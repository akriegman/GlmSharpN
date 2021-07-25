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
    /// A matrix of type T with 3 columns and 5 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct gmat3x5<T> : IReadOnlyList<T>, IEquatable<gmat3x5<T>>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public T m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public T m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public T m02;
        
        /// <summary>
        /// Column 0, Rows 3
        /// </summary>
        [DataMember]
        public T m03;
        
        /// <summary>
        /// Column 0, Rows 4
        /// </summary>
        [DataMember]
        public T m04;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public T m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public T m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public T m12;
        
        /// <summary>
        /// Column 1, Rows 3
        /// </summary>
        [DataMember]
        public T m13;
        
        /// <summary>
        /// Column 1, Rows 4
        /// </summary>
        [DataMember]
        public T m14;
        
        /// <summary>
        /// Column 2, Rows 0
        /// </summary>
        [DataMember]
        public T m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        [DataMember]
        public T m21;
        
        /// <summary>
        /// Column 2, Rows 2
        /// </summary>
        [DataMember]
        public T m22;
        
        /// <summary>
        /// Column 2, Rows 3
        /// </summary>
        [DataMember]
        public T m23;
        
        /// <summary>
        /// Column 2, Rows 4
        /// </summary>
        [DataMember]
        public T m24;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public gmat3x5(T m00, T m01, T m02, T m03, T m04, T m10, T m11, T m12, T m13, T m14, T m20, T m21, T m22, T m23, T m24)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat2<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat3x2<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat4x2<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat5x2<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat2x3<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat3<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat4x3<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat5x3<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat2x4<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat3x4<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat4<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat5x4<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat2x5<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat3x5<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat4x5<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gmat5<T> m)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gvec2<T> c0, gvec2<T> c1)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gvec2<T> c0, gvec2<T> c1, gvec2<T> c2)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gvec3<T> c0, gvec3<T> c1)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gvec3<T> c0, gvec3<T> c1, gvec3<T> c2)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gvec4<T> c0, gvec4<T> c1)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gvec4<T> c0, gvec4<T> c1, gvec4<T> c2)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gvec5<T> c0, gvec5<T> c1)
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
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat3x5(gvec5<T> c0, gvec5<T> c1, gvec5<T> c2)
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
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public T[,] Values => new[,] { { m00, m01, m02, m03, m04 }, { m10, m11, m12, m13, m14 }, { m20, m21, m22, m23, m24 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public T[] Values1D => new[] { m00, m01, m02, m03, m04, m10, m11, m12, m13, m14, m20, m21, m22, m23, m24 };
        
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
        /// Gets or sets the row nr 0
        /// </summary>
        public gvec3<T> Row0
        {
            get
            {
                return new gvec3<T>(m00, m10, m20);
            }
            set
            {
                m00 = value.x;
                m10 = value.y;
                m20 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 1
        /// </summary>
        public gvec3<T> Row1
        {
            get
            {
                return new gvec3<T>(m01, m11, m21);
            }
            set
            {
                m01 = value.x;
                m11 = value.y;
                m21 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 2
        /// </summary>
        public gvec3<T> Row2
        {
            get
            {
                return new gvec3<T>(m02, m12, m22);
            }
            set
            {
                m02 = value.x;
                m12 = value.y;
                m22 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 3
        /// </summary>
        public gvec3<T> Row3
        {
            get
            {
                return new gvec3<T>(m03, m13, m23);
            }
            set
            {
                m03 = value.x;
                m13 = value.y;
                m23 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 4
        /// </summary>
        public gvec3<T> Row4
        {
            get
            {
                return new gvec3<T>(m04, m14, m24);
            }
            set
            {
                m04 = value.x;
                m14 = value.y;
                m24 = value.z;
            }
        }

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static gmat3x5<T> Zero { get; } = new gmat3x5<T>(default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T));

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
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (3 x 5 = 15).
        /// </summary>
        public int Count => 15;
        
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
        public bool Equals(gmat3x5<T> rhs) => ((((EqualityComparer<T>.Default.Equals(m00, rhs.m00) && EqualityComparer<T>.Default.Equals(m01, rhs.m01)) && (EqualityComparer<T>.Default.Equals(m02, rhs.m02) && EqualityComparer<T>.Default.Equals(m03, rhs.m03))) && ((EqualityComparer<T>.Default.Equals(m04, rhs.m04) && EqualityComparer<T>.Default.Equals(m10, rhs.m10)) && (EqualityComparer<T>.Default.Equals(m11, rhs.m11) && EqualityComparer<T>.Default.Equals(m12, rhs.m12)))) && (((EqualityComparer<T>.Default.Equals(m13, rhs.m13) && EqualityComparer<T>.Default.Equals(m14, rhs.m14)) && (EqualityComparer<T>.Default.Equals(m20, rhs.m20) && EqualityComparer<T>.Default.Equals(m21, rhs.m21))) && ((EqualityComparer<T>.Default.Equals(m22, rhs.m22) && EqualityComparer<T>.Default.Equals(m23, rhs.m23)) && EqualityComparer<T>.Default.Equals(m24, rhs.m24))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is gmat3x5<T> && Equals((gmat3x5<T>) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(gmat3x5<T> lhs, gmat3x5<T> rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(gmat3x5<T> lhs, gmat3x5<T> rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((((((((EqualityComparer<T>.Default.GetHashCode(m00)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m01)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m02)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m03)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m04)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m10)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m11)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m12)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m13)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m14)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m20)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m21)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m22)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m23)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m24);
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public gmat5x3<T> Transposed => new gmat5x3<T>(m00, m10, m20, m01, m11, m21, m02, m12, m22, m03, m13, m23, m04, m14, m24);
    }
}
