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
    /// A matrix of type bool with 5 columns and 3 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct bmat5x3 : IReadOnlyList<bool>, IEquatable<bmat5x3>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public bool m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public bool m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public bool m02;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public bool m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public bool m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public bool m12;
        
        /// <summary>
        /// Column 2, Rows 0
        /// </summary>
        [DataMember]
        public bool m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        [DataMember]
        public bool m21;
        
        /// <summary>
        /// Column 2, Rows 2
        /// </summary>
        [DataMember]
        public bool m22;
        
        /// <summary>
        /// Column 3, Rows 0
        /// </summary>
        [DataMember]
        public bool m30;
        
        /// <summary>
        /// Column 3, Rows 1
        /// </summary>
        [DataMember]
        public bool m31;
        
        /// <summary>
        /// Column 3, Rows 2
        /// </summary>
        [DataMember]
        public bool m32;
        
        /// <summary>
        /// Column 4, Rows 0
        /// </summary>
        [DataMember]
        public bool m40;
        
        /// <summary>
        /// Column 4, Rows 1
        /// </summary>
        [DataMember]
        public bool m41;
        
        /// <summary>
        /// Column 4, Rows 2
        /// </summary>
        [DataMember]
        public bool m42;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bmat5x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32, bool m40, bool m41, bool m42)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
            this.m30 = m30;
            this.m31 = m31;
            this.m32 = m32;
            this.m40 = m40;
            this.m41 = m41;
            this.m42 = m42;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = false;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = false;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = false;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = false;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = true;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = false;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = false;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = true;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat5x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat5x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = false;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = false;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = true;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = false;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat5x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat5x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = m.m42;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat3x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat5x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat5x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = m.m42;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat2x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat2x5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat3x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat3x5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat4x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat4x5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a bmat5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bmat5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m40 = m.m40;
            this.m41 = m.m41;
            this.m42 = m.m42;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bvec2 c0, bvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = false;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = false;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bvec2 c0, bvec2 c1, bvec2 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = false;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = false;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = true;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bvec2 c0, bvec2 c1, bvec2 c2, bvec2 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = false;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = false;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = true;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bvec2 c0, bvec2 c1, bvec2 c2, bvec2 c3, bvec2 c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = false;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = false;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = true;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = false;
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bvec3 c0, bvec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m20 = false;
            this.m21 = false;
            this.m22 = true;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bvec3 c0, bvec3 c1, bvec3 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m30 = false;
            this.m31 = false;
            this.m32 = false;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bvec3 c0, bvec3 c1, bvec3 c2, bvec3 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m40 = false;
            this.m41 = false;
            this.m42 = false;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public bmat5x3(bvec3 c0, bvec3 c1, bvec3 c2, bvec3 c3, bvec3 c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m40 = c4.x;
            this.m41 = c4.y;
            this.m42 = c4.z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public bool[,] Values => new[,] { { m00, m01, m02 }, { m10, m11, m12 }, { m20, m21, m22 }, { m30, m31, m32 }, { m40, m41, m42 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public bool[] Values1D => new[] { m00, m01, m02, m10, m11, m12, m20, m21, m22, m30, m31, m32, m40, m41, m42 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public bvec3 Column0
        {
            get
            {
                return new bvec3(m00, m01, m02);
            }
            set
            {
                m00 = value.x;
                m01 = value.y;
                m02 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 1
        /// </summary>
        public bvec3 Column1
        {
            get
            {
                return new bvec3(m10, m11, m12);
            }
            set
            {
                m10 = value.x;
                m11 = value.y;
                m12 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 2
        /// </summary>
        public bvec3 Column2
        {
            get
            {
                return new bvec3(m20, m21, m22);
            }
            set
            {
                m20 = value.x;
                m21 = value.y;
                m22 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 3
        /// </summary>
        public bvec3 Column3
        {
            get
            {
                return new bvec3(m30, m31, m32);
            }
            set
            {
                m30 = value.x;
                m31 = value.y;
                m32 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 4
        /// </summary>
        public bvec3 Column4
        {
            get
            {
                return new bvec3(m40, m41, m42);
            }
            set
            {
                m40 = value.x;
                m41 = value.y;
                m42 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 0
        /// </summary>
        public bvec5 Row0
        {
            get
            {
                return new bvec5(m00, m10, m20, m30, m40);
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
        public bvec5 Row1
        {
            get
            {
                return new bvec5(m01, m11, m21, m31, m41);
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
        public bvec5 Row2
        {
            get
            {
                return new bvec5(m02, m12, m22, m32, m42);
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

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static bmat5x3 Zero { get; } = new bmat5x3(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static bmat5x3 Ones { get; } = new bmat5x3(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static bmat5x3 Identity { get; } = new bmat5x3(true, false, false, false, true, false, false, false, true, false, false, false, false, false, false);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<bool> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m02;
            yield return m10;
            yield return m11;
            yield return m12;
            yield return m20;
            yield return m21;
            yield return m22;
            yield return m30;
            yield return m31;
            yield return m32;
            yield return m40;
            yield return m41;
            yield return m42;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (5 x 3 = 15).
        /// </summary>
        public int Count => 15;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int fieldIndex]
        {
            get
            {
                switch (fieldIndex)
                {
                    case 0: return m00;
                    case 1: return m01;
                    case 2: return m02;
                    case 3: return m10;
                    case 4: return m11;
                    case 5: return m12;
                    case 6: return m20;
                    case 7: return m21;
                    case 8: return m22;
                    case 9: return m30;
                    case 10: return m31;
                    case 11: return m32;
                    case 12: return m40;
                    case 13: return m41;
                    case 14: return m42;
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
                    case 3: this.m10 = value; break;
                    case 4: this.m11 = value; break;
                    case 5: this.m12 = value; break;
                    case 6: this.m20 = value; break;
                    case 7: this.m21 = value; break;
                    case 8: this.m22 = value; break;
                    case 9: this.m30 = value; break;
                    case 10: this.m31 = value; break;
                    case 11: this.m32 = value; break;
                    case 12: this.m40 = value; break;
                    case 13: this.m41 = value; break;
                    case 14: this.m42 = value; break;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int col, int row]
        {
            get
            {
                return this[col * 3 + row];
            }
            set
            {
                this[col * 3 + row] = value;
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bmat5x3 rhs) => ((((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && (m02.Equals(rhs.m02) && m10.Equals(rhs.m10))) && ((m11.Equals(rhs.m11) && m12.Equals(rhs.m12)) && (m20.Equals(rhs.m20) && m21.Equals(rhs.m21)))) && (((m22.Equals(rhs.m22) && m30.Equals(rhs.m30)) && (m31.Equals(rhs.m31) && m32.Equals(rhs.m32))) && ((m40.Equals(rhs.m40) && m41.Equals(rhs.m41)) && m42.Equals(rhs.m42))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bmat5x3 && Equals((bmat5x3) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(bmat5x3 lhs, bmat5x3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(bmat5x3 lhs, bmat5x3 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((((((((m00.GetHashCode()) * 2) ^ m01.GetHashCode()) * 2) ^ m02.GetHashCode()) * 2) ^ m10.GetHashCode()) * 2) ^ m11.GetHashCode()) * 2) ^ m12.GetHashCode()) * 2) ^ m20.GetHashCode()) * 2) ^ m21.GetHashCode()) * 2) ^ m22.GetHashCode()) * 2) ^ m30.GetHashCode()) * 2) ^ m31.GetHashCode()) * 2) ^ m32.GetHashCode()) * 2) ^ m40.GetHashCode()) * 2) ^ m41.GetHashCode()) * 2) ^ m42.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public bmat3x5 Transposed => new bmat3x5(m00, m10, m20, m30, m40, m01, m11, m21, m31, m41, m02, m12, m22, m32, m42);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public bool MinElement => ((((m00 && m01) && (m02 && m10)) && ((m11 && m12) && (m20 && m21))) && (((m22 && m30) && (m31 && m32)) && ((m40 && m41) && m42)));
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public bool MaxElement => ((((m00 || m01) || (m02 || m10)) || ((m11 || m12) || (m20 || m21))) || (((m22 || m30) || (m31 || m32)) || ((m40 || m41) || m42)));
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public bool All => ((((m00 && m01) && (m02 && m10)) && ((m11 && m12) && (m20 && m21))) && (((m22 && m30) && (m31 && m32)) && ((m40 && m41) && m42)));
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public bool Any => ((((m00 || m01) || (m02 || m10)) || ((m11 || m12) || (m20 || m21))) || (((m22 || m30) || (m31 || m32)) || ((m40 || m41) || m42)));
        
        /// <summary>
        /// Executes a component-wise &amp;&amp;. (sorry for different overload but &amp;&amp; cannot be overloaded directly)
        /// </summary>
        public static bmat5x3 operator&(bmat5x3 lhs, bmat5x3 rhs) => new bmat5x3(lhs.m00 && rhs.m00, lhs.m01 && rhs.m01, lhs.m02 && rhs.m02, lhs.m10 && rhs.m10, lhs.m11 && rhs.m11, lhs.m12 && rhs.m12, lhs.m20 && rhs.m20, lhs.m21 && rhs.m21, lhs.m22 && rhs.m22, lhs.m30 && rhs.m30, lhs.m31 && rhs.m31, lhs.m32 && rhs.m32, lhs.m40 && rhs.m40, lhs.m41 && rhs.m41, lhs.m42 && rhs.m42);
        
        /// <summary>
        /// Executes a component-wise ||. (sorry for different overload but || cannot be overloaded directly)
        /// </summary>
        public static bmat5x3 operator|(bmat5x3 lhs, bmat5x3 rhs) => new bmat5x3(lhs.m00 || rhs.m00, lhs.m01 || rhs.m01, lhs.m02 || rhs.m02, lhs.m10 || rhs.m10, lhs.m11 || rhs.m11, lhs.m12 || rhs.m12, lhs.m20 || rhs.m20, lhs.m21 || rhs.m21, lhs.m22 || rhs.m22, lhs.m30 || rhs.m30, lhs.m31 || rhs.m31, lhs.m32 || rhs.m32, lhs.m40 || rhs.m40, lhs.m41 || rhs.m41, lhs.m42 || rhs.m42);
    }
}
