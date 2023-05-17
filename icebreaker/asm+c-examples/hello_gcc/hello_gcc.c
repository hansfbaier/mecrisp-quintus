
// -----------------------------------------------------------------------------
//   Now go on with C
// -----------------------------------------------------------------------------

#include <stdint.h>
#include <stdarg.h>

// -----------------------------------------------------------------------------
//   LEDs & Buttons
// -----------------------------------------------------------------------------

#define PORT_IN   *(volatile uint32_t  *) 0x400010
#define PORT_OUT  *(volatile uint32_t  *) 0x400020
#define PORT_DIR  *(volatile uint32_t  *) 0x400040
#define LEDS      *(volatile uint32_t  *) 0x400080

// -----------------------------------------------------------------------------
//   Timing
// -----------------------------------------------------------------------------

#define CYCLES_US    12
#define CYCLES_MS 12000

uint32_t cycles(void)
{
  uint32_t ticks;
  asm volatile ("rdcycle %0" : "=r"(ticks));
  return ticks;
}

void delay_cycles(uint32_t time)
{
  uint32_t now = cycles();
  while ( (cycles() - now) < time ) {};
}

void us(uint32_t time)
{
  delay_cycles(time * CYCLES_US);
}

void ms(uint32_t time)
{
  delay_cycles(time * CYCLES_MS);
}

// -----------------------------------------------------------------------------
//   Terminal IO
// -----------------------------------------------------------------------------

#define UART_DATA  *(volatile uint8_t  *) 0x410000
#define UART_FLAGS *(volatile uint32_t *) 0x420000

uint32_t keypressed(void)
{
  return 0x100 & UART_FLAGS ? -1 : 0;
}

uint8_t getchar(void)
{
  while ( 0x100 & ~UART_FLAGS) {};
  return UART_DATA;
}

void putchar(uint8_t character)
{
  while ( 0x200 & UART_FLAGS) {};
  UART_DATA = character;
}

// -----------------------------------------------------------------------------
//   Random numbers
// -----------------------------------------------------------------------------

uint32_t randombit(void)
{
  delay_cycles(100);
  return PORT_IN >> 24;
}

uint32_t random(void)
{
  uint32_t randombits = 0;
  for (uint32_t i = 0; i < 32; i++)
  {
    randombits = randombits << 1 | randombit();
  }
  return randombits;
}

// -----------------------------------------------------------------------------
//   Pretty printing
// -----------------------------------------------------------------------------

void print_string(const char* s) {
   for(const char* p = s; *p; ++p) {
      putchar(*p);
   }
}

int puts(const char* s) {
   print_string(s);
   putchar('\n');
   return 1;
}

void print_dec(int val) {
   char buffer[255];
   char *p = buffer;
   if(val < 0) {
      putchar('-');
      print_dec(-val);
      return;
   }
   while (val || p == buffer) {
      *(p++) = val % 10;
      val = val / 10;
   }
   while (p != buffer) {
      putchar('0' + *(--p));
   }
}

void print_hex_digits(unsigned int val, int nbdigits) {
   for (int i = (4*nbdigits)-4; i >= 0; i -= 4) {
      putchar("0123456789ABCDEF"[(val >> i) % 16]);
   }
}

void print_hex(unsigned int val) {
   print_hex_digits(val, 8);
}

// -----------------------------------------------------------------------------
//   Formated printing
// -----------------------------------------------------------------------------

int printf(const char *fmt,...)
{
    va_list ap;

    for(va_start(ap, fmt);*fmt;fmt++)
    {
        if(*fmt=='%')
        {
            fmt++;
                 if(*fmt=='s') print_string(va_arg(ap,char *));
            else if(*fmt=='x') print_hex(va_arg(ap,int));
            else if(*fmt=='d') print_dec(va_arg(ap,int));
            else if(*fmt=='c') putchar(va_arg(ap,int));
            else putchar(*fmt);
        }
        else putchar(*fmt);
    }

    va_end(ap);

    return 0;
}

// -----------------------------------------------------------------------------
//   Main
// -----------------------------------------------------------------------------

void main(void)
{
  putchar(10);
  puts("RISC-V Playground");
  printf("Most recent random number: 0x%x.\n", random());
  putchar(10);

  while (1)
  {
    if (keypressed())
    {
      uint32_t character = getchar();
      putchar(character);

      printf(" Character %d received.\n", character);
      LEDS = character;
    }
  }
}
