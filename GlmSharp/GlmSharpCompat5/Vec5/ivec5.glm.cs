using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
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
        public static swizzle_ivec5 swizzle(ivec5 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static int[] Values(ivec5 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<int> GetEnumerator(ivec5 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(ivec5 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(ivec5 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(ivec5 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(ivec5 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(ivec5 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public static int Count(ivec5 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(ivec5 v, ivec5 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(ivec5 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(ivec5 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(ivec5 lhs, ivec5 rhs) => ivec5.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(ivec5 lhs, ivec5 rhs) => ivec5.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(ivec5 lhs, ivec5 rhs) => ivec5.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(ivec5 lhs, ivec5 rhs) => ivec5.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(ivec5 lhs, ivec5 rhs) => ivec5.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(ivec5 lhs, ivec5 rhs) => ivec5.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static ivec5 Abs(ivec5 v) => ivec5.Abs(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static ivec5 HermiteInterpolationOrder3(ivec5 v) => ivec5.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static ivec5 HermiteInterpolationOrder5(ivec5 v) => ivec5.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static ivec5 Sqr(ivec5 v) => ivec5.Sqr(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static ivec5 Pow2(ivec5 v) => ivec5.Pow2(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static ivec5 Pow3(ivec5 v) => ivec5.Pow3(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static ivec5 Step(ivec5 v) => ivec5.Step(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sqrt ((int)Math.Sqrt((double)v)).
        /// </summary>
        public static ivec5 Sqrt(ivec5 v) => ivec5.Sqrt(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of InverseSqrt ((int)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static ivec5 InverseSqrt(ivec5 v) => ivec5.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(ivec5 v) => ivec5.Sign(v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static ivec5 Max(ivec5 lhs, ivec5 rhs) => ivec5.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static ivec5 Min(ivec5 lhs, ivec5 rhs) => ivec5.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Pow ((int)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec5 Pow(ivec5 lhs, ivec5 rhs) => ivec5.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Log ((int)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec5 Log(ivec5 lhs, ivec5 rhs) => ivec5.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec5 Clamp(ivec5 v, ivec5 min, ivec5 max) => ivec5.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Mix(ivec5 min, ivec5 max, ivec5 a) => ivec5.Mix(min, max, a);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Lerp(ivec5 min, ivec5 max, ivec5 a) => ivec5.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec5 Smoothstep(ivec5 edge0, ivec5 edge1, ivec5 v) => ivec5.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec5 Smootherstep(ivec5 edge0, ivec5 edge1, ivec5 v) => ivec5.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static ivec5 Fma(ivec5 a, ivec5 b, ivec5 c) => ivec5.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat2x5 OuterProduct(ivec5 c, ivec2 r) => ivec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat3x5 OuterProduct(ivec5 c, ivec3 r) => ivec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat4x5 OuterProduct(ivec5 c, ivec4 r) => ivec5.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat5 OuterProduct(ivec5 c, ivec5 r) => ivec5.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static ivec5 Add(ivec5 lhs, ivec5 rhs) => ivec5.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static ivec5 Sub(ivec5 lhs, ivec5 rhs) => ivec5.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static ivec5 Mul(ivec5 lhs, ivec5 rhs) => ivec5.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static ivec5 Div(ivec5 lhs, ivec5 rhs) => ivec5.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static ivec5 Xor(ivec5 lhs, ivec5 rhs) => ivec5.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static ivec5 BitwiseOr(ivec5 lhs, ivec5 rhs) => ivec5.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static ivec5 BitwiseAnd(ivec5 lhs, ivec5 rhs) => ivec5.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static ivec5 LeftShift(ivec5 lhs, ivec5 rhs) => ivec5.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static ivec5 RightShift(ivec5 lhs, ivec5 rhs) => ivec5.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static int MinElement(ivec5 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static int MaxElement(ivec5 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(ivec5 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(ivec5 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static int Sum(ivec5 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(ivec5 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(ivec5 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(ivec5 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(ivec5 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(ivec5 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static int Dot(ivec5 lhs, ivec5 rhs) => ivec5.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(ivec5 lhs, ivec5 rhs) => ivec5.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(ivec5 lhs, ivec5 rhs) => ivec5.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static ivec5 Reflect(ivec5 I, ivec5 N) => ivec5.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static ivec5 Refract(ivec5 I, ivec5 N, int eta) => ivec5.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static ivec5 FaceForward(ivec5 N, ivec5 I, ivec5 Nref) => ivec5.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static ivec5 Random(Random random, ivec5 maxValue) => ivec5.Random(random, maxValue);
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec5 Random(Random random, ivec5 minValue, ivec5 maxValue) => ivec5.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec5 RandomUniform(Random random, ivec5 minValue, ivec5 maxValue) => ivec5.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static ivec5 RandomPoisson(Random random, dvec5 lambda) => ivec5.RandomPoisson(random, lambda);

    }
}
