using System.Runtime.InteropServices;

namespace Native
{
    public static class InteropWrapper
    {
        private const string DllName = "native_lib.dll";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="first_addend"></param>
        /// <param name="second_addend"></param>
        /// <returns></returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int add(int first_addend, int second_addend);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int subtract(int minuend, int subtrahend);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="multiplicand"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern double multiply(int multiplicand, int multiplier);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern double divide(int dividend, int divisor);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseValue"></param>
        /// <param name="exponent"></param>
        /// <returns></returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern double power(double baseValue, double exponent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern double square_root(double value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hypotenuse_length"></param>
        /// <param name="base_length"></param>
        /// <returns></returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern double find_perpendicular(double hypotenuse_length, double base_length);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hypotenuse_length"></param>
        /// <param name="perpendicular_length"></param>
        /// <returns></returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern double find_base(double hypotenuse_length, double perpendicular_length);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="base_length"></param>
        /// <param name="perpendicular_length"></param>
        /// <returns></returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern double find_hypotenuse(double base_length, double perpendicular_length);
    }
}