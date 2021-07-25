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
    /// A vector of type int with 5 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct ivec5 : IReadOnlyList<int>, IEquatable<ivec5>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public int x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public int y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public int z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public int w;
        
        /// <summary>
        /// v-component
        /// </summary>
        [DataMember]
        public int v;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public ivec5(int x, int y, int z, int w, int v)
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
        public ivec5(int v)
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
        public ivec5(ivec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0;
            this.w = 0;
            this.v = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public ivec5(ivec2 ve, int z)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = 0;
            this.v = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public ivec5(ivec2 ve, int z, int w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = w;
            this.v = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public ivec5(ivec2 ve, int z, int w, int v)
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
        public ivec5(ivec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0;
            this.v = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public ivec5(ivec3 ve, int w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = ve.z;
            this.w = w;
            this.v = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public ivec5(ivec3 ve, int w, int v)
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
        public ivec5(ivec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
            this.v = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public ivec5(ivec4 ve, int v)
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
        public ivec5(ivec5 v)
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
        public ivec5(IReadOnlyList<int> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0 : v[0];
            this.y = c < 1 ? 0 : v[1];
            this.z = c < 2 ? 0 : v[2];
            this.w = c < 3 ? 0 : v[3];
            this.v = c < 4 ? 0 : v[4];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public ivec5(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0 : (int)v[0];
            this.y = c < 1 ? 0 : (int)v[1];
            this.z = c < 2 ? 0 : (int)v[2];
            this.w = c < 3 ? 0 : (int)v[3];
            this.v = c < 4 ? 0 : (int)v[4];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public ivec5(int[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0 : v[0];
            this.y = c < 1 ? 0 : v[1];
            this.z = c < 2 ? 0 : v[2];
            this.w = c < 3 ? 0 : v[3];
            this.v = c < 4 ? 0 : v[4];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public ivec5(int[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0 : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0 : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0 : v[2 + startIndex];
            this.w = c + startIndex < 3 ? 0 : v[3 + startIndex];
            this.v = c + startIndex < 4 ? 0 : v[4 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public ivec5(IEnumerable<int> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a lvec5.
        /// </summary>
        public static implicit operator lvec5(ivec5 v) => new lvec5((long)v.x, (long)v.y, (long)v.z, (long)v.w, (long)v.v);
        
        /// <summary>
        /// Implicitly converts this to a vec5.
        /// </summary>
        public static implicit operator vec5(ivec5 v) => new vec5((float)v.x, (float)v.y, (float)v.z, (float)v.w, (float)v.v);
        
        /// <summary>
        /// Implicitly converts this to a hvec5.
        /// </summary>
        public static implicit operator hvec5(ivec5 v) => new hvec5((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w, (Half)v.v);
        
        /// <summary>
        /// Implicitly converts this to a dvec5.
        /// </summary>
        public static implicit operator dvec5(ivec5 v) => new dvec5((double)v.x, (double)v.y, (double)v.z, (double)v.w, (double)v.v);
        
        /// <summary>
        /// Implicitly converts this to a decvec5.
        /// </summary>
        public static implicit operator decvec5(ivec5 v) => new decvec5((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w, (decimal)v.v);
        
        /// <summary>
        /// Implicitly converts this to a cvec5.
        /// </summary>
        public static implicit operator cvec5(ivec5 v) => new cvec5((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w, (Complex)v.v);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(ivec5 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(ivec5 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(ivec5 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(ivec5 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(ivec5 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(ivec5 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec5.
        /// </summary>
        public static explicit operator uvec5(ivec5 v) => new uvec5((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w, (uint)v.v);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(ivec5 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(ivec5 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(ivec5 v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(ivec5 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(ivec5 v) => new hvec3((Half)v.x, (Half)v.y, (Half)v.z);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(ivec5 v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(ivec5 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(ivec5 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(ivec5 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(ivec5 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(ivec5 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(ivec5 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(ivec5 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(ivec5 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(ivec5 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(ivec5 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(ivec5 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(ivec5 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(ivec5 v) => new bvec2(v.x != 0, v.y != 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(ivec5 v) => new bvec3(v.x != 0, v.y != 0, v.z != 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(ivec5 v) => new bvec4(v.x != 0, v.y != 0, v.z != 0, v.w != 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec5.
        /// </summary>
        public static explicit operator bvec5(ivec5 v) => new bvec5(v.x != 0, v.y != 0, v.z != 0, v.w != 0, v.v != 0);
        
        /// <summary>
        /// Explicitly converts this to a int array.
        /// </summary>
        public static explicit operator int[](ivec5 v) => new [] { v.x, v.y, v.z, v.w, v.v };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](ivec5 v) => new Object[] { v.x, v.y, v.z, v.w, v.v };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public int this[int index]
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
        public swizzle_ivec5 swizzle => new swizzle_ivec5(x, y, z, w, v);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public ivec2 xy
        {
            get
            {
                return new ivec2(x, y);
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
        public ivec2 xz
        {
            get
            {
                return new ivec2(x, z);
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
        public ivec2 yz
        {
            get
            {
                return new ivec2(y, z);
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
        public ivec3 xyz
        {
            get
            {
                return new ivec3(x, y, z);
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
        public ivec2 xw
        {
            get
            {
                return new ivec2(x, w);
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
        public ivec2 yw
        {
            get
            {
                return new ivec2(y, w);
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
        public ivec3 xyw
        {
            get
            {
                return new ivec3(x, y, w);
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
        public ivec2 zw
        {
            get
            {
                return new ivec2(z, w);
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
        public ivec3 xzw
        {
            get
            {
                return new ivec3(x, z, w);
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
        public ivec3 yzw
        {
            get
            {
                return new ivec3(y, z, w);
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
        public ivec4 xyzw
        {
            get
            {
                return new ivec4(x, y, z, w);
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
        public ivec2 xv
        {
            get
            {
                return new ivec2(x, v);
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
        public ivec2 yv
        {
            get
            {
                return new ivec2(y, v);
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
        public ivec3 xyv
        {
            get
            {
                return new ivec3(x, y, v);
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
        public ivec2 zv
        {
            get
            {
                return new ivec2(z, v);
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
        public ivec3 xzv
        {
            get
            {
                return new ivec3(x, z, v);
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
        public ivec3 yzv
        {
            get
            {
                return new ivec3(y, z, v);
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
        public ivec4 xyzv
        {
            get
            {
                return new ivec4(x, y, z, v);
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
        public ivec2 wv
        {
            get
            {
                return new ivec2(w, v);
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
        public ivec3 xwv
        {
            get
            {
                return new ivec3(x, w, v);
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
        public ivec3 ywv
        {
            get
            {
                return new ivec3(y, w, v);
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
        public ivec4 xywv
        {
            get
            {
                return new ivec4(x, y, w, v);
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
        public ivec3 zwv
        {
            get
            {
                return new ivec3(z, w, v);
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
        public ivec4 xzwv
        {
            get
            {
                return new ivec4(x, z, w, v);
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
        public ivec4 yzwv
        {
            get
            {
                return new ivec4(y, z, w, v);
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
        public ivec5 xyzwv
        {
            get
            {
                return new ivec5(x, y, z, w, v);
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
        public ivec2 rg
        {
            get
            {
                return new ivec2(x, y);
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
        public ivec2 rb
        {
            get
            {
                return new ivec2(x, z);
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
        public ivec2 gb
        {
            get
            {
                return new ivec2(y, z);
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
        public ivec3 rgb
        {
            get
            {
                return new ivec3(x, y, z);
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
        public ivec2 ra
        {
            get
            {
                return new ivec2(x, w);
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
        public ivec2 ga
        {
            get
            {
                return new ivec2(y, w);
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
        public ivec3 rga
        {
            get
            {
                return new ivec3(x, y, w);
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
        public ivec2 ba
        {
            get
            {
                return new ivec2(z, w);
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
        public ivec3 rba
        {
            get
            {
                return new ivec3(x, z, w);
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
        public ivec3 gba
        {
            get
            {
                return new ivec3(y, z, w);
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
        public ivec4 rgba
        {
            get
            {
                return new ivec4(x, y, z, w);
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
        public ivec2 rk
        {
            get
            {
                return new ivec2(x, v);
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
        public ivec2 gk
        {
            get
            {
                return new ivec2(y, v);
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
        public ivec3 rgk
        {
            get
            {
                return new ivec3(x, y, v);
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
        public ivec2 bk
        {
            get
            {
                return new ivec2(z, v);
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
        public ivec3 rbk
        {
            get
            {
                return new ivec3(x, z, v);
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
        public ivec3 gbk
        {
            get
            {
                return new ivec3(y, z, v);
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
        public ivec4 rgbk
        {
            get
            {
                return new ivec4(x, y, z, v);
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
        public ivec2 ak
        {
            get
            {
                return new ivec2(w, v);
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
        public ivec3 rak
        {
            get
            {
                return new ivec3(x, w, v);
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
        public ivec3 gak
        {
            get
            {
                return new ivec3(y, w, v);
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
        public ivec4 rgak
        {
            get
            {
                return new ivec4(x, y, w, v);
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
        public ivec3 bak
        {
            get
            {
                return new ivec3(z, w, v);
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
        public ivec4 rbak
        {
            get
            {
                return new ivec4(x, z, w, v);
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
        public ivec4 gbak
        {
            get
            {
                return new ivec4(y, z, w, v);
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
        public ivec5 rgbak
        {
            get
            {
                return new ivec5(x, y, z, w, v);
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
        public int r
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
        public int g
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
        public int b
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
        public int a
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
        public int k
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
        public int[] Values => new[] { x, y, z, w, v };
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public int Count => 5;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public int MinElement => Math.Min(Math.Min(Math.Min(x, y), z), Math.Min(w, v));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public int MaxElement => Math.Max(Math.Max(Math.Max(x, y), z), Math.Max(w, v));
        
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
        public int Sum => (((x + y) + z) + (w + v));
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)Math.Sqrt((((x*x + y*y) + z*z) + (w*w + v*v)));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => (((Math.Abs(x) + Math.Abs(y)) + Math.Abs(z)) + (Math.Abs(w) + Math.Abs(v)));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt((((x*x + y*y) + z*z) + (w*w + v*v)));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => Math.Max(Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z)), Math.Max(Math.Abs(w), Math.Abs(v)));

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static ivec5 Zero { get; } = new ivec5(0, 0, 0, 0, 0);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static ivec5 Ones { get; } = new ivec5(1, 1, 1, 1, 1);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static ivec5 UnitX { get; } = new ivec5(1, 0, 0, 0, 0);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static ivec5 UnitY { get; } = new ivec5(0, 1, 0, 0, 0);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static ivec5 UnitZ { get; } = new ivec5(0, 0, 1, 0, 0);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static ivec5 UnitW { get; } = new ivec5(0, 0, 0, 1, 0);
        
        /// <summary>
        /// Predefined unit-V vector
        /// </summary>
        public static ivec5 UnitV { get; } = new ivec5(0, 0, 0, 0, 1);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static ivec5 MaxValue { get; } = new ivec5(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static ivec5 MinValue { get; } = new ivec5(int.MinValue, int.MinValue, int.MinValue, int.MinValue, int.MinValue);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(ivec5 lhs, ivec5 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(ivec5 lhs, ivec5 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<int> GetEnumerator()
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
        public bool Equals(ivec5 rhs) => (((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z)) && (w.Equals(rhs.w) && v.Equals(rhs.v)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is ivec5 && Equals((ivec5) obj);
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
        public static ivec5 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static ivec5 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new ivec5(int.Parse(kvp[0].Trim()), int.Parse(kvp[1].Trim()), int.Parse(kvp[2].Trim()), int.Parse(kvp[3].Trim()), int.Parse(kvp[4].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static ivec5 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new ivec5(int.Parse(kvp[0].Trim(), provider), int.Parse(kvp[1].Trim(), provider), int.Parse(kvp[2].Trim(), provider), int.Parse(kvp[3].Trim(), provider), int.Parse(kvp[4].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static ivec5 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new ivec5(int.Parse(kvp[0].Trim(), style), int.Parse(kvp[1].Trim(), style), int.Parse(kvp[2].Trim(), style), int.Parse(kvp[3].Trim(), style), int.Parse(kvp[4].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static ivec5 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new ivec5(int.Parse(kvp[0].Trim(), style, provider), int.Parse(kvp[1].Trim(), style, provider), int.Parse(kvp[2].Trim(), style, provider), int.Parse(kvp[3].Trim(), style, provider), int.Parse(kvp[4].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out ivec5 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out ivec5 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) return false;
            int x = 0, y = 0, z = 0, w = 0, v = 0;
            var ok = (((int.TryParse(kvp[0].Trim(), out x) && int.TryParse(kvp[1].Trim(), out y)) && int.TryParse(kvp[2].Trim(), out z)) && (int.TryParse(kvp[3].Trim(), out w) && int.TryParse(kvp[4].Trim(), out v)));
            result = ok ? new ivec5(x, y, z, w, v) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out ivec5 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) return false;
            int x = 0, y = 0, z = 0, w = 0, v = 0;
            var ok = (((int.TryParse(kvp[0].Trim(), style, provider, out x) && int.TryParse(kvp[1].Trim(), style, provider, out y)) && int.TryParse(kvp[2].Trim(), style, provider, out z)) && (int.TryParse(kvp[3].Trim(), style, provider, out w) && int.TryParse(kvp[4].Trim(), style, provider, out v)));
            result = ok ? new ivec5(x, y, z, w, v) : Zero;
            return ok;
        }
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat5x2 OuterProduct(ivec2 c, ivec5 r) => new imat5x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w, c.x * r.v, c.y * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat2x5 OuterProduct(ivec5 c, ivec2 r) => new imat2x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat5x3 OuterProduct(ivec3 c, ivec5 r) => new imat5x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.x * r.v, c.y * r.v, c.z * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat3x5 OuterProduct(ivec5 c, ivec3 r) => new imat3x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat5x4 OuterProduct(ivec4 c, ivec5 r) => new imat5x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.x * r.v, c.y * r.v, c.z * r.v, c.w * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat4x5 OuterProduct(ivec5 c, ivec4 r) => new imat4x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.v * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat5 OuterProduct(ivec5 c, ivec5 r) => new imat5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.v * r.w, c.x * r.v, c.y * r.v, c.z * r.v, c.w * r.v, c.v * r.v);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static int Dot(ivec5 lhs, ivec5 rhs) => (((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z) + (lhs.w * rhs.w + lhs.v * rhs.v));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(ivec5 lhs, ivec5 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(ivec5 lhs, ivec5 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static ivec5 Reflect(ivec5 I, ivec5 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static ivec5 Refract(ivec5 I, ivec5 N, int eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (int)Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static ivec5 FaceForward(ivec5 N, ivec5 I, ivec5 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between 0 (inclusive) and int.MaxValue (exclusive).
        /// </summary>
        public static ivec5 Random(Random random) => new ivec5((int)random.Next(), (int)random.Next(), (int)random.Next(), (int)random.Next(), (int)random.Next());

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(ivec5 lhs, ivec5 rhs) => new bvec5(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w, lhs.v == rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(ivec5 lhs, int rhs) => new bvec5(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs, lhs.v == rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(int lhs, ivec5 rhs) => new bvec5(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w, lhs == rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(int lhs, int rhs) => new bvec5(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(ivec5 lhs, ivec5 rhs) => new bvec5(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w, lhs.v != rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(ivec5 lhs, int rhs) => new bvec5(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs, lhs.v != rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(int lhs, ivec5 rhs) => new bvec5(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w, lhs != rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(int lhs, int rhs) => new bvec5(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(ivec5 lhs, ivec5 rhs) => new bvec5(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w, lhs.v > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(ivec5 lhs, int rhs) => new bvec5(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs, lhs.v > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(int lhs, ivec5 rhs) => new bvec5(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w, lhs > rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(int lhs, int rhs) => new bvec5(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(ivec5 lhs, ivec5 rhs) => new bvec5(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w, lhs.v >= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(ivec5 lhs, int rhs) => new bvec5(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs, lhs.v >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(int lhs, ivec5 rhs) => new bvec5(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w, lhs >= rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(int lhs, int rhs) => new bvec5(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(ivec5 lhs, ivec5 rhs) => new bvec5(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w, lhs.v < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(ivec5 lhs, int rhs) => new bvec5(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs, lhs.v < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(int lhs, ivec5 rhs) => new bvec5(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w, lhs < rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(int lhs, int rhs) => new bvec5(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(ivec5 lhs, ivec5 rhs) => new bvec5(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w, lhs.v <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(ivec5 lhs, int rhs) => new bvec5(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs, lhs.v <= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(int lhs, ivec5 rhs) => new bvec5(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w, lhs <= rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(int lhs, int rhs) => new bvec5(lhs <= rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static ivec5 Abs(ivec5 v) => new ivec5(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z), Math.Abs(v.w), Math.Abs(v.v));
        
        /// <summary>
        /// Returns a ivec from the application of Abs (Math.Abs(v)).
        /// </summary>
        public static ivec5 Abs(int v) => new ivec5(Math.Abs(v));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static ivec5 HermiteInterpolationOrder3(ivec5 v) => new ivec5((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w, (3 - 2 * v.v) * v.v * v.v);
        
        /// <summary>
        /// Returns a ivec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static ivec5 HermiteInterpolationOrder3(int v) => new ivec5((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static ivec5 HermiteInterpolationOrder5(ivec5 v) => new ivec5(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w, ((6 * v.v - 15) * v.v + 10) * v.v * v.v * v.v);
        
        /// <summary>
        /// Returns a ivec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static ivec5 HermiteInterpolationOrder5(int v) => new ivec5(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static ivec5 Sqr(ivec5 v) => new ivec5(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w, v.v * v.v);
        
        /// <summary>
        /// Returns a ivec from the application of Sqr (v * v).
        /// </summary>
        public static ivec5 Sqr(int v) => new ivec5(v * v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static ivec5 Pow2(ivec5 v) => new ivec5(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w, v.v * v.v);
        
        /// <summary>
        /// Returns a ivec from the application of Pow2 (v * v).
        /// </summary>
        public static ivec5 Pow2(int v) => new ivec5(v * v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static ivec5 Pow3(ivec5 v) => new ivec5(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w, v.v * v.v * v.v);
        
        /// <summary>
        /// Returns a ivec from the application of Pow3 (v * v * v).
        /// </summary>
        public static ivec5 Pow3(int v) => new ivec5(v * v * v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static ivec5 Step(ivec5 v) => new ivec5(v.x >= 0 ? 1 : 0, v.y >= 0 ? 1 : 0, v.z >= 0 ? 1 : 0, v.w >= 0 ? 1 : 0, v.v >= 0 ? 1 : 0);
        
        /// <summary>
        /// Returns a ivec from the application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static ivec5 Step(int v) => new ivec5(v >= 0 ? 1 : 0);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sqrt ((int)Math.Sqrt((double)v)).
        /// </summary>
        public static ivec5 Sqrt(ivec5 v) => new ivec5((int)Math.Sqrt((double)v.x), (int)Math.Sqrt((double)v.y), (int)Math.Sqrt((double)v.z), (int)Math.Sqrt((double)v.w), (int)Math.Sqrt((double)v.v));
        
        /// <summary>
        /// Returns a ivec from the application of Sqrt ((int)Math.Sqrt((double)v)).
        /// </summary>
        public static ivec5 Sqrt(int v) => new ivec5((int)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of InverseSqrt ((int)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static ivec5 InverseSqrt(ivec5 v) => new ivec5((int)(1.0 / Math.Sqrt((double)v.x)), (int)(1.0 / Math.Sqrt((double)v.y)), (int)(1.0 / Math.Sqrt((double)v.z)), (int)(1.0 / Math.Sqrt((double)v.w)), (int)(1.0 / Math.Sqrt((double)v.v)));
        
        /// <summary>
        /// Returns a ivec from the application of InverseSqrt ((int)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static ivec5 InverseSqrt(int v) => new ivec5((int)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(ivec5 v) => new ivec5(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z), Math.Sign(v.w), Math.Sign(v.v));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(int v) => new ivec5(Math.Sign(v));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static ivec5 Max(ivec5 lhs, ivec5 rhs) => new ivec5(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z), Math.Max(lhs.w, rhs.w), Math.Max(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static ivec5 Max(ivec5 lhs, int rhs) => new ivec5(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs), Math.Max(lhs.z, rhs), Math.Max(lhs.w, rhs), Math.Max(lhs.v, rhs));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static ivec5 Max(int lhs, ivec5 rhs) => new ivec5(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y), Math.Max(lhs, rhs.z), Math.Max(lhs, rhs.w), Math.Max(lhs, rhs.v));
        
        /// <summary>
        /// Returns a ivec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static ivec5 Max(int lhs, int rhs) => new ivec5(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static ivec5 Min(ivec5 lhs, ivec5 rhs) => new ivec5(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z), Math.Min(lhs.w, rhs.w), Math.Min(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static ivec5 Min(ivec5 lhs, int rhs) => new ivec5(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs), Math.Min(lhs.z, rhs), Math.Min(lhs.w, rhs), Math.Min(lhs.v, rhs));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static ivec5 Min(int lhs, ivec5 rhs) => new ivec5(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y), Math.Min(lhs, rhs.z), Math.Min(lhs, rhs.w), Math.Min(lhs, rhs.v));
        
        /// <summary>
        /// Returns a ivec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static ivec5 Min(int lhs, int rhs) => new ivec5(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Pow ((int)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec5 Pow(ivec5 lhs, ivec5 rhs) => new ivec5((int)Math.Pow((double)lhs.x, (double)rhs.x), (int)Math.Pow((double)lhs.y, (double)rhs.y), (int)Math.Pow((double)lhs.z, (double)rhs.z), (int)Math.Pow((double)lhs.w, (double)rhs.w), (int)Math.Pow((double)lhs.v, (double)rhs.v));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Pow ((int)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec5 Pow(ivec5 lhs, int rhs) => new ivec5((int)Math.Pow((double)lhs.x, (double)rhs), (int)Math.Pow((double)lhs.y, (double)rhs), (int)Math.Pow((double)lhs.z, (double)rhs), (int)Math.Pow((double)lhs.w, (double)rhs), (int)Math.Pow((double)lhs.v, (double)rhs));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Pow ((int)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec5 Pow(int lhs, ivec5 rhs) => new ivec5((int)Math.Pow((double)lhs, (double)rhs.x), (int)Math.Pow((double)lhs, (double)rhs.y), (int)Math.Pow((double)lhs, (double)rhs.z), (int)Math.Pow((double)lhs, (double)rhs.w), (int)Math.Pow((double)lhs, (double)rhs.v));
        
        /// <summary>
        /// Returns a ivec from the application of Pow ((int)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec5 Pow(int lhs, int rhs) => new ivec5((int)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Log ((int)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec5 Log(ivec5 lhs, ivec5 rhs) => new ivec5((int)Math.Log((double)lhs.x, (double)rhs.x), (int)Math.Log((double)lhs.y, (double)rhs.y), (int)Math.Log((double)lhs.z, (double)rhs.z), (int)Math.Log((double)lhs.w, (double)rhs.w), (int)Math.Log((double)lhs.v, (double)rhs.v));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Log ((int)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec5 Log(ivec5 lhs, int rhs) => new ivec5((int)Math.Log((double)lhs.x, (double)rhs), (int)Math.Log((double)lhs.y, (double)rhs), (int)Math.Log((double)lhs.z, (double)rhs), (int)Math.Log((double)lhs.w, (double)rhs), (int)Math.Log((double)lhs.v, (double)rhs));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Log ((int)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec5 Log(int lhs, ivec5 rhs) => new ivec5((int)Math.Log((double)lhs, (double)rhs.x), (int)Math.Log((double)lhs, (double)rhs.y), (int)Math.Log((double)lhs, (double)rhs.z), (int)Math.Log((double)lhs, (double)rhs.w), (int)Math.Log((double)lhs, (double)rhs.v));
        
        /// <summary>
        /// Returns a ivec from the application of Log ((int)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec5 Log(int lhs, int rhs) => new ivec5((int)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec5 Clamp(ivec5 v, ivec5 min, ivec5 max) => new ivec5(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z), Math.Min(Math.Max(v.w, min.w), max.w), Math.Min(Math.Max(v.v, min.v), max.v));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec5 Clamp(ivec5 v, ivec5 min, int max) => new ivec5(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max), Math.Min(Math.Max(v.w, min.w), max), Math.Min(Math.Max(v.v, min.v), max));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec5 Clamp(ivec5 v, int min, ivec5 max) => new ivec5(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z), Math.Min(Math.Max(v.w, min), max.w), Math.Min(Math.Max(v.v, min), max.v));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec5 Clamp(ivec5 v, int min, int max) => new ivec5(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max), Math.Min(Math.Max(v.w, min), max), Math.Min(Math.Max(v.v, min), max));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec5 Clamp(int v, ivec5 min, ivec5 max) => new ivec5(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z), Math.Min(Math.Max(v, min.w), max.w), Math.Min(Math.Max(v, min.v), max.v));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec5 Clamp(int v, ivec5 min, int max) => new ivec5(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max), Math.Min(Math.Max(v, min.w), max), Math.Min(Math.Max(v, min.v), max));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec5 Clamp(int v, int min, ivec5 max) => new ivec5(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z), Math.Min(Math.Max(v, min), max.w), Math.Min(Math.Max(v, min), max.v));
        
        /// <summary>
        /// Returns a ivec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec5 Clamp(int v, int min, int max) => new ivec5(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Mix(ivec5 min, ivec5 max, ivec5 a) => new ivec5(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w, min.v * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Mix(ivec5 min, ivec5 max, int a) => new ivec5(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a, min.v * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Mix(ivec5 min, int max, ivec5 a) => new ivec5(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w, min.v * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Mix(ivec5 min, int max, int a) => new ivec5(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a, min.v * (1-a) + max * a);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Mix(int min, ivec5 max, ivec5 a) => new ivec5(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w, min * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Mix(int min, ivec5 max, int a) => new ivec5(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a, min * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Mix(int min, int max, ivec5 a) => new ivec5(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w, min * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a ivec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Mix(int min, int max, int a) => new ivec5(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Lerp(ivec5 min, ivec5 max, ivec5 a) => new ivec5(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w, min.v * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Lerp(ivec5 min, ivec5 max, int a) => new ivec5(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a, min.v * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Lerp(ivec5 min, int max, ivec5 a) => new ivec5(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w, min.v * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Lerp(ivec5 min, int max, int a) => new ivec5(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a, min.v * (1-a) + max * a);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Lerp(int min, ivec5 max, ivec5 a) => new ivec5(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w, min * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Lerp(int min, ivec5 max, int a) => new ivec5(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a, min * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Lerp(int min, int max, ivec5 a) => new ivec5(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w, min * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a ivec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec5 Lerp(int min, int max, int a) => new ivec5(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec5 Smoothstep(ivec5 edge0, ivec5 edge1, ivec5 v) => new ivec5(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec5 Smoothstep(ivec5 edge0, ivec5 edge1, int v) => new ivec5(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec5 Smoothstep(ivec5 edge0, int edge1, ivec5 v) => new ivec5(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec5 Smoothstep(ivec5 edge0, int edge1, int v) => new ivec5(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec5 Smoothstep(int edge0, ivec5 edge1, ivec5 v) => new ivec5(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec5 Smoothstep(int edge0, ivec5 edge1, int v) => new ivec5(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec5 Smoothstep(int edge0, int edge1, ivec5 v) => new ivec5(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a ivec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec5 Smoothstep(int edge0, int edge1, int v) => new ivec5(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec5 Smootherstep(ivec5 edge0, ivec5 edge1, ivec5 v) => new ivec5(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec5 Smootherstep(ivec5 edge0, ivec5 edge1, int v) => new ivec5(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec5 Smootherstep(ivec5 edge0, int edge1, ivec5 v) => new ivec5(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec5 Smootherstep(ivec5 edge0, int edge1, int v) => new ivec5(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec5 Smootherstep(int edge0, ivec5 edge1, ivec5 v) => new ivec5(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec5 Smootherstep(int edge0, ivec5 edge1, int v) => new ivec5(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec5 Smootherstep(int edge0, int edge1, ivec5 v) => new ivec5(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a ivec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec5 Smootherstep(int edge0, int edge1, int v) => new ivec5(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static ivec5 Fma(ivec5 a, ivec5 b, ivec5 c) => new ivec5(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w, a.v * b.v + c.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static ivec5 Fma(ivec5 a, ivec5 b, int c) => new ivec5(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c, a.v * b.v + c);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static ivec5 Fma(ivec5 a, int b, ivec5 c) => new ivec5(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w, a.v * b + c.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static ivec5 Fma(ivec5 a, int b, int c) => new ivec5(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c, a.v * b + c);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static ivec5 Fma(int a, ivec5 b, ivec5 c) => new ivec5(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w, a * b.v + c.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static ivec5 Fma(int a, ivec5 b, int c) => new ivec5(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c, a * b.v + c);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static ivec5 Fma(int a, int b, ivec5 c) => new ivec5(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w, a * b + c.v);
        
        /// <summary>
        /// Returns a ivec from the application of Fma (a * b + c).
        /// </summary>
        public static ivec5 Fma(int a, int b, int c) => new ivec5(a * b + c);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static ivec5 Add(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w, lhs.v + rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static ivec5 Add(ivec5 lhs, int rhs) => new ivec5(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs, lhs.v + rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static ivec5 Add(int lhs, ivec5 rhs) => new ivec5(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w, lhs + rhs.v);
        
        /// <summary>
        /// Returns a ivec from the application of Add (lhs + rhs).
        /// </summary>
        public static ivec5 Add(int lhs, int rhs) => new ivec5(lhs + rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static ivec5 Sub(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w, lhs.v - rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static ivec5 Sub(ivec5 lhs, int rhs) => new ivec5(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs, lhs.v - rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static ivec5 Sub(int lhs, ivec5 rhs) => new ivec5(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w, lhs - rhs.v);
        
        /// <summary>
        /// Returns a ivec from the application of Sub (lhs - rhs).
        /// </summary>
        public static ivec5 Sub(int lhs, int rhs) => new ivec5(lhs - rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static ivec5 Mul(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w, lhs.v * rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static ivec5 Mul(ivec5 lhs, int rhs) => new ivec5(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs, lhs.v * rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static ivec5 Mul(int lhs, ivec5 rhs) => new ivec5(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w, lhs * rhs.v);
        
        /// <summary>
        /// Returns a ivec from the application of Mul (lhs * rhs).
        /// </summary>
        public static ivec5 Mul(int lhs, int rhs) => new ivec5(lhs * rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static ivec5 Div(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w, lhs.v / rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static ivec5 Div(ivec5 lhs, int rhs) => new ivec5(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs, lhs.v / rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static ivec5 Div(int lhs, ivec5 rhs) => new ivec5(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w, lhs / rhs.v);
        
        /// <summary>
        /// Returns a ivec from the application of Div (lhs / rhs).
        /// </summary>
        public static ivec5 Div(int lhs, int rhs) => new ivec5(lhs / rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static ivec5 Xor(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w, lhs.v ^ rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static ivec5 Xor(ivec5 lhs, int rhs) => new ivec5(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs, lhs.v ^ rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static ivec5 Xor(int lhs, ivec5 rhs) => new ivec5(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w, lhs ^ rhs.v);
        
        /// <summary>
        /// Returns a ivec from the application of Xor (lhs ^ rhs).
        /// </summary>
        public static ivec5 Xor(int lhs, int rhs) => new ivec5(lhs ^ rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static ivec5 BitwiseOr(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w, lhs.v | rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static ivec5 BitwiseOr(ivec5 lhs, int rhs) => new ivec5(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs, lhs.v | rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static ivec5 BitwiseOr(int lhs, ivec5 rhs) => new ivec5(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w, lhs | rhs.v);
        
        /// <summary>
        /// Returns a ivec from the application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static ivec5 BitwiseOr(int lhs, int rhs) => new ivec5(lhs | rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static ivec5 BitwiseAnd(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w, lhs.v & rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static ivec5 BitwiseAnd(ivec5 lhs, int rhs) => new ivec5(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs, lhs.v & rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static ivec5 BitwiseAnd(int lhs, ivec5 rhs) => new ivec5(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w, lhs & rhs.v);
        
        /// <summary>
        /// Returns a ivec from the application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static ivec5 BitwiseAnd(int lhs, int rhs) => new ivec5(lhs & rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static ivec5 LeftShift(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x << rhs.x, lhs.y << rhs.y, lhs.z << rhs.z, lhs.w << rhs.w, lhs.v << rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static ivec5 LeftShift(ivec5 lhs, int rhs) => new ivec5(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs, lhs.w << rhs, lhs.v << rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static ivec5 LeftShift(int lhs, ivec5 rhs) => new ivec5(lhs << rhs.x, lhs << rhs.y, lhs << rhs.z, lhs << rhs.w, lhs << rhs.v);
        
        /// <summary>
        /// Returns a ivec from the application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static ivec5 LeftShift(int lhs, int rhs) => new ivec5(lhs << rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static ivec5 RightShift(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x >> rhs.x, lhs.y >> rhs.y, lhs.z >> rhs.z, lhs.w >> rhs.w, lhs.v >> rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static ivec5 RightShift(ivec5 lhs, int rhs) => new ivec5(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs, lhs.w >> rhs, lhs.v >> rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static ivec5 RightShift(int lhs, ivec5 rhs) => new ivec5(lhs >> rhs.x, lhs >> rhs.y, lhs >> rhs.z, lhs >> rhs.w, lhs >> rhs.v);
        
        /// <summary>
        /// Returns a ivec from the application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static ivec5 RightShift(int lhs, int rhs) => new ivec5(lhs >> rhs);
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static ivec5 Random(Random random, ivec5 maxValue) => new ivec5((int)random.Next((int)maxValue.x), (int)random.Next((int)maxValue.y), (int)random.Next((int)maxValue.z), (int)random.Next((int)maxValue.w), (int)random.Next((int)maxValue.v));
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static ivec5 Random(Random random, int maxValue) => new ivec5((int)random.Next((int)maxValue));
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec5 Random(Random random, ivec5 minValue, ivec5 maxValue) => new ivec5((int)random.Next((int)minValue.x, (int)maxValue.x), (int)random.Next((int)minValue.y, (int)maxValue.y), (int)random.Next((int)minValue.z, (int)maxValue.z), (int)random.Next((int)minValue.w, (int)maxValue.w), (int)random.Next((int)minValue.v, (int)maxValue.v));
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec5 Random(Random random, ivec5 minValue, int maxValue) => new ivec5((int)random.Next((int)minValue.x, (int)maxValue), (int)random.Next((int)minValue.y, (int)maxValue), (int)random.Next((int)minValue.z, (int)maxValue), (int)random.Next((int)minValue.w, (int)maxValue), (int)random.Next((int)minValue.v, (int)maxValue));
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec5 Random(Random random, int minValue, ivec5 maxValue) => new ivec5((int)random.Next((int)minValue, (int)maxValue.x), (int)random.Next((int)minValue, (int)maxValue.y), (int)random.Next((int)minValue, (int)maxValue.z), (int)random.Next((int)minValue, (int)maxValue.w), (int)random.Next((int)minValue, (int)maxValue.v));
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec5 Random(Random random, int minValue, int maxValue) => new ivec5((int)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec5 RandomUniform(Random random, ivec5 minValue, ivec5 maxValue) => new ivec5((int)random.Next((int)minValue.x, (int)maxValue.x), (int)random.Next((int)minValue.y, (int)maxValue.y), (int)random.Next((int)minValue.z, (int)maxValue.z), (int)random.Next((int)minValue.w, (int)maxValue.w), (int)random.Next((int)minValue.v, (int)maxValue.v));
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec5 RandomUniform(Random random, ivec5 minValue, int maxValue) => new ivec5((int)random.Next((int)minValue.x, (int)maxValue), (int)random.Next((int)minValue.y, (int)maxValue), (int)random.Next((int)minValue.z, (int)maxValue), (int)random.Next((int)minValue.w, (int)maxValue), (int)random.Next((int)minValue.v, (int)maxValue));
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec5 RandomUniform(Random random, int minValue, ivec5 maxValue) => new ivec5((int)random.Next((int)minValue, (int)maxValue.x), (int)random.Next((int)minValue, (int)maxValue.y), (int)random.Next((int)minValue, (int)maxValue.z), (int)random.Next((int)minValue, (int)maxValue.w), (int)random.Next((int)minValue, (int)maxValue.v));
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec5 RandomUniform(Random random, int minValue, int maxValue) => new ivec5((int)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static ivec5 RandomPoisson(Random random, dvec5 lambda) => new ivec5((int)lambda.x.GetPoisson(random), (int)lambda.y.GetPoisson(random), (int)lambda.z.GetPoisson(random), (int)lambda.w.GetPoisson(random), (int)lambda.v.GetPoisson(random));
        
        /// <summary>
        /// Returns a ivec5 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static ivec5 RandomPoisson(Random random, double lambda) => new ivec5((int)lambda.GetPoisson(random));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(ivec5 lhs, ivec5 rhs) => new bvec5(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w, lhs.v < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(ivec5 lhs, int rhs) => new bvec5(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs, lhs.v < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(int lhs, ivec5 rhs) => new bvec5(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w, lhs < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(ivec5 lhs, ivec5 rhs) => new bvec5(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w, lhs.v <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(ivec5 lhs, int rhs) => new bvec5(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs, lhs.v <= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(int lhs, ivec5 rhs) => new bvec5(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w, lhs <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(ivec5 lhs, ivec5 rhs) => new bvec5(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w, lhs.v > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(ivec5 lhs, int rhs) => new bvec5(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs, lhs.v > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(int lhs, ivec5 rhs) => new bvec5(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w, lhs > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(ivec5 lhs, ivec5 rhs) => new bvec5(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w, lhs.v >= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(ivec5 lhs, int rhs) => new bvec5(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs, lhs.v >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(int lhs, ivec5 rhs) => new bvec5(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w, lhs >= rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static ivec5 operator+(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w, lhs.v + rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static ivec5 operator+(ivec5 lhs, int rhs) => new ivec5(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs, lhs.v + rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static ivec5 operator+(int lhs, ivec5 rhs) => new ivec5(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w, lhs + rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static ivec5 operator-(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w, lhs.v - rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static ivec5 operator-(ivec5 lhs, int rhs) => new ivec5(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs, lhs.v - rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static ivec5 operator-(int lhs, ivec5 rhs) => new ivec5(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w, lhs - rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static ivec5 operator*(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w, lhs.v * rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static ivec5 operator*(ivec5 lhs, int rhs) => new ivec5(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs, lhs.v * rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static ivec5 operator*(int lhs, ivec5 rhs) => new ivec5(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w, lhs * rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static ivec5 operator/(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w, lhs.v / rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static ivec5 operator/(ivec5 lhs, int rhs) => new ivec5(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs, lhs.v / rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static ivec5 operator/(int lhs, ivec5 rhs) => new ivec5(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w, lhs / rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator+ (identity).
        /// </summary>
        public static ivec5 operator+(ivec5 v) => v;
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator- (-v).
        /// </summary>
        public static ivec5 operator-(ivec5 v) => new ivec5(-v.x, -v.y, -v.z, -v.w, -v.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator~ (~v).
        /// </summary>
        public static ivec5 operator~(ivec5 v) => new ivec5(~v.x, ~v.y, ~v.z, ~v.w, ~v.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static ivec5 operator^(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w, lhs.v ^ rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static ivec5 operator^(ivec5 lhs, int rhs) => new ivec5(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs, lhs.v ^ rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static ivec5 operator^(int lhs, ivec5 rhs) => new ivec5(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w, lhs ^ rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static ivec5 operator|(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w, lhs.v | rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static ivec5 operator|(ivec5 lhs, int rhs) => new ivec5(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs, lhs.v | rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static ivec5 operator|(int lhs, ivec5 rhs) => new ivec5(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w, lhs | rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static ivec5 operator&(ivec5 lhs, ivec5 rhs) => new ivec5(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w, lhs.v & rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static ivec5 operator&(ivec5 lhs, int rhs) => new ivec5(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs, lhs.v & rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static ivec5 operator&(int lhs, ivec5 rhs) => new ivec5(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w, lhs & rhs.v);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        public static ivec5 operator<<(ivec5 lhs, int rhs) => new ivec5(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs, lhs.w << rhs, lhs.v << rhs);
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        public static ivec5 operator>>(ivec5 lhs, int rhs) => new ivec5(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs, lhs.w >> rhs, lhs.v >> rhs);

        #endregion

    }
}
