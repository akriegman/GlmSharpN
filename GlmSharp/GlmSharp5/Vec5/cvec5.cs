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
    /// A vector of type Complex with 5 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct cvec5 : IReadOnlyList<Complex>, IEquatable<cvec5>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public Complex x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public Complex y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public Complex z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public Complex w;
        
        /// <summary>
        /// v-component
        /// </summary>
        [DataMember]
        public Complex v;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public cvec5(Complex x, Complex y, Complex z, Complex w, Complex v)
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
        public cvec5(Complex v)
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
        public cvec5(cvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = Complex.Zero;
            this.w = Complex.Zero;
            this.v = Complex.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public cvec5(cvec2 ve, Complex z)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = Complex.Zero;
            this.v = Complex.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public cvec5(cvec2 ve, Complex z, Complex w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = z;
            this.w = w;
            this.v = Complex.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public cvec5(cvec2 ve, Complex z, Complex w, Complex v)
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
        public cvec5(cvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = Complex.Zero;
            this.v = Complex.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public cvec5(cvec3 ve, Complex w)
        {
            this.x = ve.x;
            this.y = ve.y;
            this.z = ve.z;
            this.w = w;
            this.v = Complex.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public cvec5(cvec3 ve, Complex w, Complex v)
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
        public cvec5(cvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
            this.v = Complex.Zero;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public cvec5(cvec4 ve, Complex v)
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
        public cvec5(cvec5 v)
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
        public cvec5(IReadOnlyList<Complex> v)
        {
            var c = v.Count;
            this.x = c < 0 ? Complex.Zero : v[0];
            this.y = c < 1 ? Complex.Zero : v[1];
            this.z = c < 2 ? Complex.Zero : v[2];
            this.w = c < 3 ? Complex.Zero : v[3];
            this.v = c < 4 ? Complex.Zero : v[4];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public cvec5(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? Complex.Zero : (Complex)v[0];
            this.y = c < 1 ? Complex.Zero : (Complex)v[1];
            this.z = c < 2 ? Complex.Zero : (Complex)v[2];
            this.w = c < 3 ? Complex.Zero : (Complex)v[3];
            this.v = c < 4 ? Complex.Zero : (Complex)v[4];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public cvec5(Complex[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? Complex.Zero : v[0];
            this.y = c < 1 ? Complex.Zero : v[1];
            this.z = c < 2 ? Complex.Zero : v[2];
            this.w = c < 3 ? Complex.Zero : v[3];
            this.v = c < 4 ? Complex.Zero : v[4];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public cvec5(Complex[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? Complex.Zero : v[0 + startIndex];
            this.y = c + startIndex < 1 ? Complex.Zero : v[1 + startIndex];
            this.z = c + startIndex < 2 ? Complex.Zero : v[2 + startIndex];
            this.w = c + startIndex < 3 ? Complex.Zero : v[3 + startIndex];
            this.v = c + startIndex < 4 ? Complex.Zero : v[4 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public cvec5(IEnumerable<Complex> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(cvec5 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(cvec5 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(cvec5 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
        /// <summary>
        /// Explicitly converts this to a Complex array.
        /// </summary>
        public static explicit operator Complex[](cvec5 v) => new [] { v.x, v.y, v.z, v.w, v.v };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](cvec5 v) => new Object[] { v.x, v.y, v.z, v.w, v.v };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public Complex this[int index]
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
        public swizzle_cvec5 swizzle => new swizzle_cvec5(x, y, z, w, v);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public cvec2 xy
        {
            get
            {
                return new cvec2(x, y);
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
        public cvec2 xz
        {
            get
            {
                return new cvec2(x, z);
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
        public cvec2 yz
        {
            get
            {
                return new cvec2(y, z);
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
        public cvec3 xyz
        {
            get
            {
                return new cvec3(x, y, z);
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
        public cvec2 xw
        {
            get
            {
                return new cvec2(x, w);
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
        public cvec2 yw
        {
            get
            {
                return new cvec2(y, w);
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
        public cvec3 xyw
        {
            get
            {
                return new cvec3(x, y, w);
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
        public cvec2 zw
        {
            get
            {
                return new cvec2(z, w);
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
        public cvec3 xzw
        {
            get
            {
                return new cvec3(x, z, w);
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
        public cvec3 yzw
        {
            get
            {
                return new cvec3(y, z, w);
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
        public cvec4 xyzw
        {
            get
            {
                return new cvec4(x, y, z, w);
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
        public cvec2 xv
        {
            get
            {
                return new cvec2(x, v);
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
        public cvec2 yv
        {
            get
            {
                return new cvec2(y, v);
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
        public cvec3 xyv
        {
            get
            {
                return new cvec3(x, y, v);
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
        public cvec2 zv
        {
            get
            {
                return new cvec2(z, v);
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
        public cvec3 xzv
        {
            get
            {
                return new cvec3(x, z, v);
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
        public cvec3 yzv
        {
            get
            {
                return new cvec3(y, z, v);
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
        public cvec4 xyzv
        {
            get
            {
                return new cvec4(x, y, z, v);
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
        public cvec2 wv
        {
            get
            {
                return new cvec2(w, v);
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
        public cvec3 xwv
        {
            get
            {
                return new cvec3(x, w, v);
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
        public cvec3 ywv
        {
            get
            {
                return new cvec3(y, w, v);
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
        public cvec4 xywv
        {
            get
            {
                return new cvec4(x, y, w, v);
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
        public cvec3 zwv
        {
            get
            {
                return new cvec3(z, w, v);
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
        public cvec4 xzwv
        {
            get
            {
                return new cvec4(x, z, w, v);
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
        public cvec4 yzwv
        {
            get
            {
                return new cvec4(y, z, w, v);
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
        public cvec5 xyzwv
        {
            get
            {
                return new cvec5(x, y, z, w, v);
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
        public cvec2 rg
        {
            get
            {
                return new cvec2(x, y);
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
        public cvec2 rb
        {
            get
            {
                return new cvec2(x, z);
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
        public cvec2 gb
        {
            get
            {
                return new cvec2(y, z);
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
        public cvec3 rgb
        {
            get
            {
                return new cvec3(x, y, z);
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
        public cvec2 ra
        {
            get
            {
                return new cvec2(x, w);
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
        public cvec2 ga
        {
            get
            {
                return new cvec2(y, w);
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
        public cvec3 rga
        {
            get
            {
                return new cvec3(x, y, w);
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
        public cvec2 ba
        {
            get
            {
                return new cvec2(z, w);
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
        public cvec3 rba
        {
            get
            {
                return new cvec3(x, z, w);
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
        public cvec3 gba
        {
            get
            {
                return new cvec3(y, z, w);
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
        public cvec4 rgba
        {
            get
            {
                return new cvec4(x, y, z, w);
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
        public cvec2 rk
        {
            get
            {
                return new cvec2(x, v);
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
        public cvec2 gk
        {
            get
            {
                return new cvec2(y, v);
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
        public cvec3 rgk
        {
            get
            {
                return new cvec3(x, y, v);
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
        public cvec2 bk
        {
            get
            {
                return new cvec2(z, v);
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
        public cvec3 rbk
        {
            get
            {
                return new cvec3(x, z, v);
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
        public cvec3 gbk
        {
            get
            {
                return new cvec3(y, z, v);
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
        public cvec4 rgbk
        {
            get
            {
                return new cvec4(x, y, z, v);
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
        public cvec2 ak
        {
            get
            {
                return new cvec2(w, v);
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
        public cvec3 rak
        {
            get
            {
                return new cvec3(x, w, v);
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
        public cvec3 gak
        {
            get
            {
                return new cvec3(y, w, v);
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
        public cvec4 rgak
        {
            get
            {
                return new cvec4(x, y, w, v);
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
        public cvec3 bak
        {
            get
            {
                return new cvec3(z, w, v);
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
        public cvec4 rbak
        {
            get
            {
                return new cvec4(x, z, w, v);
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
        public cvec4 gbak
        {
            get
            {
                return new cvec4(y, z, w, v);
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
        public cvec5 rgbak
        {
            get
            {
                return new cvec5(x, y, z, w, v);
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
        public Complex r
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
        public Complex g
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
        public Complex b
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
        public Complex a
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
        public Complex k
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
        public Complex[] Values => new[] { x, y, z, w, v };
        
        /// <summary>
        /// Returns the number of components (5).
        /// </summary>
        public int Count => 5;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)Math.Sqrt((((x.LengthSqr() + y.LengthSqr()) + z.LengthSqr()) + (w.LengthSqr() + v.LengthSqr())));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => (((x.LengthSqr() + y.LengthSqr()) + z.LengthSqr()) + (w.LengthSqr() + v.LengthSqr()));
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public Complex Sum => (((x + y) + z) + (w + v));
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)Math.Sqrt((((x.LengthSqr() + y.LengthSqr()) + z.LengthSqr()) + (w.LengthSqr() + v.LengthSqr())));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => (((x.Magnitude + y.Magnitude) + z.Magnitude) + (w.Magnitude + v.Magnitude));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt((((x.LengthSqr() + y.LengthSqr()) + z.LengthSqr()) + (w.LengthSqr() + v.LengthSqr())));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public double NormMax => Math.Max(Math.Max(Math.Max(x.Magnitude, y.Magnitude), z.Magnitude), Math.Max(w.Magnitude, v.Magnitude));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public cvec5 Normalized => this / (Complex)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public cvec5 NormalizedSafe => this == Zero ? Zero : this / (Complex)Length;
        
        /// <summary>
        /// Returns a vector containing component-wise magnitudes.
        /// </summary>
        public dvec5 Magnitude => new dvec5(x.Magnitude, y.Magnitude, z.Magnitude, w.Magnitude, v.Magnitude);
        
        /// <summary>
        /// Returns a vector containing component-wise phases.
        /// </summary>
        public dvec5 Phase => new dvec5(x.Phase, y.Phase, z.Phase, w.Phase, v.Phase);
        
        /// <summary>
        /// Returns a vector containing component-wise imaginary parts.
        /// </summary>
        public dvec5 Imaginary => new dvec5(x.Imaginary, y.Imaginary, z.Imaginary, w.Imaginary, v.Imaginary);
        
        /// <summary>
        /// Returns a vector containing component-wise real parts.
        /// </summary>
        public dvec5 Real => new dvec5(x.Real, y.Real, z.Real, w.Real, v.Real);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static cvec5 Zero { get; } = new cvec5(Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static cvec5 Ones { get; } = new cvec5(Complex.One, Complex.One, Complex.One, Complex.One, Complex.One);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static cvec5 UnitX { get; } = new cvec5(Complex.One, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static cvec5 UnitY { get; } = new cvec5(Complex.Zero, Complex.One, Complex.Zero, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static cvec5 UnitZ { get; } = new cvec5(Complex.Zero, Complex.Zero, Complex.One, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static cvec5 UnitW { get; } = new cvec5(Complex.Zero, Complex.Zero, Complex.Zero, Complex.One, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-V vector
        /// </summary>
        public static cvec5 UnitV { get; } = new cvec5(Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.One);
        
        /// <summary>
        /// Predefined all-imaginary-ones vector
        /// </summary>
        public static cvec5 ImaginaryOnes { get; } = new cvec5(Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne);
        
        /// <summary>
        /// Predefined unit-imaginary-X vector
        /// </summary>
        public static cvec5 ImaginaryUnitX { get; } = new cvec5(Complex.ImaginaryOne, Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-imaginary-Y vector
        /// </summary>
        public static cvec5 ImaginaryUnitY { get; } = new cvec5(Complex.Zero, Complex.ImaginaryOne, Complex.Zero, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-imaginary-Z vector
        /// </summary>
        public static cvec5 ImaginaryUnitZ { get; } = new cvec5(Complex.Zero, Complex.Zero, Complex.ImaginaryOne, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-imaginary-W vector
        /// </summary>
        public static cvec5 ImaginaryUnitW { get; } = new cvec5(Complex.Zero, Complex.Zero, Complex.Zero, Complex.ImaginaryOne, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-imaginary-V vector
        /// </summary>
        public static cvec5 ImaginaryUnitV { get; } = new cvec5(Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero, Complex.ImaginaryOne);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(cvec5 lhs, cvec5 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(cvec5 lhs, cvec5 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<Complex> GetEnumerator()
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
        public bool Equals(cvec5 rhs) => (((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z)) && (w.Equals(rhs.w) && v.Equals(rhs.v)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is cvec5 && Equals((cvec5) obj);
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
        public double NormP(double p) => Math.Pow((((Math.Pow((double)x.Magnitude, p) + Math.Pow((double)y.Magnitude, p)) + Math.Pow((double)z.Magnitude, p)) + (Math.Pow((double)w.Magnitude, p) + Math.Pow((double)v.Magnitude, p))), 1 / p);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(cvec5 lhs, cvec5 rhs, double eps = 0.1d) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat5x2 OuterProduct(cvec2 c, cvec5 r) => new cmat5x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w, c.x * r.v, c.y * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat2x5 OuterProduct(cvec5 c, cvec2 r) => new cmat2x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat5x3 OuterProduct(cvec3 c, cvec5 r) => new cmat5x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.x * r.v, c.y * r.v, c.z * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat3x5 OuterProduct(cvec5 c, cvec3 r) => new cmat3x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat5x4 OuterProduct(cvec4 c, cvec5 r) => new cmat5x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.x * r.v, c.y * r.v, c.z * r.v, c.w * r.v);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat4x5 OuterProduct(cvec5 c, cvec4 r) => new cmat4x5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.v * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat5 OuterProduct(cvec5 c, cvec5 r) => new cmat5(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.v * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.v * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.v * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w, c.v * r.w, c.x * r.v, c.y * r.v, c.z * r.v, c.w * r.v, c.v * r.v);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static Complex Dot(cvec5 lhs, cvec5 rhs) => (((lhs.x * Complex.Conjugate(rhs.x) + lhs.y * Complex.Conjugate(rhs.y)) + lhs.z * Complex.Conjugate(rhs.z)) + (lhs.w * Complex.Conjugate(rhs.w) + lhs.v * Complex.Conjugate(rhs.v)));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(cvec5 lhs, cvec5 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(cvec5 lhs, cvec5 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static cvec5 Reflect(cvec5 I, cvec5 N) => I - 2 * Dot(N, I) * N;

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(cvec5 lhs, cvec5 rhs) => new bvec5(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w, lhs.v == rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(cvec5 lhs, Complex rhs) => new bvec5(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs, lhs.v == rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(Complex lhs, cvec5 rhs) => new bvec5(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w, lhs == rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec5 Equal(Complex lhs, Complex rhs) => new bvec5(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(cvec5 lhs, cvec5 rhs) => new bvec5(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w, lhs.v != rhs.v);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(cvec5 lhs, Complex rhs) => new bvec5(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs, lhs.v != rhs);
        
        /// <summary>
        /// Returns a bvec5 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(Complex lhs, cvec5 rhs) => new bvec5(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w, lhs != rhs.v);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec5 NotEqual(Complex lhs, Complex rhs) => new bvec5(lhs != rhs);
        
        /// <summary>
        /// Returns a dvec5 from component-wise application of Abs (v.Magnitude).
        /// </summary>
        public static dvec5 Abs(cvec5 v) => new dvec5(v.x.Magnitude, v.y.Magnitude, v.z.Magnitude, v.w.Magnitude, v.v.Magnitude);
        
        /// <summary>
        /// Returns a dvec from the application of Abs (v.Magnitude).
        /// </summary>
        public static dvec5 Abs(Complex v) => new dvec5(v.Magnitude);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static cvec5 HermiteInterpolationOrder3(cvec5 v) => new cvec5((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w, (3 - 2 * v.v) * v.v * v.v);
        
        /// <summary>
        /// Returns a cvec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static cvec5 HermiteInterpolationOrder3(Complex v) => new cvec5((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static cvec5 HermiteInterpolationOrder5(cvec5 v) => new cvec5(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w, ((6 * v.v - 15) * v.v + 10) * v.v * v.v * v.v);
        
        /// <summary>
        /// Returns a cvec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static cvec5 HermiteInterpolationOrder5(Complex v) => new cvec5(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sqr (v * v).
        /// </summary>
        public static cvec5 Sqr(cvec5 v) => new cvec5(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w, v.v * v.v);
        
        /// <summary>
        /// Returns a cvec from the application of Sqr (v * v).
        /// </summary>
        public static cvec5 Sqr(Complex v) => new cvec5(v * v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static cvec5 Pow2(cvec5 v) => new cvec5(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w, v.v * v.v);
        
        /// <summary>
        /// Returns a cvec from the application of Pow2 (v * v).
        /// </summary>
        public static cvec5 Pow2(Complex v) => new cvec5(v * v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static cvec5 Pow3(cvec5 v) => new cvec5(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w, v.v * v.v * v.v);
        
        /// <summary>
        /// Returns a cvec from the application of Pow3 (v * v * v).
        /// </summary>
        public static cvec5 Pow3(Complex v) => new cvec5(v * v * v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Acos (Complex.Acos(v)).
        /// </summary>
        public static cvec5 Acos(cvec5 v) => new cvec5(Complex.Acos(v.x), Complex.Acos(v.y), Complex.Acos(v.z), Complex.Acos(v.w), Complex.Acos(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Acos (Complex.Acos(v)).
        /// </summary>
        public static cvec5 Acos(Complex v) => new cvec5(Complex.Acos(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Asin (Complex.Asin(v)).
        /// </summary>
        public static cvec5 Asin(cvec5 v) => new cvec5(Complex.Asin(v.x), Complex.Asin(v.y), Complex.Asin(v.z), Complex.Asin(v.w), Complex.Asin(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Asin (Complex.Asin(v)).
        /// </summary>
        public static cvec5 Asin(Complex v) => new cvec5(Complex.Asin(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Atan (Complex.Atan(v)).
        /// </summary>
        public static cvec5 Atan(cvec5 v) => new cvec5(Complex.Atan(v.x), Complex.Atan(v.y), Complex.Atan(v.z), Complex.Atan(v.w), Complex.Atan(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Atan (Complex.Atan(v)).
        /// </summary>
        public static cvec5 Atan(Complex v) => new cvec5(Complex.Atan(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Cos (Complex.Cos(v)).
        /// </summary>
        public static cvec5 Cos(cvec5 v) => new cvec5(Complex.Cos(v.x), Complex.Cos(v.y), Complex.Cos(v.z), Complex.Cos(v.w), Complex.Cos(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Cos (Complex.Cos(v)).
        /// </summary>
        public static cvec5 Cos(Complex v) => new cvec5(Complex.Cos(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Cosh (Complex.Cosh(v)).
        /// </summary>
        public static cvec5 Cosh(cvec5 v) => new cvec5(Complex.Cosh(v.x), Complex.Cosh(v.y), Complex.Cosh(v.z), Complex.Cosh(v.w), Complex.Cosh(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Cosh (Complex.Cosh(v)).
        /// </summary>
        public static cvec5 Cosh(Complex v) => new cvec5(Complex.Cosh(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Exp (Complex.Exp(v)).
        /// </summary>
        public static cvec5 Exp(cvec5 v) => new cvec5(Complex.Exp(v.x), Complex.Exp(v.y), Complex.Exp(v.z), Complex.Exp(v.w), Complex.Exp(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Exp (Complex.Exp(v)).
        /// </summary>
        public static cvec5 Exp(Complex v) => new cvec5(Complex.Exp(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Log (Complex.Log(v)).
        /// </summary>
        public static cvec5 Log(cvec5 v) => new cvec5(Complex.Log(v.x), Complex.Log(v.y), Complex.Log(v.z), Complex.Log(v.w), Complex.Log(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Log (Complex.Log(v)).
        /// </summary>
        public static cvec5 Log(Complex v) => new cvec5(Complex.Log(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Log2 (Complex.Log(v, 2.0)).
        /// </summary>
        public static cvec5 Log2(cvec5 v) => new cvec5(Complex.Log(v.x, 2.0), Complex.Log(v.y, 2.0), Complex.Log(v.z, 2.0), Complex.Log(v.w, 2.0), Complex.Log(v.v, 2.0));
        
        /// <summary>
        /// Returns a cvec from the application of Log2 (Complex.Log(v, 2.0)).
        /// </summary>
        public static cvec5 Log2(Complex v) => new cvec5(Complex.Log(v, 2.0));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Log10 (Complex.Log10(v)).
        /// </summary>
        public static cvec5 Log10(cvec5 v) => new cvec5(Complex.Log10(v.x), Complex.Log10(v.y), Complex.Log10(v.z), Complex.Log10(v.w), Complex.Log10(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Log10 (Complex.Log10(v)).
        /// </summary>
        public static cvec5 Log10(Complex v) => new cvec5(Complex.Log10(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Reciprocal (Complex.Reciprocal(v)).
        /// </summary>
        public static cvec5 Reciprocal(cvec5 v) => new cvec5(Complex.Reciprocal(v.x), Complex.Reciprocal(v.y), Complex.Reciprocal(v.z), Complex.Reciprocal(v.w), Complex.Reciprocal(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Reciprocal (Complex.Reciprocal(v)).
        /// </summary>
        public static cvec5 Reciprocal(Complex v) => new cvec5(Complex.Reciprocal(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sin (Complex.Sin(v)).
        /// </summary>
        public static cvec5 Sin(cvec5 v) => new cvec5(Complex.Sin(v.x), Complex.Sin(v.y), Complex.Sin(v.z), Complex.Sin(v.w), Complex.Sin(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Sin (Complex.Sin(v)).
        /// </summary>
        public static cvec5 Sin(Complex v) => new cvec5(Complex.Sin(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sinh (Complex.Sinh(v)).
        /// </summary>
        public static cvec5 Sinh(cvec5 v) => new cvec5(Complex.Sinh(v.x), Complex.Sinh(v.y), Complex.Sinh(v.z), Complex.Sinh(v.w), Complex.Sinh(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Sinh (Complex.Sinh(v)).
        /// </summary>
        public static cvec5 Sinh(Complex v) => new cvec5(Complex.Sinh(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sqrt (Complex.Sqrt(v)).
        /// </summary>
        public static cvec5 Sqrt(cvec5 v) => new cvec5(Complex.Sqrt(v.x), Complex.Sqrt(v.y), Complex.Sqrt(v.z), Complex.Sqrt(v.w), Complex.Sqrt(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Sqrt (Complex.Sqrt(v)).
        /// </summary>
        public static cvec5 Sqrt(Complex v) => new cvec5(Complex.Sqrt(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of InverseSqrt (Complex.One / Complex.Sqrt(v)).
        /// </summary>
        public static cvec5 InverseSqrt(cvec5 v) => new cvec5(Complex.One / Complex.Sqrt(v.x), Complex.One / Complex.Sqrt(v.y), Complex.One / Complex.Sqrt(v.z), Complex.One / Complex.Sqrt(v.w), Complex.One / Complex.Sqrt(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of InverseSqrt (Complex.One / Complex.Sqrt(v)).
        /// </summary>
        public static cvec5 InverseSqrt(Complex v) => new cvec5(Complex.One / Complex.Sqrt(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Tan (Complex.Tan(v)).
        /// </summary>
        public static cvec5 Tan(cvec5 v) => new cvec5(Complex.Tan(v.x), Complex.Tan(v.y), Complex.Tan(v.z), Complex.Tan(v.w), Complex.Tan(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Tan (Complex.Tan(v)).
        /// </summary>
        public static cvec5 Tan(Complex v) => new cvec5(Complex.Tan(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Tanh (Complex.Tanh(v)).
        /// </summary>
        public static cvec5 Tanh(cvec5 v) => new cvec5(Complex.Tanh(v.x), Complex.Tanh(v.y), Complex.Tanh(v.z), Complex.Tanh(v.w), Complex.Tanh(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Tanh (Complex.Tanh(v)).
        /// </summary>
        public static cvec5 Tanh(Complex v) => new cvec5(Complex.Tanh(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Conjugate (Complex.Conjugate(v)).
        /// </summary>
        public static cvec5 Conjugate(cvec5 v) => new cvec5(Complex.Conjugate(v.x), Complex.Conjugate(v.y), Complex.Conjugate(v.z), Complex.Conjugate(v.w), Complex.Conjugate(v.v));
        
        /// <summary>
        /// Returns a cvec from the application of Conjugate (Complex.Conjugate(v)).
        /// </summary>
        public static cvec5 Conjugate(Complex v) => new cvec5(Complex.Conjugate(v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec5 Pow(cvec5 lhs, cvec5 rhs) => new cvec5(Complex.Pow(lhs.x, rhs.x), Complex.Pow(lhs.y, rhs.y), Complex.Pow(lhs.z, rhs.z), Complex.Pow(lhs.w, rhs.w), Complex.Pow(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec5 Pow(cvec5 lhs, Complex rhs) => new cvec5(Complex.Pow(lhs.x, rhs), Complex.Pow(lhs.y, rhs), Complex.Pow(lhs.z, rhs), Complex.Pow(lhs.w, rhs), Complex.Pow(lhs.v, rhs));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec5 Pow(Complex lhs, cvec5 rhs) => new cvec5(Complex.Pow(lhs, rhs.x), Complex.Pow(lhs, rhs.y), Complex.Pow(lhs, rhs.z), Complex.Pow(lhs, rhs.w), Complex.Pow(lhs, rhs.v));
        
        /// <summary>
        /// Returns a cvec from the application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec5 Pow(Complex lhs, Complex rhs) => new cvec5(Complex.Pow(lhs, rhs));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec5 Log(cvec5 lhs, dvec5 rhs) => new cvec5(Complex.Log(lhs.x, rhs.x), Complex.Log(lhs.y, rhs.y), Complex.Log(lhs.z, rhs.z), Complex.Log(lhs.w, rhs.w), Complex.Log(lhs.v, rhs.v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec5 Log(cvec5 lhs, double rhs) => new cvec5(Complex.Log(lhs.x, rhs), Complex.Log(lhs.y, rhs), Complex.Log(lhs.z, rhs), Complex.Log(lhs.w, rhs), Complex.Log(lhs.v, rhs));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec5 Log(Complex lhs, dvec5 rhs) => new cvec5(Complex.Log(lhs, rhs.x), Complex.Log(lhs, rhs.y), Complex.Log(lhs, rhs.z), Complex.Log(lhs, rhs.w), Complex.Log(lhs, rhs.v));
        
        /// <summary>
        /// Returns a cvec from the application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec5 Log(Complex lhs, double rhs) => new cvec5(Complex.Log(lhs, rhs));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec5 FromPolarCoordinates(dvec5 magnitude, dvec5 phase) => new cvec5(Complex.FromPolarCoordinates(magnitude.x, phase.x), Complex.FromPolarCoordinates(magnitude.y, phase.y), Complex.FromPolarCoordinates(magnitude.z, phase.z), Complex.FromPolarCoordinates(magnitude.w, phase.w), Complex.FromPolarCoordinates(magnitude.v, phase.v));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec5 FromPolarCoordinates(dvec5 magnitude, double phase) => new cvec5(Complex.FromPolarCoordinates(magnitude.x, phase), Complex.FromPolarCoordinates(magnitude.y, phase), Complex.FromPolarCoordinates(magnitude.z, phase), Complex.FromPolarCoordinates(magnitude.w, phase), Complex.FromPolarCoordinates(magnitude.v, phase));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec5 FromPolarCoordinates(double magnitude, dvec5 phase) => new cvec5(Complex.FromPolarCoordinates(magnitude, phase.x), Complex.FromPolarCoordinates(magnitude, phase.y), Complex.FromPolarCoordinates(magnitude, phase.z), Complex.FromPolarCoordinates(magnitude, phase.w), Complex.FromPolarCoordinates(magnitude, phase.v));
        
        /// <summary>
        /// Returns a cvec from the application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec5 FromPolarCoordinates(double magnitude, double phase) => new cvec5(Complex.FromPolarCoordinates(magnitude, phase));
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static cvec5 Fma(cvec5 a, cvec5 b, cvec5 c) => new cvec5(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w, a.v * b.v + c.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static cvec5 Fma(cvec5 a, cvec5 b, Complex c) => new cvec5(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c, a.v * b.v + c);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static cvec5 Fma(cvec5 a, Complex b, cvec5 c) => new cvec5(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w, a.v * b + c.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static cvec5 Fma(cvec5 a, Complex b, Complex c) => new cvec5(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c, a.v * b + c);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static cvec5 Fma(Complex a, cvec5 b, cvec5 c) => new cvec5(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w, a * b.v + c.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static cvec5 Fma(Complex a, cvec5 b, Complex c) => new cvec5(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c, a * b.v + c);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static cvec5 Fma(Complex a, Complex b, cvec5 c) => new cvec5(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w, a * b + c.v);
        
        /// <summary>
        /// Returns a cvec from the application of Fma (a * b + c).
        /// </summary>
        public static cvec5 Fma(Complex a, Complex b, Complex c) => new cvec5(a * b + c);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static cvec5 Add(cvec5 lhs, cvec5 rhs) => new cvec5(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w, lhs.v + rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static cvec5 Add(cvec5 lhs, Complex rhs) => new cvec5(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs, lhs.v + rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static cvec5 Add(Complex lhs, cvec5 rhs) => new cvec5(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w, lhs + rhs.v);
        
        /// <summary>
        /// Returns a cvec from the application of Add (lhs + rhs).
        /// </summary>
        public static cvec5 Add(Complex lhs, Complex rhs) => new cvec5(lhs + rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static cvec5 Sub(cvec5 lhs, cvec5 rhs) => new cvec5(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w, lhs.v - rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static cvec5 Sub(cvec5 lhs, Complex rhs) => new cvec5(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs, lhs.v - rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static cvec5 Sub(Complex lhs, cvec5 rhs) => new cvec5(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w, lhs - rhs.v);
        
        /// <summary>
        /// Returns a cvec from the application of Sub (lhs - rhs).
        /// </summary>
        public static cvec5 Sub(Complex lhs, Complex rhs) => new cvec5(lhs - rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static cvec5 Mul(cvec5 lhs, cvec5 rhs) => new cvec5(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w, lhs.v * rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static cvec5 Mul(cvec5 lhs, Complex rhs) => new cvec5(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs, lhs.v * rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static cvec5 Mul(Complex lhs, cvec5 rhs) => new cvec5(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w, lhs * rhs.v);
        
        /// <summary>
        /// Returns a cvec from the application of Mul (lhs * rhs).
        /// </summary>
        public static cvec5 Mul(Complex lhs, Complex rhs) => new cvec5(lhs * rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static cvec5 Div(cvec5 lhs, cvec5 rhs) => new cvec5(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w, lhs.v / rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static cvec5 Div(cvec5 lhs, Complex rhs) => new cvec5(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs, lhs.v / rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static cvec5 Div(Complex lhs, cvec5 rhs) => new cvec5(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w, lhs / rhs.v);
        
        /// <summary>
        /// Returns a cvec from the application of Div (lhs / rhs).
        /// </summary>
        public static cvec5 Div(Complex lhs, Complex rhs) => new cvec5(lhs / rhs);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static cvec5 operator+(cvec5 lhs, cvec5 rhs) => new cvec5(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w, lhs.v + rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static cvec5 operator+(cvec5 lhs, Complex rhs) => new cvec5(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs, lhs.v + rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static cvec5 operator+(Complex lhs, cvec5 rhs) => new cvec5(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w, lhs + rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static cvec5 operator-(cvec5 lhs, cvec5 rhs) => new cvec5(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w, lhs.v - rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static cvec5 operator-(cvec5 lhs, Complex rhs) => new cvec5(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs, lhs.v - rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static cvec5 operator-(Complex lhs, cvec5 rhs) => new cvec5(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w, lhs - rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static cvec5 operator*(cvec5 lhs, cvec5 rhs) => new cvec5(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w, lhs.v * rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static cvec5 operator*(cvec5 lhs, Complex rhs) => new cvec5(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs, lhs.v * rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static cvec5 operator*(Complex lhs, cvec5 rhs) => new cvec5(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w, lhs * rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static cvec5 operator/(cvec5 lhs, cvec5 rhs) => new cvec5(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w, lhs.v / rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static cvec5 operator/(cvec5 lhs, Complex rhs) => new cvec5(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs, lhs.v / rhs);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static cvec5 operator/(Complex lhs, cvec5 rhs) => new cvec5(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w, lhs / rhs.v);
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator+ (identity).
        /// </summary>
        public static cvec5 operator+(cvec5 v) => v;
        
        /// <summary>
        /// Returns a cvec5 from component-wise application of operator- (-v).
        /// </summary>
        public static cvec5 operator-(cvec5 v) => new cvec5(-v.x, -v.y, -v.z, -v.w, -v.v);

        #endregion

    }
}
