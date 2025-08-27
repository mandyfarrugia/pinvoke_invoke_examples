#include <math.h>

extern "C" {
    /// @brief 
    /// @param first_addend 
    /// @param second_addend 
    /// @return 
    __declspec (dllexport) int __cdecl add(int first_addend, int second_addend) {
        return first_addend + second_addend;
    }

    /// @brief 
    /// @param minuend 
    /// @param subtrahend 
    /// @return 
    __declspec (dllexport) int __cdecl subtract(int minuend, int subtrahend) {
        return minuend - subtrahend;
    }

    /// @brief 
    /// @param multiplicand 
    /// @param multiplier 
    /// @return 
    __declspec (dllexport) int __cdecl multiply(int multiplicand, int multiplier) {
        return multiplicand * multiplier;
    }

    /// @brief 
    /// @param dividend 
    /// @param divisor 
    /// @return 
    __declspec (dllexport) double __cdecl divide(int dividend, int divisor) {
        if (divisor == 0) return -1;
        return static_cast<double>(dividend) / divisor;
    }

    /// @brief 
    /// @param base 
    /// @param exponent 
    /// @return 
    __declspec (dllexport) double __cdecl power(double base, double exponent) {
        return pow(base, exponent);
    }

    /// @brief 
    /// @param value 
    /// @return 
    __declspec (dllexport) double __cdecl square_root(double value) {
        if (value < 0) return -1;
        return sqrt(value);
    }

    /// @brief 
    /// @param hypotenuse 
    /// @param base 
    /// @return 
    __declspec (dllexport) double __cdecl find_perpendicular(double hypotenuse, double base) {
        return sqrt(power(hypotenuse, 2) - power(base, 2));
    }

    /// @brief 
    /// @param hypotenuse 
    /// @param perpendicular 
    /// @return 
    __declspec (dllexport) double __cdecl find_base(double hypotenuse, double perpendicular) {
        return sqrt(power(hypotenuse, 2) - power(perpendicular, 2));
    }

    /// @brief 
    /// @param perpendicular 
    /// @param base 
    /// @return 
    __declspec (dllexport) double __cdecl find_hypotenuse(double perpendicular, double base) {
        return sqrt(power(perpendicular, 2) + power(base, 2));
    }
}