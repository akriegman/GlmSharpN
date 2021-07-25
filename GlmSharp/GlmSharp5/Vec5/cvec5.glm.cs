using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using GlmSharp.Swizzle;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    /// <summary>
    /// Static class that contains static glm functions
    /// </summary>
    public static partial class glm
    {
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public static swizzle_cvec5 swizzle(cvec5 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static Complex[] Values(cvec5 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<Complex> GetEnumerator(cvec5 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(cvec5 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(cvec5 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(cvec5 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(cvec5 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(cvec5 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public static int Count(cvec5 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(cvec5 v, cvec5 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(cvec5 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(cvec5 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(cvec5 lhs, cvec5 rhs, double eps = 0.1d) => cvec5.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(cvec5 lhs, cvec5 rhs) => cvec5.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(cvec5 lhs, cvec5 rhs) => cvec5.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Abs (v.Magnitude).
        /// </summary>
        public static dvec5 Abs(cvec5 v) => cvec5.Abs(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static cvec5 HermiteInterpolationOrder3(cvec5 v) => cvec5.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static cvec5 HermiteInterpolationOrder5(cvec5 v) => cvec5.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static cvec5 Sqr(cvec5 v) => cvec5.Sqr(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static cvec5 Pow2(cvec5 v) => cvec5.Pow2(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static cvec5 Pow3(cvec5 v) => cvec5.Pow3(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Acos (Complex.Acos(v)).
        /// </summary>
        public static cvec5 Acos(cvec5 v) => cvec5.Acos(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Asin (Complex.Asin(v)).
        /// </summary>
        public static cvec5 Asin(cvec5 v) => cvec5.Asin(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Atan (Complex.Atan(v)).
        /// </summary>
        public static cvec5 Atan(cvec5 v) => cvec5.Atan(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Cos (Complex.Cos(v)).
        /// </summary>
        public static cvec5 Cos(cvec5 v) => cvec5.Cos(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Cosh (Complex.Cosh(v)).
        /// </summary>
        public static cvec5 Cosh(cvec5 v) => cvec5.Cosh(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Exp (Complex.Exp(v)).
        /// </summary>
        public static cvec5 Exp(cvec5 v) => cvec5.Exp(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Log (Complex.Log(v)).
        /// </summary>
        public static cvec5 Log(cvec5 v) => cvec5.Log(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Log2 (Complex.Log(v, 2.0)).
        /// </summary>
        public static cvec5 Log2(cvec5 v) => cvec5.Log2(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Log10 (Complex.Log10(v)).
        /// </summary>
        public static cvec5 Log10(cvec5 v) => cvec5.Log10(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Reciprocal (Complex.Reciprocal(v)).
        /// </summary>
        public static cvec5 Reciprocal(cvec5 v) => cvec5.Reciprocal(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sin (Complex.Sin(v)).
        /// </summary>
        public static cvec5 Sin(cvec5 v) => cvec5.Sin(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sinh (Complex.Sinh(v)).
        /// </summary>
        public static cvec5 Sinh(cvec5 v) => cvec5.Sinh(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sqrt (Complex.Sqrt(v)).
        /// </summary>
        public static cvec5 Sqrt(cvec5 v) => cvec5.Sqrt(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of InverseSqrt (Complex.One / Complex.Sqrt(v)).
        /// </summary>
        public static cvec5 InverseSqrt(cvec5 v) => cvec5.InverseSqrt(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Tan (Complex.Tan(v)).
        /// </summary>
        public static cvec5 Tan(cvec5 v) => cvec5.Tan(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Tanh (Complex.Tanh(v)).
        /// </summary>
        public static cvec5 Tanh(cvec5 v) => cvec5.Tanh(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Conjugate (Complex.Conjugate(v)).
        /// </summary>
        public static cvec5 Conjugate(cvec5 v) => cvec5.Conjugate(v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec5 Pow(cvec5 lhs, cvec5 rhs) => cvec5.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec5 Log(cvec5 lhs, dvec5 rhs) => cvec5.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec5 FromPolarCoordinates(dvec5 magnitude, dvec5 phase) => cvec5.FromPolarCoordinates(magnitude, phase);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static cvec5 Fma(cvec5 a, cvec5 b, cvec5 c) => cvec5.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat2x5 OuterProduct(cvec5 c, cvec2 r) => cvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat3x5 OuterProduct(cvec5 c, cvec3 r) => cvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat4x5 OuterProduct(cvec5 c, cvec4 r) => cvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat5 OuterProduct(cvec5 c, cvec5 r) => cvec5.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static cvec5 Add(cvec5 lhs, cvec5 rhs) => cvec5.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static cvec5 Sub(cvec5 lhs, cvec5 rhs) => cvec5.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static cvec5 Mul(cvec5 lhs, cvec5 rhs) => cvec5.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static cvec5 Div(cvec5 lhs, cvec5 rhs) => cvec5.Div(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(cvec5 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(cvec5 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static Complex Sum(cvec5 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(cvec5 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(cvec5 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(cvec5 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(cvec5 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(cvec5 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static cvec5 Normalized(cvec5 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static cvec5 NormalizedSafe(cvec5 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns a vector containing component-wise magnitudes.
        /// </summary>
        public static dvec5 Magnitude(cvec5 v) => v.Magnitude;
        
        /// <summary>
        /// Returns a vector containing component-wise phases.
        /// </summary>
        public static dvec5 Phase(cvec5 v) => v.Phase;
        
        /// <summary>
        /// Returns a vector containing component-wise imaginary parts.
        /// </summary>
        public static dvec5 Imaginary(cvec5 v) => v.Imaginary;
        
        /// <summary>
        /// Returns a vector containing component-wise real parts.
        /// </summary>
        public static dvec5 Real(cvec5 v) => v.Real;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static Complex Dot(cvec5 lhs, cvec5 rhs) => cvec5.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(cvec5 lhs, cvec5 rhs) => cvec5.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(cvec5 lhs, cvec5 rhs) => cvec5.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static cvec5 Reflect(cvec5 I, cvec5 N) => cvec5.Reflect(I, N);

    }
}
