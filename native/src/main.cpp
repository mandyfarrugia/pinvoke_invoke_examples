#include <math.h> //Include math.h to invoke built-in C++ mathematical functions like pow and sqrt.

extern "C" {
    /// @brief Adds two numbers.
    /// @param first_addend The first number to add.
    /// @param second_addend The second number to add.
    /// @return The sum of first_addend and second_addend as a double.
    __declspec (dllexport) double __cdecl add(double first_addend, double second_addend) {
        return first_addend + second_addend;
    }

    /// @brief Subtracts one number from another.
    /// @param minuend The number from which to subtract.
    /// @param subtrahend The number to subtract.
    /// @return The result of minuend minus subtrahend as a double.
    __declspec (dllexport) double __cdecl subtract(double minuend, double subtrahend) {
        return minuend - subtrahend;
    }

    /// @brief Multiplies two numbers.
    /// @param multiplicand The number to be multiplied.
    /// @param multiplier The number to multiply by.
    /// @return The product of multiplicand and multiplier as a double.
    __declspec (dllexport) double __cdecl multiply(double multiplicand, double multiplier) {
        return multiplicand * multiplier;
    }

    /// @brief Divides one number by another.
    /// @param dividend The number to be divided.
    /// @param divisor The number to divide by.
    /// @return The result of dividend divided by divisor as a double. Returns -1 if divisor is 0.
    __declspec (dllexport) double __cdecl divide(double dividend, double divisor) {
        if (divisor == 0) return -1; //Return -1 for division by zero to indicate error.
        return dividend / divisor; //Safe to perform division now, convert the dividend to double for accurate division.
    }

    /// @brief Raises a base to a given exponent.
    /// @param base The base value (double).
    /// @param exponent The exponent value (double).
    /// @return The result of base raised to the power of exponent as a double.
    __declspec (dllexport) double __cdecl power(double base, double exponent) {
        return pow(base, exponent);
    }

    /// @brief Calculates the square root of a value.
    /// @param value The value (double) to calculate the square root of.
    /// @return The square root of value as a double. Returns -1 if value is negative.
    __declspec (dllexport) double __cdecl square_root(double value) {
        if (value < 0) return -1; //Return -1 for negative inputs to indicate error.
        return sqrt(value);
    }

    /// @brief Finds the length of the perpendicular side of a right triangle given the hypotenuse and base.
    /// @param hypotenuse The length of the hypotenuse (double).
    /// @param base The length of the base (double).
    /// @return The length of the perpendicular side as a double.
    __declspec (dllexport) double __cdecl find_perpendicular(double hypotenuse, double base) {
        return square_root(power(hypotenuse, 2) - power(base, 2));
    }

    /// @brief Finds the length of the base of a right triangle given the hypotenuse and perpendicular.
    /// @param hypotenuse The length of the hypotenuse (double).
    /// @param perpendicular The length of the perpendicular side (double).
    /// @return The length of the base as a double.
    __declspec (dllexport) double __cdecl find_base(double hypotenuse, double perpendicular) {
        return square_root(power(hypotenuse, 2) - power(perpendicular, 2));
    }

    /// @brief Finds the length of the hypotenuse of a right triangle given the perpendicular and base.
    /// @param perpendicular The length of the perpendicular side (double).
    /// @param base The length of the base (double).
    /// @return The length of the hypotenuse as a double.
    __declspec (dllexport) double __cdecl find_hypotenuse(double perpendicular, double base) {
        return square_root(power(perpendicular, 2) + power(base, 2));
    }
}