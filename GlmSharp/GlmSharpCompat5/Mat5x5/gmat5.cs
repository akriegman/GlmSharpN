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
    /// A matrix of type T with 5 columns and 5 rows.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct gmat5<T> : IEnumerable<T>, IEquatable<gmat5<T>>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        public T m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        public T m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        public T m02;
        
        /// <summary>
        /// Column 0, Rows 3
        /// </summary>
        public T m03;
        
        /// <summary>
        /// Column 0, Rows 4
        /// </summary>
        public T m04;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        public T m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        public T m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        public T m12;
        
        /// <summary>
        /// Column 1, Rows 3
        /// </summary>
        public T m13;
        
        /// <summary>
        /// Column 1, Rows 4
        /// </summary>
        public T m14;
        
        /// <summary>
        /// Column 2, Rows 0
        /// </summary>
        public T m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        public T m21;
        
        /// <summary>
        /// Column 2, Rows 2
        /// </summary>
        public T m22;
        
        /// <summary>
        /// Column 2, Rows 3
        /// </summary>
        public T m23;
        
        /// <summary>
        /// Column 2, Rows 4
        /// </summary>
        public T m24;
        
        /// <summary>
        /// Column 3, Rows 0
        /// </summary>
        public T m30;
        
        /// <summary>
        /// Column 3, Rows 1
        /// </summary>
        public T m31;
        
        /// <summary>
        /// Column 3, Rows 2
        /// </summary>
        public T m32;
        
        /// <summary>
        /// Column 3, Rows 3
        /// </summary>
        public T m33;
        
        /// <summary>
        /// Column 3, Rows 4
        /// </summary>
        public T m34;
        
        /// <summary>
        /// Column 4, Rows 0
        /// </summary>
        public T m40;
        
        /// <summary>
        /// Column 4, Rows 1
        /// </summary>
        public T m41;
        
        /// <summary>
        /// Column 4, Rows 2
        /// </summary>
        public T m42;
        
        /// <summary>
        /// Column 4, Rows 3
        /// </summary>
        public T m43;
        
        /// <summary>
        /// Column 4, Rows 4
        /// </summary>
        public T m44;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public gmat5(T m00, T m01, T m02, T m03, T m04, T m10, T m11, T m12, T m13, T m14, T m20, T m21, T m22, T m23, T m24, T m30, T m31, T m32, T m33, T m34, T m40, T m41, T m42, T m43, T m44)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m03 = m03;
            this.m04 = m04;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m14 = m14;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m24 = m24;
            this.m30 = m30;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
            this.m34 = m34;
            this.m40 = m40;
            this.m41 = m41;
            this.m42 = m42;
            this.m43 = m43;
            this.m44 = m44;
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat3x2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat4x2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat5x2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat2x3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat4x3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat5x3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = m.m42;
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat2x4<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = default(T);
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat3x4<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = default(T);
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat4<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = default(T);
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m24 = default(T);
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat5x4<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = default(T);
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m24 = default(T);
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
            this.m34 = default(T);
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = m.m42;
            this.m43 = m.m43;
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat2x5<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = m.m04;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = m.m14;
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat3x5<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = m.m04;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = m.m14;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m24 = m.m24;
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat4x5<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = m.m04;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = m.m14;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m24 = m.m24;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
            this.m34 = m.m34;
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gmat5<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = m.m04;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = m.m14;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m24 = m.m24;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
            this.m34 = m.m34;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = m.m42;
            this.m43 = m.m43;
            this.m44 = m.m44;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec2<T> c0, gvec2<T> c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = default(T);
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec2<T> c0, gvec2<T> c1, gvec2<T> c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = default(T);
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec2<T> c0, gvec2<T> c1, gvec2<T> c2, gvec2<T> c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = default(T);
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec2<T> c0, gvec2<T> c1, gvec2<T> c2, gvec2<T> c3, gvec2<T> c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = default(T);
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec3<T> c0, gvec3<T> c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec3<T> c0, gvec3<T> c1, gvec3<T> c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec3<T> c0, gvec3<T> c1, gvec3<T> c2, gvec3<T> c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec3<T> c0, gvec3<T> c1, gvec3<T> c2, gvec3<T> c3, gvec3<T> c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = default(T);
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = default(T);
            this.m14 = default(T);
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = c4.z;
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec4<T> c0, gvec4<T> c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = default(T);
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec4<T> c0, gvec4<T> c1, gvec4<T> c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = default(T);
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec4<T> c0, gvec4<T> c1, gvec4<T> c2, gvec4<T> c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = default(T);
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m24 = default(T);
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = c3.w;
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec4<T> c0, gvec4<T> c1, gvec4<T> c2, gvec4<T> c3, gvec4<T> c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = default(T);
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m24 = default(T);
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = c3.w;
            this.m34 = default(T);
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = c4.z;
            this.m43 = c4.w;
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec5<T> c0, gvec5<T> c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = c0.v;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = c1.v;
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m23 = default(T);
            this.m24 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec5<T> c0, gvec5<T> c1, gvec5<T> c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = c0.v;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = c1.v;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m24 = c2.v;
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
            this.m33 = default(T);
            this.m34 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec5<T> c0, gvec5<T> c1, gvec5<T> c2, gvec5<T> c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = c0.v;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = c1.v;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m24 = c2.v;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = c3.w;
            this.m34 = c3.v;
            this.m40 = default(T);
            this.m41 = default(T);
            this.m42 = default(T);
            this.m43 = default(T);
            this.m44 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5(gvec5<T> c0, gvec5<T> c1, gvec5<T> c2, gvec5<T> c3, gvec5<T> c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = c0.v;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = c1.v;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m24 = c2.v;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = c3.w;
            this.m34 = c3.v;
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = c4.z;
            this.m43 = c4.w;
            this.m44 = c4.v;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public T[,] Values => new[,] { { m00, m01, m02, m03, m04 }, { m10, m11, m12, m13, m14 }, { m20, m21, m22, m23, m24 }, { m30, m31, m32, m33, m34 }, { m40, m41, m42, m43, m44 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public T[] Values1D => new[] { m00, m01, m02, m03, m04, m10, m11, m12, m13, m14, m20, m21, m22, m23, m24, m30, m31, m32, m33, m34, m40, m41, m42, m43, m44 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public gvec5<T> Column0
        {
            get
            {
                return new gvec5<T>(m00, m01, m02, m03, m04);
            }
            set
            {
                m00 = value.x;
                m01 = value.y;
                m02 = value.z;
                m03 = value.w;
                m04 = value.v;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 1
        /// </summary>
        public gvec5<T> Column1
        {
            get
            {
                return new gvec5<T>(m10, m11, m12, m13, m14);
            }
            set
            {
                m10 = value.x;
                m11 = value.y;
                m12 = value.z;
                m13 = value.w;
                m14 = value.v;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 2
        /// </summary>
        public gvec5<T> Column2
        {
            get
            {
                return new gvec5<T>(m20, m21, m22, m23, m24);
            }
            set
            {
                m20 = value.x;
                m21 = value.y;
                m22 = value.z;
                m23 = value.w;
                m24 = value.v;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 3
        /// </summary>
        public gvec5<T> Column3
        {
            get
            {
                return new gvec5<T>(m30, m31, m32, m33, m34);
            }
            set
            {
                m30 = value.x;
                m31 = value.y;
                m32 = value.z;
                m33 = value.w;
                m34 = value.v;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 4
        /// </summary>
        public gvec5<T> Column4
        {
            get
            {
                return new gvec5<T>(m40, m41, m42, m43, m44);
            }
            set
            {
                m40 = value.x;
                m41 = value.y;
                m42 = value.z;
                m43 = value.w;
                m44 = value.v;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 0
        /// </summary>
        public gvec5<T> Row0
        {
            get
            {
                return new gvec5<T>(m00, m10, m20, m30, m40);
            }
            set
            {
                m00 = value.x;
                m10 = value.y;
                m20 = value.z;
                m30 = value.w;
                m40 = value.v;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 1
        /// </summary>
        public gvec5<T> Row1
        {
            get
            {
                return new gvec5<T>(m01, m11, m21, m31, m41);
            }
            set
            {
                m01 = value.x;
                m11 = value.y;
                m21 = value.z;
                m31 = value.w;
                m41 = value.v;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 2
        /// </summary>
        public gvec5<T> Row2
        {
            get
            {
                return new gvec5<T>(m02, m12, m22, m32, m42);
            }
            set
            {
                m02 = value.x;
                m12 = value.y;
                m22 = value.z;
                m32 = value.w;
                m42 = value.v;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 3
        /// </summary>
        public gvec5<T> Row3
        {
            get
            {
                return new gvec5<T>(m03, m13, m23, m33, m43);
            }
            set
            {
                m03 = value.x;
                m13 = value.y;
                m23 = value.z;
                m33 = value.w;
                m43 = value.v;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 4
        /// </summary>
        public gvec5<T> Row4
        {
            get
            {
                return new gvec5<T>(m04, m14, m24, m34, m44);
            }
            set
            {
                m04 = value.x;
                m14 = value.y;
                m24 = value.z;
                m34 = value.w;
                m44 = value.v;
            }
        }

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static gmat5<T> Zero { get; } = new gmat5<T>(default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T));

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m02;
            yield return m03;
            yield return m04;
            yield return m10;
            yield return m11;
            yield return m12;
            yield return m13;
            yield return m14;
            yield return m20;
            yield return m21;
            yield return m22;
            yield return m23;
            yield return m24;
            yield return m30;
            yield return m31;
            yield return m32;
            yield return m33;
            yield return m34;
            yield return m40;
            yield return m41;
            yield return m42;
            yield return m43;
            yield return m44;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (5 x 5 = 25).
        /// </summary>
        public int Count => 25;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public T this[int fieldIndex]
        {
            get
            {
                switch (fieldIndex)
                {
                    case 0: return m00;
                    case 1: return m01;
                    case 2: return m02;
                    case 3: return m03;
                    case 4: return m04;
                    case 5: return m10;
                    case 6: return m11;
                    case 7: return m12;
                    case 8: return m13;
                    case 9: return m14;
                    case 10: return m20;
                    case 11: return m21;
                    case 12: return m22;
                    case 13: return m23;
                    case 14: return m24;
                    case 15: return m30;
                    case 16: return m31;
                    case 17: return m32;
                    case 18: return m33;
                    case 19: return m34;
                    case 20: return m40;
                    case 21: return m41;
                    case 22: return m42;
                    case 23: return m43;
                    case 24: return m44;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
            set
            {
                switch (fieldIndex)
                {
                    case 0: this.m00 = value; break;
                    case 1: this.m01 = value; break;
                    case 2: this.m02 = value; break;
                    case 3: this.m03 = value; break;
                    case 4: this.m04 = value; break;
                    case 5: this.m10 = value; break;
                    case 6: this.m11 = value; break;
                    case 7: this.m12 = value; break;
                    case 8: this.m13 = value; break;
                    case 9: this.m14 = value; break;
                    case 10: this.m20 = value; break;
                    case 11: this.m21 = value; break;
                    case 12: this.m22 = value; break;
                    case 13: this.m23 = value; break;
                    case 14: this.m24 = value; break;
                    case 15: this.m30 = value; break;
                    case 16: this.m31 = value; break;
                    case 17: this.m32 = value; break;
                    case 18: this.m33 = value; break;
                    case 19: this.m34 = value; break;
                    case 20: this.m40 = value; break;
                    case 21: this.m41 = value; break;
                    case 22: this.m42 = value; break;
                    case 23: this.m43 = value; break;
                    case 24: this.m44 = value; break;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public T this[int col, int row]
        {
            get
            {
                return this[col * 5 + row];
            }
            set
            {
                this[col * 5 + row] = value;
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(gmat5<T> rhs) => (((((EqualityComparer<T>.Default.Equals(m00, rhs.m00) && EqualityComparer<T>.Default.Equals(m01, rhs.m01)) && (EqualityComparer<T>.Default.Equals(m02, rhs.m02) && EqualityComparer<T>.Default.Equals(m03, rhs.m03))) && ((EqualityComparer<T>.Default.Equals(m04, rhs.m04) && EqualityComparer<T>.Default.Equals(m10, rhs.m10)) && EqualityComparer<T>.Default.Equals(m11, rhs.m11))) && (((EqualityComparer<T>.Default.Equals(m12, rhs.m12) && EqualityComparer<T>.Default.Equals(m13, rhs.m13)) && EqualityComparer<T>.Default.Equals(m14, rhs.m14)) && ((EqualityComparer<T>.Default.Equals(m20, rhs.m20) && EqualityComparer<T>.Default.Equals(m21, rhs.m21)) && EqualityComparer<T>.Default.Equals(m22, rhs.m22)))) && ((((EqualityComparer<T>.Default.Equals(m23, rhs.m23) && EqualityComparer<T>.Default.Equals(m24, rhs.m24)) && EqualityComparer<T>.Default.Equals(m30, rhs.m30)) && ((EqualityComparer<T>.Default.Equals(m31, rhs.m31) && EqualityComparer<T>.Default.Equals(m32, rhs.m32)) && EqualityComparer<T>.Default.Equals(m33, rhs.m33))) && (((EqualityComparer<T>.Default.Equals(m34, rhs.m34) && EqualityComparer<T>.Default.Equals(m40, rhs.m40)) && EqualityComparer<T>.Default.Equals(m41, rhs.m41)) && ((EqualityComparer<T>.Default.Equals(m42, rhs.m42) && EqualityComparer<T>.Default.Equals(m43, rhs.m43)) && EqualityComparer<T>.Default.Equals(m44, rhs.m44)))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is gmat5<T> && Equals((gmat5<T>) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(gmat5<T> lhs, gmat5<T> rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(gmat5<T> lhs, gmat5<T> rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((((((((((((((((((((((((((((EqualityComparer<T>.Default.GetHashCode(m00)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m01)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m02)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m03)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m04)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m10)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m11)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m12)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m13)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m14)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m20)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m21)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m22)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m23)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m24)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m30)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m31)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m32)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m33)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m34)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m40)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m41)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m42)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m43)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m44);
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public gmat5<T> Transposed => new gmat5<T>(m00, m10, m20, m30, m40, m01, m11, m21, m31, m41, m02, m12, m22, m32, m42, m03, m13, m23, m33, m43, m04, m14, m24, m34, m44);
    }
}
