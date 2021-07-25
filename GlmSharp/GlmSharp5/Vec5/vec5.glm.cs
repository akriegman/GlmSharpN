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
        public static swizzle_vec5 swizzle(vec5 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static float[] Values(vec5 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<float> GetEnumerator(vec5 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(vec5 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(vec5 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(vec5 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(vec5 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(vec5 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public static int Count(vec5 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(vec5 v, vec5 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(vec5 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(vec5 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(vec5 lhs, vec5 rhs, float eps = 0.1f) => vec5.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(vec5 lhs, vec5 rhs) => vec5.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(vec5 lhs, vec5 rhs) => vec5.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(vec5 lhs, vec5 rhs) => vec5.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(vec5 lhs, vec5 rhs) => vec5.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(vec5 lhs, vec5 rhs) => vec5.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(vec5 lhs, vec5 rhs) => vec5.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsInfinity(vec5 v) => vec5.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsFinite(vec5 v) => vec5.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bvec5 IsNaN(vec5 v) => vec5.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec5 IsNegativeInfinity(vec5 v) => vec5.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec5 IsPositiveInfinity(vec5 v) => vec5.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static vec5 Abs(vec5 v) => vec5.Abs(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static vec5 HermiteInterpolationOrder3(vec5 v) => vec5.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static vec5 HermiteInterpolationOrder5(vec5 v) => vec5.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static vec5 Sqr(vec5 v) => vec5.Sqr(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static vec5 Pow2(vec5 v) => vec5.Pow2(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static vec5 Pow3(vec5 v) => vec5.Pow3(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static vec5 Step(vec5 v) => vec5.Step(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Sqrt ((float)Math.Sqrt((double)v)).
        /// </summary>
        public static vec5 Sqrt(vec5 v) => vec5.Sqrt(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of InverseSqrt ((float)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static vec5 InverseSqrt(vec5 v) => vec5.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(vec5 v) => vec5.Sign(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec5 Max(vec5 lhs, vec5 rhs) => vec5.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec5 Min(vec5 lhs, vec5 rhs) => vec5.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec5 Pow(vec5 lhs, vec5 rhs) => vec5.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec5 Log(vec5 lhs, vec5 rhs) => vec5.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec5 Clamp(vec5 v, vec5 min, vec5 max) => vec5.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec5 Mix(vec5 min, vec5 max, vec5 a) => vec5.Mix(min, max, a);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec5 Lerp(vec5 min, vec5 max, vec5 a) => vec5.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec5 Smoothstep(vec5 edge0, vec5 edge1, vec5 v) => vec5.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec5 Smootherstep(vec5 edge0, vec5 edge1, vec5 v) => vec5.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec5 Fma(vec5 a, vec5 b, vec5 c) => vec5.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat2x5 OuterProduct(vec5 c, vec2 r) => vec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat3x5 OuterProduct(vec5 c, vec3 r) => vec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat4x5 OuterProduct(vec5 c, vec4 r) => vec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat5 OuterProduct(vec5 c, vec5 r) => vec5.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static vec5 Add(vec5 lhs, vec5 rhs) => vec5.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static vec5 Sub(vec5 lhs, vec5 rhs) => vec5.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static vec5 Mul(vec5 lhs, vec5 rhs) => vec5.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static vec5 Div(vec5 lhs, vec5 rhs) => vec5.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static vec5 Modulo(vec5 lhs, vec5 rhs) => vec5.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static vec5 Degrees(vec5 v) => vec5.Degrees(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static vec5 Radians(vec5 v) => vec5.Radians(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Acos ((float)Math.Acos((double)v)).
        /// </summary>
        public static vec5 Acos(vec5 v) => vec5.Acos(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Asin ((float)Math.Asin((double)v)).
        /// </summary>
        public static vec5 Asin(vec5 v) => vec5.Asin(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Atan ((float)Math.Atan((double)v)).
        /// </summary>
        public static vec5 Atan(vec5 v) => vec5.Atan(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Cos ((float)Math.Cos((double)v)).
        /// </summary>
        public static vec5 Cos(vec5 v) => vec5.Cos(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Cosh ((float)Math.Cosh((double)v)).
        /// </summary>
        public static vec5 Cosh(vec5 v) => vec5.Cosh(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Exp ((float)Math.Exp((double)v)).
        /// </summary>
        public static vec5 Exp(vec5 v) => vec5.Exp(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Log ((float)Math.Log((double)v)).
        /// </summary>
        public static vec5 Log(vec5 v) => vec5.Log(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Log2 ((float)Math.Log((double)v, 2)).
        /// </summary>
        public static vec5 Log2(vec5 v) => vec5.Log2(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Log10 ((float)Math.Log10((double)v)).
        /// </summary>
        public static vec5 Log10(vec5 v) => vec5.Log10(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Floor ((float)Math.Floor(v)).
        /// </summary>
        public static vec5 Floor(vec5 v) => vec5.Floor(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Ceiling ((float)Math.Ceiling(v)).
        /// </summary>
        public static vec5 Ceiling(vec5 v) => vec5.Ceiling(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Round ((float)Math.Round(v)).
        /// </summary>
        public static vec5 Round(vec5 v) => vec5.Round(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Sin ((float)Math.Sin((double)v)).
        /// </summary>
        public static vec5 Sin(vec5 v) => vec5.Sin(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Sinh ((float)Math.Sinh((double)v)).
        /// </summary>
        public static vec5 Sinh(vec5 v) => vec5.Sinh(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Tan ((float)Math.Tan((double)v)).
        /// </summary>
        public static vec5 Tan(vec5 v) => vec5.Tan(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Tanh ((float)Math.Tanh((double)v)).
        /// </summary>
        public static vec5 Tanh(vec5 v) => vec5.Tanh(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Truncate ((float)Math.Truncate((double)v)).
        /// </summary>
        public static vec5 Truncate(vec5 v) => vec5.Truncate(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Fract ((float)(v - Math.Floor(v))).
        /// </summary>
        public static vec5 Fract(vec5 v) => vec5.Fract(v);
        
        /// <summary>
        /// Returns a vec5 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static vec5 Trunc(vec5 v) => vec5.Trunc(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static float MinElement(vec5 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static float MaxElement(vec5 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(vec5 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(vec5 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static float Sum(vec5 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(vec5 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(vec5 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(vec5 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(vec5 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(vec5 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static vec5 Normalized(vec5 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static vec5 NormalizedSafe(vec5 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(vec5 lhs, vec5 rhs) => vec5.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(vec5 lhs, vec5 rhs) => vec5.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(vec5 lhs, vec5 rhs) => vec5.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec5 Reflect(vec5 I, vec5 N) => vec5.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec5 Refract(vec5 I, vec5 N, float eta) => vec5.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static vec5 FaceForward(vec5 N, vec5 I, vec5 Nref) => vec5.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a vec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec5 Random(Random random, vec5 minValue, vec5 maxValue) => vec5.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a vec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec5 RandomUniform(Random random, vec5 minValue, vec5 maxValue) => vec5.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a vec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec5 RandomNormal(Random random, vec5 mean, vec5 variance) => vec5.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a vec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec5 RandomGaussian(Random random, vec5 mean, vec5 variance) => vec5.RandomGaussian(random, mean, variance);

    }
}
