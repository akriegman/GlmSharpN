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
    /// A matrix of type float with 5 columns and 4 rows.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct mat5x4 : IEnumerable<float>, IEquatable<mat5x4>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        public float m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        public float m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        public float m02;
        
        /// <summary>
        /// Column 0, Rows 3
        /// </summary>
        public float m03;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        public float m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        public float m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        public float m12;
        
        /// <summary>
        /// Column 1, Rows 3
        /// </summary>
        public float m13;
        
        /// <summary>
        /// Column 2, Rows 0
        /// </summary>
        public float m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        public float m21;
        
        /// <summary>
        /// Column 2, Rows 2
        /// </summary>
        public float m22;
        
        /// <summary>
        /// Column 2, Rows 3
        /// </summary>
        public float m23;
        
        /// <summary>
        /// Column 3, Rows 0
        /// </summary>
        public float m30;
        
        /// <summary>
        /// Column 3, Rows 1
        /// </summary>
        public float m31;
        
        /// <summary>
        /// Column 3, Rows 2
        /// </summary>
        public float m32;
        
        /// <summary>
        /// Column 3, Rows 3
        /// </summary>
        public float m33;
        
        /// <summary>
        /// Column 4, Rows 0
        /// </summary>
        public float m40;
        
        /// <summary>
        /// Column 4, Rows 1
        /// </summary>
        public float m41;
        
        /// <summary>
        /// Column 4, Rows 2
        /// </summary>
        public float m42;
        
        /// <summary>
        /// Column 4, Rows 3
        /// </summary>
        public float m43;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public mat5x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33, float m40, float m41, float m42, float m43)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m03 = m03;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m30 = m30;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
            this.m40 = m40;
            this.m41 = m41;
            this.m42 = m42;
            this.m43 = m43;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0f;
            this.m03 = 0f;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0f;
            this.m13 = 0f;
            this.m20 = 0f;
            this.m21 = 0f;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0f;
            this.m03 = 0f;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0f;
            this.m13 = 0f;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0f;
            this.m03 = 0f;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0f;
            this.m13 = 0f;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat5x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat5x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0f;
            this.m03 = 0f;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0f;
            this.m13 = 0f;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0f;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0f;
            this.m20 = 0f;
            this.m21 = 0f;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0f;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0f;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = 0f;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0f;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0f;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = 0f;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat5x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat5x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0f;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0f;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = 0f;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = 1f;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = m.m42;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = 0f;
            this.m21 = 0f;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat3x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat5x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat5x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = m.m42;
            this.m43 = m.m43;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat2x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat2x5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = 0f;
            this.m21 = 0f;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat3x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat3x5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat4x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat4x5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a mat5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(mat5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = m.m42;
            this.m43 = m.m43;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec2 c0, vec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0f;
            this.m03 = 0f;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0f;
            this.m13 = 0f;
            this.m20 = 0f;
            this.m21 = 0f;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec2 c0, vec2 c1, vec2 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0f;
            this.m03 = 0f;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0f;
            this.m13 = 0f;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec2 c0, vec2 c1, vec2 c2, vec2 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0f;
            this.m03 = 0f;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0f;
            this.m13 = 0f;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec2 c0, vec2 c1, vec2 c2, vec2 c3, vec2 c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0f;
            this.m03 = 0f;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0f;
            this.m13 = 0f;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec3 c0, vec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0f;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0f;
            this.m20 = 0f;
            this.m21 = 0f;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec3 c0, vec3 c1, vec3 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0f;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0f;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = 0f;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec3 c0, vec3 c1, vec3 c2, vec3 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0f;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0f;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = 0f;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec3 c0, vec3 c1, vec3 c2, vec3 c3, vec3 c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0f;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0f;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = 0f;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = 1f;
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = c4.z;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec4 c0, vec4 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m20 = 0f;
            this.m21 = 0f;
            this.m22 = 1f;
            this.m23 = 0f;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec4 c0, vec4 c1, vec4 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m30 = 0f;
            this.m31 = 0f;
            this.m32 = 0f;
            this.m33 = 1f;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec4 c0, vec4 c1, vec4 c2, vec4 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = c3.w;
            this.m40 = 0f;
            this.m41 = 0f;
            this.m42 = 0f;
            this.m43 = 0f;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public mat5x4(vec4 c0, vec4 c1, vec4 c2, vec4 c3, vec4 c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = c3.w;
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = c4.z;
            this.m43 = c4.w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public float[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 }, { m20, m21, m22, m23 }, { m30, m31, m32, m33 }, { m40, m41, m42, m43 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public float[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33, m40, m41, m42, m43 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public vec4 Column0
        {
            get
            {
                return new vec4(m00, m01, m02, m03);
            }
            set
            {
                m00 = value.x;
                m01 = value.y;
                m02 = value.z;
                m03 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 1
        /// </summary>
        public vec4 Column1
        {
            get
            {
                return new vec4(m10, m11, m12, m13);
            }
            set
            {
                m10 = value.x;
                m11 = value.y;
                m12 = value.z;
                m13 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 2
        /// </summary>
        public vec4 Column2
        {
            get
            {
                return new vec4(m20, m21, m22, m23);
            }
            set
            {
                m20 = value.x;
                m21 = value.y;
                m22 = value.z;
                m23 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 3
        /// </summary>
        public vec4 Column3
        {
            get
            {
                return new vec4(m30, m31, m32, m33);
            }
            set
            {
                m30 = value.x;
                m31 = value.y;
                m32 = value.z;
                m33 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 4
        /// </summary>
        public vec4 Column4
        {
            get
            {
                return new vec4(m40, m41, m42, m43);
            }
            set
            {
                m40 = value.x;
                m41 = value.y;
                m42 = value.z;
                m43 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 0
        /// </summary>
        public vec5 Row0
        {
            get
            {
                return new vec5(m00, m10, m20, m30, m40);
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
        public vec5 Row1
        {
            get
            {
                return new vec5(m01, m11, m21, m31, m41);
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
        public vec5 Row2
        {
            get
            {
                return new vec5(m02, m12, m22, m32, m42);
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
        public vec5 Row3
        {
            get
            {
                return new vec5(m03, m13, m23, m33, m43);
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

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static mat5x4 Zero { get; } = new mat5x4(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static mat5x4 Ones { get; } = new mat5x4(1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static mat5x4 Identity { get; } = new mat5x4(1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-MaxValue matrix
        /// </summary>
        public static mat5x4 AllMaxValue { get; } = new mat5x4(float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue);
        
        /// <summary>
        /// Predefined diagonal-MaxValue matrix
        /// </summary>
        public static mat5x4 DiagonalMaxValue { get; } = new mat5x4(float.MaxValue, 0f, 0f, 0f, 0f, float.MaxValue, 0f, 0f, 0f, 0f, float.MaxValue, 0f, 0f, 0f, 0f, float.MaxValue, 0f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-MinValue matrix
        /// </summary>
        public static mat5x4 AllMinValue { get; } = new mat5x4(float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue, float.MinValue);
        
        /// <summary>
        /// Predefined diagonal-MinValue matrix
        /// </summary>
        public static mat5x4 DiagonalMinValue { get; } = new mat5x4(float.MinValue, 0f, 0f, 0f, 0f, float.MinValue, 0f, 0f, 0f, 0f, float.MinValue, 0f, 0f, 0f, 0f, float.MinValue, 0f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-Epsilon matrix
        /// </summary>
        public static mat5x4 AllEpsilon { get; } = new mat5x4(float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon);
        
        /// <summary>
        /// Predefined diagonal-Epsilon matrix
        /// </summary>
        public static mat5x4 DiagonalEpsilon { get; } = new mat5x4(float.Epsilon, 0f, 0f, 0f, 0f, float.Epsilon, 0f, 0f, 0f, 0f, float.Epsilon, 0f, 0f, 0f, 0f, float.Epsilon, 0f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-NaN matrix
        /// </summary>
        public static mat5x4 AllNaN { get; } = new mat5x4(float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN, float.NaN);
        
        /// <summary>
        /// Predefined diagonal-NaN matrix
        /// </summary>
        public static mat5x4 DiagonalNaN { get; } = new mat5x4(float.NaN, 0f, 0f, 0f, 0f, float.NaN, 0f, 0f, 0f, 0f, float.NaN, 0f, 0f, 0f, 0f, float.NaN, 0f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-NegativeInfinity matrix
        /// </summary>
        public static mat5x4 AllNegativeInfinity { get; } = new mat5x4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        
        /// <summary>
        /// Predefined diagonal-NegativeInfinity matrix
        /// </summary>
        public static mat5x4 DiagonalNegativeInfinity { get; } = new mat5x4(float.NegativeInfinity, 0f, 0f, 0f, 0f, float.NegativeInfinity, 0f, 0f, 0f, 0f, float.NegativeInfinity, 0f, 0f, 0f, 0f, float.NegativeInfinity, 0f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-PositiveInfinity matrix
        /// </summary>
        public static mat5x4 AllPositiveInfinity { get; } = new mat5x4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
        
        /// <summary>
        /// Predefined diagonal-PositiveInfinity matrix
        /// </summary>
        public static mat5x4 DiagonalPositiveInfinity { get; } = new mat5x4(float.PositiveInfinity, 0f, 0f, 0f, 0f, float.PositiveInfinity, 0f, 0f, 0f, 0f, float.PositiveInfinity, 0f, 0f, 0f, 0f, float.PositiveInfinity, 0f, 0f, 0f, 0f);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<float> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m02;
            yield return m03;
            yield return m10;
            yield return m11;
            yield return m12;
            yield return m13;
            yield return m20;
            yield return m21;
            yield return m22;
            yield return m23;
            yield return m30;
            yield return m31;
            yield return m32;
            yield return m33;
            yield return m40;
            yield return m41;
            yield return m42;
            yield return m43;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (5 x 4 = 20).
        /// </summary>
        public int Count => 20;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public float this[int fieldIndex]
        {
            get
            {
                switch (fieldIndex)
                {
                    case 0: return m00;
                    case 1: return m01;
                    case 2: return m02;
                    case 3: return m03;
                    case 4: return m10;
                    case 5: return m11;
                    case 6: return m12;
                    case 7: return m13;
                    case 8: return m20;
                    case 9: return m21;
                    case 10: return m22;
                    case 11: return m23;
                    case 12: return m30;
                    case 13: return m31;
                    case 14: return m32;
                    case 15: return m33;
                    case 16: return m40;
                    case 17: return m41;
                    case 18: return m42;
                    case 19: return m43;
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
                    case 4: this.m10 = value; break;
                    case 5: this.m11 = value; break;
                    case 6: this.m12 = value; break;
                    case 7: this.m13 = value; break;
                    case 8: this.m20 = value; break;
                    case 9: this.m21 = value; break;
                    case 10: this.m22 = value; break;
                    case 11: this.m23 = value; break;
                    case 12: this.m30 = value; break;
                    case 13: this.m31 = value; break;
                    case 14: this.m32 = value; break;
                    case 15: this.m33 = value; break;
                    case 16: this.m40 = value; break;
                    case 17: this.m41 = value; break;
                    case 18: this.m42 = value; break;
                    case 19: this.m43 = value; break;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public float this[int col, int row]
        {
            get
            {
                return this[col * 4 + row];
            }
            set
            {
                this[col * 4 + row] = value;
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(mat5x4 rhs) => (((((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && m02.Equals(rhs.m02)) && (m03.Equals(rhs.m03) && m10.Equals(rhs.m10))) && (((m11.Equals(rhs.m11) && m12.Equals(rhs.m12)) && m13.Equals(rhs.m13)) && (m20.Equals(rhs.m20) && m21.Equals(rhs.m21)))) && ((((m22.Equals(rhs.m22) && m23.Equals(rhs.m23)) && m30.Equals(rhs.m30)) && (m31.Equals(rhs.m31) && m32.Equals(rhs.m32))) && (((m33.Equals(rhs.m33) && m40.Equals(rhs.m40)) && m41.Equals(rhs.m41)) && (m42.Equals(rhs.m42) && m43.Equals(rhs.m43)))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is mat5x4 && Equals((mat5x4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(mat5x4 lhs, mat5x4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(mat5x4 lhs, mat5x4 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((((((((((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m02.GetHashCode()) * 397) ^ m03.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m12.GetHashCode()) * 397) ^ m13.GetHashCode()) * 397) ^ m20.GetHashCode()) * 397) ^ m21.GetHashCode()) * 397) ^ m22.GetHashCode()) * 397) ^ m23.GetHashCode()) * 397) ^ m30.GetHashCode()) * 397) ^ m31.GetHashCode()) * 397) ^ m32.GetHashCode()) * 397) ^ m33.GetHashCode()) * 397) ^ m40.GetHashCode()) * 397) ^ m41.GetHashCode()) * 397) ^ m42.GetHashCode()) * 397) ^ m43.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public mat4x5 Transposed => new mat4x5(m00, m10, m20, m30, m40, m01, m11, m21, m31, m41, m02, m12, m22, m32, m42, m03, m13, m23, m33, m43);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public float MinElement => Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(m00, m01), m02), m03), m10), m11), m12), m13), m20), m21), m22), m23), m30), m31), m32), m33), m40), m41), m42), m43);
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public float MaxElement => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(m00, m01), m02), m03), m10), m11), m12), m13), m20), m21), m22), m23), m30), m31), m32), m33), m40), m41), m42), m43);
        
        /// <summary>
        /// Returns the euclidean length of this matrix.
        /// </summary>
        public float Length => (float)Math.Sqrt((((((m00*m00 + m01*m01) + m02*m02) + (m03*m03 + m10*m10)) + (((m11*m11 + m12*m12) + m13*m13) + (m20*m20 + m21*m21))) + ((((m22*m22 + m23*m23) + m30*m30) + (m31*m31 + m32*m32)) + (((m33*m33 + m40*m40) + m41*m41) + (m42*m42 + m43*m43)))));
        
        /// <summary>
        /// Returns the squared euclidean length of this matrix.
        /// </summary>
        public float LengthSqr => (((((m00*m00 + m01*m01) + m02*m02) + (m03*m03 + m10*m10)) + (((m11*m11 + m12*m12) + m13*m13) + (m20*m20 + m21*m21))) + ((((m22*m22 + m23*m23) + m30*m30) + (m31*m31 + m32*m32)) + (((m33*m33 + m40*m40) + m41*m41) + (m42*m42 + m43*m43))));
        
        /// <summary>
        /// Returns the sum of all fields.
        /// </summary>
        public float Sum => (((((m00 + m01) + m02) + (m03 + m10)) + (((m11 + m12) + m13) + (m20 + m21))) + ((((m22 + m23) + m30) + (m31 + m32)) + (((m33 + m40) + m41) + (m42 + m43))));
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public float Norm => (float)Math.Sqrt((((((m00*m00 + m01*m01) + m02*m02) + (m03*m03 + m10*m10)) + (((m11*m11 + m12*m12) + m13*m13) + (m20*m20 + m21*m21))) + ((((m22*m22 + m23*m23) + m30*m30) + (m31*m31 + m32*m32)) + (((m33*m33 + m40*m40) + m41*m41) + (m42*m42 + m43*m43)))));
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public float Norm1 => (((((Math.Abs(m00) + Math.Abs(m01)) + Math.Abs(m02)) + (Math.Abs(m03) + Math.Abs(m10))) + (((Math.Abs(m11) + Math.Abs(m12)) + Math.Abs(m13)) + (Math.Abs(m20) + Math.Abs(m21)))) + ((((Math.Abs(m22) + Math.Abs(m23)) + Math.Abs(m30)) + (Math.Abs(m31) + Math.Abs(m32))) + (((Math.Abs(m33) + Math.Abs(m40)) + Math.Abs(m41)) + (Math.Abs(m42) + Math.Abs(m43)))));
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt((((((m00*m00 + m01*m01) + m02*m02) + (m03*m03 + m10*m10)) + (((m11*m11 + m12*m12) + m13*m13) + (m20*m20 + m21*m21))) + ((((m22*m22 + m23*m23) + m30*m30) + (m31*m31 + m32*m32)) + (((m33*m33 + m40*m40) + m41*m41) + (m42*m42 + m43*m43)))));
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public float NormMax => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Abs(m00), Math.Abs(m01)), Math.Abs(m02)), Math.Abs(m03)), Math.Abs(m10)), Math.Abs(m11)), Math.Abs(m12)), Math.Abs(m13)), Math.Abs(m20)), Math.Abs(m21)), Math.Abs(m22)), Math.Abs(m23)), Math.Abs(m30)), Math.Abs(m31)), Math.Abs(m32)), Math.Abs(m33)), Math.Abs(m40)), Math.Abs(m41)), Math.Abs(m42)), Math.Abs(m43));
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow((((((Math.Pow((double)Math.Abs(m00), p) + Math.Pow((double)Math.Abs(m01), p)) + Math.Pow((double)Math.Abs(m02), p)) + (Math.Pow((double)Math.Abs(m03), p) + Math.Pow((double)Math.Abs(m10), p))) + (((Math.Pow((double)Math.Abs(m11), p) + Math.Pow((double)Math.Abs(m12), p)) + Math.Pow((double)Math.Abs(m13), p)) + (Math.Pow((double)Math.Abs(m20), p) + Math.Pow((double)Math.Abs(m21), p)))) + ((((Math.Pow((double)Math.Abs(m22), p) + Math.Pow((double)Math.Abs(m23), p)) + Math.Pow((double)Math.Abs(m30), p)) + (Math.Pow((double)Math.Abs(m31), p) + Math.Pow((double)Math.Abs(m32), p))) + (((Math.Pow((double)Math.Abs(m33), p) + Math.Pow((double)Math.Abs(m40), p)) + Math.Pow((double)Math.Abs(m41), p)) + (Math.Pow((double)Math.Abs(m42), p) + Math.Pow((double)Math.Abs(m43), p))))), 1 / p);
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication mat5x4 * mat2x5 -> mat2x4.
        /// </summary>
        public static mat2x4 operator*(mat5x4 lhs, mat2x5 rhs) => new mat2x4((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02) + (lhs.m32 * rhs.m03 + lhs.m42 * rhs.m04)), (((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + lhs.m23 * rhs.m02) + (lhs.m33 * rhs.m03 + lhs.m43 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)), (((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12) + (lhs.m32 * rhs.m13 + lhs.m42 * rhs.m14)), (((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + lhs.m23 * rhs.m12) + (lhs.m33 * rhs.m13 + lhs.m43 * rhs.m14)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication mat5x4 * mat3x5 -> mat3x4.
        /// </summary>
        public static mat3x4 operator*(mat5x4 lhs, mat3x5 rhs) => new mat3x4((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02) + (lhs.m32 * rhs.m03 + lhs.m42 * rhs.m04)), (((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + lhs.m23 * rhs.m02) + (lhs.m33 * rhs.m03 + lhs.m43 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)), (((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12) + (lhs.m32 * rhs.m13 + lhs.m42 * rhs.m14)), (((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + lhs.m23 * rhs.m12) + (lhs.m33 * rhs.m13 + lhs.m43 * rhs.m14)), (((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22) + (lhs.m30 * rhs.m23 + lhs.m40 * rhs.m24)), (((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22) + (lhs.m31 * rhs.m23 + lhs.m41 * rhs.m24)), (((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + lhs.m22 * rhs.m22) + (lhs.m32 * rhs.m23 + lhs.m42 * rhs.m24)), (((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + lhs.m23 * rhs.m22) + (lhs.m33 * rhs.m23 + lhs.m43 * rhs.m24)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication mat5x4 * mat4x5 -> mat4.
        /// </summary>
        public static mat4 operator*(mat5x4 lhs, mat4x5 rhs) => new mat4((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02) + (lhs.m32 * rhs.m03 + lhs.m42 * rhs.m04)), (((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + lhs.m23 * rhs.m02) + (lhs.m33 * rhs.m03 + lhs.m43 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)), (((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12) + (lhs.m32 * rhs.m13 + lhs.m42 * rhs.m14)), (((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + lhs.m23 * rhs.m12) + (lhs.m33 * rhs.m13 + lhs.m43 * rhs.m14)), (((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22) + (lhs.m30 * rhs.m23 + lhs.m40 * rhs.m24)), (((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22) + (lhs.m31 * rhs.m23 + lhs.m41 * rhs.m24)), (((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + lhs.m22 * rhs.m22) + (lhs.m32 * rhs.m23 + lhs.m42 * rhs.m24)), (((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + lhs.m23 * rhs.m22) + (lhs.m33 * rhs.m23 + lhs.m43 * rhs.m24)), (((lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31) + lhs.m20 * rhs.m32) + (lhs.m30 * rhs.m33 + lhs.m40 * rhs.m34)), (((lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31) + lhs.m21 * rhs.m32) + (lhs.m31 * rhs.m33 + lhs.m41 * rhs.m34)), (((lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31) + lhs.m22 * rhs.m32) + (lhs.m32 * rhs.m33 + lhs.m42 * rhs.m34)), (((lhs.m03 * rhs.m30 + lhs.m13 * rhs.m31) + lhs.m23 * rhs.m32) + (lhs.m33 * rhs.m33 + lhs.m43 * rhs.m34)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication mat5x4 * mat5 -> mat5x4.
        /// </summary>
        public static mat5x4 operator*(mat5x4 lhs, mat5 rhs) => new mat5x4((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02) + (lhs.m32 * rhs.m03 + lhs.m42 * rhs.m04)), (((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + lhs.m23 * rhs.m02) + (lhs.m33 * rhs.m03 + lhs.m43 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)), (((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12) + (lhs.m32 * rhs.m13 + lhs.m42 * rhs.m14)), (((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + lhs.m23 * rhs.m12) + (lhs.m33 * rhs.m13 + lhs.m43 * rhs.m14)), (((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22) + (lhs.m30 * rhs.m23 + lhs.m40 * rhs.m24)), (((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22) + (lhs.m31 * rhs.m23 + lhs.m41 * rhs.m24)), (((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + lhs.m22 * rhs.m22) + (lhs.m32 * rhs.m23 + lhs.m42 * rhs.m24)), (((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + lhs.m23 * rhs.m22) + (lhs.m33 * rhs.m23 + lhs.m43 * rhs.m24)), (((lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31) + lhs.m20 * rhs.m32) + (lhs.m30 * rhs.m33 + lhs.m40 * rhs.m34)), (((lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31) + lhs.m21 * rhs.m32) + (lhs.m31 * rhs.m33 + lhs.m41 * rhs.m34)), (((lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31) + lhs.m22 * rhs.m32) + (lhs.m32 * rhs.m33 + lhs.m42 * rhs.m34)), (((lhs.m03 * rhs.m30 + lhs.m13 * rhs.m31) + lhs.m23 * rhs.m32) + (lhs.m33 * rhs.m33 + lhs.m43 * rhs.m34)), (((lhs.m00 * rhs.m40 + lhs.m10 * rhs.m41) + lhs.m20 * rhs.m42) + (lhs.m30 * rhs.m43 + lhs.m40 * rhs.m44)), (((lhs.m01 * rhs.m40 + lhs.m11 * rhs.m41) + lhs.m21 * rhs.m42) + (lhs.m31 * rhs.m43 + lhs.m41 * rhs.m44)), (((lhs.m02 * rhs.m40 + lhs.m12 * rhs.m41) + lhs.m22 * rhs.m42) + (lhs.m32 * rhs.m43 + lhs.m42 * rhs.m44)), (((lhs.m03 * rhs.m40 + lhs.m13 * rhs.m41) + lhs.m23 * rhs.m42) + (lhs.m33 * rhs.m43 + lhs.m43 * rhs.m44)));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static vec4 operator*(mat5x4 m, vec5 v) => new vec4((((m.m00 * v.x + m.m10 * v.y) + m.m20 * v.z) + (m.m30 * v.w + m.m40 * v.v)), (((m.m01 * v.x + m.m11 * v.y) + m.m21 * v.z) + (m.m31 * v.w + m.m41 * v.v)), (((m.m02 * v.x + m.m12 * v.y) + m.m22 * v.z) + (m.m32 * v.w + m.m42 * v.v)), (((m.m03 * v.x + m.m13 * v.y) + m.m23 * v.z) + (m.m33 * v.w + m.m43 * v.v)));
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static mat5x4 CompMul(mat5x4 A, mat5x4 B) => new mat5x4(A.m00 * B.m00, A.m01 * B.m01, A.m02 * B.m02, A.m03 * B.m03, A.m10 * B.m10, A.m11 * B.m11, A.m12 * B.m12, A.m13 * B.m13, A.m20 * B.m20, A.m21 * B.m21, A.m22 * B.m22, A.m23 * B.m23, A.m30 * B.m30, A.m31 * B.m31, A.m32 * B.m32, A.m33 * B.m33, A.m40 * B.m40, A.m41 * B.m41, A.m42 * B.m42, A.m43 * B.m43);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static mat5x4 CompDiv(mat5x4 A, mat5x4 B) => new mat5x4(A.m00 / B.m00, A.m01 / B.m01, A.m02 / B.m02, A.m03 / B.m03, A.m10 / B.m10, A.m11 / B.m11, A.m12 / B.m12, A.m13 / B.m13, A.m20 / B.m20, A.m21 / B.m21, A.m22 / B.m22, A.m23 / B.m23, A.m30 / B.m30, A.m31 / B.m31, A.m32 / B.m32, A.m33 / B.m33, A.m40 / B.m40, A.m41 / B.m41, A.m42 / B.m42, A.m43 / B.m43);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static mat5x4 CompAdd(mat5x4 A, mat5x4 B) => new mat5x4(A.m00 + B.m00, A.m01 + B.m01, A.m02 + B.m02, A.m03 + B.m03, A.m10 + B.m10, A.m11 + B.m11, A.m12 + B.m12, A.m13 + B.m13, A.m20 + B.m20, A.m21 + B.m21, A.m22 + B.m22, A.m23 + B.m23, A.m30 + B.m30, A.m31 + B.m31, A.m32 + B.m32, A.m33 + B.m33, A.m40 + B.m40, A.m41 + B.m41, A.m42 + B.m42, A.m43 + B.m43);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static mat5x4 CompSub(mat5x4 A, mat5x4 B) => new mat5x4(A.m00 - B.m00, A.m01 - B.m01, A.m02 - B.m02, A.m03 - B.m03, A.m10 - B.m10, A.m11 - B.m11, A.m12 - B.m12, A.m13 - B.m13, A.m20 - B.m20, A.m21 - B.m21, A.m22 - B.m22, A.m23 - B.m23, A.m30 - B.m30, A.m31 - B.m31, A.m32 - B.m32, A.m33 - B.m33, A.m40 - B.m40, A.m41 - B.m41, A.m42 - B.m42, A.m43 - B.m43);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static mat5x4 operator+(mat5x4 lhs, mat5x4 rhs) => new mat5x4(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m02 + rhs.m02, lhs.m03 + rhs.m03, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11, lhs.m12 + rhs.m12, lhs.m13 + rhs.m13, lhs.m20 + rhs.m20, lhs.m21 + rhs.m21, lhs.m22 + rhs.m22, lhs.m23 + rhs.m23, lhs.m30 + rhs.m30, lhs.m31 + rhs.m31, lhs.m32 + rhs.m32, lhs.m33 + rhs.m33, lhs.m40 + rhs.m40, lhs.m41 + rhs.m41, lhs.m42 + rhs.m42, lhs.m43 + rhs.m43);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static mat5x4 operator+(mat5x4 lhs, float rhs) => new mat5x4(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m02 + rhs, lhs.m03 + rhs, lhs.m10 + rhs, lhs.m11 + rhs, lhs.m12 + rhs, lhs.m13 + rhs, lhs.m20 + rhs, lhs.m21 + rhs, lhs.m22 + rhs, lhs.m23 + rhs, lhs.m30 + rhs, lhs.m31 + rhs, lhs.m32 + rhs, lhs.m33 + rhs, lhs.m40 + rhs, lhs.m41 + rhs, lhs.m42 + rhs, lhs.m43 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static mat5x4 operator+(float lhs, mat5x4 rhs) => new mat5x4(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m02, lhs + rhs.m03, lhs + rhs.m10, lhs + rhs.m11, lhs + rhs.m12, lhs + rhs.m13, lhs + rhs.m20, lhs + rhs.m21, lhs + rhs.m22, lhs + rhs.m23, lhs + rhs.m30, lhs + rhs.m31, lhs + rhs.m32, lhs + rhs.m33, lhs + rhs.m40, lhs + rhs.m41, lhs + rhs.m42, lhs + rhs.m43);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static mat5x4 operator-(mat5x4 lhs, mat5x4 rhs) => new mat5x4(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m02 - rhs.m02, lhs.m03 - rhs.m03, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11, lhs.m12 - rhs.m12, lhs.m13 - rhs.m13, lhs.m20 - rhs.m20, lhs.m21 - rhs.m21, lhs.m22 - rhs.m22, lhs.m23 - rhs.m23, lhs.m30 - rhs.m30, lhs.m31 - rhs.m31, lhs.m32 - rhs.m32, lhs.m33 - rhs.m33, lhs.m40 - rhs.m40, lhs.m41 - rhs.m41, lhs.m42 - rhs.m42, lhs.m43 - rhs.m43);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static mat5x4 operator-(mat5x4 lhs, float rhs) => new mat5x4(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m02 - rhs, lhs.m03 - rhs, lhs.m10 - rhs, lhs.m11 - rhs, lhs.m12 - rhs, lhs.m13 - rhs, lhs.m20 - rhs, lhs.m21 - rhs, lhs.m22 - rhs, lhs.m23 - rhs, lhs.m30 - rhs, lhs.m31 - rhs, lhs.m32 - rhs, lhs.m33 - rhs, lhs.m40 - rhs, lhs.m41 - rhs, lhs.m42 - rhs, lhs.m43 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static mat5x4 operator-(float lhs, mat5x4 rhs) => new mat5x4(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m02, lhs - rhs.m03, lhs - rhs.m10, lhs - rhs.m11, lhs - rhs.m12, lhs - rhs.m13, lhs - rhs.m20, lhs - rhs.m21, lhs - rhs.m22, lhs - rhs.m23, lhs - rhs.m30, lhs - rhs.m31, lhs - rhs.m32, lhs - rhs.m33, lhs - rhs.m40, lhs - rhs.m41, lhs - rhs.m42, lhs - rhs.m43);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static mat5x4 operator/(mat5x4 lhs, float rhs) => new mat5x4(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m02 / rhs, lhs.m03 / rhs, lhs.m10 / rhs, lhs.m11 / rhs, lhs.m12 / rhs, lhs.m13 / rhs, lhs.m20 / rhs, lhs.m21 / rhs, lhs.m22 / rhs, lhs.m23 / rhs, lhs.m30 / rhs, lhs.m31 / rhs, lhs.m32 / rhs, lhs.m33 / rhs, lhs.m40 / rhs, lhs.m41 / rhs, lhs.m42 / rhs, lhs.m43 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static mat5x4 operator/(float lhs, mat5x4 rhs) => new mat5x4(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m02, lhs / rhs.m03, lhs / rhs.m10, lhs / rhs.m11, lhs / rhs.m12, lhs / rhs.m13, lhs / rhs.m20, lhs / rhs.m21, lhs / rhs.m22, lhs / rhs.m23, lhs / rhs.m30, lhs / rhs.m31, lhs / rhs.m32, lhs / rhs.m33, lhs / rhs.m40, lhs / rhs.m41, lhs / rhs.m42, lhs / rhs.m43);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static mat5x4 operator*(mat5x4 lhs, float rhs) => new mat5x4(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m02 * rhs, lhs.m03 * rhs, lhs.m10 * rhs, lhs.m11 * rhs, lhs.m12 * rhs, lhs.m13 * rhs, lhs.m20 * rhs, lhs.m21 * rhs, lhs.m22 * rhs, lhs.m23 * rhs, lhs.m30 * rhs, lhs.m31 * rhs, lhs.m32 * rhs, lhs.m33 * rhs, lhs.m40 * rhs, lhs.m41 * rhs, lhs.m42 * rhs, lhs.m43 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static mat5x4 operator*(float lhs, mat5x4 rhs) => new mat5x4(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m02, lhs * rhs.m03, lhs * rhs.m10, lhs * rhs.m11, lhs * rhs.m12, lhs * rhs.m13, lhs * rhs.m20, lhs * rhs.m21, lhs * rhs.m22, lhs * rhs.m23, lhs * rhs.m30, lhs * rhs.m31, lhs * rhs.m32, lhs * rhs.m33, lhs * rhs.m40, lhs * rhs.m41, lhs * rhs.m42, lhs * rhs.m43);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bmat5x4 operator<(mat5x4 lhs, mat5x4 rhs) => new bmat5x4(lhs.m00 < rhs.m00, lhs.m01 < rhs.m01, lhs.m02 < rhs.m02, lhs.m03 < rhs.m03, lhs.m10 < rhs.m10, lhs.m11 < rhs.m11, lhs.m12 < rhs.m12, lhs.m13 < rhs.m13, lhs.m20 < rhs.m20, lhs.m21 < rhs.m21, lhs.m22 < rhs.m22, lhs.m23 < rhs.m23, lhs.m30 < rhs.m30, lhs.m31 < rhs.m31, lhs.m32 < rhs.m32, lhs.m33 < rhs.m33, lhs.m40 < rhs.m40, lhs.m41 < rhs.m41, lhs.m42 < rhs.m42, lhs.m43 < rhs.m43);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat5x4 operator<(mat5x4 lhs, float rhs) => new bmat5x4(lhs.m00 < rhs, lhs.m01 < rhs, lhs.m02 < rhs, lhs.m03 < rhs, lhs.m10 < rhs, lhs.m11 < rhs, lhs.m12 < rhs, lhs.m13 < rhs, lhs.m20 < rhs, lhs.m21 < rhs, lhs.m22 < rhs, lhs.m23 < rhs, lhs.m30 < rhs, lhs.m31 < rhs, lhs.m32 < rhs, lhs.m33 < rhs, lhs.m40 < rhs, lhs.m41 < rhs, lhs.m42 < rhs, lhs.m43 < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat5x4 operator<(float lhs, mat5x4 rhs) => new bmat5x4(lhs < rhs.m00, lhs < rhs.m01, lhs < rhs.m02, lhs < rhs.m03, lhs < rhs.m10, lhs < rhs.m11, lhs < rhs.m12, lhs < rhs.m13, lhs < rhs.m20, lhs < rhs.m21, lhs < rhs.m22, lhs < rhs.m23, lhs < rhs.m30, lhs < rhs.m31, lhs < rhs.m32, lhs < rhs.m33, lhs < rhs.m40, lhs < rhs.m41, lhs < rhs.m42, lhs < rhs.m43);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bmat5x4 operator<=(mat5x4 lhs, mat5x4 rhs) => new bmat5x4(lhs.m00 <= rhs.m00, lhs.m01 <= rhs.m01, lhs.m02 <= rhs.m02, lhs.m03 <= rhs.m03, lhs.m10 <= rhs.m10, lhs.m11 <= rhs.m11, lhs.m12 <= rhs.m12, lhs.m13 <= rhs.m13, lhs.m20 <= rhs.m20, lhs.m21 <= rhs.m21, lhs.m22 <= rhs.m22, lhs.m23 <= rhs.m23, lhs.m30 <= rhs.m30, lhs.m31 <= rhs.m31, lhs.m32 <= rhs.m32, lhs.m33 <= rhs.m33, lhs.m40 <= rhs.m40, lhs.m41 <= rhs.m41, lhs.m42 <= rhs.m42, lhs.m43 <= rhs.m43);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat5x4 operator<=(mat5x4 lhs, float rhs) => new bmat5x4(lhs.m00 <= rhs, lhs.m01 <= rhs, lhs.m02 <= rhs, lhs.m03 <= rhs, lhs.m10 <= rhs, lhs.m11 <= rhs, lhs.m12 <= rhs, lhs.m13 <= rhs, lhs.m20 <= rhs, lhs.m21 <= rhs, lhs.m22 <= rhs, lhs.m23 <= rhs, lhs.m30 <= rhs, lhs.m31 <= rhs, lhs.m32 <= rhs, lhs.m33 <= rhs, lhs.m40 <= rhs, lhs.m41 <= rhs, lhs.m42 <= rhs, lhs.m43 <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat5x4 operator<=(float lhs, mat5x4 rhs) => new bmat5x4(lhs <= rhs.m00, lhs <= rhs.m01, lhs <= rhs.m02, lhs <= rhs.m03, lhs <= rhs.m10, lhs <= rhs.m11, lhs <= rhs.m12, lhs <= rhs.m13, lhs <= rhs.m20, lhs <= rhs.m21, lhs <= rhs.m22, lhs <= rhs.m23, lhs <= rhs.m30, lhs <= rhs.m31, lhs <= rhs.m32, lhs <= rhs.m33, lhs <= rhs.m40, lhs <= rhs.m41, lhs <= rhs.m42, lhs <= rhs.m43);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bmat5x4 operator>(mat5x4 lhs, mat5x4 rhs) => new bmat5x4(lhs.m00 > rhs.m00, lhs.m01 > rhs.m01, lhs.m02 > rhs.m02, lhs.m03 > rhs.m03, lhs.m10 > rhs.m10, lhs.m11 > rhs.m11, lhs.m12 > rhs.m12, lhs.m13 > rhs.m13, lhs.m20 > rhs.m20, lhs.m21 > rhs.m21, lhs.m22 > rhs.m22, lhs.m23 > rhs.m23, lhs.m30 > rhs.m30, lhs.m31 > rhs.m31, lhs.m32 > rhs.m32, lhs.m33 > rhs.m33, lhs.m40 > rhs.m40, lhs.m41 > rhs.m41, lhs.m42 > rhs.m42, lhs.m43 > rhs.m43);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat5x4 operator>(mat5x4 lhs, float rhs) => new bmat5x4(lhs.m00 > rhs, lhs.m01 > rhs, lhs.m02 > rhs, lhs.m03 > rhs, lhs.m10 > rhs, lhs.m11 > rhs, lhs.m12 > rhs, lhs.m13 > rhs, lhs.m20 > rhs, lhs.m21 > rhs, lhs.m22 > rhs, lhs.m23 > rhs, lhs.m30 > rhs, lhs.m31 > rhs, lhs.m32 > rhs, lhs.m33 > rhs, lhs.m40 > rhs, lhs.m41 > rhs, lhs.m42 > rhs, lhs.m43 > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat5x4 operator>(float lhs, mat5x4 rhs) => new bmat5x4(lhs > rhs.m00, lhs > rhs.m01, lhs > rhs.m02, lhs > rhs.m03, lhs > rhs.m10, lhs > rhs.m11, lhs > rhs.m12, lhs > rhs.m13, lhs > rhs.m20, lhs > rhs.m21, lhs > rhs.m22, lhs > rhs.m23, lhs > rhs.m30, lhs > rhs.m31, lhs > rhs.m32, lhs > rhs.m33, lhs > rhs.m40, lhs > rhs.m41, lhs > rhs.m42, lhs > rhs.m43);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bmat5x4 operator>=(mat5x4 lhs, mat5x4 rhs) => new bmat5x4(lhs.m00 >= rhs.m00, lhs.m01 >= rhs.m01, lhs.m02 >= rhs.m02, lhs.m03 >= rhs.m03, lhs.m10 >= rhs.m10, lhs.m11 >= rhs.m11, lhs.m12 >= rhs.m12, lhs.m13 >= rhs.m13, lhs.m20 >= rhs.m20, lhs.m21 >= rhs.m21, lhs.m22 >= rhs.m22, lhs.m23 >= rhs.m23, lhs.m30 >= rhs.m30, lhs.m31 >= rhs.m31, lhs.m32 >= rhs.m32, lhs.m33 >= rhs.m33, lhs.m40 >= rhs.m40, lhs.m41 >= rhs.m41, lhs.m42 >= rhs.m42, lhs.m43 >= rhs.m43);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat5x4 operator>=(mat5x4 lhs, float rhs) => new bmat5x4(lhs.m00 >= rhs, lhs.m01 >= rhs, lhs.m02 >= rhs, lhs.m03 >= rhs, lhs.m10 >= rhs, lhs.m11 >= rhs, lhs.m12 >= rhs, lhs.m13 >= rhs, lhs.m20 >= rhs, lhs.m21 >= rhs, lhs.m22 >= rhs, lhs.m23 >= rhs, lhs.m30 >= rhs, lhs.m31 >= rhs, lhs.m32 >= rhs, lhs.m33 >= rhs, lhs.m40 >= rhs, lhs.m41 >= rhs, lhs.m42 >= rhs, lhs.m43 >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat5x4 operator>=(float lhs, mat5x4 rhs) => new bmat5x4(lhs >= rhs.m00, lhs >= rhs.m01, lhs >= rhs.m02, lhs >= rhs.m03, lhs >= rhs.m10, lhs >= rhs.m11, lhs >= rhs.m12, lhs >= rhs.m13, lhs >= rhs.m20, lhs >= rhs.m21, lhs >= rhs.m22, lhs >= rhs.m23, lhs >= rhs.m30, lhs >= rhs.m31, lhs >= rhs.m32, lhs >= rhs.m33, lhs >= rhs.m40, lhs >= rhs.m41, lhs >= rhs.m42, lhs >= rhs.m43);
    }
}
