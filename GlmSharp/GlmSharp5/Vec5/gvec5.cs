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
    /// A vector of type T with 5 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct gvec5<T> : IReadOnlyList<T>, IEquatable<gvec5<T>>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public T x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public T y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public T z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public T w;
        
        /// <summary>
        /// v-component
        /// </summary>
        [DataMember]
        public T v;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public gvec5(T x, T y, T z, T w, T v)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
            this.v = v;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public gvec5(T v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
            this.v = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public gvec5(gvec2<T> v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = default(T);
            this.w = default(T);
            this.v = default(T);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public gvec5(gvec2<T> ve, T z)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = default(T);
            this.v = default(T);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public gvec5(gvec2<T> ve, T z, T w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = w;
            this.v = default(T);
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public gvec5(gvec2<T> ve, T z, T w, T v)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = w;
            this.v = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public gvec5(gvec3<T> v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = default(T);
            this.v = default(T);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public gvec5(gvec3<T> ve, T w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = ve.z;
            this.w = w;
            this.v = default(T);
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public gvec5(gvec3<T> ve, T w, T v)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = ve.z;
            this.w = w;
            this.v = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public gvec5(gvec4<T> v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
            this.v = default(T);
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public gvec5(gvec4<T> ve, T v)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = ve.z;
            this.w = ve.w;
            this.v = v;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public gvec5(gvec5<T> v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
            this.v = v.v;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public gvec5(IReadOnlyList<T> v)
        {
            var c = v.Count;
            this.x = c < 0 ? default(T) : v[0];
            this.y = c < 1 ? default(T) : v[1];
            this.z = c < 2 ? default(T) : v[2];
            this.w = c < 3 ? default(T) : v[3];
            this.v = c < 4 ? default(T) : v[4];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public gvec5(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? default(T) : (T)v[0];
            this.y = c < 1 ? default(T) : (T)v[1];
            this.z = c < 2 ? default(T) : (T)v[2];
            this.w = c < 3 ? default(T) : (T)v[3];
            this.v = c < 4 ? default(T) : (T)v[4];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public gvec5(T[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? default(T) : v[0];
            this.y = c < 1 ? default(T) : v[1];
            this.z = c < 2 ? default(T) : v[2];
            this.w = c < 3 ? default(T) : v[3];
            this.v = c < 4 ? default(T) : v[4];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public gvec5(T[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? default(T) : v[0 + startIndex];
            this.y = c + startIndex < 1 ? default(T) : v[1 + startIndex];
            this.z = c + startIndex < 2 ? default(T) : v[2 + startIndex];
            this.w = c + startIndex < 3 ? default(T) : v[3 + startIndex];
            this.v = c + startIndex < 4 ? default(T) : v[4 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public gvec5(IEnumerable<T> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a gvec2.
        /// </summary>
        public static explicit operator gvec2<T>(gvec5<T> v) => new gvec2<T>((T)v.x, (T)v.y);
        
        /// <summary>
        /// Explicitly converts this to a gvec3.
        /// </summary>
        public static explicit operator gvec3<T>(gvec5<T> v) => new gvec3<T>((T)v.x, (T)v.y, (T)v.z);
        
        /// <summary>
        /// Explicitly converts this to a gvec4.
        /// </summary>
        public static explicit operator gvec4<T>(gvec5<T> v) => new gvec4<T>((T)v.x, (T)v.y, (T)v.z, (T)v.w);
        
        /// <summary>
        /// Explicitly converts this to a T array.
        /// </summary>
        public static explicit operator T[](gvec5<T> v) => new [] { v.x, v.y, v.z, v.w, v.v };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](gvec5<T> v) => new Object[] { v.x, v.y, v.z, v.w, v.v };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public T this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    case 3: return w;
                    case 4: return v;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    case 3: w = value; break;
                    case 4: v = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_gvec5<T> swizzle => new swizzle_gvec5<T>(x, y, z, w, v);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> xy
        {
            get
            {
                return new gvec2<T>(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> xz
        {
            get
            {
                return new gvec2<T>(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> yz
        {
            get
            {
                return new gvec2<T>(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> xyz
        {
            get
            {
                return new gvec3<T>(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> xw
        {
            get
            {
                return new gvec2<T>(x, w);
            }
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> yw
        {
            get
            {
                return new gvec2<T>(y, w);
            }
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> xyw
        {
            get
            {
                return new gvec3<T>(x, y, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> zw
        {
            get
            {
                return new gvec2<T>(z, w);
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> xzw
        {
            get
            {
                return new gvec3<T>(x, z, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> yzw
        {
            get
            {
                return new gvec3<T>(y, z, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec4<T> xyzw
        {
            get
            {
                return new gvec4<T>(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> xv
        {
            get
            {
                return new gvec2<T>(x, v);
            }
            set
            {
                x = value.x;
                v = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> yv
        {
            get
            {
                return new gvec2<T>(y, v);
            }
            set
            {
                y = value.x;
                v = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> xyv
        {
            get
            {
                return new gvec3<T>(x, y, v);
            }
            set
            {
                x = value.x;
                y = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> zv
        {
            get
            {
                return new gvec2<T>(z, v);
            }
            set
            {
                z = value.x;
                v = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> xzv
        {
            get
            {
                return new gvec3<T>(x, z, v);
            }
            set
            {
                x = value.x;
                z = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> yzv
        {
            get
            {
                return new gvec3<T>(y, z, v);
            }
            set
            {
                y = value.x;
                z = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec4<T> xyzv
        {
            get
            {
                return new gvec4<T>(x, y, z, v);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                v = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> wv
        {
            get
            {
                return new gvec2<T>(w, v);
            }
            set
            {
                w = value.x;
                v = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> xwv
        {
            get
            {
                return new gvec3<T>(x, w, v);
            }
            set
            {
                x = value.x;
                w = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> ywv
        {
            get
            {
                return new gvec3<T>(y, w, v);
            }
            set
            {
                y = value.x;
                w = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec4<T> xywv
        {
            get
            {
                return new gvec4<T>(x, y, w, v);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                v = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> zwv
        {
            get
            {
                return new gvec3<T>(z, w, v);
            }
            set
            {
                z = value.x;
                w = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec4<T> xzwv
        {
            get
            {
                return new gvec4<T>(x, z, w, v);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
                v = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec4<T> yzwv
        {
            get
            {
                return new gvec4<T>(y, z, w, v);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                v = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec5<T> xyzwv
        {
            get
            {
                return new gvec5<T>(x, y, z, w, v);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
                v = value.v;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> rg
        {
            get
            {
                return new gvec2<T>(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> rb
        {
            get
            {
                return new gvec2<T>(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> gb
        {
            get
            {
                return new gvec2<T>(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> rgb
        {
            get
            {
                return new gvec3<T>(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> ra
        {
            get
            {
                return new gvec2<T>(x, w);
            }
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> ga
        {
            get
            {
                return new gvec2<T>(y, w);
            }
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> rga
        {
            get
            {
                return new gvec3<T>(x, y, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> ba
        {
            get
            {
                return new gvec2<T>(z, w);
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> rba
        {
            get
            {
                return new gvec3<T>(x, z, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> gba
        {
            get
            {
                return new gvec3<T>(y, z, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec4<T> rgba
        {
            get
            {
                return new gvec4<T>(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> rk
        {
            get
            {
                return new gvec2<T>(x, v);
            }
            set
            {
                x = value.x;
                v = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> gk
        {
            get
            {
                return new gvec2<T>(y, v);
            }
            set
            {
                y = value.x;
                v = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> rgk
        {
            get
            {
                return new gvec3<T>(x, y, v);
            }
            set
            {
                x = value.x;
                y = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> bk
        {
            get
            {
                return new gvec2<T>(z, v);
            }
            set
            {
                z = value.x;
                v = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> rbk
        {
            get
            {
                return new gvec3<T>(x, z, v);
            }
            set
            {
                x = value.x;
                z = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> gbk
        {
            get
            {
                return new gvec3<T>(y, z, v);
            }
            set
            {
                y = value.x;
                z = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec4<T> rgbk
        {
            get
            {
                return new gvec4<T>(x, y, z, v);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                v = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec2<T> ak
        {
            get
            {
                return new gvec2<T>(w, v);
            }
            set
            {
                w = value.x;
                v = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> rak
        {
            get
            {
                return new gvec3<T>(x, w, v);
            }
            set
            {
                x = value.x;
                w = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> gak
        {
            get
            {
                return new gvec3<T>(y, w, v);
            }
            set
            {
                y = value.x;
                w = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec4<T> rgak
        {
            get
            {
                return new gvec4<T>(x, y, w, v);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                v = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec3<T> bak
        {
            get
            {
                return new gvec3<T>(z, w, v);
            }
            set
            {
                z = value.x;
                w = value.y;
                v = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec4<T> rbak
        {
            get
            {
                return new gvec4<T>(x, z, w, v);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
                v = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec4<T> gbak
        {
            get
            {
                return new gvec4<T>(y, z, w, v);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                v = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public gvec5<T> rgbak
        {
            get
            {
                return new gvec5<T>(x, y, z, w, v);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
                v = value.v;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public T r
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public T g
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public T b
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public T a
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public T k
        {
            get
            {
                return v;
            }
            set
            {
                v = value;
            }
        }
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public T[] Values => new[] { x, y, z, w, v };
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public int Count => 5;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static gvec5<T> Zero { get; } = new gvec5<T>(default(T), default(T), default(T), default(T), default(T));

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(gvec5<T> lhs, gvec5<T> rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(gvec5<T> lhs, gvec5<T> rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
            yield return w;
            yield return v;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public string ToString(string sep) => (((x + sep + y) + sep + z) + sep + (w + sep + v));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(gvec5<T> rhs) => (((EqualityComparer<T>.Default.Equals(x, rhs.x) && EqualityComparer<T>.Default.Equals(y, rhs.y)) && EqualityComparer<T>.Default.Equals(z, rhs.z)) && (EqualityComparer<T>.Default.Equals(w, rhs.w) && EqualityComparer<T>.Default.Equals(v, rhs.v)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is gvec5<T> && Equals((gvec5<T>) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((EqualityComparer<T>.Default.GetHashCode(x)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(y)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(z)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(w)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(v);
            }
        }

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec5 Equal(gvec5<T> lhs, gvec5<T> rhs) => new bvec5(EqualityComparer<T>.Default.Equals(lhs.x, rhs.x), EqualityComparer<T>.Default.Equals(lhs.y, rhs.y), EqualityComparer<T>.Default.Equals(lhs.z, rhs.z), EqualityComparer<T>.Default.Equals(lhs.w, rhs.w), EqualityComparer<T>.Default.Equals(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec5 Equal(gvec5<T> lhs, T rhs) => new bvec5(EqualityComparer<T>.Default.Equals(lhs.x, rhs), EqualityComparer<T>.Default.Equals(lhs.y, rhs), EqualityComparer<T>.Default.Equals(lhs.z, rhs), EqualityComparer<T>.Default.Equals(lhs.w, rhs), EqualityComparer<T>.Default.Equals(lhs.v, rhs));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec5 Equal(T lhs, gvec5<T> rhs) => new bvec5(EqualityComparer<T>.Default.Equals(lhs, rhs.x), EqualityComparer<T>.Default.Equals(lhs, rhs.y), EqualityComparer<T>.Default.Equals(lhs, rhs.z), EqualityComparer<T>.Default.Equals(lhs, rhs.w), EqualityComparer<T>.Default.Equals(lhs, rhs.v));
        
        /// <summary>
        /// Returns a bvec from the application of Equal (EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec5 Equal(T lhs, T rhs) => new bvec5(EqualityComparer<T>.Default.Equals(lhs, rhs));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec5 NotEqual(gvec5<T> lhs, gvec5<T> rhs) => new bvec5(!EqualityComparer<T>.Default.Equals(lhs.x, rhs.x), !EqualityComparer<T>.Default.Equals(lhs.y, rhs.y), !EqualityComparer<T>.Default.Equals(lhs.z, rhs.z), !EqualityComparer<T>.Default.Equals(lhs.w, rhs.w), !EqualityComparer<T>.Default.Equals(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec5 NotEqual(gvec5<T> lhs, T rhs) => new bvec5(!EqualityComparer<T>.Default.Equals(lhs.x, rhs), !EqualityComparer<T>.Default.Equals(lhs.y, rhs), !EqualityComparer<T>.Default.Equals(lhs.z, rhs), !EqualityComparer<T>.Default.Equals(lhs.w, rhs), !EqualityComparer<T>.Default.Equals(lhs.v, rhs));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec5 NotEqual(T lhs, gvec5<T> rhs) => new bvec5(!EqualityComparer<T>.Default.Equals(lhs, rhs.x), !EqualityComparer<T>.Default.Equals(lhs, rhs.y), !EqualityComparer<T>.Default.Equals(lhs, rhs.z), !EqualityComparer<T>.Default.Equals(lhs, rhs.w), !EqualityComparer<T>.Default.Equals(lhs, rhs.v));
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (!EqualityComparer&lt;T&gt;.Default.Equals(lhs, rhs)).
        /// </summary>
        public static bvec5 NotEqual(T lhs, T rhs) => new bvec5(!EqualityComparer<T>.Default.Equals(lhs, rhs));

        #endregion

    }
}
