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
    /// Temporary vector of type uint with 4 components, used for implementing swizzling for uvec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_uvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly uint x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly uint y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly uint z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly uint w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_uvec4.
        /// </summary>
        internal swizzle_uvec4(uint x, uint y, uint z, uint w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns uvec4.xx swizzling.
        /// </summary>
        public uvec2 xx => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec4.rr swizzling (equivalent to uvec4.xx).
        /// </summary>
        public uvec2 rr => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec4.xxx swizzling.
        /// </summary>
        public uvec3 xxx => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec4.rrr swizzling (equivalent to uvec4.xxx).
        /// </summary>
        public uvec3 rrr => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec4.xxxx swizzling.
        /// </summary>
        public uvec4 xxxx => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.rrrr swizzling (equivalent to uvec4.xxxx).
        /// </summary>
        public uvec4 rrrr => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.xxxxx swizzling.
        /// </summary>
        public uvec5 xxxxx => new uvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.rrrrr swizzling (equivalent to uvec4.xxxxx).
        /// </summary>
        public uvec5 rrrrr => new uvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.xxxxy swizzling.
        /// </summary>
        public uvec5 xxxxy => new uvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.rrrrg swizzling (equivalent to uvec4.xxxxy).
        /// </summary>
        public uvec5 rrrrg => new uvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.xxxxz swizzling.
        /// </summary>
        public uvec5 xxxxz => new uvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.rrrrb swizzling (equivalent to uvec4.xxxxz).
        /// </summary>
        public uvec5 rrrrb => new uvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.xxxxw swizzling.
        /// </summary>
        public uvec5 xxxxw => new uvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.rrrra swizzling (equivalent to uvec4.xxxxw).
        /// </summary>
        public uvec5 rrrra => new uvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.xxxy swizzling.
        /// </summary>
        public uvec4 xxxy => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.rrrg swizzling (equivalent to uvec4.xxxy).
        /// </summary>
        public uvec4 rrrg => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.xxxyx swizzling.
        /// </summary>
        public uvec5 xxxyx => new uvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.rrrgr swizzling (equivalent to uvec4.xxxyx).
        /// </summary>
        public uvec5 rrrgr => new uvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.xxxyy swizzling.
        /// </summary>
        public uvec5 xxxyy => new uvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.rrrgg swizzling (equivalent to uvec4.xxxyy).
        /// </summary>
        public uvec5 rrrgg => new uvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.xxxyz swizzling.
        /// </summary>
        public uvec5 xxxyz => new uvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.rrrgb swizzling (equivalent to uvec4.xxxyz).
        /// </summary>
        public uvec5 rrrgb => new uvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.xxxyw swizzling.
        /// </summary>
        public uvec5 xxxyw => new uvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.rrrga swizzling (equivalent to uvec4.xxxyw).
        /// </summary>
        public uvec5 rrrga => new uvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.xxxz swizzling.
        /// </summary>
        public uvec4 xxxz => new uvec4(x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.rrrb swizzling (equivalent to uvec4.xxxz).
        /// </summary>
        public uvec4 rrrb => new uvec4(x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.xxxzx swizzling.
        /// </summary>
        public uvec5 xxxzx => new uvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.rrrbr swizzling (equivalent to uvec4.xxxzx).
        /// </summary>
        public uvec5 rrrbr => new uvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.xxxzy swizzling.
        /// </summary>
        public uvec5 xxxzy => new uvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.rrrbg swizzling (equivalent to uvec4.xxxzy).
        /// </summary>
        public uvec5 rrrbg => new uvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.xxxzz swizzling.
        /// </summary>
        public uvec5 xxxzz => new uvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.rrrbb swizzling (equivalent to uvec4.xxxzz).
        /// </summary>
        public uvec5 rrrbb => new uvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.xxxzw swizzling.
        /// </summary>
        public uvec5 xxxzw => new uvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.rrrba swizzling (equivalent to uvec4.xxxzw).
        /// </summary>
        public uvec5 rrrba => new uvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.xxxw swizzling.
        /// </summary>
        public uvec4 xxxw => new uvec4(x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.rrra swizzling (equivalent to uvec4.xxxw).
        /// </summary>
        public uvec4 rrra => new uvec4(x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.xxxwx swizzling.
        /// </summary>
        public uvec5 xxxwx => new uvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.rrrar swizzling (equivalent to uvec4.xxxwx).
        /// </summary>
        public uvec5 rrrar => new uvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.xxxwy swizzling.
        /// </summary>
        public uvec5 xxxwy => new uvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.rrrag swizzling (equivalent to uvec4.xxxwy).
        /// </summary>
        public uvec5 rrrag => new uvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.xxxwz swizzling.
        /// </summary>
        public uvec5 xxxwz => new uvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.rrrab swizzling (equivalent to uvec4.xxxwz).
        /// </summary>
        public uvec5 rrrab => new uvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.xxxww swizzling.
        /// </summary>
        public uvec5 xxxww => new uvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.rrraa swizzling (equivalent to uvec4.xxxww).
        /// </summary>
        public uvec5 rrraa => new uvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.xxy swizzling.
        /// </summary>
        public uvec3 xxy => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec4.rrg swizzling (equivalent to uvec4.xxy).
        /// </summary>
        public uvec3 rrg => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec4.xxyx swizzling.
        /// </summary>
        public uvec4 xxyx => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.rrgr swizzling (equivalent to uvec4.xxyx).
        /// </summary>
        public uvec4 rrgr => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.xxyxx swizzling.
        /// </summary>
        public uvec5 xxyxx => new uvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.rrgrr swizzling (equivalent to uvec4.xxyxx).
        /// </summary>
        public uvec5 rrgrr => new uvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.xxyxy swizzling.
        /// </summary>
        public uvec5 xxyxy => new uvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.rrgrg swizzling (equivalent to uvec4.xxyxy).
        /// </summary>
        public uvec5 rrgrg => new uvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.xxyxz swizzling.
        /// </summary>
        public uvec5 xxyxz => new uvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.rrgrb swizzling (equivalent to uvec4.xxyxz).
        /// </summary>
        public uvec5 rrgrb => new uvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.xxyxw swizzling.
        /// </summary>
        public uvec5 xxyxw => new uvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.rrgra swizzling (equivalent to uvec4.xxyxw).
        /// </summary>
        public uvec5 rrgra => new uvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.xxyy swizzling.
        /// </summary>
        public uvec4 xxyy => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.rrgg swizzling (equivalent to uvec4.xxyy).
        /// </summary>
        public uvec4 rrgg => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.xxyyx swizzling.
        /// </summary>
        public uvec5 xxyyx => new uvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.rrggr swizzling (equivalent to uvec4.xxyyx).
        /// </summary>
        public uvec5 rrggr => new uvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.xxyyy swizzling.
        /// </summary>
        public uvec5 xxyyy => new uvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.rrggg swizzling (equivalent to uvec4.xxyyy).
        /// </summary>
        public uvec5 rrggg => new uvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.xxyyz swizzling.
        /// </summary>
        public uvec5 xxyyz => new uvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.rrggb swizzling (equivalent to uvec4.xxyyz).
        /// </summary>
        public uvec5 rrggb => new uvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.xxyyw swizzling.
        /// </summary>
        public uvec5 xxyyw => new uvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.rrgga swizzling (equivalent to uvec4.xxyyw).
        /// </summary>
        public uvec5 rrgga => new uvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.xxyz swizzling.
        /// </summary>
        public uvec4 xxyz => new uvec4(x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.rrgb swizzling (equivalent to uvec4.xxyz).
        /// </summary>
        public uvec4 rrgb => new uvec4(x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.xxyzx swizzling.
        /// </summary>
        public uvec5 xxyzx => new uvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.rrgbr swizzling (equivalent to uvec4.xxyzx).
        /// </summary>
        public uvec5 rrgbr => new uvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.xxyzy swizzling.
        /// </summary>
        public uvec5 xxyzy => new uvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.rrgbg swizzling (equivalent to uvec4.xxyzy).
        /// </summary>
        public uvec5 rrgbg => new uvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.xxyzz swizzling.
        /// </summary>
        public uvec5 xxyzz => new uvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.rrgbb swizzling (equivalent to uvec4.xxyzz).
        /// </summary>
        public uvec5 rrgbb => new uvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.xxyzw swizzling.
        /// </summary>
        public uvec5 xxyzw => new uvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.rrgba swizzling (equivalent to uvec4.xxyzw).
        /// </summary>
        public uvec5 rrgba => new uvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.xxyw swizzling.
        /// </summary>
        public uvec4 xxyw => new uvec4(x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.rrga swizzling (equivalent to uvec4.xxyw).
        /// </summary>
        public uvec4 rrga => new uvec4(x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.xxywx swizzling.
        /// </summary>
        public uvec5 xxywx => new uvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.rrgar swizzling (equivalent to uvec4.xxywx).
        /// </summary>
        public uvec5 rrgar => new uvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.xxywy swizzling.
        /// </summary>
        public uvec5 xxywy => new uvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.rrgag swizzling (equivalent to uvec4.xxywy).
        /// </summary>
        public uvec5 rrgag => new uvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.xxywz swizzling.
        /// </summary>
        public uvec5 xxywz => new uvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.rrgab swizzling (equivalent to uvec4.xxywz).
        /// </summary>
        public uvec5 rrgab => new uvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.xxyww swizzling.
        /// </summary>
        public uvec5 xxyww => new uvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.rrgaa swizzling (equivalent to uvec4.xxyww).
        /// </summary>
        public uvec5 rrgaa => new uvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.xxz swizzling.
        /// </summary>
        public uvec3 xxz => new uvec3(x, x, z);
        
        /// <summary>
        /// Returns uvec4.rrb swizzling (equivalent to uvec4.xxz).
        /// </summary>
        public uvec3 rrb => new uvec3(x, x, z);
        
        /// <summary>
        /// Returns uvec4.xxzx swizzling.
        /// </summary>
        public uvec4 xxzx => new uvec4(x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.rrbr swizzling (equivalent to uvec4.xxzx).
        /// </summary>
        public uvec4 rrbr => new uvec4(x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.xxzxx swizzling.
        /// </summary>
        public uvec5 xxzxx => new uvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.rrbrr swizzling (equivalent to uvec4.xxzxx).
        /// </summary>
        public uvec5 rrbrr => new uvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.xxzxy swizzling.
        /// </summary>
        public uvec5 xxzxy => new uvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.rrbrg swizzling (equivalent to uvec4.xxzxy).
        /// </summary>
        public uvec5 rrbrg => new uvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.xxzxz swizzling.
        /// </summary>
        public uvec5 xxzxz => new uvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.rrbrb swizzling (equivalent to uvec4.xxzxz).
        /// </summary>
        public uvec5 rrbrb => new uvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.xxzxw swizzling.
        /// </summary>
        public uvec5 xxzxw => new uvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.rrbra swizzling (equivalent to uvec4.xxzxw).
        /// </summary>
        public uvec5 rrbra => new uvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.xxzy swizzling.
        /// </summary>
        public uvec4 xxzy => new uvec4(x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.rrbg swizzling (equivalent to uvec4.xxzy).
        /// </summary>
        public uvec4 rrbg => new uvec4(x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.xxzyx swizzling.
        /// </summary>
        public uvec5 xxzyx => new uvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.rrbgr swizzling (equivalent to uvec4.xxzyx).
        /// </summary>
        public uvec5 rrbgr => new uvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.xxzyy swizzling.
        /// </summary>
        public uvec5 xxzyy => new uvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.rrbgg swizzling (equivalent to uvec4.xxzyy).
        /// </summary>
        public uvec5 rrbgg => new uvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.xxzyz swizzling.
        /// </summary>
        public uvec5 xxzyz => new uvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.rrbgb swizzling (equivalent to uvec4.xxzyz).
        /// </summary>
        public uvec5 rrbgb => new uvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.xxzyw swizzling.
        /// </summary>
        public uvec5 xxzyw => new uvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.rrbga swizzling (equivalent to uvec4.xxzyw).
        /// </summary>
        public uvec5 rrbga => new uvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.xxzz swizzling.
        /// </summary>
        public uvec4 xxzz => new uvec4(x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.rrbb swizzling (equivalent to uvec4.xxzz).
        /// </summary>
        public uvec4 rrbb => new uvec4(x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.xxzzx swizzling.
        /// </summary>
        public uvec5 xxzzx => new uvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.rrbbr swizzling (equivalent to uvec4.xxzzx).
        /// </summary>
        public uvec5 rrbbr => new uvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.xxzzy swizzling.
        /// </summary>
        public uvec5 xxzzy => new uvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.rrbbg swizzling (equivalent to uvec4.xxzzy).
        /// </summary>
        public uvec5 rrbbg => new uvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.xxzzz swizzling.
        /// </summary>
        public uvec5 xxzzz => new uvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.rrbbb swizzling (equivalent to uvec4.xxzzz).
        /// </summary>
        public uvec5 rrbbb => new uvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.xxzzw swizzling.
        /// </summary>
        public uvec5 xxzzw => new uvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.rrbba swizzling (equivalent to uvec4.xxzzw).
        /// </summary>
        public uvec5 rrbba => new uvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.xxzw swizzling.
        /// </summary>
        public uvec4 xxzw => new uvec4(x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.rrba swizzling (equivalent to uvec4.xxzw).
        /// </summary>
        public uvec4 rrba => new uvec4(x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.xxzwx swizzling.
        /// </summary>
        public uvec5 xxzwx => new uvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.rrbar swizzling (equivalent to uvec4.xxzwx).
        /// </summary>
        public uvec5 rrbar => new uvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.xxzwy swizzling.
        /// </summary>
        public uvec5 xxzwy => new uvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.rrbag swizzling (equivalent to uvec4.xxzwy).
        /// </summary>
        public uvec5 rrbag => new uvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.xxzwz swizzling.
        /// </summary>
        public uvec5 xxzwz => new uvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.rrbab swizzling (equivalent to uvec4.xxzwz).
        /// </summary>
        public uvec5 rrbab => new uvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.xxzww swizzling.
        /// </summary>
        public uvec5 xxzww => new uvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.rrbaa swizzling (equivalent to uvec4.xxzww).
        /// </summary>
        public uvec5 rrbaa => new uvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.xxw swizzling.
        /// </summary>
        public uvec3 xxw => new uvec3(x, x, w);
        
        /// <summary>
        /// Returns uvec4.rra swizzling (equivalent to uvec4.xxw).
        /// </summary>
        public uvec3 rra => new uvec3(x, x, w);
        
        /// <summary>
        /// Returns uvec4.xxwx swizzling.
        /// </summary>
        public uvec4 xxwx => new uvec4(x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.rrar swizzling (equivalent to uvec4.xxwx).
        /// </summary>
        public uvec4 rrar => new uvec4(x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.xxwxx swizzling.
        /// </summary>
        public uvec5 xxwxx => new uvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.rrarr swizzling (equivalent to uvec4.xxwxx).
        /// </summary>
        public uvec5 rrarr => new uvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.xxwxy swizzling.
        /// </summary>
        public uvec5 xxwxy => new uvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.rrarg swizzling (equivalent to uvec4.xxwxy).
        /// </summary>
        public uvec5 rrarg => new uvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.xxwxz swizzling.
        /// </summary>
        public uvec5 xxwxz => new uvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.rrarb swizzling (equivalent to uvec4.xxwxz).
        /// </summary>
        public uvec5 rrarb => new uvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.xxwxw swizzling.
        /// </summary>
        public uvec5 xxwxw => new uvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.rrara swizzling (equivalent to uvec4.xxwxw).
        /// </summary>
        public uvec5 rrara => new uvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.xxwy swizzling.
        /// </summary>
        public uvec4 xxwy => new uvec4(x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.rrag swizzling (equivalent to uvec4.xxwy).
        /// </summary>
        public uvec4 rrag => new uvec4(x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.xxwyx swizzling.
        /// </summary>
        public uvec5 xxwyx => new uvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.rragr swizzling (equivalent to uvec4.xxwyx).
        /// </summary>
        public uvec5 rragr => new uvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.xxwyy swizzling.
        /// </summary>
        public uvec5 xxwyy => new uvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.rragg swizzling (equivalent to uvec4.xxwyy).
        /// </summary>
        public uvec5 rragg => new uvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.xxwyz swizzling.
        /// </summary>
        public uvec5 xxwyz => new uvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.rragb swizzling (equivalent to uvec4.xxwyz).
        /// </summary>
        public uvec5 rragb => new uvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.xxwyw swizzling.
        /// </summary>
        public uvec5 xxwyw => new uvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.rraga swizzling (equivalent to uvec4.xxwyw).
        /// </summary>
        public uvec5 rraga => new uvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.xxwz swizzling.
        /// </summary>
        public uvec4 xxwz => new uvec4(x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.rrab swizzling (equivalent to uvec4.xxwz).
        /// </summary>
        public uvec4 rrab => new uvec4(x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.xxwzx swizzling.
        /// </summary>
        public uvec5 xxwzx => new uvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.rrabr swizzling (equivalent to uvec4.xxwzx).
        /// </summary>
        public uvec5 rrabr => new uvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.xxwzy swizzling.
        /// </summary>
        public uvec5 xxwzy => new uvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.rrabg swizzling (equivalent to uvec4.xxwzy).
        /// </summary>
        public uvec5 rrabg => new uvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.xxwzz swizzling.
        /// </summary>
        public uvec5 xxwzz => new uvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.rrabb swizzling (equivalent to uvec4.xxwzz).
        /// </summary>
        public uvec5 rrabb => new uvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.xxwzw swizzling.
        /// </summary>
        public uvec5 xxwzw => new uvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.rraba swizzling (equivalent to uvec4.xxwzw).
        /// </summary>
        public uvec5 rraba => new uvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.xxww swizzling.
        /// </summary>
        public uvec4 xxww => new uvec4(x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.rraa swizzling (equivalent to uvec4.xxww).
        /// </summary>
        public uvec4 rraa => new uvec4(x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.xxwwx swizzling.
        /// </summary>
        public uvec5 xxwwx => new uvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.rraar swizzling (equivalent to uvec4.xxwwx).
        /// </summary>
        public uvec5 rraar => new uvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.xxwwy swizzling.
        /// </summary>
        public uvec5 xxwwy => new uvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.rraag swizzling (equivalent to uvec4.xxwwy).
        /// </summary>
        public uvec5 rraag => new uvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.xxwwz swizzling.
        /// </summary>
        public uvec5 xxwwz => new uvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.rraab swizzling (equivalent to uvec4.xxwwz).
        /// </summary>
        public uvec5 rraab => new uvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.xxwww swizzling.
        /// </summary>
        public uvec5 xxwww => new uvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.rraaa swizzling (equivalent to uvec4.xxwww).
        /// </summary>
        public uvec5 rraaa => new uvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.xy swizzling.
        /// </summary>
        public uvec2 xy => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec4.rg swizzling (equivalent to uvec4.xy).
        /// </summary>
        public uvec2 rg => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec4.xyx swizzling.
        /// </summary>
        public uvec3 xyx => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec4.rgr swizzling (equivalent to uvec4.xyx).
        /// </summary>
        public uvec3 rgr => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec4.xyxx swizzling.
        /// </summary>
        public uvec4 xyxx => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.rgrr swizzling (equivalent to uvec4.xyxx).
        /// </summary>
        public uvec4 rgrr => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.xyxxx swizzling.
        /// </summary>
        public uvec5 xyxxx => new uvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.rgrrr swizzling (equivalent to uvec4.xyxxx).
        /// </summary>
        public uvec5 rgrrr => new uvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.xyxxy swizzling.
        /// </summary>
        public uvec5 xyxxy => new uvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.rgrrg swizzling (equivalent to uvec4.xyxxy).
        /// </summary>
        public uvec5 rgrrg => new uvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.xyxxz swizzling.
        /// </summary>
        public uvec5 xyxxz => new uvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.rgrrb swizzling (equivalent to uvec4.xyxxz).
        /// </summary>
        public uvec5 rgrrb => new uvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.xyxxw swizzling.
        /// </summary>
        public uvec5 xyxxw => new uvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.rgrra swizzling (equivalent to uvec4.xyxxw).
        /// </summary>
        public uvec5 rgrra => new uvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.xyxy swizzling.
        /// </summary>
        public uvec4 xyxy => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.rgrg swizzling (equivalent to uvec4.xyxy).
        /// </summary>
        public uvec4 rgrg => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.xyxyx swizzling.
        /// </summary>
        public uvec5 xyxyx => new uvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.rgrgr swizzling (equivalent to uvec4.xyxyx).
        /// </summary>
        public uvec5 rgrgr => new uvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.xyxyy swizzling.
        /// </summary>
        public uvec5 xyxyy => new uvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.rgrgg swizzling (equivalent to uvec4.xyxyy).
        /// </summary>
        public uvec5 rgrgg => new uvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.xyxyz swizzling.
        /// </summary>
        public uvec5 xyxyz => new uvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.rgrgb swizzling (equivalent to uvec4.xyxyz).
        /// </summary>
        public uvec5 rgrgb => new uvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.xyxyw swizzling.
        /// </summary>
        public uvec5 xyxyw => new uvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.rgrga swizzling (equivalent to uvec4.xyxyw).
        /// </summary>
        public uvec5 rgrga => new uvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.xyxz swizzling.
        /// </summary>
        public uvec4 xyxz => new uvec4(x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.rgrb swizzling (equivalent to uvec4.xyxz).
        /// </summary>
        public uvec4 rgrb => new uvec4(x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.xyxzx swizzling.
        /// </summary>
        public uvec5 xyxzx => new uvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.rgrbr swizzling (equivalent to uvec4.xyxzx).
        /// </summary>
        public uvec5 rgrbr => new uvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.xyxzy swizzling.
        /// </summary>
        public uvec5 xyxzy => new uvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.rgrbg swizzling (equivalent to uvec4.xyxzy).
        /// </summary>
        public uvec5 rgrbg => new uvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.xyxzz swizzling.
        /// </summary>
        public uvec5 xyxzz => new uvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.rgrbb swizzling (equivalent to uvec4.xyxzz).
        /// </summary>
        public uvec5 rgrbb => new uvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.xyxzw swizzling.
        /// </summary>
        public uvec5 xyxzw => new uvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.rgrba swizzling (equivalent to uvec4.xyxzw).
        /// </summary>
        public uvec5 rgrba => new uvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.xyxw swizzling.
        /// </summary>
        public uvec4 xyxw => new uvec4(x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.rgra swizzling (equivalent to uvec4.xyxw).
        /// </summary>
        public uvec4 rgra => new uvec4(x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.xyxwx swizzling.
        /// </summary>
        public uvec5 xyxwx => new uvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.rgrar swizzling (equivalent to uvec4.xyxwx).
        /// </summary>
        public uvec5 rgrar => new uvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.xyxwy swizzling.
        /// </summary>
        public uvec5 xyxwy => new uvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.rgrag swizzling (equivalent to uvec4.xyxwy).
        /// </summary>
        public uvec5 rgrag => new uvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.xyxwz swizzling.
        /// </summary>
        public uvec5 xyxwz => new uvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.rgrab swizzling (equivalent to uvec4.xyxwz).
        /// </summary>
        public uvec5 rgrab => new uvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.xyxww swizzling.
        /// </summary>
        public uvec5 xyxww => new uvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.rgraa swizzling (equivalent to uvec4.xyxww).
        /// </summary>
        public uvec5 rgraa => new uvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.xyy swizzling.
        /// </summary>
        public uvec3 xyy => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec4.rgg swizzling (equivalent to uvec4.xyy).
        /// </summary>
        public uvec3 rgg => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec4.xyyx swizzling.
        /// </summary>
        public uvec4 xyyx => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.rggr swizzling (equivalent to uvec4.xyyx).
        /// </summary>
        public uvec4 rggr => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.xyyxx swizzling.
        /// </summary>
        public uvec5 xyyxx => new uvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.rggrr swizzling (equivalent to uvec4.xyyxx).
        /// </summary>
        public uvec5 rggrr => new uvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.xyyxy swizzling.
        /// </summary>
        public uvec5 xyyxy => new uvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.rggrg swizzling (equivalent to uvec4.xyyxy).
        /// </summary>
        public uvec5 rggrg => new uvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.xyyxz swizzling.
        /// </summary>
        public uvec5 xyyxz => new uvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.rggrb swizzling (equivalent to uvec4.xyyxz).
        /// </summary>
        public uvec5 rggrb => new uvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.xyyxw swizzling.
        /// </summary>
        public uvec5 xyyxw => new uvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.rggra swizzling (equivalent to uvec4.xyyxw).
        /// </summary>
        public uvec5 rggra => new uvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.xyyy swizzling.
        /// </summary>
        public uvec4 xyyy => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.rggg swizzling (equivalent to uvec4.xyyy).
        /// </summary>
        public uvec4 rggg => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.xyyyx swizzling.
        /// </summary>
        public uvec5 xyyyx => new uvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.rgggr swizzling (equivalent to uvec4.xyyyx).
        /// </summary>
        public uvec5 rgggr => new uvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.xyyyy swizzling.
        /// </summary>
        public uvec5 xyyyy => new uvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.rgggg swizzling (equivalent to uvec4.xyyyy).
        /// </summary>
        public uvec5 rgggg => new uvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.xyyyz swizzling.
        /// </summary>
        public uvec5 xyyyz => new uvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.rgggb swizzling (equivalent to uvec4.xyyyz).
        /// </summary>
        public uvec5 rgggb => new uvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.xyyyw swizzling.
        /// </summary>
        public uvec5 xyyyw => new uvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.rggga swizzling (equivalent to uvec4.xyyyw).
        /// </summary>
        public uvec5 rggga => new uvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.xyyz swizzling.
        /// </summary>
        public uvec4 xyyz => new uvec4(x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.rggb swizzling (equivalent to uvec4.xyyz).
        /// </summary>
        public uvec4 rggb => new uvec4(x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.xyyzx swizzling.
        /// </summary>
        public uvec5 xyyzx => new uvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.rggbr swizzling (equivalent to uvec4.xyyzx).
        /// </summary>
        public uvec5 rggbr => new uvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.xyyzy swizzling.
        /// </summary>
        public uvec5 xyyzy => new uvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.rggbg swizzling (equivalent to uvec4.xyyzy).
        /// </summary>
        public uvec5 rggbg => new uvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.xyyzz swizzling.
        /// </summary>
        public uvec5 xyyzz => new uvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.rggbb swizzling (equivalent to uvec4.xyyzz).
        /// </summary>
        public uvec5 rggbb => new uvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.xyyzw swizzling.
        /// </summary>
        public uvec5 xyyzw => new uvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.rggba swizzling (equivalent to uvec4.xyyzw).
        /// </summary>
        public uvec5 rggba => new uvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.xyyw swizzling.
        /// </summary>
        public uvec4 xyyw => new uvec4(x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.rgga swizzling (equivalent to uvec4.xyyw).
        /// </summary>
        public uvec4 rgga => new uvec4(x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.xyywx swizzling.
        /// </summary>
        public uvec5 xyywx => new uvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.rggar swizzling (equivalent to uvec4.xyywx).
        /// </summary>
        public uvec5 rggar => new uvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.xyywy swizzling.
        /// </summary>
        public uvec5 xyywy => new uvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.rggag swizzling (equivalent to uvec4.xyywy).
        /// </summary>
        public uvec5 rggag => new uvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.xyywz swizzling.
        /// </summary>
        public uvec5 xyywz => new uvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.rggab swizzling (equivalent to uvec4.xyywz).
        /// </summary>
        public uvec5 rggab => new uvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.xyyww swizzling.
        /// </summary>
        public uvec5 xyyww => new uvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.rggaa swizzling (equivalent to uvec4.xyyww).
        /// </summary>
        public uvec5 rggaa => new uvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.xyz swizzling.
        /// </summary>
        public uvec3 xyz => new uvec3(x, y, z);
        
        /// <summary>
        /// Returns uvec4.rgb swizzling (equivalent to uvec4.xyz).
        /// </summary>
        public uvec3 rgb => new uvec3(x, y, z);
        
        /// <summary>
        /// Returns uvec4.xyzx swizzling.
        /// </summary>
        public uvec4 xyzx => new uvec4(x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.rgbr swizzling (equivalent to uvec4.xyzx).
        /// </summary>
        public uvec4 rgbr => new uvec4(x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.xyzxx swizzling.
        /// </summary>
        public uvec5 xyzxx => new uvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.rgbrr swizzling (equivalent to uvec4.xyzxx).
        /// </summary>
        public uvec5 rgbrr => new uvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.xyzxy swizzling.
        /// </summary>
        public uvec5 xyzxy => new uvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.rgbrg swizzling (equivalent to uvec4.xyzxy).
        /// </summary>
        public uvec5 rgbrg => new uvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.xyzxz swizzling.
        /// </summary>
        public uvec5 xyzxz => new uvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.rgbrb swizzling (equivalent to uvec4.xyzxz).
        /// </summary>
        public uvec5 rgbrb => new uvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.xyzxw swizzling.
        /// </summary>
        public uvec5 xyzxw => new uvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.rgbra swizzling (equivalent to uvec4.xyzxw).
        /// </summary>
        public uvec5 rgbra => new uvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.xyzy swizzling.
        /// </summary>
        public uvec4 xyzy => new uvec4(x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.rgbg swizzling (equivalent to uvec4.xyzy).
        /// </summary>
        public uvec4 rgbg => new uvec4(x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.xyzyx swizzling.
        /// </summary>
        public uvec5 xyzyx => new uvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.rgbgr swizzling (equivalent to uvec4.xyzyx).
        /// </summary>
        public uvec5 rgbgr => new uvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.xyzyy swizzling.
        /// </summary>
        public uvec5 xyzyy => new uvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.rgbgg swizzling (equivalent to uvec4.xyzyy).
        /// </summary>
        public uvec5 rgbgg => new uvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.xyzyz swizzling.
        /// </summary>
        public uvec5 xyzyz => new uvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.rgbgb swizzling (equivalent to uvec4.xyzyz).
        /// </summary>
        public uvec5 rgbgb => new uvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.xyzyw swizzling.
        /// </summary>
        public uvec5 xyzyw => new uvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.rgbga swizzling (equivalent to uvec4.xyzyw).
        /// </summary>
        public uvec5 rgbga => new uvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.xyzz swizzling.
        /// </summary>
        public uvec4 xyzz => new uvec4(x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.rgbb swizzling (equivalent to uvec4.xyzz).
        /// </summary>
        public uvec4 rgbb => new uvec4(x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.xyzzx swizzling.
        /// </summary>
        public uvec5 xyzzx => new uvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.rgbbr swizzling (equivalent to uvec4.xyzzx).
        /// </summary>
        public uvec5 rgbbr => new uvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.xyzzy swizzling.
        /// </summary>
        public uvec5 xyzzy => new uvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.rgbbg swizzling (equivalent to uvec4.xyzzy).
        /// </summary>
        public uvec5 rgbbg => new uvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.xyzzz swizzling.
        /// </summary>
        public uvec5 xyzzz => new uvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.rgbbb swizzling (equivalent to uvec4.xyzzz).
        /// </summary>
        public uvec5 rgbbb => new uvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.xyzzw swizzling.
        /// </summary>
        public uvec5 xyzzw => new uvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.rgbba swizzling (equivalent to uvec4.xyzzw).
        /// </summary>
        public uvec5 rgbba => new uvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.xyzw swizzling.
        /// </summary>
        public uvec4 xyzw => new uvec4(x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.rgba swizzling (equivalent to uvec4.xyzw).
        /// </summary>
        public uvec4 rgba => new uvec4(x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.xyzwx swizzling.
        /// </summary>
        public uvec5 xyzwx => new uvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.rgbar swizzling (equivalent to uvec4.xyzwx).
        /// </summary>
        public uvec5 rgbar => new uvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.xyzwy swizzling.
        /// </summary>
        public uvec5 xyzwy => new uvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.rgbag swizzling (equivalent to uvec4.xyzwy).
        /// </summary>
        public uvec5 rgbag => new uvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.xyzwz swizzling.
        /// </summary>
        public uvec5 xyzwz => new uvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.rgbab swizzling (equivalent to uvec4.xyzwz).
        /// </summary>
        public uvec5 rgbab => new uvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.xyzww swizzling.
        /// </summary>
        public uvec5 xyzww => new uvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.rgbaa swizzling (equivalent to uvec4.xyzww).
        /// </summary>
        public uvec5 rgbaa => new uvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.xyw swizzling.
        /// </summary>
        public uvec3 xyw => new uvec3(x, y, w);
        
        /// <summary>
        /// Returns uvec4.rga swizzling (equivalent to uvec4.xyw).
        /// </summary>
        public uvec3 rga => new uvec3(x, y, w);
        
        /// <summary>
        /// Returns uvec4.xywx swizzling.
        /// </summary>
        public uvec4 xywx => new uvec4(x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.rgar swizzling (equivalent to uvec4.xywx).
        /// </summary>
        public uvec4 rgar => new uvec4(x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.xywxx swizzling.
        /// </summary>
        public uvec5 xywxx => new uvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.rgarr swizzling (equivalent to uvec4.xywxx).
        /// </summary>
        public uvec5 rgarr => new uvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.xywxy swizzling.
        /// </summary>
        public uvec5 xywxy => new uvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.rgarg swizzling (equivalent to uvec4.xywxy).
        /// </summary>
        public uvec5 rgarg => new uvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.xywxz swizzling.
        /// </summary>
        public uvec5 xywxz => new uvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.rgarb swizzling (equivalent to uvec4.xywxz).
        /// </summary>
        public uvec5 rgarb => new uvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.xywxw swizzling.
        /// </summary>
        public uvec5 xywxw => new uvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.rgara swizzling (equivalent to uvec4.xywxw).
        /// </summary>
        public uvec5 rgara => new uvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.xywy swizzling.
        /// </summary>
        public uvec4 xywy => new uvec4(x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.rgag swizzling (equivalent to uvec4.xywy).
        /// </summary>
        public uvec4 rgag => new uvec4(x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.xywyx swizzling.
        /// </summary>
        public uvec5 xywyx => new uvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.rgagr swizzling (equivalent to uvec4.xywyx).
        /// </summary>
        public uvec5 rgagr => new uvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.xywyy swizzling.
        /// </summary>
        public uvec5 xywyy => new uvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.rgagg swizzling (equivalent to uvec4.xywyy).
        /// </summary>
        public uvec5 rgagg => new uvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.xywyz swizzling.
        /// </summary>
        public uvec5 xywyz => new uvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.rgagb swizzling (equivalent to uvec4.xywyz).
        /// </summary>
        public uvec5 rgagb => new uvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.xywyw swizzling.
        /// </summary>
        public uvec5 xywyw => new uvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.rgaga swizzling (equivalent to uvec4.xywyw).
        /// </summary>
        public uvec5 rgaga => new uvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.xywz swizzling.
        /// </summary>
        public uvec4 xywz => new uvec4(x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.rgab swizzling (equivalent to uvec4.xywz).
        /// </summary>
        public uvec4 rgab => new uvec4(x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.xywzx swizzling.
        /// </summary>
        public uvec5 xywzx => new uvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.rgabr swizzling (equivalent to uvec4.xywzx).
        /// </summary>
        public uvec5 rgabr => new uvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.xywzy swizzling.
        /// </summary>
        public uvec5 xywzy => new uvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.rgabg swizzling (equivalent to uvec4.xywzy).
        /// </summary>
        public uvec5 rgabg => new uvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.xywzz swizzling.
        /// </summary>
        public uvec5 xywzz => new uvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.rgabb swizzling (equivalent to uvec4.xywzz).
        /// </summary>
        public uvec5 rgabb => new uvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.xywzw swizzling.
        /// </summary>
        public uvec5 xywzw => new uvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.rgaba swizzling (equivalent to uvec4.xywzw).
        /// </summary>
        public uvec5 rgaba => new uvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.xyww swizzling.
        /// </summary>
        public uvec4 xyww => new uvec4(x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.rgaa swizzling (equivalent to uvec4.xyww).
        /// </summary>
        public uvec4 rgaa => new uvec4(x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.xywwx swizzling.
        /// </summary>
        public uvec5 xywwx => new uvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.rgaar swizzling (equivalent to uvec4.xywwx).
        /// </summary>
        public uvec5 rgaar => new uvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.xywwy swizzling.
        /// </summary>
        public uvec5 xywwy => new uvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.rgaag swizzling (equivalent to uvec4.xywwy).
        /// </summary>
        public uvec5 rgaag => new uvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.xywwz swizzling.
        /// </summary>
        public uvec5 xywwz => new uvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.rgaab swizzling (equivalent to uvec4.xywwz).
        /// </summary>
        public uvec5 rgaab => new uvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.xywww swizzling.
        /// </summary>
        public uvec5 xywww => new uvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.rgaaa swizzling (equivalent to uvec4.xywww).
        /// </summary>
        public uvec5 rgaaa => new uvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.xz swizzling.
        /// </summary>
        public uvec2 xz => new uvec2(x, z);
        
        /// <summary>
        /// Returns uvec4.rb swizzling (equivalent to uvec4.xz).
        /// </summary>
        public uvec2 rb => new uvec2(x, z);
        
        /// <summary>
        /// Returns uvec4.xzx swizzling.
        /// </summary>
        public uvec3 xzx => new uvec3(x, z, x);
        
        /// <summary>
        /// Returns uvec4.rbr swizzling (equivalent to uvec4.xzx).
        /// </summary>
        public uvec3 rbr => new uvec3(x, z, x);
        
        /// <summary>
        /// Returns uvec4.xzxx swizzling.
        /// </summary>
        public uvec4 xzxx => new uvec4(x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.rbrr swizzling (equivalent to uvec4.xzxx).
        /// </summary>
        public uvec4 rbrr => new uvec4(x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.xzxxx swizzling.
        /// </summary>
        public uvec5 xzxxx => new uvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.rbrrr swizzling (equivalent to uvec4.xzxxx).
        /// </summary>
        public uvec5 rbrrr => new uvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.xzxxy swizzling.
        /// </summary>
        public uvec5 xzxxy => new uvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.rbrrg swizzling (equivalent to uvec4.xzxxy).
        /// </summary>
        public uvec5 rbrrg => new uvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.xzxxz swizzling.
        /// </summary>
        public uvec5 xzxxz => new uvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.rbrrb swizzling (equivalent to uvec4.xzxxz).
        /// </summary>
        public uvec5 rbrrb => new uvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.xzxxw swizzling.
        /// </summary>
        public uvec5 xzxxw => new uvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.rbrra swizzling (equivalent to uvec4.xzxxw).
        /// </summary>
        public uvec5 rbrra => new uvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.xzxy swizzling.
        /// </summary>
        public uvec4 xzxy => new uvec4(x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.rbrg swizzling (equivalent to uvec4.xzxy).
        /// </summary>
        public uvec4 rbrg => new uvec4(x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.xzxyx swizzling.
        /// </summary>
        public uvec5 xzxyx => new uvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.rbrgr swizzling (equivalent to uvec4.xzxyx).
        /// </summary>
        public uvec5 rbrgr => new uvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.xzxyy swizzling.
        /// </summary>
        public uvec5 xzxyy => new uvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.rbrgg swizzling (equivalent to uvec4.xzxyy).
        /// </summary>
        public uvec5 rbrgg => new uvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.xzxyz swizzling.
        /// </summary>
        public uvec5 xzxyz => new uvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.rbrgb swizzling (equivalent to uvec4.xzxyz).
        /// </summary>
        public uvec5 rbrgb => new uvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.xzxyw swizzling.
        /// </summary>
        public uvec5 xzxyw => new uvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.rbrga swizzling (equivalent to uvec4.xzxyw).
        /// </summary>
        public uvec5 rbrga => new uvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.xzxz swizzling.
        /// </summary>
        public uvec4 xzxz => new uvec4(x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.rbrb swizzling (equivalent to uvec4.xzxz).
        /// </summary>
        public uvec4 rbrb => new uvec4(x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.xzxzx swizzling.
        /// </summary>
        public uvec5 xzxzx => new uvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.rbrbr swizzling (equivalent to uvec4.xzxzx).
        /// </summary>
        public uvec5 rbrbr => new uvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.xzxzy swizzling.
        /// </summary>
        public uvec5 xzxzy => new uvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.rbrbg swizzling (equivalent to uvec4.xzxzy).
        /// </summary>
        public uvec5 rbrbg => new uvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.xzxzz swizzling.
        /// </summary>
        public uvec5 xzxzz => new uvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.rbrbb swizzling (equivalent to uvec4.xzxzz).
        /// </summary>
        public uvec5 rbrbb => new uvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.xzxzw swizzling.
        /// </summary>
        public uvec5 xzxzw => new uvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.rbrba swizzling (equivalent to uvec4.xzxzw).
        /// </summary>
        public uvec5 rbrba => new uvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.xzxw swizzling.
        /// </summary>
        public uvec4 xzxw => new uvec4(x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.rbra swizzling (equivalent to uvec4.xzxw).
        /// </summary>
        public uvec4 rbra => new uvec4(x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.xzxwx swizzling.
        /// </summary>
        public uvec5 xzxwx => new uvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.rbrar swizzling (equivalent to uvec4.xzxwx).
        /// </summary>
        public uvec5 rbrar => new uvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.xzxwy swizzling.
        /// </summary>
        public uvec5 xzxwy => new uvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.rbrag swizzling (equivalent to uvec4.xzxwy).
        /// </summary>
        public uvec5 rbrag => new uvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.xzxwz swizzling.
        /// </summary>
        public uvec5 xzxwz => new uvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.rbrab swizzling (equivalent to uvec4.xzxwz).
        /// </summary>
        public uvec5 rbrab => new uvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.xzxww swizzling.
        /// </summary>
        public uvec5 xzxww => new uvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.rbraa swizzling (equivalent to uvec4.xzxww).
        /// </summary>
        public uvec5 rbraa => new uvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.xzy swizzling.
        /// </summary>
        public uvec3 xzy => new uvec3(x, z, y);
        
        /// <summary>
        /// Returns uvec4.rbg swizzling (equivalent to uvec4.xzy).
        /// </summary>
        public uvec3 rbg => new uvec3(x, z, y);
        
        /// <summary>
        /// Returns uvec4.xzyx swizzling.
        /// </summary>
        public uvec4 xzyx => new uvec4(x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.rbgr swizzling (equivalent to uvec4.xzyx).
        /// </summary>
        public uvec4 rbgr => new uvec4(x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.xzyxx swizzling.
        /// </summary>
        public uvec5 xzyxx => new uvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.rbgrr swizzling (equivalent to uvec4.xzyxx).
        /// </summary>
        public uvec5 rbgrr => new uvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.xzyxy swizzling.
        /// </summary>
        public uvec5 xzyxy => new uvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.rbgrg swizzling (equivalent to uvec4.xzyxy).
        /// </summary>
        public uvec5 rbgrg => new uvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.xzyxz swizzling.
        /// </summary>
        public uvec5 xzyxz => new uvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.rbgrb swizzling (equivalent to uvec4.xzyxz).
        /// </summary>
        public uvec5 rbgrb => new uvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.xzyxw swizzling.
        /// </summary>
        public uvec5 xzyxw => new uvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.rbgra swizzling (equivalent to uvec4.xzyxw).
        /// </summary>
        public uvec5 rbgra => new uvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.xzyy swizzling.
        /// </summary>
        public uvec4 xzyy => new uvec4(x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.rbgg swizzling (equivalent to uvec4.xzyy).
        /// </summary>
        public uvec4 rbgg => new uvec4(x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.xzyyx swizzling.
        /// </summary>
        public uvec5 xzyyx => new uvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.rbggr swizzling (equivalent to uvec4.xzyyx).
        /// </summary>
        public uvec5 rbggr => new uvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.xzyyy swizzling.
        /// </summary>
        public uvec5 xzyyy => new uvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.rbggg swizzling (equivalent to uvec4.xzyyy).
        /// </summary>
        public uvec5 rbggg => new uvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.xzyyz swizzling.
        /// </summary>
        public uvec5 xzyyz => new uvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.rbggb swizzling (equivalent to uvec4.xzyyz).
        /// </summary>
        public uvec5 rbggb => new uvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.xzyyw swizzling.
        /// </summary>
        public uvec5 xzyyw => new uvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.rbgga swizzling (equivalent to uvec4.xzyyw).
        /// </summary>
        public uvec5 rbgga => new uvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.xzyz swizzling.
        /// </summary>
        public uvec4 xzyz => new uvec4(x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.rbgb swizzling (equivalent to uvec4.xzyz).
        /// </summary>
        public uvec4 rbgb => new uvec4(x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.xzyzx swizzling.
        /// </summary>
        public uvec5 xzyzx => new uvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.rbgbr swizzling (equivalent to uvec4.xzyzx).
        /// </summary>
        public uvec5 rbgbr => new uvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.xzyzy swizzling.
        /// </summary>
        public uvec5 xzyzy => new uvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.rbgbg swizzling (equivalent to uvec4.xzyzy).
        /// </summary>
        public uvec5 rbgbg => new uvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.xzyzz swizzling.
        /// </summary>
        public uvec5 xzyzz => new uvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.rbgbb swizzling (equivalent to uvec4.xzyzz).
        /// </summary>
        public uvec5 rbgbb => new uvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.xzyzw swizzling.
        /// </summary>
        public uvec5 xzyzw => new uvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.rbgba swizzling (equivalent to uvec4.xzyzw).
        /// </summary>
        public uvec5 rbgba => new uvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.xzyw swizzling.
        /// </summary>
        public uvec4 xzyw => new uvec4(x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.rbga swizzling (equivalent to uvec4.xzyw).
        /// </summary>
        public uvec4 rbga => new uvec4(x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.xzywx swizzling.
        /// </summary>
        public uvec5 xzywx => new uvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.rbgar swizzling (equivalent to uvec4.xzywx).
        /// </summary>
        public uvec5 rbgar => new uvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.xzywy swizzling.
        /// </summary>
        public uvec5 xzywy => new uvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.rbgag swizzling (equivalent to uvec4.xzywy).
        /// </summary>
        public uvec5 rbgag => new uvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.xzywz swizzling.
        /// </summary>
        public uvec5 xzywz => new uvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.rbgab swizzling (equivalent to uvec4.xzywz).
        /// </summary>
        public uvec5 rbgab => new uvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.xzyww swizzling.
        /// </summary>
        public uvec5 xzyww => new uvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.rbgaa swizzling (equivalent to uvec4.xzyww).
        /// </summary>
        public uvec5 rbgaa => new uvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.xzz swizzling.
        /// </summary>
        public uvec3 xzz => new uvec3(x, z, z);
        
        /// <summary>
        /// Returns uvec4.rbb swizzling (equivalent to uvec4.xzz).
        /// </summary>
        public uvec3 rbb => new uvec3(x, z, z);
        
        /// <summary>
        /// Returns uvec4.xzzx swizzling.
        /// </summary>
        public uvec4 xzzx => new uvec4(x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.rbbr swizzling (equivalent to uvec4.xzzx).
        /// </summary>
        public uvec4 rbbr => new uvec4(x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.xzzxx swizzling.
        /// </summary>
        public uvec5 xzzxx => new uvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.rbbrr swizzling (equivalent to uvec4.xzzxx).
        /// </summary>
        public uvec5 rbbrr => new uvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.xzzxy swizzling.
        /// </summary>
        public uvec5 xzzxy => new uvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.rbbrg swizzling (equivalent to uvec4.xzzxy).
        /// </summary>
        public uvec5 rbbrg => new uvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.xzzxz swizzling.
        /// </summary>
        public uvec5 xzzxz => new uvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.rbbrb swizzling (equivalent to uvec4.xzzxz).
        /// </summary>
        public uvec5 rbbrb => new uvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.xzzxw swizzling.
        /// </summary>
        public uvec5 xzzxw => new uvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.rbbra swizzling (equivalent to uvec4.xzzxw).
        /// </summary>
        public uvec5 rbbra => new uvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.xzzy swizzling.
        /// </summary>
        public uvec4 xzzy => new uvec4(x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.rbbg swizzling (equivalent to uvec4.xzzy).
        /// </summary>
        public uvec4 rbbg => new uvec4(x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.xzzyx swizzling.
        /// </summary>
        public uvec5 xzzyx => new uvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.rbbgr swizzling (equivalent to uvec4.xzzyx).
        /// </summary>
        public uvec5 rbbgr => new uvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.xzzyy swizzling.
        /// </summary>
        public uvec5 xzzyy => new uvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.rbbgg swizzling (equivalent to uvec4.xzzyy).
        /// </summary>
        public uvec5 rbbgg => new uvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.xzzyz swizzling.
        /// </summary>
        public uvec5 xzzyz => new uvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.rbbgb swizzling (equivalent to uvec4.xzzyz).
        /// </summary>
        public uvec5 rbbgb => new uvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.xzzyw swizzling.
        /// </summary>
        public uvec5 xzzyw => new uvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.rbbga swizzling (equivalent to uvec4.xzzyw).
        /// </summary>
        public uvec5 rbbga => new uvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.xzzz swizzling.
        /// </summary>
        public uvec4 xzzz => new uvec4(x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.rbbb swizzling (equivalent to uvec4.xzzz).
        /// </summary>
        public uvec4 rbbb => new uvec4(x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.xzzzx swizzling.
        /// </summary>
        public uvec5 xzzzx => new uvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.rbbbr swizzling (equivalent to uvec4.xzzzx).
        /// </summary>
        public uvec5 rbbbr => new uvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.xzzzy swizzling.
        /// </summary>
        public uvec5 xzzzy => new uvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.rbbbg swizzling (equivalent to uvec4.xzzzy).
        /// </summary>
        public uvec5 rbbbg => new uvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.xzzzz swizzling.
        /// </summary>
        public uvec5 xzzzz => new uvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.rbbbb swizzling (equivalent to uvec4.xzzzz).
        /// </summary>
        public uvec5 rbbbb => new uvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.xzzzw swizzling.
        /// </summary>
        public uvec5 xzzzw => new uvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.rbbba swizzling (equivalent to uvec4.xzzzw).
        /// </summary>
        public uvec5 rbbba => new uvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.xzzw swizzling.
        /// </summary>
        public uvec4 xzzw => new uvec4(x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.rbba swizzling (equivalent to uvec4.xzzw).
        /// </summary>
        public uvec4 rbba => new uvec4(x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.xzzwx swizzling.
        /// </summary>
        public uvec5 xzzwx => new uvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.rbbar swizzling (equivalent to uvec4.xzzwx).
        /// </summary>
        public uvec5 rbbar => new uvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.xzzwy swizzling.
        /// </summary>
        public uvec5 xzzwy => new uvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.rbbag swizzling (equivalent to uvec4.xzzwy).
        /// </summary>
        public uvec5 rbbag => new uvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.xzzwz swizzling.
        /// </summary>
        public uvec5 xzzwz => new uvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.rbbab swizzling (equivalent to uvec4.xzzwz).
        /// </summary>
        public uvec5 rbbab => new uvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.xzzww swizzling.
        /// </summary>
        public uvec5 xzzww => new uvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.rbbaa swizzling (equivalent to uvec4.xzzww).
        /// </summary>
        public uvec5 rbbaa => new uvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.xzw swizzling.
        /// </summary>
        public uvec3 xzw => new uvec3(x, z, w);
        
        /// <summary>
        /// Returns uvec4.rba swizzling (equivalent to uvec4.xzw).
        /// </summary>
        public uvec3 rba => new uvec3(x, z, w);
        
        /// <summary>
        /// Returns uvec4.xzwx swizzling.
        /// </summary>
        public uvec4 xzwx => new uvec4(x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.rbar swizzling (equivalent to uvec4.xzwx).
        /// </summary>
        public uvec4 rbar => new uvec4(x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.xzwxx swizzling.
        /// </summary>
        public uvec5 xzwxx => new uvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.rbarr swizzling (equivalent to uvec4.xzwxx).
        /// </summary>
        public uvec5 rbarr => new uvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.xzwxy swizzling.
        /// </summary>
        public uvec5 xzwxy => new uvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.rbarg swizzling (equivalent to uvec4.xzwxy).
        /// </summary>
        public uvec5 rbarg => new uvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.xzwxz swizzling.
        /// </summary>
        public uvec5 xzwxz => new uvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.rbarb swizzling (equivalent to uvec4.xzwxz).
        /// </summary>
        public uvec5 rbarb => new uvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.xzwxw swizzling.
        /// </summary>
        public uvec5 xzwxw => new uvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.rbara swizzling (equivalent to uvec4.xzwxw).
        /// </summary>
        public uvec5 rbara => new uvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.xzwy swizzling.
        /// </summary>
        public uvec4 xzwy => new uvec4(x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.rbag swizzling (equivalent to uvec4.xzwy).
        /// </summary>
        public uvec4 rbag => new uvec4(x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.xzwyx swizzling.
        /// </summary>
        public uvec5 xzwyx => new uvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.rbagr swizzling (equivalent to uvec4.xzwyx).
        /// </summary>
        public uvec5 rbagr => new uvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.xzwyy swizzling.
        /// </summary>
        public uvec5 xzwyy => new uvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.rbagg swizzling (equivalent to uvec4.xzwyy).
        /// </summary>
        public uvec5 rbagg => new uvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.xzwyz swizzling.
        /// </summary>
        public uvec5 xzwyz => new uvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.rbagb swizzling (equivalent to uvec4.xzwyz).
        /// </summary>
        public uvec5 rbagb => new uvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.xzwyw swizzling.
        /// </summary>
        public uvec5 xzwyw => new uvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.rbaga swizzling (equivalent to uvec4.xzwyw).
        /// </summary>
        public uvec5 rbaga => new uvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.xzwz swizzling.
        /// </summary>
        public uvec4 xzwz => new uvec4(x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.rbab swizzling (equivalent to uvec4.xzwz).
        /// </summary>
        public uvec4 rbab => new uvec4(x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.xzwzx swizzling.
        /// </summary>
        public uvec5 xzwzx => new uvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.rbabr swizzling (equivalent to uvec4.xzwzx).
        /// </summary>
        public uvec5 rbabr => new uvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.xzwzy swizzling.
        /// </summary>
        public uvec5 xzwzy => new uvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.rbabg swizzling (equivalent to uvec4.xzwzy).
        /// </summary>
        public uvec5 rbabg => new uvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.xzwzz swizzling.
        /// </summary>
        public uvec5 xzwzz => new uvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.rbabb swizzling (equivalent to uvec4.xzwzz).
        /// </summary>
        public uvec5 rbabb => new uvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.xzwzw swizzling.
        /// </summary>
        public uvec5 xzwzw => new uvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.rbaba swizzling (equivalent to uvec4.xzwzw).
        /// </summary>
        public uvec5 rbaba => new uvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.xzww swizzling.
        /// </summary>
        public uvec4 xzww => new uvec4(x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.rbaa swizzling (equivalent to uvec4.xzww).
        /// </summary>
        public uvec4 rbaa => new uvec4(x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.xzwwx swizzling.
        /// </summary>
        public uvec5 xzwwx => new uvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.rbaar swizzling (equivalent to uvec4.xzwwx).
        /// </summary>
        public uvec5 rbaar => new uvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.xzwwy swizzling.
        /// </summary>
        public uvec5 xzwwy => new uvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.rbaag swizzling (equivalent to uvec4.xzwwy).
        /// </summary>
        public uvec5 rbaag => new uvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.xzwwz swizzling.
        /// </summary>
        public uvec5 xzwwz => new uvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.rbaab swizzling (equivalent to uvec4.xzwwz).
        /// </summary>
        public uvec5 rbaab => new uvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.xzwww swizzling.
        /// </summary>
        public uvec5 xzwww => new uvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.rbaaa swizzling (equivalent to uvec4.xzwww).
        /// </summary>
        public uvec5 rbaaa => new uvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.xw swizzling.
        /// </summary>
        public uvec2 xw => new uvec2(x, w);
        
        /// <summary>
        /// Returns uvec4.ra swizzling (equivalent to uvec4.xw).
        /// </summary>
        public uvec2 ra => new uvec2(x, w);
        
        /// <summary>
        /// Returns uvec4.xwx swizzling.
        /// </summary>
        public uvec3 xwx => new uvec3(x, w, x);
        
        /// <summary>
        /// Returns uvec4.rar swizzling (equivalent to uvec4.xwx).
        /// </summary>
        public uvec3 rar => new uvec3(x, w, x);
        
        /// <summary>
        /// Returns uvec4.xwxx swizzling.
        /// </summary>
        public uvec4 xwxx => new uvec4(x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.rarr swizzling (equivalent to uvec4.xwxx).
        /// </summary>
        public uvec4 rarr => new uvec4(x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.xwxxx swizzling.
        /// </summary>
        public uvec5 xwxxx => new uvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.rarrr swizzling (equivalent to uvec4.xwxxx).
        /// </summary>
        public uvec5 rarrr => new uvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.xwxxy swizzling.
        /// </summary>
        public uvec5 xwxxy => new uvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.rarrg swizzling (equivalent to uvec4.xwxxy).
        /// </summary>
        public uvec5 rarrg => new uvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.xwxxz swizzling.
        /// </summary>
        public uvec5 xwxxz => new uvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.rarrb swizzling (equivalent to uvec4.xwxxz).
        /// </summary>
        public uvec5 rarrb => new uvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.xwxxw swizzling.
        /// </summary>
        public uvec5 xwxxw => new uvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.rarra swizzling (equivalent to uvec4.xwxxw).
        /// </summary>
        public uvec5 rarra => new uvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.xwxy swizzling.
        /// </summary>
        public uvec4 xwxy => new uvec4(x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.rarg swizzling (equivalent to uvec4.xwxy).
        /// </summary>
        public uvec4 rarg => new uvec4(x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.xwxyx swizzling.
        /// </summary>
        public uvec5 xwxyx => new uvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.rargr swizzling (equivalent to uvec4.xwxyx).
        /// </summary>
        public uvec5 rargr => new uvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.xwxyy swizzling.
        /// </summary>
        public uvec5 xwxyy => new uvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.rargg swizzling (equivalent to uvec4.xwxyy).
        /// </summary>
        public uvec5 rargg => new uvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.xwxyz swizzling.
        /// </summary>
        public uvec5 xwxyz => new uvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.rargb swizzling (equivalent to uvec4.xwxyz).
        /// </summary>
        public uvec5 rargb => new uvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.xwxyw swizzling.
        /// </summary>
        public uvec5 xwxyw => new uvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.rarga swizzling (equivalent to uvec4.xwxyw).
        /// </summary>
        public uvec5 rarga => new uvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.xwxz swizzling.
        /// </summary>
        public uvec4 xwxz => new uvec4(x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.rarb swizzling (equivalent to uvec4.xwxz).
        /// </summary>
        public uvec4 rarb => new uvec4(x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.xwxzx swizzling.
        /// </summary>
        public uvec5 xwxzx => new uvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.rarbr swizzling (equivalent to uvec4.xwxzx).
        /// </summary>
        public uvec5 rarbr => new uvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.xwxzy swizzling.
        /// </summary>
        public uvec5 xwxzy => new uvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.rarbg swizzling (equivalent to uvec4.xwxzy).
        /// </summary>
        public uvec5 rarbg => new uvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.xwxzz swizzling.
        /// </summary>
        public uvec5 xwxzz => new uvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.rarbb swizzling (equivalent to uvec4.xwxzz).
        /// </summary>
        public uvec5 rarbb => new uvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.xwxzw swizzling.
        /// </summary>
        public uvec5 xwxzw => new uvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.rarba swizzling (equivalent to uvec4.xwxzw).
        /// </summary>
        public uvec5 rarba => new uvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.xwxw swizzling.
        /// </summary>
        public uvec4 xwxw => new uvec4(x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.rara swizzling (equivalent to uvec4.xwxw).
        /// </summary>
        public uvec4 rara => new uvec4(x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.xwxwx swizzling.
        /// </summary>
        public uvec5 xwxwx => new uvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.rarar swizzling (equivalent to uvec4.xwxwx).
        /// </summary>
        public uvec5 rarar => new uvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.xwxwy swizzling.
        /// </summary>
        public uvec5 xwxwy => new uvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.rarag swizzling (equivalent to uvec4.xwxwy).
        /// </summary>
        public uvec5 rarag => new uvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.xwxwz swizzling.
        /// </summary>
        public uvec5 xwxwz => new uvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.rarab swizzling (equivalent to uvec4.xwxwz).
        /// </summary>
        public uvec5 rarab => new uvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.xwxww swizzling.
        /// </summary>
        public uvec5 xwxww => new uvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.raraa swizzling (equivalent to uvec4.xwxww).
        /// </summary>
        public uvec5 raraa => new uvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.xwy swizzling.
        /// </summary>
        public uvec3 xwy => new uvec3(x, w, y);
        
        /// <summary>
        /// Returns uvec4.rag swizzling (equivalent to uvec4.xwy).
        /// </summary>
        public uvec3 rag => new uvec3(x, w, y);
        
        /// <summary>
        /// Returns uvec4.xwyx swizzling.
        /// </summary>
        public uvec4 xwyx => new uvec4(x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.ragr swizzling (equivalent to uvec4.xwyx).
        /// </summary>
        public uvec4 ragr => new uvec4(x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.xwyxx swizzling.
        /// </summary>
        public uvec5 xwyxx => new uvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.ragrr swizzling (equivalent to uvec4.xwyxx).
        /// </summary>
        public uvec5 ragrr => new uvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.xwyxy swizzling.
        /// </summary>
        public uvec5 xwyxy => new uvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.ragrg swizzling (equivalent to uvec4.xwyxy).
        /// </summary>
        public uvec5 ragrg => new uvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.xwyxz swizzling.
        /// </summary>
        public uvec5 xwyxz => new uvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.ragrb swizzling (equivalent to uvec4.xwyxz).
        /// </summary>
        public uvec5 ragrb => new uvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.xwyxw swizzling.
        /// </summary>
        public uvec5 xwyxw => new uvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.ragra swizzling (equivalent to uvec4.xwyxw).
        /// </summary>
        public uvec5 ragra => new uvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.xwyy swizzling.
        /// </summary>
        public uvec4 xwyy => new uvec4(x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.ragg swizzling (equivalent to uvec4.xwyy).
        /// </summary>
        public uvec4 ragg => new uvec4(x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.xwyyx swizzling.
        /// </summary>
        public uvec5 xwyyx => new uvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.raggr swizzling (equivalent to uvec4.xwyyx).
        /// </summary>
        public uvec5 raggr => new uvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.xwyyy swizzling.
        /// </summary>
        public uvec5 xwyyy => new uvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.raggg swizzling (equivalent to uvec4.xwyyy).
        /// </summary>
        public uvec5 raggg => new uvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.xwyyz swizzling.
        /// </summary>
        public uvec5 xwyyz => new uvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.raggb swizzling (equivalent to uvec4.xwyyz).
        /// </summary>
        public uvec5 raggb => new uvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.xwyyw swizzling.
        /// </summary>
        public uvec5 xwyyw => new uvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.ragga swizzling (equivalent to uvec4.xwyyw).
        /// </summary>
        public uvec5 ragga => new uvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.xwyz swizzling.
        /// </summary>
        public uvec4 xwyz => new uvec4(x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.ragb swizzling (equivalent to uvec4.xwyz).
        /// </summary>
        public uvec4 ragb => new uvec4(x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.xwyzx swizzling.
        /// </summary>
        public uvec5 xwyzx => new uvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.ragbr swizzling (equivalent to uvec4.xwyzx).
        /// </summary>
        public uvec5 ragbr => new uvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.xwyzy swizzling.
        /// </summary>
        public uvec5 xwyzy => new uvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.ragbg swizzling (equivalent to uvec4.xwyzy).
        /// </summary>
        public uvec5 ragbg => new uvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.xwyzz swizzling.
        /// </summary>
        public uvec5 xwyzz => new uvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.ragbb swizzling (equivalent to uvec4.xwyzz).
        /// </summary>
        public uvec5 ragbb => new uvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.xwyzw swizzling.
        /// </summary>
        public uvec5 xwyzw => new uvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.ragba swizzling (equivalent to uvec4.xwyzw).
        /// </summary>
        public uvec5 ragba => new uvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.xwyw swizzling.
        /// </summary>
        public uvec4 xwyw => new uvec4(x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.raga swizzling (equivalent to uvec4.xwyw).
        /// </summary>
        public uvec4 raga => new uvec4(x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.xwywx swizzling.
        /// </summary>
        public uvec5 xwywx => new uvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.ragar swizzling (equivalent to uvec4.xwywx).
        /// </summary>
        public uvec5 ragar => new uvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.xwywy swizzling.
        /// </summary>
        public uvec5 xwywy => new uvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.ragag swizzling (equivalent to uvec4.xwywy).
        /// </summary>
        public uvec5 ragag => new uvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.xwywz swizzling.
        /// </summary>
        public uvec5 xwywz => new uvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.ragab swizzling (equivalent to uvec4.xwywz).
        /// </summary>
        public uvec5 ragab => new uvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.xwyww swizzling.
        /// </summary>
        public uvec5 xwyww => new uvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.ragaa swizzling (equivalent to uvec4.xwyww).
        /// </summary>
        public uvec5 ragaa => new uvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.xwz swizzling.
        /// </summary>
        public uvec3 xwz => new uvec3(x, w, z);
        
        /// <summary>
        /// Returns uvec4.rab swizzling (equivalent to uvec4.xwz).
        /// </summary>
        public uvec3 rab => new uvec3(x, w, z);
        
        /// <summary>
        /// Returns uvec4.xwzx swizzling.
        /// </summary>
        public uvec4 xwzx => new uvec4(x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.rabr swizzling (equivalent to uvec4.xwzx).
        /// </summary>
        public uvec4 rabr => new uvec4(x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.xwzxx swizzling.
        /// </summary>
        public uvec5 xwzxx => new uvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.rabrr swizzling (equivalent to uvec4.xwzxx).
        /// </summary>
        public uvec5 rabrr => new uvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.xwzxy swizzling.
        /// </summary>
        public uvec5 xwzxy => new uvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.rabrg swizzling (equivalent to uvec4.xwzxy).
        /// </summary>
        public uvec5 rabrg => new uvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.xwzxz swizzling.
        /// </summary>
        public uvec5 xwzxz => new uvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.rabrb swizzling (equivalent to uvec4.xwzxz).
        /// </summary>
        public uvec5 rabrb => new uvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.xwzxw swizzling.
        /// </summary>
        public uvec5 xwzxw => new uvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.rabra swizzling (equivalent to uvec4.xwzxw).
        /// </summary>
        public uvec5 rabra => new uvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.xwzy swizzling.
        /// </summary>
        public uvec4 xwzy => new uvec4(x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.rabg swizzling (equivalent to uvec4.xwzy).
        /// </summary>
        public uvec4 rabg => new uvec4(x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.xwzyx swizzling.
        /// </summary>
        public uvec5 xwzyx => new uvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.rabgr swizzling (equivalent to uvec4.xwzyx).
        /// </summary>
        public uvec5 rabgr => new uvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.xwzyy swizzling.
        /// </summary>
        public uvec5 xwzyy => new uvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.rabgg swizzling (equivalent to uvec4.xwzyy).
        /// </summary>
        public uvec5 rabgg => new uvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.xwzyz swizzling.
        /// </summary>
        public uvec5 xwzyz => new uvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.rabgb swizzling (equivalent to uvec4.xwzyz).
        /// </summary>
        public uvec5 rabgb => new uvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.xwzyw swizzling.
        /// </summary>
        public uvec5 xwzyw => new uvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.rabga swizzling (equivalent to uvec4.xwzyw).
        /// </summary>
        public uvec5 rabga => new uvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.xwzz swizzling.
        /// </summary>
        public uvec4 xwzz => new uvec4(x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.rabb swizzling (equivalent to uvec4.xwzz).
        /// </summary>
        public uvec4 rabb => new uvec4(x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.xwzzx swizzling.
        /// </summary>
        public uvec5 xwzzx => new uvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.rabbr swizzling (equivalent to uvec4.xwzzx).
        /// </summary>
        public uvec5 rabbr => new uvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.xwzzy swizzling.
        /// </summary>
        public uvec5 xwzzy => new uvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.rabbg swizzling (equivalent to uvec4.xwzzy).
        /// </summary>
        public uvec5 rabbg => new uvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.xwzzz swizzling.
        /// </summary>
        public uvec5 xwzzz => new uvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.rabbb swizzling (equivalent to uvec4.xwzzz).
        /// </summary>
        public uvec5 rabbb => new uvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.xwzzw swizzling.
        /// </summary>
        public uvec5 xwzzw => new uvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.rabba swizzling (equivalent to uvec4.xwzzw).
        /// </summary>
        public uvec5 rabba => new uvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.xwzw swizzling.
        /// </summary>
        public uvec4 xwzw => new uvec4(x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.raba swizzling (equivalent to uvec4.xwzw).
        /// </summary>
        public uvec4 raba => new uvec4(x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.xwzwx swizzling.
        /// </summary>
        public uvec5 xwzwx => new uvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.rabar swizzling (equivalent to uvec4.xwzwx).
        /// </summary>
        public uvec5 rabar => new uvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.xwzwy swizzling.
        /// </summary>
        public uvec5 xwzwy => new uvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.rabag swizzling (equivalent to uvec4.xwzwy).
        /// </summary>
        public uvec5 rabag => new uvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.xwzwz swizzling.
        /// </summary>
        public uvec5 xwzwz => new uvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.rabab swizzling (equivalent to uvec4.xwzwz).
        /// </summary>
        public uvec5 rabab => new uvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.xwzww swizzling.
        /// </summary>
        public uvec5 xwzww => new uvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.rabaa swizzling (equivalent to uvec4.xwzww).
        /// </summary>
        public uvec5 rabaa => new uvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.xww swizzling.
        /// </summary>
        public uvec3 xww => new uvec3(x, w, w);
        
        /// <summary>
        /// Returns uvec4.raa swizzling (equivalent to uvec4.xww).
        /// </summary>
        public uvec3 raa => new uvec3(x, w, w);
        
        /// <summary>
        /// Returns uvec4.xwwx swizzling.
        /// </summary>
        public uvec4 xwwx => new uvec4(x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.raar swizzling (equivalent to uvec4.xwwx).
        /// </summary>
        public uvec4 raar => new uvec4(x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.xwwxx swizzling.
        /// </summary>
        public uvec5 xwwxx => new uvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.raarr swizzling (equivalent to uvec4.xwwxx).
        /// </summary>
        public uvec5 raarr => new uvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.xwwxy swizzling.
        /// </summary>
        public uvec5 xwwxy => new uvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.raarg swizzling (equivalent to uvec4.xwwxy).
        /// </summary>
        public uvec5 raarg => new uvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.xwwxz swizzling.
        /// </summary>
        public uvec5 xwwxz => new uvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.raarb swizzling (equivalent to uvec4.xwwxz).
        /// </summary>
        public uvec5 raarb => new uvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.xwwxw swizzling.
        /// </summary>
        public uvec5 xwwxw => new uvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.raara swizzling (equivalent to uvec4.xwwxw).
        /// </summary>
        public uvec5 raara => new uvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.xwwy swizzling.
        /// </summary>
        public uvec4 xwwy => new uvec4(x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.raag swizzling (equivalent to uvec4.xwwy).
        /// </summary>
        public uvec4 raag => new uvec4(x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.xwwyx swizzling.
        /// </summary>
        public uvec5 xwwyx => new uvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.raagr swizzling (equivalent to uvec4.xwwyx).
        /// </summary>
        public uvec5 raagr => new uvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.xwwyy swizzling.
        /// </summary>
        public uvec5 xwwyy => new uvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.raagg swizzling (equivalent to uvec4.xwwyy).
        /// </summary>
        public uvec5 raagg => new uvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.xwwyz swizzling.
        /// </summary>
        public uvec5 xwwyz => new uvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.raagb swizzling (equivalent to uvec4.xwwyz).
        /// </summary>
        public uvec5 raagb => new uvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.xwwyw swizzling.
        /// </summary>
        public uvec5 xwwyw => new uvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.raaga swizzling (equivalent to uvec4.xwwyw).
        /// </summary>
        public uvec5 raaga => new uvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.xwwz swizzling.
        /// </summary>
        public uvec4 xwwz => new uvec4(x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.raab swizzling (equivalent to uvec4.xwwz).
        /// </summary>
        public uvec4 raab => new uvec4(x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.xwwzx swizzling.
        /// </summary>
        public uvec5 xwwzx => new uvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.raabr swizzling (equivalent to uvec4.xwwzx).
        /// </summary>
        public uvec5 raabr => new uvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.xwwzy swizzling.
        /// </summary>
        public uvec5 xwwzy => new uvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.raabg swizzling (equivalent to uvec4.xwwzy).
        /// </summary>
        public uvec5 raabg => new uvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.xwwzz swizzling.
        /// </summary>
        public uvec5 xwwzz => new uvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.raabb swizzling (equivalent to uvec4.xwwzz).
        /// </summary>
        public uvec5 raabb => new uvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.xwwzw swizzling.
        /// </summary>
        public uvec5 xwwzw => new uvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.raaba swizzling (equivalent to uvec4.xwwzw).
        /// </summary>
        public uvec5 raaba => new uvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.xwww swizzling.
        /// </summary>
        public uvec4 xwww => new uvec4(x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.raaa swizzling (equivalent to uvec4.xwww).
        /// </summary>
        public uvec4 raaa => new uvec4(x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.xwwwx swizzling.
        /// </summary>
        public uvec5 xwwwx => new uvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.raaar swizzling (equivalent to uvec4.xwwwx).
        /// </summary>
        public uvec5 raaar => new uvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.xwwwy swizzling.
        /// </summary>
        public uvec5 xwwwy => new uvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.raaag swizzling (equivalent to uvec4.xwwwy).
        /// </summary>
        public uvec5 raaag => new uvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.xwwwz swizzling.
        /// </summary>
        public uvec5 xwwwz => new uvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.raaab swizzling (equivalent to uvec4.xwwwz).
        /// </summary>
        public uvec5 raaab => new uvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.xwwww swizzling.
        /// </summary>
        public uvec5 xwwww => new uvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns uvec4.raaaa swizzling (equivalent to uvec4.xwwww).
        /// </summary>
        public uvec5 raaaa => new uvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns uvec4.yx swizzling.
        /// </summary>
        public uvec2 yx => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec4.gr swizzling (equivalent to uvec4.yx).
        /// </summary>
        public uvec2 gr => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec4.yxx swizzling.
        /// </summary>
        public uvec3 yxx => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec4.grr swizzling (equivalent to uvec4.yxx).
        /// </summary>
        public uvec3 grr => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec4.yxxx swizzling.
        /// </summary>
        public uvec4 yxxx => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.grrr swizzling (equivalent to uvec4.yxxx).
        /// </summary>
        public uvec4 grrr => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.yxxxx swizzling.
        /// </summary>
        public uvec5 yxxxx => new uvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.grrrr swizzling (equivalent to uvec4.yxxxx).
        /// </summary>
        public uvec5 grrrr => new uvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.yxxxy swizzling.
        /// </summary>
        public uvec5 yxxxy => new uvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.grrrg swizzling (equivalent to uvec4.yxxxy).
        /// </summary>
        public uvec5 grrrg => new uvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.yxxxz swizzling.
        /// </summary>
        public uvec5 yxxxz => new uvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.grrrb swizzling (equivalent to uvec4.yxxxz).
        /// </summary>
        public uvec5 grrrb => new uvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.yxxxw swizzling.
        /// </summary>
        public uvec5 yxxxw => new uvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.grrra swizzling (equivalent to uvec4.yxxxw).
        /// </summary>
        public uvec5 grrra => new uvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.yxxy swizzling.
        /// </summary>
        public uvec4 yxxy => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.grrg swizzling (equivalent to uvec4.yxxy).
        /// </summary>
        public uvec4 grrg => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.yxxyx swizzling.
        /// </summary>
        public uvec5 yxxyx => new uvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.grrgr swizzling (equivalent to uvec4.yxxyx).
        /// </summary>
        public uvec5 grrgr => new uvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.yxxyy swizzling.
        /// </summary>
        public uvec5 yxxyy => new uvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.grrgg swizzling (equivalent to uvec4.yxxyy).
        /// </summary>
        public uvec5 grrgg => new uvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.yxxyz swizzling.
        /// </summary>
        public uvec5 yxxyz => new uvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.grrgb swizzling (equivalent to uvec4.yxxyz).
        /// </summary>
        public uvec5 grrgb => new uvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.yxxyw swizzling.
        /// </summary>
        public uvec5 yxxyw => new uvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.grrga swizzling (equivalent to uvec4.yxxyw).
        /// </summary>
        public uvec5 grrga => new uvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.yxxz swizzling.
        /// </summary>
        public uvec4 yxxz => new uvec4(y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.grrb swizzling (equivalent to uvec4.yxxz).
        /// </summary>
        public uvec4 grrb => new uvec4(y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.yxxzx swizzling.
        /// </summary>
        public uvec5 yxxzx => new uvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.grrbr swizzling (equivalent to uvec4.yxxzx).
        /// </summary>
        public uvec5 grrbr => new uvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.yxxzy swizzling.
        /// </summary>
        public uvec5 yxxzy => new uvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.grrbg swizzling (equivalent to uvec4.yxxzy).
        /// </summary>
        public uvec5 grrbg => new uvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.yxxzz swizzling.
        /// </summary>
        public uvec5 yxxzz => new uvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.grrbb swizzling (equivalent to uvec4.yxxzz).
        /// </summary>
        public uvec5 grrbb => new uvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.yxxzw swizzling.
        /// </summary>
        public uvec5 yxxzw => new uvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.grrba swizzling (equivalent to uvec4.yxxzw).
        /// </summary>
        public uvec5 grrba => new uvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.yxxw swizzling.
        /// </summary>
        public uvec4 yxxw => new uvec4(y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.grra swizzling (equivalent to uvec4.yxxw).
        /// </summary>
        public uvec4 grra => new uvec4(y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.yxxwx swizzling.
        /// </summary>
        public uvec5 yxxwx => new uvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.grrar swizzling (equivalent to uvec4.yxxwx).
        /// </summary>
        public uvec5 grrar => new uvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.yxxwy swizzling.
        /// </summary>
        public uvec5 yxxwy => new uvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.grrag swizzling (equivalent to uvec4.yxxwy).
        /// </summary>
        public uvec5 grrag => new uvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.yxxwz swizzling.
        /// </summary>
        public uvec5 yxxwz => new uvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.grrab swizzling (equivalent to uvec4.yxxwz).
        /// </summary>
        public uvec5 grrab => new uvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.yxxww swizzling.
        /// </summary>
        public uvec5 yxxww => new uvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.grraa swizzling (equivalent to uvec4.yxxww).
        /// </summary>
        public uvec5 grraa => new uvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.yxy swizzling.
        /// </summary>
        public uvec3 yxy => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec4.grg swizzling (equivalent to uvec4.yxy).
        /// </summary>
        public uvec3 grg => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec4.yxyx swizzling.
        /// </summary>
        public uvec4 yxyx => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.grgr swizzling (equivalent to uvec4.yxyx).
        /// </summary>
        public uvec4 grgr => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.yxyxx swizzling.
        /// </summary>
        public uvec5 yxyxx => new uvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.grgrr swizzling (equivalent to uvec4.yxyxx).
        /// </summary>
        public uvec5 grgrr => new uvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.yxyxy swizzling.
        /// </summary>
        public uvec5 yxyxy => new uvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.grgrg swizzling (equivalent to uvec4.yxyxy).
        /// </summary>
        public uvec5 grgrg => new uvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.yxyxz swizzling.
        /// </summary>
        public uvec5 yxyxz => new uvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.grgrb swizzling (equivalent to uvec4.yxyxz).
        /// </summary>
        public uvec5 grgrb => new uvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.yxyxw swizzling.
        /// </summary>
        public uvec5 yxyxw => new uvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.grgra swizzling (equivalent to uvec4.yxyxw).
        /// </summary>
        public uvec5 grgra => new uvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.yxyy swizzling.
        /// </summary>
        public uvec4 yxyy => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.grgg swizzling (equivalent to uvec4.yxyy).
        /// </summary>
        public uvec4 grgg => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.yxyyx swizzling.
        /// </summary>
        public uvec5 yxyyx => new uvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.grggr swizzling (equivalent to uvec4.yxyyx).
        /// </summary>
        public uvec5 grggr => new uvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.yxyyy swizzling.
        /// </summary>
        public uvec5 yxyyy => new uvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.grggg swizzling (equivalent to uvec4.yxyyy).
        /// </summary>
        public uvec5 grggg => new uvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.yxyyz swizzling.
        /// </summary>
        public uvec5 yxyyz => new uvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.grggb swizzling (equivalent to uvec4.yxyyz).
        /// </summary>
        public uvec5 grggb => new uvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.yxyyw swizzling.
        /// </summary>
        public uvec5 yxyyw => new uvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.grgga swizzling (equivalent to uvec4.yxyyw).
        /// </summary>
        public uvec5 grgga => new uvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.yxyz swizzling.
        /// </summary>
        public uvec4 yxyz => new uvec4(y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.grgb swizzling (equivalent to uvec4.yxyz).
        /// </summary>
        public uvec4 grgb => new uvec4(y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.yxyzx swizzling.
        /// </summary>
        public uvec5 yxyzx => new uvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.grgbr swizzling (equivalent to uvec4.yxyzx).
        /// </summary>
        public uvec5 grgbr => new uvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.yxyzy swizzling.
        /// </summary>
        public uvec5 yxyzy => new uvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.grgbg swizzling (equivalent to uvec4.yxyzy).
        /// </summary>
        public uvec5 grgbg => new uvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.yxyzz swizzling.
        /// </summary>
        public uvec5 yxyzz => new uvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.grgbb swizzling (equivalent to uvec4.yxyzz).
        /// </summary>
        public uvec5 grgbb => new uvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.yxyzw swizzling.
        /// </summary>
        public uvec5 yxyzw => new uvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.grgba swizzling (equivalent to uvec4.yxyzw).
        /// </summary>
        public uvec5 grgba => new uvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.yxyw swizzling.
        /// </summary>
        public uvec4 yxyw => new uvec4(y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.grga swizzling (equivalent to uvec4.yxyw).
        /// </summary>
        public uvec4 grga => new uvec4(y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.yxywx swizzling.
        /// </summary>
        public uvec5 yxywx => new uvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.grgar swizzling (equivalent to uvec4.yxywx).
        /// </summary>
        public uvec5 grgar => new uvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.yxywy swizzling.
        /// </summary>
        public uvec5 yxywy => new uvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.grgag swizzling (equivalent to uvec4.yxywy).
        /// </summary>
        public uvec5 grgag => new uvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.yxywz swizzling.
        /// </summary>
        public uvec5 yxywz => new uvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.grgab swizzling (equivalent to uvec4.yxywz).
        /// </summary>
        public uvec5 grgab => new uvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.yxyww swizzling.
        /// </summary>
        public uvec5 yxyww => new uvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.grgaa swizzling (equivalent to uvec4.yxyww).
        /// </summary>
        public uvec5 grgaa => new uvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.yxz swizzling.
        /// </summary>
        public uvec3 yxz => new uvec3(y, x, z);
        
        /// <summary>
        /// Returns uvec4.grb swizzling (equivalent to uvec4.yxz).
        /// </summary>
        public uvec3 grb => new uvec3(y, x, z);
        
        /// <summary>
        /// Returns uvec4.yxzx swizzling.
        /// </summary>
        public uvec4 yxzx => new uvec4(y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.grbr swizzling (equivalent to uvec4.yxzx).
        /// </summary>
        public uvec4 grbr => new uvec4(y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.yxzxx swizzling.
        /// </summary>
        public uvec5 yxzxx => new uvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.grbrr swizzling (equivalent to uvec4.yxzxx).
        /// </summary>
        public uvec5 grbrr => new uvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.yxzxy swizzling.
        /// </summary>
        public uvec5 yxzxy => new uvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.grbrg swizzling (equivalent to uvec4.yxzxy).
        /// </summary>
        public uvec5 grbrg => new uvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.yxzxz swizzling.
        /// </summary>
        public uvec5 yxzxz => new uvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.grbrb swizzling (equivalent to uvec4.yxzxz).
        /// </summary>
        public uvec5 grbrb => new uvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.yxzxw swizzling.
        /// </summary>
        public uvec5 yxzxw => new uvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.grbra swizzling (equivalent to uvec4.yxzxw).
        /// </summary>
        public uvec5 grbra => new uvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.yxzy swizzling.
        /// </summary>
        public uvec4 yxzy => new uvec4(y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.grbg swizzling (equivalent to uvec4.yxzy).
        /// </summary>
        public uvec4 grbg => new uvec4(y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.yxzyx swizzling.
        /// </summary>
        public uvec5 yxzyx => new uvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.grbgr swizzling (equivalent to uvec4.yxzyx).
        /// </summary>
        public uvec5 grbgr => new uvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.yxzyy swizzling.
        /// </summary>
        public uvec5 yxzyy => new uvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.grbgg swizzling (equivalent to uvec4.yxzyy).
        /// </summary>
        public uvec5 grbgg => new uvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.yxzyz swizzling.
        /// </summary>
        public uvec5 yxzyz => new uvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.grbgb swizzling (equivalent to uvec4.yxzyz).
        /// </summary>
        public uvec5 grbgb => new uvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.yxzyw swizzling.
        /// </summary>
        public uvec5 yxzyw => new uvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.grbga swizzling (equivalent to uvec4.yxzyw).
        /// </summary>
        public uvec5 grbga => new uvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.yxzz swizzling.
        /// </summary>
        public uvec4 yxzz => new uvec4(y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.grbb swizzling (equivalent to uvec4.yxzz).
        /// </summary>
        public uvec4 grbb => new uvec4(y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.yxzzx swizzling.
        /// </summary>
        public uvec5 yxzzx => new uvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.grbbr swizzling (equivalent to uvec4.yxzzx).
        /// </summary>
        public uvec5 grbbr => new uvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.yxzzy swizzling.
        /// </summary>
        public uvec5 yxzzy => new uvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.grbbg swizzling (equivalent to uvec4.yxzzy).
        /// </summary>
        public uvec5 grbbg => new uvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.yxzzz swizzling.
        /// </summary>
        public uvec5 yxzzz => new uvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.grbbb swizzling (equivalent to uvec4.yxzzz).
        /// </summary>
        public uvec5 grbbb => new uvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.yxzzw swizzling.
        /// </summary>
        public uvec5 yxzzw => new uvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.grbba swizzling (equivalent to uvec4.yxzzw).
        /// </summary>
        public uvec5 grbba => new uvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.yxzw swizzling.
        /// </summary>
        public uvec4 yxzw => new uvec4(y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.grba swizzling (equivalent to uvec4.yxzw).
        /// </summary>
        public uvec4 grba => new uvec4(y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.yxzwx swizzling.
        /// </summary>
        public uvec5 yxzwx => new uvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.grbar swizzling (equivalent to uvec4.yxzwx).
        /// </summary>
        public uvec5 grbar => new uvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.yxzwy swizzling.
        /// </summary>
        public uvec5 yxzwy => new uvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.grbag swizzling (equivalent to uvec4.yxzwy).
        /// </summary>
        public uvec5 grbag => new uvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.yxzwz swizzling.
        /// </summary>
        public uvec5 yxzwz => new uvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.grbab swizzling (equivalent to uvec4.yxzwz).
        /// </summary>
        public uvec5 grbab => new uvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.yxzww swizzling.
        /// </summary>
        public uvec5 yxzww => new uvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.grbaa swizzling (equivalent to uvec4.yxzww).
        /// </summary>
        public uvec5 grbaa => new uvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.yxw swizzling.
        /// </summary>
        public uvec3 yxw => new uvec3(y, x, w);
        
        /// <summary>
        /// Returns uvec4.gra swizzling (equivalent to uvec4.yxw).
        /// </summary>
        public uvec3 gra => new uvec3(y, x, w);
        
        /// <summary>
        /// Returns uvec4.yxwx swizzling.
        /// </summary>
        public uvec4 yxwx => new uvec4(y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.grar swizzling (equivalent to uvec4.yxwx).
        /// </summary>
        public uvec4 grar => new uvec4(y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.yxwxx swizzling.
        /// </summary>
        public uvec5 yxwxx => new uvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.grarr swizzling (equivalent to uvec4.yxwxx).
        /// </summary>
        public uvec5 grarr => new uvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.yxwxy swizzling.
        /// </summary>
        public uvec5 yxwxy => new uvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.grarg swizzling (equivalent to uvec4.yxwxy).
        /// </summary>
        public uvec5 grarg => new uvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.yxwxz swizzling.
        /// </summary>
        public uvec5 yxwxz => new uvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.grarb swizzling (equivalent to uvec4.yxwxz).
        /// </summary>
        public uvec5 grarb => new uvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.yxwxw swizzling.
        /// </summary>
        public uvec5 yxwxw => new uvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.grara swizzling (equivalent to uvec4.yxwxw).
        /// </summary>
        public uvec5 grara => new uvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.yxwy swizzling.
        /// </summary>
        public uvec4 yxwy => new uvec4(y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.grag swizzling (equivalent to uvec4.yxwy).
        /// </summary>
        public uvec4 grag => new uvec4(y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.yxwyx swizzling.
        /// </summary>
        public uvec5 yxwyx => new uvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.gragr swizzling (equivalent to uvec4.yxwyx).
        /// </summary>
        public uvec5 gragr => new uvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.yxwyy swizzling.
        /// </summary>
        public uvec5 yxwyy => new uvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.gragg swizzling (equivalent to uvec4.yxwyy).
        /// </summary>
        public uvec5 gragg => new uvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.yxwyz swizzling.
        /// </summary>
        public uvec5 yxwyz => new uvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.gragb swizzling (equivalent to uvec4.yxwyz).
        /// </summary>
        public uvec5 gragb => new uvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.yxwyw swizzling.
        /// </summary>
        public uvec5 yxwyw => new uvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.graga swizzling (equivalent to uvec4.yxwyw).
        /// </summary>
        public uvec5 graga => new uvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.yxwz swizzling.
        /// </summary>
        public uvec4 yxwz => new uvec4(y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.grab swizzling (equivalent to uvec4.yxwz).
        /// </summary>
        public uvec4 grab => new uvec4(y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.yxwzx swizzling.
        /// </summary>
        public uvec5 yxwzx => new uvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.grabr swizzling (equivalent to uvec4.yxwzx).
        /// </summary>
        public uvec5 grabr => new uvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.yxwzy swizzling.
        /// </summary>
        public uvec5 yxwzy => new uvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.grabg swizzling (equivalent to uvec4.yxwzy).
        /// </summary>
        public uvec5 grabg => new uvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.yxwzz swizzling.
        /// </summary>
        public uvec5 yxwzz => new uvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.grabb swizzling (equivalent to uvec4.yxwzz).
        /// </summary>
        public uvec5 grabb => new uvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.yxwzw swizzling.
        /// </summary>
        public uvec5 yxwzw => new uvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.graba swizzling (equivalent to uvec4.yxwzw).
        /// </summary>
        public uvec5 graba => new uvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.yxww swizzling.
        /// </summary>
        public uvec4 yxww => new uvec4(y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.graa swizzling (equivalent to uvec4.yxww).
        /// </summary>
        public uvec4 graa => new uvec4(y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.yxwwx swizzling.
        /// </summary>
        public uvec5 yxwwx => new uvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.graar swizzling (equivalent to uvec4.yxwwx).
        /// </summary>
        public uvec5 graar => new uvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.yxwwy swizzling.
        /// </summary>
        public uvec5 yxwwy => new uvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.graag swizzling (equivalent to uvec4.yxwwy).
        /// </summary>
        public uvec5 graag => new uvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.yxwwz swizzling.
        /// </summary>
        public uvec5 yxwwz => new uvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.graab swizzling (equivalent to uvec4.yxwwz).
        /// </summary>
        public uvec5 graab => new uvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.yxwww swizzling.
        /// </summary>
        public uvec5 yxwww => new uvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.graaa swizzling (equivalent to uvec4.yxwww).
        /// </summary>
        public uvec5 graaa => new uvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.yy swizzling.
        /// </summary>
        public uvec2 yy => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec4.gg swizzling (equivalent to uvec4.yy).
        /// </summary>
        public uvec2 gg => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec4.yyx swizzling.
        /// </summary>
        public uvec3 yyx => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec4.ggr swizzling (equivalent to uvec4.yyx).
        /// </summary>
        public uvec3 ggr => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec4.yyxx swizzling.
        /// </summary>
        public uvec4 yyxx => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.ggrr swizzling (equivalent to uvec4.yyxx).
        /// </summary>
        public uvec4 ggrr => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.yyxxx swizzling.
        /// </summary>
        public uvec5 yyxxx => new uvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.ggrrr swizzling (equivalent to uvec4.yyxxx).
        /// </summary>
        public uvec5 ggrrr => new uvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.yyxxy swizzling.
        /// </summary>
        public uvec5 yyxxy => new uvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.ggrrg swizzling (equivalent to uvec4.yyxxy).
        /// </summary>
        public uvec5 ggrrg => new uvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.yyxxz swizzling.
        /// </summary>
        public uvec5 yyxxz => new uvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.ggrrb swizzling (equivalent to uvec4.yyxxz).
        /// </summary>
        public uvec5 ggrrb => new uvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.yyxxw swizzling.
        /// </summary>
        public uvec5 yyxxw => new uvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.ggrra swizzling (equivalent to uvec4.yyxxw).
        /// </summary>
        public uvec5 ggrra => new uvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.yyxy swizzling.
        /// </summary>
        public uvec4 yyxy => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.ggrg swizzling (equivalent to uvec4.yyxy).
        /// </summary>
        public uvec4 ggrg => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.yyxyx swizzling.
        /// </summary>
        public uvec5 yyxyx => new uvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.ggrgr swizzling (equivalent to uvec4.yyxyx).
        /// </summary>
        public uvec5 ggrgr => new uvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.yyxyy swizzling.
        /// </summary>
        public uvec5 yyxyy => new uvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.ggrgg swizzling (equivalent to uvec4.yyxyy).
        /// </summary>
        public uvec5 ggrgg => new uvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.yyxyz swizzling.
        /// </summary>
        public uvec5 yyxyz => new uvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.ggrgb swizzling (equivalent to uvec4.yyxyz).
        /// </summary>
        public uvec5 ggrgb => new uvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.yyxyw swizzling.
        /// </summary>
        public uvec5 yyxyw => new uvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.ggrga swizzling (equivalent to uvec4.yyxyw).
        /// </summary>
        public uvec5 ggrga => new uvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.yyxz swizzling.
        /// </summary>
        public uvec4 yyxz => new uvec4(y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.ggrb swizzling (equivalent to uvec4.yyxz).
        /// </summary>
        public uvec4 ggrb => new uvec4(y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.yyxzx swizzling.
        /// </summary>
        public uvec5 yyxzx => new uvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.ggrbr swizzling (equivalent to uvec4.yyxzx).
        /// </summary>
        public uvec5 ggrbr => new uvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.yyxzy swizzling.
        /// </summary>
        public uvec5 yyxzy => new uvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.ggrbg swizzling (equivalent to uvec4.yyxzy).
        /// </summary>
        public uvec5 ggrbg => new uvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.yyxzz swizzling.
        /// </summary>
        public uvec5 yyxzz => new uvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.ggrbb swizzling (equivalent to uvec4.yyxzz).
        /// </summary>
        public uvec5 ggrbb => new uvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.yyxzw swizzling.
        /// </summary>
        public uvec5 yyxzw => new uvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.ggrba swizzling (equivalent to uvec4.yyxzw).
        /// </summary>
        public uvec5 ggrba => new uvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.yyxw swizzling.
        /// </summary>
        public uvec4 yyxw => new uvec4(y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.ggra swizzling (equivalent to uvec4.yyxw).
        /// </summary>
        public uvec4 ggra => new uvec4(y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.yyxwx swizzling.
        /// </summary>
        public uvec5 yyxwx => new uvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.ggrar swizzling (equivalent to uvec4.yyxwx).
        /// </summary>
        public uvec5 ggrar => new uvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.yyxwy swizzling.
        /// </summary>
        public uvec5 yyxwy => new uvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.ggrag swizzling (equivalent to uvec4.yyxwy).
        /// </summary>
        public uvec5 ggrag => new uvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.yyxwz swizzling.
        /// </summary>
        public uvec5 yyxwz => new uvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.ggrab swizzling (equivalent to uvec4.yyxwz).
        /// </summary>
        public uvec5 ggrab => new uvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.yyxww swizzling.
        /// </summary>
        public uvec5 yyxww => new uvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.ggraa swizzling (equivalent to uvec4.yyxww).
        /// </summary>
        public uvec5 ggraa => new uvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.yyy swizzling.
        /// </summary>
        public uvec3 yyy => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec4.ggg swizzling (equivalent to uvec4.yyy).
        /// </summary>
        public uvec3 ggg => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec4.yyyx swizzling.
        /// </summary>
        public uvec4 yyyx => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.gggr swizzling (equivalent to uvec4.yyyx).
        /// </summary>
        public uvec4 gggr => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.yyyxx swizzling.
        /// </summary>
        public uvec5 yyyxx => new uvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.gggrr swizzling (equivalent to uvec4.yyyxx).
        /// </summary>
        public uvec5 gggrr => new uvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.yyyxy swizzling.
        /// </summary>
        public uvec5 yyyxy => new uvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.gggrg swizzling (equivalent to uvec4.yyyxy).
        /// </summary>
        public uvec5 gggrg => new uvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.yyyxz swizzling.
        /// </summary>
        public uvec5 yyyxz => new uvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.gggrb swizzling (equivalent to uvec4.yyyxz).
        /// </summary>
        public uvec5 gggrb => new uvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.yyyxw swizzling.
        /// </summary>
        public uvec5 yyyxw => new uvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.gggra swizzling (equivalent to uvec4.yyyxw).
        /// </summary>
        public uvec5 gggra => new uvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.yyyy swizzling.
        /// </summary>
        public uvec4 yyyy => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.gggg swizzling (equivalent to uvec4.yyyy).
        /// </summary>
        public uvec4 gggg => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.yyyyx swizzling.
        /// </summary>
        public uvec5 yyyyx => new uvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.ggggr swizzling (equivalent to uvec4.yyyyx).
        /// </summary>
        public uvec5 ggggr => new uvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.yyyyy swizzling.
        /// </summary>
        public uvec5 yyyyy => new uvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.ggggg swizzling (equivalent to uvec4.yyyyy).
        /// </summary>
        public uvec5 ggggg => new uvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.yyyyz swizzling.
        /// </summary>
        public uvec5 yyyyz => new uvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.ggggb swizzling (equivalent to uvec4.yyyyz).
        /// </summary>
        public uvec5 ggggb => new uvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.yyyyw swizzling.
        /// </summary>
        public uvec5 yyyyw => new uvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.gggga swizzling (equivalent to uvec4.yyyyw).
        /// </summary>
        public uvec5 gggga => new uvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.yyyz swizzling.
        /// </summary>
        public uvec4 yyyz => new uvec4(y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.gggb swizzling (equivalent to uvec4.yyyz).
        /// </summary>
        public uvec4 gggb => new uvec4(y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.yyyzx swizzling.
        /// </summary>
        public uvec5 yyyzx => new uvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.gggbr swizzling (equivalent to uvec4.yyyzx).
        /// </summary>
        public uvec5 gggbr => new uvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.yyyzy swizzling.
        /// </summary>
        public uvec5 yyyzy => new uvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.gggbg swizzling (equivalent to uvec4.yyyzy).
        /// </summary>
        public uvec5 gggbg => new uvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.yyyzz swizzling.
        /// </summary>
        public uvec5 yyyzz => new uvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.gggbb swizzling (equivalent to uvec4.yyyzz).
        /// </summary>
        public uvec5 gggbb => new uvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.yyyzw swizzling.
        /// </summary>
        public uvec5 yyyzw => new uvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.gggba swizzling (equivalent to uvec4.yyyzw).
        /// </summary>
        public uvec5 gggba => new uvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.yyyw swizzling.
        /// </summary>
        public uvec4 yyyw => new uvec4(y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.ggga swizzling (equivalent to uvec4.yyyw).
        /// </summary>
        public uvec4 ggga => new uvec4(y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.yyywx swizzling.
        /// </summary>
        public uvec5 yyywx => new uvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.gggar swizzling (equivalent to uvec4.yyywx).
        /// </summary>
        public uvec5 gggar => new uvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.yyywy swizzling.
        /// </summary>
        public uvec5 yyywy => new uvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.gggag swizzling (equivalent to uvec4.yyywy).
        /// </summary>
        public uvec5 gggag => new uvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.yyywz swizzling.
        /// </summary>
        public uvec5 yyywz => new uvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.gggab swizzling (equivalent to uvec4.yyywz).
        /// </summary>
        public uvec5 gggab => new uvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.yyyww swizzling.
        /// </summary>
        public uvec5 yyyww => new uvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.gggaa swizzling (equivalent to uvec4.yyyww).
        /// </summary>
        public uvec5 gggaa => new uvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.yyz swizzling.
        /// </summary>
        public uvec3 yyz => new uvec3(y, y, z);
        
        /// <summary>
        /// Returns uvec4.ggb swizzling (equivalent to uvec4.yyz).
        /// </summary>
        public uvec3 ggb => new uvec3(y, y, z);
        
        /// <summary>
        /// Returns uvec4.yyzx swizzling.
        /// </summary>
        public uvec4 yyzx => new uvec4(y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.ggbr swizzling (equivalent to uvec4.yyzx).
        /// </summary>
        public uvec4 ggbr => new uvec4(y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.yyzxx swizzling.
        /// </summary>
        public uvec5 yyzxx => new uvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.ggbrr swizzling (equivalent to uvec4.yyzxx).
        /// </summary>
        public uvec5 ggbrr => new uvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.yyzxy swizzling.
        /// </summary>
        public uvec5 yyzxy => new uvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.ggbrg swizzling (equivalent to uvec4.yyzxy).
        /// </summary>
        public uvec5 ggbrg => new uvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.yyzxz swizzling.
        /// </summary>
        public uvec5 yyzxz => new uvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.ggbrb swizzling (equivalent to uvec4.yyzxz).
        /// </summary>
        public uvec5 ggbrb => new uvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.yyzxw swizzling.
        /// </summary>
        public uvec5 yyzxw => new uvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.ggbra swizzling (equivalent to uvec4.yyzxw).
        /// </summary>
        public uvec5 ggbra => new uvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.yyzy swizzling.
        /// </summary>
        public uvec4 yyzy => new uvec4(y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.ggbg swizzling (equivalent to uvec4.yyzy).
        /// </summary>
        public uvec4 ggbg => new uvec4(y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.yyzyx swizzling.
        /// </summary>
        public uvec5 yyzyx => new uvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.ggbgr swizzling (equivalent to uvec4.yyzyx).
        /// </summary>
        public uvec5 ggbgr => new uvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.yyzyy swizzling.
        /// </summary>
        public uvec5 yyzyy => new uvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.ggbgg swizzling (equivalent to uvec4.yyzyy).
        /// </summary>
        public uvec5 ggbgg => new uvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.yyzyz swizzling.
        /// </summary>
        public uvec5 yyzyz => new uvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.ggbgb swizzling (equivalent to uvec4.yyzyz).
        /// </summary>
        public uvec5 ggbgb => new uvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.yyzyw swizzling.
        /// </summary>
        public uvec5 yyzyw => new uvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.ggbga swizzling (equivalent to uvec4.yyzyw).
        /// </summary>
        public uvec5 ggbga => new uvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.yyzz swizzling.
        /// </summary>
        public uvec4 yyzz => new uvec4(y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.ggbb swizzling (equivalent to uvec4.yyzz).
        /// </summary>
        public uvec4 ggbb => new uvec4(y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.yyzzx swizzling.
        /// </summary>
        public uvec5 yyzzx => new uvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.ggbbr swizzling (equivalent to uvec4.yyzzx).
        /// </summary>
        public uvec5 ggbbr => new uvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.yyzzy swizzling.
        /// </summary>
        public uvec5 yyzzy => new uvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.ggbbg swizzling (equivalent to uvec4.yyzzy).
        /// </summary>
        public uvec5 ggbbg => new uvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.yyzzz swizzling.
        /// </summary>
        public uvec5 yyzzz => new uvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.ggbbb swizzling (equivalent to uvec4.yyzzz).
        /// </summary>
        public uvec5 ggbbb => new uvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.yyzzw swizzling.
        /// </summary>
        public uvec5 yyzzw => new uvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.ggbba swizzling (equivalent to uvec4.yyzzw).
        /// </summary>
        public uvec5 ggbba => new uvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.yyzw swizzling.
        /// </summary>
        public uvec4 yyzw => new uvec4(y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.ggba swizzling (equivalent to uvec4.yyzw).
        /// </summary>
        public uvec4 ggba => new uvec4(y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.yyzwx swizzling.
        /// </summary>
        public uvec5 yyzwx => new uvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.ggbar swizzling (equivalent to uvec4.yyzwx).
        /// </summary>
        public uvec5 ggbar => new uvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.yyzwy swizzling.
        /// </summary>
        public uvec5 yyzwy => new uvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.ggbag swizzling (equivalent to uvec4.yyzwy).
        /// </summary>
        public uvec5 ggbag => new uvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.yyzwz swizzling.
        /// </summary>
        public uvec5 yyzwz => new uvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.ggbab swizzling (equivalent to uvec4.yyzwz).
        /// </summary>
        public uvec5 ggbab => new uvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.yyzww swizzling.
        /// </summary>
        public uvec5 yyzww => new uvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.ggbaa swizzling (equivalent to uvec4.yyzww).
        /// </summary>
        public uvec5 ggbaa => new uvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.yyw swizzling.
        /// </summary>
        public uvec3 yyw => new uvec3(y, y, w);
        
        /// <summary>
        /// Returns uvec4.gga swizzling (equivalent to uvec4.yyw).
        /// </summary>
        public uvec3 gga => new uvec3(y, y, w);
        
        /// <summary>
        /// Returns uvec4.yywx swizzling.
        /// </summary>
        public uvec4 yywx => new uvec4(y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.ggar swizzling (equivalent to uvec4.yywx).
        /// </summary>
        public uvec4 ggar => new uvec4(y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.yywxx swizzling.
        /// </summary>
        public uvec5 yywxx => new uvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.ggarr swizzling (equivalent to uvec4.yywxx).
        /// </summary>
        public uvec5 ggarr => new uvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.yywxy swizzling.
        /// </summary>
        public uvec5 yywxy => new uvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.ggarg swizzling (equivalent to uvec4.yywxy).
        /// </summary>
        public uvec5 ggarg => new uvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.yywxz swizzling.
        /// </summary>
        public uvec5 yywxz => new uvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.ggarb swizzling (equivalent to uvec4.yywxz).
        /// </summary>
        public uvec5 ggarb => new uvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.yywxw swizzling.
        /// </summary>
        public uvec5 yywxw => new uvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.ggara swizzling (equivalent to uvec4.yywxw).
        /// </summary>
        public uvec5 ggara => new uvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.yywy swizzling.
        /// </summary>
        public uvec4 yywy => new uvec4(y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.ggag swizzling (equivalent to uvec4.yywy).
        /// </summary>
        public uvec4 ggag => new uvec4(y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.yywyx swizzling.
        /// </summary>
        public uvec5 yywyx => new uvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.ggagr swizzling (equivalent to uvec4.yywyx).
        /// </summary>
        public uvec5 ggagr => new uvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.yywyy swizzling.
        /// </summary>
        public uvec5 yywyy => new uvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.ggagg swizzling (equivalent to uvec4.yywyy).
        /// </summary>
        public uvec5 ggagg => new uvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.yywyz swizzling.
        /// </summary>
        public uvec5 yywyz => new uvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.ggagb swizzling (equivalent to uvec4.yywyz).
        /// </summary>
        public uvec5 ggagb => new uvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.yywyw swizzling.
        /// </summary>
        public uvec5 yywyw => new uvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.ggaga swizzling (equivalent to uvec4.yywyw).
        /// </summary>
        public uvec5 ggaga => new uvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.yywz swizzling.
        /// </summary>
        public uvec4 yywz => new uvec4(y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.ggab swizzling (equivalent to uvec4.yywz).
        /// </summary>
        public uvec4 ggab => new uvec4(y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.yywzx swizzling.
        /// </summary>
        public uvec5 yywzx => new uvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.ggabr swizzling (equivalent to uvec4.yywzx).
        /// </summary>
        public uvec5 ggabr => new uvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.yywzy swizzling.
        /// </summary>
        public uvec5 yywzy => new uvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.ggabg swizzling (equivalent to uvec4.yywzy).
        /// </summary>
        public uvec5 ggabg => new uvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.yywzz swizzling.
        /// </summary>
        public uvec5 yywzz => new uvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.ggabb swizzling (equivalent to uvec4.yywzz).
        /// </summary>
        public uvec5 ggabb => new uvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.yywzw swizzling.
        /// </summary>
        public uvec5 yywzw => new uvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.ggaba swizzling (equivalent to uvec4.yywzw).
        /// </summary>
        public uvec5 ggaba => new uvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.yyww swizzling.
        /// </summary>
        public uvec4 yyww => new uvec4(y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.ggaa swizzling (equivalent to uvec4.yyww).
        /// </summary>
        public uvec4 ggaa => new uvec4(y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.yywwx swizzling.
        /// </summary>
        public uvec5 yywwx => new uvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.ggaar swizzling (equivalent to uvec4.yywwx).
        /// </summary>
        public uvec5 ggaar => new uvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.yywwy swizzling.
        /// </summary>
        public uvec5 yywwy => new uvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.ggaag swizzling (equivalent to uvec4.yywwy).
        /// </summary>
        public uvec5 ggaag => new uvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.yywwz swizzling.
        /// </summary>
        public uvec5 yywwz => new uvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.ggaab swizzling (equivalent to uvec4.yywwz).
        /// </summary>
        public uvec5 ggaab => new uvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.yywww swizzling.
        /// </summary>
        public uvec5 yywww => new uvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.ggaaa swizzling (equivalent to uvec4.yywww).
        /// </summary>
        public uvec5 ggaaa => new uvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.yz swizzling.
        /// </summary>
        public uvec2 yz => new uvec2(y, z);
        
        /// <summary>
        /// Returns uvec4.gb swizzling (equivalent to uvec4.yz).
        /// </summary>
        public uvec2 gb => new uvec2(y, z);
        
        /// <summary>
        /// Returns uvec4.yzx swizzling.
        /// </summary>
        public uvec3 yzx => new uvec3(y, z, x);
        
        /// <summary>
        /// Returns uvec4.gbr swizzling (equivalent to uvec4.yzx).
        /// </summary>
        public uvec3 gbr => new uvec3(y, z, x);
        
        /// <summary>
        /// Returns uvec4.yzxx swizzling.
        /// </summary>
        public uvec4 yzxx => new uvec4(y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.gbrr swizzling (equivalent to uvec4.yzxx).
        /// </summary>
        public uvec4 gbrr => new uvec4(y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.yzxxx swizzling.
        /// </summary>
        public uvec5 yzxxx => new uvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.gbrrr swizzling (equivalent to uvec4.yzxxx).
        /// </summary>
        public uvec5 gbrrr => new uvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.yzxxy swizzling.
        /// </summary>
        public uvec5 yzxxy => new uvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.gbrrg swizzling (equivalent to uvec4.yzxxy).
        /// </summary>
        public uvec5 gbrrg => new uvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.yzxxz swizzling.
        /// </summary>
        public uvec5 yzxxz => new uvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.gbrrb swizzling (equivalent to uvec4.yzxxz).
        /// </summary>
        public uvec5 gbrrb => new uvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.yzxxw swizzling.
        /// </summary>
        public uvec5 yzxxw => new uvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.gbrra swizzling (equivalent to uvec4.yzxxw).
        /// </summary>
        public uvec5 gbrra => new uvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.yzxy swizzling.
        /// </summary>
        public uvec4 yzxy => new uvec4(y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.gbrg swizzling (equivalent to uvec4.yzxy).
        /// </summary>
        public uvec4 gbrg => new uvec4(y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.yzxyx swizzling.
        /// </summary>
        public uvec5 yzxyx => new uvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.gbrgr swizzling (equivalent to uvec4.yzxyx).
        /// </summary>
        public uvec5 gbrgr => new uvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.yzxyy swizzling.
        /// </summary>
        public uvec5 yzxyy => new uvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.gbrgg swizzling (equivalent to uvec4.yzxyy).
        /// </summary>
        public uvec5 gbrgg => new uvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.yzxyz swizzling.
        /// </summary>
        public uvec5 yzxyz => new uvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.gbrgb swizzling (equivalent to uvec4.yzxyz).
        /// </summary>
        public uvec5 gbrgb => new uvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.yzxyw swizzling.
        /// </summary>
        public uvec5 yzxyw => new uvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.gbrga swizzling (equivalent to uvec4.yzxyw).
        /// </summary>
        public uvec5 gbrga => new uvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.yzxz swizzling.
        /// </summary>
        public uvec4 yzxz => new uvec4(y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.gbrb swizzling (equivalent to uvec4.yzxz).
        /// </summary>
        public uvec4 gbrb => new uvec4(y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.yzxzx swizzling.
        /// </summary>
        public uvec5 yzxzx => new uvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.gbrbr swizzling (equivalent to uvec4.yzxzx).
        /// </summary>
        public uvec5 gbrbr => new uvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.yzxzy swizzling.
        /// </summary>
        public uvec5 yzxzy => new uvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.gbrbg swizzling (equivalent to uvec4.yzxzy).
        /// </summary>
        public uvec5 gbrbg => new uvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.yzxzz swizzling.
        /// </summary>
        public uvec5 yzxzz => new uvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.gbrbb swizzling (equivalent to uvec4.yzxzz).
        /// </summary>
        public uvec5 gbrbb => new uvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.yzxzw swizzling.
        /// </summary>
        public uvec5 yzxzw => new uvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.gbrba swizzling (equivalent to uvec4.yzxzw).
        /// </summary>
        public uvec5 gbrba => new uvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.yzxw swizzling.
        /// </summary>
        public uvec4 yzxw => new uvec4(y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.gbra swizzling (equivalent to uvec4.yzxw).
        /// </summary>
        public uvec4 gbra => new uvec4(y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.yzxwx swizzling.
        /// </summary>
        public uvec5 yzxwx => new uvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.gbrar swizzling (equivalent to uvec4.yzxwx).
        /// </summary>
        public uvec5 gbrar => new uvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.yzxwy swizzling.
        /// </summary>
        public uvec5 yzxwy => new uvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.gbrag swizzling (equivalent to uvec4.yzxwy).
        /// </summary>
        public uvec5 gbrag => new uvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.yzxwz swizzling.
        /// </summary>
        public uvec5 yzxwz => new uvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.gbrab swizzling (equivalent to uvec4.yzxwz).
        /// </summary>
        public uvec5 gbrab => new uvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.yzxww swizzling.
        /// </summary>
        public uvec5 yzxww => new uvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.gbraa swizzling (equivalent to uvec4.yzxww).
        /// </summary>
        public uvec5 gbraa => new uvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.yzy swizzling.
        /// </summary>
        public uvec3 yzy => new uvec3(y, z, y);
        
        /// <summary>
        /// Returns uvec4.gbg swizzling (equivalent to uvec4.yzy).
        /// </summary>
        public uvec3 gbg => new uvec3(y, z, y);
        
        /// <summary>
        /// Returns uvec4.yzyx swizzling.
        /// </summary>
        public uvec4 yzyx => new uvec4(y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.gbgr swizzling (equivalent to uvec4.yzyx).
        /// </summary>
        public uvec4 gbgr => new uvec4(y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.yzyxx swizzling.
        /// </summary>
        public uvec5 yzyxx => new uvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.gbgrr swizzling (equivalent to uvec4.yzyxx).
        /// </summary>
        public uvec5 gbgrr => new uvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.yzyxy swizzling.
        /// </summary>
        public uvec5 yzyxy => new uvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.gbgrg swizzling (equivalent to uvec4.yzyxy).
        /// </summary>
        public uvec5 gbgrg => new uvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.yzyxz swizzling.
        /// </summary>
        public uvec5 yzyxz => new uvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.gbgrb swizzling (equivalent to uvec4.yzyxz).
        /// </summary>
        public uvec5 gbgrb => new uvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.yzyxw swizzling.
        /// </summary>
        public uvec5 yzyxw => new uvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.gbgra swizzling (equivalent to uvec4.yzyxw).
        /// </summary>
        public uvec5 gbgra => new uvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.yzyy swizzling.
        /// </summary>
        public uvec4 yzyy => new uvec4(y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.gbgg swizzling (equivalent to uvec4.yzyy).
        /// </summary>
        public uvec4 gbgg => new uvec4(y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.yzyyx swizzling.
        /// </summary>
        public uvec5 yzyyx => new uvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.gbggr swizzling (equivalent to uvec4.yzyyx).
        /// </summary>
        public uvec5 gbggr => new uvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.yzyyy swizzling.
        /// </summary>
        public uvec5 yzyyy => new uvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.gbggg swizzling (equivalent to uvec4.yzyyy).
        /// </summary>
        public uvec5 gbggg => new uvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.yzyyz swizzling.
        /// </summary>
        public uvec5 yzyyz => new uvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.gbggb swizzling (equivalent to uvec4.yzyyz).
        /// </summary>
        public uvec5 gbggb => new uvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.yzyyw swizzling.
        /// </summary>
        public uvec5 yzyyw => new uvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.gbgga swizzling (equivalent to uvec4.yzyyw).
        /// </summary>
        public uvec5 gbgga => new uvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.yzyz swizzling.
        /// </summary>
        public uvec4 yzyz => new uvec4(y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.gbgb swizzling (equivalent to uvec4.yzyz).
        /// </summary>
        public uvec4 gbgb => new uvec4(y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.yzyzx swizzling.
        /// </summary>
        public uvec5 yzyzx => new uvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.gbgbr swizzling (equivalent to uvec4.yzyzx).
        /// </summary>
        public uvec5 gbgbr => new uvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.yzyzy swizzling.
        /// </summary>
        public uvec5 yzyzy => new uvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.gbgbg swizzling (equivalent to uvec4.yzyzy).
        /// </summary>
        public uvec5 gbgbg => new uvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.yzyzz swizzling.
        /// </summary>
        public uvec5 yzyzz => new uvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.gbgbb swizzling (equivalent to uvec4.yzyzz).
        /// </summary>
        public uvec5 gbgbb => new uvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.yzyzw swizzling.
        /// </summary>
        public uvec5 yzyzw => new uvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.gbgba swizzling (equivalent to uvec4.yzyzw).
        /// </summary>
        public uvec5 gbgba => new uvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.yzyw swizzling.
        /// </summary>
        public uvec4 yzyw => new uvec4(y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.gbga swizzling (equivalent to uvec4.yzyw).
        /// </summary>
        public uvec4 gbga => new uvec4(y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.yzywx swizzling.
        /// </summary>
        public uvec5 yzywx => new uvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.gbgar swizzling (equivalent to uvec4.yzywx).
        /// </summary>
        public uvec5 gbgar => new uvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.yzywy swizzling.
        /// </summary>
        public uvec5 yzywy => new uvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.gbgag swizzling (equivalent to uvec4.yzywy).
        /// </summary>
        public uvec5 gbgag => new uvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.yzywz swizzling.
        /// </summary>
        public uvec5 yzywz => new uvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.gbgab swizzling (equivalent to uvec4.yzywz).
        /// </summary>
        public uvec5 gbgab => new uvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.yzyww swizzling.
        /// </summary>
        public uvec5 yzyww => new uvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.gbgaa swizzling (equivalent to uvec4.yzyww).
        /// </summary>
        public uvec5 gbgaa => new uvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.yzz swizzling.
        /// </summary>
        public uvec3 yzz => new uvec3(y, z, z);
        
        /// <summary>
        /// Returns uvec4.gbb swizzling (equivalent to uvec4.yzz).
        /// </summary>
        public uvec3 gbb => new uvec3(y, z, z);
        
        /// <summary>
        /// Returns uvec4.yzzx swizzling.
        /// </summary>
        public uvec4 yzzx => new uvec4(y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.gbbr swizzling (equivalent to uvec4.yzzx).
        /// </summary>
        public uvec4 gbbr => new uvec4(y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.yzzxx swizzling.
        /// </summary>
        public uvec5 yzzxx => new uvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.gbbrr swizzling (equivalent to uvec4.yzzxx).
        /// </summary>
        public uvec5 gbbrr => new uvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.yzzxy swizzling.
        /// </summary>
        public uvec5 yzzxy => new uvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.gbbrg swizzling (equivalent to uvec4.yzzxy).
        /// </summary>
        public uvec5 gbbrg => new uvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.yzzxz swizzling.
        /// </summary>
        public uvec5 yzzxz => new uvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.gbbrb swizzling (equivalent to uvec4.yzzxz).
        /// </summary>
        public uvec5 gbbrb => new uvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.yzzxw swizzling.
        /// </summary>
        public uvec5 yzzxw => new uvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.gbbra swizzling (equivalent to uvec4.yzzxw).
        /// </summary>
        public uvec5 gbbra => new uvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.yzzy swizzling.
        /// </summary>
        public uvec4 yzzy => new uvec4(y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.gbbg swizzling (equivalent to uvec4.yzzy).
        /// </summary>
        public uvec4 gbbg => new uvec4(y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.yzzyx swizzling.
        /// </summary>
        public uvec5 yzzyx => new uvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.gbbgr swizzling (equivalent to uvec4.yzzyx).
        /// </summary>
        public uvec5 gbbgr => new uvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.yzzyy swizzling.
        /// </summary>
        public uvec5 yzzyy => new uvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.gbbgg swizzling (equivalent to uvec4.yzzyy).
        /// </summary>
        public uvec5 gbbgg => new uvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.yzzyz swizzling.
        /// </summary>
        public uvec5 yzzyz => new uvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.gbbgb swizzling (equivalent to uvec4.yzzyz).
        /// </summary>
        public uvec5 gbbgb => new uvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.yzzyw swizzling.
        /// </summary>
        public uvec5 yzzyw => new uvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.gbbga swizzling (equivalent to uvec4.yzzyw).
        /// </summary>
        public uvec5 gbbga => new uvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.yzzz swizzling.
        /// </summary>
        public uvec4 yzzz => new uvec4(y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.gbbb swizzling (equivalent to uvec4.yzzz).
        /// </summary>
        public uvec4 gbbb => new uvec4(y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.yzzzx swizzling.
        /// </summary>
        public uvec5 yzzzx => new uvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.gbbbr swizzling (equivalent to uvec4.yzzzx).
        /// </summary>
        public uvec5 gbbbr => new uvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.yzzzy swizzling.
        /// </summary>
        public uvec5 yzzzy => new uvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.gbbbg swizzling (equivalent to uvec4.yzzzy).
        /// </summary>
        public uvec5 gbbbg => new uvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.yzzzz swizzling.
        /// </summary>
        public uvec5 yzzzz => new uvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.gbbbb swizzling (equivalent to uvec4.yzzzz).
        /// </summary>
        public uvec5 gbbbb => new uvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.yzzzw swizzling.
        /// </summary>
        public uvec5 yzzzw => new uvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.gbbba swizzling (equivalent to uvec4.yzzzw).
        /// </summary>
        public uvec5 gbbba => new uvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.yzzw swizzling.
        /// </summary>
        public uvec4 yzzw => new uvec4(y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.gbba swizzling (equivalent to uvec4.yzzw).
        /// </summary>
        public uvec4 gbba => new uvec4(y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.yzzwx swizzling.
        /// </summary>
        public uvec5 yzzwx => new uvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.gbbar swizzling (equivalent to uvec4.yzzwx).
        /// </summary>
        public uvec5 gbbar => new uvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.yzzwy swizzling.
        /// </summary>
        public uvec5 yzzwy => new uvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.gbbag swizzling (equivalent to uvec4.yzzwy).
        /// </summary>
        public uvec5 gbbag => new uvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.yzzwz swizzling.
        /// </summary>
        public uvec5 yzzwz => new uvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.gbbab swizzling (equivalent to uvec4.yzzwz).
        /// </summary>
        public uvec5 gbbab => new uvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.yzzww swizzling.
        /// </summary>
        public uvec5 yzzww => new uvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.gbbaa swizzling (equivalent to uvec4.yzzww).
        /// </summary>
        public uvec5 gbbaa => new uvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.yzw swizzling.
        /// </summary>
        public uvec3 yzw => new uvec3(y, z, w);
        
        /// <summary>
        /// Returns uvec4.gba swizzling (equivalent to uvec4.yzw).
        /// </summary>
        public uvec3 gba => new uvec3(y, z, w);
        
        /// <summary>
        /// Returns uvec4.yzwx swizzling.
        /// </summary>
        public uvec4 yzwx => new uvec4(y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.gbar swizzling (equivalent to uvec4.yzwx).
        /// </summary>
        public uvec4 gbar => new uvec4(y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.yzwxx swizzling.
        /// </summary>
        public uvec5 yzwxx => new uvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.gbarr swizzling (equivalent to uvec4.yzwxx).
        /// </summary>
        public uvec5 gbarr => new uvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.yzwxy swizzling.
        /// </summary>
        public uvec5 yzwxy => new uvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.gbarg swizzling (equivalent to uvec4.yzwxy).
        /// </summary>
        public uvec5 gbarg => new uvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.yzwxz swizzling.
        /// </summary>
        public uvec5 yzwxz => new uvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.gbarb swizzling (equivalent to uvec4.yzwxz).
        /// </summary>
        public uvec5 gbarb => new uvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.yzwxw swizzling.
        /// </summary>
        public uvec5 yzwxw => new uvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.gbara swizzling (equivalent to uvec4.yzwxw).
        /// </summary>
        public uvec5 gbara => new uvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.yzwy swizzling.
        /// </summary>
        public uvec4 yzwy => new uvec4(y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.gbag swizzling (equivalent to uvec4.yzwy).
        /// </summary>
        public uvec4 gbag => new uvec4(y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.yzwyx swizzling.
        /// </summary>
        public uvec5 yzwyx => new uvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.gbagr swizzling (equivalent to uvec4.yzwyx).
        /// </summary>
        public uvec5 gbagr => new uvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.yzwyy swizzling.
        /// </summary>
        public uvec5 yzwyy => new uvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.gbagg swizzling (equivalent to uvec4.yzwyy).
        /// </summary>
        public uvec5 gbagg => new uvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.yzwyz swizzling.
        /// </summary>
        public uvec5 yzwyz => new uvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.gbagb swizzling (equivalent to uvec4.yzwyz).
        /// </summary>
        public uvec5 gbagb => new uvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.yzwyw swizzling.
        /// </summary>
        public uvec5 yzwyw => new uvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.gbaga swizzling (equivalent to uvec4.yzwyw).
        /// </summary>
        public uvec5 gbaga => new uvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.yzwz swizzling.
        /// </summary>
        public uvec4 yzwz => new uvec4(y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.gbab swizzling (equivalent to uvec4.yzwz).
        /// </summary>
        public uvec4 gbab => new uvec4(y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.yzwzx swizzling.
        /// </summary>
        public uvec5 yzwzx => new uvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.gbabr swizzling (equivalent to uvec4.yzwzx).
        /// </summary>
        public uvec5 gbabr => new uvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.yzwzy swizzling.
        /// </summary>
        public uvec5 yzwzy => new uvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.gbabg swizzling (equivalent to uvec4.yzwzy).
        /// </summary>
        public uvec5 gbabg => new uvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.yzwzz swizzling.
        /// </summary>
        public uvec5 yzwzz => new uvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.gbabb swizzling (equivalent to uvec4.yzwzz).
        /// </summary>
        public uvec5 gbabb => new uvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.yzwzw swizzling.
        /// </summary>
        public uvec5 yzwzw => new uvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.gbaba swizzling (equivalent to uvec4.yzwzw).
        /// </summary>
        public uvec5 gbaba => new uvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.yzww swizzling.
        /// </summary>
        public uvec4 yzww => new uvec4(y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.gbaa swizzling (equivalent to uvec4.yzww).
        /// </summary>
        public uvec4 gbaa => new uvec4(y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.yzwwx swizzling.
        /// </summary>
        public uvec5 yzwwx => new uvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.gbaar swizzling (equivalent to uvec4.yzwwx).
        /// </summary>
        public uvec5 gbaar => new uvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.yzwwy swizzling.
        /// </summary>
        public uvec5 yzwwy => new uvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.gbaag swizzling (equivalent to uvec4.yzwwy).
        /// </summary>
        public uvec5 gbaag => new uvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.yzwwz swizzling.
        /// </summary>
        public uvec5 yzwwz => new uvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.gbaab swizzling (equivalent to uvec4.yzwwz).
        /// </summary>
        public uvec5 gbaab => new uvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.yzwww swizzling.
        /// </summary>
        public uvec5 yzwww => new uvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.gbaaa swizzling (equivalent to uvec4.yzwww).
        /// </summary>
        public uvec5 gbaaa => new uvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.yw swizzling.
        /// </summary>
        public uvec2 yw => new uvec2(y, w);
        
        /// <summary>
        /// Returns uvec4.ga swizzling (equivalent to uvec4.yw).
        /// </summary>
        public uvec2 ga => new uvec2(y, w);
        
        /// <summary>
        /// Returns uvec4.ywx swizzling.
        /// </summary>
        public uvec3 ywx => new uvec3(y, w, x);
        
        /// <summary>
        /// Returns uvec4.gar swizzling (equivalent to uvec4.ywx).
        /// </summary>
        public uvec3 gar => new uvec3(y, w, x);
        
        /// <summary>
        /// Returns uvec4.ywxx swizzling.
        /// </summary>
        public uvec4 ywxx => new uvec4(y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.garr swizzling (equivalent to uvec4.ywxx).
        /// </summary>
        public uvec4 garr => new uvec4(y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.ywxxx swizzling.
        /// </summary>
        public uvec5 ywxxx => new uvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.garrr swizzling (equivalent to uvec4.ywxxx).
        /// </summary>
        public uvec5 garrr => new uvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.ywxxy swizzling.
        /// </summary>
        public uvec5 ywxxy => new uvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.garrg swizzling (equivalent to uvec4.ywxxy).
        /// </summary>
        public uvec5 garrg => new uvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.ywxxz swizzling.
        /// </summary>
        public uvec5 ywxxz => new uvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.garrb swizzling (equivalent to uvec4.ywxxz).
        /// </summary>
        public uvec5 garrb => new uvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.ywxxw swizzling.
        /// </summary>
        public uvec5 ywxxw => new uvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.garra swizzling (equivalent to uvec4.ywxxw).
        /// </summary>
        public uvec5 garra => new uvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.ywxy swizzling.
        /// </summary>
        public uvec4 ywxy => new uvec4(y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.garg swizzling (equivalent to uvec4.ywxy).
        /// </summary>
        public uvec4 garg => new uvec4(y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.ywxyx swizzling.
        /// </summary>
        public uvec5 ywxyx => new uvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.gargr swizzling (equivalent to uvec4.ywxyx).
        /// </summary>
        public uvec5 gargr => new uvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.ywxyy swizzling.
        /// </summary>
        public uvec5 ywxyy => new uvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.gargg swizzling (equivalent to uvec4.ywxyy).
        /// </summary>
        public uvec5 gargg => new uvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.ywxyz swizzling.
        /// </summary>
        public uvec5 ywxyz => new uvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.gargb swizzling (equivalent to uvec4.ywxyz).
        /// </summary>
        public uvec5 gargb => new uvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.ywxyw swizzling.
        /// </summary>
        public uvec5 ywxyw => new uvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.garga swizzling (equivalent to uvec4.ywxyw).
        /// </summary>
        public uvec5 garga => new uvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.ywxz swizzling.
        /// </summary>
        public uvec4 ywxz => new uvec4(y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.garb swizzling (equivalent to uvec4.ywxz).
        /// </summary>
        public uvec4 garb => new uvec4(y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.ywxzx swizzling.
        /// </summary>
        public uvec5 ywxzx => new uvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.garbr swizzling (equivalent to uvec4.ywxzx).
        /// </summary>
        public uvec5 garbr => new uvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.ywxzy swizzling.
        /// </summary>
        public uvec5 ywxzy => new uvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.garbg swizzling (equivalent to uvec4.ywxzy).
        /// </summary>
        public uvec5 garbg => new uvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.ywxzz swizzling.
        /// </summary>
        public uvec5 ywxzz => new uvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.garbb swizzling (equivalent to uvec4.ywxzz).
        /// </summary>
        public uvec5 garbb => new uvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.ywxzw swizzling.
        /// </summary>
        public uvec5 ywxzw => new uvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.garba swizzling (equivalent to uvec4.ywxzw).
        /// </summary>
        public uvec5 garba => new uvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.ywxw swizzling.
        /// </summary>
        public uvec4 ywxw => new uvec4(y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.gara swizzling (equivalent to uvec4.ywxw).
        /// </summary>
        public uvec4 gara => new uvec4(y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.ywxwx swizzling.
        /// </summary>
        public uvec5 ywxwx => new uvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.garar swizzling (equivalent to uvec4.ywxwx).
        /// </summary>
        public uvec5 garar => new uvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.ywxwy swizzling.
        /// </summary>
        public uvec5 ywxwy => new uvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.garag swizzling (equivalent to uvec4.ywxwy).
        /// </summary>
        public uvec5 garag => new uvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.ywxwz swizzling.
        /// </summary>
        public uvec5 ywxwz => new uvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.garab swizzling (equivalent to uvec4.ywxwz).
        /// </summary>
        public uvec5 garab => new uvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.ywxww swizzling.
        /// </summary>
        public uvec5 ywxww => new uvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.garaa swizzling (equivalent to uvec4.ywxww).
        /// </summary>
        public uvec5 garaa => new uvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.ywy swizzling.
        /// </summary>
        public uvec3 ywy => new uvec3(y, w, y);
        
        /// <summary>
        /// Returns uvec4.gag swizzling (equivalent to uvec4.ywy).
        /// </summary>
        public uvec3 gag => new uvec3(y, w, y);
        
        /// <summary>
        /// Returns uvec4.ywyx swizzling.
        /// </summary>
        public uvec4 ywyx => new uvec4(y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.gagr swizzling (equivalent to uvec4.ywyx).
        /// </summary>
        public uvec4 gagr => new uvec4(y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.ywyxx swizzling.
        /// </summary>
        public uvec5 ywyxx => new uvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.gagrr swizzling (equivalent to uvec4.ywyxx).
        /// </summary>
        public uvec5 gagrr => new uvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.ywyxy swizzling.
        /// </summary>
        public uvec5 ywyxy => new uvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.gagrg swizzling (equivalent to uvec4.ywyxy).
        /// </summary>
        public uvec5 gagrg => new uvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.ywyxz swizzling.
        /// </summary>
        public uvec5 ywyxz => new uvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.gagrb swizzling (equivalent to uvec4.ywyxz).
        /// </summary>
        public uvec5 gagrb => new uvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.ywyxw swizzling.
        /// </summary>
        public uvec5 ywyxw => new uvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.gagra swizzling (equivalent to uvec4.ywyxw).
        /// </summary>
        public uvec5 gagra => new uvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.ywyy swizzling.
        /// </summary>
        public uvec4 ywyy => new uvec4(y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.gagg swizzling (equivalent to uvec4.ywyy).
        /// </summary>
        public uvec4 gagg => new uvec4(y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.ywyyx swizzling.
        /// </summary>
        public uvec5 ywyyx => new uvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.gaggr swizzling (equivalent to uvec4.ywyyx).
        /// </summary>
        public uvec5 gaggr => new uvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.ywyyy swizzling.
        /// </summary>
        public uvec5 ywyyy => new uvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.gaggg swizzling (equivalent to uvec4.ywyyy).
        /// </summary>
        public uvec5 gaggg => new uvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.ywyyz swizzling.
        /// </summary>
        public uvec5 ywyyz => new uvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.gaggb swizzling (equivalent to uvec4.ywyyz).
        /// </summary>
        public uvec5 gaggb => new uvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.ywyyw swizzling.
        /// </summary>
        public uvec5 ywyyw => new uvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.gagga swizzling (equivalent to uvec4.ywyyw).
        /// </summary>
        public uvec5 gagga => new uvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.ywyz swizzling.
        /// </summary>
        public uvec4 ywyz => new uvec4(y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.gagb swizzling (equivalent to uvec4.ywyz).
        /// </summary>
        public uvec4 gagb => new uvec4(y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.ywyzx swizzling.
        /// </summary>
        public uvec5 ywyzx => new uvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.gagbr swizzling (equivalent to uvec4.ywyzx).
        /// </summary>
        public uvec5 gagbr => new uvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.ywyzy swizzling.
        /// </summary>
        public uvec5 ywyzy => new uvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.gagbg swizzling (equivalent to uvec4.ywyzy).
        /// </summary>
        public uvec5 gagbg => new uvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.ywyzz swizzling.
        /// </summary>
        public uvec5 ywyzz => new uvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.gagbb swizzling (equivalent to uvec4.ywyzz).
        /// </summary>
        public uvec5 gagbb => new uvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.ywyzw swizzling.
        /// </summary>
        public uvec5 ywyzw => new uvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.gagba swizzling (equivalent to uvec4.ywyzw).
        /// </summary>
        public uvec5 gagba => new uvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.ywyw swizzling.
        /// </summary>
        public uvec4 ywyw => new uvec4(y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.gaga swizzling (equivalent to uvec4.ywyw).
        /// </summary>
        public uvec4 gaga => new uvec4(y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.ywywx swizzling.
        /// </summary>
        public uvec5 ywywx => new uvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.gagar swizzling (equivalent to uvec4.ywywx).
        /// </summary>
        public uvec5 gagar => new uvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.ywywy swizzling.
        /// </summary>
        public uvec5 ywywy => new uvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.gagag swizzling (equivalent to uvec4.ywywy).
        /// </summary>
        public uvec5 gagag => new uvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.ywywz swizzling.
        /// </summary>
        public uvec5 ywywz => new uvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.gagab swizzling (equivalent to uvec4.ywywz).
        /// </summary>
        public uvec5 gagab => new uvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.ywyww swizzling.
        /// </summary>
        public uvec5 ywyww => new uvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.gagaa swizzling (equivalent to uvec4.ywyww).
        /// </summary>
        public uvec5 gagaa => new uvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.ywz swizzling.
        /// </summary>
        public uvec3 ywz => new uvec3(y, w, z);
        
        /// <summary>
        /// Returns uvec4.gab swizzling (equivalent to uvec4.ywz).
        /// </summary>
        public uvec3 gab => new uvec3(y, w, z);
        
        /// <summary>
        /// Returns uvec4.ywzx swizzling.
        /// </summary>
        public uvec4 ywzx => new uvec4(y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.gabr swizzling (equivalent to uvec4.ywzx).
        /// </summary>
        public uvec4 gabr => new uvec4(y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.ywzxx swizzling.
        /// </summary>
        public uvec5 ywzxx => new uvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.gabrr swizzling (equivalent to uvec4.ywzxx).
        /// </summary>
        public uvec5 gabrr => new uvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.ywzxy swizzling.
        /// </summary>
        public uvec5 ywzxy => new uvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.gabrg swizzling (equivalent to uvec4.ywzxy).
        /// </summary>
        public uvec5 gabrg => new uvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.ywzxz swizzling.
        /// </summary>
        public uvec5 ywzxz => new uvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.gabrb swizzling (equivalent to uvec4.ywzxz).
        /// </summary>
        public uvec5 gabrb => new uvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.ywzxw swizzling.
        /// </summary>
        public uvec5 ywzxw => new uvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.gabra swizzling (equivalent to uvec4.ywzxw).
        /// </summary>
        public uvec5 gabra => new uvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.ywzy swizzling.
        /// </summary>
        public uvec4 ywzy => new uvec4(y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.gabg swizzling (equivalent to uvec4.ywzy).
        /// </summary>
        public uvec4 gabg => new uvec4(y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.ywzyx swizzling.
        /// </summary>
        public uvec5 ywzyx => new uvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.gabgr swizzling (equivalent to uvec4.ywzyx).
        /// </summary>
        public uvec5 gabgr => new uvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.ywzyy swizzling.
        /// </summary>
        public uvec5 ywzyy => new uvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.gabgg swizzling (equivalent to uvec4.ywzyy).
        /// </summary>
        public uvec5 gabgg => new uvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.ywzyz swizzling.
        /// </summary>
        public uvec5 ywzyz => new uvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.gabgb swizzling (equivalent to uvec4.ywzyz).
        /// </summary>
        public uvec5 gabgb => new uvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.ywzyw swizzling.
        /// </summary>
        public uvec5 ywzyw => new uvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.gabga swizzling (equivalent to uvec4.ywzyw).
        /// </summary>
        public uvec5 gabga => new uvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.ywzz swizzling.
        /// </summary>
        public uvec4 ywzz => new uvec4(y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.gabb swizzling (equivalent to uvec4.ywzz).
        /// </summary>
        public uvec4 gabb => new uvec4(y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.ywzzx swizzling.
        /// </summary>
        public uvec5 ywzzx => new uvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.gabbr swizzling (equivalent to uvec4.ywzzx).
        /// </summary>
        public uvec5 gabbr => new uvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.ywzzy swizzling.
        /// </summary>
        public uvec5 ywzzy => new uvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.gabbg swizzling (equivalent to uvec4.ywzzy).
        /// </summary>
        public uvec5 gabbg => new uvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.ywzzz swizzling.
        /// </summary>
        public uvec5 ywzzz => new uvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.gabbb swizzling (equivalent to uvec4.ywzzz).
        /// </summary>
        public uvec5 gabbb => new uvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.ywzzw swizzling.
        /// </summary>
        public uvec5 ywzzw => new uvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.gabba swizzling (equivalent to uvec4.ywzzw).
        /// </summary>
        public uvec5 gabba => new uvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.ywzw swizzling.
        /// </summary>
        public uvec4 ywzw => new uvec4(y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.gaba swizzling (equivalent to uvec4.ywzw).
        /// </summary>
        public uvec4 gaba => new uvec4(y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.ywzwx swizzling.
        /// </summary>
        public uvec5 ywzwx => new uvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.gabar swizzling (equivalent to uvec4.ywzwx).
        /// </summary>
        public uvec5 gabar => new uvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.ywzwy swizzling.
        /// </summary>
        public uvec5 ywzwy => new uvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.gabag swizzling (equivalent to uvec4.ywzwy).
        /// </summary>
        public uvec5 gabag => new uvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.ywzwz swizzling.
        /// </summary>
        public uvec5 ywzwz => new uvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.gabab swizzling (equivalent to uvec4.ywzwz).
        /// </summary>
        public uvec5 gabab => new uvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.ywzww swizzling.
        /// </summary>
        public uvec5 ywzww => new uvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.gabaa swizzling (equivalent to uvec4.ywzww).
        /// </summary>
        public uvec5 gabaa => new uvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.yww swizzling.
        /// </summary>
        public uvec3 yww => new uvec3(y, w, w);
        
        /// <summary>
        /// Returns uvec4.gaa swizzling (equivalent to uvec4.yww).
        /// </summary>
        public uvec3 gaa => new uvec3(y, w, w);
        
        /// <summary>
        /// Returns uvec4.ywwx swizzling.
        /// </summary>
        public uvec4 ywwx => new uvec4(y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.gaar swizzling (equivalent to uvec4.ywwx).
        /// </summary>
        public uvec4 gaar => new uvec4(y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.ywwxx swizzling.
        /// </summary>
        public uvec5 ywwxx => new uvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.gaarr swizzling (equivalent to uvec4.ywwxx).
        /// </summary>
        public uvec5 gaarr => new uvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.ywwxy swizzling.
        /// </summary>
        public uvec5 ywwxy => new uvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.gaarg swizzling (equivalent to uvec4.ywwxy).
        /// </summary>
        public uvec5 gaarg => new uvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.ywwxz swizzling.
        /// </summary>
        public uvec5 ywwxz => new uvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.gaarb swizzling (equivalent to uvec4.ywwxz).
        /// </summary>
        public uvec5 gaarb => new uvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.ywwxw swizzling.
        /// </summary>
        public uvec5 ywwxw => new uvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.gaara swizzling (equivalent to uvec4.ywwxw).
        /// </summary>
        public uvec5 gaara => new uvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.ywwy swizzling.
        /// </summary>
        public uvec4 ywwy => new uvec4(y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.gaag swizzling (equivalent to uvec4.ywwy).
        /// </summary>
        public uvec4 gaag => new uvec4(y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.ywwyx swizzling.
        /// </summary>
        public uvec5 ywwyx => new uvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.gaagr swizzling (equivalent to uvec4.ywwyx).
        /// </summary>
        public uvec5 gaagr => new uvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.ywwyy swizzling.
        /// </summary>
        public uvec5 ywwyy => new uvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.gaagg swizzling (equivalent to uvec4.ywwyy).
        /// </summary>
        public uvec5 gaagg => new uvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.ywwyz swizzling.
        /// </summary>
        public uvec5 ywwyz => new uvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.gaagb swizzling (equivalent to uvec4.ywwyz).
        /// </summary>
        public uvec5 gaagb => new uvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.ywwyw swizzling.
        /// </summary>
        public uvec5 ywwyw => new uvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.gaaga swizzling (equivalent to uvec4.ywwyw).
        /// </summary>
        public uvec5 gaaga => new uvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.ywwz swizzling.
        /// </summary>
        public uvec4 ywwz => new uvec4(y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.gaab swizzling (equivalent to uvec4.ywwz).
        /// </summary>
        public uvec4 gaab => new uvec4(y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.ywwzx swizzling.
        /// </summary>
        public uvec5 ywwzx => new uvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.gaabr swizzling (equivalent to uvec4.ywwzx).
        /// </summary>
        public uvec5 gaabr => new uvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.ywwzy swizzling.
        /// </summary>
        public uvec5 ywwzy => new uvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.gaabg swizzling (equivalent to uvec4.ywwzy).
        /// </summary>
        public uvec5 gaabg => new uvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.ywwzz swizzling.
        /// </summary>
        public uvec5 ywwzz => new uvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.gaabb swizzling (equivalent to uvec4.ywwzz).
        /// </summary>
        public uvec5 gaabb => new uvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.ywwzw swizzling.
        /// </summary>
        public uvec5 ywwzw => new uvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.gaaba swizzling (equivalent to uvec4.ywwzw).
        /// </summary>
        public uvec5 gaaba => new uvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.ywww swizzling.
        /// </summary>
        public uvec4 ywww => new uvec4(y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.gaaa swizzling (equivalent to uvec4.ywww).
        /// </summary>
        public uvec4 gaaa => new uvec4(y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.ywwwx swizzling.
        /// </summary>
        public uvec5 ywwwx => new uvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.gaaar swizzling (equivalent to uvec4.ywwwx).
        /// </summary>
        public uvec5 gaaar => new uvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.ywwwy swizzling.
        /// </summary>
        public uvec5 ywwwy => new uvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.gaaag swizzling (equivalent to uvec4.ywwwy).
        /// </summary>
        public uvec5 gaaag => new uvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.ywwwz swizzling.
        /// </summary>
        public uvec5 ywwwz => new uvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.gaaab swizzling (equivalent to uvec4.ywwwz).
        /// </summary>
        public uvec5 gaaab => new uvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.ywwww swizzling.
        /// </summary>
        public uvec5 ywwww => new uvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns uvec4.gaaaa swizzling (equivalent to uvec4.ywwww).
        /// </summary>
        public uvec5 gaaaa => new uvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns uvec4.zx swizzling.
        /// </summary>
        public uvec2 zx => new uvec2(z, x);
        
        /// <summary>
        /// Returns uvec4.br swizzling (equivalent to uvec4.zx).
        /// </summary>
        public uvec2 br => new uvec2(z, x);
        
        /// <summary>
        /// Returns uvec4.zxx swizzling.
        /// </summary>
        public uvec3 zxx => new uvec3(z, x, x);
        
        /// <summary>
        /// Returns uvec4.brr swizzling (equivalent to uvec4.zxx).
        /// </summary>
        public uvec3 brr => new uvec3(z, x, x);
        
        /// <summary>
        /// Returns uvec4.zxxx swizzling.
        /// </summary>
        public uvec4 zxxx => new uvec4(z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.brrr swizzling (equivalent to uvec4.zxxx).
        /// </summary>
        public uvec4 brrr => new uvec4(z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.zxxxx swizzling.
        /// </summary>
        public uvec5 zxxxx => new uvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.brrrr swizzling (equivalent to uvec4.zxxxx).
        /// </summary>
        public uvec5 brrrr => new uvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.zxxxy swizzling.
        /// </summary>
        public uvec5 zxxxy => new uvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.brrrg swizzling (equivalent to uvec4.zxxxy).
        /// </summary>
        public uvec5 brrrg => new uvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.zxxxz swizzling.
        /// </summary>
        public uvec5 zxxxz => new uvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.brrrb swizzling (equivalent to uvec4.zxxxz).
        /// </summary>
        public uvec5 brrrb => new uvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.zxxxw swizzling.
        /// </summary>
        public uvec5 zxxxw => new uvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.brrra swizzling (equivalent to uvec4.zxxxw).
        /// </summary>
        public uvec5 brrra => new uvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.zxxy swizzling.
        /// </summary>
        public uvec4 zxxy => new uvec4(z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.brrg swizzling (equivalent to uvec4.zxxy).
        /// </summary>
        public uvec4 brrg => new uvec4(z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.zxxyx swizzling.
        /// </summary>
        public uvec5 zxxyx => new uvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.brrgr swizzling (equivalent to uvec4.zxxyx).
        /// </summary>
        public uvec5 brrgr => new uvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.zxxyy swizzling.
        /// </summary>
        public uvec5 zxxyy => new uvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.brrgg swizzling (equivalent to uvec4.zxxyy).
        /// </summary>
        public uvec5 brrgg => new uvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.zxxyz swizzling.
        /// </summary>
        public uvec5 zxxyz => new uvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.brrgb swizzling (equivalent to uvec4.zxxyz).
        /// </summary>
        public uvec5 brrgb => new uvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.zxxyw swizzling.
        /// </summary>
        public uvec5 zxxyw => new uvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.brrga swizzling (equivalent to uvec4.zxxyw).
        /// </summary>
        public uvec5 brrga => new uvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.zxxz swizzling.
        /// </summary>
        public uvec4 zxxz => new uvec4(z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.brrb swizzling (equivalent to uvec4.zxxz).
        /// </summary>
        public uvec4 brrb => new uvec4(z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.zxxzx swizzling.
        /// </summary>
        public uvec5 zxxzx => new uvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.brrbr swizzling (equivalent to uvec4.zxxzx).
        /// </summary>
        public uvec5 brrbr => new uvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.zxxzy swizzling.
        /// </summary>
        public uvec5 zxxzy => new uvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.brrbg swizzling (equivalent to uvec4.zxxzy).
        /// </summary>
        public uvec5 brrbg => new uvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.zxxzz swizzling.
        /// </summary>
        public uvec5 zxxzz => new uvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.brrbb swizzling (equivalent to uvec4.zxxzz).
        /// </summary>
        public uvec5 brrbb => new uvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.zxxzw swizzling.
        /// </summary>
        public uvec5 zxxzw => new uvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.brrba swizzling (equivalent to uvec4.zxxzw).
        /// </summary>
        public uvec5 brrba => new uvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.zxxw swizzling.
        /// </summary>
        public uvec4 zxxw => new uvec4(z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.brra swizzling (equivalent to uvec4.zxxw).
        /// </summary>
        public uvec4 brra => new uvec4(z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.zxxwx swizzling.
        /// </summary>
        public uvec5 zxxwx => new uvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.brrar swizzling (equivalent to uvec4.zxxwx).
        /// </summary>
        public uvec5 brrar => new uvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.zxxwy swizzling.
        /// </summary>
        public uvec5 zxxwy => new uvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.brrag swizzling (equivalent to uvec4.zxxwy).
        /// </summary>
        public uvec5 brrag => new uvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.zxxwz swizzling.
        /// </summary>
        public uvec5 zxxwz => new uvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.brrab swizzling (equivalent to uvec4.zxxwz).
        /// </summary>
        public uvec5 brrab => new uvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.zxxww swizzling.
        /// </summary>
        public uvec5 zxxww => new uvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.brraa swizzling (equivalent to uvec4.zxxww).
        /// </summary>
        public uvec5 brraa => new uvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.zxy swizzling.
        /// </summary>
        public uvec3 zxy => new uvec3(z, x, y);
        
        /// <summary>
        /// Returns uvec4.brg swizzling (equivalent to uvec4.zxy).
        /// </summary>
        public uvec3 brg => new uvec3(z, x, y);
        
        /// <summary>
        /// Returns uvec4.zxyx swizzling.
        /// </summary>
        public uvec4 zxyx => new uvec4(z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.brgr swizzling (equivalent to uvec4.zxyx).
        /// </summary>
        public uvec4 brgr => new uvec4(z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.zxyxx swizzling.
        /// </summary>
        public uvec5 zxyxx => new uvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.brgrr swizzling (equivalent to uvec4.zxyxx).
        /// </summary>
        public uvec5 brgrr => new uvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.zxyxy swizzling.
        /// </summary>
        public uvec5 zxyxy => new uvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.brgrg swizzling (equivalent to uvec4.zxyxy).
        /// </summary>
        public uvec5 brgrg => new uvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.zxyxz swizzling.
        /// </summary>
        public uvec5 zxyxz => new uvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.brgrb swizzling (equivalent to uvec4.zxyxz).
        /// </summary>
        public uvec5 brgrb => new uvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.zxyxw swizzling.
        /// </summary>
        public uvec5 zxyxw => new uvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.brgra swizzling (equivalent to uvec4.zxyxw).
        /// </summary>
        public uvec5 brgra => new uvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.zxyy swizzling.
        /// </summary>
        public uvec4 zxyy => new uvec4(z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.brgg swizzling (equivalent to uvec4.zxyy).
        /// </summary>
        public uvec4 brgg => new uvec4(z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.zxyyx swizzling.
        /// </summary>
        public uvec5 zxyyx => new uvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.brggr swizzling (equivalent to uvec4.zxyyx).
        /// </summary>
        public uvec5 brggr => new uvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.zxyyy swizzling.
        /// </summary>
        public uvec5 zxyyy => new uvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.brggg swizzling (equivalent to uvec4.zxyyy).
        /// </summary>
        public uvec5 brggg => new uvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.zxyyz swizzling.
        /// </summary>
        public uvec5 zxyyz => new uvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.brggb swizzling (equivalent to uvec4.zxyyz).
        /// </summary>
        public uvec5 brggb => new uvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.zxyyw swizzling.
        /// </summary>
        public uvec5 zxyyw => new uvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.brgga swizzling (equivalent to uvec4.zxyyw).
        /// </summary>
        public uvec5 brgga => new uvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.zxyz swizzling.
        /// </summary>
        public uvec4 zxyz => new uvec4(z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.brgb swizzling (equivalent to uvec4.zxyz).
        /// </summary>
        public uvec4 brgb => new uvec4(z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.zxyzx swizzling.
        /// </summary>
        public uvec5 zxyzx => new uvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.brgbr swizzling (equivalent to uvec4.zxyzx).
        /// </summary>
        public uvec5 brgbr => new uvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.zxyzy swizzling.
        /// </summary>
        public uvec5 zxyzy => new uvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.brgbg swizzling (equivalent to uvec4.zxyzy).
        /// </summary>
        public uvec5 brgbg => new uvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.zxyzz swizzling.
        /// </summary>
        public uvec5 zxyzz => new uvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.brgbb swizzling (equivalent to uvec4.zxyzz).
        /// </summary>
        public uvec5 brgbb => new uvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.zxyzw swizzling.
        /// </summary>
        public uvec5 zxyzw => new uvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.brgba swizzling (equivalent to uvec4.zxyzw).
        /// </summary>
        public uvec5 brgba => new uvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.zxyw swizzling.
        /// </summary>
        public uvec4 zxyw => new uvec4(z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.brga swizzling (equivalent to uvec4.zxyw).
        /// </summary>
        public uvec4 brga => new uvec4(z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.zxywx swizzling.
        /// </summary>
        public uvec5 zxywx => new uvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.brgar swizzling (equivalent to uvec4.zxywx).
        /// </summary>
        public uvec5 brgar => new uvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.zxywy swizzling.
        /// </summary>
        public uvec5 zxywy => new uvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.brgag swizzling (equivalent to uvec4.zxywy).
        /// </summary>
        public uvec5 brgag => new uvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.zxywz swizzling.
        /// </summary>
        public uvec5 zxywz => new uvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.brgab swizzling (equivalent to uvec4.zxywz).
        /// </summary>
        public uvec5 brgab => new uvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.zxyww swizzling.
        /// </summary>
        public uvec5 zxyww => new uvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.brgaa swizzling (equivalent to uvec4.zxyww).
        /// </summary>
        public uvec5 brgaa => new uvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.zxz swizzling.
        /// </summary>
        public uvec3 zxz => new uvec3(z, x, z);
        
        /// <summary>
        /// Returns uvec4.brb swizzling (equivalent to uvec4.zxz).
        /// </summary>
        public uvec3 brb => new uvec3(z, x, z);
        
        /// <summary>
        /// Returns uvec4.zxzx swizzling.
        /// </summary>
        public uvec4 zxzx => new uvec4(z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.brbr swizzling (equivalent to uvec4.zxzx).
        /// </summary>
        public uvec4 brbr => new uvec4(z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.zxzxx swizzling.
        /// </summary>
        public uvec5 zxzxx => new uvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.brbrr swizzling (equivalent to uvec4.zxzxx).
        /// </summary>
        public uvec5 brbrr => new uvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.zxzxy swizzling.
        /// </summary>
        public uvec5 zxzxy => new uvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.brbrg swizzling (equivalent to uvec4.zxzxy).
        /// </summary>
        public uvec5 brbrg => new uvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.zxzxz swizzling.
        /// </summary>
        public uvec5 zxzxz => new uvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.brbrb swizzling (equivalent to uvec4.zxzxz).
        /// </summary>
        public uvec5 brbrb => new uvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.zxzxw swizzling.
        /// </summary>
        public uvec5 zxzxw => new uvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.brbra swizzling (equivalent to uvec4.zxzxw).
        /// </summary>
        public uvec5 brbra => new uvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.zxzy swizzling.
        /// </summary>
        public uvec4 zxzy => new uvec4(z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.brbg swizzling (equivalent to uvec4.zxzy).
        /// </summary>
        public uvec4 brbg => new uvec4(z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.zxzyx swizzling.
        /// </summary>
        public uvec5 zxzyx => new uvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.brbgr swizzling (equivalent to uvec4.zxzyx).
        /// </summary>
        public uvec5 brbgr => new uvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.zxzyy swizzling.
        /// </summary>
        public uvec5 zxzyy => new uvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.brbgg swizzling (equivalent to uvec4.zxzyy).
        /// </summary>
        public uvec5 brbgg => new uvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.zxzyz swizzling.
        /// </summary>
        public uvec5 zxzyz => new uvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.brbgb swizzling (equivalent to uvec4.zxzyz).
        /// </summary>
        public uvec5 brbgb => new uvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.zxzyw swizzling.
        /// </summary>
        public uvec5 zxzyw => new uvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.brbga swizzling (equivalent to uvec4.zxzyw).
        /// </summary>
        public uvec5 brbga => new uvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.zxzz swizzling.
        /// </summary>
        public uvec4 zxzz => new uvec4(z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.brbb swizzling (equivalent to uvec4.zxzz).
        /// </summary>
        public uvec4 brbb => new uvec4(z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.zxzzx swizzling.
        /// </summary>
        public uvec5 zxzzx => new uvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.brbbr swizzling (equivalent to uvec4.zxzzx).
        /// </summary>
        public uvec5 brbbr => new uvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.zxzzy swizzling.
        /// </summary>
        public uvec5 zxzzy => new uvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.brbbg swizzling (equivalent to uvec4.zxzzy).
        /// </summary>
        public uvec5 brbbg => new uvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.zxzzz swizzling.
        /// </summary>
        public uvec5 zxzzz => new uvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.brbbb swizzling (equivalent to uvec4.zxzzz).
        /// </summary>
        public uvec5 brbbb => new uvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.zxzzw swizzling.
        /// </summary>
        public uvec5 zxzzw => new uvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.brbba swizzling (equivalent to uvec4.zxzzw).
        /// </summary>
        public uvec5 brbba => new uvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.zxzw swizzling.
        /// </summary>
        public uvec4 zxzw => new uvec4(z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.brba swizzling (equivalent to uvec4.zxzw).
        /// </summary>
        public uvec4 brba => new uvec4(z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.zxzwx swizzling.
        /// </summary>
        public uvec5 zxzwx => new uvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.brbar swizzling (equivalent to uvec4.zxzwx).
        /// </summary>
        public uvec5 brbar => new uvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.zxzwy swizzling.
        /// </summary>
        public uvec5 zxzwy => new uvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.brbag swizzling (equivalent to uvec4.zxzwy).
        /// </summary>
        public uvec5 brbag => new uvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.zxzwz swizzling.
        /// </summary>
        public uvec5 zxzwz => new uvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.brbab swizzling (equivalent to uvec4.zxzwz).
        /// </summary>
        public uvec5 brbab => new uvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.zxzww swizzling.
        /// </summary>
        public uvec5 zxzww => new uvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.brbaa swizzling (equivalent to uvec4.zxzww).
        /// </summary>
        public uvec5 brbaa => new uvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.zxw swizzling.
        /// </summary>
        public uvec3 zxw => new uvec3(z, x, w);
        
        /// <summary>
        /// Returns uvec4.bra swizzling (equivalent to uvec4.zxw).
        /// </summary>
        public uvec3 bra => new uvec3(z, x, w);
        
        /// <summary>
        /// Returns uvec4.zxwx swizzling.
        /// </summary>
        public uvec4 zxwx => new uvec4(z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.brar swizzling (equivalent to uvec4.zxwx).
        /// </summary>
        public uvec4 brar => new uvec4(z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.zxwxx swizzling.
        /// </summary>
        public uvec5 zxwxx => new uvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.brarr swizzling (equivalent to uvec4.zxwxx).
        /// </summary>
        public uvec5 brarr => new uvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.zxwxy swizzling.
        /// </summary>
        public uvec5 zxwxy => new uvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.brarg swizzling (equivalent to uvec4.zxwxy).
        /// </summary>
        public uvec5 brarg => new uvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.zxwxz swizzling.
        /// </summary>
        public uvec5 zxwxz => new uvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.brarb swizzling (equivalent to uvec4.zxwxz).
        /// </summary>
        public uvec5 brarb => new uvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.zxwxw swizzling.
        /// </summary>
        public uvec5 zxwxw => new uvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.brara swizzling (equivalent to uvec4.zxwxw).
        /// </summary>
        public uvec5 brara => new uvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.zxwy swizzling.
        /// </summary>
        public uvec4 zxwy => new uvec4(z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.brag swizzling (equivalent to uvec4.zxwy).
        /// </summary>
        public uvec4 brag => new uvec4(z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.zxwyx swizzling.
        /// </summary>
        public uvec5 zxwyx => new uvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.bragr swizzling (equivalent to uvec4.zxwyx).
        /// </summary>
        public uvec5 bragr => new uvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.zxwyy swizzling.
        /// </summary>
        public uvec5 zxwyy => new uvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.bragg swizzling (equivalent to uvec4.zxwyy).
        /// </summary>
        public uvec5 bragg => new uvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.zxwyz swizzling.
        /// </summary>
        public uvec5 zxwyz => new uvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.bragb swizzling (equivalent to uvec4.zxwyz).
        /// </summary>
        public uvec5 bragb => new uvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.zxwyw swizzling.
        /// </summary>
        public uvec5 zxwyw => new uvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.braga swizzling (equivalent to uvec4.zxwyw).
        /// </summary>
        public uvec5 braga => new uvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.zxwz swizzling.
        /// </summary>
        public uvec4 zxwz => new uvec4(z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.brab swizzling (equivalent to uvec4.zxwz).
        /// </summary>
        public uvec4 brab => new uvec4(z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.zxwzx swizzling.
        /// </summary>
        public uvec5 zxwzx => new uvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.brabr swizzling (equivalent to uvec4.zxwzx).
        /// </summary>
        public uvec5 brabr => new uvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.zxwzy swizzling.
        /// </summary>
        public uvec5 zxwzy => new uvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.brabg swizzling (equivalent to uvec4.zxwzy).
        /// </summary>
        public uvec5 brabg => new uvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.zxwzz swizzling.
        /// </summary>
        public uvec5 zxwzz => new uvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.brabb swizzling (equivalent to uvec4.zxwzz).
        /// </summary>
        public uvec5 brabb => new uvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.zxwzw swizzling.
        /// </summary>
        public uvec5 zxwzw => new uvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.braba swizzling (equivalent to uvec4.zxwzw).
        /// </summary>
        public uvec5 braba => new uvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.zxww swizzling.
        /// </summary>
        public uvec4 zxww => new uvec4(z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.braa swizzling (equivalent to uvec4.zxww).
        /// </summary>
        public uvec4 braa => new uvec4(z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.zxwwx swizzling.
        /// </summary>
        public uvec5 zxwwx => new uvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.braar swizzling (equivalent to uvec4.zxwwx).
        /// </summary>
        public uvec5 braar => new uvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.zxwwy swizzling.
        /// </summary>
        public uvec5 zxwwy => new uvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.braag swizzling (equivalent to uvec4.zxwwy).
        /// </summary>
        public uvec5 braag => new uvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.zxwwz swizzling.
        /// </summary>
        public uvec5 zxwwz => new uvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.braab swizzling (equivalent to uvec4.zxwwz).
        /// </summary>
        public uvec5 braab => new uvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.zxwww swizzling.
        /// </summary>
        public uvec5 zxwww => new uvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.braaa swizzling (equivalent to uvec4.zxwww).
        /// </summary>
        public uvec5 braaa => new uvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.zy swizzling.
        /// </summary>
        public uvec2 zy => new uvec2(z, y);
        
        /// <summary>
        /// Returns uvec4.bg swizzling (equivalent to uvec4.zy).
        /// </summary>
        public uvec2 bg => new uvec2(z, y);
        
        /// <summary>
        /// Returns uvec4.zyx swizzling.
        /// </summary>
        public uvec3 zyx => new uvec3(z, y, x);
        
        /// <summary>
        /// Returns uvec4.bgr swizzling (equivalent to uvec4.zyx).
        /// </summary>
        public uvec3 bgr => new uvec3(z, y, x);
        
        /// <summary>
        /// Returns uvec4.zyxx swizzling.
        /// </summary>
        public uvec4 zyxx => new uvec4(z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.bgrr swizzling (equivalent to uvec4.zyxx).
        /// </summary>
        public uvec4 bgrr => new uvec4(z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.zyxxx swizzling.
        /// </summary>
        public uvec5 zyxxx => new uvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.bgrrr swizzling (equivalent to uvec4.zyxxx).
        /// </summary>
        public uvec5 bgrrr => new uvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.zyxxy swizzling.
        /// </summary>
        public uvec5 zyxxy => new uvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.bgrrg swizzling (equivalent to uvec4.zyxxy).
        /// </summary>
        public uvec5 bgrrg => new uvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.zyxxz swizzling.
        /// </summary>
        public uvec5 zyxxz => new uvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.bgrrb swizzling (equivalent to uvec4.zyxxz).
        /// </summary>
        public uvec5 bgrrb => new uvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.zyxxw swizzling.
        /// </summary>
        public uvec5 zyxxw => new uvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.bgrra swizzling (equivalent to uvec4.zyxxw).
        /// </summary>
        public uvec5 bgrra => new uvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.zyxy swizzling.
        /// </summary>
        public uvec4 zyxy => new uvec4(z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.bgrg swizzling (equivalent to uvec4.zyxy).
        /// </summary>
        public uvec4 bgrg => new uvec4(z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.zyxyx swizzling.
        /// </summary>
        public uvec5 zyxyx => new uvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.bgrgr swizzling (equivalent to uvec4.zyxyx).
        /// </summary>
        public uvec5 bgrgr => new uvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.zyxyy swizzling.
        /// </summary>
        public uvec5 zyxyy => new uvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.bgrgg swizzling (equivalent to uvec4.zyxyy).
        /// </summary>
        public uvec5 bgrgg => new uvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.zyxyz swizzling.
        /// </summary>
        public uvec5 zyxyz => new uvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.bgrgb swizzling (equivalent to uvec4.zyxyz).
        /// </summary>
        public uvec5 bgrgb => new uvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.zyxyw swizzling.
        /// </summary>
        public uvec5 zyxyw => new uvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.bgrga swizzling (equivalent to uvec4.zyxyw).
        /// </summary>
        public uvec5 bgrga => new uvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.zyxz swizzling.
        /// </summary>
        public uvec4 zyxz => new uvec4(z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.bgrb swizzling (equivalent to uvec4.zyxz).
        /// </summary>
        public uvec4 bgrb => new uvec4(z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.zyxzx swizzling.
        /// </summary>
        public uvec5 zyxzx => new uvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.bgrbr swizzling (equivalent to uvec4.zyxzx).
        /// </summary>
        public uvec5 bgrbr => new uvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.zyxzy swizzling.
        /// </summary>
        public uvec5 zyxzy => new uvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.bgrbg swizzling (equivalent to uvec4.zyxzy).
        /// </summary>
        public uvec5 bgrbg => new uvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.zyxzz swizzling.
        /// </summary>
        public uvec5 zyxzz => new uvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.bgrbb swizzling (equivalent to uvec4.zyxzz).
        /// </summary>
        public uvec5 bgrbb => new uvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.zyxzw swizzling.
        /// </summary>
        public uvec5 zyxzw => new uvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.bgrba swizzling (equivalent to uvec4.zyxzw).
        /// </summary>
        public uvec5 bgrba => new uvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.zyxw swizzling.
        /// </summary>
        public uvec4 zyxw => new uvec4(z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.bgra swizzling (equivalent to uvec4.zyxw).
        /// </summary>
        public uvec4 bgra => new uvec4(z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.zyxwx swizzling.
        /// </summary>
        public uvec5 zyxwx => new uvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.bgrar swizzling (equivalent to uvec4.zyxwx).
        /// </summary>
        public uvec5 bgrar => new uvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.zyxwy swizzling.
        /// </summary>
        public uvec5 zyxwy => new uvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.bgrag swizzling (equivalent to uvec4.zyxwy).
        /// </summary>
        public uvec5 bgrag => new uvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.zyxwz swizzling.
        /// </summary>
        public uvec5 zyxwz => new uvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.bgrab swizzling (equivalent to uvec4.zyxwz).
        /// </summary>
        public uvec5 bgrab => new uvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.zyxww swizzling.
        /// </summary>
        public uvec5 zyxww => new uvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.bgraa swizzling (equivalent to uvec4.zyxww).
        /// </summary>
        public uvec5 bgraa => new uvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.zyy swizzling.
        /// </summary>
        public uvec3 zyy => new uvec3(z, y, y);
        
        /// <summary>
        /// Returns uvec4.bgg swizzling (equivalent to uvec4.zyy).
        /// </summary>
        public uvec3 bgg => new uvec3(z, y, y);
        
        /// <summary>
        /// Returns uvec4.zyyx swizzling.
        /// </summary>
        public uvec4 zyyx => new uvec4(z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.bggr swizzling (equivalent to uvec4.zyyx).
        /// </summary>
        public uvec4 bggr => new uvec4(z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.zyyxx swizzling.
        /// </summary>
        public uvec5 zyyxx => new uvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.bggrr swizzling (equivalent to uvec4.zyyxx).
        /// </summary>
        public uvec5 bggrr => new uvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.zyyxy swizzling.
        /// </summary>
        public uvec5 zyyxy => new uvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.bggrg swizzling (equivalent to uvec4.zyyxy).
        /// </summary>
        public uvec5 bggrg => new uvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.zyyxz swizzling.
        /// </summary>
        public uvec5 zyyxz => new uvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.bggrb swizzling (equivalent to uvec4.zyyxz).
        /// </summary>
        public uvec5 bggrb => new uvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.zyyxw swizzling.
        /// </summary>
        public uvec5 zyyxw => new uvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.bggra swizzling (equivalent to uvec4.zyyxw).
        /// </summary>
        public uvec5 bggra => new uvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.zyyy swizzling.
        /// </summary>
        public uvec4 zyyy => new uvec4(z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.bggg swizzling (equivalent to uvec4.zyyy).
        /// </summary>
        public uvec4 bggg => new uvec4(z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.zyyyx swizzling.
        /// </summary>
        public uvec5 zyyyx => new uvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.bgggr swizzling (equivalent to uvec4.zyyyx).
        /// </summary>
        public uvec5 bgggr => new uvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.zyyyy swizzling.
        /// </summary>
        public uvec5 zyyyy => new uvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.bgggg swizzling (equivalent to uvec4.zyyyy).
        /// </summary>
        public uvec5 bgggg => new uvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.zyyyz swizzling.
        /// </summary>
        public uvec5 zyyyz => new uvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.bgggb swizzling (equivalent to uvec4.zyyyz).
        /// </summary>
        public uvec5 bgggb => new uvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.zyyyw swizzling.
        /// </summary>
        public uvec5 zyyyw => new uvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.bggga swizzling (equivalent to uvec4.zyyyw).
        /// </summary>
        public uvec5 bggga => new uvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.zyyz swizzling.
        /// </summary>
        public uvec4 zyyz => new uvec4(z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.bggb swizzling (equivalent to uvec4.zyyz).
        /// </summary>
        public uvec4 bggb => new uvec4(z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.zyyzx swizzling.
        /// </summary>
        public uvec5 zyyzx => new uvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.bggbr swizzling (equivalent to uvec4.zyyzx).
        /// </summary>
        public uvec5 bggbr => new uvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.zyyzy swizzling.
        /// </summary>
        public uvec5 zyyzy => new uvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.bggbg swizzling (equivalent to uvec4.zyyzy).
        /// </summary>
        public uvec5 bggbg => new uvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.zyyzz swizzling.
        /// </summary>
        public uvec5 zyyzz => new uvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.bggbb swizzling (equivalent to uvec4.zyyzz).
        /// </summary>
        public uvec5 bggbb => new uvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.zyyzw swizzling.
        /// </summary>
        public uvec5 zyyzw => new uvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.bggba swizzling (equivalent to uvec4.zyyzw).
        /// </summary>
        public uvec5 bggba => new uvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.zyyw swizzling.
        /// </summary>
        public uvec4 zyyw => new uvec4(z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.bgga swizzling (equivalent to uvec4.zyyw).
        /// </summary>
        public uvec4 bgga => new uvec4(z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.zyywx swizzling.
        /// </summary>
        public uvec5 zyywx => new uvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.bggar swizzling (equivalent to uvec4.zyywx).
        /// </summary>
        public uvec5 bggar => new uvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.zyywy swizzling.
        /// </summary>
        public uvec5 zyywy => new uvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.bggag swizzling (equivalent to uvec4.zyywy).
        /// </summary>
        public uvec5 bggag => new uvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.zyywz swizzling.
        /// </summary>
        public uvec5 zyywz => new uvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.bggab swizzling (equivalent to uvec4.zyywz).
        /// </summary>
        public uvec5 bggab => new uvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.zyyww swizzling.
        /// </summary>
        public uvec5 zyyww => new uvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.bggaa swizzling (equivalent to uvec4.zyyww).
        /// </summary>
        public uvec5 bggaa => new uvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.zyz swizzling.
        /// </summary>
        public uvec3 zyz => new uvec3(z, y, z);
        
        /// <summary>
        /// Returns uvec4.bgb swizzling (equivalent to uvec4.zyz).
        /// </summary>
        public uvec3 bgb => new uvec3(z, y, z);
        
        /// <summary>
        /// Returns uvec4.zyzx swizzling.
        /// </summary>
        public uvec4 zyzx => new uvec4(z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.bgbr swizzling (equivalent to uvec4.zyzx).
        /// </summary>
        public uvec4 bgbr => new uvec4(z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.zyzxx swizzling.
        /// </summary>
        public uvec5 zyzxx => new uvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.bgbrr swizzling (equivalent to uvec4.zyzxx).
        /// </summary>
        public uvec5 bgbrr => new uvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.zyzxy swizzling.
        /// </summary>
        public uvec5 zyzxy => new uvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.bgbrg swizzling (equivalent to uvec4.zyzxy).
        /// </summary>
        public uvec5 bgbrg => new uvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.zyzxz swizzling.
        /// </summary>
        public uvec5 zyzxz => new uvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.bgbrb swizzling (equivalent to uvec4.zyzxz).
        /// </summary>
        public uvec5 bgbrb => new uvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.zyzxw swizzling.
        /// </summary>
        public uvec5 zyzxw => new uvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.bgbra swizzling (equivalent to uvec4.zyzxw).
        /// </summary>
        public uvec5 bgbra => new uvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.zyzy swizzling.
        /// </summary>
        public uvec4 zyzy => new uvec4(z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.bgbg swizzling (equivalent to uvec4.zyzy).
        /// </summary>
        public uvec4 bgbg => new uvec4(z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.zyzyx swizzling.
        /// </summary>
        public uvec5 zyzyx => new uvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.bgbgr swizzling (equivalent to uvec4.zyzyx).
        /// </summary>
        public uvec5 bgbgr => new uvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.zyzyy swizzling.
        /// </summary>
        public uvec5 zyzyy => new uvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.bgbgg swizzling (equivalent to uvec4.zyzyy).
        /// </summary>
        public uvec5 bgbgg => new uvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.zyzyz swizzling.
        /// </summary>
        public uvec5 zyzyz => new uvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.bgbgb swizzling (equivalent to uvec4.zyzyz).
        /// </summary>
        public uvec5 bgbgb => new uvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.zyzyw swizzling.
        /// </summary>
        public uvec5 zyzyw => new uvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.bgbga swizzling (equivalent to uvec4.zyzyw).
        /// </summary>
        public uvec5 bgbga => new uvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.zyzz swizzling.
        /// </summary>
        public uvec4 zyzz => new uvec4(z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.bgbb swizzling (equivalent to uvec4.zyzz).
        /// </summary>
        public uvec4 bgbb => new uvec4(z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.zyzzx swizzling.
        /// </summary>
        public uvec5 zyzzx => new uvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.bgbbr swizzling (equivalent to uvec4.zyzzx).
        /// </summary>
        public uvec5 bgbbr => new uvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.zyzzy swizzling.
        /// </summary>
        public uvec5 zyzzy => new uvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.bgbbg swizzling (equivalent to uvec4.zyzzy).
        /// </summary>
        public uvec5 bgbbg => new uvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.zyzzz swizzling.
        /// </summary>
        public uvec5 zyzzz => new uvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.bgbbb swizzling (equivalent to uvec4.zyzzz).
        /// </summary>
        public uvec5 bgbbb => new uvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.zyzzw swizzling.
        /// </summary>
        public uvec5 zyzzw => new uvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.bgbba swizzling (equivalent to uvec4.zyzzw).
        /// </summary>
        public uvec5 bgbba => new uvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.zyzw swizzling.
        /// </summary>
        public uvec4 zyzw => new uvec4(z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.bgba swizzling (equivalent to uvec4.zyzw).
        /// </summary>
        public uvec4 bgba => new uvec4(z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.zyzwx swizzling.
        /// </summary>
        public uvec5 zyzwx => new uvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.bgbar swizzling (equivalent to uvec4.zyzwx).
        /// </summary>
        public uvec5 bgbar => new uvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.zyzwy swizzling.
        /// </summary>
        public uvec5 zyzwy => new uvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.bgbag swizzling (equivalent to uvec4.zyzwy).
        /// </summary>
        public uvec5 bgbag => new uvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.zyzwz swizzling.
        /// </summary>
        public uvec5 zyzwz => new uvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.bgbab swizzling (equivalent to uvec4.zyzwz).
        /// </summary>
        public uvec5 bgbab => new uvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.zyzww swizzling.
        /// </summary>
        public uvec5 zyzww => new uvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.bgbaa swizzling (equivalent to uvec4.zyzww).
        /// </summary>
        public uvec5 bgbaa => new uvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.zyw swizzling.
        /// </summary>
        public uvec3 zyw => new uvec3(z, y, w);
        
        /// <summary>
        /// Returns uvec4.bga swizzling (equivalent to uvec4.zyw).
        /// </summary>
        public uvec3 bga => new uvec3(z, y, w);
        
        /// <summary>
        /// Returns uvec4.zywx swizzling.
        /// </summary>
        public uvec4 zywx => new uvec4(z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.bgar swizzling (equivalent to uvec4.zywx).
        /// </summary>
        public uvec4 bgar => new uvec4(z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.zywxx swizzling.
        /// </summary>
        public uvec5 zywxx => new uvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.bgarr swizzling (equivalent to uvec4.zywxx).
        /// </summary>
        public uvec5 bgarr => new uvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.zywxy swizzling.
        /// </summary>
        public uvec5 zywxy => new uvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.bgarg swizzling (equivalent to uvec4.zywxy).
        /// </summary>
        public uvec5 bgarg => new uvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.zywxz swizzling.
        /// </summary>
        public uvec5 zywxz => new uvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.bgarb swizzling (equivalent to uvec4.zywxz).
        /// </summary>
        public uvec5 bgarb => new uvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.zywxw swizzling.
        /// </summary>
        public uvec5 zywxw => new uvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.bgara swizzling (equivalent to uvec4.zywxw).
        /// </summary>
        public uvec5 bgara => new uvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.zywy swizzling.
        /// </summary>
        public uvec4 zywy => new uvec4(z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.bgag swizzling (equivalent to uvec4.zywy).
        /// </summary>
        public uvec4 bgag => new uvec4(z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.zywyx swizzling.
        /// </summary>
        public uvec5 zywyx => new uvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.bgagr swizzling (equivalent to uvec4.zywyx).
        /// </summary>
        public uvec5 bgagr => new uvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.zywyy swizzling.
        /// </summary>
        public uvec5 zywyy => new uvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.bgagg swizzling (equivalent to uvec4.zywyy).
        /// </summary>
        public uvec5 bgagg => new uvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.zywyz swizzling.
        /// </summary>
        public uvec5 zywyz => new uvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.bgagb swizzling (equivalent to uvec4.zywyz).
        /// </summary>
        public uvec5 bgagb => new uvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.zywyw swizzling.
        /// </summary>
        public uvec5 zywyw => new uvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.bgaga swizzling (equivalent to uvec4.zywyw).
        /// </summary>
        public uvec5 bgaga => new uvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.zywz swizzling.
        /// </summary>
        public uvec4 zywz => new uvec4(z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.bgab swizzling (equivalent to uvec4.zywz).
        /// </summary>
        public uvec4 bgab => new uvec4(z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.zywzx swizzling.
        /// </summary>
        public uvec5 zywzx => new uvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.bgabr swizzling (equivalent to uvec4.zywzx).
        /// </summary>
        public uvec5 bgabr => new uvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.zywzy swizzling.
        /// </summary>
        public uvec5 zywzy => new uvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.bgabg swizzling (equivalent to uvec4.zywzy).
        /// </summary>
        public uvec5 bgabg => new uvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.zywzz swizzling.
        /// </summary>
        public uvec5 zywzz => new uvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.bgabb swizzling (equivalent to uvec4.zywzz).
        /// </summary>
        public uvec5 bgabb => new uvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.zywzw swizzling.
        /// </summary>
        public uvec5 zywzw => new uvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.bgaba swizzling (equivalent to uvec4.zywzw).
        /// </summary>
        public uvec5 bgaba => new uvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.zyww swizzling.
        /// </summary>
        public uvec4 zyww => new uvec4(z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.bgaa swizzling (equivalent to uvec4.zyww).
        /// </summary>
        public uvec4 bgaa => new uvec4(z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.zywwx swizzling.
        /// </summary>
        public uvec5 zywwx => new uvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.bgaar swizzling (equivalent to uvec4.zywwx).
        /// </summary>
        public uvec5 bgaar => new uvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.zywwy swizzling.
        /// </summary>
        public uvec5 zywwy => new uvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.bgaag swizzling (equivalent to uvec4.zywwy).
        /// </summary>
        public uvec5 bgaag => new uvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.zywwz swizzling.
        /// </summary>
        public uvec5 zywwz => new uvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.bgaab swizzling (equivalent to uvec4.zywwz).
        /// </summary>
        public uvec5 bgaab => new uvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.zywww swizzling.
        /// </summary>
        public uvec5 zywww => new uvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.bgaaa swizzling (equivalent to uvec4.zywww).
        /// </summary>
        public uvec5 bgaaa => new uvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.zz swizzling.
        /// </summary>
        public uvec2 zz => new uvec2(z, z);
        
        /// <summary>
        /// Returns uvec4.bb swizzling (equivalent to uvec4.zz).
        /// </summary>
        public uvec2 bb => new uvec2(z, z);
        
        /// <summary>
        /// Returns uvec4.zzx swizzling.
        /// </summary>
        public uvec3 zzx => new uvec3(z, z, x);
        
        /// <summary>
        /// Returns uvec4.bbr swizzling (equivalent to uvec4.zzx).
        /// </summary>
        public uvec3 bbr => new uvec3(z, z, x);
        
        /// <summary>
        /// Returns uvec4.zzxx swizzling.
        /// </summary>
        public uvec4 zzxx => new uvec4(z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.bbrr swizzling (equivalent to uvec4.zzxx).
        /// </summary>
        public uvec4 bbrr => new uvec4(z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.zzxxx swizzling.
        /// </summary>
        public uvec5 zzxxx => new uvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.bbrrr swizzling (equivalent to uvec4.zzxxx).
        /// </summary>
        public uvec5 bbrrr => new uvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.zzxxy swizzling.
        /// </summary>
        public uvec5 zzxxy => new uvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.bbrrg swizzling (equivalent to uvec4.zzxxy).
        /// </summary>
        public uvec5 bbrrg => new uvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.zzxxz swizzling.
        /// </summary>
        public uvec5 zzxxz => new uvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.bbrrb swizzling (equivalent to uvec4.zzxxz).
        /// </summary>
        public uvec5 bbrrb => new uvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.zzxxw swizzling.
        /// </summary>
        public uvec5 zzxxw => new uvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.bbrra swizzling (equivalent to uvec4.zzxxw).
        /// </summary>
        public uvec5 bbrra => new uvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.zzxy swizzling.
        /// </summary>
        public uvec4 zzxy => new uvec4(z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.bbrg swizzling (equivalent to uvec4.zzxy).
        /// </summary>
        public uvec4 bbrg => new uvec4(z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.zzxyx swizzling.
        /// </summary>
        public uvec5 zzxyx => new uvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.bbrgr swizzling (equivalent to uvec4.zzxyx).
        /// </summary>
        public uvec5 bbrgr => new uvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.zzxyy swizzling.
        /// </summary>
        public uvec5 zzxyy => new uvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.bbrgg swizzling (equivalent to uvec4.zzxyy).
        /// </summary>
        public uvec5 bbrgg => new uvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.zzxyz swizzling.
        /// </summary>
        public uvec5 zzxyz => new uvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.bbrgb swizzling (equivalent to uvec4.zzxyz).
        /// </summary>
        public uvec5 bbrgb => new uvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.zzxyw swizzling.
        /// </summary>
        public uvec5 zzxyw => new uvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.bbrga swizzling (equivalent to uvec4.zzxyw).
        /// </summary>
        public uvec5 bbrga => new uvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.zzxz swizzling.
        /// </summary>
        public uvec4 zzxz => new uvec4(z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.bbrb swizzling (equivalent to uvec4.zzxz).
        /// </summary>
        public uvec4 bbrb => new uvec4(z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.zzxzx swizzling.
        /// </summary>
        public uvec5 zzxzx => new uvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.bbrbr swizzling (equivalent to uvec4.zzxzx).
        /// </summary>
        public uvec5 bbrbr => new uvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.zzxzy swizzling.
        /// </summary>
        public uvec5 zzxzy => new uvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.bbrbg swizzling (equivalent to uvec4.zzxzy).
        /// </summary>
        public uvec5 bbrbg => new uvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.zzxzz swizzling.
        /// </summary>
        public uvec5 zzxzz => new uvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.bbrbb swizzling (equivalent to uvec4.zzxzz).
        /// </summary>
        public uvec5 bbrbb => new uvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.zzxzw swizzling.
        /// </summary>
        public uvec5 zzxzw => new uvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.bbrba swizzling (equivalent to uvec4.zzxzw).
        /// </summary>
        public uvec5 bbrba => new uvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.zzxw swizzling.
        /// </summary>
        public uvec4 zzxw => new uvec4(z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.bbra swizzling (equivalent to uvec4.zzxw).
        /// </summary>
        public uvec4 bbra => new uvec4(z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.zzxwx swizzling.
        /// </summary>
        public uvec5 zzxwx => new uvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.bbrar swizzling (equivalent to uvec4.zzxwx).
        /// </summary>
        public uvec5 bbrar => new uvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.zzxwy swizzling.
        /// </summary>
        public uvec5 zzxwy => new uvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.bbrag swizzling (equivalent to uvec4.zzxwy).
        /// </summary>
        public uvec5 bbrag => new uvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.zzxwz swizzling.
        /// </summary>
        public uvec5 zzxwz => new uvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.bbrab swizzling (equivalent to uvec4.zzxwz).
        /// </summary>
        public uvec5 bbrab => new uvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.zzxww swizzling.
        /// </summary>
        public uvec5 zzxww => new uvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.bbraa swizzling (equivalent to uvec4.zzxww).
        /// </summary>
        public uvec5 bbraa => new uvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.zzy swizzling.
        /// </summary>
        public uvec3 zzy => new uvec3(z, z, y);
        
        /// <summary>
        /// Returns uvec4.bbg swizzling (equivalent to uvec4.zzy).
        /// </summary>
        public uvec3 bbg => new uvec3(z, z, y);
        
        /// <summary>
        /// Returns uvec4.zzyx swizzling.
        /// </summary>
        public uvec4 zzyx => new uvec4(z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.bbgr swizzling (equivalent to uvec4.zzyx).
        /// </summary>
        public uvec4 bbgr => new uvec4(z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.zzyxx swizzling.
        /// </summary>
        public uvec5 zzyxx => new uvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.bbgrr swizzling (equivalent to uvec4.zzyxx).
        /// </summary>
        public uvec5 bbgrr => new uvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.zzyxy swizzling.
        /// </summary>
        public uvec5 zzyxy => new uvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.bbgrg swizzling (equivalent to uvec4.zzyxy).
        /// </summary>
        public uvec5 bbgrg => new uvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.zzyxz swizzling.
        /// </summary>
        public uvec5 zzyxz => new uvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.bbgrb swizzling (equivalent to uvec4.zzyxz).
        /// </summary>
        public uvec5 bbgrb => new uvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.zzyxw swizzling.
        /// </summary>
        public uvec5 zzyxw => new uvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.bbgra swizzling (equivalent to uvec4.zzyxw).
        /// </summary>
        public uvec5 bbgra => new uvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.zzyy swizzling.
        /// </summary>
        public uvec4 zzyy => new uvec4(z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.bbgg swizzling (equivalent to uvec4.zzyy).
        /// </summary>
        public uvec4 bbgg => new uvec4(z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.zzyyx swizzling.
        /// </summary>
        public uvec5 zzyyx => new uvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.bbggr swizzling (equivalent to uvec4.zzyyx).
        /// </summary>
        public uvec5 bbggr => new uvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.zzyyy swizzling.
        /// </summary>
        public uvec5 zzyyy => new uvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.bbggg swizzling (equivalent to uvec4.zzyyy).
        /// </summary>
        public uvec5 bbggg => new uvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.zzyyz swizzling.
        /// </summary>
        public uvec5 zzyyz => new uvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.bbggb swizzling (equivalent to uvec4.zzyyz).
        /// </summary>
        public uvec5 bbggb => new uvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.zzyyw swizzling.
        /// </summary>
        public uvec5 zzyyw => new uvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.bbgga swizzling (equivalent to uvec4.zzyyw).
        /// </summary>
        public uvec5 bbgga => new uvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.zzyz swizzling.
        /// </summary>
        public uvec4 zzyz => new uvec4(z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.bbgb swizzling (equivalent to uvec4.zzyz).
        /// </summary>
        public uvec4 bbgb => new uvec4(z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.zzyzx swizzling.
        /// </summary>
        public uvec5 zzyzx => new uvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.bbgbr swizzling (equivalent to uvec4.zzyzx).
        /// </summary>
        public uvec5 bbgbr => new uvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.zzyzy swizzling.
        /// </summary>
        public uvec5 zzyzy => new uvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.bbgbg swizzling (equivalent to uvec4.zzyzy).
        /// </summary>
        public uvec5 bbgbg => new uvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.zzyzz swizzling.
        /// </summary>
        public uvec5 zzyzz => new uvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.bbgbb swizzling (equivalent to uvec4.zzyzz).
        /// </summary>
        public uvec5 bbgbb => new uvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.zzyzw swizzling.
        /// </summary>
        public uvec5 zzyzw => new uvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.bbgba swizzling (equivalent to uvec4.zzyzw).
        /// </summary>
        public uvec5 bbgba => new uvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.zzyw swizzling.
        /// </summary>
        public uvec4 zzyw => new uvec4(z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.bbga swizzling (equivalent to uvec4.zzyw).
        /// </summary>
        public uvec4 bbga => new uvec4(z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.zzywx swizzling.
        /// </summary>
        public uvec5 zzywx => new uvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.bbgar swizzling (equivalent to uvec4.zzywx).
        /// </summary>
        public uvec5 bbgar => new uvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.zzywy swizzling.
        /// </summary>
        public uvec5 zzywy => new uvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.bbgag swizzling (equivalent to uvec4.zzywy).
        /// </summary>
        public uvec5 bbgag => new uvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.zzywz swizzling.
        /// </summary>
        public uvec5 zzywz => new uvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.bbgab swizzling (equivalent to uvec4.zzywz).
        /// </summary>
        public uvec5 bbgab => new uvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.zzyww swizzling.
        /// </summary>
        public uvec5 zzyww => new uvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.bbgaa swizzling (equivalent to uvec4.zzyww).
        /// </summary>
        public uvec5 bbgaa => new uvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.zzz swizzling.
        /// </summary>
        public uvec3 zzz => new uvec3(z, z, z);
        
        /// <summary>
        /// Returns uvec4.bbb swizzling (equivalent to uvec4.zzz).
        /// </summary>
        public uvec3 bbb => new uvec3(z, z, z);
        
        /// <summary>
        /// Returns uvec4.zzzx swizzling.
        /// </summary>
        public uvec4 zzzx => new uvec4(z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.bbbr swizzling (equivalent to uvec4.zzzx).
        /// </summary>
        public uvec4 bbbr => new uvec4(z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.zzzxx swizzling.
        /// </summary>
        public uvec5 zzzxx => new uvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.bbbrr swizzling (equivalent to uvec4.zzzxx).
        /// </summary>
        public uvec5 bbbrr => new uvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.zzzxy swizzling.
        /// </summary>
        public uvec5 zzzxy => new uvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.bbbrg swizzling (equivalent to uvec4.zzzxy).
        /// </summary>
        public uvec5 bbbrg => new uvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.zzzxz swizzling.
        /// </summary>
        public uvec5 zzzxz => new uvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.bbbrb swizzling (equivalent to uvec4.zzzxz).
        /// </summary>
        public uvec5 bbbrb => new uvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.zzzxw swizzling.
        /// </summary>
        public uvec5 zzzxw => new uvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.bbbra swizzling (equivalent to uvec4.zzzxw).
        /// </summary>
        public uvec5 bbbra => new uvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.zzzy swizzling.
        /// </summary>
        public uvec4 zzzy => new uvec4(z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.bbbg swizzling (equivalent to uvec4.zzzy).
        /// </summary>
        public uvec4 bbbg => new uvec4(z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.zzzyx swizzling.
        /// </summary>
        public uvec5 zzzyx => new uvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.bbbgr swizzling (equivalent to uvec4.zzzyx).
        /// </summary>
        public uvec5 bbbgr => new uvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.zzzyy swizzling.
        /// </summary>
        public uvec5 zzzyy => new uvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.bbbgg swizzling (equivalent to uvec4.zzzyy).
        /// </summary>
        public uvec5 bbbgg => new uvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.zzzyz swizzling.
        /// </summary>
        public uvec5 zzzyz => new uvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.bbbgb swizzling (equivalent to uvec4.zzzyz).
        /// </summary>
        public uvec5 bbbgb => new uvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.zzzyw swizzling.
        /// </summary>
        public uvec5 zzzyw => new uvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.bbbga swizzling (equivalent to uvec4.zzzyw).
        /// </summary>
        public uvec5 bbbga => new uvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.zzzz swizzling.
        /// </summary>
        public uvec4 zzzz => new uvec4(z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.bbbb swizzling (equivalent to uvec4.zzzz).
        /// </summary>
        public uvec4 bbbb => new uvec4(z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.zzzzx swizzling.
        /// </summary>
        public uvec5 zzzzx => new uvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.bbbbr swizzling (equivalent to uvec4.zzzzx).
        /// </summary>
        public uvec5 bbbbr => new uvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.zzzzy swizzling.
        /// </summary>
        public uvec5 zzzzy => new uvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.bbbbg swizzling (equivalent to uvec4.zzzzy).
        /// </summary>
        public uvec5 bbbbg => new uvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.zzzzz swizzling.
        /// </summary>
        public uvec5 zzzzz => new uvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.bbbbb swizzling (equivalent to uvec4.zzzzz).
        /// </summary>
        public uvec5 bbbbb => new uvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.zzzzw swizzling.
        /// </summary>
        public uvec5 zzzzw => new uvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.bbbba swizzling (equivalent to uvec4.zzzzw).
        /// </summary>
        public uvec5 bbbba => new uvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.zzzw swizzling.
        /// </summary>
        public uvec4 zzzw => new uvec4(z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.bbba swizzling (equivalent to uvec4.zzzw).
        /// </summary>
        public uvec4 bbba => new uvec4(z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.zzzwx swizzling.
        /// </summary>
        public uvec5 zzzwx => new uvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.bbbar swizzling (equivalent to uvec4.zzzwx).
        /// </summary>
        public uvec5 bbbar => new uvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.zzzwy swizzling.
        /// </summary>
        public uvec5 zzzwy => new uvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.bbbag swizzling (equivalent to uvec4.zzzwy).
        /// </summary>
        public uvec5 bbbag => new uvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.zzzwz swizzling.
        /// </summary>
        public uvec5 zzzwz => new uvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.bbbab swizzling (equivalent to uvec4.zzzwz).
        /// </summary>
        public uvec5 bbbab => new uvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.zzzww swizzling.
        /// </summary>
        public uvec5 zzzww => new uvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.bbbaa swizzling (equivalent to uvec4.zzzww).
        /// </summary>
        public uvec5 bbbaa => new uvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.zzw swizzling.
        /// </summary>
        public uvec3 zzw => new uvec3(z, z, w);
        
        /// <summary>
        /// Returns uvec4.bba swizzling (equivalent to uvec4.zzw).
        /// </summary>
        public uvec3 bba => new uvec3(z, z, w);
        
        /// <summary>
        /// Returns uvec4.zzwx swizzling.
        /// </summary>
        public uvec4 zzwx => new uvec4(z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.bbar swizzling (equivalent to uvec4.zzwx).
        /// </summary>
        public uvec4 bbar => new uvec4(z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.zzwxx swizzling.
        /// </summary>
        public uvec5 zzwxx => new uvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.bbarr swizzling (equivalent to uvec4.zzwxx).
        /// </summary>
        public uvec5 bbarr => new uvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.zzwxy swizzling.
        /// </summary>
        public uvec5 zzwxy => new uvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.bbarg swizzling (equivalent to uvec4.zzwxy).
        /// </summary>
        public uvec5 bbarg => new uvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.zzwxz swizzling.
        /// </summary>
        public uvec5 zzwxz => new uvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.bbarb swizzling (equivalent to uvec4.zzwxz).
        /// </summary>
        public uvec5 bbarb => new uvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.zzwxw swizzling.
        /// </summary>
        public uvec5 zzwxw => new uvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.bbara swizzling (equivalent to uvec4.zzwxw).
        /// </summary>
        public uvec5 bbara => new uvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.zzwy swizzling.
        /// </summary>
        public uvec4 zzwy => new uvec4(z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.bbag swizzling (equivalent to uvec4.zzwy).
        /// </summary>
        public uvec4 bbag => new uvec4(z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.zzwyx swizzling.
        /// </summary>
        public uvec5 zzwyx => new uvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.bbagr swizzling (equivalent to uvec4.zzwyx).
        /// </summary>
        public uvec5 bbagr => new uvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.zzwyy swizzling.
        /// </summary>
        public uvec5 zzwyy => new uvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.bbagg swizzling (equivalent to uvec4.zzwyy).
        /// </summary>
        public uvec5 bbagg => new uvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.zzwyz swizzling.
        /// </summary>
        public uvec5 zzwyz => new uvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.bbagb swizzling (equivalent to uvec4.zzwyz).
        /// </summary>
        public uvec5 bbagb => new uvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.zzwyw swizzling.
        /// </summary>
        public uvec5 zzwyw => new uvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.bbaga swizzling (equivalent to uvec4.zzwyw).
        /// </summary>
        public uvec5 bbaga => new uvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.zzwz swizzling.
        /// </summary>
        public uvec4 zzwz => new uvec4(z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.bbab swizzling (equivalent to uvec4.zzwz).
        /// </summary>
        public uvec4 bbab => new uvec4(z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.zzwzx swizzling.
        /// </summary>
        public uvec5 zzwzx => new uvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.bbabr swizzling (equivalent to uvec4.zzwzx).
        /// </summary>
        public uvec5 bbabr => new uvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.zzwzy swizzling.
        /// </summary>
        public uvec5 zzwzy => new uvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.bbabg swizzling (equivalent to uvec4.zzwzy).
        /// </summary>
        public uvec5 bbabg => new uvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.zzwzz swizzling.
        /// </summary>
        public uvec5 zzwzz => new uvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.bbabb swizzling (equivalent to uvec4.zzwzz).
        /// </summary>
        public uvec5 bbabb => new uvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.zzwzw swizzling.
        /// </summary>
        public uvec5 zzwzw => new uvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.bbaba swizzling (equivalent to uvec4.zzwzw).
        /// </summary>
        public uvec5 bbaba => new uvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.zzww swizzling.
        /// </summary>
        public uvec4 zzww => new uvec4(z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.bbaa swizzling (equivalent to uvec4.zzww).
        /// </summary>
        public uvec4 bbaa => new uvec4(z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.zzwwx swizzling.
        /// </summary>
        public uvec5 zzwwx => new uvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.bbaar swizzling (equivalent to uvec4.zzwwx).
        /// </summary>
        public uvec5 bbaar => new uvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.zzwwy swizzling.
        /// </summary>
        public uvec5 zzwwy => new uvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.bbaag swizzling (equivalent to uvec4.zzwwy).
        /// </summary>
        public uvec5 bbaag => new uvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.zzwwz swizzling.
        /// </summary>
        public uvec5 zzwwz => new uvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.bbaab swizzling (equivalent to uvec4.zzwwz).
        /// </summary>
        public uvec5 bbaab => new uvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.zzwww swizzling.
        /// </summary>
        public uvec5 zzwww => new uvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.bbaaa swizzling (equivalent to uvec4.zzwww).
        /// </summary>
        public uvec5 bbaaa => new uvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.zw swizzling.
        /// </summary>
        public uvec2 zw => new uvec2(z, w);
        
        /// <summary>
        /// Returns uvec4.ba swizzling (equivalent to uvec4.zw).
        /// </summary>
        public uvec2 ba => new uvec2(z, w);
        
        /// <summary>
        /// Returns uvec4.zwx swizzling.
        /// </summary>
        public uvec3 zwx => new uvec3(z, w, x);
        
        /// <summary>
        /// Returns uvec4.bar swizzling (equivalent to uvec4.zwx).
        /// </summary>
        public uvec3 bar => new uvec3(z, w, x);
        
        /// <summary>
        /// Returns uvec4.zwxx swizzling.
        /// </summary>
        public uvec4 zwxx => new uvec4(z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.barr swizzling (equivalent to uvec4.zwxx).
        /// </summary>
        public uvec4 barr => new uvec4(z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.zwxxx swizzling.
        /// </summary>
        public uvec5 zwxxx => new uvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.barrr swizzling (equivalent to uvec4.zwxxx).
        /// </summary>
        public uvec5 barrr => new uvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.zwxxy swizzling.
        /// </summary>
        public uvec5 zwxxy => new uvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.barrg swizzling (equivalent to uvec4.zwxxy).
        /// </summary>
        public uvec5 barrg => new uvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.zwxxz swizzling.
        /// </summary>
        public uvec5 zwxxz => new uvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.barrb swizzling (equivalent to uvec4.zwxxz).
        /// </summary>
        public uvec5 barrb => new uvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.zwxxw swizzling.
        /// </summary>
        public uvec5 zwxxw => new uvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.barra swizzling (equivalent to uvec4.zwxxw).
        /// </summary>
        public uvec5 barra => new uvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.zwxy swizzling.
        /// </summary>
        public uvec4 zwxy => new uvec4(z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.barg swizzling (equivalent to uvec4.zwxy).
        /// </summary>
        public uvec4 barg => new uvec4(z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.zwxyx swizzling.
        /// </summary>
        public uvec5 zwxyx => new uvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.bargr swizzling (equivalent to uvec4.zwxyx).
        /// </summary>
        public uvec5 bargr => new uvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.zwxyy swizzling.
        /// </summary>
        public uvec5 zwxyy => new uvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.bargg swizzling (equivalent to uvec4.zwxyy).
        /// </summary>
        public uvec5 bargg => new uvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.zwxyz swizzling.
        /// </summary>
        public uvec5 zwxyz => new uvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.bargb swizzling (equivalent to uvec4.zwxyz).
        /// </summary>
        public uvec5 bargb => new uvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.zwxyw swizzling.
        /// </summary>
        public uvec5 zwxyw => new uvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.barga swizzling (equivalent to uvec4.zwxyw).
        /// </summary>
        public uvec5 barga => new uvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.zwxz swizzling.
        /// </summary>
        public uvec4 zwxz => new uvec4(z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.barb swizzling (equivalent to uvec4.zwxz).
        /// </summary>
        public uvec4 barb => new uvec4(z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.zwxzx swizzling.
        /// </summary>
        public uvec5 zwxzx => new uvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.barbr swizzling (equivalent to uvec4.zwxzx).
        /// </summary>
        public uvec5 barbr => new uvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.zwxzy swizzling.
        /// </summary>
        public uvec5 zwxzy => new uvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.barbg swizzling (equivalent to uvec4.zwxzy).
        /// </summary>
        public uvec5 barbg => new uvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.zwxzz swizzling.
        /// </summary>
        public uvec5 zwxzz => new uvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.barbb swizzling (equivalent to uvec4.zwxzz).
        /// </summary>
        public uvec5 barbb => new uvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.zwxzw swizzling.
        /// </summary>
        public uvec5 zwxzw => new uvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.barba swizzling (equivalent to uvec4.zwxzw).
        /// </summary>
        public uvec5 barba => new uvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.zwxw swizzling.
        /// </summary>
        public uvec4 zwxw => new uvec4(z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.bara swizzling (equivalent to uvec4.zwxw).
        /// </summary>
        public uvec4 bara => new uvec4(z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.zwxwx swizzling.
        /// </summary>
        public uvec5 zwxwx => new uvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.barar swizzling (equivalent to uvec4.zwxwx).
        /// </summary>
        public uvec5 barar => new uvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.zwxwy swizzling.
        /// </summary>
        public uvec5 zwxwy => new uvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.barag swizzling (equivalent to uvec4.zwxwy).
        /// </summary>
        public uvec5 barag => new uvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.zwxwz swizzling.
        /// </summary>
        public uvec5 zwxwz => new uvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.barab swizzling (equivalent to uvec4.zwxwz).
        /// </summary>
        public uvec5 barab => new uvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.zwxww swizzling.
        /// </summary>
        public uvec5 zwxww => new uvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.baraa swizzling (equivalent to uvec4.zwxww).
        /// </summary>
        public uvec5 baraa => new uvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.zwy swizzling.
        /// </summary>
        public uvec3 zwy => new uvec3(z, w, y);
        
        /// <summary>
        /// Returns uvec4.bag swizzling (equivalent to uvec4.zwy).
        /// </summary>
        public uvec3 bag => new uvec3(z, w, y);
        
        /// <summary>
        /// Returns uvec4.zwyx swizzling.
        /// </summary>
        public uvec4 zwyx => new uvec4(z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.bagr swizzling (equivalent to uvec4.zwyx).
        /// </summary>
        public uvec4 bagr => new uvec4(z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.zwyxx swizzling.
        /// </summary>
        public uvec5 zwyxx => new uvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.bagrr swizzling (equivalent to uvec4.zwyxx).
        /// </summary>
        public uvec5 bagrr => new uvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.zwyxy swizzling.
        /// </summary>
        public uvec5 zwyxy => new uvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.bagrg swizzling (equivalent to uvec4.zwyxy).
        /// </summary>
        public uvec5 bagrg => new uvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.zwyxz swizzling.
        /// </summary>
        public uvec5 zwyxz => new uvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.bagrb swizzling (equivalent to uvec4.zwyxz).
        /// </summary>
        public uvec5 bagrb => new uvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.zwyxw swizzling.
        /// </summary>
        public uvec5 zwyxw => new uvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.bagra swizzling (equivalent to uvec4.zwyxw).
        /// </summary>
        public uvec5 bagra => new uvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.zwyy swizzling.
        /// </summary>
        public uvec4 zwyy => new uvec4(z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.bagg swizzling (equivalent to uvec4.zwyy).
        /// </summary>
        public uvec4 bagg => new uvec4(z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.zwyyx swizzling.
        /// </summary>
        public uvec5 zwyyx => new uvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.baggr swizzling (equivalent to uvec4.zwyyx).
        /// </summary>
        public uvec5 baggr => new uvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.zwyyy swizzling.
        /// </summary>
        public uvec5 zwyyy => new uvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.baggg swizzling (equivalent to uvec4.zwyyy).
        /// </summary>
        public uvec5 baggg => new uvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.zwyyz swizzling.
        /// </summary>
        public uvec5 zwyyz => new uvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.baggb swizzling (equivalent to uvec4.zwyyz).
        /// </summary>
        public uvec5 baggb => new uvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.zwyyw swizzling.
        /// </summary>
        public uvec5 zwyyw => new uvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.bagga swizzling (equivalent to uvec4.zwyyw).
        /// </summary>
        public uvec5 bagga => new uvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.zwyz swizzling.
        /// </summary>
        public uvec4 zwyz => new uvec4(z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.bagb swizzling (equivalent to uvec4.zwyz).
        /// </summary>
        public uvec4 bagb => new uvec4(z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.zwyzx swizzling.
        /// </summary>
        public uvec5 zwyzx => new uvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.bagbr swizzling (equivalent to uvec4.zwyzx).
        /// </summary>
        public uvec5 bagbr => new uvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.zwyzy swizzling.
        /// </summary>
        public uvec5 zwyzy => new uvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.bagbg swizzling (equivalent to uvec4.zwyzy).
        /// </summary>
        public uvec5 bagbg => new uvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.zwyzz swizzling.
        /// </summary>
        public uvec5 zwyzz => new uvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.bagbb swizzling (equivalent to uvec4.zwyzz).
        /// </summary>
        public uvec5 bagbb => new uvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.zwyzw swizzling.
        /// </summary>
        public uvec5 zwyzw => new uvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.bagba swizzling (equivalent to uvec4.zwyzw).
        /// </summary>
        public uvec5 bagba => new uvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.zwyw swizzling.
        /// </summary>
        public uvec4 zwyw => new uvec4(z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.baga swizzling (equivalent to uvec4.zwyw).
        /// </summary>
        public uvec4 baga => new uvec4(z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.zwywx swizzling.
        /// </summary>
        public uvec5 zwywx => new uvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.bagar swizzling (equivalent to uvec4.zwywx).
        /// </summary>
        public uvec5 bagar => new uvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.zwywy swizzling.
        /// </summary>
        public uvec5 zwywy => new uvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.bagag swizzling (equivalent to uvec4.zwywy).
        /// </summary>
        public uvec5 bagag => new uvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.zwywz swizzling.
        /// </summary>
        public uvec5 zwywz => new uvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.bagab swizzling (equivalent to uvec4.zwywz).
        /// </summary>
        public uvec5 bagab => new uvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.zwyww swizzling.
        /// </summary>
        public uvec5 zwyww => new uvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.bagaa swizzling (equivalent to uvec4.zwyww).
        /// </summary>
        public uvec5 bagaa => new uvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.zwz swizzling.
        /// </summary>
        public uvec3 zwz => new uvec3(z, w, z);
        
        /// <summary>
        /// Returns uvec4.bab swizzling (equivalent to uvec4.zwz).
        /// </summary>
        public uvec3 bab => new uvec3(z, w, z);
        
        /// <summary>
        /// Returns uvec4.zwzx swizzling.
        /// </summary>
        public uvec4 zwzx => new uvec4(z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.babr swizzling (equivalent to uvec4.zwzx).
        /// </summary>
        public uvec4 babr => new uvec4(z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.zwzxx swizzling.
        /// </summary>
        public uvec5 zwzxx => new uvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.babrr swizzling (equivalent to uvec4.zwzxx).
        /// </summary>
        public uvec5 babrr => new uvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.zwzxy swizzling.
        /// </summary>
        public uvec5 zwzxy => new uvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.babrg swizzling (equivalent to uvec4.zwzxy).
        /// </summary>
        public uvec5 babrg => new uvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.zwzxz swizzling.
        /// </summary>
        public uvec5 zwzxz => new uvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.babrb swizzling (equivalent to uvec4.zwzxz).
        /// </summary>
        public uvec5 babrb => new uvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.zwzxw swizzling.
        /// </summary>
        public uvec5 zwzxw => new uvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.babra swizzling (equivalent to uvec4.zwzxw).
        /// </summary>
        public uvec5 babra => new uvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.zwzy swizzling.
        /// </summary>
        public uvec4 zwzy => new uvec4(z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.babg swizzling (equivalent to uvec4.zwzy).
        /// </summary>
        public uvec4 babg => new uvec4(z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.zwzyx swizzling.
        /// </summary>
        public uvec5 zwzyx => new uvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.babgr swizzling (equivalent to uvec4.zwzyx).
        /// </summary>
        public uvec5 babgr => new uvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.zwzyy swizzling.
        /// </summary>
        public uvec5 zwzyy => new uvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.babgg swizzling (equivalent to uvec4.zwzyy).
        /// </summary>
        public uvec5 babgg => new uvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.zwzyz swizzling.
        /// </summary>
        public uvec5 zwzyz => new uvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.babgb swizzling (equivalent to uvec4.zwzyz).
        /// </summary>
        public uvec5 babgb => new uvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.zwzyw swizzling.
        /// </summary>
        public uvec5 zwzyw => new uvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.babga swizzling (equivalent to uvec4.zwzyw).
        /// </summary>
        public uvec5 babga => new uvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.zwzz swizzling.
        /// </summary>
        public uvec4 zwzz => new uvec4(z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.babb swizzling (equivalent to uvec4.zwzz).
        /// </summary>
        public uvec4 babb => new uvec4(z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.zwzzx swizzling.
        /// </summary>
        public uvec5 zwzzx => new uvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.babbr swizzling (equivalent to uvec4.zwzzx).
        /// </summary>
        public uvec5 babbr => new uvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.zwzzy swizzling.
        /// </summary>
        public uvec5 zwzzy => new uvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.babbg swizzling (equivalent to uvec4.zwzzy).
        /// </summary>
        public uvec5 babbg => new uvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.zwzzz swizzling.
        /// </summary>
        public uvec5 zwzzz => new uvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.babbb swizzling (equivalent to uvec4.zwzzz).
        /// </summary>
        public uvec5 babbb => new uvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.zwzzw swizzling.
        /// </summary>
        public uvec5 zwzzw => new uvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.babba swizzling (equivalent to uvec4.zwzzw).
        /// </summary>
        public uvec5 babba => new uvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.zwzw swizzling.
        /// </summary>
        public uvec4 zwzw => new uvec4(z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.baba swizzling (equivalent to uvec4.zwzw).
        /// </summary>
        public uvec4 baba => new uvec4(z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.zwzwx swizzling.
        /// </summary>
        public uvec5 zwzwx => new uvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.babar swizzling (equivalent to uvec4.zwzwx).
        /// </summary>
        public uvec5 babar => new uvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.zwzwy swizzling.
        /// </summary>
        public uvec5 zwzwy => new uvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.babag swizzling (equivalent to uvec4.zwzwy).
        /// </summary>
        public uvec5 babag => new uvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.zwzwz swizzling.
        /// </summary>
        public uvec5 zwzwz => new uvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.babab swizzling (equivalent to uvec4.zwzwz).
        /// </summary>
        public uvec5 babab => new uvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.zwzww swizzling.
        /// </summary>
        public uvec5 zwzww => new uvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.babaa swizzling (equivalent to uvec4.zwzww).
        /// </summary>
        public uvec5 babaa => new uvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.zww swizzling.
        /// </summary>
        public uvec3 zww => new uvec3(z, w, w);
        
        /// <summary>
        /// Returns uvec4.baa swizzling (equivalent to uvec4.zww).
        /// </summary>
        public uvec3 baa => new uvec3(z, w, w);
        
        /// <summary>
        /// Returns uvec4.zwwx swizzling.
        /// </summary>
        public uvec4 zwwx => new uvec4(z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.baar swizzling (equivalent to uvec4.zwwx).
        /// </summary>
        public uvec4 baar => new uvec4(z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.zwwxx swizzling.
        /// </summary>
        public uvec5 zwwxx => new uvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.baarr swizzling (equivalent to uvec4.zwwxx).
        /// </summary>
        public uvec5 baarr => new uvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.zwwxy swizzling.
        /// </summary>
        public uvec5 zwwxy => new uvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.baarg swizzling (equivalent to uvec4.zwwxy).
        /// </summary>
        public uvec5 baarg => new uvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.zwwxz swizzling.
        /// </summary>
        public uvec5 zwwxz => new uvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.baarb swizzling (equivalent to uvec4.zwwxz).
        /// </summary>
        public uvec5 baarb => new uvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.zwwxw swizzling.
        /// </summary>
        public uvec5 zwwxw => new uvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.baara swizzling (equivalent to uvec4.zwwxw).
        /// </summary>
        public uvec5 baara => new uvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.zwwy swizzling.
        /// </summary>
        public uvec4 zwwy => new uvec4(z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.baag swizzling (equivalent to uvec4.zwwy).
        /// </summary>
        public uvec4 baag => new uvec4(z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.zwwyx swizzling.
        /// </summary>
        public uvec5 zwwyx => new uvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.baagr swizzling (equivalent to uvec4.zwwyx).
        /// </summary>
        public uvec5 baagr => new uvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.zwwyy swizzling.
        /// </summary>
        public uvec5 zwwyy => new uvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.baagg swizzling (equivalent to uvec4.zwwyy).
        /// </summary>
        public uvec5 baagg => new uvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.zwwyz swizzling.
        /// </summary>
        public uvec5 zwwyz => new uvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.baagb swizzling (equivalent to uvec4.zwwyz).
        /// </summary>
        public uvec5 baagb => new uvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.zwwyw swizzling.
        /// </summary>
        public uvec5 zwwyw => new uvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.baaga swizzling (equivalent to uvec4.zwwyw).
        /// </summary>
        public uvec5 baaga => new uvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.zwwz swizzling.
        /// </summary>
        public uvec4 zwwz => new uvec4(z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.baab swizzling (equivalent to uvec4.zwwz).
        /// </summary>
        public uvec4 baab => new uvec4(z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.zwwzx swizzling.
        /// </summary>
        public uvec5 zwwzx => new uvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.baabr swizzling (equivalent to uvec4.zwwzx).
        /// </summary>
        public uvec5 baabr => new uvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.zwwzy swizzling.
        /// </summary>
        public uvec5 zwwzy => new uvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.baabg swizzling (equivalent to uvec4.zwwzy).
        /// </summary>
        public uvec5 baabg => new uvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.zwwzz swizzling.
        /// </summary>
        public uvec5 zwwzz => new uvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.baabb swizzling (equivalent to uvec4.zwwzz).
        /// </summary>
        public uvec5 baabb => new uvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.zwwzw swizzling.
        /// </summary>
        public uvec5 zwwzw => new uvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.baaba swizzling (equivalent to uvec4.zwwzw).
        /// </summary>
        public uvec5 baaba => new uvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.zwww swizzling.
        /// </summary>
        public uvec4 zwww => new uvec4(z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.baaa swizzling (equivalent to uvec4.zwww).
        /// </summary>
        public uvec4 baaa => new uvec4(z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.zwwwx swizzling.
        /// </summary>
        public uvec5 zwwwx => new uvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.baaar swizzling (equivalent to uvec4.zwwwx).
        /// </summary>
        public uvec5 baaar => new uvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.zwwwy swizzling.
        /// </summary>
        public uvec5 zwwwy => new uvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.baaag swizzling (equivalent to uvec4.zwwwy).
        /// </summary>
        public uvec5 baaag => new uvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.zwwwz swizzling.
        /// </summary>
        public uvec5 zwwwz => new uvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.baaab swizzling (equivalent to uvec4.zwwwz).
        /// </summary>
        public uvec5 baaab => new uvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.zwwww swizzling.
        /// </summary>
        public uvec5 zwwww => new uvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns uvec4.baaaa swizzling (equivalent to uvec4.zwwww).
        /// </summary>
        public uvec5 baaaa => new uvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns uvec4.wx swizzling.
        /// </summary>
        public uvec2 wx => new uvec2(w, x);
        
        /// <summary>
        /// Returns uvec4.ar swizzling (equivalent to uvec4.wx).
        /// </summary>
        public uvec2 ar => new uvec2(w, x);
        
        /// <summary>
        /// Returns uvec4.wxx swizzling.
        /// </summary>
        public uvec3 wxx => new uvec3(w, x, x);
        
        /// <summary>
        /// Returns uvec4.arr swizzling (equivalent to uvec4.wxx).
        /// </summary>
        public uvec3 arr => new uvec3(w, x, x);
        
        /// <summary>
        /// Returns uvec4.wxxx swizzling.
        /// </summary>
        public uvec4 wxxx => new uvec4(w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.arrr swizzling (equivalent to uvec4.wxxx).
        /// </summary>
        public uvec4 arrr => new uvec4(w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.wxxxx swizzling.
        /// </summary>
        public uvec5 wxxxx => new uvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.arrrr swizzling (equivalent to uvec4.wxxxx).
        /// </summary>
        public uvec5 arrrr => new uvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.wxxxy swizzling.
        /// </summary>
        public uvec5 wxxxy => new uvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.arrrg swizzling (equivalent to uvec4.wxxxy).
        /// </summary>
        public uvec5 arrrg => new uvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.wxxxz swizzling.
        /// </summary>
        public uvec5 wxxxz => new uvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.arrrb swizzling (equivalent to uvec4.wxxxz).
        /// </summary>
        public uvec5 arrrb => new uvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.wxxxw swizzling.
        /// </summary>
        public uvec5 wxxxw => new uvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.arrra swizzling (equivalent to uvec4.wxxxw).
        /// </summary>
        public uvec5 arrra => new uvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.wxxy swizzling.
        /// </summary>
        public uvec4 wxxy => new uvec4(w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.arrg swizzling (equivalent to uvec4.wxxy).
        /// </summary>
        public uvec4 arrg => new uvec4(w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.wxxyx swizzling.
        /// </summary>
        public uvec5 wxxyx => new uvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.arrgr swizzling (equivalent to uvec4.wxxyx).
        /// </summary>
        public uvec5 arrgr => new uvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.wxxyy swizzling.
        /// </summary>
        public uvec5 wxxyy => new uvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.arrgg swizzling (equivalent to uvec4.wxxyy).
        /// </summary>
        public uvec5 arrgg => new uvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.wxxyz swizzling.
        /// </summary>
        public uvec5 wxxyz => new uvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.arrgb swizzling (equivalent to uvec4.wxxyz).
        /// </summary>
        public uvec5 arrgb => new uvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.wxxyw swizzling.
        /// </summary>
        public uvec5 wxxyw => new uvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.arrga swizzling (equivalent to uvec4.wxxyw).
        /// </summary>
        public uvec5 arrga => new uvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.wxxz swizzling.
        /// </summary>
        public uvec4 wxxz => new uvec4(w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.arrb swizzling (equivalent to uvec4.wxxz).
        /// </summary>
        public uvec4 arrb => new uvec4(w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.wxxzx swizzling.
        /// </summary>
        public uvec5 wxxzx => new uvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.arrbr swizzling (equivalent to uvec4.wxxzx).
        /// </summary>
        public uvec5 arrbr => new uvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.wxxzy swizzling.
        /// </summary>
        public uvec5 wxxzy => new uvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.arrbg swizzling (equivalent to uvec4.wxxzy).
        /// </summary>
        public uvec5 arrbg => new uvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.wxxzz swizzling.
        /// </summary>
        public uvec5 wxxzz => new uvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.arrbb swizzling (equivalent to uvec4.wxxzz).
        /// </summary>
        public uvec5 arrbb => new uvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.wxxzw swizzling.
        /// </summary>
        public uvec5 wxxzw => new uvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.arrba swizzling (equivalent to uvec4.wxxzw).
        /// </summary>
        public uvec5 arrba => new uvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.wxxw swizzling.
        /// </summary>
        public uvec4 wxxw => new uvec4(w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.arra swizzling (equivalent to uvec4.wxxw).
        /// </summary>
        public uvec4 arra => new uvec4(w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.wxxwx swizzling.
        /// </summary>
        public uvec5 wxxwx => new uvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.arrar swizzling (equivalent to uvec4.wxxwx).
        /// </summary>
        public uvec5 arrar => new uvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.wxxwy swizzling.
        /// </summary>
        public uvec5 wxxwy => new uvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.arrag swizzling (equivalent to uvec4.wxxwy).
        /// </summary>
        public uvec5 arrag => new uvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.wxxwz swizzling.
        /// </summary>
        public uvec5 wxxwz => new uvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.arrab swizzling (equivalent to uvec4.wxxwz).
        /// </summary>
        public uvec5 arrab => new uvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.wxxww swizzling.
        /// </summary>
        public uvec5 wxxww => new uvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.arraa swizzling (equivalent to uvec4.wxxww).
        /// </summary>
        public uvec5 arraa => new uvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.wxy swizzling.
        /// </summary>
        public uvec3 wxy => new uvec3(w, x, y);
        
        /// <summary>
        /// Returns uvec4.arg swizzling (equivalent to uvec4.wxy).
        /// </summary>
        public uvec3 arg => new uvec3(w, x, y);
        
        /// <summary>
        /// Returns uvec4.wxyx swizzling.
        /// </summary>
        public uvec4 wxyx => new uvec4(w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.argr swizzling (equivalent to uvec4.wxyx).
        /// </summary>
        public uvec4 argr => new uvec4(w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.wxyxx swizzling.
        /// </summary>
        public uvec5 wxyxx => new uvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.argrr swizzling (equivalent to uvec4.wxyxx).
        /// </summary>
        public uvec5 argrr => new uvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.wxyxy swizzling.
        /// </summary>
        public uvec5 wxyxy => new uvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.argrg swizzling (equivalent to uvec4.wxyxy).
        /// </summary>
        public uvec5 argrg => new uvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.wxyxz swizzling.
        /// </summary>
        public uvec5 wxyxz => new uvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.argrb swizzling (equivalent to uvec4.wxyxz).
        /// </summary>
        public uvec5 argrb => new uvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.wxyxw swizzling.
        /// </summary>
        public uvec5 wxyxw => new uvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.argra swizzling (equivalent to uvec4.wxyxw).
        /// </summary>
        public uvec5 argra => new uvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.wxyy swizzling.
        /// </summary>
        public uvec4 wxyy => new uvec4(w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.argg swizzling (equivalent to uvec4.wxyy).
        /// </summary>
        public uvec4 argg => new uvec4(w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.wxyyx swizzling.
        /// </summary>
        public uvec5 wxyyx => new uvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.arggr swizzling (equivalent to uvec4.wxyyx).
        /// </summary>
        public uvec5 arggr => new uvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.wxyyy swizzling.
        /// </summary>
        public uvec5 wxyyy => new uvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.arggg swizzling (equivalent to uvec4.wxyyy).
        /// </summary>
        public uvec5 arggg => new uvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.wxyyz swizzling.
        /// </summary>
        public uvec5 wxyyz => new uvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.arggb swizzling (equivalent to uvec4.wxyyz).
        /// </summary>
        public uvec5 arggb => new uvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.wxyyw swizzling.
        /// </summary>
        public uvec5 wxyyw => new uvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.argga swizzling (equivalent to uvec4.wxyyw).
        /// </summary>
        public uvec5 argga => new uvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.wxyz swizzling.
        /// </summary>
        public uvec4 wxyz => new uvec4(w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.argb swizzling (equivalent to uvec4.wxyz).
        /// </summary>
        public uvec4 argb => new uvec4(w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.wxyzx swizzling.
        /// </summary>
        public uvec5 wxyzx => new uvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.argbr swizzling (equivalent to uvec4.wxyzx).
        /// </summary>
        public uvec5 argbr => new uvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.wxyzy swizzling.
        /// </summary>
        public uvec5 wxyzy => new uvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.argbg swizzling (equivalent to uvec4.wxyzy).
        /// </summary>
        public uvec5 argbg => new uvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.wxyzz swizzling.
        /// </summary>
        public uvec5 wxyzz => new uvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.argbb swizzling (equivalent to uvec4.wxyzz).
        /// </summary>
        public uvec5 argbb => new uvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.wxyzw swizzling.
        /// </summary>
        public uvec5 wxyzw => new uvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.argba swizzling (equivalent to uvec4.wxyzw).
        /// </summary>
        public uvec5 argba => new uvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.wxyw swizzling.
        /// </summary>
        public uvec4 wxyw => new uvec4(w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.arga swizzling (equivalent to uvec4.wxyw).
        /// </summary>
        public uvec4 arga => new uvec4(w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.wxywx swizzling.
        /// </summary>
        public uvec5 wxywx => new uvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.argar swizzling (equivalent to uvec4.wxywx).
        /// </summary>
        public uvec5 argar => new uvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.wxywy swizzling.
        /// </summary>
        public uvec5 wxywy => new uvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.argag swizzling (equivalent to uvec4.wxywy).
        /// </summary>
        public uvec5 argag => new uvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.wxywz swizzling.
        /// </summary>
        public uvec5 wxywz => new uvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.argab swizzling (equivalent to uvec4.wxywz).
        /// </summary>
        public uvec5 argab => new uvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.wxyww swizzling.
        /// </summary>
        public uvec5 wxyww => new uvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.argaa swizzling (equivalent to uvec4.wxyww).
        /// </summary>
        public uvec5 argaa => new uvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.wxz swizzling.
        /// </summary>
        public uvec3 wxz => new uvec3(w, x, z);
        
        /// <summary>
        /// Returns uvec4.arb swizzling (equivalent to uvec4.wxz).
        /// </summary>
        public uvec3 arb => new uvec3(w, x, z);
        
        /// <summary>
        /// Returns uvec4.wxzx swizzling.
        /// </summary>
        public uvec4 wxzx => new uvec4(w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.arbr swizzling (equivalent to uvec4.wxzx).
        /// </summary>
        public uvec4 arbr => new uvec4(w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.wxzxx swizzling.
        /// </summary>
        public uvec5 wxzxx => new uvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.arbrr swizzling (equivalent to uvec4.wxzxx).
        /// </summary>
        public uvec5 arbrr => new uvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.wxzxy swizzling.
        /// </summary>
        public uvec5 wxzxy => new uvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.arbrg swizzling (equivalent to uvec4.wxzxy).
        /// </summary>
        public uvec5 arbrg => new uvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.wxzxz swizzling.
        /// </summary>
        public uvec5 wxzxz => new uvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.arbrb swizzling (equivalent to uvec4.wxzxz).
        /// </summary>
        public uvec5 arbrb => new uvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.wxzxw swizzling.
        /// </summary>
        public uvec5 wxzxw => new uvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.arbra swizzling (equivalent to uvec4.wxzxw).
        /// </summary>
        public uvec5 arbra => new uvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.wxzy swizzling.
        /// </summary>
        public uvec4 wxzy => new uvec4(w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.arbg swizzling (equivalent to uvec4.wxzy).
        /// </summary>
        public uvec4 arbg => new uvec4(w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.wxzyx swizzling.
        /// </summary>
        public uvec5 wxzyx => new uvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.arbgr swizzling (equivalent to uvec4.wxzyx).
        /// </summary>
        public uvec5 arbgr => new uvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.wxzyy swizzling.
        /// </summary>
        public uvec5 wxzyy => new uvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.arbgg swizzling (equivalent to uvec4.wxzyy).
        /// </summary>
        public uvec5 arbgg => new uvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.wxzyz swizzling.
        /// </summary>
        public uvec5 wxzyz => new uvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.arbgb swizzling (equivalent to uvec4.wxzyz).
        /// </summary>
        public uvec5 arbgb => new uvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.wxzyw swizzling.
        /// </summary>
        public uvec5 wxzyw => new uvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.arbga swizzling (equivalent to uvec4.wxzyw).
        /// </summary>
        public uvec5 arbga => new uvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.wxzz swizzling.
        /// </summary>
        public uvec4 wxzz => new uvec4(w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.arbb swizzling (equivalent to uvec4.wxzz).
        /// </summary>
        public uvec4 arbb => new uvec4(w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.wxzzx swizzling.
        /// </summary>
        public uvec5 wxzzx => new uvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.arbbr swizzling (equivalent to uvec4.wxzzx).
        /// </summary>
        public uvec5 arbbr => new uvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.wxzzy swizzling.
        /// </summary>
        public uvec5 wxzzy => new uvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.arbbg swizzling (equivalent to uvec4.wxzzy).
        /// </summary>
        public uvec5 arbbg => new uvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.wxzzz swizzling.
        /// </summary>
        public uvec5 wxzzz => new uvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.arbbb swizzling (equivalent to uvec4.wxzzz).
        /// </summary>
        public uvec5 arbbb => new uvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.wxzzw swizzling.
        /// </summary>
        public uvec5 wxzzw => new uvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.arbba swizzling (equivalent to uvec4.wxzzw).
        /// </summary>
        public uvec5 arbba => new uvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.wxzw swizzling.
        /// </summary>
        public uvec4 wxzw => new uvec4(w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.arba swizzling (equivalent to uvec4.wxzw).
        /// </summary>
        public uvec4 arba => new uvec4(w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.wxzwx swizzling.
        /// </summary>
        public uvec5 wxzwx => new uvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.arbar swizzling (equivalent to uvec4.wxzwx).
        /// </summary>
        public uvec5 arbar => new uvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.wxzwy swizzling.
        /// </summary>
        public uvec5 wxzwy => new uvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.arbag swizzling (equivalent to uvec4.wxzwy).
        /// </summary>
        public uvec5 arbag => new uvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.wxzwz swizzling.
        /// </summary>
        public uvec5 wxzwz => new uvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.arbab swizzling (equivalent to uvec4.wxzwz).
        /// </summary>
        public uvec5 arbab => new uvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.wxzww swizzling.
        /// </summary>
        public uvec5 wxzww => new uvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.arbaa swizzling (equivalent to uvec4.wxzww).
        /// </summary>
        public uvec5 arbaa => new uvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.wxw swizzling.
        /// </summary>
        public uvec3 wxw => new uvec3(w, x, w);
        
        /// <summary>
        /// Returns uvec4.ara swizzling (equivalent to uvec4.wxw).
        /// </summary>
        public uvec3 ara => new uvec3(w, x, w);
        
        /// <summary>
        /// Returns uvec4.wxwx swizzling.
        /// </summary>
        public uvec4 wxwx => new uvec4(w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.arar swizzling (equivalent to uvec4.wxwx).
        /// </summary>
        public uvec4 arar => new uvec4(w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.wxwxx swizzling.
        /// </summary>
        public uvec5 wxwxx => new uvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.ararr swizzling (equivalent to uvec4.wxwxx).
        /// </summary>
        public uvec5 ararr => new uvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.wxwxy swizzling.
        /// </summary>
        public uvec5 wxwxy => new uvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.ararg swizzling (equivalent to uvec4.wxwxy).
        /// </summary>
        public uvec5 ararg => new uvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.wxwxz swizzling.
        /// </summary>
        public uvec5 wxwxz => new uvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.ararb swizzling (equivalent to uvec4.wxwxz).
        /// </summary>
        public uvec5 ararb => new uvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.wxwxw swizzling.
        /// </summary>
        public uvec5 wxwxw => new uvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.arara swizzling (equivalent to uvec4.wxwxw).
        /// </summary>
        public uvec5 arara => new uvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.wxwy swizzling.
        /// </summary>
        public uvec4 wxwy => new uvec4(w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.arag swizzling (equivalent to uvec4.wxwy).
        /// </summary>
        public uvec4 arag => new uvec4(w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.wxwyx swizzling.
        /// </summary>
        public uvec5 wxwyx => new uvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.aragr swizzling (equivalent to uvec4.wxwyx).
        /// </summary>
        public uvec5 aragr => new uvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.wxwyy swizzling.
        /// </summary>
        public uvec5 wxwyy => new uvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.aragg swizzling (equivalent to uvec4.wxwyy).
        /// </summary>
        public uvec5 aragg => new uvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.wxwyz swizzling.
        /// </summary>
        public uvec5 wxwyz => new uvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.aragb swizzling (equivalent to uvec4.wxwyz).
        /// </summary>
        public uvec5 aragb => new uvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.wxwyw swizzling.
        /// </summary>
        public uvec5 wxwyw => new uvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.araga swizzling (equivalent to uvec4.wxwyw).
        /// </summary>
        public uvec5 araga => new uvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.wxwz swizzling.
        /// </summary>
        public uvec4 wxwz => new uvec4(w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.arab swizzling (equivalent to uvec4.wxwz).
        /// </summary>
        public uvec4 arab => new uvec4(w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.wxwzx swizzling.
        /// </summary>
        public uvec5 wxwzx => new uvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.arabr swizzling (equivalent to uvec4.wxwzx).
        /// </summary>
        public uvec5 arabr => new uvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.wxwzy swizzling.
        /// </summary>
        public uvec5 wxwzy => new uvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.arabg swizzling (equivalent to uvec4.wxwzy).
        /// </summary>
        public uvec5 arabg => new uvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.wxwzz swizzling.
        /// </summary>
        public uvec5 wxwzz => new uvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.arabb swizzling (equivalent to uvec4.wxwzz).
        /// </summary>
        public uvec5 arabb => new uvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.wxwzw swizzling.
        /// </summary>
        public uvec5 wxwzw => new uvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.araba swizzling (equivalent to uvec4.wxwzw).
        /// </summary>
        public uvec5 araba => new uvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.wxww swizzling.
        /// </summary>
        public uvec4 wxww => new uvec4(w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.araa swizzling (equivalent to uvec4.wxww).
        /// </summary>
        public uvec4 araa => new uvec4(w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.wxwwx swizzling.
        /// </summary>
        public uvec5 wxwwx => new uvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.araar swizzling (equivalent to uvec4.wxwwx).
        /// </summary>
        public uvec5 araar => new uvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.wxwwy swizzling.
        /// </summary>
        public uvec5 wxwwy => new uvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.araag swizzling (equivalent to uvec4.wxwwy).
        /// </summary>
        public uvec5 araag => new uvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.wxwwz swizzling.
        /// </summary>
        public uvec5 wxwwz => new uvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.araab swizzling (equivalent to uvec4.wxwwz).
        /// </summary>
        public uvec5 araab => new uvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.wxwww swizzling.
        /// </summary>
        public uvec5 wxwww => new uvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.araaa swizzling (equivalent to uvec4.wxwww).
        /// </summary>
        public uvec5 araaa => new uvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.wy swizzling.
        /// </summary>
        public uvec2 wy => new uvec2(w, y);
        
        /// <summary>
        /// Returns uvec4.ag swizzling (equivalent to uvec4.wy).
        /// </summary>
        public uvec2 ag => new uvec2(w, y);
        
        /// <summary>
        /// Returns uvec4.wyx swizzling.
        /// </summary>
        public uvec3 wyx => new uvec3(w, y, x);
        
        /// <summary>
        /// Returns uvec4.agr swizzling (equivalent to uvec4.wyx).
        /// </summary>
        public uvec3 agr => new uvec3(w, y, x);
        
        /// <summary>
        /// Returns uvec4.wyxx swizzling.
        /// </summary>
        public uvec4 wyxx => new uvec4(w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.agrr swizzling (equivalent to uvec4.wyxx).
        /// </summary>
        public uvec4 agrr => new uvec4(w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.wyxxx swizzling.
        /// </summary>
        public uvec5 wyxxx => new uvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.agrrr swizzling (equivalent to uvec4.wyxxx).
        /// </summary>
        public uvec5 agrrr => new uvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.wyxxy swizzling.
        /// </summary>
        public uvec5 wyxxy => new uvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.agrrg swizzling (equivalent to uvec4.wyxxy).
        /// </summary>
        public uvec5 agrrg => new uvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.wyxxz swizzling.
        /// </summary>
        public uvec5 wyxxz => new uvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.agrrb swizzling (equivalent to uvec4.wyxxz).
        /// </summary>
        public uvec5 agrrb => new uvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.wyxxw swizzling.
        /// </summary>
        public uvec5 wyxxw => new uvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.agrra swizzling (equivalent to uvec4.wyxxw).
        /// </summary>
        public uvec5 agrra => new uvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.wyxy swizzling.
        /// </summary>
        public uvec4 wyxy => new uvec4(w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.agrg swizzling (equivalent to uvec4.wyxy).
        /// </summary>
        public uvec4 agrg => new uvec4(w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.wyxyx swizzling.
        /// </summary>
        public uvec5 wyxyx => new uvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.agrgr swizzling (equivalent to uvec4.wyxyx).
        /// </summary>
        public uvec5 agrgr => new uvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.wyxyy swizzling.
        /// </summary>
        public uvec5 wyxyy => new uvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.agrgg swizzling (equivalent to uvec4.wyxyy).
        /// </summary>
        public uvec5 agrgg => new uvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.wyxyz swizzling.
        /// </summary>
        public uvec5 wyxyz => new uvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.agrgb swizzling (equivalent to uvec4.wyxyz).
        /// </summary>
        public uvec5 agrgb => new uvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.wyxyw swizzling.
        /// </summary>
        public uvec5 wyxyw => new uvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.agrga swizzling (equivalent to uvec4.wyxyw).
        /// </summary>
        public uvec5 agrga => new uvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.wyxz swizzling.
        /// </summary>
        public uvec4 wyxz => new uvec4(w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.agrb swizzling (equivalent to uvec4.wyxz).
        /// </summary>
        public uvec4 agrb => new uvec4(w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.wyxzx swizzling.
        /// </summary>
        public uvec5 wyxzx => new uvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.agrbr swizzling (equivalent to uvec4.wyxzx).
        /// </summary>
        public uvec5 agrbr => new uvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.wyxzy swizzling.
        /// </summary>
        public uvec5 wyxzy => new uvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.agrbg swizzling (equivalent to uvec4.wyxzy).
        /// </summary>
        public uvec5 agrbg => new uvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.wyxzz swizzling.
        /// </summary>
        public uvec5 wyxzz => new uvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.agrbb swizzling (equivalent to uvec4.wyxzz).
        /// </summary>
        public uvec5 agrbb => new uvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.wyxzw swizzling.
        /// </summary>
        public uvec5 wyxzw => new uvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.agrba swizzling (equivalent to uvec4.wyxzw).
        /// </summary>
        public uvec5 agrba => new uvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.wyxw swizzling.
        /// </summary>
        public uvec4 wyxw => new uvec4(w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.agra swizzling (equivalent to uvec4.wyxw).
        /// </summary>
        public uvec4 agra => new uvec4(w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.wyxwx swizzling.
        /// </summary>
        public uvec5 wyxwx => new uvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.agrar swizzling (equivalent to uvec4.wyxwx).
        /// </summary>
        public uvec5 agrar => new uvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.wyxwy swizzling.
        /// </summary>
        public uvec5 wyxwy => new uvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.agrag swizzling (equivalent to uvec4.wyxwy).
        /// </summary>
        public uvec5 agrag => new uvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.wyxwz swizzling.
        /// </summary>
        public uvec5 wyxwz => new uvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.agrab swizzling (equivalent to uvec4.wyxwz).
        /// </summary>
        public uvec5 agrab => new uvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.wyxww swizzling.
        /// </summary>
        public uvec5 wyxww => new uvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.agraa swizzling (equivalent to uvec4.wyxww).
        /// </summary>
        public uvec5 agraa => new uvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.wyy swizzling.
        /// </summary>
        public uvec3 wyy => new uvec3(w, y, y);
        
        /// <summary>
        /// Returns uvec4.agg swizzling (equivalent to uvec4.wyy).
        /// </summary>
        public uvec3 agg => new uvec3(w, y, y);
        
        /// <summary>
        /// Returns uvec4.wyyx swizzling.
        /// </summary>
        public uvec4 wyyx => new uvec4(w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.aggr swizzling (equivalent to uvec4.wyyx).
        /// </summary>
        public uvec4 aggr => new uvec4(w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.wyyxx swizzling.
        /// </summary>
        public uvec5 wyyxx => new uvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.aggrr swizzling (equivalent to uvec4.wyyxx).
        /// </summary>
        public uvec5 aggrr => new uvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.wyyxy swizzling.
        /// </summary>
        public uvec5 wyyxy => new uvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.aggrg swizzling (equivalent to uvec4.wyyxy).
        /// </summary>
        public uvec5 aggrg => new uvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.wyyxz swizzling.
        /// </summary>
        public uvec5 wyyxz => new uvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.aggrb swizzling (equivalent to uvec4.wyyxz).
        /// </summary>
        public uvec5 aggrb => new uvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.wyyxw swizzling.
        /// </summary>
        public uvec5 wyyxw => new uvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.aggra swizzling (equivalent to uvec4.wyyxw).
        /// </summary>
        public uvec5 aggra => new uvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.wyyy swizzling.
        /// </summary>
        public uvec4 wyyy => new uvec4(w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.aggg swizzling (equivalent to uvec4.wyyy).
        /// </summary>
        public uvec4 aggg => new uvec4(w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.wyyyx swizzling.
        /// </summary>
        public uvec5 wyyyx => new uvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.agggr swizzling (equivalent to uvec4.wyyyx).
        /// </summary>
        public uvec5 agggr => new uvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.wyyyy swizzling.
        /// </summary>
        public uvec5 wyyyy => new uvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.agggg swizzling (equivalent to uvec4.wyyyy).
        /// </summary>
        public uvec5 agggg => new uvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.wyyyz swizzling.
        /// </summary>
        public uvec5 wyyyz => new uvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.agggb swizzling (equivalent to uvec4.wyyyz).
        /// </summary>
        public uvec5 agggb => new uvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.wyyyw swizzling.
        /// </summary>
        public uvec5 wyyyw => new uvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.aggga swizzling (equivalent to uvec4.wyyyw).
        /// </summary>
        public uvec5 aggga => new uvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.wyyz swizzling.
        /// </summary>
        public uvec4 wyyz => new uvec4(w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.aggb swizzling (equivalent to uvec4.wyyz).
        /// </summary>
        public uvec4 aggb => new uvec4(w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.wyyzx swizzling.
        /// </summary>
        public uvec5 wyyzx => new uvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.aggbr swizzling (equivalent to uvec4.wyyzx).
        /// </summary>
        public uvec5 aggbr => new uvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.wyyzy swizzling.
        /// </summary>
        public uvec5 wyyzy => new uvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.aggbg swizzling (equivalent to uvec4.wyyzy).
        /// </summary>
        public uvec5 aggbg => new uvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.wyyzz swizzling.
        /// </summary>
        public uvec5 wyyzz => new uvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.aggbb swizzling (equivalent to uvec4.wyyzz).
        /// </summary>
        public uvec5 aggbb => new uvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.wyyzw swizzling.
        /// </summary>
        public uvec5 wyyzw => new uvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.aggba swizzling (equivalent to uvec4.wyyzw).
        /// </summary>
        public uvec5 aggba => new uvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.wyyw swizzling.
        /// </summary>
        public uvec4 wyyw => new uvec4(w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.agga swizzling (equivalent to uvec4.wyyw).
        /// </summary>
        public uvec4 agga => new uvec4(w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.wyywx swizzling.
        /// </summary>
        public uvec5 wyywx => new uvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.aggar swizzling (equivalent to uvec4.wyywx).
        /// </summary>
        public uvec5 aggar => new uvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.wyywy swizzling.
        /// </summary>
        public uvec5 wyywy => new uvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.aggag swizzling (equivalent to uvec4.wyywy).
        /// </summary>
        public uvec5 aggag => new uvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.wyywz swizzling.
        /// </summary>
        public uvec5 wyywz => new uvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.aggab swizzling (equivalent to uvec4.wyywz).
        /// </summary>
        public uvec5 aggab => new uvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.wyyww swizzling.
        /// </summary>
        public uvec5 wyyww => new uvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.aggaa swizzling (equivalent to uvec4.wyyww).
        /// </summary>
        public uvec5 aggaa => new uvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.wyz swizzling.
        /// </summary>
        public uvec3 wyz => new uvec3(w, y, z);
        
        /// <summary>
        /// Returns uvec4.agb swizzling (equivalent to uvec4.wyz).
        /// </summary>
        public uvec3 agb => new uvec3(w, y, z);
        
        /// <summary>
        /// Returns uvec4.wyzx swizzling.
        /// </summary>
        public uvec4 wyzx => new uvec4(w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.agbr swizzling (equivalent to uvec4.wyzx).
        /// </summary>
        public uvec4 agbr => new uvec4(w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.wyzxx swizzling.
        /// </summary>
        public uvec5 wyzxx => new uvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.agbrr swizzling (equivalent to uvec4.wyzxx).
        /// </summary>
        public uvec5 agbrr => new uvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.wyzxy swizzling.
        /// </summary>
        public uvec5 wyzxy => new uvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.agbrg swizzling (equivalent to uvec4.wyzxy).
        /// </summary>
        public uvec5 agbrg => new uvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.wyzxz swizzling.
        /// </summary>
        public uvec5 wyzxz => new uvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.agbrb swizzling (equivalent to uvec4.wyzxz).
        /// </summary>
        public uvec5 agbrb => new uvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.wyzxw swizzling.
        /// </summary>
        public uvec5 wyzxw => new uvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.agbra swizzling (equivalent to uvec4.wyzxw).
        /// </summary>
        public uvec5 agbra => new uvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.wyzy swizzling.
        /// </summary>
        public uvec4 wyzy => new uvec4(w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.agbg swizzling (equivalent to uvec4.wyzy).
        /// </summary>
        public uvec4 agbg => new uvec4(w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.wyzyx swizzling.
        /// </summary>
        public uvec5 wyzyx => new uvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.agbgr swizzling (equivalent to uvec4.wyzyx).
        /// </summary>
        public uvec5 agbgr => new uvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.wyzyy swizzling.
        /// </summary>
        public uvec5 wyzyy => new uvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.agbgg swizzling (equivalent to uvec4.wyzyy).
        /// </summary>
        public uvec5 agbgg => new uvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.wyzyz swizzling.
        /// </summary>
        public uvec5 wyzyz => new uvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.agbgb swizzling (equivalent to uvec4.wyzyz).
        /// </summary>
        public uvec5 agbgb => new uvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.wyzyw swizzling.
        /// </summary>
        public uvec5 wyzyw => new uvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.agbga swizzling (equivalent to uvec4.wyzyw).
        /// </summary>
        public uvec5 agbga => new uvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.wyzz swizzling.
        /// </summary>
        public uvec4 wyzz => new uvec4(w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.agbb swizzling (equivalent to uvec4.wyzz).
        /// </summary>
        public uvec4 agbb => new uvec4(w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.wyzzx swizzling.
        /// </summary>
        public uvec5 wyzzx => new uvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.agbbr swizzling (equivalent to uvec4.wyzzx).
        /// </summary>
        public uvec5 agbbr => new uvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.wyzzy swizzling.
        /// </summary>
        public uvec5 wyzzy => new uvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.agbbg swizzling (equivalent to uvec4.wyzzy).
        /// </summary>
        public uvec5 agbbg => new uvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.wyzzz swizzling.
        /// </summary>
        public uvec5 wyzzz => new uvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.agbbb swizzling (equivalent to uvec4.wyzzz).
        /// </summary>
        public uvec5 agbbb => new uvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.wyzzw swizzling.
        /// </summary>
        public uvec5 wyzzw => new uvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.agbba swizzling (equivalent to uvec4.wyzzw).
        /// </summary>
        public uvec5 agbba => new uvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.wyzw swizzling.
        /// </summary>
        public uvec4 wyzw => new uvec4(w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.agba swizzling (equivalent to uvec4.wyzw).
        /// </summary>
        public uvec4 agba => new uvec4(w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.wyzwx swizzling.
        /// </summary>
        public uvec5 wyzwx => new uvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.agbar swizzling (equivalent to uvec4.wyzwx).
        /// </summary>
        public uvec5 agbar => new uvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.wyzwy swizzling.
        /// </summary>
        public uvec5 wyzwy => new uvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.agbag swizzling (equivalent to uvec4.wyzwy).
        /// </summary>
        public uvec5 agbag => new uvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.wyzwz swizzling.
        /// </summary>
        public uvec5 wyzwz => new uvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.agbab swizzling (equivalent to uvec4.wyzwz).
        /// </summary>
        public uvec5 agbab => new uvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.wyzww swizzling.
        /// </summary>
        public uvec5 wyzww => new uvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.agbaa swizzling (equivalent to uvec4.wyzww).
        /// </summary>
        public uvec5 agbaa => new uvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.wyw swizzling.
        /// </summary>
        public uvec3 wyw => new uvec3(w, y, w);
        
        /// <summary>
        /// Returns uvec4.aga swizzling (equivalent to uvec4.wyw).
        /// </summary>
        public uvec3 aga => new uvec3(w, y, w);
        
        /// <summary>
        /// Returns uvec4.wywx swizzling.
        /// </summary>
        public uvec4 wywx => new uvec4(w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.agar swizzling (equivalent to uvec4.wywx).
        /// </summary>
        public uvec4 agar => new uvec4(w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.wywxx swizzling.
        /// </summary>
        public uvec5 wywxx => new uvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.agarr swizzling (equivalent to uvec4.wywxx).
        /// </summary>
        public uvec5 agarr => new uvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.wywxy swizzling.
        /// </summary>
        public uvec5 wywxy => new uvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.agarg swizzling (equivalent to uvec4.wywxy).
        /// </summary>
        public uvec5 agarg => new uvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.wywxz swizzling.
        /// </summary>
        public uvec5 wywxz => new uvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.agarb swizzling (equivalent to uvec4.wywxz).
        /// </summary>
        public uvec5 agarb => new uvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.wywxw swizzling.
        /// </summary>
        public uvec5 wywxw => new uvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.agara swizzling (equivalent to uvec4.wywxw).
        /// </summary>
        public uvec5 agara => new uvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.wywy swizzling.
        /// </summary>
        public uvec4 wywy => new uvec4(w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.agag swizzling (equivalent to uvec4.wywy).
        /// </summary>
        public uvec4 agag => new uvec4(w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.wywyx swizzling.
        /// </summary>
        public uvec5 wywyx => new uvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.agagr swizzling (equivalent to uvec4.wywyx).
        /// </summary>
        public uvec5 agagr => new uvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.wywyy swizzling.
        /// </summary>
        public uvec5 wywyy => new uvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.agagg swizzling (equivalent to uvec4.wywyy).
        /// </summary>
        public uvec5 agagg => new uvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.wywyz swizzling.
        /// </summary>
        public uvec5 wywyz => new uvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.agagb swizzling (equivalent to uvec4.wywyz).
        /// </summary>
        public uvec5 agagb => new uvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.wywyw swizzling.
        /// </summary>
        public uvec5 wywyw => new uvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.agaga swizzling (equivalent to uvec4.wywyw).
        /// </summary>
        public uvec5 agaga => new uvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.wywz swizzling.
        /// </summary>
        public uvec4 wywz => new uvec4(w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.agab swizzling (equivalent to uvec4.wywz).
        /// </summary>
        public uvec4 agab => new uvec4(w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.wywzx swizzling.
        /// </summary>
        public uvec5 wywzx => new uvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.agabr swizzling (equivalent to uvec4.wywzx).
        /// </summary>
        public uvec5 agabr => new uvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.wywzy swizzling.
        /// </summary>
        public uvec5 wywzy => new uvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.agabg swizzling (equivalent to uvec4.wywzy).
        /// </summary>
        public uvec5 agabg => new uvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.wywzz swizzling.
        /// </summary>
        public uvec5 wywzz => new uvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.agabb swizzling (equivalent to uvec4.wywzz).
        /// </summary>
        public uvec5 agabb => new uvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.wywzw swizzling.
        /// </summary>
        public uvec5 wywzw => new uvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.agaba swizzling (equivalent to uvec4.wywzw).
        /// </summary>
        public uvec5 agaba => new uvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.wyww swizzling.
        /// </summary>
        public uvec4 wyww => new uvec4(w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.agaa swizzling (equivalent to uvec4.wyww).
        /// </summary>
        public uvec4 agaa => new uvec4(w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.wywwx swizzling.
        /// </summary>
        public uvec5 wywwx => new uvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.agaar swizzling (equivalent to uvec4.wywwx).
        /// </summary>
        public uvec5 agaar => new uvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.wywwy swizzling.
        /// </summary>
        public uvec5 wywwy => new uvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.agaag swizzling (equivalent to uvec4.wywwy).
        /// </summary>
        public uvec5 agaag => new uvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.wywwz swizzling.
        /// </summary>
        public uvec5 wywwz => new uvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.agaab swizzling (equivalent to uvec4.wywwz).
        /// </summary>
        public uvec5 agaab => new uvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.wywww swizzling.
        /// </summary>
        public uvec5 wywww => new uvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.agaaa swizzling (equivalent to uvec4.wywww).
        /// </summary>
        public uvec5 agaaa => new uvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.wz swizzling.
        /// </summary>
        public uvec2 wz => new uvec2(w, z);
        
        /// <summary>
        /// Returns uvec4.ab swizzling (equivalent to uvec4.wz).
        /// </summary>
        public uvec2 ab => new uvec2(w, z);
        
        /// <summary>
        /// Returns uvec4.wzx swizzling.
        /// </summary>
        public uvec3 wzx => new uvec3(w, z, x);
        
        /// <summary>
        /// Returns uvec4.abr swizzling (equivalent to uvec4.wzx).
        /// </summary>
        public uvec3 abr => new uvec3(w, z, x);
        
        /// <summary>
        /// Returns uvec4.wzxx swizzling.
        /// </summary>
        public uvec4 wzxx => new uvec4(w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.abrr swizzling (equivalent to uvec4.wzxx).
        /// </summary>
        public uvec4 abrr => new uvec4(w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.wzxxx swizzling.
        /// </summary>
        public uvec5 wzxxx => new uvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.abrrr swizzling (equivalent to uvec4.wzxxx).
        /// </summary>
        public uvec5 abrrr => new uvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.wzxxy swizzling.
        /// </summary>
        public uvec5 wzxxy => new uvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.abrrg swizzling (equivalent to uvec4.wzxxy).
        /// </summary>
        public uvec5 abrrg => new uvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.wzxxz swizzling.
        /// </summary>
        public uvec5 wzxxz => new uvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.abrrb swizzling (equivalent to uvec4.wzxxz).
        /// </summary>
        public uvec5 abrrb => new uvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.wzxxw swizzling.
        /// </summary>
        public uvec5 wzxxw => new uvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.abrra swizzling (equivalent to uvec4.wzxxw).
        /// </summary>
        public uvec5 abrra => new uvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.wzxy swizzling.
        /// </summary>
        public uvec4 wzxy => new uvec4(w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.abrg swizzling (equivalent to uvec4.wzxy).
        /// </summary>
        public uvec4 abrg => new uvec4(w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.wzxyx swizzling.
        /// </summary>
        public uvec5 wzxyx => new uvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.abrgr swizzling (equivalent to uvec4.wzxyx).
        /// </summary>
        public uvec5 abrgr => new uvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.wzxyy swizzling.
        /// </summary>
        public uvec5 wzxyy => new uvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.abrgg swizzling (equivalent to uvec4.wzxyy).
        /// </summary>
        public uvec5 abrgg => new uvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.wzxyz swizzling.
        /// </summary>
        public uvec5 wzxyz => new uvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.abrgb swizzling (equivalent to uvec4.wzxyz).
        /// </summary>
        public uvec5 abrgb => new uvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.wzxyw swizzling.
        /// </summary>
        public uvec5 wzxyw => new uvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.abrga swizzling (equivalent to uvec4.wzxyw).
        /// </summary>
        public uvec5 abrga => new uvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.wzxz swizzling.
        /// </summary>
        public uvec4 wzxz => new uvec4(w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.abrb swizzling (equivalent to uvec4.wzxz).
        /// </summary>
        public uvec4 abrb => new uvec4(w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.wzxzx swizzling.
        /// </summary>
        public uvec5 wzxzx => new uvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.abrbr swizzling (equivalent to uvec4.wzxzx).
        /// </summary>
        public uvec5 abrbr => new uvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.wzxzy swizzling.
        /// </summary>
        public uvec5 wzxzy => new uvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.abrbg swizzling (equivalent to uvec4.wzxzy).
        /// </summary>
        public uvec5 abrbg => new uvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.wzxzz swizzling.
        /// </summary>
        public uvec5 wzxzz => new uvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.abrbb swizzling (equivalent to uvec4.wzxzz).
        /// </summary>
        public uvec5 abrbb => new uvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.wzxzw swizzling.
        /// </summary>
        public uvec5 wzxzw => new uvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.abrba swizzling (equivalent to uvec4.wzxzw).
        /// </summary>
        public uvec5 abrba => new uvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.wzxw swizzling.
        /// </summary>
        public uvec4 wzxw => new uvec4(w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.abra swizzling (equivalent to uvec4.wzxw).
        /// </summary>
        public uvec4 abra => new uvec4(w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.wzxwx swizzling.
        /// </summary>
        public uvec5 wzxwx => new uvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.abrar swizzling (equivalent to uvec4.wzxwx).
        /// </summary>
        public uvec5 abrar => new uvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.wzxwy swizzling.
        /// </summary>
        public uvec5 wzxwy => new uvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.abrag swizzling (equivalent to uvec4.wzxwy).
        /// </summary>
        public uvec5 abrag => new uvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.wzxwz swizzling.
        /// </summary>
        public uvec5 wzxwz => new uvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.abrab swizzling (equivalent to uvec4.wzxwz).
        /// </summary>
        public uvec5 abrab => new uvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.wzxww swizzling.
        /// </summary>
        public uvec5 wzxww => new uvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.abraa swizzling (equivalent to uvec4.wzxww).
        /// </summary>
        public uvec5 abraa => new uvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.wzy swizzling.
        /// </summary>
        public uvec3 wzy => new uvec3(w, z, y);
        
        /// <summary>
        /// Returns uvec4.abg swizzling (equivalent to uvec4.wzy).
        /// </summary>
        public uvec3 abg => new uvec3(w, z, y);
        
        /// <summary>
        /// Returns uvec4.wzyx swizzling.
        /// </summary>
        public uvec4 wzyx => new uvec4(w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.abgr swizzling (equivalent to uvec4.wzyx).
        /// </summary>
        public uvec4 abgr => new uvec4(w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.wzyxx swizzling.
        /// </summary>
        public uvec5 wzyxx => new uvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.abgrr swizzling (equivalent to uvec4.wzyxx).
        /// </summary>
        public uvec5 abgrr => new uvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.wzyxy swizzling.
        /// </summary>
        public uvec5 wzyxy => new uvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.abgrg swizzling (equivalent to uvec4.wzyxy).
        /// </summary>
        public uvec5 abgrg => new uvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.wzyxz swizzling.
        /// </summary>
        public uvec5 wzyxz => new uvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.abgrb swizzling (equivalent to uvec4.wzyxz).
        /// </summary>
        public uvec5 abgrb => new uvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.wzyxw swizzling.
        /// </summary>
        public uvec5 wzyxw => new uvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.abgra swizzling (equivalent to uvec4.wzyxw).
        /// </summary>
        public uvec5 abgra => new uvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.wzyy swizzling.
        /// </summary>
        public uvec4 wzyy => new uvec4(w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.abgg swizzling (equivalent to uvec4.wzyy).
        /// </summary>
        public uvec4 abgg => new uvec4(w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.wzyyx swizzling.
        /// </summary>
        public uvec5 wzyyx => new uvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.abggr swizzling (equivalent to uvec4.wzyyx).
        /// </summary>
        public uvec5 abggr => new uvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.wzyyy swizzling.
        /// </summary>
        public uvec5 wzyyy => new uvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.abggg swizzling (equivalent to uvec4.wzyyy).
        /// </summary>
        public uvec5 abggg => new uvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.wzyyz swizzling.
        /// </summary>
        public uvec5 wzyyz => new uvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.abggb swizzling (equivalent to uvec4.wzyyz).
        /// </summary>
        public uvec5 abggb => new uvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.wzyyw swizzling.
        /// </summary>
        public uvec5 wzyyw => new uvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.abgga swizzling (equivalent to uvec4.wzyyw).
        /// </summary>
        public uvec5 abgga => new uvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.wzyz swizzling.
        /// </summary>
        public uvec4 wzyz => new uvec4(w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.abgb swizzling (equivalent to uvec4.wzyz).
        /// </summary>
        public uvec4 abgb => new uvec4(w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.wzyzx swizzling.
        /// </summary>
        public uvec5 wzyzx => new uvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.abgbr swizzling (equivalent to uvec4.wzyzx).
        /// </summary>
        public uvec5 abgbr => new uvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.wzyzy swizzling.
        /// </summary>
        public uvec5 wzyzy => new uvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.abgbg swizzling (equivalent to uvec4.wzyzy).
        /// </summary>
        public uvec5 abgbg => new uvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.wzyzz swizzling.
        /// </summary>
        public uvec5 wzyzz => new uvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.abgbb swizzling (equivalent to uvec4.wzyzz).
        /// </summary>
        public uvec5 abgbb => new uvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.wzyzw swizzling.
        /// </summary>
        public uvec5 wzyzw => new uvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.abgba swizzling (equivalent to uvec4.wzyzw).
        /// </summary>
        public uvec5 abgba => new uvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.wzyw swizzling.
        /// </summary>
        public uvec4 wzyw => new uvec4(w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.abga swizzling (equivalent to uvec4.wzyw).
        /// </summary>
        public uvec4 abga => new uvec4(w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.wzywx swizzling.
        /// </summary>
        public uvec5 wzywx => new uvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.abgar swizzling (equivalent to uvec4.wzywx).
        /// </summary>
        public uvec5 abgar => new uvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.wzywy swizzling.
        /// </summary>
        public uvec5 wzywy => new uvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.abgag swizzling (equivalent to uvec4.wzywy).
        /// </summary>
        public uvec5 abgag => new uvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.wzywz swizzling.
        /// </summary>
        public uvec5 wzywz => new uvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.abgab swizzling (equivalent to uvec4.wzywz).
        /// </summary>
        public uvec5 abgab => new uvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.wzyww swizzling.
        /// </summary>
        public uvec5 wzyww => new uvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.abgaa swizzling (equivalent to uvec4.wzyww).
        /// </summary>
        public uvec5 abgaa => new uvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.wzz swizzling.
        /// </summary>
        public uvec3 wzz => new uvec3(w, z, z);
        
        /// <summary>
        /// Returns uvec4.abb swizzling (equivalent to uvec4.wzz).
        /// </summary>
        public uvec3 abb => new uvec3(w, z, z);
        
        /// <summary>
        /// Returns uvec4.wzzx swizzling.
        /// </summary>
        public uvec4 wzzx => new uvec4(w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.abbr swizzling (equivalent to uvec4.wzzx).
        /// </summary>
        public uvec4 abbr => new uvec4(w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.wzzxx swizzling.
        /// </summary>
        public uvec5 wzzxx => new uvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.abbrr swizzling (equivalent to uvec4.wzzxx).
        /// </summary>
        public uvec5 abbrr => new uvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.wzzxy swizzling.
        /// </summary>
        public uvec5 wzzxy => new uvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.abbrg swizzling (equivalent to uvec4.wzzxy).
        /// </summary>
        public uvec5 abbrg => new uvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.wzzxz swizzling.
        /// </summary>
        public uvec5 wzzxz => new uvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.abbrb swizzling (equivalent to uvec4.wzzxz).
        /// </summary>
        public uvec5 abbrb => new uvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.wzzxw swizzling.
        /// </summary>
        public uvec5 wzzxw => new uvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.abbra swizzling (equivalent to uvec4.wzzxw).
        /// </summary>
        public uvec5 abbra => new uvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.wzzy swizzling.
        /// </summary>
        public uvec4 wzzy => new uvec4(w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.abbg swizzling (equivalent to uvec4.wzzy).
        /// </summary>
        public uvec4 abbg => new uvec4(w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.wzzyx swizzling.
        /// </summary>
        public uvec5 wzzyx => new uvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.abbgr swizzling (equivalent to uvec4.wzzyx).
        /// </summary>
        public uvec5 abbgr => new uvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.wzzyy swizzling.
        /// </summary>
        public uvec5 wzzyy => new uvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.abbgg swizzling (equivalent to uvec4.wzzyy).
        /// </summary>
        public uvec5 abbgg => new uvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.wzzyz swizzling.
        /// </summary>
        public uvec5 wzzyz => new uvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.abbgb swizzling (equivalent to uvec4.wzzyz).
        /// </summary>
        public uvec5 abbgb => new uvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.wzzyw swizzling.
        /// </summary>
        public uvec5 wzzyw => new uvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.abbga swizzling (equivalent to uvec4.wzzyw).
        /// </summary>
        public uvec5 abbga => new uvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.wzzz swizzling.
        /// </summary>
        public uvec4 wzzz => new uvec4(w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.abbb swizzling (equivalent to uvec4.wzzz).
        /// </summary>
        public uvec4 abbb => new uvec4(w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.wzzzx swizzling.
        /// </summary>
        public uvec5 wzzzx => new uvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.abbbr swizzling (equivalent to uvec4.wzzzx).
        /// </summary>
        public uvec5 abbbr => new uvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.wzzzy swizzling.
        /// </summary>
        public uvec5 wzzzy => new uvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.abbbg swizzling (equivalent to uvec4.wzzzy).
        /// </summary>
        public uvec5 abbbg => new uvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.wzzzz swizzling.
        /// </summary>
        public uvec5 wzzzz => new uvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.abbbb swizzling (equivalent to uvec4.wzzzz).
        /// </summary>
        public uvec5 abbbb => new uvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.wzzzw swizzling.
        /// </summary>
        public uvec5 wzzzw => new uvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.abbba swizzling (equivalent to uvec4.wzzzw).
        /// </summary>
        public uvec5 abbba => new uvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.wzzw swizzling.
        /// </summary>
        public uvec4 wzzw => new uvec4(w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.abba swizzling (equivalent to uvec4.wzzw).
        /// </summary>
        public uvec4 abba => new uvec4(w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.wzzwx swizzling.
        /// </summary>
        public uvec5 wzzwx => new uvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.abbar swizzling (equivalent to uvec4.wzzwx).
        /// </summary>
        public uvec5 abbar => new uvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.wzzwy swizzling.
        /// </summary>
        public uvec5 wzzwy => new uvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.abbag swizzling (equivalent to uvec4.wzzwy).
        /// </summary>
        public uvec5 abbag => new uvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.wzzwz swizzling.
        /// </summary>
        public uvec5 wzzwz => new uvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.abbab swizzling (equivalent to uvec4.wzzwz).
        /// </summary>
        public uvec5 abbab => new uvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.wzzww swizzling.
        /// </summary>
        public uvec5 wzzww => new uvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.abbaa swizzling (equivalent to uvec4.wzzww).
        /// </summary>
        public uvec5 abbaa => new uvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.wzw swizzling.
        /// </summary>
        public uvec3 wzw => new uvec3(w, z, w);
        
        /// <summary>
        /// Returns uvec4.aba swizzling (equivalent to uvec4.wzw).
        /// </summary>
        public uvec3 aba => new uvec3(w, z, w);
        
        /// <summary>
        /// Returns uvec4.wzwx swizzling.
        /// </summary>
        public uvec4 wzwx => new uvec4(w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.abar swizzling (equivalent to uvec4.wzwx).
        /// </summary>
        public uvec4 abar => new uvec4(w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.wzwxx swizzling.
        /// </summary>
        public uvec5 wzwxx => new uvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.abarr swizzling (equivalent to uvec4.wzwxx).
        /// </summary>
        public uvec5 abarr => new uvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.wzwxy swizzling.
        /// </summary>
        public uvec5 wzwxy => new uvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.abarg swizzling (equivalent to uvec4.wzwxy).
        /// </summary>
        public uvec5 abarg => new uvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.wzwxz swizzling.
        /// </summary>
        public uvec5 wzwxz => new uvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.abarb swizzling (equivalent to uvec4.wzwxz).
        /// </summary>
        public uvec5 abarb => new uvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.wzwxw swizzling.
        /// </summary>
        public uvec5 wzwxw => new uvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.abara swizzling (equivalent to uvec4.wzwxw).
        /// </summary>
        public uvec5 abara => new uvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.wzwy swizzling.
        /// </summary>
        public uvec4 wzwy => new uvec4(w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.abag swizzling (equivalent to uvec4.wzwy).
        /// </summary>
        public uvec4 abag => new uvec4(w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.wzwyx swizzling.
        /// </summary>
        public uvec5 wzwyx => new uvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.abagr swizzling (equivalent to uvec4.wzwyx).
        /// </summary>
        public uvec5 abagr => new uvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.wzwyy swizzling.
        /// </summary>
        public uvec5 wzwyy => new uvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.abagg swizzling (equivalent to uvec4.wzwyy).
        /// </summary>
        public uvec5 abagg => new uvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.wzwyz swizzling.
        /// </summary>
        public uvec5 wzwyz => new uvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.abagb swizzling (equivalent to uvec4.wzwyz).
        /// </summary>
        public uvec5 abagb => new uvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.wzwyw swizzling.
        /// </summary>
        public uvec5 wzwyw => new uvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.abaga swizzling (equivalent to uvec4.wzwyw).
        /// </summary>
        public uvec5 abaga => new uvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.wzwz swizzling.
        /// </summary>
        public uvec4 wzwz => new uvec4(w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.abab swizzling (equivalent to uvec4.wzwz).
        /// </summary>
        public uvec4 abab => new uvec4(w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.wzwzx swizzling.
        /// </summary>
        public uvec5 wzwzx => new uvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.ababr swizzling (equivalent to uvec4.wzwzx).
        /// </summary>
        public uvec5 ababr => new uvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.wzwzy swizzling.
        /// </summary>
        public uvec5 wzwzy => new uvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.ababg swizzling (equivalent to uvec4.wzwzy).
        /// </summary>
        public uvec5 ababg => new uvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.wzwzz swizzling.
        /// </summary>
        public uvec5 wzwzz => new uvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.ababb swizzling (equivalent to uvec4.wzwzz).
        /// </summary>
        public uvec5 ababb => new uvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.wzwzw swizzling.
        /// </summary>
        public uvec5 wzwzw => new uvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.ababa swizzling (equivalent to uvec4.wzwzw).
        /// </summary>
        public uvec5 ababa => new uvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.wzww swizzling.
        /// </summary>
        public uvec4 wzww => new uvec4(w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.abaa swizzling (equivalent to uvec4.wzww).
        /// </summary>
        public uvec4 abaa => new uvec4(w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.wzwwx swizzling.
        /// </summary>
        public uvec5 wzwwx => new uvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.abaar swizzling (equivalent to uvec4.wzwwx).
        /// </summary>
        public uvec5 abaar => new uvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.wzwwy swizzling.
        /// </summary>
        public uvec5 wzwwy => new uvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.abaag swizzling (equivalent to uvec4.wzwwy).
        /// </summary>
        public uvec5 abaag => new uvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.wzwwz swizzling.
        /// </summary>
        public uvec5 wzwwz => new uvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.abaab swizzling (equivalent to uvec4.wzwwz).
        /// </summary>
        public uvec5 abaab => new uvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.wzwww swizzling.
        /// </summary>
        public uvec5 wzwww => new uvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.abaaa swizzling (equivalent to uvec4.wzwww).
        /// </summary>
        public uvec5 abaaa => new uvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.ww swizzling.
        /// </summary>
        public uvec2 ww => new uvec2(w, w);
        
        /// <summary>
        /// Returns uvec4.aa swizzling (equivalent to uvec4.ww).
        /// </summary>
        public uvec2 aa => new uvec2(w, w);
        
        /// <summary>
        /// Returns uvec4.wwx swizzling.
        /// </summary>
        public uvec3 wwx => new uvec3(w, w, x);
        
        /// <summary>
        /// Returns uvec4.aar swizzling (equivalent to uvec4.wwx).
        /// </summary>
        public uvec3 aar => new uvec3(w, w, x);
        
        /// <summary>
        /// Returns uvec4.wwxx swizzling.
        /// </summary>
        public uvec4 wwxx => new uvec4(w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.aarr swizzling (equivalent to uvec4.wwxx).
        /// </summary>
        public uvec4 aarr => new uvec4(w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.wwxxx swizzling.
        /// </summary>
        public uvec5 wwxxx => new uvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.aarrr swizzling (equivalent to uvec4.wwxxx).
        /// </summary>
        public uvec5 aarrr => new uvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.wwxxy swizzling.
        /// </summary>
        public uvec5 wwxxy => new uvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.aarrg swizzling (equivalent to uvec4.wwxxy).
        /// </summary>
        public uvec5 aarrg => new uvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.wwxxz swizzling.
        /// </summary>
        public uvec5 wwxxz => new uvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.aarrb swizzling (equivalent to uvec4.wwxxz).
        /// </summary>
        public uvec5 aarrb => new uvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.wwxxw swizzling.
        /// </summary>
        public uvec5 wwxxw => new uvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.aarra swizzling (equivalent to uvec4.wwxxw).
        /// </summary>
        public uvec5 aarra => new uvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.wwxy swizzling.
        /// </summary>
        public uvec4 wwxy => new uvec4(w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.aarg swizzling (equivalent to uvec4.wwxy).
        /// </summary>
        public uvec4 aarg => new uvec4(w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.wwxyx swizzling.
        /// </summary>
        public uvec5 wwxyx => new uvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.aargr swizzling (equivalent to uvec4.wwxyx).
        /// </summary>
        public uvec5 aargr => new uvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.wwxyy swizzling.
        /// </summary>
        public uvec5 wwxyy => new uvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.aargg swizzling (equivalent to uvec4.wwxyy).
        /// </summary>
        public uvec5 aargg => new uvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.wwxyz swizzling.
        /// </summary>
        public uvec5 wwxyz => new uvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.aargb swizzling (equivalent to uvec4.wwxyz).
        /// </summary>
        public uvec5 aargb => new uvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.wwxyw swizzling.
        /// </summary>
        public uvec5 wwxyw => new uvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.aarga swizzling (equivalent to uvec4.wwxyw).
        /// </summary>
        public uvec5 aarga => new uvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.wwxz swizzling.
        /// </summary>
        public uvec4 wwxz => new uvec4(w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.aarb swizzling (equivalent to uvec4.wwxz).
        /// </summary>
        public uvec4 aarb => new uvec4(w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.wwxzx swizzling.
        /// </summary>
        public uvec5 wwxzx => new uvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.aarbr swizzling (equivalent to uvec4.wwxzx).
        /// </summary>
        public uvec5 aarbr => new uvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.wwxzy swizzling.
        /// </summary>
        public uvec5 wwxzy => new uvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.aarbg swizzling (equivalent to uvec4.wwxzy).
        /// </summary>
        public uvec5 aarbg => new uvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.wwxzz swizzling.
        /// </summary>
        public uvec5 wwxzz => new uvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.aarbb swizzling (equivalent to uvec4.wwxzz).
        /// </summary>
        public uvec5 aarbb => new uvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.wwxzw swizzling.
        /// </summary>
        public uvec5 wwxzw => new uvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.aarba swizzling (equivalent to uvec4.wwxzw).
        /// </summary>
        public uvec5 aarba => new uvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.wwxw swizzling.
        /// </summary>
        public uvec4 wwxw => new uvec4(w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.aara swizzling (equivalent to uvec4.wwxw).
        /// </summary>
        public uvec4 aara => new uvec4(w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.wwxwx swizzling.
        /// </summary>
        public uvec5 wwxwx => new uvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.aarar swizzling (equivalent to uvec4.wwxwx).
        /// </summary>
        public uvec5 aarar => new uvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.wwxwy swizzling.
        /// </summary>
        public uvec5 wwxwy => new uvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.aarag swizzling (equivalent to uvec4.wwxwy).
        /// </summary>
        public uvec5 aarag => new uvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.wwxwz swizzling.
        /// </summary>
        public uvec5 wwxwz => new uvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.aarab swizzling (equivalent to uvec4.wwxwz).
        /// </summary>
        public uvec5 aarab => new uvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.wwxww swizzling.
        /// </summary>
        public uvec5 wwxww => new uvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.aaraa swizzling (equivalent to uvec4.wwxww).
        /// </summary>
        public uvec5 aaraa => new uvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.wwy swizzling.
        /// </summary>
        public uvec3 wwy => new uvec3(w, w, y);
        
        /// <summary>
        /// Returns uvec4.aag swizzling (equivalent to uvec4.wwy).
        /// </summary>
        public uvec3 aag => new uvec3(w, w, y);
        
        /// <summary>
        /// Returns uvec4.wwyx swizzling.
        /// </summary>
        public uvec4 wwyx => new uvec4(w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.aagr swizzling (equivalent to uvec4.wwyx).
        /// </summary>
        public uvec4 aagr => new uvec4(w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.wwyxx swizzling.
        /// </summary>
        public uvec5 wwyxx => new uvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.aagrr swizzling (equivalent to uvec4.wwyxx).
        /// </summary>
        public uvec5 aagrr => new uvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.wwyxy swizzling.
        /// </summary>
        public uvec5 wwyxy => new uvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.aagrg swizzling (equivalent to uvec4.wwyxy).
        /// </summary>
        public uvec5 aagrg => new uvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.wwyxz swizzling.
        /// </summary>
        public uvec5 wwyxz => new uvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.aagrb swizzling (equivalent to uvec4.wwyxz).
        /// </summary>
        public uvec5 aagrb => new uvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.wwyxw swizzling.
        /// </summary>
        public uvec5 wwyxw => new uvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.aagra swizzling (equivalent to uvec4.wwyxw).
        /// </summary>
        public uvec5 aagra => new uvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.wwyy swizzling.
        /// </summary>
        public uvec4 wwyy => new uvec4(w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.aagg swizzling (equivalent to uvec4.wwyy).
        /// </summary>
        public uvec4 aagg => new uvec4(w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.wwyyx swizzling.
        /// </summary>
        public uvec5 wwyyx => new uvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.aaggr swizzling (equivalent to uvec4.wwyyx).
        /// </summary>
        public uvec5 aaggr => new uvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.wwyyy swizzling.
        /// </summary>
        public uvec5 wwyyy => new uvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.aaggg swizzling (equivalent to uvec4.wwyyy).
        /// </summary>
        public uvec5 aaggg => new uvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.wwyyz swizzling.
        /// </summary>
        public uvec5 wwyyz => new uvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.aaggb swizzling (equivalent to uvec4.wwyyz).
        /// </summary>
        public uvec5 aaggb => new uvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.wwyyw swizzling.
        /// </summary>
        public uvec5 wwyyw => new uvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.aagga swizzling (equivalent to uvec4.wwyyw).
        /// </summary>
        public uvec5 aagga => new uvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.wwyz swizzling.
        /// </summary>
        public uvec4 wwyz => new uvec4(w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.aagb swizzling (equivalent to uvec4.wwyz).
        /// </summary>
        public uvec4 aagb => new uvec4(w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.wwyzx swizzling.
        /// </summary>
        public uvec5 wwyzx => new uvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.aagbr swizzling (equivalent to uvec4.wwyzx).
        /// </summary>
        public uvec5 aagbr => new uvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.wwyzy swizzling.
        /// </summary>
        public uvec5 wwyzy => new uvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.aagbg swizzling (equivalent to uvec4.wwyzy).
        /// </summary>
        public uvec5 aagbg => new uvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.wwyzz swizzling.
        /// </summary>
        public uvec5 wwyzz => new uvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.aagbb swizzling (equivalent to uvec4.wwyzz).
        /// </summary>
        public uvec5 aagbb => new uvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.wwyzw swizzling.
        /// </summary>
        public uvec5 wwyzw => new uvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.aagba swizzling (equivalent to uvec4.wwyzw).
        /// </summary>
        public uvec5 aagba => new uvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.wwyw swizzling.
        /// </summary>
        public uvec4 wwyw => new uvec4(w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.aaga swizzling (equivalent to uvec4.wwyw).
        /// </summary>
        public uvec4 aaga => new uvec4(w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.wwywx swizzling.
        /// </summary>
        public uvec5 wwywx => new uvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.aagar swizzling (equivalent to uvec4.wwywx).
        /// </summary>
        public uvec5 aagar => new uvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.wwywy swizzling.
        /// </summary>
        public uvec5 wwywy => new uvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.aagag swizzling (equivalent to uvec4.wwywy).
        /// </summary>
        public uvec5 aagag => new uvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.wwywz swizzling.
        /// </summary>
        public uvec5 wwywz => new uvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.aagab swizzling (equivalent to uvec4.wwywz).
        /// </summary>
        public uvec5 aagab => new uvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.wwyww swizzling.
        /// </summary>
        public uvec5 wwyww => new uvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.aagaa swizzling (equivalent to uvec4.wwyww).
        /// </summary>
        public uvec5 aagaa => new uvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.wwz swizzling.
        /// </summary>
        public uvec3 wwz => new uvec3(w, w, z);
        
        /// <summary>
        /// Returns uvec4.aab swizzling (equivalent to uvec4.wwz).
        /// </summary>
        public uvec3 aab => new uvec3(w, w, z);
        
        /// <summary>
        /// Returns uvec4.wwzx swizzling.
        /// </summary>
        public uvec4 wwzx => new uvec4(w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.aabr swizzling (equivalent to uvec4.wwzx).
        /// </summary>
        public uvec4 aabr => new uvec4(w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.wwzxx swizzling.
        /// </summary>
        public uvec5 wwzxx => new uvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.aabrr swizzling (equivalent to uvec4.wwzxx).
        /// </summary>
        public uvec5 aabrr => new uvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.wwzxy swizzling.
        /// </summary>
        public uvec5 wwzxy => new uvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.aabrg swizzling (equivalent to uvec4.wwzxy).
        /// </summary>
        public uvec5 aabrg => new uvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.wwzxz swizzling.
        /// </summary>
        public uvec5 wwzxz => new uvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.aabrb swizzling (equivalent to uvec4.wwzxz).
        /// </summary>
        public uvec5 aabrb => new uvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.wwzxw swizzling.
        /// </summary>
        public uvec5 wwzxw => new uvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.aabra swizzling (equivalent to uvec4.wwzxw).
        /// </summary>
        public uvec5 aabra => new uvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.wwzy swizzling.
        /// </summary>
        public uvec4 wwzy => new uvec4(w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.aabg swizzling (equivalent to uvec4.wwzy).
        /// </summary>
        public uvec4 aabg => new uvec4(w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.wwzyx swizzling.
        /// </summary>
        public uvec5 wwzyx => new uvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.aabgr swizzling (equivalent to uvec4.wwzyx).
        /// </summary>
        public uvec5 aabgr => new uvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.wwzyy swizzling.
        /// </summary>
        public uvec5 wwzyy => new uvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.aabgg swizzling (equivalent to uvec4.wwzyy).
        /// </summary>
        public uvec5 aabgg => new uvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.wwzyz swizzling.
        /// </summary>
        public uvec5 wwzyz => new uvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.aabgb swizzling (equivalent to uvec4.wwzyz).
        /// </summary>
        public uvec5 aabgb => new uvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.wwzyw swizzling.
        /// </summary>
        public uvec5 wwzyw => new uvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.aabga swizzling (equivalent to uvec4.wwzyw).
        /// </summary>
        public uvec5 aabga => new uvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.wwzz swizzling.
        /// </summary>
        public uvec4 wwzz => new uvec4(w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.aabb swizzling (equivalent to uvec4.wwzz).
        /// </summary>
        public uvec4 aabb => new uvec4(w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.wwzzx swizzling.
        /// </summary>
        public uvec5 wwzzx => new uvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.aabbr swizzling (equivalent to uvec4.wwzzx).
        /// </summary>
        public uvec5 aabbr => new uvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.wwzzy swizzling.
        /// </summary>
        public uvec5 wwzzy => new uvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.aabbg swizzling (equivalent to uvec4.wwzzy).
        /// </summary>
        public uvec5 aabbg => new uvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.wwzzz swizzling.
        /// </summary>
        public uvec5 wwzzz => new uvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.aabbb swizzling (equivalent to uvec4.wwzzz).
        /// </summary>
        public uvec5 aabbb => new uvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.wwzzw swizzling.
        /// </summary>
        public uvec5 wwzzw => new uvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.aabba swizzling (equivalent to uvec4.wwzzw).
        /// </summary>
        public uvec5 aabba => new uvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.wwzw swizzling.
        /// </summary>
        public uvec4 wwzw => new uvec4(w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.aaba swizzling (equivalent to uvec4.wwzw).
        /// </summary>
        public uvec4 aaba => new uvec4(w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.wwzwx swizzling.
        /// </summary>
        public uvec5 wwzwx => new uvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.aabar swizzling (equivalent to uvec4.wwzwx).
        /// </summary>
        public uvec5 aabar => new uvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.wwzwy swizzling.
        /// </summary>
        public uvec5 wwzwy => new uvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.aabag swizzling (equivalent to uvec4.wwzwy).
        /// </summary>
        public uvec5 aabag => new uvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.wwzwz swizzling.
        /// </summary>
        public uvec5 wwzwz => new uvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.aabab swizzling (equivalent to uvec4.wwzwz).
        /// </summary>
        public uvec5 aabab => new uvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.wwzww swizzling.
        /// </summary>
        public uvec5 wwzww => new uvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.aabaa swizzling (equivalent to uvec4.wwzww).
        /// </summary>
        public uvec5 aabaa => new uvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.www swizzling.
        /// </summary>
        public uvec3 www => new uvec3(w, w, w);
        
        /// <summary>
        /// Returns uvec4.aaa swizzling (equivalent to uvec4.www).
        /// </summary>
        public uvec3 aaa => new uvec3(w, w, w);
        
        /// <summary>
        /// Returns uvec4.wwwx swizzling.
        /// </summary>
        public uvec4 wwwx => new uvec4(w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.aaar swizzling (equivalent to uvec4.wwwx).
        /// </summary>
        public uvec4 aaar => new uvec4(w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.wwwxx swizzling.
        /// </summary>
        public uvec5 wwwxx => new uvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.aaarr swizzling (equivalent to uvec4.wwwxx).
        /// </summary>
        public uvec5 aaarr => new uvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.wwwxy swizzling.
        /// </summary>
        public uvec5 wwwxy => new uvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.aaarg swizzling (equivalent to uvec4.wwwxy).
        /// </summary>
        public uvec5 aaarg => new uvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.wwwxz swizzling.
        /// </summary>
        public uvec5 wwwxz => new uvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.aaarb swizzling (equivalent to uvec4.wwwxz).
        /// </summary>
        public uvec5 aaarb => new uvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.wwwxw swizzling.
        /// </summary>
        public uvec5 wwwxw => new uvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.aaara swizzling (equivalent to uvec4.wwwxw).
        /// </summary>
        public uvec5 aaara => new uvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.wwwy swizzling.
        /// </summary>
        public uvec4 wwwy => new uvec4(w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.aaag swizzling (equivalent to uvec4.wwwy).
        /// </summary>
        public uvec4 aaag => new uvec4(w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.wwwyx swizzling.
        /// </summary>
        public uvec5 wwwyx => new uvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.aaagr swizzling (equivalent to uvec4.wwwyx).
        /// </summary>
        public uvec5 aaagr => new uvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.wwwyy swizzling.
        /// </summary>
        public uvec5 wwwyy => new uvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.aaagg swizzling (equivalent to uvec4.wwwyy).
        /// </summary>
        public uvec5 aaagg => new uvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.wwwyz swizzling.
        /// </summary>
        public uvec5 wwwyz => new uvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.aaagb swizzling (equivalent to uvec4.wwwyz).
        /// </summary>
        public uvec5 aaagb => new uvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.wwwyw swizzling.
        /// </summary>
        public uvec5 wwwyw => new uvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.aaaga swizzling (equivalent to uvec4.wwwyw).
        /// </summary>
        public uvec5 aaaga => new uvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.wwwz swizzling.
        /// </summary>
        public uvec4 wwwz => new uvec4(w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.aaab swizzling (equivalent to uvec4.wwwz).
        /// </summary>
        public uvec4 aaab => new uvec4(w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.wwwzx swizzling.
        /// </summary>
        public uvec5 wwwzx => new uvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.aaabr swizzling (equivalent to uvec4.wwwzx).
        /// </summary>
        public uvec5 aaabr => new uvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.wwwzy swizzling.
        /// </summary>
        public uvec5 wwwzy => new uvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.aaabg swizzling (equivalent to uvec4.wwwzy).
        /// </summary>
        public uvec5 aaabg => new uvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.wwwzz swizzling.
        /// </summary>
        public uvec5 wwwzz => new uvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.aaabb swizzling (equivalent to uvec4.wwwzz).
        /// </summary>
        public uvec5 aaabb => new uvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.wwwzw swizzling.
        /// </summary>
        public uvec5 wwwzw => new uvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.aaaba swizzling (equivalent to uvec4.wwwzw).
        /// </summary>
        public uvec5 aaaba => new uvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.wwww swizzling.
        /// </summary>
        public uvec4 wwww => new uvec4(w, w, w, w);
        
        /// <summary>
        /// Returns uvec4.aaaa swizzling (equivalent to uvec4.wwww).
        /// </summary>
        public uvec4 aaaa => new uvec4(w, w, w, w);
        
        /// <summary>
        /// Returns uvec4.wwwwx swizzling.
        /// </summary>
        public uvec5 wwwwx => new uvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.aaaar swizzling (equivalent to uvec4.wwwwx).
        /// </summary>
        public uvec5 aaaar => new uvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.wwwwy swizzling.
        /// </summary>
        public uvec5 wwwwy => new uvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.aaaag swizzling (equivalent to uvec4.wwwwy).
        /// </summary>
        public uvec5 aaaag => new uvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.wwwwz swizzling.
        /// </summary>
        public uvec5 wwwwz => new uvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.aaaab swizzling (equivalent to uvec4.wwwwz).
        /// </summary>
        public uvec5 aaaab => new uvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.wwwww swizzling.
        /// </summary>
        public uvec5 wwwww => new uvec5(w, w, w, w, w);
        
        /// <summary>
        /// Returns uvec4.aaaaa swizzling (equivalent to uvec4.wwwww).
        /// </summary>
        public uvec5 aaaaa => new uvec5(w, w, w, w, w);

        #endregion

    }
}
