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

namespace GlmSharp.Swizzle
{
    
    /// <summary>
    /// Temporary vector of type Complex with 4 components, used for implementing swizzling for cvec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_cvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly Complex x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly Complex y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly Complex z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly Complex w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_cvec4.
        /// </summary>
        internal swizzle_cvec4(Complex x, Complex y, Complex z, Complex w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns cvec4.xx swizzling.
        /// </summary>
        public cvec2 xx => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec4.rr swizzling (equivalent to cvec4.xx).
        /// </summary>
        public cvec2 rr => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec4.xxx swizzling.
        /// </summary>
        public cvec3 xxx => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec4.rrr swizzling (equivalent to cvec4.xxx).
        /// </summary>
        public cvec3 rrr => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec4.xxxx swizzling.
        /// </summary>
        public cvec4 xxxx => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.rrrr swizzling (equivalent to cvec4.xxxx).
        /// </summary>
        public cvec4 rrrr => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.xxxxx swizzling.
        /// </summary>
        public cvec5 xxxxx => new cvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.rrrrr swizzling (equivalent to cvec4.xxxxx).
        /// </summary>
        public cvec5 rrrrr => new cvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.xxxxy swizzling.
        /// </summary>
        public cvec5 xxxxy => new cvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.rrrrg swizzling (equivalent to cvec4.xxxxy).
        /// </summary>
        public cvec5 rrrrg => new cvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.xxxxz swizzling.
        /// </summary>
        public cvec5 xxxxz => new cvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.rrrrb swizzling (equivalent to cvec4.xxxxz).
        /// </summary>
        public cvec5 rrrrb => new cvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.xxxxw swizzling.
        /// </summary>
        public cvec5 xxxxw => new cvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.rrrra swizzling (equivalent to cvec4.xxxxw).
        /// </summary>
        public cvec5 rrrra => new cvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.xxxy swizzling.
        /// </summary>
        public cvec4 xxxy => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.rrrg swizzling (equivalent to cvec4.xxxy).
        /// </summary>
        public cvec4 rrrg => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.xxxyx swizzling.
        /// </summary>
        public cvec5 xxxyx => new cvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.rrrgr swizzling (equivalent to cvec4.xxxyx).
        /// </summary>
        public cvec5 rrrgr => new cvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.xxxyy swizzling.
        /// </summary>
        public cvec5 xxxyy => new cvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.rrrgg swizzling (equivalent to cvec4.xxxyy).
        /// </summary>
        public cvec5 rrrgg => new cvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.xxxyz swizzling.
        /// </summary>
        public cvec5 xxxyz => new cvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.rrrgb swizzling (equivalent to cvec4.xxxyz).
        /// </summary>
        public cvec5 rrrgb => new cvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.xxxyw swizzling.
        /// </summary>
        public cvec5 xxxyw => new cvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.rrrga swizzling (equivalent to cvec4.xxxyw).
        /// </summary>
        public cvec5 rrrga => new cvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.xxxz swizzling.
        /// </summary>
        public cvec4 xxxz => new cvec4(x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.rrrb swizzling (equivalent to cvec4.xxxz).
        /// </summary>
        public cvec4 rrrb => new cvec4(x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.xxxzx swizzling.
        /// </summary>
        public cvec5 xxxzx => new cvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.rrrbr swizzling (equivalent to cvec4.xxxzx).
        /// </summary>
        public cvec5 rrrbr => new cvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.xxxzy swizzling.
        /// </summary>
        public cvec5 xxxzy => new cvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.rrrbg swizzling (equivalent to cvec4.xxxzy).
        /// </summary>
        public cvec5 rrrbg => new cvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.xxxzz swizzling.
        /// </summary>
        public cvec5 xxxzz => new cvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.rrrbb swizzling (equivalent to cvec4.xxxzz).
        /// </summary>
        public cvec5 rrrbb => new cvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.xxxzw swizzling.
        /// </summary>
        public cvec5 xxxzw => new cvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.rrrba swizzling (equivalent to cvec4.xxxzw).
        /// </summary>
        public cvec5 rrrba => new cvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.xxxw swizzling.
        /// </summary>
        public cvec4 xxxw => new cvec4(x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.rrra swizzling (equivalent to cvec4.xxxw).
        /// </summary>
        public cvec4 rrra => new cvec4(x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.xxxwx swizzling.
        /// </summary>
        public cvec5 xxxwx => new cvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.rrrar swizzling (equivalent to cvec4.xxxwx).
        /// </summary>
        public cvec5 rrrar => new cvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.xxxwy swizzling.
        /// </summary>
        public cvec5 xxxwy => new cvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.rrrag swizzling (equivalent to cvec4.xxxwy).
        /// </summary>
        public cvec5 rrrag => new cvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.xxxwz swizzling.
        /// </summary>
        public cvec5 xxxwz => new cvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.rrrab swizzling (equivalent to cvec4.xxxwz).
        /// </summary>
        public cvec5 rrrab => new cvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.xxxww swizzling.
        /// </summary>
        public cvec5 xxxww => new cvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.rrraa swizzling (equivalent to cvec4.xxxww).
        /// </summary>
        public cvec5 rrraa => new cvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.xxy swizzling.
        /// </summary>
        public cvec3 xxy => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec4.rrg swizzling (equivalent to cvec4.xxy).
        /// </summary>
        public cvec3 rrg => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec4.xxyx swizzling.
        /// </summary>
        public cvec4 xxyx => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.rrgr swizzling (equivalent to cvec4.xxyx).
        /// </summary>
        public cvec4 rrgr => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.xxyxx swizzling.
        /// </summary>
        public cvec5 xxyxx => new cvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.rrgrr swizzling (equivalent to cvec4.xxyxx).
        /// </summary>
        public cvec5 rrgrr => new cvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.xxyxy swizzling.
        /// </summary>
        public cvec5 xxyxy => new cvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.rrgrg swizzling (equivalent to cvec4.xxyxy).
        /// </summary>
        public cvec5 rrgrg => new cvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.xxyxz swizzling.
        /// </summary>
        public cvec5 xxyxz => new cvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.rrgrb swizzling (equivalent to cvec4.xxyxz).
        /// </summary>
        public cvec5 rrgrb => new cvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.xxyxw swizzling.
        /// </summary>
        public cvec5 xxyxw => new cvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.rrgra swizzling (equivalent to cvec4.xxyxw).
        /// </summary>
        public cvec5 rrgra => new cvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.xxyy swizzling.
        /// </summary>
        public cvec4 xxyy => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.rrgg swizzling (equivalent to cvec4.xxyy).
        /// </summary>
        public cvec4 rrgg => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.xxyyx swizzling.
        /// </summary>
        public cvec5 xxyyx => new cvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.rrggr swizzling (equivalent to cvec4.xxyyx).
        /// </summary>
        public cvec5 rrggr => new cvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.xxyyy swizzling.
        /// </summary>
        public cvec5 xxyyy => new cvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.rrggg swizzling (equivalent to cvec4.xxyyy).
        /// </summary>
        public cvec5 rrggg => new cvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.xxyyz swizzling.
        /// </summary>
        public cvec5 xxyyz => new cvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.rrggb swizzling (equivalent to cvec4.xxyyz).
        /// </summary>
        public cvec5 rrggb => new cvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.xxyyw swizzling.
        /// </summary>
        public cvec5 xxyyw => new cvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.rrgga swizzling (equivalent to cvec4.xxyyw).
        /// </summary>
        public cvec5 rrgga => new cvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.xxyz swizzling.
        /// </summary>
        public cvec4 xxyz => new cvec4(x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.rrgb swizzling (equivalent to cvec4.xxyz).
        /// </summary>
        public cvec4 rrgb => new cvec4(x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.xxyzx swizzling.
        /// </summary>
        public cvec5 xxyzx => new cvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.rrgbr swizzling (equivalent to cvec4.xxyzx).
        /// </summary>
        public cvec5 rrgbr => new cvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.xxyzy swizzling.
        /// </summary>
        public cvec5 xxyzy => new cvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.rrgbg swizzling (equivalent to cvec4.xxyzy).
        /// </summary>
        public cvec5 rrgbg => new cvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.xxyzz swizzling.
        /// </summary>
        public cvec5 xxyzz => new cvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.rrgbb swizzling (equivalent to cvec4.xxyzz).
        /// </summary>
        public cvec5 rrgbb => new cvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.xxyzw swizzling.
        /// </summary>
        public cvec5 xxyzw => new cvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.rrgba swizzling (equivalent to cvec4.xxyzw).
        /// </summary>
        public cvec5 rrgba => new cvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.xxyw swizzling.
        /// </summary>
        public cvec4 xxyw => new cvec4(x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.rrga swizzling (equivalent to cvec4.xxyw).
        /// </summary>
        public cvec4 rrga => new cvec4(x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.xxywx swizzling.
        /// </summary>
        public cvec5 xxywx => new cvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.rrgar swizzling (equivalent to cvec4.xxywx).
        /// </summary>
        public cvec5 rrgar => new cvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.xxywy swizzling.
        /// </summary>
        public cvec5 xxywy => new cvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.rrgag swizzling (equivalent to cvec4.xxywy).
        /// </summary>
        public cvec5 rrgag => new cvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.xxywz swizzling.
        /// </summary>
        public cvec5 xxywz => new cvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.rrgab swizzling (equivalent to cvec4.xxywz).
        /// </summary>
        public cvec5 rrgab => new cvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.xxyww swizzling.
        /// </summary>
        public cvec5 xxyww => new cvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.rrgaa swizzling (equivalent to cvec4.xxyww).
        /// </summary>
        public cvec5 rrgaa => new cvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.xxz swizzling.
        /// </summary>
        public cvec3 xxz => new cvec3(x, x, z);
        
        /// <summary>
        /// Returns cvec4.rrb swizzling (equivalent to cvec4.xxz).
        /// </summary>
        public cvec3 rrb => new cvec3(x, x, z);
        
        /// <summary>
        /// Returns cvec4.xxzx swizzling.
        /// </summary>
        public cvec4 xxzx => new cvec4(x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.rrbr swizzling (equivalent to cvec4.xxzx).
        /// </summary>
        public cvec4 rrbr => new cvec4(x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.xxzxx swizzling.
        /// </summary>
        public cvec5 xxzxx => new cvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.rrbrr swizzling (equivalent to cvec4.xxzxx).
        /// </summary>
        public cvec5 rrbrr => new cvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.xxzxy swizzling.
        /// </summary>
        public cvec5 xxzxy => new cvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.rrbrg swizzling (equivalent to cvec4.xxzxy).
        /// </summary>
        public cvec5 rrbrg => new cvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.xxzxz swizzling.
        /// </summary>
        public cvec5 xxzxz => new cvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.rrbrb swizzling (equivalent to cvec4.xxzxz).
        /// </summary>
        public cvec5 rrbrb => new cvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.xxzxw swizzling.
        /// </summary>
        public cvec5 xxzxw => new cvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.rrbra swizzling (equivalent to cvec4.xxzxw).
        /// </summary>
        public cvec5 rrbra => new cvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.xxzy swizzling.
        /// </summary>
        public cvec4 xxzy => new cvec4(x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.rrbg swizzling (equivalent to cvec4.xxzy).
        /// </summary>
        public cvec4 rrbg => new cvec4(x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.xxzyx swizzling.
        /// </summary>
        public cvec5 xxzyx => new cvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.rrbgr swizzling (equivalent to cvec4.xxzyx).
        /// </summary>
        public cvec5 rrbgr => new cvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.xxzyy swizzling.
        /// </summary>
        public cvec5 xxzyy => new cvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.rrbgg swizzling (equivalent to cvec4.xxzyy).
        /// </summary>
        public cvec5 rrbgg => new cvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.xxzyz swizzling.
        /// </summary>
        public cvec5 xxzyz => new cvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.rrbgb swizzling (equivalent to cvec4.xxzyz).
        /// </summary>
        public cvec5 rrbgb => new cvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.xxzyw swizzling.
        /// </summary>
        public cvec5 xxzyw => new cvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.rrbga swizzling (equivalent to cvec4.xxzyw).
        /// </summary>
        public cvec5 rrbga => new cvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.xxzz swizzling.
        /// </summary>
        public cvec4 xxzz => new cvec4(x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.rrbb swizzling (equivalent to cvec4.xxzz).
        /// </summary>
        public cvec4 rrbb => new cvec4(x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.xxzzx swizzling.
        /// </summary>
        public cvec5 xxzzx => new cvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.rrbbr swizzling (equivalent to cvec4.xxzzx).
        /// </summary>
        public cvec5 rrbbr => new cvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.xxzzy swizzling.
        /// </summary>
        public cvec5 xxzzy => new cvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.rrbbg swizzling (equivalent to cvec4.xxzzy).
        /// </summary>
        public cvec5 rrbbg => new cvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.xxzzz swizzling.
        /// </summary>
        public cvec5 xxzzz => new cvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.rrbbb swizzling (equivalent to cvec4.xxzzz).
        /// </summary>
        public cvec5 rrbbb => new cvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.xxzzw swizzling.
        /// </summary>
        public cvec5 xxzzw => new cvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.rrbba swizzling (equivalent to cvec4.xxzzw).
        /// </summary>
        public cvec5 rrbba => new cvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.xxzw swizzling.
        /// </summary>
        public cvec4 xxzw => new cvec4(x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.rrba swizzling (equivalent to cvec4.xxzw).
        /// </summary>
        public cvec4 rrba => new cvec4(x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.xxzwx swizzling.
        /// </summary>
        public cvec5 xxzwx => new cvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.rrbar swizzling (equivalent to cvec4.xxzwx).
        /// </summary>
        public cvec5 rrbar => new cvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.xxzwy swizzling.
        /// </summary>
        public cvec5 xxzwy => new cvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.rrbag swizzling (equivalent to cvec4.xxzwy).
        /// </summary>
        public cvec5 rrbag => new cvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.xxzwz swizzling.
        /// </summary>
        public cvec5 xxzwz => new cvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.rrbab swizzling (equivalent to cvec4.xxzwz).
        /// </summary>
        public cvec5 rrbab => new cvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.xxzww swizzling.
        /// </summary>
        public cvec5 xxzww => new cvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.rrbaa swizzling (equivalent to cvec4.xxzww).
        /// </summary>
        public cvec5 rrbaa => new cvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.xxw swizzling.
        /// </summary>
        public cvec3 xxw => new cvec3(x, x, w);
        
        /// <summary>
        /// Returns cvec4.rra swizzling (equivalent to cvec4.xxw).
        /// </summary>
        public cvec3 rra => new cvec3(x, x, w);
        
        /// <summary>
        /// Returns cvec4.xxwx swizzling.
        /// </summary>
        public cvec4 xxwx => new cvec4(x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.rrar swizzling (equivalent to cvec4.xxwx).
        /// </summary>
        public cvec4 rrar => new cvec4(x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.xxwxx swizzling.
        /// </summary>
        public cvec5 xxwxx => new cvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.rrarr swizzling (equivalent to cvec4.xxwxx).
        /// </summary>
        public cvec5 rrarr => new cvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.xxwxy swizzling.
        /// </summary>
        public cvec5 xxwxy => new cvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.rrarg swizzling (equivalent to cvec4.xxwxy).
        /// </summary>
        public cvec5 rrarg => new cvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.xxwxz swizzling.
        /// </summary>
        public cvec5 xxwxz => new cvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.rrarb swizzling (equivalent to cvec4.xxwxz).
        /// </summary>
        public cvec5 rrarb => new cvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.xxwxw swizzling.
        /// </summary>
        public cvec5 xxwxw => new cvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.rrara swizzling (equivalent to cvec4.xxwxw).
        /// </summary>
        public cvec5 rrara => new cvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.xxwy swizzling.
        /// </summary>
        public cvec4 xxwy => new cvec4(x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.rrag swizzling (equivalent to cvec4.xxwy).
        /// </summary>
        public cvec4 rrag => new cvec4(x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.xxwyx swizzling.
        /// </summary>
        public cvec5 xxwyx => new cvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.rragr swizzling (equivalent to cvec4.xxwyx).
        /// </summary>
        public cvec5 rragr => new cvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.xxwyy swizzling.
        /// </summary>
        public cvec5 xxwyy => new cvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.rragg swizzling (equivalent to cvec4.xxwyy).
        /// </summary>
        public cvec5 rragg => new cvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.xxwyz swizzling.
        /// </summary>
        public cvec5 xxwyz => new cvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.rragb swizzling (equivalent to cvec4.xxwyz).
        /// </summary>
        public cvec5 rragb => new cvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.xxwyw swizzling.
        /// </summary>
        public cvec5 xxwyw => new cvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.rraga swizzling (equivalent to cvec4.xxwyw).
        /// </summary>
        public cvec5 rraga => new cvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.xxwz swizzling.
        /// </summary>
        public cvec4 xxwz => new cvec4(x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.rrab swizzling (equivalent to cvec4.xxwz).
        /// </summary>
        public cvec4 rrab => new cvec4(x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.xxwzx swizzling.
        /// </summary>
        public cvec5 xxwzx => new cvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.rrabr swizzling (equivalent to cvec4.xxwzx).
        /// </summary>
        public cvec5 rrabr => new cvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.xxwzy swizzling.
        /// </summary>
        public cvec5 xxwzy => new cvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.rrabg swizzling (equivalent to cvec4.xxwzy).
        /// </summary>
        public cvec5 rrabg => new cvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.xxwzz swizzling.
        /// </summary>
        public cvec5 xxwzz => new cvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.rrabb swizzling (equivalent to cvec4.xxwzz).
        /// </summary>
        public cvec5 rrabb => new cvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.xxwzw swizzling.
        /// </summary>
        public cvec5 xxwzw => new cvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.rraba swizzling (equivalent to cvec4.xxwzw).
        /// </summary>
        public cvec5 rraba => new cvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.xxww swizzling.
        /// </summary>
        public cvec4 xxww => new cvec4(x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.rraa swizzling (equivalent to cvec4.xxww).
        /// </summary>
        public cvec4 rraa => new cvec4(x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.xxwwx swizzling.
        /// </summary>
        public cvec5 xxwwx => new cvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.rraar swizzling (equivalent to cvec4.xxwwx).
        /// </summary>
        public cvec5 rraar => new cvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.xxwwy swizzling.
        /// </summary>
        public cvec5 xxwwy => new cvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.rraag swizzling (equivalent to cvec4.xxwwy).
        /// </summary>
        public cvec5 rraag => new cvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.xxwwz swizzling.
        /// </summary>
        public cvec5 xxwwz => new cvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.rraab swizzling (equivalent to cvec4.xxwwz).
        /// </summary>
        public cvec5 rraab => new cvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.xxwww swizzling.
        /// </summary>
        public cvec5 xxwww => new cvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.rraaa swizzling (equivalent to cvec4.xxwww).
        /// </summary>
        public cvec5 rraaa => new cvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.xy swizzling.
        /// </summary>
        public cvec2 xy => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec4.rg swizzling (equivalent to cvec4.xy).
        /// </summary>
        public cvec2 rg => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec4.xyx swizzling.
        /// </summary>
        public cvec3 xyx => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec4.rgr swizzling (equivalent to cvec4.xyx).
        /// </summary>
        public cvec3 rgr => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec4.xyxx swizzling.
        /// </summary>
        public cvec4 xyxx => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.rgrr swizzling (equivalent to cvec4.xyxx).
        /// </summary>
        public cvec4 rgrr => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.xyxxx swizzling.
        /// </summary>
        public cvec5 xyxxx => new cvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.rgrrr swizzling (equivalent to cvec4.xyxxx).
        /// </summary>
        public cvec5 rgrrr => new cvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.xyxxy swizzling.
        /// </summary>
        public cvec5 xyxxy => new cvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.rgrrg swizzling (equivalent to cvec4.xyxxy).
        /// </summary>
        public cvec5 rgrrg => new cvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.xyxxz swizzling.
        /// </summary>
        public cvec5 xyxxz => new cvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.rgrrb swizzling (equivalent to cvec4.xyxxz).
        /// </summary>
        public cvec5 rgrrb => new cvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.xyxxw swizzling.
        /// </summary>
        public cvec5 xyxxw => new cvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.rgrra swizzling (equivalent to cvec4.xyxxw).
        /// </summary>
        public cvec5 rgrra => new cvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.xyxy swizzling.
        /// </summary>
        public cvec4 xyxy => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.rgrg swizzling (equivalent to cvec4.xyxy).
        /// </summary>
        public cvec4 rgrg => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.xyxyx swizzling.
        /// </summary>
        public cvec5 xyxyx => new cvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.rgrgr swizzling (equivalent to cvec4.xyxyx).
        /// </summary>
        public cvec5 rgrgr => new cvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.xyxyy swizzling.
        /// </summary>
        public cvec5 xyxyy => new cvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.rgrgg swizzling (equivalent to cvec4.xyxyy).
        /// </summary>
        public cvec5 rgrgg => new cvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.xyxyz swizzling.
        /// </summary>
        public cvec5 xyxyz => new cvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.rgrgb swizzling (equivalent to cvec4.xyxyz).
        /// </summary>
        public cvec5 rgrgb => new cvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.xyxyw swizzling.
        /// </summary>
        public cvec5 xyxyw => new cvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.rgrga swizzling (equivalent to cvec4.xyxyw).
        /// </summary>
        public cvec5 rgrga => new cvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.xyxz swizzling.
        /// </summary>
        public cvec4 xyxz => new cvec4(x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.rgrb swizzling (equivalent to cvec4.xyxz).
        /// </summary>
        public cvec4 rgrb => new cvec4(x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.xyxzx swizzling.
        /// </summary>
        public cvec5 xyxzx => new cvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.rgrbr swizzling (equivalent to cvec4.xyxzx).
        /// </summary>
        public cvec5 rgrbr => new cvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.xyxzy swizzling.
        /// </summary>
        public cvec5 xyxzy => new cvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.rgrbg swizzling (equivalent to cvec4.xyxzy).
        /// </summary>
        public cvec5 rgrbg => new cvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.xyxzz swizzling.
        /// </summary>
        public cvec5 xyxzz => new cvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.rgrbb swizzling (equivalent to cvec4.xyxzz).
        /// </summary>
        public cvec5 rgrbb => new cvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.xyxzw swizzling.
        /// </summary>
        public cvec5 xyxzw => new cvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.rgrba swizzling (equivalent to cvec4.xyxzw).
        /// </summary>
        public cvec5 rgrba => new cvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.xyxw swizzling.
        /// </summary>
        public cvec4 xyxw => new cvec4(x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.rgra swizzling (equivalent to cvec4.xyxw).
        /// </summary>
        public cvec4 rgra => new cvec4(x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.xyxwx swizzling.
        /// </summary>
        public cvec5 xyxwx => new cvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.rgrar swizzling (equivalent to cvec4.xyxwx).
        /// </summary>
        public cvec5 rgrar => new cvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.xyxwy swizzling.
        /// </summary>
        public cvec5 xyxwy => new cvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.rgrag swizzling (equivalent to cvec4.xyxwy).
        /// </summary>
        public cvec5 rgrag => new cvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.xyxwz swizzling.
        /// </summary>
        public cvec5 xyxwz => new cvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.rgrab swizzling (equivalent to cvec4.xyxwz).
        /// </summary>
        public cvec5 rgrab => new cvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.xyxww swizzling.
        /// </summary>
        public cvec5 xyxww => new cvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.rgraa swizzling (equivalent to cvec4.xyxww).
        /// </summary>
        public cvec5 rgraa => new cvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.xyy swizzling.
        /// </summary>
        public cvec3 xyy => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec4.rgg swizzling (equivalent to cvec4.xyy).
        /// </summary>
        public cvec3 rgg => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec4.xyyx swizzling.
        /// </summary>
        public cvec4 xyyx => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.rggr swizzling (equivalent to cvec4.xyyx).
        /// </summary>
        public cvec4 rggr => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.xyyxx swizzling.
        /// </summary>
        public cvec5 xyyxx => new cvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.rggrr swizzling (equivalent to cvec4.xyyxx).
        /// </summary>
        public cvec5 rggrr => new cvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.xyyxy swizzling.
        /// </summary>
        public cvec5 xyyxy => new cvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.rggrg swizzling (equivalent to cvec4.xyyxy).
        /// </summary>
        public cvec5 rggrg => new cvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.xyyxz swizzling.
        /// </summary>
        public cvec5 xyyxz => new cvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.rggrb swizzling (equivalent to cvec4.xyyxz).
        /// </summary>
        public cvec5 rggrb => new cvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.xyyxw swizzling.
        /// </summary>
        public cvec5 xyyxw => new cvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.rggra swizzling (equivalent to cvec4.xyyxw).
        /// </summary>
        public cvec5 rggra => new cvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.xyyy swizzling.
        /// </summary>
        public cvec4 xyyy => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.rggg swizzling (equivalent to cvec4.xyyy).
        /// </summary>
        public cvec4 rggg => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.xyyyx swizzling.
        /// </summary>
        public cvec5 xyyyx => new cvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.rgggr swizzling (equivalent to cvec4.xyyyx).
        /// </summary>
        public cvec5 rgggr => new cvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.xyyyy swizzling.
        /// </summary>
        public cvec5 xyyyy => new cvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.rgggg swizzling (equivalent to cvec4.xyyyy).
        /// </summary>
        public cvec5 rgggg => new cvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.xyyyz swizzling.
        /// </summary>
        public cvec5 xyyyz => new cvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.rgggb swizzling (equivalent to cvec4.xyyyz).
        /// </summary>
        public cvec5 rgggb => new cvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.xyyyw swizzling.
        /// </summary>
        public cvec5 xyyyw => new cvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.rggga swizzling (equivalent to cvec4.xyyyw).
        /// </summary>
        public cvec5 rggga => new cvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.xyyz swizzling.
        /// </summary>
        public cvec4 xyyz => new cvec4(x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.rggb swizzling (equivalent to cvec4.xyyz).
        /// </summary>
        public cvec4 rggb => new cvec4(x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.xyyzx swizzling.
        /// </summary>
        public cvec5 xyyzx => new cvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.rggbr swizzling (equivalent to cvec4.xyyzx).
        /// </summary>
        public cvec5 rggbr => new cvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.xyyzy swizzling.
        /// </summary>
        public cvec5 xyyzy => new cvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.rggbg swizzling (equivalent to cvec4.xyyzy).
        /// </summary>
        public cvec5 rggbg => new cvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.xyyzz swizzling.
        /// </summary>
        public cvec5 xyyzz => new cvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.rggbb swizzling (equivalent to cvec4.xyyzz).
        /// </summary>
        public cvec5 rggbb => new cvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.xyyzw swizzling.
        /// </summary>
        public cvec5 xyyzw => new cvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.rggba swizzling (equivalent to cvec4.xyyzw).
        /// </summary>
        public cvec5 rggba => new cvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.xyyw swizzling.
        /// </summary>
        public cvec4 xyyw => new cvec4(x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.rgga swizzling (equivalent to cvec4.xyyw).
        /// </summary>
        public cvec4 rgga => new cvec4(x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.xyywx swizzling.
        /// </summary>
        public cvec5 xyywx => new cvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.rggar swizzling (equivalent to cvec4.xyywx).
        /// </summary>
        public cvec5 rggar => new cvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.xyywy swizzling.
        /// </summary>
        public cvec5 xyywy => new cvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.rggag swizzling (equivalent to cvec4.xyywy).
        /// </summary>
        public cvec5 rggag => new cvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.xyywz swizzling.
        /// </summary>
        public cvec5 xyywz => new cvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.rggab swizzling (equivalent to cvec4.xyywz).
        /// </summary>
        public cvec5 rggab => new cvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.xyyww swizzling.
        /// </summary>
        public cvec5 xyyww => new cvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.rggaa swizzling (equivalent to cvec4.xyyww).
        /// </summary>
        public cvec5 rggaa => new cvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.xyz swizzling.
        /// </summary>
        public cvec3 xyz => new cvec3(x, y, z);
        
        /// <summary>
        /// Returns cvec4.rgb swizzling (equivalent to cvec4.xyz).
        /// </summary>
        public cvec3 rgb => new cvec3(x, y, z);
        
        /// <summary>
        /// Returns cvec4.xyzx swizzling.
        /// </summary>
        public cvec4 xyzx => new cvec4(x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.rgbr swizzling (equivalent to cvec4.xyzx).
        /// </summary>
        public cvec4 rgbr => new cvec4(x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.xyzxx swizzling.
        /// </summary>
        public cvec5 xyzxx => new cvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.rgbrr swizzling (equivalent to cvec4.xyzxx).
        /// </summary>
        public cvec5 rgbrr => new cvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.xyzxy swizzling.
        /// </summary>
        public cvec5 xyzxy => new cvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.rgbrg swizzling (equivalent to cvec4.xyzxy).
        /// </summary>
        public cvec5 rgbrg => new cvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.xyzxz swizzling.
        /// </summary>
        public cvec5 xyzxz => new cvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.rgbrb swizzling (equivalent to cvec4.xyzxz).
        /// </summary>
        public cvec5 rgbrb => new cvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.xyzxw swizzling.
        /// </summary>
        public cvec5 xyzxw => new cvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.rgbra swizzling (equivalent to cvec4.xyzxw).
        /// </summary>
        public cvec5 rgbra => new cvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.xyzy swizzling.
        /// </summary>
        public cvec4 xyzy => new cvec4(x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.rgbg swizzling (equivalent to cvec4.xyzy).
        /// </summary>
        public cvec4 rgbg => new cvec4(x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.xyzyx swizzling.
        /// </summary>
        public cvec5 xyzyx => new cvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.rgbgr swizzling (equivalent to cvec4.xyzyx).
        /// </summary>
        public cvec5 rgbgr => new cvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.xyzyy swizzling.
        /// </summary>
        public cvec5 xyzyy => new cvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.rgbgg swizzling (equivalent to cvec4.xyzyy).
        /// </summary>
        public cvec5 rgbgg => new cvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.xyzyz swizzling.
        /// </summary>
        public cvec5 xyzyz => new cvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.rgbgb swizzling (equivalent to cvec4.xyzyz).
        /// </summary>
        public cvec5 rgbgb => new cvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.xyzyw swizzling.
        /// </summary>
        public cvec5 xyzyw => new cvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.rgbga swizzling (equivalent to cvec4.xyzyw).
        /// </summary>
        public cvec5 rgbga => new cvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.xyzz swizzling.
        /// </summary>
        public cvec4 xyzz => new cvec4(x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.rgbb swizzling (equivalent to cvec4.xyzz).
        /// </summary>
        public cvec4 rgbb => new cvec4(x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.xyzzx swizzling.
        /// </summary>
        public cvec5 xyzzx => new cvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.rgbbr swizzling (equivalent to cvec4.xyzzx).
        /// </summary>
        public cvec5 rgbbr => new cvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.xyzzy swizzling.
        /// </summary>
        public cvec5 xyzzy => new cvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.rgbbg swizzling (equivalent to cvec4.xyzzy).
        /// </summary>
        public cvec5 rgbbg => new cvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.xyzzz swizzling.
        /// </summary>
        public cvec5 xyzzz => new cvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.rgbbb swizzling (equivalent to cvec4.xyzzz).
        /// </summary>
        public cvec5 rgbbb => new cvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.xyzzw swizzling.
        /// </summary>
        public cvec5 xyzzw => new cvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.rgbba swizzling (equivalent to cvec4.xyzzw).
        /// </summary>
        public cvec5 rgbba => new cvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.xyzw swizzling.
        /// </summary>
        public cvec4 xyzw => new cvec4(x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.rgba swizzling (equivalent to cvec4.xyzw).
        /// </summary>
        public cvec4 rgba => new cvec4(x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.xyzwx swizzling.
        /// </summary>
        public cvec5 xyzwx => new cvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.rgbar swizzling (equivalent to cvec4.xyzwx).
        /// </summary>
        public cvec5 rgbar => new cvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.xyzwy swizzling.
        /// </summary>
        public cvec5 xyzwy => new cvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.rgbag swizzling (equivalent to cvec4.xyzwy).
        /// </summary>
        public cvec5 rgbag => new cvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.xyzwz swizzling.
        /// </summary>
        public cvec5 xyzwz => new cvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.rgbab swizzling (equivalent to cvec4.xyzwz).
        /// </summary>
        public cvec5 rgbab => new cvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.xyzww swizzling.
        /// </summary>
        public cvec5 xyzww => new cvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.rgbaa swizzling (equivalent to cvec4.xyzww).
        /// </summary>
        public cvec5 rgbaa => new cvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.xyw swizzling.
        /// </summary>
        public cvec3 xyw => new cvec3(x, y, w);
        
        /// <summary>
        /// Returns cvec4.rga swizzling (equivalent to cvec4.xyw).
        /// </summary>
        public cvec3 rga => new cvec3(x, y, w);
        
        /// <summary>
        /// Returns cvec4.xywx swizzling.
        /// </summary>
        public cvec4 xywx => new cvec4(x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.rgar swizzling (equivalent to cvec4.xywx).
        /// </summary>
        public cvec4 rgar => new cvec4(x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.xywxx swizzling.
        /// </summary>
        public cvec5 xywxx => new cvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.rgarr swizzling (equivalent to cvec4.xywxx).
        /// </summary>
        public cvec5 rgarr => new cvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.xywxy swizzling.
        /// </summary>
        public cvec5 xywxy => new cvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.rgarg swizzling (equivalent to cvec4.xywxy).
        /// </summary>
        public cvec5 rgarg => new cvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.xywxz swizzling.
        /// </summary>
        public cvec5 xywxz => new cvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.rgarb swizzling (equivalent to cvec4.xywxz).
        /// </summary>
        public cvec5 rgarb => new cvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.xywxw swizzling.
        /// </summary>
        public cvec5 xywxw => new cvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.rgara swizzling (equivalent to cvec4.xywxw).
        /// </summary>
        public cvec5 rgara => new cvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.xywy swizzling.
        /// </summary>
        public cvec4 xywy => new cvec4(x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.rgag swizzling (equivalent to cvec4.xywy).
        /// </summary>
        public cvec4 rgag => new cvec4(x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.xywyx swizzling.
        /// </summary>
        public cvec5 xywyx => new cvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.rgagr swizzling (equivalent to cvec4.xywyx).
        /// </summary>
        public cvec5 rgagr => new cvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.xywyy swizzling.
        /// </summary>
        public cvec5 xywyy => new cvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.rgagg swizzling (equivalent to cvec4.xywyy).
        /// </summary>
        public cvec5 rgagg => new cvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.xywyz swizzling.
        /// </summary>
        public cvec5 xywyz => new cvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.rgagb swizzling (equivalent to cvec4.xywyz).
        /// </summary>
        public cvec5 rgagb => new cvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.xywyw swizzling.
        /// </summary>
        public cvec5 xywyw => new cvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.rgaga swizzling (equivalent to cvec4.xywyw).
        /// </summary>
        public cvec5 rgaga => new cvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.xywz swizzling.
        /// </summary>
        public cvec4 xywz => new cvec4(x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.rgab swizzling (equivalent to cvec4.xywz).
        /// </summary>
        public cvec4 rgab => new cvec4(x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.xywzx swizzling.
        /// </summary>
        public cvec5 xywzx => new cvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.rgabr swizzling (equivalent to cvec4.xywzx).
        /// </summary>
        public cvec5 rgabr => new cvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.xywzy swizzling.
        /// </summary>
        public cvec5 xywzy => new cvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.rgabg swizzling (equivalent to cvec4.xywzy).
        /// </summary>
        public cvec5 rgabg => new cvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.xywzz swizzling.
        /// </summary>
        public cvec5 xywzz => new cvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.rgabb swizzling (equivalent to cvec4.xywzz).
        /// </summary>
        public cvec5 rgabb => new cvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.xywzw swizzling.
        /// </summary>
        public cvec5 xywzw => new cvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.rgaba swizzling (equivalent to cvec4.xywzw).
        /// </summary>
        public cvec5 rgaba => new cvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.xyww swizzling.
        /// </summary>
        public cvec4 xyww => new cvec4(x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.rgaa swizzling (equivalent to cvec4.xyww).
        /// </summary>
        public cvec4 rgaa => new cvec4(x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.xywwx swizzling.
        /// </summary>
        public cvec5 xywwx => new cvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.rgaar swizzling (equivalent to cvec4.xywwx).
        /// </summary>
        public cvec5 rgaar => new cvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.xywwy swizzling.
        /// </summary>
        public cvec5 xywwy => new cvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.rgaag swizzling (equivalent to cvec4.xywwy).
        /// </summary>
        public cvec5 rgaag => new cvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.xywwz swizzling.
        /// </summary>
        public cvec5 xywwz => new cvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.rgaab swizzling (equivalent to cvec4.xywwz).
        /// </summary>
        public cvec5 rgaab => new cvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.xywww swizzling.
        /// </summary>
        public cvec5 xywww => new cvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.rgaaa swizzling (equivalent to cvec4.xywww).
        /// </summary>
        public cvec5 rgaaa => new cvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.xz swizzling.
        /// </summary>
        public cvec2 xz => new cvec2(x, z);
        
        /// <summary>
        /// Returns cvec4.rb swizzling (equivalent to cvec4.xz).
        /// </summary>
        public cvec2 rb => new cvec2(x, z);
        
        /// <summary>
        /// Returns cvec4.xzx swizzling.
        /// </summary>
        public cvec3 xzx => new cvec3(x, z, x);
        
        /// <summary>
        /// Returns cvec4.rbr swizzling (equivalent to cvec4.xzx).
        /// </summary>
        public cvec3 rbr => new cvec3(x, z, x);
        
        /// <summary>
        /// Returns cvec4.xzxx swizzling.
        /// </summary>
        public cvec4 xzxx => new cvec4(x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.rbrr swizzling (equivalent to cvec4.xzxx).
        /// </summary>
        public cvec4 rbrr => new cvec4(x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.xzxxx swizzling.
        /// </summary>
        public cvec5 xzxxx => new cvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.rbrrr swizzling (equivalent to cvec4.xzxxx).
        /// </summary>
        public cvec5 rbrrr => new cvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.xzxxy swizzling.
        /// </summary>
        public cvec5 xzxxy => new cvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.rbrrg swizzling (equivalent to cvec4.xzxxy).
        /// </summary>
        public cvec5 rbrrg => new cvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.xzxxz swizzling.
        /// </summary>
        public cvec5 xzxxz => new cvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.rbrrb swizzling (equivalent to cvec4.xzxxz).
        /// </summary>
        public cvec5 rbrrb => new cvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.xzxxw swizzling.
        /// </summary>
        public cvec5 xzxxw => new cvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.rbrra swizzling (equivalent to cvec4.xzxxw).
        /// </summary>
        public cvec5 rbrra => new cvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.xzxy swizzling.
        /// </summary>
        public cvec4 xzxy => new cvec4(x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.rbrg swizzling (equivalent to cvec4.xzxy).
        /// </summary>
        public cvec4 rbrg => new cvec4(x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.xzxyx swizzling.
        /// </summary>
        public cvec5 xzxyx => new cvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.rbrgr swizzling (equivalent to cvec4.xzxyx).
        /// </summary>
        public cvec5 rbrgr => new cvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.xzxyy swizzling.
        /// </summary>
        public cvec5 xzxyy => new cvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.rbrgg swizzling (equivalent to cvec4.xzxyy).
        /// </summary>
        public cvec5 rbrgg => new cvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.xzxyz swizzling.
        /// </summary>
        public cvec5 xzxyz => new cvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.rbrgb swizzling (equivalent to cvec4.xzxyz).
        /// </summary>
        public cvec5 rbrgb => new cvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.xzxyw swizzling.
        /// </summary>
        public cvec5 xzxyw => new cvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.rbrga swizzling (equivalent to cvec4.xzxyw).
        /// </summary>
        public cvec5 rbrga => new cvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.xzxz swizzling.
        /// </summary>
        public cvec4 xzxz => new cvec4(x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.rbrb swizzling (equivalent to cvec4.xzxz).
        /// </summary>
        public cvec4 rbrb => new cvec4(x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.xzxzx swizzling.
        /// </summary>
        public cvec5 xzxzx => new cvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.rbrbr swizzling (equivalent to cvec4.xzxzx).
        /// </summary>
        public cvec5 rbrbr => new cvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.xzxzy swizzling.
        /// </summary>
        public cvec5 xzxzy => new cvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.rbrbg swizzling (equivalent to cvec4.xzxzy).
        /// </summary>
        public cvec5 rbrbg => new cvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.xzxzz swizzling.
        /// </summary>
        public cvec5 xzxzz => new cvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.rbrbb swizzling (equivalent to cvec4.xzxzz).
        /// </summary>
        public cvec5 rbrbb => new cvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.xzxzw swizzling.
        /// </summary>
        public cvec5 xzxzw => new cvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.rbrba swizzling (equivalent to cvec4.xzxzw).
        /// </summary>
        public cvec5 rbrba => new cvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.xzxw swizzling.
        /// </summary>
        public cvec4 xzxw => new cvec4(x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.rbra swizzling (equivalent to cvec4.xzxw).
        /// </summary>
        public cvec4 rbra => new cvec4(x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.xzxwx swizzling.
        /// </summary>
        public cvec5 xzxwx => new cvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.rbrar swizzling (equivalent to cvec4.xzxwx).
        /// </summary>
        public cvec5 rbrar => new cvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.xzxwy swizzling.
        /// </summary>
        public cvec5 xzxwy => new cvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.rbrag swizzling (equivalent to cvec4.xzxwy).
        /// </summary>
        public cvec5 rbrag => new cvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.xzxwz swizzling.
        /// </summary>
        public cvec5 xzxwz => new cvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.rbrab swizzling (equivalent to cvec4.xzxwz).
        /// </summary>
        public cvec5 rbrab => new cvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.xzxww swizzling.
        /// </summary>
        public cvec5 xzxww => new cvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.rbraa swizzling (equivalent to cvec4.xzxww).
        /// </summary>
        public cvec5 rbraa => new cvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.xzy swizzling.
        /// </summary>
        public cvec3 xzy => new cvec3(x, z, y);
        
        /// <summary>
        /// Returns cvec4.rbg swizzling (equivalent to cvec4.xzy).
        /// </summary>
        public cvec3 rbg => new cvec3(x, z, y);
        
        /// <summary>
        /// Returns cvec4.xzyx swizzling.
        /// </summary>
        public cvec4 xzyx => new cvec4(x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.rbgr swizzling (equivalent to cvec4.xzyx).
        /// </summary>
        public cvec4 rbgr => new cvec4(x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.xzyxx swizzling.
        /// </summary>
        public cvec5 xzyxx => new cvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.rbgrr swizzling (equivalent to cvec4.xzyxx).
        /// </summary>
        public cvec5 rbgrr => new cvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.xzyxy swizzling.
        /// </summary>
        public cvec5 xzyxy => new cvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.rbgrg swizzling (equivalent to cvec4.xzyxy).
        /// </summary>
        public cvec5 rbgrg => new cvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.xzyxz swizzling.
        /// </summary>
        public cvec5 xzyxz => new cvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.rbgrb swizzling (equivalent to cvec4.xzyxz).
        /// </summary>
        public cvec5 rbgrb => new cvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.xzyxw swizzling.
        /// </summary>
        public cvec5 xzyxw => new cvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.rbgra swizzling (equivalent to cvec4.xzyxw).
        /// </summary>
        public cvec5 rbgra => new cvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.xzyy swizzling.
        /// </summary>
        public cvec4 xzyy => new cvec4(x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.rbgg swizzling (equivalent to cvec4.xzyy).
        /// </summary>
        public cvec4 rbgg => new cvec4(x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.xzyyx swizzling.
        /// </summary>
        public cvec5 xzyyx => new cvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.rbggr swizzling (equivalent to cvec4.xzyyx).
        /// </summary>
        public cvec5 rbggr => new cvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.xzyyy swizzling.
        /// </summary>
        public cvec5 xzyyy => new cvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.rbggg swizzling (equivalent to cvec4.xzyyy).
        /// </summary>
        public cvec5 rbggg => new cvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.xzyyz swizzling.
        /// </summary>
        public cvec5 xzyyz => new cvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.rbggb swizzling (equivalent to cvec4.xzyyz).
        /// </summary>
        public cvec5 rbggb => new cvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.xzyyw swizzling.
        /// </summary>
        public cvec5 xzyyw => new cvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.rbgga swizzling (equivalent to cvec4.xzyyw).
        /// </summary>
        public cvec5 rbgga => new cvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.xzyz swizzling.
        /// </summary>
        public cvec4 xzyz => new cvec4(x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.rbgb swizzling (equivalent to cvec4.xzyz).
        /// </summary>
        public cvec4 rbgb => new cvec4(x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.xzyzx swizzling.
        /// </summary>
        public cvec5 xzyzx => new cvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.rbgbr swizzling (equivalent to cvec4.xzyzx).
        /// </summary>
        public cvec5 rbgbr => new cvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.xzyzy swizzling.
        /// </summary>
        public cvec5 xzyzy => new cvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.rbgbg swizzling (equivalent to cvec4.xzyzy).
        /// </summary>
        public cvec5 rbgbg => new cvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.xzyzz swizzling.
        /// </summary>
        public cvec5 xzyzz => new cvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.rbgbb swizzling (equivalent to cvec4.xzyzz).
        /// </summary>
        public cvec5 rbgbb => new cvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.xzyzw swizzling.
        /// </summary>
        public cvec5 xzyzw => new cvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.rbgba swizzling (equivalent to cvec4.xzyzw).
        /// </summary>
        public cvec5 rbgba => new cvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.xzyw swizzling.
        /// </summary>
        public cvec4 xzyw => new cvec4(x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.rbga swizzling (equivalent to cvec4.xzyw).
        /// </summary>
        public cvec4 rbga => new cvec4(x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.xzywx swizzling.
        /// </summary>
        public cvec5 xzywx => new cvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.rbgar swizzling (equivalent to cvec4.xzywx).
        /// </summary>
        public cvec5 rbgar => new cvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.xzywy swizzling.
        /// </summary>
        public cvec5 xzywy => new cvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.rbgag swizzling (equivalent to cvec4.xzywy).
        /// </summary>
        public cvec5 rbgag => new cvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.xzywz swizzling.
        /// </summary>
        public cvec5 xzywz => new cvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.rbgab swizzling (equivalent to cvec4.xzywz).
        /// </summary>
        public cvec5 rbgab => new cvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.xzyww swizzling.
        /// </summary>
        public cvec5 xzyww => new cvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.rbgaa swizzling (equivalent to cvec4.xzyww).
        /// </summary>
        public cvec5 rbgaa => new cvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.xzz swizzling.
        /// </summary>
        public cvec3 xzz => new cvec3(x, z, z);
        
        /// <summary>
        /// Returns cvec4.rbb swizzling (equivalent to cvec4.xzz).
        /// </summary>
        public cvec3 rbb => new cvec3(x, z, z);
        
        /// <summary>
        /// Returns cvec4.xzzx swizzling.
        /// </summary>
        public cvec4 xzzx => new cvec4(x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.rbbr swizzling (equivalent to cvec4.xzzx).
        /// </summary>
        public cvec4 rbbr => new cvec4(x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.xzzxx swizzling.
        /// </summary>
        public cvec5 xzzxx => new cvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.rbbrr swizzling (equivalent to cvec4.xzzxx).
        /// </summary>
        public cvec5 rbbrr => new cvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.xzzxy swizzling.
        /// </summary>
        public cvec5 xzzxy => new cvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.rbbrg swizzling (equivalent to cvec4.xzzxy).
        /// </summary>
        public cvec5 rbbrg => new cvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.xzzxz swizzling.
        /// </summary>
        public cvec5 xzzxz => new cvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.rbbrb swizzling (equivalent to cvec4.xzzxz).
        /// </summary>
        public cvec5 rbbrb => new cvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.xzzxw swizzling.
        /// </summary>
        public cvec5 xzzxw => new cvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.rbbra swizzling (equivalent to cvec4.xzzxw).
        /// </summary>
        public cvec5 rbbra => new cvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.xzzy swizzling.
        /// </summary>
        public cvec4 xzzy => new cvec4(x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.rbbg swizzling (equivalent to cvec4.xzzy).
        /// </summary>
        public cvec4 rbbg => new cvec4(x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.xzzyx swizzling.
        /// </summary>
        public cvec5 xzzyx => new cvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.rbbgr swizzling (equivalent to cvec4.xzzyx).
        /// </summary>
        public cvec5 rbbgr => new cvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.xzzyy swizzling.
        /// </summary>
        public cvec5 xzzyy => new cvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.rbbgg swizzling (equivalent to cvec4.xzzyy).
        /// </summary>
        public cvec5 rbbgg => new cvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.xzzyz swizzling.
        /// </summary>
        public cvec5 xzzyz => new cvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.rbbgb swizzling (equivalent to cvec4.xzzyz).
        /// </summary>
        public cvec5 rbbgb => new cvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.xzzyw swizzling.
        /// </summary>
        public cvec5 xzzyw => new cvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.rbbga swizzling (equivalent to cvec4.xzzyw).
        /// </summary>
        public cvec5 rbbga => new cvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.xzzz swizzling.
        /// </summary>
        public cvec4 xzzz => new cvec4(x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.rbbb swizzling (equivalent to cvec4.xzzz).
        /// </summary>
        public cvec4 rbbb => new cvec4(x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.xzzzx swizzling.
        /// </summary>
        public cvec5 xzzzx => new cvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.rbbbr swizzling (equivalent to cvec4.xzzzx).
        /// </summary>
        public cvec5 rbbbr => new cvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.xzzzy swizzling.
        /// </summary>
        public cvec5 xzzzy => new cvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.rbbbg swizzling (equivalent to cvec4.xzzzy).
        /// </summary>
        public cvec5 rbbbg => new cvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.xzzzz swizzling.
        /// </summary>
        public cvec5 xzzzz => new cvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.rbbbb swizzling (equivalent to cvec4.xzzzz).
        /// </summary>
        public cvec5 rbbbb => new cvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.xzzzw swizzling.
        /// </summary>
        public cvec5 xzzzw => new cvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.rbbba swizzling (equivalent to cvec4.xzzzw).
        /// </summary>
        public cvec5 rbbba => new cvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.xzzw swizzling.
        /// </summary>
        public cvec4 xzzw => new cvec4(x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.rbba swizzling (equivalent to cvec4.xzzw).
        /// </summary>
        public cvec4 rbba => new cvec4(x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.xzzwx swizzling.
        /// </summary>
        public cvec5 xzzwx => new cvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.rbbar swizzling (equivalent to cvec4.xzzwx).
        /// </summary>
        public cvec5 rbbar => new cvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.xzzwy swizzling.
        /// </summary>
        public cvec5 xzzwy => new cvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.rbbag swizzling (equivalent to cvec4.xzzwy).
        /// </summary>
        public cvec5 rbbag => new cvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.xzzwz swizzling.
        /// </summary>
        public cvec5 xzzwz => new cvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.rbbab swizzling (equivalent to cvec4.xzzwz).
        /// </summary>
        public cvec5 rbbab => new cvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.xzzww swizzling.
        /// </summary>
        public cvec5 xzzww => new cvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.rbbaa swizzling (equivalent to cvec4.xzzww).
        /// </summary>
        public cvec5 rbbaa => new cvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.xzw swizzling.
        /// </summary>
        public cvec3 xzw => new cvec3(x, z, w);
        
        /// <summary>
        /// Returns cvec4.rba swizzling (equivalent to cvec4.xzw).
        /// </summary>
        public cvec3 rba => new cvec3(x, z, w);
        
        /// <summary>
        /// Returns cvec4.xzwx swizzling.
        /// </summary>
        public cvec4 xzwx => new cvec4(x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.rbar swizzling (equivalent to cvec4.xzwx).
        /// </summary>
        public cvec4 rbar => new cvec4(x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.xzwxx swizzling.
        /// </summary>
        public cvec5 xzwxx => new cvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.rbarr swizzling (equivalent to cvec4.xzwxx).
        /// </summary>
        public cvec5 rbarr => new cvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.xzwxy swizzling.
        /// </summary>
        public cvec5 xzwxy => new cvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.rbarg swizzling (equivalent to cvec4.xzwxy).
        /// </summary>
        public cvec5 rbarg => new cvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.xzwxz swizzling.
        /// </summary>
        public cvec5 xzwxz => new cvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.rbarb swizzling (equivalent to cvec4.xzwxz).
        /// </summary>
        public cvec5 rbarb => new cvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.xzwxw swizzling.
        /// </summary>
        public cvec5 xzwxw => new cvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.rbara swizzling (equivalent to cvec4.xzwxw).
        /// </summary>
        public cvec5 rbara => new cvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.xzwy swizzling.
        /// </summary>
        public cvec4 xzwy => new cvec4(x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.rbag swizzling (equivalent to cvec4.xzwy).
        /// </summary>
        public cvec4 rbag => new cvec4(x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.xzwyx swizzling.
        /// </summary>
        public cvec5 xzwyx => new cvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.rbagr swizzling (equivalent to cvec4.xzwyx).
        /// </summary>
        public cvec5 rbagr => new cvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.xzwyy swizzling.
        /// </summary>
        public cvec5 xzwyy => new cvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.rbagg swizzling (equivalent to cvec4.xzwyy).
        /// </summary>
        public cvec5 rbagg => new cvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.xzwyz swizzling.
        /// </summary>
        public cvec5 xzwyz => new cvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.rbagb swizzling (equivalent to cvec4.xzwyz).
        /// </summary>
        public cvec5 rbagb => new cvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.xzwyw swizzling.
        /// </summary>
        public cvec5 xzwyw => new cvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.rbaga swizzling (equivalent to cvec4.xzwyw).
        /// </summary>
        public cvec5 rbaga => new cvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.xzwz swizzling.
        /// </summary>
        public cvec4 xzwz => new cvec4(x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.rbab swizzling (equivalent to cvec4.xzwz).
        /// </summary>
        public cvec4 rbab => new cvec4(x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.xzwzx swizzling.
        /// </summary>
        public cvec5 xzwzx => new cvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.rbabr swizzling (equivalent to cvec4.xzwzx).
        /// </summary>
        public cvec5 rbabr => new cvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.xzwzy swizzling.
        /// </summary>
        public cvec5 xzwzy => new cvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.rbabg swizzling (equivalent to cvec4.xzwzy).
        /// </summary>
        public cvec5 rbabg => new cvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.xzwzz swizzling.
        /// </summary>
        public cvec5 xzwzz => new cvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.rbabb swizzling (equivalent to cvec4.xzwzz).
        /// </summary>
        public cvec5 rbabb => new cvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.xzwzw swizzling.
        /// </summary>
        public cvec5 xzwzw => new cvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.rbaba swizzling (equivalent to cvec4.xzwzw).
        /// </summary>
        public cvec5 rbaba => new cvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.xzww swizzling.
        /// </summary>
        public cvec4 xzww => new cvec4(x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.rbaa swizzling (equivalent to cvec4.xzww).
        /// </summary>
        public cvec4 rbaa => new cvec4(x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.xzwwx swizzling.
        /// </summary>
        public cvec5 xzwwx => new cvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.rbaar swizzling (equivalent to cvec4.xzwwx).
        /// </summary>
        public cvec5 rbaar => new cvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.xzwwy swizzling.
        /// </summary>
        public cvec5 xzwwy => new cvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.rbaag swizzling (equivalent to cvec4.xzwwy).
        /// </summary>
        public cvec5 rbaag => new cvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.xzwwz swizzling.
        /// </summary>
        public cvec5 xzwwz => new cvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.rbaab swizzling (equivalent to cvec4.xzwwz).
        /// </summary>
        public cvec5 rbaab => new cvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.xzwww swizzling.
        /// </summary>
        public cvec5 xzwww => new cvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.rbaaa swizzling (equivalent to cvec4.xzwww).
        /// </summary>
        public cvec5 rbaaa => new cvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.xw swizzling.
        /// </summary>
        public cvec2 xw => new cvec2(x, w);
        
        /// <summary>
        /// Returns cvec4.ra swizzling (equivalent to cvec4.xw).
        /// </summary>
        public cvec2 ra => new cvec2(x, w);
        
        /// <summary>
        /// Returns cvec4.xwx swizzling.
        /// </summary>
        public cvec3 xwx => new cvec3(x, w, x);
        
        /// <summary>
        /// Returns cvec4.rar swizzling (equivalent to cvec4.xwx).
        /// </summary>
        public cvec3 rar => new cvec3(x, w, x);
        
        /// <summary>
        /// Returns cvec4.xwxx swizzling.
        /// </summary>
        public cvec4 xwxx => new cvec4(x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.rarr swizzling (equivalent to cvec4.xwxx).
        /// </summary>
        public cvec4 rarr => new cvec4(x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.xwxxx swizzling.
        /// </summary>
        public cvec5 xwxxx => new cvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.rarrr swizzling (equivalent to cvec4.xwxxx).
        /// </summary>
        public cvec5 rarrr => new cvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.xwxxy swizzling.
        /// </summary>
        public cvec5 xwxxy => new cvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.rarrg swizzling (equivalent to cvec4.xwxxy).
        /// </summary>
        public cvec5 rarrg => new cvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.xwxxz swizzling.
        /// </summary>
        public cvec5 xwxxz => new cvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.rarrb swizzling (equivalent to cvec4.xwxxz).
        /// </summary>
        public cvec5 rarrb => new cvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.xwxxw swizzling.
        /// </summary>
        public cvec5 xwxxw => new cvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.rarra swizzling (equivalent to cvec4.xwxxw).
        /// </summary>
        public cvec5 rarra => new cvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.xwxy swizzling.
        /// </summary>
        public cvec4 xwxy => new cvec4(x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.rarg swizzling (equivalent to cvec4.xwxy).
        /// </summary>
        public cvec4 rarg => new cvec4(x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.xwxyx swizzling.
        /// </summary>
        public cvec5 xwxyx => new cvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.rargr swizzling (equivalent to cvec4.xwxyx).
        /// </summary>
        public cvec5 rargr => new cvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.xwxyy swizzling.
        /// </summary>
        public cvec5 xwxyy => new cvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.rargg swizzling (equivalent to cvec4.xwxyy).
        /// </summary>
        public cvec5 rargg => new cvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.xwxyz swizzling.
        /// </summary>
        public cvec5 xwxyz => new cvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.rargb swizzling (equivalent to cvec4.xwxyz).
        /// </summary>
        public cvec5 rargb => new cvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.xwxyw swizzling.
        /// </summary>
        public cvec5 xwxyw => new cvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.rarga swizzling (equivalent to cvec4.xwxyw).
        /// </summary>
        public cvec5 rarga => new cvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.xwxz swizzling.
        /// </summary>
        public cvec4 xwxz => new cvec4(x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.rarb swizzling (equivalent to cvec4.xwxz).
        /// </summary>
        public cvec4 rarb => new cvec4(x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.xwxzx swizzling.
        /// </summary>
        public cvec5 xwxzx => new cvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.rarbr swizzling (equivalent to cvec4.xwxzx).
        /// </summary>
        public cvec5 rarbr => new cvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.xwxzy swizzling.
        /// </summary>
        public cvec5 xwxzy => new cvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.rarbg swizzling (equivalent to cvec4.xwxzy).
        /// </summary>
        public cvec5 rarbg => new cvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.xwxzz swizzling.
        /// </summary>
        public cvec5 xwxzz => new cvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.rarbb swizzling (equivalent to cvec4.xwxzz).
        /// </summary>
        public cvec5 rarbb => new cvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.xwxzw swizzling.
        /// </summary>
        public cvec5 xwxzw => new cvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.rarba swizzling (equivalent to cvec4.xwxzw).
        /// </summary>
        public cvec5 rarba => new cvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.xwxw swizzling.
        /// </summary>
        public cvec4 xwxw => new cvec4(x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.rara swizzling (equivalent to cvec4.xwxw).
        /// </summary>
        public cvec4 rara => new cvec4(x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.xwxwx swizzling.
        /// </summary>
        public cvec5 xwxwx => new cvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.rarar swizzling (equivalent to cvec4.xwxwx).
        /// </summary>
        public cvec5 rarar => new cvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.xwxwy swizzling.
        /// </summary>
        public cvec5 xwxwy => new cvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.rarag swizzling (equivalent to cvec4.xwxwy).
        /// </summary>
        public cvec5 rarag => new cvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.xwxwz swizzling.
        /// </summary>
        public cvec5 xwxwz => new cvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.rarab swizzling (equivalent to cvec4.xwxwz).
        /// </summary>
        public cvec5 rarab => new cvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.xwxww swizzling.
        /// </summary>
        public cvec5 xwxww => new cvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.raraa swizzling (equivalent to cvec4.xwxww).
        /// </summary>
        public cvec5 raraa => new cvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.xwy swizzling.
        /// </summary>
        public cvec3 xwy => new cvec3(x, w, y);
        
        /// <summary>
        /// Returns cvec4.rag swizzling (equivalent to cvec4.xwy).
        /// </summary>
        public cvec3 rag => new cvec3(x, w, y);
        
        /// <summary>
        /// Returns cvec4.xwyx swizzling.
        /// </summary>
        public cvec4 xwyx => new cvec4(x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.ragr swizzling (equivalent to cvec4.xwyx).
        /// </summary>
        public cvec4 ragr => new cvec4(x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.xwyxx swizzling.
        /// </summary>
        public cvec5 xwyxx => new cvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.ragrr swizzling (equivalent to cvec4.xwyxx).
        /// </summary>
        public cvec5 ragrr => new cvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.xwyxy swizzling.
        /// </summary>
        public cvec5 xwyxy => new cvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.ragrg swizzling (equivalent to cvec4.xwyxy).
        /// </summary>
        public cvec5 ragrg => new cvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.xwyxz swizzling.
        /// </summary>
        public cvec5 xwyxz => new cvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.ragrb swizzling (equivalent to cvec4.xwyxz).
        /// </summary>
        public cvec5 ragrb => new cvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.xwyxw swizzling.
        /// </summary>
        public cvec5 xwyxw => new cvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.ragra swizzling (equivalent to cvec4.xwyxw).
        /// </summary>
        public cvec5 ragra => new cvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.xwyy swizzling.
        /// </summary>
        public cvec4 xwyy => new cvec4(x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.ragg swizzling (equivalent to cvec4.xwyy).
        /// </summary>
        public cvec4 ragg => new cvec4(x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.xwyyx swizzling.
        /// </summary>
        public cvec5 xwyyx => new cvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.raggr swizzling (equivalent to cvec4.xwyyx).
        /// </summary>
        public cvec5 raggr => new cvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.xwyyy swizzling.
        /// </summary>
        public cvec5 xwyyy => new cvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.raggg swizzling (equivalent to cvec4.xwyyy).
        /// </summary>
        public cvec5 raggg => new cvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.xwyyz swizzling.
        /// </summary>
        public cvec5 xwyyz => new cvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.raggb swizzling (equivalent to cvec4.xwyyz).
        /// </summary>
        public cvec5 raggb => new cvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.xwyyw swizzling.
        /// </summary>
        public cvec5 xwyyw => new cvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.ragga swizzling (equivalent to cvec4.xwyyw).
        /// </summary>
        public cvec5 ragga => new cvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.xwyz swizzling.
        /// </summary>
        public cvec4 xwyz => new cvec4(x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.ragb swizzling (equivalent to cvec4.xwyz).
        /// </summary>
        public cvec4 ragb => new cvec4(x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.xwyzx swizzling.
        /// </summary>
        public cvec5 xwyzx => new cvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.ragbr swizzling (equivalent to cvec4.xwyzx).
        /// </summary>
        public cvec5 ragbr => new cvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.xwyzy swizzling.
        /// </summary>
        public cvec5 xwyzy => new cvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.ragbg swizzling (equivalent to cvec4.xwyzy).
        /// </summary>
        public cvec5 ragbg => new cvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.xwyzz swizzling.
        /// </summary>
        public cvec5 xwyzz => new cvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.ragbb swizzling (equivalent to cvec4.xwyzz).
        /// </summary>
        public cvec5 ragbb => new cvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.xwyzw swizzling.
        /// </summary>
        public cvec5 xwyzw => new cvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.ragba swizzling (equivalent to cvec4.xwyzw).
        /// </summary>
        public cvec5 ragba => new cvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.xwyw swizzling.
        /// </summary>
        public cvec4 xwyw => new cvec4(x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.raga swizzling (equivalent to cvec4.xwyw).
        /// </summary>
        public cvec4 raga => new cvec4(x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.xwywx swizzling.
        /// </summary>
        public cvec5 xwywx => new cvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.ragar swizzling (equivalent to cvec4.xwywx).
        /// </summary>
        public cvec5 ragar => new cvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.xwywy swizzling.
        /// </summary>
        public cvec5 xwywy => new cvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.ragag swizzling (equivalent to cvec4.xwywy).
        /// </summary>
        public cvec5 ragag => new cvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.xwywz swizzling.
        /// </summary>
        public cvec5 xwywz => new cvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.ragab swizzling (equivalent to cvec4.xwywz).
        /// </summary>
        public cvec5 ragab => new cvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.xwyww swizzling.
        /// </summary>
        public cvec5 xwyww => new cvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.ragaa swizzling (equivalent to cvec4.xwyww).
        /// </summary>
        public cvec5 ragaa => new cvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.xwz swizzling.
        /// </summary>
        public cvec3 xwz => new cvec3(x, w, z);
        
        /// <summary>
        /// Returns cvec4.rab swizzling (equivalent to cvec4.xwz).
        /// </summary>
        public cvec3 rab => new cvec3(x, w, z);
        
        /// <summary>
        /// Returns cvec4.xwzx swizzling.
        /// </summary>
        public cvec4 xwzx => new cvec4(x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.rabr swizzling (equivalent to cvec4.xwzx).
        /// </summary>
        public cvec4 rabr => new cvec4(x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.xwzxx swizzling.
        /// </summary>
        public cvec5 xwzxx => new cvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.rabrr swizzling (equivalent to cvec4.xwzxx).
        /// </summary>
        public cvec5 rabrr => new cvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.xwzxy swizzling.
        /// </summary>
        public cvec5 xwzxy => new cvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.rabrg swizzling (equivalent to cvec4.xwzxy).
        /// </summary>
        public cvec5 rabrg => new cvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.xwzxz swizzling.
        /// </summary>
        public cvec5 xwzxz => new cvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.rabrb swizzling (equivalent to cvec4.xwzxz).
        /// </summary>
        public cvec5 rabrb => new cvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.xwzxw swizzling.
        /// </summary>
        public cvec5 xwzxw => new cvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.rabra swizzling (equivalent to cvec4.xwzxw).
        /// </summary>
        public cvec5 rabra => new cvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.xwzy swizzling.
        /// </summary>
        public cvec4 xwzy => new cvec4(x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.rabg swizzling (equivalent to cvec4.xwzy).
        /// </summary>
        public cvec4 rabg => new cvec4(x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.xwzyx swizzling.
        /// </summary>
        public cvec5 xwzyx => new cvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.rabgr swizzling (equivalent to cvec4.xwzyx).
        /// </summary>
        public cvec5 rabgr => new cvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.xwzyy swizzling.
        /// </summary>
        public cvec5 xwzyy => new cvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.rabgg swizzling (equivalent to cvec4.xwzyy).
        /// </summary>
        public cvec5 rabgg => new cvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.xwzyz swizzling.
        /// </summary>
        public cvec5 xwzyz => new cvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.rabgb swizzling (equivalent to cvec4.xwzyz).
        /// </summary>
        public cvec5 rabgb => new cvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.xwzyw swizzling.
        /// </summary>
        public cvec5 xwzyw => new cvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.rabga swizzling (equivalent to cvec4.xwzyw).
        /// </summary>
        public cvec5 rabga => new cvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.xwzz swizzling.
        /// </summary>
        public cvec4 xwzz => new cvec4(x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.rabb swizzling (equivalent to cvec4.xwzz).
        /// </summary>
        public cvec4 rabb => new cvec4(x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.xwzzx swizzling.
        /// </summary>
        public cvec5 xwzzx => new cvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.rabbr swizzling (equivalent to cvec4.xwzzx).
        /// </summary>
        public cvec5 rabbr => new cvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.xwzzy swizzling.
        /// </summary>
        public cvec5 xwzzy => new cvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.rabbg swizzling (equivalent to cvec4.xwzzy).
        /// </summary>
        public cvec5 rabbg => new cvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.xwzzz swizzling.
        /// </summary>
        public cvec5 xwzzz => new cvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.rabbb swizzling (equivalent to cvec4.xwzzz).
        /// </summary>
        public cvec5 rabbb => new cvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.xwzzw swizzling.
        /// </summary>
        public cvec5 xwzzw => new cvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.rabba swizzling (equivalent to cvec4.xwzzw).
        /// </summary>
        public cvec5 rabba => new cvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.xwzw swizzling.
        /// </summary>
        public cvec4 xwzw => new cvec4(x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.raba swizzling (equivalent to cvec4.xwzw).
        /// </summary>
        public cvec4 raba => new cvec4(x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.xwzwx swizzling.
        /// </summary>
        public cvec5 xwzwx => new cvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.rabar swizzling (equivalent to cvec4.xwzwx).
        /// </summary>
        public cvec5 rabar => new cvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.xwzwy swizzling.
        /// </summary>
        public cvec5 xwzwy => new cvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.rabag swizzling (equivalent to cvec4.xwzwy).
        /// </summary>
        public cvec5 rabag => new cvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.xwzwz swizzling.
        /// </summary>
        public cvec5 xwzwz => new cvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.rabab swizzling (equivalent to cvec4.xwzwz).
        /// </summary>
        public cvec5 rabab => new cvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.xwzww swizzling.
        /// </summary>
        public cvec5 xwzww => new cvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.rabaa swizzling (equivalent to cvec4.xwzww).
        /// </summary>
        public cvec5 rabaa => new cvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.xww swizzling.
        /// </summary>
        public cvec3 xww => new cvec3(x, w, w);
        
        /// <summary>
        /// Returns cvec4.raa swizzling (equivalent to cvec4.xww).
        /// </summary>
        public cvec3 raa => new cvec3(x, w, w);
        
        /// <summary>
        /// Returns cvec4.xwwx swizzling.
        /// </summary>
        public cvec4 xwwx => new cvec4(x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.raar swizzling (equivalent to cvec4.xwwx).
        /// </summary>
        public cvec4 raar => new cvec4(x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.xwwxx swizzling.
        /// </summary>
        public cvec5 xwwxx => new cvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.raarr swizzling (equivalent to cvec4.xwwxx).
        /// </summary>
        public cvec5 raarr => new cvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.xwwxy swizzling.
        /// </summary>
        public cvec5 xwwxy => new cvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.raarg swizzling (equivalent to cvec4.xwwxy).
        /// </summary>
        public cvec5 raarg => new cvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.xwwxz swizzling.
        /// </summary>
        public cvec5 xwwxz => new cvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.raarb swizzling (equivalent to cvec4.xwwxz).
        /// </summary>
        public cvec5 raarb => new cvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.xwwxw swizzling.
        /// </summary>
        public cvec5 xwwxw => new cvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.raara swizzling (equivalent to cvec4.xwwxw).
        /// </summary>
        public cvec5 raara => new cvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.xwwy swizzling.
        /// </summary>
        public cvec4 xwwy => new cvec4(x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.raag swizzling (equivalent to cvec4.xwwy).
        /// </summary>
        public cvec4 raag => new cvec4(x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.xwwyx swizzling.
        /// </summary>
        public cvec5 xwwyx => new cvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.raagr swizzling (equivalent to cvec4.xwwyx).
        /// </summary>
        public cvec5 raagr => new cvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.xwwyy swizzling.
        /// </summary>
        public cvec5 xwwyy => new cvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.raagg swizzling (equivalent to cvec4.xwwyy).
        /// </summary>
        public cvec5 raagg => new cvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.xwwyz swizzling.
        /// </summary>
        public cvec5 xwwyz => new cvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.raagb swizzling (equivalent to cvec4.xwwyz).
        /// </summary>
        public cvec5 raagb => new cvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.xwwyw swizzling.
        /// </summary>
        public cvec5 xwwyw => new cvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.raaga swizzling (equivalent to cvec4.xwwyw).
        /// </summary>
        public cvec5 raaga => new cvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.xwwz swizzling.
        /// </summary>
        public cvec4 xwwz => new cvec4(x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.raab swizzling (equivalent to cvec4.xwwz).
        /// </summary>
        public cvec4 raab => new cvec4(x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.xwwzx swizzling.
        /// </summary>
        public cvec5 xwwzx => new cvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.raabr swizzling (equivalent to cvec4.xwwzx).
        /// </summary>
        public cvec5 raabr => new cvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.xwwzy swizzling.
        /// </summary>
        public cvec5 xwwzy => new cvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.raabg swizzling (equivalent to cvec4.xwwzy).
        /// </summary>
        public cvec5 raabg => new cvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.xwwzz swizzling.
        /// </summary>
        public cvec5 xwwzz => new cvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.raabb swizzling (equivalent to cvec4.xwwzz).
        /// </summary>
        public cvec5 raabb => new cvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.xwwzw swizzling.
        /// </summary>
        public cvec5 xwwzw => new cvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.raaba swizzling (equivalent to cvec4.xwwzw).
        /// </summary>
        public cvec5 raaba => new cvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.xwww swizzling.
        /// </summary>
        public cvec4 xwww => new cvec4(x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.raaa swizzling (equivalent to cvec4.xwww).
        /// </summary>
        public cvec4 raaa => new cvec4(x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.xwwwx swizzling.
        /// </summary>
        public cvec5 xwwwx => new cvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.raaar swizzling (equivalent to cvec4.xwwwx).
        /// </summary>
        public cvec5 raaar => new cvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.xwwwy swizzling.
        /// </summary>
        public cvec5 xwwwy => new cvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.raaag swizzling (equivalent to cvec4.xwwwy).
        /// </summary>
        public cvec5 raaag => new cvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.xwwwz swizzling.
        /// </summary>
        public cvec5 xwwwz => new cvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.raaab swizzling (equivalent to cvec4.xwwwz).
        /// </summary>
        public cvec5 raaab => new cvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.xwwww swizzling.
        /// </summary>
        public cvec5 xwwww => new cvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns cvec4.raaaa swizzling (equivalent to cvec4.xwwww).
        /// </summary>
        public cvec5 raaaa => new cvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns cvec4.yx swizzling.
        /// </summary>
        public cvec2 yx => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec4.gr swizzling (equivalent to cvec4.yx).
        /// </summary>
        public cvec2 gr => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec4.yxx swizzling.
        /// </summary>
        public cvec3 yxx => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec4.grr swizzling (equivalent to cvec4.yxx).
        /// </summary>
        public cvec3 grr => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec4.yxxx swizzling.
        /// </summary>
        public cvec4 yxxx => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.grrr swizzling (equivalent to cvec4.yxxx).
        /// </summary>
        public cvec4 grrr => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.yxxxx swizzling.
        /// </summary>
        public cvec5 yxxxx => new cvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.grrrr swizzling (equivalent to cvec4.yxxxx).
        /// </summary>
        public cvec5 grrrr => new cvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.yxxxy swizzling.
        /// </summary>
        public cvec5 yxxxy => new cvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.grrrg swizzling (equivalent to cvec4.yxxxy).
        /// </summary>
        public cvec5 grrrg => new cvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.yxxxz swizzling.
        /// </summary>
        public cvec5 yxxxz => new cvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.grrrb swizzling (equivalent to cvec4.yxxxz).
        /// </summary>
        public cvec5 grrrb => new cvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.yxxxw swizzling.
        /// </summary>
        public cvec5 yxxxw => new cvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.grrra swizzling (equivalent to cvec4.yxxxw).
        /// </summary>
        public cvec5 grrra => new cvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.yxxy swizzling.
        /// </summary>
        public cvec4 yxxy => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.grrg swizzling (equivalent to cvec4.yxxy).
        /// </summary>
        public cvec4 grrg => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.yxxyx swizzling.
        /// </summary>
        public cvec5 yxxyx => new cvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.grrgr swizzling (equivalent to cvec4.yxxyx).
        /// </summary>
        public cvec5 grrgr => new cvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.yxxyy swizzling.
        /// </summary>
        public cvec5 yxxyy => new cvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.grrgg swizzling (equivalent to cvec4.yxxyy).
        /// </summary>
        public cvec5 grrgg => new cvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.yxxyz swizzling.
        /// </summary>
        public cvec5 yxxyz => new cvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.grrgb swizzling (equivalent to cvec4.yxxyz).
        /// </summary>
        public cvec5 grrgb => new cvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.yxxyw swizzling.
        /// </summary>
        public cvec5 yxxyw => new cvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.grrga swizzling (equivalent to cvec4.yxxyw).
        /// </summary>
        public cvec5 grrga => new cvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.yxxz swizzling.
        /// </summary>
        public cvec4 yxxz => new cvec4(y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.grrb swizzling (equivalent to cvec4.yxxz).
        /// </summary>
        public cvec4 grrb => new cvec4(y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.yxxzx swizzling.
        /// </summary>
        public cvec5 yxxzx => new cvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.grrbr swizzling (equivalent to cvec4.yxxzx).
        /// </summary>
        public cvec5 grrbr => new cvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.yxxzy swizzling.
        /// </summary>
        public cvec5 yxxzy => new cvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.grrbg swizzling (equivalent to cvec4.yxxzy).
        /// </summary>
        public cvec5 grrbg => new cvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.yxxzz swizzling.
        /// </summary>
        public cvec5 yxxzz => new cvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.grrbb swizzling (equivalent to cvec4.yxxzz).
        /// </summary>
        public cvec5 grrbb => new cvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.yxxzw swizzling.
        /// </summary>
        public cvec5 yxxzw => new cvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.grrba swizzling (equivalent to cvec4.yxxzw).
        /// </summary>
        public cvec5 grrba => new cvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.yxxw swizzling.
        /// </summary>
        public cvec4 yxxw => new cvec4(y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.grra swizzling (equivalent to cvec4.yxxw).
        /// </summary>
        public cvec4 grra => new cvec4(y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.yxxwx swizzling.
        /// </summary>
        public cvec5 yxxwx => new cvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.grrar swizzling (equivalent to cvec4.yxxwx).
        /// </summary>
        public cvec5 grrar => new cvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.yxxwy swizzling.
        /// </summary>
        public cvec5 yxxwy => new cvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.grrag swizzling (equivalent to cvec4.yxxwy).
        /// </summary>
        public cvec5 grrag => new cvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.yxxwz swizzling.
        /// </summary>
        public cvec5 yxxwz => new cvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.grrab swizzling (equivalent to cvec4.yxxwz).
        /// </summary>
        public cvec5 grrab => new cvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.yxxww swizzling.
        /// </summary>
        public cvec5 yxxww => new cvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.grraa swizzling (equivalent to cvec4.yxxww).
        /// </summary>
        public cvec5 grraa => new cvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.yxy swizzling.
        /// </summary>
        public cvec3 yxy => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec4.grg swizzling (equivalent to cvec4.yxy).
        /// </summary>
        public cvec3 grg => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec4.yxyx swizzling.
        /// </summary>
        public cvec4 yxyx => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.grgr swizzling (equivalent to cvec4.yxyx).
        /// </summary>
        public cvec4 grgr => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.yxyxx swizzling.
        /// </summary>
        public cvec5 yxyxx => new cvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.grgrr swizzling (equivalent to cvec4.yxyxx).
        /// </summary>
        public cvec5 grgrr => new cvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.yxyxy swizzling.
        /// </summary>
        public cvec5 yxyxy => new cvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.grgrg swizzling (equivalent to cvec4.yxyxy).
        /// </summary>
        public cvec5 grgrg => new cvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.yxyxz swizzling.
        /// </summary>
        public cvec5 yxyxz => new cvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.grgrb swizzling (equivalent to cvec4.yxyxz).
        /// </summary>
        public cvec5 grgrb => new cvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.yxyxw swizzling.
        /// </summary>
        public cvec5 yxyxw => new cvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.grgra swizzling (equivalent to cvec4.yxyxw).
        /// </summary>
        public cvec5 grgra => new cvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.yxyy swizzling.
        /// </summary>
        public cvec4 yxyy => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.grgg swizzling (equivalent to cvec4.yxyy).
        /// </summary>
        public cvec4 grgg => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.yxyyx swizzling.
        /// </summary>
        public cvec5 yxyyx => new cvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.grggr swizzling (equivalent to cvec4.yxyyx).
        /// </summary>
        public cvec5 grggr => new cvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.yxyyy swizzling.
        /// </summary>
        public cvec5 yxyyy => new cvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.grggg swizzling (equivalent to cvec4.yxyyy).
        /// </summary>
        public cvec5 grggg => new cvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.yxyyz swizzling.
        /// </summary>
        public cvec5 yxyyz => new cvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.grggb swizzling (equivalent to cvec4.yxyyz).
        /// </summary>
        public cvec5 grggb => new cvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.yxyyw swizzling.
        /// </summary>
        public cvec5 yxyyw => new cvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.grgga swizzling (equivalent to cvec4.yxyyw).
        /// </summary>
        public cvec5 grgga => new cvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.yxyz swizzling.
        /// </summary>
        public cvec4 yxyz => new cvec4(y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.grgb swizzling (equivalent to cvec4.yxyz).
        /// </summary>
        public cvec4 grgb => new cvec4(y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.yxyzx swizzling.
        /// </summary>
        public cvec5 yxyzx => new cvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.grgbr swizzling (equivalent to cvec4.yxyzx).
        /// </summary>
        public cvec5 grgbr => new cvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.yxyzy swizzling.
        /// </summary>
        public cvec5 yxyzy => new cvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.grgbg swizzling (equivalent to cvec4.yxyzy).
        /// </summary>
        public cvec5 grgbg => new cvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.yxyzz swizzling.
        /// </summary>
        public cvec5 yxyzz => new cvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.grgbb swizzling (equivalent to cvec4.yxyzz).
        /// </summary>
        public cvec5 grgbb => new cvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.yxyzw swizzling.
        /// </summary>
        public cvec5 yxyzw => new cvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.grgba swizzling (equivalent to cvec4.yxyzw).
        /// </summary>
        public cvec5 grgba => new cvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.yxyw swizzling.
        /// </summary>
        public cvec4 yxyw => new cvec4(y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.grga swizzling (equivalent to cvec4.yxyw).
        /// </summary>
        public cvec4 grga => new cvec4(y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.yxywx swizzling.
        /// </summary>
        public cvec5 yxywx => new cvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.grgar swizzling (equivalent to cvec4.yxywx).
        /// </summary>
        public cvec5 grgar => new cvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.yxywy swizzling.
        /// </summary>
        public cvec5 yxywy => new cvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.grgag swizzling (equivalent to cvec4.yxywy).
        /// </summary>
        public cvec5 grgag => new cvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.yxywz swizzling.
        /// </summary>
        public cvec5 yxywz => new cvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.grgab swizzling (equivalent to cvec4.yxywz).
        /// </summary>
        public cvec5 grgab => new cvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.yxyww swizzling.
        /// </summary>
        public cvec5 yxyww => new cvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.grgaa swizzling (equivalent to cvec4.yxyww).
        /// </summary>
        public cvec5 grgaa => new cvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.yxz swizzling.
        /// </summary>
        public cvec3 yxz => new cvec3(y, x, z);
        
        /// <summary>
        /// Returns cvec4.grb swizzling (equivalent to cvec4.yxz).
        /// </summary>
        public cvec3 grb => new cvec3(y, x, z);
        
        /// <summary>
        /// Returns cvec4.yxzx swizzling.
        /// </summary>
        public cvec4 yxzx => new cvec4(y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.grbr swizzling (equivalent to cvec4.yxzx).
        /// </summary>
        public cvec4 grbr => new cvec4(y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.yxzxx swizzling.
        /// </summary>
        public cvec5 yxzxx => new cvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.grbrr swizzling (equivalent to cvec4.yxzxx).
        /// </summary>
        public cvec5 grbrr => new cvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.yxzxy swizzling.
        /// </summary>
        public cvec5 yxzxy => new cvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.grbrg swizzling (equivalent to cvec4.yxzxy).
        /// </summary>
        public cvec5 grbrg => new cvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.yxzxz swizzling.
        /// </summary>
        public cvec5 yxzxz => new cvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.grbrb swizzling (equivalent to cvec4.yxzxz).
        /// </summary>
        public cvec5 grbrb => new cvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.yxzxw swizzling.
        /// </summary>
        public cvec5 yxzxw => new cvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.grbra swizzling (equivalent to cvec4.yxzxw).
        /// </summary>
        public cvec5 grbra => new cvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.yxzy swizzling.
        /// </summary>
        public cvec4 yxzy => new cvec4(y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.grbg swizzling (equivalent to cvec4.yxzy).
        /// </summary>
        public cvec4 grbg => new cvec4(y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.yxzyx swizzling.
        /// </summary>
        public cvec5 yxzyx => new cvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.grbgr swizzling (equivalent to cvec4.yxzyx).
        /// </summary>
        public cvec5 grbgr => new cvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.yxzyy swizzling.
        /// </summary>
        public cvec5 yxzyy => new cvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.grbgg swizzling (equivalent to cvec4.yxzyy).
        /// </summary>
        public cvec5 grbgg => new cvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.yxzyz swizzling.
        /// </summary>
        public cvec5 yxzyz => new cvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.grbgb swizzling (equivalent to cvec4.yxzyz).
        /// </summary>
        public cvec5 grbgb => new cvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.yxzyw swizzling.
        /// </summary>
        public cvec5 yxzyw => new cvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.grbga swizzling (equivalent to cvec4.yxzyw).
        /// </summary>
        public cvec5 grbga => new cvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.yxzz swizzling.
        /// </summary>
        public cvec4 yxzz => new cvec4(y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.grbb swizzling (equivalent to cvec4.yxzz).
        /// </summary>
        public cvec4 grbb => new cvec4(y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.yxzzx swizzling.
        /// </summary>
        public cvec5 yxzzx => new cvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.grbbr swizzling (equivalent to cvec4.yxzzx).
        /// </summary>
        public cvec5 grbbr => new cvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.yxzzy swizzling.
        /// </summary>
        public cvec5 yxzzy => new cvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.grbbg swizzling (equivalent to cvec4.yxzzy).
        /// </summary>
        public cvec5 grbbg => new cvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.yxzzz swizzling.
        /// </summary>
        public cvec5 yxzzz => new cvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.grbbb swizzling (equivalent to cvec4.yxzzz).
        /// </summary>
        public cvec5 grbbb => new cvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.yxzzw swizzling.
        /// </summary>
        public cvec5 yxzzw => new cvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.grbba swizzling (equivalent to cvec4.yxzzw).
        /// </summary>
        public cvec5 grbba => new cvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.yxzw swizzling.
        /// </summary>
        public cvec4 yxzw => new cvec4(y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.grba swizzling (equivalent to cvec4.yxzw).
        /// </summary>
        public cvec4 grba => new cvec4(y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.yxzwx swizzling.
        /// </summary>
        public cvec5 yxzwx => new cvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.grbar swizzling (equivalent to cvec4.yxzwx).
        /// </summary>
        public cvec5 grbar => new cvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.yxzwy swizzling.
        /// </summary>
        public cvec5 yxzwy => new cvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.grbag swizzling (equivalent to cvec4.yxzwy).
        /// </summary>
        public cvec5 grbag => new cvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.yxzwz swizzling.
        /// </summary>
        public cvec5 yxzwz => new cvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.grbab swizzling (equivalent to cvec4.yxzwz).
        /// </summary>
        public cvec5 grbab => new cvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.yxzww swizzling.
        /// </summary>
        public cvec5 yxzww => new cvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.grbaa swizzling (equivalent to cvec4.yxzww).
        /// </summary>
        public cvec5 grbaa => new cvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.yxw swizzling.
        /// </summary>
        public cvec3 yxw => new cvec3(y, x, w);
        
        /// <summary>
        /// Returns cvec4.gra swizzling (equivalent to cvec4.yxw).
        /// </summary>
        public cvec3 gra => new cvec3(y, x, w);
        
        /// <summary>
        /// Returns cvec4.yxwx swizzling.
        /// </summary>
        public cvec4 yxwx => new cvec4(y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.grar swizzling (equivalent to cvec4.yxwx).
        /// </summary>
        public cvec4 grar => new cvec4(y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.yxwxx swizzling.
        /// </summary>
        public cvec5 yxwxx => new cvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.grarr swizzling (equivalent to cvec4.yxwxx).
        /// </summary>
        public cvec5 grarr => new cvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.yxwxy swizzling.
        /// </summary>
        public cvec5 yxwxy => new cvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.grarg swizzling (equivalent to cvec4.yxwxy).
        /// </summary>
        public cvec5 grarg => new cvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.yxwxz swizzling.
        /// </summary>
        public cvec5 yxwxz => new cvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.grarb swizzling (equivalent to cvec4.yxwxz).
        /// </summary>
        public cvec5 grarb => new cvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.yxwxw swizzling.
        /// </summary>
        public cvec5 yxwxw => new cvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.grara swizzling (equivalent to cvec4.yxwxw).
        /// </summary>
        public cvec5 grara => new cvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.yxwy swizzling.
        /// </summary>
        public cvec4 yxwy => new cvec4(y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.grag swizzling (equivalent to cvec4.yxwy).
        /// </summary>
        public cvec4 grag => new cvec4(y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.yxwyx swizzling.
        /// </summary>
        public cvec5 yxwyx => new cvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.gragr swizzling (equivalent to cvec4.yxwyx).
        /// </summary>
        public cvec5 gragr => new cvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.yxwyy swizzling.
        /// </summary>
        public cvec5 yxwyy => new cvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.gragg swizzling (equivalent to cvec4.yxwyy).
        /// </summary>
        public cvec5 gragg => new cvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.yxwyz swizzling.
        /// </summary>
        public cvec5 yxwyz => new cvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.gragb swizzling (equivalent to cvec4.yxwyz).
        /// </summary>
        public cvec5 gragb => new cvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.yxwyw swizzling.
        /// </summary>
        public cvec5 yxwyw => new cvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.graga swizzling (equivalent to cvec4.yxwyw).
        /// </summary>
        public cvec5 graga => new cvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.yxwz swizzling.
        /// </summary>
        public cvec4 yxwz => new cvec4(y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.grab swizzling (equivalent to cvec4.yxwz).
        /// </summary>
        public cvec4 grab => new cvec4(y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.yxwzx swizzling.
        /// </summary>
        public cvec5 yxwzx => new cvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.grabr swizzling (equivalent to cvec4.yxwzx).
        /// </summary>
        public cvec5 grabr => new cvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.yxwzy swizzling.
        /// </summary>
        public cvec5 yxwzy => new cvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.grabg swizzling (equivalent to cvec4.yxwzy).
        /// </summary>
        public cvec5 grabg => new cvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.yxwzz swizzling.
        /// </summary>
        public cvec5 yxwzz => new cvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.grabb swizzling (equivalent to cvec4.yxwzz).
        /// </summary>
        public cvec5 grabb => new cvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.yxwzw swizzling.
        /// </summary>
        public cvec5 yxwzw => new cvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.graba swizzling (equivalent to cvec4.yxwzw).
        /// </summary>
        public cvec5 graba => new cvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.yxww swizzling.
        /// </summary>
        public cvec4 yxww => new cvec4(y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.graa swizzling (equivalent to cvec4.yxww).
        /// </summary>
        public cvec4 graa => new cvec4(y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.yxwwx swizzling.
        /// </summary>
        public cvec5 yxwwx => new cvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.graar swizzling (equivalent to cvec4.yxwwx).
        /// </summary>
        public cvec5 graar => new cvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.yxwwy swizzling.
        /// </summary>
        public cvec5 yxwwy => new cvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.graag swizzling (equivalent to cvec4.yxwwy).
        /// </summary>
        public cvec5 graag => new cvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.yxwwz swizzling.
        /// </summary>
        public cvec5 yxwwz => new cvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.graab swizzling (equivalent to cvec4.yxwwz).
        /// </summary>
        public cvec5 graab => new cvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.yxwww swizzling.
        /// </summary>
        public cvec5 yxwww => new cvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.graaa swizzling (equivalent to cvec4.yxwww).
        /// </summary>
        public cvec5 graaa => new cvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.yy swizzling.
        /// </summary>
        public cvec2 yy => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec4.gg swizzling (equivalent to cvec4.yy).
        /// </summary>
        public cvec2 gg => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec4.yyx swizzling.
        /// </summary>
        public cvec3 yyx => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec4.ggr swizzling (equivalent to cvec4.yyx).
        /// </summary>
        public cvec3 ggr => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec4.yyxx swizzling.
        /// </summary>
        public cvec4 yyxx => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.ggrr swizzling (equivalent to cvec4.yyxx).
        /// </summary>
        public cvec4 ggrr => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.yyxxx swizzling.
        /// </summary>
        public cvec5 yyxxx => new cvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.ggrrr swizzling (equivalent to cvec4.yyxxx).
        /// </summary>
        public cvec5 ggrrr => new cvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.yyxxy swizzling.
        /// </summary>
        public cvec5 yyxxy => new cvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.ggrrg swizzling (equivalent to cvec4.yyxxy).
        /// </summary>
        public cvec5 ggrrg => new cvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.yyxxz swizzling.
        /// </summary>
        public cvec5 yyxxz => new cvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.ggrrb swizzling (equivalent to cvec4.yyxxz).
        /// </summary>
        public cvec5 ggrrb => new cvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.yyxxw swizzling.
        /// </summary>
        public cvec5 yyxxw => new cvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.ggrra swizzling (equivalent to cvec4.yyxxw).
        /// </summary>
        public cvec5 ggrra => new cvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.yyxy swizzling.
        /// </summary>
        public cvec4 yyxy => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.ggrg swizzling (equivalent to cvec4.yyxy).
        /// </summary>
        public cvec4 ggrg => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.yyxyx swizzling.
        /// </summary>
        public cvec5 yyxyx => new cvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.ggrgr swizzling (equivalent to cvec4.yyxyx).
        /// </summary>
        public cvec5 ggrgr => new cvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.yyxyy swizzling.
        /// </summary>
        public cvec5 yyxyy => new cvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.ggrgg swizzling (equivalent to cvec4.yyxyy).
        /// </summary>
        public cvec5 ggrgg => new cvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.yyxyz swizzling.
        /// </summary>
        public cvec5 yyxyz => new cvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.ggrgb swizzling (equivalent to cvec4.yyxyz).
        /// </summary>
        public cvec5 ggrgb => new cvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.yyxyw swizzling.
        /// </summary>
        public cvec5 yyxyw => new cvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.ggrga swizzling (equivalent to cvec4.yyxyw).
        /// </summary>
        public cvec5 ggrga => new cvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.yyxz swizzling.
        /// </summary>
        public cvec4 yyxz => new cvec4(y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.ggrb swizzling (equivalent to cvec4.yyxz).
        /// </summary>
        public cvec4 ggrb => new cvec4(y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.yyxzx swizzling.
        /// </summary>
        public cvec5 yyxzx => new cvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.ggrbr swizzling (equivalent to cvec4.yyxzx).
        /// </summary>
        public cvec5 ggrbr => new cvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.yyxzy swizzling.
        /// </summary>
        public cvec5 yyxzy => new cvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.ggrbg swizzling (equivalent to cvec4.yyxzy).
        /// </summary>
        public cvec5 ggrbg => new cvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.yyxzz swizzling.
        /// </summary>
        public cvec5 yyxzz => new cvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.ggrbb swizzling (equivalent to cvec4.yyxzz).
        /// </summary>
        public cvec5 ggrbb => new cvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.yyxzw swizzling.
        /// </summary>
        public cvec5 yyxzw => new cvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.ggrba swizzling (equivalent to cvec4.yyxzw).
        /// </summary>
        public cvec5 ggrba => new cvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.yyxw swizzling.
        /// </summary>
        public cvec4 yyxw => new cvec4(y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.ggra swizzling (equivalent to cvec4.yyxw).
        /// </summary>
        public cvec4 ggra => new cvec4(y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.yyxwx swizzling.
        /// </summary>
        public cvec5 yyxwx => new cvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.ggrar swizzling (equivalent to cvec4.yyxwx).
        /// </summary>
        public cvec5 ggrar => new cvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.yyxwy swizzling.
        /// </summary>
        public cvec5 yyxwy => new cvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.ggrag swizzling (equivalent to cvec4.yyxwy).
        /// </summary>
        public cvec5 ggrag => new cvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.yyxwz swizzling.
        /// </summary>
        public cvec5 yyxwz => new cvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.ggrab swizzling (equivalent to cvec4.yyxwz).
        /// </summary>
        public cvec5 ggrab => new cvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.yyxww swizzling.
        /// </summary>
        public cvec5 yyxww => new cvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.ggraa swizzling (equivalent to cvec4.yyxww).
        /// </summary>
        public cvec5 ggraa => new cvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.yyy swizzling.
        /// </summary>
        public cvec3 yyy => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec4.ggg swizzling (equivalent to cvec4.yyy).
        /// </summary>
        public cvec3 ggg => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec4.yyyx swizzling.
        /// </summary>
        public cvec4 yyyx => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.gggr swizzling (equivalent to cvec4.yyyx).
        /// </summary>
        public cvec4 gggr => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.yyyxx swizzling.
        /// </summary>
        public cvec5 yyyxx => new cvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.gggrr swizzling (equivalent to cvec4.yyyxx).
        /// </summary>
        public cvec5 gggrr => new cvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.yyyxy swizzling.
        /// </summary>
        public cvec5 yyyxy => new cvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.gggrg swizzling (equivalent to cvec4.yyyxy).
        /// </summary>
        public cvec5 gggrg => new cvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.yyyxz swizzling.
        /// </summary>
        public cvec5 yyyxz => new cvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.gggrb swizzling (equivalent to cvec4.yyyxz).
        /// </summary>
        public cvec5 gggrb => new cvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.yyyxw swizzling.
        /// </summary>
        public cvec5 yyyxw => new cvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.gggra swizzling (equivalent to cvec4.yyyxw).
        /// </summary>
        public cvec5 gggra => new cvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.yyyy swizzling.
        /// </summary>
        public cvec4 yyyy => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.gggg swizzling (equivalent to cvec4.yyyy).
        /// </summary>
        public cvec4 gggg => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.yyyyx swizzling.
        /// </summary>
        public cvec5 yyyyx => new cvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.ggggr swizzling (equivalent to cvec4.yyyyx).
        /// </summary>
        public cvec5 ggggr => new cvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.yyyyy swizzling.
        /// </summary>
        public cvec5 yyyyy => new cvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.ggggg swizzling (equivalent to cvec4.yyyyy).
        /// </summary>
        public cvec5 ggggg => new cvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.yyyyz swizzling.
        /// </summary>
        public cvec5 yyyyz => new cvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.ggggb swizzling (equivalent to cvec4.yyyyz).
        /// </summary>
        public cvec5 ggggb => new cvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.yyyyw swizzling.
        /// </summary>
        public cvec5 yyyyw => new cvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.gggga swizzling (equivalent to cvec4.yyyyw).
        /// </summary>
        public cvec5 gggga => new cvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.yyyz swizzling.
        /// </summary>
        public cvec4 yyyz => new cvec4(y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.gggb swizzling (equivalent to cvec4.yyyz).
        /// </summary>
        public cvec4 gggb => new cvec4(y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.yyyzx swizzling.
        /// </summary>
        public cvec5 yyyzx => new cvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.gggbr swizzling (equivalent to cvec4.yyyzx).
        /// </summary>
        public cvec5 gggbr => new cvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.yyyzy swizzling.
        /// </summary>
        public cvec5 yyyzy => new cvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.gggbg swizzling (equivalent to cvec4.yyyzy).
        /// </summary>
        public cvec5 gggbg => new cvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.yyyzz swizzling.
        /// </summary>
        public cvec5 yyyzz => new cvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.gggbb swizzling (equivalent to cvec4.yyyzz).
        /// </summary>
        public cvec5 gggbb => new cvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.yyyzw swizzling.
        /// </summary>
        public cvec5 yyyzw => new cvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.gggba swizzling (equivalent to cvec4.yyyzw).
        /// </summary>
        public cvec5 gggba => new cvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.yyyw swizzling.
        /// </summary>
        public cvec4 yyyw => new cvec4(y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.ggga swizzling (equivalent to cvec4.yyyw).
        /// </summary>
        public cvec4 ggga => new cvec4(y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.yyywx swizzling.
        /// </summary>
        public cvec5 yyywx => new cvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.gggar swizzling (equivalent to cvec4.yyywx).
        /// </summary>
        public cvec5 gggar => new cvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.yyywy swizzling.
        /// </summary>
        public cvec5 yyywy => new cvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.gggag swizzling (equivalent to cvec4.yyywy).
        /// </summary>
        public cvec5 gggag => new cvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.yyywz swizzling.
        /// </summary>
        public cvec5 yyywz => new cvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.gggab swizzling (equivalent to cvec4.yyywz).
        /// </summary>
        public cvec5 gggab => new cvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.yyyww swizzling.
        /// </summary>
        public cvec5 yyyww => new cvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.gggaa swizzling (equivalent to cvec4.yyyww).
        /// </summary>
        public cvec5 gggaa => new cvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.yyz swizzling.
        /// </summary>
        public cvec3 yyz => new cvec3(y, y, z);
        
        /// <summary>
        /// Returns cvec4.ggb swizzling (equivalent to cvec4.yyz).
        /// </summary>
        public cvec3 ggb => new cvec3(y, y, z);
        
        /// <summary>
        /// Returns cvec4.yyzx swizzling.
        /// </summary>
        public cvec4 yyzx => new cvec4(y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.ggbr swizzling (equivalent to cvec4.yyzx).
        /// </summary>
        public cvec4 ggbr => new cvec4(y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.yyzxx swizzling.
        /// </summary>
        public cvec5 yyzxx => new cvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.ggbrr swizzling (equivalent to cvec4.yyzxx).
        /// </summary>
        public cvec5 ggbrr => new cvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.yyzxy swizzling.
        /// </summary>
        public cvec5 yyzxy => new cvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.ggbrg swizzling (equivalent to cvec4.yyzxy).
        /// </summary>
        public cvec5 ggbrg => new cvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.yyzxz swizzling.
        /// </summary>
        public cvec5 yyzxz => new cvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.ggbrb swizzling (equivalent to cvec4.yyzxz).
        /// </summary>
        public cvec5 ggbrb => new cvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.yyzxw swizzling.
        /// </summary>
        public cvec5 yyzxw => new cvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.ggbra swizzling (equivalent to cvec4.yyzxw).
        /// </summary>
        public cvec5 ggbra => new cvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.yyzy swizzling.
        /// </summary>
        public cvec4 yyzy => new cvec4(y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.ggbg swizzling (equivalent to cvec4.yyzy).
        /// </summary>
        public cvec4 ggbg => new cvec4(y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.yyzyx swizzling.
        /// </summary>
        public cvec5 yyzyx => new cvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.ggbgr swizzling (equivalent to cvec4.yyzyx).
        /// </summary>
        public cvec5 ggbgr => new cvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.yyzyy swizzling.
        /// </summary>
        public cvec5 yyzyy => new cvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.ggbgg swizzling (equivalent to cvec4.yyzyy).
        /// </summary>
        public cvec5 ggbgg => new cvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.yyzyz swizzling.
        /// </summary>
        public cvec5 yyzyz => new cvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.ggbgb swizzling (equivalent to cvec4.yyzyz).
        /// </summary>
        public cvec5 ggbgb => new cvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.yyzyw swizzling.
        /// </summary>
        public cvec5 yyzyw => new cvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.ggbga swizzling (equivalent to cvec4.yyzyw).
        /// </summary>
        public cvec5 ggbga => new cvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.yyzz swizzling.
        /// </summary>
        public cvec4 yyzz => new cvec4(y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.ggbb swizzling (equivalent to cvec4.yyzz).
        /// </summary>
        public cvec4 ggbb => new cvec4(y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.yyzzx swizzling.
        /// </summary>
        public cvec5 yyzzx => new cvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.ggbbr swizzling (equivalent to cvec4.yyzzx).
        /// </summary>
        public cvec5 ggbbr => new cvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.yyzzy swizzling.
        /// </summary>
        public cvec5 yyzzy => new cvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.ggbbg swizzling (equivalent to cvec4.yyzzy).
        /// </summary>
        public cvec5 ggbbg => new cvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.yyzzz swizzling.
        /// </summary>
        public cvec5 yyzzz => new cvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.ggbbb swizzling (equivalent to cvec4.yyzzz).
        /// </summary>
        public cvec5 ggbbb => new cvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.yyzzw swizzling.
        /// </summary>
        public cvec5 yyzzw => new cvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.ggbba swizzling (equivalent to cvec4.yyzzw).
        /// </summary>
        public cvec5 ggbba => new cvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.yyzw swizzling.
        /// </summary>
        public cvec4 yyzw => new cvec4(y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.ggba swizzling (equivalent to cvec4.yyzw).
        /// </summary>
        public cvec4 ggba => new cvec4(y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.yyzwx swizzling.
        /// </summary>
        public cvec5 yyzwx => new cvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.ggbar swizzling (equivalent to cvec4.yyzwx).
        /// </summary>
        public cvec5 ggbar => new cvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.yyzwy swizzling.
        /// </summary>
        public cvec5 yyzwy => new cvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.ggbag swizzling (equivalent to cvec4.yyzwy).
        /// </summary>
        public cvec5 ggbag => new cvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.yyzwz swizzling.
        /// </summary>
        public cvec5 yyzwz => new cvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.ggbab swizzling (equivalent to cvec4.yyzwz).
        /// </summary>
        public cvec5 ggbab => new cvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.yyzww swizzling.
        /// </summary>
        public cvec5 yyzww => new cvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.ggbaa swizzling (equivalent to cvec4.yyzww).
        /// </summary>
        public cvec5 ggbaa => new cvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.yyw swizzling.
        /// </summary>
        public cvec3 yyw => new cvec3(y, y, w);
        
        /// <summary>
        /// Returns cvec4.gga swizzling (equivalent to cvec4.yyw).
        /// </summary>
        public cvec3 gga => new cvec3(y, y, w);
        
        /// <summary>
        /// Returns cvec4.yywx swizzling.
        /// </summary>
        public cvec4 yywx => new cvec4(y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.ggar swizzling (equivalent to cvec4.yywx).
        /// </summary>
        public cvec4 ggar => new cvec4(y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.yywxx swizzling.
        /// </summary>
        public cvec5 yywxx => new cvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.ggarr swizzling (equivalent to cvec4.yywxx).
        /// </summary>
        public cvec5 ggarr => new cvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.yywxy swizzling.
        /// </summary>
        public cvec5 yywxy => new cvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.ggarg swizzling (equivalent to cvec4.yywxy).
        /// </summary>
        public cvec5 ggarg => new cvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.yywxz swizzling.
        /// </summary>
        public cvec5 yywxz => new cvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.ggarb swizzling (equivalent to cvec4.yywxz).
        /// </summary>
        public cvec5 ggarb => new cvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.yywxw swizzling.
        /// </summary>
        public cvec5 yywxw => new cvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.ggara swizzling (equivalent to cvec4.yywxw).
        /// </summary>
        public cvec5 ggara => new cvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.yywy swizzling.
        /// </summary>
        public cvec4 yywy => new cvec4(y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.ggag swizzling (equivalent to cvec4.yywy).
        /// </summary>
        public cvec4 ggag => new cvec4(y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.yywyx swizzling.
        /// </summary>
        public cvec5 yywyx => new cvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.ggagr swizzling (equivalent to cvec4.yywyx).
        /// </summary>
        public cvec5 ggagr => new cvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.yywyy swizzling.
        /// </summary>
        public cvec5 yywyy => new cvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.ggagg swizzling (equivalent to cvec4.yywyy).
        /// </summary>
        public cvec5 ggagg => new cvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.yywyz swizzling.
        /// </summary>
        public cvec5 yywyz => new cvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.ggagb swizzling (equivalent to cvec4.yywyz).
        /// </summary>
        public cvec5 ggagb => new cvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.yywyw swizzling.
        /// </summary>
        public cvec5 yywyw => new cvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.ggaga swizzling (equivalent to cvec4.yywyw).
        /// </summary>
        public cvec5 ggaga => new cvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.yywz swizzling.
        /// </summary>
        public cvec4 yywz => new cvec4(y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.ggab swizzling (equivalent to cvec4.yywz).
        /// </summary>
        public cvec4 ggab => new cvec4(y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.yywzx swizzling.
        /// </summary>
        public cvec5 yywzx => new cvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.ggabr swizzling (equivalent to cvec4.yywzx).
        /// </summary>
        public cvec5 ggabr => new cvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.yywzy swizzling.
        /// </summary>
        public cvec5 yywzy => new cvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.ggabg swizzling (equivalent to cvec4.yywzy).
        /// </summary>
        public cvec5 ggabg => new cvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.yywzz swizzling.
        /// </summary>
        public cvec5 yywzz => new cvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.ggabb swizzling (equivalent to cvec4.yywzz).
        /// </summary>
        public cvec5 ggabb => new cvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.yywzw swizzling.
        /// </summary>
        public cvec5 yywzw => new cvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.ggaba swizzling (equivalent to cvec4.yywzw).
        /// </summary>
        public cvec5 ggaba => new cvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.yyww swizzling.
        /// </summary>
        public cvec4 yyww => new cvec4(y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.ggaa swizzling (equivalent to cvec4.yyww).
        /// </summary>
        public cvec4 ggaa => new cvec4(y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.yywwx swizzling.
        /// </summary>
        public cvec5 yywwx => new cvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.ggaar swizzling (equivalent to cvec4.yywwx).
        /// </summary>
        public cvec5 ggaar => new cvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.yywwy swizzling.
        /// </summary>
        public cvec5 yywwy => new cvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.ggaag swizzling (equivalent to cvec4.yywwy).
        /// </summary>
        public cvec5 ggaag => new cvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.yywwz swizzling.
        /// </summary>
        public cvec5 yywwz => new cvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.ggaab swizzling (equivalent to cvec4.yywwz).
        /// </summary>
        public cvec5 ggaab => new cvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.yywww swizzling.
        /// </summary>
        public cvec5 yywww => new cvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.ggaaa swizzling (equivalent to cvec4.yywww).
        /// </summary>
        public cvec5 ggaaa => new cvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.yz swizzling.
        /// </summary>
        public cvec2 yz => new cvec2(y, z);
        
        /// <summary>
        /// Returns cvec4.gb swizzling (equivalent to cvec4.yz).
        /// </summary>
        public cvec2 gb => new cvec2(y, z);
        
        /// <summary>
        /// Returns cvec4.yzx swizzling.
        /// </summary>
        public cvec3 yzx => new cvec3(y, z, x);
        
        /// <summary>
        /// Returns cvec4.gbr swizzling (equivalent to cvec4.yzx).
        /// </summary>
        public cvec3 gbr => new cvec3(y, z, x);
        
        /// <summary>
        /// Returns cvec4.yzxx swizzling.
        /// </summary>
        public cvec4 yzxx => new cvec4(y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.gbrr swizzling (equivalent to cvec4.yzxx).
        /// </summary>
        public cvec4 gbrr => new cvec4(y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.yzxxx swizzling.
        /// </summary>
        public cvec5 yzxxx => new cvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.gbrrr swizzling (equivalent to cvec4.yzxxx).
        /// </summary>
        public cvec5 gbrrr => new cvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.yzxxy swizzling.
        /// </summary>
        public cvec5 yzxxy => new cvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.gbrrg swizzling (equivalent to cvec4.yzxxy).
        /// </summary>
        public cvec5 gbrrg => new cvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.yzxxz swizzling.
        /// </summary>
        public cvec5 yzxxz => new cvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.gbrrb swizzling (equivalent to cvec4.yzxxz).
        /// </summary>
        public cvec5 gbrrb => new cvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.yzxxw swizzling.
        /// </summary>
        public cvec5 yzxxw => new cvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.gbrra swizzling (equivalent to cvec4.yzxxw).
        /// </summary>
        public cvec5 gbrra => new cvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.yzxy swizzling.
        /// </summary>
        public cvec4 yzxy => new cvec4(y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.gbrg swizzling (equivalent to cvec4.yzxy).
        /// </summary>
        public cvec4 gbrg => new cvec4(y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.yzxyx swizzling.
        /// </summary>
        public cvec5 yzxyx => new cvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.gbrgr swizzling (equivalent to cvec4.yzxyx).
        /// </summary>
        public cvec5 gbrgr => new cvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.yzxyy swizzling.
        /// </summary>
        public cvec5 yzxyy => new cvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.gbrgg swizzling (equivalent to cvec4.yzxyy).
        /// </summary>
        public cvec5 gbrgg => new cvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.yzxyz swizzling.
        /// </summary>
        public cvec5 yzxyz => new cvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.gbrgb swizzling (equivalent to cvec4.yzxyz).
        /// </summary>
        public cvec5 gbrgb => new cvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.yzxyw swizzling.
        /// </summary>
        public cvec5 yzxyw => new cvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.gbrga swizzling (equivalent to cvec4.yzxyw).
        /// </summary>
        public cvec5 gbrga => new cvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.yzxz swizzling.
        /// </summary>
        public cvec4 yzxz => new cvec4(y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.gbrb swizzling (equivalent to cvec4.yzxz).
        /// </summary>
        public cvec4 gbrb => new cvec4(y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.yzxzx swizzling.
        /// </summary>
        public cvec5 yzxzx => new cvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.gbrbr swizzling (equivalent to cvec4.yzxzx).
        /// </summary>
        public cvec5 gbrbr => new cvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.yzxzy swizzling.
        /// </summary>
        public cvec5 yzxzy => new cvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.gbrbg swizzling (equivalent to cvec4.yzxzy).
        /// </summary>
        public cvec5 gbrbg => new cvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.yzxzz swizzling.
        /// </summary>
        public cvec5 yzxzz => new cvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.gbrbb swizzling (equivalent to cvec4.yzxzz).
        /// </summary>
        public cvec5 gbrbb => new cvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.yzxzw swizzling.
        /// </summary>
        public cvec5 yzxzw => new cvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.gbrba swizzling (equivalent to cvec4.yzxzw).
        /// </summary>
        public cvec5 gbrba => new cvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.yzxw swizzling.
        /// </summary>
        public cvec4 yzxw => new cvec4(y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.gbra swizzling (equivalent to cvec4.yzxw).
        /// </summary>
        public cvec4 gbra => new cvec4(y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.yzxwx swizzling.
        /// </summary>
        public cvec5 yzxwx => new cvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.gbrar swizzling (equivalent to cvec4.yzxwx).
        /// </summary>
        public cvec5 gbrar => new cvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.yzxwy swizzling.
        /// </summary>
        public cvec5 yzxwy => new cvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.gbrag swizzling (equivalent to cvec4.yzxwy).
        /// </summary>
        public cvec5 gbrag => new cvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.yzxwz swizzling.
        /// </summary>
        public cvec5 yzxwz => new cvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.gbrab swizzling (equivalent to cvec4.yzxwz).
        /// </summary>
        public cvec5 gbrab => new cvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.yzxww swizzling.
        /// </summary>
        public cvec5 yzxww => new cvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.gbraa swizzling (equivalent to cvec4.yzxww).
        /// </summary>
        public cvec5 gbraa => new cvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.yzy swizzling.
        /// </summary>
        public cvec3 yzy => new cvec3(y, z, y);
        
        /// <summary>
        /// Returns cvec4.gbg swizzling (equivalent to cvec4.yzy).
        /// </summary>
        public cvec3 gbg => new cvec3(y, z, y);
        
        /// <summary>
        /// Returns cvec4.yzyx swizzling.
        /// </summary>
        public cvec4 yzyx => new cvec4(y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.gbgr swizzling (equivalent to cvec4.yzyx).
        /// </summary>
        public cvec4 gbgr => new cvec4(y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.yzyxx swizzling.
        /// </summary>
        public cvec5 yzyxx => new cvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.gbgrr swizzling (equivalent to cvec4.yzyxx).
        /// </summary>
        public cvec5 gbgrr => new cvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.yzyxy swizzling.
        /// </summary>
        public cvec5 yzyxy => new cvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.gbgrg swizzling (equivalent to cvec4.yzyxy).
        /// </summary>
        public cvec5 gbgrg => new cvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.yzyxz swizzling.
        /// </summary>
        public cvec5 yzyxz => new cvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.gbgrb swizzling (equivalent to cvec4.yzyxz).
        /// </summary>
        public cvec5 gbgrb => new cvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.yzyxw swizzling.
        /// </summary>
        public cvec5 yzyxw => new cvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.gbgra swizzling (equivalent to cvec4.yzyxw).
        /// </summary>
        public cvec5 gbgra => new cvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.yzyy swizzling.
        /// </summary>
        public cvec4 yzyy => new cvec4(y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.gbgg swizzling (equivalent to cvec4.yzyy).
        /// </summary>
        public cvec4 gbgg => new cvec4(y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.yzyyx swizzling.
        /// </summary>
        public cvec5 yzyyx => new cvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.gbggr swizzling (equivalent to cvec4.yzyyx).
        /// </summary>
        public cvec5 gbggr => new cvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.yzyyy swizzling.
        /// </summary>
        public cvec5 yzyyy => new cvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.gbggg swizzling (equivalent to cvec4.yzyyy).
        /// </summary>
        public cvec5 gbggg => new cvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.yzyyz swizzling.
        /// </summary>
        public cvec5 yzyyz => new cvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.gbggb swizzling (equivalent to cvec4.yzyyz).
        /// </summary>
        public cvec5 gbggb => new cvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.yzyyw swizzling.
        /// </summary>
        public cvec5 yzyyw => new cvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.gbgga swizzling (equivalent to cvec4.yzyyw).
        /// </summary>
        public cvec5 gbgga => new cvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.yzyz swizzling.
        /// </summary>
        public cvec4 yzyz => new cvec4(y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.gbgb swizzling (equivalent to cvec4.yzyz).
        /// </summary>
        public cvec4 gbgb => new cvec4(y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.yzyzx swizzling.
        /// </summary>
        public cvec5 yzyzx => new cvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.gbgbr swizzling (equivalent to cvec4.yzyzx).
        /// </summary>
        public cvec5 gbgbr => new cvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.yzyzy swizzling.
        /// </summary>
        public cvec5 yzyzy => new cvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.gbgbg swizzling (equivalent to cvec4.yzyzy).
        /// </summary>
        public cvec5 gbgbg => new cvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.yzyzz swizzling.
        /// </summary>
        public cvec5 yzyzz => new cvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.gbgbb swizzling (equivalent to cvec4.yzyzz).
        /// </summary>
        public cvec5 gbgbb => new cvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.yzyzw swizzling.
        /// </summary>
        public cvec5 yzyzw => new cvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.gbgba swizzling (equivalent to cvec4.yzyzw).
        /// </summary>
        public cvec5 gbgba => new cvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.yzyw swizzling.
        /// </summary>
        public cvec4 yzyw => new cvec4(y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.gbga swizzling (equivalent to cvec4.yzyw).
        /// </summary>
        public cvec4 gbga => new cvec4(y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.yzywx swizzling.
        /// </summary>
        public cvec5 yzywx => new cvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.gbgar swizzling (equivalent to cvec4.yzywx).
        /// </summary>
        public cvec5 gbgar => new cvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.yzywy swizzling.
        /// </summary>
        public cvec5 yzywy => new cvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.gbgag swizzling (equivalent to cvec4.yzywy).
        /// </summary>
        public cvec5 gbgag => new cvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.yzywz swizzling.
        /// </summary>
        public cvec5 yzywz => new cvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.gbgab swizzling (equivalent to cvec4.yzywz).
        /// </summary>
        public cvec5 gbgab => new cvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.yzyww swizzling.
        /// </summary>
        public cvec5 yzyww => new cvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.gbgaa swizzling (equivalent to cvec4.yzyww).
        /// </summary>
        public cvec5 gbgaa => new cvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.yzz swizzling.
        /// </summary>
        public cvec3 yzz => new cvec3(y, z, z);
        
        /// <summary>
        /// Returns cvec4.gbb swizzling (equivalent to cvec4.yzz).
        /// </summary>
        public cvec3 gbb => new cvec3(y, z, z);
        
        /// <summary>
        /// Returns cvec4.yzzx swizzling.
        /// </summary>
        public cvec4 yzzx => new cvec4(y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.gbbr swizzling (equivalent to cvec4.yzzx).
        /// </summary>
        public cvec4 gbbr => new cvec4(y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.yzzxx swizzling.
        /// </summary>
        public cvec5 yzzxx => new cvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.gbbrr swizzling (equivalent to cvec4.yzzxx).
        /// </summary>
        public cvec5 gbbrr => new cvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.yzzxy swizzling.
        /// </summary>
        public cvec5 yzzxy => new cvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.gbbrg swizzling (equivalent to cvec4.yzzxy).
        /// </summary>
        public cvec5 gbbrg => new cvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.yzzxz swizzling.
        /// </summary>
        public cvec5 yzzxz => new cvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.gbbrb swizzling (equivalent to cvec4.yzzxz).
        /// </summary>
        public cvec5 gbbrb => new cvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.yzzxw swizzling.
        /// </summary>
        public cvec5 yzzxw => new cvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.gbbra swizzling (equivalent to cvec4.yzzxw).
        /// </summary>
        public cvec5 gbbra => new cvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.yzzy swizzling.
        /// </summary>
        public cvec4 yzzy => new cvec4(y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.gbbg swizzling (equivalent to cvec4.yzzy).
        /// </summary>
        public cvec4 gbbg => new cvec4(y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.yzzyx swizzling.
        /// </summary>
        public cvec5 yzzyx => new cvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.gbbgr swizzling (equivalent to cvec4.yzzyx).
        /// </summary>
        public cvec5 gbbgr => new cvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.yzzyy swizzling.
        /// </summary>
        public cvec5 yzzyy => new cvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.gbbgg swizzling (equivalent to cvec4.yzzyy).
        /// </summary>
        public cvec5 gbbgg => new cvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.yzzyz swizzling.
        /// </summary>
        public cvec5 yzzyz => new cvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.gbbgb swizzling (equivalent to cvec4.yzzyz).
        /// </summary>
        public cvec5 gbbgb => new cvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.yzzyw swizzling.
        /// </summary>
        public cvec5 yzzyw => new cvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.gbbga swizzling (equivalent to cvec4.yzzyw).
        /// </summary>
        public cvec5 gbbga => new cvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.yzzz swizzling.
        /// </summary>
        public cvec4 yzzz => new cvec4(y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.gbbb swizzling (equivalent to cvec4.yzzz).
        /// </summary>
        public cvec4 gbbb => new cvec4(y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.yzzzx swizzling.
        /// </summary>
        public cvec5 yzzzx => new cvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.gbbbr swizzling (equivalent to cvec4.yzzzx).
        /// </summary>
        public cvec5 gbbbr => new cvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.yzzzy swizzling.
        /// </summary>
        public cvec5 yzzzy => new cvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.gbbbg swizzling (equivalent to cvec4.yzzzy).
        /// </summary>
        public cvec5 gbbbg => new cvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.yzzzz swizzling.
        /// </summary>
        public cvec5 yzzzz => new cvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.gbbbb swizzling (equivalent to cvec4.yzzzz).
        /// </summary>
        public cvec5 gbbbb => new cvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.yzzzw swizzling.
        /// </summary>
        public cvec5 yzzzw => new cvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.gbbba swizzling (equivalent to cvec4.yzzzw).
        /// </summary>
        public cvec5 gbbba => new cvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.yzzw swizzling.
        /// </summary>
        public cvec4 yzzw => new cvec4(y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.gbba swizzling (equivalent to cvec4.yzzw).
        /// </summary>
        public cvec4 gbba => new cvec4(y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.yzzwx swizzling.
        /// </summary>
        public cvec5 yzzwx => new cvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.gbbar swizzling (equivalent to cvec4.yzzwx).
        /// </summary>
        public cvec5 gbbar => new cvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.yzzwy swizzling.
        /// </summary>
        public cvec5 yzzwy => new cvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.gbbag swizzling (equivalent to cvec4.yzzwy).
        /// </summary>
        public cvec5 gbbag => new cvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.yzzwz swizzling.
        /// </summary>
        public cvec5 yzzwz => new cvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.gbbab swizzling (equivalent to cvec4.yzzwz).
        /// </summary>
        public cvec5 gbbab => new cvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.yzzww swizzling.
        /// </summary>
        public cvec5 yzzww => new cvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.gbbaa swizzling (equivalent to cvec4.yzzww).
        /// </summary>
        public cvec5 gbbaa => new cvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.yzw swizzling.
        /// </summary>
        public cvec3 yzw => new cvec3(y, z, w);
        
        /// <summary>
        /// Returns cvec4.gba swizzling (equivalent to cvec4.yzw).
        /// </summary>
        public cvec3 gba => new cvec3(y, z, w);
        
        /// <summary>
        /// Returns cvec4.yzwx swizzling.
        /// </summary>
        public cvec4 yzwx => new cvec4(y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.gbar swizzling (equivalent to cvec4.yzwx).
        /// </summary>
        public cvec4 gbar => new cvec4(y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.yzwxx swizzling.
        /// </summary>
        public cvec5 yzwxx => new cvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.gbarr swizzling (equivalent to cvec4.yzwxx).
        /// </summary>
        public cvec5 gbarr => new cvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.yzwxy swizzling.
        /// </summary>
        public cvec5 yzwxy => new cvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.gbarg swizzling (equivalent to cvec4.yzwxy).
        /// </summary>
        public cvec5 gbarg => new cvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.yzwxz swizzling.
        /// </summary>
        public cvec5 yzwxz => new cvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.gbarb swizzling (equivalent to cvec4.yzwxz).
        /// </summary>
        public cvec5 gbarb => new cvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.yzwxw swizzling.
        /// </summary>
        public cvec5 yzwxw => new cvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.gbara swizzling (equivalent to cvec4.yzwxw).
        /// </summary>
        public cvec5 gbara => new cvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.yzwy swizzling.
        /// </summary>
        public cvec4 yzwy => new cvec4(y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.gbag swizzling (equivalent to cvec4.yzwy).
        /// </summary>
        public cvec4 gbag => new cvec4(y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.yzwyx swizzling.
        /// </summary>
        public cvec5 yzwyx => new cvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.gbagr swizzling (equivalent to cvec4.yzwyx).
        /// </summary>
        public cvec5 gbagr => new cvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.yzwyy swizzling.
        /// </summary>
        public cvec5 yzwyy => new cvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.gbagg swizzling (equivalent to cvec4.yzwyy).
        /// </summary>
        public cvec5 gbagg => new cvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.yzwyz swizzling.
        /// </summary>
        public cvec5 yzwyz => new cvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.gbagb swizzling (equivalent to cvec4.yzwyz).
        /// </summary>
        public cvec5 gbagb => new cvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.yzwyw swizzling.
        /// </summary>
        public cvec5 yzwyw => new cvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.gbaga swizzling (equivalent to cvec4.yzwyw).
        /// </summary>
        public cvec5 gbaga => new cvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.yzwz swizzling.
        /// </summary>
        public cvec4 yzwz => new cvec4(y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.gbab swizzling (equivalent to cvec4.yzwz).
        /// </summary>
        public cvec4 gbab => new cvec4(y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.yzwzx swizzling.
        /// </summary>
        public cvec5 yzwzx => new cvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.gbabr swizzling (equivalent to cvec4.yzwzx).
        /// </summary>
        public cvec5 gbabr => new cvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.yzwzy swizzling.
        /// </summary>
        public cvec5 yzwzy => new cvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.gbabg swizzling (equivalent to cvec4.yzwzy).
        /// </summary>
        public cvec5 gbabg => new cvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.yzwzz swizzling.
        /// </summary>
        public cvec5 yzwzz => new cvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.gbabb swizzling (equivalent to cvec4.yzwzz).
        /// </summary>
        public cvec5 gbabb => new cvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.yzwzw swizzling.
        /// </summary>
        public cvec5 yzwzw => new cvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.gbaba swizzling (equivalent to cvec4.yzwzw).
        /// </summary>
        public cvec5 gbaba => new cvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.yzww swizzling.
        /// </summary>
        public cvec4 yzww => new cvec4(y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.gbaa swizzling (equivalent to cvec4.yzww).
        /// </summary>
        public cvec4 gbaa => new cvec4(y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.yzwwx swizzling.
        /// </summary>
        public cvec5 yzwwx => new cvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.gbaar swizzling (equivalent to cvec4.yzwwx).
        /// </summary>
        public cvec5 gbaar => new cvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.yzwwy swizzling.
        /// </summary>
        public cvec5 yzwwy => new cvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.gbaag swizzling (equivalent to cvec4.yzwwy).
        /// </summary>
        public cvec5 gbaag => new cvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.yzwwz swizzling.
        /// </summary>
        public cvec5 yzwwz => new cvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.gbaab swizzling (equivalent to cvec4.yzwwz).
        /// </summary>
        public cvec5 gbaab => new cvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.yzwww swizzling.
        /// </summary>
        public cvec5 yzwww => new cvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.gbaaa swizzling (equivalent to cvec4.yzwww).
        /// </summary>
        public cvec5 gbaaa => new cvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.yw swizzling.
        /// </summary>
        public cvec2 yw => new cvec2(y, w);
        
        /// <summary>
        /// Returns cvec4.ga swizzling (equivalent to cvec4.yw).
        /// </summary>
        public cvec2 ga => new cvec2(y, w);
        
        /// <summary>
        /// Returns cvec4.ywx swizzling.
        /// </summary>
        public cvec3 ywx => new cvec3(y, w, x);
        
        /// <summary>
        /// Returns cvec4.gar swizzling (equivalent to cvec4.ywx).
        /// </summary>
        public cvec3 gar => new cvec3(y, w, x);
        
        /// <summary>
        /// Returns cvec4.ywxx swizzling.
        /// </summary>
        public cvec4 ywxx => new cvec4(y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.garr swizzling (equivalent to cvec4.ywxx).
        /// </summary>
        public cvec4 garr => new cvec4(y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.ywxxx swizzling.
        /// </summary>
        public cvec5 ywxxx => new cvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.garrr swizzling (equivalent to cvec4.ywxxx).
        /// </summary>
        public cvec5 garrr => new cvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.ywxxy swizzling.
        /// </summary>
        public cvec5 ywxxy => new cvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.garrg swizzling (equivalent to cvec4.ywxxy).
        /// </summary>
        public cvec5 garrg => new cvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.ywxxz swizzling.
        /// </summary>
        public cvec5 ywxxz => new cvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.garrb swizzling (equivalent to cvec4.ywxxz).
        /// </summary>
        public cvec5 garrb => new cvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.ywxxw swizzling.
        /// </summary>
        public cvec5 ywxxw => new cvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.garra swizzling (equivalent to cvec4.ywxxw).
        /// </summary>
        public cvec5 garra => new cvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.ywxy swizzling.
        /// </summary>
        public cvec4 ywxy => new cvec4(y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.garg swizzling (equivalent to cvec4.ywxy).
        /// </summary>
        public cvec4 garg => new cvec4(y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.ywxyx swizzling.
        /// </summary>
        public cvec5 ywxyx => new cvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.gargr swizzling (equivalent to cvec4.ywxyx).
        /// </summary>
        public cvec5 gargr => new cvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.ywxyy swizzling.
        /// </summary>
        public cvec5 ywxyy => new cvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.gargg swizzling (equivalent to cvec4.ywxyy).
        /// </summary>
        public cvec5 gargg => new cvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.ywxyz swizzling.
        /// </summary>
        public cvec5 ywxyz => new cvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.gargb swizzling (equivalent to cvec4.ywxyz).
        /// </summary>
        public cvec5 gargb => new cvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.ywxyw swizzling.
        /// </summary>
        public cvec5 ywxyw => new cvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.garga swizzling (equivalent to cvec4.ywxyw).
        /// </summary>
        public cvec5 garga => new cvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.ywxz swizzling.
        /// </summary>
        public cvec4 ywxz => new cvec4(y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.garb swizzling (equivalent to cvec4.ywxz).
        /// </summary>
        public cvec4 garb => new cvec4(y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.ywxzx swizzling.
        /// </summary>
        public cvec5 ywxzx => new cvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.garbr swizzling (equivalent to cvec4.ywxzx).
        /// </summary>
        public cvec5 garbr => new cvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.ywxzy swizzling.
        /// </summary>
        public cvec5 ywxzy => new cvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.garbg swizzling (equivalent to cvec4.ywxzy).
        /// </summary>
        public cvec5 garbg => new cvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.ywxzz swizzling.
        /// </summary>
        public cvec5 ywxzz => new cvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.garbb swizzling (equivalent to cvec4.ywxzz).
        /// </summary>
        public cvec5 garbb => new cvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.ywxzw swizzling.
        /// </summary>
        public cvec5 ywxzw => new cvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.garba swizzling (equivalent to cvec4.ywxzw).
        /// </summary>
        public cvec5 garba => new cvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.ywxw swizzling.
        /// </summary>
        public cvec4 ywxw => new cvec4(y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.gara swizzling (equivalent to cvec4.ywxw).
        /// </summary>
        public cvec4 gara => new cvec4(y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.ywxwx swizzling.
        /// </summary>
        public cvec5 ywxwx => new cvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.garar swizzling (equivalent to cvec4.ywxwx).
        /// </summary>
        public cvec5 garar => new cvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.ywxwy swizzling.
        /// </summary>
        public cvec5 ywxwy => new cvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.garag swizzling (equivalent to cvec4.ywxwy).
        /// </summary>
        public cvec5 garag => new cvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.ywxwz swizzling.
        /// </summary>
        public cvec5 ywxwz => new cvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.garab swizzling (equivalent to cvec4.ywxwz).
        /// </summary>
        public cvec5 garab => new cvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.ywxww swizzling.
        /// </summary>
        public cvec5 ywxww => new cvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.garaa swizzling (equivalent to cvec4.ywxww).
        /// </summary>
        public cvec5 garaa => new cvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.ywy swizzling.
        /// </summary>
        public cvec3 ywy => new cvec3(y, w, y);
        
        /// <summary>
        /// Returns cvec4.gag swizzling (equivalent to cvec4.ywy).
        /// </summary>
        public cvec3 gag => new cvec3(y, w, y);
        
        /// <summary>
        /// Returns cvec4.ywyx swizzling.
        /// </summary>
        public cvec4 ywyx => new cvec4(y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.gagr swizzling (equivalent to cvec4.ywyx).
        /// </summary>
        public cvec4 gagr => new cvec4(y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.ywyxx swizzling.
        /// </summary>
        public cvec5 ywyxx => new cvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.gagrr swizzling (equivalent to cvec4.ywyxx).
        /// </summary>
        public cvec5 gagrr => new cvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.ywyxy swizzling.
        /// </summary>
        public cvec5 ywyxy => new cvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.gagrg swizzling (equivalent to cvec4.ywyxy).
        /// </summary>
        public cvec5 gagrg => new cvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.ywyxz swizzling.
        /// </summary>
        public cvec5 ywyxz => new cvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.gagrb swizzling (equivalent to cvec4.ywyxz).
        /// </summary>
        public cvec5 gagrb => new cvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.ywyxw swizzling.
        /// </summary>
        public cvec5 ywyxw => new cvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.gagra swizzling (equivalent to cvec4.ywyxw).
        /// </summary>
        public cvec5 gagra => new cvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.ywyy swizzling.
        /// </summary>
        public cvec4 ywyy => new cvec4(y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.gagg swizzling (equivalent to cvec4.ywyy).
        /// </summary>
        public cvec4 gagg => new cvec4(y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.ywyyx swizzling.
        /// </summary>
        public cvec5 ywyyx => new cvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.gaggr swizzling (equivalent to cvec4.ywyyx).
        /// </summary>
        public cvec5 gaggr => new cvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.ywyyy swizzling.
        /// </summary>
        public cvec5 ywyyy => new cvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.gaggg swizzling (equivalent to cvec4.ywyyy).
        /// </summary>
        public cvec5 gaggg => new cvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.ywyyz swizzling.
        /// </summary>
        public cvec5 ywyyz => new cvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.gaggb swizzling (equivalent to cvec4.ywyyz).
        /// </summary>
        public cvec5 gaggb => new cvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.ywyyw swizzling.
        /// </summary>
        public cvec5 ywyyw => new cvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.gagga swizzling (equivalent to cvec4.ywyyw).
        /// </summary>
        public cvec5 gagga => new cvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.ywyz swizzling.
        /// </summary>
        public cvec4 ywyz => new cvec4(y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.gagb swizzling (equivalent to cvec4.ywyz).
        /// </summary>
        public cvec4 gagb => new cvec4(y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.ywyzx swizzling.
        /// </summary>
        public cvec5 ywyzx => new cvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.gagbr swizzling (equivalent to cvec4.ywyzx).
        /// </summary>
        public cvec5 gagbr => new cvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.ywyzy swizzling.
        /// </summary>
        public cvec5 ywyzy => new cvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.gagbg swizzling (equivalent to cvec4.ywyzy).
        /// </summary>
        public cvec5 gagbg => new cvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.ywyzz swizzling.
        /// </summary>
        public cvec5 ywyzz => new cvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.gagbb swizzling (equivalent to cvec4.ywyzz).
        /// </summary>
        public cvec5 gagbb => new cvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.ywyzw swizzling.
        /// </summary>
        public cvec5 ywyzw => new cvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.gagba swizzling (equivalent to cvec4.ywyzw).
        /// </summary>
        public cvec5 gagba => new cvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.ywyw swizzling.
        /// </summary>
        public cvec4 ywyw => new cvec4(y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.gaga swizzling (equivalent to cvec4.ywyw).
        /// </summary>
        public cvec4 gaga => new cvec4(y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.ywywx swizzling.
        /// </summary>
        public cvec5 ywywx => new cvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.gagar swizzling (equivalent to cvec4.ywywx).
        /// </summary>
        public cvec5 gagar => new cvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.ywywy swizzling.
        /// </summary>
        public cvec5 ywywy => new cvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.gagag swizzling (equivalent to cvec4.ywywy).
        /// </summary>
        public cvec5 gagag => new cvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.ywywz swizzling.
        /// </summary>
        public cvec5 ywywz => new cvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.gagab swizzling (equivalent to cvec4.ywywz).
        /// </summary>
        public cvec5 gagab => new cvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.ywyww swizzling.
        /// </summary>
        public cvec5 ywyww => new cvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.gagaa swizzling (equivalent to cvec4.ywyww).
        /// </summary>
        public cvec5 gagaa => new cvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.ywz swizzling.
        /// </summary>
        public cvec3 ywz => new cvec3(y, w, z);
        
        /// <summary>
        /// Returns cvec4.gab swizzling (equivalent to cvec4.ywz).
        /// </summary>
        public cvec3 gab => new cvec3(y, w, z);
        
        /// <summary>
        /// Returns cvec4.ywzx swizzling.
        /// </summary>
        public cvec4 ywzx => new cvec4(y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.gabr swizzling (equivalent to cvec4.ywzx).
        /// </summary>
        public cvec4 gabr => new cvec4(y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.ywzxx swizzling.
        /// </summary>
        public cvec5 ywzxx => new cvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.gabrr swizzling (equivalent to cvec4.ywzxx).
        /// </summary>
        public cvec5 gabrr => new cvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.ywzxy swizzling.
        /// </summary>
        public cvec5 ywzxy => new cvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.gabrg swizzling (equivalent to cvec4.ywzxy).
        /// </summary>
        public cvec5 gabrg => new cvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.ywzxz swizzling.
        /// </summary>
        public cvec5 ywzxz => new cvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.gabrb swizzling (equivalent to cvec4.ywzxz).
        /// </summary>
        public cvec5 gabrb => new cvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.ywzxw swizzling.
        /// </summary>
        public cvec5 ywzxw => new cvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.gabra swizzling (equivalent to cvec4.ywzxw).
        /// </summary>
        public cvec5 gabra => new cvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.ywzy swizzling.
        /// </summary>
        public cvec4 ywzy => new cvec4(y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.gabg swizzling (equivalent to cvec4.ywzy).
        /// </summary>
        public cvec4 gabg => new cvec4(y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.ywzyx swizzling.
        /// </summary>
        public cvec5 ywzyx => new cvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.gabgr swizzling (equivalent to cvec4.ywzyx).
        /// </summary>
        public cvec5 gabgr => new cvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.ywzyy swizzling.
        /// </summary>
        public cvec5 ywzyy => new cvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.gabgg swizzling (equivalent to cvec4.ywzyy).
        /// </summary>
        public cvec5 gabgg => new cvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.ywzyz swizzling.
        /// </summary>
        public cvec5 ywzyz => new cvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.gabgb swizzling (equivalent to cvec4.ywzyz).
        /// </summary>
        public cvec5 gabgb => new cvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.ywzyw swizzling.
        /// </summary>
        public cvec5 ywzyw => new cvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.gabga swizzling (equivalent to cvec4.ywzyw).
        /// </summary>
        public cvec5 gabga => new cvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.ywzz swizzling.
        /// </summary>
        public cvec4 ywzz => new cvec4(y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.gabb swizzling (equivalent to cvec4.ywzz).
        /// </summary>
        public cvec4 gabb => new cvec4(y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.ywzzx swizzling.
        /// </summary>
        public cvec5 ywzzx => new cvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.gabbr swizzling (equivalent to cvec4.ywzzx).
        /// </summary>
        public cvec5 gabbr => new cvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.ywzzy swizzling.
        /// </summary>
        public cvec5 ywzzy => new cvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.gabbg swizzling (equivalent to cvec4.ywzzy).
        /// </summary>
        public cvec5 gabbg => new cvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.ywzzz swizzling.
        /// </summary>
        public cvec5 ywzzz => new cvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.gabbb swizzling (equivalent to cvec4.ywzzz).
        /// </summary>
        public cvec5 gabbb => new cvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.ywzzw swizzling.
        /// </summary>
        public cvec5 ywzzw => new cvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.gabba swizzling (equivalent to cvec4.ywzzw).
        /// </summary>
        public cvec5 gabba => new cvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.ywzw swizzling.
        /// </summary>
        public cvec4 ywzw => new cvec4(y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.gaba swizzling (equivalent to cvec4.ywzw).
        /// </summary>
        public cvec4 gaba => new cvec4(y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.ywzwx swizzling.
        /// </summary>
        public cvec5 ywzwx => new cvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.gabar swizzling (equivalent to cvec4.ywzwx).
        /// </summary>
        public cvec5 gabar => new cvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.ywzwy swizzling.
        /// </summary>
        public cvec5 ywzwy => new cvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.gabag swizzling (equivalent to cvec4.ywzwy).
        /// </summary>
        public cvec5 gabag => new cvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.ywzwz swizzling.
        /// </summary>
        public cvec5 ywzwz => new cvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.gabab swizzling (equivalent to cvec4.ywzwz).
        /// </summary>
        public cvec5 gabab => new cvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.ywzww swizzling.
        /// </summary>
        public cvec5 ywzww => new cvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.gabaa swizzling (equivalent to cvec4.ywzww).
        /// </summary>
        public cvec5 gabaa => new cvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.yww swizzling.
        /// </summary>
        public cvec3 yww => new cvec3(y, w, w);
        
        /// <summary>
        /// Returns cvec4.gaa swizzling (equivalent to cvec4.yww).
        /// </summary>
        public cvec3 gaa => new cvec3(y, w, w);
        
        /// <summary>
        /// Returns cvec4.ywwx swizzling.
        /// </summary>
        public cvec4 ywwx => new cvec4(y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.gaar swizzling (equivalent to cvec4.ywwx).
        /// </summary>
        public cvec4 gaar => new cvec4(y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.ywwxx swizzling.
        /// </summary>
        public cvec5 ywwxx => new cvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.gaarr swizzling (equivalent to cvec4.ywwxx).
        /// </summary>
        public cvec5 gaarr => new cvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.ywwxy swizzling.
        /// </summary>
        public cvec5 ywwxy => new cvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.gaarg swizzling (equivalent to cvec4.ywwxy).
        /// </summary>
        public cvec5 gaarg => new cvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.ywwxz swizzling.
        /// </summary>
        public cvec5 ywwxz => new cvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.gaarb swizzling (equivalent to cvec4.ywwxz).
        /// </summary>
        public cvec5 gaarb => new cvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.ywwxw swizzling.
        /// </summary>
        public cvec5 ywwxw => new cvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.gaara swizzling (equivalent to cvec4.ywwxw).
        /// </summary>
        public cvec5 gaara => new cvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.ywwy swizzling.
        /// </summary>
        public cvec4 ywwy => new cvec4(y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.gaag swizzling (equivalent to cvec4.ywwy).
        /// </summary>
        public cvec4 gaag => new cvec4(y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.ywwyx swizzling.
        /// </summary>
        public cvec5 ywwyx => new cvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.gaagr swizzling (equivalent to cvec4.ywwyx).
        /// </summary>
        public cvec5 gaagr => new cvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.ywwyy swizzling.
        /// </summary>
        public cvec5 ywwyy => new cvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.gaagg swizzling (equivalent to cvec4.ywwyy).
        /// </summary>
        public cvec5 gaagg => new cvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.ywwyz swizzling.
        /// </summary>
        public cvec5 ywwyz => new cvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.gaagb swizzling (equivalent to cvec4.ywwyz).
        /// </summary>
        public cvec5 gaagb => new cvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.ywwyw swizzling.
        /// </summary>
        public cvec5 ywwyw => new cvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.gaaga swizzling (equivalent to cvec4.ywwyw).
        /// </summary>
        public cvec5 gaaga => new cvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.ywwz swizzling.
        /// </summary>
        public cvec4 ywwz => new cvec4(y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.gaab swizzling (equivalent to cvec4.ywwz).
        /// </summary>
        public cvec4 gaab => new cvec4(y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.ywwzx swizzling.
        /// </summary>
        public cvec5 ywwzx => new cvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.gaabr swizzling (equivalent to cvec4.ywwzx).
        /// </summary>
        public cvec5 gaabr => new cvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.ywwzy swizzling.
        /// </summary>
        public cvec5 ywwzy => new cvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.gaabg swizzling (equivalent to cvec4.ywwzy).
        /// </summary>
        public cvec5 gaabg => new cvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.ywwzz swizzling.
        /// </summary>
        public cvec5 ywwzz => new cvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.gaabb swizzling (equivalent to cvec4.ywwzz).
        /// </summary>
        public cvec5 gaabb => new cvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.ywwzw swizzling.
        /// </summary>
        public cvec5 ywwzw => new cvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.gaaba swizzling (equivalent to cvec4.ywwzw).
        /// </summary>
        public cvec5 gaaba => new cvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.ywww swizzling.
        /// </summary>
        public cvec4 ywww => new cvec4(y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.gaaa swizzling (equivalent to cvec4.ywww).
        /// </summary>
        public cvec4 gaaa => new cvec4(y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.ywwwx swizzling.
        /// </summary>
        public cvec5 ywwwx => new cvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.gaaar swizzling (equivalent to cvec4.ywwwx).
        /// </summary>
        public cvec5 gaaar => new cvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.ywwwy swizzling.
        /// </summary>
        public cvec5 ywwwy => new cvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.gaaag swizzling (equivalent to cvec4.ywwwy).
        /// </summary>
        public cvec5 gaaag => new cvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.ywwwz swizzling.
        /// </summary>
        public cvec5 ywwwz => new cvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.gaaab swizzling (equivalent to cvec4.ywwwz).
        /// </summary>
        public cvec5 gaaab => new cvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.ywwww swizzling.
        /// </summary>
        public cvec5 ywwww => new cvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns cvec4.gaaaa swizzling (equivalent to cvec4.ywwww).
        /// </summary>
        public cvec5 gaaaa => new cvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns cvec4.zx swizzling.
        /// </summary>
        public cvec2 zx => new cvec2(z, x);
        
        /// <summary>
        /// Returns cvec4.br swizzling (equivalent to cvec4.zx).
        /// </summary>
        public cvec2 br => new cvec2(z, x);
        
        /// <summary>
        /// Returns cvec4.zxx swizzling.
        /// </summary>
        public cvec3 zxx => new cvec3(z, x, x);
        
        /// <summary>
        /// Returns cvec4.brr swizzling (equivalent to cvec4.zxx).
        /// </summary>
        public cvec3 brr => new cvec3(z, x, x);
        
        /// <summary>
        /// Returns cvec4.zxxx swizzling.
        /// </summary>
        public cvec4 zxxx => new cvec4(z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.brrr swizzling (equivalent to cvec4.zxxx).
        /// </summary>
        public cvec4 brrr => new cvec4(z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.zxxxx swizzling.
        /// </summary>
        public cvec5 zxxxx => new cvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.brrrr swizzling (equivalent to cvec4.zxxxx).
        /// </summary>
        public cvec5 brrrr => new cvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.zxxxy swizzling.
        /// </summary>
        public cvec5 zxxxy => new cvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.brrrg swizzling (equivalent to cvec4.zxxxy).
        /// </summary>
        public cvec5 brrrg => new cvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.zxxxz swizzling.
        /// </summary>
        public cvec5 zxxxz => new cvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.brrrb swizzling (equivalent to cvec4.zxxxz).
        /// </summary>
        public cvec5 brrrb => new cvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.zxxxw swizzling.
        /// </summary>
        public cvec5 zxxxw => new cvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.brrra swizzling (equivalent to cvec4.zxxxw).
        /// </summary>
        public cvec5 brrra => new cvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.zxxy swizzling.
        /// </summary>
        public cvec4 zxxy => new cvec4(z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.brrg swizzling (equivalent to cvec4.zxxy).
        /// </summary>
        public cvec4 brrg => new cvec4(z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.zxxyx swizzling.
        /// </summary>
        public cvec5 zxxyx => new cvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.brrgr swizzling (equivalent to cvec4.zxxyx).
        /// </summary>
        public cvec5 brrgr => new cvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.zxxyy swizzling.
        /// </summary>
        public cvec5 zxxyy => new cvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.brrgg swizzling (equivalent to cvec4.zxxyy).
        /// </summary>
        public cvec5 brrgg => new cvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.zxxyz swizzling.
        /// </summary>
        public cvec5 zxxyz => new cvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.brrgb swizzling (equivalent to cvec4.zxxyz).
        /// </summary>
        public cvec5 brrgb => new cvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.zxxyw swizzling.
        /// </summary>
        public cvec5 zxxyw => new cvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.brrga swizzling (equivalent to cvec4.zxxyw).
        /// </summary>
        public cvec5 brrga => new cvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.zxxz swizzling.
        /// </summary>
        public cvec4 zxxz => new cvec4(z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.brrb swizzling (equivalent to cvec4.zxxz).
        /// </summary>
        public cvec4 brrb => new cvec4(z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.zxxzx swizzling.
        /// </summary>
        public cvec5 zxxzx => new cvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.brrbr swizzling (equivalent to cvec4.zxxzx).
        /// </summary>
        public cvec5 brrbr => new cvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.zxxzy swizzling.
        /// </summary>
        public cvec5 zxxzy => new cvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.brrbg swizzling (equivalent to cvec4.zxxzy).
        /// </summary>
        public cvec5 brrbg => new cvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.zxxzz swizzling.
        /// </summary>
        public cvec5 zxxzz => new cvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.brrbb swizzling (equivalent to cvec4.zxxzz).
        /// </summary>
        public cvec5 brrbb => new cvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.zxxzw swizzling.
        /// </summary>
        public cvec5 zxxzw => new cvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.brrba swizzling (equivalent to cvec4.zxxzw).
        /// </summary>
        public cvec5 brrba => new cvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.zxxw swizzling.
        /// </summary>
        public cvec4 zxxw => new cvec4(z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.brra swizzling (equivalent to cvec4.zxxw).
        /// </summary>
        public cvec4 brra => new cvec4(z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.zxxwx swizzling.
        /// </summary>
        public cvec5 zxxwx => new cvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.brrar swizzling (equivalent to cvec4.zxxwx).
        /// </summary>
        public cvec5 brrar => new cvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.zxxwy swizzling.
        /// </summary>
        public cvec5 zxxwy => new cvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.brrag swizzling (equivalent to cvec4.zxxwy).
        /// </summary>
        public cvec5 brrag => new cvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.zxxwz swizzling.
        /// </summary>
        public cvec5 zxxwz => new cvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.brrab swizzling (equivalent to cvec4.zxxwz).
        /// </summary>
        public cvec5 brrab => new cvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.zxxww swizzling.
        /// </summary>
        public cvec5 zxxww => new cvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.brraa swizzling (equivalent to cvec4.zxxww).
        /// </summary>
        public cvec5 brraa => new cvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.zxy swizzling.
        /// </summary>
        public cvec3 zxy => new cvec3(z, x, y);
        
        /// <summary>
        /// Returns cvec4.brg swizzling (equivalent to cvec4.zxy).
        /// </summary>
        public cvec3 brg => new cvec3(z, x, y);
        
        /// <summary>
        /// Returns cvec4.zxyx swizzling.
        /// </summary>
        public cvec4 zxyx => new cvec4(z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.brgr swizzling (equivalent to cvec4.zxyx).
        /// </summary>
        public cvec4 brgr => new cvec4(z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.zxyxx swizzling.
        /// </summary>
        public cvec5 zxyxx => new cvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.brgrr swizzling (equivalent to cvec4.zxyxx).
        /// </summary>
        public cvec5 brgrr => new cvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.zxyxy swizzling.
        /// </summary>
        public cvec5 zxyxy => new cvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.brgrg swizzling (equivalent to cvec4.zxyxy).
        /// </summary>
        public cvec5 brgrg => new cvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.zxyxz swizzling.
        /// </summary>
        public cvec5 zxyxz => new cvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.brgrb swizzling (equivalent to cvec4.zxyxz).
        /// </summary>
        public cvec5 brgrb => new cvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.zxyxw swizzling.
        /// </summary>
        public cvec5 zxyxw => new cvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.brgra swizzling (equivalent to cvec4.zxyxw).
        /// </summary>
        public cvec5 brgra => new cvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.zxyy swizzling.
        /// </summary>
        public cvec4 zxyy => new cvec4(z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.brgg swizzling (equivalent to cvec4.zxyy).
        /// </summary>
        public cvec4 brgg => new cvec4(z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.zxyyx swizzling.
        /// </summary>
        public cvec5 zxyyx => new cvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.brggr swizzling (equivalent to cvec4.zxyyx).
        /// </summary>
        public cvec5 brggr => new cvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.zxyyy swizzling.
        /// </summary>
        public cvec5 zxyyy => new cvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.brggg swizzling (equivalent to cvec4.zxyyy).
        /// </summary>
        public cvec5 brggg => new cvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.zxyyz swizzling.
        /// </summary>
        public cvec5 zxyyz => new cvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.brggb swizzling (equivalent to cvec4.zxyyz).
        /// </summary>
        public cvec5 brggb => new cvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.zxyyw swizzling.
        /// </summary>
        public cvec5 zxyyw => new cvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.brgga swizzling (equivalent to cvec4.zxyyw).
        /// </summary>
        public cvec5 brgga => new cvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.zxyz swizzling.
        /// </summary>
        public cvec4 zxyz => new cvec4(z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.brgb swizzling (equivalent to cvec4.zxyz).
        /// </summary>
        public cvec4 brgb => new cvec4(z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.zxyzx swizzling.
        /// </summary>
        public cvec5 zxyzx => new cvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.brgbr swizzling (equivalent to cvec4.zxyzx).
        /// </summary>
        public cvec5 brgbr => new cvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.zxyzy swizzling.
        /// </summary>
        public cvec5 zxyzy => new cvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.brgbg swizzling (equivalent to cvec4.zxyzy).
        /// </summary>
        public cvec5 brgbg => new cvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.zxyzz swizzling.
        /// </summary>
        public cvec5 zxyzz => new cvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.brgbb swizzling (equivalent to cvec4.zxyzz).
        /// </summary>
        public cvec5 brgbb => new cvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.zxyzw swizzling.
        /// </summary>
        public cvec5 zxyzw => new cvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.brgba swizzling (equivalent to cvec4.zxyzw).
        /// </summary>
        public cvec5 brgba => new cvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.zxyw swizzling.
        /// </summary>
        public cvec4 zxyw => new cvec4(z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.brga swizzling (equivalent to cvec4.zxyw).
        /// </summary>
        public cvec4 brga => new cvec4(z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.zxywx swizzling.
        /// </summary>
        public cvec5 zxywx => new cvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.brgar swizzling (equivalent to cvec4.zxywx).
        /// </summary>
        public cvec5 brgar => new cvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.zxywy swizzling.
        /// </summary>
        public cvec5 zxywy => new cvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.brgag swizzling (equivalent to cvec4.zxywy).
        /// </summary>
        public cvec5 brgag => new cvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.zxywz swizzling.
        /// </summary>
        public cvec5 zxywz => new cvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.brgab swizzling (equivalent to cvec4.zxywz).
        /// </summary>
        public cvec5 brgab => new cvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.zxyww swizzling.
        /// </summary>
        public cvec5 zxyww => new cvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.brgaa swizzling (equivalent to cvec4.zxyww).
        /// </summary>
        public cvec5 brgaa => new cvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.zxz swizzling.
        /// </summary>
        public cvec3 zxz => new cvec3(z, x, z);
        
        /// <summary>
        /// Returns cvec4.brb swizzling (equivalent to cvec4.zxz).
        /// </summary>
        public cvec3 brb => new cvec3(z, x, z);
        
        /// <summary>
        /// Returns cvec4.zxzx swizzling.
        /// </summary>
        public cvec4 zxzx => new cvec4(z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.brbr swizzling (equivalent to cvec4.zxzx).
        /// </summary>
        public cvec4 brbr => new cvec4(z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.zxzxx swizzling.
        /// </summary>
        public cvec5 zxzxx => new cvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.brbrr swizzling (equivalent to cvec4.zxzxx).
        /// </summary>
        public cvec5 brbrr => new cvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.zxzxy swizzling.
        /// </summary>
        public cvec5 zxzxy => new cvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.brbrg swizzling (equivalent to cvec4.zxzxy).
        /// </summary>
        public cvec5 brbrg => new cvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.zxzxz swizzling.
        /// </summary>
        public cvec5 zxzxz => new cvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.brbrb swizzling (equivalent to cvec4.zxzxz).
        /// </summary>
        public cvec5 brbrb => new cvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.zxzxw swizzling.
        /// </summary>
        public cvec5 zxzxw => new cvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.brbra swizzling (equivalent to cvec4.zxzxw).
        /// </summary>
        public cvec5 brbra => new cvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.zxzy swizzling.
        /// </summary>
        public cvec4 zxzy => new cvec4(z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.brbg swizzling (equivalent to cvec4.zxzy).
        /// </summary>
        public cvec4 brbg => new cvec4(z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.zxzyx swizzling.
        /// </summary>
        public cvec5 zxzyx => new cvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.brbgr swizzling (equivalent to cvec4.zxzyx).
        /// </summary>
        public cvec5 brbgr => new cvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.zxzyy swizzling.
        /// </summary>
        public cvec5 zxzyy => new cvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.brbgg swizzling (equivalent to cvec4.zxzyy).
        /// </summary>
        public cvec5 brbgg => new cvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.zxzyz swizzling.
        /// </summary>
        public cvec5 zxzyz => new cvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.brbgb swizzling (equivalent to cvec4.zxzyz).
        /// </summary>
        public cvec5 brbgb => new cvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.zxzyw swizzling.
        /// </summary>
        public cvec5 zxzyw => new cvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.brbga swizzling (equivalent to cvec4.zxzyw).
        /// </summary>
        public cvec5 brbga => new cvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.zxzz swizzling.
        /// </summary>
        public cvec4 zxzz => new cvec4(z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.brbb swizzling (equivalent to cvec4.zxzz).
        /// </summary>
        public cvec4 brbb => new cvec4(z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.zxzzx swizzling.
        /// </summary>
        public cvec5 zxzzx => new cvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.brbbr swizzling (equivalent to cvec4.zxzzx).
        /// </summary>
        public cvec5 brbbr => new cvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.zxzzy swizzling.
        /// </summary>
        public cvec5 zxzzy => new cvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.brbbg swizzling (equivalent to cvec4.zxzzy).
        /// </summary>
        public cvec5 brbbg => new cvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.zxzzz swizzling.
        /// </summary>
        public cvec5 zxzzz => new cvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.brbbb swizzling (equivalent to cvec4.zxzzz).
        /// </summary>
        public cvec5 brbbb => new cvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.zxzzw swizzling.
        /// </summary>
        public cvec5 zxzzw => new cvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.brbba swizzling (equivalent to cvec4.zxzzw).
        /// </summary>
        public cvec5 brbba => new cvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.zxzw swizzling.
        /// </summary>
        public cvec4 zxzw => new cvec4(z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.brba swizzling (equivalent to cvec4.zxzw).
        /// </summary>
        public cvec4 brba => new cvec4(z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.zxzwx swizzling.
        /// </summary>
        public cvec5 zxzwx => new cvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.brbar swizzling (equivalent to cvec4.zxzwx).
        /// </summary>
        public cvec5 brbar => new cvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.zxzwy swizzling.
        /// </summary>
        public cvec5 zxzwy => new cvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.brbag swizzling (equivalent to cvec4.zxzwy).
        /// </summary>
        public cvec5 brbag => new cvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.zxzwz swizzling.
        /// </summary>
        public cvec5 zxzwz => new cvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.brbab swizzling (equivalent to cvec4.zxzwz).
        /// </summary>
        public cvec5 brbab => new cvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.zxzww swizzling.
        /// </summary>
        public cvec5 zxzww => new cvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.brbaa swizzling (equivalent to cvec4.zxzww).
        /// </summary>
        public cvec5 brbaa => new cvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.zxw swizzling.
        /// </summary>
        public cvec3 zxw => new cvec3(z, x, w);
        
        /// <summary>
        /// Returns cvec4.bra swizzling (equivalent to cvec4.zxw).
        /// </summary>
        public cvec3 bra => new cvec3(z, x, w);
        
        /// <summary>
        /// Returns cvec4.zxwx swizzling.
        /// </summary>
        public cvec4 zxwx => new cvec4(z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.brar swizzling (equivalent to cvec4.zxwx).
        /// </summary>
        public cvec4 brar => new cvec4(z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.zxwxx swizzling.
        /// </summary>
        public cvec5 zxwxx => new cvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.brarr swizzling (equivalent to cvec4.zxwxx).
        /// </summary>
        public cvec5 brarr => new cvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.zxwxy swizzling.
        /// </summary>
        public cvec5 zxwxy => new cvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.brarg swizzling (equivalent to cvec4.zxwxy).
        /// </summary>
        public cvec5 brarg => new cvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.zxwxz swizzling.
        /// </summary>
        public cvec5 zxwxz => new cvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.brarb swizzling (equivalent to cvec4.zxwxz).
        /// </summary>
        public cvec5 brarb => new cvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.zxwxw swizzling.
        /// </summary>
        public cvec5 zxwxw => new cvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.brara swizzling (equivalent to cvec4.zxwxw).
        /// </summary>
        public cvec5 brara => new cvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.zxwy swizzling.
        /// </summary>
        public cvec4 zxwy => new cvec4(z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.brag swizzling (equivalent to cvec4.zxwy).
        /// </summary>
        public cvec4 brag => new cvec4(z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.zxwyx swizzling.
        /// </summary>
        public cvec5 zxwyx => new cvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.bragr swizzling (equivalent to cvec4.zxwyx).
        /// </summary>
        public cvec5 bragr => new cvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.zxwyy swizzling.
        /// </summary>
        public cvec5 zxwyy => new cvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.bragg swizzling (equivalent to cvec4.zxwyy).
        /// </summary>
        public cvec5 bragg => new cvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.zxwyz swizzling.
        /// </summary>
        public cvec5 zxwyz => new cvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.bragb swizzling (equivalent to cvec4.zxwyz).
        /// </summary>
        public cvec5 bragb => new cvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.zxwyw swizzling.
        /// </summary>
        public cvec5 zxwyw => new cvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.braga swizzling (equivalent to cvec4.zxwyw).
        /// </summary>
        public cvec5 braga => new cvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.zxwz swizzling.
        /// </summary>
        public cvec4 zxwz => new cvec4(z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.brab swizzling (equivalent to cvec4.zxwz).
        /// </summary>
        public cvec4 brab => new cvec4(z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.zxwzx swizzling.
        /// </summary>
        public cvec5 zxwzx => new cvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.brabr swizzling (equivalent to cvec4.zxwzx).
        /// </summary>
        public cvec5 brabr => new cvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.zxwzy swizzling.
        /// </summary>
        public cvec5 zxwzy => new cvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.brabg swizzling (equivalent to cvec4.zxwzy).
        /// </summary>
        public cvec5 brabg => new cvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.zxwzz swizzling.
        /// </summary>
        public cvec5 zxwzz => new cvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.brabb swizzling (equivalent to cvec4.zxwzz).
        /// </summary>
        public cvec5 brabb => new cvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.zxwzw swizzling.
        /// </summary>
        public cvec5 zxwzw => new cvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.braba swizzling (equivalent to cvec4.zxwzw).
        /// </summary>
        public cvec5 braba => new cvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.zxww swizzling.
        /// </summary>
        public cvec4 zxww => new cvec4(z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.braa swizzling (equivalent to cvec4.zxww).
        /// </summary>
        public cvec4 braa => new cvec4(z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.zxwwx swizzling.
        /// </summary>
        public cvec5 zxwwx => new cvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.braar swizzling (equivalent to cvec4.zxwwx).
        /// </summary>
        public cvec5 braar => new cvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.zxwwy swizzling.
        /// </summary>
        public cvec5 zxwwy => new cvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.braag swizzling (equivalent to cvec4.zxwwy).
        /// </summary>
        public cvec5 braag => new cvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.zxwwz swizzling.
        /// </summary>
        public cvec5 zxwwz => new cvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.braab swizzling (equivalent to cvec4.zxwwz).
        /// </summary>
        public cvec5 braab => new cvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.zxwww swizzling.
        /// </summary>
        public cvec5 zxwww => new cvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.braaa swizzling (equivalent to cvec4.zxwww).
        /// </summary>
        public cvec5 braaa => new cvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.zy swizzling.
        /// </summary>
        public cvec2 zy => new cvec2(z, y);
        
        /// <summary>
        /// Returns cvec4.bg swizzling (equivalent to cvec4.zy).
        /// </summary>
        public cvec2 bg => new cvec2(z, y);
        
        /// <summary>
        /// Returns cvec4.zyx swizzling.
        /// </summary>
        public cvec3 zyx => new cvec3(z, y, x);
        
        /// <summary>
        /// Returns cvec4.bgr swizzling (equivalent to cvec4.zyx).
        /// </summary>
        public cvec3 bgr => new cvec3(z, y, x);
        
        /// <summary>
        /// Returns cvec4.zyxx swizzling.
        /// </summary>
        public cvec4 zyxx => new cvec4(z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.bgrr swizzling (equivalent to cvec4.zyxx).
        /// </summary>
        public cvec4 bgrr => new cvec4(z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.zyxxx swizzling.
        /// </summary>
        public cvec5 zyxxx => new cvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.bgrrr swizzling (equivalent to cvec4.zyxxx).
        /// </summary>
        public cvec5 bgrrr => new cvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.zyxxy swizzling.
        /// </summary>
        public cvec5 zyxxy => new cvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.bgrrg swizzling (equivalent to cvec4.zyxxy).
        /// </summary>
        public cvec5 bgrrg => new cvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.zyxxz swizzling.
        /// </summary>
        public cvec5 zyxxz => new cvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.bgrrb swizzling (equivalent to cvec4.zyxxz).
        /// </summary>
        public cvec5 bgrrb => new cvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.zyxxw swizzling.
        /// </summary>
        public cvec5 zyxxw => new cvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.bgrra swizzling (equivalent to cvec4.zyxxw).
        /// </summary>
        public cvec5 bgrra => new cvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.zyxy swizzling.
        /// </summary>
        public cvec4 zyxy => new cvec4(z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.bgrg swizzling (equivalent to cvec4.zyxy).
        /// </summary>
        public cvec4 bgrg => new cvec4(z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.zyxyx swizzling.
        /// </summary>
        public cvec5 zyxyx => new cvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.bgrgr swizzling (equivalent to cvec4.zyxyx).
        /// </summary>
        public cvec5 bgrgr => new cvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.zyxyy swizzling.
        /// </summary>
        public cvec5 zyxyy => new cvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.bgrgg swizzling (equivalent to cvec4.zyxyy).
        /// </summary>
        public cvec5 bgrgg => new cvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.zyxyz swizzling.
        /// </summary>
        public cvec5 zyxyz => new cvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.bgrgb swizzling (equivalent to cvec4.zyxyz).
        /// </summary>
        public cvec5 bgrgb => new cvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.zyxyw swizzling.
        /// </summary>
        public cvec5 zyxyw => new cvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.bgrga swizzling (equivalent to cvec4.zyxyw).
        /// </summary>
        public cvec5 bgrga => new cvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.zyxz swizzling.
        /// </summary>
        public cvec4 zyxz => new cvec4(z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.bgrb swizzling (equivalent to cvec4.zyxz).
        /// </summary>
        public cvec4 bgrb => new cvec4(z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.zyxzx swizzling.
        /// </summary>
        public cvec5 zyxzx => new cvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.bgrbr swizzling (equivalent to cvec4.zyxzx).
        /// </summary>
        public cvec5 bgrbr => new cvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.zyxzy swizzling.
        /// </summary>
        public cvec5 zyxzy => new cvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.bgrbg swizzling (equivalent to cvec4.zyxzy).
        /// </summary>
        public cvec5 bgrbg => new cvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.zyxzz swizzling.
        /// </summary>
        public cvec5 zyxzz => new cvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.bgrbb swizzling (equivalent to cvec4.zyxzz).
        /// </summary>
        public cvec5 bgrbb => new cvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.zyxzw swizzling.
        /// </summary>
        public cvec5 zyxzw => new cvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.bgrba swizzling (equivalent to cvec4.zyxzw).
        /// </summary>
        public cvec5 bgrba => new cvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.zyxw swizzling.
        /// </summary>
        public cvec4 zyxw => new cvec4(z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.bgra swizzling (equivalent to cvec4.zyxw).
        /// </summary>
        public cvec4 bgra => new cvec4(z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.zyxwx swizzling.
        /// </summary>
        public cvec5 zyxwx => new cvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.bgrar swizzling (equivalent to cvec4.zyxwx).
        /// </summary>
        public cvec5 bgrar => new cvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.zyxwy swizzling.
        /// </summary>
        public cvec5 zyxwy => new cvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.bgrag swizzling (equivalent to cvec4.zyxwy).
        /// </summary>
        public cvec5 bgrag => new cvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.zyxwz swizzling.
        /// </summary>
        public cvec5 zyxwz => new cvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.bgrab swizzling (equivalent to cvec4.zyxwz).
        /// </summary>
        public cvec5 bgrab => new cvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.zyxww swizzling.
        /// </summary>
        public cvec5 zyxww => new cvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.bgraa swizzling (equivalent to cvec4.zyxww).
        /// </summary>
        public cvec5 bgraa => new cvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.zyy swizzling.
        /// </summary>
        public cvec3 zyy => new cvec3(z, y, y);
        
        /// <summary>
        /// Returns cvec4.bgg swizzling (equivalent to cvec4.zyy).
        /// </summary>
        public cvec3 bgg => new cvec3(z, y, y);
        
        /// <summary>
        /// Returns cvec4.zyyx swizzling.
        /// </summary>
        public cvec4 zyyx => new cvec4(z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.bggr swizzling (equivalent to cvec4.zyyx).
        /// </summary>
        public cvec4 bggr => new cvec4(z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.zyyxx swizzling.
        /// </summary>
        public cvec5 zyyxx => new cvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.bggrr swizzling (equivalent to cvec4.zyyxx).
        /// </summary>
        public cvec5 bggrr => new cvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.zyyxy swizzling.
        /// </summary>
        public cvec5 zyyxy => new cvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.bggrg swizzling (equivalent to cvec4.zyyxy).
        /// </summary>
        public cvec5 bggrg => new cvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.zyyxz swizzling.
        /// </summary>
        public cvec5 zyyxz => new cvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.bggrb swizzling (equivalent to cvec4.zyyxz).
        /// </summary>
        public cvec5 bggrb => new cvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.zyyxw swizzling.
        /// </summary>
        public cvec5 zyyxw => new cvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.bggra swizzling (equivalent to cvec4.zyyxw).
        /// </summary>
        public cvec5 bggra => new cvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.zyyy swizzling.
        /// </summary>
        public cvec4 zyyy => new cvec4(z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.bggg swizzling (equivalent to cvec4.zyyy).
        /// </summary>
        public cvec4 bggg => new cvec4(z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.zyyyx swizzling.
        /// </summary>
        public cvec5 zyyyx => new cvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.bgggr swizzling (equivalent to cvec4.zyyyx).
        /// </summary>
        public cvec5 bgggr => new cvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.zyyyy swizzling.
        /// </summary>
        public cvec5 zyyyy => new cvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.bgggg swizzling (equivalent to cvec4.zyyyy).
        /// </summary>
        public cvec5 bgggg => new cvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.zyyyz swizzling.
        /// </summary>
        public cvec5 zyyyz => new cvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.bgggb swizzling (equivalent to cvec4.zyyyz).
        /// </summary>
        public cvec5 bgggb => new cvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.zyyyw swizzling.
        /// </summary>
        public cvec5 zyyyw => new cvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.bggga swizzling (equivalent to cvec4.zyyyw).
        /// </summary>
        public cvec5 bggga => new cvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.zyyz swizzling.
        /// </summary>
        public cvec4 zyyz => new cvec4(z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.bggb swizzling (equivalent to cvec4.zyyz).
        /// </summary>
        public cvec4 bggb => new cvec4(z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.zyyzx swizzling.
        /// </summary>
        public cvec5 zyyzx => new cvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.bggbr swizzling (equivalent to cvec4.zyyzx).
        /// </summary>
        public cvec5 bggbr => new cvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.zyyzy swizzling.
        /// </summary>
        public cvec5 zyyzy => new cvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.bggbg swizzling (equivalent to cvec4.zyyzy).
        /// </summary>
        public cvec5 bggbg => new cvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.zyyzz swizzling.
        /// </summary>
        public cvec5 zyyzz => new cvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.bggbb swizzling (equivalent to cvec4.zyyzz).
        /// </summary>
        public cvec5 bggbb => new cvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.zyyzw swizzling.
        /// </summary>
        public cvec5 zyyzw => new cvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.bggba swizzling (equivalent to cvec4.zyyzw).
        /// </summary>
        public cvec5 bggba => new cvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.zyyw swizzling.
        /// </summary>
        public cvec4 zyyw => new cvec4(z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.bgga swizzling (equivalent to cvec4.zyyw).
        /// </summary>
        public cvec4 bgga => new cvec4(z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.zyywx swizzling.
        /// </summary>
        public cvec5 zyywx => new cvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.bggar swizzling (equivalent to cvec4.zyywx).
        /// </summary>
        public cvec5 bggar => new cvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.zyywy swizzling.
        /// </summary>
        public cvec5 zyywy => new cvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.bggag swizzling (equivalent to cvec4.zyywy).
        /// </summary>
        public cvec5 bggag => new cvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.zyywz swizzling.
        /// </summary>
        public cvec5 zyywz => new cvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.bggab swizzling (equivalent to cvec4.zyywz).
        /// </summary>
        public cvec5 bggab => new cvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.zyyww swizzling.
        /// </summary>
        public cvec5 zyyww => new cvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.bggaa swizzling (equivalent to cvec4.zyyww).
        /// </summary>
        public cvec5 bggaa => new cvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.zyz swizzling.
        /// </summary>
        public cvec3 zyz => new cvec3(z, y, z);
        
        /// <summary>
        /// Returns cvec4.bgb swizzling (equivalent to cvec4.zyz).
        /// </summary>
        public cvec3 bgb => new cvec3(z, y, z);
        
        /// <summary>
        /// Returns cvec4.zyzx swizzling.
        /// </summary>
        public cvec4 zyzx => new cvec4(z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.bgbr swizzling (equivalent to cvec4.zyzx).
        /// </summary>
        public cvec4 bgbr => new cvec4(z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.zyzxx swizzling.
        /// </summary>
        public cvec5 zyzxx => new cvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.bgbrr swizzling (equivalent to cvec4.zyzxx).
        /// </summary>
        public cvec5 bgbrr => new cvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.zyzxy swizzling.
        /// </summary>
        public cvec5 zyzxy => new cvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.bgbrg swizzling (equivalent to cvec4.zyzxy).
        /// </summary>
        public cvec5 bgbrg => new cvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.zyzxz swizzling.
        /// </summary>
        public cvec5 zyzxz => new cvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.bgbrb swizzling (equivalent to cvec4.zyzxz).
        /// </summary>
        public cvec5 bgbrb => new cvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.zyzxw swizzling.
        /// </summary>
        public cvec5 zyzxw => new cvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.bgbra swizzling (equivalent to cvec4.zyzxw).
        /// </summary>
        public cvec5 bgbra => new cvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.zyzy swizzling.
        /// </summary>
        public cvec4 zyzy => new cvec4(z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.bgbg swizzling (equivalent to cvec4.zyzy).
        /// </summary>
        public cvec4 bgbg => new cvec4(z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.zyzyx swizzling.
        /// </summary>
        public cvec5 zyzyx => new cvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.bgbgr swizzling (equivalent to cvec4.zyzyx).
        /// </summary>
        public cvec5 bgbgr => new cvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.zyzyy swizzling.
        /// </summary>
        public cvec5 zyzyy => new cvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.bgbgg swizzling (equivalent to cvec4.zyzyy).
        /// </summary>
        public cvec5 bgbgg => new cvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.zyzyz swizzling.
        /// </summary>
        public cvec5 zyzyz => new cvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.bgbgb swizzling (equivalent to cvec4.zyzyz).
        /// </summary>
        public cvec5 bgbgb => new cvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.zyzyw swizzling.
        /// </summary>
        public cvec5 zyzyw => new cvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.bgbga swizzling (equivalent to cvec4.zyzyw).
        /// </summary>
        public cvec5 bgbga => new cvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.zyzz swizzling.
        /// </summary>
        public cvec4 zyzz => new cvec4(z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.bgbb swizzling (equivalent to cvec4.zyzz).
        /// </summary>
        public cvec4 bgbb => new cvec4(z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.zyzzx swizzling.
        /// </summary>
        public cvec5 zyzzx => new cvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.bgbbr swizzling (equivalent to cvec4.zyzzx).
        /// </summary>
        public cvec5 bgbbr => new cvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.zyzzy swizzling.
        /// </summary>
        public cvec5 zyzzy => new cvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.bgbbg swizzling (equivalent to cvec4.zyzzy).
        /// </summary>
        public cvec5 bgbbg => new cvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.zyzzz swizzling.
        /// </summary>
        public cvec5 zyzzz => new cvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.bgbbb swizzling (equivalent to cvec4.zyzzz).
        /// </summary>
        public cvec5 bgbbb => new cvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.zyzzw swizzling.
        /// </summary>
        public cvec5 zyzzw => new cvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.bgbba swizzling (equivalent to cvec4.zyzzw).
        /// </summary>
        public cvec5 bgbba => new cvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.zyzw swizzling.
        /// </summary>
        public cvec4 zyzw => new cvec4(z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.bgba swizzling (equivalent to cvec4.zyzw).
        /// </summary>
        public cvec4 bgba => new cvec4(z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.zyzwx swizzling.
        /// </summary>
        public cvec5 zyzwx => new cvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.bgbar swizzling (equivalent to cvec4.zyzwx).
        /// </summary>
        public cvec5 bgbar => new cvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.zyzwy swizzling.
        /// </summary>
        public cvec5 zyzwy => new cvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.bgbag swizzling (equivalent to cvec4.zyzwy).
        /// </summary>
        public cvec5 bgbag => new cvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.zyzwz swizzling.
        /// </summary>
        public cvec5 zyzwz => new cvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.bgbab swizzling (equivalent to cvec4.zyzwz).
        /// </summary>
        public cvec5 bgbab => new cvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.zyzww swizzling.
        /// </summary>
        public cvec5 zyzww => new cvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.bgbaa swizzling (equivalent to cvec4.zyzww).
        /// </summary>
        public cvec5 bgbaa => new cvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.zyw swizzling.
        /// </summary>
        public cvec3 zyw => new cvec3(z, y, w);
        
        /// <summary>
        /// Returns cvec4.bga swizzling (equivalent to cvec4.zyw).
        /// </summary>
        public cvec3 bga => new cvec3(z, y, w);
        
        /// <summary>
        /// Returns cvec4.zywx swizzling.
        /// </summary>
        public cvec4 zywx => new cvec4(z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.bgar swizzling (equivalent to cvec4.zywx).
        /// </summary>
        public cvec4 bgar => new cvec4(z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.zywxx swizzling.
        /// </summary>
        public cvec5 zywxx => new cvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.bgarr swizzling (equivalent to cvec4.zywxx).
        /// </summary>
        public cvec5 bgarr => new cvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.zywxy swizzling.
        /// </summary>
        public cvec5 zywxy => new cvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.bgarg swizzling (equivalent to cvec4.zywxy).
        /// </summary>
        public cvec5 bgarg => new cvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.zywxz swizzling.
        /// </summary>
        public cvec5 zywxz => new cvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.bgarb swizzling (equivalent to cvec4.zywxz).
        /// </summary>
        public cvec5 bgarb => new cvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.zywxw swizzling.
        /// </summary>
        public cvec5 zywxw => new cvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.bgara swizzling (equivalent to cvec4.zywxw).
        /// </summary>
        public cvec5 bgara => new cvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.zywy swizzling.
        /// </summary>
        public cvec4 zywy => new cvec4(z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.bgag swizzling (equivalent to cvec4.zywy).
        /// </summary>
        public cvec4 bgag => new cvec4(z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.zywyx swizzling.
        /// </summary>
        public cvec5 zywyx => new cvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.bgagr swizzling (equivalent to cvec4.zywyx).
        /// </summary>
        public cvec5 bgagr => new cvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.zywyy swizzling.
        /// </summary>
        public cvec5 zywyy => new cvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.bgagg swizzling (equivalent to cvec4.zywyy).
        /// </summary>
        public cvec5 bgagg => new cvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.zywyz swizzling.
        /// </summary>
        public cvec5 zywyz => new cvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.bgagb swizzling (equivalent to cvec4.zywyz).
        /// </summary>
        public cvec5 bgagb => new cvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.zywyw swizzling.
        /// </summary>
        public cvec5 zywyw => new cvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.bgaga swizzling (equivalent to cvec4.zywyw).
        /// </summary>
        public cvec5 bgaga => new cvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.zywz swizzling.
        /// </summary>
        public cvec4 zywz => new cvec4(z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.bgab swizzling (equivalent to cvec4.zywz).
        /// </summary>
        public cvec4 bgab => new cvec4(z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.zywzx swizzling.
        /// </summary>
        public cvec5 zywzx => new cvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.bgabr swizzling (equivalent to cvec4.zywzx).
        /// </summary>
        public cvec5 bgabr => new cvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.zywzy swizzling.
        /// </summary>
        public cvec5 zywzy => new cvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.bgabg swizzling (equivalent to cvec4.zywzy).
        /// </summary>
        public cvec5 bgabg => new cvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.zywzz swizzling.
        /// </summary>
        public cvec5 zywzz => new cvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.bgabb swizzling (equivalent to cvec4.zywzz).
        /// </summary>
        public cvec5 bgabb => new cvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.zywzw swizzling.
        /// </summary>
        public cvec5 zywzw => new cvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.bgaba swizzling (equivalent to cvec4.zywzw).
        /// </summary>
        public cvec5 bgaba => new cvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.zyww swizzling.
        /// </summary>
        public cvec4 zyww => new cvec4(z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.bgaa swizzling (equivalent to cvec4.zyww).
        /// </summary>
        public cvec4 bgaa => new cvec4(z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.zywwx swizzling.
        /// </summary>
        public cvec5 zywwx => new cvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.bgaar swizzling (equivalent to cvec4.zywwx).
        /// </summary>
        public cvec5 bgaar => new cvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.zywwy swizzling.
        /// </summary>
        public cvec5 zywwy => new cvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.bgaag swizzling (equivalent to cvec4.zywwy).
        /// </summary>
        public cvec5 bgaag => new cvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.zywwz swizzling.
        /// </summary>
        public cvec5 zywwz => new cvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.bgaab swizzling (equivalent to cvec4.zywwz).
        /// </summary>
        public cvec5 bgaab => new cvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.zywww swizzling.
        /// </summary>
        public cvec5 zywww => new cvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.bgaaa swizzling (equivalent to cvec4.zywww).
        /// </summary>
        public cvec5 bgaaa => new cvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.zz swizzling.
        /// </summary>
        public cvec2 zz => new cvec2(z, z);
        
        /// <summary>
        /// Returns cvec4.bb swizzling (equivalent to cvec4.zz).
        /// </summary>
        public cvec2 bb => new cvec2(z, z);
        
        /// <summary>
        /// Returns cvec4.zzx swizzling.
        /// </summary>
        public cvec3 zzx => new cvec3(z, z, x);
        
        /// <summary>
        /// Returns cvec4.bbr swizzling (equivalent to cvec4.zzx).
        /// </summary>
        public cvec3 bbr => new cvec3(z, z, x);
        
        /// <summary>
        /// Returns cvec4.zzxx swizzling.
        /// </summary>
        public cvec4 zzxx => new cvec4(z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.bbrr swizzling (equivalent to cvec4.zzxx).
        /// </summary>
        public cvec4 bbrr => new cvec4(z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.zzxxx swizzling.
        /// </summary>
        public cvec5 zzxxx => new cvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.bbrrr swizzling (equivalent to cvec4.zzxxx).
        /// </summary>
        public cvec5 bbrrr => new cvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.zzxxy swizzling.
        /// </summary>
        public cvec5 zzxxy => new cvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.bbrrg swizzling (equivalent to cvec4.zzxxy).
        /// </summary>
        public cvec5 bbrrg => new cvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.zzxxz swizzling.
        /// </summary>
        public cvec5 zzxxz => new cvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.bbrrb swizzling (equivalent to cvec4.zzxxz).
        /// </summary>
        public cvec5 bbrrb => new cvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.zzxxw swizzling.
        /// </summary>
        public cvec5 zzxxw => new cvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.bbrra swizzling (equivalent to cvec4.zzxxw).
        /// </summary>
        public cvec5 bbrra => new cvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.zzxy swizzling.
        /// </summary>
        public cvec4 zzxy => new cvec4(z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.bbrg swizzling (equivalent to cvec4.zzxy).
        /// </summary>
        public cvec4 bbrg => new cvec4(z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.zzxyx swizzling.
        /// </summary>
        public cvec5 zzxyx => new cvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.bbrgr swizzling (equivalent to cvec4.zzxyx).
        /// </summary>
        public cvec5 bbrgr => new cvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.zzxyy swizzling.
        /// </summary>
        public cvec5 zzxyy => new cvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.bbrgg swizzling (equivalent to cvec4.zzxyy).
        /// </summary>
        public cvec5 bbrgg => new cvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.zzxyz swizzling.
        /// </summary>
        public cvec5 zzxyz => new cvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.bbrgb swizzling (equivalent to cvec4.zzxyz).
        /// </summary>
        public cvec5 bbrgb => new cvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.zzxyw swizzling.
        /// </summary>
        public cvec5 zzxyw => new cvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.bbrga swizzling (equivalent to cvec4.zzxyw).
        /// </summary>
        public cvec5 bbrga => new cvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.zzxz swizzling.
        /// </summary>
        public cvec4 zzxz => new cvec4(z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.bbrb swizzling (equivalent to cvec4.zzxz).
        /// </summary>
        public cvec4 bbrb => new cvec4(z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.zzxzx swizzling.
        /// </summary>
        public cvec5 zzxzx => new cvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.bbrbr swizzling (equivalent to cvec4.zzxzx).
        /// </summary>
        public cvec5 bbrbr => new cvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.zzxzy swizzling.
        /// </summary>
        public cvec5 zzxzy => new cvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.bbrbg swizzling (equivalent to cvec4.zzxzy).
        /// </summary>
        public cvec5 bbrbg => new cvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.zzxzz swizzling.
        /// </summary>
        public cvec5 zzxzz => new cvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.bbrbb swizzling (equivalent to cvec4.zzxzz).
        /// </summary>
        public cvec5 bbrbb => new cvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.zzxzw swizzling.
        /// </summary>
        public cvec5 zzxzw => new cvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.bbrba swizzling (equivalent to cvec4.zzxzw).
        /// </summary>
        public cvec5 bbrba => new cvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.zzxw swizzling.
        /// </summary>
        public cvec4 zzxw => new cvec4(z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.bbra swizzling (equivalent to cvec4.zzxw).
        /// </summary>
        public cvec4 bbra => new cvec4(z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.zzxwx swizzling.
        /// </summary>
        public cvec5 zzxwx => new cvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.bbrar swizzling (equivalent to cvec4.zzxwx).
        /// </summary>
        public cvec5 bbrar => new cvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.zzxwy swizzling.
        /// </summary>
        public cvec5 zzxwy => new cvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.bbrag swizzling (equivalent to cvec4.zzxwy).
        /// </summary>
        public cvec5 bbrag => new cvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.zzxwz swizzling.
        /// </summary>
        public cvec5 zzxwz => new cvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.bbrab swizzling (equivalent to cvec4.zzxwz).
        /// </summary>
        public cvec5 bbrab => new cvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.zzxww swizzling.
        /// </summary>
        public cvec5 zzxww => new cvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.bbraa swizzling (equivalent to cvec4.zzxww).
        /// </summary>
        public cvec5 bbraa => new cvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.zzy swizzling.
        /// </summary>
        public cvec3 zzy => new cvec3(z, z, y);
        
        /// <summary>
        /// Returns cvec4.bbg swizzling (equivalent to cvec4.zzy).
        /// </summary>
        public cvec3 bbg => new cvec3(z, z, y);
        
        /// <summary>
        /// Returns cvec4.zzyx swizzling.
        /// </summary>
        public cvec4 zzyx => new cvec4(z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.bbgr swizzling (equivalent to cvec4.zzyx).
        /// </summary>
        public cvec4 bbgr => new cvec4(z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.zzyxx swizzling.
        /// </summary>
        public cvec5 zzyxx => new cvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.bbgrr swizzling (equivalent to cvec4.zzyxx).
        /// </summary>
        public cvec5 bbgrr => new cvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.zzyxy swizzling.
        /// </summary>
        public cvec5 zzyxy => new cvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.bbgrg swizzling (equivalent to cvec4.zzyxy).
        /// </summary>
        public cvec5 bbgrg => new cvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.zzyxz swizzling.
        /// </summary>
        public cvec5 zzyxz => new cvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.bbgrb swizzling (equivalent to cvec4.zzyxz).
        /// </summary>
        public cvec5 bbgrb => new cvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.zzyxw swizzling.
        /// </summary>
        public cvec5 zzyxw => new cvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.bbgra swizzling (equivalent to cvec4.zzyxw).
        /// </summary>
        public cvec5 bbgra => new cvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.zzyy swizzling.
        /// </summary>
        public cvec4 zzyy => new cvec4(z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.bbgg swizzling (equivalent to cvec4.zzyy).
        /// </summary>
        public cvec4 bbgg => new cvec4(z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.zzyyx swizzling.
        /// </summary>
        public cvec5 zzyyx => new cvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.bbggr swizzling (equivalent to cvec4.zzyyx).
        /// </summary>
        public cvec5 bbggr => new cvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.zzyyy swizzling.
        /// </summary>
        public cvec5 zzyyy => new cvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.bbggg swizzling (equivalent to cvec4.zzyyy).
        /// </summary>
        public cvec5 bbggg => new cvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.zzyyz swizzling.
        /// </summary>
        public cvec5 zzyyz => new cvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.bbggb swizzling (equivalent to cvec4.zzyyz).
        /// </summary>
        public cvec5 bbggb => new cvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.zzyyw swizzling.
        /// </summary>
        public cvec5 zzyyw => new cvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.bbgga swizzling (equivalent to cvec4.zzyyw).
        /// </summary>
        public cvec5 bbgga => new cvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.zzyz swizzling.
        /// </summary>
        public cvec4 zzyz => new cvec4(z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.bbgb swizzling (equivalent to cvec4.zzyz).
        /// </summary>
        public cvec4 bbgb => new cvec4(z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.zzyzx swizzling.
        /// </summary>
        public cvec5 zzyzx => new cvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.bbgbr swizzling (equivalent to cvec4.zzyzx).
        /// </summary>
        public cvec5 bbgbr => new cvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.zzyzy swizzling.
        /// </summary>
        public cvec5 zzyzy => new cvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.bbgbg swizzling (equivalent to cvec4.zzyzy).
        /// </summary>
        public cvec5 bbgbg => new cvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.zzyzz swizzling.
        /// </summary>
        public cvec5 zzyzz => new cvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.bbgbb swizzling (equivalent to cvec4.zzyzz).
        /// </summary>
        public cvec5 bbgbb => new cvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.zzyzw swizzling.
        /// </summary>
        public cvec5 zzyzw => new cvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.bbgba swizzling (equivalent to cvec4.zzyzw).
        /// </summary>
        public cvec5 bbgba => new cvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.zzyw swizzling.
        /// </summary>
        public cvec4 zzyw => new cvec4(z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.bbga swizzling (equivalent to cvec4.zzyw).
        /// </summary>
        public cvec4 bbga => new cvec4(z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.zzywx swizzling.
        /// </summary>
        public cvec5 zzywx => new cvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.bbgar swizzling (equivalent to cvec4.zzywx).
        /// </summary>
        public cvec5 bbgar => new cvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.zzywy swizzling.
        /// </summary>
        public cvec5 zzywy => new cvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.bbgag swizzling (equivalent to cvec4.zzywy).
        /// </summary>
        public cvec5 bbgag => new cvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.zzywz swizzling.
        /// </summary>
        public cvec5 zzywz => new cvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.bbgab swizzling (equivalent to cvec4.zzywz).
        /// </summary>
        public cvec5 bbgab => new cvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.zzyww swizzling.
        /// </summary>
        public cvec5 zzyww => new cvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.bbgaa swizzling (equivalent to cvec4.zzyww).
        /// </summary>
        public cvec5 bbgaa => new cvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.zzz swizzling.
        /// </summary>
        public cvec3 zzz => new cvec3(z, z, z);
        
        /// <summary>
        /// Returns cvec4.bbb swizzling (equivalent to cvec4.zzz).
        /// </summary>
        public cvec3 bbb => new cvec3(z, z, z);
        
        /// <summary>
        /// Returns cvec4.zzzx swizzling.
        /// </summary>
        public cvec4 zzzx => new cvec4(z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.bbbr swizzling (equivalent to cvec4.zzzx).
        /// </summary>
        public cvec4 bbbr => new cvec4(z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.zzzxx swizzling.
        /// </summary>
        public cvec5 zzzxx => new cvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.bbbrr swizzling (equivalent to cvec4.zzzxx).
        /// </summary>
        public cvec5 bbbrr => new cvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.zzzxy swizzling.
        /// </summary>
        public cvec5 zzzxy => new cvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.bbbrg swizzling (equivalent to cvec4.zzzxy).
        /// </summary>
        public cvec5 bbbrg => new cvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.zzzxz swizzling.
        /// </summary>
        public cvec5 zzzxz => new cvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.bbbrb swizzling (equivalent to cvec4.zzzxz).
        /// </summary>
        public cvec5 bbbrb => new cvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.zzzxw swizzling.
        /// </summary>
        public cvec5 zzzxw => new cvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.bbbra swizzling (equivalent to cvec4.zzzxw).
        /// </summary>
        public cvec5 bbbra => new cvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.zzzy swizzling.
        /// </summary>
        public cvec4 zzzy => new cvec4(z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.bbbg swizzling (equivalent to cvec4.zzzy).
        /// </summary>
        public cvec4 bbbg => new cvec4(z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.zzzyx swizzling.
        /// </summary>
        public cvec5 zzzyx => new cvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.bbbgr swizzling (equivalent to cvec4.zzzyx).
        /// </summary>
        public cvec5 bbbgr => new cvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.zzzyy swizzling.
        /// </summary>
        public cvec5 zzzyy => new cvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.bbbgg swizzling (equivalent to cvec4.zzzyy).
        /// </summary>
        public cvec5 bbbgg => new cvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.zzzyz swizzling.
        /// </summary>
        public cvec5 zzzyz => new cvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.bbbgb swizzling (equivalent to cvec4.zzzyz).
        /// </summary>
        public cvec5 bbbgb => new cvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.zzzyw swizzling.
        /// </summary>
        public cvec5 zzzyw => new cvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.bbbga swizzling (equivalent to cvec4.zzzyw).
        /// </summary>
        public cvec5 bbbga => new cvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.zzzz swizzling.
        /// </summary>
        public cvec4 zzzz => new cvec4(z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.bbbb swizzling (equivalent to cvec4.zzzz).
        /// </summary>
        public cvec4 bbbb => new cvec4(z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.zzzzx swizzling.
        /// </summary>
        public cvec5 zzzzx => new cvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.bbbbr swizzling (equivalent to cvec4.zzzzx).
        /// </summary>
        public cvec5 bbbbr => new cvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.zzzzy swizzling.
        /// </summary>
        public cvec5 zzzzy => new cvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.bbbbg swizzling (equivalent to cvec4.zzzzy).
        /// </summary>
        public cvec5 bbbbg => new cvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.zzzzz swizzling.
        /// </summary>
        public cvec5 zzzzz => new cvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.bbbbb swizzling (equivalent to cvec4.zzzzz).
        /// </summary>
        public cvec5 bbbbb => new cvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.zzzzw swizzling.
        /// </summary>
        public cvec5 zzzzw => new cvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.bbbba swizzling (equivalent to cvec4.zzzzw).
        /// </summary>
        public cvec5 bbbba => new cvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.zzzw swizzling.
        /// </summary>
        public cvec4 zzzw => new cvec4(z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.bbba swizzling (equivalent to cvec4.zzzw).
        /// </summary>
        public cvec4 bbba => new cvec4(z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.zzzwx swizzling.
        /// </summary>
        public cvec5 zzzwx => new cvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.bbbar swizzling (equivalent to cvec4.zzzwx).
        /// </summary>
        public cvec5 bbbar => new cvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.zzzwy swizzling.
        /// </summary>
        public cvec5 zzzwy => new cvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.bbbag swizzling (equivalent to cvec4.zzzwy).
        /// </summary>
        public cvec5 bbbag => new cvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.zzzwz swizzling.
        /// </summary>
        public cvec5 zzzwz => new cvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.bbbab swizzling (equivalent to cvec4.zzzwz).
        /// </summary>
        public cvec5 bbbab => new cvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.zzzww swizzling.
        /// </summary>
        public cvec5 zzzww => new cvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.bbbaa swizzling (equivalent to cvec4.zzzww).
        /// </summary>
        public cvec5 bbbaa => new cvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.zzw swizzling.
        /// </summary>
        public cvec3 zzw => new cvec3(z, z, w);
        
        /// <summary>
        /// Returns cvec4.bba swizzling (equivalent to cvec4.zzw).
        /// </summary>
        public cvec3 bba => new cvec3(z, z, w);
        
        /// <summary>
        /// Returns cvec4.zzwx swizzling.
        /// </summary>
        public cvec4 zzwx => new cvec4(z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.bbar swizzling (equivalent to cvec4.zzwx).
        /// </summary>
        public cvec4 bbar => new cvec4(z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.zzwxx swizzling.
        /// </summary>
        public cvec5 zzwxx => new cvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.bbarr swizzling (equivalent to cvec4.zzwxx).
        /// </summary>
        public cvec5 bbarr => new cvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.zzwxy swizzling.
        /// </summary>
        public cvec5 zzwxy => new cvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.bbarg swizzling (equivalent to cvec4.zzwxy).
        /// </summary>
        public cvec5 bbarg => new cvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.zzwxz swizzling.
        /// </summary>
        public cvec5 zzwxz => new cvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.bbarb swizzling (equivalent to cvec4.zzwxz).
        /// </summary>
        public cvec5 bbarb => new cvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.zzwxw swizzling.
        /// </summary>
        public cvec5 zzwxw => new cvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.bbara swizzling (equivalent to cvec4.zzwxw).
        /// </summary>
        public cvec5 bbara => new cvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.zzwy swizzling.
        /// </summary>
        public cvec4 zzwy => new cvec4(z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.bbag swizzling (equivalent to cvec4.zzwy).
        /// </summary>
        public cvec4 bbag => new cvec4(z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.zzwyx swizzling.
        /// </summary>
        public cvec5 zzwyx => new cvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.bbagr swizzling (equivalent to cvec4.zzwyx).
        /// </summary>
        public cvec5 bbagr => new cvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.zzwyy swizzling.
        /// </summary>
        public cvec5 zzwyy => new cvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.bbagg swizzling (equivalent to cvec4.zzwyy).
        /// </summary>
        public cvec5 bbagg => new cvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.zzwyz swizzling.
        /// </summary>
        public cvec5 zzwyz => new cvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.bbagb swizzling (equivalent to cvec4.zzwyz).
        /// </summary>
        public cvec5 bbagb => new cvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.zzwyw swizzling.
        /// </summary>
        public cvec5 zzwyw => new cvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.bbaga swizzling (equivalent to cvec4.zzwyw).
        /// </summary>
        public cvec5 bbaga => new cvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.zzwz swizzling.
        /// </summary>
        public cvec4 zzwz => new cvec4(z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.bbab swizzling (equivalent to cvec4.zzwz).
        /// </summary>
        public cvec4 bbab => new cvec4(z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.zzwzx swizzling.
        /// </summary>
        public cvec5 zzwzx => new cvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.bbabr swizzling (equivalent to cvec4.zzwzx).
        /// </summary>
        public cvec5 bbabr => new cvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.zzwzy swizzling.
        /// </summary>
        public cvec5 zzwzy => new cvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.bbabg swizzling (equivalent to cvec4.zzwzy).
        /// </summary>
        public cvec5 bbabg => new cvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.zzwzz swizzling.
        /// </summary>
        public cvec5 zzwzz => new cvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.bbabb swizzling (equivalent to cvec4.zzwzz).
        /// </summary>
        public cvec5 bbabb => new cvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.zzwzw swizzling.
        /// </summary>
        public cvec5 zzwzw => new cvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.bbaba swizzling (equivalent to cvec4.zzwzw).
        /// </summary>
        public cvec5 bbaba => new cvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.zzww swizzling.
        /// </summary>
        public cvec4 zzww => new cvec4(z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.bbaa swizzling (equivalent to cvec4.zzww).
        /// </summary>
        public cvec4 bbaa => new cvec4(z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.zzwwx swizzling.
        /// </summary>
        public cvec5 zzwwx => new cvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.bbaar swizzling (equivalent to cvec4.zzwwx).
        /// </summary>
        public cvec5 bbaar => new cvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.zzwwy swizzling.
        /// </summary>
        public cvec5 zzwwy => new cvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.bbaag swizzling (equivalent to cvec4.zzwwy).
        /// </summary>
        public cvec5 bbaag => new cvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.zzwwz swizzling.
        /// </summary>
        public cvec5 zzwwz => new cvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.bbaab swizzling (equivalent to cvec4.zzwwz).
        /// </summary>
        public cvec5 bbaab => new cvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.zzwww swizzling.
        /// </summary>
        public cvec5 zzwww => new cvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.bbaaa swizzling (equivalent to cvec4.zzwww).
        /// </summary>
        public cvec5 bbaaa => new cvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.zw swizzling.
        /// </summary>
        public cvec2 zw => new cvec2(z, w);
        
        /// <summary>
        /// Returns cvec4.ba swizzling (equivalent to cvec4.zw).
        /// </summary>
        public cvec2 ba => new cvec2(z, w);
        
        /// <summary>
        /// Returns cvec4.zwx swizzling.
        /// </summary>
        public cvec3 zwx => new cvec3(z, w, x);
        
        /// <summary>
        /// Returns cvec4.bar swizzling (equivalent to cvec4.zwx).
        /// </summary>
        public cvec3 bar => new cvec3(z, w, x);
        
        /// <summary>
        /// Returns cvec4.zwxx swizzling.
        /// </summary>
        public cvec4 zwxx => new cvec4(z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.barr swizzling (equivalent to cvec4.zwxx).
        /// </summary>
        public cvec4 barr => new cvec4(z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.zwxxx swizzling.
        /// </summary>
        public cvec5 zwxxx => new cvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.barrr swizzling (equivalent to cvec4.zwxxx).
        /// </summary>
        public cvec5 barrr => new cvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.zwxxy swizzling.
        /// </summary>
        public cvec5 zwxxy => new cvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.barrg swizzling (equivalent to cvec4.zwxxy).
        /// </summary>
        public cvec5 barrg => new cvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.zwxxz swizzling.
        /// </summary>
        public cvec5 zwxxz => new cvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.barrb swizzling (equivalent to cvec4.zwxxz).
        /// </summary>
        public cvec5 barrb => new cvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.zwxxw swizzling.
        /// </summary>
        public cvec5 zwxxw => new cvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.barra swizzling (equivalent to cvec4.zwxxw).
        /// </summary>
        public cvec5 barra => new cvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.zwxy swizzling.
        /// </summary>
        public cvec4 zwxy => new cvec4(z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.barg swizzling (equivalent to cvec4.zwxy).
        /// </summary>
        public cvec4 barg => new cvec4(z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.zwxyx swizzling.
        /// </summary>
        public cvec5 zwxyx => new cvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.bargr swizzling (equivalent to cvec4.zwxyx).
        /// </summary>
        public cvec5 bargr => new cvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.zwxyy swizzling.
        /// </summary>
        public cvec5 zwxyy => new cvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.bargg swizzling (equivalent to cvec4.zwxyy).
        /// </summary>
        public cvec5 bargg => new cvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.zwxyz swizzling.
        /// </summary>
        public cvec5 zwxyz => new cvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.bargb swizzling (equivalent to cvec4.zwxyz).
        /// </summary>
        public cvec5 bargb => new cvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.zwxyw swizzling.
        /// </summary>
        public cvec5 zwxyw => new cvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.barga swizzling (equivalent to cvec4.zwxyw).
        /// </summary>
        public cvec5 barga => new cvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.zwxz swizzling.
        /// </summary>
        public cvec4 zwxz => new cvec4(z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.barb swizzling (equivalent to cvec4.zwxz).
        /// </summary>
        public cvec4 barb => new cvec4(z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.zwxzx swizzling.
        /// </summary>
        public cvec5 zwxzx => new cvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.barbr swizzling (equivalent to cvec4.zwxzx).
        /// </summary>
        public cvec5 barbr => new cvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.zwxzy swizzling.
        /// </summary>
        public cvec5 zwxzy => new cvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.barbg swizzling (equivalent to cvec4.zwxzy).
        /// </summary>
        public cvec5 barbg => new cvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.zwxzz swizzling.
        /// </summary>
        public cvec5 zwxzz => new cvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.barbb swizzling (equivalent to cvec4.zwxzz).
        /// </summary>
        public cvec5 barbb => new cvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.zwxzw swizzling.
        /// </summary>
        public cvec5 zwxzw => new cvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.barba swizzling (equivalent to cvec4.zwxzw).
        /// </summary>
        public cvec5 barba => new cvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.zwxw swizzling.
        /// </summary>
        public cvec4 zwxw => new cvec4(z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.bara swizzling (equivalent to cvec4.zwxw).
        /// </summary>
        public cvec4 bara => new cvec4(z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.zwxwx swizzling.
        /// </summary>
        public cvec5 zwxwx => new cvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.barar swizzling (equivalent to cvec4.zwxwx).
        /// </summary>
        public cvec5 barar => new cvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.zwxwy swizzling.
        /// </summary>
        public cvec5 zwxwy => new cvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.barag swizzling (equivalent to cvec4.zwxwy).
        /// </summary>
        public cvec5 barag => new cvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.zwxwz swizzling.
        /// </summary>
        public cvec5 zwxwz => new cvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.barab swizzling (equivalent to cvec4.zwxwz).
        /// </summary>
        public cvec5 barab => new cvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.zwxww swizzling.
        /// </summary>
        public cvec5 zwxww => new cvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.baraa swizzling (equivalent to cvec4.zwxww).
        /// </summary>
        public cvec5 baraa => new cvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.zwy swizzling.
        /// </summary>
        public cvec3 zwy => new cvec3(z, w, y);
        
        /// <summary>
        /// Returns cvec4.bag swizzling (equivalent to cvec4.zwy).
        /// </summary>
        public cvec3 bag => new cvec3(z, w, y);
        
        /// <summary>
        /// Returns cvec4.zwyx swizzling.
        /// </summary>
        public cvec4 zwyx => new cvec4(z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.bagr swizzling (equivalent to cvec4.zwyx).
        /// </summary>
        public cvec4 bagr => new cvec4(z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.zwyxx swizzling.
        /// </summary>
        public cvec5 zwyxx => new cvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.bagrr swizzling (equivalent to cvec4.zwyxx).
        /// </summary>
        public cvec5 bagrr => new cvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.zwyxy swizzling.
        /// </summary>
        public cvec5 zwyxy => new cvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.bagrg swizzling (equivalent to cvec4.zwyxy).
        /// </summary>
        public cvec5 bagrg => new cvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.zwyxz swizzling.
        /// </summary>
        public cvec5 zwyxz => new cvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.bagrb swizzling (equivalent to cvec4.zwyxz).
        /// </summary>
        public cvec5 bagrb => new cvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.zwyxw swizzling.
        /// </summary>
        public cvec5 zwyxw => new cvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.bagra swizzling (equivalent to cvec4.zwyxw).
        /// </summary>
        public cvec5 bagra => new cvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.zwyy swizzling.
        /// </summary>
        public cvec4 zwyy => new cvec4(z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.bagg swizzling (equivalent to cvec4.zwyy).
        /// </summary>
        public cvec4 bagg => new cvec4(z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.zwyyx swizzling.
        /// </summary>
        public cvec5 zwyyx => new cvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.baggr swizzling (equivalent to cvec4.zwyyx).
        /// </summary>
        public cvec5 baggr => new cvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.zwyyy swizzling.
        /// </summary>
        public cvec5 zwyyy => new cvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.baggg swizzling (equivalent to cvec4.zwyyy).
        /// </summary>
        public cvec5 baggg => new cvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.zwyyz swizzling.
        /// </summary>
        public cvec5 zwyyz => new cvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.baggb swizzling (equivalent to cvec4.zwyyz).
        /// </summary>
        public cvec5 baggb => new cvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.zwyyw swizzling.
        /// </summary>
        public cvec5 zwyyw => new cvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.bagga swizzling (equivalent to cvec4.zwyyw).
        /// </summary>
        public cvec5 bagga => new cvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.zwyz swizzling.
        /// </summary>
        public cvec4 zwyz => new cvec4(z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.bagb swizzling (equivalent to cvec4.zwyz).
        /// </summary>
        public cvec4 bagb => new cvec4(z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.zwyzx swizzling.
        /// </summary>
        public cvec5 zwyzx => new cvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.bagbr swizzling (equivalent to cvec4.zwyzx).
        /// </summary>
        public cvec5 bagbr => new cvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.zwyzy swizzling.
        /// </summary>
        public cvec5 zwyzy => new cvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.bagbg swizzling (equivalent to cvec4.zwyzy).
        /// </summary>
        public cvec5 bagbg => new cvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.zwyzz swizzling.
        /// </summary>
        public cvec5 zwyzz => new cvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.bagbb swizzling (equivalent to cvec4.zwyzz).
        /// </summary>
        public cvec5 bagbb => new cvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.zwyzw swizzling.
        /// </summary>
        public cvec5 zwyzw => new cvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.bagba swizzling (equivalent to cvec4.zwyzw).
        /// </summary>
        public cvec5 bagba => new cvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.zwyw swizzling.
        /// </summary>
        public cvec4 zwyw => new cvec4(z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.baga swizzling (equivalent to cvec4.zwyw).
        /// </summary>
        public cvec4 baga => new cvec4(z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.zwywx swizzling.
        /// </summary>
        public cvec5 zwywx => new cvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.bagar swizzling (equivalent to cvec4.zwywx).
        /// </summary>
        public cvec5 bagar => new cvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.zwywy swizzling.
        /// </summary>
        public cvec5 zwywy => new cvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.bagag swizzling (equivalent to cvec4.zwywy).
        /// </summary>
        public cvec5 bagag => new cvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.zwywz swizzling.
        /// </summary>
        public cvec5 zwywz => new cvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.bagab swizzling (equivalent to cvec4.zwywz).
        /// </summary>
        public cvec5 bagab => new cvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.zwyww swizzling.
        /// </summary>
        public cvec5 zwyww => new cvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.bagaa swizzling (equivalent to cvec4.zwyww).
        /// </summary>
        public cvec5 bagaa => new cvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.zwz swizzling.
        /// </summary>
        public cvec3 zwz => new cvec3(z, w, z);
        
        /// <summary>
        /// Returns cvec4.bab swizzling (equivalent to cvec4.zwz).
        /// </summary>
        public cvec3 bab => new cvec3(z, w, z);
        
        /// <summary>
        /// Returns cvec4.zwzx swizzling.
        /// </summary>
        public cvec4 zwzx => new cvec4(z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.babr swizzling (equivalent to cvec4.zwzx).
        /// </summary>
        public cvec4 babr => new cvec4(z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.zwzxx swizzling.
        /// </summary>
        public cvec5 zwzxx => new cvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.babrr swizzling (equivalent to cvec4.zwzxx).
        /// </summary>
        public cvec5 babrr => new cvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.zwzxy swizzling.
        /// </summary>
        public cvec5 zwzxy => new cvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.babrg swizzling (equivalent to cvec4.zwzxy).
        /// </summary>
        public cvec5 babrg => new cvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.zwzxz swizzling.
        /// </summary>
        public cvec5 zwzxz => new cvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.babrb swizzling (equivalent to cvec4.zwzxz).
        /// </summary>
        public cvec5 babrb => new cvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.zwzxw swizzling.
        /// </summary>
        public cvec5 zwzxw => new cvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.babra swizzling (equivalent to cvec4.zwzxw).
        /// </summary>
        public cvec5 babra => new cvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.zwzy swizzling.
        /// </summary>
        public cvec4 zwzy => new cvec4(z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.babg swizzling (equivalent to cvec4.zwzy).
        /// </summary>
        public cvec4 babg => new cvec4(z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.zwzyx swizzling.
        /// </summary>
        public cvec5 zwzyx => new cvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.babgr swizzling (equivalent to cvec4.zwzyx).
        /// </summary>
        public cvec5 babgr => new cvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.zwzyy swizzling.
        /// </summary>
        public cvec5 zwzyy => new cvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.babgg swizzling (equivalent to cvec4.zwzyy).
        /// </summary>
        public cvec5 babgg => new cvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.zwzyz swizzling.
        /// </summary>
        public cvec5 zwzyz => new cvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.babgb swizzling (equivalent to cvec4.zwzyz).
        /// </summary>
        public cvec5 babgb => new cvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.zwzyw swizzling.
        /// </summary>
        public cvec5 zwzyw => new cvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.babga swizzling (equivalent to cvec4.zwzyw).
        /// </summary>
        public cvec5 babga => new cvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.zwzz swizzling.
        /// </summary>
        public cvec4 zwzz => new cvec4(z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.babb swizzling (equivalent to cvec4.zwzz).
        /// </summary>
        public cvec4 babb => new cvec4(z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.zwzzx swizzling.
        /// </summary>
        public cvec5 zwzzx => new cvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.babbr swizzling (equivalent to cvec4.zwzzx).
        /// </summary>
        public cvec5 babbr => new cvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.zwzzy swizzling.
        /// </summary>
        public cvec5 zwzzy => new cvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.babbg swizzling (equivalent to cvec4.zwzzy).
        /// </summary>
        public cvec5 babbg => new cvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.zwzzz swizzling.
        /// </summary>
        public cvec5 zwzzz => new cvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.babbb swizzling (equivalent to cvec4.zwzzz).
        /// </summary>
        public cvec5 babbb => new cvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.zwzzw swizzling.
        /// </summary>
        public cvec5 zwzzw => new cvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.babba swizzling (equivalent to cvec4.zwzzw).
        /// </summary>
        public cvec5 babba => new cvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.zwzw swizzling.
        /// </summary>
        public cvec4 zwzw => new cvec4(z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.baba swizzling (equivalent to cvec4.zwzw).
        /// </summary>
        public cvec4 baba => new cvec4(z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.zwzwx swizzling.
        /// </summary>
        public cvec5 zwzwx => new cvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.babar swizzling (equivalent to cvec4.zwzwx).
        /// </summary>
        public cvec5 babar => new cvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.zwzwy swizzling.
        /// </summary>
        public cvec5 zwzwy => new cvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.babag swizzling (equivalent to cvec4.zwzwy).
        /// </summary>
        public cvec5 babag => new cvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.zwzwz swizzling.
        /// </summary>
        public cvec5 zwzwz => new cvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.babab swizzling (equivalent to cvec4.zwzwz).
        /// </summary>
        public cvec5 babab => new cvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.zwzww swizzling.
        /// </summary>
        public cvec5 zwzww => new cvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.babaa swizzling (equivalent to cvec4.zwzww).
        /// </summary>
        public cvec5 babaa => new cvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.zww swizzling.
        /// </summary>
        public cvec3 zww => new cvec3(z, w, w);
        
        /// <summary>
        /// Returns cvec4.baa swizzling (equivalent to cvec4.zww).
        /// </summary>
        public cvec3 baa => new cvec3(z, w, w);
        
        /// <summary>
        /// Returns cvec4.zwwx swizzling.
        /// </summary>
        public cvec4 zwwx => new cvec4(z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.baar swizzling (equivalent to cvec4.zwwx).
        /// </summary>
        public cvec4 baar => new cvec4(z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.zwwxx swizzling.
        /// </summary>
        public cvec5 zwwxx => new cvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.baarr swizzling (equivalent to cvec4.zwwxx).
        /// </summary>
        public cvec5 baarr => new cvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.zwwxy swizzling.
        /// </summary>
        public cvec5 zwwxy => new cvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.baarg swizzling (equivalent to cvec4.zwwxy).
        /// </summary>
        public cvec5 baarg => new cvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.zwwxz swizzling.
        /// </summary>
        public cvec5 zwwxz => new cvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.baarb swizzling (equivalent to cvec4.zwwxz).
        /// </summary>
        public cvec5 baarb => new cvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.zwwxw swizzling.
        /// </summary>
        public cvec5 zwwxw => new cvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.baara swizzling (equivalent to cvec4.zwwxw).
        /// </summary>
        public cvec5 baara => new cvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.zwwy swizzling.
        /// </summary>
        public cvec4 zwwy => new cvec4(z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.baag swizzling (equivalent to cvec4.zwwy).
        /// </summary>
        public cvec4 baag => new cvec4(z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.zwwyx swizzling.
        /// </summary>
        public cvec5 zwwyx => new cvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.baagr swizzling (equivalent to cvec4.zwwyx).
        /// </summary>
        public cvec5 baagr => new cvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.zwwyy swizzling.
        /// </summary>
        public cvec5 zwwyy => new cvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.baagg swizzling (equivalent to cvec4.zwwyy).
        /// </summary>
        public cvec5 baagg => new cvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.zwwyz swizzling.
        /// </summary>
        public cvec5 zwwyz => new cvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.baagb swizzling (equivalent to cvec4.zwwyz).
        /// </summary>
        public cvec5 baagb => new cvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.zwwyw swizzling.
        /// </summary>
        public cvec5 zwwyw => new cvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.baaga swizzling (equivalent to cvec4.zwwyw).
        /// </summary>
        public cvec5 baaga => new cvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.zwwz swizzling.
        /// </summary>
        public cvec4 zwwz => new cvec4(z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.baab swizzling (equivalent to cvec4.zwwz).
        /// </summary>
        public cvec4 baab => new cvec4(z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.zwwzx swizzling.
        /// </summary>
        public cvec5 zwwzx => new cvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.baabr swizzling (equivalent to cvec4.zwwzx).
        /// </summary>
        public cvec5 baabr => new cvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.zwwzy swizzling.
        /// </summary>
        public cvec5 zwwzy => new cvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.baabg swizzling (equivalent to cvec4.zwwzy).
        /// </summary>
        public cvec5 baabg => new cvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.zwwzz swizzling.
        /// </summary>
        public cvec5 zwwzz => new cvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.baabb swizzling (equivalent to cvec4.zwwzz).
        /// </summary>
        public cvec5 baabb => new cvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.zwwzw swizzling.
        /// </summary>
        public cvec5 zwwzw => new cvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.baaba swizzling (equivalent to cvec4.zwwzw).
        /// </summary>
        public cvec5 baaba => new cvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.zwww swizzling.
        /// </summary>
        public cvec4 zwww => new cvec4(z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.baaa swizzling (equivalent to cvec4.zwww).
        /// </summary>
        public cvec4 baaa => new cvec4(z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.zwwwx swizzling.
        /// </summary>
        public cvec5 zwwwx => new cvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.baaar swizzling (equivalent to cvec4.zwwwx).
        /// </summary>
        public cvec5 baaar => new cvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.zwwwy swizzling.
        /// </summary>
        public cvec5 zwwwy => new cvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.baaag swizzling (equivalent to cvec4.zwwwy).
        /// </summary>
        public cvec5 baaag => new cvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.zwwwz swizzling.
        /// </summary>
        public cvec5 zwwwz => new cvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.baaab swizzling (equivalent to cvec4.zwwwz).
        /// </summary>
        public cvec5 baaab => new cvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.zwwww swizzling.
        /// </summary>
        public cvec5 zwwww => new cvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns cvec4.baaaa swizzling (equivalent to cvec4.zwwww).
        /// </summary>
        public cvec5 baaaa => new cvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns cvec4.wx swizzling.
        /// </summary>
        public cvec2 wx => new cvec2(w, x);
        
        /// <summary>
        /// Returns cvec4.ar swizzling (equivalent to cvec4.wx).
        /// </summary>
        public cvec2 ar => new cvec2(w, x);
        
        /// <summary>
        /// Returns cvec4.wxx swizzling.
        /// </summary>
        public cvec3 wxx => new cvec3(w, x, x);
        
        /// <summary>
        /// Returns cvec4.arr swizzling (equivalent to cvec4.wxx).
        /// </summary>
        public cvec3 arr => new cvec3(w, x, x);
        
        /// <summary>
        /// Returns cvec4.wxxx swizzling.
        /// </summary>
        public cvec4 wxxx => new cvec4(w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.arrr swizzling (equivalent to cvec4.wxxx).
        /// </summary>
        public cvec4 arrr => new cvec4(w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.wxxxx swizzling.
        /// </summary>
        public cvec5 wxxxx => new cvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.arrrr swizzling (equivalent to cvec4.wxxxx).
        /// </summary>
        public cvec5 arrrr => new cvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.wxxxy swizzling.
        /// </summary>
        public cvec5 wxxxy => new cvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.arrrg swizzling (equivalent to cvec4.wxxxy).
        /// </summary>
        public cvec5 arrrg => new cvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.wxxxz swizzling.
        /// </summary>
        public cvec5 wxxxz => new cvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.arrrb swizzling (equivalent to cvec4.wxxxz).
        /// </summary>
        public cvec5 arrrb => new cvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.wxxxw swizzling.
        /// </summary>
        public cvec5 wxxxw => new cvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.arrra swizzling (equivalent to cvec4.wxxxw).
        /// </summary>
        public cvec5 arrra => new cvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.wxxy swizzling.
        /// </summary>
        public cvec4 wxxy => new cvec4(w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.arrg swizzling (equivalent to cvec4.wxxy).
        /// </summary>
        public cvec4 arrg => new cvec4(w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.wxxyx swizzling.
        /// </summary>
        public cvec5 wxxyx => new cvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.arrgr swizzling (equivalent to cvec4.wxxyx).
        /// </summary>
        public cvec5 arrgr => new cvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.wxxyy swizzling.
        /// </summary>
        public cvec5 wxxyy => new cvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.arrgg swizzling (equivalent to cvec4.wxxyy).
        /// </summary>
        public cvec5 arrgg => new cvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.wxxyz swizzling.
        /// </summary>
        public cvec5 wxxyz => new cvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.arrgb swizzling (equivalent to cvec4.wxxyz).
        /// </summary>
        public cvec5 arrgb => new cvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.wxxyw swizzling.
        /// </summary>
        public cvec5 wxxyw => new cvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.arrga swizzling (equivalent to cvec4.wxxyw).
        /// </summary>
        public cvec5 arrga => new cvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.wxxz swizzling.
        /// </summary>
        public cvec4 wxxz => new cvec4(w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.arrb swizzling (equivalent to cvec4.wxxz).
        /// </summary>
        public cvec4 arrb => new cvec4(w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.wxxzx swizzling.
        /// </summary>
        public cvec5 wxxzx => new cvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.arrbr swizzling (equivalent to cvec4.wxxzx).
        /// </summary>
        public cvec5 arrbr => new cvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.wxxzy swizzling.
        /// </summary>
        public cvec5 wxxzy => new cvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.arrbg swizzling (equivalent to cvec4.wxxzy).
        /// </summary>
        public cvec5 arrbg => new cvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.wxxzz swizzling.
        /// </summary>
        public cvec5 wxxzz => new cvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.arrbb swizzling (equivalent to cvec4.wxxzz).
        /// </summary>
        public cvec5 arrbb => new cvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.wxxzw swizzling.
        /// </summary>
        public cvec5 wxxzw => new cvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.arrba swizzling (equivalent to cvec4.wxxzw).
        /// </summary>
        public cvec5 arrba => new cvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.wxxw swizzling.
        /// </summary>
        public cvec4 wxxw => new cvec4(w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.arra swizzling (equivalent to cvec4.wxxw).
        /// </summary>
        public cvec4 arra => new cvec4(w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.wxxwx swizzling.
        /// </summary>
        public cvec5 wxxwx => new cvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.arrar swizzling (equivalent to cvec4.wxxwx).
        /// </summary>
        public cvec5 arrar => new cvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.wxxwy swizzling.
        /// </summary>
        public cvec5 wxxwy => new cvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.arrag swizzling (equivalent to cvec4.wxxwy).
        /// </summary>
        public cvec5 arrag => new cvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.wxxwz swizzling.
        /// </summary>
        public cvec5 wxxwz => new cvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.arrab swizzling (equivalent to cvec4.wxxwz).
        /// </summary>
        public cvec5 arrab => new cvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.wxxww swizzling.
        /// </summary>
        public cvec5 wxxww => new cvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.arraa swizzling (equivalent to cvec4.wxxww).
        /// </summary>
        public cvec5 arraa => new cvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.wxy swizzling.
        /// </summary>
        public cvec3 wxy => new cvec3(w, x, y);
        
        /// <summary>
        /// Returns cvec4.arg swizzling (equivalent to cvec4.wxy).
        /// </summary>
        public cvec3 arg => new cvec3(w, x, y);
        
        /// <summary>
        /// Returns cvec4.wxyx swizzling.
        /// </summary>
        public cvec4 wxyx => new cvec4(w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.argr swizzling (equivalent to cvec4.wxyx).
        /// </summary>
        public cvec4 argr => new cvec4(w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.wxyxx swizzling.
        /// </summary>
        public cvec5 wxyxx => new cvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.argrr swizzling (equivalent to cvec4.wxyxx).
        /// </summary>
        public cvec5 argrr => new cvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.wxyxy swizzling.
        /// </summary>
        public cvec5 wxyxy => new cvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.argrg swizzling (equivalent to cvec4.wxyxy).
        /// </summary>
        public cvec5 argrg => new cvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.wxyxz swizzling.
        /// </summary>
        public cvec5 wxyxz => new cvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.argrb swizzling (equivalent to cvec4.wxyxz).
        /// </summary>
        public cvec5 argrb => new cvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.wxyxw swizzling.
        /// </summary>
        public cvec5 wxyxw => new cvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.argra swizzling (equivalent to cvec4.wxyxw).
        /// </summary>
        public cvec5 argra => new cvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.wxyy swizzling.
        /// </summary>
        public cvec4 wxyy => new cvec4(w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.argg swizzling (equivalent to cvec4.wxyy).
        /// </summary>
        public cvec4 argg => new cvec4(w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.wxyyx swizzling.
        /// </summary>
        public cvec5 wxyyx => new cvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.arggr swizzling (equivalent to cvec4.wxyyx).
        /// </summary>
        public cvec5 arggr => new cvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.wxyyy swizzling.
        /// </summary>
        public cvec5 wxyyy => new cvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.arggg swizzling (equivalent to cvec4.wxyyy).
        /// </summary>
        public cvec5 arggg => new cvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.wxyyz swizzling.
        /// </summary>
        public cvec5 wxyyz => new cvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.arggb swizzling (equivalent to cvec4.wxyyz).
        /// </summary>
        public cvec5 arggb => new cvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.wxyyw swizzling.
        /// </summary>
        public cvec5 wxyyw => new cvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.argga swizzling (equivalent to cvec4.wxyyw).
        /// </summary>
        public cvec5 argga => new cvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.wxyz swizzling.
        /// </summary>
        public cvec4 wxyz => new cvec4(w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.argb swizzling (equivalent to cvec4.wxyz).
        /// </summary>
        public cvec4 argb => new cvec4(w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.wxyzx swizzling.
        /// </summary>
        public cvec5 wxyzx => new cvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.argbr swizzling (equivalent to cvec4.wxyzx).
        /// </summary>
        public cvec5 argbr => new cvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.wxyzy swizzling.
        /// </summary>
        public cvec5 wxyzy => new cvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.argbg swizzling (equivalent to cvec4.wxyzy).
        /// </summary>
        public cvec5 argbg => new cvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.wxyzz swizzling.
        /// </summary>
        public cvec5 wxyzz => new cvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.argbb swizzling (equivalent to cvec4.wxyzz).
        /// </summary>
        public cvec5 argbb => new cvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.wxyzw swizzling.
        /// </summary>
        public cvec5 wxyzw => new cvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.argba swizzling (equivalent to cvec4.wxyzw).
        /// </summary>
        public cvec5 argba => new cvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.wxyw swizzling.
        /// </summary>
        public cvec4 wxyw => new cvec4(w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.arga swizzling (equivalent to cvec4.wxyw).
        /// </summary>
        public cvec4 arga => new cvec4(w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.wxywx swizzling.
        /// </summary>
        public cvec5 wxywx => new cvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.argar swizzling (equivalent to cvec4.wxywx).
        /// </summary>
        public cvec5 argar => new cvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.wxywy swizzling.
        /// </summary>
        public cvec5 wxywy => new cvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.argag swizzling (equivalent to cvec4.wxywy).
        /// </summary>
        public cvec5 argag => new cvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.wxywz swizzling.
        /// </summary>
        public cvec5 wxywz => new cvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.argab swizzling (equivalent to cvec4.wxywz).
        /// </summary>
        public cvec5 argab => new cvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.wxyww swizzling.
        /// </summary>
        public cvec5 wxyww => new cvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.argaa swizzling (equivalent to cvec4.wxyww).
        /// </summary>
        public cvec5 argaa => new cvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.wxz swizzling.
        /// </summary>
        public cvec3 wxz => new cvec3(w, x, z);
        
        /// <summary>
        /// Returns cvec4.arb swizzling (equivalent to cvec4.wxz).
        /// </summary>
        public cvec3 arb => new cvec3(w, x, z);
        
        /// <summary>
        /// Returns cvec4.wxzx swizzling.
        /// </summary>
        public cvec4 wxzx => new cvec4(w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.arbr swizzling (equivalent to cvec4.wxzx).
        /// </summary>
        public cvec4 arbr => new cvec4(w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.wxzxx swizzling.
        /// </summary>
        public cvec5 wxzxx => new cvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.arbrr swizzling (equivalent to cvec4.wxzxx).
        /// </summary>
        public cvec5 arbrr => new cvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.wxzxy swizzling.
        /// </summary>
        public cvec5 wxzxy => new cvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.arbrg swizzling (equivalent to cvec4.wxzxy).
        /// </summary>
        public cvec5 arbrg => new cvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.wxzxz swizzling.
        /// </summary>
        public cvec5 wxzxz => new cvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.arbrb swizzling (equivalent to cvec4.wxzxz).
        /// </summary>
        public cvec5 arbrb => new cvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.wxzxw swizzling.
        /// </summary>
        public cvec5 wxzxw => new cvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.arbra swizzling (equivalent to cvec4.wxzxw).
        /// </summary>
        public cvec5 arbra => new cvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.wxzy swizzling.
        /// </summary>
        public cvec4 wxzy => new cvec4(w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.arbg swizzling (equivalent to cvec4.wxzy).
        /// </summary>
        public cvec4 arbg => new cvec4(w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.wxzyx swizzling.
        /// </summary>
        public cvec5 wxzyx => new cvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.arbgr swizzling (equivalent to cvec4.wxzyx).
        /// </summary>
        public cvec5 arbgr => new cvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.wxzyy swizzling.
        /// </summary>
        public cvec5 wxzyy => new cvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.arbgg swizzling (equivalent to cvec4.wxzyy).
        /// </summary>
        public cvec5 arbgg => new cvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.wxzyz swizzling.
        /// </summary>
        public cvec5 wxzyz => new cvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.arbgb swizzling (equivalent to cvec4.wxzyz).
        /// </summary>
        public cvec5 arbgb => new cvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.wxzyw swizzling.
        /// </summary>
        public cvec5 wxzyw => new cvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.arbga swizzling (equivalent to cvec4.wxzyw).
        /// </summary>
        public cvec5 arbga => new cvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.wxzz swizzling.
        /// </summary>
        public cvec4 wxzz => new cvec4(w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.arbb swizzling (equivalent to cvec4.wxzz).
        /// </summary>
        public cvec4 arbb => new cvec4(w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.wxzzx swizzling.
        /// </summary>
        public cvec5 wxzzx => new cvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.arbbr swizzling (equivalent to cvec4.wxzzx).
        /// </summary>
        public cvec5 arbbr => new cvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.wxzzy swizzling.
        /// </summary>
        public cvec5 wxzzy => new cvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.arbbg swizzling (equivalent to cvec4.wxzzy).
        /// </summary>
        public cvec5 arbbg => new cvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.wxzzz swizzling.
        /// </summary>
        public cvec5 wxzzz => new cvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.arbbb swizzling (equivalent to cvec4.wxzzz).
        /// </summary>
        public cvec5 arbbb => new cvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.wxzzw swizzling.
        /// </summary>
        public cvec5 wxzzw => new cvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.arbba swizzling (equivalent to cvec4.wxzzw).
        /// </summary>
        public cvec5 arbba => new cvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.wxzw swizzling.
        /// </summary>
        public cvec4 wxzw => new cvec4(w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.arba swizzling (equivalent to cvec4.wxzw).
        /// </summary>
        public cvec4 arba => new cvec4(w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.wxzwx swizzling.
        /// </summary>
        public cvec5 wxzwx => new cvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.arbar swizzling (equivalent to cvec4.wxzwx).
        /// </summary>
        public cvec5 arbar => new cvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.wxzwy swizzling.
        /// </summary>
        public cvec5 wxzwy => new cvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.arbag swizzling (equivalent to cvec4.wxzwy).
        /// </summary>
        public cvec5 arbag => new cvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.wxzwz swizzling.
        /// </summary>
        public cvec5 wxzwz => new cvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.arbab swizzling (equivalent to cvec4.wxzwz).
        /// </summary>
        public cvec5 arbab => new cvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.wxzww swizzling.
        /// </summary>
        public cvec5 wxzww => new cvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.arbaa swizzling (equivalent to cvec4.wxzww).
        /// </summary>
        public cvec5 arbaa => new cvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.wxw swizzling.
        /// </summary>
        public cvec3 wxw => new cvec3(w, x, w);
        
        /// <summary>
        /// Returns cvec4.ara swizzling (equivalent to cvec4.wxw).
        /// </summary>
        public cvec3 ara => new cvec3(w, x, w);
        
        /// <summary>
        /// Returns cvec4.wxwx swizzling.
        /// </summary>
        public cvec4 wxwx => new cvec4(w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.arar swizzling (equivalent to cvec4.wxwx).
        /// </summary>
        public cvec4 arar => new cvec4(w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.wxwxx swizzling.
        /// </summary>
        public cvec5 wxwxx => new cvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.ararr swizzling (equivalent to cvec4.wxwxx).
        /// </summary>
        public cvec5 ararr => new cvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.wxwxy swizzling.
        /// </summary>
        public cvec5 wxwxy => new cvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.ararg swizzling (equivalent to cvec4.wxwxy).
        /// </summary>
        public cvec5 ararg => new cvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.wxwxz swizzling.
        /// </summary>
        public cvec5 wxwxz => new cvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.ararb swizzling (equivalent to cvec4.wxwxz).
        /// </summary>
        public cvec5 ararb => new cvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.wxwxw swizzling.
        /// </summary>
        public cvec5 wxwxw => new cvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.arara swizzling (equivalent to cvec4.wxwxw).
        /// </summary>
        public cvec5 arara => new cvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.wxwy swizzling.
        /// </summary>
        public cvec4 wxwy => new cvec4(w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.arag swizzling (equivalent to cvec4.wxwy).
        /// </summary>
        public cvec4 arag => new cvec4(w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.wxwyx swizzling.
        /// </summary>
        public cvec5 wxwyx => new cvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.aragr swizzling (equivalent to cvec4.wxwyx).
        /// </summary>
        public cvec5 aragr => new cvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.wxwyy swizzling.
        /// </summary>
        public cvec5 wxwyy => new cvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.aragg swizzling (equivalent to cvec4.wxwyy).
        /// </summary>
        public cvec5 aragg => new cvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.wxwyz swizzling.
        /// </summary>
        public cvec5 wxwyz => new cvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.aragb swizzling (equivalent to cvec4.wxwyz).
        /// </summary>
        public cvec5 aragb => new cvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.wxwyw swizzling.
        /// </summary>
        public cvec5 wxwyw => new cvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.araga swizzling (equivalent to cvec4.wxwyw).
        /// </summary>
        public cvec5 araga => new cvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.wxwz swizzling.
        /// </summary>
        public cvec4 wxwz => new cvec4(w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.arab swizzling (equivalent to cvec4.wxwz).
        /// </summary>
        public cvec4 arab => new cvec4(w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.wxwzx swizzling.
        /// </summary>
        public cvec5 wxwzx => new cvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.arabr swizzling (equivalent to cvec4.wxwzx).
        /// </summary>
        public cvec5 arabr => new cvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.wxwzy swizzling.
        /// </summary>
        public cvec5 wxwzy => new cvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.arabg swizzling (equivalent to cvec4.wxwzy).
        /// </summary>
        public cvec5 arabg => new cvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.wxwzz swizzling.
        /// </summary>
        public cvec5 wxwzz => new cvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.arabb swizzling (equivalent to cvec4.wxwzz).
        /// </summary>
        public cvec5 arabb => new cvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.wxwzw swizzling.
        /// </summary>
        public cvec5 wxwzw => new cvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.araba swizzling (equivalent to cvec4.wxwzw).
        /// </summary>
        public cvec5 araba => new cvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.wxww swizzling.
        /// </summary>
        public cvec4 wxww => new cvec4(w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.araa swizzling (equivalent to cvec4.wxww).
        /// </summary>
        public cvec4 araa => new cvec4(w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.wxwwx swizzling.
        /// </summary>
        public cvec5 wxwwx => new cvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.araar swizzling (equivalent to cvec4.wxwwx).
        /// </summary>
        public cvec5 araar => new cvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.wxwwy swizzling.
        /// </summary>
        public cvec5 wxwwy => new cvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.araag swizzling (equivalent to cvec4.wxwwy).
        /// </summary>
        public cvec5 araag => new cvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.wxwwz swizzling.
        /// </summary>
        public cvec5 wxwwz => new cvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.araab swizzling (equivalent to cvec4.wxwwz).
        /// </summary>
        public cvec5 araab => new cvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.wxwww swizzling.
        /// </summary>
        public cvec5 wxwww => new cvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.araaa swizzling (equivalent to cvec4.wxwww).
        /// </summary>
        public cvec5 araaa => new cvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.wy swizzling.
        /// </summary>
        public cvec2 wy => new cvec2(w, y);
        
        /// <summary>
        /// Returns cvec4.ag swizzling (equivalent to cvec4.wy).
        /// </summary>
        public cvec2 ag => new cvec2(w, y);
        
        /// <summary>
        /// Returns cvec4.wyx swizzling.
        /// </summary>
        public cvec3 wyx => new cvec3(w, y, x);
        
        /// <summary>
        /// Returns cvec4.agr swizzling (equivalent to cvec4.wyx).
        /// </summary>
        public cvec3 agr => new cvec3(w, y, x);
        
        /// <summary>
        /// Returns cvec4.wyxx swizzling.
        /// </summary>
        public cvec4 wyxx => new cvec4(w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.agrr swizzling (equivalent to cvec4.wyxx).
        /// </summary>
        public cvec4 agrr => new cvec4(w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.wyxxx swizzling.
        /// </summary>
        public cvec5 wyxxx => new cvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.agrrr swizzling (equivalent to cvec4.wyxxx).
        /// </summary>
        public cvec5 agrrr => new cvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.wyxxy swizzling.
        /// </summary>
        public cvec5 wyxxy => new cvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.agrrg swizzling (equivalent to cvec4.wyxxy).
        /// </summary>
        public cvec5 agrrg => new cvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.wyxxz swizzling.
        /// </summary>
        public cvec5 wyxxz => new cvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.agrrb swizzling (equivalent to cvec4.wyxxz).
        /// </summary>
        public cvec5 agrrb => new cvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.wyxxw swizzling.
        /// </summary>
        public cvec5 wyxxw => new cvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.agrra swizzling (equivalent to cvec4.wyxxw).
        /// </summary>
        public cvec5 agrra => new cvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.wyxy swizzling.
        /// </summary>
        public cvec4 wyxy => new cvec4(w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.agrg swizzling (equivalent to cvec4.wyxy).
        /// </summary>
        public cvec4 agrg => new cvec4(w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.wyxyx swizzling.
        /// </summary>
        public cvec5 wyxyx => new cvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.agrgr swizzling (equivalent to cvec4.wyxyx).
        /// </summary>
        public cvec5 agrgr => new cvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.wyxyy swizzling.
        /// </summary>
        public cvec5 wyxyy => new cvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.agrgg swizzling (equivalent to cvec4.wyxyy).
        /// </summary>
        public cvec5 agrgg => new cvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.wyxyz swizzling.
        /// </summary>
        public cvec5 wyxyz => new cvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.agrgb swizzling (equivalent to cvec4.wyxyz).
        /// </summary>
        public cvec5 agrgb => new cvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.wyxyw swizzling.
        /// </summary>
        public cvec5 wyxyw => new cvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.agrga swizzling (equivalent to cvec4.wyxyw).
        /// </summary>
        public cvec5 agrga => new cvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.wyxz swizzling.
        /// </summary>
        public cvec4 wyxz => new cvec4(w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.agrb swizzling (equivalent to cvec4.wyxz).
        /// </summary>
        public cvec4 agrb => new cvec4(w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.wyxzx swizzling.
        /// </summary>
        public cvec5 wyxzx => new cvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.agrbr swizzling (equivalent to cvec4.wyxzx).
        /// </summary>
        public cvec5 agrbr => new cvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.wyxzy swizzling.
        /// </summary>
        public cvec5 wyxzy => new cvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.agrbg swizzling (equivalent to cvec4.wyxzy).
        /// </summary>
        public cvec5 agrbg => new cvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.wyxzz swizzling.
        /// </summary>
        public cvec5 wyxzz => new cvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.agrbb swizzling (equivalent to cvec4.wyxzz).
        /// </summary>
        public cvec5 agrbb => new cvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.wyxzw swizzling.
        /// </summary>
        public cvec5 wyxzw => new cvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.agrba swizzling (equivalent to cvec4.wyxzw).
        /// </summary>
        public cvec5 agrba => new cvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.wyxw swizzling.
        /// </summary>
        public cvec4 wyxw => new cvec4(w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.agra swizzling (equivalent to cvec4.wyxw).
        /// </summary>
        public cvec4 agra => new cvec4(w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.wyxwx swizzling.
        /// </summary>
        public cvec5 wyxwx => new cvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.agrar swizzling (equivalent to cvec4.wyxwx).
        /// </summary>
        public cvec5 agrar => new cvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.wyxwy swizzling.
        /// </summary>
        public cvec5 wyxwy => new cvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.agrag swizzling (equivalent to cvec4.wyxwy).
        /// </summary>
        public cvec5 agrag => new cvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.wyxwz swizzling.
        /// </summary>
        public cvec5 wyxwz => new cvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.agrab swizzling (equivalent to cvec4.wyxwz).
        /// </summary>
        public cvec5 agrab => new cvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.wyxww swizzling.
        /// </summary>
        public cvec5 wyxww => new cvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.agraa swizzling (equivalent to cvec4.wyxww).
        /// </summary>
        public cvec5 agraa => new cvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.wyy swizzling.
        /// </summary>
        public cvec3 wyy => new cvec3(w, y, y);
        
        /// <summary>
        /// Returns cvec4.agg swizzling (equivalent to cvec4.wyy).
        /// </summary>
        public cvec3 agg => new cvec3(w, y, y);
        
        /// <summary>
        /// Returns cvec4.wyyx swizzling.
        /// </summary>
        public cvec4 wyyx => new cvec4(w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.aggr swizzling (equivalent to cvec4.wyyx).
        /// </summary>
        public cvec4 aggr => new cvec4(w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.wyyxx swizzling.
        /// </summary>
        public cvec5 wyyxx => new cvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.aggrr swizzling (equivalent to cvec4.wyyxx).
        /// </summary>
        public cvec5 aggrr => new cvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.wyyxy swizzling.
        /// </summary>
        public cvec5 wyyxy => new cvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.aggrg swizzling (equivalent to cvec4.wyyxy).
        /// </summary>
        public cvec5 aggrg => new cvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.wyyxz swizzling.
        /// </summary>
        public cvec5 wyyxz => new cvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.aggrb swizzling (equivalent to cvec4.wyyxz).
        /// </summary>
        public cvec5 aggrb => new cvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.wyyxw swizzling.
        /// </summary>
        public cvec5 wyyxw => new cvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.aggra swizzling (equivalent to cvec4.wyyxw).
        /// </summary>
        public cvec5 aggra => new cvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.wyyy swizzling.
        /// </summary>
        public cvec4 wyyy => new cvec4(w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.aggg swizzling (equivalent to cvec4.wyyy).
        /// </summary>
        public cvec4 aggg => new cvec4(w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.wyyyx swizzling.
        /// </summary>
        public cvec5 wyyyx => new cvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.agggr swizzling (equivalent to cvec4.wyyyx).
        /// </summary>
        public cvec5 agggr => new cvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.wyyyy swizzling.
        /// </summary>
        public cvec5 wyyyy => new cvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.agggg swizzling (equivalent to cvec4.wyyyy).
        /// </summary>
        public cvec5 agggg => new cvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.wyyyz swizzling.
        /// </summary>
        public cvec5 wyyyz => new cvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.agggb swizzling (equivalent to cvec4.wyyyz).
        /// </summary>
        public cvec5 agggb => new cvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.wyyyw swizzling.
        /// </summary>
        public cvec5 wyyyw => new cvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.aggga swizzling (equivalent to cvec4.wyyyw).
        /// </summary>
        public cvec5 aggga => new cvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.wyyz swizzling.
        /// </summary>
        public cvec4 wyyz => new cvec4(w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.aggb swizzling (equivalent to cvec4.wyyz).
        /// </summary>
        public cvec4 aggb => new cvec4(w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.wyyzx swizzling.
        /// </summary>
        public cvec5 wyyzx => new cvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.aggbr swizzling (equivalent to cvec4.wyyzx).
        /// </summary>
        public cvec5 aggbr => new cvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.wyyzy swizzling.
        /// </summary>
        public cvec5 wyyzy => new cvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.aggbg swizzling (equivalent to cvec4.wyyzy).
        /// </summary>
        public cvec5 aggbg => new cvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.wyyzz swizzling.
        /// </summary>
        public cvec5 wyyzz => new cvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.aggbb swizzling (equivalent to cvec4.wyyzz).
        /// </summary>
        public cvec5 aggbb => new cvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.wyyzw swizzling.
        /// </summary>
        public cvec5 wyyzw => new cvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.aggba swizzling (equivalent to cvec4.wyyzw).
        /// </summary>
        public cvec5 aggba => new cvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.wyyw swizzling.
        /// </summary>
        public cvec4 wyyw => new cvec4(w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.agga swizzling (equivalent to cvec4.wyyw).
        /// </summary>
        public cvec4 agga => new cvec4(w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.wyywx swizzling.
        /// </summary>
        public cvec5 wyywx => new cvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.aggar swizzling (equivalent to cvec4.wyywx).
        /// </summary>
        public cvec5 aggar => new cvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.wyywy swizzling.
        /// </summary>
        public cvec5 wyywy => new cvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.aggag swizzling (equivalent to cvec4.wyywy).
        /// </summary>
        public cvec5 aggag => new cvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.wyywz swizzling.
        /// </summary>
        public cvec5 wyywz => new cvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.aggab swizzling (equivalent to cvec4.wyywz).
        /// </summary>
        public cvec5 aggab => new cvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.wyyww swizzling.
        /// </summary>
        public cvec5 wyyww => new cvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.aggaa swizzling (equivalent to cvec4.wyyww).
        /// </summary>
        public cvec5 aggaa => new cvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.wyz swizzling.
        /// </summary>
        public cvec3 wyz => new cvec3(w, y, z);
        
        /// <summary>
        /// Returns cvec4.agb swizzling (equivalent to cvec4.wyz).
        /// </summary>
        public cvec3 agb => new cvec3(w, y, z);
        
        /// <summary>
        /// Returns cvec4.wyzx swizzling.
        /// </summary>
        public cvec4 wyzx => new cvec4(w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.agbr swizzling (equivalent to cvec4.wyzx).
        /// </summary>
        public cvec4 agbr => new cvec4(w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.wyzxx swizzling.
        /// </summary>
        public cvec5 wyzxx => new cvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.agbrr swizzling (equivalent to cvec4.wyzxx).
        /// </summary>
        public cvec5 agbrr => new cvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.wyzxy swizzling.
        /// </summary>
        public cvec5 wyzxy => new cvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.agbrg swizzling (equivalent to cvec4.wyzxy).
        /// </summary>
        public cvec5 agbrg => new cvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.wyzxz swizzling.
        /// </summary>
        public cvec5 wyzxz => new cvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.agbrb swizzling (equivalent to cvec4.wyzxz).
        /// </summary>
        public cvec5 agbrb => new cvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.wyzxw swizzling.
        /// </summary>
        public cvec5 wyzxw => new cvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.agbra swizzling (equivalent to cvec4.wyzxw).
        /// </summary>
        public cvec5 agbra => new cvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.wyzy swizzling.
        /// </summary>
        public cvec4 wyzy => new cvec4(w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.agbg swizzling (equivalent to cvec4.wyzy).
        /// </summary>
        public cvec4 agbg => new cvec4(w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.wyzyx swizzling.
        /// </summary>
        public cvec5 wyzyx => new cvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.agbgr swizzling (equivalent to cvec4.wyzyx).
        /// </summary>
        public cvec5 agbgr => new cvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.wyzyy swizzling.
        /// </summary>
        public cvec5 wyzyy => new cvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.agbgg swizzling (equivalent to cvec4.wyzyy).
        /// </summary>
        public cvec5 agbgg => new cvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.wyzyz swizzling.
        /// </summary>
        public cvec5 wyzyz => new cvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.agbgb swizzling (equivalent to cvec4.wyzyz).
        /// </summary>
        public cvec5 agbgb => new cvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.wyzyw swizzling.
        /// </summary>
        public cvec5 wyzyw => new cvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.agbga swizzling (equivalent to cvec4.wyzyw).
        /// </summary>
        public cvec5 agbga => new cvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.wyzz swizzling.
        /// </summary>
        public cvec4 wyzz => new cvec4(w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.agbb swizzling (equivalent to cvec4.wyzz).
        /// </summary>
        public cvec4 agbb => new cvec4(w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.wyzzx swizzling.
        /// </summary>
        public cvec5 wyzzx => new cvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.agbbr swizzling (equivalent to cvec4.wyzzx).
        /// </summary>
        public cvec5 agbbr => new cvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.wyzzy swizzling.
        /// </summary>
        public cvec5 wyzzy => new cvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.agbbg swizzling (equivalent to cvec4.wyzzy).
        /// </summary>
        public cvec5 agbbg => new cvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.wyzzz swizzling.
        /// </summary>
        public cvec5 wyzzz => new cvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.agbbb swizzling (equivalent to cvec4.wyzzz).
        /// </summary>
        public cvec5 agbbb => new cvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.wyzzw swizzling.
        /// </summary>
        public cvec5 wyzzw => new cvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.agbba swizzling (equivalent to cvec4.wyzzw).
        /// </summary>
        public cvec5 agbba => new cvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.wyzw swizzling.
        /// </summary>
        public cvec4 wyzw => new cvec4(w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.agba swizzling (equivalent to cvec4.wyzw).
        /// </summary>
        public cvec4 agba => new cvec4(w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.wyzwx swizzling.
        /// </summary>
        public cvec5 wyzwx => new cvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.agbar swizzling (equivalent to cvec4.wyzwx).
        /// </summary>
        public cvec5 agbar => new cvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.wyzwy swizzling.
        /// </summary>
        public cvec5 wyzwy => new cvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.agbag swizzling (equivalent to cvec4.wyzwy).
        /// </summary>
        public cvec5 agbag => new cvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.wyzwz swizzling.
        /// </summary>
        public cvec5 wyzwz => new cvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.agbab swizzling (equivalent to cvec4.wyzwz).
        /// </summary>
        public cvec5 agbab => new cvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.wyzww swizzling.
        /// </summary>
        public cvec5 wyzww => new cvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.agbaa swizzling (equivalent to cvec4.wyzww).
        /// </summary>
        public cvec5 agbaa => new cvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.wyw swizzling.
        /// </summary>
        public cvec3 wyw => new cvec3(w, y, w);
        
        /// <summary>
        /// Returns cvec4.aga swizzling (equivalent to cvec4.wyw).
        /// </summary>
        public cvec3 aga => new cvec3(w, y, w);
        
        /// <summary>
        /// Returns cvec4.wywx swizzling.
        /// </summary>
        public cvec4 wywx => new cvec4(w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.agar swizzling (equivalent to cvec4.wywx).
        /// </summary>
        public cvec4 agar => new cvec4(w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.wywxx swizzling.
        /// </summary>
        public cvec5 wywxx => new cvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.agarr swizzling (equivalent to cvec4.wywxx).
        /// </summary>
        public cvec5 agarr => new cvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.wywxy swizzling.
        /// </summary>
        public cvec5 wywxy => new cvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.agarg swizzling (equivalent to cvec4.wywxy).
        /// </summary>
        public cvec5 agarg => new cvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.wywxz swizzling.
        /// </summary>
        public cvec5 wywxz => new cvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.agarb swizzling (equivalent to cvec4.wywxz).
        /// </summary>
        public cvec5 agarb => new cvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.wywxw swizzling.
        /// </summary>
        public cvec5 wywxw => new cvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.agara swizzling (equivalent to cvec4.wywxw).
        /// </summary>
        public cvec5 agara => new cvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.wywy swizzling.
        /// </summary>
        public cvec4 wywy => new cvec4(w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.agag swizzling (equivalent to cvec4.wywy).
        /// </summary>
        public cvec4 agag => new cvec4(w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.wywyx swizzling.
        /// </summary>
        public cvec5 wywyx => new cvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.agagr swizzling (equivalent to cvec4.wywyx).
        /// </summary>
        public cvec5 agagr => new cvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.wywyy swizzling.
        /// </summary>
        public cvec5 wywyy => new cvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.agagg swizzling (equivalent to cvec4.wywyy).
        /// </summary>
        public cvec5 agagg => new cvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.wywyz swizzling.
        /// </summary>
        public cvec5 wywyz => new cvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.agagb swizzling (equivalent to cvec4.wywyz).
        /// </summary>
        public cvec5 agagb => new cvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.wywyw swizzling.
        /// </summary>
        public cvec5 wywyw => new cvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.agaga swizzling (equivalent to cvec4.wywyw).
        /// </summary>
        public cvec5 agaga => new cvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.wywz swizzling.
        /// </summary>
        public cvec4 wywz => new cvec4(w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.agab swizzling (equivalent to cvec4.wywz).
        /// </summary>
        public cvec4 agab => new cvec4(w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.wywzx swizzling.
        /// </summary>
        public cvec5 wywzx => new cvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.agabr swizzling (equivalent to cvec4.wywzx).
        /// </summary>
        public cvec5 agabr => new cvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.wywzy swizzling.
        /// </summary>
        public cvec5 wywzy => new cvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.agabg swizzling (equivalent to cvec4.wywzy).
        /// </summary>
        public cvec5 agabg => new cvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.wywzz swizzling.
        /// </summary>
        public cvec5 wywzz => new cvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.agabb swizzling (equivalent to cvec4.wywzz).
        /// </summary>
        public cvec5 agabb => new cvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.wywzw swizzling.
        /// </summary>
        public cvec5 wywzw => new cvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.agaba swizzling (equivalent to cvec4.wywzw).
        /// </summary>
        public cvec5 agaba => new cvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.wyww swizzling.
        /// </summary>
        public cvec4 wyww => new cvec4(w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.agaa swizzling (equivalent to cvec4.wyww).
        /// </summary>
        public cvec4 agaa => new cvec4(w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.wywwx swizzling.
        /// </summary>
        public cvec5 wywwx => new cvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.agaar swizzling (equivalent to cvec4.wywwx).
        /// </summary>
        public cvec5 agaar => new cvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.wywwy swizzling.
        /// </summary>
        public cvec5 wywwy => new cvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.agaag swizzling (equivalent to cvec4.wywwy).
        /// </summary>
        public cvec5 agaag => new cvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.wywwz swizzling.
        /// </summary>
        public cvec5 wywwz => new cvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.agaab swizzling (equivalent to cvec4.wywwz).
        /// </summary>
        public cvec5 agaab => new cvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.wywww swizzling.
        /// </summary>
        public cvec5 wywww => new cvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.agaaa swizzling (equivalent to cvec4.wywww).
        /// </summary>
        public cvec5 agaaa => new cvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.wz swizzling.
        /// </summary>
        public cvec2 wz => new cvec2(w, z);
        
        /// <summary>
        /// Returns cvec4.ab swizzling (equivalent to cvec4.wz).
        /// </summary>
        public cvec2 ab => new cvec2(w, z);
        
        /// <summary>
        /// Returns cvec4.wzx swizzling.
        /// </summary>
        public cvec3 wzx => new cvec3(w, z, x);
        
        /// <summary>
        /// Returns cvec4.abr swizzling (equivalent to cvec4.wzx).
        /// </summary>
        public cvec3 abr => new cvec3(w, z, x);
        
        /// <summary>
        /// Returns cvec4.wzxx swizzling.
        /// </summary>
        public cvec4 wzxx => new cvec4(w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.abrr swizzling (equivalent to cvec4.wzxx).
        /// </summary>
        public cvec4 abrr => new cvec4(w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.wzxxx swizzling.
        /// </summary>
        public cvec5 wzxxx => new cvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.abrrr swizzling (equivalent to cvec4.wzxxx).
        /// </summary>
        public cvec5 abrrr => new cvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.wzxxy swizzling.
        /// </summary>
        public cvec5 wzxxy => new cvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.abrrg swizzling (equivalent to cvec4.wzxxy).
        /// </summary>
        public cvec5 abrrg => new cvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.wzxxz swizzling.
        /// </summary>
        public cvec5 wzxxz => new cvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.abrrb swizzling (equivalent to cvec4.wzxxz).
        /// </summary>
        public cvec5 abrrb => new cvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.wzxxw swizzling.
        /// </summary>
        public cvec5 wzxxw => new cvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.abrra swizzling (equivalent to cvec4.wzxxw).
        /// </summary>
        public cvec5 abrra => new cvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.wzxy swizzling.
        /// </summary>
        public cvec4 wzxy => new cvec4(w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.abrg swizzling (equivalent to cvec4.wzxy).
        /// </summary>
        public cvec4 abrg => new cvec4(w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.wzxyx swizzling.
        /// </summary>
        public cvec5 wzxyx => new cvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.abrgr swizzling (equivalent to cvec4.wzxyx).
        /// </summary>
        public cvec5 abrgr => new cvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.wzxyy swizzling.
        /// </summary>
        public cvec5 wzxyy => new cvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.abrgg swizzling (equivalent to cvec4.wzxyy).
        /// </summary>
        public cvec5 abrgg => new cvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.wzxyz swizzling.
        /// </summary>
        public cvec5 wzxyz => new cvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.abrgb swizzling (equivalent to cvec4.wzxyz).
        /// </summary>
        public cvec5 abrgb => new cvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.wzxyw swizzling.
        /// </summary>
        public cvec5 wzxyw => new cvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.abrga swizzling (equivalent to cvec4.wzxyw).
        /// </summary>
        public cvec5 abrga => new cvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.wzxz swizzling.
        /// </summary>
        public cvec4 wzxz => new cvec4(w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.abrb swizzling (equivalent to cvec4.wzxz).
        /// </summary>
        public cvec4 abrb => new cvec4(w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.wzxzx swizzling.
        /// </summary>
        public cvec5 wzxzx => new cvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.abrbr swizzling (equivalent to cvec4.wzxzx).
        /// </summary>
        public cvec5 abrbr => new cvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.wzxzy swizzling.
        /// </summary>
        public cvec5 wzxzy => new cvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.abrbg swizzling (equivalent to cvec4.wzxzy).
        /// </summary>
        public cvec5 abrbg => new cvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.wzxzz swizzling.
        /// </summary>
        public cvec5 wzxzz => new cvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.abrbb swizzling (equivalent to cvec4.wzxzz).
        /// </summary>
        public cvec5 abrbb => new cvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.wzxzw swizzling.
        /// </summary>
        public cvec5 wzxzw => new cvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.abrba swizzling (equivalent to cvec4.wzxzw).
        /// </summary>
        public cvec5 abrba => new cvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.wzxw swizzling.
        /// </summary>
        public cvec4 wzxw => new cvec4(w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.abra swizzling (equivalent to cvec4.wzxw).
        /// </summary>
        public cvec4 abra => new cvec4(w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.wzxwx swizzling.
        /// </summary>
        public cvec5 wzxwx => new cvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.abrar swizzling (equivalent to cvec4.wzxwx).
        /// </summary>
        public cvec5 abrar => new cvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.wzxwy swizzling.
        /// </summary>
        public cvec5 wzxwy => new cvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.abrag swizzling (equivalent to cvec4.wzxwy).
        /// </summary>
        public cvec5 abrag => new cvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.wzxwz swizzling.
        /// </summary>
        public cvec5 wzxwz => new cvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.abrab swizzling (equivalent to cvec4.wzxwz).
        /// </summary>
        public cvec5 abrab => new cvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.wzxww swizzling.
        /// </summary>
        public cvec5 wzxww => new cvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.abraa swizzling (equivalent to cvec4.wzxww).
        /// </summary>
        public cvec5 abraa => new cvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.wzy swizzling.
        /// </summary>
        public cvec3 wzy => new cvec3(w, z, y);
        
        /// <summary>
        /// Returns cvec4.abg swizzling (equivalent to cvec4.wzy).
        /// </summary>
        public cvec3 abg => new cvec3(w, z, y);
        
        /// <summary>
        /// Returns cvec4.wzyx swizzling.
        /// </summary>
        public cvec4 wzyx => new cvec4(w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.abgr swizzling (equivalent to cvec4.wzyx).
        /// </summary>
        public cvec4 abgr => new cvec4(w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.wzyxx swizzling.
        /// </summary>
        public cvec5 wzyxx => new cvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.abgrr swizzling (equivalent to cvec4.wzyxx).
        /// </summary>
        public cvec5 abgrr => new cvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.wzyxy swizzling.
        /// </summary>
        public cvec5 wzyxy => new cvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.abgrg swizzling (equivalent to cvec4.wzyxy).
        /// </summary>
        public cvec5 abgrg => new cvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.wzyxz swizzling.
        /// </summary>
        public cvec5 wzyxz => new cvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.abgrb swizzling (equivalent to cvec4.wzyxz).
        /// </summary>
        public cvec5 abgrb => new cvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.wzyxw swizzling.
        /// </summary>
        public cvec5 wzyxw => new cvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.abgra swizzling (equivalent to cvec4.wzyxw).
        /// </summary>
        public cvec5 abgra => new cvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.wzyy swizzling.
        /// </summary>
        public cvec4 wzyy => new cvec4(w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.abgg swizzling (equivalent to cvec4.wzyy).
        /// </summary>
        public cvec4 abgg => new cvec4(w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.wzyyx swizzling.
        /// </summary>
        public cvec5 wzyyx => new cvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.abggr swizzling (equivalent to cvec4.wzyyx).
        /// </summary>
        public cvec5 abggr => new cvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.wzyyy swizzling.
        /// </summary>
        public cvec5 wzyyy => new cvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.abggg swizzling (equivalent to cvec4.wzyyy).
        /// </summary>
        public cvec5 abggg => new cvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.wzyyz swizzling.
        /// </summary>
        public cvec5 wzyyz => new cvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.abggb swizzling (equivalent to cvec4.wzyyz).
        /// </summary>
        public cvec5 abggb => new cvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.wzyyw swizzling.
        /// </summary>
        public cvec5 wzyyw => new cvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.abgga swizzling (equivalent to cvec4.wzyyw).
        /// </summary>
        public cvec5 abgga => new cvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.wzyz swizzling.
        /// </summary>
        public cvec4 wzyz => new cvec4(w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.abgb swizzling (equivalent to cvec4.wzyz).
        /// </summary>
        public cvec4 abgb => new cvec4(w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.wzyzx swizzling.
        /// </summary>
        public cvec5 wzyzx => new cvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.abgbr swizzling (equivalent to cvec4.wzyzx).
        /// </summary>
        public cvec5 abgbr => new cvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.wzyzy swizzling.
        /// </summary>
        public cvec5 wzyzy => new cvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.abgbg swizzling (equivalent to cvec4.wzyzy).
        /// </summary>
        public cvec5 abgbg => new cvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.wzyzz swizzling.
        /// </summary>
        public cvec5 wzyzz => new cvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.abgbb swizzling (equivalent to cvec4.wzyzz).
        /// </summary>
        public cvec5 abgbb => new cvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.wzyzw swizzling.
        /// </summary>
        public cvec5 wzyzw => new cvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.abgba swizzling (equivalent to cvec4.wzyzw).
        /// </summary>
        public cvec5 abgba => new cvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.wzyw swizzling.
        /// </summary>
        public cvec4 wzyw => new cvec4(w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.abga swizzling (equivalent to cvec4.wzyw).
        /// </summary>
        public cvec4 abga => new cvec4(w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.wzywx swizzling.
        /// </summary>
        public cvec5 wzywx => new cvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.abgar swizzling (equivalent to cvec4.wzywx).
        /// </summary>
        public cvec5 abgar => new cvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.wzywy swizzling.
        /// </summary>
        public cvec5 wzywy => new cvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.abgag swizzling (equivalent to cvec4.wzywy).
        /// </summary>
        public cvec5 abgag => new cvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.wzywz swizzling.
        /// </summary>
        public cvec5 wzywz => new cvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.abgab swizzling (equivalent to cvec4.wzywz).
        /// </summary>
        public cvec5 abgab => new cvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.wzyww swizzling.
        /// </summary>
        public cvec5 wzyww => new cvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.abgaa swizzling (equivalent to cvec4.wzyww).
        /// </summary>
        public cvec5 abgaa => new cvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.wzz swizzling.
        /// </summary>
        public cvec3 wzz => new cvec3(w, z, z);
        
        /// <summary>
        /// Returns cvec4.abb swizzling (equivalent to cvec4.wzz).
        /// </summary>
        public cvec3 abb => new cvec3(w, z, z);
        
        /// <summary>
        /// Returns cvec4.wzzx swizzling.
        /// </summary>
        public cvec4 wzzx => new cvec4(w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.abbr swizzling (equivalent to cvec4.wzzx).
        /// </summary>
        public cvec4 abbr => new cvec4(w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.wzzxx swizzling.
        /// </summary>
        public cvec5 wzzxx => new cvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.abbrr swizzling (equivalent to cvec4.wzzxx).
        /// </summary>
        public cvec5 abbrr => new cvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.wzzxy swizzling.
        /// </summary>
        public cvec5 wzzxy => new cvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.abbrg swizzling (equivalent to cvec4.wzzxy).
        /// </summary>
        public cvec5 abbrg => new cvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.wzzxz swizzling.
        /// </summary>
        public cvec5 wzzxz => new cvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.abbrb swizzling (equivalent to cvec4.wzzxz).
        /// </summary>
        public cvec5 abbrb => new cvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.wzzxw swizzling.
        /// </summary>
        public cvec5 wzzxw => new cvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.abbra swizzling (equivalent to cvec4.wzzxw).
        /// </summary>
        public cvec5 abbra => new cvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.wzzy swizzling.
        /// </summary>
        public cvec4 wzzy => new cvec4(w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.abbg swizzling (equivalent to cvec4.wzzy).
        /// </summary>
        public cvec4 abbg => new cvec4(w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.wzzyx swizzling.
        /// </summary>
        public cvec5 wzzyx => new cvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.abbgr swizzling (equivalent to cvec4.wzzyx).
        /// </summary>
        public cvec5 abbgr => new cvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.wzzyy swizzling.
        /// </summary>
        public cvec5 wzzyy => new cvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.abbgg swizzling (equivalent to cvec4.wzzyy).
        /// </summary>
        public cvec5 abbgg => new cvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.wzzyz swizzling.
        /// </summary>
        public cvec5 wzzyz => new cvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.abbgb swizzling (equivalent to cvec4.wzzyz).
        /// </summary>
        public cvec5 abbgb => new cvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.wzzyw swizzling.
        /// </summary>
        public cvec5 wzzyw => new cvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.abbga swizzling (equivalent to cvec4.wzzyw).
        /// </summary>
        public cvec5 abbga => new cvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.wzzz swizzling.
        /// </summary>
        public cvec4 wzzz => new cvec4(w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.abbb swizzling (equivalent to cvec4.wzzz).
        /// </summary>
        public cvec4 abbb => new cvec4(w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.wzzzx swizzling.
        /// </summary>
        public cvec5 wzzzx => new cvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.abbbr swizzling (equivalent to cvec4.wzzzx).
        /// </summary>
        public cvec5 abbbr => new cvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.wzzzy swizzling.
        /// </summary>
        public cvec5 wzzzy => new cvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.abbbg swizzling (equivalent to cvec4.wzzzy).
        /// </summary>
        public cvec5 abbbg => new cvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.wzzzz swizzling.
        /// </summary>
        public cvec5 wzzzz => new cvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.abbbb swizzling (equivalent to cvec4.wzzzz).
        /// </summary>
        public cvec5 abbbb => new cvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.wzzzw swizzling.
        /// </summary>
        public cvec5 wzzzw => new cvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.abbba swizzling (equivalent to cvec4.wzzzw).
        /// </summary>
        public cvec5 abbba => new cvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.wzzw swizzling.
        /// </summary>
        public cvec4 wzzw => new cvec4(w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.abba swizzling (equivalent to cvec4.wzzw).
        /// </summary>
        public cvec4 abba => new cvec4(w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.wzzwx swizzling.
        /// </summary>
        public cvec5 wzzwx => new cvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.abbar swizzling (equivalent to cvec4.wzzwx).
        /// </summary>
        public cvec5 abbar => new cvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.wzzwy swizzling.
        /// </summary>
        public cvec5 wzzwy => new cvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.abbag swizzling (equivalent to cvec4.wzzwy).
        /// </summary>
        public cvec5 abbag => new cvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.wzzwz swizzling.
        /// </summary>
        public cvec5 wzzwz => new cvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.abbab swizzling (equivalent to cvec4.wzzwz).
        /// </summary>
        public cvec5 abbab => new cvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.wzzww swizzling.
        /// </summary>
        public cvec5 wzzww => new cvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.abbaa swizzling (equivalent to cvec4.wzzww).
        /// </summary>
        public cvec5 abbaa => new cvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.wzw swizzling.
        /// </summary>
        public cvec3 wzw => new cvec3(w, z, w);
        
        /// <summary>
        /// Returns cvec4.aba swizzling (equivalent to cvec4.wzw).
        /// </summary>
        public cvec3 aba => new cvec3(w, z, w);
        
        /// <summary>
        /// Returns cvec4.wzwx swizzling.
        /// </summary>
        public cvec4 wzwx => new cvec4(w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.abar swizzling (equivalent to cvec4.wzwx).
        /// </summary>
        public cvec4 abar => new cvec4(w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.wzwxx swizzling.
        /// </summary>
        public cvec5 wzwxx => new cvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.abarr swizzling (equivalent to cvec4.wzwxx).
        /// </summary>
        public cvec5 abarr => new cvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.wzwxy swizzling.
        /// </summary>
        public cvec5 wzwxy => new cvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.abarg swizzling (equivalent to cvec4.wzwxy).
        /// </summary>
        public cvec5 abarg => new cvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.wzwxz swizzling.
        /// </summary>
        public cvec5 wzwxz => new cvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.abarb swizzling (equivalent to cvec4.wzwxz).
        /// </summary>
        public cvec5 abarb => new cvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.wzwxw swizzling.
        /// </summary>
        public cvec5 wzwxw => new cvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.abara swizzling (equivalent to cvec4.wzwxw).
        /// </summary>
        public cvec5 abara => new cvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.wzwy swizzling.
        /// </summary>
        public cvec4 wzwy => new cvec4(w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.abag swizzling (equivalent to cvec4.wzwy).
        /// </summary>
        public cvec4 abag => new cvec4(w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.wzwyx swizzling.
        /// </summary>
        public cvec5 wzwyx => new cvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.abagr swizzling (equivalent to cvec4.wzwyx).
        /// </summary>
        public cvec5 abagr => new cvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.wzwyy swizzling.
        /// </summary>
        public cvec5 wzwyy => new cvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.abagg swizzling (equivalent to cvec4.wzwyy).
        /// </summary>
        public cvec5 abagg => new cvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.wzwyz swizzling.
        /// </summary>
        public cvec5 wzwyz => new cvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.abagb swizzling (equivalent to cvec4.wzwyz).
        /// </summary>
        public cvec5 abagb => new cvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.wzwyw swizzling.
        /// </summary>
        public cvec5 wzwyw => new cvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.abaga swizzling (equivalent to cvec4.wzwyw).
        /// </summary>
        public cvec5 abaga => new cvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.wzwz swizzling.
        /// </summary>
        public cvec4 wzwz => new cvec4(w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.abab swizzling (equivalent to cvec4.wzwz).
        /// </summary>
        public cvec4 abab => new cvec4(w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.wzwzx swizzling.
        /// </summary>
        public cvec5 wzwzx => new cvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.ababr swizzling (equivalent to cvec4.wzwzx).
        /// </summary>
        public cvec5 ababr => new cvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.wzwzy swizzling.
        /// </summary>
        public cvec5 wzwzy => new cvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.ababg swizzling (equivalent to cvec4.wzwzy).
        /// </summary>
        public cvec5 ababg => new cvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.wzwzz swizzling.
        /// </summary>
        public cvec5 wzwzz => new cvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.ababb swizzling (equivalent to cvec4.wzwzz).
        /// </summary>
        public cvec5 ababb => new cvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.wzwzw swizzling.
        /// </summary>
        public cvec5 wzwzw => new cvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.ababa swizzling (equivalent to cvec4.wzwzw).
        /// </summary>
        public cvec5 ababa => new cvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.wzww swizzling.
        /// </summary>
        public cvec4 wzww => new cvec4(w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.abaa swizzling (equivalent to cvec4.wzww).
        /// </summary>
        public cvec4 abaa => new cvec4(w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.wzwwx swizzling.
        /// </summary>
        public cvec5 wzwwx => new cvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.abaar swizzling (equivalent to cvec4.wzwwx).
        /// </summary>
        public cvec5 abaar => new cvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.wzwwy swizzling.
        /// </summary>
        public cvec5 wzwwy => new cvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.abaag swizzling (equivalent to cvec4.wzwwy).
        /// </summary>
        public cvec5 abaag => new cvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.wzwwz swizzling.
        /// </summary>
        public cvec5 wzwwz => new cvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.abaab swizzling (equivalent to cvec4.wzwwz).
        /// </summary>
        public cvec5 abaab => new cvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.wzwww swizzling.
        /// </summary>
        public cvec5 wzwww => new cvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.abaaa swizzling (equivalent to cvec4.wzwww).
        /// </summary>
        public cvec5 abaaa => new cvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.ww swizzling.
        /// </summary>
        public cvec2 ww => new cvec2(w, w);
        
        /// <summary>
        /// Returns cvec4.aa swizzling (equivalent to cvec4.ww).
        /// </summary>
        public cvec2 aa => new cvec2(w, w);
        
        /// <summary>
        /// Returns cvec4.wwx swizzling.
        /// </summary>
        public cvec3 wwx => new cvec3(w, w, x);
        
        /// <summary>
        /// Returns cvec4.aar swizzling (equivalent to cvec4.wwx).
        /// </summary>
        public cvec3 aar => new cvec3(w, w, x);
        
        /// <summary>
        /// Returns cvec4.wwxx swizzling.
        /// </summary>
        public cvec4 wwxx => new cvec4(w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.aarr swizzling (equivalent to cvec4.wwxx).
        /// </summary>
        public cvec4 aarr => new cvec4(w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.wwxxx swizzling.
        /// </summary>
        public cvec5 wwxxx => new cvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.aarrr swizzling (equivalent to cvec4.wwxxx).
        /// </summary>
        public cvec5 aarrr => new cvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.wwxxy swizzling.
        /// </summary>
        public cvec5 wwxxy => new cvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.aarrg swizzling (equivalent to cvec4.wwxxy).
        /// </summary>
        public cvec5 aarrg => new cvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.wwxxz swizzling.
        /// </summary>
        public cvec5 wwxxz => new cvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.aarrb swizzling (equivalent to cvec4.wwxxz).
        /// </summary>
        public cvec5 aarrb => new cvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.wwxxw swizzling.
        /// </summary>
        public cvec5 wwxxw => new cvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.aarra swizzling (equivalent to cvec4.wwxxw).
        /// </summary>
        public cvec5 aarra => new cvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.wwxy swizzling.
        /// </summary>
        public cvec4 wwxy => new cvec4(w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.aarg swizzling (equivalent to cvec4.wwxy).
        /// </summary>
        public cvec4 aarg => new cvec4(w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.wwxyx swizzling.
        /// </summary>
        public cvec5 wwxyx => new cvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.aargr swizzling (equivalent to cvec4.wwxyx).
        /// </summary>
        public cvec5 aargr => new cvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.wwxyy swizzling.
        /// </summary>
        public cvec5 wwxyy => new cvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.aargg swizzling (equivalent to cvec4.wwxyy).
        /// </summary>
        public cvec5 aargg => new cvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.wwxyz swizzling.
        /// </summary>
        public cvec5 wwxyz => new cvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.aargb swizzling (equivalent to cvec4.wwxyz).
        /// </summary>
        public cvec5 aargb => new cvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.wwxyw swizzling.
        /// </summary>
        public cvec5 wwxyw => new cvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.aarga swizzling (equivalent to cvec4.wwxyw).
        /// </summary>
        public cvec5 aarga => new cvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.wwxz swizzling.
        /// </summary>
        public cvec4 wwxz => new cvec4(w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.aarb swizzling (equivalent to cvec4.wwxz).
        /// </summary>
        public cvec4 aarb => new cvec4(w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.wwxzx swizzling.
        /// </summary>
        public cvec5 wwxzx => new cvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.aarbr swizzling (equivalent to cvec4.wwxzx).
        /// </summary>
        public cvec5 aarbr => new cvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.wwxzy swizzling.
        /// </summary>
        public cvec5 wwxzy => new cvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.aarbg swizzling (equivalent to cvec4.wwxzy).
        /// </summary>
        public cvec5 aarbg => new cvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.wwxzz swizzling.
        /// </summary>
        public cvec5 wwxzz => new cvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.aarbb swizzling (equivalent to cvec4.wwxzz).
        /// </summary>
        public cvec5 aarbb => new cvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.wwxzw swizzling.
        /// </summary>
        public cvec5 wwxzw => new cvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.aarba swizzling (equivalent to cvec4.wwxzw).
        /// </summary>
        public cvec5 aarba => new cvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.wwxw swizzling.
        /// </summary>
        public cvec4 wwxw => new cvec4(w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.aara swizzling (equivalent to cvec4.wwxw).
        /// </summary>
        public cvec4 aara => new cvec4(w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.wwxwx swizzling.
        /// </summary>
        public cvec5 wwxwx => new cvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.aarar swizzling (equivalent to cvec4.wwxwx).
        /// </summary>
        public cvec5 aarar => new cvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.wwxwy swizzling.
        /// </summary>
        public cvec5 wwxwy => new cvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.aarag swizzling (equivalent to cvec4.wwxwy).
        /// </summary>
        public cvec5 aarag => new cvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.wwxwz swizzling.
        /// </summary>
        public cvec5 wwxwz => new cvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.aarab swizzling (equivalent to cvec4.wwxwz).
        /// </summary>
        public cvec5 aarab => new cvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.wwxww swizzling.
        /// </summary>
        public cvec5 wwxww => new cvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.aaraa swizzling (equivalent to cvec4.wwxww).
        /// </summary>
        public cvec5 aaraa => new cvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.wwy swizzling.
        /// </summary>
        public cvec3 wwy => new cvec3(w, w, y);
        
        /// <summary>
        /// Returns cvec4.aag swizzling (equivalent to cvec4.wwy).
        /// </summary>
        public cvec3 aag => new cvec3(w, w, y);
        
        /// <summary>
        /// Returns cvec4.wwyx swizzling.
        /// </summary>
        public cvec4 wwyx => new cvec4(w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.aagr swizzling (equivalent to cvec4.wwyx).
        /// </summary>
        public cvec4 aagr => new cvec4(w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.wwyxx swizzling.
        /// </summary>
        public cvec5 wwyxx => new cvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.aagrr swizzling (equivalent to cvec4.wwyxx).
        /// </summary>
        public cvec5 aagrr => new cvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.wwyxy swizzling.
        /// </summary>
        public cvec5 wwyxy => new cvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.aagrg swizzling (equivalent to cvec4.wwyxy).
        /// </summary>
        public cvec5 aagrg => new cvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.wwyxz swizzling.
        /// </summary>
        public cvec5 wwyxz => new cvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.aagrb swizzling (equivalent to cvec4.wwyxz).
        /// </summary>
        public cvec5 aagrb => new cvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.wwyxw swizzling.
        /// </summary>
        public cvec5 wwyxw => new cvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.aagra swizzling (equivalent to cvec4.wwyxw).
        /// </summary>
        public cvec5 aagra => new cvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.wwyy swizzling.
        /// </summary>
        public cvec4 wwyy => new cvec4(w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.aagg swizzling (equivalent to cvec4.wwyy).
        /// </summary>
        public cvec4 aagg => new cvec4(w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.wwyyx swizzling.
        /// </summary>
        public cvec5 wwyyx => new cvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.aaggr swizzling (equivalent to cvec4.wwyyx).
        /// </summary>
        public cvec5 aaggr => new cvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.wwyyy swizzling.
        /// </summary>
        public cvec5 wwyyy => new cvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.aaggg swizzling (equivalent to cvec4.wwyyy).
        /// </summary>
        public cvec5 aaggg => new cvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.wwyyz swizzling.
        /// </summary>
        public cvec5 wwyyz => new cvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.aaggb swizzling (equivalent to cvec4.wwyyz).
        /// </summary>
        public cvec5 aaggb => new cvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.wwyyw swizzling.
        /// </summary>
        public cvec5 wwyyw => new cvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.aagga swizzling (equivalent to cvec4.wwyyw).
        /// </summary>
        public cvec5 aagga => new cvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.wwyz swizzling.
        /// </summary>
        public cvec4 wwyz => new cvec4(w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.aagb swizzling (equivalent to cvec4.wwyz).
        /// </summary>
        public cvec4 aagb => new cvec4(w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.wwyzx swizzling.
        /// </summary>
        public cvec5 wwyzx => new cvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.aagbr swizzling (equivalent to cvec4.wwyzx).
        /// </summary>
        public cvec5 aagbr => new cvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.wwyzy swizzling.
        /// </summary>
        public cvec5 wwyzy => new cvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.aagbg swizzling (equivalent to cvec4.wwyzy).
        /// </summary>
        public cvec5 aagbg => new cvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.wwyzz swizzling.
        /// </summary>
        public cvec5 wwyzz => new cvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.aagbb swizzling (equivalent to cvec4.wwyzz).
        /// </summary>
        public cvec5 aagbb => new cvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.wwyzw swizzling.
        /// </summary>
        public cvec5 wwyzw => new cvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.aagba swizzling (equivalent to cvec4.wwyzw).
        /// </summary>
        public cvec5 aagba => new cvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.wwyw swizzling.
        /// </summary>
        public cvec4 wwyw => new cvec4(w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.aaga swizzling (equivalent to cvec4.wwyw).
        /// </summary>
        public cvec4 aaga => new cvec4(w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.wwywx swizzling.
        /// </summary>
        public cvec5 wwywx => new cvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.aagar swizzling (equivalent to cvec4.wwywx).
        /// </summary>
        public cvec5 aagar => new cvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.wwywy swizzling.
        /// </summary>
        public cvec5 wwywy => new cvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.aagag swizzling (equivalent to cvec4.wwywy).
        /// </summary>
        public cvec5 aagag => new cvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.wwywz swizzling.
        /// </summary>
        public cvec5 wwywz => new cvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.aagab swizzling (equivalent to cvec4.wwywz).
        /// </summary>
        public cvec5 aagab => new cvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.wwyww swizzling.
        /// </summary>
        public cvec5 wwyww => new cvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.aagaa swizzling (equivalent to cvec4.wwyww).
        /// </summary>
        public cvec5 aagaa => new cvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.wwz swizzling.
        /// </summary>
        public cvec3 wwz => new cvec3(w, w, z);
        
        /// <summary>
        /// Returns cvec4.aab swizzling (equivalent to cvec4.wwz).
        /// </summary>
        public cvec3 aab => new cvec3(w, w, z);
        
        /// <summary>
        /// Returns cvec4.wwzx swizzling.
        /// </summary>
        public cvec4 wwzx => new cvec4(w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.aabr swizzling (equivalent to cvec4.wwzx).
        /// </summary>
        public cvec4 aabr => new cvec4(w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.wwzxx swizzling.
        /// </summary>
        public cvec5 wwzxx => new cvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.aabrr swizzling (equivalent to cvec4.wwzxx).
        /// </summary>
        public cvec5 aabrr => new cvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.wwzxy swizzling.
        /// </summary>
        public cvec5 wwzxy => new cvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.aabrg swizzling (equivalent to cvec4.wwzxy).
        /// </summary>
        public cvec5 aabrg => new cvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.wwzxz swizzling.
        /// </summary>
        public cvec5 wwzxz => new cvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.aabrb swizzling (equivalent to cvec4.wwzxz).
        /// </summary>
        public cvec5 aabrb => new cvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.wwzxw swizzling.
        /// </summary>
        public cvec5 wwzxw => new cvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.aabra swizzling (equivalent to cvec4.wwzxw).
        /// </summary>
        public cvec5 aabra => new cvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.wwzy swizzling.
        /// </summary>
        public cvec4 wwzy => new cvec4(w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.aabg swizzling (equivalent to cvec4.wwzy).
        /// </summary>
        public cvec4 aabg => new cvec4(w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.wwzyx swizzling.
        /// </summary>
        public cvec5 wwzyx => new cvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.aabgr swizzling (equivalent to cvec4.wwzyx).
        /// </summary>
        public cvec5 aabgr => new cvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.wwzyy swizzling.
        /// </summary>
        public cvec5 wwzyy => new cvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.aabgg swizzling (equivalent to cvec4.wwzyy).
        /// </summary>
        public cvec5 aabgg => new cvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.wwzyz swizzling.
        /// </summary>
        public cvec5 wwzyz => new cvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.aabgb swizzling (equivalent to cvec4.wwzyz).
        /// </summary>
        public cvec5 aabgb => new cvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.wwzyw swizzling.
        /// </summary>
        public cvec5 wwzyw => new cvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.aabga swizzling (equivalent to cvec4.wwzyw).
        /// </summary>
        public cvec5 aabga => new cvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.wwzz swizzling.
        /// </summary>
        public cvec4 wwzz => new cvec4(w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.aabb swizzling (equivalent to cvec4.wwzz).
        /// </summary>
        public cvec4 aabb => new cvec4(w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.wwzzx swizzling.
        /// </summary>
        public cvec5 wwzzx => new cvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.aabbr swizzling (equivalent to cvec4.wwzzx).
        /// </summary>
        public cvec5 aabbr => new cvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.wwzzy swizzling.
        /// </summary>
        public cvec5 wwzzy => new cvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.aabbg swizzling (equivalent to cvec4.wwzzy).
        /// </summary>
        public cvec5 aabbg => new cvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.wwzzz swizzling.
        /// </summary>
        public cvec5 wwzzz => new cvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.aabbb swizzling (equivalent to cvec4.wwzzz).
        /// </summary>
        public cvec5 aabbb => new cvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.wwzzw swizzling.
        /// </summary>
        public cvec5 wwzzw => new cvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.aabba swizzling (equivalent to cvec4.wwzzw).
        /// </summary>
        public cvec5 aabba => new cvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.wwzw swizzling.
        /// </summary>
        public cvec4 wwzw => new cvec4(w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.aaba swizzling (equivalent to cvec4.wwzw).
        /// </summary>
        public cvec4 aaba => new cvec4(w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.wwzwx swizzling.
        /// </summary>
        public cvec5 wwzwx => new cvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.aabar swizzling (equivalent to cvec4.wwzwx).
        /// </summary>
        public cvec5 aabar => new cvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.wwzwy swizzling.
        /// </summary>
        public cvec5 wwzwy => new cvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.aabag swizzling (equivalent to cvec4.wwzwy).
        /// </summary>
        public cvec5 aabag => new cvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.wwzwz swizzling.
        /// </summary>
        public cvec5 wwzwz => new cvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.aabab swizzling (equivalent to cvec4.wwzwz).
        /// </summary>
        public cvec5 aabab => new cvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.wwzww swizzling.
        /// </summary>
        public cvec5 wwzww => new cvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.aabaa swizzling (equivalent to cvec4.wwzww).
        /// </summary>
        public cvec5 aabaa => new cvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.www swizzling.
        /// </summary>
        public cvec3 www => new cvec3(w, w, w);
        
        /// <summary>
        /// Returns cvec4.aaa swizzling (equivalent to cvec4.www).
        /// </summary>
        public cvec3 aaa => new cvec3(w, w, w);
        
        /// <summary>
        /// Returns cvec4.wwwx swizzling.
        /// </summary>
        public cvec4 wwwx => new cvec4(w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.aaar swizzling (equivalent to cvec4.wwwx).
        /// </summary>
        public cvec4 aaar => new cvec4(w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.wwwxx swizzling.
        /// </summary>
        public cvec5 wwwxx => new cvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.aaarr swizzling (equivalent to cvec4.wwwxx).
        /// </summary>
        public cvec5 aaarr => new cvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.wwwxy swizzling.
        /// </summary>
        public cvec5 wwwxy => new cvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.aaarg swizzling (equivalent to cvec4.wwwxy).
        /// </summary>
        public cvec5 aaarg => new cvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.wwwxz swizzling.
        /// </summary>
        public cvec5 wwwxz => new cvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.aaarb swizzling (equivalent to cvec4.wwwxz).
        /// </summary>
        public cvec5 aaarb => new cvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.wwwxw swizzling.
        /// </summary>
        public cvec5 wwwxw => new cvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.aaara swizzling (equivalent to cvec4.wwwxw).
        /// </summary>
        public cvec5 aaara => new cvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.wwwy swizzling.
        /// </summary>
        public cvec4 wwwy => new cvec4(w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.aaag swizzling (equivalent to cvec4.wwwy).
        /// </summary>
        public cvec4 aaag => new cvec4(w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.wwwyx swizzling.
        /// </summary>
        public cvec5 wwwyx => new cvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.aaagr swizzling (equivalent to cvec4.wwwyx).
        /// </summary>
        public cvec5 aaagr => new cvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.wwwyy swizzling.
        /// </summary>
        public cvec5 wwwyy => new cvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.aaagg swizzling (equivalent to cvec4.wwwyy).
        /// </summary>
        public cvec5 aaagg => new cvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.wwwyz swizzling.
        /// </summary>
        public cvec5 wwwyz => new cvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.aaagb swizzling (equivalent to cvec4.wwwyz).
        /// </summary>
        public cvec5 aaagb => new cvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.wwwyw swizzling.
        /// </summary>
        public cvec5 wwwyw => new cvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.aaaga swizzling (equivalent to cvec4.wwwyw).
        /// </summary>
        public cvec5 aaaga => new cvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.wwwz swizzling.
        /// </summary>
        public cvec4 wwwz => new cvec4(w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.aaab swizzling (equivalent to cvec4.wwwz).
        /// </summary>
        public cvec4 aaab => new cvec4(w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.wwwzx swizzling.
        /// </summary>
        public cvec5 wwwzx => new cvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.aaabr swizzling (equivalent to cvec4.wwwzx).
        /// </summary>
        public cvec5 aaabr => new cvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.wwwzy swizzling.
        /// </summary>
        public cvec5 wwwzy => new cvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.aaabg swizzling (equivalent to cvec4.wwwzy).
        /// </summary>
        public cvec5 aaabg => new cvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.wwwzz swizzling.
        /// </summary>
        public cvec5 wwwzz => new cvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.aaabb swizzling (equivalent to cvec4.wwwzz).
        /// </summary>
        public cvec5 aaabb => new cvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.wwwzw swizzling.
        /// </summary>
        public cvec5 wwwzw => new cvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.aaaba swizzling (equivalent to cvec4.wwwzw).
        /// </summary>
        public cvec5 aaaba => new cvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.wwww swizzling.
        /// </summary>
        public cvec4 wwww => new cvec4(w, w, w, w);
        
        /// <summary>
        /// Returns cvec4.aaaa swizzling (equivalent to cvec4.wwww).
        /// </summary>
        public cvec4 aaaa => new cvec4(w, w, w, w);
        
        /// <summary>
        /// Returns cvec4.wwwwx swizzling.
        /// </summary>
        public cvec5 wwwwx => new cvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.aaaar swizzling (equivalent to cvec4.wwwwx).
        /// </summary>
        public cvec5 aaaar => new cvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.wwwwy swizzling.
        /// </summary>
        public cvec5 wwwwy => new cvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.aaaag swizzling (equivalent to cvec4.wwwwy).
        /// </summary>
        public cvec5 aaaag => new cvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.wwwwz swizzling.
        /// </summary>
        public cvec5 wwwwz => new cvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.aaaab swizzling (equivalent to cvec4.wwwwz).
        /// </summary>
        public cvec5 aaaab => new cvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.wwwww swizzling.
        /// </summary>
        public cvec5 wwwww => new cvec5(w, w, w, w, w);
        
        /// <summary>
        /// Returns cvec4.aaaaa swizzling (equivalent to cvec4.wwwww).
        /// </summary>
        public cvec5 aaaaa => new cvec5(w, w, w, w, w);

        #endregion

    }
}
