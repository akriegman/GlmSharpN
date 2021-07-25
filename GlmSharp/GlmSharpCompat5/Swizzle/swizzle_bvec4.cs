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
    /// Temporary vector of type bool with 4 components, used for implementing swizzling for bvec4.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_bvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly bool y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly bool z;
        
        /// <summary>
        /// w-component
        /// </summary>
        internal readonly bool w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_bvec4.
        /// </summary>
        internal swizzle_bvec4(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns bvec4.xx swizzling.
        /// </summary>
        public bvec2 xx => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec4.rr swizzling (equivalent to bvec4.xx).
        /// </summary>
        public bvec2 rr => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec4.xxx swizzling.
        /// </summary>
        public bvec3 xxx => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec4.rrr swizzling (equivalent to bvec4.xxx).
        /// </summary>
        public bvec3 rrr => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec4.xxxx swizzling.
        /// </summary>
        public bvec4 xxxx => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.rrrr swizzling (equivalent to bvec4.xxxx).
        /// </summary>
        public bvec4 rrrr => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.xxxxx swizzling.
        /// </summary>
        public bvec5 xxxxx => new bvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.rrrrr swizzling (equivalent to bvec4.xxxxx).
        /// </summary>
        public bvec5 rrrrr => new bvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.xxxxy swizzling.
        /// </summary>
        public bvec5 xxxxy => new bvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.rrrrg swizzling (equivalent to bvec4.xxxxy).
        /// </summary>
        public bvec5 rrrrg => new bvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.xxxxz swizzling.
        /// </summary>
        public bvec5 xxxxz => new bvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.rrrrb swizzling (equivalent to bvec4.xxxxz).
        /// </summary>
        public bvec5 rrrrb => new bvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.xxxxw swizzling.
        /// </summary>
        public bvec5 xxxxw => new bvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.rrrra swizzling (equivalent to bvec4.xxxxw).
        /// </summary>
        public bvec5 rrrra => new bvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.xxxy swizzling.
        /// </summary>
        public bvec4 xxxy => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.rrrg swizzling (equivalent to bvec4.xxxy).
        /// </summary>
        public bvec4 rrrg => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.xxxyx swizzling.
        /// </summary>
        public bvec5 xxxyx => new bvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.rrrgr swizzling (equivalent to bvec4.xxxyx).
        /// </summary>
        public bvec5 rrrgr => new bvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.xxxyy swizzling.
        /// </summary>
        public bvec5 xxxyy => new bvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.rrrgg swizzling (equivalent to bvec4.xxxyy).
        /// </summary>
        public bvec5 rrrgg => new bvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.xxxyz swizzling.
        /// </summary>
        public bvec5 xxxyz => new bvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.rrrgb swizzling (equivalent to bvec4.xxxyz).
        /// </summary>
        public bvec5 rrrgb => new bvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.xxxyw swizzling.
        /// </summary>
        public bvec5 xxxyw => new bvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.rrrga swizzling (equivalent to bvec4.xxxyw).
        /// </summary>
        public bvec5 rrrga => new bvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.xxxz swizzling.
        /// </summary>
        public bvec4 xxxz => new bvec4(x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.rrrb swizzling (equivalent to bvec4.xxxz).
        /// </summary>
        public bvec4 rrrb => new bvec4(x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.xxxzx swizzling.
        /// </summary>
        public bvec5 xxxzx => new bvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.rrrbr swizzling (equivalent to bvec4.xxxzx).
        /// </summary>
        public bvec5 rrrbr => new bvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.xxxzy swizzling.
        /// </summary>
        public bvec5 xxxzy => new bvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.rrrbg swizzling (equivalent to bvec4.xxxzy).
        /// </summary>
        public bvec5 rrrbg => new bvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.xxxzz swizzling.
        /// </summary>
        public bvec5 xxxzz => new bvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.rrrbb swizzling (equivalent to bvec4.xxxzz).
        /// </summary>
        public bvec5 rrrbb => new bvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.xxxzw swizzling.
        /// </summary>
        public bvec5 xxxzw => new bvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.rrrba swizzling (equivalent to bvec4.xxxzw).
        /// </summary>
        public bvec5 rrrba => new bvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.xxxw swizzling.
        /// </summary>
        public bvec4 xxxw => new bvec4(x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.rrra swizzling (equivalent to bvec4.xxxw).
        /// </summary>
        public bvec4 rrra => new bvec4(x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.xxxwx swizzling.
        /// </summary>
        public bvec5 xxxwx => new bvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.rrrar swizzling (equivalent to bvec4.xxxwx).
        /// </summary>
        public bvec5 rrrar => new bvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.xxxwy swizzling.
        /// </summary>
        public bvec5 xxxwy => new bvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.rrrag swizzling (equivalent to bvec4.xxxwy).
        /// </summary>
        public bvec5 rrrag => new bvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.xxxwz swizzling.
        /// </summary>
        public bvec5 xxxwz => new bvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.rrrab swizzling (equivalent to bvec4.xxxwz).
        /// </summary>
        public bvec5 rrrab => new bvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.xxxww swizzling.
        /// </summary>
        public bvec5 xxxww => new bvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.rrraa swizzling (equivalent to bvec4.xxxww).
        /// </summary>
        public bvec5 rrraa => new bvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.xxy swizzling.
        /// </summary>
        public bvec3 xxy => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec4.rrg swizzling (equivalent to bvec4.xxy).
        /// </summary>
        public bvec3 rrg => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec4.xxyx swizzling.
        /// </summary>
        public bvec4 xxyx => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.rrgr swizzling (equivalent to bvec4.xxyx).
        /// </summary>
        public bvec4 rrgr => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.xxyxx swizzling.
        /// </summary>
        public bvec5 xxyxx => new bvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.rrgrr swizzling (equivalent to bvec4.xxyxx).
        /// </summary>
        public bvec5 rrgrr => new bvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.xxyxy swizzling.
        /// </summary>
        public bvec5 xxyxy => new bvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.rrgrg swizzling (equivalent to bvec4.xxyxy).
        /// </summary>
        public bvec5 rrgrg => new bvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.xxyxz swizzling.
        /// </summary>
        public bvec5 xxyxz => new bvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.rrgrb swizzling (equivalent to bvec4.xxyxz).
        /// </summary>
        public bvec5 rrgrb => new bvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.xxyxw swizzling.
        /// </summary>
        public bvec5 xxyxw => new bvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.rrgra swizzling (equivalent to bvec4.xxyxw).
        /// </summary>
        public bvec5 rrgra => new bvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.xxyy swizzling.
        /// </summary>
        public bvec4 xxyy => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.rrgg swizzling (equivalent to bvec4.xxyy).
        /// </summary>
        public bvec4 rrgg => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.xxyyx swizzling.
        /// </summary>
        public bvec5 xxyyx => new bvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.rrggr swizzling (equivalent to bvec4.xxyyx).
        /// </summary>
        public bvec5 rrggr => new bvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.xxyyy swizzling.
        /// </summary>
        public bvec5 xxyyy => new bvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.rrggg swizzling (equivalent to bvec4.xxyyy).
        /// </summary>
        public bvec5 rrggg => new bvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.xxyyz swizzling.
        /// </summary>
        public bvec5 xxyyz => new bvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.rrggb swizzling (equivalent to bvec4.xxyyz).
        /// </summary>
        public bvec5 rrggb => new bvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.xxyyw swizzling.
        /// </summary>
        public bvec5 xxyyw => new bvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.rrgga swizzling (equivalent to bvec4.xxyyw).
        /// </summary>
        public bvec5 rrgga => new bvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.xxyz swizzling.
        /// </summary>
        public bvec4 xxyz => new bvec4(x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.rrgb swizzling (equivalent to bvec4.xxyz).
        /// </summary>
        public bvec4 rrgb => new bvec4(x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.xxyzx swizzling.
        /// </summary>
        public bvec5 xxyzx => new bvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.rrgbr swizzling (equivalent to bvec4.xxyzx).
        /// </summary>
        public bvec5 rrgbr => new bvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.xxyzy swizzling.
        /// </summary>
        public bvec5 xxyzy => new bvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.rrgbg swizzling (equivalent to bvec4.xxyzy).
        /// </summary>
        public bvec5 rrgbg => new bvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.xxyzz swizzling.
        /// </summary>
        public bvec5 xxyzz => new bvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.rrgbb swizzling (equivalent to bvec4.xxyzz).
        /// </summary>
        public bvec5 rrgbb => new bvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.xxyzw swizzling.
        /// </summary>
        public bvec5 xxyzw => new bvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.rrgba swizzling (equivalent to bvec4.xxyzw).
        /// </summary>
        public bvec5 rrgba => new bvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.xxyw swizzling.
        /// </summary>
        public bvec4 xxyw => new bvec4(x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.rrga swizzling (equivalent to bvec4.xxyw).
        /// </summary>
        public bvec4 rrga => new bvec4(x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.xxywx swizzling.
        /// </summary>
        public bvec5 xxywx => new bvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.rrgar swizzling (equivalent to bvec4.xxywx).
        /// </summary>
        public bvec5 rrgar => new bvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.xxywy swizzling.
        /// </summary>
        public bvec5 xxywy => new bvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.rrgag swizzling (equivalent to bvec4.xxywy).
        /// </summary>
        public bvec5 rrgag => new bvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.xxywz swizzling.
        /// </summary>
        public bvec5 xxywz => new bvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.rrgab swizzling (equivalent to bvec4.xxywz).
        /// </summary>
        public bvec5 rrgab => new bvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.xxyww swizzling.
        /// </summary>
        public bvec5 xxyww => new bvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.rrgaa swizzling (equivalent to bvec4.xxyww).
        /// </summary>
        public bvec5 rrgaa => new bvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.xxz swizzling.
        /// </summary>
        public bvec3 xxz => new bvec3(x, x, z);
        
        /// <summary>
        /// Returns bvec4.rrb swizzling (equivalent to bvec4.xxz).
        /// </summary>
        public bvec3 rrb => new bvec3(x, x, z);
        
        /// <summary>
        /// Returns bvec4.xxzx swizzling.
        /// </summary>
        public bvec4 xxzx => new bvec4(x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.rrbr swizzling (equivalent to bvec4.xxzx).
        /// </summary>
        public bvec4 rrbr => new bvec4(x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.xxzxx swizzling.
        /// </summary>
        public bvec5 xxzxx => new bvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.rrbrr swizzling (equivalent to bvec4.xxzxx).
        /// </summary>
        public bvec5 rrbrr => new bvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.xxzxy swizzling.
        /// </summary>
        public bvec5 xxzxy => new bvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.rrbrg swizzling (equivalent to bvec4.xxzxy).
        /// </summary>
        public bvec5 rrbrg => new bvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.xxzxz swizzling.
        /// </summary>
        public bvec5 xxzxz => new bvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.rrbrb swizzling (equivalent to bvec4.xxzxz).
        /// </summary>
        public bvec5 rrbrb => new bvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.xxzxw swizzling.
        /// </summary>
        public bvec5 xxzxw => new bvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.rrbra swizzling (equivalent to bvec4.xxzxw).
        /// </summary>
        public bvec5 rrbra => new bvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.xxzy swizzling.
        /// </summary>
        public bvec4 xxzy => new bvec4(x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.rrbg swizzling (equivalent to bvec4.xxzy).
        /// </summary>
        public bvec4 rrbg => new bvec4(x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.xxzyx swizzling.
        /// </summary>
        public bvec5 xxzyx => new bvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.rrbgr swizzling (equivalent to bvec4.xxzyx).
        /// </summary>
        public bvec5 rrbgr => new bvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.xxzyy swizzling.
        /// </summary>
        public bvec5 xxzyy => new bvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.rrbgg swizzling (equivalent to bvec4.xxzyy).
        /// </summary>
        public bvec5 rrbgg => new bvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.xxzyz swizzling.
        /// </summary>
        public bvec5 xxzyz => new bvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.rrbgb swizzling (equivalent to bvec4.xxzyz).
        /// </summary>
        public bvec5 rrbgb => new bvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.xxzyw swizzling.
        /// </summary>
        public bvec5 xxzyw => new bvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.rrbga swizzling (equivalent to bvec4.xxzyw).
        /// </summary>
        public bvec5 rrbga => new bvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.xxzz swizzling.
        /// </summary>
        public bvec4 xxzz => new bvec4(x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.rrbb swizzling (equivalent to bvec4.xxzz).
        /// </summary>
        public bvec4 rrbb => new bvec4(x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.xxzzx swizzling.
        /// </summary>
        public bvec5 xxzzx => new bvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.rrbbr swizzling (equivalent to bvec4.xxzzx).
        /// </summary>
        public bvec5 rrbbr => new bvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.xxzzy swizzling.
        /// </summary>
        public bvec5 xxzzy => new bvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.rrbbg swizzling (equivalent to bvec4.xxzzy).
        /// </summary>
        public bvec5 rrbbg => new bvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.xxzzz swizzling.
        /// </summary>
        public bvec5 xxzzz => new bvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.rrbbb swizzling (equivalent to bvec4.xxzzz).
        /// </summary>
        public bvec5 rrbbb => new bvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.xxzzw swizzling.
        /// </summary>
        public bvec5 xxzzw => new bvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.rrbba swizzling (equivalent to bvec4.xxzzw).
        /// </summary>
        public bvec5 rrbba => new bvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.xxzw swizzling.
        /// </summary>
        public bvec4 xxzw => new bvec4(x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.rrba swizzling (equivalent to bvec4.xxzw).
        /// </summary>
        public bvec4 rrba => new bvec4(x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.xxzwx swizzling.
        /// </summary>
        public bvec5 xxzwx => new bvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.rrbar swizzling (equivalent to bvec4.xxzwx).
        /// </summary>
        public bvec5 rrbar => new bvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.xxzwy swizzling.
        /// </summary>
        public bvec5 xxzwy => new bvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.rrbag swizzling (equivalent to bvec4.xxzwy).
        /// </summary>
        public bvec5 rrbag => new bvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.xxzwz swizzling.
        /// </summary>
        public bvec5 xxzwz => new bvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.rrbab swizzling (equivalent to bvec4.xxzwz).
        /// </summary>
        public bvec5 rrbab => new bvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.xxzww swizzling.
        /// </summary>
        public bvec5 xxzww => new bvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.rrbaa swizzling (equivalent to bvec4.xxzww).
        /// </summary>
        public bvec5 rrbaa => new bvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.xxw swizzling.
        /// </summary>
        public bvec3 xxw => new bvec3(x, x, w);
        
        /// <summary>
        /// Returns bvec4.rra swizzling (equivalent to bvec4.xxw).
        /// </summary>
        public bvec3 rra => new bvec3(x, x, w);
        
        /// <summary>
        /// Returns bvec4.xxwx swizzling.
        /// </summary>
        public bvec4 xxwx => new bvec4(x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.rrar swizzling (equivalent to bvec4.xxwx).
        /// </summary>
        public bvec4 rrar => new bvec4(x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.xxwxx swizzling.
        /// </summary>
        public bvec5 xxwxx => new bvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.rrarr swizzling (equivalent to bvec4.xxwxx).
        /// </summary>
        public bvec5 rrarr => new bvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.xxwxy swizzling.
        /// </summary>
        public bvec5 xxwxy => new bvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.rrarg swizzling (equivalent to bvec4.xxwxy).
        /// </summary>
        public bvec5 rrarg => new bvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.xxwxz swizzling.
        /// </summary>
        public bvec5 xxwxz => new bvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.rrarb swizzling (equivalent to bvec4.xxwxz).
        /// </summary>
        public bvec5 rrarb => new bvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.xxwxw swizzling.
        /// </summary>
        public bvec5 xxwxw => new bvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.rrara swizzling (equivalent to bvec4.xxwxw).
        /// </summary>
        public bvec5 rrara => new bvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.xxwy swizzling.
        /// </summary>
        public bvec4 xxwy => new bvec4(x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.rrag swizzling (equivalent to bvec4.xxwy).
        /// </summary>
        public bvec4 rrag => new bvec4(x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.xxwyx swizzling.
        /// </summary>
        public bvec5 xxwyx => new bvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.rragr swizzling (equivalent to bvec4.xxwyx).
        /// </summary>
        public bvec5 rragr => new bvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.xxwyy swizzling.
        /// </summary>
        public bvec5 xxwyy => new bvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.rragg swizzling (equivalent to bvec4.xxwyy).
        /// </summary>
        public bvec5 rragg => new bvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.xxwyz swizzling.
        /// </summary>
        public bvec5 xxwyz => new bvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.rragb swizzling (equivalent to bvec4.xxwyz).
        /// </summary>
        public bvec5 rragb => new bvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.xxwyw swizzling.
        /// </summary>
        public bvec5 xxwyw => new bvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.rraga swizzling (equivalent to bvec4.xxwyw).
        /// </summary>
        public bvec5 rraga => new bvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.xxwz swizzling.
        /// </summary>
        public bvec4 xxwz => new bvec4(x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.rrab swizzling (equivalent to bvec4.xxwz).
        /// </summary>
        public bvec4 rrab => new bvec4(x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.xxwzx swizzling.
        /// </summary>
        public bvec5 xxwzx => new bvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.rrabr swizzling (equivalent to bvec4.xxwzx).
        /// </summary>
        public bvec5 rrabr => new bvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.xxwzy swizzling.
        /// </summary>
        public bvec5 xxwzy => new bvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.rrabg swizzling (equivalent to bvec4.xxwzy).
        /// </summary>
        public bvec5 rrabg => new bvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.xxwzz swizzling.
        /// </summary>
        public bvec5 xxwzz => new bvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.rrabb swizzling (equivalent to bvec4.xxwzz).
        /// </summary>
        public bvec5 rrabb => new bvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.xxwzw swizzling.
        /// </summary>
        public bvec5 xxwzw => new bvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.rraba swizzling (equivalent to bvec4.xxwzw).
        /// </summary>
        public bvec5 rraba => new bvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.xxww swizzling.
        /// </summary>
        public bvec4 xxww => new bvec4(x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.rraa swizzling (equivalent to bvec4.xxww).
        /// </summary>
        public bvec4 rraa => new bvec4(x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.xxwwx swizzling.
        /// </summary>
        public bvec5 xxwwx => new bvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.rraar swizzling (equivalent to bvec4.xxwwx).
        /// </summary>
        public bvec5 rraar => new bvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.xxwwy swizzling.
        /// </summary>
        public bvec5 xxwwy => new bvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.rraag swizzling (equivalent to bvec4.xxwwy).
        /// </summary>
        public bvec5 rraag => new bvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.xxwwz swizzling.
        /// </summary>
        public bvec5 xxwwz => new bvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.rraab swizzling (equivalent to bvec4.xxwwz).
        /// </summary>
        public bvec5 rraab => new bvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.xxwww swizzling.
        /// </summary>
        public bvec5 xxwww => new bvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.rraaa swizzling (equivalent to bvec4.xxwww).
        /// </summary>
        public bvec5 rraaa => new bvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.xy swizzling.
        /// </summary>
        public bvec2 xy => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec4.rg swizzling (equivalent to bvec4.xy).
        /// </summary>
        public bvec2 rg => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec4.xyx swizzling.
        /// </summary>
        public bvec3 xyx => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec4.rgr swizzling (equivalent to bvec4.xyx).
        /// </summary>
        public bvec3 rgr => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec4.xyxx swizzling.
        /// </summary>
        public bvec4 xyxx => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.rgrr swizzling (equivalent to bvec4.xyxx).
        /// </summary>
        public bvec4 rgrr => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.xyxxx swizzling.
        /// </summary>
        public bvec5 xyxxx => new bvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.rgrrr swizzling (equivalent to bvec4.xyxxx).
        /// </summary>
        public bvec5 rgrrr => new bvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.xyxxy swizzling.
        /// </summary>
        public bvec5 xyxxy => new bvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.rgrrg swizzling (equivalent to bvec4.xyxxy).
        /// </summary>
        public bvec5 rgrrg => new bvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.xyxxz swizzling.
        /// </summary>
        public bvec5 xyxxz => new bvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.rgrrb swizzling (equivalent to bvec4.xyxxz).
        /// </summary>
        public bvec5 rgrrb => new bvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.xyxxw swizzling.
        /// </summary>
        public bvec5 xyxxw => new bvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.rgrra swizzling (equivalent to bvec4.xyxxw).
        /// </summary>
        public bvec5 rgrra => new bvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.xyxy swizzling.
        /// </summary>
        public bvec4 xyxy => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.rgrg swizzling (equivalent to bvec4.xyxy).
        /// </summary>
        public bvec4 rgrg => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.xyxyx swizzling.
        /// </summary>
        public bvec5 xyxyx => new bvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.rgrgr swizzling (equivalent to bvec4.xyxyx).
        /// </summary>
        public bvec5 rgrgr => new bvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.xyxyy swizzling.
        /// </summary>
        public bvec5 xyxyy => new bvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.rgrgg swizzling (equivalent to bvec4.xyxyy).
        /// </summary>
        public bvec5 rgrgg => new bvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.xyxyz swizzling.
        /// </summary>
        public bvec5 xyxyz => new bvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.rgrgb swizzling (equivalent to bvec4.xyxyz).
        /// </summary>
        public bvec5 rgrgb => new bvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.xyxyw swizzling.
        /// </summary>
        public bvec5 xyxyw => new bvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.rgrga swizzling (equivalent to bvec4.xyxyw).
        /// </summary>
        public bvec5 rgrga => new bvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.xyxz swizzling.
        /// </summary>
        public bvec4 xyxz => new bvec4(x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.rgrb swizzling (equivalent to bvec4.xyxz).
        /// </summary>
        public bvec4 rgrb => new bvec4(x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.xyxzx swizzling.
        /// </summary>
        public bvec5 xyxzx => new bvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.rgrbr swizzling (equivalent to bvec4.xyxzx).
        /// </summary>
        public bvec5 rgrbr => new bvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.xyxzy swizzling.
        /// </summary>
        public bvec5 xyxzy => new bvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.rgrbg swizzling (equivalent to bvec4.xyxzy).
        /// </summary>
        public bvec5 rgrbg => new bvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.xyxzz swizzling.
        /// </summary>
        public bvec5 xyxzz => new bvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.rgrbb swizzling (equivalent to bvec4.xyxzz).
        /// </summary>
        public bvec5 rgrbb => new bvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.xyxzw swizzling.
        /// </summary>
        public bvec5 xyxzw => new bvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.rgrba swizzling (equivalent to bvec4.xyxzw).
        /// </summary>
        public bvec5 rgrba => new bvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.xyxw swizzling.
        /// </summary>
        public bvec4 xyxw => new bvec4(x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.rgra swizzling (equivalent to bvec4.xyxw).
        /// </summary>
        public bvec4 rgra => new bvec4(x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.xyxwx swizzling.
        /// </summary>
        public bvec5 xyxwx => new bvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.rgrar swizzling (equivalent to bvec4.xyxwx).
        /// </summary>
        public bvec5 rgrar => new bvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.xyxwy swizzling.
        /// </summary>
        public bvec5 xyxwy => new bvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.rgrag swizzling (equivalent to bvec4.xyxwy).
        /// </summary>
        public bvec5 rgrag => new bvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.xyxwz swizzling.
        /// </summary>
        public bvec5 xyxwz => new bvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.rgrab swizzling (equivalent to bvec4.xyxwz).
        /// </summary>
        public bvec5 rgrab => new bvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.xyxww swizzling.
        /// </summary>
        public bvec5 xyxww => new bvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.rgraa swizzling (equivalent to bvec4.xyxww).
        /// </summary>
        public bvec5 rgraa => new bvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.xyy swizzling.
        /// </summary>
        public bvec3 xyy => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec4.rgg swizzling (equivalent to bvec4.xyy).
        /// </summary>
        public bvec3 rgg => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec4.xyyx swizzling.
        /// </summary>
        public bvec4 xyyx => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.rggr swizzling (equivalent to bvec4.xyyx).
        /// </summary>
        public bvec4 rggr => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.xyyxx swizzling.
        /// </summary>
        public bvec5 xyyxx => new bvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.rggrr swizzling (equivalent to bvec4.xyyxx).
        /// </summary>
        public bvec5 rggrr => new bvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.xyyxy swizzling.
        /// </summary>
        public bvec5 xyyxy => new bvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.rggrg swizzling (equivalent to bvec4.xyyxy).
        /// </summary>
        public bvec5 rggrg => new bvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.xyyxz swizzling.
        /// </summary>
        public bvec5 xyyxz => new bvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.rggrb swizzling (equivalent to bvec4.xyyxz).
        /// </summary>
        public bvec5 rggrb => new bvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.xyyxw swizzling.
        /// </summary>
        public bvec5 xyyxw => new bvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.rggra swizzling (equivalent to bvec4.xyyxw).
        /// </summary>
        public bvec5 rggra => new bvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.xyyy swizzling.
        /// </summary>
        public bvec4 xyyy => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.rggg swizzling (equivalent to bvec4.xyyy).
        /// </summary>
        public bvec4 rggg => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.xyyyx swizzling.
        /// </summary>
        public bvec5 xyyyx => new bvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.rgggr swizzling (equivalent to bvec4.xyyyx).
        /// </summary>
        public bvec5 rgggr => new bvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.xyyyy swizzling.
        /// </summary>
        public bvec5 xyyyy => new bvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.rgggg swizzling (equivalent to bvec4.xyyyy).
        /// </summary>
        public bvec5 rgggg => new bvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.xyyyz swizzling.
        /// </summary>
        public bvec5 xyyyz => new bvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.rgggb swizzling (equivalent to bvec4.xyyyz).
        /// </summary>
        public bvec5 rgggb => new bvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.xyyyw swizzling.
        /// </summary>
        public bvec5 xyyyw => new bvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.rggga swizzling (equivalent to bvec4.xyyyw).
        /// </summary>
        public bvec5 rggga => new bvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.xyyz swizzling.
        /// </summary>
        public bvec4 xyyz => new bvec4(x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.rggb swizzling (equivalent to bvec4.xyyz).
        /// </summary>
        public bvec4 rggb => new bvec4(x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.xyyzx swizzling.
        /// </summary>
        public bvec5 xyyzx => new bvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.rggbr swizzling (equivalent to bvec4.xyyzx).
        /// </summary>
        public bvec5 rggbr => new bvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.xyyzy swizzling.
        /// </summary>
        public bvec5 xyyzy => new bvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.rggbg swizzling (equivalent to bvec4.xyyzy).
        /// </summary>
        public bvec5 rggbg => new bvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.xyyzz swizzling.
        /// </summary>
        public bvec5 xyyzz => new bvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.rggbb swizzling (equivalent to bvec4.xyyzz).
        /// </summary>
        public bvec5 rggbb => new bvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.xyyzw swizzling.
        /// </summary>
        public bvec5 xyyzw => new bvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.rggba swizzling (equivalent to bvec4.xyyzw).
        /// </summary>
        public bvec5 rggba => new bvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.xyyw swizzling.
        /// </summary>
        public bvec4 xyyw => new bvec4(x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.rgga swizzling (equivalent to bvec4.xyyw).
        /// </summary>
        public bvec4 rgga => new bvec4(x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.xyywx swizzling.
        /// </summary>
        public bvec5 xyywx => new bvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.rggar swizzling (equivalent to bvec4.xyywx).
        /// </summary>
        public bvec5 rggar => new bvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.xyywy swizzling.
        /// </summary>
        public bvec5 xyywy => new bvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.rggag swizzling (equivalent to bvec4.xyywy).
        /// </summary>
        public bvec5 rggag => new bvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.xyywz swizzling.
        /// </summary>
        public bvec5 xyywz => new bvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.rggab swizzling (equivalent to bvec4.xyywz).
        /// </summary>
        public bvec5 rggab => new bvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.xyyww swizzling.
        /// </summary>
        public bvec5 xyyww => new bvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.rggaa swizzling (equivalent to bvec4.xyyww).
        /// </summary>
        public bvec5 rggaa => new bvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.xyz swizzling.
        /// </summary>
        public bvec3 xyz => new bvec3(x, y, z);
        
        /// <summary>
        /// Returns bvec4.rgb swizzling (equivalent to bvec4.xyz).
        /// </summary>
        public bvec3 rgb => new bvec3(x, y, z);
        
        /// <summary>
        /// Returns bvec4.xyzx swizzling.
        /// </summary>
        public bvec4 xyzx => new bvec4(x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.rgbr swizzling (equivalent to bvec4.xyzx).
        /// </summary>
        public bvec4 rgbr => new bvec4(x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.xyzxx swizzling.
        /// </summary>
        public bvec5 xyzxx => new bvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.rgbrr swizzling (equivalent to bvec4.xyzxx).
        /// </summary>
        public bvec5 rgbrr => new bvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.xyzxy swizzling.
        /// </summary>
        public bvec5 xyzxy => new bvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.rgbrg swizzling (equivalent to bvec4.xyzxy).
        /// </summary>
        public bvec5 rgbrg => new bvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.xyzxz swizzling.
        /// </summary>
        public bvec5 xyzxz => new bvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.rgbrb swizzling (equivalent to bvec4.xyzxz).
        /// </summary>
        public bvec5 rgbrb => new bvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.xyzxw swizzling.
        /// </summary>
        public bvec5 xyzxw => new bvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.rgbra swizzling (equivalent to bvec4.xyzxw).
        /// </summary>
        public bvec5 rgbra => new bvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.xyzy swizzling.
        /// </summary>
        public bvec4 xyzy => new bvec4(x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.rgbg swizzling (equivalent to bvec4.xyzy).
        /// </summary>
        public bvec4 rgbg => new bvec4(x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.xyzyx swizzling.
        /// </summary>
        public bvec5 xyzyx => new bvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.rgbgr swizzling (equivalent to bvec4.xyzyx).
        /// </summary>
        public bvec5 rgbgr => new bvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.xyzyy swizzling.
        /// </summary>
        public bvec5 xyzyy => new bvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.rgbgg swizzling (equivalent to bvec4.xyzyy).
        /// </summary>
        public bvec5 rgbgg => new bvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.xyzyz swizzling.
        /// </summary>
        public bvec5 xyzyz => new bvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.rgbgb swizzling (equivalent to bvec4.xyzyz).
        /// </summary>
        public bvec5 rgbgb => new bvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.xyzyw swizzling.
        /// </summary>
        public bvec5 xyzyw => new bvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.rgbga swizzling (equivalent to bvec4.xyzyw).
        /// </summary>
        public bvec5 rgbga => new bvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.xyzz swizzling.
        /// </summary>
        public bvec4 xyzz => new bvec4(x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.rgbb swizzling (equivalent to bvec4.xyzz).
        /// </summary>
        public bvec4 rgbb => new bvec4(x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.xyzzx swizzling.
        /// </summary>
        public bvec5 xyzzx => new bvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.rgbbr swizzling (equivalent to bvec4.xyzzx).
        /// </summary>
        public bvec5 rgbbr => new bvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.xyzzy swizzling.
        /// </summary>
        public bvec5 xyzzy => new bvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.rgbbg swizzling (equivalent to bvec4.xyzzy).
        /// </summary>
        public bvec5 rgbbg => new bvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.xyzzz swizzling.
        /// </summary>
        public bvec5 xyzzz => new bvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.rgbbb swizzling (equivalent to bvec4.xyzzz).
        /// </summary>
        public bvec5 rgbbb => new bvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.xyzzw swizzling.
        /// </summary>
        public bvec5 xyzzw => new bvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.rgbba swizzling (equivalent to bvec4.xyzzw).
        /// </summary>
        public bvec5 rgbba => new bvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.xyzw swizzling.
        /// </summary>
        public bvec4 xyzw => new bvec4(x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.rgba swizzling (equivalent to bvec4.xyzw).
        /// </summary>
        public bvec4 rgba => new bvec4(x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.xyzwx swizzling.
        /// </summary>
        public bvec5 xyzwx => new bvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.rgbar swizzling (equivalent to bvec4.xyzwx).
        /// </summary>
        public bvec5 rgbar => new bvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.xyzwy swizzling.
        /// </summary>
        public bvec5 xyzwy => new bvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.rgbag swizzling (equivalent to bvec4.xyzwy).
        /// </summary>
        public bvec5 rgbag => new bvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.xyzwz swizzling.
        /// </summary>
        public bvec5 xyzwz => new bvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.rgbab swizzling (equivalent to bvec4.xyzwz).
        /// </summary>
        public bvec5 rgbab => new bvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.xyzww swizzling.
        /// </summary>
        public bvec5 xyzww => new bvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.rgbaa swizzling (equivalent to bvec4.xyzww).
        /// </summary>
        public bvec5 rgbaa => new bvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.xyw swizzling.
        /// </summary>
        public bvec3 xyw => new bvec3(x, y, w);
        
        /// <summary>
        /// Returns bvec4.rga swizzling (equivalent to bvec4.xyw).
        /// </summary>
        public bvec3 rga => new bvec3(x, y, w);
        
        /// <summary>
        /// Returns bvec4.xywx swizzling.
        /// </summary>
        public bvec4 xywx => new bvec4(x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.rgar swizzling (equivalent to bvec4.xywx).
        /// </summary>
        public bvec4 rgar => new bvec4(x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.xywxx swizzling.
        /// </summary>
        public bvec5 xywxx => new bvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.rgarr swizzling (equivalent to bvec4.xywxx).
        /// </summary>
        public bvec5 rgarr => new bvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.xywxy swizzling.
        /// </summary>
        public bvec5 xywxy => new bvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.rgarg swizzling (equivalent to bvec4.xywxy).
        /// </summary>
        public bvec5 rgarg => new bvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.xywxz swizzling.
        /// </summary>
        public bvec5 xywxz => new bvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.rgarb swizzling (equivalent to bvec4.xywxz).
        /// </summary>
        public bvec5 rgarb => new bvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.xywxw swizzling.
        /// </summary>
        public bvec5 xywxw => new bvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.rgara swizzling (equivalent to bvec4.xywxw).
        /// </summary>
        public bvec5 rgara => new bvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.xywy swizzling.
        /// </summary>
        public bvec4 xywy => new bvec4(x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.rgag swizzling (equivalent to bvec4.xywy).
        /// </summary>
        public bvec4 rgag => new bvec4(x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.xywyx swizzling.
        /// </summary>
        public bvec5 xywyx => new bvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.rgagr swizzling (equivalent to bvec4.xywyx).
        /// </summary>
        public bvec5 rgagr => new bvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.xywyy swizzling.
        /// </summary>
        public bvec5 xywyy => new bvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.rgagg swizzling (equivalent to bvec4.xywyy).
        /// </summary>
        public bvec5 rgagg => new bvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.xywyz swizzling.
        /// </summary>
        public bvec5 xywyz => new bvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.rgagb swizzling (equivalent to bvec4.xywyz).
        /// </summary>
        public bvec5 rgagb => new bvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.xywyw swizzling.
        /// </summary>
        public bvec5 xywyw => new bvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.rgaga swizzling (equivalent to bvec4.xywyw).
        /// </summary>
        public bvec5 rgaga => new bvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.xywz swizzling.
        /// </summary>
        public bvec4 xywz => new bvec4(x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.rgab swizzling (equivalent to bvec4.xywz).
        /// </summary>
        public bvec4 rgab => new bvec4(x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.xywzx swizzling.
        /// </summary>
        public bvec5 xywzx => new bvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.rgabr swizzling (equivalent to bvec4.xywzx).
        /// </summary>
        public bvec5 rgabr => new bvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.xywzy swizzling.
        /// </summary>
        public bvec5 xywzy => new bvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.rgabg swizzling (equivalent to bvec4.xywzy).
        /// </summary>
        public bvec5 rgabg => new bvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.xywzz swizzling.
        /// </summary>
        public bvec5 xywzz => new bvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.rgabb swizzling (equivalent to bvec4.xywzz).
        /// </summary>
        public bvec5 rgabb => new bvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.xywzw swizzling.
        /// </summary>
        public bvec5 xywzw => new bvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.rgaba swizzling (equivalent to bvec4.xywzw).
        /// </summary>
        public bvec5 rgaba => new bvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.xyww swizzling.
        /// </summary>
        public bvec4 xyww => new bvec4(x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.rgaa swizzling (equivalent to bvec4.xyww).
        /// </summary>
        public bvec4 rgaa => new bvec4(x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.xywwx swizzling.
        /// </summary>
        public bvec5 xywwx => new bvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.rgaar swizzling (equivalent to bvec4.xywwx).
        /// </summary>
        public bvec5 rgaar => new bvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.xywwy swizzling.
        /// </summary>
        public bvec5 xywwy => new bvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.rgaag swizzling (equivalent to bvec4.xywwy).
        /// </summary>
        public bvec5 rgaag => new bvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.xywwz swizzling.
        /// </summary>
        public bvec5 xywwz => new bvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.rgaab swizzling (equivalent to bvec4.xywwz).
        /// </summary>
        public bvec5 rgaab => new bvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.xywww swizzling.
        /// </summary>
        public bvec5 xywww => new bvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.rgaaa swizzling (equivalent to bvec4.xywww).
        /// </summary>
        public bvec5 rgaaa => new bvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.xz swizzling.
        /// </summary>
        public bvec2 xz => new bvec2(x, z);
        
        /// <summary>
        /// Returns bvec4.rb swizzling (equivalent to bvec4.xz).
        /// </summary>
        public bvec2 rb => new bvec2(x, z);
        
        /// <summary>
        /// Returns bvec4.xzx swizzling.
        /// </summary>
        public bvec3 xzx => new bvec3(x, z, x);
        
        /// <summary>
        /// Returns bvec4.rbr swizzling (equivalent to bvec4.xzx).
        /// </summary>
        public bvec3 rbr => new bvec3(x, z, x);
        
        /// <summary>
        /// Returns bvec4.xzxx swizzling.
        /// </summary>
        public bvec4 xzxx => new bvec4(x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.rbrr swizzling (equivalent to bvec4.xzxx).
        /// </summary>
        public bvec4 rbrr => new bvec4(x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.xzxxx swizzling.
        /// </summary>
        public bvec5 xzxxx => new bvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.rbrrr swizzling (equivalent to bvec4.xzxxx).
        /// </summary>
        public bvec5 rbrrr => new bvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.xzxxy swizzling.
        /// </summary>
        public bvec5 xzxxy => new bvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.rbrrg swizzling (equivalent to bvec4.xzxxy).
        /// </summary>
        public bvec5 rbrrg => new bvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.xzxxz swizzling.
        /// </summary>
        public bvec5 xzxxz => new bvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.rbrrb swizzling (equivalent to bvec4.xzxxz).
        /// </summary>
        public bvec5 rbrrb => new bvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.xzxxw swizzling.
        /// </summary>
        public bvec5 xzxxw => new bvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.rbrra swizzling (equivalent to bvec4.xzxxw).
        /// </summary>
        public bvec5 rbrra => new bvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.xzxy swizzling.
        /// </summary>
        public bvec4 xzxy => new bvec4(x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.rbrg swizzling (equivalent to bvec4.xzxy).
        /// </summary>
        public bvec4 rbrg => new bvec4(x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.xzxyx swizzling.
        /// </summary>
        public bvec5 xzxyx => new bvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.rbrgr swizzling (equivalent to bvec4.xzxyx).
        /// </summary>
        public bvec5 rbrgr => new bvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.xzxyy swizzling.
        /// </summary>
        public bvec5 xzxyy => new bvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.rbrgg swizzling (equivalent to bvec4.xzxyy).
        /// </summary>
        public bvec5 rbrgg => new bvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.xzxyz swizzling.
        /// </summary>
        public bvec5 xzxyz => new bvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.rbrgb swizzling (equivalent to bvec4.xzxyz).
        /// </summary>
        public bvec5 rbrgb => new bvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.xzxyw swizzling.
        /// </summary>
        public bvec5 xzxyw => new bvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.rbrga swizzling (equivalent to bvec4.xzxyw).
        /// </summary>
        public bvec5 rbrga => new bvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.xzxz swizzling.
        /// </summary>
        public bvec4 xzxz => new bvec4(x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.rbrb swizzling (equivalent to bvec4.xzxz).
        /// </summary>
        public bvec4 rbrb => new bvec4(x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.xzxzx swizzling.
        /// </summary>
        public bvec5 xzxzx => new bvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.rbrbr swizzling (equivalent to bvec4.xzxzx).
        /// </summary>
        public bvec5 rbrbr => new bvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.xzxzy swizzling.
        /// </summary>
        public bvec5 xzxzy => new bvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.rbrbg swizzling (equivalent to bvec4.xzxzy).
        /// </summary>
        public bvec5 rbrbg => new bvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.xzxzz swizzling.
        /// </summary>
        public bvec5 xzxzz => new bvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.rbrbb swizzling (equivalent to bvec4.xzxzz).
        /// </summary>
        public bvec5 rbrbb => new bvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.xzxzw swizzling.
        /// </summary>
        public bvec5 xzxzw => new bvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.rbrba swizzling (equivalent to bvec4.xzxzw).
        /// </summary>
        public bvec5 rbrba => new bvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.xzxw swizzling.
        /// </summary>
        public bvec4 xzxw => new bvec4(x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.rbra swizzling (equivalent to bvec4.xzxw).
        /// </summary>
        public bvec4 rbra => new bvec4(x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.xzxwx swizzling.
        /// </summary>
        public bvec5 xzxwx => new bvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.rbrar swizzling (equivalent to bvec4.xzxwx).
        /// </summary>
        public bvec5 rbrar => new bvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.xzxwy swizzling.
        /// </summary>
        public bvec5 xzxwy => new bvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.rbrag swizzling (equivalent to bvec4.xzxwy).
        /// </summary>
        public bvec5 rbrag => new bvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.xzxwz swizzling.
        /// </summary>
        public bvec5 xzxwz => new bvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.rbrab swizzling (equivalent to bvec4.xzxwz).
        /// </summary>
        public bvec5 rbrab => new bvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.xzxww swizzling.
        /// </summary>
        public bvec5 xzxww => new bvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.rbraa swizzling (equivalent to bvec4.xzxww).
        /// </summary>
        public bvec5 rbraa => new bvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.xzy swizzling.
        /// </summary>
        public bvec3 xzy => new bvec3(x, z, y);
        
        /// <summary>
        /// Returns bvec4.rbg swizzling (equivalent to bvec4.xzy).
        /// </summary>
        public bvec3 rbg => new bvec3(x, z, y);
        
        /// <summary>
        /// Returns bvec4.xzyx swizzling.
        /// </summary>
        public bvec4 xzyx => new bvec4(x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.rbgr swizzling (equivalent to bvec4.xzyx).
        /// </summary>
        public bvec4 rbgr => new bvec4(x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.xzyxx swizzling.
        /// </summary>
        public bvec5 xzyxx => new bvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.rbgrr swizzling (equivalent to bvec4.xzyxx).
        /// </summary>
        public bvec5 rbgrr => new bvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.xzyxy swizzling.
        /// </summary>
        public bvec5 xzyxy => new bvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.rbgrg swizzling (equivalent to bvec4.xzyxy).
        /// </summary>
        public bvec5 rbgrg => new bvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.xzyxz swizzling.
        /// </summary>
        public bvec5 xzyxz => new bvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.rbgrb swizzling (equivalent to bvec4.xzyxz).
        /// </summary>
        public bvec5 rbgrb => new bvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.xzyxw swizzling.
        /// </summary>
        public bvec5 xzyxw => new bvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.rbgra swizzling (equivalent to bvec4.xzyxw).
        /// </summary>
        public bvec5 rbgra => new bvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.xzyy swizzling.
        /// </summary>
        public bvec4 xzyy => new bvec4(x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.rbgg swizzling (equivalent to bvec4.xzyy).
        /// </summary>
        public bvec4 rbgg => new bvec4(x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.xzyyx swizzling.
        /// </summary>
        public bvec5 xzyyx => new bvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.rbggr swizzling (equivalent to bvec4.xzyyx).
        /// </summary>
        public bvec5 rbggr => new bvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.xzyyy swizzling.
        /// </summary>
        public bvec5 xzyyy => new bvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.rbggg swizzling (equivalent to bvec4.xzyyy).
        /// </summary>
        public bvec5 rbggg => new bvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.xzyyz swizzling.
        /// </summary>
        public bvec5 xzyyz => new bvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.rbggb swizzling (equivalent to bvec4.xzyyz).
        /// </summary>
        public bvec5 rbggb => new bvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.xzyyw swizzling.
        /// </summary>
        public bvec5 xzyyw => new bvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.rbgga swizzling (equivalent to bvec4.xzyyw).
        /// </summary>
        public bvec5 rbgga => new bvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.xzyz swizzling.
        /// </summary>
        public bvec4 xzyz => new bvec4(x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.rbgb swizzling (equivalent to bvec4.xzyz).
        /// </summary>
        public bvec4 rbgb => new bvec4(x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.xzyzx swizzling.
        /// </summary>
        public bvec5 xzyzx => new bvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.rbgbr swizzling (equivalent to bvec4.xzyzx).
        /// </summary>
        public bvec5 rbgbr => new bvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.xzyzy swizzling.
        /// </summary>
        public bvec5 xzyzy => new bvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.rbgbg swizzling (equivalent to bvec4.xzyzy).
        /// </summary>
        public bvec5 rbgbg => new bvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.xzyzz swizzling.
        /// </summary>
        public bvec5 xzyzz => new bvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.rbgbb swizzling (equivalent to bvec4.xzyzz).
        /// </summary>
        public bvec5 rbgbb => new bvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.xzyzw swizzling.
        /// </summary>
        public bvec5 xzyzw => new bvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.rbgba swizzling (equivalent to bvec4.xzyzw).
        /// </summary>
        public bvec5 rbgba => new bvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.xzyw swizzling.
        /// </summary>
        public bvec4 xzyw => new bvec4(x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.rbga swizzling (equivalent to bvec4.xzyw).
        /// </summary>
        public bvec4 rbga => new bvec4(x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.xzywx swizzling.
        /// </summary>
        public bvec5 xzywx => new bvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.rbgar swizzling (equivalent to bvec4.xzywx).
        /// </summary>
        public bvec5 rbgar => new bvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.xzywy swizzling.
        /// </summary>
        public bvec5 xzywy => new bvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.rbgag swizzling (equivalent to bvec4.xzywy).
        /// </summary>
        public bvec5 rbgag => new bvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.xzywz swizzling.
        /// </summary>
        public bvec5 xzywz => new bvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.rbgab swizzling (equivalent to bvec4.xzywz).
        /// </summary>
        public bvec5 rbgab => new bvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.xzyww swizzling.
        /// </summary>
        public bvec5 xzyww => new bvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.rbgaa swizzling (equivalent to bvec4.xzyww).
        /// </summary>
        public bvec5 rbgaa => new bvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.xzz swizzling.
        /// </summary>
        public bvec3 xzz => new bvec3(x, z, z);
        
        /// <summary>
        /// Returns bvec4.rbb swizzling (equivalent to bvec4.xzz).
        /// </summary>
        public bvec3 rbb => new bvec3(x, z, z);
        
        /// <summary>
        /// Returns bvec4.xzzx swizzling.
        /// </summary>
        public bvec4 xzzx => new bvec4(x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.rbbr swizzling (equivalent to bvec4.xzzx).
        /// </summary>
        public bvec4 rbbr => new bvec4(x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.xzzxx swizzling.
        /// </summary>
        public bvec5 xzzxx => new bvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.rbbrr swizzling (equivalent to bvec4.xzzxx).
        /// </summary>
        public bvec5 rbbrr => new bvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.xzzxy swizzling.
        /// </summary>
        public bvec5 xzzxy => new bvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.rbbrg swizzling (equivalent to bvec4.xzzxy).
        /// </summary>
        public bvec5 rbbrg => new bvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.xzzxz swizzling.
        /// </summary>
        public bvec5 xzzxz => new bvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.rbbrb swizzling (equivalent to bvec4.xzzxz).
        /// </summary>
        public bvec5 rbbrb => new bvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.xzzxw swizzling.
        /// </summary>
        public bvec5 xzzxw => new bvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.rbbra swizzling (equivalent to bvec4.xzzxw).
        /// </summary>
        public bvec5 rbbra => new bvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.xzzy swizzling.
        /// </summary>
        public bvec4 xzzy => new bvec4(x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.rbbg swizzling (equivalent to bvec4.xzzy).
        /// </summary>
        public bvec4 rbbg => new bvec4(x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.xzzyx swizzling.
        /// </summary>
        public bvec5 xzzyx => new bvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.rbbgr swizzling (equivalent to bvec4.xzzyx).
        /// </summary>
        public bvec5 rbbgr => new bvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.xzzyy swizzling.
        /// </summary>
        public bvec5 xzzyy => new bvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.rbbgg swizzling (equivalent to bvec4.xzzyy).
        /// </summary>
        public bvec5 rbbgg => new bvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.xzzyz swizzling.
        /// </summary>
        public bvec5 xzzyz => new bvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.rbbgb swizzling (equivalent to bvec4.xzzyz).
        /// </summary>
        public bvec5 rbbgb => new bvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.xzzyw swizzling.
        /// </summary>
        public bvec5 xzzyw => new bvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.rbbga swizzling (equivalent to bvec4.xzzyw).
        /// </summary>
        public bvec5 rbbga => new bvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.xzzz swizzling.
        /// </summary>
        public bvec4 xzzz => new bvec4(x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.rbbb swizzling (equivalent to bvec4.xzzz).
        /// </summary>
        public bvec4 rbbb => new bvec4(x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.xzzzx swizzling.
        /// </summary>
        public bvec5 xzzzx => new bvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.rbbbr swizzling (equivalent to bvec4.xzzzx).
        /// </summary>
        public bvec5 rbbbr => new bvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.xzzzy swizzling.
        /// </summary>
        public bvec5 xzzzy => new bvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.rbbbg swizzling (equivalent to bvec4.xzzzy).
        /// </summary>
        public bvec5 rbbbg => new bvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.xzzzz swizzling.
        /// </summary>
        public bvec5 xzzzz => new bvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.rbbbb swizzling (equivalent to bvec4.xzzzz).
        /// </summary>
        public bvec5 rbbbb => new bvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.xzzzw swizzling.
        /// </summary>
        public bvec5 xzzzw => new bvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.rbbba swizzling (equivalent to bvec4.xzzzw).
        /// </summary>
        public bvec5 rbbba => new bvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.xzzw swizzling.
        /// </summary>
        public bvec4 xzzw => new bvec4(x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.rbba swizzling (equivalent to bvec4.xzzw).
        /// </summary>
        public bvec4 rbba => new bvec4(x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.xzzwx swizzling.
        /// </summary>
        public bvec5 xzzwx => new bvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.rbbar swizzling (equivalent to bvec4.xzzwx).
        /// </summary>
        public bvec5 rbbar => new bvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.xzzwy swizzling.
        /// </summary>
        public bvec5 xzzwy => new bvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.rbbag swizzling (equivalent to bvec4.xzzwy).
        /// </summary>
        public bvec5 rbbag => new bvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.xzzwz swizzling.
        /// </summary>
        public bvec5 xzzwz => new bvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.rbbab swizzling (equivalent to bvec4.xzzwz).
        /// </summary>
        public bvec5 rbbab => new bvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.xzzww swizzling.
        /// </summary>
        public bvec5 xzzww => new bvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.rbbaa swizzling (equivalent to bvec4.xzzww).
        /// </summary>
        public bvec5 rbbaa => new bvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.xzw swizzling.
        /// </summary>
        public bvec3 xzw => new bvec3(x, z, w);
        
        /// <summary>
        /// Returns bvec4.rba swizzling (equivalent to bvec4.xzw).
        /// </summary>
        public bvec3 rba => new bvec3(x, z, w);
        
        /// <summary>
        /// Returns bvec4.xzwx swizzling.
        /// </summary>
        public bvec4 xzwx => new bvec4(x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.rbar swizzling (equivalent to bvec4.xzwx).
        /// </summary>
        public bvec4 rbar => new bvec4(x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.xzwxx swizzling.
        /// </summary>
        public bvec5 xzwxx => new bvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.rbarr swizzling (equivalent to bvec4.xzwxx).
        /// </summary>
        public bvec5 rbarr => new bvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.xzwxy swizzling.
        /// </summary>
        public bvec5 xzwxy => new bvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.rbarg swizzling (equivalent to bvec4.xzwxy).
        /// </summary>
        public bvec5 rbarg => new bvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.xzwxz swizzling.
        /// </summary>
        public bvec5 xzwxz => new bvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.rbarb swizzling (equivalent to bvec4.xzwxz).
        /// </summary>
        public bvec5 rbarb => new bvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.xzwxw swizzling.
        /// </summary>
        public bvec5 xzwxw => new bvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.rbara swizzling (equivalent to bvec4.xzwxw).
        /// </summary>
        public bvec5 rbara => new bvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.xzwy swizzling.
        /// </summary>
        public bvec4 xzwy => new bvec4(x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.rbag swizzling (equivalent to bvec4.xzwy).
        /// </summary>
        public bvec4 rbag => new bvec4(x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.xzwyx swizzling.
        /// </summary>
        public bvec5 xzwyx => new bvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.rbagr swizzling (equivalent to bvec4.xzwyx).
        /// </summary>
        public bvec5 rbagr => new bvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.xzwyy swizzling.
        /// </summary>
        public bvec5 xzwyy => new bvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.rbagg swizzling (equivalent to bvec4.xzwyy).
        /// </summary>
        public bvec5 rbagg => new bvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.xzwyz swizzling.
        /// </summary>
        public bvec5 xzwyz => new bvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.rbagb swizzling (equivalent to bvec4.xzwyz).
        /// </summary>
        public bvec5 rbagb => new bvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.xzwyw swizzling.
        /// </summary>
        public bvec5 xzwyw => new bvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.rbaga swizzling (equivalent to bvec4.xzwyw).
        /// </summary>
        public bvec5 rbaga => new bvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.xzwz swizzling.
        /// </summary>
        public bvec4 xzwz => new bvec4(x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.rbab swizzling (equivalent to bvec4.xzwz).
        /// </summary>
        public bvec4 rbab => new bvec4(x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.xzwzx swizzling.
        /// </summary>
        public bvec5 xzwzx => new bvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.rbabr swizzling (equivalent to bvec4.xzwzx).
        /// </summary>
        public bvec5 rbabr => new bvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.xzwzy swizzling.
        /// </summary>
        public bvec5 xzwzy => new bvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.rbabg swizzling (equivalent to bvec4.xzwzy).
        /// </summary>
        public bvec5 rbabg => new bvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.xzwzz swizzling.
        /// </summary>
        public bvec5 xzwzz => new bvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.rbabb swizzling (equivalent to bvec4.xzwzz).
        /// </summary>
        public bvec5 rbabb => new bvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.xzwzw swizzling.
        /// </summary>
        public bvec5 xzwzw => new bvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.rbaba swizzling (equivalent to bvec4.xzwzw).
        /// </summary>
        public bvec5 rbaba => new bvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.xzww swizzling.
        /// </summary>
        public bvec4 xzww => new bvec4(x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.rbaa swizzling (equivalent to bvec4.xzww).
        /// </summary>
        public bvec4 rbaa => new bvec4(x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.xzwwx swizzling.
        /// </summary>
        public bvec5 xzwwx => new bvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.rbaar swizzling (equivalent to bvec4.xzwwx).
        /// </summary>
        public bvec5 rbaar => new bvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.xzwwy swizzling.
        /// </summary>
        public bvec5 xzwwy => new bvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.rbaag swizzling (equivalent to bvec4.xzwwy).
        /// </summary>
        public bvec5 rbaag => new bvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.xzwwz swizzling.
        /// </summary>
        public bvec5 xzwwz => new bvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.rbaab swizzling (equivalent to bvec4.xzwwz).
        /// </summary>
        public bvec5 rbaab => new bvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.xzwww swizzling.
        /// </summary>
        public bvec5 xzwww => new bvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.rbaaa swizzling (equivalent to bvec4.xzwww).
        /// </summary>
        public bvec5 rbaaa => new bvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.xw swizzling.
        /// </summary>
        public bvec2 xw => new bvec2(x, w);
        
        /// <summary>
        /// Returns bvec4.ra swizzling (equivalent to bvec4.xw).
        /// </summary>
        public bvec2 ra => new bvec2(x, w);
        
        /// <summary>
        /// Returns bvec4.xwx swizzling.
        /// </summary>
        public bvec3 xwx => new bvec3(x, w, x);
        
        /// <summary>
        /// Returns bvec4.rar swizzling (equivalent to bvec4.xwx).
        /// </summary>
        public bvec3 rar => new bvec3(x, w, x);
        
        /// <summary>
        /// Returns bvec4.xwxx swizzling.
        /// </summary>
        public bvec4 xwxx => new bvec4(x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.rarr swizzling (equivalent to bvec4.xwxx).
        /// </summary>
        public bvec4 rarr => new bvec4(x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.xwxxx swizzling.
        /// </summary>
        public bvec5 xwxxx => new bvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.rarrr swizzling (equivalent to bvec4.xwxxx).
        /// </summary>
        public bvec5 rarrr => new bvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.xwxxy swizzling.
        /// </summary>
        public bvec5 xwxxy => new bvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.rarrg swizzling (equivalent to bvec4.xwxxy).
        /// </summary>
        public bvec5 rarrg => new bvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.xwxxz swizzling.
        /// </summary>
        public bvec5 xwxxz => new bvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.rarrb swizzling (equivalent to bvec4.xwxxz).
        /// </summary>
        public bvec5 rarrb => new bvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.xwxxw swizzling.
        /// </summary>
        public bvec5 xwxxw => new bvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.rarra swizzling (equivalent to bvec4.xwxxw).
        /// </summary>
        public bvec5 rarra => new bvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.xwxy swizzling.
        /// </summary>
        public bvec4 xwxy => new bvec4(x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.rarg swizzling (equivalent to bvec4.xwxy).
        /// </summary>
        public bvec4 rarg => new bvec4(x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.xwxyx swizzling.
        /// </summary>
        public bvec5 xwxyx => new bvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.rargr swizzling (equivalent to bvec4.xwxyx).
        /// </summary>
        public bvec5 rargr => new bvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.xwxyy swizzling.
        /// </summary>
        public bvec5 xwxyy => new bvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.rargg swizzling (equivalent to bvec4.xwxyy).
        /// </summary>
        public bvec5 rargg => new bvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.xwxyz swizzling.
        /// </summary>
        public bvec5 xwxyz => new bvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.rargb swizzling (equivalent to bvec4.xwxyz).
        /// </summary>
        public bvec5 rargb => new bvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.xwxyw swizzling.
        /// </summary>
        public bvec5 xwxyw => new bvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.rarga swizzling (equivalent to bvec4.xwxyw).
        /// </summary>
        public bvec5 rarga => new bvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.xwxz swizzling.
        /// </summary>
        public bvec4 xwxz => new bvec4(x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.rarb swizzling (equivalent to bvec4.xwxz).
        /// </summary>
        public bvec4 rarb => new bvec4(x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.xwxzx swizzling.
        /// </summary>
        public bvec5 xwxzx => new bvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.rarbr swizzling (equivalent to bvec4.xwxzx).
        /// </summary>
        public bvec5 rarbr => new bvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.xwxzy swizzling.
        /// </summary>
        public bvec5 xwxzy => new bvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.rarbg swizzling (equivalent to bvec4.xwxzy).
        /// </summary>
        public bvec5 rarbg => new bvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.xwxzz swizzling.
        /// </summary>
        public bvec5 xwxzz => new bvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.rarbb swizzling (equivalent to bvec4.xwxzz).
        /// </summary>
        public bvec5 rarbb => new bvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.xwxzw swizzling.
        /// </summary>
        public bvec5 xwxzw => new bvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.rarba swizzling (equivalent to bvec4.xwxzw).
        /// </summary>
        public bvec5 rarba => new bvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.xwxw swizzling.
        /// </summary>
        public bvec4 xwxw => new bvec4(x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.rara swizzling (equivalent to bvec4.xwxw).
        /// </summary>
        public bvec4 rara => new bvec4(x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.xwxwx swizzling.
        /// </summary>
        public bvec5 xwxwx => new bvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.rarar swizzling (equivalent to bvec4.xwxwx).
        /// </summary>
        public bvec5 rarar => new bvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.xwxwy swizzling.
        /// </summary>
        public bvec5 xwxwy => new bvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.rarag swizzling (equivalent to bvec4.xwxwy).
        /// </summary>
        public bvec5 rarag => new bvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.xwxwz swizzling.
        /// </summary>
        public bvec5 xwxwz => new bvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.rarab swizzling (equivalent to bvec4.xwxwz).
        /// </summary>
        public bvec5 rarab => new bvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.xwxww swizzling.
        /// </summary>
        public bvec5 xwxww => new bvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.raraa swizzling (equivalent to bvec4.xwxww).
        /// </summary>
        public bvec5 raraa => new bvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.xwy swizzling.
        /// </summary>
        public bvec3 xwy => new bvec3(x, w, y);
        
        /// <summary>
        /// Returns bvec4.rag swizzling (equivalent to bvec4.xwy).
        /// </summary>
        public bvec3 rag => new bvec3(x, w, y);
        
        /// <summary>
        /// Returns bvec4.xwyx swizzling.
        /// </summary>
        public bvec4 xwyx => new bvec4(x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.ragr swizzling (equivalent to bvec4.xwyx).
        /// </summary>
        public bvec4 ragr => new bvec4(x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.xwyxx swizzling.
        /// </summary>
        public bvec5 xwyxx => new bvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.ragrr swizzling (equivalent to bvec4.xwyxx).
        /// </summary>
        public bvec5 ragrr => new bvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.xwyxy swizzling.
        /// </summary>
        public bvec5 xwyxy => new bvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.ragrg swizzling (equivalent to bvec4.xwyxy).
        /// </summary>
        public bvec5 ragrg => new bvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.xwyxz swizzling.
        /// </summary>
        public bvec5 xwyxz => new bvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.ragrb swizzling (equivalent to bvec4.xwyxz).
        /// </summary>
        public bvec5 ragrb => new bvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.xwyxw swizzling.
        /// </summary>
        public bvec5 xwyxw => new bvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.ragra swizzling (equivalent to bvec4.xwyxw).
        /// </summary>
        public bvec5 ragra => new bvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.xwyy swizzling.
        /// </summary>
        public bvec4 xwyy => new bvec4(x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.ragg swizzling (equivalent to bvec4.xwyy).
        /// </summary>
        public bvec4 ragg => new bvec4(x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.xwyyx swizzling.
        /// </summary>
        public bvec5 xwyyx => new bvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.raggr swizzling (equivalent to bvec4.xwyyx).
        /// </summary>
        public bvec5 raggr => new bvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.xwyyy swizzling.
        /// </summary>
        public bvec5 xwyyy => new bvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.raggg swizzling (equivalent to bvec4.xwyyy).
        /// </summary>
        public bvec5 raggg => new bvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.xwyyz swizzling.
        /// </summary>
        public bvec5 xwyyz => new bvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.raggb swizzling (equivalent to bvec4.xwyyz).
        /// </summary>
        public bvec5 raggb => new bvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.xwyyw swizzling.
        /// </summary>
        public bvec5 xwyyw => new bvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.ragga swizzling (equivalent to bvec4.xwyyw).
        /// </summary>
        public bvec5 ragga => new bvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.xwyz swizzling.
        /// </summary>
        public bvec4 xwyz => new bvec4(x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.ragb swizzling (equivalent to bvec4.xwyz).
        /// </summary>
        public bvec4 ragb => new bvec4(x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.xwyzx swizzling.
        /// </summary>
        public bvec5 xwyzx => new bvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.ragbr swizzling (equivalent to bvec4.xwyzx).
        /// </summary>
        public bvec5 ragbr => new bvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.xwyzy swizzling.
        /// </summary>
        public bvec5 xwyzy => new bvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.ragbg swizzling (equivalent to bvec4.xwyzy).
        /// </summary>
        public bvec5 ragbg => new bvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.xwyzz swizzling.
        /// </summary>
        public bvec5 xwyzz => new bvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.ragbb swizzling (equivalent to bvec4.xwyzz).
        /// </summary>
        public bvec5 ragbb => new bvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.xwyzw swizzling.
        /// </summary>
        public bvec5 xwyzw => new bvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.ragba swizzling (equivalent to bvec4.xwyzw).
        /// </summary>
        public bvec5 ragba => new bvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.xwyw swizzling.
        /// </summary>
        public bvec4 xwyw => new bvec4(x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.raga swizzling (equivalent to bvec4.xwyw).
        /// </summary>
        public bvec4 raga => new bvec4(x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.xwywx swizzling.
        /// </summary>
        public bvec5 xwywx => new bvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.ragar swizzling (equivalent to bvec4.xwywx).
        /// </summary>
        public bvec5 ragar => new bvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.xwywy swizzling.
        /// </summary>
        public bvec5 xwywy => new bvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.ragag swizzling (equivalent to bvec4.xwywy).
        /// </summary>
        public bvec5 ragag => new bvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.xwywz swizzling.
        /// </summary>
        public bvec5 xwywz => new bvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.ragab swizzling (equivalent to bvec4.xwywz).
        /// </summary>
        public bvec5 ragab => new bvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.xwyww swizzling.
        /// </summary>
        public bvec5 xwyww => new bvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.ragaa swizzling (equivalent to bvec4.xwyww).
        /// </summary>
        public bvec5 ragaa => new bvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.xwz swizzling.
        /// </summary>
        public bvec3 xwz => new bvec3(x, w, z);
        
        /// <summary>
        /// Returns bvec4.rab swizzling (equivalent to bvec4.xwz).
        /// </summary>
        public bvec3 rab => new bvec3(x, w, z);
        
        /// <summary>
        /// Returns bvec4.xwzx swizzling.
        /// </summary>
        public bvec4 xwzx => new bvec4(x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.rabr swizzling (equivalent to bvec4.xwzx).
        /// </summary>
        public bvec4 rabr => new bvec4(x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.xwzxx swizzling.
        /// </summary>
        public bvec5 xwzxx => new bvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.rabrr swizzling (equivalent to bvec4.xwzxx).
        /// </summary>
        public bvec5 rabrr => new bvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.xwzxy swizzling.
        /// </summary>
        public bvec5 xwzxy => new bvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.rabrg swizzling (equivalent to bvec4.xwzxy).
        /// </summary>
        public bvec5 rabrg => new bvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.xwzxz swizzling.
        /// </summary>
        public bvec5 xwzxz => new bvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.rabrb swizzling (equivalent to bvec4.xwzxz).
        /// </summary>
        public bvec5 rabrb => new bvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.xwzxw swizzling.
        /// </summary>
        public bvec5 xwzxw => new bvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.rabra swizzling (equivalent to bvec4.xwzxw).
        /// </summary>
        public bvec5 rabra => new bvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.xwzy swizzling.
        /// </summary>
        public bvec4 xwzy => new bvec4(x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.rabg swizzling (equivalent to bvec4.xwzy).
        /// </summary>
        public bvec4 rabg => new bvec4(x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.xwzyx swizzling.
        /// </summary>
        public bvec5 xwzyx => new bvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.rabgr swizzling (equivalent to bvec4.xwzyx).
        /// </summary>
        public bvec5 rabgr => new bvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.xwzyy swizzling.
        /// </summary>
        public bvec5 xwzyy => new bvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.rabgg swizzling (equivalent to bvec4.xwzyy).
        /// </summary>
        public bvec5 rabgg => new bvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.xwzyz swizzling.
        /// </summary>
        public bvec5 xwzyz => new bvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.rabgb swizzling (equivalent to bvec4.xwzyz).
        /// </summary>
        public bvec5 rabgb => new bvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.xwzyw swizzling.
        /// </summary>
        public bvec5 xwzyw => new bvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.rabga swizzling (equivalent to bvec4.xwzyw).
        /// </summary>
        public bvec5 rabga => new bvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.xwzz swizzling.
        /// </summary>
        public bvec4 xwzz => new bvec4(x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.rabb swizzling (equivalent to bvec4.xwzz).
        /// </summary>
        public bvec4 rabb => new bvec4(x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.xwzzx swizzling.
        /// </summary>
        public bvec5 xwzzx => new bvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.rabbr swizzling (equivalent to bvec4.xwzzx).
        /// </summary>
        public bvec5 rabbr => new bvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.xwzzy swizzling.
        /// </summary>
        public bvec5 xwzzy => new bvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.rabbg swizzling (equivalent to bvec4.xwzzy).
        /// </summary>
        public bvec5 rabbg => new bvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.xwzzz swizzling.
        /// </summary>
        public bvec5 xwzzz => new bvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.rabbb swizzling (equivalent to bvec4.xwzzz).
        /// </summary>
        public bvec5 rabbb => new bvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.xwzzw swizzling.
        /// </summary>
        public bvec5 xwzzw => new bvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.rabba swizzling (equivalent to bvec4.xwzzw).
        /// </summary>
        public bvec5 rabba => new bvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.xwzw swizzling.
        /// </summary>
        public bvec4 xwzw => new bvec4(x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.raba swizzling (equivalent to bvec4.xwzw).
        /// </summary>
        public bvec4 raba => new bvec4(x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.xwzwx swizzling.
        /// </summary>
        public bvec5 xwzwx => new bvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.rabar swizzling (equivalent to bvec4.xwzwx).
        /// </summary>
        public bvec5 rabar => new bvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.xwzwy swizzling.
        /// </summary>
        public bvec5 xwzwy => new bvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.rabag swizzling (equivalent to bvec4.xwzwy).
        /// </summary>
        public bvec5 rabag => new bvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.xwzwz swizzling.
        /// </summary>
        public bvec5 xwzwz => new bvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.rabab swizzling (equivalent to bvec4.xwzwz).
        /// </summary>
        public bvec5 rabab => new bvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.xwzww swizzling.
        /// </summary>
        public bvec5 xwzww => new bvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.rabaa swizzling (equivalent to bvec4.xwzww).
        /// </summary>
        public bvec5 rabaa => new bvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.xww swizzling.
        /// </summary>
        public bvec3 xww => new bvec3(x, w, w);
        
        /// <summary>
        /// Returns bvec4.raa swizzling (equivalent to bvec4.xww).
        /// </summary>
        public bvec3 raa => new bvec3(x, w, w);
        
        /// <summary>
        /// Returns bvec4.xwwx swizzling.
        /// </summary>
        public bvec4 xwwx => new bvec4(x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.raar swizzling (equivalent to bvec4.xwwx).
        /// </summary>
        public bvec4 raar => new bvec4(x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.xwwxx swizzling.
        /// </summary>
        public bvec5 xwwxx => new bvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.raarr swizzling (equivalent to bvec4.xwwxx).
        /// </summary>
        public bvec5 raarr => new bvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.xwwxy swizzling.
        /// </summary>
        public bvec5 xwwxy => new bvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.raarg swizzling (equivalent to bvec4.xwwxy).
        /// </summary>
        public bvec5 raarg => new bvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.xwwxz swizzling.
        /// </summary>
        public bvec5 xwwxz => new bvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.raarb swizzling (equivalent to bvec4.xwwxz).
        /// </summary>
        public bvec5 raarb => new bvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.xwwxw swizzling.
        /// </summary>
        public bvec5 xwwxw => new bvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.raara swizzling (equivalent to bvec4.xwwxw).
        /// </summary>
        public bvec5 raara => new bvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.xwwy swizzling.
        /// </summary>
        public bvec4 xwwy => new bvec4(x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.raag swizzling (equivalent to bvec4.xwwy).
        /// </summary>
        public bvec4 raag => new bvec4(x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.xwwyx swizzling.
        /// </summary>
        public bvec5 xwwyx => new bvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.raagr swizzling (equivalent to bvec4.xwwyx).
        /// </summary>
        public bvec5 raagr => new bvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.xwwyy swizzling.
        /// </summary>
        public bvec5 xwwyy => new bvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.raagg swizzling (equivalent to bvec4.xwwyy).
        /// </summary>
        public bvec5 raagg => new bvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.xwwyz swizzling.
        /// </summary>
        public bvec5 xwwyz => new bvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.raagb swizzling (equivalent to bvec4.xwwyz).
        /// </summary>
        public bvec5 raagb => new bvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.xwwyw swizzling.
        /// </summary>
        public bvec5 xwwyw => new bvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.raaga swizzling (equivalent to bvec4.xwwyw).
        /// </summary>
        public bvec5 raaga => new bvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.xwwz swizzling.
        /// </summary>
        public bvec4 xwwz => new bvec4(x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.raab swizzling (equivalent to bvec4.xwwz).
        /// </summary>
        public bvec4 raab => new bvec4(x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.xwwzx swizzling.
        /// </summary>
        public bvec5 xwwzx => new bvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.raabr swizzling (equivalent to bvec4.xwwzx).
        /// </summary>
        public bvec5 raabr => new bvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.xwwzy swizzling.
        /// </summary>
        public bvec5 xwwzy => new bvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.raabg swizzling (equivalent to bvec4.xwwzy).
        /// </summary>
        public bvec5 raabg => new bvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.xwwzz swizzling.
        /// </summary>
        public bvec5 xwwzz => new bvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.raabb swizzling (equivalent to bvec4.xwwzz).
        /// </summary>
        public bvec5 raabb => new bvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.xwwzw swizzling.
        /// </summary>
        public bvec5 xwwzw => new bvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.raaba swizzling (equivalent to bvec4.xwwzw).
        /// </summary>
        public bvec5 raaba => new bvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.xwww swizzling.
        /// </summary>
        public bvec4 xwww => new bvec4(x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.raaa swizzling (equivalent to bvec4.xwww).
        /// </summary>
        public bvec4 raaa => new bvec4(x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.xwwwx swizzling.
        /// </summary>
        public bvec5 xwwwx => new bvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.raaar swizzling (equivalent to bvec4.xwwwx).
        /// </summary>
        public bvec5 raaar => new bvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.xwwwy swizzling.
        /// </summary>
        public bvec5 xwwwy => new bvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.raaag swizzling (equivalent to bvec4.xwwwy).
        /// </summary>
        public bvec5 raaag => new bvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.xwwwz swizzling.
        /// </summary>
        public bvec5 xwwwz => new bvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.raaab swizzling (equivalent to bvec4.xwwwz).
        /// </summary>
        public bvec5 raaab => new bvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.xwwww swizzling.
        /// </summary>
        public bvec5 xwwww => new bvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns bvec4.raaaa swizzling (equivalent to bvec4.xwwww).
        /// </summary>
        public bvec5 raaaa => new bvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns bvec4.yx swizzling.
        /// </summary>
        public bvec2 yx => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec4.gr swizzling (equivalent to bvec4.yx).
        /// </summary>
        public bvec2 gr => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec4.yxx swizzling.
        /// </summary>
        public bvec3 yxx => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec4.grr swizzling (equivalent to bvec4.yxx).
        /// </summary>
        public bvec3 grr => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec4.yxxx swizzling.
        /// </summary>
        public bvec4 yxxx => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.grrr swizzling (equivalent to bvec4.yxxx).
        /// </summary>
        public bvec4 grrr => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.yxxxx swizzling.
        /// </summary>
        public bvec5 yxxxx => new bvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.grrrr swizzling (equivalent to bvec4.yxxxx).
        /// </summary>
        public bvec5 grrrr => new bvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.yxxxy swizzling.
        /// </summary>
        public bvec5 yxxxy => new bvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.grrrg swizzling (equivalent to bvec4.yxxxy).
        /// </summary>
        public bvec5 grrrg => new bvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.yxxxz swizzling.
        /// </summary>
        public bvec5 yxxxz => new bvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.grrrb swizzling (equivalent to bvec4.yxxxz).
        /// </summary>
        public bvec5 grrrb => new bvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.yxxxw swizzling.
        /// </summary>
        public bvec5 yxxxw => new bvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.grrra swizzling (equivalent to bvec4.yxxxw).
        /// </summary>
        public bvec5 grrra => new bvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.yxxy swizzling.
        /// </summary>
        public bvec4 yxxy => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.grrg swizzling (equivalent to bvec4.yxxy).
        /// </summary>
        public bvec4 grrg => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.yxxyx swizzling.
        /// </summary>
        public bvec5 yxxyx => new bvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.grrgr swizzling (equivalent to bvec4.yxxyx).
        /// </summary>
        public bvec5 grrgr => new bvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.yxxyy swizzling.
        /// </summary>
        public bvec5 yxxyy => new bvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.grrgg swizzling (equivalent to bvec4.yxxyy).
        /// </summary>
        public bvec5 grrgg => new bvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.yxxyz swizzling.
        /// </summary>
        public bvec5 yxxyz => new bvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.grrgb swizzling (equivalent to bvec4.yxxyz).
        /// </summary>
        public bvec5 grrgb => new bvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.yxxyw swizzling.
        /// </summary>
        public bvec5 yxxyw => new bvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.grrga swizzling (equivalent to bvec4.yxxyw).
        /// </summary>
        public bvec5 grrga => new bvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.yxxz swizzling.
        /// </summary>
        public bvec4 yxxz => new bvec4(y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.grrb swizzling (equivalent to bvec4.yxxz).
        /// </summary>
        public bvec4 grrb => new bvec4(y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.yxxzx swizzling.
        /// </summary>
        public bvec5 yxxzx => new bvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.grrbr swizzling (equivalent to bvec4.yxxzx).
        /// </summary>
        public bvec5 grrbr => new bvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.yxxzy swizzling.
        /// </summary>
        public bvec5 yxxzy => new bvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.grrbg swizzling (equivalent to bvec4.yxxzy).
        /// </summary>
        public bvec5 grrbg => new bvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.yxxzz swizzling.
        /// </summary>
        public bvec5 yxxzz => new bvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.grrbb swizzling (equivalent to bvec4.yxxzz).
        /// </summary>
        public bvec5 grrbb => new bvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.yxxzw swizzling.
        /// </summary>
        public bvec5 yxxzw => new bvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.grrba swizzling (equivalent to bvec4.yxxzw).
        /// </summary>
        public bvec5 grrba => new bvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.yxxw swizzling.
        /// </summary>
        public bvec4 yxxw => new bvec4(y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.grra swizzling (equivalent to bvec4.yxxw).
        /// </summary>
        public bvec4 grra => new bvec4(y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.yxxwx swizzling.
        /// </summary>
        public bvec5 yxxwx => new bvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.grrar swizzling (equivalent to bvec4.yxxwx).
        /// </summary>
        public bvec5 grrar => new bvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.yxxwy swizzling.
        /// </summary>
        public bvec5 yxxwy => new bvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.grrag swizzling (equivalent to bvec4.yxxwy).
        /// </summary>
        public bvec5 grrag => new bvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.yxxwz swizzling.
        /// </summary>
        public bvec5 yxxwz => new bvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.grrab swizzling (equivalent to bvec4.yxxwz).
        /// </summary>
        public bvec5 grrab => new bvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.yxxww swizzling.
        /// </summary>
        public bvec5 yxxww => new bvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.grraa swizzling (equivalent to bvec4.yxxww).
        /// </summary>
        public bvec5 grraa => new bvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.yxy swizzling.
        /// </summary>
        public bvec3 yxy => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec4.grg swizzling (equivalent to bvec4.yxy).
        /// </summary>
        public bvec3 grg => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec4.yxyx swizzling.
        /// </summary>
        public bvec4 yxyx => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.grgr swizzling (equivalent to bvec4.yxyx).
        /// </summary>
        public bvec4 grgr => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.yxyxx swizzling.
        /// </summary>
        public bvec5 yxyxx => new bvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.grgrr swizzling (equivalent to bvec4.yxyxx).
        /// </summary>
        public bvec5 grgrr => new bvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.yxyxy swizzling.
        /// </summary>
        public bvec5 yxyxy => new bvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.grgrg swizzling (equivalent to bvec4.yxyxy).
        /// </summary>
        public bvec5 grgrg => new bvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.yxyxz swizzling.
        /// </summary>
        public bvec5 yxyxz => new bvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.grgrb swizzling (equivalent to bvec4.yxyxz).
        /// </summary>
        public bvec5 grgrb => new bvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.yxyxw swizzling.
        /// </summary>
        public bvec5 yxyxw => new bvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.grgra swizzling (equivalent to bvec4.yxyxw).
        /// </summary>
        public bvec5 grgra => new bvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.yxyy swizzling.
        /// </summary>
        public bvec4 yxyy => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.grgg swizzling (equivalent to bvec4.yxyy).
        /// </summary>
        public bvec4 grgg => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.yxyyx swizzling.
        /// </summary>
        public bvec5 yxyyx => new bvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.grggr swizzling (equivalent to bvec4.yxyyx).
        /// </summary>
        public bvec5 grggr => new bvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.yxyyy swizzling.
        /// </summary>
        public bvec5 yxyyy => new bvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.grggg swizzling (equivalent to bvec4.yxyyy).
        /// </summary>
        public bvec5 grggg => new bvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.yxyyz swizzling.
        /// </summary>
        public bvec5 yxyyz => new bvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.grggb swizzling (equivalent to bvec4.yxyyz).
        /// </summary>
        public bvec5 grggb => new bvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.yxyyw swizzling.
        /// </summary>
        public bvec5 yxyyw => new bvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.grgga swizzling (equivalent to bvec4.yxyyw).
        /// </summary>
        public bvec5 grgga => new bvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.yxyz swizzling.
        /// </summary>
        public bvec4 yxyz => new bvec4(y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.grgb swizzling (equivalent to bvec4.yxyz).
        /// </summary>
        public bvec4 grgb => new bvec4(y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.yxyzx swizzling.
        /// </summary>
        public bvec5 yxyzx => new bvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.grgbr swizzling (equivalent to bvec4.yxyzx).
        /// </summary>
        public bvec5 grgbr => new bvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.yxyzy swizzling.
        /// </summary>
        public bvec5 yxyzy => new bvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.grgbg swizzling (equivalent to bvec4.yxyzy).
        /// </summary>
        public bvec5 grgbg => new bvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.yxyzz swizzling.
        /// </summary>
        public bvec5 yxyzz => new bvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.grgbb swizzling (equivalent to bvec4.yxyzz).
        /// </summary>
        public bvec5 grgbb => new bvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.yxyzw swizzling.
        /// </summary>
        public bvec5 yxyzw => new bvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.grgba swizzling (equivalent to bvec4.yxyzw).
        /// </summary>
        public bvec5 grgba => new bvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.yxyw swizzling.
        /// </summary>
        public bvec4 yxyw => new bvec4(y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.grga swizzling (equivalent to bvec4.yxyw).
        /// </summary>
        public bvec4 grga => new bvec4(y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.yxywx swizzling.
        /// </summary>
        public bvec5 yxywx => new bvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.grgar swizzling (equivalent to bvec4.yxywx).
        /// </summary>
        public bvec5 grgar => new bvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.yxywy swizzling.
        /// </summary>
        public bvec5 yxywy => new bvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.grgag swizzling (equivalent to bvec4.yxywy).
        /// </summary>
        public bvec5 grgag => new bvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.yxywz swizzling.
        /// </summary>
        public bvec5 yxywz => new bvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.grgab swizzling (equivalent to bvec4.yxywz).
        /// </summary>
        public bvec5 grgab => new bvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.yxyww swizzling.
        /// </summary>
        public bvec5 yxyww => new bvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.grgaa swizzling (equivalent to bvec4.yxyww).
        /// </summary>
        public bvec5 grgaa => new bvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.yxz swizzling.
        /// </summary>
        public bvec3 yxz => new bvec3(y, x, z);
        
        /// <summary>
        /// Returns bvec4.grb swizzling (equivalent to bvec4.yxz).
        /// </summary>
        public bvec3 grb => new bvec3(y, x, z);
        
        /// <summary>
        /// Returns bvec4.yxzx swizzling.
        /// </summary>
        public bvec4 yxzx => new bvec4(y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.grbr swizzling (equivalent to bvec4.yxzx).
        /// </summary>
        public bvec4 grbr => new bvec4(y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.yxzxx swizzling.
        /// </summary>
        public bvec5 yxzxx => new bvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.grbrr swizzling (equivalent to bvec4.yxzxx).
        /// </summary>
        public bvec5 grbrr => new bvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.yxzxy swizzling.
        /// </summary>
        public bvec5 yxzxy => new bvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.grbrg swizzling (equivalent to bvec4.yxzxy).
        /// </summary>
        public bvec5 grbrg => new bvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.yxzxz swizzling.
        /// </summary>
        public bvec5 yxzxz => new bvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.grbrb swizzling (equivalent to bvec4.yxzxz).
        /// </summary>
        public bvec5 grbrb => new bvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.yxzxw swizzling.
        /// </summary>
        public bvec5 yxzxw => new bvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.grbra swizzling (equivalent to bvec4.yxzxw).
        /// </summary>
        public bvec5 grbra => new bvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.yxzy swizzling.
        /// </summary>
        public bvec4 yxzy => new bvec4(y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.grbg swizzling (equivalent to bvec4.yxzy).
        /// </summary>
        public bvec4 grbg => new bvec4(y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.yxzyx swizzling.
        /// </summary>
        public bvec5 yxzyx => new bvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.grbgr swizzling (equivalent to bvec4.yxzyx).
        /// </summary>
        public bvec5 grbgr => new bvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.yxzyy swizzling.
        /// </summary>
        public bvec5 yxzyy => new bvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.grbgg swizzling (equivalent to bvec4.yxzyy).
        /// </summary>
        public bvec5 grbgg => new bvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.yxzyz swizzling.
        /// </summary>
        public bvec5 yxzyz => new bvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.grbgb swizzling (equivalent to bvec4.yxzyz).
        /// </summary>
        public bvec5 grbgb => new bvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.yxzyw swizzling.
        /// </summary>
        public bvec5 yxzyw => new bvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.grbga swizzling (equivalent to bvec4.yxzyw).
        /// </summary>
        public bvec5 grbga => new bvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.yxzz swizzling.
        /// </summary>
        public bvec4 yxzz => new bvec4(y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.grbb swizzling (equivalent to bvec4.yxzz).
        /// </summary>
        public bvec4 grbb => new bvec4(y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.yxzzx swizzling.
        /// </summary>
        public bvec5 yxzzx => new bvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.grbbr swizzling (equivalent to bvec4.yxzzx).
        /// </summary>
        public bvec5 grbbr => new bvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.yxzzy swizzling.
        /// </summary>
        public bvec5 yxzzy => new bvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.grbbg swizzling (equivalent to bvec4.yxzzy).
        /// </summary>
        public bvec5 grbbg => new bvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.yxzzz swizzling.
        /// </summary>
        public bvec5 yxzzz => new bvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.grbbb swizzling (equivalent to bvec4.yxzzz).
        /// </summary>
        public bvec5 grbbb => new bvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.yxzzw swizzling.
        /// </summary>
        public bvec5 yxzzw => new bvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.grbba swizzling (equivalent to bvec4.yxzzw).
        /// </summary>
        public bvec5 grbba => new bvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.yxzw swizzling.
        /// </summary>
        public bvec4 yxzw => new bvec4(y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.grba swizzling (equivalent to bvec4.yxzw).
        /// </summary>
        public bvec4 grba => new bvec4(y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.yxzwx swizzling.
        /// </summary>
        public bvec5 yxzwx => new bvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.grbar swizzling (equivalent to bvec4.yxzwx).
        /// </summary>
        public bvec5 grbar => new bvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.yxzwy swizzling.
        /// </summary>
        public bvec5 yxzwy => new bvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.grbag swizzling (equivalent to bvec4.yxzwy).
        /// </summary>
        public bvec5 grbag => new bvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.yxzwz swizzling.
        /// </summary>
        public bvec5 yxzwz => new bvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.grbab swizzling (equivalent to bvec4.yxzwz).
        /// </summary>
        public bvec5 grbab => new bvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.yxzww swizzling.
        /// </summary>
        public bvec5 yxzww => new bvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.grbaa swizzling (equivalent to bvec4.yxzww).
        /// </summary>
        public bvec5 grbaa => new bvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.yxw swizzling.
        /// </summary>
        public bvec3 yxw => new bvec3(y, x, w);
        
        /// <summary>
        /// Returns bvec4.gra swizzling (equivalent to bvec4.yxw).
        /// </summary>
        public bvec3 gra => new bvec3(y, x, w);
        
        /// <summary>
        /// Returns bvec4.yxwx swizzling.
        /// </summary>
        public bvec4 yxwx => new bvec4(y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.grar swizzling (equivalent to bvec4.yxwx).
        /// </summary>
        public bvec4 grar => new bvec4(y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.yxwxx swizzling.
        /// </summary>
        public bvec5 yxwxx => new bvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.grarr swizzling (equivalent to bvec4.yxwxx).
        /// </summary>
        public bvec5 grarr => new bvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.yxwxy swizzling.
        /// </summary>
        public bvec5 yxwxy => new bvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.grarg swizzling (equivalent to bvec4.yxwxy).
        /// </summary>
        public bvec5 grarg => new bvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.yxwxz swizzling.
        /// </summary>
        public bvec5 yxwxz => new bvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.grarb swizzling (equivalent to bvec4.yxwxz).
        /// </summary>
        public bvec5 grarb => new bvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.yxwxw swizzling.
        /// </summary>
        public bvec5 yxwxw => new bvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.grara swizzling (equivalent to bvec4.yxwxw).
        /// </summary>
        public bvec5 grara => new bvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.yxwy swizzling.
        /// </summary>
        public bvec4 yxwy => new bvec4(y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.grag swizzling (equivalent to bvec4.yxwy).
        /// </summary>
        public bvec4 grag => new bvec4(y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.yxwyx swizzling.
        /// </summary>
        public bvec5 yxwyx => new bvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.gragr swizzling (equivalent to bvec4.yxwyx).
        /// </summary>
        public bvec5 gragr => new bvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.yxwyy swizzling.
        /// </summary>
        public bvec5 yxwyy => new bvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.gragg swizzling (equivalent to bvec4.yxwyy).
        /// </summary>
        public bvec5 gragg => new bvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.yxwyz swizzling.
        /// </summary>
        public bvec5 yxwyz => new bvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.gragb swizzling (equivalent to bvec4.yxwyz).
        /// </summary>
        public bvec5 gragb => new bvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.yxwyw swizzling.
        /// </summary>
        public bvec5 yxwyw => new bvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.graga swizzling (equivalent to bvec4.yxwyw).
        /// </summary>
        public bvec5 graga => new bvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.yxwz swizzling.
        /// </summary>
        public bvec4 yxwz => new bvec4(y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.grab swizzling (equivalent to bvec4.yxwz).
        /// </summary>
        public bvec4 grab => new bvec4(y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.yxwzx swizzling.
        /// </summary>
        public bvec5 yxwzx => new bvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.grabr swizzling (equivalent to bvec4.yxwzx).
        /// </summary>
        public bvec5 grabr => new bvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.yxwzy swizzling.
        /// </summary>
        public bvec5 yxwzy => new bvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.grabg swizzling (equivalent to bvec4.yxwzy).
        /// </summary>
        public bvec5 grabg => new bvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.yxwzz swizzling.
        /// </summary>
        public bvec5 yxwzz => new bvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.grabb swizzling (equivalent to bvec4.yxwzz).
        /// </summary>
        public bvec5 grabb => new bvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.yxwzw swizzling.
        /// </summary>
        public bvec5 yxwzw => new bvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.graba swizzling (equivalent to bvec4.yxwzw).
        /// </summary>
        public bvec5 graba => new bvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.yxww swizzling.
        /// </summary>
        public bvec4 yxww => new bvec4(y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.graa swizzling (equivalent to bvec4.yxww).
        /// </summary>
        public bvec4 graa => new bvec4(y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.yxwwx swizzling.
        /// </summary>
        public bvec5 yxwwx => new bvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.graar swizzling (equivalent to bvec4.yxwwx).
        /// </summary>
        public bvec5 graar => new bvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.yxwwy swizzling.
        /// </summary>
        public bvec5 yxwwy => new bvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.graag swizzling (equivalent to bvec4.yxwwy).
        /// </summary>
        public bvec5 graag => new bvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.yxwwz swizzling.
        /// </summary>
        public bvec5 yxwwz => new bvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.graab swizzling (equivalent to bvec4.yxwwz).
        /// </summary>
        public bvec5 graab => new bvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.yxwww swizzling.
        /// </summary>
        public bvec5 yxwww => new bvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.graaa swizzling (equivalent to bvec4.yxwww).
        /// </summary>
        public bvec5 graaa => new bvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.yy swizzling.
        /// </summary>
        public bvec2 yy => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec4.gg swizzling (equivalent to bvec4.yy).
        /// </summary>
        public bvec2 gg => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec4.yyx swizzling.
        /// </summary>
        public bvec3 yyx => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec4.ggr swizzling (equivalent to bvec4.yyx).
        /// </summary>
        public bvec3 ggr => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec4.yyxx swizzling.
        /// </summary>
        public bvec4 yyxx => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.ggrr swizzling (equivalent to bvec4.yyxx).
        /// </summary>
        public bvec4 ggrr => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.yyxxx swizzling.
        /// </summary>
        public bvec5 yyxxx => new bvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.ggrrr swizzling (equivalent to bvec4.yyxxx).
        /// </summary>
        public bvec5 ggrrr => new bvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.yyxxy swizzling.
        /// </summary>
        public bvec5 yyxxy => new bvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.ggrrg swizzling (equivalent to bvec4.yyxxy).
        /// </summary>
        public bvec5 ggrrg => new bvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.yyxxz swizzling.
        /// </summary>
        public bvec5 yyxxz => new bvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.ggrrb swizzling (equivalent to bvec4.yyxxz).
        /// </summary>
        public bvec5 ggrrb => new bvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.yyxxw swizzling.
        /// </summary>
        public bvec5 yyxxw => new bvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.ggrra swizzling (equivalent to bvec4.yyxxw).
        /// </summary>
        public bvec5 ggrra => new bvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.yyxy swizzling.
        /// </summary>
        public bvec4 yyxy => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.ggrg swizzling (equivalent to bvec4.yyxy).
        /// </summary>
        public bvec4 ggrg => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.yyxyx swizzling.
        /// </summary>
        public bvec5 yyxyx => new bvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.ggrgr swizzling (equivalent to bvec4.yyxyx).
        /// </summary>
        public bvec5 ggrgr => new bvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.yyxyy swizzling.
        /// </summary>
        public bvec5 yyxyy => new bvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.ggrgg swizzling (equivalent to bvec4.yyxyy).
        /// </summary>
        public bvec5 ggrgg => new bvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.yyxyz swizzling.
        /// </summary>
        public bvec5 yyxyz => new bvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.ggrgb swizzling (equivalent to bvec4.yyxyz).
        /// </summary>
        public bvec5 ggrgb => new bvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.yyxyw swizzling.
        /// </summary>
        public bvec5 yyxyw => new bvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.ggrga swizzling (equivalent to bvec4.yyxyw).
        /// </summary>
        public bvec5 ggrga => new bvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.yyxz swizzling.
        /// </summary>
        public bvec4 yyxz => new bvec4(y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.ggrb swizzling (equivalent to bvec4.yyxz).
        /// </summary>
        public bvec4 ggrb => new bvec4(y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.yyxzx swizzling.
        /// </summary>
        public bvec5 yyxzx => new bvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.ggrbr swizzling (equivalent to bvec4.yyxzx).
        /// </summary>
        public bvec5 ggrbr => new bvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.yyxzy swizzling.
        /// </summary>
        public bvec5 yyxzy => new bvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.ggrbg swizzling (equivalent to bvec4.yyxzy).
        /// </summary>
        public bvec5 ggrbg => new bvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.yyxzz swizzling.
        /// </summary>
        public bvec5 yyxzz => new bvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.ggrbb swizzling (equivalent to bvec4.yyxzz).
        /// </summary>
        public bvec5 ggrbb => new bvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.yyxzw swizzling.
        /// </summary>
        public bvec5 yyxzw => new bvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.ggrba swizzling (equivalent to bvec4.yyxzw).
        /// </summary>
        public bvec5 ggrba => new bvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.yyxw swizzling.
        /// </summary>
        public bvec4 yyxw => new bvec4(y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.ggra swizzling (equivalent to bvec4.yyxw).
        /// </summary>
        public bvec4 ggra => new bvec4(y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.yyxwx swizzling.
        /// </summary>
        public bvec5 yyxwx => new bvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.ggrar swizzling (equivalent to bvec4.yyxwx).
        /// </summary>
        public bvec5 ggrar => new bvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.yyxwy swizzling.
        /// </summary>
        public bvec5 yyxwy => new bvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.ggrag swizzling (equivalent to bvec4.yyxwy).
        /// </summary>
        public bvec5 ggrag => new bvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.yyxwz swizzling.
        /// </summary>
        public bvec5 yyxwz => new bvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.ggrab swizzling (equivalent to bvec4.yyxwz).
        /// </summary>
        public bvec5 ggrab => new bvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.yyxww swizzling.
        /// </summary>
        public bvec5 yyxww => new bvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.ggraa swizzling (equivalent to bvec4.yyxww).
        /// </summary>
        public bvec5 ggraa => new bvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.yyy swizzling.
        /// </summary>
        public bvec3 yyy => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec4.ggg swizzling (equivalent to bvec4.yyy).
        /// </summary>
        public bvec3 ggg => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec4.yyyx swizzling.
        /// </summary>
        public bvec4 yyyx => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.gggr swizzling (equivalent to bvec4.yyyx).
        /// </summary>
        public bvec4 gggr => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.yyyxx swizzling.
        /// </summary>
        public bvec5 yyyxx => new bvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.gggrr swizzling (equivalent to bvec4.yyyxx).
        /// </summary>
        public bvec5 gggrr => new bvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.yyyxy swizzling.
        /// </summary>
        public bvec5 yyyxy => new bvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.gggrg swizzling (equivalent to bvec4.yyyxy).
        /// </summary>
        public bvec5 gggrg => new bvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.yyyxz swizzling.
        /// </summary>
        public bvec5 yyyxz => new bvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.gggrb swizzling (equivalent to bvec4.yyyxz).
        /// </summary>
        public bvec5 gggrb => new bvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.yyyxw swizzling.
        /// </summary>
        public bvec5 yyyxw => new bvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.gggra swizzling (equivalent to bvec4.yyyxw).
        /// </summary>
        public bvec5 gggra => new bvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.yyyy swizzling.
        /// </summary>
        public bvec4 yyyy => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.gggg swizzling (equivalent to bvec4.yyyy).
        /// </summary>
        public bvec4 gggg => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.yyyyx swizzling.
        /// </summary>
        public bvec5 yyyyx => new bvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.ggggr swizzling (equivalent to bvec4.yyyyx).
        /// </summary>
        public bvec5 ggggr => new bvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.yyyyy swizzling.
        /// </summary>
        public bvec5 yyyyy => new bvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.ggggg swizzling (equivalent to bvec4.yyyyy).
        /// </summary>
        public bvec5 ggggg => new bvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.yyyyz swizzling.
        /// </summary>
        public bvec5 yyyyz => new bvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.ggggb swizzling (equivalent to bvec4.yyyyz).
        /// </summary>
        public bvec5 ggggb => new bvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.yyyyw swizzling.
        /// </summary>
        public bvec5 yyyyw => new bvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.gggga swizzling (equivalent to bvec4.yyyyw).
        /// </summary>
        public bvec5 gggga => new bvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.yyyz swizzling.
        /// </summary>
        public bvec4 yyyz => new bvec4(y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.gggb swizzling (equivalent to bvec4.yyyz).
        /// </summary>
        public bvec4 gggb => new bvec4(y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.yyyzx swizzling.
        /// </summary>
        public bvec5 yyyzx => new bvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.gggbr swizzling (equivalent to bvec4.yyyzx).
        /// </summary>
        public bvec5 gggbr => new bvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.yyyzy swizzling.
        /// </summary>
        public bvec5 yyyzy => new bvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.gggbg swizzling (equivalent to bvec4.yyyzy).
        /// </summary>
        public bvec5 gggbg => new bvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.yyyzz swizzling.
        /// </summary>
        public bvec5 yyyzz => new bvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.gggbb swizzling (equivalent to bvec4.yyyzz).
        /// </summary>
        public bvec5 gggbb => new bvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.yyyzw swizzling.
        /// </summary>
        public bvec5 yyyzw => new bvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.gggba swizzling (equivalent to bvec4.yyyzw).
        /// </summary>
        public bvec5 gggba => new bvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.yyyw swizzling.
        /// </summary>
        public bvec4 yyyw => new bvec4(y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.ggga swizzling (equivalent to bvec4.yyyw).
        /// </summary>
        public bvec4 ggga => new bvec4(y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.yyywx swizzling.
        /// </summary>
        public bvec5 yyywx => new bvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.gggar swizzling (equivalent to bvec4.yyywx).
        /// </summary>
        public bvec5 gggar => new bvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.yyywy swizzling.
        /// </summary>
        public bvec5 yyywy => new bvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.gggag swizzling (equivalent to bvec4.yyywy).
        /// </summary>
        public bvec5 gggag => new bvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.yyywz swizzling.
        /// </summary>
        public bvec5 yyywz => new bvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.gggab swizzling (equivalent to bvec4.yyywz).
        /// </summary>
        public bvec5 gggab => new bvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.yyyww swizzling.
        /// </summary>
        public bvec5 yyyww => new bvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.gggaa swizzling (equivalent to bvec4.yyyww).
        /// </summary>
        public bvec5 gggaa => new bvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.yyz swizzling.
        /// </summary>
        public bvec3 yyz => new bvec3(y, y, z);
        
        /// <summary>
        /// Returns bvec4.ggb swizzling (equivalent to bvec4.yyz).
        /// </summary>
        public bvec3 ggb => new bvec3(y, y, z);
        
        /// <summary>
        /// Returns bvec4.yyzx swizzling.
        /// </summary>
        public bvec4 yyzx => new bvec4(y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.ggbr swizzling (equivalent to bvec4.yyzx).
        /// </summary>
        public bvec4 ggbr => new bvec4(y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.yyzxx swizzling.
        /// </summary>
        public bvec5 yyzxx => new bvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.ggbrr swizzling (equivalent to bvec4.yyzxx).
        /// </summary>
        public bvec5 ggbrr => new bvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.yyzxy swizzling.
        /// </summary>
        public bvec5 yyzxy => new bvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.ggbrg swizzling (equivalent to bvec4.yyzxy).
        /// </summary>
        public bvec5 ggbrg => new bvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.yyzxz swizzling.
        /// </summary>
        public bvec5 yyzxz => new bvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.ggbrb swizzling (equivalent to bvec4.yyzxz).
        /// </summary>
        public bvec5 ggbrb => new bvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.yyzxw swizzling.
        /// </summary>
        public bvec5 yyzxw => new bvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.ggbra swizzling (equivalent to bvec4.yyzxw).
        /// </summary>
        public bvec5 ggbra => new bvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.yyzy swizzling.
        /// </summary>
        public bvec4 yyzy => new bvec4(y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.ggbg swizzling (equivalent to bvec4.yyzy).
        /// </summary>
        public bvec4 ggbg => new bvec4(y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.yyzyx swizzling.
        /// </summary>
        public bvec5 yyzyx => new bvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.ggbgr swizzling (equivalent to bvec4.yyzyx).
        /// </summary>
        public bvec5 ggbgr => new bvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.yyzyy swizzling.
        /// </summary>
        public bvec5 yyzyy => new bvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.ggbgg swizzling (equivalent to bvec4.yyzyy).
        /// </summary>
        public bvec5 ggbgg => new bvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.yyzyz swizzling.
        /// </summary>
        public bvec5 yyzyz => new bvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.ggbgb swizzling (equivalent to bvec4.yyzyz).
        /// </summary>
        public bvec5 ggbgb => new bvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.yyzyw swizzling.
        /// </summary>
        public bvec5 yyzyw => new bvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.ggbga swizzling (equivalent to bvec4.yyzyw).
        /// </summary>
        public bvec5 ggbga => new bvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.yyzz swizzling.
        /// </summary>
        public bvec4 yyzz => new bvec4(y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.ggbb swizzling (equivalent to bvec4.yyzz).
        /// </summary>
        public bvec4 ggbb => new bvec4(y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.yyzzx swizzling.
        /// </summary>
        public bvec5 yyzzx => new bvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.ggbbr swizzling (equivalent to bvec4.yyzzx).
        /// </summary>
        public bvec5 ggbbr => new bvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.yyzzy swizzling.
        /// </summary>
        public bvec5 yyzzy => new bvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.ggbbg swizzling (equivalent to bvec4.yyzzy).
        /// </summary>
        public bvec5 ggbbg => new bvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.yyzzz swizzling.
        /// </summary>
        public bvec5 yyzzz => new bvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.ggbbb swizzling (equivalent to bvec4.yyzzz).
        /// </summary>
        public bvec5 ggbbb => new bvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.yyzzw swizzling.
        /// </summary>
        public bvec5 yyzzw => new bvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.ggbba swizzling (equivalent to bvec4.yyzzw).
        /// </summary>
        public bvec5 ggbba => new bvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.yyzw swizzling.
        /// </summary>
        public bvec4 yyzw => new bvec4(y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.ggba swizzling (equivalent to bvec4.yyzw).
        /// </summary>
        public bvec4 ggba => new bvec4(y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.yyzwx swizzling.
        /// </summary>
        public bvec5 yyzwx => new bvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.ggbar swizzling (equivalent to bvec4.yyzwx).
        /// </summary>
        public bvec5 ggbar => new bvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.yyzwy swizzling.
        /// </summary>
        public bvec5 yyzwy => new bvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.ggbag swizzling (equivalent to bvec4.yyzwy).
        /// </summary>
        public bvec5 ggbag => new bvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.yyzwz swizzling.
        /// </summary>
        public bvec5 yyzwz => new bvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.ggbab swizzling (equivalent to bvec4.yyzwz).
        /// </summary>
        public bvec5 ggbab => new bvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.yyzww swizzling.
        /// </summary>
        public bvec5 yyzww => new bvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.ggbaa swizzling (equivalent to bvec4.yyzww).
        /// </summary>
        public bvec5 ggbaa => new bvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.yyw swizzling.
        /// </summary>
        public bvec3 yyw => new bvec3(y, y, w);
        
        /// <summary>
        /// Returns bvec4.gga swizzling (equivalent to bvec4.yyw).
        /// </summary>
        public bvec3 gga => new bvec3(y, y, w);
        
        /// <summary>
        /// Returns bvec4.yywx swizzling.
        /// </summary>
        public bvec4 yywx => new bvec4(y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.ggar swizzling (equivalent to bvec4.yywx).
        /// </summary>
        public bvec4 ggar => new bvec4(y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.yywxx swizzling.
        /// </summary>
        public bvec5 yywxx => new bvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.ggarr swizzling (equivalent to bvec4.yywxx).
        /// </summary>
        public bvec5 ggarr => new bvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.yywxy swizzling.
        /// </summary>
        public bvec5 yywxy => new bvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.ggarg swizzling (equivalent to bvec4.yywxy).
        /// </summary>
        public bvec5 ggarg => new bvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.yywxz swizzling.
        /// </summary>
        public bvec5 yywxz => new bvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.ggarb swizzling (equivalent to bvec4.yywxz).
        /// </summary>
        public bvec5 ggarb => new bvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.yywxw swizzling.
        /// </summary>
        public bvec5 yywxw => new bvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.ggara swizzling (equivalent to bvec4.yywxw).
        /// </summary>
        public bvec5 ggara => new bvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.yywy swizzling.
        /// </summary>
        public bvec4 yywy => new bvec4(y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.ggag swizzling (equivalent to bvec4.yywy).
        /// </summary>
        public bvec4 ggag => new bvec4(y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.yywyx swizzling.
        /// </summary>
        public bvec5 yywyx => new bvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.ggagr swizzling (equivalent to bvec4.yywyx).
        /// </summary>
        public bvec5 ggagr => new bvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.yywyy swizzling.
        /// </summary>
        public bvec5 yywyy => new bvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.ggagg swizzling (equivalent to bvec4.yywyy).
        /// </summary>
        public bvec5 ggagg => new bvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.yywyz swizzling.
        /// </summary>
        public bvec5 yywyz => new bvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.ggagb swizzling (equivalent to bvec4.yywyz).
        /// </summary>
        public bvec5 ggagb => new bvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.yywyw swizzling.
        /// </summary>
        public bvec5 yywyw => new bvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.ggaga swizzling (equivalent to bvec4.yywyw).
        /// </summary>
        public bvec5 ggaga => new bvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.yywz swizzling.
        /// </summary>
        public bvec4 yywz => new bvec4(y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.ggab swizzling (equivalent to bvec4.yywz).
        /// </summary>
        public bvec4 ggab => new bvec4(y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.yywzx swizzling.
        /// </summary>
        public bvec5 yywzx => new bvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.ggabr swizzling (equivalent to bvec4.yywzx).
        /// </summary>
        public bvec5 ggabr => new bvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.yywzy swizzling.
        /// </summary>
        public bvec5 yywzy => new bvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.ggabg swizzling (equivalent to bvec4.yywzy).
        /// </summary>
        public bvec5 ggabg => new bvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.yywzz swizzling.
        /// </summary>
        public bvec5 yywzz => new bvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.ggabb swizzling (equivalent to bvec4.yywzz).
        /// </summary>
        public bvec5 ggabb => new bvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.yywzw swizzling.
        /// </summary>
        public bvec5 yywzw => new bvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.ggaba swizzling (equivalent to bvec4.yywzw).
        /// </summary>
        public bvec5 ggaba => new bvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.yyww swizzling.
        /// </summary>
        public bvec4 yyww => new bvec4(y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.ggaa swizzling (equivalent to bvec4.yyww).
        /// </summary>
        public bvec4 ggaa => new bvec4(y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.yywwx swizzling.
        /// </summary>
        public bvec5 yywwx => new bvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.ggaar swizzling (equivalent to bvec4.yywwx).
        /// </summary>
        public bvec5 ggaar => new bvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.yywwy swizzling.
        /// </summary>
        public bvec5 yywwy => new bvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.ggaag swizzling (equivalent to bvec4.yywwy).
        /// </summary>
        public bvec5 ggaag => new bvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.yywwz swizzling.
        /// </summary>
        public bvec5 yywwz => new bvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.ggaab swizzling (equivalent to bvec4.yywwz).
        /// </summary>
        public bvec5 ggaab => new bvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.yywww swizzling.
        /// </summary>
        public bvec5 yywww => new bvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.ggaaa swizzling (equivalent to bvec4.yywww).
        /// </summary>
        public bvec5 ggaaa => new bvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.yz swizzling.
        /// </summary>
        public bvec2 yz => new bvec2(y, z);
        
        /// <summary>
        /// Returns bvec4.gb swizzling (equivalent to bvec4.yz).
        /// </summary>
        public bvec2 gb => new bvec2(y, z);
        
        /// <summary>
        /// Returns bvec4.yzx swizzling.
        /// </summary>
        public bvec3 yzx => new bvec3(y, z, x);
        
        /// <summary>
        /// Returns bvec4.gbr swizzling (equivalent to bvec4.yzx).
        /// </summary>
        public bvec3 gbr => new bvec3(y, z, x);
        
        /// <summary>
        /// Returns bvec4.yzxx swizzling.
        /// </summary>
        public bvec4 yzxx => new bvec4(y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.gbrr swizzling (equivalent to bvec4.yzxx).
        /// </summary>
        public bvec4 gbrr => new bvec4(y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.yzxxx swizzling.
        /// </summary>
        public bvec5 yzxxx => new bvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.gbrrr swizzling (equivalent to bvec4.yzxxx).
        /// </summary>
        public bvec5 gbrrr => new bvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.yzxxy swizzling.
        /// </summary>
        public bvec5 yzxxy => new bvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.gbrrg swizzling (equivalent to bvec4.yzxxy).
        /// </summary>
        public bvec5 gbrrg => new bvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.yzxxz swizzling.
        /// </summary>
        public bvec5 yzxxz => new bvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.gbrrb swizzling (equivalent to bvec4.yzxxz).
        /// </summary>
        public bvec5 gbrrb => new bvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.yzxxw swizzling.
        /// </summary>
        public bvec5 yzxxw => new bvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.gbrra swizzling (equivalent to bvec4.yzxxw).
        /// </summary>
        public bvec5 gbrra => new bvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.yzxy swizzling.
        /// </summary>
        public bvec4 yzxy => new bvec4(y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.gbrg swizzling (equivalent to bvec4.yzxy).
        /// </summary>
        public bvec4 gbrg => new bvec4(y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.yzxyx swizzling.
        /// </summary>
        public bvec5 yzxyx => new bvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.gbrgr swizzling (equivalent to bvec4.yzxyx).
        /// </summary>
        public bvec5 gbrgr => new bvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.yzxyy swizzling.
        /// </summary>
        public bvec5 yzxyy => new bvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.gbrgg swizzling (equivalent to bvec4.yzxyy).
        /// </summary>
        public bvec5 gbrgg => new bvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.yzxyz swizzling.
        /// </summary>
        public bvec5 yzxyz => new bvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.gbrgb swizzling (equivalent to bvec4.yzxyz).
        /// </summary>
        public bvec5 gbrgb => new bvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.yzxyw swizzling.
        /// </summary>
        public bvec5 yzxyw => new bvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.gbrga swizzling (equivalent to bvec4.yzxyw).
        /// </summary>
        public bvec5 gbrga => new bvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.yzxz swizzling.
        /// </summary>
        public bvec4 yzxz => new bvec4(y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.gbrb swizzling (equivalent to bvec4.yzxz).
        /// </summary>
        public bvec4 gbrb => new bvec4(y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.yzxzx swizzling.
        /// </summary>
        public bvec5 yzxzx => new bvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.gbrbr swizzling (equivalent to bvec4.yzxzx).
        /// </summary>
        public bvec5 gbrbr => new bvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.yzxzy swizzling.
        /// </summary>
        public bvec5 yzxzy => new bvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.gbrbg swizzling (equivalent to bvec4.yzxzy).
        /// </summary>
        public bvec5 gbrbg => new bvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.yzxzz swizzling.
        /// </summary>
        public bvec5 yzxzz => new bvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.gbrbb swizzling (equivalent to bvec4.yzxzz).
        /// </summary>
        public bvec5 gbrbb => new bvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.yzxzw swizzling.
        /// </summary>
        public bvec5 yzxzw => new bvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.gbrba swizzling (equivalent to bvec4.yzxzw).
        /// </summary>
        public bvec5 gbrba => new bvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.yzxw swizzling.
        /// </summary>
        public bvec4 yzxw => new bvec4(y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.gbra swizzling (equivalent to bvec4.yzxw).
        /// </summary>
        public bvec4 gbra => new bvec4(y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.yzxwx swizzling.
        /// </summary>
        public bvec5 yzxwx => new bvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.gbrar swizzling (equivalent to bvec4.yzxwx).
        /// </summary>
        public bvec5 gbrar => new bvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.yzxwy swizzling.
        /// </summary>
        public bvec5 yzxwy => new bvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.gbrag swizzling (equivalent to bvec4.yzxwy).
        /// </summary>
        public bvec5 gbrag => new bvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.yzxwz swizzling.
        /// </summary>
        public bvec5 yzxwz => new bvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.gbrab swizzling (equivalent to bvec4.yzxwz).
        /// </summary>
        public bvec5 gbrab => new bvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.yzxww swizzling.
        /// </summary>
        public bvec5 yzxww => new bvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.gbraa swizzling (equivalent to bvec4.yzxww).
        /// </summary>
        public bvec5 gbraa => new bvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.yzy swizzling.
        /// </summary>
        public bvec3 yzy => new bvec3(y, z, y);
        
        /// <summary>
        /// Returns bvec4.gbg swizzling (equivalent to bvec4.yzy).
        /// </summary>
        public bvec3 gbg => new bvec3(y, z, y);
        
        /// <summary>
        /// Returns bvec4.yzyx swizzling.
        /// </summary>
        public bvec4 yzyx => new bvec4(y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.gbgr swizzling (equivalent to bvec4.yzyx).
        /// </summary>
        public bvec4 gbgr => new bvec4(y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.yzyxx swizzling.
        /// </summary>
        public bvec5 yzyxx => new bvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.gbgrr swizzling (equivalent to bvec4.yzyxx).
        /// </summary>
        public bvec5 gbgrr => new bvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.yzyxy swizzling.
        /// </summary>
        public bvec5 yzyxy => new bvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.gbgrg swizzling (equivalent to bvec4.yzyxy).
        /// </summary>
        public bvec5 gbgrg => new bvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.yzyxz swizzling.
        /// </summary>
        public bvec5 yzyxz => new bvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.gbgrb swizzling (equivalent to bvec4.yzyxz).
        /// </summary>
        public bvec5 gbgrb => new bvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.yzyxw swizzling.
        /// </summary>
        public bvec5 yzyxw => new bvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.gbgra swizzling (equivalent to bvec4.yzyxw).
        /// </summary>
        public bvec5 gbgra => new bvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.yzyy swizzling.
        /// </summary>
        public bvec4 yzyy => new bvec4(y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.gbgg swizzling (equivalent to bvec4.yzyy).
        /// </summary>
        public bvec4 gbgg => new bvec4(y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.yzyyx swizzling.
        /// </summary>
        public bvec5 yzyyx => new bvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.gbggr swizzling (equivalent to bvec4.yzyyx).
        /// </summary>
        public bvec5 gbggr => new bvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.yzyyy swizzling.
        /// </summary>
        public bvec5 yzyyy => new bvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.gbggg swizzling (equivalent to bvec4.yzyyy).
        /// </summary>
        public bvec5 gbggg => new bvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.yzyyz swizzling.
        /// </summary>
        public bvec5 yzyyz => new bvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.gbggb swizzling (equivalent to bvec4.yzyyz).
        /// </summary>
        public bvec5 gbggb => new bvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.yzyyw swizzling.
        /// </summary>
        public bvec5 yzyyw => new bvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.gbgga swizzling (equivalent to bvec4.yzyyw).
        /// </summary>
        public bvec5 gbgga => new bvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.yzyz swizzling.
        /// </summary>
        public bvec4 yzyz => new bvec4(y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.gbgb swizzling (equivalent to bvec4.yzyz).
        /// </summary>
        public bvec4 gbgb => new bvec4(y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.yzyzx swizzling.
        /// </summary>
        public bvec5 yzyzx => new bvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.gbgbr swizzling (equivalent to bvec4.yzyzx).
        /// </summary>
        public bvec5 gbgbr => new bvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.yzyzy swizzling.
        /// </summary>
        public bvec5 yzyzy => new bvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.gbgbg swizzling (equivalent to bvec4.yzyzy).
        /// </summary>
        public bvec5 gbgbg => new bvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.yzyzz swizzling.
        /// </summary>
        public bvec5 yzyzz => new bvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.gbgbb swizzling (equivalent to bvec4.yzyzz).
        /// </summary>
        public bvec5 gbgbb => new bvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.yzyzw swizzling.
        /// </summary>
        public bvec5 yzyzw => new bvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.gbgba swizzling (equivalent to bvec4.yzyzw).
        /// </summary>
        public bvec5 gbgba => new bvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.yzyw swizzling.
        /// </summary>
        public bvec4 yzyw => new bvec4(y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.gbga swizzling (equivalent to bvec4.yzyw).
        /// </summary>
        public bvec4 gbga => new bvec4(y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.yzywx swizzling.
        /// </summary>
        public bvec5 yzywx => new bvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.gbgar swizzling (equivalent to bvec4.yzywx).
        /// </summary>
        public bvec5 gbgar => new bvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.yzywy swizzling.
        /// </summary>
        public bvec5 yzywy => new bvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.gbgag swizzling (equivalent to bvec4.yzywy).
        /// </summary>
        public bvec5 gbgag => new bvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.yzywz swizzling.
        /// </summary>
        public bvec5 yzywz => new bvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.gbgab swizzling (equivalent to bvec4.yzywz).
        /// </summary>
        public bvec5 gbgab => new bvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.yzyww swizzling.
        /// </summary>
        public bvec5 yzyww => new bvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.gbgaa swizzling (equivalent to bvec4.yzyww).
        /// </summary>
        public bvec5 gbgaa => new bvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.yzz swizzling.
        /// </summary>
        public bvec3 yzz => new bvec3(y, z, z);
        
        /// <summary>
        /// Returns bvec4.gbb swizzling (equivalent to bvec4.yzz).
        /// </summary>
        public bvec3 gbb => new bvec3(y, z, z);
        
        /// <summary>
        /// Returns bvec4.yzzx swizzling.
        /// </summary>
        public bvec4 yzzx => new bvec4(y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.gbbr swizzling (equivalent to bvec4.yzzx).
        /// </summary>
        public bvec4 gbbr => new bvec4(y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.yzzxx swizzling.
        /// </summary>
        public bvec5 yzzxx => new bvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.gbbrr swizzling (equivalent to bvec4.yzzxx).
        /// </summary>
        public bvec5 gbbrr => new bvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.yzzxy swizzling.
        /// </summary>
        public bvec5 yzzxy => new bvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.gbbrg swizzling (equivalent to bvec4.yzzxy).
        /// </summary>
        public bvec5 gbbrg => new bvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.yzzxz swizzling.
        /// </summary>
        public bvec5 yzzxz => new bvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.gbbrb swizzling (equivalent to bvec4.yzzxz).
        /// </summary>
        public bvec5 gbbrb => new bvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.yzzxw swizzling.
        /// </summary>
        public bvec5 yzzxw => new bvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.gbbra swizzling (equivalent to bvec4.yzzxw).
        /// </summary>
        public bvec5 gbbra => new bvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.yzzy swizzling.
        /// </summary>
        public bvec4 yzzy => new bvec4(y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.gbbg swizzling (equivalent to bvec4.yzzy).
        /// </summary>
        public bvec4 gbbg => new bvec4(y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.yzzyx swizzling.
        /// </summary>
        public bvec5 yzzyx => new bvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.gbbgr swizzling (equivalent to bvec4.yzzyx).
        /// </summary>
        public bvec5 gbbgr => new bvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.yzzyy swizzling.
        /// </summary>
        public bvec5 yzzyy => new bvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.gbbgg swizzling (equivalent to bvec4.yzzyy).
        /// </summary>
        public bvec5 gbbgg => new bvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.yzzyz swizzling.
        /// </summary>
        public bvec5 yzzyz => new bvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.gbbgb swizzling (equivalent to bvec4.yzzyz).
        /// </summary>
        public bvec5 gbbgb => new bvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.yzzyw swizzling.
        /// </summary>
        public bvec5 yzzyw => new bvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.gbbga swizzling (equivalent to bvec4.yzzyw).
        /// </summary>
        public bvec5 gbbga => new bvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.yzzz swizzling.
        /// </summary>
        public bvec4 yzzz => new bvec4(y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.gbbb swizzling (equivalent to bvec4.yzzz).
        /// </summary>
        public bvec4 gbbb => new bvec4(y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.yzzzx swizzling.
        /// </summary>
        public bvec5 yzzzx => new bvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.gbbbr swizzling (equivalent to bvec4.yzzzx).
        /// </summary>
        public bvec5 gbbbr => new bvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.yzzzy swizzling.
        /// </summary>
        public bvec5 yzzzy => new bvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.gbbbg swizzling (equivalent to bvec4.yzzzy).
        /// </summary>
        public bvec5 gbbbg => new bvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.yzzzz swizzling.
        /// </summary>
        public bvec5 yzzzz => new bvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.gbbbb swizzling (equivalent to bvec4.yzzzz).
        /// </summary>
        public bvec5 gbbbb => new bvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.yzzzw swizzling.
        /// </summary>
        public bvec5 yzzzw => new bvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.gbbba swizzling (equivalent to bvec4.yzzzw).
        /// </summary>
        public bvec5 gbbba => new bvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.yzzw swizzling.
        /// </summary>
        public bvec4 yzzw => new bvec4(y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.gbba swizzling (equivalent to bvec4.yzzw).
        /// </summary>
        public bvec4 gbba => new bvec4(y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.yzzwx swizzling.
        /// </summary>
        public bvec5 yzzwx => new bvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.gbbar swizzling (equivalent to bvec4.yzzwx).
        /// </summary>
        public bvec5 gbbar => new bvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.yzzwy swizzling.
        /// </summary>
        public bvec5 yzzwy => new bvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.gbbag swizzling (equivalent to bvec4.yzzwy).
        /// </summary>
        public bvec5 gbbag => new bvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.yzzwz swizzling.
        /// </summary>
        public bvec5 yzzwz => new bvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.gbbab swizzling (equivalent to bvec4.yzzwz).
        /// </summary>
        public bvec5 gbbab => new bvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.yzzww swizzling.
        /// </summary>
        public bvec5 yzzww => new bvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.gbbaa swizzling (equivalent to bvec4.yzzww).
        /// </summary>
        public bvec5 gbbaa => new bvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.yzw swizzling.
        /// </summary>
        public bvec3 yzw => new bvec3(y, z, w);
        
        /// <summary>
        /// Returns bvec4.gba swizzling (equivalent to bvec4.yzw).
        /// </summary>
        public bvec3 gba => new bvec3(y, z, w);
        
        /// <summary>
        /// Returns bvec4.yzwx swizzling.
        /// </summary>
        public bvec4 yzwx => new bvec4(y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.gbar swizzling (equivalent to bvec4.yzwx).
        /// </summary>
        public bvec4 gbar => new bvec4(y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.yzwxx swizzling.
        /// </summary>
        public bvec5 yzwxx => new bvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.gbarr swizzling (equivalent to bvec4.yzwxx).
        /// </summary>
        public bvec5 gbarr => new bvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.yzwxy swizzling.
        /// </summary>
        public bvec5 yzwxy => new bvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.gbarg swizzling (equivalent to bvec4.yzwxy).
        /// </summary>
        public bvec5 gbarg => new bvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.yzwxz swizzling.
        /// </summary>
        public bvec5 yzwxz => new bvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.gbarb swizzling (equivalent to bvec4.yzwxz).
        /// </summary>
        public bvec5 gbarb => new bvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.yzwxw swizzling.
        /// </summary>
        public bvec5 yzwxw => new bvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.gbara swizzling (equivalent to bvec4.yzwxw).
        /// </summary>
        public bvec5 gbara => new bvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.yzwy swizzling.
        /// </summary>
        public bvec4 yzwy => new bvec4(y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.gbag swizzling (equivalent to bvec4.yzwy).
        /// </summary>
        public bvec4 gbag => new bvec4(y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.yzwyx swizzling.
        /// </summary>
        public bvec5 yzwyx => new bvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.gbagr swizzling (equivalent to bvec4.yzwyx).
        /// </summary>
        public bvec5 gbagr => new bvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.yzwyy swizzling.
        /// </summary>
        public bvec5 yzwyy => new bvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.gbagg swizzling (equivalent to bvec4.yzwyy).
        /// </summary>
        public bvec5 gbagg => new bvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.yzwyz swizzling.
        /// </summary>
        public bvec5 yzwyz => new bvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.gbagb swizzling (equivalent to bvec4.yzwyz).
        /// </summary>
        public bvec5 gbagb => new bvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.yzwyw swizzling.
        /// </summary>
        public bvec5 yzwyw => new bvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.gbaga swizzling (equivalent to bvec4.yzwyw).
        /// </summary>
        public bvec5 gbaga => new bvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.yzwz swizzling.
        /// </summary>
        public bvec4 yzwz => new bvec4(y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.gbab swizzling (equivalent to bvec4.yzwz).
        /// </summary>
        public bvec4 gbab => new bvec4(y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.yzwzx swizzling.
        /// </summary>
        public bvec5 yzwzx => new bvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.gbabr swizzling (equivalent to bvec4.yzwzx).
        /// </summary>
        public bvec5 gbabr => new bvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.yzwzy swizzling.
        /// </summary>
        public bvec5 yzwzy => new bvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.gbabg swizzling (equivalent to bvec4.yzwzy).
        /// </summary>
        public bvec5 gbabg => new bvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.yzwzz swizzling.
        /// </summary>
        public bvec5 yzwzz => new bvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.gbabb swizzling (equivalent to bvec4.yzwzz).
        /// </summary>
        public bvec5 gbabb => new bvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.yzwzw swizzling.
        /// </summary>
        public bvec5 yzwzw => new bvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.gbaba swizzling (equivalent to bvec4.yzwzw).
        /// </summary>
        public bvec5 gbaba => new bvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.yzww swizzling.
        /// </summary>
        public bvec4 yzww => new bvec4(y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.gbaa swizzling (equivalent to bvec4.yzww).
        /// </summary>
        public bvec4 gbaa => new bvec4(y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.yzwwx swizzling.
        /// </summary>
        public bvec5 yzwwx => new bvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.gbaar swizzling (equivalent to bvec4.yzwwx).
        /// </summary>
        public bvec5 gbaar => new bvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.yzwwy swizzling.
        /// </summary>
        public bvec5 yzwwy => new bvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.gbaag swizzling (equivalent to bvec4.yzwwy).
        /// </summary>
        public bvec5 gbaag => new bvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.yzwwz swizzling.
        /// </summary>
        public bvec5 yzwwz => new bvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.gbaab swizzling (equivalent to bvec4.yzwwz).
        /// </summary>
        public bvec5 gbaab => new bvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.yzwww swizzling.
        /// </summary>
        public bvec5 yzwww => new bvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.gbaaa swizzling (equivalent to bvec4.yzwww).
        /// </summary>
        public bvec5 gbaaa => new bvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.yw swizzling.
        /// </summary>
        public bvec2 yw => new bvec2(y, w);
        
        /// <summary>
        /// Returns bvec4.ga swizzling (equivalent to bvec4.yw).
        /// </summary>
        public bvec2 ga => new bvec2(y, w);
        
        /// <summary>
        /// Returns bvec4.ywx swizzling.
        /// </summary>
        public bvec3 ywx => new bvec3(y, w, x);
        
        /// <summary>
        /// Returns bvec4.gar swizzling (equivalent to bvec4.ywx).
        /// </summary>
        public bvec3 gar => new bvec3(y, w, x);
        
        /// <summary>
        /// Returns bvec4.ywxx swizzling.
        /// </summary>
        public bvec4 ywxx => new bvec4(y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.garr swizzling (equivalent to bvec4.ywxx).
        /// </summary>
        public bvec4 garr => new bvec4(y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.ywxxx swizzling.
        /// </summary>
        public bvec5 ywxxx => new bvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.garrr swizzling (equivalent to bvec4.ywxxx).
        /// </summary>
        public bvec5 garrr => new bvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.ywxxy swizzling.
        /// </summary>
        public bvec5 ywxxy => new bvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.garrg swizzling (equivalent to bvec4.ywxxy).
        /// </summary>
        public bvec5 garrg => new bvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.ywxxz swizzling.
        /// </summary>
        public bvec5 ywxxz => new bvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.garrb swizzling (equivalent to bvec4.ywxxz).
        /// </summary>
        public bvec5 garrb => new bvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.ywxxw swizzling.
        /// </summary>
        public bvec5 ywxxw => new bvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.garra swizzling (equivalent to bvec4.ywxxw).
        /// </summary>
        public bvec5 garra => new bvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.ywxy swizzling.
        /// </summary>
        public bvec4 ywxy => new bvec4(y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.garg swizzling (equivalent to bvec4.ywxy).
        /// </summary>
        public bvec4 garg => new bvec4(y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.ywxyx swizzling.
        /// </summary>
        public bvec5 ywxyx => new bvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.gargr swizzling (equivalent to bvec4.ywxyx).
        /// </summary>
        public bvec5 gargr => new bvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.ywxyy swizzling.
        /// </summary>
        public bvec5 ywxyy => new bvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.gargg swizzling (equivalent to bvec4.ywxyy).
        /// </summary>
        public bvec5 gargg => new bvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.ywxyz swizzling.
        /// </summary>
        public bvec5 ywxyz => new bvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.gargb swizzling (equivalent to bvec4.ywxyz).
        /// </summary>
        public bvec5 gargb => new bvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.ywxyw swizzling.
        /// </summary>
        public bvec5 ywxyw => new bvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.garga swizzling (equivalent to bvec4.ywxyw).
        /// </summary>
        public bvec5 garga => new bvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.ywxz swizzling.
        /// </summary>
        public bvec4 ywxz => new bvec4(y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.garb swizzling (equivalent to bvec4.ywxz).
        /// </summary>
        public bvec4 garb => new bvec4(y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.ywxzx swizzling.
        /// </summary>
        public bvec5 ywxzx => new bvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.garbr swizzling (equivalent to bvec4.ywxzx).
        /// </summary>
        public bvec5 garbr => new bvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.ywxzy swizzling.
        /// </summary>
        public bvec5 ywxzy => new bvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.garbg swizzling (equivalent to bvec4.ywxzy).
        /// </summary>
        public bvec5 garbg => new bvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.ywxzz swizzling.
        /// </summary>
        public bvec5 ywxzz => new bvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.garbb swizzling (equivalent to bvec4.ywxzz).
        /// </summary>
        public bvec5 garbb => new bvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.ywxzw swizzling.
        /// </summary>
        public bvec5 ywxzw => new bvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.garba swizzling (equivalent to bvec4.ywxzw).
        /// </summary>
        public bvec5 garba => new bvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.ywxw swizzling.
        /// </summary>
        public bvec4 ywxw => new bvec4(y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.gara swizzling (equivalent to bvec4.ywxw).
        /// </summary>
        public bvec4 gara => new bvec4(y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.ywxwx swizzling.
        /// </summary>
        public bvec5 ywxwx => new bvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.garar swizzling (equivalent to bvec4.ywxwx).
        /// </summary>
        public bvec5 garar => new bvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.ywxwy swizzling.
        /// </summary>
        public bvec5 ywxwy => new bvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.garag swizzling (equivalent to bvec4.ywxwy).
        /// </summary>
        public bvec5 garag => new bvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.ywxwz swizzling.
        /// </summary>
        public bvec5 ywxwz => new bvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.garab swizzling (equivalent to bvec4.ywxwz).
        /// </summary>
        public bvec5 garab => new bvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.ywxww swizzling.
        /// </summary>
        public bvec5 ywxww => new bvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.garaa swizzling (equivalent to bvec4.ywxww).
        /// </summary>
        public bvec5 garaa => new bvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.ywy swizzling.
        /// </summary>
        public bvec3 ywy => new bvec3(y, w, y);
        
        /// <summary>
        /// Returns bvec4.gag swizzling (equivalent to bvec4.ywy).
        /// </summary>
        public bvec3 gag => new bvec3(y, w, y);
        
        /// <summary>
        /// Returns bvec4.ywyx swizzling.
        /// </summary>
        public bvec4 ywyx => new bvec4(y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.gagr swizzling (equivalent to bvec4.ywyx).
        /// </summary>
        public bvec4 gagr => new bvec4(y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.ywyxx swizzling.
        /// </summary>
        public bvec5 ywyxx => new bvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.gagrr swizzling (equivalent to bvec4.ywyxx).
        /// </summary>
        public bvec5 gagrr => new bvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.ywyxy swizzling.
        /// </summary>
        public bvec5 ywyxy => new bvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.gagrg swizzling (equivalent to bvec4.ywyxy).
        /// </summary>
        public bvec5 gagrg => new bvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.ywyxz swizzling.
        /// </summary>
        public bvec5 ywyxz => new bvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.gagrb swizzling (equivalent to bvec4.ywyxz).
        /// </summary>
        public bvec5 gagrb => new bvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.ywyxw swizzling.
        /// </summary>
        public bvec5 ywyxw => new bvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.gagra swizzling (equivalent to bvec4.ywyxw).
        /// </summary>
        public bvec5 gagra => new bvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.ywyy swizzling.
        /// </summary>
        public bvec4 ywyy => new bvec4(y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.gagg swizzling (equivalent to bvec4.ywyy).
        /// </summary>
        public bvec4 gagg => new bvec4(y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.ywyyx swizzling.
        /// </summary>
        public bvec5 ywyyx => new bvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.gaggr swizzling (equivalent to bvec4.ywyyx).
        /// </summary>
        public bvec5 gaggr => new bvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.ywyyy swizzling.
        /// </summary>
        public bvec5 ywyyy => new bvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.gaggg swizzling (equivalent to bvec4.ywyyy).
        /// </summary>
        public bvec5 gaggg => new bvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.ywyyz swizzling.
        /// </summary>
        public bvec5 ywyyz => new bvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.gaggb swizzling (equivalent to bvec4.ywyyz).
        /// </summary>
        public bvec5 gaggb => new bvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.ywyyw swizzling.
        /// </summary>
        public bvec5 ywyyw => new bvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.gagga swizzling (equivalent to bvec4.ywyyw).
        /// </summary>
        public bvec5 gagga => new bvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.ywyz swizzling.
        /// </summary>
        public bvec4 ywyz => new bvec4(y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.gagb swizzling (equivalent to bvec4.ywyz).
        /// </summary>
        public bvec4 gagb => new bvec4(y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.ywyzx swizzling.
        /// </summary>
        public bvec5 ywyzx => new bvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.gagbr swizzling (equivalent to bvec4.ywyzx).
        /// </summary>
        public bvec5 gagbr => new bvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.ywyzy swizzling.
        /// </summary>
        public bvec5 ywyzy => new bvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.gagbg swizzling (equivalent to bvec4.ywyzy).
        /// </summary>
        public bvec5 gagbg => new bvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.ywyzz swizzling.
        /// </summary>
        public bvec5 ywyzz => new bvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.gagbb swizzling (equivalent to bvec4.ywyzz).
        /// </summary>
        public bvec5 gagbb => new bvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.ywyzw swizzling.
        /// </summary>
        public bvec5 ywyzw => new bvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.gagba swizzling (equivalent to bvec4.ywyzw).
        /// </summary>
        public bvec5 gagba => new bvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.ywyw swizzling.
        /// </summary>
        public bvec4 ywyw => new bvec4(y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.gaga swizzling (equivalent to bvec4.ywyw).
        /// </summary>
        public bvec4 gaga => new bvec4(y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.ywywx swizzling.
        /// </summary>
        public bvec5 ywywx => new bvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.gagar swizzling (equivalent to bvec4.ywywx).
        /// </summary>
        public bvec5 gagar => new bvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.ywywy swizzling.
        /// </summary>
        public bvec5 ywywy => new bvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.gagag swizzling (equivalent to bvec4.ywywy).
        /// </summary>
        public bvec5 gagag => new bvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.ywywz swizzling.
        /// </summary>
        public bvec5 ywywz => new bvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.gagab swizzling (equivalent to bvec4.ywywz).
        /// </summary>
        public bvec5 gagab => new bvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.ywyww swizzling.
        /// </summary>
        public bvec5 ywyww => new bvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.gagaa swizzling (equivalent to bvec4.ywyww).
        /// </summary>
        public bvec5 gagaa => new bvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.ywz swizzling.
        /// </summary>
        public bvec3 ywz => new bvec3(y, w, z);
        
        /// <summary>
        /// Returns bvec4.gab swizzling (equivalent to bvec4.ywz).
        /// </summary>
        public bvec3 gab => new bvec3(y, w, z);
        
        /// <summary>
        /// Returns bvec4.ywzx swizzling.
        /// </summary>
        public bvec4 ywzx => new bvec4(y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.gabr swizzling (equivalent to bvec4.ywzx).
        /// </summary>
        public bvec4 gabr => new bvec4(y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.ywzxx swizzling.
        /// </summary>
        public bvec5 ywzxx => new bvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.gabrr swizzling (equivalent to bvec4.ywzxx).
        /// </summary>
        public bvec5 gabrr => new bvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.ywzxy swizzling.
        /// </summary>
        public bvec5 ywzxy => new bvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.gabrg swizzling (equivalent to bvec4.ywzxy).
        /// </summary>
        public bvec5 gabrg => new bvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.ywzxz swizzling.
        /// </summary>
        public bvec5 ywzxz => new bvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.gabrb swizzling (equivalent to bvec4.ywzxz).
        /// </summary>
        public bvec5 gabrb => new bvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.ywzxw swizzling.
        /// </summary>
        public bvec5 ywzxw => new bvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.gabra swizzling (equivalent to bvec4.ywzxw).
        /// </summary>
        public bvec5 gabra => new bvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.ywzy swizzling.
        /// </summary>
        public bvec4 ywzy => new bvec4(y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.gabg swizzling (equivalent to bvec4.ywzy).
        /// </summary>
        public bvec4 gabg => new bvec4(y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.ywzyx swizzling.
        /// </summary>
        public bvec5 ywzyx => new bvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.gabgr swizzling (equivalent to bvec4.ywzyx).
        /// </summary>
        public bvec5 gabgr => new bvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.ywzyy swizzling.
        /// </summary>
        public bvec5 ywzyy => new bvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.gabgg swizzling (equivalent to bvec4.ywzyy).
        /// </summary>
        public bvec5 gabgg => new bvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.ywzyz swizzling.
        /// </summary>
        public bvec5 ywzyz => new bvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.gabgb swizzling (equivalent to bvec4.ywzyz).
        /// </summary>
        public bvec5 gabgb => new bvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.ywzyw swizzling.
        /// </summary>
        public bvec5 ywzyw => new bvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.gabga swizzling (equivalent to bvec4.ywzyw).
        /// </summary>
        public bvec5 gabga => new bvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.ywzz swizzling.
        /// </summary>
        public bvec4 ywzz => new bvec4(y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.gabb swizzling (equivalent to bvec4.ywzz).
        /// </summary>
        public bvec4 gabb => new bvec4(y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.ywzzx swizzling.
        /// </summary>
        public bvec5 ywzzx => new bvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.gabbr swizzling (equivalent to bvec4.ywzzx).
        /// </summary>
        public bvec5 gabbr => new bvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.ywzzy swizzling.
        /// </summary>
        public bvec5 ywzzy => new bvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.gabbg swizzling (equivalent to bvec4.ywzzy).
        /// </summary>
        public bvec5 gabbg => new bvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.ywzzz swizzling.
        /// </summary>
        public bvec5 ywzzz => new bvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.gabbb swizzling (equivalent to bvec4.ywzzz).
        /// </summary>
        public bvec5 gabbb => new bvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.ywzzw swizzling.
        /// </summary>
        public bvec5 ywzzw => new bvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.gabba swizzling (equivalent to bvec4.ywzzw).
        /// </summary>
        public bvec5 gabba => new bvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.ywzw swizzling.
        /// </summary>
        public bvec4 ywzw => new bvec4(y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.gaba swizzling (equivalent to bvec4.ywzw).
        /// </summary>
        public bvec4 gaba => new bvec4(y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.ywzwx swizzling.
        /// </summary>
        public bvec5 ywzwx => new bvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.gabar swizzling (equivalent to bvec4.ywzwx).
        /// </summary>
        public bvec5 gabar => new bvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.ywzwy swizzling.
        /// </summary>
        public bvec5 ywzwy => new bvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.gabag swizzling (equivalent to bvec4.ywzwy).
        /// </summary>
        public bvec5 gabag => new bvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.ywzwz swizzling.
        /// </summary>
        public bvec5 ywzwz => new bvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.gabab swizzling (equivalent to bvec4.ywzwz).
        /// </summary>
        public bvec5 gabab => new bvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.ywzww swizzling.
        /// </summary>
        public bvec5 ywzww => new bvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.gabaa swizzling (equivalent to bvec4.ywzww).
        /// </summary>
        public bvec5 gabaa => new bvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.yww swizzling.
        /// </summary>
        public bvec3 yww => new bvec3(y, w, w);
        
        /// <summary>
        /// Returns bvec4.gaa swizzling (equivalent to bvec4.yww).
        /// </summary>
        public bvec3 gaa => new bvec3(y, w, w);
        
        /// <summary>
        /// Returns bvec4.ywwx swizzling.
        /// </summary>
        public bvec4 ywwx => new bvec4(y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.gaar swizzling (equivalent to bvec4.ywwx).
        /// </summary>
        public bvec4 gaar => new bvec4(y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.ywwxx swizzling.
        /// </summary>
        public bvec5 ywwxx => new bvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.gaarr swizzling (equivalent to bvec4.ywwxx).
        /// </summary>
        public bvec5 gaarr => new bvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.ywwxy swizzling.
        /// </summary>
        public bvec5 ywwxy => new bvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.gaarg swizzling (equivalent to bvec4.ywwxy).
        /// </summary>
        public bvec5 gaarg => new bvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.ywwxz swizzling.
        /// </summary>
        public bvec5 ywwxz => new bvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.gaarb swizzling (equivalent to bvec4.ywwxz).
        /// </summary>
        public bvec5 gaarb => new bvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.ywwxw swizzling.
        /// </summary>
        public bvec5 ywwxw => new bvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.gaara swizzling (equivalent to bvec4.ywwxw).
        /// </summary>
        public bvec5 gaara => new bvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.ywwy swizzling.
        /// </summary>
        public bvec4 ywwy => new bvec4(y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.gaag swizzling (equivalent to bvec4.ywwy).
        /// </summary>
        public bvec4 gaag => new bvec4(y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.ywwyx swizzling.
        /// </summary>
        public bvec5 ywwyx => new bvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.gaagr swizzling (equivalent to bvec4.ywwyx).
        /// </summary>
        public bvec5 gaagr => new bvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.ywwyy swizzling.
        /// </summary>
        public bvec5 ywwyy => new bvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.gaagg swizzling (equivalent to bvec4.ywwyy).
        /// </summary>
        public bvec5 gaagg => new bvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.ywwyz swizzling.
        /// </summary>
        public bvec5 ywwyz => new bvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.gaagb swizzling (equivalent to bvec4.ywwyz).
        /// </summary>
        public bvec5 gaagb => new bvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.ywwyw swizzling.
        /// </summary>
        public bvec5 ywwyw => new bvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.gaaga swizzling (equivalent to bvec4.ywwyw).
        /// </summary>
        public bvec5 gaaga => new bvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.ywwz swizzling.
        /// </summary>
        public bvec4 ywwz => new bvec4(y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.gaab swizzling (equivalent to bvec4.ywwz).
        /// </summary>
        public bvec4 gaab => new bvec4(y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.ywwzx swizzling.
        /// </summary>
        public bvec5 ywwzx => new bvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.gaabr swizzling (equivalent to bvec4.ywwzx).
        /// </summary>
        public bvec5 gaabr => new bvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.ywwzy swizzling.
        /// </summary>
        public bvec5 ywwzy => new bvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.gaabg swizzling (equivalent to bvec4.ywwzy).
        /// </summary>
        public bvec5 gaabg => new bvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.ywwzz swizzling.
        /// </summary>
        public bvec5 ywwzz => new bvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.gaabb swizzling (equivalent to bvec4.ywwzz).
        /// </summary>
        public bvec5 gaabb => new bvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.ywwzw swizzling.
        /// </summary>
        public bvec5 ywwzw => new bvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.gaaba swizzling (equivalent to bvec4.ywwzw).
        /// </summary>
        public bvec5 gaaba => new bvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.ywww swizzling.
        /// </summary>
        public bvec4 ywww => new bvec4(y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.gaaa swizzling (equivalent to bvec4.ywww).
        /// </summary>
        public bvec4 gaaa => new bvec4(y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.ywwwx swizzling.
        /// </summary>
        public bvec5 ywwwx => new bvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.gaaar swizzling (equivalent to bvec4.ywwwx).
        /// </summary>
        public bvec5 gaaar => new bvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.ywwwy swizzling.
        /// </summary>
        public bvec5 ywwwy => new bvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.gaaag swizzling (equivalent to bvec4.ywwwy).
        /// </summary>
        public bvec5 gaaag => new bvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.ywwwz swizzling.
        /// </summary>
        public bvec5 ywwwz => new bvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.gaaab swizzling (equivalent to bvec4.ywwwz).
        /// </summary>
        public bvec5 gaaab => new bvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.ywwww swizzling.
        /// </summary>
        public bvec5 ywwww => new bvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns bvec4.gaaaa swizzling (equivalent to bvec4.ywwww).
        /// </summary>
        public bvec5 gaaaa => new bvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns bvec4.zx swizzling.
        /// </summary>
        public bvec2 zx => new bvec2(z, x);
        
        /// <summary>
        /// Returns bvec4.br swizzling (equivalent to bvec4.zx).
        /// </summary>
        public bvec2 br => new bvec2(z, x);
        
        /// <summary>
        /// Returns bvec4.zxx swizzling.
        /// </summary>
        public bvec3 zxx => new bvec3(z, x, x);
        
        /// <summary>
        /// Returns bvec4.brr swizzling (equivalent to bvec4.zxx).
        /// </summary>
        public bvec3 brr => new bvec3(z, x, x);
        
        /// <summary>
        /// Returns bvec4.zxxx swizzling.
        /// </summary>
        public bvec4 zxxx => new bvec4(z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.brrr swizzling (equivalent to bvec4.zxxx).
        /// </summary>
        public bvec4 brrr => new bvec4(z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.zxxxx swizzling.
        /// </summary>
        public bvec5 zxxxx => new bvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.brrrr swizzling (equivalent to bvec4.zxxxx).
        /// </summary>
        public bvec5 brrrr => new bvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.zxxxy swizzling.
        /// </summary>
        public bvec5 zxxxy => new bvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.brrrg swizzling (equivalent to bvec4.zxxxy).
        /// </summary>
        public bvec5 brrrg => new bvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.zxxxz swizzling.
        /// </summary>
        public bvec5 zxxxz => new bvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.brrrb swizzling (equivalent to bvec4.zxxxz).
        /// </summary>
        public bvec5 brrrb => new bvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.zxxxw swizzling.
        /// </summary>
        public bvec5 zxxxw => new bvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.brrra swizzling (equivalent to bvec4.zxxxw).
        /// </summary>
        public bvec5 brrra => new bvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.zxxy swizzling.
        /// </summary>
        public bvec4 zxxy => new bvec4(z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.brrg swizzling (equivalent to bvec4.zxxy).
        /// </summary>
        public bvec4 brrg => new bvec4(z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.zxxyx swizzling.
        /// </summary>
        public bvec5 zxxyx => new bvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.brrgr swizzling (equivalent to bvec4.zxxyx).
        /// </summary>
        public bvec5 brrgr => new bvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.zxxyy swizzling.
        /// </summary>
        public bvec5 zxxyy => new bvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.brrgg swizzling (equivalent to bvec4.zxxyy).
        /// </summary>
        public bvec5 brrgg => new bvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.zxxyz swizzling.
        /// </summary>
        public bvec5 zxxyz => new bvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.brrgb swizzling (equivalent to bvec4.zxxyz).
        /// </summary>
        public bvec5 brrgb => new bvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.zxxyw swizzling.
        /// </summary>
        public bvec5 zxxyw => new bvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.brrga swizzling (equivalent to bvec4.zxxyw).
        /// </summary>
        public bvec5 brrga => new bvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.zxxz swizzling.
        /// </summary>
        public bvec4 zxxz => new bvec4(z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.brrb swizzling (equivalent to bvec4.zxxz).
        /// </summary>
        public bvec4 brrb => new bvec4(z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.zxxzx swizzling.
        /// </summary>
        public bvec5 zxxzx => new bvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.brrbr swizzling (equivalent to bvec4.zxxzx).
        /// </summary>
        public bvec5 brrbr => new bvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.zxxzy swizzling.
        /// </summary>
        public bvec5 zxxzy => new bvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.brrbg swizzling (equivalent to bvec4.zxxzy).
        /// </summary>
        public bvec5 brrbg => new bvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.zxxzz swizzling.
        /// </summary>
        public bvec5 zxxzz => new bvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.brrbb swizzling (equivalent to bvec4.zxxzz).
        /// </summary>
        public bvec5 brrbb => new bvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.zxxzw swizzling.
        /// </summary>
        public bvec5 zxxzw => new bvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.brrba swizzling (equivalent to bvec4.zxxzw).
        /// </summary>
        public bvec5 brrba => new bvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.zxxw swizzling.
        /// </summary>
        public bvec4 zxxw => new bvec4(z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.brra swizzling (equivalent to bvec4.zxxw).
        /// </summary>
        public bvec4 brra => new bvec4(z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.zxxwx swizzling.
        /// </summary>
        public bvec5 zxxwx => new bvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.brrar swizzling (equivalent to bvec4.zxxwx).
        /// </summary>
        public bvec5 brrar => new bvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.zxxwy swizzling.
        /// </summary>
        public bvec5 zxxwy => new bvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.brrag swizzling (equivalent to bvec4.zxxwy).
        /// </summary>
        public bvec5 brrag => new bvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.zxxwz swizzling.
        /// </summary>
        public bvec5 zxxwz => new bvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.brrab swizzling (equivalent to bvec4.zxxwz).
        /// </summary>
        public bvec5 brrab => new bvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.zxxww swizzling.
        /// </summary>
        public bvec5 zxxww => new bvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.brraa swizzling (equivalent to bvec4.zxxww).
        /// </summary>
        public bvec5 brraa => new bvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.zxy swizzling.
        /// </summary>
        public bvec3 zxy => new bvec3(z, x, y);
        
        /// <summary>
        /// Returns bvec4.brg swizzling (equivalent to bvec4.zxy).
        /// </summary>
        public bvec3 brg => new bvec3(z, x, y);
        
        /// <summary>
        /// Returns bvec4.zxyx swizzling.
        /// </summary>
        public bvec4 zxyx => new bvec4(z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.brgr swizzling (equivalent to bvec4.zxyx).
        /// </summary>
        public bvec4 brgr => new bvec4(z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.zxyxx swizzling.
        /// </summary>
        public bvec5 zxyxx => new bvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.brgrr swizzling (equivalent to bvec4.zxyxx).
        /// </summary>
        public bvec5 brgrr => new bvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.zxyxy swizzling.
        /// </summary>
        public bvec5 zxyxy => new bvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.brgrg swizzling (equivalent to bvec4.zxyxy).
        /// </summary>
        public bvec5 brgrg => new bvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.zxyxz swizzling.
        /// </summary>
        public bvec5 zxyxz => new bvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.brgrb swizzling (equivalent to bvec4.zxyxz).
        /// </summary>
        public bvec5 brgrb => new bvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.zxyxw swizzling.
        /// </summary>
        public bvec5 zxyxw => new bvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.brgra swizzling (equivalent to bvec4.zxyxw).
        /// </summary>
        public bvec5 brgra => new bvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.zxyy swizzling.
        /// </summary>
        public bvec4 zxyy => new bvec4(z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.brgg swizzling (equivalent to bvec4.zxyy).
        /// </summary>
        public bvec4 brgg => new bvec4(z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.zxyyx swizzling.
        /// </summary>
        public bvec5 zxyyx => new bvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.brggr swizzling (equivalent to bvec4.zxyyx).
        /// </summary>
        public bvec5 brggr => new bvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.zxyyy swizzling.
        /// </summary>
        public bvec5 zxyyy => new bvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.brggg swizzling (equivalent to bvec4.zxyyy).
        /// </summary>
        public bvec5 brggg => new bvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.zxyyz swizzling.
        /// </summary>
        public bvec5 zxyyz => new bvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.brggb swizzling (equivalent to bvec4.zxyyz).
        /// </summary>
        public bvec5 brggb => new bvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.zxyyw swizzling.
        /// </summary>
        public bvec5 zxyyw => new bvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.brgga swizzling (equivalent to bvec4.zxyyw).
        /// </summary>
        public bvec5 brgga => new bvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.zxyz swizzling.
        /// </summary>
        public bvec4 zxyz => new bvec4(z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.brgb swizzling (equivalent to bvec4.zxyz).
        /// </summary>
        public bvec4 brgb => new bvec4(z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.zxyzx swizzling.
        /// </summary>
        public bvec5 zxyzx => new bvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.brgbr swizzling (equivalent to bvec4.zxyzx).
        /// </summary>
        public bvec5 brgbr => new bvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.zxyzy swizzling.
        /// </summary>
        public bvec5 zxyzy => new bvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.brgbg swizzling (equivalent to bvec4.zxyzy).
        /// </summary>
        public bvec5 brgbg => new bvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.zxyzz swizzling.
        /// </summary>
        public bvec5 zxyzz => new bvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.brgbb swizzling (equivalent to bvec4.zxyzz).
        /// </summary>
        public bvec5 brgbb => new bvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.zxyzw swizzling.
        /// </summary>
        public bvec5 zxyzw => new bvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.brgba swizzling (equivalent to bvec4.zxyzw).
        /// </summary>
        public bvec5 brgba => new bvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.zxyw swizzling.
        /// </summary>
        public bvec4 zxyw => new bvec4(z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.brga swizzling (equivalent to bvec4.zxyw).
        /// </summary>
        public bvec4 brga => new bvec4(z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.zxywx swizzling.
        /// </summary>
        public bvec5 zxywx => new bvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.brgar swizzling (equivalent to bvec4.zxywx).
        /// </summary>
        public bvec5 brgar => new bvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.zxywy swizzling.
        /// </summary>
        public bvec5 zxywy => new bvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.brgag swizzling (equivalent to bvec4.zxywy).
        /// </summary>
        public bvec5 brgag => new bvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.zxywz swizzling.
        /// </summary>
        public bvec5 zxywz => new bvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.brgab swizzling (equivalent to bvec4.zxywz).
        /// </summary>
        public bvec5 brgab => new bvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.zxyww swizzling.
        /// </summary>
        public bvec5 zxyww => new bvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.brgaa swizzling (equivalent to bvec4.zxyww).
        /// </summary>
        public bvec5 brgaa => new bvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.zxz swizzling.
        /// </summary>
        public bvec3 zxz => new bvec3(z, x, z);
        
        /// <summary>
        /// Returns bvec4.brb swizzling (equivalent to bvec4.zxz).
        /// </summary>
        public bvec3 brb => new bvec3(z, x, z);
        
        /// <summary>
        /// Returns bvec4.zxzx swizzling.
        /// </summary>
        public bvec4 zxzx => new bvec4(z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.brbr swizzling (equivalent to bvec4.zxzx).
        /// </summary>
        public bvec4 brbr => new bvec4(z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.zxzxx swizzling.
        /// </summary>
        public bvec5 zxzxx => new bvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.brbrr swizzling (equivalent to bvec4.zxzxx).
        /// </summary>
        public bvec5 brbrr => new bvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.zxzxy swizzling.
        /// </summary>
        public bvec5 zxzxy => new bvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.brbrg swizzling (equivalent to bvec4.zxzxy).
        /// </summary>
        public bvec5 brbrg => new bvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.zxzxz swizzling.
        /// </summary>
        public bvec5 zxzxz => new bvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.brbrb swizzling (equivalent to bvec4.zxzxz).
        /// </summary>
        public bvec5 brbrb => new bvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.zxzxw swizzling.
        /// </summary>
        public bvec5 zxzxw => new bvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.brbra swizzling (equivalent to bvec4.zxzxw).
        /// </summary>
        public bvec5 brbra => new bvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.zxzy swizzling.
        /// </summary>
        public bvec4 zxzy => new bvec4(z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.brbg swizzling (equivalent to bvec4.zxzy).
        /// </summary>
        public bvec4 brbg => new bvec4(z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.zxzyx swizzling.
        /// </summary>
        public bvec5 zxzyx => new bvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.brbgr swizzling (equivalent to bvec4.zxzyx).
        /// </summary>
        public bvec5 brbgr => new bvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.zxzyy swizzling.
        /// </summary>
        public bvec5 zxzyy => new bvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.brbgg swizzling (equivalent to bvec4.zxzyy).
        /// </summary>
        public bvec5 brbgg => new bvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.zxzyz swizzling.
        /// </summary>
        public bvec5 zxzyz => new bvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.brbgb swizzling (equivalent to bvec4.zxzyz).
        /// </summary>
        public bvec5 brbgb => new bvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.zxzyw swizzling.
        /// </summary>
        public bvec5 zxzyw => new bvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.brbga swizzling (equivalent to bvec4.zxzyw).
        /// </summary>
        public bvec5 brbga => new bvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.zxzz swizzling.
        /// </summary>
        public bvec4 zxzz => new bvec4(z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.brbb swizzling (equivalent to bvec4.zxzz).
        /// </summary>
        public bvec4 brbb => new bvec4(z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.zxzzx swizzling.
        /// </summary>
        public bvec5 zxzzx => new bvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.brbbr swizzling (equivalent to bvec4.zxzzx).
        /// </summary>
        public bvec5 brbbr => new bvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.zxzzy swizzling.
        /// </summary>
        public bvec5 zxzzy => new bvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.brbbg swizzling (equivalent to bvec4.zxzzy).
        /// </summary>
        public bvec5 brbbg => new bvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.zxzzz swizzling.
        /// </summary>
        public bvec5 zxzzz => new bvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.brbbb swizzling (equivalent to bvec4.zxzzz).
        /// </summary>
        public bvec5 brbbb => new bvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.zxzzw swizzling.
        /// </summary>
        public bvec5 zxzzw => new bvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.brbba swizzling (equivalent to bvec4.zxzzw).
        /// </summary>
        public bvec5 brbba => new bvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.zxzw swizzling.
        /// </summary>
        public bvec4 zxzw => new bvec4(z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.brba swizzling (equivalent to bvec4.zxzw).
        /// </summary>
        public bvec4 brba => new bvec4(z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.zxzwx swizzling.
        /// </summary>
        public bvec5 zxzwx => new bvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.brbar swizzling (equivalent to bvec4.zxzwx).
        /// </summary>
        public bvec5 brbar => new bvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.zxzwy swizzling.
        /// </summary>
        public bvec5 zxzwy => new bvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.brbag swizzling (equivalent to bvec4.zxzwy).
        /// </summary>
        public bvec5 brbag => new bvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.zxzwz swizzling.
        /// </summary>
        public bvec5 zxzwz => new bvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.brbab swizzling (equivalent to bvec4.zxzwz).
        /// </summary>
        public bvec5 brbab => new bvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.zxzww swizzling.
        /// </summary>
        public bvec5 zxzww => new bvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.brbaa swizzling (equivalent to bvec4.zxzww).
        /// </summary>
        public bvec5 brbaa => new bvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.zxw swizzling.
        /// </summary>
        public bvec3 zxw => new bvec3(z, x, w);
        
        /// <summary>
        /// Returns bvec4.bra swizzling (equivalent to bvec4.zxw).
        /// </summary>
        public bvec3 bra => new bvec3(z, x, w);
        
        /// <summary>
        /// Returns bvec4.zxwx swizzling.
        /// </summary>
        public bvec4 zxwx => new bvec4(z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.brar swizzling (equivalent to bvec4.zxwx).
        /// </summary>
        public bvec4 brar => new bvec4(z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.zxwxx swizzling.
        /// </summary>
        public bvec5 zxwxx => new bvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.brarr swizzling (equivalent to bvec4.zxwxx).
        /// </summary>
        public bvec5 brarr => new bvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.zxwxy swizzling.
        /// </summary>
        public bvec5 zxwxy => new bvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.brarg swizzling (equivalent to bvec4.zxwxy).
        /// </summary>
        public bvec5 brarg => new bvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.zxwxz swizzling.
        /// </summary>
        public bvec5 zxwxz => new bvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.brarb swizzling (equivalent to bvec4.zxwxz).
        /// </summary>
        public bvec5 brarb => new bvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.zxwxw swizzling.
        /// </summary>
        public bvec5 zxwxw => new bvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.brara swizzling (equivalent to bvec4.zxwxw).
        /// </summary>
        public bvec5 brara => new bvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.zxwy swizzling.
        /// </summary>
        public bvec4 zxwy => new bvec4(z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.brag swizzling (equivalent to bvec4.zxwy).
        /// </summary>
        public bvec4 brag => new bvec4(z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.zxwyx swizzling.
        /// </summary>
        public bvec5 zxwyx => new bvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.bragr swizzling (equivalent to bvec4.zxwyx).
        /// </summary>
        public bvec5 bragr => new bvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.zxwyy swizzling.
        /// </summary>
        public bvec5 zxwyy => new bvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.bragg swizzling (equivalent to bvec4.zxwyy).
        /// </summary>
        public bvec5 bragg => new bvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.zxwyz swizzling.
        /// </summary>
        public bvec5 zxwyz => new bvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.bragb swizzling (equivalent to bvec4.zxwyz).
        /// </summary>
        public bvec5 bragb => new bvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.zxwyw swizzling.
        /// </summary>
        public bvec5 zxwyw => new bvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.braga swizzling (equivalent to bvec4.zxwyw).
        /// </summary>
        public bvec5 braga => new bvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.zxwz swizzling.
        /// </summary>
        public bvec4 zxwz => new bvec4(z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.brab swizzling (equivalent to bvec4.zxwz).
        /// </summary>
        public bvec4 brab => new bvec4(z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.zxwzx swizzling.
        /// </summary>
        public bvec5 zxwzx => new bvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.brabr swizzling (equivalent to bvec4.zxwzx).
        /// </summary>
        public bvec5 brabr => new bvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.zxwzy swizzling.
        /// </summary>
        public bvec5 zxwzy => new bvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.brabg swizzling (equivalent to bvec4.zxwzy).
        /// </summary>
        public bvec5 brabg => new bvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.zxwzz swizzling.
        /// </summary>
        public bvec5 zxwzz => new bvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.brabb swizzling (equivalent to bvec4.zxwzz).
        /// </summary>
        public bvec5 brabb => new bvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.zxwzw swizzling.
        /// </summary>
        public bvec5 zxwzw => new bvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.braba swizzling (equivalent to bvec4.zxwzw).
        /// </summary>
        public bvec5 braba => new bvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.zxww swizzling.
        /// </summary>
        public bvec4 zxww => new bvec4(z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.braa swizzling (equivalent to bvec4.zxww).
        /// </summary>
        public bvec4 braa => new bvec4(z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.zxwwx swizzling.
        /// </summary>
        public bvec5 zxwwx => new bvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.braar swizzling (equivalent to bvec4.zxwwx).
        /// </summary>
        public bvec5 braar => new bvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.zxwwy swizzling.
        /// </summary>
        public bvec5 zxwwy => new bvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.braag swizzling (equivalent to bvec4.zxwwy).
        /// </summary>
        public bvec5 braag => new bvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.zxwwz swizzling.
        /// </summary>
        public bvec5 zxwwz => new bvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.braab swizzling (equivalent to bvec4.zxwwz).
        /// </summary>
        public bvec5 braab => new bvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.zxwww swizzling.
        /// </summary>
        public bvec5 zxwww => new bvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.braaa swizzling (equivalent to bvec4.zxwww).
        /// </summary>
        public bvec5 braaa => new bvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.zy swizzling.
        /// </summary>
        public bvec2 zy => new bvec2(z, y);
        
        /// <summary>
        /// Returns bvec4.bg swizzling (equivalent to bvec4.zy).
        /// </summary>
        public bvec2 bg => new bvec2(z, y);
        
        /// <summary>
        /// Returns bvec4.zyx swizzling.
        /// </summary>
        public bvec3 zyx => new bvec3(z, y, x);
        
        /// <summary>
        /// Returns bvec4.bgr swizzling (equivalent to bvec4.zyx).
        /// </summary>
        public bvec3 bgr => new bvec3(z, y, x);
        
        /// <summary>
        /// Returns bvec4.zyxx swizzling.
        /// </summary>
        public bvec4 zyxx => new bvec4(z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.bgrr swizzling (equivalent to bvec4.zyxx).
        /// </summary>
        public bvec4 bgrr => new bvec4(z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.zyxxx swizzling.
        /// </summary>
        public bvec5 zyxxx => new bvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.bgrrr swizzling (equivalent to bvec4.zyxxx).
        /// </summary>
        public bvec5 bgrrr => new bvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.zyxxy swizzling.
        /// </summary>
        public bvec5 zyxxy => new bvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.bgrrg swizzling (equivalent to bvec4.zyxxy).
        /// </summary>
        public bvec5 bgrrg => new bvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.zyxxz swizzling.
        /// </summary>
        public bvec5 zyxxz => new bvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.bgrrb swizzling (equivalent to bvec4.zyxxz).
        /// </summary>
        public bvec5 bgrrb => new bvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.zyxxw swizzling.
        /// </summary>
        public bvec5 zyxxw => new bvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.bgrra swizzling (equivalent to bvec4.zyxxw).
        /// </summary>
        public bvec5 bgrra => new bvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.zyxy swizzling.
        /// </summary>
        public bvec4 zyxy => new bvec4(z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.bgrg swizzling (equivalent to bvec4.zyxy).
        /// </summary>
        public bvec4 bgrg => new bvec4(z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.zyxyx swizzling.
        /// </summary>
        public bvec5 zyxyx => new bvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.bgrgr swizzling (equivalent to bvec4.zyxyx).
        /// </summary>
        public bvec5 bgrgr => new bvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.zyxyy swizzling.
        /// </summary>
        public bvec5 zyxyy => new bvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.bgrgg swizzling (equivalent to bvec4.zyxyy).
        /// </summary>
        public bvec5 bgrgg => new bvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.zyxyz swizzling.
        /// </summary>
        public bvec5 zyxyz => new bvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.bgrgb swizzling (equivalent to bvec4.zyxyz).
        /// </summary>
        public bvec5 bgrgb => new bvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.zyxyw swizzling.
        /// </summary>
        public bvec5 zyxyw => new bvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.bgrga swizzling (equivalent to bvec4.zyxyw).
        /// </summary>
        public bvec5 bgrga => new bvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.zyxz swizzling.
        /// </summary>
        public bvec4 zyxz => new bvec4(z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.bgrb swizzling (equivalent to bvec4.zyxz).
        /// </summary>
        public bvec4 bgrb => new bvec4(z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.zyxzx swizzling.
        /// </summary>
        public bvec5 zyxzx => new bvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.bgrbr swizzling (equivalent to bvec4.zyxzx).
        /// </summary>
        public bvec5 bgrbr => new bvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.zyxzy swizzling.
        /// </summary>
        public bvec5 zyxzy => new bvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.bgrbg swizzling (equivalent to bvec4.zyxzy).
        /// </summary>
        public bvec5 bgrbg => new bvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.zyxzz swizzling.
        /// </summary>
        public bvec5 zyxzz => new bvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.bgrbb swizzling (equivalent to bvec4.zyxzz).
        /// </summary>
        public bvec5 bgrbb => new bvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.zyxzw swizzling.
        /// </summary>
        public bvec5 zyxzw => new bvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.bgrba swizzling (equivalent to bvec4.zyxzw).
        /// </summary>
        public bvec5 bgrba => new bvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.zyxw swizzling.
        /// </summary>
        public bvec4 zyxw => new bvec4(z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.bgra swizzling (equivalent to bvec4.zyxw).
        /// </summary>
        public bvec4 bgra => new bvec4(z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.zyxwx swizzling.
        /// </summary>
        public bvec5 zyxwx => new bvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.bgrar swizzling (equivalent to bvec4.zyxwx).
        /// </summary>
        public bvec5 bgrar => new bvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.zyxwy swizzling.
        /// </summary>
        public bvec5 zyxwy => new bvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.bgrag swizzling (equivalent to bvec4.zyxwy).
        /// </summary>
        public bvec5 bgrag => new bvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.zyxwz swizzling.
        /// </summary>
        public bvec5 zyxwz => new bvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.bgrab swizzling (equivalent to bvec4.zyxwz).
        /// </summary>
        public bvec5 bgrab => new bvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.zyxww swizzling.
        /// </summary>
        public bvec5 zyxww => new bvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.bgraa swizzling (equivalent to bvec4.zyxww).
        /// </summary>
        public bvec5 bgraa => new bvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.zyy swizzling.
        /// </summary>
        public bvec3 zyy => new bvec3(z, y, y);
        
        /// <summary>
        /// Returns bvec4.bgg swizzling (equivalent to bvec4.zyy).
        /// </summary>
        public bvec3 bgg => new bvec3(z, y, y);
        
        /// <summary>
        /// Returns bvec4.zyyx swizzling.
        /// </summary>
        public bvec4 zyyx => new bvec4(z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.bggr swizzling (equivalent to bvec4.zyyx).
        /// </summary>
        public bvec4 bggr => new bvec4(z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.zyyxx swizzling.
        /// </summary>
        public bvec5 zyyxx => new bvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.bggrr swizzling (equivalent to bvec4.zyyxx).
        /// </summary>
        public bvec5 bggrr => new bvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.zyyxy swizzling.
        /// </summary>
        public bvec5 zyyxy => new bvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.bggrg swizzling (equivalent to bvec4.zyyxy).
        /// </summary>
        public bvec5 bggrg => new bvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.zyyxz swizzling.
        /// </summary>
        public bvec5 zyyxz => new bvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.bggrb swizzling (equivalent to bvec4.zyyxz).
        /// </summary>
        public bvec5 bggrb => new bvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.zyyxw swizzling.
        /// </summary>
        public bvec5 zyyxw => new bvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.bggra swizzling (equivalent to bvec4.zyyxw).
        /// </summary>
        public bvec5 bggra => new bvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.zyyy swizzling.
        /// </summary>
        public bvec4 zyyy => new bvec4(z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.bggg swizzling (equivalent to bvec4.zyyy).
        /// </summary>
        public bvec4 bggg => new bvec4(z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.zyyyx swizzling.
        /// </summary>
        public bvec5 zyyyx => new bvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.bgggr swizzling (equivalent to bvec4.zyyyx).
        /// </summary>
        public bvec5 bgggr => new bvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.zyyyy swizzling.
        /// </summary>
        public bvec5 zyyyy => new bvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.bgggg swizzling (equivalent to bvec4.zyyyy).
        /// </summary>
        public bvec5 bgggg => new bvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.zyyyz swizzling.
        /// </summary>
        public bvec5 zyyyz => new bvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.bgggb swizzling (equivalent to bvec4.zyyyz).
        /// </summary>
        public bvec5 bgggb => new bvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.zyyyw swizzling.
        /// </summary>
        public bvec5 zyyyw => new bvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.bggga swizzling (equivalent to bvec4.zyyyw).
        /// </summary>
        public bvec5 bggga => new bvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.zyyz swizzling.
        /// </summary>
        public bvec4 zyyz => new bvec4(z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.bggb swizzling (equivalent to bvec4.zyyz).
        /// </summary>
        public bvec4 bggb => new bvec4(z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.zyyzx swizzling.
        /// </summary>
        public bvec5 zyyzx => new bvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.bggbr swizzling (equivalent to bvec4.zyyzx).
        /// </summary>
        public bvec5 bggbr => new bvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.zyyzy swizzling.
        /// </summary>
        public bvec5 zyyzy => new bvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.bggbg swizzling (equivalent to bvec4.zyyzy).
        /// </summary>
        public bvec5 bggbg => new bvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.zyyzz swizzling.
        /// </summary>
        public bvec5 zyyzz => new bvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.bggbb swizzling (equivalent to bvec4.zyyzz).
        /// </summary>
        public bvec5 bggbb => new bvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.zyyzw swizzling.
        /// </summary>
        public bvec5 zyyzw => new bvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.bggba swizzling (equivalent to bvec4.zyyzw).
        /// </summary>
        public bvec5 bggba => new bvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.zyyw swizzling.
        /// </summary>
        public bvec4 zyyw => new bvec4(z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.bgga swizzling (equivalent to bvec4.zyyw).
        /// </summary>
        public bvec4 bgga => new bvec4(z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.zyywx swizzling.
        /// </summary>
        public bvec5 zyywx => new bvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.bggar swizzling (equivalent to bvec4.zyywx).
        /// </summary>
        public bvec5 bggar => new bvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.zyywy swizzling.
        /// </summary>
        public bvec5 zyywy => new bvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.bggag swizzling (equivalent to bvec4.zyywy).
        /// </summary>
        public bvec5 bggag => new bvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.zyywz swizzling.
        /// </summary>
        public bvec5 zyywz => new bvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.bggab swizzling (equivalent to bvec4.zyywz).
        /// </summary>
        public bvec5 bggab => new bvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.zyyww swizzling.
        /// </summary>
        public bvec5 zyyww => new bvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.bggaa swizzling (equivalent to bvec4.zyyww).
        /// </summary>
        public bvec5 bggaa => new bvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.zyz swizzling.
        /// </summary>
        public bvec3 zyz => new bvec3(z, y, z);
        
        /// <summary>
        /// Returns bvec4.bgb swizzling (equivalent to bvec4.zyz).
        /// </summary>
        public bvec3 bgb => new bvec3(z, y, z);
        
        /// <summary>
        /// Returns bvec4.zyzx swizzling.
        /// </summary>
        public bvec4 zyzx => new bvec4(z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.bgbr swizzling (equivalent to bvec4.zyzx).
        /// </summary>
        public bvec4 bgbr => new bvec4(z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.zyzxx swizzling.
        /// </summary>
        public bvec5 zyzxx => new bvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.bgbrr swizzling (equivalent to bvec4.zyzxx).
        /// </summary>
        public bvec5 bgbrr => new bvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.zyzxy swizzling.
        /// </summary>
        public bvec5 zyzxy => new bvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.bgbrg swizzling (equivalent to bvec4.zyzxy).
        /// </summary>
        public bvec5 bgbrg => new bvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.zyzxz swizzling.
        /// </summary>
        public bvec5 zyzxz => new bvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.bgbrb swizzling (equivalent to bvec4.zyzxz).
        /// </summary>
        public bvec5 bgbrb => new bvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.zyzxw swizzling.
        /// </summary>
        public bvec5 zyzxw => new bvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.bgbra swizzling (equivalent to bvec4.zyzxw).
        /// </summary>
        public bvec5 bgbra => new bvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.zyzy swizzling.
        /// </summary>
        public bvec4 zyzy => new bvec4(z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.bgbg swizzling (equivalent to bvec4.zyzy).
        /// </summary>
        public bvec4 bgbg => new bvec4(z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.zyzyx swizzling.
        /// </summary>
        public bvec5 zyzyx => new bvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.bgbgr swizzling (equivalent to bvec4.zyzyx).
        /// </summary>
        public bvec5 bgbgr => new bvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.zyzyy swizzling.
        /// </summary>
        public bvec5 zyzyy => new bvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.bgbgg swizzling (equivalent to bvec4.zyzyy).
        /// </summary>
        public bvec5 bgbgg => new bvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.zyzyz swizzling.
        /// </summary>
        public bvec5 zyzyz => new bvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.bgbgb swizzling (equivalent to bvec4.zyzyz).
        /// </summary>
        public bvec5 bgbgb => new bvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.zyzyw swizzling.
        /// </summary>
        public bvec5 zyzyw => new bvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.bgbga swizzling (equivalent to bvec4.zyzyw).
        /// </summary>
        public bvec5 bgbga => new bvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.zyzz swizzling.
        /// </summary>
        public bvec4 zyzz => new bvec4(z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.bgbb swizzling (equivalent to bvec4.zyzz).
        /// </summary>
        public bvec4 bgbb => new bvec4(z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.zyzzx swizzling.
        /// </summary>
        public bvec5 zyzzx => new bvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.bgbbr swizzling (equivalent to bvec4.zyzzx).
        /// </summary>
        public bvec5 bgbbr => new bvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.zyzzy swizzling.
        /// </summary>
        public bvec5 zyzzy => new bvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.bgbbg swizzling (equivalent to bvec4.zyzzy).
        /// </summary>
        public bvec5 bgbbg => new bvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.zyzzz swizzling.
        /// </summary>
        public bvec5 zyzzz => new bvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.bgbbb swizzling (equivalent to bvec4.zyzzz).
        /// </summary>
        public bvec5 bgbbb => new bvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.zyzzw swizzling.
        /// </summary>
        public bvec5 zyzzw => new bvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.bgbba swizzling (equivalent to bvec4.zyzzw).
        /// </summary>
        public bvec5 bgbba => new bvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.zyzw swizzling.
        /// </summary>
        public bvec4 zyzw => new bvec4(z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.bgba swizzling (equivalent to bvec4.zyzw).
        /// </summary>
        public bvec4 bgba => new bvec4(z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.zyzwx swizzling.
        /// </summary>
        public bvec5 zyzwx => new bvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.bgbar swizzling (equivalent to bvec4.zyzwx).
        /// </summary>
        public bvec5 bgbar => new bvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.zyzwy swizzling.
        /// </summary>
        public bvec5 zyzwy => new bvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.bgbag swizzling (equivalent to bvec4.zyzwy).
        /// </summary>
        public bvec5 bgbag => new bvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.zyzwz swizzling.
        /// </summary>
        public bvec5 zyzwz => new bvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.bgbab swizzling (equivalent to bvec4.zyzwz).
        /// </summary>
        public bvec5 bgbab => new bvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.zyzww swizzling.
        /// </summary>
        public bvec5 zyzww => new bvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.bgbaa swizzling (equivalent to bvec4.zyzww).
        /// </summary>
        public bvec5 bgbaa => new bvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.zyw swizzling.
        /// </summary>
        public bvec3 zyw => new bvec3(z, y, w);
        
        /// <summary>
        /// Returns bvec4.bga swizzling (equivalent to bvec4.zyw).
        /// </summary>
        public bvec3 bga => new bvec3(z, y, w);
        
        /// <summary>
        /// Returns bvec4.zywx swizzling.
        /// </summary>
        public bvec4 zywx => new bvec4(z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.bgar swizzling (equivalent to bvec4.zywx).
        /// </summary>
        public bvec4 bgar => new bvec4(z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.zywxx swizzling.
        /// </summary>
        public bvec5 zywxx => new bvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.bgarr swizzling (equivalent to bvec4.zywxx).
        /// </summary>
        public bvec5 bgarr => new bvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.zywxy swizzling.
        /// </summary>
        public bvec5 zywxy => new bvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.bgarg swizzling (equivalent to bvec4.zywxy).
        /// </summary>
        public bvec5 bgarg => new bvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.zywxz swizzling.
        /// </summary>
        public bvec5 zywxz => new bvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.bgarb swizzling (equivalent to bvec4.zywxz).
        /// </summary>
        public bvec5 bgarb => new bvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.zywxw swizzling.
        /// </summary>
        public bvec5 zywxw => new bvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.bgara swizzling (equivalent to bvec4.zywxw).
        /// </summary>
        public bvec5 bgara => new bvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.zywy swizzling.
        /// </summary>
        public bvec4 zywy => new bvec4(z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.bgag swizzling (equivalent to bvec4.zywy).
        /// </summary>
        public bvec4 bgag => new bvec4(z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.zywyx swizzling.
        /// </summary>
        public bvec5 zywyx => new bvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.bgagr swizzling (equivalent to bvec4.zywyx).
        /// </summary>
        public bvec5 bgagr => new bvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.zywyy swizzling.
        /// </summary>
        public bvec5 zywyy => new bvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.bgagg swizzling (equivalent to bvec4.zywyy).
        /// </summary>
        public bvec5 bgagg => new bvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.zywyz swizzling.
        /// </summary>
        public bvec5 zywyz => new bvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.bgagb swizzling (equivalent to bvec4.zywyz).
        /// </summary>
        public bvec5 bgagb => new bvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.zywyw swizzling.
        /// </summary>
        public bvec5 zywyw => new bvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.bgaga swizzling (equivalent to bvec4.zywyw).
        /// </summary>
        public bvec5 bgaga => new bvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.zywz swizzling.
        /// </summary>
        public bvec4 zywz => new bvec4(z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.bgab swizzling (equivalent to bvec4.zywz).
        /// </summary>
        public bvec4 bgab => new bvec4(z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.zywzx swizzling.
        /// </summary>
        public bvec5 zywzx => new bvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.bgabr swizzling (equivalent to bvec4.zywzx).
        /// </summary>
        public bvec5 bgabr => new bvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.zywzy swizzling.
        /// </summary>
        public bvec5 zywzy => new bvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.bgabg swizzling (equivalent to bvec4.zywzy).
        /// </summary>
        public bvec5 bgabg => new bvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.zywzz swizzling.
        /// </summary>
        public bvec5 zywzz => new bvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.bgabb swizzling (equivalent to bvec4.zywzz).
        /// </summary>
        public bvec5 bgabb => new bvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.zywzw swizzling.
        /// </summary>
        public bvec5 zywzw => new bvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.bgaba swizzling (equivalent to bvec4.zywzw).
        /// </summary>
        public bvec5 bgaba => new bvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.zyww swizzling.
        /// </summary>
        public bvec4 zyww => new bvec4(z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.bgaa swizzling (equivalent to bvec4.zyww).
        /// </summary>
        public bvec4 bgaa => new bvec4(z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.zywwx swizzling.
        /// </summary>
        public bvec5 zywwx => new bvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.bgaar swizzling (equivalent to bvec4.zywwx).
        /// </summary>
        public bvec5 bgaar => new bvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.zywwy swizzling.
        /// </summary>
        public bvec5 zywwy => new bvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.bgaag swizzling (equivalent to bvec4.zywwy).
        /// </summary>
        public bvec5 bgaag => new bvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.zywwz swizzling.
        /// </summary>
        public bvec5 zywwz => new bvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.bgaab swizzling (equivalent to bvec4.zywwz).
        /// </summary>
        public bvec5 bgaab => new bvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.zywww swizzling.
        /// </summary>
        public bvec5 zywww => new bvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.bgaaa swizzling (equivalent to bvec4.zywww).
        /// </summary>
        public bvec5 bgaaa => new bvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.zz swizzling.
        /// </summary>
        public bvec2 zz => new bvec2(z, z);
        
        /// <summary>
        /// Returns bvec4.bb swizzling (equivalent to bvec4.zz).
        /// </summary>
        public bvec2 bb => new bvec2(z, z);
        
        /// <summary>
        /// Returns bvec4.zzx swizzling.
        /// </summary>
        public bvec3 zzx => new bvec3(z, z, x);
        
        /// <summary>
        /// Returns bvec4.bbr swizzling (equivalent to bvec4.zzx).
        /// </summary>
        public bvec3 bbr => new bvec3(z, z, x);
        
        /// <summary>
        /// Returns bvec4.zzxx swizzling.
        /// </summary>
        public bvec4 zzxx => new bvec4(z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.bbrr swizzling (equivalent to bvec4.zzxx).
        /// </summary>
        public bvec4 bbrr => new bvec4(z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.zzxxx swizzling.
        /// </summary>
        public bvec5 zzxxx => new bvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.bbrrr swizzling (equivalent to bvec4.zzxxx).
        /// </summary>
        public bvec5 bbrrr => new bvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.zzxxy swizzling.
        /// </summary>
        public bvec5 zzxxy => new bvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.bbrrg swizzling (equivalent to bvec4.zzxxy).
        /// </summary>
        public bvec5 bbrrg => new bvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.zzxxz swizzling.
        /// </summary>
        public bvec5 zzxxz => new bvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.bbrrb swizzling (equivalent to bvec4.zzxxz).
        /// </summary>
        public bvec5 bbrrb => new bvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.zzxxw swizzling.
        /// </summary>
        public bvec5 zzxxw => new bvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.bbrra swizzling (equivalent to bvec4.zzxxw).
        /// </summary>
        public bvec5 bbrra => new bvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.zzxy swizzling.
        /// </summary>
        public bvec4 zzxy => new bvec4(z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.bbrg swizzling (equivalent to bvec4.zzxy).
        /// </summary>
        public bvec4 bbrg => new bvec4(z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.zzxyx swizzling.
        /// </summary>
        public bvec5 zzxyx => new bvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.bbrgr swizzling (equivalent to bvec4.zzxyx).
        /// </summary>
        public bvec5 bbrgr => new bvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.zzxyy swizzling.
        /// </summary>
        public bvec5 zzxyy => new bvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.bbrgg swizzling (equivalent to bvec4.zzxyy).
        /// </summary>
        public bvec5 bbrgg => new bvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.zzxyz swizzling.
        /// </summary>
        public bvec5 zzxyz => new bvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.bbrgb swizzling (equivalent to bvec4.zzxyz).
        /// </summary>
        public bvec5 bbrgb => new bvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.zzxyw swizzling.
        /// </summary>
        public bvec5 zzxyw => new bvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.bbrga swizzling (equivalent to bvec4.zzxyw).
        /// </summary>
        public bvec5 bbrga => new bvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.zzxz swizzling.
        /// </summary>
        public bvec4 zzxz => new bvec4(z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.bbrb swizzling (equivalent to bvec4.zzxz).
        /// </summary>
        public bvec4 bbrb => new bvec4(z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.zzxzx swizzling.
        /// </summary>
        public bvec5 zzxzx => new bvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.bbrbr swizzling (equivalent to bvec4.zzxzx).
        /// </summary>
        public bvec5 bbrbr => new bvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.zzxzy swizzling.
        /// </summary>
        public bvec5 zzxzy => new bvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.bbrbg swizzling (equivalent to bvec4.zzxzy).
        /// </summary>
        public bvec5 bbrbg => new bvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.zzxzz swizzling.
        /// </summary>
        public bvec5 zzxzz => new bvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.bbrbb swizzling (equivalent to bvec4.zzxzz).
        /// </summary>
        public bvec5 bbrbb => new bvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.zzxzw swizzling.
        /// </summary>
        public bvec5 zzxzw => new bvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.bbrba swizzling (equivalent to bvec4.zzxzw).
        /// </summary>
        public bvec5 bbrba => new bvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.zzxw swizzling.
        /// </summary>
        public bvec4 zzxw => new bvec4(z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.bbra swizzling (equivalent to bvec4.zzxw).
        /// </summary>
        public bvec4 bbra => new bvec4(z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.zzxwx swizzling.
        /// </summary>
        public bvec5 zzxwx => new bvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.bbrar swizzling (equivalent to bvec4.zzxwx).
        /// </summary>
        public bvec5 bbrar => new bvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.zzxwy swizzling.
        /// </summary>
        public bvec5 zzxwy => new bvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.bbrag swizzling (equivalent to bvec4.zzxwy).
        /// </summary>
        public bvec5 bbrag => new bvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.zzxwz swizzling.
        /// </summary>
        public bvec5 zzxwz => new bvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.bbrab swizzling (equivalent to bvec4.zzxwz).
        /// </summary>
        public bvec5 bbrab => new bvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.zzxww swizzling.
        /// </summary>
        public bvec5 zzxww => new bvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.bbraa swizzling (equivalent to bvec4.zzxww).
        /// </summary>
        public bvec5 bbraa => new bvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.zzy swizzling.
        /// </summary>
        public bvec3 zzy => new bvec3(z, z, y);
        
        /// <summary>
        /// Returns bvec4.bbg swizzling (equivalent to bvec4.zzy).
        /// </summary>
        public bvec3 bbg => new bvec3(z, z, y);
        
        /// <summary>
        /// Returns bvec4.zzyx swizzling.
        /// </summary>
        public bvec4 zzyx => new bvec4(z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.bbgr swizzling (equivalent to bvec4.zzyx).
        /// </summary>
        public bvec4 bbgr => new bvec4(z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.zzyxx swizzling.
        /// </summary>
        public bvec5 zzyxx => new bvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.bbgrr swizzling (equivalent to bvec4.zzyxx).
        /// </summary>
        public bvec5 bbgrr => new bvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.zzyxy swizzling.
        /// </summary>
        public bvec5 zzyxy => new bvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.bbgrg swizzling (equivalent to bvec4.zzyxy).
        /// </summary>
        public bvec5 bbgrg => new bvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.zzyxz swizzling.
        /// </summary>
        public bvec5 zzyxz => new bvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.bbgrb swizzling (equivalent to bvec4.zzyxz).
        /// </summary>
        public bvec5 bbgrb => new bvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.zzyxw swizzling.
        /// </summary>
        public bvec5 zzyxw => new bvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.bbgra swizzling (equivalent to bvec4.zzyxw).
        /// </summary>
        public bvec5 bbgra => new bvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.zzyy swizzling.
        /// </summary>
        public bvec4 zzyy => new bvec4(z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.bbgg swizzling (equivalent to bvec4.zzyy).
        /// </summary>
        public bvec4 bbgg => new bvec4(z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.zzyyx swizzling.
        /// </summary>
        public bvec5 zzyyx => new bvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.bbggr swizzling (equivalent to bvec4.zzyyx).
        /// </summary>
        public bvec5 bbggr => new bvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.zzyyy swizzling.
        /// </summary>
        public bvec5 zzyyy => new bvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.bbggg swizzling (equivalent to bvec4.zzyyy).
        /// </summary>
        public bvec5 bbggg => new bvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.zzyyz swizzling.
        /// </summary>
        public bvec5 zzyyz => new bvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.bbggb swizzling (equivalent to bvec4.zzyyz).
        /// </summary>
        public bvec5 bbggb => new bvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.zzyyw swizzling.
        /// </summary>
        public bvec5 zzyyw => new bvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.bbgga swizzling (equivalent to bvec4.zzyyw).
        /// </summary>
        public bvec5 bbgga => new bvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.zzyz swizzling.
        /// </summary>
        public bvec4 zzyz => new bvec4(z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.bbgb swizzling (equivalent to bvec4.zzyz).
        /// </summary>
        public bvec4 bbgb => new bvec4(z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.zzyzx swizzling.
        /// </summary>
        public bvec5 zzyzx => new bvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.bbgbr swizzling (equivalent to bvec4.zzyzx).
        /// </summary>
        public bvec5 bbgbr => new bvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.zzyzy swizzling.
        /// </summary>
        public bvec5 zzyzy => new bvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.bbgbg swizzling (equivalent to bvec4.zzyzy).
        /// </summary>
        public bvec5 bbgbg => new bvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.zzyzz swizzling.
        /// </summary>
        public bvec5 zzyzz => new bvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.bbgbb swizzling (equivalent to bvec4.zzyzz).
        /// </summary>
        public bvec5 bbgbb => new bvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.zzyzw swizzling.
        /// </summary>
        public bvec5 zzyzw => new bvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.bbgba swizzling (equivalent to bvec4.zzyzw).
        /// </summary>
        public bvec5 bbgba => new bvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.zzyw swizzling.
        /// </summary>
        public bvec4 zzyw => new bvec4(z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.bbga swizzling (equivalent to bvec4.zzyw).
        /// </summary>
        public bvec4 bbga => new bvec4(z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.zzywx swizzling.
        /// </summary>
        public bvec5 zzywx => new bvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.bbgar swizzling (equivalent to bvec4.zzywx).
        /// </summary>
        public bvec5 bbgar => new bvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.zzywy swizzling.
        /// </summary>
        public bvec5 zzywy => new bvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.bbgag swizzling (equivalent to bvec4.zzywy).
        /// </summary>
        public bvec5 bbgag => new bvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.zzywz swizzling.
        /// </summary>
        public bvec5 zzywz => new bvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.bbgab swizzling (equivalent to bvec4.zzywz).
        /// </summary>
        public bvec5 bbgab => new bvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.zzyww swizzling.
        /// </summary>
        public bvec5 zzyww => new bvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.bbgaa swizzling (equivalent to bvec4.zzyww).
        /// </summary>
        public bvec5 bbgaa => new bvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.zzz swizzling.
        /// </summary>
        public bvec3 zzz => new bvec3(z, z, z);
        
        /// <summary>
        /// Returns bvec4.bbb swizzling (equivalent to bvec4.zzz).
        /// </summary>
        public bvec3 bbb => new bvec3(z, z, z);
        
        /// <summary>
        /// Returns bvec4.zzzx swizzling.
        /// </summary>
        public bvec4 zzzx => new bvec4(z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.bbbr swizzling (equivalent to bvec4.zzzx).
        /// </summary>
        public bvec4 bbbr => new bvec4(z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.zzzxx swizzling.
        /// </summary>
        public bvec5 zzzxx => new bvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.bbbrr swizzling (equivalent to bvec4.zzzxx).
        /// </summary>
        public bvec5 bbbrr => new bvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.zzzxy swizzling.
        /// </summary>
        public bvec5 zzzxy => new bvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.bbbrg swizzling (equivalent to bvec4.zzzxy).
        /// </summary>
        public bvec5 bbbrg => new bvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.zzzxz swizzling.
        /// </summary>
        public bvec5 zzzxz => new bvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.bbbrb swizzling (equivalent to bvec4.zzzxz).
        /// </summary>
        public bvec5 bbbrb => new bvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.zzzxw swizzling.
        /// </summary>
        public bvec5 zzzxw => new bvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.bbbra swizzling (equivalent to bvec4.zzzxw).
        /// </summary>
        public bvec5 bbbra => new bvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.zzzy swizzling.
        /// </summary>
        public bvec4 zzzy => new bvec4(z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.bbbg swizzling (equivalent to bvec4.zzzy).
        /// </summary>
        public bvec4 bbbg => new bvec4(z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.zzzyx swizzling.
        /// </summary>
        public bvec5 zzzyx => new bvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.bbbgr swizzling (equivalent to bvec4.zzzyx).
        /// </summary>
        public bvec5 bbbgr => new bvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.zzzyy swizzling.
        /// </summary>
        public bvec5 zzzyy => new bvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.bbbgg swizzling (equivalent to bvec4.zzzyy).
        /// </summary>
        public bvec5 bbbgg => new bvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.zzzyz swizzling.
        /// </summary>
        public bvec5 zzzyz => new bvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.bbbgb swizzling (equivalent to bvec4.zzzyz).
        /// </summary>
        public bvec5 bbbgb => new bvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.zzzyw swizzling.
        /// </summary>
        public bvec5 zzzyw => new bvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.bbbga swizzling (equivalent to bvec4.zzzyw).
        /// </summary>
        public bvec5 bbbga => new bvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.zzzz swizzling.
        /// </summary>
        public bvec4 zzzz => new bvec4(z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.bbbb swizzling (equivalent to bvec4.zzzz).
        /// </summary>
        public bvec4 bbbb => new bvec4(z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.zzzzx swizzling.
        /// </summary>
        public bvec5 zzzzx => new bvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.bbbbr swizzling (equivalent to bvec4.zzzzx).
        /// </summary>
        public bvec5 bbbbr => new bvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.zzzzy swizzling.
        /// </summary>
        public bvec5 zzzzy => new bvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.bbbbg swizzling (equivalent to bvec4.zzzzy).
        /// </summary>
        public bvec5 bbbbg => new bvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.zzzzz swizzling.
        /// </summary>
        public bvec5 zzzzz => new bvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.bbbbb swizzling (equivalent to bvec4.zzzzz).
        /// </summary>
        public bvec5 bbbbb => new bvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.zzzzw swizzling.
        /// </summary>
        public bvec5 zzzzw => new bvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.bbbba swizzling (equivalent to bvec4.zzzzw).
        /// </summary>
        public bvec5 bbbba => new bvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.zzzw swizzling.
        /// </summary>
        public bvec4 zzzw => new bvec4(z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.bbba swizzling (equivalent to bvec4.zzzw).
        /// </summary>
        public bvec4 bbba => new bvec4(z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.zzzwx swizzling.
        /// </summary>
        public bvec5 zzzwx => new bvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.bbbar swizzling (equivalent to bvec4.zzzwx).
        /// </summary>
        public bvec5 bbbar => new bvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.zzzwy swizzling.
        /// </summary>
        public bvec5 zzzwy => new bvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.bbbag swizzling (equivalent to bvec4.zzzwy).
        /// </summary>
        public bvec5 bbbag => new bvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.zzzwz swizzling.
        /// </summary>
        public bvec5 zzzwz => new bvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.bbbab swizzling (equivalent to bvec4.zzzwz).
        /// </summary>
        public bvec5 bbbab => new bvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.zzzww swizzling.
        /// </summary>
        public bvec5 zzzww => new bvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.bbbaa swizzling (equivalent to bvec4.zzzww).
        /// </summary>
        public bvec5 bbbaa => new bvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.zzw swizzling.
        /// </summary>
        public bvec3 zzw => new bvec3(z, z, w);
        
        /// <summary>
        /// Returns bvec4.bba swizzling (equivalent to bvec4.zzw).
        /// </summary>
        public bvec3 bba => new bvec3(z, z, w);
        
        /// <summary>
        /// Returns bvec4.zzwx swizzling.
        /// </summary>
        public bvec4 zzwx => new bvec4(z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.bbar swizzling (equivalent to bvec4.zzwx).
        /// </summary>
        public bvec4 bbar => new bvec4(z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.zzwxx swizzling.
        /// </summary>
        public bvec5 zzwxx => new bvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.bbarr swizzling (equivalent to bvec4.zzwxx).
        /// </summary>
        public bvec5 bbarr => new bvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.zzwxy swizzling.
        /// </summary>
        public bvec5 zzwxy => new bvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.bbarg swizzling (equivalent to bvec4.zzwxy).
        /// </summary>
        public bvec5 bbarg => new bvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.zzwxz swizzling.
        /// </summary>
        public bvec5 zzwxz => new bvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.bbarb swizzling (equivalent to bvec4.zzwxz).
        /// </summary>
        public bvec5 bbarb => new bvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.zzwxw swizzling.
        /// </summary>
        public bvec5 zzwxw => new bvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.bbara swizzling (equivalent to bvec4.zzwxw).
        /// </summary>
        public bvec5 bbara => new bvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.zzwy swizzling.
        /// </summary>
        public bvec4 zzwy => new bvec4(z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.bbag swizzling (equivalent to bvec4.zzwy).
        /// </summary>
        public bvec4 bbag => new bvec4(z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.zzwyx swizzling.
        /// </summary>
        public bvec5 zzwyx => new bvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.bbagr swizzling (equivalent to bvec4.zzwyx).
        /// </summary>
        public bvec5 bbagr => new bvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.zzwyy swizzling.
        /// </summary>
        public bvec5 zzwyy => new bvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.bbagg swizzling (equivalent to bvec4.zzwyy).
        /// </summary>
        public bvec5 bbagg => new bvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.zzwyz swizzling.
        /// </summary>
        public bvec5 zzwyz => new bvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.bbagb swizzling (equivalent to bvec4.zzwyz).
        /// </summary>
        public bvec5 bbagb => new bvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.zzwyw swizzling.
        /// </summary>
        public bvec5 zzwyw => new bvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.bbaga swizzling (equivalent to bvec4.zzwyw).
        /// </summary>
        public bvec5 bbaga => new bvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.zzwz swizzling.
        /// </summary>
        public bvec4 zzwz => new bvec4(z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.bbab swizzling (equivalent to bvec4.zzwz).
        /// </summary>
        public bvec4 bbab => new bvec4(z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.zzwzx swizzling.
        /// </summary>
        public bvec5 zzwzx => new bvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.bbabr swizzling (equivalent to bvec4.zzwzx).
        /// </summary>
        public bvec5 bbabr => new bvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.zzwzy swizzling.
        /// </summary>
        public bvec5 zzwzy => new bvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.bbabg swizzling (equivalent to bvec4.zzwzy).
        /// </summary>
        public bvec5 bbabg => new bvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.zzwzz swizzling.
        /// </summary>
        public bvec5 zzwzz => new bvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.bbabb swizzling (equivalent to bvec4.zzwzz).
        /// </summary>
        public bvec5 bbabb => new bvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.zzwzw swizzling.
        /// </summary>
        public bvec5 zzwzw => new bvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.bbaba swizzling (equivalent to bvec4.zzwzw).
        /// </summary>
        public bvec5 bbaba => new bvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.zzww swizzling.
        /// </summary>
        public bvec4 zzww => new bvec4(z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.bbaa swizzling (equivalent to bvec4.zzww).
        /// </summary>
        public bvec4 bbaa => new bvec4(z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.zzwwx swizzling.
        /// </summary>
        public bvec5 zzwwx => new bvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.bbaar swizzling (equivalent to bvec4.zzwwx).
        /// </summary>
        public bvec5 bbaar => new bvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.zzwwy swizzling.
        /// </summary>
        public bvec5 zzwwy => new bvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.bbaag swizzling (equivalent to bvec4.zzwwy).
        /// </summary>
        public bvec5 bbaag => new bvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.zzwwz swizzling.
        /// </summary>
        public bvec5 zzwwz => new bvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.bbaab swizzling (equivalent to bvec4.zzwwz).
        /// </summary>
        public bvec5 bbaab => new bvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.zzwww swizzling.
        /// </summary>
        public bvec5 zzwww => new bvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.bbaaa swizzling (equivalent to bvec4.zzwww).
        /// </summary>
        public bvec5 bbaaa => new bvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.zw swizzling.
        /// </summary>
        public bvec2 zw => new bvec2(z, w);
        
        /// <summary>
        /// Returns bvec4.ba swizzling (equivalent to bvec4.zw).
        /// </summary>
        public bvec2 ba => new bvec2(z, w);
        
        /// <summary>
        /// Returns bvec4.zwx swizzling.
        /// </summary>
        public bvec3 zwx => new bvec3(z, w, x);
        
        /// <summary>
        /// Returns bvec4.bar swizzling (equivalent to bvec4.zwx).
        /// </summary>
        public bvec3 bar => new bvec3(z, w, x);
        
        /// <summary>
        /// Returns bvec4.zwxx swizzling.
        /// </summary>
        public bvec4 zwxx => new bvec4(z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.barr swizzling (equivalent to bvec4.zwxx).
        /// </summary>
        public bvec4 barr => new bvec4(z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.zwxxx swizzling.
        /// </summary>
        public bvec5 zwxxx => new bvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.barrr swizzling (equivalent to bvec4.zwxxx).
        /// </summary>
        public bvec5 barrr => new bvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.zwxxy swizzling.
        /// </summary>
        public bvec5 zwxxy => new bvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.barrg swizzling (equivalent to bvec4.zwxxy).
        /// </summary>
        public bvec5 barrg => new bvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.zwxxz swizzling.
        /// </summary>
        public bvec5 zwxxz => new bvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.barrb swizzling (equivalent to bvec4.zwxxz).
        /// </summary>
        public bvec5 barrb => new bvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.zwxxw swizzling.
        /// </summary>
        public bvec5 zwxxw => new bvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.barra swizzling (equivalent to bvec4.zwxxw).
        /// </summary>
        public bvec5 barra => new bvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.zwxy swizzling.
        /// </summary>
        public bvec4 zwxy => new bvec4(z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.barg swizzling (equivalent to bvec4.zwxy).
        /// </summary>
        public bvec4 barg => new bvec4(z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.zwxyx swizzling.
        /// </summary>
        public bvec5 zwxyx => new bvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.bargr swizzling (equivalent to bvec4.zwxyx).
        /// </summary>
        public bvec5 bargr => new bvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.zwxyy swizzling.
        /// </summary>
        public bvec5 zwxyy => new bvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.bargg swizzling (equivalent to bvec4.zwxyy).
        /// </summary>
        public bvec5 bargg => new bvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.zwxyz swizzling.
        /// </summary>
        public bvec5 zwxyz => new bvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.bargb swizzling (equivalent to bvec4.zwxyz).
        /// </summary>
        public bvec5 bargb => new bvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.zwxyw swizzling.
        /// </summary>
        public bvec5 zwxyw => new bvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.barga swizzling (equivalent to bvec4.zwxyw).
        /// </summary>
        public bvec5 barga => new bvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.zwxz swizzling.
        /// </summary>
        public bvec4 zwxz => new bvec4(z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.barb swizzling (equivalent to bvec4.zwxz).
        /// </summary>
        public bvec4 barb => new bvec4(z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.zwxzx swizzling.
        /// </summary>
        public bvec5 zwxzx => new bvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.barbr swizzling (equivalent to bvec4.zwxzx).
        /// </summary>
        public bvec5 barbr => new bvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.zwxzy swizzling.
        /// </summary>
        public bvec5 zwxzy => new bvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.barbg swizzling (equivalent to bvec4.zwxzy).
        /// </summary>
        public bvec5 barbg => new bvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.zwxzz swizzling.
        /// </summary>
        public bvec5 zwxzz => new bvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.barbb swizzling (equivalent to bvec4.zwxzz).
        /// </summary>
        public bvec5 barbb => new bvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.zwxzw swizzling.
        /// </summary>
        public bvec5 zwxzw => new bvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.barba swizzling (equivalent to bvec4.zwxzw).
        /// </summary>
        public bvec5 barba => new bvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.zwxw swizzling.
        /// </summary>
        public bvec4 zwxw => new bvec4(z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.bara swizzling (equivalent to bvec4.zwxw).
        /// </summary>
        public bvec4 bara => new bvec4(z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.zwxwx swizzling.
        /// </summary>
        public bvec5 zwxwx => new bvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.barar swizzling (equivalent to bvec4.zwxwx).
        /// </summary>
        public bvec5 barar => new bvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.zwxwy swizzling.
        /// </summary>
        public bvec5 zwxwy => new bvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.barag swizzling (equivalent to bvec4.zwxwy).
        /// </summary>
        public bvec5 barag => new bvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.zwxwz swizzling.
        /// </summary>
        public bvec5 zwxwz => new bvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.barab swizzling (equivalent to bvec4.zwxwz).
        /// </summary>
        public bvec5 barab => new bvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.zwxww swizzling.
        /// </summary>
        public bvec5 zwxww => new bvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.baraa swizzling (equivalent to bvec4.zwxww).
        /// </summary>
        public bvec5 baraa => new bvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.zwy swizzling.
        /// </summary>
        public bvec3 zwy => new bvec3(z, w, y);
        
        /// <summary>
        /// Returns bvec4.bag swizzling (equivalent to bvec4.zwy).
        /// </summary>
        public bvec3 bag => new bvec3(z, w, y);
        
        /// <summary>
        /// Returns bvec4.zwyx swizzling.
        /// </summary>
        public bvec4 zwyx => new bvec4(z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.bagr swizzling (equivalent to bvec4.zwyx).
        /// </summary>
        public bvec4 bagr => new bvec4(z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.zwyxx swizzling.
        /// </summary>
        public bvec5 zwyxx => new bvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.bagrr swizzling (equivalent to bvec4.zwyxx).
        /// </summary>
        public bvec5 bagrr => new bvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.zwyxy swizzling.
        /// </summary>
        public bvec5 zwyxy => new bvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.bagrg swizzling (equivalent to bvec4.zwyxy).
        /// </summary>
        public bvec5 bagrg => new bvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.zwyxz swizzling.
        /// </summary>
        public bvec5 zwyxz => new bvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.bagrb swizzling (equivalent to bvec4.zwyxz).
        /// </summary>
        public bvec5 bagrb => new bvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.zwyxw swizzling.
        /// </summary>
        public bvec5 zwyxw => new bvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.bagra swizzling (equivalent to bvec4.zwyxw).
        /// </summary>
        public bvec5 bagra => new bvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.zwyy swizzling.
        /// </summary>
        public bvec4 zwyy => new bvec4(z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.bagg swizzling (equivalent to bvec4.zwyy).
        /// </summary>
        public bvec4 bagg => new bvec4(z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.zwyyx swizzling.
        /// </summary>
        public bvec5 zwyyx => new bvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.baggr swizzling (equivalent to bvec4.zwyyx).
        /// </summary>
        public bvec5 baggr => new bvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.zwyyy swizzling.
        /// </summary>
        public bvec5 zwyyy => new bvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.baggg swizzling (equivalent to bvec4.zwyyy).
        /// </summary>
        public bvec5 baggg => new bvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.zwyyz swizzling.
        /// </summary>
        public bvec5 zwyyz => new bvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.baggb swizzling (equivalent to bvec4.zwyyz).
        /// </summary>
        public bvec5 baggb => new bvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.zwyyw swizzling.
        /// </summary>
        public bvec5 zwyyw => new bvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.bagga swizzling (equivalent to bvec4.zwyyw).
        /// </summary>
        public bvec5 bagga => new bvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.zwyz swizzling.
        /// </summary>
        public bvec4 zwyz => new bvec4(z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.bagb swizzling (equivalent to bvec4.zwyz).
        /// </summary>
        public bvec4 bagb => new bvec4(z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.zwyzx swizzling.
        /// </summary>
        public bvec5 zwyzx => new bvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.bagbr swizzling (equivalent to bvec4.zwyzx).
        /// </summary>
        public bvec5 bagbr => new bvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.zwyzy swizzling.
        /// </summary>
        public bvec5 zwyzy => new bvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.bagbg swizzling (equivalent to bvec4.zwyzy).
        /// </summary>
        public bvec5 bagbg => new bvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.zwyzz swizzling.
        /// </summary>
        public bvec5 zwyzz => new bvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.bagbb swizzling (equivalent to bvec4.zwyzz).
        /// </summary>
        public bvec5 bagbb => new bvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.zwyzw swizzling.
        /// </summary>
        public bvec5 zwyzw => new bvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.bagba swizzling (equivalent to bvec4.zwyzw).
        /// </summary>
        public bvec5 bagba => new bvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.zwyw swizzling.
        /// </summary>
        public bvec4 zwyw => new bvec4(z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.baga swizzling (equivalent to bvec4.zwyw).
        /// </summary>
        public bvec4 baga => new bvec4(z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.zwywx swizzling.
        /// </summary>
        public bvec5 zwywx => new bvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.bagar swizzling (equivalent to bvec4.zwywx).
        /// </summary>
        public bvec5 bagar => new bvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.zwywy swizzling.
        /// </summary>
        public bvec5 zwywy => new bvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.bagag swizzling (equivalent to bvec4.zwywy).
        /// </summary>
        public bvec5 bagag => new bvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.zwywz swizzling.
        /// </summary>
        public bvec5 zwywz => new bvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.bagab swizzling (equivalent to bvec4.zwywz).
        /// </summary>
        public bvec5 bagab => new bvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.zwyww swizzling.
        /// </summary>
        public bvec5 zwyww => new bvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.bagaa swizzling (equivalent to bvec4.zwyww).
        /// </summary>
        public bvec5 bagaa => new bvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.zwz swizzling.
        /// </summary>
        public bvec3 zwz => new bvec3(z, w, z);
        
        /// <summary>
        /// Returns bvec4.bab swizzling (equivalent to bvec4.zwz).
        /// </summary>
        public bvec3 bab => new bvec3(z, w, z);
        
        /// <summary>
        /// Returns bvec4.zwzx swizzling.
        /// </summary>
        public bvec4 zwzx => new bvec4(z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.babr swizzling (equivalent to bvec4.zwzx).
        /// </summary>
        public bvec4 babr => new bvec4(z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.zwzxx swizzling.
        /// </summary>
        public bvec5 zwzxx => new bvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.babrr swizzling (equivalent to bvec4.zwzxx).
        /// </summary>
        public bvec5 babrr => new bvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.zwzxy swizzling.
        /// </summary>
        public bvec5 zwzxy => new bvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.babrg swizzling (equivalent to bvec4.zwzxy).
        /// </summary>
        public bvec5 babrg => new bvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.zwzxz swizzling.
        /// </summary>
        public bvec5 zwzxz => new bvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.babrb swizzling (equivalent to bvec4.zwzxz).
        /// </summary>
        public bvec5 babrb => new bvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.zwzxw swizzling.
        /// </summary>
        public bvec5 zwzxw => new bvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.babra swizzling (equivalent to bvec4.zwzxw).
        /// </summary>
        public bvec5 babra => new bvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.zwzy swizzling.
        /// </summary>
        public bvec4 zwzy => new bvec4(z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.babg swizzling (equivalent to bvec4.zwzy).
        /// </summary>
        public bvec4 babg => new bvec4(z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.zwzyx swizzling.
        /// </summary>
        public bvec5 zwzyx => new bvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.babgr swizzling (equivalent to bvec4.zwzyx).
        /// </summary>
        public bvec5 babgr => new bvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.zwzyy swizzling.
        /// </summary>
        public bvec5 zwzyy => new bvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.babgg swizzling (equivalent to bvec4.zwzyy).
        /// </summary>
        public bvec5 babgg => new bvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.zwzyz swizzling.
        /// </summary>
        public bvec5 zwzyz => new bvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.babgb swizzling (equivalent to bvec4.zwzyz).
        /// </summary>
        public bvec5 babgb => new bvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.zwzyw swizzling.
        /// </summary>
        public bvec5 zwzyw => new bvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.babga swizzling (equivalent to bvec4.zwzyw).
        /// </summary>
        public bvec5 babga => new bvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.zwzz swizzling.
        /// </summary>
        public bvec4 zwzz => new bvec4(z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.babb swizzling (equivalent to bvec4.zwzz).
        /// </summary>
        public bvec4 babb => new bvec4(z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.zwzzx swizzling.
        /// </summary>
        public bvec5 zwzzx => new bvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.babbr swizzling (equivalent to bvec4.zwzzx).
        /// </summary>
        public bvec5 babbr => new bvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.zwzzy swizzling.
        /// </summary>
        public bvec5 zwzzy => new bvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.babbg swizzling (equivalent to bvec4.zwzzy).
        /// </summary>
        public bvec5 babbg => new bvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.zwzzz swizzling.
        /// </summary>
        public bvec5 zwzzz => new bvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.babbb swizzling (equivalent to bvec4.zwzzz).
        /// </summary>
        public bvec5 babbb => new bvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.zwzzw swizzling.
        /// </summary>
        public bvec5 zwzzw => new bvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.babba swizzling (equivalent to bvec4.zwzzw).
        /// </summary>
        public bvec5 babba => new bvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.zwzw swizzling.
        /// </summary>
        public bvec4 zwzw => new bvec4(z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.baba swizzling (equivalent to bvec4.zwzw).
        /// </summary>
        public bvec4 baba => new bvec4(z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.zwzwx swizzling.
        /// </summary>
        public bvec5 zwzwx => new bvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.babar swizzling (equivalent to bvec4.zwzwx).
        /// </summary>
        public bvec5 babar => new bvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.zwzwy swizzling.
        /// </summary>
        public bvec5 zwzwy => new bvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.babag swizzling (equivalent to bvec4.zwzwy).
        /// </summary>
        public bvec5 babag => new bvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.zwzwz swizzling.
        /// </summary>
        public bvec5 zwzwz => new bvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.babab swizzling (equivalent to bvec4.zwzwz).
        /// </summary>
        public bvec5 babab => new bvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.zwzww swizzling.
        /// </summary>
        public bvec5 zwzww => new bvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.babaa swizzling (equivalent to bvec4.zwzww).
        /// </summary>
        public bvec5 babaa => new bvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.zww swizzling.
        /// </summary>
        public bvec3 zww => new bvec3(z, w, w);
        
        /// <summary>
        /// Returns bvec4.baa swizzling (equivalent to bvec4.zww).
        /// </summary>
        public bvec3 baa => new bvec3(z, w, w);
        
        /// <summary>
        /// Returns bvec4.zwwx swizzling.
        /// </summary>
        public bvec4 zwwx => new bvec4(z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.baar swizzling (equivalent to bvec4.zwwx).
        /// </summary>
        public bvec4 baar => new bvec4(z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.zwwxx swizzling.
        /// </summary>
        public bvec5 zwwxx => new bvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.baarr swizzling (equivalent to bvec4.zwwxx).
        /// </summary>
        public bvec5 baarr => new bvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.zwwxy swizzling.
        /// </summary>
        public bvec5 zwwxy => new bvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.baarg swizzling (equivalent to bvec4.zwwxy).
        /// </summary>
        public bvec5 baarg => new bvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.zwwxz swizzling.
        /// </summary>
        public bvec5 zwwxz => new bvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.baarb swizzling (equivalent to bvec4.zwwxz).
        /// </summary>
        public bvec5 baarb => new bvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.zwwxw swizzling.
        /// </summary>
        public bvec5 zwwxw => new bvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.baara swizzling (equivalent to bvec4.zwwxw).
        /// </summary>
        public bvec5 baara => new bvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.zwwy swizzling.
        /// </summary>
        public bvec4 zwwy => new bvec4(z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.baag swizzling (equivalent to bvec4.zwwy).
        /// </summary>
        public bvec4 baag => new bvec4(z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.zwwyx swizzling.
        /// </summary>
        public bvec5 zwwyx => new bvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.baagr swizzling (equivalent to bvec4.zwwyx).
        /// </summary>
        public bvec5 baagr => new bvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.zwwyy swizzling.
        /// </summary>
        public bvec5 zwwyy => new bvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.baagg swizzling (equivalent to bvec4.zwwyy).
        /// </summary>
        public bvec5 baagg => new bvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.zwwyz swizzling.
        /// </summary>
        public bvec5 zwwyz => new bvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.baagb swizzling (equivalent to bvec4.zwwyz).
        /// </summary>
        public bvec5 baagb => new bvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.zwwyw swizzling.
        /// </summary>
        public bvec5 zwwyw => new bvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.baaga swizzling (equivalent to bvec4.zwwyw).
        /// </summary>
        public bvec5 baaga => new bvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.zwwz swizzling.
        /// </summary>
        public bvec4 zwwz => new bvec4(z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.baab swizzling (equivalent to bvec4.zwwz).
        /// </summary>
        public bvec4 baab => new bvec4(z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.zwwzx swizzling.
        /// </summary>
        public bvec5 zwwzx => new bvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.baabr swizzling (equivalent to bvec4.zwwzx).
        /// </summary>
        public bvec5 baabr => new bvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.zwwzy swizzling.
        /// </summary>
        public bvec5 zwwzy => new bvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.baabg swizzling (equivalent to bvec4.zwwzy).
        /// </summary>
        public bvec5 baabg => new bvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.zwwzz swizzling.
        /// </summary>
        public bvec5 zwwzz => new bvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.baabb swizzling (equivalent to bvec4.zwwzz).
        /// </summary>
        public bvec5 baabb => new bvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.zwwzw swizzling.
        /// </summary>
        public bvec5 zwwzw => new bvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.baaba swizzling (equivalent to bvec4.zwwzw).
        /// </summary>
        public bvec5 baaba => new bvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.zwww swizzling.
        /// </summary>
        public bvec4 zwww => new bvec4(z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.baaa swizzling (equivalent to bvec4.zwww).
        /// </summary>
        public bvec4 baaa => new bvec4(z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.zwwwx swizzling.
        /// </summary>
        public bvec5 zwwwx => new bvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.baaar swizzling (equivalent to bvec4.zwwwx).
        /// </summary>
        public bvec5 baaar => new bvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.zwwwy swizzling.
        /// </summary>
        public bvec5 zwwwy => new bvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.baaag swizzling (equivalent to bvec4.zwwwy).
        /// </summary>
        public bvec5 baaag => new bvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.zwwwz swizzling.
        /// </summary>
        public bvec5 zwwwz => new bvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.baaab swizzling (equivalent to bvec4.zwwwz).
        /// </summary>
        public bvec5 baaab => new bvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.zwwww swizzling.
        /// </summary>
        public bvec5 zwwww => new bvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns bvec4.baaaa swizzling (equivalent to bvec4.zwwww).
        /// </summary>
        public bvec5 baaaa => new bvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns bvec4.wx swizzling.
        /// </summary>
        public bvec2 wx => new bvec2(w, x);
        
        /// <summary>
        /// Returns bvec4.ar swizzling (equivalent to bvec4.wx).
        /// </summary>
        public bvec2 ar => new bvec2(w, x);
        
        /// <summary>
        /// Returns bvec4.wxx swizzling.
        /// </summary>
        public bvec3 wxx => new bvec3(w, x, x);
        
        /// <summary>
        /// Returns bvec4.arr swizzling (equivalent to bvec4.wxx).
        /// </summary>
        public bvec3 arr => new bvec3(w, x, x);
        
        /// <summary>
        /// Returns bvec4.wxxx swizzling.
        /// </summary>
        public bvec4 wxxx => new bvec4(w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.arrr swizzling (equivalent to bvec4.wxxx).
        /// </summary>
        public bvec4 arrr => new bvec4(w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.wxxxx swizzling.
        /// </summary>
        public bvec5 wxxxx => new bvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.arrrr swizzling (equivalent to bvec4.wxxxx).
        /// </summary>
        public bvec5 arrrr => new bvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.wxxxy swizzling.
        /// </summary>
        public bvec5 wxxxy => new bvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.arrrg swizzling (equivalent to bvec4.wxxxy).
        /// </summary>
        public bvec5 arrrg => new bvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.wxxxz swizzling.
        /// </summary>
        public bvec5 wxxxz => new bvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.arrrb swizzling (equivalent to bvec4.wxxxz).
        /// </summary>
        public bvec5 arrrb => new bvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.wxxxw swizzling.
        /// </summary>
        public bvec5 wxxxw => new bvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.arrra swizzling (equivalent to bvec4.wxxxw).
        /// </summary>
        public bvec5 arrra => new bvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.wxxy swizzling.
        /// </summary>
        public bvec4 wxxy => new bvec4(w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.arrg swizzling (equivalent to bvec4.wxxy).
        /// </summary>
        public bvec4 arrg => new bvec4(w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.wxxyx swizzling.
        /// </summary>
        public bvec5 wxxyx => new bvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.arrgr swizzling (equivalent to bvec4.wxxyx).
        /// </summary>
        public bvec5 arrgr => new bvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.wxxyy swizzling.
        /// </summary>
        public bvec5 wxxyy => new bvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.arrgg swizzling (equivalent to bvec4.wxxyy).
        /// </summary>
        public bvec5 arrgg => new bvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.wxxyz swizzling.
        /// </summary>
        public bvec5 wxxyz => new bvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.arrgb swizzling (equivalent to bvec4.wxxyz).
        /// </summary>
        public bvec5 arrgb => new bvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.wxxyw swizzling.
        /// </summary>
        public bvec5 wxxyw => new bvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.arrga swizzling (equivalent to bvec4.wxxyw).
        /// </summary>
        public bvec5 arrga => new bvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.wxxz swizzling.
        /// </summary>
        public bvec4 wxxz => new bvec4(w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.arrb swizzling (equivalent to bvec4.wxxz).
        /// </summary>
        public bvec4 arrb => new bvec4(w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.wxxzx swizzling.
        /// </summary>
        public bvec5 wxxzx => new bvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.arrbr swizzling (equivalent to bvec4.wxxzx).
        /// </summary>
        public bvec5 arrbr => new bvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.wxxzy swizzling.
        /// </summary>
        public bvec5 wxxzy => new bvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.arrbg swizzling (equivalent to bvec4.wxxzy).
        /// </summary>
        public bvec5 arrbg => new bvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.wxxzz swizzling.
        /// </summary>
        public bvec5 wxxzz => new bvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.arrbb swizzling (equivalent to bvec4.wxxzz).
        /// </summary>
        public bvec5 arrbb => new bvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.wxxzw swizzling.
        /// </summary>
        public bvec5 wxxzw => new bvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.arrba swizzling (equivalent to bvec4.wxxzw).
        /// </summary>
        public bvec5 arrba => new bvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.wxxw swizzling.
        /// </summary>
        public bvec4 wxxw => new bvec4(w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.arra swizzling (equivalent to bvec4.wxxw).
        /// </summary>
        public bvec4 arra => new bvec4(w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.wxxwx swizzling.
        /// </summary>
        public bvec5 wxxwx => new bvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.arrar swizzling (equivalent to bvec4.wxxwx).
        /// </summary>
        public bvec5 arrar => new bvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.wxxwy swizzling.
        /// </summary>
        public bvec5 wxxwy => new bvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.arrag swizzling (equivalent to bvec4.wxxwy).
        /// </summary>
        public bvec5 arrag => new bvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.wxxwz swizzling.
        /// </summary>
        public bvec5 wxxwz => new bvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.arrab swizzling (equivalent to bvec4.wxxwz).
        /// </summary>
        public bvec5 arrab => new bvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.wxxww swizzling.
        /// </summary>
        public bvec5 wxxww => new bvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.arraa swizzling (equivalent to bvec4.wxxww).
        /// </summary>
        public bvec5 arraa => new bvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.wxy swizzling.
        /// </summary>
        public bvec3 wxy => new bvec3(w, x, y);
        
        /// <summary>
        /// Returns bvec4.arg swizzling (equivalent to bvec4.wxy).
        /// </summary>
        public bvec3 arg => new bvec3(w, x, y);
        
        /// <summary>
        /// Returns bvec4.wxyx swizzling.
        /// </summary>
        public bvec4 wxyx => new bvec4(w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.argr swizzling (equivalent to bvec4.wxyx).
        /// </summary>
        public bvec4 argr => new bvec4(w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.wxyxx swizzling.
        /// </summary>
        public bvec5 wxyxx => new bvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.argrr swizzling (equivalent to bvec4.wxyxx).
        /// </summary>
        public bvec5 argrr => new bvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.wxyxy swizzling.
        /// </summary>
        public bvec5 wxyxy => new bvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.argrg swizzling (equivalent to bvec4.wxyxy).
        /// </summary>
        public bvec5 argrg => new bvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.wxyxz swizzling.
        /// </summary>
        public bvec5 wxyxz => new bvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.argrb swizzling (equivalent to bvec4.wxyxz).
        /// </summary>
        public bvec5 argrb => new bvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.wxyxw swizzling.
        /// </summary>
        public bvec5 wxyxw => new bvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.argra swizzling (equivalent to bvec4.wxyxw).
        /// </summary>
        public bvec5 argra => new bvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.wxyy swizzling.
        /// </summary>
        public bvec4 wxyy => new bvec4(w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.argg swizzling (equivalent to bvec4.wxyy).
        /// </summary>
        public bvec4 argg => new bvec4(w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.wxyyx swizzling.
        /// </summary>
        public bvec5 wxyyx => new bvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.arggr swizzling (equivalent to bvec4.wxyyx).
        /// </summary>
        public bvec5 arggr => new bvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.wxyyy swizzling.
        /// </summary>
        public bvec5 wxyyy => new bvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.arggg swizzling (equivalent to bvec4.wxyyy).
        /// </summary>
        public bvec5 arggg => new bvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.wxyyz swizzling.
        /// </summary>
        public bvec5 wxyyz => new bvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.arggb swizzling (equivalent to bvec4.wxyyz).
        /// </summary>
        public bvec5 arggb => new bvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.wxyyw swizzling.
        /// </summary>
        public bvec5 wxyyw => new bvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.argga swizzling (equivalent to bvec4.wxyyw).
        /// </summary>
        public bvec5 argga => new bvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.wxyz swizzling.
        /// </summary>
        public bvec4 wxyz => new bvec4(w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.argb swizzling (equivalent to bvec4.wxyz).
        /// </summary>
        public bvec4 argb => new bvec4(w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.wxyzx swizzling.
        /// </summary>
        public bvec5 wxyzx => new bvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.argbr swizzling (equivalent to bvec4.wxyzx).
        /// </summary>
        public bvec5 argbr => new bvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.wxyzy swizzling.
        /// </summary>
        public bvec5 wxyzy => new bvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.argbg swizzling (equivalent to bvec4.wxyzy).
        /// </summary>
        public bvec5 argbg => new bvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.wxyzz swizzling.
        /// </summary>
        public bvec5 wxyzz => new bvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.argbb swizzling (equivalent to bvec4.wxyzz).
        /// </summary>
        public bvec5 argbb => new bvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.wxyzw swizzling.
        /// </summary>
        public bvec5 wxyzw => new bvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.argba swizzling (equivalent to bvec4.wxyzw).
        /// </summary>
        public bvec5 argba => new bvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.wxyw swizzling.
        /// </summary>
        public bvec4 wxyw => new bvec4(w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.arga swizzling (equivalent to bvec4.wxyw).
        /// </summary>
        public bvec4 arga => new bvec4(w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.wxywx swizzling.
        /// </summary>
        public bvec5 wxywx => new bvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.argar swizzling (equivalent to bvec4.wxywx).
        /// </summary>
        public bvec5 argar => new bvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.wxywy swizzling.
        /// </summary>
        public bvec5 wxywy => new bvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.argag swizzling (equivalent to bvec4.wxywy).
        /// </summary>
        public bvec5 argag => new bvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.wxywz swizzling.
        /// </summary>
        public bvec5 wxywz => new bvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.argab swizzling (equivalent to bvec4.wxywz).
        /// </summary>
        public bvec5 argab => new bvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.wxyww swizzling.
        /// </summary>
        public bvec5 wxyww => new bvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.argaa swizzling (equivalent to bvec4.wxyww).
        /// </summary>
        public bvec5 argaa => new bvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.wxz swizzling.
        /// </summary>
        public bvec3 wxz => new bvec3(w, x, z);
        
        /// <summary>
        /// Returns bvec4.arb swizzling (equivalent to bvec4.wxz).
        /// </summary>
        public bvec3 arb => new bvec3(w, x, z);
        
        /// <summary>
        /// Returns bvec4.wxzx swizzling.
        /// </summary>
        public bvec4 wxzx => new bvec4(w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.arbr swizzling (equivalent to bvec4.wxzx).
        /// </summary>
        public bvec4 arbr => new bvec4(w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.wxzxx swizzling.
        /// </summary>
        public bvec5 wxzxx => new bvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.arbrr swizzling (equivalent to bvec4.wxzxx).
        /// </summary>
        public bvec5 arbrr => new bvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.wxzxy swizzling.
        /// </summary>
        public bvec5 wxzxy => new bvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.arbrg swizzling (equivalent to bvec4.wxzxy).
        /// </summary>
        public bvec5 arbrg => new bvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.wxzxz swizzling.
        /// </summary>
        public bvec5 wxzxz => new bvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.arbrb swizzling (equivalent to bvec4.wxzxz).
        /// </summary>
        public bvec5 arbrb => new bvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.wxzxw swizzling.
        /// </summary>
        public bvec5 wxzxw => new bvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.arbra swizzling (equivalent to bvec4.wxzxw).
        /// </summary>
        public bvec5 arbra => new bvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.wxzy swizzling.
        /// </summary>
        public bvec4 wxzy => new bvec4(w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.arbg swizzling (equivalent to bvec4.wxzy).
        /// </summary>
        public bvec4 arbg => new bvec4(w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.wxzyx swizzling.
        /// </summary>
        public bvec5 wxzyx => new bvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.arbgr swizzling (equivalent to bvec4.wxzyx).
        /// </summary>
        public bvec5 arbgr => new bvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.wxzyy swizzling.
        /// </summary>
        public bvec5 wxzyy => new bvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.arbgg swizzling (equivalent to bvec4.wxzyy).
        /// </summary>
        public bvec5 arbgg => new bvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.wxzyz swizzling.
        /// </summary>
        public bvec5 wxzyz => new bvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.arbgb swizzling (equivalent to bvec4.wxzyz).
        /// </summary>
        public bvec5 arbgb => new bvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.wxzyw swizzling.
        /// </summary>
        public bvec5 wxzyw => new bvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.arbga swizzling (equivalent to bvec4.wxzyw).
        /// </summary>
        public bvec5 arbga => new bvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.wxzz swizzling.
        /// </summary>
        public bvec4 wxzz => new bvec4(w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.arbb swizzling (equivalent to bvec4.wxzz).
        /// </summary>
        public bvec4 arbb => new bvec4(w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.wxzzx swizzling.
        /// </summary>
        public bvec5 wxzzx => new bvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.arbbr swizzling (equivalent to bvec4.wxzzx).
        /// </summary>
        public bvec5 arbbr => new bvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.wxzzy swizzling.
        /// </summary>
        public bvec5 wxzzy => new bvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.arbbg swizzling (equivalent to bvec4.wxzzy).
        /// </summary>
        public bvec5 arbbg => new bvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.wxzzz swizzling.
        /// </summary>
        public bvec5 wxzzz => new bvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.arbbb swizzling (equivalent to bvec4.wxzzz).
        /// </summary>
        public bvec5 arbbb => new bvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.wxzzw swizzling.
        /// </summary>
        public bvec5 wxzzw => new bvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.arbba swizzling (equivalent to bvec4.wxzzw).
        /// </summary>
        public bvec5 arbba => new bvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.wxzw swizzling.
        /// </summary>
        public bvec4 wxzw => new bvec4(w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.arba swizzling (equivalent to bvec4.wxzw).
        /// </summary>
        public bvec4 arba => new bvec4(w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.wxzwx swizzling.
        /// </summary>
        public bvec5 wxzwx => new bvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.arbar swizzling (equivalent to bvec4.wxzwx).
        /// </summary>
        public bvec5 arbar => new bvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.wxzwy swizzling.
        /// </summary>
        public bvec5 wxzwy => new bvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.arbag swizzling (equivalent to bvec4.wxzwy).
        /// </summary>
        public bvec5 arbag => new bvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.wxzwz swizzling.
        /// </summary>
        public bvec5 wxzwz => new bvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.arbab swizzling (equivalent to bvec4.wxzwz).
        /// </summary>
        public bvec5 arbab => new bvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.wxzww swizzling.
        /// </summary>
        public bvec5 wxzww => new bvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.arbaa swizzling (equivalent to bvec4.wxzww).
        /// </summary>
        public bvec5 arbaa => new bvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.wxw swizzling.
        /// </summary>
        public bvec3 wxw => new bvec3(w, x, w);
        
        /// <summary>
        /// Returns bvec4.ara swizzling (equivalent to bvec4.wxw).
        /// </summary>
        public bvec3 ara => new bvec3(w, x, w);
        
        /// <summary>
        /// Returns bvec4.wxwx swizzling.
        /// </summary>
        public bvec4 wxwx => new bvec4(w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.arar swizzling (equivalent to bvec4.wxwx).
        /// </summary>
        public bvec4 arar => new bvec4(w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.wxwxx swizzling.
        /// </summary>
        public bvec5 wxwxx => new bvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.ararr swizzling (equivalent to bvec4.wxwxx).
        /// </summary>
        public bvec5 ararr => new bvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.wxwxy swizzling.
        /// </summary>
        public bvec5 wxwxy => new bvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.ararg swizzling (equivalent to bvec4.wxwxy).
        /// </summary>
        public bvec5 ararg => new bvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.wxwxz swizzling.
        /// </summary>
        public bvec5 wxwxz => new bvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.ararb swizzling (equivalent to bvec4.wxwxz).
        /// </summary>
        public bvec5 ararb => new bvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.wxwxw swizzling.
        /// </summary>
        public bvec5 wxwxw => new bvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.arara swizzling (equivalent to bvec4.wxwxw).
        /// </summary>
        public bvec5 arara => new bvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.wxwy swizzling.
        /// </summary>
        public bvec4 wxwy => new bvec4(w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.arag swizzling (equivalent to bvec4.wxwy).
        /// </summary>
        public bvec4 arag => new bvec4(w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.wxwyx swizzling.
        /// </summary>
        public bvec5 wxwyx => new bvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.aragr swizzling (equivalent to bvec4.wxwyx).
        /// </summary>
        public bvec5 aragr => new bvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.wxwyy swizzling.
        /// </summary>
        public bvec5 wxwyy => new bvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.aragg swizzling (equivalent to bvec4.wxwyy).
        /// </summary>
        public bvec5 aragg => new bvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.wxwyz swizzling.
        /// </summary>
        public bvec5 wxwyz => new bvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.aragb swizzling (equivalent to bvec4.wxwyz).
        /// </summary>
        public bvec5 aragb => new bvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.wxwyw swizzling.
        /// </summary>
        public bvec5 wxwyw => new bvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.araga swizzling (equivalent to bvec4.wxwyw).
        /// </summary>
        public bvec5 araga => new bvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.wxwz swizzling.
        /// </summary>
        public bvec4 wxwz => new bvec4(w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.arab swizzling (equivalent to bvec4.wxwz).
        /// </summary>
        public bvec4 arab => new bvec4(w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.wxwzx swizzling.
        /// </summary>
        public bvec5 wxwzx => new bvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.arabr swizzling (equivalent to bvec4.wxwzx).
        /// </summary>
        public bvec5 arabr => new bvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.wxwzy swizzling.
        /// </summary>
        public bvec5 wxwzy => new bvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.arabg swizzling (equivalent to bvec4.wxwzy).
        /// </summary>
        public bvec5 arabg => new bvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.wxwzz swizzling.
        /// </summary>
        public bvec5 wxwzz => new bvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.arabb swizzling (equivalent to bvec4.wxwzz).
        /// </summary>
        public bvec5 arabb => new bvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.wxwzw swizzling.
        /// </summary>
        public bvec5 wxwzw => new bvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.araba swizzling (equivalent to bvec4.wxwzw).
        /// </summary>
        public bvec5 araba => new bvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.wxww swizzling.
        /// </summary>
        public bvec4 wxww => new bvec4(w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.araa swizzling (equivalent to bvec4.wxww).
        /// </summary>
        public bvec4 araa => new bvec4(w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.wxwwx swizzling.
        /// </summary>
        public bvec5 wxwwx => new bvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.araar swizzling (equivalent to bvec4.wxwwx).
        /// </summary>
        public bvec5 araar => new bvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.wxwwy swizzling.
        /// </summary>
        public bvec5 wxwwy => new bvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.araag swizzling (equivalent to bvec4.wxwwy).
        /// </summary>
        public bvec5 araag => new bvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.wxwwz swizzling.
        /// </summary>
        public bvec5 wxwwz => new bvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.araab swizzling (equivalent to bvec4.wxwwz).
        /// </summary>
        public bvec5 araab => new bvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.wxwww swizzling.
        /// </summary>
        public bvec5 wxwww => new bvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.araaa swizzling (equivalent to bvec4.wxwww).
        /// </summary>
        public bvec5 araaa => new bvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.wy swizzling.
        /// </summary>
        public bvec2 wy => new bvec2(w, y);
        
        /// <summary>
        /// Returns bvec4.ag swizzling (equivalent to bvec4.wy).
        /// </summary>
        public bvec2 ag => new bvec2(w, y);
        
        /// <summary>
        /// Returns bvec4.wyx swizzling.
        /// </summary>
        public bvec3 wyx => new bvec3(w, y, x);
        
        /// <summary>
        /// Returns bvec4.agr swizzling (equivalent to bvec4.wyx).
        /// </summary>
        public bvec3 agr => new bvec3(w, y, x);
        
        /// <summary>
        /// Returns bvec4.wyxx swizzling.
        /// </summary>
        public bvec4 wyxx => new bvec4(w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.agrr swizzling (equivalent to bvec4.wyxx).
        /// </summary>
        public bvec4 agrr => new bvec4(w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.wyxxx swizzling.
        /// </summary>
        public bvec5 wyxxx => new bvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.agrrr swizzling (equivalent to bvec4.wyxxx).
        /// </summary>
        public bvec5 agrrr => new bvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.wyxxy swizzling.
        /// </summary>
        public bvec5 wyxxy => new bvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.agrrg swizzling (equivalent to bvec4.wyxxy).
        /// </summary>
        public bvec5 agrrg => new bvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.wyxxz swizzling.
        /// </summary>
        public bvec5 wyxxz => new bvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.agrrb swizzling (equivalent to bvec4.wyxxz).
        /// </summary>
        public bvec5 agrrb => new bvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.wyxxw swizzling.
        /// </summary>
        public bvec5 wyxxw => new bvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.agrra swizzling (equivalent to bvec4.wyxxw).
        /// </summary>
        public bvec5 agrra => new bvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.wyxy swizzling.
        /// </summary>
        public bvec4 wyxy => new bvec4(w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.agrg swizzling (equivalent to bvec4.wyxy).
        /// </summary>
        public bvec4 agrg => new bvec4(w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.wyxyx swizzling.
        /// </summary>
        public bvec5 wyxyx => new bvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.agrgr swizzling (equivalent to bvec4.wyxyx).
        /// </summary>
        public bvec5 agrgr => new bvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.wyxyy swizzling.
        /// </summary>
        public bvec5 wyxyy => new bvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.agrgg swizzling (equivalent to bvec4.wyxyy).
        /// </summary>
        public bvec5 agrgg => new bvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.wyxyz swizzling.
        /// </summary>
        public bvec5 wyxyz => new bvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.agrgb swizzling (equivalent to bvec4.wyxyz).
        /// </summary>
        public bvec5 agrgb => new bvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.wyxyw swizzling.
        /// </summary>
        public bvec5 wyxyw => new bvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.agrga swizzling (equivalent to bvec4.wyxyw).
        /// </summary>
        public bvec5 agrga => new bvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.wyxz swizzling.
        /// </summary>
        public bvec4 wyxz => new bvec4(w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.agrb swizzling (equivalent to bvec4.wyxz).
        /// </summary>
        public bvec4 agrb => new bvec4(w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.wyxzx swizzling.
        /// </summary>
        public bvec5 wyxzx => new bvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.agrbr swizzling (equivalent to bvec4.wyxzx).
        /// </summary>
        public bvec5 agrbr => new bvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.wyxzy swizzling.
        /// </summary>
        public bvec5 wyxzy => new bvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.agrbg swizzling (equivalent to bvec4.wyxzy).
        /// </summary>
        public bvec5 agrbg => new bvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.wyxzz swizzling.
        /// </summary>
        public bvec5 wyxzz => new bvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.agrbb swizzling (equivalent to bvec4.wyxzz).
        /// </summary>
        public bvec5 agrbb => new bvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.wyxzw swizzling.
        /// </summary>
        public bvec5 wyxzw => new bvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.agrba swizzling (equivalent to bvec4.wyxzw).
        /// </summary>
        public bvec5 agrba => new bvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.wyxw swizzling.
        /// </summary>
        public bvec4 wyxw => new bvec4(w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.agra swizzling (equivalent to bvec4.wyxw).
        /// </summary>
        public bvec4 agra => new bvec4(w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.wyxwx swizzling.
        /// </summary>
        public bvec5 wyxwx => new bvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.agrar swizzling (equivalent to bvec4.wyxwx).
        /// </summary>
        public bvec5 agrar => new bvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.wyxwy swizzling.
        /// </summary>
        public bvec5 wyxwy => new bvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.agrag swizzling (equivalent to bvec4.wyxwy).
        /// </summary>
        public bvec5 agrag => new bvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.wyxwz swizzling.
        /// </summary>
        public bvec5 wyxwz => new bvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.agrab swizzling (equivalent to bvec4.wyxwz).
        /// </summary>
        public bvec5 agrab => new bvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.wyxww swizzling.
        /// </summary>
        public bvec5 wyxww => new bvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.agraa swizzling (equivalent to bvec4.wyxww).
        /// </summary>
        public bvec5 agraa => new bvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.wyy swizzling.
        /// </summary>
        public bvec3 wyy => new bvec3(w, y, y);
        
        /// <summary>
        /// Returns bvec4.agg swizzling (equivalent to bvec4.wyy).
        /// </summary>
        public bvec3 agg => new bvec3(w, y, y);
        
        /// <summary>
        /// Returns bvec4.wyyx swizzling.
        /// </summary>
        public bvec4 wyyx => new bvec4(w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.aggr swizzling (equivalent to bvec4.wyyx).
        /// </summary>
        public bvec4 aggr => new bvec4(w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.wyyxx swizzling.
        /// </summary>
        public bvec5 wyyxx => new bvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.aggrr swizzling (equivalent to bvec4.wyyxx).
        /// </summary>
        public bvec5 aggrr => new bvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.wyyxy swizzling.
        /// </summary>
        public bvec5 wyyxy => new bvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.aggrg swizzling (equivalent to bvec4.wyyxy).
        /// </summary>
        public bvec5 aggrg => new bvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.wyyxz swizzling.
        /// </summary>
        public bvec5 wyyxz => new bvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.aggrb swizzling (equivalent to bvec4.wyyxz).
        /// </summary>
        public bvec5 aggrb => new bvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.wyyxw swizzling.
        /// </summary>
        public bvec5 wyyxw => new bvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.aggra swizzling (equivalent to bvec4.wyyxw).
        /// </summary>
        public bvec5 aggra => new bvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.wyyy swizzling.
        /// </summary>
        public bvec4 wyyy => new bvec4(w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.aggg swizzling (equivalent to bvec4.wyyy).
        /// </summary>
        public bvec4 aggg => new bvec4(w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.wyyyx swizzling.
        /// </summary>
        public bvec5 wyyyx => new bvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.agggr swizzling (equivalent to bvec4.wyyyx).
        /// </summary>
        public bvec5 agggr => new bvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.wyyyy swizzling.
        /// </summary>
        public bvec5 wyyyy => new bvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.agggg swizzling (equivalent to bvec4.wyyyy).
        /// </summary>
        public bvec5 agggg => new bvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.wyyyz swizzling.
        /// </summary>
        public bvec5 wyyyz => new bvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.agggb swizzling (equivalent to bvec4.wyyyz).
        /// </summary>
        public bvec5 agggb => new bvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.wyyyw swizzling.
        /// </summary>
        public bvec5 wyyyw => new bvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.aggga swizzling (equivalent to bvec4.wyyyw).
        /// </summary>
        public bvec5 aggga => new bvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.wyyz swizzling.
        /// </summary>
        public bvec4 wyyz => new bvec4(w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.aggb swizzling (equivalent to bvec4.wyyz).
        /// </summary>
        public bvec4 aggb => new bvec4(w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.wyyzx swizzling.
        /// </summary>
        public bvec5 wyyzx => new bvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.aggbr swizzling (equivalent to bvec4.wyyzx).
        /// </summary>
        public bvec5 aggbr => new bvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.wyyzy swizzling.
        /// </summary>
        public bvec5 wyyzy => new bvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.aggbg swizzling (equivalent to bvec4.wyyzy).
        /// </summary>
        public bvec5 aggbg => new bvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.wyyzz swizzling.
        /// </summary>
        public bvec5 wyyzz => new bvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.aggbb swizzling (equivalent to bvec4.wyyzz).
        /// </summary>
        public bvec5 aggbb => new bvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.wyyzw swizzling.
        /// </summary>
        public bvec5 wyyzw => new bvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.aggba swizzling (equivalent to bvec4.wyyzw).
        /// </summary>
        public bvec5 aggba => new bvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.wyyw swizzling.
        /// </summary>
        public bvec4 wyyw => new bvec4(w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.agga swizzling (equivalent to bvec4.wyyw).
        /// </summary>
        public bvec4 agga => new bvec4(w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.wyywx swizzling.
        /// </summary>
        public bvec5 wyywx => new bvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.aggar swizzling (equivalent to bvec4.wyywx).
        /// </summary>
        public bvec5 aggar => new bvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.wyywy swizzling.
        /// </summary>
        public bvec5 wyywy => new bvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.aggag swizzling (equivalent to bvec4.wyywy).
        /// </summary>
        public bvec5 aggag => new bvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.wyywz swizzling.
        /// </summary>
        public bvec5 wyywz => new bvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.aggab swizzling (equivalent to bvec4.wyywz).
        /// </summary>
        public bvec5 aggab => new bvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.wyyww swizzling.
        /// </summary>
        public bvec5 wyyww => new bvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.aggaa swizzling (equivalent to bvec4.wyyww).
        /// </summary>
        public bvec5 aggaa => new bvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.wyz swizzling.
        /// </summary>
        public bvec3 wyz => new bvec3(w, y, z);
        
        /// <summary>
        /// Returns bvec4.agb swizzling (equivalent to bvec4.wyz).
        /// </summary>
        public bvec3 agb => new bvec3(w, y, z);
        
        /// <summary>
        /// Returns bvec4.wyzx swizzling.
        /// </summary>
        public bvec4 wyzx => new bvec4(w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.agbr swizzling (equivalent to bvec4.wyzx).
        /// </summary>
        public bvec4 agbr => new bvec4(w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.wyzxx swizzling.
        /// </summary>
        public bvec5 wyzxx => new bvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.agbrr swizzling (equivalent to bvec4.wyzxx).
        /// </summary>
        public bvec5 agbrr => new bvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.wyzxy swizzling.
        /// </summary>
        public bvec5 wyzxy => new bvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.agbrg swizzling (equivalent to bvec4.wyzxy).
        /// </summary>
        public bvec5 agbrg => new bvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.wyzxz swizzling.
        /// </summary>
        public bvec5 wyzxz => new bvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.agbrb swizzling (equivalent to bvec4.wyzxz).
        /// </summary>
        public bvec5 agbrb => new bvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.wyzxw swizzling.
        /// </summary>
        public bvec5 wyzxw => new bvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.agbra swizzling (equivalent to bvec4.wyzxw).
        /// </summary>
        public bvec5 agbra => new bvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.wyzy swizzling.
        /// </summary>
        public bvec4 wyzy => new bvec4(w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.agbg swizzling (equivalent to bvec4.wyzy).
        /// </summary>
        public bvec4 agbg => new bvec4(w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.wyzyx swizzling.
        /// </summary>
        public bvec5 wyzyx => new bvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.agbgr swizzling (equivalent to bvec4.wyzyx).
        /// </summary>
        public bvec5 agbgr => new bvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.wyzyy swizzling.
        /// </summary>
        public bvec5 wyzyy => new bvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.agbgg swizzling (equivalent to bvec4.wyzyy).
        /// </summary>
        public bvec5 agbgg => new bvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.wyzyz swizzling.
        /// </summary>
        public bvec5 wyzyz => new bvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.agbgb swizzling (equivalent to bvec4.wyzyz).
        /// </summary>
        public bvec5 agbgb => new bvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.wyzyw swizzling.
        /// </summary>
        public bvec5 wyzyw => new bvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.agbga swizzling (equivalent to bvec4.wyzyw).
        /// </summary>
        public bvec5 agbga => new bvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.wyzz swizzling.
        /// </summary>
        public bvec4 wyzz => new bvec4(w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.agbb swizzling (equivalent to bvec4.wyzz).
        /// </summary>
        public bvec4 agbb => new bvec4(w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.wyzzx swizzling.
        /// </summary>
        public bvec5 wyzzx => new bvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.agbbr swizzling (equivalent to bvec4.wyzzx).
        /// </summary>
        public bvec5 agbbr => new bvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.wyzzy swizzling.
        /// </summary>
        public bvec5 wyzzy => new bvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.agbbg swizzling (equivalent to bvec4.wyzzy).
        /// </summary>
        public bvec5 agbbg => new bvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.wyzzz swizzling.
        /// </summary>
        public bvec5 wyzzz => new bvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.agbbb swizzling (equivalent to bvec4.wyzzz).
        /// </summary>
        public bvec5 agbbb => new bvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.wyzzw swizzling.
        /// </summary>
        public bvec5 wyzzw => new bvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.agbba swizzling (equivalent to bvec4.wyzzw).
        /// </summary>
        public bvec5 agbba => new bvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.wyzw swizzling.
        /// </summary>
        public bvec4 wyzw => new bvec4(w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.agba swizzling (equivalent to bvec4.wyzw).
        /// </summary>
        public bvec4 agba => new bvec4(w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.wyzwx swizzling.
        /// </summary>
        public bvec5 wyzwx => new bvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.agbar swizzling (equivalent to bvec4.wyzwx).
        /// </summary>
        public bvec5 agbar => new bvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.wyzwy swizzling.
        /// </summary>
        public bvec5 wyzwy => new bvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.agbag swizzling (equivalent to bvec4.wyzwy).
        /// </summary>
        public bvec5 agbag => new bvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.wyzwz swizzling.
        /// </summary>
        public bvec5 wyzwz => new bvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.agbab swizzling (equivalent to bvec4.wyzwz).
        /// </summary>
        public bvec5 agbab => new bvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.wyzww swizzling.
        /// </summary>
        public bvec5 wyzww => new bvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.agbaa swizzling (equivalent to bvec4.wyzww).
        /// </summary>
        public bvec5 agbaa => new bvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.wyw swizzling.
        /// </summary>
        public bvec3 wyw => new bvec3(w, y, w);
        
        /// <summary>
        /// Returns bvec4.aga swizzling (equivalent to bvec4.wyw).
        /// </summary>
        public bvec3 aga => new bvec3(w, y, w);
        
        /// <summary>
        /// Returns bvec4.wywx swizzling.
        /// </summary>
        public bvec4 wywx => new bvec4(w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.agar swizzling (equivalent to bvec4.wywx).
        /// </summary>
        public bvec4 agar => new bvec4(w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.wywxx swizzling.
        /// </summary>
        public bvec5 wywxx => new bvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.agarr swizzling (equivalent to bvec4.wywxx).
        /// </summary>
        public bvec5 agarr => new bvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.wywxy swizzling.
        /// </summary>
        public bvec5 wywxy => new bvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.agarg swizzling (equivalent to bvec4.wywxy).
        /// </summary>
        public bvec5 agarg => new bvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.wywxz swizzling.
        /// </summary>
        public bvec5 wywxz => new bvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.agarb swizzling (equivalent to bvec4.wywxz).
        /// </summary>
        public bvec5 agarb => new bvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.wywxw swizzling.
        /// </summary>
        public bvec5 wywxw => new bvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.agara swizzling (equivalent to bvec4.wywxw).
        /// </summary>
        public bvec5 agara => new bvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.wywy swizzling.
        /// </summary>
        public bvec4 wywy => new bvec4(w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.agag swizzling (equivalent to bvec4.wywy).
        /// </summary>
        public bvec4 agag => new bvec4(w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.wywyx swizzling.
        /// </summary>
        public bvec5 wywyx => new bvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.agagr swizzling (equivalent to bvec4.wywyx).
        /// </summary>
        public bvec5 agagr => new bvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.wywyy swizzling.
        /// </summary>
        public bvec5 wywyy => new bvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.agagg swizzling (equivalent to bvec4.wywyy).
        /// </summary>
        public bvec5 agagg => new bvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.wywyz swizzling.
        /// </summary>
        public bvec5 wywyz => new bvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.agagb swizzling (equivalent to bvec4.wywyz).
        /// </summary>
        public bvec5 agagb => new bvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.wywyw swizzling.
        /// </summary>
        public bvec5 wywyw => new bvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.agaga swizzling (equivalent to bvec4.wywyw).
        /// </summary>
        public bvec5 agaga => new bvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.wywz swizzling.
        /// </summary>
        public bvec4 wywz => new bvec4(w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.agab swizzling (equivalent to bvec4.wywz).
        /// </summary>
        public bvec4 agab => new bvec4(w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.wywzx swizzling.
        /// </summary>
        public bvec5 wywzx => new bvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.agabr swizzling (equivalent to bvec4.wywzx).
        /// </summary>
        public bvec5 agabr => new bvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.wywzy swizzling.
        /// </summary>
        public bvec5 wywzy => new bvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.agabg swizzling (equivalent to bvec4.wywzy).
        /// </summary>
        public bvec5 agabg => new bvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.wywzz swizzling.
        /// </summary>
        public bvec5 wywzz => new bvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.agabb swizzling (equivalent to bvec4.wywzz).
        /// </summary>
        public bvec5 agabb => new bvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.wywzw swizzling.
        /// </summary>
        public bvec5 wywzw => new bvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.agaba swizzling (equivalent to bvec4.wywzw).
        /// </summary>
        public bvec5 agaba => new bvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.wyww swizzling.
        /// </summary>
        public bvec4 wyww => new bvec4(w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.agaa swizzling (equivalent to bvec4.wyww).
        /// </summary>
        public bvec4 agaa => new bvec4(w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.wywwx swizzling.
        /// </summary>
        public bvec5 wywwx => new bvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.agaar swizzling (equivalent to bvec4.wywwx).
        /// </summary>
        public bvec5 agaar => new bvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.wywwy swizzling.
        /// </summary>
        public bvec5 wywwy => new bvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.agaag swizzling (equivalent to bvec4.wywwy).
        /// </summary>
        public bvec5 agaag => new bvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.wywwz swizzling.
        /// </summary>
        public bvec5 wywwz => new bvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.agaab swizzling (equivalent to bvec4.wywwz).
        /// </summary>
        public bvec5 agaab => new bvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.wywww swizzling.
        /// </summary>
        public bvec5 wywww => new bvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.agaaa swizzling (equivalent to bvec4.wywww).
        /// </summary>
        public bvec5 agaaa => new bvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.wz swizzling.
        /// </summary>
        public bvec2 wz => new bvec2(w, z);
        
        /// <summary>
        /// Returns bvec4.ab swizzling (equivalent to bvec4.wz).
        /// </summary>
        public bvec2 ab => new bvec2(w, z);
        
        /// <summary>
        /// Returns bvec4.wzx swizzling.
        /// </summary>
        public bvec3 wzx => new bvec3(w, z, x);
        
        /// <summary>
        /// Returns bvec4.abr swizzling (equivalent to bvec4.wzx).
        /// </summary>
        public bvec3 abr => new bvec3(w, z, x);
        
        /// <summary>
        /// Returns bvec4.wzxx swizzling.
        /// </summary>
        public bvec4 wzxx => new bvec4(w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.abrr swizzling (equivalent to bvec4.wzxx).
        /// </summary>
        public bvec4 abrr => new bvec4(w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.wzxxx swizzling.
        /// </summary>
        public bvec5 wzxxx => new bvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.abrrr swizzling (equivalent to bvec4.wzxxx).
        /// </summary>
        public bvec5 abrrr => new bvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.wzxxy swizzling.
        /// </summary>
        public bvec5 wzxxy => new bvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.abrrg swizzling (equivalent to bvec4.wzxxy).
        /// </summary>
        public bvec5 abrrg => new bvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.wzxxz swizzling.
        /// </summary>
        public bvec5 wzxxz => new bvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.abrrb swizzling (equivalent to bvec4.wzxxz).
        /// </summary>
        public bvec5 abrrb => new bvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.wzxxw swizzling.
        /// </summary>
        public bvec5 wzxxw => new bvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.abrra swizzling (equivalent to bvec4.wzxxw).
        /// </summary>
        public bvec5 abrra => new bvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.wzxy swizzling.
        /// </summary>
        public bvec4 wzxy => new bvec4(w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.abrg swizzling (equivalent to bvec4.wzxy).
        /// </summary>
        public bvec4 abrg => new bvec4(w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.wzxyx swizzling.
        /// </summary>
        public bvec5 wzxyx => new bvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.abrgr swizzling (equivalent to bvec4.wzxyx).
        /// </summary>
        public bvec5 abrgr => new bvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.wzxyy swizzling.
        /// </summary>
        public bvec5 wzxyy => new bvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.abrgg swizzling (equivalent to bvec4.wzxyy).
        /// </summary>
        public bvec5 abrgg => new bvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.wzxyz swizzling.
        /// </summary>
        public bvec5 wzxyz => new bvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.abrgb swizzling (equivalent to bvec4.wzxyz).
        /// </summary>
        public bvec5 abrgb => new bvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.wzxyw swizzling.
        /// </summary>
        public bvec5 wzxyw => new bvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.abrga swizzling (equivalent to bvec4.wzxyw).
        /// </summary>
        public bvec5 abrga => new bvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.wzxz swizzling.
        /// </summary>
        public bvec4 wzxz => new bvec4(w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.abrb swizzling (equivalent to bvec4.wzxz).
        /// </summary>
        public bvec4 abrb => new bvec4(w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.wzxzx swizzling.
        /// </summary>
        public bvec5 wzxzx => new bvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.abrbr swizzling (equivalent to bvec4.wzxzx).
        /// </summary>
        public bvec5 abrbr => new bvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.wzxzy swizzling.
        /// </summary>
        public bvec5 wzxzy => new bvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.abrbg swizzling (equivalent to bvec4.wzxzy).
        /// </summary>
        public bvec5 abrbg => new bvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.wzxzz swizzling.
        /// </summary>
        public bvec5 wzxzz => new bvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.abrbb swizzling (equivalent to bvec4.wzxzz).
        /// </summary>
        public bvec5 abrbb => new bvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.wzxzw swizzling.
        /// </summary>
        public bvec5 wzxzw => new bvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.abrba swizzling (equivalent to bvec4.wzxzw).
        /// </summary>
        public bvec5 abrba => new bvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.wzxw swizzling.
        /// </summary>
        public bvec4 wzxw => new bvec4(w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.abra swizzling (equivalent to bvec4.wzxw).
        /// </summary>
        public bvec4 abra => new bvec4(w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.wzxwx swizzling.
        /// </summary>
        public bvec5 wzxwx => new bvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.abrar swizzling (equivalent to bvec4.wzxwx).
        /// </summary>
        public bvec5 abrar => new bvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.wzxwy swizzling.
        /// </summary>
        public bvec5 wzxwy => new bvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.abrag swizzling (equivalent to bvec4.wzxwy).
        /// </summary>
        public bvec5 abrag => new bvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.wzxwz swizzling.
        /// </summary>
        public bvec5 wzxwz => new bvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.abrab swizzling (equivalent to bvec4.wzxwz).
        /// </summary>
        public bvec5 abrab => new bvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.wzxww swizzling.
        /// </summary>
        public bvec5 wzxww => new bvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.abraa swizzling (equivalent to bvec4.wzxww).
        /// </summary>
        public bvec5 abraa => new bvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.wzy swizzling.
        /// </summary>
        public bvec3 wzy => new bvec3(w, z, y);
        
        /// <summary>
        /// Returns bvec4.abg swizzling (equivalent to bvec4.wzy).
        /// </summary>
        public bvec3 abg => new bvec3(w, z, y);
        
        /// <summary>
        /// Returns bvec4.wzyx swizzling.
        /// </summary>
        public bvec4 wzyx => new bvec4(w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.abgr swizzling (equivalent to bvec4.wzyx).
        /// </summary>
        public bvec4 abgr => new bvec4(w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.wzyxx swizzling.
        /// </summary>
        public bvec5 wzyxx => new bvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.abgrr swizzling (equivalent to bvec4.wzyxx).
        /// </summary>
        public bvec5 abgrr => new bvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.wzyxy swizzling.
        /// </summary>
        public bvec5 wzyxy => new bvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.abgrg swizzling (equivalent to bvec4.wzyxy).
        /// </summary>
        public bvec5 abgrg => new bvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.wzyxz swizzling.
        /// </summary>
        public bvec5 wzyxz => new bvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.abgrb swizzling (equivalent to bvec4.wzyxz).
        /// </summary>
        public bvec5 abgrb => new bvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.wzyxw swizzling.
        /// </summary>
        public bvec5 wzyxw => new bvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.abgra swizzling (equivalent to bvec4.wzyxw).
        /// </summary>
        public bvec5 abgra => new bvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.wzyy swizzling.
        /// </summary>
        public bvec4 wzyy => new bvec4(w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.abgg swizzling (equivalent to bvec4.wzyy).
        /// </summary>
        public bvec4 abgg => new bvec4(w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.wzyyx swizzling.
        /// </summary>
        public bvec5 wzyyx => new bvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.abggr swizzling (equivalent to bvec4.wzyyx).
        /// </summary>
        public bvec5 abggr => new bvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.wzyyy swizzling.
        /// </summary>
        public bvec5 wzyyy => new bvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.abggg swizzling (equivalent to bvec4.wzyyy).
        /// </summary>
        public bvec5 abggg => new bvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.wzyyz swizzling.
        /// </summary>
        public bvec5 wzyyz => new bvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.abggb swizzling (equivalent to bvec4.wzyyz).
        /// </summary>
        public bvec5 abggb => new bvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.wzyyw swizzling.
        /// </summary>
        public bvec5 wzyyw => new bvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.abgga swizzling (equivalent to bvec4.wzyyw).
        /// </summary>
        public bvec5 abgga => new bvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.wzyz swizzling.
        /// </summary>
        public bvec4 wzyz => new bvec4(w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.abgb swizzling (equivalent to bvec4.wzyz).
        /// </summary>
        public bvec4 abgb => new bvec4(w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.wzyzx swizzling.
        /// </summary>
        public bvec5 wzyzx => new bvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.abgbr swizzling (equivalent to bvec4.wzyzx).
        /// </summary>
        public bvec5 abgbr => new bvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.wzyzy swizzling.
        /// </summary>
        public bvec5 wzyzy => new bvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.abgbg swizzling (equivalent to bvec4.wzyzy).
        /// </summary>
        public bvec5 abgbg => new bvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.wzyzz swizzling.
        /// </summary>
        public bvec5 wzyzz => new bvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.abgbb swizzling (equivalent to bvec4.wzyzz).
        /// </summary>
        public bvec5 abgbb => new bvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.wzyzw swizzling.
        /// </summary>
        public bvec5 wzyzw => new bvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.abgba swizzling (equivalent to bvec4.wzyzw).
        /// </summary>
        public bvec5 abgba => new bvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.wzyw swizzling.
        /// </summary>
        public bvec4 wzyw => new bvec4(w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.abga swizzling (equivalent to bvec4.wzyw).
        /// </summary>
        public bvec4 abga => new bvec4(w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.wzywx swizzling.
        /// </summary>
        public bvec5 wzywx => new bvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.abgar swizzling (equivalent to bvec4.wzywx).
        /// </summary>
        public bvec5 abgar => new bvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.wzywy swizzling.
        /// </summary>
        public bvec5 wzywy => new bvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.abgag swizzling (equivalent to bvec4.wzywy).
        /// </summary>
        public bvec5 abgag => new bvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.wzywz swizzling.
        /// </summary>
        public bvec5 wzywz => new bvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.abgab swizzling (equivalent to bvec4.wzywz).
        /// </summary>
        public bvec5 abgab => new bvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.wzyww swizzling.
        /// </summary>
        public bvec5 wzyww => new bvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.abgaa swizzling (equivalent to bvec4.wzyww).
        /// </summary>
        public bvec5 abgaa => new bvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.wzz swizzling.
        /// </summary>
        public bvec3 wzz => new bvec3(w, z, z);
        
        /// <summary>
        /// Returns bvec4.abb swizzling (equivalent to bvec4.wzz).
        /// </summary>
        public bvec3 abb => new bvec3(w, z, z);
        
        /// <summary>
        /// Returns bvec4.wzzx swizzling.
        /// </summary>
        public bvec4 wzzx => new bvec4(w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.abbr swizzling (equivalent to bvec4.wzzx).
        /// </summary>
        public bvec4 abbr => new bvec4(w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.wzzxx swizzling.
        /// </summary>
        public bvec5 wzzxx => new bvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.abbrr swizzling (equivalent to bvec4.wzzxx).
        /// </summary>
        public bvec5 abbrr => new bvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.wzzxy swizzling.
        /// </summary>
        public bvec5 wzzxy => new bvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.abbrg swizzling (equivalent to bvec4.wzzxy).
        /// </summary>
        public bvec5 abbrg => new bvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.wzzxz swizzling.
        /// </summary>
        public bvec5 wzzxz => new bvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.abbrb swizzling (equivalent to bvec4.wzzxz).
        /// </summary>
        public bvec5 abbrb => new bvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.wzzxw swizzling.
        /// </summary>
        public bvec5 wzzxw => new bvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.abbra swizzling (equivalent to bvec4.wzzxw).
        /// </summary>
        public bvec5 abbra => new bvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.wzzy swizzling.
        /// </summary>
        public bvec4 wzzy => new bvec4(w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.abbg swizzling (equivalent to bvec4.wzzy).
        /// </summary>
        public bvec4 abbg => new bvec4(w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.wzzyx swizzling.
        /// </summary>
        public bvec5 wzzyx => new bvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.abbgr swizzling (equivalent to bvec4.wzzyx).
        /// </summary>
        public bvec5 abbgr => new bvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.wzzyy swizzling.
        /// </summary>
        public bvec5 wzzyy => new bvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.abbgg swizzling (equivalent to bvec4.wzzyy).
        /// </summary>
        public bvec5 abbgg => new bvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.wzzyz swizzling.
        /// </summary>
        public bvec5 wzzyz => new bvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.abbgb swizzling (equivalent to bvec4.wzzyz).
        /// </summary>
        public bvec5 abbgb => new bvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.wzzyw swizzling.
        /// </summary>
        public bvec5 wzzyw => new bvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.abbga swizzling (equivalent to bvec4.wzzyw).
        /// </summary>
        public bvec5 abbga => new bvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.wzzz swizzling.
        /// </summary>
        public bvec4 wzzz => new bvec4(w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.abbb swizzling (equivalent to bvec4.wzzz).
        /// </summary>
        public bvec4 abbb => new bvec4(w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.wzzzx swizzling.
        /// </summary>
        public bvec5 wzzzx => new bvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.abbbr swizzling (equivalent to bvec4.wzzzx).
        /// </summary>
        public bvec5 abbbr => new bvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.wzzzy swizzling.
        /// </summary>
        public bvec5 wzzzy => new bvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.abbbg swizzling (equivalent to bvec4.wzzzy).
        /// </summary>
        public bvec5 abbbg => new bvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.wzzzz swizzling.
        /// </summary>
        public bvec5 wzzzz => new bvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.abbbb swizzling (equivalent to bvec4.wzzzz).
        /// </summary>
        public bvec5 abbbb => new bvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.wzzzw swizzling.
        /// </summary>
        public bvec5 wzzzw => new bvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.abbba swizzling (equivalent to bvec4.wzzzw).
        /// </summary>
        public bvec5 abbba => new bvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.wzzw swizzling.
        /// </summary>
        public bvec4 wzzw => new bvec4(w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.abba swizzling (equivalent to bvec4.wzzw).
        /// </summary>
        public bvec4 abba => new bvec4(w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.wzzwx swizzling.
        /// </summary>
        public bvec5 wzzwx => new bvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.abbar swizzling (equivalent to bvec4.wzzwx).
        /// </summary>
        public bvec5 abbar => new bvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.wzzwy swizzling.
        /// </summary>
        public bvec5 wzzwy => new bvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.abbag swizzling (equivalent to bvec4.wzzwy).
        /// </summary>
        public bvec5 abbag => new bvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.wzzwz swizzling.
        /// </summary>
        public bvec5 wzzwz => new bvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.abbab swizzling (equivalent to bvec4.wzzwz).
        /// </summary>
        public bvec5 abbab => new bvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.wzzww swizzling.
        /// </summary>
        public bvec5 wzzww => new bvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.abbaa swizzling (equivalent to bvec4.wzzww).
        /// </summary>
        public bvec5 abbaa => new bvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.wzw swizzling.
        /// </summary>
        public bvec3 wzw => new bvec3(w, z, w);
        
        /// <summary>
        /// Returns bvec4.aba swizzling (equivalent to bvec4.wzw).
        /// </summary>
        public bvec3 aba => new bvec3(w, z, w);
        
        /// <summary>
        /// Returns bvec4.wzwx swizzling.
        /// </summary>
        public bvec4 wzwx => new bvec4(w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.abar swizzling (equivalent to bvec4.wzwx).
        /// </summary>
        public bvec4 abar => new bvec4(w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.wzwxx swizzling.
        /// </summary>
        public bvec5 wzwxx => new bvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.abarr swizzling (equivalent to bvec4.wzwxx).
        /// </summary>
        public bvec5 abarr => new bvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.wzwxy swizzling.
        /// </summary>
        public bvec5 wzwxy => new bvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.abarg swizzling (equivalent to bvec4.wzwxy).
        /// </summary>
        public bvec5 abarg => new bvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.wzwxz swizzling.
        /// </summary>
        public bvec5 wzwxz => new bvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.abarb swizzling (equivalent to bvec4.wzwxz).
        /// </summary>
        public bvec5 abarb => new bvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.wzwxw swizzling.
        /// </summary>
        public bvec5 wzwxw => new bvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.abara swizzling (equivalent to bvec4.wzwxw).
        /// </summary>
        public bvec5 abara => new bvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.wzwy swizzling.
        /// </summary>
        public bvec4 wzwy => new bvec4(w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.abag swizzling (equivalent to bvec4.wzwy).
        /// </summary>
        public bvec4 abag => new bvec4(w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.wzwyx swizzling.
        /// </summary>
        public bvec5 wzwyx => new bvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.abagr swizzling (equivalent to bvec4.wzwyx).
        /// </summary>
        public bvec5 abagr => new bvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.wzwyy swizzling.
        /// </summary>
        public bvec5 wzwyy => new bvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.abagg swizzling (equivalent to bvec4.wzwyy).
        /// </summary>
        public bvec5 abagg => new bvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.wzwyz swizzling.
        /// </summary>
        public bvec5 wzwyz => new bvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.abagb swizzling (equivalent to bvec4.wzwyz).
        /// </summary>
        public bvec5 abagb => new bvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.wzwyw swizzling.
        /// </summary>
        public bvec5 wzwyw => new bvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.abaga swizzling (equivalent to bvec4.wzwyw).
        /// </summary>
        public bvec5 abaga => new bvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.wzwz swizzling.
        /// </summary>
        public bvec4 wzwz => new bvec4(w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.abab swizzling (equivalent to bvec4.wzwz).
        /// </summary>
        public bvec4 abab => new bvec4(w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.wzwzx swizzling.
        /// </summary>
        public bvec5 wzwzx => new bvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.ababr swizzling (equivalent to bvec4.wzwzx).
        /// </summary>
        public bvec5 ababr => new bvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.wzwzy swizzling.
        /// </summary>
        public bvec5 wzwzy => new bvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.ababg swizzling (equivalent to bvec4.wzwzy).
        /// </summary>
        public bvec5 ababg => new bvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.wzwzz swizzling.
        /// </summary>
        public bvec5 wzwzz => new bvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.ababb swizzling (equivalent to bvec4.wzwzz).
        /// </summary>
        public bvec5 ababb => new bvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.wzwzw swizzling.
        /// </summary>
        public bvec5 wzwzw => new bvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.ababa swizzling (equivalent to bvec4.wzwzw).
        /// </summary>
        public bvec5 ababa => new bvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.wzww swizzling.
        /// </summary>
        public bvec4 wzww => new bvec4(w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.abaa swizzling (equivalent to bvec4.wzww).
        /// </summary>
        public bvec4 abaa => new bvec4(w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.wzwwx swizzling.
        /// </summary>
        public bvec5 wzwwx => new bvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.abaar swizzling (equivalent to bvec4.wzwwx).
        /// </summary>
        public bvec5 abaar => new bvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.wzwwy swizzling.
        /// </summary>
        public bvec5 wzwwy => new bvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.abaag swizzling (equivalent to bvec4.wzwwy).
        /// </summary>
        public bvec5 abaag => new bvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.wzwwz swizzling.
        /// </summary>
        public bvec5 wzwwz => new bvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.abaab swizzling (equivalent to bvec4.wzwwz).
        /// </summary>
        public bvec5 abaab => new bvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.wzwww swizzling.
        /// </summary>
        public bvec5 wzwww => new bvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.abaaa swizzling (equivalent to bvec4.wzwww).
        /// </summary>
        public bvec5 abaaa => new bvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.ww swizzling.
        /// </summary>
        public bvec2 ww => new bvec2(w, w);
        
        /// <summary>
        /// Returns bvec4.aa swizzling (equivalent to bvec4.ww).
        /// </summary>
        public bvec2 aa => new bvec2(w, w);
        
        /// <summary>
        /// Returns bvec4.wwx swizzling.
        /// </summary>
        public bvec3 wwx => new bvec3(w, w, x);
        
        /// <summary>
        /// Returns bvec4.aar swizzling (equivalent to bvec4.wwx).
        /// </summary>
        public bvec3 aar => new bvec3(w, w, x);
        
        /// <summary>
        /// Returns bvec4.wwxx swizzling.
        /// </summary>
        public bvec4 wwxx => new bvec4(w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.aarr swizzling (equivalent to bvec4.wwxx).
        /// </summary>
        public bvec4 aarr => new bvec4(w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.wwxxx swizzling.
        /// </summary>
        public bvec5 wwxxx => new bvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.aarrr swizzling (equivalent to bvec4.wwxxx).
        /// </summary>
        public bvec5 aarrr => new bvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.wwxxy swizzling.
        /// </summary>
        public bvec5 wwxxy => new bvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.aarrg swizzling (equivalent to bvec4.wwxxy).
        /// </summary>
        public bvec5 aarrg => new bvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.wwxxz swizzling.
        /// </summary>
        public bvec5 wwxxz => new bvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.aarrb swizzling (equivalent to bvec4.wwxxz).
        /// </summary>
        public bvec5 aarrb => new bvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.wwxxw swizzling.
        /// </summary>
        public bvec5 wwxxw => new bvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.aarra swizzling (equivalent to bvec4.wwxxw).
        /// </summary>
        public bvec5 aarra => new bvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.wwxy swizzling.
        /// </summary>
        public bvec4 wwxy => new bvec4(w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.aarg swizzling (equivalent to bvec4.wwxy).
        /// </summary>
        public bvec4 aarg => new bvec4(w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.wwxyx swizzling.
        /// </summary>
        public bvec5 wwxyx => new bvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.aargr swizzling (equivalent to bvec4.wwxyx).
        /// </summary>
        public bvec5 aargr => new bvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.wwxyy swizzling.
        /// </summary>
        public bvec5 wwxyy => new bvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.aargg swizzling (equivalent to bvec4.wwxyy).
        /// </summary>
        public bvec5 aargg => new bvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.wwxyz swizzling.
        /// </summary>
        public bvec5 wwxyz => new bvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.aargb swizzling (equivalent to bvec4.wwxyz).
        /// </summary>
        public bvec5 aargb => new bvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.wwxyw swizzling.
        /// </summary>
        public bvec5 wwxyw => new bvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.aarga swizzling (equivalent to bvec4.wwxyw).
        /// </summary>
        public bvec5 aarga => new bvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.wwxz swizzling.
        /// </summary>
        public bvec4 wwxz => new bvec4(w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.aarb swizzling (equivalent to bvec4.wwxz).
        /// </summary>
        public bvec4 aarb => new bvec4(w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.wwxzx swizzling.
        /// </summary>
        public bvec5 wwxzx => new bvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.aarbr swizzling (equivalent to bvec4.wwxzx).
        /// </summary>
        public bvec5 aarbr => new bvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.wwxzy swizzling.
        /// </summary>
        public bvec5 wwxzy => new bvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.aarbg swizzling (equivalent to bvec4.wwxzy).
        /// </summary>
        public bvec5 aarbg => new bvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.wwxzz swizzling.
        /// </summary>
        public bvec5 wwxzz => new bvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.aarbb swizzling (equivalent to bvec4.wwxzz).
        /// </summary>
        public bvec5 aarbb => new bvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.wwxzw swizzling.
        /// </summary>
        public bvec5 wwxzw => new bvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.aarba swizzling (equivalent to bvec4.wwxzw).
        /// </summary>
        public bvec5 aarba => new bvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.wwxw swizzling.
        /// </summary>
        public bvec4 wwxw => new bvec4(w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.aara swizzling (equivalent to bvec4.wwxw).
        /// </summary>
        public bvec4 aara => new bvec4(w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.wwxwx swizzling.
        /// </summary>
        public bvec5 wwxwx => new bvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.aarar swizzling (equivalent to bvec4.wwxwx).
        /// </summary>
        public bvec5 aarar => new bvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.wwxwy swizzling.
        /// </summary>
        public bvec5 wwxwy => new bvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.aarag swizzling (equivalent to bvec4.wwxwy).
        /// </summary>
        public bvec5 aarag => new bvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.wwxwz swizzling.
        /// </summary>
        public bvec5 wwxwz => new bvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.aarab swizzling (equivalent to bvec4.wwxwz).
        /// </summary>
        public bvec5 aarab => new bvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.wwxww swizzling.
        /// </summary>
        public bvec5 wwxww => new bvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.aaraa swizzling (equivalent to bvec4.wwxww).
        /// </summary>
        public bvec5 aaraa => new bvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.wwy swizzling.
        /// </summary>
        public bvec3 wwy => new bvec3(w, w, y);
        
        /// <summary>
        /// Returns bvec4.aag swizzling (equivalent to bvec4.wwy).
        /// </summary>
        public bvec3 aag => new bvec3(w, w, y);
        
        /// <summary>
        /// Returns bvec4.wwyx swizzling.
        /// </summary>
        public bvec4 wwyx => new bvec4(w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.aagr swizzling (equivalent to bvec4.wwyx).
        /// </summary>
        public bvec4 aagr => new bvec4(w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.wwyxx swizzling.
        /// </summary>
        public bvec5 wwyxx => new bvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.aagrr swizzling (equivalent to bvec4.wwyxx).
        /// </summary>
        public bvec5 aagrr => new bvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.wwyxy swizzling.
        /// </summary>
        public bvec5 wwyxy => new bvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.aagrg swizzling (equivalent to bvec4.wwyxy).
        /// </summary>
        public bvec5 aagrg => new bvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.wwyxz swizzling.
        /// </summary>
        public bvec5 wwyxz => new bvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.aagrb swizzling (equivalent to bvec4.wwyxz).
        /// </summary>
        public bvec5 aagrb => new bvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.wwyxw swizzling.
        /// </summary>
        public bvec5 wwyxw => new bvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.aagra swizzling (equivalent to bvec4.wwyxw).
        /// </summary>
        public bvec5 aagra => new bvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.wwyy swizzling.
        /// </summary>
        public bvec4 wwyy => new bvec4(w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.aagg swizzling (equivalent to bvec4.wwyy).
        /// </summary>
        public bvec4 aagg => new bvec4(w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.wwyyx swizzling.
        /// </summary>
        public bvec5 wwyyx => new bvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.aaggr swizzling (equivalent to bvec4.wwyyx).
        /// </summary>
        public bvec5 aaggr => new bvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.wwyyy swizzling.
        /// </summary>
        public bvec5 wwyyy => new bvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.aaggg swizzling (equivalent to bvec4.wwyyy).
        /// </summary>
        public bvec5 aaggg => new bvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.wwyyz swizzling.
        /// </summary>
        public bvec5 wwyyz => new bvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.aaggb swizzling (equivalent to bvec4.wwyyz).
        /// </summary>
        public bvec5 aaggb => new bvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.wwyyw swizzling.
        /// </summary>
        public bvec5 wwyyw => new bvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.aagga swizzling (equivalent to bvec4.wwyyw).
        /// </summary>
        public bvec5 aagga => new bvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.wwyz swizzling.
        /// </summary>
        public bvec4 wwyz => new bvec4(w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.aagb swizzling (equivalent to bvec4.wwyz).
        /// </summary>
        public bvec4 aagb => new bvec4(w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.wwyzx swizzling.
        /// </summary>
        public bvec5 wwyzx => new bvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.aagbr swizzling (equivalent to bvec4.wwyzx).
        /// </summary>
        public bvec5 aagbr => new bvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.wwyzy swizzling.
        /// </summary>
        public bvec5 wwyzy => new bvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.aagbg swizzling (equivalent to bvec4.wwyzy).
        /// </summary>
        public bvec5 aagbg => new bvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.wwyzz swizzling.
        /// </summary>
        public bvec5 wwyzz => new bvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.aagbb swizzling (equivalent to bvec4.wwyzz).
        /// </summary>
        public bvec5 aagbb => new bvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.wwyzw swizzling.
        /// </summary>
        public bvec5 wwyzw => new bvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.aagba swizzling (equivalent to bvec4.wwyzw).
        /// </summary>
        public bvec5 aagba => new bvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.wwyw swizzling.
        /// </summary>
        public bvec4 wwyw => new bvec4(w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.aaga swizzling (equivalent to bvec4.wwyw).
        /// </summary>
        public bvec4 aaga => new bvec4(w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.wwywx swizzling.
        /// </summary>
        public bvec5 wwywx => new bvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.aagar swizzling (equivalent to bvec4.wwywx).
        /// </summary>
        public bvec5 aagar => new bvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.wwywy swizzling.
        /// </summary>
        public bvec5 wwywy => new bvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.aagag swizzling (equivalent to bvec4.wwywy).
        /// </summary>
        public bvec5 aagag => new bvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.wwywz swizzling.
        /// </summary>
        public bvec5 wwywz => new bvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.aagab swizzling (equivalent to bvec4.wwywz).
        /// </summary>
        public bvec5 aagab => new bvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.wwyww swizzling.
        /// </summary>
        public bvec5 wwyww => new bvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.aagaa swizzling (equivalent to bvec4.wwyww).
        /// </summary>
        public bvec5 aagaa => new bvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.wwz swizzling.
        /// </summary>
        public bvec3 wwz => new bvec3(w, w, z);
        
        /// <summary>
        /// Returns bvec4.aab swizzling (equivalent to bvec4.wwz).
        /// </summary>
        public bvec3 aab => new bvec3(w, w, z);
        
        /// <summary>
        /// Returns bvec4.wwzx swizzling.
        /// </summary>
        public bvec4 wwzx => new bvec4(w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.aabr swizzling (equivalent to bvec4.wwzx).
        /// </summary>
        public bvec4 aabr => new bvec4(w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.wwzxx swizzling.
        /// </summary>
        public bvec5 wwzxx => new bvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.aabrr swizzling (equivalent to bvec4.wwzxx).
        /// </summary>
        public bvec5 aabrr => new bvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.wwzxy swizzling.
        /// </summary>
        public bvec5 wwzxy => new bvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.aabrg swizzling (equivalent to bvec4.wwzxy).
        /// </summary>
        public bvec5 aabrg => new bvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.wwzxz swizzling.
        /// </summary>
        public bvec5 wwzxz => new bvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.aabrb swizzling (equivalent to bvec4.wwzxz).
        /// </summary>
        public bvec5 aabrb => new bvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.wwzxw swizzling.
        /// </summary>
        public bvec5 wwzxw => new bvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.aabra swizzling (equivalent to bvec4.wwzxw).
        /// </summary>
        public bvec5 aabra => new bvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.wwzy swizzling.
        /// </summary>
        public bvec4 wwzy => new bvec4(w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.aabg swizzling (equivalent to bvec4.wwzy).
        /// </summary>
        public bvec4 aabg => new bvec4(w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.wwzyx swizzling.
        /// </summary>
        public bvec5 wwzyx => new bvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.aabgr swizzling (equivalent to bvec4.wwzyx).
        /// </summary>
        public bvec5 aabgr => new bvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.wwzyy swizzling.
        /// </summary>
        public bvec5 wwzyy => new bvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.aabgg swizzling (equivalent to bvec4.wwzyy).
        /// </summary>
        public bvec5 aabgg => new bvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.wwzyz swizzling.
        /// </summary>
        public bvec5 wwzyz => new bvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.aabgb swizzling (equivalent to bvec4.wwzyz).
        /// </summary>
        public bvec5 aabgb => new bvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.wwzyw swizzling.
        /// </summary>
        public bvec5 wwzyw => new bvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.aabga swizzling (equivalent to bvec4.wwzyw).
        /// </summary>
        public bvec5 aabga => new bvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.wwzz swizzling.
        /// </summary>
        public bvec4 wwzz => new bvec4(w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.aabb swizzling (equivalent to bvec4.wwzz).
        /// </summary>
        public bvec4 aabb => new bvec4(w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.wwzzx swizzling.
        /// </summary>
        public bvec5 wwzzx => new bvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.aabbr swizzling (equivalent to bvec4.wwzzx).
        /// </summary>
        public bvec5 aabbr => new bvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.wwzzy swizzling.
        /// </summary>
        public bvec5 wwzzy => new bvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.aabbg swizzling (equivalent to bvec4.wwzzy).
        /// </summary>
        public bvec5 aabbg => new bvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.wwzzz swizzling.
        /// </summary>
        public bvec5 wwzzz => new bvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.aabbb swizzling (equivalent to bvec4.wwzzz).
        /// </summary>
        public bvec5 aabbb => new bvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.wwzzw swizzling.
        /// </summary>
        public bvec5 wwzzw => new bvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.aabba swizzling (equivalent to bvec4.wwzzw).
        /// </summary>
        public bvec5 aabba => new bvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.wwzw swizzling.
        /// </summary>
        public bvec4 wwzw => new bvec4(w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.aaba swizzling (equivalent to bvec4.wwzw).
        /// </summary>
        public bvec4 aaba => new bvec4(w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.wwzwx swizzling.
        /// </summary>
        public bvec5 wwzwx => new bvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.aabar swizzling (equivalent to bvec4.wwzwx).
        /// </summary>
        public bvec5 aabar => new bvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.wwzwy swizzling.
        /// </summary>
        public bvec5 wwzwy => new bvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.aabag swizzling (equivalent to bvec4.wwzwy).
        /// </summary>
        public bvec5 aabag => new bvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.wwzwz swizzling.
        /// </summary>
        public bvec5 wwzwz => new bvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.aabab swizzling (equivalent to bvec4.wwzwz).
        /// </summary>
        public bvec5 aabab => new bvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.wwzww swizzling.
        /// </summary>
        public bvec5 wwzww => new bvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.aabaa swizzling (equivalent to bvec4.wwzww).
        /// </summary>
        public bvec5 aabaa => new bvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.www swizzling.
        /// </summary>
        public bvec3 www => new bvec3(w, w, w);
        
        /// <summary>
        /// Returns bvec4.aaa swizzling (equivalent to bvec4.www).
        /// </summary>
        public bvec3 aaa => new bvec3(w, w, w);
        
        /// <summary>
        /// Returns bvec4.wwwx swizzling.
        /// </summary>
        public bvec4 wwwx => new bvec4(w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.aaar swizzling (equivalent to bvec4.wwwx).
        /// </summary>
        public bvec4 aaar => new bvec4(w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.wwwxx swizzling.
        /// </summary>
        public bvec5 wwwxx => new bvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.aaarr swizzling (equivalent to bvec4.wwwxx).
        /// </summary>
        public bvec5 aaarr => new bvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.wwwxy swizzling.
        /// </summary>
        public bvec5 wwwxy => new bvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.aaarg swizzling (equivalent to bvec4.wwwxy).
        /// </summary>
        public bvec5 aaarg => new bvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.wwwxz swizzling.
        /// </summary>
        public bvec5 wwwxz => new bvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.aaarb swizzling (equivalent to bvec4.wwwxz).
        /// </summary>
        public bvec5 aaarb => new bvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.wwwxw swizzling.
        /// </summary>
        public bvec5 wwwxw => new bvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.aaara swizzling (equivalent to bvec4.wwwxw).
        /// </summary>
        public bvec5 aaara => new bvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.wwwy swizzling.
        /// </summary>
        public bvec4 wwwy => new bvec4(w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.aaag swizzling (equivalent to bvec4.wwwy).
        /// </summary>
        public bvec4 aaag => new bvec4(w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.wwwyx swizzling.
        /// </summary>
        public bvec5 wwwyx => new bvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.aaagr swizzling (equivalent to bvec4.wwwyx).
        /// </summary>
        public bvec5 aaagr => new bvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.wwwyy swizzling.
        /// </summary>
        public bvec5 wwwyy => new bvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.aaagg swizzling (equivalent to bvec4.wwwyy).
        /// </summary>
        public bvec5 aaagg => new bvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.wwwyz swizzling.
        /// </summary>
        public bvec5 wwwyz => new bvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.aaagb swizzling (equivalent to bvec4.wwwyz).
        /// </summary>
        public bvec5 aaagb => new bvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.wwwyw swizzling.
        /// </summary>
        public bvec5 wwwyw => new bvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.aaaga swizzling (equivalent to bvec4.wwwyw).
        /// </summary>
        public bvec5 aaaga => new bvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.wwwz swizzling.
        /// </summary>
        public bvec4 wwwz => new bvec4(w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.aaab swizzling (equivalent to bvec4.wwwz).
        /// </summary>
        public bvec4 aaab => new bvec4(w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.wwwzx swizzling.
        /// </summary>
        public bvec5 wwwzx => new bvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.aaabr swizzling (equivalent to bvec4.wwwzx).
        /// </summary>
        public bvec5 aaabr => new bvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.wwwzy swizzling.
        /// </summary>
        public bvec5 wwwzy => new bvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.aaabg swizzling (equivalent to bvec4.wwwzy).
        /// </summary>
        public bvec5 aaabg => new bvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.wwwzz swizzling.
        /// </summary>
        public bvec5 wwwzz => new bvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.aaabb swizzling (equivalent to bvec4.wwwzz).
        /// </summary>
        public bvec5 aaabb => new bvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.wwwzw swizzling.
        /// </summary>
        public bvec5 wwwzw => new bvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.aaaba swizzling (equivalent to bvec4.wwwzw).
        /// </summary>
        public bvec5 aaaba => new bvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.wwww swizzling.
        /// </summary>
        public bvec4 wwww => new bvec4(w, w, w, w);
        
        /// <summary>
        /// Returns bvec4.aaaa swizzling (equivalent to bvec4.wwww).
        /// </summary>
        public bvec4 aaaa => new bvec4(w, w, w, w);
        
        /// <summary>
        /// Returns bvec4.wwwwx swizzling.
        /// </summary>
        public bvec5 wwwwx => new bvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.aaaar swizzling (equivalent to bvec4.wwwwx).
        /// </summary>
        public bvec5 aaaar => new bvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.wwwwy swizzling.
        /// </summary>
        public bvec5 wwwwy => new bvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.aaaag swizzling (equivalent to bvec4.wwwwy).
        /// </summary>
        public bvec5 aaaag => new bvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.wwwwz swizzling.
        /// </summary>
        public bvec5 wwwwz => new bvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.aaaab swizzling (equivalent to bvec4.wwwwz).
        /// </summary>
        public bvec5 aaaab => new bvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.wwwww swizzling.
        /// </summary>
        public bvec5 wwwww => new bvec5(w, w, w, w, w);
        
        /// <summary>
        /// Returns bvec4.aaaaa swizzling (equivalent to bvec4.wwwww).
        /// </summary>
        public bvec5 aaaaa => new bvec5(w, w, w, w, w);

        #endregion

    }
}
