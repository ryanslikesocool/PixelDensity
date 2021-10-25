// Developed with love by Ryan Boyer http://ryanjboyer.com <3

#include "PixelDensity.h"

extern "C" {
	float getPixelDensity() {
		return NSScreen.mainScreen.backingScaleFactor;
	}
}
