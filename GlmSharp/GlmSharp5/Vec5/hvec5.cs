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
    /// A vector of type Half with 5 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct hvec5 : IReadOnlyList<Half>, IEquatable<hvec5>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public Half x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public Half y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public Half z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public Half w;
        
        /// <summary>
        /// v-component
        /// </summary>
        [DataMember]
        public Half v;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public hvec5(Half x, Half y, Half z, Half w, Half v)
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
        public hvec5(Half v)
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
        public hvec5(hvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = Half.Zero;
            this.w = Half.Zero;
            this.v = Half.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public hvec5(hvec2 ve, Half z)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = Half.Zero;
            this.v = Half.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public hvec5(hvec2 ve, Half z, Half w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = w;
            this.v = Half.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public hvec5(hvec2 ve, Half z, Half w, Half v)
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
        public hvec5(hvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = Half.Zero;
            this.v = Half.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public hvec5(hvec3 ve, Half w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = ve.z;
            this.w = w;
            this.v = Half.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public hvec5(hvec3 ve, Half w, Half v)
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
        public hvec5(hvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
            this.v = Half.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public hvec5(hvec4 ve, Half v)
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
        public hvec5(hvec5 v)
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
        public hvec5(IReadOnlyList<Half> v)
        {
            var c = v.Count;
            this.x = c < 0 ? Half.Zero : v[0];
            this.y = c < 1 ? Half.Zero : v[1];
            this.z = c < 2 ? Half.Zero : v[2];
            this.w = c < 3 ? Half.Zero : v[3];
            this.v = c < 4 ? Half.Zero : v[4];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public hvec5(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? Half.Zero : (Half)v[0];
            this.y = c < 1 ? Half.Zero : (Half)v[1];
            this.z = c < 2 ? Half.Zero : (Half)v[2];
            this.w = c < 3 ? Half.Zero : (Half)v[3];
            this.v = c < 4 ? Half.Zero : (Half)v[4];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public hvec5(Half[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? Half.Zero : v[0];
            this.y = c < 1 ? Half.Zero : v[1];
            this.z = c < 2 ? Half.Zero : v[2];
            this.w = c < 3 ? Half.Zero : v[3];
            this.v = c < 4 ? Half.Zero : v[4];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public hvec5(Half[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? Half.Zero : v[0 + startIndex];
            this.y = c + startIndex < 1 ? Half.Zero : v[1 + startIndex];
            this.z = c + startIndex < 2 ? Half.Zero : v[2 + startIndex];
            this.w = c + startIndex < 3 ? Half.Zero : v[3 + startIndex];
            this.v = c + startIndex < 4 ? Half.Zero : v[4 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public hvec5(IEnumerable<Half> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a vec5.
        /// </summary>
        public static implicit operator vec5(hvec5 v) => new vec5((float)v.x, (float)v.y, (float)v.z, (float)v.w, (float)v.v);
        
        /// <summary>
        /// Implicitly converts this to a dvec5.
        /// </summary>
        public static implicit operator dvec5(hvec5 v) => new dvec5((double)v.x, (double)v.y, (double)v.z, (double)v.w, (double)v.v);
        
        /// <summary>
        /// Implicitly converts this to a cvec5.
        /// </summary>
        public static implicit operator cvec5(hvec5 v) => new cvec5((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w, (Complex)v.v);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(hvec5 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(hvec5 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(hvec5 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a ivec5.
        /// </summary>
        public static explicit operator ivec5(hvec5 v) => new ivec5((int)v.x, (int)v.y, (int)v.z, (int)v.w, (int)v.v);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(hvec5 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(hvec5 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(hvec5 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec5.
        /// </summary>
        public static explicit operator uvec5(hvec5 v) => new uvec5((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w, (uint)v.v);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(hvec5 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(hvec5 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(hvec5 v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(hvec5 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(hvec5 v) => new hvec3((Half)v.x, (Half)v.y, (Half)v.z);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(hvec5 v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(hvec5 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(hvec5 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(hvec5 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(hvec5 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(hvec5 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(hvec5 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a decvec5.
        /// </summary>
        public static explicit operator decvec5(hvec5 v) => new decvec5((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w, (decimal)v.v);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(hvec5 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(hvec5 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(hvec5 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(hvec5 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(hvec5 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(hvec5 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lvec5.
        /// </summary>
        public static explicit operator lvec5(hvec5 v) => new lvec5((long)v.x, (long)v.y, (long)v.z, (long)v.w, (long)v.v);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(hvec5 v) => new bvec2(v.x != Half.Zero, v.y != Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(hvec5 v) => new bvec3(v.x != Half.Zero, v.y != Half.Zero, v.z != Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(hvec5 v) => new bvec4(v.x != Half.Zero, v.y != Half.Zero, v.z != Half.Zero, v.w != Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a bvec5.
        /// </summary>
        public static explicit operator bvec5(hvec5 v) => new bvec5(v.x != Half.Zero, v.y != Half.Zero, v.z != Half.Zero, v.w != Half.Zero, v.v != Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a Half array.
        /// </summary>
        public static explicit operator Half[](hvec5 v) => new [] { v.x, v.y, v.z, v.w, v.v };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](hvec5 v) => new Object[] { v.x, v.y, v.z, v.w, v.v };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public Half this[int index]
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
        public swizzle_hvec5 swizzle => new swizzle_hvec5(x, y, z, w, v);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public hvec2 xy
        {
            get
            {
                return new hvec2(x, y);
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
        public hvec2 xz
        {
            get
            {
                return new hvec2(x, z);
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
        public hvec2 yz
        {
            get
            {
                return new hvec2(y, z);
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
        public hvec3 xyz
        {
            get
            {
                return new hvec3(x, y, z);
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
        public hvec2 xw
        {
            get
            {
                return new hvec2(x, w);
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
        public hvec2 yw
        {
            get
            {
                return new hvec2(y, w);
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
        public hvec3 xyw
        {
            get
            {
                return new hvec3(x, y, w);
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
        public hvec2 zw
        {
            get
            {
                return new hvec2(z, w);
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
        public hvec3 xzw
        {
            get
            {
                return new hvec3(x, z, w);
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
        public hvec3 yzw
        {
            get
            {
                return new hvec3(y, z, w);
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
        public hvec4 xyzw
        {
            get
            {
                return new hvec4(x, y, z, w);
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
        public hvec2 xv
        {
            get
            {
                return new hvec2(x, v);
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
        public hvec2 yv
        {
            get
            {
                return new hvec2(y, v);
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
        public hvec3 xyv
        {
            get
            {
                return new hvec3(x, y, v);
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
        public hvec2 zv
        {
            get
            {
                return new hvec2(z, v);
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
        public hvec3 xzv
        {
            get
            {
                return new hvec3(x, z, v);
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
        public hvec3 yzv
        {
            get
            {
                return new hvec3(y, z, v);
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
        public hvec4 xyzv
        {
            get
            {
                return new hvec4(x, y, z, v);
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
        public hvec2 wv
        {
            get
            {
                return new hvec2(w, v);
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
        public hvec3 xwv
        {
            get
            {
                return new hvec3(x, w, v);
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
        public hvec3 ywv
        {
            get
            {
                return new hvec3(y, w, v);
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
        public hvec4 xywv
        {
            get
            {
                return new hvec4(x, y, w, v);
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
        public hvec3 zwv
        {
            get
            {
                return new hvec3(z, w, v);
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
        public hvec4 xzwv
        {
            get
            {
                return new hvec4(x, z, w, v);
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
        public hvec4 yzwv
        {
            get
            {
                return new hvec4(y, z, w, v);
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
        public hvec5 xyzwv
        {
            get
            {
                return new hvec5(x, y, z, w, v);
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
        public hvec2 rg
        {
            get
            {
                return new hvec2(x, y);
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
        public hvec2 rb
        {
            get
            {
                return new hvec2(x, z);
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
        public hvec2 gb
        {
            get
            {
                return new hvec2(y, z);
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
        public hvec3 rgb
        {
            get
            {
                return new hvec3(x, y, z);
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
        public hvec2 ra
        {
            get
            {
                return new hvec2(x, w);
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
        public hvec2 ga
        {
            get
            {
                return new hvec2(y, w);
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
        public hvec3 rga
        {
            get
            {
                return new hvec3(x, y, w);
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
        public hvec2 ba
        {
            get
            {
                return new hvec2(z, w);
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
        public hvec3 rba
        {
            get
            {
                return new hvec3(x, z, w);
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
        public hvec3 gba
        {
            get
            {
                return new hvec3(y, z, w);
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
        public hvec4 rgba
        {
            get
            {
                return new hvec4(x, y, z, w);
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
        public hvec2 rk
        {
            get
            {
                return new hvec2(x, v);
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
        public hvec2 gk
        {
            get
            {
                return new hvec2(y, v);
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
        public hvec3 rgk
        {
            get
            {
                return new hvec3(x, y, v);
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
        public hvec2 bk
        {
            get
            {
                return new hvec2(z, v);
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
        public hvec3 rbk
        {
            get
            {
                return new hvec3(x, z, v);
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
        public hvec3 gbk
        {
            get
            {
                return new hvec3(y, z, v);
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
        public hvec4 rgbk
        {
            get
            {
                return new hvec4(x, y, z, v);
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
        public hvec2 ak
        {
            get
            {
                return new hvec2(w, v);
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
        public hvec3 rak
        {
            get
            {
                return new hvec3(x, w, v);
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
        public hvec3 gak
        {
            get
            {
                return new hvec3(y, w, v);
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
        public hvec4 rgak
        {
            get
            {
                return new hvec4(x, y, w, v);
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
        public hvec3 bak
        {
            get
            {
                return new hvec3(z, w, v);
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
        public hvec4 rbak
        {
            get
            {
                return new hvec4(x, z, w, v);
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
        public hvec4 gbak
        {
            get
            {
                return new hvec4(y, z, w, v);
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
        public hvec5 rgbak
        {
            get
            {
                return new hvec5(x, y, z, w, v);
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
        public Half r
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
        public Half g
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
        public Half b
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
        public Half a
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
        public Half k
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
        public Half[] Values => new[] { x, y, z, w, v };
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public int Count => 5;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public Half MinElement => Half.Min(Half.Min(Half.Min(x, y), z), Half.Min(w, v));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public Half MaxElement => Half.Max(Half.Max(Half.Max(x, y), z), Half.Max(w, v));
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public float Length => (float)Math.Sqrt((((x*x + y*y) + z*z) + (w*w + v*v)));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public float LengthSqr => (((x*x + y*y) + z*z) + (w*w + v*v));
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public Half Sum => (((x + y) + z) + (w + v));
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)Math.Sqrt((((x*x + y*y) + z*z) + (w*w + v*v)));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => (((Half.Abs(x) + Half.Abs(y)) + Half.Abs(z)) + (Half.Abs(w) + Half.Abs(v)));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt((((x*x + y*y) + z*z) + (w*w + v*v)));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => Half.Max(Half.Max(Half.Max(Half.Abs(x), Half.Abs(y)), Half.Abs(z)), Half.Max(Half.Abs(w), Half.Abs(v)));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public hvec5 Normalized => this / (Half)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public hvec5 NormalizedSafe => this == Zero ? Zero : this / (Half)Length;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static hvec5 Zero { get; } = new hvec5(Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static hvec5 Ones { get; } = new hvec5(Half.One, Half.One, Half.One, Half.One, Half.One);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static hvec5 UnitX { get; } = new hvec5(Half.One, Half.Zero, Half.Zero, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static hvec5 UnitY { get; } = new hvec5(Half.Zero, Half.One, Half.Zero, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static hvec5 UnitZ { get; } = new hvec5(Half.Zero, Half.Zero, Half.One, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static hvec5 UnitW { get; } = new hvec5(Half.Zero, Half.Zero, Half.Zero, Half.One, Half.Zero);
        
        /// <summary>
        /// Predefined unit-V vector
        /// </summary>
        public static hvec5 UnitV { get; } = new hvec5(Half.Zero, Half.Zero, Half.Zero, Half.Zero, Half.One);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static hvec5 MaxValue { get; } = new hvec5(Half.MaxValue, Half.MaxValue, Half.MaxValue, Half.MaxValue, Half.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static hvec5 MinValue { get; } = new hvec5(Half.MinValue, Half.MinValue, Half.MinValue, Half.MinValue, Half.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static hvec5 Epsilon { get; } = new hvec5(Half.Epsilon, Half.Epsilon, Half.Epsilon, Half.Epsilon, Half.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static hvec5 NaN { get; } = new hvec5(Half.NaN, Half.NaN, Half.NaN, Half.NaN, Half.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static hvec5 NegativeInfinity { get; } = new hvec5(Half.NegativeInfinity, Half.NegativeInfinity, Half.NegativeInfinity, Half.NegativeInfinity, Half.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static hvec5 PositiveInfinity { get; } = new hvec5(Half.PositiveInfinity, Half.PositiveInfinity, Half.PositiveInfinity, Half.PositiveInfinity, Half.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(hvec5 lhs, hvec5 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(hvec5 lhs, hvec5 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<Half> GetEnumerator()
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
        public bool Equals(hvec5 rhs) => (((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z)) && (w.Equals(rhs.w) && v.Equals(rhs.v)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is hvec5 && Equals((hvec5) obj);
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
        public double NormP(double p) => Math.Pow((((Math.Pow((double)Half.Abs(x), p) + Math.Pow((double)Half.Abs(y), p)) + Math.Pow((double)Half.Abs(z), p)) + (Math.Pow((double)Half.Abs(w), p) + Math.Pow((double)Half.Abs(v), p))), 1 / p);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static hvec5 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static hvec5 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new hvec5(Half.Parse(kvp[0].Trim()), Half.Parse(kvp[1].Trim()), Half.Parse(kvp[2].Trim()), Half.Parse(kvp[3].Trim()), Half.Parse(kvp[4].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static hvec5 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new hvec5(Half.Parse(kvp[0].Trim(), provider), Half.Parse(kvp[1].Trim(), provider), Half.Parse(kvp[2].Trim(), provider), Half.Parse(kvp[3].Trim(), provider), Half.Parse(kvp[4].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static hvec5 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new hvec5(Half.Parse(kvp[0].Trim(), style), Half.Parse(kvp[1].Trim(), style), Half.Parse(kvp[2].Trim(), style), Half.Parse(kvp[3].Trim(), style), Half.Parse(kvp[4].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static hvec5 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new hvec5(Half.Parse(kvp[0].Trim(), style, provider), Half.Parse(kvp[1].Trim(), style, provider), Half.Parse(kvp[2].Trim(), style, provider), Half.Parse(kvp[3].Trim(), style, provider), Half.Parse(kvp[4].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out hvec5 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out hvec5 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) return false;
            Half x = Half.Zero, y = Half.Zero, z = Half.Zero, w = Half.Zero, v = Half.Zero;
            var ok = (((Half.TryParse(kvp[0].Trim(), out x) && Half.TryParse(kvp[1].Trim(), out y)) && Half.TryParse(kvp[2].Trim(), out z)) && (Half.TryParse(kvp[3].Trim(), out w) && Half.TryParse(kvp[4].Trim(), out v)));
            result = ok ? new hvec5(x, y, z, w, v) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out hvec5 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) return false;
            Half x = Half.Zero, y = Half.Zero, z = Half.Zero, w = Half.Zero, v = Half.Zero;
            var ok = (((Half.TryParse(kvp[0].Trim(), style, provider, out x) && Half.TryParse(kvp[1].Trim(), style, provider, out y)) && Half.TryParse(kvp[2].Trim(), style, provider, out z)) && (Half.TryParse(kvp[3].Trim(), style, provider, out w) && Half.TryParse(kvp[4].Trim(), style, provider, out v)));
            result = ok ? new hvec5(x, y, z, w, v) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(hvec5 lhs, hvec5 rhs, float eps = 0.1f) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat5x2 OuterProduct(hvec2 c, hvec5 r) => new hmat5x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w, c.x * r.v, c.y * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat2x5 OuterProduct(hvec5 c, hvec2 r) => new hmat2x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat5x3 OuterProduct(hvec3 c, hvec5 r) => new hmat5x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.x * r.v, c.y * r.v, c.z * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat3x5 OuterProduct(hvec5 c, hvec3 r) => new hmat3x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat5x4 OuterProduct(hvec4 c, hvec5 r) => new hmat5x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.x * r.v, c.y * r.v, c.z * r.v, c.w * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat4x5 OuterProduct(hvec5 c, hvec4 r) => new hmat4x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.v * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat5 OuterProduct(hvec5 c, hvec5 r) => new hmat5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.v * r.w, c.x * r.v, c.y * r.v, c.z * r.v, c.w * r.v, c.v * r.v);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static Half Dot(hvec5 lhs, hvec5 rhs) => (((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z) + (lhs.w * rhs.w + lhs.v * rhs.v));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(hvec5 lhs, hvec5 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(hvec5 lhs, hvec5 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static hvec5 Reflect(hvec5 I, hvec5 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static hvec5 Refract(hvec5 I, hvec5 N, Half eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (Half)Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static hvec5 FaceForward(hvec5 N, hvec5 I, hvec5 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static hvec5 Random(Random random) => new hvec5((Half)random.NextDouble(), (Half)random.NextDouble(), (Half)random.NextDouble(), (Half)random.NextDouble(), (Half)random.NextDouble());
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static hvec5 RandomSigned(Random random) => new hvec5((Half)(random.NextDouble() * 2.0 - 1.0), (Half)(random.NextDouble() * 2.0 - 1.0), (Half)(random.NextDouble() * 2.0 - 1.0), (Half)(random.NextDouble() * 2.0 - 1.0), (Half)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static hvec5 RandomNormal(Random random) => new hvec5((Half)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (Half)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (Half)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (Half)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (Half)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(hvec5 lhs, hvec5 rhs) => new bvec5(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w, lhs.v == rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(hvec5 lhs, Half rhs) => new bvec5(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs, lhs.v == rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(Half lhs, hvec5 rhs) => new bvec5(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w, lhs == rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(Half lhs, Half rhs) => new bvec5(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(hvec5 lhs, hvec5 rhs) => new bvec5(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w, lhs.v != rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(hvec5 lhs, Half rhs) => new bvec5(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs, lhs.v != rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(Half lhs, hvec5 rhs) => new bvec5(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w, lhs != rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(Half lhs, Half rhs) => new bvec5(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(hvec5 lhs, hvec5 rhs) => new bvec5(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w, lhs.v > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(hvec5 lhs, Half rhs) => new bvec5(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs, lhs.v > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(Half lhs, hvec5 rhs) => new bvec5(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w, lhs > rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(Half lhs, Half rhs) => new bvec5(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(hvec5 lhs, hvec5 rhs) => new bvec5(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w, lhs.v >= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(hvec5 lhs, Half rhs) => new bvec5(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs, lhs.v >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(Half lhs, hvec5 rhs) => new bvec5(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w, lhs >= rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(Half lhs, Half rhs) => new bvec5(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(hvec5 lhs, hvec5 rhs) => new bvec5(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w, lhs.v < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(hvec5 lhs, Half rhs) => new bvec5(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs, lhs.v < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(Half lhs, hvec5 rhs) => new bvec5(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w, lhs < rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(Half lhs, Half rhs) => new bvec5(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(hvec5 lhs, hvec5 rhs) => new bvec5(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w, lhs.v <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(hvec5 lhs, Half rhs) => new bvec5(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs, lhs.v <= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(Half lhs, hvec5 rhs) => new bvec5(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w, lhs <= rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(Half lhs, Half rhs) => new bvec5(lhs <= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsInfinity (Half.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsInfinity(hvec5 v) => new bvec5(Half.IsInfinity(v.x), Half.IsInfinity(v.y), Half.IsInfinity(v.z), Half.IsInfinity(v.w), Half.IsInfinity(v.v));
        
        /// <summary>
        /// Returns a bvec from the application of IsInfinity (Half.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsInfinity(Half v) => new bvec5(Half.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsFinite (!Half.IsNaN(v) &amp;&amp; !Half.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsFinite(hvec5 v) => new bvec5(!Half.IsNaN(v.x) && !Half.IsInfinity(v.x), !Half.IsNaN(v.y) && !Half.IsInfinity(v.y), !Half.IsNaN(v.z) && !Half.IsInfinity(v.z), !Half.IsNaN(v.w) && !Half.IsInfinity(v.w), !Half.IsNaN(v.v) && !Half.IsInfinity(v.v));
        
        /// <summary>
        /// Returns a bvec from the application of IsFinite (!Half.IsNaN(v) &amp;&amp; !Half.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsFinite(Half v) => new bvec5(!Half.IsNaN(v) && !Half.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsNaN (Half.IsNaN(v)).
        /// </summary>
        public static bvec5 IsNaN(hvec5 v) => new bvec5(Half.IsNaN(v.x), Half.IsNaN(v.y), Half.IsNaN(v.z), Half.IsNaN(v.w), Half.IsNaN(v.v));
        
        /// <summary>
        /// Returns a bvec from the application of IsNaN (Half.IsNaN(v)).
        /// </summary>
        public static bvec5 IsNaN(Half v) => new bvec5(Half.IsNaN(v));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsNegativeInfinity (Half.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec5 IsNegativeInfinity(hvec5 v) => new bvec5(Half.IsNegativeInfinity(v.x), Half.IsNegativeInfinity(v.y), Half.IsNegativeInfinity(v.z), Half.IsNegativeInfinity(v.w), Half.IsNegativeInfinity(v.v));
        
        /// <summary>
        /// Returns a bvec from the application of IsNegativeInfinity (Half.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec5 IsNegativeInfinity(Half v) => new bvec5(Half.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsPositiveInfinity (Half.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec5 IsPositiveInfinity(hvec5 v) => new bvec5(Half.IsPositiveInfinity(v.x), Half.IsPositiveInfinity(v.y), Half.IsPositiveInfinity(v.z), Half.IsPositiveInfinity(v.w), Half.IsPositiveInfinity(v.v));
        
        /// <summary>
        /// Returns a bvec from the application of IsPositiveInfinity (Half.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec5 IsPositiveInfinity(Half v) => new bvec5(Half.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Abs (Half.Abs(v)).
        /// </summary>
        public static hvec5 Abs(hvec5 v) => new hvec5(Half.Abs(v.x), Half.Abs(v.y), Half.Abs(v.z), Half.Abs(v.w), Half.Abs(v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Abs (Half.Abs(v)).
        /// </summary>
        public static hvec5 Abs(Half v) => new hvec5(Half.Abs(v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static hvec5 HermiteInterpolationOrder3(hvec5 v) => new hvec5((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w, (3 - 2 * v.v) * v.v * v.v);
        
        /// <summary>
        /// Returns a hvec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static hvec5 HermiteInterpolationOrder3(Half v) => new hvec5((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static hvec5 HermiteInterpolationOrder5(hvec5 v) => new hvec5(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w, ((6 * v.v - 15) * v.v + 10) * v.v * v.v * v.v);
        
        /// <summary>
        /// Returns a hvec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static hvec5 HermiteInterpolationOrder5(Half v) => new hvec5(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static hvec5 Sqr(hvec5 v) => new hvec5(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w, v.v * v.v);
        
        /// <summary>
        /// Returns a hvec from the application of Sqr (v * v).
        /// </summary>
        public static hvec5 Sqr(Half v) => new hvec5(v * v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static hvec5 Pow2(hvec5 v) => new hvec5(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w, v.v * v.v);
        
        /// <summary>
        /// Returns a hvec from the application of Pow2 (v * v).
        /// </summary>
        public static hvec5 Pow2(Half v) => new hvec5(v * v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static hvec5 Pow3(hvec5 v) => new hvec5(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w, v.v * v.v * v.v);
        
        /// <summary>
        /// Returns a hvec from the application of Pow3 (v * v * v).
        /// </summary>
        public static hvec5 Pow3(Half v) => new hvec5(v * v * v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Step (v &gt;= Half.Zero ? Half.One : Half.Zero).
        /// </summary>
        public static hvec5 Step(hvec5 v) => new hvec5(v.x >= Half.Zero ? Half.One : Half.Zero, v.y >= Half.Zero ? Half.One : Half.Zero, v.z >= Half.Zero ? Half.One : Half.Zero, v.w >= Half.Zero ? Half.One : Half.Zero, v.v >= Half.Zero ? Half.One : Half.Zero);
        
        /// <summary>
        /// Returns a hvec from the application of Step (v &gt;= Half.Zero ? Half.One : Half.Zero).
        /// </summary>
        public static hvec5 Step(Half v) => new hvec5(v >= Half.Zero ? Half.One : Half.Zero);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Sqrt ((Half)Math.Sqrt((double)v)).
        /// </summary>
        public static hvec5 Sqrt(hvec5 v) => new hvec5((Half)Math.Sqrt((double)v.x), (Half)Math.Sqrt((double)v.y), (Half)Math.Sqrt((double)v.z), (Half)Math.Sqrt((double)v.w), (Half)Math.Sqrt((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Sqrt ((Half)Math.Sqrt((double)v)).
        /// </summary>
        public static hvec5 Sqrt(Half v) => new hvec5((Half)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of InverseSqrt ((Half)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static hvec5 InverseSqrt(hvec5 v) => new hvec5((Half)(1.0 / Math.Sqrt((double)v.x)), (Half)(1.0 / Math.Sqrt((double)v.y)), (Half)(1.0 / Math.Sqrt((double)v.z)), (Half)(1.0 / Math.Sqrt((double)v.w)), (Half)(1.0 / Math.Sqrt((double)v.v)));
        
        /// <summary>
        /// Returns a hvec from the application of InverseSqrt ((Half)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static hvec5 InverseSqrt(Half v) => new hvec5((Half)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(hvec5 v) => new ivec5(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z), Math.Sign(v.w), Math.Sign(v.v));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(Half v) => new ivec5(Math.Sign(v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Max (Half.Max(lhs, rhs)).
        /// </summary>
        public static hvec5 Max(hvec5 lhs, hvec5 rhs) => new hvec5(Half.Max(lhs.x, rhs.x), Half.Max(lhs.y, rhs.y), Half.Max(lhs.z, rhs.z), Half.Max(lhs.w, rhs.w), Half.Max(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Max (Half.Max(lhs, rhs)).
        /// </summary>
        public static hvec5 Max(hvec5 lhs, Half rhs) => new hvec5(Half.Max(lhs.x, rhs), Half.Max(lhs.y, rhs), Half.Max(lhs.z, rhs), Half.Max(lhs.w, rhs), Half.Max(lhs.v, rhs));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Max (Half.Max(lhs, rhs)).
        /// </summary>
        public static hvec5 Max(Half lhs, hvec5 rhs) => new hvec5(Half.Max(lhs, rhs.x), Half.Max(lhs, rhs.y), Half.Max(lhs, rhs.z), Half.Max(lhs, rhs.w), Half.Max(lhs, rhs.v));
        
        /// <summary>
        /// Returns a hvec from the application of Max (Half.Max(lhs, rhs)).
        /// </summary>
        public static hvec5 Max(Half lhs, Half rhs) => new hvec5(Half.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Min (Half.Min(lhs, rhs)).
        /// </summary>
        public static hvec5 Min(hvec5 lhs, hvec5 rhs) => new hvec5(Half.Min(lhs.x, rhs.x), Half.Min(lhs.y, rhs.y), Half.Min(lhs.z, rhs.z), Half.Min(lhs.w, rhs.w), Half.Min(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Min (Half.Min(lhs, rhs)).
        /// </summary>
        public static hvec5 Min(hvec5 lhs, Half rhs) => new hvec5(Half.Min(lhs.x, rhs), Half.Min(lhs.y, rhs), Half.Min(lhs.z, rhs), Half.Min(lhs.w, rhs), Half.Min(lhs.v, rhs));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Min (Half.Min(lhs, rhs)).
        /// </summary>
        public static hvec5 Min(Half lhs, hvec5 rhs) => new hvec5(Half.Min(lhs, rhs.x), Half.Min(lhs, rhs.y), Half.Min(lhs, rhs.z), Half.Min(lhs, rhs.w), Half.Min(lhs, rhs.v));
        
        /// <summary>
        /// Returns a hvec from the application of Min (Half.Min(lhs, rhs)).
        /// </summary>
        public static hvec5 Min(Half lhs, Half rhs) => new hvec5(Half.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Pow ((Half)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec5 Pow(hvec5 lhs, hvec5 rhs) => new hvec5((Half)Math.Pow((double)lhs.x, (double)rhs.x), (Half)Math.Pow((double)lhs.y, (double)rhs.y), (Half)Math.Pow((double)lhs.z, (double)rhs.z), (Half)Math.Pow((double)lhs.w, (double)rhs.w), (Half)Math.Pow((double)lhs.v, (double)rhs.v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Pow ((Half)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec5 Pow(hvec5 lhs, Half rhs) => new hvec5((Half)Math.Pow((double)lhs.x, (double)rhs), (Half)Math.Pow((double)lhs.y, (double)rhs), (Half)Math.Pow((double)lhs.z, (double)rhs), (Half)Math.Pow((double)lhs.w, (double)rhs), (Half)Math.Pow((double)lhs.v, (double)rhs));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Pow ((Half)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec5 Pow(Half lhs, hvec5 rhs) => new hvec5((Half)Math.Pow((double)lhs, (double)rhs.x), (Half)Math.Pow((double)lhs, (double)rhs.y), (Half)Math.Pow((double)lhs, (double)rhs.z), (Half)Math.Pow((double)lhs, (double)rhs.w), (Half)Math.Pow((double)lhs, (double)rhs.v));
        
        /// <summary>
        /// Returns a hvec from the application of Pow ((Half)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec5 Pow(Half lhs, Half rhs) => new hvec5((Half)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Log ((Half)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec5 Log(hvec5 lhs, hvec5 rhs) => new hvec5((Half)Math.Log((double)lhs.x, (double)rhs.x), (Half)Math.Log((double)lhs.y, (double)rhs.y), (Half)Math.Log((double)lhs.z, (double)rhs.z), (Half)Math.Log((double)lhs.w, (double)rhs.w), (Half)Math.Log((double)lhs.v, (double)rhs.v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Log ((Half)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec5 Log(hvec5 lhs, Half rhs) => new hvec5((Half)Math.Log((double)lhs.x, (double)rhs), (Half)Math.Log((double)lhs.y, (double)rhs), (Half)Math.Log((double)lhs.z, (double)rhs), (Half)Math.Log((double)lhs.w, (double)rhs), (Half)Math.Log((double)lhs.v, (double)rhs));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Log ((Half)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec5 Log(Half lhs, hvec5 rhs) => new hvec5((Half)Math.Log((double)lhs, (double)rhs.x), (Half)Math.Log((double)lhs, (double)rhs.y), (Half)Math.Log((double)lhs, (double)rhs.z), (Half)Math.Log((double)lhs, (double)rhs.w), (Half)Math.Log((double)lhs, (double)rhs.v));
        
        /// <summary>
        /// Returns a hvec from the application of Log ((Half)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec5 Log(Half lhs, Half rhs) => new hvec5((Half)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static hvec5 Clamp(hvec5 v, hvec5 min, hvec5 max) => new hvec5(Half.Min(Half.Max(v.x, min.x), max.x), Half.Min(Half.Max(v.y, min.y), max.y), Half.Min(Half.Max(v.z, min.z), max.z), Half.Min(Half.Max(v.w, min.w), max.w), Half.Min(Half.Max(v.v, min.v), max.v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static hvec5 Clamp(hvec5 v, hvec5 min, Half max) => new hvec5(Half.Min(Half.Max(v.x, min.x), max), Half.Min(Half.Max(v.y, min.y), max), Half.Min(Half.Max(v.z, min.z), max), Half.Min(Half.Max(v.w, min.w), max), Half.Min(Half.Max(v.v, min.v), max));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static hvec5 Clamp(hvec5 v, Half min, hvec5 max) => new hvec5(Half.Min(Half.Max(v.x, min), max.x), Half.Min(Half.Max(v.y, min), max.y), Half.Min(Half.Max(v.z, min), max.z), Half.Min(Half.Max(v.w, min), max.w), Half.Min(Half.Max(v.v, min), max.v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static hvec5 Clamp(hvec5 v, Half min, Half max) => new hvec5(Half.Min(Half.Max(v.x, min), max), Half.Min(Half.Max(v.y, min), max), Half.Min(Half.Max(v.z, min), max), Half.Min(Half.Max(v.w, min), max), Half.Min(Half.Max(v.v, min), max));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static hvec5 Clamp(Half v, hvec5 min, hvec5 max) => new hvec5(Half.Min(Half.Max(v, min.x), max.x), Half.Min(Half.Max(v, min.y), max.y), Half.Min(Half.Max(v, min.z), max.z), Half.Min(Half.Max(v, min.w), max.w), Half.Min(Half.Max(v, min.v), max.v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static hvec5 Clamp(Half v, hvec5 min, Half max) => new hvec5(Half.Min(Half.Max(v, min.x), max), Half.Min(Half.Max(v, min.y), max), Half.Min(Half.Max(v, min.z), max), Half.Min(Half.Max(v, min.w), max), Half.Min(Half.Max(v, min.v), max));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static hvec5 Clamp(Half v, Half min, hvec5 max) => new hvec5(Half.Min(Half.Max(v, min), max.x), Half.Min(Half.Max(v, min), max.y), Half.Min(Half.Max(v, min), max.z), Half.Min(Half.Max(v, min), max.w), Half.Min(Half.Max(v, min), max.v));
        
        /// <summary>
        /// Returns a hvec from the application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static hvec5 Clamp(Half v, Half min, Half max) => new hvec5(Half.Min(Half.Max(v, min), max));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Mix(hvec5 min, hvec5 max, hvec5 a) => new hvec5(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w, min.v * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Mix(hvec5 min, hvec5 max, Half a) => new hvec5(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a, min.v * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Mix(hvec5 min, Half max, hvec5 a) => new hvec5(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w, min.v * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Mix(hvec5 min, Half max, Half a) => new hvec5(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a, min.v * (1-a) + max * a);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Mix(Half min, hvec5 max, hvec5 a) => new hvec5(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w, min * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Mix(Half min, hvec5 max, Half a) => new hvec5(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a, min * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Mix(Half min, Half max, hvec5 a) => new hvec5(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w, min * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a hvec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Mix(Half min, Half max, Half a) => new hvec5(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Lerp(hvec5 min, hvec5 max, hvec5 a) => new hvec5(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w, min.v * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Lerp(hvec5 min, hvec5 max, Half a) => new hvec5(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a, min.v * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Lerp(hvec5 min, Half max, hvec5 a) => new hvec5(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w, min.v * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Lerp(hvec5 min, Half max, Half a) => new hvec5(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a, min.v * (1-a) + max * a);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Lerp(Half min, hvec5 max, hvec5 a) => new hvec5(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w, min * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Lerp(Half min, hvec5 max, Half a) => new hvec5(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a, min * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Lerp(Half min, Half max, hvec5 a) => new hvec5(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w, min * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a hvec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hvec5 Lerp(Half min, Half max, Half a) => new hvec5(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static hvec5 Smoothstep(hvec5 edge0, hvec5 edge1, hvec5 v) => new hvec5(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static hvec5 Smoothstep(hvec5 edge0, hvec5 edge1, Half v) => new hvec5(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static hvec5 Smoothstep(hvec5 edge0, Half edge1, hvec5 v) => new hvec5(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static hvec5 Smoothstep(hvec5 edge0, Half edge1, Half v) => new hvec5(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static hvec5 Smoothstep(Half edge0, hvec5 edge1, hvec5 v) => new hvec5(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static hvec5 Smoothstep(Half edge0, hvec5 edge1, Half v) => new hvec5(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static hvec5 Smoothstep(Half edge0, Half edge1, hvec5 v) => new hvec5(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a hvec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static hvec5 Smoothstep(Half edge0, Half edge1, Half v) => new hvec5(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static hvec5 Smootherstep(hvec5 edge0, hvec5 edge1, hvec5 v) => new hvec5(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static hvec5 Smootherstep(hvec5 edge0, hvec5 edge1, Half v) => new hvec5(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static hvec5 Smootherstep(hvec5 edge0, Half edge1, hvec5 v) => new hvec5(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static hvec5 Smootherstep(hvec5 edge0, Half edge1, Half v) => new hvec5(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static hvec5 Smootherstep(Half edge0, hvec5 edge1, hvec5 v) => new hvec5(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static hvec5 Smootherstep(Half edge0, hvec5 edge1, Half v) => new hvec5(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static hvec5 Smootherstep(Half edge0, Half edge1, hvec5 v) => new hvec5(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a hvec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static hvec5 Smootherstep(Half edge0, Half edge1, Half v) => new hvec5(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static hvec5 Fma(hvec5 a, hvec5 b, hvec5 c) => new hvec5(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w, a.v * b.v + c.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static hvec5 Fma(hvec5 a, hvec5 b, Half c) => new hvec5(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c, a.v * b.v + c);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static hvec5 Fma(hvec5 a, Half b, hvec5 c) => new hvec5(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w, a.v * b + c.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static hvec5 Fma(hvec5 a, Half b, Half c) => new hvec5(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c, a.v * b + c);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static hvec5 Fma(Half a, hvec5 b, hvec5 c) => new hvec5(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w, a * b.v + c.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static hvec5 Fma(Half a, hvec5 b, Half c) => new hvec5(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c, a * b.v + c);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static hvec5 Fma(Half a, Half b, hvec5 c) => new hvec5(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w, a * b + c.v);
        
        /// <summary>
        /// Returns a hvec from the application of Fma (a * b + c).
        /// </summary>
        public static hvec5 Fma(Half a, Half b, Half c) => new hvec5(a * b + c);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static hvec5 Add(hvec5 lhs, hvec5 rhs) => new hvec5(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w, lhs.v + rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static hvec5 Add(hvec5 lhs, Half rhs) => new hvec5(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs, lhs.v + rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static hvec5 Add(Half lhs, hvec5 rhs) => new hvec5(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w, lhs + rhs.v);
        
        /// <summary>
        /// Returns a hvec from the application of Add (lhs + rhs).
        /// </summary>
        public static hvec5 Add(Half lhs, Half rhs) => new hvec5(lhs + rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static hvec5 Sub(hvec5 lhs, hvec5 rhs) => new hvec5(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w, lhs.v - rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static hvec5 Sub(hvec5 lhs, Half rhs) => new hvec5(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs, lhs.v - rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static hvec5 Sub(Half lhs, hvec5 rhs) => new hvec5(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w, lhs - rhs.v);
        
        /// <summary>
        /// Returns a hvec from the application of Sub (lhs - rhs).
        /// </summary>
        public static hvec5 Sub(Half lhs, Half rhs) => new hvec5(lhs - rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static hvec5 Mul(hvec5 lhs, hvec5 rhs) => new hvec5(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w, lhs.v * rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static hvec5 Mul(hvec5 lhs, Half rhs) => new hvec5(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs, lhs.v * rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static hvec5 Mul(Half lhs, hvec5 rhs) => new hvec5(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w, lhs * rhs.v);
        
        /// <summary>
        /// Returns a hvec from the application of Mul (lhs * rhs).
        /// </summary>
        public static hvec5 Mul(Half lhs, Half rhs) => new hvec5(lhs * rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static hvec5 Div(hvec5 lhs, hvec5 rhs) => new hvec5(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w, lhs.v / rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static hvec5 Div(hvec5 lhs, Half rhs) => new hvec5(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs, lhs.v / rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static hvec5 Div(Half lhs, hvec5 rhs) => new hvec5(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w, lhs / rhs.v);
        
        /// <summary>
        /// Returns a hvec from the application of Div (lhs / rhs).
        /// </summary>
        public static hvec5 Div(Half lhs, Half rhs) => new hvec5(lhs / rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static hvec5 Modulo(hvec5 lhs, hvec5 rhs) => new hvec5(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w, lhs.v % rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static hvec5 Modulo(hvec5 lhs, Half rhs) => new hvec5(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs, lhs.v % rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static hvec5 Modulo(Half lhs, hvec5 rhs) => new hvec5(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w, lhs % rhs.v);
        
        /// <summary>
        /// Returns a hvec from the application of Modulo (lhs % rhs).
        /// </summary>
        public static hvec5 Modulo(Half lhs, Half rhs) => new hvec5(lhs % rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static hvec5 Degrees(hvec5 v) => new hvec5((Half)(v.x * new Half(57.295779513082320876798154814105170332405472466564321)), (Half)(v.y * new Half(57.295779513082320876798154814105170332405472466564321)), (Half)(v.z * new Half(57.295779513082320876798154814105170332405472466564321)), (Half)(v.w * new Half(57.295779513082320876798154814105170332405472466564321)), (Half)(v.v * new Half(57.295779513082320876798154814105170332405472466564321)));
        
        /// <summary>
        /// Returns a hvec from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static hvec5 Degrees(Half v) => new hvec5((Half)(v * new Half(57.295779513082320876798154814105170332405472466564321)));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static hvec5 Radians(hvec5 v) => new hvec5((Half)(v.x * new Half(0.0174532925199432957692369076848861271344287188854172)), (Half)(v.y * new Half(0.0174532925199432957692369076848861271344287188854172)), (Half)(v.z * new Half(0.0174532925199432957692369076848861271344287188854172)), (Half)(v.w * new Half(0.0174532925199432957692369076848861271344287188854172)), (Half)(v.v * new Half(0.0174532925199432957692369076848861271344287188854172)));
        
        /// <summary>
        /// Returns a hvec from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static hvec5 Radians(Half v) => new hvec5((Half)(v * new Half(0.0174532925199432957692369076848861271344287188854172)));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Acos ((Half)Math.Acos((double)v)).
        /// </summary>
        public static hvec5 Acos(hvec5 v) => new hvec5((Half)Math.Acos((double)v.x), (Half)Math.Acos((double)v.y), (Half)Math.Acos((double)v.z), (Half)Math.Acos((double)v.w), (Half)Math.Acos((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Acos ((Half)Math.Acos((double)v)).
        /// </summary>
        public static hvec5 Acos(Half v) => new hvec5((Half)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Asin ((Half)Math.Asin((double)v)).
        /// </summary>
        public static hvec5 Asin(hvec5 v) => new hvec5((Half)Math.Asin((double)v.x), (Half)Math.Asin((double)v.y), (Half)Math.Asin((double)v.z), (Half)Math.Asin((double)v.w), (Half)Math.Asin((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Asin ((Half)Math.Asin((double)v)).
        /// </summary>
        public static hvec5 Asin(Half v) => new hvec5((Half)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Atan ((Half)Math.Atan((double)v)).
        /// </summary>
        public static hvec5 Atan(hvec5 v) => new hvec5((Half)Math.Atan((double)v.x), (Half)Math.Atan((double)v.y), (Half)Math.Atan((double)v.z), (Half)Math.Atan((double)v.w), (Half)Math.Atan((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Atan ((Half)Math.Atan((double)v)).
        /// </summary>
        public static hvec5 Atan(Half v) => new hvec5((Half)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Cos ((Half)Math.Cos((double)v)).
        /// </summary>
        public static hvec5 Cos(hvec5 v) => new hvec5((Half)Math.Cos((double)v.x), (Half)Math.Cos((double)v.y), (Half)Math.Cos((double)v.z), (Half)Math.Cos((double)v.w), (Half)Math.Cos((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Cos ((Half)Math.Cos((double)v)).
        /// </summary>
        public static hvec5 Cos(Half v) => new hvec5((Half)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Cosh ((Half)Math.Cosh((double)v)).
        /// </summary>
        public static hvec5 Cosh(hvec5 v) => new hvec5((Half)Math.Cosh((double)v.x), (Half)Math.Cosh((double)v.y), (Half)Math.Cosh((double)v.z), (Half)Math.Cosh((double)v.w), (Half)Math.Cosh((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Cosh ((Half)Math.Cosh((double)v)).
        /// </summary>
        public static hvec5 Cosh(Half v) => new hvec5((Half)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Exp ((Half)Math.Exp((double)v)).
        /// </summary>
        public static hvec5 Exp(hvec5 v) => new hvec5((Half)Math.Exp((double)v.x), (Half)Math.Exp((double)v.y), (Half)Math.Exp((double)v.z), (Half)Math.Exp((double)v.w), (Half)Math.Exp((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Exp ((Half)Math.Exp((double)v)).
        /// </summary>
        public static hvec5 Exp(Half v) => new hvec5((Half)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Log ((Half)Math.Log((double)v)).
        /// </summary>
        public static hvec5 Log(hvec5 v) => new hvec5((Half)Math.Log((double)v.x), (Half)Math.Log((double)v.y), (Half)Math.Log((double)v.z), (Half)Math.Log((double)v.w), (Half)Math.Log((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Log ((Half)Math.Log((double)v)).
        /// </summary>
        public static hvec5 Log(Half v) => new hvec5((Half)Math.Log((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Log2 ((Half)Math.Log((double)v, 2)).
        /// </summary>
        public static hvec5 Log2(hvec5 v) => new hvec5((Half)Math.Log((double)v.x, 2), (Half)Math.Log((double)v.y, 2), (Half)Math.Log((double)v.z, 2), (Half)Math.Log((double)v.w, 2), (Half)Math.Log((double)v.v, 2));
        
        /// <summary>
        /// Returns a hvec from the application of Log2 ((Half)Math.Log((double)v, 2)).
        /// </summary>
        public static hvec5 Log2(Half v) => new hvec5((Half)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Log10 ((Half)Math.Log10((double)v)).
        /// </summary>
        public static hvec5 Log10(hvec5 v) => new hvec5((Half)Math.Log10((double)v.x), (Half)Math.Log10((double)v.y), (Half)Math.Log10((double)v.z), (Half)Math.Log10((double)v.w), (Half)Math.Log10((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Log10 ((Half)Math.Log10((double)v)).
        /// </summary>
        public static hvec5 Log10(Half v) => new hvec5((Half)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Floor ((Half)Math.Floor(v)).
        /// </summary>
        public static hvec5 Floor(hvec5 v) => new hvec5((Half)Math.Floor(v.x), (Half)Math.Floor(v.y), (Half)Math.Floor(v.z), (Half)Math.Floor(v.w), (Half)Math.Floor(v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Floor ((Half)Math.Floor(v)).
        /// </summary>
        public static hvec5 Floor(Half v) => new hvec5((Half)Math.Floor(v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Ceiling ((Half)Math.Ceiling(v)).
        /// </summary>
        public static hvec5 Ceiling(hvec5 v) => new hvec5((Half)Math.Ceiling(v.x), (Half)Math.Ceiling(v.y), (Half)Math.Ceiling(v.z), (Half)Math.Ceiling(v.w), (Half)Math.Ceiling(v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Ceiling ((Half)Math.Ceiling(v)).
        /// </summary>
        public static hvec5 Ceiling(Half v) => new hvec5((Half)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Round ((Half)Math.Round(v)).
        /// </summary>
        public static hvec5 Round(hvec5 v) => new hvec5((Half)Math.Round(v.x), (Half)Math.Round(v.y), (Half)Math.Round(v.z), (Half)Math.Round(v.w), (Half)Math.Round(v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Round ((Half)Math.Round(v)).
        /// </summary>
        public static hvec5 Round(Half v) => new hvec5((Half)Math.Round(v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Sin ((Half)Math.Sin((double)v)).
        /// </summary>
        public static hvec5 Sin(hvec5 v) => new hvec5((Half)Math.Sin((double)v.x), (Half)Math.Sin((double)v.y), (Half)Math.Sin((double)v.z), (Half)Math.Sin((double)v.w), (Half)Math.Sin((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Sin ((Half)Math.Sin((double)v)).
        /// </summary>
        public static hvec5 Sin(Half v) => new hvec5((Half)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Sinh ((Half)Math.Sinh((double)v)).
        /// </summary>
        public static hvec5 Sinh(hvec5 v) => new hvec5((Half)Math.Sinh((double)v.x), (Half)Math.Sinh((double)v.y), (Half)Math.Sinh((double)v.z), (Half)Math.Sinh((double)v.w), (Half)Math.Sinh((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Sinh ((Half)Math.Sinh((double)v)).
        /// </summary>
        public static hvec5 Sinh(Half v) => new hvec5((Half)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Tan ((Half)Math.Tan((double)v)).
        /// </summary>
        public static hvec5 Tan(hvec5 v) => new hvec5((Half)Math.Tan((double)v.x), (Half)Math.Tan((double)v.y), (Half)Math.Tan((double)v.z), (Half)Math.Tan((double)v.w), (Half)Math.Tan((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Tan ((Half)Math.Tan((double)v)).
        /// </summary>
        public static hvec5 Tan(Half v) => new hvec5((Half)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Tanh ((Half)Math.Tanh((double)v)).
        /// </summary>
        public static hvec5 Tanh(hvec5 v) => new hvec5((Half)Math.Tanh((double)v.x), (Half)Math.Tanh((double)v.y), (Half)Math.Tanh((double)v.z), (Half)Math.Tanh((double)v.w), (Half)Math.Tanh((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Tanh ((Half)Math.Tanh((double)v)).
        /// </summary>
        public static hvec5 Tanh(Half v) => new hvec5((Half)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Truncate ((Half)Math.Truncate((double)v)).
        /// </summary>
        public static hvec5 Truncate(hvec5 v) => new hvec5((Half)Math.Truncate((double)v.x), (Half)Math.Truncate((double)v.y), (Half)Math.Truncate((double)v.z), (Half)Math.Truncate((double)v.w), (Half)Math.Truncate((double)v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Truncate ((Half)Math.Truncate((double)v)).
        /// </summary>
        public static hvec5 Truncate(Half v) => new hvec5((Half)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Fract ((Half)(v - Math.Floor(v))).
        /// </summary>
        public static hvec5 Fract(hvec5 v) => new hvec5((Half)(v.x - Math.Floor(v.x)), (Half)(v.y - Math.Floor(v.y)), (Half)(v.z - Math.Floor(v.z)), (Half)(v.w - Math.Floor(v.w)), (Half)(v.v - Math.Floor(v.v)));
        
        /// <summary>
        /// Returns a hvec from the application of Fract ((Half)(v - Math.Floor(v))).
        /// </summary>
        public static hvec5 Fract(Half v) => new hvec5((Half)(v - Math.Floor(v)));
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static hvec5 Trunc(hvec5 v) => new hvec5((long)(v.x), (long)(v.y), (long)(v.z), (long)(v.w), (long)(v.v));
        
        /// <summary>
        /// Returns a hvec from the application of Trunc ((long)(v)).
        /// </summary>
        public static hvec5 Trunc(Half v) => new hvec5((long)(v));
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec5 Random(Random random, hvec5 minValue, hvec5 maxValue) => new hvec5((Half)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (Half)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (Half)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (Half)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w, (Half)random.NextDouble() * (maxValue.v - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec5 Random(Random random, hvec5 minValue, Half maxValue) => new hvec5((Half)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (Half)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (Half)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (Half)random.NextDouble() * (maxValue - minValue.w) + minValue.w, (Half)random.NextDouble() * (maxValue - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec5 Random(Random random, Half minValue, hvec5 maxValue) => new hvec5((Half)random.NextDouble() * (maxValue.x - minValue) + minValue, (Half)random.NextDouble() * (maxValue.y - minValue) + minValue, (Half)random.NextDouble() * (maxValue.z - minValue) + minValue, (Half)random.NextDouble() * (maxValue.w - minValue) + minValue, (Half)random.NextDouble() * (maxValue.v - minValue) + minValue);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec5 Random(Random random, Half minValue, Half maxValue) => new hvec5((Half)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec5 RandomUniform(Random random, hvec5 minValue, hvec5 maxValue) => new hvec5((Half)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (Half)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (Half)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (Half)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w, (Half)random.NextDouble() * (maxValue.v - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec5 RandomUniform(Random random, hvec5 minValue, Half maxValue) => new hvec5((Half)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (Half)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (Half)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (Half)random.NextDouble() * (maxValue - minValue.w) + minValue.w, (Half)random.NextDouble() * (maxValue - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec5 RandomUniform(Random random, Half minValue, hvec5 maxValue) => new hvec5((Half)random.NextDouble() * (maxValue.x - minValue) + minValue, (Half)random.NextDouble() * (maxValue.y - minValue) + minValue, (Half)random.NextDouble() * (maxValue.z - minValue) + minValue, (Half)random.NextDouble() * (maxValue.w - minValue) + minValue, (Half)random.NextDouble() * (maxValue.v - minValue) + minValue);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec5 RandomUniform(Random random, Half minValue, Half maxValue) => new hvec5((Half)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec5 RandomNormal(Random random, hvec5 mean, hvec5 variance) => new hvec5((Half)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (Half)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (Half)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (Half)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (Half)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec5 RandomNormal(Random random, hvec5 mean, Half variance) => new hvec5((Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec5 RandomNormal(Random random, Half mean, hvec5 variance) => new hvec5((Half)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (Half)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (Half)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (Half)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (Half)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec5 RandomNormal(Random random, Half mean, Half variance) => new hvec5((Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec5 RandomGaussian(Random random, hvec5 mean, hvec5 variance) => new hvec5((Half)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (Half)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (Half)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (Half)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (Half)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec5 RandomGaussian(Random random, hvec5 mean, Half variance) => new hvec5((Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec5 RandomGaussian(Random random, Half mean, hvec5 variance) => new hvec5((Half)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (Half)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (Half)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (Half)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (Half)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a hvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec5 RandomGaussian(Random random, Half mean, Half variance) => new hvec5((Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(hvec5 lhs, hvec5 rhs) => new bvec5(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w, lhs.v < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(hvec5 lhs, Half rhs) => new bvec5(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs, lhs.v < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(Half lhs, hvec5 rhs) => new bvec5(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w, lhs < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(hvec5 lhs, hvec5 rhs) => new bvec5(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w, lhs.v <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(hvec5 lhs, Half rhs) => new bvec5(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs, lhs.v <= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(Half lhs, hvec5 rhs) => new bvec5(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w, lhs <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(hvec5 lhs, hvec5 rhs) => new bvec5(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w, lhs.v > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(hvec5 lhs, Half rhs) => new bvec5(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs, lhs.v > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(Half lhs, hvec5 rhs) => new bvec5(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w, lhs > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(hvec5 lhs, hvec5 rhs) => new bvec5(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w, lhs.v >= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(hvec5 lhs, Half rhs) => new bvec5(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs, lhs.v >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(Half lhs, hvec5 rhs) => new bvec5(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w, lhs >= rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static hvec5 operator+(hvec5 lhs, hvec5 rhs) => new hvec5(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w, lhs.v + rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static hvec5 operator+(hvec5 lhs, Half rhs) => new hvec5(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs, lhs.v + rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static hvec5 operator+(Half lhs, hvec5 rhs) => new hvec5(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w, lhs + rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static hvec5 operator-(hvec5 lhs, hvec5 rhs) => new hvec5(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w, lhs.v - rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static hvec5 operator-(hvec5 lhs, Half rhs) => new hvec5(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs, lhs.v - rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static hvec5 operator-(Half lhs, hvec5 rhs) => new hvec5(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w, lhs - rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static hvec5 operator*(hvec5 lhs, hvec5 rhs) => new hvec5(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w, lhs.v * rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static hvec5 operator*(hvec5 lhs, Half rhs) => new hvec5(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs, lhs.v * rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static hvec5 operator*(Half lhs, hvec5 rhs) => new hvec5(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w, lhs * rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static hvec5 operator/(hvec5 lhs, hvec5 rhs) => new hvec5(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w, lhs.v / rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static hvec5 operator/(hvec5 lhs, Half rhs) => new hvec5(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs, lhs.v / rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static hvec5 operator/(Half lhs, hvec5 rhs) => new hvec5(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w, lhs / rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator+ (identity).
        /// </summary>
        public static hvec5 operator+(hvec5 v) => v;
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator- (-v).
        /// </summary>
        public static hvec5 operator-(hvec5 v) => new hvec5(-v.x, -v.y, -v.z, -v.w, -v.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static hvec5 operator%(hvec5 lhs, hvec5 rhs) => new hvec5(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w, lhs.v % rhs.v);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static hvec5 operator%(hvec5 lhs, Half rhs) => new hvec5(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs, lhs.v % rhs);
        
        /// <summary>
        /// Returns a hvec5 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static hvec5 operator%(Half lhs, hvec5 rhs) => new hvec5(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w, lhs % rhs.v);

        #endregion

    }
}
