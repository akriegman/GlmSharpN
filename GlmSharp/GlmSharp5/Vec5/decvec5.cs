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
    /// A vector of type decimal with 5 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct decvec5 : IReadOnlyList<decimal>, IEquatable<decvec5>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public decimal x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public decimal y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public decimal z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public decimal w;
        
        /// <summary>
        /// v-component
        /// </summary>
        [DataMember]
        public decimal v;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public decvec5(decimal x, decimal y, decimal z, decimal w, decimal v)
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
        public decvec5(decimal v)
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
        public decvec5(decvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0m;
            this.w = 0m;
            this.v = 0m;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public decvec5(decvec2 ve, decimal z)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = 0m;
            this.v = 0m;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public decvec5(decvec2 ve, decimal z, decimal w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = w;
            this.v = 0m;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public decvec5(decvec2 ve, decimal z, decimal w, decimal v)
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
        public decvec5(decvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0m;
            this.v = 0m;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public decvec5(decvec3 ve, decimal w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = ve.z;
            this.w = w;
            this.v = 0m;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public decvec5(decvec3 ve, decimal w, decimal v)
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
        public decvec5(decvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
            this.v = 0m;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public decvec5(decvec4 ve, decimal v)
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
        public decvec5(decvec5 v)
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
        public decvec5(IReadOnlyList<decimal> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0m : v[0];
            this.y = c < 1 ? 0m : v[1];
            this.z = c < 2 ? 0m : v[2];
            this.w = c < 3 ? 0m : v[3];
            this.v = c < 4 ? 0m : v[4];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec5(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0m : (decimal)v[0];
            this.y = c < 1 ? 0m : (decimal)v[1];
            this.z = c < 2 ? 0m : (decimal)v[2];
            this.w = c < 3 ? 0m : (decimal)v[3];
            this.v = c < 4 ? 0m : (decimal)v[4];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec5(decimal[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0m : v[0];
            this.y = c < 1 ? 0m : v[1];
            this.z = c < 2 ? 0m : v[2];
            this.w = c < 3 ? 0m : v[3];
            this.v = c < 4 ? 0m : v[4];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec5(decimal[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0m : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0m : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0m : v[2 + startIndex];
            this.w = c + startIndex < 3 ? 0m : v[3 + startIndex];
            this.v = c + startIndex < 4 ? 0m : v[4 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec5(IEnumerable<decimal> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(decvec5 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(decvec5 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(decvec5 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a ivec5.
        /// </summary>
        public static explicit operator ivec5(decvec5 v) => new ivec5((int)v.x, (int)v.y, (int)v.z, (int)v.w, (int)v.v);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(decvec5 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(decvec5 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(decvec5 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec5.
        /// </summary>
        public static explicit operator uvec5(decvec5 v) => new uvec5((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w, (uint)v.v);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(decvec5 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(decvec5 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(decvec5 v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a vec5.
        /// </summary>
        public static explicit operator vec5(decvec5 v) => new vec5((float)v.x, (float)v.y, (float)v.z, (float)v.w, (float)v.v);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(decvec5 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(decvec5 v) => new hvec3((Half)v.x, (Half)v.y, (Half)v.z);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(decvec5 v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Explicitly converts this to a hvec5.
        /// </summary>
        public static explicit operator hvec5(decvec5 v) => new hvec5((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w, (Half)v.v);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(decvec5 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(decvec5 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(decvec5 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a dvec5.
        /// </summary>
        public static explicit operator dvec5(decvec5 v) => new dvec5((double)v.x, (double)v.y, (double)v.z, (double)v.w, (double)v.v);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(decvec5 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(decvec5 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(decvec5 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(decvec5 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(decvec5 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(decvec5 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
        /// <summary>
        /// Explicitly converts this to a cvec5.
        /// </summary>
        public static explicit operator cvec5(decvec5 v) => new cvec5((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w, (Complex)v.v);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(decvec5 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(decvec5 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(decvec5 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lvec5.
        /// </summary>
        public static explicit operator lvec5(decvec5 v) => new lvec5((long)v.x, (long)v.y, (long)v.z, (long)v.w, (long)v.v);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(decvec5 v) => new bvec2(v.x != 0m, v.y != 0m);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(decvec5 v) => new bvec3(v.x != 0m, v.y != 0m, v.z != 0m);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(decvec5 v) => new bvec4(v.x != 0m, v.y != 0m, v.z != 0m, v.w != 0m);
        
        /// <summary>
        /// Explicitly converts this to a bvec5.
        /// </summary>
        public static explicit operator bvec5(decvec5 v) => new bvec5(v.x != 0m, v.y != 0m, v.z != 0m, v.w != 0m, v.v != 0m);
        
        /// <summary>
        /// Explicitly converts this to a decimal array.
        /// </summary>
        public static explicit operator decimal[](decvec5 v) => new [] { v.x, v.y, v.z, v.w, v.v };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](decvec5 v) => new Object[] { v.x, v.y, v.z, v.w, v.v };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public decimal this[int index]
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
        public swizzle_decvec5 swizzle => new swizzle_decvec5(x, y, z, w, v);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public decvec2 xy
        {
            get
            {
                return new decvec2(x, y);
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
        public decvec2 xz
        {
            get
            {
                return new decvec2(x, z);
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
        public decvec2 yz
        {
            get
            {
                return new decvec2(y, z);
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
        public decvec3 xyz
        {
            get
            {
                return new decvec3(x, y, z);
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
        public decvec2 xw
        {
            get
            {
                return new decvec2(x, w);
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
        public decvec2 yw
        {
            get
            {
                return new decvec2(y, w);
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
        public decvec3 xyw
        {
            get
            {
                return new decvec3(x, y, w);
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
        public decvec2 zw
        {
            get
            {
                return new decvec2(z, w);
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
        public decvec3 xzw
        {
            get
            {
                return new decvec3(x, z, w);
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
        public decvec3 yzw
        {
            get
            {
                return new decvec3(y, z, w);
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
        public decvec4 xyzw
        {
            get
            {
                return new decvec4(x, y, z, w);
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
        public decvec2 xv
        {
            get
            {
                return new decvec2(x, v);
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
        public decvec2 yv
        {
            get
            {
                return new decvec2(y, v);
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
        public decvec3 xyv
        {
            get
            {
                return new decvec3(x, y, v);
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
        public decvec2 zv
        {
            get
            {
                return new decvec2(z, v);
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
        public decvec3 xzv
        {
            get
            {
                return new decvec3(x, z, v);
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
        public decvec3 yzv
        {
            get
            {
                return new decvec3(y, z, v);
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
        public decvec4 xyzv
        {
            get
            {
                return new decvec4(x, y, z, v);
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
        public decvec2 wv
        {
            get
            {
                return new decvec2(w, v);
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
        public decvec3 xwv
        {
            get
            {
                return new decvec3(x, w, v);
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
        public decvec3 ywv
        {
            get
            {
                return new decvec3(y, w, v);
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
        public decvec4 xywv
        {
            get
            {
                return new decvec4(x, y, w, v);
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
        public decvec3 zwv
        {
            get
            {
                return new decvec3(z, w, v);
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
        public decvec4 xzwv
        {
            get
            {
                return new decvec4(x, z, w, v);
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
        public decvec4 yzwv
        {
            get
            {
                return new decvec4(y, z, w, v);
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
        public decvec5 xyzwv
        {
            get
            {
                return new decvec5(x, y, z, w, v);
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
        public decvec2 rg
        {
            get
            {
                return new decvec2(x, y);
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
        public decvec2 rb
        {
            get
            {
                return new decvec2(x, z);
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
        public decvec2 gb
        {
            get
            {
                return new decvec2(y, z);
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
        public decvec3 rgb
        {
            get
            {
                return new decvec3(x, y, z);
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
        public decvec2 ra
        {
            get
            {
                return new decvec2(x, w);
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
        public decvec2 ga
        {
            get
            {
                return new decvec2(y, w);
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
        public decvec3 rga
        {
            get
            {
                return new decvec3(x, y, w);
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
        public decvec2 ba
        {
            get
            {
                return new decvec2(z, w);
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
        public decvec3 rba
        {
            get
            {
                return new decvec3(x, z, w);
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
        public decvec3 gba
        {
            get
            {
                return new decvec3(y, z, w);
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
        public decvec4 rgba
        {
            get
            {
                return new decvec4(x, y, z, w);
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
        public decvec2 rk
        {
            get
            {
                return new decvec2(x, v);
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
        public decvec2 gk
        {
            get
            {
                return new decvec2(y, v);
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
        public decvec3 rgk
        {
            get
            {
                return new decvec3(x, y, v);
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
        public decvec2 bk
        {
            get
            {
                return new decvec2(z, v);
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
        public decvec3 rbk
        {
            get
            {
                return new decvec3(x, z, v);
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
        public decvec3 gbk
        {
            get
            {
                return new decvec3(y, z, v);
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
        public decvec4 rgbk
        {
            get
            {
                return new decvec4(x, y, z, v);
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
        public decvec2 ak
        {
            get
            {
                return new decvec2(w, v);
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
        public decvec3 rak
        {
            get
            {
                return new decvec3(x, w, v);
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
        public decvec3 gak
        {
            get
            {
                return new decvec3(y, w, v);
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
        public decvec4 rgak
        {
            get
            {
                return new decvec4(x, y, w, v);
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
        public decvec3 bak
        {
            get
            {
                return new decvec3(z, w, v);
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
        public decvec4 rbak
        {
            get
            {
                return new decvec4(x, z, w, v);
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
        public decvec4 gbak
        {
            get
            {
                return new decvec4(y, z, w, v);
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
        public decvec5 rgbak
        {
            get
            {
                return new decvec5(x, y, z, w, v);
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
        public decimal r
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
        public decimal g
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
        public decimal b
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
        public decimal a
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
        public decimal k
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
        public decimal[] Values => new[] { x, y, z, w, v };
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public int Count => 5;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public decimal MinElement => Math.Min(Math.Min(Math.Min(x, y), z), Math.Min(w, v));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public decimal MaxElement => Math.Max(Math.Max(Math.Max(x, y), z), Math.Max(w, v));
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public decimal Length => (decimal)((((x*x + y*y) + z*z) + (w*w + v*v))).Sqrt();
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public decimal LengthSqr => (((x*x + y*y) + z*z) + (w*w + v*v));
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public decimal Sum => (((x + y) + z) + (w + v));
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public decimal Norm => (decimal)((((x*x + y*y) + z*z) + (w*w + v*v))).Sqrt();
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public decimal Norm1 => (((Math.Abs(x) + Math.Abs(y)) + Math.Abs(z)) + (Math.Abs(w) + Math.Abs(v)));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public decimal Norm2 => (decimal)((((x*x + y*y) + z*z) + (w*w + v*v))).Sqrt();
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public decimal NormMax => Math.Max(Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z)), Math.Max(Math.Abs(w), Math.Abs(v)));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public decvec5 Normalized => this / (decimal)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public decvec5 NormalizedSafe => this == Zero ? Zero : this / (decimal)Length;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static decvec5 Zero { get; } = new decvec5(0m, 0m, 0m, 0m, 0m);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static decvec5 Ones { get; } = new decvec5(1m, 1m, 1m, 1m, 1m);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static decvec5 UnitX { get; } = new decvec5(1m, 0m, 0m, 0m, 0m);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static decvec5 UnitY { get; } = new decvec5(0m, 1m, 0m, 0m, 0m);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static decvec5 UnitZ { get; } = new decvec5(0m, 0m, 1m, 0m, 0m);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static decvec5 UnitW { get; } = new decvec5(0m, 0m, 0m, 1m, 0m);
        
        /// <summary>
        /// Predefined unit-V vector
        /// </summary>
        public static decvec5 UnitV { get; } = new decvec5(0m, 0m, 0m, 0m, 1m);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static decvec5 MaxValue { get; } = new decvec5(decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static decvec5 MinValue { get; } = new decvec5(decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue);
        
        /// <summary>
        /// Predefined all-MinusOne vector
        /// </summary>
        public static decvec5 MinusOne { get; } = new decvec5(decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(decvec5 lhs, decvec5 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(decvec5 lhs, decvec5 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<decimal> GetEnumerator()
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
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => (((x.ToString(provider) + sep + y.ToString(provider)) + sep + z.ToString(provider)) + sep + (w.ToString(provider) + sep + v.ToString(provider)));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => (((x.ToString(format) + sep + y.ToString(format)) + sep + z.ToString(format)) + sep + (w.ToString(format) + sep + v.ToString(format)));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => (((x.ToString(format, provider) + sep + y.ToString(format, provider)) + sep + z.ToString(format, provider)) + sep + (w.ToString(format, provider) + sep + v.ToString(format, provider)));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(decvec5 rhs) => (((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z)) && (w.Equals(rhs.w) && v.Equals(rhs.v)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is decvec5 && Equals((decvec5) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((x.GetHashCode()) * 397) ^ y.GetHashCode()) * 397) ^ z.GetHashCode()) * 397) ^ w.GetHashCode()) * 397) ^ v.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow((((Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p)) + Math.Pow((double)Math.Abs(z), p)) + (Math.Pow((double)Math.Abs(w), p) + Math.Pow((double)Math.Abs(v), p))), 1 / p);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static decvec5 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static decvec5 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new decvec5(decimal.Parse(kvp[0].Trim()), decimal.Parse(kvp[1].Trim()), decimal.Parse(kvp[2].Trim()), decimal.Parse(kvp[3].Trim()), decimal.Parse(kvp[4].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static decvec5 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new decvec5(decimal.Parse(kvp[0].Trim(), provider), decimal.Parse(kvp[1].Trim(), provider), decimal.Parse(kvp[2].Trim(), provider), decimal.Parse(kvp[3].Trim(), provider), decimal.Parse(kvp[4].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static decvec5 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new decvec5(decimal.Parse(kvp[0].Trim(), style), decimal.Parse(kvp[1].Trim(), style), decimal.Parse(kvp[2].Trim(), style), decimal.Parse(kvp[3].Trim(), style), decimal.Parse(kvp[4].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static decvec5 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new decvec5(decimal.Parse(kvp[0].Trim(), style, provider), decimal.Parse(kvp[1].Trim(), style, provider), decimal.Parse(kvp[2].Trim(), style, provider), decimal.Parse(kvp[3].Trim(), style, provider), decimal.Parse(kvp[4].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out decvec5 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out decvec5 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) return false;
            decimal x = 0m, y = 0m, z = 0m, w = 0m, v = 0m;
            var ok = (((decimal.TryParse(kvp[0].Trim(), out x) && decimal.TryParse(kvp[1].Trim(), out y)) && decimal.TryParse(kvp[2].Trim(), out z)) && (decimal.TryParse(kvp[3].Trim(), out w) && decimal.TryParse(kvp[4].Trim(), out v)));
            result = ok ? new decvec5(x, y, z, w, v) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out decvec5 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) return false;
            decimal x = 0m, y = 0m, z = 0m, w = 0m, v = 0m;
            var ok = (((decimal.TryParse(kvp[0].Trim(), style, provider, out x) && decimal.TryParse(kvp[1].Trim(), style, provider, out y)) && decimal.TryParse(kvp[2].Trim(), style, provider, out z)) && (decimal.TryParse(kvp[3].Trim(), style, provider, out w) && decimal.TryParse(kvp[4].Trim(), style, provider, out v)));
            result = ok ? new decvec5(x, y, z, w, v) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(decvec5 lhs, decvec5 rhs, decimal eps = 0.1m) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat5x2 OuterProduct(decvec2 c, decvec5 r) => new decmat5x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w, c.x * r.v, c.y * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat2x5 OuterProduct(decvec5 c, decvec2 r) => new decmat2x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat5x3 OuterProduct(decvec3 c, decvec5 r) => new decmat5x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.x * r.v, c.y * r.v, c.z * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat3x5 OuterProduct(decvec5 c, decvec3 r) => new decmat3x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat5x4 OuterProduct(decvec4 c, decvec5 r) => new decmat5x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.x * r.v, c.y * r.v, c.z * r.v, c.w * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat4x5 OuterProduct(decvec5 c, decvec4 r) => new decmat4x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.v * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat5 OuterProduct(decvec5 c, decvec5 r) => new decmat5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.v * r.w, c.x * r.v, c.y * r.v, c.z * r.v, c.w * r.v, c.v * r.v);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static decimal Dot(decvec5 lhs, decvec5 rhs) => (((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z) + (lhs.w * rhs.w + lhs.v * rhs.v));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static decimal Distance(decvec5 lhs, decvec5 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static decimal DistanceSqr(decvec5 lhs, decvec5 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec5 Reflect(decvec5 I, decvec5 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec5 Refract(decvec5 I, decvec5 N, decimal eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (decimal)(k).Sqrt()) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static decvec5 FaceForward(decvec5 N, decvec5 I, decvec5 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static decvec5 Random(Random random) => new decvec5((decimal)random.NextDouble(), (decimal)random.NextDouble(), (decimal)random.NextDouble(), (decimal)random.NextDouble(), (decimal)random.NextDouble());
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static decvec5 RandomSigned(Random random) => new decvec5((decimal)(random.NextDouble() * 2.0 - 1.0), (decimal)(random.NextDouble() * 2.0 - 1.0), (decimal)(random.NextDouble() * 2.0 - 1.0), (decimal)(random.NextDouble() * 2.0 - 1.0), (decimal)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static decvec5 RandomNormal(Random random) => new decvec5((decimal)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (decimal)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (decimal)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (decimal)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (decimal)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(decvec5 lhs, decvec5 rhs) => new bvec5(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w, lhs.v == rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(decvec5 lhs, decimal rhs) => new bvec5(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs, lhs.v == rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(decimal lhs, decvec5 rhs) => new bvec5(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w, lhs == rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(decimal lhs, decimal rhs) => new bvec5(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(decvec5 lhs, decvec5 rhs) => new bvec5(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w, lhs.v != rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(decvec5 lhs, decimal rhs) => new bvec5(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs, lhs.v != rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(decimal lhs, decvec5 rhs) => new bvec5(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w, lhs != rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(decimal lhs, decimal rhs) => new bvec5(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(decvec5 lhs, decvec5 rhs) => new bvec5(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w, lhs.v > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(decvec5 lhs, decimal rhs) => new bvec5(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs, lhs.v > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(decimal lhs, decvec5 rhs) => new bvec5(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w, lhs > rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(decimal lhs, decimal rhs) => new bvec5(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(decvec5 lhs, decvec5 rhs) => new bvec5(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w, lhs.v >= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(decvec5 lhs, decimal rhs) => new bvec5(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs, lhs.v >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(decimal lhs, decvec5 rhs) => new bvec5(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w, lhs >= rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(decimal lhs, decimal rhs) => new bvec5(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(decvec5 lhs, decvec5 rhs) => new bvec5(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w, lhs.v < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(decvec5 lhs, decimal rhs) => new bvec5(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs, lhs.v < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(decimal lhs, decvec5 rhs) => new bvec5(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w, lhs < rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(decimal lhs, decimal rhs) => new bvec5(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(decvec5 lhs, decvec5 rhs) => new bvec5(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w, lhs.v <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(decvec5 lhs, decimal rhs) => new bvec5(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs, lhs.v <= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(decimal lhs, decvec5 rhs) => new bvec5(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w, lhs <= rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(decimal lhs, decimal rhs) => new bvec5(lhs <= rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static decvec5 Abs(decvec5 v) => new decvec5(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z), Math.Abs(v.w), Math.Abs(v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Abs (Math.Abs(v)).
        /// </summary>
        public static decvec5 Abs(decimal v) => new decvec5(Math.Abs(v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static decvec5 HermiteInterpolationOrder3(decvec5 v) => new decvec5((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w, (3 - 2 * v.v) * v.v * v.v);
        
        /// <summary>
        /// Returns a decvec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static decvec5 HermiteInterpolationOrder3(decimal v) => new decvec5((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static decvec5 HermiteInterpolationOrder5(decvec5 v) => new decvec5(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w, ((6 * v.v - 15) * v.v + 10) * v.v * v.v * v.v);
        
        /// <summary>
        /// Returns a decvec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static decvec5 HermiteInterpolationOrder5(decimal v) => new decvec5(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static decvec5 Sqr(decvec5 v) => new decvec5(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w, v.v * v.v);
        
        /// <summary>
        /// Returns a decvec from the application of Sqr (v * v).
        /// </summary>
        public static decvec5 Sqr(decimal v) => new decvec5(v * v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static decvec5 Pow2(decvec5 v) => new decvec5(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w, v.v * v.v);
        
        /// <summary>
        /// Returns a decvec from the application of Pow2 (v * v).
        /// </summary>
        public static decvec5 Pow2(decimal v) => new decvec5(v * v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static decvec5 Pow3(decvec5 v) => new decvec5(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w, v.v * v.v * v.v);
        
        /// <summary>
        /// Returns a decvec from the application of Pow3 (v * v * v).
        /// </summary>
        public static decvec5 Pow3(decimal v) => new decvec5(v * v * v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Step (v &gt;= 0m ? 1m : 0m).
        /// </summary>
        public static decvec5 Step(decvec5 v) => new decvec5(v.x >= 0m ? 1m : 0m, v.y >= 0m ? 1m : 0m, v.z >= 0m ? 1m : 0m, v.w >= 0m ? 1m : 0m, v.v >= 0m ? 1m : 0m);
        
        /// <summary>
        /// Returns a decvec from the application of Step (v &gt;= 0m ? 1m : 0m).
        /// </summary>
        public static decvec5 Step(decimal v) => new decvec5(v >= 0m ? 1m : 0m);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sqrt ((decimal)Math.Sqrt((double)v)).
        /// </summary>
        public static decvec5 Sqrt(decvec5 v) => new decvec5((decimal)Math.Sqrt((double)v.x), (decimal)Math.Sqrt((double)v.y), (decimal)Math.Sqrt((double)v.z), (decimal)Math.Sqrt((double)v.w), (decimal)Math.Sqrt((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Sqrt ((decimal)Math.Sqrt((double)v)).
        /// </summary>
        public static decvec5 Sqrt(decimal v) => new decvec5((decimal)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of InverseSqrt ((decimal)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static decvec5 InverseSqrt(decvec5 v) => new decvec5((decimal)(1.0 / Math.Sqrt((double)v.x)), (decimal)(1.0 / Math.Sqrt((double)v.y)), (decimal)(1.0 / Math.Sqrt((double)v.z)), (decimal)(1.0 / Math.Sqrt((double)v.w)), (decimal)(1.0 / Math.Sqrt((double)v.v)));
        
        /// <summary>
        /// Returns a decvec from the application of InverseSqrt ((decimal)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static decvec5 InverseSqrt(decimal v) => new decvec5((decimal)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(decvec5 v) => new ivec5(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z), Math.Sign(v.w), Math.Sign(v.v));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(decimal v) => new ivec5(Math.Sign(v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec5 Max(decvec5 lhs, decvec5 rhs) => new decvec5(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z), Math.Max(lhs.w, rhs.w), Math.Max(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec5 Max(decvec5 lhs, decimal rhs) => new decvec5(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs), Math.Max(lhs.z, rhs), Math.Max(lhs.w, rhs), Math.Max(lhs.v, rhs));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec5 Max(decimal lhs, decvec5 rhs) => new decvec5(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y), Math.Max(lhs, rhs.z), Math.Max(lhs, rhs.w), Math.Max(lhs, rhs.v));
        
        /// <summary>
        /// Returns a decvec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec5 Max(decimal lhs, decimal rhs) => new decvec5(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec5 Min(decvec5 lhs, decvec5 rhs) => new decvec5(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z), Math.Min(lhs.w, rhs.w), Math.Min(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec5 Min(decvec5 lhs, decimal rhs) => new decvec5(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs), Math.Min(lhs.z, rhs), Math.Min(lhs.w, rhs), Math.Min(lhs.v, rhs));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec5 Min(decimal lhs, decvec5 rhs) => new decvec5(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y), Math.Min(lhs, rhs.z), Math.Min(lhs, rhs.w), Math.Min(lhs, rhs.v));
        
        /// <summary>
        /// Returns a decvec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec5 Min(decimal lhs, decimal rhs) => new decvec5(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec5 Pow(decvec5 lhs, decvec5 rhs) => new decvec5((decimal)Math.Pow((double)lhs.x, (double)rhs.x), (decimal)Math.Pow((double)lhs.y, (double)rhs.y), (decimal)Math.Pow((double)lhs.z, (double)rhs.z), (decimal)Math.Pow((double)lhs.w, (double)rhs.w), (decimal)Math.Pow((double)lhs.v, (double)rhs.v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec5 Pow(decvec5 lhs, decimal rhs) => new decvec5((decimal)Math.Pow((double)lhs.x, (double)rhs), (decimal)Math.Pow((double)lhs.y, (double)rhs), (decimal)Math.Pow((double)lhs.z, (double)rhs), (decimal)Math.Pow((double)lhs.w, (double)rhs), (decimal)Math.Pow((double)lhs.v, (double)rhs));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec5 Pow(decimal lhs, decvec5 rhs) => new decvec5((decimal)Math.Pow((double)lhs, (double)rhs.x), (decimal)Math.Pow((double)lhs, (double)rhs.y), (decimal)Math.Pow((double)lhs, (double)rhs.z), (decimal)Math.Pow((double)lhs, (double)rhs.w), (decimal)Math.Pow((double)lhs, (double)rhs.v));
        
        /// <summary>
        /// Returns a decvec from the application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec5 Pow(decimal lhs, decimal rhs) => new decvec5((decimal)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec5 Log(decvec5 lhs, decvec5 rhs) => new decvec5((decimal)Math.Log((double)lhs.x, (double)rhs.x), (decimal)Math.Log((double)lhs.y, (double)rhs.y), (decimal)Math.Log((double)lhs.z, (double)rhs.z), (decimal)Math.Log((double)lhs.w, (double)rhs.w), (decimal)Math.Log((double)lhs.v, (double)rhs.v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec5 Log(decvec5 lhs, decimal rhs) => new decvec5((decimal)Math.Log((double)lhs.x, (double)rhs), (decimal)Math.Log((double)lhs.y, (double)rhs), (decimal)Math.Log((double)lhs.z, (double)rhs), (decimal)Math.Log((double)lhs.w, (double)rhs), (decimal)Math.Log((double)lhs.v, (double)rhs));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec5 Log(decimal lhs, decvec5 rhs) => new decvec5((decimal)Math.Log((double)lhs, (double)rhs.x), (decimal)Math.Log((double)lhs, (double)rhs.y), (decimal)Math.Log((double)lhs, (double)rhs.z), (decimal)Math.Log((double)lhs, (double)rhs.w), (decimal)Math.Log((double)lhs, (double)rhs.v));
        
        /// <summary>
        /// Returns a decvec from the application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec5 Log(decimal lhs, decimal rhs) => new decvec5((decimal)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec5 Clamp(decvec5 v, decvec5 min, decvec5 max) => new decvec5(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z), Math.Min(Math.Max(v.w, min.w), max.w), Math.Min(Math.Max(v.v, min.v), max.v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec5 Clamp(decvec5 v, decvec5 min, decimal max) => new decvec5(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max), Math.Min(Math.Max(v.w, min.w), max), Math.Min(Math.Max(v.v, min.v), max));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec5 Clamp(decvec5 v, decimal min, decvec5 max) => new decvec5(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z), Math.Min(Math.Max(v.w, min), max.w), Math.Min(Math.Max(v.v, min), max.v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec5 Clamp(decvec5 v, decimal min, decimal max) => new decvec5(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max), Math.Min(Math.Max(v.w, min), max), Math.Min(Math.Max(v.v, min), max));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec5 Clamp(decimal v, decvec5 min, decvec5 max) => new decvec5(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z), Math.Min(Math.Max(v, min.w), max.w), Math.Min(Math.Max(v, min.v), max.v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec5 Clamp(decimal v, decvec5 min, decimal max) => new decvec5(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max), Math.Min(Math.Max(v, min.w), max), Math.Min(Math.Max(v, min.v), max));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec5 Clamp(decimal v, decimal min, decvec5 max) => new decvec5(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z), Math.Min(Math.Max(v, min), max.w), Math.Min(Math.Max(v, min), max.v));
        
        /// <summary>
        /// Returns a decvec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec5 Clamp(decimal v, decimal min, decimal max) => new decvec5(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Mix(decvec5 min, decvec5 max, decvec5 a) => new decvec5(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w, min.v * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Mix(decvec5 min, decvec5 max, decimal a) => new decvec5(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a, min.v * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Mix(decvec5 min, decimal max, decvec5 a) => new decvec5(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w, min.v * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Mix(decvec5 min, decimal max, decimal a) => new decvec5(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a, min.v * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Mix(decimal min, decvec5 max, decvec5 a) => new decvec5(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w, min * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Mix(decimal min, decvec5 max, decimal a) => new decvec5(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a, min * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Mix(decimal min, decimal max, decvec5 a) => new decvec5(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w, min * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a decvec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Mix(decimal min, decimal max, decimal a) => new decvec5(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Lerp(decvec5 min, decvec5 max, decvec5 a) => new decvec5(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w, min.v * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Lerp(decvec5 min, decvec5 max, decimal a) => new decvec5(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a, min.v * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Lerp(decvec5 min, decimal max, decvec5 a) => new decvec5(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w, min.v * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Lerp(decvec5 min, decimal max, decimal a) => new decvec5(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a, min.v * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Lerp(decimal min, decvec5 max, decvec5 a) => new decvec5(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w, min * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Lerp(decimal min, decvec5 max, decimal a) => new decvec5(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a, min * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Lerp(decimal min, decimal max, decvec5 a) => new decvec5(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w, min * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a decvec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec5 Lerp(decimal min, decimal max, decimal a) => new decvec5(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec5 Smoothstep(decvec5 edge0, decvec5 edge1, decvec5 v) => new decvec5(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec5 Smoothstep(decvec5 edge0, decvec5 edge1, decimal v) => new decvec5(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec5 Smoothstep(decvec5 edge0, decimal edge1, decvec5 v) => new decvec5(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec5 Smoothstep(decvec5 edge0, decimal edge1, decimal v) => new decvec5(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec5 Smoothstep(decimal edge0, decvec5 edge1, decvec5 v) => new decvec5(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec5 Smoothstep(decimal edge0, decvec5 edge1, decimal v) => new decvec5(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec5 Smoothstep(decimal edge0, decimal edge1, decvec5 v) => new decvec5(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec5 Smoothstep(decimal edge0, decimal edge1, decimal v) => new decvec5(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec5 Smootherstep(decvec5 edge0, decvec5 edge1, decvec5 v) => new decvec5(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec5 Smootherstep(decvec5 edge0, decvec5 edge1, decimal v) => new decvec5(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec5 Smootherstep(decvec5 edge0, decimal edge1, decvec5 v) => new decvec5(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec5 Smootherstep(decvec5 edge0, decimal edge1, decimal v) => new decvec5(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec5 Smootherstep(decimal edge0, decvec5 edge1, decvec5 v) => new decvec5(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec5 Smootherstep(decimal edge0, decvec5 edge1, decimal v) => new decvec5(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec5 Smootherstep(decimal edge0, decimal edge1, decvec5 v) => new decvec5(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec5 Smootherstep(decimal edge0, decimal edge1, decimal v) => new decvec5(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec5 Fma(decvec5 a, decvec5 b, decvec5 c) => new decvec5(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w, a.v * b.v + c.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec5 Fma(decvec5 a, decvec5 b, decimal c) => new decvec5(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c, a.v * b.v + c);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec5 Fma(decvec5 a, decimal b, decvec5 c) => new decvec5(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w, a.v * b + c.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec5 Fma(decvec5 a, decimal b, decimal c) => new decvec5(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c, a.v * b + c);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec5 Fma(decimal a, decvec5 b, decvec5 c) => new decvec5(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w, a * b.v + c.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec5 Fma(decimal a, decvec5 b, decimal c) => new decvec5(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c, a * b.v + c);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec5 Fma(decimal a, decimal b, decvec5 c) => new decvec5(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w, a * b + c.v);
        
        /// <summary>
        /// Returns a decvec from the application of Fma (a * b + c).
        /// </summary>
        public static decvec5 Fma(decimal a, decimal b, decimal c) => new decvec5(a * b + c);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec5 Add(decvec5 lhs, decvec5 rhs) => new decvec5(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w, lhs.v + rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec5 Add(decvec5 lhs, decimal rhs) => new decvec5(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs, lhs.v + rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec5 Add(decimal lhs, decvec5 rhs) => new decvec5(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w, lhs + rhs.v);
        
        /// <summary>
        /// Returns a decvec from the application of Add (lhs + rhs).
        /// </summary>
        public static decvec5 Add(decimal lhs, decimal rhs) => new decvec5(lhs + rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec5 Sub(decvec5 lhs, decvec5 rhs) => new decvec5(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w, lhs.v - rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec5 Sub(decvec5 lhs, decimal rhs) => new decvec5(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs, lhs.v - rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec5 Sub(decimal lhs, decvec5 rhs) => new decvec5(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w, lhs - rhs.v);
        
        /// <summary>
        /// Returns a decvec from the application of Sub (lhs - rhs).
        /// </summary>
        public static decvec5 Sub(decimal lhs, decimal rhs) => new decvec5(lhs - rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec5 Mul(decvec5 lhs, decvec5 rhs) => new decvec5(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w, lhs.v * rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec5 Mul(decvec5 lhs, decimal rhs) => new decvec5(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs, lhs.v * rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec5 Mul(decimal lhs, decvec5 rhs) => new decvec5(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w, lhs * rhs.v);
        
        /// <summary>
        /// Returns a decvec from the application of Mul (lhs * rhs).
        /// </summary>
        public static decvec5 Mul(decimal lhs, decimal rhs) => new decvec5(lhs * rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec5 Div(decvec5 lhs, decvec5 rhs) => new decvec5(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w, lhs.v / rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec5 Div(decvec5 lhs, decimal rhs) => new decvec5(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs, lhs.v / rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec5 Div(decimal lhs, decvec5 rhs) => new decvec5(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w, lhs / rhs.v);
        
        /// <summary>
        /// Returns a decvec from the application of Div (lhs / rhs).
        /// </summary>
        public static decvec5 Div(decimal lhs, decimal rhs) => new decvec5(lhs / rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec5 Modulo(decvec5 lhs, decvec5 rhs) => new decvec5(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w, lhs.v % rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec5 Modulo(decvec5 lhs, decimal rhs) => new decvec5(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs, lhs.v % rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec5 Modulo(decimal lhs, decvec5 rhs) => new decvec5(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w, lhs % rhs.v);
        
        /// <summary>
        /// Returns a decvec from the application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec5 Modulo(decimal lhs, decimal rhs) => new decvec5(lhs % rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static decvec5 Degrees(decvec5 v) => new decvec5((decimal)(v.x * 57.295779513082320876798154814105170332405472466564321m), (decimal)(v.y * 57.295779513082320876798154814105170332405472466564321m), (decimal)(v.z * 57.295779513082320876798154814105170332405472466564321m), (decimal)(v.w * 57.295779513082320876798154814105170332405472466564321m), (decimal)(v.v * 57.295779513082320876798154814105170332405472466564321m));
        
        /// <summary>
        /// Returns a decvec from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static decvec5 Degrees(decimal v) => new decvec5((decimal)(v * 57.295779513082320876798154814105170332405472466564321m));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static decvec5 Radians(decvec5 v) => new decvec5((decimal)(v.x * 0.0174532925199432957692369076848861271344287188854172m), (decimal)(v.y * 0.0174532925199432957692369076848861271344287188854172m), (decimal)(v.z * 0.0174532925199432957692369076848861271344287188854172m), (decimal)(v.w * 0.0174532925199432957692369076848861271344287188854172m), (decimal)(v.v * 0.0174532925199432957692369076848861271344287188854172m));
        
        /// <summary>
        /// Returns a decvec from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static decvec5 Radians(decimal v) => new decvec5((decimal)(v * 0.0174532925199432957692369076848861271344287188854172m));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Acos ((decimal)Math.Acos((double)v)).
        /// </summary>
        public static decvec5 Acos(decvec5 v) => new decvec5((decimal)Math.Acos((double)v.x), (decimal)Math.Acos((double)v.y), (decimal)Math.Acos((double)v.z), (decimal)Math.Acos((double)v.w), (decimal)Math.Acos((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Acos ((decimal)Math.Acos((double)v)).
        /// </summary>
        public static decvec5 Acos(decimal v) => new decvec5((decimal)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Asin ((decimal)Math.Asin((double)v)).
        /// </summary>
        public static decvec5 Asin(decvec5 v) => new decvec5((decimal)Math.Asin((double)v.x), (decimal)Math.Asin((double)v.y), (decimal)Math.Asin((double)v.z), (decimal)Math.Asin((double)v.w), (decimal)Math.Asin((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Asin ((decimal)Math.Asin((double)v)).
        /// </summary>
        public static decvec5 Asin(decimal v) => new decvec5((decimal)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Atan ((decimal)Math.Atan((double)v)).
        /// </summary>
        public static decvec5 Atan(decvec5 v) => new decvec5((decimal)Math.Atan((double)v.x), (decimal)Math.Atan((double)v.y), (decimal)Math.Atan((double)v.z), (decimal)Math.Atan((double)v.w), (decimal)Math.Atan((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Atan ((decimal)Math.Atan((double)v)).
        /// </summary>
        public static decvec5 Atan(decimal v) => new decvec5((decimal)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Cos ((decimal)Math.Cos((double)v)).
        /// </summary>
        public static decvec5 Cos(decvec5 v) => new decvec5((decimal)Math.Cos((double)v.x), (decimal)Math.Cos((double)v.y), (decimal)Math.Cos((double)v.z), (decimal)Math.Cos((double)v.w), (decimal)Math.Cos((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Cos ((decimal)Math.Cos((double)v)).
        /// </summary>
        public static decvec5 Cos(decimal v) => new decvec5((decimal)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Cosh ((decimal)Math.Cosh((double)v)).
        /// </summary>
        public static decvec5 Cosh(decvec5 v) => new decvec5((decimal)Math.Cosh((double)v.x), (decimal)Math.Cosh((double)v.y), (decimal)Math.Cosh((double)v.z), (decimal)Math.Cosh((double)v.w), (decimal)Math.Cosh((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Cosh ((decimal)Math.Cosh((double)v)).
        /// </summary>
        public static decvec5 Cosh(decimal v) => new decvec5((decimal)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Exp ((decimal)Math.Exp((double)v)).
        /// </summary>
        public static decvec5 Exp(decvec5 v) => new decvec5((decimal)Math.Exp((double)v.x), (decimal)Math.Exp((double)v.y), (decimal)Math.Exp((double)v.z), (decimal)Math.Exp((double)v.w), (decimal)Math.Exp((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Exp ((decimal)Math.Exp((double)v)).
        /// </summary>
        public static decvec5 Exp(decimal v) => new decvec5((decimal)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Log ((decimal)Math.Log((double)v)).
        /// </summary>
        public static decvec5 Log(decvec5 v) => new decvec5((decimal)Math.Log((double)v.x), (decimal)Math.Log((double)v.y), (decimal)Math.Log((double)v.z), (decimal)Math.Log((double)v.w), (decimal)Math.Log((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Log ((decimal)Math.Log((double)v)).
        /// </summary>
        public static decvec5 Log(decimal v) => new decvec5((decimal)Math.Log((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Log2 ((decimal)Math.Log((double)v, 2)).
        /// </summary>
        public static decvec5 Log2(decvec5 v) => new decvec5((decimal)Math.Log((double)v.x, 2), (decimal)Math.Log((double)v.y, 2), (decimal)Math.Log((double)v.z, 2), (decimal)Math.Log((double)v.w, 2), (decimal)Math.Log((double)v.v, 2));
        
        /// <summary>
        /// Returns a decvec from the application of Log2 ((decimal)Math.Log((double)v, 2)).
        /// </summary>
        public static decvec5 Log2(decimal v) => new decvec5((decimal)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Log10 ((decimal)Math.Log10((double)v)).
        /// </summary>
        public static decvec5 Log10(decvec5 v) => new decvec5((decimal)Math.Log10((double)v.x), (decimal)Math.Log10((double)v.y), (decimal)Math.Log10((double)v.z), (decimal)Math.Log10((double)v.w), (decimal)Math.Log10((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Log10 ((decimal)Math.Log10((double)v)).
        /// </summary>
        public static decvec5 Log10(decimal v) => new decvec5((decimal)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Floor ((decimal)Math.Floor(v)).
        /// </summary>
        public static decvec5 Floor(decvec5 v) => new decvec5((decimal)Math.Floor(v.x), (decimal)Math.Floor(v.y), (decimal)Math.Floor(v.z), (decimal)Math.Floor(v.w), (decimal)Math.Floor(v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Floor ((decimal)Math.Floor(v)).
        /// </summary>
        public static decvec5 Floor(decimal v) => new decvec5((decimal)Math.Floor(v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Ceiling ((decimal)Math.Ceiling(v)).
        /// </summary>
        public static decvec5 Ceiling(decvec5 v) => new decvec5((decimal)Math.Ceiling(v.x), (decimal)Math.Ceiling(v.y), (decimal)Math.Ceiling(v.z), (decimal)Math.Ceiling(v.w), (decimal)Math.Ceiling(v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Ceiling ((decimal)Math.Ceiling(v)).
        /// </summary>
        public static decvec5 Ceiling(decimal v) => new decvec5((decimal)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Round ((decimal)Math.Round(v)).
        /// </summary>
        public static decvec5 Round(decvec5 v) => new decvec5((decimal)Math.Round(v.x), (decimal)Math.Round(v.y), (decimal)Math.Round(v.z), (decimal)Math.Round(v.w), (decimal)Math.Round(v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Round ((decimal)Math.Round(v)).
        /// </summary>
        public static decvec5 Round(decimal v) => new decvec5((decimal)Math.Round(v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sin ((decimal)Math.Sin((double)v)).
        /// </summary>
        public static decvec5 Sin(decvec5 v) => new decvec5((decimal)Math.Sin((double)v.x), (decimal)Math.Sin((double)v.y), (decimal)Math.Sin((double)v.z), (decimal)Math.Sin((double)v.w), (decimal)Math.Sin((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Sin ((decimal)Math.Sin((double)v)).
        /// </summary>
        public static decvec5 Sin(decimal v) => new decvec5((decimal)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Sinh ((decimal)Math.Sinh((double)v)).
        /// </summary>
        public static decvec5 Sinh(decvec5 v) => new decvec5((decimal)Math.Sinh((double)v.x), (decimal)Math.Sinh((double)v.y), (decimal)Math.Sinh((double)v.z), (decimal)Math.Sinh((double)v.w), (decimal)Math.Sinh((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Sinh ((decimal)Math.Sinh((double)v)).
        /// </summary>
        public static decvec5 Sinh(decimal v) => new decvec5((decimal)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Tan ((decimal)Math.Tan((double)v)).
        /// </summary>
        public static decvec5 Tan(decvec5 v) => new decvec5((decimal)Math.Tan((double)v.x), (decimal)Math.Tan((double)v.y), (decimal)Math.Tan((double)v.z), (decimal)Math.Tan((double)v.w), (decimal)Math.Tan((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Tan ((decimal)Math.Tan((double)v)).
        /// </summary>
        public static decvec5 Tan(decimal v) => new decvec5((decimal)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Tanh ((decimal)Math.Tanh((double)v)).
        /// </summary>
        public static decvec5 Tanh(decvec5 v) => new decvec5((decimal)Math.Tanh((double)v.x), (decimal)Math.Tanh((double)v.y), (decimal)Math.Tanh((double)v.z), (decimal)Math.Tanh((double)v.w), (decimal)Math.Tanh((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Tanh ((decimal)Math.Tanh((double)v)).
        /// </summary>
        public static decvec5 Tanh(decimal v) => new decvec5((decimal)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Truncate ((decimal)Math.Truncate((double)v)).
        /// </summary>
        public static decvec5 Truncate(decvec5 v) => new decvec5((decimal)Math.Truncate((double)v.x), (decimal)Math.Truncate((double)v.y), (decimal)Math.Truncate((double)v.z), (decimal)Math.Truncate((double)v.w), (decimal)Math.Truncate((double)v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Truncate ((decimal)Math.Truncate((double)v)).
        /// </summary>
        public static decvec5 Truncate(decimal v) => new decvec5((decimal)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Fract ((decimal)(v - Math.Floor(v))).
        /// </summary>
        public static decvec5 Fract(decvec5 v) => new decvec5((decimal)(v.x - Math.Floor(v.x)), (decimal)(v.y - Math.Floor(v.y)), (decimal)(v.z - Math.Floor(v.z)), (decimal)(v.w - Math.Floor(v.w)), (decimal)(v.v - Math.Floor(v.v)));
        
        /// <summary>
        /// Returns a decvec from the application of Fract ((decimal)(v - Math.Floor(v))).
        /// </summary>
        public static decvec5 Fract(decimal v) => new decvec5((decimal)(v - Math.Floor(v)));
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static decvec5 Trunc(decvec5 v) => new decvec5((long)(v.x), (long)(v.y), (long)(v.z), (long)(v.w), (long)(v.v));
        
        /// <summary>
        /// Returns a decvec from the application of Trunc ((long)(v)).
        /// </summary>
        public static decvec5 Trunc(decimal v) => new decvec5((long)(v));
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec5 Random(Random random, decvec5 minValue, decvec5 maxValue) => new decvec5((decimal)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (decimal)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (decimal)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w, (decimal)random.NextDouble() * (maxValue.v - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec5 Random(Random random, decvec5 minValue, decimal maxValue) => new decvec5((decimal)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (decimal)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (decimal)random.NextDouble() * (maxValue - minValue.w) + minValue.w, (decimal)random.NextDouble() * (maxValue - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec5 Random(Random random, decimal minValue, decvec5 maxValue) => new decvec5((decimal)random.NextDouble() * (maxValue.x - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.y - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.z - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.w - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.v - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec5 Random(Random random, decimal minValue, decimal maxValue) => new decvec5((decimal)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec5 RandomUniform(Random random, decvec5 minValue, decvec5 maxValue) => new decvec5((decimal)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (decimal)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (decimal)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w, (decimal)random.NextDouble() * (maxValue.v - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec5 RandomUniform(Random random, decvec5 minValue, decimal maxValue) => new decvec5((decimal)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (decimal)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (decimal)random.NextDouble() * (maxValue - minValue.w) + minValue.w, (decimal)random.NextDouble() * (maxValue - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec5 RandomUniform(Random random, decimal minValue, decvec5 maxValue) => new decvec5((decimal)random.NextDouble() * (maxValue.x - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.y - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.z - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.w - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.v - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec5 RandomUniform(Random random, decimal minValue, decimal maxValue) => new decvec5((decimal)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec5 RandomNormal(Random random, decvec5 mean, decvec5 variance) => new decvec5((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (decimal)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (decimal)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (decimal)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec5 RandomNormal(Random random, decvec5 mean, decimal variance) => new decvec5((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec5 RandomNormal(Random random, decimal mean, decvec5 variance) => new decvec5((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec5 RandomNormal(Random random, decimal mean, decimal variance) => new decvec5((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec5 RandomGaussian(Random random, decvec5 mean, decvec5 variance) => new decvec5((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (decimal)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (decimal)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (decimal)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec5 RandomGaussian(Random random, decvec5 mean, decimal variance) => new decvec5((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec5 RandomGaussian(Random random, decimal mean, decvec5 variance) => new decvec5((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a decvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec5 RandomGaussian(Random random, decimal mean, decimal variance) => new decvec5((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(decvec5 lhs, decvec5 rhs) => new bvec5(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w, lhs.v < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(decvec5 lhs, decimal rhs) => new bvec5(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs, lhs.v < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(decimal lhs, decvec5 rhs) => new bvec5(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w, lhs < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(decvec5 lhs, decvec5 rhs) => new bvec5(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w, lhs.v <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(decvec5 lhs, decimal rhs) => new bvec5(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs, lhs.v <= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(decimal lhs, decvec5 rhs) => new bvec5(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w, lhs <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(decvec5 lhs, decvec5 rhs) => new bvec5(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w, lhs.v > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(decvec5 lhs, decimal rhs) => new bvec5(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs, lhs.v > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(decimal lhs, decvec5 rhs) => new bvec5(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w, lhs > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(decvec5 lhs, decvec5 rhs) => new bvec5(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w, lhs.v >= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(decvec5 lhs, decimal rhs) => new bvec5(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs, lhs.v >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(decimal lhs, decvec5 rhs) => new bvec5(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w, lhs >= rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decvec5 operator+(decvec5 lhs, decvec5 rhs) => new decvec5(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w, lhs.v + rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decvec5 operator+(decvec5 lhs, decimal rhs) => new decvec5(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs, lhs.v + rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decvec5 operator+(decimal lhs, decvec5 rhs) => new decvec5(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w, lhs + rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decvec5 operator-(decvec5 lhs, decvec5 rhs) => new decvec5(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w, lhs.v - rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decvec5 operator-(decvec5 lhs, decimal rhs) => new decvec5(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs, lhs.v - rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decvec5 operator-(decimal lhs, decvec5 rhs) => new decvec5(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w, lhs - rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static decvec5 operator*(decvec5 lhs, decvec5 rhs) => new decvec5(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w, lhs.v * rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static decvec5 operator*(decvec5 lhs, decimal rhs) => new decvec5(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs, lhs.v * rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static decvec5 operator*(decimal lhs, decvec5 rhs) => new decvec5(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w, lhs * rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static decvec5 operator/(decvec5 lhs, decvec5 rhs) => new decvec5(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w, lhs.v / rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static decvec5 operator/(decvec5 lhs, decimal rhs) => new decvec5(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs, lhs.v / rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static decvec5 operator/(decimal lhs, decvec5 rhs) => new decvec5(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w, lhs / rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator+ (identity).
        /// </summary>
        public static decvec5 operator+(decvec5 v) => v;
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator- (-v).
        /// </summary>
        public static decvec5 operator-(decvec5 v) => new decvec5(-v.x, -v.y, -v.z, -v.w, -v.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static decvec5 operator%(decvec5 lhs, decvec5 rhs) => new decvec5(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w, lhs.v % rhs.v);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static decvec5 operator%(decvec5 lhs, decimal rhs) => new decvec5(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs, lhs.v % rhs);
        
        /// <summary>
        /// Returns a decvec5 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static decvec5 operator%(decimal lhs, decvec5 rhs) => new decvec5(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w, lhs % rhs.v);

        #endregion

    }
}
