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
    /// A matrix of type Complex with 5 columns and 5 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct cmat5 : IReadOnlyList<Complex>, IEquatable<cmat5>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public Complex m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public Complex m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public Complex m02;
        
        /// <summary>
        /// Column 0, Rows 3
        /// </summary>
        [DataMember]
        public Complex m03;
        
        /// <summary>
        /// Column 0, Rows 4
        /// </summary>
        [DataMember]
        public Complex m04;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public Complex m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public Complex m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public Complex m12;
        
        /// <summary>
        /// Column 1, Rows 3
        /// </summary>
        [DataMember]
        public Complex m13;
        
        /// <summary>
        /// Column 1, Rows 4
        /// </summary>
        [DataMember]
        public Complex m14;
        
        /// <summary>
        /// Column 2, Rows 0
        /// </summary>
        [DataMember]
        public Complex m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        [DataMember]
        public Complex m21;
        
        /// <summary>
        /// Column 2, Rows 2
        /// </summary>
        [DataMember]
        public Complex m22;
        
        /// <summary>
        /// Column 2, Rows 3
        /// </summary>
        [DataMember]
        public Complex m23;
        
        /// <summary>
        /// Column 2, Rows 4
        /// </summary>
        [DataMember]
        public Complex m24;
        
        /// <summary>
        /// Column 3, Rows 0
        /// </summary>
        [DataMember]
        public Complex m30;
        
        /// <summary>
        /// Column 3, Rows 1
        /// </summary>
        [DataMember]
        public Complex m31;
        
        /// <summary>
        /// Column 3, Rows 2
        /// </summary>
        [DataMember]
        public Complex m32;
        
        /// <summary>
        /// Column 3, Rows 3
        /// </summary>
        [DataMember]
        public Complex m33;
        
        /// <summary>
        /// Column 3, Rows 4
        /// </summary>
        [DataMember]
        public Complex m34;
        
        /// <summary>
        /// Column 4, Rows 0
        /// </summary>
        [DataMember]
        public Complex m40;
        
        /// <summary>
        /// Column 4, Rows 1
        /// </summary>
        [DataMember]
        public Complex m41;
        
        /// <summary>
        /// Column 4, Rows 2
        /// </summary>
        [DataMember]
        public Complex m42;
        
        /// <summary>
        /// Column 4, Rows 3
        /// </summary>
        [DataMember]
        public Complex m43;
        
        /// <summary>
        /// Column 4, Rows 4
        /// </summary>
        [DataMember]
        public Complex m44;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public cmat5(Complex m00, Complex m01, Complex m02, Complex m03, Complex m04, Complex m10, Complex m11, Complex m12, Complex m13, Complex m14, Complex m20, Complex m21, Complex m22, Complex m23, Complex m24, Complex m30, Complex m31, Complex m32, Complex m33, Complex m34, Complex m40, Complex m41, Complex m42, Complex m43, Complex m44)
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
        /// Constructs this matrix from a cmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = Complex.Zero;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = Complex.Zero;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = Complex.Zero;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = Complex.Zero;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = Complex.Zero;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = Complex.Zero;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat5x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat5x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = Complex.Zero;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = Complex.Zero;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat5x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat5x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = m.m42;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = Complex.Zero;
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat3x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = Complex.Zero;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = Complex.Zero;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m24 = Complex.Zero;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat5x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat5x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m04 = Complex.Zero;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m14 = Complex.Zero;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m24 = Complex.Zero;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
            this.m34 = Complex.Zero;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = m.m42;
            this.m43 = m.m43;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat2x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat2x5 m)
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
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat3x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat3x5 m)
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
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat4x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat4x5 m)
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
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a cmat5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cmat5 m)
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
        public cmat5(cvec2 c0, cvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = Complex.Zero;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = Complex.Zero;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec2 c0, cvec2 c1, cvec2 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = Complex.Zero;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = Complex.Zero;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec2 c0, cvec2 c1, cvec2 c2, cvec2 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = Complex.Zero;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = Complex.Zero;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec2 c0, cvec2 c1, cvec2 c2, cvec2 c3, cvec2 c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = Complex.Zero;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = Complex.Zero;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec3 c0, cvec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec3 c0, cvec3 c1, cvec3 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec3 c0, cvec3 c1, cvec3 c2, cvec3 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec3 c0, cvec3 c1, cvec3 c2, cvec3 c3, cvec3 c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = Complex.Zero;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = Complex.Zero;
            this.m14 = Complex.Zero;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = c4.z;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec4 c0, cvec4 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = Complex.Zero;
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec4 c0, cvec4 c1, cvec4 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = Complex.Zero;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec4 c0, cvec4 c1, cvec4 c2, cvec4 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = Complex.Zero;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m24 = Complex.Zero;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = c3.w;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec4 c0, cvec4 c1, cvec4 c2, cvec4 c3, cvec4 c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m04 = Complex.Zero;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m14 = Complex.Zero;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m24 = Complex.Zero;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = c3.w;
            this.m34 = Complex.Zero;
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = c4.z;
            this.m43 = c4.w;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec5 c0, cvec5 c1)
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
            this.m20 = Complex.Zero;
            this.m21 = Complex.Zero;
            this.m22 = Complex.One;
            this.m23 = Complex.Zero;
            this.m24 = Complex.Zero;
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec5 c0, cvec5 c1, cvec5 c2)
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
            this.m30 = Complex.Zero;
            this.m31 = Complex.Zero;
            this.m32 = Complex.Zero;
            this.m33 = Complex.One;
            this.m34 = Complex.Zero;
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec5 c0, cvec5 c1, cvec5 c2, cvec5 c3)
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
            this.m40 = Complex.Zero;
            this.m41 = Complex.Zero;
            this.m42 = Complex.Zero;
            this.m43 = Complex.Zero;
            this.m44 = Complex.One;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public cmat5(cvec5 c0, cvec5 c1, cvec5 c2, cvec5 c3, cvec5 c4)
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
        public Complex[,] Values => new[,] { { m00, m01, m02, m03, m04 }, { m10, m11, m12, m13, m14 }, { m20, m21, m22, m23, m24 }, { m30, m31, m32, m33, m34 }, { m40, m41, m42, m43, m44 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public Complex[] Values1D => new[] { m00, m01, m02, m03, m04, m10, m11, m12, m13, m14, m20, m21, m22, m23, m24, m30, m31, m32, m33, m34, m40, m41, m42, m43, m44 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public cvec5 Column0
        {
            get
            {
                return new cvec5(m00, m01, m02, m03, m04);
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
        public cvec5 Column1
        {
            get
            {
                return new cvec5(m10, m11, m12, m13, m14);
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
        public cvec5 Column2
        {
            get
            {
                return new cvec5(m20, m21, m22, m23, m24);
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
        public cvec5 Column3
        {
            get
            {
                return new cvec5(m30, m31, m32, m33, m34);
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
        public cvec5 Column4
        {
            get
            {
                return new cvec5(m40, m41, m42, m43, m44);
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
        public cvec5 Row0
        {
            get
            {
                return new cvec5(m00, m10, m20, m30, m40);
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
        public cvec5 Row1
        {
            get
            {
                return new cvec5(m01, m11, m21, m31, m41);
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
        public cvec5 Row2
        {
            get
            {
                return new cvec5(m02, m12, m22, m32, m42);
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
        public cvec5 Row3
        {
            get
            {
                return new cvec5(m03, m13, m23, m33, m43);
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
        public cvec5 Row4
        {
            get
            {
                return new cvec5(m04, m14, m24, m34, m44);
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
        public static cmat5 Zero { get; } = new cmat5(Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static cmat5 Ones { get; } = new cmat5(Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One, Complex.One);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static cmat5 Identity { get; } = new cmat5(Complex.One, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.One, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.One, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.One, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.One);
        
        /// <summary>
        /// Predefined all-imaginary-ones matrix
        /// </summary>
        public static cmat5 ImaginaryOnes { get; } = new cmat5(Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne);
        
        /// <summary>
        /// Predefined diagonal-imaginary-one matrix
        /// </summary>
        public static cmat5 ImaginaryIdentity { get; } = new cmat5(Complex.ImaginaryOne, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.ImaginaryOne, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.ImaginaryOne, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.ImaginaryOne, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.ImaginaryOne);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<Complex> GetEnumerator()
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
        public Complex this[int fieldIndex]
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
        public Complex this[int col, int row]
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
        public bool Equals(cmat5 rhs) => (((((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && (m02.Equals(rhs.m02) && m03.Equals(rhs.m03))) && ((m04.Equals(rhs.m04) && m10.Equals(rhs.m10)) && m11.Equals(rhs.m11))) && (((m12.Equals(rhs.m12) && m13.Equals(rhs.m13)) && m14.Equals(rhs.m14)) && ((m20.Equals(rhs.m20) && m21.Equals(rhs.m21)) && m22.Equals(rhs.m22)))) && ((((m23.Equals(rhs.m23) && m24.Equals(rhs.m24)) && m30.Equals(rhs.m30)) && ((m31.Equals(rhs.m31) && m32.Equals(rhs.m32)) && m33.Equals(rhs.m33))) && (((m34.Equals(rhs.m34) && m40.Equals(rhs.m40)) && m41.Equals(rhs.m41)) && ((m42.Equals(rhs.m42) && m43.Equals(rhs.m43)) && m44.Equals(rhs.m44)))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is cmat5 && Equals((cmat5) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(cmat5 lhs, cmat5 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(cmat5 lhs, cmat5 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((((((((((((((((((((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m02.GetHashCode()) * 397) ^ m03.GetHashCode()) * 397) ^ m04.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m12.GetHashCode()) * 397) ^ m13.GetHashCode()) * 397) ^ m14.GetHashCode()) * 397) ^ m20.GetHashCode()) * 397) ^ m21.GetHashCode()) * 397) ^ m22.GetHashCode()) * 397) ^ m23.GetHashCode()) * 397) ^ m24.GetHashCode()) * 397) ^ m30.GetHashCode()) * 397) ^ m31.GetHashCode()) * 397) ^ m32.GetHashCode()) * 397) ^ m33.GetHashCode()) * 397) ^ m34.GetHashCode()) * 397) ^ m40.GetHashCode()) * 397) ^ m41.GetHashCode()) * 397) ^ m42.GetHashCode()) * 397) ^ m43.GetHashCode()) * 397) ^ m44.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public cmat5 Transposed => new cmat5(m00, m10, m20, m30, m40, m01, m11, m21, m31, m41, m02, m12, m22, m32, m42, m03, m13, m23, m33, m43, m04, m14, m24, m34, m44);
        
        /// <summary>
        /// Returns the euclidean length of this matrix.
        /// </summary>
        public double Length => (double)Math.Sqrt((((((m00.LengthSqr() + m01.LengthSqr()) + (m02.LengthSqr() + m03.LengthSqr())) + ((m04.LengthSqr() + m10.LengthSqr()) + m11.LengthSqr())) + (((m12.LengthSqr() + m13.LengthSqr()) + m14.LengthSqr()) + ((m20.LengthSqr() + m21.LengthSqr()) + m22.LengthSqr()))) + ((((m23.LengthSqr() + m24.LengthSqr()) + m30.LengthSqr()) + ((m31.LengthSqr() + m32.LengthSqr()) + m33.LengthSqr())) + (((m34.LengthSqr() + m40.LengthSqr()) + m41.LengthSqr()) + ((m42.LengthSqr() + m43.LengthSqr()) + m44.LengthSqr())))));
        
        /// <summary>
        /// Returns the squared euclidean length of this matrix.
        /// </summary>
        public double LengthSqr => (((((m00.LengthSqr() + m01.LengthSqr()) + (m02.LengthSqr() + m03.LengthSqr())) + ((m04.LengthSqr() + m10.LengthSqr()) + m11.LengthSqr())) + (((m12.LengthSqr() + m13.LengthSqr()) + m14.LengthSqr()) + ((m20.LengthSqr() + m21.LengthSqr()) + m22.LengthSqr()))) + ((((m23.LengthSqr() + m24.LengthSqr()) + m30.LengthSqr()) + ((m31.LengthSqr() + m32.LengthSqr()) + m33.LengthSqr())) + (((m34.LengthSqr() + m40.LengthSqr()) + m41.LengthSqr()) + ((m42.LengthSqr() + m43.LengthSqr()) + m44.LengthSqr()))));
        
        /// <summary>
        /// Returns the sum of all fields.
        /// </summary>
        public Complex Sum => (((((m00 + m01) + (m02 + m03)) + ((m04 + m10) + m11)) + (((m12 + m13) + m14) + ((m20 + m21) + m22))) + ((((m23 + m24) + m30) + ((m31 + m32) + m33)) + (((m34 + m40) + m41) + ((m42 + m43) + m44))));
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public double Norm => (double)Math.Sqrt((((((m00.LengthSqr() + m01.LengthSqr()) + (m02.LengthSqr() + m03.LengthSqr())) + ((m04.LengthSqr() + m10.LengthSqr()) + m11.LengthSqr())) + (((m12.LengthSqr() + m13.LengthSqr()) + m14.LengthSqr()) + ((m20.LengthSqr() + m21.LengthSqr()) + m22.LengthSqr()))) + ((((m23.LengthSqr() + m24.LengthSqr()) + m30.LengthSqr()) + ((m31.LengthSqr() + m32.LengthSqr()) + m33.LengthSqr())) + (((m34.LengthSqr() + m40.LengthSqr()) + m41.LengthSqr()) + ((m42.LengthSqr() + m43.LengthSqr()) + m44.LengthSqr())))));
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public double Norm1 => (((((m00.Magnitude + m01.Magnitude) + (m02.Magnitude + m03.Magnitude)) + ((m04.Magnitude + m10.Magnitude) + m11.Magnitude)) + (((m12.Magnitude + m13.Magnitude) + m14.Magnitude) + ((m20.Magnitude + m21.Magnitude) + m22.Magnitude))) + ((((m23.Magnitude + m24.Magnitude) + m30.Magnitude) + ((m31.Magnitude + m32.Magnitude) + m33.Magnitude)) + (((m34.Magnitude + m40.Magnitude) + m41.Magnitude) + ((m42.Magnitude + m43.Magnitude) + m44.Magnitude))));
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt((((((m00.LengthSqr() + m01.LengthSqr()) + (m02.LengthSqr() + m03.LengthSqr())) + ((m04.LengthSqr() + m10.LengthSqr()) + m11.LengthSqr())) + (((m12.LengthSqr() + m13.LengthSqr()) + m14.LengthSqr()) + ((m20.LengthSqr() + m21.LengthSqr()) + m22.LengthSqr()))) + ((((m23.LengthSqr() + m24.LengthSqr()) + m30.LengthSqr()) + ((m31.LengthSqr() + m32.LengthSqr()) + m33.LengthSqr())) + (((m34.LengthSqr() + m40.LengthSqr()) + m41.LengthSqr()) + ((m42.LengthSqr() + m43.LengthSqr()) + m44.LengthSqr())))));
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public Complex NormMax => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(m00.Magnitude, m01.Magnitude), m02.Magnitude), m03.Magnitude), m04.Magnitude), m10.Magnitude), m11.Magnitude), m12.Magnitude), m13.Magnitude), m14.Magnitude), m20.Magnitude), m21.Magnitude), m22.Magnitude), m23.Magnitude), m24.Magnitude), m30.Magnitude), m31.Magnitude), m32.Magnitude), m33.Magnitude), m34.Magnitude), m40.Magnitude), m41.Magnitude), m42.Magnitude), m43.Magnitude), m44.Magnitude);
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow((((((Math.Pow((double)m00.Magnitude, p) + Math.Pow((double)m01.Magnitude, p)) + (Math.Pow((double)m02.Magnitude, p) + Math.Pow((double)m03.Magnitude, p))) + ((Math.Pow((double)m04.Magnitude, p) + Math.Pow((double)m10.Magnitude, p)) + Math.Pow((double)m11.Magnitude, p))) + (((Math.Pow((double)m12.Magnitude, p) + Math.Pow((double)m13.Magnitude, p)) + Math.Pow((double)m14.Magnitude, p)) + ((Math.Pow((double)m20.Magnitude, p) + Math.Pow((double)m21.Magnitude, p)) + Math.Pow((double)m22.Magnitude, p)))) + ((((Math.Pow((double)m23.Magnitude, p) + Math.Pow((double)m24.Magnitude, p)) + Math.Pow((double)m30.Magnitude, p)) + ((Math.Pow((double)m31.Magnitude, p) + Math.Pow((double)m32.Magnitude, p)) + Math.Pow((double)m33.Magnitude, p))) + (((Math.Pow((double)m34.Magnitude, p) + Math.Pow((double)m40.Magnitude, p)) + Math.Pow((double)m41.Magnitude, p)) + ((Math.Pow((double)m42.Magnitude, p) + Math.Pow((double)m43.Magnitude, p)) + Math.Pow((double)m44.Magnitude, p))))), 1 / p);
        
        /// <summary>
        /// Returns determinant of this matrix.
        /// </summary>
        public Complex Determinant => m00 * (m11 * (m22 * (m33 * m44 - m43 * m34) - m32 * (m23 * m44 - m43 * m24) + m42 * (m23 * m34 - m33 * m24)) - m21 * (m12 * (m33 * m44 - m43 * m34) - m32 * (m13 * m44 - m43 * m14) + m42 * (m13 * m34 - m33 * m14)) + m31 * (m12 * (m23 * m44 - m43 * m24) - m22 * (m13 * m44 - m43 * m14) + m42 * (m13 * m24 - m23 * m14)) - m41 * (m12 * (m23 * m34 - m33 * m24) - m22 * (m13 * m34 - m33 * m14) + m32 * (m13 * m24 - m23 * m14))) - m10 * (m01 * (m22 * (m33 * m44 - m43 * m34) - m32 * (m23 * m44 - m43 * m24) + m42 * (m23 * m34 - m33 * m24)) - m21 * (m02 * (m33 * m44 - m43 * m34) - m32 * (m03 * m44 - m43 * m04) + m42 * (m03 * m34 - m33 * m04)) + m31 * (m02 * (m23 * m44 - m43 * m24) - m22 * (m03 * m44 - m43 * m04) + m42 * (m03 * m24 - m23 * m04)) - m41 * (m02 * (m23 * m34 - m33 * m24) - m22 * (m03 * m34 - m33 * m04) + m32 * (m03 * m24 - m23 * m04))) + m20 * (m01 * (m12 * (m33 * m44 - m43 * m34) - m32 * (m13 * m44 - m43 * m14) + m42 * (m13 * m34 - m33 * m14)) - m11 * (m02 * (m33 * m44 - m43 * m34) - m32 * (m03 * m44 - m43 * m04) + m42 * (m03 * m34 - m33 * m04)) + m31 * (m02 * (m13 * m44 - m43 * m14) - m12 * (m03 * m44 - m43 * m04) + m42 * (m03 * m14 - m13 * m04)) - m41 * (m02 * (m13 * m34 - m33 * m14) - m12 * (m03 * m34 - m33 * m04) + m32 * (m03 * m14 - m13 * m04))) - m30 * (m01 * (m12 * (m23 * m44 - m43 * m24) - m22 * (m13 * m44 - m43 * m14) + m42 * (m13 * m24 - m23 * m14)) - m11 * (m02 * (m23 * m44 - m43 * m24) - m22 * (m03 * m44 - m43 * m04) + m42 * (m03 * m24 - m23 * m04)) + m21 * (m02 * (m13 * m44 - m43 * m14) - m12 * (m03 * m44 - m43 * m04) + m42 * (m03 * m14 - m13 * m04)) - m41 * (m02 * (m13 * m24 - m23 * m14) - m12 * (m03 * m24 - m23 * m04) + m22 * (m03 * m14 - m13 * m04))) + m40 * (m01 * (m12 * (m23 * m34 - m33 * m24) - m22 * (m13 * m34 - m33 * m14) + m32 * (m13 * m24 - m23 * m14)) - m11 * (m02 * (m23 * m34 - m33 * m24) - m22 * (m03 * m34 - m33 * m04) + m32 * (m03 * m24 - m23 * m04)) + m21 * (m02 * (m13 * m34 - m33 * m14) - m12 * (m03 * m34 - m33 * m04) + m32 * (m03 * m14 - m13 * m04)) - m31 * (m02 * (m13 * m24 - m23 * m14) - m12 * (m03 * m24 - m23 * m04) + m22 * (m03 * m14 - m13 * m04)));
        
        /// <summary>
        /// Returns the adjunct of this matrix.
        /// </summary>
        public cmat5 Adjugate => new cmat5(m11 * (m22 * (m33 * m44 - m43 * m34) - m32 * (m23 * m44 - m43 * m24) + m42 * (m23 * m34 - m33 * m24)) - m21 * (m12 * (m33 * m44 - m43 * m34) - m32 * (m13 * m44 - m43 * m14) + m42 * (m13 * m34 - m33 * m14)) + m31 * (m12 * (m23 * m44 - m43 * m24) - m22 * (m13 * m44 - m43 * m14) + m42 * (m13 * m24 - m23 * m14)) - m41 * (m12 * (m23 * m34 - m33 * m24) - m22 * (m13 * m34 - m33 * m14) + m32 * (m13 * m24 - m23 * m14)), -m01 * (m22 * (m33 * m44 - m43 * m34) - m32 * (m23 * m44 - m43 * m24) + m42 * (m23 * m34 - m33 * m24)) + m21 * (m02 * (m33 * m44 - m43 * m34) - m32 * (m03 * m44 - m43 * m04) + m42 * (m03 * m34 - m33 * m04)) - m31 * (m02 * (m23 * m44 - m43 * m24) - m22 * (m03 * m44 - m43 * m04) + m42 * (m03 * m24 - m23 * m04)) + m41 * (m02 * (m23 * m34 - m33 * m24) - m22 * (m03 * m34 - m33 * m04) + m32 * (m03 * m24 - m23 * m04)), m01 * (m12 * (m33 * m44 - m43 * m34) - m32 * (m13 * m44 - m43 * m14) + m42 * (m13 * m34 - m33 * m14)) - m11 * (m02 * (m33 * m44 - m43 * m34) - m32 * (m03 * m44 - m43 * m04) + m42 * (m03 * m34 - m33 * m04)) + m31 * (m02 * (m13 * m44 - m43 * m14) - m12 * (m03 * m44 - m43 * m04) + m42 * (m03 * m14 - m13 * m04)) - m41 * (m02 * (m13 * m34 - m33 * m14) - m12 * (m03 * m34 - m33 * m04) + m32 * (m03 * m14 - m13 * m04)), -m01 * (m12 * (m23 * m44 - m43 * m24) - m22 * (m13 * m44 - m43 * m14) + m42 * (m13 * m24 - m23 * m14)) + m11 * (m02 * (m23 * m44 - m43 * m24) - m22 * (m03 * m44 - m43 * m04) + m42 * (m03 * m24 - m23 * m04)) - m21 * (m02 * (m13 * m44 - m43 * m14) - m12 * (m03 * m44 - m43 * m04) + m42 * (m03 * m14 - m13 * m04)) + m41 * (m02 * (m13 * m24 - m23 * m14) - m12 * (m03 * m24 - m23 * m04) + m22 * (m03 * m14 - m13 * m04)), m01 * (m12 * (m23 * m34 - m33 * m24) - m22 * (m13 * m34 - m33 * m14) + m32 * (m13 * m24 - m23 * m14)) - m11 * (m02 * (m23 * m34 - m33 * m24) - m22 * (m03 * m34 - m33 * m04) + m32 * (m03 * m24 - m23 * m04)) + m21 * (m02 * (m13 * m34 - m33 * m14) - m12 * (m03 * m34 - m33 * m04) + m32 * (m03 * m14 - m13 * m04)) - m31 * (m02 * (m13 * m24 - m23 * m14) - m12 * (m03 * m24 - m23 * m04) + m22 * (m03 * m14 - m13 * m04)), -m10 * (m22 * (m33 * m44 - m43 * m34) - m32 * (m23 * m44 - m43 * m24) + m42 * (m23 * m34 - m33 * m24)) + m20 * (m12 * (m33 * m44 - m43 * m34) - m32 * (m13 * m44 - m43 * m14) + m42 * (m13 * m34 - m33 * m14)) - m30 * (m12 * (m23 * m44 - m43 * m24) - m22 * (m13 * m44 - m43 * m14) + m42 * (m13 * m24 - m23 * m14)) + m40 * (m12 * (m23 * m34 - m33 * m24) - m22 * (m13 * m34 - m33 * m14) + m32 * (m13 * m24 - m23 * m14)), m00 * (m22 * (m33 * m44 - m43 * m34) - m32 * (m23 * m44 - m43 * m24) + m42 * (m23 * m34 - m33 * m24)) - m20 * (m02 * (m33 * m44 - m43 * m34) - m32 * (m03 * m44 - m43 * m04) + m42 * (m03 * m34 - m33 * m04)) + m30 * (m02 * (m23 * m44 - m43 * m24) - m22 * (m03 * m44 - m43 * m04) + m42 * (m03 * m24 - m23 * m04)) - m40 * (m02 * (m23 * m34 - m33 * m24) - m22 * (m03 * m34 - m33 * m04) + m32 * (m03 * m24 - m23 * m04)), -m00 * (m12 * (m33 * m44 - m43 * m34) - m32 * (m13 * m44 - m43 * m14) + m42 * (m13 * m34 - m33 * m14)) + m10 * (m02 * (m33 * m44 - m43 * m34) - m32 * (m03 * m44 - m43 * m04) + m42 * (m03 * m34 - m33 * m04)) - m30 * (m02 * (m13 * m44 - m43 * m14) - m12 * (m03 * m44 - m43 * m04) + m42 * (m03 * m14 - m13 * m04)) + m40 * (m02 * (m13 * m34 - m33 * m14) - m12 * (m03 * m34 - m33 * m04) + m32 * (m03 * m14 - m13 * m04)), m00 * (m12 * (m23 * m44 - m43 * m24) - m22 * (m13 * m44 - m43 * m14) + m42 * (m13 * m24 - m23 * m14)) - m10 * (m02 * (m23 * m44 - m43 * m24) - m22 * (m03 * m44 - m43 * m04) + m42 * (m03 * m24 - m23 * m04)) + m20 * (m02 * (m13 * m44 - m43 * m14) - m12 * (m03 * m44 - m43 * m04) + m42 * (m03 * m14 - m13 * m04)) - m40 * (m02 * (m13 * m24 - m23 * m14) - m12 * (m03 * m24 - m23 * m04) + m22 * (m03 * m14 - m13 * m04)), -m00 * (m12 * (m23 * m34 - m33 * m24) - m22 * (m13 * m34 - m33 * m14) + m32 * (m13 * m24 - m23 * m14)) + m10 * (m02 * (m23 * m34 - m33 * m24) - m22 * (m03 * m34 - m33 * m04) + m32 * (m03 * m24 - m23 * m04)) - m20 * (m02 * (m13 * m34 - m33 * m14) - m12 * (m03 * m34 - m33 * m04) + m32 * (m03 * m14 - m13 * m04)) + m30 * (m02 * (m13 * m24 - m23 * m14) - m12 * (m03 * m24 - m23 * m04) + m22 * (m03 * m14 - m13 * m04)), m10 * (m21 * (m33 * m44 - m43 * m34) - m31 * (m23 * m44 - m43 * m24) + m41 * (m23 * m34 - m33 * m24)) - m20 * (m11 * (m33 * m44 - m43 * m34) - m31 * (m13 * m44 - m43 * m14) + m41 * (m13 * m34 - m33 * m14)) + m30 * (m11 * (m23 * m44 - m43 * m24) - m21 * (m13 * m44 - m43 * m14) + m41 * (m13 * m24 - m23 * m14)) - m40 * (m11 * (m23 * m34 - m33 * m24) - m21 * (m13 * m34 - m33 * m14) + m31 * (m13 * m24 - m23 * m14)), -m00 * (m21 * (m33 * m44 - m43 * m34) - m31 * (m23 * m44 - m43 * m24) + m41 * (m23 * m34 - m33 * m24)) + m20 * (m01 * (m33 * m44 - m43 * m34) - m31 * (m03 * m44 - m43 * m04) + m41 * (m03 * m34 - m33 * m04)) - m30 * (m01 * (m23 * m44 - m43 * m24) - m21 * (m03 * m44 - m43 * m04) + m41 * (m03 * m24 - m23 * m04)) + m40 * (m01 * (m23 * m34 - m33 * m24) - m21 * (m03 * m34 - m33 * m04) + m31 * (m03 * m24 - m23 * m04)), m00 * (m11 * (m33 * m44 - m43 * m34) - m31 * (m13 * m44 - m43 * m14) + m41 * (m13 * m34 - m33 * m14)) - m10 * (m01 * (m33 * m44 - m43 * m34) - m31 * (m03 * m44 - m43 * m04) + m41 * (m03 * m34 - m33 * m04)) + m30 * (m01 * (m13 * m44 - m43 * m14) - m11 * (m03 * m44 - m43 * m04) + m41 * (m03 * m14 - m13 * m04)) - m40 * (m01 * (m13 * m34 - m33 * m14) - m11 * (m03 * m34 - m33 * m04) + m31 * (m03 * m14 - m13 * m04)), -m00 * (m11 * (m23 * m44 - m43 * m24) - m21 * (m13 * m44 - m43 * m14) + m41 * (m13 * m24 - m23 * m14)) + m10 * (m01 * (m23 * m44 - m43 * m24) - m21 * (m03 * m44 - m43 * m04) + m41 * (m03 * m24 - m23 * m04)) - m20 * (m01 * (m13 * m44 - m43 * m14) - m11 * (m03 * m44 - m43 * m04) + m41 * (m03 * m14 - m13 * m04)) + m40 * (m01 * (m13 * m24 - m23 * m14) - m11 * (m03 * m24 - m23 * m04) + m21 * (m03 * m14 - m13 * m04)), m00 * (m11 * (m23 * m34 - m33 * m24) - m21 * (m13 * m34 - m33 * m14) + m31 * (m13 * m24 - m23 * m14)) - m10 * (m01 * (m23 * m34 - m33 * m24) - m21 * (m03 * m34 - m33 * m04) + m31 * (m03 * m24 - m23 * m04)) + m20 * (m01 * (m13 * m34 - m33 * m14) - m11 * (m03 * m34 - m33 * m04) + m31 * (m03 * m14 - m13 * m04)) - m30 * (m01 * (m13 * m24 - m23 * m14) - m11 * (m03 * m24 - m23 * m04) + m21 * (m03 * m14 - m13 * m04)), -m10 * (m21 * (m32 * m44 - m42 * m34) - m31 * (m22 * m44 - m42 * m24) + m41 * (m22 * m34 - m32 * m24)) + m20 * (m11 * (m32 * m44 - m42 * m34) - m31 * (m12 * m44 - m42 * m14) + m41 * (m12 * m34 - m32 * m14)) - m30 * (m11 * (m22 * m44 - m42 * m24) - m21 * (m12 * m44 - m42 * m14) + m41 * (m12 * m24 - m22 * m14)) + m40 * (m11 * (m22 * m34 - m32 * m24) - m21 * (m12 * m34 - m32 * m14) + m31 * (m12 * m24 - m22 * m14)), m00 * (m21 * (m32 * m44 - m42 * m34) - m31 * (m22 * m44 - m42 * m24) + m41 * (m22 * m34 - m32 * m24)) - m20 * (m01 * (m32 * m44 - m42 * m34) - m31 * (m02 * m44 - m42 * m04) + m41 * (m02 * m34 - m32 * m04)) + m30 * (m01 * (m22 * m44 - m42 * m24) - m21 * (m02 * m44 - m42 * m04) + m41 * (m02 * m24 - m22 * m04)) - m40 * (m01 * (m22 * m34 - m32 * m24) - m21 * (m02 * m34 - m32 * m04) + m31 * (m02 * m24 - m22 * m04)), -m00 * (m11 * (m32 * m44 - m42 * m34) - m31 * (m12 * m44 - m42 * m14) + m41 * (m12 * m34 - m32 * m14)) + m10 * (m01 * (m32 * m44 - m42 * m34) - m31 * (m02 * m44 - m42 * m04) + m41 * (m02 * m34 - m32 * m04)) - m30 * (m01 * (m12 * m44 - m42 * m14) - m11 * (m02 * m44 - m42 * m04) + m41 * (m02 * m14 - m12 * m04)) + m40 * (m01 * (m12 * m34 - m32 * m14) - m11 * (m02 * m34 - m32 * m04) + m31 * (m02 * m14 - m12 * m04)), m00 * (m11 * (m22 * m44 - m42 * m24) - m21 * (m12 * m44 - m42 * m14) + m41 * (m12 * m24 - m22 * m14)) - m10 * (m01 * (m22 * m44 - m42 * m24) - m21 * (m02 * m44 - m42 * m04) + m41 * (m02 * m24 - m22 * m04)) + m20 * (m01 * (m12 * m44 - m42 * m14) - m11 * (m02 * m44 - m42 * m04) + m41 * (m02 * m14 - m12 * m04)) - m40 * (m01 * (m12 * m24 - m22 * m14) - m11 * (m02 * m24 - m22 * m04) + m21 * (m02 * m14 - m12 * m04)), -m00 * (m11 * (m22 * m34 - m32 * m24) - m21 * (m12 * m34 - m32 * m14) + m31 * (m12 * m24 - m22 * m14)) + m10 * (m01 * (m22 * m34 - m32 * m24) - m21 * (m02 * m34 - m32 * m04) + m31 * (m02 * m24 - m22 * m04)) - m20 * (m01 * (m12 * m34 - m32 * m14) - m11 * (m02 * m34 - m32 * m04) + m31 * (m02 * m14 - m12 * m04)) + m30 * (m01 * (m12 * m24 - m22 * m14) - m11 * (m02 * m24 - m22 * m04) + m21 * (m02 * m14 - m12 * m04)), m10 * (m21 * (m32 * m43 - m42 * m33) - m31 * (m22 * m43 - m42 * m23) + m41 * (m22 * m33 - m32 * m23)) - m20 * (m11 * (m32 * m43 - m42 * m33) - m31 * (m12 * m43 - m42 * m13) + m41 * (m12 * m33 - m32 * m13)) + m30 * (m11 * (m22 * m43 - m42 * m23) - m21 * (m12 * m43 - m42 * m13) + m41 * (m12 * m23 - m22 * m13)) - m40 * (m11 * (m22 * m33 - m32 * m23) - m21 * (m12 * m33 - m32 * m13) + m31 * (m12 * m23 - m22 * m13)), -m00 * (m21 * (m32 * m43 - m42 * m33) - m31 * (m22 * m43 - m42 * m23) + m41 * (m22 * m33 - m32 * m23)) + m20 * (m01 * (m32 * m43 - m42 * m33) - m31 * (m02 * m43 - m42 * m03) + m41 * (m02 * m33 - m32 * m03)) - m30 * (m01 * (m22 * m43 - m42 * m23) - m21 * (m02 * m43 - m42 * m03) + m41 * (m02 * m23 - m22 * m03)) + m40 * (m01 * (m22 * m33 - m32 * m23) - m21 * (m02 * m33 - m32 * m03) + m31 * (m02 * m23 - m22 * m03)), m00 * (m11 * (m32 * m43 - m42 * m33) - m31 * (m12 * m43 - m42 * m13) + m41 * (m12 * m33 - m32 * m13)) - m10 * (m01 * (m32 * m43 - m42 * m33) - m31 * (m02 * m43 - m42 * m03) + m41 * (m02 * m33 - m32 * m03)) + m30 * (m01 * (m12 * m43 - m42 * m13) - m11 * (m02 * m43 - m42 * m03) + m41 * (m02 * m13 - m12 * m03)) - m40 * (m01 * (m12 * m33 - m32 * m13) - m11 * (m02 * m33 - m32 * m03) + m31 * (m02 * m13 - m12 * m03)), -m00 * (m11 * (m22 * m43 - m42 * m23) - m21 * (m12 * m43 - m42 * m13) + m41 * (m12 * m23 - m22 * m13)) + m10 * (m01 * (m22 * m43 - m42 * m23) - m21 * (m02 * m43 - m42 * m03) + m41 * (m02 * m23 - m22 * m03)) - m20 * (m01 * (m12 * m43 - m42 * m13) - m11 * (m02 * m43 - m42 * m03) + m41 * (m02 * m13 - m12 * m03)) + m40 * (m01 * (m12 * m23 - m22 * m13) - m11 * (m02 * m23 - m22 * m03) + m21 * (m02 * m13 - m12 * m03)), m00 * (m11 * (m22 * m33 - m32 * m23) - m21 * (m12 * m33 - m32 * m13) + m31 * (m12 * m23 - m22 * m13)) - m10 * (m01 * (m22 * m33 - m32 * m23) - m21 * (m02 * m33 - m32 * m03) + m31 * (m02 * m23 - m22 * m03)) + m20 * (m01 * (m12 * m33 - m32 * m13) - m11 * (m02 * m33 - m32 * m03) + m31 * (m02 * m13 - m12 * m03)) - m30 * (m01 * (m12 * m23 - m22 * m13) - m11 * (m02 * m23 - m22 * m03) + m21 * (m02 * m13 - m12 * m03)));
        
        /// <summary>
        /// Returns the inverse of this matrix (use with caution).
        /// </summary>
        public cmat5 Inverse => Adjugate / Determinant;
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat5 * cmat2x5 -> cmat2x5.
        /// </summary>
        public static cmat2x5 operator*(cmat5 lhs, cmat2x5 rhs) => new cmat2x5((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02) + (lhs.m32 * rhs.m03 + lhs.m42 * rhs.m04)), (((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + lhs.m23 * rhs.m02) + (lhs.m33 * rhs.m03 + lhs.m43 * rhs.m04)), (((lhs.m04 * rhs.m00 + lhs.m14 * rhs.m01) + lhs.m24 * rhs.m02) + (lhs.m34 * rhs.m03 + lhs.m44 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)), (((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12) + (lhs.m32 * rhs.m13 + lhs.m42 * rhs.m14)), (((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + lhs.m23 * rhs.m12) + (lhs.m33 * rhs.m13 + lhs.m43 * rhs.m14)), (((lhs.m04 * rhs.m10 + lhs.m14 * rhs.m11) + lhs.m24 * rhs.m12) + (lhs.m34 * rhs.m13 + lhs.m44 * rhs.m14)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat5 * cmat3x5 -> cmat3x5.
        /// </summary>
        public static cmat3x5 operator*(cmat5 lhs, cmat3x5 rhs) => new cmat3x5((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02) + (lhs.m32 * rhs.m03 + lhs.m42 * rhs.m04)), (((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + lhs.m23 * rhs.m02) + (lhs.m33 * rhs.m03 + lhs.m43 * rhs.m04)), (((lhs.m04 * rhs.m00 + lhs.m14 * rhs.m01) + lhs.m24 * rhs.m02) + (lhs.m34 * rhs.m03 + lhs.m44 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)), (((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12) + (lhs.m32 * rhs.m13 + lhs.m42 * rhs.m14)), (((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + lhs.m23 * rhs.m12) + (lhs.m33 * rhs.m13 + lhs.m43 * rhs.m14)), (((lhs.m04 * rhs.m10 + lhs.m14 * rhs.m11) + lhs.m24 * rhs.m12) + (lhs.m34 * rhs.m13 + lhs.m44 * rhs.m14)), (((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22) + (lhs.m30 * rhs.m23 + lhs.m40 * rhs.m24)), (((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22) + (lhs.m31 * rhs.m23 + lhs.m41 * rhs.m24)), (((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + lhs.m22 * rhs.m22) + (lhs.m32 * rhs.m23 + lhs.m42 * rhs.m24)), (((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + lhs.m23 * rhs.m22) + (lhs.m33 * rhs.m23 + lhs.m43 * rhs.m24)), (((lhs.m04 * rhs.m20 + lhs.m14 * rhs.m21) + lhs.m24 * rhs.m22) + (lhs.m34 * rhs.m23 + lhs.m44 * rhs.m24)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat5 * cmat4x5 -> cmat4x5.
        /// </summary>
        public static cmat4x5 operator*(cmat5 lhs, cmat4x5 rhs) => new cmat4x5((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02) + (lhs.m32 * rhs.m03 + lhs.m42 * rhs.m04)), (((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + lhs.m23 * rhs.m02) + (lhs.m33 * rhs.m03 + lhs.m43 * rhs.m04)), (((lhs.m04 * rhs.m00 + lhs.m14 * rhs.m01) + lhs.m24 * rhs.m02) + (lhs.m34 * rhs.m03 + lhs.m44 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)), (((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12) + (lhs.m32 * rhs.m13 + lhs.m42 * rhs.m14)), (((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + lhs.m23 * rhs.m12) + (lhs.m33 * rhs.m13 + lhs.m43 * rhs.m14)), (((lhs.m04 * rhs.m10 + lhs.m14 * rhs.m11) + lhs.m24 * rhs.m12) + (lhs.m34 * rhs.m13 + lhs.m44 * rhs.m14)), (((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22) + (lhs.m30 * rhs.m23 + lhs.m40 * rhs.m24)), (((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22) + (lhs.m31 * rhs.m23 + lhs.m41 * rhs.m24)), (((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + lhs.m22 * rhs.m22) + (lhs.m32 * rhs.m23 + lhs.m42 * rhs.m24)), (((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + lhs.m23 * rhs.m22) + (lhs.m33 * rhs.m23 + lhs.m43 * rhs.m24)), (((lhs.m04 * rhs.m20 + lhs.m14 * rhs.m21) + lhs.m24 * rhs.m22) + (lhs.m34 * rhs.m23 + lhs.m44 * rhs.m24)), (((lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31) + lhs.m20 * rhs.m32) + (lhs.m30 * rhs.m33 + lhs.m40 * rhs.m34)), (((lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31) + lhs.m21 * rhs.m32) + (lhs.m31 * rhs.m33 + lhs.m41 * rhs.m34)), (((lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31) + lhs.m22 * rhs.m32) + (lhs.m32 * rhs.m33 + lhs.m42 * rhs.m34)), (((lhs.m03 * rhs.m30 + lhs.m13 * rhs.m31) + lhs.m23 * rhs.m32) + (lhs.m33 * rhs.m33 + lhs.m43 * rhs.m34)), (((lhs.m04 * rhs.m30 + lhs.m14 * rhs.m31) + lhs.m24 * rhs.m32) + (lhs.m34 * rhs.m33 + lhs.m44 * rhs.m34)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat5 * cmat5 -> cmat5.
        /// </summary>
        public static cmat5 operator*(cmat5 lhs, cmat5 rhs) => new cmat5((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02) + (lhs.m32 * rhs.m03 + lhs.m42 * rhs.m04)), (((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + lhs.m23 * rhs.m02) + (lhs.m33 * rhs.m03 + lhs.m43 * rhs.m04)), (((lhs.m04 * rhs.m00 + lhs.m14 * rhs.m01) + lhs.m24 * rhs.m02) + (lhs.m34 * rhs.m03 + lhs.m44 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)), (((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12) + (lhs.m32 * rhs.m13 + lhs.m42 * rhs.m14)), (((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + lhs.m23 * rhs.m12) + (lhs.m33 * rhs.m13 + lhs.m43 * rhs.m14)), (((lhs.m04 * rhs.m10 + lhs.m14 * rhs.m11) + lhs.m24 * rhs.m12) + (lhs.m34 * rhs.m13 + lhs.m44 * rhs.m14)), (((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22) + (lhs.m30 * rhs.m23 + lhs.m40 * rhs.m24)), (((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22) + (lhs.m31 * rhs.m23 + lhs.m41 * rhs.m24)), (((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + lhs.m22 * rhs.m22) + (lhs.m32 * rhs.m23 + lhs.m42 * rhs.m24)), (((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + lhs.m23 * rhs.m22) + (lhs.m33 * rhs.m23 + lhs.m43 * rhs.m24)), (((lhs.m04 * rhs.m20 + lhs.m14 * rhs.m21) + lhs.m24 * rhs.m22) + (lhs.m34 * rhs.m23 + lhs.m44 * rhs.m24)), (((lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31) + lhs.m20 * rhs.m32) + (lhs.m30 * rhs.m33 + lhs.m40 * rhs.m34)), (((lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31) + lhs.m21 * rhs.m32) + (lhs.m31 * rhs.m33 + lhs.m41 * rhs.m34)), (((lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31) + lhs.m22 * rhs.m32) + (lhs.m32 * rhs.m33 + lhs.m42 * rhs.m34)), (((lhs.m03 * rhs.m30 + lhs.m13 * rhs.m31) + lhs.m23 * rhs.m32) + (lhs.m33 * rhs.m33 + lhs.m43 * rhs.m34)), (((lhs.m04 * rhs.m30 + lhs.m14 * rhs.m31) + lhs.m24 * rhs.m32) + (lhs.m34 * rhs.m33 + lhs.m44 * rhs.m34)), (((lhs.m00 * rhs.m40 + lhs.m10 * rhs.m41) + lhs.m20 * rhs.m42) + (lhs.m30 * rhs.m43 + lhs.m40 * rhs.m44)), (((lhs.m01 * rhs.m40 + lhs.m11 * rhs.m41) + lhs.m21 * rhs.m42) + (lhs.m31 * rhs.m43 + lhs.m41 * rhs.m44)), (((lhs.m02 * rhs.m40 + lhs.m12 * rhs.m41) + lhs.m22 * rhs.m42) + (lhs.m32 * rhs.m43 + lhs.m42 * rhs.m44)), (((lhs.m03 * rhs.m40 + lhs.m13 * rhs.m41) + lhs.m23 * rhs.m42) + (lhs.m33 * rhs.m43 + lhs.m43 * rhs.m44)), (((lhs.m04 * rhs.m40 + lhs.m14 * rhs.m41) + lhs.m24 * rhs.m42) + (lhs.m34 * rhs.m43 + lhs.m44 * rhs.m44)));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static cvec5 operator*(cmat5 m, cvec5 v) => new cvec5((((m.m00 * v.x + m.m10 * v.y) + m.m20 * v.z) + (m.m30 * v.w + m.m40 * v.v)), (((m.m01 * v.x + m.m11 * v.y) + m.m21 * v.z) + (m.m31 * v.w + m.m41 * v.v)), (((m.m02 * v.x + m.m12 * v.y) + m.m22 * v.z) + (m.m32 * v.w + m.m42 * v.v)), (((m.m03 * v.x + m.m13 * v.y) + m.m23 * v.z) + (m.m33 * v.w + m.m43 * v.v)), (((m.m04 * v.x + m.m14 * v.y) + m.m24 * v.z) + (m.m34 * v.w + m.m44 * v.v)));
        
        /// <summary>
        /// Executes a matrix-matrix-divison A / B == A * B^-1 (use with caution).
        /// </summary>
        public static cmat5 operator/(cmat5 A, cmat5 B) => A * B.Inverse;
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static cmat5 CompMul(cmat5 A, cmat5 B) => new cmat5(A.m00 * B.m00, A.m01 * B.m01, A.m02 * B.m02, A.m03 * B.m03, A.m04 * B.m04, A.m10 * B.m10, A.m11 * B.m11, A.m12 * B.m12, A.m13 * B.m13, A.m14 * B.m14, A.m20 * B.m20, A.m21 * B.m21, A.m22 * B.m22, A.m23 * B.m23, A.m24 * B.m24, A.m30 * B.m30, A.m31 * B.m31, A.m32 * B.m32, A.m33 * B.m33, A.m34 * B.m34, A.m40 * B.m40, A.m41 * B.m41, A.m42 * B.m42, A.m43 * B.m43, A.m44 * B.m44);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static cmat5 CompDiv(cmat5 A, cmat5 B) => new cmat5(A.m00 / B.m00, A.m01 / B.m01, A.m02 / B.m02, A.m03 / B.m03, A.m04 / B.m04, A.m10 / B.m10, A.m11 / B.m11, A.m12 / B.m12, A.m13 / B.m13, A.m14 / B.m14, A.m20 / B.m20, A.m21 / B.m21, A.m22 / B.m22, A.m23 / B.m23, A.m24 / B.m24, A.m30 / B.m30, A.m31 / B.m31, A.m32 / B.m32, A.m33 / B.m33, A.m34 / B.m34, A.m40 / B.m40, A.m41 / B.m41, A.m42 / B.m42, A.m43 / B.m43, A.m44 / B.m44);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static cmat5 CompAdd(cmat5 A, cmat5 B) => new cmat5(A.m00 + B.m00, A.m01 + B.m01, A.m02 + B.m02, A.m03 + B.m03, A.m04 + B.m04, A.m10 + B.m10, A.m11 + B.m11, A.m12 + B.m12, A.m13 + B.m13, A.m14 + B.m14, A.m20 + B.m20, A.m21 + B.m21, A.m22 + B.m22, A.m23 + B.m23, A.m24 + B.m24, A.m30 + B.m30, A.m31 + B.m31, A.m32 + B.m32, A.m33 + B.m33, A.m34 + B.m34, A.m40 + B.m40, A.m41 + B.m41, A.m42 + B.m42, A.m43 + B.m43, A.m44 + B.m44);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static cmat5 CompSub(cmat5 A, cmat5 B) => new cmat5(A.m00 - B.m00, A.m01 - B.m01, A.m02 - B.m02, A.m03 - B.m03, A.m04 - B.m04, A.m10 - B.m10, A.m11 - B.m11, A.m12 - B.m12, A.m13 - B.m13, A.m14 - B.m14, A.m20 - B.m20, A.m21 - B.m21, A.m22 - B.m22, A.m23 - B.m23, A.m24 - B.m24, A.m30 - B.m30, A.m31 - B.m31, A.m32 - B.m32, A.m33 - B.m33, A.m34 - B.m34, A.m40 - B.m40, A.m41 - B.m41, A.m42 - B.m42, A.m43 - B.m43, A.m44 - B.m44);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static cmat5 operator+(cmat5 lhs, cmat5 rhs) => new cmat5(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m02 + rhs.m02, lhs.m03 + rhs.m03, lhs.m04 + rhs.m04, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11, lhs.m12 + rhs.m12, lhs.m13 + rhs.m13, lhs.m14 + rhs.m14, lhs.m20 + rhs.m20, lhs.m21 + rhs.m21, lhs.m22 + rhs.m22, lhs.m23 + rhs.m23, lhs.m24 + rhs.m24, lhs.m30 + rhs.m30, lhs.m31 + rhs.m31, lhs.m32 + rhs.m32, lhs.m33 + rhs.m33, lhs.m34 + rhs.m34, lhs.m40 + rhs.m40, lhs.m41 + rhs.m41, lhs.m42 + rhs.m42, lhs.m43 + rhs.m43, lhs.m44 + rhs.m44);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static cmat5 operator+(cmat5 lhs, Complex rhs) => new cmat5(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m02 + rhs, lhs.m03 + rhs, lhs.m04 + rhs, lhs.m10 + rhs, lhs.m11 + rhs, lhs.m12 + rhs, lhs.m13 + rhs, lhs.m14 + rhs, lhs.m20 + rhs, lhs.m21 + rhs, lhs.m22 + rhs, lhs.m23 + rhs, lhs.m24 + rhs, lhs.m30 + rhs, lhs.m31 + rhs, lhs.m32 + rhs, lhs.m33 + rhs, lhs.m34 + rhs, lhs.m40 + rhs, lhs.m41 + rhs, lhs.m42 + rhs, lhs.m43 + rhs, lhs.m44 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static cmat5 operator+(Complex lhs, cmat5 rhs) => new cmat5(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m02, lhs + rhs.m03, lhs + rhs.m04, lhs + rhs.m10, lhs + rhs.m11, lhs + rhs.m12, lhs + rhs.m13, lhs + rhs.m14, lhs + rhs.m20, lhs + rhs.m21, lhs + rhs.m22, lhs + rhs.m23, lhs + rhs.m24, lhs + rhs.m30, lhs + rhs.m31, lhs + rhs.m32, lhs + rhs.m33, lhs + rhs.m34, lhs + rhs.m40, lhs + rhs.m41, lhs + rhs.m42, lhs + rhs.m43, lhs + rhs.m44);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static cmat5 operator-(cmat5 lhs, cmat5 rhs) => new cmat5(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m02 - rhs.m02, lhs.m03 - rhs.m03, lhs.m04 - rhs.m04, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11, lhs.m12 - rhs.m12, lhs.m13 - rhs.m13, lhs.m14 - rhs.m14, lhs.m20 - rhs.m20, lhs.m21 - rhs.m21, lhs.m22 - rhs.m22, lhs.m23 - rhs.m23, lhs.m24 - rhs.m24, lhs.m30 - rhs.m30, lhs.m31 - rhs.m31, lhs.m32 - rhs.m32, lhs.m33 - rhs.m33, lhs.m34 - rhs.m34, lhs.m40 - rhs.m40, lhs.m41 - rhs.m41, lhs.m42 - rhs.m42, lhs.m43 - rhs.m43, lhs.m44 - rhs.m44);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static cmat5 operator-(cmat5 lhs, Complex rhs) => new cmat5(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m02 - rhs, lhs.m03 - rhs, lhs.m04 - rhs, lhs.m10 - rhs, lhs.m11 - rhs, lhs.m12 - rhs, lhs.m13 - rhs, lhs.m14 - rhs, lhs.m20 - rhs, lhs.m21 - rhs, lhs.m22 - rhs, lhs.m23 - rhs, lhs.m24 - rhs, lhs.m30 - rhs, lhs.m31 - rhs, lhs.m32 - rhs, lhs.m33 - rhs, lhs.m34 - rhs, lhs.m40 - rhs, lhs.m41 - rhs, lhs.m42 - rhs, lhs.m43 - rhs, lhs.m44 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static cmat5 operator-(Complex lhs, cmat5 rhs) => new cmat5(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m02, lhs - rhs.m03, lhs - rhs.m04, lhs - rhs.m10, lhs - rhs.m11, lhs - rhs.m12, lhs - rhs.m13, lhs - rhs.m14, lhs - rhs.m20, lhs - rhs.m21, lhs - rhs.m22, lhs - rhs.m23, lhs - rhs.m24, lhs - rhs.m30, lhs - rhs.m31, lhs - rhs.m32, lhs - rhs.m33, lhs - rhs.m34, lhs - rhs.m40, lhs - rhs.m41, lhs - rhs.m42, lhs - rhs.m43, lhs - rhs.m44);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static cmat5 operator/(cmat5 lhs, Complex rhs) => new cmat5(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m02 / rhs, lhs.m03 / rhs, lhs.m04 / rhs, lhs.m10 / rhs, lhs.m11 / rhs, lhs.m12 / rhs, lhs.m13 / rhs, lhs.m14 / rhs, lhs.m20 / rhs, lhs.m21 / rhs, lhs.m22 / rhs, lhs.m23 / rhs, lhs.m24 / rhs, lhs.m30 / rhs, lhs.m31 / rhs, lhs.m32 / rhs, lhs.m33 / rhs, lhs.m34 / rhs, lhs.m40 / rhs, lhs.m41 / rhs, lhs.m42 / rhs, lhs.m43 / rhs, lhs.m44 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static cmat5 operator/(Complex lhs, cmat5 rhs) => new cmat5(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m02, lhs / rhs.m03, lhs / rhs.m04, lhs / rhs.m10, lhs / rhs.m11, lhs / rhs.m12, lhs / rhs.m13, lhs / rhs.m14, lhs / rhs.m20, lhs / rhs.m21, lhs / rhs.m22, lhs / rhs.m23, lhs / rhs.m24, lhs / rhs.m30, lhs / rhs.m31, lhs / rhs.m32, lhs / rhs.m33, lhs / rhs.m34, lhs / rhs.m40, lhs / rhs.m41, lhs / rhs.m42, lhs / rhs.m43, lhs / rhs.m44);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static cmat5 operator*(cmat5 lhs, Complex rhs) => new cmat5(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m02 * rhs, lhs.m03 * rhs, lhs.m04 * rhs, lhs.m10 * rhs, lhs.m11 * rhs, lhs.m12 * rhs, lhs.m13 * rhs, lhs.m14 * rhs, lhs.m20 * rhs, lhs.m21 * rhs, lhs.m22 * rhs, lhs.m23 * rhs, lhs.m24 * rhs, lhs.m30 * rhs, lhs.m31 * rhs, lhs.m32 * rhs, lhs.m33 * rhs, lhs.m34 * rhs, lhs.m40 * rhs, lhs.m41 * rhs, lhs.m42 * rhs, lhs.m43 * rhs, lhs.m44 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static cmat5 operator*(Complex lhs, cmat5 rhs) => new cmat5(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m02, lhs * rhs.m03, lhs * rhs.m04, lhs * rhs.m10, lhs * rhs.m11, lhs * rhs.m12, lhs * rhs.m13, lhs * rhs.m14, lhs * rhs.m20, lhs * rhs.m21, lhs * rhs.m22, lhs * rhs.m23, lhs * rhs.m24, lhs * rhs.m30, lhs * rhs.m31, lhs * rhs.m32, lhs * rhs.m33, lhs * rhs.m34, lhs * rhs.m40, lhs * rhs.m41, lhs * rhs.m42, lhs * rhs.m43, lhs * rhs.m44);
    }
}
