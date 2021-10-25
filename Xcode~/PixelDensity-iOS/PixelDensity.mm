// Developed with love by Ryan Boyer http://ryanjboyer.com <3

#include "PixelDensity.h"

extern "C" {
	int getPixelDensity() {
		return UIScreen.mainScreen.scale;
	}
}
