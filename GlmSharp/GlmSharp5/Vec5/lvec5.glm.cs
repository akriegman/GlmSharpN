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
        public static swizzle_lvec5 swizzle(lvec5 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static long[] Values(lvec5 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<long> GetEnumerator(lvec5 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(lvec5 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(lvec5 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(lvec5 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(lvec5 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(lvec5 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public static int Count(lvec5 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(lvec5 v, lvec5 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(lvec5 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(lvec5 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(lvec5 lhs, lvec5 rhs) => lvec5.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(lvec5 lhs, lvec5 rhs) => lvec5.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(lvec5 lhs, lvec5 rhs) => lvec5.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(lvec5 lhs, lvec5 rhs) => lvec5.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(lvec5 lhs, lvec5 rhs) => lvec5.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(lvec5 lhs, lvec5 rhs) => lvec5.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static lvec5 Abs(lvec5 v) => lvec5.Abs(v);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static lvec5 HermiteInterpolationOrder3(lvec5 v) => lvec5.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static lvec5 HermiteInterpolationOrder5(lvec5 v) => lvec5.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static lvec5 Sqr(lvec5 v) => lvec5.Sqr(v);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static lvec5 Pow2(lvec5 v) => lvec5.Pow2(v);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static lvec5 Pow3(lvec5 v) => lvec5.Pow3(v);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static lvec5 Step(lvec5 v) => lvec5.Step(v);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Sqrt ((long)Math.Sqrt((double)v)).
        /// </summary>
        public static lvec5 Sqrt(lvec5 v) => lvec5.Sqrt(v);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of InverseSqrt ((long)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static lvec5 InverseSqrt(lvec5 v) => lvec5.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(lvec5 v) => lvec5.Sign(v);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static lvec5 Max(lvec5 lhs, lvec5 rhs) => lvec5.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static lvec5 Min(lvec5 lhs, lvec5 rhs) => lvec5.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Pow ((long)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec5 Pow(lvec5 lhs, lvec5 rhs) => lvec5.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Log ((long)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec5 Log(lvec5 lhs, lvec5 rhs) => lvec5.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec5 Clamp(lvec5 v, lvec5 min, lvec5 max) => lvec5.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec5 Mix(lvec5 min, lvec5 max, lvec5 a) => lvec5.Mix(min, max, a);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec5 Lerp(lvec5 min, lvec5 max, lvec5 a) => lvec5.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec5 Smoothstep(lvec5 edge0, lvec5 edge1, lvec5 v) => lvec5.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec5 Smootherstep(lvec5 edge0, lvec5 edge1, lvec5 v) => lvec5.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static lvec5 Fma(lvec5 a, lvec5 b, lvec5 c) => lvec5.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat2x5 OuterProduct(lvec5 c, lvec2 r) => lvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat3x5 OuterProduct(lvec5 c, lvec3 r) => lvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat4x5 OuterProduct(lvec5 c, lvec4 r) => lvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat5 OuterProduct(lvec5 c, lvec5 r) => lvec5.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static lvec5 Add(lvec5 lhs, lvec5 rhs) => lvec5.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static lvec5 Sub(lvec5 lhs, lvec5 rhs) => lvec5.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static lvec5 Mul(lvec5 lhs, lvec5 rhs) => lvec5.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static lvec5 Div(lvec5 lhs, lvec5 rhs) => lvec5.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static lvec5 Xor(lvec5 lhs, lvec5 rhs) => lvec5.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static lvec5 BitwiseOr(lvec5 lhs, lvec5 rhs) => lvec5.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static lvec5 BitwiseAnd(lvec5 lhs, lvec5 rhs) => lvec5.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static lvec5 LeftShift(lvec5 lhs, ivec5 rhs) => lvec5.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec5 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static lvec5 RightShift(lvec5 lhs, ivec5 rhs) => lvec5.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static long MinElement(lvec5 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static long MaxElement(lvec5 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(lvec5 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(lvec5 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static long Sum(lvec5 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(lvec5 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(lvec5 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(lvec5 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(lvec5 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(lvec5 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static long Dot(lvec5 lhs, lvec5 rhs) => lvec5.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(lvec5 lhs, lvec5 rhs) => lvec5.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(lvec5 lhs, lvec5 rhs) => lvec5.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static lvec5 Reflect(lvec5 I, lvec5 N) => lvec5.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static lvec5 Refract(lvec5 I, lvec5 N, long eta) => lvec5.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static lvec5 FaceForward(lvec5 N, lvec5 I, lvec5 Nref) => lvec5.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a lvec5 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static lvec5 Random(Random random, lvec5 maxValue) => lvec5.Random(random, maxValue);
        
        /// <summary>
        /// Returns a lvec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec5 Random(Random random, lvec5 minValue, lvec5 maxValue) => lvec5.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a lvec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec5 RandomUniform(Random random, lvec5 minValue, lvec5 maxValue) => lvec5.RandomUniform(random, minValue, maxValue);

    }
}
