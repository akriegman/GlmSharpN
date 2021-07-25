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
        public static swizzle_dvec5 swizzle(dvec5 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static double[] Values(dvec5 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<double> GetEnumerator(dvec5 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(dvec5 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(dvec5 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(dvec5 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(dvec5 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(dvec5 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public static int Count(dvec5 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(dvec5 v, dvec5 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(dvec5 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(dvec5 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(dvec5 lhs, dvec5 rhs, double eps = 0.1d) => dvec5.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(dvec5 lhs, dvec5 rhs) => dvec5.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(dvec5 lhs, dvec5 rhs) => dvec5.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(dvec5 lhs, dvec5 rhs) => dvec5.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(dvec5 lhs, dvec5 rhs) => dvec5.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(dvec5 lhs, dvec5 rhs) => dvec5.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(dvec5 lhs, dvec5 rhs) => dvec5.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsInfinity(dvec5 v) => dvec5.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsFinite(dvec5 v) => dvec5.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bvec5 IsNaN(dvec5 v) => dvec5.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec5 IsNegativeInfinity(dvec5 v) => dvec5.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec5 IsPositiveInfinity(dvec5 v) => dvec5.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static dvec5 Abs(dvec5 v) => dvec5.Abs(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static dvec5 HermiteInterpolationOrder3(dvec5 v) => dvec5.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static dvec5 HermiteInterpolationOrder5(dvec5 v) => dvec5.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static dvec5 Sqr(dvec5 v) => dvec5.Sqr(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static dvec5 Pow2(dvec5 v) => dvec5.Pow2(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static dvec5 Pow3(dvec5 v) => dvec5.Pow3(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static dvec5 Step(dvec5 v) => dvec5.Step(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sqrt ((double)Math.Sqrt((double)v)).
        /// </summary>
        public static dvec5 Sqrt(dvec5 v) => dvec5.Sqrt(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of InverseSqrt ((double)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static dvec5 InverseSqrt(dvec5 v) => dvec5.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(dvec5 v) => dvec5.Sign(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec5 Max(dvec5 lhs, dvec5 rhs) => dvec5.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec5 Min(dvec5 lhs, dvec5 rhs) => dvec5.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec5 Pow(dvec5 lhs, dvec5 rhs) => dvec5.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec5 Log(dvec5 lhs, dvec5 rhs) => dvec5.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec5 Clamp(dvec5 v, dvec5 min, dvec5 max) => dvec5.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Mix(dvec5 min, dvec5 max, dvec5 a) => dvec5.Mix(min, max, a);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Lerp(dvec5 min, dvec5 max, dvec5 a) => dvec5.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec5 Smoothstep(dvec5 edge0, dvec5 edge1, dvec5 v) => dvec5.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec5 Smootherstep(dvec5 edge0, dvec5 edge1, dvec5 v) => dvec5.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec5 Fma(dvec5 a, dvec5 b, dvec5 c) => dvec5.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat2x5 OuterProduct(dvec5 c, dvec2 r) => dvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat3x5 OuterProduct(dvec5 c, dvec3 r) => dvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat4x5 OuterProduct(dvec5 c, dvec4 r) => dvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat5 OuterProduct(dvec5 c, dvec5 r) => dvec5.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec5 Add(dvec5 lhs, dvec5 rhs) => dvec5.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec5 Sub(dvec5 lhs, dvec5 rhs) => dvec5.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec5 Mul(dvec5 lhs, dvec5 rhs) => dvec5.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec5 Div(dvec5 lhs, dvec5 rhs) => dvec5.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec5 Modulo(dvec5 lhs, dvec5 rhs) => dvec5.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static dvec5 Degrees(dvec5 v) => dvec5.Degrees(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static dvec5 Radians(dvec5 v) => dvec5.Radians(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Acos ((double)Math.Acos((double)v)).
        /// </summary>
        public static dvec5 Acos(dvec5 v) => dvec5.Acos(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Asin ((double)Math.Asin((double)v)).
        /// </summary>
        public static dvec5 Asin(dvec5 v) => dvec5.Asin(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Atan ((double)Math.Atan((double)v)).
        /// </summary>
        public static dvec5 Atan(dvec5 v) => dvec5.Atan(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Cos ((double)Math.Cos((double)v)).
        /// </summary>
        public static dvec5 Cos(dvec5 v) => dvec5.Cos(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Cosh ((double)Math.Cosh((double)v)).
        /// </summary>
        public static dvec5 Cosh(dvec5 v) => dvec5.Cosh(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Exp ((double)Math.Exp((double)v)).
        /// </summary>
        public static dvec5 Exp(dvec5 v) => dvec5.Exp(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Log ((double)Math.Log((double)v)).
        /// </summary>
        public static dvec5 Log(dvec5 v) => dvec5.Log(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Log2 ((double)Math.Log((double)v, 2)).
        /// </summary>
        public static dvec5 Log2(dvec5 v) => dvec5.Log2(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Log10 ((double)Math.Log10((double)v)).
        /// </summary>
        public static dvec5 Log10(dvec5 v) => dvec5.Log10(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Floor ((double)Math.Floor(v)).
        /// </summary>
        public static dvec5 Floor(dvec5 v) => dvec5.Floor(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Ceiling ((double)Math.Ceiling(v)).
        /// </summary>
        public static dvec5 Ceiling(dvec5 v) => dvec5.Ceiling(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Round ((double)Math.Round(v)).
        /// </summary>
        public static dvec5 Round(dvec5 v) => dvec5.Round(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sin ((double)Math.Sin((double)v)).
        /// </summary>
        public static dvec5 Sin(dvec5 v) => dvec5.Sin(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sinh ((double)Math.Sinh((double)v)).
        /// </summary>
        public static dvec5 Sinh(dvec5 v) => dvec5.Sinh(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Tan ((double)Math.Tan((double)v)).
        /// </summary>
        public static dvec5 Tan(dvec5 v) => dvec5.Tan(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Tanh ((double)Math.Tanh((double)v)).
        /// </summary>
        public static dvec5 Tanh(dvec5 v) => dvec5.Tanh(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Truncate ((double)Math.Truncate((double)v)).
        /// </summary>
        public static dvec5 Truncate(dvec5 v) => dvec5.Truncate(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Fract ((double)(v - Math.Floor(v))).
        /// </summary>
        public static dvec5 Fract(dvec5 v) => dvec5.Fract(v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static dvec5 Trunc(dvec5 v) => dvec5.Trunc(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static double MinElement(dvec5 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static double MaxElement(dvec5 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(dvec5 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(dvec5 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static double Sum(dvec5 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(dvec5 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(dvec5 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(dvec5 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(dvec5 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(dvec5 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static dvec5 Normalized(dvec5 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static dvec5 NormalizedSafe(dvec5 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(dvec5 lhs, dvec5 rhs) => dvec5.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(dvec5 lhs, dvec5 rhs) => dvec5.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(dvec5 lhs, dvec5 rhs) => dvec5.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec5 Reflect(dvec5 I, dvec5 N) => dvec5.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec5 Refract(dvec5 I, dvec5 N, double eta) => dvec5.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static dvec5 FaceForward(dvec5 N, dvec5 I, dvec5 Nref) => dvec5.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec5 Random(Random random, dvec5 minValue, dvec5 maxValue) => dvec5.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec5 RandomUniform(Random random, dvec5 minValue, dvec5 maxValue) => dvec5.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec5 RandomNormal(Random random, dvec5 mean, dvec5 variance) => dvec5.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec5 RandomGaussian(Random random, dvec5 mean, dvec5 variance) => dvec5.RandomGaussian(random, mean, variance);

    }
}
