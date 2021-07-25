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
    /// A matrix of type T with 5 columns and 2 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct gmat5x2<T> : IReadOnlyList<T>, IEquatable<gmat5x2<T>>
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
        /// Column 3, Rows 0
        /// </summary>
        [DataMember]
        public T m30;
        
        /// <summary>
        /// Column 3, Rows 1
        /// </summary>
        [DataMember]
        public T m31;
        
        /// <summary>
        /// Column 4, Rows 0
        /// </summary>
        [DataMember]
        public T m40;
        
        /// <summary>
        /// Column 4, Rows 1
        /// </summary>
        [DataMember]
        public T m41;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public gmat5x2(T m00, T m01, T m10, T m11, T m20, T m21, T m30, T m31, T m40, T m41)
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
        /// Constructs this matrix from a gmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = default(T);
            this.m21 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat3x2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = default(T);
            this.m31 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat4x2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat5x2<T> m)
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
        /// Constructs this matrix from a gmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat2x3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = default(T);
            this.m21 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = default(T);
            this.m31 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat4x3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat5x3<T> m)
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
        /// Constructs this matrix from a gmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat2x4<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = default(T);
            this.m21 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat3x4<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = default(T);
            this.m31 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat4<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat5x4<T> m)
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
        /// Constructs this matrix from a gmat2x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat2x5<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = default(T);
            this.m21 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat3x5<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = default(T);
            this.m31 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat4x5<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat5. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gmat5<T> m)
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
        public gmat5x2(gvec2<T> c0, gvec2<T> c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m20 = default(T);
            this.m21 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gvec2<T> c0, gvec2<T> c1, gvec2<T> c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m30 = default(T);
            this.m31 = default(T);
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gvec2<T> c0, gvec2<T> c1, gvec2<T> c2, gvec2<T> c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m40 = default(T);
            this.m41 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat5x2(gvec2<T> c0, gvec2<T> c1, gvec2<T> c2, gvec2<T> c3, gvec2<T> c4)
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
        public T[,] Values => new[,] { { m00, m01 }, { m10, m11 }, { m20, m21 }, { m30, m31 }, { m40, m41 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public T[] Values1D => new[] { m00, m01, m10, m11, m20, m21, m30, m31, m40, m41 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public gvec2<T> Column0
        {
            get
            {
                return new gvec2<T>(m00, m01);
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
        public gvec2<T> Column1
        {
            get
            {
                return new gvec2<T>(m10, m11);
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
        public gvec2<T> Column2
        {
            get
            {
                return new gvec2<T>(m20, m21);
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
        public gvec2<T> Column3
        {
            get
            {
                return new gvec2<T>(m30, m31);
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
        public gvec2<T> Column4
        {
            get
            {
                return new gvec2<T>(m40, m41);
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

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static gmat5x2<T> Zero { get; } = new gmat5x2<T>(default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T));

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
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
        public T this[int fieldIndex]
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
        public T this[int col, int row]
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
        public bool Equals(gmat5x2<T> rhs) => ((((EqualityComparer<T>.Default.Equals(m00, rhs.m00) && EqualityComparer<T>.Default.Equals(m01, rhs.m01)) && EqualityComparer<T>.Default.Equals(m10, rhs.m10)) && (EqualityComparer<T>.Default.Equals(m11, rhs.m11) && EqualityComparer<T>.Default.Equals(m20, rhs.m20))) && (((EqualityComparer<T>.Default.Equals(m21, rhs.m21) && EqualityComparer<T>.Default.Equals(m30, rhs.m30)) && EqualityComparer<T>.Default.Equals(m31, rhs.m31)) && (EqualityComparer<T>.Default.Equals(m40, rhs.m40) && EqualityComparer<T>.Default.Equals(m41, rhs.m41))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is gmat5x2<T> && Equals((gmat5x2<T>) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(gmat5x2<T> lhs, gmat5x2<T> rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(gmat5x2<T> lhs, gmat5x2<T> rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((EqualityComparer<T>.Default.GetHashCode(m00)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m01)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m10)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m11)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m20)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m21)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m30)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m31)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m40)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m41);
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public gmat2x5<T> Transposed => new gmat2x5<T>(m00, m10, m20, m30, m40, m01, m11, m21, m31, m41);
    }
}
