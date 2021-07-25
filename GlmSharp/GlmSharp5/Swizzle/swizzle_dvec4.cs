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
    /// Temporary vector of type double with 4 components, used for implementing swizzling for dvec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_dvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly double y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly double z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly double w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_dvec4.
        /// </summary>
        internal swizzle_dvec4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns dvec4.xx swizzling.
        /// </summary>
        public dvec2 xx => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec4.rr swizzling (equivalent to dvec4.xx).
        /// </summary>
        public dvec2 rr => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec4.xxx swizzling.
        /// </summary>
        public dvec3 xxx => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec4.rrr swizzling (equivalent to dvec4.xxx).
        /// </summary>
        public dvec3 rrr => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec4.xxxx swizzling.
        /// </summary>
        public dvec4 xxxx => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.rrrr swizzling (equivalent to dvec4.xxxx).
        /// </summary>
        public dvec4 rrrr => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.xxxxx swizzling.
        /// </summary>
        public dvec5 xxxxx => new dvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.rrrrr swizzling (equivalent to dvec4.xxxxx).
        /// </summary>
        public dvec5 rrrrr => new dvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.xxxxy swizzling.
        /// </summary>
        public dvec5 xxxxy => new dvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.rrrrg swizzling (equivalent to dvec4.xxxxy).
        /// </summary>
        public dvec5 rrrrg => new dvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.xxxxz swizzling.
        /// </summary>
        public dvec5 xxxxz => new dvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.rrrrb swizzling (equivalent to dvec4.xxxxz).
        /// </summary>
        public dvec5 rrrrb => new dvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.xxxxw swizzling.
        /// </summary>
        public dvec5 xxxxw => new dvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.rrrra swizzling (equivalent to dvec4.xxxxw).
        /// </summary>
        public dvec5 rrrra => new dvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.xxxy swizzling.
        /// </summary>
        public dvec4 xxxy => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.rrrg swizzling (equivalent to dvec4.xxxy).
        /// </summary>
        public dvec4 rrrg => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.xxxyx swizzling.
        /// </summary>
        public dvec5 xxxyx => new dvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.rrrgr swizzling (equivalent to dvec4.xxxyx).
        /// </summary>
        public dvec5 rrrgr => new dvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.xxxyy swizzling.
        /// </summary>
        public dvec5 xxxyy => new dvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.rrrgg swizzling (equivalent to dvec4.xxxyy).
        /// </summary>
        public dvec5 rrrgg => new dvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.xxxyz swizzling.
        /// </summary>
        public dvec5 xxxyz => new dvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.rrrgb swizzling (equivalent to dvec4.xxxyz).
        /// </summary>
        public dvec5 rrrgb => new dvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.xxxyw swizzling.
        /// </summary>
        public dvec5 xxxyw => new dvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.rrrga swizzling (equivalent to dvec4.xxxyw).
        /// </summary>
        public dvec5 rrrga => new dvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.xxxz swizzling.
        /// </summary>
        public dvec4 xxxz => new dvec4(x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.rrrb swizzling (equivalent to dvec4.xxxz).
        /// </summary>
        public dvec4 rrrb => new dvec4(x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.xxxzx swizzling.
        /// </summary>
        public dvec5 xxxzx => new dvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.rrrbr swizzling (equivalent to dvec4.xxxzx).
        /// </summary>
        public dvec5 rrrbr => new dvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.xxxzy swizzling.
        /// </summary>
        public dvec5 xxxzy => new dvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.rrrbg swizzling (equivalent to dvec4.xxxzy).
        /// </summary>
        public dvec5 rrrbg => new dvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.xxxzz swizzling.
        /// </summary>
        public dvec5 xxxzz => new dvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.rrrbb swizzling (equivalent to dvec4.xxxzz).
        /// </summary>
        public dvec5 rrrbb => new dvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.xxxzw swizzling.
        /// </summary>
        public dvec5 xxxzw => new dvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.rrrba swizzling (equivalent to dvec4.xxxzw).
        /// </summary>
        public dvec5 rrrba => new dvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.xxxw swizzling.
        /// </summary>
        public dvec4 xxxw => new dvec4(x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.rrra swizzling (equivalent to dvec4.xxxw).
        /// </summary>
        public dvec4 rrra => new dvec4(x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.xxxwx swizzling.
        /// </summary>
        public dvec5 xxxwx => new dvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.rrrar swizzling (equivalent to dvec4.xxxwx).
        /// </summary>
        public dvec5 rrrar => new dvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.xxxwy swizzling.
        /// </summary>
        public dvec5 xxxwy => new dvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.rrrag swizzling (equivalent to dvec4.xxxwy).
        /// </summary>
        public dvec5 rrrag => new dvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.xxxwz swizzling.
        /// </summary>
        public dvec5 xxxwz => new dvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.rrrab swizzling (equivalent to dvec4.xxxwz).
        /// </summary>
        public dvec5 rrrab => new dvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.xxxww swizzling.
        /// </summary>
        public dvec5 xxxww => new dvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.rrraa swizzling (equivalent to dvec4.xxxww).
        /// </summary>
        public dvec5 rrraa => new dvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.xxy swizzling.
        /// </summary>
        public dvec3 xxy => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec4.rrg swizzling (equivalent to dvec4.xxy).
        /// </summary>
        public dvec3 rrg => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec4.xxyx swizzling.
        /// </summary>
        public dvec4 xxyx => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.rrgr swizzling (equivalent to dvec4.xxyx).
        /// </summary>
        public dvec4 rrgr => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.xxyxx swizzling.
        /// </summary>
        public dvec5 xxyxx => new dvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.rrgrr swizzling (equivalent to dvec4.xxyxx).
        /// </summary>
        public dvec5 rrgrr => new dvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.xxyxy swizzling.
        /// </summary>
        public dvec5 xxyxy => new dvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.rrgrg swizzling (equivalent to dvec4.xxyxy).
        /// </summary>
        public dvec5 rrgrg => new dvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.xxyxz swizzling.
        /// </summary>
        public dvec5 xxyxz => new dvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.rrgrb swizzling (equivalent to dvec4.xxyxz).
        /// </summary>
        public dvec5 rrgrb => new dvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.xxyxw swizzling.
        /// </summary>
        public dvec5 xxyxw => new dvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.rrgra swizzling (equivalent to dvec4.xxyxw).
        /// </summary>
        public dvec5 rrgra => new dvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.xxyy swizzling.
        /// </summary>
        public dvec4 xxyy => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.rrgg swizzling (equivalent to dvec4.xxyy).
        /// </summary>
        public dvec4 rrgg => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.xxyyx swizzling.
        /// </summary>
        public dvec5 xxyyx => new dvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.rrggr swizzling (equivalent to dvec4.xxyyx).
        /// </summary>
        public dvec5 rrggr => new dvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.xxyyy swizzling.
        /// </summary>
        public dvec5 xxyyy => new dvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.rrggg swizzling (equivalent to dvec4.xxyyy).
        /// </summary>
        public dvec5 rrggg => new dvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.xxyyz swizzling.
        /// </summary>
        public dvec5 xxyyz => new dvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.rrggb swizzling (equivalent to dvec4.xxyyz).
        /// </summary>
        public dvec5 rrggb => new dvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.xxyyw swizzling.
        /// </summary>
        public dvec5 xxyyw => new dvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.rrgga swizzling (equivalent to dvec4.xxyyw).
        /// </summary>
        public dvec5 rrgga => new dvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.xxyz swizzling.
        /// </summary>
        public dvec4 xxyz => new dvec4(x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.rrgb swizzling (equivalent to dvec4.xxyz).
        /// </summary>
        public dvec4 rrgb => new dvec4(x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.xxyzx swizzling.
        /// </summary>
        public dvec5 xxyzx => new dvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.rrgbr swizzling (equivalent to dvec4.xxyzx).
        /// </summary>
        public dvec5 rrgbr => new dvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.xxyzy swizzling.
        /// </summary>
        public dvec5 xxyzy => new dvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.rrgbg swizzling (equivalent to dvec4.xxyzy).
        /// </summary>
        public dvec5 rrgbg => new dvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.xxyzz swizzling.
        /// </summary>
        public dvec5 xxyzz => new dvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.rrgbb swizzling (equivalent to dvec4.xxyzz).
        /// </summary>
        public dvec5 rrgbb => new dvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.xxyzw swizzling.
        /// </summary>
        public dvec5 xxyzw => new dvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.rrgba swizzling (equivalent to dvec4.xxyzw).
        /// </summary>
        public dvec5 rrgba => new dvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.xxyw swizzling.
        /// </summary>
        public dvec4 xxyw => new dvec4(x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.rrga swizzling (equivalent to dvec4.xxyw).
        /// </summary>
        public dvec4 rrga => new dvec4(x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.xxywx swizzling.
        /// </summary>
        public dvec5 xxywx => new dvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.rrgar swizzling (equivalent to dvec4.xxywx).
        /// </summary>
        public dvec5 rrgar => new dvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.xxywy swizzling.
        /// </summary>
        public dvec5 xxywy => new dvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.rrgag swizzling (equivalent to dvec4.xxywy).
        /// </summary>
        public dvec5 rrgag => new dvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.xxywz swizzling.
        /// </summary>
        public dvec5 xxywz => new dvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.rrgab swizzling (equivalent to dvec4.xxywz).
        /// </summary>
        public dvec5 rrgab => new dvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.xxyww swizzling.
        /// </summary>
        public dvec5 xxyww => new dvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.rrgaa swizzling (equivalent to dvec4.xxyww).
        /// </summary>
        public dvec5 rrgaa => new dvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.xxz swizzling.
        /// </summary>
        public dvec3 xxz => new dvec3(x, x, z);
        
        /// <summary>
        /// Returns dvec4.rrb swizzling (equivalent to dvec4.xxz).
        /// </summary>
        public dvec3 rrb => new dvec3(x, x, z);
        
        /// <summary>
        /// Returns dvec4.xxzx swizzling.
        /// </summary>
        public dvec4 xxzx => new dvec4(x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.rrbr swizzling (equivalent to dvec4.xxzx).
        /// </summary>
        public dvec4 rrbr => new dvec4(x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.xxzxx swizzling.
        /// </summary>
        public dvec5 xxzxx => new dvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.rrbrr swizzling (equivalent to dvec4.xxzxx).
        /// </summary>
        public dvec5 rrbrr => new dvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.xxzxy swizzling.
        /// </summary>
        public dvec5 xxzxy => new dvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.rrbrg swizzling (equivalent to dvec4.xxzxy).
        /// </summary>
        public dvec5 rrbrg => new dvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.xxzxz swizzling.
        /// </summary>
        public dvec5 xxzxz => new dvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.rrbrb swizzling (equivalent to dvec4.xxzxz).
        /// </summary>
        public dvec5 rrbrb => new dvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.xxzxw swizzling.
        /// </summary>
        public dvec5 xxzxw => new dvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.rrbra swizzling (equivalent to dvec4.xxzxw).
        /// </summary>
        public dvec5 rrbra => new dvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.xxzy swizzling.
        /// </summary>
        public dvec4 xxzy => new dvec4(x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.rrbg swizzling (equivalent to dvec4.xxzy).
        /// </summary>
        public dvec4 rrbg => new dvec4(x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.xxzyx swizzling.
        /// </summary>
        public dvec5 xxzyx => new dvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.rrbgr swizzling (equivalent to dvec4.xxzyx).
        /// </summary>
        public dvec5 rrbgr => new dvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.xxzyy swizzling.
        /// </summary>
        public dvec5 xxzyy => new dvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.rrbgg swizzling (equivalent to dvec4.xxzyy).
        /// </summary>
        public dvec5 rrbgg => new dvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.xxzyz swizzling.
        /// </summary>
        public dvec5 xxzyz => new dvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.rrbgb swizzling (equivalent to dvec4.xxzyz).
        /// </summary>
        public dvec5 rrbgb => new dvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.xxzyw swizzling.
        /// </summary>
        public dvec5 xxzyw => new dvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.rrbga swizzling (equivalent to dvec4.xxzyw).
        /// </summary>
        public dvec5 rrbga => new dvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.xxzz swizzling.
        /// </summary>
        public dvec4 xxzz => new dvec4(x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.rrbb swizzling (equivalent to dvec4.xxzz).
        /// </summary>
        public dvec4 rrbb => new dvec4(x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.xxzzx swizzling.
        /// </summary>
        public dvec5 xxzzx => new dvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.rrbbr swizzling (equivalent to dvec4.xxzzx).
        /// </summary>
        public dvec5 rrbbr => new dvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.xxzzy swizzling.
        /// </summary>
        public dvec5 xxzzy => new dvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.rrbbg swizzling (equivalent to dvec4.xxzzy).
        /// </summary>
        public dvec5 rrbbg => new dvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.xxzzz swizzling.
        /// </summary>
        public dvec5 xxzzz => new dvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.rrbbb swizzling (equivalent to dvec4.xxzzz).
        /// </summary>
        public dvec5 rrbbb => new dvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.xxzzw swizzling.
        /// </summary>
        public dvec5 xxzzw => new dvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.rrbba swizzling (equivalent to dvec4.xxzzw).
        /// </summary>
        public dvec5 rrbba => new dvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.xxzw swizzling.
        /// </summary>
        public dvec4 xxzw => new dvec4(x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.rrba swizzling (equivalent to dvec4.xxzw).
        /// </summary>
        public dvec4 rrba => new dvec4(x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.xxzwx swizzling.
        /// </summary>
        public dvec5 xxzwx => new dvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.rrbar swizzling (equivalent to dvec4.xxzwx).
        /// </summary>
        public dvec5 rrbar => new dvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.xxzwy swizzling.
        /// </summary>
        public dvec5 xxzwy => new dvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.rrbag swizzling (equivalent to dvec4.xxzwy).
        /// </summary>
        public dvec5 rrbag => new dvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.xxzwz swizzling.
        /// </summary>
        public dvec5 xxzwz => new dvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.rrbab swizzling (equivalent to dvec4.xxzwz).
        /// </summary>
        public dvec5 rrbab => new dvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.xxzww swizzling.
        /// </summary>
        public dvec5 xxzww => new dvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.rrbaa swizzling (equivalent to dvec4.xxzww).
        /// </summary>
        public dvec5 rrbaa => new dvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.xxw swizzling.
        /// </summary>
        public dvec3 xxw => new dvec3(x, x, w);
        
        /// <summary>
        /// Returns dvec4.rra swizzling (equivalent to dvec4.xxw).
        /// </summary>
        public dvec3 rra => new dvec3(x, x, w);
        
        /// <summary>
        /// Returns dvec4.xxwx swizzling.
        /// </summary>
        public dvec4 xxwx => new dvec4(x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.rrar swizzling (equivalent to dvec4.xxwx).
        /// </summary>
        public dvec4 rrar => new dvec4(x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.xxwxx swizzling.
        /// </summary>
        public dvec5 xxwxx => new dvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.rrarr swizzling (equivalent to dvec4.xxwxx).
        /// </summary>
        public dvec5 rrarr => new dvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.xxwxy swizzling.
        /// </summary>
        public dvec5 xxwxy => new dvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.rrarg swizzling (equivalent to dvec4.xxwxy).
        /// </summary>
        public dvec5 rrarg => new dvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.xxwxz swizzling.
        /// </summary>
        public dvec5 xxwxz => new dvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.rrarb swizzling (equivalent to dvec4.xxwxz).
        /// </summary>
        public dvec5 rrarb => new dvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.xxwxw swizzling.
        /// </summary>
        public dvec5 xxwxw => new dvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.rrara swizzling (equivalent to dvec4.xxwxw).
        /// </summary>
        public dvec5 rrara => new dvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.xxwy swizzling.
        /// </summary>
        public dvec4 xxwy => new dvec4(x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.rrag swizzling (equivalent to dvec4.xxwy).
        /// </summary>
        public dvec4 rrag => new dvec4(x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.xxwyx swizzling.
        /// </summary>
        public dvec5 xxwyx => new dvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.rragr swizzling (equivalent to dvec4.xxwyx).
        /// </summary>
        public dvec5 rragr => new dvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.xxwyy swizzling.
        /// </summary>
        public dvec5 xxwyy => new dvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.rragg swizzling (equivalent to dvec4.xxwyy).
        /// </summary>
        public dvec5 rragg => new dvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.xxwyz swizzling.
        /// </summary>
        public dvec5 xxwyz => new dvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.rragb swizzling (equivalent to dvec4.xxwyz).
        /// </summary>
        public dvec5 rragb => new dvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.xxwyw swizzling.
        /// </summary>
        public dvec5 xxwyw => new dvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.rraga swizzling (equivalent to dvec4.xxwyw).
        /// </summary>
        public dvec5 rraga => new dvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.xxwz swizzling.
        /// </summary>
        public dvec4 xxwz => new dvec4(x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.rrab swizzling (equivalent to dvec4.xxwz).
        /// </summary>
        public dvec4 rrab => new dvec4(x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.xxwzx swizzling.
        /// </summary>
        public dvec5 xxwzx => new dvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.rrabr swizzling (equivalent to dvec4.xxwzx).
        /// </summary>
        public dvec5 rrabr => new dvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.xxwzy swizzling.
        /// </summary>
        public dvec5 xxwzy => new dvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.rrabg swizzling (equivalent to dvec4.xxwzy).
        /// </summary>
        public dvec5 rrabg => new dvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.xxwzz swizzling.
        /// </summary>
        public dvec5 xxwzz => new dvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.rrabb swizzling (equivalent to dvec4.xxwzz).
        /// </summary>
        public dvec5 rrabb => new dvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.xxwzw swizzling.
        /// </summary>
        public dvec5 xxwzw => new dvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.rraba swizzling (equivalent to dvec4.xxwzw).
        /// </summary>
        public dvec5 rraba => new dvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.xxww swizzling.
        /// </summary>
        public dvec4 xxww => new dvec4(x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.rraa swizzling (equivalent to dvec4.xxww).
        /// </summary>
        public dvec4 rraa => new dvec4(x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.xxwwx swizzling.
        /// </summary>
        public dvec5 xxwwx => new dvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.rraar swizzling (equivalent to dvec4.xxwwx).
        /// </summary>
        public dvec5 rraar => new dvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.xxwwy swizzling.
        /// </summary>
        public dvec5 xxwwy => new dvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.rraag swizzling (equivalent to dvec4.xxwwy).
        /// </summary>
        public dvec5 rraag => new dvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.xxwwz swizzling.
        /// </summary>
        public dvec5 xxwwz => new dvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.rraab swizzling (equivalent to dvec4.xxwwz).
        /// </summary>
        public dvec5 rraab => new dvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.xxwww swizzling.
        /// </summary>
        public dvec5 xxwww => new dvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.rraaa swizzling (equivalent to dvec4.xxwww).
        /// </summary>
        public dvec5 rraaa => new dvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.xy swizzling.
        /// </summary>
        public dvec2 xy => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec4.rg swizzling (equivalent to dvec4.xy).
        /// </summary>
        public dvec2 rg => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec4.xyx swizzling.
        /// </summary>
        public dvec3 xyx => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec4.rgr swizzling (equivalent to dvec4.xyx).
        /// </summary>
        public dvec3 rgr => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec4.xyxx swizzling.
        /// </summary>
        public dvec4 xyxx => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.rgrr swizzling (equivalent to dvec4.xyxx).
        /// </summary>
        public dvec4 rgrr => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.xyxxx swizzling.
        /// </summary>
        public dvec5 xyxxx => new dvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.rgrrr swizzling (equivalent to dvec4.xyxxx).
        /// </summary>
        public dvec5 rgrrr => new dvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.xyxxy swizzling.
        /// </summary>
        public dvec5 xyxxy => new dvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.rgrrg swizzling (equivalent to dvec4.xyxxy).
        /// </summary>
        public dvec5 rgrrg => new dvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.xyxxz swizzling.
        /// </summary>
        public dvec5 xyxxz => new dvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.rgrrb swizzling (equivalent to dvec4.xyxxz).
        /// </summary>
        public dvec5 rgrrb => new dvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.xyxxw swizzling.
        /// </summary>
        public dvec5 xyxxw => new dvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.rgrra swizzling (equivalent to dvec4.xyxxw).
        /// </summary>
        public dvec5 rgrra => new dvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.xyxy swizzling.
        /// </summary>
        public dvec4 xyxy => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.rgrg swizzling (equivalent to dvec4.xyxy).
        /// </summary>
        public dvec4 rgrg => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.xyxyx swizzling.
        /// </summary>
        public dvec5 xyxyx => new dvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.rgrgr swizzling (equivalent to dvec4.xyxyx).
        /// </summary>
        public dvec5 rgrgr => new dvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.xyxyy swizzling.
        /// </summary>
        public dvec5 xyxyy => new dvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.rgrgg swizzling (equivalent to dvec4.xyxyy).
        /// </summary>
        public dvec5 rgrgg => new dvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.xyxyz swizzling.
        /// </summary>
        public dvec5 xyxyz => new dvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.rgrgb swizzling (equivalent to dvec4.xyxyz).
        /// </summary>
        public dvec5 rgrgb => new dvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.xyxyw swizzling.
        /// </summary>
        public dvec5 xyxyw => new dvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.rgrga swizzling (equivalent to dvec4.xyxyw).
        /// </summary>
        public dvec5 rgrga => new dvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.xyxz swizzling.
        /// </summary>
        public dvec4 xyxz => new dvec4(x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.rgrb swizzling (equivalent to dvec4.xyxz).
        /// </summary>
        public dvec4 rgrb => new dvec4(x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.xyxzx swizzling.
        /// </summary>
        public dvec5 xyxzx => new dvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.rgrbr swizzling (equivalent to dvec4.xyxzx).
        /// </summary>
        public dvec5 rgrbr => new dvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.xyxzy swizzling.
        /// </summary>
        public dvec5 xyxzy => new dvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.rgrbg swizzling (equivalent to dvec4.xyxzy).
        /// </summary>
        public dvec5 rgrbg => new dvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.xyxzz swizzling.
        /// </summary>
        public dvec5 xyxzz => new dvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.rgrbb swizzling (equivalent to dvec4.xyxzz).
        /// </summary>
        public dvec5 rgrbb => new dvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.xyxzw swizzling.
        /// </summary>
        public dvec5 xyxzw => new dvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.rgrba swizzling (equivalent to dvec4.xyxzw).
        /// </summary>
        public dvec5 rgrba => new dvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.xyxw swizzling.
        /// </summary>
        public dvec4 xyxw => new dvec4(x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.rgra swizzling (equivalent to dvec4.xyxw).
        /// </summary>
        public dvec4 rgra => new dvec4(x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.xyxwx swizzling.
        /// </summary>
        public dvec5 xyxwx => new dvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.rgrar swizzling (equivalent to dvec4.xyxwx).
        /// </summary>
        public dvec5 rgrar => new dvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.xyxwy swizzling.
        /// </summary>
        public dvec5 xyxwy => new dvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.rgrag swizzling (equivalent to dvec4.xyxwy).
        /// </summary>
        public dvec5 rgrag => new dvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.xyxwz swizzling.
        /// </summary>
        public dvec5 xyxwz => new dvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.rgrab swizzling (equivalent to dvec4.xyxwz).
        /// </summary>
        public dvec5 rgrab => new dvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.xyxww swizzling.
        /// </summary>
        public dvec5 xyxww => new dvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.rgraa swizzling (equivalent to dvec4.xyxww).
        /// </summary>
        public dvec5 rgraa => new dvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.xyy swizzling.
        /// </summary>
        public dvec3 xyy => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec4.rgg swizzling (equivalent to dvec4.xyy).
        /// </summary>
        public dvec3 rgg => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec4.xyyx swizzling.
        /// </summary>
        public dvec4 xyyx => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.rggr swizzling (equivalent to dvec4.xyyx).
        /// </summary>
        public dvec4 rggr => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.xyyxx swizzling.
        /// </summary>
        public dvec5 xyyxx => new dvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.rggrr swizzling (equivalent to dvec4.xyyxx).
        /// </summary>
        public dvec5 rggrr => new dvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.xyyxy swizzling.
        /// </summary>
        public dvec5 xyyxy => new dvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.rggrg swizzling (equivalent to dvec4.xyyxy).
        /// </summary>
        public dvec5 rggrg => new dvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.xyyxz swizzling.
        /// </summary>
        public dvec5 xyyxz => new dvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.rggrb swizzling (equivalent to dvec4.xyyxz).
        /// </summary>
        public dvec5 rggrb => new dvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.xyyxw swizzling.
        /// </summary>
        public dvec5 xyyxw => new dvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.rggra swizzling (equivalent to dvec4.xyyxw).
        /// </summary>
        public dvec5 rggra => new dvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.xyyy swizzling.
        /// </summary>
        public dvec4 xyyy => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.rggg swizzling (equivalent to dvec4.xyyy).
        /// </summary>
        public dvec4 rggg => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.xyyyx swizzling.
        /// </summary>
        public dvec5 xyyyx => new dvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.rgggr swizzling (equivalent to dvec4.xyyyx).
        /// </summary>
        public dvec5 rgggr => new dvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.xyyyy swizzling.
        /// </summary>
        public dvec5 xyyyy => new dvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.rgggg swizzling (equivalent to dvec4.xyyyy).
        /// </summary>
        public dvec5 rgggg => new dvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.xyyyz swizzling.
        /// </summary>
        public dvec5 xyyyz => new dvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.rgggb swizzling (equivalent to dvec4.xyyyz).
        /// </summary>
        public dvec5 rgggb => new dvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.xyyyw swizzling.
        /// </summary>
        public dvec5 xyyyw => new dvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.rggga swizzling (equivalent to dvec4.xyyyw).
        /// </summary>
        public dvec5 rggga => new dvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.xyyz swizzling.
        /// </summary>
        public dvec4 xyyz => new dvec4(x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.rggb swizzling (equivalent to dvec4.xyyz).
        /// </summary>
        public dvec4 rggb => new dvec4(x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.xyyzx swizzling.
        /// </summary>
        public dvec5 xyyzx => new dvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.rggbr swizzling (equivalent to dvec4.xyyzx).
        /// </summary>
        public dvec5 rggbr => new dvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.xyyzy swizzling.
        /// </summary>
        public dvec5 xyyzy => new dvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.rggbg swizzling (equivalent to dvec4.xyyzy).
        /// </summary>
        public dvec5 rggbg => new dvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.xyyzz swizzling.
        /// </summary>
        public dvec5 xyyzz => new dvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.rggbb swizzling (equivalent to dvec4.xyyzz).
        /// </summary>
        public dvec5 rggbb => new dvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.xyyzw swizzling.
        /// </summary>
        public dvec5 xyyzw => new dvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.rggba swizzling (equivalent to dvec4.xyyzw).
        /// </summary>
        public dvec5 rggba => new dvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.xyyw swizzling.
        /// </summary>
        public dvec4 xyyw => new dvec4(x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.rgga swizzling (equivalent to dvec4.xyyw).
        /// </summary>
        public dvec4 rgga => new dvec4(x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.xyywx swizzling.
        /// </summary>
        public dvec5 xyywx => new dvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.rggar swizzling (equivalent to dvec4.xyywx).
        /// </summary>
        public dvec5 rggar => new dvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.xyywy swizzling.
        /// </summary>
        public dvec5 xyywy => new dvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.rggag swizzling (equivalent to dvec4.xyywy).
        /// </summary>
        public dvec5 rggag => new dvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.xyywz swizzling.
        /// </summary>
        public dvec5 xyywz => new dvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.rggab swizzling (equivalent to dvec4.xyywz).
        /// </summary>
        public dvec5 rggab => new dvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.xyyww swizzling.
        /// </summary>
        public dvec5 xyyww => new dvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.rggaa swizzling (equivalent to dvec4.xyyww).
        /// </summary>
        public dvec5 rggaa => new dvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.xyz swizzling.
        /// </summary>
        public dvec3 xyz => new dvec3(x, y, z);
        
        /// <summary>
        /// Returns dvec4.rgb swizzling (equivalent to dvec4.xyz).
        /// </summary>
        public dvec3 rgb => new dvec3(x, y, z);
        
        /// <summary>
        /// Returns dvec4.xyzx swizzling.
        /// </summary>
        public dvec4 xyzx => new dvec4(x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.rgbr swizzling (equivalent to dvec4.xyzx).
        /// </summary>
        public dvec4 rgbr => new dvec4(x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.xyzxx swizzling.
        /// </summary>
        public dvec5 xyzxx => new dvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.rgbrr swizzling (equivalent to dvec4.xyzxx).
        /// </summary>
        public dvec5 rgbrr => new dvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.xyzxy swizzling.
        /// </summary>
        public dvec5 xyzxy => new dvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.rgbrg swizzling (equivalent to dvec4.xyzxy).
        /// </summary>
        public dvec5 rgbrg => new dvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.xyzxz swizzling.
        /// </summary>
        public dvec5 xyzxz => new dvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.rgbrb swizzling (equivalent to dvec4.xyzxz).
        /// </summary>
        public dvec5 rgbrb => new dvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.xyzxw swizzling.
        /// </summary>
        public dvec5 xyzxw => new dvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.rgbra swizzling (equivalent to dvec4.xyzxw).
        /// </summary>
        public dvec5 rgbra => new dvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.xyzy swizzling.
        /// </summary>
        public dvec4 xyzy => new dvec4(x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.rgbg swizzling (equivalent to dvec4.xyzy).
        /// </summary>
        public dvec4 rgbg => new dvec4(x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.xyzyx swizzling.
        /// </summary>
        public dvec5 xyzyx => new dvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.rgbgr swizzling (equivalent to dvec4.xyzyx).
        /// </summary>
        public dvec5 rgbgr => new dvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.xyzyy swizzling.
        /// </summary>
        public dvec5 xyzyy => new dvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.rgbgg swizzling (equivalent to dvec4.xyzyy).
        /// </summary>
        public dvec5 rgbgg => new dvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.xyzyz swizzling.
        /// </summary>
        public dvec5 xyzyz => new dvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.rgbgb swizzling (equivalent to dvec4.xyzyz).
        /// </summary>
        public dvec5 rgbgb => new dvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.xyzyw swizzling.
        /// </summary>
        public dvec5 xyzyw => new dvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.rgbga swizzling (equivalent to dvec4.xyzyw).
        /// </summary>
        public dvec5 rgbga => new dvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.xyzz swizzling.
        /// </summary>
        public dvec4 xyzz => new dvec4(x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.rgbb swizzling (equivalent to dvec4.xyzz).
        /// </summary>
        public dvec4 rgbb => new dvec4(x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.xyzzx swizzling.
        /// </summary>
        public dvec5 xyzzx => new dvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.rgbbr swizzling (equivalent to dvec4.xyzzx).
        /// </summary>
        public dvec5 rgbbr => new dvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.xyzzy swizzling.
        /// </summary>
        public dvec5 xyzzy => new dvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.rgbbg swizzling (equivalent to dvec4.xyzzy).
        /// </summary>
        public dvec5 rgbbg => new dvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.xyzzz swizzling.
        /// </summary>
        public dvec5 xyzzz => new dvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.rgbbb swizzling (equivalent to dvec4.xyzzz).
        /// </summary>
        public dvec5 rgbbb => new dvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.xyzzw swizzling.
        /// </summary>
        public dvec5 xyzzw => new dvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.rgbba swizzling (equivalent to dvec4.xyzzw).
        /// </summary>
        public dvec5 rgbba => new dvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.xyzw swizzling.
        /// </summary>
        public dvec4 xyzw => new dvec4(x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.rgba swizzling (equivalent to dvec4.xyzw).
        /// </summary>
        public dvec4 rgba => new dvec4(x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.xyzwx swizzling.
        /// </summary>
        public dvec5 xyzwx => new dvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.rgbar swizzling (equivalent to dvec4.xyzwx).
        /// </summary>
        public dvec5 rgbar => new dvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.xyzwy swizzling.
        /// </summary>
        public dvec5 xyzwy => new dvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.rgbag swizzling (equivalent to dvec4.xyzwy).
        /// </summary>
        public dvec5 rgbag => new dvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.xyzwz swizzling.
        /// </summary>
        public dvec5 xyzwz => new dvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.rgbab swizzling (equivalent to dvec4.xyzwz).
        /// </summary>
        public dvec5 rgbab => new dvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.xyzww swizzling.
        /// </summary>
        public dvec5 xyzww => new dvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.rgbaa swizzling (equivalent to dvec4.xyzww).
        /// </summary>
        public dvec5 rgbaa => new dvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.xyw swizzling.
        /// </summary>
        public dvec3 xyw => new dvec3(x, y, w);
        
        /// <summary>
        /// Returns dvec4.rga swizzling (equivalent to dvec4.xyw).
        /// </summary>
        public dvec3 rga => new dvec3(x, y, w);
        
        /// <summary>
        /// Returns dvec4.xywx swizzling.
        /// </summary>
        public dvec4 xywx => new dvec4(x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.rgar swizzling (equivalent to dvec4.xywx).
        /// </summary>
        public dvec4 rgar => new dvec4(x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.xywxx swizzling.
        /// </summary>
        public dvec5 xywxx => new dvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.rgarr swizzling (equivalent to dvec4.xywxx).
        /// </summary>
        public dvec5 rgarr => new dvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.xywxy swizzling.
        /// </summary>
        public dvec5 xywxy => new dvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.rgarg swizzling (equivalent to dvec4.xywxy).
        /// </summary>
        public dvec5 rgarg => new dvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.xywxz swizzling.
        /// </summary>
        public dvec5 xywxz => new dvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.rgarb swizzling (equivalent to dvec4.xywxz).
        /// </summary>
        public dvec5 rgarb => new dvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.xywxw swizzling.
        /// </summary>
        public dvec5 xywxw => new dvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.rgara swizzling (equivalent to dvec4.xywxw).
        /// </summary>
        public dvec5 rgara => new dvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.xywy swizzling.
        /// </summary>
        public dvec4 xywy => new dvec4(x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.rgag swizzling (equivalent to dvec4.xywy).
        /// </summary>
        public dvec4 rgag => new dvec4(x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.xywyx swizzling.
        /// </summary>
        public dvec5 xywyx => new dvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.rgagr swizzling (equivalent to dvec4.xywyx).
        /// </summary>
        public dvec5 rgagr => new dvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.xywyy swizzling.
        /// </summary>
        public dvec5 xywyy => new dvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.rgagg swizzling (equivalent to dvec4.xywyy).
        /// </summary>
        public dvec5 rgagg => new dvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.xywyz swizzling.
        /// </summary>
        public dvec5 xywyz => new dvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.rgagb swizzling (equivalent to dvec4.xywyz).
        /// </summary>
        public dvec5 rgagb => new dvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.xywyw swizzling.
        /// </summary>
        public dvec5 xywyw => new dvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.rgaga swizzling (equivalent to dvec4.xywyw).
        /// </summary>
        public dvec5 rgaga => new dvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.xywz swizzling.
        /// </summary>
        public dvec4 xywz => new dvec4(x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.rgab swizzling (equivalent to dvec4.xywz).
        /// </summary>
        public dvec4 rgab => new dvec4(x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.xywzx swizzling.
        /// </summary>
        public dvec5 xywzx => new dvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.rgabr swizzling (equivalent to dvec4.xywzx).
        /// </summary>
        public dvec5 rgabr => new dvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.xywzy swizzling.
        /// </summary>
        public dvec5 xywzy => new dvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.rgabg swizzling (equivalent to dvec4.xywzy).
        /// </summary>
        public dvec5 rgabg => new dvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.xywzz swizzling.
        /// </summary>
        public dvec5 xywzz => new dvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.rgabb swizzling (equivalent to dvec4.xywzz).
        /// </summary>
        public dvec5 rgabb => new dvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.xywzw swizzling.
        /// </summary>
        public dvec5 xywzw => new dvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.rgaba swizzling (equivalent to dvec4.xywzw).
        /// </summary>
        public dvec5 rgaba => new dvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.xyww swizzling.
        /// </summary>
        public dvec4 xyww => new dvec4(x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.rgaa swizzling (equivalent to dvec4.xyww).
        /// </summary>
        public dvec4 rgaa => new dvec4(x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.xywwx swizzling.
        /// </summary>
        public dvec5 xywwx => new dvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.rgaar swizzling (equivalent to dvec4.xywwx).
        /// </summary>
        public dvec5 rgaar => new dvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.xywwy swizzling.
        /// </summary>
        public dvec5 xywwy => new dvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.rgaag swizzling (equivalent to dvec4.xywwy).
        /// </summary>
        public dvec5 rgaag => new dvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.xywwz swizzling.
        /// </summary>
        public dvec5 xywwz => new dvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.rgaab swizzling (equivalent to dvec4.xywwz).
        /// </summary>
        public dvec5 rgaab => new dvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.xywww swizzling.
        /// </summary>
        public dvec5 xywww => new dvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.rgaaa swizzling (equivalent to dvec4.xywww).
        /// </summary>
        public dvec5 rgaaa => new dvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.xz swizzling.
        /// </summary>
        public dvec2 xz => new dvec2(x, z);
        
        /// <summary>
        /// Returns dvec4.rb swizzling (equivalent to dvec4.xz).
        /// </summary>
        public dvec2 rb => new dvec2(x, z);
        
        /// <summary>
        /// Returns dvec4.xzx swizzling.
        /// </summary>
        public dvec3 xzx => new dvec3(x, z, x);
        
        /// <summary>
        /// Returns dvec4.rbr swizzling (equivalent to dvec4.xzx).
        /// </summary>
        public dvec3 rbr => new dvec3(x, z, x);
        
        /// <summary>
        /// Returns dvec4.xzxx swizzling.
        /// </summary>
        public dvec4 xzxx => new dvec4(x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.rbrr swizzling (equivalent to dvec4.xzxx).
        /// </summary>
        public dvec4 rbrr => new dvec4(x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.xzxxx swizzling.
        /// </summary>
        public dvec5 xzxxx => new dvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.rbrrr swizzling (equivalent to dvec4.xzxxx).
        /// </summary>
        public dvec5 rbrrr => new dvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.xzxxy swizzling.
        /// </summary>
        public dvec5 xzxxy => new dvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.rbrrg swizzling (equivalent to dvec4.xzxxy).
        /// </summary>
        public dvec5 rbrrg => new dvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.xzxxz swizzling.
        /// </summary>
        public dvec5 xzxxz => new dvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.rbrrb swizzling (equivalent to dvec4.xzxxz).
        /// </summary>
        public dvec5 rbrrb => new dvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.xzxxw swizzling.
        /// </summary>
        public dvec5 xzxxw => new dvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.rbrra swizzling (equivalent to dvec4.xzxxw).
        /// </summary>
        public dvec5 rbrra => new dvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.xzxy swizzling.
        /// </summary>
        public dvec4 xzxy => new dvec4(x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.rbrg swizzling (equivalent to dvec4.xzxy).
        /// </summary>
        public dvec4 rbrg => new dvec4(x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.xzxyx swizzling.
        /// </summary>
        public dvec5 xzxyx => new dvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.rbrgr swizzling (equivalent to dvec4.xzxyx).
        /// </summary>
        public dvec5 rbrgr => new dvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.xzxyy swizzling.
        /// </summary>
        public dvec5 xzxyy => new dvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.rbrgg swizzling (equivalent to dvec4.xzxyy).
        /// </summary>
        public dvec5 rbrgg => new dvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.xzxyz swizzling.
        /// </summary>
        public dvec5 xzxyz => new dvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.rbrgb swizzling (equivalent to dvec4.xzxyz).
        /// </summary>
        public dvec5 rbrgb => new dvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.xzxyw swizzling.
        /// </summary>
        public dvec5 xzxyw => new dvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.rbrga swizzling (equivalent to dvec4.xzxyw).
        /// </summary>
        public dvec5 rbrga => new dvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.xzxz swizzling.
        /// </summary>
        public dvec4 xzxz => new dvec4(x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.rbrb swizzling (equivalent to dvec4.xzxz).
        /// </summary>
        public dvec4 rbrb => new dvec4(x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.xzxzx swizzling.
        /// </summary>
        public dvec5 xzxzx => new dvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.rbrbr swizzling (equivalent to dvec4.xzxzx).
        /// </summary>
        public dvec5 rbrbr => new dvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.xzxzy swizzling.
        /// </summary>
        public dvec5 xzxzy => new dvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.rbrbg swizzling (equivalent to dvec4.xzxzy).
        /// </summary>
        public dvec5 rbrbg => new dvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.xzxzz swizzling.
        /// </summary>
        public dvec5 xzxzz => new dvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.rbrbb swizzling (equivalent to dvec4.xzxzz).
        /// </summary>
        public dvec5 rbrbb => new dvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.xzxzw swizzling.
        /// </summary>
        public dvec5 xzxzw => new dvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.rbrba swizzling (equivalent to dvec4.xzxzw).
        /// </summary>
        public dvec5 rbrba => new dvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.xzxw swizzling.
        /// </summary>
        public dvec4 xzxw => new dvec4(x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.rbra swizzling (equivalent to dvec4.xzxw).
        /// </summary>
        public dvec4 rbra => new dvec4(x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.xzxwx swizzling.
        /// </summary>
        public dvec5 xzxwx => new dvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.rbrar swizzling (equivalent to dvec4.xzxwx).
        /// </summary>
        public dvec5 rbrar => new dvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.xzxwy swizzling.
        /// </summary>
        public dvec5 xzxwy => new dvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.rbrag swizzling (equivalent to dvec4.xzxwy).
        /// </summary>
        public dvec5 rbrag => new dvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.xzxwz swizzling.
        /// </summary>
        public dvec5 xzxwz => new dvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.rbrab swizzling (equivalent to dvec4.xzxwz).
        /// </summary>
        public dvec5 rbrab => new dvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.xzxww swizzling.
        /// </summary>
        public dvec5 xzxww => new dvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.rbraa swizzling (equivalent to dvec4.xzxww).
        /// </summary>
        public dvec5 rbraa => new dvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.xzy swizzling.
        /// </summary>
        public dvec3 xzy => new dvec3(x, z, y);
        
        /// <summary>
        /// Returns dvec4.rbg swizzling (equivalent to dvec4.xzy).
        /// </summary>
        public dvec3 rbg => new dvec3(x, z, y);
        
        /// <summary>
        /// Returns dvec4.xzyx swizzling.
        /// </summary>
        public dvec4 xzyx => new dvec4(x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.rbgr swizzling (equivalent to dvec4.xzyx).
        /// </summary>
        public dvec4 rbgr => new dvec4(x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.xzyxx swizzling.
        /// </summary>
        public dvec5 xzyxx => new dvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.rbgrr swizzling (equivalent to dvec4.xzyxx).
        /// </summary>
        public dvec5 rbgrr => new dvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.xzyxy swizzling.
        /// </summary>
        public dvec5 xzyxy => new dvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.rbgrg swizzling (equivalent to dvec4.xzyxy).
        /// </summary>
        public dvec5 rbgrg => new dvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.xzyxz swizzling.
        /// </summary>
        public dvec5 xzyxz => new dvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.rbgrb swizzling (equivalent to dvec4.xzyxz).
        /// </summary>
        public dvec5 rbgrb => new dvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.xzyxw swizzling.
        /// </summary>
        public dvec5 xzyxw => new dvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.rbgra swizzling (equivalent to dvec4.xzyxw).
        /// </summary>
        public dvec5 rbgra => new dvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.xzyy swizzling.
        /// </summary>
        public dvec4 xzyy => new dvec4(x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.rbgg swizzling (equivalent to dvec4.xzyy).
        /// </summary>
        public dvec4 rbgg => new dvec4(x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.xzyyx swizzling.
        /// </summary>
        public dvec5 xzyyx => new dvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.rbggr swizzling (equivalent to dvec4.xzyyx).
        /// </summary>
        public dvec5 rbggr => new dvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.xzyyy swizzling.
        /// </summary>
        public dvec5 xzyyy => new dvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.rbggg swizzling (equivalent to dvec4.xzyyy).
        /// </summary>
        public dvec5 rbggg => new dvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.xzyyz swizzling.
        /// </summary>
        public dvec5 xzyyz => new dvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.rbggb swizzling (equivalent to dvec4.xzyyz).
        /// </summary>
        public dvec5 rbggb => new dvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.xzyyw swizzling.
        /// </summary>
        public dvec5 xzyyw => new dvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.rbgga swizzling (equivalent to dvec4.xzyyw).
        /// </summary>
        public dvec5 rbgga => new dvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.xzyz swizzling.
        /// </summary>
        public dvec4 xzyz => new dvec4(x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.rbgb swizzling (equivalent to dvec4.xzyz).
        /// </summary>
        public dvec4 rbgb => new dvec4(x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.xzyzx swizzling.
        /// </summary>
        public dvec5 xzyzx => new dvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.rbgbr swizzling (equivalent to dvec4.xzyzx).
        /// </summary>
        public dvec5 rbgbr => new dvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.xzyzy swizzling.
        /// </summary>
        public dvec5 xzyzy => new dvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.rbgbg swizzling (equivalent to dvec4.xzyzy).
        /// </summary>
        public dvec5 rbgbg => new dvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.xzyzz swizzling.
        /// </summary>
        public dvec5 xzyzz => new dvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.rbgbb swizzling (equivalent to dvec4.xzyzz).
        /// </summary>
        public dvec5 rbgbb => new dvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.xzyzw swizzling.
        /// </summary>
        public dvec5 xzyzw => new dvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.rbgba swizzling (equivalent to dvec4.xzyzw).
        /// </summary>
        public dvec5 rbgba => new dvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.xzyw swizzling.
        /// </summary>
        public dvec4 xzyw => new dvec4(x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.rbga swizzling (equivalent to dvec4.xzyw).
        /// </summary>
        public dvec4 rbga => new dvec4(x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.xzywx swizzling.
        /// </summary>
        public dvec5 xzywx => new dvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.rbgar swizzling (equivalent to dvec4.xzywx).
        /// </summary>
        public dvec5 rbgar => new dvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.xzywy swizzling.
        /// </summary>
        public dvec5 xzywy => new dvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.rbgag swizzling (equivalent to dvec4.xzywy).
        /// </summary>
        public dvec5 rbgag => new dvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.xzywz swizzling.
        /// </summary>
        public dvec5 xzywz => new dvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.rbgab swizzling (equivalent to dvec4.xzywz).
        /// </summary>
        public dvec5 rbgab => new dvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.xzyww swizzling.
        /// </summary>
        public dvec5 xzyww => new dvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.rbgaa swizzling (equivalent to dvec4.xzyww).
        /// </summary>
        public dvec5 rbgaa => new dvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.xzz swizzling.
        /// </summary>
        public dvec3 xzz => new dvec3(x, z, z);
        
        /// <summary>
        /// Returns dvec4.rbb swizzling (equivalent to dvec4.xzz).
        /// </summary>
        public dvec3 rbb => new dvec3(x, z, z);
        
        /// <summary>
        /// Returns dvec4.xzzx swizzling.
        /// </summary>
        public dvec4 xzzx => new dvec4(x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.rbbr swizzling (equivalent to dvec4.xzzx).
        /// </summary>
        public dvec4 rbbr => new dvec4(x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.xzzxx swizzling.
        /// </summary>
        public dvec5 xzzxx => new dvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.rbbrr swizzling (equivalent to dvec4.xzzxx).
        /// </summary>
        public dvec5 rbbrr => new dvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.xzzxy swizzling.
        /// </summary>
        public dvec5 xzzxy => new dvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.rbbrg swizzling (equivalent to dvec4.xzzxy).
        /// </summary>
        public dvec5 rbbrg => new dvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.xzzxz swizzling.
        /// </summary>
        public dvec5 xzzxz => new dvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.rbbrb swizzling (equivalent to dvec4.xzzxz).
        /// </summary>
        public dvec5 rbbrb => new dvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.xzzxw swizzling.
        /// </summary>
        public dvec5 xzzxw => new dvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.rbbra swizzling (equivalent to dvec4.xzzxw).
        /// </summary>
        public dvec5 rbbra => new dvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.xzzy swizzling.
        /// </summary>
        public dvec4 xzzy => new dvec4(x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.rbbg swizzling (equivalent to dvec4.xzzy).
        /// </summary>
        public dvec4 rbbg => new dvec4(x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.xzzyx swizzling.
        /// </summary>
        public dvec5 xzzyx => new dvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.rbbgr swizzling (equivalent to dvec4.xzzyx).
        /// </summary>
        public dvec5 rbbgr => new dvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.xzzyy swizzling.
        /// </summary>
        public dvec5 xzzyy => new dvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.rbbgg swizzling (equivalent to dvec4.xzzyy).
        /// </summary>
        public dvec5 rbbgg => new dvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.xzzyz swizzling.
        /// </summary>
        public dvec5 xzzyz => new dvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.rbbgb swizzling (equivalent to dvec4.xzzyz).
        /// </summary>
        public dvec5 rbbgb => new dvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.xzzyw swizzling.
        /// </summary>
        public dvec5 xzzyw => new dvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.rbbga swizzling (equivalent to dvec4.xzzyw).
        /// </summary>
        public dvec5 rbbga => new dvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.xzzz swizzling.
        /// </summary>
        public dvec4 xzzz => new dvec4(x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.rbbb swizzling (equivalent to dvec4.xzzz).
        /// </summary>
        public dvec4 rbbb => new dvec4(x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.xzzzx swizzling.
        /// </summary>
        public dvec5 xzzzx => new dvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.rbbbr swizzling (equivalent to dvec4.xzzzx).
        /// </summary>
        public dvec5 rbbbr => new dvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.xzzzy swizzling.
        /// </summary>
        public dvec5 xzzzy => new dvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.rbbbg swizzling (equivalent to dvec4.xzzzy).
        /// </summary>
        public dvec5 rbbbg => new dvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.xzzzz swizzling.
        /// </summary>
        public dvec5 xzzzz => new dvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.rbbbb swizzling (equivalent to dvec4.xzzzz).
        /// </summary>
        public dvec5 rbbbb => new dvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.xzzzw swizzling.
        /// </summary>
        public dvec5 xzzzw => new dvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.rbbba swizzling (equivalent to dvec4.xzzzw).
        /// </summary>
        public dvec5 rbbba => new dvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.xzzw swizzling.
        /// </summary>
        public dvec4 xzzw => new dvec4(x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.rbba swizzling (equivalent to dvec4.xzzw).
        /// </summary>
        public dvec4 rbba => new dvec4(x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.xzzwx swizzling.
        /// </summary>
        public dvec5 xzzwx => new dvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.rbbar swizzling (equivalent to dvec4.xzzwx).
        /// </summary>
        public dvec5 rbbar => new dvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.xzzwy swizzling.
        /// </summary>
        public dvec5 xzzwy => new dvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.rbbag swizzling (equivalent to dvec4.xzzwy).
        /// </summary>
        public dvec5 rbbag => new dvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.xzzwz swizzling.
        /// </summary>
        public dvec5 xzzwz => new dvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.rbbab swizzling (equivalent to dvec4.xzzwz).
        /// </summary>
        public dvec5 rbbab => new dvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.xzzww swizzling.
        /// </summary>
        public dvec5 xzzww => new dvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.rbbaa swizzling (equivalent to dvec4.xzzww).
        /// </summary>
        public dvec5 rbbaa => new dvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.xzw swizzling.
        /// </summary>
        public dvec3 xzw => new dvec3(x, z, w);
        
        /// <summary>
        /// Returns dvec4.rba swizzling (equivalent to dvec4.xzw).
        /// </summary>
        public dvec3 rba => new dvec3(x, z, w);
        
        /// <summary>
        /// Returns dvec4.xzwx swizzling.
        /// </summary>
        public dvec4 xzwx => new dvec4(x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.rbar swizzling (equivalent to dvec4.xzwx).
        /// </summary>
        public dvec4 rbar => new dvec4(x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.xzwxx swizzling.
        /// </summary>
        public dvec5 xzwxx => new dvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.rbarr swizzling (equivalent to dvec4.xzwxx).
        /// </summary>
        public dvec5 rbarr => new dvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.xzwxy swizzling.
        /// </summary>
        public dvec5 xzwxy => new dvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.rbarg swizzling (equivalent to dvec4.xzwxy).
        /// </summary>
        public dvec5 rbarg => new dvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.xzwxz swizzling.
        /// </summary>
        public dvec5 xzwxz => new dvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.rbarb swizzling (equivalent to dvec4.xzwxz).
        /// </summary>
        public dvec5 rbarb => new dvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.xzwxw swizzling.
        /// </summary>
        public dvec5 xzwxw => new dvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.rbara swizzling (equivalent to dvec4.xzwxw).
        /// </summary>
        public dvec5 rbara => new dvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.xzwy swizzling.
        /// </summary>
        public dvec4 xzwy => new dvec4(x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.rbag swizzling (equivalent to dvec4.xzwy).
        /// </summary>
        public dvec4 rbag => new dvec4(x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.xzwyx swizzling.
        /// </summary>
        public dvec5 xzwyx => new dvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.rbagr swizzling (equivalent to dvec4.xzwyx).
        /// </summary>
        public dvec5 rbagr => new dvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.xzwyy swizzling.
        /// </summary>
        public dvec5 xzwyy => new dvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.rbagg swizzling (equivalent to dvec4.xzwyy).
        /// </summary>
        public dvec5 rbagg => new dvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.xzwyz swizzling.
        /// </summary>
        public dvec5 xzwyz => new dvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.rbagb swizzling (equivalent to dvec4.xzwyz).
        /// </summary>
        public dvec5 rbagb => new dvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.xzwyw swizzling.
        /// </summary>
        public dvec5 xzwyw => new dvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.rbaga swizzling (equivalent to dvec4.xzwyw).
        /// </summary>
        public dvec5 rbaga => new dvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.xzwz swizzling.
        /// </summary>
        public dvec4 xzwz => new dvec4(x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.rbab swizzling (equivalent to dvec4.xzwz).
        /// </summary>
        public dvec4 rbab => new dvec4(x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.xzwzx swizzling.
        /// </summary>
        public dvec5 xzwzx => new dvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.rbabr swizzling (equivalent to dvec4.xzwzx).
        /// </summary>
        public dvec5 rbabr => new dvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.xzwzy swizzling.
        /// </summary>
        public dvec5 xzwzy => new dvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.rbabg swizzling (equivalent to dvec4.xzwzy).
        /// </summary>
        public dvec5 rbabg => new dvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.xzwzz swizzling.
        /// </summary>
        public dvec5 xzwzz => new dvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.rbabb swizzling (equivalent to dvec4.xzwzz).
        /// </summary>
        public dvec5 rbabb => new dvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.xzwzw swizzling.
        /// </summary>
        public dvec5 xzwzw => new dvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.rbaba swizzling (equivalent to dvec4.xzwzw).
        /// </summary>
        public dvec5 rbaba => new dvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.xzww swizzling.
        /// </summary>
        public dvec4 xzww => new dvec4(x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.rbaa swizzling (equivalent to dvec4.xzww).
        /// </summary>
        public dvec4 rbaa => new dvec4(x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.xzwwx swizzling.
        /// </summary>
        public dvec5 xzwwx => new dvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.rbaar swizzling (equivalent to dvec4.xzwwx).
        /// </summary>
        public dvec5 rbaar => new dvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.xzwwy swizzling.
        /// </summary>
        public dvec5 xzwwy => new dvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.rbaag swizzling (equivalent to dvec4.xzwwy).
        /// </summary>
        public dvec5 rbaag => new dvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.xzwwz swizzling.
        /// </summary>
        public dvec5 xzwwz => new dvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.rbaab swizzling (equivalent to dvec4.xzwwz).
        /// </summary>
        public dvec5 rbaab => new dvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.xzwww swizzling.
        /// </summary>
        public dvec5 xzwww => new dvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.rbaaa swizzling (equivalent to dvec4.xzwww).
        /// </summary>
        public dvec5 rbaaa => new dvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.xw swizzling.
        /// </summary>
        public dvec2 xw => new dvec2(x, w);
        
        /// <summary>
        /// Returns dvec4.ra swizzling (equivalent to dvec4.xw).
        /// </summary>
        public dvec2 ra => new dvec2(x, w);
        
        /// <summary>
        /// Returns dvec4.xwx swizzling.
        /// </summary>
        public dvec3 xwx => new dvec3(x, w, x);
        
        /// <summary>
        /// Returns dvec4.rar swizzling (equivalent to dvec4.xwx).
        /// </summary>
        public dvec3 rar => new dvec3(x, w, x);
        
        /// <summary>
        /// Returns dvec4.xwxx swizzling.
        /// </summary>
        public dvec4 xwxx => new dvec4(x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.rarr swizzling (equivalent to dvec4.xwxx).
        /// </summary>
        public dvec4 rarr => new dvec4(x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.xwxxx swizzling.
        /// </summary>
        public dvec5 xwxxx => new dvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.rarrr swizzling (equivalent to dvec4.xwxxx).
        /// </summary>
        public dvec5 rarrr => new dvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.xwxxy swizzling.
        /// </summary>
        public dvec5 xwxxy => new dvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.rarrg swizzling (equivalent to dvec4.xwxxy).
        /// </summary>
        public dvec5 rarrg => new dvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.xwxxz swizzling.
        /// </summary>
        public dvec5 xwxxz => new dvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.rarrb swizzling (equivalent to dvec4.xwxxz).
        /// </summary>
        public dvec5 rarrb => new dvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.xwxxw swizzling.
        /// </summary>
        public dvec5 xwxxw => new dvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.rarra swizzling (equivalent to dvec4.xwxxw).
        /// </summary>
        public dvec5 rarra => new dvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.xwxy swizzling.
        /// </summary>
        public dvec4 xwxy => new dvec4(x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.rarg swizzling (equivalent to dvec4.xwxy).
        /// </summary>
        public dvec4 rarg => new dvec4(x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.xwxyx swizzling.
        /// </summary>
        public dvec5 xwxyx => new dvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.rargr swizzling (equivalent to dvec4.xwxyx).
        /// </summary>
        public dvec5 rargr => new dvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.xwxyy swizzling.
        /// </summary>
        public dvec5 xwxyy => new dvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.rargg swizzling (equivalent to dvec4.xwxyy).
        /// </summary>
        public dvec5 rargg => new dvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.xwxyz swizzling.
        /// </summary>
        public dvec5 xwxyz => new dvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.rargb swizzling (equivalent to dvec4.xwxyz).
        /// </summary>
        public dvec5 rargb => new dvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.xwxyw swizzling.
        /// </summary>
        public dvec5 xwxyw => new dvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.rarga swizzling (equivalent to dvec4.xwxyw).
        /// </summary>
        public dvec5 rarga => new dvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.xwxz swizzling.
        /// </summary>
        public dvec4 xwxz => new dvec4(x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.rarb swizzling (equivalent to dvec4.xwxz).
        /// </summary>
        public dvec4 rarb => new dvec4(x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.xwxzx swizzling.
        /// </summary>
        public dvec5 xwxzx => new dvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.rarbr swizzling (equivalent to dvec4.xwxzx).
        /// </summary>
        public dvec5 rarbr => new dvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.xwxzy swizzling.
        /// </summary>
        public dvec5 xwxzy => new dvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.rarbg swizzling (equivalent to dvec4.xwxzy).
        /// </summary>
        public dvec5 rarbg => new dvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.xwxzz swizzling.
        /// </summary>
        public dvec5 xwxzz => new dvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.rarbb swizzling (equivalent to dvec4.xwxzz).
        /// </summary>
        public dvec5 rarbb => new dvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.xwxzw swizzling.
        /// </summary>
        public dvec5 xwxzw => new dvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.rarba swizzling (equivalent to dvec4.xwxzw).
        /// </summary>
        public dvec5 rarba => new dvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.xwxw swizzling.
        /// </summary>
        public dvec4 xwxw => new dvec4(x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.rara swizzling (equivalent to dvec4.xwxw).
        /// </summary>
        public dvec4 rara => new dvec4(x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.xwxwx swizzling.
        /// </summary>
        public dvec5 xwxwx => new dvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.rarar swizzling (equivalent to dvec4.xwxwx).
        /// </summary>
        public dvec5 rarar => new dvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.xwxwy swizzling.
        /// </summary>
        public dvec5 xwxwy => new dvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.rarag swizzling (equivalent to dvec4.xwxwy).
        /// </summary>
        public dvec5 rarag => new dvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.xwxwz swizzling.
        /// </summary>
        public dvec5 xwxwz => new dvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.rarab swizzling (equivalent to dvec4.xwxwz).
        /// </summary>
        public dvec5 rarab => new dvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.xwxww swizzling.
        /// </summary>
        public dvec5 xwxww => new dvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.raraa swizzling (equivalent to dvec4.xwxww).
        /// </summary>
        public dvec5 raraa => new dvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.xwy swizzling.
        /// </summary>
        public dvec3 xwy => new dvec3(x, w, y);
        
        /// <summary>
        /// Returns dvec4.rag swizzling (equivalent to dvec4.xwy).
        /// </summary>
        public dvec3 rag => new dvec3(x, w, y);
        
        /// <summary>
        /// Returns dvec4.xwyx swizzling.
        /// </summary>
        public dvec4 xwyx => new dvec4(x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.ragr swizzling (equivalent to dvec4.xwyx).
        /// </summary>
        public dvec4 ragr => new dvec4(x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.xwyxx swizzling.
        /// </summary>
        public dvec5 xwyxx => new dvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.ragrr swizzling (equivalent to dvec4.xwyxx).
        /// </summary>
        public dvec5 ragrr => new dvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.xwyxy swizzling.
        /// </summary>
        public dvec5 xwyxy => new dvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.ragrg swizzling (equivalent to dvec4.xwyxy).
        /// </summary>
        public dvec5 ragrg => new dvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.xwyxz swizzling.
        /// </summary>
        public dvec5 xwyxz => new dvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.ragrb swizzling (equivalent to dvec4.xwyxz).
        /// </summary>
        public dvec5 ragrb => new dvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.xwyxw swizzling.
        /// </summary>
        public dvec5 xwyxw => new dvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.ragra swizzling (equivalent to dvec4.xwyxw).
        /// </summary>
        public dvec5 ragra => new dvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.xwyy swizzling.
        /// </summary>
        public dvec4 xwyy => new dvec4(x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.ragg swizzling (equivalent to dvec4.xwyy).
        /// </summary>
        public dvec4 ragg => new dvec4(x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.xwyyx swizzling.
        /// </summary>
        public dvec5 xwyyx => new dvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.raggr swizzling (equivalent to dvec4.xwyyx).
        /// </summary>
        public dvec5 raggr => new dvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.xwyyy swizzling.
        /// </summary>
        public dvec5 xwyyy => new dvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.raggg swizzling (equivalent to dvec4.xwyyy).
        /// </summary>
        public dvec5 raggg => new dvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.xwyyz swizzling.
        /// </summary>
        public dvec5 xwyyz => new dvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.raggb swizzling (equivalent to dvec4.xwyyz).
        /// </summary>
        public dvec5 raggb => new dvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.xwyyw swizzling.
        /// </summary>
        public dvec5 xwyyw => new dvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.ragga swizzling (equivalent to dvec4.xwyyw).
        /// </summary>
        public dvec5 ragga => new dvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.xwyz swizzling.
        /// </summary>
        public dvec4 xwyz => new dvec4(x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.ragb swizzling (equivalent to dvec4.xwyz).
        /// </summary>
        public dvec4 ragb => new dvec4(x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.xwyzx swizzling.
        /// </summary>
        public dvec5 xwyzx => new dvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.ragbr swizzling (equivalent to dvec4.xwyzx).
        /// </summary>
        public dvec5 ragbr => new dvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.xwyzy swizzling.
        /// </summary>
        public dvec5 xwyzy => new dvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.ragbg swizzling (equivalent to dvec4.xwyzy).
        /// </summary>
        public dvec5 ragbg => new dvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.xwyzz swizzling.
        /// </summary>
        public dvec5 xwyzz => new dvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.ragbb swizzling (equivalent to dvec4.xwyzz).
        /// </summary>
        public dvec5 ragbb => new dvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.xwyzw swizzling.
        /// </summary>
        public dvec5 xwyzw => new dvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.ragba swizzling (equivalent to dvec4.xwyzw).
        /// </summary>
        public dvec5 ragba => new dvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.xwyw swizzling.
        /// </summary>
        public dvec4 xwyw => new dvec4(x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.raga swizzling (equivalent to dvec4.xwyw).
        /// </summary>
        public dvec4 raga => new dvec4(x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.xwywx swizzling.
        /// </summary>
        public dvec5 xwywx => new dvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.ragar swizzling (equivalent to dvec4.xwywx).
        /// </summary>
        public dvec5 ragar => new dvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.xwywy swizzling.
        /// </summary>
        public dvec5 xwywy => new dvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.ragag swizzling (equivalent to dvec4.xwywy).
        /// </summary>
        public dvec5 ragag => new dvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.xwywz swizzling.
        /// </summary>
        public dvec5 xwywz => new dvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.ragab swizzling (equivalent to dvec4.xwywz).
        /// </summary>
        public dvec5 ragab => new dvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.xwyww swizzling.
        /// </summary>
        public dvec5 xwyww => new dvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.ragaa swizzling (equivalent to dvec4.xwyww).
        /// </summary>
        public dvec5 ragaa => new dvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.xwz swizzling.
        /// </summary>
        public dvec3 xwz => new dvec3(x, w, z);
        
        /// <summary>
        /// Returns dvec4.rab swizzling (equivalent to dvec4.xwz).
        /// </summary>
        public dvec3 rab => new dvec3(x, w, z);
        
        /// <summary>
        /// Returns dvec4.xwzx swizzling.
        /// </summary>
        public dvec4 xwzx => new dvec4(x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.rabr swizzling (equivalent to dvec4.xwzx).
        /// </summary>
        public dvec4 rabr => new dvec4(x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.xwzxx swizzling.
        /// </summary>
        public dvec5 xwzxx => new dvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.rabrr swizzling (equivalent to dvec4.xwzxx).
        /// </summary>
        public dvec5 rabrr => new dvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.xwzxy swizzling.
        /// </summary>
        public dvec5 xwzxy => new dvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.rabrg swizzling (equivalent to dvec4.xwzxy).
        /// </summary>
        public dvec5 rabrg => new dvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.xwzxz swizzling.
        /// </summary>
        public dvec5 xwzxz => new dvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.rabrb swizzling (equivalent to dvec4.xwzxz).
        /// </summary>
        public dvec5 rabrb => new dvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.xwzxw swizzling.
        /// </summary>
        public dvec5 xwzxw => new dvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.rabra swizzling (equivalent to dvec4.xwzxw).
        /// </summary>
        public dvec5 rabra => new dvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.xwzy swizzling.
        /// </summary>
        public dvec4 xwzy => new dvec4(x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.rabg swizzling (equivalent to dvec4.xwzy).
        /// </summary>
        public dvec4 rabg => new dvec4(x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.xwzyx swizzling.
        /// </summary>
        public dvec5 xwzyx => new dvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.rabgr swizzling (equivalent to dvec4.xwzyx).
        /// </summary>
        public dvec5 rabgr => new dvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.xwzyy swizzling.
        /// </summary>
        public dvec5 xwzyy => new dvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.rabgg swizzling (equivalent to dvec4.xwzyy).
        /// </summary>
        public dvec5 rabgg => new dvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.xwzyz swizzling.
        /// </summary>
        public dvec5 xwzyz => new dvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.rabgb swizzling (equivalent to dvec4.xwzyz).
        /// </summary>
        public dvec5 rabgb => new dvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.xwzyw swizzling.
        /// </summary>
        public dvec5 xwzyw => new dvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.rabga swizzling (equivalent to dvec4.xwzyw).
        /// </summary>
        public dvec5 rabga => new dvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.xwzz swizzling.
        /// </summary>
        public dvec4 xwzz => new dvec4(x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.rabb swizzling (equivalent to dvec4.xwzz).
        /// </summary>
        public dvec4 rabb => new dvec4(x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.xwzzx swizzling.
        /// </summary>
        public dvec5 xwzzx => new dvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.rabbr swizzling (equivalent to dvec4.xwzzx).
        /// </summary>
        public dvec5 rabbr => new dvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.xwzzy swizzling.
        /// </summary>
        public dvec5 xwzzy => new dvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.rabbg swizzling (equivalent to dvec4.xwzzy).
        /// </summary>
        public dvec5 rabbg => new dvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.xwzzz swizzling.
        /// </summary>
        public dvec5 xwzzz => new dvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.rabbb swizzling (equivalent to dvec4.xwzzz).
        /// </summary>
        public dvec5 rabbb => new dvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.xwzzw swizzling.
        /// </summary>
        public dvec5 xwzzw => new dvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.rabba swizzling (equivalent to dvec4.xwzzw).
        /// </summary>
        public dvec5 rabba => new dvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.xwzw swizzling.
        /// </summary>
        public dvec4 xwzw => new dvec4(x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.raba swizzling (equivalent to dvec4.xwzw).
        /// </summary>
        public dvec4 raba => new dvec4(x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.xwzwx swizzling.
        /// </summary>
        public dvec5 xwzwx => new dvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.rabar swizzling (equivalent to dvec4.xwzwx).
        /// </summary>
        public dvec5 rabar => new dvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.xwzwy swizzling.
        /// </summary>
        public dvec5 xwzwy => new dvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.rabag swizzling (equivalent to dvec4.xwzwy).
        /// </summary>
        public dvec5 rabag => new dvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.xwzwz swizzling.
        /// </summary>
        public dvec5 xwzwz => new dvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.rabab swizzling (equivalent to dvec4.xwzwz).
        /// </summary>
        public dvec5 rabab => new dvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.xwzww swizzling.
        /// </summary>
        public dvec5 xwzww => new dvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.rabaa swizzling (equivalent to dvec4.xwzww).
        /// </summary>
        public dvec5 rabaa => new dvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.xww swizzling.
        /// </summary>
        public dvec3 xww => new dvec3(x, w, w);
        
        /// <summary>
        /// Returns dvec4.raa swizzling (equivalent to dvec4.xww).
        /// </summary>
        public dvec3 raa => new dvec3(x, w, w);
        
        /// <summary>
        /// Returns dvec4.xwwx swizzling.
        /// </summary>
        public dvec4 xwwx => new dvec4(x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.raar swizzling (equivalent to dvec4.xwwx).
        /// </summary>
        public dvec4 raar => new dvec4(x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.xwwxx swizzling.
        /// </summary>
        public dvec5 xwwxx => new dvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.raarr swizzling (equivalent to dvec4.xwwxx).
        /// </summary>
        public dvec5 raarr => new dvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.xwwxy swizzling.
        /// </summary>
        public dvec5 xwwxy => new dvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.raarg swizzling (equivalent to dvec4.xwwxy).
        /// </summary>
        public dvec5 raarg => new dvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.xwwxz swizzling.
        /// </summary>
        public dvec5 xwwxz => new dvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.raarb swizzling (equivalent to dvec4.xwwxz).
        /// </summary>
        public dvec5 raarb => new dvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.xwwxw swizzling.
        /// </summary>
        public dvec5 xwwxw => new dvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.raara swizzling (equivalent to dvec4.xwwxw).
        /// </summary>
        public dvec5 raara => new dvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.xwwy swizzling.
        /// </summary>
        public dvec4 xwwy => new dvec4(x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.raag swizzling (equivalent to dvec4.xwwy).
        /// </summary>
        public dvec4 raag => new dvec4(x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.xwwyx swizzling.
        /// </summary>
        public dvec5 xwwyx => new dvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.raagr swizzling (equivalent to dvec4.xwwyx).
        /// </summary>
        public dvec5 raagr => new dvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.xwwyy swizzling.
        /// </summary>
        public dvec5 xwwyy => new dvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.raagg swizzling (equivalent to dvec4.xwwyy).
        /// </summary>
        public dvec5 raagg => new dvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.xwwyz swizzling.
        /// </summary>
        public dvec5 xwwyz => new dvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.raagb swizzling (equivalent to dvec4.xwwyz).
        /// </summary>
        public dvec5 raagb => new dvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.xwwyw swizzling.
        /// </summary>
        public dvec5 xwwyw => new dvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.raaga swizzling (equivalent to dvec4.xwwyw).
        /// </summary>
        public dvec5 raaga => new dvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.xwwz swizzling.
        /// </summary>
        public dvec4 xwwz => new dvec4(x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.raab swizzling (equivalent to dvec4.xwwz).
        /// </summary>
        public dvec4 raab => new dvec4(x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.xwwzx swizzling.
        /// </summary>
        public dvec5 xwwzx => new dvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.raabr swizzling (equivalent to dvec4.xwwzx).
        /// </summary>
        public dvec5 raabr => new dvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.xwwzy swizzling.
        /// </summary>
        public dvec5 xwwzy => new dvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.raabg swizzling (equivalent to dvec4.xwwzy).
        /// </summary>
        public dvec5 raabg => new dvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.xwwzz swizzling.
        /// </summary>
        public dvec5 xwwzz => new dvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.raabb swizzling (equivalent to dvec4.xwwzz).
        /// </summary>
        public dvec5 raabb => new dvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.xwwzw swizzling.
        /// </summary>
        public dvec5 xwwzw => new dvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.raaba swizzling (equivalent to dvec4.xwwzw).
        /// </summary>
        public dvec5 raaba => new dvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.xwww swizzling.
        /// </summary>
        public dvec4 xwww => new dvec4(x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.raaa swizzling (equivalent to dvec4.xwww).
        /// </summary>
        public dvec4 raaa => new dvec4(x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.xwwwx swizzling.
        /// </summary>
        public dvec5 xwwwx => new dvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.raaar swizzling (equivalent to dvec4.xwwwx).
        /// </summary>
        public dvec5 raaar => new dvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.xwwwy swizzling.
        /// </summary>
        public dvec5 xwwwy => new dvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.raaag swizzling (equivalent to dvec4.xwwwy).
        /// </summary>
        public dvec5 raaag => new dvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.xwwwz swizzling.
        /// </summary>
        public dvec5 xwwwz => new dvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.raaab swizzling (equivalent to dvec4.xwwwz).
        /// </summary>
        public dvec5 raaab => new dvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.xwwww swizzling.
        /// </summary>
        public dvec5 xwwww => new dvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns dvec4.raaaa swizzling (equivalent to dvec4.xwwww).
        /// </summary>
        public dvec5 raaaa => new dvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns dvec4.yx swizzling.
        /// </summary>
        public dvec2 yx => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec4.gr swizzling (equivalent to dvec4.yx).
        /// </summary>
        public dvec2 gr => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec4.yxx swizzling.
        /// </summary>
        public dvec3 yxx => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec4.grr swizzling (equivalent to dvec4.yxx).
        /// </summary>
        public dvec3 grr => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec4.yxxx swizzling.
        /// </summary>
        public dvec4 yxxx => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.grrr swizzling (equivalent to dvec4.yxxx).
        /// </summary>
        public dvec4 grrr => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.yxxxx swizzling.
        /// </summary>
        public dvec5 yxxxx => new dvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.grrrr swizzling (equivalent to dvec4.yxxxx).
        /// </summary>
        public dvec5 grrrr => new dvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.yxxxy swizzling.
        /// </summary>
        public dvec5 yxxxy => new dvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.grrrg swizzling (equivalent to dvec4.yxxxy).
        /// </summary>
        public dvec5 grrrg => new dvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.yxxxz swizzling.
        /// </summary>
        public dvec5 yxxxz => new dvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.grrrb swizzling (equivalent to dvec4.yxxxz).
        /// </summary>
        public dvec5 grrrb => new dvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.yxxxw swizzling.
        /// </summary>
        public dvec5 yxxxw => new dvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.grrra swizzling (equivalent to dvec4.yxxxw).
        /// </summary>
        public dvec5 grrra => new dvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.yxxy swizzling.
        /// </summary>
        public dvec4 yxxy => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.grrg swizzling (equivalent to dvec4.yxxy).
        /// </summary>
        public dvec4 grrg => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.yxxyx swizzling.
        /// </summary>
        public dvec5 yxxyx => new dvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.grrgr swizzling (equivalent to dvec4.yxxyx).
        /// </summary>
        public dvec5 grrgr => new dvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.yxxyy swizzling.
        /// </summary>
        public dvec5 yxxyy => new dvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.grrgg swizzling (equivalent to dvec4.yxxyy).
        /// </summary>
        public dvec5 grrgg => new dvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.yxxyz swizzling.
        /// </summary>
        public dvec5 yxxyz => new dvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.grrgb swizzling (equivalent to dvec4.yxxyz).
        /// </summary>
        public dvec5 grrgb => new dvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.yxxyw swizzling.
        /// </summary>
        public dvec5 yxxyw => new dvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.grrga swizzling (equivalent to dvec4.yxxyw).
        /// </summary>
        public dvec5 grrga => new dvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.yxxz swizzling.
        /// </summary>
        public dvec4 yxxz => new dvec4(y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.grrb swizzling (equivalent to dvec4.yxxz).
        /// </summary>
        public dvec4 grrb => new dvec4(y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.yxxzx swizzling.
        /// </summary>
        public dvec5 yxxzx => new dvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.grrbr swizzling (equivalent to dvec4.yxxzx).
        /// </summary>
        public dvec5 grrbr => new dvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.yxxzy swizzling.
        /// </summary>
        public dvec5 yxxzy => new dvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.grrbg swizzling (equivalent to dvec4.yxxzy).
        /// </summary>
        public dvec5 grrbg => new dvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.yxxzz swizzling.
        /// </summary>
        public dvec5 yxxzz => new dvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.grrbb swizzling (equivalent to dvec4.yxxzz).
        /// </summary>
        public dvec5 grrbb => new dvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.yxxzw swizzling.
        /// </summary>
        public dvec5 yxxzw => new dvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.grrba swizzling (equivalent to dvec4.yxxzw).
        /// </summary>
        public dvec5 grrba => new dvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.yxxw swizzling.
        /// </summary>
        public dvec4 yxxw => new dvec4(y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.grra swizzling (equivalent to dvec4.yxxw).
        /// </summary>
        public dvec4 grra => new dvec4(y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.yxxwx swizzling.
        /// </summary>
        public dvec5 yxxwx => new dvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.grrar swizzling (equivalent to dvec4.yxxwx).
        /// </summary>
        public dvec5 grrar => new dvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.yxxwy swizzling.
        /// </summary>
        public dvec5 yxxwy => new dvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.grrag swizzling (equivalent to dvec4.yxxwy).
        /// </summary>
        public dvec5 grrag => new dvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.yxxwz swizzling.
        /// </summary>
        public dvec5 yxxwz => new dvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.grrab swizzling (equivalent to dvec4.yxxwz).
        /// </summary>
        public dvec5 grrab => new dvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.yxxww swizzling.
        /// </summary>
        public dvec5 yxxww => new dvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.grraa swizzling (equivalent to dvec4.yxxww).
        /// </summary>
        public dvec5 grraa => new dvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.yxy swizzling.
        /// </summary>
        public dvec3 yxy => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec4.grg swizzling (equivalent to dvec4.yxy).
        /// </summary>
        public dvec3 grg => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec4.yxyx swizzling.
        /// </summary>
        public dvec4 yxyx => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.grgr swizzling (equivalent to dvec4.yxyx).
        /// </summary>
        public dvec4 grgr => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.yxyxx swizzling.
        /// </summary>
        public dvec5 yxyxx => new dvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.grgrr swizzling (equivalent to dvec4.yxyxx).
        /// </summary>
        public dvec5 grgrr => new dvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.yxyxy swizzling.
        /// </summary>
        public dvec5 yxyxy => new dvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.grgrg swizzling (equivalent to dvec4.yxyxy).
        /// </summary>
        public dvec5 grgrg => new dvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.yxyxz swizzling.
        /// </summary>
        public dvec5 yxyxz => new dvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.grgrb swizzling (equivalent to dvec4.yxyxz).
        /// </summary>
        public dvec5 grgrb => new dvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.yxyxw swizzling.
        /// </summary>
        public dvec5 yxyxw => new dvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.grgra swizzling (equivalent to dvec4.yxyxw).
        /// </summary>
        public dvec5 grgra => new dvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.yxyy swizzling.
        /// </summary>
        public dvec4 yxyy => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.grgg swizzling (equivalent to dvec4.yxyy).
        /// </summary>
        public dvec4 grgg => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.yxyyx swizzling.
        /// </summary>
        public dvec5 yxyyx => new dvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.grggr swizzling (equivalent to dvec4.yxyyx).
        /// </summary>
        public dvec5 grggr => new dvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.yxyyy swizzling.
        /// </summary>
        public dvec5 yxyyy => new dvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.grggg swizzling (equivalent to dvec4.yxyyy).
        /// </summary>
        public dvec5 grggg => new dvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.yxyyz swizzling.
        /// </summary>
        public dvec5 yxyyz => new dvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.grggb swizzling (equivalent to dvec4.yxyyz).
        /// </summary>
        public dvec5 grggb => new dvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.yxyyw swizzling.
        /// </summary>
        public dvec5 yxyyw => new dvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.grgga swizzling (equivalent to dvec4.yxyyw).
        /// </summary>
        public dvec5 grgga => new dvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.yxyz swizzling.
        /// </summary>
        public dvec4 yxyz => new dvec4(y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.grgb swizzling (equivalent to dvec4.yxyz).
        /// </summary>
        public dvec4 grgb => new dvec4(y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.yxyzx swizzling.
        /// </summary>
        public dvec5 yxyzx => new dvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.grgbr swizzling (equivalent to dvec4.yxyzx).
        /// </summary>
        public dvec5 grgbr => new dvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.yxyzy swizzling.
        /// </summary>
        public dvec5 yxyzy => new dvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.grgbg swizzling (equivalent to dvec4.yxyzy).
        /// </summary>
        public dvec5 grgbg => new dvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.yxyzz swizzling.
        /// </summary>
        public dvec5 yxyzz => new dvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.grgbb swizzling (equivalent to dvec4.yxyzz).
        /// </summary>
        public dvec5 grgbb => new dvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.yxyzw swizzling.
        /// </summary>
        public dvec5 yxyzw => new dvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.grgba swizzling (equivalent to dvec4.yxyzw).
        /// </summary>
        public dvec5 grgba => new dvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.yxyw swizzling.
        /// </summary>
        public dvec4 yxyw => new dvec4(y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.grga swizzling (equivalent to dvec4.yxyw).
        /// </summary>
        public dvec4 grga => new dvec4(y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.yxywx swizzling.
        /// </summary>
        public dvec5 yxywx => new dvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.grgar swizzling (equivalent to dvec4.yxywx).
        /// </summary>
        public dvec5 grgar => new dvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.yxywy swizzling.
        /// </summary>
        public dvec5 yxywy => new dvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.grgag swizzling (equivalent to dvec4.yxywy).
        /// </summary>
        public dvec5 grgag => new dvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.yxywz swizzling.
        /// </summary>
        public dvec5 yxywz => new dvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.grgab swizzling (equivalent to dvec4.yxywz).
        /// </summary>
        public dvec5 grgab => new dvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.yxyww swizzling.
        /// </summary>
        public dvec5 yxyww => new dvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.grgaa swizzling (equivalent to dvec4.yxyww).
        /// </summary>
        public dvec5 grgaa => new dvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.yxz swizzling.
        /// </summary>
        public dvec3 yxz => new dvec3(y, x, z);
        
        /// <summary>
        /// Returns dvec4.grb swizzling (equivalent to dvec4.yxz).
        /// </summary>
        public dvec3 grb => new dvec3(y, x, z);
        
        /// <summary>
        /// Returns dvec4.yxzx swizzling.
        /// </summary>
        public dvec4 yxzx => new dvec4(y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.grbr swizzling (equivalent to dvec4.yxzx).
        /// </summary>
        public dvec4 grbr => new dvec4(y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.yxzxx swizzling.
        /// </summary>
        public dvec5 yxzxx => new dvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.grbrr swizzling (equivalent to dvec4.yxzxx).
        /// </summary>
        public dvec5 grbrr => new dvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.yxzxy swizzling.
        /// </summary>
        public dvec5 yxzxy => new dvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.grbrg swizzling (equivalent to dvec4.yxzxy).
        /// </summary>
        public dvec5 grbrg => new dvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.yxzxz swizzling.
        /// </summary>
        public dvec5 yxzxz => new dvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.grbrb swizzling (equivalent to dvec4.yxzxz).
        /// </summary>
        public dvec5 grbrb => new dvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.yxzxw swizzling.
        /// </summary>
        public dvec5 yxzxw => new dvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.grbra swizzling (equivalent to dvec4.yxzxw).
        /// </summary>
        public dvec5 grbra => new dvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.yxzy swizzling.
        /// </summary>
        public dvec4 yxzy => new dvec4(y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.grbg swizzling (equivalent to dvec4.yxzy).
        /// </summary>
        public dvec4 grbg => new dvec4(y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.yxzyx swizzling.
        /// </summary>
        public dvec5 yxzyx => new dvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.grbgr swizzling (equivalent to dvec4.yxzyx).
        /// </summary>
        public dvec5 grbgr => new dvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.yxzyy swizzling.
        /// </summary>
        public dvec5 yxzyy => new dvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.grbgg swizzling (equivalent to dvec4.yxzyy).
        /// </summary>
        public dvec5 grbgg => new dvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.yxzyz swizzling.
        /// </summary>
        public dvec5 yxzyz => new dvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.grbgb swizzling (equivalent to dvec4.yxzyz).
        /// </summary>
        public dvec5 grbgb => new dvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.yxzyw swizzling.
        /// </summary>
        public dvec5 yxzyw => new dvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.grbga swizzling (equivalent to dvec4.yxzyw).
        /// </summary>
        public dvec5 grbga => new dvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.yxzz swizzling.
        /// </summary>
        public dvec4 yxzz => new dvec4(y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.grbb swizzling (equivalent to dvec4.yxzz).
        /// </summary>
        public dvec4 grbb => new dvec4(y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.yxzzx swizzling.
        /// </summary>
        public dvec5 yxzzx => new dvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.grbbr swizzling (equivalent to dvec4.yxzzx).
        /// </summary>
        public dvec5 grbbr => new dvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.yxzzy swizzling.
        /// </summary>
        public dvec5 yxzzy => new dvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.grbbg swizzling (equivalent to dvec4.yxzzy).
        /// </summary>
        public dvec5 grbbg => new dvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.yxzzz swizzling.
        /// </summary>
        public dvec5 yxzzz => new dvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.grbbb swizzling (equivalent to dvec4.yxzzz).
        /// </summary>
        public dvec5 grbbb => new dvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.yxzzw swizzling.
        /// </summary>
        public dvec5 yxzzw => new dvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.grbba swizzling (equivalent to dvec4.yxzzw).
        /// </summary>
        public dvec5 grbba => new dvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.yxzw swizzling.
        /// </summary>
        public dvec4 yxzw => new dvec4(y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.grba swizzling (equivalent to dvec4.yxzw).
        /// </summary>
        public dvec4 grba => new dvec4(y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.yxzwx swizzling.
        /// </summary>
        public dvec5 yxzwx => new dvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.grbar swizzling (equivalent to dvec4.yxzwx).
        /// </summary>
        public dvec5 grbar => new dvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.yxzwy swizzling.
        /// </summary>
        public dvec5 yxzwy => new dvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.grbag swizzling (equivalent to dvec4.yxzwy).
        /// </summary>
        public dvec5 grbag => new dvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.yxzwz swizzling.
        /// </summary>
        public dvec5 yxzwz => new dvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.grbab swizzling (equivalent to dvec4.yxzwz).
        /// </summary>
        public dvec5 grbab => new dvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.yxzww swizzling.
        /// </summary>
        public dvec5 yxzww => new dvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.grbaa swizzling (equivalent to dvec4.yxzww).
        /// </summary>
        public dvec5 grbaa => new dvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.yxw swizzling.
        /// </summary>
        public dvec3 yxw => new dvec3(y, x, w);
        
        /// <summary>
        /// Returns dvec4.gra swizzling (equivalent to dvec4.yxw).
        /// </summary>
        public dvec3 gra => new dvec3(y, x, w);
        
        /// <summary>
        /// Returns dvec4.yxwx swizzling.
        /// </summary>
        public dvec4 yxwx => new dvec4(y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.grar swizzling (equivalent to dvec4.yxwx).
        /// </summary>
        public dvec4 grar => new dvec4(y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.yxwxx swizzling.
        /// </summary>
        public dvec5 yxwxx => new dvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.grarr swizzling (equivalent to dvec4.yxwxx).
        /// </summary>
        public dvec5 grarr => new dvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.yxwxy swizzling.
        /// </summary>
        public dvec5 yxwxy => new dvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.grarg swizzling (equivalent to dvec4.yxwxy).
        /// </summary>
        public dvec5 grarg => new dvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.yxwxz swizzling.
        /// </summary>
        public dvec5 yxwxz => new dvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.grarb swizzling (equivalent to dvec4.yxwxz).
        /// </summary>
        public dvec5 grarb => new dvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.yxwxw swizzling.
        /// </summary>
        public dvec5 yxwxw => new dvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.grara swizzling (equivalent to dvec4.yxwxw).
        /// </summary>
        public dvec5 grara => new dvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.yxwy swizzling.
        /// </summary>
        public dvec4 yxwy => new dvec4(y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.grag swizzling (equivalent to dvec4.yxwy).
        /// </summary>
        public dvec4 grag => new dvec4(y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.yxwyx swizzling.
        /// </summary>
        public dvec5 yxwyx => new dvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.gragr swizzling (equivalent to dvec4.yxwyx).
        /// </summary>
        public dvec5 gragr => new dvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.yxwyy swizzling.
        /// </summary>
        public dvec5 yxwyy => new dvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.gragg swizzling (equivalent to dvec4.yxwyy).
        /// </summary>
        public dvec5 gragg => new dvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.yxwyz swizzling.
        /// </summary>
        public dvec5 yxwyz => new dvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.gragb swizzling (equivalent to dvec4.yxwyz).
        /// </summary>
        public dvec5 gragb => new dvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.yxwyw swizzling.
        /// </summary>
        public dvec5 yxwyw => new dvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.graga swizzling (equivalent to dvec4.yxwyw).
        /// </summary>
        public dvec5 graga => new dvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.yxwz swizzling.
        /// </summary>
        public dvec4 yxwz => new dvec4(y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.grab swizzling (equivalent to dvec4.yxwz).
        /// </summary>
        public dvec4 grab => new dvec4(y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.yxwzx swizzling.
        /// </summary>
        public dvec5 yxwzx => new dvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.grabr swizzling (equivalent to dvec4.yxwzx).
        /// </summary>
        public dvec5 grabr => new dvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.yxwzy swizzling.
        /// </summary>
        public dvec5 yxwzy => new dvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.grabg swizzling (equivalent to dvec4.yxwzy).
        /// </summary>
        public dvec5 grabg => new dvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.yxwzz swizzling.
        /// </summary>
        public dvec5 yxwzz => new dvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.grabb swizzling (equivalent to dvec4.yxwzz).
        /// </summary>
        public dvec5 grabb => new dvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.yxwzw swizzling.
        /// </summary>
        public dvec5 yxwzw => new dvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.graba swizzling (equivalent to dvec4.yxwzw).
        /// </summary>
        public dvec5 graba => new dvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.yxww swizzling.
        /// </summary>
        public dvec4 yxww => new dvec4(y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.graa swizzling (equivalent to dvec4.yxww).
        /// </summary>
        public dvec4 graa => new dvec4(y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.yxwwx swizzling.
        /// </summary>
        public dvec5 yxwwx => new dvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.graar swizzling (equivalent to dvec4.yxwwx).
        /// </summary>
        public dvec5 graar => new dvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.yxwwy swizzling.
        /// </summary>
        public dvec5 yxwwy => new dvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.graag swizzling (equivalent to dvec4.yxwwy).
        /// </summary>
        public dvec5 graag => new dvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.yxwwz swizzling.
        /// </summary>
        public dvec5 yxwwz => new dvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.graab swizzling (equivalent to dvec4.yxwwz).
        /// </summary>
        public dvec5 graab => new dvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.yxwww swizzling.
        /// </summary>
        public dvec5 yxwww => new dvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.graaa swizzling (equivalent to dvec4.yxwww).
        /// </summary>
        public dvec5 graaa => new dvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.yy swizzling.
        /// </summary>
        public dvec2 yy => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec4.gg swizzling (equivalent to dvec4.yy).
        /// </summary>
        public dvec2 gg => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec4.yyx swizzling.
        /// </summary>
        public dvec3 yyx => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec4.ggr swizzling (equivalent to dvec4.yyx).
        /// </summary>
        public dvec3 ggr => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec4.yyxx swizzling.
        /// </summary>
        public dvec4 yyxx => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.ggrr swizzling (equivalent to dvec4.yyxx).
        /// </summary>
        public dvec4 ggrr => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.yyxxx swizzling.
        /// </summary>
        public dvec5 yyxxx => new dvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.ggrrr swizzling (equivalent to dvec4.yyxxx).
        /// </summary>
        public dvec5 ggrrr => new dvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.yyxxy swizzling.
        /// </summary>
        public dvec5 yyxxy => new dvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.ggrrg swizzling (equivalent to dvec4.yyxxy).
        /// </summary>
        public dvec5 ggrrg => new dvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.yyxxz swizzling.
        /// </summary>
        public dvec5 yyxxz => new dvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.ggrrb swizzling (equivalent to dvec4.yyxxz).
        /// </summary>
        public dvec5 ggrrb => new dvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.yyxxw swizzling.
        /// </summary>
        public dvec5 yyxxw => new dvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.ggrra swizzling (equivalent to dvec4.yyxxw).
        /// </summary>
        public dvec5 ggrra => new dvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.yyxy swizzling.
        /// </summary>
        public dvec4 yyxy => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.ggrg swizzling (equivalent to dvec4.yyxy).
        /// </summary>
        public dvec4 ggrg => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.yyxyx swizzling.
        /// </summary>
        public dvec5 yyxyx => new dvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.ggrgr swizzling (equivalent to dvec4.yyxyx).
        /// </summary>
        public dvec5 ggrgr => new dvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.yyxyy swizzling.
        /// </summary>
        public dvec5 yyxyy => new dvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.ggrgg swizzling (equivalent to dvec4.yyxyy).
        /// </summary>
        public dvec5 ggrgg => new dvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.yyxyz swizzling.
        /// </summary>
        public dvec5 yyxyz => new dvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.ggrgb swizzling (equivalent to dvec4.yyxyz).
        /// </summary>
        public dvec5 ggrgb => new dvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.yyxyw swizzling.
        /// </summary>
        public dvec5 yyxyw => new dvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.ggrga swizzling (equivalent to dvec4.yyxyw).
        /// </summary>
        public dvec5 ggrga => new dvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.yyxz swizzling.
        /// </summary>
        public dvec4 yyxz => new dvec4(y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.ggrb swizzling (equivalent to dvec4.yyxz).
        /// </summary>
        public dvec4 ggrb => new dvec4(y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.yyxzx swizzling.
        /// </summary>
        public dvec5 yyxzx => new dvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.ggrbr swizzling (equivalent to dvec4.yyxzx).
        /// </summary>
        public dvec5 ggrbr => new dvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.yyxzy swizzling.
        /// </summary>
        public dvec5 yyxzy => new dvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.ggrbg swizzling (equivalent to dvec4.yyxzy).
        /// </summary>
        public dvec5 ggrbg => new dvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.yyxzz swizzling.
        /// </summary>
        public dvec5 yyxzz => new dvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.ggrbb swizzling (equivalent to dvec4.yyxzz).
        /// </summary>
        public dvec5 ggrbb => new dvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.yyxzw swizzling.
        /// </summary>
        public dvec5 yyxzw => new dvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.ggrba swizzling (equivalent to dvec4.yyxzw).
        /// </summary>
        public dvec5 ggrba => new dvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.yyxw swizzling.
        /// </summary>
        public dvec4 yyxw => new dvec4(y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.ggra swizzling (equivalent to dvec4.yyxw).
        /// </summary>
        public dvec4 ggra => new dvec4(y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.yyxwx swizzling.
        /// </summary>
        public dvec5 yyxwx => new dvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.ggrar swizzling (equivalent to dvec4.yyxwx).
        /// </summary>
        public dvec5 ggrar => new dvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.yyxwy swizzling.
        /// </summary>
        public dvec5 yyxwy => new dvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.ggrag swizzling (equivalent to dvec4.yyxwy).
        /// </summary>
        public dvec5 ggrag => new dvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.yyxwz swizzling.
        /// </summary>
        public dvec5 yyxwz => new dvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.ggrab swizzling (equivalent to dvec4.yyxwz).
        /// </summary>
        public dvec5 ggrab => new dvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.yyxww swizzling.
        /// </summary>
        public dvec5 yyxww => new dvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.ggraa swizzling (equivalent to dvec4.yyxww).
        /// </summary>
        public dvec5 ggraa => new dvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.yyy swizzling.
        /// </summary>
        public dvec3 yyy => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec4.ggg swizzling (equivalent to dvec4.yyy).
        /// </summary>
        public dvec3 ggg => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec4.yyyx swizzling.
        /// </summary>
        public dvec4 yyyx => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.gggr swizzling (equivalent to dvec4.yyyx).
        /// </summary>
        public dvec4 gggr => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.yyyxx swizzling.
        /// </summary>
        public dvec5 yyyxx => new dvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.gggrr swizzling (equivalent to dvec4.yyyxx).
        /// </summary>
        public dvec5 gggrr => new dvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.yyyxy swizzling.
        /// </summary>
        public dvec5 yyyxy => new dvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.gggrg swizzling (equivalent to dvec4.yyyxy).
        /// </summary>
        public dvec5 gggrg => new dvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.yyyxz swizzling.
        /// </summary>
        public dvec5 yyyxz => new dvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.gggrb swizzling (equivalent to dvec4.yyyxz).
        /// </summary>
        public dvec5 gggrb => new dvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.yyyxw swizzling.
        /// </summary>
        public dvec5 yyyxw => new dvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.gggra swizzling (equivalent to dvec4.yyyxw).
        /// </summary>
        public dvec5 gggra => new dvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.yyyy swizzling.
        /// </summary>
        public dvec4 yyyy => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.gggg swizzling (equivalent to dvec4.yyyy).
        /// </summary>
        public dvec4 gggg => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.yyyyx swizzling.
        /// </summary>
        public dvec5 yyyyx => new dvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.ggggr swizzling (equivalent to dvec4.yyyyx).
        /// </summary>
        public dvec5 ggggr => new dvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.yyyyy swizzling.
        /// </summary>
        public dvec5 yyyyy => new dvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.ggggg swizzling (equivalent to dvec4.yyyyy).
        /// </summary>
        public dvec5 ggggg => new dvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.yyyyz swizzling.
        /// </summary>
        public dvec5 yyyyz => new dvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.ggggb swizzling (equivalent to dvec4.yyyyz).
        /// </summary>
        public dvec5 ggggb => new dvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.yyyyw swizzling.
        /// </summary>
        public dvec5 yyyyw => new dvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.gggga swizzling (equivalent to dvec4.yyyyw).
        /// </summary>
        public dvec5 gggga => new dvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.yyyz swizzling.
        /// </summary>
        public dvec4 yyyz => new dvec4(y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.gggb swizzling (equivalent to dvec4.yyyz).
        /// </summary>
        public dvec4 gggb => new dvec4(y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.yyyzx swizzling.
        /// </summary>
        public dvec5 yyyzx => new dvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.gggbr swizzling (equivalent to dvec4.yyyzx).
        /// </summary>
        public dvec5 gggbr => new dvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.yyyzy swizzling.
        /// </summary>
        public dvec5 yyyzy => new dvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.gggbg swizzling (equivalent to dvec4.yyyzy).
        /// </summary>
        public dvec5 gggbg => new dvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.yyyzz swizzling.
        /// </summary>
        public dvec5 yyyzz => new dvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.gggbb swizzling (equivalent to dvec4.yyyzz).
        /// </summary>
        public dvec5 gggbb => new dvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.yyyzw swizzling.
        /// </summary>
        public dvec5 yyyzw => new dvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.gggba swizzling (equivalent to dvec4.yyyzw).
        /// </summary>
        public dvec5 gggba => new dvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.yyyw swizzling.
        /// </summary>
        public dvec4 yyyw => new dvec4(y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.ggga swizzling (equivalent to dvec4.yyyw).
        /// </summary>
        public dvec4 ggga => new dvec4(y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.yyywx swizzling.
        /// </summary>
        public dvec5 yyywx => new dvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.gggar swizzling (equivalent to dvec4.yyywx).
        /// </summary>
        public dvec5 gggar => new dvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.yyywy swizzling.
        /// </summary>
        public dvec5 yyywy => new dvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.gggag swizzling (equivalent to dvec4.yyywy).
        /// </summary>
        public dvec5 gggag => new dvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.yyywz swizzling.
        /// </summary>
        public dvec5 yyywz => new dvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.gggab swizzling (equivalent to dvec4.yyywz).
        /// </summary>
        public dvec5 gggab => new dvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.yyyww swizzling.
        /// </summary>
        public dvec5 yyyww => new dvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.gggaa swizzling (equivalent to dvec4.yyyww).
        /// </summary>
        public dvec5 gggaa => new dvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.yyz swizzling.
        /// </summary>
        public dvec3 yyz => new dvec3(y, y, z);
        
        /// <summary>
        /// Returns dvec4.ggb swizzling (equivalent to dvec4.yyz).
        /// </summary>
        public dvec3 ggb => new dvec3(y, y, z);
        
        /// <summary>
        /// Returns dvec4.yyzx swizzling.
        /// </summary>
        public dvec4 yyzx => new dvec4(y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.ggbr swizzling (equivalent to dvec4.yyzx).
        /// </summary>
        public dvec4 ggbr => new dvec4(y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.yyzxx swizzling.
        /// </summary>
        public dvec5 yyzxx => new dvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.ggbrr swizzling (equivalent to dvec4.yyzxx).
        /// </summary>
        public dvec5 ggbrr => new dvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.yyzxy swizzling.
        /// </summary>
        public dvec5 yyzxy => new dvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.ggbrg swizzling (equivalent to dvec4.yyzxy).
        /// </summary>
        public dvec5 ggbrg => new dvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.yyzxz swizzling.
        /// </summary>
        public dvec5 yyzxz => new dvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.ggbrb swizzling (equivalent to dvec4.yyzxz).
        /// </summary>
        public dvec5 ggbrb => new dvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.yyzxw swizzling.
        /// </summary>
        public dvec5 yyzxw => new dvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.ggbra swizzling (equivalent to dvec4.yyzxw).
        /// </summary>
        public dvec5 ggbra => new dvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.yyzy swizzling.
        /// </summary>
        public dvec4 yyzy => new dvec4(y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.ggbg swizzling (equivalent to dvec4.yyzy).
        /// </summary>
        public dvec4 ggbg => new dvec4(y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.yyzyx swizzling.
        /// </summary>
        public dvec5 yyzyx => new dvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.ggbgr swizzling (equivalent to dvec4.yyzyx).
        /// </summary>
        public dvec5 ggbgr => new dvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.yyzyy swizzling.
        /// </summary>
        public dvec5 yyzyy => new dvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.ggbgg swizzling (equivalent to dvec4.yyzyy).
        /// </summary>
        public dvec5 ggbgg => new dvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.yyzyz swizzling.
        /// </summary>
        public dvec5 yyzyz => new dvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.ggbgb swizzling (equivalent to dvec4.yyzyz).
        /// </summary>
        public dvec5 ggbgb => new dvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.yyzyw swizzling.
        /// </summary>
        public dvec5 yyzyw => new dvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.ggbga swizzling (equivalent to dvec4.yyzyw).
        /// </summary>
        public dvec5 ggbga => new dvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.yyzz swizzling.
        /// </summary>
        public dvec4 yyzz => new dvec4(y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.ggbb swizzling (equivalent to dvec4.yyzz).
        /// </summary>
        public dvec4 ggbb => new dvec4(y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.yyzzx swizzling.
        /// </summary>
        public dvec5 yyzzx => new dvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.ggbbr swizzling (equivalent to dvec4.yyzzx).
        /// </summary>
        public dvec5 ggbbr => new dvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.yyzzy swizzling.
        /// </summary>
        public dvec5 yyzzy => new dvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.ggbbg swizzling (equivalent to dvec4.yyzzy).
        /// </summary>
        public dvec5 ggbbg => new dvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.yyzzz swizzling.
        /// </summary>
        public dvec5 yyzzz => new dvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.ggbbb swizzling (equivalent to dvec4.yyzzz).
        /// </summary>
        public dvec5 ggbbb => new dvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.yyzzw swizzling.
        /// </summary>
        public dvec5 yyzzw => new dvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.ggbba swizzling (equivalent to dvec4.yyzzw).
        /// </summary>
        public dvec5 ggbba => new dvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.yyzw swizzling.
        /// </summary>
        public dvec4 yyzw => new dvec4(y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.ggba swizzling (equivalent to dvec4.yyzw).
        /// </summary>
        public dvec4 ggba => new dvec4(y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.yyzwx swizzling.
        /// </summary>
        public dvec5 yyzwx => new dvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.ggbar swizzling (equivalent to dvec4.yyzwx).
        /// </summary>
        public dvec5 ggbar => new dvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.yyzwy swizzling.
        /// </summary>
        public dvec5 yyzwy => new dvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.ggbag swizzling (equivalent to dvec4.yyzwy).
        /// </summary>
        public dvec5 ggbag => new dvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.yyzwz swizzling.
        /// </summary>
        public dvec5 yyzwz => new dvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.ggbab swizzling (equivalent to dvec4.yyzwz).
        /// </summary>
        public dvec5 ggbab => new dvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.yyzww swizzling.
        /// </summary>
        public dvec5 yyzww => new dvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.ggbaa swizzling (equivalent to dvec4.yyzww).
        /// </summary>
        public dvec5 ggbaa => new dvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.yyw swizzling.
        /// </summary>
        public dvec3 yyw => new dvec3(y, y, w);
        
        /// <summary>
        /// Returns dvec4.gga swizzling (equivalent to dvec4.yyw).
        /// </summary>
        public dvec3 gga => new dvec3(y, y, w);
        
        /// <summary>
        /// Returns dvec4.yywx swizzling.
        /// </summary>
        public dvec4 yywx => new dvec4(y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.ggar swizzling (equivalent to dvec4.yywx).
        /// </summary>
        public dvec4 ggar => new dvec4(y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.yywxx swizzling.
        /// </summary>
        public dvec5 yywxx => new dvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.ggarr swizzling (equivalent to dvec4.yywxx).
        /// </summary>
        public dvec5 ggarr => new dvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.yywxy swizzling.
        /// </summary>
        public dvec5 yywxy => new dvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.ggarg swizzling (equivalent to dvec4.yywxy).
        /// </summary>
        public dvec5 ggarg => new dvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.yywxz swizzling.
        /// </summary>
        public dvec5 yywxz => new dvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.ggarb swizzling (equivalent to dvec4.yywxz).
        /// </summary>
        public dvec5 ggarb => new dvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.yywxw swizzling.
        /// </summary>
        public dvec5 yywxw => new dvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.ggara swizzling (equivalent to dvec4.yywxw).
        /// </summary>
        public dvec5 ggara => new dvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.yywy swizzling.
        /// </summary>
        public dvec4 yywy => new dvec4(y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.ggag swizzling (equivalent to dvec4.yywy).
        /// </summary>
        public dvec4 ggag => new dvec4(y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.yywyx swizzling.
        /// </summary>
        public dvec5 yywyx => new dvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.ggagr swizzling (equivalent to dvec4.yywyx).
        /// </summary>
        public dvec5 ggagr => new dvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.yywyy swizzling.
        /// </summary>
        public dvec5 yywyy => new dvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.ggagg swizzling (equivalent to dvec4.yywyy).
        /// </summary>
        public dvec5 ggagg => new dvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.yywyz swizzling.
        /// </summary>
        public dvec5 yywyz => new dvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.ggagb swizzling (equivalent to dvec4.yywyz).
        /// </summary>
        public dvec5 ggagb => new dvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.yywyw swizzling.
        /// </summary>
        public dvec5 yywyw => new dvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.ggaga swizzling (equivalent to dvec4.yywyw).
        /// </summary>
        public dvec5 ggaga => new dvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.yywz swizzling.
        /// </summary>
        public dvec4 yywz => new dvec4(y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.ggab swizzling (equivalent to dvec4.yywz).
        /// </summary>
        public dvec4 ggab => new dvec4(y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.yywzx swizzling.
        /// </summary>
        public dvec5 yywzx => new dvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.ggabr swizzling (equivalent to dvec4.yywzx).
        /// </summary>
        public dvec5 ggabr => new dvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.yywzy swizzling.
        /// </summary>
        public dvec5 yywzy => new dvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.ggabg swizzling (equivalent to dvec4.yywzy).
        /// </summary>
        public dvec5 ggabg => new dvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.yywzz swizzling.
        /// </summary>
        public dvec5 yywzz => new dvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.ggabb swizzling (equivalent to dvec4.yywzz).
        /// </summary>
        public dvec5 ggabb => new dvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.yywzw swizzling.
        /// </summary>
        public dvec5 yywzw => new dvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.ggaba swizzling (equivalent to dvec4.yywzw).
        /// </summary>
        public dvec5 ggaba => new dvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.yyww swizzling.
        /// </summary>
        public dvec4 yyww => new dvec4(y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.ggaa swizzling (equivalent to dvec4.yyww).
        /// </summary>
        public dvec4 ggaa => new dvec4(y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.yywwx swizzling.
        /// </summary>
        public dvec5 yywwx => new dvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.ggaar swizzling (equivalent to dvec4.yywwx).
        /// </summary>
        public dvec5 ggaar => new dvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.yywwy swizzling.
        /// </summary>
        public dvec5 yywwy => new dvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.ggaag swizzling (equivalent to dvec4.yywwy).
        /// </summary>
        public dvec5 ggaag => new dvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.yywwz swizzling.
        /// </summary>
        public dvec5 yywwz => new dvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.ggaab swizzling (equivalent to dvec4.yywwz).
        /// </summary>
        public dvec5 ggaab => new dvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.yywww swizzling.
        /// </summary>
        public dvec5 yywww => new dvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.ggaaa swizzling (equivalent to dvec4.yywww).
        /// </summary>
        public dvec5 ggaaa => new dvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.yz swizzling.
        /// </summary>
        public dvec2 yz => new dvec2(y, z);
        
        /// <summary>
        /// Returns dvec4.gb swizzling (equivalent to dvec4.yz).
        /// </summary>
        public dvec2 gb => new dvec2(y, z);
        
        /// <summary>
        /// Returns dvec4.yzx swizzling.
        /// </summary>
        public dvec3 yzx => new dvec3(y, z, x);
        
        /// <summary>
        /// Returns dvec4.gbr swizzling (equivalent to dvec4.yzx).
        /// </summary>
        public dvec3 gbr => new dvec3(y, z, x);
        
        /// <summary>
        /// Returns dvec4.yzxx swizzling.
        /// </summary>
        public dvec4 yzxx => new dvec4(y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.gbrr swizzling (equivalent to dvec4.yzxx).
        /// </summary>
        public dvec4 gbrr => new dvec4(y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.yzxxx swizzling.
        /// </summary>
        public dvec5 yzxxx => new dvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.gbrrr swizzling (equivalent to dvec4.yzxxx).
        /// </summary>
        public dvec5 gbrrr => new dvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.yzxxy swizzling.
        /// </summary>
        public dvec5 yzxxy => new dvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.gbrrg swizzling (equivalent to dvec4.yzxxy).
        /// </summary>
        public dvec5 gbrrg => new dvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.yzxxz swizzling.
        /// </summary>
        public dvec5 yzxxz => new dvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.gbrrb swizzling (equivalent to dvec4.yzxxz).
        /// </summary>
        public dvec5 gbrrb => new dvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.yzxxw swizzling.
        /// </summary>
        public dvec5 yzxxw => new dvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.gbrra swizzling (equivalent to dvec4.yzxxw).
        /// </summary>
        public dvec5 gbrra => new dvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.yzxy swizzling.
        /// </summary>
        public dvec4 yzxy => new dvec4(y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.gbrg swizzling (equivalent to dvec4.yzxy).
        /// </summary>
        public dvec4 gbrg => new dvec4(y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.yzxyx swizzling.
        /// </summary>
        public dvec5 yzxyx => new dvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.gbrgr swizzling (equivalent to dvec4.yzxyx).
        /// </summary>
        public dvec5 gbrgr => new dvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.yzxyy swizzling.
        /// </summary>
        public dvec5 yzxyy => new dvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.gbrgg swizzling (equivalent to dvec4.yzxyy).
        /// </summary>
        public dvec5 gbrgg => new dvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.yzxyz swizzling.
        /// </summary>
        public dvec5 yzxyz => new dvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.gbrgb swizzling (equivalent to dvec4.yzxyz).
        /// </summary>
        public dvec5 gbrgb => new dvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.yzxyw swizzling.
        /// </summary>
        public dvec5 yzxyw => new dvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.gbrga swizzling (equivalent to dvec4.yzxyw).
        /// </summary>
        public dvec5 gbrga => new dvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.yzxz swizzling.
        /// </summary>
        public dvec4 yzxz => new dvec4(y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.gbrb swizzling (equivalent to dvec4.yzxz).
        /// </summary>
        public dvec4 gbrb => new dvec4(y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.yzxzx swizzling.
        /// </summary>
        public dvec5 yzxzx => new dvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.gbrbr swizzling (equivalent to dvec4.yzxzx).
        /// </summary>
        public dvec5 gbrbr => new dvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.yzxzy swizzling.
        /// </summary>
        public dvec5 yzxzy => new dvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.gbrbg swizzling (equivalent to dvec4.yzxzy).
        /// </summary>
        public dvec5 gbrbg => new dvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.yzxzz swizzling.
        /// </summary>
        public dvec5 yzxzz => new dvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.gbrbb swizzling (equivalent to dvec4.yzxzz).
        /// </summary>
        public dvec5 gbrbb => new dvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.yzxzw swizzling.
        /// </summary>
        public dvec5 yzxzw => new dvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.gbrba swizzling (equivalent to dvec4.yzxzw).
        /// </summary>
        public dvec5 gbrba => new dvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.yzxw swizzling.
        /// </summary>
        public dvec4 yzxw => new dvec4(y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.gbra swizzling (equivalent to dvec4.yzxw).
        /// </summary>
        public dvec4 gbra => new dvec4(y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.yzxwx swizzling.
        /// </summary>
        public dvec5 yzxwx => new dvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.gbrar swizzling (equivalent to dvec4.yzxwx).
        /// </summary>
        public dvec5 gbrar => new dvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.yzxwy swizzling.
        /// </summary>
        public dvec5 yzxwy => new dvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.gbrag swizzling (equivalent to dvec4.yzxwy).
        /// </summary>
        public dvec5 gbrag => new dvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.yzxwz swizzling.
        /// </summary>
        public dvec5 yzxwz => new dvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.gbrab swizzling (equivalent to dvec4.yzxwz).
        /// </summary>
        public dvec5 gbrab => new dvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.yzxww swizzling.
        /// </summary>
        public dvec5 yzxww => new dvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.gbraa swizzling (equivalent to dvec4.yzxww).
        /// </summary>
        public dvec5 gbraa => new dvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.yzy swizzling.
        /// </summary>
        public dvec3 yzy => new dvec3(y, z, y);
        
        /// <summary>
        /// Returns dvec4.gbg swizzling (equivalent to dvec4.yzy).
        /// </summary>
        public dvec3 gbg => new dvec3(y, z, y);
        
        /// <summary>
        /// Returns dvec4.yzyx swizzling.
        /// </summary>
        public dvec4 yzyx => new dvec4(y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.gbgr swizzling (equivalent to dvec4.yzyx).
        /// </summary>
        public dvec4 gbgr => new dvec4(y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.yzyxx swizzling.
        /// </summary>
        public dvec5 yzyxx => new dvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.gbgrr swizzling (equivalent to dvec4.yzyxx).
        /// </summary>
        public dvec5 gbgrr => new dvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.yzyxy swizzling.
        /// </summary>
        public dvec5 yzyxy => new dvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.gbgrg swizzling (equivalent to dvec4.yzyxy).
        /// </summary>
        public dvec5 gbgrg => new dvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.yzyxz swizzling.
        /// </summary>
        public dvec5 yzyxz => new dvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.gbgrb swizzling (equivalent to dvec4.yzyxz).
        /// </summary>
        public dvec5 gbgrb => new dvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.yzyxw swizzling.
        /// </summary>
        public dvec5 yzyxw => new dvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.gbgra swizzling (equivalent to dvec4.yzyxw).
        /// </summary>
        public dvec5 gbgra => new dvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.yzyy swizzling.
        /// </summary>
        public dvec4 yzyy => new dvec4(y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.gbgg swizzling (equivalent to dvec4.yzyy).
        /// </summary>
        public dvec4 gbgg => new dvec4(y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.yzyyx swizzling.
        /// </summary>
        public dvec5 yzyyx => new dvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.gbggr swizzling (equivalent to dvec4.yzyyx).
        /// </summary>
        public dvec5 gbggr => new dvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.yzyyy swizzling.
        /// </summary>
        public dvec5 yzyyy => new dvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.gbggg swizzling (equivalent to dvec4.yzyyy).
        /// </summary>
        public dvec5 gbggg => new dvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.yzyyz swizzling.
        /// </summary>
        public dvec5 yzyyz => new dvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.gbggb swizzling (equivalent to dvec4.yzyyz).
        /// </summary>
        public dvec5 gbggb => new dvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.yzyyw swizzling.
        /// </summary>
        public dvec5 yzyyw => new dvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.gbgga swizzling (equivalent to dvec4.yzyyw).
        /// </summary>
        public dvec5 gbgga => new dvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.yzyz swizzling.
        /// </summary>
        public dvec4 yzyz => new dvec4(y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.gbgb swizzling (equivalent to dvec4.yzyz).
        /// </summary>
        public dvec4 gbgb => new dvec4(y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.yzyzx swizzling.
        /// </summary>
        public dvec5 yzyzx => new dvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.gbgbr swizzling (equivalent to dvec4.yzyzx).
        /// </summary>
        public dvec5 gbgbr => new dvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.yzyzy swizzling.
        /// </summary>
        public dvec5 yzyzy => new dvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.gbgbg swizzling (equivalent to dvec4.yzyzy).
        /// </summary>
        public dvec5 gbgbg => new dvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.yzyzz swizzling.
        /// </summary>
        public dvec5 yzyzz => new dvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.gbgbb swizzling (equivalent to dvec4.yzyzz).
        /// </summary>
        public dvec5 gbgbb => new dvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.yzyzw swizzling.
        /// </summary>
        public dvec5 yzyzw => new dvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.gbgba swizzling (equivalent to dvec4.yzyzw).
        /// </summary>
        public dvec5 gbgba => new dvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.yzyw swizzling.
        /// </summary>
        public dvec4 yzyw => new dvec4(y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.gbga swizzling (equivalent to dvec4.yzyw).
        /// </summary>
        public dvec4 gbga => new dvec4(y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.yzywx swizzling.
        /// </summary>
        public dvec5 yzywx => new dvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.gbgar swizzling (equivalent to dvec4.yzywx).
        /// </summary>
        public dvec5 gbgar => new dvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.yzywy swizzling.
        /// </summary>
        public dvec5 yzywy => new dvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.gbgag swizzling (equivalent to dvec4.yzywy).
        /// </summary>
        public dvec5 gbgag => new dvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.yzywz swizzling.
        /// </summary>
        public dvec5 yzywz => new dvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.gbgab swizzling (equivalent to dvec4.yzywz).
        /// </summary>
        public dvec5 gbgab => new dvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.yzyww swizzling.
        /// </summary>
        public dvec5 yzyww => new dvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.gbgaa swizzling (equivalent to dvec4.yzyww).
        /// </summary>
        public dvec5 gbgaa => new dvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.yzz swizzling.
        /// </summary>
        public dvec3 yzz => new dvec3(y, z, z);
        
        /// <summary>
        /// Returns dvec4.gbb swizzling (equivalent to dvec4.yzz).
        /// </summary>
        public dvec3 gbb => new dvec3(y, z, z);
        
        /// <summary>
        /// Returns dvec4.yzzx swizzling.
        /// </summary>
        public dvec4 yzzx => new dvec4(y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.gbbr swizzling (equivalent to dvec4.yzzx).
        /// </summary>
        public dvec4 gbbr => new dvec4(y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.yzzxx swizzling.
        /// </summary>
        public dvec5 yzzxx => new dvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.gbbrr swizzling (equivalent to dvec4.yzzxx).
        /// </summary>
        public dvec5 gbbrr => new dvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.yzzxy swizzling.
        /// </summary>
        public dvec5 yzzxy => new dvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.gbbrg swizzling (equivalent to dvec4.yzzxy).
        /// </summary>
        public dvec5 gbbrg => new dvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.yzzxz swizzling.
        /// </summary>
        public dvec5 yzzxz => new dvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.gbbrb swizzling (equivalent to dvec4.yzzxz).
        /// </summary>
        public dvec5 gbbrb => new dvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.yzzxw swizzling.
        /// </summary>
        public dvec5 yzzxw => new dvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.gbbra swizzling (equivalent to dvec4.yzzxw).
        /// </summary>
        public dvec5 gbbra => new dvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.yzzy swizzling.
        /// </summary>
        public dvec4 yzzy => new dvec4(y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.gbbg swizzling (equivalent to dvec4.yzzy).
        /// </summary>
        public dvec4 gbbg => new dvec4(y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.yzzyx swizzling.
        /// </summary>
        public dvec5 yzzyx => new dvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.gbbgr swizzling (equivalent to dvec4.yzzyx).
        /// </summary>
        public dvec5 gbbgr => new dvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.yzzyy swizzling.
        /// </summary>
        public dvec5 yzzyy => new dvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.gbbgg swizzling (equivalent to dvec4.yzzyy).
        /// </summary>
        public dvec5 gbbgg => new dvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.yzzyz swizzling.
        /// </summary>
        public dvec5 yzzyz => new dvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.gbbgb swizzling (equivalent to dvec4.yzzyz).
        /// </summary>
        public dvec5 gbbgb => new dvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.yzzyw swizzling.
        /// </summary>
        public dvec5 yzzyw => new dvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.gbbga swizzling (equivalent to dvec4.yzzyw).
        /// </summary>
        public dvec5 gbbga => new dvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.yzzz swizzling.
        /// </summary>
        public dvec4 yzzz => new dvec4(y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.gbbb swizzling (equivalent to dvec4.yzzz).
        /// </summary>
        public dvec4 gbbb => new dvec4(y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.yzzzx swizzling.
        /// </summary>
        public dvec5 yzzzx => new dvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.gbbbr swizzling (equivalent to dvec4.yzzzx).
        /// </summary>
        public dvec5 gbbbr => new dvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.yzzzy swizzling.
        /// </summary>
        public dvec5 yzzzy => new dvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.gbbbg swizzling (equivalent to dvec4.yzzzy).
        /// </summary>
        public dvec5 gbbbg => new dvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.yzzzz swizzling.
        /// </summary>
        public dvec5 yzzzz => new dvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.gbbbb swizzling (equivalent to dvec4.yzzzz).
        /// </summary>
        public dvec5 gbbbb => new dvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.yzzzw swizzling.
        /// </summary>
        public dvec5 yzzzw => new dvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.gbbba swizzling (equivalent to dvec4.yzzzw).
        /// </summary>
        public dvec5 gbbba => new dvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.yzzw swizzling.
        /// </summary>
        public dvec4 yzzw => new dvec4(y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.gbba swizzling (equivalent to dvec4.yzzw).
        /// </summary>
        public dvec4 gbba => new dvec4(y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.yzzwx swizzling.
        /// </summary>
        public dvec5 yzzwx => new dvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.gbbar swizzling (equivalent to dvec4.yzzwx).
        /// </summary>
        public dvec5 gbbar => new dvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.yzzwy swizzling.
        /// </summary>
        public dvec5 yzzwy => new dvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.gbbag swizzling (equivalent to dvec4.yzzwy).
        /// </summary>
        public dvec5 gbbag => new dvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.yzzwz swizzling.
        /// </summary>
        public dvec5 yzzwz => new dvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.gbbab swizzling (equivalent to dvec4.yzzwz).
        /// </summary>
        public dvec5 gbbab => new dvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.yzzww swizzling.
        /// </summary>
        public dvec5 yzzww => new dvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.gbbaa swizzling (equivalent to dvec4.yzzww).
        /// </summary>
        public dvec5 gbbaa => new dvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.yzw swizzling.
        /// </summary>
        public dvec3 yzw => new dvec3(y, z, w);
        
        /// <summary>
        /// Returns dvec4.gba swizzling (equivalent to dvec4.yzw).
        /// </summary>
        public dvec3 gba => new dvec3(y, z, w);
        
        /// <summary>
        /// Returns dvec4.yzwx swizzling.
        /// </summary>
        public dvec4 yzwx => new dvec4(y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.gbar swizzling (equivalent to dvec4.yzwx).
        /// </summary>
        public dvec4 gbar => new dvec4(y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.yzwxx swizzling.
        /// </summary>
        public dvec5 yzwxx => new dvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.gbarr swizzling (equivalent to dvec4.yzwxx).
        /// </summary>
        public dvec5 gbarr => new dvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.yzwxy swizzling.
        /// </summary>
        public dvec5 yzwxy => new dvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.gbarg swizzling (equivalent to dvec4.yzwxy).
        /// </summary>
        public dvec5 gbarg => new dvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.yzwxz swizzling.
        /// </summary>
        public dvec5 yzwxz => new dvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.gbarb swizzling (equivalent to dvec4.yzwxz).
        /// </summary>
        public dvec5 gbarb => new dvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.yzwxw swizzling.
        /// </summary>
        public dvec5 yzwxw => new dvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.gbara swizzling (equivalent to dvec4.yzwxw).
        /// </summary>
        public dvec5 gbara => new dvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.yzwy swizzling.
        /// </summary>
        public dvec4 yzwy => new dvec4(y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.gbag swizzling (equivalent to dvec4.yzwy).
        /// </summary>
        public dvec4 gbag => new dvec4(y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.yzwyx swizzling.
        /// </summary>
        public dvec5 yzwyx => new dvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.gbagr swizzling (equivalent to dvec4.yzwyx).
        /// </summary>
        public dvec5 gbagr => new dvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.yzwyy swizzling.
        /// </summary>
        public dvec5 yzwyy => new dvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.gbagg swizzling (equivalent to dvec4.yzwyy).
        /// </summary>
        public dvec5 gbagg => new dvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.yzwyz swizzling.
        /// </summary>
        public dvec5 yzwyz => new dvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.gbagb swizzling (equivalent to dvec4.yzwyz).
        /// </summary>
        public dvec5 gbagb => new dvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.yzwyw swizzling.
        /// </summary>
        public dvec5 yzwyw => new dvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.gbaga swizzling (equivalent to dvec4.yzwyw).
        /// </summary>
        public dvec5 gbaga => new dvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.yzwz swizzling.
        /// </summary>
        public dvec4 yzwz => new dvec4(y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.gbab swizzling (equivalent to dvec4.yzwz).
        /// </summary>
        public dvec4 gbab => new dvec4(y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.yzwzx swizzling.
        /// </summary>
        public dvec5 yzwzx => new dvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.gbabr swizzling (equivalent to dvec4.yzwzx).
        /// </summary>
        public dvec5 gbabr => new dvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.yzwzy swizzling.
        /// </summary>
        public dvec5 yzwzy => new dvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.gbabg swizzling (equivalent to dvec4.yzwzy).
        /// </summary>
        public dvec5 gbabg => new dvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.yzwzz swizzling.
        /// </summary>
        public dvec5 yzwzz => new dvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.gbabb swizzling (equivalent to dvec4.yzwzz).
        /// </summary>
        public dvec5 gbabb => new dvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.yzwzw swizzling.
        /// </summary>
        public dvec5 yzwzw => new dvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.gbaba swizzling (equivalent to dvec4.yzwzw).
        /// </summary>
        public dvec5 gbaba => new dvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.yzww swizzling.
        /// </summary>
        public dvec4 yzww => new dvec4(y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.gbaa swizzling (equivalent to dvec4.yzww).
        /// </summary>
        public dvec4 gbaa => new dvec4(y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.yzwwx swizzling.
        /// </summary>
        public dvec5 yzwwx => new dvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.gbaar swizzling (equivalent to dvec4.yzwwx).
        /// </summary>
        public dvec5 gbaar => new dvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.yzwwy swizzling.
        /// </summary>
        public dvec5 yzwwy => new dvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.gbaag swizzling (equivalent to dvec4.yzwwy).
        /// </summary>
        public dvec5 gbaag => new dvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.yzwwz swizzling.
        /// </summary>
        public dvec5 yzwwz => new dvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.gbaab swizzling (equivalent to dvec4.yzwwz).
        /// </summary>
        public dvec5 gbaab => new dvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.yzwww swizzling.
        /// </summary>
        public dvec5 yzwww => new dvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.gbaaa swizzling (equivalent to dvec4.yzwww).
        /// </summary>
        public dvec5 gbaaa => new dvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.yw swizzling.
        /// </summary>
        public dvec2 yw => new dvec2(y, w);
        
        /// <summary>
        /// Returns dvec4.ga swizzling (equivalent to dvec4.yw).
        /// </summary>
        public dvec2 ga => new dvec2(y, w);
        
        /// <summary>
        /// Returns dvec4.ywx swizzling.
        /// </summary>
        public dvec3 ywx => new dvec3(y, w, x);
        
        /// <summary>
        /// Returns dvec4.gar swizzling (equivalent to dvec4.ywx).
        /// </summary>
        public dvec3 gar => new dvec3(y, w, x);
        
        /// <summary>
        /// Returns dvec4.ywxx swizzling.
        /// </summary>
        public dvec4 ywxx => new dvec4(y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.garr swizzling (equivalent to dvec4.ywxx).
        /// </summary>
        public dvec4 garr => new dvec4(y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.ywxxx swizzling.
        /// </summary>
        public dvec5 ywxxx => new dvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.garrr swizzling (equivalent to dvec4.ywxxx).
        /// </summary>
        public dvec5 garrr => new dvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.ywxxy swizzling.
        /// </summary>
        public dvec5 ywxxy => new dvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.garrg swizzling (equivalent to dvec4.ywxxy).
        /// </summary>
        public dvec5 garrg => new dvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.ywxxz swizzling.
        /// </summary>
        public dvec5 ywxxz => new dvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.garrb swizzling (equivalent to dvec4.ywxxz).
        /// </summary>
        public dvec5 garrb => new dvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.ywxxw swizzling.
        /// </summary>
        public dvec5 ywxxw => new dvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.garra swizzling (equivalent to dvec4.ywxxw).
        /// </summary>
        public dvec5 garra => new dvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.ywxy swizzling.
        /// </summary>
        public dvec4 ywxy => new dvec4(y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.garg swizzling (equivalent to dvec4.ywxy).
        /// </summary>
        public dvec4 garg => new dvec4(y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.ywxyx swizzling.
        /// </summary>
        public dvec5 ywxyx => new dvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.gargr swizzling (equivalent to dvec4.ywxyx).
        /// </summary>
        public dvec5 gargr => new dvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.ywxyy swizzling.
        /// </summary>
        public dvec5 ywxyy => new dvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.gargg swizzling (equivalent to dvec4.ywxyy).
        /// </summary>
        public dvec5 gargg => new dvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.ywxyz swizzling.
        /// </summary>
        public dvec5 ywxyz => new dvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.gargb swizzling (equivalent to dvec4.ywxyz).
        /// </summary>
        public dvec5 gargb => new dvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.ywxyw swizzling.
        /// </summary>
        public dvec5 ywxyw => new dvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.garga swizzling (equivalent to dvec4.ywxyw).
        /// </summary>
        public dvec5 garga => new dvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.ywxz swizzling.
        /// </summary>
        public dvec4 ywxz => new dvec4(y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.garb swizzling (equivalent to dvec4.ywxz).
        /// </summary>
        public dvec4 garb => new dvec4(y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.ywxzx swizzling.
        /// </summary>
        public dvec5 ywxzx => new dvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.garbr swizzling (equivalent to dvec4.ywxzx).
        /// </summary>
        public dvec5 garbr => new dvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.ywxzy swizzling.
        /// </summary>
        public dvec5 ywxzy => new dvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.garbg swizzling (equivalent to dvec4.ywxzy).
        /// </summary>
        public dvec5 garbg => new dvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.ywxzz swizzling.
        /// </summary>
        public dvec5 ywxzz => new dvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.garbb swizzling (equivalent to dvec4.ywxzz).
        /// </summary>
        public dvec5 garbb => new dvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.ywxzw swizzling.
        /// </summary>
        public dvec5 ywxzw => new dvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.garba swizzling (equivalent to dvec4.ywxzw).
        /// </summary>
        public dvec5 garba => new dvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.ywxw swizzling.
        /// </summary>
        public dvec4 ywxw => new dvec4(y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.gara swizzling (equivalent to dvec4.ywxw).
        /// </summary>
        public dvec4 gara => new dvec4(y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.ywxwx swizzling.
        /// </summary>
        public dvec5 ywxwx => new dvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.garar swizzling (equivalent to dvec4.ywxwx).
        /// </summary>
        public dvec5 garar => new dvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.ywxwy swizzling.
        /// </summary>
        public dvec5 ywxwy => new dvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.garag swizzling (equivalent to dvec4.ywxwy).
        /// </summary>
        public dvec5 garag => new dvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.ywxwz swizzling.
        /// </summary>
        public dvec5 ywxwz => new dvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.garab swizzling (equivalent to dvec4.ywxwz).
        /// </summary>
        public dvec5 garab => new dvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.ywxww swizzling.
        /// </summary>
        public dvec5 ywxww => new dvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.garaa swizzling (equivalent to dvec4.ywxww).
        /// </summary>
        public dvec5 garaa => new dvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.ywy swizzling.
        /// </summary>
        public dvec3 ywy => new dvec3(y, w, y);
        
        /// <summary>
        /// Returns dvec4.gag swizzling (equivalent to dvec4.ywy).
        /// </summary>
        public dvec3 gag => new dvec3(y, w, y);
        
        /// <summary>
        /// Returns dvec4.ywyx swizzling.
        /// </summary>
        public dvec4 ywyx => new dvec4(y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.gagr swizzling (equivalent to dvec4.ywyx).
        /// </summary>
        public dvec4 gagr => new dvec4(y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.ywyxx swizzling.
        /// </summary>
        public dvec5 ywyxx => new dvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.gagrr swizzling (equivalent to dvec4.ywyxx).
        /// </summary>
        public dvec5 gagrr => new dvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.ywyxy swizzling.
        /// </summary>
        public dvec5 ywyxy => new dvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.gagrg swizzling (equivalent to dvec4.ywyxy).
        /// </summary>
        public dvec5 gagrg => new dvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.ywyxz swizzling.
        /// </summary>
        public dvec5 ywyxz => new dvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.gagrb swizzling (equivalent to dvec4.ywyxz).
        /// </summary>
        public dvec5 gagrb => new dvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.ywyxw swizzling.
        /// </summary>
        public dvec5 ywyxw => new dvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.gagra swizzling (equivalent to dvec4.ywyxw).
        /// </summary>
        public dvec5 gagra => new dvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.ywyy swizzling.
        /// </summary>
        public dvec4 ywyy => new dvec4(y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.gagg swizzling (equivalent to dvec4.ywyy).
        /// </summary>
        public dvec4 gagg => new dvec4(y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.ywyyx swizzling.
        /// </summary>
        public dvec5 ywyyx => new dvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.gaggr swizzling (equivalent to dvec4.ywyyx).
        /// </summary>
        public dvec5 gaggr => new dvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.ywyyy swizzling.
        /// </summary>
        public dvec5 ywyyy => new dvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.gaggg swizzling (equivalent to dvec4.ywyyy).
        /// </summary>
        public dvec5 gaggg => new dvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.ywyyz swizzling.
        /// </summary>
        public dvec5 ywyyz => new dvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.gaggb swizzling (equivalent to dvec4.ywyyz).
        /// </summary>
        public dvec5 gaggb => new dvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.ywyyw swizzling.
        /// </summary>
        public dvec5 ywyyw => new dvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.gagga swizzling (equivalent to dvec4.ywyyw).
        /// </summary>
        public dvec5 gagga => new dvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.ywyz swizzling.
        /// </summary>
        public dvec4 ywyz => new dvec4(y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.gagb swizzling (equivalent to dvec4.ywyz).
        /// </summary>
        public dvec4 gagb => new dvec4(y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.ywyzx swizzling.
        /// </summary>
        public dvec5 ywyzx => new dvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.gagbr swizzling (equivalent to dvec4.ywyzx).
        /// </summary>
        public dvec5 gagbr => new dvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.ywyzy swizzling.
        /// </summary>
        public dvec5 ywyzy => new dvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.gagbg swizzling (equivalent to dvec4.ywyzy).
        /// </summary>
        public dvec5 gagbg => new dvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.ywyzz swizzling.
        /// </summary>
        public dvec5 ywyzz => new dvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.gagbb swizzling (equivalent to dvec4.ywyzz).
        /// </summary>
        public dvec5 gagbb => new dvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.ywyzw swizzling.
        /// </summary>
        public dvec5 ywyzw => new dvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.gagba swizzling (equivalent to dvec4.ywyzw).
        /// </summary>
        public dvec5 gagba => new dvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.ywyw swizzling.
        /// </summary>
        public dvec4 ywyw => new dvec4(y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.gaga swizzling (equivalent to dvec4.ywyw).
        /// </summary>
        public dvec4 gaga => new dvec4(y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.ywywx swizzling.
        /// </summary>
        public dvec5 ywywx => new dvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.gagar swizzling (equivalent to dvec4.ywywx).
        /// </summary>
        public dvec5 gagar => new dvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.ywywy swizzling.
        /// </summary>
        public dvec5 ywywy => new dvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.gagag swizzling (equivalent to dvec4.ywywy).
        /// </summary>
        public dvec5 gagag => new dvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.ywywz swizzling.
        /// </summary>
        public dvec5 ywywz => new dvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.gagab swizzling (equivalent to dvec4.ywywz).
        /// </summary>
        public dvec5 gagab => new dvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.ywyww swizzling.
        /// </summary>
        public dvec5 ywyww => new dvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.gagaa swizzling (equivalent to dvec4.ywyww).
        /// </summary>
        public dvec5 gagaa => new dvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.ywz swizzling.
        /// </summary>
        public dvec3 ywz => new dvec3(y, w, z);
        
        /// <summary>
        /// Returns dvec4.gab swizzling (equivalent to dvec4.ywz).
        /// </summary>
        public dvec3 gab => new dvec3(y, w, z);
        
        /// <summary>
        /// Returns dvec4.ywzx swizzling.
        /// </summary>
        public dvec4 ywzx => new dvec4(y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.gabr swizzling (equivalent to dvec4.ywzx).
        /// </summary>
        public dvec4 gabr => new dvec4(y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.ywzxx swizzling.
        /// </summary>
        public dvec5 ywzxx => new dvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.gabrr swizzling (equivalent to dvec4.ywzxx).
        /// </summary>
        public dvec5 gabrr => new dvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.ywzxy swizzling.
        /// </summary>
        public dvec5 ywzxy => new dvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.gabrg swizzling (equivalent to dvec4.ywzxy).
        /// </summary>
        public dvec5 gabrg => new dvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.ywzxz swizzling.
        /// </summary>
        public dvec5 ywzxz => new dvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.gabrb swizzling (equivalent to dvec4.ywzxz).
        /// </summary>
        public dvec5 gabrb => new dvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.ywzxw swizzling.
        /// </summary>
        public dvec5 ywzxw => new dvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.gabra swizzling (equivalent to dvec4.ywzxw).
        /// </summary>
        public dvec5 gabra => new dvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.ywzy swizzling.
        /// </summary>
        public dvec4 ywzy => new dvec4(y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.gabg swizzling (equivalent to dvec4.ywzy).
        /// </summary>
        public dvec4 gabg => new dvec4(y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.ywzyx swizzling.
        /// </summary>
        public dvec5 ywzyx => new dvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.gabgr swizzling (equivalent to dvec4.ywzyx).
        /// </summary>
        public dvec5 gabgr => new dvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.ywzyy swizzling.
        /// </summary>
        public dvec5 ywzyy => new dvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.gabgg swizzling (equivalent to dvec4.ywzyy).
        /// </summary>
        public dvec5 gabgg => new dvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.ywzyz swizzling.
        /// </summary>
        public dvec5 ywzyz => new dvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.gabgb swizzling (equivalent to dvec4.ywzyz).
        /// </summary>
        public dvec5 gabgb => new dvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.ywzyw swizzling.
        /// </summary>
        public dvec5 ywzyw => new dvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.gabga swizzling (equivalent to dvec4.ywzyw).
        /// </summary>
        public dvec5 gabga => new dvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.ywzz swizzling.
        /// </summary>
        public dvec4 ywzz => new dvec4(y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.gabb swizzling (equivalent to dvec4.ywzz).
        /// </summary>
        public dvec4 gabb => new dvec4(y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.ywzzx swizzling.
        /// </summary>
        public dvec5 ywzzx => new dvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.gabbr swizzling (equivalent to dvec4.ywzzx).
        /// </summary>
        public dvec5 gabbr => new dvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.ywzzy swizzling.
        /// </summary>
        public dvec5 ywzzy => new dvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.gabbg swizzling (equivalent to dvec4.ywzzy).
        /// </summary>
        public dvec5 gabbg => new dvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.ywzzz swizzling.
        /// </summary>
        public dvec5 ywzzz => new dvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.gabbb swizzling (equivalent to dvec4.ywzzz).
        /// </summary>
        public dvec5 gabbb => new dvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.ywzzw swizzling.
        /// </summary>
        public dvec5 ywzzw => new dvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.gabba swizzling (equivalent to dvec4.ywzzw).
        /// </summary>
        public dvec5 gabba => new dvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.ywzw swizzling.
        /// </summary>
        public dvec4 ywzw => new dvec4(y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.gaba swizzling (equivalent to dvec4.ywzw).
        /// </summary>
        public dvec4 gaba => new dvec4(y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.ywzwx swizzling.
        /// </summary>
        public dvec5 ywzwx => new dvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.gabar swizzling (equivalent to dvec4.ywzwx).
        /// </summary>
        public dvec5 gabar => new dvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.ywzwy swizzling.
        /// </summary>
        public dvec5 ywzwy => new dvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.gabag swizzling (equivalent to dvec4.ywzwy).
        /// </summary>
        public dvec5 gabag => new dvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.ywzwz swizzling.
        /// </summary>
        public dvec5 ywzwz => new dvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.gabab swizzling (equivalent to dvec4.ywzwz).
        /// </summary>
        public dvec5 gabab => new dvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.ywzww swizzling.
        /// </summary>
        public dvec5 ywzww => new dvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.gabaa swizzling (equivalent to dvec4.ywzww).
        /// </summary>
        public dvec5 gabaa => new dvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.yww swizzling.
        /// </summary>
        public dvec3 yww => new dvec3(y, w, w);
        
        /// <summary>
        /// Returns dvec4.gaa swizzling (equivalent to dvec4.yww).
        /// </summary>
        public dvec3 gaa => new dvec3(y, w, w);
        
        /// <summary>
        /// Returns dvec4.ywwx swizzling.
        /// </summary>
        public dvec4 ywwx => new dvec4(y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.gaar swizzling (equivalent to dvec4.ywwx).
        /// </summary>
        public dvec4 gaar => new dvec4(y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.ywwxx swizzling.
        /// </summary>
        public dvec5 ywwxx => new dvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.gaarr swizzling (equivalent to dvec4.ywwxx).
        /// </summary>
        public dvec5 gaarr => new dvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.ywwxy swizzling.
        /// </summary>
        public dvec5 ywwxy => new dvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.gaarg swizzling (equivalent to dvec4.ywwxy).
        /// </summary>
        public dvec5 gaarg => new dvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.ywwxz swizzling.
        /// </summary>
        public dvec5 ywwxz => new dvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.gaarb swizzling (equivalent to dvec4.ywwxz).
        /// </summary>
        public dvec5 gaarb => new dvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.ywwxw swizzling.
        /// </summary>
        public dvec5 ywwxw => new dvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.gaara swizzling (equivalent to dvec4.ywwxw).
        /// </summary>
        public dvec5 gaara => new dvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.ywwy swizzling.
        /// </summary>
        public dvec4 ywwy => new dvec4(y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.gaag swizzling (equivalent to dvec4.ywwy).
        /// </summary>
        public dvec4 gaag => new dvec4(y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.ywwyx swizzling.
        /// </summary>
        public dvec5 ywwyx => new dvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.gaagr swizzling (equivalent to dvec4.ywwyx).
        /// </summary>
        public dvec5 gaagr => new dvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.ywwyy swizzling.
        /// </summary>
        public dvec5 ywwyy => new dvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.gaagg swizzling (equivalent to dvec4.ywwyy).
        /// </summary>
        public dvec5 gaagg => new dvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.ywwyz swizzling.
        /// </summary>
        public dvec5 ywwyz => new dvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.gaagb swizzling (equivalent to dvec4.ywwyz).
        /// </summary>
        public dvec5 gaagb => new dvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.ywwyw swizzling.
        /// </summary>
        public dvec5 ywwyw => new dvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.gaaga swizzling (equivalent to dvec4.ywwyw).
        /// </summary>
        public dvec5 gaaga => new dvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.ywwz swizzling.
        /// </summary>
        public dvec4 ywwz => new dvec4(y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.gaab swizzling (equivalent to dvec4.ywwz).
        /// </summary>
        public dvec4 gaab => new dvec4(y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.ywwzx swizzling.
        /// </summary>
        public dvec5 ywwzx => new dvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.gaabr swizzling (equivalent to dvec4.ywwzx).
        /// </summary>
        public dvec5 gaabr => new dvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.ywwzy swizzling.
        /// </summary>
        public dvec5 ywwzy => new dvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.gaabg swizzling (equivalent to dvec4.ywwzy).
        /// </summary>
        public dvec5 gaabg => new dvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.ywwzz swizzling.
        /// </summary>
        public dvec5 ywwzz => new dvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.gaabb swizzling (equivalent to dvec4.ywwzz).
        /// </summary>
        public dvec5 gaabb => new dvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.ywwzw swizzling.
        /// </summary>
        public dvec5 ywwzw => new dvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.gaaba swizzling (equivalent to dvec4.ywwzw).
        /// </summary>
        public dvec5 gaaba => new dvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.ywww swizzling.
        /// </summary>
        public dvec4 ywww => new dvec4(y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.gaaa swizzling (equivalent to dvec4.ywww).
        /// </summary>
        public dvec4 gaaa => new dvec4(y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.ywwwx swizzling.
        /// </summary>
        public dvec5 ywwwx => new dvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.gaaar swizzling (equivalent to dvec4.ywwwx).
        /// </summary>
        public dvec5 gaaar => new dvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.ywwwy swizzling.
        /// </summary>
        public dvec5 ywwwy => new dvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.gaaag swizzling (equivalent to dvec4.ywwwy).
        /// </summary>
        public dvec5 gaaag => new dvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.ywwwz swizzling.
        /// </summary>
        public dvec5 ywwwz => new dvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.gaaab swizzling (equivalent to dvec4.ywwwz).
        /// </summary>
        public dvec5 gaaab => new dvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.ywwww swizzling.
        /// </summary>
        public dvec5 ywwww => new dvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns dvec4.gaaaa swizzling (equivalent to dvec4.ywwww).
        /// </summary>
        public dvec5 gaaaa => new dvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns dvec4.zx swizzling.
        /// </summary>
        public dvec2 zx => new dvec2(z, x);
        
        /// <summary>
        /// Returns dvec4.br swizzling (equivalent to dvec4.zx).
        /// </summary>
        public dvec2 br => new dvec2(z, x);
        
        /// <summary>
        /// Returns dvec4.zxx swizzling.
        /// </summary>
        public dvec3 zxx => new dvec3(z, x, x);
        
        /// <summary>
        /// Returns dvec4.brr swizzling (equivalent to dvec4.zxx).
        /// </summary>
        public dvec3 brr => new dvec3(z, x, x);
        
        /// <summary>
        /// Returns dvec4.zxxx swizzling.
        /// </summary>
        public dvec4 zxxx => new dvec4(z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.brrr swizzling (equivalent to dvec4.zxxx).
        /// </summary>
        public dvec4 brrr => new dvec4(z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.zxxxx swizzling.
        /// </summary>
        public dvec5 zxxxx => new dvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.brrrr swizzling (equivalent to dvec4.zxxxx).
        /// </summary>
        public dvec5 brrrr => new dvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.zxxxy swizzling.
        /// </summary>
        public dvec5 zxxxy => new dvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.brrrg swizzling (equivalent to dvec4.zxxxy).
        /// </summary>
        public dvec5 brrrg => new dvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.zxxxz swizzling.
        /// </summary>
        public dvec5 zxxxz => new dvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.brrrb swizzling (equivalent to dvec4.zxxxz).
        /// </summary>
        public dvec5 brrrb => new dvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.zxxxw swizzling.
        /// </summary>
        public dvec5 zxxxw => new dvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.brrra swizzling (equivalent to dvec4.zxxxw).
        /// </summary>
        public dvec5 brrra => new dvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.zxxy swizzling.
        /// </summary>
        public dvec4 zxxy => new dvec4(z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.brrg swizzling (equivalent to dvec4.zxxy).
        /// </summary>
        public dvec4 brrg => new dvec4(z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.zxxyx swizzling.
        /// </summary>
        public dvec5 zxxyx => new dvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.brrgr swizzling (equivalent to dvec4.zxxyx).
        /// </summary>
        public dvec5 brrgr => new dvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.zxxyy swizzling.
        /// </summary>
        public dvec5 zxxyy => new dvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.brrgg swizzling (equivalent to dvec4.zxxyy).
        /// </summary>
        public dvec5 brrgg => new dvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.zxxyz swizzling.
        /// </summary>
        public dvec5 zxxyz => new dvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.brrgb swizzling (equivalent to dvec4.zxxyz).
        /// </summary>
        public dvec5 brrgb => new dvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.zxxyw swizzling.
        /// </summary>
        public dvec5 zxxyw => new dvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.brrga swizzling (equivalent to dvec4.zxxyw).
        /// </summary>
        public dvec5 brrga => new dvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.zxxz swizzling.
        /// </summary>
        public dvec4 zxxz => new dvec4(z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.brrb swizzling (equivalent to dvec4.zxxz).
        /// </summary>
        public dvec4 brrb => new dvec4(z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.zxxzx swizzling.
        /// </summary>
        public dvec5 zxxzx => new dvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.brrbr swizzling (equivalent to dvec4.zxxzx).
        /// </summary>
        public dvec5 brrbr => new dvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.zxxzy swizzling.
        /// </summary>
        public dvec5 zxxzy => new dvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.brrbg swizzling (equivalent to dvec4.zxxzy).
        /// </summary>
        public dvec5 brrbg => new dvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.zxxzz swizzling.
        /// </summary>
        public dvec5 zxxzz => new dvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.brrbb swizzling (equivalent to dvec4.zxxzz).
        /// </summary>
        public dvec5 brrbb => new dvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.zxxzw swizzling.
        /// </summary>
        public dvec5 zxxzw => new dvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.brrba swizzling (equivalent to dvec4.zxxzw).
        /// </summary>
        public dvec5 brrba => new dvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.zxxw swizzling.
        /// </summary>
        public dvec4 zxxw => new dvec4(z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.brra swizzling (equivalent to dvec4.zxxw).
        /// </summary>
        public dvec4 brra => new dvec4(z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.zxxwx swizzling.
        /// </summary>
        public dvec5 zxxwx => new dvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.brrar swizzling (equivalent to dvec4.zxxwx).
        /// </summary>
        public dvec5 brrar => new dvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.zxxwy swizzling.
        /// </summary>
        public dvec5 zxxwy => new dvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.brrag swizzling (equivalent to dvec4.zxxwy).
        /// </summary>
        public dvec5 brrag => new dvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.zxxwz swizzling.
        /// </summary>
        public dvec5 zxxwz => new dvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.brrab swizzling (equivalent to dvec4.zxxwz).
        /// </summary>
        public dvec5 brrab => new dvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.zxxww swizzling.
        /// </summary>
        public dvec5 zxxww => new dvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.brraa swizzling (equivalent to dvec4.zxxww).
        /// </summary>
        public dvec5 brraa => new dvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.zxy swizzling.
        /// </summary>
        public dvec3 zxy => new dvec3(z, x, y);
        
        /// <summary>
        /// Returns dvec4.brg swizzling (equivalent to dvec4.zxy).
        /// </summary>
        public dvec3 brg => new dvec3(z, x, y);
        
        /// <summary>
        /// Returns dvec4.zxyx swizzling.
        /// </summary>
        public dvec4 zxyx => new dvec4(z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.brgr swizzling (equivalent to dvec4.zxyx).
        /// </summary>
        public dvec4 brgr => new dvec4(z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.zxyxx swizzling.
        /// </summary>
        public dvec5 zxyxx => new dvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.brgrr swizzling (equivalent to dvec4.zxyxx).
        /// </summary>
        public dvec5 brgrr => new dvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.zxyxy swizzling.
        /// </summary>
        public dvec5 zxyxy => new dvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.brgrg swizzling (equivalent to dvec4.zxyxy).
        /// </summary>
        public dvec5 brgrg => new dvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.zxyxz swizzling.
        /// </summary>
        public dvec5 zxyxz => new dvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.brgrb swizzling (equivalent to dvec4.zxyxz).
        /// </summary>
        public dvec5 brgrb => new dvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.zxyxw swizzling.
        /// </summary>
        public dvec5 zxyxw => new dvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.brgra swizzling (equivalent to dvec4.zxyxw).
        /// </summary>
        public dvec5 brgra => new dvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.zxyy swizzling.
        /// </summary>
        public dvec4 zxyy => new dvec4(z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.brgg swizzling (equivalent to dvec4.zxyy).
        /// </summary>
        public dvec4 brgg => new dvec4(z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.zxyyx swizzling.
        /// </summary>
        public dvec5 zxyyx => new dvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.brggr swizzling (equivalent to dvec4.zxyyx).
        /// </summary>
        public dvec5 brggr => new dvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.zxyyy swizzling.
        /// </summary>
        public dvec5 zxyyy => new dvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.brggg swizzling (equivalent to dvec4.zxyyy).
        /// </summary>
        public dvec5 brggg => new dvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.zxyyz swizzling.
        /// </summary>
        public dvec5 zxyyz => new dvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.brggb swizzling (equivalent to dvec4.zxyyz).
        /// </summary>
        public dvec5 brggb => new dvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.zxyyw swizzling.
        /// </summary>
        public dvec5 zxyyw => new dvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.brgga swizzling (equivalent to dvec4.zxyyw).
        /// </summary>
        public dvec5 brgga => new dvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.zxyz swizzling.
        /// </summary>
        public dvec4 zxyz => new dvec4(z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.brgb swizzling (equivalent to dvec4.zxyz).
        /// </summary>
        public dvec4 brgb => new dvec4(z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.zxyzx swizzling.
        /// </summary>
        public dvec5 zxyzx => new dvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.brgbr swizzling (equivalent to dvec4.zxyzx).
        /// </summary>
        public dvec5 brgbr => new dvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.zxyzy swizzling.
        /// </summary>
        public dvec5 zxyzy => new dvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.brgbg swizzling (equivalent to dvec4.zxyzy).
        /// </summary>
        public dvec5 brgbg => new dvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.zxyzz swizzling.
        /// </summary>
        public dvec5 zxyzz => new dvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.brgbb swizzling (equivalent to dvec4.zxyzz).
        /// </summary>
        public dvec5 brgbb => new dvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.zxyzw swizzling.
        /// </summary>
        public dvec5 zxyzw => new dvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.brgba swizzling (equivalent to dvec4.zxyzw).
        /// </summary>
        public dvec5 brgba => new dvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.zxyw swizzling.
        /// </summary>
        public dvec4 zxyw => new dvec4(z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.brga swizzling (equivalent to dvec4.zxyw).
        /// </summary>
        public dvec4 brga => new dvec4(z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.zxywx swizzling.
        /// </summary>
        public dvec5 zxywx => new dvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.brgar swizzling (equivalent to dvec4.zxywx).
        /// </summary>
        public dvec5 brgar => new dvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.zxywy swizzling.
        /// </summary>
        public dvec5 zxywy => new dvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.brgag swizzling (equivalent to dvec4.zxywy).
        /// </summary>
        public dvec5 brgag => new dvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.zxywz swizzling.
        /// </summary>
        public dvec5 zxywz => new dvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.brgab swizzling (equivalent to dvec4.zxywz).
        /// </summary>
        public dvec5 brgab => new dvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.zxyww swizzling.
        /// </summary>
        public dvec5 zxyww => new dvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.brgaa swizzling (equivalent to dvec4.zxyww).
        /// </summary>
        public dvec5 brgaa => new dvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.zxz swizzling.
        /// </summary>
        public dvec3 zxz => new dvec3(z, x, z);
        
        /// <summary>
        /// Returns dvec4.brb swizzling (equivalent to dvec4.zxz).
        /// </summary>
        public dvec3 brb => new dvec3(z, x, z);
        
        /// <summary>
        /// Returns dvec4.zxzx swizzling.
        /// </summary>
        public dvec4 zxzx => new dvec4(z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.brbr swizzling (equivalent to dvec4.zxzx).
        /// </summary>
        public dvec4 brbr => new dvec4(z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.zxzxx swizzling.
        /// </summary>
        public dvec5 zxzxx => new dvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.brbrr swizzling (equivalent to dvec4.zxzxx).
        /// </summary>
        public dvec5 brbrr => new dvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.zxzxy swizzling.
        /// </summary>
        public dvec5 zxzxy => new dvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.brbrg swizzling (equivalent to dvec4.zxzxy).
        /// </summary>
        public dvec5 brbrg => new dvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.zxzxz swizzling.
        /// </summary>
        public dvec5 zxzxz => new dvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.brbrb swizzling (equivalent to dvec4.zxzxz).
        /// </summary>
        public dvec5 brbrb => new dvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.zxzxw swizzling.
        /// </summary>
        public dvec5 zxzxw => new dvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.brbra swizzling (equivalent to dvec4.zxzxw).
        /// </summary>
        public dvec5 brbra => new dvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.zxzy swizzling.
        /// </summary>
        public dvec4 zxzy => new dvec4(z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.brbg swizzling (equivalent to dvec4.zxzy).
        /// </summary>
        public dvec4 brbg => new dvec4(z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.zxzyx swizzling.
        /// </summary>
        public dvec5 zxzyx => new dvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.brbgr swizzling (equivalent to dvec4.zxzyx).
        /// </summary>
        public dvec5 brbgr => new dvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.zxzyy swizzling.
        /// </summary>
        public dvec5 zxzyy => new dvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.brbgg swizzling (equivalent to dvec4.zxzyy).
        /// </summary>
        public dvec5 brbgg => new dvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.zxzyz swizzling.
        /// </summary>
        public dvec5 zxzyz => new dvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.brbgb swizzling (equivalent to dvec4.zxzyz).
        /// </summary>
        public dvec5 brbgb => new dvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.zxzyw swizzling.
        /// </summary>
        public dvec5 zxzyw => new dvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.brbga swizzling (equivalent to dvec4.zxzyw).
        /// </summary>
        public dvec5 brbga => new dvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.zxzz swizzling.
        /// </summary>
        public dvec4 zxzz => new dvec4(z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.brbb swizzling (equivalent to dvec4.zxzz).
        /// </summary>
        public dvec4 brbb => new dvec4(z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.zxzzx swizzling.
        /// </summary>
        public dvec5 zxzzx => new dvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.brbbr swizzling (equivalent to dvec4.zxzzx).
        /// </summary>
        public dvec5 brbbr => new dvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.zxzzy swizzling.
        /// </summary>
        public dvec5 zxzzy => new dvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.brbbg swizzling (equivalent to dvec4.zxzzy).
        /// </summary>
        public dvec5 brbbg => new dvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.zxzzz swizzling.
        /// </summary>
        public dvec5 zxzzz => new dvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.brbbb swizzling (equivalent to dvec4.zxzzz).
        /// </summary>
        public dvec5 brbbb => new dvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.zxzzw swizzling.
        /// </summary>
        public dvec5 zxzzw => new dvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.brbba swizzling (equivalent to dvec4.zxzzw).
        /// </summary>
        public dvec5 brbba => new dvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.zxzw swizzling.
        /// </summary>
        public dvec4 zxzw => new dvec4(z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.brba swizzling (equivalent to dvec4.zxzw).
        /// </summary>
        public dvec4 brba => new dvec4(z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.zxzwx swizzling.
        /// </summary>
        public dvec5 zxzwx => new dvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.brbar swizzling (equivalent to dvec4.zxzwx).
        /// </summary>
        public dvec5 brbar => new dvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.zxzwy swizzling.
        /// </summary>
        public dvec5 zxzwy => new dvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.brbag swizzling (equivalent to dvec4.zxzwy).
        /// </summary>
        public dvec5 brbag => new dvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.zxzwz swizzling.
        /// </summary>
        public dvec5 zxzwz => new dvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.brbab swizzling (equivalent to dvec4.zxzwz).
        /// </summary>
        public dvec5 brbab => new dvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.zxzww swizzling.
        /// </summary>
        public dvec5 zxzww => new dvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.brbaa swizzling (equivalent to dvec4.zxzww).
        /// </summary>
        public dvec5 brbaa => new dvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.zxw swizzling.
        /// </summary>
        public dvec3 zxw => new dvec3(z, x, w);
        
        /// <summary>
        /// Returns dvec4.bra swizzling (equivalent to dvec4.zxw).
        /// </summary>
        public dvec3 bra => new dvec3(z, x, w);
        
        /// <summary>
        /// Returns dvec4.zxwx swizzling.
        /// </summary>
        public dvec4 zxwx => new dvec4(z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.brar swizzling (equivalent to dvec4.zxwx).
        /// </summary>
        public dvec4 brar => new dvec4(z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.zxwxx swizzling.
        /// </summary>
        public dvec5 zxwxx => new dvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.brarr swizzling (equivalent to dvec4.zxwxx).
        /// </summary>
        public dvec5 brarr => new dvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.zxwxy swizzling.
        /// </summary>
        public dvec5 zxwxy => new dvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.brarg swizzling (equivalent to dvec4.zxwxy).
        /// </summary>
        public dvec5 brarg => new dvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.zxwxz swizzling.
        /// </summary>
        public dvec5 zxwxz => new dvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.brarb swizzling (equivalent to dvec4.zxwxz).
        /// </summary>
        public dvec5 brarb => new dvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.zxwxw swizzling.
        /// </summary>
        public dvec5 zxwxw => new dvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.brara swizzling (equivalent to dvec4.zxwxw).
        /// </summary>
        public dvec5 brara => new dvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.zxwy swizzling.
        /// </summary>
        public dvec4 zxwy => new dvec4(z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.brag swizzling (equivalent to dvec4.zxwy).
        /// </summary>
        public dvec4 brag => new dvec4(z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.zxwyx swizzling.
        /// </summary>
        public dvec5 zxwyx => new dvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.bragr swizzling (equivalent to dvec4.zxwyx).
        /// </summary>
        public dvec5 bragr => new dvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.zxwyy swizzling.
        /// </summary>
        public dvec5 zxwyy => new dvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.bragg swizzling (equivalent to dvec4.zxwyy).
        /// </summary>
        public dvec5 bragg => new dvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.zxwyz swizzling.
        /// </summary>
        public dvec5 zxwyz => new dvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.bragb swizzling (equivalent to dvec4.zxwyz).
        /// </summary>
        public dvec5 bragb => new dvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.zxwyw swizzling.
        /// </summary>
        public dvec5 zxwyw => new dvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.braga swizzling (equivalent to dvec4.zxwyw).
        /// </summary>
        public dvec5 braga => new dvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.zxwz swizzling.
        /// </summary>
        public dvec4 zxwz => new dvec4(z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.brab swizzling (equivalent to dvec4.zxwz).
        /// </summary>
        public dvec4 brab => new dvec4(z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.zxwzx swizzling.
        /// </summary>
        public dvec5 zxwzx => new dvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.brabr swizzling (equivalent to dvec4.zxwzx).
        /// </summary>
        public dvec5 brabr => new dvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.zxwzy swizzling.
        /// </summary>
        public dvec5 zxwzy => new dvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.brabg swizzling (equivalent to dvec4.zxwzy).
        /// </summary>
        public dvec5 brabg => new dvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.zxwzz swizzling.
        /// </summary>
        public dvec5 zxwzz => new dvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.brabb swizzling (equivalent to dvec4.zxwzz).
        /// </summary>
        public dvec5 brabb => new dvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.zxwzw swizzling.
        /// </summary>
        public dvec5 zxwzw => new dvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.braba swizzling (equivalent to dvec4.zxwzw).
        /// </summary>
        public dvec5 braba => new dvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.zxww swizzling.
        /// </summary>
        public dvec4 zxww => new dvec4(z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.braa swizzling (equivalent to dvec4.zxww).
        /// </summary>
        public dvec4 braa => new dvec4(z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.zxwwx swizzling.
        /// </summary>
        public dvec5 zxwwx => new dvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.braar swizzling (equivalent to dvec4.zxwwx).
        /// </summary>
        public dvec5 braar => new dvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.zxwwy swizzling.
        /// </summary>
        public dvec5 zxwwy => new dvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.braag swizzling (equivalent to dvec4.zxwwy).
        /// </summary>
        public dvec5 braag => new dvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.zxwwz swizzling.
        /// </summary>
        public dvec5 zxwwz => new dvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.braab swizzling (equivalent to dvec4.zxwwz).
        /// </summary>
        public dvec5 braab => new dvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.zxwww swizzling.
        /// </summary>
        public dvec5 zxwww => new dvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.braaa swizzling (equivalent to dvec4.zxwww).
        /// </summary>
        public dvec5 braaa => new dvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.zy swizzling.
        /// </summary>
        public dvec2 zy => new dvec2(z, y);
        
        /// <summary>
        /// Returns dvec4.bg swizzling (equivalent to dvec4.zy).
        /// </summary>
        public dvec2 bg => new dvec2(z, y);
        
        /// <summary>
        /// Returns dvec4.zyx swizzling.
        /// </summary>
        public dvec3 zyx => new dvec3(z, y, x);
        
        /// <summary>
        /// Returns dvec4.bgr swizzling (equivalent to dvec4.zyx).
        /// </summary>
        public dvec3 bgr => new dvec3(z, y, x);
        
        /// <summary>
        /// Returns dvec4.zyxx swizzling.
        /// </summary>
        public dvec4 zyxx => new dvec4(z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.bgrr swizzling (equivalent to dvec4.zyxx).
        /// </summary>
        public dvec4 bgrr => new dvec4(z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.zyxxx swizzling.
        /// </summary>
        public dvec5 zyxxx => new dvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.bgrrr swizzling (equivalent to dvec4.zyxxx).
        /// </summary>
        public dvec5 bgrrr => new dvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.zyxxy swizzling.
        /// </summary>
        public dvec5 zyxxy => new dvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.bgrrg swizzling (equivalent to dvec4.zyxxy).
        /// </summary>
        public dvec5 bgrrg => new dvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.zyxxz swizzling.
        /// </summary>
        public dvec5 zyxxz => new dvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.bgrrb swizzling (equivalent to dvec4.zyxxz).
        /// </summary>
        public dvec5 bgrrb => new dvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.zyxxw swizzling.
        /// </summary>
        public dvec5 zyxxw => new dvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.bgrra swizzling (equivalent to dvec4.zyxxw).
        /// </summary>
        public dvec5 bgrra => new dvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.zyxy swizzling.
        /// </summary>
        public dvec4 zyxy => new dvec4(z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.bgrg swizzling (equivalent to dvec4.zyxy).
        /// </summary>
        public dvec4 bgrg => new dvec4(z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.zyxyx swizzling.
        /// </summary>
        public dvec5 zyxyx => new dvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.bgrgr swizzling (equivalent to dvec4.zyxyx).
        /// </summary>
        public dvec5 bgrgr => new dvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.zyxyy swizzling.
        /// </summary>
        public dvec5 zyxyy => new dvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.bgrgg swizzling (equivalent to dvec4.zyxyy).
        /// </summary>
        public dvec5 bgrgg => new dvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.zyxyz swizzling.
        /// </summary>
        public dvec5 zyxyz => new dvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.bgrgb swizzling (equivalent to dvec4.zyxyz).
        /// </summary>
        public dvec5 bgrgb => new dvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.zyxyw swizzling.
        /// </summary>
        public dvec5 zyxyw => new dvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.bgrga swizzling (equivalent to dvec4.zyxyw).
        /// </summary>
        public dvec5 bgrga => new dvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.zyxz swizzling.
        /// </summary>
        public dvec4 zyxz => new dvec4(z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.bgrb swizzling (equivalent to dvec4.zyxz).
        /// </summary>
        public dvec4 bgrb => new dvec4(z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.zyxzx swizzling.
        /// </summary>
        public dvec5 zyxzx => new dvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.bgrbr swizzling (equivalent to dvec4.zyxzx).
        /// </summary>
        public dvec5 bgrbr => new dvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.zyxzy swizzling.
        /// </summary>
        public dvec5 zyxzy => new dvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.bgrbg swizzling (equivalent to dvec4.zyxzy).
        /// </summary>
        public dvec5 bgrbg => new dvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.zyxzz swizzling.
        /// </summary>
        public dvec5 zyxzz => new dvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.bgrbb swizzling (equivalent to dvec4.zyxzz).
        /// </summary>
        public dvec5 bgrbb => new dvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.zyxzw swizzling.
        /// </summary>
        public dvec5 zyxzw => new dvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.bgrba swizzling (equivalent to dvec4.zyxzw).
        /// </summary>
        public dvec5 bgrba => new dvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.zyxw swizzling.
        /// </summary>
        public dvec4 zyxw => new dvec4(z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.bgra swizzling (equivalent to dvec4.zyxw).
        /// </summary>
        public dvec4 bgra => new dvec4(z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.zyxwx swizzling.
        /// </summary>
        public dvec5 zyxwx => new dvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.bgrar swizzling (equivalent to dvec4.zyxwx).
        /// </summary>
        public dvec5 bgrar => new dvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.zyxwy swizzling.
        /// </summary>
        public dvec5 zyxwy => new dvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.bgrag swizzling (equivalent to dvec4.zyxwy).
        /// </summary>
        public dvec5 bgrag => new dvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.zyxwz swizzling.
        /// </summary>
        public dvec5 zyxwz => new dvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.bgrab swizzling (equivalent to dvec4.zyxwz).
        /// </summary>
        public dvec5 bgrab => new dvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.zyxww swizzling.
        /// </summary>
        public dvec5 zyxww => new dvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.bgraa swizzling (equivalent to dvec4.zyxww).
        /// </summary>
        public dvec5 bgraa => new dvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.zyy swizzling.
        /// </summary>
        public dvec3 zyy => new dvec3(z, y, y);
        
        /// <summary>
        /// Returns dvec4.bgg swizzling (equivalent to dvec4.zyy).
        /// </summary>
        public dvec3 bgg => new dvec3(z, y, y);
        
        /// <summary>
        /// Returns dvec4.zyyx swizzling.
        /// </summary>
        public dvec4 zyyx => new dvec4(z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.bggr swizzling (equivalent to dvec4.zyyx).
        /// </summary>
        public dvec4 bggr => new dvec4(z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.zyyxx swizzling.
        /// </summary>
        public dvec5 zyyxx => new dvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.bggrr swizzling (equivalent to dvec4.zyyxx).
        /// </summary>
        public dvec5 bggrr => new dvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.zyyxy swizzling.
        /// </summary>
        public dvec5 zyyxy => new dvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.bggrg swizzling (equivalent to dvec4.zyyxy).
        /// </summary>
        public dvec5 bggrg => new dvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.zyyxz swizzling.
        /// </summary>
        public dvec5 zyyxz => new dvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.bggrb swizzling (equivalent to dvec4.zyyxz).
        /// </summary>
        public dvec5 bggrb => new dvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.zyyxw swizzling.
        /// </summary>
        public dvec5 zyyxw => new dvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.bggra swizzling (equivalent to dvec4.zyyxw).
        /// </summary>
        public dvec5 bggra => new dvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.zyyy swizzling.
        /// </summary>
        public dvec4 zyyy => new dvec4(z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.bggg swizzling (equivalent to dvec4.zyyy).
        /// </summary>
        public dvec4 bggg => new dvec4(z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.zyyyx swizzling.
        /// </summary>
        public dvec5 zyyyx => new dvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.bgggr swizzling (equivalent to dvec4.zyyyx).
        /// </summary>
        public dvec5 bgggr => new dvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.zyyyy swizzling.
        /// </summary>
        public dvec5 zyyyy => new dvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.bgggg swizzling (equivalent to dvec4.zyyyy).
        /// </summary>
        public dvec5 bgggg => new dvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.zyyyz swizzling.
        /// </summary>
        public dvec5 zyyyz => new dvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.bgggb swizzling (equivalent to dvec4.zyyyz).
        /// </summary>
        public dvec5 bgggb => new dvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.zyyyw swizzling.
        /// </summary>
        public dvec5 zyyyw => new dvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.bggga swizzling (equivalent to dvec4.zyyyw).
        /// </summary>
        public dvec5 bggga => new dvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.zyyz swizzling.
        /// </summary>
        public dvec4 zyyz => new dvec4(z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.bggb swizzling (equivalent to dvec4.zyyz).
        /// </summary>
        public dvec4 bggb => new dvec4(z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.zyyzx swizzling.
        /// </summary>
        public dvec5 zyyzx => new dvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.bggbr swizzling (equivalent to dvec4.zyyzx).
        /// </summary>
        public dvec5 bggbr => new dvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.zyyzy swizzling.
        /// </summary>
        public dvec5 zyyzy => new dvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.bggbg swizzling (equivalent to dvec4.zyyzy).
        /// </summary>
        public dvec5 bggbg => new dvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.zyyzz swizzling.
        /// </summary>
        public dvec5 zyyzz => new dvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.bggbb swizzling (equivalent to dvec4.zyyzz).
        /// </summary>
        public dvec5 bggbb => new dvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.zyyzw swizzling.
        /// </summary>
        public dvec5 zyyzw => new dvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.bggba swizzling (equivalent to dvec4.zyyzw).
        /// </summary>
        public dvec5 bggba => new dvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.zyyw swizzling.
        /// </summary>
        public dvec4 zyyw => new dvec4(z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.bgga swizzling (equivalent to dvec4.zyyw).
        /// </summary>
        public dvec4 bgga => new dvec4(z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.zyywx swizzling.
        /// </summary>
        public dvec5 zyywx => new dvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.bggar swizzling (equivalent to dvec4.zyywx).
        /// </summary>
        public dvec5 bggar => new dvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.zyywy swizzling.
        /// </summary>
        public dvec5 zyywy => new dvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.bggag swizzling (equivalent to dvec4.zyywy).
        /// </summary>
        public dvec5 bggag => new dvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.zyywz swizzling.
        /// </summary>
        public dvec5 zyywz => new dvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.bggab swizzling (equivalent to dvec4.zyywz).
        /// </summary>
        public dvec5 bggab => new dvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.zyyww swizzling.
        /// </summary>
        public dvec5 zyyww => new dvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.bggaa swizzling (equivalent to dvec4.zyyww).
        /// </summary>
        public dvec5 bggaa => new dvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.zyz swizzling.
        /// </summary>
        public dvec3 zyz => new dvec3(z, y, z);
        
        /// <summary>
        /// Returns dvec4.bgb swizzling (equivalent to dvec4.zyz).
        /// </summary>
        public dvec3 bgb => new dvec3(z, y, z);
        
        /// <summary>
        /// Returns dvec4.zyzx swizzling.
        /// </summary>
        public dvec4 zyzx => new dvec4(z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.bgbr swizzling (equivalent to dvec4.zyzx).
        /// </summary>
        public dvec4 bgbr => new dvec4(z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.zyzxx swizzling.
        /// </summary>
        public dvec5 zyzxx => new dvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.bgbrr swizzling (equivalent to dvec4.zyzxx).
        /// </summary>
        public dvec5 bgbrr => new dvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.zyzxy swizzling.
        /// </summary>
        public dvec5 zyzxy => new dvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.bgbrg swizzling (equivalent to dvec4.zyzxy).
        /// </summary>
        public dvec5 bgbrg => new dvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.zyzxz swizzling.
        /// </summary>
        public dvec5 zyzxz => new dvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.bgbrb swizzling (equivalent to dvec4.zyzxz).
        /// </summary>
        public dvec5 bgbrb => new dvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.zyzxw swizzling.
        /// </summary>
        public dvec5 zyzxw => new dvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.bgbra swizzling (equivalent to dvec4.zyzxw).
        /// </summary>
        public dvec5 bgbra => new dvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.zyzy swizzling.
        /// </summary>
        public dvec4 zyzy => new dvec4(z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.bgbg swizzling (equivalent to dvec4.zyzy).
        /// </summary>
        public dvec4 bgbg => new dvec4(z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.zyzyx swizzling.
        /// </summary>
        public dvec5 zyzyx => new dvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.bgbgr swizzling (equivalent to dvec4.zyzyx).
        /// </summary>
        public dvec5 bgbgr => new dvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.zyzyy swizzling.
        /// </summary>
        public dvec5 zyzyy => new dvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.bgbgg swizzling (equivalent to dvec4.zyzyy).
        /// </summary>
        public dvec5 bgbgg => new dvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.zyzyz swizzling.
        /// </summary>
        public dvec5 zyzyz => new dvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.bgbgb swizzling (equivalent to dvec4.zyzyz).
        /// </summary>
        public dvec5 bgbgb => new dvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.zyzyw swizzling.
        /// </summary>
        public dvec5 zyzyw => new dvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.bgbga swizzling (equivalent to dvec4.zyzyw).
        /// </summary>
        public dvec5 bgbga => new dvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.zyzz swizzling.
        /// </summary>
        public dvec4 zyzz => new dvec4(z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.bgbb swizzling (equivalent to dvec4.zyzz).
        /// </summary>
        public dvec4 bgbb => new dvec4(z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.zyzzx swizzling.
        /// </summary>
        public dvec5 zyzzx => new dvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.bgbbr swizzling (equivalent to dvec4.zyzzx).
        /// </summary>
        public dvec5 bgbbr => new dvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.zyzzy swizzling.
        /// </summary>
        public dvec5 zyzzy => new dvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.bgbbg swizzling (equivalent to dvec4.zyzzy).
        /// </summary>
        public dvec5 bgbbg => new dvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.zyzzz swizzling.
        /// </summary>
        public dvec5 zyzzz => new dvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.bgbbb swizzling (equivalent to dvec4.zyzzz).
        /// </summary>
        public dvec5 bgbbb => new dvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.zyzzw swizzling.
        /// </summary>
        public dvec5 zyzzw => new dvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.bgbba swizzling (equivalent to dvec4.zyzzw).
        /// </summary>
        public dvec5 bgbba => new dvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.zyzw swizzling.
        /// </summary>
        public dvec4 zyzw => new dvec4(z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.bgba swizzling (equivalent to dvec4.zyzw).
        /// </summary>
        public dvec4 bgba => new dvec4(z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.zyzwx swizzling.
        /// </summary>
        public dvec5 zyzwx => new dvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.bgbar swizzling (equivalent to dvec4.zyzwx).
        /// </summary>
        public dvec5 bgbar => new dvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.zyzwy swizzling.
        /// </summary>
        public dvec5 zyzwy => new dvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.bgbag swizzling (equivalent to dvec4.zyzwy).
        /// </summary>
        public dvec5 bgbag => new dvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.zyzwz swizzling.
        /// </summary>
        public dvec5 zyzwz => new dvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.bgbab swizzling (equivalent to dvec4.zyzwz).
        /// </summary>
        public dvec5 bgbab => new dvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.zyzww swizzling.
        /// </summary>
        public dvec5 zyzww => new dvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.bgbaa swizzling (equivalent to dvec4.zyzww).
        /// </summary>
        public dvec5 bgbaa => new dvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.zyw swizzling.
        /// </summary>
        public dvec3 zyw => new dvec3(z, y, w);
        
        /// <summary>
        /// Returns dvec4.bga swizzling (equivalent to dvec4.zyw).
        /// </summary>
        public dvec3 bga => new dvec3(z, y, w);
        
        /// <summary>
        /// Returns dvec4.zywx swizzling.
        /// </summary>
        public dvec4 zywx => new dvec4(z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.bgar swizzling (equivalent to dvec4.zywx).
        /// </summary>
        public dvec4 bgar => new dvec4(z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.zywxx swizzling.
        /// </summary>
        public dvec5 zywxx => new dvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.bgarr swizzling (equivalent to dvec4.zywxx).
        /// </summary>
        public dvec5 bgarr => new dvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.zywxy swizzling.
        /// </summary>
        public dvec5 zywxy => new dvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.bgarg swizzling (equivalent to dvec4.zywxy).
        /// </summary>
        public dvec5 bgarg => new dvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.zywxz swizzling.
        /// </summary>
        public dvec5 zywxz => new dvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.bgarb swizzling (equivalent to dvec4.zywxz).
        /// </summary>
        public dvec5 bgarb => new dvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.zywxw swizzling.
        /// </summary>
        public dvec5 zywxw => new dvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.bgara swizzling (equivalent to dvec4.zywxw).
        /// </summary>
        public dvec5 bgara => new dvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.zywy swizzling.
        /// </summary>
        public dvec4 zywy => new dvec4(z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.bgag swizzling (equivalent to dvec4.zywy).
        /// </summary>
        public dvec4 bgag => new dvec4(z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.zywyx swizzling.
        /// </summary>
        public dvec5 zywyx => new dvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.bgagr swizzling (equivalent to dvec4.zywyx).
        /// </summary>
        public dvec5 bgagr => new dvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.zywyy swizzling.
        /// </summary>
        public dvec5 zywyy => new dvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.bgagg swizzling (equivalent to dvec4.zywyy).
        /// </summary>
        public dvec5 bgagg => new dvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.zywyz swizzling.
        /// </summary>
        public dvec5 zywyz => new dvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.bgagb swizzling (equivalent to dvec4.zywyz).
        /// </summary>
        public dvec5 bgagb => new dvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.zywyw swizzling.
        /// </summary>
        public dvec5 zywyw => new dvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.bgaga swizzling (equivalent to dvec4.zywyw).
        /// </summary>
        public dvec5 bgaga => new dvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.zywz swizzling.
        /// </summary>
        public dvec4 zywz => new dvec4(z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.bgab swizzling (equivalent to dvec4.zywz).
        /// </summary>
        public dvec4 bgab => new dvec4(z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.zywzx swizzling.
        /// </summary>
        public dvec5 zywzx => new dvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.bgabr swizzling (equivalent to dvec4.zywzx).
        /// </summary>
        public dvec5 bgabr => new dvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.zywzy swizzling.
        /// </summary>
        public dvec5 zywzy => new dvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.bgabg swizzling (equivalent to dvec4.zywzy).
        /// </summary>
        public dvec5 bgabg => new dvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.zywzz swizzling.
        /// </summary>
        public dvec5 zywzz => new dvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.bgabb swizzling (equivalent to dvec4.zywzz).
        /// </summary>
        public dvec5 bgabb => new dvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.zywzw swizzling.
        /// </summary>
        public dvec5 zywzw => new dvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.bgaba swizzling (equivalent to dvec4.zywzw).
        /// </summary>
        public dvec5 bgaba => new dvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.zyww swizzling.
        /// </summary>
        public dvec4 zyww => new dvec4(z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.bgaa swizzling (equivalent to dvec4.zyww).
        /// </summary>
        public dvec4 bgaa => new dvec4(z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.zywwx swizzling.
        /// </summary>
        public dvec5 zywwx => new dvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.bgaar swizzling (equivalent to dvec4.zywwx).
        /// </summary>
        public dvec5 bgaar => new dvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.zywwy swizzling.
        /// </summary>
        public dvec5 zywwy => new dvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.bgaag swizzling (equivalent to dvec4.zywwy).
        /// </summary>
        public dvec5 bgaag => new dvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.zywwz swizzling.
        /// </summary>
        public dvec5 zywwz => new dvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.bgaab swizzling (equivalent to dvec4.zywwz).
        /// </summary>
        public dvec5 bgaab => new dvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.zywww swizzling.
        /// </summary>
        public dvec5 zywww => new dvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.bgaaa swizzling (equivalent to dvec4.zywww).
        /// </summary>
        public dvec5 bgaaa => new dvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.zz swizzling.
        /// </summary>
        public dvec2 zz => new dvec2(z, z);
        
        /// <summary>
        /// Returns dvec4.bb swizzling (equivalent to dvec4.zz).
        /// </summary>
        public dvec2 bb => new dvec2(z, z);
        
        /// <summary>
        /// Returns dvec4.zzx swizzling.
        /// </summary>
        public dvec3 zzx => new dvec3(z, z, x);
        
        /// <summary>
        /// Returns dvec4.bbr swizzling (equivalent to dvec4.zzx).
        /// </summary>
        public dvec3 bbr => new dvec3(z, z, x);
        
        /// <summary>
        /// Returns dvec4.zzxx swizzling.
        /// </summary>
        public dvec4 zzxx => new dvec4(z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.bbrr swizzling (equivalent to dvec4.zzxx).
        /// </summary>
        public dvec4 bbrr => new dvec4(z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.zzxxx swizzling.
        /// </summary>
        public dvec5 zzxxx => new dvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.bbrrr swizzling (equivalent to dvec4.zzxxx).
        /// </summary>
        public dvec5 bbrrr => new dvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.zzxxy swizzling.
        /// </summary>
        public dvec5 zzxxy => new dvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.bbrrg swizzling (equivalent to dvec4.zzxxy).
        /// </summary>
        public dvec5 bbrrg => new dvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.zzxxz swizzling.
        /// </summary>
        public dvec5 zzxxz => new dvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.bbrrb swizzling (equivalent to dvec4.zzxxz).
        /// </summary>
        public dvec5 bbrrb => new dvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.zzxxw swizzling.
        /// </summary>
        public dvec5 zzxxw => new dvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.bbrra swizzling (equivalent to dvec4.zzxxw).
        /// </summary>
        public dvec5 bbrra => new dvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.zzxy swizzling.
        /// </summary>
        public dvec4 zzxy => new dvec4(z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.bbrg swizzling (equivalent to dvec4.zzxy).
        /// </summary>
        public dvec4 bbrg => new dvec4(z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.zzxyx swizzling.
        /// </summary>
        public dvec5 zzxyx => new dvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.bbrgr swizzling (equivalent to dvec4.zzxyx).
        /// </summary>
        public dvec5 bbrgr => new dvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.zzxyy swizzling.
        /// </summary>
        public dvec5 zzxyy => new dvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.bbrgg swizzling (equivalent to dvec4.zzxyy).
        /// </summary>
        public dvec5 bbrgg => new dvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.zzxyz swizzling.
        /// </summary>
        public dvec5 zzxyz => new dvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.bbrgb swizzling (equivalent to dvec4.zzxyz).
        /// </summary>
        public dvec5 bbrgb => new dvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.zzxyw swizzling.
        /// </summary>
        public dvec5 zzxyw => new dvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.bbrga swizzling (equivalent to dvec4.zzxyw).
        /// </summary>
        public dvec5 bbrga => new dvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.zzxz swizzling.
        /// </summary>
        public dvec4 zzxz => new dvec4(z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.bbrb swizzling (equivalent to dvec4.zzxz).
        /// </summary>
        public dvec4 bbrb => new dvec4(z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.zzxzx swizzling.
        /// </summary>
        public dvec5 zzxzx => new dvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.bbrbr swizzling (equivalent to dvec4.zzxzx).
        /// </summary>
        public dvec5 bbrbr => new dvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.zzxzy swizzling.
        /// </summary>
        public dvec5 zzxzy => new dvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.bbrbg swizzling (equivalent to dvec4.zzxzy).
        /// </summary>
        public dvec5 bbrbg => new dvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.zzxzz swizzling.
        /// </summary>
        public dvec5 zzxzz => new dvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.bbrbb swizzling (equivalent to dvec4.zzxzz).
        /// </summary>
        public dvec5 bbrbb => new dvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.zzxzw swizzling.
        /// </summary>
        public dvec5 zzxzw => new dvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.bbrba swizzling (equivalent to dvec4.zzxzw).
        /// </summary>
        public dvec5 bbrba => new dvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.zzxw swizzling.
        /// </summary>
        public dvec4 zzxw => new dvec4(z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.bbra swizzling (equivalent to dvec4.zzxw).
        /// </summary>
        public dvec4 bbra => new dvec4(z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.zzxwx swizzling.
        /// </summary>
        public dvec5 zzxwx => new dvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.bbrar swizzling (equivalent to dvec4.zzxwx).
        /// </summary>
        public dvec5 bbrar => new dvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.zzxwy swizzling.
        /// </summary>
        public dvec5 zzxwy => new dvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.bbrag swizzling (equivalent to dvec4.zzxwy).
        /// </summary>
        public dvec5 bbrag => new dvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.zzxwz swizzling.
        /// </summary>
        public dvec5 zzxwz => new dvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.bbrab swizzling (equivalent to dvec4.zzxwz).
        /// </summary>
        public dvec5 bbrab => new dvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.zzxww swizzling.
        /// </summary>
        public dvec5 zzxww => new dvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.bbraa swizzling (equivalent to dvec4.zzxww).
        /// </summary>
        public dvec5 bbraa => new dvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.zzy swizzling.
        /// </summary>
        public dvec3 zzy => new dvec3(z, z, y);
        
        /// <summary>
        /// Returns dvec4.bbg swizzling (equivalent to dvec4.zzy).
        /// </summary>
        public dvec3 bbg => new dvec3(z, z, y);
        
        /// <summary>
        /// Returns dvec4.zzyx swizzling.
        /// </summary>
        public dvec4 zzyx => new dvec4(z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.bbgr swizzling (equivalent to dvec4.zzyx).
        /// </summary>
        public dvec4 bbgr => new dvec4(z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.zzyxx swizzling.
        /// </summary>
        public dvec5 zzyxx => new dvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.bbgrr swizzling (equivalent to dvec4.zzyxx).
        /// </summary>
        public dvec5 bbgrr => new dvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.zzyxy swizzling.
        /// </summary>
        public dvec5 zzyxy => new dvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.bbgrg swizzling (equivalent to dvec4.zzyxy).
        /// </summary>
        public dvec5 bbgrg => new dvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.zzyxz swizzling.
        /// </summary>
        public dvec5 zzyxz => new dvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.bbgrb swizzling (equivalent to dvec4.zzyxz).
        /// </summary>
        public dvec5 bbgrb => new dvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.zzyxw swizzling.
        /// </summary>
        public dvec5 zzyxw => new dvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.bbgra swizzling (equivalent to dvec4.zzyxw).
        /// </summary>
        public dvec5 bbgra => new dvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.zzyy swizzling.
        /// </summary>
        public dvec4 zzyy => new dvec4(z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.bbgg swizzling (equivalent to dvec4.zzyy).
        /// </summary>
        public dvec4 bbgg => new dvec4(z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.zzyyx swizzling.
        /// </summary>
        public dvec5 zzyyx => new dvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.bbggr swizzling (equivalent to dvec4.zzyyx).
        /// </summary>
        public dvec5 bbggr => new dvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.zzyyy swizzling.
        /// </summary>
        public dvec5 zzyyy => new dvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.bbggg swizzling (equivalent to dvec4.zzyyy).
        /// </summary>
        public dvec5 bbggg => new dvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.zzyyz swizzling.
        /// </summary>
        public dvec5 zzyyz => new dvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.bbggb swizzling (equivalent to dvec4.zzyyz).
        /// </summary>
        public dvec5 bbggb => new dvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.zzyyw swizzling.
        /// </summary>
        public dvec5 zzyyw => new dvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.bbgga swizzling (equivalent to dvec4.zzyyw).
        /// </summary>
        public dvec5 bbgga => new dvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.zzyz swizzling.
        /// </summary>
        public dvec4 zzyz => new dvec4(z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.bbgb swizzling (equivalent to dvec4.zzyz).
        /// </summary>
        public dvec4 bbgb => new dvec4(z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.zzyzx swizzling.
        /// </summary>
        public dvec5 zzyzx => new dvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.bbgbr swizzling (equivalent to dvec4.zzyzx).
        /// </summary>
        public dvec5 bbgbr => new dvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.zzyzy swizzling.
        /// </summary>
        public dvec5 zzyzy => new dvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.bbgbg swizzling (equivalent to dvec4.zzyzy).
        /// </summary>
        public dvec5 bbgbg => new dvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.zzyzz swizzling.
        /// </summary>
        public dvec5 zzyzz => new dvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.bbgbb swizzling (equivalent to dvec4.zzyzz).
        /// </summary>
        public dvec5 bbgbb => new dvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.zzyzw swizzling.
        /// </summary>
        public dvec5 zzyzw => new dvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.bbgba swizzling (equivalent to dvec4.zzyzw).
        /// </summary>
        public dvec5 bbgba => new dvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.zzyw swizzling.
        /// </summary>
        public dvec4 zzyw => new dvec4(z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.bbga swizzling (equivalent to dvec4.zzyw).
        /// </summary>
        public dvec4 bbga => new dvec4(z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.zzywx swizzling.
        /// </summary>
        public dvec5 zzywx => new dvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.bbgar swizzling (equivalent to dvec4.zzywx).
        /// </summary>
        public dvec5 bbgar => new dvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.zzywy swizzling.
        /// </summary>
        public dvec5 zzywy => new dvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.bbgag swizzling (equivalent to dvec4.zzywy).
        /// </summary>
        public dvec5 bbgag => new dvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.zzywz swizzling.
        /// </summary>
        public dvec5 zzywz => new dvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.bbgab swizzling (equivalent to dvec4.zzywz).
        /// </summary>
        public dvec5 bbgab => new dvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.zzyww swizzling.
        /// </summary>
        public dvec5 zzyww => new dvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.bbgaa swizzling (equivalent to dvec4.zzyww).
        /// </summary>
        public dvec5 bbgaa => new dvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.zzz swizzling.
        /// </summary>
        public dvec3 zzz => new dvec3(z, z, z);
        
        /// <summary>
        /// Returns dvec4.bbb swizzling (equivalent to dvec4.zzz).
        /// </summary>
        public dvec3 bbb => new dvec3(z, z, z);
        
        /// <summary>
        /// Returns dvec4.zzzx swizzling.
        /// </summary>
        public dvec4 zzzx => new dvec4(z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.bbbr swizzling (equivalent to dvec4.zzzx).
        /// </summary>
        public dvec4 bbbr => new dvec4(z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.zzzxx swizzling.
        /// </summary>
        public dvec5 zzzxx => new dvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.bbbrr swizzling (equivalent to dvec4.zzzxx).
        /// </summary>
        public dvec5 bbbrr => new dvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.zzzxy swizzling.
        /// </summary>
        public dvec5 zzzxy => new dvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.bbbrg swizzling (equivalent to dvec4.zzzxy).
        /// </summary>
        public dvec5 bbbrg => new dvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.zzzxz swizzling.
        /// </summary>
        public dvec5 zzzxz => new dvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.bbbrb swizzling (equivalent to dvec4.zzzxz).
        /// </summary>
        public dvec5 bbbrb => new dvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.zzzxw swizzling.
        /// </summary>
        public dvec5 zzzxw => new dvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.bbbra swizzling (equivalent to dvec4.zzzxw).
        /// </summary>
        public dvec5 bbbra => new dvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.zzzy swizzling.
        /// </summary>
        public dvec4 zzzy => new dvec4(z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.bbbg swizzling (equivalent to dvec4.zzzy).
        /// </summary>
        public dvec4 bbbg => new dvec4(z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.zzzyx swizzling.
        /// </summary>
        public dvec5 zzzyx => new dvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.bbbgr swizzling (equivalent to dvec4.zzzyx).
        /// </summary>
        public dvec5 bbbgr => new dvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.zzzyy swizzling.
        /// </summary>
        public dvec5 zzzyy => new dvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.bbbgg swizzling (equivalent to dvec4.zzzyy).
        /// </summary>
        public dvec5 bbbgg => new dvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.zzzyz swizzling.
        /// </summary>
        public dvec5 zzzyz => new dvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.bbbgb swizzling (equivalent to dvec4.zzzyz).
        /// </summary>
        public dvec5 bbbgb => new dvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.zzzyw swizzling.
        /// </summary>
        public dvec5 zzzyw => new dvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.bbbga swizzling (equivalent to dvec4.zzzyw).
        /// </summary>
        public dvec5 bbbga => new dvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.zzzz swizzling.
        /// </summary>
        public dvec4 zzzz => new dvec4(z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.bbbb swizzling (equivalent to dvec4.zzzz).
        /// </summary>
        public dvec4 bbbb => new dvec4(z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.zzzzx swizzling.
        /// </summary>
        public dvec5 zzzzx => new dvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.bbbbr swizzling (equivalent to dvec4.zzzzx).
        /// </summary>
        public dvec5 bbbbr => new dvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.zzzzy swizzling.
        /// </summary>
        public dvec5 zzzzy => new dvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.bbbbg swizzling (equivalent to dvec4.zzzzy).
        /// </summary>
        public dvec5 bbbbg => new dvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.zzzzz swizzling.
        /// </summary>
        public dvec5 zzzzz => new dvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.bbbbb swizzling (equivalent to dvec4.zzzzz).
        /// </summary>
        public dvec5 bbbbb => new dvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.zzzzw swizzling.
        /// </summary>
        public dvec5 zzzzw => new dvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.bbbba swizzling (equivalent to dvec4.zzzzw).
        /// </summary>
        public dvec5 bbbba => new dvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.zzzw swizzling.
        /// </summary>
        public dvec4 zzzw => new dvec4(z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.bbba swizzling (equivalent to dvec4.zzzw).
        /// </summary>
        public dvec4 bbba => new dvec4(z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.zzzwx swizzling.
        /// </summary>
        public dvec5 zzzwx => new dvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.bbbar swizzling (equivalent to dvec4.zzzwx).
        /// </summary>
        public dvec5 bbbar => new dvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.zzzwy swizzling.
        /// </summary>
        public dvec5 zzzwy => new dvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.bbbag swizzling (equivalent to dvec4.zzzwy).
        /// </summary>
        public dvec5 bbbag => new dvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.zzzwz swizzling.
        /// </summary>
        public dvec5 zzzwz => new dvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.bbbab swizzling (equivalent to dvec4.zzzwz).
        /// </summary>
        public dvec5 bbbab => new dvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.zzzww swizzling.
        /// </summary>
        public dvec5 zzzww => new dvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.bbbaa swizzling (equivalent to dvec4.zzzww).
        /// </summary>
        public dvec5 bbbaa => new dvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.zzw swizzling.
        /// </summary>
        public dvec3 zzw => new dvec3(z, z, w);
        
        /// <summary>
        /// Returns dvec4.bba swizzling (equivalent to dvec4.zzw).
        /// </summary>
        public dvec3 bba => new dvec3(z, z, w);
        
        /// <summary>
        /// Returns dvec4.zzwx swizzling.
        /// </summary>
        public dvec4 zzwx => new dvec4(z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.bbar swizzling (equivalent to dvec4.zzwx).
        /// </summary>
        public dvec4 bbar => new dvec4(z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.zzwxx swizzling.
        /// </summary>
        public dvec5 zzwxx => new dvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.bbarr swizzling (equivalent to dvec4.zzwxx).
        /// </summary>
        public dvec5 bbarr => new dvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.zzwxy swizzling.
        /// </summary>
        public dvec5 zzwxy => new dvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.bbarg swizzling (equivalent to dvec4.zzwxy).
        /// </summary>
        public dvec5 bbarg => new dvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.zzwxz swizzling.
        /// </summary>
        public dvec5 zzwxz => new dvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.bbarb swizzling (equivalent to dvec4.zzwxz).
        /// </summary>
        public dvec5 bbarb => new dvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.zzwxw swizzling.
        /// </summary>
        public dvec5 zzwxw => new dvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.bbara swizzling (equivalent to dvec4.zzwxw).
        /// </summary>
        public dvec5 bbara => new dvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.zzwy swizzling.
        /// </summary>
        public dvec4 zzwy => new dvec4(z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.bbag swizzling (equivalent to dvec4.zzwy).
        /// </summary>
        public dvec4 bbag => new dvec4(z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.zzwyx swizzling.
        /// </summary>
        public dvec5 zzwyx => new dvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.bbagr swizzling (equivalent to dvec4.zzwyx).
        /// </summary>
        public dvec5 bbagr => new dvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.zzwyy swizzling.
        /// </summary>
        public dvec5 zzwyy => new dvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.bbagg swizzling (equivalent to dvec4.zzwyy).
        /// </summary>
        public dvec5 bbagg => new dvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.zzwyz swizzling.
        /// </summary>
        public dvec5 zzwyz => new dvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.bbagb swizzling (equivalent to dvec4.zzwyz).
        /// </summary>
        public dvec5 bbagb => new dvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.zzwyw swizzling.
        /// </summary>
        public dvec5 zzwyw => new dvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.bbaga swizzling (equivalent to dvec4.zzwyw).
        /// </summary>
        public dvec5 bbaga => new dvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.zzwz swizzling.
        /// </summary>
        public dvec4 zzwz => new dvec4(z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.bbab swizzling (equivalent to dvec4.zzwz).
        /// </summary>
        public dvec4 bbab => new dvec4(z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.zzwzx swizzling.
        /// </summary>
        public dvec5 zzwzx => new dvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.bbabr swizzling (equivalent to dvec4.zzwzx).
        /// </summary>
        public dvec5 bbabr => new dvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.zzwzy swizzling.
        /// </summary>
        public dvec5 zzwzy => new dvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.bbabg swizzling (equivalent to dvec4.zzwzy).
        /// </summary>
        public dvec5 bbabg => new dvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.zzwzz swizzling.
        /// </summary>
        public dvec5 zzwzz => new dvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.bbabb swizzling (equivalent to dvec4.zzwzz).
        /// </summary>
        public dvec5 bbabb => new dvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.zzwzw swizzling.
        /// </summary>
        public dvec5 zzwzw => new dvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.bbaba swizzling (equivalent to dvec4.zzwzw).
        /// </summary>
        public dvec5 bbaba => new dvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.zzww swizzling.
        /// </summary>
        public dvec4 zzww => new dvec4(z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.bbaa swizzling (equivalent to dvec4.zzww).
        /// </summary>
        public dvec4 bbaa => new dvec4(z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.zzwwx swizzling.
        /// </summary>
        public dvec5 zzwwx => new dvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.bbaar swizzling (equivalent to dvec4.zzwwx).
        /// </summary>
        public dvec5 bbaar => new dvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.zzwwy swizzling.
        /// </summary>
        public dvec5 zzwwy => new dvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.bbaag swizzling (equivalent to dvec4.zzwwy).
        /// </summary>
        public dvec5 bbaag => new dvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.zzwwz swizzling.
        /// </summary>
        public dvec5 zzwwz => new dvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.bbaab swizzling (equivalent to dvec4.zzwwz).
        /// </summary>
        public dvec5 bbaab => new dvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.zzwww swizzling.
        /// </summary>
        public dvec5 zzwww => new dvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.bbaaa swizzling (equivalent to dvec4.zzwww).
        /// </summary>
        public dvec5 bbaaa => new dvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.zw swizzling.
        /// </summary>
        public dvec2 zw => new dvec2(z, w);
        
        /// <summary>
        /// Returns dvec4.ba swizzling (equivalent to dvec4.zw).
        /// </summary>
        public dvec2 ba => new dvec2(z, w);
        
        /// <summary>
        /// Returns dvec4.zwx swizzling.
        /// </summary>
        public dvec3 zwx => new dvec3(z, w, x);
        
        /// <summary>
        /// Returns dvec4.bar swizzling (equivalent to dvec4.zwx).
        /// </summary>
        public dvec3 bar => new dvec3(z, w, x);
        
        /// <summary>
        /// Returns dvec4.zwxx swizzling.
        /// </summary>
        public dvec4 zwxx => new dvec4(z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.barr swizzling (equivalent to dvec4.zwxx).
        /// </summary>
        public dvec4 barr => new dvec4(z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.zwxxx swizzling.
        /// </summary>
        public dvec5 zwxxx => new dvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.barrr swizzling (equivalent to dvec4.zwxxx).
        /// </summary>
        public dvec5 barrr => new dvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.zwxxy swizzling.
        /// </summary>
        public dvec5 zwxxy => new dvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.barrg swizzling (equivalent to dvec4.zwxxy).
        /// </summary>
        public dvec5 barrg => new dvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.zwxxz swizzling.
        /// </summary>
        public dvec5 zwxxz => new dvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.barrb swizzling (equivalent to dvec4.zwxxz).
        /// </summary>
        public dvec5 barrb => new dvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.zwxxw swizzling.
        /// </summary>
        public dvec5 zwxxw => new dvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.barra swizzling (equivalent to dvec4.zwxxw).
        /// </summary>
        public dvec5 barra => new dvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.zwxy swizzling.
        /// </summary>
        public dvec4 zwxy => new dvec4(z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.barg swizzling (equivalent to dvec4.zwxy).
        /// </summary>
        public dvec4 barg => new dvec4(z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.zwxyx swizzling.
        /// </summary>
        public dvec5 zwxyx => new dvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.bargr swizzling (equivalent to dvec4.zwxyx).
        /// </summary>
        public dvec5 bargr => new dvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.zwxyy swizzling.
        /// </summary>
        public dvec5 zwxyy => new dvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.bargg swizzling (equivalent to dvec4.zwxyy).
        /// </summary>
        public dvec5 bargg => new dvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.zwxyz swizzling.
        /// </summary>
        public dvec5 zwxyz => new dvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.bargb swizzling (equivalent to dvec4.zwxyz).
        /// </summary>
        public dvec5 bargb => new dvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.zwxyw swizzling.
        /// </summary>
        public dvec5 zwxyw => new dvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.barga swizzling (equivalent to dvec4.zwxyw).
        /// </summary>
        public dvec5 barga => new dvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.zwxz swizzling.
        /// </summary>
        public dvec4 zwxz => new dvec4(z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.barb swizzling (equivalent to dvec4.zwxz).
        /// </summary>
        public dvec4 barb => new dvec4(z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.zwxzx swizzling.
        /// </summary>
        public dvec5 zwxzx => new dvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.barbr swizzling (equivalent to dvec4.zwxzx).
        /// </summary>
        public dvec5 barbr => new dvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.zwxzy swizzling.
        /// </summary>
        public dvec5 zwxzy => new dvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.barbg swizzling (equivalent to dvec4.zwxzy).
        /// </summary>
        public dvec5 barbg => new dvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.zwxzz swizzling.
        /// </summary>
        public dvec5 zwxzz => new dvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.barbb swizzling (equivalent to dvec4.zwxzz).
        /// </summary>
        public dvec5 barbb => new dvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.zwxzw swizzling.
        /// </summary>
        public dvec5 zwxzw => new dvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.barba swizzling (equivalent to dvec4.zwxzw).
        /// </summary>
        public dvec5 barba => new dvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.zwxw swizzling.
        /// </summary>
        public dvec4 zwxw => new dvec4(z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.bara swizzling (equivalent to dvec4.zwxw).
        /// </summary>
        public dvec4 bara => new dvec4(z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.zwxwx swizzling.
        /// </summary>
        public dvec5 zwxwx => new dvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.barar swizzling (equivalent to dvec4.zwxwx).
        /// </summary>
        public dvec5 barar => new dvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.zwxwy swizzling.
        /// </summary>
        public dvec5 zwxwy => new dvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.barag swizzling (equivalent to dvec4.zwxwy).
        /// </summary>
        public dvec5 barag => new dvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.zwxwz swizzling.
        /// </summary>
        public dvec5 zwxwz => new dvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.barab swizzling (equivalent to dvec4.zwxwz).
        /// </summary>
        public dvec5 barab => new dvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.zwxww swizzling.
        /// </summary>
        public dvec5 zwxww => new dvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.baraa swizzling (equivalent to dvec4.zwxww).
        /// </summary>
        public dvec5 baraa => new dvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.zwy swizzling.
        /// </summary>
        public dvec3 zwy => new dvec3(z, w, y);
        
        /// <summary>
        /// Returns dvec4.bag swizzling (equivalent to dvec4.zwy).
        /// </summary>
        public dvec3 bag => new dvec3(z, w, y);
        
        /// <summary>
        /// Returns dvec4.zwyx swizzling.
        /// </summary>
        public dvec4 zwyx => new dvec4(z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.bagr swizzling (equivalent to dvec4.zwyx).
        /// </summary>
        public dvec4 bagr => new dvec4(z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.zwyxx swizzling.
        /// </summary>
        public dvec5 zwyxx => new dvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.bagrr swizzling (equivalent to dvec4.zwyxx).
        /// </summary>
        public dvec5 bagrr => new dvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.zwyxy swizzling.
        /// </summary>
        public dvec5 zwyxy => new dvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.bagrg swizzling (equivalent to dvec4.zwyxy).
        /// </summary>
        public dvec5 bagrg => new dvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.zwyxz swizzling.
        /// </summary>
        public dvec5 zwyxz => new dvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.bagrb swizzling (equivalent to dvec4.zwyxz).
        /// </summary>
        public dvec5 bagrb => new dvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.zwyxw swizzling.
        /// </summary>
        public dvec5 zwyxw => new dvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.bagra swizzling (equivalent to dvec4.zwyxw).
        /// </summary>
        public dvec5 bagra => new dvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.zwyy swizzling.
        /// </summary>
        public dvec4 zwyy => new dvec4(z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.bagg swizzling (equivalent to dvec4.zwyy).
        /// </summary>
        public dvec4 bagg => new dvec4(z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.zwyyx swizzling.
        /// </summary>
        public dvec5 zwyyx => new dvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.baggr swizzling (equivalent to dvec4.zwyyx).
        /// </summary>
        public dvec5 baggr => new dvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.zwyyy swizzling.
        /// </summary>
        public dvec5 zwyyy => new dvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.baggg swizzling (equivalent to dvec4.zwyyy).
        /// </summary>
        public dvec5 baggg => new dvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.zwyyz swizzling.
        /// </summary>
        public dvec5 zwyyz => new dvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.baggb swizzling (equivalent to dvec4.zwyyz).
        /// </summary>
        public dvec5 baggb => new dvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.zwyyw swizzling.
        /// </summary>
        public dvec5 zwyyw => new dvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.bagga swizzling (equivalent to dvec4.zwyyw).
        /// </summary>
        public dvec5 bagga => new dvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.zwyz swizzling.
        /// </summary>
        public dvec4 zwyz => new dvec4(z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.bagb swizzling (equivalent to dvec4.zwyz).
        /// </summary>
        public dvec4 bagb => new dvec4(z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.zwyzx swizzling.
        /// </summary>
        public dvec5 zwyzx => new dvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.bagbr swizzling (equivalent to dvec4.zwyzx).
        /// </summary>
        public dvec5 bagbr => new dvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.zwyzy swizzling.
        /// </summary>
        public dvec5 zwyzy => new dvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.bagbg swizzling (equivalent to dvec4.zwyzy).
        /// </summary>
        public dvec5 bagbg => new dvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.zwyzz swizzling.
        /// </summary>
        public dvec5 zwyzz => new dvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.bagbb swizzling (equivalent to dvec4.zwyzz).
        /// </summary>
        public dvec5 bagbb => new dvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.zwyzw swizzling.
        /// </summary>
        public dvec5 zwyzw => new dvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.bagba swizzling (equivalent to dvec4.zwyzw).
        /// </summary>
        public dvec5 bagba => new dvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.zwyw swizzling.
        /// </summary>
        public dvec4 zwyw => new dvec4(z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.baga swizzling (equivalent to dvec4.zwyw).
        /// </summary>
        public dvec4 baga => new dvec4(z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.zwywx swizzling.
        /// </summary>
        public dvec5 zwywx => new dvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.bagar swizzling (equivalent to dvec4.zwywx).
        /// </summary>
        public dvec5 bagar => new dvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.zwywy swizzling.
        /// </summary>
        public dvec5 zwywy => new dvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.bagag swizzling (equivalent to dvec4.zwywy).
        /// </summary>
        public dvec5 bagag => new dvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.zwywz swizzling.
        /// </summary>
        public dvec5 zwywz => new dvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.bagab swizzling (equivalent to dvec4.zwywz).
        /// </summary>
        public dvec5 bagab => new dvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.zwyww swizzling.
        /// </summary>
        public dvec5 zwyww => new dvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.bagaa swizzling (equivalent to dvec4.zwyww).
        /// </summary>
        public dvec5 bagaa => new dvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.zwz swizzling.
        /// </summary>
        public dvec3 zwz => new dvec3(z, w, z);
        
        /// <summary>
        /// Returns dvec4.bab swizzling (equivalent to dvec4.zwz).
        /// </summary>
        public dvec3 bab => new dvec3(z, w, z);
        
        /// <summary>
        /// Returns dvec4.zwzx swizzling.
        /// </summary>
        public dvec4 zwzx => new dvec4(z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.babr swizzling (equivalent to dvec4.zwzx).
        /// </summary>
        public dvec4 babr => new dvec4(z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.zwzxx swizzling.
        /// </summary>
        public dvec5 zwzxx => new dvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.babrr swizzling (equivalent to dvec4.zwzxx).
        /// </summary>
        public dvec5 babrr => new dvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.zwzxy swizzling.
        /// </summary>
        public dvec5 zwzxy => new dvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.babrg swizzling (equivalent to dvec4.zwzxy).
        /// </summary>
        public dvec5 babrg => new dvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.zwzxz swizzling.
        /// </summary>
        public dvec5 zwzxz => new dvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.babrb swizzling (equivalent to dvec4.zwzxz).
        /// </summary>
        public dvec5 babrb => new dvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.zwzxw swizzling.
        /// </summary>
        public dvec5 zwzxw => new dvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.babra swizzling (equivalent to dvec4.zwzxw).
        /// </summary>
        public dvec5 babra => new dvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.zwzy swizzling.
        /// </summary>
        public dvec4 zwzy => new dvec4(z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.babg swizzling (equivalent to dvec4.zwzy).
        /// </summary>
        public dvec4 babg => new dvec4(z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.zwzyx swizzling.
        /// </summary>
        public dvec5 zwzyx => new dvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.babgr swizzling (equivalent to dvec4.zwzyx).
        /// </summary>
        public dvec5 babgr => new dvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.zwzyy swizzling.
        /// </summary>
        public dvec5 zwzyy => new dvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.babgg swizzling (equivalent to dvec4.zwzyy).
        /// </summary>
        public dvec5 babgg => new dvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.zwzyz swizzling.
        /// </summary>
        public dvec5 zwzyz => new dvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.babgb swizzling (equivalent to dvec4.zwzyz).
        /// </summary>
        public dvec5 babgb => new dvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.zwzyw swizzling.
        /// </summary>
        public dvec5 zwzyw => new dvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.babga swizzling (equivalent to dvec4.zwzyw).
        /// </summary>
        public dvec5 babga => new dvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.zwzz swizzling.
        /// </summary>
        public dvec4 zwzz => new dvec4(z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.babb swizzling (equivalent to dvec4.zwzz).
        /// </summary>
        public dvec4 babb => new dvec4(z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.zwzzx swizzling.
        /// </summary>
        public dvec5 zwzzx => new dvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.babbr swizzling (equivalent to dvec4.zwzzx).
        /// </summary>
        public dvec5 babbr => new dvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.zwzzy swizzling.
        /// </summary>
        public dvec5 zwzzy => new dvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.babbg swizzling (equivalent to dvec4.zwzzy).
        /// </summary>
        public dvec5 babbg => new dvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.zwzzz swizzling.
        /// </summary>
        public dvec5 zwzzz => new dvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.babbb swizzling (equivalent to dvec4.zwzzz).
        /// </summary>
        public dvec5 babbb => new dvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.zwzzw swizzling.
        /// </summary>
        public dvec5 zwzzw => new dvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.babba swizzling (equivalent to dvec4.zwzzw).
        /// </summary>
        public dvec5 babba => new dvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.zwzw swizzling.
        /// </summary>
        public dvec4 zwzw => new dvec4(z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.baba swizzling (equivalent to dvec4.zwzw).
        /// </summary>
        public dvec4 baba => new dvec4(z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.zwzwx swizzling.
        /// </summary>
        public dvec5 zwzwx => new dvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.babar swizzling (equivalent to dvec4.zwzwx).
        /// </summary>
        public dvec5 babar => new dvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.zwzwy swizzling.
        /// </summary>
        public dvec5 zwzwy => new dvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.babag swizzling (equivalent to dvec4.zwzwy).
        /// </summary>
        public dvec5 babag => new dvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.zwzwz swizzling.
        /// </summary>
        public dvec5 zwzwz => new dvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.babab swizzling (equivalent to dvec4.zwzwz).
        /// </summary>
        public dvec5 babab => new dvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.zwzww swizzling.
        /// </summary>
        public dvec5 zwzww => new dvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.babaa swizzling (equivalent to dvec4.zwzww).
        /// </summary>
        public dvec5 babaa => new dvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.zww swizzling.
        /// </summary>
        public dvec3 zww => new dvec3(z, w, w);
        
        /// <summary>
        /// Returns dvec4.baa swizzling (equivalent to dvec4.zww).
        /// </summary>
        public dvec3 baa => new dvec3(z, w, w);
        
        /// <summary>
        /// Returns dvec4.zwwx swizzling.
        /// </summary>
        public dvec4 zwwx => new dvec4(z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.baar swizzling (equivalent to dvec4.zwwx).
        /// </summary>
        public dvec4 baar => new dvec4(z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.zwwxx swizzling.
        /// </summary>
        public dvec5 zwwxx => new dvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.baarr swizzling (equivalent to dvec4.zwwxx).
        /// </summary>
        public dvec5 baarr => new dvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.zwwxy swizzling.
        /// </summary>
        public dvec5 zwwxy => new dvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.baarg swizzling (equivalent to dvec4.zwwxy).
        /// </summary>
        public dvec5 baarg => new dvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.zwwxz swizzling.
        /// </summary>
        public dvec5 zwwxz => new dvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.baarb swizzling (equivalent to dvec4.zwwxz).
        /// </summary>
        public dvec5 baarb => new dvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.zwwxw swizzling.
        /// </summary>
        public dvec5 zwwxw => new dvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.baara swizzling (equivalent to dvec4.zwwxw).
        /// </summary>
        public dvec5 baara => new dvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.zwwy swizzling.
        /// </summary>
        public dvec4 zwwy => new dvec4(z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.baag swizzling (equivalent to dvec4.zwwy).
        /// </summary>
        public dvec4 baag => new dvec4(z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.zwwyx swizzling.
        /// </summary>
        public dvec5 zwwyx => new dvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.baagr swizzling (equivalent to dvec4.zwwyx).
        /// </summary>
        public dvec5 baagr => new dvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.zwwyy swizzling.
        /// </summary>
        public dvec5 zwwyy => new dvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.baagg swizzling (equivalent to dvec4.zwwyy).
        /// </summary>
        public dvec5 baagg => new dvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.zwwyz swizzling.
        /// </summary>
        public dvec5 zwwyz => new dvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.baagb swizzling (equivalent to dvec4.zwwyz).
        /// </summary>
        public dvec5 baagb => new dvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.zwwyw swizzling.
        /// </summary>
        public dvec5 zwwyw => new dvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.baaga swizzling (equivalent to dvec4.zwwyw).
        /// </summary>
        public dvec5 baaga => new dvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.zwwz swizzling.
        /// </summary>
        public dvec4 zwwz => new dvec4(z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.baab swizzling (equivalent to dvec4.zwwz).
        /// </summary>
        public dvec4 baab => new dvec4(z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.zwwzx swizzling.
        /// </summary>
        public dvec5 zwwzx => new dvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.baabr swizzling (equivalent to dvec4.zwwzx).
        /// </summary>
        public dvec5 baabr => new dvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.zwwzy swizzling.
        /// </summary>
        public dvec5 zwwzy => new dvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.baabg swizzling (equivalent to dvec4.zwwzy).
        /// </summary>
        public dvec5 baabg => new dvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.zwwzz swizzling.
        /// </summary>
        public dvec5 zwwzz => new dvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.baabb swizzling (equivalent to dvec4.zwwzz).
        /// </summary>
        public dvec5 baabb => new dvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.zwwzw swizzling.
        /// </summary>
        public dvec5 zwwzw => new dvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.baaba swizzling (equivalent to dvec4.zwwzw).
        /// </summary>
        public dvec5 baaba => new dvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.zwww swizzling.
        /// </summary>
        public dvec4 zwww => new dvec4(z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.baaa swizzling (equivalent to dvec4.zwww).
        /// </summary>
        public dvec4 baaa => new dvec4(z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.zwwwx swizzling.
        /// </summary>
        public dvec5 zwwwx => new dvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.baaar swizzling (equivalent to dvec4.zwwwx).
        /// </summary>
        public dvec5 baaar => new dvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.zwwwy swizzling.
        /// </summary>
        public dvec5 zwwwy => new dvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.baaag swizzling (equivalent to dvec4.zwwwy).
        /// </summary>
        public dvec5 baaag => new dvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.zwwwz swizzling.
        /// </summary>
        public dvec5 zwwwz => new dvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.baaab swizzling (equivalent to dvec4.zwwwz).
        /// </summary>
        public dvec5 baaab => new dvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.zwwww swizzling.
        /// </summary>
        public dvec5 zwwww => new dvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns dvec4.baaaa swizzling (equivalent to dvec4.zwwww).
        /// </summary>
        public dvec5 baaaa => new dvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns dvec4.wx swizzling.
        /// </summary>
        public dvec2 wx => new dvec2(w, x);
        
        /// <summary>
        /// Returns dvec4.ar swizzling (equivalent to dvec4.wx).
        /// </summary>
        public dvec2 ar => new dvec2(w, x);
        
        /// <summary>
        /// Returns dvec4.wxx swizzling.
        /// </summary>
        public dvec3 wxx => new dvec3(w, x, x);
        
        /// <summary>
        /// Returns dvec4.arr swizzling (equivalent to dvec4.wxx).
        /// </summary>
        public dvec3 arr => new dvec3(w, x, x);
        
        /// <summary>
        /// Returns dvec4.wxxx swizzling.
        /// </summary>
        public dvec4 wxxx => new dvec4(w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.arrr swizzling (equivalent to dvec4.wxxx).
        /// </summary>
        public dvec4 arrr => new dvec4(w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.wxxxx swizzling.
        /// </summary>
        public dvec5 wxxxx => new dvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.arrrr swizzling (equivalent to dvec4.wxxxx).
        /// </summary>
        public dvec5 arrrr => new dvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.wxxxy swizzling.
        /// </summary>
        public dvec5 wxxxy => new dvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.arrrg swizzling (equivalent to dvec4.wxxxy).
        /// </summary>
        public dvec5 arrrg => new dvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.wxxxz swizzling.
        /// </summary>
        public dvec5 wxxxz => new dvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.arrrb swizzling (equivalent to dvec4.wxxxz).
        /// </summary>
        public dvec5 arrrb => new dvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.wxxxw swizzling.
        /// </summary>
        public dvec5 wxxxw => new dvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.arrra swizzling (equivalent to dvec4.wxxxw).
        /// </summary>
        public dvec5 arrra => new dvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.wxxy swizzling.
        /// </summary>
        public dvec4 wxxy => new dvec4(w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.arrg swizzling (equivalent to dvec4.wxxy).
        /// </summary>
        public dvec4 arrg => new dvec4(w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.wxxyx swizzling.
        /// </summary>
        public dvec5 wxxyx => new dvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.arrgr swizzling (equivalent to dvec4.wxxyx).
        /// </summary>
        public dvec5 arrgr => new dvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.wxxyy swizzling.
        /// </summary>
        public dvec5 wxxyy => new dvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.arrgg swizzling (equivalent to dvec4.wxxyy).
        /// </summary>
        public dvec5 arrgg => new dvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.wxxyz swizzling.
        /// </summary>
        public dvec5 wxxyz => new dvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.arrgb swizzling (equivalent to dvec4.wxxyz).
        /// </summary>
        public dvec5 arrgb => new dvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.wxxyw swizzling.
        /// </summary>
        public dvec5 wxxyw => new dvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.arrga swizzling (equivalent to dvec4.wxxyw).
        /// </summary>
        public dvec5 arrga => new dvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.wxxz swizzling.
        /// </summary>
        public dvec4 wxxz => new dvec4(w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.arrb swizzling (equivalent to dvec4.wxxz).
        /// </summary>
        public dvec4 arrb => new dvec4(w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.wxxzx swizzling.
        /// </summary>
        public dvec5 wxxzx => new dvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.arrbr swizzling (equivalent to dvec4.wxxzx).
        /// </summary>
        public dvec5 arrbr => new dvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.wxxzy swizzling.
        /// </summary>
        public dvec5 wxxzy => new dvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.arrbg swizzling (equivalent to dvec4.wxxzy).
        /// </summary>
        public dvec5 arrbg => new dvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.wxxzz swizzling.
        /// </summary>
        public dvec5 wxxzz => new dvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.arrbb swizzling (equivalent to dvec4.wxxzz).
        /// </summary>
        public dvec5 arrbb => new dvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.wxxzw swizzling.
        /// </summary>
        public dvec5 wxxzw => new dvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.arrba swizzling (equivalent to dvec4.wxxzw).
        /// </summary>
        public dvec5 arrba => new dvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.wxxw swizzling.
        /// </summary>
        public dvec4 wxxw => new dvec4(w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.arra swizzling (equivalent to dvec4.wxxw).
        /// </summary>
        public dvec4 arra => new dvec4(w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.wxxwx swizzling.
        /// </summary>
        public dvec5 wxxwx => new dvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.arrar swizzling (equivalent to dvec4.wxxwx).
        /// </summary>
        public dvec5 arrar => new dvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.wxxwy swizzling.
        /// </summary>
        public dvec5 wxxwy => new dvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.arrag swizzling (equivalent to dvec4.wxxwy).
        /// </summary>
        public dvec5 arrag => new dvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.wxxwz swizzling.
        /// </summary>
        public dvec5 wxxwz => new dvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.arrab swizzling (equivalent to dvec4.wxxwz).
        /// </summary>
        public dvec5 arrab => new dvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.wxxww swizzling.
        /// </summary>
        public dvec5 wxxww => new dvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.arraa swizzling (equivalent to dvec4.wxxww).
        /// </summary>
        public dvec5 arraa => new dvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.wxy swizzling.
        /// </summary>
        public dvec3 wxy => new dvec3(w, x, y);
        
        /// <summary>
        /// Returns dvec4.arg swizzling (equivalent to dvec4.wxy).
        /// </summary>
        public dvec3 arg => new dvec3(w, x, y);
        
        /// <summary>
        /// Returns dvec4.wxyx swizzling.
        /// </summary>
        public dvec4 wxyx => new dvec4(w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.argr swizzling (equivalent to dvec4.wxyx).
        /// </summary>
        public dvec4 argr => new dvec4(w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.wxyxx swizzling.
        /// </summary>
        public dvec5 wxyxx => new dvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.argrr swizzling (equivalent to dvec4.wxyxx).
        /// </summary>
        public dvec5 argrr => new dvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.wxyxy swizzling.
        /// </summary>
        public dvec5 wxyxy => new dvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.argrg swizzling (equivalent to dvec4.wxyxy).
        /// </summary>
        public dvec5 argrg => new dvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.wxyxz swizzling.
        /// </summary>
        public dvec5 wxyxz => new dvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.argrb swizzling (equivalent to dvec4.wxyxz).
        /// </summary>
        public dvec5 argrb => new dvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.wxyxw swizzling.
        /// </summary>
        public dvec5 wxyxw => new dvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.argra swizzling (equivalent to dvec4.wxyxw).
        /// </summary>
        public dvec5 argra => new dvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.wxyy swizzling.
        /// </summary>
        public dvec4 wxyy => new dvec4(w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.argg swizzling (equivalent to dvec4.wxyy).
        /// </summary>
        public dvec4 argg => new dvec4(w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.wxyyx swizzling.
        /// </summary>
        public dvec5 wxyyx => new dvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.arggr swizzling (equivalent to dvec4.wxyyx).
        /// </summary>
        public dvec5 arggr => new dvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.wxyyy swizzling.
        /// </summary>
        public dvec5 wxyyy => new dvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.arggg swizzling (equivalent to dvec4.wxyyy).
        /// </summary>
        public dvec5 arggg => new dvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.wxyyz swizzling.
        /// </summary>
        public dvec5 wxyyz => new dvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.arggb swizzling (equivalent to dvec4.wxyyz).
        /// </summary>
        public dvec5 arggb => new dvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.wxyyw swizzling.
        /// </summary>
        public dvec5 wxyyw => new dvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.argga swizzling (equivalent to dvec4.wxyyw).
        /// </summary>
        public dvec5 argga => new dvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.wxyz swizzling.
        /// </summary>
        public dvec4 wxyz => new dvec4(w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.argb swizzling (equivalent to dvec4.wxyz).
        /// </summary>
        public dvec4 argb => new dvec4(w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.wxyzx swizzling.
        /// </summary>
        public dvec5 wxyzx => new dvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.argbr swizzling (equivalent to dvec4.wxyzx).
        /// </summary>
        public dvec5 argbr => new dvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.wxyzy swizzling.
        /// </summary>
        public dvec5 wxyzy => new dvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.argbg swizzling (equivalent to dvec4.wxyzy).
        /// </summary>
        public dvec5 argbg => new dvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.wxyzz swizzling.
        /// </summary>
        public dvec5 wxyzz => new dvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.argbb swizzling (equivalent to dvec4.wxyzz).
        /// </summary>
        public dvec5 argbb => new dvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.wxyzw swizzling.
        /// </summary>
        public dvec5 wxyzw => new dvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.argba swizzling (equivalent to dvec4.wxyzw).
        /// </summary>
        public dvec5 argba => new dvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.wxyw swizzling.
        /// </summary>
        public dvec4 wxyw => new dvec4(w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.arga swizzling (equivalent to dvec4.wxyw).
        /// </summary>
        public dvec4 arga => new dvec4(w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.wxywx swizzling.
        /// </summary>
        public dvec5 wxywx => new dvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.argar swizzling (equivalent to dvec4.wxywx).
        /// </summary>
        public dvec5 argar => new dvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.wxywy swizzling.
        /// </summary>
        public dvec5 wxywy => new dvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.argag swizzling (equivalent to dvec4.wxywy).
        /// </summary>
        public dvec5 argag => new dvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.wxywz swizzling.
        /// </summary>
        public dvec5 wxywz => new dvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.argab swizzling (equivalent to dvec4.wxywz).
        /// </summary>
        public dvec5 argab => new dvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.wxyww swizzling.
        /// </summary>
        public dvec5 wxyww => new dvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.argaa swizzling (equivalent to dvec4.wxyww).
        /// </summary>
        public dvec5 argaa => new dvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.wxz swizzling.
        /// </summary>
        public dvec3 wxz => new dvec3(w, x, z);
        
        /// <summary>
        /// Returns dvec4.arb swizzling (equivalent to dvec4.wxz).
        /// </summary>
        public dvec3 arb => new dvec3(w, x, z);
        
        /// <summary>
        /// Returns dvec4.wxzx swizzling.
        /// </summary>
        public dvec4 wxzx => new dvec4(w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.arbr swizzling (equivalent to dvec4.wxzx).
        /// </summary>
        public dvec4 arbr => new dvec4(w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.wxzxx swizzling.
        /// </summary>
        public dvec5 wxzxx => new dvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.arbrr swizzling (equivalent to dvec4.wxzxx).
        /// </summary>
        public dvec5 arbrr => new dvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.wxzxy swizzling.
        /// </summary>
        public dvec5 wxzxy => new dvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.arbrg swizzling (equivalent to dvec4.wxzxy).
        /// </summary>
        public dvec5 arbrg => new dvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.wxzxz swizzling.
        /// </summary>
        public dvec5 wxzxz => new dvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.arbrb swizzling (equivalent to dvec4.wxzxz).
        /// </summary>
        public dvec5 arbrb => new dvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.wxzxw swizzling.
        /// </summary>
        public dvec5 wxzxw => new dvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.arbra swizzling (equivalent to dvec4.wxzxw).
        /// </summary>
        public dvec5 arbra => new dvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.wxzy swizzling.
        /// </summary>
        public dvec4 wxzy => new dvec4(w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.arbg swizzling (equivalent to dvec4.wxzy).
        /// </summary>
        public dvec4 arbg => new dvec4(w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.wxzyx swizzling.
        /// </summary>
        public dvec5 wxzyx => new dvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.arbgr swizzling (equivalent to dvec4.wxzyx).
        /// </summary>
        public dvec5 arbgr => new dvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.wxzyy swizzling.
        /// </summary>
        public dvec5 wxzyy => new dvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.arbgg swizzling (equivalent to dvec4.wxzyy).
        /// </summary>
        public dvec5 arbgg => new dvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.wxzyz swizzling.
        /// </summary>
        public dvec5 wxzyz => new dvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.arbgb swizzling (equivalent to dvec4.wxzyz).
        /// </summary>
        public dvec5 arbgb => new dvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.wxzyw swizzling.
        /// </summary>
        public dvec5 wxzyw => new dvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.arbga swizzling (equivalent to dvec4.wxzyw).
        /// </summary>
        public dvec5 arbga => new dvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.wxzz swizzling.
        /// </summary>
        public dvec4 wxzz => new dvec4(w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.arbb swizzling (equivalent to dvec4.wxzz).
        /// </summary>
        public dvec4 arbb => new dvec4(w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.wxzzx swizzling.
        /// </summary>
        public dvec5 wxzzx => new dvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.arbbr swizzling (equivalent to dvec4.wxzzx).
        /// </summary>
        public dvec5 arbbr => new dvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.wxzzy swizzling.
        /// </summary>
        public dvec5 wxzzy => new dvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.arbbg swizzling (equivalent to dvec4.wxzzy).
        /// </summary>
        public dvec5 arbbg => new dvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.wxzzz swizzling.
        /// </summary>
        public dvec5 wxzzz => new dvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.arbbb swizzling (equivalent to dvec4.wxzzz).
        /// </summary>
        public dvec5 arbbb => new dvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.wxzzw swizzling.
        /// </summary>
        public dvec5 wxzzw => new dvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.arbba swizzling (equivalent to dvec4.wxzzw).
        /// </summary>
        public dvec5 arbba => new dvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.wxzw swizzling.
        /// </summary>
        public dvec4 wxzw => new dvec4(w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.arba swizzling (equivalent to dvec4.wxzw).
        /// </summary>
        public dvec4 arba => new dvec4(w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.wxzwx swizzling.
        /// </summary>
        public dvec5 wxzwx => new dvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.arbar swizzling (equivalent to dvec4.wxzwx).
        /// </summary>
        public dvec5 arbar => new dvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.wxzwy swizzling.
        /// </summary>
        public dvec5 wxzwy => new dvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.arbag swizzling (equivalent to dvec4.wxzwy).
        /// </summary>
        public dvec5 arbag => new dvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.wxzwz swizzling.
        /// </summary>
        public dvec5 wxzwz => new dvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.arbab swizzling (equivalent to dvec4.wxzwz).
        /// </summary>
        public dvec5 arbab => new dvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.wxzww swizzling.
        /// </summary>
        public dvec5 wxzww => new dvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.arbaa swizzling (equivalent to dvec4.wxzww).
        /// </summary>
        public dvec5 arbaa => new dvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.wxw swizzling.
        /// </summary>
        public dvec3 wxw => new dvec3(w, x, w);
        
        /// <summary>
        /// Returns dvec4.ara swizzling (equivalent to dvec4.wxw).
        /// </summary>
        public dvec3 ara => new dvec3(w, x, w);
        
        /// <summary>
        /// Returns dvec4.wxwx swizzling.
        /// </summary>
        public dvec4 wxwx => new dvec4(w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.arar swizzling (equivalent to dvec4.wxwx).
        /// </summary>
        public dvec4 arar => new dvec4(w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.wxwxx swizzling.
        /// </summary>
        public dvec5 wxwxx => new dvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.ararr swizzling (equivalent to dvec4.wxwxx).
        /// </summary>
        public dvec5 ararr => new dvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.wxwxy swizzling.
        /// </summary>
        public dvec5 wxwxy => new dvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.ararg swizzling (equivalent to dvec4.wxwxy).
        /// </summary>
        public dvec5 ararg => new dvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.wxwxz swizzling.
        /// </summary>
        public dvec5 wxwxz => new dvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.ararb swizzling (equivalent to dvec4.wxwxz).
        /// </summary>
        public dvec5 ararb => new dvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.wxwxw swizzling.
        /// </summary>
        public dvec5 wxwxw => new dvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.arara swizzling (equivalent to dvec4.wxwxw).
        /// </summary>
        public dvec5 arara => new dvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.wxwy swizzling.
        /// </summary>
        public dvec4 wxwy => new dvec4(w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.arag swizzling (equivalent to dvec4.wxwy).
        /// </summary>
        public dvec4 arag => new dvec4(w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.wxwyx swizzling.
        /// </summary>
        public dvec5 wxwyx => new dvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.aragr swizzling (equivalent to dvec4.wxwyx).
        /// </summary>
        public dvec5 aragr => new dvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.wxwyy swizzling.
        /// </summary>
        public dvec5 wxwyy => new dvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.aragg swizzling (equivalent to dvec4.wxwyy).
        /// </summary>
        public dvec5 aragg => new dvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.wxwyz swizzling.
        /// </summary>
        public dvec5 wxwyz => new dvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.aragb swizzling (equivalent to dvec4.wxwyz).
        /// </summary>
        public dvec5 aragb => new dvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.wxwyw swizzling.
        /// </summary>
        public dvec5 wxwyw => new dvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.araga swizzling (equivalent to dvec4.wxwyw).
        /// </summary>
        public dvec5 araga => new dvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.wxwz swizzling.
        /// </summary>
        public dvec4 wxwz => new dvec4(w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.arab swizzling (equivalent to dvec4.wxwz).
        /// </summary>
        public dvec4 arab => new dvec4(w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.wxwzx swizzling.
        /// </summary>
        public dvec5 wxwzx => new dvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.arabr swizzling (equivalent to dvec4.wxwzx).
        /// </summary>
        public dvec5 arabr => new dvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.wxwzy swizzling.
        /// </summary>
        public dvec5 wxwzy => new dvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.arabg swizzling (equivalent to dvec4.wxwzy).
        /// </summary>
        public dvec5 arabg => new dvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.wxwzz swizzling.
        /// </summary>
        public dvec5 wxwzz => new dvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.arabb swizzling (equivalent to dvec4.wxwzz).
        /// </summary>
        public dvec5 arabb => new dvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.wxwzw swizzling.
        /// </summary>
        public dvec5 wxwzw => new dvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.araba swizzling (equivalent to dvec4.wxwzw).
        /// </summary>
        public dvec5 araba => new dvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.wxww swizzling.
        /// </summary>
        public dvec4 wxww => new dvec4(w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.araa swizzling (equivalent to dvec4.wxww).
        /// </summary>
        public dvec4 araa => new dvec4(w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.wxwwx swizzling.
        /// </summary>
        public dvec5 wxwwx => new dvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.araar swizzling (equivalent to dvec4.wxwwx).
        /// </summary>
        public dvec5 araar => new dvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.wxwwy swizzling.
        /// </summary>
        public dvec5 wxwwy => new dvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.araag swizzling (equivalent to dvec4.wxwwy).
        /// </summary>
        public dvec5 araag => new dvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.wxwwz swizzling.
        /// </summary>
        public dvec5 wxwwz => new dvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.araab swizzling (equivalent to dvec4.wxwwz).
        /// </summary>
        public dvec5 araab => new dvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.wxwww swizzling.
        /// </summary>
        public dvec5 wxwww => new dvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.araaa swizzling (equivalent to dvec4.wxwww).
        /// </summary>
        public dvec5 araaa => new dvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.wy swizzling.
        /// </summary>
        public dvec2 wy => new dvec2(w, y);
        
        /// <summary>
        /// Returns dvec4.ag swizzling (equivalent to dvec4.wy).
        /// </summary>
        public dvec2 ag => new dvec2(w, y);
        
        /// <summary>
        /// Returns dvec4.wyx swizzling.
        /// </summary>
        public dvec3 wyx => new dvec3(w, y, x);
        
        /// <summary>
        /// Returns dvec4.agr swizzling (equivalent to dvec4.wyx).
        /// </summary>
        public dvec3 agr => new dvec3(w, y, x);
        
        /// <summary>
        /// Returns dvec4.wyxx swizzling.
        /// </summary>
        public dvec4 wyxx => new dvec4(w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.agrr swizzling (equivalent to dvec4.wyxx).
        /// </summary>
        public dvec4 agrr => new dvec4(w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.wyxxx swizzling.
        /// </summary>
        public dvec5 wyxxx => new dvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.agrrr swizzling (equivalent to dvec4.wyxxx).
        /// </summary>
        public dvec5 agrrr => new dvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.wyxxy swizzling.
        /// </summary>
        public dvec5 wyxxy => new dvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.agrrg swizzling (equivalent to dvec4.wyxxy).
        /// </summary>
        public dvec5 agrrg => new dvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.wyxxz swizzling.
        /// </summary>
        public dvec5 wyxxz => new dvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.agrrb swizzling (equivalent to dvec4.wyxxz).
        /// </summary>
        public dvec5 agrrb => new dvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.wyxxw swizzling.
        /// </summary>
        public dvec5 wyxxw => new dvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.agrra swizzling (equivalent to dvec4.wyxxw).
        /// </summary>
        public dvec5 agrra => new dvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.wyxy swizzling.
        /// </summary>
        public dvec4 wyxy => new dvec4(w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.agrg swizzling (equivalent to dvec4.wyxy).
        /// </summary>
        public dvec4 agrg => new dvec4(w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.wyxyx swizzling.
        /// </summary>
        public dvec5 wyxyx => new dvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.agrgr swizzling (equivalent to dvec4.wyxyx).
        /// </summary>
        public dvec5 agrgr => new dvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.wyxyy swizzling.
        /// </summary>
        public dvec5 wyxyy => new dvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.agrgg swizzling (equivalent to dvec4.wyxyy).
        /// </summary>
        public dvec5 agrgg => new dvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.wyxyz swizzling.
        /// </summary>
        public dvec5 wyxyz => new dvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.agrgb swizzling (equivalent to dvec4.wyxyz).
        /// </summary>
        public dvec5 agrgb => new dvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.wyxyw swizzling.
        /// </summary>
        public dvec5 wyxyw => new dvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.agrga swizzling (equivalent to dvec4.wyxyw).
        /// </summary>
        public dvec5 agrga => new dvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.wyxz swizzling.
        /// </summary>
        public dvec4 wyxz => new dvec4(w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.agrb swizzling (equivalent to dvec4.wyxz).
        /// </summary>
        public dvec4 agrb => new dvec4(w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.wyxzx swizzling.
        /// </summary>
        public dvec5 wyxzx => new dvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.agrbr swizzling (equivalent to dvec4.wyxzx).
        /// </summary>
        public dvec5 agrbr => new dvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.wyxzy swizzling.
        /// </summary>
        public dvec5 wyxzy => new dvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.agrbg swizzling (equivalent to dvec4.wyxzy).
        /// </summary>
        public dvec5 agrbg => new dvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.wyxzz swizzling.
        /// </summary>
        public dvec5 wyxzz => new dvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.agrbb swizzling (equivalent to dvec4.wyxzz).
        /// </summary>
        public dvec5 agrbb => new dvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.wyxzw swizzling.
        /// </summary>
        public dvec5 wyxzw => new dvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.agrba swizzling (equivalent to dvec4.wyxzw).
        /// </summary>
        public dvec5 agrba => new dvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.wyxw swizzling.
        /// </summary>
        public dvec4 wyxw => new dvec4(w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.agra swizzling (equivalent to dvec4.wyxw).
        /// </summary>
        public dvec4 agra => new dvec4(w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.wyxwx swizzling.
        /// </summary>
        public dvec5 wyxwx => new dvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.agrar swizzling (equivalent to dvec4.wyxwx).
        /// </summary>
        public dvec5 agrar => new dvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.wyxwy swizzling.
        /// </summary>
        public dvec5 wyxwy => new dvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.agrag swizzling (equivalent to dvec4.wyxwy).
        /// </summary>
        public dvec5 agrag => new dvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.wyxwz swizzling.
        /// </summary>
        public dvec5 wyxwz => new dvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.agrab swizzling (equivalent to dvec4.wyxwz).
        /// </summary>
        public dvec5 agrab => new dvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.wyxww swizzling.
        /// </summary>
        public dvec5 wyxww => new dvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.agraa swizzling (equivalent to dvec4.wyxww).
        /// </summary>
        public dvec5 agraa => new dvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.wyy swizzling.
        /// </summary>
        public dvec3 wyy => new dvec3(w, y, y);
        
        /// <summary>
        /// Returns dvec4.agg swizzling (equivalent to dvec4.wyy).
        /// </summary>
        public dvec3 agg => new dvec3(w, y, y);
        
        /// <summary>
        /// Returns dvec4.wyyx swizzling.
        /// </summary>
        public dvec4 wyyx => new dvec4(w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.aggr swizzling (equivalent to dvec4.wyyx).
        /// </summary>
        public dvec4 aggr => new dvec4(w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.wyyxx swizzling.
        /// </summary>
        public dvec5 wyyxx => new dvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.aggrr swizzling (equivalent to dvec4.wyyxx).
        /// </summary>
        public dvec5 aggrr => new dvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.wyyxy swizzling.
        /// </summary>
        public dvec5 wyyxy => new dvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.aggrg swizzling (equivalent to dvec4.wyyxy).
        /// </summary>
        public dvec5 aggrg => new dvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.wyyxz swizzling.
        /// </summary>
        public dvec5 wyyxz => new dvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.aggrb swizzling (equivalent to dvec4.wyyxz).
        /// </summary>
        public dvec5 aggrb => new dvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.wyyxw swizzling.
        /// </summary>
        public dvec5 wyyxw => new dvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.aggra swizzling (equivalent to dvec4.wyyxw).
        /// </summary>
        public dvec5 aggra => new dvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.wyyy swizzling.
        /// </summary>
        public dvec4 wyyy => new dvec4(w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.aggg swizzling (equivalent to dvec4.wyyy).
        /// </summary>
        public dvec4 aggg => new dvec4(w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.wyyyx swizzling.
        /// </summary>
        public dvec5 wyyyx => new dvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.agggr swizzling (equivalent to dvec4.wyyyx).
        /// </summary>
        public dvec5 agggr => new dvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.wyyyy swizzling.
        /// </summary>
        public dvec5 wyyyy => new dvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.agggg swizzling (equivalent to dvec4.wyyyy).
        /// </summary>
        public dvec5 agggg => new dvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.wyyyz swizzling.
        /// </summary>
        public dvec5 wyyyz => new dvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.agggb swizzling (equivalent to dvec4.wyyyz).
        /// </summary>
        public dvec5 agggb => new dvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.wyyyw swizzling.
        /// </summary>
        public dvec5 wyyyw => new dvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.aggga swizzling (equivalent to dvec4.wyyyw).
        /// </summary>
        public dvec5 aggga => new dvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.wyyz swizzling.
        /// </summary>
        public dvec4 wyyz => new dvec4(w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.aggb swizzling (equivalent to dvec4.wyyz).
        /// </summary>
        public dvec4 aggb => new dvec4(w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.wyyzx swizzling.
        /// </summary>
        public dvec5 wyyzx => new dvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.aggbr swizzling (equivalent to dvec4.wyyzx).
        /// </summary>
        public dvec5 aggbr => new dvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.wyyzy swizzling.
        /// </summary>
        public dvec5 wyyzy => new dvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.aggbg swizzling (equivalent to dvec4.wyyzy).
        /// </summary>
        public dvec5 aggbg => new dvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.wyyzz swizzling.
        /// </summary>
        public dvec5 wyyzz => new dvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.aggbb swizzling (equivalent to dvec4.wyyzz).
        /// </summary>
        public dvec5 aggbb => new dvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.wyyzw swizzling.
        /// </summary>
        public dvec5 wyyzw => new dvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.aggba swizzling (equivalent to dvec4.wyyzw).
        /// </summary>
        public dvec5 aggba => new dvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.wyyw swizzling.
        /// </summary>
        public dvec4 wyyw => new dvec4(w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.agga swizzling (equivalent to dvec4.wyyw).
        /// </summary>
        public dvec4 agga => new dvec4(w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.wyywx swizzling.
        /// </summary>
        public dvec5 wyywx => new dvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.aggar swizzling (equivalent to dvec4.wyywx).
        /// </summary>
        public dvec5 aggar => new dvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.wyywy swizzling.
        /// </summary>
        public dvec5 wyywy => new dvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.aggag swizzling (equivalent to dvec4.wyywy).
        /// </summary>
        public dvec5 aggag => new dvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.wyywz swizzling.
        /// </summary>
        public dvec5 wyywz => new dvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.aggab swizzling (equivalent to dvec4.wyywz).
        /// </summary>
        public dvec5 aggab => new dvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.wyyww swizzling.
        /// </summary>
        public dvec5 wyyww => new dvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.aggaa swizzling (equivalent to dvec4.wyyww).
        /// </summary>
        public dvec5 aggaa => new dvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.wyz swizzling.
        /// </summary>
        public dvec3 wyz => new dvec3(w, y, z);
        
        /// <summary>
        /// Returns dvec4.agb swizzling (equivalent to dvec4.wyz).
        /// </summary>
        public dvec3 agb => new dvec3(w, y, z);
        
        /// <summary>
        /// Returns dvec4.wyzx swizzling.
        /// </summary>
        public dvec4 wyzx => new dvec4(w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.agbr swizzling (equivalent to dvec4.wyzx).
        /// </summary>
        public dvec4 agbr => new dvec4(w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.wyzxx swizzling.
        /// </summary>
        public dvec5 wyzxx => new dvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.agbrr swizzling (equivalent to dvec4.wyzxx).
        /// </summary>
        public dvec5 agbrr => new dvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.wyzxy swizzling.
        /// </summary>
        public dvec5 wyzxy => new dvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.agbrg swizzling (equivalent to dvec4.wyzxy).
        /// </summary>
        public dvec5 agbrg => new dvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.wyzxz swizzling.
        /// </summary>
        public dvec5 wyzxz => new dvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.agbrb swizzling (equivalent to dvec4.wyzxz).
        /// </summary>
        public dvec5 agbrb => new dvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.wyzxw swizzling.
        /// </summary>
        public dvec5 wyzxw => new dvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.agbra swizzling (equivalent to dvec4.wyzxw).
        /// </summary>
        public dvec5 agbra => new dvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.wyzy swizzling.
        /// </summary>
        public dvec4 wyzy => new dvec4(w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.agbg swizzling (equivalent to dvec4.wyzy).
        /// </summary>
        public dvec4 agbg => new dvec4(w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.wyzyx swizzling.
        /// </summary>
        public dvec5 wyzyx => new dvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.agbgr swizzling (equivalent to dvec4.wyzyx).
        /// </summary>
        public dvec5 agbgr => new dvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.wyzyy swizzling.
        /// </summary>
        public dvec5 wyzyy => new dvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.agbgg swizzling (equivalent to dvec4.wyzyy).
        /// </summary>
        public dvec5 agbgg => new dvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.wyzyz swizzling.
        /// </summary>
        public dvec5 wyzyz => new dvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.agbgb swizzling (equivalent to dvec4.wyzyz).
        /// </summary>
        public dvec5 agbgb => new dvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.wyzyw swizzling.
        /// </summary>
        public dvec5 wyzyw => new dvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.agbga swizzling (equivalent to dvec4.wyzyw).
        /// </summary>
        public dvec5 agbga => new dvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.wyzz swizzling.
        /// </summary>
        public dvec4 wyzz => new dvec4(w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.agbb swizzling (equivalent to dvec4.wyzz).
        /// </summary>
        public dvec4 agbb => new dvec4(w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.wyzzx swizzling.
        /// </summary>
        public dvec5 wyzzx => new dvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.agbbr swizzling (equivalent to dvec4.wyzzx).
        /// </summary>
        public dvec5 agbbr => new dvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.wyzzy swizzling.
        /// </summary>
        public dvec5 wyzzy => new dvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.agbbg swizzling (equivalent to dvec4.wyzzy).
        /// </summary>
        public dvec5 agbbg => new dvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.wyzzz swizzling.
        /// </summary>
        public dvec5 wyzzz => new dvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.agbbb swizzling (equivalent to dvec4.wyzzz).
        /// </summary>
        public dvec5 agbbb => new dvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.wyzzw swizzling.
        /// </summary>
        public dvec5 wyzzw => new dvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.agbba swizzling (equivalent to dvec4.wyzzw).
        /// </summary>
        public dvec5 agbba => new dvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.wyzw swizzling.
        /// </summary>
        public dvec4 wyzw => new dvec4(w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.agba swizzling (equivalent to dvec4.wyzw).
        /// </summary>
        public dvec4 agba => new dvec4(w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.wyzwx swizzling.
        /// </summary>
        public dvec5 wyzwx => new dvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.agbar swizzling (equivalent to dvec4.wyzwx).
        /// </summary>
        public dvec5 agbar => new dvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.wyzwy swizzling.
        /// </summary>
        public dvec5 wyzwy => new dvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.agbag swizzling (equivalent to dvec4.wyzwy).
        /// </summary>
        public dvec5 agbag => new dvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.wyzwz swizzling.
        /// </summary>
        public dvec5 wyzwz => new dvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.agbab swizzling (equivalent to dvec4.wyzwz).
        /// </summary>
        public dvec5 agbab => new dvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.wyzww swizzling.
        /// </summary>
        public dvec5 wyzww => new dvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.agbaa swizzling (equivalent to dvec4.wyzww).
        /// </summary>
        public dvec5 agbaa => new dvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.wyw swizzling.
        /// </summary>
        public dvec3 wyw => new dvec3(w, y, w);
        
        /// <summary>
        /// Returns dvec4.aga swizzling (equivalent to dvec4.wyw).
        /// </summary>
        public dvec3 aga => new dvec3(w, y, w);
        
        /// <summary>
        /// Returns dvec4.wywx swizzling.
        /// </summary>
        public dvec4 wywx => new dvec4(w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.agar swizzling (equivalent to dvec4.wywx).
        /// </summary>
        public dvec4 agar => new dvec4(w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.wywxx swizzling.
        /// </summary>
        public dvec5 wywxx => new dvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.agarr swizzling (equivalent to dvec4.wywxx).
        /// </summary>
        public dvec5 agarr => new dvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.wywxy swizzling.
        /// </summary>
        public dvec5 wywxy => new dvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.agarg swizzling (equivalent to dvec4.wywxy).
        /// </summary>
        public dvec5 agarg => new dvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.wywxz swizzling.
        /// </summary>
        public dvec5 wywxz => new dvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.agarb swizzling (equivalent to dvec4.wywxz).
        /// </summary>
        public dvec5 agarb => new dvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.wywxw swizzling.
        /// </summary>
        public dvec5 wywxw => new dvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.agara swizzling (equivalent to dvec4.wywxw).
        /// </summary>
        public dvec5 agara => new dvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.wywy swizzling.
        /// </summary>
        public dvec4 wywy => new dvec4(w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.agag swizzling (equivalent to dvec4.wywy).
        /// </summary>
        public dvec4 agag => new dvec4(w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.wywyx swizzling.
        /// </summary>
        public dvec5 wywyx => new dvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.agagr swizzling (equivalent to dvec4.wywyx).
        /// </summary>
        public dvec5 agagr => new dvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.wywyy swizzling.
        /// </summary>
        public dvec5 wywyy => new dvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.agagg swizzling (equivalent to dvec4.wywyy).
        /// </summary>
        public dvec5 agagg => new dvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.wywyz swizzling.
        /// </summary>
        public dvec5 wywyz => new dvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.agagb swizzling (equivalent to dvec4.wywyz).
        /// </summary>
        public dvec5 agagb => new dvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.wywyw swizzling.
        /// </summary>
        public dvec5 wywyw => new dvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.agaga swizzling (equivalent to dvec4.wywyw).
        /// </summary>
        public dvec5 agaga => new dvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.wywz swizzling.
        /// </summary>
        public dvec4 wywz => new dvec4(w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.agab swizzling (equivalent to dvec4.wywz).
        /// </summary>
        public dvec4 agab => new dvec4(w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.wywzx swizzling.
        /// </summary>
        public dvec5 wywzx => new dvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.agabr swizzling (equivalent to dvec4.wywzx).
        /// </summary>
        public dvec5 agabr => new dvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.wywzy swizzling.
        /// </summary>
        public dvec5 wywzy => new dvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.agabg swizzling (equivalent to dvec4.wywzy).
        /// </summary>
        public dvec5 agabg => new dvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.wywzz swizzling.
        /// </summary>
        public dvec5 wywzz => new dvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.agabb swizzling (equivalent to dvec4.wywzz).
        /// </summary>
        public dvec5 agabb => new dvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.wywzw swizzling.
        /// </summary>
        public dvec5 wywzw => new dvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.agaba swizzling (equivalent to dvec4.wywzw).
        /// </summary>
        public dvec5 agaba => new dvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.wyww swizzling.
        /// </summary>
        public dvec4 wyww => new dvec4(w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.agaa swizzling (equivalent to dvec4.wyww).
        /// </summary>
        public dvec4 agaa => new dvec4(w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.wywwx swizzling.
        /// </summary>
        public dvec5 wywwx => new dvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.agaar swizzling (equivalent to dvec4.wywwx).
        /// </summary>
        public dvec5 agaar => new dvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.wywwy swizzling.
        /// </summary>
        public dvec5 wywwy => new dvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.agaag swizzling (equivalent to dvec4.wywwy).
        /// </summary>
        public dvec5 agaag => new dvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.wywwz swizzling.
        /// </summary>
        public dvec5 wywwz => new dvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.agaab swizzling (equivalent to dvec4.wywwz).
        /// </summary>
        public dvec5 agaab => new dvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.wywww swizzling.
        /// </summary>
        public dvec5 wywww => new dvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.agaaa swizzling (equivalent to dvec4.wywww).
        /// </summary>
        public dvec5 agaaa => new dvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.wz swizzling.
        /// </summary>
        public dvec2 wz => new dvec2(w, z);
        
        /// <summary>
        /// Returns dvec4.ab swizzling (equivalent to dvec4.wz).
        /// </summary>
        public dvec2 ab => new dvec2(w, z);
        
        /// <summary>
        /// Returns dvec4.wzx swizzling.
        /// </summary>
        public dvec3 wzx => new dvec3(w, z, x);
        
        /// <summary>
        /// Returns dvec4.abr swizzling (equivalent to dvec4.wzx).
        /// </summary>
        public dvec3 abr => new dvec3(w, z, x);
        
        /// <summary>
        /// Returns dvec4.wzxx swizzling.
        /// </summary>
        public dvec4 wzxx => new dvec4(w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.abrr swizzling (equivalent to dvec4.wzxx).
        /// </summary>
        public dvec4 abrr => new dvec4(w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.wzxxx swizzling.
        /// </summary>
        public dvec5 wzxxx => new dvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.abrrr swizzling (equivalent to dvec4.wzxxx).
        /// </summary>
        public dvec5 abrrr => new dvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.wzxxy swizzling.
        /// </summary>
        public dvec5 wzxxy => new dvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.abrrg swizzling (equivalent to dvec4.wzxxy).
        /// </summary>
        public dvec5 abrrg => new dvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.wzxxz swizzling.
        /// </summary>
        public dvec5 wzxxz => new dvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.abrrb swizzling (equivalent to dvec4.wzxxz).
        /// </summary>
        public dvec5 abrrb => new dvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.wzxxw swizzling.
        /// </summary>
        public dvec5 wzxxw => new dvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.abrra swizzling (equivalent to dvec4.wzxxw).
        /// </summary>
        public dvec5 abrra => new dvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.wzxy swizzling.
        /// </summary>
        public dvec4 wzxy => new dvec4(w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.abrg swizzling (equivalent to dvec4.wzxy).
        /// </summary>
        public dvec4 abrg => new dvec4(w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.wzxyx swizzling.
        /// </summary>
        public dvec5 wzxyx => new dvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.abrgr swizzling (equivalent to dvec4.wzxyx).
        /// </summary>
        public dvec5 abrgr => new dvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.wzxyy swizzling.
        /// </summary>
        public dvec5 wzxyy => new dvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.abrgg swizzling (equivalent to dvec4.wzxyy).
        /// </summary>
        public dvec5 abrgg => new dvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.wzxyz swizzling.
        /// </summary>
        public dvec5 wzxyz => new dvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.abrgb swizzling (equivalent to dvec4.wzxyz).
        /// </summary>
        public dvec5 abrgb => new dvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.wzxyw swizzling.
        /// </summary>
        public dvec5 wzxyw => new dvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.abrga swizzling (equivalent to dvec4.wzxyw).
        /// </summary>
        public dvec5 abrga => new dvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.wzxz swizzling.
        /// </summary>
        public dvec4 wzxz => new dvec4(w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.abrb swizzling (equivalent to dvec4.wzxz).
        /// </summary>
        public dvec4 abrb => new dvec4(w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.wzxzx swizzling.
        /// </summary>
        public dvec5 wzxzx => new dvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.abrbr swizzling (equivalent to dvec4.wzxzx).
        /// </summary>
        public dvec5 abrbr => new dvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.wzxzy swizzling.
        /// </summary>
        public dvec5 wzxzy => new dvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.abrbg swizzling (equivalent to dvec4.wzxzy).
        /// </summary>
        public dvec5 abrbg => new dvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.wzxzz swizzling.
        /// </summary>
        public dvec5 wzxzz => new dvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.abrbb swizzling (equivalent to dvec4.wzxzz).
        /// </summary>
        public dvec5 abrbb => new dvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.wzxzw swizzling.
        /// </summary>
        public dvec5 wzxzw => new dvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.abrba swizzling (equivalent to dvec4.wzxzw).
        /// </summary>
        public dvec5 abrba => new dvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.wzxw swizzling.
        /// </summary>
        public dvec4 wzxw => new dvec4(w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.abra swizzling (equivalent to dvec4.wzxw).
        /// </summary>
        public dvec4 abra => new dvec4(w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.wzxwx swizzling.
        /// </summary>
        public dvec5 wzxwx => new dvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.abrar swizzling (equivalent to dvec4.wzxwx).
        /// </summary>
        public dvec5 abrar => new dvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.wzxwy swizzling.
        /// </summary>
        public dvec5 wzxwy => new dvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.abrag swizzling (equivalent to dvec4.wzxwy).
        /// </summary>
        public dvec5 abrag => new dvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.wzxwz swizzling.
        /// </summary>
        public dvec5 wzxwz => new dvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.abrab swizzling (equivalent to dvec4.wzxwz).
        /// </summary>
        public dvec5 abrab => new dvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.wzxww swizzling.
        /// </summary>
        public dvec5 wzxww => new dvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.abraa swizzling (equivalent to dvec4.wzxww).
        /// </summary>
        public dvec5 abraa => new dvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.wzy swizzling.
        /// </summary>
        public dvec3 wzy => new dvec3(w, z, y);
        
        /// <summary>
        /// Returns dvec4.abg swizzling (equivalent to dvec4.wzy).
        /// </summary>
        public dvec3 abg => new dvec3(w, z, y);
        
        /// <summary>
        /// Returns dvec4.wzyx swizzling.
        /// </summary>
        public dvec4 wzyx => new dvec4(w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.abgr swizzling (equivalent to dvec4.wzyx).
        /// </summary>
        public dvec4 abgr => new dvec4(w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.wzyxx swizzling.
        /// </summary>
        public dvec5 wzyxx => new dvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.abgrr swizzling (equivalent to dvec4.wzyxx).
        /// </summary>
        public dvec5 abgrr => new dvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.wzyxy swizzling.
        /// </summary>
        public dvec5 wzyxy => new dvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.abgrg swizzling (equivalent to dvec4.wzyxy).
        /// </summary>
        public dvec5 abgrg => new dvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.wzyxz swizzling.
        /// </summary>
        public dvec5 wzyxz => new dvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.abgrb swizzling (equivalent to dvec4.wzyxz).
        /// </summary>
        public dvec5 abgrb => new dvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.wzyxw swizzling.
        /// </summary>
        public dvec5 wzyxw => new dvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.abgra swizzling (equivalent to dvec4.wzyxw).
        /// </summary>
        public dvec5 abgra => new dvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.wzyy swizzling.
        /// </summary>
        public dvec4 wzyy => new dvec4(w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.abgg swizzling (equivalent to dvec4.wzyy).
        /// </summary>
        public dvec4 abgg => new dvec4(w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.wzyyx swizzling.
        /// </summary>
        public dvec5 wzyyx => new dvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.abggr swizzling (equivalent to dvec4.wzyyx).
        /// </summary>
        public dvec5 abggr => new dvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.wzyyy swizzling.
        /// </summary>
        public dvec5 wzyyy => new dvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.abggg swizzling (equivalent to dvec4.wzyyy).
        /// </summary>
        public dvec5 abggg => new dvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.wzyyz swizzling.
        /// </summary>
        public dvec5 wzyyz => new dvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.abggb swizzling (equivalent to dvec4.wzyyz).
        /// </summary>
        public dvec5 abggb => new dvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.wzyyw swizzling.
        /// </summary>
        public dvec5 wzyyw => new dvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.abgga swizzling (equivalent to dvec4.wzyyw).
        /// </summary>
        public dvec5 abgga => new dvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.wzyz swizzling.
        /// </summary>
        public dvec4 wzyz => new dvec4(w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.abgb swizzling (equivalent to dvec4.wzyz).
        /// </summary>
        public dvec4 abgb => new dvec4(w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.wzyzx swizzling.
        /// </summary>
        public dvec5 wzyzx => new dvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.abgbr swizzling (equivalent to dvec4.wzyzx).
        /// </summary>
        public dvec5 abgbr => new dvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.wzyzy swizzling.
        /// </summary>
        public dvec5 wzyzy => new dvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.abgbg swizzling (equivalent to dvec4.wzyzy).
        /// </summary>
        public dvec5 abgbg => new dvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.wzyzz swizzling.
        /// </summary>
        public dvec5 wzyzz => new dvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.abgbb swizzling (equivalent to dvec4.wzyzz).
        /// </summary>
        public dvec5 abgbb => new dvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.wzyzw swizzling.
        /// </summary>
        public dvec5 wzyzw => new dvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.abgba swizzling (equivalent to dvec4.wzyzw).
        /// </summary>
        public dvec5 abgba => new dvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.wzyw swizzling.
        /// </summary>
        public dvec4 wzyw => new dvec4(w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.abga swizzling (equivalent to dvec4.wzyw).
        /// </summary>
        public dvec4 abga => new dvec4(w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.wzywx swizzling.
        /// </summary>
        public dvec5 wzywx => new dvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.abgar swizzling (equivalent to dvec4.wzywx).
        /// </summary>
        public dvec5 abgar => new dvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.wzywy swizzling.
        /// </summary>
        public dvec5 wzywy => new dvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.abgag swizzling (equivalent to dvec4.wzywy).
        /// </summary>
        public dvec5 abgag => new dvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.wzywz swizzling.
        /// </summary>
        public dvec5 wzywz => new dvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.abgab swizzling (equivalent to dvec4.wzywz).
        /// </summary>
        public dvec5 abgab => new dvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.wzyww swizzling.
        /// </summary>
        public dvec5 wzyww => new dvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.abgaa swizzling (equivalent to dvec4.wzyww).
        /// </summary>
        public dvec5 abgaa => new dvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.wzz swizzling.
        /// </summary>
        public dvec3 wzz => new dvec3(w, z, z);
        
        /// <summary>
        /// Returns dvec4.abb swizzling (equivalent to dvec4.wzz).
        /// </summary>
        public dvec3 abb => new dvec3(w, z, z);
        
        /// <summary>
        /// Returns dvec4.wzzx swizzling.
        /// </summary>
        public dvec4 wzzx => new dvec4(w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.abbr swizzling (equivalent to dvec4.wzzx).
        /// </summary>
        public dvec4 abbr => new dvec4(w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.wzzxx swizzling.
        /// </summary>
        public dvec5 wzzxx => new dvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.abbrr swizzling (equivalent to dvec4.wzzxx).
        /// </summary>
        public dvec5 abbrr => new dvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.wzzxy swizzling.
        /// </summary>
        public dvec5 wzzxy => new dvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.abbrg swizzling (equivalent to dvec4.wzzxy).
        /// </summary>
        public dvec5 abbrg => new dvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.wzzxz swizzling.
        /// </summary>
        public dvec5 wzzxz => new dvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.abbrb swizzling (equivalent to dvec4.wzzxz).
        /// </summary>
        public dvec5 abbrb => new dvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.wzzxw swizzling.
        /// </summary>
        public dvec5 wzzxw => new dvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.abbra swizzling (equivalent to dvec4.wzzxw).
        /// </summary>
        public dvec5 abbra => new dvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.wzzy swizzling.
        /// </summary>
        public dvec4 wzzy => new dvec4(w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.abbg swizzling (equivalent to dvec4.wzzy).
        /// </summary>
        public dvec4 abbg => new dvec4(w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.wzzyx swizzling.
        /// </summary>
        public dvec5 wzzyx => new dvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.abbgr swizzling (equivalent to dvec4.wzzyx).
        /// </summary>
        public dvec5 abbgr => new dvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.wzzyy swizzling.
        /// </summary>
        public dvec5 wzzyy => new dvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.abbgg swizzling (equivalent to dvec4.wzzyy).
        /// </summary>
        public dvec5 abbgg => new dvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.wzzyz swizzling.
        /// </summary>
        public dvec5 wzzyz => new dvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.abbgb swizzling (equivalent to dvec4.wzzyz).
        /// </summary>
        public dvec5 abbgb => new dvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.wzzyw swizzling.
        /// </summary>
        public dvec5 wzzyw => new dvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.abbga swizzling (equivalent to dvec4.wzzyw).
        /// </summary>
        public dvec5 abbga => new dvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.wzzz swizzling.
        /// </summary>
        public dvec4 wzzz => new dvec4(w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.abbb swizzling (equivalent to dvec4.wzzz).
        /// </summary>
        public dvec4 abbb => new dvec4(w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.wzzzx swizzling.
        /// </summary>
        public dvec5 wzzzx => new dvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.abbbr swizzling (equivalent to dvec4.wzzzx).
        /// </summary>
        public dvec5 abbbr => new dvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.wzzzy swizzling.
        /// </summary>
        public dvec5 wzzzy => new dvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.abbbg swizzling (equivalent to dvec4.wzzzy).
        /// </summary>
        public dvec5 abbbg => new dvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.wzzzz swizzling.
        /// </summary>
        public dvec5 wzzzz => new dvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.abbbb swizzling (equivalent to dvec4.wzzzz).
        /// </summary>
        public dvec5 abbbb => new dvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.wzzzw swizzling.
        /// </summary>
        public dvec5 wzzzw => new dvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.abbba swizzling (equivalent to dvec4.wzzzw).
        /// </summary>
        public dvec5 abbba => new dvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.wzzw swizzling.
        /// </summary>
        public dvec4 wzzw => new dvec4(w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.abba swizzling (equivalent to dvec4.wzzw).
        /// </summary>
        public dvec4 abba => new dvec4(w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.wzzwx swizzling.
        /// </summary>
        public dvec5 wzzwx => new dvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.abbar swizzling (equivalent to dvec4.wzzwx).
        /// </summary>
        public dvec5 abbar => new dvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.wzzwy swizzling.
        /// </summary>
        public dvec5 wzzwy => new dvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.abbag swizzling (equivalent to dvec4.wzzwy).
        /// </summary>
        public dvec5 abbag => new dvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.wzzwz swizzling.
        /// </summary>
        public dvec5 wzzwz => new dvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.abbab swizzling (equivalent to dvec4.wzzwz).
        /// </summary>
        public dvec5 abbab => new dvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.wzzww swizzling.
        /// </summary>
        public dvec5 wzzww => new dvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.abbaa swizzling (equivalent to dvec4.wzzww).
        /// </summary>
        public dvec5 abbaa => new dvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.wzw swizzling.
        /// </summary>
        public dvec3 wzw => new dvec3(w, z, w);
        
        /// <summary>
        /// Returns dvec4.aba swizzling (equivalent to dvec4.wzw).
        /// </summary>
        public dvec3 aba => new dvec3(w, z, w);
        
        /// <summary>
        /// Returns dvec4.wzwx swizzling.
        /// </summary>
        public dvec4 wzwx => new dvec4(w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.abar swizzling (equivalent to dvec4.wzwx).
        /// </summary>
        public dvec4 abar => new dvec4(w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.wzwxx swizzling.
        /// </summary>
        public dvec5 wzwxx => new dvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.abarr swizzling (equivalent to dvec4.wzwxx).
        /// </summary>
        public dvec5 abarr => new dvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.wzwxy swizzling.
        /// </summary>
        public dvec5 wzwxy => new dvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.abarg swizzling (equivalent to dvec4.wzwxy).
        /// </summary>
        public dvec5 abarg => new dvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.wzwxz swizzling.
        /// </summary>
        public dvec5 wzwxz => new dvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.abarb swizzling (equivalent to dvec4.wzwxz).
        /// </summary>
        public dvec5 abarb => new dvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.wzwxw swizzling.
        /// </summary>
        public dvec5 wzwxw => new dvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.abara swizzling (equivalent to dvec4.wzwxw).
        /// </summary>
        public dvec5 abara => new dvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.wzwy swizzling.
        /// </summary>
        public dvec4 wzwy => new dvec4(w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.abag swizzling (equivalent to dvec4.wzwy).
        /// </summary>
        public dvec4 abag => new dvec4(w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.wzwyx swizzling.
        /// </summary>
        public dvec5 wzwyx => new dvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.abagr swizzling (equivalent to dvec4.wzwyx).
        /// </summary>
        public dvec5 abagr => new dvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.wzwyy swizzling.
        /// </summary>
        public dvec5 wzwyy => new dvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.abagg swizzling (equivalent to dvec4.wzwyy).
        /// </summary>
        public dvec5 abagg => new dvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.wzwyz swizzling.
        /// </summary>
        public dvec5 wzwyz => new dvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.abagb swizzling (equivalent to dvec4.wzwyz).
        /// </summary>
        public dvec5 abagb => new dvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.wzwyw swizzling.
        /// </summary>
        public dvec5 wzwyw => new dvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.abaga swizzling (equivalent to dvec4.wzwyw).
        /// </summary>
        public dvec5 abaga => new dvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.wzwz swizzling.
        /// </summary>
        public dvec4 wzwz => new dvec4(w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.abab swizzling (equivalent to dvec4.wzwz).
        /// </summary>
        public dvec4 abab => new dvec4(w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.wzwzx swizzling.
        /// </summary>
        public dvec5 wzwzx => new dvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.ababr swizzling (equivalent to dvec4.wzwzx).
        /// </summary>
        public dvec5 ababr => new dvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.wzwzy swizzling.
        /// </summary>
        public dvec5 wzwzy => new dvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.ababg swizzling (equivalent to dvec4.wzwzy).
        /// </summary>
        public dvec5 ababg => new dvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.wzwzz swizzling.
        /// </summary>
        public dvec5 wzwzz => new dvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.ababb swizzling (equivalent to dvec4.wzwzz).
        /// </summary>
        public dvec5 ababb => new dvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.wzwzw swizzling.
        /// </summary>
        public dvec5 wzwzw => new dvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.ababa swizzling (equivalent to dvec4.wzwzw).
        /// </summary>
        public dvec5 ababa => new dvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.wzww swizzling.
        /// </summary>
        public dvec4 wzww => new dvec4(w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.abaa swizzling (equivalent to dvec4.wzww).
        /// </summary>
        public dvec4 abaa => new dvec4(w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.wzwwx swizzling.
        /// </summary>
        public dvec5 wzwwx => new dvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.abaar swizzling (equivalent to dvec4.wzwwx).
        /// </summary>
        public dvec5 abaar => new dvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.wzwwy swizzling.
        /// </summary>
        public dvec5 wzwwy => new dvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.abaag swizzling (equivalent to dvec4.wzwwy).
        /// </summary>
        public dvec5 abaag => new dvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.wzwwz swizzling.
        /// </summary>
        public dvec5 wzwwz => new dvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.abaab swizzling (equivalent to dvec4.wzwwz).
        /// </summary>
        public dvec5 abaab => new dvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.wzwww swizzling.
        /// </summary>
        public dvec5 wzwww => new dvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.abaaa swizzling (equivalent to dvec4.wzwww).
        /// </summary>
        public dvec5 abaaa => new dvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.ww swizzling.
        /// </summary>
        public dvec2 ww => new dvec2(w, w);
        
        /// <summary>
        /// Returns dvec4.aa swizzling (equivalent to dvec4.ww).
        /// </summary>
        public dvec2 aa => new dvec2(w, w);
        
        /// <summary>
        /// Returns dvec4.wwx swizzling.
        /// </summary>
        public dvec3 wwx => new dvec3(w, w, x);
        
        /// <summary>
        /// Returns dvec4.aar swizzling (equivalent to dvec4.wwx).
        /// </summary>
        public dvec3 aar => new dvec3(w, w, x);
        
        /// <summary>
        /// Returns dvec4.wwxx swizzling.
        /// </summary>
        public dvec4 wwxx => new dvec4(w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.aarr swizzling (equivalent to dvec4.wwxx).
        /// </summary>
        public dvec4 aarr => new dvec4(w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.wwxxx swizzling.
        /// </summary>
        public dvec5 wwxxx => new dvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.aarrr swizzling (equivalent to dvec4.wwxxx).
        /// </summary>
        public dvec5 aarrr => new dvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.wwxxy swizzling.
        /// </summary>
        public dvec5 wwxxy => new dvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.aarrg swizzling (equivalent to dvec4.wwxxy).
        /// </summary>
        public dvec5 aarrg => new dvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.wwxxz swizzling.
        /// </summary>
        public dvec5 wwxxz => new dvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.aarrb swizzling (equivalent to dvec4.wwxxz).
        /// </summary>
        public dvec5 aarrb => new dvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.wwxxw swizzling.
        /// </summary>
        public dvec5 wwxxw => new dvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.aarra swizzling (equivalent to dvec4.wwxxw).
        /// </summary>
        public dvec5 aarra => new dvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.wwxy swizzling.
        /// </summary>
        public dvec4 wwxy => new dvec4(w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.aarg swizzling (equivalent to dvec4.wwxy).
        /// </summary>
        public dvec4 aarg => new dvec4(w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.wwxyx swizzling.
        /// </summary>
        public dvec5 wwxyx => new dvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.aargr swizzling (equivalent to dvec4.wwxyx).
        /// </summary>
        public dvec5 aargr => new dvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.wwxyy swizzling.
        /// </summary>
        public dvec5 wwxyy => new dvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.aargg swizzling (equivalent to dvec4.wwxyy).
        /// </summary>
        public dvec5 aargg => new dvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.wwxyz swizzling.
        /// </summary>
        public dvec5 wwxyz => new dvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.aargb swizzling (equivalent to dvec4.wwxyz).
        /// </summary>
        public dvec5 aargb => new dvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.wwxyw swizzling.
        /// </summary>
        public dvec5 wwxyw => new dvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.aarga swizzling (equivalent to dvec4.wwxyw).
        /// </summary>
        public dvec5 aarga => new dvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.wwxz swizzling.
        /// </summary>
        public dvec4 wwxz => new dvec4(w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.aarb swizzling (equivalent to dvec4.wwxz).
        /// </summary>
        public dvec4 aarb => new dvec4(w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.wwxzx swizzling.
        /// </summary>
        public dvec5 wwxzx => new dvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.aarbr swizzling (equivalent to dvec4.wwxzx).
        /// </summary>
        public dvec5 aarbr => new dvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.wwxzy swizzling.
        /// </summary>
        public dvec5 wwxzy => new dvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.aarbg swizzling (equivalent to dvec4.wwxzy).
        /// </summary>
        public dvec5 aarbg => new dvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.wwxzz swizzling.
        /// </summary>
        public dvec5 wwxzz => new dvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.aarbb swizzling (equivalent to dvec4.wwxzz).
        /// </summary>
        public dvec5 aarbb => new dvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.wwxzw swizzling.
        /// </summary>
        public dvec5 wwxzw => new dvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.aarba swizzling (equivalent to dvec4.wwxzw).
        /// </summary>
        public dvec5 aarba => new dvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.wwxw swizzling.
        /// </summary>
        public dvec4 wwxw => new dvec4(w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.aara swizzling (equivalent to dvec4.wwxw).
        /// </summary>
        public dvec4 aara => new dvec4(w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.wwxwx swizzling.
        /// </summary>
        public dvec5 wwxwx => new dvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.aarar swizzling (equivalent to dvec4.wwxwx).
        /// </summary>
        public dvec5 aarar => new dvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.wwxwy swizzling.
        /// </summary>
        public dvec5 wwxwy => new dvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.aarag swizzling (equivalent to dvec4.wwxwy).
        /// </summary>
        public dvec5 aarag => new dvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.wwxwz swizzling.
        /// </summary>
        public dvec5 wwxwz => new dvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.aarab swizzling (equivalent to dvec4.wwxwz).
        /// </summary>
        public dvec5 aarab => new dvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.wwxww swizzling.
        /// </summary>
        public dvec5 wwxww => new dvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.aaraa swizzling (equivalent to dvec4.wwxww).
        /// </summary>
        public dvec5 aaraa => new dvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.wwy swizzling.
        /// </summary>
        public dvec3 wwy => new dvec3(w, w, y);
        
        /// <summary>
        /// Returns dvec4.aag swizzling (equivalent to dvec4.wwy).
        /// </summary>
        public dvec3 aag => new dvec3(w, w, y);
        
        /// <summary>
        /// Returns dvec4.wwyx swizzling.
        /// </summary>
        public dvec4 wwyx => new dvec4(w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.aagr swizzling (equivalent to dvec4.wwyx).
        /// </summary>
        public dvec4 aagr => new dvec4(w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.wwyxx swizzling.
        /// </summary>
        public dvec5 wwyxx => new dvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.aagrr swizzling (equivalent to dvec4.wwyxx).
        /// </summary>
        public dvec5 aagrr => new dvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.wwyxy swizzling.
        /// </summary>
        public dvec5 wwyxy => new dvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.aagrg swizzling (equivalent to dvec4.wwyxy).
        /// </summary>
        public dvec5 aagrg => new dvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.wwyxz swizzling.
        /// </summary>
        public dvec5 wwyxz => new dvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.aagrb swizzling (equivalent to dvec4.wwyxz).
        /// </summary>
        public dvec5 aagrb => new dvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.wwyxw swizzling.
        /// </summary>
        public dvec5 wwyxw => new dvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.aagra swizzling (equivalent to dvec4.wwyxw).
        /// </summary>
        public dvec5 aagra => new dvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.wwyy swizzling.
        /// </summary>
        public dvec4 wwyy => new dvec4(w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.aagg swizzling (equivalent to dvec4.wwyy).
        /// </summary>
        public dvec4 aagg => new dvec4(w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.wwyyx swizzling.
        /// </summary>
        public dvec5 wwyyx => new dvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.aaggr swizzling (equivalent to dvec4.wwyyx).
        /// </summary>
        public dvec5 aaggr => new dvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.wwyyy swizzling.
        /// </summary>
        public dvec5 wwyyy => new dvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.aaggg swizzling (equivalent to dvec4.wwyyy).
        /// </summary>
        public dvec5 aaggg => new dvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.wwyyz swizzling.
        /// </summary>
        public dvec5 wwyyz => new dvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.aaggb swizzling (equivalent to dvec4.wwyyz).
        /// </summary>
        public dvec5 aaggb => new dvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.wwyyw swizzling.
        /// </summary>
        public dvec5 wwyyw => new dvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.aagga swizzling (equivalent to dvec4.wwyyw).
        /// </summary>
        public dvec5 aagga => new dvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.wwyz swizzling.
        /// </summary>
        public dvec4 wwyz => new dvec4(w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.aagb swizzling (equivalent to dvec4.wwyz).
        /// </summary>
        public dvec4 aagb => new dvec4(w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.wwyzx swizzling.
        /// </summary>
        public dvec5 wwyzx => new dvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.aagbr swizzling (equivalent to dvec4.wwyzx).
        /// </summary>
        public dvec5 aagbr => new dvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.wwyzy swizzling.
        /// </summary>
        public dvec5 wwyzy => new dvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.aagbg swizzling (equivalent to dvec4.wwyzy).
        /// </summary>
        public dvec5 aagbg => new dvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.wwyzz swizzling.
        /// </summary>
        public dvec5 wwyzz => new dvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.aagbb swizzling (equivalent to dvec4.wwyzz).
        /// </summary>
        public dvec5 aagbb => new dvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.wwyzw swizzling.
        /// </summary>
        public dvec5 wwyzw => new dvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.aagba swizzling (equivalent to dvec4.wwyzw).
        /// </summary>
        public dvec5 aagba => new dvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.wwyw swizzling.
        /// </summary>
        public dvec4 wwyw => new dvec4(w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.aaga swizzling (equivalent to dvec4.wwyw).
        /// </summary>
        public dvec4 aaga => new dvec4(w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.wwywx swizzling.
        /// </summary>
        public dvec5 wwywx => new dvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.aagar swizzling (equivalent to dvec4.wwywx).
        /// </summary>
        public dvec5 aagar => new dvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.wwywy swizzling.
        /// </summary>
        public dvec5 wwywy => new dvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.aagag swizzling (equivalent to dvec4.wwywy).
        /// </summary>
        public dvec5 aagag => new dvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.wwywz swizzling.
        /// </summary>
        public dvec5 wwywz => new dvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.aagab swizzling (equivalent to dvec4.wwywz).
        /// </summary>
        public dvec5 aagab => new dvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.wwyww swizzling.
        /// </summary>
        public dvec5 wwyww => new dvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.aagaa swizzling (equivalent to dvec4.wwyww).
        /// </summary>
        public dvec5 aagaa => new dvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.wwz swizzling.
        /// </summary>
        public dvec3 wwz => new dvec3(w, w, z);
        
        /// <summary>
        /// Returns dvec4.aab swizzling (equivalent to dvec4.wwz).
        /// </summary>
        public dvec3 aab => new dvec3(w, w, z);
        
        /// <summary>
        /// Returns dvec4.wwzx swizzling.
        /// </summary>
        public dvec4 wwzx => new dvec4(w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.aabr swizzling (equivalent to dvec4.wwzx).
        /// </summary>
        public dvec4 aabr => new dvec4(w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.wwzxx swizzling.
        /// </summary>
        public dvec5 wwzxx => new dvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.aabrr swizzling (equivalent to dvec4.wwzxx).
        /// </summary>
        public dvec5 aabrr => new dvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.wwzxy swizzling.
        /// </summary>
        public dvec5 wwzxy => new dvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.aabrg swizzling (equivalent to dvec4.wwzxy).
        /// </summary>
        public dvec5 aabrg => new dvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.wwzxz swizzling.
        /// </summary>
        public dvec5 wwzxz => new dvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.aabrb swizzling (equivalent to dvec4.wwzxz).
        /// </summary>
        public dvec5 aabrb => new dvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.wwzxw swizzling.
        /// </summary>
        public dvec5 wwzxw => new dvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.aabra swizzling (equivalent to dvec4.wwzxw).
        /// </summary>
        public dvec5 aabra => new dvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.wwzy swizzling.
        /// </summary>
        public dvec4 wwzy => new dvec4(w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.aabg swizzling (equivalent to dvec4.wwzy).
        /// </summary>
        public dvec4 aabg => new dvec4(w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.wwzyx swizzling.
        /// </summary>
        public dvec5 wwzyx => new dvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.aabgr swizzling (equivalent to dvec4.wwzyx).
        /// </summary>
        public dvec5 aabgr => new dvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.wwzyy swizzling.
        /// </summary>
        public dvec5 wwzyy => new dvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.aabgg swizzling (equivalent to dvec4.wwzyy).
        /// </summary>
        public dvec5 aabgg => new dvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.wwzyz swizzling.
        /// </summary>
        public dvec5 wwzyz => new dvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.aabgb swizzling (equivalent to dvec4.wwzyz).
        /// </summary>
        public dvec5 aabgb => new dvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.wwzyw swizzling.
        /// </summary>
        public dvec5 wwzyw => new dvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.aabga swizzling (equivalent to dvec4.wwzyw).
        /// </summary>
        public dvec5 aabga => new dvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.wwzz swizzling.
        /// </summary>
        public dvec4 wwzz => new dvec4(w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.aabb swizzling (equivalent to dvec4.wwzz).
        /// </summary>
        public dvec4 aabb => new dvec4(w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.wwzzx swizzling.
        /// </summary>
        public dvec5 wwzzx => new dvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.aabbr swizzling (equivalent to dvec4.wwzzx).
        /// </summary>
        public dvec5 aabbr => new dvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.wwzzy swizzling.
        /// </summary>
        public dvec5 wwzzy => new dvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.aabbg swizzling (equivalent to dvec4.wwzzy).
        /// </summary>
        public dvec5 aabbg => new dvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.wwzzz swizzling.
        /// </summary>
        public dvec5 wwzzz => new dvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.aabbb swizzling (equivalent to dvec4.wwzzz).
        /// </summary>
        public dvec5 aabbb => new dvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.wwzzw swizzling.
        /// </summary>
        public dvec5 wwzzw => new dvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.aabba swizzling (equivalent to dvec4.wwzzw).
        /// </summary>
        public dvec5 aabba => new dvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.wwzw swizzling.
        /// </summary>
        public dvec4 wwzw => new dvec4(w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.aaba swizzling (equivalent to dvec4.wwzw).
        /// </summary>
        public dvec4 aaba => new dvec4(w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.wwzwx swizzling.
        /// </summary>
        public dvec5 wwzwx => new dvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.aabar swizzling (equivalent to dvec4.wwzwx).
        /// </summary>
        public dvec5 aabar => new dvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.wwzwy swizzling.
        /// </summary>
        public dvec5 wwzwy => new dvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.aabag swizzling (equivalent to dvec4.wwzwy).
        /// </summary>
        public dvec5 aabag => new dvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.wwzwz swizzling.
        /// </summary>
        public dvec5 wwzwz => new dvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.aabab swizzling (equivalent to dvec4.wwzwz).
        /// </summary>
        public dvec5 aabab => new dvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.wwzww swizzling.
        /// </summary>
        public dvec5 wwzww => new dvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.aabaa swizzling (equivalent to dvec4.wwzww).
        /// </summary>
        public dvec5 aabaa => new dvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.www swizzling.
        /// </summary>
        public dvec3 www => new dvec3(w, w, w);
        
        /// <summary>
        /// Returns dvec4.aaa swizzling (equivalent to dvec4.www).
        /// </summary>
        public dvec3 aaa => new dvec3(w, w, w);
        
        /// <summary>
        /// Returns dvec4.wwwx swizzling.
        /// </summary>
        public dvec4 wwwx => new dvec4(w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.aaar swizzling (equivalent to dvec4.wwwx).
        /// </summary>
        public dvec4 aaar => new dvec4(w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.wwwxx swizzling.
        /// </summary>
        public dvec5 wwwxx => new dvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.aaarr swizzling (equivalent to dvec4.wwwxx).
        /// </summary>
        public dvec5 aaarr => new dvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.wwwxy swizzling.
        /// </summary>
        public dvec5 wwwxy => new dvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.aaarg swizzling (equivalent to dvec4.wwwxy).
        /// </summary>
        public dvec5 aaarg => new dvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.wwwxz swizzling.
        /// </summary>
        public dvec5 wwwxz => new dvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.aaarb swizzling (equivalent to dvec4.wwwxz).
        /// </summary>
        public dvec5 aaarb => new dvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.wwwxw swizzling.
        /// </summary>
        public dvec5 wwwxw => new dvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.aaara swizzling (equivalent to dvec4.wwwxw).
        /// </summary>
        public dvec5 aaara => new dvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.wwwy swizzling.
        /// </summary>
        public dvec4 wwwy => new dvec4(w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.aaag swizzling (equivalent to dvec4.wwwy).
        /// </summary>
        public dvec4 aaag => new dvec4(w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.wwwyx swizzling.
        /// </summary>
        public dvec5 wwwyx => new dvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.aaagr swizzling (equivalent to dvec4.wwwyx).
        /// </summary>
        public dvec5 aaagr => new dvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.wwwyy swizzling.
        /// </summary>
        public dvec5 wwwyy => new dvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.aaagg swizzling (equivalent to dvec4.wwwyy).
        /// </summary>
        public dvec5 aaagg => new dvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.wwwyz swizzling.
        /// </summary>
        public dvec5 wwwyz => new dvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.aaagb swizzling (equivalent to dvec4.wwwyz).
        /// </summary>
        public dvec5 aaagb => new dvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.wwwyw swizzling.
        /// </summary>
        public dvec5 wwwyw => new dvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.aaaga swizzling (equivalent to dvec4.wwwyw).
        /// </summary>
        public dvec5 aaaga => new dvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.wwwz swizzling.
        /// </summary>
        public dvec4 wwwz => new dvec4(w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.aaab swizzling (equivalent to dvec4.wwwz).
        /// </summary>
        public dvec4 aaab => new dvec4(w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.wwwzx swizzling.
        /// </summary>
        public dvec5 wwwzx => new dvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.aaabr swizzling (equivalent to dvec4.wwwzx).
        /// </summary>
        public dvec5 aaabr => new dvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.wwwzy swizzling.
        /// </summary>
        public dvec5 wwwzy => new dvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.aaabg swizzling (equivalent to dvec4.wwwzy).
        /// </summary>
        public dvec5 aaabg => new dvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.wwwzz swizzling.
        /// </summary>
        public dvec5 wwwzz => new dvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.aaabb swizzling (equivalent to dvec4.wwwzz).
        /// </summary>
        public dvec5 aaabb => new dvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.wwwzw swizzling.
        /// </summary>
        public dvec5 wwwzw => new dvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.aaaba swizzling (equivalent to dvec4.wwwzw).
        /// </summary>
        public dvec5 aaaba => new dvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.wwww swizzling.
        /// </summary>
        public dvec4 wwww => new dvec4(w, w, w, w);
        
        /// <summary>
        /// Returns dvec4.aaaa swizzling (equivalent to dvec4.wwww).
        /// </summary>
        public dvec4 aaaa => new dvec4(w, w, w, w);
        
        /// <summary>
        /// Returns dvec4.wwwwx swizzling.
        /// </summary>
        public dvec5 wwwwx => new dvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.aaaar swizzling (equivalent to dvec4.wwwwx).
        /// </summary>
        public dvec5 aaaar => new dvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.wwwwy swizzling.
        /// </summary>
        public dvec5 wwwwy => new dvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.aaaag swizzling (equivalent to dvec4.wwwwy).
        /// </summary>
        public dvec5 aaaag => new dvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.wwwwz swizzling.
        /// </summary>
        public dvec5 wwwwz => new dvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.aaaab swizzling (equivalent to dvec4.wwwwz).
        /// </summary>
        public dvec5 aaaab => new dvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.wwwww swizzling.
        /// </summary>
        public dvec5 wwwww => new dvec5(w, w, w, w, w);
        
        /// <summary>
        /// Returns dvec4.aaaaa swizzling (equivalent to dvec4.wwwww).
        /// </summary>
        public dvec5 aaaaa => new dvec5(w, w, w, w, w);

        #endregion

    }
}
