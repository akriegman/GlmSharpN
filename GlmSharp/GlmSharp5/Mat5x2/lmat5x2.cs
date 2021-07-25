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
    /// A matrix of type long with 5 columns and 2 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct lmat5x2 : IReadOnlyList<long>, IEquatable<lmat5x2>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public long m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public long m01;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public long m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public long m11;
        
        /// <summary>
        /// Column 2, Rows 0
        /// </summary>
        [DataMember]
        public long m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        [DataMember]
        public long m21;
        
        /// <summary>
        /// Column 3, Rows 0
        /// </summary>
        [DataMember]
        public long m30;
        
        /// <summary>
        /// Column 3, Rows 1
        /// </summary>
        [DataMember]
        public long m31;
        
        /// <summary>
        /// Column 4, Rows 0
        /// </summary>
        [DataMember]
        public long m40;
        
        /// <summary>
        /// Column 4, Rows 1
        /// </summary>
        [DataMember]
        public long m41;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public lmat5x2(long m00, long m01, long m10, long m11, long m20, long m21, long m30, long m31, long m40, long m41)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m10 = m10;
            this.m11 = m11;
            this.m20 = m20;
            this.m21 = m21;
            this.m30 = m30;
            this.m31 = m31;
            this.m40 = m40;
            this.m41 = m41;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = 0;
            this.m21 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = 0;
            this.m31 = 0;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat5x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat5x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = m.m40;
            this.m41 = m.m41;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = 0;
            this.m21 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = 0;
            this.m31 = 0;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat5x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat5x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = m.m40;
            this.m41 = m.m41;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = 0;
            this.m21 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat3x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = 0;
            this.m31 = 0;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat5x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat5x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = m.m40;
            this.m41 = m.m41;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat2x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat2x5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = 0;
            this.m21 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat3x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat3x5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = 0;
            this.m31 = 0;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat4x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat4x5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a lmat5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lmat5 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = m.m40;
            this.m41 = m.m41;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lvec2 c0, lvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m20 = 0;
            this.m21 = 0;
            this.m30 = 0;
            this.m31 = 0;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lvec2 c0, lvec2 c1, lvec2 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m30 = 0;
            this.m31 = 0;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lvec2 c0, lvec2 c1, lvec2 c2, lvec2 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m40 = 0;
            this.m41 = 0;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public lmat5x2(lvec2 c0, lvec2 c1, lvec2 c2, lvec2 c3, lvec2 c4)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m40 = c4.x;
            this.m41 = c4.y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public long[,] Values => new[,] { { m00, m01 }, { m10, m11 }, { m20, m21 }, { m30, m31 }, { m40, m41 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public long[] Values1D => new[] { m00, m01, m10, m11, m20, m21, m30, m31, m40, m41 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public lvec2 Column0
        {
            get
            {
                return new lvec2(m00, m01);
            }
            set
            {
                m00 = value.x;
                m01 = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 1
        /// </summary>
        public lvec2 Column1
        {
            get
            {
                return new lvec2(m10, m11);
            }
            set
            {
                m10 = value.x;
                m11 = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 2
        /// </summary>
        public lvec2 Column2
        {
            get
            {
                return new lvec2(m20, m21);
            }
            set
            {
                m20 = value.x;
                m21 = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 3
        /// </summary>
        public lvec2 Column3
        {
            get
            {
                return new lvec2(m30, m31);
            }
            set
            {
                m30 = value.x;
                m31 = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 4
        /// </summary>
        public lvec2 Column4
        {
            get
            {
                return new lvec2(m40, m41);
            }
            set
            {
                m40 = value.x;
                m41 = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 0
        /// </summary>
        public lvec5 Row0
        {
            get
            {
                return new lvec5(m00, m10, m20, m30, m40);
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
        public lvec5 Row1
        {
            get
            {
                return new lvec5(m01, m11, m21, m31, m41);
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

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static lmat5x2 Zero { get; } = new lmat5x2(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static lmat5x2 Ones { get; } = new lmat5x2(1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static lmat5x2 Identity { get; } = new lmat5x2(1, 0, 0, 1, 0, 0, 0, 0, 0, 0);
        
        /// <summary>
        /// Predefined all-MaxValue matrix
        /// </summary>
        public static lmat5x2 AllMaxValue { get; } = new lmat5x2(long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue);
        
        /// <summary>
        /// Predefined diagonal-MaxValue matrix
        /// </summary>
        public static lmat5x2 DiagonalMaxValue { get; } = new lmat5x2(long.MaxValue, 0, 0, long.MaxValue, 0, 0, 0, 0, 0, 0);
        
        /// <summary>
        /// Predefined all-MinValue matrix
        /// </summary>
        public static lmat5x2 AllMinValue { get; } = new lmat5x2(long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue, long.MinValue);
        
        /// <summary>
        /// Predefined diagonal-MinValue matrix
        /// </summary>
        public static lmat5x2 DiagonalMinValue { get; } = new lmat5x2(long.MinValue, 0, 0, long.MinValue, 0, 0, 0, 0, 0, 0);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<long> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m10;
            yield return m11;
            yield return m20;
            yield return m21;
            yield return m30;
            yield return m31;
            yield return m40;
            yield return m41;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (5 x 2 = 10).
        /// </summary>
        public int Count => 10;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public long this[int fieldIndex]
        {
            get
            {
                switch (fieldIndex)
                {
                    case 0: return m00;
                    case 1: return m01;
                    case 2: return m10;
                    case 3: return m11;
                    case 4: return m20;
                    case 5: return m21;
                    case 6: return m30;
                    case 7: return m31;
                    case 8: return m40;
                    case 9: return m41;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
            set
            {
                switch (fieldIndex)
                {
                    case 0: this.m00 = value; break;
                    case 1: this.m01 = value; break;
                    case 2: this.m10 = value; break;
                    case 3: this.m11 = value; break;
                    case 4: this.m20 = value; break;
                    case 5: this.m21 = value; break;
                    case 6: this.m30 = value; break;
                    case 7: this.m31 = value; break;
                    case 8: this.m40 = value; break;
                    case 9: this.m41 = value; break;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public long this[int col, int row]
        {
            get
            {
                return this[col * 2 + row];
            }
            set
            {
                this[col * 2 + row] = value;
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(lmat5x2 rhs) => ((((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && m10.Equals(rhs.m10)) && (m11.Equals(rhs.m11) && m20.Equals(rhs.m20))) && (((m21.Equals(rhs.m21) && m30.Equals(rhs.m30)) && m31.Equals(rhs.m31)) && (m40.Equals(rhs.m40) && m41.Equals(rhs.m41))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is lmat5x2 && Equals((lmat5x2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(lmat5x2 lhs, lmat5x2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(lmat5x2 lhs, lmat5x2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m20.GetHashCode()) * 397) ^ m21.GetHashCode()) * 397) ^ m30.GetHashCode()) * 397) ^ m31.GetHashCode()) * 397) ^ m40.GetHashCode()) * 397) ^ m41.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public lmat2x5 Transposed => new lmat2x5(m00, m10, m20, m30, m40, m01, m11, m21, m31, m41);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public long MinElement => Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(m00, m01), m10), m11), m20), m21), m30), m31), m40), m41);
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public long MaxElement => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(m00, m01), m10), m11), m20), m21), m30), m31), m40), m41);
        
        /// <summary>
        /// Returns the euclidean length of this matrix.
        /// </summary>
        public double Length => (double)Math.Sqrt(((((m00*m00 + m01*m01) + m10*m10) + (m11*m11 + m20*m20)) + (((m21*m21 + m30*m30) + m31*m31) + (m40*m40 + m41*m41))));
        
        /// <summary>
        /// Returns the squared euclidean length of this matrix.
        /// </summary>
        public double LengthSqr => ((((m00*m00 + m01*m01) + m10*m10) + (m11*m11 + m20*m20)) + (((m21*m21 + m30*m30) + m31*m31) + (m40*m40 + m41*m41)));
        
        /// <summary>
        /// Returns the sum of all fields.
        /// </summary>
        public long Sum => ((((m00 + m01) + m10) + (m11 + m20)) + (((m21 + m30) + m31) + (m40 + m41)));
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public double Norm => (double)Math.Sqrt(((((m00*m00 + m01*m01) + m10*m10) + (m11*m11 + m20*m20)) + (((m21*m21 + m30*m30) + m31*m31) + (m40*m40 + m41*m41))));
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public double Norm1 => ((((Math.Abs(m00) + Math.Abs(m01)) + Math.Abs(m10)) + (Math.Abs(m11) + Math.Abs(m20))) + (((Math.Abs(m21) + Math.Abs(m30)) + Math.Abs(m31)) + (Math.Abs(m40) + Math.Abs(m41))));
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(((((m00*m00 + m01*m01) + m10*m10) + (m11*m11 + m20*m20)) + (((m21*m21 + m30*m30) + m31*m31) + (m40*m40 + m41*m41))));
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public long NormMax => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Abs(m00), Math.Abs(m01)), Math.Abs(m10)), Math.Abs(m11)), Math.Abs(m20)), Math.Abs(m21)), Math.Abs(m30)), Math.Abs(m31)), Math.Abs(m40)), Math.Abs(m41));
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow(((((Math.Pow((double)Math.Abs(m00), p) + Math.Pow((double)Math.Abs(m01), p)) + Math.Pow((double)Math.Abs(m10), p)) + (Math.Pow((double)Math.Abs(m11), p) + Math.Pow((double)Math.Abs(m20), p))) + (((Math.Pow((double)Math.Abs(m21), p) + Math.Pow((double)Math.Abs(m30), p)) + Math.Pow((double)Math.Abs(m31), p)) + (Math.Pow((double)Math.Abs(m40), p) + Math.Pow((double)Math.Abs(m41), p)))), 1 / p);
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication lmat5x2 * lmat2x5 -> lmat2.
        /// </summary>
        public static lmat2 operator*(lmat5x2 lhs, lmat2x5 rhs) => new lmat2((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication lmat5x2 * lmat3x5 -> lmat3x2.
        /// </summary>
        public static lmat3x2 operator*(lmat5x2 lhs, lmat3x5 rhs) => new lmat3x2((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)), (((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22) + (lhs.m30 * rhs.m23 + lhs.m40 * rhs.m24)), (((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22) + (lhs.m31 * rhs.m23 + lhs.m41 * rhs.m24)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication lmat5x2 * lmat4x5 -> lmat4x2.
        /// </summary>
        public static lmat4x2 operator*(lmat5x2 lhs, lmat4x5 rhs) => new lmat4x2((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)), (((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22) + (lhs.m30 * rhs.m23 + lhs.m40 * rhs.m24)), (((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22) + (lhs.m31 * rhs.m23 + lhs.m41 * rhs.m24)), (((lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31) + lhs.m20 * rhs.m32) + (lhs.m30 * rhs.m33 + lhs.m40 * rhs.m34)), (((lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31) + lhs.m21 * rhs.m32) + (lhs.m31 * rhs.m33 + lhs.m41 * rhs.m34)));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication lmat5x2 * lmat5 -> lmat5x2.
        /// </summary>
        public static lmat5x2 operator*(lmat5x2 lhs, lmat5 rhs) => new lmat5x2((((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02) + (lhs.m30 * rhs.m03 + lhs.m40 * rhs.m04)), (((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02) + (lhs.m31 * rhs.m03 + lhs.m41 * rhs.m04)), (((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12) + (lhs.m30 * rhs.m13 + lhs.m40 * rhs.m14)), (((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12) + (lhs.m31 * rhs.m13 + lhs.m41 * rhs.m14)), (((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22) + (lhs.m30 * rhs.m23 + lhs.m40 * rhs.m24)), (((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22) + (lhs.m31 * rhs.m23 + lhs.m41 * rhs.m24)), (((lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31) + lhs.m20 * rhs.m32) + (lhs.m30 * rhs.m33 + lhs.m40 * rhs.m34)), (((lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31) + lhs.m21 * rhs.m32) + (lhs.m31 * rhs.m33 + lhs.m41 * rhs.m34)), (((lhs.m00 * rhs.m40 + lhs.m10 * rhs.m41) + lhs.m20 * rhs.m42) + (lhs.m30 * rhs.m43 + lhs.m40 * rhs.m44)), (((lhs.m01 * rhs.m40 + lhs.m11 * rhs.m41) + lhs.m21 * rhs.m42) + (lhs.m31 * rhs.m43 + lhs.m41 * rhs.m44)));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static lvec2 operator*(lmat5x2 m, lvec5 v) => new lvec2((((m.m00 * v.x + m.m10 * v.y) + m.m20 * v.z) + (m.m30 * v.w + m.m40 * v.v)), (((m.m01 * v.x + m.m11 * v.y) + m.m21 * v.z) + (m.m31 * v.w + m.m41 * v.v)));
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static lmat5x2 CompMul(lmat5x2 A, lmat5x2 B) => new lmat5x2(A.m00 * B.m00, A.m01 * B.m01, A.m10 * B.m10, A.m11 * B.m11, A.m20 * B.m20, A.m21 * B.m21, A.m30 * B.m30, A.m31 * B.m31, A.m40 * B.m40, A.m41 * B.m41);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static lmat5x2 CompDiv(lmat5x2 A, lmat5x2 B) => new lmat5x2(A.m00 / B.m00, A.m01 / B.m01, A.m10 / B.m10, A.m11 / B.m11, A.m20 / B.m20, A.m21 / B.m21, A.m30 / B.m30, A.m31 / B.m31, A.m40 / B.m40, A.m41 / B.m41);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static lmat5x2 CompAdd(lmat5x2 A, lmat5x2 B) => new lmat5x2(A.m00 + B.m00, A.m01 + B.m01, A.m10 + B.m10, A.m11 + B.m11, A.m20 + B.m20, A.m21 + B.m21, A.m30 + B.m30, A.m31 + B.m31, A.m40 + B.m40, A.m41 + B.m41);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static lmat5x2 CompSub(lmat5x2 A, lmat5x2 B) => new lmat5x2(A.m00 - B.m00, A.m01 - B.m01, A.m10 - B.m10, A.m11 - B.m11, A.m20 - B.m20, A.m21 - B.m21, A.m30 - B.m30, A.m31 - B.m31, A.m40 - B.m40, A.m41 - B.m41);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static lmat5x2 operator+(lmat5x2 lhs, lmat5x2 rhs) => new lmat5x2(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11, lhs.m20 + rhs.m20, lhs.m21 + rhs.m21, lhs.m30 + rhs.m30, lhs.m31 + rhs.m31, lhs.m40 + rhs.m40, lhs.m41 + rhs.m41);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static lmat5x2 operator+(lmat5x2 lhs, long rhs) => new lmat5x2(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m10 + rhs, lhs.m11 + rhs, lhs.m20 + rhs, lhs.m21 + rhs, lhs.m30 + rhs, lhs.m31 + rhs, lhs.m40 + rhs, lhs.m41 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static lmat5x2 operator+(long lhs, lmat5x2 rhs) => new lmat5x2(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m10, lhs + rhs.m11, lhs + rhs.m20, lhs + rhs.m21, lhs + rhs.m30, lhs + rhs.m31, lhs + rhs.m40, lhs + rhs.m41);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static lmat5x2 operator-(lmat5x2 lhs, lmat5x2 rhs) => new lmat5x2(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11, lhs.m20 - rhs.m20, lhs.m21 - rhs.m21, lhs.m30 - rhs.m30, lhs.m31 - rhs.m31, lhs.m40 - rhs.m40, lhs.m41 - rhs.m41);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static lmat5x2 operator-(lmat5x2 lhs, long rhs) => new lmat5x2(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m10 - rhs, lhs.m11 - rhs, lhs.m20 - rhs, lhs.m21 - rhs, lhs.m30 - rhs, lhs.m31 - rhs, lhs.m40 - rhs, lhs.m41 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static lmat5x2 operator-(long lhs, lmat5x2 rhs) => new lmat5x2(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m10, lhs - rhs.m11, lhs - rhs.m20, lhs - rhs.m21, lhs - rhs.m30, lhs - rhs.m31, lhs - rhs.m40, lhs - rhs.m41);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static lmat5x2 operator/(lmat5x2 lhs, long rhs) => new lmat5x2(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m10 / rhs, lhs.m11 / rhs, lhs.m20 / rhs, lhs.m21 / rhs, lhs.m30 / rhs, lhs.m31 / rhs, lhs.m40 / rhs, lhs.m41 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static lmat5x2 operator/(long lhs, lmat5x2 rhs) => new lmat5x2(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m10, lhs / rhs.m11, lhs / rhs.m20, lhs / rhs.m21, lhs / rhs.m30, lhs / rhs.m31, lhs / rhs.m40, lhs / rhs.m41);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static lmat5x2 operator*(lmat5x2 lhs, long rhs) => new lmat5x2(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m10 * rhs, lhs.m11 * rhs, lhs.m20 * rhs, lhs.m21 * rhs, lhs.m30 * rhs, lhs.m31 * rhs, lhs.m40 * rhs, lhs.m41 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static lmat5x2 operator*(long lhs, lmat5x2 rhs) => new lmat5x2(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m10, lhs * rhs.m11, lhs * rhs.m20, lhs * rhs.m21, lhs * rhs.m30, lhs * rhs.m31, lhs * rhs.m40, lhs * rhs.m41);
        
        /// <summary>
        /// Executes a component-wise % (modulo).
        /// </summary>
        public static lmat5x2 operator%(lmat5x2 lhs, lmat5x2 rhs) => new lmat5x2(lhs.m00 % rhs.m00, lhs.m01 % rhs.m01, lhs.m10 % rhs.m10, lhs.m11 % rhs.m11, lhs.m20 % rhs.m20, lhs.m21 % rhs.m21, lhs.m30 % rhs.m30, lhs.m31 % rhs.m31, lhs.m40 % rhs.m40, lhs.m41 % rhs.m41);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static lmat5x2 operator%(lmat5x2 lhs, long rhs) => new lmat5x2(lhs.m00 % rhs, lhs.m01 % rhs, lhs.m10 % rhs, lhs.m11 % rhs, lhs.m20 % rhs, lhs.m21 % rhs, lhs.m30 % rhs, lhs.m31 % rhs, lhs.m40 % rhs, lhs.m41 % rhs);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static lmat5x2 operator%(long lhs, lmat5x2 rhs) => new lmat5x2(lhs % rhs.m00, lhs % rhs.m01, lhs % rhs.m10, lhs % rhs.m11, lhs % rhs.m20, lhs % rhs.m21, lhs % rhs.m30, lhs % rhs.m31, lhs % rhs.m40, lhs % rhs.m41);
        
        /// <summary>
        /// Executes a component-wise ^ (xor).
        /// </summary>
        public static lmat5x2 operator^(lmat5x2 lhs, lmat5x2 rhs) => new lmat5x2(lhs.m00 ^ rhs.m00, lhs.m01 ^ rhs.m01, lhs.m10 ^ rhs.m10, lhs.m11 ^ rhs.m11, lhs.m20 ^ rhs.m20, lhs.m21 ^ rhs.m21, lhs.m30 ^ rhs.m30, lhs.m31 ^ rhs.m31, lhs.m40 ^ rhs.m40, lhs.m41 ^ rhs.m41);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static lmat5x2 operator^(lmat5x2 lhs, long rhs) => new lmat5x2(lhs.m00 ^ rhs, lhs.m01 ^ rhs, lhs.m10 ^ rhs, lhs.m11 ^ rhs, lhs.m20 ^ rhs, lhs.m21 ^ rhs, lhs.m30 ^ rhs, lhs.m31 ^ rhs, lhs.m40 ^ rhs, lhs.m41 ^ rhs);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static lmat5x2 operator^(long lhs, lmat5x2 rhs) => new lmat5x2(lhs ^ rhs.m00, lhs ^ rhs.m01, lhs ^ rhs.m10, lhs ^ rhs.m11, lhs ^ rhs.m20, lhs ^ rhs.m21, lhs ^ rhs.m30, lhs ^ rhs.m31, lhs ^ rhs.m40, lhs ^ rhs.m41);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or).
        /// </summary>
        public static lmat5x2 operator|(lmat5x2 lhs, lmat5x2 rhs) => new lmat5x2(lhs.m00 | rhs.m00, lhs.m01 | rhs.m01, lhs.m10 | rhs.m10, lhs.m11 | rhs.m11, lhs.m20 | rhs.m20, lhs.m21 | rhs.m21, lhs.m30 | rhs.m30, lhs.m31 | rhs.m31, lhs.m40 | rhs.m40, lhs.m41 | rhs.m41);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static lmat5x2 operator|(lmat5x2 lhs, long rhs) => new lmat5x2(lhs.m00 | rhs, lhs.m01 | rhs, lhs.m10 | rhs, lhs.m11 | rhs, lhs.m20 | rhs, lhs.m21 | rhs, lhs.m30 | rhs, lhs.m31 | rhs, lhs.m40 | rhs, lhs.m41 | rhs);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static lmat5x2 operator|(long lhs, lmat5x2 rhs) => new lmat5x2(lhs | rhs.m00, lhs | rhs.m01, lhs | rhs.m10, lhs | rhs.m11, lhs | rhs.m20, lhs | rhs.m21, lhs | rhs.m30, lhs | rhs.m31, lhs | rhs.m40, lhs | rhs.m41);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and).
        /// </summary>
        public static lmat5x2 operator&(lmat5x2 lhs, lmat5x2 rhs) => new lmat5x2(lhs.m00 & rhs.m00, lhs.m01 & rhs.m01, lhs.m10 & rhs.m10, lhs.m11 & rhs.m11, lhs.m20 & rhs.m20, lhs.m21 & rhs.m21, lhs.m30 & rhs.m30, lhs.m31 & rhs.m31, lhs.m40 & rhs.m40, lhs.m41 & rhs.m41);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and) with a scalar.
        /// </summary>
        public static lmat5x2 operator&(lmat5x2 lhs, long rhs) => new lmat5x2(lhs.m00 & rhs, lhs.m01 & rhs, lhs.m10 & rhs, lhs.m11 & rhs, lhs.m20 & rhs, lhs.m21 & rhs, lhs.m30 & rhs, lhs.m31 & rhs, lhs.m40 & rhs, lhs.m41 & rhs);
        
        /// <summary>
        /// Executes a component-wise &amp; (bitwise-and) with a scalar.
        /// </summary>
        public static lmat5x2 operator&(long lhs, lmat5x2 rhs) => new lmat5x2(lhs & rhs.m00, lhs & rhs.m01, lhs & rhs.m10, lhs & rhs.m11, lhs & rhs.m20, lhs & rhs.m21, lhs & rhs.m30, lhs & rhs.m31, lhs & rhs.m40, lhs & rhs.m41);
        
        /// <summary>
        /// Executes a component-wise left-shift with a scalar.
        /// </summary>
        public static lmat5x2 operator<<(lmat5x2 lhs, int rhs) => new lmat5x2(lhs.m00 << rhs, lhs.m01 << rhs, lhs.m10 << rhs, lhs.m11 << rhs, lhs.m20 << rhs, lhs.m21 << rhs, lhs.m30 << rhs, lhs.m31 << rhs, lhs.m40 << rhs, lhs.m41 << rhs);
        
        /// <summary>
        /// Executes a component-wise right-shift with a scalar.
        /// </summary>
        public static lmat5x2 operator>>(lmat5x2 lhs, int rhs) => new lmat5x2(lhs.m00 >> rhs, lhs.m01 >> rhs, lhs.m10 >> rhs, lhs.m11 >> rhs, lhs.m20 >> rhs, lhs.m21 >> rhs, lhs.m30 >> rhs, lhs.m31 >> rhs, lhs.m40 >> rhs, lhs.m41 >> rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bmat5x2 operator<(lmat5x2 lhs, lmat5x2 rhs) => new bmat5x2(lhs.m00 < rhs.m00, lhs.m01 < rhs.m01, lhs.m10 < rhs.m10, lhs.m11 < rhs.m11, lhs.m20 < rhs.m20, lhs.m21 < rhs.m21, lhs.m30 < rhs.m30, lhs.m31 < rhs.m31, lhs.m40 < rhs.m40, lhs.m41 < rhs.m41);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat5x2 operator<(lmat5x2 lhs, long rhs) => new bmat5x2(lhs.m00 < rhs, lhs.m01 < rhs, lhs.m10 < rhs, lhs.m11 < rhs, lhs.m20 < rhs, lhs.m21 < rhs, lhs.m30 < rhs, lhs.m31 < rhs, lhs.m40 < rhs, lhs.m41 < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat5x2 operator<(long lhs, lmat5x2 rhs) => new bmat5x2(lhs < rhs.m00, lhs < rhs.m01, lhs < rhs.m10, lhs < rhs.m11, lhs < rhs.m20, lhs < rhs.m21, lhs < rhs.m30, lhs < rhs.m31, lhs < rhs.m40, lhs < rhs.m41);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bmat5x2 operator<=(lmat5x2 lhs, lmat5x2 rhs) => new bmat5x2(lhs.m00 <= rhs.m00, lhs.m01 <= rhs.m01, lhs.m10 <= rhs.m10, lhs.m11 <= rhs.m11, lhs.m20 <= rhs.m20, lhs.m21 <= rhs.m21, lhs.m30 <= rhs.m30, lhs.m31 <= rhs.m31, lhs.m40 <= rhs.m40, lhs.m41 <= rhs.m41);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat5x2 operator<=(lmat5x2 lhs, long rhs) => new bmat5x2(lhs.m00 <= rhs, lhs.m01 <= rhs, lhs.m10 <= rhs, lhs.m11 <= rhs, lhs.m20 <= rhs, lhs.m21 <= rhs, lhs.m30 <= rhs, lhs.m31 <= rhs, lhs.m40 <= rhs, lhs.m41 <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat5x2 operator<=(long lhs, lmat5x2 rhs) => new bmat5x2(lhs <= rhs.m00, lhs <= rhs.m01, lhs <= rhs.m10, lhs <= rhs.m11, lhs <= rhs.m20, lhs <= rhs.m21, lhs <= rhs.m30, lhs <= rhs.m31, lhs <= rhs.m40, lhs <= rhs.m41);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bmat5x2 operator>(lmat5x2 lhs, lmat5x2 rhs) => new bmat5x2(lhs.m00 > rhs.m00, lhs.m01 > rhs.m01, lhs.m10 > rhs.m10, lhs.m11 > rhs.m11, lhs.m20 > rhs.m20, lhs.m21 > rhs.m21, lhs.m30 > rhs.m30, lhs.m31 > rhs.m31, lhs.m40 > rhs.m40, lhs.m41 > rhs.m41);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat5x2 operator>(lmat5x2 lhs, long rhs) => new bmat5x2(lhs.m00 > rhs, lhs.m01 > rhs, lhs.m10 > rhs, lhs.m11 > rhs, lhs.m20 > rhs, lhs.m21 > rhs, lhs.m30 > rhs, lhs.m31 > rhs, lhs.m40 > rhs, lhs.m41 > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat5x2 operator>(long lhs, lmat5x2 rhs) => new bmat5x2(lhs > rhs.m00, lhs > rhs.m01, lhs > rhs.m10, lhs > rhs.m11, lhs > rhs.m20, lhs > rhs.m21, lhs > rhs.m30, lhs > rhs.m31, lhs > rhs.m40, lhs > rhs.m41);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bmat5x2 operator>=(lmat5x2 lhs, lmat5x2 rhs) => new bmat5x2(lhs.m00 >= rhs.m00, lhs.m01 >= rhs.m01, lhs.m10 >= rhs.m10, lhs.m11 >= rhs.m11, lhs.m20 >= rhs.m20, lhs.m21 >= rhs.m21, lhs.m30 >= rhs.m30, lhs.m31 >= rhs.m31, lhs.m40 >= rhs.m40, lhs.m41 >= rhs.m41);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat5x2 operator>=(lmat5x2 lhs, long rhs) => new bmat5x2(lhs.m00 >= rhs, lhs.m01 >= rhs, lhs.m10 >= rhs, lhs.m11 >= rhs, lhs.m20 >= rhs, lhs.m21 >= rhs, lhs.m30 >= rhs, lhs.m31 >= rhs, lhs.m40 >= rhs, lhs.m41 >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat5x2 operator>=(long lhs, lmat5x2 rhs) => new bmat5x2(lhs >= rhs.m00, lhs >= rhs.m01, lhs >= rhs.m10, lhs >= rhs.m11, lhs >= rhs.m20, lhs >= rhs.m21, lhs >= rhs.m30, lhs >= rhs.m31, lhs >= rhs.m40, lhs >= rhs.m41);
    }
}
