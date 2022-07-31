
/*
  Short test program to accompany fix_fft.c
*/

#define DEBUG 1
#define SPECTRUM 0

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

#include "fix_fft.c"

#define FFT_SIZE  128
#define log2FFT   7
#define N         (2 * FFT_SIZE)
#define log2N     (log2FFT + 1)
#define FREQUENCY 5
#define AMPLITUDE 12288

int main()
{
	int i, scale;
	unsigned diff;
	short x[N], fx[N];

	for (i=0; i<N; i++){
		x[i] = AMPLITUDE*cos(i*FREQUENCY*(2*3.1415926535)/N);
		if (i & 0x01)
			fx[(N+i)>>1] = x[i];
		else
			fx[i>>1] = x[i];
#if DEBUG
printf("%d %d\n", i, x[i]);
#endif
	}
puts("");

	fix_fftr(fx, log2N, 0);
#if SPECTRUM
for (i=0; i<N/2; i++) printf("%d %d\n", i, fx[i]);
return 0;
#endif
	scale = fix_fftr(fx, log2N, 1);
fprintf(stderr, "scale = %d\n", scale);

	for (i=0,diff=0; i<N; i++) {
		int sample;
		if (i & 0x01)
			sample = fx[(N+i)>>1] << scale;
		else
			sample = fx[i>>1] << scale;
#if DEBUG
printf("%d %d\n", i, sample);
#endif
		diff += abs(x[i]-sample);
	}
	fprintf(stderr, "sum(abs(diffs)))/N = %g\n", diff/(double)N);

	return 0;
}


