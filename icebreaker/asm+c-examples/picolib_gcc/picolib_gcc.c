
// -----------------------------------------------------------------------------
//   How to use a C standard library: Picolibc
// -----------------------------------------------------------------------------

// apt-get install picolibc-riscv64-unknown-elf

// https://github.com/picolibc/picolibc/blob/main/doc/using.md
// https://github.com/picolibc/picolibc/blob/main/doc/linking.md

// -----------------------------------------------------------------------------
//   Now go on with C
// -----------------------------------------------------------------------------

#include <stdio.h>
#include <sys/cdefs.h>
#include <stdint.h>
#include <stdarg.h>
#include <math.h>

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

uint8_t serial_getchar(void)
{
  while ( 0x100 & ~UART_FLAGS) {};
  return UART_DATA;
}

void serial_putchar(uint8_t character)
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
//   Wire STDIO of the library into the UART terminal
// -----------------------------------------------------------------------------

static int sample_putc(char c, FILE *file)
{
  // (void) file;         /* Not used in this function */
  serial_putchar(c);     /* Defined by underlying system */
  return c;
}

static int sample_getc(FILE *file)
  {
  unsigned char c;
  // (void) file;         /* Not used in this function */
  c = serial_getchar();  /* Defined by underlying system */
  return c;
}

static int sample_flush(FILE *file)
        {
  /* This function doesn't need to do anything */
  // (void) file;         /* Not used in this function */
  return 0;
    }

static FILE __stdio = FDEV_SETUP_STREAM(sample_putc, sample_getc, sample_flush, _FDEV_SETUP_RW);

FILE *const __iob[3] = { &__stdio, &__stdio, &__stdio };

// -----------------------------------------------------------------------------
//   Main
// -----------------------------------------------------------------------------

void main(void)
{
  putchar(10);
  puts("RISC-V Playground");
  printf("Most recent random number: 0x%X.\n", random());
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
