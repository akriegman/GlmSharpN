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
    /// Temporary vector of type decimal with 4 components, used for implementing swizzling for decvec4.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_decvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly decimal x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly decimal y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly decimal z;
        
        /// <summary>
        /// w-component
        /// </summary>
        internal readonly decimal w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_decvec4.
        /// </summary>
        internal swizzle_decvec4(decimal x, decimal y, decimal z, decimal w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns decvec4.xx swizzling.
        /// </summary>
        public decvec2 xx => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec4.rr swizzling (equivalent to decvec4.xx).
        /// </summary>
        public decvec2 rr => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec4.xxx swizzling.
        /// </summary>
        public decvec3 xxx => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec4.rrr swizzling (equivalent to decvec4.xxx).
        /// </summary>
        public decvec3 rrr => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec4.xxxx swizzling.
        /// </summary>
        public decvec4 xxxx => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.rrrr swizzling (equivalent to decvec4.xxxx).
        /// </summary>
        public decvec4 rrrr => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.xxxxx swizzling.
        /// </summary>
        public decvec5 xxxxx => new decvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.rrrrr swizzling (equivalent to decvec4.xxxxx).
        /// </summary>
        public decvec5 rrrrr => new decvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.xxxxy swizzling.
        /// </summary>
        public decvec5 xxxxy => new decvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.rrrrg swizzling (equivalent to decvec4.xxxxy).
        /// </summary>
        public decvec5 rrrrg => new decvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.xxxxz swizzling.
        /// </summary>
        public decvec5 xxxxz => new decvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.rrrrb swizzling (equivalent to decvec4.xxxxz).
        /// </summary>
        public decvec5 rrrrb => new decvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.xxxxw swizzling.
        /// </summary>
        public decvec5 xxxxw => new decvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.rrrra swizzling (equivalent to decvec4.xxxxw).
        /// </summary>
        public decvec5 rrrra => new decvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.xxxy swizzling.
        /// </summary>
        public decvec4 xxxy => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.rrrg swizzling (equivalent to decvec4.xxxy).
        /// </summary>
        public decvec4 rrrg => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.xxxyx swizzling.
        /// </summary>
        public decvec5 xxxyx => new decvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.rrrgr swizzling (equivalent to decvec4.xxxyx).
        /// </summary>
        public decvec5 rrrgr => new decvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.xxxyy swizzling.
        /// </summary>
        public decvec5 xxxyy => new decvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.rrrgg swizzling (equivalent to decvec4.xxxyy).
        /// </summary>
        public decvec5 rrrgg => new decvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.xxxyz swizzling.
        /// </summary>
        public decvec5 xxxyz => new decvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.rrrgb swizzling (equivalent to decvec4.xxxyz).
        /// </summary>
        public decvec5 rrrgb => new decvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.xxxyw swizzling.
        /// </summary>
        public decvec5 xxxyw => new decvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.rrrga swizzling (equivalent to decvec4.xxxyw).
        /// </summary>
        public decvec5 rrrga => new decvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.xxxz swizzling.
        /// </summary>
        public decvec4 xxxz => new decvec4(x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.rrrb swizzling (equivalent to decvec4.xxxz).
        /// </summary>
        public decvec4 rrrb => new decvec4(x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.xxxzx swizzling.
        /// </summary>
        public decvec5 xxxzx => new decvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.rrrbr swizzling (equivalent to decvec4.xxxzx).
        /// </summary>
        public decvec5 rrrbr => new decvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.xxxzy swizzling.
        /// </summary>
        public decvec5 xxxzy => new decvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.rrrbg swizzling (equivalent to decvec4.xxxzy).
        /// </summary>
        public decvec5 rrrbg => new decvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.xxxzz swizzling.
        /// </summary>
        public decvec5 xxxzz => new decvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.rrrbb swizzling (equivalent to decvec4.xxxzz).
        /// </summary>
        public decvec5 rrrbb => new decvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.xxxzw swizzling.
        /// </summary>
        public decvec5 xxxzw => new decvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.rrrba swizzling (equivalent to decvec4.xxxzw).
        /// </summary>
        public decvec5 rrrba => new decvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.xxxw swizzling.
        /// </summary>
        public decvec4 xxxw => new decvec4(x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.rrra swizzling (equivalent to decvec4.xxxw).
        /// </summary>
        public decvec4 rrra => new decvec4(x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.xxxwx swizzling.
        /// </summary>
        public decvec5 xxxwx => new decvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.rrrar swizzling (equivalent to decvec4.xxxwx).
        /// </summary>
        public decvec5 rrrar => new decvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.xxxwy swizzling.
        /// </summary>
        public decvec5 xxxwy => new decvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.rrrag swizzling (equivalent to decvec4.xxxwy).
        /// </summary>
        public decvec5 rrrag => new decvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.xxxwz swizzling.
        /// </summary>
        public decvec5 xxxwz => new decvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.rrrab swizzling (equivalent to decvec4.xxxwz).
        /// </summary>
        public decvec5 rrrab => new decvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.xxxww swizzling.
        /// </summary>
        public decvec5 xxxww => new decvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.rrraa swizzling (equivalent to decvec4.xxxww).
        /// </summary>
        public decvec5 rrraa => new decvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.xxy swizzling.
        /// </summary>
        public decvec3 xxy => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec4.rrg swizzling (equivalent to decvec4.xxy).
        /// </summary>
        public decvec3 rrg => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec4.xxyx swizzling.
        /// </summary>
        public decvec4 xxyx => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.rrgr swizzling (equivalent to decvec4.xxyx).
        /// </summary>
        public decvec4 rrgr => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.xxyxx swizzling.
        /// </summary>
        public decvec5 xxyxx => new decvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.rrgrr swizzling (equivalent to decvec4.xxyxx).
        /// </summary>
        public decvec5 rrgrr => new decvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.xxyxy swizzling.
        /// </summary>
        public decvec5 xxyxy => new decvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.rrgrg swizzling (equivalent to decvec4.xxyxy).
        /// </summary>
        public decvec5 rrgrg => new decvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.xxyxz swizzling.
        /// </summary>
        public decvec5 xxyxz => new decvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.rrgrb swizzling (equivalent to decvec4.xxyxz).
        /// </summary>
        public decvec5 rrgrb => new decvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.xxyxw swizzling.
        /// </summary>
        public decvec5 xxyxw => new decvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.rrgra swizzling (equivalent to decvec4.xxyxw).
        /// </summary>
        public decvec5 rrgra => new decvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.xxyy swizzling.
        /// </summary>
        public decvec4 xxyy => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.rrgg swizzling (equivalent to decvec4.xxyy).
        /// </summary>
        public decvec4 rrgg => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.xxyyx swizzling.
        /// </summary>
        public decvec5 xxyyx => new decvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.rrggr swizzling (equivalent to decvec4.xxyyx).
        /// </summary>
        public decvec5 rrggr => new decvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.xxyyy swizzling.
        /// </summary>
        public decvec5 xxyyy => new decvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.rrggg swizzling (equivalent to decvec4.xxyyy).
        /// </summary>
        public decvec5 rrggg => new decvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.xxyyz swizzling.
        /// </summary>
        public decvec5 xxyyz => new decvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.rrggb swizzling (equivalent to decvec4.xxyyz).
        /// </summary>
        public decvec5 rrggb => new decvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.xxyyw swizzling.
        /// </summary>
        public decvec5 xxyyw => new decvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.rrgga swizzling (equivalent to decvec4.xxyyw).
        /// </summary>
        public decvec5 rrgga => new decvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.xxyz swizzling.
        /// </summary>
        public decvec4 xxyz => new decvec4(x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.rrgb swizzling (equivalent to decvec4.xxyz).
        /// </summary>
        public decvec4 rrgb => new decvec4(x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.xxyzx swizzling.
        /// </summary>
        public decvec5 xxyzx => new decvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.rrgbr swizzling (equivalent to decvec4.xxyzx).
        /// </summary>
        public decvec5 rrgbr => new decvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.xxyzy swizzling.
        /// </summary>
        public decvec5 xxyzy => new decvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.rrgbg swizzling (equivalent to decvec4.xxyzy).
        /// </summary>
        public decvec5 rrgbg => new decvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.xxyzz swizzling.
        /// </summary>
        public decvec5 xxyzz => new decvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.rrgbb swizzling (equivalent to decvec4.xxyzz).
        /// </summary>
        public decvec5 rrgbb => new decvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.xxyzw swizzling.
        /// </summary>
        public decvec5 xxyzw => new decvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.rrgba swizzling (equivalent to decvec4.xxyzw).
        /// </summary>
        public decvec5 rrgba => new decvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.xxyw swizzling.
        /// </summary>
        public decvec4 xxyw => new decvec4(x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.rrga swizzling (equivalent to decvec4.xxyw).
        /// </summary>
        public decvec4 rrga => new decvec4(x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.xxywx swizzling.
        /// </summary>
        public decvec5 xxywx => new decvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.rrgar swizzling (equivalent to decvec4.xxywx).
        /// </summary>
        public decvec5 rrgar => new decvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.xxywy swizzling.
        /// </summary>
        public decvec5 xxywy => new decvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.rrgag swizzling (equivalent to decvec4.xxywy).
        /// </summary>
        public decvec5 rrgag => new decvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.xxywz swizzling.
        /// </summary>
        public decvec5 xxywz => new decvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.rrgab swizzling (equivalent to decvec4.xxywz).
        /// </summary>
        public decvec5 rrgab => new decvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.xxyww swizzling.
        /// </summary>
        public decvec5 xxyww => new decvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.rrgaa swizzling (equivalent to decvec4.xxyww).
        /// </summary>
        public decvec5 rrgaa => new decvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.xxz swizzling.
        /// </summary>
        public decvec3 xxz => new decvec3(x, x, z);
        
        /// <summary>
        /// Returns decvec4.rrb swizzling (equivalent to decvec4.xxz).
        /// </summary>
        public decvec3 rrb => new decvec3(x, x, z);
        
        /// <summary>
        /// Returns decvec4.xxzx swizzling.
        /// </summary>
        public decvec4 xxzx => new decvec4(x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.rrbr swizzling (equivalent to decvec4.xxzx).
        /// </summary>
        public decvec4 rrbr => new decvec4(x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.xxzxx swizzling.
        /// </summary>
        public decvec5 xxzxx => new decvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.rrbrr swizzling (equivalent to decvec4.xxzxx).
        /// </summary>
        public decvec5 rrbrr => new decvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.xxzxy swizzling.
        /// </summary>
        public decvec5 xxzxy => new decvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.rrbrg swizzling (equivalent to decvec4.xxzxy).
        /// </summary>
        public decvec5 rrbrg => new decvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.xxzxz swizzling.
        /// </summary>
        public decvec5 xxzxz => new decvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.rrbrb swizzling (equivalent to decvec4.xxzxz).
        /// </summary>
        public decvec5 rrbrb => new decvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.xxzxw swizzling.
        /// </summary>
        public decvec5 xxzxw => new decvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.rrbra swizzling (equivalent to decvec4.xxzxw).
        /// </summary>
        public decvec5 rrbra => new decvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.xxzy swizzling.
        /// </summary>
        public decvec4 xxzy => new decvec4(x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.rrbg swizzling (equivalent to decvec4.xxzy).
        /// </summary>
        public decvec4 rrbg => new decvec4(x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.xxzyx swizzling.
        /// </summary>
        public decvec5 xxzyx => new decvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.rrbgr swizzling (equivalent to decvec4.xxzyx).
        /// </summary>
        public decvec5 rrbgr => new decvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.xxzyy swizzling.
        /// </summary>
        public decvec5 xxzyy => new decvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.rrbgg swizzling (equivalent to decvec4.xxzyy).
        /// </summary>
        public decvec5 rrbgg => new decvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.xxzyz swizzling.
        /// </summary>
        public decvec5 xxzyz => new decvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.rrbgb swizzling (equivalent to decvec4.xxzyz).
        /// </summary>
        public decvec5 rrbgb => new decvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.xxzyw swizzling.
        /// </summary>
        public decvec5 xxzyw => new decvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.rrbga swizzling (equivalent to decvec4.xxzyw).
        /// </summary>
        public decvec5 rrbga => new decvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.xxzz swizzling.
        /// </summary>
        public decvec4 xxzz => new decvec4(x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.rrbb swizzling (equivalent to decvec4.xxzz).
        /// </summary>
        public decvec4 rrbb => new decvec4(x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.xxzzx swizzling.
        /// </summary>
        public decvec5 xxzzx => new decvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.rrbbr swizzling (equivalent to decvec4.xxzzx).
        /// </summary>
        public decvec5 rrbbr => new decvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.xxzzy swizzling.
        /// </summary>
        public decvec5 xxzzy => new decvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.rrbbg swizzling (equivalent to decvec4.xxzzy).
        /// </summary>
        public decvec5 rrbbg => new decvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.xxzzz swizzling.
        /// </summary>
        public decvec5 xxzzz => new decvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.rrbbb swizzling (equivalent to decvec4.xxzzz).
        /// </summary>
        public decvec5 rrbbb => new decvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.xxzzw swizzling.
        /// </summary>
        public decvec5 xxzzw => new decvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.rrbba swizzling (equivalent to decvec4.xxzzw).
        /// </summary>
        public decvec5 rrbba => new decvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.xxzw swizzling.
        /// </summary>
        public decvec4 xxzw => new decvec4(x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.rrba swizzling (equivalent to decvec4.xxzw).
        /// </summary>
        public decvec4 rrba => new decvec4(x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.xxzwx swizzling.
        /// </summary>
        public decvec5 xxzwx => new decvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.rrbar swizzling (equivalent to decvec4.xxzwx).
        /// </summary>
        public decvec5 rrbar => new decvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.xxzwy swizzling.
        /// </summary>
        public decvec5 xxzwy => new decvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.rrbag swizzling (equivalent to decvec4.xxzwy).
        /// </summary>
        public decvec5 rrbag => new decvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.xxzwz swizzling.
        /// </summary>
        public decvec5 xxzwz => new decvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.rrbab swizzling (equivalent to decvec4.xxzwz).
        /// </summary>
        public decvec5 rrbab => new decvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.xxzww swizzling.
        /// </summary>
        public decvec5 xxzww => new decvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.rrbaa swizzling (equivalent to decvec4.xxzww).
        /// </summary>
        public decvec5 rrbaa => new decvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.xxw swizzling.
        /// </summary>
        public decvec3 xxw => new decvec3(x, x, w);
        
        /// <summary>
        /// Returns decvec4.rra swizzling (equivalent to decvec4.xxw).
        /// </summary>
        public decvec3 rra => new decvec3(x, x, w);
        
        /// <summary>
        /// Returns decvec4.xxwx swizzling.
        /// </summary>
        public decvec4 xxwx => new decvec4(x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.rrar swizzling (equivalent to decvec4.xxwx).
        /// </summary>
        public decvec4 rrar => new decvec4(x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.xxwxx swizzling.
        /// </summary>
        public decvec5 xxwxx => new decvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.rrarr swizzling (equivalent to decvec4.xxwxx).
        /// </summary>
        public decvec5 rrarr => new decvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.xxwxy swizzling.
        /// </summary>
        public decvec5 xxwxy => new decvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.rrarg swizzling (equivalent to decvec4.xxwxy).
        /// </summary>
        public decvec5 rrarg => new decvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.xxwxz swizzling.
        /// </summary>
        public decvec5 xxwxz => new decvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.rrarb swizzling (equivalent to decvec4.xxwxz).
        /// </summary>
        public decvec5 rrarb => new decvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.xxwxw swizzling.
        /// </summary>
        public decvec5 xxwxw => new decvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.rrara swizzling (equivalent to decvec4.xxwxw).
        /// </summary>
        public decvec5 rrara => new decvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.xxwy swizzling.
        /// </summary>
        public decvec4 xxwy => new decvec4(x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.rrag swizzling (equivalent to decvec4.xxwy).
        /// </summary>
        public decvec4 rrag => new decvec4(x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.xxwyx swizzling.
        /// </summary>
        public decvec5 xxwyx => new decvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.rragr swizzling (equivalent to decvec4.xxwyx).
        /// </summary>
        public decvec5 rragr => new decvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.xxwyy swizzling.
        /// </summary>
        public decvec5 xxwyy => new decvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.rragg swizzling (equivalent to decvec4.xxwyy).
        /// </summary>
        public decvec5 rragg => new decvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.xxwyz swizzling.
        /// </summary>
        public decvec5 xxwyz => new decvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.rragb swizzling (equivalent to decvec4.xxwyz).
        /// </summary>
        public decvec5 rragb => new decvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.xxwyw swizzling.
        /// </summary>
        public decvec5 xxwyw => new decvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.rraga swizzling (equivalent to decvec4.xxwyw).
        /// </summary>
        public decvec5 rraga => new decvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.xxwz swizzling.
        /// </summary>
        public decvec4 xxwz => new decvec4(x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.rrab swizzling (equivalent to decvec4.xxwz).
        /// </summary>
        public decvec4 rrab => new decvec4(x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.xxwzx swizzling.
        /// </summary>
        public decvec5 xxwzx => new decvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.rrabr swizzling (equivalent to decvec4.xxwzx).
        /// </summary>
        public decvec5 rrabr => new decvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.xxwzy swizzling.
        /// </summary>
        public decvec5 xxwzy => new decvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.rrabg swizzling (equivalent to decvec4.xxwzy).
        /// </summary>
        public decvec5 rrabg => new decvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.xxwzz swizzling.
        /// </summary>
        public decvec5 xxwzz => new decvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.rrabb swizzling (equivalent to decvec4.xxwzz).
        /// </summary>
        public decvec5 rrabb => new decvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.xxwzw swizzling.
        /// </summary>
        public decvec5 xxwzw => new decvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.rraba swizzling (equivalent to decvec4.xxwzw).
        /// </summary>
        public decvec5 rraba => new decvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.xxww swizzling.
        /// </summary>
        public decvec4 xxww => new decvec4(x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.rraa swizzling (equivalent to decvec4.xxww).
        /// </summary>
        public decvec4 rraa => new decvec4(x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.xxwwx swizzling.
        /// </summary>
        public decvec5 xxwwx => new decvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.rraar swizzling (equivalent to decvec4.xxwwx).
        /// </summary>
        public decvec5 rraar => new decvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.xxwwy swizzling.
        /// </summary>
        public decvec5 xxwwy => new decvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.rraag swizzling (equivalent to decvec4.xxwwy).
        /// </summary>
        public decvec5 rraag => new decvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.xxwwz swizzling.
        /// </summary>
        public decvec5 xxwwz => new decvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.rraab swizzling (equivalent to decvec4.xxwwz).
        /// </summary>
        public decvec5 rraab => new decvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.xxwww swizzling.
        /// </summary>
        public decvec5 xxwww => new decvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.rraaa swizzling (equivalent to decvec4.xxwww).
        /// </summary>
        public decvec5 rraaa => new decvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.xy swizzling.
        /// </summary>
        public decvec2 xy => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec4.rg swizzling (equivalent to decvec4.xy).
        /// </summary>
        public decvec2 rg => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec4.xyx swizzling.
        /// </summary>
        public decvec3 xyx => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec4.rgr swizzling (equivalent to decvec4.xyx).
        /// </summary>
        public decvec3 rgr => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec4.xyxx swizzling.
        /// </summary>
        public decvec4 xyxx => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.rgrr swizzling (equivalent to decvec4.xyxx).
        /// </summary>
        public decvec4 rgrr => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.xyxxx swizzling.
        /// </summary>
        public decvec5 xyxxx => new decvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.rgrrr swizzling (equivalent to decvec4.xyxxx).
        /// </summary>
        public decvec5 rgrrr => new decvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.xyxxy swizzling.
        /// </summary>
        public decvec5 xyxxy => new decvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.rgrrg swizzling (equivalent to decvec4.xyxxy).
        /// </summary>
        public decvec5 rgrrg => new decvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.xyxxz swizzling.
        /// </summary>
        public decvec5 xyxxz => new decvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.rgrrb swizzling (equivalent to decvec4.xyxxz).
        /// </summary>
        public decvec5 rgrrb => new decvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.xyxxw swizzling.
        /// </summary>
        public decvec5 xyxxw => new decvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.rgrra swizzling (equivalent to decvec4.xyxxw).
        /// </summary>
        public decvec5 rgrra => new decvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.xyxy swizzling.
        /// </summary>
        public decvec4 xyxy => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.rgrg swizzling (equivalent to decvec4.xyxy).
        /// </summary>
        public decvec4 rgrg => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.xyxyx swizzling.
        /// </summary>
        public decvec5 xyxyx => new decvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.rgrgr swizzling (equivalent to decvec4.xyxyx).
        /// </summary>
        public decvec5 rgrgr => new decvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.xyxyy swizzling.
        /// </summary>
        public decvec5 xyxyy => new decvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.rgrgg swizzling (equivalent to decvec4.xyxyy).
        /// </summary>
        public decvec5 rgrgg => new decvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.xyxyz swizzling.
        /// </summary>
        public decvec5 xyxyz => new decvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.rgrgb swizzling (equivalent to decvec4.xyxyz).
        /// </summary>
        public decvec5 rgrgb => new decvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.xyxyw swizzling.
        /// </summary>
        public decvec5 xyxyw => new decvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.rgrga swizzling (equivalent to decvec4.xyxyw).
        /// </summary>
        public decvec5 rgrga => new decvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.xyxz swizzling.
        /// </summary>
        public decvec4 xyxz => new decvec4(x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.rgrb swizzling (equivalent to decvec4.xyxz).
        /// </summary>
        public decvec4 rgrb => new decvec4(x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.xyxzx swizzling.
        /// </summary>
        public decvec5 xyxzx => new decvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.rgrbr swizzling (equivalent to decvec4.xyxzx).
        /// </summary>
        public decvec5 rgrbr => new decvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.xyxzy swizzling.
        /// </summary>
        public decvec5 xyxzy => new decvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.rgrbg swizzling (equivalent to decvec4.xyxzy).
        /// </summary>
        public decvec5 rgrbg => new decvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.xyxzz swizzling.
        /// </summary>
        public decvec5 xyxzz => new decvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.rgrbb swizzling (equivalent to decvec4.xyxzz).
        /// </summary>
        public decvec5 rgrbb => new decvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.xyxzw swizzling.
        /// </summary>
        public decvec5 xyxzw => new decvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.rgrba swizzling (equivalent to decvec4.xyxzw).
        /// </summary>
        public decvec5 rgrba => new decvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.xyxw swizzling.
        /// </summary>
        public decvec4 xyxw => new decvec4(x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.rgra swizzling (equivalent to decvec4.xyxw).
        /// </summary>
        public decvec4 rgra => new decvec4(x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.xyxwx swizzling.
        /// </summary>
        public decvec5 xyxwx => new decvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.rgrar swizzling (equivalent to decvec4.xyxwx).
        /// </summary>
        public decvec5 rgrar => new decvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.xyxwy swizzling.
        /// </summary>
        public decvec5 xyxwy => new decvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.rgrag swizzling (equivalent to decvec4.xyxwy).
        /// </summary>
        public decvec5 rgrag => new decvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.xyxwz swizzling.
        /// </summary>
        public decvec5 xyxwz => new decvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.rgrab swizzling (equivalent to decvec4.xyxwz).
        /// </summary>
        public decvec5 rgrab => new decvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.xyxww swizzling.
        /// </summary>
        public decvec5 xyxww => new decvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.rgraa swizzling (equivalent to decvec4.xyxww).
        /// </summary>
        public decvec5 rgraa => new decvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.xyy swizzling.
        /// </summary>
        public decvec3 xyy => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec4.rgg swizzling (equivalent to decvec4.xyy).
        /// </summary>
        public decvec3 rgg => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec4.xyyx swizzling.
        /// </summary>
        public decvec4 xyyx => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.rggr swizzling (equivalent to decvec4.xyyx).
        /// </summary>
        public decvec4 rggr => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.xyyxx swizzling.
        /// </summary>
        public decvec5 xyyxx => new decvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.rggrr swizzling (equivalent to decvec4.xyyxx).
        /// </summary>
        public decvec5 rggrr => new decvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.xyyxy swizzling.
        /// </summary>
        public decvec5 xyyxy => new decvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.rggrg swizzling (equivalent to decvec4.xyyxy).
        /// </summary>
        public decvec5 rggrg => new decvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.xyyxz swizzling.
        /// </summary>
        public decvec5 xyyxz => new decvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.rggrb swizzling (equivalent to decvec4.xyyxz).
        /// </summary>
        public decvec5 rggrb => new decvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.xyyxw swizzling.
        /// </summary>
        public decvec5 xyyxw => new decvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.rggra swizzling (equivalent to decvec4.xyyxw).
        /// </summary>
        public decvec5 rggra => new decvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.xyyy swizzling.
        /// </summary>
        public decvec4 xyyy => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.rggg swizzling (equivalent to decvec4.xyyy).
        /// </summary>
        public decvec4 rggg => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.xyyyx swizzling.
        /// </summary>
        public decvec5 xyyyx => new decvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.rgggr swizzling (equivalent to decvec4.xyyyx).
        /// </summary>
        public decvec5 rgggr => new decvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.xyyyy swizzling.
        /// </summary>
        public decvec5 xyyyy => new decvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.rgggg swizzling (equivalent to decvec4.xyyyy).
        /// </summary>
        public decvec5 rgggg => new decvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.xyyyz swizzling.
        /// </summary>
        public decvec5 xyyyz => new decvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.rgggb swizzling (equivalent to decvec4.xyyyz).
        /// </summary>
        public decvec5 rgggb => new decvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.xyyyw swizzling.
        /// </summary>
        public decvec5 xyyyw => new decvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.rggga swizzling (equivalent to decvec4.xyyyw).
        /// </summary>
        public decvec5 rggga => new decvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.xyyz swizzling.
        /// </summary>
        public decvec4 xyyz => new decvec4(x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.rggb swizzling (equivalent to decvec4.xyyz).
        /// </summary>
        public decvec4 rggb => new decvec4(x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.xyyzx swizzling.
        /// </summary>
        public decvec5 xyyzx => new decvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.rggbr swizzling (equivalent to decvec4.xyyzx).
        /// </summary>
        public decvec5 rggbr => new decvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.xyyzy swizzling.
        /// </summary>
        public decvec5 xyyzy => new decvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.rggbg swizzling (equivalent to decvec4.xyyzy).
        /// </summary>
        public decvec5 rggbg => new decvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.xyyzz swizzling.
        /// </summary>
        public decvec5 xyyzz => new decvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.rggbb swizzling (equivalent to decvec4.xyyzz).
        /// </summary>
        public decvec5 rggbb => new decvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.xyyzw swizzling.
        /// </summary>
        public decvec5 xyyzw => new decvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.rggba swizzling (equivalent to decvec4.xyyzw).
        /// </summary>
        public decvec5 rggba => new decvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.xyyw swizzling.
        /// </summary>
        public decvec4 xyyw => new decvec4(x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.rgga swizzling (equivalent to decvec4.xyyw).
        /// </summary>
        public decvec4 rgga => new decvec4(x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.xyywx swizzling.
        /// </summary>
        public decvec5 xyywx => new decvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.rggar swizzling (equivalent to decvec4.xyywx).
        /// </summary>
        public decvec5 rggar => new decvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.xyywy swizzling.
        /// </summary>
        public decvec5 xyywy => new decvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.rggag swizzling (equivalent to decvec4.xyywy).
        /// </summary>
        public decvec5 rggag => new decvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.xyywz swizzling.
        /// </summary>
        public decvec5 xyywz => new decvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.rggab swizzling (equivalent to decvec4.xyywz).
        /// </summary>
        public decvec5 rggab => new decvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.xyyww swizzling.
        /// </summary>
        public decvec5 xyyww => new decvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.rggaa swizzling (equivalent to decvec4.xyyww).
        /// </summary>
        public decvec5 rggaa => new decvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.xyz swizzling.
        /// </summary>
        public decvec3 xyz => new decvec3(x, y, z);
        
        /// <summary>
        /// Returns decvec4.rgb swizzling (equivalent to decvec4.xyz).
        /// </summary>
        public decvec3 rgb => new decvec3(x, y, z);
        
        /// <summary>
        /// Returns decvec4.xyzx swizzling.
        /// </summary>
        public decvec4 xyzx => new decvec4(x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.rgbr swizzling (equivalent to decvec4.xyzx).
        /// </summary>
        public decvec4 rgbr => new decvec4(x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.xyzxx swizzling.
        /// </summary>
        public decvec5 xyzxx => new decvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.rgbrr swizzling (equivalent to decvec4.xyzxx).
        /// </summary>
        public decvec5 rgbrr => new decvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.xyzxy swizzling.
        /// </summary>
        public decvec5 xyzxy => new decvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.rgbrg swizzling (equivalent to decvec4.xyzxy).
        /// </summary>
        public decvec5 rgbrg => new decvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.xyzxz swizzling.
        /// </summary>
        public decvec5 xyzxz => new decvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.rgbrb swizzling (equivalent to decvec4.xyzxz).
        /// </summary>
        public decvec5 rgbrb => new decvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.xyzxw swizzling.
        /// </summary>
        public decvec5 xyzxw => new decvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.rgbra swizzling (equivalent to decvec4.xyzxw).
        /// </summary>
        public decvec5 rgbra => new decvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.xyzy swizzling.
        /// </summary>
        public decvec4 xyzy => new decvec4(x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.rgbg swizzling (equivalent to decvec4.xyzy).
        /// </summary>
        public decvec4 rgbg => new decvec4(x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.xyzyx swizzling.
        /// </summary>
        public decvec5 xyzyx => new decvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.rgbgr swizzling (equivalent to decvec4.xyzyx).
        /// </summary>
        public decvec5 rgbgr => new decvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.xyzyy swizzling.
        /// </summary>
        public decvec5 xyzyy => new decvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.rgbgg swizzling (equivalent to decvec4.xyzyy).
        /// </summary>
        public decvec5 rgbgg => new decvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.xyzyz swizzling.
        /// </summary>
        public decvec5 xyzyz => new decvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.rgbgb swizzling (equivalent to decvec4.xyzyz).
        /// </summary>
        public decvec5 rgbgb => new decvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.xyzyw swizzling.
        /// </summary>
        public decvec5 xyzyw => new decvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.rgbga swizzling (equivalent to decvec4.xyzyw).
        /// </summary>
        public decvec5 rgbga => new decvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.xyzz swizzling.
        /// </summary>
        public decvec4 xyzz => new decvec4(x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.rgbb swizzling (equivalent to decvec4.xyzz).
        /// </summary>
        public decvec4 rgbb => new decvec4(x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.xyzzx swizzling.
        /// </summary>
        public decvec5 xyzzx => new decvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.rgbbr swizzling (equivalent to decvec4.xyzzx).
        /// </summary>
        public decvec5 rgbbr => new decvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.xyzzy swizzling.
        /// </summary>
        public decvec5 xyzzy => new decvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.rgbbg swizzling (equivalent to decvec4.xyzzy).
        /// </summary>
        public decvec5 rgbbg => new decvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.xyzzz swizzling.
        /// </summary>
        public decvec5 xyzzz => new decvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.rgbbb swizzling (equivalent to decvec4.xyzzz).
        /// </summary>
        public decvec5 rgbbb => new decvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.xyzzw swizzling.
        /// </summary>
        public decvec5 xyzzw => new decvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.rgbba swizzling (equivalent to decvec4.xyzzw).
        /// </summary>
        public decvec5 rgbba => new decvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.xyzw swizzling.
        /// </summary>
        public decvec4 xyzw => new decvec4(x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.rgba swizzling (equivalent to decvec4.xyzw).
        /// </summary>
        public decvec4 rgba => new decvec4(x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.xyzwx swizzling.
        /// </summary>
        public decvec5 xyzwx => new decvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.rgbar swizzling (equivalent to decvec4.xyzwx).
        /// </summary>
        public decvec5 rgbar => new decvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.xyzwy swizzling.
        /// </summary>
        public decvec5 xyzwy => new decvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.rgbag swizzling (equivalent to decvec4.xyzwy).
        /// </summary>
        public decvec5 rgbag => new decvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.xyzwz swizzling.
        /// </summary>
        public decvec5 xyzwz => new decvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.rgbab swizzling (equivalent to decvec4.xyzwz).
        /// </summary>
        public decvec5 rgbab => new decvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.xyzww swizzling.
        /// </summary>
        public decvec5 xyzww => new decvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.rgbaa swizzling (equivalent to decvec4.xyzww).
        /// </summary>
        public decvec5 rgbaa => new decvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.xyw swizzling.
        /// </summary>
        public decvec3 xyw => new decvec3(x, y, w);
        
        /// <summary>
        /// Returns decvec4.rga swizzling (equivalent to decvec4.xyw).
        /// </summary>
        public decvec3 rga => new decvec3(x, y, w);
        
        /// <summary>
        /// Returns decvec4.xywx swizzling.
        /// </summary>
        public decvec4 xywx => new decvec4(x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.rgar swizzling (equivalent to decvec4.xywx).
        /// </summary>
        public decvec4 rgar => new decvec4(x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.xywxx swizzling.
        /// </summary>
        public decvec5 xywxx => new decvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.rgarr swizzling (equivalent to decvec4.xywxx).
        /// </summary>
        public decvec5 rgarr => new decvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.xywxy swizzling.
        /// </summary>
        public decvec5 xywxy => new decvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.rgarg swizzling (equivalent to decvec4.xywxy).
        /// </summary>
        public decvec5 rgarg => new decvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.xywxz swizzling.
        /// </summary>
        public decvec5 xywxz => new decvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.rgarb swizzling (equivalent to decvec4.xywxz).
        /// </summary>
        public decvec5 rgarb => new decvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.xywxw swizzling.
        /// </summary>
        public decvec5 xywxw => new decvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.rgara swizzling (equivalent to decvec4.xywxw).
        /// </summary>
        public decvec5 rgara => new decvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.xywy swizzling.
        /// </summary>
        public decvec4 xywy => new decvec4(x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.rgag swizzling (equivalent to decvec4.xywy).
        /// </summary>
        public decvec4 rgag => new decvec4(x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.xywyx swizzling.
        /// </summary>
        public decvec5 xywyx => new decvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.rgagr swizzling (equivalent to decvec4.xywyx).
        /// </summary>
        public decvec5 rgagr => new decvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.xywyy swizzling.
        /// </summary>
        public decvec5 xywyy => new decvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.rgagg swizzling (equivalent to decvec4.xywyy).
        /// </summary>
        public decvec5 rgagg => new decvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.xywyz swizzling.
        /// </summary>
        public decvec5 xywyz => new decvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.rgagb swizzling (equivalent to decvec4.xywyz).
        /// </summary>
        public decvec5 rgagb => new decvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.xywyw swizzling.
        /// </summary>
        public decvec5 xywyw => new decvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.rgaga swizzling (equivalent to decvec4.xywyw).
        /// </summary>
        public decvec5 rgaga => new decvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.xywz swizzling.
        /// </summary>
        public decvec4 xywz => new decvec4(x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.rgab swizzling (equivalent to decvec4.xywz).
        /// </summary>
        public decvec4 rgab => new decvec4(x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.xywzx swizzling.
        /// </summary>
        public decvec5 xywzx => new decvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.rgabr swizzling (equivalent to decvec4.xywzx).
        /// </summary>
        public decvec5 rgabr => new decvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.xywzy swizzling.
        /// </summary>
        public decvec5 xywzy => new decvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.rgabg swizzling (equivalent to decvec4.xywzy).
        /// </summary>
        public decvec5 rgabg => new decvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.xywzz swizzling.
        /// </summary>
        public decvec5 xywzz => new decvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.rgabb swizzling (equivalent to decvec4.xywzz).
        /// </summary>
        public decvec5 rgabb => new decvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.xywzw swizzling.
        /// </summary>
        public decvec5 xywzw => new decvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.rgaba swizzling (equivalent to decvec4.xywzw).
        /// </summary>
        public decvec5 rgaba => new decvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.xyww swizzling.
        /// </summary>
        public decvec4 xyww => new decvec4(x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.rgaa swizzling (equivalent to decvec4.xyww).
        /// </summary>
        public decvec4 rgaa => new decvec4(x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.xywwx swizzling.
        /// </summary>
        public decvec5 xywwx => new decvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.rgaar swizzling (equivalent to decvec4.xywwx).
        /// </summary>
        public decvec5 rgaar => new decvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.xywwy swizzling.
        /// </summary>
        public decvec5 xywwy => new decvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.rgaag swizzling (equivalent to decvec4.xywwy).
        /// </summary>
        public decvec5 rgaag => new decvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.xywwz swizzling.
        /// </summary>
        public decvec5 xywwz => new decvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.rgaab swizzling (equivalent to decvec4.xywwz).
        /// </summary>
        public decvec5 rgaab => new decvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.xywww swizzling.
        /// </summary>
        public decvec5 xywww => new decvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.rgaaa swizzling (equivalent to decvec4.xywww).
        /// </summary>
        public decvec5 rgaaa => new decvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.xz swizzling.
        /// </summary>
        public decvec2 xz => new decvec2(x, z);
        
        /// <summary>
        /// Returns decvec4.rb swizzling (equivalent to decvec4.xz).
        /// </summary>
        public decvec2 rb => new decvec2(x, z);
        
        /// <summary>
        /// Returns decvec4.xzx swizzling.
        /// </summary>
        public decvec3 xzx => new decvec3(x, z, x);
        
        /// <summary>
        /// Returns decvec4.rbr swizzling (equivalent to decvec4.xzx).
        /// </summary>
        public decvec3 rbr => new decvec3(x, z, x);
        
        /// <summary>
        /// Returns decvec4.xzxx swizzling.
        /// </summary>
        public decvec4 xzxx => new decvec4(x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.rbrr swizzling (equivalent to decvec4.xzxx).
        /// </summary>
        public decvec4 rbrr => new decvec4(x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.xzxxx swizzling.
        /// </summary>
        public decvec5 xzxxx => new decvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.rbrrr swizzling (equivalent to decvec4.xzxxx).
        /// </summary>
        public decvec5 rbrrr => new decvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.xzxxy swizzling.
        /// </summary>
        public decvec5 xzxxy => new decvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.rbrrg swizzling (equivalent to decvec4.xzxxy).
        /// </summary>
        public decvec5 rbrrg => new decvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.xzxxz swizzling.
        /// </summary>
        public decvec5 xzxxz => new decvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.rbrrb swizzling (equivalent to decvec4.xzxxz).
        /// </summary>
        public decvec5 rbrrb => new decvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.xzxxw swizzling.
        /// </summary>
        public decvec5 xzxxw => new decvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.rbrra swizzling (equivalent to decvec4.xzxxw).
        /// </summary>
        public decvec5 rbrra => new decvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.xzxy swizzling.
        /// </summary>
        public decvec4 xzxy => new decvec4(x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.rbrg swizzling (equivalent to decvec4.xzxy).
        /// </summary>
        public decvec4 rbrg => new decvec4(x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.xzxyx swizzling.
        /// </summary>
        public decvec5 xzxyx => new decvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.rbrgr swizzling (equivalent to decvec4.xzxyx).
        /// </summary>
        public decvec5 rbrgr => new decvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.xzxyy swizzling.
        /// </summary>
        public decvec5 xzxyy => new decvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.rbrgg swizzling (equivalent to decvec4.xzxyy).
        /// </summary>
        public decvec5 rbrgg => new decvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.xzxyz swizzling.
        /// </summary>
        public decvec5 xzxyz => new decvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.rbrgb swizzling (equivalent to decvec4.xzxyz).
        /// </summary>
        public decvec5 rbrgb => new decvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.xzxyw swizzling.
        /// </summary>
        public decvec5 xzxyw => new decvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.rbrga swizzling (equivalent to decvec4.xzxyw).
        /// </summary>
        public decvec5 rbrga => new decvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.xzxz swizzling.
        /// </summary>
        public decvec4 xzxz => new decvec4(x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.rbrb swizzling (equivalent to decvec4.xzxz).
        /// </summary>
        public decvec4 rbrb => new decvec4(x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.xzxzx swizzling.
        /// </summary>
        public decvec5 xzxzx => new decvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.rbrbr swizzling (equivalent to decvec4.xzxzx).
        /// </summary>
        public decvec5 rbrbr => new decvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.xzxzy swizzling.
        /// </summary>
        public decvec5 xzxzy => new decvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.rbrbg swizzling (equivalent to decvec4.xzxzy).
        /// </summary>
        public decvec5 rbrbg => new decvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.xzxzz swizzling.
        /// </summary>
        public decvec5 xzxzz => new decvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.rbrbb swizzling (equivalent to decvec4.xzxzz).
        /// </summary>
        public decvec5 rbrbb => new decvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.xzxzw swizzling.
        /// </summary>
        public decvec5 xzxzw => new decvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.rbrba swizzling (equivalent to decvec4.xzxzw).
        /// </summary>
        public decvec5 rbrba => new decvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.xzxw swizzling.
        /// </summary>
        public decvec4 xzxw => new decvec4(x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.rbra swizzling (equivalent to decvec4.xzxw).
        /// </summary>
        public decvec4 rbra => new decvec4(x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.xzxwx swizzling.
        /// </summary>
        public decvec5 xzxwx => new decvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.rbrar swizzling (equivalent to decvec4.xzxwx).
        /// </summary>
        public decvec5 rbrar => new decvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.xzxwy swizzling.
        /// </summary>
        public decvec5 xzxwy => new decvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.rbrag swizzling (equivalent to decvec4.xzxwy).
        /// </summary>
        public decvec5 rbrag => new decvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.xzxwz swizzling.
        /// </summary>
        public decvec5 xzxwz => new decvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.rbrab swizzling (equivalent to decvec4.xzxwz).
        /// </summary>
        public decvec5 rbrab => new decvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.xzxww swizzling.
        /// </summary>
        public decvec5 xzxww => new decvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.rbraa swizzling (equivalent to decvec4.xzxww).
        /// </summary>
        public decvec5 rbraa => new decvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.xzy swizzling.
        /// </summary>
        public decvec3 xzy => new decvec3(x, z, y);
        
        /// <summary>
        /// Returns decvec4.rbg swizzling (equivalent to decvec4.xzy).
        /// </summary>
        public decvec3 rbg => new decvec3(x, z, y);
        
        /// <summary>
        /// Returns decvec4.xzyx swizzling.
        /// </summary>
        public decvec4 xzyx => new decvec4(x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.rbgr swizzling (equivalent to decvec4.xzyx).
        /// </summary>
        public decvec4 rbgr => new decvec4(x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.xzyxx swizzling.
        /// </summary>
        public decvec5 xzyxx => new decvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.rbgrr swizzling (equivalent to decvec4.xzyxx).
        /// </summary>
        public decvec5 rbgrr => new decvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.xzyxy swizzling.
        /// </summary>
        public decvec5 xzyxy => new decvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.rbgrg swizzling (equivalent to decvec4.xzyxy).
        /// </summary>
        public decvec5 rbgrg => new decvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.xzyxz swizzling.
        /// </summary>
        public decvec5 xzyxz => new decvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.rbgrb swizzling (equivalent to decvec4.xzyxz).
        /// </summary>
        public decvec5 rbgrb => new decvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.xzyxw swizzling.
        /// </summary>
        public decvec5 xzyxw => new decvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.rbgra swizzling (equivalent to decvec4.xzyxw).
        /// </summary>
        public decvec5 rbgra => new decvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.xzyy swizzling.
        /// </summary>
        public decvec4 xzyy => new decvec4(x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.rbgg swizzling (equivalent to decvec4.xzyy).
        /// </summary>
        public decvec4 rbgg => new decvec4(x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.xzyyx swizzling.
        /// </summary>
        public decvec5 xzyyx => new decvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.rbggr swizzling (equivalent to decvec4.xzyyx).
        /// </summary>
        public decvec5 rbggr => new decvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.xzyyy swizzling.
        /// </summary>
        public decvec5 xzyyy => new decvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.rbggg swizzling (equivalent to decvec4.xzyyy).
        /// </summary>
        public decvec5 rbggg => new decvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.xzyyz swizzling.
        /// </summary>
        public decvec5 xzyyz => new decvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.rbggb swizzling (equivalent to decvec4.xzyyz).
        /// </summary>
        public decvec5 rbggb => new decvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.xzyyw swizzling.
        /// </summary>
        public decvec5 xzyyw => new decvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.rbgga swizzling (equivalent to decvec4.xzyyw).
        /// </summary>
        public decvec5 rbgga => new decvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.xzyz swizzling.
        /// </summary>
        public decvec4 xzyz => new decvec4(x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.rbgb swizzling (equivalent to decvec4.xzyz).
        /// </summary>
        public decvec4 rbgb => new decvec4(x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.xzyzx swizzling.
        /// </summary>
        public decvec5 xzyzx => new decvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.rbgbr swizzling (equivalent to decvec4.xzyzx).
        /// </summary>
        public decvec5 rbgbr => new decvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.xzyzy swizzling.
        /// </summary>
        public decvec5 xzyzy => new decvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.rbgbg swizzling (equivalent to decvec4.xzyzy).
        /// </summary>
        public decvec5 rbgbg => new decvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.xzyzz swizzling.
        /// </summary>
        public decvec5 xzyzz => new decvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.rbgbb swizzling (equivalent to decvec4.xzyzz).
        /// </summary>
        public decvec5 rbgbb => new decvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.xzyzw swizzling.
        /// </summary>
        public decvec5 xzyzw => new decvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.rbgba swizzling (equivalent to decvec4.xzyzw).
        /// </summary>
        public decvec5 rbgba => new decvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.xzyw swizzling.
        /// </summary>
        public decvec4 xzyw => new decvec4(x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.rbga swizzling (equivalent to decvec4.xzyw).
        /// </summary>
        public decvec4 rbga => new decvec4(x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.xzywx swizzling.
        /// </summary>
        public decvec5 xzywx => new decvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.rbgar swizzling (equivalent to decvec4.xzywx).
        /// </summary>
        public decvec5 rbgar => new decvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.xzywy swizzling.
        /// </summary>
        public decvec5 xzywy => new decvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.rbgag swizzling (equivalent to decvec4.xzywy).
        /// </summary>
        public decvec5 rbgag => new decvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.xzywz swizzling.
        /// </summary>
        public decvec5 xzywz => new decvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.rbgab swizzling (equivalent to decvec4.xzywz).
        /// </summary>
        public decvec5 rbgab => new decvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.xzyww swizzling.
        /// </summary>
        public decvec5 xzyww => new decvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.rbgaa swizzling (equivalent to decvec4.xzyww).
        /// </summary>
        public decvec5 rbgaa => new decvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.xzz swizzling.
        /// </summary>
        public decvec3 xzz => new decvec3(x, z, z);
        
        /// <summary>
        /// Returns decvec4.rbb swizzling (equivalent to decvec4.xzz).
        /// </summary>
        public decvec3 rbb => new decvec3(x, z, z);
        
        /// <summary>
        /// Returns decvec4.xzzx swizzling.
        /// </summary>
        public decvec4 xzzx => new decvec4(x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.rbbr swizzling (equivalent to decvec4.xzzx).
        /// </summary>
        public decvec4 rbbr => new decvec4(x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.xzzxx swizzling.
        /// </summary>
        public decvec5 xzzxx => new decvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.rbbrr swizzling (equivalent to decvec4.xzzxx).
        /// </summary>
        public decvec5 rbbrr => new decvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.xzzxy swizzling.
        /// </summary>
        public decvec5 xzzxy => new decvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.rbbrg swizzling (equivalent to decvec4.xzzxy).
        /// </summary>
        public decvec5 rbbrg => new decvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.xzzxz swizzling.
        /// </summary>
        public decvec5 xzzxz => new decvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.rbbrb swizzling (equivalent to decvec4.xzzxz).
        /// </summary>
        public decvec5 rbbrb => new decvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.xzzxw swizzling.
        /// </summary>
        public decvec5 xzzxw => new decvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.rbbra swizzling (equivalent to decvec4.xzzxw).
        /// </summary>
        public decvec5 rbbra => new decvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.xzzy swizzling.
        /// </summary>
        public decvec4 xzzy => new decvec4(x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.rbbg swizzling (equivalent to decvec4.xzzy).
        /// </summary>
        public decvec4 rbbg => new decvec4(x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.xzzyx swizzling.
        /// </summary>
        public decvec5 xzzyx => new decvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.rbbgr swizzling (equivalent to decvec4.xzzyx).
        /// </summary>
        public decvec5 rbbgr => new decvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.xzzyy swizzling.
        /// </summary>
        public decvec5 xzzyy => new decvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.rbbgg swizzling (equivalent to decvec4.xzzyy).
        /// </summary>
        public decvec5 rbbgg => new decvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.xzzyz swizzling.
        /// </summary>
        public decvec5 xzzyz => new decvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.rbbgb swizzling (equivalent to decvec4.xzzyz).
        /// </summary>
        public decvec5 rbbgb => new decvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.xzzyw swizzling.
        /// </summary>
        public decvec5 xzzyw => new decvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.rbbga swizzling (equivalent to decvec4.xzzyw).
        /// </summary>
        public decvec5 rbbga => new decvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.xzzz swizzling.
        /// </summary>
        public decvec4 xzzz => new decvec4(x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.rbbb swizzling (equivalent to decvec4.xzzz).
        /// </summary>
        public decvec4 rbbb => new decvec4(x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.xzzzx swizzling.
        /// </summary>
        public decvec5 xzzzx => new decvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.rbbbr swizzling (equivalent to decvec4.xzzzx).
        /// </summary>
        public decvec5 rbbbr => new decvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.xzzzy swizzling.
        /// </summary>
        public decvec5 xzzzy => new decvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.rbbbg swizzling (equivalent to decvec4.xzzzy).
        /// </summary>
        public decvec5 rbbbg => new decvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.xzzzz swizzling.
        /// </summary>
        public decvec5 xzzzz => new decvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.rbbbb swizzling (equivalent to decvec4.xzzzz).
        /// </summary>
        public decvec5 rbbbb => new decvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.xzzzw swizzling.
        /// </summary>
        public decvec5 xzzzw => new decvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.rbbba swizzling (equivalent to decvec4.xzzzw).
        /// </summary>
        public decvec5 rbbba => new decvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.xzzw swizzling.
        /// </summary>
        public decvec4 xzzw => new decvec4(x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.rbba swizzling (equivalent to decvec4.xzzw).
        /// </summary>
        public decvec4 rbba => new decvec4(x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.xzzwx swizzling.
        /// </summary>
        public decvec5 xzzwx => new decvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.rbbar swizzling (equivalent to decvec4.xzzwx).
        /// </summary>
        public decvec5 rbbar => new decvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.xzzwy swizzling.
        /// </summary>
        public decvec5 xzzwy => new decvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.rbbag swizzling (equivalent to decvec4.xzzwy).
        /// </summary>
        public decvec5 rbbag => new decvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.xzzwz swizzling.
        /// </summary>
        public decvec5 xzzwz => new decvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.rbbab swizzling (equivalent to decvec4.xzzwz).
        /// </summary>
        public decvec5 rbbab => new decvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.xzzww swizzling.
        /// </summary>
        public decvec5 xzzww => new decvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.rbbaa swizzling (equivalent to decvec4.xzzww).
        /// </summary>
        public decvec5 rbbaa => new decvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.xzw swizzling.
        /// </summary>
        public decvec3 xzw => new decvec3(x, z, w);
        
        /// <summary>
        /// Returns decvec4.rba swizzling (equivalent to decvec4.xzw).
        /// </summary>
        public decvec3 rba => new decvec3(x, z, w);
        
        /// <summary>
        /// Returns decvec4.xzwx swizzling.
        /// </summary>
        public decvec4 xzwx => new decvec4(x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.rbar swizzling (equivalent to decvec4.xzwx).
        /// </summary>
        public decvec4 rbar => new decvec4(x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.xzwxx swizzling.
        /// </summary>
        public decvec5 xzwxx => new decvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.rbarr swizzling (equivalent to decvec4.xzwxx).
        /// </summary>
        public decvec5 rbarr => new decvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.xzwxy swizzling.
        /// </summary>
        public decvec5 xzwxy => new decvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.rbarg swizzling (equivalent to decvec4.xzwxy).
        /// </summary>
        public decvec5 rbarg => new decvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.xzwxz swizzling.
        /// </summary>
        public decvec5 xzwxz => new decvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.rbarb swizzling (equivalent to decvec4.xzwxz).
        /// </summary>
        public decvec5 rbarb => new decvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.xzwxw swizzling.
        /// </summary>
        public decvec5 xzwxw => new decvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.rbara swizzling (equivalent to decvec4.xzwxw).
        /// </summary>
        public decvec5 rbara => new decvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.xzwy swizzling.
        /// </summary>
        public decvec4 xzwy => new decvec4(x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.rbag swizzling (equivalent to decvec4.xzwy).
        /// </summary>
        public decvec4 rbag => new decvec4(x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.xzwyx swizzling.
        /// </summary>
        public decvec5 xzwyx => new decvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.rbagr swizzling (equivalent to decvec4.xzwyx).
        /// </summary>
        public decvec5 rbagr => new decvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.xzwyy swizzling.
        /// </summary>
        public decvec5 xzwyy => new decvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.rbagg swizzling (equivalent to decvec4.xzwyy).
        /// </summary>
        public decvec5 rbagg => new decvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.xzwyz swizzling.
        /// </summary>
        public decvec5 xzwyz => new decvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.rbagb swizzling (equivalent to decvec4.xzwyz).
        /// </summary>
        public decvec5 rbagb => new decvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.xzwyw swizzling.
        /// </summary>
        public decvec5 xzwyw => new decvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.rbaga swizzling (equivalent to decvec4.xzwyw).
        /// </summary>
        public decvec5 rbaga => new decvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.xzwz swizzling.
        /// </summary>
        public decvec4 xzwz => new decvec4(x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.rbab swizzling (equivalent to decvec4.xzwz).
        /// </summary>
        public decvec4 rbab => new decvec4(x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.xzwzx swizzling.
        /// </summary>
        public decvec5 xzwzx => new decvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.rbabr swizzling (equivalent to decvec4.xzwzx).
        /// </summary>
        public decvec5 rbabr => new decvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.xzwzy swizzling.
        /// </summary>
        public decvec5 xzwzy => new decvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.rbabg swizzling (equivalent to decvec4.xzwzy).
        /// </summary>
        public decvec5 rbabg => new decvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.xzwzz swizzling.
        /// </summary>
        public decvec5 xzwzz => new decvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.rbabb swizzling (equivalent to decvec4.xzwzz).
        /// </summary>
        public decvec5 rbabb => new decvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.xzwzw swizzling.
        /// </summary>
        public decvec5 xzwzw => new decvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.rbaba swizzling (equivalent to decvec4.xzwzw).
        /// </summary>
        public decvec5 rbaba => new decvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.xzww swizzling.
        /// </summary>
        public decvec4 xzww => new decvec4(x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.rbaa swizzling (equivalent to decvec4.xzww).
        /// </summary>
        public decvec4 rbaa => new decvec4(x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.xzwwx swizzling.
        /// </summary>
        public decvec5 xzwwx => new decvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.rbaar swizzling (equivalent to decvec4.xzwwx).
        /// </summary>
        public decvec5 rbaar => new decvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.xzwwy swizzling.
        /// </summary>
        public decvec5 xzwwy => new decvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.rbaag swizzling (equivalent to decvec4.xzwwy).
        /// </summary>
        public decvec5 rbaag => new decvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.xzwwz swizzling.
        /// </summary>
        public decvec5 xzwwz => new decvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.rbaab swizzling (equivalent to decvec4.xzwwz).
        /// </summary>
        public decvec5 rbaab => new decvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.xzwww swizzling.
        /// </summary>
        public decvec5 xzwww => new decvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.rbaaa swizzling (equivalent to decvec4.xzwww).
        /// </summary>
        public decvec5 rbaaa => new decvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.xw swizzling.
        /// </summary>
        public decvec2 xw => new decvec2(x, w);
        
        /// <summary>
        /// Returns decvec4.ra swizzling (equivalent to decvec4.xw).
        /// </summary>
        public decvec2 ra => new decvec2(x, w);
        
        /// <summary>
        /// Returns decvec4.xwx swizzling.
        /// </summary>
        public decvec3 xwx => new decvec3(x, w, x);
        
        /// <summary>
        /// Returns decvec4.rar swizzling (equivalent to decvec4.xwx).
        /// </summary>
        public decvec3 rar => new decvec3(x, w, x);
        
        /// <summary>
        /// Returns decvec4.xwxx swizzling.
        /// </summary>
        public decvec4 xwxx => new decvec4(x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.rarr swizzling (equivalent to decvec4.xwxx).
        /// </summary>
        public decvec4 rarr => new decvec4(x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.xwxxx swizzling.
        /// </summary>
        public decvec5 xwxxx => new decvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.rarrr swizzling (equivalent to decvec4.xwxxx).
        /// </summary>
        public decvec5 rarrr => new decvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.xwxxy swizzling.
        /// </summary>
        public decvec5 xwxxy => new decvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.rarrg swizzling (equivalent to decvec4.xwxxy).
        /// </summary>
        public decvec5 rarrg => new decvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.xwxxz swizzling.
        /// </summary>
        public decvec5 xwxxz => new decvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.rarrb swizzling (equivalent to decvec4.xwxxz).
        /// </summary>
        public decvec5 rarrb => new decvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.xwxxw swizzling.
        /// </summary>
        public decvec5 xwxxw => new decvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.rarra swizzling (equivalent to decvec4.xwxxw).
        /// </summary>
        public decvec5 rarra => new decvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.xwxy swizzling.
        /// </summary>
        public decvec4 xwxy => new decvec4(x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.rarg swizzling (equivalent to decvec4.xwxy).
        /// </summary>
        public decvec4 rarg => new decvec4(x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.xwxyx swizzling.
        /// </summary>
        public decvec5 xwxyx => new decvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.rargr swizzling (equivalent to decvec4.xwxyx).
        /// </summary>
        public decvec5 rargr => new decvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.xwxyy swizzling.
        /// </summary>
        public decvec5 xwxyy => new decvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.rargg swizzling (equivalent to decvec4.xwxyy).
        /// </summary>
        public decvec5 rargg => new decvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.xwxyz swizzling.
        /// </summary>
        public decvec5 xwxyz => new decvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.rargb swizzling (equivalent to decvec4.xwxyz).
        /// </summary>
        public decvec5 rargb => new decvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.xwxyw swizzling.
        /// </summary>
        public decvec5 xwxyw => new decvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.rarga swizzling (equivalent to decvec4.xwxyw).
        /// </summary>
        public decvec5 rarga => new decvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.xwxz swizzling.
        /// </summary>
        public decvec4 xwxz => new decvec4(x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.rarb swizzling (equivalent to decvec4.xwxz).
        /// </summary>
        public decvec4 rarb => new decvec4(x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.xwxzx swizzling.
        /// </summary>
        public decvec5 xwxzx => new decvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.rarbr swizzling (equivalent to decvec4.xwxzx).
        /// </summary>
        public decvec5 rarbr => new decvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.xwxzy swizzling.
        /// </summary>
        public decvec5 xwxzy => new decvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.rarbg swizzling (equivalent to decvec4.xwxzy).
        /// </summary>
        public decvec5 rarbg => new decvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.xwxzz swizzling.
        /// </summary>
        public decvec5 xwxzz => new decvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.rarbb swizzling (equivalent to decvec4.xwxzz).
        /// </summary>
        public decvec5 rarbb => new decvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.xwxzw swizzling.
        /// </summary>
        public decvec5 xwxzw => new decvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.rarba swizzling (equivalent to decvec4.xwxzw).
        /// </summary>
        public decvec5 rarba => new decvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.xwxw swizzling.
        /// </summary>
        public decvec4 xwxw => new decvec4(x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.rara swizzling (equivalent to decvec4.xwxw).
        /// </summary>
        public decvec4 rara => new decvec4(x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.xwxwx swizzling.
        /// </summary>
        public decvec5 xwxwx => new decvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.rarar swizzling (equivalent to decvec4.xwxwx).
        /// </summary>
        public decvec5 rarar => new decvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.xwxwy swizzling.
        /// </summary>
        public decvec5 xwxwy => new decvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.rarag swizzling (equivalent to decvec4.xwxwy).
        /// </summary>
        public decvec5 rarag => new decvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.xwxwz swizzling.
        /// </summary>
        public decvec5 xwxwz => new decvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.rarab swizzling (equivalent to decvec4.xwxwz).
        /// </summary>
        public decvec5 rarab => new decvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.xwxww swizzling.
        /// </summary>
        public decvec5 xwxww => new decvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.raraa swizzling (equivalent to decvec4.xwxww).
        /// </summary>
        public decvec5 raraa => new decvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.xwy swizzling.
        /// </summary>
        public decvec3 xwy => new decvec3(x, w, y);
        
        /// <summary>
        /// Returns decvec4.rag swizzling (equivalent to decvec4.xwy).
        /// </summary>
        public decvec3 rag => new decvec3(x, w, y);
        
        /// <summary>
        /// Returns decvec4.xwyx swizzling.
        /// </summary>
        public decvec4 xwyx => new decvec4(x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.ragr swizzling (equivalent to decvec4.xwyx).
        /// </summary>
        public decvec4 ragr => new decvec4(x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.xwyxx swizzling.
        /// </summary>
        public decvec5 xwyxx => new decvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.ragrr swizzling (equivalent to decvec4.xwyxx).
        /// </summary>
        public decvec5 ragrr => new decvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.xwyxy swizzling.
        /// </summary>
        public decvec5 xwyxy => new decvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.ragrg swizzling (equivalent to decvec4.xwyxy).
        /// </summary>
        public decvec5 ragrg => new decvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.xwyxz swizzling.
        /// </summary>
        public decvec5 xwyxz => new decvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.ragrb swizzling (equivalent to decvec4.xwyxz).
        /// </summary>
        public decvec5 ragrb => new decvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.xwyxw swizzling.
        /// </summary>
        public decvec5 xwyxw => new decvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.ragra swizzling (equivalent to decvec4.xwyxw).
        /// </summary>
        public decvec5 ragra => new decvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.xwyy swizzling.
        /// </summary>
        public decvec4 xwyy => new decvec4(x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.ragg swizzling (equivalent to decvec4.xwyy).
        /// </summary>
        public decvec4 ragg => new decvec4(x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.xwyyx swizzling.
        /// </summary>
        public decvec5 xwyyx => new decvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.raggr swizzling (equivalent to decvec4.xwyyx).
        /// </summary>
        public decvec5 raggr => new decvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.xwyyy swizzling.
        /// </summary>
        public decvec5 xwyyy => new decvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.raggg swizzling (equivalent to decvec4.xwyyy).
        /// </summary>
        public decvec5 raggg => new decvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.xwyyz swizzling.
        /// </summary>
        public decvec5 xwyyz => new decvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.raggb swizzling (equivalent to decvec4.xwyyz).
        /// </summary>
        public decvec5 raggb => new decvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.xwyyw swizzling.
        /// </summary>
        public decvec5 xwyyw => new decvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.ragga swizzling (equivalent to decvec4.xwyyw).
        /// </summary>
        public decvec5 ragga => new decvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.xwyz swizzling.
        /// </summary>
        public decvec4 xwyz => new decvec4(x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.ragb swizzling (equivalent to decvec4.xwyz).
        /// </summary>
        public decvec4 ragb => new decvec4(x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.xwyzx swizzling.
        /// </summary>
        public decvec5 xwyzx => new decvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.ragbr swizzling (equivalent to decvec4.xwyzx).
        /// </summary>
        public decvec5 ragbr => new decvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.xwyzy swizzling.
        /// </summary>
        public decvec5 xwyzy => new decvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.ragbg swizzling (equivalent to decvec4.xwyzy).
        /// </summary>
        public decvec5 ragbg => new decvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.xwyzz swizzling.
        /// </summary>
        public decvec5 xwyzz => new decvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.ragbb swizzling (equivalent to decvec4.xwyzz).
        /// </summary>
        public decvec5 ragbb => new decvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.xwyzw swizzling.
        /// </summary>
        public decvec5 xwyzw => new decvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.ragba swizzling (equivalent to decvec4.xwyzw).
        /// </summary>
        public decvec5 ragba => new decvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.xwyw swizzling.
        /// </summary>
        public decvec4 xwyw => new decvec4(x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.raga swizzling (equivalent to decvec4.xwyw).
        /// </summary>
        public decvec4 raga => new decvec4(x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.xwywx swizzling.
        /// </summary>
        public decvec5 xwywx => new decvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.ragar swizzling (equivalent to decvec4.xwywx).
        /// </summary>
        public decvec5 ragar => new decvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.xwywy swizzling.
        /// </summary>
        public decvec5 xwywy => new decvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.ragag swizzling (equivalent to decvec4.xwywy).
        /// </summary>
        public decvec5 ragag => new decvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.xwywz swizzling.
        /// </summary>
        public decvec5 xwywz => new decvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.ragab swizzling (equivalent to decvec4.xwywz).
        /// </summary>
        public decvec5 ragab => new decvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.xwyww swizzling.
        /// </summary>
        public decvec5 xwyww => new decvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.ragaa swizzling (equivalent to decvec4.xwyww).
        /// </summary>
        public decvec5 ragaa => new decvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.xwz swizzling.
        /// </summary>
        public decvec3 xwz => new decvec3(x, w, z);
        
        /// <summary>
        /// Returns decvec4.rab swizzling (equivalent to decvec4.xwz).
        /// </summary>
        public decvec3 rab => new decvec3(x, w, z);
        
        /// <summary>
        /// Returns decvec4.xwzx swizzling.
        /// </summary>
        public decvec4 xwzx => new decvec4(x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.rabr swizzling (equivalent to decvec4.xwzx).
        /// </summary>
        public decvec4 rabr => new decvec4(x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.xwzxx swizzling.
        /// </summary>
        public decvec5 xwzxx => new decvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.rabrr swizzling (equivalent to decvec4.xwzxx).
        /// </summary>
        public decvec5 rabrr => new decvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.xwzxy swizzling.
        /// </summary>
        public decvec5 xwzxy => new decvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.rabrg swizzling (equivalent to decvec4.xwzxy).
        /// </summary>
        public decvec5 rabrg => new decvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.xwzxz swizzling.
        /// </summary>
        public decvec5 xwzxz => new decvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.rabrb swizzling (equivalent to decvec4.xwzxz).
        /// </summary>
        public decvec5 rabrb => new decvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.xwzxw swizzling.
        /// </summary>
        public decvec5 xwzxw => new decvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.rabra swizzling (equivalent to decvec4.xwzxw).
        /// </summary>
        public decvec5 rabra => new decvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.xwzy swizzling.
        /// </summary>
        public decvec4 xwzy => new decvec4(x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.rabg swizzling (equivalent to decvec4.xwzy).
        /// </summary>
        public decvec4 rabg => new decvec4(x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.xwzyx swizzling.
        /// </summary>
        public decvec5 xwzyx => new decvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.rabgr swizzling (equivalent to decvec4.xwzyx).
        /// </summary>
        public decvec5 rabgr => new decvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.xwzyy swizzling.
        /// </summary>
        public decvec5 xwzyy => new decvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.rabgg swizzling (equivalent to decvec4.xwzyy).
        /// </summary>
        public decvec5 rabgg => new decvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.xwzyz swizzling.
        /// </summary>
        public decvec5 xwzyz => new decvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.rabgb swizzling (equivalent to decvec4.xwzyz).
        /// </summary>
        public decvec5 rabgb => new decvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.xwzyw swizzling.
        /// </summary>
        public decvec5 xwzyw => new decvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.rabga swizzling (equivalent to decvec4.xwzyw).
        /// </summary>
        public decvec5 rabga => new decvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.xwzz swizzling.
        /// </summary>
        public decvec4 xwzz => new decvec4(x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.rabb swizzling (equivalent to decvec4.xwzz).
        /// </summary>
        public decvec4 rabb => new decvec4(x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.xwzzx swizzling.
        /// </summary>
        public decvec5 xwzzx => new decvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.rabbr swizzling (equivalent to decvec4.xwzzx).
        /// </summary>
        public decvec5 rabbr => new decvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.xwzzy swizzling.
        /// </summary>
        public decvec5 xwzzy => new decvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.rabbg swizzling (equivalent to decvec4.xwzzy).
        /// </summary>
        public decvec5 rabbg => new decvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.xwzzz swizzling.
        /// </summary>
        public decvec5 xwzzz => new decvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.rabbb swizzling (equivalent to decvec4.xwzzz).
        /// </summary>
        public decvec5 rabbb => new decvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.xwzzw swizzling.
        /// </summary>
        public decvec5 xwzzw => new decvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.rabba swizzling (equivalent to decvec4.xwzzw).
        /// </summary>
        public decvec5 rabba => new decvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.xwzw swizzling.
        /// </summary>
        public decvec4 xwzw => new decvec4(x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.raba swizzling (equivalent to decvec4.xwzw).
        /// </summary>
        public decvec4 raba => new decvec4(x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.xwzwx swizzling.
        /// </summary>
        public decvec5 xwzwx => new decvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.rabar swizzling (equivalent to decvec4.xwzwx).
        /// </summary>
        public decvec5 rabar => new decvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.xwzwy swizzling.
        /// </summary>
        public decvec5 xwzwy => new decvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.rabag swizzling (equivalent to decvec4.xwzwy).
        /// </summary>
        public decvec5 rabag => new decvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.xwzwz swizzling.
        /// </summary>
        public decvec5 xwzwz => new decvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.rabab swizzling (equivalent to decvec4.xwzwz).
        /// </summary>
        public decvec5 rabab => new decvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.xwzww swizzling.
        /// </summary>
        public decvec5 xwzww => new decvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.rabaa swizzling (equivalent to decvec4.xwzww).
        /// </summary>
        public decvec5 rabaa => new decvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.xww swizzling.
        /// </summary>
        public decvec3 xww => new decvec3(x, w, w);
        
        /// <summary>
        /// Returns decvec4.raa swizzling (equivalent to decvec4.xww).
        /// </summary>
        public decvec3 raa => new decvec3(x, w, w);
        
        /// <summary>
        /// Returns decvec4.xwwx swizzling.
        /// </summary>
        public decvec4 xwwx => new decvec4(x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.raar swizzling (equivalent to decvec4.xwwx).
        /// </summary>
        public decvec4 raar => new decvec4(x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.xwwxx swizzling.
        /// </summary>
        public decvec5 xwwxx => new decvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.raarr swizzling (equivalent to decvec4.xwwxx).
        /// </summary>
        public decvec5 raarr => new decvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.xwwxy swizzling.
        /// </summary>
        public decvec5 xwwxy => new decvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.raarg swizzling (equivalent to decvec4.xwwxy).
        /// </summary>
        public decvec5 raarg => new decvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.xwwxz swizzling.
        /// </summary>
        public decvec5 xwwxz => new decvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.raarb swizzling (equivalent to decvec4.xwwxz).
        /// </summary>
        public decvec5 raarb => new decvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.xwwxw swizzling.
        /// </summary>
        public decvec5 xwwxw => new decvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.raara swizzling (equivalent to decvec4.xwwxw).
        /// </summary>
        public decvec5 raara => new decvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.xwwy swizzling.
        /// </summary>
        public decvec4 xwwy => new decvec4(x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.raag swizzling (equivalent to decvec4.xwwy).
        /// </summary>
        public decvec4 raag => new decvec4(x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.xwwyx swizzling.
        /// </summary>
        public decvec5 xwwyx => new decvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.raagr swizzling (equivalent to decvec4.xwwyx).
        /// </summary>
        public decvec5 raagr => new decvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.xwwyy swizzling.
        /// </summary>
        public decvec5 xwwyy => new decvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.raagg swizzling (equivalent to decvec4.xwwyy).
        /// </summary>
        public decvec5 raagg => new decvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.xwwyz swizzling.
        /// </summary>
        public decvec5 xwwyz => new decvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.raagb swizzling (equivalent to decvec4.xwwyz).
        /// </summary>
        public decvec5 raagb => new decvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.xwwyw swizzling.
        /// </summary>
        public decvec5 xwwyw => new decvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.raaga swizzling (equivalent to decvec4.xwwyw).
        /// </summary>
        public decvec5 raaga => new decvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.xwwz swizzling.
        /// </summary>
        public decvec4 xwwz => new decvec4(x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.raab swizzling (equivalent to decvec4.xwwz).
        /// </summary>
        public decvec4 raab => new decvec4(x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.xwwzx swizzling.
        /// </summary>
        public decvec5 xwwzx => new decvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.raabr swizzling (equivalent to decvec4.xwwzx).
        /// </summary>
        public decvec5 raabr => new decvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.xwwzy swizzling.
        /// </summary>
        public decvec5 xwwzy => new decvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.raabg swizzling (equivalent to decvec4.xwwzy).
        /// </summary>
        public decvec5 raabg => new decvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.xwwzz swizzling.
        /// </summary>
        public decvec5 xwwzz => new decvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.raabb swizzling (equivalent to decvec4.xwwzz).
        /// </summary>
        public decvec5 raabb => new decvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.xwwzw swizzling.
        /// </summary>
        public decvec5 xwwzw => new decvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.raaba swizzling (equivalent to decvec4.xwwzw).
        /// </summary>
        public decvec5 raaba => new decvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.xwww swizzling.
        /// </summary>
        public decvec4 xwww => new decvec4(x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.raaa swizzling (equivalent to decvec4.xwww).
        /// </summary>
        public decvec4 raaa => new decvec4(x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.xwwwx swizzling.
        /// </summary>
        public decvec5 xwwwx => new decvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.raaar swizzling (equivalent to decvec4.xwwwx).
        /// </summary>
        public decvec5 raaar => new decvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.xwwwy swizzling.
        /// </summary>
        public decvec5 xwwwy => new decvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.raaag swizzling (equivalent to decvec4.xwwwy).
        /// </summary>
        public decvec5 raaag => new decvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.xwwwz swizzling.
        /// </summary>
        public decvec5 xwwwz => new decvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.raaab swizzling (equivalent to decvec4.xwwwz).
        /// </summary>
        public decvec5 raaab => new decvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.xwwww swizzling.
        /// </summary>
        public decvec5 xwwww => new decvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns decvec4.raaaa swizzling (equivalent to decvec4.xwwww).
        /// </summary>
        public decvec5 raaaa => new decvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns decvec4.yx swizzling.
        /// </summary>
        public decvec2 yx => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec4.gr swizzling (equivalent to decvec4.yx).
        /// </summary>
        public decvec2 gr => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec4.yxx swizzling.
        /// </summary>
        public decvec3 yxx => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec4.grr swizzling (equivalent to decvec4.yxx).
        /// </summary>
        public decvec3 grr => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec4.yxxx swizzling.
        /// </summary>
        public decvec4 yxxx => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.grrr swizzling (equivalent to decvec4.yxxx).
        /// </summary>
        public decvec4 grrr => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.yxxxx swizzling.
        /// </summary>
        public decvec5 yxxxx => new decvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.grrrr swizzling (equivalent to decvec4.yxxxx).
        /// </summary>
        public decvec5 grrrr => new decvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.yxxxy swizzling.
        /// </summary>
        public decvec5 yxxxy => new decvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.grrrg swizzling (equivalent to decvec4.yxxxy).
        /// </summary>
        public decvec5 grrrg => new decvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.yxxxz swizzling.
        /// </summary>
        public decvec5 yxxxz => new decvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.grrrb swizzling (equivalent to decvec4.yxxxz).
        /// </summary>
        public decvec5 grrrb => new decvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.yxxxw swizzling.
        /// </summary>
        public decvec5 yxxxw => new decvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.grrra swizzling (equivalent to decvec4.yxxxw).
        /// </summary>
        public decvec5 grrra => new decvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.yxxy swizzling.
        /// </summary>
        public decvec4 yxxy => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.grrg swizzling (equivalent to decvec4.yxxy).
        /// </summary>
        public decvec4 grrg => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.yxxyx swizzling.
        /// </summary>
        public decvec5 yxxyx => new decvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.grrgr swizzling (equivalent to decvec4.yxxyx).
        /// </summary>
        public decvec5 grrgr => new decvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.yxxyy swizzling.
        /// </summary>
        public decvec5 yxxyy => new decvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.grrgg swizzling (equivalent to decvec4.yxxyy).
        /// </summary>
        public decvec5 grrgg => new decvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.yxxyz swizzling.
        /// </summary>
        public decvec5 yxxyz => new decvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.grrgb swizzling (equivalent to decvec4.yxxyz).
        /// </summary>
        public decvec5 grrgb => new decvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.yxxyw swizzling.
        /// </summary>
        public decvec5 yxxyw => new decvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.grrga swizzling (equivalent to decvec4.yxxyw).
        /// </summary>
        public decvec5 grrga => new decvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.yxxz swizzling.
        /// </summary>
        public decvec4 yxxz => new decvec4(y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.grrb swizzling (equivalent to decvec4.yxxz).
        /// </summary>
        public decvec4 grrb => new decvec4(y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.yxxzx swizzling.
        /// </summary>
        public decvec5 yxxzx => new decvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.grrbr swizzling (equivalent to decvec4.yxxzx).
        /// </summary>
        public decvec5 grrbr => new decvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.yxxzy swizzling.
        /// </summary>
        public decvec5 yxxzy => new decvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.grrbg swizzling (equivalent to decvec4.yxxzy).
        /// </summary>
        public decvec5 grrbg => new decvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.yxxzz swizzling.
        /// </summary>
        public decvec5 yxxzz => new decvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.grrbb swizzling (equivalent to decvec4.yxxzz).
        /// </summary>
        public decvec5 grrbb => new decvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.yxxzw swizzling.
        /// </summary>
        public decvec5 yxxzw => new decvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.grrba swizzling (equivalent to decvec4.yxxzw).
        /// </summary>
        public decvec5 grrba => new decvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.yxxw swizzling.
        /// </summary>
        public decvec4 yxxw => new decvec4(y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.grra swizzling (equivalent to decvec4.yxxw).
        /// </summary>
        public decvec4 grra => new decvec4(y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.yxxwx swizzling.
        /// </summary>
        public decvec5 yxxwx => new decvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.grrar swizzling (equivalent to decvec4.yxxwx).
        /// </summary>
        public decvec5 grrar => new decvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.yxxwy swizzling.
        /// </summary>
        public decvec5 yxxwy => new decvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.grrag swizzling (equivalent to decvec4.yxxwy).
        /// </summary>
        public decvec5 grrag => new decvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.yxxwz swizzling.
        /// </summary>
        public decvec5 yxxwz => new decvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.grrab swizzling (equivalent to decvec4.yxxwz).
        /// </summary>
        public decvec5 grrab => new decvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.yxxww swizzling.
        /// </summary>
        public decvec5 yxxww => new decvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.grraa swizzling (equivalent to decvec4.yxxww).
        /// </summary>
        public decvec5 grraa => new decvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.yxy swizzling.
        /// </summary>
        public decvec3 yxy => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec4.grg swizzling (equivalent to decvec4.yxy).
        /// </summary>
        public decvec3 grg => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec4.yxyx swizzling.
        /// </summary>
        public decvec4 yxyx => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.grgr swizzling (equivalent to decvec4.yxyx).
        /// </summary>
        public decvec4 grgr => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.yxyxx swizzling.
        /// </summary>
        public decvec5 yxyxx => new decvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.grgrr swizzling (equivalent to decvec4.yxyxx).
        /// </summary>
        public decvec5 grgrr => new decvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.yxyxy swizzling.
        /// </summary>
        public decvec5 yxyxy => new decvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.grgrg swizzling (equivalent to decvec4.yxyxy).
        /// </summary>
        public decvec5 grgrg => new decvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.yxyxz swizzling.
        /// </summary>
        public decvec5 yxyxz => new decvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.grgrb swizzling (equivalent to decvec4.yxyxz).
        /// </summary>
        public decvec5 grgrb => new decvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.yxyxw swizzling.
        /// </summary>
        public decvec5 yxyxw => new decvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.grgra swizzling (equivalent to decvec4.yxyxw).
        /// </summary>
        public decvec5 grgra => new decvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.yxyy swizzling.
        /// </summary>
        public decvec4 yxyy => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.grgg swizzling (equivalent to decvec4.yxyy).
        /// </summary>
        public decvec4 grgg => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.yxyyx swizzling.
        /// </summary>
        public decvec5 yxyyx => new decvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.grggr swizzling (equivalent to decvec4.yxyyx).
        /// </summary>
        public decvec5 grggr => new decvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.yxyyy swizzling.
        /// </summary>
        public decvec5 yxyyy => new decvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.grggg swizzling (equivalent to decvec4.yxyyy).
        /// </summary>
        public decvec5 grggg => new decvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.yxyyz swizzling.
        /// </summary>
        public decvec5 yxyyz => new decvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.grggb swizzling (equivalent to decvec4.yxyyz).
        /// </summary>
        public decvec5 grggb => new decvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.yxyyw swizzling.
        /// </summary>
        public decvec5 yxyyw => new decvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.grgga swizzling (equivalent to decvec4.yxyyw).
        /// </summary>
        public decvec5 grgga => new decvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.yxyz swizzling.
        /// </summary>
        public decvec4 yxyz => new decvec4(y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.grgb swizzling (equivalent to decvec4.yxyz).
        /// </summary>
        public decvec4 grgb => new decvec4(y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.yxyzx swizzling.
        /// </summary>
        public decvec5 yxyzx => new decvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.grgbr swizzling (equivalent to decvec4.yxyzx).
        /// </summary>
        public decvec5 grgbr => new decvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.yxyzy swizzling.
        /// </summary>
        public decvec5 yxyzy => new decvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.grgbg swizzling (equivalent to decvec4.yxyzy).
        /// </summary>
        public decvec5 grgbg => new decvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.yxyzz swizzling.
        /// </summary>
        public decvec5 yxyzz => new decvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.grgbb swizzling (equivalent to decvec4.yxyzz).
        /// </summary>
        public decvec5 grgbb => new decvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.yxyzw swizzling.
        /// </summary>
        public decvec5 yxyzw => new decvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.grgba swizzling (equivalent to decvec4.yxyzw).
        /// </summary>
        public decvec5 grgba => new decvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.yxyw swizzling.
        /// </summary>
        public decvec4 yxyw => new decvec4(y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.grga swizzling (equivalent to decvec4.yxyw).
        /// </summary>
        public decvec4 grga => new decvec4(y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.yxywx swizzling.
        /// </summary>
        public decvec5 yxywx => new decvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.grgar swizzling (equivalent to decvec4.yxywx).
        /// </summary>
        public decvec5 grgar => new decvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.yxywy swizzling.
        /// </summary>
        public decvec5 yxywy => new decvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.grgag swizzling (equivalent to decvec4.yxywy).
        /// </summary>
        public decvec5 grgag => new decvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.yxywz swizzling.
        /// </summary>
        public decvec5 yxywz => new decvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.grgab swizzling (equivalent to decvec4.yxywz).
        /// </summary>
        public decvec5 grgab => new decvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.yxyww swizzling.
        /// </summary>
        public decvec5 yxyww => new decvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.grgaa swizzling (equivalent to decvec4.yxyww).
        /// </summary>
        public decvec5 grgaa => new decvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.yxz swizzling.
        /// </summary>
        public decvec3 yxz => new decvec3(y, x, z);
        
        /// <summary>
        /// Returns decvec4.grb swizzling (equivalent to decvec4.yxz).
        /// </summary>
        public decvec3 grb => new decvec3(y, x, z);
        
        /// <summary>
        /// Returns decvec4.yxzx swizzling.
        /// </summary>
        public decvec4 yxzx => new decvec4(y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.grbr swizzling (equivalent to decvec4.yxzx).
        /// </summary>
        public decvec4 grbr => new decvec4(y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.yxzxx swizzling.
        /// </summary>
        public decvec5 yxzxx => new decvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.grbrr swizzling (equivalent to decvec4.yxzxx).
        /// </summary>
        public decvec5 grbrr => new decvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.yxzxy swizzling.
        /// </summary>
        public decvec5 yxzxy => new decvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.grbrg swizzling (equivalent to decvec4.yxzxy).
        /// </summary>
        public decvec5 grbrg => new decvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.yxzxz swizzling.
        /// </summary>
        public decvec5 yxzxz => new decvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.grbrb swizzling (equivalent to decvec4.yxzxz).
        /// </summary>
        public decvec5 grbrb => new decvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.yxzxw swizzling.
        /// </summary>
        public decvec5 yxzxw => new decvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.grbra swizzling (equivalent to decvec4.yxzxw).
        /// </summary>
        public decvec5 grbra => new decvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.yxzy swizzling.
        /// </summary>
        public decvec4 yxzy => new decvec4(y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.grbg swizzling (equivalent to decvec4.yxzy).
        /// </summary>
        public decvec4 grbg => new decvec4(y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.yxzyx swizzling.
        /// </summary>
        public decvec5 yxzyx => new decvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.grbgr swizzling (equivalent to decvec4.yxzyx).
        /// </summary>
        public decvec5 grbgr => new decvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.yxzyy swizzling.
        /// </summary>
        public decvec5 yxzyy => new decvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.grbgg swizzling (equivalent to decvec4.yxzyy).
        /// </summary>
        public decvec5 grbgg => new decvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.yxzyz swizzling.
        /// </summary>
        public decvec5 yxzyz => new decvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.grbgb swizzling (equivalent to decvec4.yxzyz).
        /// </summary>
        public decvec5 grbgb => new decvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.yxzyw swizzling.
        /// </summary>
        public decvec5 yxzyw => new decvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.grbga swizzling (equivalent to decvec4.yxzyw).
        /// </summary>
        public decvec5 grbga => new decvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.yxzz swizzling.
        /// </summary>
        public decvec4 yxzz => new decvec4(y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.grbb swizzling (equivalent to decvec4.yxzz).
        /// </summary>
        public decvec4 grbb => new decvec4(y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.yxzzx swizzling.
        /// </summary>
        public decvec5 yxzzx => new decvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.grbbr swizzling (equivalent to decvec4.yxzzx).
        /// </summary>
        public decvec5 grbbr => new decvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.yxzzy swizzling.
        /// </summary>
        public decvec5 yxzzy => new decvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.grbbg swizzling (equivalent to decvec4.yxzzy).
        /// </summary>
        public decvec5 grbbg => new decvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.yxzzz swizzling.
        /// </summary>
        public decvec5 yxzzz => new decvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.grbbb swizzling (equivalent to decvec4.yxzzz).
        /// </summary>
        public decvec5 grbbb => new decvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.yxzzw swizzling.
        /// </summary>
        public decvec5 yxzzw => new decvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.grbba swizzling (equivalent to decvec4.yxzzw).
        /// </summary>
        public decvec5 grbba => new decvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.yxzw swizzling.
        /// </summary>
        public decvec4 yxzw => new decvec4(y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.grba swizzling (equivalent to decvec4.yxzw).
        /// </summary>
        public decvec4 grba => new decvec4(y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.yxzwx swizzling.
        /// </summary>
        public decvec5 yxzwx => new decvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.grbar swizzling (equivalent to decvec4.yxzwx).
        /// </summary>
        public decvec5 grbar => new decvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.yxzwy swizzling.
        /// </summary>
        public decvec5 yxzwy => new decvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.grbag swizzling (equivalent to decvec4.yxzwy).
        /// </summary>
        public decvec5 grbag => new decvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.yxzwz swizzling.
        /// </summary>
        public decvec5 yxzwz => new decvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.grbab swizzling (equivalent to decvec4.yxzwz).
        /// </summary>
        public decvec5 grbab => new decvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.yxzww swizzling.
        /// </summary>
        public decvec5 yxzww => new decvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.grbaa swizzling (equivalent to decvec4.yxzww).
        /// </summary>
        public decvec5 grbaa => new decvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.yxw swizzling.
        /// </summary>
        public decvec3 yxw => new decvec3(y, x, w);
        
        /// <summary>
        /// Returns decvec4.gra swizzling (equivalent to decvec4.yxw).
        /// </summary>
        public decvec3 gra => new decvec3(y, x, w);
        
        /// <summary>
        /// Returns decvec4.yxwx swizzling.
        /// </summary>
        public decvec4 yxwx => new decvec4(y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.grar swizzling (equivalent to decvec4.yxwx).
        /// </summary>
        public decvec4 grar => new decvec4(y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.yxwxx swizzling.
        /// </summary>
        public decvec5 yxwxx => new decvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.grarr swizzling (equivalent to decvec4.yxwxx).
        /// </summary>
        public decvec5 grarr => new decvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.yxwxy swizzling.
        /// </summary>
        public decvec5 yxwxy => new decvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.grarg swizzling (equivalent to decvec4.yxwxy).
        /// </summary>
        public decvec5 grarg => new decvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.yxwxz swizzling.
        /// </summary>
        public decvec5 yxwxz => new decvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.grarb swizzling (equivalent to decvec4.yxwxz).
        /// </summary>
        public decvec5 grarb => new decvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.yxwxw swizzling.
        /// </summary>
        public decvec5 yxwxw => new decvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.grara swizzling (equivalent to decvec4.yxwxw).
        /// </summary>
        public decvec5 grara => new decvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.yxwy swizzling.
        /// </summary>
        public decvec4 yxwy => new decvec4(y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.grag swizzling (equivalent to decvec4.yxwy).
        /// </summary>
        public decvec4 grag => new decvec4(y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.yxwyx swizzling.
        /// </summary>
        public decvec5 yxwyx => new decvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.gragr swizzling (equivalent to decvec4.yxwyx).
        /// </summary>
        public decvec5 gragr => new decvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.yxwyy swizzling.
        /// </summary>
        public decvec5 yxwyy => new decvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.gragg swizzling (equivalent to decvec4.yxwyy).
        /// </summary>
        public decvec5 gragg => new decvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.yxwyz swizzling.
        /// </summary>
        public decvec5 yxwyz => new decvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.gragb swizzling (equivalent to decvec4.yxwyz).
        /// </summary>
        public decvec5 gragb => new decvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.yxwyw swizzling.
        /// </summary>
        public decvec5 yxwyw => new decvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.graga swizzling (equivalent to decvec4.yxwyw).
        /// </summary>
        public decvec5 graga => new decvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.yxwz swizzling.
        /// </summary>
        public decvec4 yxwz => new decvec4(y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.grab swizzling (equivalent to decvec4.yxwz).
        /// </summary>
        public decvec4 grab => new decvec4(y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.yxwzx swizzling.
        /// </summary>
        public decvec5 yxwzx => new decvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.grabr swizzling (equivalent to decvec4.yxwzx).
        /// </summary>
        public decvec5 grabr => new decvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.yxwzy swizzling.
        /// </summary>
        public decvec5 yxwzy => new decvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.grabg swizzling (equivalent to decvec4.yxwzy).
        /// </summary>
        public decvec5 grabg => new decvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.yxwzz swizzling.
        /// </summary>
        public decvec5 yxwzz => new decvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.grabb swizzling (equivalent to decvec4.yxwzz).
        /// </summary>
        public decvec5 grabb => new decvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.yxwzw swizzling.
        /// </summary>
        public decvec5 yxwzw => new decvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.graba swizzling (equivalent to decvec4.yxwzw).
        /// </summary>
        public decvec5 graba => new decvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.yxww swizzling.
        /// </summary>
        public decvec4 yxww => new decvec4(y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.graa swizzling (equivalent to decvec4.yxww).
        /// </summary>
        public decvec4 graa => new decvec4(y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.yxwwx swizzling.
        /// </summary>
        public decvec5 yxwwx => new decvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.graar swizzling (equivalent to decvec4.yxwwx).
        /// </summary>
        public decvec5 graar => new decvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.yxwwy swizzling.
        /// </summary>
        public decvec5 yxwwy => new decvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.graag swizzling (equivalent to decvec4.yxwwy).
        /// </summary>
        public decvec5 graag => new decvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.yxwwz swizzling.
        /// </summary>
        public decvec5 yxwwz => new decvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.graab swizzling (equivalent to decvec4.yxwwz).
        /// </summary>
        public decvec5 graab => new decvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.yxwww swizzling.
        /// </summary>
        public decvec5 yxwww => new decvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.graaa swizzling (equivalent to decvec4.yxwww).
        /// </summary>
        public decvec5 graaa => new decvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.yy swizzling.
        /// </summary>
        public decvec2 yy => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec4.gg swizzling (equivalent to decvec4.yy).
        /// </summary>
        public decvec2 gg => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec4.yyx swizzling.
        /// </summary>
        public decvec3 yyx => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec4.ggr swizzling (equivalent to decvec4.yyx).
        /// </summary>
        public decvec3 ggr => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec4.yyxx swizzling.
        /// </summary>
        public decvec4 yyxx => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.ggrr swizzling (equivalent to decvec4.yyxx).
        /// </summary>
        public decvec4 ggrr => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.yyxxx swizzling.
        /// </summary>
        public decvec5 yyxxx => new decvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.ggrrr swizzling (equivalent to decvec4.yyxxx).
        /// </summary>
        public decvec5 ggrrr => new decvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.yyxxy swizzling.
        /// </summary>
        public decvec5 yyxxy => new decvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.ggrrg swizzling (equivalent to decvec4.yyxxy).
        /// </summary>
        public decvec5 ggrrg => new decvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.yyxxz swizzling.
        /// </summary>
        public decvec5 yyxxz => new decvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.ggrrb swizzling (equivalent to decvec4.yyxxz).
        /// </summary>
        public decvec5 ggrrb => new decvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.yyxxw swizzling.
        /// </summary>
        public decvec5 yyxxw => new decvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.ggrra swizzling (equivalent to decvec4.yyxxw).
        /// </summary>
        public decvec5 ggrra => new decvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.yyxy swizzling.
        /// </summary>
        public decvec4 yyxy => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.ggrg swizzling (equivalent to decvec4.yyxy).
        /// </summary>
        public decvec4 ggrg => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.yyxyx swizzling.
        /// </summary>
        public decvec5 yyxyx => new decvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.ggrgr swizzling (equivalent to decvec4.yyxyx).
        /// </summary>
        public decvec5 ggrgr => new decvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.yyxyy swizzling.
        /// </summary>
        public decvec5 yyxyy => new decvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.ggrgg swizzling (equivalent to decvec4.yyxyy).
        /// </summary>
        public decvec5 ggrgg => new decvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.yyxyz swizzling.
        /// </summary>
        public decvec5 yyxyz => new decvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.ggrgb swizzling (equivalent to decvec4.yyxyz).
        /// </summary>
        public decvec5 ggrgb => new decvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.yyxyw swizzling.
        /// </summary>
        public decvec5 yyxyw => new decvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.ggrga swizzling (equivalent to decvec4.yyxyw).
        /// </summary>
        public decvec5 ggrga => new decvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.yyxz swizzling.
        /// </summary>
        public decvec4 yyxz => new decvec4(y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.ggrb swizzling (equivalent to decvec4.yyxz).
        /// </summary>
        public decvec4 ggrb => new decvec4(y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.yyxzx swizzling.
        /// </summary>
        public decvec5 yyxzx => new decvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.ggrbr swizzling (equivalent to decvec4.yyxzx).
        /// </summary>
        public decvec5 ggrbr => new decvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.yyxzy swizzling.
        /// </summary>
        public decvec5 yyxzy => new decvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.ggrbg swizzling (equivalent to decvec4.yyxzy).
        /// </summary>
        public decvec5 ggrbg => new decvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.yyxzz swizzling.
        /// </summary>
        public decvec5 yyxzz => new decvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.ggrbb swizzling (equivalent to decvec4.yyxzz).
        /// </summary>
        public decvec5 ggrbb => new decvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.yyxzw swizzling.
        /// </summary>
        public decvec5 yyxzw => new decvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.ggrba swizzling (equivalent to decvec4.yyxzw).
        /// </summary>
        public decvec5 ggrba => new decvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.yyxw swizzling.
        /// </summary>
        public decvec4 yyxw => new decvec4(y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.ggra swizzling (equivalent to decvec4.yyxw).
        /// </summary>
        public decvec4 ggra => new decvec4(y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.yyxwx swizzling.
        /// </summary>
        public decvec5 yyxwx => new decvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.ggrar swizzling (equivalent to decvec4.yyxwx).
        /// </summary>
        public decvec5 ggrar => new decvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.yyxwy swizzling.
        /// </summary>
        public decvec5 yyxwy => new decvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.ggrag swizzling (equivalent to decvec4.yyxwy).
        /// </summary>
        public decvec5 ggrag => new decvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.yyxwz swizzling.
        /// </summary>
        public decvec5 yyxwz => new decvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.ggrab swizzling (equivalent to decvec4.yyxwz).
        /// </summary>
        public decvec5 ggrab => new decvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.yyxww swizzling.
        /// </summary>
        public decvec5 yyxww => new decvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.ggraa swizzling (equivalent to decvec4.yyxww).
        /// </summary>
        public decvec5 ggraa => new decvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.yyy swizzling.
        /// </summary>
        public decvec3 yyy => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec4.ggg swizzling (equivalent to decvec4.yyy).
        /// </summary>
        public decvec3 ggg => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec4.yyyx swizzling.
        /// </summary>
        public decvec4 yyyx => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.gggr swizzling (equivalent to decvec4.yyyx).
        /// </summary>
        public decvec4 gggr => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.yyyxx swizzling.
        /// </summary>
        public decvec5 yyyxx => new decvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.gggrr swizzling (equivalent to decvec4.yyyxx).
        /// </summary>
        public decvec5 gggrr => new decvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.yyyxy swizzling.
        /// </summary>
        public decvec5 yyyxy => new decvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.gggrg swizzling (equivalent to decvec4.yyyxy).
        /// </summary>
        public decvec5 gggrg => new decvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.yyyxz swizzling.
        /// </summary>
        public decvec5 yyyxz => new decvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.gggrb swizzling (equivalent to decvec4.yyyxz).
        /// </summary>
        public decvec5 gggrb => new decvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.yyyxw swizzling.
        /// </summary>
        public decvec5 yyyxw => new decvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.gggra swizzling (equivalent to decvec4.yyyxw).
        /// </summary>
        public decvec5 gggra => new decvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.yyyy swizzling.
        /// </summary>
        public decvec4 yyyy => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.gggg swizzling (equivalent to decvec4.yyyy).
        /// </summary>
        public decvec4 gggg => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.yyyyx swizzling.
        /// </summary>
        public decvec5 yyyyx => new decvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.ggggr swizzling (equivalent to decvec4.yyyyx).
        /// </summary>
        public decvec5 ggggr => new decvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.yyyyy swizzling.
        /// </summary>
        public decvec5 yyyyy => new decvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.ggggg swizzling (equivalent to decvec4.yyyyy).
        /// </summary>
        public decvec5 ggggg => new decvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.yyyyz swizzling.
        /// </summary>
        public decvec5 yyyyz => new decvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.ggggb swizzling (equivalent to decvec4.yyyyz).
        /// </summary>
        public decvec5 ggggb => new decvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.yyyyw swizzling.
        /// </summary>
        public decvec5 yyyyw => new decvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.gggga swizzling (equivalent to decvec4.yyyyw).
        /// </summary>
        public decvec5 gggga => new decvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.yyyz swizzling.
        /// </summary>
        public decvec4 yyyz => new decvec4(y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.gggb swizzling (equivalent to decvec4.yyyz).
        /// </summary>
        public decvec4 gggb => new decvec4(y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.yyyzx swizzling.
        /// </summary>
        public decvec5 yyyzx => new decvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.gggbr swizzling (equivalent to decvec4.yyyzx).
        /// </summary>
        public decvec5 gggbr => new decvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.yyyzy swizzling.
        /// </summary>
        public decvec5 yyyzy => new decvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.gggbg swizzling (equivalent to decvec4.yyyzy).
        /// </summary>
        public decvec5 gggbg => new decvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.yyyzz swizzling.
        /// </summary>
        public decvec5 yyyzz => new decvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.gggbb swizzling (equivalent to decvec4.yyyzz).
        /// </summary>
        public decvec5 gggbb => new decvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.yyyzw swizzling.
        /// </summary>
        public decvec5 yyyzw => new decvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.gggba swizzling (equivalent to decvec4.yyyzw).
        /// </summary>
        public decvec5 gggba => new decvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.yyyw swizzling.
        /// </summary>
        public decvec4 yyyw => new decvec4(y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.ggga swizzling (equivalent to decvec4.yyyw).
        /// </summary>
        public decvec4 ggga => new decvec4(y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.yyywx swizzling.
        /// </summary>
        public decvec5 yyywx => new decvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.gggar swizzling (equivalent to decvec4.yyywx).
        /// </summary>
        public decvec5 gggar => new decvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.yyywy swizzling.
        /// </summary>
        public decvec5 yyywy => new decvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.gggag swizzling (equivalent to decvec4.yyywy).
        /// </summary>
        public decvec5 gggag => new decvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.yyywz swizzling.
        /// </summary>
        public decvec5 yyywz => new decvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.gggab swizzling (equivalent to decvec4.yyywz).
        /// </summary>
        public decvec5 gggab => new decvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.yyyww swizzling.
        /// </summary>
        public decvec5 yyyww => new decvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.gggaa swizzling (equivalent to decvec4.yyyww).
        /// </summary>
        public decvec5 gggaa => new decvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.yyz swizzling.
        /// </summary>
        public decvec3 yyz => new decvec3(y, y, z);
        
        /// <summary>
        /// Returns decvec4.ggb swizzling (equivalent to decvec4.yyz).
        /// </summary>
        public decvec3 ggb => new decvec3(y, y, z);
        
        /// <summary>
        /// Returns decvec4.yyzx swizzling.
        /// </summary>
        public decvec4 yyzx => new decvec4(y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.ggbr swizzling (equivalent to decvec4.yyzx).
        /// </summary>
        public decvec4 ggbr => new decvec4(y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.yyzxx swizzling.
        /// </summary>
        public decvec5 yyzxx => new decvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.ggbrr swizzling (equivalent to decvec4.yyzxx).
        /// </summary>
        public decvec5 ggbrr => new decvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.yyzxy swizzling.
        /// </summary>
        public decvec5 yyzxy => new decvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.ggbrg swizzling (equivalent to decvec4.yyzxy).
        /// </summary>
        public decvec5 ggbrg => new decvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.yyzxz swizzling.
        /// </summary>
        public decvec5 yyzxz => new decvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.ggbrb swizzling (equivalent to decvec4.yyzxz).
        /// </summary>
        public decvec5 ggbrb => new decvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.yyzxw swizzling.
        /// </summary>
        public decvec5 yyzxw => new decvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.ggbra swizzling (equivalent to decvec4.yyzxw).
        /// </summary>
        public decvec5 ggbra => new decvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.yyzy swizzling.
        /// </summary>
        public decvec4 yyzy => new decvec4(y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.ggbg swizzling (equivalent to decvec4.yyzy).
        /// </summary>
        public decvec4 ggbg => new decvec4(y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.yyzyx swizzling.
        /// </summary>
        public decvec5 yyzyx => new decvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.ggbgr swizzling (equivalent to decvec4.yyzyx).
        /// </summary>
        public decvec5 ggbgr => new decvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.yyzyy swizzling.
        /// </summary>
        public decvec5 yyzyy => new decvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.ggbgg swizzling (equivalent to decvec4.yyzyy).
        /// </summary>
        public decvec5 ggbgg => new decvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.yyzyz swizzling.
        /// </summary>
        public decvec5 yyzyz => new decvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.ggbgb swizzling (equivalent to decvec4.yyzyz).
        /// </summary>
        public decvec5 ggbgb => new decvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.yyzyw swizzling.
        /// </summary>
        public decvec5 yyzyw => new decvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.ggbga swizzling (equivalent to decvec4.yyzyw).
        /// </summary>
        public decvec5 ggbga => new decvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.yyzz swizzling.
        /// </summary>
        public decvec4 yyzz => new decvec4(y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.ggbb swizzling (equivalent to decvec4.yyzz).
        /// </summary>
        public decvec4 ggbb => new decvec4(y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.yyzzx swizzling.
        /// </summary>
        public decvec5 yyzzx => new decvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.ggbbr swizzling (equivalent to decvec4.yyzzx).
        /// </summary>
        public decvec5 ggbbr => new decvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.yyzzy swizzling.
        /// </summary>
        public decvec5 yyzzy => new decvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.ggbbg swizzling (equivalent to decvec4.yyzzy).
        /// </summary>
        public decvec5 ggbbg => new decvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.yyzzz swizzling.
        /// </summary>
        public decvec5 yyzzz => new decvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.ggbbb swizzling (equivalent to decvec4.yyzzz).
        /// </summary>
        public decvec5 ggbbb => new decvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.yyzzw swizzling.
        /// </summary>
        public decvec5 yyzzw => new decvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.ggbba swizzling (equivalent to decvec4.yyzzw).
        /// </summary>
        public decvec5 ggbba => new decvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.yyzw swizzling.
        /// </summary>
        public decvec4 yyzw => new decvec4(y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.ggba swizzling (equivalent to decvec4.yyzw).
        /// </summary>
        public decvec4 ggba => new decvec4(y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.yyzwx swizzling.
        /// </summary>
        public decvec5 yyzwx => new decvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.ggbar swizzling (equivalent to decvec4.yyzwx).
        /// </summary>
        public decvec5 ggbar => new decvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.yyzwy swizzling.
        /// </summary>
        public decvec5 yyzwy => new decvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.ggbag swizzling (equivalent to decvec4.yyzwy).
        /// </summary>
        public decvec5 ggbag => new decvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.yyzwz swizzling.
        /// </summary>
        public decvec5 yyzwz => new decvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.ggbab swizzling (equivalent to decvec4.yyzwz).
        /// </summary>
        public decvec5 ggbab => new decvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.yyzww swizzling.
        /// </summary>
        public decvec5 yyzww => new decvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.ggbaa swizzling (equivalent to decvec4.yyzww).
        /// </summary>
        public decvec5 ggbaa => new decvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.yyw swizzling.
        /// </summary>
        public decvec3 yyw => new decvec3(y, y, w);
        
        /// <summary>
        /// Returns decvec4.gga swizzling (equivalent to decvec4.yyw).
        /// </summary>
        public decvec3 gga => new decvec3(y, y, w);
        
        /// <summary>
        /// Returns decvec4.yywx swizzling.
        /// </summary>
        public decvec4 yywx => new decvec4(y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.ggar swizzling (equivalent to decvec4.yywx).
        /// </summary>
        public decvec4 ggar => new decvec4(y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.yywxx swizzling.
        /// </summary>
        public decvec5 yywxx => new decvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.ggarr swizzling (equivalent to decvec4.yywxx).
        /// </summary>
        public decvec5 ggarr => new decvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.yywxy swizzling.
        /// </summary>
        public decvec5 yywxy => new decvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.ggarg swizzling (equivalent to decvec4.yywxy).
        /// </summary>
        public decvec5 ggarg => new decvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.yywxz swizzling.
        /// </summary>
        public decvec5 yywxz => new decvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.ggarb swizzling (equivalent to decvec4.yywxz).
        /// </summary>
        public decvec5 ggarb => new decvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.yywxw swizzling.
        /// </summary>
        public decvec5 yywxw => new decvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.ggara swizzling (equivalent to decvec4.yywxw).
        /// </summary>
        public decvec5 ggara => new decvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.yywy swizzling.
        /// </summary>
        public decvec4 yywy => new decvec4(y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.ggag swizzling (equivalent to decvec4.yywy).
        /// </summary>
        public decvec4 ggag => new decvec4(y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.yywyx swizzling.
        /// </summary>
        public decvec5 yywyx => new decvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.ggagr swizzling (equivalent to decvec4.yywyx).
        /// </summary>
        public decvec5 ggagr => new decvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.yywyy swizzling.
        /// </summary>
        public decvec5 yywyy => new decvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.ggagg swizzling (equivalent to decvec4.yywyy).
        /// </summary>
        public decvec5 ggagg => new decvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.yywyz swizzling.
        /// </summary>
        public decvec5 yywyz => new decvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.ggagb swizzling (equivalent to decvec4.yywyz).
        /// </summary>
        public decvec5 ggagb => new decvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.yywyw swizzling.
        /// </summary>
        public decvec5 yywyw => new decvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.ggaga swizzling (equivalent to decvec4.yywyw).
        /// </summary>
        public decvec5 ggaga => new decvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.yywz swizzling.
        /// </summary>
        public decvec4 yywz => new decvec4(y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.ggab swizzling (equivalent to decvec4.yywz).
        /// </summary>
        public decvec4 ggab => new decvec4(y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.yywzx swizzling.
        /// </summary>
        public decvec5 yywzx => new decvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.ggabr swizzling (equivalent to decvec4.yywzx).
        /// </summary>
        public decvec5 ggabr => new decvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.yywzy swizzling.
        /// </summary>
        public decvec5 yywzy => new decvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.ggabg swizzling (equivalent to decvec4.yywzy).
        /// </summary>
        public decvec5 ggabg => new decvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.yywzz swizzling.
        /// </summary>
        public decvec5 yywzz => new decvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.ggabb swizzling (equivalent to decvec4.yywzz).
        /// </summary>
        public decvec5 ggabb => new decvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.yywzw swizzling.
        /// </summary>
        public decvec5 yywzw => new decvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.ggaba swizzling (equivalent to decvec4.yywzw).
        /// </summary>
        public decvec5 ggaba => new decvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.yyww swizzling.
        /// </summary>
        public decvec4 yyww => new decvec4(y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.ggaa swizzling (equivalent to decvec4.yyww).
        /// </summary>
        public decvec4 ggaa => new decvec4(y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.yywwx swizzling.
        /// </summary>
        public decvec5 yywwx => new decvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.ggaar swizzling (equivalent to decvec4.yywwx).
        /// </summary>
        public decvec5 ggaar => new decvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.yywwy swizzling.
        /// </summary>
        public decvec5 yywwy => new decvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.ggaag swizzling (equivalent to decvec4.yywwy).
        /// </summary>
        public decvec5 ggaag => new decvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.yywwz swizzling.
        /// </summary>
        public decvec5 yywwz => new decvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.ggaab swizzling (equivalent to decvec4.yywwz).
        /// </summary>
        public decvec5 ggaab => new decvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.yywww swizzling.
        /// </summary>
        public decvec5 yywww => new decvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.ggaaa swizzling (equivalent to decvec4.yywww).
        /// </summary>
        public decvec5 ggaaa => new decvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.yz swizzling.
        /// </summary>
        public decvec2 yz => new decvec2(y, z);
        
        /// <summary>
        /// Returns decvec4.gb swizzling (equivalent to decvec4.yz).
        /// </summary>
        public decvec2 gb => new decvec2(y, z);
        
        /// <summary>
        /// Returns decvec4.yzx swizzling.
        /// </summary>
        public decvec3 yzx => new decvec3(y, z, x);
        
        /// <summary>
        /// Returns decvec4.gbr swizzling (equivalent to decvec4.yzx).
        /// </summary>
        public decvec3 gbr => new decvec3(y, z, x);
        
        /// <summary>
        /// Returns decvec4.yzxx swizzling.
        /// </summary>
        public decvec4 yzxx => new decvec4(y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.gbrr swizzling (equivalent to decvec4.yzxx).
        /// </summary>
        public decvec4 gbrr => new decvec4(y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.yzxxx swizzling.
        /// </summary>
        public decvec5 yzxxx => new decvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.gbrrr swizzling (equivalent to decvec4.yzxxx).
        /// </summary>
        public decvec5 gbrrr => new decvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.yzxxy swizzling.
        /// </summary>
        public decvec5 yzxxy => new decvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.gbrrg swizzling (equivalent to decvec4.yzxxy).
        /// </summary>
        public decvec5 gbrrg => new decvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.yzxxz swizzling.
        /// </summary>
        public decvec5 yzxxz => new decvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.gbrrb swizzling (equivalent to decvec4.yzxxz).
        /// </summary>
        public decvec5 gbrrb => new decvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.yzxxw swizzling.
        /// </summary>
        public decvec5 yzxxw => new decvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.gbrra swizzling (equivalent to decvec4.yzxxw).
        /// </summary>
        public decvec5 gbrra => new decvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.yzxy swizzling.
        /// </summary>
        public decvec4 yzxy => new decvec4(y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.gbrg swizzling (equivalent to decvec4.yzxy).
        /// </summary>
        public decvec4 gbrg => new decvec4(y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.yzxyx swizzling.
        /// </summary>
        public decvec5 yzxyx => new decvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.gbrgr swizzling (equivalent to decvec4.yzxyx).
        /// </summary>
        public decvec5 gbrgr => new decvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.yzxyy swizzling.
        /// </summary>
        public decvec5 yzxyy => new decvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.gbrgg swizzling (equivalent to decvec4.yzxyy).
        /// </summary>
        public decvec5 gbrgg => new decvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.yzxyz swizzling.
        /// </summary>
        public decvec5 yzxyz => new decvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.gbrgb swizzling (equivalent to decvec4.yzxyz).
        /// </summary>
        public decvec5 gbrgb => new decvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.yzxyw swizzling.
        /// </summary>
        public decvec5 yzxyw => new decvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.gbrga swizzling (equivalent to decvec4.yzxyw).
        /// </summary>
        public decvec5 gbrga => new decvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.yzxz swizzling.
        /// </summary>
        public decvec4 yzxz => new decvec4(y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.gbrb swizzling (equivalent to decvec4.yzxz).
        /// </summary>
        public decvec4 gbrb => new decvec4(y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.yzxzx swizzling.
        /// </summary>
        public decvec5 yzxzx => new decvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.gbrbr swizzling (equivalent to decvec4.yzxzx).
        /// </summary>
        public decvec5 gbrbr => new decvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.yzxzy swizzling.
        /// </summary>
        public decvec5 yzxzy => new decvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.gbrbg swizzling (equivalent to decvec4.yzxzy).
        /// </summary>
        public decvec5 gbrbg => new decvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.yzxzz swizzling.
        /// </summary>
        public decvec5 yzxzz => new decvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.gbrbb swizzling (equivalent to decvec4.yzxzz).
        /// </summary>
        public decvec5 gbrbb => new decvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.yzxzw swizzling.
        /// </summary>
        public decvec5 yzxzw => new decvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.gbrba swizzling (equivalent to decvec4.yzxzw).
        /// </summary>
        public decvec5 gbrba => new decvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.yzxw swizzling.
        /// </summary>
        public decvec4 yzxw => new decvec4(y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.gbra swizzling (equivalent to decvec4.yzxw).
        /// </summary>
        public decvec4 gbra => new decvec4(y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.yzxwx swizzling.
        /// </summary>
        public decvec5 yzxwx => new decvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.gbrar swizzling (equivalent to decvec4.yzxwx).
        /// </summary>
        public decvec5 gbrar => new decvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.yzxwy swizzling.
        /// </summary>
        public decvec5 yzxwy => new decvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.gbrag swizzling (equivalent to decvec4.yzxwy).
        /// </summary>
        public decvec5 gbrag => new decvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.yzxwz swizzling.
        /// </summary>
        public decvec5 yzxwz => new decvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.gbrab swizzling (equivalent to decvec4.yzxwz).
        /// </summary>
        public decvec5 gbrab => new decvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.yzxww swizzling.
        /// </summary>
        public decvec5 yzxww => new decvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.gbraa swizzling (equivalent to decvec4.yzxww).
        /// </summary>
        public decvec5 gbraa => new decvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.yzy swizzling.
        /// </summary>
        public decvec3 yzy => new decvec3(y, z, y);
        
        /// <summary>
        /// Returns decvec4.gbg swizzling (equivalent to decvec4.yzy).
        /// </summary>
        public decvec3 gbg => new decvec3(y, z, y);
        
        /// <summary>
        /// Returns decvec4.yzyx swizzling.
        /// </summary>
        public decvec4 yzyx => new decvec4(y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.gbgr swizzling (equivalent to decvec4.yzyx).
        /// </summary>
        public decvec4 gbgr => new decvec4(y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.yzyxx swizzling.
        /// </summary>
        public decvec5 yzyxx => new decvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.gbgrr swizzling (equivalent to decvec4.yzyxx).
        /// </summary>
        public decvec5 gbgrr => new decvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.yzyxy swizzling.
        /// </summary>
        public decvec5 yzyxy => new decvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.gbgrg swizzling (equivalent to decvec4.yzyxy).
        /// </summary>
        public decvec5 gbgrg => new decvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.yzyxz swizzling.
        /// </summary>
        public decvec5 yzyxz => new decvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.gbgrb swizzling (equivalent to decvec4.yzyxz).
        /// </summary>
        public decvec5 gbgrb => new decvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.yzyxw swizzling.
        /// </summary>
        public decvec5 yzyxw => new decvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.gbgra swizzling (equivalent to decvec4.yzyxw).
        /// </summary>
        public decvec5 gbgra => new decvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.yzyy swizzling.
        /// </summary>
        public decvec4 yzyy => new decvec4(y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.gbgg swizzling (equivalent to decvec4.yzyy).
        /// </summary>
        public decvec4 gbgg => new decvec4(y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.yzyyx swizzling.
        /// </summary>
        public decvec5 yzyyx => new decvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.gbggr swizzling (equivalent to decvec4.yzyyx).
        /// </summary>
        public decvec5 gbggr => new decvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.yzyyy swizzling.
        /// </summary>
        public decvec5 yzyyy => new decvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.gbggg swizzling (equivalent to decvec4.yzyyy).
        /// </summary>
        public decvec5 gbggg => new decvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.yzyyz swizzling.
        /// </summary>
        public decvec5 yzyyz => new decvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.gbggb swizzling (equivalent to decvec4.yzyyz).
        /// </summary>
        public decvec5 gbggb => new decvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.yzyyw swizzling.
        /// </summary>
        public decvec5 yzyyw => new decvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.gbgga swizzling (equivalent to decvec4.yzyyw).
        /// </summary>
        public decvec5 gbgga => new decvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.yzyz swizzling.
        /// </summary>
        public decvec4 yzyz => new decvec4(y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.gbgb swizzling (equivalent to decvec4.yzyz).
        /// </summary>
        public decvec4 gbgb => new decvec4(y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.yzyzx swizzling.
        /// </summary>
        public decvec5 yzyzx => new decvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.gbgbr swizzling (equivalent to decvec4.yzyzx).
        /// </summary>
        public decvec5 gbgbr => new decvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.yzyzy swizzling.
        /// </summary>
        public decvec5 yzyzy => new decvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.gbgbg swizzling (equivalent to decvec4.yzyzy).
        /// </summary>
        public decvec5 gbgbg => new decvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.yzyzz swizzling.
        /// </summary>
        public decvec5 yzyzz => new decvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.gbgbb swizzling (equivalent to decvec4.yzyzz).
        /// </summary>
        public decvec5 gbgbb => new decvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.yzyzw swizzling.
        /// </summary>
        public decvec5 yzyzw => new decvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.gbgba swizzling (equivalent to decvec4.yzyzw).
        /// </summary>
        public decvec5 gbgba => new decvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.yzyw swizzling.
        /// </summary>
        public decvec4 yzyw => new decvec4(y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.gbga swizzling (equivalent to decvec4.yzyw).
        /// </summary>
        public decvec4 gbga => new decvec4(y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.yzywx swizzling.
        /// </summary>
        public decvec5 yzywx => new decvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.gbgar swizzling (equivalent to decvec4.yzywx).
        /// </summary>
        public decvec5 gbgar => new decvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.yzywy swizzling.
        /// </summary>
        public decvec5 yzywy => new decvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.gbgag swizzling (equivalent to decvec4.yzywy).
        /// </summary>
        public decvec5 gbgag => new decvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.yzywz swizzling.
        /// </summary>
        public decvec5 yzywz => new decvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.gbgab swizzling (equivalent to decvec4.yzywz).
        /// </summary>
        public decvec5 gbgab => new decvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.yzyww swizzling.
        /// </summary>
        public decvec5 yzyww => new decvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.gbgaa swizzling (equivalent to decvec4.yzyww).
        /// </summary>
        public decvec5 gbgaa => new decvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.yzz swizzling.
        /// </summary>
        public decvec3 yzz => new decvec3(y, z, z);
        
        /// <summary>
        /// Returns decvec4.gbb swizzling (equivalent to decvec4.yzz).
        /// </summary>
        public decvec3 gbb => new decvec3(y, z, z);
        
        /// <summary>
        /// Returns decvec4.yzzx swizzling.
        /// </summary>
        public decvec4 yzzx => new decvec4(y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.gbbr swizzling (equivalent to decvec4.yzzx).
        /// </summary>
        public decvec4 gbbr => new decvec4(y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.yzzxx swizzling.
        /// </summary>
        public decvec5 yzzxx => new decvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.gbbrr swizzling (equivalent to decvec4.yzzxx).
        /// </summary>
        public decvec5 gbbrr => new decvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.yzzxy swizzling.
        /// </summary>
        public decvec5 yzzxy => new decvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.gbbrg swizzling (equivalent to decvec4.yzzxy).
        /// </summary>
        public decvec5 gbbrg => new decvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.yzzxz swizzling.
        /// </summary>
        public decvec5 yzzxz => new decvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.gbbrb swizzling (equivalent to decvec4.yzzxz).
        /// </summary>
        public decvec5 gbbrb => new decvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.yzzxw swizzling.
        /// </summary>
        public decvec5 yzzxw => new decvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.gbbra swizzling (equivalent to decvec4.yzzxw).
        /// </summary>
        public decvec5 gbbra => new decvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.yzzy swizzling.
        /// </summary>
        public decvec4 yzzy => new decvec4(y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.gbbg swizzling (equivalent to decvec4.yzzy).
        /// </summary>
        public decvec4 gbbg => new decvec4(y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.yzzyx swizzling.
        /// </summary>
        public decvec5 yzzyx => new decvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.gbbgr swizzling (equivalent to decvec4.yzzyx).
        /// </summary>
        public decvec5 gbbgr => new decvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.yzzyy swizzling.
        /// </summary>
        public decvec5 yzzyy => new decvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.gbbgg swizzling (equivalent to decvec4.yzzyy).
        /// </summary>
        public decvec5 gbbgg => new decvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.yzzyz swizzling.
        /// </summary>
        public decvec5 yzzyz => new decvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.gbbgb swizzling (equivalent to decvec4.yzzyz).
        /// </summary>
        public decvec5 gbbgb => new decvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.yzzyw swizzling.
        /// </summary>
        public decvec5 yzzyw => new decvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.gbbga swizzling (equivalent to decvec4.yzzyw).
        /// </summary>
        public decvec5 gbbga => new decvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.yzzz swizzling.
        /// </summary>
        public decvec4 yzzz => new decvec4(y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.gbbb swizzling (equivalent to decvec4.yzzz).
        /// </summary>
        public decvec4 gbbb => new decvec4(y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.yzzzx swizzling.
        /// </summary>
        public decvec5 yzzzx => new decvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.gbbbr swizzling (equivalent to decvec4.yzzzx).
        /// </summary>
        public decvec5 gbbbr => new decvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.yzzzy swizzling.
        /// </summary>
        public decvec5 yzzzy => new decvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.gbbbg swizzling (equivalent to decvec4.yzzzy).
        /// </summary>
        public decvec5 gbbbg => new decvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.yzzzz swizzling.
        /// </summary>
        public decvec5 yzzzz => new decvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.gbbbb swizzling (equivalent to decvec4.yzzzz).
        /// </summary>
        public decvec5 gbbbb => new decvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.yzzzw swizzling.
        /// </summary>
        public decvec5 yzzzw => new decvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.gbbba swizzling (equivalent to decvec4.yzzzw).
        /// </summary>
        public decvec5 gbbba => new decvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.yzzw swizzling.
        /// </summary>
        public decvec4 yzzw => new decvec4(y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.gbba swizzling (equivalent to decvec4.yzzw).
        /// </summary>
        public decvec4 gbba => new decvec4(y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.yzzwx swizzling.
        /// </summary>
        public decvec5 yzzwx => new decvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.gbbar swizzling (equivalent to decvec4.yzzwx).
        /// </summary>
        public decvec5 gbbar => new decvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.yzzwy swizzling.
        /// </summary>
        public decvec5 yzzwy => new decvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.gbbag swizzling (equivalent to decvec4.yzzwy).
        /// </summary>
        public decvec5 gbbag => new decvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.yzzwz swizzling.
        /// </summary>
        public decvec5 yzzwz => new decvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.gbbab swizzling (equivalent to decvec4.yzzwz).
        /// </summary>
        public decvec5 gbbab => new decvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.yzzww swizzling.
        /// </summary>
        public decvec5 yzzww => new decvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.gbbaa swizzling (equivalent to decvec4.yzzww).
        /// </summary>
        public decvec5 gbbaa => new decvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.yzw swizzling.
        /// </summary>
        public decvec3 yzw => new decvec3(y, z, w);
        
        /// <summary>
        /// Returns decvec4.gba swizzling (equivalent to decvec4.yzw).
        /// </summary>
        public decvec3 gba => new decvec3(y, z, w);
        
        /// <summary>
        /// Returns decvec4.yzwx swizzling.
        /// </summary>
        public decvec4 yzwx => new decvec4(y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.gbar swizzling (equivalent to decvec4.yzwx).
        /// </summary>
        public decvec4 gbar => new decvec4(y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.yzwxx swizzling.
        /// </summary>
        public decvec5 yzwxx => new decvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.gbarr swizzling (equivalent to decvec4.yzwxx).
        /// </summary>
        public decvec5 gbarr => new decvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.yzwxy swizzling.
        /// </summary>
        public decvec5 yzwxy => new decvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.gbarg swizzling (equivalent to decvec4.yzwxy).
        /// </summary>
        public decvec5 gbarg => new decvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.yzwxz swizzling.
        /// </summary>
        public decvec5 yzwxz => new decvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.gbarb swizzling (equivalent to decvec4.yzwxz).
        /// </summary>
        public decvec5 gbarb => new decvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.yzwxw swizzling.
        /// </summary>
        public decvec5 yzwxw => new decvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.gbara swizzling (equivalent to decvec4.yzwxw).
        /// </summary>
        public decvec5 gbara => new decvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.yzwy swizzling.
        /// </summary>
        public decvec4 yzwy => new decvec4(y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.gbag swizzling (equivalent to decvec4.yzwy).
        /// </summary>
        public decvec4 gbag => new decvec4(y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.yzwyx swizzling.
        /// </summary>
        public decvec5 yzwyx => new decvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.gbagr swizzling (equivalent to decvec4.yzwyx).
        /// </summary>
        public decvec5 gbagr => new decvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.yzwyy swizzling.
        /// </summary>
        public decvec5 yzwyy => new decvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.gbagg swizzling (equivalent to decvec4.yzwyy).
        /// </summary>
        public decvec5 gbagg => new decvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.yzwyz swizzling.
        /// </summary>
        public decvec5 yzwyz => new decvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.gbagb swizzling (equivalent to decvec4.yzwyz).
        /// </summary>
        public decvec5 gbagb => new decvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.yzwyw swizzling.
        /// </summary>
        public decvec5 yzwyw => new decvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.gbaga swizzling (equivalent to decvec4.yzwyw).
        /// </summary>
        public decvec5 gbaga => new decvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.yzwz swizzling.
        /// </summary>
        public decvec4 yzwz => new decvec4(y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.gbab swizzling (equivalent to decvec4.yzwz).
        /// </summary>
        public decvec4 gbab => new decvec4(y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.yzwzx swizzling.
        /// </summary>
        public decvec5 yzwzx => new decvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.gbabr swizzling (equivalent to decvec4.yzwzx).
        /// </summary>
        public decvec5 gbabr => new decvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.yzwzy swizzling.
        /// </summary>
        public decvec5 yzwzy => new decvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.gbabg swizzling (equivalent to decvec4.yzwzy).
        /// </summary>
        public decvec5 gbabg => new decvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.yzwzz swizzling.
        /// </summary>
        public decvec5 yzwzz => new decvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.gbabb swizzling (equivalent to decvec4.yzwzz).
        /// </summary>
        public decvec5 gbabb => new decvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.yzwzw swizzling.
        /// </summary>
        public decvec5 yzwzw => new decvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.gbaba swizzling (equivalent to decvec4.yzwzw).
        /// </summary>
        public decvec5 gbaba => new decvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.yzww swizzling.
        /// </summary>
        public decvec4 yzww => new decvec4(y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.gbaa swizzling (equivalent to decvec4.yzww).
        /// </summary>
        public decvec4 gbaa => new decvec4(y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.yzwwx swizzling.
        /// </summary>
        public decvec5 yzwwx => new decvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.gbaar swizzling (equivalent to decvec4.yzwwx).
        /// </summary>
        public decvec5 gbaar => new decvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.yzwwy swizzling.
        /// </summary>
        public decvec5 yzwwy => new decvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.gbaag swizzling (equivalent to decvec4.yzwwy).
        /// </summary>
        public decvec5 gbaag => new decvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.yzwwz swizzling.
        /// </summary>
        public decvec5 yzwwz => new decvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.gbaab swizzling (equivalent to decvec4.yzwwz).
        /// </summary>
        public decvec5 gbaab => new decvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.yzwww swizzling.
        /// </summary>
        public decvec5 yzwww => new decvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.gbaaa swizzling (equivalent to decvec4.yzwww).
        /// </summary>
        public decvec5 gbaaa => new decvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.yw swizzling.
        /// </summary>
        public decvec2 yw => new decvec2(y, w);
        
        /// <summary>
        /// Returns decvec4.ga swizzling (equivalent to decvec4.yw).
        /// </summary>
        public decvec2 ga => new decvec2(y, w);
        
        /// <summary>
        /// Returns decvec4.ywx swizzling.
        /// </summary>
        public decvec3 ywx => new decvec3(y, w, x);
        
        /// <summary>
        /// Returns decvec4.gar swizzling (equivalent to decvec4.ywx).
        /// </summary>
        public decvec3 gar => new decvec3(y, w, x);
        
        /// <summary>
        /// Returns decvec4.ywxx swizzling.
        /// </summary>
        public decvec4 ywxx => new decvec4(y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.garr swizzling (equivalent to decvec4.ywxx).
        /// </summary>
        public decvec4 garr => new decvec4(y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.ywxxx swizzling.
        /// </summary>
        public decvec5 ywxxx => new decvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.garrr swizzling (equivalent to decvec4.ywxxx).
        /// </summary>
        public decvec5 garrr => new decvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.ywxxy swizzling.
        /// </summary>
        public decvec5 ywxxy => new decvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.garrg swizzling (equivalent to decvec4.ywxxy).
        /// </summary>
        public decvec5 garrg => new decvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.ywxxz swizzling.
        /// </summary>
        public decvec5 ywxxz => new decvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.garrb swizzling (equivalent to decvec4.ywxxz).
        /// </summary>
        public decvec5 garrb => new decvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.ywxxw swizzling.
        /// </summary>
        public decvec5 ywxxw => new decvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.garra swizzling (equivalent to decvec4.ywxxw).
        /// </summary>
        public decvec5 garra => new decvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.ywxy swizzling.
        /// </summary>
        public decvec4 ywxy => new decvec4(y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.garg swizzling (equivalent to decvec4.ywxy).
        /// </summary>
        public decvec4 garg => new decvec4(y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.ywxyx swizzling.
        /// </summary>
        public decvec5 ywxyx => new decvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.gargr swizzling (equivalent to decvec4.ywxyx).
        /// </summary>
        public decvec5 gargr => new decvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.ywxyy swizzling.
        /// </summary>
        public decvec5 ywxyy => new decvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.gargg swizzling (equivalent to decvec4.ywxyy).
        /// </summary>
        public decvec5 gargg => new decvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.ywxyz swizzling.
        /// </summary>
        public decvec5 ywxyz => new decvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.gargb swizzling (equivalent to decvec4.ywxyz).
        /// </summary>
        public decvec5 gargb => new decvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.ywxyw swizzling.
        /// </summary>
        public decvec5 ywxyw => new decvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.garga swizzling (equivalent to decvec4.ywxyw).
        /// </summary>
        public decvec5 garga => new decvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.ywxz swizzling.
        /// </summary>
        public decvec4 ywxz => new decvec4(y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.garb swizzling (equivalent to decvec4.ywxz).
        /// </summary>
        public decvec4 garb => new decvec4(y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.ywxzx swizzling.
        /// </summary>
        public decvec5 ywxzx => new decvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.garbr swizzling (equivalent to decvec4.ywxzx).
        /// </summary>
        public decvec5 garbr => new decvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.ywxzy swizzling.
        /// </summary>
        public decvec5 ywxzy => new decvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.garbg swizzling (equivalent to decvec4.ywxzy).
        /// </summary>
        public decvec5 garbg => new decvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.ywxzz swizzling.
        /// </summary>
        public decvec5 ywxzz => new decvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.garbb swizzling (equivalent to decvec4.ywxzz).
        /// </summary>
        public decvec5 garbb => new decvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.ywxzw swizzling.
        /// </summary>
        public decvec5 ywxzw => new decvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.garba swizzling (equivalent to decvec4.ywxzw).
        /// </summary>
        public decvec5 garba => new decvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.ywxw swizzling.
        /// </summary>
        public decvec4 ywxw => new decvec4(y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.gara swizzling (equivalent to decvec4.ywxw).
        /// </summary>
        public decvec4 gara => new decvec4(y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.ywxwx swizzling.
        /// </summary>
        public decvec5 ywxwx => new decvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.garar swizzling (equivalent to decvec4.ywxwx).
        /// </summary>
        public decvec5 garar => new decvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.ywxwy swizzling.
        /// </summary>
        public decvec5 ywxwy => new decvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.garag swizzling (equivalent to decvec4.ywxwy).
        /// </summary>
        public decvec5 garag => new decvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.ywxwz swizzling.
        /// </summary>
        public decvec5 ywxwz => new decvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.garab swizzling (equivalent to decvec4.ywxwz).
        /// </summary>
        public decvec5 garab => new decvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.ywxww swizzling.
        /// </summary>
        public decvec5 ywxww => new decvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.garaa swizzling (equivalent to decvec4.ywxww).
        /// </summary>
        public decvec5 garaa => new decvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.ywy swizzling.
        /// </summary>
        public decvec3 ywy => new decvec3(y, w, y);
        
        /// <summary>
        /// Returns decvec4.gag swizzling (equivalent to decvec4.ywy).
        /// </summary>
        public decvec3 gag => new decvec3(y, w, y);
        
        /// <summary>
        /// Returns decvec4.ywyx swizzling.
        /// </summary>
        public decvec4 ywyx => new decvec4(y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.gagr swizzling (equivalent to decvec4.ywyx).
        /// </summary>
        public decvec4 gagr => new decvec4(y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.ywyxx swizzling.
        /// </summary>
        public decvec5 ywyxx => new decvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.gagrr swizzling (equivalent to decvec4.ywyxx).
        /// </summary>
        public decvec5 gagrr => new decvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.ywyxy swizzling.
        /// </summary>
        public decvec5 ywyxy => new decvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.gagrg swizzling (equivalent to decvec4.ywyxy).
        /// </summary>
        public decvec5 gagrg => new decvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.ywyxz swizzling.
        /// </summary>
        public decvec5 ywyxz => new decvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.gagrb swizzling (equivalent to decvec4.ywyxz).
        /// </summary>
        public decvec5 gagrb => new decvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.ywyxw swizzling.
        /// </summary>
        public decvec5 ywyxw => new decvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.gagra swizzling (equivalent to decvec4.ywyxw).
        /// </summary>
        public decvec5 gagra => new decvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.ywyy swizzling.
        /// </summary>
        public decvec4 ywyy => new decvec4(y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.gagg swizzling (equivalent to decvec4.ywyy).
        /// </summary>
        public decvec4 gagg => new decvec4(y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.ywyyx swizzling.
        /// </summary>
        public decvec5 ywyyx => new decvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.gaggr swizzling (equivalent to decvec4.ywyyx).
        /// </summary>
        public decvec5 gaggr => new decvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.ywyyy swizzling.
        /// </summary>
        public decvec5 ywyyy => new decvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.gaggg swizzling (equivalent to decvec4.ywyyy).
        /// </summary>
        public decvec5 gaggg => new decvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.ywyyz swizzling.
        /// </summary>
        public decvec5 ywyyz => new decvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.gaggb swizzling (equivalent to decvec4.ywyyz).
        /// </summary>
        public decvec5 gaggb => new decvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.ywyyw swizzling.
        /// </summary>
        public decvec5 ywyyw => new decvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.gagga swizzling (equivalent to decvec4.ywyyw).
        /// </summary>
        public decvec5 gagga => new decvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.ywyz swizzling.
        /// </summary>
        public decvec4 ywyz => new decvec4(y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.gagb swizzling (equivalent to decvec4.ywyz).
        /// </summary>
        public decvec4 gagb => new decvec4(y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.ywyzx swizzling.
        /// </summary>
        public decvec5 ywyzx => new decvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.gagbr swizzling (equivalent to decvec4.ywyzx).
        /// </summary>
        public decvec5 gagbr => new decvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.ywyzy swizzling.
        /// </summary>
        public decvec5 ywyzy => new decvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.gagbg swizzling (equivalent to decvec4.ywyzy).
        /// </summary>
        public decvec5 gagbg => new decvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.ywyzz swizzling.
        /// </summary>
        public decvec5 ywyzz => new decvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.gagbb swizzling (equivalent to decvec4.ywyzz).
        /// </summary>
        public decvec5 gagbb => new decvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.ywyzw swizzling.
        /// </summary>
        public decvec5 ywyzw => new decvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.gagba swizzling (equivalent to decvec4.ywyzw).
        /// </summary>
        public decvec5 gagba => new decvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.ywyw swizzling.
        /// </summary>
        public decvec4 ywyw => new decvec4(y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.gaga swizzling (equivalent to decvec4.ywyw).
        /// </summary>
        public decvec4 gaga => new decvec4(y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.ywywx swizzling.
        /// </summary>
        public decvec5 ywywx => new decvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.gagar swizzling (equivalent to decvec4.ywywx).
        /// </summary>
        public decvec5 gagar => new decvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.ywywy swizzling.
        /// </summary>
        public decvec5 ywywy => new decvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.gagag swizzling (equivalent to decvec4.ywywy).
        /// </summary>
        public decvec5 gagag => new decvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.ywywz swizzling.
        /// </summary>
        public decvec5 ywywz => new decvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.gagab swizzling (equivalent to decvec4.ywywz).
        /// </summary>
        public decvec5 gagab => new decvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.ywyww swizzling.
        /// </summary>
        public decvec5 ywyww => new decvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.gagaa swizzling (equivalent to decvec4.ywyww).
        /// </summary>
        public decvec5 gagaa => new decvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.ywz swizzling.
        /// </summary>
        public decvec3 ywz => new decvec3(y, w, z);
        
        /// <summary>
        /// Returns decvec4.gab swizzling (equivalent to decvec4.ywz).
        /// </summary>
        public decvec3 gab => new decvec3(y, w, z);
        
        /// <summary>
        /// Returns decvec4.ywzx swizzling.
        /// </summary>
        public decvec4 ywzx => new decvec4(y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.gabr swizzling (equivalent to decvec4.ywzx).
        /// </summary>
        public decvec4 gabr => new decvec4(y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.ywzxx swizzling.
        /// </summary>
        public decvec5 ywzxx => new decvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.gabrr swizzling (equivalent to decvec4.ywzxx).
        /// </summary>
        public decvec5 gabrr => new decvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.ywzxy swizzling.
        /// </summary>
        public decvec5 ywzxy => new decvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.gabrg swizzling (equivalent to decvec4.ywzxy).
        /// </summary>
        public decvec5 gabrg => new decvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.ywzxz swizzling.
        /// </summary>
        public decvec5 ywzxz => new decvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.gabrb swizzling (equivalent to decvec4.ywzxz).
        /// </summary>
        public decvec5 gabrb => new decvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.ywzxw swizzling.
        /// </summary>
        public decvec5 ywzxw => new decvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.gabra swizzling (equivalent to decvec4.ywzxw).
        /// </summary>
        public decvec5 gabra => new decvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.ywzy swizzling.
        /// </summary>
        public decvec4 ywzy => new decvec4(y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.gabg swizzling (equivalent to decvec4.ywzy).
        /// </summary>
        public decvec4 gabg => new decvec4(y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.ywzyx swizzling.
        /// </summary>
        public decvec5 ywzyx => new decvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.gabgr swizzling (equivalent to decvec4.ywzyx).
        /// </summary>
        public decvec5 gabgr => new decvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.ywzyy swizzling.
        /// </summary>
        public decvec5 ywzyy => new decvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.gabgg swizzling (equivalent to decvec4.ywzyy).
        /// </summary>
        public decvec5 gabgg => new decvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.ywzyz swizzling.
        /// </summary>
        public decvec5 ywzyz => new decvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.gabgb swizzling (equivalent to decvec4.ywzyz).
        /// </summary>
        public decvec5 gabgb => new decvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.ywzyw swizzling.
        /// </summary>
        public decvec5 ywzyw => new decvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.gabga swizzling (equivalent to decvec4.ywzyw).
        /// </summary>
        public decvec5 gabga => new decvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.ywzz swizzling.
        /// </summary>
        public decvec4 ywzz => new decvec4(y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.gabb swizzling (equivalent to decvec4.ywzz).
        /// </summary>
        public decvec4 gabb => new decvec4(y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.ywzzx swizzling.
        /// </summary>
        public decvec5 ywzzx => new decvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.gabbr swizzling (equivalent to decvec4.ywzzx).
        /// </summary>
        public decvec5 gabbr => new decvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.ywzzy swizzling.
        /// </summary>
        public decvec5 ywzzy => new decvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.gabbg swizzling (equivalent to decvec4.ywzzy).
        /// </summary>
        public decvec5 gabbg => new decvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.ywzzz swizzling.
        /// </summary>
        public decvec5 ywzzz => new decvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.gabbb swizzling (equivalent to decvec4.ywzzz).
        /// </summary>
        public decvec5 gabbb => new decvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.ywzzw swizzling.
        /// </summary>
        public decvec5 ywzzw => new decvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.gabba swizzling (equivalent to decvec4.ywzzw).
        /// </summary>
        public decvec5 gabba => new decvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.ywzw swizzling.
        /// </summary>
        public decvec4 ywzw => new decvec4(y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.gaba swizzling (equivalent to decvec4.ywzw).
        /// </summary>
        public decvec4 gaba => new decvec4(y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.ywzwx swizzling.
        /// </summary>
        public decvec5 ywzwx => new decvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.gabar swizzling (equivalent to decvec4.ywzwx).
        /// </summary>
        public decvec5 gabar => new decvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.ywzwy swizzling.
        /// </summary>
        public decvec5 ywzwy => new decvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.gabag swizzling (equivalent to decvec4.ywzwy).
        /// </summary>
        public decvec5 gabag => new decvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.ywzwz swizzling.
        /// </summary>
        public decvec5 ywzwz => new decvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.gabab swizzling (equivalent to decvec4.ywzwz).
        /// </summary>
        public decvec5 gabab => new decvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.ywzww swizzling.
        /// </summary>
        public decvec5 ywzww => new decvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.gabaa swizzling (equivalent to decvec4.ywzww).
        /// </summary>
        public decvec5 gabaa => new decvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.yww swizzling.
        /// </summary>
        public decvec3 yww => new decvec3(y, w, w);
        
        /// <summary>
        /// Returns decvec4.gaa swizzling (equivalent to decvec4.yww).
        /// </summary>
        public decvec3 gaa => new decvec3(y, w, w);
        
        /// <summary>
        /// Returns decvec4.ywwx swizzling.
        /// </summary>
        public decvec4 ywwx => new decvec4(y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.gaar swizzling (equivalent to decvec4.ywwx).
        /// </summary>
        public decvec4 gaar => new decvec4(y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.ywwxx swizzling.
        /// </summary>
        public decvec5 ywwxx => new decvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.gaarr swizzling (equivalent to decvec4.ywwxx).
        /// </summary>
        public decvec5 gaarr => new decvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.ywwxy swizzling.
        /// </summary>
        public decvec5 ywwxy => new decvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.gaarg swizzling (equivalent to decvec4.ywwxy).
        /// </summary>
        public decvec5 gaarg => new decvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.ywwxz swizzling.
        /// </summary>
        public decvec5 ywwxz => new decvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.gaarb swizzling (equivalent to decvec4.ywwxz).
        /// </summary>
        public decvec5 gaarb => new decvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.ywwxw swizzling.
        /// </summary>
        public decvec5 ywwxw => new decvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.gaara swizzling (equivalent to decvec4.ywwxw).
        /// </summary>
        public decvec5 gaara => new decvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.ywwy swizzling.
        /// </summary>
        public decvec4 ywwy => new decvec4(y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.gaag swizzling (equivalent to decvec4.ywwy).
        /// </summary>
        public decvec4 gaag => new decvec4(y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.ywwyx swizzling.
        /// </summary>
        public decvec5 ywwyx => new decvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.gaagr swizzling (equivalent to decvec4.ywwyx).
        /// </summary>
        public decvec5 gaagr => new decvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.ywwyy swizzling.
        /// </summary>
        public decvec5 ywwyy => new decvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.gaagg swizzling (equivalent to decvec4.ywwyy).
        /// </summary>
        public decvec5 gaagg => new decvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.ywwyz swizzling.
        /// </summary>
        public decvec5 ywwyz => new decvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.gaagb swizzling (equivalent to decvec4.ywwyz).
        /// </summary>
        public decvec5 gaagb => new decvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.ywwyw swizzling.
        /// </summary>
        public decvec5 ywwyw => new decvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.gaaga swizzling (equivalent to decvec4.ywwyw).
        /// </summary>
        public decvec5 gaaga => new decvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.ywwz swizzling.
        /// </summary>
        public decvec4 ywwz => new decvec4(y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.gaab swizzling (equivalent to decvec4.ywwz).
        /// </summary>
        public decvec4 gaab => new decvec4(y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.ywwzx swizzling.
        /// </summary>
        public decvec5 ywwzx => new decvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.gaabr swizzling (equivalent to decvec4.ywwzx).
        /// </summary>
        public decvec5 gaabr => new decvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.ywwzy swizzling.
        /// </summary>
        public decvec5 ywwzy => new decvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.gaabg swizzling (equivalent to decvec4.ywwzy).
        /// </summary>
        public decvec5 gaabg => new decvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.ywwzz swizzling.
        /// </summary>
        public decvec5 ywwzz => new decvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.gaabb swizzling (equivalent to decvec4.ywwzz).
        /// </summary>
        public decvec5 gaabb => new decvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.ywwzw swizzling.
        /// </summary>
        public decvec5 ywwzw => new decvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.gaaba swizzling (equivalent to decvec4.ywwzw).
        /// </summary>
        public decvec5 gaaba => new decvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.ywww swizzling.
        /// </summary>
        public decvec4 ywww => new decvec4(y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.gaaa swizzling (equivalent to decvec4.ywww).
        /// </summary>
        public decvec4 gaaa => new decvec4(y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.ywwwx swizzling.
        /// </summary>
        public decvec5 ywwwx => new decvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.gaaar swizzling (equivalent to decvec4.ywwwx).
        /// </summary>
        public decvec5 gaaar => new decvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.ywwwy swizzling.
        /// </summary>
        public decvec5 ywwwy => new decvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.gaaag swizzling (equivalent to decvec4.ywwwy).
        /// </summary>
        public decvec5 gaaag => new decvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.ywwwz swizzling.
        /// </summary>
        public decvec5 ywwwz => new decvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.gaaab swizzling (equivalent to decvec4.ywwwz).
        /// </summary>
        public decvec5 gaaab => new decvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.ywwww swizzling.
        /// </summary>
        public decvec5 ywwww => new decvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns decvec4.gaaaa swizzling (equivalent to decvec4.ywwww).
        /// </summary>
        public decvec5 gaaaa => new decvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns decvec4.zx swizzling.
        /// </summary>
        public decvec2 zx => new decvec2(z, x);
        
        /// <summary>
        /// Returns decvec4.br swizzling (equivalent to decvec4.zx).
        /// </summary>
        public decvec2 br => new decvec2(z, x);
        
        /// <summary>
        /// Returns decvec4.zxx swizzling.
        /// </summary>
        public decvec3 zxx => new decvec3(z, x, x);
        
        /// <summary>
        /// Returns decvec4.brr swizzling (equivalent to decvec4.zxx).
        /// </summary>
        public decvec3 brr => new decvec3(z, x, x);
        
        /// <summary>
        /// Returns decvec4.zxxx swizzling.
        /// </summary>
        public decvec4 zxxx => new decvec4(z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.brrr swizzling (equivalent to decvec4.zxxx).
        /// </summary>
        public decvec4 brrr => new decvec4(z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.zxxxx swizzling.
        /// </summary>
        public decvec5 zxxxx => new decvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.brrrr swizzling (equivalent to decvec4.zxxxx).
        /// </summary>
        public decvec5 brrrr => new decvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.zxxxy swizzling.
        /// </summary>
        public decvec5 zxxxy => new decvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.brrrg swizzling (equivalent to decvec4.zxxxy).
        /// </summary>
        public decvec5 brrrg => new decvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.zxxxz swizzling.
        /// </summary>
        public decvec5 zxxxz => new decvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.brrrb swizzling (equivalent to decvec4.zxxxz).
        /// </summary>
        public decvec5 brrrb => new decvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.zxxxw swizzling.
        /// </summary>
        public decvec5 zxxxw => new decvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.brrra swizzling (equivalent to decvec4.zxxxw).
        /// </summary>
        public decvec5 brrra => new decvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.zxxy swizzling.
        /// </summary>
        public decvec4 zxxy => new decvec4(z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.brrg swizzling (equivalent to decvec4.zxxy).
        /// </summary>
        public decvec4 brrg => new decvec4(z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.zxxyx swizzling.
        /// </summary>
        public decvec5 zxxyx => new decvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.brrgr swizzling (equivalent to decvec4.zxxyx).
        /// </summary>
        public decvec5 brrgr => new decvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.zxxyy swizzling.
        /// </summary>
        public decvec5 zxxyy => new decvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.brrgg swizzling (equivalent to decvec4.zxxyy).
        /// </summary>
        public decvec5 brrgg => new decvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.zxxyz swizzling.
        /// </summary>
        public decvec5 zxxyz => new decvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.brrgb swizzling (equivalent to decvec4.zxxyz).
        /// </summary>
        public decvec5 brrgb => new decvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.zxxyw swizzling.
        /// </summary>
        public decvec5 zxxyw => new decvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.brrga swizzling (equivalent to decvec4.zxxyw).
        /// </summary>
        public decvec5 brrga => new decvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.zxxz swizzling.
        /// </summary>
        public decvec4 zxxz => new decvec4(z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.brrb swizzling (equivalent to decvec4.zxxz).
        /// </summary>
        public decvec4 brrb => new decvec4(z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.zxxzx swizzling.
        /// </summary>
        public decvec5 zxxzx => new decvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.brrbr swizzling (equivalent to decvec4.zxxzx).
        /// </summary>
        public decvec5 brrbr => new decvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.zxxzy swizzling.
        /// </summary>
        public decvec5 zxxzy => new decvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.brrbg swizzling (equivalent to decvec4.zxxzy).
        /// </summary>
        public decvec5 brrbg => new decvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.zxxzz swizzling.
        /// </summary>
        public decvec5 zxxzz => new decvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.brrbb swizzling (equivalent to decvec4.zxxzz).
        /// </summary>
        public decvec5 brrbb => new decvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.zxxzw swizzling.
        /// </summary>
        public decvec5 zxxzw => new decvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.brrba swizzling (equivalent to decvec4.zxxzw).
        /// </summary>
        public decvec5 brrba => new decvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.zxxw swizzling.
        /// </summary>
        public decvec4 zxxw => new decvec4(z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.brra swizzling (equivalent to decvec4.zxxw).
        /// </summary>
        public decvec4 brra => new decvec4(z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.zxxwx swizzling.
        /// </summary>
        public decvec5 zxxwx => new decvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.brrar swizzling (equivalent to decvec4.zxxwx).
        /// </summary>
        public decvec5 brrar => new decvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.zxxwy swizzling.
        /// </summary>
        public decvec5 zxxwy => new decvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.brrag swizzling (equivalent to decvec4.zxxwy).
        /// </summary>
        public decvec5 brrag => new decvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.zxxwz swizzling.
        /// </summary>
        public decvec5 zxxwz => new decvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.brrab swizzling (equivalent to decvec4.zxxwz).
        /// </summary>
        public decvec5 brrab => new decvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.zxxww swizzling.
        /// </summary>
        public decvec5 zxxww => new decvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.brraa swizzling (equivalent to decvec4.zxxww).
        /// </summary>
        public decvec5 brraa => new decvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.zxy swizzling.
        /// </summary>
        public decvec3 zxy => new decvec3(z, x, y);
        
        /// <summary>
        /// Returns decvec4.brg swizzling (equivalent to decvec4.zxy).
        /// </summary>
        public decvec3 brg => new decvec3(z, x, y);
        
        /// <summary>
        /// Returns decvec4.zxyx swizzling.
        /// </summary>
        public decvec4 zxyx => new decvec4(z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.brgr swizzling (equivalent to decvec4.zxyx).
        /// </summary>
        public decvec4 brgr => new decvec4(z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.zxyxx swizzling.
        /// </summary>
        public decvec5 zxyxx => new decvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.brgrr swizzling (equivalent to decvec4.zxyxx).
        /// </summary>
        public decvec5 brgrr => new decvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.zxyxy swizzling.
        /// </summary>
        public decvec5 zxyxy => new decvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.brgrg swizzling (equivalent to decvec4.zxyxy).
        /// </summary>
        public decvec5 brgrg => new decvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.zxyxz swizzling.
        /// </summary>
        public decvec5 zxyxz => new decvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.brgrb swizzling (equivalent to decvec4.zxyxz).
        /// </summary>
        public decvec5 brgrb => new decvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.zxyxw swizzling.
        /// </summary>
        public decvec5 zxyxw => new decvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.brgra swizzling (equivalent to decvec4.zxyxw).
        /// </summary>
        public decvec5 brgra => new decvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.zxyy swizzling.
        /// </summary>
        public decvec4 zxyy => new decvec4(z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.brgg swizzling (equivalent to decvec4.zxyy).
        /// </summary>
        public decvec4 brgg => new decvec4(z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.zxyyx swizzling.
        /// </summary>
        public decvec5 zxyyx => new decvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.brggr swizzling (equivalent to decvec4.zxyyx).
        /// </summary>
        public decvec5 brggr => new decvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.zxyyy swizzling.
        /// </summary>
        public decvec5 zxyyy => new decvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.brggg swizzling (equivalent to decvec4.zxyyy).
        /// </summary>
        public decvec5 brggg => new decvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.zxyyz swizzling.
        /// </summary>
        public decvec5 zxyyz => new decvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.brggb swizzling (equivalent to decvec4.zxyyz).
        /// </summary>
        public decvec5 brggb => new decvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.zxyyw swizzling.
        /// </summary>
        public decvec5 zxyyw => new decvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.brgga swizzling (equivalent to decvec4.zxyyw).
        /// </summary>
        public decvec5 brgga => new decvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.zxyz swizzling.
        /// </summary>
        public decvec4 zxyz => new decvec4(z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.brgb swizzling (equivalent to decvec4.zxyz).
        /// </summary>
        public decvec4 brgb => new decvec4(z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.zxyzx swizzling.
        /// </summary>
        public decvec5 zxyzx => new decvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.brgbr swizzling (equivalent to decvec4.zxyzx).
        /// </summary>
        public decvec5 brgbr => new decvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.zxyzy swizzling.
        /// </summary>
        public decvec5 zxyzy => new decvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.brgbg swizzling (equivalent to decvec4.zxyzy).
        /// </summary>
        public decvec5 brgbg => new decvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.zxyzz swizzling.
        /// </summary>
        public decvec5 zxyzz => new decvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.brgbb swizzling (equivalent to decvec4.zxyzz).
        /// </summary>
        public decvec5 brgbb => new decvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.zxyzw swizzling.
        /// </summary>
        public decvec5 zxyzw => new decvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.brgba swizzling (equivalent to decvec4.zxyzw).
        /// </summary>
        public decvec5 brgba => new decvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.zxyw swizzling.
        /// </summary>
        public decvec4 zxyw => new decvec4(z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.brga swizzling (equivalent to decvec4.zxyw).
        /// </summary>
        public decvec4 brga => new decvec4(z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.zxywx swizzling.
        /// </summary>
        public decvec5 zxywx => new decvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.brgar swizzling (equivalent to decvec4.zxywx).
        /// </summary>
        public decvec5 brgar => new decvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.zxywy swizzling.
        /// </summary>
        public decvec5 zxywy => new decvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.brgag swizzling (equivalent to decvec4.zxywy).
        /// </summary>
        public decvec5 brgag => new decvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.zxywz swizzling.
        /// </summary>
        public decvec5 zxywz => new decvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.brgab swizzling (equivalent to decvec4.zxywz).
        /// </summary>
        public decvec5 brgab => new decvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.zxyww swizzling.
        /// </summary>
        public decvec5 zxyww => new decvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.brgaa swizzling (equivalent to decvec4.zxyww).
        /// </summary>
        public decvec5 brgaa => new decvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.zxz swizzling.
        /// </summary>
        public decvec3 zxz => new decvec3(z, x, z);
        
        /// <summary>
        /// Returns decvec4.brb swizzling (equivalent to decvec4.zxz).
        /// </summary>
        public decvec3 brb => new decvec3(z, x, z);
        
        /// <summary>
        /// Returns decvec4.zxzx swizzling.
        /// </summary>
        public decvec4 zxzx => new decvec4(z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.brbr swizzling (equivalent to decvec4.zxzx).
        /// </summary>
        public decvec4 brbr => new decvec4(z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.zxzxx swizzling.
        /// </summary>
        public decvec5 zxzxx => new decvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.brbrr swizzling (equivalent to decvec4.zxzxx).
        /// </summary>
        public decvec5 brbrr => new decvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.zxzxy swizzling.
        /// </summary>
        public decvec5 zxzxy => new decvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.brbrg swizzling (equivalent to decvec4.zxzxy).
        /// </summary>
        public decvec5 brbrg => new decvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.zxzxz swizzling.
        /// </summary>
        public decvec5 zxzxz => new decvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.brbrb swizzling (equivalent to decvec4.zxzxz).
        /// </summary>
        public decvec5 brbrb => new decvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.zxzxw swizzling.
        /// </summary>
        public decvec5 zxzxw => new decvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.brbra swizzling (equivalent to decvec4.zxzxw).
        /// </summary>
        public decvec5 brbra => new decvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.zxzy swizzling.
        /// </summary>
        public decvec4 zxzy => new decvec4(z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.brbg swizzling (equivalent to decvec4.zxzy).
        /// </summary>
        public decvec4 brbg => new decvec4(z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.zxzyx swizzling.
        /// </summary>
        public decvec5 zxzyx => new decvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.brbgr swizzling (equivalent to decvec4.zxzyx).
        /// </summary>
        public decvec5 brbgr => new decvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.zxzyy swizzling.
        /// </summary>
        public decvec5 zxzyy => new decvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.brbgg swizzling (equivalent to decvec4.zxzyy).
        /// </summary>
        public decvec5 brbgg => new decvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.zxzyz swizzling.
        /// </summary>
        public decvec5 zxzyz => new decvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.brbgb swizzling (equivalent to decvec4.zxzyz).
        /// </summary>
        public decvec5 brbgb => new decvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.zxzyw swizzling.
        /// </summary>
        public decvec5 zxzyw => new decvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.brbga swizzling (equivalent to decvec4.zxzyw).
        /// </summary>
        public decvec5 brbga => new decvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.zxzz swizzling.
        /// </summary>
        public decvec4 zxzz => new decvec4(z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.brbb swizzling (equivalent to decvec4.zxzz).
        /// </summary>
        public decvec4 brbb => new decvec4(z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.zxzzx swizzling.
        /// </summary>
        public decvec5 zxzzx => new decvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.brbbr swizzling (equivalent to decvec4.zxzzx).
        /// </summary>
        public decvec5 brbbr => new decvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.zxzzy swizzling.
        /// </summary>
        public decvec5 zxzzy => new decvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.brbbg swizzling (equivalent to decvec4.zxzzy).
        /// </summary>
        public decvec5 brbbg => new decvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.zxzzz swizzling.
        /// </summary>
        public decvec5 zxzzz => new decvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.brbbb swizzling (equivalent to decvec4.zxzzz).
        /// </summary>
        public decvec5 brbbb => new decvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.zxzzw swizzling.
        /// </summary>
        public decvec5 zxzzw => new decvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.brbba swizzling (equivalent to decvec4.zxzzw).
        /// </summary>
        public decvec5 brbba => new decvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.zxzw swizzling.
        /// </summary>
        public decvec4 zxzw => new decvec4(z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.brba swizzling (equivalent to decvec4.zxzw).
        /// </summary>
        public decvec4 brba => new decvec4(z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.zxzwx swizzling.
        /// </summary>
        public decvec5 zxzwx => new decvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.brbar swizzling (equivalent to decvec4.zxzwx).
        /// </summary>
        public decvec5 brbar => new decvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.zxzwy swizzling.
        /// </summary>
        public decvec5 zxzwy => new decvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.brbag swizzling (equivalent to decvec4.zxzwy).
        /// </summary>
        public decvec5 brbag => new decvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.zxzwz swizzling.
        /// </summary>
        public decvec5 zxzwz => new decvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.brbab swizzling (equivalent to decvec4.zxzwz).
        /// </summary>
        public decvec5 brbab => new decvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.zxzww swizzling.
        /// </summary>
        public decvec5 zxzww => new decvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.brbaa swizzling (equivalent to decvec4.zxzww).
        /// </summary>
        public decvec5 brbaa => new decvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.zxw swizzling.
        /// </summary>
        public decvec3 zxw => new decvec3(z, x, w);
        
        /// <summary>
        /// Returns decvec4.bra swizzling (equivalent to decvec4.zxw).
        /// </summary>
        public decvec3 bra => new decvec3(z, x, w);
        
        /// <summary>
        /// Returns decvec4.zxwx swizzling.
        /// </summary>
        public decvec4 zxwx => new decvec4(z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.brar swizzling (equivalent to decvec4.zxwx).
        /// </summary>
        public decvec4 brar => new decvec4(z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.zxwxx swizzling.
        /// </summary>
        public decvec5 zxwxx => new decvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.brarr swizzling (equivalent to decvec4.zxwxx).
        /// </summary>
        public decvec5 brarr => new decvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.zxwxy swizzling.
        /// </summary>
        public decvec5 zxwxy => new decvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.brarg swizzling (equivalent to decvec4.zxwxy).
        /// </summary>
        public decvec5 brarg => new decvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.zxwxz swizzling.
        /// </summary>
        public decvec5 zxwxz => new decvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.brarb swizzling (equivalent to decvec4.zxwxz).
        /// </summary>
        public decvec5 brarb => new decvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.zxwxw swizzling.
        /// </summary>
        public decvec5 zxwxw => new decvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.brara swizzling (equivalent to decvec4.zxwxw).
        /// </summary>
        public decvec5 brara => new decvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.zxwy swizzling.
        /// </summary>
        public decvec4 zxwy => new decvec4(z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.brag swizzling (equivalent to decvec4.zxwy).
        /// </summary>
        public decvec4 brag => new decvec4(z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.zxwyx swizzling.
        /// </summary>
        public decvec5 zxwyx => new decvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.bragr swizzling (equivalent to decvec4.zxwyx).
        /// </summary>
        public decvec5 bragr => new decvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.zxwyy swizzling.
        /// </summary>
        public decvec5 zxwyy => new decvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.bragg swizzling (equivalent to decvec4.zxwyy).
        /// </summary>
        public decvec5 bragg => new decvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.zxwyz swizzling.
        /// </summary>
        public decvec5 zxwyz => new decvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.bragb swizzling (equivalent to decvec4.zxwyz).
        /// </summary>
        public decvec5 bragb => new decvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.zxwyw swizzling.
        /// </summary>
        public decvec5 zxwyw => new decvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.braga swizzling (equivalent to decvec4.zxwyw).
        /// </summary>
        public decvec5 braga => new decvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.zxwz swizzling.
        /// </summary>
        public decvec4 zxwz => new decvec4(z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.brab swizzling (equivalent to decvec4.zxwz).
        /// </summary>
        public decvec4 brab => new decvec4(z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.zxwzx swizzling.
        /// </summary>
        public decvec5 zxwzx => new decvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.brabr swizzling (equivalent to decvec4.zxwzx).
        /// </summary>
        public decvec5 brabr => new decvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.zxwzy swizzling.
        /// </summary>
        public decvec5 zxwzy => new decvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.brabg swizzling (equivalent to decvec4.zxwzy).
        /// </summary>
        public decvec5 brabg => new decvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.zxwzz swizzling.
        /// </summary>
        public decvec5 zxwzz => new decvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.brabb swizzling (equivalent to decvec4.zxwzz).
        /// </summary>
        public decvec5 brabb => new decvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.zxwzw swizzling.
        /// </summary>
        public decvec5 zxwzw => new decvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.braba swizzling (equivalent to decvec4.zxwzw).
        /// </summary>
        public decvec5 braba => new decvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.zxww swizzling.
        /// </summary>
        public decvec4 zxww => new decvec4(z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.braa swizzling (equivalent to decvec4.zxww).
        /// </summary>
        public decvec4 braa => new decvec4(z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.zxwwx swizzling.
        /// </summary>
        public decvec5 zxwwx => new decvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.braar swizzling (equivalent to decvec4.zxwwx).
        /// </summary>
        public decvec5 braar => new decvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.zxwwy swizzling.
        /// </summary>
        public decvec5 zxwwy => new decvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.braag swizzling (equivalent to decvec4.zxwwy).
        /// </summary>
        public decvec5 braag => new decvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.zxwwz swizzling.
        /// </summary>
        public decvec5 zxwwz => new decvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.braab swizzling (equivalent to decvec4.zxwwz).
        /// </summary>
        public decvec5 braab => new decvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.zxwww swizzling.
        /// </summary>
        public decvec5 zxwww => new decvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.braaa swizzling (equivalent to decvec4.zxwww).
        /// </summary>
        public decvec5 braaa => new decvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.zy swizzling.
        /// </summary>
        public decvec2 zy => new decvec2(z, y);
        
        /// <summary>
        /// Returns decvec4.bg swizzling (equivalent to decvec4.zy).
        /// </summary>
        public decvec2 bg => new decvec2(z, y);
        
        /// <summary>
        /// Returns decvec4.zyx swizzling.
        /// </summary>
        public decvec3 zyx => new decvec3(z, y, x);
        
        /// <summary>
        /// Returns decvec4.bgr swizzling (equivalent to decvec4.zyx).
        /// </summary>
        public decvec3 bgr => new decvec3(z, y, x);
        
        /// <summary>
        /// Returns decvec4.zyxx swizzling.
        /// </summary>
        public decvec4 zyxx => new decvec4(z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.bgrr swizzling (equivalent to decvec4.zyxx).
        /// </summary>
        public decvec4 bgrr => new decvec4(z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.zyxxx swizzling.
        /// </summary>
        public decvec5 zyxxx => new decvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.bgrrr swizzling (equivalent to decvec4.zyxxx).
        /// </summary>
        public decvec5 bgrrr => new decvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.zyxxy swizzling.
        /// </summary>
        public decvec5 zyxxy => new decvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.bgrrg swizzling (equivalent to decvec4.zyxxy).
        /// </summary>
        public decvec5 bgrrg => new decvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.zyxxz swizzling.
        /// </summary>
        public decvec5 zyxxz => new decvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.bgrrb swizzling (equivalent to decvec4.zyxxz).
        /// </summary>
        public decvec5 bgrrb => new decvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.zyxxw swizzling.
        /// </summary>
        public decvec5 zyxxw => new decvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.bgrra swizzling (equivalent to decvec4.zyxxw).
        /// </summary>
        public decvec5 bgrra => new decvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.zyxy swizzling.
        /// </summary>
        public decvec4 zyxy => new decvec4(z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.bgrg swizzling (equivalent to decvec4.zyxy).
        /// </summary>
        public decvec4 bgrg => new decvec4(z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.zyxyx swizzling.
        /// </summary>
        public decvec5 zyxyx => new decvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.bgrgr swizzling (equivalent to decvec4.zyxyx).
        /// </summary>
        public decvec5 bgrgr => new decvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.zyxyy swizzling.
        /// </summary>
        public decvec5 zyxyy => new decvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.bgrgg swizzling (equivalent to decvec4.zyxyy).
        /// </summary>
        public decvec5 bgrgg => new decvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.zyxyz swizzling.
        /// </summary>
        public decvec5 zyxyz => new decvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.bgrgb swizzling (equivalent to decvec4.zyxyz).
        /// </summary>
        public decvec5 bgrgb => new decvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.zyxyw swizzling.
        /// </summary>
        public decvec5 zyxyw => new decvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.bgrga swizzling (equivalent to decvec4.zyxyw).
        /// </summary>
        public decvec5 bgrga => new decvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.zyxz swizzling.
        /// </summary>
        public decvec4 zyxz => new decvec4(z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.bgrb swizzling (equivalent to decvec4.zyxz).
        /// </summary>
        public decvec4 bgrb => new decvec4(z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.zyxzx swizzling.
        /// </summary>
        public decvec5 zyxzx => new decvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.bgrbr swizzling (equivalent to decvec4.zyxzx).
        /// </summary>
        public decvec5 bgrbr => new decvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.zyxzy swizzling.
        /// </summary>
        public decvec5 zyxzy => new decvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.bgrbg swizzling (equivalent to decvec4.zyxzy).
        /// </summary>
        public decvec5 bgrbg => new decvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.zyxzz swizzling.
        /// </summary>
        public decvec5 zyxzz => new decvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.bgrbb swizzling (equivalent to decvec4.zyxzz).
        /// </summary>
        public decvec5 bgrbb => new decvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.zyxzw swizzling.
        /// </summary>
        public decvec5 zyxzw => new decvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.bgrba swizzling (equivalent to decvec4.zyxzw).
        /// </summary>
        public decvec5 bgrba => new decvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.zyxw swizzling.
        /// </summary>
        public decvec4 zyxw => new decvec4(z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.bgra swizzling (equivalent to decvec4.zyxw).
        /// </summary>
        public decvec4 bgra => new decvec4(z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.zyxwx swizzling.
        /// </summary>
        public decvec5 zyxwx => new decvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.bgrar swizzling (equivalent to decvec4.zyxwx).
        /// </summary>
        public decvec5 bgrar => new decvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.zyxwy swizzling.
        /// </summary>
        public decvec5 zyxwy => new decvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.bgrag swizzling (equivalent to decvec4.zyxwy).
        /// </summary>
        public decvec5 bgrag => new decvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.zyxwz swizzling.
        /// </summary>
        public decvec5 zyxwz => new decvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.bgrab swizzling (equivalent to decvec4.zyxwz).
        /// </summary>
        public decvec5 bgrab => new decvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.zyxww swizzling.
        /// </summary>
        public decvec5 zyxww => new decvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.bgraa swizzling (equivalent to decvec4.zyxww).
        /// </summary>
        public decvec5 bgraa => new decvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.zyy swizzling.
        /// </summary>
        public decvec3 zyy => new decvec3(z, y, y);
        
        /// <summary>
        /// Returns decvec4.bgg swizzling (equivalent to decvec4.zyy).
        /// </summary>
        public decvec3 bgg => new decvec3(z, y, y);
        
        /// <summary>
        /// Returns decvec4.zyyx swizzling.
        /// </summary>
        public decvec4 zyyx => new decvec4(z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.bggr swizzling (equivalent to decvec4.zyyx).
        /// </summary>
        public decvec4 bggr => new decvec4(z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.zyyxx swizzling.
        /// </summary>
        public decvec5 zyyxx => new decvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.bggrr swizzling (equivalent to decvec4.zyyxx).
        /// </summary>
        public decvec5 bggrr => new decvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.zyyxy swizzling.
        /// </summary>
        public decvec5 zyyxy => new decvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.bggrg swizzling (equivalent to decvec4.zyyxy).
        /// </summary>
        public decvec5 bggrg => new decvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.zyyxz swizzling.
        /// </summary>
        public decvec5 zyyxz => new decvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.bggrb swizzling (equivalent to decvec4.zyyxz).
        /// </summary>
        public decvec5 bggrb => new decvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.zyyxw swizzling.
        /// </summary>
        public decvec5 zyyxw => new decvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.bggra swizzling (equivalent to decvec4.zyyxw).
        /// </summary>
        public decvec5 bggra => new decvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.zyyy swizzling.
        /// </summary>
        public decvec4 zyyy => new decvec4(z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.bggg swizzling (equivalent to decvec4.zyyy).
        /// </summary>
        public decvec4 bggg => new decvec4(z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.zyyyx swizzling.
        /// </summary>
        public decvec5 zyyyx => new decvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.bgggr swizzling (equivalent to decvec4.zyyyx).
        /// </summary>
        public decvec5 bgggr => new decvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.zyyyy swizzling.
        /// </summary>
        public decvec5 zyyyy => new decvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.bgggg swizzling (equivalent to decvec4.zyyyy).
        /// </summary>
        public decvec5 bgggg => new decvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.zyyyz swizzling.
        /// </summary>
        public decvec5 zyyyz => new decvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.bgggb swizzling (equivalent to decvec4.zyyyz).
        /// </summary>
        public decvec5 bgggb => new decvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.zyyyw swizzling.
        /// </summary>
        public decvec5 zyyyw => new decvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.bggga swizzling (equivalent to decvec4.zyyyw).
        /// </summary>
        public decvec5 bggga => new decvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.zyyz swizzling.
        /// </summary>
        public decvec4 zyyz => new decvec4(z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.bggb swizzling (equivalent to decvec4.zyyz).
        /// </summary>
        public decvec4 bggb => new decvec4(z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.zyyzx swizzling.
        /// </summary>
        public decvec5 zyyzx => new decvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.bggbr swizzling (equivalent to decvec4.zyyzx).
        /// </summary>
        public decvec5 bggbr => new decvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.zyyzy swizzling.
        /// </summary>
        public decvec5 zyyzy => new decvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.bggbg swizzling (equivalent to decvec4.zyyzy).
        /// </summary>
        public decvec5 bggbg => new decvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.zyyzz swizzling.
        /// </summary>
        public decvec5 zyyzz => new decvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.bggbb swizzling (equivalent to decvec4.zyyzz).
        /// </summary>
        public decvec5 bggbb => new decvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.zyyzw swizzling.
        /// </summary>
        public decvec5 zyyzw => new decvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.bggba swizzling (equivalent to decvec4.zyyzw).
        /// </summary>
        public decvec5 bggba => new decvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.zyyw swizzling.
        /// </summary>
        public decvec4 zyyw => new decvec4(z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.bgga swizzling (equivalent to decvec4.zyyw).
        /// </summary>
        public decvec4 bgga => new decvec4(z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.zyywx swizzling.
        /// </summary>
        public decvec5 zyywx => new decvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.bggar swizzling (equivalent to decvec4.zyywx).
        /// </summary>
        public decvec5 bggar => new decvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.zyywy swizzling.
        /// </summary>
        public decvec5 zyywy => new decvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.bggag swizzling (equivalent to decvec4.zyywy).
        /// </summary>
        public decvec5 bggag => new decvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.zyywz swizzling.
        /// </summary>
        public decvec5 zyywz => new decvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.bggab swizzling (equivalent to decvec4.zyywz).
        /// </summary>
        public decvec5 bggab => new decvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.zyyww swizzling.
        /// </summary>
        public decvec5 zyyww => new decvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.bggaa swizzling (equivalent to decvec4.zyyww).
        /// </summary>
        public decvec5 bggaa => new decvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.zyz swizzling.
        /// </summary>
        public decvec3 zyz => new decvec3(z, y, z);
        
        /// <summary>
        /// Returns decvec4.bgb swizzling (equivalent to decvec4.zyz).
        /// </summary>
        public decvec3 bgb => new decvec3(z, y, z);
        
        /// <summary>
        /// Returns decvec4.zyzx swizzling.
        /// </summary>
        public decvec4 zyzx => new decvec4(z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.bgbr swizzling (equivalent to decvec4.zyzx).
        /// </summary>
        public decvec4 bgbr => new decvec4(z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.zyzxx swizzling.
        /// </summary>
        public decvec5 zyzxx => new decvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.bgbrr swizzling (equivalent to decvec4.zyzxx).
        /// </summary>
        public decvec5 bgbrr => new decvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.zyzxy swizzling.
        /// </summary>
        public decvec5 zyzxy => new decvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.bgbrg swizzling (equivalent to decvec4.zyzxy).
        /// </summary>
        public decvec5 bgbrg => new decvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.zyzxz swizzling.
        /// </summary>
        public decvec5 zyzxz => new decvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.bgbrb swizzling (equivalent to decvec4.zyzxz).
        /// </summary>
        public decvec5 bgbrb => new decvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.zyzxw swizzling.
        /// </summary>
        public decvec5 zyzxw => new decvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.bgbra swizzling (equivalent to decvec4.zyzxw).
        /// </summary>
        public decvec5 bgbra => new decvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.zyzy swizzling.
        /// </summary>
        public decvec4 zyzy => new decvec4(z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.bgbg swizzling (equivalent to decvec4.zyzy).
        /// </summary>
        public decvec4 bgbg => new decvec4(z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.zyzyx swizzling.
        /// </summary>
        public decvec5 zyzyx => new decvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.bgbgr swizzling (equivalent to decvec4.zyzyx).
        /// </summary>
        public decvec5 bgbgr => new decvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.zyzyy swizzling.
        /// </summary>
        public decvec5 zyzyy => new decvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.bgbgg swizzling (equivalent to decvec4.zyzyy).
        /// </summary>
        public decvec5 bgbgg => new decvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.zyzyz swizzling.
        /// </summary>
        public decvec5 zyzyz => new decvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.bgbgb swizzling (equivalent to decvec4.zyzyz).
        /// </summary>
        public decvec5 bgbgb => new decvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.zyzyw swizzling.
        /// </summary>
        public decvec5 zyzyw => new decvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.bgbga swizzling (equivalent to decvec4.zyzyw).
        /// </summary>
        public decvec5 bgbga => new decvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.zyzz swizzling.
        /// </summary>
        public decvec4 zyzz => new decvec4(z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.bgbb swizzling (equivalent to decvec4.zyzz).
        /// </summary>
        public decvec4 bgbb => new decvec4(z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.zyzzx swizzling.
        /// </summary>
        public decvec5 zyzzx => new decvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.bgbbr swizzling (equivalent to decvec4.zyzzx).
        /// </summary>
        public decvec5 bgbbr => new decvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.zyzzy swizzling.
        /// </summary>
        public decvec5 zyzzy => new decvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.bgbbg swizzling (equivalent to decvec4.zyzzy).
        /// </summary>
        public decvec5 bgbbg => new decvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.zyzzz swizzling.
        /// </summary>
        public decvec5 zyzzz => new decvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.bgbbb swizzling (equivalent to decvec4.zyzzz).
        /// </summary>
        public decvec5 bgbbb => new decvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.zyzzw swizzling.
        /// </summary>
        public decvec5 zyzzw => new decvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.bgbba swizzling (equivalent to decvec4.zyzzw).
        /// </summary>
        public decvec5 bgbba => new decvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.zyzw swizzling.
        /// </summary>
        public decvec4 zyzw => new decvec4(z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.bgba swizzling (equivalent to decvec4.zyzw).
        /// </summary>
        public decvec4 bgba => new decvec4(z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.zyzwx swizzling.
        /// </summary>
        public decvec5 zyzwx => new decvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.bgbar swizzling (equivalent to decvec4.zyzwx).
        /// </summary>
        public decvec5 bgbar => new decvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.zyzwy swizzling.
        /// </summary>
        public decvec5 zyzwy => new decvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.bgbag swizzling (equivalent to decvec4.zyzwy).
        /// </summary>
        public decvec5 bgbag => new decvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.zyzwz swizzling.
        /// </summary>
        public decvec5 zyzwz => new decvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.bgbab swizzling (equivalent to decvec4.zyzwz).
        /// </summary>
        public decvec5 bgbab => new decvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.zyzww swizzling.
        /// </summary>
        public decvec5 zyzww => new decvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.bgbaa swizzling (equivalent to decvec4.zyzww).
        /// </summary>
        public decvec5 bgbaa => new decvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.zyw swizzling.
        /// </summary>
        public decvec3 zyw => new decvec3(z, y, w);
        
        /// <summary>
        /// Returns decvec4.bga swizzling (equivalent to decvec4.zyw).
        /// </summary>
        public decvec3 bga => new decvec3(z, y, w);
        
        /// <summary>
        /// Returns decvec4.zywx swizzling.
        /// </summary>
        public decvec4 zywx => new decvec4(z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.bgar swizzling (equivalent to decvec4.zywx).
        /// </summary>
        public decvec4 bgar => new decvec4(z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.zywxx swizzling.
        /// </summary>
        public decvec5 zywxx => new decvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.bgarr swizzling (equivalent to decvec4.zywxx).
        /// </summary>
        public decvec5 bgarr => new decvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.zywxy swizzling.
        /// </summary>
        public decvec5 zywxy => new decvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.bgarg swizzling (equivalent to decvec4.zywxy).
        /// </summary>
        public decvec5 bgarg => new decvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.zywxz swizzling.
        /// </summary>
        public decvec5 zywxz => new decvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.bgarb swizzling (equivalent to decvec4.zywxz).
        /// </summary>
        public decvec5 bgarb => new decvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.zywxw swizzling.
        /// </summary>
        public decvec5 zywxw => new decvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.bgara swizzling (equivalent to decvec4.zywxw).
        /// </summary>
        public decvec5 bgara => new decvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.zywy swizzling.
        /// </summary>
        public decvec4 zywy => new decvec4(z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.bgag swizzling (equivalent to decvec4.zywy).
        /// </summary>
        public decvec4 bgag => new decvec4(z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.zywyx swizzling.
        /// </summary>
        public decvec5 zywyx => new decvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.bgagr swizzling (equivalent to decvec4.zywyx).
        /// </summary>
        public decvec5 bgagr => new decvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.zywyy swizzling.
        /// </summary>
        public decvec5 zywyy => new decvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.bgagg swizzling (equivalent to decvec4.zywyy).
        /// </summary>
        public decvec5 bgagg => new decvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.zywyz swizzling.
        /// </summary>
        public decvec5 zywyz => new decvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.bgagb swizzling (equivalent to decvec4.zywyz).
        /// </summary>
        public decvec5 bgagb => new decvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.zywyw swizzling.
        /// </summary>
        public decvec5 zywyw => new decvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.bgaga swizzling (equivalent to decvec4.zywyw).
        /// </summary>
        public decvec5 bgaga => new decvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.zywz swizzling.
        /// </summary>
        public decvec4 zywz => new decvec4(z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.bgab swizzling (equivalent to decvec4.zywz).
        /// </summary>
        public decvec4 bgab => new decvec4(z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.zywzx swizzling.
        /// </summary>
        public decvec5 zywzx => new decvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.bgabr swizzling (equivalent to decvec4.zywzx).
        /// </summary>
        public decvec5 bgabr => new decvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.zywzy swizzling.
        /// </summary>
        public decvec5 zywzy => new decvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.bgabg swizzling (equivalent to decvec4.zywzy).
        /// </summary>
        public decvec5 bgabg => new decvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.zywzz swizzling.
        /// </summary>
        public decvec5 zywzz => new decvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.bgabb swizzling (equivalent to decvec4.zywzz).
        /// </summary>
        public decvec5 bgabb => new decvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.zywzw swizzling.
        /// </summary>
        public decvec5 zywzw => new decvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.bgaba swizzling (equivalent to decvec4.zywzw).
        /// </summary>
        public decvec5 bgaba => new decvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.zyww swizzling.
        /// </summary>
        public decvec4 zyww => new decvec4(z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.bgaa swizzling (equivalent to decvec4.zyww).
        /// </summary>
        public decvec4 bgaa => new decvec4(z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.zywwx swizzling.
        /// </summary>
        public decvec5 zywwx => new decvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.bgaar swizzling (equivalent to decvec4.zywwx).
        /// </summary>
        public decvec5 bgaar => new decvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.zywwy swizzling.
        /// </summary>
        public decvec5 zywwy => new decvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.bgaag swizzling (equivalent to decvec4.zywwy).
        /// </summary>
        public decvec5 bgaag => new decvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.zywwz swizzling.
        /// </summary>
        public decvec5 zywwz => new decvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.bgaab swizzling (equivalent to decvec4.zywwz).
        /// </summary>
        public decvec5 bgaab => new decvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.zywww swizzling.
        /// </summary>
        public decvec5 zywww => new decvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.bgaaa swizzling (equivalent to decvec4.zywww).
        /// </summary>
        public decvec5 bgaaa => new decvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.zz swizzling.
        /// </summary>
        public decvec2 zz => new decvec2(z, z);
        
        /// <summary>
        /// Returns decvec4.bb swizzling (equivalent to decvec4.zz).
        /// </summary>
        public decvec2 bb => new decvec2(z, z);
        
        /// <summary>
        /// Returns decvec4.zzx swizzling.
        /// </summary>
        public decvec3 zzx => new decvec3(z, z, x);
        
        /// <summary>
        /// Returns decvec4.bbr swizzling (equivalent to decvec4.zzx).
        /// </summary>
        public decvec3 bbr => new decvec3(z, z, x);
        
        /// <summary>
        /// Returns decvec4.zzxx swizzling.
        /// </summary>
        public decvec4 zzxx => new decvec4(z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.bbrr swizzling (equivalent to decvec4.zzxx).
        /// </summary>
        public decvec4 bbrr => new decvec4(z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.zzxxx swizzling.
        /// </summary>
        public decvec5 zzxxx => new decvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.bbrrr swizzling (equivalent to decvec4.zzxxx).
        /// </summary>
        public decvec5 bbrrr => new decvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.zzxxy swizzling.
        /// </summary>
        public decvec5 zzxxy => new decvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.bbrrg swizzling (equivalent to decvec4.zzxxy).
        /// </summary>
        public decvec5 bbrrg => new decvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.zzxxz swizzling.
        /// </summary>
        public decvec5 zzxxz => new decvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.bbrrb swizzling (equivalent to decvec4.zzxxz).
        /// </summary>
        public decvec5 bbrrb => new decvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.zzxxw swizzling.
        /// </summary>
        public decvec5 zzxxw => new decvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.bbrra swizzling (equivalent to decvec4.zzxxw).
        /// </summary>
        public decvec5 bbrra => new decvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.zzxy swizzling.
        /// </summary>
        public decvec4 zzxy => new decvec4(z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.bbrg swizzling (equivalent to decvec4.zzxy).
        /// </summary>
        public decvec4 bbrg => new decvec4(z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.zzxyx swizzling.
        /// </summary>
        public decvec5 zzxyx => new decvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.bbrgr swizzling (equivalent to decvec4.zzxyx).
        /// </summary>
        public decvec5 bbrgr => new decvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.zzxyy swizzling.
        /// </summary>
        public decvec5 zzxyy => new decvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.bbrgg swizzling (equivalent to decvec4.zzxyy).
        /// </summary>
        public decvec5 bbrgg => new decvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.zzxyz swizzling.
        /// </summary>
        public decvec5 zzxyz => new decvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.bbrgb swizzling (equivalent to decvec4.zzxyz).
        /// </summary>
        public decvec5 bbrgb => new decvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.zzxyw swizzling.
        /// </summary>
        public decvec5 zzxyw => new decvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.bbrga swizzling (equivalent to decvec4.zzxyw).
        /// </summary>
        public decvec5 bbrga => new decvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.zzxz swizzling.
        /// </summary>
        public decvec4 zzxz => new decvec4(z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.bbrb swizzling (equivalent to decvec4.zzxz).
        /// </summary>
        public decvec4 bbrb => new decvec4(z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.zzxzx swizzling.
        /// </summary>
        public decvec5 zzxzx => new decvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.bbrbr swizzling (equivalent to decvec4.zzxzx).
        /// </summary>
        public decvec5 bbrbr => new decvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.zzxzy swizzling.
        /// </summary>
        public decvec5 zzxzy => new decvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.bbrbg swizzling (equivalent to decvec4.zzxzy).
        /// </summary>
        public decvec5 bbrbg => new decvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.zzxzz swizzling.
        /// </summary>
        public decvec5 zzxzz => new decvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.bbrbb swizzling (equivalent to decvec4.zzxzz).
        /// </summary>
        public decvec5 bbrbb => new decvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.zzxzw swizzling.
        /// </summary>
        public decvec5 zzxzw => new decvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.bbrba swizzling (equivalent to decvec4.zzxzw).
        /// </summary>
        public decvec5 bbrba => new decvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.zzxw swizzling.
        /// </summary>
        public decvec4 zzxw => new decvec4(z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.bbra swizzling (equivalent to decvec4.zzxw).
        /// </summary>
        public decvec4 bbra => new decvec4(z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.zzxwx swizzling.
        /// </summary>
        public decvec5 zzxwx => new decvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.bbrar swizzling (equivalent to decvec4.zzxwx).
        /// </summary>
        public decvec5 bbrar => new decvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.zzxwy swizzling.
        /// </summary>
        public decvec5 zzxwy => new decvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.bbrag swizzling (equivalent to decvec4.zzxwy).
        /// </summary>
        public decvec5 bbrag => new decvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.zzxwz swizzling.
        /// </summary>
        public decvec5 zzxwz => new decvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.bbrab swizzling (equivalent to decvec4.zzxwz).
        /// </summary>
        public decvec5 bbrab => new decvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.zzxww swizzling.
        /// </summary>
        public decvec5 zzxww => new decvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.bbraa swizzling (equivalent to decvec4.zzxww).
        /// </summary>
        public decvec5 bbraa => new decvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.zzy swizzling.
        /// </summary>
        public decvec3 zzy => new decvec3(z, z, y);
        
        /// <summary>
        /// Returns decvec4.bbg swizzling (equivalent to decvec4.zzy).
        /// </summary>
        public decvec3 bbg => new decvec3(z, z, y);
        
        /// <summary>
        /// Returns decvec4.zzyx swizzling.
        /// </summary>
        public decvec4 zzyx => new decvec4(z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.bbgr swizzling (equivalent to decvec4.zzyx).
        /// </summary>
        public decvec4 bbgr => new decvec4(z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.zzyxx swizzling.
        /// </summary>
        public decvec5 zzyxx => new decvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.bbgrr swizzling (equivalent to decvec4.zzyxx).
        /// </summary>
        public decvec5 bbgrr => new decvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.zzyxy swizzling.
        /// </summary>
        public decvec5 zzyxy => new decvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.bbgrg swizzling (equivalent to decvec4.zzyxy).
        /// </summary>
        public decvec5 bbgrg => new decvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.zzyxz swizzling.
        /// </summary>
        public decvec5 zzyxz => new decvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.bbgrb swizzling (equivalent to decvec4.zzyxz).
        /// </summary>
        public decvec5 bbgrb => new decvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.zzyxw swizzling.
        /// </summary>
        public decvec5 zzyxw => new decvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.bbgra swizzling (equivalent to decvec4.zzyxw).
        /// </summary>
        public decvec5 bbgra => new decvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.zzyy swizzling.
        /// </summary>
        public decvec4 zzyy => new decvec4(z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.bbgg swizzling (equivalent to decvec4.zzyy).
        /// </summary>
        public decvec4 bbgg => new decvec4(z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.zzyyx swizzling.
        /// </summary>
        public decvec5 zzyyx => new decvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.bbggr swizzling (equivalent to decvec4.zzyyx).
        /// </summary>
        public decvec5 bbggr => new decvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.zzyyy swizzling.
        /// </summary>
        public decvec5 zzyyy => new decvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.bbggg swizzling (equivalent to decvec4.zzyyy).
        /// </summary>
        public decvec5 bbggg => new decvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.zzyyz swizzling.
        /// </summary>
        public decvec5 zzyyz => new decvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.bbggb swizzling (equivalent to decvec4.zzyyz).
        /// </summary>
        public decvec5 bbggb => new decvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.zzyyw swizzling.
        /// </summary>
        public decvec5 zzyyw => new decvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.bbgga swizzling (equivalent to decvec4.zzyyw).
        /// </summary>
        public decvec5 bbgga => new decvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.zzyz swizzling.
        /// </summary>
        public decvec4 zzyz => new decvec4(z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.bbgb swizzling (equivalent to decvec4.zzyz).
        /// </summary>
        public decvec4 bbgb => new decvec4(z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.zzyzx swizzling.
        /// </summary>
        public decvec5 zzyzx => new decvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.bbgbr swizzling (equivalent to decvec4.zzyzx).
        /// </summary>
        public decvec5 bbgbr => new decvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.zzyzy swizzling.
        /// </summary>
        public decvec5 zzyzy => new decvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.bbgbg swizzling (equivalent to decvec4.zzyzy).
        /// </summary>
        public decvec5 bbgbg => new decvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.zzyzz swizzling.
        /// </summary>
        public decvec5 zzyzz => new decvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.bbgbb swizzling (equivalent to decvec4.zzyzz).
        /// </summary>
        public decvec5 bbgbb => new decvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.zzyzw swizzling.
        /// </summary>
        public decvec5 zzyzw => new decvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.bbgba swizzling (equivalent to decvec4.zzyzw).
        /// </summary>
        public decvec5 bbgba => new decvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.zzyw swizzling.
        /// </summary>
        public decvec4 zzyw => new decvec4(z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.bbga swizzling (equivalent to decvec4.zzyw).
        /// </summary>
        public decvec4 bbga => new decvec4(z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.zzywx swizzling.
        /// </summary>
        public decvec5 zzywx => new decvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.bbgar swizzling (equivalent to decvec4.zzywx).
        /// </summary>
        public decvec5 bbgar => new decvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.zzywy swizzling.
        /// </summary>
        public decvec5 zzywy => new decvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.bbgag swizzling (equivalent to decvec4.zzywy).
        /// </summary>
        public decvec5 bbgag => new decvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.zzywz swizzling.
        /// </summary>
        public decvec5 zzywz => new decvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.bbgab swizzling (equivalent to decvec4.zzywz).
        /// </summary>
        public decvec5 bbgab => new decvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.zzyww swizzling.
        /// </summary>
        public decvec5 zzyww => new decvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.bbgaa swizzling (equivalent to decvec4.zzyww).
        /// </summary>
        public decvec5 bbgaa => new decvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.zzz swizzling.
        /// </summary>
        public decvec3 zzz => new decvec3(z, z, z);
        
        /// <summary>
        /// Returns decvec4.bbb swizzling (equivalent to decvec4.zzz).
        /// </summary>
        public decvec3 bbb => new decvec3(z, z, z);
        
        /// <summary>
        /// Returns decvec4.zzzx swizzling.
        /// </summary>
        public decvec4 zzzx => new decvec4(z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.bbbr swizzling (equivalent to decvec4.zzzx).
        /// </summary>
        public decvec4 bbbr => new decvec4(z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.zzzxx swizzling.
        /// </summary>
        public decvec5 zzzxx => new decvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.bbbrr swizzling (equivalent to decvec4.zzzxx).
        /// </summary>
        public decvec5 bbbrr => new decvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.zzzxy swizzling.
        /// </summary>
        public decvec5 zzzxy => new decvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.bbbrg swizzling (equivalent to decvec4.zzzxy).
        /// </summary>
        public decvec5 bbbrg => new decvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.zzzxz swizzling.
        /// </summary>
        public decvec5 zzzxz => new decvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.bbbrb swizzling (equivalent to decvec4.zzzxz).
        /// </summary>
        public decvec5 bbbrb => new decvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.zzzxw swizzling.
        /// </summary>
        public decvec5 zzzxw => new decvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.bbbra swizzling (equivalent to decvec4.zzzxw).
        /// </summary>
        public decvec5 bbbra => new decvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.zzzy swizzling.
        /// </summary>
        public decvec4 zzzy => new decvec4(z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.bbbg swizzling (equivalent to decvec4.zzzy).
        /// </summary>
        public decvec4 bbbg => new decvec4(z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.zzzyx swizzling.
        /// </summary>
        public decvec5 zzzyx => new decvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.bbbgr swizzling (equivalent to decvec4.zzzyx).
        /// </summary>
        public decvec5 bbbgr => new decvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.zzzyy swizzling.
        /// </summary>
        public decvec5 zzzyy => new decvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.bbbgg swizzling (equivalent to decvec4.zzzyy).
        /// </summary>
        public decvec5 bbbgg => new decvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.zzzyz swizzling.
        /// </summary>
        public decvec5 zzzyz => new decvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.bbbgb swizzling (equivalent to decvec4.zzzyz).
        /// </summary>
        public decvec5 bbbgb => new decvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.zzzyw swizzling.
        /// </summary>
        public decvec5 zzzyw => new decvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.bbbga swizzling (equivalent to decvec4.zzzyw).
        /// </summary>
        public decvec5 bbbga => new decvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.zzzz swizzling.
        /// </summary>
        public decvec4 zzzz => new decvec4(z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.bbbb swizzling (equivalent to decvec4.zzzz).
        /// </summary>
        public decvec4 bbbb => new decvec4(z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.zzzzx swizzling.
        /// </summary>
        public decvec5 zzzzx => new decvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.bbbbr swizzling (equivalent to decvec4.zzzzx).
        /// </summary>
        public decvec5 bbbbr => new decvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.zzzzy swizzling.
        /// </summary>
        public decvec5 zzzzy => new decvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.bbbbg swizzling (equivalent to decvec4.zzzzy).
        /// </summary>
        public decvec5 bbbbg => new decvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.zzzzz swizzling.
        /// </summary>
        public decvec5 zzzzz => new decvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.bbbbb swizzling (equivalent to decvec4.zzzzz).
        /// </summary>
        public decvec5 bbbbb => new decvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.zzzzw swizzling.
        /// </summary>
        public decvec5 zzzzw => new decvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.bbbba swizzling (equivalent to decvec4.zzzzw).
        /// </summary>
        public decvec5 bbbba => new decvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.zzzw swizzling.
        /// </summary>
        public decvec4 zzzw => new decvec4(z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.bbba swizzling (equivalent to decvec4.zzzw).
        /// </summary>
        public decvec4 bbba => new decvec4(z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.zzzwx swizzling.
        /// </summary>
        public decvec5 zzzwx => new decvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.bbbar swizzling (equivalent to decvec4.zzzwx).
        /// </summary>
        public decvec5 bbbar => new decvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.zzzwy swizzling.
        /// </summary>
        public decvec5 zzzwy => new decvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.bbbag swizzling (equivalent to decvec4.zzzwy).
        /// </summary>
        public decvec5 bbbag => new decvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.zzzwz swizzling.
        /// </summary>
        public decvec5 zzzwz => new decvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.bbbab swizzling (equivalent to decvec4.zzzwz).
        /// </summary>
        public decvec5 bbbab => new decvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.zzzww swizzling.
        /// </summary>
        public decvec5 zzzww => new decvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.bbbaa swizzling (equivalent to decvec4.zzzww).
        /// </summary>
        public decvec5 bbbaa => new decvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.zzw swizzling.
        /// </summary>
        public decvec3 zzw => new decvec3(z, z, w);
        
        /// <summary>
        /// Returns decvec4.bba swizzling (equivalent to decvec4.zzw).
        /// </summary>
        public decvec3 bba => new decvec3(z, z, w);
        
        /// <summary>
        /// Returns decvec4.zzwx swizzling.
        /// </summary>
        public decvec4 zzwx => new decvec4(z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.bbar swizzling (equivalent to decvec4.zzwx).
        /// </summary>
        public decvec4 bbar => new decvec4(z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.zzwxx swizzling.
        /// </summary>
        public decvec5 zzwxx => new decvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.bbarr swizzling (equivalent to decvec4.zzwxx).
        /// </summary>
        public decvec5 bbarr => new decvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.zzwxy swizzling.
        /// </summary>
        public decvec5 zzwxy => new decvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.bbarg swizzling (equivalent to decvec4.zzwxy).
        /// </summary>
        public decvec5 bbarg => new decvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.zzwxz swizzling.
        /// </summary>
        public decvec5 zzwxz => new decvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.bbarb swizzling (equivalent to decvec4.zzwxz).
        /// </summary>
        public decvec5 bbarb => new decvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.zzwxw swizzling.
        /// </summary>
        public decvec5 zzwxw => new decvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.bbara swizzling (equivalent to decvec4.zzwxw).
        /// </summary>
        public decvec5 bbara => new decvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.zzwy swizzling.
        /// </summary>
        public decvec4 zzwy => new decvec4(z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.bbag swizzling (equivalent to decvec4.zzwy).
        /// </summary>
        public decvec4 bbag => new decvec4(z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.zzwyx swizzling.
        /// </summary>
        public decvec5 zzwyx => new decvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.bbagr swizzling (equivalent to decvec4.zzwyx).
        /// </summary>
        public decvec5 bbagr => new decvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.zzwyy swizzling.
        /// </summary>
        public decvec5 zzwyy => new decvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.bbagg swizzling (equivalent to decvec4.zzwyy).
        /// </summary>
        public decvec5 bbagg => new decvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.zzwyz swizzling.
        /// </summary>
        public decvec5 zzwyz => new decvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.bbagb swizzling (equivalent to decvec4.zzwyz).
        /// </summary>
        public decvec5 bbagb => new decvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.zzwyw swizzling.
        /// </summary>
        public decvec5 zzwyw => new decvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.bbaga swizzling (equivalent to decvec4.zzwyw).
        /// </summary>
        public decvec5 bbaga => new decvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.zzwz swizzling.
        /// </summary>
        public decvec4 zzwz => new decvec4(z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.bbab swizzling (equivalent to decvec4.zzwz).
        /// </summary>
        public decvec4 bbab => new decvec4(z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.zzwzx swizzling.
        /// </summary>
        public decvec5 zzwzx => new decvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.bbabr swizzling (equivalent to decvec4.zzwzx).
        /// </summary>
        public decvec5 bbabr => new decvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.zzwzy swizzling.
        /// </summary>
        public decvec5 zzwzy => new decvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.bbabg swizzling (equivalent to decvec4.zzwzy).
        /// </summary>
        public decvec5 bbabg => new decvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.zzwzz swizzling.
        /// </summary>
        public decvec5 zzwzz => new decvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.bbabb swizzling (equivalent to decvec4.zzwzz).
        /// </summary>
        public decvec5 bbabb => new decvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.zzwzw swizzling.
        /// </summary>
        public decvec5 zzwzw => new decvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.bbaba swizzling (equivalent to decvec4.zzwzw).
        /// </summary>
        public decvec5 bbaba => new decvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.zzww swizzling.
        /// </summary>
        public decvec4 zzww => new decvec4(z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.bbaa swizzling (equivalent to decvec4.zzww).
        /// </summary>
        public decvec4 bbaa => new decvec4(z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.zzwwx swizzling.
        /// </summary>
        public decvec5 zzwwx => new decvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.bbaar swizzling (equivalent to decvec4.zzwwx).
        /// </summary>
        public decvec5 bbaar => new decvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.zzwwy swizzling.
        /// </summary>
        public decvec5 zzwwy => new decvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.bbaag swizzling (equivalent to decvec4.zzwwy).
        /// </summary>
        public decvec5 bbaag => new decvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.zzwwz swizzling.
        /// </summary>
        public decvec5 zzwwz => new decvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.bbaab swizzling (equivalent to decvec4.zzwwz).
        /// </summary>
        public decvec5 bbaab => new decvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.zzwww swizzling.
        /// </summary>
        public decvec5 zzwww => new decvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.bbaaa swizzling (equivalent to decvec4.zzwww).
        /// </summary>
        public decvec5 bbaaa => new decvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.zw swizzling.
        /// </summary>
        public decvec2 zw => new decvec2(z, w);
        
        /// <summary>
        /// Returns decvec4.ba swizzling (equivalent to decvec4.zw).
        /// </summary>
        public decvec2 ba => new decvec2(z, w);
        
        /// <summary>
        /// Returns decvec4.zwx swizzling.
        /// </summary>
        public decvec3 zwx => new decvec3(z, w, x);
        
        /// <summary>
        /// Returns decvec4.bar swizzling (equivalent to decvec4.zwx).
        /// </summary>
        public decvec3 bar => new decvec3(z, w, x);
        
        /// <summary>
        /// Returns decvec4.zwxx swizzling.
        /// </summary>
        public decvec4 zwxx => new decvec4(z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.barr swizzling (equivalent to decvec4.zwxx).
        /// </summary>
        public decvec4 barr => new decvec4(z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.zwxxx swizzling.
        /// </summary>
        public decvec5 zwxxx => new decvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.barrr swizzling (equivalent to decvec4.zwxxx).
        /// </summary>
        public decvec5 barrr => new decvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.zwxxy swizzling.
        /// </summary>
        public decvec5 zwxxy => new decvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.barrg swizzling (equivalent to decvec4.zwxxy).
        /// </summary>
        public decvec5 barrg => new decvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.zwxxz swizzling.
        /// </summary>
        public decvec5 zwxxz => new decvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.barrb swizzling (equivalent to decvec4.zwxxz).
        /// </summary>
        public decvec5 barrb => new decvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.zwxxw swizzling.
        /// </summary>
        public decvec5 zwxxw => new decvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.barra swizzling (equivalent to decvec4.zwxxw).
        /// </summary>
        public decvec5 barra => new decvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.zwxy swizzling.
        /// </summary>
        public decvec4 zwxy => new decvec4(z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.barg swizzling (equivalent to decvec4.zwxy).
        /// </summary>
        public decvec4 barg => new decvec4(z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.zwxyx swizzling.
        /// </summary>
        public decvec5 zwxyx => new decvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.bargr swizzling (equivalent to decvec4.zwxyx).
        /// </summary>
        public decvec5 bargr => new decvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.zwxyy swizzling.
        /// </summary>
        public decvec5 zwxyy => new decvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.bargg swizzling (equivalent to decvec4.zwxyy).
        /// </summary>
        public decvec5 bargg => new decvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.zwxyz swizzling.
        /// </summary>
        public decvec5 zwxyz => new decvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.bargb swizzling (equivalent to decvec4.zwxyz).
        /// </summary>
        public decvec5 bargb => new decvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.zwxyw swizzling.
        /// </summary>
        public decvec5 zwxyw => new decvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.barga swizzling (equivalent to decvec4.zwxyw).
        /// </summary>
        public decvec5 barga => new decvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.zwxz swizzling.
        /// </summary>
        public decvec4 zwxz => new decvec4(z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.barb swizzling (equivalent to decvec4.zwxz).
        /// </summary>
        public decvec4 barb => new decvec4(z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.zwxzx swizzling.
        /// </summary>
        public decvec5 zwxzx => new decvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.barbr swizzling (equivalent to decvec4.zwxzx).
        /// </summary>
        public decvec5 barbr => new decvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.zwxzy swizzling.
        /// </summary>
        public decvec5 zwxzy => new decvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.barbg swizzling (equivalent to decvec4.zwxzy).
        /// </summary>
        public decvec5 barbg => new decvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.zwxzz swizzling.
        /// </summary>
        public decvec5 zwxzz => new decvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.barbb swizzling (equivalent to decvec4.zwxzz).
        /// </summary>
        public decvec5 barbb => new decvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.zwxzw swizzling.
        /// </summary>
        public decvec5 zwxzw => new decvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.barba swizzling (equivalent to decvec4.zwxzw).
        /// </summary>
        public decvec5 barba => new decvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.zwxw swizzling.
        /// </summary>
        public decvec4 zwxw => new decvec4(z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.bara swizzling (equivalent to decvec4.zwxw).
        /// </summary>
        public decvec4 bara => new decvec4(z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.zwxwx swizzling.
        /// </summary>
        public decvec5 zwxwx => new decvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.barar swizzling (equivalent to decvec4.zwxwx).
        /// </summary>
        public decvec5 barar => new decvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.zwxwy swizzling.
        /// </summary>
        public decvec5 zwxwy => new decvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.barag swizzling (equivalent to decvec4.zwxwy).
        /// </summary>
        public decvec5 barag => new decvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.zwxwz swizzling.
        /// </summary>
        public decvec5 zwxwz => new decvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.barab swizzling (equivalent to decvec4.zwxwz).
        /// </summary>
        public decvec5 barab => new decvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.zwxww swizzling.
        /// </summary>
        public decvec5 zwxww => new decvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.baraa swizzling (equivalent to decvec4.zwxww).
        /// </summary>
        public decvec5 baraa => new decvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.zwy swizzling.
        /// </summary>
        public decvec3 zwy => new decvec3(z, w, y);
        
        /// <summary>
        /// Returns decvec4.bag swizzling (equivalent to decvec4.zwy).
        /// </summary>
        public decvec3 bag => new decvec3(z, w, y);
        
        /// <summary>
        /// Returns decvec4.zwyx swizzling.
        /// </summary>
        public decvec4 zwyx => new decvec4(z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.bagr swizzling (equivalent to decvec4.zwyx).
        /// </summary>
        public decvec4 bagr => new decvec4(z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.zwyxx swizzling.
        /// </summary>
        public decvec5 zwyxx => new decvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.bagrr swizzling (equivalent to decvec4.zwyxx).
        /// </summary>
        public decvec5 bagrr => new decvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.zwyxy swizzling.
        /// </summary>
        public decvec5 zwyxy => new decvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.bagrg swizzling (equivalent to decvec4.zwyxy).
        /// </summary>
        public decvec5 bagrg => new decvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.zwyxz swizzling.
        /// </summary>
        public decvec5 zwyxz => new decvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.bagrb swizzling (equivalent to decvec4.zwyxz).
        /// </summary>
        public decvec5 bagrb => new decvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.zwyxw swizzling.
        /// </summary>
        public decvec5 zwyxw => new decvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.bagra swizzling (equivalent to decvec4.zwyxw).
        /// </summary>
        public decvec5 bagra => new decvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.zwyy swizzling.
        /// </summary>
        public decvec4 zwyy => new decvec4(z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.bagg swizzling (equivalent to decvec4.zwyy).
        /// </summary>
        public decvec4 bagg => new decvec4(z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.zwyyx swizzling.
        /// </summary>
        public decvec5 zwyyx => new decvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.baggr swizzling (equivalent to decvec4.zwyyx).
        /// </summary>
        public decvec5 baggr => new decvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.zwyyy swizzling.
        /// </summary>
        public decvec5 zwyyy => new decvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.baggg swizzling (equivalent to decvec4.zwyyy).
        /// </summary>
        public decvec5 baggg => new decvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.zwyyz swizzling.
        /// </summary>
        public decvec5 zwyyz => new decvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.baggb swizzling (equivalent to decvec4.zwyyz).
        /// </summary>
        public decvec5 baggb => new decvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.zwyyw swizzling.
        /// </summary>
        public decvec5 zwyyw => new decvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.bagga swizzling (equivalent to decvec4.zwyyw).
        /// </summary>
        public decvec5 bagga => new decvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.zwyz swizzling.
        /// </summary>
        public decvec4 zwyz => new decvec4(z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.bagb swizzling (equivalent to decvec4.zwyz).
        /// </summary>
        public decvec4 bagb => new decvec4(z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.zwyzx swizzling.
        /// </summary>
        public decvec5 zwyzx => new decvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.bagbr swizzling (equivalent to decvec4.zwyzx).
        /// </summary>
        public decvec5 bagbr => new decvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.zwyzy swizzling.
        /// </summary>
        public decvec5 zwyzy => new decvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.bagbg swizzling (equivalent to decvec4.zwyzy).
        /// </summary>
        public decvec5 bagbg => new decvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.zwyzz swizzling.
        /// </summary>
        public decvec5 zwyzz => new decvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.bagbb swizzling (equivalent to decvec4.zwyzz).
        /// </summary>
        public decvec5 bagbb => new decvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.zwyzw swizzling.
        /// </summary>
        public decvec5 zwyzw => new decvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.bagba swizzling (equivalent to decvec4.zwyzw).
        /// </summary>
        public decvec5 bagba => new decvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.zwyw swizzling.
        /// </summary>
        public decvec4 zwyw => new decvec4(z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.baga swizzling (equivalent to decvec4.zwyw).
        /// </summary>
        public decvec4 baga => new decvec4(z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.zwywx swizzling.
        /// </summary>
        public decvec5 zwywx => new decvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.bagar swizzling (equivalent to decvec4.zwywx).
        /// </summary>
        public decvec5 bagar => new decvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.zwywy swizzling.
        /// </summary>
        public decvec5 zwywy => new decvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.bagag swizzling (equivalent to decvec4.zwywy).
        /// </summary>
        public decvec5 bagag => new decvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.zwywz swizzling.
        /// </summary>
        public decvec5 zwywz => new decvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.bagab swizzling (equivalent to decvec4.zwywz).
        /// </summary>
        public decvec5 bagab => new decvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.zwyww swizzling.
        /// </summary>
        public decvec5 zwyww => new decvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.bagaa swizzling (equivalent to decvec4.zwyww).
        /// </summary>
        public decvec5 bagaa => new decvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.zwz swizzling.
        /// </summary>
        public decvec3 zwz => new decvec3(z, w, z);
        
        /// <summary>
        /// Returns decvec4.bab swizzling (equivalent to decvec4.zwz).
        /// </summary>
        public decvec3 bab => new decvec3(z, w, z);
        
        /// <summary>
        /// Returns decvec4.zwzx swizzling.
        /// </summary>
        public decvec4 zwzx => new decvec4(z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.babr swizzling (equivalent to decvec4.zwzx).
        /// </summary>
        public decvec4 babr => new decvec4(z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.zwzxx swizzling.
        /// </summary>
        public decvec5 zwzxx => new decvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.babrr swizzling (equivalent to decvec4.zwzxx).
        /// </summary>
        public decvec5 babrr => new decvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.zwzxy swizzling.
        /// </summary>
        public decvec5 zwzxy => new decvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.babrg swizzling (equivalent to decvec4.zwzxy).
        /// </summary>
        public decvec5 babrg => new decvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.zwzxz swizzling.
        /// </summary>
        public decvec5 zwzxz => new decvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.babrb swizzling (equivalent to decvec4.zwzxz).
        /// </summary>
        public decvec5 babrb => new decvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.zwzxw swizzling.
        /// </summary>
        public decvec5 zwzxw => new decvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.babra swizzling (equivalent to decvec4.zwzxw).
        /// </summary>
        public decvec5 babra => new decvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.zwzy swizzling.
        /// </summary>
        public decvec4 zwzy => new decvec4(z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.babg swizzling (equivalent to decvec4.zwzy).
        /// </summary>
        public decvec4 babg => new decvec4(z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.zwzyx swizzling.
        /// </summary>
        public decvec5 zwzyx => new decvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.babgr swizzling (equivalent to decvec4.zwzyx).
        /// </summary>
        public decvec5 babgr => new decvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.zwzyy swizzling.
        /// </summary>
        public decvec5 zwzyy => new decvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.babgg swizzling (equivalent to decvec4.zwzyy).
        /// </summary>
        public decvec5 babgg => new decvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.zwzyz swizzling.
        /// </summary>
        public decvec5 zwzyz => new decvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.babgb swizzling (equivalent to decvec4.zwzyz).
        /// </summary>
        public decvec5 babgb => new decvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.zwzyw swizzling.
        /// </summary>
        public decvec5 zwzyw => new decvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.babga swizzling (equivalent to decvec4.zwzyw).
        /// </summary>
        public decvec5 babga => new decvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.zwzz swizzling.
        /// </summary>
        public decvec4 zwzz => new decvec4(z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.babb swizzling (equivalent to decvec4.zwzz).
        /// </summary>
        public decvec4 babb => new decvec4(z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.zwzzx swizzling.
        /// </summary>
        public decvec5 zwzzx => new decvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.babbr swizzling (equivalent to decvec4.zwzzx).
        /// </summary>
        public decvec5 babbr => new decvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.zwzzy swizzling.
        /// </summary>
        public decvec5 zwzzy => new decvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.babbg swizzling (equivalent to decvec4.zwzzy).
        /// </summary>
        public decvec5 babbg => new decvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.zwzzz swizzling.
        /// </summary>
        public decvec5 zwzzz => new decvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.babbb swizzling (equivalent to decvec4.zwzzz).
        /// </summary>
        public decvec5 babbb => new decvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.zwzzw swizzling.
        /// </summary>
        public decvec5 zwzzw => new decvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.babba swizzling (equivalent to decvec4.zwzzw).
        /// </summary>
        public decvec5 babba => new decvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.zwzw swizzling.
        /// </summary>
        public decvec4 zwzw => new decvec4(z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.baba swizzling (equivalent to decvec4.zwzw).
        /// </summary>
        public decvec4 baba => new decvec4(z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.zwzwx swizzling.
        /// </summary>
        public decvec5 zwzwx => new decvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.babar swizzling (equivalent to decvec4.zwzwx).
        /// </summary>
        public decvec5 babar => new decvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.zwzwy swizzling.
        /// </summary>
        public decvec5 zwzwy => new decvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.babag swizzling (equivalent to decvec4.zwzwy).
        /// </summary>
        public decvec5 babag => new decvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.zwzwz swizzling.
        /// </summary>
        public decvec5 zwzwz => new decvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.babab swizzling (equivalent to decvec4.zwzwz).
        /// </summary>
        public decvec5 babab => new decvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.zwzww swizzling.
        /// </summary>
        public decvec5 zwzww => new decvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.babaa swizzling (equivalent to decvec4.zwzww).
        /// </summary>
        public decvec5 babaa => new decvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.zww swizzling.
        /// </summary>
        public decvec3 zww => new decvec3(z, w, w);
        
        /// <summary>
        /// Returns decvec4.baa swizzling (equivalent to decvec4.zww).
        /// </summary>
        public decvec3 baa => new decvec3(z, w, w);
        
        /// <summary>
        /// Returns decvec4.zwwx swizzling.
        /// </summary>
        public decvec4 zwwx => new decvec4(z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.baar swizzling (equivalent to decvec4.zwwx).
        /// </summary>
        public decvec4 baar => new decvec4(z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.zwwxx swizzling.
        /// </summary>
        public decvec5 zwwxx => new decvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.baarr swizzling (equivalent to decvec4.zwwxx).
        /// </summary>
        public decvec5 baarr => new decvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.zwwxy swizzling.
        /// </summary>
        public decvec5 zwwxy => new decvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.baarg swizzling (equivalent to decvec4.zwwxy).
        /// </summary>
        public decvec5 baarg => new decvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.zwwxz swizzling.
        /// </summary>
        public decvec5 zwwxz => new decvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.baarb swizzling (equivalent to decvec4.zwwxz).
        /// </summary>
        public decvec5 baarb => new decvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.zwwxw swizzling.
        /// </summary>
        public decvec5 zwwxw => new decvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.baara swizzling (equivalent to decvec4.zwwxw).
        /// </summary>
        public decvec5 baara => new decvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.zwwy swizzling.
        /// </summary>
        public decvec4 zwwy => new decvec4(z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.baag swizzling (equivalent to decvec4.zwwy).
        /// </summary>
        public decvec4 baag => new decvec4(z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.zwwyx swizzling.
        /// </summary>
        public decvec5 zwwyx => new decvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.baagr swizzling (equivalent to decvec4.zwwyx).
        /// </summary>
        public decvec5 baagr => new decvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.zwwyy swizzling.
        /// </summary>
        public decvec5 zwwyy => new decvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.baagg swizzling (equivalent to decvec4.zwwyy).
        /// </summary>
        public decvec5 baagg => new decvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.zwwyz swizzling.
        /// </summary>
        public decvec5 zwwyz => new decvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.baagb swizzling (equivalent to decvec4.zwwyz).
        /// </summary>
        public decvec5 baagb => new decvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.zwwyw swizzling.
        /// </summary>
        public decvec5 zwwyw => new decvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.baaga swizzling (equivalent to decvec4.zwwyw).
        /// </summary>
        public decvec5 baaga => new decvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.zwwz swizzling.
        /// </summary>
        public decvec4 zwwz => new decvec4(z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.baab swizzling (equivalent to decvec4.zwwz).
        /// </summary>
        public decvec4 baab => new decvec4(z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.zwwzx swizzling.
        /// </summary>
        public decvec5 zwwzx => new decvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.baabr swizzling (equivalent to decvec4.zwwzx).
        /// </summary>
        public decvec5 baabr => new decvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.zwwzy swizzling.
        /// </summary>
        public decvec5 zwwzy => new decvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.baabg swizzling (equivalent to decvec4.zwwzy).
        /// </summary>
        public decvec5 baabg => new decvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.zwwzz swizzling.
        /// </summary>
        public decvec5 zwwzz => new decvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.baabb swizzling (equivalent to decvec4.zwwzz).
        /// </summary>
        public decvec5 baabb => new decvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.zwwzw swizzling.
        /// </summary>
        public decvec5 zwwzw => new decvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.baaba swizzling (equivalent to decvec4.zwwzw).
        /// </summary>
        public decvec5 baaba => new decvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.zwww swizzling.
        /// </summary>
        public decvec4 zwww => new decvec4(z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.baaa swizzling (equivalent to decvec4.zwww).
        /// </summary>
        public decvec4 baaa => new decvec4(z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.zwwwx swizzling.
        /// </summary>
        public decvec5 zwwwx => new decvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.baaar swizzling (equivalent to decvec4.zwwwx).
        /// </summary>
        public decvec5 baaar => new decvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.zwwwy swizzling.
        /// </summary>
        public decvec5 zwwwy => new decvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.baaag swizzling (equivalent to decvec4.zwwwy).
        /// </summary>
        public decvec5 baaag => new decvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.zwwwz swizzling.
        /// </summary>
        public decvec5 zwwwz => new decvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.baaab swizzling (equivalent to decvec4.zwwwz).
        /// </summary>
        public decvec5 baaab => new decvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.zwwww swizzling.
        /// </summary>
        public decvec5 zwwww => new decvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns decvec4.baaaa swizzling (equivalent to decvec4.zwwww).
        /// </summary>
        public decvec5 baaaa => new decvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns decvec4.wx swizzling.
        /// </summary>
        public decvec2 wx => new decvec2(w, x);
        
        /// <summary>
        /// Returns decvec4.ar swizzling (equivalent to decvec4.wx).
        /// </summary>
        public decvec2 ar => new decvec2(w, x);
        
        /// <summary>
        /// Returns decvec4.wxx swizzling.
        /// </summary>
        public decvec3 wxx => new decvec3(w, x, x);
        
        /// <summary>
        /// Returns decvec4.arr swizzling (equivalent to decvec4.wxx).
        /// </summary>
        public decvec3 arr => new decvec3(w, x, x);
        
        /// <summary>
        /// Returns decvec4.wxxx swizzling.
        /// </summary>
        public decvec4 wxxx => new decvec4(w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.arrr swizzling (equivalent to decvec4.wxxx).
        /// </summary>
        public decvec4 arrr => new decvec4(w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.wxxxx swizzling.
        /// </summary>
        public decvec5 wxxxx => new decvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.arrrr swizzling (equivalent to decvec4.wxxxx).
        /// </summary>
        public decvec5 arrrr => new decvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.wxxxy swizzling.
        /// </summary>
        public decvec5 wxxxy => new decvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.arrrg swizzling (equivalent to decvec4.wxxxy).
        /// </summary>
        public decvec5 arrrg => new decvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.wxxxz swizzling.
        /// </summary>
        public decvec5 wxxxz => new decvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.arrrb swizzling (equivalent to decvec4.wxxxz).
        /// </summary>
        public decvec5 arrrb => new decvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.wxxxw swizzling.
        /// </summary>
        public decvec5 wxxxw => new decvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.arrra swizzling (equivalent to decvec4.wxxxw).
        /// </summary>
        public decvec5 arrra => new decvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.wxxy swizzling.
        /// </summary>
        public decvec4 wxxy => new decvec4(w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.arrg swizzling (equivalent to decvec4.wxxy).
        /// </summary>
        public decvec4 arrg => new decvec4(w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.wxxyx swizzling.
        /// </summary>
        public decvec5 wxxyx => new decvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.arrgr swizzling (equivalent to decvec4.wxxyx).
        /// </summary>
        public decvec5 arrgr => new decvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.wxxyy swizzling.
        /// </summary>
        public decvec5 wxxyy => new decvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.arrgg swizzling (equivalent to decvec4.wxxyy).
        /// </summary>
        public decvec5 arrgg => new decvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.wxxyz swizzling.
        /// </summary>
        public decvec5 wxxyz => new decvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.arrgb swizzling (equivalent to decvec4.wxxyz).
        /// </summary>
        public decvec5 arrgb => new decvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.wxxyw swizzling.
        /// </summary>
        public decvec5 wxxyw => new decvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.arrga swizzling (equivalent to decvec4.wxxyw).
        /// </summary>
        public decvec5 arrga => new decvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.wxxz swizzling.
        /// </summary>
        public decvec4 wxxz => new decvec4(w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.arrb swizzling (equivalent to decvec4.wxxz).
        /// </summary>
        public decvec4 arrb => new decvec4(w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.wxxzx swizzling.
        /// </summary>
        public decvec5 wxxzx => new decvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.arrbr swizzling (equivalent to decvec4.wxxzx).
        /// </summary>
        public decvec5 arrbr => new decvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.wxxzy swizzling.
        /// </summary>
        public decvec5 wxxzy => new decvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.arrbg swizzling (equivalent to decvec4.wxxzy).
        /// </summary>
        public decvec5 arrbg => new decvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.wxxzz swizzling.
        /// </summary>
        public decvec5 wxxzz => new decvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.arrbb swizzling (equivalent to decvec4.wxxzz).
        /// </summary>
        public decvec5 arrbb => new decvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.wxxzw swizzling.
        /// </summary>
        public decvec5 wxxzw => new decvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.arrba swizzling (equivalent to decvec4.wxxzw).
        /// </summary>
        public decvec5 arrba => new decvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.wxxw swizzling.
        /// </summary>
        public decvec4 wxxw => new decvec4(w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.arra swizzling (equivalent to decvec4.wxxw).
        /// </summary>
        public decvec4 arra => new decvec4(w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.wxxwx swizzling.
        /// </summary>
        public decvec5 wxxwx => new decvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.arrar swizzling (equivalent to decvec4.wxxwx).
        /// </summary>
        public decvec5 arrar => new decvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.wxxwy swizzling.
        /// </summary>
        public decvec5 wxxwy => new decvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.arrag swizzling (equivalent to decvec4.wxxwy).
        /// </summary>
        public decvec5 arrag => new decvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.wxxwz swizzling.
        /// </summary>
        public decvec5 wxxwz => new decvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.arrab swizzling (equivalent to decvec4.wxxwz).
        /// </summary>
        public decvec5 arrab => new decvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.wxxww swizzling.
        /// </summary>
        public decvec5 wxxww => new decvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.arraa swizzling (equivalent to decvec4.wxxww).
        /// </summary>
        public decvec5 arraa => new decvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.wxy swizzling.
        /// </summary>
        public decvec3 wxy => new decvec3(w, x, y);
        
        /// <summary>
        /// Returns decvec4.arg swizzling (equivalent to decvec4.wxy).
        /// </summary>
        public decvec3 arg => new decvec3(w, x, y);
        
        /// <summary>
        /// Returns decvec4.wxyx swizzling.
        /// </summary>
        public decvec4 wxyx => new decvec4(w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.argr swizzling (equivalent to decvec4.wxyx).
        /// </summary>
        public decvec4 argr => new decvec4(w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.wxyxx swizzling.
        /// </summary>
        public decvec5 wxyxx => new decvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.argrr swizzling (equivalent to decvec4.wxyxx).
        /// </summary>
        public decvec5 argrr => new decvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.wxyxy swizzling.
        /// </summary>
        public decvec5 wxyxy => new decvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.argrg swizzling (equivalent to decvec4.wxyxy).
        /// </summary>
        public decvec5 argrg => new decvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.wxyxz swizzling.
        /// </summary>
        public decvec5 wxyxz => new decvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.argrb swizzling (equivalent to decvec4.wxyxz).
        /// </summary>
        public decvec5 argrb => new decvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.wxyxw swizzling.
        /// </summary>
        public decvec5 wxyxw => new decvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.argra swizzling (equivalent to decvec4.wxyxw).
        /// </summary>
        public decvec5 argra => new decvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.wxyy swizzling.
        /// </summary>
        public decvec4 wxyy => new decvec4(w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.argg swizzling (equivalent to decvec4.wxyy).
        /// </summary>
        public decvec4 argg => new decvec4(w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.wxyyx swizzling.
        /// </summary>
        public decvec5 wxyyx => new decvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.arggr swizzling (equivalent to decvec4.wxyyx).
        /// </summary>
        public decvec5 arggr => new decvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.wxyyy swizzling.
        /// </summary>
        public decvec5 wxyyy => new decvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.arggg swizzling (equivalent to decvec4.wxyyy).
        /// </summary>
        public decvec5 arggg => new decvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.wxyyz swizzling.
        /// </summary>
        public decvec5 wxyyz => new decvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.arggb swizzling (equivalent to decvec4.wxyyz).
        /// </summary>
        public decvec5 arggb => new decvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.wxyyw swizzling.
        /// </summary>
        public decvec5 wxyyw => new decvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.argga swizzling (equivalent to decvec4.wxyyw).
        /// </summary>
        public decvec5 argga => new decvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.wxyz swizzling.
        /// </summary>
        public decvec4 wxyz => new decvec4(w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.argb swizzling (equivalent to decvec4.wxyz).
        /// </summary>
        public decvec4 argb => new decvec4(w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.wxyzx swizzling.
        /// </summary>
        public decvec5 wxyzx => new decvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.argbr swizzling (equivalent to decvec4.wxyzx).
        /// </summary>
        public decvec5 argbr => new decvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.wxyzy swizzling.
        /// </summary>
        public decvec5 wxyzy => new decvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.argbg swizzling (equivalent to decvec4.wxyzy).
        /// </summary>
        public decvec5 argbg => new decvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.wxyzz swizzling.
        /// </summary>
        public decvec5 wxyzz => new decvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.argbb swizzling (equivalent to decvec4.wxyzz).
        /// </summary>
        public decvec5 argbb => new decvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.wxyzw swizzling.
        /// </summary>
        public decvec5 wxyzw => new decvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.argba swizzling (equivalent to decvec4.wxyzw).
        /// </summary>
        public decvec5 argba => new decvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.wxyw swizzling.
        /// </summary>
        public decvec4 wxyw => new decvec4(w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.arga swizzling (equivalent to decvec4.wxyw).
        /// </summary>
        public decvec4 arga => new decvec4(w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.wxywx swizzling.
        /// </summary>
        public decvec5 wxywx => new decvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.argar swizzling (equivalent to decvec4.wxywx).
        /// </summary>
        public decvec5 argar => new decvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.wxywy swizzling.
        /// </summary>
        public decvec5 wxywy => new decvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.argag swizzling (equivalent to decvec4.wxywy).
        /// </summary>
        public decvec5 argag => new decvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.wxywz swizzling.
        /// </summary>
        public decvec5 wxywz => new decvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.argab swizzling (equivalent to decvec4.wxywz).
        /// </summary>
        public decvec5 argab => new decvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.wxyww swizzling.
        /// </summary>
        public decvec5 wxyww => new decvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.argaa swizzling (equivalent to decvec4.wxyww).
        /// </summary>
        public decvec5 argaa => new decvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.wxz swizzling.
        /// </summary>
        public decvec3 wxz => new decvec3(w, x, z);
        
        /// <summary>
        /// Returns decvec4.arb swizzling (equivalent to decvec4.wxz).
        /// </summary>
        public decvec3 arb => new decvec3(w, x, z);
        
        /// <summary>
        /// Returns decvec4.wxzx swizzling.
        /// </summary>
        public decvec4 wxzx => new decvec4(w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.arbr swizzling (equivalent to decvec4.wxzx).
        /// </summary>
        public decvec4 arbr => new decvec4(w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.wxzxx swizzling.
        /// </summary>
        public decvec5 wxzxx => new decvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.arbrr swizzling (equivalent to decvec4.wxzxx).
        /// </summary>
        public decvec5 arbrr => new decvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.wxzxy swizzling.
        /// </summary>
        public decvec5 wxzxy => new decvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.arbrg swizzling (equivalent to decvec4.wxzxy).
        /// </summary>
        public decvec5 arbrg => new decvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.wxzxz swizzling.
        /// </summary>
        public decvec5 wxzxz => new decvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.arbrb swizzling (equivalent to decvec4.wxzxz).
        /// </summary>
        public decvec5 arbrb => new decvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.wxzxw swizzling.
        /// </summary>
        public decvec5 wxzxw => new decvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.arbra swizzling (equivalent to decvec4.wxzxw).
        /// </summary>
        public decvec5 arbra => new decvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.wxzy swizzling.
        /// </summary>
        public decvec4 wxzy => new decvec4(w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.arbg swizzling (equivalent to decvec4.wxzy).
        /// </summary>
        public decvec4 arbg => new decvec4(w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.wxzyx swizzling.
        /// </summary>
        public decvec5 wxzyx => new decvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.arbgr swizzling (equivalent to decvec4.wxzyx).
        /// </summary>
        public decvec5 arbgr => new decvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.wxzyy swizzling.
        /// </summary>
        public decvec5 wxzyy => new decvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.arbgg swizzling (equivalent to decvec4.wxzyy).
        /// </summary>
        public decvec5 arbgg => new decvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.wxzyz swizzling.
        /// </summary>
        public decvec5 wxzyz => new decvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.arbgb swizzling (equivalent to decvec4.wxzyz).
        /// </summary>
        public decvec5 arbgb => new decvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.wxzyw swizzling.
        /// </summary>
        public decvec5 wxzyw => new decvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.arbga swizzling (equivalent to decvec4.wxzyw).
        /// </summary>
        public decvec5 arbga => new decvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.wxzz swizzling.
        /// </summary>
        public decvec4 wxzz => new decvec4(w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.arbb swizzling (equivalent to decvec4.wxzz).
        /// </summary>
        public decvec4 arbb => new decvec4(w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.wxzzx swizzling.
        /// </summary>
        public decvec5 wxzzx => new decvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.arbbr swizzling (equivalent to decvec4.wxzzx).
        /// </summary>
        public decvec5 arbbr => new decvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.wxzzy swizzling.
        /// </summary>
        public decvec5 wxzzy => new decvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.arbbg swizzling (equivalent to decvec4.wxzzy).
        /// </summary>
        public decvec5 arbbg => new decvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.wxzzz swizzling.
        /// </summary>
        public decvec5 wxzzz => new decvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.arbbb swizzling (equivalent to decvec4.wxzzz).
        /// </summary>
        public decvec5 arbbb => new decvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.wxzzw swizzling.
        /// </summary>
        public decvec5 wxzzw => new decvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.arbba swizzling (equivalent to decvec4.wxzzw).
        /// </summary>
        public decvec5 arbba => new decvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.wxzw swizzling.
        /// </summary>
        public decvec4 wxzw => new decvec4(w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.arba swizzling (equivalent to decvec4.wxzw).
        /// </summary>
        public decvec4 arba => new decvec4(w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.wxzwx swizzling.
        /// </summary>
        public decvec5 wxzwx => new decvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.arbar swizzling (equivalent to decvec4.wxzwx).
        /// </summary>
        public decvec5 arbar => new decvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.wxzwy swizzling.
        /// </summary>
        public decvec5 wxzwy => new decvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.arbag swizzling (equivalent to decvec4.wxzwy).
        /// </summary>
        public decvec5 arbag => new decvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.wxzwz swizzling.
        /// </summary>
        public decvec5 wxzwz => new decvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.arbab swizzling (equivalent to decvec4.wxzwz).
        /// </summary>
        public decvec5 arbab => new decvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.wxzww swizzling.
        /// </summary>
        public decvec5 wxzww => new decvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.arbaa swizzling (equivalent to decvec4.wxzww).
        /// </summary>
        public decvec5 arbaa => new decvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.wxw swizzling.
        /// </summary>
        public decvec3 wxw => new decvec3(w, x, w);
        
        /// <summary>
        /// Returns decvec4.ara swizzling (equivalent to decvec4.wxw).
        /// </summary>
        public decvec3 ara => new decvec3(w, x, w);
        
        /// <summary>
        /// Returns decvec4.wxwx swizzling.
        /// </summary>
        public decvec4 wxwx => new decvec4(w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.arar swizzling (equivalent to decvec4.wxwx).
        /// </summary>
        public decvec4 arar => new decvec4(w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.wxwxx swizzling.
        /// </summary>
        public decvec5 wxwxx => new decvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.ararr swizzling (equivalent to decvec4.wxwxx).
        /// </summary>
        public decvec5 ararr => new decvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.wxwxy swizzling.
        /// </summary>
        public decvec5 wxwxy => new decvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.ararg swizzling (equivalent to decvec4.wxwxy).
        /// </summary>
        public decvec5 ararg => new decvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.wxwxz swizzling.
        /// </summary>
        public decvec5 wxwxz => new decvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.ararb swizzling (equivalent to decvec4.wxwxz).
        /// </summary>
        public decvec5 ararb => new decvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.wxwxw swizzling.
        /// </summary>
        public decvec5 wxwxw => new decvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.arara swizzling (equivalent to decvec4.wxwxw).
        /// </summary>
        public decvec5 arara => new decvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.wxwy swizzling.
        /// </summary>
        public decvec4 wxwy => new decvec4(w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.arag swizzling (equivalent to decvec4.wxwy).
        /// </summary>
        public decvec4 arag => new decvec4(w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.wxwyx swizzling.
        /// </summary>
        public decvec5 wxwyx => new decvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.aragr swizzling (equivalent to decvec4.wxwyx).
        /// </summary>
        public decvec5 aragr => new decvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.wxwyy swizzling.
        /// </summary>
        public decvec5 wxwyy => new decvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.aragg swizzling (equivalent to decvec4.wxwyy).
        /// </summary>
        public decvec5 aragg => new decvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.wxwyz swizzling.
        /// </summary>
        public decvec5 wxwyz => new decvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.aragb swizzling (equivalent to decvec4.wxwyz).
        /// </summary>
        public decvec5 aragb => new decvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.wxwyw swizzling.
        /// </summary>
        public decvec5 wxwyw => new decvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.araga swizzling (equivalent to decvec4.wxwyw).
        /// </summary>
        public decvec5 araga => new decvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.wxwz swizzling.
        /// </summary>
        public decvec4 wxwz => new decvec4(w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.arab swizzling (equivalent to decvec4.wxwz).
        /// </summary>
        public decvec4 arab => new decvec4(w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.wxwzx swizzling.
        /// </summary>
        public decvec5 wxwzx => new decvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.arabr swizzling (equivalent to decvec4.wxwzx).
        /// </summary>
        public decvec5 arabr => new decvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.wxwzy swizzling.
        /// </summary>
        public decvec5 wxwzy => new decvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.arabg swizzling (equivalent to decvec4.wxwzy).
        /// </summary>
        public decvec5 arabg => new decvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.wxwzz swizzling.
        /// </summary>
        public decvec5 wxwzz => new decvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.arabb swizzling (equivalent to decvec4.wxwzz).
        /// </summary>
        public decvec5 arabb => new decvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.wxwzw swizzling.
        /// </summary>
        public decvec5 wxwzw => new decvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.araba swizzling (equivalent to decvec4.wxwzw).
        /// </summary>
        public decvec5 araba => new decvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.wxww swizzling.
        /// </summary>
        public decvec4 wxww => new decvec4(w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.araa swizzling (equivalent to decvec4.wxww).
        /// </summary>
        public decvec4 araa => new decvec4(w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.wxwwx swizzling.
        /// </summary>
        public decvec5 wxwwx => new decvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.araar swizzling (equivalent to decvec4.wxwwx).
        /// </summary>
        public decvec5 araar => new decvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.wxwwy swizzling.
        /// </summary>
        public decvec5 wxwwy => new decvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.araag swizzling (equivalent to decvec4.wxwwy).
        /// </summary>
        public decvec5 araag => new decvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.wxwwz swizzling.
        /// </summary>
        public decvec5 wxwwz => new decvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.araab swizzling (equivalent to decvec4.wxwwz).
        /// </summary>
        public decvec5 araab => new decvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.wxwww swizzling.
        /// </summary>
        public decvec5 wxwww => new decvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.araaa swizzling (equivalent to decvec4.wxwww).
        /// </summary>
        public decvec5 araaa => new decvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.wy swizzling.
        /// </summary>
        public decvec2 wy => new decvec2(w, y);
        
        /// <summary>
        /// Returns decvec4.ag swizzling (equivalent to decvec4.wy).
        /// </summary>
        public decvec2 ag => new decvec2(w, y);
        
        /// <summary>
        /// Returns decvec4.wyx swizzling.
        /// </summary>
        public decvec3 wyx => new decvec3(w, y, x);
        
        /// <summary>
        /// Returns decvec4.agr swizzling (equivalent to decvec4.wyx).
        /// </summary>
        public decvec3 agr => new decvec3(w, y, x);
        
        /// <summary>
        /// Returns decvec4.wyxx swizzling.
        /// </summary>
        public decvec4 wyxx => new decvec4(w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.agrr swizzling (equivalent to decvec4.wyxx).
        /// </summary>
        public decvec4 agrr => new decvec4(w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.wyxxx swizzling.
        /// </summary>
        public decvec5 wyxxx => new decvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.agrrr swizzling (equivalent to decvec4.wyxxx).
        /// </summary>
        public decvec5 agrrr => new decvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.wyxxy swizzling.
        /// </summary>
        public decvec5 wyxxy => new decvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.agrrg swizzling (equivalent to decvec4.wyxxy).
        /// </summary>
        public decvec5 agrrg => new decvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.wyxxz swizzling.
        /// </summary>
        public decvec5 wyxxz => new decvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.agrrb swizzling (equivalent to decvec4.wyxxz).
        /// </summary>
        public decvec5 agrrb => new decvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.wyxxw swizzling.
        /// </summary>
        public decvec5 wyxxw => new decvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.agrra swizzling (equivalent to decvec4.wyxxw).
        /// </summary>
        public decvec5 agrra => new decvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.wyxy swizzling.
        /// </summary>
        public decvec4 wyxy => new decvec4(w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.agrg swizzling (equivalent to decvec4.wyxy).
        /// </summary>
        public decvec4 agrg => new decvec4(w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.wyxyx swizzling.
        /// </summary>
        public decvec5 wyxyx => new decvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.agrgr swizzling (equivalent to decvec4.wyxyx).
        /// </summary>
        public decvec5 agrgr => new decvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.wyxyy swizzling.
        /// </summary>
        public decvec5 wyxyy => new decvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.agrgg swizzling (equivalent to decvec4.wyxyy).
        /// </summary>
        public decvec5 agrgg => new decvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.wyxyz swizzling.
        /// </summary>
        public decvec5 wyxyz => new decvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.agrgb swizzling (equivalent to decvec4.wyxyz).
        /// </summary>
        public decvec5 agrgb => new decvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.wyxyw swizzling.
        /// </summary>
        public decvec5 wyxyw => new decvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.agrga swizzling (equivalent to decvec4.wyxyw).
        /// </summary>
        public decvec5 agrga => new decvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.wyxz swizzling.
        /// </summary>
        public decvec4 wyxz => new decvec4(w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.agrb swizzling (equivalent to decvec4.wyxz).
        /// </summary>
        public decvec4 agrb => new decvec4(w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.wyxzx swizzling.
        /// </summary>
        public decvec5 wyxzx => new decvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.agrbr swizzling (equivalent to decvec4.wyxzx).
        /// </summary>
        public decvec5 agrbr => new decvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.wyxzy swizzling.
        /// </summary>
        public decvec5 wyxzy => new decvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.agrbg swizzling (equivalent to decvec4.wyxzy).
        /// </summary>
        public decvec5 agrbg => new decvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.wyxzz swizzling.
        /// </summary>
        public decvec5 wyxzz => new decvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.agrbb swizzling (equivalent to decvec4.wyxzz).
        /// </summary>
        public decvec5 agrbb => new decvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.wyxzw swizzling.
        /// </summary>
        public decvec5 wyxzw => new decvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.agrba swizzling (equivalent to decvec4.wyxzw).
        /// </summary>
        public decvec5 agrba => new decvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.wyxw swizzling.
        /// </summary>
        public decvec4 wyxw => new decvec4(w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.agra swizzling (equivalent to decvec4.wyxw).
        /// </summary>
        public decvec4 agra => new decvec4(w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.wyxwx swizzling.
        /// </summary>
        public decvec5 wyxwx => new decvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.agrar swizzling (equivalent to decvec4.wyxwx).
        /// </summary>
        public decvec5 agrar => new decvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.wyxwy swizzling.
        /// </summary>
        public decvec5 wyxwy => new decvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.agrag swizzling (equivalent to decvec4.wyxwy).
        /// </summary>
        public decvec5 agrag => new decvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.wyxwz swizzling.
        /// </summary>
        public decvec5 wyxwz => new decvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.agrab swizzling (equivalent to decvec4.wyxwz).
        /// </summary>
        public decvec5 agrab => new decvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.wyxww swizzling.
        /// </summary>
        public decvec5 wyxww => new decvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.agraa swizzling (equivalent to decvec4.wyxww).
        /// </summary>
        public decvec5 agraa => new decvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.wyy swizzling.
        /// </summary>
        public decvec3 wyy => new decvec3(w, y, y);
        
        /// <summary>
        /// Returns decvec4.agg swizzling (equivalent to decvec4.wyy).
        /// </summary>
        public decvec3 agg => new decvec3(w, y, y);
        
        /// <summary>
        /// Returns decvec4.wyyx swizzling.
        /// </summary>
        public decvec4 wyyx => new decvec4(w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.aggr swizzling (equivalent to decvec4.wyyx).
        /// </summary>
        public decvec4 aggr => new decvec4(w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.wyyxx swizzling.
        /// </summary>
        public decvec5 wyyxx => new decvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.aggrr swizzling (equivalent to decvec4.wyyxx).
        /// </summary>
        public decvec5 aggrr => new decvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.wyyxy swizzling.
        /// </summary>
        public decvec5 wyyxy => new decvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.aggrg swizzling (equivalent to decvec4.wyyxy).
        /// </summary>
        public decvec5 aggrg => new decvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.wyyxz swizzling.
        /// </summary>
        public decvec5 wyyxz => new decvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.aggrb swizzling (equivalent to decvec4.wyyxz).
        /// </summary>
        public decvec5 aggrb => new decvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.wyyxw swizzling.
        /// </summary>
        public decvec5 wyyxw => new decvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.aggra swizzling (equivalent to decvec4.wyyxw).
        /// </summary>
        public decvec5 aggra => new decvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.wyyy swizzling.
        /// </summary>
        public decvec4 wyyy => new decvec4(w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.aggg swizzling (equivalent to decvec4.wyyy).
        /// </summary>
        public decvec4 aggg => new decvec4(w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.wyyyx swizzling.
        /// </summary>
        public decvec5 wyyyx => new decvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.agggr swizzling (equivalent to decvec4.wyyyx).
        /// </summary>
        public decvec5 agggr => new decvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.wyyyy swizzling.
        /// </summary>
        public decvec5 wyyyy => new decvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.agggg swizzling (equivalent to decvec4.wyyyy).
        /// </summary>
        public decvec5 agggg => new decvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.wyyyz swizzling.
        /// </summary>
        public decvec5 wyyyz => new decvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.agggb swizzling (equivalent to decvec4.wyyyz).
        /// </summary>
        public decvec5 agggb => new decvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.wyyyw swizzling.
        /// </summary>
        public decvec5 wyyyw => new decvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.aggga swizzling (equivalent to decvec4.wyyyw).
        /// </summary>
        public decvec5 aggga => new decvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.wyyz swizzling.
        /// </summary>
        public decvec4 wyyz => new decvec4(w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.aggb swizzling (equivalent to decvec4.wyyz).
        /// </summary>
        public decvec4 aggb => new decvec4(w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.wyyzx swizzling.
        /// </summary>
        public decvec5 wyyzx => new decvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.aggbr swizzling (equivalent to decvec4.wyyzx).
        /// </summary>
        public decvec5 aggbr => new decvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.wyyzy swizzling.
        /// </summary>
        public decvec5 wyyzy => new decvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.aggbg swizzling (equivalent to decvec4.wyyzy).
        /// </summary>
        public decvec5 aggbg => new decvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.wyyzz swizzling.
        /// </summary>
        public decvec5 wyyzz => new decvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.aggbb swizzling (equivalent to decvec4.wyyzz).
        /// </summary>
        public decvec5 aggbb => new decvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.wyyzw swizzling.
        /// </summary>
        public decvec5 wyyzw => new decvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.aggba swizzling (equivalent to decvec4.wyyzw).
        /// </summary>
        public decvec5 aggba => new decvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.wyyw swizzling.
        /// </summary>
        public decvec4 wyyw => new decvec4(w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.agga swizzling (equivalent to decvec4.wyyw).
        /// </summary>
        public decvec4 agga => new decvec4(w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.wyywx swizzling.
        /// </summary>
        public decvec5 wyywx => new decvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.aggar swizzling (equivalent to decvec4.wyywx).
        /// </summary>
        public decvec5 aggar => new decvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.wyywy swizzling.
        /// </summary>
        public decvec5 wyywy => new decvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.aggag swizzling (equivalent to decvec4.wyywy).
        /// </summary>
        public decvec5 aggag => new decvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.wyywz swizzling.
        /// </summary>
        public decvec5 wyywz => new decvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.aggab swizzling (equivalent to decvec4.wyywz).
        /// </summary>
        public decvec5 aggab => new decvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.wyyww swizzling.
        /// </summary>
        public decvec5 wyyww => new decvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.aggaa swizzling (equivalent to decvec4.wyyww).
        /// </summary>
        public decvec5 aggaa => new decvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.wyz swizzling.
        /// </summary>
        public decvec3 wyz => new decvec3(w, y, z);
        
        /// <summary>
        /// Returns decvec4.agb swizzling (equivalent to decvec4.wyz).
        /// </summary>
        public decvec3 agb => new decvec3(w, y, z);
        
        /// <summary>
        /// Returns decvec4.wyzx swizzling.
        /// </summary>
        public decvec4 wyzx => new decvec4(w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.agbr swizzling (equivalent to decvec4.wyzx).
        /// </summary>
        public decvec4 agbr => new decvec4(w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.wyzxx swizzling.
        /// </summary>
        public decvec5 wyzxx => new decvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.agbrr swizzling (equivalent to decvec4.wyzxx).
        /// </summary>
        public decvec5 agbrr => new decvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.wyzxy swizzling.
        /// </summary>
        public decvec5 wyzxy => new decvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.agbrg swizzling (equivalent to decvec4.wyzxy).
        /// </summary>
        public decvec5 agbrg => new decvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.wyzxz swizzling.
        /// </summary>
        public decvec5 wyzxz => new decvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.agbrb swizzling (equivalent to decvec4.wyzxz).
        /// </summary>
        public decvec5 agbrb => new decvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.wyzxw swizzling.
        /// </summary>
        public decvec5 wyzxw => new decvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.agbra swizzling (equivalent to decvec4.wyzxw).
        /// </summary>
        public decvec5 agbra => new decvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.wyzy swizzling.
        /// </summary>
        public decvec4 wyzy => new decvec4(w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.agbg swizzling (equivalent to decvec4.wyzy).
        /// </summary>
        public decvec4 agbg => new decvec4(w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.wyzyx swizzling.
        /// </summary>
        public decvec5 wyzyx => new decvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.agbgr swizzling (equivalent to decvec4.wyzyx).
        /// </summary>
        public decvec5 agbgr => new decvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.wyzyy swizzling.
        /// </summary>
        public decvec5 wyzyy => new decvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.agbgg swizzling (equivalent to decvec4.wyzyy).
        /// </summary>
        public decvec5 agbgg => new decvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.wyzyz swizzling.
        /// </summary>
        public decvec5 wyzyz => new decvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.agbgb swizzling (equivalent to decvec4.wyzyz).
        /// </summary>
        public decvec5 agbgb => new decvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.wyzyw swizzling.
        /// </summary>
        public decvec5 wyzyw => new decvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.agbga swizzling (equivalent to decvec4.wyzyw).
        /// </summary>
        public decvec5 agbga => new decvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.wyzz swizzling.
        /// </summary>
        public decvec4 wyzz => new decvec4(w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.agbb swizzling (equivalent to decvec4.wyzz).
        /// </summary>
        public decvec4 agbb => new decvec4(w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.wyzzx swizzling.
        /// </summary>
        public decvec5 wyzzx => new decvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.agbbr swizzling (equivalent to decvec4.wyzzx).
        /// </summary>
        public decvec5 agbbr => new decvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.wyzzy swizzling.
        /// </summary>
        public decvec5 wyzzy => new decvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.agbbg swizzling (equivalent to decvec4.wyzzy).
        /// </summary>
        public decvec5 agbbg => new decvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.wyzzz swizzling.
        /// </summary>
        public decvec5 wyzzz => new decvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.agbbb swizzling (equivalent to decvec4.wyzzz).
        /// </summary>
        public decvec5 agbbb => new decvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.wyzzw swizzling.
        /// </summary>
        public decvec5 wyzzw => new decvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.agbba swizzling (equivalent to decvec4.wyzzw).
        /// </summary>
        public decvec5 agbba => new decvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.wyzw swizzling.
        /// </summary>
        public decvec4 wyzw => new decvec4(w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.agba swizzling (equivalent to decvec4.wyzw).
        /// </summary>
        public decvec4 agba => new decvec4(w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.wyzwx swizzling.
        /// </summary>
        public decvec5 wyzwx => new decvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.agbar swizzling (equivalent to decvec4.wyzwx).
        /// </summary>
        public decvec5 agbar => new decvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.wyzwy swizzling.
        /// </summary>
        public decvec5 wyzwy => new decvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.agbag swizzling (equivalent to decvec4.wyzwy).
        /// </summary>
        public decvec5 agbag => new decvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.wyzwz swizzling.
        /// </summary>
        public decvec5 wyzwz => new decvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.agbab swizzling (equivalent to decvec4.wyzwz).
        /// </summary>
        public decvec5 agbab => new decvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.wyzww swizzling.
        /// </summary>
        public decvec5 wyzww => new decvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.agbaa swizzling (equivalent to decvec4.wyzww).
        /// </summary>
        public decvec5 agbaa => new decvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.wyw swizzling.
        /// </summary>
        public decvec3 wyw => new decvec3(w, y, w);
        
        /// <summary>
        /// Returns decvec4.aga swizzling (equivalent to decvec4.wyw).
        /// </summary>
        public decvec3 aga => new decvec3(w, y, w);
        
        /// <summary>
        /// Returns decvec4.wywx swizzling.
        /// </summary>
        public decvec4 wywx => new decvec4(w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.agar swizzling (equivalent to decvec4.wywx).
        /// </summary>
        public decvec4 agar => new decvec4(w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.wywxx swizzling.
        /// </summary>
        public decvec5 wywxx => new decvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.agarr swizzling (equivalent to decvec4.wywxx).
        /// </summary>
        public decvec5 agarr => new decvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.wywxy swizzling.
        /// </summary>
        public decvec5 wywxy => new decvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.agarg swizzling (equivalent to decvec4.wywxy).
        /// </summary>
        public decvec5 agarg => new decvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.wywxz swizzling.
        /// </summary>
        public decvec5 wywxz => new decvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.agarb swizzling (equivalent to decvec4.wywxz).
        /// </summary>
        public decvec5 agarb => new decvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.wywxw swizzling.
        /// </summary>
        public decvec5 wywxw => new decvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.agara swizzling (equivalent to decvec4.wywxw).
        /// </summary>
        public decvec5 agara => new decvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.wywy swizzling.
        /// </summary>
        public decvec4 wywy => new decvec4(w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.agag swizzling (equivalent to decvec4.wywy).
        /// </summary>
        public decvec4 agag => new decvec4(w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.wywyx swizzling.
        /// </summary>
        public decvec5 wywyx => new decvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.agagr swizzling (equivalent to decvec4.wywyx).
        /// </summary>
        public decvec5 agagr => new decvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.wywyy swizzling.
        /// </summary>
        public decvec5 wywyy => new decvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.agagg swizzling (equivalent to decvec4.wywyy).
        /// </summary>
        public decvec5 agagg => new decvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.wywyz swizzling.
        /// </summary>
        public decvec5 wywyz => new decvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.agagb swizzling (equivalent to decvec4.wywyz).
        /// </summary>
        public decvec5 agagb => new decvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.wywyw swizzling.
        /// </summary>
        public decvec5 wywyw => new decvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.agaga swizzling (equivalent to decvec4.wywyw).
        /// </summary>
        public decvec5 agaga => new decvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.wywz swizzling.
        /// </summary>
        public decvec4 wywz => new decvec4(w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.agab swizzling (equivalent to decvec4.wywz).
        /// </summary>
        public decvec4 agab => new decvec4(w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.wywzx swizzling.
        /// </summary>
        public decvec5 wywzx => new decvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.agabr swizzling (equivalent to decvec4.wywzx).
        /// </summary>
        public decvec5 agabr => new decvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.wywzy swizzling.
        /// </summary>
        public decvec5 wywzy => new decvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.agabg swizzling (equivalent to decvec4.wywzy).
        /// </summary>
        public decvec5 agabg => new decvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.wywzz swizzling.
        /// </summary>
        public decvec5 wywzz => new decvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.agabb swizzling (equivalent to decvec4.wywzz).
        /// </summary>
        public decvec5 agabb => new decvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.wywzw swizzling.
        /// </summary>
        public decvec5 wywzw => new decvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.agaba swizzling (equivalent to decvec4.wywzw).
        /// </summary>
        public decvec5 agaba => new decvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.wyww swizzling.
        /// </summary>
        public decvec4 wyww => new decvec4(w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.agaa swizzling (equivalent to decvec4.wyww).
        /// </summary>
        public decvec4 agaa => new decvec4(w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.wywwx swizzling.
        /// </summary>
        public decvec5 wywwx => new decvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.agaar swizzling (equivalent to decvec4.wywwx).
        /// </summary>
        public decvec5 agaar => new decvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.wywwy swizzling.
        /// </summary>
        public decvec5 wywwy => new decvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.agaag swizzling (equivalent to decvec4.wywwy).
        /// </summary>
        public decvec5 agaag => new decvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.wywwz swizzling.
        /// </summary>
        public decvec5 wywwz => new decvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.agaab swizzling (equivalent to decvec4.wywwz).
        /// </summary>
        public decvec5 agaab => new decvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.wywww swizzling.
        /// </summary>
        public decvec5 wywww => new decvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.agaaa swizzling (equivalent to decvec4.wywww).
        /// </summary>
        public decvec5 agaaa => new decvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.wz swizzling.
        /// </summary>
        public decvec2 wz => new decvec2(w, z);
        
        /// <summary>
        /// Returns decvec4.ab swizzling (equivalent to decvec4.wz).
        /// </summary>
        public decvec2 ab => new decvec2(w, z);
        
        /// <summary>
        /// Returns decvec4.wzx swizzling.
        /// </summary>
        public decvec3 wzx => new decvec3(w, z, x);
        
        /// <summary>
        /// Returns decvec4.abr swizzling (equivalent to decvec4.wzx).
        /// </summary>
        public decvec3 abr => new decvec3(w, z, x);
        
        /// <summary>
        /// Returns decvec4.wzxx swizzling.
        /// </summary>
        public decvec4 wzxx => new decvec4(w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.abrr swizzling (equivalent to decvec4.wzxx).
        /// </summary>
        public decvec4 abrr => new decvec4(w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.wzxxx swizzling.
        /// </summary>
        public decvec5 wzxxx => new decvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.abrrr swizzling (equivalent to decvec4.wzxxx).
        /// </summary>
        public decvec5 abrrr => new decvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.wzxxy swizzling.
        /// </summary>
        public decvec5 wzxxy => new decvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.abrrg swizzling (equivalent to decvec4.wzxxy).
        /// </summary>
        public decvec5 abrrg => new decvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.wzxxz swizzling.
        /// </summary>
        public decvec5 wzxxz => new decvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.abrrb swizzling (equivalent to decvec4.wzxxz).
        /// </summary>
        public decvec5 abrrb => new decvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.wzxxw swizzling.
        /// </summary>
        public decvec5 wzxxw => new decvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.abrra swizzling (equivalent to decvec4.wzxxw).
        /// </summary>
        public decvec5 abrra => new decvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.wzxy swizzling.
        /// </summary>
        public decvec4 wzxy => new decvec4(w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.abrg swizzling (equivalent to decvec4.wzxy).
        /// </summary>
        public decvec4 abrg => new decvec4(w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.wzxyx swizzling.
        /// </summary>
        public decvec5 wzxyx => new decvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.abrgr swizzling (equivalent to decvec4.wzxyx).
        /// </summary>
        public decvec5 abrgr => new decvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.wzxyy swizzling.
        /// </summary>
        public decvec5 wzxyy => new decvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.abrgg swizzling (equivalent to decvec4.wzxyy).
        /// </summary>
        public decvec5 abrgg => new decvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.wzxyz swizzling.
        /// </summary>
        public decvec5 wzxyz => new decvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.abrgb swizzling (equivalent to decvec4.wzxyz).
        /// </summary>
        public decvec5 abrgb => new decvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.wzxyw swizzling.
        /// </summary>
        public decvec5 wzxyw => new decvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.abrga swizzling (equivalent to decvec4.wzxyw).
        /// </summary>
        public decvec5 abrga => new decvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.wzxz swizzling.
        /// </summary>
        public decvec4 wzxz => new decvec4(w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.abrb swizzling (equivalent to decvec4.wzxz).
        /// </summary>
        public decvec4 abrb => new decvec4(w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.wzxzx swizzling.
        /// </summary>
        public decvec5 wzxzx => new decvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.abrbr swizzling (equivalent to decvec4.wzxzx).
        /// </summary>
        public decvec5 abrbr => new decvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.wzxzy swizzling.
        /// </summary>
        public decvec5 wzxzy => new decvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.abrbg swizzling (equivalent to decvec4.wzxzy).
        /// </summary>
        public decvec5 abrbg => new decvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.wzxzz swizzling.
        /// </summary>
        public decvec5 wzxzz => new decvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.abrbb swizzling (equivalent to decvec4.wzxzz).
        /// </summary>
        public decvec5 abrbb => new decvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.wzxzw swizzling.
        /// </summary>
        public decvec5 wzxzw => new decvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.abrba swizzling (equivalent to decvec4.wzxzw).
        /// </summary>
        public decvec5 abrba => new decvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.wzxw swizzling.
        /// </summary>
        public decvec4 wzxw => new decvec4(w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.abra swizzling (equivalent to decvec4.wzxw).
        /// </summary>
        public decvec4 abra => new decvec4(w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.wzxwx swizzling.
        /// </summary>
        public decvec5 wzxwx => new decvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.abrar swizzling (equivalent to decvec4.wzxwx).
        /// </summary>
        public decvec5 abrar => new decvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.wzxwy swizzling.
        /// </summary>
        public decvec5 wzxwy => new decvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.abrag swizzling (equivalent to decvec4.wzxwy).
        /// </summary>
        public decvec5 abrag => new decvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.wzxwz swizzling.
        /// </summary>
        public decvec5 wzxwz => new decvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.abrab swizzling (equivalent to decvec4.wzxwz).
        /// </summary>
        public decvec5 abrab => new decvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.wzxww swizzling.
        /// </summary>
        public decvec5 wzxww => new decvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.abraa swizzling (equivalent to decvec4.wzxww).
        /// </summary>
        public decvec5 abraa => new decvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.wzy swizzling.
        /// </summary>
        public decvec3 wzy => new decvec3(w, z, y);
        
        /// <summary>
        /// Returns decvec4.abg swizzling (equivalent to decvec4.wzy).
        /// </summary>
        public decvec3 abg => new decvec3(w, z, y);
        
        /// <summary>
        /// Returns decvec4.wzyx swizzling.
        /// </summary>
        public decvec4 wzyx => new decvec4(w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.abgr swizzling (equivalent to decvec4.wzyx).
        /// </summary>
        public decvec4 abgr => new decvec4(w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.wzyxx swizzling.
        /// </summary>
        public decvec5 wzyxx => new decvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.abgrr swizzling (equivalent to decvec4.wzyxx).
        /// </summary>
        public decvec5 abgrr => new decvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.wzyxy swizzling.
        /// </summary>
        public decvec5 wzyxy => new decvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.abgrg swizzling (equivalent to decvec4.wzyxy).
        /// </summary>
        public decvec5 abgrg => new decvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.wzyxz swizzling.
        /// </summary>
        public decvec5 wzyxz => new decvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.abgrb swizzling (equivalent to decvec4.wzyxz).
        /// </summary>
        public decvec5 abgrb => new decvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.wzyxw swizzling.
        /// </summary>
        public decvec5 wzyxw => new decvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.abgra swizzling (equivalent to decvec4.wzyxw).
        /// </summary>
        public decvec5 abgra => new decvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.wzyy swizzling.
        /// </summary>
        public decvec4 wzyy => new decvec4(w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.abgg swizzling (equivalent to decvec4.wzyy).
        /// </summary>
        public decvec4 abgg => new decvec4(w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.wzyyx swizzling.
        /// </summary>
        public decvec5 wzyyx => new decvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.abggr swizzling (equivalent to decvec4.wzyyx).
        /// </summary>
        public decvec5 abggr => new decvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.wzyyy swizzling.
        /// </summary>
        public decvec5 wzyyy => new decvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.abggg swizzling (equivalent to decvec4.wzyyy).
        /// </summary>
        public decvec5 abggg => new decvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.wzyyz swizzling.
        /// </summary>
        public decvec5 wzyyz => new decvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.abggb swizzling (equivalent to decvec4.wzyyz).
        /// </summary>
        public decvec5 abggb => new decvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.wzyyw swizzling.
        /// </summary>
        public decvec5 wzyyw => new decvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.abgga swizzling (equivalent to decvec4.wzyyw).
        /// </summary>
        public decvec5 abgga => new decvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.wzyz swizzling.
        /// </summary>
        public decvec4 wzyz => new decvec4(w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.abgb swizzling (equivalent to decvec4.wzyz).
        /// </summary>
        public decvec4 abgb => new decvec4(w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.wzyzx swizzling.
        /// </summary>
        public decvec5 wzyzx => new decvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.abgbr swizzling (equivalent to decvec4.wzyzx).
        /// </summary>
        public decvec5 abgbr => new decvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.wzyzy swizzling.
        /// </summary>
        public decvec5 wzyzy => new decvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.abgbg swizzling (equivalent to decvec4.wzyzy).
        /// </summary>
        public decvec5 abgbg => new decvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.wzyzz swizzling.
        /// </summary>
        public decvec5 wzyzz => new decvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.abgbb swizzling (equivalent to decvec4.wzyzz).
        /// </summary>
        public decvec5 abgbb => new decvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.wzyzw swizzling.
        /// </summary>
        public decvec5 wzyzw => new decvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.abgba swizzling (equivalent to decvec4.wzyzw).
        /// </summary>
        public decvec5 abgba => new decvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.wzyw swizzling.
        /// </summary>
        public decvec4 wzyw => new decvec4(w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.abga swizzling (equivalent to decvec4.wzyw).
        /// </summary>
        public decvec4 abga => new decvec4(w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.wzywx swizzling.
        /// </summary>
        public decvec5 wzywx => new decvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.abgar swizzling (equivalent to decvec4.wzywx).
        /// </summary>
        public decvec5 abgar => new decvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.wzywy swizzling.
        /// </summary>
        public decvec5 wzywy => new decvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.abgag swizzling (equivalent to decvec4.wzywy).
        /// </summary>
        public decvec5 abgag => new decvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.wzywz swizzling.
        /// </summary>
        public decvec5 wzywz => new decvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.abgab swizzling (equivalent to decvec4.wzywz).
        /// </summary>
        public decvec5 abgab => new decvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.wzyww swizzling.
        /// </summary>
        public decvec5 wzyww => new decvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.abgaa swizzling (equivalent to decvec4.wzyww).
        /// </summary>
        public decvec5 abgaa => new decvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.wzz swizzling.
        /// </summary>
        public decvec3 wzz => new decvec3(w, z, z);
        
        /// <summary>
        /// Returns decvec4.abb swizzling (equivalent to decvec4.wzz).
        /// </summary>
        public decvec3 abb => new decvec3(w, z, z);
        
        /// <summary>
        /// Returns decvec4.wzzx swizzling.
        /// </summary>
        public decvec4 wzzx => new decvec4(w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.abbr swizzling (equivalent to decvec4.wzzx).
        /// </summary>
        public decvec4 abbr => new decvec4(w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.wzzxx swizzling.
        /// </summary>
        public decvec5 wzzxx => new decvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.abbrr swizzling (equivalent to decvec4.wzzxx).
        /// </summary>
        public decvec5 abbrr => new decvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.wzzxy swizzling.
        /// </summary>
        public decvec5 wzzxy => new decvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.abbrg swizzling (equivalent to decvec4.wzzxy).
        /// </summary>
        public decvec5 abbrg => new decvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.wzzxz swizzling.
        /// </summary>
        public decvec5 wzzxz => new decvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.abbrb swizzling (equivalent to decvec4.wzzxz).
        /// </summary>
        public decvec5 abbrb => new decvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.wzzxw swizzling.
        /// </summary>
        public decvec5 wzzxw => new decvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.abbra swizzling (equivalent to decvec4.wzzxw).
        /// </summary>
        public decvec5 abbra => new decvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.wzzy swizzling.
        /// </summary>
        public decvec4 wzzy => new decvec4(w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.abbg swizzling (equivalent to decvec4.wzzy).
        /// </summary>
        public decvec4 abbg => new decvec4(w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.wzzyx swizzling.
        /// </summary>
        public decvec5 wzzyx => new decvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.abbgr swizzling (equivalent to decvec4.wzzyx).
        /// </summary>
        public decvec5 abbgr => new decvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.wzzyy swizzling.
        /// </summary>
        public decvec5 wzzyy => new decvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.abbgg swizzling (equivalent to decvec4.wzzyy).
        /// </summary>
        public decvec5 abbgg => new decvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.wzzyz swizzling.
        /// </summary>
        public decvec5 wzzyz => new decvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.abbgb swizzling (equivalent to decvec4.wzzyz).
        /// </summary>
        public decvec5 abbgb => new decvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.wzzyw swizzling.
        /// </summary>
        public decvec5 wzzyw => new decvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.abbga swizzling (equivalent to decvec4.wzzyw).
        /// </summary>
        public decvec5 abbga => new decvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.wzzz swizzling.
        /// </summary>
        public decvec4 wzzz => new decvec4(w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.abbb swizzling (equivalent to decvec4.wzzz).
        /// </summary>
        public decvec4 abbb => new decvec4(w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.wzzzx swizzling.
        /// </summary>
        public decvec5 wzzzx => new decvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.abbbr swizzling (equivalent to decvec4.wzzzx).
        /// </summary>
        public decvec5 abbbr => new decvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.wzzzy swizzling.
        /// </summary>
        public decvec5 wzzzy => new decvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.abbbg swizzling (equivalent to decvec4.wzzzy).
        /// </summary>
        public decvec5 abbbg => new decvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.wzzzz swizzling.
        /// </summary>
        public decvec5 wzzzz => new decvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.abbbb swizzling (equivalent to decvec4.wzzzz).
        /// </summary>
        public decvec5 abbbb => new decvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.wzzzw swizzling.
        /// </summary>
        public decvec5 wzzzw => new decvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.abbba swizzling (equivalent to decvec4.wzzzw).
        /// </summary>
        public decvec5 abbba => new decvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.wzzw swizzling.
        /// </summary>
        public decvec4 wzzw => new decvec4(w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.abba swizzling (equivalent to decvec4.wzzw).
        /// </summary>
        public decvec4 abba => new decvec4(w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.wzzwx swizzling.
        /// </summary>
        public decvec5 wzzwx => new decvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.abbar swizzling (equivalent to decvec4.wzzwx).
        /// </summary>
        public decvec5 abbar => new decvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.wzzwy swizzling.
        /// </summary>
        public decvec5 wzzwy => new decvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.abbag swizzling (equivalent to decvec4.wzzwy).
        /// </summary>
        public decvec5 abbag => new decvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.wzzwz swizzling.
        /// </summary>
        public decvec5 wzzwz => new decvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.abbab swizzling (equivalent to decvec4.wzzwz).
        /// </summary>
        public decvec5 abbab => new decvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.wzzww swizzling.
        /// </summary>
        public decvec5 wzzww => new decvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.abbaa swizzling (equivalent to decvec4.wzzww).
        /// </summary>
        public decvec5 abbaa => new decvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.wzw swizzling.
        /// </summary>
        public decvec3 wzw => new decvec3(w, z, w);
        
        /// <summary>
        /// Returns decvec4.aba swizzling (equivalent to decvec4.wzw).
        /// </summary>
        public decvec3 aba => new decvec3(w, z, w);
        
        /// <summary>
        /// Returns decvec4.wzwx swizzling.
        /// </summary>
        public decvec4 wzwx => new decvec4(w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.abar swizzling (equivalent to decvec4.wzwx).
        /// </summary>
        public decvec4 abar => new decvec4(w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.wzwxx swizzling.
        /// </summary>
        public decvec5 wzwxx => new decvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.abarr swizzling (equivalent to decvec4.wzwxx).
        /// </summary>
        public decvec5 abarr => new decvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.wzwxy swizzling.
        /// </summary>
        public decvec5 wzwxy => new decvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.abarg swizzling (equivalent to decvec4.wzwxy).
        /// </summary>
        public decvec5 abarg => new decvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.wzwxz swizzling.
        /// </summary>
        public decvec5 wzwxz => new decvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.abarb swizzling (equivalent to decvec4.wzwxz).
        /// </summary>
        public decvec5 abarb => new decvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.wzwxw swizzling.
        /// </summary>
        public decvec5 wzwxw => new decvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.abara swizzling (equivalent to decvec4.wzwxw).
        /// </summary>
        public decvec5 abara => new decvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.wzwy swizzling.
        /// </summary>
        public decvec4 wzwy => new decvec4(w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.abag swizzling (equivalent to decvec4.wzwy).
        /// </summary>
        public decvec4 abag => new decvec4(w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.wzwyx swizzling.
        /// </summary>
        public decvec5 wzwyx => new decvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.abagr swizzling (equivalent to decvec4.wzwyx).
        /// </summary>
        public decvec5 abagr => new decvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.wzwyy swizzling.
        /// </summary>
        public decvec5 wzwyy => new decvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.abagg swizzling (equivalent to decvec4.wzwyy).
        /// </summary>
        public decvec5 abagg => new decvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.wzwyz swizzling.
        /// </summary>
        public decvec5 wzwyz => new decvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.abagb swizzling (equivalent to decvec4.wzwyz).
        /// </summary>
        public decvec5 abagb => new decvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.wzwyw swizzling.
        /// </summary>
        public decvec5 wzwyw => new decvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.abaga swizzling (equivalent to decvec4.wzwyw).
        /// </summary>
        public decvec5 abaga => new decvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.wzwz swizzling.
        /// </summary>
        public decvec4 wzwz => new decvec4(w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.abab swizzling (equivalent to decvec4.wzwz).
        /// </summary>
        public decvec4 abab => new decvec4(w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.wzwzx swizzling.
        /// </summary>
        public decvec5 wzwzx => new decvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.ababr swizzling (equivalent to decvec4.wzwzx).
        /// </summary>
        public decvec5 ababr => new decvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.wzwzy swizzling.
        /// </summary>
        public decvec5 wzwzy => new decvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.ababg swizzling (equivalent to decvec4.wzwzy).
        /// </summary>
        public decvec5 ababg => new decvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.wzwzz swizzling.
        /// </summary>
        public decvec5 wzwzz => new decvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.ababb swizzling (equivalent to decvec4.wzwzz).
        /// </summary>
        public decvec5 ababb => new decvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.wzwzw swizzling.
        /// </summary>
        public decvec5 wzwzw => new decvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.ababa swizzling (equivalent to decvec4.wzwzw).
        /// </summary>
        public decvec5 ababa => new decvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.wzww swizzling.
        /// </summary>
        public decvec4 wzww => new decvec4(w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.abaa swizzling (equivalent to decvec4.wzww).
        /// </summary>
        public decvec4 abaa => new decvec4(w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.wzwwx swizzling.
        /// </summary>
        public decvec5 wzwwx => new decvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.abaar swizzling (equivalent to decvec4.wzwwx).
        /// </summary>
        public decvec5 abaar => new decvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.wzwwy swizzling.
        /// </summary>
        public decvec5 wzwwy => new decvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.abaag swizzling (equivalent to decvec4.wzwwy).
        /// </summary>
        public decvec5 abaag => new decvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.wzwwz swizzling.
        /// </summary>
        public decvec5 wzwwz => new decvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.abaab swizzling (equivalent to decvec4.wzwwz).
        /// </summary>
        public decvec5 abaab => new decvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.wzwww swizzling.
        /// </summary>
        public decvec5 wzwww => new decvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.abaaa swizzling (equivalent to decvec4.wzwww).
        /// </summary>
        public decvec5 abaaa => new decvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.ww swizzling.
        /// </summary>
        public decvec2 ww => new decvec2(w, w);
        
        /// <summary>
        /// Returns decvec4.aa swizzling (equivalent to decvec4.ww).
        /// </summary>
        public decvec2 aa => new decvec2(w, w);
        
        /// <summary>
        /// Returns decvec4.wwx swizzling.
        /// </summary>
        public decvec3 wwx => new decvec3(w, w, x);
        
        /// <summary>
        /// Returns decvec4.aar swizzling (equivalent to decvec4.wwx).
        /// </summary>
        public decvec3 aar => new decvec3(w, w, x);
        
        /// <summary>
        /// Returns decvec4.wwxx swizzling.
        /// </summary>
        public decvec4 wwxx => new decvec4(w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.aarr swizzling (equivalent to decvec4.wwxx).
        /// </summary>
        public decvec4 aarr => new decvec4(w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.wwxxx swizzling.
        /// </summary>
        public decvec5 wwxxx => new decvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.aarrr swizzling (equivalent to decvec4.wwxxx).
        /// </summary>
        public decvec5 aarrr => new decvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.wwxxy swizzling.
        /// </summary>
        public decvec5 wwxxy => new decvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.aarrg swizzling (equivalent to decvec4.wwxxy).
        /// </summary>
        public decvec5 aarrg => new decvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.wwxxz swizzling.
        /// </summary>
        public decvec5 wwxxz => new decvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.aarrb swizzling (equivalent to decvec4.wwxxz).
        /// </summary>
        public decvec5 aarrb => new decvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.wwxxw swizzling.
        /// </summary>
        public decvec5 wwxxw => new decvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.aarra swizzling (equivalent to decvec4.wwxxw).
        /// </summary>
        public decvec5 aarra => new decvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.wwxy swizzling.
        /// </summary>
        public decvec4 wwxy => new decvec4(w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.aarg swizzling (equivalent to decvec4.wwxy).
        /// </summary>
        public decvec4 aarg => new decvec4(w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.wwxyx swizzling.
        /// </summary>
        public decvec5 wwxyx => new decvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.aargr swizzling (equivalent to decvec4.wwxyx).
        /// </summary>
        public decvec5 aargr => new decvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.wwxyy swizzling.
        /// </summary>
        public decvec5 wwxyy => new decvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.aargg swizzling (equivalent to decvec4.wwxyy).
        /// </summary>
        public decvec5 aargg => new decvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.wwxyz swizzling.
        /// </summary>
        public decvec5 wwxyz => new decvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.aargb swizzling (equivalent to decvec4.wwxyz).
        /// </summary>
        public decvec5 aargb => new decvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.wwxyw swizzling.
        /// </summary>
        public decvec5 wwxyw => new decvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.aarga swizzling (equivalent to decvec4.wwxyw).
        /// </summary>
        public decvec5 aarga => new decvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.wwxz swizzling.
        /// </summary>
        public decvec4 wwxz => new decvec4(w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.aarb swizzling (equivalent to decvec4.wwxz).
        /// </summary>
        public decvec4 aarb => new decvec4(w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.wwxzx swizzling.
        /// </summary>
        public decvec5 wwxzx => new decvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.aarbr swizzling (equivalent to decvec4.wwxzx).
        /// </summary>
        public decvec5 aarbr => new decvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.wwxzy swizzling.
        /// </summary>
        public decvec5 wwxzy => new decvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.aarbg swizzling (equivalent to decvec4.wwxzy).
        /// </summary>
        public decvec5 aarbg => new decvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.wwxzz swizzling.
        /// </summary>
        public decvec5 wwxzz => new decvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.aarbb swizzling (equivalent to decvec4.wwxzz).
        /// </summary>
        public decvec5 aarbb => new decvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.wwxzw swizzling.
        /// </summary>
        public decvec5 wwxzw => new decvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.aarba swizzling (equivalent to decvec4.wwxzw).
        /// </summary>
        public decvec5 aarba => new decvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.wwxw swizzling.
        /// </summary>
        public decvec4 wwxw => new decvec4(w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.aara swizzling (equivalent to decvec4.wwxw).
        /// </summary>
        public decvec4 aara => new decvec4(w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.wwxwx swizzling.
        /// </summary>
        public decvec5 wwxwx => new decvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.aarar swizzling (equivalent to decvec4.wwxwx).
        /// </summary>
        public decvec5 aarar => new decvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.wwxwy swizzling.
        /// </summary>
        public decvec5 wwxwy => new decvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.aarag swizzling (equivalent to decvec4.wwxwy).
        /// </summary>
        public decvec5 aarag => new decvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.wwxwz swizzling.
        /// </summary>
        public decvec5 wwxwz => new decvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.aarab swizzling (equivalent to decvec4.wwxwz).
        /// </summary>
        public decvec5 aarab => new decvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.wwxww swizzling.
        /// </summary>
        public decvec5 wwxww => new decvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.aaraa swizzling (equivalent to decvec4.wwxww).
        /// </summary>
        public decvec5 aaraa => new decvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.wwy swizzling.
        /// </summary>
        public decvec3 wwy => new decvec3(w, w, y);
        
        /// <summary>
        /// Returns decvec4.aag swizzling (equivalent to decvec4.wwy).
        /// </summary>
        public decvec3 aag => new decvec3(w, w, y);
        
        /// <summary>
        /// Returns decvec4.wwyx swizzling.
        /// </summary>
        public decvec4 wwyx => new decvec4(w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.aagr swizzling (equivalent to decvec4.wwyx).
        /// </summary>
        public decvec4 aagr => new decvec4(w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.wwyxx swizzling.
        /// </summary>
        public decvec5 wwyxx => new decvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.aagrr swizzling (equivalent to decvec4.wwyxx).
        /// </summary>
        public decvec5 aagrr => new decvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.wwyxy swizzling.
        /// </summary>
        public decvec5 wwyxy => new decvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.aagrg swizzling (equivalent to decvec4.wwyxy).
        /// </summary>
        public decvec5 aagrg => new decvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.wwyxz swizzling.
        /// </summary>
        public decvec5 wwyxz => new decvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.aagrb swizzling (equivalent to decvec4.wwyxz).
        /// </summary>
        public decvec5 aagrb => new decvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.wwyxw swizzling.
        /// </summary>
        public decvec5 wwyxw => new decvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.aagra swizzling (equivalent to decvec4.wwyxw).
        /// </summary>
        public decvec5 aagra => new decvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.wwyy swizzling.
        /// </summary>
        public decvec4 wwyy => new decvec4(w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.aagg swizzling (equivalent to decvec4.wwyy).
        /// </summary>
        public decvec4 aagg => new decvec4(w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.wwyyx swizzling.
        /// </summary>
        public decvec5 wwyyx => new decvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.aaggr swizzling (equivalent to decvec4.wwyyx).
        /// </summary>
        public decvec5 aaggr => new decvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.wwyyy swizzling.
        /// </summary>
        public decvec5 wwyyy => new decvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.aaggg swizzling (equivalent to decvec4.wwyyy).
        /// </summary>
        public decvec5 aaggg => new decvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.wwyyz swizzling.
        /// </summary>
        public decvec5 wwyyz => new decvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.aaggb swizzling (equivalent to decvec4.wwyyz).
        /// </summary>
        public decvec5 aaggb => new decvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.wwyyw swizzling.
        /// </summary>
        public decvec5 wwyyw => new decvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.aagga swizzling (equivalent to decvec4.wwyyw).
        /// </summary>
        public decvec5 aagga => new decvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.wwyz swizzling.
        /// </summary>
        public decvec4 wwyz => new decvec4(w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.aagb swizzling (equivalent to decvec4.wwyz).
        /// </summary>
        public decvec4 aagb => new decvec4(w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.wwyzx swizzling.
        /// </summary>
        public decvec5 wwyzx => new decvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.aagbr swizzling (equivalent to decvec4.wwyzx).
        /// </summary>
        public decvec5 aagbr => new decvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.wwyzy swizzling.
        /// </summary>
        public decvec5 wwyzy => new decvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.aagbg swizzling (equivalent to decvec4.wwyzy).
        /// </summary>
        public decvec5 aagbg => new decvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.wwyzz swizzling.
        /// </summary>
        public decvec5 wwyzz => new decvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.aagbb swizzling (equivalent to decvec4.wwyzz).
        /// </summary>
        public decvec5 aagbb => new decvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.wwyzw swizzling.
        /// </summary>
        public decvec5 wwyzw => new decvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.aagba swizzling (equivalent to decvec4.wwyzw).
        /// </summary>
        public decvec5 aagba => new decvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.wwyw swizzling.
        /// </summary>
        public decvec4 wwyw => new decvec4(w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.aaga swizzling (equivalent to decvec4.wwyw).
        /// </summary>
        public decvec4 aaga => new decvec4(w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.wwywx swizzling.
        /// </summary>
        public decvec5 wwywx => new decvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.aagar swizzling (equivalent to decvec4.wwywx).
        /// </summary>
        public decvec5 aagar => new decvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.wwywy swizzling.
        /// </summary>
        public decvec5 wwywy => new decvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.aagag swizzling (equivalent to decvec4.wwywy).
        /// </summary>
        public decvec5 aagag => new decvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.wwywz swizzling.
        /// </summary>
        public decvec5 wwywz => new decvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.aagab swizzling (equivalent to decvec4.wwywz).
        /// </summary>
        public decvec5 aagab => new decvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.wwyww swizzling.
        /// </summary>
        public decvec5 wwyww => new decvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.aagaa swizzling (equivalent to decvec4.wwyww).
        /// </summary>
        public decvec5 aagaa => new decvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.wwz swizzling.
        /// </summary>
        public decvec3 wwz => new decvec3(w, w, z);
        
        /// <summary>
        /// Returns decvec4.aab swizzling (equivalent to decvec4.wwz).
        /// </summary>
        public decvec3 aab => new decvec3(w, w, z);
        
        /// <summary>
        /// Returns decvec4.wwzx swizzling.
        /// </summary>
        public decvec4 wwzx => new decvec4(w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.aabr swizzling (equivalent to decvec4.wwzx).
        /// </summary>
        public decvec4 aabr => new decvec4(w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.wwzxx swizzling.
        /// </summary>
        public decvec5 wwzxx => new decvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.aabrr swizzling (equivalent to decvec4.wwzxx).
        /// </summary>
        public decvec5 aabrr => new decvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.wwzxy swizzling.
        /// </summary>
        public decvec5 wwzxy => new decvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.aabrg swizzling (equivalent to decvec4.wwzxy).
        /// </summary>
        public decvec5 aabrg => new decvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.wwzxz swizzling.
        /// </summary>
        public decvec5 wwzxz => new decvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.aabrb swizzling (equivalent to decvec4.wwzxz).
        /// </summary>
        public decvec5 aabrb => new decvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.wwzxw swizzling.
        /// </summary>
        public decvec5 wwzxw => new decvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.aabra swizzling (equivalent to decvec4.wwzxw).
        /// </summary>
        public decvec5 aabra => new decvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.wwzy swizzling.
        /// </summary>
        public decvec4 wwzy => new decvec4(w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.aabg swizzling (equivalent to decvec4.wwzy).
        /// </summary>
        public decvec4 aabg => new decvec4(w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.wwzyx swizzling.
        /// </summary>
        public decvec5 wwzyx => new decvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.aabgr swizzling (equivalent to decvec4.wwzyx).
        /// </summary>
        public decvec5 aabgr => new decvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.wwzyy swizzling.
        /// </summary>
        public decvec5 wwzyy => new decvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.aabgg swizzling (equivalent to decvec4.wwzyy).
        /// </summary>
        public decvec5 aabgg => new decvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.wwzyz swizzling.
        /// </summary>
        public decvec5 wwzyz => new decvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.aabgb swizzling (equivalent to decvec4.wwzyz).
        /// </summary>
        public decvec5 aabgb => new decvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.wwzyw swizzling.
        /// </summary>
        public decvec5 wwzyw => new decvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.aabga swizzling (equivalent to decvec4.wwzyw).
        /// </summary>
        public decvec5 aabga => new decvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.wwzz swizzling.
        /// </summary>
        public decvec4 wwzz => new decvec4(w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.aabb swizzling (equivalent to decvec4.wwzz).
        /// </summary>
        public decvec4 aabb => new decvec4(w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.wwzzx swizzling.
        /// </summary>
        public decvec5 wwzzx => new decvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.aabbr swizzling (equivalent to decvec4.wwzzx).
        /// </summary>
        public decvec5 aabbr => new decvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.wwzzy swizzling.
        /// </summary>
        public decvec5 wwzzy => new decvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.aabbg swizzling (equivalent to decvec4.wwzzy).
        /// </summary>
        public decvec5 aabbg => new decvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.wwzzz swizzling.
        /// </summary>
        public decvec5 wwzzz => new decvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.aabbb swizzling (equivalent to decvec4.wwzzz).
        /// </summary>
        public decvec5 aabbb => new decvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.wwzzw swizzling.
        /// </summary>
        public decvec5 wwzzw => new decvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.aabba swizzling (equivalent to decvec4.wwzzw).
        /// </summary>
        public decvec5 aabba => new decvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.wwzw swizzling.
        /// </summary>
        public decvec4 wwzw => new decvec4(w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.aaba swizzling (equivalent to decvec4.wwzw).
        /// </summary>
        public decvec4 aaba => new decvec4(w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.wwzwx swizzling.
        /// </summary>
        public decvec5 wwzwx => new decvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.aabar swizzling (equivalent to decvec4.wwzwx).
        /// </summary>
        public decvec5 aabar => new decvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.wwzwy swizzling.
        /// </summary>
        public decvec5 wwzwy => new decvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.aabag swizzling (equivalent to decvec4.wwzwy).
        /// </summary>
        public decvec5 aabag => new decvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.wwzwz swizzling.
        /// </summary>
        public decvec5 wwzwz => new decvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.aabab swizzling (equivalent to decvec4.wwzwz).
        /// </summary>
        public decvec5 aabab => new decvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.wwzww swizzling.
        /// </summary>
        public decvec5 wwzww => new decvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.aabaa swizzling (equivalent to decvec4.wwzww).
        /// </summary>
        public decvec5 aabaa => new decvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.www swizzling.
        /// </summary>
        public decvec3 www => new decvec3(w, w, w);
        
        /// <summary>
        /// Returns decvec4.aaa swizzling (equivalent to decvec4.www).
        /// </summary>
        public decvec3 aaa => new decvec3(w, w, w);
        
        /// <summary>
        /// Returns decvec4.wwwx swizzling.
        /// </summary>
        public decvec4 wwwx => new decvec4(w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.aaar swizzling (equivalent to decvec4.wwwx).
        /// </summary>
        public decvec4 aaar => new decvec4(w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.wwwxx swizzling.
        /// </summary>
        public decvec5 wwwxx => new decvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.aaarr swizzling (equivalent to decvec4.wwwxx).
        /// </summary>
        public decvec5 aaarr => new decvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.wwwxy swizzling.
        /// </summary>
        public decvec5 wwwxy => new decvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.aaarg swizzling (equivalent to decvec4.wwwxy).
        /// </summary>
        public decvec5 aaarg => new decvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.wwwxz swizzling.
        /// </summary>
        public decvec5 wwwxz => new decvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.aaarb swizzling (equivalent to decvec4.wwwxz).
        /// </summary>
        public decvec5 aaarb => new decvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.wwwxw swizzling.
        /// </summary>
        public decvec5 wwwxw => new decvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.aaara swizzling (equivalent to decvec4.wwwxw).
        /// </summary>
        public decvec5 aaara => new decvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.wwwy swizzling.
        /// </summary>
        public decvec4 wwwy => new decvec4(w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.aaag swizzling (equivalent to decvec4.wwwy).
        /// </summary>
        public decvec4 aaag => new decvec4(w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.wwwyx swizzling.
        /// </summary>
        public decvec5 wwwyx => new decvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.aaagr swizzling (equivalent to decvec4.wwwyx).
        /// </summary>
        public decvec5 aaagr => new decvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.wwwyy swizzling.
        /// </summary>
        public decvec5 wwwyy => new decvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.aaagg swizzling (equivalent to decvec4.wwwyy).
        /// </summary>
        public decvec5 aaagg => new decvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.wwwyz swizzling.
        /// </summary>
        public decvec5 wwwyz => new decvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.aaagb swizzling (equivalent to decvec4.wwwyz).
        /// </summary>
        public decvec5 aaagb => new decvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.wwwyw swizzling.
        /// </summary>
        public decvec5 wwwyw => new decvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.aaaga swizzling (equivalent to decvec4.wwwyw).
        /// </summary>
        public decvec5 aaaga => new decvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.wwwz swizzling.
        /// </summary>
        public decvec4 wwwz => new decvec4(w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.aaab swizzling (equivalent to decvec4.wwwz).
        /// </summary>
        public decvec4 aaab => new decvec4(w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.wwwzx swizzling.
        /// </summary>
        public decvec5 wwwzx => new decvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.aaabr swizzling (equivalent to decvec4.wwwzx).
        /// </summary>
        public decvec5 aaabr => new decvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.wwwzy swizzling.
        /// </summary>
        public decvec5 wwwzy => new decvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.aaabg swizzling (equivalent to decvec4.wwwzy).
        /// </summary>
        public decvec5 aaabg => new decvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.wwwzz swizzling.
        /// </summary>
        public decvec5 wwwzz => new decvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.aaabb swizzling (equivalent to decvec4.wwwzz).
        /// </summary>
        public decvec5 aaabb => new decvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.wwwzw swizzling.
        /// </summary>
        public decvec5 wwwzw => new decvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.aaaba swizzling (equivalent to decvec4.wwwzw).
        /// </summary>
        public decvec5 aaaba => new decvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.wwww swizzling.
        /// </summary>
        public decvec4 wwww => new decvec4(w, w, w, w);
        
        /// <summary>
        /// Returns decvec4.aaaa swizzling (equivalent to decvec4.wwww).
        /// </summary>
        public decvec4 aaaa => new decvec4(w, w, w, w);
        
        /// <summary>
        /// Returns decvec4.wwwwx swizzling.
        /// </summary>
        public decvec5 wwwwx => new decvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.aaaar swizzling (equivalent to decvec4.wwwwx).
        /// </summary>
        public decvec5 aaaar => new decvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.wwwwy swizzling.
        /// </summary>
        public decvec5 wwwwy => new decvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.aaaag swizzling (equivalent to decvec4.wwwwy).
        /// </summary>
        public decvec5 aaaag => new decvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.wwwwz swizzling.
        /// </summary>
        public decvec5 wwwwz => new decvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.aaaab swizzling (equivalent to decvec4.wwwwz).
        /// </summary>
        public decvec5 aaaab => new decvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.wwwww swizzling.
        /// </summary>
        public decvec5 wwwww => new decvec5(w, w, w, w, w);
        
        /// <summary>
        /// Returns decvec4.aaaaa swizzling (equivalent to decvec4.wwwww).
        /// </summary>
        public decvec5 aaaaa => new decvec5(w, w, w, w, w);

        #endregion

    }
}
