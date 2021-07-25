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
        public static swizzle_uvec5 swizzle(uvec5 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static uint[] Values(uvec5 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<uint> GetEnumerator(uvec5 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(uvec5 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(uvec5 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(uvec5 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(uvec5 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(uvec5 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public static int Count(uvec5 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(uvec5 v, uvec5 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(uvec5 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(uvec5 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(uvec5 lhs, uvec5 rhs) => uvec5.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(uvec5 lhs, uvec5 rhs) => uvec5.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(uvec5 lhs, uvec5 rhs) => uvec5.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(uvec5 lhs, uvec5 rhs) => uvec5.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(uvec5 lhs, uvec5 rhs) => uvec5.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(uvec5 lhs, uvec5 rhs) => uvec5.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Abs (v).
        /// </summary>
        public static uvec5 Abs(uvec5 v) => uvec5.Abs(v);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uvec5 HermiteInterpolationOrder3(uvec5 v) => uvec5.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uvec5 HermiteInterpolationOrder5(uvec5 v) => uvec5.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static uvec5 Sqr(uvec5 v) => uvec5.Sqr(v);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static uvec5 Pow2(uvec5 v) => uvec5.Pow2(v);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static uvec5 Pow3(uvec5 v) => uvec5.Pow3(v);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uvec5 Step(uvec5 v) => uvec5.Step(v);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Sqrt ((uint)Math.Sqrt((double)v)).
        /// </summary>
        public static uvec5 Sqrt(uvec5 v) => uvec5.Sqrt(v);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of InverseSqrt ((uint)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static uvec5 InverseSqrt(uvec5 v) => uvec5.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(uvec5 v) => uvec5.Sign(v);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec5 Max(uvec5 lhs, uvec5 rhs) => uvec5.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec5 Min(uvec5 lhs, uvec5 rhs) => uvec5.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec5 Pow(uvec5 lhs, uvec5 rhs) => uvec5.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec5 Log(uvec5 lhs, uvec5 rhs) => uvec5.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec5 Clamp(uvec5 v, uvec5 min, uvec5 max) => uvec5.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec5 Mix(uvec5 min, uvec5 max, uvec5 a) => uvec5.Mix(min, max, a);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec5 Lerp(uvec5 min, uvec5 max, uvec5 a) => uvec5.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec5 Smoothstep(uvec5 edge0, uvec5 edge1, uvec5 v) => uvec5.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec5 Smootherstep(uvec5 edge0, uvec5 edge1, uvec5 v) => uvec5.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec5 Fma(uvec5 a, uvec5 b, uvec5 c) => uvec5.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat2x5 OuterProduct(uvec5 c, uvec2 r) => uvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat3x5 OuterProduct(uvec5 c, uvec3 r) => uvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat4x5 OuterProduct(uvec5 c, uvec4 r) => uvec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat5 OuterProduct(uvec5 c, uvec5 r) => uvec5.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uvec5 Add(uvec5 lhs, uvec5 rhs) => uvec5.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uvec5 Sub(uvec5 lhs, uvec5 rhs) => uvec5.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uvec5 Mul(uvec5 lhs, uvec5 rhs) => uvec5.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uvec5 Div(uvec5 lhs, uvec5 rhs) => uvec5.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec5 Xor(uvec5 lhs, uvec5 rhs) => uvec5.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec5 BitwiseOr(uvec5 lhs, uvec5 rhs) => uvec5.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec5 BitwiseAnd(uvec5 lhs, uvec5 rhs) => uvec5.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec5 LeftShift(uvec5 lhs, ivec5 rhs) => uvec5.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec5 RightShift(uvec5 lhs, ivec5 rhs) => uvec5.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static uint MinElement(uvec5 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static uint MaxElement(uvec5 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(uvec5 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(uvec5 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static uint Sum(uvec5 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(uvec5 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(uvec5 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(uvec5 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(uvec5 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(uvec5 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static uint Dot(uvec5 lhs, uvec5 rhs) => uvec5.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(uvec5 lhs, uvec5 rhs) => uvec5.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(uvec5 lhs, uvec5 rhs) => uvec5.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec5 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uvec5 Random(Random random, uvec5 maxValue) => uvec5.Random(random, maxValue);
        
        /// <summary>
        /// Returns a uvec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec5 Random(Random random, uvec5 minValue, uvec5 maxValue) => uvec5.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a uvec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec5 RandomUniform(Random random, uvec5 minValue, uvec5 maxValue) => uvec5.RandomUniform(random, minValue, maxValue);

    }
}
