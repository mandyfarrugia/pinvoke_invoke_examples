public class InteropWrapper
{
    private const string DllName = "native_lib.dll";

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int add(int a, int b);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int subtract(int a, int b);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern double multiply(double a, double b);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern double divide(int dividend, int divisor);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern double power(double baseValue, double exponent);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern double square_root(double value);
}