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
    /// Temporary vector of type Half with 4 components, used for implementing swizzling for hvec4.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_hvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly Half x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly Half y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly Half z;
        
        /// <summary>
        /// w-component
        /// </summary>
        internal readonly Half w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_hvec4.
        /// </summary>
        internal swizzle_hvec4(Half x, Half y, Half z, Half w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns hvec4.xx swizzling.
        /// </summary>
        public hvec2 xx => new hvec2(x, x);
        
        /// <summary>
        /// Returns hvec4.rr swizzling (equivalent to hvec4.xx).
        /// </summary>
        public hvec2 rr => new hvec2(x, x);
        
        /// <summary>
        /// Returns hvec4.xxx swizzling.
        /// </summary>
        public hvec3 xxx => new hvec3(x, x, x);
        
        /// <summary>
        /// Returns hvec4.rrr swizzling (equivalent to hvec4.xxx).
        /// </summary>
        public hvec3 rrr => new hvec3(x, x, x);
        
        /// <summary>
        /// Returns hvec4.xxxx swizzling.
        /// </summary>
        public hvec4 xxxx => new hvec4(x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.rrrr swizzling (equivalent to hvec4.xxxx).
        /// </summary>
        public hvec4 rrrr => new hvec4(x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.xxxxx swizzling.
        /// </summary>
        public hvec5 xxxxx => new hvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.rrrrr swizzling (equivalent to hvec4.xxxxx).
        /// </summary>
        public hvec5 rrrrr => new hvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.xxxxy swizzling.
        /// </summary>
        public hvec5 xxxxy => new hvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.rrrrg swizzling (equivalent to hvec4.xxxxy).
        /// </summary>
        public hvec5 rrrrg => new hvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.xxxxz swizzling.
        /// </summary>
        public hvec5 xxxxz => new hvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.rrrrb swizzling (equivalent to hvec4.xxxxz).
        /// </summary>
        public hvec5 rrrrb => new hvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.xxxxw swizzling.
        /// </summary>
        public hvec5 xxxxw => new hvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.rrrra swizzling (equivalent to hvec4.xxxxw).
        /// </summary>
        public hvec5 rrrra => new hvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.xxxy swizzling.
        /// </summary>
        public hvec4 xxxy => new hvec4(x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.rrrg swizzling (equivalent to hvec4.xxxy).
        /// </summary>
        public hvec4 rrrg => new hvec4(x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.xxxyx swizzling.
        /// </summary>
        public hvec5 xxxyx => new hvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.rrrgr swizzling (equivalent to hvec4.xxxyx).
        /// </summary>
        public hvec5 rrrgr => new hvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.xxxyy swizzling.
        /// </summary>
        public hvec5 xxxyy => new hvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.rrrgg swizzling (equivalent to hvec4.xxxyy).
        /// </summary>
        public hvec5 rrrgg => new hvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.xxxyz swizzling.
        /// </summary>
        public hvec5 xxxyz => new hvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.rrrgb swizzling (equivalent to hvec4.xxxyz).
        /// </summary>
        public hvec5 rrrgb => new hvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.xxxyw swizzling.
        /// </summary>
        public hvec5 xxxyw => new hvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.rrrga swizzling (equivalent to hvec4.xxxyw).
        /// </summary>
        public hvec5 rrrga => new hvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.xxxz swizzling.
        /// </summary>
        public hvec4 xxxz => new hvec4(x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.rrrb swizzling (equivalent to hvec4.xxxz).
        /// </summary>
        public hvec4 rrrb => new hvec4(x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.xxxzx swizzling.
        /// </summary>
        public hvec5 xxxzx => new hvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.rrrbr swizzling (equivalent to hvec4.xxxzx).
        /// </summary>
        public hvec5 rrrbr => new hvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.xxxzy swizzling.
        /// </summary>
        public hvec5 xxxzy => new hvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.rrrbg swizzling (equivalent to hvec4.xxxzy).
        /// </summary>
        public hvec5 rrrbg => new hvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.xxxzz swizzling.
        /// </summary>
        public hvec5 xxxzz => new hvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.rrrbb swizzling (equivalent to hvec4.xxxzz).
        /// </summary>
        public hvec5 rrrbb => new hvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.xxxzw swizzling.
        /// </summary>
        public hvec5 xxxzw => new hvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.rrrba swizzling (equivalent to hvec4.xxxzw).
        /// </summary>
        public hvec5 rrrba => new hvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.xxxw swizzling.
        /// </summary>
        public hvec4 xxxw => new hvec4(x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.rrra swizzling (equivalent to hvec4.xxxw).
        /// </summary>
        public hvec4 rrra => new hvec4(x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.xxxwx swizzling.
        /// </summary>
        public hvec5 xxxwx => new hvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.rrrar swizzling (equivalent to hvec4.xxxwx).
        /// </summary>
        public hvec5 rrrar => new hvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.xxxwy swizzling.
        /// </summary>
        public hvec5 xxxwy => new hvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.rrrag swizzling (equivalent to hvec4.xxxwy).
        /// </summary>
        public hvec5 rrrag => new hvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.xxxwz swizzling.
        /// </summary>
        public hvec5 xxxwz => new hvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.rrrab swizzling (equivalent to hvec4.xxxwz).
        /// </summary>
        public hvec5 rrrab => new hvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.xxxww swizzling.
        /// </summary>
        public hvec5 xxxww => new hvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.rrraa swizzling (equivalent to hvec4.xxxww).
        /// </summary>
        public hvec5 rrraa => new hvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.xxy swizzling.
        /// </summary>
        public hvec3 xxy => new hvec3(x, x, y);
        
        /// <summary>
        /// Returns hvec4.rrg swizzling (equivalent to hvec4.xxy).
        /// </summary>
        public hvec3 rrg => new hvec3(x, x, y);
        
        /// <summary>
        /// Returns hvec4.xxyx swizzling.
        /// </summary>
        public hvec4 xxyx => new hvec4(x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.rrgr swizzling (equivalent to hvec4.xxyx).
        /// </summary>
        public hvec4 rrgr => new hvec4(x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.xxyxx swizzling.
        /// </summary>
        public hvec5 xxyxx => new hvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.rrgrr swizzling (equivalent to hvec4.xxyxx).
        /// </summary>
        public hvec5 rrgrr => new hvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.xxyxy swizzling.
        /// </summary>
        public hvec5 xxyxy => new hvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.rrgrg swizzling (equivalent to hvec4.xxyxy).
        /// </summary>
        public hvec5 rrgrg => new hvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.xxyxz swizzling.
        /// </summary>
        public hvec5 xxyxz => new hvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.rrgrb swizzling (equivalent to hvec4.xxyxz).
        /// </summary>
        public hvec5 rrgrb => new hvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.xxyxw swizzling.
        /// </summary>
        public hvec5 xxyxw => new hvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.rrgra swizzling (equivalent to hvec4.xxyxw).
        /// </summary>
        public hvec5 rrgra => new hvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.xxyy swizzling.
        /// </summary>
        public hvec4 xxyy => new hvec4(x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.rrgg swizzling (equivalent to hvec4.xxyy).
        /// </summary>
        public hvec4 rrgg => new hvec4(x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.xxyyx swizzling.
        /// </summary>
        public hvec5 xxyyx => new hvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.rrggr swizzling (equivalent to hvec4.xxyyx).
        /// </summary>
        public hvec5 rrggr => new hvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.xxyyy swizzling.
        /// </summary>
        public hvec5 xxyyy => new hvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.rrggg swizzling (equivalent to hvec4.xxyyy).
        /// </summary>
        public hvec5 rrggg => new hvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.xxyyz swizzling.
        /// </summary>
        public hvec5 xxyyz => new hvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.rrggb swizzling (equivalent to hvec4.xxyyz).
        /// </summary>
        public hvec5 rrggb => new hvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.xxyyw swizzling.
        /// </summary>
        public hvec5 xxyyw => new hvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.rrgga swizzling (equivalent to hvec4.xxyyw).
        /// </summary>
        public hvec5 rrgga => new hvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.xxyz swizzling.
        /// </summary>
        public hvec4 xxyz => new hvec4(x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.rrgb swizzling (equivalent to hvec4.xxyz).
        /// </summary>
        public hvec4 rrgb => new hvec4(x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.xxyzx swizzling.
        /// </summary>
        public hvec5 xxyzx => new hvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.rrgbr swizzling (equivalent to hvec4.xxyzx).
        /// </summary>
        public hvec5 rrgbr => new hvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.xxyzy swizzling.
        /// </summary>
        public hvec5 xxyzy => new hvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.rrgbg swizzling (equivalent to hvec4.xxyzy).
        /// </summary>
        public hvec5 rrgbg => new hvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.xxyzz swizzling.
        /// </summary>
        public hvec5 xxyzz => new hvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.rrgbb swizzling (equivalent to hvec4.xxyzz).
        /// </summary>
        public hvec5 rrgbb => new hvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.xxyzw swizzling.
        /// </summary>
        public hvec5 xxyzw => new hvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.rrgba swizzling (equivalent to hvec4.xxyzw).
        /// </summary>
        public hvec5 rrgba => new hvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.xxyw swizzling.
        /// </summary>
        public hvec4 xxyw => new hvec4(x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.rrga swizzling (equivalent to hvec4.xxyw).
        /// </summary>
        public hvec4 rrga => new hvec4(x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.xxywx swizzling.
        /// </summary>
        public hvec5 xxywx => new hvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.rrgar swizzling (equivalent to hvec4.xxywx).
        /// </summary>
        public hvec5 rrgar => new hvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.xxywy swizzling.
        /// </summary>
        public hvec5 xxywy => new hvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.rrgag swizzling (equivalent to hvec4.xxywy).
        /// </summary>
        public hvec5 rrgag => new hvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.xxywz swizzling.
        /// </summary>
        public hvec5 xxywz => new hvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.rrgab swizzling (equivalent to hvec4.xxywz).
        /// </summary>
        public hvec5 rrgab => new hvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.xxyww swizzling.
        /// </summary>
        public hvec5 xxyww => new hvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.rrgaa swizzling (equivalent to hvec4.xxyww).
        /// </summary>
        public hvec5 rrgaa => new hvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.xxz swizzling.
        /// </summary>
        public hvec3 xxz => new hvec3(x, x, z);
        
        /// <summary>
        /// Returns hvec4.rrb swizzling (equivalent to hvec4.xxz).
        /// </summary>
        public hvec3 rrb => new hvec3(x, x, z);
        
        /// <summary>
        /// Returns hvec4.xxzx swizzling.
        /// </summary>
        public hvec4 xxzx => new hvec4(x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.rrbr swizzling (equivalent to hvec4.xxzx).
        /// </summary>
        public hvec4 rrbr => new hvec4(x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.xxzxx swizzling.
        /// </summary>
        public hvec5 xxzxx => new hvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.rrbrr swizzling (equivalent to hvec4.xxzxx).
        /// </summary>
        public hvec5 rrbrr => new hvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.xxzxy swizzling.
        /// </summary>
        public hvec5 xxzxy => new hvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.rrbrg swizzling (equivalent to hvec4.xxzxy).
        /// </summary>
        public hvec5 rrbrg => new hvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.xxzxz swizzling.
        /// </summary>
        public hvec5 xxzxz => new hvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.rrbrb swizzling (equivalent to hvec4.xxzxz).
        /// </summary>
        public hvec5 rrbrb => new hvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.xxzxw swizzling.
        /// </summary>
        public hvec5 xxzxw => new hvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.rrbra swizzling (equivalent to hvec4.xxzxw).
        /// </summary>
        public hvec5 rrbra => new hvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.xxzy swizzling.
        /// </summary>
        public hvec4 xxzy => new hvec4(x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.rrbg swizzling (equivalent to hvec4.xxzy).
        /// </summary>
        public hvec4 rrbg => new hvec4(x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.xxzyx swizzling.
        /// </summary>
        public hvec5 xxzyx => new hvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.rrbgr swizzling (equivalent to hvec4.xxzyx).
        /// </summary>
        public hvec5 rrbgr => new hvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.xxzyy swizzling.
        /// </summary>
        public hvec5 xxzyy => new hvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.rrbgg swizzling (equivalent to hvec4.xxzyy).
        /// </summary>
        public hvec5 rrbgg => new hvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.xxzyz swizzling.
        /// </summary>
        public hvec5 xxzyz => new hvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.rrbgb swizzling (equivalent to hvec4.xxzyz).
        /// </summary>
        public hvec5 rrbgb => new hvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.xxzyw swizzling.
        /// </summary>
        public hvec5 xxzyw => new hvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.rrbga swizzling (equivalent to hvec4.xxzyw).
        /// </summary>
        public hvec5 rrbga => new hvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.xxzz swizzling.
        /// </summary>
        public hvec4 xxzz => new hvec4(x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.rrbb swizzling (equivalent to hvec4.xxzz).
        /// </summary>
        public hvec4 rrbb => new hvec4(x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.xxzzx swizzling.
        /// </summary>
        public hvec5 xxzzx => new hvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.rrbbr swizzling (equivalent to hvec4.xxzzx).
        /// </summary>
        public hvec5 rrbbr => new hvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.xxzzy swizzling.
        /// </summary>
        public hvec5 xxzzy => new hvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.rrbbg swizzling (equivalent to hvec4.xxzzy).
        /// </summary>
        public hvec5 rrbbg => new hvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.xxzzz swizzling.
        /// </summary>
        public hvec5 xxzzz => new hvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.rrbbb swizzling (equivalent to hvec4.xxzzz).
        /// </summary>
        public hvec5 rrbbb => new hvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.xxzzw swizzling.
        /// </summary>
        public hvec5 xxzzw => new hvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.rrbba swizzling (equivalent to hvec4.xxzzw).
        /// </summary>
        public hvec5 rrbba => new hvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.xxzw swizzling.
        /// </summary>
        public hvec4 xxzw => new hvec4(x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.rrba swizzling (equivalent to hvec4.xxzw).
        /// </summary>
        public hvec4 rrba => new hvec4(x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.xxzwx swizzling.
        /// </summary>
        public hvec5 xxzwx => new hvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.rrbar swizzling (equivalent to hvec4.xxzwx).
        /// </summary>
        public hvec5 rrbar => new hvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.xxzwy swizzling.
        /// </summary>
        public hvec5 xxzwy => new hvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.rrbag swizzling (equivalent to hvec4.xxzwy).
        /// </summary>
        public hvec5 rrbag => new hvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.xxzwz swizzling.
        /// </summary>
        public hvec5 xxzwz => new hvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.rrbab swizzling (equivalent to hvec4.xxzwz).
        /// </summary>
        public hvec5 rrbab => new hvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.xxzww swizzling.
        /// </summary>
        public hvec5 xxzww => new hvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.rrbaa swizzling (equivalent to hvec4.xxzww).
        /// </summary>
        public hvec5 rrbaa => new hvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.xxw swizzling.
        /// </summary>
        public hvec3 xxw => new hvec3(x, x, w);
        
        /// <summary>
        /// Returns hvec4.rra swizzling (equivalent to hvec4.xxw).
        /// </summary>
        public hvec3 rra => new hvec3(x, x, w);
        
        /// <summary>
        /// Returns hvec4.xxwx swizzling.
        /// </summary>
        public hvec4 xxwx => new hvec4(x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.rrar swizzling (equivalent to hvec4.xxwx).
        /// </summary>
        public hvec4 rrar => new hvec4(x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.xxwxx swizzling.
        /// </summary>
        public hvec5 xxwxx => new hvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.rrarr swizzling (equivalent to hvec4.xxwxx).
        /// </summary>
        public hvec5 rrarr => new hvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.xxwxy swizzling.
        /// </summary>
        public hvec5 xxwxy => new hvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.rrarg swizzling (equivalent to hvec4.xxwxy).
        /// </summary>
        public hvec5 rrarg => new hvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.xxwxz swizzling.
        /// </summary>
        public hvec5 xxwxz => new hvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.rrarb swizzling (equivalent to hvec4.xxwxz).
        /// </summary>
        public hvec5 rrarb => new hvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.xxwxw swizzling.
        /// </summary>
        public hvec5 xxwxw => new hvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.rrara swizzling (equivalent to hvec4.xxwxw).
        /// </summary>
        public hvec5 rrara => new hvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.xxwy swizzling.
        /// </summary>
        public hvec4 xxwy => new hvec4(x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.rrag swizzling (equivalent to hvec4.xxwy).
        /// </summary>
        public hvec4 rrag => new hvec4(x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.xxwyx swizzling.
        /// </summary>
        public hvec5 xxwyx => new hvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.rragr swizzling (equivalent to hvec4.xxwyx).
        /// </summary>
        public hvec5 rragr => new hvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.xxwyy swizzling.
        /// </summary>
        public hvec5 xxwyy => new hvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.rragg swizzling (equivalent to hvec4.xxwyy).
        /// </summary>
        public hvec5 rragg => new hvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.xxwyz swizzling.
        /// </summary>
        public hvec5 xxwyz => new hvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.rragb swizzling (equivalent to hvec4.xxwyz).
        /// </summary>
        public hvec5 rragb => new hvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.xxwyw swizzling.
        /// </summary>
        public hvec5 xxwyw => new hvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.rraga swizzling (equivalent to hvec4.xxwyw).
        /// </summary>
        public hvec5 rraga => new hvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.xxwz swizzling.
        /// </summary>
        public hvec4 xxwz => new hvec4(x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.rrab swizzling (equivalent to hvec4.xxwz).
        /// </summary>
        public hvec4 rrab => new hvec4(x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.xxwzx swizzling.
        /// </summary>
        public hvec5 xxwzx => new hvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.rrabr swizzling (equivalent to hvec4.xxwzx).
        /// </summary>
        public hvec5 rrabr => new hvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.xxwzy swizzling.
        /// </summary>
        public hvec5 xxwzy => new hvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.rrabg swizzling (equivalent to hvec4.xxwzy).
        /// </summary>
        public hvec5 rrabg => new hvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.xxwzz swizzling.
        /// </summary>
        public hvec5 xxwzz => new hvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.rrabb swizzling (equivalent to hvec4.xxwzz).
        /// </summary>
        public hvec5 rrabb => new hvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.xxwzw swizzling.
        /// </summary>
        public hvec5 xxwzw => new hvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.rraba swizzling (equivalent to hvec4.xxwzw).
        /// </summary>
        public hvec5 rraba => new hvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.xxww swizzling.
        /// </summary>
        public hvec4 xxww => new hvec4(x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.rraa swizzling (equivalent to hvec4.xxww).
        /// </summary>
        public hvec4 rraa => new hvec4(x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.xxwwx swizzling.
        /// </summary>
        public hvec5 xxwwx => new hvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.rraar swizzling (equivalent to hvec4.xxwwx).
        /// </summary>
        public hvec5 rraar => new hvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.xxwwy swizzling.
        /// </summary>
        public hvec5 xxwwy => new hvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.rraag swizzling (equivalent to hvec4.xxwwy).
        /// </summary>
        public hvec5 rraag => new hvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.xxwwz swizzling.
        /// </summary>
        public hvec5 xxwwz => new hvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.rraab swizzling (equivalent to hvec4.xxwwz).
        /// </summary>
        public hvec5 rraab => new hvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.xxwww swizzling.
        /// </summary>
        public hvec5 xxwww => new hvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.rraaa swizzling (equivalent to hvec4.xxwww).
        /// </summary>
        public hvec5 rraaa => new hvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.xy swizzling.
        /// </summary>
        public hvec2 xy => new hvec2(x, y);
        
        /// <summary>
        /// Returns hvec4.rg swizzling (equivalent to hvec4.xy).
        /// </summary>
        public hvec2 rg => new hvec2(x, y);
        
        /// <summary>
        /// Returns hvec4.xyx swizzling.
        /// </summary>
        public hvec3 xyx => new hvec3(x, y, x);
        
        /// <summary>
        /// Returns hvec4.rgr swizzling (equivalent to hvec4.xyx).
        /// </summary>
        public hvec3 rgr => new hvec3(x, y, x);
        
        /// <summary>
        /// Returns hvec4.xyxx swizzling.
        /// </summary>
        public hvec4 xyxx => new hvec4(x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.rgrr swizzling (equivalent to hvec4.xyxx).
        /// </summary>
        public hvec4 rgrr => new hvec4(x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.xyxxx swizzling.
        /// </summary>
        public hvec5 xyxxx => new hvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.rgrrr swizzling (equivalent to hvec4.xyxxx).
        /// </summary>
        public hvec5 rgrrr => new hvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.xyxxy swizzling.
        /// </summary>
        public hvec5 xyxxy => new hvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.rgrrg swizzling (equivalent to hvec4.xyxxy).
        /// </summary>
        public hvec5 rgrrg => new hvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.xyxxz swizzling.
        /// </summary>
        public hvec5 xyxxz => new hvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.rgrrb swizzling (equivalent to hvec4.xyxxz).
        /// </summary>
        public hvec5 rgrrb => new hvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.xyxxw swizzling.
        /// </summary>
        public hvec5 xyxxw => new hvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.rgrra swizzling (equivalent to hvec4.xyxxw).
        /// </summary>
        public hvec5 rgrra => new hvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.xyxy swizzling.
        /// </summary>
        public hvec4 xyxy => new hvec4(x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.rgrg swizzling (equivalent to hvec4.xyxy).
        /// </summary>
        public hvec4 rgrg => new hvec4(x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.xyxyx swizzling.
        /// </summary>
        public hvec5 xyxyx => new hvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.rgrgr swizzling (equivalent to hvec4.xyxyx).
        /// </summary>
        public hvec5 rgrgr => new hvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.xyxyy swizzling.
        /// </summary>
        public hvec5 xyxyy => new hvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.rgrgg swizzling (equivalent to hvec4.xyxyy).
        /// </summary>
        public hvec5 rgrgg => new hvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.xyxyz swizzling.
        /// </summary>
        public hvec5 xyxyz => new hvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.rgrgb swizzling (equivalent to hvec4.xyxyz).
        /// </summary>
        public hvec5 rgrgb => new hvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.xyxyw swizzling.
        /// </summary>
        public hvec5 xyxyw => new hvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.rgrga swizzling (equivalent to hvec4.xyxyw).
        /// </summary>
        public hvec5 rgrga => new hvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.xyxz swizzling.
        /// </summary>
        public hvec4 xyxz => new hvec4(x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.rgrb swizzling (equivalent to hvec4.xyxz).
        /// </summary>
        public hvec4 rgrb => new hvec4(x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.xyxzx swizzling.
        /// </summary>
        public hvec5 xyxzx => new hvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.rgrbr swizzling (equivalent to hvec4.xyxzx).
        /// </summary>
        public hvec5 rgrbr => new hvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.xyxzy swizzling.
        /// </summary>
        public hvec5 xyxzy => new hvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.rgrbg swizzling (equivalent to hvec4.xyxzy).
        /// </summary>
        public hvec5 rgrbg => new hvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.xyxzz swizzling.
        /// </summary>
        public hvec5 xyxzz => new hvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.rgrbb swizzling (equivalent to hvec4.xyxzz).
        /// </summary>
        public hvec5 rgrbb => new hvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.xyxzw swizzling.
        /// </summary>
        public hvec5 xyxzw => new hvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.rgrba swizzling (equivalent to hvec4.xyxzw).
        /// </summary>
        public hvec5 rgrba => new hvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.xyxw swizzling.
        /// </summary>
        public hvec4 xyxw => new hvec4(x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.rgra swizzling (equivalent to hvec4.xyxw).
        /// </summary>
        public hvec4 rgra => new hvec4(x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.xyxwx swizzling.
        /// </summary>
        public hvec5 xyxwx => new hvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.rgrar swizzling (equivalent to hvec4.xyxwx).
        /// </summary>
        public hvec5 rgrar => new hvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.xyxwy swizzling.
        /// </summary>
        public hvec5 xyxwy => new hvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.rgrag swizzling (equivalent to hvec4.xyxwy).
        /// </summary>
        public hvec5 rgrag => new hvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.xyxwz swizzling.
        /// </summary>
        public hvec5 xyxwz => new hvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.rgrab swizzling (equivalent to hvec4.xyxwz).
        /// </summary>
        public hvec5 rgrab => new hvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.xyxww swizzling.
        /// </summary>
        public hvec5 xyxww => new hvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.rgraa swizzling (equivalent to hvec4.xyxww).
        /// </summary>
        public hvec5 rgraa => new hvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.xyy swizzling.
        /// </summary>
        public hvec3 xyy => new hvec3(x, y, y);
        
        /// <summary>
        /// Returns hvec4.rgg swizzling (equivalent to hvec4.xyy).
        /// </summary>
        public hvec3 rgg => new hvec3(x, y, y);
        
        /// <summary>
        /// Returns hvec4.xyyx swizzling.
        /// </summary>
        public hvec4 xyyx => new hvec4(x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.rggr swizzling (equivalent to hvec4.xyyx).
        /// </summary>
        public hvec4 rggr => new hvec4(x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.xyyxx swizzling.
        /// </summary>
        public hvec5 xyyxx => new hvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.rggrr swizzling (equivalent to hvec4.xyyxx).
        /// </summary>
        public hvec5 rggrr => new hvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.xyyxy swizzling.
        /// </summary>
        public hvec5 xyyxy => new hvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.rggrg swizzling (equivalent to hvec4.xyyxy).
        /// </summary>
        public hvec5 rggrg => new hvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.xyyxz swizzling.
        /// </summary>
        public hvec5 xyyxz => new hvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.rggrb swizzling (equivalent to hvec4.xyyxz).
        /// </summary>
        public hvec5 rggrb => new hvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.xyyxw swizzling.
        /// </summary>
        public hvec5 xyyxw => new hvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.rggra swizzling (equivalent to hvec4.xyyxw).
        /// </summary>
        public hvec5 rggra => new hvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.xyyy swizzling.
        /// </summary>
        public hvec4 xyyy => new hvec4(x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.rggg swizzling (equivalent to hvec4.xyyy).
        /// </summary>
        public hvec4 rggg => new hvec4(x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.xyyyx swizzling.
        /// </summary>
        public hvec5 xyyyx => new hvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.rgggr swizzling (equivalent to hvec4.xyyyx).
        /// </summary>
        public hvec5 rgggr => new hvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.xyyyy swizzling.
        /// </summary>
        public hvec5 xyyyy => new hvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.rgggg swizzling (equivalent to hvec4.xyyyy).
        /// </summary>
        public hvec5 rgggg => new hvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.xyyyz swizzling.
        /// </summary>
        public hvec5 xyyyz => new hvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.rgggb swizzling (equivalent to hvec4.xyyyz).
        /// </summary>
        public hvec5 rgggb => new hvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.xyyyw swizzling.
        /// </summary>
        public hvec5 xyyyw => new hvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.rggga swizzling (equivalent to hvec4.xyyyw).
        /// </summary>
        public hvec5 rggga => new hvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.xyyz swizzling.
        /// </summary>
        public hvec4 xyyz => new hvec4(x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.rggb swizzling (equivalent to hvec4.xyyz).
        /// </summary>
        public hvec4 rggb => new hvec4(x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.xyyzx swizzling.
        /// </summary>
        public hvec5 xyyzx => new hvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.rggbr swizzling (equivalent to hvec4.xyyzx).
        /// </summary>
        public hvec5 rggbr => new hvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.xyyzy swizzling.
        /// </summary>
        public hvec5 xyyzy => new hvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.rggbg swizzling (equivalent to hvec4.xyyzy).
        /// </summary>
        public hvec5 rggbg => new hvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.xyyzz swizzling.
        /// </summary>
        public hvec5 xyyzz => new hvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.rggbb swizzling (equivalent to hvec4.xyyzz).
        /// </summary>
        public hvec5 rggbb => new hvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.xyyzw swizzling.
        /// </summary>
        public hvec5 xyyzw => new hvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.rggba swizzling (equivalent to hvec4.xyyzw).
        /// </summary>
        public hvec5 rggba => new hvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.xyyw swizzling.
        /// </summary>
        public hvec4 xyyw => new hvec4(x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.rgga swizzling (equivalent to hvec4.xyyw).
        /// </summary>
        public hvec4 rgga => new hvec4(x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.xyywx swizzling.
        /// </summary>
        public hvec5 xyywx => new hvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.rggar swizzling (equivalent to hvec4.xyywx).
        /// </summary>
        public hvec5 rggar => new hvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.xyywy swizzling.
        /// </summary>
        public hvec5 xyywy => new hvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.rggag swizzling (equivalent to hvec4.xyywy).
        /// </summary>
        public hvec5 rggag => new hvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.xyywz swizzling.
        /// </summary>
        public hvec5 xyywz => new hvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.rggab swizzling (equivalent to hvec4.xyywz).
        /// </summary>
        public hvec5 rggab => new hvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.xyyww swizzling.
        /// </summary>
        public hvec5 xyyww => new hvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.rggaa swizzling (equivalent to hvec4.xyyww).
        /// </summary>
        public hvec5 rggaa => new hvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.xyz swizzling.
        /// </summary>
        public hvec3 xyz => new hvec3(x, y, z);
        
        /// <summary>
        /// Returns hvec4.rgb swizzling (equivalent to hvec4.xyz).
        /// </summary>
        public hvec3 rgb => new hvec3(x, y, z);
        
        /// <summary>
        /// Returns hvec4.xyzx swizzling.
        /// </summary>
        public hvec4 xyzx => new hvec4(x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.rgbr swizzling (equivalent to hvec4.xyzx).
        /// </summary>
        public hvec4 rgbr => new hvec4(x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.xyzxx swizzling.
        /// </summary>
        public hvec5 xyzxx => new hvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.rgbrr swizzling (equivalent to hvec4.xyzxx).
        /// </summary>
        public hvec5 rgbrr => new hvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.xyzxy swizzling.
        /// </summary>
        public hvec5 xyzxy => new hvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.rgbrg swizzling (equivalent to hvec4.xyzxy).
        /// </summary>
        public hvec5 rgbrg => new hvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.xyzxz swizzling.
        /// </summary>
        public hvec5 xyzxz => new hvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.rgbrb swizzling (equivalent to hvec4.xyzxz).
        /// </summary>
        public hvec5 rgbrb => new hvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.xyzxw swizzling.
        /// </summary>
        public hvec5 xyzxw => new hvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.rgbra swizzling (equivalent to hvec4.xyzxw).
        /// </summary>
        public hvec5 rgbra => new hvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.xyzy swizzling.
        /// </summary>
        public hvec4 xyzy => new hvec4(x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.rgbg swizzling (equivalent to hvec4.xyzy).
        /// </summary>
        public hvec4 rgbg => new hvec4(x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.xyzyx swizzling.
        /// </summary>
        public hvec5 xyzyx => new hvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.rgbgr swizzling (equivalent to hvec4.xyzyx).
        /// </summary>
        public hvec5 rgbgr => new hvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.xyzyy swizzling.
        /// </summary>
        public hvec5 xyzyy => new hvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.rgbgg swizzling (equivalent to hvec4.xyzyy).
        /// </summary>
        public hvec5 rgbgg => new hvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.xyzyz swizzling.
        /// </summary>
        public hvec5 xyzyz => new hvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.rgbgb swizzling (equivalent to hvec4.xyzyz).
        /// </summary>
        public hvec5 rgbgb => new hvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.xyzyw swizzling.
        /// </summary>
        public hvec5 xyzyw => new hvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.rgbga swizzling (equivalent to hvec4.xyzyw).
        /// </summary>
        public hvec5 rgbga => new hvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.xyzz swizzling.
        /// </summary>
        public hvec4 xyzz => new hvec4(x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.rgbb swizzling (equivalent to hvec4.xyzz).
        /// </summary>
        public hvec4 rgbb => new hvec4(x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.xyzzx swizzling.
        /// </summary>
        public hvec5 xyzzx => new hvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.rgbbr swizzling (equivalent to hvec4.xyzzx).
        /// </summary>
        public hvec5 rgbbr => new hvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.xyzzy swizzling.
        /// </summary>
        public hvec5 xyzzy => new hvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.rgbbg swizzling (equivalent to hvec4.xyzzy).
        /// </summary>
        public hvec5 rgbbg => new hvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.xyzzz swizzling.
        /// </summary>
        public hvec5 xyzzz => new hvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.rgbbb swizzling (equivalent to hvec4.xyzzz).
        /// </summary>
        public hvec5 rgbbb => new hvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.xyzzw swizzling.
        /// </summary>
        public hvec5 xyzzw => new hvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.rgbba swizzling (equivalent to hvec4.xyzzw).
        /// </summary>
        public hvec5 rgbba => new hvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.xyzw swizzling.
        /// </summary>
        public hvec4 xyzw => new hvec4(x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.rgba swizzling (equivalent to hvec4.xyzw).
        /// </summary>
        public hvec4 rgba => new hvec4(x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.xyzwx swizzling.
        /// </summary>
        public hvec5 xyzwx => new hvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.rgbar swizzling (equivalent to hvec4.xyzwx).
        /// </summary>
        public hvec5 rgbar => new hvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.xyzwy swizzling.
        /// </summary>
        public hvec5 xyzwy => new hvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.rgbag swizzling (equivalent to hvec4.xyzwy).
        /// </summary>
        public hvec5 rgbag => new hvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.xyzwz swizzling.
        /// </summary>
        public hvec5 xyzwz => new hvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.rgbab swizzling (equivalent to hvec4.xyzwz).
        /// </summary>
        public hvec5 rgbab => new hvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.xyzww swizzling.
        /// </summary>
        public hvec5 xyzww => new hvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.rgbaa swizzling (equivalent to hvec4.xyzww).
        /// </summary>
        public hvec5 rgbaa => new hvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.xyw swizzling.
        /// </summary>
        public hvec3 xyw => new hvec3(x, y, w);
        
        /// <summary>
        /// Returns hvec4.rga swizzling (equivalent to hvec4.xyw).
        /// </summary>
        public hvec3 rga => new hvec3(x, y, w);
        
        /// <summary>
        /// Returns hvec4.xywx swizzling.
        /// </summary>
        public hvec4 xywx => new hvec4(x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.rgar swizzling (equivalent to hvec4.xywx).
        /// </summary>
        public hvec4 rgar => new hvec4(x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.xywxx swizzling.
        /// </summary>
        public hvec5 xywxx => new hvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.rgarr swizzling (equivalent to hvec4.xywxx).
        /// </summary>
        public hvec5 rgarr => new hvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.xywxy swizzling.
        /// </summary>
        public hvec5 xywxy => new hvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.rgarg swizzling (equivalent to hvec4.xywxy).
        /// </summary>
        public hvec5 rgarg => new hvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.xywxz swizzling.
        /// </summary>
        public hvec5 xywxz => new hvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.rgarb swizzling (equivalent to hvec4.xywxz).
        /// </summary>
        public hvec5 rgarb => new hvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.xywxw swizzling.
        /// </summary>
        public hvec5 xywxw => new hvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.rgara swizzling (equivalent to hvec4.xywxw).
        /// </summary>
        public hvec5 rgara => new hvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.xywy swizzling.
        /// </summary>
        public hvec4 xywy => new hvec4(x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.rgag swizzling (equivalent to hvec4.xywy).
        /// </summary>
        public hvec4 rgag => new hvec4(x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.xywyx swizzling.
        /// </summary>
        public hvec5 xywyx => new hvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.rgagr swizzling (equivalent to hvec4.xywyx).
        /// </summary>
        public hvec5 rgagr => new hvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.xywyy swizzling.
        /// </summary>
        public hvec5 xywyy => new hvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.rgagg swizzling (equivalent to hvec4.xywyy).
        /// </summary>
        public hvec5 rgagg => new hvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.xywyz swizzling.
        /// </summary>
        public hvec5 xywyz => new hvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.rgagb swizzling (equivalent to hvec4.xywyz).
        /// </summary>
        public hvec5 rgagb => new hvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.xywyw swizzling.
        /// </summary>
        public hvec5 xywyw => new hvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.rgaga swizzling (equivalent to hvec4.xywyw).
        /// </summary>
        public hvec5 rgaga => new hvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.xywz swizzling.
        /// </summary>
        public hvec4 xywz => new hvec4(x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.rgab swizzling (equivalent to hvec4.xywz).
        /// </summary>
        public hvec4 rgab => new hvec4(x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.xywzx swizzling.
        /// </summary>
        public hvec5 xywzx => new hvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.rgabr swizzling (equivalent to hvec4.xywzx).
        /// </summary>
        public hvec5 rgabr => new hvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.xywzy swizzling.
        /// </summary>
        public hvec5 xywzy => new hvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.rgabg swizzling (equivalent to hvec4.xywzy).
        /// </summary>
        public hvec5 rgabg => new hvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.xywzz swizzling.
        /// </summary>
        public hvec5 xywzz => new hvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.rgabb swizzling (equivalent to hvec4.xywzz).
        /// </summary>
        public hvec5 rgabb => new hvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.xywzw swizzling.
        /// </summary>
        public hvec5 xywzw => new hvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.rgaba swizzling (equivalent to hvec4.xywzw).
        /// </summary>
        public hvec5 rgaba => new hvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.xyww swizzling.
        /// </summary>
        public hvec4 xyww => new hvec4(x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.rgaa swizzling (equivalent to hvec4.xyww).
        /// </summary>
        public hvec4 rgaa => new hvec4(x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.xywwx swizzling.
        /// </summary>
        public hvec5 xywwx => new hvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.rgaar swizzling (equivalent to hvec4.xywwx).
        /// </summary>
        public hvec5 rgaar => new hvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.xywwy swizzling.
        /// </summary>
        public hvec5 xywwy => new hvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.rgaag swizzling (equivalent to hvec4.xywwy).
        /// </summary>
        public hvec5 rgaag => new hvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.xywwz swizzling.
        /// </summary>
        public hvec5 xywwz => new hvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.rgaab swizzling (equivalent to hvec4.xywwz).
        /// </summary>
        public hvec5 rgaab => new hvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.xywww swizzling.
        /// </summary>
        public hvec5 xywww => new hvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.rgaaa swizzling (equivalent to hvec4.xywww).
        /// </summary>
        public hvec5 rgaaa => new hvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.xz swizzling.
        /// </summary>
        public hvec2 xz => new hvec2(x, z);
        
        /// <summary>
        /// Returns hvec4.rb swizzling (equivalent to hvec4.xz).
        /// </summary>
        public hvec2 rb => new hvec2(x, z);
        
        /// <summary>
        /// Returns hvec4.xzx swizzling.
        /// </summary>
        public hvec3 xzx => new hvec3(x, z, x);
        
        /// <summary>
        /// Returns hvec4.rbr swizzling (equivalent to hvec4.xzx).
        /// </summary>
        public hvec3 rbr => new hvec3(x, z, x);
        
        /// <summary>
        /// Returns hvec4.xzxx swizzling.
        /// </summary>
        public hvec4 xzxx => new hvec4(x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.rbrr swizzling (equivalent to hvec4.xzxx).
        /// </summary>
        public hvec4 rbrr => new hvec4(x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.xzxxx swizzling.
        /// </summary>
        public hvec5 xzxxx => new hvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.rbrrr swizzling (equivalent to hvec4.xzxxx).
        /// </summary>
        public hvec5 rbrrr => new hvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.xzxxy swizzling.
        /// </summary>
        public hvec5 xzxxy => new hvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.rbrrg swizzling (equivalent to hvec4.xzxxy).
        /// </summary>
        public hvec5 rbrrg => new hvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.xzxxz swizzling.
        /// </summary>
        public hvec5 xzxxz => new hvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.rbrrb swizzling (equivalent to hvec4.xzxxz).
        /// </summary>
        public hvec5 rbrrb => new hvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.xzxxw swizzling.
        /// </summary>
        public hvec5 xzxxw => new hvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.rbrra swizzling (equivalent to hvec4.xzxxw).
        /// </summary>
        public hvec5 rbrra => new hvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.xzxy swizzling.
        /// </summary>
        public hvec4 xzxy => new hvec4(x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.rbrg swizzling (equivalent to hvec4.xzxy).
        /// </summary>
        public hvec4 rbrg => new hvec4(x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.xzxyx swizzling.
        /// </summary>
        public hvec5 xzxyx => new hvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.rbrgr swizzling (equivalent to hvec4.xzxyx).
        /// </summary>
        public hvec5 rbrgr => new hvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.xzxyy swizzling.
        /// </summary>
        public hvec5 xzxyy => new hvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.rbrgg swizzling (equivalent to hvec4.xzxyy).
        /// </summary>
        public hvec5 rbrgg => new hvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.xzxyz swizzling.
        /// </summary>
        public hvec5 xzxyz => new hvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.rbrgb swizzling (equivalent to hvec4.xzxyz).
        /// </summary>
        public hvec5 rbrgb => new hvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.xzxyw swizzling.
        /// </summary>
        public hvec5 xzxyw => new hvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.rbrga swizzling (equivalent to hvec4.xzxyw).
        /// </summary>
        public hvec5 rbrga => new hvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.xzxz swizzling.
        /// </summary>
        public hvec4 xzxz => new hvec4(x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.rbrb swizzling (equivalent to hvec4.xzxz).
        /// </summary>
        public hvec4 rbrb => new hvec4(x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.xzxzx swizzling.
        /// </summary>
        public hvec5 xzxzx => new hvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.rbrbr swizzling (equivalent to hvec4.xzxzx).
        /// </summary>
        public hvec5 rbrbr => new hvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.xzxzy swizzling.
        /// </summary>
        public hvec5 xzxzy => new hvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.rbrbg swizzling (equivalent to hvec4.xzxzy).
        /// </summary>
        public hvec5 rbrbg => new hvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.xzxzz swizzling.
        /// </summary>
        public hvec5 xzxzz => new hvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.rbrbb swizzling (equivalent to hvec4.xzxzz).
        /// </summary>
        public hvec5 rbrbb => new hvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.xzxzw swizzling.
        /// </summary>
        public hvec5 xzxzw => new hvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.rbrba swizzling (equivalent to hvec4.xzxzw).
        /// </summary>
        public hvec5 rbrba => new hvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.xzxw swizzling.
        /// </summary>
        public hvec4 xzxw => new hvec4(x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.rbra swizzling (equivalent to hvec4.xzxw).
        /// </summary>
        public hvec4 rbra => new hvec4(x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.xzxwx swizzling.
        /// </summary>
        public hvec5 xzxwx => new hvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.rbrar swizzling (equivalent to hvec4.xzxwx).
        /// </summary>
        public hvec5 rbrar => new hvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.xzxwy swizzling.
        /// </summary>
        public hvec5 xzxwy => new hvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.rbrag swizzling (equivalent to hvec4.xzxwy).
        /// </summary>
        public hvec5 rbrag => new hvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.xzxwz swizzling.
        /// </summary>
        public hvec5 xzxwz => new hvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.rbrab swizzling (equivalent to hvec4.xzxwz).
        /// </summary>
        public hvec5 rbrab => new hvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.xzxww swizzling.
        /// </summary>
        public hvec5 xzxww => new hvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.rbraa swizzling (equivalent to hvec4.xzxww).
        /// </summary>
        public hvec5 rbraa => new hvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.xzy swizzling.
        /// </summary>
        public hvec3 xzy => new hvec3(x, z, y);
        
        /// <summary>
        /// Returns hvec4.rbg swizzling (equivalent to hvec4.xzy).
        /// </summary>
        public hvec3 rbg => new hvec3(x, z, y);
        
        /// <summary>
        /// Returns hvec4.xzyx swizzling.
        /// </summary>
        public hvec4 xzyx => new hvec4(x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.rbgr swizzling (equivalent to hvec4.xzyx).
        /// </summary>
        public hvec4 rbgr => new hvec4(x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.xzyxx swizzling.
        /// </summary>
        public hvec5 xzyxx => new hvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.rbgrr swizzling (equivalent to hvec4.xzyxx).
        /// </summary>
        public hvec5 rbgrr => new hvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.xzyxy swizzling.
        /// </summary>
        public hvec5 xzyxy => new hvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.rbgrg swizzling (equivalent to hvec4.xzyxy).
        /// </summary>
        public hvec5 rbgrg => new hvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.xzyxz swizzling.
        /// </summary>
        public hvec5 xzyxz => new hvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.rbgrb swizzling (equivalent to hvec4.xzyxz).
        /// </summary>
        public hvec5 rbgrb => new hvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.xzyxw swizzling.
        /// </summary>
        public hvec5 xzyxw => new hvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.rbgra swizzling (equivalent to hvec4.xzyxw).
        /// </summary>
        public hvec5 rbgra => new hvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.xzyy swizzling.
        /// </summary>
        public hvec4 xzyy => new hvec4(x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.rbgg swizzling (equivalent to hvec4.xzyy).
        /// </summary>
        public hvec4 rbgg => new hvec4(x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.xzyyx swizzling.
        /// </summary>
        public hvec5 xzyyx => new hvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.rbggr swizzling (equivalent to hvec4.xzyyx).
        /// </summary>
        public hvec5 rbggr => new hvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.xzyyy swizzling.
        /// </summary>
        public hvec5 xzyyy => new hvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.rbggg swizzling (equivalent to hvec4.xzyyy).
        /// </summary>
        public hvec5 rbggg => new hvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.xzyyz swizzling.
        /// </summary>
        public hvec5 xzyyz => new hvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.rbggb swizzling (equivalent to hvec4.xzyyz).
        /// </summary>
        public hvec5 rbggb => new hvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.xzyyw swizzling.
        /// </summary>
        public hvec5 xzyyw => new hvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.rbgga swizzling (equivalent to hvec4.xzyyw).
        /// </summary>
        public hvec5 rbgga => new hvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.xzyz swizzling.
        /// </summary>
        public hvec4 xzyz => new hvec4(x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.rbgb swizzling (equivalent to hvec4.xzyz).
        /// </summary>
        public hvec4 rbgb => new hvec4(x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.xzyzx swizzling.
        /// </summary>
        public hvec5 xzyzx => new hvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.rbgbr swizzling (equivalent to hvec4.xzyzx).
        /// </summary>
        public hvec5 rbgbr => new hvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.xzyzy swizzling.
        /// </summary>
        public hvec5 xzyzy => new hvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.rbgbg swizzling (equivalent to hvec4.xzyzy).
        /// </summary>
        public hvec5 rbgbg => new hvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.xzyzz swizzling.
        /// </summary>
        public hvec5 xzyzz => new hvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.rbgbb swizzling (equivalent to hvec4.xzyzz).
        /// </summary>
        public hvec5 rbgbb => new hvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.xzyzw swizzling.
        /// </summary>
        public hvec5 xzyzw => new hvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.rbgba swizzling (equivalent to hvec4.xzyzw).
        /// </summary>
        public hvec5 rbgba => new hvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.xzyw swizzling.
        /// </summary>
        public hvec4 xzyw => new hvec4(x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.rbga swizzling (equivalent to hvec4.xzyw).
        /// </summary>
        public hvec4 rbga => new hvec4(x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.xzywx swizzling.
        /// </summary>
        public hvec5 xzywx => new hvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.rbgar swizzling (equivalent to hvec4.xzywx).
        /// </summary>
        public hvec5 rbgar => new hvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.xzywy swizzling.
        /// </summary>
        public hvec5 xzywy => new hvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.rbgag swizzling (equivalent to hvec4.xzywy).
        /// </summary>
        public hvec5 rbgag => new hvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.xzywz swizzling.
        /// </summary>
        public hvec5 xzywz => new hvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.rbgab swizzling (equivalent to hvec4.xzywz).
        /// </summary>
        public hvec5 rbgab => new hvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.xzyww swizzling.
        /// </summary>
        public hvec5 xzyww => new hvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.rbgaa swizzling (equivalent to hvec4.xzyww).
        /// </summary>
        public hvec5 rbgaa => new hvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.xzz swizzling.
        /// </summary>
        public hvec3 xzz => new hvec3(x, z, z);
        
        /// <summary>
        /// Returns hvec4.rbb swizzling (equivalent to hvec4.xzz).
        /// </summary>
        public hvec3 rbb => new hvec3(x, z, z);
        
        /// <summary>
        /// Returns hvec4.xzzx swizzling.
        /// </summary>
        public hvec4 xzzx => new hvec4(x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.rbbr swizzling (equivalent to hvec4.xzzx).
        /// </summary>
        public hvec4 rbbr => new hvec4(x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.xzzxx swizzling.
        /// </summary>
        public hvec5 xzzxx => new hvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.rbbrr swizzling (equivalent to hvec4.xzzxx).
        /// </summary>
        public hvec5 rbbrr => new hvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.xzzxy swizzling.
        /// </summary>
        public hvec5 xzzxy => new hvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.rbbrg swizzling (equivalent to hvec4.xzzxy).
        /// </summary>
        public hvec5 rbbrg => new hvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.xzzxz swizzling.
        /// </summary>
        public hvec5 xzzxz => new hvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.rbbrb swizzling (equivalent to hvec4.xzzxz).
        /// </summary>
        public hvec5 rbbrb => new hvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.xzzxw swizzling.
        /// </summary>
        public hvec5 xzzxw => new hvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.rbbra swizzling (equivalent to hvec4.xzzxw).
        /// </summary>
        public hvec5 rbbra => new hvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.xzzy swizzling.
        /// </summary>
        public hvec4 xzzy => new hvec4(x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.rbbg swizzling (equivalent to hvec4.xzzy).
        /// </summary>
        public hvec4 rbbg => new hvec4(x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.xzzyx swizzling.
        /// </summary>
        public hvec5 xzzyx => new hvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.rbbgr swizzling (equivalent to hvec4.xzzyx).
        /// </summary>
        public hvec5 rbbgr => new hvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.xzzyy swizzling.
        /// </summary>
        public hvec5 xzzyy => new hvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.rbbgg swizzling (equivalent to hvec4.xzzyy).
        /// </summary>
        public hvec5 rbbgg => new hvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.xzzyz swizzling.
        /// </summary>
        public hvec5 xzzyz => new hvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.rbbgb swizzling (equivalent to hvec4.xzzyz).
        /// </summary>
        public hvec5 rbbgb => new hvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.xzzyw swizzling.
        /// </summary>
        public hvec5 xzzyw => new hvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.rbbga swizzling (equivalent to hvec4.xzzyw).
        /// </summary>
        public hvec5 rbbga => new hvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.xzzz swizzling.
        /// </summary>
        public hvec4 xzzz => new hvec4(x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.rbbb swizzling (equivalent to hvec4.xzzz).
        /// </summary>
        public hvec4 rbbb => new hvec4(x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.xzzzx swizzling.
        /// </summary>
        public hvec5 xzzzx => new hvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.rbbbr swizzling (equivalent to hvec4.xzzzx).
        /// </summary>
        public hvec5 rbbbr => new hvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.xzzzy swizzling.
        /// </summary>
        public hvec5 xzzzy => new hvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.rbbbg swizzling (equivalent to hvec4.xzzzy).
        /// </summary>
        public hvec5 rbbbg => new hvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.xzzzz swizzling.
        /// </summary>
        public hvec5 xzzzz => new hvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.rbbbb swizzling (equivalent to hvec4.xzzzz).
        /// </summary>
        public hvec5 rbbbb => new hvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.xzzzw swizzling.
        /// </summary>
        public hvec5 xzzzw => new hvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.rbbba swizzling (equivalent to hvec4.xzzzw).
        /// </summary>
        public hvec5 rbbba => new hvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.xzzw swizzling.
        /// </summary>
        public hvec4 xzzw => new hvec4(x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.rbba swizzling (equivalent to hvec4.xzzw).
        /// </summary>
        public hvec4 rbba => new hvec4(x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.xzzwx swizzling.
        /// </summary>
        public hvec5 xzzwx => new hvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.rbbar swizzling (equivalent to hvec4.xzzwx).
        /// </summary>
        public hvec5 rbbar => new hvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.xzzwy swizzling.
        /// </summary>
        public hvec5 xzzwy => new hvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.rbbag swizzling (equivalent to hvec4.xzzwy).
        /// </summary>
        public hvec5 rbbag => new hvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.xzzwz swizzling.
        /// </summary>
        public hvec5 xzzwz => new hvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.rbbab swizzling (equivalent to hvec4.xzzwz).
        /// </summary>
        public hvec5 rbbab => new hvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.xzzww swizzling.
        /// </summary>
        public hvec5 xzzww => new hvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.rbbaa swizzling (equivalent to hvec4.xzzww).
        /// </summary>
        public hvec5 rbbaa => new hvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.xzw swizzling.
        /// </summary>
        public hvec3 xzw => new hvec3(x, z, w);
        
        /// <summary>
        /// Returns hvec4.rba swizzling (equivalent to hvec4.xzw).
        /// </summary>
        public hvec3 rba => new hvec3(x, z, w);
        
        /// <summary>
        /// Returns hvec4.xzwx swizzling.
        /// </summary>
        public hvec4 xzwx => new hvec4(x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.rbar swizzling (equivalent to hvec4.xzwx).
        /// </summary>
        public hvec4 rbar => new hvec4(x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.xzwxx swizzling.
        /// </summary>
        public hvec5 xzwxx => new hvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.rbarr swizzling (equivalent to hvec4.xzwxx).
        /// </summary>
        public hvec5 rbarr => new hvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.xzwxy swizzling.
        /// </summary>
        public hvec5 xzwxy => new hvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.rbarg swizzling (equivalent to hvec4.xzwxy).
        /// </summary>
        public hvec5 rbarg => new hvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.xzwxz swizzling.
        /// </summary>
        public hvec5 xzwxz => new hvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.rbarb swizzling (equivalent to hvec4.xzwxz).
        /// </summary>
        public hvec5 rbarb => new hvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.xzwxw swizzling.
        /// </summary>
        public hvec5 xzwxw => new hvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.rbara swizzling (equivalent to hvec4.xzwxw).
        /// </summary>
        public hvec5 rbara => new hvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.xzwy swizzling.
        /// </summary>
        public hvec4 xzwy => new hvec4(x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.rbag swizzling (equivalent to hvec4.xzwy).
        /// </summary>
        public hvec4 rbag => new hvec4(x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.xzwyx swizzling.
        /// </summary>
        public hvec5 xzwyx => new hvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.rbagr swizzling (equivalent to hvec4.xzwyx).
        /// </summary>
        public hvec5 rbagr => new hvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.xzwyy swizzling.
        /// </summary>
        public hvec5 xzwyy => new hvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.rbagg swizzling (equivalent to hvec4.xzwyy).
        /// </summary>
        public hvec5 rbagg => new hvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.xzwyz swizzling.
        /// </summary>
        public hvec5 xzwyz => new hvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.rbagb swizzling (equivalent to hvec4.xzwyz).
        /// </summary>
        public hvec5 rbagb => new hvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.xzwyw swizzling.
        /// </summary>
        public hvec5 xzwyw => new hvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.rbaga swizzling (equivalent to hvec4.xzwyw).
        /// </summary>
        public hvec5 rbaga => new hvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.xzwz swizzling.
        /// </summary>
        public hvec4 xzwz => new hvec4(x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.rbab swizzling (equivalent to hvec4.xzwz).
        /// </summary>
        public hvec4 rbab => new hvec4(x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.xzwzx swizzling.
        /// </summary>
        public hvec5 xzwzx => new hvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.rbabr swizzling (equivalent to hvec4.xzwzx).
        /// </summary>
        public hvec5 rbabr => new hvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.xzwzy swizzling.
        /// </summary>
        public hvec5 xzwzy => new hvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.rbabg swizzling (equivalent to hvec4.xzwzy).
        /// </summary>
        public hvec5 rbabg => new hvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.xzwzz swizzling.
        /// </summary>
        public hvec5 xzwzz => new hvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.rbabb swizzling (equivalent to hvec4.xzwzz).
        /// </summary>
        public hvec5 rbabb => new hvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.xzwzw swizzling.
        /// </summary>
        public hvec5 xzwzw => new hvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.rbaba swizzling (equivalent to hvec4.xzwzw).
        /// </summary>
        public hvec5 rbaba => new hvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.xzww swizzling.
        /// </summary>
        public hvec4 xzww => new hvec4(x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.rbaa swizzling (equivalent to hvec4.xzww).
        /// </summary>
        public hvec4 rbaa => new hvec4(x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.xzwwx swizzling.
        /// </summary>
        public hvec5 xzwwx => new hvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.rbaar swizzling (equivalent to hvec4.xzwwx).
        /// </summary>
        public hvec5 rbaar => new hvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.xzwwy swizzling.
        /// </summary>
        public hvec5 xzwwy => new hvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.rbaag swizzling (equivalent to hvec4.xzwwy).
        /// </summary>
        public hvec5 rbaag => new hvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.xzwwz swizzling.
        /// </summary>
        public hvec5 xzwwz => new hvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.rbaab swizzling (equivalent to hvec4.xzwwz).
        /// </summary>
        public hvec5 rbaab => new hvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.xzwww swizzling.
        /// </summary>
        public hvec5 xzwww => new hvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.rbaaa swizzling (equivalent to hvec4.xzwww).
        /// </summary>
        public hvec5 rbaaa => new hvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.xw swizzling.
        /// </summary>
        public hvec2 xw => new hvec2(x, w);
        
        /// <summary>
        /// Returns hvec4.ra swizzling (equivalent to hvec4.xw).
        /// </summary>
        public hvec2 ra => new hvec2(x, w);
        
        /// <summary>
        /// Returns hvec4.xwx swizzling.
        /// </summary>
        public hvec3 xwx => new hvec3(x, w, x);
        
        /// <summary>
        /// Returns hvec4.rar swizzling (equivalent to hvec4.xwx).
        /// </summary>
        public hvec3 rar => new hvec3(x, w, x);
        
        /// <summary>
        /// Returns hvec4.xwxx swizzling.
        /// </summary>
        public hvec4 xwxx => new hvec4(x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.rarr swizzling (equivalent to hvec4.xwxx).
        /// </summary>
        public hvec4 rarr => new hvec4(x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.xwxxx swizzling.
        /// </summary>
        public hvec5 xwxxx => new hvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.rarrr swizzling (equivalent to hvec4.xwxxx).
        /// </summary>
        public hvec5 rarrr => new hvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.xwxxy swizzling.
        /// </summary>
        public hvec5 xwxxy => new hvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.rarrg swizzling (equivalent to hvec4.xwxxy).
        /// </summary>
        public hvec5 rarrg => new hvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.xwxxz swizzling.
        /// </summary>
        public hvec5 xwxxz => new hvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.rarrb swizzling (equivalent to hvec4.xwxxz).
        /// </summary>
        public hvec5 rarrb => new hvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.xwxxw swizzling.
        /// </summary>
        public hvec5 xwxxw => new hvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.rarra swizzling (equivalent to hvec4.xwxxw).
        /// </summary>
        public hvec5 rarra => new hvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.xwxy swizzling.
        /// </summary>
        public hvec4 xwxy => new hvec4(x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.rarg swizzling (equivalent to hvec4.xwxy).
        /// </summary>
        public hvec4 rarg => new hvec4(x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.xwxyx swizzling.
        /// </summary>
        public hvec5 xwxyx => new hvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.rargr swizzling (equivalent to hvec4.xwxyx).
        /// </summary>
        public hvec5 rargr => new hvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.xwxyy swizzling.
        /// </summary>
        public hvec5 xwxyy => new hvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.rargg swizzling (equivalent to hvec4.xwxyy).
        /// </summary>
        public hvec5 rargg => new hvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.xwxyz swizzling.
        /// </summary>
        public hvec5 xwxyz => new hvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.rargb swizzling (equivalent to hvec4.xwxyz).
        /// </summary>
        public hvec5 rargb => new hvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.xwxyw swizzling.
        /// </summary>
        public hvec5 xwxyw => new hvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.rarga swizzling (equivalent to hvec4.xwxyw).
        /// </summary>
        public hvec5 rarga => new hvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.xwxz swizzling.
        /// </summary>
        public hvec4 xwxz => new hvec4(x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.rarb swizzling (equivalent to hvec4.xwxz).
        /// </summary>
        public hvec4 rarb => new hvec4(x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.xwxzx swizzling.
        /// </summary>
        public hvec5 xwxzx => new hvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.rarbr swizzling (equivalent to hvec4.xwxzx).
        /// </summary>
        public hvec5 rarbr => new hvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.xwxzy swizzling.
        /// </summary>
        public hvec5 xwxzy => new hvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.rarbg swizzling (equivalent to hvec4.xwxzy).
        /// </summary>
        public hvec5 rarbg => new hvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.xwxzz swizzling.
        /// </summary>
        public hvec5 xwxzz => new hvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.rarbb swizzling (equivalent to hvec4.xwxzz).
        /// </summary>
        public hvec5 rarbb => new hvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.xwxzw swizzling.
        /// </summary>
        public hvec5 xwxzw => new hvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.rarba swizzling (equivalent to hvec4.xwxzw).
        /// </summary>
        public hvec5 rarba => new hvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.xwxw swizzling.
        /// </summary>
        public hvec4 xwxw => new hvec4(x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.rara swizzling (equivalent to hvec4.xwxw).
        /// </summary>
        public hvec4 rara => new hvec4(x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.xwxwx swizzling.
        /// </summary>
        public hvec5 xwxwx => new hvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.rarar swizzling (equivalent to hvec4.xwxwx).
        /// </summary>
        public hvec5 rarar => new hvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.xwxwy swizzling.
        /// </summary>
        public hvec5 xwxwy => new hvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.rarag swizzling (equivalent to hvec4.xwxwy).
        /// </summary>
        public hvec5 rarag => new hvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.xwxwz swizzling.
        /// </summary>
        public hvec5 xwxwz => new hvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.rarab swizzling (equivalent to hvec4.xwxwz).
        /// </summary>
        public hvec5 rarab => new hvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.xwxww swizzling.
        /// </summary>
        public hvec5 xwxww => new hvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.raraa swizzling (equivalent to hvec4.xwxww).
        /// </summary>
        public hvec5 raraa => new hvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.xwy swizzling.
        /// </summary>
        public hvec3 xwy => new hvec3(x, w, y);
        
        /// <summary>
        /// Returns hvec4.rag swizzling (equivalent to hvec4.xwy).
        /// </summary>
        public hvec3 rag => new hvec3(x, w, y);
        
        /// <summary>
        /// Returns hvec4.xwyx swizzling.
        /// </summary>
        public hvec4 xwyx => new hvec4(x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.ragr swizzling (equivalent to hvec4.xwyx).
        /// </summary>
        public hvec4 ragr => new hvec4(x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.xwyxx swizzling.
        /// </summary>
        public hvec5 xwyxx => new hvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.ragrr swizzling (equivalent to hvec4.xwyxx).
        /// </summary>
        public hvec5 ragrr => new hvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.xwyxy swizzling.
        /// </summary>
        public hvec5 xwyxy => new hvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.ragrg swizzling (equivalent to hvec4.xwyxy).
        /// </summary>
        public hvec5 ragrg => new hvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.xwyxz swizzling.
        /// </summary>
        public hvec5 xwyxz => new hvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.ragrb swizzling (equivalent to hvec4.xwyxz).
        /// </summary>
        public hvec5 ragrb => new hvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.xwyxw swizzling.
        /// </summary>
        public hvec5 xwyxw => new hvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.ragra swizzling (equivalent to hvec4.xwyxw).
        /// </summary>
        public hvec5 ragra => new hvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.xwyy swizzling.
        /// </summary>
        public hvec4 xwyy => new hvec4(x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.ragg swizzling (equivalent to hvec4.xwyy).
        /// </summary>
        public hvec4 ragg => new hvec4(x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.xwyyx swizzling.
        /// </summary>
        public hvec5 xwyyx => new hvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.raggr swizzling (equivalent to hvec4.xwyyx).
        /// </summary>
        public hvec5 raggr => new hvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.xwyyy swizzling.
        /// </summary>
        public hvec5 xwyyy => new hvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.raggg swizzling (equivalent to hvec4.xwyyy).
        /// </summary>
        public hvec5 raggg => new hvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.xwyyz swizzling.
        /// </summary>
        public hvec5 xwyyz => new hvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.raggb swizzling (equivalent to hvec4.xwyyz).
        /// </summary>
        public hvec5 raggb => new hvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.xwyyw swizzling.
        /// </summary>
        public hvec5 xwyyw => new hvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.ragga swizzling (equivalent to hvec4.xwyyw).
        /// </summary>
        public hvec5 ragga => new hvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.xwyz swizzling.
        /// </summary>
        public hvec4 xwyz => new hvec4(x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.ragb swizzling (equivalent to hvec4.xwyz).
        /// </summary>
        public hvec4 ragb => new hvec4(x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.xwyzx swizzling.
        /// </summary>
        public hvec5 xwyzx => new hvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.ragbr swizzling (equivalent to hvec4.xwyzx).
        /// </summary>
        public hvec5 ragbr => new hvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.xwyzy swizzling.
        /// </summary>
        public hvec5 xwyzy => new hvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.ragbg swizzling (equivalent to hvec4.xwyzy).
        /// </summary>
        public hvec5 ragbg => new hvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.xwyzz swizzling.
        /// </summary>
        public hvec5 xwyzz => new hvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.ragbb swizzling (equivalent to hvec4.xwyzz).
        /// </summary>
        public hvec5 ragbb => new hvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.xwyzw swizzling.
        /// </summary>
        public hvec5 xwyzw => new hvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.ragba swizzling (equivalent to hvec4.xwyzw).
        /// </summary>
        public hvec5 ragba => new hvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.xwyw swizzling.
        /// </summary>
        public hvec4 xwyw => new hvec4(x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.raga swizzling (equivalent to hvec4.xwyw).
        /// </summary>
        public hvec4 raga => new hvec4(x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.xwywx swizzling.
        /// </summary>
        public hvec5 xwywx => new hvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.ragar swizzling (equivalent to hvec4.xwywx).
        /// </summary>
        public hvec5 ragar => new hvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.xwywy swizzling.
        /// </summary>
        public hvec5 xwywy => new hvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.ragag swizzling (equivalent to hvec4.xwywy).
        /// </summary>
        public hvec5 ragag => new hvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.xwywz swizzling.
        /// </summary>
        public hvec5 xwywz => new hvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.ragab swizzling (equivalent to hvec4.xwywz).
        /// </summary>
        public hvec5 ragab => new hvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.xwyww swizzling.
        /// </summary>
        public hvec5 xwyww => new hvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.ragaa swizzling (equivalent to hvec4.xwyww).
        /// </summary>
        public hvec5 ragaa => new hvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.xwz swizzling.
        /// </summary>
        public hvec3 xwz => new hvec3(x, w, z);
        
        /// <summary>
        /// Returns hvec4.rab swizzling (equivalent to hvec4.xwz).
        /// </summary>
        public hvec3 rab => new hvec3(x, w, z);
        
        /// <summary>
        /// Returns hvec4.xwzx swizzling.
        /// </summary>
        public hvec4 xwzx => new hvec4(x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.rabr swizzling (equivalent to hvec4.xwzx).
        /// </summary>
        public hvec4 rabr => new hvec4(x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.xwzxx swizzling.
        /// </summary>
        public hvec5 xwzxx => new hvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.rabrr swizzling (equivalent to hvec4.xwzxx).
        /// </summary>
        public hvec5 rabrr => new hvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.xwzxy swizzling.
        /// </summary>
        public hvec5 xwzxy => new hvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.rabrg swizzling (equivalent to hvec4.xwzxy).
        /// </summary>
        public hvec5 rabrg => new hvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.xwzxz swizzling.
        /// </summary>
        public hvec5 xwzxz => new hvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.rabrb swizzling (equivalent to hvec4.xwzxz).
        /// </summary>
        public hvec5 rabrb => new hvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.xwzxw swizzling.
        /// </summary>
        public hvec5 xwzxw => new hvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.rabra swizzling (equivalent to hvec4.xwzxw).
        /// </summary>
        public hvec5 rabra => new hvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.xwzy swizzling.
        /// </summary>
        public hvec4 xwzy => new hvec4(x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.rabg swizzling (equivalent to hvec4.xwzy).
        /// </summary>
        public hvec4 rabg => new hvec4(x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.xwzyx swizzling.
        /// </summary>
        public hvec5 xwzyx => new hvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.rabgr swizzling (equivalent to hvec4.xwzyx).
        /// </summary>
        public hvec5 rabgr => new hvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.xwzyy swizzling.
        /// </summary>
        public hvec5 xwzyy => new hvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.rabgg swizzling (equivalent to hvec4.xwzyy).
        /// </summary>
        public hvec5 rabgg => new hvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.xwzyz swizzling.
        /// </summary>
        public hvec5 xwzyz => new hvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.rabgb swizzling (equivalent to hvec4.xwzyz).
        /// </summary>
        public hvec5 rabgb => new hvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.xwzyw swizzling.
        /// </summary>
        public hvec5 xwzyw => new hvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.rabga swizzling (equivalent to hvec4.xwzyw).
        /// </summary>
        public hvec5 rabga => new hvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.xwzz swizzling.
        /// </summary>
        public hvec4 xwzz => new hvec4(x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.rabb swizzling (equivalent to hvec4.xwzz).
        /// </summary>
        public hvec4 rabb => new hvec4(x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.xwzzx swizzling.
        /// </summary>
        public hvec5 xwzzx => new hvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.rabbr swizzling (equivalent to hvec4.xwzzx).
        /// </summary>
        public hvec5 rabbr => new hvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.xwzzy swizzling.
        /// </summary>
        public hvec5 xwzzy => new hvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.rabbg swizzling (equivalent to hvec4.xwzzy).
        /// </summary>
        public hvec5 rabbg => new hvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.xwzzz swizzling.
        /// </summary>
        public hvec5 xwzzz => new hvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.rabbb swizzling (equivalent to hvec4.xwzzz).
        /// </summary>
        public hvec5 rabbb => new hvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.xwzzw swizzling.
        /// </summary>
        public hvec5 xwzzw => new hvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.rabba swizzling (equivalent to hvec4.xwzzw).
        /// </summary>
        public hvec5 rabba => new hvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.xwzw swizzling.
        /// </summary>
        public hvec4 xwzw => new hvec4(x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.raba swizzling (equivalent to hvec4.xwzw).
        /// </summary>
        public hvec4 raba => new hvec4(x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.xwzwx swizzling.
        /// </summary>
        public hvec5 xwzwx => new hvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.rabar swizzling (equivalent to hvec4.xwzwx).
        /// </summary>
        public hvec5 rabar => new hvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.xwzwy swizzling.
        /// </summary>
        public hvec5 xwzwy => new hvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.rabag swizzling (equivalent to hvec4.xwzwy).
        /// </summary>
        public hvec5 rabag => new hvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.xwzwz swizzling.
        /// </summary>
        public hvec5 xwzwz => new hvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.rabab swizzling (equivalent to hvec4.xwzwz).
        /// </summary>
        public hvec5 rabab => new hvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.xwzww swizzling.
        /// </summary>
        public hvec5 xwzww => new hvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.rabaa swizzling (equivalent to hvec4.xwzww).
        /// </summary>
        public hvec5 rabaa => new hvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.xww swizzling.
        /// </summary>
        public hvec3 xww => new hvec3(x, w, w);
        
        /// <summary>
        /// Returns hvec4.raa swizzling (equivalent to hvec4.xww).
        /// </summary>
        public hvec3 raa => new hvec3(x, w, w);
        
        /// <summary>
        /// Returns hvec4.xwwx swizzling.
        /// </summary>
        public hvec4 xwwx => new hvec4(x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.raar swizzling (equivalent to hvec4.xwwx).
        /// </summary>
        public hvec4 raar => new hvec4(x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.xwwxx swizzling.
        /// </summary>
        public hvec5 xwwxx => new hvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.raarr swizzling (equivalent to hvec4.xwwxx).
        /// </summary>
        public hvec5 raarr => new hvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.xwwxy swizzling.
        /// </summary>
        public hvec5 xwwxy => new hvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.raarg swizzling (equivalent to hvec4.xwwxy).
        /// </summary>
        public hvec5 raarg => new hvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.xwwxz swizzling.
        /// </summary>
        public hvec5 xwwxz => new hvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.raarb swizzling (equivalent to hvec4.xwwxz).
        /// </summary>
        public hvec5 raarb => new hvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.xwwxw swizzling.
        /// </summary>
        public hvec5 xwwxw => new hvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.raara swizzling (equivalent to hvec4.xwwxw).
        /// </summary>
        public hvec5 raara => new hvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.xwwy swizzling.
        /// </summary>
        public hvec4 xwwy => new hvec4(x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.raag swizzling (equivalent to hvec4.xwwy).
        /// </summary>
        public hvec4 raag => new hvec4(x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.xwwyx swizzling.
        /// </summary>
        public hvec5 xwwyx => new hvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.raagr swizzling (equivalent to hvec4.xwwyx).
        /// </summary>
        public hvec5 raagr => new hvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.xwwyy swizzling.
        /// </summary>
        public hvec5 xwwyy => new hvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.raagg swizzling (equivalent to hvec4.xwwyy).
        /// </summary>
        public hvec5 raagg => new hvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.xwwyz swizzling.
        /// </summary>
        public hvec5 xwwyz => new hvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.raagb swizzling (equivalent to hvec4.xwwyz).
        /// </summary>
        public hvec5 raagb => new hvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.xwwyw swizzling.
        /// </summary>
        public hvec5 xwwyw => new hvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.raaga swizzling (equivalent to hvec4.xwwyw).
        /// </summary>
        public hvec5 raaga => new hvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.xwwz swizzling.
        /// </summary>
        public hvec4 xwwz => new hvec4(x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.raab swizzling (equivalent to hvec4.xwwz).
        /// </summary>
        public hvec4 raab => new hvec4(x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.xwwzx swizzling.
        /// </summary>
        public hvec5 xwwzx => new hvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.raabr swizzling (equivalent to hvec4.xwwzx).
        /// </summary>
        public hvec5 raabr => new hvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.xwwzy swizzling.
        /// </summary>
        public hvec5 xwwzy => new hvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.raabg swizzling (equivalent to hvec4.xwwzy).
        /// </summary>
        public hvec5 raabg => new hvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.xwwzz swizzling.
        /// </summary>
        public hvec5 xwwzz => new hvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.raabb swizzling (equivalent to hvec4.xwwzz).
        /// </summary>
        public hvec5 raabb => new hvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.xwwzw swizzling.
        /// </summary>
        public hvec5 xwwzw => new hvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.raaba swizzling (equivalent to hvec4.xwwzw).
        /// </summary>
        public hvec5 raaba => new hvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.xwww swizzling.
        /// </summary>
        public hvec4 xwww => new hvec4(x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.raaa swizzling (equivalent to hvec4.xwww).
        /// </summary>
        public hvec4 raaa => new hvec4(x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.xwwwx swizzling.
        /// </summary>
        public hvec5 xwwwx => new hvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.raaar swizzling (equivalent to hvec4.xwwwx).
        /// </summary>
        public hvec5 raaar => new hvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.xwwwy swizzling.
        /// </summary>
        public hvec5 xwwwy => new hvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.raaag swizzling (equivalent to hvec4.xwwwy).
        /// </summary>
        public hvec5 raaag => new hvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.xwwwz swizzling.
        /// </summary>
        public hvec5 xwwwz => new hvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.raaab swizzling (equivalent to hvec4.xwwwz).
        /// </summary>
        public hvec5 raaab => new hvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.xwwww swizzling.
        /// </summary>
        public hvec5 xwwww => new hvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns hvec4.raaaa swizzling (equivalent to hvec4.xwwww).
        /// </summary>
        public hvec5 raaaa => new hvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns hvec4.yx swizzling.
        /// </summary>
        public hvec2 yx => new hvec2(y, x);
        
        /// <summary>
        /// Returns hvec4.gr swizzling (equivalent to hvec4.yx).
        /// </summary>
        public hvec2 gr => new hvec2(y, x);
        
        /// <summary>
        /// Returns hvec4.yxx swizzling.
        /// </summary>
        public hvec3 yxx => new hvec3(y, x, x);
        
        /// <summary>
        /// Returns hvec4.grr swizzling (equivalent to hvec4.yxx).
        /// </summary>
        public hvec3 grr => new hvec3(y, x, x);
        
        /// <summary>
        /// Returns hvec4.yxxx swizzling.
        /// </summary>
        public hvec4 yxxx => new hvec4(y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.grrr swizzling (equivalent to hvec4.yxxx).
        /// </summary>
        public hvec4 grrr => new hvec4(y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.yxxxx swizzling.
        /// </summary>
        public hvec5 yxxxx => new hvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.grrrr swizzling (equivalent to hvec4.yxxxx).
        /// </summary>
        public hvec5 grrrr => new hvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.yxxxy swizzling.
        /// </summary>
        public hvec5 yxxxy => new hvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.grrrg swizzling (equivalent to hvec4.yxxxy).
        /// </summary>
        public hvec5 grrrg => new hvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.yxxxz swizzling.
        /// </summary>
        public hvec5 yxxxz => new hvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.grrrb swizzling (equivalent to hvec4.yxxxz).
        /// </summary>
        public hvec5 grrrb => new hvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.yxxxw swizzling.
        /// </summary>
        public hvec5 yxxxw => new hvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.grrra swizzling (equivalent to hvec4.yxxxw).
        /// </summary>
        public hvec5 grrra => new hvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.yxxy swizzling.
        /// </summary>
        public hvec4 yxxy => new hvec4(y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.grrg swizzling (equivalent to hvec4.yxxy).
        /// </summary>
        public hvec4 grrg => new hvec4(y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.yxxyx swizzling.
        /// </summary>
        public hvec5 yxxyx => new hvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.grrgr swizzling (equivalent to hvec4.yxxyx).
        /// </summary>
        public hvec5 grrgr => new hvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.yxxyy swizzling.
        /// </summary>
        public hvec5 yxxyy => new hvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.grrgg swizzling (equivalent to hvec4.yxxyy).
        /// </summary>
        public hvec5 grrgg => new hvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.yxxyz swizzling.
        /// </summary>
        public hvec5 yxxyz => new hvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.grrgb swizzling (equivalent to hvec4.yxxyz).
        /// </summary>
        public hvec5 grrgb => new hvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.yxxyw swizzling.
        /// </summary>
        public hvec5 yxxyw => new hvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.grrga swizzling (equivalent to hvec4.yxxyw).
        /// </summary>
        public hvec5 grrga => new hvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.yxxz swizzling.
        /// </summary>
        public hvec4 yxxz => new hvec4(y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.grrb swizzling (equivalent to hvec4.yxxz).
        /// </summary>
        public hvec4 grrb => new hvec4(y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.yxxzx swizzling.
        /// </summary>
        public hvec5 yxxzx => new hvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.grrbr swizzling (equivalent to hvec4.yxxzx).
        /// </summary>
        public hvec5 grrbr => new hvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.yxxzy swizzling.
        /// </summary>
        public hvec5 yxxzy => new hvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.grrbg swizzling (equivalent to hvec4.yxxzy).
        /// </summary>
        public hvec5 grrbg => new hvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.yxxzz swizzling.
        /// </summary>
        public hvec5 yxxzz => new hvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.grrbb swizzling (equivalent to hvec4.yxxzz).
        /// </summary>
        public hvec5 grrbb => new hvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.yxxzw swizzling.
        /// </summary>
        public hvec5 yxxzw => new hvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.grrba swizzling (equivalent to hvec4.yxxzw).
        /// </summary>
        public hvec5 grrba => new hvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.yxxw swizzling.
        /// </summary>
        public hvec4 yxxw => new hvec4(y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.grra swizzling (equivalent to hvec4.yxxw).
        /// </summary>
        public hvec4 grra => new hvec4(y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.yxxwx swizzling.
        /// </summary>
        public hvec5 yxxwx => new hvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.grrar swizzling (equivalent to hvec4.yxxwx).
        /// </summary>
        public hvec5 grrar => new hvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.yxxwy swizzling.
        /// </summary>
        public hvec5 yxxwy => new hvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.grrag swizzling (equivalent to hvec4.yxxwy).
        /// </summary>
        public hvec5 grrag => new hvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.yxxwz swizzling.
        /// </summary>
        public hvec5 yxxwz => new hvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.grrab swizzling (equivalent to hvec4.yxxwz).
        /// </summary>
        public hvec5 grrab => new hvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.yxxww swizzling.
        /// </summary>
        public hvec5 yxxww => new hvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.grraa swizzling (equivalent to hvec4.yxxww).
        /// </summary>
        public hvec5 grraa => new hvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.yxy swizzling.
        /// </summary>
        public hvec3 yxy => new hvec3(y, x, y);
        
        /// <summary>
        /// Returns hvec4.grg swizzling (equivalent to hvec4.yxy).
        /// </summary>
        public hvec3 grg => new hvec3(y, x, y);
        
        /// <summary>
        /// Returns hvec4.yxyx swizzling.
        /// </summary>
        public hvec4 yxyx => new hvec4(y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.grgr swizzling (equivalent to hvec4.yxyx).
        /// </summary>
        public hvec4 grgr => new hvec4(y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.yxyxx swizzling.
        /// </summary>
        public hvec5 yxyxx => new hvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.grgrr swizzling (equivalent to hvec4.yxyxx).
        /// </summary>
        public hvec5 grgrr => new hvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.yxyxy swizzling.
        /// </summary>
        public hvec5 yxyxy => new hvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.grgrg swizzling (equivalent to hvec4.yxyxy).
        /// </summary>
        public hvec5 grgrg => new hvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.yxyxz swizzling.
        /// </summary>
        public hvec5 yxyxz => new hvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.grgrb swizzling (equivalent to hvec4.yxyxz).
        /// </summary>
        public hvec5 grgrb => new hvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.yxyxw swizzling.
        /// </summary>
        public hvec5 yxyxw => new hvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.grgra swizzling (equivalent to hvec4.yxyxw).
        /// </summary>
        public hvec5 grgra => new hvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.yxyy swizzling.
        /// </summary>
        public hvec4 yxyy => new hvec4(y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.grgg swizzling (equivalent to hvec4.yxyy).
        /// </summary>
        public hvec4 grgg => new hvec4(y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.yxyyx swizzling.
        /// </summary>
        public hvec5 yxyyx => new hvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.grggr swizzling (equivalent to hvec4.yxyyx).
        /// </summary>
        public hvec5 grggr => new hvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.yxyyy swizzling.
        /// </summary>
        public hvec5 yxyyy => new hvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.grggg swizzling (equivalent to hvec4.yxyyy).
        /// </summary>
        public hvec5 grggg => new hvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.yxyyz swizzling.
        /// </summary>
        public hvec5 yxyyz => new hvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.grggb swizzling (equivalent to hvec4.yxyyz).
        /// </summary>
        public hvec5 grggb => new hvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.yxyyw swizzling.
        /// </summary>
        public hvec5 yxyyw => new hvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.grgga swizzling (equivalent to hvec4.yxyyw).
        /// </summary>
        public hvec5 grgga => new hvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.yxyz swizzling.
        /// </summary>
        public hvec4 yxyz => new hvec4(y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.grgb swizzling (equivalent to hvec4.yxyz).
        /// </summary>
        public hvec4 grgb => new hvec4(y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.yxyzx swizzling.
        /// </summary>
        public hvec5 yxyzx => new hvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.grgbr swizzling (equivalent to hvec4.yxyzx).
        /// </summary>
        public hvec5 grgbr => new hvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.yxyzy swizzling.
        /// </summary>
        public hvec5 yxyzy => new hvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.grgbg swizzling (equivalent to hvec4.yxyzy).
        /// </summary>
        public hvec5 grgbg => new hvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.yxyzz swizzling.
        /// </summary>
        public hvec5 yxyzz => new hvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.grgbb swizzling (equivalent to hvec4.yxyzz).
        /// </summary>
        public hvec5 grgbb => new hvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.yxyzw swizzling.
        /// </summary>
        public hvec5 yxyzw => new hvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.grgba swizzling (equivalent to hvec4.yxyzw).
        /// </summary>
        public hvec5 grgba => new hvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.yxyw swizzling.
        /// </summary>
        public hvec4 yxyw => new hvec4(y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.grga swizzling (equivalent to hvec4.yxyw).
        /// </summary>
        public hvec4 grga => new hvec4(y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.yxywx swizzling.
        /// </summary>
        public hvec5 yxywx => new hvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.grgar swizzling (equivalent to hvec4.yxywx).
        /// </summary>
        public hvec5 grgar => new hvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.yxywy swizzling.
        /// </summary>
        public hvec5 yxywy => new hvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.grgag swizzling (equivalent to hvec4.yxywy).
        /// </summary>
        public hvec5 grgag => new hvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.yxywz swizzling.
        /// </summary>
        public hvec5 yxywz => new hvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.grgab swizzling (equivalent to hvec4.yxywz).
        /// </summary>
        public hvec5 grgab => new hvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.yxyww swizzling.
        /// </summary>
        public hvec5 yxyww => new hvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.grgaa swizzling (equivalent to hvec4.yxyww).
        /// </summary>
        public hvec5 grgaa => new hvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.yxz swizzling.
        /// </summary>
        public hvec3 yxz => new hvec3(y, x, z);
        
        /// <summary>
        /// Returns hvec4.grb swizzling (equivalent to hvec4.yxz).
        /// </summary>
        public hvec3 grb => new hvec3(y, x, z);
        
        /// <summary>
        /// Returns hvec4.yxzx swizzling.
        /// </summary>
        public hvec4 yxzx => new hvec4(y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.grbr swizzling (equivalent to hvec4.yxzx).
        /// </summary>
        public hvec4 grbr => new hvec4(y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.yxzxx swizzling.
        /// </summary>
        public hvec5 yxzxx => new hvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.grbrr swizzling (equivalent to hvec4.yxzxx).
        /// </summary>
        public hvec5 grbrr => new hvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.yxzxy swizzling.
        /// </summary>
        public hvec5 yxzxy => new hvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.grbrg swizzling (equivalent to hvec4.yxzxy).
        /// </summary>
        public hvec5 grbrg => new hvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.yxzxz swizzling.
        /// </summary>
        public hvec5 yxzxz => new hvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.grbrb swizzling (equivalent to hvec4.yxzxz).
        /// </summary>
        public hvec5 grbrb => new hvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.yxzxw swizzling.
        /// </summary>
        public hvec5 yxzxw => new hvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.grbra swizzling (equivalent to hvec4.yxzxw).
        /// </summary>
        public hvec5 grbra => new hvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.yxzy swizzling.
        /// </summary>
        public hvec4 yxzy => new hvec4(y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.grbg swizzling (equivalent to hvec4.yxzy).
        /// </summary>
        public hvec4 grbg => new hvec4(y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.yxzyx swizzling.
        /// </summary>
        public hvec5 yxzyx => new hvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.grbgr swizzling (equivalent to hvec4.yxzyx).
        /// </summary>
        public hvec5 grbgr => new hvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.yxzyy swizzling.
        /// </summary>
        public hvec5 yxzyy => new hvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.grbgg swizzling (equivalent to hvec4.yxzyy).
        /// </summary>
        public hvec5 grbgg => new hvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.yxzyz swizzling.
        /// </summary>
        public hvec5 yxzyz => new hvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.grbgb swizzling (equivalent to hvec4.yxzyz).
        /// </summary>
        public hvec5 grbgb => new hvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.yxzyw swizzling.
        /// </summary>
        public hvec5 yxzyw => new hvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.grbga swizzling (equivalent to hvec4.yxzyw).
        /// </summary>
        public hvec5 grbga => new hvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.yxzz swizzling.
        /// </summary>
        public hvec4 yxzz => new hvec4(y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.grbb swizzling (equivalent to hvec4.yxzz).
        /// </summary>
        public hvec4 grbb => new hvec4(y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.yxzzx swizzling.
        /// </summary>
        public hvec5 yxzzx => new hvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.grbbr swizzling (equivalent to hvec4.yxzzx).
        /// </summary>
        public hvec5 grbbr => new hvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.yxzzy swizzling.
        /// </summary>
        public hvec5 yxzzy => new hvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.grbbg swizzling (equivalent to hvec4.yxzzy).
        /// </summary>
        public hvec5 grbbg => new hvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.yxzzz swizzling.
        /// </summary>
        public hvec5 yxzzz => new hvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.grbbb swizzling (equivalent to hvec4.yxzzz).
        /// </summary>
        public hvec5 grbbb => new hvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.yxzzw swizzling.
        /// </summary>
        public hvec5 yxzzw => new hvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.grbba swizzling (equivalent to hvec4.yxzzw).
        /// </summary>
        public hvec5 grbba => new hvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.yxzw swizzling.
        /// </summary>
        public hvec4 yxzw => new hvec4(y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.grba swizzling (equivalent to hvec4.yxzw).
        /// </summary>
        public hvec4 grba => new hvec4(y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.yxzwx swizzling.
        /// </summary>
        public hvec5 yxzwx => new hvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.grbar swizzling (equivalent to hvec4.yxzwx).
        /// </summary>
        public hvec5 grbar => new hvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.yxzwy swizzling.
        /// </summary>
        public hvec5 yxzwy => new hvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.grbag swizzling (equivalent to hvec4.yxzwy).
        /// </summary>
        public hvec5 grbag => new hvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.yxzwz swizzling.
        /// </summary>
        public hvec5 yxzwz => new hvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.grbab swizzling (equivalent to hvec4.yxzwz).
        /// </summary>
        public hvec5 grbab => new hvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.yxzww swizzling.
        /// </summary>
        public hvec5 yxzww => new hvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.grbaa swizzling (equivalent to hvec4.yxzww).
        /// </summary>
        public hvec5 grbaa => new hvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.yxw swizzling.
        /// </summary>
        public hvec3 yxw => new hvec3(y, x, w);
        
        /// <summary>
        /// Returns hvec4.gra swizzling (equivalent to hvec4.yxw).
        /// </summary>
        public hvec3 gra => new hvec3(y, x, w);
        
        /// <summary>
        /// Returns hvec4.yxwx swizzling.
        /// </summary>
        public hvec4 yxwx => new hvec4(y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.grar swizzling (equivalent to hvec4.yxwx).
        /// </summary>
        public hvec4 grar => new hvec4(y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.yxwxx swizzling.
        /// </summary>
        public hvec5 yxwxx => new hvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.grarr swizzling (equivalent to hvec4.yxwxx).
        /// </summary>
        public hvec5 grarr => new hvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.yxwxy swizzling.
        /// </summary>
        public hvec5 yxwxy => new hvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.grarg swizzling (equivalent to hvec4.yxwxy).
        /// </summary>
        public hvec5 grarg => new hvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.yxwxz swizzling.
        /// </summary>
        public hvec5 yxwxz => new hvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.grarb swizzling (equivalent to hvec4.yxwxz).
        /// </summary>
        public hvec5 grarb => new hvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.yxwxw swizzling.
        /// </summary>
        public hvec5 yxwxw => new hvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.grara swizzling (equivalent to hvec4.yxwxw).
        /// </summary>
        public hvec5 grara => new hvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.yxwy swizzling.
        /// </summary>
        public hvec4 yxwy => new hvec4(y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.grag swizzling (equivalent to hvec4.yxwy).
        /// </summary>
        public hvec4 grag => new hvec4(y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.yxwyx swizzling.
        /// </summary>
        public hvec5 yxwyx => new hvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.gragr swizzling (equivalent to hvec4.yxwyx).
        /// </summary>
        public hvec5 gragr => new hvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.yxwyy swizzling.
        /// </summary>
        public hvec5 yxwyy => new hvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.gragg swizzling (equivalent to hvec4.yxwyy).
        /// </summary>
        public hvec5 gragg => new hvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.yxwyz swizzling.
        /// </summary>
        public hvec5 yxwyz => new hvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.gragb swizzling (equivalent to hvec4.yxwyz).
        /// </summary>
        public hvec5 gragb => new hvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.yxwyw swizzling.
        /// </summary>
        public hvec5 yxwyw => new hvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.graga swizzling (equivalent to hvec4.yxwyw).
        /// </summary>
        public hvec5 graga => new hvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.yxwz swizzling.
        /// </summary>
        public hvec4 yxwz => new hvec4(y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.grab swizzling (equivalent to hvec4.yxwz).
        /// </summary>
        public hvec4 grab => new hvec4(y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.yxwzx swizzling.
        /// </summary>
        public hvec5 yxwzx => new hvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.grabr swizzling (equivalent to hvec4.yxwzx).
        /// </summary>
        public hvec5 grabr => new hvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.yxwzy swizzling.
        /// </summary>
        public hvec5 yxwzy => new hvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.grabg swizzling (equivalent to hvec4.yxwzy).
        /// </summary>
        public hvec5 grabg => new hvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.yxwzz swizzling.
        /// </summary>
        public hvec5 yxwzz => new hvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.grabb swizzling (equivalent to hvec4.yxwzz).
        /// </summary>
        public hvec5 grabb => new hvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.yxwzw swizzling.
        /// </summary>
        public hvec5 yxwzw => new hvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.graba swizzling (equivalent to hvec4.yxwzw).
        /// </summary>
        public hvec5 graba => new hvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.yxww swizzling.
        /// </summary>
        public hvec4 yxww => new hvec4(y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.graa swizzling (equivalent to hvec4.yxww).
        /// </summary>
        public hvec4 graa => new hvec4(y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.yxwwx swizzling.
        /// </summary>
        public hvec5 yxwwx => new hvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.graar swizzling (equivalent to hvec4.yxwwx).
        /// </summary>
        public hvec5 graar => new hvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.yxwwy swizzling.
        /// </summary>
        public hvec5 yxwwy => new hvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.graag swizzling (equivalent to hvec4.yxwwy).
        /// </summary>
        public hvec5 graag => new hvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.yxwwz swizzling.
        /// </summary>
        public hvec5 yxwwz => new hvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.graab swizzling (equivalent to hvec4.yxwwz).
        /// </summary>
        public hvec5 graab => new hvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.yxwww swizzling.
        /// </summary>
        public hvec5 yxwww => new hvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.graaa swizzling (equivalent to hvec4.yxwww).
        /// </summary>
        public hvec5 graaa => new hvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.yy swizzling.
        /// </summary>
        public hvec2 yy => new hvec2(y, y);
        
        /// <summary>
        /// Returns hvec4.gg swizzling (equivalent to hvec4.yy).
        /// </summary>
        public hvec2 gg => new hvec2(y, y);
        
        /// <summary>
        /// Returns hvec4.yyx swizzling.
        /// </summary>
        public hvec3 yyx => new hvec3(y, y, x);
        
        /// <summary>
        /// Returns hvec4.ggr swizzling (equivalent to hvec4.yyx).
        /// </summary>
        public hvec3 ggr => new hvec3(y, y, x);
        
        /// <summary>
        /// Returns hvec4.yyxx swizzling.
        /// </summary>
        public hvec4 yyxx => new hvec4(y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.ggrr swizzling (equivalent to hvec4.yyxx).
        /// </summary>
        public hvec4 ggrr => new hvec4(y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.yyxxx swizzling.
        /// </summary>
        public hvec5 yyxxx => new hvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.ggrrr swizzling (equivalent to hvec4.yyxxx).
        /// </summary>
        public hvec5 ggrrr => new hvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.yyxxy swizzling.
        /// </summary>
        public hvec5 yyxxy => new hvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.ggrrg swizzling (equivalent to hvec4.yyxxy).
        /// </summary>
        public hvec5 ggrrg => new hvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.yyxxz swizzling.
        /// </summary>
        public hvec5 yyxxz => new hvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.ggrrb swizzling (equivalent to hvec4.yyxxz).
        /// </summary>
        public hvec5 ggrrb => new hvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.yyxxw swizzling.
        /// </summary>
        public hvec5 yyxxw => new hvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.ggrra swizzling (equivalent to hvec4.yyxxw).
        /// </summary>
        public hvec5 ggrra => new hvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.yyxy swizzling.
        /// </summary>
        public hvec4 yyxy => new hvec4(y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.ggrg swizzling (equivalent to hvec4.yyxy).
        /// </summary>
        public hvec4 ggrg => new hvec4(y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.yyxyx swizzling.
        /// </summary>
        public hvec5 yyxyx => new hvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.ggrgr swizzling (equivalent to hvec4.yyxyx).
        /// </summary>
        public hvec5 ggrgr => new hvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.yyxyy swizzling.
        /// </summary>
        public hvec5 yyxyy => new hvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.ggrgg swizzling (equivalent to hvec4.yyxyy).
        /// </summary>
        public hvec5 ggrgg => new hvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.yyxyz swizzling.
        /// </summary>
        public hvec5 yyxyz => new hvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.ggrgb swizzling (equivalent to hvec4.yyxyz).
        /// </summary>
        public hvec5 ggrgb => new hvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.yyxyw swizzling.
        /// </summary>
        public hvec5 yyxyw => new hvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.ggrga swizzling (equivalent to hvec4.yyxyw).
        /// </summary>
        public hvec5 ggrga => new hvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.yyxz swizzling.
        /// </summary>
        public hvec4 yyxz => new hvec4(y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.ggrb swizzling (equivalent to hvec4.yyxz).
        /// </summary>
        public hvec4 ggrb => new hvec4(y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.yyxzx swizzling.
        /// </summary>
        public hvec5 yyxzx => new hvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.ggrbr swizzling (equivalent to hvec4.yyxzx).
        /// </summary>
        public hvec5 ggrbr => new hvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.yyxzy swizzling.
        /// </summary>
        public hvec5 yyxzy => new hvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.ggrbg swizzling (equivalent to hvec4.yyxzy).
        /// </summary>
        public hvec5 ggrbg => new hvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.yyxzz swizzling.
        /// </summary>
        public hvec5 yyxzz => new hvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.ggrbb swizzling (equivalent to hvec4.yyxzz).
        /// </summary>
        public hvec5 ggrbb => new hvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.yyxzw swizzling.
        /// </summary>
        public hvec5 yyxzw => new hvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.ggrba swizzling (equivalent to hvec4.yyxzw).
        /// </summary>
        public hvec5 ggrba => new hvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.yyxw swizzling.
        /// </summary>
        public hvec4 yyxw => new hvec4(y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.ggra swizzling (equivalent to hvec4.yyxw).
        /// </summary>
        public hvec4 ggra => new hvec4(y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.yyxwx swizzling.
        /// </summary>
        public hvec5 yyxwx => new hvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.ggrar swizzling (equivalent to hvec4.yyxwx).
        /// </summary>
        public hvec5 ggrar => new hvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.yyxwy swizzling.
        /// </summary>
        public hvec5 yyxwy => new hvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.ggrag swizzling (equivalent to hvec4.yyxwy).
        /// </summary>
        public hvec5 ggrag => new hvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.yyxwz swizzling.
        /// </summary>
        public hvec5 yyxwz => new hvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.ggrab swizzling (equivalent to hvec4.yyxwz).
        /// </summary>
        public hvec5 ggrab => new hvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.yyxww swizzling.
        /// </summary>
        public hvec5 yyxww => new hvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.ggraa swizzling (equivalent to hvec4.yyxww).
        /// </summary>
        public hvec5 ggraa => new hvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.yyy swizzling.
        /// </summary>
        public hvec3 yyy => new hvec3(y, y, y);
        
        /// <summary>
        /// Returns hvec4.ggg swizzling (equivalent to hvec4.yyy).
        /// </summary>
        public hvec3 ggg => new hvec3(y, y, y);
        
        /// <summary>
        /// Returns hvec4.yyyx swizzling.
        /// </summary>
        public hvec4 yyyx => new hvec4(y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.gggr swizzling (equivalent to hvec4.yyyx).
        /// </summary>
        public hvec4 gggr => new hvec4(y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.yyyxx swizzling.
        /// </summary>
        public hvec5 yyyxx => new hvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.gggrr swizzling (equivalent to hvec4.yyyxx).
        /// </summary>
        public hvec5 gggrr => new hvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.yyyxy swizzling.
        /// </summary>
        public hvec5 yyyxy => new hvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.gggrg swizzling (equivalent to hvec4.yyyxy).
        /// </summary>
        public hvec5 gggrg => new hvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.yyyxz swizzling.
        /// </summary>
        public hvec5 yyyxz => new hvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.gggrb swizzling (equivalent to hvec4.yyyxz).
        /// </summary>
        public hvec5 gggrb => new hvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.yyyxw swizzling.
        /// </summary>
        public hvec5 yyyxw => new hvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.gggra swizzling (equivalent to hvec4.yyyxw).
        /// </summary>
        public hvec5 gggra => new hvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.yyyy swizzling.
        /// </summary>
        public hvec4 yyyy => new hvec4(y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.gggg swizzling (equivalent to hvec4.yyyy).
        /// </summary>
        public hvec4 gggg => new hvec4(y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.yyyyx swizzling.
        /// </summary>
        public hvec5 yyyyx => new hvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.ggggr swizzling (equivalent to hvec4.yyyyx).
        /// </summary>
        public hvec5 ggggr => new hvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.yyyyy swizzling.
        /// </summary>
        public hvec5 yyyyy => new hvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.ggggg swizzling (equivalent to hvec4.yyyyy).
        /// </summary>
        public hvec5 ggggg => new hvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.yyyyz swizzling.
        /// </summary>
        public hvec5 yyyyz => new hvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.ggggb swizzling (equivalent to hvec4.yyyyz).
        /// </summary>
        public hvec5 ggggb => new hvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.yyyyw swizzling.
        /// </summary>
        public hvec5 yyyyw => new hvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.gggga swizzling (equivalent to hvec4.yyyyw).
        /// </summary>
        public hvec5 gggga => new hvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.yyyz swizzling.
        /// </summary>
        public hvec4 yyyz => new hvec4(y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.gggb swizzling (equivalent to hvec4.yyyz).
        /// </summary>
        public hvec4 gggb => new hvec4(y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.yyyzx swizzling.
        /// </summary>
        public hvec5 yyyzx => new hvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.gggbr swizzling (equivalent to hvec4.yyyzx).
        /// </summary>
        public hvec5 gggbr => new hvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.yyyzy swizzling.
        /// </summary>
        public hvec5 yyyzy => new hvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.gggbg swizzling (equivalent to hvec4.yyyzy).
        /// </summary>
        public hvec5 gggbg => new hvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.yyyzz swizzling.
        /// </summary>
        public hvec5 yyyzz => new hvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.gggbb swizzling (equivalent to hvec4.yyyzz).
        /// </summary>
        public hvec5 gggbb => new hvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.yyyzw swizzling.
        /// </summary>
        public hvec5 yyyzw => new hvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.gggba swizzling (equivalent to hvec4.yyyzw).
        /// </summary>
        public hvec5 gggba => new hvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.yyyw swizzling.
        /// </summary>
        public hvec4 yyyw => new hvec4(y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.ggga swizzling (equivalent to hvec4.yyyw).
        /// </summary>
        public hvec4 ggga => new hvec4(y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.yyywx swizzling.
        /// </summary>
        public hvec5 yyywx => new hvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.gggar swizzling (equivalent to hvec4.yyywx).
        /// </summary>
        public hvec5 gggar => new hvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.yyywy swizzling.
        /// </summary>
        public hvec5 yyywy => new hvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.gggag swizzling (equivalent to hvec4.yyywy).
        /// </summary>
        public hvec5 gggag => new hvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.yyywz swizzling.
        /// </summary>
        public hvec5 yyywz => new hvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.gggab swizzling (equivalent to hvec4.yyywz).
        /// </summary>
        public hvec5 gggab => new hvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.yyyww swizzling.
        /// </summary>
        public hvec5 yyyww => new hvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.gggaa swizzling (equivalent to hvec4.yyyww).
        /// </summary>
        public hvec5 gggaa => new hvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.yyz swizzling.
        /// </summary>
        public hvec3 yyz => new hvec3(y, y, z);
        
        /// <summary>
        /// Returns hvec4.ggb swizzling (equivalent to hvec4.yyz).
        /// </summary>
        public hvec3 ggb => new hvec3(y, y, z);
        
        /// <summary>
        /// Returns hvec4.yyzx swizzling.
        /// </summary>
        public hvec4 yyzx => new hvec4(y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.ggbr swizzling (equivalent to hvec4.yyzx).
        /// </summary>
        public hvec4 ggbr => new hvec4(y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.yyzxx swizzling.
        /// </summary>
        public hvec5 yyzxx => new hvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.ggbrr swizzling (equivalent to hvec4.yyzxx).
        /// </summary>
        public hvec5 ggbrr => new hvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.yyzxy swizzling.
        /// </summary>
        public hvec5 yyzxy => new hvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.ggbrg swizzling (equivalent to hvec4.yyzxy).
        /// </summary>
        public hvec5 ggbrg => new hvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.yyzxz swizzling.
        /// </summary>
        public hvec5 yyzxz => new hvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.ggbrb swizzling (equivalent to hvec4.yyzxz).
        /// </summary>
        public hvec5 ggbrb => new hvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.yyzxw swizzling.
        /// </summary>
        public hvec5 yyzxw => new hvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.ggbra swizzling (equivalent to hvec4.yyzxw).
        /// </summary>
        public hvec5 ggbra => new hvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.yyzy swizzling.
        /// </summary>
        public hvec4 yyzy => new hvec4(y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.ggbg swizzling (equivalent to hvec4.yyzy).
        /// </summary>
        public hvec4 ggbg => new hvec4(y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.yyzyx swizzling.
        /// </summary>
        public hvec5 yyzyx => new hvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.ggbgr swizzling (equivalent to hvec4.yyzyx).
        /// </summary>
        public hvec5 ggbgr => new hvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.yyzyy swizzling.
        /// </summary>
        public hvec5 yyzyy => new hvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.ggbgg swizzling (equivalent to hvec4.yyzyy).
        /// </summary>
        public hvec5 ggbgg => new hvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.yyzyz swizzling.
        /// </summary>
        public hvec5 yyzyz => new hvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.ggbgb swizzling (equivalent to hvec4.yyzyz).
        /// </summary>
        public hvec5 ggbgb => new hvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.yyzyw swizzling.
        /// </summary>
        public hvec5 yyzyw => new hvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.ggbga swizzling (equivalent to hvec4.yyzyw).
        /// </summary>
        public hvec5 ggbga => new hvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.yyzz swizzling.
        /// </summary>
        public hvec4 yyzz => new hvec4(y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.ggbb swizzling (equivalent to hvec4.yyzz).
        /// </summary>
        public hvec4 ggbb => new hvec4(y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.yyzzx swizzling.
        /// </summary>
        public hvec5 yyzzx => new hvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.ggbbr swizzling (equivalent to hvec4.yyzzx).
        /// </summary>
        public hvec5 ggbbr => new hvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.yyzzy swizzling.
        /// </summary>
        public hvec5 yyzzy => new hvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.ggbbg swizzling (equivalent to hvec4.yyzzy).
        /// </summary>
        public hvec5 ggbbg => new hvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.yyzzz swizzling.
        /// </summary>
        public hvec5 yyzzz => new hvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.ggbbb swizzling (equivalent to hvec4.yyzzz).
        /// </summary>
        public hvec5 ggbbb => new hvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.yyzzw swizzling.
        /// </summary>
        public hvec5 yyzzw => new hvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.ggbba swizzling (equivalent to hvec4.yyzzw).
        /// </summary>
        public hvec5 ggbba => new hvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.yyzw swizzling.
        /// </summary>
        public hvec4 yyzw => new hvec4(y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.ggba swizzling (equivalent to hvec4.yyzw).
        /// </summary>
        public hvec4 ggba => new hvec4(y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.yyzwx swizzling.
        /// </summary>
        public hvec5 yyzwx => new hvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.ggbar swizzling (equivalent to hvec4.yyzwx).
        /// </summary>
        public hvec5 ggbar => new hvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.yyzwy swizzling.
        /// </summary>
        public hvec5 yyzwy => new hvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.ggbag swizzling (equivalent to hvec4.yyzwy).
        /// </summary>
        public hvec5 ggbag => new hvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.yyzwz swizzling.
        /// </summary>
        public hvec5 yyzwz => new hvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.ggbab swizzling (equivalent to hvec4.yyzwz).
        /// </summary>
        public hvec5 ggbab => new hvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.yyzww swizzling.
        /// </summary>
        public hvec5 yyzww => new hvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.ggbaa swizzling (equivalent to hvec4.yyzww).
        /// </summary>
        public hvec5 ggbaa => new hvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.yyw swizzling.
        /// </summary>
        public hvec3 yyw => new hvec3(y, y, w);
        
        /// <summary>
        /// Returns hvec4.gga swizzling (equivalent to hvec4.yyw).
        /// </summary>
        public hvec3 gga => new hvec3(y, y, w);
        
        /// <summary>
        /// Returns hvec4.yywx swizzling.
        /// </summary>
        public hvec4 yywx => new hvec4(y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.ggar swizzling (equivalent to hvec4.yywx).
        /// </summary>
        public hvec4 ggar => new hvec4(y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.yywxx swizzling.
        /// </summary>
        public hvec5 yywxx => new hvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.ggarr swizzling (equivalent to hvec4.yywxx).
        /// </summary>
        public hvec5 ggarr => new hvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.yywxy swizzling.
        /// </summary>
        public hvec5 yywxy => new hvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.ggarg swizzling (equivalent to hvec4.yywxy).
        /// </summary>
        public hvec5 ggarg => new hvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.yywxz swizzling.
        /// </summary>
        public hvec5 yywxz => new hvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.ggarb swizzling (equivalent to hvec4.yywxz).
        /// </summary>
        public hvec5 ggarb => new hvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.yywxw swizzling.
        /// </summary>
        public hvec5 yywxw => new hvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.ggara swizzling (equivalent to hvec4.yywxw).
        /// </summary>
        public hvec5 ggara => new hvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.yywy swizzling.
        /// </summary>
        public hvec4 yywy => new hvec4(y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.ggag swizzling (equivalent to hvec4.yywy).
        /// </summary>
        public hvec4 ggag => new hvec4(y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.yywyx swizzling.
        /// </summary>
        public hvec5 yywyx => new hvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.ggagr swizzling (equivalent to hvec4.yywyx).
        /// </summary>
        public hvec5 ggagr => new hvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.yywyy swizzling.
        /// </summary>
        public hvec5 yywyy => new hvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.ggagg swizzling (equivalent to hvec4.yywyy).
        /// </summary>
        public hvec5 ggagg => new hvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.yywyz swizzling.
        /// </summary>
        public hvec5 yywyz => new hvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.ggagb swizzling (equivalent to hvec4.yywyz).
        /// </summary>
        public hvec5 ggagb => new hvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.yywyw swizzling.
        /// </summary>
        public hvec5 yywyw => new hvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.ggaga swizzling (equivalent to hvec4.yywyw).
        /// </summary>
        public hvec5 ggaga => new hvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.yywz swizzling.
        /// </summary>
        public hvec4 yywz => new hvec4(y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.ggab swizzling (equivalent to hvec4.yywz).
        /// </summary>
        public hvec4 ggab => new hvec4(y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.yywzx swizzling.
        /// </summary>
        public hvec5 yywzx => new hvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.ggabr swizzling (equivalent to hvec4.yywzx).
        /// </summary>
        public hvec5 ggabr => new hvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.yywzy swizzling.
        /// </summary>
        public hvec5 yywzy => new hvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.ggabg swizzling (equivalent to hvec4.yywzy).
        /// </summary>
        public hvec5 ggabg => new hvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.yywzz swizzling.
        /// </summary>
        public hvec5 yywzz => new hvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.ggabb swizzling (equivalent to hvec4.yywzz).
        /// </summary>
        public hvec5 ggabb => new hvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.yywzw swizzling.
        /// </summary>
        public hvec5 yywzw => new hvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.ggaba swizzling (equivalent to hvec4.yywzw).
        /// </summary>
        public hvec5 ggaba => new hvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.yyww swizzling.
        /// </summary>
        public hvec4 yyww => new hvec4(y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.ggaa swizzling (equivalent to hvec4.yyww).
        /// </summary>
        public hvec4 ggaa => new hvec4(y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.yywwx swizzling.
        /// </summary>
        public hvec5 yywwx => new hvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.ggaar swizzling (equivalent to hvec4.yywwx).
        /// </summary>
        public hvec5 ggaar => new hvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.yywwy swizzling.
        /// </summary>
        public hvec5 yywwy => new hvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.ggaag swizzling (equivalent to hvec4.yywwy).
        /// </summary>
        public hvec5 ggaag => new hvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.yywwz swizzling.
        /// </summary>
        public hvec5 yywwz => new hvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.ggaab swizzling (equivalent to hvec4.yywwz).
        /// </summary>
        public hvec5 ggaab => new hvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.yywww swizzling.
        /// </summary>
        public hvec5 yywww => new hvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.ggaaa swizzling (equivalent to hvec4.yywww).
        /// </summary>
        public hvec5 ggaaa => new hvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.yz swizzling.
        /// </summary>
        public hvec2 yz => new hvec2(y, z);
        
        /// <summary>
        /// Returns hvec4.gb swizzling (equivalent to hvec4.yz).
        /// </summary>
        public hvec2 gb => new hvec2(y, z);
        
        /// <summary>
        /// Returns hvec4.yzx swizzling.
        /// </summary>
        public hvec3 yzx => new hvec3(y, z, x);
        
        /// <summary>
        /// Returns hvec4.gbr swizzling (equivalent to hvec4.yzx).
        /// </summary>
        public hvec3 gbr => new hvec3(y, z, x);
        
        /// <summary>
        /// Returns hvec4.yzxx swizzling.
        /// </summary>
        public hvec4 yzxx => new hvec4(y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.gbrr swizzling (equivalent to hvec4.yzxx).
        /// </summary>
        public hvec4 gbrr => new hvec4(y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.yzxxx swizzling.
        /// </summary>
        public hvec5 yzxxx => new hvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.gbrrr swizzling (equivalent to hvec4.yzxxx).
        /// </summary>
        public hvec5 gbrrr => new hvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.yzxxy swizzling.
        /// </summary>
        public hvec5 yzxxy => new hvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.gbrrg swizzling (equivalent to hvec4.yzxxy).
        /// </summary>
        public hvec5 gbrrg => new hvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.yzxxz swizzling.
        /// </summary>
        public hvec5 yzxxz => new hvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.gbrrb swizzling (equivalent to hvec4.yzxxz).
        /// </summary>
        public hvec5 gbrrb => new hvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.yzxxw swizzling.
        /// </summary>
        public hvec5 yzxxw => new hvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.gbrra swizzling (equivalent to hvec4.yzxxw).
        /// </summary>
        public hvec5 gbrra => new hvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.yzxy swizzling.
        /// </summary>
        public hvec4 yzxy => new hvec4(y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.gbrg swizzling (equivalent to hvec4.yzxy).
        /// </summary>
        public hvec4 gbrg => new hvec4(y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.yzxyx swizzling.
        /// </summary>
        public hvec5 yzxyx => new hvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.gbrgr swizzling (equivalent to hvec4.yzxyx).
        /// </summary>
        public hvec5 gbrgr => new hvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.yzxyy swizzling.
        /// </summary>
        public hvec5 yzxyy => new hvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.gbrgg swizzling (equivalent to hvec4.yzxyy).
        /// </summary>
        public hvec5 gbrgg => new hvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.yzxyz swizzling.
        /// </summary>
        public hvec5 yzxyz => new hvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.gbrgb swizzling (equivalent to hvec4.yzxyz).
        /// </summary>
        public hvec5 gbrgb => new hvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.yzxyw swizzling.
        /// </summary>
        public hvec5 yzxyw => new hvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.gbrga swizzling (equivalent to hvec4.yzxyw).
        /// </summary>
        public hvec5 gbrga => new hvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.yzxz swizzling.
        /// </summary>
        public hvec4 yzxz => new hvec4(y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.gbrb swizzling (equivalent to hvec4.yzxz).
        /// </summary>
        public hvec4 gbrb => new hvec4(y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.yzxzx swizzling.
        /// </summary>
        public hvec5 yzxzx => new hvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.gbrbr swizzling (equivalent to hvec4.yzxzx).
        /// </summary>
        public hvec5 gbrbr => new hvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.yzxzy swizzling.
        /// </summary>
        public hvec5 yzxzy => new hvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.gbrbg swizzling (equivalent to hvec4.yzxzy).
        /// </summary>
        public hvec5 gbrbg => new hvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.yzxzz swizzling.
        /// </summary>
        public hvec5 yzxzz => new hvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.gbrbb swizzling (equivalent to hvec4.yzxzz).
        /// </summary>
        public hvec5 gbrbb => new hvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.yzxzw swizzling.
        /// </summary>
        public hvec5 yzxzw => new hvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.gbrba swizzling (equivalent to hvec4.yzxzw).
        /// </summary>
        public hvec5 gbrba => new hvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.yzxw swizzling.
        /// </summary>
        public hvec4 yzxw => new hvec4(y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.gbra swizzling (equivalent to hvec4.yzxw).
        /// </summary>
        public hvec4 gbra => new hvec4(y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.yzxwx swizzling.
        /// </summary>
        public hvec5 yzxwx => new hvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.gbrar swizzling (equivalent to hvec4.yzxwx).
        /// </summary>
        public hvec5 gbrar => new hvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.yzxwy swizzling.
        /// </summary>
        public hvec5 yzxwy => new hvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.gbrag swizzling (equivalent to hvec4.yzxwy).
        /// </summary>
        public hvec5 gbrag => new hvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.yzxwz swizzling.
        /// </summary>
        public hvec5 yzxwz => new hvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.gbrab swizzling (equivalent to hvec4.yzxwz).
        /// </summary>
        public hvec5 gbrab => new hvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.yzxww swizzling.
        /// </summary>
        public hvec5 yzxww => new hvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.gbraa swizzling (equivalent to hvec4.yzxww).
        /// </summary>
        public hvec5 gbraa => new hvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.yzy swizzling.
        /// </summary>
        public hvec3 yzy => new hvec3(y, z, y);
        
        /// <summary>
        /// Returns hvec4.gbg swizzling (equivalent to hvec4.yzy).
        /// </summary>
        public hvec3 gbg => new hvec3(y, z, y);
        
        /// <summary>
        /// Returns hvec4.yzyx swizzling.
        /// </summary>
        public hvec4 yzyx => new hvec4(y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.gbgr swizzling (equivalent to hvec4.yzyx).
        /// </summary>
        public hvec4 gbgr => new hvec4(y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.yzyxx swizzling.
        /// </summary>
        public hvec5 yzyxx => new hvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.gbgrr swizzling (equivalent to hvec4.yzyxx).
        /// </summary>
        public hvec5 gbgrr => new hvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.yzyxy swizzling.
        /// </summary>
        public hvec5 yzyxy => new hvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.gbgrg swizzling (equivalent to hvec4.yzyxy).
        /// </summary>
        public hvec5 gbgrg => new hvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.yzyxz swizzling.
        /// </summary>
        public hvec5 yzyxz => new hvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.gbgrb swizzling (equivalent to hvec4.yzyxz).
        /// </summary>
        public hvec5 gbgrb => new hvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.yzyxw swizzling.
        /// </summary>
        public hvec5 yzyxw => new hvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.gbgra swizzling (equivalent to hvec4.yzyxw).
        /// </summary>
        public hvec5 gbgra => new hvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.yzyy swizzling.
        /// </summary>
        public hvec4 yzyy => new hvec4(y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.gbgg swizzling (equivalent to hvec4.yzyy).
        /// </summary>
        public hvec4 gbgg => new hvec4(y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.yzyyx swizzling.
        /// </summary>
        public hvec5 yzyyx => new hvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.gbggr swizzling (equivalent to hvec4.yzyyx).
        /// </summary>
        public hvec5 gbggr => new hvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.yzyyy swizzling.
        /// </summary>
        public hvec5 yzyyy => new hvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.gbggg swizzling (equivalent to hvec4.yzyyy).
        /// </summary>
        public hvec5 gbggg => new hvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.yzyyz swizzling.
        /// </summary>
        public hvec5 yzyyz => new hvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.gbggb swizzling (equivalent to hvec4.yzyyz).
        /// </summary>
        public hvec5 gbggb => new hvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.yzyyw swizzling.
        /// </summary>
        public hvec5 yzyyw => new hvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.gbgga swizzling (equivalent to hvec4.yzyyw).
        /// </summary>
        public hvec5 gbgga => new hvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.yzyz swizzling.
        /// </summary>
        public hvec4 yzyz => new hvec4(y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.gbgb swizzling (equivalent to hvec4.yzyz).
        /// </summary>
        public hvec4 gbgb => new hvec4(y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.yzyzx swizzling.
        /// </summary>
        public hvec5 yzyzx => new hvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.gbgbr swizzling (equivalent to hvec4.yzyzx).
        /// </summary>
        public hvec5 gbgbr => new hvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.yzyzy swizzling.
        /// </summary>
        public hvec5 yzyzy => new hvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.gbgbg swizzling (equivalent to hvec4.yzyzy).
        /// </summary>
        public hvec5 gbgbg => new hvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.yzyzz swizzling.
        /// </summary>
        public hvec5 yzyzz => new hvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.gbgbb swizzling (equivalent to hvec4.yzyzz).
        /// </summary>
        public hvec5 gbgbb => new hvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.yzyzw swizzling.
        /// </summary>
        public hvec5 yzyzw => new hvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.gbgba swizzling (equivalent to hvec4.yzyzw).
        /// </summary>
        public hvec5 gbgba => new hvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.yzyw swizzling.
        /// </summary>
        public hvec4 yzyw => new hvec4(y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.gbga swizzling (equivalent to hvec4.yzyw).
        /// </summary>
        public hvec4 gbga => new hvec4(y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.yzywx swizzling.
        /// </summary>
        public hvec5 yzywx => new hvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.gbgar swizzling (equivalent to hvec4.yzywx).
        /// </summary>
        public hvec5 gbgar => new hvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.yzywy swizzling.
        /// </summary>
        public hvec5 yzywy => new hvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.gbgag swizzling (equivalent to hvec4.yzywy).
        /// </summary>
        public hvec5 gbgag => new hvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.yzywz swizzling.
        /// </summary>
        public hvec5 yzywz => new hvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.gbgab swizzling (equivalent to hvec4.yzywz).
        /// </summary>
        public hvec5 gbgab => new hvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.yzyww swizzling.
        /// </summary>
        public hvec5 yzyww => new hvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.gbgaa swizzling (equivalent to hvec4.yzyww).
        /// </summary>
        public hvec5 gbgaa => new hvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.yzz swizzling.
        /// </summary>
        public hvec3 yzz => new hvec3(y, z, z);
        
        /// <summary>
        /// Returns hvec4.gbb swizzling (equivalent to hvec4.yzz).
        /// </summary>
        public hvec3 gbb => new hvec3(y, z, z);
        
        /// <summary>
        /// Returns hvec4.yzzx swizzling.
        /// </summary>
        public hvec4 yzzx => new hvec4(y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.gbbr swizzling (equivalent to hvec4.yzzx).
        /// </summary>
        public hvec4 gbbr => new hvec4(y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.yzzxx swizzling.
        /// </summary>
        public hvec5 yzzxx => new hvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.gbbrr swizzling (equivalent to hvec4.yzzxx).
        /// </summary>
        public hvec5 gbbrr => new hvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.yzzxy swizzling.
        /// </summary>
        public hvec5 yzzxy => new hvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.gbbrg swizzling (equivalent to hvec4.yzzxy).
        /// </summary>
        public hvec5 gbbrg => new hvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.yzzxz swizzling.
        /// </summary>
        public hvec5 yzzxz => new hvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.gbbrb swizzling (equivalent to hvec4.yzzxz).
        /// </summary>
        public hvec5 gbbrb => new hvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.yzzxw swizzling.
        /// </summary>
        public hvec5 yzzxw => new hvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.gbbra swizzling (equivalent to hvec4.yzzxw).
        /// </summary>
        public hvec5 gbbra => new hvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.yzzy swizzling.
        /// </summary>
        public hvec4 yzzy => new hvec4(y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.gbbg swizzling (equivalent to hvec4.yzzy).
        /// </summary>
        public hvec4 gbbg => new hvec4(y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.yzzyx swizzling.
        /// </summary>
        public hvec5 yzzyx => new hvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.gbbgr swizzling (equivalent to hvec4.yzzyx).
        /// </summary>
        public hvec5 gbbgr => new hvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.yzzyy swizzling.
        /// </summary>
        public hvec5 yzzyy => new hvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.gbbgg swizzling (equivalent to hvec4.yzzyy).
        /// </summary>
        public hvec5 gbbgg => new hvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.yzzyz swizzling.
        /// </summary>
        public hvec5 yzzyz => new hvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.gbbgb swizzling (equivalent to hvec4.yzzyz).
        /// </summary>
        public hvec5 gbbgb => new hvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.yzzyw swizzling.
        /// </summary>
        public hvec5 yzzyw => new hvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.gbbga swizzling (equivalent to hvec4.yzzyw).
        /// </summary>
        public hvec5 gbbga => new hvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.yzzz swizzling.
        /// </summary>
        public hvec4 yzzz => new hvec4(y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.gbbb swizzling (equivalent to hvec4.yzzz).
        /// </summary>
        public hvec4 gbbb => new hvec4(y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.yzzzx swizzling.
        /// </summary>
        public hvec5 yzzzx => new hvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.gbbbr swizzling (equivalent to hvec4.yzzzx).
        /// </summary>
        public hvec5 gbbbr => new hvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.yzzzy swizzling.
        /// </summary>
        public hvec5 yzzzy => new hvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.gbbbg swizzling (equivalent to hvec4.yzzzy).
        /// </summary>
        public hvec5 gbbbg => new hvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.yzzzz swizzling.
        /// </summary>
        public hvec5 yzzzz => new hvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.gbbbb swizzling (equivalent to hvec4.yzzzz).
        /// </summary>
        public hvec5 gbbbb => new hvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.yzzzw swizzling.
        /// </summary>
        public hvec5 yzzzw => new hvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.gbbba swizzling (equivalent to hvec4.yzzzw).
        /// </summary>
        public hvec5 gbbba => new hvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.yzzw swizzling.
        /// </summary>
        public hvec4 yzzw => new hvec4(y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.gbba swizzling (equivalent to hvec4.yzzw).
        /// </summary>
        public hvec4 gbba => new hvec4(y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.yzzwx swizzling.
        /// </summary>
        public hvec5 yzzwx => new hvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.gbbar swizzling (equivalent to hvec4.yzzwx).
        /// </summary>
        public hvec5 gbbar => new hvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.yzzwy swizzling.
        /// </summary>
        public hvec5 yzzwy => new hvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.gbbag swizzling (equivalent to hvec4.yzzwy).
        /// </summary>
        public hvec5 gbbag => new hvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.yzzwz swizzling.
        /// </summary>
        public hvec5 yzzwz => new hvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.gbbab swizzling (equivalent to hvec4.yzzwz).
        /// </summary>
        public hvec5 gbbab => new hvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.yzzww swizzling.
        /// </summary>
        public hvec5 yzzww => new hvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.gbbaa swizzling (equivalent to hvec4.yzzww).
        /// </summary>
        public hvec5 gbbaa => new hvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.yzw swizzling.
        /// </summary>
        public hvec3 yzw => new hvec3(y, z, w);
        
        /// <summary>
        /// Returns hvec4.gba swizzling (equivalent to hvec4.yzw).
        /// </summary>
        public hvec3 gba => new hvec3(y, z, w);
        
        /// <summary>
        /// Returns hvec4.yzwx swizzling.
        /// </summary>
        public hvec4 yzwx => new hvec4(y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.gbar swizzling (equivalent to hvec4.yzwx).
        /// </summary>
        public hvec4 gbar => new hvec4(y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.yzwxx swizzling.
        /// </summary>
        public hvec5 yzwxx => new hvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.gbarr swizzling (equivalent to hvec4.yzwxx).
        /// </summary>
        public hvec5 gbarr => new hvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.yzwxy swizzling.
        /// </summary>
        public hvec5 yzwxy => new hvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.gbarg swizzling (equivalent to hvec4.yzwxy).
        /// </summary>
        public hvec5 gbarg => new hvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.yzwxz swizzling.
        /// </summary>
        public hvec5 yzwxz => new hvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.gbarb swizzling (equivalent to hvec4.yzwxz).
        /// </summary>
        public hvec5 gbarb => new hvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.yzwxw swizzling.
        /// </summary>
        public hvec5 yzwxw => new hvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.gbara swizzling (equivalent to hvec4.yzwxw).
        /// </summary>
        public hvec5 gbara => new hvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.yzwy swizzling.
        /// </summary>
        public hvec4 yzwy => new hvec4(y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.gbag swizzling (equivalent to hvec4.yzwy).
        /// </summary>
        public hvec4 gbag => new hvec4(y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.yzwyx swizzling.
        /// </summary>
        public hvec5 yzwyx => new hvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.gbagr swizzling (equivalent to hvec4.yzwyx).
        /// </summary>
        public hvec5 gbagr => new hvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.yzwyy swizzling.
        /// </summary>
        public hvec5 yzwyy => new hvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.gbagg swizzling (equivalent to hvec4.yzwyy).
        /// </summary>
        public hvec5 gbagg => new hvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.yzwyz swizzling.
        /// </summary>
        public hvec5 yzwyz => new hvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.gbagb swizzling (equivalent to hvec4.yzwyz).
        /// </summary>
        public hvec5 gbagb => new hvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.yzwyw swizzling.
        /// </summary>
        public hvec5 yzwyw => new hvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.gbaga swizzling (equivalent to hvec4.yzwyw).
        /// </summary>
        public hvec5 gbaga => new hvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.yzwz swizzling.
        /// </summary>
        public hvec4 yzwz => new hvec4(y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.gbab swizzling (equivalent to hvec4.yzwz).
        /// </summary>
        public hvec4 gbab => new hvec4(y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.yzwzx swizzling.
        /// </summary>
        public hvec5 yzwzx => new hvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.gbabr swizzling (equivalent to hvec4.yzwzx).
        /// </summary>
        public hvec5 gbabr => new hvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.yzwzy swizzling.
        /// </summary>
        public hvec5 yzwzy => new hvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.gbabg swizzling (equivalent to hvec4.yzwzy).
        /// </summary>
        public hvec5 gbabg => new hvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.yzwzz swizzling.
        /// </summary>
        public hvec5 yzwzz => new hvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.gbabb swizzling (equivalent to hvec4.yzwzz).
        /// </summary>
        public hvec5 gbabb => new hvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.yzwzw swizzling.
        /// </summary>
        public hvec5 yzwzw => new hvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.gbaba swizzling (equivalent to hvec4.yzwzw).
        /// </summary>
        public hvec5 gbaba => new hvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.yzww swizzling.
        /// </summary>
        public hvec4 yzww => new hvec4(y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.gbaa swizzling (equivalent to hvec4.yzww).
        /// </summary>
        public hvec4 gbaa => new hvec4(y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.yzwwx swizzling.
        /// </summary>
        public hvec5 yzwwx => new hvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.gbaar swizzling (equivalent to hvec4.yzwwx).
        /// </summary>
        public hvec5 gbaar => new hvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.yzwwy swizzling.
        /// </summary>
        public hvec5 yzwwy => new hvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.gbaag swizzling (equivalent to hvec4.yzwwy).
        /// </summary>
        public hvec5 gbaag => new hvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.yzwwz swizzling.
        /// </summary>
        public hvec5 yzwwz => new hvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.gbaab swizzling (equivalent to hvec4.yzwwz).
        /// </summary>
        public hvec5 gbaab => new hvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.yzwww swizzling.
        /// </summary>
        public hvec5 yzwww => new hvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.gbaaa swizzling (equivalent to hvec4.yzwww).
        /// </summary>
        public hvec5 gbaaa => new hvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.yw swizzling.
        /// </summary>
        public hvec2 yw => new hvec2(y, w);
        
        /// <summary>
        /// Returns hvec4.ga swizzling (equivalent to hvec4.yw).
        /// </summary>
        public hvec2 ga => new hvec2(y, w);
        
        /// <summary>
        /// Returns hvec4.ywx swizzling.
        /// </summary>
        public hvec3 ywx => new hvec3(y, w, x);
        
        /// <summary>
        /// Returns hvec4.gar swizzling (equivalent to hvec4.ywx).
        /// </summary>
        public hvec3 gar => new hvec3(y, w, x);
        
        /// <summary>
        /// Returns hvec4.ywxx swizzling.
        /// </summary>
        public hvec4 ywxx => new hvec4(y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.garr swizzling (equivalent to hvec4.ywxx).
        /// </summary>
        public hvec4 garr => new hvec4(y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.ywxxx swizzling.
        /// </summary>
        public hvec5 ywxxx => new hvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.garrr swizzling (equivalent to hvec4.ywxxx).
        /// </summary>
        public hvec5 garrr => new hvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.ywxxy swizzling.
        /// </summary>
        public hvec5 ywxxy => new hvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.garrg swizzling (equivalent to hvec4.ywxxy).
        /// </summary>
        public hvec5 garrg => new hvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.ywxxz swizzling.
        /// </summary>
        public hvec5 ywxxz => new hvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.garrb swizzling (equivalent to hvec4.ywxxz).
        /// </summary>
        public hvec5 garrb => new hvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.ywxxw swizzling.
        /// </summary>
        public hvec5 ywxxw => new hvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.garra swizzling (equivalent to hvec4.ywxxw).
        /// </summary>
        public hvec5 garra => new hvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.ywxy swizzling.
        /// </summary>
        public hvec4 ywxy => new hvec4(y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.garg swizzling (equivalent to hvec4.ywxy).
        /// </summary>
        public hvec4 garg => new hvec4(y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.ywxyx swizzling.
        /// </summary>
        public hvec5 ywxyx => new hvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.gargr swizzling (equivalent to hvec4.ywxyx).
        /// </summary>
        public hvec5 gargr => new hvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.ywxyy swizzling.
        /// </summary>
        public hvec5 ywxyy => new hvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.gargg swizzling (equivalent to hvec4.ywxyy).
        /// </summary>
        public hvec5 gargg => new hvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.ywxyz swizzling.
        /// </summary>
        public hvec5 ywxyz => new hvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.gargb swizzling (equivalent to hvec4.ywxyz).
        /// </summary>
        public hvec5 gargb => new hvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.ywxyw swizzling.
        /// </summary>
        public hvec5 ywxyw => new hvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.garga swizzling (equivalent to hvec4.ywxyw).
        /// </summary>
        public hvec5 garga => new hvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.ywxz swizzling.
        /// </summary>
        public hvec4 ywxz => new hvec4(y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.garb swizzling (equivalent to hvec4.ywxz).
        /// </summary>
        public hvec4 garb => new hvec4(y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.ywxzx swizzling.
        /// </summary>
        public hvec5 ywxzx => new hvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.garbr swizzling (equivalent to hvec4.ywxzx).
        /// </summary>
        public hvec5 garbr => new hvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.ywxzy swizzling.
        /// </summary>
        public hvec5 ywxzy => new hvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.garbg swizzling (equivalent to hvec4.ywxzy).
        /// </summary>
        public hvec5 garbg => new hvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.ywxzz swizzling.
        /// </summary>
        public hvec5 ywxzz => new hvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.garbb swizzling (equivalent to hvec4.ywxzz).
        /// </summary>
        public hvec5 garbb => new hvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.ywxzw swizzling.
        /// </summary>
        public hvec5 ywxzw => new hvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.garba swizzling (equivalent to hvec4.ywxzw).
        /// </summary>
        public hvec5 garba => new hvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.ywxw swizzling.
        /// </summary>
        public hvec4 ywxw => new hvec4(y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.gara swizzling (equivalent to hvec4.ywxw).
        /// </summary>
        public hvec4 gara => new hvec4(y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.ywxwx swizzling.
        /// </summary>
        public hvec5 ywxwx => new hvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.garar swizzling (equivalent to hvec4.ywxwx).
        /// </summary>
        public hvec5 garar => new hvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.ywxwy swizzling.
        /// </summary>
        public hvec5 ywxwy => new hvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.garag swizzling (equivalent to hvec4.ywxwy).
        /// </summary>
        public hvec5 garag => new hvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.ywxwz swizzling.
        /// </summary>
        public hvec5 ywxwz => new hvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.garab swizzling (equivalent to hvec4.ywxwz).
        /// </summary>
        public hvec5 garab => new hvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.ywxww swizzling.
        /// </summary>
        public hvec5 ywxww => new hvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.garaa swizzling (equivalent to hvec4.ywxww).
        /// </summary>
        public hvec5 garaa => new hvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.ywy swizzling.
        /// </summary>
        public hvec3 ywy => new hvec3(y, w, y);
        
        /// <summary>
        /// Returns hvec4.gag swizzling (equivalent to hvec4.ywy).
        /// </summary>
        public hvec3 gag => new hvec3(y, w, y);
        
        /// <summary>
        /// Returns hvec4.ywyx swizzling.
        /// </summary>
        public hvec4 ywyx => new hvec4(y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.gagr swizzling (equivalent to hvec4.ywyx).
        /// </summary>
        public hvec4 gagr => new hvec4(y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.ywyxx swizzling.
        /// </summary>
        public hvec5 ywyxx => new hvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.gagrr swizzling (equivalent to hvec4.ywyxx).
        /// </summary>
        public hvec5 gagrr => new hvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.ywyxy swizzling.
        /// </summary>
        public hvec5 ywyxy => new hvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.gagrg swizzling (equivalent to hvec4.ywyxy).
        /// </summary>
        public hvec5 gagrg => new hvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.ywyxz swizzling.
        /// </summary>
        public hvec5 ywyxz => new hvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.gagrb swizzling (equivalent to hvec4.ywyxz).
        /// </summary>
        public hvec5 gagrb => new hvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.ywyxw swizzling.
        /// </summary>
        public hvec5 ywyxw => new hvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.gagra swizzling (equivalent to hvec4.ywyxw).
        /// </summary>
        public hvec5 gagra => new hvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.ywyy swizzling.
        /// </summary>
        public hvec4 ywyy => new hvec4(y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.gagg swizzling (equivalent to hvec4.ywyy).
        /// </summary>
        public hvec4 gagg => new hvec4(y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.ywyyx swizzling.
        /// </summary>
        public hvec5 ywyyx => new hvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.gaggr swizzling (equivalent to hvec4.ywyyx).
        /// </summary>
        public hvec5 gaggr => new hvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.ywyyy swizzling.
        /// </summary>
        public hvec5 ywyyy => new hvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.gaggg swizzling (equivalent to hvec4.ywyyy).
        /// </summary>
        public hvec5 gaggg => new hvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.ywyyz swizzling.
        /// </summary>
        public hvec5 ywyyz => new hvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.gaggb swizzling (equivalent to hvec4.ywyyz).
        /// </summary>
        public hvec5 gaggb => new hvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.ywyyw swizzling.
        /// </summary>
        public hvec5 ywyyw => new hvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.gagga swizzling (equivalent to hvec4.ywyyw).
        /// </summary>
        public hvec5 gagga => new hvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.ywyz swizzling.
        /// </summary>
        public hvec4 ywyz => new hvec4(y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.gagb swizzling (equivalent to hvec4.ywyz).
        /// </summary>
        public hvec4 gagb => new hvec4(y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.ywyzx swizzling.
        /// </summary>
        public hvec5 ywyzx => new hvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.gagbr swizzling (equivalent to hvec4.ywyzx).
        /// </summary>
        public hvec5 gagbr => new hvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.ywyzy swizzling.
        /// </summary>
        public hvec5 ywyzy => new hvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.gagbg swizzling (equivalent to hvec4.ywyzy).
        /// </summary>
        public hvec5 gagbg => new hvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.ywyzz swizzling.
        /// </summary>
        public hvec5 ywyzz => new hvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.gagbb swizzling (equivalent to hvec4.ywyzz).
        /// </summary>
        public hvec5 gagbb => new hvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.ywyzw swizzling.
        /// </summary>
        public hvec5 ywyzw => new hvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.gagba swizzling (equivalent to hvec4.ywyzw).
        /// </summary>
        public hvec5 gagba => new hvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.ywyw swizzling.
        /// </summary>
        public hvec4 ywyw => new hvec4(y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.gaga swizzling (equivalent to hvec4.ywyw).
        /// </summary>
        public hvec4 gaga => new hvec4(y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.ywywx swizzling.
        /// </summary>
        public hvec5 ywywx => new hvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.gagar swizzling (equivalent to hvec4.ywywx).
        /// </summary>
        public hvec5 gagar => new hvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.ywywy swizzling.
        /// </summary>
        public hvec5 ywywy => new hvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.gagag swizzling (equivalent to hvec4.ywywy).
        /// </summary>
        public hvec5 gagag => new hvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.ywywz swizzling.
        /// </summary>
        public hvec5 ywywz => new hvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.gagab swizzling (equivalent to hvec4.ywywz).
        /// </summary>
        public hvec5 gagab => new hvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.ywyww swizzling.
        /// </summary>
        public hvec5 ywyww => new hvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.gagaa swizzling (equivalent to hvec4.ywyww).
        /// </summary>
        public hvec5 gagaa => new hvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.ywz swizzling.
        /// </summary>
        public hvec3 ywz => new hvec3(y, w, z);
        
        /// <summary>
        /// Returns hvec4.gab swizzling (equivalent to hvec4.ywz).
        /// </summary>
        public hvec3 gab => new hvec3(y, w, z);
        
        /// <summary>
        /// Returns hvec4.ywzx swizzling.
        /// </summary>
        public hvec4 ywzx => new hvec4(y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.gabr swizzling (equivalent to hvec4.ywzx).
        /// </summary>
        public hvec4 gabr => new hvec4(y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.ywzxx swizzling.
        /// </summary>
        public hvec5 ywzxx => new hvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.gabrr swizzling (equivalent to hvec4.ywzxx).
        /// </summary>
        public hvec5 gabrr => new hvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.ywzxy swizzling.
        /// </summary>
        public hvec5 ywzxy => new hvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.gabrg swizzling (equivalent to hvec4.ywzxy).
        /// </summary>
        public hvec5 gabrg => new hvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.ywzxz swizzling.
        /// </summary>
        public hvec5 ywzxz => new hvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.gabrb swizzling (equivalent to hvec4.ywzxz).
        /// </summary>
        public hvec5 gabrb => new hvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.ywzxw swizzling.
        /// </summary>
        public hvec5 ywzxw => new hvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.gabra swizzling (equivalent to hvec4.ywzxw).
        /// </summary>
        public hvec5 gabra => new hvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.ywzy swizzling.
        /// </summary>
        public hvec4 ywzy => new hvec4(y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.gabg swizzling (equivalent to hvec4.ywzy).
        /// </summary>
        public hvec4 gabg => new hvec4(y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.ywzyx swizzling.
        /// </summary>
        public hvec5 ywzyx => new hvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.gabgr swizzling (equivalent to hvec4.ywzyx).
        /// </summary>
        public hvec5 gabgr => new hvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.ywzyy swizzling.
        /// </summary>
        public hvec5 ywzyy => new hvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.gabgg swizzling (equivalent to hvec4.ywzyy).
        /// </summary>
        public hvec5 gabgg => new hvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.ywzyz swizzling.
        /// </summary>
        public hvec5 ywzyz => new hvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.gabgb swizzling (equivalent to hvec4.ywzyz).
        /// </summary>
        public hvec5 gabgb => new hvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.ywzyw swizzling.
        /// </summary>
        public hvec5 ywzyw => new hvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.gabga swizzling (equivalent to hvec4.ywzyw).
        /// </summary>
        public hvec5 gabga => new hvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.ywzz swizzling.
        /// </summary>
        public hvec4 ywzz => new hvec4(y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.gabb swizzling (equivalent to hvec4.ywzz).
        /// </summary>
        public hvec4 gabb => new hvec4(y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.ywzzx swizzling.
        /// </summary>
        public hvec5 ywzzx => new hvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.gabbr swizzling (equivalent to hvec4.ywzzx).
        /// </summary>
        public hvec5 gabbr => new hvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.ywzzy swizzling.
        /// </summary>
        public hvec5 ywzzy => new hvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.gabbg swizzling (equivalent to hvec4.ywzzy).
        /// </summary>
        public hvec5 gabbg => new hvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.ywzzz swizzling.
        /// </summary>
        public hvec5 ywzzz => new hvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.gabbb swizzling (equivalent to hvec4.ywzzz).
        /// </summary>
        public hvec5 gabbb => new hvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.ywzzw swizzling.
        /// </summary>
        public hvec5 ywzzw => new hvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.gabba swizzling (equivalent to hvec4.ywzzw).
        /// </summary>
        public hvec5 gabba => new hvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.ywzw swizzling.
        /// </summary>
        public hvec4 ywzw => new hvec4(y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.gaba swizzling (equivalent to hvec4.ywzw).
        /// </summary>
        public hvec4 gaba => new hvec4(y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.ywzwx swizzling.
        /// </summary>
        public hvec5 ywzwx => new hvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.gabar swizzling (equivalent to hvec4.ywzwx).
        /// </summary>
        public hvec5 gabar => new hvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.ywzwy swizzling.
        /// </summary>
        public hvec5 ywzwy => new hvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.gabag swizzling (equivalent to hvec4.ywzwy).
        /// </summary>
        public hvec5 gabag => new hvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.ywzwz swizzling.
        /// </summary>
        public hvec5 ywzwz => new hvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.gabab swizzling (equivalent to hvec4.ywzwz).
        /// </summary>
        public hvec5 gabab => new hvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.ywzww swizzling.
        /// </summary>
        public hvec5 ywzww => new hvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.gabaa swizzling (equivalent to hvec4.ywzww).
        /// </summary>
        public hvec5 gabaa => new hvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.yww swizzling.
        /// </summary>
        public hvec3 yww => new hvec3(y, w, w);
        
        /// <summary>
        /// Returns hvec4.gaa swizzling (equivalent to hvec4.yww).
        /// </summary>
        public hvec3 gaa => new hvec3(y, w, w);
        
        /// <summary>
        /// Returns hvec4.ywwx swizzling.
        /// </summary>
        public hvec4 ywwx => new hvec4(y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.gaar swizzling (equivalent to hvec4.ywwx).
        /// </summary>
        public hvec4 gaar => new hvec4(y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.ywwxx swizzling.
        /// </summary>
        public hvec5 ywwxx => new hvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.gaarr swizzling (equivalent to hvec4.ywwxx).
        /// </summary>
        public hvec5 gaarr => new hvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.ywwxy swizzling.
        /// </summary>
        public hvec5 ywwxy => new hvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.gaarg swizzling (equivalent to hvec4.ywwxy).
        /// </summary>
        public hvec5 gaarg => new hvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.ywwxz swizzling.
        /// </summary>
        public hvec5 ywwxz => new hvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.gaarb swizzling (equivalent to hvec4.ywwxz).
        /// </summary>
        public hvec5 gaarb => new hvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.ywwxw swizzling.
        /// </summary>
        public hvec5 ywwxw => new hvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.gaara swizzling (equivalent to hvec4.ywwxw).
        /// </summary>
        public hvec5 gaara => new hvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.ywwy swizzling.
        /// </summary>
        public hvec4 ywwy => new hvec4(y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.gaag swizzling (equivalent to hvec4.ywwy).
        /// </summary>
        public hvec4 gaag => new hvec4(y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.ywwyx swizzling.
        /// </summary>
        public hvec5 ywwyx => new hvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.gaagr swizzling (equivalent to hvec4.ywwyx).
        /// </summary>
        public hvec5 gaagr => new hvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.ywwyy swizzling.
        /// </summary>
        public hvec5 ywwyy => new hvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.gaagg swizzling (equivalent to hvec4.ywwyy).
        /// </summary>
        public hvec5 gaagg => new hvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.ywwyz swizzling.
        /// </summary>
        public hvec5 ywwyz => new hvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.gaagb swizzling (equivalent to hvec4.ywwyz).
        /// </summary>
        public hvec5 gaagb => new hvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.ywwyw swizzling.
        /// </summary>
        public hvec5 ywwyw => new hvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.gaaga swizzling (equivalent to hvec4.ywwyw).
        /// </summary>
        public hvec5 gaaga => new hvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.ywwz swizzling.
        /// </summary>
        public hvec4 ywwz => new hvec4(y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.gaab swizzling (equivalent to hvec4.ywwz).
        /// </summary>
        public hvec4 gaab => new hvec4(y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.ywwzx swizzling.
        /// </summary>
        public hvec5 ywwzx => new hvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.gaabr swizzling (equivalent to hvec4.ywwzx).
        /// </summary>
        public hvec5 gaabr => new hvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.ywwzy swizzling.
        /// </summary>
        public hvec5 ywwzy => new hvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.gaabg swizzling (equivalent to hvec4.ywwzy).
        /// </summary>
        public hvec5 gaabg => new hvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.ywwzz swizzling.
        /// </summary>
        public hvec5 ywwzz => new hvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.gaabb swizzling (equivalent to hvec4.ywwzz).
        /// </summary>
        public hvec5 gaabb => new hvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.ywwzw swizzling.
        /// </summary>
        public hvec5 ywwzw => new hvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.gaaba swizzling (equivalent to hvec4.ywwzw).
        /// </summary>
        public hvec5 gaaba => new hvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.ywww swizzling.
        /// </summary>
        public hvec4 ywww => new hvec4(y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.gaaa swizzling (equivalent to hvec4.ywww).
        /// </summary>
        public hvec4 gaaa => new hvec4(y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.ywwwx swizzling.
        /// </summary>
        public hvec5 ywwwx => new hvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.gaaar swizzling (equivalent to hvec4.ywwwx).
        /// </summary>
        public hvec5 gaaar => new hvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.ywwwy swizzling.
        /// </summary>
        public hvec5 ywwwy => new hvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.gaaag swizzling (equivalent to hvec4.ywwwy).
        /// </summary>
        public hvec5 gaaag => new hvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.ywwwz swizzling.
        /// </summary>
        public hvec5 ywwwz => new hvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.gaaab swizzling (equivalent to hvec4.ywwwz).
        /// </summary>
        public hvec5 gaaab => new hvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.ywwww swizzling.
        /// </summary>
        public hvec5 ywwww => new hvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns hvec4.gaaaa swizzling (equivalent to hvec4.ywwww).
        /// </summary>
        public hvec5 gaaaa => new hvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns hvec4.zx swizzling.
        /// </summary>
        public hvec2 zx => new hvec2(z, x);
        
        /// <summary>
        /// Returns hvec4.br swizzling (equivalent to hvec4.zx).
        /// </summary>
        public hvec2 br => new hvec2(z, x);
        
        /// <summary>
        /// Returns hvec4.zxx swizzling.
        /// </summary>
        public hvec3 zxx => new hvec3(z, x, x);
        
        /// <summary>
        /// Returns hvec4.brr swizzling (equivalent to hvec4.zxx).
        /// </summary>
        public hvec3 brr => new hvec3(z, x, x);
        
        /// <summary>
        /// Returns hvec4.zxxx swizzling.
        /// </summary>
        public hvec4 zxxx => new hvec4(z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.brrr swizzling (equivalent to hvec4.zxxx).
        /// </summary>
        public hvec4 brrr => new hvec4(z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.zxxxx swizzling.
        /// </summary>
        public hvec5 zxxxx => new hvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.brrrr swizzling (equivalent to hvec4.zxxxx).
        /// </summary>
        public hvec5 brrrr => new hvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.zxxxy swizzling.
        /// </summary>
        public hvec5 zxxxy => new hvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.brrrg swizzling (equivalent to hvec4.zxxxy).
        /// </summary>
        public hvec5 brrrg => new hvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.zxxxz swizzling.
        /// </summary>
        public hvec5 zxxxz => new hvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.brrrb swizzling (equivalent to hvec4.zxxxz).
        /// </summary>
        public hvec5 brrrb => new hvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.zxxxw swizzling.
        /// </summary>
        public hvec5 zxxxw => new hvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.brrra swizzling (equivalent to hvec4.zxxxw).
        /// </summary>
        public hvec5 brrra => new hvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.zxxy swizzling.
        /// </summary>
        public hvec4 zxxy => new hvec4(z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.brrg swizzling (equivalent to hvec4.zxxy).
        /// </summary>
        public hvec4 brrg => new hvec4(z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.zxxyx swizzling.
        /// </summary>
        public hvec5 zxxyx => new hvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.brrgr swizzling (equivalent to hvec4.zxxyx).
        /// </summary>
        public hvec5 brrgr => new hvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.zxxyy swizzling.
        /// </summary>
        public hvec5 zxxyy => new hvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.brrgg swizzling (equivalent to hvec4.zxxyy).
        /// </summary>
        public hvec5 brrgg => new hvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.zxxyz swizzling.
        /// </summary>
        public hvec5 zxxyz => new hvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.brrgb swizzling (equivalent to hvec4.zxxyz).
        /// </summary>
        public hvec5 brrgb => new hvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.zxxyw swizzling.
        /// </summary>
        public hvec5 zxxyw => new hvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.brrga swizzling (equivalent to hvec4.zxxyw).
        /// </summary>
        public hvec5 brrga => new hvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.zxxz swizzling.
        /// </summary>
        public hvec4 zxxz => new hvec4(z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.brrb swizzling (equivalent to hvec4.zxxz).
        /// </summary>
        public hvec4 brrb => new hvec4(z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.zxxzx swizzling.
        /// </summary>
        public hvec5 zxxzx => new hvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.brrbr swizzling (equivalent to hvec4.zxxzx).
        /// </summary>
        public hvec5 brrbr => new hvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.zxxzy swizzling.
        /// </summary>
        public hvec5 zxxzy => new hvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.brrbg swizzling (equivalent to hvec4.zxxzy).
        /// </summary>
        public hvec5 brrbg => new hvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.zxxzz swizzling.
        /// </summary>
        public hvec5 zxxzz => new hvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.brrbb swizzling (equivalent to hvec4.zxxzz).
        /// </summary>
        public hvec5 brrbb => new hvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.zxxzw swizzling.
        /// </summary>
        public hvec5 zxxzw => new hvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.brrba swizzling (equivalent to hvec4.zxxzw).
        /// </summary>
        public hvec5 brrba => new hvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.zxxw swizzling.
        /// </summary>
        public hvec4 zxxw => new hvec4(z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.brra swizzling (equivalent to hvec4.zxxw).
        /// </summary>
        public hvec4 brra => new hvec4(z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.zxxwx swizzling.
        /// </summary>
        public hvec5 zxxwx => new hvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.brrar swizzling (equivalent to hvec4.zxxwx).
        /// </summary>
        public hvec5 brrar => new hvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.zxxwy swizzling.
        /// </summary>
        public hvec5 zxxwy => new hvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.brrag swizzling (equivalent to hvec4.zxxwy).
        /// </summary>
        public hvec5 brrag => new hvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.zxxwz swizzling.
        /// </summary>
        public hvec5 zxxwz => new hvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.brrab swizzling (equivalent to hvec4.zxxwz).
        /// </summary>
        public hvec5 brrab => new hvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.zxxww swizzling.
        /// </summary>
        public hvec5 zxxww => new hvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.brraa swizzling (equivalent to hvec4.zxxww).
        /// </summary>
        public hvec5 brraa => new hvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.zxy swizzling.
        /// </summary>
        public hvec3 zxy => new hvec3(z, x, y);
        
        /// <summary>
        /// Returns hvec4.brg swizzling (equivalent to hvec4.zxy).
        /// </summary>
        public hvec3 brg => new hvec3(z, x, y);
        
        /// <summary>
        /// Returns hvec4.zxyx swizzling.
        /// </summary>
        public hvec4 zxyx => new hvec4(z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.brgr swizzling (equivalent to hvec4.zxyx).
        /// </summary>
        public hvec4 brgr => new hvec4(z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.zxyxx swizzling.
        /// </summary>
        public hvec5 zxyxx => new hvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.brgrr swizzling (equivalent to hvec4.zxyxx).
        /// </summary>
        public hvec5 brgrr => new hvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.zxyxy swizzling.
        /// </summary>
        public hvec5 zxyxy => new hvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.brgrg swizzling (equivalent to hvec4.zxyxy).
        /// </summary>
        public hvec5 brgrg => new hvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.zxyxz swizzling.
        /// </summary>
        public hvec5 zxyxz => new hvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.brgrb swizzling (equivalent to hvec4.zxyxz).
        /// </summary>
        public hvec5 brgrb => new hvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.zxyxw swizzling.
        /// </summary>
        public hvec5 zxyxw => new hvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.brgra swizzling (equivalent to hvec4.zxyxw).
        /// </summary>
        public hvec5 brgra => new hvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.zxyy swizzling.
        /// </summary>
        public hvec4 zxyy => new hvec4(z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.brgg swizzling (equivalent to hvec4.zxyy).
        /// </summary>
        public hvec4 brgg => new hvec4(z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.zxyyx swizzling.
        /// </summary>
        public hvec5 zxyyx => new hvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.brggr swizzling (equivalent to hvec4.zxyyx).
        /// </summary>
        public hvec5 brggr => new hvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.zxyyy swizzling.
        /// </summary>
        public hvec5 zxyyy => new hvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.brggg swizzling (equivalent to hvec4.zxyyy).
        /// </summary>
        public hvec5 brggg => new hvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.zxyyz swizzling.
        /// </summary>
        public hvec5 zxyyz => new hvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.brggb swizzling (equivalent to hvec4.zxyyz).
        /// </summary>
        public hvec5 brggb => new hvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.zxyyw swizzling.
        /// </summary>
        public hvec5 zxyyw => new hvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.brgga swizzling (equivalent to hvec4.zxyyw).
        /// </summary>
        public hvec5 brgga => new hvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.zxyz swizzling.
        /// </summary>
        public hvec4 zxyz => new hvec4(z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.brgb swizzling (equivalent to hvec4.zxyz).
        /// </summary>
        public hvec4 brgb => new hvec4(z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.zxyzx swizzling.
        /// </summary>
        public hvec5 zxyzx => new hvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.brgbr swizzling (equivalent to hvec4.zxyzx).
        /// </summary>
        public hvec5 brgbr => new hvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.zxyzy swizzling.
        /// </summary>
        public hvec5 zxyzy => new hvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.brgbg swizzling (equivalent to hvec4.zxyzy).
        /// </summary>
        public hvec5 brgbg => new hvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.zxyzz swizzling.
        /// </summary>
        public hvec5 zxyzz => new hvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.brgbb swizzling (equivalent to hvec4.zxyzz).
        /// </summary>
        public hvec5 brgbb => new hvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.zxyzw swizzling.
        /// </summary>
        public hvec5 zxyzw => new hvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.brgba swizzling (equivalent to hvec4.zxyzw).
        /// </summary>
        public hvec5 brgba => new hvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.zxyw swizzling.
        /// </summary>
        public hvec4 zxyw => new hvec4(z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.brga swizzling (equivalent to hvec4.zxyw).
        /// </summary>
        public hvec4 brga => new hvec4(z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.zxywx swizzling.
        /// </summary>
        public hvec5 zxywx => new hvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.brgar swizzling (equivalent to hvec4.zxywx).
        /// </summary>
        public hvec5 brgar => new hvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.zxywy swizzling.
        /// </summary>
        public hvec5 zxywy => new hvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.brgag swizzling (equivalent to hvec4.zxywy).
        /// </summary>
        public hvec5 brgag => new hvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.zxywz swizzling.
        /// </summary>
        public hvec5 zxywz => new hvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.brgab swizzling (equivalent to hvec4.zxywz).
        /// </summary>
        public hvec5 brgab => new hvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.zxyww swizzling.
        /// </summary>
        public hvec5 zxyww => new hvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.brgaa swizzling (equivalent to hvec4.zxyww).
        /// </summary>
        public hvec5 brgaa => new hvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.zxz swizzling.
        /// </summary>
        public hvec3 zxz => new hvec3(z, x, z);
        
        /// <summary>
        /// Returns hvec4.brb swizzling (equivalent to hvec4.zxz).
        /// </summary>
        public hvec3 brb => new hvec3(z, x, z);
        
        /// <summary>
        /// Returns hvec4.zxzx swizzling.
        /// </summary>
        public hvec4 zxzx => new hvec4(z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.brbr swizzling (equivalent to hvec4.zxzx).
        /// </summary>
        public hvec4 brbr => new hvec4(z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.zxzxx swizzling.
        /// </summary>
        public hvec5 zxzxx => new hvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.brbrr swizzling (equivalent to hvec4.zxzxx).
        /// </summary>
        public hvec5 brbrr => new hvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.zxzxy swizzling.
        /// </summary>
        public hvec5 zxzxy => new hvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.brbrg swizzling (equivalent to hvec4.zxzxy).
        /// </summary>
        public hvec5 brbrg => new hvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.zxzxz swizzling.
        /// </summary>
        public hvec5 zxzxz => new hvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.brbrb swizzling (equivalent to hvec4.zxzxz).
        /// </summary>
        public hvec5 brbrb => new hvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.zxzxw swizzling.
        /// </summary>
        public hvec5 zxzxw => new hvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.brbra swizzling (equivalent to hvec4.zxzxw).
        /// </summary>
        public hvec5 brbra => new hvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.zxzy swizzling.
        /// </summary>
        public hvec4 zxzy => new hvec4(z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.brbg swizzling (equivalent to hvec4.zxzy).
        /// </summary>
        public hvec4 brbg => new hvec4(z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.zxzyx swizzling.
        /// </summary>
        public hvec5 zxzyx => new hvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.brbgr swizzling (equivalent to hvec4.zxzyx).
        /// </summary>
        public hvec5 brbgr => new hvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.zxzyy swizzling.
        /// </summary>
        public hvec5 zxzyy => new hvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.brbgg swizzling (equivalent to hvec4.zxzyy).
        /// </summary>
        public hvec5 brbgg => new hvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.zxzyz swizzling.
        /// </summary>
        public hvec5 zxzyz => new hvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.brbgb swizzling (equivalent to hvec4.zxzyz).
        /// </summary>
        public hvec5 brbgb => new hvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.zxzyw swizzling.
        /// </summary>
        public hvec5 zxzyw => new hvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.brbga swizzling (equivalent to hvec4.zxzyw).
        /// </summary>
        public hvec5 brbga => new hvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.zxzz swizzling.
        /// </summary>
        public hvec4 zxzz => new hvec4(z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.brbb swizzling (equivalent to hvec4.zxzz).
        /// </summary>
        public hvec4 brbb => new hvec4(z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.zxzzx swizzling.
        /// </summary>
        public hvec5 zxzzx => new hvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.brbbr swizzling (equivalent to hvec4.zxzzx).
        /// </summary>
        public hvec5 brbbr => new hvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.zxzzy swizzling.
        /// </summary>
        public hvec5 zxzzy => new hvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.brbbg swizzling (equivalent to hvec4.zxzzy).
        /// </summary>
        public hvec5 brbbg => new hvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.zxzzz swizzling.
        /// </summary>
        public hvec5 zxzzz => new hvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.brbbb swizzling (equivalent to hvec4.zxzzz).
        /// </summary>
        public hvec5 brbbb => new hvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.zxzzw swizzling.
        /// </summary>
        public hvec5 zxzzw => new hvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.brbba swizzling (equivalent to hvec4.zxzzw).
        /// </summary>
        public hvec5 brbba => new hvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.zxzw swizzling.
        /// </summary>
        public hvec4 zxzw => new hvec4(z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.brba swizzling (equivalent to hvec4.zxzw).
        /// </summary>
        public hvec4 brba => new hvec4(z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.zxzwx swizzling.
        /// </summary>
        public hvec5 zxzwx => new hvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.brbar swizzling (equivalent to hvec4.zxzwx).
        /// </summary>
        public hvec5 brbar => new hvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.zxzwy swizzling.
        /// </summary>
        public hvec5 zxzwy => new hvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.brbag swizzling (equivalent to hvec4.zxzwy).
        /// </summary>
        public hvec5 brbag => new hvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.zxzwz swizzling.
        /// </summary>
        public hvec5 zxzwz => new hvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.brbab swizzling (equivalent to hvec4.zxzwz).
        /// </summary>
        public hvec5 brbab => new hvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.zxzww swizzling.
        /// </summary>
        public hvec5 zxzww => new hvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.brbaa swizzling (equivalent to hvec4.zxzww).
        /// </summary>
        public hvec5 brbaa => new hvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.zxw swizzling.
        /// </summary>
        public hvec3 zxw => new hvec3(z, x, w);
        
        /// <summary>
        /// Returns hvec4.bra swizzling (equivalent to hvec4.zxw).
        /// </summary>
        public hvec3 bra => new hvec3(z, x, w);
        
        /// <summary>
        /// Returns hvec4.zxwx swizzling.
        /// </summary>
        public hvec4 zxwx => new hvec4(z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.brar swizzling (equivalent to hvec4.zxwx).
        /// </summary>
        public hvec4 brar => new hvec4(z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.zxwxx swizzling.
        /// </summary>
        public hvec5 zxwxx => new hvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.brarr swizzling (equivalent to hvec4.zxwxx).
        /// </summary>
        public hvec5 brarr => new hvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.zxwxy swizzling.
        /// </summary>
        public hvec5 zxwxy => new hvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.brarg swizzling (equivalent to hvec4.zxwxy).
        /// </summary>
        public hvec5 brarg => new hvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.zxwxz swizzling.
        /// </summary>
        public hvec5 zxwxz => new hvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.brarb swizzling (equivalent to hvec4.zxwxz).
        /// </summary>
        public hvec5 brarb => new hvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.zxwxw swizzling.
        /// </summary>
        public hvec5 zxwxw => new hvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.brara swizzling (equivalent to hvec4.zxwxw).
        /// </summary>
        public hvec5 brara => new hvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.zxwy swizzling.
        /// </summary>
        public hvec4 zxwy => new hvec4(z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.brag swizzling (equivalent to hvec4.zxwy).
        /// </summary>
        public hvec4 brag => new hvec4(z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.zxwyx swizzling.
        /// </summary>
        public hvec5 zxwyx => new hvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.bragr swizzling (equivalent to hvec4.zxwyx).
        /// </summary>
        public hvec5 bragr => new hvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.zxwyy swizzling.
        /// </summary>
        public hvec5 zxwyy => new hvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.bragg swizzling (equivalent to hvec4.zxwyy).
        /// </summary>
        public hvec5 bragg => new hvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.zxwyz swizzling.
        /// </summary>
        public hvec5 zxwyz => new hvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.bragb swizzling (equivalent to hvec4.zxwyz).
        /// </summary>
        public hvec5 bragb => new hvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.zxwyw swizzling.
        /// </summary>
        public hvec5 zxwyw => new hvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.braga swizzling (equivalent to hvec4.zxwyw).
        /// </summary>
        public hvec5 braga => new hvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.zxwz swizzling.
        /// </summary>
        public hvec4 zxwz => new hvec4(z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.brab swizzling (equivalent to hvec4.zxwz).
        /// </summary>
        public hvec4 brab => new hvec4(z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.zxwzx swizzling.
        /// </summary>
        public hvec5 zxwzx => new hvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.brabr swizzling (equivalent to hvec4.zxwzx).
        /// </summary>
        public hvec5 brabr => new hvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.zxwzy swizzling.
        /// </summary>
        public hvec5 zxwzy => new hvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.brabg swizzling (equivalent to hvec4.zxwzy).
        /// </summary>
        public hvec5 brabg => new hvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.zxwzz swizzling.
        /// </summary>
        public hvec5 zxwzz => new hvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.brabb swizzling (equivalent to hvec4.zxwzz).
        /// </summary>
        public hvec5 brabb => new hvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.zxwzw swizzling.
        /// </summary>
        public hvec5 zxwzw => new hvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.braba swizzling (equivalent to hvec4.zxwzw).
        /// </summary>
        public hvec5 braba => new hvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.zxww swizzling.
        /// </summary>
        public hvec4 zxww => new hvec4(z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.braa swizzling (equivalent to hvec4.zxww).
        /// </summary>
        public hvec4 braa => new hvec4(z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.zxwwx swizzling.
        /// </summary>
        public hvec5 zxwwx => new hvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.braar swizzling (equivalent to hvec4.zxwwx).
        /// </summary>
        public hvec5 braar => new hvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.zxwwy swizzling.
        /// </summary>
        public hvec5 zxwwy => new hvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.braag swizzling (equivalent to hvec4.zxwwy).
        /// </summary>
        public hvec5 braag => new hvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.zxwwz swizzling.
        /// </summary>
        public hvec5 zxwwz => new hvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.braab swizzling (equivalent to hvec4.zxwwz).
        /// </summary>
        public hvec5 braab => new hvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.zxwww swizzling.
        /// </summary>
        public hvec5 zxwww => new hvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.braaa swizzling (equivalent to hvec4.zxwww).
        /// </summary>
        public hvec5 braaa => new hvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.zy swizzling.
        /// </summary>
        public hvec2 zy => new hvec2(z, y);
        
        /// <summary>
        /// Returns hvec4.bg swizzling (equivalent to hvec4.zy).
        /// </summary>
        public hvec2 bg => new hvec2(z, y);
        
        /// <summary>
        /// Returns hvec4.zyx swizzling.
        /// </summary>
        public hvec3 zyx => new hvec3(z, y, x);
        
        /// <summary>
        /// Returns hvec4.bgr swizzling (equivalent to hvec4.zyx).
        /// </summary>
        public hvec3 bgr => new hvec3(z, y, x);
        
        /// <summary>
        /// Returns hvec4.zyxx swizzling.
        /// </summary>
        public hvec4 zyxx => new hvec4(z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.bgrr swizzling (equivalent to hvec4.zyxx).
        /// </summary>
        public hvec4 bgrr => new hvec4(z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.zyxxx swizzling.
        /// </summary>
        public hvec5 zyxxx => new hvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.bgrrr swizzling (equivalent to hvec4.zyxxx).
        /// </summary>
        public hvec5 bgrrr => new hvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.zyxxy swizzling.
        /// </summary>
        public hvec5 zyxxy => new hvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.bgrrg swizzling (equivalent to hvec4.zyxxy).
        /// </summary>
        public hvec5 bgrrg => new hvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.zyxxz swizzling.
        /// </summary>
        public hvec5 zyxxz => new hvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.bgrrb swizzling (equivalent to hvec4.zyxxz).
        /// </summary>
        public hvec5 bgrrb => new hvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.zyxxw swizzling.
        /// </summary>
        public hvec5 zyxxw => new hvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.bgrra swizzling (equivalent to hvec4.zyxxw).
        /// </summary>
        public hvec5 bgrra => new hvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.zyxy swizzling.
        /// </summary>
        public hvec4 zyxy => new hvec4(z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.bgrg swizzling (equivalent to hvec4.zyxy).
        /// </summary>
        public hvec4 bgrg => new hvec4(z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.zyxyx swizzling.
        /// </summary>
        public hvec5 zyxyx => new hvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.bgrgr swizzling (equivalent to hvec4.zyxyx).
        /// </summary>
        public hvec5 bgrgr => new hvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.zyxyy swizzling.
        /// </summary>
        public hvec5 zyxyy => new hvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.bgrgg swizzling (equivalent to hvec4.zyxyy).
        /// </summary>
        public hvec5 bgrgg => new hvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.zyxyz swizzling.
        /// </summary>
        public hvec5 zyxyz => new hvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.bgrgb swizzling (equivalent to hvec4.zyxyz).
        /// </summary>
        public hvec5 bgrgb => new hvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.zyxyw swizzling.
        /// </summary>
        public hvec5 zyxyw => new hvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.bgrga swizzling (equivalent to hvec4.zyxyw).
        /// </summary>
        public hvec5 bgrga => new hvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.zyxz swizzling.
        /// </summary>
        public hvec4 zyxz => new hvec4(z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.bgrb swizzling (equivalent to hvec4.zyxz).
        /// </summary>
        public hvec4 bgrb => new hvec4(z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.zyxzx swizzling.
        /// </summary>
        public hvec5 zyxzx => new hvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.bgrbr swizzling (equivalent to hvec4.zyxzx).
        /// </summary>
        public hvec5 bgrbr => new hvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.zyxzy swizzling.
        /// </summary>
        public hvec5 zyxzy => new hvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.bgrbg swizzling (equivalent to hvec4.zyxzy).
        /// </summary>
        public hvec5 bgrbg => new hvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.zyxzz swizzling.
        /// </summary>
        public hvec5 zyxzz => new hvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.bgrbb swizzling (equivalent to hvec4.zyxzz).
        /// </summary>
        public hvec5 bgrbb => new hvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.zyxzw swizzling.
        /// </summary>
        public hvec5 zyxzw => new hvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.bgrba swizzling (equivalent to hvec4.zyxzw).
        /// </summary>
        public hvec5 bgrba => new hvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.zyxw swizzling.
        /// </summary>
        public hvec4 zyxw => new hvec4(z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.bgra swizzling (equivalent to hvec4.zyxw).
        /// </summary>
        public hvec4 bgra => new hvec4(z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.zyxwx swizzling.
        /// </summary>
        public hvec5 zyxwx => new hvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.bgrar swizzling (equivalent to hvec4.zyxwx).
        /// </summary>
        public hvec5 bgrar => new hvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.zyxwy swizzling.
        /// </summary>
        public hvec5 zyxwy => new hvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.bgrag swizzling (equivalent to hvec4.zyxwy).
        /// </summary>
        public hvec5 bgrag => new hvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.zyxwz swizzling.
        /// </summary>
        public hvec5 zyxwz => new hvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.bgrab swizzling (equivalent to hvec4.zyxwz).
        /// </summary>
        public hvec5 bgrab => new hvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.zyxww swizzling.
        /// </summary>
        public hvec5 zyxww => new hvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.bgraa swizzling (equivalent to hvec4.zyxww).
        /// </summary>
        public hvec5 bgraa => new hvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.zyy swizzling.
        /// </summary>
        public hvec3 zyy => new hvec3(z, y, y);
        
        /// <summary>
        /// Returns hvec4.bgg swizzling (equivalent to hvec4.zyy).
        /// </summary>
        public hvec3 bgg => new hvec3(z, y, y);
        
        /// <summary>
        /// Returns hvec4.zyyx swizzling.
        /// </summary>
        public hvec4 zyyx => new hvec4(z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.bggr swizzling (equivalent to hvec4.zyyx).
        /// </summary>
        public hvec4 bggr => new hvec4(z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.zyyxx swizzling.
        /// </summary>
        public hvec5 zyyxx => new hvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.bggrr swizzling (equivalent to hvec4.zyyxx).
        /// </summary>
        public hvec5 bggrr => new hvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.zyyxy swizzling.
        /// </summary>
        public hvec5 zyyxy => new hvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.bggrg swizzling (equivalent to hvec4.zyyxy).
        /// </summary>
        public hvec5 bggrg => new hvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.zyyxz swizzling.
        /// </summary>
        public hvec5 zyyxz => new hvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.bggrb swizzling (equivalent to hvec4.zyyxz).
        /// </summary>
        public hvec5 bggrb => new hvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.zyyxw swizzling.
        /// </summary>
        public hvec5 zyyxw => new hvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.bggra swizzling (equivalent to hvec4.zyyxw).
        /// </summary>
        public hvec5 bggra => new hvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.zyyy swizzling.
        /// </summary>
        public hvec4 zyyy => new hvec4(z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.bggg swizzling (equivalent to hvec4.zyyy).
        /// </summary>
        public hvec4 bggg => new hvec4(z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.zyyyx swizzling.
        /// </summary>
        public hvec5 zyyyx => new hvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.bgggr swizzling (equivalent to hvec4.zyyyx).
        /// </summary>
        public hvec5 bgggr => new hvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.zyyyy swizzling.
        /// </summary>
        public hvec5 zyyyy => new hvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.bgggg swizzling (equivalent to hvec4.zyyyy).
        /// </summary>
        public hvec5 bgggg => new hvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.zyyyz swizzling.
        /// </summary>
        public hvec5 zyyyz => new hvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.bgggb swizzling (equivalent to hvec4.zyyyz).
        /// </summary>
        public hvec5 bgggb => new hvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.zyyyw swizzling.
        /// </summary>
        public hvec5 zyyyw => new hvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.bggga swizzling (equivalent to hvec4.zyyyw).
        /// </summary>
        public hvec5 bggga => new hvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.zyyz swizzling.
        /// </summary>
        public hvec4 zyyz => new hvec4(z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.bggb swizzling (equivalent to hvec4.zyyz).
        /// </summary>
        public hvec4 bggb => new hvec4(z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.zyyzx swizzling.
        /// </summary>
        public hvec5 zyyzx => new hvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.bggbr swizzling (equivalent to hvec4.zyyzx).
        /// </summary>
        public hvec5 bggbr => new hvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.zyyzy swizzling.
        /// </summary>
        public hvec5 zyyzy => new hvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.bggbg swizzling (equivalent to hvec4.zyyzy).
        /// </summary>
        public hvec5 bggbg => new hvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.zyyzz swizzling.
        /// </summary>
        public hvec5 zyyzz => new hvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.bggbb swizzling (equivalent to hvec4.zyyzz).
        /// </summary>
        public hvec5 bggbb => new hvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.zyyzw swizzling.
        /// </summary>
        public hvec5 zyyzw => new hvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.bggba swizzling (equivalent to hvec4.zyyzw).
        /// </summary>
        public hvec5 bggba => new hvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.zyyw swizzling.
        /// </summary>
        public hvec4 zyyw => new hvec4(z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.bgga swizzling (equivalent to hvec4.zyyw).
        /// </summary>
        public hvec4 bgga => new hvec4(z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.zyywx swizzling.
        /// </summary>
        public hvec5 zyywx => new hvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.bggar swizzling (equivalent to hvec4.zyywx).
        /// </summary>
        public hvec5 bggar => new hvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.zyywy swizzling.
        /// </summary>
        public hvec5 zyywy => new hvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.bggag swizzling (equivalent to hvec4.zyywy).
        /// </summary>
        public hvec5 bggag => new hvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.zyywz swizzling.
        /// </summary>
        public hvec5 zyywz => new hvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.bggab swizzling (equivalent to hvec4.zyywz).
        /// </summary>
        public hvec5 bggab => new hvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.zyyww swizzling.
        /// </summary>
        public hvec5 zyyww => new hvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.bggaa swizzling (equivalent to hvec4.zyyww).
        /// </summary>
        public hvec5 bggaa => new hvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.zyz swizzling.
        /// </summary>
        public hvec3 zyz => new hvec3(z, y, z);
        
        /// <summary>
        /// Returns hvec4.bgb swizzling (equivalent to hvec4.zyz).
        /// </summary>
        public hvec3 bgb => new hvec3(z, y, z);
        
        /// <summary>
        /// Returns hvec4.zyzx swizzling.
        /// </summary>
        public hvec4 zyzx => new hvec4(z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.bgbr swizzling (equivalent to hvec4.zyzx).
        /// </summary>
        public hvec4 bgbr => new hvec4(z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.zyzxx swizzling.
        /// </summary>
        public hvec5 zyzxx => new hvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.bgbrr swizzling (equivalent to hvec4.zyzxx).
        /// </summary>
        public hvec5 bgbrr => new hvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.zyzxy swizzling.
        /// </summary>
        public hvec5 zyzxy => new hvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.bgbrg swizzling (equivalent to hvec4.zyzxy).
        /// </summary>
        public hvec5 bgbrg => new hvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.zyzxz swizzling.
        /// </summary>
        public hvec5 zyzxz => new hvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.bgbrb swizzling (equivalent to hvec4.zyzxz).
        /// </summary>
        public hvec5 bgbrb => new hvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.zyzxw swizzling.
        /// </summary>
        public hvec5 zyzxw => new hvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.bgbra swizzling (equivalent to hvec4.zyzxw).
        /// </summary>
        public hvec5 bgbra => new hvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.zyzy swizzling.
        /// </summary>
        public hvec4 zyzy => new hvec4(z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.bgbg swizzling (equivalent to hvec4.zyzy).
        /// </summary>
        public hvec4 bgbg => new hvec4(z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.zyzyx swizzling.
        /// </summary>
        public hvec5 zyzyx => new hvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.bgbgr swizzling (equivalent to hvec4.zyzyx).
        /// </summary>
        public hvec5 bgbgr => new hvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.zyzyy swizzling.
        /// </summary>
        public hvec5 zyzyy => new hvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.bgbgg swizzling (equivalent to hvec4.zyzyy).
        /// </summary>
        public hvec5 bgbgg => new hvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.zyzyz swizzling.
        /// </summary>
        public hvec5 zyzyz => new hvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.bgbgb swizzling (equivalent to hvec4.zyzyz).
        /// </summary>
        public hvec5 bgbgb => new hvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.zyzyw swizzling.
        /// </summary>
        public hvec5 zyzyw => new hvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.bgbga swizzling (equivalent to hvec4.zyzyw).
        /// </summary>
        public hvec5 bgbga => new hvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.zyzz swizzling.
        /// </summary>
        public hvec4 zyzz => new hvec4(z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.bgbb swizzling (equivalent to hvec4.zyzz).
        /// </summary>
        public hvec4 bgbb => new hvec4(z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.zyzzx swizzling.
        /// </summary>
        public hvec5 zyzzx => new hvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.bgbbr swizzling (equivalent to hvec4.zyzzx).
        /// </summary>
        public hvec5 bgbbr => new hvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.zyzzy swizzling.
        /// </summary>
        public hvec5 zyzzy => new hvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.bgbbg swizzling (equivalent to hvec4.zyzzy).
        /// </summary>
        public hvec5 bgbbg => new hvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.zyzzz swizzling.
        /// </summary>
        public hvec5 zyzzz => new hvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.bgbbb swizzling (equivalent to hvec4.zyzzz).
        /// </summary>
        public hvec5 bgbbb => new hvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.zyzzw swizzling.
        /// </summary>
        public hvec5 zyzzw => new hvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.bgbba swizzling (equivalent to hvec4.zyzzw).
        /// </summary>
        public hvec5 bgbba => new hvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.zyzw swizzling.
        /// </summary>
        public hvec4 zyzw => new hvec4(z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.bgba swizzling (equivalent to hvec4.zyzw).
        /// </summary>
        public hvec4 bgba => new hvec4(z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.zyzwx swizzling.
        /// </summary>
        public hvec5 zyzwx => new hvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.bgbar swizzling (equivalent to hvec4.zyzwx).
        /// </summary>
        public hvec5 bgbar => new hvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.zyzwy swizzling.
        /// </summary>
        public hvec5 zyzwy => new hvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.bgbag swizzling (equivalent to hvec4.zyzwy).
        /// </summary>
        public hvec5 bgbag => new hvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.zyzwz swizzling.
        /// </summary>
        public hvec5 zyzwz => new hvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.bgbab swizzling (equivalent to hvec4.zyzwz).
        /// </summary>
        public hvec5 bgbab => new hvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.zyzww swizzling.
        /// </summary>
        public hvec5 zyzww => new hvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.bgbaa swizzling (equivalent to hvec4.zyzww).
        /// </summary>
        public hvec5 bgbaa => new hvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.zyw swizzling.
        /// </summary>
        public hvec3 zyw => new hvec3(z, y, w);
        
        /// <summary>
        /// Returns hvec4.bga swizzling (equivalent to hvec4.zyw).
        /// </summary>
        public hvec3 bga => new hvec3(z, y, w);
        
        /// <summary>
        /// Returns hvec4.zywx swizzling.
        /// </summary>
        public hvec4 zywx => new hvec4(z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.bgar swizzling (equivalent to hvec4.zywx).
        /// </summary>
        public hvec4 bgar => new hvec4(z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.zywxx swizzling.
        /// </summary>
        public hvec5 zywxx => new hvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.bgarr swizzling (equivalent to hvec4.zywxx).
        /// </summary>
        public hvec5 bgarr => new hvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.zywxy swizzling.
        /// </summary>
        public hvec5 zywxy => new hvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.bgarg swizzling (equivalent to hvec4.zywxy).
        /// </summary>
        public hvec5 bgarg => new hvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.zywxz swizzling.
        /// </summary>
        public hvec5 zywxz => new hvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.bgarb swizzling (equivalent to hvec4.zywxz).
        /// </summary>
        public hvec5 bgarb => new hvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.zywxw swizzling.
        /// </summary>
        public hvec5 zywxw => new hvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.bgara swizzling (equivalent to hvec4.zywxw).
        /// </summary>
        public hvec5 bgara => new hvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.zywy swizzling.
        /// </summary>
        public hvec4 zywy => new hvec4(z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.bgag swizzling (equivalent to hvec4.zywy).
        /// </summary>
        public hvec4 bgag => new hvec4(z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.zywyx swizzling.
        /// </summary>
        public hvec5 zywyx => new hvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.bgagr swizzling (equivalent to hvec4.zywyx).
        /// </summary>
        public hvec5 bgagr => new hvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.zywyy swizzling.
        /// </summary>
        public hvec5 zywyy => new hvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.bgagg swizzling (equivalent to hvec4.zywyy).
        /// </summary>
        public hvec5 bgagg => new hvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.zywyz swizzling.
        /// </summary>
        public hvec5 zywyz => new hvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.bgagb swizzling (equivalent to hvec4.zywyz).
        /// </summary>
        public hvec5 bgagb => new hvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.zywyw swizzling.
        /// </summary>
        public hvec5 zywyw => new hvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.bgaga swizzling (equivalent to hvec4.zywyw).
        /// </summary>
        public hvec5 bgaga => new hvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.zywz swizzling.
        /// </summary>
        public hvec4 zywz => new hvec4(z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.bgab swizzling (equivalent to hvec4.zywz).
        /// </summary>
        public hvec4 bgab => new hvec4(z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.zywzx swizzling.
        /// </summary>
        public hvec5 zywzx => new hvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.bgabr swizzling (equivalent to hvec4.zywzx).
        /// </summary>
        public hvec5 bgabr => new hvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.zywzy swizzling.
        /// </summary>
        public hvec5 zywzy => new hvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.bgabg swizzling (equivalent to hvec4.zywzy).
        /// </summary>
        public hvec5 bgabg => new hvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.zywzz swizzling.
        /// </summary>
        public hvec5 zywzz => new hvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.bgabb swizzling (equivalent to hvec4.zywzz).
        /// </summary>
        public hvec5 bgabb => new hvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.zywzw swizzling.
        /// </summary>
        public hvec5 zywzw => new hvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.bgaba swizzling (equivalent to hvec4.zywzw).
        /// </summary>
        public hvec5 bgaba => new hvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.zyww swizzling.
        /// </summary>
        public hvec4 zyww => new hvec4(z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.bgaa swizzling (equivalent to hvec4.zyww).
        /// </summary>
        public hvec4 bgaa => new hvec4(z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.zywwx swizzling.
        /// </summary>
        public hvec5 zywwx => new hvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.bgaar swizzling (equivalent to hvec4.zywwx).
        /// </summary>
        public hvec5 bgaar => new hvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.zywwy swizzling.
        /// </summary>
        public hvec5 zywwy => new hvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.bgaag swizzling (equivalent to hvec4.zywwy).
        /// </summary>
        public hvec5 bgaag => new hvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.zywwz swizzling.
        /// </summary>
        public hvec5 zywwz => new hvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.bgaab swizzling (equivalent to hvec4.zywwz).
        /// </summary>
        public hvec5 bgaab => new hvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.zywww swizzling.
        /// </summary>
        public hvec5 zywww => new hvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.bgaaa swizzling (equivalent to hvec4.zywww).
        /// </summary>
        public hvec5 bgaaa => new hvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.zz swizzling.
        /// </summary>
        public hvec2 zz => new hvec2(z, z);
        
        /// <summary>
        /// Returns hvec4.bb swizzling (equivalent to hvec4.zz).
        /// </summary>
        public hvec2 bb => new hvec2(z, z);
        
        /// <summary>
        /// Returns hvec4.zzx swizzling.
        /// </summary>
        public hvec3 zzx => new hvec3(z, z, x);
        
        /// <summary>
        /// Returns hvec4.bbr swizzling (equivalent to hvec4.zzx).
        /// </summary>
        public hvec3 bbr => new hvec3(z, z, x);
        
        /// <summary>
        /// Returns hvec4.zzxx swizzling.
        /// </summary>
        public hvec4 zzxx => new hvec4(z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.bbrr swizzling (equivalent to hvec4.zzxx).
        /// </summary>
        public hvec4 bbrr => new hvec4(z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.zzxxx swizzling.
        /// </summary>
        public hvec5 zzxxx => new hvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.bbrrr swizzling (equivalent to hvec4.zzxxx).
        /// </summary>
        public hvec5 bbrrr => new hvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.zzxxy swizzling.
        /// </summary>
        public hvec5 zzxxy => new hvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.bbrrg swizzling (equivalent to hvec4.zzxxy).
        /// </summary>
        public hvec5 bbrrg => new hvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.zzxxz swizzling.
        /// </summary>
        public hvec5 zzxxz => new hvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.bbrrb swizzling (equivalent to hvec4.zzxxz).
        /// </summary>
        public hvec5 bbrrb => new hvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.zzxxw swizzling.
        /// </summary>
        public hvec5 zzxxw => new hvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.bbrra swizzling (equivalent to hvec4.zzxxw).
        /// </summary>
        public hvec5 bbrra => new hvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.zzxy swizzling.
        /// </summary>
        public hvec4 zzxy => new hvec4(z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.bbrg swizzling (equivalent to hvec4.zzxy).
        /// </summary>
        public hvec4 bbrg => new hvec4(z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.zzxyx swizzling.
        /// </summary>
        public hvec5 zzxyx => new hvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.bbrgr swizzling (equivalent to hvec4.zzxyx).
        /// </summary>
        public hvec5 bbrgr => new hvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.zzxyy swizzling.
        /// </summary>
        public hvec5 zzxyy => new hvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.bbrgg swizzling (equivalent to hvec4.zzxyy).
        /// </summary>
        public hvec5 bbrgg => new hvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.zzxyz swizzling.
        /// </summary>
        public hvec5 zzxyz => new hvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.bbrgb swizzling (equivalent to hvec4.zzxyz).
        /// </summary>
        public hvec5 bbrgb => new hvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.zzxyw swizzling.
        /// </summary>
        public hvec5 zzxyw => new hvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.bbrga swizzling (equivalent to hvec4.zzxyw).
        /// </summary>
        public hvec5 bbrga => new hvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.zzxz swizzling.
        /// </summary>
        public hvec4 zzxz => new hvec4(z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.bbrb swizzling (equivalent to hvec4.zzxz).
        /// </summary>
        public hvec4 bbrb => new hvec4(z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.zzxzx swizzling.
        /// </summary>
        public hvec5 zzxzx => new hvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.bbrbr swizzling (equivalent to hvec4.zzxzx).
        /// </summary>
        public hvec5 bbrbr => new hvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.zzxzy swizzling.
        /// </summary>
        public hvec5 zzxzy => new hvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.bbrbg swizzling (equivalent to hvec4.zzxzy).
        /// </summary>
        public hvec5 bbrbg => new hvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.zzxzz swizzling.
        /// </summary>
        public hvec5 zzxzz => new hvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.bbrbb swizzling (equivalent to hvec4.zzxzz).
        /// </summary>
        public hvec5 bbrbb => new hvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.zzxzw swizzling.
        /// </summary>
        public hvec5 zzxzw => new hvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.bbrba swizzling (equivalent to hvec4.zzxzw).
        /// </summary>
        public hvec5 bbrba => new hvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.zzxw swizzling.
        /// </summary>
        public hvec4 zzxw => new hvec4(z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.bbra swizzling (equivalent to hvec4.zzxw).
        /// </summary>
        public hvec4 bbra => new hvec4(z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.zzxwx swizzling.
        /// </summary>
        public hvec5 zzxwx => new hvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.bbrar swizzling (equivalent to hvec4.zzxwx).
        /// </summary>
        public hvec5 bbrar => new hvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.zzxwy swizzling.
        /// </summary>
        public hvec5 zzxwy => new hvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.bbrag swizzling (equivalent to hvec4.zzxwy).
        /// </summary>
        public hvec5 bbrag => new hvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.zzxwz swizzling.
        /// </summary>
        public hvec5 zzxwz => new hvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.bbrab swizzling (equivalent to hvec4.zzxwz).
        /// </summary>
        public hvec5 bbrab => new hvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.zzxww swizzling.
        /// </summary>
        public hvec5 zzxww => new hvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.bbraa swizzling (equivalent to hvec4.zzxww).
        /// </summary>
        public hvec5 bbraa => new hvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.zzy swizzling.
        /// </summary>
        public hvec3 zzy => new hvec3(z, z, y);
        
        /// <summary>
        /// Returns hvec4.bbg swizzling (equivalent to hvec4.zzy).
        /// </summary>
        public hvec3 bbg => new hvec3(z, z, y);
        
        /// <summary>
        /// Returns hvec4.zzyx swizzling.
        /// </summary>
        public hvec4 zzyx => new hvec4(z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.bbgr swizzling (equivalent to hvec4.zzyx).
        /// </summary>
        public hvec4 bbgr => new hvec4(z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.zzyxx swizzling.
        /// </summary>
        public hvec5 zzyxx => new hvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.bbgrr swizzling (equivalent to hvec4.zzyxx).
        /// </summary>
        public hvec5 bbgrr => new hvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.zzyxy swizzling.
        /// </summary>
        public hvec5 zzyxy => new hvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.bbgrg swizzling (equivalent to hvec4.zzyxy).
        /// </summary>
        public hvec5 bbgrg => new hvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.zzyxz swizzling.
        /// </summary>
        public hvec5 zzyxz => new hvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.bbgrb swizzling (equivalent to hvec4.zzyxz).
        /// </summary>
        public hvec5 bbgrb => new hvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.zzyxw swizzling.
        /// </summary>
        public hvec5 zzyxw => new hvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.bbgra swizzling (equivalent to hvec4.zzyxw).
        /// </summary>
        public hvec5 bbgra => new hvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.zzyy swizzling.
        /// </summary>
        public hvec4 zzyy => new hvec4(z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.bbgg swizzling (equivalent to hvec4.zzyy).
        /// </summary>
        public hvec4 bbgg => new hvec4(z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.zzyyx swizzling.
        /// </summary>
        public hvec5 zzyyx => new hvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.bbggr swizzling (equivalent to hvec4.zzyyx).
        /// </summary>
        public hvec5 bbggr => new hvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.zzyyy swizzling.
        /// </summary>
        public hvec5 zzyyy => new hvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.bbggg swizzling (equivalent to hvec4.zzyyy).
        /// </summary>
        public hvec5 bbggg => new hvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.zzyyz swizzling.
        /// </summary>
        public hvec5 zzyyz => new hvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.bbggb swizzling (equivalent to hvec4.zzyyz).
        /// </summary>
        public hvec5 bbggb => new hvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.zzyyw swizzling.
        /// </summary>
        public hvec5 zzyyw => new hvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.bbgga swizzling (equivalent to hvec4.zzyyw).
        /// </summary>
        public hvec5 bbgga => new hvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.zzyz swizzling.
        /// </summary>
        public hvec4 zzyz => new hvec4(z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.bbgb swizzling (equivalent to hvec4.zzyz).
        /// </summary>
        public hvec4 bbgb => new hvec4(z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.zzyzx swizzling.
        /// </summary>
        public hvec5 zzyzx => new hvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.bbgbr swizzling (equivalent to hvec4.zzyzx).
        /// </summary>
        public hvec5 bbgbr => new hvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.zzyzy swizzling.
        /// </summary>
        public hvec5 zzyzy => new hvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.bbgbg swizzling (equivalent to hvec4.zzyzy).
        /// </summary>
        public hvec5 bbgbg => new hvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.zzyzz swizzling.
        /// </summary>
        public hvec5 zzyzz => new hvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.bbgbb swizzling (equivalent to hvec4.zzyzz).
        /// </summary>
        public hvec5 bbgbb => new hvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.zzyzw swizzling.
        /// </summary>
        public hvec5 zzyzw => new hvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.bbgba swizzling (equivalent to hvec4.zzyzw).
        /// </summary>
        public hvec5 bbgba => new hvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.zzyw swizzling.
        /// </summary>
        public hvec4 zzyw => new hvec4(z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.bbga swizzling (equivalent to hvec4.zzyw).
        /// </summary>
        public hvec4 bbga => new hvec4(z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.zzywx swizzling.
        /// </summary>
        public hvec5 zzywx => new hvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.bbgar swizzling (equivalent to hvec4.zzywx).
        /// </summary>
        public hvec5 bbgar => new hvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.zzywy swizzling.
        /// </summary>
        public hvec5 zzywy => new hvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.bbgag swizzling (equivalent to hvec4.zzywy).
        /// </summary>
        public hvec5 bbgag => new hvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.zzywz swizzling.
        /// </summary>
        public hvec5 zzywz => new hvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.bbgab swizzling (equivalent to hvec4.zzywz).
        /// </summary>
        public hvec5 bbgab => new hvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.zzyww swizzling.
        /// </summary>
        public hvec5 zzyww => new hvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.bbgaa swizzling (equivalent to hvec4.zzyww).
        /// </summary>
        public hvec5 bbgaa => new hvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.zzz swizzling.
        /// </summary>
        public hvec3 zzz => new hvec3(z, z, z);
        
        /// <summary>
        /// Returns hvec4.bbb swizzling (equivalent to hvec4.zzz).
        /// </summary>
        public hvec3 bbb => new hvec3(z, z, z);
        
        /// <summary>
        /// Returns hvec4.zzzx swizzling.
        /// </summary>
        public hvec4 zzzx => new hvec4(z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.bbbr swizzling (equivalent to hvec4.zzzx).
        /// </summary>
        public hvec4 bbbr => new hvec4(z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.zzzxx swizzling.
        /// </summary>
        public hvec5 zzzxx => new hvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.bbbrr swizzling (equivalent to hvec4.zzzxx).
        /// </summary>
        public hvec5 bbbrr => new hvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.zzzxy swizzling.
        /// </summary>
        public hvec5 zzzxy => new hvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.bbbrg swizzling (equivalent to hvec4.zzzxy).
        /// </summary>
        public hvec5 bbbrg => new hvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.zzzxz swizzling.
        /// </summary>
        public hvec5 zzzxz => new hvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.bbbrb swizzling (equivalent to hvec4.zzzxz).
        /// </summary>
        public hvec5 bbbrb => new hvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.zzzxw swizzling.
        /// </summary>
        public hvec5 zzzxw => new hvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.bbbra swizzling (equivalent to hvec4.zzzxw).
        /// </summary>
        public hvec5 bbbra => new hvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.zzzy swizzling.
        /// </summary>
        public hvec4 zzzy => new hvec4(z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.bbbg swizzling (equivalent to hvec4.zzzy).
        /// </summary>
        public hvec4 bbbg => new hvec4(z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.zzzyx swizzling.
        /// </summary>
        public hvec5 zzzyx => new hvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.bbbgr swizzling (equivalent to hvec4.zzzyx).
        /// </summary>
        public hvec5 bbbgr => new hvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.zzzyy swizzling.
        /// </summary>
        public hvec5 zzzyy => new hvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.bbbgg swizzling (equivalent to hvec4.zzzyy).
        /// </summary>
        public hvec5 bbbgg => new hvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.zzzyz swizzling.
        /// </summary>
        public hvec5 zzzyz => new hvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.bbbgb swizzling (equivalent to hvec4.zzzyz).
        /// </summary>
        public hvec5 bbbgb => new hvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.zzzyw swizzling.
        /// </summary>
        public hvec5 zzzyw => new hvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.bbbga swizzling (equivalent to hvec4.zzzyw).
        /// </summary>
        public hvec5 bbbga => new hvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.zzzz swizzling.
        /// </summary>
        public hvec4 zzzz => new hvec4(z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.bbbb swizzling (equivalent to hvec4.zzzz).
        /// </summary>
        public hvec4 bbbb => new hvec4(z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.zzzzx swizzling.
        /// </summary>
        public hvec5 zzzzx => new hvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.bbbbr swizzling (equivalent to hvec4.zzzzx).
        /// </summary>
        public hvec5 bbbbr => new hvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.zzzzy swizzling.
        /// </summary>
        public hvec5 zzzzy => new hvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.bbbbg swizzling (equivalent to hvec4.zzzzy).
        /// </summary>
        public hvec5 bbbbg => new hvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.zzzzz swizzling.
        /// </summary>
        public hvec5 zzzzz => new hvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.bbbbb swizzling (equivalent to hvec4.zzzzz).
        /// </summary>
        public hvec5 bbbbb => new hvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.zzzzw swizzling.
        /// </summary>
        public hvec5 zzzzw => new hvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.bbbba swizzling (equivalent to hvec4.zzzzw).
        /// </summary>
        public hvec5 bbbba => new hvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.zzzw swizzling.
        /// </summary>
        public hvec4 zzzw => new hvec4(z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.bbba swizzling (equivalent to hvec4.zzzw).
        /// </summary>
        public hvec4 bbba => new hvec4(z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.zzzwx swizzling.
        /// </summary>
        public hvec5 zzzwx => new hvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.bbbar swizzling (equivalent to hvec4.zzzwx).
        /// </summary>
        public hvec5 bbbar => new hvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.zzzwy swizzling.
        /// </summary>
        public hvec5 zzzwy => new hvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.bbbag swizzling (equivalent to hvec4.zzzwy).
        /// </summary>
        public hvec5 bbbag => new hvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.zzzwz swizzling.
        /// </summary>
        public hvec5 zzzwz => new hvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.bbbab swizzling (equivalent to hvec4.zzzwz).
        /// </summary>
        public hvec5 bbbab => new hvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.zzzww swizzling.
        /// </summary>
        public hvec5 zzzww => new hvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.bbbaa swizzling (equivalent to hvec4.zzzww).
        /// </summary>
        public hvec5 bbbaa => new hvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.zzw swizzling.
        /// </summary>
        public hvec3 zzw => new hvec3(z, z, w);
        
        /// <summary>
        /// Returns hvec4.bba swizzling (equivalent to hvec4.zzw).
        /// </summary>
        public hvec3 bba => new hvec3(z, z, w);
        
        /// <summary>
        /// Returns hvec4.zzwx swizzling.
        /// </summary>
        public hvec4 zzwx => new hvec4(z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.bbar swizzling (equivalent to hvec4.zzwx).
        /// </summary>
        public hvec4 bbar => new hvec4(z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.zzwxx swizzling.
        /// </summary>
        public hvec5 zzwxx => new hvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.bbarr swizzling (equivalent to hvec4.zzwxx).
        /// </summary>
        public hvec5 bbarr => new hvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.zzwxy swizzling.
        /// </summary>
        public hvec5 zzwxy => new hvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.bbarg swizzling (equivalent to hvec4.zzwxy).
        /// </summary>
        public hvec5 bbarg => new hvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.zzwxz swizzling.
        /// </summary>
        public hvec5 zzwxz => new hvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.bbarb swizzling (equivalent to hvec4.zzwxz).
        /// </summary>
        public hvec5 bbarb => new hvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.zzwxw swizzling.
        /// </summary>
        public hvec5 zzwxw => new hvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.bbara swizzling (equivalent to hvec4.zzwxw).
        /// </summary>
        public hvec5 bbara => new hvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.zzwy swizzling.
        /// </summary>
        public hvec4 zzwy => new hvec4(z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.bbag swizzling (equivalent to hvec4.zzwy).
        /// </summary>
        public hvec4 bbag => new hvec4(z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.zzwyx swizzling.
        /// </summary>
        public hvec5 zzwyx => new hvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.bbagr swizzling (equivalent to hvec4.zzwyx).
        /// </summary>
        public hvec5 bbagr => new hvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.zzwyy swizzling.
        /// </summary>
        public hvec5 zzwyy => new hvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.bbagg swizzling (equivalent to hvec4.zzwyy).
        /// </summary>
        public hvec5 bbagg => new hvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.zzwyz swizzling.
        /// </summary>
        public hvec5 zzwyz => new hvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.bbagb swizzling (equivalent to hvec4.zzwyz).
        /// </summary>
        public hvec5 bbagb => new hvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.zzwyw swizzling.
        /// </summary>
        public hvec5 zzwyw => new hvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.bbaga swizzling (equivalent to hvec4.zzwyw).
        /// </summary>
        public hvec5 bbaga => new hvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.zzwz swizzling.
        /// </summary>
        public hvec4 zzwz => new hvec4(z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.bbab swizzling (equivalent to hvec4.zzwz).
        /// </summary>
        public hvec4 bbab => new hvec4(z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.zzwzx swizzling.
        /// </summary>
        public hvec5 zzwzx => new hvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.bbabr swizzling (equivalent to hvec4.zzwzx).
        /// </summary>
        public hvec5 bbabr => new hvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.zzwzy swizzling.
        /// </summary>
        public hvec5 zzwzy => new hvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.bbabg swizzling (equivalent to hvec4.zzwzy).
        /// </summary>
        public hvec5 bbabg => new hvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.zzwzz swizzling.
        /// </summary>
        public hvec5 zzwzz => new hvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.bbabb swizzling (equivalent to hvec4.zzwzz).
        /// </summary>
        public hvec5 bbabb => new hvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.zzwzw swizzling.
        /// </summary>
        public hvec5 zzwzw => new hvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.bbaba swizzling (equivalent to hvec4.zzwzw).
        /// </summary>
        public hvec5 bbaba => new hvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.zzww swizzling.
        /// </summary>
        public hvec4 zzww => new hvec4(z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.bbaa swizzling (equivalent to hvec4.zzww).
        /// </summary>
        public hvec4 bbaa => new hvec4(z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.zzwwx swizzling.
        /// </summary>
        public hvec5 zzwwx => new hvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.bbaar swizzling (equivalent to hvec4.zzwwx).
        /// </summary>
        public hvec5 bbaar => new hvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.zzwwy swizzling.
        /// </summary>
        public hvec5 zzwwy => new hvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.bbaag swizzling (equivalent to hvec4.zzwwy).
        /// </summary>
        public hvec5 bbaag => new hvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.zzwwz swizzling.
        /// </summary>
        public hvec5 zzwwz => new hvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.bbaab swizzling (equivalent to hvec4.zzwwz).
        /// </summary>
        public hvec5 bbaab => new hvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.zzwww swizzling.
        /// </summary>
        public hvec5 zzwww => new hvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.bbaaa swizzling (equivalent to hvec4.zzwww).
        /// </summary>
        public hvec5 bbaaa => new hvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.zw swizzling.
        /// </summary>
        public hvec2 zw => new hvec2(z, w);
        
        /// <summary>
        /// Returns hvec4.ba swizzling (equivalent to hvec4.zw).
        /// </summary>
        public hvec2 ba => new hvec2(z, w);
        
        /// <summary>
        /// Returns hvec4.zwx swizzling.
        /// </summary>
        public hvec3 zwx => new hvec3(z, w, x);
        
        /// <summary>
        /// Returns hvec4.bar swizzling (equivalent to hvec4.zwx).
        /// </summary>
        public hvec3 bar => new hvec3(z, w, x);
        
        /// <summary>
        /// Returns hvec4.zwxx swizzling.
        /// </summary>
        public hvec4 zwxx => new hvec4(z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.barr swizzling (equivalent to hvec4.zwxx).
        /// </summary>
        public hvec4 barr => new hvec4(z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.zwxxx swizzling.
        /// </summary>
        public hvec5 zwxxx => new hvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.barrr swizzling (equivalent to hvec4.zwxxx).
        /// </summary>
        public hvec5 barrr => new hvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.zwxxy swizzling.
        /// </summary>
        public hvec5 zwxxy => new hvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.barrg swizzling (equivalent to hvec4.zwxxy).
        /// </summary>
        public hvec5 barrg => new hvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.zwxxz swizzling.
        /// </summary>
        public hvec5 zwxxz => new hvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.barrb swizzling (equivalent to hvec4.zwxxz).
        /// </summary>
        public hvec5 barrb => new hvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.zwxxw swizzling.
        /// </summary>
        public hvec5 zwxxw => new hvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.barra swizzling (equivalent to hvec4.zwxxw).
        /// </summary>
        public hvec5 barra => new hvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.zwxy swizzling.
        /// </summary>
        public hvec4 zwxy => new hvec4(z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.barg swizzling (equivalent to hvec4.zwxy).
        /// </summary>
        public hvec4 barg => new hvec4(z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.zwxyx swizzling.
        /// </summary>
        public hvec5 zwxyx => new hvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.bargr swizzling (equivalent to hvec4.zwxyx).
        /// </summary>
        public hvec5 bargr => new hvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.zwxyy swizzling.
        /// </summary>
        public hvec5 zwxyy => new hvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.bargg swizzling (equivalent to hvec4.zwxyy).
        /// </summary>
        public hvec5 bargg => new hvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.zwxyz swizzling.
        /// </summary>
        public hvec5 zwxyz => new hvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.bargb swizzling (equivalent to hvec4.zwxyz).
        /// </summary>
        public hvec5 bargb => new hvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.zwxyw swizzling.
        /// </summary>
        public hvec5 zwxyw => new hvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.barga swizzling (equivalent to hvec4.zwxyw).
        /// </summary>
        public hvec5 barga => new hvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.zwxz swizzling.
        /// </summary>
        public hvec4 zwxz => new hvec4(z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.barb swizzling (equivalent to hvec4.zwxz).
        /// </summary>
        public hvec4 barb => new hvec4(z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.zwxzx swizzling.
        /// </summary>
        public hvec5 zwxzx => new hvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.barbr swizzling (equivalent to hvec4.zwxzx).
        /// </summary>
        public hvec5 barbr => new hvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.zwxzy swizzling.
        /// </summary>
        public hvec5 zwxzy => new hvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.barbg swizzling (equivalent to hvec4.zwxzy).
        /// </summary>
        public hvec5 barbg => new hvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.zwxzz swizzling.
        /// </summary>
        public hvec5 zwxzz => new hvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.barbb swizzling (equivalent to hvec4.zwxzz).
        /// </summary>
        public hvec5 barbb => new hvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.zwxzw swizzling.
        /// </summary>
        public hvec5 zwxzw => new hvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.barba swizzling (equivalent to hvec4.zwxzw).
        /// </summary>
        public hvec5 barba => new hvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.zwxw swizzling.
        /// </summary>
        public hvec4 zwxw => new hvec4(z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.bara swizzling (equivalent to hvec4.zwxw).
        /// </summary>
        public hvec4 bara => new hvec4(z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.zwxwx swizzling.
        /// </summary>
        public hvec5 zwxwx => new hvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.barar swizzling (equivalent to hvec4.zwxwx).
        /// </summary>
        public hvec5 barar => new hvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.zwxwy swizzling.
        /// </summary>
        public hvec5 zwxwy => new hvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.barag swizzling (equivalent to hvec4.zwxwy).
        /// </summary>
        public hvec5 barag => new hvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.zwxwz swizzling.
        /// </summary>
        public hvec5 zwxwz => new hvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.barab swizzling (equivalent to hvec4.zwxwz).
        /// </summary>
        public hvec5 barab => new hvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.zwxww swizzling.
        /// </summary>
        public hvec5 zwxww => new hvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.baraa swizzling (equivalent to hvec4.zwxww).
        /// </summary>
        public hvec5 baraa => new hvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.zwy swizzling.
        /// </summary>
        public hvec3 zwy => new hvec3(z, w, y);
        
        /// <summary>
        /// Returns hvec4.bag swizzling (equivalent to hvec4.zwy).
        /// </summary>
        public hvec3 bag => new hvec3(z, w, y);
        
        /// <summary>
        /// Returns hvec4.zwyx swizzling.
        /// </summary>
        public hvec4 zwyx => new hvec4(z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.bagr swizzling (equivalent to hvec4.zwyx).
        /// </summary>
        public hvec4 bagr => new hvec4(z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.zwyxx swizzling.
        /// </summary>
        public hvec5 zwyxx => new hvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.bagrr swizzling (equivalent to hvec4.zwyxx).
        /// </summary>
        public hvec5 bagrr => new hvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.zwyxy swizzling.
        /// </summary>
        public hvec5 zwyxy => new hvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.bagrg swizzling (equivalent to hvec4.zwyxy).
        /// </summary>
        public hvec5 bagrg => new hvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.zwyxz swizzling.
        /// </summary>
        public hvec5 zwyxz => new hvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.bagrb swizzling (equivalent to hvec4.zwyxz).
        /// </summary>
        public hvec5 bagrb => new hvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.zwyxw swizzling.
        /// </summary>
        public hvec5 zwyxw => new hvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.bagra swizzling (equivalent to hvec4.zwyxw).
        /// </summary>
        public hvec5 bagra => new hvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.zwyy swizzling.
        /// </summary>
        public hvec4 zwyy => new hvec4(z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.bagg swizzling (equivalent to hvec4.zwyy).
        /// </summary>
        public hvec4 bagg => new hvec4(z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.zwyyx swizzling.
        /// </summary>
        public hvec5 zwyyx => new hvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.baggr swizzling (equivalent to hvec4.zwyyx).
        /// </summary>
        public hvec5 baggr => new hvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.zwyyy swizzling.
        /// </summary>
        public hvec5 zwyyy => new hvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.baggg swizzling (equivalent to hvec4.zwyyy).
        /// </summary>
        public hvec5 baggg => new hvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.zwyyz swizzling.
        /// </summary>
        public hvec5 zwyyz => new hvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.baggb swizzling (equivalent to hvec4.zwyyz).
        /// </summary>
        public hvec5 baggb => new hvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.zwyyw swizzling.
        /// </summary>
        public hvec5 zwyyw => new hvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.bagga swizzling (equivalent to hvec4.zwyyw).
        /// </summary>
        public hvec5 bagga => new hvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.zwyz swizzling.
        /// </summary>
        public hvec4 zwyz => new hvec4(z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.bagb swizzling (equivalent to hvec4.zwyz).
        /// </summary>
        public hvec4 bagb => new hvec4(z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.zwyzx swizzling.
        /// </summary>
        public hvec5 zwyzx => new hvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.bagbr swizzling (equivalent to hvec4.zwyzx).
        /// </summary>
        public hvec5 bagbr => new hvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.zwyzy swizzling.
        /// </summary>
        public hvec5 zwyzy => new hvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.bagbg swizzling (equivalent to hvec4.zwyzy).
        /// </summary>
        public hvec5 bagbg => new hvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.zwyzz swizzling.
        /// </summary>
        public hvec5 zwyzz => new hvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.bagbb swizzling (equivalent to hvec4.zwyzz).
        /// </summary>
        public hvec5 bagbb => new hvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.zwyzw swizzling.
        /// </summary>
        public hvec5 zwyzw => new hvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.bagba swizzling (equivalent to hvec4.zwyzw).
        /// </summary>
        public hvec5 bagba => new hvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.zwyw swizzling.
        /// </summary>
        public hvec4 zwyw => new hvec4(z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.baga swizzling (equivalent to hvec4.zwyw).
        /// </summary>
        public hvec4 baga => new hvec4(z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.zwywx swizzling.
        /// </summary>
        public hvec5 zwywx => new hvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.bagar swizzling (equivalent to hvec4.zwywx).
        /// </summary>
        public hvec5 bagar => new hvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.zwywy swizzling.
        /// </summary>
        public hvec5 zwywy => new hvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.bagag swizzling (equivalent to hvec4.zwywy).
        /// </summary>
        public hvec5 bagag => new hvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.zwywz swizzling.
        /// </summary>
        public hvec5 zwywz => new hvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.bagab swizzling (equivalent to hvec4.zwywz).
        /// </summary>
        public hvec5 bagab => new hvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.zwyww swizzling.
        /// </summary>
        public hvec5 zwyww => new hvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.bagaa swizzling (equivalent to hvec4.zwyww).
        /// </summary>
        public hvec5 bagaa => new hvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.zwz swizzling.
        /// </summary>
        public hvec3 zwz => new hvec3(z, w, z);
        
        /// <summary>
        /// Returns hvec4.bab swizzling (equivalent to hvec4.zwz).
        /// </summary>
        public hvec3 bab => new hvec3(z, w, z);
        
        /// <summary>
        /// Returns hvec4.zwzx swizzling.
        /// </summary>
        public hvec4 zwzx => new hvec4(z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.babr swizzling (equivalent to hvec4.zwzx).
        /// </summary>
        public hvec4 babr => new hvec4(z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.zwzxx swizzling.
        /// </summary>
        public hvec5 zwzxx => new hvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.babrr swizzling (equivalent to hvec4.zwzxx).
        /// </summary>
        public hvec5 babrr => new hvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.zwzxy swizzling.
        /// </summary>
        public hvec5 zwzxy => new hvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.babrg swizzling (equivalent to hvec4.zwzxy).
        /// </summary>
        public hvec5 babrg => new hvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.zwzxz swizzling.
        /// </summary>
        public hvec5 zwzxz => new hvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.babrb swizzling (equivalent to hvec4.zwzxz).
        /// </summary>
        public hvec5 babrb => new hvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.zwzxw swizzling.
        /// </summary>
        public hvec5 zwzxw => new hvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.babra swizzling (equivalent to hvec4.zwzxw).
        /// </summary>
        public hvec5 babra => new hvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.zwzy swizzling.
        /// </summary>
        public hvec4 zwzy => new hvec4(z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.babg swizzling (equivalent to hvec4.zwzy).
        /// </summary>
        public hvec4 babg => new hvec4(z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.zwzyx swizzling.
        /// </summary>
        public hvec5 zwzyx => new hvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.babgr swizzling (equivalent to hvec4.zwzyx).
        /// </summary>
        public hvec5 babgr => new hvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.zwzyy swizzling.
        /// </summary>
        public hvec5 zwzyy => new hvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.babgg swizzling (equivalent to hvec4.zwzyy).
        /// </summary>
        public hvec5 babgg => new hvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.zwzyz swizzling.
        /// </summary>
        public hvec5 zwzyz => new hvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.babgb swizzling (equivalent to hvec4.zwzyz).
        /// </summary>
        public hvec5 babgb => new hvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.zwzyw swizzling.
        /// </summary>
        public hvec5 zwzyw => new hvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.babga swizzling (equivalent to hvec4.zwzyw).
        /// </summary>
        public hvec5 babga => new hvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.zwzz swizzling.
        /// </summary>
        public hvec4 zwzz => new hvec4(z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.babb swizzling (equivalent to hvec4.zwzz).
        /// </summary>
        public hvec4 babb => new hvec4(z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.zwzzx swizzling.
        /// </summary>
        public hvec5 zwzzx => new hvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.babbr swizzling (equivalent to hvec4.zwzzx).
        /// </summary>
        public hvec5 babbr => new hvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.zwzzy swizzling.
        /// </summary>
        public hvec5 zwzzy => new hvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.babbg swizzling (equivalent to hvec4.zwzzy).
        /// </summary>
        public hvec5 babbg => new hvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.zwzzz swizzling.
        /// </summary>
        public hvec5 zwzzz => new hvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.babbb swizzling (equivalent to hvec4.zwzzz).
        /// </summary>
        public hvec5 babbb => new hvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.zwzzw swizzling.
        /// </summary>
        public hvec5 zwzzw => new hvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.babba swizzling (equivalent to hvec4.zwzzw).
        /// </summary>
        public hvec5 babba => new hvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.zwzw swizzling.
        /// </summary>
        public hvec4 zwzw => new hvec4(z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.baba swizzling (equivalent to hvec4.zwzw).
        /// </summary>
        public hvec4 baba => new hvec4(z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.zwzwx swizzling.
        /// </summary>
        public hvec5 zwzwx => new hvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.babar swizzling (equivalent to hvec4.zwzwx).
        /// </summary>
        public hvec5 babar => new hvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.zwzwy swizzling.
        /// </summary>
        public hvec5 zwzwy => new hvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.babag swizzling (equivalent to hvec4.zwzwy).
        /// </summary>
        public hvec5 babag => new hvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.zwzwz swizzling.
        /// </summary>
        public hvec5 zwzwz => new hvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.babab swizzling (equivalent to hvec4.zwzwz).
        /// </summary>
        public hvec5 babab => new hvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.zwzww swizzling.
        /// </summary>
        public hvec5 zwzww => new hvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.babaa swizzling (equivalent to hvec4.zwzww).
        /// </summary>
        public hvec5 babaa => new hvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.zww swizzling.
        /// </summary>
        public hvec3 zww => new hvec3(z, w, w);
        
        /// <summary>
        /// Returns hvec4.baa swizzling (equivalent to hvec4.zww).
        /// </summary>
        public hvec3 baa => new hvec3(z, w, w);
        
        /// <summary>
        /// Returns hvec4.zwwx swizzling.
        /// </summary>
        public hvec4 zwwx => new hvec4(z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.baar swizzling (equivalent to hvec4.zwwx).
        /// </summary>
        public hvec4 baar => new hvec4(z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.zwwxx swizzling.
        /// </summary>
        public hvec5 zwwxx => new hvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.baarr swizzling (equivalent to hvec4.zwwxx).
        /// </summary>
        public hvec5 baarr => new hvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.zwwxy swizzling.
        /// </summary>
        public hvec5 zwwxy => new hvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.baarg swizzling (equivalent to hvec4.zwwxy).
        /// </summary>
        public hvec5 baarg => new hvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.zwwxz swizzling.
        /// </summary>
        public hvec5 zwwxz => new hvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.baarb swizzling (equivalent to hvec4.zwwxz).
        /// </summary>
        public hvec5 baarb => new hvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.zwwxw swizzling.
        /// </summary>
        public hvec5 zwwxw => new hvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.baara swizzling (equivalent to hvec4.zwwxw).
        /// </summary>
        public hvec5 baara => new hvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.zwwy swizzling.
        /// </summary>
        public hvec4 zwwy => new hvec4(z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.baag swizzling (equivalent to hvec4.zwwy).
        /// </summary>
        public hvec4 baag => new hvec4(z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.zwwyx swizzling.
        /// </summary>
        public hvec5 zwwyx => new hvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.baagr swizzling (equivalent to hvec4.zwwyx).
        /// </summary>
        public hvec5 baagr => new hvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.zwwyy swizzling.
        /// </summary>
        public hvec5 zwwyy => new hvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.baagg swizzling (equivalent to hvec4.zwwyy).
        /// </summary>
        public hvec5 baagg => new hvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.zwwyz swizzling.
        /// </summary>
        public hvec5 zwwyz => new hvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.baagb swizzling (equivalent to hvec4.zwwyz).
        /// </summary>
        public hvec5 baagb => new hvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.zwwyw swizzling.
        /// </summary>
        public hvec5 zwwyw => new hvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.baaga swizzling (equivalent to hvec4.zwwyw).
        /// </summary>
        public hvec5 baaga => new hvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.zwwz swizzling.
        /// </summary>
        public hvec4 zwwz => new hvec4(z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.baab swizzling (equivalent to hvec4.zwwz).
        /// </summary>
        public hvec4 baab => new hvec4(z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.zwwzx swizzling.
        /// </summary>
        public hvec5 zwwzx => new hvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.baabr swizzling (equivalent to hvec4.zwwzx).
        /// </summary>
        public hvec5 baabr => new hvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.zwwzy swizzling.
        /// </summary>
        public hvec5 zwwzy => new hvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.baabg swizzling (equivalent to hvec4.zwwzy).
        /// </summary>
        public hvec5 baabg => new hvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.zwwzz swizzling.
        /// </summary>
        public hvec5 zwwzz => new hvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.baabb swizzling (equivalent to hvec4.zwwzz).
        /// </summary>
        public hvec5 baabb => new hvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.zwwzw swizzling.
        /// </summary>
        public hvec5 zwwzw => new hvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.baaba swizzling (equivalent to hvec4.zwwzw).
        /// </summary>
        public hvec5 baaba => new hvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.zwww swizzling.
        /// </summary>
        public hvec4 zwww => new hvec4(z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.baaa swizzling (equivalent to hvec4.zwww).
        /// </summary>
        public hvec4 baaa => new hvec4(z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.zwwwx swizzling.
        /// </summary>
        public hvec5 zwwwx => new hvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.baaar swizzling (equivalent to hvec4.zwwwx).
        /// </summary>
        public hvec5 baaar => new hvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.zwwwy swizzling.
        /// </summary>
        public hvec5 zwwwy => new hvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.baaag swizzling (equivalent to hvec4.zwwwy).
        /// </summary>
        public hvec5 baaag => new hvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.zwwwz swizzling.
        /// </summary>
        public hvec5 zwwwz => new hvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.baaab swizzling (equivalent to hvec4.zwwwz).
        /// </summary>
        public hvec5 baaab => new hvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.zwwww swizzling.
        /// </summary>
        public hvec5 zwwww => new hvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns hvec4.baaaa swizzling (equivalent to hvec4.zwwww).
        /// </summary>
        public hvec5 baaaa => new hvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns hvec4.wx swizzling.
        /// </summary>
        public hvec2 wx => new hvec2(w, x);
        
        /// <summary>
        /// Returns hvec4.ar swizzling (equivalent to hvec4.wx).
        /// </summary>
        public hvec2 ar => new hvec2(w, x);
        
        /// <summary>
        /// Returns hvec4.wxx swizzling.
        /// </summary>
        public hvec3 wxx => new hvec3(w, x, x);
        
        /// <summary>
        /// Returns hvec4.arr swizzling (equivalent to hvec4.wxx).
        /// </summary>
        public hvec3 arr => new hvec3(w, x, x);
        
        /// <summary>
        /// Returns hvec4.wxxx swizzling.
        /// </summary>
        public hvec4 wxxx => new hvec4(w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.arrr swizzling (equivalent to hvec4.wxxx).
        /// </summary>
        public hvec4 arrr => new hvec4(w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.wxxxx swizzling.
        /// </summary>
        public hvec5 wxxxx => new hvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.arrrr swizzling (equivalent to hvec4.wxxxx).
        /// </summary>
        public hvec5 arrrr => new hvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.wxxxy swizzling.
        /// </summary>
        public hvec5 wxxxy => new hvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.arrrg swizzling (equivalent to hvec4.wxxxy).
        /// </summary>
        public hvec5 arrrg => new hvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.wxxxz swizzling.
        /// </summary>
        public hvec5 wxxxz => new hvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.arrrb swizzling (equivalent to hvec4.wxxxz).
        /// </summary>
        public hvec5 arrrb => new hvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.wxxxw swizzling.
        /// </summary>
        public hvec5 wxxxw => new hvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.arrra swizzling (equivalent to hvec4.wxxxw).
        /// </summary>
        public hvec5 arrra => new hvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.wxxy swizzling.
        /// </summary>
        public hvec4 wxxy => new hvec4(w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.arrg swizzling (equivalent to hvec4.wxxy).
        /// </summary>
        public hvec4 arrg => new hvec4(w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.wxxyx swizzling.
        /// </summary>
        public hvec5 wxxyx => new hvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.arrgr swizzling (equivalent to hvec4.wxxyx).
        /// </summary>
        public hvec5 arrgr => new hvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.wxxyy swizzling.
        /// </summary>
        public hvec5 wxxyy => new hvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.arrgg swizzling (equivalent to hvec4.wxxyy).
        /// </summary>
        public hvec5 arrgg => new hvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.wxxyz swizzling.
        /// </summary>
        public hvec5 wxxyz => new hvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.arrgb swizzling (equivalent to hvec4.wxxyz).
        /// </summary>
        public hvec5 arrgb => new hvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.wxxyw swizzling.
        /// </summary>
        public hvec5 wxxyw => new hvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.arrga swizzling (equivalent to hvec4.wxxyw).
        /// </summary>
        public hvec5 arrga => new hvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.wxxz swizzling.
        /// </summary>
        public hvec4 wxxz => new hvec4(w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.arrb swizzling (equivalent to hvec4.wxxz).
        /// </summary>
        public hvec4 arrb => new hvec4(w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.wxxzx swizzling.
        /// </summary>
        public hvec5 wxxzx => new hvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.arrbr swizzling (equivalent to hvec4.wxxzx).
        /// </summary>
        public hvec5 arrbr => new hvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.wxxzy swizzling.
        /// </summary>
        public hvec5 wxxzy => new hvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.arrbg swizzling (equivalent to hvec4.wxxzy).
        /// </summary>
        public hvec5 arrbg => new hvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.wxxzz swizzling.
        /// </summary>
        public hvec5 wxxzz => new hvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.arrbb swizzling (equivalent to hvec4.wxxzz).
        /// </summary>
        public hvec5 arrbb => new hvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.wxxzw swizzling.
        /// </summary>
        public hvec5 wxxzw => new hvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.arrba swizzling (equivalent to hvec4.wxxzw).
        /// </summary>
        public hvec5 arrba => new hvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.wxxw swizzling.
        /// </summary>
        public hvec4 wxxw => new hvec4(w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.arra swizzling (equivalent to hvec4.wxxw).
        /// </summary>
        public hvec4 arra => new hvec4(w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.wxxwx swizzling.
        /// </summary>
        public hvec5 wxxwx => new hvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.arrar swizzling (equivalent to hvec4.wxxwx).
        /// </summary>
        public hvec5 arrar => new hvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.wxxwy swizzling.
        /// </summary>
        public hvec5 wxxwy => new hvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.arrag swizzling (equivalent to hvec4.wxxwy).
        /// </summary>
        public hvec5 arrag => new hvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.wxxwz swizzling.
        /// </summary>
        public hvec5 wxxwz => new hvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.arrab swizzling (equivalent to hvec4.wxxwz).
        /// </summary>
        public hvec5 arrab => new hvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.wxxww swizzling.
        /// </summary>
        public hvec5 wxxww => new hvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.arraa swizzling (equivalent to hvec4.wxxww).
        /// </summary>
        public hvec5 arraa => new hvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.wxy swizzling.
        /// </summary>
        public hvec3 wxy => new hvec3(w, x, y);
        
        /// <summary>
        /// Returns hvec4.arg swizzling (equivalent to hvec4.wxy).
        /// </summary>
        public hvec3 arg => new hvec3(w, x, y);
        
        /// <summary>
        /// Returns hvec4.wxyx swizzling.
        /// </summary>
        public hvec4 wxyx => new hvec4(w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.argr swizzling (equivalent to hvec4.wxyx).
        /// </summary>
        public hvec4 argr => new hvec4(w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.wxyxx swizzling.
        /// </summary>
        public hvec5 wxyxx => new hvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.argrr swizzling (equivalent to hvec4.wxyxx).
        /// </summary>
        public hvec5 argrr => new hvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.wxyxy swizzling.
        /// </summary>
        public hvec5 wxyxy => new hvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.argrg swizzling (equivalent to hvec4.wxyxy).
        /// </summary>
        public hvec5 argrg => new hvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.wxyxz swizzling.
        /// </summary>
        public hvec5 wxyxz => new hvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.argrb swizzling (equivalent to hvec4.wxyxz).
        /// </summary>
        public hvec5 argrb => new hvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.wxyxw swizzling.
        /// </summary>
        public hvec5 wxyxw => new hvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.argra swizzling (equivalent to hvec4.wxyxw).
        /// </summary>
        public hvec5 argra => new hvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.wxyy swizzling.
        /// </summary>
        public hvec4 wxyy => new hvec4(w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.argg swizzling (equivalent to hvec4.wxyy).
        /// </summary>
        public hvec4 argg => new hvec4(w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.wxyyx swizzling.
        /// </summary>
        public hvec5 wxyyx => new hvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.arggr swizzling (equivalent to hvec4.wxyyx).
        /// </summary>
        public hvec5 arggr => new hvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.wxyyy swizzling.
        /// </summary>
        public hvec5 wxyyy => new hvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.arggg swizzling (equivalent to hvec4.wxyyy).
        /// </summary>
        public hvec5 arggg => new hvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.wxyyz swizzling.
        /// </summary>
        public hvec5 wxyyz => new hvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.arggb swizzling (equivalent to hvec4.wxyyz).
        /// </summary>
        public hvec5 arggb => new hvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.wxyyw swizzling.
        /// </summary>
        public hvec5 wxyyw => new hvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.argga swizzling (equivalent to hvec4.wxyyw).
        /// </summary>
        public hvec5 argga => new hvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.wxyz swizzling.
        /// </summary>
        public hvec4 wxyz => new hvec4(w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.argb swizzling (equivalent to hvec4.wxyz).
        /// </summary>
        public hvec4 argb => new hvec4(w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.wxyzx swizzling.
        /// </summary>
        public hvec5 wxyzx => new hvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.argbr swizzling (equivalent to hvec4.wxyzx).
        /// </summary>
        public hvec5 argbr => new hvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.wxyzy swizzling.
        /// </summary>
        public hvec5 wxyzy => new hvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.argbg swizzling (equivalent to hvec4.wxyzy).
        /// </summary>
        public hvec5 argbg => new hvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.wxyzz swizzling.
        /// </summary>
        public hvec5 wxyzz => new hvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.argbb swizzling (equivalent to hvec4.wxyzz).
        /// </summary>
        public hvec5 argbb => new hvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.wxyzw swizzling.
        /// </summary>
        public hvec5 wxyzw => new hvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.argba swizzling (equivalent to hvec4.wxyzw).
        /// </summary>
        public hvec5 argba => new hvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.wxyw swizzling.
        /// </summary>
        public hvec4 wxyw => new hvec4(w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.arga swizzling (equivalent to hvec4.wxyw).
        /// </summary>
        public hvec4 arga => new hvec4(w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.wxywx swizzling.
        /// </summary>
        public hvec5 wxywx => new hvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.argar swizzling (equivalent to hvec4.wxywx).
        /// </summary>
        public hvec5 argar => new hvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.wxywy swizzling.
        /// </summary>
        public hvec5 wxywy => new hvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.argag swizzling (equivalent to hvec4.wxywy).
        /// </summary>
        public hvec5 argag => new hvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.wxywz swizzling.
        /// </summary>
        public hvec5 wxywz => new hvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.argab swizzling (equivalent to hvec4.wxywz).
        /// </summary>
        public hvec5 argab => new hvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.wxyww swizzling.
        /// </summary>
        public hvec5 wxyww => new hvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.argaa swizzling (equivalent to hvec4.wxyww).
        /// </summary>
        public hvec5 argaa => new hvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.wxz swizzling.
        /// </summary>
        public hvec3 wxz => new hvec3(w, x, z);
        
        /// <summary>
        /// Returns hvec4.arb swizzling (equivalent to hvec4.wxz).
        /// </summary>
        public hvec3 arb => new hvec3(w, x, z);
        
        /// <summary>
        /// Returns hvec4.wxzx swizzling.
        /// </summary>
        public hvec4 wxzx => new hvec4(w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.arbr swizzling (equivalent to hvec4.wxzx).
        /// </summary>
        public hvec4 arbr => new hvec4(w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.wxzxx swizzling.
        /// </summary>
        public hvec5 wxzxx => new hvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.arbrr swizzling (equivalent to hvec4.wxzxx).
        /// </summary>
        public hvec5 arbrr => new hvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.wxzxy swizzling.
        /// </summary>
        public hvec5 wxzxy => new hvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.arbrg swizzling (equivalent to hvec4.wxzxy).
        /// </summary>
        public hvec5 arbrg => new hvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.wxzxz swizzling.
        /// </summary>
        public hvec5 wxzxz => new hvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.arbrb swizzling (equivalent to hvec4.wxzxz).
        /// </summary>
        public hvec5 arbrb => new hvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.wxzxw swizzling.
        /// </summary>
        public hvec5 wxzxw => new hvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.arbra swizzling (equivalent to hvec4.wxzxw).
        /// </summary>
        public hvec5 arbra => new hvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.wxzy swizzling.
        /// </summary>
        public hvec4 wxzy => new hvec4(w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.arbg swizzling (equivalent to hvec4.wxzy).
        /// </summary>
        public hvec4 arbg => new hvec4(w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.wxzyx swizzling.
        /// </summary>
        public hvec5 wxzyx => new hvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.arbgr swizzling (equivalent to hvec4.wxzyx).
        /// </summary>
        public hvec5 arbgr => new hvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.wxzyy swizzling.
        /// </summary>
        public hvec5 wxzyy => new hvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.arbgg swizzling (equivalent to hvec4.wxzyy).
        /// </summary>
        public hvec5 arbgg => new hvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.wxzyz swizzling.
        /// </summary>
        public hvec5 wxzyz => new hvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.arbgb swizzling (equivalent to hvec4.wxzyz).
        /// </summary>
        public hvec5 arbgb => new hvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.wxzyw swizzling.
        /// </summary>
        public hvec5 wxzyw => new hvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.arbga swizzling (equivalent to hvec4.wxzyw).
        /// </summary>
        public hvec5 arbga => new hvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.wxzz swizzling.
        /// </summary>
        public hvec4 wxzz => new hvec4(w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.arbb swizzling (equivalent to hvec4.wxzz).
        /// </summary>
        public hvec4 arbb => new hvec4(w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.wxzzx swizzling.
        /// </summary>
        public hvec5 wxzzx => new hvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.arbbr swizzling (equivalent to hvec4.wxzzx).
        /// </summary>
        public hvec5 arbbr => new hvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.wxzzy swizzling.
        /// </summary>
        public hvec5 wxzzy => new hvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.arbbg swizzling (equivalent to hvec4.wxzzy).
        /// </summary>
        public hvec5 arbbg => new hvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.wxzzz swizzling.
        /// </summary>
        public hvec5 wxzzz => new hvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.arbbb swizzling (equivalent to hvec4.wxzzz).
        /// </summary>
        public hvec5 arbbb => new hvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.wxzzw swizzling.
        /// </summary>
        public hvec5 wxzzw => new hvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.arbba swizzling (equivalent to hvec4.wxzzw).
        /// </summary>
        public hvec5 arbba => new hvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.wxzw swizzling.
        /// </summary>
        public hvec4 wxzw => new hvec4(w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.arba swizzling (equivalent to hvec4.wxzw).
        /// </summary>
        public hvec4 arba => new hvec4(w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.wxzwx swizzling.
        /// </summary>
        public hvec5 wxzwx => new hvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.arbar swizzling (equivalent to hvec4.wxzwx).
        /// </summary>
        public hvec5 arbar => new hvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.wxzwy swizzling.
        /// </summary>
        public hvec5 wxzwy => new hvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.arbag swizzling (equivalent to hvec4.wxzwy).
        /// </summary>
        public hvec5 arbag => new hvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.wxzwz swizzling.
        /// </summary>
        public hvec5 wxzwz => new hvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.arbab swizzling (equivalent to hvec4.wxzwz).
        /// </summary>
        public hvec5 arbab => new hvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.wxzww swizzling.
        /// </summary>
        public hvec5 wxzww => new hvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.arbaa swizzling (equivalent to hvec4.wxzww).
        /// </summary>
        public hvec5 arbaa => new hvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.wxw swizzling.
        /// </summary>
        public hvec3 wxw => new hvec3(w, x, w);
        
        /// <summary>
        /// Returns hvec4.ara swizzling (equivalent to hvec4.wxw).
        /// </summary>
        public hvec3 ara => new hvec3(w, x, w);
        
        /// <summary>
        /// Returns hvec4.wxwx swizzling.
        /// </summary>
        public hvec4 wxwx => new hvec4(w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.arar swizzling (equivalent to hvec4.wxwx).
        /// </summary>
        public hvec4 arar => new hvec4(w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.wxwxx swizzling.
        /// </summary>
        public hvec5 wxwxx => new hvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.ararr swizzling (equivalent to hvec4.wxwxx).
        /// </summary>
        public hvec5 ararr => new hvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.wxwxy swizzling.
        /// </summary>
        public hvec5 wxwxy => new hvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.ararg swizzling (equivalent to hvec4.wxwxy).
        /// </summary>
        public hvec5 ararg => new hvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.wxwxz swizzling.
        /// </summary>
        public hvec5 wxwxz => new hvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.ararb swizzling (equivalent to hvec4.wxwxz).
        /// </summary>
        public hvec5 ararb => new hvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.wxwxw swizzling.
        /// </summary>
        public hvec5 wxwxw => new hvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.arara swizzling (equivalent to hvec4.wxwxw).
        /// </summary>
        public hvec5 arara => new hvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.wxwy swizzling.
        /// </summary>
        public hvec4 wxwy => new hvec4(w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.arag swizzling (equivalent to hvec4.wxwy).
        /// </summary>
        public hvec4 arag => new hvec4(w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.wxwyx swizzling.
        /// </summary>
        public hvec5 wxwyx => new hvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.aragr swizzling (equivalent to hvec4.wxwyx).
        /// </summary>
        public hvec5 aragr => new hvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.wxwyy swizzling.
        /// </summary>
        public hvec5 wxwyy => new hvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.aragg swizzling (equivalent to hvec4.wxwyy).
        /// </summary>
        public hvec5 aragg => new hvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.wxwyz swizzling.
        /// </summary>
        public hvec5 wxwyz => new hvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.aragb swizzling (equivalent to hvec4.wxwyz).
        /// </summary>
        public hvec5 aragb => new hvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.wxwyw swizzling.
        /// </summary>
        public hvec5 wxwyw => new hvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.araga swizzling (equivalent to hvec4.wxwyw).
        /// </summary>
        public hvec5 araga => new hvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.wxwz swizzling.
        /// </summary>
        public hvec4 wxwz => new hvec4(w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.arab swizzling (equivalent to hvec4.wxwz).
        /// </summary>
        public hvec4 arab => new hvec4(w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.wxwzx swizzling.
        /// </summary>
        public hvec5 wxwzx => new hvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.arabr swizzling (equivalent to hvec4.wxwzx).
        /// </summary>
        public hvec5 arabr => new hvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.wxwzy swizzling.
        /// </summary>
        public hvec5 wxwzy => new hvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.arabg swizzling (equivalent to hvec4.wxwzy).
        /// </summary>
        public hvec5 arabg => new hvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.wxwzz swizzling.
        /// </summary>
        public hvec5 wxwzz => new hvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.arabb swizzling (equivalent to hvec4.wxwzz).
        /// </summary>
        public hvec5 arabb => new hvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.wxwzw swizzling.
        /// </summary>
        public hvec5 wxwzw => new hvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.araba swizzling (equivalent to hvec4.wxwzw).
        /// </summary>
        public hvec5 araba => new hvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.wxww swizzling.
        /// </summary>
        public hvec4 wxww => new hvec4(w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.araa swizzling (equivalent to hvec4.wxww).
        /// </summary>
        public hvec4 araa => new hvec4(w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.wxwwx swizzling.
        /// </summary>
        public hvec5 wxwwx => new hvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.araar swizzling (equivalent to hvec4.wxwwx).
        /// </summary>
        public hvec5 araar => new hvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.wxwwy swizzling.
        /// </summary>
        public hvec5 wxwwy => new hvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.araag swizzling (equivalent to hvec4.wxwwy).
        /// </summary>
        public hvec5 araag => new hvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.wxwwz swizzling.
        /// </summary>
        public hvec5 wxwwz => new hvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.araab swizzling (equivalent to hvec4.wxwwz).
        /// </summary>
        public hvec5 araab => new hvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.wxwww swizzling.
        /// </summary>
        public hvec5 wxwww => new hvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.araaa swizzling (equivalent to hvec4.wxwww).
        /// </summary>
        public hvec5 araaa => new hvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.wy swizzling.
        /// </summary>
        public hvec2 wy => new hvec2(w, y);
        
        /// <summary>
        /// Returns hvec4.ag swizzling (equivalent to hvec4.wy).
        /// </summary>
        public hvec2 ag => new hvec2(w, y);
        
        /// <summary>
        /// Returns hvec4.wyx swizzling.
        /// </summary>
        public hvec3 wyx => new hvec3(w, y, x);
        
        /// <summary>
        /// Returns hvec4.agr swizzling (equivalent to hvec4.wyx).
        /// </summary>
        public hvec3 agr => new hvec3(w, y, x);
        
        /// <summary>
        /// Returns hvec4.wyxx swizzling.
        /// </summary>
        public hvec4 wyxx => new hvec4(w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.agrr swizzling (equivalent to hvec4.wyxx).
        /// </summary>
        public hvec4 agrr => new hvec4(w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.wyxxx swizzling.
        /// </summary>
        public hvec5 wyxxx => new hvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.agrrr swizzling (equivalent to hvec4.wyxxx).
        /// </summary>
        public hvec5 agrrr => new hvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.wyxxy swizzling.
        /// </summary>
        public hvec5 wyxxy => new hvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.agrrg swizzling (equivalent to hvec4.wyxxy).
        /// </summary>
        public hvec5 agrrg => new hvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.wyxxz swizzling.
        /// </summary>
        public hvec5 wyxxz => new hvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.agrrb swizzling (equivalent to hvec4.wyxxz).
        /// </summary>
        public hvec5 agrrb => new hvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.wyxxw swizzling.
        /// </summary>
        public hvec5 wyxxw => new hvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.agrra swizzling (equivalent to hvec4.wyxxw).
        /// </summary>
        public hvec5 agrra => new hvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.wyxy swizzling.
        /// </summary>
        public hvec4 wyxy => new hvec4(w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.agrg swizzling (equivalent to hvec4.wyxy).
        /// </summary>
        public hvec4 agrg => new hvec4(w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.wyxyx swizzling.
        /// </summary>
        public hvec5 wyxyx => new hvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.agrgr swizzling (equivalent to hvec4.wyxyx).
        /// </summary>
        public hvec5 agrgr => new hvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.wyxyy swizzling.
        /// </summary>
        public hvec5 wyxyy => new hvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.agrgg swizzling (equivalent to hvec4.wyxyy).
        /// </summary>
        public hvec5 agrgg => new hvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.wyxyz swizzling.
        /// </summary>
        public hvec5 wyxyz => new hvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.agrgb swizzling (equivalent to hvec4.wyxyz).
        /// </summary>
        public hvec5 agrgb => new hvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.wyxyw swizzling.
        /// </summary>
        public hvec5 wyxyw => new hvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.agrga swizzling (equivalent to hvec4.wyxyw).
        /// </summary>
        public hvec5 agrga => new hvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.wyxz swizzling.
        /// </summary>
        public hvec4 wyxz => new hvec4(w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.agrb swizzling (equivalent to hvec4.wyxz).
        /// </summary>
        public hvec4 agrb => new hvec4(w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.wyxzx swizzling.
        /// </summary>
        public hvec5 wyxzx => new hvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.agrbr swizzling (equivalent to hvec4.wyxzx).
        /// </summary>
        public hvec5 agrbr => new hvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.wyxzy swizzling.
        /// </summary>
        public hvec5 wyxzy => new hvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.agrbg swizzling (equivalent to hvec4.wyxzy).
        /// </summary>
        public hvec5 agrbg => new hvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.wyxzz swizzling.
        /// </summary>
        public hvec5 wyxzz => new hvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.agrbb swizzling (equivalent to hvec4.wyxzz).
        /// </summary>
        public hvec5 agrbb => new hvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.wyxzw swizzling.
        /// </summary>
        public hvec5 wyxzw => new hvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.agrba swizzling (equivalent to hvec4.wyxzw).
        /// </summary>
        public hvec5 agrba => new hvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.wyxw swizzling.
        /// </summary>
        public hvec4 wyxw => new hvec4(w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.agra swizzling (equivalent to hvec4.wyxw).
        /// </summary>
        public hvec4 agra => new hvec4(w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.wyxwx swizzling.
        /// </summary>
        public hvec5 wyxwx => new hvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.agrar swizzling (equivalent to hvec4.wyxwx).
        /// </summary>
        public hvec5 agrar => new hvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.wyxwy swizzling.
        /// </summary>
        public hvec5 wyxwy => new hvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.agrag swizzling (equivalent to hvec4.wyxwy).
        /// </summary>
        public hvec5 agrag => new hvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.wyxwz swizzling.
        /// </summary>
        public hvec5 wyxwz => new hvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.agrab swizzling (equivalent to hvec4.wyxwz).
        /// </summary>
        public hvec5 agrab => new hvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.wyxww swizzling.
        /// </summary>
        public hvec5 wyxww => new hvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.agraa swizzling (equivalent to hvec4.wyxww).
        /// </summary>
        public hvec5 agraa => new hvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.wyy swizzling.
        /// </summary>
        public hvec3 wyy => new hvec3(w, y, y);
        
        /// <summary>
        /// Returns hvec4.agg swizzling (equivalent to hvec4.wyy).
        /// </summary>
        public hvec3 agg => new hvec3(w, y, y);
        
        /// <summary>
        /// Returns hvec4.wyyx swizzling.
        /// </summary>
        public hvec4 wyyx => new hvec4(w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.aggr swizzling (equivalent to hvec4.wyyx).
        /// </summary>
        public hvec4 aggr => new hvec4(w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.wyyxx swizzling.
        /// </summary>
        public hvec5 wyyxx => new hvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.aggrr swizzling (equivalent to hvec4.wyyxx).
        /// </summary>
        public hvec5 aggrr => new hvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.wyyxy swizzling.
        /// </summary>
        public hvec5 wyyxy => new hvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.aggrg swizzling (equivalent to hvec4.wyyxy).
        /// </summary>
        public hvec5 aggrg => new hvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.wyyxz swizzling.
        /// </summary>
        public hvec5 wyyxz => new hvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.aggrb swizzling (equivalent to hvec4.wyyxz).
        /// </summary>
        public hvec5 aggrb => new hvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.wyyxw swizzling.
        /// </summary>
        public hvec5 wyyxw => new hvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.aggra swizzling (equivalent to hvec4.wyyxw).
        /// </summary>
        public hvec5 aggra => new hvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.wyyy swizzling.
        /// </summary>
        public hvec4 wyyy => new hvec4(w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.aggg swizzling (equivalent to hvec4.wyyy).
        /// </summary>
        public hvec4 aggg => new hvec4(w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.wyyyx swizzling.
        /// </summary>
        public hvec5 wyyyx => new hvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.agggr swizzling (equivalent to hvec4.wyyyx).
        /// </summary>
        public hvec5 agggr => new hvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.wyyyy swizzling.
        /// </summary>
        public hvec5 wyyyy => new hvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.agggg swizzling (equivalent to hvec4.wyyyy).
        /// </summary>
        public hvec5 agggg => new hvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.wyyyz swizzling.
        /// </summary>
        public hvec5 wyyyz => new hvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.agggb swizzling (equivalent to hvec4.wyyyz).
        /// </summary>
        public hvec5 agggb => new hvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.wyyyw swizzling.
        /// </summary>
        public hvec5 wyyyw => new hvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.aggga swizzling (equivalent to hvec4.wyyyw).
        /// </summary>
        public hvec5 aggga => new hvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.wyyz swizzling.
        /// </summary>
        public hvec4 wyyz => new hvec4(w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.aggb swizzling (equivalent to hvec4.wyyz).
        /// </summary>
        public hvec4 aggb => new hvec4(w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.wyyzx swizzling.
        /// </summary>
        public hvec5 wyyzx => new hvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.aggbr swizzling (equivalent to hvec4.wyyzx).
        /// </summary>
        public hvec5 aggbr => new hvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.wyyzy swizzling.
        /// </summary>
        public hvec5 wyyzy => new hvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.aggbg swizzling (equivalent to hvec4.wyyzy).
        /// </summary>
        public hvec5 aggbg => new hvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.wyyzz swizzling.
        /// </summary>
        public hvec5 wyyzz => new hvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.aggbb swizzling (equivalent to hvec4.wyyzz).
        /// </summary>
        public hvec5 aggbb => new hvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.wyyzw swizzling.
        /// </summary>
        public hvec5 wyyzw => new hvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.aggba swizzling (equivalent to hvec4.wyyzw).
        /// </summary>
        public hvec5 aggba => new hvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.wyyw swizzling.
        /// </summary>
        public hvec4 wyyw => new hvec4(w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.agga swizzling (equivalent to hvec4.wyyw).
        /// </summary>
        public hvec4 agga => new hvec4(w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.wyywx swizzling.
        /// </summary>
        public hvec5 wyywx => new hvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.aggar swizzling (equivalent to hvec4.wyywx).
        /// </summary>
        public hvec5 aggar => new hvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.wyywy swizzling.
        /// </summary>
        public hvec5 wyywy => new hvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.aggag swizzling (equivalent to hvec4.wyywy).
        /// </summary>
        public hvec5 aggag => new hvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.wyywz swizzling.
        /// </summary>
        public hvec5 wyywz => new hvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.aggab swizzling (equivalent to hvec4.wyywz).
        /// </summary>
        public hvec5 aggab => new hvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.wyyww swizzling.
        /// </summary>
        public hvec5 wyyww => new hvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.aggaa swizzling (equivalent to hvec4.wyyww).
        /// </summary>
        public hvec5 aggaa => new hvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.wyz swizzling.
        /// </summary>
        public hvec3 wyz => new hvec3(w, y, z);
        
        /// <summary>
        /// Returns hvec4.agb swizzling (equivalent to hvec4.wyz).
        /// </summary>
        public hvec3 agb => new hvec3(w, y, z);
        
        /// <summary>
        /// Returns hvec4.wyzx swizzling.
        /// </summary>
        public hvec4 wyzx => new hvec4(w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.agbr swizzling (equivalent to hvec4.wyzx).
        /// </summary>
        public hvec4 agbr => new hvec4(w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.wyzxx swizzling.
        /// </summary>
        public hvec5 wyzxx => new hvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.agbrr swizzling (equivalent to hvec4.wyzxx).
        /// </summary>
        public hvec5 agbrr => new hvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.wyzxy swizzling.
        /// </summary>
        public hvec5 wyzxy => new hvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.agbrg swizzling (equivalent to hvec4.wyzxy).
        /// </summary>
        public hvec5 agbrg => new hvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.wyzxz swizzling.
        /// </summary>
        public hvec5 wyzxz => new hvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.agbrb swizzling (equivalent to hvec4.wyzxz).
        /// </summary>
        public hvec5 agbrb => new hvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.wyzxw swizzling.
        /// </summary>
        public hvec5 wyzxw => new hvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.agbra swizzling (equivalent to hvec4.wyzxw).
        /// </summary>
        public hvec5 agbra => new hvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.wyzy swizzling.
        /// </summary>
        public hvec4 wyzy => new hvec4(w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.agbg swizzling (equivalent to hvec4.wyzy).
        /// </summary>
        public hvec4 agbg => new hvec4(w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.wyzyx swizzling.
        /// </summary>
        public hvec5 wyzyx => new hvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.agbgr swizzling (equivalent to hvec4.wyzyx).
        /// </summary>
        public hvec5 agbgr => new hvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.wyzyy swizzling.
        /// </summary>
        public hvec5 wyzyy => new hvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.agbgg swizzling (equivalent to hvec4.wyzyy).
        /// </summary>
        public hvec5 agbgg => new hvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.wyzyz swizzling.
        /// </summary>
        public hvec5 wyzyz => new hvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.agbgb swizzling (equivalent to hvec4.wyzyz).
        /// </summary>
        public hvec5 agbgb => new hvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.wyzyw swizzling.
        /// </summary>
        public hvec5 wyzyw => new hvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.agbga swizzling (equivalent to hvec4.wyzyw).
        /// </summary>
        public hvec5 agbga => new hvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.wyzz swizzling.
        /// </summary>
        public hvec4 wyzz => new hvec4(w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.agbb swizzling (equivalent to hvec4.wyzz).
        /// </summary>
        public hvec4 agbb => new hvec4(w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.wyzzx swizzling.
        /// </summary>
        public hvec5 wyzzx => new hvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.agbbr swizzling (equivalent to hvec4.wyzzx).
        /// </summary>
        public hvec5 agbbr => new hvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.wyzzy swizzling.
        /// </summary>
        public hvec5 wyzzy => new hvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.agbbg swizzling (equivalent to hvec4.wyzzy).
        /// </summary>
        public hvec5 agbbg => new hvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.wyzzz swizzling.
        /// </summary>
        public hvec5 wyzzz => new hvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.agbbb swizzling (equivalent to hvec4.wyzzz).
        /// </summary>
        public hvec5 agbbb => new hvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.wyzzw swizzling.
        /// </summary>
        public hvec5 wyzzw => new hvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.agbba swizzling (equivalent to hvec4.wyzzw).
        /// </summary>
        public hvec5 agbba => new hvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.wyzw swizzling.
        /// </summary>
        public hvec4 wyzw => new hvec4(w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.agba swizzling (equivalent to hvec4.wyzw).
        /// </summary>
        public hvec4 agba => new hvec4(w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.wyzwx swizzling.
        /// </summary>
        public hvec5 wyzwx => new hvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.agbar swizzling (equivalent to hvec4.wyzwx).
        /// </summary>
        public hvec5 agbar => new hvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.wyzwy swizzling.
        /// </summary>
        public hvec5 wyzwy => new hvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.agbag swizzling (equivalent to hvec4.wyzwy).
        /// </summary>
        public hvec5 agbag => new hvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.wyzwz swizzling.
        /// </summary>
        public hvec5 wyzwz => new hvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.agbab swizzling (equivalent to hvec4.wyzwz).
        /// </summary>
        public hvec5 agbab => new hvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.wyzww swizzling.
        /// </summary>
        public hvec5 wyzww => new hvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.agbaa swizzling (equivalent to hvec4.wyzww).
        /// </summary>
        public hvec5 agbaa => new hvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.wyw swizzling.
        /// </summary>
        public hvec3 wyw => new hvec3(w, y, w);
        
        /// <summary>
        /// Returns hvec4.aga swizzling (equivalent to hvec4.wyw).
        /// </summary>
        public hvec3 aga => new hvec3(w, y, w);
        
        /// <summary>
        /// Returns hvec4.wywx swizzling.
        /// </summary>
        public hvec4 wywx => new hvec4(w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.agar swizzling (equivalent to hvec4.wywx).
        /// </summary>
        public hvec4 agar => new hvec4(w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.wywxx swizzling.
        /// </summary>
        public hvec5 wywxx => new hvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.agarr swizzling (equivalent to hvec4.wywxx).
        /// </summary>
        public hvec5 agarr => new hvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.wywxy swizzling.
        /// </summary>
        public hvec5 wywxy => new hvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.agarg swizzling (equivalent to hvec4.wywxy).
        /// </summary>
        public hvec5 agarg => new hvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.wywxz swizzling.
        /// </summary>
        public hvec5 wywxz => new hvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.agarb swizzling (equivalent to hvec4.wywxz).
        /// </summary>
        public hvec5 agarb => new hvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.wywxw swizzling.
        /// </summary>
        public hvec5 wywxw => new hvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.agara swizzling (equivalent to hvec4.wywxw).
        /// </summary>
        public hvec5 agara => new hvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.wywy swizzling.
        /// </summary>
        public hvec4 wywy => new hvec4(w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.agag swizzling (equivalent to hvec4.wywy).
        /// </summary>
        public hvec4 agag => new hvec4(w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.wywyx swizzling.
        /// </summary>
        public hvec5 wywyx => new hvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.agagr swizzling (equivalent to hvec4.wywyx).
        /// </summary>
        public hvec5 agagr => new hvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.wywyy swizzling.
        /// </summary>
        public hvec5 wywyy => new hvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.agagg swizzling (equivalent to hvec4.wywyy).
        /// </summary>
        public hvec5 agagg => new hvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.wywyz swizzling.
        /// </summary>
        public hvec5 wywyz => new hvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.agagb swizzling (equivalent to hvec4.wywyz).
        /// </summary>
        public hvec5 agagb => new hvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.wywyw swizzling.
        /// </summary>
        public hvec5 wywyw => new hvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.agaga swizzling (equivalent to hvec4.wywyw).
        /// </summary>
        public hvec5 agaga => new hvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.wywz swizzling.
        /// </summary>
        public hvec4 wywz => new hvec4(w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.agab swizzling (equivalent to hvec4.wywz).
        /// </summary>
        public hvec4 agab => new hvec4(w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.wywzx swizzling.
        /// </summary>
        public hvec5 wywzx => new hvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.agabr swizzling (equivalent to hvec4.wywzx).
        /// </summary>
        public hvec5 agabr => new hvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.wywzy swizzling.
        /// </summary>
        public hvec5 wywzy => new hvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.agabg swizzling (equivalent to hvec4.wywzy).
        /// </summary>
        public hvec5 agabg => new hvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.wywzz swizzling.
        /// </summary>
        public hvec5 wywzz => new hvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.agabb swizzling (equivalent to hvec4.wywzz).
        /// </summary>
        public hvec5 agabb => new hvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.wywzw swizzling.
        /// </summary>
        public hvec5 wywzw => new hvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.agaba swizzling (equivalent to hvec4.wywzw).
        /// </summary>
        public hvec5 agaba => new hvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.wyww swizzling.
        /// </summary>
        public hvec4 wyww => new hvec4(w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.agaa swizzling (equivalent to hvec4.wyww).
        /// </summary>
        public hvec4 agaa => new hvec4(w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.wywwx swizzling.
        /// </summary>
        public hvec5 wywwx => new hvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.agaar swizzling (equivalent to hvec4.wywwx).
        /// </summary>
        public hvec5 agaar => new hvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.wywwy swizzling.
        /// </summary>
        public hvec5 wywwy => new hvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.agaag swizzling (equivalent to hvec4.wywwy).
        /// </summary>
        public hvec5 agaag => new hvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.wywwz swizzling.
        /// </summary>
        public hvec5 wywwz => new hvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.agaab swizzling (equivalent to hvec4.wywwz).
        /// </summary>
        public hvec5 agaab => new hvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.wywww swizzling.
        /// </summary>
        public hvec5 wywww => new hvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.agaaa swizzling (equivalent to hvec4.wywww).
        /// </summary>
        public hvec5 agaaa => new hvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.wz swizzling.
        /// </summary>
        public hvec2 wz => new hvec2(w, z);
        
        /// <summary>
        /// Returns hvec4.ab swizzling (equivalent to hvec4.wz).
        /// </summary>
        public hvec2 ab => new hvec2(w, z);
        
        /// <summary>
        /// Returns hvec4.wzx swizzling.
        /// </summary>
        public hvec3 wzx => new hvec3(w, z, x);
        
        /// <summary>
        /// Returns hvec4.abr swizzling (equivalent to hvec4.wzx).
        /// </summary>
        public hvec3 abr => new hvec3(w, z, x);
        
        /// <summary>
        /// Returns hvec4.wzxx swizzling.
        /// </summary>
        public hvec4 wzxx => new hvec4(w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.abrr swizzling (equivalent to hvec4.wzxx).
        /// </summary>
        public hvec4 abrr => new hvec4(w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.wzxxx swizzling.
        /// </summary>
        public hvec5 wzxxx => new hvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.abrrr swizzling (equivalent to hvec4.wzxxx).
        /// </summary>
        public hvec5 abrrr => new hvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.wzxxy swizzling.
        /// </summary>
        public hvec5 wzxxy => new hvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.abrrg swizzling (equivalent to hvec4.wzxxy).
        /// </summary>
        public hvec5 abrrg => new hvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.wzxxz swizzling.
        /// </summary>
        public hvec5 wzxxz => new hvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.abrrb swizzling (equivalent to hvec4.wzxxz).
        /// </summary>
        public hvec5 abrrb => new hvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.wzxxw swizzling.
        /// </summary>
        public hvec5 wzxxw => new hvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.abrra swizzling (equivalent to hvec4.wzxxw).
        /// </summary>
        public hvec5 abrra => new hvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.wzxy swizzling.
        /// </summary>
        public hvec4 wzxy => new hvec4(w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.abrg swizzling (equivalent to hvec4.wzxy).
        /// </summary>
        public hvec4 abrg => new hvec4(w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.wzxyx swizzling.
        /// </summary>
        public hvec5 wzxyx => new hvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.abrgr swizzling (equivalent to hvec4.wzxyx).
        /// </summary>
        public hvec5 abrgr => new hvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.wzxyy swizzling.
        /// </summary>
        public hvec5 wzxyy => new hvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.abrgg swizzling (equivalent to hvec4.wzxyy).
        /// </summary>
        public hvec5 abrgg => new hvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.wzxyz swizzling.
        /// </summary>
        public hvec5 wzxyz => new hvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.abrgb swizzling (equivalent to hvec4.wzxyz).
        /// </summary>
        public hvec5 abrgb => new hvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.wzxyw swizzling.
        /// </summary>
        public hvec5 wzxyw => new hvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.abrga swizzling (equivalent to hvec4.wzxyw).
        /// </summary>
        public hvec5 abrga => new hvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.wzxz swizzling.
        /// </summary>
        public hvec4 wzxz => new hvec4(w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.abrb swizzling (equivalent to hvec4.wzxz).
        /// </summary>
        public hvec4 abrb => new hvec4(w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.wzxzx swizzling.
        /// </summary>
        public hvec5 wzxzx => new hvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.abrbr swizzling (equivalent to hvec4.wzxzx).
        /// </summary>
        public hvec5 abrbr => new hvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.wzxzy swizzling.
        /// </summary>
        public hvec5 wzxzy => new hvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.abrbg swizzling (equivalent to hvec4.wzxzy).
        /// </summary>
        public hvec5 abrbg => new hvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.wzxzz swizzling.
        /// </summary>
        public hvec5 wzxzz => new hvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.abrbb swizzling (equivalent to hvec4.wzxzz).
        /// </summary>
        public hvec5 abrbb => new hvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.wzxzw swizzling.
        /// </summary>
        public hvec5 wzxzw => new hvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.abrba swizzling (equivalent to hvec4.wzxzw).
        /// </summary>
        public hvec5 abrba => new hvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.wzxw swizzling.
        /// </summary>
        public hvec4 wzxw => new hvec4(w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.abra swizzling (equivalent to hvec4.wzxw).
        /// </summary>
        public hvec4 abra => new hvec4(w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.wzxwx swizzling.
        /// </summary>
        public hvec5 wzxwx => new hvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.abrar swizzling (equivalent to hvec4.wzxwx).
        /// </summary>
        public hvec5 abrar => new hvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.wzxwy swizzling.
        /// </summary>
        public hvec5 wzxwy => new hvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.abrag swizzling (equivalent to hvec4.wzxwy).
        /// </summary>
        public hvec5 abrag => new hvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.wzxwz swizzling.
        /// </summary>
        public hvec5 wzxwz => new hvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.abrab swizzling (equivalent to hvec4.wzxwz).
        /// </summary>
        public hvec5 abrab => new hvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.wzxww swizzling.
        /// </summary>
        public hvec5 wzxww => new hvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.abraa swizzling (equivalent to hvec4.wzxww).
        /// </summary>
        public hvec5 abraa => new hvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.wzy swizzling.
        /// </summary>
        public hvec3 wzy => new hvec3(w, z, y);
        
        /// <summary>
        /// Returns hvec4.abg swizzling (equivalent to hvec4.wzy).
        /// </summary>
        public hvec3 abg => new hvec3(w, z, y);
        
        /// <summary>
        /// Returns hvec4.wzyx swizzling.
        /// </summary>
        public hvec4 wzyx => new hvec4(w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.abgr swizzling (equivalent to hvec4.wzyx).
        /// </summary>
        public hvec4 abgr => new hvec4(w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.wzyxx swizzling.
        /// </summary>
        public hvec5 wzyxx => new hvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.abgrr swizzling (equivalent to hvec4.wzyxx).
        /// </summary>
        public hvec5 abgrr => new hvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.wzyxy swizzling.
        /// </summary>
        public hvec5 wzyxy => new hvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.abgrg swizzling (equivalent to hvec4.wzyxy).
        /// </summary>
        public hvec5 abgrg => new hvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.wzyxz swizzling.
        /// </summary>
        public hvec5 wzyxz => new hvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.abgrb swizzling (equivalent to hvec4.wzyxz).
        /// </summary>
        public hvec5 abgrb => new hvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.wzyxw swizzling.
        /// </summary>
        public hvec5 wzyxw => new hvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.abgra swizzling (equivalent to hvec4.wzyxw).
        /// </summary>
        public hvec5 abgra => new hvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.wzyy swizzling.
        /// </summary>
        public hvec4 wzyy => new hvec4(w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.abgg swizzling (equivalent to hvec4.wzyy).
        /// </summary>
        public hvec4 abgg => new hvec4(w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.wzyyx swizzling.
        /// </summary>
        public hvec5 wzyyx => new hvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.abggr swizzling (equivalent to hvec4.wzyyx).
        /// </summary>
        public hvec5 abggr => new hvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.wzyyy swizzling.
        /// </summary>
        public hvec5 wzyyy => new hvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.abggg swizzling (equivalent to hvec4.wzyyy).
        /// </summary>
        public hvec5 abggg => new hvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.wzyyz swizzling.
        /// </summary>
        public hvec5 wzyyz => new hvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.abggb swizzling (equivalent to hvec4.wzyyz).
        /// </summary>
        public hvec5 abggb => new hvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.wzyyw swizzling.
        /// </summary>
        public hvec5 wzyyw => new hvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.abgga swizzling (equivalent to hvec4.wzyyw).
        /// </summary>
        public hvec5 abgga => new hvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.wzyz swizzling.
        /// </summary>
        public hvec4 wzyz => new hvec4(w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.abgb swizzling (equivalent to hvec4.wzyz).
        /// </summary>
        public hvec4 abgb => new hvec4(w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.wzyzx swizzling.
        /// </summary>
        public hvec5 wzyzx => new hvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.abgbr swizzling (equivalent to hvec4.wzyzx).
        /// </summary>
        public hvec5 abgbr => new hvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.wzyzy swizzling.
        /// </summary>
        public hvec5 wzyzy => new hvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.abgbg swizzling (equivalent to hvec4.wzyzy).
        /// </summary>
        public hvec5 abgbg => new hvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.wzyzz swizzling.
        /// </summary>
        public hvec5 wzyzz => new hvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.abgbb swizzling (equivalent to hvec4.wzyzz).
        /// </summary>
        public hvec5 abgbb => new hvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.wzyzw swizzling.
        /// </summary>
        public hvec5 wzyzw => new hvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.abgba swizzling (equivalent to hvec4.wzyzw).
        /// </summary>
        public hvec5 abgba => new hvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.wzyw swizzling.
        /// </summary>
        public hvec4 wzyw => new hvec4(w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.abga swizzling (equivalent to hvec4.wzyw).
        /// </summary>
        public hvec4 abga => new hvec4(w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.wzywx swizzling.
        /// </summary>
        public hvec5 wzywx => new hvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.abgar swizzling (equivalent to hvec4.wzywx).
        /// </summary>
        public hvec5 abgar => new hvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.wzywy swizzling.
        /// </summary>
        public hvec5 wzywy => new hvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.abgag swizzling (equivalent to hvec4.wzywy).
        /// </summary>
        public hvec5 abgag => new hvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.wzywz swizzling.
        /// </summary>
        public hvec5 wzywz => new hvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.abgab swizzling (equivalent to hvec4.wzywz).
        /// </summary>
        public hvec5 abgab => new hvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.wzyww swizzling.
        /// </summary>
        public hvec5 wzyww => new hvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.abgaa swizzling (equivalent to hvec4.wzyww).
        /// </summary>
        public hvec5 abgaa => new hvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.wzz swizzling.
        /// </summary>
        public hvec3 wzz => new hvec3(w, z, z);
        
        /// <summary>
        /// Returns hvec4.abb swizzling (equivalent to hvec4.wzz).
        /// </summary>
        public hvec3 abb => new hvec3(w, z, z);
        
        /// <summary>
        /// Returns hvec4.wzzx swizzling.
        /// </summary>
        public hvec4 wzzx => new hvec4(w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.abbr swizzling (equivalent to hvec4.wzzx).
        /// </summary>
        public hvec4 abbr => new hvec4(w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.wzzxx swizzling.
        /// </summary>
        public hvec5 wzzxx => new hvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.abbrr swizzling (equivalent to hvec4.wzzxx).
        /// </summary>
        public hvec5 abbrr => new hvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.wzzxy swizzling.
        /// </summary>
        public hvec5 wzzxy => new hvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.abbrg swizzling (equivalent to hvec4.wzzxy).
        /// </summary>
        public hvec5 abbrg => new hvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.wzzxz swizzling.
        /// </summary>
        public hvec5 wzzxz => new hvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.abbrb swizzling (equivalent to hvec4.wzzxz).
        /// </summary>
        public hvec5 abbrb => new hvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.wzzxw swizzling.
        /// </summary>
        public hvec5 wzzxw => new hvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.abbra swizzling (equivalent to hvec4.wzzxw).
        /// </summary>
        public hvec5 abbra => new hvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.wzzy swizzling.
        /// </summary>
        public hvec4 wzzy => new hvec4(w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.abbg swizzling (equivalent to hvec4.wzzy).
        /// </summary>
        public hvec4 abbg => new hvec4(w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.wzzyx swizzling.
        /// </summary>
        public hvec5 wzzyx => new hvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.abbgr swizzling (equivalent to hvec4.wzzyx).
        /// </summary>
        public hvec5 abbgr => new hvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.wzzyy swizzling.
        /// </summary>
        public hvec5 wzzyy => new hvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.abbgg swizzling (equivalent to hvec4.wzzyy).
        /// </summary>
        public hvec5 abbgg => new hvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.wzzyz swizzling.
        /// </summary>
        public hvec5 wzzyz => new hvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.abbgb swizzling (equivalent to hvec4.wzzyz).
        /// </summary>
        public hvec5 abbgb => new hvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.wzzyw swizzling.
        /// </summary>
        public hvec5 wzzyw => new hvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.abbga swizzling (equivalent to hvec4.wzzyw).
        /// </summary>
        public hvec5 abbga => new hvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.wzzz swizzling.
        /// </summary>
        public hvec4 wzzz => new hvec4(w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.abbb swizzling (equivalent to hvec4.wzzz).
        /// </summary>
        public hvec4 abbb => new hvec4(w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.wzzzx swizzling.
        /// </summary>
        public hvec5 wzzzx => new hvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.abbbr swizzling (equivalent to hvec4.wzzzx).
        /// </summary>
        public hvec5 abbbr => new hvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.wzzzy swizzling.
        /// </summary>
        public hvec5 wzzzy => new hvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.abbbg swizzling (equivalent to hvec4.wzzzy).
        /// </summary>
        public hvec5 abbbg => new hvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.wzzzz swizzling.
        /// </summary>
        public hvec5 wzzzz => new hvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.abbbb swizzling (equivalent to hvec4.wzzzz).
        /// </summary>
        public hvec5 abbbb => new hvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.wzzzw swizzling.
        /// </summary>
        public hvec5 wzzzw => new hvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.abbba swizzling (equivalent to hvec4.wzzzw).
        /// </summary>
        public hvec5 abbba => new hvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.wzzw swizzling.
        /// </summary>
        public hvec4 wzzw => new hvec4(w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.abba swizzling (equivalent to hvec4.wzzw).
        /// </summary>
        public hvec4 abba => new hvec4(w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.wzzwx swizzling.
        /// </summary>
        public hvec5 wzzwx => new hvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.abbar swizzling (equivalent to hvec4.wzzwx).
        /// </summary>
        public hvec5 abbar => new hvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.wzzwy swizzling.
        /// </summary>
        public hvec5 wzzwy => new hvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.abbag swizzling (equivalent to hvec4.wzzwy).
        /// </summary>
        public hvec5 abbag => new hvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.wzzwz swizzling.
        /// </summary>
        public hvec5 wzzwz => new hvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.abbab swizzling (equivalent to hvec4.wzzwz).
        /// </summary>
        public hvec5 abbab => new hvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.wzzww swizzling.
        /// </summary>
        public hvec5 wzzww => new hvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.abbaa swizzling (equivalent to hvec4.wzzww).
        /// </summary>
        public hvec5 abbaa => new hvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.wzw swizzling.
        /// </summary>
        public hvec3 wzw => new hvec3(w, z, w);
        
        /// <summary>
        /// Returns hvec4.aba swizzling (equivalent to hvec4.wzw).
        /// </summary>
        public hvec3 aba => new hvec3(w, z, w);
        
        /// <summary>
        /// Returns hvec4.wzwx swizzling.
        /// </summary>
        public hvec4 wzwx => new hvec4(w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.abar swizzling (equivalent to hvec4.wzwx).
        /// </summary>
        public hvec4 abar => new hvec4(w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.wzwxx swizzling.
        /// </summary>
        public hvec5 wzwxx => new hvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.abarr swizzling (equivalent to hvec4.wzwxx).
        /// </summary>
        public hvec5 abarr => new hvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.wzwxy swizzling.
        /// </summary>
        public hvec5 wzwxy => new hvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.abarg swizzling (equivalent to hvec4.wzwxy).
        /// </summary>
        public hvec5 abarg => new hvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.wzwxz swizzling.
        /// </summary>
        public hvec5 wzwxz => new hvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.abarb swizzling (equivalent to hvec4.wzwxz).
        /// </summary>
        public hvec5 abarb => new hvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.wzwxw swizzling.
        /// </summary>
        public hvec5 wzwxw => new hvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.abara swizzling (equivalent to hvec4.wzwxw).
        /// </summary>
        public hvec5 abara => new hvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.wzwy swizzling.
        /// </summary>
        public hvec4 wzwy => new hvec4(w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.abag swizzling (equivalent to hvec4.wzwy).
        /// </summary>
        public hvec4 abag => new hvec4(w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.wzwyx swizzling.
        /// </summary>
        public hvec5 wzwyx => new hvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.abagr swizzling (equivalent to hvec4.wzwyx).
        /// </summary>
        public hvec5 abagr => new hvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.wzwyy swizzling.
        /// </summary>
        public hvec5 wzwyy => new hvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.abagg swizzling (equivalent to hvec4.wzwyy).
        /// </summary>
        public hvec5 abagg => new hvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.wzwyz swizzling.
        /// </summary>
        public hvec5 wzwyz => new hvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.abagb swizzling (equivalent to hvec4.wzwyz).
        /// </summary>
        public hvec5 abagb => new hvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.wzwyw swizzling.
        /// </summary>
        public hvec5 wzwyw => new hvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.abaga swizzling (equivalent to hvec4.wzwyw).
        /// </summary>
        public hvec5 abaga => new hvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.wzwz swizzling.
        /// </summary>
        public hvec4 wzwz => new hvec4(w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.abab swizzling (equivalent to hvec4.wzwz).
        /// </summary>
        public hvec4 abab => new hvec4(w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.wzwzx swizzling.
        /// </summary>
        public hvec5 wzwzx => new hvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.ababr swizzling (equivalent to hvec4.wzwzx).
        /// </summary>
        public hvec5 ababr => new hvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.wzwzy swizzling.
        /// </summary>
        public hvec5 wzwzy => new hvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.ababg swizzling (equivalent to hvec4.wzwzy).
        /// </summary>
        public hvec5 ababg => new hvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.wzwzz swizzling.
        /// </summary>
        public hvec5 wzwzz => new hvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.ababb swizzling (equivalent to hvec4.wzwzz).
        /// </summary>
        public hvec5 ababb => new hvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.wzwzw swizzling.
        /// </summary>
        public hvec5 wzwzw => new hvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.ababa swizzling (equivalent to hvec4.wzwzw).
        /// </summary>
        public hvec5 ababa => new hvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.wzww swizzling.
        /// </summary>
        public hvec4 wzww => new hvec4(w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.abaa swizzling (equivalent to hvec4.wzww).
        /// </summary>
        public hvec4 abaa => new hvec4(w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.wzwwx swizzling.
        /// </summary>
        public hvec5 wzwwx => new hvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.abaar swizzling (equivalent to hvec4.wzwwx).
        /// </summary>
        public hvec5 abaar => new hvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.wzwwy swizzling.
        /// </summary>
        public hvec5 wzwwy => new hvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.abaag swizzling (equivalent to hvec4.wzwwy).
        /// </summary>
        public hvec5 abaag => new hvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.wzwwz swizzling.
        /// </summary>
        public hvec5 wzwwz => new hvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.abaab swizzling (equivalent to hvec4.wzwwz).
        /// </summary>
        public hvec5 abaab => new hvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.wzwww swizzling.
        /// </summary>
        public hvec5 wzwww => new hvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.abaaa swizzling (equivalent to hvec4.wzwww).
        /// </summary>
        public hvec5 abaaa => new hvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.ww swizzling.
        /// </summary>
        public hvec2 ww => new hvec2(w, w);
        
        /// <summary>
        /// Returns hvec4.aa swizzling (equivalent to hvec4.ww).
        /// </summary>
        public hvec2 aa => new hvec2(w, w);
        
        /// <summary>
        /// Returns hvec4.wwx swizzling.
        /// </summary>
        public hvec3 wwx => new hvec3(w, w, x);
        
        /// <summary>
        /// Returns hvec4.aar swizzling (equivalent to hvec4.wwx).
        /// </summary>
        public hvec3 aar => new hvec3(w, w, x);
        
        /// <summary>
        /// Returns hvec4.wwxx swizzling.
        /// </summary>
        public hvec4 wwxx => new hvec4(w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.aarr swizzling (equivalent to hvec4.wwxx).
        /// </summary>
        public hvec4 aarr => new hvec4(w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.wwxxx swizzling.
        /// </summary>
        public hvec5 wwxxx => new hvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.aarrr swizzling (equivalent to hvec4.wwxxx).
        /// </summary>
        public hvec5 aarrr => new hvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.wwxxy swizzling.
        /// </summary>
        public hvec5 wwxxy => new hvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.aarrg swizzling (equivalent to hvec4.wwxxy).
        /// </summary>
        public hvec5 aarrg => new hvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.wwxxz swizzling.
        /// </summary>
        public hvec5 wwxxz => new hvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.aarrb swizzling (equivalent to hvec4.wwxxz).
        /// </summary>
        public hvec5 aarrb => new hvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.wwxxw swizzling.
        /// </summary>
        public hvec5 wwxxw => new hvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.aarra swizzling (equivalent to hvec4.wwxxw).
        /// </summary>
        public hvec5 aarra => new hvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.wwxy swizzling.
        /// </summary>
        public hvec4 wwxy => new hvec4(w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.aarg swizzling (equivalent to hvec4.wwxy).
        /// </summary>
        public hvec4 aarg => new hvec4(w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.wwxyx swizzling.
        /// </summary>
        public hvec5 wwxyx => new hvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.aargr swizzling (equivalent to hvec4.wwxyx).
        /// </summary>
        public hvec5 aargr => new hvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.wwxyy swizzling.
        /// </summary>
        public hvec5 wwxyy => new hvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.aargg swizzling (equivalent to hvec4.wwxyy).
        /// </summary>
        public hvec5 aargg => new hvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.wwxyz swizzling.
        /// </summary>
        public hvec5 wwxyz => new hvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.aargb swizzling (equivalent to hvec4.wwxyz).
        /// </summary>
        public hvec5 aargb => new hvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.wwxyw swizzling.
        /// </summary>
        public hvec5 wwxyw => new hvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.aarga swizzling (equivalent to hvec4.wwxyw).
        /// </summary>
        public hvec5 aarga => new hvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.wwxz swizzling.
        /// </summary>
        public hvec4 wwxz => new hvec4(w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.aarb swizzling (equivalent to hvec4.wwxz).
        /// </summary>
        public hvec4 aarb => new hvec4(w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.wwxzx swizzling.
        /// </summary>
        public hvec5 wwxzx => new hvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.aarbr swizzling (equivalent to hvec4.wwxzx).
        /// </summary>
        public hvec5 aarbr => new hvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.wwxzy swizzling.
        /// </summary>
        public hvec5 wwxzy => new hvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.aarbg swizzling (equivalent to hvec4.wwxzy).
        /// </summary>
        public hvec5 aarbg => new hvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.wwxzz swizzling.
        /// </summary>
        public hvec5 wwxzz => new hvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.aarbb swizzling (equivalent to hvec4.wwxzz).
        /// </summary>
        public hvec5 aarbb => new hvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.wwxzw swizzling.
        /// </summary>
        public hvec5 wwxzw => new hvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.aarba swizzling (equivalent to hvec4.wwxzw).
        /// </summary>
        public hvec5 aarba => new hvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.wwxw swizzling.
        /// </summary>
        public hvec4 wwxw => new hvec4(w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.aara swizzling (equivalent to hvec4.wwxw).
        /// </summary>
        public hvec4 aara => new hvec4(w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.wwxwx swizzling.
        /// </summary>
        public hvec5 wwxwx => new hvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.aarar swizzling (equivalent to hvec4.wwxwx).
        /// </summary>
        public hvec5 aarar => new hvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.wwxwy swizzling.
        /// </summary>
        public hvec5 wwxwy => new hvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.aarag swizzling (equivalent to hvec4.wwxwy).
        /// </summary>
        public hvec5 aarag => new hvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.wwxwz swizzling.
        /// </summary>
        public hvec5 wwxwz => new hvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.aarab swizzling (equivalent to hvec4.wwxwz).
        /// </summary>
        public hvec5 aarab => new hvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.wwxww swizzling.
        /// </summary>
        public hvec5 wwxww => new hvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.aaraa swizzling (equivalent to hvec4.wwxww).
        /// </summary>
        public hvec5 aaraa => new hvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.wwy swizzling.
        /// </summary>
        public hvec3 wwy => new hvec3(w, w, y);
        
        /// <summary>
        /// Returns hvec4.aag swizzling (equivalent to hvec4.wwy).
        /// </summary>
        public hvec3 aag => new hvec3(w, w, y);
        
        /// <summary>
        /// Returns hvec4.wwyx swizzling.
        /// </summary>
        public hvec4 wwyx => new hvec4(w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.aagr swizzling (equivalent to hvec4.wwyx).
        /// </summary>
        public hvec4 aagr => new hvec4(w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.wwyxx swizzling.
        /// </summary>
        public hvec5 wwyxx => new hvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.aagrr swizzling (equivalent to hvec4.wwyxx).
        /// </summary>
        public hvec5 aagrr => new hvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.wwyxy swizzling.
        /// </summary>
        public hvec5 wwyxy => new hvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.aagrg swizzling (equivalent to hvec4.wwyxy).
        /// </summary>
        public hvec5 aagrg => new hvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.wwyxz swizzling.
        /// </summary>
        public hvec5 wwyxz => new hvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.aagrb swizzling (equivalent to hvec4.wwyxz).
        /// </summary>
        public hvec5 aagrb => new hvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.wwyxw swizzling.
        /// </summary>
        public hvec5 wwyxw => new hvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.aagra swizzling (equivalent to hvec4.wwyxw).
        /// </summary>
        public hvec5 aagra => new hvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.wwyy swizzling.
        /// </summary>
        public hvec4 wwyy => new hvec4(w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.aagg swizzling (equivalent to hvec4.wwyy).
        /// </summary>
        public hvec4 aagg => new hvec4(w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.wwyyx swizzling.
        /// </summary>
        public hvec5 wwyyx => new hvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.aaggr swizzling (equivalent to hvec4.wwyyx).
        /// </summary>
        public hvec5 aaggr => new hvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.wwyyy swizzling.
        /// </summary>
        public hvec5 wwyyy => new hvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.aaggg swizzling (equivalent to hvec4.wwyyy).
        /// </summary>
        public hvec5 aaggg => new hvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.wwyyz swizzling.
        /// </summary>
        public hvec5 wwyyz => new hvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.aaggb swizzling (equivalent to hvec4.wwyyz).
        /// </summary>
        public hvec5 aaggb => new hvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.wwyyw swizzling.
        /// </summary>
        public hvec5 wwyyw => new hvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.aagga swizzling (equivalent to hvec4.wwyyw).
        /// </summary>
        public hvec5 aagga => new hvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.wwyz swizzling.
        /// </summary>
        public hvec4 wwyz => new hvec4(w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.aagb swizzling (equivalent to hvec4.wwyz).
        /// </summary>
        public hvec4 aagb => new hvec4(w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.wwyzx swizzling.
        /// </summary>
        public hvec5 wwyzx => new hvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.aagbr swizzling (equivalent to hvec4.wwyzx).
        /// </summary>
        public hvec5 aagbr => new hvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.wwyzy swizzling.
        /// </summary>
        public hvec5 wwyzy => new hvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.aagbg swizzling (equivalent to hvec4.wwyzy).
        /// </summary>
        public hvec5 aagbg => new hvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.wwyzz swizzling.
        /// </summary>
        public hvec5 wwyzz => new hvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.aagbb swizzling (equivalent to hvec4.wwyzz).
        /// </summary>
        public hvec5 aagbb => new hvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.wwyzw swizzling.
        /// </summary>
        public hvec5 wwyzw => new hvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.aagba swizzling (equivalent to hvec4.wwyzw).
        /// </summary>
        public hvec5 aagba => new hvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.wwyw swizzling.
        /// </summary>
        public hvec4 wwyw => new hvec4(w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.aaga swizzling (equivalent to hvec4.wwyw).
        /// </summary>
        public hvec4 aaga => new hvec4(w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.wwywx swizzling.
        /// </summary>
        public hvec5 wwywx => new hvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.aagar swizzling (equivalent to hvec4.wwywx).
        /// </summary>
        public hvec5 aagar => new hvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.wwywy swizzling.
        /// </summary>
        public hvec5 wwywy => new hvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.aagag swizzling (equivalent to hvec4.wwywy).
        /// </summary>
        public hvec5 aagag => new hvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.wwywz swizzling.
        /// </summary>
        public hvec5 wwywz => new hvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.aagab swizzling (equivalent to hvec4.wwywz).
        /// </summary>
        public hvec5 aagab => new hvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.wwyww swizzling.
        /// </summary>
        public hvec5 wwyww => new hvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.aagaa swizzling (equivalent to hvec4.wwyww).
        /// </summary>
        public hvec5 aagaa => new hvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.wwz swizzling.
        /// </summary>
        public hvec3 wwz => new hvec3(w, w, z);
        
        /// <summary>
        /// Returns hvec4.aab swizzling (equivalent to hvec4.wwz).
        /// </summary>
        public hvec3 aab => new hvec3(w, w, z);
        
        /// <summary>
        /// Returns hvec4.wwzx swizzling.
        /// </summary>
        public hvec4 wwzx => new hvec4(w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.aabr swizzling (equivalent to hvec4.wwzx).
        /// </summary>
        public hvec4 aabr => new hvec4(w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.wwzxx swizzling.
        /// </summary>
        public hvec5 wwzxx => new hvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.aabrr swizzling (equivalent to hvec4.wwzxx).
        /// </summary>
        public hvec5 aabrr => new hvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.wwzxy swizzling.
        /// </summary>
        public hvec5 wwzxy => new hvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.aabrg swizzling (equivalent to hvec4.wwzxy).
        /// </summary>
        public hvec5 aabrg => new hvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.wwzxz swizzling.
        /// </summary>
        public hvec5 wwzxz => new hvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.aabrb swizzling (equivalent to hvec4.wwzxz).
        /// </summary>
        public hvec5 aabrb => new hvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.wwzxw swizzling.
        /// </summary>
        public hvec5 wwzxw => new hvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.aabra swizzling (equivalent to hvec4.wwzxw).
        /// </summary>
        public hvec5 aabra => new hvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.wwzy swizzling.
        /// </summary>
        public hvec4 wwzy => new hvec4(w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.aabg swizzling (equivalent to hvec4.wwzy).
        /// </summary>
        public hvec4 aabg => new hvec4(w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.wwzyx swizzling.
        /// </summary>
        public hvec5 wwzyx => new hvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.aabgr swizzling (equivalent to hvec4.wwzyx).
        /// </summary>
        public hvec5 aabgr => new hvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.wwzyy swizzling.
        /// </summary>
        public hvec5 wwzyy => new hvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.aabgg swizzling (equivalent to hvec4.wwzyy).
        /// </summary>
        public hvec5 aabgg => new hvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.wwzyz swizzling.
        /// </summary>
        public hvec5 wwzyz => new hvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.aabgb swizzling (equivalent to hvec4.wwzyz).
        /// </summary>
        public hvec5 aabgb => new hvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.wwzyw swizzling.
        /// </summary>
        public hvec5 wwzyw => new hvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.aabga swizzling (equivalent to hvec4.wwzyw).
        /// </summary>
        public hvec5 aabga => new hvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.wwzz swizzling.
        /// </summary>
        public hvec4 wwzz => new hvec4(w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.aabb swizzling (equivalent to hvec4.wwzz).
        /// </summary>
        public hvec4 aabb => new hvec4(w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.wwzzx swizzling.
        /// </summary>
        public hvec5 wwzzx => new hvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.aabbr swizzling (equivalent to hvec4.wwzzx).
        /// </summary>
        public hvec5 aabbr => new hvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.wwzzy swizzling.
        /// </summary>
        public hvec5 wwzzy => new hvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.aabbg swizzling (equivalent to hvec4.wwzzy).
        /// </summary>
        public hvec5 aabbg => new hvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.wwzzz swizzling.
        /// </summary>
        public hvec5 wwzzz => new hvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.aabbb swizzling (equivalent to hvec4.wwzzz).
        /// </summary>
        public hvec5 aabbb => new hvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.wwzzw swizzling.
        /// </summary>
        public hvec5 wwzzw => new hvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.aabba swizzling (equivalent to hvec4.wwzzw).
        /// </summary>
        public hvec5 aabba => new hvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.wwzw swizzling.
        /// </summary>
        public hvec4 wwzw => new hvec4(w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.aaba swizzling (equivalent to hvec4.wwzw).
        /// </summary>
        public hvec4 aaba => new hvec4(w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.wwzwx swizzling.
        /// </summary>
        public hvec5 wwzwx => new hvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.aabar swizzling (equivalent to hvec4.wwzwx).
        /// </summary>
        public hvec5 aabar => new hvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.wwzwy swizzling.
        /// </summary>
        public hvec5 wwzwy => new hvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.aabag swizzling (equivalent to hvec4.wwzwy).
        /// </summary>
        public hvec5 aabag => new hvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.wwzwz swizzling.
        /// </summary>
        public hvec5 wwzwz => new hvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.aabab swizzling (equivalent to hvec4.wwzwz).
        /// </summary>
        public hvec5 aabab => new hvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.wwzww swizzling.
        /// </summary>
        public hvec5 wwzww => new hvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.aabaa swizzling (equivalent to hvec4.wwzww).
        /// </summary>
        public hvec5 aabaa => new hvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.www swizzling.
        /// </summary>
        public hvec3 www => new hvec3(w, w, w);
        
        /// <summary>
        /// Returns hvec4.aaa swizzling (equivalent to hvec4.www).
        /// </summary>
        public hvec3 aaa => new hvec3(w, w, w);
        
        /// <summary>
        /// Returns hvec4.wwwx swizzling.
        /// </summary>
        public hvec4 wwwx => new hvec4(w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.aaar swizzling (equivalent to hvec4.wwwx).
        /// </summary>
        public hvec4 aaar => new hvec4(w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.wwwxx swizzling.
        /// </summary>
        public hvec5 wwwxx => new hvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.aaarr swizzling (equivalent to hvec4.wwwxx).
        /// </summary>
        public hvec5 aaarr => new hvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.wwwxy swizzling.
        /// </summary>
        public hvec5 wwwxy => new hvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.aaarg swizzling (equivalent to hvec4.wwwxy).
        /// </summary>
        public hvec5 aaarg => new hvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.wwwxz swizzling.
        /// </summary>
        public hvec5 wwwxz => new hvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.aaarb swizzling (equivalent to hvec4.wwwxz).
        /// </summary>
        public hvec5 aaarb => new hvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.wwwxw swizzling.
        /// </summary>
        public hvec5 wwwxw => new hvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.aaara swizzling (equivalent to hvec4.wwwxw).
        /// </summary>
        public hvec5 aaara => new hvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.wwwy swizzling.
        /// </summary>
        public hvec4 wwwy => new hvec4(w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.aaag swizzling (equivalent to hvec4.wwwy).
        /// </summary>
        public hvec4 aaag => new hvec4(w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.wwwyx swizzling.
        /// </summary>
        public hvec5 wwwyx => new hvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.aaagr swizzling (equivalent to hvec4.wwwyx).
        /// </summary>
        public hvec5 aaagr => new hvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.wwwyy swizzling.
        /// </summary>
        public hvec5 wwwyy => new hvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.aaagg swizzling (equivalent to hvec4.wwwyy).
        /// </summary>
        public hvec5 aaagg => new hvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.wwwyz swizzling.
        /// </summary>
        public hvec5 wwwyz => new hvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.aaagb swizzling (equivalent to hvec4.wwwyz).
        /// </summary>
        public hvec5 aaagb => new hvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.wwwyw swizzling.
        /// </summary>
        public hvec5 wwwyw => new hvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.aaaga swizzling (equivalent to hvec4.wwwyw).
        /// </summary>
        public hvec5 aaaga => new hvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.wwwz swizzling.
        /// </summary>
        public hvec4 wwwz => new hvec4(w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.aaab swizzling (equivalent to hvec4.wwwz).
        /// </summary>
        public hvec4 aaab => new hvec4(w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.wwwzx swizzling.
        /// </summary>
        public hvec5 wwwzx => new hvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.aaabr swizzling (equivalent to hvec4.wwwzx).
        /// </summary>
        public hvec5 aaabr => new hvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.wwwzy swizzling.
        /// </summary>
        public hvec5 wwwzy => new hvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.aaabg swizzling (equivalent to hvec4.wwwzy).
        /// </summary>
        public hvec5 aaabg => new hvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.wwwzz swizzling.
        /// </summary>
        public hvec5 wwwzz => new hvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.aaabb swizzling (equivalent to hvec4.wwwzz).
        /// </summary>
        public hvec5 aaabb => new hvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.wwwzw swizzling.
        /// </summary>
        public hvec5 wwwzw => new hvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.aaaba swizzling (equivalent to hvec4.wwwzw).
        /// </summary>
        public hvec5 aaaba => new hvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.wwww swizzling.
        /// </summary>
        public hvec4 wwww => new hvec4(w, w, w, w);
        
        /// <summary>
        /// Returns hvec4.aaaa swizzling (equivalent to hvec4.wwww).
        /// </summary>
        public hvec4 aaaa => new hvec4(w, w, w, w);
        
        /// <summary>
        /// Returns hvec4.wwwwx swizzling.
        /// </summary>
        public hvec5 wwwwx => new hvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.aaaar swizzling (equivalent to hvec4.wwwwx).
        /// </summary>
        public hvec5 aaaar => new hvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.wwwwy swizzling.
        /// </summary>
        public hvec5 wwwwy => new hvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.aaaag swizzling (equivalent to hvec4.wwwwy).
        /// </summary>
        public hvec5 aaaag => new hvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.wwwwz swizzling.
        /// </summary>
        public hvec5 wwwwz => new hvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.aaaab swizzling (equivalent to hvec4.wwwwz).
        /// </summary>
        public hvec5 aaaab => new hvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.wwwww swizzling.
        /// </summary>
        public hvec5 wwwww => new hvec5(w, w, w, w, w);
        
        /// <summary>
        /// Returns hvec4.aaaaa swizzling (equivalent to hvec4.wwwww).
        /// </summary>
        public hvec5 aaaaa => new hvec5(w, w, w, w, w);

        #endregion

    }
}
