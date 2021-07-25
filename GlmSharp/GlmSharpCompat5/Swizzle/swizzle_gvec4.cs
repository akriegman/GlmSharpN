using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using GlmSharp.Swizzle;

// ReSharper disable InconsistentNaming

namespace GlmSharp.Swizzle
{
    
    /// <summary>
    /// Temporary vector of type T with 4 components, used for implementing swizzling for gvec4.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_gvec4<T>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly T x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly T y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly T z;
        
        /// <summary>
        /// w-component
        /// </summary>
        internal readonly T w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_gvec4.
        /// </summary>
        internal swizzle_gvec4(T x, T y, T z, T w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns gvec4.xx swizzling.
        /// </summary>
        public gvec2<T> xx => new gvec2<T>(x, x);
        
        /// <summary>
        /// Returns gvec4.rr swizzling (equivalent to gvec4.xx).
        /// </summary>
        public gvec2<T> rr => new gvec2<T>(x, x);
        
        /// <summary>
        /// Returns gvec4.xxx swizzling.
        /// </summary>
        public gvec3<T> xxx => new gvec3<T>(x, x, x);
        
        /// <summary>
        /// Returns gvec4.rrr swizzling (equivalent to gvec4.xxx).
        /// </summary>
        public gvec3<T> rrr => new gvec3<T>(x, x, x);
        
        /// <summary>
        /// Returns gvec4.xxxx swizzling.
        /// </summary>
        public gvec4<T> xxxx => new gvec4<T>(x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.rrrr swizzling (equivalent to gvec4.xxxx).
        /// </summary>
        public gvec4<T> rrrr => new gvec4<T>(x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.xxxxx swizzling.
        /// </summary>
        public gvec5<T> xxxxx => new gvec5<T>(x, x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.rrrrr swizzling (equivalent to gvec4.xxxxx).
        /// </summary>
        public gvec5<T> rrrrr => new gvec5<T>(x, x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.xxxxy swizzling.
        /// </summary>
        public gvec5<T> xxxxy => new gvec5<T>(x, x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.rrrrg swizzling (equivalent to gvec4.xxxxy).
        /// </summary>
        public gvec5<T> rrrrg => new gvec5<T>(x, x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.xxxxz swizzling.
        /// </summary>
        public gvec5<T> xxxxz => new gvec5<T>(x, x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.rrrrb swizzling (equivalent to gvec4.xxxxz).
        /// </summary>
        public gvec5<T> rrrrb => new gvec5<T>(x, x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.xxxxw swizzling.
        /// </summary>
        public gvec5<T> xxxxw => new gvec5<T>(x, x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.rrrra swizzling (equivalent to gvec4.xxxxw).
        /// </summary>
        public gvec5<T> rrrra => new gvec5<T>(x, x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.xxxy swizzling.
        /// </summary>
        public gvec4<T> xxxy => new gvec4<T>(x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.rrrg swizzling (equivalent to gvec4.xxxy).
        /// </summary>
        public gvec4<T> rrrg => new gvec4<T>(x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.xxxyx swizzling.
        /// </summary>
        public gvec5<T> xxxyx => new gvec5<T>(x, x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.rrrgr swizzling (equivalent to gvec4.xxxyx).
        /// </summary>
        public gvec5<T> rrrgr => new gvec5<T>(x, x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.xxxyy swizzling.
        /// </summary>
        public gvec5<T> xxxyy => new gvec5<T>(x, x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.rrrgg swizzling (equivalent to gvec4.xxxyy).
        /// </summary>
        public gvec5<T> rrrgg => new gvec5<T>(x, x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.xxxyz swizzling.
        /// </summary>
        public gvec5<T> xxxyz => new gvec5<T>(x, x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.rrrgb swizzling (equivalent to gvec4.xxxyz).
        /// </summary>
        public gvec5<T> rrrgb => new gvec5<T>(x, x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.xxxyw swizzling.
        /// </summary>
        public gvec5<T> xxxyw => new gvec5<T>(x, x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.rrrga swizzling (equivalent to gvec4.xxxyw).
        /// </summary>
        public gvec5<T> rrrga => new gvec5<T>(x, x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.xxxz swizzling.
        /// </summary>
        public gvec4<T> xxxz => new gvec4<T>(x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.rrrb swizzling (equivalent to gvec4.xxxz).
        /// </summary>
        public gvec4<T> rrrb => new gvec4<T>(x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.xxxzx swizzling.
        /// </summary>
        public gvec5<T> xxxzx => new gvec5<T>(x, x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.rrrbr swizzling (equivalent to gvec4.xxxzx).
        /// </summary>
        public gvec5<T> rrrbr => new gvec5<T>(x, x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.xxxzy swizzling.
        /// </summary>
        public gvec5<T> xxxzy => new gvec5<T>(x, x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.rrrbg swizzling (equivalent to gvec4.xxxzy).
        /// </summary>
        public gvec5<T> rrrbg => new gvec5<T>(x, x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.xxxzz swizzling.
        /// </summary>
        public gvec5<T> xxxzz => new gvec5<T>(x, x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.rrrbb swizzling (equivalent to gvec4.xxxzz).
        /// </summary>
        public gvec5<T> rrrbb => new gvec5<T>(x, x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.xxxzw swizzling.
        /// </summary>
        public gvec5<T> xxxzw => new gvec5<T>(x, x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.rrrba swizzling (equivalent to gvec4.xxxzw).
        /// </summary>
        public gvec5<T> rrrba => new gvec5<T>(x, x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.xxxw swizzling.
        /// </summary>
        public gvec4<T> xxxw => new gvec4<T>(x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.rrra swizzling (equivalent to gvec4.xxxw).
        /// </summary>
        public gvec4<T> rrra => new gvec4<T>(x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.xxxwx swizzling.
        /// </summary>
        public gvec5<T> xxxwx => new gvec5<T>(x, x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.rrrar swizzling (equivalent to gvec4.xxxwx).
        /// </summary>
        public gvec5<T> rrrar => new gvec5<T>(x, x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.xxxwy swizzling.
        /// </summary>
        public gvec5<T> xxxwy => new gvec5<T>(x, x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.rrrag swizzling (equivalent to gvec4.xxxwy).
        /// </summary>
        public gvec5<T> rrrag => new gvec5<T>(x, x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.xxxwz swizzling.
        /// </summary>
        public gvec5<T> xxxwz => new gvec5<T>(x, x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.rrrab swizzling (equivalent to gvec4.xxxwz).
        /// </summary>
        public gvec5<T> rrrab => new gvec5<T>(x, x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.xxxww swizzling.
        /// </summary>
        public gvec5<T> xxxww => new gvec5<T>(x, x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.rrraa swizzling (equivalent to gvec4.xxxww).
        /// </summary>
        public gvec5<T> rrraa => new gvec5<T>(x, x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.xxy swizzling.
        /// </summary>
        public gvec3<T> xxy => new gvec3<T>(x, x, y);
        
        /// <summary>
        /// Returns gvec4.rrg swizzling (equivalent to gvec4.xxy).
        /// </summary>
        public gvec3<T> rrg => new gvec3<T>(x, x, y);
        
        /// <summary>
        /// Returns gvec4.xxyx swizzling.
        /// </summary>
        public gvec4<T> xxyx => new gvec4<T>(x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.rrgr swizzling (equivalent to gvec4.xxyx).
        /// </summary>
        public gvec4<T> rrgr => new gvec4<T>(x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.xxyxx swizzling.
        /// </summary>
        public gvec5<T> xxyxx => new gvec5<T>(x, x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.rrgrr swizzling (equivalent to gvec4.xxyxx).
        /// </summary>
        public gvec5<T> rrgrr => new gvec5<T>(x, x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.xxyxy swizzling.
        /// </summary>
        public gvec5<T> xxyxy => new gvec5<T>(x, x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.rrgrg swizzling (equivalent to gvec4.xxyxy).
        /// </summary>
        public gvec5<T> rrgrg => new gvec5<T>(x, x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.xxyxz swizzling.
        /// </summary>
        public gvec5<T> xxyxz => new gvec5<T>(x, x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.rrgrb swizzling (equivalent to gvec4.xxyxz).
        /// </summary>
        public gvec5<T> rrgrb => new gvec5<T>(x, x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.xxyxw swizzling.
        /// </summary>
        public gvec5<T> xxyxw => new gvec5<T>(x, x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.rrgra swizzling (equivalent to gvec4.xxyxw).
        /// </summary>
        public gvec5<T> rrgra => new gvec5<T>(x, x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.xxyy swizzling.
        /// </summary>
        public gvec4<T> xxyy => new gvec4<T>(x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.rrgg swizzling (equivalent to gvec4.xxyy).
        /// </summary>
        public gvec4<T> rrgg => new gvec4<T>(x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.xxyyx swizzling.
        /// </summary>
        public gvec5<T> xxyyx => new gvec5<T>(x, x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.rrggr swizzling (equivalent to gvec4.xxyyx).
        /// </summary>
        public gvec5<T> rrggr => new gvec5<T>(x, x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.xxyyy swizzling.
        /// </summary>
        public gvec5<T> xxyyy => new gvec5<T>(x, x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.rrggg swizzling (equivalent to gvec4.xxyyy).
        /// </summary>
        public gvec5<T> rrggg => new gvec5<T>(x, x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.xxyyz swizzling.
        /// </summary>
        public gvec5<T> xxyyz => new gvec5<T>(x, x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.rrggb swizzling (equivalent to gvec4.xxyyz).
        /// </summary>
        public gvec5<T> rrggb => new gvec5<T>(x, x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.xxyyw swizzling.
        /// </summary>
        public gvec5<T> xxyyw => new gvec5<T>(x, x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.rrgga swizzling (equivalent to gvec4.xxyyw).
        /// </summary>
        public gvec5<T> rrgga => new gvec5<T>(x, x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.xxyz swizzling.
        /// </summary>
        public gvec4<T> xxyz => new gvec4<T>(x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.rrgb swizzling (equivalent to gvec4.xxyz).
        /// </summary>
        public gvec4<T> rrgb => new gvec4<T>(x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.xxyzx swizzling.
        /// </summary>
        public gvec5<T> xxyzx => new gvec5<T>(x, x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.rrgbr swizzling (equivalent to gvec4.xxyzx).
        /// </summary>
        public gvec5<T> rrgbr => new gvec5<T>(x, x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.xxyzy swizzling.
        /// </summary>
        public gvec5<T> xxyzy => new gvec5<T>(x, x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.rrgbg swizzling (equivalent to gvec4.xxyzy).
        /// </summary>
        public gvec5<T> rrgbg => new gvec5<T>(x, x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.xxyzz swizzling.
        /// </summary>
        public gvec5<T> xxyzz => new gvec5<T>(x, x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.rrgbb swizzling (equivalent to gvec4.xxyzz).
        /// </summary>
        public gvec5<T> rrgbb => new gvec5<T>(x, x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.xxyzw swizzling.
        /// </summary>
        public gvec5<T> xxyzw => new gvec5<T>(x, x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.rrgba swizzling (equivalent to gvec4.xxyzw).
        /// </summary>
        public gvec5<T> rrgba => new gvec5<T>(x, x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.xxyw swizzling.
        /// </summary>
        public gvec4<T> xxyw => new gvec4<T>(x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.rrga swizzling (equivalent to gvec4.xxyw).
        /// </summary>
        public gvec4<T> rrga => new gvec4<T>(x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.xxywx swizzling.
        /// </summary>
        public gvec5<T> xxywx => new gvec5<T>(x, x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.rrgar swizzling (equivalent to gvec4.xxywx).
        /// </summary>
        public gvec5<T> rrgar => new gvec5<T>(x, x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.xxywy swizzling.
        /// </summary>
        public gvec5<T> xxywy => new gvec5<T>(x, x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.rrgag swizzling (equivalent to gvec4.xxywy).
        /// </summary>
        public gvec5<T> rrgag => new gvec5<T>(x, x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.xxywz swizzling.
        /// </summary>
        public gvec5<T> xxywz => new gvec5<T>(x, x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.rrgab swizzling (equivalent to gvec4.xxywz).
        /// </summary>
        public gvec5<T> rrgab => new gvec5<T>(x, x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.xxyww swizzling.
        /// </summary>
        public gvec5<T> xxyww => new gvec5<T>(x, x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.rrgaa swizzling (equivalent to gvec4.xxyww).
        /// </summary>
        public gvec5<T> rrgaa => new gvec5<T>(x, x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.xxz swizzling.
        /// </summary>
        public gvec3<T> xxz => new gvec3<T>(x, x, z);
        
        /// <summary>
        /// Returns gvec4.rrb swizzling (equivalent to gvec4.xxz).
        /// </summary>
        public gvec3<T> rrb => new gvec3<T>(x, x, z);
        
        /// <summary>
        /// Returns gvec4.xxzx swizzling.
        /// </summary>
        public gvec4<T> xxzx => new gvec4<T>(x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.rrbr swizzling (equivalent to gvec4.xxzx).
        /// </summary>
        public gvec4<T> rrbr => new gvec4<T>(x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.xxzxx swizzling.
        /// </summary>
        public gvec5<T> xxzxx => new gvec5<T>(x, x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.rrbrr swizzling (equivalent to gvec4.xxzxx).
        /// </summary>
        public gvec5<T> rrbrr => new gvec5<T>(x, x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.xxzxy swizzling.
        /// </summary>
        public gvec5<T> xxzxy => new gvec5<T>(x, x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.rrbrg swizzling (equivalent to gvec4.xxzxy).
        /// </summary>
        public gvec5<T> rrbrg => new gvec5<T>(x, x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.xxzxz swizzling.
        /// </summary>
        public gvec5<T> xxzxz => new gvec5<T>(x, x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.rrbrb swizzling (equivalent to gvec4.xxzxz).
        /// </summary>
        public gvec5<T> rrbrb => new gvec5<T>(x, x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.xxzxw swizzling.
        /// </summary>
        public gvec5<T> xxzxw => new gvec5<T>(x, x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.rrbra swizzling (equivalent to gvec4.xxzxw).
        /// </summary>
        public gvec5<T> rrbra => new gvec5<T>(x, x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.xxzy swizzling.
        /// </summary>
        public gvec4<T> xxzy => new gvec4<T>(x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.rrbg swizzling (equivalent to gvec4.xxzy).
        /// </summary>
        public gvec4<T> rrbg => new gvec4<T>(x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.xxzyx swizzling.
        /// </summary>
        public gvec5<T> xxzyx => new gvec5<T>(x, x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.rrbgr swizzling (equivalent to gvec4.xxzyx).
        /// </summary>
        public gvec5<T> rrbgr => new gvec5<T>(x, x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.xxzyy swizzling.
        /// </summary>
        public gvec5<T> xxzyy => new gvec5<T>(x, x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.rrbgg swizzling (equivalent to gvec4.xxzyy).
        /// </summary>
        public gvec5<T> rrbgg => new gvec5<T>(x, x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.xxzyz swizzling.
        /// </summary>
        public gvec5<T> xxzyz => new gvec5<T>(x, x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.rrbgb swizzling (equivalent to gvec4.xxzyz).
        /// </summary>
        public gvec5<T> rrbgb => new gvec5<T>(x, x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.xxzyw swizzling.
        /// </summary>
        public gvec5<T> xxzyw => new gvec5<T>(x, x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.rrbga swizzling (equivalent to gvec4.xxzyw).
        /// </summary>
        public gvec5<T> rrbga => new gvec5<T>(x, x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.xxzz swizzling.
        /// </summary>
        public gvec4<T> xxzz => new gvec4<T>(x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.rrbb swizzling (equivalent to gvec4.xxzz).
        /// </summary>
        public gvec4<T> rrbb => new gvec4<T>(x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.xxzzx swizzling.
        /// </summary>
        public gvec5<T> xxzzx => new gvec5<T>(x, x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.rrbbr swizzling (equivalent to gvec4.xxzzx).
        /// </summary>
        public gvec5<T> rrbbr => new gvec5<T>(x, x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.xxzzy swizzling.
        /// </summary>
        public gvec5<T> xxzzy => new gvec5<T>(x, x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.rrbbg swizzling (equivalent to gvec4.xxzzy).
        /// </summary>
        public gvec5<T> rrbbg => new gvec5<T>(x, x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.xxzzz swizzling.
        /// </summary>
        public gvec5<T> xxzzz => new gvec5<T>(x, x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.rrbbb swizzling (equivalent to gvec4.xxzzz).
        /// </summary>
        public gvec5<T> rrbbb => new gvec5<T>(x, x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.xxzzw swizzling.
        /// </summary>
        public gvec5<T> xxzzw => new gvec5<T>(x, x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.rrbba swizzling (equivalent to gvec4.xxzzw).
        /// </summary>
        public gvec5<T> rrbba => new gvec5<T>(x, x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.xxzw swizzling.
        /// </summary>
        public gvec4<T> xxzw => new gvec4<T>(x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.rrba swizzling (equivalent to gvec4.xxzw).
        /// </summary>
        public gvec4<T> rrba => new gvec4<T>(x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.xxzwx swizzling.
        /// </summary>
        public gvec5<T> xxzwx => new gvec5<T>(x, x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.rrbar swizzling (equivalent to gvec4.xxzwx).
        /// </summary>
        public gvec5<T> rrbar => new gvec5<T>(x, x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.xxzwy swizzling.
        /// </summary>
        public gvec5<T> xxzwy => new gvec5<T>(x, x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.rrbag swizzling (equivalent to gvec4.xxzwy).
        /// </summary>
        public gvec5<T> rrbag => new gvec5<T>(x, x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.xxzwz swizzling.
        /// </summary>
        public gvec5<T> xxzwz => new gvec5<T>(x, x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.rrbab swizzling (equivalent to gvec4.xxzwz).
        /// </summary>
        public gvec5<T> rrbab => new gvec5<T>(x, x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.xxzww swizzling.
        /// </summary>
        public gvec5<T> xxzww => new gvec5<T>(x, x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.rrbaa swizzling (equivalent to gvec4.xxzww).
        /// </summary>
        public gvec5<T> rrbaa => new gvec5<T>(x, x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.xxw swizzling.
        /// </summary>
        public gvec3<T> xxw => new gvec3<T>(x, x, w);
        
        /// <summary>
        /// Returns gvec4.rra swizzling (equivalent to gvec4.xxw).
        /// </summary>
        public gvec3<T> rra => new gvec3<T>(x, x, w);
        
        /// <summary>
        /// Returns gvec4.xxwx swizzling.
        /// </summary>
        public gvec4<T> xxwx => new gvec4<T>(x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.rrar swizzling (equivalent to gvec4.xxwx).
        /// </summary>
        public gvec4<T> rrar => new gvec4<T>(x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.xxwxx swizzling.
        /// </summary>
        public gvec5<T> xxwxx => new gvec5<T>(x, x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.rrarr swizzling (equivalent to gvec4.xxwxx).
        /// </summary>
        public gvec5<T> rrarr => new gvec5<T>(x, x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.xxwxy swizzling.
        /// </summary>
        public gvec5<T> xxwxy => new gvec5<T>(x, x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.rrarg swizzling (equivalent to gvec4.xxwxy).
        /// </summary>
        public gvec5<T> rrarg => new gvec5<T>(x, x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.xxwxz swizzling.
        /// </summary>
        public gvec5<T> xxwxz => new gvec5<T>(x, x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.rrarb swizzling (equivalent to gvec4.xxwxz).
        /// </summary>
        public gvec5<T> rrarb => new gvec5<T>(x, x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.xxwxw swizzling.
        /// </summary>
        public gvec5<T> xxwxw => new gvec5<T>(x, x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.rrara swizzling (equivalent to gvec4.xxwxw).
        /// </summary>
        public gvec5<T> rrara => new gvec5<T>(x, x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.xxwy swizzling.
        /// </summary>
        public gvec4<T> xxwy => new gvec4<T>(x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.rrag swizzling (equivalent to gvec4.xxwy).
        /// </summary>
        public gvec4<T> rrag => new gvec4<T>(x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.xxwyx swizzling.
        /// </summary>
        public gvec5<T> xxwyx => new gvec5<T>(x, x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.rragr swizzling (equivalent to gvec4.xxwyx).
        /// </summary>
        public gvec5<T> rragr => new gvec5<T>(x, x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.xxwyy swizzling.
        /// </summary>
        public gvec5<T> xxwyy => new gvec5<T>(x, x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.rragg swizzling (equivalent to gvec4.xxwyy).
        /// </summary>
        public gvec5<T> rragg => new gvec5<T>(x, x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.xxwyz swizzling.
        /// </summary>
        public gvec5<T> xxwyz => new gvec5<T>(x, x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.rragb swizzling (equivalent to gvec4.xxwyz).
        /// </summary>
        public gvec5<T> rragb => new gvec5<T>(x, x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.xxwyw swizzling.
        /// </summary>
        public gvec5<T> xxwyw => new gvec5<T>(x, x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.rraga swizzling (equivalent to gvec4.xxwyw).
        /// </summary>
        public gvec5<T> rraga => new gvec5<T>(x, x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.xxwz swizzling.
        /// </summary>
        public gvec4<T> xxwz => new gvec4<T>(x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.rrab swizzling (equivalent to gvec4.xxwz).
        /// </summary>
        public gvec4<T> rrab => new gvec4<T>(x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.xxwzx swizzling.
        /// </summary>
        public gvec5<T> xxwzx => new gvec5<T>(x, x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.rrabr swizzling (equivalent to gvec4.xxwzx).
        /// </summary>
        public gvec5<T> rrabr => new gvec5<T>(x, x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.xxwzy swizzling.
        /// </summary>
        public gvec5<T> xxwzy => new gvec5<T>(x, x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.rrabg swizzling (equivalent to gvec4.xxwzy).
        /// </summary>
        public gvec5<T> rrabg => new gvec5<T>(x, x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.xxwzz swizzling.
        /// </summary>
        public gvec5<T> xxwzz => new gvec5<T>(x, x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.rrabb swizzling (equivalent to gvec4.xxwzz).
        /// </summary>
        public gvec5<T> rrabb => new gvec5<T>(x, x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.xxwzw swizzling.
        /// </summary>
        public gvec5<T> xxwzw => new gvec5<T>(x, x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.rraba swizzling (equivalent to gvec4.xxwzw).
        /// </summary>
        public gvec5<T> rraba => new gvec5<T>(x, x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.xxww swizzling.
        /// </summary>
        public gvec4<T> xxww => new gvec4<T>(x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.rraa swizzling (equivalent to gvec4.xxww).
        /// </summary>
        public gvec4<T> rraa => new gvec4<T>(x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.xxwwx swizzling.
        /// </summary>
        public gvec5<T> xxwwx => new gvec5<T>(x, x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.rraar swizzling (equivalent to gvec4.xxwwx).
        /// </summary>
        public gvec5<T> rraar => new gvec5<T>(x, x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.xxwwy swizzling.
        /// </summary>
        public gvec5<T> xxwwy => new gvec5<T>(x, x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.rraag swizzling (equivalent to gvec4.xxwwy).
        /// </summary>
        public gvec5<T> rraag => new gvec5<T>(x, x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.xxwwz swizzling.
        /// </summary>
        public gvec5<T> xxwwz => new gvec5<T>(x, x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.rraab swizzling (equivalent to gvec4.xxwwz).
        /// </summary>
        public gvec5<T> rraab => new gvec5<T>(x, x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.xxwww swizzling.
        /// </summary>
        public gvec5<T> xxwww => new gvec5<T>(x, x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.rraaa swizzling (equivalent to gvec4.xxwww).
        /// </summary>
        public gvec5<T> rraaa => new gvec5<T>(x, x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.xy swizzling.
        /// </summary>
        public gvec2<T> xy => new gvec2<T>(x, y);
        
        /// <summary>
        /// Returns gvec4.rg swizzling (equivalent to gvec4.xy).
        /// </summary>
        public gvec2<T> rg => new gvec2<T>(x, y);
        
        /// <summary>
        /// Returns gvec4.xyx swizzling.
        /// </summary>
        public gvec3<T> xyx => new gvec3<T>(x, y, x);
        
        /// <summary>
        /// Returns gvec4.rgr swizzling (equivalent to gvec4.xyx).
        /// </summary>
        public gvec3<T> rgr => new gvec3<T>(x, y, x);
        
        /// <summary>
        /// Returns gvec4.xyxx swizzling.
        /// </summary>
        public gvec4<T> xyxx => new gvec4<T>(x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.rgrr swizzling (equivalent to gvec4.xyxx).
        /// </summary>
        public gvec4<T> rgrr => new gvec4<T>(x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.xyxxx swizzling.
        /// </summary>
        public gvec5<T> xyxxx => new gvec5<T>(x, y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.rgrrr swizzling (equivalent to gvec4.xyxxx).
        /// </summary>
        public gvec5<T> rgrrr => new gvec5<T>(x, y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.xyxxy swizzling.
        /// </summary>
        public gvec5<T> xyxxy => new gvec5<T>(x, y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.rgrrg swizzling (equivalent to gvec4.xyxxy).
        /// </summary>
        public gvec5<T> rgrrg => new gvec5<T>(x, y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.xyxxz swizzling.
        /// </summary>
        public gvec5<T> xyxxz => new gvec5<T>(x, y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.rgrrb swizzling (equivalent to gvec4.xyxxz).
        /// </summary>
        public gvec5<T> rgrrb => new gvec5<T>(x, y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.xyxxw swizzling.
        /// </summary>
        public gvec5<T> xyxxw => new gvec5<T>(x, y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.rgrra swizzling (equivalent to gvec4.xyxxw).
        /// </summary>
        public gvec5<T> rgrra => new gvec5<T>(x, y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.xyxy swizzling.
        /// </summary>
        public gvec4<T> xyxy => new gvec4<T>(x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.rgrg swizzling (equivalent to gvec4.xyxy).
        /// </summary>
        public gvec4<T> rgrg => new gvec4<T>(x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.xyxyx swizzling.
        /// </summary>
        public gvec5<T> xyxyx => new gvec5<T>(x, y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.rgrgr swizzling (equivalent to gvec4.xyxyx).
        /// </summary>
        public gvec5<T> rgrgr => new gvec5<T>(x, y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.xyxyy swizzling.
        /// </summary>
        public gvec5<T> xyxyy => new gvec5<T>(x, y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.rgrgg swizzling (equivalent to gvec4.xyxyy).
        /// </summary>
        public gvec5<T> rgrgg => new gvec5<T>(x, y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.xyxyz swizzling.
        /// </summary>
        public gvec5<T> xyxyz => new gvec5<T>(x, y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.rgrgb swizzling (equivalent to gvec4.xyxyz).
        /// </summary>
        public gvec5<T> rgrgb => new gvec5<T>(x, y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.xyxyw swizzling.
        /// </summary>
        public gvec5<T> xyxyw => new gvec5<T>(x, y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.rgrga swizzling (equivalent to gvec4.xyxyw).
        /// </summary>
        public gvec5<T> rgrga => new gvec5<T>(x, y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.xyxz swizzling.
        /// </summary>
        public gvec4<T> xyxz => new gvec4<T>(x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.rgrb swizzling (equivalent to gvec4.xyxz).
        /// </summary>
        public gvec4<T> rgrb => new gvec4<T>(x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.xyxzx swizzling.
        /// </summary>
        public gvec5<T> xyxzx => new gvec5<T>(x, y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.rgrbr swizzling (equivalent to gvec4.xyxzx).
        /// </summary>
        public gvec5<T> rgrbr => new gvec5<T>(x, y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.xyxzy swizzling.
        /// </summary>
        public gvec5<T> xyxzy => new gvec5<T>(x, y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.rgrbg swizzling (equivalent to gvec4.xyxzy).
        /// </summary>
        public gvec5<T> rgrbg => new gvec5<T>(x, y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.xyxzz swizzling.
        /// </summary>
        public gvec5<T> xyxzz => new gvec5<T>(x, y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.rgrbb swizzling (equivalent to gvec4.xyxzz).
        /// </summary>
        public gvec5<T> rgrbb => new gvec5<T>(x, y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.xyxzw swizzling.
        /// </summary>
        public gvec5<T> xyxzw => new gvec5<T>(x, y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.rgrba swizzling (equivalent to gvec4.xyxzw).
        /// </summary>
        public gvec5<T> rgrba => new gvec5<T>(x, y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.xyxw swizzling.
        /// </summary>
        public gvec4<T> xyxw => new gvec4<T>(x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.rgra swizzling (equivalent to gvec4.xyxw).
        /// </summary>
        public gvec4<T> rgra => new gvec4<T>(x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.xyxwx swizzling.
        /// </summary>
        public gvec5<T> xyxwx => new gvec5<T>(x, y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.rgrar swizzling (equivalent to gvec4.xyxwx).
        /// </summary>
        public gvec5<T> rgrar => new gvec5<T>(x, y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.xyxwy swizzling.
        /// </summary>
        public gvec5<T> xyxwy => new gvec5<T>(x, y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.rgrag swizzling (equivalent to gvec4.xyxwy).
        /// </summary>
        public gvec5<T> rgrag => new gvec5<T>(x, y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.xyxwz swizzling.
        /// </summary>
        public gvec5<T> xyxwz => new gvec5<T>(x, y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.rgrab swizzling (equivalent to gvec4.xyxwz).
        /// </summary>
        public gvec5<T> rgrab => new gvec5<T>(x, y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.xyxww swizzling.
        /// </summary>
        public gvec5<T> xyxww => new gvec5<T>(x, y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.rgraa swizzling (equivalent to gvec4.xyxww).
        /// </summary>
        public gvec5<T> rgraa => new gvec5<T>(x, y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.xyy swizzling.
        /// </summary>
        public gvec3<T> xyy => new gvec3<T>(x, y, y);
        
        /// <summary>
        /// Returns gvec4.rgg swizzling (equivalent to gvec4.xyy).
        /// </summary>
        public gvec3<T> rgg => new gvec3<T>(x, y, y);
        
        /// <summary>
        /// Returns gvec4.xyyx swizzling.
        /// </summary>
        public gvec4<T> xyyx => new gvec4<T>(x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.rggr swizzling (equivalent to gvec4.xyyx).
        /// </summary>
        public gvec4<T> rggr => new gvec4<T>(x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.xyyxx swizzling.
        /// </summary>
        public gvec5<T> xyyxx => new gvec5<T>(x, y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.rggrr swizzling (equivalent to gvec4.xyyxx).
        /// </summary>
        public gvec5<T> rggrr => new gvec5<T>(x, y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.xyyxy swizzling.
        /// </summary>
        public gvec5<T> xyyxy => new gvec5<T>(x, y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.rggrg swizzling (equivalent to gvec4.xyyxy).
        /// </summary>
        public gvec5<T> rggrg => new gvec5<T>(x, y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.xyyxz swizzling.
        /// </summary>
        public gvec5<T> xyyxz => new gvec5<T>(x, y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.rggrb swizzling (equivalent to gvec4.xyyxz).
        /// </summary>
        public gvec5<T> rggrb => new gvec5<T>(x, y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.xyyxw swizzling.
        /// </summary>
        public gvec5<T> xyyxw => new gvec5<T>(x, y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.rggra swizzling (equivalent to gvec4.xyyxw).
        /// </summary>
        public gvec5<T> rggra => new gvec5<T>(x, y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.xyyy swizzling.
        /// </summary>
        public gvec4<T> xyyy => new gvec4<T>(x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.rggg swizzling (equivalent to gvec4.xyyy).
        /// </summary>
        public gvec4<T> rggg => new gvec4<T>(x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.xyyyx swizzling.
        /// </summary>
        public gvec5<T> xyyyx => new gvec5<T>(x, y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.rgggr swizzling (equivalent to gvec4.xyyyx).
        /// </summary>
        public gvec5<T> rgggr => new gvec5<T>(x, y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.xyyyy swizzling.
        /// </summary>
        public gvec5<T> xyyyy => new gvec5<T>(x, y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.rgggg swizzling (equivalent to gvec4.xyyyy).
        /// </summary>
        public gvec5<T> rgggg => new gvec5<T>(x, y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.xyyyz swizzling.
        /// </summary>
        public gvec5<T> xyyyz => new gvec5<T>(x, y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.rgggb swizzling (equivalent to gvec4.xyyyz).
        /// </summary>
        public gvec5<T> rgggb => new gvec5<T>(x, y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.xyyyw swizzling.
        /// </summary>
        public gvec5<T> xyyyw => new gvec5<T>(x, y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.rggga swizzling (equivalent to gvec4.xyyyw).
        /// </summary>
        public gvec5<T> rggga => new gvec5<T>(x, y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.xyyz swizzling.
        /// </summary>
        public gvec4<T> xyyz => new gvec4<T>(x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.rggb swizzling (equivalent to gvec4.xyyz).
        /// </summary>
        public gvec4<T> rggb => new gvec4<T>(x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.xyyzx swizzling.
        /// </summary>
        public gvec5<T> xyyzx => new gvec5<T>(x, y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.rggbr swizzling (equivalent to gvec4.xyyzx).
        /// </summary>
        public gvec5<T> rggbr => new gvec5<T>(x, y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.xyyzy swizzling.
        /// </summary>
        public gvec5<T> xyyzy => new gvec5<T>(x, y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.rggbg swizzling (equivalent to gvec4.xyyzy).
        /// </summary>
        public gvec5<T> rggbg => new gvec5<T>(x, y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.xyyzz swizzling.
        /// </summary>
        public gvec5<T> xyyzz => new gvec5<T>(x, y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.rggbb swizzling (equivalent to gvec4.xyyzz).
        /// </summary>
        public gvec5<T> rggbb => new gvec5<T>(x, y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.xyyzw swizzling.
        /// </summary>
        public gvec5<T> xyyzw => new gvec5<T>(x, y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.rggba swizzling (equivalent to gvec4.xyyzw).
        /// </summary>
        public gvec5<T> rggba => new gvec5<T>(x, y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.xyyw swizzling.
        /// </summary>
        public gvec4<T> xyyw => new gvec4<T>(x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.rgga swizzling (equivalent to gvec4.xyyw).
        /// </summary>
        public gvec4<T> rgga => new gvec4<T>(x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.xyywx swizzling.
        /// </summary>
        public gvec5<T> xyywx => new gvec5<T>(x, y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.rggar swizzling (equivalent to gvec4.xyywx).
        /// </summary>
        public gvec5<T> rggar => new gvec5<T>(x, y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.xyywy swizzling.
        /// </summary>
        public gvec5<T> xyywy => new gvec5<T>(x, y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.rggag swizzling (equivalent to gvec4.xyywy).
        /// </summary>
        public gvec5<T> rggag => new gvec5<T>(x, y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.xyywz swizzling.
        /// </summary>
        public gvec5<T> xyywz => new gvec5<T>(x, y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.rggab swizzling (equivalent to gvec4.xyywz).
        /// </summary>
        public gvec5<T> rggab => new gvec5<T>(x, y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.xyyww swizzling.
        /// </summary>
        public gvec5<T> xyyww => new gvec5<T>(x, y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.rggaa swizzling (equivalent to gvec4.xyyww).
        /// </summary>
        public gvec5<T> rggaa => new gvec5<T>(x, y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.xyz swizzling.
        /// </summary>
        public gvec3<T> xyz => new gvec3<T>(x, y, z);
        
        /// <summary>
        /// Returns gvec4.rgb swizzling (equivalent to gvec4.xyz).
        /// </summary>
        public gvec3<T> rgb => new gvec3<T>(x, y, z);
        
        /// <summary>
        /// Returns gvec4.xyzx swizzling.
        /// </summary>
        public gvec4<T> xyzx => new gvec4<T>(x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.rgbr swizzling (equivalent to gvec4.xyzx).
        /// </summary>
        public gvec4<T> rgbr => new gvec4<T>(x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.xyzxx swizzling.
        /// </summary>
        public gvec5<T> xyzxx => new gvec5<T>(x, y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.rgbrr swizzling (equivalent to gvec4.xyzxx).
        /// </summary>
        public gvec5<T> rgbrr => new gvec5<T>(x, y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.xyzxy swizzling.
        /// </summary>
        public gvec5<T> xyzxy => new gvec5<T>(x, y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.rgbrg swizzling (equivalent to gvec4.xyzxy).
        /// </summary>
        public gvec5<T> rgbrg => new gvec5<T>(x, y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.xyzxz swizzling.
        /// </summary>
        public gvec5<T> xyzxz => new gvec5<T>(x, y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.rgbrb swizzling (equivalent to gvec4.xyzxz).
        /// </summary>
        public gvec5<T> rgbrb => new gvec5<T>(x, y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.xyzxw swizzling.
        /// </summary>
        public gvec5<T> xyzxw => new gvec5<T>(x, y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.rgbra swizzling (equivalent to gvec4.xyzxw).
        /// </summary>
        public gvec5<T> rgbra => new gvec5<T>(x, y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.xyzy swizzling.
        /// </summary>
        public gvec4<T> xyzy => new gvec4<T>(x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.rgbg swizzling (equivalent to gvec4.xyzy).
        /// </summary>
        public gvec4<T> rgbg => new gvec4<T>(x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.xyzyx swizzling.
        /// </summary>
        public gvec5<T> xyzyx => new gvec5<T>(x, y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.rgbgr swizzling (equivalent to gvec4.xyzyx).
        /// </summary>
        public gvec5<T> rgbgr => new gvec5<T>(x, y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.xyzyy swizzling.
        /// </summary>
        public gvec5<T> xyzyy => new gvec5<T>(x, y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.rgbgg swizzling (equivalent to gvec4.xyzyy).
        /// </summary>
        public gvec5<T> rgbgg => new gvec5<T>(x, y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.xyzyz swizzling.
        /// </summary>
        public gvec5<T> xyzyz => new gvec5<T>(x, y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.rgbgb swizzling (equivalent to gvec4.xyzyz).
        /// </summary>
        public gvec5<T> rgbgb => new gvec5<T>(x, y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.xyzyw swizzling.
        /// </summary>
        public gvec5<T> xyzyw => new gvec5<T>(x, y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.rgbga swizzling (equivalent to gvec4.xyzyw).
        /// </summary>
        public gvec5<T> rgbga => new gvec5<T>(x, y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.xyzz swizzling.
        /// </summary>
        public gvec4<T> xyzz => new gvec4<T>(x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.rgbb swizzling (equivalent to gvec4.xyzz).
        /// </summary>
        public gvec4<T> rgbb => new gvec4<T>(x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.xyzzx swizzling.
        /// </summary>
        public gvec5<T> xyzzx => new gvec5<T>(x, y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.rgbbr swizzling (equivalent to gvec4.xyzzx).
        /// </summary>
        public gvec5<T> rgbbr => new gvec5<T>(x, y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.xyzzy swizzling.
        /// </summary>
        public gvec5<T> xyzzy => new gvec5<T>(x, y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.rgbbg swizzling (equivalent to gvec4.xyzzy).
        /// </summary>
        public gvec5<T> rgbbg => new gvec5<T>(x, y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.xyzzz swizzling.
        /// </summary>
        public gvec5<T> xyzzz => new gvec5<T>(x, y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.rgbbb swizzling (equivalent to gvec4.xyzzz).
        /// </summary>
        public gvec5<T> rgbbb => new gvec5<T>(x, y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.xyzzw swizzling.
        /// </summary>
        public gvec5<T> xyzzw => new gvec5<T>(x, y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.rgbba swizzling (equivalent to gvec4.xyzzw).
        /// </summary>
        public gvec5<T> rgbba => new gvec5<T>(x, y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.xyzw swizzling.
        /// </summary>
        public gvec4<T> xyzw => new gvec4<T>(x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.rgba swizzling (equivalent to gvec4.xyzw).
        /// </summary>
        public gvec4<T> rgba => new gvec4<T>(x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.xyzwx swizzling.
        /// </summary>
        public gvec5<T> xyzwx => new gvec5<T>(x, y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.rgbar swizzling (equivalent to gvec4.xyzwx).
        /// </summary>
        public gvec5<T> rgbar => new gvec5<T>(x, y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.xyzwy swizzling.
        /// </summary>
        public gvec5<T> xyzwy => new gvec5<T>(x, y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.rgbag swizzling (equivalent to gvec4.xyzwy).
        /// </summary>
        public gvec5<T> rgbag => new gvec5<T>(x, y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.xyzwz swizzling.
        /// </summary>
        public gvec5<T> xyzwz => new gvec5<T>(x, y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.rgbab swizzling (equivalent to gvec4.xyzwz).
        /// </summary>
        public gvec5<T> rgbab => new gvec5<T>(x, y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.xyzww swizzling.
        /// </summary>
        public gvec5<T> xyzww => new gvec5<T>(x, y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.rgbaa swizzling (equivalent to gvec4.xyzww).
        /// </summary>
        public gvec5<T> rgbaa => new gvec5<T>(x, y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.xyw swizzling.
        /// </summary>
        public gvec3<T> xyw => new gvec3<T>(x, y, w);
        
        /// <summary>
        /// Returns gvec4.rga swizzling (equivalent to gvec4.xyw).
        /// </summary>
        public gvec3<T> rga => new gvec3<T>(x, y, w);
        
        /// <summary>
        /// Returns gvec4.xywx swizzling.
        /// </summary>
        public gvec4<T> xywx => new gvec4<T>(x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.rgar swizzling (equivalent to gvec4.xywx).
        /// </summary>
        public gvec4<T> rgar => new gvec4<T>(x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.xywxx swizzling.
        /// </summary>
        public gvec5<T> xywxx => new gvec5<T>(x, y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.rgarr swizzling (equivalent to gvec4.xywxx).
        /// </summary>
        public gvec5<T> rgarr => new gvec5<T>(x, y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.xywxy swizzling.
        /// </summary>
        public gvec5<T> xywxy => new gvec5<T>(x, y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.rgarg swizzling (equivalent to gvec4.xywxy).
        /// </summary>
        public gvec5<T> rgarg => new gvec5<T>(x, y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.xywxz swizzling.
        /// </summary>
        public gvec5<T> xywxz => new gvec5<T>(x, y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.rgarb swizzling (equivalent to gvec4.xywxz).
        /// </summary>
        public gvec5<T> rgarb => new gvec5<T>(x, y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.xywxw swizzling.
        /// </summary>
        public gvec5<T> xywxw => new gvec5<T>(x, y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.rgara swizzling (equivalent to gvec4.xywxw).
        /// </summary>
        public gvec5<T> rgara => new gvec5<T>(x, y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.xywy swizzling.
        /// </summary>
        public gvec4<T> xywy => new gvec4<T>(x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.rgag swizzling (equivalent to gvec4.xywy).
        /// </summary>
        public gvec4<T> rgag => new gvec4<T>(x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.xywyx swizzling.
        /// </summary>
        public gvec5<T> xywyx => new gvec5<T>(x, y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.rgagr swizzling (equivalent to gvec4.xywyx).
        /// </summary>
        public gvec5<T> rgagr => new gvec5<T>(x, y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.xywyy swizzling.
        /// </summary>
        public gvec5<T> xywyy => new gvec5<T>(x, y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.rgagg swizzling (equivalent to gvec4.xywyy).
        /// </summary>
        public gvec5<T> rgagg => new gvec5<T>(x, y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.xywyz swizzling.
        /// </summary>
        public gvec5<T> xywyz => new gvec5<T>(x, y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.rgagb swizzling (equivalent to gvec4.xywyz).
        /// </summary>
        public gvec5<T> rgagb => new gvec5<T>(x, y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.xywyw swizzling.
        /// </summary>
        public gvec5<T> xywyw => new gvec5<T>(x, y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.rgaga swizzling (equivalent to gvec4.xywyw).
        /// </summary>
        public gvec5<T> rgaga => new gvec5<T>(x, y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.xywz swizzling.
        /// </summary>
        public gvec4<T> xywz => new gvec4<T>(x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.rgab swizzling (equivalent to gvec4.xywz).
        /// </summary>
        public gvec4<T> rgab => new gvec4<T>(x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.xywzx swizzling.
        /// </summary>
        public gvec5<T> xywzx => new gvec5<T>(x, y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.rgabr swizzling (equivalent to gvec4.xywzx).
        /// </summary>
        public gvec5<T> rgabr => new gvec5<T>(x, y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.xywzy swizzling.
        /// </summary>
        public gvec5<T> xywzy => new gvec5<T>(x, y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.rgabg swizzling (equivalent to gvec4.xywzy).
        /// </summary>
        public gvec5<T> rgabg => new gvec5<T>(x, y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.xywzz swizzling.
        /// </summary>
        public gvec5<T> xywzz => new gvec5<T>(x, y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.rgabb swizzling (equivalent to gvec4.xywzz).
        /// </summary>
        public gvec5<T> rgabb => new gvec5<T>(x, y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.xywzw swizzling.
        /// </summary>
        public gvec5<T> xywzw => new gvec5<T>(x, y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.rgaba swizzling (equivalent to gvec4.xywzw).
        /// </summary>
        public gvec5<T> rgaba => new gvec5<T>(x, y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.xyww swizzling.
        /// </summary>
        public gvec4<T> xyww => new gvec4<T>(x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.rgaa swizzling (equivalent to gvec4.xyww).
        /// </summary>
        public gvec4<T> rgaa => new gvec4<T>(x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.xywwx swizzling.
        /// </summary>
        public gvec5<T> xywwx => new gvec5<T>(x, y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.rgaar swizzling (equivalent to gvec4.xywwx).
        /// </summary>
        public gvec5<T> rgaar => new gvec5<T>(x, y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.xywwy swizzling.
        /// </summary>
        public gvec5<T> xywwy => new gvec5<T>(x, y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.rgaag swizzling (equivalent to gvec4.xywwy).
        /// </summary>
        public gvec5<T> rgaag => new gvec5<T>(x, y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.xywwz swizzling.
        /// </summary>
        public gvec5<T> xywwz => new gvec5<T>(x, y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.rgaab swizzling (equivalent to gvec4.xywwz).
        /// </summary>
        public gvec5<T> rgaab => new gvec5<T>(x, y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.xywww swizzling.
        /// </summary>
        public gvec5<T> xywww => new gvec5<T>(x, y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.rgaaa swizzling (equivalent to gvec4.xywww).
        /// </summary>
        public gvec5<T> rgaaa => new gvec5<T>(x, y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.xz swizzling.
        /// </summary>
        public gvec2<T> xz => new gvec2<T>(x, z);
        
        /// <summary>
        /// Returns gvec4.rb swizzling (equivalent to gvec4.xz).
        /// </summary>
        public gvec2<T> rb => new gvec2<T>(x, z);
        
        /// <summary>
        /// Returns gvec4.xzx swizzling.
        /// </summary>
        public gvec3<T> xzx => new gvec3<T>(x, z, x);
        
        /// <summary>
        /// Returns gvec4.rbr swizzling (equivalent to gvec4.xzx).
        /// </summary>
        public gvec3<T> rbr => new gvec3<T>(x, z, x);
        
        /// <summary>
        /// Returns gvec4.xzxx swizzling.
        /// </summary>
        public gvec4<T> xzxx => new gvec4<T>(x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.rbrr swizzling (equivalent to gvec4.xzxx).
        /// </summary>
        public gvec4<T> rbrr => new gvec4<T>(x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.xzxxx swizzling.
        /// </summary>
        public gvec5<T> xzxxx => new gvec5<T>(x, z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.rbrrr swizzling (equivalent to gvec4.xzxxx).
        /// </summary>
        public gvec5<T> rbrrr => new gvec5<T>(x, z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.xzxxy swizzling.
        /// </summary>
        public gvec5<T> xzxxy => new gvec5<T>(x, z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.rbrrg swizzling (equivalent to gvec4.xzxxy).
        /// </summary>
        public gvec5<T> rbrrg => new gvec5<T>(x, z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.xzxxz swizzling.
        /// </summary>
        public gvec5<T> xzxxz => new gvec5<T>(x, z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.rbrrb swizzling (equivalent to gvec4.xzxxz).
        /// </summary>
        public gvec5<T> rbrrb => new gvec5<T>(x, z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.xzxxw swizzling.
        /// </summary>
        public gvec5<T> xzxxw => new gvec5<T>(x, z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.rbrra swizzling (equivalent to gvec4.xzxxw).
        /// </summary>
        public gvec5<T> rbrra => new gvec5<T>(x, z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.xzxy swizzling.
        /// </summary>
        public gvec4<T> xzxy => new gvec4<T>(x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.rbrg swizzling (equivalent to gvec4.xzxy).
        /// </summary>
        public gvec4<T> rbrg => new gvec4<T>(x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.xzxyx swizzling.
        /// </summary>
        public gvec5<T> xzxyx => new gvec5<T>(x, z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.rbrgr swizzling (equivalent to gvec4.xzxyx).
        /// </summary>
        public gvec5<T> rbrgr => new gvec5<T>(x, z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.xzxyy swizzling.
        /// </summary>
        public gvec5<T> xzxyy => new gvec5<T>(x, z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.rbrgg swizzling (equivalent to gvec4.xzxyy).
        /// </summary>
        public gvec5<T> rbrgg => new gvec5<T>(x, z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.xzxyz swizzling.
        /// </summary>
        public gvec5<T> xzxyz => new gvec5<T>(x, z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.rbrgb swizzling (equivalent to gvec4.xzxyz).
        /// </summary>
        public gvec5<T> rbrgb => new gvec5<T>(x, z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.xzxyw swizzling.
        /// </summary>
        public gvec5<T> xzxyw => new gvec5<T>(x, z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.rbrga swizzling (equivalent to gvec4.xzxyw).
        /// </summary>
        public gvec5<T> rbrga => new gvec5<T>(x, z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.xzxz swizzling.
        /// </summary>
        public gvec4<T> xzxz => new gvec4<T>(x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.rbrb swizzling (equivalent to gvec4.xzxz).
        /// </summary>
        public gvec4<T> rbrb => new gvec4<T>(x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.xzxzx swizzling.
        /// </summary>
        public gvec5<T> xzxzx => new gvec5<T>(x, z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.rbrbr swizzling (equivalent to gvec4.xzxzx).
        /// </summary>
        public gvec5<T> rbrbr => new gvec5<T>(x, z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.xzxzy swizzling.
        /// </summary>
        public gvec5<T> xzxzy => new gvec5<T>(x, z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.rbrbg swizzling (equivalent to gvec4.xzxzy).
        /// </summary>
        public gvec5<T> rbrbg => new gvec5<T>(x, z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.xzxzz swizzling.
        /// </summary>
        public gvec5<T> xzxzz => new gvec5<T>(x, z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.rbrbb swizzling (equivalent to gvec4.xzxzz).
        /// </summary>
        public gvec5<T> rbrbb => new gvec5<T>(x, z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.xzxzw swizzling.
        /// </summary>
        public gvec5<T> xzxzw => new gvec5<T>(x, z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.rbrba swizzling (equivalent to gvec4.xzxzw).
        /// </summary>
        public gvec5<T> rbrba => new gvec5<T>(x, z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.xzxw swizzling.
        /// </summary>
        public gvec4<T> xzxw => new gvec4<T>(x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.rbra swizzling (equivalent to gvec4.xzxw).
        /// </summary>
        public gvec4<T> rbra => new gvec4<T>(x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.xzxwx swizzling.
        /// </summary>
        public gvec5<T> xzxwx => new gvec5<T>(x, z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.rbrar swizzling (equivalent to gvec4.xzxwx).
        /// </summary>
        public gvec5<T> rbrar => new gvec5<T>(x, z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.xzxwy swizzling.
        /// </summary>
        public gvec5<T> xzxwy => new gvec5<T>(x, z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.rbrag swizzling (equivalent to gvec4.xzxwy).
        /// </summary>
        public gvec5<T> rbrag => new gvec5<T>(x, z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.xzxwz swizzling.
        /// </summary>
        public gvec5<T> xzxwz => new gvec5<T>(x, z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.rbrab swizzling (equivalent to gvec4.xzxwz).
        /// </summary>
        public gvec5<T> rbrab => new gvec5<T>(x, z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.xzxww swizzling.
        /// </summary>
        public gvec5<T> xzxww => new gvec5<T>(x, z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.rbraa swizzling (equivalent to gvec4.xzxww).
        /// </summary>
        public gvec5<T> rbraa => new gvec5<T>(x, z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.xzy swizzling.
        /// </summary>
        public gvec3<T> xzy => new gvec3<T>(x, z, y);
        
        /// <summary>
        /// Returns gvec4.rbg swizzling (equivalent to gvec4.xzy).
        /// </summary>
        public gvec3<T> rbg => new gvec3<T>(x, z, y);
        
        /// <summary>
        /// Returns gvec4.xzyx swizzling.
        /// </summary>
        public gvec4<T> xzyx => new gvec4<T>(x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.rbgr swizzling (equivalent to gvec4.xzyx).
        /// </summary>
        public gvec4<T> rbgr => new gvec4<T>(x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.xzyxx swizzling.
        /// </summary>
        public gvec5<T> xzyxx => new gvec5<T>(x, z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.rbgrr swizzling (equivalent to gvec4.xzyxx).
        /// </summary>
        public gvec5<T> rbgrr => new gvec5<T>(x, z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.xzyxy swizzling.
        /// </summary>
        public gvec5<T> xzyxy => new gvec5<T>(x, z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.rbgrg swizzling (equivalent to gvec4.xzyxy).
        /// </summary>
        public gvec5<T> rbgrg => new gvec5<T>(x, z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.xzyxz swizzling.
        /// </summary>
        public gvec5<T> xzyxz => new gvec5<T>(x, z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.rbgrb swizzling (equivalent to gvec4.xzyxz).
        /// </summary>
        public gvec5<T> rbgrb => new gvec5<T>(x, z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.xzyxw swizzling.
        /// </summary>
        public gvec5<T> xzyxw => new gvec5<T>(x, z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.rbgra swizzling (equivalent to gvec4.xzyxw).
        /// </summary>
        public gvec5<T> rbgra => new gvec5<T>(x, z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.xzyy swizzling.
        /// </summary>
        public gvec4<T> xzyy => new gvec4<T>(x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.rbgg swizzling (equivalent to gvec4.xzyy).
        /// </summary>
        public gvec4<T> rbgg => new gvec4<T>(x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.xzyyx swizzling.
        /// </summary>
        public gvec5<T> xzyyx => new gvec5<T>(x, z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.rbggr swizzling (equivalent to gvec4.xzyyx).
        /// </summary>
        public gvec5<T> rbggr => new gvec5<T>(x, z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.xzyyy swizzling.
        /// </summary>
        public gvec5<T> xzyyy => new gvec5<T>(x, z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.rbggg swizzling (equivalent to gvec4.xzyyy).
        /// </summary>
        public gvec5<T> rbggg => new gvec5<T>(x, z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.xzyyz swizzling.
        /// </summary>
        public gvec5<T> xzyyz => new gvec5<T>(x, z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.rbggb swizzling (equivalent to gvec4.xzyyz).
        /// </summary>
        public gvec5<T> rbggb => new gvec5<T>(x, z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.xzyyw swizzling.
        /// </summary>
        public gvec5<T> xzyyw => new gvec5<T>(x, z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.rbgga swizzling (equivalent to gvec4.xzyyw).
        /// </summary>
        public gvec5<T> rbgga => new gvec5<T>(x, z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.xzyz swizzling.
        /// </summary>
        public gvec4<T> xzyz => new gvec4<T>(x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.rbgb swizzling (equivalent to gvec4.xzyz).
        /// </summary>
        public gvec4<T> rbgb => new gvec4<T>(x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.xzyzx swizzling.
        /// </summary>
        public gvec5<T> xzyzx => new gvec5<T>(x, z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.rbgbr swizzling (equivalent to gvec4.xzyzx).
        /// </summary>
        public gvec5<T> rbgbr => new gvec5<T>(x, z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.xzyzy swizzling.
        /// </summary>
        public gvec5<T> xzyzy => new gvec5<T>(x, z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.rbgbg swizzling (equivalent to gvec4.xzyzy).
        /// </summary>
        public gvec5<T> rbgbg => new gvec5<T>(x, z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.xzyzz swizzling.
        /// </summary>
        public gvec5<T> xzyzz => new gvec5<T>(x, z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.rbgbb swizzling (equivalent to gvec4.xzyzz).
        /// </summary>
        public gvec5<T> rbgbb => new gvec5<T>(x, z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.xzyzw swizzling.
        /// </summary>
        public gvec5<T> xzyzw => new gvec5<T>(x, z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.rbgba swizzling (equivalent to gvec4.xzyzw).
        /// </summary>
        public gvec5<T> rbgba => new gvec5<T>(x, z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.xzyw swizzling.
        /// </summary>
        public gvec4<T> xzyw => new gvec4<T>(x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.rbga swizzling (equivalent to gvec4.xzyw).
        /// </summary>
        public gvec4<T> rbga => new gvec4<T>(x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.xzywx swizzling.
        /// </summary>
        public gvec5<T> xzywx => new gvec5<T>(x, z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.rbgar swizzling (equivalent to gvec4.xzywx).
        /// </summary>
        public gvec5<T> rbgar => new gvec5<T>(x, z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.xzywy swizzling.
        /// </summary>
        public gvec5<T> xzywy => new gvec5<T>(x, z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.rbgag swizzling (equivalent to gvec4.xzywy).
        /// </summary>
        public gvec5<T> rbgag => new gvec5<T>(x, z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.xzywz swizzling.
        /// </summary>
        public gvec5<T> xzywz => new gvec5<T>(x, z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.rbgab swizzling (equivalent to gvec4.xzywz).
        /// </summary>
        public gvec5<T> rbgab => new gvec5<T>(x, z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.xzyww swizzling.
        /// </summary>
        public gvec5<T> xzyww => new gvec5<T>(x, z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.rbgaa swizzling (equivalent to gvec4.xzyww).
        /// </summary>
        public gvec5<T> rbgaa => new gvec5<T>(x, z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.xzz swizzling.
        /// </summary>
        public gvec3<T> xzz => new gvec3<T>(x, z, z);
        
        /// <summary>
        /// Returns gvec4.rbb swizzling (equivalent to gvec4.xzz).
        /// </summary>
        public gvec3<T> rbb => new gvec3<T>(x, z, z);
        
        /// <summary>
        /// Returns gvec4.xzzx swizzling.
        /// </summary>
        public gvec4<T> xzzx => new gvec4<T>(x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.rbbr swizzling (equivalent to gvec4.xzzx).
        /// </summary>
        public gvec4<T> rbbr => new gvec4<T>(x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.xzzxx swizzling.
        /// </summary>
        public gvec5<T> xzzxx => new gvec5<T>(x, z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.rbbrr swizzling (equivalent to gvec4.xzzxx).
        /// </summary>
        public gvec5<T> rbbrr => new gvec5<T>(x, z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.xzzxy swizzling.
        /// </summary>
        public gvec5<T> xzzxy => new gvec5<T>(x, z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.rbbrg swizzling (equivalent to gvec4.xzzxy).
        /// </summary>
        public gvec5<T> rbbrg => new gvec5<T>(x, z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.xzzxz swizzling.
        /// </summary>
        public gvec5<T> xzzxz => new gvec5<T>(x, z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.rbbrb swizzling (equivalent to gvec4.xzzxz).
        /// </summary>
        public gvec5<T> rbbrb => new gvec5<T>(x, z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.xzzxw swizzling.
        /// </summary>
        public gvec5<T> xzzxw => new gvec5<T>(x, z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.rbbra swizzling (equivalent to gvec4.xzzxw).
        /// </summary>
        public gvec5<T> rbbra => new gvec5<T>(x, z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.xzzy swizzling.
        /// </summary>
        public gvec4<T> xzzy => new gvec4<T>(x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.rbbg swizzling (equivalent to gvec4.xzzy).
        /// </summary>
        public gvec4<T> rbbg => new gvec4<T>(x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.xzzyx swizzling.
        /// </summary>
        public gvec5<T> xzzyx => new gvec5<T>(x, z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.rbbgr swizzling (equivalent to gvec4.xzzyx).
        /// </summary>
        public gvec5<T> rbbgr => new gvec5<T>(x, z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.xzzyy swizzling.
        /// </summary>
        public gvec5<T> xzzyy => new gvec5<T>(x, z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.rbbgg swizzling (equivalent to gvec4.xzzyy).
        /// </summary>
        public gvec5<T> rbbgg => new gvec5<T>(x, z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.xzzyz swizzling.
        /// </summary>
        public gvec5<T> xzzyz => new gvec5<T>(x, z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.rbbgb swizzling (equivalent to gvec4.xzzyz).
        /// </summary>
        public gvec5<T> rbbgb => new gvec5<T>(x, z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.xzzyw swizzling.
        /// </summary>
        public gvec5<T> xzzyw => new gvec5<T>(x, z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.rbbga swizzling (equivalent to gvec4.xzzyw).
        /// </summary>
        public gvec5<T> rbbga => new gvec5<T>(x, z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.xzzz swizzling.
        /// </summary>
        public gvec4<T> xzzz => new gvec4<T>(x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.rbbb swizzling (equivalent to gvec4.xzzz).
        /// </summary>
        public gvec4<T> rbbb => new gvec4<T>(x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.xzzzx swizzling.
        /// </summary>
        public gvec5<T> xzzzx => new gvec5<T>(x, z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.rbbbr swizzling (equivalent to gvec4.xzzzx).
        /// </summary>
        public gvec5<T> rbbbr => new gvec5<T>(x, z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.xzzzy swizzling.
        /// </summary>
        public gvec5<T> xzzzy => new gvec5<T>(x, z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.rbbbg swizzling (equivalent to gvec4.xzzzy).
        /// </summary>
        public gvec5<T> rbbbg => new gvec5<T>(x, z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.xzzzz swizzling.
        /// </summary>
        public gvec5<T> xzzzz => new gvec5<T>(x, z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.rbbbb swizzling (equivalent to gvec4.xzzzz).
        /// </summary>
        public gvec5<T> rbbbb => new gvec5<T>(x, z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.xzzzw swizzling.
        /// </summary>
        public gvec5<T> xzzzw => new gvec5<T>(x, z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.rbbba swizzling (equivalent to gvec4.xzzzw).
        /// </summary>
        public gvec5<T> rbbba => new gvec5<T>(x, z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.xzzw swizzling.
        /// </summary>
        public gvec4<T> xzzw => new gvec4<T>(x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.rbba swizzling (equivalent to gvec4.xzzw).
        /// </summary>
        public gvec4<T> rbba => new gvec4<T>(x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.xzzwx swizzling.
        /// </summary>
        public gvec5<T> xzzwx => new gvec5<T>(x, z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.rbbar swizzling (equivalent to gvec4.xzzwx).
        /// </summary>
        public gvec5<T> rbbar => new gvec5<T>(x, z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.xzzwy swizzling.
        /// </summary>
        public gvec5<T> xzzwy => new gvec5<T>(x, z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.rbbag swizzling (equivalent to gvec4.xzzwy).
        /// </summary>
        public gvec5<T> rbbag => new gvec5<T>(x, z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.xzzwz swizzling.
        /// </summary>
        public gvec5<T> xzzwz => new gvec5<T>(x, z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.rbbab swizzling (equivalent to gvec4.xzzwz).
        /// </summary>
        public gvec5<T> rbbab => new gvec5<T>(x, z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.xzzww swizzling.
        /// </summary>
        public gvec5<T> xzzww => new gvec5<T>(x, z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.rbbaa swizzling (equivalent to gvec4.xzzww).
        /// </summary>
        public gvec5<T> rbbaa => new gvec5<T>(x, z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.xzw swizzling.
        /// </summary>
        public gvec3<T> xzw => new gvec3<T>(x, z, w);
        
        /// <summary>
        /// Returns gvec4.rba swizzling (equivalent to gvec4.xzw).
        /// </summary>
        public gvec3<T> rba => new gvec3<T>(x, z, w);
        
        /// <summary>
        /// Returns gvec4.xzwx swizzling.
        /// </summary>
        public gvec4<T> xzwx => new gvec4<T>(x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.rbar swizzling (equivalent to gvec4.xzwx).
        /// </summary>
        public gvec4<T> rbar => new gvec4<T>(x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.xzwxx swizzling.
        /// </summary>
        public gvec5<T> xzwxx => new gvec5<T>(x, z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.rbarr swizzling (equivalent to gvec4.xzwxx).
        /// </summary>
        public gvec5<T> rbarr => new gvec5<T>(x, z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.xzwxy swizzling.
        /// </summary>
        public gvec5<T> xzwxy => new gvec5<T>(x, z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.rbarg swizzling (equivalent to gvec4.xzwxy).
        /// </summary>
        public gvec5<T> rbarg => new gvec5<T>(x, z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.xzwxz swizzling.
        /// </summary>
        public gvec5<T> xzwxz => new gvec5<T>(x, z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.rbarb swizzling (equivalent to gvec4.xzwxz).
        /// </summary>
        public gvec5<T> rbarb => new gvec5<T>(x, z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.xzwxw swizzling.
        /// </summary>
        public gvec5<T> xzwxw => new gvec5<T>(x, z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.rbara swizzling (equivalent to gvec4.xzwxw).
        /// </summary>
        public gvec5<T> rbara => new gvec5<T>(x, z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.xzwy swizzling.
        /// </summary>
        public gvec4<T> xzwy => new gvec4<T>(x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.rbag swizzling (equivalent to gvec4.xzwy).
        /// </summary>
        public gvec4<T> rbag => new gvec4<T>(x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.xzwyx swizzling.
        /// </summary>
        public gvec5<T> xzwyx => new gvec5<T>(x, z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.rbagr swizzling (equivalent to gvec4.xzwyx).
        /// </summary>
        public gvec5<T> rbagr => new gvec5<T>(x, z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.xzwyy swizzling.
        /// </summary>
        public gvec5<T> xzwyy => new gvec5<T>(x, z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.rbagg swizzling (equivalent to gvec4.xzwyy).
        /// </summary>
        public gvec5<T> rbagg => new gvec5<T>(x, z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.xzwyz swizzling.
        /// </summary>
        public gvec5<T> xzwyz => new gvec5<T>(x, z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.rbagb swizzling (equivalent to gvec4.xzwyz).
        /// </summary>
        public gvec5<T> rbagb => new gvec5<T>(x, z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.xzwyw swizzling.
        /// </summary>
        public gvec5<T> xzwyw => new gvec5<T>(x, z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.rbaga swizzling (equivalent to gvec4.xzwyw).
        /// </summary>
        public gvec5<T> rbaga => new gvec5<T>(x, z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.xzwz swizzling.
        /// </summary>
        public gvec4<T> xzwz => new gvec4<T>(x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.rbab swizzling (equivalent to gvec4.xzwz).
        /// </summary>
        public gvec4<T> rbab => new gvec4<T>(x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.xzwzx swizzling.
        /// </summary>
        public gvec5<T> xzwzx => new gvec5<T>(x, z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.rbabr swizzling (equivalent to gvec4.xzwzx).
        /// </summary>
        public gvec5<T> rbabr => new gvec5<T>(x, z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.xzwzy swizzling.
        /// </summary>
        public gvec5<T> xzwzy => new gvec5<T>(x, z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.rbabg swizzling (equivalent to gvec4.xzwzy).
        /// </summary>
        public gvec5<T> rbabg => new gvec5<T>(x, z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.xzwzz swizzling.
        /// </summary>
        public gvec5<T> xzwzz => new gvec5<T>(x, z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.rbabb swizzling (equivalent to gvec4.xzwzz).
        /// </summary>
        public gvec5<T> rbabb => new gvec5<T>(x, z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.xzwzw swizzling.
        /// </summary>
        public gvec5<T> xzwzw => new gvec5<T>(x, z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.rbaba swizzling (equivalent to gvec4.xzwzw).
        /// </summary>
        public gvec5<T> rbaba => new gvec5<T>(x, z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.xzww swizzling.
        /// </summary>
        public gvec4<T> xzww => new gvec4<T>(x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.rbaa swizzling (equivalent to gvec4.xzww).
        /// </summary>
        public gvec4<T> rbaa => new gvec4<T>(x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.xzwwx swizzling.
        /// </summary>
        public gvec5<T> xzwwx => new gvec5<T>(x, z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.rbaar swizzling (equivalent to gvec4.xzwwx).
        /// </summary>
        public gvec5<T> rbaar => new gvec5<T>(x, z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.xzwwy swizzling.
        /// </summary>
        public gvec5<T> xzwwy => new gvec5<T>(x, z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.rbaag swizzling (equivalent to gvec4.xzwwy).
        /// </summary>
        public gvec5<T> rbaag => new gvec5<T>(x, z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.xzwwz swizzling.
        /// </summary>
        public gvec5<T> xzwwz => new gvec5<T>(x, z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.rbaab swizzling (equivalent to gvec4.xzwwz).
        /// </summary>
        public gvec5<T> rbaab => new gvec5<T>(x, z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.xzwww swizzling.
        /// </summary>
        public gvec5<T> xzwww => new gvec5<T>(x, z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.rbaaa swizzling (equivalent to gvec4.xzwww).
        /// </summary>
        public gvec5<T> rbaaa => new gvec5<T>(x, z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.xw swizzling.
        /// </summary>
        public gvec2<T> xw => new gvec2<T>(x, w);
        
        /// <summary>
        /// Returns gvec4.ra swizzling (equivalent to gvec4.xw).
        /// </summary>
        public gvec2<T> ra => new gvec2<T>(x, w);
        
        /// <summary>
        /// Returns gvec4.xwx swizzling.
        /// </summary>
        public gvec3<T> xwx => new gvec3<T>(x, w, x);
        
        /// <summary>
        /// Returns gvec4.rar swizzling (equivalent to gvec4.xwx).
        /// </summary>
        public gvec3<T> rar => new gvec3<T>(x, w, x);
        
        /// <summary>
        /// Returns gvec4.xwxx swizzling.
        /// </summary>
        public gvec4<T> xwxx => new gvec4<T>(x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.rarr swizzling (equivalent to gvec4.xwxx).
        /// </summary>
        public gvec4<T> rarr => new gvec4<T>(x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.xwxxx swizzling.
        /// </summary>
        public gvec5<T> xwxxx => new gvec5<T>(x, w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.rarrr swizzling (equivalent to gvec4.xwxxx).
        /// </summary>
        public gvec5<T> rarrr => new gvec5<T>(x, w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.xwxxy swizzling.
        /// </summary>
        public gvec5<T> xwxxy => new gvec5<T>(x, w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.rarrg swizzling (equivalent to gvec4.xwxxy).
        /// </summary>
        public gvec5<T> rarrg => new gvec5<T>(x, w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.xwxxz swizzling.
        /// </summary>
        public gvec5<T> xwxxz => new gvec5<T>(x, w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.rarrb swizzling (equivalent to gvec4.xwxxz).
        /// </summary>
        public gvec5<T> rarrb => new gvec5<T>(x, w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.xwxxw swizzling.
        /// </summary>
        public gvec5<T> xwxxw => new gvec5<T>(x, w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.rarra swizzling (equivalent to gvec4.xwxxw).
        /// </summary>
        public gvec5<T> rarra => new gvec5<T>(x, w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.xwxy swizzling.
        /// </summary>
        public gvec4<T> xwxy => new gvec4<T>(x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.rarg swizzling (equivalent to gvec4.xwxy).
        /// </summary>
        public gvec4<T> rarg => new gvec4<T>(x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.xwxyx swizzling.
        /// </summary>
        public gvec5<T> xwxyx => new gvec5<T>(x, w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.rargr swizzling (equivalent to gvec4.xwxyx).
        /// </summary>
        public gvec5<T> rargr => new gvec5<T>(x, w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.xwxyy swizzling.
        /// </summary>
        public gvec5<T> xwxyy => new gvec5<T>(x, w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.rargg swizzling (equivalent to gvec4.xwxyy).
        /// </summary>
        public gvec5<T> rargg => new gvec5<T>(x, w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.xwxyz swizzling.
        /// </summary>
        public gvec5<T> xwxyz => new gvec5<T>(x, w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.rargb swizzling (equivalent to gvec4.xwxyz).
        /// </summary>
        public gvec5<T> rargb => new gvec5<T>(x, w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.xwxyw swizzling.
        /// </summary>
        public gvec5<T> xwxyw => new gvec5<T>(x, w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.rarga swizzling (equivalent to gvec4.xwxyw).
        /// </summary>
        public gvec5<T> rarga => new gvec5<T>(x, w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.xwxz swizzling.
        /// </summary>
        public gvec4<T> xwxz => new gvec4<T>(x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.rarb swizzling (equivalent to gvec4.xwxz).
        /// </summary>
        public gvec4<T> rarb => new gvec4<T>(x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.xwxzx swizzling.
        /// </summary>
        public gvec5<T> xwxzx => new gvec5<T>(x, w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.rarbr swizzling (equivalent to gvec4.xwxzx).
        /// </summary>
        public gvec5<T> rarbr => new gvec5<T>(x, w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.xwxzy swizzling.
        /// </summary>
        public gvec5<T> xwxzy => new gvec5<T>(x, w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.rarbg swizzling (equivalent to gvec4.xwxzy).
        /// </summary>
        public gvec5<T> rarbg => new gvec5<T>(x, w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.xwxzz swizzling.
        /// </summary>
        public gvec5<T> xwxzz => new gvec5<T>(x, w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.rarbb swizzling (equivalent to gvec4.xwxzz).
        /// </summary>
        public gvec5<T> rarbb => new gvec5<T>(x, w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.xwxzw swizzling.
        /// </summary>
        public gvec5<T> xwxzw => new gvec5<T>(x, w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.rarba swizzling (equivalent to gvec4.xwxzw).
        /// </summary>
        public gvec5<T> rarba => new gvec5<T>(x, w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.xwxw swizzling.
        /// </summary>
        public gvec4<T> xwxw => new gvec4<T>(x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.rara swizzling (equivalent to gvec4.xwxw).
        /// </summary>
        public gvec4<T> rara => new gvec4<T>(x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.xwxwx swizzling.
        /// </summary>
        public gvec5<T> xwxwx => new gvec5<T>(x, w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.rarar swizzling (equivalent to gvec4.xwxwx).
        /// </summary>
        public gvec5<T> rarar => new gvec5<T>(x, w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.xwxwy swizzling.
        /// </summary>
        public gvec5<T> xwxwy => new gvec5<T>(x, w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.rarag swizzling (equivalent to gvec4.xwxwy).
        /// </summary>
        public gvec5<T> rarag => new gvec5<T>(x, w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.xwxwz swizzling.
        /// </summary>
        public gvec5<T> xwxwz => new gvec5<T>(x, w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.rarab swizzling (equivalent to gvec4.xwxwz).
        /// </summary>
        public gvec5<T> rarab => new gvec5<T>(x, w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.xwxww swizzling.
        /// </summary>
        public gvec5<T> xwxww => new gvec5<T>(x, w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.raraa swizzling (equivalent to gvec4.xwxww).
        /// </summary>
        public gvec5<T> raraa => new gvec5<T>(x, w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.xwy swizzling.
        /// </summary>
        public gvec3<T> xwy => new gvec3<T>(x, w, y);
        
        /// <summary>
        /// Returns gvec4.rag swizzling (equivalent to gvec4.xwy).
        /// </summary>
        public gvec3<T> rag => new gvec3<T>(x, w, y);
        
        /// <summary>
        /// Returns gvec4.xwyx swizzling.
        /// </summary>
        public gvec4<T> xwyx => new gvec4<T>(x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.ragr swizzling (equivalent to gvec4.xwyx).
        /// </summary>
        public gvec4<T> ragr => new gvec4<T>(x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.xwyxx swizzling.
        /// </summary>
        public gvec5<T> xwyxx => new gvec5<T>(x, w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.ragrr swizzling (equivalent to gvec4.xwyxx).
        /// </summary>
        public gvec5<T> ragrr => new gvec5<T>(x, w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.xwyxy swizzling.
        /// </summary>
        public gvec5<T> xwyxy => new gvec5<T>(x, w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.ragrg swizzling (equivalent to gvec4.xwyxy).
        /// </summary>
        public gvec5<T> ragrg => new gvec5<T>(x, w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.xwyxz swizzling.
        /// </summary>
        public gvec5<T> xwyxz => new gvec5<T>(x, w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.ragrb swizzling (equivalent to gvec4.xwyxz).
        /// </summary>
        public gvec5<T> ragrb => new gvec5<T>(x, w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.xwyxw swizzling.
        /// </summary>
        public gvec5<T> xwyxw => new gvec5<T>(x, w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.ragra swizzling (equivalent to gvec4.xwyxw).
        /// </summary>
        public gvec5<T> ragra => new gvec5<T>(x, w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.xwyy swizzling.
        /// </summary>
        public gvec4<T> xwyy => new gvec4<T>(x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.ragg swizzling (equivalent to gvec4.xwyy).
        /// </summary>
        public gvec4<T> ragg => new gvec4<T>(x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.xwyyx swizzling.
        /// </summary>
        public gvec5<T> xwyyx => new gvec5<T>(x, w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.raggr swizzling (equivalent to gvec4.xwyyx).
        /// </summary>
        public gvec5<T> raggr => new gvec5<T>(x, w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.xwyyy swizzling.
        /// </summary>
        public gvec5<T> xwyyy => new gvec5<T>(x, w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.raggg swizzling (equivalent to gvec4.xwyyy).
        /// </summary>
        public gvec5<T> raggg => new gvec5<T>(x, w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.xwyyz swizzling.
        /// </summary>
        public gvec5<T> xwyyz => new gvec5<T>(x, w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.raggb swizzling (equivalent to gvec4.xwyyz).
        /// </summary>
        public gvec5<T> raggb => new gvec5<T>(x, w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.xwyyw swizzling.
        /// </summary>
        public gvec5<T> xwyyw => new gvec5<T>(x, w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.ragga swizzling (equivalent to gvec4.xwyyw).
        /// </summary>
        public gvec5<T> ragga => new gvec5<T>(x, w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.xwyz swizzling.
        /// </summary>
        public gvec4<T> xwyz => new gvec4<T>(x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.ragb swizzling (equivalent to gvec4.xwyz).
        /// </summary>
        public gvec4<T> ragb => new gvec4<T>(x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.xwyzx swizzling.
        /// </summary>
        public gvec5<T> xwyzx => new gvec5<T>(x, w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.ragbr swizzling (equivalent to gvec4.xwyzx).
        /// </summary>
        public gvec5<T> ragbr => new gvec5<T>(x, w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.xwyzy swizzling.
        /// </summary>
        public gvec5<T> xwyzy => new gvec5<T>(x, w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.ragbg swizzling (equivalent to gvec4.xwyzy).
        /// </summary>
        public gvec5<T> ragbg => new gvec5<T>(x, w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.xwyzz swizzling.
        /// </summary>
        public gvec5<T> xwyzz => new gvec5<T>(x, w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.ragbb swizzling (equivalent to gvec4.xwyzz).
        /// </summary>
        public gvec5<T> ragbb => new gvec5<T>(x, w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.xwyzw swizzling.
        /// </summary>
        public gvec5<T> xwyzw => new gvec5<T>(x, w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.ragba swizzling (equivalent to gvec4.xwyzw).
        /// </summary>
        public gvec5<T> ragba => new gvec5<T>(x, w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.xwyw swizzling.
        /// </summary>
        public gvec4<T> xwyw => new gvec4<T>(x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.raga swizzling (equivalent to gvec4.xwyw).
        /// </summary>
        public gvec4<T> raga => new gvec4<T>(x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.xwywx swizzling.
        /// </summary>
        public gvec5<T> xwywx => new gvec5<T>(x, w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.ragar swizzling (equivalent to gvec4.xwywx).
        /// </summary>
        public gvec5<T> ragar => new gvec5<T>(x, w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.xwywy swizzling.
        /// </summary>
        public gvec5<T> xwywy => new gvec5<T>(x, w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.ragag swizzling (equivalent to gvec4.xwywy).
        /// </summary>
        public gvec5<T> ragag => new gvec5<T>(x, w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.xwywz swizzling.
        /// </summary>
        public gvec5<T> xwywz => new gvec5<T>(x, w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.ragab swizzling (equivalent to gvec4.xwywz).
        /// </summary>
        public gvec5<T> ragab => new gvec5<T>(x, w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.xwyww swizzling.
        /// </summary>
        public gvec5<T> xwyww => new gvec5<T>(x, w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.ragaa swizzling (equivalent to gvec4.xwyww).
        /// </summary>
        public gvec5<T> ragaa => new gvec5<T>(x, w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.xwz swizzling.
        /// </summary>
        public gvec3<T> xwz => new gvec3<T>(x, w, z);
        
        /// <summary>
        /// Returns gvec4.rab swizzling (equivalent to gvec4.xwz).
        /// </summary>
        public gvec3<T> rab => new gvec3<T>(x, w, z);
        
        /// <summary>
        /// Returns gvec4.xwzx swizzling.
        /// </summary>
        public gvec4<T> xwzx => new gvec4<T>(x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.rabr swizzling (equivalent to gvec4.xwzx).
        /// </summary>
        public gvec4<T> rabr => new gvec4<T>(x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.xwzxx swizzling.
        /// </summary>
        public gvec5<T> xwzxx => new gvec5<T>(x, w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.rabrr swizzling (equivalent to gvec4.xwzxx).
        /// </summary>
        public gvec5<T> rabrr => new gvec5<T>(x, w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.xwzxy swizzling.
        /// </summary>
        public gvec5<T> xwzxy => new gvec5<T>(x, w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.rabrg swizzling (equivalent to gvec4.xwzxy).
        /// </summary>
        public gvec5<T> rabrg => new gvec5<T>(x, w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.xwzxz swizzling.
        /// </summary>
        public gvec5<T> xwzxz => new gvec5<T>(x, w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.rabrb swizzling (equivalent to gvec4.xwzxz).
        /// </summary>
        public gvec5<T> rabrb => new gvec5<T>(x, w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.xwzxw swizzling.
        /// </summary>
        public gvec5<T> xwzxw => new gvec5<T>(x, w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.rabra swizzling (equivalent to gvec4.xwzxw).
        /// </summary>
        public gvec5<T> rabra => new gvec5<T>(x, w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.xwzy swizzling.
        /// </summary>
        public gvec4<T> xwzy => new gvec4<T>(x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.rabg swizzling (equivalent to gvec4.xwzy).
        /// </summary>
        public gvec4<T> rabg => new gvec4<T>(x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.xwzyx swizzling.
        /// </summary>
        public gvec5<T> xwzyx => new gvec5<T>(x, w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.rabgr swizzling (equivalent to gvec4.xwzyx).
        /// </summary>
        public gvec5<T> rabgr => new gvec5<T>(x, w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.xwzyy swizzling.
        /// </summary>
        public gvec5<T> xwzyy => new gvec5<T>(x, w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.rabgg swizzling (equivalent to gvec4.xwzyy).
        /// </summary>
        public gvec5<T> rabgg => new gvec5<T>(x, w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.xwzyz swizzling.
        /// </summary>
        public gvec5<T> xwzyz => new gvec5<T>(x, w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.rabgb swizzling (equivalent to gvec4.xwzyz).
        /// </summary>
        public gvec5<T> rabgb => new gvec5<T>(x, w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.xwzyw swizzling.
        /// </summary>
        public gvec5<T> xwzyw => new gvec5<T>(x, w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.rabga swizzling (equivalent to gvec4.xwzyw).
        /// </summary>
        public gvec5<T> rabga => new gvec5<T>(x, w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.xwzz swizzling.
        /// </summary>
        public gvec4<T> xwzz => new gvec4<T>(x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.rabb swizzling (equivalent to gvec4.xwzz).
        /// </summary>
        public gvec4<T> rabb => new gvec4<T>(x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.xwzzx swizzling.
        /// </summary>
        public gvec5<T> xwzzx => new gvec5<T>(x, w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.rabbr swizzling (equivalent to gvec4.xwzzx).
        /// </summary>
        public gvec5<T> rabbr => new gvec5<T>(x, w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.xwzzy swizzling.
        /// </summary>
        public gvec5<T> xwzzy => new gvec5<T>(x, w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.rabbg swizzling (equivalent to gvec4.xwzzy).
        /// </summary>
        public gvec5<T> rabbg => new gvec5<T>(x, w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.xwzzz swizzling.
        /// </summary>
        public gvec5<T> xwzzz => new gvec5<T>(x, w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.rabbb swizzling (equivalent to gvec4.xwzzz).
        /// </summary>
        public gvec5<T> rabbb => new gvec5<T>(x, w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.xwzzw swizzling.
        /// </summary>
        public gvec5<T> xwzzw => new gvec5<T>(x, w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.rabba swizzling (equivalent to gvec4.xwzzw).
        /// </summary>
        public gvec5<T> rabba => new gvec5<T>(x, w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.xwzw swizzling.
        /// </summary>
        public gvec4<T> xwzw => new gvec4<T>(x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.raba swizzling (equivalent to gvec4.xwzw).
        /// </summary>
        public gvec4<T> raba => new gvec4<T>(x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.xwzwx swizzling.
        /// </summary>
        public gvec5<T> xwzwx => new gvec5<T>(x, w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.rabar swizzling (equivalent to gvec4.xwzwx).
        /// </summary>
        public gvec5<T> rabar => new gvec5<T>(x, w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.xwzwy swizzling.
        /// </summary>
        public gvec5<T> xwzwy => new gvec5<T>(x, w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.rabag swizzling (equivalent to gvec4.xwzwy).
        /// </summary>
        public gvec5<T> rabag => new gvec5<T>(x, w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.xwzwz swizzling.
        /// </summary>
        public gvec5<T> xwzwz => new gvec5<T>(x, w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.rabab swizzling (equivalent to gvec4.xwzwz).
        /// </summary>
        public gvec5<T> rabab => new gvec5<T>(x, w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.xwzww swizzling.
        /// </summary>
        public gvec5<T> xwzww => new gvec5<T>(x, w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.rabaa swizzling (equivalent to gvec4.xwzww).
        /// </summary>
        public gvec5<T> rabaa => new gvec5<T>(x, w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.xww swizzling.
        /// </summary>
        public gvec3<T> xww => new gvec3<T>(x, w, w);
        
        /// <summary>
        /// Returns gvec4.raa swizzling (equivalent to gvec4.xww).
        /// </summary>
        public gvec3<T> raa => new gvec3<T>(x, w, w);
        
        /// <summary>
        /// Returns gvec4.xwwx swizzling.
        /// </summary>
        public gvec4<T> xwwx => new gvec4<T>(x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.raar swizzling (equivalent to gvec4.xwwx).
        /// </summary>
        public gvec4<T> raar => new gvec4<T>(x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.xwwxx swizzling.
        /// </summary>
        public gvec5<T> xwwxx => new gvec5<T>(x, w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.raarr swizzling (equivalent to gvec4.xwwxx).
        /// </summary>
        public gvec5<T> raarr => new gvec5<T>(x, w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.xwwxy swizzling.
        /// </summary>
        public gvec5<T> xwwxy => new gvec5<T>(x, w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.raarg swizzling (equivalent to gvec4.xwwxy).
        /// </summary>
        public gvec5<T> raarg => new gvec5<T>(x, w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.xwwxz swizzling.
        /// </summary>
        public gvec5<T> xwwxz => new gvec5<T>(x, w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.raarb swizzling (equivalent to gvec4.xwwxz).
        /// </summary>
        public gvec5<T> raarb => new gvec5<T>(x, w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.xwwxw swizzling.
        /// </summary>
        public gvec5<T> xwwxw => new gvec5<T>(x, w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.raara swizzling (equivalent to gvec4.xwwxw).
        /// </summary>
        public gvec5<T> raara => new gvec5<T>(x, w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.xwwy swizzling.
        /// </summary>
        public gvec4<T> xwwy => new gvec4<T>(x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.raag swizzling (equivalent to gvec4.xwwy).
        /// </summary>
        public gvec4<T> raag => new gvec4<T>(x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.xwwyx swizzling.
        /// </summary>
        public gvec5<T> xwwyx => new gvec5<T>(x, w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.raagr swizzling (equivalent to gvec4.xwwyx).
        /// </summary>
        public gvec5<T> raagr => new gvec5<T>(x, w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.xwwyy swizzling.
        /// </summary>
        public gvec5<T> xwwyy => new gvec5<T>(x, w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.raagg swizzling (equivalent to gvec4.xwwyy).
        /// </summary>
        public gvec5<T> raagg => new gvec5<T>(x, w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.xwwyz swizzling.
        /// </summary>
        public gvec5<T> xwwyz => new gvec5<T>(x, w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.raagb swizzling (equivalent to gvec4.xwwyz).
        /// </summary>
        public gvec5<T> raagb => new gvec5<T>(x, w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.xwwyw swizzling.
        /// </summary>
        public gvec5<T> xwwyw => new gvec5<T>(x, w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.raaga swizzling (equivalent to gvec4.xwwyw).
        /// </summary>
        public gvec5<T> raaga => new gvec5<T>(x, w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.xwwz swizzling.
        /// </summary>
        public gvec4<T> xwwz => new gvec4<T>(x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.raab swizzling (equivalent to gvec4.xwwz).
        /// </summary>
        public gvec4<T> raab => new gvec4<T>(x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.xwwzx swizzling.
        /// </summary>
        public gvec5<T> xwwzx => new gvec5<T>(x, w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.raabr swizzling (equivalent to gvec4.xwwzx).
        /// </summary>
        public gvec5<T> raabr => new gvec5<T>(x, w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.xwwzy swizzling.
        /// </summary>
        public gvec5<T> xwwzy => new gvec5<T>(x, w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.raabg swizzling (equivalent to gvec4.xwwzy).
        /// </summary>
        public gvec5<T> raabg => new gvec5<T>(x, w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.xwwzz swizzling.
        /// </summary>
        public gvec5<T> xwwzz => new gvec5<T>(x, w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.raabb swizzling (equivalent to gvec4.xwwzz).
        /// </summary>
        public gvec5<T> raabb => new gvec5<T>(x, w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.xwwzw swizzling.
        /// </summary>
        public gvec5<T> xwwzw => new gvec5<T>(x, w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.raaba swizzling (equivalent to gvec4.xwwzw).
        /// </summary>
        public gvec5<T> raaba => new gvec5<T>(x, w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.xwww swizzling.
        /// </summary>
        public gvec4<T> xwww => new gvec4<T>(x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.raaa swizzling (equivalent to gvec4.xwww).
        /// </summary>
        public gvec4<T> raaa => new gvec4<T>(x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.xwwwx swizzling.
        /// </summary>
        public gvec5<T> xwwwx => new gvec5<T>(x, w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.raaar swizzling (equivalent to gvec4.xwwwx).
        /// </summary>
        public gvec5<T> raaar => new gvec5<T>(x, w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.xwwwy swizzling.
        /// </summary>
        public gvec5<T> xwwwy => new gvec5<T>(x, w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.raaag swizzling (equivalent to gvec4.xwwwy).
        /// </summary>
        public gvec5<T> raaag => new gvec5<T>(x, w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.xwwwz swizzling.
        /// </summary>
        public gvec5<T> xwwwz => new gvec5<T>(x, w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.raaab swizzling (equivalent to gvec4.xwwwz).
        /// </summary>
        public gvec5<T> raaab => new gvec5<T>(x, w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.xwwww swizzling.
        /// </summary>
        public gvec5<T> xwwww => new gvec5<T>(x, w, w, w, w);
        
        /// <summary>
        /// Returns gvec4.raaaa swizzling (equivalent to gvec4.xwwww).
        /// </summary>
        public gvec5<T> raaaa => new gvec5<T>(x, w, w, w, w);
        
        /// <summary>
        /// Returns gvec4.yx swizzling.
        /// </summary>
        public gvec2<T> yx => new gvec2<T>(y, x);
        
        /// <summary>
        /// Returns gvec4.gr swizzling (equivalent to gvec4.yx).
        /// </summary>
        public gvec2<T> gr => new gvec2<T>(y, x);
        
        /// <summary>
        /// Returns gvec4.yxx swizzling.
        /// </summary>
        public gvec3<T> yxx => new gvec3<T>(y, x, x);
        
        /// <summary>
        /// Returns gvec4.grr swizzling (equivalent to gvec4.yxx).
        /// </summary>
        public gvec3<T> grr => new gvec3<T>(y, x, x);
        
        /// <summary>
        /// Returns gvec4.yxxx swizzling.
        /// </summary>
        public gvec4<T> yxxx => new gvec4<T>(y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.grrr swizzling (equivalent to gvec4.yxxx).
        /// </summary>
        public gvec4<T> grrr => new gvec4<T>(y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.yxxxx swizzling.
        /// </summary>
        public gvec5<T> yxxxx => new gvec5<T>(y, x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.grrrr swizzling (equivalent to gvec4.yxxxx).
        /// </summary>
        public gvec5<T> grrrr => new gvec5<T>(y, x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.yxxxy swizzling.
        /// </summary>
        public gvec5<T> yxxxy => new gvec5<T>(y, x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.grrrg swizzling (equivalent to gvec4.yxxxy).
        /// </summary>
        public gvec5<T> grrrg => new gvec5<T>(y, x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.yxxxz swizzling.
        /// </summary>
        public gvec5<T> yxxxz => new gvec5<T>(y, x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.grrrb swizzling (equivalent to gvec4.yxxxz).
        /// </summary>
        public gvec5<T> grrrb => new gvec5<T>(y, x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.yxxxw swizzling.
        /// </summary>
        public gvec5<T> yxxxw => new gvec5<T>(y, x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.grrra swizzling (equivalent to gvec4.yxxxw).
        /// </summary>
        public gvec5<T> grrra => new gvec5<T>(y, x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.yxxy swizzling.
        /// </summary>
        public gvec4<T> yxxy => new gvec4<T>(y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.grrg swizzling (equivalent to gvec4.yxxy).
        /// </summary>
        public gvec4<T> grrg => new gvec4<T>(y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.yxxyx swizzling.
        /// </summary>
        public gvec5<T> yxxyx => new gvec5<T>(y, x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.grrgr swizzling (equivalent to gvec4.yxxyx).
        /// </summary>
        public gvec5<T> grrgr => new gvec5<T>(y, x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.yxxyy swizzling.
        /// </summary>
        public gvec5<T> yxxyy => new gvec5<T>(y, x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.grrgg swizzling (equivalent to gvec4.yxxyy).
        /// </summary>
        public gvec5<T> grrgg => new gvec5<T>(y, x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.yxxyz swizzling.
        /// </summary>
        public gvec5<T> yxxyz => new gvec5<T>(y, x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.grrgb swizzling (equivalent to gvec4.yxxyz).
        /// </summary>
        public gvec5<T> grrgb => new gvec5<T>(y, x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.yxxyw swizzling.
        /// </summary>
        public gvec5<T> yxxyw => new gvec5<T>(y, x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.grrga swizzling (equivalent to gvec4.yxxyw).
        /// </summary>
        public gvec5<T> grrga => new gvec5<T>(y, x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.yxxz swizzling.
        /// </summary>
        public gvec4<T> yxxz => new gvec4<T>(y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.grrb swizzling (equivalent to gvec4.yxxz).
        /// </summary>
        public gvec4<T> grrb => new gvec4<T>(y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.yxxzx swizzling.
        /// </summary>
        public gvec5<T> yxxzx => new gvec5<T>(y, x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.grrbr swizzling (equivalent to gvec4.yxxzx).
        /// </summary>
        public gvec5<T> grrbr => new gvec5<T>(y, x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.yxxzy swizzling.
        /// </summary>
        public gvec5<T> yxxzy => new gvec5<T>(y, x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.grrbg swizzling (equivalent to gvec4.yxxzy).
        /// </summary>
        public gvec5<T> grrbg => new gvec5<T>(y, x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.yxxzz swizzling.
        /// </summary>
        public gvec5<T> yxxzz => new gvec5<T>(y, x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.grrbb swizzling (equivalent to gvec4.yxxzz).
        /// </summary>
        public gvec5<T> grrbb => new gvec5<T>(y, x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.yxxzw swizzling.
        /// </summary>
        public gvec5<T> yxxzw => new gvec5<T>(y, x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.grrba swizzling (equivalent to gvec4.yxxzw).
        /// </summary>
        public gvec5<T> grrba => new gvec5<T>(y, x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.yxxw swizzling.
        /// </summary>
        public gvec4<T> yxxw => new gvec4<T>(y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.grra swizzling (equivalent to gvec4.yxxw).
        /// </summary>
        public gvec4<T> grra => new gvec4<T>(y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.yxxwx swizzling.
        /// </summary>
        public gvec5<T> yxxwx => new gvec5<T>(y, x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.grrar swizzling (equivalent to gvec4.yxxwx).
        /// </summary>
        public gvec5<T> grrar => new gvec5<T>(y, x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.yxxwy swizzling.
        /// </summary>
        public gvec5<T> yxxwy => new gvec5<T>(y, x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.grrag swizzling (equivalent to gvec4.yxxwy).
        /// </summary>
        public gvec5<T> grrag => new gvec5<T>(y, x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.yxxwz swizzling.
        /// </summary>
        public gvec5<T> yxxwz => new gvec5<T>(y, x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.grrab swizzling (equivalent to gvec4.yxxwz).
        /// </summary>
        public gvec5<T> grrab => new gvec5<T>(y, x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.yxxww swizzling.
        /// </summary>
        public gvec5<T> yxxww => new gvec5<T>(y, x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.grraa swizzling (equivalent to gvec4.yxxww).
        /// </summary>
        public gvec5<T> grraa => new gvec5<T>(y, x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.yxy swizzling.
        /// </summary>
        public gvec3<T> yxy => new gvec3<T>(y, x, y);
        
        /// <summary>
        /// Returns gvec4.grg swizzling (equivalent to gvec4.yxy).
        /// </summary>
        public gvec3<T> grg => new gvec3<T>(y, x, y);
        
        /// <summary>
        /// Returns gvec4.yxyx swizzling.
        /// </summary>
        public gvec4<T> yxyx => new gvec4<T>(y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.grgr swizzling (equivalent to gvec4.yxyx).
        /// </summary>
        public gvec4<T> grgr => new gvec4<T>(y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.yxyxx swizzling.
        /// </summary>
        public gvec5<T> yxyxx => new gvec5<T>(y, x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.grgrr swizzling (equivalent to gvec4.yxyxx).
        /// </summary>
        public gvec5<T> grgrr => new gvec5<T>(y, x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.yxyxy swizzling.
        /// </summary>
        public gvec5<T> yxyxy => new gvec5<T>(y, x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.grgrg swizzling (equivalent to gvec4.yxyxy).
        /// </summary>
        public gvec5<T> grgrg => new gvec5<T>(y, x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.yxyxz swizzling.
        /// </summary>
        public gvec5<T> yxyxz => new gvec5<T>(y, x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.grgrb swizzling (equivalent to gvec4.yxyxz).
        /// </summary>
        public gvec5<T> grgrb => new gvec5<T>(y, x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.yxyxw swizzling.
        /// </summary>
        public gvec5<T> yxyxw => new gvec5<T>(y, x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.grgra swizzling (equivalent to gvec4.yxyxw).
        /// </summary>
        public gvec5<T> grgra => new gvec5<T>(y, x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.yxyy swizzling.
        /// </summary>
        public gvec4<T> yxyy => new gvec4<T>(y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.grgg swizzling (equivalent to gvec4.yxyy).
        /// </summary>
        public gvec4<T> grgg => new gvec4<T>(y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.yxyyx swizzling.
        /// </summary>
        public gvec5<T> yxyyx => new gvec5<T>(y, x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.grggr swizzling (equivalent to gvec4.yxyyx).
        /// </summary>
        public gvec5<T> grggr => new gvec5<T>(y, x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.yxyyy swizzling.
        /// </summary>
        public gvec5<T> yxyyy => new gvec5<T>(y, x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.grggg swizzling (equivalent to gvec4.yxyyy).
        /// </summary>
        public gvec5<T> grggg => new gvec5<T>(y, x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.yxyyz swizzling.
        /// </summary>
        public gvec5<T> yxyyz => new gvec5<T>(y, x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.grggb swizzling (equivalent to gvec4.yxyyz).
        /// </summary>
        public gvec5<T> grggb => new gvec5<T>(y, x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.yxyyw swizzling.
        /// </summary>
        public gvec5<T> yxyyw => new gvec5<T>(y, x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.grgga swizzling (equivalent to gvec4.yxyyw).
        /// </summary>
        public gvec5<T> grgga => new gvec5<T>(y, x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.yxyz swizzling.
        /// </summary>
        public gvec4<T> yxyz => new gvec4<T>(y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.grgb swizzling (equivalent to gvec4.yxyz).
        /// </summary>
        public gvec4<T> grgb => new gvec4<T>(y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.yxyzx swizzling.
        /// </summary>
        public gvec5<T> yxyzx => new gvec5<T>(y, x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.grgbr swizzling (equivalent to gvec4.yxyzx).
        /// </summary>
        public gvec5<T> grgbr => new gvec5<T>(y, x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.yxyzy swizzling.
        /// </summary>
        public gvec5<T> yxyzy => new gvec5<T>(y, x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.grgbg swizzling (equivalent to gvec4.yxyzy).
        /// </summary>
        public gvec5<T> grgbg => new gvec5<T>(y, x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.yxyzz swizzling.
        /// </summary>
        public gvec5<T> yxyzz => new gvec5<T>(y, x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.grgbb swizzling (equivalent to gvec4.yxyzz).
        /// </summary>
        public gvec5<T> grgbb => new gvec5<T>(y, x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.yxyzw swizzling.
        /// </summary>
        public gvec5<T> yxyzw => new gvec5<T>(y, x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.grgba swizzling (equivalent to gvec4.yxyzw).
        /// </summary>
        public gvec5<T> grgba => new gvec5<T>(y, x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.yxyw swizzling.
        /// </summary>
        public gvec4<T> yxyw => new gvec4<T>(y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.grga swizzling (equivalent to gvec4.yxyw).
        /// </summary>
        public gvec4<T> grga => new gvec4<T>(y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.yxywx swizzling.
        /// </summary>
        public gvec5<T> yxywx => new gvec5<T>(y, x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.grgar swizzling (equivalent to gvec4.yxywx).
        /// </summary>
        public gvec5<T> grgar => new gvec5<T>(y, x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.yxywy swizzling.
        /// </summary>
        public gvec5<T> yxywy => new gvec5<T>(y, x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.grgag swizzling (equivalent to gvec4.yxywy).
        /// </summary>
        public gvec5<T> grgag => new gvec5<T>(y, x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.yxywz swizzling.
        /// </summary>
        public gvec5<T> yxywz => new gvec5<T>(y, x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.grgab swizzling (equivalent to gvec4.yxywz).
        /// </summary>
        public gvec5<T> grgab => new gvec5<T>(y, x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.yxyww swizzling.
        /// </summary>
        public gvec5<T> yxyww => new gvec5<T>(y, x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.grgaa swizzling (equivalent to gvec4.yxyww).
        /// </summary>
        public gvec5<T> grgaa => new gvec5<T>(y, x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.yxz swizzling.
        /// </summary>
        public gvec3<T> yxz => new gvec3<T>(y, x, z);
        
        /// <summary>
        /// Returns gvec4.grb swizzling (equivalent to gvec4.yxz).
        /// </summary>
        public gvec3<T> grb => new gvec3<T>(y, x, z);
        
        /// <summary>
        /// Returns gvec4.yxzx swizzling.
        /// </summary>
        public gvec4<T> yxzx => new gvec4<T>(y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.grbr swizzling (equivalent to gvec4.yxzx).
        /// </summary>
        public gvec4<T> grbr => new gvec4<T>(y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.yxzxx swizzling.
        /// </summary>
        public gvec5<T> yxzxx => new gvec5<T>(y, x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.grbrr swizzling (equivalent to gvec4.yxzxx).
        /// </summary>
        public gvec5<T> grbrr => new gvec5<T>(y, x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.yxzxy swizzling.
        /// </summary>
        public gvec5<T> yxzxy => new gvec5<T>(y, x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.grbrg swizzling (equivalent to gvec4.yxzxy).
        /// </summary>
        public gvec5<T> grbrg => new gvec5<T>(y, x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.yxzxz swizzling.
        /// </summary>
        public gvec5<T> yxzxz => new gvec5<T>(y, x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.grbrb swizzling (equivalent to gvec4.yxzxz).
        /// </summary>
        public gvec5<T> grbrb => new gvec5<T>(y, x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.yxzxw swizzling.
        /// </summary>
        public gvec5<T> yxzxw => new gvec5<T>(y, x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.grbra swizzling (equivalent to gvec4.yxzxw).
        /// </summary>
        public gvec5<T> grbra => new gvec5<T>(y, x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.yxzy swizzling.
        /// </summary>
        public gvec4<T> yxzy => new gvec4<T>(y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.grbg swizzling (equivalent to gvec4.yxzy).
        /// </summary>
        public gvec4<T> grbg => new gvec4<T>(y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.yxzyx swizzling.
        /// </summary>
        public gvec5<T> yxzyx => new gvec5<T>(y, x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.grbgr swizzling (equivalent to gvec4.yxzyx).
        /// </summary>
        public gvec5<T> grbgr => new gvec5<T>(y, x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.yxzyy swizzling.
        /// </summary>
        public gvec5<T> yxzyy => new gvec5<T>(y, x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.grbgg swizzling (equivalent to gvec4.yxzyy).
        /// </summary>
        public gvec5<T> grbgg => new gvec5<T>(y, x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.yxzyz swizzling.
        /// </summary>
        public gvec5<T> yxzyz => new gvec5<T>(y, x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.grbgb swizzling (equivalent to gvec4.yxzyz).
        /// </summary>
        public gvec5<T> grbgb => new gvec5<T>(y, x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.yxzyw swizzling.
        /// </summary>
        public gvec5<T> yxzyw => new gvec5<T>(y, x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.grbga swizzling (equivalent to gvec4.yxzyw).
        /// </summary>
        public gvec5<T> grbga => new gvec5<T>(y, x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.yxzz swizzling.
        /// </summary>
        public gvec4<T> yxzz => new gvec4<T>(y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.grbb swizzling (equivalent to gvec4.yxzz).
        /// </summary>
        public gvec4<T> grbb => new gvec4<T>(y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.yxzzx swizzling.
        /// </summary>
        public gvec5<T> yxzzx => new gvec5<T>(y, x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.grbbr swizzling (equivalent to gvec4.yxzzx).
        /// </summary>
        public gvec5<T> grbbr => new gvec5<T>(y, x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.yxzzy swizzling.
        /// </summary>
        public gvec5<T> yxzzy => new gvec5<T>(y, x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.grbbg swizzling (equivalent to gvec4.yxzzy).
        /// </summary>
        public gvec5<T> grbbg => new gvec5<T>(y, x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.yxzzz swizzling.
        /// </summary>
        public gvec5<T> yxzzz => new gvec5<T>(y, x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.grbbb swizzling (equivalent to gvec4.yxzzz).
        /// </summary>
        public gvec5<T> grbbb => new gvec5<T>(y, x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.yxzzw swizzling.
        /// </summary>
        public gvec5<T> yxzzw => new gvec5<T>(y, x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.grbba swizzling (equivalent to gvec4.yxzzw).
        /// </summary>
        public gvec5<T> grbba => new gvec5<T>(y, x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.yxzw swizzling.
        /// </summary>
        public gvec4<T> yxzw => new gvec4<T>(y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.grba swizzling (equivalent to gvec4.yxzw).
        /// </summary>
        public gvec4<T> grba => new gvec4<T>(y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.yxzwx swizzling.
        /// </summary>
        public gvec5<T> yxzwx => new gvec5<T>(y, x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.grbar swizzling (equivalent to gvec4.yxzwx).
        /// </summary>
        public gvec5<T> grbar => new gvec5<T>(y, x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.yxzwy swizzling.
        /// </summary>
        public gvec5<T> yxzwy => new gvec5<T>(y, x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.grbag swizzling (equivalent to gvec4.yxzwy).
        /// </summary>
        public gvec5<T> grbag => new gvec5<T>(y, x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.yxzwz swizzling.
        /// </summary>
        public gvec5<T> yxzwz => new gvec5<T>(y, x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.grbab swizzling (equivalent to gvec4.yxzwz).
        /// </summary>
        public gvec5<T> grbab => new gvec5<T>(y, x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.yxzww swizzling.
        /// </summary>
        public gvec5<T> yxzww => new gvec5<T>(y, x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.grbaa swizzling (equivalent to gvec4.yxzww).
        /// </summary>
        public gvec5<T> grbaa => new gvec5<T>(y, x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.yxw swizzling.
        /// </summary>
        public gvec3<T> yxw => new gvec3<T>(y, x, w);
        
        /// <summary>
        /// Returns gvec4.gra swizzling (equivalent to gvec4.yxw).
        /// </summary>
        public gvec3<T> gra => new gvec3<T>(y, x, w);
        
        /// <summary>
        /// Returns gvec4.yxwx swizzling.
        /// </summary>
        public gvec4<T> yxwx => new gvec4<T>(y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.grar swizzling (equivalent to gvec4.yxwx).
        /// </summary>
        public gvec4<T> grar => new gvec4<T>(y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.yxwxx swizzling.
        /// </summary>
        public gvec5<T> yxwxx => new gvec5<T>(y, x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.grarr swizzling (equivalent to gvec4.yxwxx).
        /// </summary>
        public gvec5<T> grarr => new gvec5<T>(y, x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.yxwxy swizzling.
        /// </summary>
        public gvec5<T> yxwxy => new gvec5<T>(y, x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.grarg swizzling (equivalent to gvec4.yxwxy).
        /// </summary>
        public gvec5<T> grarg => new gvec5<T>(y, x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.yxwxz swizzling.
        /// </summary>
        public gvec5<T> yxwxz => new gvec5<T>(y, x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.grarb swizzling (equivalent to gvec4.yxwxz).
        /// </summary>
        public gvec5<T> grarb => new gvec5<T>(y, x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.yxwxw swizzling.
        /// </summary>
        public gvec5<T> yxwxw => new gvec5<T>(y, x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.grara swizzling (equivalent to gvec4.yxwxw).
        /// </summary>
        public gvec5<T> grara => new gvec5<T>(y, x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.yxwy swizzling.
        /// </summary>
        public gvec4<T> yxwy => new gvec4<T>(y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.grag swizzling (equivalent to gvec4.yxwy).
        /// </summary>
        public gvec4<T> grag => new gvec4<T>(y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.yxwyx swizzling.
        /// </summary>
        public gvec5<T> yxwyx => new gvec5<T>(y, x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.gragr swizzling (equivalent to gvec4.yxwyx).
        /// </summary>
        public gvec5<T> gragr => new gvec5<T>(y, x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.yxwyy swizzling.
        /// </summary>
        public gvec5<T> yxwyy => new gvec5<T>(y, x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.gragg swizzling (equivalent to gvec4.yxwyy).
        /// </summary>
        public gvec5<T> gragg => new gvec5<T>(y, x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.yxwyz swizzling.
        /// </summary>
        public gvec5<T> yxwyz => new gvec5<T>(y, x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.gragb swizzling (equivalent to gvec4.yxwyz).
        /// </summary>
        public gvec5<T> gragb => new gvec5<T>(y, x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.yxwyw swizzling.
        /// </summary>
        public gvec5<T> yxwyw => new gvec5<T>(y, x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.graga swizzling (equivalent to gvec4.yxwyw).
        /// </summary>
        public gvec5<T> graga => new gvec5<T>(y, x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.yxwz swizzling.
        /// </summary>
        public gvec4<T> yxwz => new gvec4<T>(y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.grab swizzling (equivalent to gvec4.yxwz).
        /// </summary>
        public gvec4<T> grab => new gvec4<T>(y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.yxwzx swizzling.
        /// </summary>
        public gvec5<T> yxwzx => new gvec5<T>(y, x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.grabr swizzling (equivalent to gvec4.yxwzx).
        /// </summary>
        public gvec5<T> grabr => new gvec5<T>(y, x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.yxwzy swizzling.
        /// </summary>
        public gvec5<T> yxwzy => new gvec5<T>(y, x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.grabg swizzling (equivalent to gvec4.yxwzy).
        /// </summary>
        public gvec5<T> grabg => new gvec5<T>(y, x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.yxwzz swizzling.
        /// </summary>
        public gvec5<T> yxwzz => new gvec5<T>(y, x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.grabb swizzling (equivalent to gvec4.yxwzz).
        /// </summary>
        public gvec5<T> grabb => new gvec5<T>(y, x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.yxwzw swizzling.
        /// </summary>
        public gvec5<T> yxwzw => new gvec5<T>(y, x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.graba swizzling (equivalent to gvec4.yxwzw).
        /// </summary>
        public gvec5<T> graba => new gvec5<T>(y, x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.yxww swizzling.
        /// </summary>
        public gvec4<T> yxww => new gvec4<T>(y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.graa swizzling (equivalent to gvec4.yxww).
        /// </summary>
        public gvec4<T> graa => new gvec4<T>(y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.yxwwx swizzling.
        /// </summary>
        public gvec5<T> yxwwx => new gvec5<T>(y, x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.graar swizzling (equivalent to gvec4.yxwwx).
        /// </summary>
        public gvec5<T> graar => new gvec5<T>(y, x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.yxwwy swizzling.
        /// </summary>
        public gvec5<T> yxwwy => new gvec5<T>(y, x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.graag swizzling (equivalent to gvec4.yxwwy).
        /// </summary>
        public gvec5<T> graag => new gvec5<T>(y, x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.yxwwz swizzling.
        /// </summary>
        public gvec5<T> yxwwz => new gvec5<T>(y, x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.graab swizzling (equivalent to gvec4.yxwwz).
        /// </summary>
        public gvec5<T> graab => new gvec5<T>(y, x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.yxwww swizzling.
        /// </summary>
        public gvec5<T> yxwww => new gvec5<T>(y, x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.graaa swizzling (equivalent to gvec4.yxwww).
        /// </summary>
        public gvec5<T> graaa => new gvec5<T>(y, x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.yy swizzling.
        /// </summary>
        public gvec2<T> yy => new gvec2<T>(y, y);
        
        /// <summary>
        /// Returns gvec4.gg swizzling (equivalent to gvec4.yy).
        /// </summary>
        public gvec2<T> gg => new gvec2<T>(y, y);
        
        /// <summary>
        /// Returns gvec4.yyx swizzling.
        /// </summary>
        public gvec3<T> yyx => new gvec3<T>(y, y, x);
        
        /// <summary>
        /// Returns gvec4.ggr swizzling (equivalent to gvec4.yyx).
        /// </summary>
        public gvec3<T> ggr => new gvec3<T>(y, y, x);
        
        /// <summary>
        /// Returns gvec4.yyxx swizzling.
        /// </summary>
        public gvec4<T> yyxx => new gvec4<T>(y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.ggrr swizzling (equivalent to gvec4.yyxx).
        /// </summary>
        public gvec4<T> ggrr => new gvec4<T>(y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.yyxxx swizzling.
        /// </summary>
        public gvec5<T> yyxxx => new gvec5<T>(y, y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.ggrrr swizzling (equivalent to gvec4.yyxxx).
        /// </summary>
        public gvec5<T> ggrrr => new gvec5<T>(y, y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.yyxxy swizzling.
        /// </summary>
        public gvec5<T> yyxxy => new gvec5<T>(y, y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.ggrrg swizzling (equivalent to gvec4.yyxxy).
        /// </summary>
        public gvec5<T> ggrrg => new gvec5<T>(y, y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.yyxxz swizzling.
        /// </summary>
        public gvec5<T> yyxxz => new gvec5<T>(y, y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.ggrrb swizzling (equivalent to gvec4.yyxxz).
        /// </summary>
        public gvec5<T> ggrrb => new gvec5<T>(y, y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.yyxxw swizzling.
        /// </summary>
        public gvec5<T> yyxxw => new gvec5<T>(y, y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.ggrra swizzling (equivalent to gvec4.yyxxw).
        /// </summary>
        public gvec5<T> ggrra => new gvec5<T>(y, y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.yyxy swizzling.
        /// </summary>
        public gvec4<T> yyxy => new gvec4<T>(y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.ggrg swizzling (equivalent to gvec4.yyxy).
        /// </summary>
        public gvec4<T> ggrg => new gvec4<T>(y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.yyxyx swizzling.
        /// </summary>
        public gvec5<T> yyxyx => new gvec5<T>(y, y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.ggrgr swizzling (equivalent to gvec4.yyxyx).
        /// </summary>
        public gvec5<T> ggrgr => new gvec5<T>(y, y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.yyxyy swizzling.
        /// </summary>
        public gvec5<T> yyxyy => new gvec5<T>(y, y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.ggrgg swizzling (equivalent to gvec4.yyxyy).
        /// </summary>
        public gvec5<T> ggrgg => new gvec5<T>(y, y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.yyxyz swizzling.
        /// </summary>
        public gvec5<T> yyxyz => new gvec5<T>(y, y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.ggrgb swizzling (equivalent to gvec4.yyxyz).
        /// </summary>
        public gvec5<T> ggrgb => new gvec5<T>(y, y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.yyxyw swizzling.
        /// </summary>
        public gvec5<T> yyxyw => new gvec5<T>(y, y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.ggrga swizzling (equivalent to gvec4.yyxyw).
        /// </summary>
        public gvec5<T> ggrga => new gvec5<T>(y, y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.yyxz swizzling.
        /// </summary>
        public gvec4<T> yyxz => new gvec4<T>(y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.ggrb swizzling (equivalent to gvec4.yyxz).
        /// </summary>
        public gvec4<T> ggrb => new gvec4<T>(y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.yyxzx swizzling.
        /// </summary>
        public gvec5<T> yyxzx => new gvec5<T>(y, y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.ggrbr swizzling (equivalent to gvec4.yyxzx).
        /// </summary>
        public gvec5<T> ggrbr => new gvec5<T>(y, y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.yyxzy swizzling.
        /// </summary>
        public gvec5<T> yyxzy => new gvec5<T>(y, y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.ggrbg swizzling (equivalent to gvec4.yyxzy).
        /// </summary>
        public gvec5<T> ggrbg => new gvec5<T>(y, y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.yyxzz swizzling.
        /// </summary>
        public gvec5<T> yyxzz => new gvec5<T>(y, y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.ggrbb swizzling (equivalent to gvec4.yyxzz).
        /// </summary>
        public gvec5<T> ggrbb => new gvec5<T>(y, y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.yyxzw swizzling.
        /// </summary>
        public gvec5<T> yyxzw => new gvec5<T>(y, y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.ggrba swizzling (equivalent to gvec4.yyxzw).
        /// </summary>
        public gvec5<T> ggrba => new gvec5<T>(y, y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.yyxw swizzling.
        /// </summary>
        public gvec4<T> yyxw => new gvec4<T>(y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.ggra swizzling (equivalent to gvec4.yyxw).
        /// </summary>
        public gvec4<T> ggra => new gvec4<T>(y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.yyxwx swizzling.
        /// </summary>
        public gvec5<T> yyxwx => new gvec5<T>(y, y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.ggrar swizzling (equivalent to gvec4.yyxwx).
        /// </summary>
        public gvec5<T> ggrar => new gvec5<T>(y, y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.yyxwy swizzling.
        /// </summary>
        public gvec5<T> yyxwy => new gvec5<T>(y, y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.ggrag swizzling (equivalent to gvec4.yyxwy).
        /// </summary>
        public gvec5<T> ggrag => new gvec5<T>(y, y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.yyxwz swizzling.
        /// </summary>
        public gvec5<T> yyxwz => new gvec5<T>(y, y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.ggrab swizzling (equivalent to gvec4.yyxwz).
        /// </summary>
        public gvec5<T> ggrab => new gvec5<T>(y, y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.yyxww swizzling.
        /// </summary>
        public gvec5<T> yyxww => new gvec5<T>(y, y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.ggraa swizzling (equivalent to gvec4.yyxww).
        /// </summary>
        public gvec5<T> ggraa => new gvec5<T>(y, y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.yyy swizzling.
        /// </summary>
        public gvec3<T> yyy => new gvec3<T>(y, y, y);
        
        /// <summary>
        /// Returns gvec4.ggg swizzling (equivalent to gvec4.yyy).
        /// </summary>
        public gvec3<T> ggg => new gvec3<T>(y, y, y);
        
        /// <summary>
        /// Returns gvec4.yyyx swizzling.
        /// </summary>
        public gvec4<T> yyyx => new gvec4<T>(y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.gggr swizzling (equivalent to gvec4.yyyx).
        /// </summary>
        public gvec4<T> gggr => new gvec4<T>(y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.yyyxx swizzling.
        /// </summary>
        public gvec5<T> yyyxx => new gvec5<T>(y, y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.gggrr swizzling (equivalent to gvec4.yyyxx).
        /// </summary>
        public gvec5<T> gggrr => new gvec5<T>(y, y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.yyyxy swizzling.
        /// </summary>
        public gvec5<T> yyyxy => new gvec5<T>(y, y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.gggrg swizzling (equivalent to gvec4.yyyxy).
        /// </summary>
        public gvec5<T> gggrg => new gvec5<T>(y, y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.yyyxz swizzling.
        /// </summary>
        public gvec5<T> yyyxz => new gvec5<T>(y, y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.gggrb swizzling (equivalent to gvec4.yyyxz).
        /// </summary>
        public gvec5<T> gggrb => new gvec5<T>(y, y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.yyyxw swizzling.
        /// </summary>
        public gvec5<T> yyyxw => new gvec5<T>(y, y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.gggra swizzling (equivalent to gvec4.yyyxw).
        /// </summary>
        public gvec5<T> gggra => new gvec5<T>(y, y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.yyyy swizzling.
        /// </summary>
        public gvec4<T> yyyy => new gvec4<T>(y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.gggg swizzling (equivalent to gvec4.yyyy).
        /// </summary>
        public gvec4<T> gggg => new gvec4<T>(y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.yyyyx swizzling.
        /// </summary>
        public gvec5<T> yyyyx => new gvec5<T>(y, y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.ggggr swizzling (equivalent to gvec4.yyyyx).
        /// </summary>
        public gvec5<T> ggggr => new gvec5<T>(y, y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.yyyyy swizzling.
        /// </summary>
        public gvec5<T> yyyyy => new gvec5<T>(y, y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.ggggg swizzling (equivalent to gvec4.yyyyy).
        /// </summary>
        public gvec5<T> ggggg => new gvec5<T>(y, y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.yyyyz swizzling.
        /// </summary>
        public gvec5<T> yyyyz => new gvec5<T>(y, y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.ggggb swizzling (equivalent to gvec4.yyyyz).
        /// </summary>
        public gvec5<T> ggggb => new gvec5<T>(y, y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.yyyyw swizzling.
        /// </summary>
        public gvec5<T> yyyyw => new gvec5<T>(y, y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.gggga swizzling (equivalent to gvec4.yyyyw).
        /// </summary>
        public gvec5<T> gggga => new gvec5<T>(y, y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.yyyz swizzling.
        /// </summary>
        public gvec4<T> yyyz => new gvec4<T>(y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.gggb swizzling (equivalent to gvec4.yyyz).
        /// </summary>
        public gvec4<T> gggb => new gvec4<T>(y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.yyyzx swizzling.
        /// </summary>
        public gvec5<T> yyyzx => new gvec5<T>(y, y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.gggbr swizzling (equivalent to gvec4.yyyzx).
        /// </summary>
        public gvec5<T> gggbr => new gvec5<T>(y, y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.yyyzy swizzling.
        /// </summary>
        public gvec5<T> yyyzy => new gvec5<T>(y, y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.gggbg swizzling (equivalent to gvec4.yyyzy).
        /// </summary>
        public gvec5<T> gggbg => new gvec5<T>(y, y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.yyyzz swizzling.
        /// </summary>
        public gvec5<T> yyyzz => new gvec5<T>(y, y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.gggbb swizzling (equivalent to gvec4.yyyzz).
        /// </summary>
        public gvec5<T> gggbb => new gvec5<T>(y, y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.yyyzw swizzling.
        /// </summary>
        public gvec5<T> yyyzw => new gvec5<T>(y, y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.gggba swizzling (equivalent to gvec4.yyyzw).
        /// </summary>
        public gvec5<T> gggba => new gvec5<T>(y, y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.yyyw swizzling.
        /// </summary>
        public gvec4<T> yyyw => new gvec4<T>(y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.ggga swizzling (equivalent to gvec4.yyyw).
        /// </summary>
        public gvec4<T> ggga => new gvec4<T>(y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.yyywx swizzling.
        /// </summary>
        public gvec5<T> yyywx => new gvec5<T>(y, y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.gggar swizzling (equivalent to gvec4.yyywx).
        /// </summary>
        public gvec5<T> gggar => new gvec5<T>(y, y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.yyywy swizzling.
        /// </summary>
        public gvec5<T> yyywy => new gvec5<T>(y, y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.gggag swizzling (equivalent to gvec4.yyywy).
        /// </summary>
        public gvec5<T> gggag => new gvec5<T>(y, y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.yyywz swizzling.
        /// </summary>
        public gvec5<T> yyywz => new gvec5<T>(y, y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.gggab swizzling (equivalent to gvec4.yyywz).
        /// </summary>
        public gvec5<T> gggab => new gvec5<T>(y, y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.yyyww swizzling.
        /// </summary>
        public gvec5<T> yyyww => new gvec5<T>(y, y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.gggaa swizzling (equivalent to gvec4.yyyww).
        /// </summary>
        public gvec5<T> gggaa => new gvec5<T>(y, y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.yyz swizzling.
        /// </summary>
        public gvec3<T> yyz => new gvec3<T>(y, y, z);
        
        /// <summary>
        /// Returns gvec4.ggb swizzling (equivalent to gvec4.yyz).
        /// </summary>
        public gvec3<T> ggb => new gvec3<T>(y, y, z);
        
        /// <summary>
        /// Returns gvec4.yyzx swizzling.
        /// </summary>
        public gvec4<T> yyzx => new gvec4<T>(y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.ggbr swizzling (equivalent to gvec4.yyzx).
        /// </summary>
        public gvec4<T> ggbr => new gvec4<T>(y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.yyzxx swizzling.
        /// </summary>
        public gvec5<T> yyzxx => new gvec5<T>(y, y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.ggbrr swizzling (equivalent to gvec4.yyzxx).
        /// </summary>
        public gvec5<T> ggbrr => new gvec5<T>(y, y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.yyzxy swizzling.
        /// </summary>
        public gvec5<T> yyzxy => new gvec5<T>(y, y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.ggbrg swizzling (equivalent to gvec4.yyzxy).
        /// </summary>
        public gvec5<T> ggbrg => new gvec5<T>(y, y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.yyzxz swizzling.
        /// </summary>
        public gvec5<T> yyzxz => new gvec5<T>(y, y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.ggbrb swizzling (equivalent to gvec4.yyzxz).
        /// </summary>
        public gvec5<T> ggbrb => new gvec5<T>(y, y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.yyzxw swizzling.
        /// </summary>
        public gvec5<T> yyzxw => new gvec5<T>(y, y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.ggbra swizzling (equivalent to gvec4.yyzxw).
        /// </summary>
        public gvec5<T> ggbra => new gvec5<T>(y, y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.yyzy swizzling.
        /// </summary>
        public gvec4<T> yyzy => new gvec4<T>(y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.ggbg swizzling (equivalent to gvec4.yyzy).
        /// </summary>
        public gvec4<T> ggbg => new gvec4<T>(y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.yyzyx swizzling.
        /// </summary>
        public gvec5<T> yyzyx => new gvec5<T>(y, y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.ggbgr swizzling (equivalent to gvec4.yyzyx).
        /// </summary>
        public gvec5<T> ggbgr => new gvec5<T>(y, y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.yyzyy swizzling.
        /// </summary>
        public gvec5<T> yyzyy => new gvec5<T>(y, y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.ggbgg swizzling (equivalent to gvec4.yyzyy).
        /// </summary>
        public gvec5<T> ggbgg => new gvec5<T>(y, y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.yyzyz swizzling.
        /// </summary>
        public gvec5<T> yyzyz => new gvec5<T>(y, y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.ggbgb swizzling (equivalent to gvec4.yyzyz).
        /// </summary>
        public gvec5<T> ggbgb => new gvec5<T>(y, y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.yyzyw swizzling.
        /// </summary>
        public gvec5<T> yyzyw => new gvec5<T>(y, y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.ggbga swizzling (equivalent to gvec4.yyzyw).
        /// </summary>
        public gvec5<T> ggbga => new gvec5<T>(y, y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.yyzz swizzling.
        /// </summary>
        public gvec4<T> yyzz => new gvec4<T>(y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.ggbb swizzling (equivalent to gvec4.yyzz).
        /// </summary>
        public gvec4<T> ggbb => new gvec4<T>(y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.yyzzx swizzling.
        /// </summary>
        public gvec5<T> yyzzx => new gvec5<T>(y, y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.ggbbr swizzling (equivalent to gvec4.yyzzx).
        /// </summary>
        public gvec5<T> ggbbr => new gvec5<T>(y, y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.yyzzy swizzling.
        /// </summary>
        public gvec5<T> yyzzy => new gvec5<T>(y, y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.ggbbg swizzling (equivalent to gvec4.yyzzy).
        /// </summary>
        public gvec5<T> ggbbg => new gvec5<T>(y, y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.yyzzz swizzling.
        /// </summary>
        public gvec5<T> yyzzz => new gvec5<T>(y, y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.ggbbb swizzling (equivalent to gvec4.yyzzz).
        /// </summary>
        public gvec5<T> ggbbb => new gvec5<T>(y, y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.yyzzw swizzling.
        /// </summary>
        public gvec5<T> yyzzw => new gvec5<T>(y, y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.ggbba swizzling (equivalent to gvec4.yyzzw).
        /// </summary>
        public gvec5<T> ggbba => new gvec5<T>(y, y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.yyzw swizzling.
        /// </summary>
        public gvec4<T> yyzw => new gvec4<T>(y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.ggba swizzling (equivalent to gvec4.yyzw).
        /// </summary>
        public gvec4<T> ggba => new gvec4<T>(y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.yyzwx swizzling.
        /// </summary>
        public gvec5<T> yyzwx => new gvec5<T>(y, y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.ggbar swizzling (equivalent to gvec4.yyzwx).
        /// </summary>
        public gvec5<T> ggbar => new gvec5<T>(y, y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.yyzwy swizzling.
        /// </summary>
        public gvec5<T> yyzwy => new gvec5<T>(y, y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.ggbag swizzling (equivalent to gvec4.yyzwy).
        /// </summary>
        public gvec5<T> ggbag => new gvec5<T>(y, y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.yyzwz swizzling.
        /// </summary>
        public gvec5<T> yyzwz => new gvec5<T>(y, y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.ggbab swizzling (equivalent to gvec4.yyzwz).
        /// </summary>
        public gvec5<T> ggbab => new gvec5<T>(y, y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.yyzww swizzling.
        /// </summary>
        public gvec5<T> yyzww => new gvec5<T>(y, y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.ggbaa swizzling (equivalent to gvec4.yyzww).
        /// </summary>
        public gvec5<T> ggbaa => new gvec5<T>(y, y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.yyw swizzling.
        /// </summary>
        public gvec3<T> yyw => new gvec3<T>(y, y, w);
        
        /// <summary>
        /// Returns gvec4.gga swizzling (equivalent to gvec4.yyw).
        /// </summary>
        public gvec3<T> gga => new gvec3<T>(y, y, w);
        
        /// <summary>
        /// Returns gvec4.yywx swizzling.
        /// </summary>
        public gvec4<T> yywx => new gvec4<T>(y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.ggar swizzling (equivalent to gvec4.yywx).
        /// </summary>
        public gvec4<T> ggar => new gvec4<T>(y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.yywxx swizzling.
        /// </summary>
        public gvec5<T> yywxx => new gvec5<T>(y, y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.ggarr swizzling (equivalent to gvec4.yywxx).
        /// </summary>
        public gvec5<T> ggarr => new gvec5<T>(y, y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.yywxy swizzling.
        /// </summary>
        public gvec5<T> yywxy => new gvec5<T>(y, y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.ggarg swizzling (equivalent to gvec4.yywxy).
        /// </summary>
        public gvec5<T> ggarg => new gvec5<T>(y, y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.yywxz swizzling.
        /// </summary>
        public gvec5<T> yywxz => new gvec5<T>(y, y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.ggarb swizzling (equivalent to gvec4.yywxz).
        /// </summary>
        public gvec5<T> ggarb => new gvec5<T>(y, y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.yywxw swizzling.
        /// </summary>
        public gvec5<T> yywxw => new gvec5<T>(y, y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.ggara swizzling (equivalent to gvec4.yywxw).
        /// </summary>
        public gvec5<T> ggara => new gvec5<T>(y, y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.yywy swizzling.
        /// </summary>
        public gvec4<T> yywy => new gvec4<T>(y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.ggag swizzling (equivalent to gvec4.yywy).
        /// </summary>
        public gvec4<T> ggag => new gvec4<T>(y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.yywyx swizzling.
        /// </summary>
        public gvec5<T> yywyx => new gvec5<T>(y, y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.ggagr swizzling (equivalent to gvec4.yywyx).
        /// </summary>
        public gvec5<T> ggagr => new gvec5<T>(y, y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.yywyy swizzling.
        /// </summary>
        public gvec5<T> yywyy => new gvec5<T>(y, y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.ggagg swizzling (equivalent to gvec4.yywyy).
        /// </summary>
        public gvec5<T> ggagg => new gvec5<T>(y, y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.yywyz swizzling.
        /// </summary>
        public gvec5<T> yywyz => new gvec5<T>(y, y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.ggagb swizzling (equivalent to gvec4.yywyz).
        /// </summary>
        public gvec5<T> ggagb => new gvec5<T>(y, y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.yywyw swizzling.
        /// </summary>
        public gvec5<T> yywyw => new gvec5<T>(y, y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.ggaga swizzling (equivalent to gvec4.yywyw).
        /// </summary>
        public gvec5<T> ggaga => new gvec5<T>(y, y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.yywz swizzling.
        /// </summary>
        public gvec4<T> yywz => new gvec4<T>(y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.ggab swizzling (equivalent to gvec4.yywz).
        /// </summary>
        public gvec4<T> ggab => new gvec4<T>(y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.yywzx swizzling.
        /// </summary>
        public gvec5<T> yywzx => new gvec5<T>(y, y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.ggabr swizzling (equivalent to gvec4.yywzx).
        /// </summary>
        public gvec5<T> ggabr => new gvec5<T>(y, y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.yywzy swizzling.
        /// </summary>
        public gvec5<T> yywzy => new gvec5<T>(y, y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.ggabg swizzling (equivalent to gvec4.yywzy).
        /// </summary>
        public gvec5<T> ggabg => new gvec5<T>(y, y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.yywzz swizzling.
        /// </summary>
        public gvec5<T> yywzz => new gvec5<T>(y, y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.ggabb swizzling (equivalent to gvec4.yywzz).
        /// </summary>
        public gvec5<T> ggabb => new gvec5<T>(y, y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.yywzw swizzling.
        /// </summary>
        public gvec5<T> yywzw => new gvec5<T>(y, y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.ggaba swizzling (equivalent to gvec4.yywzw).
        /// </summary>
        public gvec5<T> ggaba => new gvec5<T>(y, y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.yyww swizzling.
        /// </summary>
        public gvec4<T> yyww => new gvec4<T>(y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.ggaa swizzling (equivalent to gvec4.yyww).
        /// </summary>
        public gvec4<T> ggaa => new gvec4<T>(y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.yywwx swizzling.
        /// </summary>
        public gvec5<T> yywwx => new gvec5<T>(y, y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.ggaar swizzling (equivalent to gvec4.yywwx).
        /// </summary>
        public gvec5<T> ggaar => new gvec5<T>(y, y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.yywwy swizzling.
        /// </summary>
        public gvec5<T> yywwy => new gvec5<T>(y, y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.ggaag swizzling (equivalent to gvec4.yywwy).
        /// </summary>
        public gvec5<T> ggaag => new gvec5<T>(y, y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.yywwz swizzling.
        /// </summary>
        public gvec5<T> yywwz => new gvec5<T>(y, y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.ggaab swizzling (equivalent to gvec4.yywwz).
        /// </summary>
        public gvec5<T> ggaab => new gvec5<T>(y, y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.yywww swizzling.
        /// </summary>
        public gvec5<T> yywww => new gvec5<T>(y, y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.ggaaa swizzling (equivalent to gvec4.yywww).
        /// </summary>
        public gvec5<T> ggaaa => new gvec5<T>(y, y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.yz swizzling.
        /// </summary>
        public gvec2<T> yz => new gvec2<T>(y, z);
        
        /// <summary>
        /// Returns gvec4.gb swizzling (equivalent to gvec4.yz).
        /// </summary>
        public gvec2<T> gb => new gvec2<T>(y, z);
        
        /// <summary>
        /// Returns gvec4.yzx swizzling.
        /// </summary>
        public gvec3<T> yzx => new gvec3<T>(y, z, x);
        
        /// <summary>
        /// Returns gvec4.gbr swizzling (equivalent to gvec4.yzx).
        /// </summary>
        public gvec3<T> gbr => new gvec3<T>(y, z, x);
        
        /// <summary>
        /// Returns gvec4.yzxx swizzling.
        /// </summary>
        public gvec4<T> yzxx => new gvec4<T>(y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.gbrr swizzling (equivalent to gvec4.yzxx).
        /// </summary>
        public gvec4<T> gbrr => new gvec4<T>(y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.yzxxx swizzling.
        /// </summary>
        public gvec5<T> yzxxx => new gvec5<T>(y, z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.gbrrr swizzling (equivalent to gvec4.yzxxx).
        /// </summary>
        public gvec5<T> gbrrr => new gvec5<T>(y, z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.yzxxy swizzling.
        /// </summary>
        public gvec5<T> yzxxy => new gvec5<T>(y, z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.gbrrg swizzling (equivalent to gvec4.yzxxy).
        /// </summary>
        public gvec5<T> gbrrg => new gvec5<T>(y, z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.yzxxz swizzling.
        /// </summary>
        public gvec5<T> yzxxz => new gvec5<T>(y, z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.gbrrb swizzling (equivalent to gvec4.yzxxz).
        /// </summary>
        public gvec5<T> gbrrb => new gvec5<T>(y, z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.yzxxw swizzling.
        /// </summary>
        public gvec5<T> yzxxw => new gvec5<T>(y, z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.gbrra swizzling (equivalent to gvec4.yzxxw).
        /// </summary>
        public gvec5<T> gbrra => new gvec5<T>(y, z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.yzxy swizzling.
        /// </summary>
        public gvec4<T> yzxy => new gvec4<T>(y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.gbrg swizzling (equivalent to gvec4.yzxy).
        /// </summary>
        public gvec4<T> gbrg => new gvec4<T>(y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.yzxyx swizzling.
        /// </summary>
        public gvec5<T> yzxyx => new gvec5<T>(y, z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.gbrgr swizzling (equivalent to gvec4.yzxyx).
        /// </summary>
        public gvec5<T> gbrgr => new gvec5<T>(y, z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.yzxyy swizzling.
        /// </summary>
        public gvec5<T> yzxyy => new gvec5<T>(y, z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.gbrgg swizzling (equivalent to gvec4.yzxyy).
        /// </summary>
        public gvec5<T> gbrgg => new gvec5<T>(y, z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.yzxyz swizzling.
        /// </summary>
        public gvec5<T> yzxyz => new gvec5<T>(y, z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.gbrgb swizzling (equivalent to gvec4.yzxyz).
        /// </summary>
        public gvec5<T> gbrgb => new gvec5<T>(y, z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.yzxyw swizzling.
        /// </summary>
        public gvec5<T> yzxyw => new gvec5<T>(y, z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.gbrga swizzling (equivalent to gvec4.yzxyw).
        /// </summary>
        public gvec5<T> gbrga => new gvec5<T>(y, z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.yzxz swizzling.
        /// </summary>
        public gvec4<T> yzxz => new gvec4<T>(y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.gbrb swizzling (equivalent to gvec4.yzxz).
        /// </summary>
        public gvec4<T> gbrb => new gvec4<T>(y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.yzxzx swizzling.
        /// </summary>
        public gvec5<T> yzxzx => new gvec5<T>(y, z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.gbrbr swizzling (equivalent to gvec4.yzxzx).
        /// </summary>
        public gvec5<T> gbrbr => new gvec5<T>(y, z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.yzxzy swizzling.
        /// </summary>
        public gvec5<T> yzxzy => new gvec5<T>(y, z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.gbrbg swizzling (equivalent to gvec4.yzxzy).
        /// </summary>
        public gvec5<T> gbrbg => new gvec5<T>(y, z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.yzxzz swizzling.
        /// </summary>
        public gvec5<T> yzxzz => new gvec5<T>(y, z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.gbrbb swizzling (equivalent to gvec4.yzxzz).
        /// </summary>
        public gvec5<T> gbrbb => new gvec5<T>(y, z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.yzxzw swizzling.
        /// </summary>
        public gvec5<T> yzxzw => new gvec5<T>(y, z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.gbrba swizzling (equivalent to gvec4.yzxzw).
        /// </summary>
        public gvec5<T> gbrba => new gvec5<T>(y, z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.yzxw swizzling.
        /// </summary>
        public gvec4<T> yzxw => new gvec4<T>(y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.gbra swizzling (equivalent to gvec4.yzxw).
        /// </summary>
        public gvec4<T> gbra => new gvec4<T>(y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.yzxwx swizzling.
        /// </summary>
        public gvec5<T> yzxwx => new gvec5<T>(y, z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.gbrar swizzling (equivalent to gvec4.yzxwx).
        /// </summary>
        public gvec5<T> gbrar => new gvec5<T>(y, z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.yzxwy swizzling.
        /// </summary>
        public gvec5<T> yzxwy => new gvec5<T>(y, z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.gbrag swizzling (equivalent to gvec4.yzxwy).
        /// </summary>
        public gvec5<T> gbrag => new gvec5<T>(y, z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.yzxwz swizzling.
        /// </summary>
        public gvec5<T> yzxwz => new gvec5<T>(y, z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.gbrab swizzling (equivalent to gvec4.yzxwz).
        /// </summary>
        public gvec5<T> gbrab => new gvec5<T>(y, z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.yzxww swizzling.
        /// </summary>
        public gvec5<T> yzxww => new gvec5<T>(y, z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.gbraa swizzling (equivalent to gvec4.yzxww).
        /// </summary>
        public gvec5<T> gbraa => new gvec5<T>(y, z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.yzy swizzling.
        /// </summary>
        public gvec3<T> yzy => new gvec3<T>(y, z, y);
        
        /// <summary>
        /// Returns gvec4.gbg swizzling (equivalent to gvec4.yzy).
        /// </summary>
        public gvec3<T> gbg => new gvec3<T>(y, z, y);
        
        /// <summary>
        /// Returns gvec4.yzyx swizzling.
        /// </summary>
        public gvec4<T> yzyx => new gvec4<T>(y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.gbgr swizzling (equivalent to gvec4.yzyx).
        /// </summary>
        public gvec4<T> gbgr => new gvec4<T>(y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.yzyxx swizzling.
        /// </summary>
        public gvec5<T> yzyxx => new gvec5<T>(y, z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.gbgrr swizzling (equivalent to gvec4.yzyxx).
        /// </summary>
        public gvec5<T> gbgrr => new gvec5<T>(y, z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.yzyxy swizzling.
        /// </summary>
        public gvec5<T> yzyxy => new gvec5<T>(y, z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.gbgrg swizzling (equivalent to gvec4.yzyxy).
        /// </summary>
        public gvec5<T> gbgrg => new gvec5<T>(y, z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.yzyxz swizzling.
        /// </summary>
        public gvec5<T> yzyxz => new gvec5<T>(y, z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.gbgrb swizzling (equivalent to gvec4.yzyxz).
        /// </summary>
        public gvec5<T> gbgrb => new gvec5<T>(y, z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.yzyxw swizzling.
        /// </summary>
        public gvec5<T> yzyxw => new gvec5<T>(y, z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.gbgra swizzling (equivalent to gvec4.yzyxw).
        /// </summary>
        public gvec5<T> gbgra => new gvec5<T>(y, z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.yzyy swizzling.
        /// </summary>
        public gvec4<T> yzyy => new gvec4<T>(y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.gbgg swizzling (equivalent to gvec4.yzyy).
        /// </summary>
        public gvec4<T> gbgg => new gvec4<T>(y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.yzyyx swizzling.
        /// </summary>
        public gvec5<T> yzyyx => new gvec5<T>(y, z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.gbggr swizzling (equivalent to gvec4.yzyyx).
        /// </summary>
        public gvec5<T> gbggr => new gvec5<T>(y, z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.yzyyy swizzling.
        /// </summary>
        public gvec5<T> yzyyy => new gvec5<T>(y, z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.gbggg swizzling (equivalent to gvec4.yzyyy).
        /// </summary>
        public gvec5<T> gbggg => new gvec5<T>(y, z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.yzyyz swizzling.
        /// </summary>
        public gvec5<T> yzyyz => new gvec5<T>(y, z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.gbggb swizzling (equivalent to gvec4.yzyyz).
        /// </summary>
        public gvec5<T> gbggb => new gvec5<T>(y, z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.yzyyw swizzling.
        /// </summary>
        public gvec5<T> yzyyw => new gvec5<T>(y, z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.gbgga swizzling (equivalent to gvec4.yzyyw).
        /// </summary>
        public gvec5<T> gbgga => new gvec5<T>(y, z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.yzyz swizzling.
        /// </summary>
        public gvec4<T> yzyz => new gvec4<T>(y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.gbgb swizzling (equivalent to gvec4.yzyz).
        /// </summary>
        public gvec4<T> gbgb => new gvec4<T>(y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.yzyzx swizzling.
        /// </summary>
        public gvec5<T> yzyzx => new gvec5<T>(y, z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.gbgbr swizzling (equivalent to gvec4.yzyzx).
        /// </summary>
        public gvec5<T> gbgbr => new gvec5<T>(y, z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.yzyzy swizzling.
        /// </summary>
        public gvec5<T> yzyzy => new gvec5<T>(y, z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.gbgbg swizzling (equivalent to gvec4.yzyzy).
        /// </summary>
        public gvec5<T> gbgbg => new gvec5<T>(y, z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.yzyzz swizzling.
        /// </summary>
        public gvec5<T> yzyzz => new gvec5<T>(y, z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.gbgbb swizzling (equivalent to gvec4.yzyzz).
        /// </summary>
        public gvec5<T> gbgbb => new gvec5<T>(y, z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.yzyzw swizzling.
        /// </summary>
        public gvec5<T> yzyzw => new gvec5<T>(y, z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.gbgba swizzling (equivalent to gvec4.yzyzw).
        /// </summary>
        public gvec5<T> gbgba => new gvec5<T>(y, z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.yzyw swizzling.
        /// </summary>
        public gvec4<T> yzyw => new gvec4<T>(y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.gbga swizzling (equivalent to gvec4.yzyw).
        /// </summary>
        public gvec4<T> gbga => new gvec4<T>(y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.yzywx swizzling.
        /// </summary>
        public gvec5<T> yzywx => new gvec5<T>(y, z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.gbgar swizzling (equivalent to gvec4.yzywx).
        /// </summary>
        public gvec5<T> gbgar => new gvec5<T>(y, z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.yzywy swizzling.
        /// </summary>
        public gvec5<T> yzywy => new gvec5<T>(y, z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.gbgag swizzling (equivalent to gvec4.yzywy).
        /// </summary>
        public gvec5<T> gbgag => new gvec5<T>(y, z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.yzywz swizzling.
        /// </summary>
        public gvec5<T> yzywz => new gvec5<T>(y, z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.gbgab swizzling (equivalent to gvec4.yzywz).
        /// </summary>
        public gvec5<T> gbgab => new gvec5<T>(y, z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.yzyww swizzling.
        /// </summary>
        public gvec5<T> yzyww => new gvec5<T>(y, z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.gbgaa swizzling (equivalent to gvec4.yzyww).
        /// </summary>
        public gvec5<T> gbgaa => new gvec5<T>(y, z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.yzz swizzling.
        /// </summary>
        public gvec3<T> yzz => new gvec3<T>(y, z, z);
        
        /// <summary>
        /// Returns gvec4.gbb swizzling (equivalent to gvec4.yzz).
        /// </summary>
        public gvec3<T> gbb => new gvec3<T>(y, z, z);
        
        /// <summary>
        /// Returns gvec4.yzzx swizzling.
        /// </summary>
        public gvec4<T> yzzx => new gvec4<T>(y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.gbbr swizzling (equivalent to gvec4.yzzx).
        /// </summary>
        public gvec4<T> gbbr => new gvec4<T>(y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.yzzxx swizzling.
        /// </summary>
        public gvec5<T> yzzxx => new gvec5<T>(y, z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.gbbrr swizzling (equivalent to gvec4.yzzxx).
        /// </summary>
        public gvec5<T> gbbrr => new gvec5<T>(y, z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.yzzxy swizzling.
        /// </summary>
        public gvec5<T> yzzxy => new gvec5<T>(y, z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.gbbrg swizzling (equivalent to gvec4.yzzxy).
        /// </summary>
        public gvec5<T> gbbrg => new gvec5<T>(y, z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.yzzxz swizzling.
        /// </summary>
        public gvec5<T> yzzxz => new gvec5<T>(y, z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.gbbrb swizzling (equivalent to gvec4.yzzxz).
        /// </summary>
        public gvec5<T> gbbrb => new gvec5<T>(y, z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.yzzxw swizzling.
        /// </summary>
        public gvec5<T> yzzxw => new gvec5<T>(y, z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.gbbra swizzling (equivalent to gvec4.yzzxw).
        /// </summary>
        public gvec5<T> gbbra => new gvec5<T>(y, z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.yzzy swizzling.
        /// </summary>
        public gvec4<T> yzzy => new gvec4<T>(y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.gbbg swizzling (equivalent to gvec4.yzzy).
        /// </summary>
        public gvec4<T> gbbg => new gvec4<T>(y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.yzzyx swizzling.
        /// </summary>
        public gvec5<T> yzzyx => new gvec5<T>(y, z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.gbbgr swizzling (equivalent to gvec4.yzzyx).
        /// </summary>
        public gvec5<T> gbbgr => new gvec5<T>(y, z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.yzzyy swizzling.
        /// </summary>
        public gvec5<T> yzzyy => new gvec5<T>(y, z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.gbbgg swizzling (equivalent to gvec4.yzzyy).
        /// </summary>
        public gvec5<T> gbbgg => new gvec5<T>(y, z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.yzzyz swizzling.
        /// </summary>
        public gvec5<T> yzzyz => new gvec5<T>(y, z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.gbbgb swizzling (equivalent to gvec4.yzzyz).
        /// </summary>
        public gvec5<T> gbbgb => new gvec5<T>(y, z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.yzzyw swizzling.
        /// </summary>
        public gvec5<T> yzzyw => new gvec5<T>(y, z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.gbbga swizzling (equivalent to gvec4.yzzyw).
        /// </summary>
        public gvec5<T> gbbga => new gvec5<T>(y, z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.yzzz swizzling.
        /// </summary>
        public gvec4<T> yzzz => new gvec4<T>(y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.gbbb swizzling (equivalent to gvec4.yzzz).
        /// </summary>
        public gvec4<T> gbbb => new gvec4<T>(y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.yzzzx swizzling.
        /// </summary>
        public gvec5<T> yzzzx => new gvec5<T>(y, z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.gbbbr swizzling (equivalent to gvec4.yzzzx).
        /// </summary>
        public gvec5<T> gbbbr => new gvec5<T>(y, z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.yzzzy swizzling.
        /// </summary>
        public gvec5<T> yzzzy => new gvec5<T>(y, z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.gbbbg swizzling (equivalent to gvec4.yzzzy).
        /// </summary>
        public gvec5<T> gbbbg => new gvec5<T>(y, z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.yzzzz swizzling.
        /// </summary>
        public gvec5<T> yzzzz => new gvec5<T>(y, z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.gbbbb swizzling (equivalent to gvec4.yzzzz).
        /// </summary>
        public gvec5<T> gbbbb => new gvec5<T>(y, z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.yzzzw swizzling.
        /// </summary>
        public gvec5<T> yzzzw => new gvec5<T>(y, z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.gbbba swizzling (equivalent to gvec4.yzzzw).
        /// </summary>
        public gvec5<T> gbbba => new gvec5<T>(y, z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.yzzw swizzling.
        /// </summary>
        public gvec4<T> yzzw => new gvec4<T>(y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.gbba swizzling (equivalent to gvec4.yzzw).
        /// </summary>
        public gvec4<T> gbba => new gvec4<T>(y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.yzzwx swizzling.
        /// </summary>
        public gvec5<T> yzzwx => new gvec5<T>(y, z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.gbbar swizzling (equivalent to gvec4.yzzwx).
        /// </summary>
        public gvec5<T> gbbar => new gvec5<T>(y, z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.yzzwy swizzling.
        /// </summary>
        public gvec5<T> yzzwy => new gvec5<T>(y, z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.gbbag swizzling (equivalent to gvec4.yzzwy).
        /// </summary>
        public gvec5<T> gbbag => new gvec5<T>(y, z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.yzzwz swizzling.
        /// </summary>
        public gvec5<T> yzzwz => new gvec5<T>(y, z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.gbbab swizzling (equivalent to gvec4.yzzwz).
        /// </summary>
        public gvec5<T> gbbab => new gvec5<T>(y, z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.yzzww swizzling.
        /// </summary>
        public gvec5<T> yzzww => new gvec5<T>(y, z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.gbbaa swizzling (equivalent to gvec4.yzzww).
        /// </summary>
        public gvec5<T> gbbaa => new gvec5<T>(y, z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.yzw swizzling.
        /// </summary>
        public gvec3<T> yzw => new gvec3<T>(y, z, w);
        
        /// <summary>
        /// Returns gvec4.gba swizzling (equivalent to gvec4.yzw).
        /// </summary>
        public gvec3<T> gba => new gvec3<T>(y, z, w);
        
        /// <summary>
        /// Returns gvec4.yzwx swizzling.
        /// </summary>
        public gvec4<T> yzwx => new gvec4<T>(y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.gbar swizzling (equivalent to gvec4.yzwx).
        /// </summary>
        public gvec4<T> gbar => new gvec4<T>(y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.yzwxx swizzling.
        /// </summary>
        public gvec5<T> yzwxx => new gvec5<T>(y, z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.gbarr swizzling (equivalent to gvec4.yzwxx).
        /// </summary>
        public gvec5<T> gbarr => new gvec5<T>(y, z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.yzwxy swizzling.
        /// </summary>
        public gvec5<T> yzwxy => new gvec5<T>(y, z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.gbarg swizzling (equivalent to gvec4.yzwxy).
        /// </summary>
        public gvec5<T> gbarg => new gvec5<T>(y, z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.yzwxz swizzling.
        /// </summary>
        public gvec5<T> yzwxz => new gvec5<T>(y, z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.gbarb swizzling (equivalent to gvec4.yzwxz).
        /// </summary>
        public gvec5<T> gbarb => new gvec5<T>(y, z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.yzwxw swizzling.
        /// </summary>
        public gvec5<T> yzwxw => new gvec5<T>(y, z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.gbara swizzling (equivalent to gvec4.yzwxw).
        /// </summary>
        public gvec5<T> gbara => new gvec5<T>(y, z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.yzwy swizzling.
        /// </summary>
        public gvec4<T> yzwy => new gvec4<T>(y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.gbag swizzling (equivalent to gvec4.yzwy).
        /// </summary>
        public gvec4<T> gbag => new gvec4<T>(y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.yzwyx swizzling.
        /// </summary>
        public gvec5<T> yzwyx => new gvec5<T>(y, z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.gbagr swizzling (equivalent to gvec4.yzwyx).
        /// </summary>
        public gvec5<T> gbagr => new gvec5<T>(y, z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.yzwyy swizzling.
        /// </summary>
        public gvec5<T> yzwyy => new gvec5<T>(y, z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.gbagg swizzling (equivalent to gvec4.yzwyy).
        /// </summary>
        public gvec5<T> gbagg => new gvec5<T>(y, z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.yzwyz swizzling.
        /// </summary>
        public gvec5<T> yzwyz => new gvec5<T>(y, z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.gbagb swizzling (equivalent to gvec4.yzwyz).
        /// </summary>
        public gvec5<T> gbagb => new gvec5<T>(y, z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.yzwyw swizzling.
        /// </summary>
        public gvec5<T> yzwyw => new gvec5<T>(y, z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.gbaga swizzling (equivalent to gvec4.yzwyw).
        /// </summary>
        public gvec5<T> gbaga => new gvec5<T>(y, z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.yzwz swizzling.
        /// </summary>
        public gvec4<T> yzwz => new gvec4<T>(y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.gbab swizzling (equivalent to gvec4.yzwz).
        /// </summary>
        public gvec4<T> gbab => new gvec4<T>(y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.yzwzx swizzling.
        /// </summary>
        public gvec5<T> yzwzx => new gvec5<T>(y, z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.gbabr swizzling (equivalent to gvec4.yzwzx).
        /// </summary>
        public gvec5<T> gbabr => new gvec5<T>(y, z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.yzwzy swizzling.
        /// </summary>
        public gvec5<T> yzwzy => new gvec5<T>(y, z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.gbabg swizzling (equivalent to gvec4.yzwzy).
        /// </summary>
        public gvec5<T> gbabg => new gvec5<T>(y, z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.yzwzz swizzling.
        /// </summary>
        public gvec5<T> yzwzz => new gvec5<T>(y, z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.gbabb swizzling (equivalent to gvec4.yzwzz).
        /// </summary>
        public gvec5<T> gbabb => new gvec5<T>(y, z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.yzwzw swizzling.
        /// </summary>
        public gvec5<T> yzwzw => new gvec5<T>(y, z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.gbaba swizzling (equivalent to gvec4.yzwzw).
        /// </summary>
        public gvec5<T> gbaba => new gvec5<T>(y, z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.yzww swizzling.
        /// </summary>
        public gvec4<T> yzww => new gvec4<T>(y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.gbaa swizzling (equivalent to gvec4.yzww).
        /// </summary>
        public gvec4<T> gbaa => new gvec4<T>(y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.yzwwx swizzling.
        /// </summary>
        public gvec5<T> yzwwx => new gvec5<T>(y, z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.gbaar swizzling (equivalent to gvec4.yzwwx).
        /// </summary>
        public gvec5<T> gbaar => new gvec5<T>(y, z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.yzwwy swizzling.
        /// </summary>
        public gvec5<T> yzwwy => new gvec5<T>(y, z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.gbaag swizzling (equivalent to gvec4.yzwwy).
        /// </summary>
        public gvec5<T> gbaag => new gvec5<T>(y, z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.yzwwz swizzling.
        /// </summary>
        public gvec5<T> yzwwz => new gvec5<T>(y, z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.gbaab swizzling (equivalent to gvec4.yzwwz).
        /// </summary>
        public gvec5<T> gbaab => new gvec5<T>(y, z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.yzwww swizzling.
        /// </summary>
        public gvec5<T> yzwww => new gvec5<T>(y, z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.gbaaa swizzling (equivalent to gvec4.yzwww).
        /// </summary>
        public gvec5<T> gbaaa => new gvec5<T>(y, z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.yw swizzling.
        /// </summary>
        public gvec2<T> yw => new gvec2<T>(y, w);
        
        /// <summary>
        /// Returns gvec4.ga swizzling (equivalent to gvec4.yw).
        /// </summary>
        public gvec2<T> ga => new gvec2<T>(y, w);
        
        /// <summary>
        /// Returns gvec4.ywx swizzling.
        /// </summary>
        public gvec3<T> ywx => new gvec3<T>(y, w, x);
        
        /// <summary>
        /// Returns gvec4.gar swizzling (equivalent to gvec4.ywx).
        /// </summary>
        public gvec3<T> gar => new gvec3<T>(y, w, x);
        
        /// <summary>
        /// Returns gvec4.ywxx swizzling.
        /// </summary>
        public gvec4<T> ywxx => new gvec4<T>(y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.garr swizzling (equivalent to gvec4.ywxx).
        /// </summary>
        public gvec4<T> garr => new gvec4<T>(y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.ywxxx swizzling.
        /// </summary>
        public gvec5<T> ywxxx => new gvec5<T>(y, w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.garrr swizzling (equivalent to gvec4.ywxxx).
        /// </summary>
        public gvec5<T> garrr => new gvec5<T>(y, w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.ywxxy swizzling.
        /// </summary>
        public gvec5<T> ywxxy => new gvec5<T>(y, w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.garrg swizzling (equivalent to gvec4.ywxxy).
        /// </summary>
        public gvec5<T> garrg => new gvec5<T>(y, w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.ywxxz swizzling.
        /// </summary>
        public gvec5<T> ywxxz => new gvec5<T>(y, w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.garrb swizzling (equivalent to gvec4.ywxxz).
        /// </summary>
        public gvec5<T> garrb => new gvec5<T>(y, w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.ywxxw swizzling.
        /// </summary>
        public gvec5<T> ywxxw => new gvec5<T>(y, w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.garra swizzling (equivalent to gvec4.ywxxw).
        /// </summary>
        public gvec5<T> garra => new gvec5<T>(y, w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.ywxy swizzling.
        /// </summary>
        public gvec4<T> ywxy => new gvec4<T>(y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.garg swizzling (equivalent to gvec4.ywxy).
        /// </summary>
        public gvec4<T> garg => new gvec4<T>(y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.ywxyx swizzling.
        /// </summary>
        public gvec5<T> ywxyx => new gvec5<T>(y, w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.gargr swizzling (equivalent to gvec4.ywxyx).
        /// </summary>
        public gvec5<T> gargr => new gvec5<T>(y, w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.ywxyy swizzling.
        /// </summary>
        public gvec5<T> ywxyy => new gvec5<T>(y, w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.gargg swizzling (equivalent to gvec4.ywxyy).
        /// </summary>
        public gvec5<T> gargg => new gvec5<T>(y, w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.ywxyz swizzling.
        /// </summary>
        public gvec5<T> ywxyz => new gvec5<T>(y, w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.gargb swizzling (equivalent to gvec4.ywxyz).
        /// </summary>
        public gvec5<T> gargb => new gvec5<T>(y, w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.ywxyw swizzling.
        /// </summary>
        public gvec5<T> ywxyw => new gvec5<T>(y, w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.garga swizzling (equivalent to gvec4.ywxyw).
        /// </summary>
        public gvec5<T> garga => new gvec5<T>(y, w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.ywxz swizzling.
        /// </summary>
        public gvec4<T> ywxz => new gvec4<T>(y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.garb swizzling (equivalent to gvec4.ywxz).
        /// </summary>
        public gvec4<T> garb => new gvec4<T>(y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.ywxzx swizzling.
        /// </summary>
        public gvec5<T> ywxzx => new gvec5<T>(y, w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.garbr swizzling (equivalent to gvec4.ywxzx).
        /// </summary>
        public gvec5<T> garbr => new gvec5<T>(y, w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.ywxzy swizzling.
        /// </summary>
        public gvec5<T> ywxzy => new gvec5<T>(y, w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.garbg swizzling (equivalent to gvec4.ywxzy).
        /// </summary>
        public gvec5<T> garbg => new gvec5<T>(y, w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.ywxzz swizzling.
        /// </summary>
        public gvec5<T> ywxzz => new gvec5<T>(y, w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.garbb swizzling (equivalent to gvec4.ywxzz).
        /// </summary>
        public gvec5<T> garbb => new gvec5<T>(y, w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.ywxzw swizzling.
        /// </summary>
        public gvec5<T> ywxzw => new gvec5<T>(y, w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.garba swizzling (equivalent to gvec4.ywxzw).
        /// </summary>
        public gvec5<T> garba => new gvec5<T>(y, w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.ywxw swizzling.
        /// </summary>
        public gvec4<T> ywxw => new gvec4<T>(y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.gara swizzling (equivalent to gvec4.ywxw).
        /// </summary>
        public gvec4<T> gara => new gvec4<T>(y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.ywxwx swizzling.
        /// </summary>
        public gvec5<T> ywxwx => new gvec5<T>(y, w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.garar swizzling (equivalent to gvec4.ywxwx).
        /// </summary>
        public gvec5<T> garar => new gvec5<T>(y, w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.ywxwy swizzling.
        /// </summary>
        public gvec5<T> ywxwy => new gvec5<T>(y, w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.garag swizzling (equivalent to gvec4.ywxwy).
        /// </summary>
        public gvec5<T> garag => new gvec5<T>(y, w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.ywxwz swizzling.
        /// </summary>
        public gvec5<T> ywxwz => new gvec5<T>(y, w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.garab swizzling (equivalent to gvec4.ywxwz).
        /// </summary>
        public gvec5<T> garab => new gvec5<T>(y, w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.ywxww swizzling.
        /// </summary>
        public gvec5<T> ywxww => new gvec5<T>(y, w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.garaa swizzling (equivalent to gvec4.ywxww).
        /// </summary>
        public gvec5<T> garaa => new gvec5<T>(y, w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.ywy swizzling.
        /// </summary>
        public gvec3<T> ywy => new gvec3<T>(y, w, y);
        
        /// <summary>
        /// Returns gvec4.gag swizzling (equivalent to gvec4.ywy).
        /// </summary>
        public gvec3<T> gag => new gvec3<T>(y, w, y);
        
        /// <summary>
        /// Returns gvec4.ywyx swizzling.
        /// </summary>
        public gvec4<T> ywyx => new gvec4<T>(y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.gagr swizzling (equivalent to gvec4.ywyx).
        /// </summary>
        public gvec4<T> gagr => new gvec4<T>(y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.ywyxx swizzling.
        /// </summary>
        public gvec5<T> ywyxx => new gvec5<T>(y, w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.gagrr swizzling (equivalent to gvec4.ywyxx).
        /// </summary>
        public gvec5<T> gagrr => new gvec5<T>(y, w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.ywyxy swizzling.
        /// </summary>
        public gvec5<T> ywyxy => new gvec5<T>(y, w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.gagrg swizzling (equivalent to gvec4.ywyxy).
        /// </summary>
        public gvec5<T> gagrg => new gvec5<T>(y, w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.ywyxz swizzling.
        /// </summary>
        public gvec5<T> ywyxz => new gvec5<T>(y, w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.gagrb swizzling (equivalent to gvec4.ywyxz).
        /// </summary>
        public gvec5<T> gagrb => new gvec5<T>(y, w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.ywyxw swizzling.
        /// </summary>
        public gvec5<T> ywyxw => new gvec5<T>(y, w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.gagra swizzling (equivalent to gvec4.ywyxw).
        /// </summary>
        public gvec5<T> gagra => new gvec5<T>(y, w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.ywyy swizzling.
        /// </summary>
        public gvec4<T> ywyy => new gvec4<T>(y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.gagg swizzling (equivalent to gvec4.ywyy).
        /// </summary>
        public gvec4<T> gagg => new gvec4<T>(y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.ywyyx swizzling.
        /// </summary>
        public gvec5<T> ywyyx => new gvec5<T>(y, w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.gaggr swizzling (equivalent to gvec4.ywyyx).
        /// </summary>
        public gvec5<T> gaggr => new gvec5<T>(y, w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.ywyyy swizzling.
        /// </summary>
        public gvec5<T> ywyyy => new gvec5<T>(y, w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.gaggg swizzling (equivalent to gvec4.ywyyy).
        /// </summary>
        public gvec5<T> gaggg => new gvec5<T>(y, w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.ywyyz swizzling.
        /// </summary>
        public gvec5<T> ywyyz => new gvec5<T>(y, w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.gaggb swizzling (equivalent to gvec4.ywyyz).
        /// </summary>
        public gvec5<T> gaggb => new gvec5<T>(y, w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.ywyyw swizzling.
        /// </summary>
        public gvec5<T> ywyyw => new gvec5<T>(y, w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.gagga swizzling (equivalent to gvec4.ywyyw).
        /// </summary>
        public gvec5<T> gagga => new gvec5<T>(y, w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.ywyz swizzling.
        /// </summary>
        public gvec4<T> ywyz => new gvec4<T>(y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.gagb swizzling (equivalent to gvec4.ywyz).
        /// </summary>
        public gvec4<T> gagb => new gvec4<T>(y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.ywyzx swizzling.
        /// </summary>
        public gvec5<T> ywyzx => new gvec5<T>(y, w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.gagbr swizzling (equivalent to gvec4.ywyzx).
        /// </summary>
        public gvec5<T> gagbr => new gvec5<T>(y, w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.ywyzy swizzling.
        /// </summary>
        public gvec5<T> ywyzy => new gvec5<T>(y, w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.gagbg swizzling (equivalent to gvec4.ywyzy).
        /// </summary>
        public gvec5<T> gagbg => new gvec5<T>(y, w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.ywyzz swizzling.
        /// </summary>
        public gvec5<T> ywyzz => new gvec5<T>(y, w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.gagbb swizzling (equivalent to gvec4.ywyzz).
        /// </summary>
        public gvec5<T> gagbb => new gvec5<T>(y, w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.ywyzw swizzling.
        /// </summary>
        public gvec5<T> ywyzw => new gvec5<T>(y, w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.gagba swizzling (equivalent to gvec4.ywyzw).
        /// </summary>
        public gvec5<T> gagba => new gvec5<T>(y, w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.ywyw swizzling.
        /// </summary>
        public gvec4<T> ywyw => new gvec4<T>(y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.gaga swizzling (equivalent to gvec4.ywyw).
        /// </summary>
        public gvec4<T> gaga => new gvec4<T>(y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.ywywx swizzling.
        /// </summary>
        public gvec5<T> ywywx => new gvec5<T>(y, w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.gagar swizzling (equivalent to gvec4.ywywx).
        /// </summary>
        public gvec5<T> gagar => new gvec5<T>(y, w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.ywywy swizzling.
        /// </summary>
        public gvec5<T> ywywy => new gvec5<T>(y, w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.gagag swizzling (equivalent to gvec4.ywywy).
        /// </summary>
        public gvec5<T> gagag => new gvec5<T>(y, w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.ywywz swizzling.
        /// </summary>
        public gvec5<T> ywywz => new gvec5<T>(y, w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.gagab swizzling (equivalent to gvec4.ywywz).
        /// </summary>
        public gvec5<T> gagab => new gvec5<T>(y, w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.ywyww swizzling.
        /// </summary>
        public gvec5<T> ywyww => new gvec5<T>(y, w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.gagaa swizzling (equivalent to gvec4.ywyww).
        /// </summary>
        public gvec5<T> gagaa => new gvec5<T>(y, w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.ywz swizzling.
        /// </summary>
        public gvec3<T> ywz => new gvec3<T>(y, w, z);
        
        /// <summary>
        /// Returns gvec4.gab swizzling (equivalent to gvec4.ywz).
        /// </summary>
        public gvec3<T> gab => new gvec3<T>(y, w, z);
        
        /// <summary>
        /// Returns gvec4.ywzx swizzling.
        /// </summary>
        public gvec4<T> ywzx => new gvec4<T>(y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.gabr swizzling (equivalent to gvec4.ywzx).
        /// </summary>
        public gvec4<T> gabr => new gvec4<T>(y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.ywzxx swizzling.
        /// </summary>
        public gvec5<T> ywzxx => new gvec5<T>(y, w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.gabrr swizzling (equivalent to gvec4.ywzxx).
        /// </summary>
        public gvec5<T> gabrr => new gvec5<T>(y, w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.ywzxy swizzling.
        /// </summary>
        public gvec5<T> ywzxy => new gvec5<T>(y, w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.gabrg swizzling (equivalent to gvec4.ywzxy).
        /// </summary>
        public gvec5<T> gabrg => new gvec5<T>(y, w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.ywzxz swizzling.
        /// </summary>
        public gvec5<T> ywzxz => new gvec5<T>(y, w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.gabrb swizzling (equivalent to gvec4.ywzxz).
        /// </summary>
        public gvec5<T> gabrb => new gvec5<T>(y, w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.ywzxw swizzling.
        /// </summary>
        public gvec5<T> ywzxw => new gvec5<T>(y, w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.gabra swizzling (equivalent to gvec4.ywzxw).
        /// </summary>
        public gvec5<T> gabra => new gvec5<T>(y, w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.ywzy swizzling.
        /// </summary>
        public gvec4<T> ywzy => new gvec4<T>(y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.gabg swizzling (equivalent to gvec4.ywzy).
        /// </summary>
        public gvec4<T> gabg => new gvec4<T>(y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.ywzyx swizzling.
        /// </summary>
        public gvec5<T> ywzyx => new gvec5<T>(y, w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.gabgr swizzling (equivalent to gvec4.ywzyx).
        /// </summary>
        public gvec5<T> gabgr => new gvec5<T>(y, w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.ywzyy swizzling.
        /// </summary>
        public gvec5<T> ywzyy => new gvec5<T>(y, w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.gabgg swizzling (equivalent to gvec4.ywzyy).
        /// </summary>
        public gvec5<T> gabgg => new gvec5<T>(y, w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.ywzyz swizzling.
        /// </summary>
        public gvec5<T> ywzyz => new gvec5<T>(y, w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.gabgb swizzling (equivalent to gvec4.ywzyz).
        /// </summary>
        public gvec5<T> gabgb => new gvec5<T>(y, w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.ywzyw swizzling.
        /// </summary>
        public gvec5<T> ywzyw => new gvec5<T>(y, w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.gabga swizzling (equivalent to gvec4.ywzyw).
        /// </summary>
        public gvec5<T> gabga => new gvec5<T>(y, w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.ywzz swizzling.
        /// </summary>
        public gvec4<T> ywzz => new gvec4<T>(y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.gabb swizzling (equivalent to gvec4.ywzz).
        /// </summary>
        public gvec4<T> gabb => new gvec4<T>(y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.ywzzx swizzling.
        /// </summary>
        public gvec5<T> ywzzx => new gvec5<T>(y, w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.gabbr swizzling (equivalent to gvec4.ywzzx).
        /// </summary>
        public gvec5<T> gabbr => new gvec5<T>(y, w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.ywzzy swizzling.
        /// </summary>
        public gvec5<T> ywzzy => new gvec5<T>(y, w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.gabbg swizzling (equivalent to gvec4.ywzzy).
        /// </summary>
        public gvec5<T> gabbg => new gvec5<T>(y, w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.ywzzz swizzling.
        /// </summary>
        public gvec5<T> ywzzz => new gvec5<T>(y, w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.gabbb swizzling (equivalent to gvec4.ywzzz).
        /// </summary>
        public gvec5<T> gabbb => new gvec5<T>(y, w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.ywzzw swizzling.
        /// </summary>
        public gvec5<T> ywzzw => new gvec5<T>(y, w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.gabba swizzling (equivalent to gvec4.ywzzw).
        /// </summary>
        public gvec5<T> gabba => new gvec5<T>(y, w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.ywzw swizzling.
        /// </summary>
        public gvec4<T> ywzw => new gvec4<T>(y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.gaba swizzling (equivalent to gvec4.ywzw).
        /// </summary>
        public gvec4<T> gaba => new gvec4<T>(y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.ywzwx swizzling.
        /// </summary>
        public gvec5<T> ywzwx => new gvec5<T>(y, w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.gabar swizzling (equivalent to gvec4.ywzwx).
        /// </summary>
        public gvec5<T> gabar => new gvec5<T>(y, w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.ywzwy swizzling.
        /// </summary>
        public gvec5<T> ywzwy => new gvec5<T>(y, w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.gabag swizzling (equivalent to gvec4.ywzwy).
        /// </summary>
        public gvec5<T> gabag => new gvec5<T>(y, w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.ywzwz swizzling.
        /// </summary>
        public gvec5<T> ywzwz => new gvec5<T>(y, w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.gabab swizzling (equivalent to gvec4.ywzwz).
        /// </summary>
        public gvec5<T> gabab => new gvec5<T>(y, w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.ywzww swizzling.
        /// </summary>
        public gvec5<T> ywzww => new gvec5<T>(y, w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.gabaa swizzling (equivalent to gvec4.ywzww).
        /// </summary>
        public gvec5<T> gabaa => new gvec5<T>(y, w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.yww swizzling.
        /// </summary>
        public gvec3<T> yww => new gvec3<T>(y, w, w);
        
        /// <summary>
        /// Returns gvec4.gaa swizzling (equivalent to gvec4.yww).
        /// </summary>
        public gvec3<T> gaa => new gvec3<T>(y, w, w);
        
        /// <summary>
        /// Returns gvec4.ywwx swizzling.
        /// </summary>
        public gvec4<T> ywwx => new gvec4<T>(y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.gaar swizzling (equivalent to gvec4.ywwx).
        /// </summary>
        public gvec4<T> gaar => new gvec4<T>(y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.ywwxx swizzling.
        /// </summary>
        public gvec5<T> ywwxx => new gvec5<T>(y, w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.gaarr swizzling (equivalent to gvec4.ywwxx).
        /// </summary>
        public gvec5<T> gaarr => new gvec5<T>(y, w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.ywwxy swizzling.
        /// </summary>
        public gvec5<T> ywwxy => new gvec5<T>(y, w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.gaarg swizzling (equivalent to gvec4.ywwxy).
        /// </summary>
        public gvec5<T> gaarg => new gvec5<T>(y, w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.ywwxz swizzling.
        /// </summary>
        public gvec5<T> ywwxz => new gvec5<T>(y, w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.gaarb swizzling (equivalent to gvec4.ywwxz).
        /// </summary>
        public gvec5<T> gaarb => new gvec5<T>(y, w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.ywwxw swizzling.
        /// </summary>
        public gvec5<T> ywwxw => new gvec5<T>(y, w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.gaara swizzling (equivalent to gvec4.ywwxw).
        /// </summary>
        public gvec5<T> gaara => new gvec5<T>(y, w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.ywwy swizzling.
        /// </summary>
        public gvec4<T> ywwy => new gvec4<T>(y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.gaag swizzling (equivalent to gvec4.ywwy).
        /// </summary>
        public gvec4<T> gaag => new gvec4<T>(y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.ywwyx swizzling.
        /// </summary>
        public gvec5<T> ywwyx => new gvec5<T>(y, w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.gaagr swizzling (equivalent to gvec4.ywwyx).
        /// </summary>
        public gvec5<T> gaagr => new gvec5<T>(y, w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.ywwyy swizzling.
        /// </summary>
        public gvec5<T> ywwyy => new gvec5<T>(y, w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.gaagg swizzling (equivalent to gvec4.ywwyy).
        /// </summary>
        public gvec5<T> gaagg => new gvec5<T>(y, w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.ywwyz swizzling.
        /// </summary>
        public gvec5<T> ywwyz => new gvec5<T>(y, w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.gaagb swizzling (equivalent to gvec4.ywwyz).
        /// </summary>
        public gvec5<T> gaagb => new gvec5<T>(y, w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.ywwyw swizzling.
        /// </summary>
        public gvec5<T> ywwyw => new gvec5<T>(y, w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.gaaga swizzling (equivalent to gvec4.ywwyw).
        /// </summary>
        public gvec5<T> gaaga => new gvec5<T>(y, w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.ywwz swizzling.
        /// </summary>
        public gvec4<T> ywwz => new gvec4<T>(y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.gaab swizzling (equivalent to gvec4.ywwz).
        /// </summary>
        public gvec4<T> gaab => new gvec4<T>(y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.ywwzx swizzling.
        /// </summary>
        public gvec5<T> ywwzx => new gvec5<T>(y, w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.gaabr swizzling (equivalent to gvec4.ywwzx).
        /// </summary>
        public gvec5<T> gaabr => new gvec5<T>(y, w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.ywwzy swizzling.
        /// </summary>
        public gvec5<T> ywwzy => new gvec5<T>(y, w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.gaabg swizzling (equivalent to gvec4.ywwzy).
        /// </summary>
        public gvec5<T> gaabg => new gvec5<T>(y, w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.ywwzz swizzling.
        /// </summary>
        public gvec5<T> ywwzz => new gvec5<T>(y, w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.gaabb swizzling (equivalent to gvec4.ywwzz).
        /// </summary>
        public gvec5<T> gaabb => new gvec5<T>(y, w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.ywwzw swizzling.
        /// </summary>
        public gvec5<T> ywwzw => new gvec5<T>(y, w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.gaaba swizzling (equivalent to gvec4.ywwzw).
        /// </summary>
        public gvec5<T> gaaba => new gvec5<T>(y, w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.ywww swizzling.
        /// </summary>
        public gvec4<T> ywww => new gvec4<T>(y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.gaaa swizzling (equivalent to gvec4.ywww).
        /// </summary>
        public gvec4<T> gaaa => new gvec4<T>(y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.ywwwx swizzling.
        /// </summary>
        public gvec5<T> ywwwx => new gvec5<T>(y, w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.gaaar swizzling (equivalent to gvec4.ywwwx).
        /// </summary>
        public gvec5<T> gaaar => new gvec5<T>(y, w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.ywwwy swizzling.
        /// </summary>
        public gvec5<T> ywwwy => new gvec5<T>(y, w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.gaaag swizzling (equivalent to gvec4.ywwwy).
        /// </summary>
        public gvec5<T> gaaag => new gvec5<T>(y, w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.ywwwz swizzling.
        /// </summary>
        public gvec5<T> ywwwz => new gvec5<T>(y, w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.gaaab swizzling (equivalent to gvec4.ywwwz).
        /// </summary>
        public gvec5<T> gaaab => new gvec5<T>(y, w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.ywwww swizzling.
        /// </summary>
        public gvec5<T> ywwww => new gvec5<T>(y, w, w, w, w);
        
        /// <summary>
        /// Returns gvec4.gaaaa swizzling (equivalent to gvec4.ywwww).
        /// </summary>
        public gvec5<T> gaaaa => new gvec5<T>(y, w, w, w, w);
        
        /// <summary>
        /// Returns gvec4.zx swizzling.
        /// </summary>
        public gvec2<T> zx => new gvec2<T>(z, x);
        
        /// <summary>
        /// Returns gvec4.br swizzling (equivalent to gvec4.zx).
        /// </summary>
        public gvec2<T> br => new gvec2<T>(z, x);
        
        /// <summary>
        /// Returns gvec4.zxx swizzling.
        /// </summary>
        public gvec3<T> zxx => new gvec3<T>(z, x, x);
        
        /// <summary>
        /// Returns gvec4.brr swizzling (equivalent to gvec4.zxx).
        /// </summary>
        public gvec3<T> brr => new gvec3<T>(z, x, x);
        
        /// <summary>
        /// Returns gvec4.zxxx swizzling.
        /// </summary>
        public gvec4<T> zxxx => new gvec4<T>(z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.brrr swizzling (equivalent to gvec4.zxxx).
        /// </summary>
        public gvec4<T> brrr => new gvec4<T>(z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.zxxxx swizzling.
        /// </summary>
        public gvec5<T> zxxxx => new gvec5<T>(z, x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.brrrr swizzling (equivalent to gvec4.zxxxx).
        /// </summary>
        public gvec5<T> brrrr => new gvec5<T>(z, x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.zxxxy swizzling.
        /// </summary>
        public gvec5<T> zxxxy => new gvec5<T>(z, x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.brrrg swizzling (equivalent to gvec4.zxxxy).
        /// </summary>
        public gvec5<T> brrrg => new gvec5<T>(z, x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.zxxxz swizzling.
        /// </summary>
        public gvec5<T> zxxxz => new gvec5<T>(z, x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.brrrb swizzling (equivalent to gvec4.zxxxz).
        /// </summary>
        public gvec5<T> brrrb => new gvec5<T>(z, x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.zxxxw swizzling.
        /// </summary>
        public gvec5<T> zxxxw => new gvec5<T>(z, x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.brrra swizzling (equivalent to gvec4.zxxxw).
        /// </summary>
        public gvec5<T> brrra => new gvec5<T>(z, x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.zxxy swizzling.
        /// </summary>
        public gvec4<T> zxxy => new gvec4<T>(z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.brrg swizzling (equivalent to gvec4.zxxy).
        /// </summary>
        public gvec4<T> brrg => new gvec4<T>(z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.zxxyx swizzling.
        /// </summary>
        public gvec5<T> zxxyx => new gvec5<T>(z, x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.brrgr swizzling (equivalent to gvec4.zxxyx).
        /// </summary>
        public gvec5<T> brrgr => new gvec5<T>(z, x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.zxxyy swizzling.
        /// </summary>
        public gvec5<T> zxxyy => new gvec5<T>(z, x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.brrgg swizzling (equivalent to gvec4.zxxyy).
        /// </summary>
        public gvec5<T> brrgg => new gvec5<T>(z, x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.zxxyz swizzling.
        /// </summary>
        public gvec5<T> zxxyz => new gvec5<T>(z, x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.brrgb swizzling (equivalent to gvec4.zxxyz).
        /// </summary>
        public gvec5<T> brrgb => new gvec5<T>(z, x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.zxxyw swizzling.
        /// </summary>
        public gvec5<T> zxxyw => new gvec5<T>(z, x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.brrga swizzling (equivalent to gvec4.zxxyw).
        /// </summary>
        public gvec5<T> brrga => new gvec5<T>(z, x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.zxxz swizzling.
        /// </summary>
        public gvec4<T> zxxz => new gvec4<T>(z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.brrb swizzling (equivalent to gvec4.zxxz).
        /// </summary>
        public gvec4<T> brrb => new gvec4<T>(z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.zxxzx swizzling.
        /// </summary>
        public gvec5<T> zxxzx => new gvec5<T>(z, x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.brrbr swizzling (equivalent to gvec4.zxxzx).
        /// </summary>
        public gvec5<T> brrbr => new gvec5<T>(z, x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.zxxzy swizzling.
        /// </summary>
        public gvec5<T> zxxzy => new gvec5<T>(z, x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.brrbg swizzling (equivalent to gvec4.zxxzy).
        /// </summary>
        public gvec5<T> brrbg => new gvec5<T>(z, x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.zxxzz swizzling.
        /// </summary>
        public gvec5<T> zxxzz => new gvec5<T>(z, x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.brrbb swizzling (equivalent to gvec4.zxxzz).
        /// </summary>
        public gvec5<T> brrbb => new gvec5<T>(z, x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.zxxzw swizzling.
        /// </summary>
        public gvec5<T> zxxzw => new gvec5<T>(z, x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.brrba swizzling (equivalent to gvec4.zxxzw).
        /// </summary>
        public gvec5<T> brrba => new gvec5<T>(z, x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.zxxw swizzling.
        /// </summary>
        public gvec4<T> zxxw => new gvec4<T>(z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.brra swizzling (equivalent to gvec4.zxxw).
        /// </summary>
        public gvec4<T> brra => new gvec4<T>(z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.zxxwx swizzling.
        /// </summary>
        public gvec5<T> zxxwx => new gvec5<T>(z, x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.brrar swizzling (equivalent to gvec4.zxxwx).
        /// </summary>
        public gvec5<T> brrar => new gvec5<T>(z, x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.zxxwy swizzling.
        /// </summary>
        public gvec5<T> zxxwy => new gvec5<T>(z, x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.brrag swizzling (equivalent to gvec4.zxxwy).
        /// </summary>
        public gvec5<T> brrag => new gvec5<T>(z, x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.zxxwz swizzling.
        /// </summary>
        public gvec5<T> zxxwz => new gvec5<T>(z, x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.brrab swizzling (equivalent to gvec4.zxxwz).
        /// </summary>
        public gvec5<T> brrab => new gvec5<T>(z, x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.zxxww swizzling.
        /// </summary>
        public gvec5<T> zxxww => new gvec5<T>(z, x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.brraa swizzling (equivalent to gvec4.zxxww).
        /// </summary>
        public gvec5<T> brraa => new gvec5<T>(z, x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.zxy swizzling.
        /// </summary>
        public gvec3<T> zxy => new gvec3<T>(z, x, y);
        
        /// <summary>
        /// Returns gvec4.brg swizzling (equivalent to gvec4.zxy).
        /// </summary>
        public gvec3<T> brg => new gvec3<T>(z, x, y);
        
        /// <summary>
        /// Returns gvec4.zxyx swizzling.
        /// </summary>
        public gvec4<T> zxyx => new gvec4<T>(z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.brgr swizzling (equivalent to gvec4.zxyx).
        /// </summary>
        public gvec4<T> brgr => new gvec4<T>(z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.zxyxx swizzling.
        /// </summary>
        public gvec5<T> zxyxx => new gvec5<T>(z, x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.brgrr swizzling (equivalent to gvec4.zxyxx).
        /// </summary>
        public gvec5<T> brgrr => new gvec5<T>(z, x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.zxyxy swizzling.
        /// </summary>
        public gvec5<T> zxyxy => new gvec5<T>(z, x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.brgrg swizzling (equivalent to gvec4.zxyxy).
        /// </summary>
        public gvec5<T> brgrg => new gvec5<T>(z, x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.zxyxz swizzling.
        /// </summary>
        public gvec5<T> zxyxz => new gvec5<T>(z, x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.brgrb swizzling (equivalent to gvec4.zxyxz).
        /// </summary>
        public gvec5<T> brgrb => new gvec5<T>(z, x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.zxyxw swizzling.
        /// </summary>
        public gvec5<T> zxyxw => new gvec5<T>(z, x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.brgra swizzling (equivalent to gvec4.zxyxw).
        /// </summary>
        public gvec5<T> brgra => new gvec5<T>(z, x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.zxyy swizzling.
        /// </summary>
        public gvec4<T> zxyy => new gvec4<T>(z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.brgg swizzling (equivalent to gvec4.zxyy).
        /// </summary>
        public gvec4<T> brgg => new gvec4<T>(z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.zxyyx swizzling.
        /// </summary>
        public gvec5<T> zxyyx => new gvec5<T>(z, x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.brggr swizzling (equivalent to gvec4.zxyyx).
        /// </summary>
        public gvec5<T> brggr => new gvec5<T>(z, x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.zxyyy swizzling.
        /// </summary>
        public gvec5<T> zxyyy => new gvec5<T>(z, x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.brggg swizzling (equivalent to gvec4.zxyyy).
        /// </summary>
        public gvec5<T> brggg => new gvec5<T>(z, x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.zxyyz swizzling.
        /// </summary>
        public gvec5<T> zxyyz => new gvec5<T>(z, x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.brggb swizzling (equivalent to gvec4.zxyyz).
        /// </summary>
        public gvec5<T> brggb => new gvec5<T>(z, x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.zxyyw swizzling.
        /// </summary>
        public gvec5<T> zxyyw => new gvec5<T>(z, x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.brgga swizzling (equivalent to gvec4.zxyyw).
        /// </summary>
        public gvec5<T> brgga => new gvec5<T>(z, x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.zxyz swizzling.
        /// </summary>
        public gvec4<T> zxyz => new gvec4<T>(z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.brgb swizzling (equivalent to gvec4.zxyz).
        /// </summary>
        public gvec4<T> brgb => new gvec4<T>(z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.zxyzx swizzling.
        /// </summary>
        public gvec5<T> zxyzx => new gvec5<T>(z, x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.brgbr swizzling (equivalent to gvec4.zxyzx).
        /// </summary>
        public gvec5<T> brgbr => new gvec5<T>(z, x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.zxyzy swizzling.
        /// </summary>
        public gvec5<T> zxyzy => new gvec5<T>(z, x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.brgbg swizzling (equivalent to gvec4.zxyzy).
        /// </summary>
        public gvec5<T> brgbg => new gvec5<T>(z, x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.zxyzz swizzling.
        /// </summary>
        public gvec5<T> zxyzz => new gvec5<T>(z, x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.brgbb swizzling (equivalent to gvec4.zxyzz).
        /// </summary>
        public gvec5<T> brgbb => new gvec5<T>(z, x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.zxyzw swizzling.
        /// </summary>
        public gvec5<T> zxyzw => new gvec5<T>(z, x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.brgba swizzling (equivalent to gvec4.zxyzw).
        /// </summary>
        public gvec5<T> brgba => new gvec5<T>(z, x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.zxyw swizzling.
        /// </summary>
        public gvec4<T> zxyw => new gvec4<T>(z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.brga swizzling (equivalent to gvec4.zxyw).
        /// </summary>
        public gvec4<T> brga => new gvec4<T>(z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.zxywx swizzling.
        /// </summary>
        public gvec5<T> zxywx => new gvec5<T>(z, x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.brgar swizzling (equivalent to gvec4.zxywx).
        /// </summary>
        public gvec5<T> brgar => new gvec5<T>(z, x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.zxywy swizzling.
        /// </summary>
        public gvec5<T> zxywy => new gvec5<T>(z, x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.brgag swizzling (equivalent to gvec4.zxywy).
        /// </summary>
        public gvec5<T> brgag => new gvec5<T>(z, x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.zxywz swizzling.
        /// </summary>
        public gvec5<T> zxywz => new gvec5<T>(z, x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.brgab swizzling (equivalent to gvec4.zxywz).
        /// </summary>
        public gvec5<T> brgab => new gvec5<T>(z, x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.zxyww swizzling.
        /// </summary>
        public gvec5<T> zxyww => new gvec5<T>(z, x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.brgaa swizzling (equivalent to gvec4.zxyww).
        /// </summary>
        public gvec5<T> brgaa => new gvec5<T>(z, x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.zxz swizzling.
        /// </summary>
        public gvec3<T> zxz => new gvec3<T>(z, x, z);
        
        /// <summary>
        /// Returns gvec4.brb swizzling (equivalent to gvec4.zxz).
        /// </summary>
        public gvec3<T> brb => new gvec3<T>(z, x, z);
        
        /// <summary>
        /// Returns gvec4.zxzx swizzling.
        /// </summary>
        public gvec4<T> zxzx => new gvec4<T>(z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.brbr swizzling (equivalent to gvec4.zxzx).
        /// </summary>
        public gvec4<T> brbr => new gvec4<T>(z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.zxzxx swizzling.
        /// </summary>
        public gvec5<T> zxzxx => new gvec5<T>(z, x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.brbrr swizzling (equivalent to gvec4.zxzxx).
        /// </summary>
        public gvec5<T> brbrr => new gvec5<T>(z, x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.zxzxy swizzling.
        /// </summary>
        public gvec5<T> zxzxy => new gvec5<T>(z, x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.brbrg swizzling (equivalent to gvec4.zxzxy).
        /// </summary>
        public gvec5<T> brbrg => new gvec5<T>(z, x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.zxzxz swizzling.
        /// </summary>
        public gvec5<T> zxzxz => new gvec5<T>(z, x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.brbrb swizzling (equivalent to gvec4.zxzxz).
        /// </summary>
        public gvec5<T> brbrb => new gvec5<T>(z, x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.zxzxw swizzling.
        /// </summary>
        public gvec5<T> zxzxw => new gvec5<T>(z, x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.brbra swizzling (equivalent to gvec4.zxzxw).
        /// </summary>
        public gvec5<T> brbra => new gvec5<T>(z, x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.zxzy swizzling.
        /// </summary>
        public gvec4<T> zxzy => new gvec4<T>(z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.brbg swizzling (equivalent to gvec4.zxzy).
        /// </summary>
        public gvec4<T> brbg => new gvec4<T>(z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.zxzyx swizzling.
        /// </summary>
        public gvec5<T> zxzyx => new gvec5<T>(z, x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.brbgr swizzling (equivalent to gvec4.zxzyx).
        /// </summary>
        public gvec5<T> brbgr => new gvec5<T>(z, x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.zxzyy swizzling.
        /// </summary>
        public gvec5<T> zxzyy => new gvec5<T>(z, x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.brbgg swizzling (equivalent to gvec4.zxzyy).
        /// </summary>
        public gvec5<T> brbgg => new gvec5<T>(z, x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.zxzyz swizzling.
        /// </summary>
        public gvec5<T> zxzyz => new gvec5<T>(z, x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.brbgb swizzling (equivalent to gvec4.zxzyz).
        /// </summary>
        public gvec5<T> brbgb => new gvec5<T>(z, x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.zxzyw swizzling.
        /// </summary>
        public gvec5<T> zxzyw => new gvec5<T>(z, x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.brbga swizzling (equivalent to gvec4.zxzyw).
        /// </summary>
        public gvec5<T> brbga => new gvec5<T>(z, x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.zxzz swizzling.
        /// </summary>
        public gvec4<T> zxzz => new gvec4<T>(z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.brbb swizzling (equivalent to gvec4.zxzz).
        /// </summary>
        public gvec4<T> brbb => new gvec4<T>(z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.zxzzx swizzling.
        /// </summary>
        public gvec5<T> zxzzx => new gvec5<T>(z, x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.brbbr swizzling (equivalent to gvec4.zxzzx).
        /// </summary>
        public gvec5<T> brbbr => new gvec5<T>(z, x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.zxzzy swizzling.
        /// </summary>
        public gvec5<T> zxzzy => new gvec5<T>(z, x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.brbbg swizzling (equivalent to gvec4.zxzzy).
        /// </summary>
        public gvec5<T> brbbg => new gvec5<T>(z, x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.zxzzz swizzling.
        /// </summary>
        public gvec5<T> zxzzz => new gvec5<T>(z, x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.brbbb swizzling (equivalent to gvec4.zxzzz).
        /// </summary>
        public gvec5<T> brbbb => new gvec5<T>(z, x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.zxzzw swizzling.
        /// </summary>
        public gvec5<T> zxzzw => new gvec5<T>(z, x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.brbba swizzling (equivalent to gvec4.zxzzw).
        /// </summary>
        public gvec5<T> brbba => new gvec5<T>(z, x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.zxzw swizzling.
        /// </summary>
        public gvec4<T> zxzw => new gvec4<T>(z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.brba swizzling (equivalent to gvec4.zxzw).
        /// </summary>
        public gvec4<T> brba => new gvec4<T>(z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.zxzwx swizzling.
        /// </summary>
        public gvec5<T> zxzwx => new gvec5<T>(z, x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.brbar swizzling (equivalent to gvec4.zxzwx).
        /// </summary>
        public gvec5<T> brbar => new gvec5<T>(z, x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.zxzwy swizzling.
        /// </summary>
        public gvec5<T> zxzwy => new gvec5<T>(z, x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.brbag swizzling (equivalent to gvec4.zxzwy).
        /// </summary>
        public gvec5<T> brbag => new gvec5<T>(z, x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.zxzwz swizzling.
        /// </summary>
        public gvec5<T> zxzwz => new gvec5<T>(z, x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.brbab swizzling (equivalent to gvec4.zxzwz).
        /// </summary>
        public gvec5<T> brbab => new gvec5<T>(z, x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.zxzww swizzling.
        /// </summary>
        public gvec5<T> zxzww => new gvec5<T>(z, x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.brbaa swizzling (equivalent to gvec4.zxzww).
        /// </summary>
        public gvec5<T> brbaa => new gvec5<T>(z, x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.zxw swizzling.
        /// </summary>
        public gvec3<T> zxw => new gvec3<T>(z, x, w);
        
        /// <summary>
        /// Returns gvec4.bra swizzling (equivalent to gvec4.zxw).
        /// </summary>
        public gvec3<T> bra => new gvec3<T>(z, x, w);
        
        /// <summary>
        /// Returns gvec4.zxwx swizzling.
        /// </summary>
        public gvec4<T> zxwx => new gvec4<T>(z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.brar swizzling (equivalent to gvec4.zxwx).
        /// </summary>
        public gvec4<T> brar => new gvec4<T>(z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.zxwxx swizzling.
        /// </summary>
        public gvec5<T> zxwxx => new gvec5<T>(z, x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.brarr swizzling (equivalent to gvec4.zxwxx).
        /// </summary>
        public gvec5<T> brarr => new gvec5<T>(z, x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.zxwxy swizzling.
        /// </summary>
        public gvec5<T> zxwxy => new gvec5<T>(z, x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.brarg swizzling (equivalent to gvec4.zxwxy).
        /// </summary>
        public gvec5<T> brarg => new gvec5<T>(z, x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.zxwxz swizzling.
        /// </summary>
        public gvec5<T> zxwxz => new gvec5<T>(z, x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.brarb swizzling (equivalent to gvec4.zxwxz).
        /// </summary>
        public gvec5<T> brarb => new gvec5<T>(z, x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.zxwxw swizzling.
        /// </summary>
        public gvec5<T> zxwxw => new gvec5<T>(z, x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.brara swizzling (equivalent to gvec4.zxwxw).
        /// </summary>
        public gvec5<T> brara => new gvec5<T>(z, x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.zxwy swizzling.
        /// </summary>
        public gvec4<T> zxwy => new gvec4<T>(z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.brag swizzling (equivalent to gvec4.zxwy).
        /// </summary>
        public gvec4<T> brag => new gvec4<T>(z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.zxwyx swizzling.
        /// </summary>
        public gvec5<T> zxwyx => new gvec5<T>(z, x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.bragr swizzling (equivalent to gvec4.zxwyx).
        /// </summary>
        public gvec5<T> bragr => new gvec5<T>(z, x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.zxwyy swizzling.
        /// </summary>
        public gvec5<T> zxwyy => new gvec5<T>(z, x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.bragg swizzling (equivalent to gvec4.zxwyy).
        /// </summary>
        public gvec5<T> bragg => new gvec5<T>(z, x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.zxwyz swizzling.
        /// </summary>
        public gvec5<T> zxwyz => new gvec5<T>(z, x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.bragb swizzling (equivalent to gvec4.zxwyz).
        /// </summary>
        public gvec5<T> bragb => new gvec5<T>(z, x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.zxwyw swizzling.
        /// </summary>
        public gvec5<T> zxwyw => new gvec5<T>(z, x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.braga swizzling (equivalent to gvec4.zxwyw).
        /// </summary>
        public gvec5<T> braga => new gvec5<T>(z, x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.zxwz swizzling.
        /// </summary>
        public gvec4<T> zxwz => new gvec4<T>(z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.brab swizzling (equivalent to gvec4.zxwz).
        /// </summary>
        public gvec4<T> brab => new gvec4<T>(z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.zxwzx swizzling.
        /// </summary>
        public gvec5<T> zxwzx => new gvec5<T>(z, x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.brabr swizzling (equivalent to gvec4.zxwzx).
        /// </summary>
        public gvec5<T> brabr => new gvec5<T>(z, x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.zxwzy swizzling.
        /// </summary>
        public gvec5<T> zxwzy => new gvec5<T>(z, x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.brabg swizzling (equivalent to gvec4.zxwzy).
        /// </summary>
        public gvec5<T> brabg => new gvec5<T>(z, x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.zxwzz swizzling.
        /// </summary>
        public gvec5<T> zxwzz => new gvec5<T>(z, x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.brabb swizzling (equivalent to gvec4.zxwzz).
        /// </summary>
        public gvec5<T> brabb => new gvec5<T>(z, x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.zxwzw swizzling.
        /// </summary>
        public gvec5<T> zxwzw => new gvec5<T>(z, x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.braba swizzling (equivalent to gvec4.zxwzw).
        /// </summary>
        public gvec5<T> braba => new gvec5<T>(z, x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.zxww swizzling.
        /// </summary>
        public gvec4<T> zxww => new gvec4<T>(z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.braa swizzling (equivalent to gvec4.zxww).
        /// </summary>
        public gvec4<T> braa => new gvec4<T>(z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.zxwwx swizzling.
        /// </summary>
        public gvec5<T> zxwwx => new gvec5<T>(z, x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.braar swizzling (equivalent to gvec4.zxwwx).
        /// </summary>
        public gvec5<T> braar => new gvec5<T>(z, x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.zxwwy swizzling.
        /// </summary>
        public gvec5<T> zxwwy => new gvec5<T>(z, x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.braag swizzling (equivalent to gvec4.zxwwy).
        /// </summary>
        public gvec5<T> braag => new gvec5<T>(z, x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.zxwwz swizzling.
        /// </summary>
        public gvec5<T> zxwwz => new gvec5<T>(z, x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.braab swizzling (equivalent to gvec4.zxwwz).
        /// </summary>
        public gvec5<T> braab => new gvec5<T>(z, x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.zxwww swizzling.
        /// </summary>
        public gvec5<T> zxwww => new gvec5<T>(z, x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.braaa swizzling (equivalent to gvec4.zxwww).
        /// </summary>
        public gvec5<T> braaa => new gvec5<T>(z, x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.zy swizzling.
        /// </summary>
        public gvec2<T> zy => new gvec2<T>(z, y);
        
        /// <summary>
        /// Returns gvec4.bg swizzling (equivalent to gvec4.zy).
        /// </summary>
        public gvec2<T> bg => new gvec2<T>(z, y);
        
        /// <summary>
        /// Returns gvec4.zyx swizzling.
        /// </summary>
        public gvec3<T> zyx => new gvec3<T>(z, y, x);
        
        /// <summary>
        /// Returns gvec4.bgr swizzling (equivalent to gvec4.zyx).
        /// </summary>
        public gvec3<T> bgr => new gvec3<T>(z, y, x);
        
        /// <summary>
        /// Returns gvec4.zyxx swizzling.
        /// </summary>
        public gvec4<T> zyxx => new gvec4<T>(z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.bgrr swizzling (equivalent to gvec4.zyxx).
        /// </summary>
        public gvec4<T> bgrr => new gvec4<T>(z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.zyxxx swizzling.
        /// </summary>
        public gvec5<T> zyxxx => new gvec5<T>(z, y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.bgrrr swizzling (equivalent to gvec4.zyxxx).
        /// </summary>
        public gvec5<T> bgrrr => new gvec5<T>(z, y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.zyxxy swizzling.
        /// </summary>
        public gvec5<T> zyxxy => new gvec5<T>(z, y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.bgrrg swizzling (equivalent to gvec4.zyxxy).
        /// </summary>
        public gvec5<T> bgrrg => new gvec5<T>(z, y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.zyxxz swizzling.
        /// </summary>
        public gvec5<T> zyxxz => new gvec5<T>(z, y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.bgrrb swizzling (equivalent to gvec4.zyxxz).
        /// </summary>
        public gvec5<T> bgrrb => new gvec5<T>(z, y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.zyxxw swizzling.
        /// </summary>
        public gvec5<T> zyxxw => new gvec5<T>(z, y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.bgrra swizzling (equivalent to gvec4.zyxxw).
        /// </summary>
        public gvec5<T> bgrra => new gvec5<T>(z, y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.zyxy swizzling.
        /// </summary>
        public gvec4<T> zyxy => new gvec4<T>(z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.bgrg swizzling (equivalent to gvec4.zyxy).
        /// </summary>
        public gvec4<T> bgrg => new gvec4<T>(z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.zyxyx swizzling.
        /// </summary>
        public gvec5<T> zyxyx => new gvec5<T>(z, y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.bgrgr swizzling (equivalent to gvec4.zyxyx).
        /// </summary>
        public gvec5<T> bgrgr => new gvec5<T>(z, y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.zyxyy swizzling.
        /// </summary>
        public gvec5<T> zyxyy => new gvec5<T>(z, y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.bgrgg swizzling (equivalent to gvec4.zyxyy).
        /// </summary>
        public gvec5<T> bgrgg => new gvec5<T>(z, y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.zyxyz swizzling.
        /// </summary>
        public gvec5<T> zyxyz => new gvec5<T>(z, y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.bgrgb swizzling (equivalent to gvec4.zyxyz).
        /// </summary>
        public gvec5<T> bgrgb => new gvec5<T>(z, y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.zyxyw swizzling.
        /// </summary>
        public gvec5<T> zyxyw => new gvec5<T>(z, y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.bgrga swizzling (equivalent to gvec4.zyxyw).
        /// </summary>
        public gvec5<T> bgrga => new gvec5<T>(z, y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.zyxz swizzling.
        /// </summary>
        public gvec4<T> zyxz => new gvec4<T>(z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.bgrb swizzling (equivalent to gvec4.zyxz).
        /// </summary>
        public gvec4<T> bgrb => new gvec4<T>(z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.zyxzx swizzling.
        /// </summary>
        public gvec5<T> zyxzx => new gvec5<T>(z, y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.bgrbr swizzling (equivalent to gvec4.zyxzx).
        /// </summary>
        public gvec5<T> bgrbr => new gvec5<T>(z, y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.zyxzy swizzling.
        /// </summary>
        public gvec5<T> zyxzy => new gvec5<T>(z, y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.bgrbg swizzling (equivalent to gvec4.zyxzy).
        /// </summary>
        public gvec5<T> bgrbg => new gvec5<T>(z, y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.zyxzz swizzling.
        /// </summary>
        public gvec5<T> zyxzz => new gvec5<T>(z, y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.bgrbb swizzling (equivalent to gvec4.zyxzz).
        /// </summary>
        public gvec5<T> bgrbb => new gvec5<T>(z, y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.zyxzw swizzling.
        /// </summary>
        public gvec5<T> zyxzw => new gvec5<T>(z, y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.bgrba swizzling (equivalent to gvec4.zyxzw).
        /// </summary>
        public gvec5<T> bgrba => new gvec5<T>(z, y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.zyxw swizzling.
        /// </summary>
        public gvec4<T> zyxw => new gvec4<T>(z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.bgra swizzling (equivalent to gvec4.zyxw).
        /// </summary>
        public gvec4<T> bgra => new gvec4<T>(z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.zyxwx swizzling.
        /// </summary>
        public gvec5<T> zyxwx => new gvec5<T>(z, y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.bgrar swizzling (equivalent to gvec4.zyxwx).
        /// </summary>
        public gvec5<T> bgrar => new gvec5<T>(z, y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.zyxwy swizzling.
        /// </summary>
        public gvec5<T> zyxwy => new gvec5<T>(z, y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.bgrag swizzling (equivalent to gvec4.zyxwy).
        /// </summary>
        public gvec5<T> bgrag => new gvec5<T>(z, y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.zyxwz swizzling.
        /// </summary>
        public gvec5<T> zyxwz => new gvec5<T>(z, y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.bgrab swizzling (equivalent to gvec4.zyxwz).
        /// </summary>
        public gvec5<T> bgrab => new gvec5<T>(z, y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.zyxww swizzling.
        /// </summary>
        public gvec5<T> zyxww => new gvec5<T>(z, y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.bgraa swizzling (equivalent to gvec4.zyxww).
        /// </summary>
        public gvec5<T> bgraa => new gvec5<T>(z, y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.zyy swizzling.
        /// </summary>
        public gvec3<T> zyy => new gvec3<T>(z, y, y);
        
        /// <summary>
        /// Returns gvec4.bgg swizzling (equivalent to gvec4.zyy).
        /// </summary>
        public gvec3<T> bgg => new gvec3<T>(z, y, y);
        
        /// <summary>
        /// Returns gvec4.zyyx swizzling.
        /// </summary>
        public gvec4<T> zyyx => new gvec4<T>(z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.bggr swizzling (equivalent to gvec4.zyyx).
        /// </summary>
        public gvec4<T> bggr => new gvec4<T>(z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.zyyxx swizzling.
        /// </summary>
        public gvec5<T> zyyxx => new gvec5<T>(z, y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.bggrr swizzling (equivalent to gvec4.zyyxx).
        /// </summary>
        public gvec5<T> bggrr => new gvec5<T>(z, y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.zyyxy swizzling.
        /// </summary>
        public gvec5<T> zyyxy => new gvec5<T>(z, y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.bggrg swizzling (equivalent to gvec4.zyyxy).
        /// </summary>
        public gvec5<T> bggrg => new gvec5<T>(z, y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.zyyxz swizzling.
        /// </summary>
        public gvec5<T> zyyxz => new gvec5<T>(z, y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.bggrb swizzling (equivalent to gvec4.zyyxz).
        /// </summary>
        public gvec5<T> bggrb => new gvec5<T>(z, y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.zyyxw swizzling.
        /// </summary>
        public gvec5<T> zyyxw => new gvec5<T>(z, y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.bggra swizzling (equivalent to gvec4.zyyxw).
        /// </summary>
        public gvec5<T> bggra => new gvec5<T>(z, y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.zyyy swizzling.
        /// </summary>
        public gvec4<T> zyyy => new gvec4<T>(z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.bggg swizzling (equivalent to gvec4.zyyy).
        /// </summary>
        public gvec4<T> bggg => new gvec4<T>(z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.zyyyx swizzling.
        /// </summary>
        public gvec5<T> zyyyx => new gvec5<T>(z, y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.bgggr swizzling (equivalent to gvec4.zyyyx).
        /// </summary>
        public gvec5<T> bgggr => new gvec5<T>(z, y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.zyyyy swizzling.
        /// </summary>
        public gvec5<T> zyyyy => new gvec5<T>(z, y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.bgggg swizzling (equivalent to gvec4.zyyyy).
        /// </summary>
        public gvec5<T> bgggg => new gvec5<T>(z, y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.zyyyz swizzling.
        /// </summary>
        public gvec5<T> zyyyz => new gvec5<T>(z, y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.bgggb swizzling (equivalent to gvec4.zyyyz).
        /// </summary>
        public gvec5<T> bgggb => new gvec5<T>(z, y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.zyyyw swizzling.
        /// </summary>
        public gvec5<T> zyyyw => new gvec5<T>(z, y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.bggga swizzling (equivalent to gvec4.zyyyw).
        /// </summary>
        public gvec5<T> bggga => new gvec5<T>(z, y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.zyyz swizzling.
        /// </summary>
        public gvec4<T> zyyz => new gvec4<T>(z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.bggb swizzling (equivalent to gvec4.zyyz).
        /// </summary>
        public gvec4<T> bggb => new gvec4<T>(z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.zyyzx swizzling.
        /// </summary>
        public gvec5<T> zyyzx => new gvec5<T>(z, y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.bggbr swizzling (equivalent to gvec4.zyyzx).
        /// </summary>
        public gvec5<T> bggbr => new gvec5<T>(z, y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.zyyzy swizzling.
        /// </summary>
        public gvec5<T> zyyzy => new gvec5<T>(z, y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.bggbg swizzling (equivalent to gvec4.zyyzy).
        /// </summary>
        public gvec5<T> bggbg => new gvec5<T>(z, y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.zyyzz swizzling.
        /// </summary>
        public gvec5<T> zyyzz => new gvec5<T>(z, y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.bggbb swizzling (equivalent to gvec4.zyyzz).
        /// </summary>
        public gvec5<T> bggbb => new gvec5<T>(z, y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.zyyzw swizzling.
        /// </summary>
        public gvec5<T> zyyzw => new gvec5<T>(z, y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.bggba swizzling (equivalent to gvec4.zyyzw).
        /// </summary>
        public gvec5<T> bggba => new gvec5<T>(z, y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.zyyw swizzling.
        /// </summary>
        public gvec4<T> zyyw => new gvec4<T>(z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.bgga swizzling (equivalent to gvec4.zyyw).
        /// </summary>
        public gvec4<T> bgga => new gvec4<T>(z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.zyywx swizzling.
        /// </summary>
        public gvec5<T> zyywx => new gvec5<T>(z, y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.bggar swizzling (equivalent to gvec4.zyywx).
        /// </summary>
        public gvec5<T> bggar => new gvec5<T>(z, y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.zyywy swizzling.
        /// </summary>
        public gvec5<T> zyywy => new gvec5<T>(z, y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.bggag swizzling (equivalent to gvec4.zyywy).
        /// </summary>
        public gvec5<T> bggag => new gvec5<T>(z, y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.zyywz swizzling.
        /// </summary>
        public gvec5<T> zyywz => new gvec5<T>(z, y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.bggab swizzling (equivalent to gvec4.zyywz).
        /// </summary>
        public gvec5<T> bggab => new gvec5<T>(z, y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.zyyww swizzling.
        /// </summary>
        public gvec5<T> zyyww => new gvec5<T>(z, y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.bggaa swizzling (equivalent to gvec4.zyyww).
        /// </summary>
        public gvec5<T> bggaa => new gvec5<T>(z, y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.zyz swizzling.
        /// </summary>
        public gvec3<T> zyz => new gvec3<T>(z, y, z);
        
        /// <summary>
        /// Returns gvec4.bgb swizzling (equivalent to gvec4.zyz).
        /// </summary>
        public gvec3<T> bgb => new gvec3<T>(z, y, z);
        
        /// <summary>
        /// Returns gvec4.zyzx swizzling.
        /// </summary>
        public gvec4<T> zyzx => new gvec4<T>(z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.bgbr swizzling (equivalent to gvec4.zyzx).
        /// </summary>
        public gvec4<T> bgbr => new gvec4<T>(z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.zyzxx swizzling.
        /// </summary>
        public gvec5<T> zyzxx => new gvec5<T>(z, y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.bgbrr swizzling (equivalent to gvec4.zyzxx).
        /// </summary>
        public gvec5<T> bgbrr => new gvec5<T>(z, y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.zyzxy swizzling.
        /// </summary>
        public gvec5<T> zyzxy => new gvec5<T>(z, y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.bgbrg swizzling (equivalent to gvec4.zyzxy).
        /// </summary>
        public gvec5<T> bgbrg => new gvec5<T>(z, y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.zyzxz swizzling.
        /// </summary>
        public gvec5<T> zyzxz => new gvec5<T>(z, y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.bgbrb swizzling (equivalent to gvec4.zyzxz).
        /// </summary>
        public gvec5<T> bgbrb => new gvec5<T>(z, y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.zyzxw swizzling.
        /// </summary>
        public gvec5<T> zyzxw => new gvec5<T>(z, y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.bgbra swizzling (equivalent to gvec4.zyzxw).
        /// </summary>
        public gvec5<T> bgbra => new gvec5<T>(z, y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.zyzy swizzling.
        /// </summary>
        public gvec4<T> zyzy => new gvec4<T>(z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.bgbg swizzling (equivalent to gvec4.zyzy).
        /// </summary>
        public gvec4<T> bgbg => new gvec4<T>(z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.zyzyx swizzling.
        /// </summary>
        public gvec5<T> zyzyx => new gvec5<T>(z, y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.bgbgr swizzling (equivalent to gvec4.zyzyx).
        /// </summary>
        public gvec5<T> bgbgr => new gvec5<T>(z, y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.zyzyy swizzling.
        /// </summary>
        public gvec5<T> zyzyy => new gvec5<T>(z, y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.bgbgg swizzling (equivalent to gvec4.zyzyy).
        /// </summary>
        public gvec5<T> bgbgg => new gvec5<T>(z, y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.zyzyz swizzling.
        /// </summary>
        public gvec5<T> zyzyz => new gvec5<T>(z, y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.bgbgb swizzling (equivalent to gvec4.zyzyz).
        /// </summary>
        public gvec5<T> bgbgb => new gvec5<T>(z, y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.zyzyw swizzling.
        /// </summary>
        public gvec5<T> zyzyw => new gvec5<T>(z, y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.bgbga swizzling (equivalent to gvec4.zyzyw).
        /// </summary>
        public gvec5<T> bgbga => new gvec5<T>(z, y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.zyzz swizzling.
        /// </summary>
        public gvec4<T> zyzz => new gvec4<T>(z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.bgbb swizzling (equivalent to gvec4.zyzz).
        /// </summary>
        public gvec4<T> bgbb => new gvec4<T>(z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.zyzzx swizzling.
        /// </summary>
        public gvec5<T> zyzzx => new gvec5<T>(z, y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.bgbbr swizzling (equivalent to gvec4.zyzzx).
        /// </summary>
        public gvec5<T> bgbbr => new gvec5<T>(z, y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.zyzzy swizzling.
        /// </summary>
        public gvec5<T> zyzzy => new gvec5<T>(z, y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.bgbbg swizzling (equivalent to gvec4.zyzzy).
        /// </summary>
        public gvec5<T> bgbbg => new gvec5<T>(z, y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.zyzzz swizzling.
        /// </summary>
        public gvec5<T> zyzzz => new gvec5<T>(z, y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.bgbbb swizzling (equivalent to gvec4.zyzzz).
        /// </summary>
        public gvec5<T> bgbbb => new gvec5<T>(z, y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.zyzzw swizzling.
        /// </summary>
        public gvec5<T> zyzzw => new gvec5<T>(z, y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.bgbba swizzling (equivalent to gvec4.zyzzw).
        /// </summary>
        public gvec5<T> bgbba => new gvec5<T>(z, y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.zyzw swizzling.
        /// </summary>
        public gvec4<T> zyzw => new gvec4<T>(z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.bgba swizzling (equivalent to gvec4.zyzw).
        /// </summary>
        public gvec4<T> bgba => new gvec4<T>(z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.zyzwx swizzling.
        /// </summary>
        public gvec5<T> zyzwx => new gvec5<T>(z, y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.bgbar swizzling (equivalent to gvec4.zyzwx).
        /// </summary>
        public gvec5<T> bgbar => new gvec5<T>(z, y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.zyzwy swizzling.
        /// </summary>
        public gvec5<T> zyzwy => new gvec5<T>(z, y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.bgbag swizzling (equivalent to gvec4.zyzwy).
        /// </summary>
        public gvec5<T> bgbag => new gvec5<T>(z, y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.zyzwz swizzling.
        /// </summary>
        public gvec5<T> zyzwz => new gvec5<T>(z, y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.bgbab swizzling (equivalent to gvec4.zyzwz).
        /// </summary>
        public gvec5<T> bgbab => new gvec5<T>(z, y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.zyzww swizzling.
        /// </summary>
        public gvec5<T> zyzww => new gvec5<T>(z, y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.bgbaa swizzling (equivalent to gvec4.zyzww).
        /// </summary>
        public gvec5<T> bgbaa => new gvec5<T>(z, y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.zyw swizzling.
        /// </summary>
        public gvec3<T> zyw => new gvec3<T>(z, y, w);
        
        /// <summary>
        /// Returns gvec4.bga swizzling (equivalent to gvec4.zyw).
        /// </summary>
        public gvec3<T> bga => new gvec3<T>(z, y, w);
        
        /// <summary>
        /// Returns gvec4.zywx swizzling.
        /// </summary>
        public gvec4<T> zywx => new gvec4<T>(z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.bgar swizzling (equivalent to gvec4.zywx).
        /// </summary>
        public gvec4<T> bgar => new gvec4<T>(z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.zywxx swizzling.
        /// </summary>
        public gvec5<T> zywxx => new gvec5<T>(z, y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.bgarr swizzling (equivalent to gvec4.zywxx).
        /// </summary>
        public gvec5<T> bgarr => new gvec5<T>(z, y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.zywxy swizzling.
        /// </summary>
        public gvec5<T> zywxy => new gvec5<T>(z, y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.bgarg swizzling (equivalent to gvec4.zywxy).
        /// </summary>
        public gvec5<T> bgarg => new gvec5<T>(z, y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.zywxz swizzling.
        /// </summary>
        public gvec5<T> zywxz => new gvec5<T>(z, y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.bgarb swizzling (equivalent to gvec4.zywxz).
        /// </summary>
        public gvec5<T> bgarb => new gvec5<T>(z, y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.zywxw swizzling.
        /// </summary>
        public gvec5<T> zywxw => new gvec5<T>(z, y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.bgara swizzling (equivalent to gvec4.zywxw).
        /// </summary>
        public gvec5<T> bgara => new gvec5<T>(z, y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.zywy swizzling.
        /// </summary>
        public gvec4<T> zywy => new gvec4<T>(z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.bgag swizzling (equivalent to gvec4.zywy).
        /// </summary>
        public gvec4<T> bgag => new gvec4<T>(z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.zywyx swizzling.
        /// </summary>
        public gvec5<T> zywyx => new gvec5<T>(z, y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.bgagr swizzling (equivalent to gvec4.zywyx).
        /// </summary>
        public gvec5<T> bgagr => new gvec5<T>(z, y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.zywyy swizzling.
        /// </summary>
        public gvec5<T> zywyy => new gvec5<T>(z, y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.bgagg swizzling (equivalent to gvec4.zywyy).
        /// </summary>
        public gvec5<T> bgagg => new gvec5<T>(z, y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.zywyz swizzling.
        /// </summary>
        public gvec5<T> zywyz => new gvec5<T>(z, y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.bgagb swizzling (equivalent to gvec4.zywyz).
        /// </summary>
        public gvec5<T> bgagb => new gvec5<T>(z, y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.zywyw swizzling.
        /// </summary>
        public gvec5<T> zywyw => new gvec5<T>(z, y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.bgaga swizzling (equivalent to gvec4.zywyw).
        /// </summary>
        public gvec5<T> bgaga => new gvec5<T>(z, y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.zywz swizzling.
        /// </summary>
        public gvec4<T> zywz => new gvec4<T>(z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.bgab swizzling (equivalent to gvec4.zywz).
        /// </summary>
        public gvec4<T> bgab => new gvec4<T>(z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.zywzx swizzling.
        /// </summary>
        public gvec5<T> zywzx => new gvec5<T>(z, y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.bgabr swizzling (equivalent to gvec4.zywzx).
        /// </summary>
        public gvec5<T> bgabr => new gvec5<T>(z, y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.zywzy swizzling.
        /// </summary>
        public gvec5<T> zywzy => new gvec5<T>(z, y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.bgabg swizzling (equivalent to gvec4.zywzy).
        /// </summary>
        public gvec5<T> bgabg => new gvec5<T>(z, y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.zywzz swizzling.
        /// </summary>
        public gvec5<T> zywzz => new gvec5<T>(z, y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.bgabb swizzling (equivalent to gvec4.zywzz).
        /// </summary>
        public gvec5<T> bgabb => new gvec5<T>(z, y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.zywzw swizzling.
        /// </summary>
        public gvec5<T> zywzw => new gvec5<T>(z, y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.bgaba swizzling (equivalent to gvec4.zywzw).
        /// </summary>
        public gvec5<T> bgaba => new gvec5<T>(z, y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.zyww swizzling.
        /// </summary>
        public gvec4<T> zyww => new gvec4<T>(z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.bgaa swizzling (equivalent to gvec4.zyww).
        /// </summary>
        public gvec4<T> bgaa => new gvec4<T>(z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.zywwx swizzling.
        /// </summary>
        public gvec5<T> zywwx => new gvec5<T>(z, y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.bgaar swizzling (equivalent to gvec4.zywwx).
        /// </summary>
        public gvec5<T> bgaar => new gvec5<T>(z, y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.zywwy swizzling.
        /// </summary>
        public gvec5<T> zywwy => new gvec5<T>(z, y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.bgaag swizzling (equivalent to gvec4.zywwy).
        /// </summary>
        public gvec5<T> bgaag => new gvec5<T>(z, y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.zywwz swizzling.
        /// </summary>
        public gvec5<T> zywwz => new gvec5<T>(z, y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.bgaab swizzling (equivalent to gvec4.zywwz).
        /// </summary>
        public gvec5<T> bgaab => new gvec5<T>(z, y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.zywww swizzling.
        /// </summary>
        public gvec5<T> zywww => new gvec5<T>(z, y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.bgaaa swizzling (equivalent to gvec4.zywww).
        /// </summary>
        public gvec5<T> bgaaa => new gvec5<T>(z, y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.zz swizzling.
        /// </summary>
        public gvec2<T> zz => new gvec2<T>(z, z);
        
        /// <summary>
        /// Returns gvec4.bb swizzling (equivalent to gvec4.zz).
        /// </summary>
        public gvec2<T> bb => new gvec2<T>(z, z);
        
        /// <summary>
        /// Returns gvec4.zzx swizzling.
        /// </summary>
        public gvec3<T> zzx => new gvec3<T>(z, z, x);
        
        /// <summary>
        /// Returns gvec4.bbr swizzling (equivalent to gvec4.zzx).
        /// </summary>
        public gvec3<T> bbr => new gvec3<T>(z, z, x);
        
        /// <summary>
        /// Returns gvec4.zzxx swizzling.
        /// </summary>
        public gvec4<T> zzxx => new gvec4<T>(z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.bbrr swizzling (equivalent to gvec4.zzxx).
        /// </summary>
        public gvec4<T> bbrr => new gvec4<T>(z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.zzxxx swizzling.
        /// </summary>
        public gvec5<T> zzxxx => new gvec5<T>(z, z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.bbrrr swizzling (equivalent to gvec4.zzxxx).
        /// </summary>
        public gvec5<T> bbrrr => new gvec5<T>(z, z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.zzxxy swizzling.
        /// </summary>
        public gvec5<T> zzxxy => new gvec5<T>(z, z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.bbrrg swizzling (equivalent to gvec4.zzxxy).
        /// </summary>
        public gvec5<T> bbrrg => new gvec5<T>(z, z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.zzxxz swizzling.
        /// </summary>
        public gvec5<T> zzxxz => new gvec5<T>(z, z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.bbrrb swizzling (equivalent to gvec4.zzxxz).
        /// </summary>
        public gvec5<T> bbrrb => new gvec5<T>(z, z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.zzxxw swizzling.
        /// </summary>
        public gvec5<T> zzxxw => new gvec5<T>(z, z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.bbrra swizzling (equivalent to gvec4.zzxxw).
        /// </summary>
        public gvec5<T> bbrra => new gvec5<T>(z, z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.zzxy swizzling.
        /// </summary>
        public gvec4<T> zzxy => new gvec4<T>(z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.bbrg swizzling (equivalent to gvec4.zzxy).
        /// </summary>
        public gvec4<T> bbrg => new gvec4<T>(z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.zzxyx swizzling.
        /// </summary>
        public gvec5<T> zzxyx => new gvec5<T>(z, z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.bbrgr swizzling (equivalent to gvec4.zzxyx).
        /// </summary>
        public gvec5<T> bbrgr => new gvec5<T>(z, z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.zzxyy swizzling.
        /// </summary>
        public gvec5<T> zzxyy => new gvec5<T>(z, z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.bbrgg swizzling (equivalent to gvec4.zzxyy).
        /// </summary>
        public gvec5<T> bbrgg => new gvec5<T>(z, z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.zzxyz swizzling.
        /// </summary>
        public gvec5<T> zzxyz => new gvec5<T>(z, z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.bbrgb swizzling (equivalent to gvec4.zzxyz).
        /// </summary>
        public gvec5<T> bbrgb => new gvec5<T>(z, z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.zzxyw swizzling.
        /// </summary>
        public gvec5<T> zzxyw => new gvec5<T>(z, z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.bbrga swizzling (equivalent to gvec4.zzxyw).
        /// </summary>
        public gvec5<T> bbrga => new gvec5<T>(z, z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.zzxz swizzling.
        /// </summary>
        public gvec4<T> zzxz => new gvec4<T>(z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.bbrb swizzling (equivalent to gvec4.zzxz).
        /// </summary>
        public gvec4<T> bbrb => new gvec4<T>(z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.zzxzx swizzling.
        /// </summary>
        public gvec5<T> zzxzx => new gvec5<T>(z, z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.bbrbr swizzling (equivalent to gvec4.zzxzx).
        /// </summary>
        public gvec5<T> bbrbr => new gvec5<T>(z, z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.zzxzy swizzling.
        /// </summary>
        public gvec5<T> zzxzy => new gvec5<T>(z, z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.bbrbg swizzling (equivalent to gvec4.zzxzy).
        /// </summary>
        public gvec5<T> bbrbg => new gvec5<T>(z, z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.zzxzz swizzling.
        /// </summary>
        public gvec5<T> zzxzz => new gvec5<T>(z, z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.bbrbb swizzling (equivalent to gvec4.zzxzz).
        /// </summary>
        public gvec5<T> bbrbb => new gvec5<T>(z, z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.zzxzw swizzling.
        /// </summary>
        public gvec5<T> zzxzw => new gvec5<T>(z, z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.bbrba swizzling (equivalent to gvec4.zzxzw).
        /// </summary>
        public gvec5<T> bbrba => new gvec5<T>(z, z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.zzxw swizzling.
        /// </summary>
        public gvec4<T> zzxw => new gvec4<T>(z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.bbra swizzling (equivalent to gvec4.zzxw).
        /// </summary>
        public gvec4<T> bbra => new gvec4<T>(z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.zzxwx swizzling.
        /// </summary>
        public gvec5<T> zzxwx => new gvec5<T>(z, z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.bbrar swizzling (equivalent to gvec4.zzxwx).
        /// </summary>
        public gvec5<T> bbrar => new gvec5<T>(z, z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.zzxwy swizzling.
        /// </summary>
        public gvec5<T> zzxwy => new gvec5<T>(z, z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.bbrag swizzling (equivalent to gvec4.zzxwy).
        /// </summary>
        public gvec5<T> bbrag => new gvec5<T>(z, z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.zzxwz swizzling.
        /// </summary>
        public gvec5<T> zzxwz => new gvec5<T>(z, z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.bbrab swizzling (equivalent to gvec4.zzxwz).
        /// </summary>
        public gvec5<T> bbrab => new gvec5<T>(z, z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.zzxww swizzling.
        /// </summary>
        public gvec5<T> zzxww => new gvec5<T>(z, z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.bbraa swizzling (equivalent to gvec4.zzxww).
        /// </summary>
        public gvec5<T> bbraa => new gvec5<T>(z, z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.zzy swizzling.
        /// </summary>
        public gvec3<T> zzy => new gvec3<T>(z, z, y);
        
        /// <summary>
        /// Returns gvec4.bbg swizzling (equivalent to gvec4.zzy).
        /// </summary>
        public gvec3<T> bbg => new gvec3<T>(z, z, y);
        
        /// <summary>
        /// Returns gvec4.zzyx swizzling.
        /// </summary>
        public gvec4<T> zzyx => new gvec4<T>(z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.bbgr swizzling (equivalent to gvec4.zzyx).
        /// </summary>
        public gvec4<T> bbgr => new gvec4<T>(z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.zzyxx swizzling.
        /// </summary>
        public gvec5<T> zzyxx => new gvec5<T>(z, z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.bbgrr swizzling (equivalent to gvec4.zzyxx).
        /// </summary>
        public gvec5<T> bbgrr => new gvec5<T>(z, z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.zzyxy swizzling.
        /// </summary>
        public gvec5<T> zzyxy => new gvec5<T>(z, z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.bbgrg swizzling (equivalent to gvec4.zzyxy).
        /// </summary>
        public gvec5<T> bbgrg => new gvec5<T>(z, z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.zzyxz swizzling.
        /// </summary>
        public gvec5<T> zzyxz => new gvec5<T>(z, z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.bbgrb swizzling (equivalent to gvec4.zzyxz).
        /// </summary>
        public gvec5<T> bbgrb => new gvec5<T>(z, z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.zzyxw swizzling.
        /// </summary>
        public gvec5<T> zzyxw => new gvec5<T>(z, z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.bbgra swizzling (equivalent to gvec4.zzyxw).
        /// </summary>
        public gvec5<T> bbgra => new gvec5<T>(z, z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.zzyy swizzling.
        /// </summary>
        public gvec4<T> zzyy => new gvec4<T>(z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.bbgg swizzling (equivalent to gvec4.zzyy).
        /// </summary>
        public gvec4<T> bbgg => new gvec4<T>(z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.zzyyx swizzling.
        /// </summary>
        public gvec5<T> zzyyx => new gvec5<T>(z, z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.bbggr swizzling (equivalent to gvec4.zzyyx).
        /// </summary>
        public gvec5<T> bbggr => new gvec5<T>(z, z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.zzyyy swizzling.
        /// </summary>
        public gvec5<T> zzyyy => new gvec5<T>(z, z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.bbggg swizzling (equivalent to gvec4.zzyyy).
        /// </summary>
        public gvec5<T> bbggg => new gvec5<T>(z, z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.zzyyz swizzling.
        /// </summary>
        public gvec5<T> zzyyz => new gvec5<T>(z, z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.bbggb swizzling (equivalent to gvec4.zzyyz).
        /// </summary>
        public gvec5<T> bbggb => new gvec5<T>(z, z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.zzyyw swizzling.
        /// </summary>
        public gvec5<T> zzyyw => new gvec5<T>(z, z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.bbgga swizzling (equivalent to gvec4.zzyyw).
        /// </summary>
        public gvec5<T> bbgga => new gvec5<T>(z, z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.zzyz swizzling.
        /// </summary>
        public gvec4<T> zzyz => new gvec4<T>(z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.bbgb swizzling (equivalent to gvec4.zzyz).
        /// </summary>
        public gvec4<T> bbgb => new gvec4<T>(z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.zzyzx swizzling.
        /// </summary>
        public gvec5<T> zzyzx => new gvec5<T>(z, z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.bbgbr swizzling (equivalent to gvec4.zzyzx).
        /// </summary>
        public gvec5<T> bbgbr => new gvec5<T>(z, z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.zzyzy swizzling.
        /// </summary>
        public gvec5<T> zzyzy => new gvec5<T>(z, z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.bbgbg swizzling (equivalent to gvec4.zzyzy).
        /// </summary>
        public gvec5<T> bbgbg => new gvec5<T>(z, z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.zzyzz swizzling.
        /// </summary>
        public gvec5<T> zzyzz => new gvec5<T>(z, z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.bbgbb swizzling (equivalent to gvec4.zzyzz).
        /// </summary>
        public gvec5<T> bbgbb => new gvec5<T>(z, z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.zzyzw swizzling.
        /// </summary>
        public gvec5<T> zzyzw => new gvec5<T>(z, z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.bbgba swizzling (equivalent to gvec4.zzyzw).
        /// </summary>
        public gvec5<T> bbgba => new gvec5<T>(z, z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.zzyw swizzling.
        /// </summary>
        public gvec4<T> zzyw => new gvec4<T>(z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.bbga swizzling (equivalent to gvec4.zzyw).
        /// </summary>
        public gvec4<T> bbga => new gvec4<T>(z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.zzywx swizzling.
        /// </summary>
        public gvec5<T> zzywx => new gvec5<T>(z, z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.bbgar swizzling (equivalent to gvec4.zzywx).
        /// </summary>
        public gvec5<T> bbgar => new gvec5<T>(z, z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.zzywy swizzling.
        /// </summary>
        public gvec5<T> zzywy => new gvec5<T>(z, z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.bbgag swizzling (equivalent to gvec4.zzywy).
        /// </summary>
        public gvec5<T> bbgag => new gvec5<T>(z, z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.zzywz swizzling.
        /// </summary>
        public gvec5<T> zzywz => new gvec5<T>(z, z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.bbgab swizzling (equivalent to gvec4.zzywz).
        /// </summary>
        public gvec5<T> bbgab => new gvec5<T>(z, z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.zzyww swizzling.
        /// </summary>
        public gvec5<T> zzyww => new gvec5<T>(z, z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.bbgaa swizzling (equivalent to gvec4.zzyww).
        /// </summary>
        public gvec5<T> bbgaa => new gvec5<T>(z, z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.zzz swizzling.
        /// </summary>
        public gvec3<T> zzz => new gvec3<T>(z, z, z);
        
        /// <summary>
        /// Returns gvec4.bbb swizzling (equivalent to gvec4.zzz).
        /// </summary>
        public gvec3<T> bbb => new gvec3<T>(z, z, z);
        
        /// <summary>
        /// Returns gvec4.zzzx swizzling.
        /// </summary>
        public gvec4<T> zzzx => new gvec4<T>(z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.bbbr swizzling (equivalent to gvec4.zzzx).
        /// </summary>
        public gvec4<T> bbbr => new gvec4<T>(z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.zzzxx swizzling.
        /// </summary>
        public gvec5<T> zzzxx => new gvec5<T>(z, z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.bbbrr swizzling (equivalent to gvec4.zzzxx).
        /// </summary>
        public gvec5<T> bbbrr => new gvec5<T>(z, z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.zzzxy swizzling.
        /// </summary>
        public gvec5<T> zzzxy => new gvec5<T>(z, z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.bbbrg swizzling (equivalent to gvec4.zzzxy).
        /// </summary>
        public gvec5<T> bbbrg => new gvec5<T>(z, z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.zzzxz swizzling.
        /// </summary>
        public gvec5<T> zzzxz => new gvec5<T>(z, z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.bbbrb swizzling (equivalent to gvec4.zzzxz).
        /// </summary>
        public gvec5<T> bbbrb => new gvec5<T>(z, z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.zzzxw swizzling.
        /// </summary>
        public gvec5<T> zzzxw => new gvec5<T>(z, z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.bbbra swizzling (equivalent to gvec4.zzzxw).
        /// </summary>
        public gvec5<T> bbbra => new gvec5<T>(z, z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.zzzy swizzling.
        /// </summary>
        public gvec4<T> zzzy => new gvec4<T>(z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.bbbg swizzling (equivalent to gvec4.zzzy).
        /// </summary>
        public gvec4<T> bbbg => new gvec4<T>(z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.zzzyx swizzling.
        /// </summary>
        public gvec5<T> zzzyx => new gvec5<T>(z, z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.bbbgr swizzling (equivalent to gvec4.zzzyx).
        /// </summary>
        public gvec5<T> bbbgr => new gvec5<T>(z, z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.zzzyy swizzling.
        /// </summary>
        public gvec5<T> zzzyy => new gvec5<T>(z, z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.bbbgg swizzling (equivalent to gvec4.zzzyy).
        /// </summary>
        public gvec5<T> bbbgg => new gvec5<T>(z, z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.zzzyz swizzling.
        /// </summary>
        public gvec5<T> zzzyz => new gvec5<T>(z, z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.bbbgb swizzling (equivalent to gvec4.zzzyz).
        /// </summary>
        public gvec5<T> bbbgb => new gvec5<T>(z, z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.zzzyw swizzling.
        /// </summary>
        public gvec5<T> zzzyw => new gvec5<T>(z, z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.bbbga swizzling (equivalent to gvec4.zzzyw).
        /// </summary>
        public gvec5<T> bbbga => new gvec5<T>(z, z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.zzzz swizzling.
        /// </summary>
        public gvec4<T> zzzz => new gvec4<T>(z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.bbbb swizzling (equivalent to gvec4.zzzz).
        /// </summary>
        public gvec4<T> bbbb => new gvec4<T>(z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.zzzzx swizzling.
        /// </summary>
        public gvec5<T> zzzzx => new gvec5<T>(z, z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.bbbbr swizzling (equivalent to gvec4.zzzzx).
        /// </summary>
        public gvec5<T> bbbbr => new gvec5<T>(z, z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.zzzzy swizzling.
        /// </summary>
        public gvec5<T> zzzzy => new gvec5<T>(z, z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.bbbbg swizzling (equivalent to gvec4.zzzzy).
        /// </summary>
        public gvec5<T> bbbbg => new gvec5<T>(z, z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.zzzzz swizzling.
        /// </summary>
        public gvec5<T> zzzzz => new gvec5<T>(z, z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.bbbbb swizzling (equivalent to gvec4.zzzzz).
        /// </summary>
        public gvec5<T> bbbbb => new gvec5<T>(z, z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.zzzzw swizzling.
        /// </summary>
        public gvec5<T> zzzzw => new gvec5<T>(z, z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.bbbba swizzling (equivalent to gvec4.zzzzw).
        /// </summary>
        public gvec5<T> bbbba => new gvec5<T>(z, z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.zzzw swizzling.
        /// </summary>
        public gvec4<T> zzzw => new gvec4<T>(z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.bbba swizzling (equivalent to gvec4.zzzw).
        /// </summary>
        public gvec4<T> bbba => new gvec4<T>(z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.zzzwx swizzling.
        /// </summary>
        public gvec5<T> zzzwx => new gvec5<T>(z, z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.bbbar swizzling (equivalent to gvec4.zzzwx).
        /// </summary>
        public gvec5<T> bbbar => new gvec5<T>(z, z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.zzzwy swizzling.
        /// </summary>
        public gvec5<T> zzzwy => new gvec5<T>(z, z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.bbbag swizzling (equivalent to gvec4.zzzwy).
        /// </summary>
        public gvec5<T> bbbag => new gvec5<T>(z, z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.zzzwz swizzling.
        /// </summary>
        public gvec5<T> zzzwz => new gvec5<T>(z, z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.bbbab swizzling (equivalent to gvec4.zzzwz).
        /// </summary>
        public gvec5<T> bbbab => new gvec5<T>(z, z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.zzzww swizzling.
        /// </summary>
        public gvec5<T> zzzww => new gvec5<T>(z, z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.bbbaa swizzling (equivalent to gvec4.zzzww).
        /// </summary>
        public gvec5<T> bbbaa => new gvec5<T>(z, z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.zzw swizzling.
        /// </summary>
        public gvec3<T> zzw => new gvec3<T>(z, z, w);
        
        /// <summary>
        /// Returns gvec4.bba swizzling (equivalent to gvec4.zzw).
        /// </summary>
        public gvec3<T> bba => new gvec3<T>(z, z, w);
        
        /// <summary>
        /// Returns gvec4.zzwx swizzling.
        /// </summary>
        public gvec4<T> zzwx => new gvec4<T>(z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.bbar swizzling (equivalent to gvec4.zzwx).
        /// </summary>
        public gvec4<T> bbar => new gvec4<T>(z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.zzwxx swizzling.
        /// </summary>
        public gvec5<T> zzwxx => new gvec5<T>(z, z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.bbarr swizzling (equivalent to gvec4.zzwxx).
        /// </summary>
        public gvec5<T> bbarr => new gvec5<T>(z, z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.zzwxy swizzling.
        /// </summary>
        public gvec5<T> zzwxy => new gvec5<T>(z, z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.bbarg swizzling (equivalent to gvec4.zzwxy).
        /// </summary>
        public gvec5<T> bbarg => new gvec5<T>(z, z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.zzwxz swizzling.
        /// </summary>
        public gvec5<T> zzwxz => new gvec5<T>(z, z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.bbarb swizzling (equivalent to gvec4.zzwxz).
        /// </summary>
        public gvec5<T> bbarb => new gvec5<T>(z, z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.zzwxw swizzling.
        /// </summary>
        public gvec5<T> zzwxw => new gvec5<T>(z, z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.bbara swizzling (equivalent to gvec4.zzwxw).
        /// </summary>
        public gvec5<T> bbara => new gvec5<T>(z, z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.zzwy swizzling.
        /// </summary>
        public gvec4<T> zzwy => new gvec4<T>(z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.bbag swizzling (equivalent to gvec4.zzwy).
        /// </summary>
        public gvec4<T> bbag => new gvec4<T>(z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.zzwyx swizzling.
        /// </summary>
        public gvec5<T> zzwyx => new gvec5<T>(z, z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.bbagr swizzling (equivalent to gvec4.zzwyx).
        /// </summary>
        public gvec5<T> bbagr => new gvec5<T>(z, z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.zzwyy swizzling.
        /// </summary>
        public gvec5<T> zzwyy => new gvec5<T>(z, z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.bbagg swizzling (equivalent to gvec4.zzwyy).
        /// </summary>
        public gvec5<T> bbagg => new gvec5<T>(z, z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.zzwyz swizzling.
        /// </summary>
        public gvec5<T> zzwyz => new gvec5<T>(z, z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.bbagb swizzling (equivalent to gvec4.zzwyz).
        /// </summary>
        public gvec5<T> bbagb => new gvec5<T>(z, z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.zzwyw swizzling.
        /// </summary>
        public gvec5<T> zzwyw => new gvec5<T>(z, z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.bbaga swizzling (equivalent to gvec4.zzwyw).
        /// </summary>
        public gvec5<T> bbaga => new gvec5<T>(z, z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.zzwz swizzling.
        /// </summary>
        public gvec4<T> zzwz => new gvec4<T>(z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.bbab swizzling (equivalent to gvec4.zzwz).
        /// </summary>
        public gvec4<T> bbab => new gvec4<T>(z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.zzwzx swizzling.
        /// </summary>
        public gvec5<T> zzwzx => new gvec5<T>(z, z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.bbabr swizzling (equivalent to gvec4.zzwzx).
        /// </summary>
        public gvec5<T> bbabr => new gvec5<T>(z, z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.zzwzy swizzling.
        /// </summary>
        public gvec5<T> zzwzy => new gvec5<T>(z, z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.bbabg swizzling (equivalent to gvec4.zzwzy).
        /// </summary>
        public gvec5<T> bbabg => new gvec5<T>(z, z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.zzwzz swizzling.
        /// </summary>
        public gvec5<T> zzwzz => new gvec5<T>(z, z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.bbabb swizzling (equivalent to gvec4.zzwzz).
        /// </summary>
        public gvec5<T> bbabb => new gvec5<T>(z, z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.zzwzw swizzling.
        /// </summary>
        public gvec5<T> zzwzw => new gvec5<T>(z, z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.bbaba swizzling (equivalent to gvec4.zzwzw).
        /// </summary>
        public gvec5<T> bbaba => new gvec5<T>(z, z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.zzww swizzling.
        /// </summary>
        public gvec4<T> zzww => new gvec4<T>(z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.bbaa swizzling (equivalent to gvec4.zzww).
        /// </summary>
        public gvec4<T> bbaa => new gvec4<T>(z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.zzwwx swizzling.
        /// </summary>
        public gvec5<T> zzwwx => new gvec5<T>(z, z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.bbaar swizzling (equivalent to gvec4.zzwwx).
        /// </summary>
        public gvec5<T> bbaar => new gvec5<T>(z, z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.zzwwy swizzling.
        /// </summary>
        public gvec5<T> zzwwy => new gvec5<T>(z, z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.bbaag swizzling (equivalent to gvec4.zzwwy).
        /// </summary>
        public gvec5<T> bbaag => new gvec5<T>(z, z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.zzwwz swizzling.
        /// </summary>
        public gvec5<T> zzwwz => new gvec5<T>(z, z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.bbaab swizzling (equivalent to gvec4.zzwwz).
        /// </summary>
        public gvec5<T> bbaab => new gvec5<T>(z, z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.zzwww swizzling.
        /// </summary>
        public gvec5<T> zzwww => new gvec5<T>(z, z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.bbaaa swizzling (equivalent to gvec4.zzwww).
        /// </summary>
        public gvec5<T> bbaaa => new gvec5<T>(z, z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.zw swizzling.
        /// </summary>
        public gvec2<T> zw => new gvec2<T>(z, w);
        
        /// <summary>
        /// Returns gvec4.ba swizzling (equivalent to gvec4.zw).
        /// </summary>
        public gvec2<T> ba => new gvec2<T>(z, w);
        
        /// <summary>
        /// Returns gvec4.zwx swizzling.
        /// </summary>
        public gvec3<T> zwx => new gvec3<T>(z, w, x);
        
        /// <summary>
        /// Returns gvec4.bar swizzling (equivalent to gvec4.zwx).
        /// </summary>
        public gvec3<T> bar => new gvec3<T>(z, w, x);
        
        /// <summary>
        /// Returns gvec4.zwxx swizzling.
        /// </summary>
        public gvec4<T> zwxx => new gvec4<T>(z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.barr swizzling (equivalent to gvec4.zwxx).
        /// </summary>
        public gvec4<T> barr => new gvec4<T>(z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.zwxxx swizzling.
        /// </summary>
        public gvec5<T> zwxxx => new gvec5<T>(z, w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.barrr swizzling (equivalent to gvec4.zwxxx).
        /// </summary>
        public gvec5<T> barrr => new gvec5<T>(z, w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.zwxxy swizzling.
        /// </summary>
        public gvec5<T> zwxxy => new gvec5<T>(z, w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.barrg swizzling (equivalent to gvec4.zwxxy).
        /// </summary>
        public gvec5<T> barrg => new gvec5<T>(z, w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.zwxxz swizzling.
        /// </summary>
        public gvec5<T> zwxxz => new gvec5<T>(z, w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.barrb swizzling (equivalent to gvec4.zwxxz).
        /// </summary>
        public gvec5<T> barrb => new gvec5<T>(z, w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.zwxxw swizzling.
        /// </summary>
        public gvec5<T> zwxxw => new gvec5<T>(z, w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.barra swizzling (equivalent to gvec4.zwxxw).
        /// </summary>
        public gvec5<T> barra => new gvec5<T>(z, w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.zwxy swizzling.
        /// </summary>
        public gvec4<T> zwxy => new gvec4<T>(z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.barg swizzling (equivalent to gvec4.zwxy).
        /// </summary>
        public gvec4<T> barg => new gvec4<T>(z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.zwxyx swizzling.
        /// </summary>
        public gvec5<T> zwxyx => new gvec5<T>(z, w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.bargr swizzling (equivalent to gvec4.zwxyx).
        /// </summary>
        public gvec5<T> bargr => new gvec5<T>(z, w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.zwxyy swizzling.
        /// </summary>
        public gvec5<T> zwxyy => new gvec5<T>(z, w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.bargg swizzling (equivalent to gvec4.zwxyy).
        /// </summary>
        public gvec5<T> bargg => new gvec5<T>(z, w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.zwxyz swizzling.
        /// </summary>
        public gvec5<T> zwxyz => new gvec5<T>(z, w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.bargb swizzling (equivalent to gvec4.zwxyz).
        /// </summary>
        public gvec5<T> bargb => new gvec5<T>(z, w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.zwxyw swizzling.
        /// </summary>
        public gvec5<T> zwxyw => new gvec5<T>(z, w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.barga swizzling (equivalent to gvec4.zwxyw).
        /// </summary>
        public gvec5<T> barga => new gvec5<T>(z, w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.zwxz swizzling.
        /// </summary>
        public gvec4<T> zwxz => new gvec4<T>(z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.barb swizzling (equivalent to gvec4.zwxz).
        /// </summary>
        public gvec4<T> barb => new gvec4<T>(z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.zwxzx swizzling.
        /// </summary>
        public gvec5<T> zwxzx => new gvec5<T>(z, w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.barbr swizzling (equivalent to gvec4.zwxzx).
        /// </summary>
        public gvec5<T> barbr => new gvec5<T>(z, w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.zwxzy swizzling.
        /// </summary>
        public gvec5<T> zwxzy => new gvec5<T>(z, w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.barbg swizzling (equivalent to gvec4.zwxzy).
        /// </summary>
        public gvec5<T> barbg => new gvec5<T>(z, w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.zwxzz swizzling.
        /// </summary>
        public gvec5<T> zwxzz => new gvec5<T>(z, w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.barbb swizzling (equivalent to gvec4.zwxzz).
        /// </summary>
        public gvec5<T> barbb => new gvec5<T>(z, w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.zwxzw swizzling.
        /// </summary>
        public gvec5<T> zwxzw => new gvec5<T>(z, w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.barba swizzling (equivalent to gvec4.zwxzw).
        /// </summary>
        public gvec5<T> barba => new gvec5<T>(z, w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.zwxw swizzling.
        /// </summary>
        public gvec4<T> zwxw => new gvec4<T>(z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.bara swizzling (equivalent to gvec4.zwxw).
        /// </summary>
        public gvec4<T> bara => new gvec4<T>(z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.zwxwx swizzling.
        /// </summary>
        public gvec5<T> zwxwx => new gvec5<T>(z, w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.barar swizzling (equivalent to gvec4.zwxwx).
        /// </summary>
        public gvec5<T> barar => new gvec5<T>(z, w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.zwxwy swizzling.
        /// </summary>
        public gvec5<T> zwxwy => new gvec5<T>(z, w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.barag swizzling (equivalent to gvec4.zwxwy).
        /// </summary>
        public gvec5<T> barag => new gvec5<T>(z, w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.zwxwz swizzling.
        /// </summary>
        public gvec5<T> zwxwz => new gvec5<T>(z, w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.barab swizzling (equivalent to gvec4.zwxwz).
        /// </summary>
        public gvec5<T> barab => new gvec5<T>(z, w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.zwxww swizzling.
        /// </summary>
        public gvec5<T> zwxww => new gvec5<T>(z, w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.baraa swizzling (equivalent to gvec4.zwxww).
        /// </summary>
        public gvec5<T> baraa => new gvec5<T>(z, w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.zwy swizzling.
        /// </summary>
        public gvec3<T> zwy => new gvec3<T>(z, w, y);
        
        /// <summary>
        /// Returns gvec4.bag swizzling (equivalent to gvec4.zwy).
        /// </summary>
        public gvec3<T> bag => new gvec3<T>(z, w, y);
        
        /// <summary>
        /// Returns gvec4.zwyx swizzling.
        /// </summary>
        public gvec4<T> zwyx => new gvec4<T>(z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.bagr swizzling (equivalent to gvec4.zwyx).
        /// </summary>
        public gvec4<T> bagr => new gvec4<T>(z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.zwyxx swizzling.
        /// </summary>
        public gvec5<T> zwyxx => new gvec5<T>(z, w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.bagrr swizzling (equivalent to gvec4.zwyxx).
        /// </summary>
        public gvec5<T> bagrr => new gvec5<T>(z, w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.zwyxy swizzling.
        /// </summary>
        public gvec5<T> zwyxy => new gvec5<T>(z, w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.bagrg swizzling (equivalent to gvec4.zwyxy).
        /// </summary>
        public gvec5<T> bagrg => new gvec5<T>(z, w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.zwyxz swizzling.
        /// </summary>
        public gvec5<T> zwyxz => new gvec5<T>(z, w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.bagrb swizzling (equivalent to gvec4.zwyxz).
        /// </summary>
        public gvec5<T> bagrb => new gvec5<T>(z, w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.zwyxw swizzling.
        /// </summary>
        public gvec5<T> zwyxw => new gvec5<T>(z, w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.bagra swizzling (equivalent to gvec4.zwyxw).
        /// </summary>
        public gvec5<T> bagra => new gvec5<T>(z, w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.zwyy swizzling.
        /// </summary>
        public gvec4<T> zwyy => new gvec4<T>(z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.bagg swizzling (equivalent to gvec4.zwyy).
        /// </summary>
        public gvec4<T> bagg => new gvec4<T>(z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.zwyyx swizzling.
        /// </summary>
        public gvec5<T> zwyyx => new gvec5<T>(z, w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.baggr swizzling (equivalent to gvec4.zwyyx).
        /// </summary>
        public gvec5<T> baggr => new gvec5<T>(z, w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.zwyyy swizzling.
        /// </summary>
        public gvec5<T> zwyyy => new gvec5<T>(z, w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.baggg swizzling (equivalent to gvec4.zwyyy).
        /// </summary>
        public gvec5<T> baggg => new gvec5<T>(z, w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.zwyyz swizzling.
        /// </summary>
        public gvec5<T> zwyyz => new gvec5<T>(z, w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.baggb swizzling (equivalent to gvec4.zwyyz).
        /// </summary>
        public gvec5<T> baggb => new gvec5<T>(z, w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.zwyyw swizzling.
        /// </summary>
        public gvec5<T> zwyyw => new gvec5<T>(z, w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.bagga swizzling (equivalent to gvec4.zwyyw).
        /// </summary>
        public gvec5<T> bagga => new gvec5<T>(z, w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.zwyz swizzling.
        /// </summary>
        public gvec4<T> zwyz => new gvec4<T>(z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.bagb swizzling (equivalent to gvec4.zwyz).
        /// </summary>
        public gvec4<T> bagb => new gvec4<T>(z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.zwyzx swizzling.
        /// </summary>
        public gvec5<T> zwyzx => new gvec5<T>(z, w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.bagbr swizzling (equivalent to gvec4.zwyzx).
        /// </summary>
        public gvec5<T> bagbr => new gvec5<T>(z, w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.zwyzy swizzling.
        /// </summary>
        public gvec5<T> zwyzy => new gvec5<T>(z, w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.bagbg swizzling (equivalent to gvec4.zwyzy).
        /// </summary>
        public gvec5<T> bagbg => new gvec5<T>(z, w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.zwyzz swizzling.
        /// </summary>
        public gvec5<T> zwyzz => new gvec5<T>(z, w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.bagbb swizzling (equivalent to gvec4.zwyzz).
        /// </summary>
        public gvec5<T> bagbb => new gvec5<T>(z, w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.zwyzw swizzling.
        /// </summary>
        public gvec5<T> zwyzw => new gvec5<T>(z, w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.bagba swizzling (equivalent to gvec4.zwyzw).
        /// </summary>
        public gvec5<T> bagba => new gvec5<T>(z, w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.zwyw swizzling.
        /// </summary>
        public gvec4<T> zwyw => new gvec4<T>(z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.baga swizzling (equivalent to gvec4.zwyw).
        /// </summary>
        public gvec4<T> baga => new gvec4<T>(z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.zwywx swizzling.
        /// </summary>
        public gvec5<T> zwywx => new gvec5<T>(z, w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.bagar swizzling (equivalent to gvec4.zwywx).
        /// </summary>
        public gvec5<T> bagar => new gvec5<T>(z, w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.zwywy swizzling.
        /// </summary>
        public gvec5<T> zwywy => new gvec5<T>(z, w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.bagag swizzling (equivalent to gvec4.zwywy).
        /// </summary>
        public gvec5<T> bagag => new gvec5<T>(z, w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.zwywz swizzling.
        /// </summary>
        public gvec5<T> zwywz => new gvec5<T>(z, w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.bagab swizzling (equivalent to gvec4.zwywz).
        /// </summary>
        public gvec5<T> bagab => new gvec5<T>(z, w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.zwyww swizzling.
        /// </summary>
        public gvec5<T> zwyww => new gvec5<T>(z, w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.bagaa swizzling (equivalent to gvec4.zwyww).
        /// </summary>
        public gvec5<T> bagaa => new gvec5<T>(z, w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.zwz swizzling.
        /// </summary>
        public gvec3<T> zwz => new gvec3<T>(z, w, z);
        
        /// <summary>
        /// Returns gvec4.bab swizzling (equivalent to gvec4.zwz).
        /// </summary>
        public gvec3<T> bab => new gvec3<T>(z, w, z);
        
        /// <summary>
        /// Returns gvec4.zwzx swizzling.
        /// </summary>
        public gvec4<T> zwzx => new gvec4<T>(z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.babr swizzling (equivalent to gvec4.zwzx).
        /// </summary>
        public gvec4<T> babr => new gvec4<T>(z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.zwzxx swizzling.
        /// </summary>
        public gvec5<T> zwzxx => new gvec5<T>(z, w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.babrr swizzling (equivalent to gvec4.zwzxx).
        /// </summary>
        public gvec5<T> babrr => new gvec5<T>(z, w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.zwzxy swizzling.
        /// </summary>
        public gvec5<T> zwzxy => new gvec5<T>(z, w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.babrg swizzling (equivalent to gvec4.zwzxy).
        /// </summary>
        public gvec5<T> babrg => new gvec5<T>(z, w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.zwzxz swizzling.
        /// </summary>
        public gvec5<T> zwzxz => new gvec5<T>(z, w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.babrb swizzling (equivalent to gvec4.zwzxz).
        /// </summary>
        public gvec5<T> babrb => new gvec5<T>(z, w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.zwzxw swizzling.
        /// </summary>
        public gvec5<T> zwzxw => new gvec5<T>(z, w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.babra swizzling (equivalent to gvec4.zwzxw).
        /// </summary>
        public gvec5<T> babra => new gvec5<T>(z, w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.zwzy swizzling.
        /// </summary>
        public gvec4<T> zwzy => new gvec4<T>(z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.babg swizzling (equivalent to gvec4.zwzy).
        /// </summary>
        public gvec4<T> babg => new gvec4<T>(z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.zwzyx swizzling.
        /// </summary>
        public gvec5<T> zwzyx => new gvec5<T>(z, w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.babgr swizzling (equivalent to gvec4.zwzyx).
        /// </summary>
        public gvec5<T> babgr => new gvec5<T>(z, w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.zwzyy swizzling.
        /// </summary>
        public gvec5<T> zwzyy => new gvec5<T>(z, w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.babgg swizzling (equivalent to gvec4.zwzyy).
        /// </summary>
        public gvec5<T> babgg => new gvec5<T>(z, w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.zwzyz swizzling.
        /// </summary>
        public gvec5<T> zwzyz => new gvec5<T>(z, w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.babgb swizzling (equivalent to gvec4.zwzyz).
        /// </summary>
        public gvec5<T> babgb => new gvec5<T>(z, w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.zwzyw swizzling.
        /// </summary>
        public gvec5<T> zwzyw => new gvec5<T>(z, w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.babga swizzling (equivalent to gvec4.zwzyw).
        /// </summary>
        public gvec5<T> babga => new gvec5<T>(z, w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.zwzz swizzling.
        /// </summary>
        public gvec4<T> zwzz => new gvec4<T>(z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.babb swizzling (equivalent to gvec4.zwzz).
        /// </summary>
        public gvec4<T> babb => new gvec4<T>(z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.zwzzx swizzling.
        /// </summary>
        public gvec5<T> zwzzx => new gvec5<T>(z, w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.babbr swizzling (equivalent to gvec4.zwzzx).
        /// </summary>
        public gvec5<T> babbr => new gvec5<T>(z, w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.zwzzy swizzling.
        /// </summary>
        public gvec5<T> zwzzy => new gvec5<T>(z, w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.babbg swizzling (equivalent to gvec4.zwzzy).
        /// </summary>
        public gvec5<T> babbg => new gvec5<T>(z, w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.zwzzz swizzling.
        /// </summary>
        public gvec5<T> zwzzz => new gvec5<T>(z, w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.babbb swizzling (equivalent to gvec4.zwzzz).
        /// </summary>
        public gvec5<T> babbb => new gvec5<T>(z, w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.zwzzw swizzling.
        /// </summary>
        public gvec5<T> zwzzw => new gvec5<T>(z, w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.babba swizzling (equivalent to gvec4.zwzzw).
        /// </summary>
        public gvec5<T> babba => new gvec5<T>(z, w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.zwzw swizzling.
        /// </summary>
        public gvec4<T> zwzw => new gvec4<T>(z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.baba swizzling (equivalent to gvec4.zwzw).
        /// </summary>
        public gvec4<T> baba => new gvec4<T>(z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.zwzwx swizzling.
        /// </summary>
        public gvec5<T> zwzwx => new gvec5<T>(z, w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.babar swizzling (equivalent to gvec4.zwzwx).
        /// </summary>
        public gvec5<T> babar => new gvec5<T>(z, w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.zwzwy swizzling.
        /// </summary>
        public gvec5<T> zwzwy => new gvec5<T>(z, w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.babag swizzling (equivalent to gvec4.zwzwy).
        /// </summary>
        public gvec5<T> babag => new gvec5<T>(z, w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.zwzwz swizzling.
        /// </summary>
        public gvec5<T> zwzwz => new gvec5<T>(z, w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.babab swizzling (equivalent to gvec4.zwzwz).
        /// </summary>
        public gvec5<T> babab => new gvec5<T>(z, w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.zwzww swizzling.
        /// </summary>
        public gvec5<T> zwzww => new gvec5<T>(z, w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.babaa swizzling (equivalent to gvec4.zwzww).
        /// </summary>
        public gvec5<T> babaa => new gvec5<T>(z, w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.zww swizzling.
        /// </summary>
        public gvec3<T> zww => new gvec3<T>(z, w, w);
        
        /// <summary>
        /// Returns gvec4.baa swizzling (equivalent to gvec4.zww).
        /// </summary>
        public gvec3<T> baa => new gvec3<T>(z, w, w);
        
        /// <summary>
        /// Returns gvec4.zwwx swizzling.
        /// </summary>
        public gvec4<T> zwwx => new gvec4<T>(z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.baar swizzling (equivalent to gvec4.zwwx).
        /// </summary>
        public gvec4<T> baar => new gvec4<T>(z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.zwwxx swizzling.
        /// </summary>
        public gvec5<T> zwwxx => new gvec5<T>(z, w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.baarr swizzling (equivalent to gvec4.zwwxx).
        /// </summary>
        public gvec5<T> baarr => new gvec5<T>(z, w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.zwwxy swizzling.
        /// </summary>
        public gvec5<T> zwwxy => new gvec5<T>(z, w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.baarg swizzling (equivalent to gvec4.zwwxy).
        /// </summary>
        public gvec5<T> baarg => new gvec5<T>(z, w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.zwwxz swizzling.
        /// </summary>
        public gvec5<T> zwwxz => new gvec5<T>(z, w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.baarb swizzling (equivalent to gvec4.zwwxz).
        /// </summary>
        public gvec5<T> baarb => new gvec5<T>(z, w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.zwwxw swizzling.
        /// </summary>
        public gvec5<T> zwwxw => new gvec5<T>(z, w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.baara swizzling (equivalent to gvec4.zwwxw).
        /// </summary>
        public gvec5<T> baara => new gvec5<T>(z, w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.zwwy swizzling.
        /// </summary>
        public gvec4<T> zwwy => new gvec4<T>(z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.baag swizzling (equivalent to gvec4.zwwy).
        /// </summary>
        public gvec4<T> baag => new gvec4<T>(z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.zwwyx swizzling.
        /// </summary>
        public gvec5<T> zwwyx => new gvec5<T>(z, w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.baagr swizzling (equivalent to gvec4.zwwyx).
        /// </summary>
        public gvec5<T> baagr => new gvec5<T>(z, w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.zwwyy swizzling.
        /// </summary>
        public gvec5<T> zwwyy => new gvec5<T>(z, w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.baagg swizzling (equivalent to gvec4.zwwyy).
        /// </summary>
        public gvec5<T> baagg => new gvec5<T>(z, w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.zwwyz swizzling.
        /// </summary>
        public gvec5<T> zwwyz => new gvec5<T>(z, w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.baagb swizzling (equivalent to gvec4.zwwyz).
        /// </summary>
        public gvec5<T> baagb => new gvec5<T>(z, w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.zwwyw swizzling.
        /// </summary>
        public gvec5<T> zwwyw => new gvec5<T>(z, w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.baaga swizzling (equivalent to gvec4.zwwyw).
        /// </summary>
        public gvec5<T> baaga => new gvec5<T>(z, w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.zwwz swizzling.
        /// </summary>
        public gvec4<T> zwwz => new gvec4<T>(z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.baab swizzling (equivalent to gvec4.zwwz).
        /// </summary>
        public gvec4<T> baab => new gvec4<T>(z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.zwwzx swizzling.
        /// </summary>
        public gvec5<T> zwwzx => new gvec5<T>(z, w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.baabr swizzling (equivalent to gvec4.zwwzx).
        /// </summary>
        public gvec5<T> baabr => new gvec5<T>(z, w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.zwwzy swizzling.
        /// </summary>
        public gvec5<T> zwwzy => new gvec5<T>(z, w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.baabg swizzling (equivalent to gvec4.zwwzy).
        /// </summary>
        public gvec5<T> baabg => new gvec5<T>(z, w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.zwwzz swizzling.
        /// </summary>
        public gvec5<T> zwwzz => new gvec5<T>(z, w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.baabb swizzling (equivalent to gvec4.zwwzz).
        /// </summary>
        public gvec5<T> baabb => new gvec5<T>(z, w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.zwwzw swizzling.
        /// </summary>
        public gvec5<T> zwwzw => new gvec5<T>(z, w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.baaba swizzling (equivalent to gvec4.zwwzw).
        /// </summary>
        public gvec5<T> baaba => new gvec5<T>(z, w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.zwww swizzling.
        /// </summary>
        public gvec4<T> zwww => new gvec4<T>(z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.baaa swizzling (equivalent to gvec4.zwww).
        /// </summary>
        public gvec4<T> baaa => new gvec4<T>(z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.zwwwx swizzling.
        /// </summary>
        public gvec5<T> zwwwx => new gvec5<T>(z, w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.baaar swizzling (equivalent to gvec4.zwwwx).
        /// </summary>
        public gvec5<T> baaar => new gvec5<T>(z, w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.zwwwy swizzling.
        /// </summary>
        public gvec5<T> zwwwy => new gvec5<T>(z, w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.baaag swizzling (equivalent to gvec4.zwwwy).
        /// </summary>
        public gvec5<T> baaag => new gvec5<T>(z, w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.zwwwz swizzling.
        /// </summary>
        public gvec5<T> zwwwz => new gvec5<T>(z, w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.baaab swizzling (equivalent to gvec4.zwwwz).
        /// </summary>
        public gvec5<T> baaab => new gvec5<T>(z, w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.zwwww swizzling.
        /// </summary>
        public gvec5<T> zwwww => new gvec5<T>(z, w, w, w, w);
        
        /// <summary>
        /// Returns gvec4.baaaa swizzling (equivalent to gvec4.zwwww).
        /// </summary>
        public gvec5<T> baaaa => new gvec5<T>(z, w, w, w, w);
        
        /// <summary>
        /// Returns gvec4.wx swizzling.
        /// </summary>
        public gvec2<T> wx => new gvec2<T>(w, x);
        
        /// <summary>
        /// Returns gvec4.ar swizzling (equivalent to gvec4.wx).
        /// </summary>
        public gvec2<T> ar => new gvec2<T>(w, x);
        
        /// <summary>
        /// Returns gvec4.wxx swizzling.
        /// </summary>
        public gvec3<T> wxx => new gvec3<T>(w, x, x);
        
        /// <summary>
        /// Returns gvec4.arr swizzling (equivalent to gvec4.wxx).
        /// </summary>
        public gvec3<T> arr => new gvec3<T>(w, x, x);
        
        /// <summary>
        /// Returns gvec4.wxxx swizzling.
        /// </summary>
        public gvec4<T> wxxx => new gvec4<T>(w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.arrr swizzling (equivalent to gvec4.wxxx).
        /// </summary>
        public gvec4<T> arrr => new gvec4<T>(w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.wxxxx swizzling.
        /// </summary>
        public gvec5<T> wxxxx => new gvec5<T>(w, x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.arrrr swizzling (equivalent to gvec4.wxxxx).
        /// </summary>
        public gvec5<T> arrrr => new gvec5<T>(w, x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.wxxxy swizzling.
        /// </summary>
        public gvec5<T> wxxxy => new gvec5<T>(w, x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.arrrg swizzling (equivalent to gvec4.wxxxy).
        /// </summary>
        public gvec5<T> arrrg => new gvec5<T>(w, x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.wxxxz swizzling.
        /// </summary>
        public gvec5<T> wxxxz => new gvec5<T>(w, x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.arrrb swizzling (equivalent to gvec4.wxxxz).
        /// </summary>
        public gvec5<T> arrrb => new gvec5<T>(w, x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.wxxxw swizzling.
        /// </summary>
        public gvec5<T> wxxxw => new gvec5<T>(w, x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.arrra swizzling (equivalent to gvec4.wxxxw).
        /// </summary>
        public gvec5<T> arrra => new gvec5<T>(w, x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.wxxy swizzling.
        /// </summary>
        public gvec4<T> wxxy => new gvec4<T>(w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.arrg swizzling (equivalent to gvec4.wxxy).
        /// </summary>
        public gvec4<T> arrg => new gvec4<T>(w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.wxxyx swizzling.
        /// </summary>
        public gvec5<T> wxxyx => new gvec5<T>(w, x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.arrgr swizzling (equivalent to gvec4.wxxyx).
        /// </summary>
        public gvec5<T> arrgr => new gvec5<T>(w, x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.wxxyy swizzling.
        /// </summary>
        public gvec5<T> wxxyy => new gvec5<T>(w, x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.arrgg swizzling (equivalent to gvec4.wxxyy).
        /// </summary>
        public gvec5<T> arrgg => new gvec5<T>(w, x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.wxxyz swizzling.
        /// </summary>
        public gvec5<T> wxxyz => new gvec5<T>(w, x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.arrgb swizzling (equivalent to gvec4.wxxyz).
        /// </summary>
        public gvec5<T> arrgb => new gvec5<T>(w, x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.wxxyw swizzling.
        /// </summary>
        public gvec5<T> wxxyw => new gvec5<T>(w, x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.arrga swizzling (equivalent to gvec4.wxxyw).
        /// </summary>
        public gvec5<T> arrga => new gvec5<T>(w, x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.wxxz swizzling.
        /// </summary>
        public gvec4<T> wxxz => new gvec4<T>(w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.arrb swizzling (equivalent to gvec4.wxxz).
        /// </summary>
        public gvec4<T> arrb => new gvec4<T>(w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.wxxzx swizzling.
        /// </summary>
        public gvec5<T> wxxzx => new gvec5<T>(w, x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.arrbr swizzling (equivalent to gvec4.wxxzx).
        /// </summary>
        public gvec5<T> arrbr => new gvec5<T>(w, x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.wxxzy swizzling.
        /// </summary>
        public gvec5<T> wxxzy => new gvec5<T>(w, x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.arrbg swizzling (equivalent to gvec4.wxxzy).
        /// </summary>
        public gvec5<T> arrbg => new gvec5<T>(w, x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.wxxzz swizzling.
        /// </summary>
        public gvec5<T> wxxzz => new gvec5<T>(w, x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.arrbb swizzling (equivalent to gvec4.wxxzz).
        /// </summary>
        public gvec5<T> arrbb => new gvec5<T>(w, x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.wxxzw swizzling.
        /// </summary>
        public gvec5<T> wxxzw => new gvec5<T>(w, x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.arrba swizzling (equivalent to gvec4.wxxzw).
        /// </summary>
        public gvec5<T> arrba => new gvec5<T>(w, x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.wxxw swizzling.
        /// </summary>
        public gvec4<T> wxxw => new gvec4<T>(w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.arra swizzling (equivalent to gvec4.wxxw).
        /// </summary>
        public gvec4<T> arra => new gvec4<T>(w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.wxxwx swizzling.
        /// </summary>
        public gvec5<T> wxxwx => new gvec5<T>(w, x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.arrar swizzling (equivalent to gvec4.wxxwx).
        /// </summary>
        public gvec5<T> arrar => new gvec5<T>(w, x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.wxxwy swizzling.
        /// </summary>
        public gvec5<T> wxxwy => new gvec5<T>(w, x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.arrag swizzling (equivalent to gvec4.wxxwy).
        /// </summary>
        public gvec5<T> arrag => new gvec5<T>(w, x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.wxxwz swizzling.
        /// </summary>
        public gvec5<T> wxxwz => new gvec5<T>(w, x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.arrab swizzling (equivalent to gvec4.wxxwz).
        /// </summary>
        public gvec5<T> arrab => new gvec5<T>(w, x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.wxxww swizzling.
        /// </summary>
        public gvec5<T> wxxww => new gvec5<T>(w, x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.arraa swizzling (equivalent to gvec4.wxxww).
        /// </summary>
        public gvec5<T> arraa => new gvec5<T>(w, x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.wxy swizzling.
        /// </summary>
        public gvec3<T> wxy => new gvec3<T>(w, x, y);
        
        /// <summary>
        /// Returns gvec4.arg swizzling (equivalent to gvec4.wxy).
        /// </summary>
        public gvec3<T> arg => new gvec3<T>(w, x, y);
        
        /// <summary>
        /// Returns gvec4.wxyx swizzling.
        /// </summary>
        public gvec4<T> wxyx => new gvec4<T>(w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.argr swizzling (equivalent to gvec4.wxyx).
        /// </summary>
        public gvec4<T> argr => new gvec4<T>(w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.wxyxx swizzling.
        /// </summary>
        public gvec5<T> wxyxx => new gvec5<T>(w, x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.argrr swizzling (equivalent to gvec4.wxyxx).
        /// </summary>
        public gvec5<T> argrr => new gvec5<T>(w, x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.wxyxy swizzling.
        /// </summary>
        public gvec5<T> wxyxy => new gvec5<T>(w, x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.argrg swizzling (equivalent to gvec4.wxyxy).
        /// </summary>
        public gvec5<T> argrg => new gvec5<T>(w, x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.wxyxz swizzling.
        /// </summary>
        public gvec5<T> wxyxz => new gvec5<T>(w, x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.argrb swizzling (equivalent to gvec4.wxyxz).
        /// </summary>
        public gvec5<T> argrb => new gvec5<T>(w, x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.wxyxw swizzling.
        /// </summary>
        public gvec5<T> wxyxw => new gvec5<T>(w, x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.argra swizzling (equivalent to gvec4.wxyxw).
        /// </summary>
        public gvec5<T> argra => new gvec5<T>(w, x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.wxyy swizzling.
        /// </summary>
        public gvec4<T> wxyy => new gvec4<T>(w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.argg swizzling (equivalent to gvec4.wxyy).
        /// </summary>
        public gvec4<T> argg => new gvec4<T>(w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.wxyyx swizzling.
        /// </summary>
        public gvec5<T> wxyyx => new gvec5<T>(w, x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.arggr swizzling (equivalent to gvec4.wxyyx).
        /// </summary>
        public gvec5<T> arggr => new gvec5<T>(w, x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.wxyyy swizzling.
        /// </summary>
        public gvec5<T> wxyyy => new gvec5<T>(w, x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.arggg swizzling (equivalent to gvec4.wxyyy).
        /// </summary>
        public gvec5<T> arggg => new gvec5<T>(w, x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.wxyyz swizzling.
        /// </summary>
        public gvec5<T> wxyyz => new gvec5<T>(w, x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.arggb swizzling (equivalent to gvec4.wxyyz).
        /// </summary>
        public gvec5<T> arggb => new gvec5<T>(w, x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.wxyyw swizzling.
        /// </summary>
        public gvec5<T> wxyyw => new gvec5<T>(w, x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.argga swizzling (equivalent to gvec4.wxyyw).
        /// </summary>
        public gvec5<T> argga => new gvec5<T>(w, x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.wxyz swizzling.
        /// </summary>
        public gvec4<T> wxyz => new gvec4<T>(w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.argb swizzling (equivalent to gvec4.wxyz).
        /// </summary>
        public gvec4<T> argb => new gvec4<T>(w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.wxyzx swizzling.
        /// </summary>
        public gvec5<T> wxyzx => new gvec5<T>(w, x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.argbr swizzling (equivalent to gvec4.wxyzx).
        /// </summary>
        public gvec5<T> argbr => new gvec5<T>(w, x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.wxyzy swizzling.
        /// </summary>
        public gvec5<T> wxyzy => new gvec5<T>(w, x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.argbg swizzling (equivalent to gvec4.wxyzy).
        /// </summary>
        public gvec5<T> argbg => new gvec5<T>(w, x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.wxyzz swizzling.
        /// </summary>
        public gvec5<T> wxyzz => new gvec5<T>(w, x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.argbb swizzling (equivalent to gvec4.wxyzz).
        /// </summary>
        public gvec5<T> argbb => new gvec5<T>(w, x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.wxyzw swizzling.
        /// </summary>
        public gvec5<T> wxyzw => new gvec5<T>(w, x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.argba swizzling (equivalent to gvec4.wxyzw).
        /// </summary>
        public gvec5<T> argba => new gvec5<T>(w, x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.wxyw swizzling.
        /// </summary>
        public gvec4<T> wxyw => new gvec4<T>(w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.arga swizzling (equivalent to gvec4.wxyw).
        /// </summary>
        public gvec4<T> arga => new gvec4<T>(w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.wxywx swizzling.
        /// </summary>
        public gvec5<T> wxywx => new gvec5<T>(w, x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.argar swizzling (equivalent to gvec4.wxywx).
        /// </summary>
        public gvec5<T> argar => new gvec5<T>(w, x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.wxywy swizzling.
        /// </summary>
        public gvec5<T> wxywy => new gvec5<T>(w, x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.argag swizzling (equivalent to gvec4.wxywy).
        /// </summary>
        public gvec5<T> argag => new gvec5<T>(w, x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.wxywz swizzling.
        /// </summary>
        public gvec5<T> wxywz => new gvec5<T>(w, x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.argab swizzling (equivalent to gvec4.wxywz).
        /// </summary>
        public gvec5<T> argab => new gvec5<T>(w, x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.wxyww swizzling.
        /// </summary>
        public gvec5<T> wxyww => new gvec5<T>(w, x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.argaa swizzling (equivalent to gvec4.wxyww).
        /// </summary>
        public gvec5<T> argaa => new gvec5<T>(w, x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.wxz swizzling.
        /// </summary>
        public gvec3<T> wxz => new gvec3<T>(w, x, z);
        
        /// <summary>
        /// Returns gvec4.arb swizzling (equivalent to gvec4.wxz).
        /// </summary>
        public gvec3<T> arb => new gvec3<T>(w, x, z);
        
        /// <summary>
        /// Returns gvec4.wxzx swizzling.
        /// </summary>
        public gvec4<T> wxzx => new gvec4<T>(w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.arbr swizzling (equivalent to gvec4.wxzx).
        /// </summary>
        public gvec4<T> arbr => new gvec4<T>(w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.wxzxx swizzling.
        /// </summary>
        public gvec5<T> wxzxx => new gvec5<T>(w, x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.arbrr swizzling (equivalent to gvec4.wxzxx).
        /// </summary>
        public gvec5<T> arbrr => new gvec5<T>(w, x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.wxzxy swizzling.
        /// </summary>
        public gvec5<T> wxzxy => new gvec5<T>(w, x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.arbrg swizzling (equivalent to gvec4.wxzxy).
        /// </summary>
        public gvec5<T> arbrg => new gvec5<T>(w, x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.wxzxz swizzling.
        /// </summary>
        public gvec5<T> wxzxz => new gvec5<T>(w, x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.arbrb swizzling (equivalent to gvec4.wxzxz).
        /// </summary>
        public gvec5<T> arbrb => new gvec5<T>(w, x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.wxzxw swizzling.
        /// </summary>
        public gvec5<T> wxzxw => new gvec5<T>(w, x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.arbra swizzling (equivalent to gvec4.wxzxw).
        /// </summary>
        public gvec5<T> arbra => new gvec5<T>(w, x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.wxzy swizzling.
        /// </summary>
        public gvec4<T> wxzy => new gvec4<T>(w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.arbg swizzling (equivalent to gvec4.wxzy).
        /// </summary>
        public gvec4<T> arbg => new gvec4<T>(w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.wxzyx swizzling.
        /// </summary>
        public gvec5<T> wxzyx => new gvec5<T>(w, x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.arbgr swizzling (equivalent to gvec4.wxzyx).
        /// </summary>
        public gvec5<T> arbgr => new gvec5<T>(w, x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.wxzyy swizzling.
        /// </summary>
        public gvec5<T> wxzyy => new gvec5<T>(w, x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.arbgg swizzling (equivalent to gvec4.wxzyy).
        /// </summary>
        public gvec5<T> arbgg => new gvec5<T>(w, x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.wxzyz swizzling.
        /// </summary>
        public gvec5<T> wxzyz => new gvec5<T>(w, x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.arbgb swizzling (equivalent to gvec4.wxzyz).
        /// </summary>
        public gvec5<T> arbgb => new gvec5<T>(w, x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.wxzyw swizzling.
        /// </summary>
        public gvec5<T> wxzyw => new gvec5<T>(w, x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.arbga swizzling (equivalent to gvec4.wxzyw).
        /// </summary>
        public gvec5<T> arbga => new gvec5<T>(w, x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.wxzz swizzling.
        /// </summary>
        public gvec4<T> wxzz => new gvec4<T>(w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.arbb swizzling (equivalent to gvec4.wxzz).
        /// </summary>
        public gvec4<T> arbb => new gvec4<T>(w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.wxzzx swizzling.
        /// </summary>
        public gvec5<T> wxzzx => new gvec5<T>(w, x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.arbbr swizzling (equivalent to gvec4.wxzzx).
        /// </summary>
        public gvec5<T> arbbr => new gvec5<T>(w, x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.wxzzy swizzling.
        /// </summary>
        public gvec5<T> wxzzy => new gvec5<T>(w, x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.arbbg swizzling (equivalent to gvec4.wxzzy).
        /// </summary>
        public gvec5<T> arbbg => new gvec5<T>(w, x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.wxzzz swizzling.
        /// </summary>
        public gvec5<T> wxzzz => new gvec5<T>(w, x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.arbbb swizzling (equivalent to gvec4.wxzzz).
        /// </summary>
        public gvec5<T> arbbb => new gvec5<T>(w, x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.wxzzw swizzling.
        /// </summary>
        public gvec5<T> wxzzw => new gvec5<T>(w, x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.arbba swizzling (equivalent to gvec4.wxzzw).
        /// </summary>
        public gvec5<T> arbba => new gvec5<T>(w, x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.wxzw swizzling.
        /// </summary>
        public gvec4<T> wxzw => new gvec4<T>(w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.arba swizzling (equivalent to gvec4.wxzw).
        /// </summary>
        public gvec4<T> arba => new gvec4<T>(w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.wxzwx swizzling.
        /// </summary>
        public gvec5<T> wxzwx => new gvec5<T>(w, x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.arbar swizzling (equivalent to gvec4.wxzwx).
        /// </summary>
        public gvec5<T> arbar => new gvec5<T>(w, x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.wxzwy swizzling.
        /// </summary>
        public gvec5<T> wxzwy => new gvec5<T>(w, x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.arbag swizzling (equivalent to gvec4.wxzwy).
        /// </summary>
        public gvec5<T> arbag => new gvec5<T>(w, x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.wxzwz swizzling.
        /// </summary>
        public gvec5<T> wxzwz => new gvec5<T>(w, x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.arbab swizzling (equivalent to gvec4.wxzwz).
        /// </summary>
        public gvec5<T> arbab => new gvec5<T>(w, x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.wxzww swizzling.
        /// </summary>
        public gvec5<T> wxzww => new gvec5<T>(w, x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.arbaa swizzling (equivalent to gvec4.wxzww).
        /// </summary>
        public gvec5<T> arbaa => new gvec5<T>(w, x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.wxw swizzling.
        /// </summary>
        public gvec3<T> wxw => new gvec3<T>(w, x, w);
        
        /// <summary>
        /// Returns gvec4.ara swizzling (equivalent to gvec4.wxw).
        /// </summary>
        public gvec3<T> ara => new gvec3<T>(w, x, w);
        
        /// <summary>
        /// Returns gvec4.wxwx swizzling.
        /// </summary>
        public gvec4<T> wxwx => new gvec4<T>(w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.arar swizzling (equivalent to gvec4.wxwx).
        /// </summary>
        public gvec4<T> arar => new gvec4<T>(w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.wxwxx swizzling.
        /// </summary>
        public gvec5<T> wxwxx => new gvec5<T>(w, x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.ararr swizzling (equivalent to gvec4.wxwxx).
        /// </summary>
        public gvec5<T> ararr => new gvec5<T>(w, x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.wxwxy swizzling.
        /// </summary>
        public gvec5<T> wxwxy => new gvec5<T>(w, x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.ararg swizzling (equivalent to gvec4.wxwxy).
        /// </summary>
        public gvec5<T> ararg => new gvec5<T>(w, x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.wxwxz swizzling.
        /// </summary>
        public gvec5<T> wxwxz => new gvec5<T>(w, x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.ararb swizzling (equivalent to gvec4.wxwxz).
        /// </summary>
        public gvec5<T> ararb => new gvec5<T>(w, x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.wxwxw swizzling.
        /// </summary>
        public gvec5<T> wxwxw => new gvec5<T>(w, x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.arara swizzling (equivalent to gvec4.wxwxw).
        /// </summary>
        public gvec5<T> arara => new gvec5<T>(w, x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.wxwy swizzling.
        /// </summary>
        public gvec4<T> wxwy => new gvec4<T>(w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.arag swizzling (equivalent to gvec4.wxwy).
        /// </summary>
        public gvec4<T> arag => new gvec4<T>(w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.wxwyx swizzling.
        /// </summary>
        public gvec5<T> wxwyx => new gvec5<T>(w, x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.aragr swizzling (equivalent to gvec4.wxwyx).
        /// </summary>
        public gvec5<T> aragr => new gvec5<T>(w, x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.wxwyy swizzling.
        /// </summary>
        public gvec5<T> wxwyy => new gvec5<T>(w, x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.aragg swizzling (equivalent to gvec4.wxwyy).
        /// </summary>
        public gvec5<T> aragg => new gvec5<T>(w, x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.wxwyz swizzling.
        /// </summary>
        public gvec5<T> wxwyz => new gvec5<T>(w, x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.aragb swizzling (equivalent to gvec4.wxwyz).
        /// </summary>
        public gvec5<T> aragb => new gvec5<T>(w, x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.wxwyw swizzling.
        /// </summary>
        public gvec5<T> wxwyw => new gvec5<T>(w, x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.araga swizzling (equivalent to gvec4.wxwyw).
        /// </summary>
        public gvec5<T> araga => new gvec5<T>(w, x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.wxwz swizzling.
        /// </summary>
        public gvec4<T> wxwz => new gvec4<T>(w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.arab swizzling (equivalent to gvec4.wxwz).
        /// </summary>
        public gvec4<T> arab => new gvec4<T>(w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.wxwzx swizzling.
        /// </summary>
        public gvec5<T> wxwzx => new gvec5<T>(w, x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.arabr swizzling (equivalent to gvec4.wxwzx).
        /// </summary>
        public gvec5<T> arabr => new gvec5<T>(w, x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.wxwzy swizzling.
        /// </summary>
        public gvec5<T> wxwzy => new gvec5<T>(w, x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.arabg swizzling (equivalent to gvec4.wxwzy).
        /// </summary>
        public gvec5<T> arabg => new gvec5<T>(w, x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.wxwzz swizzling.
        /// </summary>
        public gvec5<T> wxwzz => new gvec5<T>(w, x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.arabb swizzling (equivalent to gvec4.wxwzz).
        /// </summary>
        public gvec5<T> arabb => new gvec5<T>(w, x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.wxwzw swizzling.
        /// </summary>
        public gvec5<T> wxwzw => new gvec5<T>(w, x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.araba swizzling (equivalent to gvec4.wxwzw).
        /// </summary>
        public gvec5<T> araba => new gvec5<T>(w, x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.wxww swizzling.
        /// </summary>
        public gvec4<T> wxww => new gvec4<T>(w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.araa swizzling (equivalent to gvec4.wxww).
        /// </summary>
        public gvec4<T> araa => new gvec4<T>(w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.wxwwx swizzling.
        /// </summary>
        public gvec5<T> wxwwx => new gvec5<T>(w, x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.araar swizzling (equivalent to gvec4.wxwwx).
        /// </summary>
        public gvec5<T> araar => new gvec5<T>(w, x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.wxwwy swizzling.
        /// </summary>
        public gvec5<T> wxwwy => new gvec5<T>(w, x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.araag swizzling (equivalent to gvec4.wxwwy).
        /// </summary>
        public gvec5<T> araag => new gvec5<T>(w, x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.wxwwz swizzling.
        /// </summary>
        public gvec5<T> wxwwz => new gvec5<T>(w, x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.araab swizzling (equivalent to gvec4.wxwwz).
        /// </summary>
        public gvec5<T> araab => new gvec5<T>(w, x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.wxwww swizzling.
        /// </summary>
        public gvec5<T> wxwww => new gvec5<T>(w, x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.araaa swizzling (equivalent to gvec4.wxwww).
        /// </summary>
        public gvec5<T> araaa => new gvec5<T>(w, x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.wy swizzling.
        /// </summary>
        public gvec2<T> wy => new gvec2<T>(w, y);
        
        /// <summary>
        /// Returns gvec4.ag swizzling (equivalent to gvec4.wy).
        /// </summary>
        public gvec2<T> ag => new gvec2<T>(w, y);
        
        /// <summary>
        /// Returns gvec4.wyx swizzling.
        /// </summary>
        public gvec3<T> wyx => new gvec3<T>(w, y, x);
        
        /// <summary>
        /// Returns gvec4.agr swizzling (equivalent to gvec4.wyx).
        /// </summary>
        public gvec3<T> agr => new gvec3<T>(w, y, x);
        
        /// <summary>
        /// Returns gvec4.wyxx swizzling.
        /// </summary>
        public gvec4<T> wyxx => new gvec4<T>(w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.agrr swizzling (equivalent to gvec4.wyxx).
        /// </summary>
        public gvec4<T> agrr => new gvec4<T>(w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.wyxxx swizzling.
        /// </summary>
        public gvec5<T> wyxxx => new gvec5<T>(w, y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.agrrr swizzling (equivalent to gvec4.wyxxx).
        /// </summary>
        public gvec5<T> agrrr => new gvec5<T>(w, y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.wyxxy swizzling.
        /// </summary>
        public gvec5<T> wyxxy => new gvec5<T>(w, y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.agrrg swizzling (equivalent to gvec4.wyxxy).
        /// </summary>
        public gvec5<T> agrrg => new gvec5<T>(w, y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.wyxxz swizzling.
        /// </summary>
        public gvec5<T> wyxxz => new gvec5<T>(w, y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.agrrb swizzling (equivalent to gvec4.wyxxz).
        /// </summary>
        public gvec5<T> agrrb => new gvec5<T>(w, y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.wyxxw swizzling.
        /// </summary>
        public gvec5<T> wyxxw => new gvec5<T>(w, y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.agrra swizzling (equivalent to gvec4.wyxxw).
        /// </summary>
        public gvec5<T> agrra => new gvec5<T>(w, y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.wyxy swizzling.
        /// </summary>
        public gvec4<T> wyxy => new gvec4<T>(w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.agrg swizzling (equivalent to gvec4.wyxy).
        /// </summary>
        public gvec4<T> agrg => new gvec4<T>(w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.wyxyx swizzling.
        /// </summary>
        public gvec5<T> wyxyx => new gvec5<T>(w, y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.agrgr swizzling (equivalent to gvec4.wyxyx).
        /// </summary>
        public gvec5<T> agrgr => new gvec5<T>(w, y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.wyxyy swizzling.
        /// </summary>
        public gvec5<T> wyxyy => new gvec5<T>(w, y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.agrgg swizzling (equivalent to gvec4.wyxyy).
        /// </summary>
        public gvec5<T> agrgg => new gvec5<T>(w, y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.wyxyz swizzling.
        /// </summary>
        public gvec5<T> wyxyz => new gvec5<T>(w, y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.agrgb swizzling (equivalent to gvec4.wyxyz).
        /// </summary>
        public gvec5<T> agrgb => new gvec5<T>(w, y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.wyxyw swizzling.
        /// </summary>
        public gvec5<T> wyxyw => new gvec5<T>(w, y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.agrga swizzling (equivalent to gvec4.wyxyw).
        /// </summary>
        public gvec5<T> agrga => new gvec5<T>(w, y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.wyxz swizzling.
        /// </summary>
        public gvec4<T> wyxz => new gvec4<T>(w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.agrb swizzling (equivalent to gvec4.wyxz).
        /// </summary>
        public gvec4<T> agrb => new gvec4<T>(w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.wyxzx swizzling.
        /// </summary>
        public gvec5<T> wyxzx => new gvec5<T>(w, y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.agrbr swizzling (equivalent to gvec4.wyxzx).
        /// </summary>
        public gvec5<T> agrbr => new gvec5<T>(w, y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.wyxzy swizzling.
        /// </summary>
        public gvec5<T> wyxzy => new gvec5<T>(w, y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.agrbg swizzling (equivalent to gvec4.wyxzy).
        /// </summary>
        public gvec5<T> agrbg => new gvec5<T>(w, y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.wyxzz swizzling.
        /// </summary>
        public gvec5<T> wyxzz => new gvec5<T>(w, y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.agrbb swizzling (equivalent to gvec4.wyxzz).
        /// </summary>
        public gvec5<T> agrbb => new gvec5<T>(w, y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.wyxzw swizzling.
        /// </summary>
        public gvec5<T> wyxzw => new gvec5<T>(w, y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.agrba swizzling (equivalent to gvec4.wyxzw).
        /// </summary>
        public gvec5<T> agrba => new gvec5<T>(w, y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.wyxw swizzling.
        /// </summary>
        public gvec4<T> wyxw => new gvec4<T>(w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.agra swizzling (equivalent to gvec4.wyxw).
        /// </summary>
        public gvec4<T> agra => new gvec4<T>(w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.wyxwx swizzling.
        /// </summary>
        public gvec5<T> wyxwx => new gvec5<T>(w, y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.agrar swizzling (equivalent to gvec4.wyxwx).
        /// </summary>
        public gvec5<T> agrar => new gvec5<T>(w, y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.wyxwy swizzling.
        /// </summary>
        public gvec5<T> wyxwy => new gvec5<T>(w, y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.agrag swizzling (equivalent to gvec4.wyxwy).
        /// </summary>
        public gvec5<T> agrag => new gvec5<T>(w, y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.wyxwz swizzling.
        /// </summary>
        public gvec5<T> wyxwz => new gvec5<T>(w, y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.agrab swizzling (equivalent to gvec4.wyxwz).
        /// </summary>
        public gvec5<T> agrab => new gvec5<T>(w, y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.wyxww swizzling.
        /// </summary>
        public gvec5<T> wyxww => new gvec5<T>(w, y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.agraa swizzling (equivalent to gvec4.wyxww).
        /// </summary>
        public gvec5<T> agraa => new gvec5<T>(w, y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.wyy swizzling.
        /// </summary>
        public gvec3<T> wyy => new gvec3<T>(w, y, y);
        
        /// <summary>
        /// Returns gvec4.agg swizzling (equivalent to gvec4.wyy).
        /// </summary>
        public gvec3<T> agg => new gvec3<T>(w, y, y);
        
        /// <summary>
        /// Returns gvec4.wyyx swizzling.
        /// </summary>
        public gvec4<T> wyyx => new gvec4<T>(w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.aggr swizzling (equivalent to gvec4.wyyx).
        /// </summary>
        public gvec4<T> aggr => new gvec4<T>(w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.wyyxx swizzling.
        /// </summary>
        public gvec5<T> wyyxx => new gvec5<T>(w, y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.aggrr swizzling (equivalent to gvec4.wyyxx).
        /// </summary>
        public gvec5<T> aggrr => new gvec5<T>(w, y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.wyyxy swizzling.
        /// </summary>
        public gvec5<T> wyyxy => new gvec5<T>(w, y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.aggrg swizzling (equivalent to gvec4.wyyxy).
        /// </summary>
        public gvec5<T> aggrg => new gvec5<T>(w, y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.wyyxz swizzling.
        /// </summary>
        public gvec5<T> wyyxz => new gvec5<T>(w, y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.aggrb swizzling (equivalent to gvec4.wyyxz).
        /// </summary>
        public gvec5<T> aggrb => new gvec5<T>(w, y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.wyyxw swizzling.
        /// </summary>
        public gvec5<T> wyyxw => new gvec5<T>(w, y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.aggra swizzling (equivalent to gvec4.wyyxw).
        /// </summary>
        public gvec5<T> aggra => new gvec5<T>(w, y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.wyyy swizzling.
        /// </summary>
        public gvec4<T> wyyy => new gvec4<T>(w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.aggg swizzling (equivalent to gvec4.wyyy).
        /// </summary>
        public gvec4<T> aggg => new gvec4<T>(w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.wyyyx swizzling.
        /// </summary>
        public gvec5<T> wyyyx => new gvec5<T>(w, y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.agggr swizzling (equivalent to gvec4.wyyyx).
        /// </summary>
        public gvec5<T> agggr => new gvec5<T>(w, y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.wyyyy swizzling.
        /// </summary>
        public gvec5<T> wyyyy => new gvec5<T>(w, y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.agggg swizzling (equivalent to gvec4.wyyyy).
        /// </summary>
        public gvec5<T> agggg => new gvec5<T>(w, y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.wyyyz swizzling.
        /// </summary>
        public gvec5<T> wyyyz => new gvec5<T>(w, y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.agggb swizzling (equivalent to gvec4.wyyyz).
        /// </summary>
        public gvec5<T> agggb => new gvec5<T>(w, y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.wyyyw swizzling.
        /// </summary>
        public gvec5<T> wyyyw => new gvec5<T>(w, y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.aggga swizzling (equivalent to gvec4.wyyyw).
        /// </summary>
        public gvec5<T> aggga => new gvec5<T>(w, y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.wyyz swizzling.
        /// </summary>
        public gvec4<T> wyyz => new gvec4<T>(w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.aggb swizzling (equivalent to gvec4.wyyz).
        /// </summary>
        public gvec4<T> aggb => new gvec4<T>(w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.wyyzx swizzling.
        /// </summary>
        public gvec5<T> wyyzx => new gvec5<T>(w, y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.aggbr swizzling (equivalent to gvec4.wyyzx).
        /// </summary>
        public gvec5<T> aggbr => new gvec5<T>(w, y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.wyyzy swizzling.
        /// </summary>
        public gvec5<T> wyyzy => new gvec5<T>(w, y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.aggbg swizzling (equivalent to gvec4.wyyzy).
        /// </summary>
        public gvec5<T> aggbg => new gvec5<T>(w, y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.wyyzz swizzling.
        /// </summary>
        public gvec5<T> wyyzz => new gvec5<T>(w, y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.aggbb swizzling (equivalent to gvec4.wyyzz).
        /// </summary>
        public gvec5<T> aggbb => new gvec5<T>(w, y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.wyyzw swizzling.
        /// </summary>
        public gvec5<T> wyyzw => new gvec5<T>(w, y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.aggba swizzling (equivalent to gvec4.wyyzw).
        /// </summary>
        public gvec5<T> aggba => new gvec5<T>(w, y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.wyyw swizzling.
        /// </summary>
        public gvec4<T> wyyw => new gvec4<T>(w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.agga swizzling (equivalent to gvec4.wyyw).
        /// </summary>
        public gvec4<T> agga => new gvec4<T>(w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.wyywx swizzling.
        /// </summary>
        public gvec5<T> wyywx => new gvec5<T>(w, y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.aggar swizzling (equivalent to gvec4.wyywx).
        /// </summary>
        public gvec5<T> aggar => new gvec5<T>(w, y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.wyywy swizzling.
        /// </summary>
        public gvec5<T> wyywy => new gvec5<T>(w, y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.aggag swizzling (equivalent to gvec4.wyywy).
        /// </summary>
        public gvec5<T> aggag => new gvec5<T>(w, y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.wyywz swizzling.
        /// </summary>
        public gvec5<T> wyywz => new gvec5<T>(w, y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.aggab swizzling (equivalent to gvec4.wyywz).
        /// </summary>
        public gvec5<T> aggab => new gvec5<T>(w, y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.wyyww swizzling.
        /// </summary>
        public gvec5<T> wyyww => new gvec5<T>(w, y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.aggaa swizzling (equivalent to gvec4.wyyww).
        /// </summary>
        public gvec5<T> aggaa => new gvec5<T>(w, y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.wyz swizzling.
        /// </summary>
        public gvec3<T> wyz => new gvec3<T>(w, y, z);
        
        /// <summary>
        /// Returns gvec4.agb swizzling (equivalent to gvec4.wyz).
        /// </summary>
        public gvec3<T> agb => new gvec3<T>(w, y, z);
        
        /// <summary>
        /// Returns gvec4.wyzx swizzling.
        /// </summary>
        public gvec4<T> wyzx => new gvec4<T>(w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.agbr swizzling (equivalent to gvec4.wyzx).
        /// </summary>
        public gvec4<T> agbr => new gvec4<T>(w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.wyzxx swizzling.
        /// </summary>
        public gvec5<T> wyzxx => new gvec5<T>(w, y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.agbrr swizzling (equivalent to gvec4.wyzxx).
        /// </summary>
        public gvec5<T> agbrr => new gvec5<T>(w, y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.wyzxy swizzling.
        /// </summary>
        public gvec5<T> wyzxy => new gvec5<T>(w, y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.agbrg swizzling (equivalent to gvec4.wyzxy).
        /// </summary>
        public gvec5<T> agbrg => new gvec5<T>(w, y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.wyzxz swizzling.
        /// </summary>
        public gvec5<T> wyzxz => new gvec5<T>(w, y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.agbrb swizzling (equivalent to gvec4.wyzxz).
        /// </summary>
        public gvec5<T> agbrb => new gvec5<T>(w, y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.wyzxw swizzling.
        /// </summary>
        public gvec5<T> wyzxw => new gvec5<T>(w, y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.agbra swizzling (equivalent to gvec4.wyzxw).
        /// </summary>
        public gvec5<T> agbra => new gvec5<T>(w, y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.wyzy swizzling.
        /// </summary>
        public gvec4<T> wyzy => new gvec4<T>(w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.agbg swizzling (equivalent to gvec4.wyzy).
        /// </summary>
        public gvec4<T> agbg => new gvec4<T>(w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.wyzyx swizzling.
        /// </summary>
        public gvec5<T> wyzyx => new gvec5<T>(w, y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.agbgr swizzling (equivalent to gvec4.wyzyx).
        /// </summary>
        public gvec5<T> agbgr => new gvec5<T>(w, y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.wyzyy swizzling.
        /// </summary>
        public gvec5<T> wyzyy => new gvec5<T>(w, y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.agbgg swizzling (equivalent to gvec4.wyzyy).
        /// </summary>
        public gvec5<T> agbgg => new gvec5<T>(w, y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.wyzyz swizzling.
        /// </summary>
        public gvec5<T> wyzyz => new gvec5<T>(w, y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.agbgb swizzling (equivalent to gvec4.wyzyz).
        /// </summary>
        public gvec5<T> agbgb => new gvec5<T>(w, y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.wyzyw swizzling.
        /// </summary>
        public gvec5<T> wyzyw => new gvec5<T>(w, y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.agbga swizzling (equivalent to gvec4.wyzyw).
        /// </summary>
        public gvec5<T> agbga => new gvec5<T>(w, y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.wyzz swizzling.
        /// </summary>
        public gvec4<T> wyzz => new gvec4<T>(w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.agbb swizzling (equivalent to gvec4.wyzz).
        /// </summary>
        public gvec4<T> agbb => new gvec4<T>(w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.wyzzx swizzling.
        /// </summary>
        public gvec5<T> wyzzx => new gvec5<T>(w, y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.agbbr swizzling (equivalent to gvec4.wyzzx).
        /// </summary>
        public gvec5<T> agbbr => new gvec5<T>(w, y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.wyzzy swizzling.
        /// </summary>
        public gvec5<T> wyzzy => new gvec5<T>(w, y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.agbbg swizzling (equivalent to gvec4.wyzzy).
        /// </summary>
        public gvec5<T> agbbg => new gvec5<T>(w, y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.wyzzz swizzling.
        /// </summary>
        public gvec5<T> wyzzz => new gvec5<T>(w, y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.agbbb swizzling (equivalent to gvec4.wyzzz).
        /// </summary>
        public gvec5<T> agbbb => new gvec5<T>(w, y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.wyzzw swizzling.
        /// </summary>
        public gvec5<T> wyzzw => new gvec5<T>(w, y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.agbba swizzling (equivalent to gvec4.wyzzw).
        /// </summary>
        public gvec5<T> agbba => new gvec5<T>(w, y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.wyzw swizzling.
        /// </summary>
        public gvec4<T> wyzw => new gvec4<T>(w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.agba swizzling (equivalent to gvec4.wyzw).
        /// </summary>
        public gvec4<T> agba => new gvec4<T>(w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.wyzwx swizzling.
        /// </summary>
        public gvec5<T> wyzwx => new gvec5<T>(w, y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.agbar swizzling (equivalent to gvec4.wyzwx).
        /// </summary>
        public gvec5<T> agbar => new gvec5<T>(w, y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.wyzwy swizzling.
        /// </summary>
        public gvec5<T> wyzwy => new gvec5<T>(w, y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.agbag swizzling (equivalent to gvec4.wyzwy).
        /// </summary>
        public gvec5<T> agbag => new gvec5<T>(w, y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.wyzwz swizzling.
        /// </summary>
        public gvec5<T> wyzwz => new gvec5<T>(w, y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.agbab swizzling (equivalent to gvec4.wyzwz).
        /// </summary>
        public gvec5<T> agbab => new gvec5<T>(w, y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.wyzww swizzling.
        /// </summary>
        public gvec5<T> wyzww => new gvec5<T>(w, y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.agbaa swizzling (equivalent to gvec4.wyzww).
        /// </summary>
        public gvec5<T> agbaa => new gvec5<T>(w, y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.wyw swizzling.
        /// </summary>
        public gvec3<T> wyw => new gvec3<T>(w, y, w);
        
        /// <summary>
        /// Returns gvec4.aga swizzling (equivalent to gvec4.wyw).
        /// </summary>
        public gvec3<T> aga => new gvec3<T>(w, y, w);
        
        /// <summary>
        /// Returns gvec4.wywx swizzling.
        /// </summary>
        public gvec4<T> wywx => new gvec4<T>(w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.agar swizzling (equivalent to gvec4.wywx).
        /// </summary>
        public gvec4<T> agar => new gvec4<T>(w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.wywxx swizzling.
        /// </summary>
        public gvec5<T> wywxx => new gvec5<T>(w, y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.agarr swizzling (equivalent to gvec4.wywxx).
        /// </summary>
        public gvec5<T> agarr => new gvec5<T>(w, y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.wywxy swizzling.
        /// </summary>
        public gvec5<T> wywxy => new gvec5<T>(w, y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.agarg swizzling (equivalent to gvec4.wywxy).
        /// </summary>
        public gvec5<T> agarg => new gvec5<T>(w, y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.wywxz swizzling.
        /// </summary>
        public gvec5<T> wywxz => new gvec5<T>(w, y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.agarb swizzling (equivalent to gvec4.wywxz).
        /// </summary>
        public gvec5<T> agarb => new gvec5<T>(w, y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.wywxw swizzling.
        /// </summary>
        public gvec5<T> wywxw => new gvec5<T>(w, y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.agara swizzling (equivalent to gvec4.wywxw).
        /// </summary>
        public gvec5<T> agara => new gvec5<T>(w, y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.wywy swizzling.
        /// </summary>
        public gvec4<T> wywy => new gvec4<T>(w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.agag swizzling (equivalent to gvec4.wywy).
        /// </summary>
        public gvec4<T> agag => new gvec4<T>(w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.wywyx swizzling.
        /// </summary>
        public gvec5<T> wywyx => new gvec5<T>(w, y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.agagr swizzling (equivalent to gvec4.wywyx).
        /// </summary>
        public gvec5<T> agagr => new gvec5<T>(w, y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.wywyy swizzling.
        /// </summary>
        public gvec5<T> wywyy => new gvec5<T>(w, y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.agagg swizzling (equivalent to gvec4.wywyy).
        /// </summary>
        public gvec5<T> agagg => new gvec5<T>(w, y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.wywyz swizzling.
        /// </summary>
        public gvec5<T> wywyz => new gvec5<T>(w, y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.agagb swizzling (equivalent to gvec4.wywyz).
        /// </summary>
        public gvec5<T> agagb => new gvec5<T>(w, y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.wywyw swizzling.
        /// </summary>
        public gvec5<T> wywyw => new gvec5<T>(w, y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.agaga swizzling (equivalent to gvec4.wywyw).
        /// </summary>
        public gvec5<T> agaga => new gvec5<T>(w, y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.wywz swizzling.
        /// </summary>
        public gvec4<T> wywz => new gvec4<T>(w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.agab swizzling (equivalent to gvec4.wywz).
        /// </summary>
        public gvec4<T> agab => new gvec4<T>(w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.wywzx swizzling.
        /// </summary>
        public gvec5<T> wywzx => new gvec5<T>(w, y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.agabr swizzling (equivalent to gvec4.wywzx).
        /// </summary>
        public gvec5<T> agabr => new gvec5<T>(w, y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.wywzy swizzling.
        /// </summary>
        public gvec5<T> wywzy => new gvec5<T>(w, y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.agabg swizzling (equivalent to gvec4.wywzy).
        /// </summary>
        public gvec5<T> agabg => new gvec5<T>(w, y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.wywzz swizzling.
        /// </summary>
        public gvec5<T> wywzz => new gvec5<T>(w, y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.agabb swizzling (equivalent to gvec4.wywzz).
        /// </summary>
        public gvec5<T> agabb => new gvec5<T>(w, y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.wywzw swizzling.
        /// </summary>
        public gvec5<T> wywzw => new gvec5<T>(w, y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.agaba swizzling (equivalent to gvec4.wywzw).
        /// </summary>
        public gvec5<T> agaba => new gvec5<T>(w, y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.wyww swizzling.
        /// </summary>
        public gvec4<T> wyww => new gvec4<T>(w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.agaa swizzling (equivalent to gvec4.wyww).
        /// </summary>
        public gvec4<T> agaa => new gvec4<T>(w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.wywwx swizzling.
        /// </summary>
        public gvec5<T> wywwx => new gvec5<T>(w, y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.agaar swizzling (equivalent to gvec4.wywwx).
        /// </summary>
        public gvec5<T> agaar => new gvec5<T>(w, y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.wywwy swizzling.
        /// </summary>
        public gvec5<T> wywwy => new gvec5<T>(w, y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.agaag swizzling (equivalent to gvec4.wywwy).
        /// </summary>
        public gvec5<T> agaag => new gvec5<T>(w, y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.wywwz swizzling.
        /// </summary>
        public gvec5<T> wywwz => new gvec5<T>(w, y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.agaab swizzling (equivalent to gvec4.wywwz).
        /// </summary>
        public gvec5<T> agaab => new gvec5<T>(w, y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.wywww swizzling.
        /// </summary>
        public gvec5<T> wywww => new gvec5<T>(w, y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.agaaa swizzling (equivalent to gvec4.wywww).
        /// </summary>
        public gvec5<T> agaaa => new gvec5<T>(w, y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.wz swizzling.
        /// </summary>
        public gvec2<T> wz => new gvec2<T>(w, z);
        
        /// <summary>
        /// Returns gvec4.ab swizzling (equivalent to gvec4.wz).
        /// </summary>
        public gvec2<T> ab => new gvec2<T>(w, z);
        
        /// <summary>
        /// Returns gvec4.wzx swizzling.
        /// </summary>
        public gvec3<T> wzx => new gvec3<T>(w, z, x);
        
        /// <summary>
        /// Returns gvec4.abr swizzling (equivalent to gvec4.wzx).
        /// </summary>
        public gvec3<T> abr => new gvec3<T>(w, z, x);
        
        /// <summary>
        /// Returns gvec4.wzxx swizzling.
        /// </summary>
        public gvec4<T> wzxx => new gvec4<T>(w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.abrr swizzling (equivalent to gvec4.wzxx).
        /// </summary>
        public gvec4<T> abrr => new gvec4<T>(w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.wzxxx swizzling.
        /// </summary>
        public gvec5<T> wzxxx => new gvec5<T>(w, z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.abrrr swizzling (equivalent to gvec4.wzxxx).
        /// </summary>
        public gvec5<T> abrrr => new gvec5<T>(w, z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.wzxxy swizzling.
        /// </summary>
        public gvec5<T> wzxxy => new gvec5<T>(w, z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.abrrg swizzling (equivalent to gvec4.wzxxy).
        /// </summary>
        public gvec5<T> abrrg => new gvec5<T>(w, z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.wzxxz swizzling.
        /// </summary>
        public gvec5<T> wzxxz => new gvec5<T>(w, z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.abrrb swizzling (equivalent to gvec4.wzxxz).
        /// </summary>
        public gvec5<T> abrrb => new gvec5<T>(w, z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.wzxxw swizzling.
        /// </summary>
        public gvec5<T> wzxxw => new gvec5<T>(w, z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.abrra swizzling (equivalent to gvec4.wzxxw).
        /// </summary>
        public gvec5<T> abrra => new gvec5<T>(w, z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.wzxy swizzling.
        /// </summary>
        public gvec4<T> wzxy => new gvec4<T>(w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.abrg swizzling (equivalent to gvec4.wzxy).
        /// </summary>
        public gvec4<T> abrg => new gvec4<T>(w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.wzxyx swizzling.
        /// </summary>
        public gvec5<T> wzxyx => new gvec5<T>(w, z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.abrgr swizzling (equivalent to gvec4.wzxyx).
        /// </summary>
        public gvec5<T> abrgr => new gvec5<T>(w, z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.wzxyy swizzling.
        /// </summary>
        public gvec5<T> wzxyy => new gvec5<T>(w, z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.abrgg swizzling (equivalent to gvec4.wzxyy).
        /// </summary>
        public gvec5<T> abrgg => new gvec5<T>(w, z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.wzxyz swizzling.
        /// </summary>
        public gvec5<T> wzxyz => new gvec5<T>(w, z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.abrgb swizzling (equivalent to gvec4.wzxyz).
        /// </summary>
        public gvec5<T> abrgb => new gvec5<T>(w, z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.wzxyw swizzling.
        /// </summary>
        public gvec5<T> wzxyw => new gvec5<T>(w, z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.abrga swizzling (equivalent to gvec4.wzxyw).
        /// </summary>
        public gvec5<T> abrga => new gvec5<T>(w, z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.wzxz swizzling.
        /// </summary>
        public gvec4<T> wzxz => new gvec4<T>(w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.abrb swizzling (equivalent to gvec4.wzxz).
        /// </summary>
        public gvec4<T> abrb => new gvec4<T>(w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.wzxzx swizzling.
        /// </summary>
        public gvec5<T> wzxzx => new gvec5<T>(w, z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.abrbr swizzling (equivalent to gvec4.wzxzx).
        /// </summary>
        public gvec5<T> abrbr => new gvec5<T>(w, z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.wzxzy swizzling.
        /// </summary>
        public gvec5<T> wzxzy => new gvec5<T>(w, z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.abrbg swizzling (equivalent to gvec4.wzxzy).
        /// </summary>
        public gvec5<T> abrbg => new gvec5<T>(w, z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.wzxzz swizzling.
        /// </summary>
        public gvec5<T> wzxzz => new gvec5<T>(w, z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.abrbb swizzling (equivalent to gvec4.wzxzz).
        /// </summary>
        public gvec5<T> abrbb => new gvec5<T>(w, z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.wzxzw swizzling.
        /// </summary>
        public gvec5<T> wzxzw => new gvec5<T>(w, z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.abrba swizzling (equivalent to gvec4.wzxzw).
        /// </summary>
        public gvec5<T> abrba => new gvec5<T>(w, z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.wzxw swizzling.
        /// </summary>
        public gvec4<T> wzxw => new gvec4<T>(w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.abra swizzling (equivalent to gvec4.wzxw).
        /// </summary>
        public gvec4<T> abra => new gvec4<T>(w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.wzxwx swizzling.
        /// </summary>
        public gvec5<T> wzxwx => new gvec5<T>(w, z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.abrar swizzling (equivalent to gvec4.wzxwx).
        /// </summary>
        public gvec5<T> abrar => new gvec5<T>(w, z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.wzxwy swizzling.
        /// </summary>
        public gvec5<T> wzxwy => new gvec5<T>(w, z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.abrag swizzling (equivalent to gvec4.wzxwy).
        /// </summary>
        public gvec5<T> abrag => new gvec5<T>(w, z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.wzxwz swizzling.
        /// </summary>
        public gvec5<T> wzxwz => new gvec5<T>(w, z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.abrab swizzling (equivalent to gvec4.wzxwz).
        /// </summary>
        public gvec5<T> abrab => new gvec5<T>(w, z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.wzxww swizzling.
        /// </summary>
        public gvec5<T> wzxww => new gvec5<T>(w, z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.abraa swizzling (equivalent to gvec4.wzxww).
        /// </summary>
        public gvec5<T> abraa => new gvec5<T>(w, z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.wzy swizzling.
        /// </summary>
        public gvec3<T> wzy => new gvec3<T>(w, z, y);
        
        /// <summary>
        /// Returns gvec4.abg swizzling (equivalent to gvec4.wzy).
        /// </summary>
        public gvec3<T> abg => new gvec3<T>(w, z, y);
        
        /// <summary>
        /// Returns gvec4.wzyx swizzling.
        /// </summary>
        public gvec4<T> wzyx => new gvec4<T>(w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.abgr swizzling (equivalent to gvec4.wzyx).
        /// </summary>
        public gvec4<T> abgr => new gvec4<T>(w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.wzyxx swizzling.
        /// </summary>
        public gvec5<T> wzyxx => new gvec5<T>(w, z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.abgrr swizzling (equivalent to gvec4.wzyxx).
        /// </summary>
        public gvec5<T> abgrr => new gvec5<T>(w, z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.wzyxy swizzling.
        /// </summary>
        public gvec5<T> wzyxy => new gvec5<T>(w, z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.abgrg swizzling (equivalent to gvec4.wzyxy).
        /// </summary>
        public gvec5<T> abgrg => new gvec5<T>(w, z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.wzyxz swizzling.
        /// </summary>
        public gvec5<T> wzyxz => new gvec5<T>(w, z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.abgrb swizzling (equivalent to gvec4.wzyxz).
        /// </summary>
        public gvec5<T> abgrb => new gvec5<T>(w, z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.wzyxw swizzling.
        /// </summary>
        public gvec5<T> wzyxw => new gvec5<T>(w, z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.abgra swizzling (equivalent to gvec4.wzyxw).
        /// </summary>
        public gvec5<T> abgra => new gvec5<T>(w, z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.wzyy swizzling.
        /// </summary>
        public gvec4<T> wzyy => new gvec4<T>(w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.abgg swizzling (equivalent to gvec4.wzyy).
        /// </summary>
        public gvec4<T> abgg => new gvec4<T>(w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.wzyyx swizzling.
        /// </summary>
        public gvec5<T> wzyyx => new gvec5<T>(w, z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.abggr swizzling (equivalent to gvec4.wzyyx).
        /// </summary>
        public gvec5<T> abggr => new gvec5<T>(w, z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.wzyyy swizzling.
        /// </summary>
        public gvec5<T> wzyyy => new gvec5<T>(w, z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.abggg swizzling (equivalent to gvec4.wzyyy).
        /// </summary>
        public gvec5<T> abggg => new gvec5<T>(w, z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.wzyyz swizzling.
        /// </summary>
        public gvec5<T> wzyyz => new gvec5<T>(w, z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.abggb swizzling (equivalent to gvec4.wzyyz).
        /// </summary>
        public gvec5<T> abggb => new gvec5<T>(w, z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.wzyyw swizzling.
        /// </summary>
        public gvec5<T> wzyyw => new gvec5<T>(w, z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.abgga swizzling (equivalent to gvec4.wzyyw).
        /// </summary>
        public gvec5<T> abgga => new gvec5<T>(w, z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.wzyz swizzling.
        /// </summary>
        public gvec4<T> wzyz => new gvec4<T>(w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.abgb swizzling (equivalent to gvec4.wzyz).
        /// </summary>
        public gvec4<T> abgb => new gvec4<T>(w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.wzyzx swizzling.
        /// </summary>
        public gvec5<T> wzyzx => new gvec5<T>(w, z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.abgbr swizzling (equivalent to gvec4.wzyzx).
        /// </summary>
        public gvec5<T> abgbr => new gvec5<T>(w, z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.wzyzy swizzling.
        /// </summary>
        public gvec5<T> wzyzy => new gvec5<T>(w, z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.abgbg swizzling (equivalent to gvec4.wzyzy).
        /// </summary>
        public gvec5<T> abgbg => new gvec5<T>(w, z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.wzyzz swizzling.
        /// </summary>
        public gvec5<T> wzyzz => new gvec5<T>(w, z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.abgbb swizzling (equivalent to gvec4.wzyzz).
        /// </summary>
        public gvec5<T> abgbb => new gvec5<T>(w, z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.wzyzw swizzling.
        /// </summary>
        public gvec5<T> wzyzw => new gvec5<T>(w, z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.abgba swizzling (equivalent to gvec4.wzyzw).
        /// </summary>
        public gvec5<T> abgba => new gvec5<T>(w, z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.wzyw swizzling.
        /// </summary>
        public gvec4<T> wzyw => new gvec4<T>(w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.abga swizzling (equivalent to gvec4.wzyw).
        /// </summary>
        public gvec4<T> abga => new gvec4<T>(w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.wzywx swizzling.
        /// </summary>
        public gvec5<T> wzywx => new gvec5<T>(w, z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.abgar swizzling (equivalent to gvec4.wzywx).
        /// </summary>
        public gvec5<T> abgar => new gvec5<T>(w, z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.wzywy swizzling.
        /// </summary>
        public gvec5<T> wzywy => new gvec5<T>(w, z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.abgag swizzling (equivalent to gvec4.wzywy).
        /// </summary>
        public gvec5<T> abgag => new gvec5<T>(w, z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.wzywz swizzling.
        /// </summary>
        public gvec5<T> wzywz => new gvec5<T>(w, z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.abgab swizzling (equivalent to gvec4.wzywz).
        /// </summary>
        public gvec5<T> abgab => new gvec5<T>(w, z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.wzyww swizzling.
        /// </summary>
        public gvec5<T> wzyww => new gvec5<T>(w, z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.abgaa swizzling (equivalent to gvec4.wzyww).
        /// </summary>
        public gvec5<T> abgaa => new gvec5<T>(w, z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.wzz swizzling.
        /// </summary>
        public gvec3<T> wzz => new gvec3<T>(w, z, z);
        
        /// <summary>
        /// Returns gvec4.abb swizzling (equivalent to gvec4.wzz).
        /// </summary>
        public gvec3<T> abb => new gvec3<T>(w, z, z);
        
        /// <summary>
        /// Returns gvec4.wzzx swizzling.
        /// </summary>
        public gvec4<T> wzzx => new gvec4<T>(w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.abbr swizzling (equivalent to gvec4.wzzx).
        /// </summary>
        public gvec4<T> abbr => new gvec4<T>(w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.wzzxx swizzling.
        /// </summary>
        public gvec5<T> wzzxx => new gvec5<T>(w, z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.abbrr swizzling (equivalent to gvec4.wzzxx).
        /// </summary>
        public gvec5<T> abbrr => new gvec5<T>(w, z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.wzzxy swizzling.
        /// </summary>
        public gvec5<T> wzzxy => new gvec5<T>(w, z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.abbrg swizzling (equivalent to gvec4.wzzxy).
        /// </summary>
        public gvec5<T> abbrg => new gvec5<T>(w, z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.wzzxz swizzling.
        /// </summary>
        public gvec5<T> wzzxz => new gvec5<T>(w, z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.abbrb swizzling (equivalent to gvec4.wzzxz).
        /// </summary>
        public gvec5<T> abbrb => new gvec5<T>(w, z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.wzzxw swizzling.
        /// </summary>
        public gvec5<T> wzzxw => new gvec5<T>(w, z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.abbra swizzling (equivalent to gvec4.wzzxw).
        /// </summary>
        public gvec5<T> abbra => new gvec5<T>(w, z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.wzzy swizzling.
        /// </summary>
        public gvec4<T> wzzy => new gvec4<T>(w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.abbg swizzling (equivalent to gvec4.wzzy).
        /// </summary>
        public gvec4<T> abbg => new gvec4<T>(w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.wzzyx swizzling.
        /// </summary>
        public gvec5<T> wzzyx => new gvec5<T>(w, z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.abbgr swizzling (equivalent to gvec4.wzzyx).
        /// </summary>
        public gvec5<T> abbgr => new gvec5<T>(w, z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.wzzyy swizzling.
        /// </summary>
        public gvec5<T> wzzyy => new gvec5<T>(w, z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.abbgg swizzling (equivalent to gvec4.wzzyy).
        /// </summary>
        public gvec5<T> abbgg => new gvec5<T>(w, z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.wzzyz swizzling.
        /// </summary>
        public gvec5<T> wzzyz => new gvec5<T>(w, z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.abbgb swizzling (equivalent to gvec4.wzzyz).
        /// </summary>
        public gvec5<T> abbgb => new gvec5<T>(w, z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.wzzyw swizzling.
        /// </summary>
        public gvec5<T> wzzyw => new gvec5<T>(w, z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.abbga swizzling (equivalent to gvec4.wzzyw).
        /// </summary>
        public gvec5<T> abbga => new gvec5<T>(w, z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.wzzz swizzling.
        /// </summary>
        public gvec4<T> wzzz => new gvec4<T>(w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.abbb swizzling (equivalent to gvec4.wzzz).
        /// </summary>
        public gvec4<T> abbb => new gvec4<T>(w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.wzzzx swizzling.
        /// </summary>
        public gvec5<T> wzzzx => new gvec5<T>(w, z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.abbbr swizzling (equivalent to gvec4.wzzzx).
        /// </summary>
        public gvec5<T> abbbr => new gvec5<T>(w, z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.wzzzy swizzling.
        /// </summary>
        public gvec5<T> wzzzy => new gvec5<T>(w, z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.abbbg swizzling (equivalent to gvec4.wzzzy).
        /// </summary>
        public gvec5<T> abbbg => new gvec5<T>(w, z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.wzzzz swizzling.
        /// </summary>
        public gvec5<T> wzzzz => new gvec5<T>(w, z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.abbbb swizzling (equivalent to gvec4.wzzzz).
        /// </summary>
        public gvec5<T> abbbb => new gvec5<T>(w, z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.wzzzw swizzling.
        /// </summary>
        public gvec5<T> wzzzw => new gvec5<T>(w, z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.abbba swizzling (equivalent to gvec4.wzzzw).
        /// </summary>
        public gvec5<T> abbba => new gvec5<T>(w, z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.wzzw swizzling.
        /// </summary>
        public gvec4<T> wzzw => new gvec4<T>(w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.abba swizzling (equivalent to gvec4.wzzw).
        /// </summary>
        public gvec4<T> abba => new gvec4<T>(w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.wzzwx swizzling.
        /// </summary>
        public gvec5<T> wzzwx => new gvec5<T>(w, z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.abbar swizzling (equivalent to gvec4.wzzwx).
        /// </summary>
        public gvec5<T> abbar => new gvec5<T>(w, z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.wzzwy swizzling.
        /// </summary>
        public gvec5<T> wzzwy => new gvec5<T>(w, z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.abbag swizzling (equivalent to gvec4.wzzwy).
        /// </summary>
        public gvec5<T> abbag => new gvec5<T>(w, z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.wzzwz swizzling.
        /// </summary>
        public gvec5<T> wzzwz => new gvec5<T>(w, z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.abbab swizzling (equivalent to gvec4.wzzwz).
        /// </summary>
        public gvec5<T> abbab => new gvec5<T>(w, z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.wzzww swizzling.
        /// </summary>
        public gvec5<T> wzzww => new gvec5<T>(w, z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.abbaa swizzling (equivalent to gvec4.wzzww).
        /// </summary>
        public gvec5<T> abbaa => new gvec5<T>(w, z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.wzw swizzling.
        /// </summary>
        public gvec3<T> wzw => new gvec3<T>(w, z, w);
        
        /// <summary>
        /// Returns gvec4.aba swizzling (equivalent to gvec4.wzw).
        /// </summary>
        public gvec3<T> aba => new gvec3<T>(w, z, w);
        
        /// <summary>
        /// Returns gvec4.wzwx swizzling.
        /// </summary>
        public gvec4<T> wzwx => new gvec4<T>(w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.abar swizzling (equivalent to gvec4.wzwx).
        /// </summary>
        public gvec4<T> abar => new gvec4<T>(w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.wzwxx swizzling.
        /// </summary>
        public gvec5<T> wzwxx => new gvec5<T>(w, z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.abarr swizzling (equivalent to gvec4.wzwxx).
        /// </summary>
        public gvec5<T> abarr => new gvec5<T>(w, z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.wzwxy swizzling.
        /// </summary>
        public gvec5<T> wzwxy => new gvec5<T>(w, z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.abarg swizzling (equivalent to gvec4.wzwxy).
        /// </summary>
        public gvec5<T> abarg => new gvec5<T>(w, z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.wzwxz swizzling.
        /// </summary>
        public gvec5<T> wzwxz => new gvec5<T>(w, z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.abarb swizzling (equivalent to gvec4.wzwxz).
        /// </summary>
        public gvec5<T> abarb => new gvec5<T>(w, z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.wzwxw swizzling.
        /// </summary>
        public gvec5<T> wzwxw => new gvec5<T>(w, z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.abara swizzling (equivalent to gvec4.wzwxw).
        /// </summary>
        public gvec5<T> abara => new gvec5<T>(w, z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.wzwy swizzling.
        /// </summary>
        public gvec4<T> wzwy => new gvec4<T>(w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.abag swizzling (equivalent to gvec4.wzwy).
        /// </summary>
        public gvec4<T> abag => new gvec4<T>(w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.wzwyx swizzling.
        /// </summary>
        public gvec5<T> wzwyx => new gvec5<T>(w, z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.abagr swizzling (equivalent to gvec4.wzwyx).
        /// </summary>
        public gvec5<T> abagr => new gvec5<T>(w, z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.wzwyy swizzling.
        /// </summary>
        public gvec5<T> wzwyy => new gvec5<T>(w, z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.abagg swizzling (equivalent to gvec4.wzwyy).
        /// </summary>
        public gvec5<T> abagg => new gvec5<T>(w, z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.wzwyz swizzling.
        /// </summary>
        public gvec5<T> wzwyz => new gvec5<T>(w, z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.abagb swizzling (equivalent to gvec4.wzwyz).
        /// </summary>
        public gvec5<T> abagb => new gvec5<T>(w, z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.wzwyw swizzling.
        /// </summary>
        public gvec5<T> wzwyw => new gvec5<T>(w, z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.abaga swizzling (equivalent to gvec4.wzwyw).
        /// </summary>
        public gvec5<T> abaga => new gvec5<T>(w, z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.wzwz swizzling.
        /// </summary>
        public gvec4<T> wzwz => new gvec4<T>(w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.abab swizzling (equivalent to gvec4.wzwz).
        /// </summary>
        public gvec4<T> abab => new gvec4<T>(w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.wzwzx swizzling.
        /// </summary>
        public gvec5<T> wzwzx => new gvec5<T>(w, z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.ababr swizzling (equivalent to gvec4.wzwzx).
        /// </summary>
        public gvec5<T> ababr => new gvec5<T>(w, z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.wzwzy swizzling.
        /// </summary>
        public gvec5<T> wzwzy => new gvec5<T>(w, z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.ababg swizzling (equivalent to gvec4.wzwzy).
        /// </summary>
        public gvec5<T> ababg => new gvec5<T>(w, z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.wzwzz swizzling.
        /// </summary>
        public gvec5<T> wzwzz => new gvec5<T>(w, z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.ababb swizzling (equivalent to gvec4.wzwzz).
        /// </summary>
        public gvec5<T> ababb => new gvec5<T>(w, z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.wzwzw swizzling.
        /// </summary>
        public gvec5<T> wzwzw => new gvec5<T>(w, z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.ababa swizzling (equivalent to gvec4.wzwzw).
        /// </summary>
        public gvec5<T> ababa => new gvec5<T>(w, z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.wzww swizzling.
        /// </summary>
        public gvec4<T> wzww => new gvec4<T>(w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.abaa swizzling (equivalent to gvec4.wzww).
        /// </summary>
        public gvec4<T> abaa => new gvec4<T>(w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.wzwwx swizzling.
        /// </summary>
        public gvec5<T> wzwwx => new gvec5<T>(w, z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.abaar swizzling (equivalent to gvec4.wzwwx).
        /// </summary>
        public gvec5<T> abaar => new gvec5<T>(w, z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.wzwwy swizzling.
        /// </summary>
        public gvec5<T> wzwwy => new gvec5<T>(w, z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.abaag swizzling (equivalent to gvec4.wzwwy).
        /// </summary>
        public gvec5<T> abaag => new gvec5<T>(w, z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.wzwwz swizzling.
        /// </summary>
        public gvec5<T> wzwwz => new gvec5<T>(w, z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.abaab swizzling (equivalent to gvec4.wzwwz).
        /// </summary>
        public gvec5<T> abaab => new gvec5<T>(w, z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.wzwww swizzling.
        /// </summary>
        public gvec5<T> wzwww => new gvec5<T>(w, z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.abaaa swizzling (equivalent to gvec4.wzwww).
        /// </summary>
        public gvec5<T> abaaa => new gvec5<T>(w, z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.ww swizzling.
        /// </summary>
        public gvec2<T> ww => new gvec2<T>(w, w);
        
        /// <summary>
        /// Returns gvec4.aa swizzling (equivalent to gvec4.ww).
        /// </summary>
        public gvec2<T> aa => new gvec2<T>(w, w);
        
        /// <summary>
        /// Returns gvec4.wwx swizzling.
        /// </summary>
        public gvec3<T> wwx => new gvec3<T>(w, w, x);
        
        /// <summary>
        /// Returns gvec4.aar swizzling (equivalent to gvec4.wwx).
        /// </summary>
        public gvec3<T> aar => new gvec3<T>(w, w, x);
        
        /// <summary>
        /// Returns gvec4.wwxx swizzling.
        /// </summary>
        public gvec4<T> wwxx => new gvec4<T>(w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.aarr swizzling (equivalent to gvec4.wwxx).
        /// </summary>
        public gvec4<T> aarr => new gvec4<T>(w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.wwxxx swizzling.
        /// </summary>
        public gvec5<T> wwxxx => new gvec5<T>(w, w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.aarrr swizzling (equivalent to gvec4.wwxxx).
        /// </summary>
        public gvec5<T> aarrr => new gvec5<T>(w, w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.wwxxy swizzling.
        /// </summary>
        public gvec5<T> wwxxy => new gvec5<T>(w, w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.aarrg swizzling (equivalent to gvec4.wwxxy).
        /// </summary>
        public gvec5<T> aarrg => new gvec5<T>(w, w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.wwxxz swizzling.
        /// </summary>
        public gvec5<T> wwxxz => new gvec5<T>(w, w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.aarrb swizzling (equivalent to gvec4.wwxxz).
        /// </summary>
        public gvec5<T> aarrb => new gvec5<T>(w, w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.wwxxw swizzling.
        /// </summary>
        public gvec5<T> wwxxw => new gvec5<T>(w, w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.aarra swizzling (equivalent to gvec4.wwxxw).
        /// </summary>
        public gvec5<T> aarra => new gvec5<T>(w, w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.wwxy swizzling.
        /// </summary>
        public gvec4<T> wwxy => new gvec4<T>(w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.aarg swizzling (equivalent to gvec4.wwxy).
        /// </summary>
        public gvec4<T> aarg => new gvec4<T>(w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.wwxyx swizzling.
        /// </summary>
        public gvec5<T> wwxyx => new gvec5<T>(w, w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.aargr swizzling (equivalent to gvec4.wwxyx).
        /// </summary>
        public gvec5<T> aargr => new gvec5<T>(w, w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.wwxyy swizzling.
        /// </summary>
        public gvec5<T> wwxyy => new gvec5<T>(w, w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.aargg swizzling (equivalent to gvec4.wwxyy).
        /// </summary>
        public gvec5<T> aargg => new gvec5<T>(w, w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.wwxyz swizzling.
        /// </summary>
        public gvec5<T> wwxyz => new gvec5<T>(w, w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.aargb swizzling (equivalent to gvec4.wwxyz).
        /// </summary>
        public gvec5<T> aargb => new gvec5<T>(w, w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.wwxyw swizzling.
        /// </summary>
        public gvec5<T> wwxyw => new gvec5<T>(w, w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.aarga swizzling (equivalent to gvec4.wwxyw).
        /// </summary>
        public gvec5<T> aarga => new gvec5<T>(w, w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.wwxz swizzling.
        /// </summary>
        public gvec4<T> wwxz => new gvec4<T>(w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.aarb swizzling (equivalent to gvec4.wwxz).
        /// </summary>
        public gvec4<T> aarb => new gvec4<T>(w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.wwxzx swizzling.
        /// </summary>
        public gvec5<T> wwxzx => new gvec5<T>(w, w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.aarbr swizzling (equivalent to gvec4.wwxzx).
        /// </summary>
        public gvec5<T> aarbr => new gvec5<T>(w, w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.wwxzy swizzling.
        /// </summary>
        public gvec5<T> wwxzy => new gvec5<T>(w, w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.aarbg swizzling (equivalent to gvec4.wwxzy).
        /// </summary>
        public gvec5<T> aarbg => new gvec5<T>(w, w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.wwxzz swizzling.
        /// </summary>
        public gvec5<T> wwxzz => new gvec5<T>(w, w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.aarbb swizzling (equivalent to gvec4.wwxzz).
        /// </summary>
        public gvec5<T> aarbb => new gvec5<T>(w, w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.wwxzw swizzling.
        /// </summary>
        public gvec5<T> wwxzw => new gvec5<T>(w, w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.aarba swizzling (equivalent to gvec4.wwxzw).
        /// </summary>
        public gvec5<T> aarba => new gvec5<T>(w, w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.wwxw swizzling.
        /// </summary>
        public gvec4<T> wwxw => new gvec4<T>(w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.aara swizzling (equivalent to gvec4.wwxw).
        /// </summary>
        public gvec4<T> aara => new gvec4<T>(w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.wwxwx swizzling.
        /// </summary>
        public gvec5<T> wwxwx => new gvec5<T>(w, w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.aarar swizzling (equivalent to gvec4.wwxwx).
        /// </summary>
        public gvec5<T> aarar => new gvec5<T>(w, w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.wwxwy swizzling.
        /// </summary>
        public gvec5<T> wwxwy => new gvec5<T>(w, w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.aarag swizzling (equivalent to gvec4.wwxwy).
        /// </summary>
        public gvec5<T> aarag => new gvec5<T>(w, w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.wwxwz swizzling.
        /// </summary>
        public gvec5<T> wwxwz => new gvec5<T>(w, w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.aarab swizzling (equivalent to gvec4.wwxwz).
        /// </summary>
        public gvec5<T> aarab => new gvec5<T>(w, w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.wwxww swizzling.
        /// </summary>
        public gvec5<T> wwxww => new gvec5<T>(w, w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.aaraa swizzling (equivalent to gvec4.wwxww).
        /// </summary>
        public gvec5<T> aaraa => new gvec5<T>(w, w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.wwy swizzling.
        /// </summary>
        public gvec3<T> wwy => new gvec3<T>(w, w, y);
        
        /// <summary>
        /// Returns gvec4.aag swizzling (equivalent to gvec4.wwy).
        /// </summary>
        public gvec3<T> aag => new gvec3<T>(w, w, y);
        
        /// <summary>
        /// Returns gvec4.wwyx swizzling.
        /// </summary>
        public gvec4<T> wwyx => new gvec4<T>(w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.aagr swizzling (equivalent to gvec4.wwyx).
        /// </summary>
        public gvec4<T> aagr => new gvec4<T>(w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.wwyxx swizzling.
        /// </summary>
        public gvec5<T> wwyxx => new gvec5<T>(w, w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.aagrr swizzling (equivalent to gvec4.wwyxx).
        /// </summary>
        public gvec5<T> aagrr => new gvec5<T>(w, w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.wwyxy swizzling.
        /// </summary>
        public gvec5<T> wwyxy => new gvec5<T>(w, w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.aagrg swizzling (equivalent to gvec4.wwyxy).
        /// </summary>
        public gvec5<T> aagrg => new gvec5<T>(w, w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.wwyxz swizzling.
        /// </summary>
        public gvec5<T> wwyxz => new gvec5<T>(w, w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.aagrb swizzling (equivalent to gvec4.wwyxz).
        /// </summary>
        public gvec5<T> aagrb => new gvec5<T>(w, w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.wwyxw swizzling.
        /// </summary>
        public gvec5<T> wwyxw => new gvec5<T>(w, w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.aagra swizzling (equivalent to gvec4.wwyxw).
        /// </summary>
        public gvec5<T> aagra => new gvec5<T>(w, w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.wwyy swizzling.
        /// </summary>
        public gvec4<T> wwyy => new gvec4<T>(w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.aagg swizzling (equivalent to gvec4.wwyy).
        /// </summary>
        public gvec4<T> aagg => new gvec4<T>(w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.wwyyx swizzling.
        /// </summary>
        public gvec5<T> wwyyx => new gvec5<T>(w, w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.aaggr swizzling (equivalent to gvec4.wwyyx).
        /// </summary>
        public gvec5<T> aaggr => new gvec5<T>(w, w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.wwyyy swizzling.
        /// </summary>
        public gvec5<T> wwyyy => new gvec5<T>(w, w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.aaggg swizzling (equivalent to gvec4.wwyyy).
        /// </summary>
        public gvec5<T> aaggg => new gvec5<T>(w, w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.wwyyz swizzling.
        /// </summary>
        public gvec5<T> wwyyz => new gvec5<T>(w, w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.aaggb swizzling (equivalent to gvec4.wwyyz).
        /// </summary>
        public gvec5<T> aaggb => new gvec5<T>(w, w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.wwyyw swizzling.
        /// </summary>
        public gvec5<T> wwyyw => new gvec5<T>(w, w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.aagga swizzling (equivalent to gvec4.wwyyw).
        /// </summary>
        public gvec5<T> aagga => new gvec5<T>(w, w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.wwyz swizzling.
        /// </summary>
        public gvec4<T> wwyz => new gvec4<T>(w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.aagb swizzling (equivalent to gvec4.wwyz).
        /// </summary>
        public gvec4<T> aagb => new gvec4<T>(w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.wwyzx swizzling.
        /// </summary>
        public gvec5<T> wwyzx => new gvec5<T>(w, w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.aagbr swizzling (equivalent to gvec4.wwyzx).
        /// </summary>
        public gvec5<T> aagbr => new gvec5<T>(w, w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.wwyzy swizzling.
        /// </summary>
        public gvec5<T> wwyzy => new gvec5<T>(w, w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.aagbg swizzling (equivalent to gvec4.wwyzy).
        /// </summary>
        public gvec5<T> aagbg => new gvec5<T>(w, w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.wwyzz swizzling.
        /// </summary>
        public gvec5<T> wwyzz => new gvec5<T>(w, w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.aagbb swizzling (equivalent to gvec4.wwyzz).
        /// </summary>
        public gvec5<T> aagbb => new gvec5<T>(w, w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.wwyzw swizzling.
        /// </summary>
        public gvec5<T> wwyzw => new gvec5<T>(w, w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.aagba swizzling (equivalent to gvec4.wwyzw).
        /// </summary>
        public gvec5<T> aagba => new gvec5<T>(w, w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.wwyw swizzling.
        /// </summary>
        public gvec4<T> wwyw => new gvec4<T>(w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.aaga swizzling (equivalent to gvec4.wwyw).
        /// </summary>
        public gvec4<T> aaga => new gvec4<T>(w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.wwywx swizzling.
        /// </summary>
        public gvec5<T> wwywx => new gvec5<T>(w, w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.aagar swizzling (equivalent to gvec4.wwywx).
        /// </summary>
        public gvec5<T> aagar => new gvec5<T>(w, w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.wwywy swizzling.
        /// </summary>
        public gvec5<T> wwywy => new gvec5<T>(w, w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.aagag swizzling (equivalent to gvec4.wwywy).
        /// </summary>
        public gvec5<T> aagag => new gvec5<T>(w, w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.wwywz swizzling.
        /// </summary>
        public gvec5<T> wwywz => new gvec5<T>(w, w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.aagab swizzling (equivalent to gvec4.wwywz).
        /// </summary>
        public gvec5<T> aagab => new gvec5<T>(w, w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.wwyww swizzling.
        /// </summary>
        public gvec5<T> wwyww => new gvec5<T>(w, w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.aagaa swizzling (equivalent to gvec4.wwyww).
        /// </summary>
        public gvec5<T> aagaa => new gvec5<T>(w, w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.wwz swizzling.
        /// </summary>
        public gvec3<T> wwz => new gvec3<T>(w, w, z);
        
        /// <summary>
        /// Returns gvec4.aab swizzling (equivalent to gvec4.wwz).
        /// </summary>
        public gvec3<T> aab => new gvec3<T>(w, w, z);
        
        /// <summary>
        /// Returns gvec4.wwzx swizzling.
        /// </summary>
        public gvec4<T> wwzx => new gvec4<T>(w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.aabr swizzling (equivalent to gvec4.wwzx).
        /// </summary>
        public gvec4<T> aabr => new gvec4<T>(w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.wwzxx swizzling.
        /// </summary>
        public gvec5<T> wwzxx => new gvec5<T>(w, w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.aabrr swizzling (equivalent to gvec4.wwzxx).
        /// </summary>
        public gvec5<T> aabrr => new gvec5<T>(w, w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.wwzxy swizzling.
        /// </summary>
        public gvec5<T> wwzxy => new gvec5<T>(w, w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.aabrg swizzling (equivalent to gvec4.wwzxy).
        /// </summary>
        public gvec5<T> aabrg => new gvec5<T>(w, w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.wwzxz swizzling.
        /// </summary>
        public gvec5<T> wwzxz => new gvec5<T>(w, w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.aabrb swizzling (equivalent to gvec4.wwzxz).
        /// </summary>
        public gvec5<T> aabrb => new gvec5<T>(w, w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.wwzxw swizzling.
        /// </summary>
        public gvec5<T> wwzxw => new gvec5<T>(w, w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.aabra swizzling (equivalent to gvec4.wwzxw).
        /// </summary>
        public gvec5<T> aabra => new gvec5<T>(w, w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.wwzy swizzling.
        /// </summary>
        public gvec4<T> wwzy => new gvec4<T>(w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.aabg swizzling (equivalent to gvec4.wwzy).
        /// </summary>
        public gvec4<T> aabg => new gvec4<T>(w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.wwzyx swizzling.
        /// </summary>
        public gvec5<T> wwzyx => new gvec5<T>(w, w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.aabgr swizzling (equivalent to gvec4.wwzyx).
        /// </summary>
        public gvec5<T> aabgr => new gvec5<T>(w, w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.wwzyy swizzling.
        /// </summary>
        public gvec5<T> wwzyy => new gvec5<T>(w, w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.aabgg swizzling (equivalent to gvec4.wwzyy).
        /// </summary>
        public gvec5<T> aabgg => new gvec5<T>(w, w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.wwzyz swizzling.
        /// </summary>
        public gvec5<T> wwzyz => new gvec5<T>(w, w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.aabgb swizzling (equivalent to gvec4.wwzyz).
        /// </summary>
        public gvec5<T> aabgb => new gvec5<T>(w, w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.wwzyw swizzling.
        /// </summary>
        public gvec5<T> wwzyw => new gvec5<T>(w, w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.aabga swizzling (equivalent to gvec4.wwzyw).
        /// </summary>
        public gvec5<T> aabga => new gvec5<T>(w, w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.wwzz swizzling.
        /// </summary>
        public gvec4<T> wwzz => new gvec4<T>(w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.aabb swizzling (equivalent to gvec4.wwzz).
        /// </summary>
        public gvec4<T> aabb => new gvec4<T>(w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.wwzzx swizzling.
        /// </summary>
        public gvec5<T> wwzzx => new gvec5<T>(w, w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.aabbr swizzling (equivalent to gvec4.wwzzx).
        /// </summary>
        public gvec5<T> aabbr => new gvec5<T>(w, w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.wwzzy swizzling.
        /// </summary>
        public gvec5<T> wwzzy => new gvec5<T>(w, w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.aabbg swizzling (equivalent to gvec4.wwzzy).
        /// </summary>
        public gvec5<T> aabbg => new gvec5<T>(w, w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.wwzzz swizzling.
        /// </summary>
        public gvec5<T> wwzzz => new gvec5<T>(w, w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.aabbb swizzling (equivalent to gvec4.wwzzz).
        /// </summary>
        public gvec5<T> aabbb => new gvec5<T>(w, w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.wwzzw swizzling.
        /// </summary>
        public gvec5<T> wwzzw => new gvec5<T>(w, w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.aabba swizzling (equivalent to gvec4.wwzzw).
        /// </summary>
        public gvec5<T> aabba => new gvec5<T>(w, w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.wwzw swizzling.
        /// </summary>
        public gvec4<T> wwzw => new gvec4<T>(w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.aaba swizzling (equivalent to gvec4.wwzw).
        /// </summary>
        public gvec4<T> aaba => new gvec4<T>(w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.wwzwx swizzling.
        /// </summary>
        public gvec5<T> wwzwx => new gvec5<T>(w, w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.aabar swizzling (equivalent to gvec4.wwzwx).
        /// </summary>
        public gvec5<T> aabar => new gvec5<T>(w, w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.wwzwy swizzling.
        /// </summary>
        public gvec5<T> wwzwy => new gvec5<T>(w, w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.aabag swizzling (equivalent to gvec4.wwzwy).
        /// </summary>
        public gvec5<T> aabag => new gvec5<T>(w, w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.wwzwz swizzling.
        /// </summary>
        public gvec5<T> wwzwz => new gvec5<T>(w, w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.aabab swizzling (equivalent to gvec4.wwzwz).
        /// </summary>
        public gvec5<T> aabab => new gvec5<T>(w, w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.wwzww swizzling.
        /// </summary>
        public gvec5<T> wwzww => new gvec5<T>(w, w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.aabaa swizzling (equivalent to gvec4.wwzww).
        /// </summary>
        public gvec5<T> aabaa => new gvec5<T>(w, w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.www swizzling.
        /// </summary>
        public gvec3<T> www => new gvec3<T>(w, w, w);
        
        /// <summary>
        /// Returns gvec4.aaa swizzling (equivalent to gvec4.www).
        /// </summary>
        public gvec3<T> aaa => new gvec3<T>(w, w, w);
        
        /// <summary>
        /// Returns gvec4.wwwx swizzling.
        /// </summary>
        public gvec4<T> wwwx => new gvec4<T>(w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.aaar swizzling (equivalent to gvec4.wwwx).
        /// </summary>
        public gvec4<T> aaar => new gvec4<T>(w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.wwwxx swizzling.
        /// </summary>
        public gvec5<T> wwwxx => new gvec5<T>(w, w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.aaarr swizzling (equivalent to gvec4.wwwxx).
        /// </summary>
        public gvec5<T> aaarr => new gvec5<T>(w, w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.wwwxy swizzling.
        /// </summary>
        public gvec5<T> wwwxy => new gvec5<T>(w, w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.aaarg swizzling (equivalent to gvec4.wwwxy).
        /// </summary>
        public gvec5<T> aaarg => new gvec5<T>(w, w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.wwwxz swizzling.
        /// </summary>
        public gvec5<T> wwwxz => new gvec5<T>(w, w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.aaarb swizzling (equivalent to gvec4.wwwxz).
        /// </summary>
        public gvec5<T> aaarb => new gvec5<T>(w, w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.wwwxw swizzling.
        /// </summary>
        public gvec5<T> wwwxw => new gvec5<T>(w, w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.aaara swizzling (equivalent to gvec4.wwwxw).
        /// </summary>
        public gvec5<T> aaara => new gvec5<T>(w, w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.wwwy swizzling.
        /// </summary>
        public gvec4<T> wwwy => new gvec4<T>(w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.aaag swizzling (equivalent to gvec4.wwwy).
        /// </summary>
        public gvec4<T> aaag => new gvec4<T>(w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.wwwyx swizzling.
        /// </summary>
        public gvec5<T> wwwyx => new gvec5<T>(w, w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.aaagr swizzling (equivalent to gvec4.wwwyx).
        /// </summary>
        public gvec5<T> aaagr => new gvec5<T>(w, w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.wwwyy swizzling.
        /// </summary>
        public gvec5<T> wwwyy => new gvec5<T>(w, w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.aaagg swizzling (equivalent to gvec4.wwwyy).
        /// </summary>
        public gvec5<T> aaagg => new gvec5<T>(w, w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.wwwyz swizzling.
        /// </summary>
        public gvec5<T> wwwyz => new gvec5<T>(w, w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.aaagb swizzling (equivalent to gvec4.wwwyz).
        /// </summary>
        public gvec5<T> aaagb => new gvec5<T>(w, w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.wwwyw swizzling.
        /// </summary>
        public gvec5<T> wwwyw => new gvec5<T>(w, w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.aaaga swizzling (equivalent to gvec4.wwwyw).
        /// </summary>
        public gvec5<T> aaaga => new gvec5<T>(w, w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.wwwz swizzling.
        /// </summary>
        public gvec4<T> wwwz => new gvec4<T>(w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.aaab swizzling (equivalent to gvec4.wwwz).
        /// </summary>
        public gvec4<T> aaab => new gvec4<T>(w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.wwwzx swizzling.
        /// </summary>
        public gvec5<T> wwwzx => new gvec5<T>(w, w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.aaabr swizzling (equivalent to gvec4.wwwzx).
        /// </summary>
        public gvec5<T> aaabr => new gvec5<T>(w, w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.wwwzy swizzling.
        /// </summary>
        public gvec5<T> wwwzy => new gvec5<T>(w, w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.aaabg swizzling (equivalent to gvec4.wwwzy).
        /// </summary>
        public gvec5<T> aaabg => new gvec5<T>(w, w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.wwwzz swizzling.
        /// </summary>
        public gvec5<T> wwwzz => new gvec5<T>(w, w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.aaabb swizzling (equivalent to gvec4.wwwzz).
        /// </summary>
        public gvec5<T> aaabb => new gvec5<T>(w, w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.wwwzw swizzling.
        /// </summary>
        public gvec5<T> wwwzw => new gvec5<T>(w, w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.aaaba swizzling (equivalent to gvec4.wwwzw).
        /// </summary>
        public gvec5<T> aaaba => new gvec5<T>(w, w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.wwww swizzling.
        /// </summary>
        public gvec4<T> wwww => new gvec4<T>(w, w, w, w);
        
        /// <summary>
        /// Returns gvec4.aaaa swizzling (equivalent to gvec4.wwww).
        /// </summary>
        public gvec4<T> aaaa => new gvec4<T>(w, w, w, w);
        
        /// <summary>
        /// Returns gvec4.wwwwx swizzling.
        /// </summary>
        public gvec5<T> wwwwx => new gvec5<T>(w, w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.aaaar swizzling (equivalent to gvec4.wwwwx).
        /// </summary>
        public gvec5<T> aaaar => new gvec5<T>(w, w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.wwwwy swizzling.
        /// </summary>
        public gvec5<T> wwwwy => new gvec5<T>(w, w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.aaaag swizzling (equivalent to gvec4.wwwwy).
        /// </summary>
        public gvec5<T> aaaag => new gvec5<T>(w, w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.wwwwz swizzling.
        /// </summary>
        public gvec5<T> wwwwz => new gvec5<T>(w, w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.aaaab swizzling (equivalent to gvec4.wwwwz).
        /// </summary>
        public gvec5<T> aaaab => new gvec5<T>(w, w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.wwwww swizzling.
        /// </summary>
        public gvec5<T> wwwww => new gvec5<T>(w, w, w, w, w);
        
        /// <summary>
        /// Returns gvec4.aaaaa swizzling (equivalent to gvec4.wwwww).
        /// </summary>
        public gvec5<T> aaaaa => new gvec5<T>(w, w, w, w, w);

        #endregion

    }
}
