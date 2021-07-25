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
    /// Temporary vector of type long with 4 components, used for implementing swizzling for lvec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_lvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly long x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly long y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly long z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly long w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_lvec4.
        /// </summary>
        internal swizzle_lvec4(long x, long y, long z, long w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns lvec4.xx swizzling.
        /// </summary>
        public lvec2 xx => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec4.rr swizzling (equivalent to lvec4.xx).
        /// </summary>
        public lvec2 rr => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec4.xxx swizzling.
        /// </summary>
        public lvec3 xxx => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec4.rrr swizzling (equivalent to lvec4.xxx).
        /// </summary>
        public lvec3 rrr => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec4.xxxx swizzling.
        /// </summary>
        public lvec4 xxxx => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.rrrr swizzling (equivalent to lvec4.xxxx).
        /// </summary>
        public lvec4 rrrr => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.xxxxx swizzling.
        /// </summary>
        public lvec5 xxxxx => new lvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.rrrrr swizzling (equivalent to lvec4.xxxxx).
        /// </summary>
        public lvec5 rrrrr => new lvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.xxxxy swizzling.
        /// </summary>
        public lvec5 xxxxy => new lvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.rrrrg swizzling (equivalent to lvec4.xxxxy).
        /// </summary>
        public lvec5 rrrrg => new lvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.xxxxz swizzling.
        /// </summary>
        public lvec5 xxxxz => new lvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.rrrrb swizzling (equivalent to lvec4.xxxxz).
        /// </summary>
        public lvec5 rrrrb => new lvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.xxxxw swizzling.
        /// </summary>
        public lvec5 xxxxw => new lvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.rrrra swizzling (equivalent to lvec4.xxxxw).
        /// </summary>
        public lvec5 rrrra => new lvec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.xxxy swizzling.
        /// </summary>
        public lvec4 xxxy => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.rrrg swizzling (equivalent to lvec4.xxxy).
        /// </summary>
        public lvec4 rrrg => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.xxxyx swizzling.
        /// </summary>
        public lvec5 xxxyx => new lvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.rrrgr swizzling (equivalent to lvec4.xxxyx).
        /// </summary>
        public lvec5 rrrgr => new lvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.xxxyy swizzling.
        /// </summary>
        public lvec5 xxxyy => new lvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.rrrgg swizzling (equivalent to lvec4.xxxyy).
        /// </summary>
        public lvec5 rrrgg => new lvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.xxxyz swizzling.
        /// </summary>
        public lvec5 xxxyz => new lvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.rrrgb swizzling (equivalent to lvec4.xxxyz).
        /// </summary>
        public lvec5 rrrgb => new lvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.xxxyw swizzling.
        /// </summary>
        public lvec5 xxxyw => new lvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.rrrga swizzling (equivalent to lvec4.xxxyw).
        /// </summary>
        public lvec5 rrrga => new lvec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.xxxz swizzling.
        /// </summary>
        public lvec4 xxxz => new lvec4(x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.rrrb swizzling (equivalent to lvec4.xxxz).
        /// </summary>
        public lvec4 rrrb => new lvec4(x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.xxxzx swizzling.
        /// </summary>
        public lvec5 xxxzx => new lvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.rrrbr swizzling (equivalent to lvec4.xxxzx).
        /// </summary>
        public lvec5 rrrbr => new lvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.xxxzy swizzling.
        /// </summary>
        public lvec5 xxxzy => new lvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.rrrbg swizzling (equivalent to lvec4.xxxzy).
        /// </summary>
        public lvec5 rrrbg => new lvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.xxxzz swizzling.
        /// </summary>
        public lvec5 xxxzz => new lvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.rrrbb swizzling (equivalent to lvec4.xxxzz).
        /// </summary>
        public lvec5 rrrbb => new lvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.xxxzw swizzling.
        /// </summary>
        public lvec5 xxxzw => new lvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.rrrba swizzling (equivalent to lvec4.xxxzw).
        /// </summary>
        public lvec5 rrrba => new lvec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.xxxw swizzling.
        /// </summary>
        public lvec4 xxxw => new lvec4(x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.rrra swizzling (equivalent to lvec4.xxxw).
        /// </summary>
        public lvec4 rrra => new lvec4(x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.xxxwx swizzling.
        /// </summary>
        public lvec5 xxxwx => new lvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.rrrar swizzling (equivalent to lvec4.xxxwx).
        /// </summary>
        public lvec5 rrrar => new lvec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.xxxwy swizzling.
        /// </summary>
        public lvec5 xxxwy => new lvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.rrrag swizzling (equivalent to lvec4.xxxwy).
        /// </summary>
        public lvec5 rrrag => new lvec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.xxxwz swizzling.
        /// </summary>
        public lvec5 xxxwz => new lvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.rrrab swizzling (equivalent to lvec4.xxxwz).
        /// </summary>
        public lvec5 rrrab => new lvec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.xxxww swizzling.
        /// </summary>
        public lvec5 xxxww => new lvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.rrraa swizzling (equivalent to lvec4.xxxww).
        /// </summary>
        public lvec5 rrraa => new lvec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.xxy swizzling.
        /// </summary>
        public lvec3 xxy => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec4.rrg swizzling (equivalent to lvec4.xxy).
        /// </summary>
        public lvec3 rrg => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec4.xxyx swizzling.
        /// </summary>
        public lvec4 xxyx => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.rrgr swizzling (equivalent to lvec4.xxyx).
        /// </summary>
        public lvec4 rrgr => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.xxyxx swizzling.
        /// </summary>
        public lvec5 xxyxx => new lvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.rrgrr swizzling (equivalent to lvec4.xxyxx).
        /// </summary>
        public lvec5 rrgrr => new lvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.xxyxy swizzling.
        /// </summary>
        public lvec5 xxyxy => new lvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.rrgrg swizzling (equivalent to lvec4.xxyxy).
        /// </summary>
        public lvec5 rrgrg => new lvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.xxyxz swizzling.
        /// </summary>
        public lvec5 xxyxz => new lvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.rrgrb swizzling (equivalent to lvec4.xxyxz).
        /// </summary>
        public lvec5 rrgrb => new lvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.xxyxw swizzling.
        /// </summary>
        public lvec5 xxyxw => new lvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.rrgra swizzling (equivalent to lvec4.xxyxw).
        /// </summary>
        public lvec5 rrgra => new lvec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.xxyy swizzling.
        /// </summary>
        public lvec4 xxyy => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.rrgg swizzling (equivalent to lvec4.xxyy).
        /// </summary>
        public lvec4 rrgg => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.xxyyx swizzling.
        /// </summary>
        public lvec5 xxyyx => new lvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.rrggr swizzling (equivalent to lvec4.xxyyx).
        /// </summary>
        public lvec5 rrggr => new lvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.xxyyy swizzling.
        /// </summary>
        public lvec5 xxyyy => new lvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.rrggg swizzling (equivalent to lvec4.xxyyy).
        /// </summary>
        public lvec5 rrggg => new lvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.xxyyz swizzling.
        /// </summary>
        public lvec5 xxyyz => new lvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.rrggb swizzling (equivalent to lvec4.xxyyz).
        /// </summary>
        public lvec5 rrggb => new lvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.xxyyw swizzling.
        /// </summary>
        public lvec5 xxyyw => new lvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.rrgga swizzling (equivalent to lvec4.xxyyw).
        /// </summary>
        public lvec5 rrgga => new lvec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.xxyz swizzling.
        /// </summary>
        public lvec4 xxyz => new lvec4(x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.rrgb swizzling (equivalent to lvec4.xxyz).
        /// </summary>
        public lvec4 rrgb => new lvec4(x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.xxyzx swizzling.
        /// </summary>
        public lvec5 xxyzx => new lvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.rrgbr swizzling (equivalent to lvec4.xxyzx).
        /// </summary>
        public lvec5 rrgbr => new lvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.xxyzy swizzling.
        /// </summary>
        public lvec5 xxyzy => new lvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.rrgbg swizzling (equivalent to lvec4.xxyzy).
        /// </summary>
        public lvec5 rrgbg => new lvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.xxyzz swizzling.
        /// </summary>
        public lvec5 xxyzz => new lvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.rrgbb swizzling (equivalent to lvec4.xxyzz).
        /// </summary>
        public lvec5 rrgbb => new lvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.xxyzw swizzling.
        /// </summary>
        public lvec5 xxyzw => new lvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.rrgba swizzling (equivalent to lvec4.xxyzw).
        /// </summary>
        public lvec5 rrgba => new lvec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.xxyw swizzling.
        /// </summary>
        public lvec4 xxyw => new lvec4(x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.rrga swizzling (equivalent to lvec4.xxyw).
        /// </summary>
        public lvec4 rrga => new lvec4(x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.xxywx swizzling.
        /// </summary>
        public lvec5 xxywx => new lvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.rrgar swizzling (equivalent to lvec4.xxywx).
        /// </summary>
        public lvec5 rrgar => new lvec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.xxywy swizzling.
        /// </summary>
        public lvec5 xxywy => new lvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.rrgag swizzling (equivalent to lvec4.xxywy).
        /// </summary>
        public lvec5 rrgag => new lvec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.xxywz swizzling.
        /// </summary>
        public lvec5 xxywz => new lvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.rrgab swizzling (equivalent to lvec4.xxywz).
        /// </summary>
        public lvec5 rrgab => new lvec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.xxyww swizzling.
        /// </summary>
        public lvec5 xxyww => new lvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.rrgaa swizzling (equivalent to lvec4.xxyww).
        /// </summary>
        public lvec5 rrgaa => new lvec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.xxz swizzling.
        /// </summary>
        public lvec3 xxz => new lvec3(x, x, z);
        
        /// <summary>
        /// Returns lvec4.rrb swizzling (equivalent to lvec4.xxz).
        /// </summary>
        public lvec3 rrb => new lvec3(x, x, z);
        
        /// <summary>
        /// Returns lvec4.xxzx swizzling.
        /// </summary>
        public lvec4 xxzx => new lvec4(x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.rrbr swizzling (equivalent to lvec4.xxzx).
        /// </summary>
        public lvec4 rrbr => new lvec4(x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.xxzxx swizzling.
        /// </summary>
        public lvec5 xxzxx => new lvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.rrbrr swizzling (equivalent to lvec4.xxzxx).
        /// </summary>
        public lvec5 rrbrr => new lvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.xxzxy swizzling.
        /// </summary>
        public lvec5 xxzxy => new lvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.rrbrg swizzling (equivalent to lvec4.xxzxy).
        /// </summary>
        public lvec5 rrbrg => new lvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.xxzxz swizzling.
        /// </summary>
        public lvec5 xxzxz => new lvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.rrbrb swizzling (equivalent to lvec4.xxzxz).
        /// </summary>
        public lvec5 rrbrb => new lvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.xxzxw swizzling.
        /// </summary>
        public lvec5 xxzxw => new lvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.rrbra swizzling (equivalent to lvec4.xxzxw).
        /// </summary>
        public lvec5 rrbra => new lvec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.xxzy swizzling.
        /// </summary>
        public lvec4 xxzy => new lvec4(x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.rrbg swizzling (equivalent to lvec4.xxzy).
        /// </summary>
        public lvec4 rrbg => new lvec4(x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.xxzyx swizzling.
        /// </summary>
        public lvec5 xxzyx => new lvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.rrbgr swizzling (equivalent to lvec4.xxzyx).
        /// </summary>
        public lvec5 rrbgr => new lvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.xxzyy swizzling.
        /// </summary>
        public lvec5 xxzyy => new lvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.rrbgg swizzling (equivalent to lvec4.xxzyy).
        /// </summary>
        public lvec5 rrbgg => new lvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.xxzyz swizzling.
        /// </summary>
        public lvec5 xxzyz => new lvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.rrbgb swizzling (equivalent to lvec4.xxzyz).
        /// </summary>
        public lvec5 rrbgb => new lvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.xxzyw swizzling.
        /// </summary>
        public lvec5 xxzyw => new lvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.rrbga swizzling (equivalent to lvec4.xxzyw).
        /// </summary>
        public lvec5 rrbga => new lvec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.xxzz swizzling.
        /// </summary>
        public lvec4 xxzz => new lvec4(x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.rrbb swizzling (equivalent to lvec4.xxzz).
        /// </summary>
        public lvec4 rrbb => new lvec4(x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.xxzzx swizzling.
        /// </summary>
        public lvec5 xxzzx => new lvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.rrbbr swizzling (equivalent to lvec4.xxzzx).
        /// </summary>
        public lvec5 rrbbr => new lvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.xxzzy swizzling.
        /// </summary>
        public lvec5 xxzzy => new lvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.rrbbg swizzling (equivalent to lvec4.xxzzy).
        /// </summary>
        public lvec5 rrbbg => new lvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.xxzzz swizzling.
        /// </summary>
        public lvec5 xxzzz => new lvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.rrbbb swizzling (equivalent to lvec4.xxzzz).
        /// </summary>
        public lvec5 rrbbb => new lvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.xxzzw swizzling.
        /// </summary>
        public lvec5 xxzzw => new lvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.rrbba swizzling (equivalent to lvec4.xxzzw).
        /// </summary>
        public lvec5 rrbba => new lvec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.xxzw swizzling.
        /// </summary>
        public lvec4 xxzw => new lvec4(x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.rrba swizzling (equivalent to lvec4.xxzw).
        /// </summary>
        public lvec4 rrba => new lvec4(x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.xxzwx swizzling.
        /// </summary>
        public lvec5 xxzwx => new lvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.rrbar swizzling (equivalent to lvec4.xxzwx).
        /// </summary>
        public lvec5 rrbar => new lvec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.xxzwy swizzling.
        /// </summary>
        public lvec5 xxzwy => new lvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.rrbag swizzling (equivalent to lvec4.xxzwy).
        /// </summary>
        public lvec5 rrbag => new lvec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.xxzwz swizzling.
        /// </summary>
        public lvec5 xxzwz => new lvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.rrbab swizzling (equivalent to lvec4.xxzwz).
        /// </summary>
        public lvec5 rrbab => new lvec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.xxzww swizzling.
        /// </summary>
        public lvec5 xxzww => new lvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.rrbaa swizzling (equivalent to lvec4.xxzww).
        /// </summary>
        public lvec5 rrbaa => new lvec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.xxw swizzling.
        /// </summary>
        public lvec3 xxw => new lvec3(x, x, w);
        
        /// <summary>
        /// Returns lvec4.rra swizzling (equivalent to lvec4.xxw).
        /// </summary>
        public lvec3 rra => new lvec3(x, x, w);
        
        /// <summary>
        /// Returns lvec4.xxwx swizzling.
        /// </summary>
        public lvec4 xxwx => new lvec4(x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.rrar swizzling (equivalent to lvec4.xxwx).
        /// </summary>
        public lvec4 rrar => new lvec4(x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.xxwxx swizzling.
        /// </summary>
        public lvec5 xxwxx => new lvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.rrarr swizzling (equivalent to lvec4.xxwxx).
        /// </summary>
        public lvec5 rrarr => new lvec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.xxwxy swizzling.
        /// </summary>
        public lvec5 xxwxy => new lvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.rrarg swizzling (equivalent to lvec4.xxwxy).
        /// </summary>
        public lvec5 rrarg => new lvec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.xxwxz swizzling.
        /// </summary>
        public lvec5 xxwxz => new lvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.rrarb swizzling (equivalent to lvec4.xxwxz).
        /// </summary>
        public lvec5 rrarb => new lvec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.xxwxw swizzling.
        /// </summary>
        public lvec5 xxwxw => new lvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.rrara swizzling (equivalent to lvec4.xxwxw).
        /// </summary>
        public lvec5 rrara => new lvec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.xxwy swizzling.
        /// </summary>
        public lvec4 xxwy => new lvec4(x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.rrag swizzling (equivalent to lvec4.xxwy).
        /// </summary>
        public lvec4 rrag => new lvec4(x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.xxwyx swizzling.
        /// </summary>
        public lvec5 xxwyx => new lvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.rragr swizzling (equivalent to lvec4.xxwyx).
        /// </summary>
        public lvec5 rragr => new lvec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.xxwyy swizzling.
        /// </summary>
        public lvec5 xxwyy => new lvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.rragg swizzling (equivalent to lvec4.xxwyy).
        /// </summary>
        public lvec5 rragg => new lvec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.xxwyz swizzling.
        /// </summary>
        public lvec5 xxwyz => new lvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.rragb swizzling (equivalent to lvec4.xxwyz).
        /// </summary>
        public lvec5 rragb => new lvec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.xxwyw swizzling.
        /// </summary>
        public lvec5 xxwyw => new lvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.rraga swizzling (equivalent to lvec4.xxwyw).
        /// </summary>
        public lvec5 rraga => new lvec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.xxwz swizzling.
        /// </summary>
        public lvec4 xxwz => new lvec4(x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.rrab swizzling (equivalent to lvec4.xxwz).
        /// </summary>
        public lvec4 rrab => new lvec4(x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.xxwzx swizzling.
        /// </summary>
        public lvec5 xxwzx => new lvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.rrabr swizzling (equivalent to lvec4.xxwzx).
        /// </summary>
        public lvec5 rrabr => new lvec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.xxwzy swizzling.
        /// </summary>
        public lvec5 xxwzy => new lvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.rrabg swizzling (equivalent to lvec4.xxwzy).
        /// </summary>
        public lvec5 rrabg => new lvec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.xxwzz swizzling.
        /// </summary>
        public lvec5 xxwzz => new lvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.rrabb swizzling (equivalent to lvec4.xxwzz).
        /// </summary>
        public lvec5 rrabb => new lvec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.xxwzw swizzling.
        /// </summary>
        public lvec5 xxwzw => new lvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.rraba swizzling (equivalent to lvec4.xxwzw).
        /// </summary>
        public lvec5 rraba => new lvec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.xxww swizzling.
        /// </summary>
        public lvec4 xxww => new lvec4(x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.rraa swizzling (equivalent to lvec4.xxww).
        /// </summary>
        public lvec4 rraa => new lvec4(x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.xxwwx swizzling.
        /// </summary>
        public lvec5 xxwwx => new lvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.rraar swizzling (equivalent to lvec4.xxwwx).
        /// </summary>
        public lvec5 rraar => new lvec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.xxwwy swizzling.
        /// </summary>
        public lvec5 xxwwy => new lvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.rraag swizzling (equivalent to lvec4.xxwwy).
        /// </summary>
        public lvec5 rraag => new lvec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.xxwwz swizzling.
        /// </summary>
        public lvec5 xxwwz => new lvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.rraab swizzling (equivalent to lvec4.xxwwz).
        /// </summary>
        public lvec5 rraab => new lvec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.xxwww swizzling.
        /// </summary>
        public lvec5 xxwww => new lvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.rraaa swizzling (equivalent to lvec4.xxwww).
        /// </summary>
        public lvec5 rraaa => new lvec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.xy swizzling.
        /// </summary>
        public lvec2 xy => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec4.rg swizzling (equivalent to lvec4.xy).
        /// </summary>
        public lvec2 rg => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec4.xyx swizzling.
        /// </summary>
        public lvec3 xyx => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec4.rgr swizzling (equivalent to lvec4.xyx).
        /// </summary>
        public lvec3 rgr => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec4.xyxx swizzling.
        /// </summary>
        public lvec4 xyxx => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.rgrr swizzling (equivalent to lvec4.xyxx).
        /// </summary>
        public lvec4 rgrr => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.xyxxx swizzling.
        /// </summary>
        public lvec5 xyxxx => new lvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.rgrrr swizzling (equivalent to lvec4.xyxxx).
        /// </summary>
        public lvec5 rgrrr => new lvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.xyxxy swizzling.
        /// </summary>
        public lvec5 xyxxy => new lvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.rgrrg swizzling (equivalent to lvec4.xyxxy).
        /// </summary>
        public lvec5 rgrrg => new lvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.xyxxz swizzling.
        /// </summary>
        public lvec5 xyxxz => new lvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.rgrrb swizzling (equivalent to lvec4.xyxxz).
        /// </summary>
        public lvec5 rgrrb => new lvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.xyxxw swizzling.
        /// </summary>
        public lvec5 xyxxw => new lvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.rgrra swizzling (equivalent to lvec4.xyxxw).
        /// </summary>
        public lvec5 rgrra => new lvec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.xyxy swizzling.
        /// </summary>
        public lvec4 xyxy => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.rgrg swizzling (equivalent to lvec4.xyxy).
        /// </summary>
        public lvec4 rgrg => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.xyxyx swizzling.
        /// </summary>
        public lvec5 xyxyx => new lvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.rgrgr swizzling (equivalent to lvec4.xyxyx).
        /// </summary>
        public lvec5 rgrgr => new lvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.xyxyy swizzling.
        /// </summary>
        public lvec5 xyxyy => new lvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.rgrgg swizzling (equivalent to lvec4.xyxyy).
        /// </summary>
        public lvec5 rgrgg => new lvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.xyxyz swizzling.
        /// </summary>
        public lvec5 xyxyz => new lvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.rgrgb swizzling (equivalent to lvec4.xyxyz).
        /// </summary>
        public lvec5 rgrgb => new lvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.xyxyw swizzling.
        /// </summary>
        public lvec5 xyxyw => new lvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.rgrga swizzling (equivalent to lvec4.xyxyw).
        /// </summary>
        public lvec5 rgrga => new lvec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.xyxz swizzling.
        /// </summary>
        public lvec4 xyxz => new lvec4(x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.rgrb swizzling (equivalent to lvec4.xyxz).
        /// </summary>
        public lvec4 rgrb => new lvec4(x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.xyxzx swizzling.
        /// </summary>
        public lvec5 xyxzx => new lvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.rgrbr swizzling (equivalent to lvec4.xyxzx).
        /// </summary>
        public lvec5 rgrbr => new lvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.xyxzy swizzling.
        /// </summary>
        public lvec5 xyxzy => new lvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.rgrbg swizzling (equivalent to lvec4.xyxzy).
        /// </summary>
        public lvec5 rgrbg => new lvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.xyxzz swizzling.
        /// </summary>
        public lvec5 xyxzz => new lvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.rgrbb swizzling (equivalent to lvec4.xyxzz).
        /// </summary>
        public lvec5 rgrbb => new lvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.xyxzw swizzling.
        /// </summary>
        public lvec5 xyxzw => new lvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.rgrba swizzling (equivalent to lvec4.xyxzw).
        /// </summary>
        public lvec5 rgrba => new lvec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.xyxw swizzling.
        /// </summary>
        public lvec4 xyxw => new lvec4(x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.rgra swizzling (equivalent to lvec4.xyxw).
        /// </summary>
        public lvec4 rgra => new lvec4(x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.xyxwx swizzling.
        /// </summary>
        public lvec5 xyxwx => new lvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.rgrar swizzling (equivalent to lvec4.xyxwx).
        /// </summary>
        public lvec5 rgrar => new lvec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.xyxwy swizzling.
        /// </summary>
        public lvec5 xyxwy => new lvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.rgrag swizzling (equivalent to lvec4.xyxwy).
        /// </summary>
        public lvec5 rgrag => new lvec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.xyxwz swizzling.
        /// </summary>
        public lvec5 xyxwz => new lvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.rgrab swizzling (equivalent to lvec4.xyxwz).
        /// </summary>
        public lvec5 rgrab => new lvec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.xyxww swizzling.
        /// </summary>
        public lvec5 xyxww => new lvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.rgraa swizzling (equivalent to lvec4.xyxww).
        /// </summary>
        public lvec5 rgraa => new lvec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.xyy swizzling.
        /// </summary>
        public lvec3 xyy => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec4.rgg swizzling (equivalent to lvec4.xyy).
        /// </summary>
        public lvec3 rgg => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec4.xyyx swizzling.
        /// </summary>
        public lvec4 xyyx => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.rggr swizzling (equivalent to lvec4.xyyx).
        /// </summary>
        public lvec4 rggr => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.xyyxx swizzling.
        /// </summary>
        public lvec5 xyyxx => new lvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.rggrr swizzling (equivalent to lvec4.xyyxx).
        /// </summary>
        public lvec5 rggrr => new lvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.xyyxy swizzling.
        /// </summary>
        public lvec5 xyyxy => new lvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.rggrg swizzling (equivalent to lvec4.xyyxy).
        /// </summary>
        public lvec5 rggrg => new lvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.xyyxz swizzling.
        /// </summary>
        public lvec5 xyyxz => new lvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.rggrb swizzling (equivalent to lvec4.xyyxz).
        /// </summary>
        public lvec5 rggrb => new lvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.xyyxw swizzling.
        /// </summary>
        public lvec5 xyyxw => new lvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.rggra swizzling (equivalent to lvec4.xyyxw).
        /// </summary>
        public lvec5 rggra => new lvec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.xyyy swizzling.
        /// </summary>
        public lvec4 xyyy => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.rggg swizzling (equivalent to lvec4.xyyy).
        /// </summary>
        public lvec4 rggg => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.xyyyx swizzling.
        /// </summary>
        public lvec5 xyyyx => new lvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.rgggr swizzling (equivalent to lvec4.xyyyx).
        /// </summary>
        public lvec5 rgggr => new lvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.xyyyy swizzling.
        /// </summary>
        public lvec5 xyyyy => new lvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.rgggg swizzling (equivalent to lvec4.xyyyy).
        /// </summary>
        public lvec5 rgggg => new lvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.xyyyz swizzling.
        /// </summary>
        public lvec5 xyyyz => new lvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.rgggb swizzling (equivalent to lvec4.xyyyz).
        /// </summary>
        public lvec5 rgggb => new lvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.xyyyw swizzling.
        /// </summary>
        public lvec5 xyyyw => new lvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.rggga swizzling (equivalent to lvec4.xyyyw).
        /// </summary>
        public lvec5 rggga => new lvec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.xyyz swizzling.
        /// </summary>
        public lvec4 xyyz => new lvec4(x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.rggb swizzling (equivalent to lvec4.xyyz).
        /// </summary>
        public lvec4 rggb => new lvec4(x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.xyyzx swizzling.
        /// </summary>
        public lvec5 xyyzx => new lvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.rggbr swizzling (equivalent to lvec4.xyyzx).
        /// </summary>
        public lvec5 rggbr => new lvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.xyyzy swizzling.
        /// </summary>
        public lvec5 xyyzy => new lvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.rggbg swizzling (equivalent to lvec4.xyyzy).
        /// </summary>
        public lvec5 rggbg => new lvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.xyyzz swizzling.
        /// </summary>
        public lvec5 xyyzz => new lvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.rggbb swizzling (equivalent to lvec4.xyyzz).
        /// </summary>
        public lvec5 rggbb => new lvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.xyyzw swizzling.
        /// </summary>
        public lvec5 xyyzw => new lvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.rggba swizzling (equivalent to lvec4.xyyzw).
        /// </summary>
        public lvec5 rggba => new lvec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.xyyw swizzling.
        /// </summary>
        public lvec4 xyyw => new lvec4(x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.rgga swizzling (equivalent to lvec4.xyyw).
        /// </summary>
        public lvec4 rgga => new lvec4(x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.xyywx swizzling.
        /// </summary>
        public lvec5 xyywx => new lvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.rggar swizzling (equivalent to lvec4.xyywx).
        /// </summary>
        public lvec5 rggar => new lvec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.xyywy swizzling.
        /// </summary>
        public lvec5 xyywy => new lvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.rggag swizzling (equivalent to lvec4.xyywy).
        /// </summary>
        public lvec5 rggag => new lvec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.xyywz swizzling.
        /// </summary>
        public lvec5 xyywz => new lvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.rggab swizzling (equivalent to lvec4.xyywz).
        /// </summary>
        public lvec5 rggab => new lvec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.xyyww swizzling.
        /// </summary>
        public lvec5 xyyww => new lvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.rggaa swizzling (equivalent to lvec4.xyyww).
        /// </summary>
        public lvec5 rggaa => new lvec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.xyz swizzling.
        /// </summary>
        public lvec3 xyz => new lvec3(x, y, z);
        
        /// <summary>
        /// Returns lvec4.rgb swizzling (equivalent to lvec4.xyz).
        /// </summary>
        public lvec3 rgb => new lvec3(x, y, z);
        
        /// <summary>
        /// Returns lvec4.xyzx swizzling.
        /// </summary>
        public lvec4 xyzx => new lvec4(x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.rgbr swizzling (equivalent to lvec4.xyzx).
        /// </summary>
        public lvec4 rgbr => new lvec4(x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.xyzxx swizzling.
        /// </summary>
        public lvec5 xyzxx => new lvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.rgbrr swizzling (equivalent to lvec4.xyzxx).
        /// </summary>
        public lvec5 rgbrr => new lvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.xyzxy swizzling.
        /// </summary>
        public lvec5 xyzxy => new lvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.rgbrg swizzling (equivalent to lvec4.xyzxy).
        /// </summary>
        public lvec5 rgbrg => new lvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.xyzxz swizzling.
        /// </summary>
        public lvec5 xyzxz => new lvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.rgbrb swizzling (equivalent to lvec4.xyzxz).
        /// </summary>
        public lvec5 rgbrb => new lvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.xyzxw swizzling.
        /// </summary>
        public lvec5 xyzxw => new lvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.rgbra swizzling (equivalent to lvec4.xyzxw).
        /// </summary>
        public lvec5 rgbra => new lvec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.xyzy swizzling.
        /// </summary>
        public lvec4 xyzy => new lvec4(x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.rgbg swizzling (equivalent to lvec4.xyzy).
        /// </summary>
        public lvec4 rgbg => new lvec4(x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.xyzyx swizzling.
        /// </summary>
        public lvec5 xyzyx => new lvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.rgbgr swizzling (equivalent to lvec4.xyzyx).
        /// </summary>
        public lvec5 rgbgr => new lvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.xyzyy swizzling.
        /// </summary>
        public lvec5 xyzyy => new lvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.rgbgg swizzling (equivalent to lvec4.xyzyy).
        /// </summary>
        public lvec5 rgbgg => new lvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.xyzyz swizzling.
        /// </summary>
        public lvec5 xyzyz => new lvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.rgbgb swizzling (equivalent to lvec4.xyzyz).
        /// </summary>
        public lvec5 rgbgb => new lvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.xyzyw swizzling.
        /// </summary>
        public lvec5 xyzyw => new lvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.rgbga swizzling (equivalent to lvec4.xyzyw).
        /// </summary>
        public lvec5 rgbga => new lvec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.xyzz swizzling.
        /// </summary>
        public lvec4 xyzz => new lvec4(x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.rgbb swizzling (equivalent to lvec4.xyzz).
        /// </summary>
        public lvec4 rgbb => new lvec4(x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.xyzzx swizzling.
        /// </summary>
        public lvec5 xyzzx => new lvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.rgbbr swizzling (equivalent to lvec4.xyzzx).
        /// </summary>
        public lvec5 rgbbr => new lvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.xyzzy swizzling.
        /// </summary>
        public lvec5 xyzzy => new lvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.rgbbg swizzling (equivalent to lvec4.xyzzy).
        /// </summary>
        public lvec5 rgbbg => new lvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.xyzzz swizzling.
        /// </summary>
        public lvec5 xyzzz => new lvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.rgbbb swizzling (equivalent to lvec4.xyzzz).
        /// </summary>
        public lvec5 rgbbb => new lvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.xyzzw swizzling.
        /// </summary>
        public lvec5 xyzzw => new lvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.rgbba swizzling (equivalent to lvec4.xyzzw).
        /// </summary>
        public lvec5 rgbba => new lvec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.xyzw swizzling.
        /// </summary>
        public lvec4 xyzw => new lvec4(x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.rgba swizzling (equivalent to lvec4.xyzw).
        /// </summary>
        public lvec4 rgba => new lvec4(x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.xyzwx swizzling.
        /// </summary>
        public lvec5 xyzwx => new lvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.rgbar swizzling (equivalent to lvec4.xyzwx).
        /// </summary>
        public lvec5 rgbar => new lvec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.xyzwy swizzling.
        /// </summary>
        public lvec5 xyzwy => new lvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.rgbag swizzling (equivalent to lvec4.xyzwy).
        /// </summary>
        public lvec5 rgbag => new lvec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.xyzwz swizzling.
        /// </summary>
        public lvec5 xyzwz => new lvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.rgbab swizzling (equivalent to lvec4.xyzwz).
        /// </summary>
        public lvec5 rgbab => new lvec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.xyzww swizzling.
        /// </summary>
        public lvec5 xyzww => new lvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.rgbaa swizzling (equivalent to lvec4.xyzww).
        /// </summary>
        public lvec5 rgbaa => new lvec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.xyw swizzling.
        /// </summary>
        public lvec3 xyw => new lvec3(x, y, w);
        
        /// <summary>
        /// Returns lvec4.rga swizzling (equivalent to lvec4.xyw).
        /// </summary>
        public lvec3 rga => new lvec3(x, y, w);
        
        /// <summary>
        /// Returns lvec4.xywx swizzling.
        /// </summary>
        public lvec4 xywx => new lvec4(x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.rgar swizzling (equivalent to lvec4.xywx).
        /// </summary>
        public lvec4 rgar => new lvec4(x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.xywxx swizzling.
        /// </summary>
        public lvec5 xywxx => new lvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.rgarr swizzling (equivalent to lvec4.xywxx).
        /// </summary>
        public lvec5 rgarr => new lvec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.xywxy swizzling.
        /// </summary>
        public lvec5 xywxy => new lvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.rgarg swizzling (equivalent to lvec4.xywxy).
        /// </summary>
        public lvec5 rgarg => new lvec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.xywxz swizzling.
        /// </summary>
        public lvec5 xywxz => new lvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.rgarb swizzling (equivalent to lvec4.xywxz).
        /// </summary>
        public lvec5 rgarb => new lvec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.xywxw swizzling.
        /// </summary>
        public lvec5 xywxw => new lvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.rgara swizzling (equivalent to lvec4.xywxw).
        /// </summary>
        public lvec5 rgara => new lvec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.xywy swizzling.
        /// </summary>
        public lvec4 xywy => new lvec4(x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.rgag swizzling (equivalent to lvec4.xywy).
        /// </summary>
        public lvec4 rgag => new lvec4(x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.xywyx swizzling.
        /// </summary>
        public lvec5 xywyx => new lvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.rgagr swizzling (equivalent to lvec4.xywyx).
        /// </summary>
        public lvec5 rgagr => new lvec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.xywyy swizzling.
        /// </summary>
        public lvec5 xywyy => new lvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.rgagg swizzling (equivalent to lvec4.xywyy).
        /// </summary>
        public lvec5 rgagg => new lvec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.xywyz swizzling.
        /// </summary>
        public lvec5 xywyz => new lvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.rgagb swizzling (equivalent to lvec4.xywyz).
        /// </summary>
        public lvec5 rgagb => new lvec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.xywyw swizzling.
        /// </summary>
        public lvec5 xywyw => new lvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.rgaga swizzling (equivalent to lvec4.xywyw).
        /// </summary>
        public lvec5 rgaga => new lvec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.xywz swizzling.
        /// </summary>
        public lvec4 xywz => new lvec4(x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.rgab swizzling (equivalent to lvec4.xywz).
        /// </summary>
        public lvec4 rgab => new lvec4(x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.xywzx swizzling.
        /// </summary>
        public lvec5 xywzx => new lvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.rgabr swizzling (equivalent to lvec4.xywzx).
        /// </summary>
        public lvec5 rgabr => new lvec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.xywzy swizzling.
        /// </summary>
        public lvec5 xywzy => new lvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.rgabg swizzling (equivalent to lvec4.xywzy).
        /// </summary>
        public lvec5 rgabg => new lvec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.xywzz swizzling.
        /// </summary>
        public lvec5 xywzz => new lvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.rgabb swizzling (equivalent to lvec4.xywzz).
        /// </summary>
        public lvec5 rgabb => new lvec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.xywzw swizzling.
        /// </summary>
        public lvec5 xywzw => new lvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.rgaba swizzling (equivalent to lvec4.xywzw).
        /// </summary>
        public lvec5 rgaba => new lvec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.xyww swizzling.
        /// </summary>
        public lvec4 xyww => new lvec4(x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.rgaa swizzling (equivalent to lvec4.xyww).
        /// </summary>
        public lvec4 rgaa => new lvec4(x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.xywwx swizzling.
        /// </summary>
        public lvec5 xywwx => new lvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.rgaar swizzling (equivalent to lvec4.xywwx).
        /// </summary>
        public lvec5 rgaar => new lvec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.xywwy swizzling.
        /// </summary>
        public lvec5 xywwy => new lvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.rgaag swizzling (equivalent to lvec4.xywwy).
        /// </summary>
        public lvec5 rgaag => new lvec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.xywwz swizzling.
        /// </summary>
        public lvec5 xywwz => new lvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.rgaab swizzling (equivalent to lvec4.xywwz).
        /// </summary>
        public lvec5 rgaab => new lvec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.xywww swizzling.
        /// </summary>
        public lvec5 xywww => new lvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.rgaaa swizzling (equivalent to lvec4.xywww).
        /// </summary>
        public lvec5 rgaaa => new lvec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.xz swizzling.
        /// </summary>
        public lvec2 xz => new lvec2(x, z);
        
        /// <summary>
        /// Returns lvec4.rb swizzling (equivalent to lvec4.xz).
        /// </summary>
        public lvec2 rb => new lvec2(x, z);
        
        /// <summary>
        /// Returns lvec4.xzx swizzling.
        /// </summary>
        public lvec3 xzx => new lvec3(x, z, x);
        
        /// <summary>
        /// Returns lvec4.rbr swizzling (equivalent to lvec4.xzx).
        /// </summary>
        public lvec3 rbr => new lvec3(x, z, x);
        
        /// <summary>
        /// Returns lvec4.xzxx swizzling.
        /// </summary>
        public lvec4 xzxx => new lvec4(x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.rbrr swizzling (equivalent to lvec4.xzxx).
        /// </summary>
        public lvec4 rbrr => new lvec4(x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.xzxxx swizzling.
        /// </summary>
        public lvec5 xzxxx => new lvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.rbrrr swizzling (equivalent to lvec4.xzxxx).
        /// </summary>
        public lvec5 rbrrr => new lvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.xzxxy swizzling.
        /// </summary>
        public lvec5 xzxxy => new lvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.rbrrg swizzling (equivalent to lvec4.xzxxy).
        /// </summary>
        public lvec5 rbrrg => new lvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.xzxxz swizzling.
        /// </summary>
        public lvec5 xzxxz => new lvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.rbrrb swizzling (equivalent to lvec4.xzxxz).
        /// </summary>
        public lvec5 rbrrb => new lvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.xzxxw swizzling.
        /// </summary>
        public lvec5 xzxxw => new lvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.rbrra swizzling (equivalent to lvec4.xzxxw).
        /// </summary>
        public lvec5 rbrra => new lvec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.xzxy swizzling.
        /// </summary>
        public lvec4 xzxy => new lvec4(x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.rbrg swizzling (equivalent to lvec4.xzxy).
        /// </summary>
        public lvec4 rbrg => new lvec4(x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.xzxyx swizzling.
        /// </summary>
        public lvec5 xzxyx => new lvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.rbrgr swizzling (equivalent to lvec4.xzxyx).
        /// </summary>
        public lvec5 rbrgr => new lvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.xzxyy swizzling.
        /// </summary>
        public lvec5 xzxyy => new lvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.rbrgg swizzling (equivalent to lvec4.xzxyy).
        /// </summary>
        public lvec5 rbrgg => new lvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.xzxyz swizzling.
        /// </summary>
        public lvec5 xzxyz => new lvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.rbrgb swizzling (equivalent to lvec4.xzxyz).
        /// </summary>
        public lvec5 rbrgb => new lvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.xzxyw swizzling.
        /// </summary>
        public lvec5 xzxyw => new lvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.rbrga swizzling (equivalent to lvec4.xzxyw).
        /// </summary>
        public lvec5 rbrga => new lvec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.xzxz swizzling.
        /// </summary>
        public lvec4 xzxz => new lvec4(x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.rbrb swizzling (equivalent to lvec4.xzxz).
        /// </summary>
        public lvec4 rbrb => new lvec4(x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.xzxzx swizzling.
        /// </summary>
        public lvec5 xzxzx => new lvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.rbrbr swizzling (equivalent to lvec4.xzxzx).
        /// </summary>
        public lvec5 rbrbr => new lvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.xzxzy swizzling.
        /// </summary>
        public lvec5 xzxzy => new lvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.rbrbg swizzling (equivalent to lvec4.xzxzy).
        /// </summary>
        public lvec5 rbrbg => new lvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.xzxzz swizzling.
        /// </summary>
        public lvec5 xzxzz => new lvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.rbrbb swizzling (equivalent to lvec4.xzxzz).
        /// </summary>
        public lvec5 rbrbb => new lvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.xzxzw swizzling.
        /// </summary>
        public lvec5 xzxzw => new lvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.rbrba swizzling (equivalent to lvec4.xzxzw).
        /// </summary>
        public lvec5 rbrba => new lvec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.xzxw swizzling.
        /// </summary>
        public lvec4 xzxw => new lvec4(x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.rbra swizzling (equivalent to lvec4.xzxw).
        /// </summary>
        public lvec4 rbra => new lvec4(x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.xzxwx swizzling.
        /// </summary>
        public lvec5 xzxwx => new lvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.rbrar swizzling (equivalent to lvec4.xzxwx).
        /// </summary>
        public lvec5 rbrar => new lvec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.xzxwy swizzling.
        /// </summary>
        public lvec5 xzxwy => new lvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.rbrag swizzling (equivalent to lvec4.xzxwy).
        /// </summary>
        public lvec5 rbrag => new lvec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.xzxwz swizzling.
        /// </summary>
        public lvec5 xzxwz => new lvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.rbrab swizzling (equivalent to lvec4.xzxwz).
        /// </summary>
        public lvec5 rbrab => new lvec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.xzxww swizzling.
        /// </summary>
        public lvec5 xzxww => new lvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.rbraa swizzling (equivalent to lvec4.xzxww).
        /// </summary>
        public lvec5 rbraa => new lvec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.xzy swizzling.
        /// </summary>
        public lvec3 xzy => new lvec3(x, z, y);
        
        /// <summary>
        /// Returns lvec4.rbg swizzling (equivalent to lvec4.xzy).
        /// </summary>
        public lvec3 rbg => new lvec3(x, z, y);
        
        /// <summary>
        /// Returns lvec4.xzyx swizzling.
        /// </summary>
        public lvec4 xzyx => new lvec4(x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.rbgr swizzling (equivalent to lvec4.xzyx).
        /// </summary>
        public lvec4 rbgr => new lvec4(x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.xzyxx swizzling.
        /// </summary>
        public lvec5 xzyxx => new lvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.rbgrr swizzling (equivalent to lvec4.xzyxx).
        /// </summary>
        public lvec5 rbgrr => new lvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.xzyxy swizzling.
        /// </summary>
        public lvec5 xzyxy => new lvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.rbgrg swizzling (equivalent to lvec4.xzyxy).
        /// </summary>
        public lvec5 rbgrg => new lvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.xzyxz swizzling.
        /// </summary>
        public lvec5 xzyxz => new lvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.rbgrb swizzling (equivalent to lvec4.xzyxz).
        /// </summary>
        public lvec5 rbgrb => new lvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.xzyxw swizzling.
        /// </summary>
        public lvec5 xzyxw => new lvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.rbgra swizzling (equivalent to lvec4.xzyxw).
        /// </summary>
        public lvec5 rbgra => new lvec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.xzyy swizzling.
        /// </summary>
        public lvec4 xzyy => new lvec4(x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.rbgg swizzling (equivalent to lvec4.xzyy).
        /// </summary>
        public lvec4 rbgg => new lvec4(x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.xzyyx swizzling.
        /// </summary>
        public lvec5 xzyyx => new lvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.rbggr swizzling (equivalent to lvec4.xzyyx).
        /// </summary>
        public lvec5 rbggr => new lvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.xzyyy swizzling.
        /// </summary>
        public lvec5 xzyyy => new lvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.rbggg swizzling (equivalent to lvec4.xzyyy).
        /// </summary>
        public lvec5 rbggg => new lvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.xzyyz swizzling.
        /// </summary>
        public lvec5 xzyyz => new lvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.rbggb swizzling (equivalent to lvec4.xzyyz).
        /// </summary>
        public lvec5 rbggb => new lvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.xzyyw swizzling.
        /// </summary>
        public lvec5 xzyyw => new lvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.rbgga swizzling (equivalent to lvec4.xzyyw).
        /// </summary>
        public lvec5 rbgga => new lvec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.xzyz swizzling.
        /// </summary>
        public lvec4 xzyz => new lvec4(x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.rbgb swizzling (equivalent to lvec4.xzyz).
        /// </summary>
        public lvec4 rbgb => new lvec4(x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.xzyzx swizzling.
        /// </summary>
        public lvec5 xzyzx => new lvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.rbgbr swizzling (equivalent to lvec4.xzyzx).
        /// </summary>
        public lvec5 rbgbr => new lvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.xzyzy swizzling.
        /// </summary>
        public lvec5 xzyzy => new lvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.rbgbg swizzling (equivalent to lvec4.xzyzy).
        /// </summary>
        public lvec5 rbgbg => new lvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.xzyzz swizzling.
        /// </summary>
        public lvec5 xzyzz => new lvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.rbgbb swizzling (equivalent to lvec4.xzyzz).
        /// </summary>
        public lvec5 rbgbb => new lvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.xzyzw swizzling.
        /// </summary>
        public lvec5 xzyzw => new lvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.rbgba swizzling (equivalent to lvec4.xzyzw).
        /// </summary>
        public lvec5 rbgba => new lvec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.xzyw swizzling.
        /// </summary>
        public lvec4 xzyw => new lvec4(x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.rbga swizzling (equivalent to lvec4.xzyw).
        /// </summary>
        public lvec4 rbga => new lvec4(x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.xzywx swizzling.
        /// </summary>
        public lvec5 xzywx => new lvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.rbgar swizzling (equivalent to lvec4.xzywx).
        /// </summary>
        public lvec5 rbgar => new lvec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.xzywy swizzling.
        /// </summary>
        public lvec5 xzywy => new lvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.rbgag swizzling (equivalent to lvec4.xzywy).
        /// </summary>
        public lvec5 rbgag => new lvec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.xzywz swizzling.
        /// </summary>
        public lvec5 xzywz => new lvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.rbgab swizzling (equivalent to lvec4.xzywz).
        /// </summary>
        public lvec5 rbgab => new lvec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.xzyww swizzling.
        /// </summary>
        public lvec5 xzyww => new lvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.rbgaa swizzling (equivalent to lvec4.xzyww).
        /// </summary>
        public lvec5 rbgaa => new lvec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.xzz swizzling.
        /// </summary>
        public lvec3 xzz => new lvec3(x, z, z);
        
        /// <summary>
        /// Returns lvec4.rbb swizzling (equivalent to lvec4.xzz).
        /// </summary>
        public lvec3 rbb => new lvec3(x, z, z);
        
        /// <summary>
        /// Returns lvec4.xzzx swizzling.
        /// </summary>
        public lvec4 xzzx => new lvec4(x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.rbbr swizzling (equivalent to lvec4.xzzx).
        /// </summary>
        public lvec4 rbbr => new lvec4(x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.xzzxx swizzling.
        /// </summary>
        public lvec5 xzzxx => new lvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.rbbrr swizzling (equivalent to lvec4.xzzxx).
        /// </summary>
        public lvec5 rbbrr => new lvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.xzzxy swizzling.
        /// </summary>
        public lvec5 xzzxy => new lvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.rbbrg swizzling (equivalent to lvec4.xzzxy).
        /// </summary>
        public lvec5 rbbrg => new lvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.xzzxz swizzling.
        /// </summary>
        public lvec5 xzzxz => new lvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.rbbrb swizzling (equivalent to lvec4.xzzxz).
        /// </summary>
        public lvec5 rbbrb => new lvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.xzzxw swizzling.
        /// </summary>
        public lvec5 xzzxw => new lvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.rbbra swizzling (equivalent to lvec4.xzzxw).
        /// </summary>
        public lvec5 rbbra => new lvec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.xzzy swizzling.
        /// </summary>
        public lvec4 xzzy => new lvec4(x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.rbbg swizzling (equivalent to lvec4.xzzy).
        /// </summary>
        public lvec4 rbbg => new lvec4(x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.xzzyx swizzling.
        /// </summary>
        public lvec5 xzzyx => new lvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.rbbgr swizzling (equivalent to lvec4.xzzyx).
        /// </summary>
        public lvec5 rbbgr => new lvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.xzzyy swizzling.
        /// </summary>
        public lvec5 xzzyy => new lvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.rbbgg swizzling (equivalent to lvec4.xzzyy).
        /// </summary>
        public lvec5 rbbgg => new lvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.xzzyz swizzling.
        /// </summary>
        public lvec5 xzzyz => new lvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.rbbgb swizzling (equivalent to lvec4.xzzyz).
        /// </summary>
        public lvec5 rbbgb => new lvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.xzzyw swizzling.
        /// </summary>
        public lvec5 xzzyw => new lvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.rbbga swizzling (equivalent to lvec4.xzzyw).
        /// </summary>
        public lvec5 rbbga => new lvec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.xzzz swizzling.
        /// </summary>
        public lvec4 xzzz => new lvec4(x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.rbbb swizzling (equivalent to lvec4.xzzz).
        /// </summary>
        public lvec4 rbbb => new lvec4(x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.xzzzx swizzling.
        /// </summary>
        public lvec5 xzzzx => new lvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.rbbbr swizzling (equivalent to lvec4.xzzzx).
        /// </summary>
        public lvec5 rbbbr => new lvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.xzzzy swizzling.
        /// </summary>
        public lvec5 xzzzy => new lvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.rbbbg swizzling (equivalent to lvec4.xzzzy).
        /// </summary>
        public lvec5 rbbbg => new lvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.xzzzz swizzling.
        /// </summary>
        public lvec5 xzzzz => new lvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.rbbbb swizzling (equivalent to lvec4.xzzzz).
        /// </summary>
        public lvec5 rbbbb => new lvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.xzzzw swizzling.
        /// </summary>
        public lvec5 xzzzw => new lvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.rbbba swizzling (equivalent to lvec4.xzzzw).
        /// </summary>
        public lvec5 rbbba => new lvec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.xzzw swizzling.
        /// </summary>
        public lvec4 xzzw => new lvec4(x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.rbba swizzling (equivalent to lvec4.xzzw).
        /// </summary>
        public lvec4 rbba => new lvec4(x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.xzzwx swizzling.
        /// </summary>
        public lvec5 xzzwx => new lvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.rbbar swizzling (equivalent to lvec4.xzzwx).
        /// </summary>
        public lvec5 rbbar => new lvec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.xzzwy swizzling.
        /// </summary>
        public lvec5 xzzwy => new lvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.rbbag swizzling (equivalent to lvec4.xzzwy).
        /// </summary>
        public lvec5 rbbag => new lvec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.xzzwz swizzling.
        /// </summary>
        public lvec5 xzzwz => new lvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.rbbab swizzling (equivalent to lvec4.xzzwz).
        /// </summary>
        public lvec5 rbbab => new lvec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.xzzww swizzling.
        /// </summary>
        public lvec5 xzzww => new lvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.rbbaa swizzling (equivalent to lvec4.xzzww).
        /// </summary>
        public lvec5 rbbaa => new lvec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.xzw swizzling.
        /// </summary>
        public lvec3 xzw => new lvec3(x, z, w);
        
        /// <summary>
        /// Returns lvec4.rba swizzling (equivalent to lvec4.xzw).
        /// </summary>
        public lvec3 rba => new lvec3(x, z, w);
        
        /// <summary>
        /// Returns lvec4.xzwx swizzling.
        /// </summary>
        public lvec4 xzwx => new lvec4(x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.rbar swizzling (equivalent to lvec4.xzwx).
        /// </summary>
        public lvec4 rbar => new lvec4(x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.xzwxx swizzling.
        /// </summary>
        public lvec5 xzwxx => new lvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.rbarr swizzling (equivalent to lvec4.xzwxx).
        /// </summary>
        public lvec5 rbarr => new lvec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.xzwxy swizzling.
        /// </summary>
        public lvec5 xzwxy => new lvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.rbarg swizzling (equivalent to lvec4.xzwxy).
        /// </summary>
        public lvec5 rbarg => new lvec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.xzwxz swizzling.
        /// </summary>
        public lvec5 xzwxz => new lvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.rbarb swizzling (equivalent to lvec4.xzwxz).
        /// </summary>
        public lvec5 rbarb => new lvec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.xzwxw swizzling.
        /// </summary>
        public lvec5 xzwxw => new lvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.rbara swizzling (equivalent to lvec4.xzwxw).
        /// </summary>
        public lvec5 rbara => new lvec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.xzwy swizzling.
        /// </summary>
        public lvec4 xzwy => new lvec4(x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.rbag swizzling (equivalent to lvec4.xzwy).
        /// </summary>
        public lvec4 rbag => new lvec4(x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.xzwyx swizzling.
        /// </summary>
        public lvec5 xzwyx => new lvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.rbagr swizzling (equivalent to lvec4.xzwyx).
        /// </summary>
        public lvec5 rbagr => new lvec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.xzwyy swizzling.
        /// </summary>
        public lvec5 xzwyy => new lvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.rbagg swizzling (equivalent to lvec4.xzwyy).
        /// </summary>
        public lvec5 rbagg => new lvec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.xzwyz swizzling.
        /// </summary>
        public lvec5 xzwyz => new lvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.rbagb swizzling (equivalent to lvec4.xzwyz).
        /// </summary>
        public lvec5 rbagb => new lvec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.xzwyw swizzling.
        /// </summary>
        public lvec5 xzwyw => new lvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.rbaga swizzling (equivalent to lvec4.xzwyw).
        /// </summary>
        public lvec5 rbaga => new lvec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.xzwz swizzling.
        /// </summary>
        public lvec4 xzwz => new lvec4(x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.rbab swizzling (equivalent to lvec4.xzwz).
        /// </summary>
        public lvec4 rbab => new lvec4(x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.xzwzx swizzling.
        /// </summary>
        public lvec5 xzwzx => new lvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.rbabr swizzling (equivalent to lvec4.xzwzx).
        /// </summary>
        public lvec5 rbabr => new lvec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.xzwzy swizzling.
        /// </summary>
        public lvec5 xzwzy => new lvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.rbabg swizzling (equivalent to lvec4.xzwzy).
        /// </summary>
        public lvec5 rbabg => new lvec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.xzwzz swizzling.
        /// </summary>
        public lvec5 xzwzz => new lvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.rbabb swizzling (equivalent to lvec4.xzwzz).
        /// </summary>
        public lvec5 rbabb => new lvec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.xzwzw swizzling.
        /// </summary>
        public lvec5 xzwzw => new lvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.rbaba swizzling (equivalent to lvec4.xzwzw).
        /// </summary>
        public lvec5 rbaba => new lvec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.xzww swizzling.
        /// </summary>
        public lvec4 xzww => new lvec4(x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.rbaa swizzling (equivalent to lvec4.xzww).
        /// </summary>
        public lvec4 rbaa => new lvec4(x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.xzwwx swizzling.
        /// </summary>
        public lvec5 xzwwx => new lvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.rbaar swizzling (equivalent to lvec4.xzwwx).
        /// </summary>
        public lvec5 rbaar => new lvec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.xzwwy swizzling.
        /// </summary>
        public lvec5 xzwwy => new lvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.rbaag swizzling (equivalent to lvec4.xzwwy).
        /// </summary>
        public lvec5 rbaag => new lvec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.xzwwz swizzling.
        /// </summary>
        public lvec5 xzwwz => new lvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.rbaab swizzling (equivalent to lvec4.xzwwz).
        /// </summary>
        public lvec5 rbaab => new lvec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.xzwww swizzling.
        /// </summary>
        public lvec5 xzwww => new lvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.rbaaa swizzling (equivalent to lvec4.xzwww).
        /// </summary>
        public lvec5 rbaaa => new lvec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.xw swizzling.
        /// </summary>
        public lvec2 xw => new lvec2(x, w);
        
        /// <summary>
        /// Returns lvec4.ra swizzling (equivalent to lvec4.xw).
        /// </summary>
        public lvec2 ra => new lvec2(x, w);
        
        /// <summary>
        /// Returns lvec4.xwx swizzling.
        /// </summary>
        public lvec3 xwx => new lvec3(x, w, x);
        
        /// <summary>
        /// Returns lvec4.rar swizzling (equivalent to lvec4.xwx).
        /// </summary>
        public lvec3 rar => new lvec3(x, w, x);
        
        /// <summary>
        /// Returns lvec4.xwxx swizzling.
        /// </summary>
        public lvec4 xwxx => new lvec4(x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.rarr swizzling (equivalent to lvec4.xwxx).
        /// </summary>
        public lvec4 rarr => new lvec4(x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.xwxxx swizzling.
        /// </summary>
        public lvec5 xwxxx => new lvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.rarrr swizzling (equivalent to lvec4.xwxxx).
        /// </summary>
        public lvec5 rarrr => new lvec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.xwxxy swizzling.
        /// </summary>
        public lvec5 xwxxy => new lvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.rarrg swizzling (equivalent to lvec4.xwxxy).
        /// </summary>
        public lvec5 rarrg => new lvec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.xwxxz swizzling.
        /// </summary>
        public lvec5 xwxxz => new lvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.rarrb swizzling (equivalent to lvec4.xwxxz).
        /// </summary>
        public lvec5 rarrb => new lvec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.xwxxw swizzling.
        /// </summary>
        public lvec5 xwxxw => new lvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.rarra swizzling (equivalent to lvec4.xwxxw).
        /// </summary>
        public lvec5 rarra => new lvec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.xwxy swizzling.
        /// </summary>
        public lvec4 xwxy => new lvec4(x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.rarg swizzling (equivalent to lvec4.xwxy).
        /// </summary>
        public lvec4 rarg => new lvec4(x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.xwxyx swizzling.
        /// </summary>
        public lvec5 xwxyx => new lvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.rargr swizzling (equivalent to lvec4.xwxyx).
        /// </summary>
        public lvec5 rargr => new lvec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.xwxyy swizzling.
        /// </summary>
        public lvec5 xwxyy => new lvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.rargg swizzling (equivalent to lvec4.xwxyy).
        /// </summary>
        public lvec5 rargg => new lvec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.xwxyz swizzling.
        /// </summary>
        public lvec5 xwxyz => new lvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.rargb swizzling (equivalent to lvec4.xwxyz).
        /// </summary>
        public lvec5 rargb => new lvec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.xwxyw swizzling.
        /// </summary>
        public lvec5 xwxyw => new lvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.rarga swizzling (equivalent to lvec4.xwxyw).
        /// </summary>
        public lvec5 rarga => new lvec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.xwxz swizzling.
        /// </summary>
        public lvec4 xwxz => new lvec4(x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.rarb swizzling (equivalent to lvec4.xwxz).
        /// </summary>
        public lvec4 rarb => new lvec4(x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.xwxzx swizzling.
        /// </summary>
        public lvec5 xwxzx => new lvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.rarbr swizzling (equivalent to lvec4.xwxzx).
        /// </summary>
        public lvec5 rarbr => new lvec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.xwxzy swizzling.
        /// </summary>
        public lvec5 xwxzy => new lvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.rarbg swizzling (equivalent to lvec4.xwxzy).
        /// </summary>
        public lvec5 rarbg => new lvec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.xwxzz swizzling.
        /// </summary>
        public lvec5 xwxzz => new lvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.rarbb swizzling (equivalent to lvec4.xwxzz).
        /// </summary>
        public lvec5 rarbb => new lvec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.xwxzw swizzling.
        /// </summary>
        public lvec5 xwxzw => new lvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.rarba swizzling (equivalent to lvec4.xwxzw).
        /// </summary>
        public lvec5 rarba => new lvec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.xwxw swizzling.
        /// </summary>
        public lvec4 xwxw => new lvec4(x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.rara swizzling (equivalent to lvec4.xwxw).
        /// </summary>
        public lvec4 rara => new lvec4(x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.xwxwx swizzling.
        /// </summary>
        public lvec5 xwxwx => new lvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.rarar swizzling (equivalent to lvec4.xwxwx).
        /// </summary>
        public lvec5 rarar => new lvec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.xwxwy swizzling.
        /// </summary>
        public lvec5 xwxwy => new lvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.rarag swizzling (equivalent to lvec4.xwxwy).
        /// </summary>
        public lvec5 rarag => new lvec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.xwxwz swizzling.
        /// </summary>
        public lvec5 xwxwz => new lvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.rarab swizzling (equivalent to lvec4.xwxwz).
        /// </summary>
        public lvec5 rarab => new lvec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.xwxww swizzling.
        /// </summary>
        public lvec5 xwxww => new lvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.raraa swizzling (equivalent to lvec4.xwxww).
        /// </summary>
        public lvec5 raraa => new lvec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.xwy swizzling.
        /// </summary>
        public lvec3 xwy => new lvec3(x, w, y);
        
        /// <summary>
        /// Returns lvec4.rag swizzling (equivalent to lvec4.xwy).
        /// </summary>
        public lvec3 rag => new lvec3(x, w, y);
        
        /// <summary>
        /// Returns lvec4.xwyx swizzling.
        /// </summary>
        public lvec4 xwyx => new lvec4(x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.ragr swizzling (equivalent to lvec4.xwyx).
        /// </summary>
        public lvec4 ragr => new lvec4(x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.xwyxx swizzling.
        /// </summary>
        public lvec5 xwyxx => new lvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.ragrr swizzling (equivalent to lvec4.xwyxx).
        /// </summary>
        public lvec5 ragrr => new lvec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.xwyxy swizzling.
        /// </summary>
        public lvec5 xwyxy => new lvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.ragrg swizzling (equivalent to lvec4.xwyxy).
        /// </summary>
        public lvec5 ragrg => new lvec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.xwyxz swizzling.
        /// </summary>
        public lvec5 xwyxz => new lvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.ragrb swizzling (equivalent to lvec4.xwyxz).
        /// </summary>
        public lvec5 ragrb => new lvec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.xwyxw swizzling.
        /// </summary>
        public lvec5 xwyxw => new lvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.ragra swizzling (equivalent to lvec4.xwyxw).
        /// </summary>
        public lvec5 ragra => new lvec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.xwyy swizzling.
        /// </summary>
        public lvec4 xwyy => new lvec4(x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.ragg swizzling (equivalent to lvec4.xwyy).
        /// </summary>
        public lvec4 ragg => new lvec4(x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.xwyyx swizzling.
        /// </summary>
        public lvec5 xwyyx => new lvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.raggr swizzling (equivalent to lvec4.xwyyx).
        /// </summary>
        public lvec5 raggr => new lvec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.xwyyy swizzling.
        /// </summary>
        public lvec5 xwyyy => new lvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.raggg swizzling (equivalent to lvec4.xwyyy).
        /// </summary>
        public lvec5 raggg => new lvec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.xwyyz swizzling.
        /// </summary>
        public lvec5 xwyyz => new lvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.raggb swizzling (equivalent to lvec4.xwyyz).
        /// </summary>
        public lvec5 raggb => new lvec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.xwyyw swizzling.
        /// </summary>
        public lvec5 xwyyw => new lvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.ragga swizzling (equivalent to lvec4.xwyyw).
        /// </summary>
        public lvec5 ragga => new lvec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.xwyz swizzling.
        /// </summary>
        public lvec4 xwyz => new lvec4(x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.ragb swizzling (equivalent to lvec4.xwyz).
        /// </summary>
        public lvec4 ragb => new lvec4(x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.xwyzx swizzling.
        /// </summary>
        public lvec5 xwyzx => new lvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.ragbr swizzling (equivalent to lvec4.xwyzx).
        /// </summary>
        public lvec5 ragbr => new lvec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.xwyzy swizzling.
        /// </summary>
        public lvec5 xwyzy => new lvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.ragbg swizzling (equivalent to lvec4.xwyzy).
        /// </summary>
        public lvec5 ragbg => new lvec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.xwyzz swizzling.
        /// </summary>
        public lvec5 xwyzz => new lvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.ragbb swizzling (equivalent to lvec4.xwyzz).
        /// </summary>
        public lvec5 ragbb => new lvec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.xwyzw swizzling.
        /// </summary>
        public lvec5 xwyzw => new lvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.ragba swizzling (equivalent to lvec4.xwyzw).
        /// </summary>
        public lvec5 ragba => new lvec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.xwyw swizzling.
        /// </summary>
        public lvec4 xwyw => new lvec4(x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.raga swizzling (equivalent to lvec4.xwyw).
        /// </summary>
        public lvec4 raga => new lvec4(x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.xwywx swizzling.
        /// </summary>
        public lvec5 xwywx => new lvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.ragar swizzling (equivalent to lvec4.xwywx).
        /// </summary>
        public lvec5 ragar => new lvec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.xwywy swizzling.
        /// </summary>
        public lvec5 xwywy => new lvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.ragag swizzling (equivalent to lvec4.xwywy).
        /// </summary>
        public lvec5 ragag => new lvec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.xwywz swizzling.
        /// </summary>
        public lvec5 xwywz => new lvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.ragab swizzling (equivalent to lvec4.xwywz).
        /// </summary>
        public lvec5 ragab => new lvec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.xwyww swizzling.
        /// </summary>
        public lvec5 xwyww => new lvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.ragaa swizzling (equivalent to lvec4.xwyww).
        /// </summary>
        public lvec5 ragaa => new lvec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.xwz swizzling.
        /// </summary>
        public lvec3 xwz => new lvec3(x, w, z);
        
        /// <summary>
        /// Returns lvec4.rab swizzling (equivalent to lvec4.xwz).
        /// </summary>
        public lvec3 rab => new lvec3(x, w, z);
        
        /// <summary>
        /// Returns lvec4.xwzx swizzling.
        /// </summary>
        public lvec4 xwzx => new lvec4(x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.rabr swizzling (equivalent to lvec4.xwzx).
        /// </summary>
        public lvec4 rabr => new lvec4(x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.xwzxx swizzling.
        /// </summary>
        public lvec5 xwzxx => new lvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.rabrr swizzling (equivalent to lvec4.xwzxx).
        /// </summary>
        public lvec5 rabrr => new lvec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.xwzxy swizzling.
        /// </summary>
        public lvec5 xwzxy => new lvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.rabrg swizzling (equivalent to lvec4.xwzxy).
        /// </summary>
        public lvec5 rabrg => new lvec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.xwzxz swizzling.
        /// </summary>
        public lvec5 xwzxz => new lvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.rabrb swizzling (equivalent to lvec4.xwzxz).
        /// </summary>
        public lvec5 rabrb => new lvec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.xwzxw swizzling.
        /// </summary>
        public lvec5 xwzxw => new lvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.rabra swizzling (equivalent to lvec4.xwzxw).
        /// </summary>
        public lvec5 rabra => new lvec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.xwzy swizzling.
        /// </summary>
        public lvec4 xwzy => new lvec4(x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.rabg swizzling (equivalent to lvec4.xwzy).
        /// </summary>
        public lvec4 rabg => new lvec4(x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.xwzyx swizzling.
        /// </summary>
        public lvec5 xwzyx => new lvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.rabgr swizzling (equivalent to lvec4.xwzyx).
        /// </summary>
        public lvec5 rabgr => new lvec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.xwzyy swizzling.
        /// </summary>
        public lvec5 xwzyy => new lvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.rabgg swizzling (equivalent to lvec4.xwzyy).
        /// </summary>
        public lvec5 rabgg => new lvec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.xwzyz swizzling.
        /// </summary>
        public lvec5 xwzyz => new lvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.rabgb swizzling (equivalent to lvec4.xwzyz).
        /// </summary>
        public lvec5 rabgb => new lvec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.xwzyw swizzling.
        /// </summary>
        public lvec5 xwzyw => new lvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.rabga swizzling (equivalent to lvec4.xwzyw).
        /// </summary>
        public lvec5 rabga => new lvec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.xwzz swizzling.
        /// </summary>
        public lvec4 xwzz => new lvec4(x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.rabb swizzling (equivalent to lvec4.xwzz).
        /// </summary>
        public lvec4 rabb => new lvec4(x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.xwzzx swizzling.
        /// </summary>
        public lvec5 xwzzx => new lvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.rabbr swizzling (equivalent to lvec4.xwzzx).
        /// </summary>
        public lvec5 rabbr => new lvec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.xwzzy swizzling.
        /// </summary>
        public lvec5 xwzzy => new lvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.rabbg swizzling (equivalent to lvec4.xwzzy).
        /// </summary>
        public lvec5 rabbg => new lvec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.xwzzz swizzling.
        /// </summary>
        public lvec5 xwzzz => new lvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.rabbb swizzling (equivalent to lvec4.xwzzz).
        /// </summary>
        public lvec5 rabbb => new lvec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.xwzzw swizzling.
        /// </summary>
        public lvec5 xwzzw => new lvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.rabba swizzling (equivalent to lvec4.xwzzw).
        /// </summary>
        public lvec5 rabba => new lvec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.xwzw swizzling.
        /// </summary>
        public lvec4 xwzw => new lvec4(x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.raba swizzling (equivalent to lvec4.xwzw).
        /// </summary>
        public lvec4 raba => new lvec4(x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.xwzwx swizzling.
        /// </summary>
        public lvec5 xwzwx => new lvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.rabar swizzling (equivalent to lvec4.xwzwx).
        /// </summary>
        public lvec5 rabar => new lvec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.xwzwy swizzling.
        /// </summary>
        public lvec5 xwzwy => new lvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.rabag swizzling (equivalent to lvec4.xwzwy).
        /// </summary>
        public lvec5 rabag => new lvec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.xwzwz swizzling.
        /// </summary>
        public lvec5 xwzwz => new lvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.rabab swizzling (equivalent to lvec4.xwzwz).
        /// </summary>
        public lvec5 rabab => new lvec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.xwzww swizzling.
        /// </summary>
        public lvec5 xwzww => new lvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.rabaa swizzling (equivalent to lvec4.xwzww).
        /// </summary>
        public lvec5 rabaa => new lvec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.xww swizzling.
        /// </summary>
        public lvec3 xww => new lvec3(x, w, w);
        
        /// <summary>
        /// Returns lvec4.raa swizzling (equivalent to lvec4.xww).
        /// </summary>
        public lvec3 raa => new lvec3(x, w, w);
        
        /// <summary>
        /// Returns lvec4.xwwx swizzling.
        /// </summary>
        public lvec4 xwwx => new lvec4(x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.raar swizzling (equivalent to lvec4.xwwx).
        /// </summary>
        public lvec4 raar => new lvec4(x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.xwwxx swizzling.
        /// </summary>
        public lvec5 xwwxx => new lvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.raarr swizzling (equivalent to lvec4.xwwxx).
        /// </summary>
        public lvec5 raarr => new lvec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.xwwxy swizzling.
        /// </summary>
        public lvec5 xwwxy => new lvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.raarg swizzling (equivalent to lvec4.xwwxy).
        /// </summary>
        public lvec5 raarg => new lvec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.xwwxz swizzling.
        /// </summary>
        public lvec5 xwwxz => new lvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.raarb swizzling (equivalent to lvec4.xwwxz).
        /// </summary>
        public lvec5 raarb => new lvec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.xwwxw swizzling.
        /// </summary>
        public lvec5 xwwxw => new lvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.raara swizzling (equivalent to lvec4.xwwxw).
        /// </summary>
        public lvec5 raara => new lvec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.xwwy swizzling.
        /// </summary>
        public lvec4 xwwy => new lvec4(x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.raag swizzling (equivalent to lvec4.xwwy).
        /// </summary>
        public lvec4 raag => new lvec4(x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.xwwyx swizzling.
        /// </summary>
        public lvec5 xwwyx => new lvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.raagr swizzling (equivalent to lvec4.xwwyx).
        /// </summary>
        public lvec5 raagr => new lvec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.xwwyy swizzling.
        /// </summary>
        public lvec5 xwwyy => new lvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.raagg swizzling (equivalent to lvec4.xwwyy).
        /// </summary>
        public lvec5 raagg => new lvec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.xwwyz swizzling.
        /// </summary>
        public lvec5 xwwyz => new lvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.raagb swizzling (equivalent to lvec4.xwwyz).
        /// </summary>
        public lvec5 raagb => new lvec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.xwwyw swizzling.
        /// </summary>
        public lvec5 xwwyw => new lvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.raaga swizzling (equivalent to lvec4.xwwyw).
        /// </summary>
        public lvec5 raaga => new lvec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.xwwz swizzling.
        /// </summary>
        public lvec4 xwwz => new lvec4(x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.raab swizzling (equivalent to lvec4.xwwz).
        /// </summary>
        public lvec4 raab => new lvec4(x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.xwwzx swizzling.
        /// </summary>
        public lvec5 xwwzx => new lvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.raabr swizzling (equivalent to lvec4.xwwzx).
        /// </summary>
        public lvec5 raabr => new lvec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.xwwzy swizzling.
        /// </summary>
        public lvec5 xwwzy => new lvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.raabg swizzling (equivalent to lvec4.xwwzy).
        /// </summary>
        public lvec5 raabg => new lvec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.xwwzz swizzling.
        /// </summary>
        public lvec5 xwwzz => new lvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.raabb swizzling (equivalent to lvec4.xwwzz).
        /// </summary>
        public lvec5 raabb => new lvec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.xwwzw swizzling.
        /// </summary>
        public lvec5 xwwzw => new lvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.raaba swizzling (equivalent to lvec4.xwwzw).
        /// </summary>
        public lvec5 raaba => new lvec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.xwww swizzling.
        /// </summary>
        public lvec4 xwww => new lvec4(x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.raaa swizzling (equivalent to lvec4.xwww).
        /// </summary>
        public lvec4 raaa => new lvec4(x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.xwwwx swizzling.
        /// </summary>
        public lvec5 xwwwx => new lvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.raaar swizzling (equivalent to lvec4.xwwwx).
        /// </summary>
        public lvec5 raaar => new lvec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.xwwwy swizzling.
        /// </summary>
        public lvec5 xwwwy => new lvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.raaag swizzling (equivalent to lvec4.xwwwy).
        /// </summary>
        public lvec5 raaag => new lvec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.xwwwz swizzling.
        /// </summary>
        public lvec5 xwwwz => new lvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.raaab swizzling (equivalent to lvec4.xwwwz).
        /// </summary>
        public lvec5 raaab => new lvec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.xwwww swizzling.
        /// </summary>
        public lvec5 xwwww => new lvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns lvec4.raaaa swizzling (equivalent to lvec4.xwwww).
        /// </summary>
        public lvec5 raaaa => new lvec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns lvec4.yx swizzling.
        /// </summary>
        public lvec2 yx => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec4.gr swizzling (equivalent to lvec4.yx).
        /// </summary>
        public lvec2 gr => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec4.yxx swizzling.
        /// </summary>
        public lvec3 yxx => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec4.grr swizzling (equivalent to lvec4.yxx).
        /// </summary>
        public lvec3 grr => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec4.yxxx swizzling.
        /// </summary>
        public lvec4 yxxx => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.grrr swizzling (equivalent to lvec4.yxxx).
        /// </summary>
        public lvec4 grrr => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.yxxxx swizzling.
        /// </summary>
        public lvec5 yxxxx => new lvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.grrrr swizzling (equivalent to lvec4.yxxxx).
        /// </summary>
        public lvec5 grrrr => new lvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.yxxxy swizzling.
        /// </summary>
        public lvec5 yxxxy => new lvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.grrrg swizzling (equivalent to lvec4.yxxxy).
        /// </summary>
        public lvec5 grrrg => new lvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.yxxxz swizzling.
        /// </summary>
        public lvec5 yxxxz => new lvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.grrrb swizzling (equivalent to lvec4.yxxxz).
        /// </summary>
        public lvec5 grrrb => new lvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.yxxxw swizzling.
        /// </summary>
        public lvec5 yxxxw => new lvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.grrra swizzling (equivalent to lvec4.yxxxw).
        /// </summary>
        public lvec5 grrra => new lvec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.yxxy swizzling.
        /// </summary>
        public lvec4 yxxy => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.grrg swizzling (equivalent to lvec4.yxxy).
        /// </summary>
        public lvec4 grrg => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.yxxyx swizzling.
        /// </summary>
        public lvec5 yxxyx => new lvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.grrgr swizzling (equivalent to lvec4.yxxyx).
        /// </summary>
        public lvec5 grrgr => new lvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.yxxyy swizzling.
        /// </summary>
        public lvec5 yxxyy => new lvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.grrgg swizzling (equivalent to lvec4.yxxyy).
        /// </summary>
        public lvec5 grrgg => new lvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.yxxyz swizzling.
        /// </summary>
        public lvec5 yxxyz => new lvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.grrgb swizzling (equivalent to lvec4.yxxyz).
        /// </summary>
        public lvec5 grrgb => new lvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.yxxyw swizzling.
        /// </summary>
        public lvec5 yxxyw => new lvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.grrga swizzling (equivalent to lvec4.yxxyw).
        /// </summary>
        public lvec5 grrga => new lvec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.yxxz swizzling.
        /// </summary>
        public lvec4 yxxz => new lvec4(y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.grrb swizzling (equivalent to lvec4.yxxz).
        /// </summary>
        public lvec4 grrb => new lvec4(y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.yxxzx swizzling.
        /// </summary>
        public lvec5 yxxzx => new lvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.grrbr swizzling (equivalent to lvec4.yxxzx).
        /// </summary>
        public lvec5 grrbr => new lvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.yxxzy swizzling.
        /// </summary>
        public lvec5 yxxzy => new lvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.grrbg swizzling (equivalent to lvec4.yxxzy).
        /// </summary>
        public lvec5 grrbg => new lvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.yxxzz swizzling.
        /// </summary>
        public lvec5 yxxzz => new lvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.grrbb swizzling (equivalent to lvec4.yxxzz).
        /// </summary>
        public lvec5 grrbb => new lvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.yxxzw swizzling.
        /// </summary>
        public lvec5 yxxzw => new lvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.grrba swizzling (equivalent to lvec4.yxxzw).
        /// </summary>
        public lvec5 grrba => new lvec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.yxxw swizzling.
        /// </summary>
        public lvec4 yxxw => new lvec4(y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.grra swizzling (equivalent to lvec4.yxxw).
        /// </summary>
        public lvec4 grra => new lvec4(y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.yxxwx swizzling.
        /// </summary>
        public lvec5 yxxwx => new lvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.grrar swizzling (equivalent to lvec4.yxxwx).
        /// </summary>
        public lvec5 grrar => new lvec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.yxxwy swizzling.
        /// </summary>
        public lvec5 yxxwy => new lvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.grrag swizzling (equivalent to lvec4.yxxwy).
        /// </summary>
        public lvec5 grrag => new lvec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.yxxwz swizzling.
        /// </summary>
        public lvec5 yxxwz => new lvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.grrab swizzling (equivalent to lvec4.yxxwz).
        /// </summary>
        public lvec5 grrab => new lvec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.yxxww swizzling.
        /// </summary>
        public lvec5 yxxww => new lvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.grraa swizzling (equivalent to lvec4.yxxww).
        /// </summary>
        public lvec5 grraa => new lvec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.yxy swizzling.
        /// </summary>
        public lvec3 yxy => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec4.grg swizzling (equivalent to lvec4.yxy).
        /// </summary>
        public lvec3 grg => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec4.yxyx swizzling.
        /// </summary>
        public lvec4 yxyx => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.grgr swizzling (equivalent to lvec4.yxyx).
        /// </summary>
        public lvec4 grgr => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.yxyxx swizzling.
        /// </summary>
        public lvec5 yxyxx => new lvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.grgrr swizzling (equivalent to lvec4.yxyxx).
        /// </summary>
        public lvec5 grgrr => new lvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.yxyxy swizzling.
        /// </summary>
        public lvec5 yxyxy => new lvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.grgrg swizzling (equivalent to lvec4.yxyxy).
        /// </summary>
        public lvec5 grgrg => new lvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.yxyxz swizzling.
        /// </summary>
        public lvec5 yxyxz => new lvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.grgrb swizzling (equivalent to lvec4.yxyxz).
        /// </summary>
        public lvec5 grgrb => new lvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.yxyxw swizzling.
        /// </summary>
        public lvec5 yxyxw => new lvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.grgra swizzling (equivalent to lvec4.yxyxw).
        /// </summary>
        public lvec5 grgra => new lvec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.yxyy swizzling.
        /// </summary>
        public lvec4 yxyy => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.grgg swizzling (equivalent to lvec4.yxyy).
        /// </summary>
        public lvec4 grgg => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.yxyyx swizzling.
        /// </summary>
        public lvec5 yxyyx => new lvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.grggr swizzling (equivalent to lvec4.yxyyx).
        /// </summary>
        public lvec5 grggr => new lvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.yxyyy swizzling.
        /// </summary>
        public lvec5 yxyyy => new lvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.grggg swizzling (equivalent to lvec4.yxyyy).
        /// </summary>
        public lvec5 grggg => new lvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.yxyyz swizzling.
        /// </summary>
        public lvec5 yxyyz => new lvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.grggb swizzling (equivalent to lvec4.yxyyz).
        /// </summary>
        public lvec5 grggb => new lvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.yxyyw swizzling.
        /// </summary>
        public lvec5 yxyyw => new lvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.grgga swizzling (equivalent to lvec4.yxyyw).
        /// </summary>
        public lvec5 grgga => new lvec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.yxyz swizzling.
        /// </summary>
        public lvec4 yxyz => new lvec4(y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.grgb swizzling (equivalent to lvec4.yxyz).
        /// </summary>
        public lvec4 grgb => new lvec4(y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.yxyzx swizzling.
        /// </summary>
        public lvec5 yxyzx => new lvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.grgbr swizzling (equivalent to lvec4.yxyzx).
        /// </summary>
        public lvec5 grgbr => new lvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.yxyzy swizzling.
        /// </summary>
        public lvec5 yxyzy => new lvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.grgbg swizzling (equivalent to lvec4.yxyzy).
        /// </summary>
        public lvec5 grgbg => new lvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.yxyzz swizzling.
        /// </summary>
        public lvec5 yxyzz => new lvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.grgbb swizzling (equivalent to lvec4.yxyzz).
        /// </summary>
        public lvec5 grgbb => new lvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.yxyzw swizzling.
        /// </summary>
        public lvec5 yxyzw => new lvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.grgba swizzling (equivalent to lvec4.yxyzw).
        /// </summary>
        public lvec5 grgba => new lvec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.yxyw swizzling.
        /// </summary>
        public lvec4 yxyw => new lvec4(y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.grga swizzling (equivalent to lvec4.yxyw).
        /// </summary>
        public lvec4 grga => new lvec4(y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.yxywx swizzling.
        /// </summary>
        public lvec5 yxywx => new lvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.grgar swizzling (equivalent to lvec4.yxywx).
        /// </summary>
        public lvec5 grgar => new lvec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.yxywy swizzling.
        /// </summary>
        public lvec5 yxywy => new lvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.grgag swizzling (equivalent to lvec4.yxywy).
        /// </summary>
        public lvec5 grgag => new lvec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.yxywz swizzling.
        /// </summary>
        public lvec5 yxywz => new lvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.grgab swizzling (equivalent to lvec4.yxywz).
        /// </summary>
        public lvec5 grgab => new lvec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.yxyww swizzling.
        /// </summary>
        public lvec5 yxyww => new lvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.grgaa swizzling (equivalent to lvec4.yxyww).
        /// </summary>
        public lvec5 grgaa => new lvec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.yxz swizzling.
        /// </summary>
        public lvec3 yxz => new lvec3(y, x, z);
        
        /// <summary>
        /// Returns lvec4.grb swizzling (equivalent to lvec4.yxz).
        /// </summary>
        public lvec3 grb => new lvec3(y, x, z);
        
        /// <summary>
        /// Returns lvec4.yxzx swizzling.
        /// </summary>
        public lvec4 yxzx => new lvec4(y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.grbr swizzling (equivalent to lvec4.yxzx).
        /// </summary>
        public lvec4 grbr => new lvec4(y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.yxzxx swizzling.
        /// </summary>
        public lvec5 yxzxx => new lvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.grbrr swizzling (equivalent to lvec4.yxzxx).
        /// </summary>
        public lvec5 grbrr => new lvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.yxzxy swizzling.
        /// </summary>
        public lvec5 yxzxy => new lvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.grbrg swizzling (equivalent to lvec4.yxzxy).
        /// </summary>
        public lvec5 grbrg => new lvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.yxzxz swizzling.
        /// </summary>
        public lvec5 yxzxz => new lvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.grbrb swizzling (equivalent to lvec4.yxzxz).
        /// </summary>
        public lvec5 grbrb => new lvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.yxzxw swizzling.
        /// </summary>
        public lvec5 yxzxw => new lvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.grbra swizzling (equivalent to lvec4.yxzxw).
        /// </summary>
        public lvec5 grbra => new lvec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.yxzy swizzling.
        /// </summary>
        public lvec4 yxzy => new lvec4(y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.grbg swizzling (equivalent to lvec4.yxzy).
        /// </summary>
        public lvec4 grbg => new lvec4(y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.yxzyx swizzling.
        /// </summary>
        public lvec5 yxzyx => new lvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.grbgr swizzling (equivalent to lvec4.yxzyx).
        /// </summary>
        public lvec5 grbgr => new lvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.yxzyy swizzling.
        /// </summary>
        public lvec5 yxzyy => new lvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.grbgg swizzling (equivalent to lvec4.yxzyy).
        /// </summary>
        public lvec5 grbgg => new lvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.yxzyz swizzling.
        /// </summary>
        public lvec5 yxzyz => new lvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.grbgb swizzling (equivalent to lvec4.yxzyz).
        /// </summary>
        public lvec5 grbgb => new lvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.yxzyw swizzling.
        /// </summary>
        public lvec5 yxzyw => new lvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.grbga swizzling (equivalent to lvec4.yxzyw).
        /// </summary>
        public lvec5 grbga => new lvec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.yxzz swizzling.
        /// </summary>
        public lvec4 yxzz => new lvec4(y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.grbb swizzling (equivalent to lvec4.yxzz).
        /// </summary>
        public lvec4 grbb => new lvec4(y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.yxzzx swizzling.
        /// </summary>
        public lvec5 yxzzx => new lvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.grbbr swizzling (equivalent to lvec4.yxzzx).
        /// </summary>
        public lvec5 grbbr => new lvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.yxzzy swizzling.
        /// </summary>
        public lvec5 yxzzy => new lvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.grbbg swizzling (equivalent to lvec4.yxzzy).
        /// </summary>
        public lvec5 grbbg => new lvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.yxzzz swizzling.
        /// </summary>
        public lvec5 yxzzz => new lvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.grbbb swizzling (equivalent to lvec4.yxzzz).
        /// </summary>
        public lvec5 grbbb => new lvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.yxzzw swizzling.
        /// </summary>
        public lvec5 yxzzw => new lvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.grbba swizzling (equivalent to lvec4.yxzzw).
        /// </summary>
        public lvec5 grbba => new lvec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.yxzw swizzling.
        /// </summary>
        public lvec4 yxzw => new lvec4(y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.grba swizzling (equivalent to lvec4.yxzw).
        /// </summary>
        public lvec4 grba => new lvec4(y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.yxzwx swizzling.
        /// </summary>
        public lvec5 yxzwx => new lvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.grbar swizzling (equivalent to lvec4.yxzwx).
        /// </summary>
        public lvec5 grbar => new lvec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.yxzwy swizzling.
        /// </summary>
        public lvec5 yxzwy => new lvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.grbag swizzling (equivalent to lvec4.yxzwy).
        /// </summary>
        public lvec5 grbag => new lvec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.yxzwz swizzling.
        /// </summary>
        public lvec5 yxzwz => new lvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.grbab swizzling (equivalent to lvec4.yxzwz).
        /// </summary>
        public lvec5 grbab => new lvec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.yxzww swizzling.
        /// </summary>
        public lvec5 yxzww => new lvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.grbaa swizzling (equivalent to lvec4.yxzww).
        /// </summary>
        public lvec5 grbaa => new lvec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.yxw swizzling.
        /// </summary>
        public lvec3 yxw => new lvec3(y, x, w);
        
        /// <summary>
        /// Returns lvec4.gra swizzling (equivalent to lvec4.yxw).
        /// </summary>
        public lvec3 gra => new lvec3(y, x, w);
        
        /// <summary>
        /// Returns lvec4.yxwx swizzling.
        /// </summary>
        public lvec4 yxwx => new lvec4(y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.grar swizzling (equivalent to lvec4.yxwx).
        /// </summary>
        public lvec4 grar => new lvec4(y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.yxwxx swizzling.
        /// </summary>
        public lvec5 yxwxx => new lvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.grarr swizzling (equivalent to lvec4.yxwxx).
        /// </summary>
        public lvec5 grarr => new lvec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.yxwxy swizzling.
        /// </summary>
        public lvec5 yxwxy => new lvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.grarg swizzling (equivalent to lvec4.yxwxy).
        /// </summary>
        public lvec5 grarg => new lvec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.yxwxz swizzling.
        /// </summary>
        public lvec5 yxwxz => new lvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.grarb swizzling (equivalent to lvec4.yxwxz).
        /// </summary>
        public lvec5 grarb => new lvec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.yxwxw swizzling.
        /// </summary>
        public lvec5 yxwxw => new lvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.grara swizzling (equivalent to lvec4.yxwxw).
        /// </summary>
        public lvec5 grara => new lvec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.yxwy swizzling.
        /// </summary>
        public lvec4 yxwy => new lvec4(y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.grag swizzling (equivalent to lvec4.yxwy).
        /// </summary>
        public lvec4 grag => new lvec4(y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.yxwyx swizzling.
        /// </summary>
        public lvec5 yxwyx => new lvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.gragr swizzling (equivalent to lvec4.yxwyx).
        /// </summary>
        public lvec5 gragr => new lvec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.yxwyy swizzling.
        /// </summary>
        public lvec5 yxwyy => new lvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.gragg swizzling (equivalent to lvec4.yxwyy).
        /// </summary>
        public lvec5 gragg => new lvec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.yxwyz swizzling.
        /// </summary>
        public lvec5 yxwyz => new lvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.gragb swizzling (equivalent to lvec4.yxwyz).
        /// </summary>
        public lvec5 gragb => new lvec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.yxwyw swizzling.
        /// </summary>
        public lvec5 yxwyw => new lvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.graga swizzling (equivalent to lvec4.yxwyw).
        /// </summary>
        public lvec5 graga => new lvec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.yxwz swizzling.
        /// </summary>
        public lvec4 yxwz => new lvec4(y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.grab swizzling (equivalent to lvec4.yxwz).
        /// </summary>
        public lvec4 grab => new lvec4(y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.yxwzx swizzling.
        /// </summary>
        public lvec5 yxwzx => new lvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.grabr swizzling (equivalent to lvec4.yxwzx).
        /// </summary>
        public lvec5 grabr => new lvec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.yxwzy swizzling.
        /// </summary>
        public lvec5 yxwzy => new lvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.grabg swizzling (equivalent to lvec4.yxwzy).
        /// </summary>
        public lvec5 grabg => new lvec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.yxwzz swizzling.
        /// </summary>
        public lvec5 yxwzz => new lvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.grabb swizzling (equivalent to lvec4.yxwzz).
        /// </summary>
        public lvec5 grabb => new lvec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.yxwzw swizzling.
        /// </summary>
        public lvec5 yxwzw => new lvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.graba swizzling (equivalent to lvec4.yxwzw).
        /// </summary>
        public lvec5 graba => new lvec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.yxww swizzling.
        /// </summary>
        public lvec4 yxww => new lvec4(y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.graa swizzling (equivalent to lvec4.yxww).
        /// </summary>
        public lvec4 graa => new lvec4(y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.yxwwx swizzling.
        /// </summary>
        public lvec5 yxwwx => new lvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.graar swizzling (equivalent to lvec4.yxwwx).
        /// </summary>
        public lvec5 graar => new lvec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.yxwwy swizzling.
        /// </summary>
        public lvec5 yxwwy => new lvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.graag swizzling (equivalent to lvec4.yxwwy).
        /// </summary>
        public lvec5 graag => new lvec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.yxwwz swizzling.
        /// </summary>
        public lvec5 yxwwz => new lvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.graab swizzling (equivalent to lvec4.yxwwz).
        /// </summary>
        public lvec5 graab => new lvec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.yxwww swizzling.
        /// </summary>
        public lvec5 yxwww => new lvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.graaa swizzling (equivalent to lvec4.yxwww).
        /// </summary>
        public lvec5 graaa => new lvec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.yy swizzling.
        /// </summary>
        public lvec2 yy => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec4.gg swizzling (equivalent to lvec4.yy).
        /// </summary>
        public lvec2 gg => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec4.yyx swizzling.
        /// </summary>
        public lvec3 yyx => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec4.ggr swizzling (equivalent to lvec4.yyx).
        /// </summary>
        public lvec3 ggr => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec4.yyxx swizzling.
        /// </summary>
        public lvec4 yyxx => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.ggrr swizzling (equivalent to lvec4.yyxx).
        /// </summary>
        public lvec4 ggrr => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.yyxxx swizzling.
        /// </summary>
        public lvec5 yyxxx => new lvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.ggrrr swizzling (equivalent to lvec4.yyxxx).
        /// </summary>
        public lvec5 ggrrr => new lvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.yyxxy swizzling.
        /// </summary>
        public lvec5 yyxxy => new lvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.ggrrg swizzling (equivalent to lvec4.yyxxy).
        /// </summary>
        public lvec5 ggrrg => new lvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.yyxxz swizzling.
        /// </summary>
        public lvec5 yyxxz => new lvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.ggrrb swizzling (equivalent to lvec4.yyxxz).
        /// </summary>
        public lvec5 ggrrb => new lvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.yyxxw swizzling.
        /// </summary>
        public lvec5 yyxxw => new lvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.ggrra swizzling (equivalent to lvec4.yyxxw).
        /// </summary>
        public lvec5 ggrra => new lvec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.yyxy swizzling.
        /// </summary>
        public lvec4 yyxy => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.ggrg swizzling (equivalent to lvec4.yyxy).
        /// </summary>
        public lvec4 ggrg => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.yyxyx swizzling.
        /// </summary>
        public lvec5 yyxyx => new lvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.ggrgr swizzling (equivalent to lvec4.yyxyx).
        /// </summary>
        public lvec5 ggrgr => new lvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.yyxyy swizzling.
        /// </summary>
        public lvec5 yyxyy => new lvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.ggrgg swizzling (equivalent to lvec4.yyxyy).
        /// </summary>
        public lvec5 ggrgg => new lvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.yyxyz swizzling.
        /// </summary>
        public lvec5 yyxyz => new lvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.ggrgb swizzling (equivalent to lvec4.yyxyz).
        /// </summary>
        public lvec5 ggrgb => new lvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.yyxyw swizzling.
        /// </summary>
        public lvec5 yyxyw => new lvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.ggrga swizzling (equivalent to lvec4.yyxyw).
        /// </summary>
        public lvec5 ggrga => new lvec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.yyxz swizzling.
        /// </summary>
        public lvec4 yyxz => new lvec4(y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.ggrb swizzling (equivalent to lvec4.yyxz).
        /// </summary>
        public lvec4 ggrb => new lvec4(y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.yyxzx swizzling.
        /// </summary>
        public lvec5 yyxzx => new lvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.ggrbr swizzling (equivalent to lvec4.yyxzx).
        /// </summary>
        public lvec5 ggrbr => new lvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.yyxzy swizzling.
        /// </summary>
        public lvec5 yyxzy => new lvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.ggrbg swizzling (equivalent to lvec4.yyxzy).
        /// </summary>
        public lvec5 ggrbg => new lvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.yyxzz swizzling.
        /// </summary>
        public lvec5 yyxzz => new lvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.ggrbb swizzling (equivalent to lvec4.yyxzz).
        /// </summary>
        public lvec5 ggrbb => new lvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.yyxzw swizzling.
        /// </summary>
        public lvec5 yyxzw => new lvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.ggrba swizzling (equivalent to lvec4.yyxzw).
        /// </summary>
        public lvec5 ggrba => new lvec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.yyxw swizzling.
        /// </summary>
        public lvec4 yyxw => new lvec4(y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.ggra swizzling (equivalent to lvec4.yyxw).
        /// </summary>
        public lvec4 ggra => new lvec4(y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.yyxwx swizzling.
        /// </summary>
        public lvec5 yyxwx => new lvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.ggrar swizzling (equivalent to lvec4.yyxwx).
        /// </summary>
        public lvec5 ggrar => new lvec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.yyxwy swizzling.
        /// </summary>
        public lvec5 yyxwy => new lvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.ggrag swizzling (equivalent to lvec4.yyxwy).
        /// </summary>
        public lvec5 ggrag => new lvec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.yyxwz swizzling.
        /// </summary>
        public lvec5 yyxwz => new lvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.ggrab swizzling (equivalent to lvec4.yyxwz).
        /// </summary>
        public lvec5 ggrab => new lvec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.yyxww swizzling.
        /// </summary>
        public lvec5 yyxww => new lvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.ggraa swizzling (equivalent to lvec4.yyxww).
        /// </summary>
        public lvec5 ggraa => new lvec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.yyy swizzling.
        /// </summary>
        public lvec3 yyy => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec4.ggg swizzling (equivalent to lvec4.yyy).
        /// </summary>
        public lvec3 ggg => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec4.yyyx swizzling.
        /// </summary>
        public lvec4 yyyx => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.gggr swizzling (equivalent to lvec4.yyyx).
        /// </summary>
        public lvec4 gggr => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.yyyxx swizzling.
        /// </summary>
        public lvec5 yyyxx => new lvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.gggrr swizzling (equivalent to lvec4.yyyxx).
        /// </summary>
        public lvec5 gggrr => new lvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.yyyxy swizzling.
        /// </summary>
        public lvec5 yyyxy => new lvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.gggrg swizzling (equivalent to lvec4.yyyxy).
        /// </summary>
        public lvec5 gggrg => new lvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.yyyxz swizzling.
        /// </summary>
        public lvec5 yyyxz => new lvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.gggrb swizzling (equivalent to lvec4.yyyxz).
        /// </summary>
        public lvec5 gggrb => new lvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.yyyxw swizzling.
        /// </summary>
        public lvec5 yyyxw => new lvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.gggra swizzling (equivalent to lvec4.yyyxw).
        /// </summary>
        public lvec5 gggra => new lvec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.yyyy swizzling.
        /// </summary>
        public lvec4 yyyy => new lvec4(y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.gggg swizzling (equivalent to lvec4.yyyy).
        /// </summary>
        public lvec4 gggg => new lvec4(y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.yyyyx swizzling.
        /// </summary>
        public lvec5 yyyyx => new lvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.ggggr swizzling (equivalent to lvec4.yyyyx).
        /// </summary>
        public lvec5 ggggr => new lvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.yyyyy swizzling.
        /// </summary>
        public lvec5 yyyyy => new lvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.ggggg swizzling (equivalent to lvec4.yyyyy).
        /// </summary>
        public lvec5 ggggg => new lvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.yyyyz swizzling.
        /// </summary>
        public lvec5 yyyyz => new lvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.ggggb swizzling (equivalent to lvec4.yyyyz).
        /// </summary>
        public lvec5 ggggb => new lvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.yyyyw swizzling.
        /// </summary>
        public lvec5 yyyyw => new lvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.gggga swizzling (equivalent to lvec4.yyyyw).
        /// </summary>
        public lvec5 gggga => new lvec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.yyyz swizzling.
        /// </summary>
        public lvec4 yyyz => new lvec4(y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.gggb swizzling (equivalent to lvec4.yyyz).
        /// </summary>
        public lvec4 gggb => new lvec4(y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.yyyzx swizzling.
        /// </summary>
        public lvec5 yyyzx => new lvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.gggbr swizzling (equivalent to lvec4.yyyzx).
        /// </summary>
        public lvec5 gggbr => new lvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.yyyzy swizzling.
        /// </summary>
        public lvec5 yyyzy => new lvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.gggbg swizzling (equivalent to lvec4.yyyzy).
        /// </summary>
        public lvec5 gggbg => new lvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.yyyzz swizzling.
        /// </summary>
        public lvec5 yyyzz => new lvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.gggbb swizzling (equivalent to lvec4.yyyzz).
        /// </summary>
        public lvec5 gggbb => new lvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.yyyzw swizzling.
        /// </summary>
        public lvec5 yyyzw => new lvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.gggba swizzling (equivalent to lvec4.yyyzw).
        /// </summary>
        public lvec5 gggba => new lvec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.yyyw swizzling.
        /// </summary>
        public lvec4 yyyw => new lvec4(y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.ggga swizzling (equivalent to lvec4.yyyw).
        /// </summary>
        public lvec4 ggga => new lvec4(y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.yyywx swizzling.
        /// </summary>
        public lvec5 yyywx => new lvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.gggar swizzling (equivalent to lvec4.yyywx).
        /// </summary>
        public lvec5 gggar => new lvec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.yyywy swizzling.
        /// </summary>
        public lvec5 yyywy => new lvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.gggag swizzling (equivalent to lvec4.yyywy).
        /// </summary>
        public lvec5 gggag => new lvec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.yyywz swizzling.
        /// </summary>
        public lvec5 yyywz => new lvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.gggab swizzling (equivalent to lvec4.yyywz).
        /// </summary>
        public lvec5 gggab => new lvec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.yyyww swizzling.
        /// </summary>
        public lvec5 yyyww => new lvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.gggaa swizzling (equivalent to lvec4.yyyww).
        /// </summary>
        public lvec5 gggaa => new lvec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.yyz swizzling.
        /// </summary>
        public lvec3 yyz => new lvec3(y, y, z);
        
        /// <summary>
        /// Returns lvec4.ggb swizzling (equivalent to lvec4.yyz).
        /// </summary>
        public lvec3 ggb => new lvec3(y, y, z);
        
        /// <summary>
        /// Returns lvec4.yyzx swizzling.
        /// </summary>
        public lvec4 yyzx => new lvec4(y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.ggbr swizzling (equivalent to lvec4.yyzx).
        /// </summary>
        public lvec4 ggbr => new lvec4(y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.yyzxx swizzling.
        /// </summary>
        public lvec5 yyzxx => new lvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.ggbrr swizzling (equivalent to lvec4.yyzxx).
        /// </summary>
        public lvec5 ggbrr => new lvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.yyzxy swizzling.
        /// </summary>
        public lvec5 yyzxy => new lvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.ggbrg swizzling (equivalent to lvec4.yyzxy).
        /// </summary>
        public lvec5 ggbrg => new lvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.yyzxz swizzling.
        /// </summary>
        public lvec5 yyzxz => new lvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.ggbrb swizzling (equivalent to lvec4.yyzxz).
        /// </summary>
        public lvec5 ggbrb => new lvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.yyzxw swizzling.
        /// </summary>
        public lvec5 yyzxw => new lvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.ggbra swizzling (equivalent to lvec4.yyzxw).
        /// </summary>
        public lvec5 ggbra => new lvec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.yyzy swizzling.
        /// </summary>
        public lvec4 yyzy => new lvec4(y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.ggbg swizzling (equivalent to lvec4.yyzy).
        /// </summary>
        public lvec4 ggbg => new lvec4(y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.yyzyx swizzling.
        /// </summary>
        public lvec5 yyzyx => new lvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.ggbgr swizzling (equivalent to lvec4.yyzyx).
        /// </summary>
        public lvec5 ggbgr => new lvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.yyzyy swizzling.
        /// </summary>
        public lvec5 yyzyy => new lvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.ggbgg swizzling (equivalent to lvec4.yyzyy).
        /// </summary>
        public lvec5 ggbgg => new lvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.yyzyz swizzling.
        /// </summary>
        public lvec5 yyzyz => new lvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.ggbgb swizzling (equivalent to lvec4.yyzyz).
        /// </summary>
        public lvec5 ggbgb => new lvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.yyzyw swizzling.
        /// </summary>
        public lvec5 yyzyw => new lvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.ggbga swizzling (equivalent to lvec4.yyzyw).
        /// </summary>
        public lvec5 ggbga => new lvec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.yyzz swizzling.
        /// </summary>
        public lvec4 yyzz => new lvec4(y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.ggbb swizzling (equivalent to lvec4.yyzz).
        /// </summary>
        public lvec4 ggbb => new lvec4(y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.yyzzx swizzling.
        /// </summary>
        public lvec5 yyzzx => new lvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.ggbbr swizzling (equivalent to lvec4.yyzzx).
        /// </summary>
        public lvec5 ggbbr => new lvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.yyzzy swizzling.
        /// </summary>
        public lvec5 yyzzy => new lvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.ggbbg swizzling (equivalent to lvec4.yyzzy).
        /// </summary>
        public lvec5 ggbbg => new lvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.yyzzz swizzling.
        /// </summary>
        public lvec5 yyzzz => new lvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.ggbbb swizzling (equivalent to lvec4.yyzzz).
        /// </summary>
        public lvec5 ggbbb => new lvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.yyzzw swizzling.
        /// </summary>
        public lvec5 yyzzw => new lvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.ggbba swizzling (equivalent to lvec4.yyzzw).
        /// </summary>
        public lvec5 ggbba => new lvec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.yyzw swizzling.
        /// </summary>
        public lvec4 yyzw => new lvec4(y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.ggba swizzling (equivalent to lvec4.yyzw).
        /// </summary>
        public lvec4 ggba => new lvec4(y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.yyzwx swizzling.
        /// </summary>
        public lvec5 yyzwx => new lvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.ggbar swizzling (equivalent to lvec4.yyzwx).
        /// </summary>
        public lvec5 ggbar => new lvec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.yyzwy swizzling.
        /// </summary>
        public lvec5 yyzwy => new lvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.ggbag swizzling (equivalent to lvec4.yyzwy).
        /// </summary>
        public lvec5 ggbag => new lvec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.yyzwz swizzling.
        /// </summary>
        public lvec5 yyzwz => new lvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.ggbab swizzling (equivalent to lvec4.yyzwz).
        /// </summary>
        public lvec5 ggbab => new lvec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.yyzww swizzling.
        /// </summary>
        public lvec5 yyzww => new lvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.ggbaa swizzling (equivalent to lvec4.yyzww).
        /// </summary>
        public lvec5 ggbaa => new lvec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.yyw swizzling.
        /// </summary>
        public lvec3 yyw => new lvec3(y, y, w);
        
        /// <summary>
        /// Returns lvec4.gga swizzling (equivalent to lvec4.yyw).
        /// </summary>
        public lvec3 gga => new lvec3(y, y, w);
        
        /// <summary>
        /// Returns lvec4.yywx swizzling.
        /// </summary>
        public lvec4 yywx => new lvec4(y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.ggar swizzling (equivalent to lvec4.yywx).
        /// </summary>
        public lvec4 ggar => new lvec4(y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.yywxx swizzling.
        /// </summary>
        public lvec5 yywxx => new lvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.ggarr swizzling (equivalent to lvec4.yywxx).
        /// </summary>
        public lvec5 ggarr => new lvec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.yywxy swizzling.
        /// </summary>
        public lvec5 yywxy => new lvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.ggarg swizzling (equivalent to lvec4.yywxy).
        /// </summary>
        public lvec5 ggarg => new lvec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.yywxz swizzling.
        /// </summary>
        public lvec5 yywxz => new lvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.ggarb swizzling (equivalent to lvec4.yywxz).
        /// </summary>
        public lvec5 ggarb => new lvec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.yywxw swizzling.
        /// </summary>
        public lvec5 yywxw => new lvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.ggara swizzling (equivalent to lvec4.yywxw).
        /// </summary>
        public lvec5 ggara => new lvec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.yywy swizzling.
        /// </summary>
        public lvec4 yywy => new lvec4(y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.ggag swizzling (equivalent to lvec4.yywy).
        /// </summary>
        public lvec4 ggag => new lvec4(y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.yywyx swizzling.
        /// </summary>
        public lvec5 yywyx => new lvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.ggagr swizzling (equivalent to lvec4.yywyx).
        /// </summary>
        public lvec5 ggagr => new lvec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.yywyy swizzling.
        /// </summary>
        public lvec5 yywyy => new lvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.ggagg swizzling (equivalent to lvec4.yywyy).
        /// </summary>
        public lvec5 ggagg => new lvec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.yywyz swizzling.
        /// </summary>
        public lvec5 yywyz => new lvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.ggagb swizzling (equivalent to lvec4.yywyz).
        /// </summary>
        public lvec5 ggagb => new lvec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.yywyw swizzling.
        /// </summary>
        public lvec5 yywyw => new lvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.ggaga swizzling (equivalent to lvec4.yywyw).
        /// </summary>
        public lvec5 ggaga => new lvec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.yywz swizzling.
        /// </summary>
        public lvec4 yywz => new lvec4(y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.ggab swizzling (equivalent to lvec4.yywz).
        /// </summary>
        public lvec4 ggab => new lvec4(y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.yywzx swizzling.
        /// </summary>
        public lvec5 yywzx => new lvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.ggabr swizzling (equivalent to lvec4.yywzx).
        /// </summary>
        public lvec5 ggabr => new lvec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.yywzy swizzling.
        /// </summary>
        public lvec5 yywzy => new lvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.ggabg swizzling (equivalent to lvec4.yywzy).
        /// </summary>
        public lvec5 ggabg => new lvec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.yywzz swizzling.
        /// </summary>
        public lvec5 yywzz => new lvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.ggabb swizzling (equivalent to lvec4.yywzz).
        /// </summary>
        public lvec5 ggabb => new lvec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.yywzw swizzling.
        /// </summary>
        public lvec5 yywzw => new lvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.ggaba swizzling (equivalent to lvec4.yywzw).
        /// </summary>
        public lvec5 ggaba => new lvec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.yyww swizzling.
        /// </summary>
        public lvec4 yyww => new lvec4(y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.ggaa swizzling (equivalent to lvec4.yyww).
        /// </summary>
        public lvec4 ggaa => new lvec4(y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.yywwx swizzling.
        /// </summary>
        public lvec5 yywwx => new lvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.ggaar swizzling (equivalent to lvec4.yywwx).
        /// </summary>
        public lvec5 ggaar => new lvec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.yywwy swizzling.
        /// </summary>
        public lvec5 yywwy => new lvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.ggaag swizzling (equivalent to lvec4.yywwy).
        /// </summary>
        public lvec5 ggaag => new lvec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.yywwz swizzling.
        /// </summary>
        public lvec5 yywwz => new lvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.ggaab swizzling (equivalent to lvec4.yywwz).
        /// </summary>
        public lvec5 ggaab => new lvec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.yywww swizzling.
        /// </summary>
        public lvec5 yywww => new lvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.ggaaa swizzling (equivalent to lvec4.yywww).
        /// </summary>
        public lvec5 ggaaa => new lvec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.yz swizzling.
        /// </summary>
        public lvec2 yz => new lvec2(y, z);
        
        /// <summary>
        /// Returns lvec4.gb swizzling (equivalent to lvec4.yz).
        /// </summary>
        public lvec2 gb => new lvec2(y, z);
        
        /// <summary>
        /// Returns lvec4.yzx swizzling.
        /// </summary>
        public lvec3 yzx => new lvec3(y, z, x);
        
        /// <summary>
        /// Returns lvec4.gbr swizzling (equivalent to lvec4.yzx).
        /// </summary>
        public lvec3 gbr => new lvec3(y, z, x);
        
        /// <summary>
        /// Returns lvec4.yzxx swizzling.
        /// </summary>
        public lvec4 yzxx => new lvec4(y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.gbrr swizzling (equivalent to lvec4.yzxx).
        /// </summary>
        public lvec4 gbrr => new lvec4(y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.yzxxx swizzling.
        /// </summary>
        public lvec5 yzxxx => new lvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.gbrrr swizzling (equivalent to lvec4.yzxxx).
        /// </summary>
        public lvec5 gbrrr => new lvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.yzxxy swizzling.
        /// </summary>
        public lvec5 yzxxy => new lvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.gbrrg swizzling (equivalent to lvec4.yzxxy).
        /// </summary>
        public lvec5 gbrrg => new lvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.yzxxz swizzling.
        /// </summary>
        public lvec5 yzxxz => new lvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.gbrrb swizzling (equivalent to lvec4.yzxxz).
        /// </summary>
        public lvec5 gbrrb => new lvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.yzxxw swizzling.
        /// </summary>
        public lvec5 yzxxw => new lvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.gbrra swizzling (equivalent to lvec4.yzxxw).
        /// </summary>
        public lvec5 gbrra => new lvec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.yzxy swizzling.
        /// </summary>
        public lvec4 yzxy => new lvec4(y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.gbrg swizzling (equivalent to lvec4.yzxy).
        /// </summary>
        public lvec4 gbrg => new lvec4(y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.yzxyx swizzling.
        /// </summary>
        public lvec5 yzxyx => new lvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.gbrgr swizzling (equivalent to lvec4.yzxyx).
        /// </summary>
        public lvec5 gbrgr => new lvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.yzxyy swizzling.
        /// </summary>
        public lvec5 yzxyy => new lvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.gbrgg swizzling (equivalent to lvec4.yzxyy).
        /// </summary>
        public lvec5 gbrgg => new lvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.yzxyz swizzling.
        /// </summary>
        public lvec5 yzxyz => new lvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.gbrgb swizzling (equivalent to lvec4.yzxyz).
        /// </summary>
        public lvec5 gbrgb => new lvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.yzxyw swizzling.
        /// </summary>
        public lvec5 yzxyw => new lvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.gbrga swizzling (equivalent to lvec4.yzxyw).
        /// </summary>
        public lvec5 gbrga => new lvec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.yzxz swizzling.
        /// </summary>
        public lvec4 yzxz => new lvec4(y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.gbrb swizzling (equivalent to lvec4.yzxz).
        /// </summary>
        public lvec4 gbrb => new lvec4(y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.yzxzx swizzling.
        /// </summary>
        public lvec5 yzxzx => new lvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.gbrbr swizzling (equivalent to lvec4.yzxzx).
        /// </summary>
        public lvec5 gbrbr => new lvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.yzxzy swizzling.
        /// </summary>
        public lvec5 yzxzy => new lvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.gbrbg swizzling (equivalent to lvec4.yzxzy).
        /// </summary>
        public lvec5 gbrbg => new lvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.yzxzz swizzling.
        /// </summary>
        public lvec5 yzxzz => new lvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.gbrbb swizzling (equivalent to lvec4.yzxzz).
        /// </summary>
        public lvec5 gbrbb => new lvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.yzxzw swizzling.
        /// </summary>
        public lvec5 yzxzw => new lvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.gbrba swizzling (equivalent to lvec4.yzxzw).
        /// </summary>
        public lvec5 gbrba => new lvec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.yzxw swizzling.
        /// </summary>
        public lvec4 yzxw => new lvec4(y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.gbra swizzling (equivalent to lvec4.yzxw).
        /// </summary>
        public lvec4 gbra => new lvec4(y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.yzxwx swizzling.
        /// </summary>
        public lvec5 yzxwx => new lvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.gbrar swizzling (equivalent to lvec4.yzxwx).
        /// </summary>
        public lvec5 gbrar => new lvec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.yzxwy swizzling.
        /// </summary>
        public lvec5 yzxwy => new lvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.gbrag swizzling (equivalent to lvec4.yzxwy).
        /// </summary>
        public lvec5 gbrag => new lvec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.yzxwz swizzling.
        /// </summary>
        public lvec5 yzxwz => new lvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.gbrab swizzling (equivalent to lvec4.yzxwz).
        /// </summary>
        public lvec5 gbrab => new lvec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.yzxww swizzling.
        /// </summary>
        public lvec5 yzxww => new lvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.gbraa swizzling (equivalent to lvec4.yzxww).
        /// </summary>
        public lvec5 gbraa => new lvec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.yzy swizzling.
        /// </summary>
        public lvec3 yzy => new lvec3(y, z, y);
        
        /// <summary>
        /// Returns lvec4.gbg swizzling (equivalent to lvec4.yzy).
        /// </summary>
        public lvec3 gbg => new lvec3(y, z, y);
        
        /// <summary>
        /// Returns lvec4.yzyx swizzling.
        /// </summary>
        public lvec4 yzyx => new lvec4(y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.gbgr swizzling (equivalent to lvec4.yzyx).
        /// </summary>
        public lvec4 gbgr => new lvec4(y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.yzyxx swizzling.
        /// </summary>
        public lvec5 yzyxx => new lvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.gbgrr swizzling (equivalent to lvec4.yzyxx).
        /// </summary>
        public lvec5 gbgrr => new lvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.yzyxy swizzling.
        /// </summary>
        public lvec5 yzyxy => new lvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.gbgrg swizzling (equivalent to lvec4.yzyxy).
        /// </summary>
        public lvec5 gbgrg => new lvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.yzyxz swizzling.
        /// </summary>
        public lvec5 yzyxz => new lvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.gbgrb swizzling (equivalent to lvec4.yzyxz).
        /// </summary>
        public lvec5 gbgrb => new lvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.yzyxw swizzling.
        /// </summary>
        public lvec5 yzyxw => new lvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.gbgra swizzling (equivalent to lvec4.yzyxw).
        /// </summary>
        public lvec5 gbgra => new lvec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.yzyy swizzling.
        /// </summary>
        public lvec4 yzyy => new lvec4(y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.gbgg swizzling (equivalent to lvec4.yzyy).
        /// </summary>
        public lvec4 gbgg => new lvec4(y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.yzyyx swizzling.
        /// </summary>
        public lvec5 yzyyx => new lvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.gbggr swizzling (equivalent to lvec4.yzyyx).
        /// </summary>
        public lvec5 gbggr => new lvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.yzyyy swizzling.
        /// </summary>
        public lvec5 yzyyy => new lvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.gbggg swizzling (equivalent to lvec4.yzyyy).
        /// </summary>
        public lvec5 gbggg => new lvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.yzyyz swizzling.
        /// </summary>
        public lvec5 yzyyz => new lvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.gbggb swizzling (equivalent to lvec4.yzyyz).
        /// </summary>
        public lvec5 gbggb => new lvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.yzyyw swizzling.
        /// </summary>
        public lvec5 yzyyw => new lvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.gbgga swizzling (equivalent to lvec4.yzyyw).
        /// </summary>
        public lvec5 gbgga => new lvec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.yzyz swizzling.
        /// </summary>
        public lvec4 yzyz => new lvec4(y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.gbgb swizzling (equivalent to lvec4.yzyz).
        /// </summary>
        public lvec4 gbgb => new lvec4(y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.yzyzx swizzling.
        /// </summary>
        public lvec5 yzyzx => new lvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.gbgbr swizzling (equivalent to lvec4.yzyzx).
        /// </summary>
        public lvec5 gbgbr => new lvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.yzyzy swizzling.
        /// </summary>
        public lvec5 yzyzy => new lvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.gbgbg swizzling (equivalent to lvec4.yzyzy).
        /// </summary>
        public lvec5 gbgbg => new lvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.yzyzz swizzling.
        /// </summary>
        public lvec5 yzyzz => new lvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.gbgbb swizzling (equivalent to lvec4.yzyzz).
        /// </summary>
        public lvec5 gbgbb => new lvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.yzyzw swizzling.
        /// </summary>
        public lvec5 yzyzw => new lvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.gbgba swizzling (equivalent to lvec4.yzyzw).
        /// </summary>
        public lvec5 gbgba => new lvec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.yzyw swizzling.
        /// </summary>
        public lvec4 yzyw => new lvec4(y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.gbga swizzling (equivalent to lvec4.yzyw).
        /// </summary>
        public lvec4 gbga => new lvec4(y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.yzywx swizzling.
        /// </summary>
        public lvec5 yzywx => new lvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.gbgar swizzling (equivalent to lvec4.yzywx).
        /// </summary>
        public lvec5 gbgar => new lvec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.yzywy swizzling.
        /// </summary>
        public lvec5 yzywy => new lvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.gbgag swizzling (equivalent to lvec4.yzywy).
        /// </summary>
        public lvec5 gbgag => new lvec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.yzywz swizzling.
        /// </summary>
        public lvec5 yzywz => new lvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.gbgab swizzling (equivalent to lvec4.yzywz).
        /// </summary>
        public lvec5 gbgab => new lvec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.yzyww swizzling.
        /// </summary>
        public lvec5 yzyww => new lvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.gbgaa swizzling (equivalent to lvec4.yzyww).
        /// </summary>
        public lvec5 gbgaa => new lvec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.yzz swizzling.
        /// </summary>
        public lvec3 yzz => new lvec3(y, z, z);
        
        /// <summary>
        /// Returns lvec4.gbb swizzling (equivalent to lvec4.yzz).
        /// </summary>
        public lvec3 gbb => new lvec3(y, z, z);
        
        /// <summary>
        /// Returns lvec4.yzzx swizzling.
        /// </summary>
        public lvec4 yzzx => new lvec4(y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.gbbr swizzling (equivalent to lvec4.yzzx).
        /// </summary>
        public lvec4 gbbr => new lvec4(y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.yzzxx swizzling.
        /// </summary>
        public lvec5 yzzxx => new lvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.gbbrr swizzling (equivalent to lvec4.yzzxx).
        /// </summary>
        public lvec5 gbbrr => new lvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.yzzxy swizzling.
        /// </summary>
        public lvec5 yzzxy => new lvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.gbbrg swizzling (equivalent to lvec4.yzzxy).
        /// </summary>
        public lvec5 gbbrg => new lvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.yzzxz swizzling.
        /// </summary>
        public lvec5 yzzxz => new lvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.gbbrb swizzling (equivalent to lvec4.yzzxz).
        /// </summary>
        public lvec5 gbbrb => new lvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.yzzxw swizzling.
        /// </summary>
        public lvec5 yzzxw => new lvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.gbbra swizzling (equivalent to lvec4.yzzxw).
        /// </summary>
        public lvec5 gbbra => new lvec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.yzzy swizzling.
        /// </summary>
        public lvec4 yzzy => new lvec4(y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.gbbg swizzling (equivalent to lvec4.yzzy).
        /// </summary>
        public lvec4 gbbg => new lvec4(y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.yzzyx swizzling.
        /// </summary>
        public lvec5 yzzyx => new lvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.gbbgr swizzling (equivalent to lvec4.yzzyx).
        /// </summary>
        public lvec5 gbbgr => new lvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.yzzyy swizzling.
        /// </summary>
        public lvec5 yzzyy => new lvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.gbbgg swizzling (equivalent to lvec4.yzzyy).
        /// </summary>
        public lvec5 gbbgg => new lvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.yzzyz swizzling.
        /// </summary>
        public lvec5 yzzyz => new lvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.gbbgb swizzling (equivalent to lvec4.yzzyz).
        /// </summary>
        public lvec5 gbbgb => new lvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.yzzyw swizzling.
        /// </summary>
        public lvec5 yzzyw => new lvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.gbbga swizzling (equivalent to lvec4.yzzyw).
        /// </summary>
        public lvec5 gbbga => new lvec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.yzzz swizzling.
        /// </summary>
        public lvec4 yzzz => new lvec4(y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.gbbb swizzling (equivalent to lvec4.yzzz).
        /// </summary>
        public lvec4 gbbb => new lvec4(y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.yzzzx swizzling.
        /// </summary>
        public lvec5 yzzzx => new lvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.gbbbr swizzling (equivalent to lvec4.yzzzx).
        /// </summary>
        public lvec5 gbbbr => new lvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.yzzzy swizzling.
        /// </summary>
        public lvec5 yzzzy => new lvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.gbbbg swizzling (equivalent to lvec4.yzzzy).
        /// </summary>
        public lvec5 gbbbg => new lvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.yzzzz swizzling.
        /// </summary>
        public lvec5 yzzzz => new lvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.gbbbb swizzling (equivalent to lvec4.yzzzz).
        /// </summary>
        public lvec5 gbbbb => new lvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.yzzzw swizzling.
        /// </summary>
        public lvec5 yzzzw => new lvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.gbbba swizzling (equivalent to lvec4.yzzzw).
        /// </summary>
        public lvec5 gbbba => new lvec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.yzzw swizzling.
        /// </summary>
        public lvec4 yzzw => new lvec4(y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.gbba swizzling (equivalent to lvec4.yzzw).
        /// </summary>
        public lvec4 gbba => new lvec4(y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.yzzwx swizzling.
        /// </summary>
        public lvec5 yzzwx => new lvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.gbbar swizzling (equivalent to lvec4.yzzwx).
        /// </summary>
        public lvec5 gbbar => new lvec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.yzzwy swizzling.
        /// </summary>
        public lvec5 yzzwy => new lvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.gbbag swizzling (equivalent to lvec4.yzzwy).
        /// </summary>
        public lvec5 gbbag => new lvec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.yzzwz swizzling.
        /// </summary>
        public lvec5 yzzwz => new lvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.gbbab swizzling (equivalent to lvec4.yzzwz).
        /// </summary>
        public lvec5 gbbab => new lvec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.yzzww swizzling.
        /// </summary>
        public lvec5 yzzww => new lvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.gbbaa swizzling (equivalent to lvec4.yzzww).
        /// </summary>
        public lvec5 gbbaa => new lvec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.yzw swizzling.
        /// </summary>
        public lvec3 yzw => new lvec3(y, z, w);
        
        /// <summary>
        /// Returns lvec4.gba swizzling (equivalent to lvec4.yzw).
        /// </summary>
        public lvec3 gba => new lvec3(y, z, w);
        
        /// <summary>
        /// Returns lvec4.yzwx swizzling.
        /// </summary>
        public lvec4 yzwx => new lvec4(y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.gbar swizzling (equivalent to lvec4.yzwx).
        /// </summary>
        public lvec4 gbar => new lvec4(y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.yzwxx swizzling.
        /// </summary>
        public lvec5 yzwxx => new lvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.gbarr swizzling (equivalent to lvec4.yzwxx).
        /// </summary>
        public lvec5 gbarr => new lvec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.yzwxy swizzling.
        /// </summary>
        public lvec5 yzwxy => new lvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.gbarg swizzling (equivalent to lvec4.yzwxy).
        /// </summary>
        public lvec5 gbarg => new lvec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.yzwxz swizzling.
        /// </summary>
        public lvec5 yzwxz => new lvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.gbarb swizzling (equivalent to lvec4.yzwxz).
        /// </summary>
        public lvec5 gbarb => new lvec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.yzwxw swizzling.
        /// </summary>
        public lvec5 yzwxw => new lvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.gbara swizzling (equivalent to lvec4.yzwxw).
        /// </summary>
        public lvec5 gbara => new lvec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.yzwy swizzling.
        /// </summary>
        public lvec4 yzwy => new lvec4(y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.gbag swizzling (equivalent to lvec4.yzwy).
        /// </summary>
        public lvec4 gbag => new lvec4(y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.yzwyx swizzling.
        /// </summary>
        public lvec5 yzwyx => new lvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.gbagr swizzling (equivalent to lvec4.yzwyx).
        /// </summary>
        public lvec5 gbagr => new lvec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.yzwyy swizzling.
        /// </summary>
        public lvec5 yzwyy => new lvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.gbagg swizzling (equivalent to lvec4.yzwyy).
        /// </summary>
        public lvec5 gbagg => new lvec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.yzwyz swizzling.
        /// </summary>
        public lvec5 yzwyz => new lvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.gbagb swizzling (equivalent to lvec4.yzwyz).
        /// </summary>
        public lvec5 gbagb => new lvec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.yzwyw swizzling.
        /// </summary>
        public lvec5 yzwyw => new lvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.gbaga swizzling (equivalent to lvec4.yzwyw).
        /// </summary>
        public lvec5 gbaga => new lvec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.yzwz swizzling.
        /// </summary>
        public lvec4 yzwz => new lvec4(y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.gbab swizzling (equivalent to lvec4.yzwz).
        /// </summary>
        public lvec4 gbab => new lvec4(y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.yzwzx swizzling.
        /// </summary>
        public lvec5 yzwzx => new lvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.gbabr swizzling (equivalent to lvec4.yzwzx).
        /// </summary>
        public lvec5 gbabr => new lvec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.yzwzy swizzling.
        /// </summary>
        public lvec5 yzwzy => new lvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.gbabg swizzling (equivalent to lvec4.yzwzy).
        /// </summary>
        public lvec5 gbabg => new lvec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.yzwzz swizzling.
        /// </summary>
        public lvec5 yzwzz => new lvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.gbabb swizzling (equivalent to lvec4.yzwzz).
        /// </summary>
        public lvec5 gbabb => new lvec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.yzwzw swizzling.
        /// </summary>
        public lvec5 yzwzw => new lvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.gbaba swizzling (equivalent to lvec4.yzwzw).
        /// </summary>
        public lvec5 gbaba => new lvec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.yzww swizzling.
        /// </summary>
        public lvec4 yzww => new lvec4(y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.gbaa swizzling (equivalent to lvec4.yzww).
        /// </summary>
        public lvec4 gbaa => new lvec4(y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.yzwwx swizzling.
        /// </summary>
        public lvec5 yzwwx => new lvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.gbaar swizzling (equivalent to lvec4.yzwwx).
        /// </summary>
        public lvec5 gbaar => new lvec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.yzwwy swizzling.
        /// </summary>
        public lvec5 yzwwy => new lvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.gbaag swizzling (equivalent to lvec4.yzwwy).
        /// </summary>
        public lvec5 gbaag => new lvec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.yzwwz swizzling.
        /// </summary>
        public lvec5 yzwwz => new lvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.gbaab swizzling (equivalent to lvec4.yzwwz).
        /// </summary>
        public lvec5 gbaab => new lvec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.yzwww swizzling.
        /// </summary>
        public lvec5 yzwww => new lvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.gbaaa swizzling (equivalent to lvec4.yzwww).
        /// </summary>
        public lvec5 gbaaa => new lvec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.yw swizzling.
        /// </summary>
        public lvec2 yw => new lvec2(y, w);
        
        /// <summary>
        /// Returns lvec4.ga swizzling (equivalent to lvec4.yw).
        /// </summary>
        public lvec2 ga => new lvec2(y, w);
        
        /// <summary>
        /// Returns lvec4.ywx swizzling.
        /// </summary>
        public lvec3 ywx => new lvec3(y, w, x);
        
        /// <summary>
        /// Returns lvec4.gar swizzling (equivalent to lvec4.ywx).
        /// </summary>
        public lvec3 gar => new lvec3(y, w, x);
        
        /// <summary>
        /// Returns lvec4.ywxx swizzling.
        /// </summary>
        public lvec4 ywxx => new lvec4(y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.garr swizzling (equivalent to lvec4.ywxx).
        /// </summary>
        public lvec4 garr => new lvec4(y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.ywxxx swizzling.
        /// </summary>
        public lvec5 ywxxx => new lvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.garrr swizzling (equivalent to lvec4.ywxxx).
        /// </summary>
        public lvec5 garrr => new lvec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.ywxxy swizzling.
        /// </summary>
        public lvec5 ywxxy => new lvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.garrg swizzling (equivalent to lvec4.ywxxy).
        /// </summary>
        public lvec5 garrg => new lvec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.ywxxz swizzling.
        /// </summary>
        public lvec5 ywxxz => new lvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.garrb swizzling (equivalent to lvec4.ywxxz).
        /// </summary>
        public lvec5 garrb => new lvec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.ywxxw swizzling.
        /// </summary>
        public lvec5 ywxxw => new lvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.garra swizzling (equivalent to lvec4.ywxxw).
        /// </summary>
        public lvec5 garra => new lvec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.ywxy swizzling.
        /// </summary>
        public lvec4 ywxy => new lvec4(y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.garg swizzling (equivalent to lvec4.ywxy).
        /// </summary>
        public lvec4 garg => new lvec4(y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.ywxyx swizzling.
        /// </summary>
        public lvec5 ywxyx => new lvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.gargr swizzling (equivalent to lvec4.ywxyx).
        /// </summary>
        public lvec5 gargr => new lvec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.ywxyy swizzling.
        /// </summary>
        public lvec5 ywxyy => new lvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.gargg swizzling (equivalent to lvec4.ywxyy).
        /// </summary>
        public lvec5 gargg => new lvec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.ywxyz swizzling.
        /// </summary>
        public lvec5 ywxyz => new lvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.gargb swizzling (equivalent to lvec4.ywxyz).
        /// </summary>
        public lvec5 gargb => new lvec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.ywxyw swizzling.
        /// </summary>
        public lvec5 ywxyw => new lvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.garga swizzling (equivalent to lvec4.ywxyw).
        /// </summary>
        public lvec5 garga => new lvec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.ywxz swizzling.
        /// </summary>
        public lvec4 ywxz => new lvec4(y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.garb swizzling (equivalent to lvec4.ywxz).
        /// </summary>
        public lvec4 garb => new lvec4(y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.ywxzx swizzling.
        /// </summary>
        public lvec5 ywxzx => new lvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.garbr swizzling (equivalent to lvec4.ywxzx).
        /// </summary>
        public lvec5 garbr => new lvec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.ywxzy swizzling.
        /// </summary>
        public lvec5 ywxzy => new lvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.garbg swizzling (equivalent to lvec4.ywxzy).
        /// </summary>
        public lvec5 garbg => new lvec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.ywxzz swizzling.
        /// </summary>
        public lvec5 ywxzz => new lvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.garbb swizzling (equivalent to lvec4.ywxzz).
        /// </summary>
        public lvec5 garbb => new lvec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.ywxzw swizzling.
        /// </summary>
        public lvec5 ywxzw => new lvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.garba swizzling (equivalent to lvec4.ywxzw).
        /// </summary>
        public lvec5 garba => new lvec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.ywxw swizzling.
        /// </summary>
        public lvec4 ywxw => new lvec4(y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.gara swizzling (equivalent to lvec4.ywxw).
        /// </summary>
        public lvec4 gara => new lvec4(y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.ywxwx swizzling.
        /// </summary>
        public lvec5 ywxwx => new lvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.garar swizzling (equivalent to lvec4.ywxwx).
        /// </summary>
        public lvec5 garar => new lvec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.ywxwy swizzling.
        /// </summary>
        public lvec5 ywxwy => new lvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.garag swizzling (equivalent to lvec4.ywxwy).
        /// </summary>
        public lvec5 garag => new lvec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.ywxwz swizzling.
        /// </summary>
        public lvec5 ywxwz => new lvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.garab swizzling (equivalent to lvec4.ywxwz).
        /// </summary>
        public lvec5 garab => new lvec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.ywxww swizzling.
        /// </summary>
        public lvec5 ywxww => new lvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.garaa swizzling (equivalent to lvec4.ywxww).
        /// </summary>
        public lvec5 garaa => new lvec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.ywy swizzling.
        /// </summary>
        public lvec3 ywy => new lvec3(y, w, y);
        
        /// <summary>
        /// Returns lvec4.gag swizzling (equivalent to lvec4.ywy).
        /// </summary>
        public lvec3 gag => new lvec3(y, w, y);
        
        /// <summary>
        /// Returns lvec4.ywyx swizzling.
        /// </summary>
        public lvec4 ywyx => new lvec4(y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.gagr swizzling (equivalent to lvec4.ywyx).
        /// </summary>
        public lvec4 gagr => new lvec4(y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.ywyxx swizzling.
        /// </summary>
        public lvec5 ywyxx => new lvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.gagrr swizzling (equivalent to lvec4.ywyxx).
        /// </summary>
        public lvec5 gagrr => new lvec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.ywyxy swizzling.
        /// </summary>
        public lvec5 ywyxy => new lvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.gagrg swizzling (equivalent to lvec4.ywyxy).
        /// </summary>
        public lvec5 gagrg => new lvec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.ywyxz swizzling.
        /// </summary>
        public lvec5 ywyxz => new lvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.gagrb swizzling (equivalent to lvec4.ywyxz).
        /// </summary>
        public lvec5 gagrb => new lvec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.ywyxw swizzling.
        /// </summary>
        public lvec5 ywyxw => new lvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.gagra swizzling (equivalent to lvec4.ywyxw).
        /// </summary>
        public lvec5 gagra => new lvec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.ywyy swizzling.
        /// </summary>
        public lvec4 ywyy => new lvec4(y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.gagg swizzling (equivalent to lvec4.ywyy).
        /// </summary>
        public lvec4 gagg => new lvec4(y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.ywyyx swizzling.
        /// </summary>
        public lvec5 ywyyx => new lvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.gaggr swizzling (equivalent to lvec4.ywyyx).
        /// </summary>
        public lvec5 gaggr => new lvec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.ywyyy swizzling.
        /// </summary>
        public lvec5 ywyyy => new lvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.gaggg swizzling (equivalent to lvec4.ywyyy).
        /// </summary>
        public lvec5 gaggg => new lvec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.ywyyz swizzling.
        /// </summary>
        public lvec5 ywyyz => new lvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.gaggb swizzling (equivalent to lvec4.ywyyz).
        /// </summary>
        public lvec5 gaggb => new lvec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.ywyyw swizzling.
        /// </summary>
        public lvec5 ywyyw => new lvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.gagga swizzling (equivalent to lvec4.ywyyw).
        /// </summary>
        public lvec5 gagga => new lvec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.ywyz swizzling.
        /// </summary>
        public lvec4 ywyz => new lvec4(y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.gagb swizzling (equivalent to lvec4.ywyz).
        /// </summary>
        public lvec4 gagb => new lvec4(y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.ywyzx swizzling.
        /// </summary>
        public lvec5 ywyzx => new lvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.gagbr swizzling (equivalent to lvec4.ywyzx).
        /// </summary>
        public lvec5 gagbr => new lvec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.ywyzy swizzling.
        /// </summary>
        public lvec5 ywyzy => new lvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.gagbg swizzling (equivalent to lvec4.ywyzy).
        /// </summary>
        public lvec5 gagbg => new lvec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.ywyzz swizzling.
        /// </summary>
        public lvec5 ywyzz => new lvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.gagbb swizzling (equivalent to lvec4.ywyzz).
        /// </summary>
        public lvec5 gagbb => new lvec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.ywyzw swizzling.
        /// </summary>
        public lvec5 ywyzw => new lvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.gagba swizzling (equivalent to lvec4.ywyzw).
        /// </summary>
        public lvec5 gagba => new lvec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.ywyw swizzling.
        /// </summary>
        public lvec4 ywyw => new lvec4(y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.gaga swizzling (equivalent to lvec4.ywyw).
        /// </summary>
        public lvec4 gaga => new lvec4(y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.ywywx swizzling.
        /// </summary>
        public lvec5 ywywx => new lvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.gagar swizzling (equivalent to lvec4.ywywx).
        /// </summary>
        public lvec5 gagar => new lvec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.ywywy swizzling.
        /// </summary>
        public lvec5 ywywy => new lvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.gagag swizzling (equivalent to lvec4.ywywy).
        /// </summary>
        public lvec5 gagag => new lvec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.ywywz swizzling.
        /// </summary>
        public lvec5 ywywz => new lvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.gagab swizzling (equivalent to lvec4.ywywz).
        /// </summary>
        public lvec5 gagab => new lvec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.ywyww swizzling.
        /// </summary>
        public lvec5 ywyww => new lvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.gagaa swizzling (equivalent to lvec4.ywyww).
        /// </summary>
        public lvec5 gagaa => new lvec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.ywz swizzling.
        /// </summary>
        public lvec3 ywz => new lvec3(y, w, z);
        
        /// <summary>
        /// Returns lvec4.gab swizzling (equivalent to lvec4.ywz).
        /// </summary>
        public lvec3 gab => new lvec3(y, w, z);
        
        /// <summary>
        /// Returns lvec4.ywzx swizzling.
        /// </summary>
        public lvec4 ywzx => new lvec4(y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.gabr swizzling (equivalent to lvec4.ywzx).
        /// </summary>
        public lvec4 gabr => new lvec4(y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.ywzxx swizzling.
        /// </summary>
        public lvec5 ywzxx => new lvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.gabrr swizzling (equivalent to lvec4.ywzxx).
        /// </summary>
        public lvec5 gabrr => new lvec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.ywzxy swizzling.
        /// </summary>
        public lvec5 ywzxy => new lvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.gabrg swizzling (equivalent to lvec4.ywzxy).
        /// </summary>
        public lvec5 gabrg => new lvec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.ywzxz swizzling.
        /// </summary>
        public lvec5 ywzxz => new lvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.gabrb swizzling (equivalent to lvec4.ywzxz).
        /// </summary>
        public lvec5 gabrb => new lvec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.ywzxw swizzling.
        /// </summary>
        public lvec5 ywzxw => new lvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.gabra swizzling (equivalent to lvec4.ywzxw).
        /// </summary>
        public lvec5 gabra => new lvec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.ywzy swizzling.
        /// </summary>
        public lvec4 ywzy => new lvec4(y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.gabg swizzling (equivalent to lvec4.ywzy).
        /// </summary>
        public lvec4 gabg => new lvec4(y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.ywzyx swizzling.
        /// </summary>
        public lvec5 ywzyx => new lvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.gabgr swizzling (equivalent to lvec4.ywzyx).
        /// </summary>
        public lvec5 gabgr => new lvec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.ywzyy swizzling.
        /// </summary>
        public lvec5 ywzyy => new lvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.gabgg swizzling (equivalent to lvec4.ywzyy).
        /// </summary>
        public lvec5 gabgg => new lvec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.ywzyz swizzling.
        /// </summary>
        public lvec5 ywzyz => new lvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.gabgb swizzling (equivalent to lvec4.ywzyz).
        /// </summary>
        public lvec5 gabgb => new lvec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.ywzyw swizzling.
        /// </summary>
        public lvec5 ywzyw => new lvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.gabga swizzling (equivalent to lvec4.ywzyw).
        /// </summary>
        public lvec5 gabga => new lvec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.ywzz swizzling.
        /// </summary>
        public lvec4 ywzz => new lvec4(y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.gabb swizzling (equivalent to lvec4.ywzz).
        /// </summary>
        public lvec4 gabb => new lvec4(y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.ywzzx swizzling.
        /// </summary>
        public lvec5 ywzzx => new lvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.gabbr swizzling (equivalent to lvec4.ywzzx).
        /// </summary>
        public lvec5 gabbr => new lvec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.ywzzy swizzling.
        /// </summary>
        public lvec5 ywzzy => new lvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.gabbg swizzling (equivalent to lvec4.ywzzy).
        /// </summary>
        public lvec5 gabbg => new lvec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.ywzzz swizzling.
        /// </summary>
        public lvec5 ywzzz => new lvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.gabbb swizzling (equivalent to lvec4.ywzzz).
        /// </summary>
        public lvec5 gabbb => new lvec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.ywzzw swizzling.
        /// </summary>
        public lvec5 ywzzw => new lvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.gabba swizzling (equivalent to lvec4.ywzzw).
        /// </summary>
        public lvec5 gabba => new lvec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.ywzw swizzling.
        /// </summary>
        public lvec4 ywzw => new lvec4(y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.gaba swizzling (equivalent to lvec4.ywzw).
        /// </summary>
        public lvec4 gaba => new lvec4(y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.ywzwx swizzling.
        /// </summary>
        public lvec5 ywzwx => new lvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.gabar swizzling (equivalent to lvec4.ywzwx).
        /// </summary>
        public lvec5 gabar => new lvec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.ywzwy swizzling.
        /// </summary>
        public lvec5 ywzwy => new lvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.gabag swizzling (equivalent to lvec4.ywzwy).
        /// </summary>
        public lvec5 gabag => new lvec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.ywzwz swizzling.
        /// </summary>
        public lvec5 ywzwz => new lvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.gabab swizzling (equivalent to lvec4.ywzwz).
        /// </summary>
        public lvec5 gabab => new lvec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.ywzww swizzling.
        /// </summary>
        public lvec5 ywzww => new lvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.gabaa swizzling (equivalent to lvec4.ywzww).
        /// </summary>
        public lvec5 gabaa => new lvec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.yww swizzling.
        /// </summary>
        public lvec3 yww => new lvec3(y, w, w);
        
        /// <summary>
        /// Returns lvec4.gaa swizzling (equivalent to lvec4.yww).
        /// </summary>
        public lvec3 gaa => new lvec3(y, w, w);
        
        /// <summary>
        /// Returns lvec4.ywwx swizzling.
        /// </summary>
        public lvec4 ywwx => new lvec4(y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.gaar swizzling (equivalent to lvec4.ywwx).
        /// </summary>
        public lvec4 gaar => new lvec4(y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.ywwxx swizzling.
        /// </summary>
        public lvec5 ywwxx => new lvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.gaarr swizzling (equivalent to lvec4.ywwxx).
        /// </summary>
        public lvec5 gaarr => new lvec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.ywwxy swizzling.
        /// </summary>
        public lvec5 ywwxy => new lvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.gaarg swizzling (equivalent to lvec4.ywwxy).
        /// </summary>
        public lvec5 gaarg => new lvec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.ywwxz swizzling.
        /// </summary>
        public lvec5 ywwxz => new lvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.gaarb swizzling (equivalent to lvec4.ywwxz).
        /// </summary>
        public lvec5 gaarb => new lvec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.ywwxw swizzling.
        /// </summary>
        public lvec5 ywwxw => new lvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.gaara swizzling (equivalent to lvec4.ywwxw).
        /// </summary>
        public lvec5 gaara => new lvec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.ywwy swizzling.
        /// </summary>
        public lvec4 ywwy => new lvec4(y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.gaag swizzling (equivalent to lvec4.ywwy).
        /// </summary>
        public lvec4 gaag => new lvec4(y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.ywwyx swizzling.
        /// </summary>
        public lvec5 ywwyx => new lvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.gaagr swizzling (equivalent to lvec4.ywwyx).
        /// </summary>
        public lvec5 gaagr => new lvec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.ywwyy swizzling.
        /// </summary>
        public lvec5 ywwyy => new lvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.gaagg swizzling (equivalent to lvec4.ywwyy).
        /// </summary>
        public lvec5 gaagg => new lvec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.ywwyz swizzling.
        /// </summary>
        public lvec5 ywwyz => new lvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.gaagb swizzling (equivalent to lvec4.ywwyz).
        /// </summary>
        public lvec5 gaagb => new lvec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.ywwyw swizzling.
        /// </summary>
        public lvec5 ywwyw => new lvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.gaaga swizzling (equivalent to lvec4.ywwyw).
        /// </summary>
        public lvec5 gaaga => new lvec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.ywwz swizzling.
        /// </summary>
        public lvec4 ywwz => new lvec4(y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.gaab swizzling (equivalent to lvec4.ywwz).
        /// </summary>
        public lvec4 gaab => new lvec4(y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.ywwzx swizzling.
        /// </summary>
        public lvec5 ywwzx => new lvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.gaabr swizzling (equivalent to lvec4.ywwzx).
        /// </summary>
        public lvec5 gaabr => new lvec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.ywwzy swizzling.
        /// </summary>
        public lvec5 ywwzy => new lvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.gaabg swizzling (equivalent to lvec4.ywwzy).
        /// </summary>
        public lvec5 gaabg => new lvec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.ywwzz swizzling.
        /// </summary>
        public lvec5 ywwzz => new lvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.gaabb swizzling (equivalent to lvec4.ywwzz).
        /// </summary>
        public lvec5 gaabb => new lvec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.ywwzw swizzling.
        /// </summary>
        public lvec5 ywwzw => new lvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.gaaba swizzling (equivalent to lvec4.ywwzw).
        /// </summary>
        public lvec5 gaaba => new lvec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.ywww swizzling.
        /// </summary>
        public lvec4 ywww => new lvec4(y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.gaaa swizzling (equivalent to lvec4.ywww).
        /// </summary>
        public lvec4 gaaa => new lvec4(y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.ywwwx swizzling.
        /// </summary>
        public lvec5 ywwwx => new lvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.gaaar swizzling (equivalent to lvec4.ywwwx).
        /// </summary>
        public lvec5 gaaar => new lvec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.ywwwy swizzling.
        /// </summary>
        public lvec5 ywwwy => new lvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.gaaag swizzling (equivalent to lvec4.ywwwy).
        /// </summary>
        public lvec5 gaaag => new lvec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.ywwwz swizzling.
        /// </summary>
        public lvec5 ywwwz => new lvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.gaaab swizzling (equivalent to lvec4.ywwwz).
        /// </summary>
        public lvec5 gaaab => new lvec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.ywwww swizzling.
        /// </summary>
        public lvec5 ywwww => new lvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns lvec4.gaaaa swizzling (equivalent to lvec4.ywwww).
        /// </summary>
        public lvec5 gaaaa => new lvec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns lvec4.zx swizzling.
        /// </summary>
        public lvec2 zx => new lvec2(z, x);
        
        /// <summary>
        /// Returns lvec4.br swizzling (equivalent to lvec4.zx).
        /// </summary>
        public lvec2 br => new lvec2(z, x);
        
        /// <summary>
        /// Returns lvec4.zxx swizzling.
        /// </summary>
        public lvec3 zxx => new lvec3(z, x, x);
        
        /// <summary>
        /// Returns lvec4.brr swizzling (equivalent to lvec4.zxx).
        /// </summary>
        public lvec3 brr => new lvec3(z, x, x);
        
        /// <summary>
        /// Returns lvec4.zxxx swizzling.
        /// </summary>
        public lvec4 zxxx => new lvec4(z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.brrr swizzling (equivalent to lvec4.zxxx).
        /// </summary>
        public lvec4 brrr => new lvec4(z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.zxxxx swizzling.
        /// </summary>
        public lvec5 zxxxx => new lvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.brrrr swizzling (equivalent to lvec4.zxxxx).
        /// </summary>
        public lvec5 brrrr => new lvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.zxxxy swizzling.
        /// </summary>
        public lvec5 zxxxy => new lvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.brrrg swizzling (equivalent to lvec4.zxxxy).
        /// </summary>
        public lvec5 brrrg => new lvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.zxxxz swizzling.
        /// </summary>
        public lvec5 zxxxz => new lvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.brrrb swizzling (equivalent to lvec4.zxxxz).
        /// </summary>
        public lvec5 brrrb => new lvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.zxxxw swizzling.
        /// </summary>
        public lvec5 zxxxw => new lvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.brrra swizzling (equivalent to lvec4.zxxxw).
        /// </summary>
        public lvec5 brrra => new lvec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.zxxy swizzling.
        /// </summary>
        public lvec4 zxxy => new lvec4(z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.brrg swizzling (equivalent to lvec4.zxxy).
        /// </summary>
        public lvec4 brrg => new lvec4(z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.zxxyx swizzling.
        /// </summary>
        public lvec5 zxxyx => new lvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.brrgr swizzling (equivalent to lvec4.zxxyx).
        /// </summary>
        public lvec5 brrgr => new lvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.zxxyy swizzling.
        /// </summary>
        public lvec5 zxxyy => new lvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.brrgg swizzling (equivalent to lvec4.zxxyy).
        /// </summary>
        public lvec5 brrgg => new lvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.zxxyz swizzling.
        /// </summary>
        public lvec5 zxxyz => new lvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.brrgb swizzling (equivalent to lvec4.zxxyz).
        /// </summary>
        public lvec5 brrgb => new lvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.zxxyw swizzling.
        /// </summary>
        public lvec5 zxxyw => new lvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.brrga swizzling (equivalent to lvec4.zxxyw).
        /// </summary>
        public lvec5 brrga => new lvec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.zxxz swizzling.
        /// </summary>
        public lvec4 zxxz => new lvec4(z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.brrb swizzling (equivalent to lvec4.zxxz).
        /// </summary>
        public lvec4 brrb => new lvec4(z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.zxxzx swizzling.
        /// </summary>
        public lvec5 zxxzx => new lvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.brrbr swizzling (equivalent to lvec4.zxxzx).
        /// </summary>
        public lvec5 brrbr => new lvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.zxxzy swizzling.
        /// </summary>
        public lvec5 zxxzy => new lvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.brrbg swizzling (equivalent to lvec4.zxxzy).
        /// </summary>
        public lvec5 brrbg => new lvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.zxxzz swizzling.
        /// </summary>
        public lvec5 zxxzz => new lvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.brrbb swizzling (equivalent to lvec4.zxxzz).
        /// </summary>
        public lvec5 brrbb => new lvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.zxxzw swizzling.
        /// </summary>
        public lvec5 zxxzw => new lvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.brrba swizzling (equivalent to lvec4.zxxzw).
        /// </summary>
        public lvec5 brrba => new lvec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.zxxw swizzling.
        /// </summary>
        public lvec4 zxxw => new lvec4(z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.brra swizzling (equivalent to lvec4.zxxw).
        /// </summary>
        public lvec4 brra => new lvec4(z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.zxxwx swizzling.
        /// </summary>
        public lvec5 zxxwx => new lvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.brrar swizzling (equivalent to lvec4.zxxwx).
        /// </summary>
        public lvec5 brrar => new lvec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.zxxwy swizzling.
        /// </summary>
        public lvec5 zxxwy => new lvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.brrag swizzling (equivalent to lvec4.zxxwy).
        /// </summary>
        public lvec5 brrag => new lvec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.zxxwz swizzling.
        /// </summary>
        public lvec5 zxxwz => new lvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.brrab swizzling (equivalent to lvec4.zxxwz).
        /// </summary>
        public lvec5 brrab => new lvec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.zxxww swizzling.
        /// </summary>
        public lvec5 zxxww => new lvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.brraa swizzling (equivalent to lvec4.zxxww).
        /// </summary>
        public lvec5 brraa => new lvec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.zxy swizzling.
        /// </summary>
        public lvec3 zxy => new lvec3(z, x, y);
        
        /// <summary>
        /// Returns lvec4.brg swizzling (equivalent to lvec4.zxy).
        /// </summary>
        public lvec3 brg => new lvec3(z, x, y);
        
        /// <summary>
        /// Returns lvec4.zxyx swizzling.
        /// </summary>
        public lvec4 zxyx => new lvec4(z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.brgr swizzling (equivalent to lvec4.zxyx).
        /// </summary>
        public lvec4 brgr => new lvec4(z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.zxyxx swizzling.
        /// </summary>
        public lvec5 zxyxx => new lvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.brgrr swizzling (equivalent to lvec4.zxyxx).
        /// </summary>
        public lvec5 brgrr => new lvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.zxyxy swizzling.
        /// </summary>
        public lvec5 zxyxy => new lvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.brgrg swizzling (equivalent to lvec4.zxyxy).
        /// </summary>
        public lvec5 brgrg => new lvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.zxyxz swizzling.
        /// </summary>
        public lvec5 zxyxz => new lvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.brgrb swizzling (equivalent to lvec4.zxyxz).
        /// </summary>
        public lvec5 brgrb => new lvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.zxyxw swizzling.
        /// </summary>
        public lvec5 zxyxw => new lvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.brgra swizzling (equivalent to lvec4.zxyxw).
        /// </summary>
        public lvec5 brgra => new lvec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.zxyy swizzling.
        /// </summary>
        public lvec4 zxyy => new lvec4(z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.brgg swizzling (equivalent to lvec4.zxyy).
        /// </summary>
        public lvec4 brgg => new lvec4(z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.zxyyx swizzling.
        /// </summary>
        public lvec5 zxyyx => new lvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.brggr swizzling (equivalent to lvec4.zxyyx).
        /// </summary>
        public lvec5 brggr => new lvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.zxyyy swizzling.
        /// </summary>
        public lvec5 zxyyy => new lvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.brggg swizzling (equivalent to lvec4.zxyyy).
        /// </summary>
        public lvec5 brggg => new lvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.zxyyz swizzling.
        /// </summary>
        public lvec5 zxyyz => new lvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.brggb swizzling (equivalent to lvec4.zxyyz).
        /// </summary>
        public lvec5 brggb => new lvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.zxyyw swizzling.
        /// </summary>
        public lvec5 zxyyw => new lvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.brgga swizzling (equivalent to lvec4.zxyyw).
        /// </summary>
        public lvec5 brgga => new lvec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.zxyz swizzling.
        /// </summary>
        public lvec4 zxyz => new lvec4(z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.brgb swizzling (equivalent to lvec4.zxyz).
        /// </summary>
        public lvec4 brgb => new lvec4(z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.zxyzx swizzling.
        /// </summary>
        public lvec5 zxyzx => new lvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.brgbr swizzling (equivalent to lvec4.zxyzx).
        /// </summary>
        public lvec5 brgbr => new lvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.zxyzy swizzling.
        /// </summary>
        public lvec5 zxyzy => new lvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.brgbg swizzling (equivalent to lvec4.zxyzy).
        /// </summary>
        public lvec5 brgbg => new lvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.zxyzz swizzling.
        /// </summary>
        public lvec5 zxyzz => new lvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.brgbb swizzling (equivalent to lvec4.zxyzz).
        /// </summary>
        public lvec5 brgbb => new lvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.zxyzw swizzling.
        /// </summary>
        public lvec5 zxyzw => new lvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.brgba swizzling (equivalent to lvec4.zxyzw).
        /// </summary>
        public lvec5 brgba => new lvec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.zxyw swizzling.
        /// </summary>
        public lvec4 zxyw => new lvec4(z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.brga swizzling (equivalent to lvec4.zxyw).
        /// </summary>
        public lvec4 brga => new lvec4(z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.zxywx swizzling.
        /// </summary>
        public lvec5 zxywx => new lvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.brgar swizzling (equivalent to lvec4.zxywx).
        /// </summary>
        public lvec5 brgar => new lvec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.zxywy swizzling.
        /// </summary>
        public lvec5 zxywy => new lvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.brgag swizzling (equivalent to lvec4.zxywy).
        /// </summary>
        public lvec5 brgag => new lvec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.zxywz swizzling.
        /// </summary>
        public lvec5 zxywz => new lvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.brgab swizzling (equivalent to lvec4.zxywz).
        /// </summary>
        public lvec5 brgab => new lvec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.zxyww swizzling.
        /// </summary>
        public lvec5 zxyww => new lvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.brgaa swizzling (equivalent to lvec4.zxyww).
        /// </summary>
        public lvec5 brgaa => new lvec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.zxz swizzling.
        /// </summary>
        public lvec3 zxz => new lvec3(z, x, z);
        
        /// <summary>
        /// Returns lvec4.brb swizzling (equivalent to lvec4.zxz).
        /// </summary>
        public lvec3 brb => new lvec3(z, x, z);
        
        /// <summary>
        /// Returns lvec4.zxzx swizzling.
        /// </summary>
        public lvec4 zxzx => new lvec4(z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.brbr swizzling (equivalent to lvec4.zxzx).
        /// </summary>
        public lvec4 brbr => new lvec4(z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.zxzxx swizzling.
        /// </summary>
        public lvec5 zxzxx => new lvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.brbrr swizzling (equivalent to lvec4.zxzxx).
        /// </summary>
        public lvec5 brbrr => new lvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.zxzxy swizzling.
        /// </summary>
        public lvec5 zxzxy => new lvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.brbrg swizzling (equivalent to lvec4.zxzxy).
        /// </summary>
        public lvec5 brbrg => new lvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.zxzxz swizzling.
        /// </summary>
        public lvec5 zxzxz => new lvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.brbrb swizzling (equivalent to lvec4.zxzxz).
        /// </summary>
        public lvec5 brbrb => new lvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.zxzxw swizzling.
        /// </summary>
        public lvec5 zxzxw => new lvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.brbra swizzling (equivalent to lvec4.zxzxw).
        /// </summary>
        public lvec5 brbra => new lvec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.zxzy swizzling.
        /// </summary>
        public lvec4 zxzy => new lvec4(z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.brbg swizzling (equivalent to lvec4.zxzy).
        /// </summary>
        public lvec4 brbg => new lvec4(z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.zxzyx swizzling.
        /// </summary>
        public lvec5 zxzyx => new lvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.brbgr swizzling (equivalent to lvec4.zxzyx).
        /// </summary>
        public lvec5 brbgr => new lvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.zxzyy swizzling.
        /// </summary>
        public lvec5 zxzyy => new lvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.brbgg swizzling (equivalent to lvec4.zxzyy).
        /// </summary>
        public lvec5 brbgg => new lvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.zxzyz swizzling.
        /// </summary>
        public lvec5 zxzyz => new lvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.brbgb swizzling (equivalent to lvec4.zxzyz).
        /// </summary>
        public lvec5 brbgb => new lvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.zxzyw swizzling.
        /// </summary>
        public lvec5 zxzyw => new lvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.brbga swizzling (equivalent to lvec4.zxzyw).
        /// </summary>
        public lvec5 brbga => new lvec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.zxzz swizzling.
        /// </summary>
        public lvec4 zxzz => new lvec4(z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.brbb swizzling (equivalent to lvec4.zxzz).
        /// </summary>
        public lvec4 brbb => new lvec4(z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.zxzzx swizzling.
        /// </summary>
        public lvec5 zxzzx => new lvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.brbbr swizzling (equivalent to lvec4.zxzzx).
        /// </summary>
        public lvec5 brbbr => new lvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.zxzzy swizzling.
        /// </summary>
        public lvec5 zxzzy => new lvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.brbbg swizzling (equivalent to lvec4.zxzzy).
        /// </summary>
        public lvec5 brbbg => new lvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.zxzzz swizzling.
        /// </summary>
        public lvec5 zxzzz => new lvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.brbbb swizzling (equivalent to lvec4.zxzzz).
        /// </summary>
        public lvec5 brbbb => new lvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.zxzzw swizzling.
        /// </summary>
        public lvec5 zxzzw => new lvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.brbba swizzling (equivalent to lvec4.zxzzw).
        /// </summary>
        public lvec5 brbba => new lvec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.zxzw swizzling.
        /// </summary>
        public lvec4 zxzw => new lvec4(z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.brba swizzling (equivalent to lvec4.zxzw).
        /// </summary>
        public lvec4 brba => new lvec4(z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.zxzwx swizzling.
        /// </summary>
        public lvec5 zxzwx => new lvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.brbar swizzling (equivalent to lvec4.zxzwx).
        /// </summary>
        public lvec5 brbar => new lvec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.zxzwy swizzling.
        /// </summary>
        public lvec5 zxzwy => new lvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.brbag swizzling (equivalent to lvec4.zxzwy).
        /// </summary>
        public lvec5 brbag => new lvec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.zxzwz swizzling.
        /// </summary>
        public lvec5 zxzwz => new lvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.brbab swizzling (equivalent to lvec4.zxzwz).
        /// </summary>
        public lvec5 brbab => new lvec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.zxzww swizzling.
        /// </summary>
        public lvec5 zxzww => new lvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.brbaa swizzling (equivalent to lvec4.zxzww).
        /// </summary>
        public lvec5 brbaa => new lvec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.zxw swizzling.
        /// </summary>
        public lvec3 zxw => new lvec3(z, x, w);
        
        /// <summary>
        /// Returns lvec4.bra swizzling (equivalent to lvec4.zxw).
        /// </summary>
        public lvec3 bra => new lvec3(z, x, w);
        
        /// <summary>
        /// Returns lvec4.zxwx swizzling.
        /// </summary>
        public lvec4 zxwx => new lvec4(z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.brar swizzling (equivalent to lvec4.zxwx).
        /// </summary>
        public lvec4 brar => new lvec4(z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.zxwxx swizzling.
        /// </summary>
        public lvec5 zxwxx => new lvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.brarr swizzling (equivalent to lvec4.zxwxx).
        /// </summary>
        public lvec5 brarr => new lvec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.zxwxy swizzling.
        /// </summary>
        public lvec5 zxwxy => new lvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.brarg swizzling (equivalent to lvec4.zxwxy).
        /// </summary>
        public lvec5 brarg => new lvec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.zxwxz swizzling.
        /// </summary>
        public lvec5 zxwxz => new lvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.brarb swizzling (equivalent to lvec4.zxwxz).
        /// </summary>
        public lvec5 brarb => new lvec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.zxwxw swizzling.
        /// </summary>
        public lvec5 zxwxw => new lvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.brara swizzling (equivalent to lvec4.zxwxw).
        /// </summary>
        public lvec5 brara => new lvec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.zxwy swizzling.
        /// </summary>
        public lvec4 zxwy => new lvec4(z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.brag swizzling (equivalent to lvec4.zxwy).
        /// </summary>
        public lvec4 brag => new lvec4(z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.zxwyx swizzling.
        /// </summary>
        public lvec5 zxwyx => new lvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.bragr swizzling (equivalent to lvec4.zxwyx).
        /// </summary>
        public lvec5 bragr => new lvec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.zxwyy swizzling.
        /// </summary>
        public lvec5 zxwyy => new lvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.bragg swizzling (equivalent to lvec4.zxwyy).
        /// </summary>
        public lvec5 bragg => new lvec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.zxwyz swizzling.
        /// </summary>
        public lvec5 zxwyz => new lvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.bragb swizzling (equivalent to lvec4.zxwyz).
        /// </summary>
        public lvec5 bragb => new lvec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.zxwyw swizzling.
        /// </summary>
        public lvec5 zxwyw => new lvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.braga swizzling (equivalent to lvec4.zxwyw).
        /// </summary>
        public lvec5 braga => new lvec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.zxwz swizzling.
        /// </summary>
        public lvec4 zxwz => new lvec4(z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.brab swizzling (equivalent to lvec4.zxwz).
        /// </summary>
        public lvec4 brab => new lvec4(z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.zxwzx swizzling.
        /// </summary>
        public lvec5 zxwzx => new lvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.brabr swizzling (equivalent to lvec4.zxwzx).
        /// </summary>
        public lvec5 brabr => new lvec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.zxwzy swizzling.
        /// </summary>
        public lvec5 zxwzy => new lvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.brabg swizzling (equivalent to lvec4.zxwzy).
        /// </summary>
        public lvec5 brabg => new lvec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.zxwzz swizzling.
        /// </summary>
        public lvec5 zxwzz => new lvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.brabb swizzling (equivalent to lvec4.zxwzz).
        /// </summary>
        public lvec5 brabb => new lvec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.zxwzw swizzling.
        /// </summary>
        public lvec5 zxwzw => new lvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.braba swizzling (equivalent to lvec4.zxwzw).
        /// </summary>
        public lvec5 braba => new lvec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.zxww swizzling.
        /// </summary>
        public lvec4 zxww => new lvec4(z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.braa swizzling (equivalent to lvec4.zxww).
        /// </summary>
        public lvec4 braa => new lvec4(z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.zxwwx swizzling.
        /// </summary>
        public lvec5 zxwwx => new lvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.braar swizzling (equivalent to lvec4.zxwwx).
        /// </summary>
        public lvec5 braar => new lvec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.zxwwy swizzling.
        /// </summary>
        public lvec5 zxwwy => new lvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.braag swizzling (equivalent to lvec4.zxwwy).
        /// </summary>
        public lvec5 braag => new lvec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.zxwwz swizzling.
        /// </summary>
        public lvec5 zxwwz => new lvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.braab swizzling (equivalent to lvec4.zxwwz).
        /// </summary>
        public lvec5 braab => new lvec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.zxwww swizzling.
        /// </summary>
        public lvec5 zxwww => new lvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.braaa swizzling (equivalent to lvec4.zxwww).
        /// </summary>
        public lvec5 braaa => new lvec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.zy swizzling.
        /// </summary>
        public lvec2 zy => new lvec2(z, y);
        
        /// <summary>
        /// Returns lvec4.bg swizzling (equivalent to lvec4.zy).
        /// </summary>
        public lvec2 bg => new lvec2(z, y);
        
        /// <summary>
        /// Returns lvec4.zyx swizzling.
        /// </summary>
        public lvec3 zyx => new lvec3(z, y, x);
        
        /// <summary>
        /// Returns lvec4.bgr swizzling (equivalent to lvec4.zyx).
        /// </summary>
        public lvec3 bgr => new lvec3(z, y, x);
        
        /// <summary>
        /// Returns lvec4.zyxx swizzling.
        /// </summary>
        public lvec4 zyxx => new lvec4(z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.bgrr swizzling (equivalent to lvec4.zyxx).
        /// </summary>
        public lvec4 bgrr => new lvec4(z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.zyxxx swizzling.
        /// </summary>
        public lvec5 zyxxx => new lvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.bgrrr swizzling (equivalent to lvec4.zyxxx).
        /// </summary>
        public lvec5 bgrrr => new lvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.zyxxy swizzling.
        /// </summary>
        public lvec5 zyxxy => new lvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.bgrrg swizzling (equivalent to lvec4.zyxxy).
        /// </summary>
        public lvec5 bgrrg => new lvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.zyxxz swizzling.
        /// </summary>
        public lvec5 zyxxz => new lvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.bgrrb swizzling (equivalent to lvec4.zyxxz).
        /// </summary>
        public lvec5 bgrrb => new lvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.zyxxw swizzling.
        /// </summary>
        public lvec5 zyxxw => new lvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.bgrra swizzling (equivalent to lvec4.zyxxw).
        /// </summary>
        public lvec5 bgrra => new lvec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.zyxy swizzling.
        /// </summary>
        public lvec4 zyxy => new lvec4(z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.bgrg swizzling (equivalent to lvec4.zyxy).
        /// </summary>
        public lvec4 bgrg => new lvec4(z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.zyxyx swizzling.
        /// </summary>
        public lvec5 zyxyx => new lvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.bgrgr swizzling (equivalent to lvec4.zyxyx).
        /// </summary>
        public lvec5 bgrgr => new lvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.zyxyy swizzling.
        /// </summary>
        public lvec5 zyxyy => new lvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.bgrgg swizzling (equivalent to lvec4.zyxyy).
        /// </summary>
        public lvec5 bgrgg => new lvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.zyxyz swizzling.
        /// </summary>
        public lvec5 zyxyz => new lvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.bgrgb swizzling (equivalent to lvec4.zyxyz).
        /// </summary>
        public lvec5 bgrgb => new lvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.zyxyw swizzling.
        /// </summary>
        public lvec5 zyxyw => new lvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.bgrga swizzling (equivalent to lvec4.zyxyw).
        /// </summary>
        public lvec5 bgrga => new lvec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.zyxz swizzling.
        /// </summary>
        public lvec4 zyxz => new lvec4(z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.bgrb swizzling (equivalent to lvec4.zyxz).
        /// </summary>
        public lvec4 bgrb => new lvec4(z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.zyxzx swizzling.
        /// </summary>
        public lvec5 zyxzx => new lvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.bgrbr swizzling (equivalent to lvec4.zyxzx).
        /// </summary>
        public lvec5 bgrbr => new lvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.zyxzy swizzling.
        /// </summary>
        public lvec5 zyxzy => new lvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.bgrbg swizzling (equivalent to lvec4.zyxzy).
        /// </summary>
        public lvec5 bgrbg => new lvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.zyxzz swizzling.
        /// </summary>
        public lvec5 zyxzz => new lvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.bgrbb swizzling (equivalent to lvec4.zyxzz).
        /// </summary>
        public lvec5 bgrbb => new lvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.zyxzw swizzling.
        /// </summary>
        public lvec5 zyxzw => new lvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.bgrba swizzling (equivalent to lvec4.zyxzw).
        /// </summary>
        public lvec5 bgrba => new lvec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.zyxw swizzling.
        /// </summary>
        public lvec4 zyxw => new lvec4(z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.bgra swizzling (equivalent to lvec4.zyxw).
        /// </summary>
        public lvec4 bgra => new lvec4(z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.zyxwx swizzling.
        /// </summary>
        public lvec5 zyxwx => new lvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.bgrar swizzling (equivalent to lvec4.zyxwx).
        /// </summary>
        public lvec5 bgrar => new lvec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.zyxwy swizzling.
        /// </summary>
        public lvec5 zyxwy => new lvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.bgrag swizzling (equivalent to lvec4.zyxwy).
        /// </summary>
        public lvec5 bgrag => new lvec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.zyxwz swizzling.
        /// </summary>
        public lvec5 zyxwz => new lvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.bgrab swizzling (equivalent to lvec4.zyxwz).
        /// </summary>
        public lvec5 bgrab => new lvec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.zyxww swizzling.
        /// </summary>
        public lvec5 zyxww => new lvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.bgraa swizzling (equivalent to lvec4.zyxww).
        /// </summary>
        public lvec5 bgraa => new lvec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.zyy swizzling.
        /// </summary>
        public lvec3 zyy => new lvec3(z, y, y);
        
        /// <summary>
        /// Returns lvec4.bgg swizzling (equivalent to lvec4.zyy).
        /// </summary>
        public lvec3 bgg => new lvec3(z, y, y);
        
        /// <summary>
        /// Returns lvec4.zyyx swizzling.
        /// </summary>
        public lvec4 zyyx => new lvec4(z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.bggr swizzling (equivalent to lvec4.zyyx).
        /// </summary>
        public lvec4 bggr => new lvec4(z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.zyyxx swizzling.
        /// </summary>
        public lvec5 zyyxx => new lvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.bggrr swizzling (equivalent to lvec4.zyyxx).
        /// </summary>
        public lvec5 bggrr => new lvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.zyyxy swizzling.
        /// </summary>
        public lvec5 zyyxy => new lvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.bggrg swizzling (equivalent to lvec4.zyyxy).
        /// </summary>
        public lvec5 bggrg => new lvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.zyyxz swizzling.
        /// </summary>
        public lvec5 zyyxz => new lvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.bggrb swizzling (equivalent to lvec4.zyyxz).
        /// </summary>
        public lvec5 bggrb => new lvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.zyyxw swizzling.
        /// </summary>
        public lvec5 zyyxw => new lvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.bggra swizzling (equivalent to lvec4.zyyxw).
        /// </summary>
        public lvec5 bggra => new lvec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.zyyy swizzling.
        /// </summary>
        public lvec4 zyyy => new lvec4(z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.bggg swizzling (equivalent to lvec4.zyyy).
        /// </summary>
        public lvec4 bggg => new lvec4(z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.zyyyx swizzling.
        /// </summary>
        public lvec5 zyyyx => new lvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.bgggr swizzling (equivalent to lvec4.zyyyx).
        /// </summary>
        public lvec5 bgggr => new lvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.zyyyy swizzling.
        /// </summary>
        public lvec5 zyyyy => new lvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.bgggg swizzling (equivalent to lvec4.zyyyy).
        /// </summary>
        public lvec5 bgggg => new lvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.zyyyz swizzling.
        /// </summary>
        public lvec5 zyyyz => new lvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.bgggb swizzling (equivalent to lvec4.zyyyz).
        /// </summary>
        public lvec5 bgggb => new lvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.zyyyw swizzling.
        /// </summary>
        public lvec5 zyyyw => new lvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.bggga swizzling (equivalent to lvec4.zyyyw).
        /// </summary>
        public lvec5 bggga => new lvec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.zyyz swizzling.
        /// </summary>
        public lvec4 zyyz => new lvec4(z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.bggb swizzling (equivalent to lvec4.zyyz).
        /// </summary>
        public lvec4 bggb => new lvec4(z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.zyyzx swizzling.
        /// </summary>
        public lvec5 zyyzx => new lvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.bggbr swizzling (equivalent to lvec4.zyyzx).
        /// </summary>
        public lvec5 bggbr => new lvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.zyyzy swizzling.
        /// </summary>
        public lvec5 zyyzy => new lvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.bggbg swizzling (equivalent to lvec4.zyyzy).
        /// </summary>
        public lvec5 bggbg => new lvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.zyyzz swizzling.
        /// </summary>
        public lvec5 zyyzz => new lvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.bggbb swizzling (equivalent to lvec4.zyyzz).
        /// </summary>
        public lvec5 bggbb => new lvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.zyyzw swizzling.
        /// </summary>
        public lvec5 zyyzw => new lvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.bggba swizzling (equivalent to lvec4.zyyzw).
        /// </summary>
        public lvec5 bggba => new lvec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.zyyw swizzling.
        /// </summary>
        public lvec4 zyyw => new lvec4(z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.bgga swizzling (equivalent to lvec4.zyyw).
        /// </summary>
        public lvec4 bgga => new lvec4(z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.zyywx swizzling.
        /// </summary>
        public lvec5 zyywx => new lvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.bggar swizzling (equivalent to lvec4.zyywx).
        /// </summary>
        public lvec5 bggar => new lvec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.zyywy swizzling.
        /// </summary>
        public lvec5 zyywy => new lvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.bggag swizzling (equivalent to lvec4.zyywy).
        /// </summary>
        public lvec5 bggag => new lvec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.zyywz swizzling.
        /// </summary>
        public lvec5 zyywz => new lvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.bggab swizzling (equivalent to lvec4.zyywz).
        /// </summary>
        public lvec5 bggab => new lvec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.zyyww swizzling.
        /// </summary>
        public lvec5 zyyww => new lvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.bggaa swizzling (equivalent to lvec4.zyyww).
        /// </summary>
        public lvec5 bggaa => new lvec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.zyz swizzling.
        /// </summary>
        public lvec3 zyz => new lvec3(z, y, z);
        
        /// <summary>
        /// Returns lvec4.bgb swizzling (equivalent to lvec4.zyz).
        /// </summary>
        public lvec3 bgb => new lvec3(z, y, z);
        
        /// <summary>
        /// Returns lvec4.zyzx swizzling.
        /// </summary>
        public lvec4 zyzx => new lvec4(z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.bgbr swizzling (equivalent to lvec4.zyzx).
        /// </summary>
        public lvec4 bgbr => new lvec4(z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.zyzxx swizzling.
        /// </summary>
        public lvec5 zyzxx => new lvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.bgbrr swizzling (equivalent to lvec4.zyzxx).
        /// </summary>
        public lvec5 bgbrr => new lvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.zyzxy swizzling.
        /// </summary>
        public lvec5 zyzxy => new lvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.bgbrg swizzling (equivalent to lvec4.zyzxy).
        /// </summary>
        public lvec5 bgbrg => new lvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.zyzxz swizzling.
        /// </summary>
        public lvec5 zyzxz => new lvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.bgbrb swizzling (equivalent to lvec4.zyzxz).
        /// </summary>
        public lvec5 bgbrb => new lvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.zyzxw swizzling.
        /// </summary>
        public lvec5 zyzxw => new lvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.bgbra swizzling (equivalent to lvec4.zyzxw).
        /// </summary>
        public lvec5 bgbra => new lvec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.zyzy swizzling.
        /// </summary>
        public lvec4 zyzy => new lvec4(z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.bgbg swizzling (equivalent to lvec4.zyzy).
        /// </summary>
        public lvec4 bgbg => new lvec4(z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.zyzyx swizzling.
        /// </summary>
        public lvec5 zyzyx => new lvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.bgbgr swizzling (equivalent to lvec4.zyzyx).
        /// </summary>
        public lvec5 bgbgr => new lvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.zyzyy swizzling.
        /// </summary>
        public lvec5 zyzyy => new lvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.bgbgg swizzling (equivalent to lvec4.zyzyy).
        /// </summary>
        public lvec5 bgbgg => new lvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.zyzyz swizzling.
        /// </summary>
        public lvec5 zyzyz => new lvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.bgbgb swizzling (equivalent to lvec4.zyzyz).
        /// </summary>
        public lvec5 bgbgb => new lvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.zyzyw swizzling.
        /// </summary>
        public lvec5 zyzyw => new lvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.bgbga swizzling (equivalent to lvec4.zyzyw).
        /// </summary>
        public lvec5 bgbga => new lvec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.zyzz swizzling.
        /// </summary>
        public lvec4 zyzz => new lvec4(z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.bgbb swizzling (equivalent to lvec4.zyzz).
        /// </summary>
        public lvec4 bgbb => new lvec4(z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.zyzzx swizzling.
        /// </summary>
        public lvec5 zyzzx => new lvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.bgbbr swizzling (equivalent to lvec4.zyzzx).
        /// </summary>
        public lvec5 bgbbr => new lvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.zyzzy swizzling.
        /// </summary>
        public lvec5 zyzzy => new lvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.bgbbg swizzling (equivalent to lvec4.zyzzy).
        /// </summary>
        public lvec5 bgbbg => new lvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.zyzzz swizzling.
        /// </summary>
        public lvec5 zyzzz => new lvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.bgbbb swizzling (equivalent to lvec4.zyzzz).
        /// </summary>
        public lvec5 bgbbb => new lvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.zyzzw swizzling.
        /// </summary>
        public lvec5 zyzzw => new lvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.bgbba swizzling (equivalent to lvec4.zyzzw).
        /// </summary>
        public lvec5 bgbba => new lvec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.zyzw swizzling.
        /// </summary>
        public lvec4 zyzw => new lvec4(z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.bgba swizzling (equivalent to lvec4.zyzw).
        /// </summary>
        public lvec4 bgba => new lvec4(z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.zyzwx swizzling.
        /// </summary>
        public lvec5 zyzwx => new lvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.bgbar swizzling (equivalent to lvec4.zyzwx).
        /// </summary>
        public lvec5 bgbar => new lvec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.zyzwy swizzling.
        /// </summary>
        public lvec5 zyzwy => new lvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.bgbag swizzling (equivalent to lvec4.zyzwy).
        /// </summary>
        public lvec5 bgbag => new lvec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.zyzwz swizzling.
        /// </summary>
        public lvec5 zyzwz => new lvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.bgbab swizzling (equivalent to lvec4.zyzwz).
        /// </summary>
        public lvec5 bgbab => new lvec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.zyzww swizzling.
        /// </summary>
        public lvec5 zyzww => new lvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.bgbaa swizzling (equivalent to lvec4.zyzww).
        /// </summary>
        public lvec5 bgbaa => new lvec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.zyw swizzling.
        /// </summary>
        public lvec3 zyw => new lvec3(z, y, w);
        
        /// <summary>
        /// Returns lvec4.bga swizzling (equivalent to lvec4.zyw).
        /// </summary>
        public lvec3 bga => new lvec3(z, y, w);
        
        /// <summary>
        /// Returns lvec4.zywx swizzling.
        /// </summary>
        public lvec4 zywx => new lvec4(z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.bgar swizzling (equivalent to lvec4.zywx).
        /// </summary>
        public lvec4 bgar => new lvec4(z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.zywxx swizzling.
        /// </summary>
        public lvec5 zywxx => new lvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.bgarr swizzling (equivalent to lvec4.zywxx).
        /// </summary>
        public lvec5 bgarr => new lvec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.zywxy swizzling.
        /// </summary>
        public lvec5 zywxy => new lvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.bgarg swizzling (equivalent to lvec4.zywxy).
        /// </summary>
        public lvec5 bgarg => new lvec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.zywxz swizzling.
        /// </summary>
        public lvec5 zywxz => new lvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.bgarb swizzling (equivalent to lvec4.zywxz).
        /// </summary>
        public lvec5 bgarb => new lvec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.zywxw swizzling.
        /// </summary>
        public lvec5 zywxw => new lvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.bgara swizzling (equivalent to lvec4.zywxw).
        /// </summary>
        public lvec5 bgara => new lvec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.zywy swizzling.
        /// </summary>
        public lvec4 zywy => new lvec4(z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.bgag swizzling (equivalent to lvec4.zywy).
        /// </summary>
        public lvec4 bgag => new lvec4(z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.zywyx swizzling.
        /// </summary>
        public lvec5 zywyx => new lvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.bgagr swizzling (equivalent to lvec4.zywyx).
        /// </summary>
        public lvec5 bgagr => new lvec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.zywyy swizzling.
        /// </summary>
        public lvec5 zywyy => new lvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.bgagg swizzling (equivalent to lvec4.zywyy).
        /// </summary>
        public lvec5 bgagg => new lvec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.zywyz swizzling.
        /// </summary>
        public lvec5 zywyz => new lvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.bgagb swizzling (equivalent to lvec4.zywyz).
        /// </summary>
        public lvec5 bgagb => new lvec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.zywyw swizzling.
        /// </summary>
        public lvec5 zywyw => new lvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.bgaga swizzling (equivalent to lvec4.zywyw).
        /// </summary>
        public lvec5 bgaga => new lvec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.zywz swizzling.
        /// </summary>
        public lvec4 zywz => new lvec4(z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.bgab swizzling (equivalent to lvec4.zywz).
        /// </summary>
        public lvec4 bgab => new lvec4(z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.zywzx swizzling.
        /// </summary>
        public lvec5 zywzx => new lvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.bgabr swizzling (equivalent to lvec4.zywzx).
        /// </summary>
        public lvec5 bgabr => new lvec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.zywzy swizzling.
        /// </summary>
        public lvec5 zywzy => new lvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.bgabg swizzling (equivalent to lvec4.zywzy).
        /// </summary>
        public lvec5 bgabg => new lvec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.zywzz swizzling.
        /// </summary>
        public lvec5 zywzz => new lvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.bgabb swizzling (equivalent to lvec4.zywzz).
        /// </summary>
        public lvec5 bgabb => new lvec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.zywzw swizzling.
        /// </summary>
        public lvec5 zywzw => new lvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.bgaba swizzling (equivalent to lvec4.zywzw).
        /// </summary>
        public lvec5 bgaba => new lvec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.zyww swizzling.
        /// </summary>
        public lvec4 zyww => new lvec4(z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.bgaa swizzling (equivalent to lvec4.zyww).
        /// </summary>
        public lvec4 bgaa => new lvec4(z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.zywwx swizzling.
        /// </summary>
        public lvec5 zywwx => new lvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.bgaar swizzling (equivalent to lvec4.zywwx).
        /// </summary>
        public lvec5 bgaar => new lvec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.zywwy swizzling.
        /// </summary>
        public lvec5 zywwy => new lvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.bgaag swizzling (equivalent to lvec4.zywwy).
        /// </summary>
        public lvec5 bgaag => new lvec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.zywwz swizzling.
        /// </summary>
        public lvec5 zywwz => new lvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.bgaab swizzling (equivalent to lvec4.zywwz).
        /// </summary>
        public lvec5 bgaab => new lvec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.zywww swizzling.
        /// </summary>
        public lvec5 zywww => new lvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.bgaaa swizzling (equivalent to lvec4.zywww).
        /// </summary>
        public lvec5 bgaaa => new lvec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.zz swizzling.
        /// </summary>
        public lvec2 zz => new lvec2(z, z);
        
        /// <summary>
        /// Returns lvec4.bb swizzling (equivalent to lvec4.zz).
        /// </summary>
        public lvec2 bb => new lvec2(z, z);
        
        /// <summary>
        /// Returns lvec4.zzx swizzling.
        /// </summary>
        public lvec3 zzx => new lvec3(z, z, x);
        
        /// <summary>
        /// Returns lvec4.bbr swizzling (equivalent to lvec4.zzx).
        /// </summary>
        public lvec3 bbr => new lvec3(z, z, x);
        
        /// <summary>
        /// Returns lvec4.zzxx swizzling.
        /// </summary>
        public lvec4 zzxx => new lvec4(z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.bbrr swizzling (equivalent to lvec4.zzxx).
        /// </summary>
        public lvec4 bbrr => new lvec4(z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.zzxxx swizzling.
        /// </summary>
        public lvec5 zzxxx => new lvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.bbrrr swizzling (equivalent to lvec4.zzxxx).
        /// </summary>
        public lvec5 bbrrr => new lvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.zzxxy swizzling.
        /// </summary>
        public lvec5 zzxxy => new lvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.bbrrg swizzling (equivalent to lvec4.zzxxy).
        /// </summary>
        public lvec5 bbrrg => new lvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.zzxxz swizzling.
        /// </summary>
        public lvec5 zzxxz => new lvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.bbrrb swizzling (equivalent to lvec4.zzxxz).
        /// </summary>
        public lvec5 bbrrb => new lvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.zzxxw swizzling.
        /// </summary>
        public lvec5 zzxxw => new lvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.bbrra swizzling (equivalent to lvec4.zzxxw).
        /// </summary>
        public lvec5 bbrra => new lvec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.zzxy swizzling.
        /// </summary>
        public lvec4 zzxy => new lvec4(z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.bbrg swizzling (equivalent to lvec4.zzxy).
        /// </summary>
        public lvec4 bbrg => new lvec4(z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.zzxyx swizzling.
        /// </summary>
        public lvec5 zzxyx => new lvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.bbrgr swizzling (equivalent to lvec4.zzxyx).
        /// </summary>
        public lvec5 bbrgr => new lvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.zzxyy swizzling.
        /// </summary>
        public lvec5 zzxyy => new lvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.bbrgg swizzling (equivalent to lvec4.zzxyy).
        /// </summary>
        public lvec5 bbrgg => new lvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.zzxyz swizzling.
        /// </summary>
        public lvec5 zzxyz => new lvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.bbrgb swizzling (equivalent to lvec4.zzxyz).
        /// </summary>
        public lvec5 bbrgb => new lvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.zzxyw swizzling.
        /// </summary>
        public lvec5 zzxyw => new lvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.bbrga swizzling (equivalent to lvec4.zzxyw).
        /// </summary>
        public lvec5 bbrga => new lvec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.zzxz swizzling.
        /// </summary>
        public lvec4 zzxz => new lvec4(z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.bbrb swizzling (equivalent to lvec4.zzxz).
        /// </summary>
        public lvec4 bbrb => new lvec4(z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.zzxzx swizzling.
        /// </summary>
        public lvec5 zzxzx => new lvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.bbrbr swizzling (equivalent to lvec4.zzxzx).
        /// </summary>
        public lvec5 bbrbr => new lvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.zzxzy swizzling.
        /// </summary>
        public lvec5 zzxzy => new lvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.bbrbg swizzling (equivalent to lvec4.zzxzy).
        /// </summary>
        public lvec5 bbrbg => new lvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.zzxzz swizzling.
        /// </summary>
        public lvec5 zzxzz => new lvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.bbrbb swizzling (equivalent to lvec4.zzxzz).
        /// </summary>
        public lvec5 bbrbb => new lvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.zzxzw swizzling.
        /// </summary>
        public lvec5 zzxzw => new lvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.bbrba swizzling (equivalent to lvec4.zzxzw).
        /// </summary>
        public lvec5 bbrba => new lvec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.zzxw swizzling.
        /// </summary>
        public lvec4 zzxw => new lvec4(z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.bbra swizzling (equivalent to lvec4.zzxw).
        /// </summary>
        public lvec4 bbra => new lvec4(z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.zzxwx swizzling.
        /// </summary>
        public lvec5 zzxwx => new lvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.bbrar swizzling (equivalent to lvec4.zzxwx).
        /// </summary>
        public lvec5 bbrar => new lvec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.zzxwy swizzling.
        /// </summary>
        public lvec5 zzxwy => new lvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.bbrag swizzling (equivalent to lvec4.zzxwy).
        /// </summary>
        public lvec5 bbrag => new lvec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.zzxwz swizzling.
        /// </summary>
        public lvec5 zzxwz => new lvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.bbrab swizzling (equivalent to lvec4.zzxwz).
        /// </summary>
        public lvec5 bbrab => new lvec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.zzxww swizzling.
        /// </summary>
        public lvec5 zzxww => new lvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.bbraa swizzling (equivalent to lvec4.zzxww).
        /// </summary>
        public lvec5 bbraa => new lvec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.zzy swizzling.
        /// </summary>
        public lvec3 zzy => new lvec3(z, z, y);
        
        /// <summary>
        /// Returns lvec4.bbg swizzling (equivalent to lvec4.zzy).
        /// </summary>
        public lvec3 bbg => new lvec3(z, z, y);
        
        /// <summary>
        /// Returns lvec4.zzyx swizzling.
        /// </summary>
        public lvec4 zzyx => new lvec4(z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.bbgr swizzling (equivalent to lvec4.zzyx).
        /// </summary>
        public lvec4 bbgr => new lvec4(z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.zzyxx swizzling.
        /// </summary>
        public lvec5 zzyxx => new lvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.bbgrr swizzling (equivalent to lvec4.zzyxx).
        /// </summary>
        public lvec5 bbgrr => new lvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.zzyxy swizzling.
        /// </summary>
        public lvec5 zzyxy => new lvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.bbgrg swizzling (equivalent to lvec4.zzyxy).
        /// </summary>
        public lvec5 bbgrg => new lvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.zzyxz swizzling.
        /// </summary>
        public lvec5 zzyxz => new lvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.bbgrb swizzling (equivalent to lvec4.zzyxz).
        /// </summary>
        public lvec5 bbgrb => new lvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.zzyxw swizzling.
        /// </summary>
        public lvec5 zzyxw => new lvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.bbgra swizzling (equivalent to lvec4.zzyxw).
        /// </summary>
        public lvec5 bbgra => new lvec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.zzyy swizzling.
        /// </summary>
        public lvec4 zzyy => new lvec4(z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.bbgg swizzling (equivalent to lvec4.zzyy).
        /// </summary>
        public lvec4 bbgg => new lvec4(z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.zzyyx swizzling.
        /// </summary>
        public lvec5 zzyyx => new lvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.bbggr swizzling (equivalent to lvec4.zzyyx).
        /// </summary>
        public lvec5 bbggr => new lvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.zzyyy swizzling.
        /// </summary>
        public lvec5 zzyyy => new lvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.bbggg swizzling (equivalent to lvec4.zzyyy).
        /// </summary>
        public lvec5 bbggg => new lvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.zzyyz swizzling.
        /// </summary>
        public lvec5 zzyyz => new lvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.bbggb swizzling (equivalent to lvec4.zzyyz).
        /// </summary>
        public lvec5 bbggb => new lvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.zzyyw swizzling.
        /// </summary>
        public lvec5 zzyyw => new lvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.bbgga swizzling (equivalent to lvec4.zzyyw).
        /// </summary>
        public lvec5 bbgga => new lvec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.zzyz swizzling.
        /// </summary>
        public lvec4 zzyz => new lvec4(z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.bbgb swizzling (equivalent to lvec4.zzyz).
        /// </summary>
        public lvec4 bbgb => new lvec4(z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.zzyzx swizzling.
        /// </summary>
        public lvec5 zzyzx => new lvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.bbgbr swizzling (equivalent to lvec4.zzyzx).
        /// </summary>
        public lvec5 bbgbr => new lvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.zzyzy swizzling.
        /// </summary>
        public lvec5 zzyzy => new lvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.bbgbg swizzling (equivalent to lvec4.zzyzy).
        /// </summary>
        public lvec5 bbgbg => new lvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.zzyzz swizzling.
        /// </summary>
        public lvec5 zzyzz => new lvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.bbgbb swizzling (equivalent to lvec4.zzyzz).
        /// </summary>
        public lvec5 bbgbb => new lvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.zzyzw swizzling.
        /// </summary>
        public lvec5 zzyzw => new lvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.bbgba swizzling (equivalent to lvec4.zzyzw).
        /// </summary>
        public lvec5 bbgba => new lvec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.zzyw swizzling.
        /// </summary>
        public lvec4 zzyw => new lvec4(z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.bbga swizzling (equivalent to lvec4.zzyw).
        /// </summary>
        public lvec4 bbga => new lvec4(z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.zzywx swizzling.
        /// </summary>
        public lvec5 zzywx => new lvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.bbgar swizzling (equivalent to lvec4.zzywx).
        /// </summary>
        public lvec5 bbgar => new lvec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.zzywy swizzling.
        /// </summary>
        public lvec5 zzywy => new lvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.bbgag swizzling (equivalent to lvec4.zzywy).
        /// </summary>
        public lvec5 bbgag => new lvec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.zzywz swizzling.
        /// </summary>
        public lvec5 zzywz => new lvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.bbgab swizzling (equivalent to lvec4.zzywz).
        /// </summary>
        public lvec5 bbgab => new lvec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.zzyww swizzling.
        /// </summary>
        public lvec5 zzyww => new lvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.bbgaa swizzling (equivalent to lvec4.zzyww).
        /// </summary>
        public lvec5 bbgaa => new lvec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.zzz swizzling.
        /// </summary>
        public lvec3 zzz => new lvec3(z, z, z);
        
        /// <summary>
        /// Returns lvec4.bbb swizzling (equivalent to lvec4.zzz).
        /// </summary>
        public lvec3 bbb => new lvec3(z, z, z);
        
        /// <summary>
        /// Returns lvec4.zzzx swizzling.
        /// </summary>
        public lvec4 zzzx => new lvec4(z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.bbbr swizzling (equivalent to lvec4.zzzx).
        /// </summary>
        public lvec4 bbbr => new lvec4(z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.zzzxx swizzling.
        /// </summary>
        public lvec5 zzzxx => new lvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.bbbrr swizzling (equivalent to lvec4.zzzxx).
        /// </summary>
        public lvec5 bbbrr => new lvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.zzzxy swizzling.
        /// </summary>
        public lvec5 zzzxy => new lvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.bbbrg swizzling (equivalent to lvec4.zzzxy).
        /// </summary>
        public lvec5 bbbrg => new lvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.zzzxz swizzling.
        /// </summary>
        public lvec5 zzzxz => new lvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.bbbrb swizzling (equivalent to lvec4.zzzxz).
        /// </summary>
        public lvec5 bbbrb => new lvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.zzzxw swizzling.
        /// </summary>
        public lvec5 zzzxw => new lvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.bbbra swizzling (equivalent to lvec4.zzzxw).
        /// </summary>
        public lvec5 bbbra => new lvec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.zzzy swizzling.
        /// </summary>
        public lvec4 zzzy => new lvec4(z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.bbbg swizzling (equivalent to lvec4.zzzy).
        /// </summary>
        public lvec4 bbbg => new lvec4(z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.zzzyx swizzling.
        /// </summary>
        public lvec5 zzzyx => new lvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.bbbgr swizzling (equivalent to lvec4.zzzyx).
        /// </summary>
        public lvec5 bbbgr => new lvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.zzzyy swizzling.
        /// </summary>
        public lvec5 zzzyy => new lvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.bbbgg swizzling (equivalent to lvec4.zzzyy).
        /// </summary>
        public lvec5 bbbgg => new lvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.zzzyz swizzling.
        /// </summary>
        public lvec5 zzzyz => new lvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.bbbgb swizzling (equivalent to lvec4.zzzyz).
        /// </summary>
        public lvec5 bbbgb => new lvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.zzzyw swizzling.
        /// </summary>
        public lvec5 zzzyw => new lvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.bbbga swizzling (equivalent to lvec4.zzzyw).
        /// </summary>
        public lvec5 bbbga => new lvec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.zzzz swizzling.
        /// </summary>
        public lvec4 zzzz => new lvec4(z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.bbbb swizzling (equivalent to lvec4.zzzz).
        /// </summary>
        public lvec4 bbbb => new lvec4(z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.zzzzx swizzling.
        /// </summary>
        public lvec5 zzzzx => new lvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.bbbbr swizzling (equivalent to lvec4.zzzzx).
        /// </summary>
        public lvec5 bbbbr => new lvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.zzzzy swizzling.
        /// </summary>
        public lvec5 zzzzy => new lvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.bbbbg swizzling (equivalent to lvec4.zzzzy).
        /// </summary>
        public lvec5 bbbbg => new lvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.zzzzz swizzling.
        /// </summary>
        public lvec5 zzzzz => new lvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.bbbbb swizzling (equivalent to lvec4.zzzzz).
        /// </summary>
        public lvec5 bbbbb => new lvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.zzzzw swizzling.
        /// </summary>
        public lvec5 zzzzw => new lvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.bbbba swizzling (equivalent to lvec4.zzzzw).
        /// </summary>
        public lvec5 bbbba => new lvec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.zzzw swizzling.
        /// </summary>
        public lvec4 zzzw => new lvec4(z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.bbba swizzling (equivalent to lvec4.zzzw).
        /// </summary>
        public lvec4 bbba => new lvec4(z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.zzzwx swizzling.
        /// </summary>
        public lvec5 zzzwx => new lvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.bbbar swizzling (equivalent to lvec4.zzzwx).
        /// </summary>
        public lvec5 bbbar => new lvec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.zzzwy swizzling.
        /// </summary>
        public lvec5 zzzwy => new lvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.bbbag swizzling (equivalent to lvec4.zzzwy).
        /// </summary>
        public lvec5 bbbag => new lvec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.zzzwz swizzling.
        /// </summary>
        public lvec5 zzzwz => new lvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.bbbab swizzling (equivalent to lvec4.zzzwz).
        /// </summary>
        public lvec5 bbbab => new lvec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.zzzww swizzling.
        /// </summary>
        public lvec5 zzzww => new lvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.bbbaa swizzling (equivalent to lvec4.zzzww).
        /// </summary>
        public lvec5 bbbaa => new lvec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.zzw swizzling.
        /// </summary>
        public lvec3 zzw => new lvec3(z, z, w);
        
        /// <summary>
        /// Returns lvec4.bba swizzling (equivalent to lvec4.zzw).
        /// </summary>
        public lvec3 bba => new lvec3(z, z, w);
        
        /// <summary>
        /// Returns lvec4.zzwx swizzling.
        /// </summary>
        public lvec4 zzwx => new lvec4(z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.bbar swizzling (equivalent to lvec4.zzwx).
        /// </summary>
        public lvec4 bbar => new lvec4(z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.zzwxx swizzling.
        /// </summary>
        public lvec5 zzwxx => new lvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.bbarr swizzling (equivalent to lvec4.zzwxx).
        /// </summary>
        public lvec5 bbarr => new lvec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.zzwxy swizzling.
        /// </summary>
        public lvec5 zzwxy => new lvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.bbarg swizzling (equivalent to lvec4.zzwxy).
        /// </summary>
        public lvec5 bbarg => new lvec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.zzwxz swizzling.
        /// </summary>
        public lvec5 zzwxz => new lvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.bbarb swizzling (equivalent to lvec4.zzwxz).
        /// </summary>
        public lvec5 bbarb => new lvec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.zzwxw swizzling.
        /// </summary>
        public lvec5 zzwxw => new lvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.bbara swizzling (equivalent to lvec4.zzwxw).
        /// </summary>
        public lvec5 bbara => new lvec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.zzwy swizzling.
        /// </summary>
        public lvec4 zzwy => new lvec4(z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.bbag swizzling (equivalent to lvec4.zzwy).
        /// </summary>
        public lvec4 bbag => new lvec4(z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.zzwyx swizzling.
        /// </summary>
        public lvec5 zzwyx => new lvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.bbagr swizzling (equivalent to lvec4.zzwyx).
        /// </summary>
        public lvec5 bbagr => new lvec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.zzwyy swizzling.
        /// </summary>
        public lvec5 zzwyy => new lvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.bbagg swizzling (equivalent to lvec4.zzwyy).
        /// </summary>
        public lvec5 bbagg => new lvec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.zzwyz swizzling.
        /// </summary>
        public lvec5 zzwyz => new lvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.bbagb swizzling (equivalent to lvec4.zzwyz).
        /// </summary>
        public lvec5 bbagb => new lvec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.zzwyw swizzling.
        /// </summary>
        public lvec5 zzwyw => new lvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.bbaga swizzling (equivalent to lvec4.zzwyw).
        /// </summary>
        public lvec5 bbaga => new lvec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.zzwz swizzling.
        /// </summary>
        public lvec4 zzwz => new lvec4(z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.bbab swizzling (equivalent to lvec4.zzwz).
        /// </summary>
        public lvec4 bbab => new lvec4(z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.zzwzx swizzling.
        /// </summary>
        public lvec5 zzwzx => new lvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.bbabr swizzling (equivalent to lvec4.zzwzx).
        /// </summary>
        public lvec5 bbabr => new lvec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.zzwzy swizzling.
        /// </summary>
        public lvec5 zzwzy => new lvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.bbabg swizzling (equivalent to lvec4.zzwzy).
        /// </summary>
        public lvec5 bbabg => new lvec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.zzwzz swizzling.
        /// </summary>
        public lvec5 zzwzz => new lvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.bbabb swizzling (equivalent to lvec4.zzwzz).
        /// </summary>
        public lvec5 bbabb => new lvec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.zzwzw swizzling.
        /// </summary>
        public lvec5 zzwzw => new lvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.bbaba swizzling (equivalent to lvec4.zzwzw).
        /// </summary>
        public lvec5 bbaba => new lvec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.zzww swizzling.
        /// </summary>
        public lvec4 zzww => new lvec4(z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.bbaa swizzling (equivalent to lvec4.zzww).
        /// </summary>
        public lvec4 bbaa => new lvec4(z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.zzwwx swizzling.
        /// </summary>
        public lvec5 zzwwx => new lvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.bbaar swizzling (equivalent to lvec4.zzwwx).
        /// </summary>
        public lvec5 bbaar => new lvec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.zzwwy swizzling.
        /// </summary>
        public lvec5 zzwwy => new lvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.bbaag swizzling (equivalent to lvec4.zzwwy).
        /// </summary>
        public lvec5 bbaag => new lvec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.zzwwz swizzling.
        /// </summary>
        public lvec5 zzwwz => new lvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.bbaab swizzling (equivalent to lvec4.zzwwz).
        /// </summary>
        public lvec5 bbaab => new lvec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.zzwww swizzling.
        /// </summary>
        public lvec5 zzwww => new lvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.bbaaa swizzling (equivalent to lvec4.zzwww).
        /// </summary>
        public lvec5 bbaaa => new lvec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.zw swizzling.
        /// </summary>
        public lvec2 zw => new lvec2(z, w);
        
        /// <summary>
        /// Returns lvec4.ba swizzling (equivalent to lvec4.zw).
        /// </summary>
        public lvec2 ba => new lvec2(z, w);
        
        /// <summary>
        /// Returns lvec4.zwx swizzling.
        /// </summary>
        public lvec3 zwx => new lvec3(z, w, x);
        
        /// <summary>
        /// Returns lvec4.bar swizzling (equivalent to lvec4.zwx).
        /// </summary>
        public lvec3 bar => new lvec3(z, w, x);
        
        /// <summary>
        /// Returns lvec4.zwxx swizzling.
        /// </summary>
        public lvec4 zwxx => new lvec4(z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.barr swizzling (equivalent to lvec4.zwxx).
        /// </summary>
        public lvec4 barr => new lvec4(z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.zwxxx swizzling.
        /// </summary>
        public lvec5 zwxxx => new lvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.barrr swizzling (equivalent to lvec4.zwxxx).
        /// </summary>
        public lvec5 barrr => new lvec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.zwxxy swizzling.
        /// </summary>
        public lvec5 zwxxy => new lvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.barrg swizzling (equivalent to lvec4.zwxxy).
        /// </summary>
        public lvec5 barrg => new lvec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.zwxxz swizzling.
        /// </summary>
        public lvec5 zwxxz => new lvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.barrb swizzling (equivalent to lvec4.zwxxz).
        /// </summary>
        public lvec5 barrb => new lvec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.zwxxw swizzling.
        /// </summary>
        public lvec5 zwxxw => new lvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.barra swizzling (equivalent to lvec4.zwxxw).
        /// </summary>
        public lvec5 barra => new lvec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.zwxy swizzling.
        /// </summary>
        public lvec4 zwxy => new lvec4(z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.barg swizzling (equivalent to lvec4.zwxy).
        /// </summary>
        public lvec4 barg => new lvec4(z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.zwxyx swizzling.
        /// </summary>
        public lvec5 zwxyx => new lvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.bargr swizzling (equivalent to lvec4.zwxyx).
        /// </summary>
        public lvec5 bargr => new lvec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.zwxyy swizzling.
        /// </summary>
        public lvec5 zwxyy => new lvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.bargg swizzling (equivalent to lvec4.zwxyy).
        /// </summary>
        public lvec5 bargg => new lvec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.zwxyz swizzling.
        /// </summary>
        public lvec5 zwxyz => new lvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.bargb swizzling (equivalent to lvec4.zwxyz).
        /// </summary>
        public lvec5 bargb => new lvec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.zwxyw swizzling.
        /// </summary>
        public lvec5 zwxyw => new lvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.barga swizzling (equivalent to lvec4.zwxyw).
        /// </summary>
        public lvec5 barga => new lvec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.zwxz swizzling.
        /// </summary>
        public lvec4 zwxz => new lvec4(z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.barb swizzling (equivalent to lvec4.zwxz).
        /// </summary>
        public lvec4 barb => new lvec4(z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.zwxzx swizzling.
        /// </summary>
        public lvec5 zwxzx => new lvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.barbr swizzling (equivalent to lvec4.zwxzx).
        /// </summary>
        public lvec5 barbr => new lvec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.zwxzy swizzling.
        /// </summary>
        public lvec5 zwxzy => new lvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.barbg swizzling (equivalent to lvec4.zwxzy).
        /// </summary>
        public lvec5 barbg => new lvec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.zwxzz swizzling.
        /// </summary>
        public lvec5 zwxzz => new lvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.barbb swizzling (equivalent to lvec4.zwxzz).
        /// </summary>
        public lvec5 barbb => new lvec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.zwxzw swizzling.
        /// </summary>
        public lvec5 zwxzw => new lvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.barba swizzling (equivalent to lvec4.zwxzw).
        /// </summary>
        public lvec5 barba => new lvec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.zwxw swizzling.
        /// </summary>
        public lvec4 zwxw => new lvec4(z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.bara swizzling (equivalent to lvec4.zwxw).
        /// </summary>
        public lvec4 bara => new lvec4(z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.zwxwx swizzling.
        /// </summary>
        public lvec5 zwxwx => new lvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.barar swizzling (equivalent to lvec4.zwxwx).
        /// </summary>
        public lvec5 barar => new lvec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.zwxwy swizzling.
        /// </summary>
        public lvec5 zwxwy => new lvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.barag swizzling (equivalent to lvec4.zwxwy).
        /// </summary>
        public lvec5 barag => new lvec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.zwxwz swizzling.
        /// </summary>
        public lvec5 zwxwz => new lvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.barab swizzling (equivalent to lvec4.zwxwz).
        /// </summary>
        public lvec5 barab => new lvec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.zwxww swizzling.
        /// </summary>
        public lvec5 zwxww => new lvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.baraa swizzling (equivalent to lvec4.zwxww).
        /// </summary>
        public lvec5 baraa => new lvec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.zwy swizzling.
        /// </summary>
        public lvec3 zwy => new lvec3(z, w, y);
        
        /// <summary>
        /// Returns lvec4.bag swizzling (equivalent to lvec4.zwy).
        /// </summary>
        public lvec3 bag => new lvec3(z, w, y);
        
        /// <summary>
        /// Returns lvec4.zwyx swizzling.
        /// </summary>
        public lvec4 zwyx => new lvec4(z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.bagr swizzling (equivalent to lvec4.zwyx).
        /// </summary>
        public lvec4 bagr => new lvec4(z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.zwyxx swizzling.
        /// </summary>
        public lvec5 zwyxx => new lvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.bagrr swizzling (equivalent to lvec4.zwyxx).
        /// </summary>
        public lvec5 bagrr => new lvec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.zwyxy swizzling.
        /// </summary>
        public lvec5 zwyxy => new lvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.bagrg swizzling (equivalent to lvec4.zwyxy).
        /// </summary>
        public lvec5 bagrg => new lvec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.zwyxz swizzling.
        /// </summary>
        public lvec5 zwyxz => new lvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.bagrb swizzling (equivalent to lvec4.zwyxz).
        /// </summary>
        public lvec5 bagrb => new lvec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.zwyxw swizzling.
        /// </summary>
        public lvec5 zwyxw => new lvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.bagra swizzling (equivalent to lvec4.zwyxw).
        /// </summary>
        public lvec5 bagra => new lvec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.zwyy swizzling.
        /// </summary>
        public lvec4 zwyy => new lvec4(z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.bagg swizzling (equivalent to lvec4.zwyy).
        /// </summary>
        public lvec4 bagg => new lvec4(z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.zwyyx swizzling.
        /// </summary>
        public lvec5 zwyyx => new lvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.baggr swizzling (equivalent to lvec4.zwyyx).
        /// </summary>
        public lvec5 baggr => new lvec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.zwyyy swizzling.
        /// </summary>
        public lvec5 zwyyy => new lvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.baggg swizzling (equivalent to lvec4.zwyyy).
        /// </summary>
        public lvec5 baggg => new lvec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.zwyyz swizzling.
        /// </summary>
        public lvec5 zwyyz => new lvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.baggb swizzling (equivalent to lvec4.zwyyz).
        /// </summary>
        public lvec5 baggb => new lvec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.zwyyw swizzling.
        /// </summary>
        public lvec5 zwyyw => new lvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.bagga swizzling (equivalent to lvec4.zwyyw).
        /// </summary>
        public lvec5 bagga => new lvec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.zwyz swizzling.
        /// </summary>
        public lvec4 zwyz => new lvec4(z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.bagb swizzling (equivalent to lvec4.zwyz).
        /// </summary>
        public lvec4 bagb => new lvec4(z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.zwyzx swizzling.
        /// </summary>
        public lvec5 zwyzx => new lvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.bagbr swizzling (equivalent to lvec4.zwyzx).
        /// </summary>
        public lvec5 bagbr => new lvec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.zwyzy swizzling.
        /// </summary>
        public lvec5 zwyzy => new lvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.bagbg swizzling (equivalent to lvec4.zwyzy).
        /// </summary>
        public lvec5 bagbg => new lvec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.zwyzz swizzling.
        /// </summary>
        public lvec5 zwyzz => new lvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.bagbb swizzling (equivalent to lvec4.zwyzz).
        /// </summary>
        public lvec5 bagbb => new lvec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.zwyzw swizzling.
        /// </summary>
        public lvec5 zwyzw => new lvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.bagba swizzling (equivalent to lvec4.zwyzw).
        /// </summary>
        public lvec5 bagba => new lvec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.zwyw swizzling.
        /// </summary>
        public lvec4 zwyw => new lvec4(z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.baga swizzling (equivalent to lvec4.zwyw).
        /// </summary>
        public lvec4 baga => new lvec4(z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.zwywx swizzling.
        /// </summary>
        public lvec5 zwywx => new lvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.bagar swizzling (equivalent to lvec4.zwywx).
        /// </summary>
        public lvec5 bagar => new lvec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.zwywy swizzling.
        /// </summary>
        public lvec5 zwywy => new lvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.bagag swizzling (equivalent to lvec4.zwywy).
        /// </summary>
        public lvec5 bagag => new lvec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.zwywz swizzling.
        /// </summary>
        public lvec5 zwywz => new lvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.bagab swizzling (equivalent to lvec4.zwywz).
        /// </summary>
        public lvec5 bagab => new lvec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.zwyww swizzling.
        /// </summary>
        public lvec5 zwyww => new lvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.bagaa swizzling (equivalent to lvec4.zwyww).
        /// </summary>
        public lvec5 bagaa => new lvec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.zwz swizzling.
        /// </summary>
        public lvec3 zwz => new lvec3(z, w, z);
        
        /// <summary>
        /// Returns lvec4.bab swizzling (equivalent to lvec4.zwz).
        /// </summary>
        public lvec3 bab => new lvec3(z, w, z);
        
        /// <summary>
        /// Returns lvec4.zwzx swizzling.
        /// </summary>
        public lvec4 zwzx => new lvec4(z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.babr swizzling (equivalent to lvec4.zwzx).
        /// </summary>
        public lvec4 babr => new lvec4(z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.zwzxx swizzling.
        /// </summary>
        public lvec5 zwzxx => new lvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.babrr swizzling (equivalent to lvec4.zwzxx).
        /// </summary>
        public lvec5 babrr => new lvec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.zwzxy swizzling.
        /// </summary>
        public lvec5 zwzxy => new lvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.babrg swizzling (equivalent to lvec4.zwzxy).
        /// </summary>
        public lvec5 babrg => new lvec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.zwzxz swizzling.
        /// </summary>
        public lvec5 zwzxz => new lvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.babrb swizzling (equivalent to lvec4.zwzxz).
        /// </summary>
        public lvec5 babrb => new lvec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.zwzxw swizzling.
        /// </summary>
        public lvec5 zwzxw => new lvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.babra swizzling (equivalent to lvec4.zwzxw).
        /// </summary>
        public lvec5 babra => new lvec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.zwzy swizzling.
        /// </summary>
        public lvec4 zwzy => new lvec4(z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.babg swizzling (equivalent to lvec4.zwzy).
        /// </summary>
        public lvec4 babg => new lvec4(z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.zwzyx swizzling.
        /// </summary>
        public lvec5 zwzyx => new lvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.babgr swizzling (equivalent to lvec4.zwzyx).
        /// </summary>
        public lvec5 babgr => new lvec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.zwzyy swizzling.
        /// </summary>
        public lvec5 zwzyy => new lvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.babgg swizzling (equivalent to lvec4.zwzyy).
        /// </summary>
        public lvec5 babgg => new lvec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.zwzyz swizzling.
        /// </summary>
        public lvec5 zwzyz => new lvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.babgb swizzling (equivalent to lvec4.zwzyz).
        /// </summary>
        public lvec5 babgb => new lvec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.zwzyw swizzling.
        /// </summary>
        public lvec5 zwzyw => new lvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.babga swizzling (equivalent to lvec4.zwzyw).
        /// </summary>
        public lvec5 babga => new lvec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.zwzz swizzling.
        /// </summary>
        public lvec4 zwzz => new lvec4(z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.babb swizzling (equivalent to lvec4.zwzz).
        /// </summary>
        public lvec4 babb => new lvec4(z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.zwzzx swizzling.
        /// </summary>
        public lvec5 zwzzx => new lvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.babbr swizzling (equivalent to lvec4.zwzzx).
        /// </summary>
        public lvec5 babbr => new lvec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.zwzzy swizzling.
        /// </summary>
        public lvec5 zwzzy => new lvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.babbg swizzling (equivalent to lvec4.zwzzy).
        /// </summary>
        public lvec5 babbg => new lvec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.zwzzz swizzling.
        /// </summary>
        public lvec5 zwzzz => new lvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.babbb swizzling (equivalent to lvec4.zwzzz).
        /// </summary>
        public lvec5 babbb => new lvec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.zwzzw swizzling.
        /// </summary>
        public lvec5 zwzzw => new lvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.babba swizzling (equivalent to lvec4.zwzzw).
        /// </summary>
        public lvec5 babba => new lvec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.zwzw swizzling.
        /// </summary>
        public lvec4 zwzw => new lvec4(z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.baba swizzling (equivalent to lvec4.zwzw).
        /// </summary>
        public lvec4 baba => new lvec4(z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.zwzwx swizzling.
        /// </summary>
        public lvec5 zwzwx => new lvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.babar swizzling (equivalent to lvec4.zwzwx).
        /// </summary>
        public lvec5 babar => new lvec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.zwzwy swizzling.
        /// </summary>
        public lvec5 zwzwy => new lvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.babag swizzling (equivalent to lvec4.zwzwy).
        /// </summary>
        public lvec5 babag => new lvec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.zwzwz swizzling.
        /// </summary>
        public lvec5 zwzwz => new lvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.babab swizzling (equivalent to lvec4.zwzwz).
        /// </summary>
        public lvec5 babab => new lvec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.zwzww swizzling.
        /// </summary>
        public lvec5 zwzww => new lvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.babaa swizzling (equivalent to lvec4.zwzww).
        /// </summary>
        public lvec5 babaa => new lvec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.zww swizzling.
        /// </summary>
        public lvec3 zww => new lvec3(z, w, w);
        
        /// <summary>
        /// Returns lvec4.baa swizzling (equivalent to lvec4.zww).
        /// </summary>
        public lvec3 baa => new lvec3(z, w, w);
        
        /// <summary>
        /// Returns lvec4.zwwx swizzling.
        /// </summary>
        public lvec4 zwwx => new lvec4(z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.baar swizzling (equivalent to lvec4.zwwx).
        /// </summary>
        public lvec4 baar => new lvec4(z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.zwwxx swizzling.
        /// </summary>
        public lvec5 zwwxx => new lvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.baarr swizzling (equivalent to lvec4.zwwxx).
        /// </summary>
        public lvec5 baarr => new lvec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.zwwxy swizzling.
        /// </summary>
        public lvec5 zwwxy => new lvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.baarg swizzling (equivalent to lvec4.zwwxy).
        /// </summary>
        public lvec5 baarg => new lvec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.zwwxz swizzling.
        /// </summary>
        public lvec5 zwwxz => new lvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.baarb swizzling (equivalent to lvec4.zwwxz).
        /// </summary>
        public lvec5 baarb => new lvec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.zwwxw swizzling.
        /// </summary>
        public lvec5 zwwxw => new lvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.baara swizzling (equivalent to lvec4.zwwxw).
        /// </summary>
        public lvec5 baara => new lvec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.zwwy swizzling.
        /// </summary>
        public lvec4 zwwy => new lvec4(z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.baag swizzling (equivalent to lvec4.zwwy).
        /// </summary>
        public lvec4 baag => new lvec4(z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.zwwyx swizzling.
        /// </summary>
        public lvec5 zwwyx => new lvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.baagr swizzling (equivalent to lvec4.zwwyx).
        /// </summary>
        public lvec5 baagr => new lvec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.zwwyy swizzling.
        /// </summary>
        public lvec5 zwwyy => new lvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.baagg swizzling (equivalent to lvec4.zwwyy).
        /// </summary>
        public lvec5 baagg => new lvec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.zwwyz swizzling.
        /// </summary>
        public lvec5 zwwyz => new lvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.baagb swizzling (equivalent to lvec4.zwwyz).
        /// </summary>
        public lvec5 baagb => new lvec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.zwwyw swizzling.
        /// </summary>
        public lvec5 zwwyw => new lvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.baaga swizzling (equivalent to lvec4.zwwyw).
        /// </summary>
        public lvec5 baaga => new lvec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.zwwz swizzling.
        /// </summary>
        public lvec4 zwwz => new lvec4(z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.baab swizzling (equivalent to lvec4.zwwz).
        /// </summary>
        public lvec4 baab => new lvec4(z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.zwwzx swizzling.
        /// </summary>
        public lvec5 zwwzx => new lvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.baabr swizzling (equivalent to lvec4.zwwzx).
        /// </summary>
        public lvec5 baabr => new lvec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.zwwzy swizzling.
        /// </summary>
        public lvec5 zwwzy => new lvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.baabg swizzling (equivalent to lvec4.zwwzy).
        /// </summary>
        public lvec5 baabg => new lvec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.zwwzz swizzling.
        /// </summary>
        public lvec5 zwwzz => new lvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.baabb swizzling (equivalent to lvec4.zwwzz).
        /// </summary>
        public lvec5 baabb => new lvec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.zwwzw swizzling.
        /// </summary>
        public lvec5 zwwzw => new lvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.baaba swizzling (equivalent to lvec4.zwwzw).
        /// </summary>
        public lvec5 baaba => new lvec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.zwww swizzling.
        /// </summary>
        public lvec4 zwww => new lvec4(z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.baaa swizzling (equivalent to lvec4.zwww).
        /// </summary>
        public lvec4 baaa => new lvec4(z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.zwwwx swizzling.
        /// </summary>
        public lvec5 zwwwx => new lvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.baaar swizzling (equivalent to lvec4.zwwwx).
        /// </summary>
        public lvec5 baaar => new lvec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.zwwwy swizzling.
        /// </summary>
        public lvec5 zwwwy => new lvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.baaag swizzling (equivalent to lvec4.zwwwy).
        /// </summary>
        public lvec5 baaag => new lvec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.zwwwz swizzling.
        /// </summary>
        public lvec5 zwwwz => new lvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.baaab swizzling (equivalent to lvec4.zwwwz).
        /// </summary>
        public lvec5 baaab => new lvec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.zwwww swizzling.
        /// </summary>
        public lvec5 zwwww => new lvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns lvec4.baaaa swizzling (equivalent to lvec4.zwwww).
        /// </summary>
        public lvec5 baaaa => new lvec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns lvec4.wx swizzling.
        /// </summary>
        public lvec2 wx => new lvec2(w, x);
        
        /// <summary>
        /// Returns lvec4.ar swizzling (equivalent to lvec4.wx).
        /// </summary>
        public lvec2 ar => new lvec2(w, x);
        
        /// <summary>
        /// Returns lvec4.wxx swizzling.
        /// </summary>
        public lvec3 wxx => new lvec3(w, x, x);
        
        /// <summary>
        /// Returns lvec4.arr swizzling (equivalent to lvec4.wxx).
        /// </summary>
        public lvec3 arr => new lvec3(w, x, x);
        
        /// <summary>
        /// Returns lvec4.wxxx swizzling.
        /// </summary>
        public lvec4 wxxx => new lvec4(w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.arrr swizzling (equivalent to lvec4.wxxx).
        /// </summary>
        public lvec4 arrr => new lvec4(w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.wxxxx swizzling.
        /// </summary>
        public lvec5 wxxxx => new lvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.arrrr swizzling (equivalent to lvec4.wxxxx).
        /// </summary>
        public lvec5 arrrr => new lvec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.wxxxy swizzling.
        /// </summary>
        public lvec5 wxxxy => new lvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.arrrg swizzling (equivalent to lvec4.wxxxy).
        /// </summary>
        public lvec5 arrrg => new lvec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.wxxxz swizzling.
        /// </summary>
        public lvec5 wxxxz => new lvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.arrrb swizzling (equivalent to lvec4.wxxxz).
        /// </summary>
        public lvec5 arrrb => new lvec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.wxxxw swizzling.
        /// </summary>
        public lvec5 wxxxw => new lvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.arrra swizzling (equivalent to lvec4.wxxxw).
        /// </summary>
        public lvec5 arrra => new lvec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.wxxy swizzling.
        /// </summary>
        public lvec4 wxxy => new lvec4(w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.arrg swizzling (equivalent to lvec4.wxxy).
        /// </summary>
        public lvec4 arrg => new lvec4(w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.wxxyx swizzling.
        /// </summary>
        public lvec5 wxxyx => new lvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.arrgr swizzling (equivalent to lvec4.wxxyx).
        /// </summary>
        public lvec5 arrgr => new lvec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.wxxyy swizzling.
        /// </summary>
        public lvec5 wxxyy => new lvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.arrgg swizzling (equivalent to lvec4.wxxyy).
        /// </summary>
        public lvec5 arrgg => new lvec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.wxxyz swizzling.
        /// </summary>
        public lvec5 wxxyz => new lvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.arrgb swizzling (equivalent to lvec4.wxxyz).
        /// </summary>
        public lvec5 arrgb => new lvec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.wxxyw swizzling.
        /// </summary>
        public lvec5 wxxyw => new lvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.arrga swizzling (equivalent to lvec4.wxxyw).
        /// </summary>
        public lvec5 arrga => new lvec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.wxxz swizzling.
        /// </summary>
        public lvec4 wxxz => new lvec4(w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.arrb swizzling (equivalent to lvec4.wxxz).
        /// </summary>
        public lvec4 arrb => new lvec4(w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.wxxzx swizzling.
        /// </summary>
        public lvec5 wxxzx => new lvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.arrbr swizzling (equivalent to lvec4.wxxzx).
        /// </summary>
        public lvec5 arrbr => new lvec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.wxxzy swizzling.
        /// </summary>
        public lvec5 wxxzy => new lvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.arrbg swizzling (equivalent to lvec4.wxxzy).
        /// </summary>
        public lvec5 arrbg => new lvec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.wxxzz swizzling.
        /// </summary>
        public lvec5 wxxzz => new lvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.arrbb swizzling (equivalent to lvec4.wxxzz).
        /// </summary>
        public lvec5 arrbb => new lvec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.wxxzw swizzling.
        /// </summary>
        public lvec5 wxxzw => new lvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.arrba swizzling (equivalent to lvec4.wxxzw).
        /// </summary>
        public lvec5 arrba => new lvec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.wxxw swizzling.
        /// </summary>
        public lvec4 wxxw => new lvec4(w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.arra swizzling (equivalent to lvec4.wxxw).
        /// </summary>
        public lvec4 arra => new lvec4(w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.wxxwx swizzling.
        /// </summary>
        public lvec5 wxxwx => new lvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.arrar swizzling (equivalent to lvec4.wxxwx).
        /// </summary>
        public lvec5 arrar => new lvec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.wxxwy swizzling.
        /// </summary>
        public lvec5 wxxwy => new lvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.arrag swizzling (equivalent to lvec4.wxxwy).
        /// </summary>
        public lvec5 arrag => new lvec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.wxxwz swizzling.
        /// </summary>
        public lvec5 wxxwz => new lvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.arrab swizzling (equivalent to lvec4.wxxwz).
        /// </summary>
        public lvec5 arrab => new lvec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.wxxww swizzling.
        /// </summary>
        public lvec5 wxxww => new lvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.arraa swizzling (equivalent to lvec4.wxxww).
        /// </summary>
        public lvec5 arraa => new lvec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.wxy swizzling.
        /// </summary>
        public lvec3 wxy => new lvec3(w, x, y);
        
        /// <summary>
        /// Returns lvec4.arg swizzling (equivalent to lvec4.wxy).
        /// </summary>
        public lvec3 arg => new lvec3(w, x, y);
        
        /// <summary>
        /// Returns lvec4.wxyx swizzling.
        /// </summary>
        public lvec4 wxyx => new lvec4(w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.argr swizzling (equivalent to lvec4.wxyx).
        /// </summary>
        public lvec4 argr => new lvec4(w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.wxyxx swizzling.
        /// </summary>
        public lvec5 wxyxx => new lvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.argrr swizzling (equivalent to lvec4.wxyxx).
        /// </summary>
        public lvec5 argrr => new lvec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.wxyxy swizzling.
        /// </summary>
        public lvec5 wxyxy => new lvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.argrg swizzling (equivalent to lvec4.wxyxy).
        /// </summary>
        public lvec5 argrg => new lvec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.wxyxz swizzling.
        /// </summary>
        public lvec5 wxyxz => new lvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.argrb swizzling (equivalent to lvec4.wxyxz).
        /// </summary>
        public lvec5 argrb => new lvec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.wxyxw swizzling.
        /// </summary>
        public lvec5 wxyxw => new lvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.argra swizzling (equivalent to lvec4.wxyxw).
        /// </summary>
        public lvec5 argra => new lvec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.wxyy swizzling.
        /// </summary>
        public lvec4 wxyy => new lvec4(w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.argg swizzling (equivalent to lvec4.wxyy).
        /// </summary>
        public lvec4 argg => new lvec4(w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.wxyyx swizzling.
        /// </summary>
        public lvec5 wxyyx => new lvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.arggr swizzling (equivalent to lvec4.wxyyx).
        /// </summary>
        public lvec5 arggr => new lvec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.wxyyy swizzling.
        /// </summary>
        public lvec5 wxyyy => new lvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.arggg swizzling (equivalent to lvec4.wxyyy).
        /// </summary>
        public lvec5 arggg => new lvec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.wxyyz swizzling.
        /// </summary>
        public lvec5 wxyyz => new lvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.arggb swizzling (equivalent to lvec4.wxyyz).
        /// </summary>
        public lvec5 arggb => new lvec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.wxyyw swizzling.
        /// </summary>
        public lvec5 wxyyw => new lvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.argga swizzling (equivalent to lvec4.wxyyw).
        /// </summary>
        public lvec5 argga => new lvec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.wxyz swizzling.
        /// </summary>
        public lvec4 wxyz => new lvec4(w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.argb swizzling (equivalent to lvec4.wxyz).
        /// </summary>
        public lvec4 argb => new lvec4(w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.wxyzx swizzling.
        /// </summary>
        public lvec5 wxyzx => new lvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.argbr swizzling (equivalent to lvec4.wxyzx).
        /// </summary>
        public lvec5 argbr => new lvec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.wxyzy swizzling.
        /// </summary>
        public lvec5 wxyzy => new lvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.argbg swizzling (equivalent to lvec4.wxyzy).
        /// </summary>
        public lvec5 argbg => new lvec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.wxyzz swizzling.
        /// </summary>
        public lvec5 wxyzz => new lvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.argbb swizzling (equivalent to lvec4.wxyzz).
        /// </summary>
        public lvec5 argbb => new lvec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.wxyzw swizzling.
        /// </summary>
        public lvec5 wxyzw => new lvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.argba swizzling (equivalent to lvec4.wxyzw).
        /// </summary>
        public lvec5 argba => new lvec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.wxyw swizzling.
        /// </summary>
        public lvec4 wxyw => new lvec4(w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.arga swizzling (equivalent to lvec4.wxyw).
        /// </summary>
        public lvec4 arga => new lvec4(w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.wxywx swizzling.
        /// </summary>
        public lvec5 wxywx => new lvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.argar swizzling (equivalent to lvec4.wxywx).
        /// </summary>
        public lvec5 argar => new lvec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.wxywy swizzling.
        /// </summary>
        public lvec5 wxywy => new lvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.argag swizzling (equivalent to lvec4.wxywy).
        /// </summary>
        public lvec5 argag => new lvec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.wxywz swizzling.
        /// </summary>
        public lvec5 wxywz => new lvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.argab swizzling (equivalent to lvec4.wxywz).
        /// </summary>
        public lvec5 argab => new lvec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.wxyww swizzling.
        /// </summary>
        public lvec5 wxyww => new lvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.argaa swizzling (equivalent to lvec4.wxyww).
        /// </summary>
        public lvec5 argaa => new lvec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.wxz swizzling.
        /// </summary>
        public lvec3 wxz => new lvec3(w, x, z);
        
        /// <summary>
        /// Returns lvec4.arb swizzling (equivalent to lvec4.wxz).
        /// </summary>
        public lvec3 arb => new lvec3(w, x, z);
        
        /// <summary>
        /// Returns lvec4.wxzx swizzling.
        /// </summary>
        public lvec4 wxzx => new lvec4(w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.arbr swizzling (equivalent to lvec4.wxzx).
        /// </summary>
        public lvec4 arbr => new lvec4(w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.wxzxx swizzling.
        /// </summary>
        public lvec5 wxzxx => new lvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.arbrr swizzling (equivalent to lvec4.wxzxx).
        /// </summary>
        public lvec5 arbrr => new lvec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.wxzxy swizzling.
        /// </summary>
        public lvec5 wxzxy => new lvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.arbrg swizzling (equivalent to lvec4.wxzxy).
        /// </summary>
        public lvec5 arbrg => new lvec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.wxzxz swizzling.
        /// </summary>
        public lvec5 wxzxz => new lvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.arbrb swizzling (equivalent to lvec4.wxzxz).
        /// </summary>
        public lvec5 arbrb => new lvec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.wxzxw swizzling.
        /// </summary>
        public lvec5 wxzxw => new lvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.arbra swizzling (equivalent to lvec4.wxzxw).
        /// </summary>
        public lvec5 arbra => new lvec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.wxzy swizzling.
        /// </summary>
        public lvec4 wxzy => new lvec4(w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.arbg swizzling (equivalent to lvec4.wxzy).
        /// </summary>
        public lvec4 arbg => new lvec4(w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.wxzyx swizzling.
        /// </summary>
        public lvec5 wxzyx => new lvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.arbgr swizzling (equivalent to lvec4.wxzyx).
        /// </summary>
        public lvec5 arbgr => new lvec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.wxzyy swizzling.
        /// </summary>
        public lvec5 wxzyy => new lvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.arbgg swizzling (equivalent to lvec4.wxzyy).
        /// </summary>
        public lvec5 arbgg => new lvec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.wxzyz swizzling.
        /// </summary>
        public lvec5 wxzyz => new lvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.arbgb swizzling (equivalent to lvec4.wxzyz).
        /// </summary>
        public lvec5 arbgb => new lvec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.wxzyw swizzling.
        /// </summary>
        public lvec5 wxzyw => new lvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.arbga swizzling (equivalent to lvec4.wxzyw).
        /// </summary>
        public lvec5 arbga => new lvec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.wxzz swizzling.
        /// </summary>
        public lvec4 wxzz => new lvec4(w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.arbb swizzling (equivalent to lvec4.wxzz).
        /// </summary>
        public lvec4 arbb => new lvec4(w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.wxzzx swizzling.
        /// </summary>
        public lvec5 wxzzx => new lvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.arbbr swizzling (equivalent to lvec4.wxzzx).
        /// </summary>
        public lvec5 arbbr => new lvec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.wxzzy swizzling.
        /// </summary>
        public lvec5 wxzzy => new lvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.arbbg swizzling (equivalent to lvec4.wxzzy).
        /// </summary>
        public lvec5 arbbg => new lvec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.wxzzz swizzling.
        /// </summary>
        public lvec5 wxzzz => new lvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.arbbb swizzling (equivalent to lvec4.wxzzz).
        /// </summary>
        public lvec5 arbbb => new lvec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.wxzzw swizzling.
        /// </summary>
        public lvec5 wxzzw => new lvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.arbba swizzling (equivalent to lvec4.wxzzw).
        /// </summary>
        public lvec5 arbba => new lvec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.wxzw swizzling.
        /// </summary>
        public lvec4 wxzw => new lvec4(w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.arba swizzling (equivalent to lvec4.wxzw).
        /// </summary>
        public lvec4 arba => new lvec4(w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.wxzwx swizzling.
        /// </summary>
        public lvec5 wxzwx => new lvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.arbar swizzling (equivalent to lvec4.wxzwx).
        /// </summary>
        public lvec5 arbar => new lvec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.wxzwy swizzling.
        /// </summary>
        public lvec5 wxzwy => new lvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.arbag swizzling (equivalent to lvec4.wxzwy).
        /// </summary>
        public lvec5 arbag => new lvec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.wxzwz swizzling.
        /// </summary>
        public lvec5 wxzwz => new lvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.arbab swizzling (equivalent to lvec4.wxzwz).
        /// </summary>
        public lvec5 arbab => new lvec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.wxzww swizzling.
        /// </summary>
        public lvec5 wxzww => new lvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.arbaa swizzling (equivalent to lvec4.wxzww).
        /// </summary>
        public lvec5 arbaa => new lvec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.wxw swizzling.
        /// </summary>
        public lvec3 wxw => new lvec3(w, x, w);
        
        /// <summary>
        /// Returns lvec4.ara swizzling (equivalent to lvec4.wxw).
        /// </summary>
        public lvec3 ara => new lvec3(w, x, w);
        
        /// <summary>
        /// Returns lvec4.wxwx swizzling.
        /// </summary>
        public lvec4 wxwx => new lvec4(w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.arar swizzling (equivalent to lvec4.wxwx).
        /// </summary>
        public lvec4 arar => new lvec4(w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.wxwxx swizzling.
        /// </summary>
        public lvec5 wxwxx => new lvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.ararr swizzling (equivalent to lvec4.wxwxx).
        /// </summary>
        public lvec5 ararr => new lvec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.wxwxy swizzling.
        /// </summary>
        public lvec5 wxwxy => new lvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.ararg swizzling (equivalent to lvec4.wxwxy).
        /// </summary>
        public lvec5 ararg => new lvec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.wxwxz swizzling.
        /// </summary>
        public lvec5 wxwxz => new lvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.ararb swizzling (equivalent to lvec4.wxwxz).
        /// </summary>
        public lvec5 ararb => new lvec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.wxwxw swizzling.
        /// </summary>
        public lvec5 wxwxw => new lvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.arara swizzling (equivalent to lvec4.wxwxw).
        /// </summary>
        public lvec5 arara => new lvec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.wxwy swizzling.
        /// </summary>
        public lvec4 wxwy => new lvec4(w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.arag swizzling (equivalent to lvec4.wxwy).
        /// </summary>
        public lvec4 arag => new lvec4(w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.wxwyx swizzling.
        /// </summary>
        public lvec5 wxwyx => new lvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.aragr swizzling (equivalent to lvec4.wxwyx).
        /// </summary>
        public lvec5 aragr => new lvec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.wxwyy swizzling.
        /// </summary>
        public lvec5 wxwyy => new lvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.aragg swizzling (equivalent to lvec4.wxwyy).
        /// </summary>
        public lvec5 aragg => new lvec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.wxwyz swizzling.
        /// </summary>
        public lvec5 wxwyz => new lvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.aragb swizzling (equivalent to lvec4.wxwyz).
        /// </summary>
        public lvec5 aragb => new lvec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.wxwyw swizzling.
        /// </summary>
        public lvec5 wxwyw => new lvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.araga swizzling (equivalent to lvec4.wxwyw).
        /// </summary>
        public lvec5 araga => new lvec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.wxwz swizzling.
        /// </summary>
        public lvec4 wxwz => new lvec4(w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.arab swizzling (equivalent to lvec4.wxwz).
        /// </summary>
        public lvec4 arab => new lvec4(w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.wxwzx swizzling.
        /// </summary>
        public lvec5 wxwzx => new lvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.arabr swizzling (equivalent to lvec4.wxwzx).
        /// </summary>
        public lvec5 arabr => new lvec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.wxwzy swizzling.
        /// </summary>
        public lvec5 wxwzy => new lvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.arabg swizzling (equivalent to lvec4.wxwzy).
        /// </summary>
        public lvec5 arabg => new lvec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.wxwzz swizzling.
        /// </summary>
        public lvec5 wxwzz => new lvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.arabb swizzling (equivalent to lvec4.wxwzz).
        /// </summary>
        public lvec5 arabb => new lvec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.wxwzw swizzling.
        /// </summary>
        public lvec5 wxwzw => new lvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.araba swizzling (equivalent to lvec4.wxwzw).
        /// </summary>
        public lvec5 araba => new lvec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.wxww swizzling.
        /// </summary>
        public lvec4 wxww => new lvec4(w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.araa swizzling (equivalent to lvec4.wxww).
        /// </summary>
        public lvec4 araa => new lvec4(w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.wxwwx swizzling.
        /// </summary>
        public lvec5 wxwwx => new lvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.araar swizzling (equivalent to lvec4.wxwwx).
        /// </summary>
        public lvec5 araar => new lvec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.wxwwy swizzling.
        /// </summary>
        public lvec5 wxwwy => new lvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.araag swizzling (equivalent to lvec4.wxwwy).
        /// </summary>
        public lvec5 araag => new lvec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.wxwwz swizzling.
        /// </summary>
        public lvec5 wxwwz => new lvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.araab swizzling (equivalent to lvec4.wxwwz).
        /// </summary>
        public lvec5 araab => new lvec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.wxwww swizzling.
        /// </summary>
        public lvec5 wxwww => new lvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.araaa swizzling (equivalent to lvec4.wxwww).
        /// </summary>
        public lvec5 araaa => new lvec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.wy swizzling.
        /// </summary>
        public lvec2 wy => new lvec2(w, y);
        
        /// <summary>
        /// Returns lvec4.ag swizzling (equivalent to lvec4.wy).
        /// </summary>
        public lvec2 ag => new lvec2(w, y);
        
        /// <summary>
        /// Returns lvec4.wyx swizzling.
        /// </summary>
        public lvec3 wyx => new lvec3(w, y, x);
        
        /// <summary>
        /// Returns lvec4.agr swizzling (equivalent to lvec4.wyx).
        /// </summary>
        public lvec3 agr => new lvec3(w, y, x);
        
        /// <summary>
        /// Returns lvec4.wyxx swizzling.
        /// </summary>
        public lvec4 wyxx => new lvec4(w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.agrr swizzling (equivalent to lvec4.wyxx).
        /// </summary>
        public lvec4 agrr => new lvec4(w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.wyxxx swizzling.
        /// </summary>
        public lvec5 wyxxx => new lvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.agrrr swizzling (equivalent to lvec4.wyxxx).
        /// </summary>
        public lvec5 agrrr => new lvec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.wyxxy swizzling.
        /// </summary>
        public lvec5 wyxxy => new lvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.agrrg swizzling (equivalent to lvec4.wyxxy).
        /// </summary>
        public lvec5 agrrg => new lvec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.wyxxz swizzling.
        /// </summary>
        public lvec5 wyxxz => new lvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.agrrb swizzling (equivalent to lvec4.wyxxz).
        /// </summary>
        public lvec5 agrrb => new lvec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.wyxxw swizzling.
        /// </summary>
        public lvec5 wyxxw => new lvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.agrra swizzling (equivalent to lvec4.wyxxw).
        /// </summary>
        public lvec5 agrra => new lvec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.wyxy swizzling.
        /// </summary>
        public lvec4 wyxy => new lvec4(w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.agrg swizzling (equivalent to lvec4.wyxy).
        /// </summary>
        public lvec4 agrg => new lvec4(w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.wyxyx swizzling.
        /// </summary>
        public lvec5 wyxyx => new lvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.agrgr swizzling (equivalent to lvec4.wyxyx).
        /// </summary>
        public lvec5 agrgr => new lvec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.wyxyy swizzling.
        /// </summary>
        public lvec5 wyxyy => new lvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.agrgg swizzling (equivalent to lvec4.wyxyy).
        /// </summary>
        public lvec5 agrgg => new lvec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.wyxyz swizzling.
        /// </summary>
        public lvec5 wyxyz => new lvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.agrgb swizzling (equivalent to lvec4.wyxyz).
        /// </summary>
        public lvec5 agrgb => new lvec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.wyxyw swizzling.
        /// </summary>
        public lvec5 wyxyw => new lvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.agrga swizzling (equivalent to lvec4.wyxyw).
        /// </summary>
        public lvec5 agrga => new lvec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.wyxz swizzling.
        /// </summary>
        public lvec4 wyxz => new lvec4(w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.agrb swizzling (equivalent to lvec4.wyxz).
        /// </summary>
        public lvec4 agrb => new lvec4(w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.wyxzx swizzling.
        /// </summary>
        public lvec5 wyxzx => new lvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.agrbr swizzling (equivalent to lvec4.wyxzx).
        /// </summary>
        public lvec5 agrbr => new lvec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.wyxzy swizzling.
        /// </summary>
        public lvec5 wyxzy => new lvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.agrbg swizzling (equivalent to lvec4.wyxzy).
        /// </summary>
        public lvec5 agrbg => new lvec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.wyxzz swizzling.
        /// </summary>
        public lvec5 wyxzz => new lvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.agrbb swizzling (equivalent to lvec4.wyxzz).
        /// </summary>
        public lvec5 agrbb => new lvec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.wyxzw swizzling.
        /// </summary>
        public lvec5 wyxzw => new lvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.agrba swizzling (equivalent to lvec4.wyxzw).
        /// </summary>
        public lvec5 agrba => new lvec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.wyxw swizzling.
        /// </summary>
        public lvec4 wyxw => new lvec4(w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.agra swizzling (equivalent to lvec4.wyxw).
        /// </summary>
        public lvec4 agra => new lvec4(w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.wyxwx swizzling.
        /// </summary>
        public lvec5 wyxwx => new lvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.agrar swizzling (equivalent to lvec4.wyxwx).
        /// </summary>
        public lvec5 agrar => new lvec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.wyxwy swizzling.
        /// </summary>
        public lvec5 wyxwy => new lvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.agrag swizzling (equivalent to lvec4.wyxwy).
        /// </summary>
        public lvec5 agrag => new lvec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.wyxwz swizzling.
        /// </summary>
        public lvec5 wyxwz => new lvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.agrab swizzling (equivalent to lvec4.wyxwz).
        /// </summary>
        public lvec5 agrab => new lvec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.wyxww swizzling.
        /// </summary>
        public lvec5 wyxww => new lvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.agraa swizzling (equivalent to lvec4.wyxww).
        /// </summary>
        public lvec5 agraa => new lvec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.wyy swizzling.
        /// </summary>
        public lvec3 wyy => new lvec3(w, y, y);
        
        /// <summary>
        /// Returns lvec4.agg swizzling (equivalent to lvec4.wyy).
        /// </summary>
        public lvec3 agg => new lvec3(w, y, y);
        
        /// <summary>
        /// Returns lvec4.wyyx swizzling.
        /// </summary>
        public lvec4 wyyx => new lvec4(w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.aggr swizzling (equivalent to lvec4.wyyx).
        /// </summary>
        public lvec4 aggr => new lvec4(w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.wyyxx swizzling.
        /// </summary>
        public lvec5 wyyxx => new lvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.aggrr swizzling (equivalent to lvec4.wyyxx).
        /// </summary>
        public lvec5 aggrr => new lvec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.wyyxy swizzling.
        /// </summary>
        public lvec5 wyyxy => new lvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.aggrg swizzling (equivalent to lvec4.wyyxy).
        /// </summary>
        public lvec5 aggrg => new lvec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.wyyxz swizzling.
        /// </summary>
        public lvec5 wyyxz => new lvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.aggrb swizzling (equivalent to lvec4.wyyxz).
        /// </summary>
        public lvec5 aggrb => new lvec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.wyyxw swizzling.
        /// </summary>
        public lvec5 wyyxw => new lvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.aggra swizzling (equivalent to lvec4.wyyxw).
        /// </summary>
        public lvec5 aggra => new lvec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.wyyy swizzling.
        /// </summary>
        public lvec4 wyyy => new lvec4(w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.aggg swizzling (equivalent to lvec4.wyyy).
        /// </summary>
        public lvec4 aggg => new lvec4(w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.wyyyx swizzling.
        /// </summary>
        public lvec5 wyyyx => new lvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.agggr swizzling (equivalent to lvec4.wyyyx).
        /// </summary>
        public lvec5 agggr => new lvec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.wyyyy swizzling.
        /// </summary>
        public lvec5 wyyyy => new lvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.agggg swizzling (equivalent to lvec4.wyyyy).
        /// </summary>
        public lvec5 agggg => new lvec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.wyyyz swizzling.
        /// </summary>
        public lvec5 wyyyz => new lvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.agggb swizzling (equivalent to lvec4.wyyyz).
        /// </summary>
        public lvec5 agggb => new lvec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.wyyyw swizzling.
        /// </summary>
        public lvec5 wyyyw => new lvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.aggga swizzling (equivalent to lvec4.wyyyw).
        /// </summary>
        public lvec5 aggga => new lvec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.wyyz swizzling.
        /// </summary>
        public lvec4 wyyz => new lvec4(w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.aggb swizzling (equivalent to lvec4.wyyz).
        /// </summary>
        public lvec4 aggb => new lvec4(w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.wyyzx swizzling.
        /// </summary>
        public lvec5 wyyzx => new lvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.aggbr swizzling (equivalent to lvec4.wyyzx).
        /// </summary>
        public lvec5 aggbr => new lvec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.wyyzy swizzling.
        /// </summary>
        public lvec5 wyyzy => new lvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.aggbg swizzling (equivalent to lvec4.wyyzy).
        /// </summary>
        public lvec5 aggbg => new lvec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.wyyzz swizzling.
        /// </summary>
        public lvec5 wyyzz => new lvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.aggbb swizzling (equivalent to lvec4.wyyzz).
        /// </summary>
        public lvec5 aggbb => new lvec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.wyyzw swizzling.
        /// </summary>
        public lvec5 wyyzw => new lvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.aggba swizzling (equivalent to lvec4.wyyzw).
        /// </summary>
        public lvec5 aggba => new lvec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.wyyw swizzling.
        /// </summary>
        public lvec4 wyyw => new lvec4(w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.agga swizzling (equivalent to lvec4.wyyw).
        /// </summary>
        public lvec4 agga => new lvec4(w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.wyywx swizzling.
        /// </summary>
        public lvec5 wyywx => new lvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.aggar swizzling (equivalent to lvec4.wyywx).
        /// </summary>
        public lvec5 aggar => new lvec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.wyywy swizzling.
        /// </summary>
        public lvec5 wyywy => new lvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.aggag swizzling (equivalent to lvec4.wyywy).
        /// </summary>
        public lvec5 aggag => new lvec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.wyywz swizzling.
        /// </summary>
        public lvec5 wyywz => new lvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.aggab swizzling (equivalent to lvec4.wyywz).
        /// </summary>
        public lvec5 aggab => new lvec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.wyyww swizzling.
        /// </summary>
        public lvec5 wyyww => new lvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.aggaa swizzling (equivalent to lvec4.wyyww).
        /// </summary>
        public lvec5 aggaa => new lvec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.wyz swizzling.
        /// </summary>
        public lvec3 wyz => new lvec3(w, y, z);
        
        /// <summary>
        /// Returns lvec4.agb swizzling (equivalent to lvec4.wyz).
        /// </summary>
        public lvec3 agb => new lvec3(w, y, z);
        
        /// <summary>
        /// Returns lvec4.wyzx swizzling.
        /// </summary>
        public lvec4 wyzx => new lvec4(w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.agbr swizzling (equivalent to lvec4.wyzx).
        /// </summary>
        public lvec4 agbr => new lvec4(w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.wyzxx swizzling.
        /// </summary>
        public lvec5 wyzxx => new lvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.agbrr swizzling (equivalent to lvec4.wyzxx).
        /// </summary>
        public lvec5 agbrr => new lvec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.wyzxy swizzling.
        /// </summary>
        public lvec5 wyzxy => new lvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.agbrg swizzling (equivalent to lvec4.wyzxy).
        /// </summary>
        public lvec5 agbrg => new lvec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.wyzxz swizzling.
        /// </summary>
        public lvec5 wyzxz => new lvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.agbrb swizzling (equivalent to lvec4.wyzxz).
        /// </summary>
        public lvec5 agbrb => new lvec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.wyzxw swizzling.
        /// </summary>
        public lvec5 wyzxw => new lvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.agbra swizzling (equivalent to lvec4.wyzxw).
        /// </summary>
        public lvec5 agbra => new lvec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.wyzy swizzling.
        /// </summary>
        public lvec4 wyzy => new lvec4(w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.agbg swizzling (equivalent to lvec4.wyzy).
        /// </summary>
        public lvec4 agbg => new lvec4(w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.wyzyx swizzling.
        /// </summary>
        public lvec5 wyzyx => new lvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.agbgr swizzling (equivalent to lvec4.wyzyx).
        /// </summary>
        public lvec5 agbgr => new lvec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.wyzyy swizzling.
        /// </summary>
        public lvec5 wyzyy => new lvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.agbgg swizzling (equivalent to lvec4.wyzyy).
        /// </summary>
        public lvec5 agbgg => new lvec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.wyzyz swizzling.
        /// </summary>
        public lvec5 wyzyz => new lvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.agbgb swizzling (equivalent to lvec4.wyzyz).
        /// </summary>
        public lvec5 agbgb => new lvec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.wyzyw swizzling.
        /// </summary>
        public lvec5 wyzyw => new lvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.agbga swizzling (equivalent to lvec4.wyzyw).
        /// </summary>
        public lvec5 agbga => new lvec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.wyzz swizzling.
        /// </summary>
        public lvec4 wyzz => new lvec4(w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.agbb swizzling (equivalent to lvec4.wyzz).
        /// </summary>
        public lvec4 agbb => new lvec4(w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.wyzzx swizzling.
        /// </summary>
        public lvec5 wyzzx => new lvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.agbbr swizzling (equivalent to lvec4.wyzzx).
        /// </summary>
        public lvec5 agbbr => new lvec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.wyzzy swizzling.
        /// </summary>
        public lvec5 wyzzy => new lvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.agbbg swizzling (equivalent to lvec4.wyzzy).
        /// </summary>
        public lvec5 agbbg => new lvec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.wyzzz swizzling.
        /// </summary>
        public lvec5 wyzzz => new lvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.agbbb swizzling (equivalent to lvec4.wyzzz).
        /// </summary>
        public lvec5 agbbb => new lvec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.wyzzw swizzling.
        /// </summary>
        public lvec5 wyzzw => new lvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.agbba swizzling (equivalent to lvec4.wyzzw).
        /// </summary>
        public lvec5 agbba => new lvec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.wyzw swizzling.
        /// </summary>
        public lvec4 wyzw => new lvec4(w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.agba swizzling (equivalent to lvec4.wyzw).
        /// </summary>
        public lvec4 agba => new lvec4(w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.wyzwx swizzling.
        /// </summary>
        public lvec5 wyzwx => new lvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.agbar swizzling (equivalent to lvec4.wyzwx).
        /// </summary>
        public lvec5 agbar => new lvec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.wyzwy swizzling.
        /// </summary>
        public lvec5 wyzwy => new lvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.agbag swizzling (equivalent to lvec4.wyzwy).
        /// </summary>
        public lvec5 agbag => new lvec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.wyzwz swizzling.
        /// </summary>
        public lvec5 wyzwz => new lvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.agbab swizzling (equivalent to lvec4.wyzwz).
        /// </summary>
        public lvec5 agbab => new lvec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.wyzww swizzling.
        /// </summary>
        public lvec5 wyzww => new lvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.agbaa swizzling (equivalent to lvec4.wyzww).
        /// </summary>
        public lvec5 agbaa => new lvec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.wyw swizzling.
        /// </summary>
        public lvec3 wyw => new lvec3(w, y, w);
        
        /// <summary>
        /// Returns lvec4.aga swizzling (equivalent to lvec4.wyw).
        /// </summary>
        public lvec3 aga => new lvec3(w, y, w);
        
        /// <summary>
        /// Returns lvec4.wywx swizzling.
        /// </summary>
        public lvec4 wywx => new lvec4(w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.agar swizzling (equivalent to lvec4.wywx).
        /// </summary>
        public lvec4 agar => new lvec4(w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.wywxx swizzling.
        /// </summary>
        public lvec5 wywxx => new lvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.agarr swizzling (equivalent to lvec4.wywxx).
        /// </summary>
        public lvec5 agarr => new lvec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.wywxy swizzling.
        /// </summary>
        public lvec5 wywxy => new lvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.agarg swizzling (equivalent to lvec4.wywxy).
        /// </summary>
        public lvec5 agarg => new lvec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.wywxz swizzling.
        /// </summary>
        public lvec5 wywxz => new lvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.agarb swizzling (equivalent to lvec4.wywxz).
        /// </summary>
        public lvec5 agarb => new lvec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.wywxw swizzling.
        /// </summary>
        public lvec5 wywxw => new lvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.agara swizzling (equivalent to lvec4.wywxw).
        /// </summary>
        public lvec5 agara => new lvec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.wywy swizzling.
        /// </summary>
        public lvec4 wywy => new lvec4(w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.agag swizzling (equivalent to lvec4.wywy).
        /// </summary>
        public lvec4 agag => new lvec4(w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.wywyx swizzling.
        /// </summary>
        public lvec5 wywyx => new lvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.agagr swizzling (equivalent to lvec4.wywyx).
        /// </summary>
        public lvec5 agagr => new lvec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.wywyy swizzling.
        /// </summary>
        public lvec5 wywyy => new lvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.agagg swizzling (equivalent to lvec4.wywyy).
        /// </summary>
        public lvec5 agagg => new lvec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.wywyz swizzling.
        /// </summary>
        public lvec5 wywyz => new lvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.agagb swizzling (equivalent to lvec4.wywyz).
        /// </summary>
        public lvec5 agagb => new lvec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.wywyw swizzling.
        /// </summary>
        public lvec5 wywyw => new lvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.agaga swizzling (equivalent to lvec4.wywyw).
        /// </summary>
        public lvec5 agaga => new lvec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.wywz swizzling.
        /// </summary>
        public lvec4 wywz => new lvec4(w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.agab swizzling (equivalent to lvec4.wywz).
        /// </summary>
        public lvec4 agab => new lvec4(w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.wywzx swizzling.
        /// </summary>
        public lvec5 wywzx => new lvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.agabr swizzling (equivalent to lvec4.wywzx).
        /// </summary>
        public lvec5 agabr => new lvec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.wywzy swizzling.
        /// </summary>
        public lvec5 wywzy => new lvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.agabg swizzling (equivalent to lvec4.wywzy).
        /// </summary>
        public lvec5 agabg => new lvec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.wywzz swizzling.
        /// </summary>
        public lvec5 wywzz => new lvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.agabb swizzling (equivalent to lvec4.wywzz).
        /// </summary>
        public lvec5 agabb => new lvec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.wywzw swizzling.
        /// </summary>
        public lvec5 wywzw => new lvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.agaba swizzling (equivalent to lvec4.wywzw).
        /// </summary>
        public lvec5 agaba => new lvec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.wyww swizzling.
        /// </summary>
        public lvec4 wyww => new lvec4(w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.agaa swizzling (equivalent to lvec4.wyww).
        /// </summary>
        public lvec4 agaa => new lvec4(w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.wywwx swizzling.
        /// </summary>
        public lvec5 wywwx => new lvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.agaar swizzling (equivalent to lvec4.wywwx).
        /// </summary>
        public lvec5 agaar => new lvec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.wywwy swizzling.
        /// </summary>
        public lvec5 wywwy => new lvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.agaag swizzling (equivalent to lvec4.wywwy).
        /// </summary>
        public lvec5 agaag => new lvec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.wywwz swizzling.
        /// </summary>
        public lvec5 wywwz => new lvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.agaab swizzling (equivalent to lvec4.wywwz).
        /// </summary>
        public lvec5 agaab => new lvec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.wywww swizzling.
        /// </summary>
        public lvec5 wywww => new lvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.agaaa swizzling (equivalent to lvec4.wywww).
        /// </summary>
        public lvec5 agaaa => new lvec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.wz swizzling.
        /// </summary>
        public lvec2 wz => new lvec2(w, z);
        
        /// <summary>
        /// Returns lvec4.ab swizzling (equivalent to lvec4.wz).
        /// </summary>
        public lvec2 ab => new lvec2(w, z);
        
        /// <summary>
        /// Returns lvec4.wzx swizzling.
        /// </summary>
        public lvec3 wzx => new lvec3(w, z, x);
        
        /// <summary>
        /// Returns lvec4.abr swizzling (equivalent to lvec4.wzx).
        /// </summary>
        public lvec3 abr => new lvec3(w, z, x);
        
        /// <summary>
        /// Returns lvec4.wzxx swizzling.
        /// </summary>
        public lvec4 wzxx => new lvec4(w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.abrr swizzling (equivalent to lvec4.wzxx).
        /// </summary>
        public lvec4 abrr => new lvec4(w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.wzxxx swizzling.
        /// </summary>
        public lvec5 wzxxx => new lvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.abrrr swizzling (equivalent to lvec4.wzxxx).
        /// </summary>
        public lvec5 abrrr => new lvec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.wzxxy swizzling.
        /// </summary>
        public lvec5 wzxxy => new lvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.abrrg swizzling (equivalent to lvec4.wzxxy).
        /// </summary>
        public lvec5 abrrg => new lvec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.wzxxz swizzling.
        /// </summary>
        public lvec5 wzxxz => new lvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.abrrb swizzling (equivalent to lvec4.wzxxz).
        /// </summary>
        public lvec5 abrrb => new lvec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.wzxxw swizzling.
        /// </summary>
        public lvec5 wzxxw => new lvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.abrra swizzling (equivalent to lvec4.wzxxw).
        /// </summary>
        public lvec5 abrra => new lvec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.wzxy swizzling.
        /// </summary>
        public lvec4 wzxy => new lvec4(w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.abrg swizzling (equivalent to lvec4.wzxy).
        /// </summary>
        public lvec4 abrg => new lvec4(w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.wzxyx swizzling.
        /// </summary>
        public lvec5 wzxyx => new lvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.abrgr swizzling (equivalent to lvec4.wzxyx).
        /// </summary>
        public lvec5 abrgr => new lvec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.wzxyy swizzling.
        /// </summary>
        public lvec5 wzxyy => new lvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.abrgg swizzling (equivalent to lvec4.wzxyy).
        /// </summary>
        public lvec5 abrgg => new lvec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.wzxyz swizzling.
        /// </summary>
        public lvec5 wzxyz => new lvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.abrgb swizzling (equivalent to lvec4.wzxyz).
        /// </summary>
        public lvec5 abrgb => new lvec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.wzxyw swizzling.
        /// </summary>
        public lvec5 wzxyw => new lvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.abrga swizzling (equivalent to lvec4.wzxyw).
        /// </summary>
        public lvec5 abrga => new lvec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.wzxz swizzling.
        /// </summary>
        public lvec4 wzxz => new lvec4(w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.abrb swizzling (equivalent to lvec4.wzxz).
        /// </summary>
        public lvec4 abrb => new lvec4(w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.wzxzx swizzling.
        /// </summary>
        public lvec5 wzxzx => new lvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.abrbr swizzling (equivalent to lvec4.wzxzx).
        /// </summary>
        public lvec5 abrbr => new lvec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.wzxzy swizzling.
        /// </summary>
        public lvec5 wzxzy => new lvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.abrbg swizzling (equivalent to lvec4.wzxzy).
        /// </summary>
        public lvec5 abrbg => new lvec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.wzxzz swizzling.
        /// </summary>
        public lvec5 wzxzz => new lvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.abrbb swizzling (equivalent to lvec4.wzxzz).
        /// </summary>
        public lvec5 abrbb => new lvec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.wzxzw swizzling.
        /// </summary>
        public lvec5 wzxzw => new lvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.abrba swizzling (equivalent to lvec4.wzxzw).
        /// </summary>
        public lvec5 abrba => new lvec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.wzxw swizzling.
        /// </summary>
        public lvec4 wzxw => new lvec4(w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.abra swizzling (equivalent to lvec4.wzxw).
        /// </summary>
        public lvec4 abra => new lvec4(w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.wzxwx swizzling.
        /// </summary>
        public lvec5 wzxwx => new lvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.abrar swizzling (equivalent to lvec4.wzxwx).
        /// </summary>
        public lvec5 abrar => new lvec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.wzxwy swizzling.
        /// </summary>
        public lvec5 wzxwy => new lvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.abrag swizzling (equivalent to lvec4.wzxwy).
        /// </summary>
        public lvec5 abrag => new lvec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.wzxwz swizzling.
        /// </summary>
        public lvec5 wzxwz => new lvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.abrab swizzling (equivalent to lvec4.wzxwz).
        /// </summary>
        public lvec5 abrab => new lvec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.wzxww swizzling.
        /// </summary>
        public lvec5 wzxww => new lvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.abraa swizzling (equivalent to lvec4.wzxww).
        /// </summary>
        public lvec5 abraa => new lvec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.wzy swizzling.
        /// </summary>
        public lvec3 wzy => new lvec3(w, z, y);
        
        /// <summary>
        /// Returns lvec4.abg swizzling (equivalent to lvec4.wzy).
        /// </summary>
        public lvec3 abg => new lvec3(w, z, y);
        
        /// <summary>
        /// Returns lvec4.wzyx swizzling.
        /// </summary>
        public lvec4 wzyx => new lvec4(w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.abgr swizzling (equivalent to lvec4.wzyx).
        /// </summary>
        public lvec4 abgr => new lvec4(w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.wzyxx swizzling.
        /// </summary>
        public lvec5 wzyxx => new lvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.abgrr swizzling (equivalent to lvec4.wzyxx).
        /// </summary>
        public lvec5 abgrr => new lvec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.wzyxy swizzling.
        /// </summary>
        public lvec5 wzyxy => new lvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.abgrg swizzling (equivalent to lvec4.wzyxy).
        /// </summary>
        public lvec5 abgrg => new lvec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.wzyxz swizzling.
        /// </summary>
        public lvec5 wzyxz => new lvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.abgrb swizzling (equivalent to lvec4.wzyxz).
        /// </summary>
        public lvec5 abgrb => new lvec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.wzyxw swizzling.
        /// </summary>
        public lvec5 wzyxw => new lvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.abgra swizzling (equivalent to lvec4.wzyxw).
        /// </summary>
        public lvec5 abgra => new lvec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.wzyy swizzling.
        /// </summary>
        public lvec4 wzyy => new lvec4(w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.abgg swizzling (equivalent to lvec4.wzyy).
        /// </summary>
        public lvec4 abgg => new lvec4(w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.wzyyx swizzling.
        /// </summary>
        public lvec5 wzyyx => new lvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.abggr swizzling (equivalent to lvec4.wzyyx).
        /// </summary>
        public lvec5 abggr => new lvec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.wzyyy swizzling.
        /// </summary>
        public lvec5 wzyyy => new lvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.abggg swizzling (equivalent to lvec4.wzyyy).
        /// </summary>
        public lvec5 abggg => new lvec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.wzyyz swizzling.
        /// </summary>
        public lvec5 wzyyz => new lvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.abggb swizzling (equivalent to lvec4.wzyyz).
        /// </summary>
        public lvec5 abggb => new lvec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.wzyyw swizzling.
        /// </summary>
        public lvec5 wzyyw => new lvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.abgga swizzling (equivalent to lvec4.wzyyw).
        /// </summary>
        public lvec5 abgga => new lvec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.wzyz swizzling.
        /// </summary>
        public lvec4 wzyz => new lvec4(w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.abgb swizzling (equivalent to lvec4.wzyz).
        /// </summary>
        public lvec4 abgb => new lvec4(w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.wzyzx swizzling.
        /// </summary>
        public lvec5 wzyzx => new lvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.abgbr swizzling (equivalent to lvec4.wzyzx).
        /// </summary>
        public lvec5 abgbr => new lvec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.wzyzy swizzling.
        /// </summary>
        public lvec5 wzyzy => new lvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.abgbg swizzling (equivalent to lvec4.wzyzy).
        /// </summary>
        public lvec5 abgbg => new lvec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.wzyzz swizzling.
        /// </summary>
        public lvec5 wzyzz => new lvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.abgbb swizzling (equivalent to lvec4.wzyzz).
        /// </summary>
        public lvec5 abgbb => new lvec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.wzyzw swizzling.
        /// </summary>
        public lvec5 wzyzw => new lvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.abgba swizzling (equivalent to lvec4.wzyzw).
        /// </summary>
        public lvec5 abgba => new lvec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.wzyw swizzling.
        /// </summary>
        public lvec4 wzyw => new lvec4(w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.abga swizzling (equivalent to lvec4.wzyw).
        /// </summary>
        public lvec4 abga => new lvec4(w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.wzywx swizzling.
        /// </summary>
        public lvec5 wzywx => new lvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.abgar swizzling (equivalent to lvec4.wzywx).
        /// </summary>
        public lvec5 abgar => new lvec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.wzywy swizzling.
        /// </summary>
        public lvec5 wzywy => new lvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.abgag swizzling (equivalent to lvec4.wzywy).
        /// </summary>
        public lvec5 abgag => new lvec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.wzywz swizzling.
        /// </summary>
        public lvec5 wzywz => new lvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.abgab swizzling (equivalent to lvec4.wzywz).
        /// </summary>
        public lvec5 abgab => new lvec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.wzyww swizzling.
        /// </summary>
        public lvec5 wzyww => new lvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.abgaa swizzling (equivalent to lvec4.wzyww).
        /// </summary>
        public lvec5 abgaa => new lvec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.wzz swizzling.
        /// </summary>
        public lvec3 wzz => new lvec3(w, z, z);
        
        /// <summary>
        /// Returns lvec4.abb swizzling (equivalent to lvec4.wzz).
        /// </summary>
        public lvec3 abb => new lvec3(w, z, z);
        
        /// <summary>
        /// Returns lvec4.wzzx swizzling.
        /// </summary>
        public lvec4 wzzx => new lvec4(w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.abbr swizzling (equivalent to lvec4.wzzx).
        /// </summary>
        public lvec4 abbr => new lvec4(w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.wzzxx swizzling.
        /// </summary>
        public lvec5 wzzxx => new lvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.abbrr swizzling (equivalent to lvec4.wzzxx).
        /// </summary>
        public lvec5 abbrr => new lvec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.wzzxy swizzling.
        /// </summary>
        public lvec5 wzzxy => new lvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.abbrg swizzling (equivalent to lvec4.wzzxy).
        /// </summary>
        public lvec5 abbrg => new lvec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.wzzxz swizzling.
        /// </summary>
        public lvec5 wzzxz => new lvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.abbrb swizzling (equivalent to lvec4.wzzxz).
        /// </summary>
        public lvec5 abbrb => new lvec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.wzzxw swizzling.
        /// </summary>
        public lvec5 wzzxw => new lvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.abbra swizzling (equivalent to lvec4.wzzxw).
        /// </summary>
        public lvec5 abbra => new lvec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.wzzy swizzling.
        /// </summary>
        public lvec4 wzzy => new lvec4(w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.abbg swizzling (equivalent to lvec4.wzzy).
        /// </summary>
        public lvec4 abbg => new lvec4(w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.wzzyx swizzling.
        /// </summary>
        public lvec5 wzzyx => new lvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.abbgr swizzling (equivalent to lvec4.wzzyx).
        /// </summary>
        public lvec5 abbgr => new lvec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.wzzyy swizzling.
        /// </summary>
        public lvec5 wzzyy => new lvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.abbgg swizzling (equivalent to lvec4.wzzyy).
        /// </summary>
        public lvec5 abbgg => new lvec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.wzzyz swizzling.
        /// </summary>
        public lvec5 wzzyz => new lvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.abbgb swizzling (equivalent to lvec4.wzzyz).
        /// </summary>
        public lvec5 abbgb => new lvec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.wzzyw swizzling.
        /// </summary>
        public lvec5 wzzyw => new lvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.abbga swizzling (equivalent to lvec4.wzzyw).
        /// </summary>
        public lvec5 abbga => new lvec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.wzzz swizzling.
        /// </summary>
        public lvec4 wzzz => new lvec4(w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.abbb swizzling (equivalent to lvec4.wzzz).
        /// </summary>
        public lvec4 abbb => new lvec4(w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.wzzzx swizzling.
        /// </summary>
        public lvec5 wzzzx => new lvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.abbbr swizzling (equivalent to lvec4.wzzzx).
        /// </summary>
        public lvec5 abbbr => new lvec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.wzzzy swizzling.
        /// </summary>
        public lvec5 wzzzy => new lvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.abbbg swizzling (equivalent to lvec4.wzzzy).
        /// </summary>
        public lvec5 abbbg => new lvec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.wzzzz swizzling.
        /// </summary>
        public lvec5 wzzzz => new lvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.abbbb swizzling (equivalent to lvec4.wzzzz).
        /// </summary>
        public lvec5 abbbb => new lvec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.wzzzw swizzling.
        /// </summary>
        public lvec5 wzzzw => new lvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.abbba swizzling (equivalent to lvec4.wzzzw).
        /// </summary>
        public lvec5 abbba => new lvec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.wzzw swizzling.
        /// </summary>
        public lvec4 wzzw => new lvec4(w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.abba swizzling (equivalent to lvec4.wzzw).
        /// </summary>
        public lvec4 abba => new lvec4(w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.wzzwx swizzling.
        /// </summary>
        public lvec5 wzzwx => new lvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.abbar swizzling (equivalent to lvec4.wzzwx).
        /// </summary>
        public lvec5 abbar => new lvec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.wzzwy swizzling.
        /// </summary>
        public lvec5 wzzwy => new lvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.abbag swizzling (equivalent to lvec4.wzzwy).
        /// </summary>
        public lvec5 abbag => new lvec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.wzzwz swizzling.
        /// </summary>
        public lvec5 wzzwz => new lvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.abbab swizzling (equivalent to lvec4.wzzwz).
        /// </summary>
        public lvec5 abbab => new lvec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.wzzww swizzling.
        /// </summary>
        public lvec5 wzzww => new lvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.abbaa swizzling (equivalent to lvec4.wzzww).
        /// </summary>
        public lvec5 abbaa => new lvec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.wzw swizzling.
        /// </summary>
        public lvec3 wzw => new lvec3(w, z, w);
        
        /// <summary>
        /// Returns lvec4.aba swizzling (equivalent to lvec4.wzw).
        /// </summary>
        public lvec3 aba => new lvec3(w, z, w);
        
        /// <summary>
        /// Returns lvec4.wzwx swizzling.
        /// </summary>
        public lvec4 wzwx => new lvec4(w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.abar swizzling (equivalent to lvec4.wzwx).
        /// </summary>
        public lvec4 abar => new lvec4(w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.wzwxx swizzling.
        /// </summary>
        public lvec5 wzwxx => new lvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.abarr swizzling (equivalent to lvec4.wzwxx).
        /// </summary>
        public lvec5 abarr => new lvec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.wzwxy swizzling.
        /// </summary>
        public lvec5 wzwxy => new lvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.abarg swizzling (equivalent to lvec4.wzwxy).
        /// </summary>
        public lvec5 abarg => new lvec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.wzwxz swizzling.
        /// </summary>
        public lvec5 wzwxz => new lvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.abarb swizzling (equivalent to lvec4.wzwxz).
        /// </summary>
        public lvec5 abarb => new lvec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.wzwxw swizzling.
        /// </summary>
        public lvec5 wzwxw => new lvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.abara swizzling (equivalent to lvec4.wzwxw).
        /// </summary>
        public lvec5 abara => new lvec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.wzwy swizzling.
        /// </summary>
        public lvec4 wzwy => new lvec4(w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.abag swizzling (equivalent to lvec4.wzwy).
        /// </summary>
        public lvec4 abag => new lvec4(w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.wzwyx swizzling.
        /// </summary>
        public lvec5 wzwyx => new lvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.abagr swizzling (equivalent to lvec4.wzwyx).
        /// </summary>
        public lvec5 abagr => new lvec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.wzwyy swizzling.
        /// </summary>
        public lvec5 wzwyy => new lvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.abagg swizzling (equivalent to lvec4.wzwyy).
        /// </summary>
        public lvec5 abagg => new lvec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.wzwyz swizzling.
        /// </summary>
        public lvec5 wzwyz => new lvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.abagb swizzling (equivalent to lvec4.wzwyz).
        /// </summary>
        public lvec5 abagb => new lvec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.wzwyw swizzling.
        /// </summary>
        public lvec5 wzwyw => new lvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.abaga swizzling (equivalent to lvec4.wzwyw).
        /// </summary>
        public lvec5 abaga => new lvec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.wzwz swizzling.
        /// </summary>
        public lvec4 wzwz => new lvec4(w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.abab swizzling (equivalent to lvec4.wzwz).
        /// </summary>
        public lvec4 abab => new lvec4(w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.wzwzx swizzling.
        /// </summary>
        public lvec5 wzwzx => new lvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.ababr swizzling (equivalent to lvec4.wzwzx).
        /// </summary>
        public lvec5 ababr => new lvec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.wzwzy swizzling.
        /// </summary>
        public lvec5 wzwzy => new lvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.ababg swizzling (equivalent to lvec4.wzwzy).
        /// </summary>
        public lvec5 ababg => new lvec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.wzwzz swizzling.
        /// </summary>
        public lvec5 wzwzz => new lvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.ababb swizzling (equivalent to lvec4.wzwzz).
        /// </summary>
        public lvec5 ababb => new lvec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.wzwzw swizzling.
        /// </summary>
        public lvec5 wzwzw => new lvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.ababa swizzling (equivalent to lvec4.wzwzw).
        /// </summary>
        public lvec5 ababa => new lvec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.wzww swizzling.
        /// </summary>
        public lvec4 wzww => new lvec4(w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.abaa swizzling (equivalent to lvec4.wzww).
        /// </summary>
        public lvec4 abaa => new lvec4(w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.wzwwx swizzling.
        /// </summary>
        public lvec5 wzwwx => new lvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.abaar swizzling (equivalent to lvec4.wzwwx).
        /// </summary>
        public lvec5 abaar => new lvec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.wzwwy swizzling.
        /// </summary>
        public lvec5 wzwwy => new lvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.abaag swizzling (equivalent to lvec4.wzwwy).
        /// </summary>
        public lvec5 abaag => new lvec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.wzwwz swizzling.
        /// </summary>
        public lvec5 wzwwz => new lvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.abaab swizzling (equivalent to lvec4.wzwwz).
        /// </summary>
        public lvec5 abaab => new lvec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.wzwww swizzling.
        /// </summary>
        public lvec5 wzwww => new lvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.abaaa swizzling (equivalent to lvec4.wzwww).
        /// </summary>
        public lvec5 abaaa => new lvec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.ww swizzling.
        /// </summary>
        public lvec2 ww => new lvec2(w, w);
        
        /// <summary>
        /// Returns lvec4.aa swizzling (equivalent to lvec4.ww).
        /// </summary>
        public lvec2 aa => new lvec2(w, w);
        
        /// <summary>
        /// Returns lvec4.wwx swizzling.
        /// </summary>
        public lvec3 wwx => new lvec3(w, w, x);
        
        /// <summary>
        /// Returns lvec4.aar swizzling (equivalent to lvec4.wwx).
        /// </summary>
        public lvec3 aar => new lvec3(w, w, x);
        
        /// <summary>
        /// Returns lvec4.wwxx swizzling.
        /// </summary>
        public lvec4 wwxx => new lvec4(w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.aarr swizzling (equivalent to lvec4.wwxx).
        /// </summary>
        public lvec4 aarr => new lvec4(w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.wwxxx swizzling.
        /// </summary>
        public lvec5 wwxxx => new lvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.aarrr swizzling (equivalent to lvec4.wwxxx).
        /// </summary>
        public lvec5 aarrr => new lvec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.wwxxy swizzling.
        /// </summary>
        public lvec5 wwxxy => new lvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.aarrg swizzling (equivalent to lvec4.wwxxy).
        /// </summary>
        public lvec5 aarrg => new lvec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.wwxxz swizzling.
        /// </summary>
        public lvec5 wwxxz => new lvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.aarrb swizzling (equivalent to lvec4.wwxxz).
        /// </summary>
        public lvec5 aarrb => new lvec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.wwxxw swizzling.
        /// </summary>
        public lvec5 wwxxw => new lvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.aarra swizzling (equivalent to lvec4.wwxxw).
        /// </summary>
        public lvec5 aarra => new lvec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.wwxy swizzling.
        /// </summary>
        public lvec4 wwxy => new lvec4(w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.aarg swizzling (equivalent to lvec4.wwxy).
        /// </summary>
        public lvec4 aarg => new lvec4(w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.wwxyx swizzling.
        /// </summary>
        public lvec5 wwxyx => new lvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.aargr swizzling (equivalent to lvec4.wwxyx).
        /// </summary>
        public lvec5 aargr => new lvec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.wwxyy swizzling.
        /// </summary>
        public lvec5 wwxyy => new lvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.aargg swizzling (equivalent to lvec4.wwxyy).
        /// </summary>
        public lvec5 aargg => new lvec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.wwxyz swizzling.
        /// </summary>
        public lvec5 wwxyz => new lvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.aargb swizzling (equivalent to lvec4.wwxyz).
        /// </summary>
        public lvec5 aargb => new lvec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.wwxyw swizzling.
        /// </summary>
        public lvec5 wwxyw => new lvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.aarga swizzling (equivalent to lvec4.wwxyw).
        /// </summary>
        public lvec5 aarga => new lvec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.wwxz swizzling.
        /// </summary>
        public lvec4 wwxz => new lvec4(w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.aarb swizzling (equivalent to lvec4.wwxz).
        /// </summary>
        public lvec4 aarb => new lvec4(w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.wwxzx swizzling.
        /// </summary>
        public lvec5 wwxzx => new lvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.aarbr swizzling (equivalent to lvec4.wwxzx).
        /// </summary>
        public lvec5 aarbr => new lvec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.wwxzy swizzling.
        /// </summary>
        public lvec5 wwxzy => new lvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.aarbg swizzling (equivalent to lvec4.wwxzy).
        /// </summary>
        public lvec5 aarbg => new lvec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.wwxzz swizzling.
        /// </summary>
        public lvec5 wwxzz => new lvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.aarbb swizzling (equivalent to lvec4.wwxzz).
        /// </summary>
        public lvec5 aarbb => new lvec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.wwxzw swizzling.
        /// </summary>
        public lvec5 wwxzw => new lvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.aarba swizzling (equivalent to lvec4.wwxzw).
        /// </summary>
        public lvec5 aarba => new lvec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.wwxw swizzling.
        /// </summary>
        public lvec4 wwxw => new lvec4(w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.aara swizzling (equivalent to lvec4.wwxw).
        /// </summary>
        public lvec4 aara => new lvec4(w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.wwxwx swizzling.
        /// </summary>
        public lvec5 wwxwx => new lvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.aarar swizzling (equivalent to lvec4.wwxwx).
        /// </summary>
        public lvec5 aarar => new lvec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.wwxwy swizzling.
        /// </summary>
        public lvec5 wwxwy => new lvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.aarag swizzling (equivalent to lvec4.wwxwy).
        /// </summary>
        public lvec5 aarag => new lvec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.wwxwz swizzling.
        /// </summary>
        public lvec5 wwxwz => new lvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.aarab swizzling (equivalent to lvec4.wwxwz).
        /// </summary>
        public lvec5 aarab => new lvec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.wwxww swizzling.
        /// </summary>
        public lvec5 wwxww => new lvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.aaraa swizzling (equivalent to lvec4.wwxww).
        /// </summary>
        public lvec5 aaraa => new lvec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.wwy swizzling.
        /// </summary>
        public lvec3 wwy => new lvec3(w, w, y);
        
        /// <summary>
        /// Returns lvec4.aag swizzling (equivalent to lvec4.wwy).
        /// </summary>
        public lvec3 aag => new lvec3(w, w, y);
        
        /// <summary>
        /// Returns lvec4.wwyx swizzling.
        /// </summary>
        public lvec4 wwyx => new lvec4(w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.aagr swizzling (equivalent to lvec4.wwyx).
        /// </summary>
        public lvec4 aagr => new lvec4(w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.wwyxx swizzling.
        /// </summary>
        public lvec5 wwyxx => new lvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.aagrr swizzling (equivalent to lvec4.wwyxx).
        /// </summary>
        public lvec5 aagrr => new lvec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.wwyxy swizzling.
        /// </summary>
        public lvec5 wwyxy => new lvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.aagrg swizzling (equivalent to lvec4.wwyxy).
        /// </summary>
        public lvec5 aagrg => new lvec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.wwyxz swizzling.
        /// </summary>
        public lvec5 wwyxz => new lvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.aagrb swizzling (equivalent to lvec4.wwyxz).
        /// </summary>
        public lvec5 aagrb => new lvec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.wwyxw swizzling.
        /// </summary>
        public lvec5 wwyxw => new lvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.aagra swizzling (equivalent to lvec4.wwyxw).
        /// </summary>
        public lvec5 aagra => new lvec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.wwyy swizzling.
        /// </summary>
        public lvec4 wwyy => new lvec4(w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.aagg swizzling (equivalent to lvec4.wwyy).
        /// </summary>
        public lvec4 aagg => new lvec4(w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.wwyyx swizzling.
        /// </summary>
        public lvec5 wwyyx => new lvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.aaggr swizzling (equivalent to lvec4.wwyyx).
        /// </summary>
        public lvec5 aaggr => new lvec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.wwyyy swizzling.
        /// </summary>
        public lvec5 wwyyy => new lvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.aaggg swizzling (equivalent to lvec4.wwyyy).
        /// </summary>
        public lvec5 aaggg => new lvec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.wwyyz swizzling.
        /// </summary>
        public lvec5 wwyyz => new lvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.aaggb swizzling (equivalent to lvec4.wwyyz).
        /// </summary>
        public lvec5 aaggb => new lvec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.wwyyw swizzling.
        /// </summary>
        public lvec5 wwyyw => new lvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.aagga swizzling (equivalent to lvec4.wwyyw).
        /// </summary>
        public lvec5 aagga => new lvec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.wwyz swizzling.
        /// </summary>
        public lvec4 wwyz => new lvec4(w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.aagb swizzling (equivalent to lvec4.wwyz).
        /// </summary>
        public lvec4 aagb => new lvec4(w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.wwyzx swizzling.
        /// </summary>
        public lvec5 wwyzx => new lvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.aagbr swizzling (equivalent to lvec4.wwyzx).
        /// </summary>
        public lvec5 aagbr => new lvec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.wwyzy swizzling.
        /// </summary>
        public lvec5 wwyzy => new lvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.aagbg swizzling (equivalent to lvec4.wwyzy).
        /// </summary>
        public lvec5 aagbg => new lvec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.wwyzz swizzling.
        /// </summary>
        public lvec5 wwyzz => new lvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.aagbb swizzling (equivalent to lvec4.wwyzz).
        /// </summary>
        public lvec5 aagbb => new lvec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.wwyzw swizzling.
        /// </summary>
        public lvec5 wwyzw => new lvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.aagba swizzling (equivalent to lvec4.wwyzw).
        /// </summary>
        public lvec5 aagba => new lvec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.wwyw swizzling.
        /// </summary>
        public lvec4 wwyw => new lvec4(w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.aaga swizzling (equivalent to lvec4.wwyw).
        /// </summary>
        public lvec4 aaga => new lvec4(w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.wwywx swizzling.
        /// </summary>
        public lvec5 wwywx => new lvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.aagar swizzling (equivalent to lvec4.wwywx).
        /// </summary>
        public lvec5 aagar => new lvec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.wwywy swizzling.
        /// </summary>
        public lvec5 wwywy => new lvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.aagag swizzling (equivalent to lvec4.wwywy).
        /// </summary>
        public lvec5 aagag => new lvec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.wwywz swizzling.
        /// </summary>
        public lvec5 wwywz => new lvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.aagab swizzling (equivalent to lvec4.wwywz).
        /// </summary>
        public lvec5 aagab => new lvec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.wwyww swizzling.
        /// </summary>
        public lvec5 wwyww => new lvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.aagaa swizzling (equivalent to lvec4.wwyww).
        /// </summary>
        public lvec5 aagaa => new lvec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.wwz swizzling.
        /// </summary>
        public lvec3 wwz => new lvec3(w, w, z);
        
        /// <summary>
        /// Returns lvec4.aab swizzling (equivalent to lvec4.wwz).
        /// </summary>
        public lvec3 aab => new lvec3(w, w, z);
        
        /// <summary>
        /// Returns lvec4.wwzx swizzling.
        /// </summary>
        public lvec4 wwzx => new lvec4(w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.aabr swizzling (equivalent to lvec4.wwzx).
        /// </summary>
        public lvec4 aabr => new lvec4(w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.wwzxx swizzling.
        /// </summary>
        public lvec5 wwzxx => new lvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.aabrr swizzling (equivalent to lvec4.wwzxx).
        /// </summary>
        public lvec5 aabrr => new lvec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.wwzxy swizzling.
        /// </summary>
        public lvec5 wwzxy => new lvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.aabrg swizzling (equivalent to lvec4.wwzxy).
        /// </summary>
        public lvec5 aabrg => new lvec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.wwzxz swizzling.
        /// </summary>
        public lvec5 wwzxz => new lvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.aabrb swizzling (equivalent to lvec4.wwzxz).
        /// </summary>
        public lvec5 aabrb => new lvec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.wwzxw swizzling.
        /// </summary>
        public lvec5 wwzxw => new lvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.aabra swizzling (equivalent to lvec4.wwzxw).
        /// </summary>
        public lvec5 aabra => new lvec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.wwzy swizzling.
        /// </summary>
        public lvec4 wwzy => new lvec4(w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.aabg swizzling (equivalent to lvec4.wwzy).
        /// </summary>
        public lvec4 aabg => new lvec4(w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.wwzyx swizzling.
        /// </summary>
        public lvec5 wwzyx => new lvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.aabgr swizzling (equivalent to lvec4.wwzyx).
        /// </summary>
        public lvec5 aabgr => new lvec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.wwzyy swizzling.
        /// </summary>
        public lvec5 wwzyy => new lvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.aabgg swizzling (equivalent to lvec4.wwzyy).
        /// </summary>
        public lvec5 aabgg => new lvec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.wwzyz swizzling.
        /// </summary>
        public lvec5 wwzyz => new lvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.aabgb swizzling (equivalent to lvec4.wwzyz).
        /// </summary>
        public lvec5 aabgb => new lvec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.wwzyw swizzling.
        /// </summary>
        public lvec5 wwzyw => new lvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.aabga swizzling (equivalent to lvec4.wwzyw).
        /// </summary>
        public lvec5 aabga => new lvec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.wwzz swizzling.
        /// </summary>
        public lvec4 wwzz => new lvec4(w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.aabb swizzling (equivalent to lvec4.wwzz).
        /// </summary>
        public lvec4 aabb => new lvec4(w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.wwzzx swizzling.
        /// </summary>
        public lvec5 wwzzx => new lvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.aabbr swizzling (equivalent to lvec4.wwzzx).
        /// </summary>
        public lvec5 aabbr => new lvec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.wwzzy swizzling.
        /// </summary>
        public lvec5 wwzzy => new lvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.aabbg swizzling (equivalent to lvec4.wwzzy).
        /// </summary>
        public lvec5 aabbg => new lvec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.wwzzz swizzling.
        /// </summary>
        public lvec5 wwzzz => new lvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.aabbb swizzling (equivalent to lvec4.wwzzz).
        /// </summary>
        public lvec5 aabbb => new lvec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.wwzzw swizzling.
        /// </summary>
        public lvec5 wwzzw => new lvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.aabba swizzling (equivalent to lvec4.wwzzw).
        /// </summary>
        public lvec5 aabba => new lvec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.wwzw swizzling.
        /// </summary>
        public lvec4 wwzw => new lvec4(w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.aaba swizzling (equivalent to lvec4.wwzw).
        /// </summary>
        public lvec4 aaba => new lvec4(w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.wwzwx swizzling.
        /// </summary>
        public lvec5 wwzwx => new lvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.aabar swizzling (equivalent to lvec4.wwzwx).
        /// </summary>
        public lvec5 aabar => new lvec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.wwzwy swizzling.
        /// </summary>
        public lvec5 wwzwy => new lvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.aabag swizzling (equivalent to lvec4.wwzwy).
        /// </summary>
        public lvec5 aabag => new lvec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.wwzwz swizzling.
        /// </summary>
        public lvec5 wwzwz => new lvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.aabab swizzling (equivalent to lvec4.wwzwz).
        /// </summary>
        public lvec5 aabab => new lvec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.wwzww swizzling.
        /// </summary>
        public lvec5 wwzww => new lvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.aabaa swizzling (equivalent to lvec4.wwzww).
        /// </summary>
        public lvec5 aabaa => new lvec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.www swizzling.
        /// </summary>
        public lvec3 www => new lvec3(w, w, w);
        
        /// <summary>
        /// Returns lvec4.aaa swizzling (equivalent to lvec4.www).
        /// </summary>
        public lvec3 aaa => new lvec3(w, w, w);
        
        /// <summary>
        /// Returns lvec4.wwwx swizzling.
        /// </summary>
        public lvec4 wwwx => new lvec4(w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.aaar swizzling (equivalent to lvec4.wwwx).
        /// </summary>
        public lvec4 aaar => new lvec4(w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.wwwxx swizzling.
        /// </summary>
        public lvec5 wwwxx => new lvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.aaarr swizzling (equivalent to lvec4.wwwxx).
        /// </summary>
        public lvec5 aaarr => new lvec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.wwwxy swizzling.
        /// </summary>
        public lvec5 wwwxy => new lvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.aaarg swizzling (equivalent to lvec4.wwwxy).
        /// </summary>
        public lvec5 aaarg => new lvec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.wwwxz swizzling.
        /// </summary>
        public lvec5 wwwxz => new lvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.aaarb swizzling (equivalent to lvec4.wwwxz).
        /// </summary>
        public lvec5 aaarb => new lvec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.wwwxw swizzling.
        /// </summary>
        public lvec5 wwwxw => new lvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.aaara swizzling (equivalent to lvec4.wwwxw).
        /// </summary>
        public lvec5 aaara => new lvec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.wwwy swizzling.
        /// </summary>
        public lvec4 wwwy => new lvec4(w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.aaag swizzling (equivalent to lvec4.wwwy).
        /// </summary>
        public lvec4 aaag => new lvec4(w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.wwwyx swizzling.
        /// </summary>
        public lvec5 wwwyx => new lvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.aaagr swizzling (equivalent to lvec4.wwwyx).
        /// </summary>
        public lvec5 aaagr => new lvec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.wwwyy swizzling.
        /// </summary>
        public lvec5 wwwyy => new lvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.aaagg swizzling (equivalent to lvec4.wwwyy).
        /// </summary>
        public lvec5 aaagg => new lvec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.wwwyz swizzling.
        /// </summary>
        public lvec5 wwwyz => new lvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.aaagb swizzling (equivalent to lvec4.wwwyz).
        /// </summary>
        public lvec5 aaagb => new lvec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.wwwyw swizzling.
        /// </summary>
        public lvec5 wwwyw => new lvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.aaaga swizzling (equivalent to lvec4.wwwyw).
        /// </summary>
        public lvec5 aaaga => new lvec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.wwwz swizzling.
        /// </summary>
        public lvec4 wwwz => new lvec4(w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.aaab swizzling (equivalent to lvec4.wwwz).
        /// </summary>
        public lvec4 aaab => new lvec4(w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.wwwzx swizzling.
        /// </summary>
        public lvec5 wwwzx => new lvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.aaabr swizzling (equivalent to lvec4.wwwzx).
        /// </summary>
        public lvec5 aaabr => new lvec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.wwwzy swizzling.
        /// </summary>
        public lvec5 wwwzy => new lvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.aaabg swizzling (equivalent to lvec4.wwwzy).
        /// </summary>
        public lvec5 aaabg => new lvec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.wwwzz swizzling.
        /// </summary>
        public lvec5 wwwzz => new lvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.aaabb swizzling (equivalent to lvec4.wwwzz).
        /// </summary>
        public lvec5 aaabb => new lvec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.wwwzw swizzling.
        /// </summary>
        public lvec5 wwwzw => new lvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.aaaba swizzling (equivalent to lvec4.wwwzw).
        /// </summary>
        public lvec5 aaaba => new lvec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.wwww swizzling.
        /// </summary>
        public lvec4 wwww => new lvec4(w, w, w, w);
        
        /// <summary>
        /// Returns lvec4.aaaa swizzling (equivalent to lvec4.wwww).
        /// </summary>
        public lvec4 aaaa => new lvec4(w, w, w, w);
        
        /// <summary>
        /// Returns lvec4.wwwwx swizzling.
        /// </summary>
        public lvec5 wwwwx => new lvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.aaaar swizzling (equivalent to lvec4.wwwwx).
        /// </summary>
        public lvec5 aaaar => new lvec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.wwwwy swizzling.
        /// </summary>
        public lvec5 wwwwy => new lvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.aaaag swizzling (equivalent to lvec4.wwwwy).
        /// </summary>
        public lvec5 aaaag => new lvec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.wwwwz swizzling.
        /// </summary>
        public lvec5 wwwwz => new lvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.aaaab swizzling (equivalent to lvec4.wwwwz).
        /// </summary>
        public lvec5 aaaab => new lvec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.wwwww swizzling.
        /// </summary>
        public lvec5 wwwww => new lvec5(w, w, w, w, w);
        
        /// <summary>
        /// Returns lvec4.aaaaa swizzling (equivalent to lvec4.wwwww).
        /// </summary>
        public lvec5 aaaaa => new lvec5(w, w, w, w, w);

        #endregion

    }
}
