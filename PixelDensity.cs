// Developed with love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.InteropServices;

public static class PixelDensity
{
#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern int getPixelDensity();

    public static int Scale => getPixelDensity();
#else 
    public static int Scale => 1;
#endif
}