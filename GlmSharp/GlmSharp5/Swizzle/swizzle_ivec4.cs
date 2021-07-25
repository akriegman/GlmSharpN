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
    /// Temporary vector of type int with 4 components, used for implementing swizzling for ivec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_ivec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly int x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly int y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly int z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly int w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_ivec4.
        /// </summary>
        internal swizzle_ivec4(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns ivec4.xx swizzling.
        /// </summary>
        public ivec2 xx => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec4.rr swizzling (equivalent to ivec4.xx).
        /// </summary>
        public ivec2 rr => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec4.xxx swizzling.
        /// </summary>
        public ivec3 xxx => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec4.rrr swizzling (equivalent to ivec4.xxx).
        /// </summary>
        public ivec3 rrr => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec4.xxxx swizzling.
        /// </summary>
        public ivec4 xxxx => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.rrrr swizzling (equivalent to ivec4.xxxx).
        /// </summary>
        public ivec4 rrrr => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.xxxxx swizzling.
        /// </summary>
        public ivec5 xxxxx => new ivec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.rrrrr swizzling (equivalent to ivec4.xxxxx).
        /// </summary>
        public ivec5 rrrrr => new ivec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.xxxxy swizzling.
        /// </summary>
        public ivec5 xxxxy => new ivec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.rrrrg swizzling (equivalent to ivec4.xxxxy).
        /// </summary>
        public ivec5 rrrrg => new ivec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.xxxxz swizzling.
        /// </summary>
        public ivec5 xxxxz => new ivec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.rrrrb swizzling (equivalent to ivec4.xxxxz).
        /// </summary>
        public ivec5 rrrrb => new ivec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.xxxxw swizzling.
        /// </summary>
        public ivec5 xxxxw => new ivec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.rrrra swizzling (equivalent to ivec4.xxxxw).
        /// </summary>
        public ivec5 rrrra => new ivec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.xxxy swizzling.
        /// </summary>
        public ivec4 xxxy => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.rrrg swizzling (equivalent to ivec4.xxxy).
        /// </summary>
        public ivec4 rrrg => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.xxxyx swizzling.
        /// </summary>
        public ivec5 xxxyx => new ivec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.rrrgr swizzling (equivalent to ivec4.xxxyx).
        /// </summary>
        public ivec5 rrrgr => new ivec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.xxxyy swizzling.
        /// </summary>
        public ivec5 xxxyy => new ivec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.rrrgg swizzling (equivalent to ivec4.xxxyy).
        /// </summary>
        public ivec5 rrrgg => new ivec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.xxxyz swizzling.
        /// </summary>
        public ivec5 xxxyz => new ivec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.rrrgb swizzling (equivalent to ivec4.xxxyz).
        /// </summary>
        public ivec5 rrrgb => new ivec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.xxxyw swizzling.
        /// </summary>
        public ivec5 xxxyw => new ivec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.rrrga swizzling (equivalent to ivec4.xxxyw).
        /// </summary>
        public ivec5 rrrga => new ivec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.xxxz swizzling.
        /// </summary>
        public ivec4 xxxz => new ivec4(x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.rrrb swizzling (equivalent to ivec4.xxxz).
        /// </summary>
        public ivec4 rrrb => new ivec4(x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.xxxzx swizzling.
        /// </summary>
        public ivec5 xxxzx => new ivec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.rrrbr swizzling (equivalent to ivec4.xxxzx).
        /// </summary>
        public ivec5 rrrbr => new ivec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.xxxzy swizzling.
        /// </summary>
        public ivec5 xxxzy => new ivec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.rrrbg swizzling (equivalent to ivec4.xxxzy).
        /// </summary>
        public ivec5 rrrbg => new ivec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.xxxzz swizzling.
        /// </summary>
        public ivec5 xxxzz => new ivec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.rrrbb swizzling (equivalent to ivec4.xxxzz).
        /// </summary>
        public ivec5 rrrbb => new ivec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.xxxzw swizzling.
        /// </summary>
        public ivec5 xxxzw => new ivec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.rrrba swizzling (equivalent to ivec4.xxxzw).
        /// </summary>
        public ivec5 rrrba => new ivec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.xxxw swizzling.
        /// </summary>
        public ivec4 xxxw => new ivec4(x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.rrra swizzling (equivalent to ivec4.xxxw).
        /// </summary>
        public ivec4 rrra => new ivec4(x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.xxxwx swizzling.
        /// </summary>
        public ivec5 xxxwx => new ivec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.rrrar swizzling (equivalent to ivec4.xxxwx).
        /// </summary>
        public ivec5 rrrar => new ivec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.xxxwy swizzling.
        /// </summary>
        public ivec5 xxxwy => new ivec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.rrrag swizzling (equivalent to ivec4.xxxwy).
        /// </summary>
        public ivec5 rrrag => new ivec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.xxxwz swizzling.
        /// </summary>
        public ivec5 xxxwz => new ivec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.rrrab swizzling (equivalent to ivec4.xxxwz).
        /// </summary>
        public ivec5 rrrab => new ivec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.xxxww swizzling.
        /// </summary>
        public ivec5 xxxww => new ivec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.rrraa swizzling (equivalent to ivec4.xxxww).
        /// </summary>
        public ivec5 rrraa => new ivec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.xxy swizzling.
        /// </summary>
        public ivec3 xxy => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec4.rrg swizzling (equivalent to ivec4.xxy).
        /// </summary>
        public ivec3 rrg => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec4.xxyx swizzling.
        /// </summary>
        public ivec4 xxyx => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.rrgr swizzling (equivalent to ivec4.xxyx).
        /// </summary>
        public ivec4 rrgr => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.xxyxx swizzling.
        /// </summary>
        public ivec5 xxyxx => new ivec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.rrgrr swizzling (equivalent to ivec4.xxyxx).
        /// </summary>
        public ivec5 rrgrr => new ivec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.xxyxy swizzling.
        /// </summary>
        public ivec5 xxyxy => new ivec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.rrgrg swizzling (equivalent to ivec4.xxyxy).
        /// </summary>
        public ivec5 rrgrg => new ivec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.xxyxz swizzling.
        /// </summary>
        public ivec5 xxyxz => new ivec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.rrgrb swizzling (equivalent to ivec4.xxyxz).
        /// </summary>
        public ivec5 rrgrb => new ivec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.xxyxw swizzling.
        /// </summary>
        public ivec5 xxyxw => new ivec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.rrgra swizzling (equivalent to ivec4.xxyxw).
        /// </summary>
        public ivec5 rrgra => new ivec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.xxyy swizzling.
        /// </summary>
        public ivec4 xxyy => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.rrgg swizzling (equivalent to ivec4.xxyy).
        /// </summary>
        public ivec4 rrgg => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.xxyyx swizzling.
        /// </summary>
        public ivec5 xxyyx => new ivec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.rrggr swizzling (equivalent to ivec4.xxyyx).
        /// </summary>
        public ivec5 rrggr => new ivec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.xxyyy swizzling.
        /// </summary>
        public ivec5 xxyyy => new ivec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.rrggg swizzling (equivalent to ivec4.xxyyy).
        /// </summary>
        public ivec5 rrggg => new ivec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.xxyyz swizzling.
        /// </summary>
        public ivec5 xxyyz => new ivec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.rrggb swizzling (equivalent to ivec4.xxyyz).
        /// </summary>
        public ivec5 rrggb => new ivec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.xxyyw swizzling.
        /// </summary>
        public ivec5 xxyyw => new ivec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.rrgga swizzling (equivalent to ivec4.xxyyw).
        /// </summary>
        public ivec5 rrgga => new ivec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.xxyz swizzling.
        /// </summary>
        public ivec4 xxyz => new ivec4(x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.rrgb swizzling (equivalent to ivec4.xxyz).
        /// </summary>
        public ivec4 rrgb => new ivec4(x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.xxyzx swizzling.
        /// </summary>
        public ivec5 xxyzx => new ivec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.rrgbr swizzling (equivalent to ivec4.xxyzx).
        /// </summary>
        public ivec5 rrgbr => new ivec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.xxyzy swizzling.
        /// </summary>
        public ivec5 xxyzy => new ivec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.rrgbg swizzling (equivalent to ivec4.xxyzy).
        /// </summary>
        public ivec5 rrgbg => new ivec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.xxyzz swizzling.
        /// </summary>
        public ivec5 xxyzz => new ivec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.rrgbb swizzling (equivalent to ivec4.xxyzz).
        /// </summary>
        public ivec5 rrgbb => new ivec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.xxyzw swizzling.
        /// </summary>
        public ivec5 xxyzw => new ivec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.rrgba swizzling (equivalent to ivec4.xxyzw).
        /// </summary>
        public ivec5 rrgba => new ivec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.xxyw swizzling.
        /// </summary>
        public ivec4 xxyw => new ivec4(x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.rrga swizzling (equivalent to ivec4.xxyw).
        /// </summary>
        public ivec4 rrga => new ivec4(x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.xxywx swizzling.
        /// </summary>
        public ivec5 xxywx => new ivec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.rrgar swizzling (equivalent to ivec4.xxywx).
        /// </summary>
        public ivec5 rrgar => new ivec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.xxywy swizzling.
        /// </summary>
        public ivec5 xxywy => new ivec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.rrgag swizzling (equivalent to ivec4.xxywy).
        /// </summary>
        public ivec5 rrgag => new ivec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.xxywz swizzling.
        /// </summary>
        public ivec5 xxywz => new ivec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.rrgab swizzling (equivalent to ivec4.xxywz).
        /// </summary>
        public ivec5 rrgab => new ivec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.xxyww swizzling.
        /// </summary>
        public ivec5 xxyww => new ivec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.rrgaa swizzling (equivalent to ivec4.xxyww).
        /// </summary>
        public ivec5 rrgaa => new ivec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.xxz swizzling.
        /// </summary>
        public ivec3 xxz => new ivec3(x, x, z);
        
        /// <summary>
        /// Returns ivec4.rrb swizzling (equivalent to ivec4.xxz).
        /// </summary>
        public ivec3 rrb => new ivec3(x, x, z);
        
        /// <summary>
        /// Returns ivec4.xxzx swizzling.
        /// </summary>
        public ivec4 xxzx => new ivec4(x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.rrbr swizzling (equivalent to ivec4.xxzx).
        /// </summary>
        public ivec4 rrbr => new ivec4(x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.xxzxx swizzling.
        /// </summary>
        public ivec5 xxzxx => new ivec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.rrbrr swizzling (equivalent to ivec4.xxzxx).
        /// </summary>
        public ivec5 rrbrr => new ivec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.xxzxy swizzling.
        /// </summary>
        public ivec5 xxzxy => new ivec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.rrbrg swizzling (equivalent to ivec4.xxzxy).
        /// </summary>
        public ivec5 rrbrg => new ivec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.xxzxz swizzling.
        /// </summary>
        public ivec5 xxzxz => new ivec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.rrbrb swizzling (equivalent to ivec4.xxzxz).
        /// </summary>
        public ivec5 rrbrb => new ivec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.xxzxw swizzling.
        /// </summary>
        public ivec5 xxzxw => new ivec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.rrbra swizzling (equivalent to ivec4.xxzxw).
        /// </summary>
        public ivec5 rrbra => new ivec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.xxzy swizzling.
        /// </summary>
        public ivec4 xxzy => new ivec4(x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.rrbg swizzling (equivalent to ivec4.xxzy).
        /// </summary>
        public ivec4 rrbg => new ivec4(x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.xxzyx swizzling.
        /// </summary>
        public ivec5 xxzyx => new ivec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.rrbgr swizzling (equivalent to ivec4.xxzyx).
        /// </summary>
        public ivec5 rrbgr => new ivec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.xxzyy swizzling.
        /// </summary>
        public ivec5 xxzyy => new ivec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.rrbgg swizzling (equivalent to ivec4.xxzyy).
        /// </summary>
        public ivec5 rrbgg => new ivec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.xxzyz swizzling.
        /// </summary>
        public ivec5 xxzyz => new ivec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.rrbgb swizzling (equivalent to ivec4.xxzyz).
        /// </summary>
        public ivec5 rrbgb => new ivec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.xxzyw swizzling.
        /// </summary>
        public ivec5 xxzyw => new ivec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.rrbga swizzling (equivalent to ivec4.xxzyw).
        /// </summary>
        public ivec5 rrbga => new ivec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.xxzz swizzling.
        /// </summary>
        public ivec4 xxzz => new ivec4(x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.rrbb swizzling (equivalent to ivec4.xxzz).
        /// </summary>
        public ivec4 rrbb => new ivec4(x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.xxzzx swizzling.
        /// </summary>
        public ivec5 xxzzx => new ivec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.rrbbr swizzling (equivalent to ivec4.xxzzx).
        /// </summary>
        public ivec5 rrbbr => new ivec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.xxzzy swizzling.
        /// </summary>
        public ivec5 xxzzy => new ivec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.rrbbg swizzling (equivalent to ivec4.xxzzy).
        /// </summary>
        public ivec5 rrbbg => new ivec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.xxzzz swizzling.
        /// </summary>
        public ivec5 xxzzz => new ivec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.rrbbb swizzling (equivalent to ivec4.xxzzz).
        /// </summary>
        public ivec5 rrbbb => new ivec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.xxzzw swizzling.
        /// </summary>
        public ivec5 xxzzw => new ivec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.rrbba swizzling (equivalent to ivec4.xxzzw).
        /// </summary>
        public ivec5 rrbba => new ivec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.xxzw swizzling.
        /// </summary>
        public ivec4 xxzw => new ivec4(x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.rrba swizzling (equivalent to ivec4.xxzw).
        /// </summary>
        public ivec4 rrba => new ivec4(x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.xxzwx swizzling.
        /// </summary>
        public ivec5 xxzwx => new ivec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.rrbar swizzling (equivalent to ivec4.xxzwx).
        /// </summary>
        public ivec5 rrbar => new ivec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.xxzwy swizzling.
        /// </summary>
        public ivec5 xxzwy => new ivec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.rrbag swizzling (equivalent to ivec4.xxzwy).
        /// </summary>
        public ivec5 rrbag => new ivec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.xxzwz swizzling.
        /// </summary>
        public ivec5 xxzwz => new ivec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.rrbab swizzling (equivalent to ivec4.xxzwz).
        /// </summary>
        public ivec5 rrbab => new ivec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.xxzww swizzling.
        /// </summary>
        public ivec5 xxzww => new ivec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.rrbaa swizzling (equivalent to ivec4.xxzww).
        /// </summary>
        public ivec5 rrbaa => new ivec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.xxw swizzling.
        /// </summary>
        public ivec3 xxw => new ivec3(x, x, w);
        
        /// <summary>
        /// Returns ivec4.rra swizzling (equivalent to ivec4.xxw).
        /// </summary>
        public ivec3 rra => new ivec3(x, x, w);
        
        /// <summary>
        /// Returns ivec4.xxwx swizzling.
        /// </summary>
        public ivec4 xxwx => new ivec4(x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.rrar swizzling (equivalent to ivec4.xxwx).
        /// </summary>
        public ivec4 rrar => new ivec4(x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.xxwxx swizzling.
        /// </summary>
        public ivec5 xxwxx => new ivec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.rrarr swizzling (equivalent to ivec4.xxwxx).
        /// </summary>
        public ivec5 rrarr => new ivec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.xxwxy swizzling.
        /// </summary>
        public ivec5 xxwxy => new ivec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.rrarg swizzling (equivalent to ivec4.xxwxy).
        /// </summary>
        public ivec5 rrarg => new ivec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.xxwxz swizzling.
        /// </summary>
        public ivec5 xxwxz => new ivec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.rrarb swizzling (equivalent to ivec4.xxwxz).
        /// </summary>
        public ivec5 rrarb => new ivec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.xxwxw swizzling.
        /// </summary>
        public ivec5 xxwxw => new ivec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.rrara swizzling (equivalent to ivec4.xxwxw).
        /// </summary>
        public ivec5 rrara => new ivec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.xxwy swizzling.
        /// </summary>
        public ivec4 xxwy => new ivec4(x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.rrag swizzling (equivalent to ivec4.xxwy).
        /// </summary>
        public ivec4 rrag => new ivec4(x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.xxwyx swizzling.
        /// </summary>
        public ivec5 xxwyx => new ivec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.rragr swizzling (equivalent to ivec4.xxwyx).
        /// </summary>
        public ivec5 rragr => new ivec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.xxwyy swizzling.
        /// </summary>
        public ivec5 xxwyy => new ivec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.rragg swizzling (equivalent to ivec4.xxwyy).
        /// </summary>
        public ivec5 rragg => new ivec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.xxwyz swizzling.
        /// </summary>
        public ivec5 xxwyz => new ivec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.rragb swizzling (equivalent to ivec4.xxwyz).
        /// </summary>
        public ivec5 rragb => new ivec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.xxwyw swizzling.
        /// </summary>
        public ivec5 xxwyw => new ivec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.rraga swizzling (equivalent to ivec4.xxwyw).
        /// </summary>
        public ivec5 rraga => new ivec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.xxwz swizzling.
        /// </summary>
        public ivec4 xxwz => new ivec4(x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.rrab swizzling (equivalent to ivec4.xxwz).
        /// </summary>
        public ivec4 rrab => new ivec4(x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.xxwzx swizzling.
        /// </summary>
        public ivec5 xxwzx => new ivec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.rrabr swizzling (equivalent to ivec4.xxwzx).
        /// </summary>
        public ivec5 rrabr => new ivec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.xxwzy swizzling.
        /// </summary>
        public ivec5 xxwzy => new ivec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.rrabg swizzling (equivalent to ivec4.xxwzy).
        /// </summary>
        public ivec5 rrabg => new ivec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.xxwzz swizzling.
        /// </summary>
        public ivec5 xxwzz => new ivec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.rrabb swizzling (equivalent to ivec4.xxwzz).
        /// </summary>
        public ivec5 rrabb => new ivec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.xxwzw swizzling.
        /// </summary>
        public ivec5 xxwzw => new ivec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.rraba swizzling (equivalent to ivec4.xxwzw).
        /// </summary>
        public ivec5 rraba => new ivec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.xxww swizzling.
        /// </summary>
        public ivec4 xxww => new ivec4(x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.rraa swizzling (equivalent to ivec4.xxww).
        /// </summary>
        public ivec4 rraa => new ivec4(x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.xxwwx swizzling.
        /// </summary>
        public ivec5 xxwwx => new ivec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.rraar swizzling (equivalent to ivec4.xxwwx).
        /// </summary>
        public ivec5 rraar => new ivec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.xxwwy swizzling.
        /// </summary>
        public ivec5 xxwwy => new ivec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.rraag swizzling (equivalent to ivec4.xxwwy).
        /// </summary>
        public ivec5 rraag => new ivec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.xxwwz swizzling.
        /// </summary>
        public ivec5 xxwwz => new ivec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.rraab swizzling (equivalent to ivec4.xxwwz).
        /// </summary>
        public ivec5 rraab => new ivec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.xxwww swizzling.
        /// </summary>
        public ivec5 xxwww => new ivec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.rraaa swizzling (equivalent to ivec4.xxwww).
        /// </summary>
        public ivec5 rraaa => new ivec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.xy swizzling.
        /// </summary>
        public ivec2 xy => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec4.rg swizzling (equivalent to ivec4.xy).
        /// </summary>
        public ivec2 rg => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec4.xyx swizzling.
        /// </summary>
        public ivec3 xyx => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec4.rgr swizzling (equivalent to ivec4.xyx).
        /// </summary>
        public ivec3 rgr => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec4.xyxx swizzling.
        /// </summary>
        public ivec4 xyxx => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.rgrr swizzling (equivalent to ivec4.xyxx).
        /// </summary>
        public ivec4 rgrr => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.xyxxx swizzling.
        /// </summary>
        public ivec5 xyxxx => new ivec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.rgrrr swizzling (equivalent to ivec4.xyxxx).
        /// </summary>
        public ivec5 rgrrr => new ivec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.xyxxy swizzling.
        /// </summary>
        public ivec5 xyxxy => new ivec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.rgrrg swizzling (equivalent to ivec4.xyxxy).
        /// </summary>
        public ivec5 rgrrg => new ivec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.xyxxz swizzling.
        /// </summary>
        public ivec5 xyxxz => new ivec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.rgrrb swizzling (equivalent to ivec4.xyxxz).
        /// </summary>
        public ivec5 rgrrb => new ivec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.xyxxw swizzling.
        /// </summary>
        public ivec5 xyxxw => new ivec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.rgrra swizzling (equivalent to ivec4.xyxxw).
        /// </summary>
        public ivec5 rgrra => new ivec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.xyxy swizzling.
        /// </summary>
        public ivec4 xyxy => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.rgrg swizzling (equivalent to ivec4.xyxy).
        /// </summary>
        public ivec4 rgrg => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.xyxyx swizzling.
        /// </summary>
        public ivec5 xyxyx => new ivec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.rgrgr swizzling (equivalent to ivec4.xyxyx).
        /// </summary>
        public ivec5 rgrgr => new ivec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.xyxyy swizzling.
        /// </summary>
        public ivec5 xyxyy => new ivec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.rgrgg swizzling (equivalent to ivec4.xyxyy).
        /// </summary>
        public ivec5 rgrgg => new ivec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.xyxyz swizzling.
        /// </summary>
        public ivec5 xyxyz => new ivec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.rgrgb swizzling (equivalent to ivec4.xyxyz).
        /// </summary>
        public ivec5 rgrgb => new ivec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.xyxyw swizzling.
        /// </summary>
        public ivec5 xyxyw => new ivec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.rgrga swizzling (equivalent to ivec4.xyxyw).
        /// </summary>
        public ivec5 rgrga => new ivec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.xyxz swizzling.
        /// </summary>
        public ivec4 xyxz => new ivec4(x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.rgrb swizzling (equivalent to ivec4.xyxz).
        /// </summary>
        public ivec4 rgrb => new ivec4(x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.xyxzx swizzling.
        /// </summary>
        public ivec5 xyxzx => new ivec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.rgrbr swizzling (equivalent to ivec4.xyxzx).
        /// </summary>
        public ivec5 rgrbr => new ivec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.xyxzy swizzling.
        /// </summary>
        public ivec5 xyxzy => new ivec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.rgrbg swizzling (equivalent to ivec4.xyxzy).
        /// </summary>
        public ivec5 rgrbg => new ivec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.xyxzz swizzling.
        /// </summary>
        public ivec5 xyxzz => new ivec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.rgrbb swizzling (equivalent to ivec4.xyxzz).
        /// </summary>
        public ivec5 rgrbb => new ivec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.xyxzw swizzling.
        /// </summary>
        public ivec5 xyxzw => new ivec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.rgrba swizzling (equivalent to ivec4.xyxzw).
        /// </summary>
        public ivec5 rgrba => new ivec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.xyxw swizzling.
        /// </summary>
        public ivec4 xyxw => new ivec4(x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.rgra swizzling (equivalent to ivec4.xyxw).
        /// </summary>
        public ivec4 rgra => new ivec4(x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.xyxwx swizzling.
        /// </summary>
        public ivec5 xyxwx => new ivec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.rgrar swizzling (equivalent to ivec4.xyxwx).
        /// </summary>
        public ivec5 rgrar => new ivec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.xyxwy swizzling.
        /// </summary>
        public ivec5 xyxwy => new ivec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.rgrag swizzling (equivalent to ivec4.xyxwy).
        /// </summary>
        public ivec5 rgrag => new ivec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.xyxwz swizzling.
        /// </summary>
        public ivec5 xyxwz => new ivec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.rgrab swizzling (equivalent to ivec4.xyxwz).
        /// </summary>
        public ivec5 rgrab => new ivec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.xyxww swizzling.
        /// </summary>
        public ivec5 xyxww => new ivec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.rgraa swizzling (equivalent to ivec4.xyxww).
        /// </summary>
        public ivec5 rgraa => new ivec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.xyy swizzling.
        /// </summary>
        public ivec3 xyy => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec4.rgg swizzling (equivalent to ivec4.xyy).
        /// </summary>
        public ivec3 rgg => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec4.xyyx swizzling.
        /// </summary>
        public ivec4 xyyx => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.rggr swizzling (equivalent to ivec4.xyyx).
        /// </summary>
        public ivec4 rggr => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.xyyxx swizzling.
        /// </summary>
        public ivec5 xyyxx => new ivec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.rggrr swizzling (equivalent to ivec4.xyyxx).
        /// </summary>
        public ivec5 rggrr => new ivec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.xyyxy swizzling.
        /// </summary>
        public ivec5 xyyxy => new ivec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.rggrg swizzling (equivalent to ivec4.xyyxy).
        /// </summary>
        public ivec5 rggrg => new ivec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.xyyxz swizzling.
        /// </summary>
        public ivec5 xyyxz => new ivec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.rggrb swizzling (equivalent to ivec4.xyyxz).
        /// </summary>
        public ivec5 rggrb => new ivec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.xyyxw swizzling.
        /// </summary>
        public ivec5 xyyxw => new ivec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.rggra swizzling (equivalent to ivec4.xyyxw).
        /// </summary>
        public ivec5 rggra => new ivec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.xyyy swizzling.
        /// </summary>
        public ivec4 xyyy => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.rggg swizzling (equivalent to ivec4.xyyy).
        /// </summary>
        public ivec4 rggg => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.xyyyx swizzling.
        /// </summary>
        public ivec5 xyyyx => new ivec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.rgggr swizzling (equivalent to ivec4.xyyyx).
        /// </summary>
        public ivec5 rgggr => new ivec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.xyyyy swizzling.
        /// </summary>
        public ivec5 xyyyy => new ivec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.rgggg swizzling (equivalent to ivec4.xyyyy).
        /// </summary>
        public ivec5 rgggg => new ivec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.xyyyz swizzling.
        /// </summary>
        public ivec5 xyyyz => new ivec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.rgggb swizzling (equivalent to ivec4.xyyyz).
        /// </summary>
        public ivec5 rgggb => new ivec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.xyyyw swizzling.
        /// </summary>
        public ivec5 xyyyw => new ivec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.rggga swizzling (equivalent to ivec4.xyyyw).
        /// </summary>
        public ivec5 rggga => new ivec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.xyyz swizzling.
        /// </summary>
        public ivec4 xyyz => new ivec4(x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.rggb swizzling (equivalent to ivec4.xyyz).
        /// </summary>
        public ivec4 rggb => new ivec4(x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.xyyzx swizzling.
        /// </summary>
        public ivec5 xyyzx => new ivec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.rggbr swizzling (equivalent to ivec4.xyyzx).
        /// </summary>
        public ivec5 rggbr => new ivec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.xyyzy swizzling.
        /// </summary>
        public ivec5 xyyzy => new ivec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.rggbg swizzling (equivalent to ivec4.xyyzy).
        /// </summary>
        public ivec5 rggbg => new ivec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.xyyzz swizzling.
        /// </summary>
        public ivec5 xyyzz => new ivec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.rggbb swizzling (equivalent to ivec4.xyyzz).
        /// </summary>
        public ivec5 rggbb => new ivec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.xyyzw swizzling.
        /// </summary>
        public ivec5 xyyzw => new ivec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.rggba swizzling (equivalent to ivec4.xyyzw).
        /// </summary>
        public ivec5 rggba => new ivec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.xyyw swizzling.
        /// </summary>
        public ivec4 xyyw => new ivec4(x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.rgga swizzling (equivalent to ivec4.xyyw).
        /// </summary>
        public ivec4 rgga => new ivec4(x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.xyywx swizzling.
        /// </summary>
        public ivec5 xyywx => new ivec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.rggar swizzling (equivalent to ivec4.xyywx).
        /// </summary>
        public ivec5 rggar => new ivec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.xyywy swizzling.
        /// </summary>
        public ivec5 xyywy => new ivec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.rggag swizzling (equivalent to ivec4.xyywy).
        /// </summary>
        public ivec5 rggag => new ivec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.xyywz swizzling.
        /// </summary>
        public ivec5 xyywz => new ivec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.rggab swizzling (equivalent to ivec4.xyywz).
        /// </summary>
        public ivec5 rggab => new ivec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.xyyww swizzling.
        /// </summary>
        public ivec5 xyyww => new ivec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.rggaa swizzling (equivalent to ivec4.xyyww).
        /// </summary>
        public ivec5 rggaa => new ivec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.xyz swizzling.
        /// </summary>
        public ivec3 xyz => new ivec3(x, y, z);
        
        /// <summary>
        /// Returns ivec4.rgb swizzling (equivalent to ivec4.xyz).
        /// </summary>
        public ivec3 rgb => new ivec3(x, y, z);
        
        /// <summary>
        /// Returns ivec4.xyzx swizzling.
        /// </summary>
        public ivec4 xyzx => new ivec4(x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.rgbr swizzling (equivalent to ivec4.xyzx).
        /// </summary>
        public ivec4 rgbr => new ivec4(x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.xyzxx swizzling.
        /// </summary>
        public ivec5 xyzxx => new ivec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.rgbrr swizzling (equivalent to ivec4.xyzxx).
        /// </summary>
        public ivec5 rgbrr => new ivec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.xyzxy swizzling.
        /// </summary>
        public ivec5 xyzxy => new ivec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.rgbrg swizzling (equivalent to ivec4.xyzxy).
        /// </summary>
        public ivec5 rgbrg => new ivec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.xyzxz swizzling.
        /// </summary>
        public ivec5 xyzxz => new ivec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.rgbrb swizzling (equivalent to ivec4.xyzxz).
        /// </summary>
        public ivec5 rgbrb => new ivec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.xyzxw swizzling.
        /// </summary>
        public ivec5 xyzxw => new ivec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.rgbra swizzling (equivalent to ivec4.xyzxw).
        /// </summary>
        public ivec5 rgbra => new ivec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.xyzy swizzling.
        /// </summary>
        public ivec4 xyzy => new ivec4(x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.rgbg swizzling (equivalent to ivec4.xyzy).
        /// </summary>
        public ivec4 rgbg => new ivec4(x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.xyzyx swizzling.
        /// </summary>
        public ivec5 xyzyx => new ivec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.rgbgr swizzling (equivalent to ivec4.xyzyx).
        /// </summary>
        public ivec5 rgbgr => new ivec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.xyzyy swizzling.
        /// </summary>
        public ivec5 xyzyy => new ivec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.rgbgg swizzling (equivalent to ivec4.xyzyy).
        /// </summary>
        public ivec5 rgbgg => new ivec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.xyzyz swizzling.
        /// </summary>
        public ivec5 xyzyz => new ivec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.rgbgb swizzling (equivalent to ivec4.xyzyz).
        /// </summary>
        public ivec5 rgbgb => new ivec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.xyzyw swizzling.
        /// </summary>
        public ivec5 xyzyw => new ivec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.rgbga swizzling (equivalent to ivec4.xyzyw).
        /// </summary>
        public ivec5 rgbga => new ivec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.xyzz swizzling.
        /// </summary>
        public ivec4 xyzz => new ivec4(x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.rgbb swizzling (equivalent to ivec4.xyzz).
        /// </summary>
        public ivec4 rgbb => new ivec4(x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.xyzzx swizzling.
        /// </summary>
        public ivec5 xyzzx => new ivec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.rgbbr swizzling (equivalent to ivec4.xyzzx).
        /// </summary>
        public ivec5 rgbbr => new ivec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.xyzzy swizzling.
        /// </summary>
        public ivec5 xyzzy => new ivec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.rgbbg swizzling (equivalent to ivec4.xyzzy).
        /// </summary>
        public ivec5 rgbbg => new ivec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.xyzzz swizzling.
        /// </summary>
        public ivec5 xyzzz => new ivec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.rgbbb swizzling (equivalent to ivec4.xyzzz).
        /// </summary>
        public ivec5 rgbbb => new ivec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.xyzzw swizzling.
        /// </summary>
        public ivec5 xyzzw => new ivec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.rgbba swizzling (equivalent to ivec4.xyzzw).
        /// </summary>
        public ivec5 rgbba => new ivec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.xyzw swizzling.
        /// </summary>
        public ivec4 xyzw => new ivec4(x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.rgba swizzling (equivalent to ivec4.xyzw).
        /// </summary>
        public ivec4 rgba => new ivec4(x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.xyzwx swizzling.
        /// </summary>
        public ivec5 xyzwx => new ivec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.rgbar swizzling (equivalent to ivec4.xyzwx).
        /// </summary>
        public ivec5 rgbar => new ivec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.xyzwy swizzling.
        /// </summary>
        public ivec5 xyzwy => new ivec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.rgbag swizzling (equivalent to ivec4.xyzwy).
        /// </summary>
        public ivec5 rgbag => new ivec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.xyzwz swizzling.
        /// </summary>
        public ivec5 xyzwz => new ivec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.rgbab swizzling (equivalent to ivec4.xyzwz).
        /// </summary>
        public ivec5 rgbab => new ivec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.xyzww swizzling.
        /// </summary>
        public ivec5 xyzww => new ivec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.rgbaa swizzling (equivalent to ivec4.xyzww).
        /// </summary>
        public ivec5 rgbaa => new ivec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.xyw swizzling.
        /// </summary>
        public ivec3 xyw => new ivec3(x, y, w);
        
        /// <summary>
        /// Returns ivec4.rga swizzling (equivalent to ivec4.xyw).
        /// </summary>
        public ivec3 rga => new ivec3(x, y, w);
        
        /// <summary>
        /// Returns ivec4.xywx swizzling.
        /// </summary>
        public ivec4 xywx => new ivec4(x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.rgar swizzling (equivalent to ivec4.xywx).
        /// </summary>
        public ivec4 rgar => new ivec4(x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.xywxx swizzling.
        /// </summary>
        public ivec5 xywxx => new ivec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.rgarr swizzling (equivalent to ivec4.xywxx).
        /// </summary>
        public ivec5 rgarr => new ivec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.xywxy swizzling.
        /// </summary>
        public ivec5 xywxy => new ivec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.rgarg swizzling (equivalent to ivec4.xywxy).
        /// </summary>
        public ivec5 rgarg => new ivec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.xywxz swizzling.
        /// </summary>
        public ivec5 xywxz => new ivec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.rgarb swizzling (equivalent to ivec4.xywxz).
        /// </summary>
        public ivec5 rgarb => new ivec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.xywxw swizzling.
        /// </summary>
        public ivec5 xywxw => new ivec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.rgara swizzling (equivalent to ivec4.xywxw).
        /// </summary>
        public ivec5 rgara => new ivec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.xywy swizzling.
        /// </summary>
        public ivec4 xywy => new ivec4(x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.rgag swizzling (equivalent to ivec4.xywy).
        /// </summary>
        public ivec4 rgag => new ivec4(x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.xywyx swizzling.
        /// </summary>
        public ivec5 xywyx => new ivec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.rgagr swizzling (equivalent to ivec4.xywyx).
        /// </summary>
        public ivec5 rgagr => new ivec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.xywyy swizzling.
        /// </summary>
        public ivec5 xywyy => new ivec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.rgagg swizzling (equivalent to ivec4.xywyy).
        /// </summary>
        public ivec5 rgagg => new ivec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.xywyz swizzling.
        /// </summary>
        public ivec5 xywyz => new ivec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.rgagb swizzling (equivalent to ivec4.xywyz).
        /// </summary>
        public ivec5 rgagb => new ivec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.xywyw swizzling.
        /// </summary>
        public ivec5 xywyw => new ivec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.rgaga swizzling (equivalent to ivec4.xywyw).
        /// </summary>
        public ivec5 rgaga => new ivec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.xywz swizzling.
        /// </summary>
        public ivec4 xywz => new ivec4(x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.rgab swizzling (equivalent to ivec4.xywz).
        /// </summary>
        public ivec4 rgab => new ivec4(x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.xywzx swizzling.
        /// </summary>
        public ivec5 xywzx => new ivec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.rgabr swizzling (equivalent to ivec4.xywzx).
        /// </summary>
        public ivec5 rgabr => new ivec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.xywzy swizzling.
        /// </summary>
        public ivec5 xywzy => new ivec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.rgabg swizzling (equivalent to ivec4.xywzy).
        /// </summary>
        public ivec5 rgabg => new ivec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.xywzz swizzling.
        /// </summary>
        public ivec5 xywzz => new ivec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.rgabb swizzling (equivalent to ivec4.xywzz).
        /// </summary>
        public ivec5 rgabb => new ivec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.xywzw swizzling.
        /// </summary>
        public ivec5 xywzw => new ivec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.rgaba swizzling (equivalent to ivec4.xywzw).
        /// </summary>
        public ivec5 rgaba => new ivec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.xyww swizzling.
        /// </summary>
        public ivec4 xyww => new ivec4(x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.rgaa swizzling (equivalent to ivec4.xyww).
        /// </summary>
        public ivec4 rgaa => new ivec4(x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.xywwx swizzling.
        /// </summary>
        public ivec5 xywwx => new ivec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.rgaar swizzling (equivalent to ivec4.xywwx).
        /// </summary>
        public ivec5 rgaar => new ivec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.xywwy swizzling.
        /// </summary>
        public ivec5 xywwy => new ivec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.rgaag swizzling (equivalent to ivec4.xywwy).
        /// </summary>
        public ivec5 rgaag => new ivec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.xywwz swizzling.
        /// </summary>
        public ivec5 xywwz => new ivec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.rgaab swizzling (equivalent to ivec4.xywwz).
        /// </summary>
        public ivec5 rgaab => new ivec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.xywww swizzling.
        /// </summary>
        public ivec5 xywww => new ivec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.rgaaa swizzling (equivalent to ivec4.xywww).
        /// </summary>
        public ivec5 rgaaa => new ivec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.xz swizzling.
        /// </summary>
        public ivec2 xz => new ivec2(x, z);
        
        /// <summary>
        /// Returns ivec4.rb swizzling (equivalent to ivec4.xz).
        /// </summary>
        public ivec2 rb => new ivec2(x, z);
        
        /// <summary>
        /// Returns ivec4.xzx swizzling.
        /// </summary>
        public ivec3 xzx => new ivec3(x, z, x);
        
        /// <summary>
        /// Returns ivec4.rbr swizzling (equivalent to ivec4.xzx).
        /// </summary>
        public ivec3 rbr => new ivec3(x, z, x);
        
        /// <summary>
        /// Returns ivec4.xzxx swizzling.
        /// </summary>
        public ivec4 xzxx => new ivec4(x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.rbrr swizzling (equivalent to ivec4.xzxx).
        /// </summary>
        public ivec4 rbrr => new ivec4(x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.xzxxx swizzling.
        /// </summary>
        public ivec5 xzxxx => new ivec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.rbrrr swizzling (equivalent to ivec4.xzxxx).
        /// </summary>
        public ivec5 rbrrr => new ivec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.xzxxy swizzling.
        /// </summary>
        public ivec5 xzxxy => new ivec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.rbrrg swizzling (equivalent to ivec4.xzxxy).
        /// </summary>
        public ivec5 rbrrg => new ivec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.xzxxz swizzling.
        /// </summary>
        public ivec5 xzxxz => new ivec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.rbrrb swizzling (equivalent to ivec4.xzxxz).
        /// </summary>
        public ivec5 rbrrb => new ivec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.xzxxw swizzling.
        /// </summary>
        public ivec5 xzxxw => new ivec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.rbrra swizzling (equivalent to ivec4.xzxxw).
        /// </summary>
        public ivec5 rbrra => new ivec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.xzxy swizzling.
        /// </summary>
        public ivec4 xzxy => new ivec4(x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.rbrg swizzling (equivalent to ivec4.xzxy).
        /// </summary>
        public ivec4 rbrg => new ivec4(x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.xzxyx swizzling.
        /// </summary>
        public ivec5 xzxyx => new ivec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.rbrgr swizzling (equivalent to ivec4.xzxyx).
        /// </summary>
        public ivec5 rbrgr => new ivec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.xzxyy swizzling.
        /// </summary>
        public ivec5 xzxyy => new ivec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.rbrgg swizzling (equivalent to ivec4.xzxyy).
        /// </summary>
        public ivec5 rbrgg => new ivec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.xzxyz swizzling.
        /// </summary>
        public ivec5 xzxyz => new ivec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.rbrgb swizzling (equivalent to ivec4.xzxyz).
        /// </summary>
        public ivec5 rbrgb => new ivec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.xzxyw swizzling.
        /// </summary>
        public ivec5 xzxyw => new ivec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.rbrga swizzling (equivalent to ivec4.xzxyw).
        /// </summary>
        public ivec5 rbrga => new ivec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.xzxz swizzling.
        /// </summary>
        public ivec4 xzxz => new ivec4(x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.rbrb swizzling (equivalent to ivec4.xzxz).
        /// </summary>
        public ivec4 rbrb => new ivec4(x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.xzxzx swizzling.
        /// </summary>
        public ivec5 xzxzx => new ivec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.rbrbr swizzling (equivalent to ivec4.xzxzx).
        /// </summary>
        public ivec5 rbrbr => new ivec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.xzxzy swizzling.
        /// </summary>
        public ivec5 xzxzy => new ivec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.rbrbg swizzling (equivalent to ivec4.xzxzy).
        /// </summary>
        public ivec5 rbrbg => new ivec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.xzxzz swizzling.
        /// </summary>
        public ivec5 xzxzz => new ivec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.rbrbb swizzling (equivalent to ivec4.xzxzz).
        /// </summary>
        public ivec5 rbrbb => new ivec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.xzxzw swizzling.
        /// </summary>
        public ivec5 xzxzw => new ivec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.rbrba swizzling (equivalent to ivec4.xzxzw).
        /// </summary>
        public ivec5 rbrba => new ivec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.xzxw swizzling.
        /// </summary>
        public ivec4 xzxw => new ivec4(x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.rbra swizzling (equivalent to ivec4.xzxw).
        /// </summary>
        public ivec4 rbra => new ivec4(x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.xzxwx swizzling.
        /// </summary>
        public ivec5 xzxwx => new ivec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.rbrar swizzling (equivalent to ivec4.xzxwx).
        /// </summary>
        public ivec5 rbrar => new ivec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.xzxwy swizzling.
        /// </summary>
        public ivec5 xzxwy => new ivec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.rbrag swizzling (equivalent to ivec4.xzxwy).
        /// </summary>
        public ivec5 rbrag => new ivec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.xzxwz swizzling.
        /// </summary>
        public ivec5 xzxwz => new ivec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.rbrab swizzling (equivalent to ivec4.xzxwz).
        /// </summary>
        public ivec5 rbrab => new ivec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.xzxww swizzling.
        /// </summary>
        public ivec5 xzxww => new ivec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.rbraa swizzling (equivalent to ivec4.xzxww).
        /// </summary>
        public ivec5 rbraa => new ivec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.xzy swizzling.
        /// </summary>
        public ivec3 xzy => new ivec3(x, z, y);
        
        /// <summary>
        /// Returns ivec4.rbg swizzling (equivalent to ivec4.xzy).
        /// </summary>
        public ivec3 rbg => new ivec3(x, z, y);
        
        /// <summary>
        /// Returns ivec4.xzyx swizzling.
        /// </summary>
        public ivec4 xzyx => new ivec4(x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.rbgr swizzling (equivalent to ivec4.xzyx).
        /// </summary>
        public ivec4 rbgr => new ivec4(x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.xzyxx swizzling.
        /// </summary>
        public ivec5 xzyxx => new ivec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.rbgrr swizzling (equivalent to ivec4.xzyxx).
        /// </summary>
        public ivec5 rbgrr => new ivec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.xzyxy swizzling.
        /// </summary>
        public ivec5 xzyxy => new ivec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.rbgrg swizzling (equivalent to ivec4.xzyxy).
        /// </summary>
        public ivec5 rbgrg => new ivec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.xzyxz swizzling.
        /// </summary>
        public ivec5 xzyxz => new ivec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.rbgrb swizzling (equivalent to ivec4.xzyxz).
        /// </summary>
        public ivec5 rbgrb => new ivec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.xzyxw swizzling.
        /// </summary>
        public ivec5 xzyxw => new ivec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.rbgra swizzling (equivalent to ivec4.xzyxw).
        /// </summary>
        public ivec5 rbgra => new ivec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.xzyy swizzling.
        /// </summary>
        public ivec4 xzyy => new ivec4(x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.rbgg swizzling (equivalent to ivec4.xzyy).
        /// </summary>
        public ivec4 rbgg => new ivec4(x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.xzyyx swizzling.
        /// </summary>
        public ivec5 xzyyx => new ivec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.rbggr swizzling (equivalent to ivec4.xzyyx).
        /// </summary>
        public ivec5 rbggr => new ivec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.xzyyy swizzling.
        /// </summary>
        public ivec5 xzyyy => new ivec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.rbggg swizzling (equivalent to ivec4.xzyyy).
        /// </summary>
        public ivec5 rbggg => new ivec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.xzyyz swizzling.
        /// </summary>
        public ivec5 xzyyz => new ivec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.rbggb swizzling (equivalent to ivec4.xzyyz).
        /// </summary>
        public ivec5 rbggb => new ivec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.xzyyw swizzling.
        /// </summary>
        public ivec5 xzyyw => new ivec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.rbgga swizzling (equivalent to ivec4.xzyyw).
        /// </summary>
        public ivec5 rbgga => new ivec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.xzyz swizzling.
        /// </summary>
        public ivec4 xzyz => new ivec4(x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.rbgb swizzling (equivalent to ivec4.xzyz).
        /// </summary>
        public ivec4 rbgb => new ivec4(x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.xzyzx swizzling.
        /// </summary>
        public ivec5 xzyzx => new ivec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.rbgbr swizzling (equivalent to ivec4.xzyzx).
        /// </summary>
        public ivec5 rbgbr => new ivec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.xzyzy swizzling.
        /// </summary>
        public ivec5 xzyzy => new ivec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.rbgbg swizzling (equivalent to ivec4.xzyzy).
        /// </summary>
        public ivec5 rbgbg => new ivec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.xzyzz swizzling.
        /// </summary>
        public ivec5 xzyzz => new ivec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.rbgbb swizzling (equivalent to ivec4.xzyzz).
        /// </summary>
        public ivec5 rbgbb => new ivec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.xzyzw swizzling.
        /// </summary>
        public ivec5 xzyzw => new ivec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.rbgba swizzling (equivalent to ivec4.xzyzw).
        /// </summary>
        public ivec5 rbgba => new ivec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.xzyw swizzling.
        /// </summary>
        public ivec4 xzyw => new ivec4(x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.rbga swizzling (equivalent to ivec4.xzyw).
        /// </summary>
        public ivec4 rbga => new ivec4(x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.xzywx swizzling.
        /// </summary>
        public ivec5 xzywx => new ivec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.rbgar swizzling (equivalent to ivec4.xzywx).
        /// </summary>
        public ivec5 rbgar => new ivec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.xzywy swizzling.
        /// </summary>
        public ivec5 xzywy => new ivec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.rbgag swizzling (equivalent to ivec4.xzywy).
        /// </summary>
        public ivec5 rbgag => new ivec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.xzywz swizzling.
        /// </summary>
        public ivec5 xzywz => new ivec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.rbgab swizzling (equivalent to ivec4.xzywz).
        /// </summary>
        public ivec5 rbgab => new ivec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.xzyww swizzling.
        /// </summary>
        public ivec5 xzyww => new ivec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.rbgaa swizzling (equivalent to ivec4.xzyww).
        /// </summary>
        public ivec5 rbgaa => new ivec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.xzz swizzling.
        /// </summary>
        public ivec3 xzz => new ivec3(x, z, z);
        
        /// <summary>
        /// Returns ivec4.rbb swizzling (equivalent to ivec4.xzz).
        /// </summary>
        public ivec3 rbb => new ivec3(x, z, z);
        
        /// <summary>
        /// Returns ivec4.xzzx swizzling.
        /// </summary>
        public ivec4 xzzx => new ivec4(x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.rbbr swizzling (equivalent to ivec4.xzzx).
        /// </summary>
        public ivec4 rbbr => new ivec4(x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.xzzxx swizzling.
        /// </summary>
        public ivec5 xzzxx => new ivec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.rbbrr swizzling (equivalent to ivec4.xzzxx).
        /// </summary>
        public ivec5 rbbrr => new ivec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.xzzxy swizzling.
        /// </summary>
        public ivec5 xzzxy => new ivec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.rbbrg swizzling (equivalent to ivec4.xzzxy).
        /// </summary>
        public ivec5 rbbrg => new ivec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.xzzxz swizzling.
        /// </summary>
        public ivec5 xzzxz => new ivec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.rbbrb swizzling (equivalent to ivec4.xzzxz).
        /// </summary>
        public ivec5 rbbrb => new ivec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.xzzxw swizzling.
        /// </summary>
        public ivec5 xzzxw => new ivec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.rbbra swizzling (equivalent to ivec4.xzzxw).
        /// </summary>
        public ivec5 rbbra => new ivec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.xzzy swizzling.
        /// </summary>
        public ivec4 xzzy => new ivec4(x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.rbbg swizzling (equivalent to ivec4.xzzy).
        /// </summary>
        public ivec4 rbbg => new ivec4(x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.xzzyx swizzling.
        /// </summary>
        public ivec5 xzzyx => new ivec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.rbbgr swizzling (equivalent to ivec4.xzzyx).
        /// </summary>
        public ivec5 rbbgr => new ivec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.xzzyy swizzling.
        /// </summary>
        public ivec5 xzzyy => new ivec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.rbbgg swizzling (equivalent to ivec4.xzzyy).
        /// </summary>
        public ivec5 rbbgg => new ivec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.xzzyz swizzling.
        /// </summary>
        public ivec5 xzzyz => new ivec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.rbbgb swizzling (equivalent to ivec4.xzzyz).
        /// </summary>
        public ivec5 rbbgb => new ivec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.xzzyw swizzling.
        /// </summary>
        public ivec5 xzzyw => new ivec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.rbbga swizzling (equivalent to ivec4.xzzyw).
        /// </summary>
        public ivec5 rbbga => new ivec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.xzzz swizzling.
        /// </summary>
        public ivec4 xzzz => new ivec4(x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.rbbb swizzling (equivalent to ivec4.xzzz).
        /// </summary>
        public ivec4 rbbb => new ivec4(x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.xzzzx swizzling.
        /// </summary>
        public ivec5 xzzzx => new ivec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.rbbbr swizzling (equivalent to ivec4.xzzzx).
        /// </summary>
        public ivec5 rbbbr => new ivec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.xzzzy swizzling.
        /// </summary>
        public ivec5 xzzzy => new ivec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.rbbbg swizzling (equivalent to ivec4.xzzzy).
        /// </summary>
        public ivec5 rbbbg => new ivec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.xzzzz swizzling.
        /// </summary>
        public ivec5 xzzzz => new ivec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.rbbbb swizzling (equivalent to ivec4.xzzzz).
        /// </summary>
        public ivec5 rbbbb => new ivec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.xzzzw swizzling.
        /// </summary>
        public ivec5 xzzzw => new ivec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.rbbba swizzling (equivalent to ivec4.xzzzw).
        /// </summary>
        public ivec5 rbbba => new ivec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.xzzw swizzling.
        /// </summary>
        public ivec4 xzzw => new ivec4(x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.rbba swizzling (equivalent to ivec4.xzzw).
        /// </summary>
        public ivec4 rbba => new ivec4(x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.xzzwx swizzling.
        /// </summary>
        public ivec5 xzzwx => new ivec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.rbbar swizzling (equivalent to ivec4.xzzwx).
        /// </summary>
        public ivec5 rbbar => new ivec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.xzzwy swizzling.
        /// </summary>
        public ivec5 xzzwy => new ivec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.rbbag swizzling (equivalent to ivec4.xzzwy).
        /// </summary>
        public ivec5 rbbag => new ivec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.xzzwz swizzling.
        /// </summary>
        public ivec5 xzzwz => new ivec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.rbbab swizzling (equivalent to ivec4.xzzwz).
        /// </summary>
        public ivec5 rbbab => new ivec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.xzzww swizzling.
        /// </summary>
        public ivec5 xzzww => new ivec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.rbbaa swizzling (equivalent to ivec4.xzzww).
        /// </summary>
        public ivec5 rbbaa => new ivec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.xzw swizzling.
        /// </summary>
        public ivec3 xzw => new ivec3(x, z, w);
        
        /// <summary>
        /// Returns ivec4.rba swizzling (equivalent to ivec4.xzw).
        /// </summary>
        public ivec3 rba => new ivec3(x, z, w);
        
        /// <summary>
        /// Returns ivec4.xzwx swizzling.
        /// </summary>
        public ivec4 xzwx => new ivec4(x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.rbar swizzling (equivalent to ivec4.xzwx).
        /// </summary>
        public ivec4 rbar => new ivec4(x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.xzwxx swizzling.
        /// </summary>
        public ivec5 xzwxx => new ivec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.rbarr swizzling (equivalent to ivec4.xzwxx).
        /// </summary>
        public ivec5 rbarr => new ivec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.xzwxy swizzling.
        /// </summary>
        public ivec5 xzwxy => new ivec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.rbarg swizzling (equivalent to ivec4.xzwxy).
        /// </summary>
        public ivec5 rbarg => new ivec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.xzwxz swizzling.
        /// </summary>
        public ivec5 xzwxz => new ivec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.rbarb swizzling (equivalent to ivec4.xzwxz).
        /// </summary>
        public ivec5 rbarb => new ivec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.xzwxw swizzling.
        /// </summary>
        public ivec5 xzwxw => new ivec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.rbara swizzling (equivalent to ivec4.xzwxw).
        /// </summary>
        public ivec5 rbara => new ivec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.xzwy swizzling.
        /// </summary>
        public ivec4 xzwy => new ivec4(x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.rbag swizzling (equivalent to ivec4.xzwy).
        /// </summary>
        public ivec4 rbag => new ivec4(x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.xzwyx swizzling.
        /// </summary>
        public ivec5 xzwyx => new ivec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.rbagr swizzling (equivalent to ivec4.xzwyx).
        /// </summary>
        public ivec5 rbagr => new ivec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.xzwyy swizzling.
        /// </summary>
        public ivec5 xzwyy => new ivec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.rbagg swizzling (equivalent to ivec4.xzwyy).
        /// </summary>
        public ivec5 rbagg => new ivec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.xzwyz swizzling.
        /// </summary>
        public ivec5 xzwyz => new ivec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.rbagb swizzling (equivalent to ivec4.xzwyz).
        /// </summary>
        public ivec5 rbagb => new ivec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.xzwyw swizzling.
        /// </summary>
        public ivec5 xzwyw => new ivec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.rbaga swizzling (equivalent to ivec4.xzwyw).
        /// </summary>
        public ivec5 rbaga => new ivec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.xzwz swizzling.
        /// </summary>
        public ivec4 xzwz => new ivec4(x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.rbab swizzling (equivalent to ivec4.xzwz).
        /// </summary>
        public ivec4 rbab => new ivec4(x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.xzwzx swizzling.
        /// </summary>
        public ivec5 xzwzx => new ivec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.rbabr swizzling (equivalent to ivec4.xzwzx).
        /// </summary>
        public ivec5 rbabr => new ivec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.xzwzy swizzling.
        /// </summary>
        public ivec5 xzwzy => new ivec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.rbabg swizzling (equivalent to ivec4.xzwzy).
        /// </summary>
        public ivec5 rbabg => new ivec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.xzwzz swizzling.
        /// </summary>
        public ivec5 xzwzz => new ivec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.rbabb swizzling (equivalent to ivec4.xzwzz).
        /// </summary>
        public ivec5 rbabb => new ivec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.xzwzw swizzling.
        /// </summary>
        public ivec5 xzwzw => new ivec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.rbaba swizzling (equivalent to ivec4.xzwzw).
        /// </summary>
        public ivec5 rbaba => new ivec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.xzww swizzling.
        /// </summary>
        public ivec4 xzww => new ivec4(x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.rbaa swizzling (equivalent to ivec4.xzww).
        /// </summary>
        public ivec4 rbaa => new ivec4(x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.xzwwx swizzling.
        /// </summary>
        public ivec5 xzwwx => new ivec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.rbaar swizzling (equivalent to ivec4.xzwwx).
        /// </summary>
        public ivec5 rbaar => new ivec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.xzwwy swizzling.
        /// </summary>
        public ivec5 xzwwy => new ivec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.rbaag swizzling (equivalent to ivec4.xzwwy).
        /// </summary>
        public ivec5 rbaag => new ivec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.xzwwz swizzling.
        /// </summary>
        public ivec5 xzwwz => new ivec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.rbaab swizzling (equivalent to ivec4.xzwwz).
        /// </summary>
        public ivec5 rbaab => new ivec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.xzwww swizzling.
        /// </summary>
        public ivec5 xzwww => new ivec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.rbaaa swizzling (equivalent to ivec4.xzwww).
        /// </summary>
        public ivec5 rbaaa => new ivec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.xw swizzling.
        /// </summary>
        public ivec2 xw => new ivec2(x, w);
        
        /// <summary>
        /// Returns ivec4.ra swizzling (equivalent to ivec4.xw).
        /// </summary>
        public ivec2 ra => new ivec2(x, w);
        
        /// <summary>
        /// Returns ivec4.xwx swizzling.
        /// </summary>
        public ivec3 xwx => new ivec3(x, w, x);
        
        /// <summary>
        /// Returns ivec4.rar swizzling (equivalent to ivec4.xwx).
        /// </summary>
        public ivec3 rar => new ivec3(x, w, x);
        
        /// <summary>
        /// Returns ivec4.xwxx swizzling.
        /// </summary>
        public ivec4 xwxx => new ivec4(x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.rarr swizzling (equivalent to ivec4.xwxx).
        /// </summary>
        public ivec4 rarr => new ivec4(x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.xwxxx swizzling.
        /// </summary>
        public ivec5 xwxxx => new ivec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.rarrr swizzling (equivalent to ivec4.xwxxx).
        /// </summary>
        public ivec5 rarrr => new ivec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.xwxxy swizzling.
        /// </summary>
        public ivec5 xwxxy => new ivec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.rarrg swizzling (equivalent to ivec4.xwxxy).
        /// </summary>
        public ivec5 rarrg => new ivec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.xwxxz swizzling.
        /// </summary>
        public ivec5 xwxxz => new ivec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.rarrb swizzling (equivalent to ivec4.xwxxz).
        /// </summary>
        public ivec5 rarrb => new ivec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.xwxxw swizzling.
        /// </summary>
        public ivec5 xwxxw => new ivec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.rarra swizzling (equivalent to ivec4.xwxxw).
        /// </summary>
        public ivec5 rarra => new ivec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.xwxy swizzling.
        /// </summary>
        public ivec4 xwxy => new ivec4(x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.rarg swizzling (equivalent to ivec4.xwxy).
        /// </summary>
        public ivec4 rarg => new ivec4(x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.xwxyx swizzling.
        /// </summary>
        public ivec5 xwxyx => new ivec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.rargr swizzling (equivalent to ivec4.xwxyx).
        /// </summary>
        public ivec5 rargr => new ivec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.xwxyy swizzling.
        /// </summary>
        public ivec5 xwxyy => new ivec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.rargg swizzling (equivalent to ivec4.xwxyy).
        /// </summary>
        public ivec5 rargg => new ivec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.xwxyz swizzling.
        /// </summary>
        public ivec5 xwxyz => new ivec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.rargb swizzling (equivalent to ivec4.xwxyz).
        /// </summary>
        public ivec5 rargb => new ivec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.xwxyw swizzling.
        /// </summary>
        public ivec5 xwxyw => new ivec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.rarga swizzling (equivalent to ivec4.xwxyw).
        /// </summary>
        public ivec5 rarga => new ivec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.xwxz swizzling.
        /// </summary>
        public ivec4 xwxz => new ivec4(x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.rarb swizzling (equivalent to ivec4.xwxz).
        /// </summary>
        public ivec4 rarb => new ivec4(x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.xwxzx swizzling.
        /// </summary>
        public ivec5 xwxzx => new ivec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.rarbr swizzling (equivalent to ivec4.xwxzx).
        /// </summary>
        public ivec5 rarbr => new ivec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.xwxzy swizzling.
        /// </summary>
        public ivec5 xwxzy => new ivec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.rarbg swizzling (equivalent to ivec4.xwxzy).
        /// </summary>
        public ivec5 rarbg => new ivec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.xwxzz swizzling.
        /// </summary>
        public ivec5 xwxzz => new ivec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.rarbb swizzling (equivalent to ivec4.xwxzz).
        /// </summary>
        public ivec5 rarbb => new ivec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.xwxzw swizzling.
        /// </summary>
        public ivec5 xwxzw => new ivec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.rarba swizzling (equivalent to ivec4.xwxzw).
        /// </summary>
        public ivec5 rarba => new ivec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.xwxw swizzling.
        /// </summary>
        public ivec4 xwxw => new ivec4(x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.rara swizzling (equivalent to ivec4.xwxw).
        /// </summary>
        public ivec4 rara => new ivec4(x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.xwxwx swizzling.
        /// </summary>
        public ivec5 xwxwx => new ivec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.rarar swizzling (equivalent to ivec4.xwxwx).
        /// </summary>
        public ivec5 rarar => new ivec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.xwxwy swizzling.
        /// </summary>
        public ivec5 xwxwy => new ivec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.rarag swizzling (equivalent to ivec4.xwxwy).
        /// </summary>
        public ivec5 rarag => new ivec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.xwxwz swizzling.
        /// </summary>
        public ivec5 xwxwz => new ivec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.rarab swizzling (equivalent to ivec4.xwxwz).
        /// </summary>
        public ivec5 rarab => new ivec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.xwxww swizzling.
        /// </summary>
        public ivec5 xwxww => new ivec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.raraa swizzling (equivalent to ivec4.xwxww).
        /// </summary>
        public ivec5 raraa => new ivec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.xwy swizzling.
        /// </summary>
        public ivec3 xwy => new ivec3(x, w, y);
        
        /// <summary>
        /// Returns ivec4.rag swizzling (equivalent to ivec4.xwy).
        /// </summary>
        public ivec3 rag => new ivec3(x, w, y);
        
        /// <summary>
        /// Returns ivec4.xwyx swizzling.
        /// </summary>
        public ivec4 xwyx => new ivec4(x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.ragr swizzling (equivalent to ivec4.xwyx).
        /// </summary>
        public ivec4 ragr => new ivec4(x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.xwyxx swizzling.
        /// </summary>
        public ivec5 xwyxx => new ivec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.ragrr swizzling (equivalent to ivec4.xwyxx).
        /// </summary>
        public ivec5 ragrr => new ivec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.xwyxy swizzling.
        /// </summary>
        public ivec5 xwyxy => new ivec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.ragrg swizzling (equivalent to ivec4.xwyxy).
        /// </summary>
        public ivec5 ragrg => new ivec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.xwyxz swizzling.
        /// </summary>
        public ivec5 xwyxz => new ivec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.ragrb swizzling (equivalent to ivec4.xwyxz).
        /// </summary>
        public ivec5 ragrb => new ivec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.xwyxw swizzling.
        /// </summary>
        public ivec5 xwyxw => new ivec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.ragra swizzling (equivalent to ivec4.xwyxw).
        /// </summary>
        public ivec5 ragra => new ivec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.xwyy swizzling.
        /// </summary>
        public ivec4 xwyy => new ivec4(x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.ragg swizzling (equivalent to ivec4.xwyy).
        /// </summary>
        public ivec4 ragg => new ivec4(x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.xwyyx swizzling.
        /// </summary>
        public ivec5 xwyyx => new ivec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.raggr swizzling (equivalent to ivec4.xwyyx).
        /// </summary>
        public ivec5 raggr => new ivec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.xwyyy swizzling.
        /// </summary>
        public ivec5 xwyyy => new ivec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.raggg swizzling (equivalent to ivec4.xwyyy).
        /// </summary>
        public ivec5 raggg => new ivec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.xwyyz swizzling.
        /// </summary>
        public ivec5 xwyyz => new ivec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.raggb swizzling (equivalent to ivec4.xwyyz).
        /// </summary>
        public ivec5 raggb => new ivec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.xwyyw swizzling.
        /// </summary>
        public ivec5 xwyyw => new ivec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.ragga swizzling (equivalent to ivec4.xwyyw).
        /// </summary>
        public ivec5 ragga => new ivec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.xwyz swizzling.
        /// </summary>
        public ivec4 xwyz => new ivec4(x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.ragb swizzling (equivalent to ivec4.xwyz).
        /// </summary>
        public ivec4 ragb => new ivec4(x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.xwyzx swizzling.
        /// </summary>
        public ivec5 xwyzx => new ivec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.ragbr swizzling (equivalent to ivec4.xwyzx).
        /// </summary>
        public ivec5 ragbr => new ivec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.xwyzy swizzling.
        /// </summary>
        public ivec5 xwyzy => new ivec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.ragbg swizzling (equivalent to ivec4.xwyzy).
        /// </summary>
        public ivec5 ragbg => new ivec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.xwyzz swizzling.
        /// </summary>
        public ivec5 xwyzz => new ivec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.ragbb swizzling (equivalent to ivec4.xwyzz).
        /// </summary>
        public ivec5 ragbb => new ivec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.xwyzw swizzling.
        /// </summary>
        public ivec5 xwyzw => new ivec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.ragba swizzling (equivalent to ivec4.xwyzw).
        /// </summary>
        public ivec5 ragba => new ivec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.xwyw swizzling.
        /// </summary>
        public ivec4 xwyw => new ivec4(x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.raga swizzling (equivalent to ivec4.xwyw).
        /// </summary>
        public ivec4 raga => new ivec4(x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.xwywx swizzling.
        /// </summary>
        public ivec5 xwywx => new ivec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.ragar swizzling (equivalent to ivec4.xwywx).
        /// </summary>
        public ivec5 ragar => new ivec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.xwywy swizzling.
        /// </summary>
        public ivec5 xwywy => new ivec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.ragag swizzling (equivalent to ivec4.xwywy).
        /// </summary>
        public ivec5 ragag => new ivec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.xwywz swizzling.
        /// </summary>
        public ivec5 xwywz => new ivec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.ragab swizzling (equivalent to ivec4.xwywz).
        /// </summary>
        public ivec5 ragab => new ivec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.xwyww swizzling.
        /// </summary>
        public ivec5 xwyww => new ivec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.ragaa swizzling (equivalent to ivec4.xwyww).
        /// </summary>
        public ivec5 ragaa => new ivec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.xwz swizzling.
        /// </summary>
        public ivec3 xwz => new ivec3(x, w, z);
        
        /// <summary>
        /// Returns ivec4.rab swizzling (equivalent to ivec4.xwz).
        /// </summary>
        public ivec3 rab => new ivec3(x, w, z);
        
        /// <summary>
        /// Returns ivec4.xwzx swizzling.
        /// </summary>
        public ivec4 xwzx => new ivec4(x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.rabr swizzling (equivalent to ivec4.xwzx).
        /// </summary>
        public ivec4 rabr => new ivec4(x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.xwzxx swizzling.
        /// </summary>
        public ivec5 xwzxx => new ivec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.rabrr swizzling (equivalent to ivec4.xwzxx).
        /// </summary>
        public ivec5 rabrr => new ivec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.xwzxy swizzling.
        /// </summary>
        public ivec5 xwzxy => new ivec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.rabrg swizzling (equivalent to ivec4.xwzxy).
        /// </summary>
        public ivec5 rabrg => new ivec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.xwzxz swizzling.
        /// </summary>
        public ivec5 xwzxz => new ivec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.rabrb swizzling (equivalent to ivec4.xwzxz).
        /// </summary>
        public ivec5 rabrb => new ivec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.xwzxw swizzling.
        /// </summary>
        public ivec5 xwzxw => new ivec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.rabra swizzling (equivalent to ivec4.xwzxw).
        /// </summary>
        public ivec5 rabra => new ivec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.xwzy swizzling.
        /// </summary>
        public ivec4 xwzy => new ivec4(x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.rabg swizzling (equivalent to ivec4.xwzy).
        /// </summary>
        public ivec4 rabg => new ivec4(x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.xwzyx swizzling.
        /// </summary>
        public ivec5 xwzyx => new ivec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.rabgr swizzling (equivalent to ivec4.xwzyx).
        /// </summary>
        public ivec5 rabgr => new ivec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.xwzyy swizzling.
        /// </summary>
        public ivec5 xwzyy => new ivec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.rabgg swizzling (equivalent to ivec4.xwzyy).
        /// </summary>
        public ivec5 rabgg => new ivec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.xwzyz swizzling.
        /// </summary>
        public ivec5 xwzyz => new ivec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.rabgb swizzling (equivalent to ivec4.xwzyz).
        /// </summary>
        public ivec5 rabgb => new ivec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.xwzyw swizzling.
        /// </summary>
        public ivec5 xwzyw => new ivec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.rabga swizzling (equivalent to ivec4.xwzyw).
        /// </summary>
        public ivec5 rabga => new ivec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.xwzz swizzling.
        /// </summary>
        public ivec4 xwzz => new ivec4(x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.rabb swizzling (equivalent to ivec4.xwzz).
        /// </summary>
        public ivec4 rabb => new ivec4(x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.xwzzx swizzling.
        /// </summary>
        public ivec5 xwzzx => new ivec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.rabbr swizzling (equivalent to ivec4.xwzzx).
        /// </summary>
        public ivec5 rabbr => new ivec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.xwzzy swizzling.
        /// </summary>
        public ivec5 xwzzy => new ivec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.rabbg swizzling (equivalent to ivec4.xwzzy).
        /// </summary>
        public ivec5 rabbg => new ivec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.xwzzz swizzling.
        /// </summary>
        public ivec5 xwzzz => new ivec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.rabbb swizzling (equivalent to ivec4.xwzzz).
        /// </summary>
        public ivec5 rabbb => new ivec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.xwzzw swizzling.
        /// </summary>
        public ivec5 xwzzw => new ivec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.rabba swizzling (equivalent to ivec4.xwzzw).
        /// </summary>
        public ivec5 rabba => new ivec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.xwzw swizzling.
        /// </summary>
        public ivec4 xwzw => new ivec4(x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.raba swizzling (equivalent to ivec4.xwzw).
        /// </summary>
        public ivec4 raba => new ivec4(x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.xwzwx swizzling.
        /// </summary>
        public ivec5 xwzwx => new ivec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.rabar swizzling (equivalent to ivec4.xwzwx).
        /// </summary>
        public ivec5 rabar => new ivec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.xwzwy swizzling.
        /// </summary>
        public ivec5 xwzwy => new ivec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.rabag swizzling (equivalent to ivec4.xwzwy).
        /// </summary>
        public ivec5 rabag => new ivec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.xwzwz swizzling.
        /// </summary>
        public ivec5 xwzwz => new ivec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.rabab swizzling (equivalent to ivec4.xwzwz).
        /// </summary>
        public ivec5 rabab => new ivec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.xwzww swizzling.
        /// </summary>
        public ivec5 xwzww => new ivec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.rabaa swizzling (equivalent to ivec4.xwzww).
        /// </summary>
        public ivec5 rabaa => new ivec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.xww swizzling.
        /// </summary>
        public ivec3 xww => new ivec3(x, w, w);
        
        /// <summary>
        /// Returns ivec4.raa swizzling (equivalent to ivec4.xww).
        /// </summary>
        public ivec3 raa => new ivec3(x, w, w);
        
        /// <summary>
        /// Returns ivec4.xwwx swizzling.
        /// </summary>
        public ivec4 xwwx => new ivec4(x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.raar swizzling (equivalent to ivec4.xwwx).
        /// </summary>
        public ivec4 raar => new ivec4(x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.xwwxx swizzling.
        /// </summary>
        public ivec5 xwwxx => new ivec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.raarr swizzling (equivalent to ivec4.xwwxx).
        /// </summary>
        public ivec5 raarr => new ivec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.xwwxy swizzling.
        /// </summary>
        public ivec5 xwwxy => new ivec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.raarg swizzling (equivalent to ivec4.xwwxy).
        /// </summary>
        public ivec5 raarg => new ivec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.xwwxz swizzling.
        /// </summary>
        public ivec5 xwwxz => new ivec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.raarb swizzling (equivalent to ivec4.xwwxz).
        /// </summary>
        public ivec5 raarb => new ivec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.xwwxw swizzling.
        /// </summary>
        public ivec5 xwwxw => new ivec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.raara swizzling (equivalent to ivec4.xwwxw).
        /// </summary>
        public ivec5 raara => new ivec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.xwwy swizzling.
        /// </summary>
        public ivec4 xwwy => new ivec4(x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.raag swizzling (equivalent to ivec4.xwwy).
        /// </summary>
        public ivec4 raag => new ivec4(x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.xwwyx swizzling.
        /// </summary>
        public ivec5 xwwyx => new ivec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.raagr swizzling (equivalent to ivec4.xwwyx).
        /// </summary>
        public ivec5 raagr => new ivec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.xwwyy swizzling.
        /// </summary>
        public ivec5 xwwyy => new ivec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.raagg swizzling (equivalent to ivec4.xwwyy).
        /// </summary>
        public ivec5 raagg => new ivec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.xwwyz swizzling.
        /// </summary>
        public ivec5 xwwyz => new ivec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.raagb swizzling (equivalent to ivec4.xwwyz).
        /// </summary>
        public ivec5 raagb => new ivec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.xwwyw swizzling.
        /// </summary>
        public ivec5 xwwyw => new ivec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.raaga swizzling (equivalent to ivec4.xwwyw).
        /// </summary>
        public ivec5 raaga => new ivec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.xwwz swizzling.
        /// </summary>
        public ivec4 xwwz => new ivec4(x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.raab swizzling (equivalent to ivec4.xwwz).
        /// </summary>
        public ivec4 raab => new ivec4(x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.xwwzx swizzling.
        /// </summary>
        public ivec5 xwwzx => new ivec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.raabr swizzling (equivalent to ivec4.xwwzx).
        /// </summary>
        public ivec5 raabr => new ivec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.xwwzy swizzling.
        /// </summary>
        public ivec5 xwwzy => new ivec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.raabg swizzling (equivalent to ivec4.xwwzy).
        /// </summary>
        public ivec5 raabg => new ivec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.xwwzz swizzling.
        /// </summary>
        public ivec5 xwwzz => new ivec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.raabb swizzling (equivalent to ivec4.xwwzz).
        /// </summary>
        public ivec5 raabb => new ivec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.xwwzw swizzling.
        /// </summary>
        public ivec5 xwwzw => new ivec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.raaba swizzling (equivalent to ivec4.xwwzw).
        /// </summary>
        public ivec5 raaba => new ivec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.xwww swizzling.
        /// </summary>
        public ivec4 xwww => new ivec4(x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.raaa swizzling (equivalent to ivec4.xwww).
        /// </summary>
        public ivec4 raaa => new ivec4(x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.xwwwx swizzling.
        /// </summary>
        public ivec5 xwwwx => new ivec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.raaar swizzling (equivalent to ivec4.xwwwx).
        /// </summary>
        public ivec5 raaar => new ivec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.xwwwy swizzling.
        /// </summary>
        public ivec5 xwwwy => new ivec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.raaag swizzling (equivalent to ivec4.xwwwy).
        /// </summary>
        public ivec5 raaag => new ivec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.xwwwz swizzling.
        /// </summary>
        public ivec5 xwwwz => new ivec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.raaab swizzling (equivalent to ivec4.xwwwz).
        /// </summary>
        public ivec5 raaab => new ivec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.xwwww swizzling.
        /// </summary>
        public ivec5 xwwww => new ivec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns ivec4.raaaa swizzling (equivalent to ivec4.xwwww).
        /// </summary>
        public ivec5 raaaa => new ivec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns ivec4.yx swizzling.
        /// </summary>
        public ivec2 yx => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec4.gr swizzling (equivalent to ivec4.yx).
        /// </summary>
        public ivec2 gr => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec4.yxx swizzling.
        /// </summary>
        public ivec3 yxx => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec4.grr swizzling (equivalent to ivec4.yxx).
        /// </summary>
        public ivec3 grr => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec4.yxxx swizzling.
        /// </summary>
        public ivec4 yxxx => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.grrr swizzling (equivalent to ivec4.yxxx).
        /// </summary>
        public ivec4 grrr => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.yxxxx swizzling.
        /// </summary>
        public ivec5 yxxxx => new ivec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.grrrr swizzling (equivalent to ivec4.yxxxx).
        /// </summary>
        public ivec5 grrrr => new ivec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.yxxxy swizzling.
        /// </summary>
        public ivec5 yxxxy => new ivec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.grrrg swizzling (equivalent to ivec4.yxxxy).
        /// </summary>
        public ivec5 grrrg => new ivec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.yxxxz swizzling.
        /// </summary>
        public ivec5 yxxxz => new ivec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.grrrb swizzling (equivalent to ivec4.yxxxz).
        /// </summary>
        public ivec5 grrrb => new ivec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.yxxxw swizzling.
        /// </summary>
        public ivec5 yxxxw => new ivec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.grrra swizzling (equivalent to ivec4.yxxxw).
        /// </summary>
        public ivec5 grrra => new ivec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.yxxy swizzling.
        /// </summary>
        public ivec4 yxxy => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.grrg swizzling (equivalent to ivec4.yxxy).
        /// </summary>
        public ivec4 grrg => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.yxxyx swizzling.
        /// </summary>
        public ivec5 yxxyx => new ivec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.grrgr swizzling (equivalent to ivec4.yxxyx).
        /// </summary>
        public ivec5 grrgr => new ivec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.yxxyy swizzling.
        /// </summary>
        public ivec5 yxxyy => new ivec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.grrgg swizzling (equivalent to ivec4.yxxyy).
        /// </summary>
        public ivec5 grrgg => new ivec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.yxxyz swizzling.
        /// </summary>
        public ivec5 yxxyz => new ivec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.grrgb swizzling (equivalent to ivec4.yxxyz).
        /// </summary>
        public ivec5 grrgb => new ivec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.yxxyw swizzling.
        /// </summary>
        public ivec5 yxxyw => new ivec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.grrga swizzling (equivalent to ivec4.yxxyw).
        /// </summary>
        public ivec5 grrga => new ivec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.yxxz swizzling.
        /// </summary>
        public ivec4 yxxz => new ivec4(y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.grrb swizzling (equivalent to ivec4.yxxz).
        /// </summary>
        public ivec4 grrb => new ivec4(y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.yxxzx swizzling.
        /// </summary>
        public ivec5 yxxzx => new ivec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.grrbr swizzling (equivalent to ivec4.yxxzx).
        /// </summary>
        public ivec5 grrbr => new ivec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.yxxzy swizzling.
        /// </summary>
        public ivec5 yxxzy => new ivec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.grrbg swizzling (equivalent to ivec4.yxxzy).
        /// </summary>
        public ivec5 grrbg => new ivec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.yxxzz swizzling.
        /// </summary>
        public ivec5 yxxzz => new ivec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.grrbb swizzling (equivalent to ivec4.yxxzz).
        /// </summary>
        public ivec5 grrbb => new ivec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.yxxzw swizzling.
        /// </summary>
        public ivec5 yxxzw => new ivec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.grrba swizzling (equivalent to ivec4.yxxzw).
        /// </summary>
        public ivec5 grrba => new ivec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.yxxw swizzling.
        /// </summary>
        public ivec4 yxxw => new ivec4(y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.grra swizzling (equivalent to ivec4.yxxw).
        /// </summary>
        public ivec4 grra => new ivec4(y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.yxxwx swizzling.
        /// </summary>
        public ivec5 yxxwx => new ivec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.grrar swizzling (equivalent to ivec4.yxxwx).
        /// </summary>
        public ivec5 grrar => new ivec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.yxxwy swizzling.
        /// </summary>
        public ivec5 yxxwy => new ivec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.grrag swizzling (equivalent to ivec4.yxxwy).
        /// </summary>
        public ivec5 grrag => new ivec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.yxxwz swizzling.
        /// </summary>
        public ivec5 yxxwz => new ivec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.grrab swizzling (equivalent to ivec4.yxxwz).
        /// </summary>
        public ivec5 grrab => new ivec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.yxxww swizzling.
        /// </summary>
        public ivec5 yxxww => new ivec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.grraa swizzling (equivalent to ivec4.yxxww).
        /// </summary>
        public ivec5 grraa => new ivec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.yxy swizzling.
        /// </summary>
        public ivec3 yxy => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec4.grg swizzling (equivalent to ivec4.yxy).
        /// </summary>
        public ivec3 grg => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec4.yxyx swizzling.
        /// </summary>
        public ivec4 yxyx => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.grgr swizzling (equivalent to ivec4.yxyx).
        /// </summary>
        public ivec4 grgr => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.yxyxx swizzling.
        /// </summary>
        public ivec5 yxyxx => new ivec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.grgrr swizzling (equivalent to ivec4.yxyxx).
        /// </summary>
        public ivec5 grgrr => new ivec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.yxyxy swizzling.
        /// </summary>
        public ivec5 yxyxy => new ivec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.grgrg swizzling (equivalent to ivec4.yxyxy).
        /// </summary>
        public ivec5 grgrg => new ivec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.yxyxz swizzling.
        /// </summary>
        public ivec5 yxyxz => new ivec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.grgrb swizzling (equivalent to ivec4.yxyxz).
        /// </summary>
        public ivec5 grgrb => new ivec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.yxyxw swizzling.
        /// </summary>
        public ivec5 yxyxw => new ivec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.grgra swizzling (equivalent to ivec4.yxyxw).
        /// </summary>
        public ivec5 grgra => new ivec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.yxyy swizzling.
        /// </summary>
        public ivec4 yxyy => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.grgg swizzling (equivalent to ivec4.yxyy).
        /// </summary>
        public ivec4 grgg => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.yxyyx swizzling.
        /// </summary>
        public ivec5 yxyyx => new ivec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.grggr swizzling (equivalent to ivec4.yxyyx).
        /// </summary>
        public ivec5 grggr => new ivec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.yxyyy swizzling.
        /// </summary>
        public ivec5 yxyyy => new ivec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.grggg swizzling (equivalent to ivec4.yxyyy).
        /// </summary>
        public ivec5 grggg => new ivec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.yxyyz swizzling.
        /// </summary>
        public ivec5 yxyyz => new ivec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.grggb swizzling (equivalent to ivec4.yxyyz).
        /// </summary>
        public ivec5 grggb => new ivec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.yxyyw swizzling.
        /// </summary>
        public ivec5 yxyyw => new ivec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.grgga swizzling (equivalent to ivec4.yxyyw).
        /// </summary>
        public ivec5 grgga => new ivec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.yxyz swizzling.
        /// </summary>
        public ivec4 yxyz => new ivec4(y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.grgb swizzling (equivalent to ivec4.yxyz).
        /// </summary>
        public ivec4 grgb => new ivec4(y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.yxyzx swizzling.
        /// </summary>
        public ivec5 yxyzx => new ivec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.grgbr swizzling (equivalent to ivec4.yxyzx).
        /// </summary>
        public ivec5 grgbr => new ivec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.yxyzy swizzling.
        /// </summary>
        public ivec5 yxyzy => new ivec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.grgbg swizzling (equivalent to ivec4.yxyzy).
        /// </summary>
        public ivec5 grgbg => new ivec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.yxyzz swizzling.
        /// </summary>
        public ivec5 yxyzz => new ivec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.grgbb swizzling (equivalent to ivec4.yxyzz).
        /// </summary>
        public ivec5 grgbb => new ivec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.yxyzw swizzling.
        /// </summary>
        public ivec5 yxyzw => new ivec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.grgba swizzling (equivalent to ivec4.yxyzw).
        /// </summary>
        public ivec5 grgba => new ivec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.yxyw swizzling.
        /// </summary>
        public ivec4 yxyw => new ivec4(y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.grga swizzling (equivalent to ivec4.yxyw).
        /// </summary>
        public ivec4 grga => new ivec4(y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.yxywx swizzling.
        /// </summary>
        public ivec5 yxywx => new ivec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.grgar swizzling (equivalent to ivec4.yxywx).
        /// </summary>
        public ivec5 grgar => new ivec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.yxywy swizzling.
        /// </summary>
        public ivec5 yxywy => new ivec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.grgag swizzling (equivalent to ivec4.yxywy).
        /// </summary>
        public ivec5 grgag => new ivec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.yxywz swizzling.
        /// </summary>
        public ivec5 yxywz => new ivec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.grgab swizzling (equivalent to ivec4.yxywz).
        /// </summary>
        public ivec5 grgab => new ivec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.yxyww swizzling.
        /// </summary>
        public ivec5 yxyww => new ivec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.grgaa swizzling (equivalent to ivec4.yxyww).
        /// </summary>
        public ivec5 grgaa => new ivec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.yxz swizzling.
        /// </summary>
        public ivec3 yxz => new ivec3(y, x, z);
        
        /// <summary>
        /// Returns ivec4.grb swizzling (equivalent to ivec4.yxz).
        /// </summary>
        public ivec3 grb => new ivec3(y, x, z);
        
        /// <summary>
        /// Returns ivec4.yxzx swizzling.
        /// </summary>
        public ivec4 yxzx => new ivec4(y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.grbr swizzling (equivalent to ivec4.yxzx).
        /// </summary>
        public ivec4 grbr => new ivec4(y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.yxzxx swizzling.
        /// </summary>
        public ivec5 yxzxx => new ivec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.grbrr swizzling (equivalent to ivec4.yxzxx).
        /// </summary>
        public ivec5 grbrr => new ivec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.yxzxy swizzling.
        /// </summary>
        public ivec5 yxzxy => new ivec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.grbrg swizzling (equivalent to ivec4.yxzxy).
        /// </summary>
        public ivec5 grbrg => new ivec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.yxzxz swizzling.
        /// </summary>
        public ivec5 yxzxz => new ivec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.grbrb swizzling (equivalent to ivec4.yxzxz).
        /// </summary>
        public ivec5 grbrb => new ivec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.yxzxw swizzling.
        /// </summary>
        public ivec5 yxzxw => new ivec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.grbra swizzling (equivalent to ivec4.yxzxw).
        /// </summary>
        public ivec5 grbra => new ivec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.yxzy swizzling.
        /// </summary>
        public ivec4 yxzy => new ivec4(y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.grbg swizzling (equivalent to ivec4.yxzy).
        /// </summary>
        public ivec4 grbg => new ivec4(y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.yxzyx swizzling.
        /// </summary>
        public ivec5 yxzyx => new ivec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.grbgr swizzling (equivalent to ivec4.yxzyx).
        /// </summary>
        public ivec5 grbgr => new ivec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.yxzyy swizzling.
        /// </summary>
        public ivec5 yxzyy => new ivec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.grbgg swizzling (equivalent to ivec4.yxzyy).
        /// </summary>
        public ivec5 grbgg => new ivec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.yxzyz swizzling.
        /// </summary>
        public ivec5 yxzyz => new ivec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.grbgb swizzling (equivalent to ivec4.yxzyz).
        /// </summary>
        public ivec5 grbgb => new ivec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.yxzyw swizzling.
        /// </summary>
        public ivec5 yxzyw => new ivec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.grbga swizzling (equivalent to ivec4.yxzyw).
        /// </summary>
        public ivec5 grbga => new ivec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.yxzz swizzling.
        /// </summary>
        public ivec4 yxzz => new ivec4(y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.grbb swizzling (equivalent to ivec4.yxzz).
        /// </summary>
        public ivec4 grbb => new ivec4(y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.yxzzx swizzling.
        /// </summary>
        public ivec5 yxzzx => new ivec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.grbbr swizzling (equivalent to ivec4.yxzzx).
        /// </summary>
        public ivec5 grbbr => new ivec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.yxzzy swizzling.
        /// </summary>
        public ivec5 yxzzy => new ivec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.grbbg swizzling (equivalent to ivec4.yxzzy).
        /// </summary>
        public ivec5 grbbg => new ivec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.yxzzz swizzling.
        /// </summary>
        public ivec5 yxzzz => new ivec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.grbbb swizzling (equivalent to ivec4.yxzzz).
        /// </summary>
        public ivec5 grbbb => new ivec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.yxzzw swizzling.
        /// </summary>
        public ivec5 yxzzw => new ivec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.grbba swizzling (equivalent to ivec4.yxzzw).
        /// </summary>
        public ivec5 grbba => new ivec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.yxzw swizzling.
        /// </summary>
        public ivec4 yxzw => new ivec4(y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.grba swizzling (equivalent to ivec4.yxzw).
        /// </summary>
        public ivec4 grba => new ivec4(y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.yxzwx swizzling.
        /// </summary>
        public ivec5 yxzwx => new ivec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.grbar swizzling (equivalent to ivec4.yxzwx).
        /// </summary>
        public ivec5 grbar => new ivec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.yxzwy swizzling.
        /// </summary>
        public ivec5 yxzwy => new ivec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.grbag swizzling (equivalent to ivec4.yxzwy).
        /// </summary>
        public ivec5 grbag => new ivec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.yxzwz swizzling.
        /// </summary>
        public ivec5 yxzwz => new ivec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.grbab swizzling (equivalent to ivec4.yxzwz).
        /// </summary>
        public ivec5 grbab => new ivec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.yxzww swizzling.
        /// </summary>
        public ivec5 yxzww => new ivec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.grbaa swizzling (equivalent to ivec4.yxzww).
        /// </summary>
        public ivec5 grbaa => new ivec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.yxw swizzling.
        /// </summary>
        public ivec3 yxw => new ivec3(y, x, w);
        
        /// <summary>
        /// Returns ivec4.gra swizzling (equivalent to ivec4.yxw).
        /// </summary>
        public ivec3 gra => new ivec3(y, x, w);
        
        /// <summary>
        /// Returns ivec4.yxwx swizzling.
        /// </summary>
        public ivec4 yxwx => new ivec4(y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.grar swizzling (equivalent to ivec4.yxwx).
        /// </summary>
        public ivec4 grar => new ivec4(y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.yxwxx swizzling.
        /// </summary>
        public ivec5 yxwxx => new ivec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.grarr swizzling (equivalent to ivec4.yxwxx).
        /// </summary>
        public ivec5 grarr => new ivec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.yxwxy swizzling.
        /// </summary>
        public ivec5 yxwxy => new ivec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.grarg swizzling (equivalent to ivec4.yxwxy).
        /// </summary>
        public ivec5 grarg => new ivec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.yxwxz swizzling.
        /// </summary>
        public ivec5 yxwxz => new ivec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.grarb swizzling (equivalent to ivec4.yxwxz).
        /// </summary>
        public ivec5 grarb => new ivec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.yxwxw swizzling.
        /// </summary>
        public ivec5 yxwxw => new ivec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.grara swizzling (equivalent to ivec4.yxwxw).
        /// </summary>
        public ivec5 grara => new ivec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.yxwy swizzling.
        /// </summary>
        public ivec4 yxwy => new ivec4(y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.grag swizzling (equivalent to ivec4.yxwy).
        /// </summary>
        public ivec4 grag => new ivec4(y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.yxwyx swizzling.
        /// </summary>
        public ivec5 yxwyx => new ivec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.gragr swizzling (equivalent to ivec4.yxwyx).
        /// </summary>
        public ivec5 gragr => new ivec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.yxwyy swizzling.
        /// </summary>
        public ivec5 yxwyy => new ivec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.gragg swizzling (equivalent to ivec4.yxwyy).
        /// </summary>
        public ivec5 gragg => new ivec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.yxwyz swizzling.
        /// </summary>
        public ivec5 yxwyz => new ivec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.gragb swizzling (equivalent to ivec4.yxwyz).
        /// </summary>
        public ivec5 gragb => new ivec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.yxwyw swizzling.
        /// </summary>
        public ivec5 yxwyw => new ivec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.graga swizzling (equivalent to ivec4.yxwyw).
        /// </summary>
        public ivec5 graga => new ivec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.yxwz swizzling.
        /// </summary>
        public ivec4 yxwz => new ivec4(y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.grab swizzling (equivalent to ivec4.yxwz).
        /// </summary>
        public ivec4 grab => new ivec4(y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.yxwzx swizzling.
        /// </summary>
        public ivec5 yxwzx => new ivec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.grabr swizzling (equivalent to ivec4.yxwzx).
        /// </summary>
        public ivec5 grabr => new ivec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.yxwzy swizzling.
        /// </summary>
        public ivec5 yxwzy => new ivec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.grabg swizzling (equivalent to ivec4.yxwzy).
        /// </summary>
        public ivec5 grabg => new ivec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.yxwzz swizzling.
        /// </summary>
        public ivec5 yxwzz => new ivec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.grabb swizzling (equivalent to ivec4.yxwzz).
        /// </summary>
        public ivec5 grabb => new ivec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.yxwzw swizzling.
        /// </summary>
        public ivec5 yxwzw => new ivec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.graba swizzling (equivalent to ivec4.yxwzw).
        /// </summary>
        public ivec5 graba => new ivec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.yxww swizzling.
        /// </summary>
        public ivec4 yxww => new ivec4(y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.graa swizzling (equivalent to ivec4.yxww).
        /// </summary>
        public ivec4 graa => new ivec4(y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.yxwwx swizzling.
        /// </summary>
        public ivec5 yxwwx => new ivec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.graar swizzling (equivalent to ivec4.yxwwx).
        /// </summary>
        public ivec5 graar => new ivec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.yxwwy swizzling.
        /// </summary>
        public ivec5 yxwwy => new ivec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.graag swizzling (equivalent to ivec4.yxwwy).
        /// </summary>
        public ivec5 graag => new ivec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.yxwwz swizzling.
        /// </summary>
        public ivec5 yxwwz => new ivec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.graab swizzling (equivalent to ivec4.yxwwz).
        /// </summary>
        public ivec5 graab => new ivec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.yxwww swizzling.
        /// </summary>
        public ivec5 yxwww => new ivec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.graaa swizzling (equivalent to ivec4.yxwww).
        /// </summary>
        public ivec5 graaa => new ivec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.yy swizzling.
        /// </summary>
        public ivec2 yy => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec4.gg swizzling (equivalent to ivec4.yy).
        /// </summary>
        public ivec2 gg => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec4.yyx swizzling.
        /// </summary>
        public ivec3 yyx => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec4.ggr swizzling (equivalent to ivec4.yyx).
        /// </summary>
        public ivec3 ggr => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec4.yyxx swizzling.
        /// </summary>
        public ivec4 yyxx => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.ggrr swizzling (equivalent to ivec4.yyxx).
        /// </summary>
        public ivec4 ggrr => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.yyxxx swizzling.
        /// </summary>
        public ivec5 yyxxx => new ivec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.ggrrr swizzling (equivalent to ivec4.yyxxx).
        /// </summary>
        public ivec5 ggrrr => new ivec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.yyxxy swizzling.
        /// </summary>
        public ivec5 yyxxy => new ivec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.ggrrg swizzling (equivalent to ivec4.yyxxy).
        /// </summary>
        public ivec5 ggrrg => new ivec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.yyxxz swizzling.
        /// </summary>
        public ivec5 yyxxz => new ivec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.ggrrb swizzling (equivalent to ivec4.yyxxz).
        /// </summary>
        public ivec5 ggrrb => new ivec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.yyxxw swizzling.
        /// </summary>
        public ivec5 yyxxw => new ivec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.ggrra swizzling (equivalent to ivec4.yyxxw).
        /// </summary>
        public ivec5 ggrra => new ivec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.yyxy swizzling.
        /// </summary>
        public ivec4 yyxy => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.ggrg swizzling (equivalent to ivec4.yyxy).
        /// </summary>
        public ivec4 ggrg => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.yyxyx swizzling.
        /// </summary>
        public ivec5 yyxyx => new ivec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.ggrgr swizzling (equivalent to ivec4.yyxyx).
        /// </summary>
        public ivec5 ggrgr => new ivec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.yyxyy swizzling.
        /// </summary>
        public ivec5 yyxyy => new ivec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.ggrgg swizzling (equivalent to ivec4.yyxyy).
        /// </summary>
        public ivec5 ggrgg => new ivec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.yyxyz swizzling.
        /// </summary>
        public ivec5 yyxyz => new ivec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.ggrgb swizzling (equivalent to ivec4.yyxyz).
        /// </summary>
        public ivec5 ggrgb => new ivec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.yyxyw swizzling.
        /// </summary>
        public ivec5 yyxyw => new ivec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.ggrga swizzling (equivalent to ivec4.yyxyw).
        /// </summary>
        public ivec5 ggrga => new ivec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.yyxz swizzling.
        /// </summary>
        public ivec4 yyxz => new ivec4(y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.ggrb swizzling (equivalent to ivec4.yyxz).
        /// </summary>
        public ivec4 ggrb => new ivec4(y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.yyxzx swizzling.
        /// </summary>
        public ivec5 yyxzx => new ivec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.ggrbr swizzling (equivalent to ivec4.yyxzx).
        /// </summary>
        public ivec5 ggrbr => new ivec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.yyxzy swizzling.
        /// </summary>
        public ivec5 yyxzy => new ivec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.ggrbg swizzling (equivalent to ivec4.yyxzy).
        /// </summary>
        public ivec5 ggrbg => new ivec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.yyxzz swizzling.
        /// </summary>
        public ivec5 yyxzz => new ivec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.ggrbb swizzling (equivalent to ivec4.yyxzz).
        /// </summary>
        public ivec5 ggrbb => new ivec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.yyxzw swizzling.
        /// </summary>
        public ivec5 yyxzw => new ivec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.ggrba swizzling (equivalent to ivec4.yyxzw).
        /// </summary>
        public ivec5 ggrba => new ivec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.yyxw swizzling.
        /// </summary>
        public ivec4 yyxw => new ivec4(y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.ggra swizzling (equivalent to ivec4.yyxw).
        /// </summary>
        public ivec4 ggra => new ivec4(y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.yyxwx swizzling.
        /// </summary>
        public ivec5 yyxwx => new ivec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.ggrar swizzling (equivalent to ivec4.yyxwx).
        /// </summary>
        public ivec5 ggrar => new ivec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.yyxwy swizzling.
        /// </summary>
        public ivec5 yyxwy => new ivec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.ggrag swizzling (equivalent to ivec4.yyxwy).
        /// </summary>
        public ivec5 ggrag => new ivec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.yyxwz swizzling.
        /// </summary>
        public ivec5 yyxwz => new ivec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.ggrab swizzling (equivalent to ivec4.yyxwz).
        /// </summary>
        public ivec5 ggrab => new ivec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.yyxww swizzling.
        /// </summary>
        public ivec5 yyxww => new ivec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.ggraa swizzling (equivalent to ivec4.yyxww).
        /// </summary>
        public ivec5 ggraa => new ivec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.yyy swizzling.
        /// </summary>
        public ivec3 yyy => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec4.ggg swizzling (equivalent to ivec4.yyy).
        /// </summary>
        public ivec3 ggg => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec4.yyyx swizzling.
        /// </summary>
        public ivec4 yyyx => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.gggr swizzling (equivalent to ivec4.yyyx).
        /// </summary>
        public ivec4 gggr => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.yyyxx swizzling.
        /// </summary>
        public ivec5 yyyxx => new ivec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.gggrr swizzling (equivalent to ivec4.yyyxx).
        /// </summary>
        public ivec5 gggrr => new ivec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.yyyxy swizzling.
        /// </summary>
        public ivec5 yyyxy => new ivec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.gggrg swizzling (equivalent to ivec4.yyyxy).
        /// </summary>
        public ivec5 gggrg => new ivec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.yyyxz swizzling.
        /// </summary>
        public ivec5 yyyxz => new ivec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.gggrb swizzling (equivalent to ivec4.yyyxz).
        /// </summary>
        public ivec5 gggrb => new ivec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.yyyxw swizzling.
        /// </summary>
        public ivec5 yyyxw => new ivec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.gggra swizzling (equivalent to ivec4.yyyxw).
        /// </summary>
        public ivec5 gggra => new ivec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.yyyy swizzling.
        /// </summary>
        public ivec4 yyyy => new ivec4(y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.gggg swizzling (equivalent to ivec4.yyyy).
        /// </summary>
        public ivec4 gggg => new ivec4(y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.yyyyx swizzling.
        /// </summary>
        public ivec5 yyyyx => new ivec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.ggggr swizzling (equivalent to ivec4.yyyyx).
        /// </summary>
        public ivec5 ggggr => new ivec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.yyyyy swizzling.
        /// </summary>
        public ivec5 yyyyy => new ivec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.ggggg swizzling (equivalent to ivec4.yyyyy).
        /// </summary>
        public ivec5 ggggg => new ivec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.yyyyz swizzling.
        /// </summary>
        public ivec5 yyyyz => new ivec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.ggggb swizzling (equivalent to ivec4.yyyyz).
        /// </summary>
        public ivec5 ggggb => new ivec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.yyyyw swizzling.
        /// </summary>
        public ivec5 yyyyw => new ivec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.gggga swizzling (equivalent to ivec4.yyyyw).
        /// </summary>
        public ivec5 gggga => new ivec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.yyyz swizzling.
        /// </summary>
        public ivec4 yyyz => new ivec4(y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.gggb swizzling (equivalent to ivec4.yyyz).
        /// </summary>
        public ivec4 gggb => new ivec4(y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.yyyzx swizzling.
        /// </summary>
        public ivec5 yyyzx => new ivec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.gggbr swizzling (equivalent to ivec4.yyyzx).
        /// </summary>
        public ivec5 gggbr => new ivec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.yyyzy swizzling.
        /// </summary>
        public ivec5 yyyzy => new ivec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.gggbg swizzling (equivalent to ivec4.yyyzy).
        /// </summary>
        public ivec5 gggbg => new ivec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.yyyzz swizzling.
        /// </summary>
        public ivec5 yyyzz => new ivec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.gggbb swizzling (equivalent to ivec4.yyyzz).
        /// </summary>
        public ivec5 gggbb => new ivec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.yyyzw swizzling.
        /// </summary>
        public ivec5 yyyzw => new ivec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.gggba swizzling (equivalent to ivec4.yyyzw).
        /// </summary>
        public ivec5 gggba => new ivec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.yyyw swizzling.
        /// </summary>
        public ivec4 yyyw => new ivec4(y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.ggga swizzling (equivalent to ivec4.yyyw).
        /// </summary>
        public ivec4 ggga => new ivec4(y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.yyywx swizzling.
        /// </summary>
        public ivec5 yyywx => new ivec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.gggar swizzling (equivalent to ivec4.yyywx).
        /// </summary>
        public ivec5 gggar => new ivec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.yyywy swizzling.
        /// </summary>
        public ivec5 yyywy => new ivec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.gggag swizzling (equivalent to ivec4.yyywy).
        /// </summary>
        public ivec5 gggag => new ivec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.yyywz swizzling.
        /// </summary>
        public ivec5 yyywz => new ivec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.gggab swizzling (equivalent to ivec4.yyywz).
        /// </summary>
        public ivec5 gggab => new ivec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.yyyww swizzling.
        /// </summary>
        public ivec5 yyyww => new ivec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.gggaa swizzling (equivalent to ivec4.yyyww).
        /// </summary>
        public ivec5 gggaa => new ivec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.yyz swizzling.
        /// </summary>
        public ivec3 yyz => new ivec3(y, y, z);
        
        /// <summary>
        /// Returns ivec4.ggb swizzling (equivalent to ivec4.yyz).
        /// </summary>
        public ivec3 ggb => new ivec3(y, y, z);
        
        /// <summary>
        /// Returns ivec4.yyzx swizzling.
        /// </summary>
        public ivec4 yyzx => new ivec4(y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.ggbr swizzling (equivalent to ivec4.yyzx).
        /// </summary>
        public ivec4 ggbr => new ivec4(y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.yyzxx swizzling.
        /// </summary>
        public ivec5 yyzxx => new ivec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.ggbrr swizzling (equivalent to ivec4.yyzxx).
        /// </summary>
        public ivec5 ggbrr => new ivec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.yyzxy swizzling.
        /// </summary>
        public ivec5 yyzxy => new ivec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.ggbrg swizzling (equivalent to ivec4.yyzxy).
        /// </summary>
        public ivec5 ggbrg => new ivec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.yyzxz swizzling.
        /// </summary>
        public ivec5 yyzxz => new ivec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.ggbrb swizzling (equivalent to ivec4.yyzxz).
        /// </summary>
        public ivec5 ggbrb => new ivec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.yyzxw swizzling.
        /// </summary>
        public ivec5 yyzxw => new ivec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.ggbra swizzling (equivalent to ivec4.yyzxw).
        /// </summary>
        public ivec5 ggbra => new ivec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.yyzy swizzling.
        /// </summary>
        public ivec4 yyzy => new ivec4(y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.ggbg swizzling (equivalent to ivec4.yyzy).
        /// </summary>
        public ivec4 ggbg => new ivec4(y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.yyzyx swizzling.
        /// </summary>
        public ivec5 yyzyx => new ivec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.ggbgr swizzling (equivalent to ivec4.yyzyx).
        /// </summary>
        public ivec5 ggbgr => new ivec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.yyzyy swizzling.
        /// </summary>
        public ivec5 yyzyy => new ivec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.ggbgg swizzling (equivalent to ivec4.yyzyy).
        /// </summary>
        public ivec5 ggbgg => new ivec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.yyzyz swizzling.
        /// </summary>
        public ivec5 yyzyz => new ivec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.ggbgb swizzling (equivalent to ivec4.yyzyz).
        /// </summary>
        public ivec5 ggbgb => new ivec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.yyzyw swizzling.
        /// </summary>
        public ivec5 yyzyw => new ivec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.ggbga swizzling (equivalent to ivec4.yyzyw).
        /// </summary>
        public ivec5 ggbga => new ivec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.yyzz swizzling.
        /// </summary>
        public ivec4 yyzz => new ivec4(y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.ggbb swizzling (equivalent to ivec4.yyzz).
        /// </summary>
        public ivec4 ggbb => new ivec4(y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.yyzzx swizzling.
        /// </summary>
        public ivec5 yyzzx => new ivec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.ggbbr swizzling (equivalent to ivec4.yyzzx).
        /// </summary>
        public ivec5 ggbbr => new ivec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.yyzzy swizzling.
        /// </summary>
        public ivec5 yyzzy => new ivec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.ggbbg swizzling (equivalent to ivec4.yyzzy).
        /// </summary>
        public ivec5 ggbbg => new ivec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.yyzzz swizzling.
        /// </summary>
        public ivec5 yyzzz => new ivec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.ggbbb swizzling (equivalent to ivec4.yyzzz).
        /// </summary>
        public ivec5 ggbbb => new ivec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.yyzzw swizzling.
        /// </summary>
        public ivec5 yyzzw => new ivec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.ggbba swizzling (equivalent to ivec4.yyzzw).
        /// </summary>
        public ivec5 ggbba => new ivec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.yyzw swizzling.
        /// </summary>
        public ivec4 yyzw => new ivec4(y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.ggba swizzling (equivalent to ivec4.yyzw).
        /// </summary>
        public ivec4 ggba => new ivec4(y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.yyzwx swizzling.
        /// </summary>
        public ivec5 yyzwx => new ivec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.ggbar swizzling (equivalent to ivec4.yyzwx).
        /// </summary>
        public ivec5 ggbar => new ivec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.yyzwy swizzling.
        /// </summary>
        public ivec5 yyzwy => new ivec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.ggbag swizzling (equivalent to ivec4.yyzwy).
        /// </summary>
        public ivec5 ggbag => new ivec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.yyzwz swizzling.
        /// </summary>
        public ivec5 yyzwz => new ivec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.ggbab swizzling (equivalent to ivec4.yyzwz).
        /// </summary>
        public ivec5 ggbab => new ivec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.yyzww swizzling.
        /// </summary>
        public ivec5 yyzww => new ivec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.ggbaa swizzling (equivalent to ivec4.yyzww).
        /// </summary>
        public ivec5 ggbaa => new ivec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.yyw swizzling.
        /// </summary>
        public ivec3 yyw => new ivec3(y, y, w);
        
        /// <summary>
        /// Returns ivec4.gga swizzling (equivalent to ivec4.yyw).
        /// </summary>
        public ivec3 gga => new ivec3(y, y, w);
        
        /// <summary>
        /// Returns ivec4.yywx swizzling.
        /// </summary>
        public ivec4 yywx => new ivec4(y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.ggar swizzling (equivalent to ivec4.yywx).
        /// </summary>
        public ivec4 ggar => new ivec4(y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.yywxx swizzling.
        /// </summary>
        public ivec5 yywxx => new ivec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.ggarr swizzling (equivalent to ivec4.yywxx).
        /// </summary>
        public ivec5 ggarr => new ivec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.yywxy swizzling.
        /// </summary>
        public ivec5 yywxy => new ivec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.ggarg swizzling (equivalent to ivec4.yywxy).
        /// </summary>
        public ivec5 ggarg => new ivec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.yywxz swizzling.
        /// </summary>
        public ivec5 yywxz => new ivec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.ggarb swizzling (equivalent to ivec4.yywxz).
        /// </summary>
        public ivec5 ggarb => new ivec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.yywxw swizzling.
        /// </summary>
        public ivec5 yywxw => new ivec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.ggara swizzling (equivalent to ivec4.yywxw).
        /// </summary>
        public ivec5 ggara => new ivec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.yywy swizzling.
        /// </summary>
        public ivec4 yywy => new ivec4(y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.ggag swizzling (equivalent to ivec4.yywy).
        /// </summary>
        public ivec4 ggag => new ivec4(y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.yywyx swizzling.
        /// </summary>
        public ivec5 yywyx => new ivec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.ggagr swizzling (equivalent to ivec4.yywyx).
        /// </summary>
        public ivec5 ggagr => new ivec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.yywyy swizzling.
        /// </summary>
        public ivec5 yywyy => new ivec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.ggagg swizzling (equivalent to ivec4.yywyy).
        /// </summary>
        public ivec5 ggagg => new ivec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.yywyz swizzling.
        /// </summary>
        public ivec5 yywyz => new ivec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.ggagb swizzling (equivalent to ivec4.yywyz).
        /// </summary>
        public ivec5 ggagb => new ivec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.yywyw swizzling.
        /// </summary>
        public ivec5 yywyw => new ivec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.ggaga swizzling (equivalent to ivec4.yywyw).
        /// </summary>
        public ivec5 ggaga => new ivec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.yywz swizzling.
        /// </summary>
        public ivec4 yywz => new ivec4(y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.ggab swizzling (equivalent to ivec4.yywz).
        /// </summary>
        public ivec4 ggab => new ivec4(y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.yywzx swizzling.
        /// </summary>
        public ivec5 yywzx => new ivec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.ggabr swizzling (equivalent to ivec4.yywzx).
        /// </summary>
        public ivec5 ggabr => new ivec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.yywzy swizzling.
        /// </summary>
        public ivec5 yywzy => new ivec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.ggabg swizzling (equivalent to ivec4.yywzy).
        /// </summary>
        public ivec5 ggabg => new ivec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.yywzz swizzling.
        /// </summary>
        public ivec5 yywzz => new ivec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.ggabb swizzling (equivalent to ivec4.yywzz).
        /// </summary>
        public ivec5 ggabb => new ivec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.yywzw swizzling.
        /// </summary>
        public ivec5 yywzw => new ivec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.ggaba swizzling (equivalent to ivec4.yywzw).
        /// </summary>
        public ivec5 ggaba => new ivec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.yyww swizzling.
        /// </summary>
        public ivec4 yyww => new ivec4(y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.ggaa swizzling (equivalent to ivec4.yyww).
        /// </summary>
        public ivec4 ggaa => new ivec4(y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.yywwx swizzling.
        /// </summary>
        public ivec5 yywwx => new ivec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.ggaar swizzling (equivalent to ivec4.yywwx).
        /// </summary>
        public ivec5 ggaar => new ivec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.yywwy swizzling.
        /// </summary>
        public ivec5 yywwy => new ivec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.ggaag swizzling (equivalent to ivec4.yywwy).
        /// </summary>
        public ivec5 ggaag => new ivec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.yywwz swizzling.
        /// </summary>
        public ivec5 yywwz => new ivec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.ggaab swizzling (equivalent to ivec4.yywwz).
        /// </summary>
        public ivec5 ggaab => new ivec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.yywww swizzling.
        /// </summary>
        public ivec5 yywww => new ivec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.ggaaa swizzling (equivalent to ivec4.yywww).
        /// </summary>
        public ivec5 ggaaa => new ivec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.yz swizzling.
        /// </summary>
        public ivec2 yz => new ivec2(y, z);
        
        /// <summary>
        /// Returns ivec4.gb swizzling (equivalent to ivec4.yz).
        /// </summary>
        public ivec2 gb => new ivec2(y, z);
        
        /// <summary>
        /// Returns ivec4.yzx swizzling.
        /// </summary>
        public ivec3 yzx => new ivec3(y, z, x);
        
        /// <summary>
        /// Returns ivec4.gbr swizzling (equivalent to ivec4.yzx).
        /// </summary>
        public ivec3 gbr => new ivec3(y, z, x);
        
        /// <summary>
        /// Returns ivec4.yzxx swizzling.
        /// </summary>
        public ivec4 yzxx => new ivec4(y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.gbrr swizzling (equivalent to ivec4.yzxx).
        /// </summary>
        public ivec4 gbrr => new ivec4(y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.yzxxx swizzling.
        /// </summary>
        public ivec5 yzxxx => new ivec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.gbrrr swizzling (equivalent to ivec4.yzxxx).
        /// </summary>
        public ivec5 gbrrr => new ivec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.yzxxy swizzling.
        /// </summary>
        public ivec5 yzxxy => new ivec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.gbrrg swizzling (equivalent to ivec4.yzxxy).
        /// </summary>
        public ivec5 gbrrg => new ivec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.yzxxz swizzling.
        /// </summary>
        public ivec5 yzxxz => new ivec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.gbrrb swizzling (equivalent to ivec4.yzxxz).
        /// </summary>
        public ivec5 gbrrb => new ivec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.yzxxw swizzling.
        /// </summary>
        public ivec5 yzxxw => new ivec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.gbrra swizzling (equivalent to ivec4.yzxxw).
        /// </summary>
        public ivec5 gbrra => new ivec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.yzxy swizzling.
        /// </summary>
        public ivec4 yzxy => new ivec4(y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.gbrg swizzling (equivalent to ivec4.yzxy).
        /// </summary>
        public ivec4 gbrg => new ivec4(y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.yzxyx swizzling.
        /// </summary>
        public ivec5 yzxyx => new ivec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.gbrgr swizzling (equivalent to ivec4.yzxyx).
        /// </summary>
        public ivec5 gbrgr => new ivec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.yzxyy swizzling.
        /// </summary>
        public ivec5 yzxyy => new ivec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.gbrgg swizzling (equivalent to ivec4.yzxyy).
        /// </summary>
        public ivec5 gbrgg => new ivec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.yzxyz swizzling.
        /// </summary>
        public ivec5 yzxyz => new ivec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.gbrgb swizzling (equivalent to ivec4.yzxyz).
        /// </summary>
        public ivec5 gbrgb => new ivec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.yzxyw swizzling.
        /// </summary>
        public ivec5 yzxyw => new ivec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.gbrga swizzling (equivalent to ivec4.yzxyw).
        /// </summary>
        public ivec5 gbrga => new ivec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.yzxz swizzling.
        /// </summary>
        public ivec4 yzxz => new ivec4(y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.gbrb swizzling (equivalent to ivec4.yzxz).
        /// </summary>
        public ivec4 gbrb => new ivec4(y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.yzxzx swizzling.
        /// </summary>
        public ivec5 yzxzx => new ivec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.gbrbr swizzling (equivalent to ivec4.yzxzx).
        /// </summary>
        public ivec5 gbrbr => new ivec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.yzxzy swizzling.
        /// </summary>
        public ivec5 yzxzy => new ivec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.gbrbg swizzling (equivalent to ivec4.yzxzy).
        /// </summary>
        public ivec5 gbrbg => new ivec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.yzxzz swizzling.
        /// </summary>
        public ivec5 yzxzz => new ivec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.gbrbb swizzling (equivalent to ivec4.yzxzz).
        /// </summary>
        public ivec5 gbrbb => new ivec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.yzxzw swizzling.
        /// </summary>
        public ivec5 yzxzw => new ivec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.gbrba swizzling (equivalent to ivec4.yzxzw).
        /// </summary>
        public ivec5 gbrba => new ivec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.yzxw swizzling.
        /// </summary>
        public ivec4 yzxw => new ivec4(y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.gbra swizzling (equivalent to ivec4.yzxw).
        /// </summary>
        public ivec4 gbra => new ivec4(y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.yzxwx swizzling.
        /// </summary>
        public ivec5 yzxwx => new ivec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.gbrar swizzling (equivalent to ivec4.yzxwx).
        /// </summary>
        public ivec5 gbrar => new ivec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.yzxwy swizzling.
        /// </summary>
        public ivec5 yzxwy => new ivec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.gbrag swizzling (equivalent to ivec4.yzxwy).
        /// </summary>
        public ivec5 gbrag => new ivec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.yzxwz swizzling.
        /// </summary>
        public ivec5 yzxwz => new ivec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.gbrab swizzling (equivalent to ivec4.yzxwz).
        /// </summary>
        public ivec5 gbrab => new ivec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.yzxww swizzling.
        /// </summary>
        public ivec5 yzxww => new ivec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.gbraa swizzling (equivalent to ivec4.yzxww).
        /// </summary>
        public ivec5 gbraa => new ivec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.yzy swizzling.
        /// </summary>
        public ivec3 yzy => new ivec3(y, z, y);
        
        /// <summary>
        /// Returns ivec4.gbg swizzling (equivalent to ivec4.yzy).
        /// </summary>
        public ivec3 gbg => new ivec3(y, z, y);
        
        /// <summary>
        /// Returns ivec4.yzyx swizzling.
        /// </summary>
        public ivec4 yzyx => new ivec4(y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.gbgr swizzling (equivalent to ivec4.yzyx).
        /// </summary>
        public ivec4 gbgr => new ivec4(y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.yzyxx swizzling.
        /// </summary>
        public ivec5 yzyxx => new ivec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.gbgrr swizzling (equivalent to ivec4.yzyxx).
        /// </summary>
        public ivec5 gbgrr => new ivec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.yzyxy swizzling.
        /// </summary>
        public ivec5 yzyxy => new ivec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.gbgrg swizzling (equivalent to ivec4.yzyxy).
        /// </summary>
        public ivec5 gbgrg => new ivec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.yzyxz swizzling.
        /// </summary>
        public ivec5 yzyxz => new ivec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.gbgrb swizzling (equivalent to ivec4.yzyxz).
        /// </summary>
        public ivec5 gbgrb => new ivec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.yzyxw swizzling.
        /// </summary>
        public ivec5 yzyxw => new ivec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.gbgra swizzling (equivalent to ivec4.yzyxw).
        /// </summary>
        public ivec5 gbgra => new ivec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.yzyy swizzling.
        /// </summary>
        public ivec4 yzyy => new ivec4(y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.gbgg swizzling (equivalent to ivec4.yzyy).
        /// </summary>
        public ivec4 gbgg => new ivec4(y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.yzyyx swizzling.
        /// </summary>
        public ivec5 yzyyx => new ivec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.gbggr swizzling (equivalent to ivec4.yzyyx).
        /// </summary>
        public ivec5 gbggr => new ivec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.yzyyy swizzling.
        /// </summary>
        public ivec5 yzyyy => new ivec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.gbggg swizzling (equivalent to ivec4.yzyyy).
        /// </summary>
        public ivec5 gbggg => new ivec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.yzyyz swizzling.
        /// </summary>
        public ivec5 yzyyz => new ivec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.gbggb swizzling (equivalent to ivec4.yzyyz).
        /// </summary>
        public ivec5 gbggb => new ivec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.yzyyw swizzling.
        /// </summary>
        public ivec5 yzyyw => new ivec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.gbgga swizzling (equivalent to ivec4.yzyyw).
        /// </summary>
        public ivec5 gbgga => new ivec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.yzyz swizzling.
        /// </summary>
        public ivec4 yzyz => new ivec4(y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.gbgb swizzling (equivalent to ivec4.yzyz).
        /// </summary>
        public ivec4 gbgb => new ivec4(y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.yzyzx swizzling.
        /// </summary>
        public ivec5 yzyzx => new ivec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.gbgbr swizzling (equivalent to ivec4.yzyzx).
        /// </summary>
        public ivec5 gbgbr => new ivec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.yzyzy swizzling.
        /// </summary>
        public ivec5 yzyzy => new ivec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.gbgbg swizzling (equivalent to ivec4.yzyzy).
        /// </summary>
        public ivec5 gbgbg => new ivec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.yzyzz swizzling.
        /// </summary>
        public ivec5 yzyzz => new ivec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.gbgbb swizzling (equivalent to ivec4.yzyzz).
        /// </summary>
        public ivec5 gbgbb => new ivec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.yzyzw swizzling.
        /// </summary>
        public ivec5 yzyzw => new ivec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.gbgba swizzling (equivalent to ivec4.yzyzw).
        /// </summary>
        public ivec5 gbgba => new ivec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.yzyw swizzling.
        /// </summary>
        public ivec4 yzyw => new ivec4(y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.gbga swizzling (equivalent to ivec4.yzyw).
        /// </summary>
        public ivec4 gbga => new ivec4(y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.yzywx swizzling.
        /// </summary>
        public ivec5 yzywx => new ivec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.gbgar swizzling (equivalent to ivec4.yzywx).
        /// </summary>
        public ivec5 gbgar => new ivec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.yzywy swizzling.
        /// </summary>
        public ivec5 yzywy => new ivec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.gbgag swizzling (equivalent to ivec4.yzywy).
        /// </summary>
        public ivec5 gbgag => new ivec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.yzywz swizzling.
        /// </summary>
        public ivec5 yzywz => new ivec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.gbgab swizzling (equivalent to ivec4.yzywz).
        /// </summary>
        public ivec5 gbgab => new ivec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.yzyww swizzling.
        /// </summary>
        public ivec5 yzyww => new ivec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.gbgaa swizzling (equivalent to ivec4.yzyww).
        /// </summary>
        public ivec5 gbgaa => new ivec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.yzz swizzling.
        /// </summary>
        public ivec3 yzz => new ivec3(y, z, z);
        
        /// <summary>
        /// Returns ivec4.gbb swizzling (equivalent to ivec4.yzz).
        /// </summary>
        public ivec3 gbb => new ivec3(y, z, z);
        
        /// <summary>
        /// Returns ivec4.yzzx swizzling.
        /// </summary>
        public ivec4 yzzx => new ivec4(y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.gbbr swizzling (equivalent to ivec4.yzzx).
        /// </summary>
        public ivec4 gbbr => new ivec4(y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.yzzxx swizzling.
        /// </summary>
        public ivec5 yzzxx => new ivec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.gbbrr swizzling (equivalent to ivec4.yzzxx).
        /// </summary>
        public ivec5 gbbrr => new ivec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.yzzxy swizzling.
        /// </summary>
        public ivec5 yzzxy => new ivec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.gbbrg swizzling (equivalent to ivec4.yzzxy).
        /// </summary>
        public ivec5 gbbrg => new ivec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.yzzxz swizzling.
        /// </summary>
        public ivec5 yzzxz => new ivec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.gbbrb swizzling (equivalent to ivec4.yzzxz).
        /// </summary>
        public ivec5 gbbrb => new ivec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.yzzxw swizzling.
        /// </summary>
        public ivec5 yzzxw => new ivec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.gbbra swizzling (equivalent to ivec4.yzzxw).
        /// </summary>
        public ivec5 gbbra => new ivec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.yzzy swizzling.
        /// </summary>
        public ivec4 yzzy => new ivec4(y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.gbbg swizzling (equivalent to ivec4.yzzy).
        /// </summary>
        public ivec4 gbbg => new ivec4(y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.yzzyx swizzling.
        /// </summary>
        public ivec5 yzzyx => new ivec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.gbbgr swizzling (equivalent to ivec4.yzzyx).
        /// </summary>
        public ivec5 gbbgr => new ivec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.yzzyy swizzling.
        /// </summary>
        public ivec5 yzzyy => new ivec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.gbbgg swizzling (equivalent to ivec4.yzzyy).
        /// </summary>
        public ivec5 gbbgg => new ivec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.yzzyz swizzling.
        /// </summary>
        public ivec5 yzzyz => new ivec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.gbbgb swizzling (equivalent to ivec4.yzzyz).
        /// </summary>
        public ivec5 gbbgb => new ivec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.yzzyw swizzling.
        /// </summary>
        public ivec5 yzzyw => new ivec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.gbbga swizzling (equivalent to ivec4.yzzyw).
        /// </summary>
        public ivec5 gbbga => new ivec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.yzzz swizzling.
        /// </summary>
        public ivec4 yzzz => new ivec4(y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.gbbb swizzling (equivalent to ivec4.yzzz).
        /// </summary>
        public ivec4 gbbb => new ivec4(y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.yzzzx swizzling.
        /// </summary>
        public ivec5 yzzzx => new ivec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.gbbbr swizzling (equivalent to ivec4.yzzzx).
        /// </summary>
        public ivec5 gbbbr => new ivec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.yzzzy swizzling.
        /// </summary>
        public ivec5 yzzzy => new ivec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.gbbbg swizzling (equivalent to ivec4.yzzzy).
        /// </summary>
        public ivec5 gbbbg => new ivec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.yzzzz swizzling.
        /// </summary>
        public ivec5 yzzzz => new ivec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.gbbbb swizzling (equivalent to ivec4.yzzzz).
        /// </summary>
        public ivec5 gbbbb => new ivec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.yzzzw swizzling.
        /// </summary>
        public ivec5 yzzzw => new ivec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.gbbba swizzling (equivalent to ivec4.yzzzw).
        /// </summary>
        public ivec5 gbbba => new ivec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.yzzw swizzling.
        /// </summary>
        public ivec4 yzzw => new ivec4(y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.gbba swizzling (equivalent to ivec4.yzzw).
        /// </summary>
        public ivec4 gbba => new ivec4(y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.yzzwx swizzling.
        /// </summary>
        public ivec5 yzzwx => new ivec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.gbbar swizzling (equivalent to ivec4.yzzwx).
        /// </summary>
        public ivec5 gbbar => new ivec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.yzzwy swizzling.
        /// </summary>
        public ivec5 yzzwy => new ivec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.gbbag swizzling (equivalent to ivec4.yzzwy).
        /// </summary>
        public ivec5 gbbag => new ivec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.yzzwz swizzling.
        /// </summary>
        public ivec5 yzzwz => new ivec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.gbbab swizzling (equivalent to ivec4.yzzwz).
        /// </summary>
        public ivec5 gbbab => new ivec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.yzzww swizzling.
        /// </summary>
        public ivec5 yzzww => new ivec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.gbbaa swizzling (equivalent to ivec4.yzzww).
        /// </summary>
        public ivec5 gbbaa => new ivec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.yzw swizzling.
        /// </summary>
        public ivec3 yzw => new ivec3(y, z, w);
        
        /// <summary>
        /// Returns ivec4.gba swizzling (equivalent to ivec4.yzw).
        /// </summary>
        public ivec3 gba => new ivec3(y, z, w);
        
        /// <summary>
        /// Returns ivec4.yzwx swizzling.
        /// </summary>
        public ivec4 yzwx => new ivec4(y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.gbar swizzling (equivalent to ivec4.yzwx).
        /// </summary>
        public ivec4 gbar => new ivec4(y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.yzwxx swizzling.
        /// </summary>
        public ivec5 yzwxx => new ivec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.gbarr swizzling (equivalent to ivec4.yzwxx).
        /// </summary>
        public ivec5 gbarr => new ivec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.yzwxy swizzling.
        /// </summary>
        public ivec5 yzwxy => new ivec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.gbarg swizzling (equivalent to ivec4.yzwxy).
        /// </summary>
        public ivec5 gbarg => new ivec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.yzwxz swizzling.
        /// </summary>
        public ivec5 yzwxz => new ivec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.gbarb swizzling (equivalent to ivec4.yzwxz).
        /// </summary>
        public ivec5 gbarb => new ivec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.yzwxw swizzling.
        /// </summary>
        public ivec5 yzwxw => new ivec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.gbara swizzling (equivalent to ivec4.yzwxw).
        /// </summary>
        public ivec5 gbara => new ivec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.yzwy swizzling.
        /// </summary>
        public ivec4 yzwy => new ivec4(y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.gbag swizzling (equivalent to ivec4.yzwy).
        /// </summary>
        public ivec4 gbag => new ivec4(y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.yzwyx swizzling.
        /// </summary>
        public ivec5 yzwyx => new ivec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.gbagr swizzling (equivalent to ivec4.yzwyx).
        /// </summary>
        public ivec5 gbagr => new ivec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.yzwyy swizzling.
        /// </summary>
        public ivec5 yzwyy => new ivec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.gbagg swizzling (equivalent to ivec4.yzwyy).
        /// </summary>
        public ivec5 gbagg => new ivec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.yzwyz swizzling.
        /// </summary>
        public ivec5 yzwyz => new ivec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.gbagb swizzling (equivalent to ivec4.yzwyz).
        /// </summary>
        public ivec5 gbagb => new ivec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.yzwyw swizzling.
        /// </summary>
        public ivec5 yzwyw => new ivec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.gbaga swizzling (equivalent to ivec4.yzwyw).
        /// </summary>
        public ivec5 gbaga => new ivec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.yzwz swizzling.
        /// </summary>
        public ivec4 yzwz => new ivec4(y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.gbab swizzling (equivalent to ivec4.yzwz).
        /// </summary>
        public ivec4 gbab => new ivec4(y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.yzwzx swizzling.
        /// </summary>
        public ivec5 yzwzx => new ivec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.gbabr swizzling (equivalent to ivec4.yzwzx).
        /// </summary>
        public ivec5 gbabr => new ivec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.yzwzy swizzling.
        /// </summary>
        public ivec5 yzwzy => new ivec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.gbabg swizzling (equivalent to ivec4.yzwzy).
        /// </summary>
        public ivec5 gbabg => new ivec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.yzwzz swizzling.
        /// </summary>
        public ivec5 yzwzz => new ivec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.gbabb swizzling (equivalent to ivec4.yzwzz).
        /// </summary>
        public ivec5 gbabb => new ivec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.yzwzw swizzling.
        /// </summary>
        public ivec5 yzwzw => new ivec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.gbaba swizzling (equivalent to ivec4.yzwzw).
        /// </summary>
        public ivec5 gbaba => new ivec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.yzww swizzling.
        /// </summary>
        public ivec4 yzww => new ivec4(y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.gbaa swizzling (equivalent to ivec4.yzww).
        /// </summary>
        public ivec4 gbaa => new ivec4(y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.yzwwx swizzling.
        /// </summary>
        public ivec5 yzwwx => new ivec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.gbaar swizzling (equivalent to ivec4.yzwwx).
        /// </summary>
        public ivec5 gbaar => new ivec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.yzwwy swizzling.
        /// </summary>
        public ivec5 yzwwy => new ivec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.gbaag swizzling (equivalent to ivec4.yzwwy).
        /// </summary>
        public ivec5 gbaag => new ivec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.yzwwz swizzling.
        /// </summary>
        public ivec5 yzwwz => new ivec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.gbaab swizzling (equivalent to ivec4.yzwwz).
        /// </summary>
        public ivec5 gbaab => new ivec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.yzwww swizzling.
        /// </summary>
        public ivec5 yzwww => new ivec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.gbaaa swizzling (equivalent to ivec4.yzwww).
        /// </summary>
        public ivec5 gbaaa => new ivec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.yw swizzling.
        /// </summary>
        public ivec2 yw => new ivec2(y, w);
        
        /// <summary>
        /// Returns ivec4.ga swizzling (equivalent to ivec4.yw).
        /// </summary>
        public ivec2 ga => new ivec2(y, w);
        
        /// <summary>
        /// Returns ivec4.ywx swizzling.
        /// </summary>
        public ivec3 ywx => new ivec3(y, w, x);
        
        /// <summary>
        /// Returns ivec4.gar swizzling (equivalent to ivec4.ywx).
        /// </summary>
        public ivec3 gar => new ivec3(y, w, x);
        
        /// <summary>
        /// Returns ivec4.ywxx swizzling.
        /// </summary>
        public ivec4 ywxx => new ivec4(y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.garr swizzling (equivalent to ivec4.ywxx).
        /// </summary>
        public ivec4 garr => new ivec4(y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.ywxxx swizzling.
        /// </summary>
        public ivec5 ywxxx => new ivec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.garrr swizzling (equivalent to ivec4.ywxxx).
        /// </summary>
        public ivec5 garrr => new ivec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.ywxxy swizzling.
        /// </summary>
        public ivec5 ywxxy => new ivec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.garrg swizzling (equivalent to ivec4.ywxxy).
        /// </summary>
        public ivec5 garrg => new ivec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.ywxxz swizzling.
        /// </summary>
        public ivec5 ywxxz => new ivec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.garrb swizzling (equivalent to ivec4.ywxxz).
        /// </summary>
        public ivec5 garrb => new ivec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.ywxxw swizzling.
        /// </summary>
        public ivec5 ywxxw => new ivec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.garra swizzling (equivalent to ivec4.ywxxw).
        /// </summary>
        public ivec5 garra => new ivec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.ywxy swizzling.
        /// </summary>
        public ivec4 ywxy => new ivec4(y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.garg swizzling (equivalent to ivec4.ywxy).
        /// </summary>
        public ivec4 garg => new ivec4(y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.ywxyx swizzling.
        /// </summary>
        public ivec5 ywxyx => new ivec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.gargr swizzling (equivalent to ivec4.ywxyx).
        /// </summary>
        public ivec5 gargr => new ivec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.ywxyy swizzling.
        /// </summary>
        public ivec5 ywxyy => new ivec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.gargg swizzling (equivalent to ivec4.ywxyy).
        /// </summary>
        public ivec5 gargg => new ivec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.ywxyz swizzling.
        /// </summary>
        public ivec5 ywxyz => new ivec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.gargb swizzling (equivalent to ivec4.ywxyz).
        /// </summary>
        public ivec5 gargb => new ivec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.ywxyw swizzling.
        /// </summary>
        public ivec5 ywxyw => new ivec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.garga swizzling (equivalent to ivec4.ywxyw).
        /// </summary>
        public ivec5 garga => new ivec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.ywxz swizzling.
        /// </summary>
        public ivec4 ywxz => new ivec4(y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.garb swizzling (equivalent to ivec4.ywxz).
        /// </summary>
        public ivec4 garb => new ivec4(y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.ywxzx swizzling.
        /// </summary>
        public ivec5 ywxzx => new ivec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.garbr swizzling (equivalent to ivec4.ywxzx).
        /// </summary>
        public ivec5 garbr => new ivec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.ywxzy swizzling.
        /// </summary>
        public ivec5 ywxzy => new ivec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.garbg swizzling (equivalent to ivec4.ywxzy).
        /// </summary>
        public ivec5 garbg => new ivec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.ywxzz swizzling.
        /// </summary>
        public ivec5 ywxzz => new ivec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.garbb swizzling (equivalent to ivec4.ywxzz).
        /// </summary>
        public ivec5 garbb => new ivec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.ywxzw swizzling.
        /// </summary>
        public ivec5 ywxzw => new ivec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.garba swizzling (equivalent to ivec4.ywxzw).
        /// </summary>
        public ivec5 garba => new ivec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.ywxw swizzling.
        /// </summary>
        public ivec4 ywxw => new ivec4(y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.gara swizzling (equivalent to ivec4.ywxw).
        /// </summary>
        public ivec4 gara => new ivec4(y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.ywxwx swizzling.
        /// </summary>
        public ivec5 ywxwx => new ivec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.garar swizzling (equivalent to ivec4.ywxwx).
        /// </summary>
        public ivec5 garar => new ivec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.ywxwy swizzling.
        /// </summary>
        public ivec5 ywxwy => new ivec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.garag swizzling (equivalent to ivec4.ywxwy).
        /// </summary>
        public ivec5 garag => new ivec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.ywxwz swizzling.
        /// </summary>
        public ivec5 ywxwz => new ivec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.garab swizzling (equivalent to ivec4.ywxwz).
        /// </summary>
        public ivec5 garab => new ivec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.ywxww swizzling.
        /// </summary>
        public ivec5 ywxww => new ivec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.garaa swizzling (equivalent to ivec4.ywxww).
        /// </summary>
        public ivec5 garaa => new ivec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.ywy swizzling.
        /// </summary>
        public ivec3 ywy => new ivec3(y, w, y);
        
        /// <summary>
        /// Returns ivec4.gag swizzling (equivalent to ivec4.ywy).
        /// </summary>
        public ivec3 gag => new ivec3(y, w, y);
        
        /// <summary>
        /// Returns ivec4.ywyx swizzling.
        /// </summary>
        public ivec4 ywyx => new ivec4(y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.gagr swizzling (equivalent to ivec4.ywyx).
        /// </summary>
        public ivec4 gagr => new ivec4(y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.ywyxx swizzling.
        /// </summary>
        public ivec5 ywyxx => new ivec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.gagrr swizzling (equivalent to ivec4.ywyxx).
        /// </summary>
        public ivec5 gagrr => new ivec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.ywyxy swizzling.
        /// </summary>
        public ivec5 ywyxy => new ivec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.gagrg swizzling (equivalent to ivec4.ywyxy).
        /// </summary>
        public ivec5 gagrg => new ivec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.ywyxz swizzling.
        /// </summary>
        public ivec5 ywyxz => new ivec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.gagrb swizzling (equivalent to ivec4.ywyxz).
        /// </summary>
        public ivec5 gagrb => new ivec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.ywyxw swizzling.
        /// </summary>
        public ivec5 ywyxw => new ivec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.gagra swizzling (equivalent to ivec4.ywyxw).
        /// </summary>
        public ivec5 gagra => new ivec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.ywyy swizzling.
        /// </summary>
        public ivec4 ywyy => new ivec4(y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.gagg swizzling (equivalent to ivec4.ywyy).
        /// </summary>
        public ivec4 gagg => new ivec4(y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.ywyyx swizzling.
        /// </summary>
        public ivec5 ywyyx => new ivec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.gaggr swizzling (equivalent to ivec4.ywyyx).
        /// </summary>
        public ivec5 gaggr => new ivec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.ywyyy swizzling.
        /// </summary>
        public ivec5 ywyyy => new ivec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.gaggg swizzling (equivalent to ivec4.ywyyy).
        /// </summary>
        public ivec5 gaggg => new ivec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.ywyyz swizzling.
        /// </summary>
        public ivec5 ywyyz => new ivec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.gaggb swizzling (equivalent to ivec4.ywyyz).
        /// </summary>
        public ivec5 gaggb => new ivec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.ywyyw swizzling.
        /// </summary>
        public ivec5 ywyyw => new ivec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.gagga swizzling (equivalent to ivec4.ywyyw).
        /// </summary>
        public ivec5 gagga => new ivec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.ywyz swizzling.
        /// </summary>
        public ivec4 ywyz => new ivec4(y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.gagb swizzling (equivalent to ivec4.ywyz).
        /// </summary>
        public ivec4 gagb => new ivec4(y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.ywyzx swizzling.
        /// </summary>
        public ivec5 ywyzx => new ivec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.gagbr swizzling (equivalent to ivec4.ywyzx).
        /// </summary>
        public ivec5 gagbr => new ivec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.ywyzy swizzling.
        /// </summary>
        public ivec5 ywyzy => new ivec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.gagbg swizzling (equivalent to ivec4.ywyzy).
        /// </summary>
        public ivec5 gagbg => new ivec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.ywyzz swizzling.
        /// </summary>
        public ivec5 ywyzz => new ivec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.gagbb swizzling (equivalent to ivec4.ywyzz).
        /// </summary>
        public ivec5 gagbb => new ivec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.ywyzw swizzling.
        /// </summary>
        public ivec5 ywyzw => new ivec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.gagba swizzling (equivalent to ivec4.ywyzw).
        /// </summary>
        public ivec5 gagba => new ivec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.ywyw swizzling.
        /// </summary>
        public ivec4 ywyw => new ivec4(y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.gaga swizzling (equivalent to ivec4.ywyw).
        /// </summary>
        public ivec4 gaga => new ivec4(y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.ywywx swizzling.
        /// </summary>
        public ivec5 ywywx => new ivec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.gagar swizzling (equivalent to ivec4.ywywx).
        /// </summary>
        public ivec5 gagar => new ivec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.ywywy swizzling.
        /// </summary>
        public ivec5 ywywy => new ivec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.gagag swizzling (equivalent to ivec4.ywywy).
        /// </summary>
        public ivec5 gagag => new ivec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.ywywz swizzling.
        /// </summary>
        public ivec5 ywywz => new ivec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.gagab swizzling (equivalent to ivec4.ywywz).
        /// </summary>
        public ivec5 gagab => new ivec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.ywyww swizzling.
        /// </summary>
        public ivec5 ywyww => new ivec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.gagaa swizzling (equivalent to ivec4.ywyww).
        /// </summary>
        public ivec5 gagaa => new ivec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.ywz swizzling.
        /// </summary>
        public ivec3 ywz => new ivec3(y, w, z);
        
        /// <summary>
        /// Returns ivec4.gab swizzling (equivalent to ivec4.ywz).
        /// </summary>
        public ivec3 gab => new ivec3(y, w, z);
        
        /// <summary>
        /// Returns ivec4.ywzx swizzling.
        /// </summary>
        public ivec4 ywzx => new ivec4(y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.gabr swizzling (equivalent to ivec4.ywzx).
        /// </summary>
        public ivec4 gabr => new ivec4(y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.ywzxx swizzling.
        /// </summary>
        public ivec5 ywzxx => new ivec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.gabrr swizzling (equivalent to ivec4.ywzxx).
        /// </summary>
        public ivec5 gabrr => new ivec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.ywzxy swizzling.
        /// </summary>
        public ivec5 ywzxy => new ivec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.gabrg swizzling (equivalent to ivec4.ywzxy).
        /// </summary>
        public ivec5 gabrg => new ivec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.ywzxz swizzling.
        /// </summary>
        public ivec5 ywzxz => new ivec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.gabrb swizzling (equivalent to ivec4.ywzxz).
        /// </summary>
        public ivec5 gabrb => new ivec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.ywzxw swizzling.
        /// </summary>
        public ivec5 ywzxw => new ivec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.gabra swizzling (equivalent to ivec4.ywzxw).
        /// </summary>
        public ivec5 gabra => new ivec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.ywzy swizzling.
        /// </summary>
        public ivec4 ywzy => new ivec4(y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.gabg swizzling (equivalent to ivec4.ywzy).
        /// </summary>
        public ivec4 gabg => new ivec4(y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.ywzyx swizzling.
        /// </summary>
        public ivec5 ywzyx => new ivec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.gabgr swizzling (equivalent to ivec4.ywzyx).
        /// </summary>
        public ivec5 gabgr => new ivec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.ywzyy swizzling.
        /// </summary>
        public ivec5 ywzyy => new ivec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.gabgg swizzling (equivalent to ivec4.ywzyy).
        /// </summary>
        public ivec5 gabgg => new ivec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.ywzyz swizzling.
        /// </summary>
        public ivec5 ywzyz => new ivec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.gabgb swizzling (equivalent to ivec4.ywzyz).
        /// </summary>
        public ivec5 gabgb => new ivec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.ywzyw swizzling.
        /// </summary>
        public ivec5 ywzyw => new ivec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.gabga swizzling (equivalent to ivec4.ywzyw).
        /// </summary>
        public ivec5 gabga => new ivec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.ywzz swizzling.
        /// </summary>
        public ivec4 ywzz => new ivec4(y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.gabb swizzling (equivalent to ivec4.ywzz).
        /// </summary>
        public ivec4 gabb => new ivec4(y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.ywzzx swizzling.
        /// </summary>
        public ivec5 ywzzx => new ivec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.gabbr swizzling (equivalent to ivec4.ywzzx).
        /// </summary>
        public ivec5 gabbr => new ivec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.ywzzy swizzling.
        /// </summary>
        public ivec5 ywzzy => new ivec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.gabbg swizzling (equivalent to ivec4.ywzzy).
        /// </summary>
        public ivec5 gabbg => new ivec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.ywzzz swizzling.
        /// </summary>
        public ivec5 ywzzz => new ivec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.gabbb swizzling (equivalent to ivec4.ywzzz).
        /// </summary>
        public ivec5 gabbb => new ivec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.ywzzw swizzling.
        /// </summary>
        public ivec5 ywzzw => new ivec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.gabba swizzling (equivalent to ivec4.ywzzw).
        /// </summary>
        public ivec5 gabba => new ivec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.ywzw swizzling.
        /// </summary>
        public ivec4 ywzw => new ivec4(y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.gaba swizzling (equivalent to ivec4.ywzw).
        /// </summary>
        public ivec4 gaba => new ivec4(y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.ywzwx swizzling.
        /// </summary>
        public ivec5 ywzwx => new ivec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.gabar swizzling (equivalent to ivec4.ywzwx).
        /// </summary>
        public ivec5 gabar => new ivec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.ywzwy swizzling.
        /// </summary>
        public ivec5 ywzwy => new ivec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.gabag swizzling (equivalent to ivec4.ywzwy).
        /// </summary>
        public ivec5 gabag => new ivec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.ywzwz swizzling.
        /// </summary>
        public ivec5 ywzwz => new ivec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.gabab swizzling (equivalent to ivec4.ywzwz).
        /// </summary>
        public ivec5 gabab => new ivec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.ywzww swizzling.
        /// </summary>
        public ivec5 ywzww => new ivec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.gabaa swizzling (equivalent to ivec4.ywzww).
        /// </summary>
        public ivec5 gabaa => new ivec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.yww swizzling.
        /// </summary>
        public ivec3 yww => new ivec3(y, w, w);
        
        /// <summary>
        /// Returns ivec4.gaa swizzling (equivalent to ivec4.yww).
        /// </summary>
        public ivec3 gaa => new ivec3(y, w, w);
        
        /// <summary>
        /// Returns ivec4.ywwx swizzling.
        /// </summary>
        public ivec4 ywwx => new ivec4(y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.gaar swizzling (equivalent to ivec4.ywwx).
        /// </summary>
        public ivec4 gaar => new ivec4(y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.ywwxx swizzling.
        /// </summary>
        public ivec5 ywwxx => new ivec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.gaarr swizzling (equivalent to ivec4.ywwxx).
        /// </summary>
        public ivec5 gaarr => new ivec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.ywwxy swizzling.
        /// </summary>
        public ivec5 ywwxy => new ivec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.gaarg swizzling (equivalent to ivec4.ywwxy).
        /// </summary>
        public ivec5 gaarg => new ivec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.ywwxz swizzling.
        /// </summary>
        public ivec5 ywwxz => new ivec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.gaarb swizzling (equivalent to ivec4.ywwxz).
        /// </summary>
        public ivec5 gaarb => new ivec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.ywwxw swizzling.
        /// </summary>
        public ivec5 ywwxw => new ivec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.gaara swizzling (equivalent to ivec4.ywwxw).
        /// </summary>
        public ivec5 gaara => new ivec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.ywwy swizzling.
        /// </summary>
        public ivec4 ywwy => new ivec4(y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.gaag swizzling (equivalent to ivec4.ywwy).
        /// </summary>
        public ivec4 gaag => new ivec4(y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.ywwyx swizzling.
        /// </summary>
        public ivec5 ywwyx => new ivec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.gaagr swizzling (equivalent to ivec4.ywwyx).
        /// </summary>
        public ivec5 gaagr => new ivec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.ywwyy swizzling.
        /// </summary>
        public ivec5 ywwyy => new ivec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.gaagg swizzling (equivalent to ivec4.ywwyy).
        /// </summary>
        public ivec5 gaagg => new ivec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.ywwyz swizzling.
        /// </summary>
        public ivec5 ywwyz => new ivec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.gaagb swizzling (equivalent to ivec4.ywwyz).
        /// </summary>
        public ivec5 gaagb => new ivec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.ywwyw swizzling.
        /// </summary>
        public ivec5 ywwyw => new ivec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.gaaga swizzling (equivalent to ivec4.ywwyw).
        /// </summary>
        public ivec5 gaaga => new ivec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.ywwz swizzling.
        /// </summary>
        public ivec4 ywwz => new ivec4(y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.gaab swizzling (equivalent to ivec4.ywwz).
        /// </summary>
        public ivec4 gaab => new ivec4(y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.ywwzx swizzling.
        /// </summary>
        public ivec5 ywwzx => new ivec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.gaabr swizzling (equivalent to ivec4.ywwzx).
        /// </summary>
        public ivec5 gaabr => new ivec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.ywwzy swizzling.
        /// </summary>
        public ivec5 ywwzy => new ivec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.gaabg swizzling (equivalent to ivec4.ywwzy).
        /// </summary>
        public ivec5 gaabg => new ivec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.ywwzz swizzling.
        /// </summary>
        public ivec5 ywwzz => new ivec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.gaabb swizzling (equivalent to ivec4.ywwzz).
        /// </summary>
        public ivec5 gaabb => new ivec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.ywwzw swizzling.
        /// </summary>
        public ivec5 ywwzw => new ivec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.gaaba swizzling (equivalent to ivec4.ywwzw).
        /// </summary>
        public ivec5 gaaba => new ivec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.ywww swizzling.
        /// </summary>
        public ivec4 ywww => new ivec4(y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.gaaa swizzling (equivalent to ivec4.ywww).
        /// </summary>
        public ivec4 gaaa => new ivec4(y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.ywwwx swizzling.
        /// </summary>
        public ivec5 ywwwx => new ivec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.gaaar swizzling (equivalent to ivec4.ywwwx).
        /// </summary>
        public ivec5 gaaar => new ivec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.ywwwy swizzling.
        /// </summary>
        public ivec5 ywwwy => new ivec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.gaaag swizzling (equivalent to ivec4.ywwwy).
        /// </summary>
        public ivec5 gaaag => new ivec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.ywwwz swizzling.
        /// </summary>
        public ivec5 ywwwz => new ivec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.gaaab swizzling (equivalent to ivec4.ywwwz).
        /// </summary>
        public ivec5 gaaab => new ivec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.ywwww swizzling.
        /// </summary>
        public ivec5 ywwww => new ivec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns ivec4.gaaaa swizzling (equivalent to ivec4.ywwww).
        /// </summary>
        public ivec5 gaaaa => new ivec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns ivec4.zx swizzling.
        /// </summary>
        public ivec2 zx => new ivec2(z, x);
        
        /// <summary>
        /// Returns ivec4.br swizzling (equivalent to ivec4.zx).
        /// </summary>
        public ivec2 br => new ivec2(z, x);
        
        /// <summary>
        /// Returns ivec4.zxx swizzling.
        /// </summary>
        public ivec3 zxx => new ivec3(z, x, x);
        
        /// <summary>
        /// Returns ivec4.brr swizzling (equivalent to ivec4.zxx).
        /// </summary>
        public ivec3 brr => new ivec3(z, x, x);
        
        /// <summary>
        /// Returns ivec4.zxxx swizzling.
        /// </summary>
        public ivec4 zxxx => new ivec4(z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.brrr swizzling (equivalent to ivec4.zxxx).
        /// </summary>
        public ivec4 brrr => new ivec4(z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.zxxxx swizzling.
        /// </summary>
        public ivec5 zxxxx => new ivec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.brrrr swizzling (equivalent to ivec4.zxxxx).
        /// </summary>
        public ivec5 brrrr => new ivec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.zxxxy swizzling.
        /// </summary>
        public ivec5 zxxxy => new ivec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.brrrg swizzling (equivalent to ivec4.zxxxy).
        /// </summary>
        public ivec5 brrrg => new ivec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.zxxxz swizzling.
        /// </summary>
        public ivec5 zxxxz => new ivec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.brrrb swizzling (equivalent to ivec4.zxxxz).
        /// </summary>
        public ivec5 brrrb => new ivec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.zxxxw swizzling.
        /// </summary>
        public ivec5 zxxxw => new ivec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.brrra swizzling (equivalent to ivec4.zxxxw).
        /// </summary>
        public ivec5 brrra => new ivec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.zxxy swizzling.
        /// </summary>
        public ivec4 zxxy => new ivec4(z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.brrg swizzling (equivalent to ivec4.zxxy).
        /// </summary>
        public ivec4 brrg => new ivec4(z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.zxxyx swizzling.
        /// </summary>
        public ivec5 zxxyx => new ivec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.brrgr swizzling (equivalent to ivec4.zxxyx).
        /// </summary>
        public ivec5 brrgr => new ivec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.zxxyy swizzling.
        /// </summary>
        public ivec5 zxxyy => new ivec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.brrgg swizzling (equivalent to ivec4.zxxyy).
        /// </summary>
        public ivec5 brrgg => new ivec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.zxxyz swizzling.
        /// </summary>
        public ivec5 zxxyz => new ivec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.brrgb swizzling (equivalent to ivec4.zxxyz).
        /// </summary>
        public ivec5 brrgb => new ivec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.zxxyw swizzling.
        /// </summary>
        public ivec5 zxxyw => new ivec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.brrga swizzling (equivalent to ivec4.zxxyw).
        /// </summary>
        public ivec5 brrga => new ivec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.zxxz swizzling.
        /// </summary>
        public ivec4 zxxz => new ivec4(z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.brrb swizzling (equivalent to ivec4.zxxz).
        /// </summary>
        public ivec4 brrb => new ivec4(z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.zxxzx swizzling.
        /// </summary>
        public ivec5 zxxzx => new ivec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.brrbr swizzling (equivalent to ivec4.zxxzx).
        /// </summary>
        public ivec5 brrbr => new ivec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.zxxzy swizzling.
        /// </summary>
        public ivec5 zxxzy => new ivec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.brrbg swizzling (equivalent to ivec4.zxxzy).
        /// </summary>
        public ivec5 brrbg => new ivec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.zxxzz swizzling.
        /// </summary>
        public ivec5 zxxzz => new ivec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.brrbb swizzling (equivalent to ivec4.zxxzz).
        /// </summary>
        public ivec5 brrbb => new ivec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.zxxzw swizzling.
        /// </summary>
        public ivec5 zxxzw => new ivec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.brrba swizzling (equivalent to ivec4.zxxzw).
        /// </summary>
        public ivec5 brrba => new ivec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.zxxw swizzling.
        /// </summary>
        public ivec4 zxxw => new ivec4(z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.brra swizzling (equivalent to ivec4.zxxw).
        /// </summary>
        public ivec4 brra => new ivec4(z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.zxxwx swizzling.
        /// </summary>
        public ivec5 zxxwx => new ivec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.brrar swizzling (equivalent to ivec4.zxxwx).
        /// </summary>
        public ivec5 brrar => new ivec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.zxxwy swizzling.
        /// </summary>
        public ivec5 zxxwy => new ivec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.brrag swizzling (equivalent to ivec4.zxxwy).
        /// </summary>
        public ivec5 brrag => new ivec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.zxxwz swizzling.
        /// </summary>
        public ivec5 zxxwz => new ivec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.brrab swizzling (equivalent to ivec4.zxxwz).
        /// </summary>
        public ivec5 brrab => new ivec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.zxxww swizzling.
        /// </summary>
        public ivec5 zxxww => new ivec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.brraa swizzling (equivalent to ivec4.zxxww).
        /// </summary>
        public ivec5 brraa => new ivec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.zxy swizzling.
        /// </summary>
        public ivec3 zxy => new ivec3(z, x, y);
        
        /// <summary>
        /// Returns ivec4.brg swizzling (equivalent to ivec4.zxy).
        /// </summary>
        public ivec3 brg => new ivec3(z, x, y);
        
        /// <summary>
        /// Returns ivec4.zxyx swizzling.
        /// </summary>
        public ivec4 zxyx => new ivec4(z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.brgr swizzling (equivalent to ivec4.zxyx).
        /// </summary>
        public ivec4 brgr => new ivec4(z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.zxyxx swizzling.
        /// </summary>
        public ivec5 zxyxx => new ivec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.brgrr swizzling (equivalent to ivec4.zxyxx).
        /// </summary>
        public ivec5 brgrr => new ivec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.zxyxy swizzling.
        /// </summary>
        public ivec5 zxyxy => new ivec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.brgrg swizzling (equivalent to ivec4.zxyxy).
        /// </summary>
        public ivec5 brgrg => new ivec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.zxyxz swizzling.
        /// </summary>
        public ivec5 zxyxz => new ivec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.brgrb swizzling (equivalent to ivec4.zxyxz).
        /// </summary>
        public ivec5 brgrb => new ivec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.zxyxw swizzling.
        /// </summary>
        public ivec5 zxyxw => new ivec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.brgra swizzling (equivalent to ivec4.zxyxw).
        /// </summary>
        public ivec5 brgra => new ivec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.zxyy swizzling.
        /// </summary>
        public ivec4 zxyy => new ivec4(z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.brgg swizzling (equivalent to ivec4.zxyy).
        /// </summary>
        public ivec4 brgg => new ivec4(z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.zxyyx swizzling.
        /// </summary>
        public ivec5 zxyyx => new ivec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.brggr swizzling (equivalent to ivec4.zxyyx).
        /// </summary>
        public ivec5 brggr => new ivec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.zxyyy swizzling.
        /// </summary>
        public ivec5 zxyyy => new ivec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.brggg swizzling (equivalent to ivec4.zxyyy).
        /// </summary>
        public ivec5 brggg => new ivec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.zxyyz swizzling.
        /// </summary>
        public ivec5 zxyyz => new ivec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.brggb swizzling (equivalent to ivec4.zxyyz).
        /// </summary>
        public ivec5 brggb => new ivec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.zxyyw swizzling.
        /// </summary>
        public ivec5 zxyyw => new ivec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.brgga swizzling (equivalent to ivec4.zxyyw).
        /// </summary>
        public ivec5 brgga => new ivec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.zxyz swizzling.
        /// </summary>
        public ivec4 zxyz => new ivec4(z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.brgb swizzling (equivalent to ivec4.zxyz).
        /// </summary>
        public ivec4 brgb => new ivec4(z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.zxyzx swizzling.
        /// </summary>
        public ivec5 zxyzx => new ivec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.brgbr swizzling (equivalent to ivec4.zxyzx).
        /// </summary>
        public ivec5 brgbr => new ivec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.zxyzy swizzling.
        /// </summary>
        public ivec5 zxyzy => new ivec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.brgbg swizzling (equivalent to ivec4.zxyzy).
        /// </summary>
        public ivec5 brgbg => new ivec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.zxyzz swizzling.
        /// </summary>
        public ivec5 zxyzz => new ivec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.brgbb swizzling (equivalent to ivec4.zxyzz).
        /// </summary>
        public ivec5 brgbb => new ivec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.zxyzw swizzling.
        /// </summary>
        public ivec5 zxyzw => new ivec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.brgba swizzling (equivalent to ivec4.zxyzw).
        /// </summary>
        public ivec5 brgba => new ivec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.zxyw swizzling.
        /// </summary>
        public ivec4 zxyw => new ivec4(z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.brga swizzling (equivalent to ivec4.zxyw).
        /// </summary>
        public ivec4 brga => new ivec4(z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.zxywx swizzling.
        /// </summary>
        public ivec5 zxywx => new ivec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.brgar swizzling (equivalent to ivec4.zxywx).
        /// </summary>
        public ivec5 brgar => new ivec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.zxywy swizzling.
        /// </summary>
        public ivec5 zxywy => new ivec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.brgag swizzling (equivalent to ivec4.zxywy).
        /// </summary>
        public ivec5 brgag => new ivec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.zxywz swizzling.
        /// </summary>
        public ivec5 zxywz => new ivec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.brgab swizzling (equivalent to ivec4.zxywz).
        /// </summary>
        public ivec5 brgab => new ivec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.zxyww swizzling.
        /// </summary>
        public ivec5 zxyww => new ivec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.brgaa swizzling (equivalent to ivec4.zxyww).
        /// </summary>
        public ivec5 brgaa => new ivec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.zxz swizzling.
        /// </summary>
        public ivec3 zxz => new ivec3(z, x, z);
        
        /// <summary>
        /// Returns ivec4.brb swizzling (equivalent to ivec4.zxz).
        /// </summary>
        public ivec3 brb => new ivec3(z, x, z);
        
        /// <summary>
        /// Returns ivec4.zxzx swizzling.
        /// </summary>
        public ivec4 zxzx => new ivec4(z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.brbr swizzling (equivalent to ivec4.zxzx).
        /// </summary>
        public ivec4 brbr => new ivec4(z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.zxzxx swizzling.
        /// </summary>
        public ivec5 zxzxx => new ivec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.brbrr swizzling (equivalent to ivec4.zxzxx).
        /// </summary>
        public ivec5 brbrr => new ivec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.zxzxy swizzling.
        /// </summary>
        public ivec5 zxzxy => new ivec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.brbrg swizzling (equivalent to ivec4.zxzxy).
        /// </summary>
        public ivec5 brbrg => new ivec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.zxzxz swizzling.
        /// </summary>
        public ivec5 zxzxz => new ivec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.brbrb swizzling (equivalent to ivec4.zxzxz).
        /// </summary>
        public ivec5 brbrb => new ivec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.zxzxw swizzling.
        /// </summary>
        public ivec5 zxzxw => new ivec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.brbra swizzling (equivalent to ivec4.zxzxw).
        /// </summary>
        public ivec5 brbra => new ivec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.zxzy swizzling.
        /// </summary>
        public ivec4 zxzy => new ivec4(z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.brbg swizzling (equivalent to ivec4.zxzy).
        /// </summary>
        public ivec4 brbg => new ivec4(z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.zxzyx swizzling.
        /// </summary>
        public ivec5 zxzyx => new ivec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.brbgr swizzling (equivalent to ivec4.zxzyx).
        /// </summary>
        public ivec5 brbgr => new ivec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.zxzyy swizzling.
        /// </summary>
        public ivec5 zxzyy => new ivec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.brbgg swizzling (equivalent to ivec4.zxzyy).
        /// </summary>
        public ivec5 brbgg => new ivec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.zxzyz swizzling.
        /// </summary>
        public ivec5 zxzyz => new ivec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.brbgb swizzling (equivalent to ivec4.zxzyz).
        /// </summary>
        public ivec5 brbgb => new ivec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.zxzyw swizzling.
        /// </summary>
        public ivec5 zxzyw => new ivec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.brbga swizzling (equivalent to ivec4.zxzyw).
        /// </summary>
        public ivec5 brbga => new ivec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.zxzz swizzling.
        /// </summary>
        public ivec4 zxzz => new ivec4(z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.brbb swizzling (equivalent to ivec4.zxzz).
        /// </summary>
        public ivec4 brbb => new ivec4(z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.zxzzx swizzling.
        /// </summary>
        public ivec5 zxzzx => new ivec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.brbbr swizzling (equivalent to ivec4.zxzzx).
        /// </summary>
        public ivec5 brbbr => new ivec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.zxzzy swizzling.
        /// </summary>
        public ivec5 zxzzy => new ivec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.brbbg swizzling (equivalent to ivec4.zxzzy).
        /// </summary>
        public ivec5 brbbg => new ivec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.zxzzz swizzling.
        /// </summary>
        public ivec5 zxzzz => new ivec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.brbbb swizzling (equivalent to ivec4.zxzzz).
        /// </summary>
        public ivec5 brbbb => new ivec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.zxzzw swizzling.
        /// </summary>
        public ivec5 zxzzw => new ivec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.brbba swizzling (equivalent to ivec4.zxzzw).
        /// </summary>
        public ivec5 brbba => new ivec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.zxzw swizzling.
        /// </summary>
        public ivec4 zxzw => new ivec4(z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.brba swizzling (equivalent to ivec4.zxzw).
        /// </summary>
        public ivec4 brba => new ivec4(z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.zxzwx swizzling.
        /// </summary>
        public ivec5 zxzwx => new ivec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.brbar swizzling (equivalent to ivec4.zxzwx).
        /// </summary>
        public ivec5 brbar => new ivec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.zxzwy swizzling.
        /// </summary>
        public ivec5 zxzwy => new ivec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.brbag swizzling (equivalent to ivec4.zxzwy).
        /// </summary>
        public ivec5 brbag => new ivec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.zxzwz swizzling.
        /// </summary>
        public ivec5 zxzwz => new ivec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.brbab swizzling (equivalent to ivec4.zxzwz).
        /// </summary>
        public ivec5 brbab => new ivec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.zxzww swizzling.
        /// </summary>
        public ivec5 zxzww => new ivec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.brbaa swizzling (equivalent to ivec4.zxzww).
        /// </summary>
        public ivec5 brbaa => new ivec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.zxw swizzling.
        /// </summary>
        public ivec3 zxw => new ivec3(z, x, w);
        
        /// <summary>
        /// Returns ivec4.bra swizzling (equivalent to ivec4.zxw).
        /// </summary>
        public ivec3 bra => new ivec3(z, x, w);
        
        /// <summary>
        /// Returns ivec4.zxwx swizzling.
        /// </summary>
        public ivec4 zxwx => new ivec4(z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.brar swizzling (equivalent to ivec4.zxwx).
        /// </summary>
        public ivec4 brar => new ivec4(z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.zxwxx swizzling.
        /// </summary>
        public ivec5 zxwxx => new ivec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.brarr swizzling (equivalent to ivec4.zxwxx).
        /// </summary>
        public ivec5 brarr => new ivec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.zxwxy swizzling.
        /// </summary>
        public ivec5 zxwxy => new ivec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.brarg swizzling (equivalent to ivec4.zxwxy).
        /// </summary>
        public ivec5 brarg => new ivec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.zxwxz swizzling.
        /// </summary>
        public ivec5 zxwxz => new ivec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.brarb swizzling (equivalent to ivec4.zxwxz).
        /// </summary>
        public ivec5 brarb => new ivec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.zxwxw swizzling.
        /// </summary>
        public ivec5 zxwxw => new ivec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.brara swizzling (equivalent to ivec4.zxwxw).
        /// </summary>
        public ivec5 brara => new ivec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.zxwy swizzling.
        /// </summary>
        public ivec4 zxwy => new ivec4(z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.brag swizzling (equivalent to ivec4.zxwy).
        /// </summary>
        public ivec4 brag => new ivec4(z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.zxwyx swizzling.
        /// </summary>
        public ivec5 zxwyx => new ivec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.bragr swizzling (equivalent to ivec4.zxwyx).
        /// </summary>
        public ivec5 bragr => new ivec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.zxwyy swizzling.
        /// </summary>
        public ivec5 zxwyy => new ivec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.bragg swizzling (equivalent to ivec4.zxwyy).
        /// </summary>
        public ivec5 bragg => new ivec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.zxwyz swizzling.
        /// </summary>
        public ivec5 zxwyz => new ivec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.bragb swizzling (equivalent to ivec4.zxwyz).
        /// </summary>
        public ivec5 bragb => new ivec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.zxwyw swizzling.
        /// </summary>
        public ivec5 zxwyw => new ivec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.braga swizzling (equivalent to ivec4.zxwyw).
        /// </summary>
        public ivec5 braga => new ivec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.zxwz swizzling.
        /// </summary>
        public ivec4 zxwz => new ivec4(z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.brab swizzling (equivalent to ivec4.zxwz).
        /// </summary>
        public ivec4 brab => new ivec4(z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.zxwzx swizzling.
        /// </summary>
        public ivec5 zxwzx => new ivec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.brabr swizzling (equivalent to ivec4.zxwzx).
        /// </summary>
        public ivec5 brabr => new ivec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.zxwzy swizzling.
        /// </summary>
        public ivec5 zxwzy => new ivec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.brabg swizzling (equivalent to ivec4.zxwzy).
        /// </summary>
        public ivec5 brabg => new ivec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.zxwzz swizzling.
        /// </summary>
        public ivec5 zxwzz => new ivec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.brabb swizzling (equivalent to ivec4.zxwzz).
        /// </summary>
        public ivec5 brabb => new ivec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.zxwzw swizzling.
        /// </summary>
        public ivec5 zxwzw => new ivec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.braba swizzling (equivalent to ivec4.zxwzw).
        /// </summary>
        public ivec5 braba => new ivec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.zxww swizzling.
        /// </summary>
        public ivec4 zxww => new ivec4(z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.braa swizzling (equivalent to ivec4.zxww).
        /// </summary>
        public ivec4 braa => new ivec4(z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.zxwwx swizzling.
        /// </summary>
        public ivec5 zxwwx => new ivec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.braar swizzling (equivalent to ivec4.zxwwx).
        /// </summary>
        public ivec5 braar => new ivec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.zxwwy swizzling.
        /// </summary>
        public ivec5 zxwwy => new ivec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.braag swizzling (equivalent to ivec4.zxwwy).
        /// </summary>
        public ivec5 braag => new ivec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.zxwwz swizzling.
        /// </summary>
        public ivec5 zxwwz => new ivec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.braab swizzling (equivalent to ivec4.zxwwz).
        /// </summary>
        public ivec5 braab => new ivec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.zxwww swizzling.
        /// </summary>
        public ivec5 zxwww => new ivec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.braaa swizzling (equivalent to ivec4.zxwww).
        /// </summary>
        public ivec5 braaa => new ivec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.zy swizzling.
        /// </summary>
        public ivec2 zy => new ivec2(z, y);
        
        /// <summary>
        /// Returns ivec4.bg swizzling (equivalent to ivec4.zy).
        /// </summary>
        public ivec2 bg => new ivec2(z, y);
        
        /// <summary>
        /// Returns ivec4.zyx swizzling.
        /// </summary>
        public ivec3 zyx => new ivec3(z, y, x);
        
        /// <summary>
        /// Returns ivec4.bgr swizzling (equivalent to ivec4.zyx).
        /// </summary>
        public ivec3 bgr => new ivec3(z, y, x);
        
        /// <summary>
        /// Returns ivec4.zyxx swizzling.
        /// </summary>
        public ivec4 zyxx => new ivec4(z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.bgrr swizzling (equivalent to ivec4.zyxx).
        /// </summary>
        public ivec4 bgrr => new ivec4(z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.zyxxx swizzling.
        /// </summary>
        public ivec5 zyxxx => new ivec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.bgrrr swizzling (equivalent to ivec4.zyxxx).
        /// </summary>
        public ivec5 bgrrr => new ivec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.zyxxy swizzling.
        /// </summary>
        public ivec5 zyxxy => new ivec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.bgrrg swizzling (equivalent to ivec4.zyxxy).
        /// </summary>
        public ivec5 bgrrg => new ivec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.zyxxz swizzling.
        /// </summary>
        public ivec5 zyxxz => new ivec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.bgrrb swizzling (equivalent to ivec4.zyxxz).
        /// </summary>
        public ivec5 bgrrb => new ivec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.zyxxw swizzling.
        /// </summary>
        public ivec5 zyxxw => new ivec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.bgrra swizzling (equivalent to ivec4.zyxxw).
        /// </summary>
        public ivec5 bgrra => new ivec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.zyxy swizzling.
        /// </summary>
        public ivec4 zyxy => new ivec4(z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.bgrg swizzling (equivalent to ivec4.zyxy).
        /// </summary>
        public ivec4 bgrg => new ivec4(z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.zyxyx swizzling.
        /// </summary>
        public ivec5 zyxyx => new ivec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.bgrgr swizzling (equivalent to ivec4.zyxyx).
        /// </summary>
        public ivec5 bgrgr => new ivec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.zyxyy swizzling.
        /// </summary>
        public ivec5 zyxyy => new ivec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.bgrgg swizzling (equivalent to ivec4.zyxyy).
        /// </summary>
        public ivec5 bgrgg => new ivec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.zyxyz swizzling.
        /// </summary>
        public ivec5 zyxyz => new ivec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.bgrgb swizzling (equivalent to ivec4.zyxyz).
        /// </summary>
        public ivec5 bgrgb => new ivec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.zyxyw swizzling.
        /// </summary>
        public ivec5 zyxyw => new ivec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.bgrga swizzling (equivalent to ivec4.zyxyw).
        /// </summary>
        public ivec5 bgrga => new ivec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.zyxz swizzling.
        /// </summary>
        public ivec4 zyxz => new ivec4(z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.bgrb swizzling (equivalent to ivec4.zyxz).
        /// </summary>
        public ivec4 bgrb => new ivec4(z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.zyxzx swizzling.
        /// </summary>
        public ivec5 zyxzx => new ivec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.bgrbr swizzling (equivalent to ivec4.zyxzx).
        /// </summary>
        public ivec5 bgrbr => new ivec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.zyxzy swizzling.
        /// </summary>
        public ivec5 zyxzy => new ivec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.bgrbg swizzling (equivalent to ivec4.zyxzy).
        /// </summary>
        public ivec5 bgrbg => new ivec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.zyxzz swizzling.
        /// </summary>
        public ivec5 zyxzz => new ivec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.bgrbb swizzling (equivalent to ivec4.zyxzz).
        /// </summary>
        public ivec5 bgrbb => new ivec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.zyxzw swizzling.
        /// </summary>
        public ivec5 zyxzw => new ivec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.bgrba swizzling (equivalent to ivec4.zyxzw).
        /// </summary>
        public ivec5 bgrba => new ivec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.zyxw swizzling.
        /// </summary>
        public ivec4 zyxw => new ivec4(z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.bgra swizzling (equivalent to ivec4.zyxw).
        /// </summary>
        public ivec4 bgra => new ivec4(z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.zyxwx swizzling.
        /// </summary>
        public ivec5 zyxwx => new ivec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.bgrar swizzling (equivalent to ivec4.zyxwx).
        /// </summary>
        public ivec5 bgrar => new ivec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.zyxwy swizzling.
        /// </summary>
        public ivec5 zyxwy => new ivec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.bgrag swizzling (equivalent to ivec4.zyxwy).
        /// </summary>
        public ivec5 bgrag => new ivec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.zyxwz swizzling.
        /// </summary>
        public ivec5 zyxwz => new ivec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.bgrab swizzling (equivalent to ivec4.zyxwz).
        /// </summary>
        public ivec5 bgrab => new ivec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.zyxww swizzling.
        /// </summary>
        public ivec5 zyxww => new ivec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.bgraa swizzling (equivalent to ivec4.zyxww).
        /// </summary>
        public ivec5 bgraa => new ivec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.zyy swizzling.
        /// </summary>
        public ivec3 zyy => new ivec3(z, y, y);
        
        /// <summary>
        /// Returns ivec4.bgg swizzling (equivalent to ivec4.zyy).
        /// </summary>
        public ivec3 bgg => new ivec3(z, y, y);
        
        /// <summary>
        /// Returns ivec4.zyyx swizzling.
        /// </summary>
        public ivec4 zyyx => new ivec4(z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.bggr swizzling (equivalent to ivec4.zyyx).
        /// </summary>
        public ivec4 bggr => new ivec4(z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.zyyxx swizzling.
        /// </summary>
        public ivec5 zyyxx => new ivec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.bggrr swizzling (equivalent to ivec4.zyyxx).
        /// </summary>
        public ivec5 bggrr => new ivec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.zyyxy swizzling.
        /// </summary>
        public ivec5 zyyxy => new ivec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.bggrg swizzling (equivalent to ivec4.zyyxy).
        /// </summary>
        public ivec5 bggrg => new ivec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.zyyxz swizzling.
        /// </summary>
        public ivec5 zyyxz => new ivec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.bggrb swizzling (equivalent to ivec4.zyyxz).
        /// </summary>
        public ivec5 bggrb => new ivec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.zyyxw swizzling.
        /// </summary>
        public ivec5 zyyxw => new ivec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.bggra swizzling (equivalent to ivec4.zyyxw).
        /// </summary>
        public ivec5 bggra => new ivec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.zyyy swizzling.
        /// </summary>
        public ivec4 zyyy => new ivec4(z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.bggg swizzling (equivalent to ivec4.zyyy).
        /// </summary>
        public ivec4 bggg => new ivec4(z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.zyyyx swizzling.
        /// </summary>
        public ivec5 zyyyx => new ivec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.bgggr swizzling (equivalent to ivec4.zyyyx).
        /// </summary>
        public ivec5 bgggr => new ivec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.zyyyy swizzling.
        /// </summary>
        public ivec5 zyyyy => new ivec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.bgggg swizzling (equivalent to ivec4.zyyyy).
        /// </summary>
        public ivec5 bgggg => new ivec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.zyyyz swizzling.
        /// </summary>
        public ivec5 zyyyz => new ivec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.bgggb swizzling (equivalent to ivec4.zyyyz).
        /// </summary>
        public ivec5 bgggb => new ivec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.zyyyw swizzling.
        /// </summary>
        public ivec5 zyyyw => new ivec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.bggga swizzling (equivalent to ivec4.zyyyw).
        /// </summary>
        public ivec5 bggga => new ivec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.zyyz swizzling.
        /// </summary>
        public ivec4 zyyz => new ivec4(z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.bggb swizzling (equivalent to ivec4.zyyz).
        /// </summary>
        public ivec4 bggb => new ivec4(z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.zyyzx swizzling.
        /// </summary>
        public ivec5 zyyzx => new ivec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.bggbr swizzling (equivalent to ivec4.zyyzx).
        /// </summary>
        public ivec5 bggbr => new ivec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.zyyzy swizzling.
        /// </summary>
        public ivec5 zyyzy => new ivec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.bggbg swizzling (equivalent to ivec4.zyyzy).
        /// </summary>
        public ivec5 bggbg => new ivec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.zyyzz swizzling.
        /// </summary>
        public ivec5 zyyzz => new ivec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.bggbb swizzling (equivalent to ivec4.zyyzz).
        /// </summary>
        public ivec5 bggbb => new ivec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.zyyzw swizzling.
        /// </summary>
        public ivec5 zyyzw => new ivec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.bggba swizzling (equivalent to ivec4.zyyzw).
        /// </summary>
        public ivec5 bggba => new ivec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.zyyw swizzling.
        /// </summary>
        public ivec4 zyyw => new ivec4(z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.bgga swizzling (equivalent to ivec4.zyyw).
        /// </summary>
        public ivec4 bgga => new ivec4(z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.zyywx swizzling.
        /// </summary>
        public ivec5 zyywx => new ivec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.bggar swizzling (equivalent to ivec4.zyywx).
        /// </summary>
        public ivec5 bggar => new ivec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.zyywy swizzling.
        /// </summary>
        public ivec5 zyywy => new ivec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.bggag swizzling (equivalent to ivec4.zyywy).
        /// </summary>
        public ivec5 bggag => new ivec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.zyywz swizzling.
        /// </summary>
        public ivec5 zyywz => new ivec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.bggab swizzling (equivalent to ivec4.zyywz).
        /// </summary>
        public ivec5 bggab => new ivec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.zyyww swizzling.
        /// </summary>
        public ivec5 zyyww => new ivec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.bggaa swizzling (equivalent to ivec4.zyyww).
        /// </summary>
        public ivec5 bggaa => new ivec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.zyz swizzling.
        /// </summary>
        public ivec3 zyz => new ivec3(z, y, z);
        
        /// <summary>
        /// Returns ivec4.bgb swizzling (equivalent to ivec4.zyz).
        /// </summary>
        public ivec3 bgb => new ivec3(z, y, z);
        
        /// <summary>
        /// Returns ivec4.zyzx swizzling.
        /// </summary>
        public ivec4 zyzx => new ivec4(z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.bgbr swizzling (equivalent to ivec4.zyzx).
        /// </summary>
        public ivec4 bgbr => new ivec4(z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.zyzxx swizzling.
        /// </summary>
        public ivec5 zyzxx => new ivec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.bgbrr swizzling (equivalent to ivec4.zyzxx).
        /// </summary>
        public ivec5 bgbrr => new ivec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.zyzxy swizzling.
        /// </summary>
        public ivec5 zyzxy => new ivec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.bgbrg swizzling (equivalent to ivec4.zyzxy).
        /// </summary>
        public ivec5 bgbrg => new ivec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.zyzxz swizzling.
        /// </summary>
        public ivec5 zyzxz => new ivec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.bgbrb swizzling (equivalent to ivec4.zyzxz).
        /// </summary>
        public ivec5 bgbrb => new ivec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.zyzxw swizzling.
        /// </summary>
        public ivec5 zyzxw => new ivec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.bgbra swizzling (equivalent to ivec4.zyzxw).
        /// </summary>
        public ivec5 bgbra => new ivec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.zyzy swizzling.
        /// </summary>
        public ivec4 zyzy => new ivec4(z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.bgbg swizzling (equivalent to ivec4.zyzy).
        /// </summary>
        public ivec4 bgbg => new ivec4(z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.zyzyx swizzling.
        /// </summary>
        public ivec5 zyzyx => new ivec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.bgbgr swizzling (equivalent to ivec4.zyzyx).
        /// </summary>
        public ivec5 bgbgr => new ivec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.zyzyy swizzling.
        /// </summary>
        public ivec5 zyzyy => new ivec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.bgbgg swizzling (equivalent to ivec4.zyzyy).
        /// </summary>
        public ivec5 bgbgg => new ivec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.zyzyz swizzling.
        /// </summary>
        public ivec5 zyzyz => new ivec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.bgbgb swizzling (equivalent to ivec4.zyzyz).
        /// </summary>
        public ivec5 bgbgb => new ivec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.zyzyw swizzling.
        /// </summary>
        public ivec5 zyzyw => new ivec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.bgbga swizzling (equivalent to ivec4.zyzyw).
        /// </summary>
        public ivec5 bgbga => new ivec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.zyzz swizzling.
        /// </summary>
        public ivec4 zyzz => new ivec4(z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.bgbb swizzling (equivalent to ivec4.zyzz).
        /// </summary>
        public ivec4 bgbb => new ivec4(z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.zyzzx swizzling.
        /// </summary>
        public ivec5 zyzzx => new ivec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.bgbbr swizzling (equivalent to ivec4.zyzzx).
        /// </summary>
        public ivec5 bgbbr => new ivec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.zyzzy swizzling.
        /// </summary>
        public ivec5 zyzzy => new ivec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.bgbbg swizzling (equivalent to ivec4.zyzzy).
        /// </summary>
        public ivec5 bgbbg => new ivec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.zyzzz swizzling.
        /// </summary>
        public ivec5 zyzzz => new ivec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.bgbbb swizzling (equivalent to ivec4.zyzzz).
        /// </summary>
        public ivec5 bgbbb => new ivec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.zyzzw swizzling.
        /// </summary>
        public ivec5 zyzzw => new ivec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.bgbba swizzling (equivalent to ivec4.zyzzw).
        /// </summary>
        public ivec5 bgbba => new ivec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.zyzw swizzling.
        /// </summary>
        public ivec4 zyzw => new ivec4(z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.bgba swizzling (equivalent to ivec4.zyzw).
        /// </summary>
        public ivec4 bgba => new ivec4(z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.zyzwx swizzling.
        /// </summary>
        public ivec5 zyzwx => new ivec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.bgbar swizzling (equivalent to ivec4.zyzwx).
        /// </summary>
        public ivec5 bgbar => new ivec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.zyzwy swizzling.
        /// </summary>
        public ivec5 zyzwy => new ivec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.bgbag swizzling (equivalent to ivec4.zyzwy).
        /// </summary>
        public ivec5 bgbag => new ivec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.zyzwz swizzling.
        /// </summary>
        public ivec5 zyzwz => new ivec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.bgbab swizzling (equivalent to ivec4.zyzwz).
        /// </summary>
        public ivec5 bgbab => new ivec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.zyzww swizzling.
        /// </summary>
        public ivec5 zyzww => new ivec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.bgbaa swizzling (equivalent to ivec4.zyzww).
        /// </summary>
        public ivec5 bgbaa => new ivec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.zyw swizzling.
        /// </summary>
        public ivec3 zyw => new ivec3(z, y, w);
        
        /// <summary>
        /// Returns ivec4.bga swizzling (equivalent to ivec4.zyw).
        /// </summary>
        public ivec3 bga => new ivec3(z, y, w);
        
        /// <summary>
        /// Returns ivec4.zywx swizzling.
        /// </summary>
        public ivec4 zywx => new ivec4(z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.bgar swizzling (equivalent to ivec4.zywx).
        /// </summary>
        public ivec4 bgar => new ivec4(z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.zywxx swizzling.
        /// </summary>
        public ivec5 zywxx => new ivec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.bgarr swizzling (equivalent to ivec4.zywxx).
        /// </summary>
        public ivec5 bgarr => new ivec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.zywxy swizzling.
        /// </summary>
        public ivec5 zywxy => new ivec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.bgarg swizzling (equivalent to ivec4.zywxy).
        /// </summary>
        public ivec5 bgarg => new ivec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.zywxz swizzling.
        /// </summary>
        public ivec5 zywxz => new ivec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.bgarb swizzling (equivalent to ivec4.zywxz).
        /// </summary>
        public ivec5 bgarb => new ivec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.zywxw swizzling.
        /// </summary>
        public ivec5 zywxw => new ivec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.bgara swizzling (equivalent to ivec4.zywxw).
        /// </summary>
        public ivec5 bgara => new ivec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.zywy swizzling.
        /// </summary>
        public ivec4 zywy => new ivec4(z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.bgag swizzling (equivalent to ivec4.zywy).
        /// </summary>
        public ivec4 bgag => new ivec4(z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.zywyx swizzling.
        /// </summary>
        public ivec5 zywyx => new ivec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.bgagr swizzling (equivalent to ivec4.zywyx).
        /// </summary>
        public ivec5 bgagr => new ivec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.zywyy swizzling.
        /// </summary>
        public ivec5 zywyy => new ivec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.bgagg swizzling (equivalent to ivec4.zywyy).
        /// </summary>
        public ivec5 bgagg => new ivec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.zywyz swizzling.
        /// </summary>
        public ivec5 zywyz => new ivec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.bgagb swizzling (equivalent to ivec4.zywyz).
        /// </summary>
        public ivec5 bgagb => new ivec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.zywyw swizzling.
        /// </summary>
        public ivec5 zywyw => new ivec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.bgaga swizzling (equivalent to ivec4.zywyw).
        /// </summary>
        public ivec5 bgaga => new ivec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.zywz swizzling.
        /// </summary>
        public ivec4 zywz => new ivec4(z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.bgab swizzling (equivalent to ivec4.zywz).
        /// </summary>
        public ivec4 bgab => new ivec4(z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.zywzx swizzling.
        /// </summary>
        public ivec5 zywzx => new ivec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.bgabr swizzling (equivalent to ivec4.zywzx).
        /// </summary>
        public ivec5 bgabr => new ivec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.zywzy swizzling.
        /// </summary>
        public ivec5 zywzy => new ivec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.bgabg swizzling (equivalent to ivec4.zywzy).
        /// </summary>
        public ivec5 bgabg => new ivec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.zywzz swizzling.
        /// </summary>
        public ivec5 zywzz => new ivec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.bgabb swizzling (equivalent to ivec4.zywzz).
        /// </summary>
        public ivec5 bgabb => new ivec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.zywzw swizzling.
        /// </summary>
        public ivec5 zywzw => new ivec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.bgaba swizzling (equivalent to ivec4.zywzw).
        /// </summary>
        public ivec5 bgaba => new ivec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.zyww swizzling.
        /// </summary>
        public ivec4 zyww => new ivec4(z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.bgaa swizzling (equivalent to ivec4.zyww).
        /// </summary>
        public ivec4 bgaa => new ivec4(z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.zywwx swizzling.
        /// </summary>
        public ivec5 zywwx => new ivec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.bgaar swizzling (equivalent to ivec4.zywwx).
        /// </summary>
        public ivec5 bgaar => new ivec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.zywwy swizzling.
        /// </summary>
        public ivec5 zywwy => new ivec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.bgaag swizzling (equivalent to ivec4.zywwy).
        /// </summary>
        public ivec5 bgaag => new ivec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.zywwz swizzling.
        /// </summary>
        public ivec5 zywwz => new ivec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.bgaab swizzling (equivalent to ivec4.zywwz).
        /// </summary>
        public ivec5 bgaab => new ivec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.zywww swizzling.
        /// </summary>
        public ivec5 zywww => new ivec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.bgaaa swizzling (equivalent to ivec4.zywww).
        /// </summary>
        public ivec5 bgaaa => new ivec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.zz swizzling.
        /// </summary>
        public ivec2 zz => new ivec2(z, z);
        
        /// <summary>
        /// Returns ivec4.bb swizzling (equivalent to ivec4.zz).
        /// </summary>
        public ivec2 bb => new ivec2(z, z);
        
        /// <summary>
        /// Returns ivec4.zzx swizzling.
        /// </summary>
        public ivec3 zzx => new ivec3(z, z, x);
        
        /// <summary>
        /// Returns ivec4.bbr swizzling (equivalent to ivec4.zzx).
        /// </summary>
        public ivec3 bbr => new ivec3(z, z, x);
        
        /// <summary>
        /// Returns ivec4.zzxx swizzling.
        /// </summary>
        public ivec4 zzxx => new ivec4(z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.bbrr swizzling (equivalent to ivec4.zzxx).
        /// </summary>
        public ivec4 bbrr => new ivec4(z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.zzxxx swizzling.
        /// </summary>
        public ivec5 zzxxx => new ivec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.bbrrr swizzling (equivalent to ivec4.zzxxx).
        /// </summary>
        public ivec5 bbrrr => new ivec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.zzxxy swizzling.
        /// </summary>
        public ivec5 zzxxy => new ivec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.bbrrg swizzling (equivalent to ivec4.zzxxy).
        /// </summary>
        public ivec5 bbrrg => new ivec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.zzxxz swizzling.
        /// </summary>
        public ivec5 zzxxz => new ivec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.bbrrb swizzling (equivalent to ivec4.zzxxz).
        /// </summary>
        public ivec5 bbrrb => new ivec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.zzxxw swizzling.
        /// </summary>
        public ivec5 zzxxw => new ivec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.bbrra swizzling (equivalent to ivec4.zzxxw).
        /// </summary>
        public ivec5 bbrra => new ivec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.zzxy swizzling.
        /// </summary>
        public ivec4 zzxy => new ivec4(z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.bbrg swizzling (equivalent to ivec4.zzxy).
        /// </summary>
        public ivec4 bbrg => new ivec4(z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.zzxyx swizzling.
        /// </summary>
        public ivec5 zzxyx => new ivec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.bbrgr swizzling (equivalent to ivec4.zzxyx).
        /// </summary>
        public ivec5 bbrgr => new ivec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.zzxyy swizzling.
        /// </summary>
        public ivec5 zzxyy => new ivec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.bbrgg swizzling (equivalent to ivec4.zzxyy).
        /// </summary>
        public ivec5 bbrgg => new ivec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.zzxyz swizzling.
        /// </summary>
        public ivec5 zzxyz => new ivec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.bbrgb swizzling (equivalent to ivec4.zzxyz).
        /// </summary>
        public ivec5 bbrgb => new ivec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.zzxyw swizzling.
        /// </summary>
        public ivec5 zzxyw => new ivec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.bbrga swizzling (equivalent to ivec4.zzxyw).
        /// </summary>
        public ivec5 bbrga => new ivec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.zzxz swizzling.
        /// </summary>
        public ivec4 zzxz => new ivec4(z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.bbrb swizzling (equivalent to ivec4.zzxz).
        /// </summary>
        public ivec4 bbrb => new ivec4(z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.zzxzx swizzling.
        /// </summary>
        public ivec5 zzxzx => new ivec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.bbrbr swizzling (equivalent to ivec4.zzxzx).
        /// </summary>
        public ivec5 bbrbr => new ivec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.zzxzy swizzling.
        /// </summary>
        public ivec5 zzxzy => new ivec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.bbrbg swizzling (equivalent to ivec4.zzxzy).
        /// </summary>
        public ivec5 bbrbg => new ivec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.zzxzz swizzling.
        /// </summary>
        public ivec5 zzxzz => new ivec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.bbrbb swizzling (equivalent to ivec4.zzxzz).
        /// </summary>
        public ivec5 bbrbb => new ivec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.zzxzw swizzling.
        /// </summary>
        public ivec5 zzxzw => new ivec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.bbrba swizzling (equivalent to ivec4.zzxzw).
        /// </summary>
        public ivec5 bbrba => new ivec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.zzxw swizzling.
        /// </summary>
        public ivec4 zzxw => new ivec4(z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.bbra swizzling (equivalent to ivec4.zzxw).
        /// </summary>
        public ivec4 bbra => new ivec4(z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.zzxwx swizzling.
        /// </summary>
        public ivec5 zzxwx => new ivec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.bbrar swizzling (equivalent to ivec4.zzxwx).
        /// </summary>
        public ivec5 bbrar => new ivec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.zzxwy swizzling.
        /// </summary>
        public ivec5 zzxwy => new ivec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.bbrag swizzling (equivalent to ivec4.zzxwy).
        /// </summary>
        public ivec5 bbrag => new ivec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.zzxwz swizzling.
        /// </summary>
        public ivec5 zzxwz => new ivec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.bbrab swizzling (equivalent to ivec4.zzxwz).
        /// </summary>
        public ivec5 bbrab => new ivec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.zzxww swizzling.
        /// </summary>
        public ivec5 zzxww => new ivec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.bbraa swizzling (equivalent to ivec4.zzxww).
        /// </summary>
        public ivec5 bbraa => new ivec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.zzy swizzling.
        /// </summary>
        public ivec3 zzy => new ivec3(z, z, y);
        
        /// <summary>
        /// Returns ivec4.bbg swizzling (equivalent to ivec4.zzy).
        /// </summary>
        public ivec3 bbg => new ivec3(z, z, y);
        
        /// <summary>
        /// Returns ivec4.zzyx swizzling.
        /// </summary>
        public ivec4 zzyx => new ivec4(z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.bbgr swizzling (equivalent to ivec4.zzyx).
        /// </summary>
        public ivec4 bbgr => new ivec4(z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.zzyxx swizzling.
        /// </summary>
        public ivec5 zzyxx => new ivec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.bbgrr swizzling (equivalent to ivec4.zzyxx).
        /// </summary>
        public ivec5 bbgrr => new ivec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.zzyxy swizzling.
        /// </summary>
        public ivec5 zzyxy => new ivec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.bbgrg swizzling (equivalent to ivec4.zzyxy).
        /// </summary>
        public ivec5 bbgrg => new ivec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.zzyxz swizzling.
        /// </summary>
        public ivec5 zzyxz => new ivec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.bbgrb swizzling (equivalent to ivec4.zzyxz).
        /// </summary>
        public ivec5 bbgrb => new ivec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.zzyxw swizzling.
        /// </summary>
        public ivec5 zzyxw => new ivec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.bbgra swizzling (equivalent to ivec4.zzyxw).
        /// </summary>
        public ivec5 bbgra => new ivec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.zzyy swizzling.
        /// </summary>
        public ivec4 zzyy => new ivec4(z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.bbgg swizzling (equivalent to ivec4.zzyy).
        /// </summary>
        public ivec4 bbgg => new ivec4(z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.zzyyx swizzling.
        /// </summary>
        public ivec5 zzyyx => new ivec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.bbggr swizzling (equivalent to ivec4.zzyyx).
        /// </summary>
        public ivec5 bbggr => new ivec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.zzyyy swizzling.
        /// </summary>
        public ivec5 zzyyy => new ivec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.bbggg swizzling (equivalent to ivec4.zzyyy).
        /// </summary>
        public ivec5 bbggg => new ivec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.zzyyz swizzling.
        /// </summary>
        public ivec5 zzyyz => new ivec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.bbggb swizzling (equivalent to ivec4.zzyyz).
        /// </summary>
        public ivec5 bbggb => new ivec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.zzyyw swizzling.
        /// </summary>
        public ivec5 zzyyw => new ivec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.bbgga swizzling (equivalent to ivec4.zzyyw).
        /// </summary>
        public ivec5 bbgga => new ivec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.zzyz swizzling.
        /// </summary>
        public ivec4 zzyz => new ivec4(z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.bbgb swizzling (equivalent to ivec4.zzyz).
        /// </summary>
        public ivec4 bbgb => new ivec4(z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.zzyzx swizzling.
        /// </summary>
        public ivec5 zzyzx => new ivec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.bbgbr swizzling (equivalent to ivec4.zzyzx).
        /// </summary>
        public ivec5 bbgbr => new ivec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.zzyzy swizzling.
        /// </summary>
        public ivec5 zzyzy => new ivec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.bbgbg swizzling (equivalent to ivec4.zzyzy).
        /// </summary>
        public ivec5 bbgbg => new ivec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.zzyzz swizzling.
        /// </summary>
        public ivec5 zzyzz => new ivec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.bbgbb swizzling (equivalent to ivec4.zzyzz).
        /// </summary>
        public ivec5 bbgbb => new ivec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.zzyzw swizzling.
        /// </summary>
        public ivec5 zzyzw => new ivec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.bbgba swizzling (equivalent to ivec4.zzyzw).
        /// </summary>
        public ivec5 bbgba => new ivec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.zzyw swizzling.
        /// </summary>
        public ivec4 zzyw => new ivec4(z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.bbga swizzling (equivalent to ivec4.zzyw).
        /// </summary>
        public ivec4 bbga => new ivec4(z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.zzywx swizzling.
        /// </summary>
        public ivec5 zzywx => new ivec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.bbgar swizzling (equivalent to ivec4.zzywx).
        /// </summary>
        public ivec5 bbgar => new ivec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.zzywy swizzling.
        /// </summary>
        public ivec5 zzywy => new ivec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.bbgag swizzling (equivalent to ivec4.zzywy).
        /// </summary>
        public ivec5 bbgag => new ivec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.zzywz swizzling.
        /// </summary>
        public ivec5 zzywz => new ivec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.bbgab swizzling (equivalent to ivec4.zzywz).
        /// </summary>
        public ivec5 bbgab => new ivec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.zzyww swizzling.
        /// </summary>
        public ivec5 zzyww => new ivec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.bbgaa swizzling (equivalent to ivec4.zzyww).
        /// </summary>
        public ivec5 bbgaa => new ivec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.zzz swizzling.
        /// </summary>
        public ivec3 zzz => new ivec3(z, z, z);
        
        /// <summary>
        /// Returns ivec4.bbb swizzling (equivalent to ivec4.zzz).
        /// </summary>
        public ivec3 bbb => new ivec3(z, z, z);
        
        /// <summary>
        /// Returns ivec4.zzzx swizzling.
        /// </summary>
        public ivec4 zzzx => new ivec4(z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.bbbr swizzling (equivalent to ivec4.zzzx).
        /// </summary>
        public ivec4 bbbr => new ivec4(z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.zzzxx swizzling.
        /// </summary>
        public ivec5 zzzxx => new ivec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.bbbrr swizzling (equivalent to ivec4.zzzxx).
        /// </summary>
        public ivec5 bbbrr => new ivec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.zzzxy swizzling.
        /// </summary>
        public ivec5 zzzxy => new ivec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.bbbrg swizzling (equivalent to ivec4.zzzxy).
        /// </summary>
        public ivec5 bbbrg => new ivec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.zzzxz swizzling.
        /// </summary>
        public ivec5 zzzxz => new ivec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.bbbrb swizzling (equivalent to ivec4.zzzxz).
        /// </summary>
        public ivec5 bbbrb => new ivec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.zzzxw swizzling.
        /// </summary>
        public ivec5 zzzxw => new ivec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.bbbra swizzling (equivalent to ivec4.zzzxw).
        /// </summary>
        public ivec5 bbbra => new ivec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.zzzy swizzling.
        /// </summary>
        public ivec4 zzzy => new ivec4(z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.bbbg swizzling (equivalent to ivec4.zzzy).
        /// </summary>
        public ivec4 bbbg => new ivec4(z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.zzzyx swizzling.
        /// </summary>
        public ivec5 zzzyx => new ivec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.bbbgr swizzling (equivalent to ivec4.zzzyx).
        /// </summary>
        public ivec5 bbbgr => new ivec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.zzzyy swizzling.
        /// </summary>
        public ivec5 zzzyy => new ivec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.bbbgg swizzling (equivalent to ivec4.zzzyy).
        /// </summary>
        public ivec5 bbbgg => new ivec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.zzzyz swizzling.
        /// </summary>
        public ivec5 zzzyz => new ivec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.bbbgb swizzling (equivalent to ivec4.zzzyz).
        /// </summary>
        public ivec5 bbbgb => new ivec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.zzzyw swizzling.
        /// </summary>
        public ivec5 zzzyw => new ivec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.bbbga swizzling (equivalent to ivec4.zzzyw).
        /// </summary>
        public ivec5 bbbga => new ivec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.zzzz swizzling.
        /// </summary>
        public ivec4 zzzz => new ivec4(z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.bbbb swizzling (equivalent to ivec4.zzzz).
        /// </summary>
        public ivec4 bbbb => new ivec4(z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.zzzzx swizzling.
        /// </summary>
        public ivec5 zzzzx => new ivec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.bbbbr swizzling (equivalent to ivec4.zzzzx).
        /// </summary>
        public ivec5 bbbbr => new ivec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.zzzzy swizzling.
        /// </summary>
        public ivec5 zzzzy => new ivec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.bbbbg swizzling (equivalent to ivec4.zzzzy).
        /// </summary>
        public ivec5 bbbbg => new ivec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.zzzzz swizzling.
        /// </summary>
        public ivec5 zzzzz => new ivec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.bbbbb swizzling (equivalent to ivec4.zzzzz).
        /// </summary>
        public ivec5 bbbbb => new ivec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.zzzzw swizzling.
        /// </summary>
        public ivec5 zzzzw => new ivec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.bbbba swizzling (equivalent to ivec4.zzzzw).
        /// </summary>
        public ivec5 bbbba => new ivec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.zzzw swizzling.
        /// </summary>
        public ivec4 zzzw => new ivec4(z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.bbba swizzling (equivalent to ivec4.zzzw).
        /// </summary>
        public ivec4 bbba => new ivec4(z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.zzzwx swizzling.
        /// </summary>
        public ivec5 zzzwx => new ivec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.bbbar swizzling (equivalent to ivec4.zzzwx).
        /// </summary>
        public ivec5 bbbar => new ivec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.zzzwy swizzling.
        /// </summary>
        public ivec5 zzzwy => new ivec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.bbbag swizzling (equivalent to ivec4.zzzwy).
        /// </summary>
        public ivec5 bbbag => new ivec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.zzzwz swizzling.
        /// </summary>
        public ivec5 zzzwz => new ivec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.bbbab swizzling (equivalent to ivec4.zzzwz).
        /// </summary>
        public ivec5 bbbab => new ivec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.zzzww swizzling.
        /// </summary>
        public ivec5 zzzww => new ivec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.bbbaa swizzling (equivalent to ivec4.zzzww).
        /// </summary>
        public ivec5 bbbaa => new ivec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.zzw swizzling.
        /// </summary>
        public ivec3 zzw => new ivec3(z, z, w);
        
        /// <summary>
        /// Returns ivec4.bba swizzling (equivalent to ivec4.zzw).
        /// </summary>
        public ivec3 bba => new ivec3(z, z, w);
        
        /// <summary>
        /// Returns ivec4.zzwx swizzling.
        /// </summary>
        public ivec4 zzwx => new ivec4(z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.bbar swizzling (equivalent to ivec4.zzwx).
        /// </summary>
        public ivec4 bbar => new ivec4(z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.zzwxx swizzling.
        /// </summary>
        public ivec5 zzwxx => new ivec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.bbarr swizzling (equivalent to ivec4.zzwxx).
        /// </summary>
        public ivec5 bbarr => new ivec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.zzwxy swizzling.
        /// </summary>
        public ivec5 zzwxy => new ivec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.bbarg swizzling (equivalent to ivec4.zzwxy).
        /// </summary>
        public ivec5 bbarg => new ivec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.zzwxz swizzling.
        /// </summary>
        public ivec5 zzwxz => new ivec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.bbarb swizzling (equivalent to ivec4.zzwxz).
        /// </summary>
        public ivec5 bbarb => new ivec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.zzwxw swizzling.
        /// </summary>
        public ivec5 zzwxw => new ivec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.bbara swizzling (equivalent to ivec4.zzwxw).
        /// </summary>
        public ivec5 bbara => new ivec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.zzwy swizzling.
        /// </summary>
        public ivec4 zzwy => new ivec4(z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.bbag swizzling (equivalent to ivec4.zzwy).
        /// </summary>
        public ivec4 bbag => new ivec4(z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.zzwyx swizzling.
        /// </summary>
        public ivec5 zzwyx => new ivec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.bbagr swizzling (equivalent to ivec4.zzwyx).
        /// </summary>
        public ivec5 bbagr => new ivec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.zzwyy swizzling.
        /// </summary>
        public ivec5 zzwyy => new ivec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.bbagg swizzling (equivalent to ivec4.zzwyy).
        /// </summary>
        public ivec5 bbagg => new ivec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.zzwyz swizzling.
        /// </summary>
        public ivec5 zzwyz => new ivec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.bbagb swizzling (equivalent to ivec4.zzwyz).
        /// </summary>
        public ivec5 bbagb => new ivec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.zzwyw swizzling.
        /// </summary>
        public ivec5 zzwyw => new ivec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.bbaga swizzling (equivalent to ivec4.zzwyw).
        /// </summary>
        public ivec5 bbaga => new ivec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.zzwz swizzling.
        /// </summary>
        public ivec4 zzwz => new ivec4(z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.bbab swizzling (equivalent to ivec4.zzwz).
        /// </summary>
        public ivec4 bbab => new ivec4(z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.zzwzx swizzling.
        /// </summary>
        public ivec5 zzwzx => new ivec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.bbabr swizzling (equivalent to ivec4.zzwzx).
        /// </summary>
        public ivec5 bbabr => new ivec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.zzwzy swizzling.
        /// </summary>
        public ivec5 zzwzy => new ivec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.bbabg swizzling (equivalent to ivec4.zzwzy).
        /// </summary>
        public ivec5 bbabg => new ivec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.zzwzz swizzling.
        /// </summary>
        public ivec5 zzwzz => new ivec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.bbabb swizzling (equivalent to ivec4.zzwzz).
        /// </summary>
        public ivec5 bbabb => new ivec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.zzwzw swizzling.
        /// </summary>
        public ivec5 zzwzw => new ivec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.bbaba swizzling (equivalent to ivec4.zzwzw).
        /// </summary>
        public ivec5 bbaba => new ivec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.zzww swizzling.
        /// </summary>
        public ivec4 zzww => new ivec4(z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.bbaa swizzling (equivalent to ivec4.zzww).
        /// </summary>
        public ivec4 bbaa => new ivec4(z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.zzwwx swizzling.
        /// </summary>
        public ivec5 zzwwx => new ivec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.bbaar swizzling (equivalent to ivec4.zzwwx).
        /// </summary>
        public ivec5 bbaar => new ivec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.zzwwy swizzling.
        /// </summary>
        public ivec5 zzwwy => new ivec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.bbaag swizzling (equivalent to ivec4.zzwwy).
        /// </summary>
        public ivec5 bbaag => new ivec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.zzwwz swizzling.
        /// </summary>
        public ivec5 zzwwz => new ivec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.bbaab swizzling (equivalent to ivec4.zzwwz).
        /// </summary>
        public ivec5 bbaab => new ivec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.zzwww swizzling.
        /// </summary>
        public ivec5 zzwww => new ivec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.bbaaa swizzling (equivalent to ivec4.zzwww).
        /// </summary>
        public ivec5 bbaaa => new ivec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.zw swizzling.
        /// </summary>
        public ivec2 zw => new ivec2(z, w);
        
        /// <summary>
        /// Returns ivec4.ba swizzling (equivalent to ivec4.zw).
        /// </summary>
        public ivec2 ba => new ivec2(z, w);
        
        /// <summary>
        /// Returns ivec4.zwx swizzling.
        /// </summary>
        public ivec3 zwx => new ivec3(z, w, x);
        
        /// <summary>
        /// Returns ivec4.bar swizzling (equivalent to ivec4.zwx).
        /// </summary>
        public ivec3 bar => new ivec3(z, w, x);
        
        /// <summary>
        /// Returns ivec4.zwxx swizzling.
        /// </summary>
        public ivec4 zwxx => new ivec4(z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.barr swizzling (equivalent to ivec4.zwxx).
        /// </summary>
        public ivec4 barr => new ivec4(z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.zwxxx swizzling.
        /// </summary>
        public ivec5 zwxxx => new ivec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.barrr swizzling (equivalent to ivec4.zwxxx).
        /// </summary>
        public ivec5 barrr => new ivec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.zwxxy swizzling.
        /// </summary>
        public ivec5 zwxxy => new ivec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.barrg swizzling (equivalent to ivec4.zwxxy).
        /// </summary>
        public ivec5 barrg => new ivec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.zwxxz swizzling.
        /// </summary>
        public ivec5 zwxxz => new ivec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.barrb swizzling (equivalent to ivec4.zwxxz).
        /// </summary>
        public ivec5 barrb => new ivec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.zwxxw swizzling.
        /// </summary>
        public ivec5 zwxxw => new ivec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.barra swizzling (equivalent to ivec4.zwxxw).
        /// </summary>
        public ivec5 barra => new ivec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.zwxy swizzling.
        /// </summary>
        public ivec4 zwxy => new ivec4(z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.barg swizzling (equivalent to ivec4.zwxy).
        /// </summary>
        public ivec4 barg => new ivec4(z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.zwxyx swizzling.
        /// </summary>
        public ivec5 zwxyx => new ivec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.bargr swizzling (equivalent to ivec4.zwxyx).
        /// </summary>
        public ivec5 bargr => new ivec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.zwxyy swizzling.
        /// </summary>
        public ivec5 zwxyy => new ivec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.bargg swizzling (equivalent to ivec4.zwxyy).
        /// </summary>
        public ivec5 bargg => new ivec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.zwxyz swizzling.
        /// </summary>
        public ivec5 zwxyz => new ivec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.bargb swizzling (equivalent to ivec4.zwxyz).
        /// </summary>
        public ivec5 bargb => new ivec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.zwxyw swizzling.
        /// </summary>
        public ivec5 zwxyw => new ivec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.barga swizzling (equivalent to ivec4.zwxyw).
        /// </summary>
        public ivec5 barga => new ivec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.zwxz swizzling.
        /// </summary>
        public ivec4 zwxz => new ivec4(z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.barb swizzling (equivalent to ivec4.zwxz).
        /// </summary>
        public ivec4 barb => new ivec4(z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.zwxzx swizzling.
        /// </summary>
        public ivec5 zwxzx => new ivec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.barbr swizzling (equivalent to ivec4.zwxzx).
        /// </summary>
        public ivec5 barbr => new ivec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.zwxzy swizzling.
        /// </summary>
        public ivec5 zwxzy => new ivec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.barbg swizzling (equivalent to ivec4.zwxzy).
        /// </summary>
        public ivec5 barbg => new ivec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.zwxzz swizzling.
        /// </summary>
        public ivec5 zwxzz => new ivec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.barbb swizzling (equivalent to ivec4.zwxzz).
        /// </summary>
        public ivec5 barbb => new ivec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.zwxzw swizzling.
        /// </summary>
        public ivec5 zwxzw => new ivec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.barba swizzling (equivalent to ivec4.zwxzw).
        /// </summary>
        public ivec5 barba => new ivec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.zwxw swizzling.
        /// </summary>
        public ivec4 zwxw => new ivec4(z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.bara swizzling (equivalent to ivec4.zwxw).
        /// </summary>
        public ivec4 bara => new ivec4(z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.zwxwx swizzling.
        /// </summary>
        public ivec5 zwxwx => new ivec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.barar swizzling (equivalent to ivec4.zwxwx).
        /// </summary>
        public ivec5 barar => new ivec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.zwxwy swizzling.
        /// </summary>
        public ivec5 zwxwy => new ivec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.barag swizzling (equivalent to ivec4.zwxwy).
        /// </summary>
        public ivec5 barag => new ivec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.zwxwz swizzling.
        /// </summary>
        public ivec5 zwxwz => new ivec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.barab swizzling (equivalent to ivec4.zwxwz).
        /// </summary>
        public ivec5 barab => new ivec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.zwxww swizzling.
        /// </summary>
        public ivec5 zwxww => new ivec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.baraa swizzling (equivalent to ivec4.zwxww).
        /// </summary>
        public ivec5 baraa => new ivec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.zwy swizzling.
        /// </summary>
        public ivec3 zwy => new ivec3(z, w, y);
        
        /// <summary>
        /// Returns ivec4.bag swizzling (equivalent to ivec4.zwy).
        /// </summary>
        public ivec3 bag => new ivec3(z, w, y);
        
        /// <summary>
        /// Returns ivec4.zwyx swizzling.
        /// </summary>
        public ivec4 zwyx => new ivec4(z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.bagr swizzling (equivalent to ivec4.zwyx).
        /// </summary>
        public ivec4 bagr => new ivec4(z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.zwyxx swizzling.
        /// </summary>
        public ivec5 zwyxx => new ivec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.bagrr swizzling (equivalent to ivec4.zwyxx).
        /// </summary>
        public ivec5 bagrr => new ivec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.zwyxy swizzling.
        /// </summary>
        public ivec5 zwyxy => new ivec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.bagrg swizzling (equivalent to ivec4.zwyxy).
        /// </summary>
        public ivec5 bagrg => new ivec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.zwyxz swizzling.
        /// </summary>
        public ivec5 zwyxz => new ivec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.bagrb swizzling (equivalent to ivec4.zwyxz).
        /// </summary>
        public ivec5 bagrb => new ivec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.zwyxw swizzling.
        /// </summary>
        public ivec5 zwyxw => new ivec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.bagra swizzling (equivalent to ivec4.zwyxw).
        /// </summary>
        public ivec5 bagra => new ivec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.zwyy swizzling.
        /// </summary>
        public ivec4 zwyy => new ivec4(z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.bagg swizzling (equivalent to ivec4.zwyy).
        /// </summary>
        public ivec4 bagg => new ivec4(z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.zwyyx swizzling.
        /// </summary>
        public ivec5 zwyyx => new ivec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.baggr swizzling (equivalent to ivec4.zwyyx).
        /// </summary>
        public ivec5 baggr => new ivec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.zwyyy swizzling.
        /// </summary>
        public ivec5 zwyyy => new ivec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.baggg swizzling (equivalent to ivec4.zwyyy).
        /// </summary>
        public ivec5 baggg => new ivec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.zwyyz swizzling.
        /// </summary>
        public ivec5 zwyyz => new ivec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.baggb swizzling (equivalent to ivec4.zwyyz).
        /// </summary>
        public ivec5 baggb => new ivec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.zwyyw swizzling.
        /// </summary>
        public ivec5 zwyyw => new ivec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.bagga swizzling (equivalent to ivec4.zwyyw).
        /// </summary>
        public ivec5 bagga => new ivec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.zwyz swizzling.
        /// </summary>
        public ivec4 zwyz => new ivec4(z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.bagb swizzling (equivalent to ivec4.zwyz).
        /// </summary>
        public ivec4 bagb => new ivec4(z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.zwyzx swizzling.
        /// </summary>
        public ivec5 zwyzx => new ivec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.bagbr swizzling (equivalent to ivec4.zwyzx).
        /// </summary>
        public ivec5 bagbr => new ivec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.zwyzy swizzling.
        /// </summary>
        public ivec5 zwyzy => new ivec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.bagbg swizzling (equivalent to ivec4.zwyzy).
        /// </summary>
        public ivec5 bagbg => new ivec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.zwyzz swizzling.
        /// </summary>
        public ivec5 zwyzz => new ivec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.bagbb swizzling (equivalent to ivec4.zwyzz).
        /// </summary>
        public ivec5 bagbb => new ivec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.zwyzw swizzling.
        /// </summary>
        public ivec5 zwyzw => new ivec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.bagba swizzling (equivalent to ivec4.zwyzw).
        /// </summary>
        public ivec5 bagba => new ivec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.zwyw swizzling.
        /// </summary>
        public ivec4 zwyw => new ivec4(z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.baga swizzling (equivalent to ivec4.zwyw).
        /// </summary>
        public ivec4 baga => new ivec4(z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.zwywx swizzling.
        /// </summary>
        public ivec5 zwywx => new ivec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.bagar swizzling (equivalent to ivec4.zwywx).
        /// </summary>
        public ivec5 bagar => new ivec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.zwywy swizzling.
        /// </summary>
        public ivec5 zwywy => new ivec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.bagag swizzling (equivalent to ivec4.zwywy).
        /// </summary>
        public ivec5 bagag => new ivec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.zwywz swizzling.
        /// </summary>
        public ivec5 zwywz => new ivec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.bagab swizzling (equivalent to ivec4.zwywz).
        /// </summary>
        public ivec5 bagab => new ivec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.zwyww swizzling.
        /// </summary>
        public ivec5 zwyww => new ivec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.bagaa swizzling (equivalent to ivec4.zwyww).
        /// </summary>
        public ivec5 bagaa => new ivec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.zwz swizzling.
        /// </summary>
        public ivec3 zwz => new ivec3(z, w, z);
        
        /// <summary>
        /// Returns ivec4.bab swizzling (equivalent to ivec4.zwz).
        /// </summary>
        public ivec3 bab => new ivec3(z, w, z);
        
        /// <summary>
        /// Returns ivec4.zwzx swizzling.
        /// </summary>
        public ivec4 zwzx => new ivec4(z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.babr swizzling (equivalent to ivec4.zwzx).
        /// </summary>
        public ivec4 babr => new ivec4(z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.zwzxx swizzling.
        /// </summary>
        public ivec5 zwzxx => new ivec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.babrr swizzling (equivalent to ivec4.zwzxx).
        /// </summary>
        public ivec5 babrr => new ivec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.zwzxy swizzling.
        /// </summary>
        public ivec5 zwzxy => new ivec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.babrg swizzling (equivalent to ivec4.zwzxy).
        /// </summary>
        public ivec5 babrg => new ivec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.zwzxz swizzling.
        /// </summary>
        public ivec5 zwzxz => new ivec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.babrb swizzling (equivalent to ivec4.zwzxz).
        /// </summary>
        public ivec5 babrb => new ivec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.zwzxw swizzling.
        /// </summary>
        public ivec5 zwzxw => new ivec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.babra swizzling (equivalent to ivec4.zwzxw).
        /// </summary>
        public ivec5 babra => new ivec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.zwzy swizzling.
        /// </summary>
        public ivec4 zwzy => new ivec4(z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.babg swizzling (equivalent to ivec4.zwzy).
        /// </summary>
        public ivec4 babg => new ivec4(z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.zwzyx swizzling.
        /// </summary>
        public ivec5 zwzyx => new ivec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.babgr swizzling (equivalent to ivec4.zwzyx).
        /// </summary>
        public ivec5 babgr => new ivec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.zwzyy swizzling.
        /// </summary>
        public ivec5 zwzyy => new ivec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.babgg swizzling (equivalent to ivec4.zwzyy).
        /// </summary>
        public ivec5 babgg => new ivec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.zwzyz swizzling.
        /// </summary>
        public ivec5 zwzyz => new ivec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.babgb swizzling (equivalent to ivec4.zwzyz).
        /// </summary>
        public ivec5 babgb => new ivec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.zwzyw swizzling.
        /// </summary>
        public ivec5 zwzyw => new ivec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.babga swizzling (equivalent to ivec4.zwzyw).
        /// </summary>
        public ivec5 babga => new ivec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.zwzz swizzling.
        /// </summary>
        public ivec4 zwzz => new ivec4(z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.babb swizzling (equivalent to ivec4.zwzz).
        /// </summary>
        public ivec4 babb => new ivec4(z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.zwzzx swizzling.
        /// </summary>
        public ivec5 zwzzx => new ivec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.babbr swizzling (equivalent to ivec4.zwzzx).
        /// </summary>
        public ivec5 babbr => new ivec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.zwzzy swizzling.
        /// </summary>
        public ivec5 zwzzy => new ivec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.babbg swizzling (equivalent to ivec4.zwzzy).
        /// </summary>
        public ivec5 babbg => new ivec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.zwzzz swizzling.
        /// </summary>
        public ivec5 zwzzz => new ivec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.babbb swizzling (equivalent to ivec4.zwzzz).
        /// </summary>
        public ivec5 babbb => new ivec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.zwzzw swizzling.
        /// </summary>
        public ivec5 zwzzw => new ivec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.babba swizzling (equivalent to ivec4.zwzzw).
        /// </summary>
        public ivec5 babba => new ivec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.zwzw swizzling.
        /// </summary>
        public ivec4 zwzw => new ivec4(z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.baba swizzling (equivalent to ivec4.zwzw).
        /// </summary>
        public ivec4 baba => new ivec4(z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.zwzwx swizzling.
        /// </summary>
        public ivec5 zwzwx => new ivec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.babar swizzling (equivalent to ivec4.zwzwx).
        /// </summary>
        public ivec5 babar => new ivec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.zwzwy swizzling.
        /// </summary>
        public ivec5 zwzwy => new ivec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.babag swizzling (equivalent to ivec4.zwzwy).
        /// </summary>
        public ivec5 babag => new ivec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.zwzwz swizzling.
        /// </summary>
        public ivec5 zwzwz => new ivec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.babab swizzling (equivalent to ivec4.zwzwz).
        /// </summary>
        public ivec5 babab => new ivec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.zwzww swizzling.
        /// </summary>
        public ivec5 zwzww => new ivec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.babaa swizzling (equivalent to ivec4.zwzww).
        /// </summary>
        public ivec5 babaa => new ivec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.zww swizzling.
        /// </summary>
        public ivec3 zww => new ivec3(z, w, w);
        
        /// <summary>
        /// Returns ivec4.baa swizzling (equivalent to ivec4.zww).
        /// </summary>
        public ivec3 baa => new ivec3(z, w, w);
        
        /// <summary>
        /// Returns ivec4.zwwx swizzling.
        /// </summary>
        public ivec4 zwwx => new ivec4(z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.baar swizzling (equivalent to ivec4.zwwx).
        /// </summary>
        public ivec4 baar => new ivec4(z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.zwwxx swizzling.
        /// </summary>
        public ivec5 zwwxx => new ivec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.baarr swizzling (equivalent to ivec4.zwwxx).
        /// </summary>
        public ivec5 baarr => new ivec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.zwwxy swizzling.
        /// </summary>
        public ivec5 zwwxy => new ivec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.baarg swizzling (equivalent to ivec4.zwwxy).
        /// </summary>
        public ivec5 baarg => new ivec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.zwwxz swizzling.
        /// </summary>
        public ivec5 zwwxz => new ivec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.baarb swizzling (equivalent to ivec4.zwwxz).
        /// </summary>
        public ivec5 baarb => new ivec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.zwwxw swizzling.
        /// </summary>
        public ivec5 zwwxw => new ivec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.baara swizzling (equivalent to ivec4.zwwxw).
        /// </summary>
        public ivec5 baara => new ivec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.zwwy swizzling.
        /// </summary>
        public ivec4 zwwy => new ivec4(z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.baag swizzling (equivalent to ivec4.zwwy).
        /// </summary>
        public ivec4 baag => new ivec4(z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.zwwyx swizzling.
        /// </summary>
        public ivec5 zwwyx => new ivec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.baagr swizzling (equivalent to ivec4.zwwyx).
        /// </summary>
        public ivec5 baagr => new ivec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.zwwyy swizzling.
        /// </summary>
        public ivec5 zwwyy => new ivec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.baagg swizzling (equivalent to ivec4.zwwyy).
        /// </summary>
        public ivec5 baagg => new ivec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.zwwyz swizzling.
        /// </summary>
        public ivec5 zwwyz => new ivec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.baagb swizzling (equivalent to ivec4.zwwyz).
        /// </summary>
        public ivec5 baagb => new ivec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.zwwyw swizzling.
        /// </summary>
        public ivec5 zwwyw => new ivec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.baaga swizzling (equivalent to ivec4.zwwyw).
        /// </summary>
        public ivec5 baaga => new ivec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.zwwz swizzling.
        /// </summary>
        public ivec4 zwwz => new ivec4(z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.baab swizzling (equivalent to ivec4.zwwz).
        /// </summary>
        public ivec4 baab => new ivec4(z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.zwwzx swizzling.
        /// </summary>
        public ivec5 zwwzx => new ivec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.baabr swizzling (equivalent to ivec4.zwwzx).
        /// </summary>
        public ivec5 baabr => new ivec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.zwwzy swizzling.
        /// </summary>
        public ivec5 zwwzy => new ivec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.baabg swizzling (equivalent to ivec4.zwwzy).
        /// </summary>
        public ivec5 baabg => new ivec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.zwwzz swizzling.
        /// </summary>
        public ivec5 zwwzz => new ivec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.baabb swizzling (equivalent to ivec4.zwwzz).
        /// </summary>
        public ivec5 baabb => new ivec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.zwwzw swizzling.
        /// </summary>
        public ivec5 zwwzw => new ivec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.baaba swizzling (equivalent to ivec4.zwwzw).
        /// </summary>
        public ivec5 baaba => new ivec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.zwww swizzling.
        /// </summary>
        public ivec4 zwww => new ivec4(z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.baaa swizzling (equivalent to ivec4.zwww).
        /// </summary>
        public ivec4 baaa => new ivec4(z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.zwwwx swizzling.
        /// </summary>
        public ivec5 zwwwx => new ivec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.baaar swizzling (equivalent to ivec4.zwwwx).
        /// </summary>
        public ivec5 baaar => new ivec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.zwwwy swizzling.
        /// </summary>
        public ivec5 zwwwy => new ivec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.baaag swizzling (equivalent to ivec4.zwwwy).
        /// </summary>
        public ivec5 baaag => new ivec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.zwwwz swizzling.
        /// </summary>
        public ivec5 zwwwz => new ivec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.baaab swizzling (equivalent to ivec4.zwwwz).
        /// </summary>
        public ivec5 baaab => new ivec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.zwwww swizzling.
        /// </summary>
        public ivec5 zwwww => new ivec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns ivec4.baaaa swizzling (equivalent to ivec4.zwwww).
        /// </summary>
        public ivec5 baaaa => new ivec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns ivec4.wx swizzling.
        /// </summary>
        public ivec2 wx => new ivec2(w, x);
        
        /// <summary>
        /// Returns ivec4.ar swizzling (equivalent to ivec4.wx).
        /// </summary>
        public ivec2 ar => new ivec2(w, x);
        
        /// <summary>
        /// Returns ivec4.wxx swizzling.
        /// </summary>
        public ivec3 wxx => new ivec3(w, x, x);
        
        /// <summary>
        /// Returns ivec4.arr swizzling (equivalent to ivec4.wxx).
        /// </summary>
        public ivec3 arr => new ivec3(w, x, x);
        
        /// <summary>
        /// Returns ivec4.wxxx swizzling.
        /// </summary>
        public ivec4 wxxx => new ivec4(w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.arrr swizzling (equivalent to ivec4.wxxx).
        /// </summary>
        public ivec4 arrr => new ivec4(w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.wxxxx swizzling.
        /// </summary>
        public ivec5 wxxxx => new ivec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.arrrr swizzling (equivalent to ivec4.wxxxx).
        /// </summary>
        public ivec5 arrrr => new ivec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.wxxxy swizzling.
        /// </summary>
        public ivec5 wxxxy => new ivec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.arrrg swizzling (equivalent to ivec4.wxxxy).
        /// </summary>
        public ivec5 arrrg => new ivec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.wxxxz swizzling.
        /// </summary>
        public ivec5 wxxxz => new ivec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.arrrb swizzling (equivalent to ivec4.wxxxz).
        /// </summary>
        public ivec5 arrrb => new ivec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.wxxxw swizzling.
        /// </summary>
        public ivec5 wxxxw => new ivec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.arrra swizzling (equivalent to ivec4.wxxxw).
        /// </summary>
        public ivec5 arrra => new ivec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.wxxy swizzling.
        /// </summary>
        public ivec4 wxxy => new ivec4(w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.arrg swizzling (equivalent to ivec4.wxxy).
        /// </summary>
        public ivec4 arrg => new ivec4(w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.wxxyx swizzling.
        /// </summary>
        public ivec5 wxxyx => new ivec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.arrgr swizzling (equivalent to ivec4.wxxyx).
        /// </summary>
        public ivec5 arrgr => new ivec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.wxxyy swizzling.
        /// </summary>
        public ivec5 wxxyy => new ivec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.arrgg swizzling (equivalent to ivec4.wxxyy).
        /// </summary>
        public ivec5 arrgg => new ivec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.wxxyz swizzling.
        /// </summary>
        public ivec5 wxxyz => new ivec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.arrgb swizzling (equivalent to ivec4.wxxyz).
        /// </summary>
        public ivec5 arrgb => new ivec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.wxxyw swizzling.
        /// </summary>
        public ivec5 wxxyw => new ivec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.arrga swizzling (equivalent to ivec4.wxxyw).
        /// </summary>
        public ivec5 arrga => new ivec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.wxxz swizzling.
        /// </summary>
        public ivec4 wxxz => new ivec4(w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.arrb swizzling (equivalent to ivec4.wxxz).
        /// </summary>
        public ivec4 arrb => new ivec4(w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.wxxzx swizzling.
        /// </summary>
        public ivec5 wxxzx => new ivec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.arrbr swizzling (equivalent to ivec4.wxxzx).
        /// </summary>
        public ivec5 arrbr => new ivec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.wxxzy swizzling.
        /// </summary>
        public ivec5 wxxzy => new ivec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.arrbg swizzling (equivalent to ivec4.wxxzy).
        /// </summary>
        public ivec5 arrbg => new ivec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.wxxzz swizzling.
        /// </summary>
        public ivec5 wxxzz => new ivec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.arrbb swizzling (equivalent to ivec4.wxxzz).
        /// </summary>
        public ivec5 arrbb => new ivec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.wxxzw swizzling.
        /// </summary>
        public ivec5 wxxzw => new ivec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.arrba swizzling (equivalent to ivec4.wxxzw).
        /// </summary>
        public ivec5 arrba => new ivec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.wxxw swizzling.
        /// </summary>
        public ivec4 wxxw => new ivec4(w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.arra swizzling (equivalent to ivec4.wxxw).
        /// </summary>
        public ivec4 arra => new ivec4(w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.wxxwx swizzling.
        /// </summary>
        public ivec5 wxxwx => new ivec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.arrar swizzling (equivalent to ivec4.wxxwx).
        /// </summary>
        public ivec5 arrar => new ivec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.wxxwy swizzling.
        /// </summary>
        public ivec5 wxxwy => new ivec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.arrag swizzling (equivalent to ivec4.wxxwy).
        /// </summary>
        public ivec5 arrag => new ivec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.wxxwz swizzling.
        /// </summary>
        public ivec5 wxxwz => new ivec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.arrab swizzling (equivalent to ivec4.wxxwz).
        /// </summary>
        public ivec5 arrab => new ivec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.wxxww swizzling.
        /// </summary>
        public ivec5 wxxww => new ivec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.arraa swizzling (equivalent to ivec4.wxxww).
        /// </summary>
        public ivec5 arraa => new ivec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.wxy swizzling.
        /// </summary>
        public ivec3 wxy => new ivec3(w, x, y);
        
        /// <summary>
        /// Returns ivec4.arg swizzling (equivalent to ivec4.wxy).
        /// </summary>
        public ivec3 arg => new ivec3(w, x, y);
        
        /// <summary>
        /// Returns ivec4.wxyx swizzling.
        /// </summary>
        public ivec4 wxyx => new ivec4(w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.argr swizzling (equivalent to ivec4.wxyx).
        /// </summary>
        public ivec4 argr => new ivec4(w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.wxyxx swizzling.
        /// </summary>
        public ivec5 wxyxx => new ivec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.argrr swizzling (equivalent to ivec4.wxyxx).
        /// </summary>
        public ivec5 argrr => new ivec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.wxyxy swizzling.
        /// </summary>
        public ivec5 wxyxy => new ivec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.argrg swizzling (equivalent to ivec4.wxyxy).
        /// </summary>
        public ivec5 argrg => new ivec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.wxyxz swizzling.
        /// </summary>
        public ivec5 wxyxz => new ivec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.argrb swizzling (equivalent to ivec4.wxyxz).
        /// </summary>
        public ivec5 argrb => new ivec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.wxyxw swizzling.
        /// </summary>
        public ivec5 wxyxw => new ivec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.argra swizzling (equivalent to ivec4.wxyxw).
        /// </summary>
        public ivec5 argra => new ivec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.wxyy swizzling.
        /// </summary>
        public ivec4 wxyy => new ivec4(w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.argg swizzling (equivalent to ivec4.wxyy).
        /// </summary>
        public ivec4 argg => new ivec4(w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.wxyyx swizzling.
        /// </summary>
        public ivec5 wxyyx => new ivec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.arggr swizzling (equivalent to ivec4.wxyyx).
        /// </summary>
        public ivec5 arggr => new ivec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.wxyyy swizzling.
        /// </summary>
        public ivec5 wxyyy => new ivec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.arggg swizzling (equivalent to ivec4.wxyyy).
        /// </summary>
        public ivec5 arggg => new ivec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.wxyyz swizzling.
        /// </summary>
        public ivec5 wxyyz => new ivec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.arggb swizzling (equivalent to ivec4.wxyyz).
        /// </summary>
        public ivec5 arggb => new ivec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.wxyyw swizzling.
        /// </summary>
        public ivec5 wxyyw => new ivec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.argga swizzling (equivalent to ivec4.wxyyw).
        /// </summary>
        public ivec5 argga => new ivec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.wxyz swizzling.
        /// </summary>
        public ivec4 wxyz => new ivec4(w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.argb swizzling (equivalent to ivec4.wxyz).
        /// </summary>
        public ivec4 argb => new ivec4(w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.wxyzx swizzling.
        /// </summary>
        public ivec5 wxyzx => new ivec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.argbr swizzling (equivalent to ivec4.wxyzx).
        /// </summary>
        public ivec5 argbr => new ivec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.wxyzy swizzling.
        /// </summary>
        public ivec5 wxyzy => new ivec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.argbg swizzling (equivalent to ivec4.wxyzy).
        /// </summary>
        public ivec5 argbg => new ivec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.wxyzz swizzling.
        /// </summary>
        public ivec5 wxyzz => new ivec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.argbb swizzling (equivalent to ivec4.wxyzz).
        /// </summary>
        public ivec5 argbb => new ivec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.wxyzw swizzling.
        /// </summary>
        public ivec5 wxyzw => new ivec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.argba swizzling (equivalent to ivec4.wxyzw).
        /// </summary>
        public ivec5 argba => new ivec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.wxyw swizzling.
        /// </summary>
        public ivec4 wxyw => new ivec4(w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.arga swizzling (equivalent to ivec4.wxyw).
        /// </summary>
        public ivec4 arga => new ivec4(w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.wxywx swizzling.
        /// </summary>
        public ivec5 wxywx => new ivec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.argar swizzling (equivalent to ivec4.wxywx).
        /// </summary>
        public ivec5 argar => new ivec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.wxywy swizzling.
        /// </summary>
        public ivec5 wxywy => new ivec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.argag swizzling (equivalent to ivec4.wxywy).
        /// </summary>
        public ivec5 argag => new ivec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.wxywz swizzling.
        /// </summary>
        public ivec5 wxywz => new ivec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.argab swizzling (equivalent to ivec4.wxywz).
        /// </summary>
        public ivec5 argab => new ivec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.wxyww swizzling.
        /// </summary>
        public ivec5 wxyww => new ivec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.argaa swizzling (equivalent to ivec4.wxyww).
        /// </summary>
        public ivec5 argaa => new ivec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.wxz swizzling.
        /// </summary>
        public ivec3 wxz => new ivec3(w, x, z);
        
        /// <summary>
        /// Returns ivec4.arb swizzling (equivalent to ivec4.wxz).
        /// </summary>
        public ivec3 arb => new ivec3(w, x, z);
        
        /// <summary>
        /// Returns ivec4.wxzx swizzling.
        /// </summary>
        public ivec4 wxzx => new ivec4(w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.arbr swizzling (equivalent to ivec4.wxzx).
        /// </summary>
        public ivec4 arbr => new ivec4(w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.wxzxx swizzling.
        /// </summary>
        public ivec5 wxzxx => new ivec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.arbrr swizzling (equivalent to ivec4.wxzxx).
        /// </summary>
        public ivec5 arbrr => new ivec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.wxzxy swizzling.
        /// </summary>
        public ivec5 wxzxy => new ivec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.arbrg swizzling (equivalent to ivec4.wxzxy).
        /// </summary>
        public ivec5 arbrg => new ivec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.wxzxz swizzling.
        /// </summary>
        public ivec5 wxzxz => new ivec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.arbrb swizzling (equivalent to ivec4.wxzxz).
        /// </summary>
        public ivec5 arbrb => new ivec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.wxzxw swizzling.
        /// </summary>
        public ivec5 wxzxw => new ivec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.arbra swizzling (equivalent to ivec4.wxzxw).
        /// </summary>
        public ivec5 arbra => new ivec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.wxzy swizzling.
        /// </summary>
        public ivec4 wxzy => new ivec4(w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.arbg swizzling (equivalent to ivec4.wxzy).
        /// </summary>
        public ivec4 arbg => new ivec4(w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.wxzyx swizzling.
        /// </summary>
        public ivec5 wxzyx => new ivec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.arbgr swizzling (equivalent to ivec4.wxzyx).
        /// </summary>
        public ivec5 arbgr => new ivec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.wxzyy swizzling.
        /// </summary>
        public ivec5 wxzyy => new ivec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.arbgg swizzling (equivalent to ivec4.wxzyy).
        /// </summary>
        public ivec5 arbgg => new ivec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.wxzyz swizzling.
        /// </summary>
        public ivec5 wxzyz => new ivec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.arbgb swizzling (equivalent to ivec4.wxzyz).
        /// </summary>
        public ivec5 arbgb => new ivec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.wxzyw swizzling.
        /// </summary>
        public ivec5 wxzyw => new ivec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.arbga swizzling (equivalent to ivec4.wxzyw).
        /// </summary>
        public ivec5 arbga => new ivec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.wxzz swizzling.
        /// </summary>
        public ivec4 wxzz => new ivec4(w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.arbb swizzling (equivalent to ivec4.wxzz).
        /// </summary>
        public ivec4 arbb => new ivec4(w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.wxzzx swizzling.
        /// </summary>
        public ivec5 wxzzx => new ivec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.arbbr swizzling (equivalent to ivec4.wxzzx).
        /// </summary>
        public ivec5 arbbr => new ivec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.wxzzy swizzling.
        /// </summary>
        public ivec5 wxzzy => new ivec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.arbbg swizzling (equivalent to ivec4.wxzzy).
        /// </summary>
        public ivec5 arbbg => new ivec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.wxzzz swizzling.
        /// </summary>
        public ivec5 wxzzz => new ivec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.arbbb swizzling (equivalent to ivec4.wxzzz).
        /// </summary>
        public ivec5 arbbb => new ivec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.wxzzw swizzling.
        /// </summary>
        public ivec5 wxzzw => new ivec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.arbba swizzling (equivalent to ivec4.wxzzw).
        /// </summary>
        public ivec5 arbba => new ivec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.wxzw swizzling.
        /// </summary>
        public ivec4 wxzw => new ivec4(w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.arba swizzling (equivalent to ivec4.wxzw).
        /// </summary>
        public ivec4 arba => new ivec4(w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.wxzwx swizzling.
        /// </summary>
        public ivec5 wxzwx => new ivec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.arbar swizzling (equivalent to ivec4.wxzwx).
        /// </summary>
        public ivec5 arbar => new ivec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.wxzwy swizzling.
        /// </summary>
        public ivec5 wxzwy => new ivec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.arbag swizzling (equivalent to ivec4.wxzwy).
        /// </summary>
        public ivec5 arbag => new ivec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.wxzwz swizzling.
        /// </summary>
        public ivec5 wxzwz => new ivec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.arbab swizzling (equivalent to ivec4.wxzwz).
        /// </summary>
        public ivec5 arbab => new ivec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.wxzww swizzling.
        /// </summary>
        public ivec5 wxzww => new ivec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.arbaa swizzling (equivalent to ivec4.wxzww).
        /// </summary>
        public ivec5 arbaa => new ivec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.wxw swizzling.
        /// </summary>
        public ivec3 wxw => new ivec3(w, x, w);
        
        /// <summary>
        /// Returns ivec4.ara swizzling (equivalent to ivec4.wxw).
        /// </summary>
        public ivec3 ara => new ivec3(w, x, w);
        
        /// <summary>
        /// Returns ivec4.wxwx swizzling.
        /// </summary>
        public ivec4 wxwx => new ivec4(w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.arar swizzling (equivalent to ivec4.wxwx).
        /// </summary>
        public ivec4 arar => new ivec4(w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.wxwxx swizzling.
        /// </summary>
        public ivec5 wxwxx => new ivec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.ararr swizzling (equivalent to ivec4.wxwxx).
        /// </summary>
        public ivec5 ararr => new ivec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.wxwxy swizzling.
        /// </summary>
        public ivec5 wxwxy => new ivec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.ararg swizzling (equivalent to ivec4.wxwxy).
        /// </summary>
        public ivec5 ararg => new ivec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.wxwxz swizzling.
        /// </summary>
        public ivec5 wxwxz => new ivec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.ararb swizzling (equivalent to ivec4.wxwxz).
        /// </summary>
        public ivec5 ararb => new ivec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.wxwxw swizzling.
        /// </summary>
        public ivec5 wxwxw => new ivec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.arara swizzling (equivalent to ivec4.wxwxw).
        /// </summary>
        public ivec5 arara => new ivec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.wxwy swizzling.
        /// </summary>
        public ivec4 wxwy => new ivec4(w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.arag swizzling (equivalent to ivec4.wxwy).
        /// </summary>
        public ivec4 arag => new ivec4(w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.wxwyx swizzling.
        /// </summary>
        public ivec5 wxwyx => new ivec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.aragr swizzling (equivalent to ivec4.wxwyx).
        /// </summary>
        public ivec5 aragr => new ivec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.wxwyy swizzling.
        /// </summary>
        public ivec5 wxwyy => new ivec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.aragg swizzling (equivalent to ivec4.wxwyy).
        /// </summary>
        public ivec5 aragg => new ivec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.wxwyz swizzling.
        /// </summary>
        public ivec5 wxwyz => new ivec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.aragb swizzling (equivalent to ivec4.wxwyz).
        /// </summary>
        public ivec5 aragb => new ivec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.wxwyw swizzling.
        /// </summary>
        public ivec5 wxwyw => new ivec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.araga swizzling (equivalent to ivec4.wxwyw).
        /// </summary>
        public ivec5 araga => new ivec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.wxwz swizzling.
        /// </summary>
        public ivec4 wxwz => new ivec4(w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.arab swizzling (equivalent to ivec4.wxwz).
        /// </summary>
        public ivec4 arab => new ivec4(w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.wxwzx swizzling.
        /// </summary>
        public ivec5 wxwzx => new ivec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.arabr swizzling (equivalent to ivec4.wxwzx).
        /// </summary>
        public ivec5 arabr => new ivec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.wxwzy swizzling.
        /// </summary>
        public ivec5 wxwzy => new ivec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.arabg swizzling (equivalent to ivec4.wxwzy).
        /// </summary>
        public ivec5 arabg => new ivec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.wxwzz swizzling.
        /// </summary>
        public ivec5 wxwzz => new ivec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.arabb swizzling (equivalent to ivec4.wxwzz).
        /// </summary>
        public ivec5 arabb => new ivec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.wxwzw swizzling.
        /// </summary>
        public ivec5 wxwzw => new ivec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.araba swizzling (equivalent to ivec4.wxwzw).
        /// </summary>
        public ivec5 araba => new ivec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.wxww swizzling.
        /// </summary>
        public ivec4 wxww => new ivec4(w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.araa swizzling (equivalent to ivec4.wxww).
        /// </summary>
        public ivec4 araa => new ivec4(w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.wxwwx swizzling.
        /// </summary>
        public ivec5 wxwwx => new ivec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.araar swizzling (equivalent to ivec4.wxwwx).
        /// </summary>
        public ivec5 araar => new ivec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.wxwwy swizzling.
        /// </summary>
        public ivec5 wxwwy => new ivec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.araag swizzling (equivalent to ivec4.wxwwy).
        /// </summary>
        public ivec5 araag => new ivec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.wxwwz swizzling.
        /// </summary>
        public ivec5 wxwwz => new ivec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.araab swizzling (equivalent to ivec4.wxwwz).
        /// </summary>
        public ivec5 araab => new ivec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.wxwww swizzling.
        /// </summary>
        public ivec5 wxwww => new ivec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.araaa swizzling (equivalent to ivec4.wxwww).
        /// </summary>
        public ivec5 araaa => new ivec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.wy swizzling.
        /// </summary>
        public ivec2 wy => new ivec2(w, y);
        
        /// <summary>
        /// Returns ivec4.ag swizzling (equivalent to ivec4.wy).
        /// </summary>
        public ivec2 ag => new ivec2(w, y);
        
        /// <summary>
        /// Returns ivec4.wyx swizzling.
        /// </summary>
        public ivec3 wyx => new ivec3(w, y, x);
        
        /// <summary>
        /// Returns ivec4.agr swizzling (equivalent to ivec4.wyx).
        /// </summary>
        public ivec3 agr => new ivec3(w, y, x);
        
        /// <summary>
        /// Returns ivec4.wyxx swizzling.
        /// </summary>
        public ivec4 wyxx => new ivec4(w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.agrr swizzling (equivalent to ivec4.wyxx).
        /// </summary>
        public ivec4 agrr => new ivec4(w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.wyxxx swizzling.
        /// </summary>
        public ivec5 wyxxx => new ivec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.agrrr swizzling (equivalent to ivec4.wyxxx).
        /// </summary>
        public ivec5 agrrr => new ivec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.wyxxy swizzling.
        /// </summary>
        public ivec5 wyxxy => new ivec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.agrrg swizzling (equivalent to ivec4.wyxxy).
        /// </summary>
        public ivec5 agrrg => new ivec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.wyxxz swizzling.
        /// </summary>
        public ivec5 wyxxz => new ivec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.agrrb swizzling (equivalent to ivec4.wyxxz).
        /// </summary>
        public ivec5 agrrb => new ivec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.wyxxw swizzling.
        /// </summary>
        public ivec5 wyxxw => new ivec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.agrra swizzling (equivalent to ivec4.wyxxw).
        /// </summary>
        public ivec5 agrra => new ivec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.wyxy swizzling.
        /// </summary>
        public ivec4 wyxy => new ivec4(w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.agrg swizzling (equivalent to ivec4.wyxy).
        /// </summary>
        public ivec4 agrg => new ivec4(w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.wyxyx swizzling.
        /// </summary>
        public ivec5 wyxyx => new ivec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.agrgr swizzling (equivalent to ivec4.wyxyx).
        /// </summary>
        public ivec5 agrgr => new ivec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.wyxyy swizzling.
        /// </summary>
        public ivec5 wyxyy => new ivec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.agrgg swizzling (equivalent to ivec4.wyxyy).
        /// </summary>
        public ivec5 agrgg => new ivec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.wyxyz swizzling.
        /// </summary>
        public ivec5 wyxyz => new ivec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.agrgb swizzling (equivalent to ivec4.wyxyz).
        /// </summary>
        public ivec5 agrgb => new ivec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.wyxyw swizzling.
        /// </summary>
        public ivec5 wyxyw => new ivec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.agrga swizzling (equivalent to ivec4.wyxyw).
        /// </summary>
        public ivec5 agrga => new ivec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.wyxz swizzling.
        /// </summary>
        public ivec4 wyxz => new ivec4(w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.agrb swizzling (equivalent to ivec4.wyxz).
        /// </summary>
        public ivec4 agrb => new ivec4(w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.wyxzx swizzling.
        /// </summary>
        public ivec5 wyxzx => new ivec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.agrbr swizzling (equivalent to ivec4.wyxzx).
        /// </summary>
        public ivec5 agrbr => new ivec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.wyxzy swizzling.
        /// </summary>
        public ivec5 wyxzy => new ivec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.agrbg swizzling (equivalent to ivec4.wyxzy).
        /// </summary>
        public ivec5 agrbg => new ivec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.wyxzz swizzling.
        /// </summary>
        public ivec5 wyxzz => new ivec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.agrbb swizzling (equivalent to ivec4.wyxzz).
        /// </summary>
        public ivec5 agrbb => new ivec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.wyxzw swizzling.
        /// </summary>
        public ivec5 wyxzw => new ivec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.agrba swizzling (equivalent to ivec4.wyxzw).
        /// </summary>
        public ivec5 agrba => new ivec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.wyxw swizzling.
        /// </summary>
        public ivec4 wyxw => new ivec4(w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.agra swizzling (equivalent to ivec4.wyxw).
        /// </summary>
        public ivec4 agra => new ivec4(w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.wyxwx swizzling.
        /// </summary>
        public ivec5 wyxwx => new ivec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.agrar swizzling (equivalent to ivec4.wyxwx).
        /// </summary>
        public ivec5 agrar => new ivec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.wyxwy swizzling.
        /// </summary>
        public ivec5 wyxwy => new ivec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.agrag swizzling (equivalent to ivec4.wyxwy).
        /// </summary>
        public ivec5 agrag => new ivec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.wyxwz swizzling.
        /// </summary>
        public ivec5 wyxwz => new ivec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.agrab swizzling (equivalent to ivec4.wyxwz).
        /// </summary>
        public ivec5 agrab => new ivec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.wyxww swizzling.
        /// </summary>
        public ivec5 wyxww => new ivec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.agraa swizzling (equivalent to ivec4.wyxww).
        /// </summary>
        public ivec5 agraa => new ivec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.wyy swizzling.
        /// </summary>
        public ivec3 wyy => new ivec3(w, y, y);
        
        /// <summary>
        /// Returns ivec4.agg swizzling (equivalent to ivec4.wyy).
        /// </summary>
        public ivec3 agg => new ivec3(w, y, y);
        
        /// <summary>
        /// Returns ivec4.wyyx swizzling.
        /// </summary>
        public ivec4 wyyx => new ivec4(w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.aggr swizzling (equivalent to ivec4.wyyx).
        /// </summary>
        public ivec4 aggr => new ivec4(w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.wyyxx swizzling.
        /// </summary>
        public ivec5 wyyxx => new ivec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.aggrr swizzling (equivalent to ivec4.wyyxx).
        /// </summary>
        public ivec5 aggrr => new ivec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.wyyxy swizzling.
        /// </summary>
        public ivec5 wyyxy => new ivec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.aggrg swizzling (equivalent to ivec4.wyyxy).
        /// </summary>
        public ivec5 aggrg => new ivec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.wyyxz swizzling.
        /// </summary>
        public ivec5 wyyxz => new ivec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.aggrb swizzling (equivalent to ivec4.wyyxz).
        /// </summary>
        public ivec5 aggrb => new ivec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.wyyxw swizzling.
        /// </summary>
        public ivec5 wyyxw => new ivec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.aggra swizzling (equivalent to ivec4.wyyxw).
        /// </summary>
        public ivec5 aggra => new ivec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.wyyy swizzling.
        /// </summary>
        public ivec4 wyyy => new ivec4(w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.aggg swizzling (equivalent to ivec4.wyyy).
        /// </summary>
        public ivec4 aggg => new ivec4(w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.wyyyx swizzling.
        /// </summary>
        public ivec5 wyyyx => new ivec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.agggr swizzling (equivalent to ivec4.wyyyx).
        /// </summary>
        public ivec5 agggr => new ivec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.wyyyy swizzling.
        /// </summary>
        public ivec5 wyyyy => new ivec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.agggg swizzling (equivalent to ivec4.wyyyy).
        /// </summary>
        public ivec5 agggg => new ivec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.wyyyz swizzling.
        /// </summary>
        public ivec5 wyyyz => new ivec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.agggb swizzling (equivalent to ivec4.wyyyz).
        /// </summary>
        public ivec5 agggb => new ivec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.wyyyw swizzling.
        /// </summary>
        public ivec5 wyyyw => new ivec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.aggga swizzling (equivalent to ivec4.wyyyw).
        /// </summary>
        public ivec5 aggga => new ivec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.wyyz swizzling.
        /// </summary>
        public ivec4 wyyz => new ivec4(w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.aggb swizzling (equivalent to ivec4.wyyz).
        /// </summary>
        public ivec4 aggb => new ivec4(w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.wyyzx swizzling.
        /// </summary>
        public ivec5 wyyzx => new ivec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.aggbr swizzling (equivalent to ivec4.wyyzx).
        /// </summary>
        public ivec5 aggbr => new ivec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.wyyzy swizzling.
        /// </summary>
        public ivec5 wyyzy => new ivec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.aggbg swizzling (equivalent to ivec4.wyyzy).
        /// </summary>
        public ivec5 aggbg => new ivec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.wyyzz swizzling.
        /// </summary>
        public ivec5 wyyzz => new ivec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.aggbb swizzling (equivalent to ivec4.wyyzz).
        /// </summary>
        public ivec5 aggbb => new ivec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.wyyzw swizzling.
        /// </summary>
        public ivec5 wyyzw => new ivec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.aggba swizzling (equivalent to ivec4.wyyzw).
        /// </summary>
        public ivec5 aggba => new ivec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.wyyw swizzling.
        /// </summary>
        public ivec4 wyyw => new ivec4(w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.agga swizzling (equivalent to ivec4.wyyw).
        /// </summary>
        public ivec4 agga => new ivec4(w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.wyywx swizzling.
        /// </summary>
        public ivec5 wyywx => new ivec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.aggar swizzling (equivalent to ivec4.wyywx).
        /// </summary>
        public ivec5 aggar => new ivec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.wyywy swizzling.
        /// </summary>
        public ivec5 wyywy => new ivec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.aggag swizzling (equivalent to ivec4.wyywy).
        /// </summary>
        public ivec5 aggag => new ivec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.wyywz swizzling.
        /// </summary>
        public ivec5 wyywz => new ivec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.aggab swizzling (equivalent to ivec4.wyywz).
        /// </summary>
        public ivec5 aggab => new ivec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.wyyww swizzling.
        /// </summary>
        public ivec5 wyyww => new ivec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.aggaa swizzling (equivalent to ivec4.wyyww).
        /// </summary>
        public ivec5 aggaa => new ivec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.wyz swizzling.
        /// </summary>
        public ivec3 wyz => new ivec3(w, y, z);
        
        /// <summary>
        /// Returns ivec4.agb swizzling (equivalent to ivec4.wyz).
        /// </summary>
        public ivec3 agb => new ivec3(w, y, z);
        
        /// <summary>
        /// Returns ivec4.wyzx swizzling.
        /// </summary>
        public ivec4 wyzx => new ivec4(w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.agbr swizzling (equivalent to ivec4.wyzx).
        /// </summary>
        public ivec4 agbr => new ivec4(w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.wyzxx swizzling.
        /// </summary>
        public ivec5 wyzxx => new ivec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.agbrr swizzling (equivalent to ivec4.wyzxx).
        /// </summary>
        public ivec5 agbrr => new ivec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.wyzxy swizzling.
        /// </summary>
        public ivec5 wyzxy => new ivec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.agbrg swizzling (equivalent to ivec4.wyzxy).
        /// </summary>
        public ivec5 agbrg => new ivec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.wyzxz swizzling.
        /// </summary>
        public ivec5 wyzxz => new ivec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.agbrb swizzling (equivalent to ivec4.wyzxz).
        /// </summary>
        public ivec5 agbrb => new ivec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.wyzxw swizzling.
        /// </summary>
        public ivec5 wyzxw => new ivec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.agbra swizzling (equivalent to ivec4.wyzxw).
        /// </summary>
        public ivec5 agbra => new ivec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.wyzy swizzling.
        /// </summary>
        public ivec4 wyzy => new ivec4(w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.agbg swizzling (equivalent to ivec4.wyzy).
        /// </summary>
        public ivec4 agbg => new ivec4(w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.wyzyx swizzling.
        /// </summary>
        public ivec5 wyzyx => new ivec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.agbgr swizzling (equivalent to ivec4.wyzyx).
        /// </summary>
        public ivec5 agbgr => new ivec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.wyzyy swizzling.
        /// </summary>
        public ivec5 wyzyy => new ivec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.agbgg swizzling (equivalent to ivec4.wyzyy).
        /// </summary>
        public ivec5 agbgg => new ivec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.wyzyz swizzling.
        /// </summary>
        public ivec5 wyzyz => new ivec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.agbgb swizzling (equivalent to ivec4.wyzyz).
        /// </summary>
        public ivec5 agbgb => new ivec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.wyzyw swizzling.
        /// </summary>
        public ivec5 wyzyw => new ivec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.agbga swizzling (equivalent to ivec4.wyzyw).
        /// </summary>
        public ivec5 agbga => new ivec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.wyzz swizzling.
        /// </summary>
        public ivec4 wyzz => new ivec4(w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.agbb swizzling (equivalent to ivec4.wyzz).
        /// </summary>
        public ivec4 agbb => new ivec4(w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.wyzzx swizzling.
        /// </summary>
        public ivec5 wyzzx => new ivec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.agbbr swizzling (equivalent to ivec4.wyzzx).
        /// </summary>
        public ivec5 agbbr => new ivec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.wyzzy swizzling.
        /// </summary>
        public ivec5 wyzzy => new ivec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.agbbg swizzling (equivalent to ivec4.wyzzy).
        /// </summary>
        public ivec5 agbbg => new ivec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.wyzzz swizzling.
        /// </summary>
        public ivec5 wyzzz => new ivec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.agbbb swizzling (equivalent to ivec4.wyzzz).
        /// </summary>
        public ivec5 agbbb => new ivec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.wyzzw swizzling.
        /// </summary>
        public ivec5 wyzzw => new ivec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.agbba swizzling (equivalent to ivec4.wyzzw).
        /// </summary>
        public ivec5 agbba => new ivec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.wyzw swizzling.
        /// </summary>
        public ivec4 wyzw => new ivec4(w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.agba swizzling (equivalent to ivec4.wyzw).
        /// </summary>
        public ivec4 agba => new ivec4(w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.wyzwx swizzling.
        /// </summary>
        public ivec5 wyzwx => new ivec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.agbar swizzling (equivalent to ivec4.wyzwx).
        /// </summary>
        public ivec5 agbar => new ivec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.wyzwy swizzling.
        /// </summary>
        public ivec5 wyzwy => new ivec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.agbag swizzling (equivalent to ivec4.wyzwy).
        /// </summary>
        public ivec5 agbag => new ivec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.wyzwz swizzling.
        /// </summary>
        public ivec5 wyzwz => new ivec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.agbab swizzling (equivalent to ivec4.wyzwz).
        /// </summary>
        public ivec5 agbab => new ivec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.wyzww swizzling.
        /// </summary>
        public ivec5 wyzww => new ivec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.agbaa swizzling (equivalent to ivec4.wyzww).
        /// </summary>
        public ivec5 agbaa => new ivec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.wyw swizzling.
        /// </summary>
        public ivec3 wyw => new ivec3(w, y, w);
        
        /// <summary>
        /// Returns ivec4.aga swizzling (equivalent to ivec4.wyw).
        /// </summary>
        public ivec3 aga => new ivec3(w, y, w);
        
        /// <summary>
        /// Returns ivec4.wywx swizzling.
        /// </summary>
        public ivec4 wywx => new ivec4(w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.agar swizzling (equivalent to ivec4.wywx).
        /// </summary>
        public ivec4 agar => new ivec4(w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.wywxx swizzling.
        /// </summary>
        public ivec5 wywxx => new ivec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.agarr swizzling (equivalent to ivec4.wywxx).
        /// </summary>
        public ivec5 agarr => new ivec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.wywxy swizzling.
        /// </summary>
        public ivec5 wywxy => new ivec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.agarg swizzling (equivalent to ivec4.wywxy).
        /// </summary>
        public ivec5 agarg => new ivec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.wywxz swizzling.
        /// </summary>
        public ivec5 wywxz => new ivec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.agarb swizzling (equivalent to ivec4.wywxz).
        /// </summary>
        public ivec5 agarb => new ivec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.wywxw swizzling.
        /// </summary>
        public ivec5 wywxw => new ivec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.agara swizzling (equivalent to ivec4.wywxw).
        /// </summary>
        public ivec5 agara => new ivec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.wywy swizzling.
        /// </summary>
        public ivec4 wywy => new ivec4(w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.agag swizzling (equivalent to ivec4.wywy).
        /// </summary>
        public ivec4 agag => new ivec4(w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.wywyx swizzling.
        /// </summary>
        public ivec5 wywyx => new ivec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.agagr swizzling (equivalent to ivec4.wywyx).
        /// </summary>
        public ivec5 agagr => new ivec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.wywyy swizzling.
        /// </summary>
        public ivec5 wywyy => new ivec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.agagg swizzling (equivalent to ivec4.wywyy).
        /// </summary>
        public ivec5 agagg => new ivec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.wywyz swizzling.
        /// </summary>
        public ivec5 wywyz => new ivec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.agagb swizzling (equivalent to ivec4.wywyz).
        /// </summary>
        public ivec5 agagb => new ivec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.wywyw swizzling.
        /// </summary>
        public ivec5 wywyw => new ivec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.agaga swizzling (equivalent to ivec4.wywyw).
        /// </summary>
        public ivec5 agaga => new ivec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.wywz swizzling.
        /// </summary>
        public ivec4 wywz => new ivec4(w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.agab swizzling (equivalent to ivec4.wywz).
        /// </summary>
        public ivec4 agab => new ivec4(w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.wywzx swizzling.
        /// </summary>
        public ivec5 wywzx => new ivec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.agabr swizzling (equivalent to ivec4.wywzx).
        /// </summary>
        public ivec5 agabr => new ivec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.wywzy swizzling.
        /// </summary>
        public ivec5 wywzy => new ivec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.agabg swizzling (equivalent to ivec4.wywzy).
        /// </summary>
        public ivec5 agabg => new ivec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.wywzz swizzling.
        /// </summary>
        public ivec5 wywzz => new ivec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.agabb swizzling (equivalent to ivec4.wywzz).
        /// </summary>
        public ivec5 agabb => new ivec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.wywzw swizzling.
        /// </summary>
        public ivec5 wywzw => new ivec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.agaba swizzling (equivalent to ivec4.wywzw).
        /// </summary>
        public ivec5 agaba => new ivec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.wyww swizzling.
        /// </summary>
        public ivec4 wyww => new ivec4(w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.agaa swizzling (equivalent to ivec4.wyww).
        /// </summary>
        public ivec4 agaa => new ivec4(w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.wywwx swizzling.
        /// </summary>
        public ivec5 wywwx => new ivec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.agaar swizzling (equivalent to ivec4.wywwx).
        /// </summary>
        public ivec5 agaar => new ivec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.wywwy swizzling.
        /// </summary>
        public ivec5 wywwy => new ivec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.agaag swizzling (equivalent to ivec4.wywwy).
        /// </summary>
        public ivec5 agaag => new ivec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.wywwz swizzling.
        /// </summary>
        public ivec5 wywwz => new ivec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.agaab swizzling (equivalent to ivec4.wywwz).
        /// </summary>
        public ivec5 agaab => new ivec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.wywww swizzling.
        /// </summary>
        public ivec5 wywww => new ivec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.agaaa swizzling (equivalent to ivec4.wywww).
        /// </summary>
        public ivec5 agaaa => new ivec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.wz swizzling.
        /// </summary>
        public ivec2 wz => new ivec2(w, z);
        
        /// <summary>
        /// Returns ivec4.ab swizzling (equivalent to ivec4.wz).
        /// </summary>
        public ivec2 ab => new ivec2(w, z);
        
        /// <summary>
        /// Returns ivec4.wzx swizzling.
        /// </summary>
        public ivec3 wzx => new ivec3(w, z, x);
        
        /// <summary>
        /// Returns ivec4.abr swizzling (equivalent to ivec4.wzx).
        /// </summary>
        public ivec3 abr => new ivec3(w, z, x);
        
        /// <summary>
        /// Returns ivec4.wzxx swizzling.
        /// </summary>
        public ivec4 wzxx => new ivec4(w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.abrr swizzling (equivalent to ivec4.wzxx).
        /// </summary>
        public ivec4 abrr => new ivec4(w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.wzxxx swizzling.
        /// </summary>
        public ivec5 wzxxx => new ivec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.abrrr swizzling (equivalent to ivec4.wzxxx).
        /// </summary>
        public ivec5 abrrr => new ivec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.wzxxy swizzling.
        /// </summary>
        public ivec5 wzxxy => new ivec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.abrrg swizzling (equivalent to ivec4.wzxxy).
        /// </summary>
        public ivec5 abrrg => new ivec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.wzxxz swizzling.
        /// </summary>
        public ivec5 wzxxz => new ivec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.abrrb swizzling (equivalent to ivec4.wzxxz).
        /// </summary>
        public ivec5 abrrb => new ivec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.wzxxw swizzling.
        /// </summary>
        public ivec5 wzxxw => new ivec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.abrra swizzling (equivalent to ivec4.wzxxw).
        /// </summary>
        public ivec5 abrra => new ivec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.wzxy swizzling.
        /// </summary>
        public ivec4 wzxy => new ivec4(w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.abrg swizzling (equivalent to ivec4.wzxy).
        /// </summary>
        public ivec4 abrg => new ivec4(w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.wzxyx swizzling.
        /// </summary>
        public ivec5 wzxyx => new ivec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.abrgr swizzling (equivalent to ivec4.wzxyx).
        /// </summary>
        public ivec5 abrgr => new ivec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.wzxyy swizzling.
        /// </summary>
        public ivec5 wzxyy => new ivec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.abrgg swizzling (equivalent to ivec4.wzxyy).
        /// </summary>
        public ivec5 abrgg => new ivec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.wzxyz swizzling.
        /// </summary>
        public ivec5 wzxyz => new ivec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.abrgb swizzling (equivalent to ivec4.wzxyz).
        /// </summary>
        public ivec5 abrgb => new ivec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.wzxyw swizzling.
        /// </summary>
        public ivec5 wzxyw => new ivec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.abrga swizzling (equivalent to ivec4.wzxyw).
        /// </summary>
        public ivec5 abrga => new ivec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.wzxz swizzling.
        /// </summary>
        public ivec4 wzxz => new ivec4(w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.abrb swizzling (equivalent to ivec4.wzxz).
        /// </summary>
        public ivec4 abrb => new ivec4(w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.wzxzx swizzling.
        /// </summary>
        public ivec5 wzxzx => new ivec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.abrbr swizzling (equivalent to ivec4.wzxzx).
        /// </summary>
        public ivec5 abrbr => new ivec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.wzxzy swizzling.
        /// </summary>
        public ivec5 wzxzy => new ivec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.abrbg swizzling (equivalent to ivec4.wzxzy).
        /// </summary>
        public ivec5 abrbg => new ivec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.wzxzz swizzling.
        /// </summary>
        public ivec5 wzxzz => new ivec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.abrbb swizzling (equivalent to ivec4.wzxzz).
        /// </summary>
        public ivec5 abrbb => new ivec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.wzxzw swizzling.
        /// </summary>
        public ivec5 wzxzw => new ivec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.abrba swizzling (equivalent to ivec4.wzxzw).
        /// </summary>
        public ivec5 abrba => new ivec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.wzxw swizzling.
        /// </summary>
        public ivec4 wzxw => new ivec4(w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.abra swizzling (equivalent to ivec4.wzxw).
        /// </summary>
        public ivec4 abra => new ivec4(w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.wzxwx swizzling.
        /// </summary>
        public ivec5 wzxwx => new ivec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.abrar swizzling (equivalent to ivec4.wzxwx).
        /// </summary>
        public ivec5 abrar => new ivec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.wzxwy swizzling.
        /// </summary>
        public ivec5 wzxwy => new ivec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.abrag swizzling (equivalent to ivec4.wzxwy).
        /// </summary>
        public ivec5 abrag => new ivec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.wzxwz swizzling.
        /// </summary>
        public ivec5 wzxwz => new ivec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.abrab swizzling (equivalent to ivec4.wzxwz).
        /// </summary>
        public ivec5 abrab => new ivec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.wzxww swizzling.
        /// </summary>
        public ivec5 wzxww => new ivec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.abraa swizzling (equivalent to ivec4.wzxww).
        /// </summary>
        public ivec5 abraa => new ivec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.wzy swizzling.
        /// </summary>
        public ivec3 wzy => new ivec3(w, z, y);
        
        /// <summary>
        /// Returns ivec4.abg swizzling (equivalent to ivec4.wzy).
        /// </summary>
        public ivec3 abg => new ivec3(w, z, y);
        
        /// <summary>
        /// Returns ivec4.wzyx swizzling.
        /// </summary>
        public ivec4 wzyx => new ivec4(w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.abgr swizzling (equivalent to ivec4.wzyx).
        /// </summary>
        public ivec4 abgr => new ivec4(w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.wzyxx swizzling.
        /// </summary>
        public ivec5 wzyxx => new ivec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.abgrr swizzling (equivalent to ivec4.wzyxx).
        /// </summary>
        public ivec5 abgrr => new ivec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.wzyxy swizzling.
        /// </summary>
        public ivec5 wzyxy => new ivec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.abgrg swizzling (equivalent to ivec4.wzyxy).
        /// </summary>
        public ivec5 abgrg => new ivec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.wzyxz swizzling.
        /// </summary>
        public ivec5 wzyxz => new ivec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.abgrb swizzling (equivalent to ivec4.wzyxz).
        /// </summary>
        public ivec5 abgrb => new ivec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.wzyxw swizzling.
        /// </summary>
        public ivec5 wzyxw => new ivec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.abgra swizzling (equivalent to ivec4.wzyxw).
        /// </summary>
        public ivec5 abgra => new ivec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.wzyy swizzling.
        /// </summary>
        public ivec4 wzyy => new ivec4(w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.abgg swizzling (equivalent to ivec4.wzyy).
        /// </summary>
        public ivec4 abgg => new ivec4(w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.wzyyx swizzling.
        /// </summary>
        public ivec5 wzyyx => new ivec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.abggr swizzling (equivalent to ivec4.wzyyx).
        /// </summary>
        public ivec5 abggr => new ivec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.wzyyy swizzling.
        /// </summary>
        public ivec5 wzyyy => new ivec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.abggg swizzling (equivalent to ivec4.wzyyy).
        /// </summary>
        public ivec5 abggg => new ivec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.wzyyz swizzling.
        /// </summary>
        public ivec5 wzyyz => new ivec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.abggb swizzling (equivalent to ivec4.wzyyz).
        /// </summary>
        public ivec5 abggb => new ivec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.wzyyw swizzling.
        /// </summary>
        public ivec5 wzyyw => new ivec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.abgga swizzling (equivalent to ivec4.wzyyw).
        /// </summary>
        public ivec5 abgga => new ivec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.wzyz swizzling.
        /// </summary>
        public ivec4 wzyz => new ivec4(w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.abgb swizzling (equivalent to ivec4.wzyz).
        /// </summary>
        public ivec4 abgb => new ivec4(w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.wzyzx swizzling.
        /// </summary>
        public ivec5 wzyzx => new ivec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.abgbr swizzling (equivalent to ivec4.wzyzx).
        /// </summary>
        public ivec5 abgbr => new ivec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.wzyzy swizzling.
        /// </summary>
        public ivec5 wzyzy => new ivec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.abgbg swizzling (equivalent to ivec4.wzyzy).
        /// </summary>
        public ivec5 abgbg => new ivec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.wzyzz swizzling.
        /// </summary>
        public ivec5 wzyzz => new ivec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.abgbb swizzling (equivalent to ivec4.wzyzz).
        /// </summary>
        public ivec5 abgbb => new ivec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.wzyzw swizzling.
        /// </summary>
        public ivec5 wzyzw => new ivec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.abgba swizzling (equivalent to ivec4.wzyzw).
        /// </summary>
        public ivec5 abgba => new ivec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.wzyw swizzling.
        /// </summary>
        public ivec4 wzyw => new ivec4(w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.abga swizzling (equivalent to ivec4.wzyw).
        /// </summary>
        public ivec4 abga => new ivec4(w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.wzywx swizzling.
        /// </summary>
        public ivec5 wzywx => new ivec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.abgar swizzling (equivalent to ivec4.wzywx).
        /// </summary>
        public ivec5 abgar => new ivec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.wzywy swizzling.
        /// </summary>
        public ivec5 wzywy => new ivec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.abgag swizzling (equivalent to ivec4.wzywy).
        /// </summary>
        public ivec5 abgag => new ivec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.wzywz swizzling.
        /// </summary>
        public ivec5 wzywz => new ivec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.abgab swizzling (equivalent to ivec4.wzywz).
        /// </summary>
        public ivec5 abgab => new ivec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.wzyww swizzling.
        /// </summary>
        public ivec5 wzyww => new ivec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.abgaa swizzling (equivalent to ivec4.wzyww).
        /// </summary>
        public ivec5 abgaa => new ivec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.wzz swizzling.
        /// </summary>
        public ivec3 wzz => new ivec3(w, z, z);
        
        /// <summary>
        /// Returns ivec4.abb swizzling (equivalent to ivec4.wzz).
        /// </summary>
        public ivec3 abb => new ivec3(w, z, z);
        
        /// <summary>
        /// Returns ivec4.wzzx swizzling.
        /// </summary>
        public ivec4 wzzx => new ivec4(w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.abbr swizzling (equivalent to ivec4.wzzx).
        /// </summary>
        public ivec4 abbr => new ivec4(w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.wzzxx swizzling.
        /// </summary>
        public ivec5 wzzxx => new ivec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.abbrr swizzling (equivalent to ivec4.wzzxx).
        /// </summary>
        public ivec5 abbrr => new ivec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.wzzxy swizzling.
        /// </summary>
        public ivec5 wzzxy => new ivec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.abbrg swizzling (equivalent to ivec4.wzzxy).
        /// </summary>
        public ivec5 abbrg => new ivec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.wzzxz swizzling.
        /// </summary>
        public ivec5 wzzxz => new ivec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.abbrb swizzling (equivalent to ivec4.wzzxz).
        /// </summary>
        public ivec5 abbrb => new ivec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.wzzxw swizzling.
        /// </summary>
        public ivec5 wzzxw => new ivec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.abbra swizzling (equivalent to ivec4.wzzxw).
        /// </summary>
        public ivec5 abbra => new ivec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.wzzy swizzling.
        /// </summary>
        public ivec4 wzzy => new ivec4(w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.abbg swizzling (equivalent to ivec4.wzzy).
        /// </summary>
        public ivec4 abbg => new ivec4(w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.wzzyx swizzling.
        /// </summary>
        public ivec5 wzzyx => new ivec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.abbgr swizzling (equivalent to ivec4.wzzyx).
        /// </summary>
        public ivec5 abbgr => new ivec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.wzzyy swizzling.
        /// </summary>
        public ivec5 wzzyy => new ivec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.abbgg swizzling (equivalent to ivec4.wzzyy).
        /// </summary>
        public ivec5 abbgg => new ivec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.wzzyz swizzling.
        /// </summary>
        public ivec5 wzzyz => new ivec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.abbgb swizzling (equivalent to ivec4.wzzyz).
        /// </summary>
        public ivec5 abbgb => new ivec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.wzzyw swizzling.
        /// </summary>
        public ivec5 wzzyw => new ivec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.abbga swizzling (equivalent to ivec4.wzzyw).
        /// </summary>
        public ivec5 abbga => new ivec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.wzzz swizzling.
        /// </summary>
        public ivec4 wzzz => new ivec4(w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.abbb swizzling (equivalent to ivec4.wzzz).
        /// </summary>
        public ivec4 abbb => new ivec4(w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.wzzzx swizzling.
        /// </summary>
        public ivec5 wzzzx => new ivec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.abbbr swizzling (equivalent to ivec4.wzzzx).
        /// </summary>
        public ivec5 abbbr => new ivec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.wzzzy swizzling.
        /// </summary>
        public ivec5 wzzzy => new ivec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.abbbg swizzling (equivalent to ivec4.wzzzy).
        /// </summary>
        public ivec5 abbbg => new ivec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.wzzzz swizzling.
        /// </summary>
        public ivec5 wzzzz => new ivec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.abbbb swizzling (equivalent to ivec4.wzzzz).
        /// </summary>
        public ivec5 abbbb => new ivec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.wzzzw swizzling.
        /// </summary>
        public ivec5 wzzzw => new ivec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.abbba swizzling (equivalent to ivec4.wzzzw).
        /// </summary>
        public ivec5 abbba => new ivec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.wzzw swizzling.
        /// </summary>
        public ivec4 wzzw => new ivec4(w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.abba swizzling (equivalent to ivec4.wzzw).
        /// </summary>
        public ivec4 abba => new ivec4(w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.wzzwx swizzling.
        /// </summary>
        public ivec5 wzzwx => new ivec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.abbar swizzling (equivalent to ivec4.wzzwx).
        /// </summary>
        public ivec5 abbar => new ivec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.wzzwy swizzling.
        /// </summary>
        public ivec5 wzzwy => new ivec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.abbag swizzling (equivalent to ivec4.wzzwy).
        /// </summary>
        public ivec5 abbag => new ivec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.wzzwz swizzling.
        /// </summary>
        public ivec5 wzzwz => new ivec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.abbab swizzling (equivalent to ivec4.wzzwz).
        /// </summary>
        public ivec5 abbab => new ivec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.wzzww swizzling.
        /// </summary>
        public ivec5 wzzww => new ivec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.abbaa swizzling (equivalent to ivec4.wzzww).
        /// </summary>
        public ivec5 abbaa => new ivec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.wzw swizzling.
        /// </summary>
        public ivec3 wzw => new ivec3(w, z, w);
        
        /// <summary>
        /// Returns ivec4.aba swizzling (equivalent to ivec4.wzw).
        /// </summary>
        public ivec3 aba => new ivec3(w, z, w);
        
        /// <summary>
        /// Returns ivec4.wzwx swizzling.
        /// </summary>
        public ivec4 wzwx => new ivec4(w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.abar swizzling (equivalent to ivec4.wzwx).
        /// </summary>
        public ivec4 abar => new ivec4(w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.wzwxx swizzling.
        /// </summary>
        public ivec5 wzwxx => new ivec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.abarr swizzling (equivalent to ivec4.wzwxx).
        /// </summary>
        public ivec5 abarr => new ivec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.wzwxy swizzling.
        /// </summary>
        public ivec5 wzwxy => new ivec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.abarg swizzling (equivalent to ivec4.wzwxy).
        /// </summary>
        public ivec5 abarg => new ivec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.wzwxz swizzling.
        /// </summary>
        public ivec5 wzwxz => new ivec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.abarb swizzling (equivalent to ivec4.wzwxz).
        /// </summary>
        public ivec5 abarb => new ivec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.wzwxw swizzling.
        /// </summary>
        public ivec5 wzwxw => new ivec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.abara swizzling (equivalent to ivec4.wzwxw).
        /// </summary>
        public ivec5 abara => new ivec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.wzwy swizzling.
        /// </summary>
        public ivec4 wzwy => new ivec4(w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.abag swizzling (equivalent to ivec4.wzwy).
        /// </summary>
        public ivec4 abag => new ivec4(w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.wzwyx swizzling.
        /// </summary>
        public ivec5 wzwyx => new ivec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.abagr swizzling (equivalent to ivec4.wzwyx).
        /// </summary>
        public ivec5 abagr => new ivec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.wzwyy swizzling.
        /// </summary>
        public ivec5 wzwyy => new ivec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.abagg swizzling (equivalent to ivec4.wzwyy).
        /// </summary>
        public ivec5 abagg => new ivec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.wzwyz swizzling.
        /// </summary>
        public ivec5 wzwyz => new ivec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.abagb swizzling (equivalent to ivec4.wzwyz).
        /// </summary>
        public ivec5 abagb => new ivec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.wzwyw swizzling.
        /// </summary>
        public ivec5 wzwyw => new ivec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.abaga swizzling (equivalent to ivec4.wzwyw).
        /// </summary>
        public ivec5 abaga => new ivec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.wzwz swizzling.
        /// </summary>
        public ivec4 wzwz => new ivec4(w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.abab swizzling (equivalent to ivec4.wzwz).
        /// </summary>
        public ivec4 abab => new ivec4(w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.wzwzx swizzling.
        /// </summary>
        public ivec5 wzwzx => new ivec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.ababr swizzling (equivalent to ivec4.wzwzx).
        /// </summary>
        public ivec5 ababr => new ivec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.wzwzy swizzling.
        /// </summary>
        public ivec5 wzwzy => new ivec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.ababg swizzling (equivalent to ivec4.wzwzy).
        /// </summary>
        public ivec5 ababg => new ivec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.wzwzz swizzling.
        /// </summary>
        public ivec5 wzwzz => new ivec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.ababb swizzling (equivalent to ivec4.wzwzz).
        /// </summary>
        public ivec5 ababb => new ivec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.wzwzw swizzling.
        /// </summary>
        public ivec5 wzwzw => new ivec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.ababa swizzling (equivalent to ivec4.wzwzw).
        /// </summary>
        public ivec5 ababa => new ivec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.wzww swizzling.
        /// </summary>
        public ivec4 wzww => new ivec4(w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.abaa swizzling (equivalent to ivec4.wzww).
        /// </summary>
        public ivec4 abaa => new ivec4(w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.wzwwx swizzling.
        /// </summary>
        public ivec5 wzwwx => new ivec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.abaar swizzling (equivalent to ivec4.wzwwx).
        /// </summary>
        public ivec5 abaar => new ivec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.wzwwy swizzling.
        /// </summary>
        public ivec5 wzwwy => new ivec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.abaag swizzling (equivalent to ivec4.wzwwy).
        /// </summary>
        public ivec5 abaag => new ivec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.wzwwz swizzling.
        /// </summary>
        public ivec5 wzwwz => new ivec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.abaab swizzling (equivalent to ivec4.wzwwz).
        /// </summary>
        public ivec5 abaab => new ivec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.wzwww swizzling.
        /// </summary>
        public ivec5 wzwww => new ivec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.abaaa swizzling (equivalent to ivec4.wzwww).
        /// </summary>
        public ivec5 abaaa => new ivec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.ww swizzling.
        /// </summary>
        public ivec2 ww => new ivec2(w, w);
        
        /// <summary>
        /// Returns ivec4.aa swizzling (equivalent to ivec4.ww).
        /// </summary>
        public ivec2 aa => new ivec2(w, w);
        
        /// <summary>
        /// Returns ivec4.wwx swizzling.
        /// </summary>
        public ivec3 wwx => new ivec3(w, w, x);
        
        /// <summary>
        /// Returns ivec4.aar swizzling (equivalent to ivec4.wwx).
        /// </summary>
        public ivec3 aar => new ivec3(w, w, x);
        
        /// <summary>
        /// Returns ivec4.wwxx swizzling.
        /// </summary>
        public ivec4 wwxx => new ivec4(w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.aarr swizzling (equivalent to ivec4.wwxx).
        /// </summary>
        public ivec4 aarr => new ivec4(w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.wwxxx swizzling.
        /// </summary>
        public ivec5 wwxxx => new ivec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.aarrr swizzling (equivalent to ivec4.wwxxx).
        /// </summary>
        public ivec5 aarrr => new ivec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.wwxxy swizzling.
        /// </summary>
        public ivec5 wwxxy => new ivec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.aarrg swizzling (equivalent to ivec4.wwxxy).
        /// </summary>
        public ivec5 aarrg => new ivec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.wwxxz swizzling.
        /// </summary>
        public ivec5 wwxxz => new ivec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.aarrb swizzling (equivalent to ivec4.wwxxz).
        /// </summary>
        public ivec5 aarrb => new ivec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.wwxxw swizzling.
        /// </summary>
        public ivec5 wwxxw => new ivec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.aarra swizzling (equivalent to ivec4.wwxxw).
        /// </summary>
        public ivec5 aarra => new ivec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.wwxy swizzling.
        /// </summary>
        public ivec4 wwxy => new ivec4(w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.aarg swizzling (equivalent to ivec4.wwxy).
        /// </summary>
        public ivec4 aarg => new ivec4(w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.wwxyx swizzling.
        /// </summary>
        public ivec5 wwxyx => new ivec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.aargr swizzling (equivalent to ivec4.wwxyx).
        /// </summary>
        public ivec5 aargr => new ivec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.wwxyy swizzling.
        /// </summary>
        public ivec5 wwxyy => new ivec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.aargg swizzling (equivalent to ivec4.wwxyy).
        /// </summary>
        public ivec5 aargg => new ivec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.wwxyz swizzling.
        /// </summary>
        public ivec5 wwxyz => new ivec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.aargb swizzling (equivalent to ivec4.wwxyz).
        /// </summary>
        public ivec5 aargb => new ivec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.wwxyw swizzling.
        /// </summary>
        public ivec5 wwxyw => new ivec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.aarga swizzling (equivalent to ivec4.wwxyw).
        /// </summary>
        public ivec5 aarga => new ivec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.wwxz swizzling.
        /// </summary>
        public ivec4 wwxz => new ivec4(w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.aarb swizzling (equivalent to ivec4.wwxz).
        /// </summary>
        public ivec4 aarb => new ivec4(w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.wwxzx swizzling.
        /// </summary>
        public ivec5 wwxzx => new ivec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.aarbr swizzling (equivalent to ivec4.wwxzx).
        /// </summary>
        public ivec5 aarbr => new ivec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.wwxzy swizzling.
        /// </summary>
        public ivec5 wwxzy => new ivec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.aarbg swizzling (equivalent to ivec4.wwxzy).
        /// </summary>
        public ivec5 aarbg => new ivec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.wwxzz swizzling.
        /// </summary>
        public ivec5 wwxzz => new ivec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.aarbb swizzling (equivalent to ivec4.wwxzz).
        /// </summary>
        public ivec5 aarbb => new ivec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.wwxzw swizzling.
        /// </summary>
        public ivec5 wwxzw => new ivec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.aarba swizzling (equivalent to ivec4.wwxzw).
        /// </summary>
        public ivec5 aarba => new ivec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.wwxw swizzling.
        /// </summary>
        public ivec4 wwxw => new ivec4(w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.aara swizzling (equivalent to ivec4.wwxw).
        /// </summary>
        public ivec4 aara => new ivec4(w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.wwxwx swizzling.
        /// </summary>
        public ivec5 wwxwx => new ivec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.aarar swizzling (equivalent to ivec4.wwxwx).
        /// </summary>
        public ivec5 aarar => new ivec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.wwxwy swizzling.
        /// </summary>
        public ivec5 wwxwy => new ivec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.aarag swizzling (equivalent to ivec4.wwxwy).
        /// </summary>
        public ivec5 aarag => new ivec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.wwxwz swizzling.
        /// </summary>
        public ivec5 wwxwz => new ivec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.aarab swizzling (equivalent to ivec4.wwxwz).
        /// </summary>
        public ivec5 aarab => new ivec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.wwxww swizzling.
        /// </summary>
        public ivec5 wwxww => new ivec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.aaraa swizzling (equivalent to ivec4.wwxww).
        /// </summary>
        public ivec5 aaraa => new ivec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.wwy swizzling.
        /// </summary>
        public ivec3 wwy => new ivec3(w, w, y);
        
        /// <summary>
        /// Returns ivec4.aag swizzling (equivalent to ivec4.wwy).
        /// </summary>
        public ivec3 aag => new ivec3(w, w, y);
        
        /// <summary>
        /// Returns ivec4.wwyx swizzling.
        /// </summary>
        public ivec4 wwyx => new ivec4(w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.aagr swizzling (equivalent to ivec4.wwyx).
        /// </summary>
        public ivec4 aagr => new ivec4(w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.wwyxx swizzling.
        /// </summary>
        public ivec5 wwyxx => new ivec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.aagrr swizzling (equivalent to ivec4.wwyxx).
        /// </summary>
        public ivec5 aagrr => new ivec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.wwyxy swizzling.
        /// </summary>
        public ivec5 wwyxy => new ivec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.aagrg swizzling (equivalent to ivec4.wwyxy).
        /// </summary>
        public ivec5 aagrg => new ivec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.wwyxz swizzling.
        /// </summary>
        public ivec5 wwyxz => new ivec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.aagrb swizzling (equivalent to ivec4.wwyxz).
        /// </summary>
        public ivec5 aagrb => new ivec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.wwyxw swizzling.
        /// </summary>
        public ivec5 wwyxw => new ivec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.aagra swizzling (equivalent to ivec4.wwyxw).
        /// </summary>
        public ivec5 aagra => new ivec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.wwyy swizzling.
        /// </summary>
        public ivec4 wwyy => new ivec4(w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.aagg swizzling (equivalent to ivec4.wwyy).
        /// </summary>
        public ivec4 aagg => new ivec4(w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.wwyyx swizzling.
        /// </summary>
        public ivec5 wwyyx => new ivec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.aaggr swizzling (equivalent to ivec4.wwyyx).
        /// </summary>
        public ivec5 aaggr => new ivec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.wwyyy swizzling.
        /// </summary>
        public ivec5 wwyyy => new ivec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.aaggg swizzling (equivalent to ivec4.wwyyy).
        /// </summary>
        public ivec5 aaggg => new ivec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.wwyyz swizzling.
        /// </summary>
        public ivec5 wwyyz => new ivec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.aaggb swizzling (equivalent to ivec4.wwyyz).
        /// </summary>
        public ivec5 aaggb => new ivec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.wwyyw swizzling.
        /// </summary>
        public ivec5 wwyyw => new ivec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.aagga swizzling (equivalent to ivec4.wwyyw).
        /// </summary>
        public ivec5 aagga => new ivec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.wwyz swizzling.
        /// </summary>
        public ivec4 wwyz => new ivec4(w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.aagb swizzling (equivalent to ivec4.wwyz).
        /// </summary>
        public ivec4 aagb => new ivec4(w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.wwyzx swizzling.
        /// </summary>
        public ivec5 wwyzx => new ivec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.aagbr swizzling (equivalent to ivec4.wwyzx).
        /// </summary>
        public ivec5 aagbr => new ivec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.wwyzy swizzling.
        /// </summary>
        public ivec5 wwyzy => new ivec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.aagbg swizzling (equivalent to ivec4.wwyzy).
        /// </summary>
        public ivec5 aagbg => new ivec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.wwyzz swizzling.
        /// </summary>
        public ivec5 wwyzz => new ivec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.aagbb swizzling (equivalent to ivec4.wwyzz).
        /// </summary>
        public ivec5 aagbb => new ivec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.wwyzw swizzling.
        /// </summary>
        public ivec5 wwyzw => new ivec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.aagba swizzling (equivalent to ivec4.wwyzw).
        /// </summary>
        public ivec5 aagba => new ivec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.wwyw swizzling.
        /// </summary>
        public ivec4 wwyw => new ivec4(w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.aaga swizzling (equivalent to ivec4.wwyw).
        /// </summary>
        public ivec4 aaga => new ivec4(w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.wwywx swizzling.
        /// </summary>
        public ivec5 wwywx => new ivec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.aagar swizzling (equivalent to ivec4.wwywx).
        /// </summary>
        public ivec5 aagar => new ivec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.wwywy swizzling.
        /// </summary>
        public ivec5 wwywy => new ivec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.aagag swizzling (equivalent to ivec4.wwywy).
        /// </summary>
        public ivec5 aagag => new ivec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.wwywz swizzling.
        /// </summary>
        public ivec5 wwywz => new ivec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.aagab swizzling (equivalent to ivec4.wwywz).
        /// </summary>
        public ivec5 aagab => new ivec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.wwyww swizzling.
        /// </summary>
        public ivec5 wwyww => new ivec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.aagaa swizzling (equivalent to ivec4.wwyww).
        /// </summary>
        public ivec5 aagaa => new ivec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.wwz swizzling.
        /// </summary>
        public ivec3 wwz => new ivec3(w, w, z);
        
        /// <summary>
        /// Returns ivec4.aab swizzling (equivalent to ivec4.wwz).
        /// </summary>
        public ivec3 aab => new ivec3(w, w, z);
        
        /// <summary>
        /// Returns ivec4.wwzx swizzling.
        /// </summary>
        public ivec4 wwzx => new ivec4(w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.aabr swizzling (equivalent to ivec4.wwzx).
        /// </summary>
        public ivec4 aabr => new ivec4(w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.wwzxx swizzling.
        /// </summary>
        public ivec5 wwzxx => new ivec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.aabrr swizzling (equivalent to ivec4.wwzxx).
        /// </summary>
        public ivec5 aabrr => new ivec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.wwzxy swizzling.
        /// </summary>
        public ivec5 wwzxy => new ivec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.aabrg swizzling (equivalent to ivec4.wwzxy).
        /// </summary>
        public ivec5 aabrg => new ivec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.wwzxz swizzling.
        /// </summary>
        public ivec5 wwzxz => new ivec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.aabrb swizzling (equivalent to ivec4.wwzxz).
        /// </summary>
        public ivec5 aabrb => new ivec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.wwzxw swizzling.
        /// </summary>
        public ivec5 wwzxw => new ivec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.aabra swizzling (equivalent to ivec4.wwzxw).
        /// </summary>
        public ivec5 aabra => new ivec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.wwzy swizzling.
        /// </summary>
        public ivec4 wwzy => new ivec4(w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.aabg swizzling (equivalent to ivec4.wwzy).
        /// </summary>
        public ivec4 aabg => new ivec4(w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.wwzyx swizzling.
        /// </summary>
        public ivec5 wwzyx => new ivec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.aabgr swizzling (equivalent to ivec4.wwzyx).
        /// </summary>
        public ivec5 aabgr => new ivec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.wwzyy swizzling.
        /// </summary>
        public ivec5 wwzyy => new ivec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.aabgg swizzling (equivalent to ivec4.wwzyy).
        /// </summary>
        public ivec5 aabgg => new ivec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.wwzyz swizzling.
        /// </summary>
        public ivec5 wwzyz => new ivec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.aabgb swizzling (equivalent to ivec4.wwzyz).
        /// </summary>
        public ivec5 aabgb => new ivec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.wwzyw swizzling.
        /// </summary>
        public ivec5 wwzyw => new ivec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.aabga swizzling (equivalent to ivec4.wwzyw).
        /// </summary>
        public ivec5 aabga => new ivec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.wwzz swizzling.
        /// </summary>
        public ivec4 wwzz => new ivec4(w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.aabb swizzling (equivalent to ivec4.wwzz).
        /// </summary>
        public ivec4 aabb => new ivec4(w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.wwzzx swizzling.
        /// </summary>
        public ivec5 wwzzx => new ivec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.aabbr swizzling (equivalent to ivec4.wwzzx).
        /// </summary>
        public ivec5 aabbr => new ivec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.wwzzy swizzling.
        /// </summary>
        public ivec5 wwzzy => new ivec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.aabbg swizzling (equivalent to ivec4.wwzzy).
        /// </summary>
        public ivec5 aabbg => new ivec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.wwzzz swizzling.
        /// </summary>
        public ivec5 wwzzz => new ivec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.aabbb swizzling (equivalent to ivec4.wwzzz).
        /// </summary>
        public ivec5 aabbb => new ivec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.wwzzw swizzling.
        /// </summary>
        public ivec5 wwzzw => new ivec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.aabba swizzling (equivalent to ivec4.wwzzw).
        /// </summary>
        public ivec5 aabba => new ivec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.wwzw swizzling.
        /// </summary>
        public ivec4 wwzw => new ivec4(w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.aaba swizzling (equivalent to ivec4.wwzw).
        /// </summary>
        public ivec4 aaba => new ivec4(w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.wwzwx swizzling.
        /// </summary>
        public ivec5 wwzwx => new ivec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.aabar swizzling (equivalent to ivec4.wwzwx).
        /// </summary>
        public ivec5 aabar => new ivec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.wwzwy swizzling.
        /// </summary>
        public ivec5 wwzwy => new ivec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.aabag swizzling (equivalent to ivec4.wwzwy).
        /// </summary>
        public ivec5 aabag => new ivec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.wwzwz swizzling.
        /// </summary>
        public ivec5 wwzwz => new ivec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.aabab swizzling (equivalent to ivec4.wwzwz).
        /// </summary>
        public ivec5 aabab => new ivec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.wwzww swizzling.
        /// </summary>
        public ivec5 wwzww => new ivec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.aabaa swizzling (equivalent to ivec4.wwzww).
        /// </summary>
        public ivec5 aabaa => new ivec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.www swizzling.
        /// </summary>
        public ivec3 www => new ivec3(w, w, w);
        
        /// <summary>
        /// Returns ivec4.aaa swizzling (equivalent to ivec4.www).
        /// </summary>
        public ivec3 aaa => new ivec3(w, w, w);
        
        /// <summary>
        /// Returns ivec4.wwwx swizzling.
        /// </summary>
        public ivec4 wwwx => new ivec4(w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.aaar swizzling (equivalent to ivec4.wwwx).
        /// </summary>
        public ivec4 aaar => new ivec4(w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.wwwxx swizzling.
        /// </summary>
        public ivec5 wwwxx => new ivec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.aaarr swizzling (equivalent to ivec4.wwwxx).
        /// </summary>
        public ivec5 aaarr => new ivec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.wwwxy swizzling.
        /// </summary>
        public ivec5 wwwxy => new ivec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.aaarg swizzling (equivalent to ivec4.wwwxy).
        /// </summary>
        public ivec5 aaarg => new ivec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.wwwxz swizzling.
        /// </summary>
        public ivec5 wwwxz => new ivec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.aaarb swizzling (equivalent to ivec4.wwwxz).
        /// </summary>
        public ivec5 aaarb => new ivec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.wwwxw swizzling.
        /// </summary>
        public ivec5 wwwxw => new ivec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.aaara swizzling (equivalent to ivec4.wwwxw).
        /// </summary>
        public ivec5 aaara => new ivec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.wwwy swizzling.
        /// </summary>
        public ivec4 wwwy => new ivec4(w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.aaag swizzling (equivalent to ivec4.wwwy).
        /// </summary>
        public ivec4 aaag => new ivec4(w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.wwwyx swizzling.
        /// </summary>
        public ivec5 wwwyx => new ivec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.aaagr swizzling (equivalent to ivec4.wwwyx).
        /// </summary>
        public ivec5 aaagr => new ivec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.wwwyy swizzling.
        /// </summary>
        public ivec5 wwwyy => new ivec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.aaagg swizzling (equivalent to ivec4.wwwyy).
        /// </summary>
        public ivec5 aaagg => new ivec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.wwwyz swizzling.
        /// </summary>
        public ivec5 wwwyz => new ivec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.aaagb swizzling (equivalent to ivec4.wwwyz).
        /// </summary>
        public ivec5 aaagb => new ivec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.wwwyw swizzling.
        /// </summary>
        public ivec5 wwwyw => new ivec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.aaaga swizzling (equivalent to ivec4.wwwyw).
        /// </summary>
        public ivec5 aaaga => new ivec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.wwwz swizzling.
        /// </summary>
        public ivec4 wwwz => new ivec4(w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.aaab swizzling (equivalent to ivec4.wwwz).
        /// </summary>
        public ivec4 aaab => new ivec4(w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.wwwzx swizzling.
        /// </summary>
        public ivec5 wwwzx => new ivec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.aaabr swizzling (equivalent to ivec4.wwwzx).
        /// </summary>
        public ivec5 aaabr => new ivec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.wwwzy swizzling.
        /// </summary>
        public ivec5 wwwzy => new ivec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.aaabg swizzling (equivalent to ivec4.wwwzy).
        /// </summary>
        public ivec5 aaabg => new ivec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.wwwzz swizzling.
        /// </summary>
        public ivec5 wwwzz => new ivec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.aaabb swizzling (equivalent to ivec4.wwwzz).
        /// </summary>
        public ivec5 aaabb => new ivec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.wwwzw swizzling.
        /// </summary>
        public ivec5 wwwzw => new ivec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.aaaba swizzling (equivalent to ivec4.wwwzw).
        /// </summary>
        public ivec5 aaaba => new ivec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.wwww swizzling.
        /// </summary>
        public ivec4 wwww => new ivec4(w, w, w, w);
        
        /// <summary>
        /// Returns ivec4.aaaa swizzling (equivalent to ivec4.wwww).
        /// </summary>
        public ivec4 aaaa => new ivec4(w, w, w, w);
        
        /// <summary>
        /// Returns ivec4.wwwwx swizzling.
        /// </summary>
        public ivec5 wwwwx => new ivec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.aaaar swizzling (equivalent to ivec4.wwwwx).
        /// </summary>
        public ivec5 aaaar => new ivec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.wwwwy swizzling.
        /// </summary>
        public ivec5 wwwwy => new ivec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.aaaag swizzling (equivalent to ivec4.wwwwy).
        /// </summary>
        public ivec5 aaaag => new ivec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.wwwwz swizzling.
        /// </summary>
        public ivec5 wwwwz => new ivec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.aaaab swizzling (equivalent to ivec4.wwwwz).
        /// </summary>
        public ivec5 aaaab => new ivec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.wwwww swizzling.
        /// </summary>
        public ivec5 wwwww => new ivec5(w, w, w, w, w);
        
        /// <summary>
        /// Returns ivec4.aaaaa swizzling (equivalent to ivec4.wwwww).
        /// </summary>
        public ivec5 aaaaa => new ivec5(w, w, w, w, w);

        #endregion

    }
}
