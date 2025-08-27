using System.Runtime.InteropServices;

namespace MiniCalculator.Native
{
    /// <summary>
    /// A static class that provides interop wrappers for native functions in a DLL.
    /// </summary>
    internal static class InteropWrapper
    {
        /// <summary>
        /// The name of the native DLL containing the functions to be imported.
        /// </summary>
        private const string DLL_NAME = "native_lib.dll";

        /// <summary>
        /// Adds two integers.
        /// </summary>
        /// <param name="first_addend">The first integer to add.</param>
        /// <param name="second_addend">The second integer to add to the first integer.</param>
        /// <returns>The sum of first_addend and second_addend.</returns>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double add(double first_addend, double second_addend);

        /// <summary>
        /// Subtracts one integer from another.
        /// </summary>
        /// <param name="minuend">The integer from which to subtract.</param>
        /// <param name="subtrahend">The integer to subtract.</param>
        /// <returns>The result of minuend minus subtrahend.</returns>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double subtract(double minuend, double subtrahend);

        /// <summary>
        /// Multiplies two integers.
        /// </summary>
        /// <param name="multiplicand">The integer to be multiplied.</param>
        /// <param name="multiplier">The integer to multiply by.</param>
        /// <returns>The product of multiplicand and multiplier.</returns>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double multiply(double multiplicand, double multiplier);

        /// <summary>
        /// Divides one integer by another.
        /// </summary>
        /// <param name="dividend">The integer to be divided.</param>
        /// <param name="divisor">The integer to divide by.</param>
        /// <returns>The result of dividend divided by divisor as a double. Returns -1 if divisor is 0.</returns>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double divide(double dividend, double divisor);

        /// <summary>
        /// Raises a base to a given exponent.
        /// </summary>
        /// <param name="baseValue">The base value.</param>
        /// <param name="exponent">The exponent value.</param>
        /// <returns>The result of baseValue raised to the power of exponent.</returns>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double power(double baseValue, double exponent);

        /// <summary>
        /// Calculates the square root of a value.
        /// </summary>
        /// <param name="value">The value to calculate the square root of.</param>
        /// <returns>The square root of value. Returns -1 if value is negative.</returns>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double square_root(double value);

        /// <summary>
        /// Finds the length of the perpendicular side of a right triangle given the hypotenuse and base.
        /// </summary>
        /// <param name="hypotenuse_length">The length of the hypotenuse.</param>
        /// <param name="base_length">The length of the base.</param>
        /// <returns>The length of the perpendicular side.</returns>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double find_perpendicular(double hypotenuse_length, double base_length);

        /// <summary>
        /// Finds the length of the base of a right triangle given the hypotenuse and perpendicular.
        /// </summary>
        /// <param name="hypotenuse_length">The length of the hypotenuse.</param>
        /// <param name="perpendicular_length">The length of the perpendicular side.</param>
        /// <returns>The length of the base.</returns>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double find_base(double hypotenuse_length, double perpendicular_length);

        /// <summary>
        /// Finds the length of the hypotenuse of a right triangle given the base and perpendicular.
        /// </summary>
        /// <param name="base_length">The length of the base.</param>
        /// <param name="perpendicular_length">The length of the perpendicular side.</param>
        /// <returns>The length of the hypotenuse.</returns>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern double find_hypotenuse(double base_length, double perpendicular_length);
    }
}