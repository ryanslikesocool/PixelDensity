# PixelDensity
Quick access to iOS screen pixel density (@1x, @2x, @3x) for Unity.

## Requirements
- A recent version of Unity
- An iOS device

## Installation

**Recommended Installation**\
Add via the Unity Package Manager\
"Add package from git URL..."\
https://github.com/ryanslikesocool/PixelDensity.git \
Add

Not-so Recommended Installation\
Get the latest release\
Open with the desired Unity project\
Import into the Plugins folder

## Usage
Use the `PixelDensity.Scale` accessor anywhere in your code to get an iOS device's [scale](https://developer.apple.com/documentation/uikit/uiscreen/1617836-scale) as an `int`.  A non-iOS device will return `1`.

```cs
int scale = PixelDensity.Scale;
// on an older iPhone/iPad display or any non-iOS display -> scale == 1
// on a "retina" display -> scale == 2
// on a "super retina" display -> scale == 3
```
