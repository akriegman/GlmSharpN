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
        public static swizzle_decvec5 swizzle(decvec5 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static decimal[] Values(decvec5 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<decimal> GetEnumerator(decvec5 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(decvec5 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(decvec5 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(decvec5 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(decvec5 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(decvec5 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public static int Count(decvec5 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(decvec5 v, decvec5 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(decvec5 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(decvec5 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(decvec5 lhs, decvec5 rhs, decimal eps = 0.1m) => decvec5.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(decvec5 lhs, decvec5 rhs) => decvec5.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(decvec5 lhs, decvec5 rhs) => decvec5.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(decvec5 lhs, decvec5 rhs) => decvec5.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(decvec5 lhs, decvec5 rhs) => decvec5.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(decvec5 lhs, decvec5 rhs) => decvec5.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(decvec5 lhs, decvec5 rhs) => decvec5.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static decvec5 Abs(decvec5 v) => decvec5.Abs(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static decvec5 HermiteInterpolationOrder3(decvec5 v) => decvec5.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static decvec5 HermiteInterpolationOrder5(decvec5 v) => decvec5.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static decvec5 Sqr(decvec5 v) => decvec5.Sqr(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static decvec5 Pow2(decvec5 v) => decvec5.Pow2(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static decvec5 Pow3(decvec5 v) => decvec5.Pow3(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Step (v &gt;= 0m ? 1m : 0m).
        /// </summary>
        public static decvec5 Step(decvec5 v) => decvec5.Step(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sqrt ((decimal)Math.Sqrt((double)v)).
        /// </summary>
        public static decvec5 Sqrt(decvec5 v) => decvec5.Sqrt(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of InverseSqrt ((decimal)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static decvec5 InverseSqrt(decvec5 v) => decvec5.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(decvec5 v) => decvec5.Sign(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec5 Max(decvec5 lhs, decvec5 rhs) => decvec5.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec5 Min(decvec5 lhs, decvec5 rhs) => decvec5.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec5 Pow(decvec5 lhs, decvec5 rhs) => decvec5.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec5 Log(decvec5 lhs, decvec5 rhs) => decvec5.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec5 Clamp(decvec5 v, decvec5 min, decvec5 max) => decvec5.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Mix(decvec5 min, decvec5 max, decvec5 a) => decvec5.Mix(min, max, a);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Lerp(decvec5 min, decvec5 max, decvec5 a) => decvec5.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec5 Smoothstep(decvec5 edge0, decvec5 edge1, decvec5 v) => decvec5.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec5 Smootherstep(decvec5 edge0, decvec5 edge1, decvec5 v) => decvec5.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec5 Fma(decvec5 a, decvec5 b, decvec5 c) => decvec5.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat2x5 OuterProduct(decvec5 c, decvec2 r) => decvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat3x5 OuterProduct(decvec5 c, decvec3 r) => decvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat4x5 OuterProduct(decvec5 c, decvec4 r) => decvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat5 OuterProduct(decvec5 c, decvec5 r) => decvec5.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec5 Add(decvec5 lhs, decvec5 rhs) => decvec5.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec5 Sub(decvec5 lhs, decvec5 rhs) => decvec5.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec5 Mul(decvec5 lhs, decvec5 rhs) => decvec5.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec5 Div(decvec5 lhs, decvec5 rhs) => decvec5.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec5 Modulo(decvec5 lhs, decvec5 rhs) => decvec5.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static decvec5 Degrees(decvec5 v) => decvec5.Degrees(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static decvec5 Radians(decvec5 v) => decvec5.Radians(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Acos ((decimal)Math.Acos((double)v)).
        /// </summary>
        public static decvec5 Acos(decvec5 v) => decvec5.Acos(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Asin ((decimal)Math.Asin((double)v)).
        /// </summary>
        public static decvec5 Asin(decvec5 v) => decvec5.Asin(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Atan ((decimal)Math.Atan((double)v)).
        /// </summary>
        public static decvec5 Atan(decvec5 v) => decvec5.Atan(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Cos ((decimal)Math.Cos((double)v)).
        /// </summary>
        public static decvec5 Cos(decvec5 v) => decvec5.Cos(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Cosh ((decimal)Math.Cosh((double)v)).
        /// </summary>
        public static decvec5 Cosh(decvec5 v) => decvec5.Cosh(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Exp ((decimal)Math.Exp((double)v)).
        /// </summary>
        public static decvec5 Exp(decvec5 v) => decvec5.Exp(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Log ((decimal)Math.Log((double)v)).
        /// </summary>
        public static decvec5 Log(decvec5 v) => decvec5.Log(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Log2 ((decimal)Math.Log((double)v, 2)).
        /// </summary>
        public static decvec5 Log2(decvec5 v) => decvec5.Log2(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Log10 ((decimal)Math.Log10((double)v)).
        /// </summary>
        public static decvec5 Log10(decvec5 v) => decvec5.Log10(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Floor ((decimal)Math.Floor(v)).
        /// </summary>
        public static decvec5 Floor(decvec5 v) => decvec5.Floor(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Ceiling ((decimal)Math.Ceiling(v)).
        /// </summary>
        public static decvec5 Ceiling(decvec5 v) => decvec5.Ceiling(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Round ((decimal)Math.Round(v)).
        /// </summary>
        public static decvec5 Round(decvec5 v) => decvec5.Round(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sin ((decimal)Math.Sin((double)v)).
        /// </summary>
        public static decvec5 Sin(decvec5 v) => decvec5.Sin(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sinh ((decimal)Math.Sinh((double)v)).
        /// </summary>
        public static decvec5 Sinh(decvec5 v) => decvec5.Sinh(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Tan ((decimal)Math.Tan((double)v)).
        /// </summary>
        public static decvec5 Tan(decvec5 v) => decvec5.Tan(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Tanh ((decimal)Math.Tanh((double)v)).
        /// </summary>
        public static decvec5 Tanh(decvec5 v) => decvec5.Tanh(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Truncate ((decimal)Math.Truncate((double)v)).
        /// </summary>
        public static decvec5 Truncate(decvec5 v) => decvec5.Truncate(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Fract ((decimal)(v - Math.Floor(v))).
        /// </summary>
        public static decvec5 Fract(decvec5 v) => decvec5.Fract(v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static decvec5 Trunc(decvec5 v) => decvec5.Trunc(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static decimal MinElement(decvec5 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static decimal MaxElement(decvec5 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static decimal Length(decvec5 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static decimal LengthSqr(decvec5 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static decimal Sum(decvec5 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static decimal Norm(decvec5 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static decimal Norm1(decvec5 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static decimal Norm2(decvec5 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static decimal NormMax(decvec5 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(decvec5 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static decvec5 Normalized(decvec5 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static decvec5 NormalizedSafe(decvec5 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static decimal Dot(decvec5 lhs, decvec5 rhs) => decvec5.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static decimal Distance(decvec5 lhs, decvec5 rhs) => decvec5.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static decimal DistanceSqr(decvec5 lhs, decvec5 rhs) => decvec5.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec5 Reflect(decvec5 I, decvec5 N) => decvec5.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec5 Refract(decvec5 I, decvec5 N, decimal eta) => decvec5.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static decvec5 FaceForward(decvec5 N, decvec5 I, decvec5 Nref) => decvec5.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec5 Random(Random random, decvec5 minValue, decvec5 maxValue) => decvec5.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec5 RandomUniform(Random random, decvec5 minValue, decvec5 maxValue) => decvec5.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec5 RandomNormal(Random random, decvec5 mean, decvec5 variance) => decvec5.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec5 RandomGaussian(Random random, decvec5 mean, decvec5 variance) => decvec5.RandomGaussian(random, mean, variance);

    }
}
