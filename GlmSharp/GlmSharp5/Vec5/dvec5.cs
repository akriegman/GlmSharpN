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
    /// A vector of type double with 5 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct dvec5 : IReadOnlyList<double>, IEquatable<dvec5>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public double y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public double z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public double w;
        
        /// <summary>
        /// v-component
        /// </summary>
        [DataMember]
        public double v;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public dvec5(double x, double y, double z, double w, double v)
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
        public dvec5(double v)
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
        public dvec5(dvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0.0;
            this.w = 0.0;
            this.v = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public dvec5(dvec2 ve, double z)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = 0.0;
            this.v = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public dvec5(dvec2 ve, double z, double w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = w;
            this.v = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public dvec5(dvec2 ve, double z, double w, double v)
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
        public dvec5(dvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0.0;
            this.v = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public dvec5(dvec3 ve, double w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = ve.z;
            this.w = w;
            this.v = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public dvec5(dvec3 ve, double w, double v)
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
        public dvec5(dvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
            this.v = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public dvec5(dvec4 ve, double v)
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
        public dvec5(dvec5 v)
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
        public dvec5(IReadOnlyList<double> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0.0 : v[0];
            this.y = c < 1 ? 0.0 : v[1];
            this.z = c < 2 ? 0.0 : v[2];
            this.w = c < 3 ? 0.0 : v[3];
            this.v = c < 4 ? 0.0 : v[4];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec5(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0.0 : (double)v[0];
            this.y = c < 1 ? 0.0 : (double)v[1];
            this.z = c < 2 ? 0.0 : (double)v[2];
            this.w = c < 3 ? 0.0 : (double)v[3];
            this.v = c < 4 ? 0.0 : (double)v[4];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec5(double[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0.0 : v[0];
            this.y = c < 1 ? 0.0 : v[1];
            this.z = c < 2 ? 0.0 : v[2];
            this.w = c < 3 ? 0.0 : v[3];
            this.v = c < 4 ? 0.0 : v[4];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec5(double[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0.0 : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0.0 : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0.0 : v[2 + startIndex];
            this.w = c + startIndex < 3 ? 0.0 : v[3 + startIndex];
            this.v = c + startIndex < 4 ? 0.0 : v[4 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec5(IEnumerable<double> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a cvec5.
        /// </summary>
        public static implicit operator cvec5(dvec5 v) => new cvec5((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w, (Complex)v.v);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(dvec5 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(dvec5 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(dvec5 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a ivec5.
        /// </summary>
        public static explicit operator ivec5(dvec5 v) => new ivec5((int)v.x, (int)v.y, (int)v.z, (int)v.w, (int)v.v);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(dvec5 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(dvec5 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(dvec5 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec5.
        /// </summary>
        public static explicit operator uvec5(dvec5 v) => new uvec5((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w, (uint)v.v);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(dvec5 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(dvec5 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(dvec5 v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a vec5.
        /// </summary>
        public static explicit operator vec5(dvec5 v) => new vec5((float)v.x, (float)v.y, (float)v.z, (float)v.w, (float)v.v);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(dvec5 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(dvec5 v) => new hvec3((Half)v.x, (Half)v.y, (Half)v.z);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(dvec5 v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Explicitly converts this to a hvec5.
        /// </summary>
        public static explicit operator hvec5(dvec5 v) => new hvec5((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w, (Half)v.v);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(dvec5 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(dvec5 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(dvec5 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(dvec5 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(dvec5 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(dvec5 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a decvec5.
        /// </summary>
        public static explicit operator decvec5(dvec5 v) => new decvec5((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w, (decimal)v.v);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(dvec5 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(dvec5 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(dvec5 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(dvec5 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(dvec5 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(dvec5 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lvec5.
        /// </summary>
        public static explicit operator lvec5(dvec5 v) => new lvec5((long)v.x, (long)v.y, (long)v.z, (long)v.w, (long)v.v);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(dvec5 v) => new bvec2(v.x != 0.0, v.y != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(dvec5 v) => new bvec3(v.x != 0.0, v.y != 0.0, v.z != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(dvec5 v) => new bvec4(v.x != 0.0, v.y != 0.0, v.z != 0.0, v.w != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a bvec5.
        /// </summary>
        public static explicit operator bvec5(dvec5 v) => new bvec5(v.x != 0.0, v.y != 0.0, v.z != 0.0, v.w != 0.0, v.v != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a double array.
        /// </summary>
        public static explicit operator double[](dvec5 v) => new [] { v.x, v.y, v.z, v.w, v.v };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](dvec5 v) => new Object[] { v.x, v.y, v.z, v.w, v.v };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public double this[int index]
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
        public swizzle_dvec5 swizzle => new swizzle_dvec5(x, y, z, w, v);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public dvec2 xy
        {
            get
            {
                return new dvec2(x, y);
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
        public dvec2 xz
        {
            get
            {
                return new dvec2(x, z);
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
        public dvec2 yz
        {
            get
            {
                return new dvec2(y, z);
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
        public dvec3 xyz
        {
            get
            {
                return new dvec3(x, y, z);
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
        public dvec2 xw
        {
            get
            {
                return new dvec2(x, w);
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
        public dvec2 yw
        {
            get
            {
                return new dvec2(y, w);
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
        public dvec3 xyw
        {
            get
            {
                return new dvec3(x, y, w);
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
        public dvec2 zw
        {
            get
            {
                return new dvec2(z, w);
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
        public dvec3 xzw
        {
            get
            {
                return new dvec3(x, z, w);
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
        public dvec3 yzw
        {
            get
            {
                return new dvec3(y, z, w);
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
        public dvec4 xyzw
        {
            get
            {
                return new dvec4(x, y, z, w);
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
        public dvec2 xv
        {
            get
            {
                return new dvec2(x, v);
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
        public dvec2 yv
        {
            get
            {
                return new dvec2(y, v);
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
        public dvec3 xyv
        {
            get
            {
                return new dvec3(x, y, v);
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
        public dvec2 zv
        {
            get
            {
                return new dvec2(z, v);
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
        public dvec3 xzv
        {
            get
            {
                return new dvec3(x, z, v);
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
        public dvec3 yzv
        {
            get
            {
                return new dvec3(y, z, v);
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
        public dvec4 xyzv
        {
            get
            {
                return new dvec4(x, y, z, v);
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
        public dvec2 wv
        {
            get
            {
                return new dvec2(w, v);
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
        public dvec3 xwv
        {
            get
            {
                return new dvec3(x, w, v);
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
        public dvec3 ywv
        {
            get
            {
                return new dvec3(y, w, v);
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
        public dvec4 xywv
        {
            get
            {
                return new dvec4(x, y, w, v);
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
        public dvec3 zwv
        {
            get
            {
                return new dvec3(z, w, v);
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
        public dvec4 xzwv
        {
            get
            {
                return new dvec4(x, z, w, v);
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
        public dvec4 yzwv
        {
            get
            {
                return new dvec4(y, z, w, v);
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
        public dvec5 xyzwv
        {
            get
            {
                return new dvec5(x, y, z, w, v);
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
        public dvec2 rg
        {
            get
            {
                return new dvec2(x, y);
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
        public dvec2 rb
        {
            get
            {
                return new dvec2(x, z);
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
        public dvec2 gb
        {
            get
            {
                return new dvec2(y, z);
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
        public dvec3 rgb
        {
            get
            {
                return new dvec3(x, y, z);
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
        public dvec2 ra
        {
            get
            {
                return new dvec2(x, w);
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
        public dvec2 ga
        {
            get
            {
                return new dvec2(y, w);
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
        public dvec3 rga
        {
            get
            {
                return new dvec3(x, y, w);
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
        public dvec2 ba
        {
            get
            {
                return new dvec2(z, w);
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
        public dvec3 rba
        {
            get
            {
                return new dvec3(x, z, w);
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
        public dvec3 gba
        {
            get
            {
                return new dvec3(y, z, w);
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
        public dvec4 rgba
        {
            get
            {
                return new dvec4(x, y, z, w);
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
        public dvec2 rk
        {
            get
            {
                return new dvec2(x, v);
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
        public dvec2 gk
        {
            get
            {
                return new dvec2(y, v);
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
        public dvec3 rgk
        {
            get
            {
                return new dvec3(x, y, v);
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
        public dvec2 bk
        {
            get
            {
                return new dvec2(z, v);
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
        public dvec3 rbk
        {
            get
            {
                return new dvec3(x, z, v);
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
        public dvec3 gbk
        {
            get
            {
                return new dvec3(y, z, v);
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
        public dvec4 rgbk
        {
            get
            {
                return new dvec4(x, y, z, v);
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
        public dvec2 ak
        {
            get
            {
                return new dvec2(w, v);
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
        public dvec3 rak
        {
            get
            {
                return new dvec3(x, w, v);
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
        public dvec3 gak
        {
            get
            {
                return new dvec3(y, w, v);
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
        public dvec4 rgak
        {
            get
            {
                return new dvec4(x, y, w, v);
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
        public dvec3 bak
        {
            get
            {
                return new dvec3(z, w, v);
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
        public dvec4 rbak
        {
            get
            {
                return new dvec4(x, z, w, v);
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
        public dvec4 gbak
        {
            get
            {
                return new dvec4(y, z, w, v);
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
        public dvec5 rgbak
        {
            get
            {
                return new dvec5(x, y, z, w, v);
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
        public double r
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
        public double g
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
        public double b
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
        public double a
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
        public double k
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
        public double[] Values => new[] { x, y, z, w, v };
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public int Count => 5;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public double MinElement => Math.Min(Math.Min(Math.Min(x, y), z), Math.Min(w, v));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public double MaxElement => Math.Max(Math.Max(Math.Max(x, y), z), Math.Max(w, v));
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)Math.Sqrt((((x*x + y*y) + z*z) + (w*w + v*v)));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => (((x*x + y*y) + z*z) + (w*w + v*v));
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public double Sum => (((x + y) + z) + (w + v));
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)Math.Sqrt((((x*x + y*y) + z*z) + (w*w + v*v)));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => (((Math.Abs(x) + Math.Abs(y)) + Math.Abs(z)) + (Math.Abs(w) + Math.Abs(v)));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt((((x*x + y*y) + z*z) + (w*w + v*v)));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public double NormMax => Math.Max(Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z)), Math.Max(Math.Abs(w), Math.Abs(v)));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public dvec5 Normalized => this / (double)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public dvec5 NormalizedSafe => this == Zero ? Zero : this / (double)Length;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static dvec5 Zero { get; } = new dvec5(0.0, 0.0, 0.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static dvec5 Ones { get; } = new dvec5(1.0, 1.0, 1.0, 1.0, 1.0);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static dvec5 UnitX { get; } = new dvec5(1.0, 0.0, 0.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static dvec5 UnitY { get; } = new dvec5(0.0, 1.0, 0.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static dvec5 UnitZ { get; } = new dvec5(0.0, 0.0, 1.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static dvec5 UnitW { get; } = new dvec5(0.0, 0.0, 0.0, 1.0, 0.0);
        
        /// <summary>
        /// Predefined unit-V vector
        /// </summary>
        public static dvec5 UnitV { get; } = new dvec5(0.0, 0.0, 0.0, 0.0, 1.0);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static dvec5 MaxValue { get; } = new dvec5(double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static dvec5 MinValue { get; } = new dvec5(double.MinValue, double.MinValue, double.MinValue, double.MinValue, double.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static dvec5 Epsilon { get; } = new dvec5(double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static dvec5 NaN { get; } = new dvec5(double.NaN, double.NaN, double.NaN, double.NaN, double.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static dvec5 NegativeInfinity { get; } = new dvec5(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static dvec5 PositiveInfinity { get; } = new dvec5(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(dvec5 lhs, dvec5 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(dvec5 lhs, dvec5 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
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
        public bool Equals(dvec5 rhs) => (((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z)) && (w.Equals(rhs.w) && v.Equals(rhs.v)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is dvec5 && Equals((dvec5) obj);
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
        public static dvec5 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static dvec5 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new dvec5(double.Parse(kvp[0].Trim()), double.Parse(kvp[1].Trim()), double.Parse(kvp[2].Trim()), double.Parse(kvp[3].Trim()), double.Parse(kvp[4].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static dvec5 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new dvec5(double.Parse(kvp[0].Trim(), provider), double.Parse(kvp[1].Trim(), provider), double.Parse(kvp[2].Trim(), provider), double.Parse(kvp[3].Trim(), provider), double.Parse(kvp[4].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static dvec5 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new dvec5(double.Parse(kvp[0].Trim(), style), double.Parse(kvp[1].Trim(), style), double.Parse(kvp[2].Trim(), style), double.Parse(kvp[3].Trim(), style), double.Parse(kvp[4].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static dvec5 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) throw new FormatException("input has not exactly 5 parts");
            return new dvec5(double.Parse(kvp[0].Trim(), style, provider), double.Parse(kvp[1].Trim(), style, provider), double.Parse(kvp[2].Trim(), style, provider), double.Parse(kvp[3].Trim(), style, provider), double.Parse(kvp[4].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out dvec5 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out dvec5 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) return false;
            double x = 0.0, y = 0.0, z = 0.0, w = 0.0, v = 0.0;
            var ok = (((double.TryParse(kvp[0].Trim(), out x) && double.TryParse(kvp[1].Trim(), out y)) && double.TryParse(kvp[2].Trim(), out z)) && (double.TryParse(kvp[3].Trim(), out w) && double.TryParse(kvp[4].Trim(), out v)));
            result = ok ? new dvec5(x, y, z, w, v) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out dvec5 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 5) return false;
            double x = 0.0, y = 0.0, z = 0.0, w = 0.0, v = 0.0;
            var ok = (((double.TryParse(kvp[0].Trim(), style, provider, out x) && double.TryParse(kvp[1].Trim(), style, provider, out y)) && double.TryParse(kvp[2].Trim(), style, provider, out z)) && (double.TryParse(kvp[3].Trim(), style, provider, out w) && double.TryParse(kvp[4].Trim(), style, provider, out v)));
            result = ok ? new dvec5(x, y, z, w, v) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(dvec5 lhs, dvec5 rhs, double eps = 0.1d) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat5x2 OuterProduct(dvec2 c, dvec5 r) => new dmat5x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w, c.x * r.v, c.y * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat2x5 OuterProduct(dvec5 c, dvec2 r) => new dmat2x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat5x3 OuterProduct(dvec3 c, dvec5 r) => new dmat5x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.x * r.v, c.y * r.v, c.z * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat3x5 OuterProduct(dvec5 c, dvec3 r) => new dmat3x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat5x4 OuterProduct(dvec4 c, dvec5 r) => new dmat5x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.x * r.v, c.y * r.v, c.z * r.v, c.w * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat4x5 OuterProduct(dvec5 c, dvec4 r) => new dmat4x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.v * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat5 OuterProduct(dvec5 c, dvec5 r) => new dmat5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.v * r.w, c.x * r.v, c.y * r.v, c.z * r.v, c.w * r.v, c.v * r.v);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(dvec5 lhs, dvec5 rhs) => (((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z) + (lhs.w * rhs.w + lhs.v * rhs.v));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(dvec5 lhs, dvec5 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(dvec5 lhs, dvec5 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec5 Reflect(dvec5 I, dvec5 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec5 Refract(dvec5 I, dvec5 N, double eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (double)Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static dvec5 FaceForward(dvec5 N, dvec5 I, dvec5 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static dvec5 Random(Random random) => new dvec5((double)random.NextDouble(), (double)random.NextDouble(), (double)random.NextDouble(), (double)random.NextDouble(), (double)random.NextDouble());
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static dvec5 RandomSigned(Random random) => new dvec5((double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static dvec5 RandomNormal(Random random) => new dvec5((double)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (double)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (double)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (double)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (double)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(dvec5 lhs, dvec5 rhs) => new bvec5(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w, lhs.v == rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(dvec5 lhs, double rhs) => new bvec5(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs, lhs.v == rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(double lhs, dvec5 rhs) => new bvec5(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w, lhs == rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(double lhs, double rhs) => new bvec5(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(dvec5 lhs, dvec5 rhs) => new bvec5(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w, lhs.v != rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(dvec5 lhs, double rhs) => new bvec5(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs, lhs.v != rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(double lhs, dvec5 rhs) => new bvec5(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w, lhs != rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(double lhs, double rhs) => new bvec5(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(dvec5 lhs, dvec5 rhs) => new bvec5(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w, lhs.v > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(dvec5 lhs, double rhs) => new bvec5(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs, lhs.v > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(double lhs, dvec5 rhs) => new bvec5(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w, lhs > rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec5 GreaterThan(double lhs, double rhs) => new bvec5(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(dvec5 lhs, dvec5 rhs) => new bvec5(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w, lhs.v >= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(dvec5 lhs, double rhs) => new bvec5(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs, lhs.v >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(double lhs, dvec5 rhs) => new bvec5(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w, lhs >= rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 GreaterThanEqual(double lhs, double rhs) => new bvec5(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(dvec5 lhs, dvec5 rhs) => new bvec5(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w, lhs.v < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(dvec5 lhs, double rhs) => new bvec5(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs, lhs.v < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(double lhs, dvec5 rhs) => new bvec5(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w, lhs < rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec5 LesserThan(double lhs, double rhs) => new bvec5(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(dvec5 lhs, dvec5 rhs) => new bvec5(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w, lhs.v <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(dvec5 lhs, double rhs) => new bvec5(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs, lhs.v <= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(double lhs, dvec5 rhs) => new bvec5(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w, lhs <= rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 LesserThanEqual(double lhs, double rhs) => new bvec5(lhs <= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsInfinity(dvec5 v) => new bvec5(double.IsInfinity(v.x), double.IsInfinity(v.y), double.IsInfinity(v.z), double.IsInfinity(v.w), double.IsInfinity(v.v));
        
        /// <summary>
        /// Returns a bvec from the application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsInfinity(double v) => new bvec5(double.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsFinite(dvec5 v) => new bvec5(!double.IsNaN(v.x) && !double.IsInfinity(v.x), !double.IsNaN(v.y) && !double.IsInfinity(v.y), !double.IsNaN(v.z) && !double.IsInfinity(v.z), !double.IsNaN(v.w) && !double.IsInfinity(v.w), !double.IsNaN(v.v) && !double.IsInfinity(v.v));
        
        /// <summary>
        /// Returns a bvec from the application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bvec5 IsFinite(double v) => new bvec5(!double.IsNaN(v) && !double.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bvec5 IsNaN(dvec5 v) => new bvec5(double.IsNaN(v.x), double.IsNaN(v.y), double.IsNaN(v.z), double.IsNaN(v.w), double.IsNaN(v.v));
        
        /// <summary>
        /// Returns a bvec from the application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bvec5 IsNaN(double v) => new bvec5(double.IsNaN(v));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec5 IsNegativeInfinity(dvec5 v) => new bvec5(double.IsNegativeInfinity(v.x), double.IsNegativeInfinity(v.y), double.IsNegativeInfinity(v.z), double.IsNegativeInfinity(v.w), double.IsNegativeInfinity(v.v));
        
        /// <summary>
        /// Returns a bvec from the application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec5 IsNegativeInfinity(double v) => new bvec5(double.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec5 IsPositiveInfinity(dvec5 v) => new bvec5(double.IsPositiveInfinity(v.x), double.IsPositiveInfinity(v.y), double.IsPositiveInfinity(v.z), double.IsPositiveInfinity(v.w), double.IsPositiveInfinity(v.v));
        
        /// <summary>
        /// Returns a bvec from the application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec5 IsPositiveInfinity(double v) => new bvec5(double.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static dvec5 Abs(dvec5 v) => new dvec5(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z), Math.Abs(v.w), Math.Abs(v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Abs (Math.Abs(v)).
        /// </summary>
        public static dvec5 Abs(double v) => new dvec5(Math.Abs(v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static dvec5 HermiteInterpolationOrder3(dvec5 v) => new dvec5((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w, (3 - 2 * v.v) * v.v * v.v);
        
        /// <summary>
        /// Returns a dvec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static dvec5 HermiteInterpolationOrder3(double v) => new dvec5((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static dvec5 HermiteInterpolationOrder5(dvec5 v) => new dvec5(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w, ((6 * v.v - 15) * v.v + 10) * v.v * v.v * v.v);
        
        /// <summary>
        /// Returns a dvec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static dvec5 HermiteInterpolationOrder5(double v) => new dvec5(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static dvec5 Sqr(dvec5 v) => new dvec5(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w, v.v * v.v);
        
        /// <summary>
        /// Returns a dvec from the application of Sqr (v * v).
        /// </summary>
        public static dvec5 Sqr(double v) => new dvec5(v * v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static dvec5 Pow2(dvec5 v) => new dvec5(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w, v.v * v.v);
        
        /// <summary>
        /// Returns a dvec from the application of Pow2 (v * v).
        /// </summary>
        public static dvec5 Pow2(double v) => new dvec5(v * v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static dvec5 Pow3(dvec5 v) => new dvec5(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w, v.v * v.v * v.v);
        
        /// <summary>
        /// Returns a dvec from the application of Pow3 (v * v * v).
        /// </summary>
        public static dvec5 Pow3(double v) => new dvec5(v * v * v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static dvec5 Step(dvec5 v) => new dvec5(v.x >= 0.0 ? 1.0 : 0.0, v.y >= 0.0 ? 1.0 : 0.0, v.z >= 0.0 ? 1.0 : 0.0, v.w >= 0.0 ? 1.0 : 0.0, v.v >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a dvec from the application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static dvec5 Step(double v) => new dvec5(v >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sqrt ((double)Math.Sqrt((double)v)).
        /// </summary>
        public static dvec5 Sqrt(dvec5 v) => new dvec5((double)Math.Sqrt((double)v.x), (double)Math.Sqrt((double)v.y), (double)Math.Sqrt((double)v.z), (double)Math.Sqrt((double)v.w), (double)Math.Sqrt((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Sqrt ((double)Math.Sqrt((double)v)).
        /// </summary>
        public static dvec5 Sqrt(double v) => new dvec5((double)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of InverseSqrt ((double)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static dvec5 InverseSqrt(dvec5 v) => new dvec5((double)(1.0 / Math.Sqrt((double)v.x)), (double)(1.0 / Math.Sqrt((double)v.y)), (double)(1.0 / Math.Sqrt((double)v.z)), (double)(1.0 / Math.Sqrt((double)v.w)), (double)(1.0 / Math.Sqrt((double)v.v)));
        
        /// <summary>
        /// Returns a dvec from the application of InverseSqrt ((double)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static dvec5 InverseSqrt(double v) => new dvec5((double)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec5 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(dvec5 v) => new ivec5(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z), Math.Sign(v.w), Math.Sign(v.v));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec5 Sign(double v) => new ivec5(Math.Sign(v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec5 Max(dvec5 lhs, dvec5 rhs) => new dvec5(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z), Math.Max(lhs.w, rhs.w), Math.Max(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec5 Max(dvec5 lhs, double rhs) => new dvec5(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs), Math.Max(lhs.z, rhs), Math.Max(lhs.w, rhs), Math.Max(lhs.v, rhs));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec5 Max(double lhs, dvec5 rhs) => new dvec5(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y), Math.Max(lhs, rhs.z), Math.Max(lhs, rhs.w), Math.Max(lhs, rhs.v));
        
        /// <summary>
        /// Returns a dvec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec5 Max(double lhs, double rhs) => new dvec5(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec5 Min(dvec5 lhs, dvec5 rhs) => new dvec5(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z), Math.Min(lhs.w, rhs.w), Math.Min(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec5 Min(dvec5 lhs, double rhs) => new dvec5(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs), Math.Min(lhs.z, rhs), Math.Min(lhs.w, rhs), Math.Min(lhs.v, rhs));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec5 Min(double lhs, dvec5 rhs) => new dvec5(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y), Math.Min(lhs, rhs.z), Math.Min(lhs, rhs.w), Math.Min(lhs, rhs.v));
        
        /// <summary>
        /// Returns a dvec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec5 Min(double lhs, double rhs) => new dvec5(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec5 Pow(dvec5 lhs, dvec5 rhs) => new dvec5((double)Math.Pow((double)lhs.x, (double)rhs.x), (double)Math.Pow((double)lhs.y, (double)rhs.y), (double)Math.Pow((double)lhs.z, (double)rhs.z), (double)Math.Pow((double)lhs.w, (double)rhs.w), (double)Math.Pow((double)lhs.v, (double)rhs.v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec5 Pow(dvec5 lhs, double rhs) => new dvec5((double)Math.Pow((double)lhs.x, (double)rhs), (double)Math.Pow((double)lhs.y, (double)rhs), (double)Math.Pow((double)lhs.z, (double)rhs), (double)Math.Pow((double)lhs.w, (double)rhs), (double)Math.Pow((double)lhs.v, (double)rhs));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec5 Pow(double lhs, dvec5 rhs) => new dvec5((double)Math.Pow((double)lhs, (double)rhs.x), (double)Math.Pow((double)lhs, (double)rhs.y), (double)Math.Pow((double)lhs, (double)rhs.z), (double)Math.Pow((double)lhs, (double)rhs.w), (double)Math.Pow((double)lhs, (double)rhs.v));
        
        /// <summary>
        /// Returns a dvec from the application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec5 Pow(double lhs, double rhs) => new dvec5((double)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec5 Log(dvec5 lhs, dvec5 rhs) => new dvec5((double)Math.Log((double)lhs.x, (double)rhs.x), (double)Math.Log((double)lhs.y, (double)rhs.y), (double)Math.Log((double)lhs.z, (double)rhs.z), (double)Math.Log((double)lhs.w, (double)rhs.w), (double)Math.Log((double)lhs.v, (double)rhs.v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec5 Log(dvec5 lhs, double rhs) => new dvec5((double)Math.Log((double)lhs.x, (double)rhs), (double)Math.Log((double)lhs.y, (double)rhs), (double)Math.Log((double)lhs.z, (double)rhs), (double)Math.Log((double)lhs.w, (double)rhs), (double)Math.Log((double)lhs.v, (double)rhs));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec5 Log(double lhs, dvec5 rhs) => new dvec5((double)Math.Log((double)lhs, (double)rhs.x), (double)Math.Log((double)lhs, (double)rhs.y), (double)Math.Log((double)lhs, (double)rhs.z), (double)Math.Log((double)lhs, (double)rhs.w), (double)Math.Log((double)lhs, (double)rhs.v));
        
        /// <summary>
        /// Returns a dvec from the application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec5 Log(double lhs, double rhs) => new dvec5((double)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec5 Clamp(dvec5 v, dvec5 min, dvec5 max) => new dvec5(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z), Math.Min(Math.Max(v.w, min.w), max.w), Math.Min(Math.Max(v.v, min.v), max.v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec5 Clamp(dvec5 v, dvec5 min, double max) => new dvec5(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max), Math.Min(Math.Max(v.w, min.w), max), Math.Min(Math.Max(v.v, min.v), max));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec5 Clamp(dvec5 v, double min, dvec5 max) => new dvec5(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z), Math.Min(Math.Max(v.w, min), max.w), Math.Min(Math.Max(v.v, min), max.v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec5 Clamp(dvec5 v, double min, double max) => new dvec5(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max), Math.Min(Math.Max(v.w, min), max), Math.Min(Math.Max(v.v, min), max));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec5 Clamp(double v, dvec5 min, dvec5 max) => new dvec5(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z), Math.Min(Math.Max(v, min.w), max.w), Math.Min(Math.Max(v, min.v), max.v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec5 Clamp(double v, dvec5 min, double max) => new dvec5(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max), Math.Min(Math.Max(v, min.w), max), Math.Min(Math.Max(v, min.v), max));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec5 Clamp(double v, double min, dvec5 max) => new dvec5(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z), Math.Min(Math.Max(v, min), max.w), Math.Min(Math.Max(v, min), max.v));
        
        /// <summary>
        /// Returns a dvec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec5 Clamp(double v, double min, double max) => new dvec5(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Mix(dvec5 min, dvec5 max, dvec5 a) => new dvec5(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w, min.v * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Mix(dvec5 min, dvec5 max, double a) => new dvec5(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a, min.v * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Mix(dvec5 min, double max, dvec5 a) => new dvec5(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w, min.v * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Mix(dvec5 min, double max, double a) => new dvec5(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a, min.v * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Mix(double min, dvec5 max, dvec5 a) => new dvec5(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w, min * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Mix(double min, dvec5 max, double a) => new dvec5(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a, min * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Mix(double min, double max, dvec5 a) => new dvec5(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w, min * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a dvec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Mix(double min, double max, double a) => new dvec5(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Lerp(dvec5 min, dvec5 max, dvec5 a) => new dvec5(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w, min.v * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Lerp(dvec5 min, dvec5 max, double a) => new dvec5(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a, min.v * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Lerp(dvec5 min, double max, dvec5 a) => new dvec5(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w, min.v * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Lerp(dvec5 min, double max, double a) => new dvec5(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a, min.v * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Lerp(double min, dvec5 max, dvec5 a) => new dvec5(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w, min * (1-a.v) + max.v * a.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Lerp(double min, dvec5 max, double a) => new dvec5(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a, min * (1-a) + max.v * a);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Lerp(double min, double max, dvec5 a) => new dvec5(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w, min * (1-a.v) + max * a.v);
        
        /// <summary>
        /// Returns a dvec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec5 Lerp(double min, double max, double a) => new dvec5(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec5 Smoothstep(dvec5 edge0, dvec5 edge1, dvec5 v) => new dvec5(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec5 Smoothstep(dvec5 edge0, dvec5 edge1, double v) => new dvec5(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec5 Smoothstep(dvec5 edge0, double edge1, dvec5 v) => new dvec5(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec5 Smoothstep(dvec5 edge0, double edge1, double v) => new dvec5(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec5 Smoothstep(double edge0, dvec5 edge1, dvec5 v) => new dvec5(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec5 Smoothstep(double edge0, dvec5 edge1, double v) => new dvec5(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec5 Smoothstep(double edge0, double edge1, dvec5 v) => new dvec5(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec5 Smoothstep(double edge0, double edge1, double v) => new dvec5(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec5 Smootherstep(dvec5 edge0, dvec5 edge1, dvec5 v) => new dvec5(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec5 Smootherstep(dvec5 edge0, dvec5 edge1, double v) => new dvec5(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.v) / (edge1.v - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec5 Smootherstep(dvec5 edge0, double edge1, dvec5 v) => new dvec5(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec5 Smootherstep(dvec5 edge0, double edge1, double v) => new dvec5(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.v) / (edge1 - edge0.v)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec5 Smootherstep(double edge0, dvec5 edge1, dvec5 v) => new dvec5(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec5 Smootherstep(double edge0, dvec5 edge1, double v) => new dvec5(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.v - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec5 Smootherstep(double edge0, double edge1, dvec5 v) => new dvec5(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec5 Smootherstep(double edge0, double edge1, double v) => new dvec5(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec5 Fma(dvec5 a, dvec5 b, dvec5 c) => new dvec5(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w, a.v * b.v + c.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec5 Fma(dvec5 a, dvec5 b, double c) => new dvec5(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c, a.v * b.v + c);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec5 Fma(dvec5 a, double b, dvec5 c) => new dvec5(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w, a.v * b + c.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec5 Fma(dvec5 a, double b, double c) => new dvec5(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c, a.v * b + c);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec5 Fma(double a, dvec5 b, dvec5 c) => new dvec5(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w, a * b.v + c.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec5 Fma(double a, dvec5 b, double c) => new dvec5(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c, a * b.v + c);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec5 Fma(double a, double b, dvec5 c) => new dvec5(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w, a * b + c.v);
        
        /// <summary>
        /// Returns a dvec from the application of Fma (a * b + c).
        /// </summary>
        public static dvec5 Fma(double a, double b, double c) => new dvec5(a * b + c);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec5 Add(dvec5 lhs, dvec5 rhs) => new dvec5(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w, lhs.v + rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec5 Add(dvec5 lhs, double rhs) => new dvec5(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs, lhs.v + rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec5 Add(double lhs, dvec5 rhs) => new dvec5(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w, lhs + rhs.v);
        
        /// <summary>
        /// Returns a dvec from the application of Add (lhs + rhs).
        /// </summary>
        public static dvec5 Add(double lhs, double rhs) => new dvec5(lhs + rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec5 Sub(dvec5 lhs, dvec5 rhs) => new dvec5(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w, lhs.v - rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec5 Sub(dvec5 lhs, double rhs) => new dvec5(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs, lhs.v - rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec5 Sub(double lhs, dvec5 rhs) => new dvec5(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w, lhs - rhs.v);
        
        /// <summary>
        /// Returns a dvec from the application of Sub (lhs - rhs).
        /// </summary>
        public static dvec5 Sub(double lhs, double rhs) => new dvec5(lhs - rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec5 Mul(dvec5 lhs, dvec5 rhs) => new dvec5(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w, lhs.v * rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec5 Mul(dvec5 lhs, double rhs) => new dvec5(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs, lhs.v * rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec5 Mul(double lhs, dvec5 rhs) => new dvec5(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w, lhs * rhs.v);
        
        /// <summary>
        /// Returns a dvec from the application of Mul (lhs * rhs).
        /// </summary>
        public static dvec5 Mul(double lhs, double rhs) => new dvec5(lhs * rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec5 Div(dvec5 lhs, dvec5 rhs) => new dvec5(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w, lhs.v / rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec5 Div(dvec5 lhs, double rhs) => new dvec5(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs, lhs.v / rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec5 Div(double lhs, dvec5 rhs) => new dvec5(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w, lhs / rhs.v);
        
        /// <summary>
        /// Returns a dvec from the application of Div (lhs / rhs).
        /// </summary>
        public static dvec5 Div(double lhs, double rhs) => new dvec5(lhs / rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec5 Modulo(dvec5 lhs, dvec5 rhs) => new dvec5(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w, lhs.v % rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec5 Modulo(dvec5 lhs, double rhs) => new dvec5(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs, lhs.v % rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec5 Modulo(double lhs, dvec5 rhs) => new dvec5(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w, lhs % rhs.v);
        
        /// <summary>
        /// Returns a dvec from the application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec5 Modulo(double lhs, double rhs) => new dvec5(lhs % rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static dvec5 Degrees(dvec5 v) => new dvec5((double)(v.x * 57.295779513082320876798154814105170332405472466564321d), (double)(v.y * 57.295779513082320876798154814105170332405472466564321d), (double)(v.z * 57.295779513082320876798154814105170332405472466564321d), (double)(v.w * 57.295779513082320876798154814105170332405472466564321d), (double)(v.v * 57.295779513082320876798154814105170332405472466564321d));
        
        /// <summary>
        /// Returns a dvec from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static dvec5 Degrees(double v) => new dvec5((double)(v * 57.295779513082320876798154814105170332405472466564321d));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static dvec5 Radians(dvec5 v) => new dvec5((double)(v.x * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.y * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.z * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.w * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.v * 0.0174532925199432957692369076848861271344287188854172d));
        
        /// <summary>
        /// Returns a dvec from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static dvec5 Radians(double v) => new dvec5((double)(v * 0.0174532925199432957692369076848861271344287188854172d));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Acos ((double)Math.Acos((double)v)).
        /// </summary>
        public static dvec5 Acos(dvec5 v) => new dvec5((double)Math.Acos((double)v.x), (double)Math.Acos((double)v.y), (double)Math.Acos((double)v.z), (double)Math.Acos((double)v.w), (double)Math.Acos((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Acos ((double)Math.Acos((double)v)).
        /// </summary>
        public static dvec5 Acos(double v) => new dvec5((double)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Asin ((double)Math.Asin((double)v)).
        /// </summary>
        public static dvec5 Asin(dvec5 v) => new dvec5((double)Math.Asin((double)v.x), (double)Math.Asin((double)v.y), (double)Math.Asin((double)v.z), (double)Math.Asin((double)v.w), (double)Math.Asin((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Asin ((double)Math.Asin((double)v)).
        /// </summary>
        public static dvec5 Asin(double v) => new dvec5((double)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Atan ((double)Math.Atan((double)v)).
        /// </summary>
        public static dvec5 Atan(dvec5 v) => new dvec5((double)Math.Atan((double)v.x), (double)Math.Atan((double)v.y), (double)Math.Atan((double)v.z), (double)Math.Atan((double)v.w), (double)Math.Atan((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Atan ((double)Math.Atan((double)v)).
        /// </summary>
        public static dvec5 Atan(double v) => new dvec5((double)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Cos ((double)Math.Cos((double)v)).
        /// </summary>
        public static dvec5 Cos(dvec5 v) => new dvec5((double)Math.Cos((double)v.x), (double)Math.Cos((double)v.y), (double)Math.Cos((double)v.z), (double)Math.Cos((double)v.w), (double)Math.Cos((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Cos ((double)Math.Cos((double)v)).
        /// </summary>
        public static dvec5 Cos(double v) => new dvec5((double)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Cosh ((double)Math.Cosh((double)v)).
        /// </summary>
        public static dvec5 Cosh(dvec5 v) => new dvec5((double)Math.Cosh((double)v.x), (double)Math.Cosh((double)v.y), (double)Math.Cosh((double)v.z), (double)Math.Cosh((double)v.w), (double)Math.Cosh((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Cosh ((double)Math.Cosh((double)v)).
        /// </summary>
        public static dvec5 Cosh(double v) => new dvec5((double)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Exp ((double)Math.Exp((double)v)).
        /// </summary>
        public static dvec5 Exp(dvec5 v) => new dvec5((double)Math.Exp((double)v.x), (double)Math.Exp((double)v.y), (double)Math.Exp((double)v.z), (double)Math.Exp((double)v.w), (double)Math.Exp((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Exp ((double)Math.Exp((double)v)).
        /// </summary>
        public static dvec5 Exp(double v) => new dvec5((double)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Log ((double)Math.Log((double)v)).
        /// </summary>
        public static dvec5 Log(dvec5 v) => new dvec5((double)Math.Log((double)v.x), (double)Math.Log((double)v.y), (double)Math.Log((double)v.z), (double)Math.Log((double)v.w), (double)Math.Log((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Log ((double)Math.Log((double)v)).
        /// </summary>
        public static dvec5 Log(double v) => new dvec5((double)Math.Log((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Log2 ((double)Math.Log((double)v, 2)).
        /// </summary>
        public static dvec5 Log2(dvec5 v) => new dvec5((double)Math.Log((double)v.x, 2), (double)Math.Log((double)v.y, 2), (double)Math.Log((double)v.z, 2), (double)Math.Log((double)v.w, 2), (double)Math.Log((double)v.v, 2));
        
        /// <summary>
        /// Returns a dvec from the application of Log2 ((double)Math.Log((double)v, 2)).
        /// </summary>
        public static dvec5 Log2(double v) => new dvec5((double)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Log10 ((double)Math.Log10((double)v)).
        /// </summary>
        public static dvec5 Log10(dvec5 v) => new dvec5((double)Math.Log10((double)v.x), (double)Math.Log10((double)v.y), (double)Math.Log10((double)v.z), (double)Math.Log10((double)v.w), (double)Math.Log10((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Log10 ((double)Math.Log10((double)v)).
        /// </summary>
        public static dvec5 Log10(double v) => new dvec5((double)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Floor ((double)Math.Floor(v)).
        /// </summary>
        public static dvec5 Floor(dvec5 v) => new dvec5((double)Math.Floor(v.x), (double)Math.Floor(v.y), (double)Math.Floor(v.z), (double)Math.Floor(v.w), (double)Math.Floor(v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Floor ((double)Math.Floor(v)).
        /// </summary>
        public static dvec5 Floor(double v) => new dvec5((double)Math.Floor(v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Ceiling ((double)Math.Ceiling(v)).
        /// </summary>
        public static dvec5 Ceiling(dvec5 v) => new dvec5((double)Math.Ceiling(v.x), (double)Math.Ceiling(v.y), (double)Math.Ceiling(v.z), (double)Math.Ceiling(v.w), (double)Math.Ceiling(v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Ceiling ((double)Math.Ceiling(v)).
        /// </summary>
        public static dvec5 Ceiling(double v) => new dvec5((double)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Round ((double)Math.Round(v)).
        /// </summary>
        public static dvec5 Round(dvec5 v) => new dvec5((double)Math.Round(v.x), (double)Math.Round(v.y), (double)Math.Round(v.z), (double)Math.Round(v.w), (double)Math.Round(v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Round ((double)Math.Round(v)).
        /// </summary>
        public static dvec5 Round(double v) => new dvec5((double)Math.Round(v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sin ((double)Math.Sin((double)v)).
        /// </summary>
        public static dvec5 Sin(dvec5 v) => new dvec5((double)Math.Sin((double)v.x), (double)Math.Sin((double)v.y), (double)Math.Sin((double)v.z), (double)Math.Sin((double)v.w), (double)Math.Sin((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Sin ((double)Math.Sin((double)v)).
        /// </summary>
        public static dvec5 Sin(double v) => new dvec5((double)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Sinh ((double)Math.Sinh((double)v)).
        /// </summary>
        public static dvec5 Sinh(dvec5 v) => new dvec5((double)Math.Sinh((double)v.x), (double)Math.Sinh((double)v.y), (double)Math.Sinh((double)v.z), (double)Math.Sinh((double)v.w), (double)Math.Sinh((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Sinh ((double)Math.Sinh((double)v)).
        /// </summary>
        public static dvec5 Sinh(double v) => new dvec5((double)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Tan ((double)Math.Tan((double)v)).
        /// </summary>
        public static dvec5 Tan(dvec5 v) => new dvec5((double)Math.Tan((double)v.x), (double)Math.Tan((double)v.y), (double)Math.Tan((double)v.z), (double)Math.Tan((double)v.w), (double)Math.Tan((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Tan ((double)Math.Tan((double)v)).
        /// </summary>
        public static dvec5 Tan(double v) => new dvec5((double)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Tanh ((double)Math.Tanh((double)v)).
        /// </summary>
        public static dvec5 Tanh(dvec5 v) => new dvec5((double)Math.Tanh((double)v.x), (double)Math.Tanh((double)v.y), (double)Math.Tanh((double)v.z), (double)Math.Tanh((double)v.w), (double)Math.Tanh((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Tanh ((double)Math.Tanh((double)v)).
        /// </summary>
        public static dvec5 Tanh(double v) => new dvec5((double)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Truncate ((double)Math.Truncate((double)v)).
        /// </summary>
        public static dvec5 Truncate(dvec5 v) => new dvec5((double)Math.Truncate((double)v.x), (double)Math.Truncate((double)v.y), (double)Math.Truncate((double)v.z), (double)Math.Truncate((double)v.w), (double)Math.Truncate((double)v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Truncate ((double)Math.Truncate((double)v)).
        /// </summary>
        public static dvec5 Truncate(double v) => new dvec5((double)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Fract ((double)(v - Math.Floor(v))).
        /// </summary>
        public static dvec5 Fract(dvec5 v) => new dvec5((double)(v.x - Math.Floor(v.x)), (double)(v.y - Math.Floor(v.y)), (double)(v.z - Math.Floor(v.z)), (double)(v.w - Math.Floor(v.w)), (double)(v.v - Math.Floor(v.v)));
        
        /// <summary>
        /// Returns a dvec from the application of Fract ((double)(v - Math.Floor(v))).
        /// </summary>
        public static dvec5 Fract(double v) => new dvec5((double)(v - Math.Floor(v)));
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static dvec5 Trunc(dvec5 v) => new dvec5((long)(v.x), (long)(v.y), (long)(v.z), (long)(v.w), (long)(v.v));
        
        /// <summary>
        /// Returns a dvec from the application of Trunc ((long)(v)).
        /// </summary>
        public static dvec5 Trunc(double v) => new dvec5((long)(v));
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec5 Random(Random random, dvec5 minValue, dvec5 maxValue) => new dvec5((double)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w, (double)random.NextDouble() * (maxValue.v - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec5 Random(Random random, dvec5 minValue, double maxValue) => new dvec5((double)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue - minValue.w) + minValue.w, (double)random.NextDouble() * (maxValue - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec5 Random(Random random, double minValue, dvec5 maxValue) => new dvec5((double)random.NextDouble() * (maxValue.x - minValue) + minValue, (double)random.NextDouble() * (maxValue.y - minValue) + minValue, (double)random.NextDouble() * (maxValue.z - minValue) + minValue, (double)random.NextDouble() * (maxValue.w - minValue) + minValue, (double)random.NextDouble() * (maxValue.v - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec5 Random(Random random, double minValue, double maxValue) => new dvec5((double)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec5 RandomUniform(Random random, dvec5 minValue, dvec5 maxValue) => new dvec5((double)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w, (double)random.NextDouble() * (maxValue.v - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec5 RandomUniform(Random random, dvec5 minValue, double maxValue) => new dvec5((double)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue - minValue.w) + minValue.w, (double)random.NextDouble() * (maxValue - minValue.v) + minValue.v);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec5 RandomUniform(Random random, double minValue, dvec5 maxValue) => new dvec5((double)random.NextDouble() * (maxValue.x - minValue) + minValue, (double)random.NextDouble() * (maxValue.y - minValue) + minValue, (double)random.NextDouble() * (maxValue.z - minValue) + minValue, (double)random.NextDouble() * (maxValue.w - minValue) + minValue, (double)random.NextDouble() * (maxValue.v - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec5 RandomUniform(Random random, double minValue, double maxValue) => new dvec5((double)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec5 RandomNormal(Random random, dvec5 mean, dvec5 variance) => new dvec5((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (double)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (double)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (double)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec5 RandomNormal(Random random, dvec5 mean, double variance) => new dvec5((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec5 RandomNormal(Random random, double mean, dvec5 variance) => new dvec5((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec5 RandomNormal(Random random, double mean, double variance) => new dvec5((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec5 RandomGaussian(Random random, dvec5 mean, dvec5 variance) => new dvec5((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (double)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (double)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (double)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec5 RandomGaussian(Random random, dvec5 mean, double variance) => new dvec5((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.w, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.v);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec5 RandomGaussian(Random random, double mean, dvec5 variance) => new dvec5((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.w) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.v) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a dvec5 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec5 RandomGaussian(Random random, double mean, double variance) => new dvec5((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(dvec5 lhs, dvec5 rhs) => new bvec5(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w, lhs.v < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(dvec5 lhs, double rhs) => new bvec5(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs, lhs.v < rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec5 operator<(double lhs, dvec5 rhs) => new bvec5(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w, lhs < rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(dvec5 lhs, dvec5 rhs) => new bvec5(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w, lhs.v <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(dvec5 lhs, double rhs) => new bvec5(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs, lhs.v <= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec5 operator<=(double lhs, dvec5 rhs) => new bvec5(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w, lhs <= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(dvec5 lhs, dvec5 rhs) => new bvec5(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w, lhs.v > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(dvec5 lhs, double rhs) => new bvec5(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs, lhs.v > rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec5 operator>(double lhs, dvec5 rhs) => new bvec5(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w, lhs > rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(dvec5 lhs, dvec5 rhs) => new bvec5(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w, lhs.v >= rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(dvec5 lhs, double rhs) => new bvec5(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs, lhs.v >= rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec5 operator>=(double lhs, dvec5 rhs) => new bvec5(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w, lhs >= rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static dvec5 operator+(dvec5 lhs, dvec5 rhs) => new dvec5(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w, lhs.v + rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static dvec5 operator+(dvec5 lhs, double rhs) => new dvec5(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs, lhs.v + rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static dvec5 operator+(double lhs, dvec5 rhs) => new dvec5(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w, lhs + rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static dvec5 operator-(dvec5 lhs, dvec5 rhs) => new dvec5(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w, lhs.v - rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static dvec5 operator-(dvec5 lhs, double rhs) => new dvec5(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs, lhs.v - rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static dvec5 operator-(double lhs, dvec5 rhs) => new dvec5(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w, lhs - rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static dvec5 operator*(dvec5 lhs, dvec5 rhs) => new dvec5(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w, lhs.v * rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static dvec5 operator*(dvec5 lhs, double rhs) => new dvec5(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs, lhs.v * rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static dvec5 operator*(double lhs, dvec5 rhs) => new dvec5(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w, lhs * rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static dvec5 operator/(dvec5 lhs, dvec5 rhs) => new dvec5(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w, lhs.v / rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static dvec5 operator/(dvec5 lhs, double rhs) => new dvec5(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs, lhs.v / rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static dvec5 operator/(double lhs, dvec5 rhs) => new dvec5(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w, lhs / rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator+ (identity).
        /// </summary>
        public static dvec5 operator+(dvec5 v) => v;
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator- (-v).
        /// </summary>
        public static dvec5 operator-(dvec5 v) => new dvec5(-v.x, -v.y, -v.z, -v.w, -v.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static dvec5 operator%(dvec5 lhs, dvec5 rhs) => new dvec5(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w, lhs.v % rhs.v);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static dvec5 operator%(dvec5 lhs, double rhs) => new dvec5(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs, lhs.v % rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static dvec5 operator%(double lhs, dvec5 rhs) => new dvec5(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w, lhs % rhs.v);

        #endregion

    }
}
