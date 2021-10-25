// Developed with love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.InteropServices;

public static class PixelDensity
{
#if UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX || UNITY_IOS
    [DllImport("__Internal")]
    private static extern int getPixelDensity();

    public static int Scale => getPixelDensity();
#else 
    public static int Scale => 1;
#endif
}