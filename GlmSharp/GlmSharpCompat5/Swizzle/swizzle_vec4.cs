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
    /// Temporary vector of type float with 4 components, used for implementing swizzling for vec4.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_vec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly float y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly float z;
        
        /// <summary>
        /// w-component
        /// </summary>
        internal readonly float w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_vec4.
        /// </summary>
        internal swizzle_vec4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns vec4.xx swizzling.
        /// </summary>
        public vec2 xx => new vec2(x, x);
        
        /// <summary>
        /// Returns vec4.rr swizzling (equivalent to vec4.xx).
        /// </summary>
        public vec2 rr => new vec2(x, x);
        
        /// <summary>
        /// Returns vec4.xxx swizzling.
        /// </summary>
        public vec3 xxx => new vec3(x, x, x);
        
        /// <summary>
        /// Returns vec4.rrr swizzling (equivalent to vec4.xxx).
        /// </summary>
        public vec3 rrr => new vec3(x, x, x);
        
        /// <summary>
        /// Returns vec4.xxxx swizzling.
        /// </summary>
        public vec4 xxxx => new vec4(x, x, x, x);
        
        /// <summary>
        /// Returns vec4.rrrr swizzling (equivalent to vec4.xxxx).
        /// </summary>
        public vec4 rrrr => new vec4(x, x, x, x);
        
        /// <summary>
        /// Returns vec4.xxxxx swizzling.
        /// </summary>
        public vec5 xxxxx => new vec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns vec4.rrrrr swizzling (equivalent to vec4.xxxxx).
        /// </summary>
        public vec5 rrrrr => new vec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns vec4.xxxxy swizzling.
        /// </summary>
        public vec5 xxxxy => new vec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns vec4.rrrrg swizzling (equivalent to vec4.xxxxy).
        /// </summary>
        public vec5 rrrrg => new vec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns vec4.xxxxz swizzling.
        /// </summary>
        public vec5 xxxxz => new vec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns vec4.rrrrb swizzling (equivalent to vec4.xxxxz).
        /// </summary>
        public vec5 rrrrb => new vec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns vec4.xxxxw swizzling.
        /// </summary>
        public vec5 xxxxw => new vec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns vec4.rrrra swizzling (equivalent to vec4.xxxxw).
        /// </summary>
        public vec5 rrrra => new vec5(x, x, x, x, w);
        
        /// <summary>
        /// Returns vec4.xxxy swizzling.
        /// </summary>
        public vec4 xxxy => new vec4(x, x, x, y);
        
        /// <summary>
        /// Returns vec4.rrrg swizzling (equivalent to vec4.xxxy).
        /// </summary>
        public vec4 rrrg => new vec4(x, x, x, y);
        
        /// <summary>
        /// Returns vec4.xxxyx swizzling.
        /// </summary>
        public vec5 xxxyx => new vec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns vec4.rrrgr swizzling (equivalent to vec4.xxxyx).
        /// </summary>
        public vec5 rrrgr => new vec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns vec4.xxxyy swizzling.
        /// </summary>
        public vec5 xxxyy => new vec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns vec4.rrrgg swizzling (equivalent to vec4.xxxyy).
        /// </summary>
        public vec5 rrrgg => new vec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns vec4.xxxyz swizzling.
        /// </summary>
        public vec5 xxxyz => new vec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns vec4.rrrgb swizzling (equivalent to vec4.xxxyz).
        /// </summary>
        public vec5 rrrgb => new vec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns vec4.xxxyw swizzling.
        /// </summary>
        public vec5 xxxyw => new vec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns vec4.rrrga swizzling (equivalent to vec4.xxxyw).
        /// </summary>
        public vec5 rrrga => new vec5(x, x, x, y, w);
        
        /// <summary>
        /// Returns vec4.xxxz swizzling.
        /// </summary>
        public vec4 xxxz => new vec4(x, x, x, z);
        
        /// <summary>
        /// Returns vec4.rrrb swizzling (equivalent to vec4.xxxz).
        /// </summary>
        public vec4 rrrb => new vec4(x, x, x, z);
        
        /// <summary>
        /// Returns vec4.xxxzx swizzling.
        /// </summary>
        public vec5 xxxzx => new vec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns vec4.rrrbr swizzling (equivalent to vec4.xxxzx).
        /// </summary>
        public vec5 rrrbr => new vec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns vec4.xxxzy swizzling.
        /// </summary>
        public vec5 xxxzy => new vec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns vec4.rrrbg swizzling (equivalent to vec4.xxxzy).
        /// </summary>
        public vec5 rrrbg => new vec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns vec4.xxxzz swizzling.
        /// </summary>
        public vec5 xxxzz => new vec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns vec4.rrrbb swizzling (equivalent to vec4.xxxzz).
        /// </summary>
        public vec5 rrrbb => new vec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns vec4.xxxzw swizzling.
        /// </summary>
        public vec5 xxxzw => new vec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns vec4.rrrba swizzling (equivalent to vec4.xxxzw).
        /// </summary>
        public vec5 rrrba => new vec5(x, x, x, z, w);
        
        /// <summary>
        /// Returns vec4.xxxw swizzling.
        /// </summary>
        public vec4 xxxw => new vec4(x, x, x, w);
        
        /// <summary>
        /// Returns vec4.rrra swizzling (equivalent to vec4.xxxw).
        /// </summary>
        public vec4 rrra => new vec4(x, x, x, w);
        
        /// <summary>
        /// Returns vec4.xxxwx swizzling.
        /// </summary>
        public vec5 xxxwx => new vec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns vec4.rrrar swizzling (equivalent to vec4.xxxwx).
        /// </summary>
        public vec5 rrrar => new vec5(x, x, x, w, x);
        
        /// <summary>
        /// Returns vec4.xxxwy swizzling.
        /// </summary>
        public vec5 xxxwy => new vec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns vec4.rrrag swizzling (equivalent to vec4.xxxwy).
        /// </summary>
        public vec5 rrrag => new vec5(x, x, x, w, y);
        
        /// <summary>
        /// Returns vec4.xxxwz swizzling.
        /// </summary>
        public vec5 xxxwz => new vec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns vec4.rrrab swizzling (equivalent to vec4.xxxwz).
        /// </summary>
        public vec5 rrrab => new vec5(x, x, x, w, z);
        
        /// <summary>
        /// Returns vec4.xxxww swizzling.
        /// </summary>
        public vec5 xxxww => new vec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns vec4.rrraa swizzling (equivalent to vec4.xxxww).
        /// </summary>
        public vec5 rrraa => new vec5(x, x, x, w, w);
        
        /// <summary>
        /// Returns vec4.xxy swizzling.
        /// </summary>
        public vec3 xxy => new vec3(x, x, y);
        
        /// <summary>
        /// Returns vec4.rrg swizzling (equivalent to vec4.xxy).
        /// </summary>
        public vec3 rrg => new vec3(x, x, y);
        
        /// <summary>
        /// Returns vec4.xxyx swizzling.
        /// </summary>
        public vec4 xxyx => new vec4(x, x, y, x);
        
        /// <summary>
        /// Returns vec4.rrgr swizzling (equivalent to vec4.xxyx).
        /// </summary>
        public vec4 rrgr => new vec4(x, x, y, x);
        
        /// <summary>
        /// Returns vec4.xxyxx swizzling.
        /// </summary>
        public vec5 xxyxx => new vec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns vec4.rrgrr swizzling (equivalent to vec4.xxyxx).
        /// </summary>
        public vec5 rrgrr => new vec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns vec4.xxyxy swizzling.
        /// </summary>
        public vec5 xxyxy => new vec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns vec4.rrgrg swizzling (equivalent to vec4.xxyxy).
        /// </summary>
        public vec5 rrgrg => new vec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns vec4.xxyxz swizzling.
        /// </summary>
        public vec5 xxyxz => new vec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns vec4.rrgrb swizzling (equivalent to vec4.xxyxz).
        /// </summary>
        public vec5 rrgrb => new vec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns vec4.xxyxw swizzling.
        /// </summary>
        public vec5 xxyxw => new vec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns vec4.rrgra swizzling (equivalent to vec4.xxyxw).
        /// </summary>
        public vec5 rrgra => new vec5(x, x, y, x, w);
        
        /// <summary>
        /// Returns vec4.xxyy swizzling.
        /// </summary>
        public vec4 xxyy => new vec4(x, x, y, y);
        
        /// <summary>
        /// Returns vec4.rrgg swizzling (equivalent to vec4.xxyy).
        /// </summary>
        public vec4 rrgg => new vec4(x, x, y, y);
        
        /// <summary>
        /// Returns vec4.xxyyx swizzling.
        /// </summary>
        public vec5 xxyyx => new vec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns vec4.rrggr swizzling (equivalent to vec4.xxyyx).
        /// </summary>
        public vec5 rrggr => new vec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns vec4.xxyyy swizzling.
        /// </summary>
        public vec5 xxyyy => new vec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns vec4.rrggg swizzling (equivalent to vec4.xxyyy).
        /// </summary>
        public vec5 rrggg => new vec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns vec4.xxyyz swizzling.
        /// </summary>
        public vec5 xxyyz => new vec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns vec4.rrggb swizzling (equivalent to vec4.xxyyz).
        /// </summary>
        public vec5 rrggb => new vec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns vec4.xxyyw swizzling.
        /// </summary>
        public vec5 xxyyw => new vec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns vec4.rrgga swizzling (equivalent to vec4.xxyyw).
        /// </summary>
        public vec5 rrgga => new vec5(x, x, y, y, w);
        
        /// <summary>
        /// Returns vec4.xxyz swizzling.
        /// </summary>
        public vec4 xxyz => new vec4(x, x, y, z);
        
        /// <summary>
        /// Returns vec4.rrgb swizzling (equivalent to vec4.xxyz).
        /// </summary>
        public vec4 rrgb => new vec4(x, x, y, z);
        
        /// <summary>
        /// Returns vec4.xxyzx swizzling.
        /// </summary>
        public vec5 xxyzx => new vec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns vec4.rrgbr swizzling (equivalent to vec4.xxyzx).
        /// </summary>
        public vec5 rrgbr => new vec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns vec4.xxyzy swizzling.
        /// </summary>
        public vec5 xxyzy => new vec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns vec4.rrgbg swizzling (equivalent to vec4.xxyzy).
        /// </summary>
        public vec5 rrgbg => new vec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns vec4.xxyzz swizzling.
        /// </summary>
        public vec5 xxyzz => new vec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns vec4.rrgbb swizzling (equivalent to vec4.xxyzz).
        /// </summary>
        public vec5 rrgbb => new vec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns vec4.xxyzw swizzling.
        /// </summary>
        public vec5 xxyzw => new vec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns vec4.rrgba swizzling (equivalent to vec4.xxyzw).
        /// </summary>
        public vec5 rrgba => new vec5(x, x, y, z, w);
        
        /// <summary>
        /// Returns vec4.xxyw swizzling.
        /// </summary>
        public vec4 xxyw => new vec4(x, x, y, w);
        
        /// <summary>
        /// Returns vec4.rrga swizzling (equivalent to vec4.xxyw).
        /// </summary>
        public vec4 rrga => new vec4(x, x, y, w);
        
        /// <summary>
        /// Returns vec4.xxywx swizzling.
        /// </summary>
        public vec5 xxywx => new vec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns vec4.rrgar swizzling (equivalent to vec4.xxywx).
        /// </summary>
        public vec5 rrgar => new vec5(x, x, y, w, x);
        
        /// <summary>
        /// Returns vec4.xxywy swizzling.
        /// </summary>
        public vec5 xxywy => new vec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns vec4.rrgag swizzling (equivalent to vec4.xxywy).
        /// </summary>
        public vec5 rrgag => new vec5(x, x, y, w, y);
        
        /// <summary>
        /// Returns vec4.xxywz swizzling.
        /// </summary>
        public vec5 xxywz => new vec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns vec4.rrgab swizzling (equivalent to vec4.xxywz).
        /// </summary>
        public vec5 rrgab => new vec5(x, x, y, w, z);
        
        /// <summary>
        /// Returns vec4.xxyww swizzling.
        /// </summary>
        public vec5 xxyww => new vec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns vec4.rrgaa swizzling (equivalent to vec4.xxyww).
        /// </summary>
        public vec5 rrgaa => new vec5(x, x, y, w, w);
        
        /// <summary>
        /// Returns vec4.xxz swizzling.
        /// </summary>
        public vec3 xxz => new vec3(x, x, z);
        
        /// <summary>
        /// Returns vec4.rrb swizzling (equivalent to vec4.xxz).
        /// </summary>
        public vec3 rrb => new vec3(x, x, z);
        
        /// <summary>
        /// Returns vec4.xxzx swizzling.
        /// </summary>
        public vec4 xxzx => new vec4(x, x, z, x);
        
        /// <summary>
        /// Returns vec4.rrbr swizzling (equivalent to vec4.xxzx).
        /// </summary>
        public vec4 rrbr => new vec4(x, x, z, x);
        
        /// <summary>
        /// Returns vec4.xxzxx swizzling.
        /// </summary>
        public vec5 xxzxx => new vec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns vec4.rrbrr swizzling (equivalent to vec4.xxzxx).
        /// </summary>
        public vec5 rrbrr => new vec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns vec4.xxzxy swizzling.
        /// </summary>
        public vec5 xxzxy => new vec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns vec4.rrbrg swizzling (equivalent to vec4.xxzxy).
        /// </summary>
        public vec5 rrbrg => new vec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns vec4.xxzxz swizzling.
        /// </summary>
        public vec5 xxzxz => new vec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns vec4.rrbrb swizzling (equivalent to vec4.xxzxz).
        /// </summary>
        public vec5 rrbrb => new vec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns vec4.xxzxw swizzling.
        /// </summary>
        public vec5 xxzxw => new vec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns vec4.rrbra swizzling (equivalent to vec4.xxzxw).
        /// </summary>
        public vec5 rrbra => new vec5(x, x, z, x, w);
        
        /// <summary>
        /// Returns vec4.xxzy swizzling.
        /// </summary>
        public vec4 xxzy => new vec4(x, x, z, y);
        
        /// <summary>
        /// Returns vec4.rrbg swizzling (equivalent to vec4.xxzy).
        /// </summary>
        public vec4 rrbg => new vec4(x, x, z, y);
        
        /// <summary>
        /// Returns vec4.xxzyx swizzling.
        /// </summary>
        public vec5 xxzyx => new vec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns vec4.rrbgr swizzling (equivalent to vec4.xxzyx).
        /// </summary>
        public vec5 rrbgr => new vec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns vec4.xxzyy swizzling.
        /// </summary>
        public vec5 xxzyy => new vec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns vec4.rrbgg swizzling (equivalent to vec4.xxzyy).
        /// </summary>
        public vec5 rrbgg => new vec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns vec4.xxzyz swizzling.
        /// </summary>
        public vec5 xxzyz => new vec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns vec4.rrbgb swizzling (equivalent to vec4.xxzyz).
        /// </summary>
        public vec5 rrbgb => new vec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns vec4.xxzyw swizzling.
        /// </summary>
        public vec5 xxzyw => new vec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns vec4.rrbga swizzling (equivalent to vec4.xxzyw).
        /// </summary>
        public vec5 rrbga => new vec5(x, x, z, y, w);
        
        /// <summary>
        /// Returns vec4.xxzz swizzling.
        /// </summary>
        public vec4 xxzz => new vec4(x, x, z, z);
        
        /// <summary>
        /// Returns vec4.rrbb swizzling (equivalent to vec4.xxzz).
        /// </summary>
        public vec4 rrbb => new vec4(x, x, z, z);
        
        /// <summary>
        /// Returns vec4.xxzzx swizzling.
        /// </summary>
        public vec5 xxzzx => new vec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns vec4.rrbbr swizzling (equivalent to vec4.xxzzx).
        /// </summary>
        public vec5 rrbbr => new vec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns vec4.xxzzy swizzling.
        /// </summary>
        public vec5 xxzzy => new vec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns vec4.rrbbg swizzling (equivalent to vec4.xxzzy).
        /// </summary>
        public vec5 rrbbg => new vec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns vec4.xxzzz swizzling.
        /// </summary>
        public vec5 xxzzz => new vec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns vec4.rrbbb swizzling (equivalent to vec4.xxzzz).
        /// </summary>
        public vec5 rrbbb => new vec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns vec4.xxzzw swizzling.
        /// </summary>
        public vec5 xxzzw => new vec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns vec4.rrbba swizzling (equivalent to vec4.xxzzw).
        /// </summary>
        public vec5 rrbba => new vec5(x, x, z, z, w);
        
        /// <summary>
        /// Returns vec4.xxzw swizzling.
        /// </summary>
        public vec4 xxzw => new vec4(x, x, z, w);
        
        /// <summary>
        /// Returns vec4.rrba swizzling (equivalent to vec4.xxzw).
        /// </summary>
        public vec4 rrba => new vec4(x, x, z, w);
        
        /// <summary>
        /// Returns vec4.xxzwx swizzling.
        /// </summary>
        public vec5 xxzwx => new vec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns vec4.rrbar swizzling (equivalent to vec4.xxzwx).
        /// </summary>
        public vec5 rrbar => new vec5(x, x, z, w, x);
        
        /// <summary>
        /// Returns vec4.xxzwy swizzling.
        /// </summary>
        public vec5 xxzwy => new vec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns vec4.rrbag swizzling (equivalent to vec4.xxzwy).
        /// </summary>
        public vec5 rrbag => new vec5(x, x, z, w, y);
        
        /// <summary>
        /// Returns vec4.xxzwz swizzling.
        /// </summary>
        public vec5 xxzwz => new vec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns vec4.rrbab swizzling (equivalent to vec4.xxzwz).
        /// </summary>
        public vec5 rrbab => new vec5(x, x, z, w, z);
        
        /// <summary>
        /// Returns vec4.xxzww swizzling.
        /// </summary>
        public vec5 xxzww => new vec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns vec4.rrbaa swizzling (equivalent to vec4.xxzww).
        /// </summary>
        public vec5 rrbaa => new vec5(x, x, z, w, w);
        
        /// <summary>
        /// Returns vec4.xxw swizzling.
        /// </summary>
        public vec3 xxw => new vec3(x, x, w);
        
        /// <summary>
        /// Returns vec4.rra swizzling (equivalent to vec4.xxw).
        /// </summary>
        public vec3 rra => new vec3(x, x, w);
        
        /// <summary>
        /// Returns vec4.xxwx swizzling.
        /// </summary>
        public vec4 xxwx => new vec4(x, x, w, x);
        
        /// <summary>
        /// Returns vec4.rrar swizzling (equivalent to vec4.xxwx).
        /// </summary>
        public vec4 rrar => new vec4(x, x, w, x);
        
        /// <summary>
        /// Returns vec4.xxwxx swizzling.
        /// </summary>
        public vec5 xxwxx => new vec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns vec4.rrarr swizzling (equivalent to vec4.xxwxx).
        /// </summary>
        public vec5 rrarr => new vec5(x, x, w, x, x);
        
        /// <summary>
        /// Returns vec4.xxwxy swizzling.
        /// </summary>
        public vec5 xxwxy => new vec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns vec4.rrarg swizzling (equivalent to vec4.xxwxy).
        /// </summary>
        public vec5 rrarg => new vec5(x, x, w, x, y);
        
        /// <summary>
        /// Returns vec4.xxwxz swizzling.
        /// </summary>
        public vec5 xxwxz => new vec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns vec4.rrarb swizzling (equivalent to vec4.xxwxz).
        /// </summary>
        public vec5 rrarb => new vec5(x, x, w, x, z);
        
        /// <summary>
        /// Returns vec4.xxwxw swizzling.
        /// </summary>
        public vec5 xxwxw => new vec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns vec4.rrara swizzling (equivalent to vec4.xxwxw).
        /// </summary>
        public vec5 rrara => new vec5(x, x, w, x, w);
        
        /// <summary>
        /// Returns vec4.xxwy swizzling.
        /// </summary>
        public vec4 xxwy => new vec4(x, x, w, y);
        
        /// <summary>
        /// Returns vec4.rrag swizzling (equivalent to vec4.xxwy).
        /// </summary>
        public vec4 rrag => new vec4(x, x, w, y);
        
        /// <summary>
        /// Returns vec4.xxwyx swizzling.
        /// </summary>
        public vec5 xxwyx => new vec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns vec4.rragr swizzling (equivalent to vec4.xxwyx).
        /// </summary>
        public vec5 rragr => new vec5(x, x, w, y, x);
        
        /// <summary>
        /// Returns vec4.xxwyy swizzling.
        /// </summary>
        public vec5 xxwyy => new vec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns vec4.rragg swizzling (equivalent to vec4.xxwyy).
        /// </summary>
        public vec5 rragg => new vec5(x, x, w, y, y);
        
        /// <summary>
        /// Returns vec4.xxwyz swizzling.
        /// </summary>
        public vec5 xxwyz => new vec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns vec4.rragb swizzling (equivalent to vec4.xxwyz).
        /// </summary>
        public vec5 rragb => new vec5(x, x, w, y, z);
        
        /// <summary>
        /// Returns vec4.xxwyw swizzling.
        /// </summary>
        public vec5 xxwyw => new vec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns vec4.rraga swizzling (equivalent to vec4.xxwyw).
        /// </summary>
        public vec5 rraga => new vec5(x, x, w, y, w);
        
        /// <summary>
        /// Returns vec4.xxwz swizzling.
        /// </summary>
        public vec4 xxwz => new vec4(x, x, w, z);
        
        /// <summary>
        /// Returns vec4.rrab swizzling (equivalent to vec4.xxwz).
        /// </summary>
        public vec4 rrab => new vec4(x, x, w, z);
        
        /// <summary>
        /// Returns vec4.xxwzx swizzling.
        /// </summary>
        public vec5 xxwzx => new vec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns vec4.rrabr swizzling (equivalent to vec4.xxwzx).
        /// </summary>
        public vec5 rrabr => new vec5(x, x, w, z, x);
        
        /// <summary>
        /// Returns vec4.xxwzy swizzling.
        /// </summary>
        public vec5 xxwzy => new vec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns vec4.rrabg swizzling (equivalent to vec4.xxwzy).
        /// </summary>
        public vec5 rrabg => new vec5(x, x, w, z, y);
        
        /// <summary>
        /// Returns vec4.xxwzz swizzling.
        /// </summary>
        public vec5 xxwzz => new vec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns vec4.rrabb swizzling (equivalent to vec4.xxwzz).
        /// </summary>
        public vec5 rrabb => new vec5(x, x, w, z, z);
        
        /// <summary>
        /// Returns vec4.xxwzw swizzling.
        /// </summary>
        public vec5 xxwzw => new vec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns vec4.rraba swizzling (equivalent to vec4.xxwzw).
        /// </summary>
        public vec5 rraba => new vec5(x, x, w, z, w);
        
        /// <summary>
        /// Returns vec4.xxww swizzling.
        /// </summary>
        public vec4 xxww => new vec4(x, x, w, w);
        
        /// <summary>
        /// Returns vec4.rraa swizzling (equivalent to vec4.xxww).
        /// </summary>
        public vec4 rraa => new vec4(x, x, w, w);
        
        /// <summary>
        /// Returns vec4.xxwwx swizzling.
        /// </summary>
        public vec5 xxwwx => new vec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns vec4.rraar swizzling (equivalent to vec4.xxwwx).
        /// </summary>
        public vec5 rraar => new vec5(x, x, w, w, x);
        
        /// <summary>
        /// Returns vec4.xxwwy swizzling.
        /// </summary>
        public vec5 xxwwy => new vec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns vec4.rraag swizzling (equivalent to vec4.xxwwy).
        /// </summary>
        public vec5 rraag => new vec5(x, x, w, w, y);
        
        /// <summary>
        /// Returns vec4.xxwwz swizzling.
        /// </summary>
        public vec5 xxwwz => new vec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns vec4.rraab swizzling (equivalent to vec4.xxwwz).
        /// </summary>
        public vec5 rraab => new vec5(x, x, w, w, z);
        
        /// <summary>
        /// Returns vec4.xxwww swizzling.
        /// </summary>
        public vec5 xxwww => new vec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns vec4.rraaa swizzling (equivalent to vec4.xxwww).
        /// </summary>
        public vec5 rraaa => new vec5(x, x, w, w, w);
        
        /// <summary>
        /// Returns vec4.xy swizzling.
        /// </summary>
        public vec2 xy => new vec2(x, y);
        
        /// <summary>
        /// Returns vec4.rg swizzling (equivalent to vec4.xy).
        /// </summary>
        public vec2 rg => new vec2(x, y);
        
        /// <summary>
        /// Returns vec4.xyx swizzling.
        /// </summary>
        public vec3 xyx => new vec3(x, y, x);
        
        /// <summary>
        /// Returns vec4.rgr swizzling (equivalent to vec4.xyx).
        /// </summary>
        public vec3 rgr => new vec3(x, y, x);
        
        /// <summary>
        /// Returns vec4.xyxx swizzling.
        /// </summary>
        public vec4 xyxx => new vec4(x, y, x, x);
        
        /// <summary>
        /// Returns vec4.rgrr swizzling (equivalent to vec4.xyxx).
        /// </summary>
        public vec4 rgrr => new vec4(x, y, x, x);
        
        /// <summary>
        /// Returns vec4.xyxxx swizzling.
        /// </summary>
        public vec5 xyxxx => new vec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns vec4.rgrrr swizzling (equivalent to vec4.xyxxx).
        /// </summary>
        public vec5 rgrrr => new vec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns vec4.xyxxy swizzling.
        /// </summary>
        public vec5 xyxxy => new vec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns vec4.rgrrg swizzling (equivalent to vec4.xyxxy).
        /// </summary>
        public vec5 rgrrg => new vec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns vec4.xyxxz swizzling.
        /// </summary>
        public vec5 xyxxz => new vec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns vec4.rgrrb swizzling (equivalent to vec4.xyxxz).
        /// </summary>
        public vec5 rgrrb => new vec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns vec4.xyxxw swizzling.
        /// </summary>
        public vec5 xyxxw => new vec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns vec4.rgrra swizzling (equivalent to vec4.xyxxw).
        /// </summary>
        public vec5 rgrra => new vec5(x, y, x, x, w);
        
        /// <summary>
        /// Returns vec4.xyxy swizzling.
        /// </summary>
        public vec4 xyxy => new vec4(x, y, x, y);
        
        /// <summary>
        /// Returns vec4.rgrg swizzling (equivalent to vec4.xyxy).
        /// </summary>
        public vec4 rgrg => new vec4(x, y, x, y);
        
        /// <summary>
        /// Returns vec4.xyxyx swizzling.
        /// </summary>
        public vec5 xyxyx => new vec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns vec4.rgrgr swizzling (equivalent to vec4.xyxyx).
        /// </summary>
        public vec5 rgrgr => new vec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns vec4.xyxyy swizzling.
        /// </summary>
        public vec5 xyxyy => new vec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns vec4.rgrgg swizzling (equivalent to vec4.xyxyy).
        /// </summary>
        public vec5 rgrgg => new vec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns vec4.xyxyz swizzling.
        /// </summary>
        public vec5 xyxyz => new vec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns vec4.rgrgb swizzling (equivalent to vec4.xyxyz).
        /// </summary>
        public vec5 rgrgb => new vec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns vec4.xyxyw swizzling.
        /// </summary>
        public vec5 xyxyw => new vec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns vec4.rgrga swizzling (equivalent to vec4.xyxyw).
        /// </summary>
        public vec5 rgrga => new vec5(x, y, x, y, w);
        
        /// <summary>
        /// Returns vec4.xyxz swizzling.
        /// </summary>
        public vec4 xyxz => new vec4(x, y, x, z);
        
        /// <summary>
        /// Returns vec4.rgrb swizzling (equivalent to vec4.xyxz).
        /// </summary>
        public vec4 rgrb => new vec4(x, y, x, z);
        
        /// <summary>
        /// Returns vec4.xyxzx swizzling.
        /// </summary>
        public vec5 xyxzx => new vec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns vec4.rgrbr swizzling (equivalent to vec4.xyxzx).
        /// </summary>
        public vec5 rgrbr => new vec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns vec4.xyxzy swizzling.
        /// </summary>
        public vec5 xyxzy => new vec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns vec4.rgrbg swizzling (equivalent to vec4.xyxzy).
        /// </summary>
        public vec5 rgrbg => new vec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns vec4.xyxzz swizzling.
        /// </summary>
        public vec5 xyxzz => new vec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns vec4.rgrbb swizzling (equivalent to vec4.xyxzz).
        /// </summary>
        public vec5 rgrbb => new vec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns vec4.xyxzw swizzling.
        /// </summary>
        public vec5 xyxzw => new vec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns vec4.rgrba swizzling (equivalent to vec4.xyxzw).
        /// </summary>
        public vec5 rgrba => new vec5(x, y, x, z, w);
        
        /// <summary>
        /// Returns vec4.xyxw swizzling.
        /// </summary>
        public vec4 xyxw => new vec4(x, y, x, w);
        
        /// <summary>
        /// Returns vec4.rgra swizzling (equivalent to vec4.xyxw).
        /// </summary>
        public vec4 rgra => new vec4(x, y, x, w);
        
        /// <summary>
        /// Returns vec4.xyxwx swizzling.
        /// </summary>
        public vec5 xyxwx => new vec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns vec4.rgrar swizzling (equivalent to vec4.xyxwx).
        /// </summary>
        public vec5 rgrar => new vec5(x, y, x, w, x);
        
        /// <summary>
        /// Returns vec4.xyxwy swizzling.
        /// </summary>
        public vec5 xyxwy => new vec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns vec4.rgrag swizzling (equivalent to vec4.xyxwy).
        /// </summary>
        public vec5 rgrag => new vec5(x, y, x, w, y);
        
        /// <summary>
        /// Returns vec4.xyxwz swizzling.
        /// </summary>
        public vec5 xyxwz => new vec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns vec4.rgrab swizzling (equivalent to vec4.xyxwz).
        /// </summary>
        public vec5 rgrab => new vec5(x, y, x, w, z);
        
        /// <summary>
        /// Returns vec4.xyxww swizzling.
        /// </summary>
        public vec5 xyxww => new vec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns vec4.rgraa swizzling (equivalent to vec4.xyxww).
        /// </summary>
        public vec5 rgraa => new vec5(x, y, x, w, w);
        
        /// <summary>
        /// Returns vec4.xyy swizzling.
        /// </summary>
        public vec3 xyy => new vec3(x, y, y);
        
        /// <summary>
        /// Returns vec4.rgg swizzling (equivalent to vec4.xyy).
        /// </summary>
        public vec3 rgg => new vec3(x, y, y);
        
        /// <summary>
        /// Returns vec4.xyyx swizzling.
        /// </summary>
        public vec4 xyyx => new vec4(x, y, y, x);
        
        /// <summary>
        /// Returns vec4.rggr swizzling (equivalent to vec4.xyyx).
        /// </summary>
        public vec4 rggr => new vec4(x, y, y, x);
        
        /// <summary>
        /// Returns vec4.xyyxx swizzling.
        /// </summary>
        public vec5 xyyxx => new vec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns vec4.rggrr swizzling (equivalent to vec4.xyyxx).
        /// </summary>
        public vec5 rggrr => new vec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns vec4.xyyxy swizzling.
        /// </summary>
        public vec5 xyyxy => new vec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns vec4.rggrg swizzling (equivalent to vec4.xyyxy).
        /// </summary>
        public vec5 rggrg => new vec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns vec4.xyyxz swizzling.
        /// </summary>
        public vec5 xyyxz => new vec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns vec4.rggrb swizzling (equivalent to vec4.xyyxz).
        /// </summary>
        public vec5 rggrb => new vec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns vec4.xyyxw swizzling.
        /// </summary>
        public vec5 xyyxw => new vec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns vec4.rggra swizzling (equivalent to vec4.xyyxw).
        /// </summary>
        public vec5 rggra => new vec5(x, y, y, x, w);
        
        /// <summary>
        /// Returns vec4.xyyy swizzling.
        /// </summary>
        public vec4 xyyy => new vec4(x, y, y, y);
        
        /// <summary>
        /// Returns vec4.rggg swizzling (equivalent to vec4.xyyy).
        /// </summary>
        public vec4 rggg => new vec4(x, y, y, y);
        
        /// <summary>
        /// Returns vec4.xyyyx swizzling.
        /// </summary>
        public vec5 xyyyx => new vec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns vec4.rgggr swizzling (equivalent to vec4.xyyyx).
        /// </summary>
        public vec5 rgggr => new vec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns vec4.xyyyy swizzling.
        /// </summary>
        public vec5 xyyyy => new vec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns vec4.rgggg swizzling (equivalent to vec4.xyyyy).
        /// </summary>
        public vec5 rgggg => new vec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns vec4.xyyyz swizzling.
        /// </summary>
        public vec5 xyyyz => new vec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns vec4.rgggb swizzling (equivalent to vec4.xyyyz).
        /// </summary>
        public vec5 rgggb => new vec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns vec4.xyyyw swizzling.
        /// </summary>
        public vec5 xyyyw => new vec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns vec4.rggga swizzling (equivalent to vec4.xyyyw).
        /// </summary>
        public vec5 rggga => new vec5(x, y, y, y, w);
        
        /// <summary>
        /// Returns vec4.xyyz swizzling.
        /// </summary>
        public vec4 xyyz => new vec4(x, y, y, z);
        
        /// <summary>
        /// Returns vec4.rggb swizzling (equivalent to vec4.xyyz).
        /// </summary>
        public vec4 rggb => new vec4(x, y, y, z);
        
        /// <summary>
        /// Returns vec4.xyyzx swizzling.
        /// </summary>
        public vec5 xyyzx => new vec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns vec4.rggbr swizzling (equivalent to vec4.xyyzx).
        /// </summary>
        public vec5 rggbr => new vec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns vec4.xyyzy swizzling.
        /// </summary>
        public vec5 xyyzy => new vec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns vec4.rggbg swizzling (equivalent to vec4.xyyzy).
        /// </summary>
        public vec5 rggbg => new vec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns vec4.xyyzz swizzling.
        /// </summary>
        public vec5 xyyzz => new vec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns vec4.rggbb swizzling (equivalent to vec4.xyyzz).
        /// </summary>
        public vec5 rggbb => new vec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns vec4.xyyzw swizzling.
        /// </summary>
        public vec5 xyyzw => new vec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns vec4.rggba swizzling (equivalent to vec4.xyyzw).
        /// </summary>
        public vec5 rggba => new vec5(x, y, y, z, w);
        
        /// <summary>
        /// Returns vec4.xyyw swizzling.
        /// </summary>
        public vec4 xyyw => new vec4(x, y, y, w);
        
        /// <summary>
        /// Returns vec4.rgga swizzling (equivalent to vec4.xyyw).
        /// </summary>
        public vec4 rgga => new vec4(x, y, y, w);
        
        /// <summary>
        /// Returns vec4.xyywx swizzling.
        /// </summary>
        public vec5 xyywx => new vec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns vec4.rggar swizzling (equivalent to vec4.xyywx).
        /// </summary>
        public vec5 rggar => new vec5(x, y, y, w, x);
        
        /// <summary>
        /// Returns vec4.xyywy swizzling.
        /// </summary>
        public vec5 xyywy => new vec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns vec4.rggag swizzling (equivalent to vec4.xyywy).
        /// </summary>
        public vec5 rggag => new vec5(x, y, y, w, y);
        
        /// <summary>
        /// Returns vec4.xyywz swizzling.
        /// </summary>
        public vec5 xyywz => new vec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns vec4.rggab swizzling (equivalent to vec4.xyywz).
        /// </summary>
        public vec5 rggab => new vec5(x, y, y, w, z);
        
        /// <summary>
        /// Returns vec4.xyyww swizzling.
        /// </summary>
        public vec5 xyyww => new vec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns vec4.rggaa swizzling (equivalent to vec4.xyyww).
        /// </summary>
        public vec5 rggaa => new vec5(x, y, y, w, w);
        
        /// <summary>
        /// Returns vec4.xyz swizzling.
        /// </summary>
        public vec3 xyz => new vec3(x, y, z);
        
        /// <summary>
        /// Returns vec4.rgb swizzling (equivalent to vec4.xyz).
        /// </summary>
        public vec3 rgb => new vec3(x, y, z);
        
        /// <summary>
        /// Returns vec4.xyzx swizzling.
        /// </summary>
        public vec4 xyzx => new vec4(x, y, z, x);
        
        /// <summary>
        /// Returns vec4.rgbr swizzling (equivalent to vec4.xyzx).
        /// </summary>
        public vec4 rgbr => new vec4(x, y, z, x);
        
        /// <summary>
        /// Returns vec4.xyzxx swizzling.
        /// </summary>
        public vec5 xyzxx => new vec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns vec4.rgbrr swizzling (equivalent to vec4.xyzxx).
        /// </summary>
        public vec5 rgbrr => new vec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns vec4.xyzxy swizzling.
        /// </summary>
        public vec5 xyzxy => new vec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns vec4.rgbrg swizzling (equivalent to vec4.xyzxy).
        /// </summary>
        public vec5 rgbrg => new vec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns vec4.xyzxz swizzling.
        /// </summary>
        public vec5 xyzxz => new vec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns vec4.rgbrb swizzling (equivalent to vec4.xyzxz).
        /// </summary>
        public vec5 rgbrb => new vec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns vec4.xyzxw swizzling.
        /// </summary>
        public vec5 xyzxw => new vec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns vec4.rgbra swizzling (equivalent to vec4.xyzxw).
        /// </summary>
        public vec5 rgbra => new vec5(x, y, z, x, w);
        
        /// <summary>
        /// Returns vec4.xyzy swizzling.
        /// </summary>
        public vec4 xyzy => new vec4(x, y, z, y);
        
        /// <summary>
        /// Returns vec4.rgbg swizzling (equivalent to vec4.xyzy).
        /// </summary>
        public vec4 rgbg => new vec4(x, y, z, y);
        
        /// <summary>
        /// Returns vec4.xyzyx swizzling.
        /// </summary>
        public vec5 xyzyx => new vec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns vec4.rgbgr swizzling (equivalent to vec4.xyzyx).
        /// </summary>
        public vec5 rgbgr => new vec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns vec4.xyzyy swizzling.
        /// </summary>
        public vec5 xyzyy => new vec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns vec4.rgbgg swizzling (equivalent to vec4.xyzyy).
        /// </summary>
        public vec5 rgbgg => new vec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns vec4.xyzyz swizzling.
        /// </summary>
        public vec5 xyzyz => new vec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns vec4.rgbgb swizzling (equivalent to vec4.xyzyz).
        /// </summary>
        public vec5 rgbgb => new vec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns vec4.xyzyw swizzling.
        /// </summary>
        public vec5 xyzyw => new vec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns vec4.rgbga swizzling (equivalent to vec4.xyzyw).
        /// </summary>
        public vec5 rgbga => new vec5(x, y, z, y, w);
        
        /// <summary>
        /// Returns vec4.xyzz swizzling.
        /// </summary>
        public vec4 xyzz => new vec4(x, y, z, z);
        
        /// <summary>
        /// Returns vec4.rgbb swizzling (equivalent to vec4.xyzz).
        /// </summary>
        public vec4 rgbb => new vec4(x, y, z, z);
        
        /// <summary>
        /// Returns vec4.xyzzx swizzling.
        /// </summary>
        public vec5 xyzzx => new vec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns vec4.rgbbr swizzling (equivalent to vec4.xyzzx).
        /// </summary>
        public vec5 rgbbr => new vec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns vec4.xyzzy swizzling.
        /// </summary>
        public vec5 xyzzy => new vec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns vec4.rgbbg swizzling (equivalent to vec4.xyzzy).
        /// </summary>
        public vec5 rgbbg => new vec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns vec4.xyzzz swizzling.
        /// </summary>
        public vec5 xyzzz => new vec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns vec4.rgbbb swizzling (equivalent to vec4.xyzzz).
        /// </summary>
        public vec5 rgbbb => new vec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns vec4.xyzzw swizzling.
        /// </summary>
        public vec5 xyzzw => new vec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns vec4.rgbba swizzling (equivalent to vec4.xyzzw).
        /// </summary>
        public vec5 rgbba => new vec5(x, y, z, z, w);
        
        /// <summary>
        /// Returns vec4.xyzw swizzling.
        /// </summary>
        public vec4 xyzw => new vec4(x, y, z, w);
        
        /// <summary>
        /// Returns vec4.rgba swizzling (equivalent to vec4.xyzw).
        /// </summary>
        public vec4 rgba => new vec4(x, y, z, w);
        
        /// <summary>
        /// Returns vec4.xyzwx swizzling.
        /// </summary>
        public vec5 xyzwx => new vec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns vec4.rgbar swizzling (equivalent to vec4.xyzwx).
        /// </summary>
        public vec5 rgbar => new vec5(x, y, z, w, x);
        
        /// <summary>
        /// Returns vec4.xyzwy swizzling.
        /// </summary>
        public vec5 xyzwy => new vec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns vec4.rgbag swizzling (equivalent to vec4.xyzwy).
        /// </summary>
        public vec5 rgbag => new vec5(x, y, z, w, y);
        
        /// <summary>
        /// Returns vec4.xyzwz swizzling.
        /// </summary>
        public vec5 xyzwz => new vec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns vec4.rgbab swizzling (equivalent to vec4.xyzwz).
        /// </summary>
        public vec5 rgbab => new vec5(x, y, z, w, z);
        
        /// <summary>
        /// Returns vec4.xyzww swizzling.
        /// </summary>
        public vec5 xyzww => new vec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns vec4.rgbaa swizzling (equivalent to vec4.xyzww).
        /// </summary>
        public vec5 rgbaa => new vec5(x, y, z, w, w);
        
        /// <summary>
        /// Returns vec4.xyw swizzling.
        /// </summary>
        public vec3 xyw => new vec3(x, y, w);
        
        /// <summary>
        /// Returns vec4.rga swizzling (equivalent to vec4.xyw).
        /// </summary>
        public vec3 rga => new vec3(x, y, w);
        
        /// <summary>
        /// Returns vec4.xywx swizzling.
        /// </summary>
        public vec4 xywx => new vec4(x, y, w, x);
        
        /// <summary>
        /// Returns vec4.rgar swizzling (equivalent to vec4.xywx).
        /// </summary>
        public vec4 rgar => new vec4(x, y, w, x);
        
        /// <summary>
        /// Returns vec4.xywxx swizzling.
        /// </summary>
        public vec5 xywxx => new vec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns vec4.rgarr swizzling (equivalent to vec4.xywxx).
        /// </summary>
        public vec5 rgarr => new vec5(x, y, w, x, x);
        
        /// <summary>
        /// Returns vec4.xywxy swizzling.
        /// </summary>
        public vec5 xywxy => new vec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns vec4.rgarg swizzling (equivalent to vec4.xywxy).
        /// </summary>
        public vec5 rgarg => new vec5(x, y, w, x, y);
        
        /// <summary>
        /// Returns vec4.xywxz swizzling.
        /// </summary>
        public vec5 xywxz => new vec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns vec4.rgarb swizzling (equivalent to vec4.xywxz).
        /// </summary>
        public vec5 rgarb => new vec5(x, y, w, x, z);
        
        /// <summary>
        /// Returns vec4.xywxw swizzling.
        /// </summary>
        public vec5 xywxw => new vec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns vec4.rgara swizzling (equivalent to vec4.xywxw).
        /// </summary>
        public vec5 rgara => new vec5(x, y, w, x, w);
        
        /// <summary>
        /// Returns vec4.xywy swizzling.
        /// </summary>
        public vec4 xywy => new vec4(x, y, w, y);
        
        /// <summary>
        /// Returns vec4.rgag swizzling (equivalent to vec4.xywy).
        /// </summary>
        public vec4 rgag => new vec4(x, y, w, y);
        
        /// <summary>
        /// Returns vec4.xywyx swizzling.
        /// </summary>
        public vec5 xywyx => new vec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns vec4.rgagr swizzling (equivalent to vec4.xywyx).
        /// </summary>
        public vec5 rgagr => new vec5(x, y, w, y, x);
        
        /// <summary>
        /// Returns vec4.xywyy swizzling.
        /// </summary>
        public vec5 xywyy => new vec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns vec4.rgagg swizzling (equivalent to vec4.xywyy).
        /// </summary>
        public vec5 rgagg => new vec5(x, y, w, y, y);
        
        /// <summary>
        /// Returns vec4.xywyz swizzling.
        /// </summary>
        public vec5 xywyz => new vec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns vec4.rgagb swizzling (equivalent to vec4.xywyz).
        /// </summary>
        public vec5 rgagb => new vec5(x, y, w, y, z);
        
        /// <summary>
        /// Returns vec4.xywyw swizzling.
        /// </summary>
        public vec5 xywyw => new vec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns vec4.rgaga swizzling (equivalent to vec4.xywyw).
        /// </summary>
        public vec5 rgaga => new vec5(x, y, w, y, w);
        
        /// <summary>
        /// Returns vec4.xywz swizzling.
        /// </summary>
        public vec4 xywz => new vec4(x, y, w, z);
        
        /// <summary>
        /// Returns vec4.rgab swizzling (equivalent to vec4.xywz).
        /// </summary>
        public vec4 rgab => new vec4(x, y, w, z);
        
        /// <summary>
        /// Returns vec4.xywzx swizzling.
        /// </summary>
        public vec5 xywzx => new vec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns vec4.rgabr swizzling (equivalent to vec4.xywzx).
        /// </summary>
        public vec5 rgabr => new vec5(x, y, w, z, x);
        
        /// <summary>
        /// Returns vec4.xywzy swizzling.
        /// </summary>
        public vec5 xywzy => new vec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns vec4.rgabg swizzling (equivalent to vec4.xywzy).
        /// </summary>
        public vec5 rgabg => new vec5(x, y, w, z, y);
        
        /// <summary>
        /// Returns vec4.xywzz swizzling.
        /// </summary>
        public vec5 xywzz => new vec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns vec4.rgabb swizzling (equivalent to vec4.xywzz).
        /// </summary>
        public vec5 rgabb => new vec5(x, y, w, z, z);
        
        /// <summary>
        /// Returns vec4.xywzw swizzling.
        /// </summary>
        public vec5 xywzw => new vec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns vec4.rgaba swizzling (equivalent to vec4.xywzw).
        /// </summary>
        public vec5 rgaba => new vec5(x, y, w, z, w);
        
        /// <summary>
        /// Returns vec4.xyww swizzling.
        /// </summary>
        public vec4 xyww => new vec4(x, y, w, w);
        
        /// <summary>
        /// Returns vec4.rgaa swizzling (equivalent to vec4.xyww).
        /// </summary>
        public vec4 rgaa => new vec4(x, y, w, w);
        
        /// <summary>
        /// Returns vec4.xywwx swizzling.
        /// </summary>
        public vec5 xywwx => new vec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns vec4.rgaar swizzling (equivalent to vec4.xywwx).
        /// </summary>
        public vec5 rgaar => new vec5(x, y, w, w, x);
        
        /// <summary>
        /// Returns vec4.xywwy swizzling.
        /// </summary>
        public vec5 xywwy => new vec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns vec4.rgaag swizzling (equivalent to vec4.xywwy).
        /// </summary>
        public vec5 rgaag => new vec5(x, y, w, w, y);
        
        /// <summary>
        /// Returns vec4.xywwz swizzling.
        /// </summary>
        public vec5 xywwz => new vec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns vec4.rgaab swizzling (equivalent to vec4.xywwz).
        /// </summary>
        public vec5 rgaab => new vec5(x, y, w, w, z);
        
        /// <summary>
        /// Returns vec4.xywww swizzling.
        /// </summary>
        public vec5 xywww => new vec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns vec4.rgaaa swizzling (equivalent to vec4.xywww).
        /// </summary>
        public vec5 rgaaa => new vec5(x, y, w, w, w);
        
        /// <summary>
        /// Returns vec4.xz swizzling.
        /// </summary>
        public vec2 xz => new vec2(x, z);
        
        /// <summary>
        /// Returns vec4.rb swizzling (equivalent to vec4.xz).
        /// </summary>
        public vec2 rb => new vec2(x, z);
        
        /// <summary>
        /// Returns vec4.xzx swizzling.
        /// </summary>
        public vec3 xzx => new vec3(x, z, x);
        
        /// <summary>
        /// Returns vec4.rbr swizzling (equivalent to vec4.xzx).
        /// </summary>
        public vec3 rbr => new vec3(x, z, x);
        
        /// <summary>
        /// Returns vec4.xzxx swizzling.
        /// </summary>
        public vec4 xzxx => new vec4(x, z, x, x);
        
        /// <summary>
        /// Returns vec4.rbrr swizzling (equivalent to vec4.xzxx).
        /// </summary>
        public vec4 rbrr => new vec4(x, z, x, x);
        
        /// <summary>
        /// Returns vec4.xzxxx swizzling.
        /// </summary>
        public vec5 xzxxx => new vec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns vec4.rbrrr swizzling (equivalent to vec4.xzxxx).
        /// </summary>
        public vec5 rbrrr => new vec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns vec4.xzxxy swizzling.
        /// </summary>
        public vec5 xzxxy => new vec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns vec4.rbrrg swizzling (equivalent to vec4.xzxxy).
        /// </summary>
        public vec5 rbrrg => new vec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns vec4.xzxxz swizzling.
        /// </summary>
        public vec5 xzxxz => new vec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns vec4.rbrrb swizzling (equivalent to vec4.xzxxz).
        /// </summary>
        public vec5 rbrrb => new vec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns vec4.xzxxw swizzling.
        /// </summary>
        public vec5 xzxxw => new vec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns vec4.rbrra swizzling (equivalent to vec4.xzxxw).
        /// </summary>
        public vec5 rbrra => new vec5(x, z, x, x, w);
        
        /// <summary>
        /// Returns vec4.xzxy swizzling.
        /// </summary>
        public vec4 xzxy => new vec4(x, z, x, y);
        
        /// <summary>
        /// Returns vec4.rbrg swizzling (equivalent to vec4.xzxy).
        /// </summary>
        public vec4 rbrg => new vec4(x, z, x, y);
        
        /// <summary>
        /// Returns vec4.xzxyx swizzling.
        /// </summary>
        public vec5 xzxyx => new vec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns vec4.rbrgr swizzling (equivalent to vec4.xzxyx).
        /// </summary>
        public vec5 rbrgr => new vec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns vec4.xzxyy swizzling.
        /// </summary>
        public vec5 xzxyy => new vec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns vec4.rbrgg swizzling (equivalent to vec4.xzxyy).
        /// </summary>
        public vec5 rbrgg => new vec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns vec4.xzxyz swizzling.
        /// </summary>
        public vec5 xzxyz => new vec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns vec4.rbrgb swizzling (equivalent to vec4.xzxyz).
        /// </summary>
        public vec5 rbrgb => new vec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns vec4.xzxyw swizzling.
        /// </summary>
        public vec5 xzxyw => new vec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns vec4.rbrga swizzling (equivalent to vec4.xzxyw).
        /// </summary>
        public vec5 rbrga => new vec5(x, z, x, y, w);
        
        /// <summary>
        /// Returns vec4.xzxz swizzling.
        /// </summary>
        public vec4 xzxz => new vec4(x, z, x, z);
        
        /// <summary>
        /// Returns vec4.rbrb swizzling (equivalent to vec4.xzxz).
        /// </summary>
        public vec4 rbrb => new vec4(x, z, x, z);
        
        /// <summary>
        /// Returns vec4.xzxzx swizzling.
        /// </summary>
        public vec5 xzxzx => new vec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns vec4.rbrbr swizzling (equivalent to vec4.xzxzx).
        /// </summary>
        public vec5 rbrbr => new vec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns vec4.xzxzy swizzling.
        /// </summary>
        public vec5 xzxzy => new vec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns vec4.rbrbg swizzling (equivalent to vec4.xzxzy).
        /// </summary>
        public vec5 rbrbg => new vec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns vec4.xzxzz swizzling.
        /// </summary>
        public vec5 xzxzz => new vec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns vec4.rbrbb swizzling (equivalent to vec4.xzxzz).
        /// </summary>
        public vec5 rbrbb => new vec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns vec4.xzxzw swizzling.
        /// </summary>
        public vec5 xzxzw => new vec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns vec4.rbrba swizzling (equivalent to vec4.xzxzw).
        /// </summary>
        public vec5 rbrba => new vec5(x, z, x, z, w);
        
        /// <summary>
        /// Returns vec4.xzxw swizzling.
        /// </summary>
        public vec4 xzxw => new vec4(x, z, x, w);
        
        /// <summary>
        /// Returns vec4.rbra swizzling (equivalent to vec4.xzxw).
        /// </summary>
        public vec4 rbra => new vec4(x, z, x, w);
        
        /// <summary>
        /// Returns vec4.xzxwx swizzling.
        /// </summary>
        public vec5 xzxwx => new vec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns vec4.rbrar swizzling (equivalent to vec4.xzxwx).
        /// </summary>
        public vec5 rbrar => new vec5(x, z, x, w, x);
        
        /// <summary>
        /// Returns vec4.xzxwy swizzling.
        /// </summary>
        public vec5 xzxwy => new vec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns vec4.rbrag swizzling (equivalent to vec4.xzxwy).
        /// </summary>
        public vec5 rbrag => new vec5(x, z, x, w, y);
        
        /// <summary>
        /// Returns vec4.xzxwz swizzling.
        /// </summary>
        public vec5 xzxwz => new vec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns vec4.rbrab swizzling (equivalent to vec4.xzxwz).
        /// </summary>
        public vec5 rbrab => new vec5(x, z, x, w, z);
        
        /// <summary>
        /// Returns vec4.xzxww swizzling.
        /// </summary>
        public vec5 xzxww => new vec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns vec4.rbraa swizzling (equivalent to vec4.xzxww).
        /// </summary>
        public vec5 rbraa => new vec5(x, z, x, w, w);
        
        /// <summary>
        /// Returns vec4.xzy swizzling.
        /// </summary>
        public vec3 xzy => new vec3(x, z, y);
        
        /// <summary>
        /// Returns vec4.rbg swizzling (equivalent to vec4.xzy).
        /// </summary>
        public vec3 rbg => new vec3(x, z, y);
        
        /// <summary>
        /// Returns vec4.xzyx swizzling.
        /// </summary>
        public vec4 xzyx => new vec4(x, z, y, x);
        
        /// <summary>
        /// Returns vec4.rbgr swizzling (equivalent to vec4.xzyx).
        /// </summary>
        public vec4 rbgr => new vec4(x, z, y, x);
        
        /// <summary>
        /// Returns vec4.xzyxx swizzling.
        /// </summary>
        public vec5 xzyxx => new vec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns vec4.rbgrr swizzling (equivalent to vec4.xzyxx).
        /// </summary>
        public vec5 rbgrr => new vec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns vec4.xzyxy swizzling.
        /// </summary>
        public vec5 xzyxy => new vec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns vec4.rbgrg swizzling (equivalent to vec4.xzyxy).
        /// </summary>
        public vec5 rbgrg => new vec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns vec4.xzyxz swizzling.
        /// </summary>
        public vec5 xzyxz => new vec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns vec4.rbgrb swizzling (equivalent to vec4.xzyxz).
        /// </summary>
        public vec5 rbgrb => new vec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns vec4.xzyxw swizzling.
        /// </summary>
        public vec5 xzyxw => new vec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns vec4.rbgra swizzling (equivalent to vec4.xzyxw).
        /// </summary>
        public vec5 rbgra => new vec5(x, z, y, x, w);
        
        /// <summary>
        /// Returns vec4.xzyy swizzling.
        /// </summary>
        public vec4 xzyy => new vec4(x, z, y, y);
        
        /// <summary>
        /// Returns vec4.rbgg swizzling (equivalent to vec4.xzyy).
        /// </summary>
        public vec4 rbgg => new vec4(x, z, y, y);
        
        /// <summary>
        /// Returns vec4.xzyyx swizzling.
        /// </summary>
        public vec5 xzyyx => new vec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns vec4.rbggr swizzling (equivalent to vec4.xzyyx).
        /// </summary>
        public vec5 rbggr => new vec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns vec4.xzyyy swizzling.
        /// </summary>
        public vec5 xzyyy => new vec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns vec4.rbggg swizzling (equivalent to vec4.xzyyy).
        /// </summary>
        public vec5 rbggg => new vec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns vec4.xzyyz swizzling.
        /// </summary>
        public vec5 xzyyz => new vec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns vec4.rbggb swizzling (equivalent to vec4.xzyyz).
        /// </summary>
        public vec5 rbggb => new vec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns vec4.xzyyw swizzling.
        /// </summary>
        public vec5 xzyyw => new vec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns vec4.rbgga swizzling (equivalent to vec4.xzyyw).
        /// </summary>
        public vec5 rbgga => new vec5(x, z, y, y, w);
        
        /// <summary>
        /// Returns vec4.xzyz swizzling.
        /// </summary>
        public vec4 xzyz => new vec4(x, z, y, z);
        
        /// <summary>
        /// Returns vec4.rbgb swizzling (equivalent to vec4.xzyz).
        /// </summary>
        public vec4 rbgb => new vec4(x, z, y, z);
        
        /// <summary>
        /// Returns vec4.xzyzx swizzling.
        /// </summary>
        public vec5 xzyzx => new vec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns vec4.rbgbr swizzling (equivalent to vec4.xzyzx).
        /// </summary>
        public vec5 rbgbr => new vec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns vec4.xzyzy swizzling.
        /// </summary>
        public vec5 xzyzy => new vec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns vec4.rbgbg swizzling (equivalent to vec4.xzyzy).
        /// </summary>
        public vec5 rbgbg => new vec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns vec4.xzyzz swizzling.
        /// </summary>
        public vec5 xzyzz => new vec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns vec4.rbgbb swizzling (equivalent to vec4.xzyzz).
        /// </summary>
        public vec5 rbgbb => new vec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns vec4.xzyzw swizzling.
        /// </summary>
        public vec5 xzyzw => new vec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns vec4.rbgba swizzling (equivalent to vec4.xzyzw).
        /// </summary>
        public vec5 rbgba => new vec5(x, z, y, z, w);
        
        /// <summary>
        /// Returns vec4.xzyw swizzling.
        /// </summary>
        public vec4 xzyw => new vec4(x, z, y, w);
        
        /// <summary>
        /// Returns vec4.rbga swizzling (equivalent to vec4.xzyw).
        /// </summary>
        public vec4 rbga => new vec4(x, z, y, w);
        
        /// <summary>
        /// Returns vec4.xzywx swizzling.
        /// </summary>
        public vec5 xzywx => new vec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns vec4.rbgar swizzling (equivalent to vec4.xzywx).
        /// </summary>
        public vec5 rbgar => new vec5(x, z, y, w, x);
        
        /// <summary>
        /// Returns vec4.xzywy swizzling.
        /// </summary>
        public vec5 xzywy => new vec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns vec4.rbgag swizzling (equivalent to vec4.xzywy).
        /// </summary>
        public vec5 rbgag => new vec5(x, z, y, w, y);
        
        /// <summary>
        /// Returns vec4.xzywz swizzling.
        /// </summary>
        public vec5 xzywz => new vec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns vec4.rbgab swizzling (equivalent to vec4.xzywz).
        /// </summary>
        public vec5 rbgab => new vec5(x, z, y, w, z);
        
        /// <summary>
        /// Returns vec4.xzyww swizzling.
        /// </summary>
        public vec5 xzyww => new vec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns vec4.rbgaa swizzling (equivalent to vec4.xzyww).
        /// </summary>
        public vec5 rbgaa => new vec5(x, z, y, w, w);
        
        /// <summary>
        /// Returns vec4.xzz swizzling.
        /// </summary>
        public vec3 xzz => new vec3(x, z, z);
        
        /// <summary>
        /// Returns vec4.rbb swizzling (equivalent to vec4.xzz).
        /// </summary>
        public vec3 rbb => new vec3(x, z, z);
        
        /// <summary>
        /// Returns vec4.xzzx swizzling.
        /// </summary>
        public vec4 xzzx => new vec4(x, z, z, x);
        
        /// <summary>
        /// Returns vec4.rbbr swizzling (equivalent to vec4.xzzx).
        /// </summary>
        public vec4 rbbr => new vec4(x, z, z, x);
        
        /// <summary>
        /// Returns vec4.xzzxx swizzling.
        /// </summary>
        public vec5 xzzxx => new vec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns vec4.rbbrr swizzling (equivalent to vec4.xzzxx).
        /// </summary>
        public vec5 rbbrr => new vec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns vec4.xzzxy swizzling.
        /// </summary>
        public vec5 xzzxy => new vec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns vec4.rbbrg swizzling (equivalent to vec4.xzzxy).
        /// </summary>
        public vec5 rbbrg => new vec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns vec4.xzzxz swizzling.
        /// </summary>
        public vec5 xzzxz => new vec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns vec4.rbbrb swizzling (equivalent to vec4.xzzxz).
        /// </summary>
        public vec5 rbbrb => new vec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns vec4.xzzxw swizzling.
        /// </summary>
        public vec5 xzzxw => new vec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns vec4.rbbra swizzling (equivalent to vec4.xzzxw).
        /// </summary>
        public vec5 rbbra => new vec5(x, z, z, x, w);
        
        /// <summary>
        /// Returns vec4.xzzy swizzling.
        /// </summary>
        public vec4 xzzy => new vec4(x, z, z, y);
        
        /// <summary>
        /// Returns vec4.rbbg swizzling (equivalent to vec4.xzzy).
        /// </summary>
        public vec4 rbbg => new vec4(x, z, z, y);
        
        /// <summary>
        /// Returns vec4.xzzyx swizzling.
        /// </summary>
        public vec5 xzzyx => new vec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns vec4.rbbgr swizzling (equivalent to vec4.xzzyx).
        /// </summary>
        public vec5 rbbgr => new vec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns vec4.xzzyy swizzling.
        /// </summary>
        public vec5 xzzyy => new vec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns vec4.rbbgg swizzling (equivalent to vec4.xzzyy).
        /// </summary>
        public vec5 rbbgg => new vec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns vec4.xzzyz swizzling.
        /// </summary>
        public vec5 xzzyz => new vec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns vec4.rbbgb swizzling (equivalent to vec4.xzzyz).
        /// </summary>
        public vec5 rbbgb => new vec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns vec4.xzzyw swizzling.
        /// </summary>
        public vec5 xzzyw => new vec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns vec4.rbbga swizzling (equivalent to vec4.xzzyw).
        /// </summary>
        public vec5 rbbga => new vec5(x, z, z, y, w);
        
        /// <summary>
        /// Returns vec4.xzzz swizzling.
        /// </summary>
        public vec4 xzzz => new vec4(x, z, z, z);
        
        /// <summary>
        /// Returns vec4.rbbb swizzling (equivalent to vec4.xzzz).
        /// </summary>
        public vec4 rbbb => new vec4(x, z, z, z);
        
        /// <summary>
        /// Returns vec4.xzzzx swizzling.
        /// </summary>
        public vec5 xzzzx => new vec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns vec4.rbbbr swizzling (equivalent to vec4.xzzzx).
        /// </summary>
        public vec5 rbbbr => new vec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns vec4.xzzzy swizzling.
        /// </summary>
        public vec5 xzzzy => new vec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns vec4.rbbbg swizzling (equivalent to vec4.xzzzy).
        /// </summary>
        public vec5 rbbbg => new vec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns vec4.xzzzz swizzling.
        /// </summary>
        public vec5 xzzzz => new vec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns vec4.rbbbb swizzling (equivalent to vec4.xzzzz).
        /// </summary>
        public vec5 rbbbb => new vec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns vec4.xzzzw swizzling.
        /// </summary>
        public vec5 xzzzw => new vec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns vec4.rbbba swizzling (equivalent to vec4.xzzzw).
        /// </summary>
        public vec5 rbbba => new vec5(x, z, z, z, w);
        
        /// <summary>
        /// Returns vec4.xzzw swizzling.
        /// </summary>
        public vec4 xzzw => new vec4(x, z, z, w);
        
        /// <summary>
        /// Returns vec4.rbba swizzling (equivalent to vec4.xzzw).
        /// </summary>
        public vec4 rbba => new vec4(x, z, z, w);
        
        /// <summary>
        /// Returns vec4.xzzwx swizzling.
        /// </summary>
        public vec5 xzzwx => new vec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns vec4.rbbar swizzling (equivalent to vec4.xzzwx).
        /// </summary>
        public vec5 rbbar => new vec5(x, z, z, w, x);
        
        /// <summary>
        /// Returns vec4.xzzwy swizzling.
        /// </summary>
        public vec5 xzzwy => new vec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns vec4.rbbag swizzling (equivalent to vec4.xzzwy).
        /// </summary>
        public vec5 rbbag => new vec5(x, z, z, w, y);
        
        /// <summary>
        /// Returns vec4.xzzwz swizzling.
        /// </summary>
        public vec5 xzzwz => new vec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns vec4.rbbab swizzling (equivalent to vec4.xzzwz).
        /// </summary>
        public vec5 rbbab => new vec5(x, z, z, w, z);
        
        /// <summary>
        /// Returns vec4.xzzww swizzling.
        /// </summary>
        public vec5 xzzww => new vec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns vec4.rbbaa swizzling (equivalent to vec4.xzzww).
        /// </summary>
        public vec5 rbbaa => new vec5(x, z, z, w, w);
        
        /// <summary>
        /// Returns vec4.xzw swizzling.
        /// </summary>
        public vec3 xzw => new vec3(x, z, w);
        
        /// <summary>
        /// Returns vec4.rba swizzling (equivalent to vec4.xzw).
        /// </summary>
        public vec3 rba => new vec3(x, z, w);
        
        /// <summary>
        /// Returns vec4.xzwx swizzling.
        /// </summary>
        public vec4 xzwx => new vec4(x, z, w, x);
        
        /// <summary>
        /// Returns vec4.rbar swizzling (equivalent to vec4.xzwx).
        /// </summary>
        public vec4 rbar => new vec4(x, z, w, x);
        
        /// <summary>
        /// Returns vec4.xzwxx swizzling.
        /// </summary>
        public vec5 xzwxx => new vec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns vec4.rbarr swizzling (equivalent to vec4.xzwxx).
        /// </summary>
        public vec5 rbarr => new vec5(x, z, w, x, x);
        
        /// <summary>
        /// Returns vec4.xzwxy swizzling.
        /// </summary>
        public vec5 xzwxy => new vec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns vec4.rbarg swizzling (equivalent to vec4.xzwxy).
        /// </summary>
        public vec5 rbarg => new vec5(x, z, w, x, y);
        
        /// <summary>
        /// Returns vec4.xzwxz swizzling.
        /// </summary>
        public vec5 xzwxz => new vec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns vec4.rbarb swizzling (equivalent to vec4.xzwxz).
        /// </summary>
        public vec5 rbarb => new vec5(x, z, w, x, z);
        
        /// <summary>
        /// Returns vec4.xzwxw swizzling.
        /// </summary>
        public vec5 xzwxw => new vec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns vec4.rbara swizzling (equivalent to vec4.xzwxw).
        /// </summary>
        public vec5 rbara => new vec5(x, z, w, x, w);
        
        /// <summary>
        /// Returns vec4.xzwy swizzling.
        /// </summary>
        public vec4 xzwy => new vec4(x, z, w, y);
        
        /// <summary>
        /// Returns vec4.rbag swizzling (equivalent to vec4.xzwy).
        /// </summary>
        public vec4 rbag => new vec4(x, z, w, y);
        
        /// <summary>
        /// Returns vec4.xzwyx swizzling.
        /// </summary>
        public vec5 xzwyx => new vec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns vec4.rbagr swizzling (equivalent to vec4.xzwyx).
        /// </summary>
        public vec5 rbagr => new vec5(x, z, w, y, x);
        
        /// <summary>
        /// Returns vec4.xzwyy swizzling.
        /// </summary>
        public vec5 xzwyy => new vec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns vec4.rbagg swizzling (equivalent to vec4.xzwyy).
        /// </summary>
        public vec5 rbagg => new vec5(x, z, w, y, y);
        
        /// <summary>
        /// Returns vec4.xzwyz swizzling.
        /// </summary>
        public vec5 xzwyz => new vec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns vec4.rbagb swizzling (equivalent to vec4.xzwyz).
        /// </summary>
        public vec5 rbagb => new vec5(x, z, w, y, z);
        
        /// <summary>
        /// Returns vec4.xzwyw swizzling.
        /// </summary>
        public vec5 xzwyw => new vec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns vec4.rbaga swizzling (equivalent to vec4.xzwyw).
        /// </summary>
        public vec5 rbaga => new vec5(x, z, w, y, w);
        
        /// <summary>
        /// Returns vec4.xzwz swizzling.
        /// </summary>
        public vec4 xzwz => new vec4(x, z, w, z);
        
        /// <summary>
        /// Returns vec4.rbab swizzling (equivalent to vec4.xzwz).
        /// </summary>
        public vec4 rbab => new vec4(x, z, w, z);
        
        /// <summary>
        /// Returns vec4.xzwzx swizzling.
        /// </summary>
        public vec5 xzwzx => new vec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns vec4.rbabr swizzling (equivalent to vec4.xzwzx).
        /// </summary>
        public vec5 rbabr => new vec5(x, z, w, z, x);
        
        /// <summary>
        /// Returns vec4.xzwzy swizzling.
        /// </summary>
        public vec5 xzwzy => new vec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns vec4.rbabg swizzling (equivalent to vec4.xzwzy).
        /// </summary>
        public vec5 rbabg => new vec5(x, z, w, z, y);
        
        /// <summary>
        /// Returns vec4.xzwzz swizzling.
        /// </summary>
        public vec5 xzwzz => new vec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns vec4.rbabb swizzling (equivalent to vec4.xzwzz).
        /// </summary>
        public vec5 rbabb => new vec5(x, z, w, z, z);
        
        /// <summary>
        /// Returns vec4.xzwzw swizzling.
        /// </summary>
        public vec5 xzwzw => new vec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns vec4.rbaba swizzling (equivalent to vec4.xzwzw).
        /// </summary>
        public vec5 rbaba => new vec5(x, z, w, z, w);
        
        /// <summary>
        /// Returns vec4.xzww swizzling.
        /// </summary>
        public vec4 xzww => new vec4(x, z, w, w);
        
        /// <summary>
        /// Returns vec4.rbaa swizzling (equivalent to vec4.xzww).
        /// </summary>
        public vec4 rbaa => new vec4(x, z, w, w);
        
        /// <summary>
        /// Returns vec4.xzwwx swizzling.
        /// </summary>
        public vec5 xzwwx => new vec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns vec4.rbaar swizzling (equivalent to vec4.xzwwx).
        /// </summary>
        public vec5 rbaar => new vec5(x, z, w, w, x);
        
        /// <summary>
        /// Returns vec4.xzwwy swizzling.
        /// </summary>
        public vec5 xzwwy => new vec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns vec4.rbaag swizzling (equivalent to vec4.xzwwy).
        /// </summary>
        public vec5 rbaag => new vec5(x, z, w, w, y);
        
        /// <summary>
        /// Returns vec4.xzwwz swizzling.
        /// </summary>
        public vec5 xzwwz => new vec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns vec4.rbaab swizzling (equivalent to vec4.xzwwz).
        /// </summary>
        public vec5 rbaab => new vec5(x, z, w, w, z);
        
        /// <summary>
        /// Returns vec4.xzwww swizzling.
        /// </summary>
        public vec5 xzwww => new vec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns vec4.rbaaa swizzling (equivalent to vec4.xzwww).
        /// </summary>
        public vec5 rbaaa => new vec5(x, z, w, w, w);
        
        /// <summary>
        /// Returns vec4.xw swizzling.
        /// </summary>
        public vec2 xw => new vec2(x, w);
        
        /// <summary>
        /// Returns vec4.ra swizzling (equivalent to vec4.xw).
        /// </summary>
        public vec2 ra => new vec2(x, w);
        
        /// <summary>
        /// Returns vec4.xwx swizzling.
        /// </summary>
        public vec3 xwx => new vec3(x, w, x);
        
        /// <summary>
        /// Returns vec4.rar swizzling (equivalent to vec4.xwx).
        /// </summary>
        public vec3 rar => new vec3(x, w, x);
        
        /// <summary>
        /// Returns vec4.xwxx swizzling.
        /// </summary>
        public vec4 xwxx => new vec4(x, w, x, x);
        
        /// <summary>
        /// Returns vec4.rarr swizzling (equivalent to vec4.xwxx).
        /// </summary>
        public vec4 rarr => new vec4(x, w, x, x);
        
        /// <summary>
        /// Returns vec4.xwxxx swizzling.
        /// </summary>
        public vec5 xwxxx => new vec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns vec4.rarrr swizzling (equivalent to vec4.xwxxx).
        /// </summary>
        public vec5 rarrr => new vec5(x, w, x, x, x);
        
        /// <summary>
        /// Returns vec4.xwxxy swizzling.
        /// </summary>
        public vec5 xwxxy => new vec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns vec4.rarrg swizzling (equivalent to vec4.xwxxy).
        /// </summary>
        public vec5 rarrg => new vec5(x, w, x, x, y);
        
        /// <summary>
        /// Returns vec4.xwxxz swizzling.
        /// </summary>
        public vec5 xwxxz => new vec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns vec4.rarrb swizzling (equivalent to vec4.xwxxz).
        /// </summary>
        public vec5 rarrb => new vec5(x, w, x, x, z);
        
        /// <summary>
        /// Returns vec4.xwxxw swizzling.
        /// </summary>
        public vec5 xwxxw => new vec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns vec4.rarra swizzling (equivalent to vec4.xwxxw).
        /// </summary>
        public vec5 rarra => new vec5(x, w, x, x, w);
        
        /// <summary>
        /// Returns vec4.xwxy swizzling.
        /// </summary>
        public vec4 xwxy => new vec4(x, w, x, y);
        
        /// <summary>
        /// Returns vec4.rarg swizzling (equivalent to vec4.xwxy).
        /// </summary>
        public vec4 rarg => new vec4(x, w, x, y);
        
        /// <summary>
        /// Returns vec4.xwxyx swizzling.
        /// </summary>
        public vec5 xwxyx => new vec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns vec4.rargr swizzling (equivalent to vec4.xwxyx).
        /// </summary>
        public vec5 rargr => new vec5(x, w, x, y, x);
        
        /// <summary>
        /// Returns vec4.xwxyy swizzling.
        /// </summary>
        public vec5 xwxyy => new vec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns vec4.rargg swizzling (equivalent to vec4.xwxyy).
        /// </summary>
        public vec5 rargg => new vec5(x, w, x, y, y);
        
        /// <summary>
        /// Returns vec4.xwxyz swizzling.
        /// </summary>
        public vec5 xwxyz => new vec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns vec4.rargb swizzling (equivalent to vec4.xwxyz).
        /// </summary>
        public vec5 rargb => new vec5(x, w, x, y, z);
        
        /// <summary>
        /// Returns vec4.xwxyw swizzling.
        /// </summary>
        public vec5 xwxyw => new vec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns vec4.rarga swizzling (equivalent to vec4.xwxyw).
        /// </summary>
        public vec5 rarga => new vec5(x, w, x, y, w);
        
        /// <summary>
        /// Returns vec4.xwxz swizzling.
        /// </summary>
        public vec4 xwxz => new vec4(x, w, x, z);
        
        /// <summary>
        /// Returns vec4.rarb swizzling (equivalent to vec4.xwxz).
        /// </summary>
        public vec4 rarb => new vec4(x, w, x, z);
        
        /// <summary>
        /// Returns vec4.xwxzx swizzling.
        /// </summary>
        public vec5 xwxzx => new vec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns vec4.rarbr swizzling (equivalent to vec4.xwxzx).
        /// </summary>
        public vec5 rarbr => new vec5(x, w, x, z, x);
        
        /// <summary>
        /// Returns vec4.xwxzy swizzling.
        /// </summary>
        public vec5 xwxzy => new vec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns vec4.rarbg swizzling (equivalent to vec4.xwxzy).
        /// </summary>
        public vec5 rarbg => new vec5(x, w, x, z, y);
        
        /// <summary>
        /// Returns vec4.xwxzz swizzling.
        /// </summary>
        public vec5 xwxzz => new vec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns vec4.rarbb swizzling (equivalent to vec4.xwxzz).
        /// </summary>
        public vec5 rarbb => new vec5(x, w, x, z, z);
        
        /// <summary>
        /// Returns vec4.xwxzw swizzling.
        /// </summary>
        public vec5 xwxzw => new vec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns vec4.rarba swizzling (equivalent to vec4.xwxzw).
        /// </summary>
        public vec5 rarba => new vec5(x, w, x, z, w);
        
        /// <summary>
        /// Returns vec4.xwxw swizzling.
        /// </summary>
        public vec4 xwxw => new vec4(x, w, x, w);
        
        /// <summary>
        /// Returns vec4.rara swizzling (equivalent to vec4.xwxw).
        /// </summary>
        public vec4 rara => new vec4(x, w, x, w);
        
        /// <summary>
        /// Returns vec4.xwxwx swizzling.
        /// </summary>
        public vec5 xwxwx => new vec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns vec4.rarar swizzling (equivalent to vec4.xwxwx).
        /// </summary>
        public vec5 rarar => new vec5(x, w, x, w, x);
        
        /// <summary>
        /// Returns vec4.xwxwy swizzling.
        /// </summary>
        public vec5 xwxwy => new vec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns vec4.rarag swizzling (equivalent to vec4.xwxwy).
        /// </summary>
        public vec5 rarag => new vec5(x, w, x, w, y);
        
        /// <summary>
        /// Returns vec4.xwxwz swizzling.
        /// </summary>
        public vec5 xwxwz => new vec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns vec4.rarab swizzling (equivalent to vec4.xwxwz).
        /// </summary>
        public vec5 rarab => new vec5(x, w, x, w, z);
        
        /// <summary>
        /// Returns vec4.xwxww swizzling.
        /// </summary>
        public vec5 xwxww => new vec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns vec4.raraa swizzling (equivalent to vec4.xwxww).
        /// </summary>
        public vec5 raraa => new vec5(x, w, x, w, w);
        
        /// <summary>
        /// Returns vec4.xwy swizzling.
        /// </summary>
        public vec3 xwy => new vec3(x, w, y);
        
        /// <summary>
        /// Returns vec4.rag swizzling (equivalent to vec4.xwy).
        /// </summary>
        public vec3 rag => new vec3(x, w, y);
        
        /// <summary>
        /// Returns vec4.xwyx swizzling.
        /// </summary>
        public vec4 xwyx => new vec4(x, w, y, x);
        
        /// <summary>
        /// Returns vec4.ragr swizzling (equivalent to vec4.xwyx).
        /// </summary>
        public vec4 ragr => new vec4(x, w, y, x);
        
        /// <summary>
        /// Returns vec4.xwyxx swizzling.
        /// </summary>
        public vec5 xwyxx => new vec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns vec4.ragrr swizzling (equivalent to vec4.xwyxx).
        /// </summary>
        public vec5 ragrr => new vec5(x, w, y, x, x);
        
        /// <summary>
        /// Returns vec4.xwyxy swizzling.
        /// </summary>
        public vec5 xwyxy => new vec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns vec4.ragrg swizzling (equivalent to vec4.xwyxy).
        /// </summary>
        public vec5 ragrg => new vec5(x, w, y, x, y);
        
        /// <summary>
        /// Returns vec4.xwyxz swizzling.
        /// </summary>
        public vec5 xwyxz => new vec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns vec4.ragrb swizzling (equivalent to vec4.xwyxz).
        /// </summary>
        public vec5 ragrb => new vec5(x, w, y, x, z);
        
        /// <summary>
        /// Returns vec4.xwyxw swizzling.
        /// </summary>
        public vec5 xwyxw => new vec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns vec4.ragra swizzling (equivalent to vec4.xwyxw).
        /// </summary>
        public vec5 ragra => new vec5(x, w, y, x, w);
        
        /// <summary>
        /// Returns vec4.xwyy swizzling.
        /// </summary>
        public vec4 xwyy => new vec4(x, w, y, y);
        
        /// <summary>
        /// Returns vec4.ragg swizzling (equivalent to vec4.xwyy).
        /// </summary>
        public vec4 ragg => new vec4(x, w, y, y);
        
        /// <summary>
        /// Returns vec4.xwyyx swizzling.
        /// </summary>
        public vec5 xwyyx => new vec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns vec4.raggr swizzling (equivalent to vec4.xwyyx).
        /// </summary>
        public vec5 raggr => new vec5(x, w, y, y, x);
        
        /// <summary>
        /// Returns vec4.xwyyy swizzling.
        /// </summary>
        public vec5 xwyyy => new vec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns vec4.raggg swizzling (equivalent to vec4.xwyyy).
        /// </summary>
        public vec5 raggg => new vec5(x, w, y, y, y);
        
        /// <summary>
        /// Returns vec4.xwyyz swizzling.
        /// </summary>
        public vec5 xwyyz => new vec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns vec4.raggb swizzling (equivalent to vec4.xwyyz).
        /// </summary>
        public vec5 raggb => new vec5(x, w, y, y, z);
        
        /// <summary>
        /// Returns vec4.xwyyw swizzling.
        /// </summary>
        public vec5 xwyyw => new vec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns vec4.ragga swizzling (equivalent to vec4.xwyyw).
        /// </summary>
        public vec5 ragga => new vec5(x, w, y, y, w);
        
        /// <summary>
        /// Returns vec4.xwyz swizzling.
        /// </summary>
        public vec4 xwyz => new vec4(x, w, y, z);
        
        /// <summary>
        /// Returns vec4.ragb swizzling (equivalent to vec4.xwyz).
        /// </summary>
        public vec4 ragb => new vec4(x, w, y, z);
        
        /// <summary>
        /// Returns vec4.xwyzx swizzling.
        /// </summary>
        public vec5 xwyzx => new vec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns vec4.ragbr swizzling (equivalent to vec4.xwyzx).
        /// </summary>
        public vec5 ragbr => new vec5(x, w, y, z, x);
        
        /// <summary>
        /// Returns vec4.xwyzy swizzling.
        /// </summary>
        public vec5 xwyzy => new vec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns vec4.ragbg swizzling (equivalent to vec4.xwyzy).
        /// </summary>
        public vec5 ragbg => new vec5(x, w, y, z, y);
        
        /// <summary>
        /// Returns vec4.xwyzz swizzling.
        /// </summary>
        public vec5 xwyzz => new vec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns vec4.ragbb swizzling (equivalent to vec4.xwyzz).
        /// </summary>
        public vec5 ragbb => new vec5(x, w, y, z, z);
        
        /// <summary>
        /// Returns vec4.xwyzw swizzling.
        /// </summary>
        public vec5 xwyzw => new vec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns vec4.ragba swizzling (equivalent to vec4.xwyzw).
        /// </summary>
        public vec5 ragba => new vec5(x, w, y, z, w);
        
        /// <summary>
        /// Returns vec4.xwyw swizzling.
        /// </summary>
        public vec4 xwyw => new vec4(x, w, y, w);
        
        /// <summary>
        /// Returns vec4.raga swizzling (equivalent to vec4.xwyw).
        /// </summary>
        public vec4 raga => new vec4(x, w, y, w);
        
        /// <summary>
        /// Returns vec4.xwywx swizzling.
        /// </summary>
        public vec5 xwywx => new vec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns vec4.ragar swizzling (equivalent to vec4.xwywx).
        /// </summary>
        public vec5 ragar => new vec5(x, w, y, w, x);
        
        /// <summary>
        /// Returns vec4.xwywy swizzling.
        /// </summary>
        public vec5 xwywy => new vec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns vec4.ragag swizzling (equivalent to vec4.xwywy).
        /// </summary>
        public vec5 ragag => new vec5(x, w, y, w, y);
        
        /// <summary>
        /// Returns vec4.xwywz swizzling.
        /// </summary>
        public vec5 xwywz => new vec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns vec4.ragab swizzling (equivalent to vec4.xwywz).
        /// </summary>
        public vec5 ragab => new vec5(x, w, y, w, z);
        
        /// <summary>
        /// Returns vec4.xwyww swizzling.
        /// </summary>
        public vec5 xwyww => new vec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns vec4.ragaa swizzling (equivalent to vec4.xwyww).
        /// </summary>
        public vec5 ragaa => new vec5(x, w, y, w, w);
        
        /// <summary>
        /// Returns vec4.xwz swizzling.
        /// </summary>
        public vec3 xwz => new vec3(x, w, z);
        
        /// <summary>
        /// Returns vec4.rab swizzling (equivalent to vec4.xwz).
        /// </summary>
        public vec3 rab => new vec3(x, w, z);
        
        /// <summary>
        /// Returns vec4.xwzx swizzling.
        /// </summary>
        public vec4 xwzx => new vec4(x, w, z, x);
        
        /// <summary>
        /// Returns vec4.rabr swizzling (equivalent to vec4.xwzx).
        /// </summary>
        public vec4 rabr => new vec4(x, w, z, x);
        
        /// <summary>
        /// Returns vec4.xwzxx swizzling.
        /// </summary>
        public vec5 xwzxx => new vec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns vec4.rabrr swizzling (equivalent to vec4.xwzxx).
        /// </summary>
        public vec5 rabrr => new vec5(x, w, z, x, x);
        
        /// <summary>
        /// Returns vec4.xwzxy swizzling.
        /// </summary>
        public vec5 xwzxy => new vec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns vec4.rabrg swizzling (equivalent to vec4.xwzxy).
        /// </summary>
        public vec5 rabrg => new vec5(x, w, z, x, y);
        
        /// <summary>
        /// Returns vec4.xwzxz swizzling.
        /// </summary>
        public vec5 xwzxz => new vec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns vec4.rabrb swizzling (equivalent to vec4.xwzxz).
        /// </summary>
        public vec5 rabrb => new vec5(x, w, z, x, z);
        
        /// <summary>
        /// Returns vec4.xwzxw swizzling.
        /// </summary>
        public vec5 xwzxw => new vec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns vec4.rabra swizzling (equivalent to vec4.xwzxw).
        /// </summary>
        public vec5 rabra => new vec5(x, w, z, x, w);
        
        /// <summary>
        /// Returns vec4.xwzy swizzling.
        /// </summary>
        public vec4 xwzy => new vec4(x, w, z, y);
        
        /// <summary>
        /// Returns vec4.rabg swizzling (equivalent to vec4.xwzy).
        /// </summary>
        public vec4 rabg => new vec4(x, w, z, y);
        
        /// <summary>
        /// Returns vec4.xwzyx swizzling.
        /// </summary>
        public vec5 xwzyx => new vec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns vec4.rabgr swizzling (equivalent to vec4.xwzyx).
        /// </summary>
        public vec5 rabgr => new vec5(x, w, z, y, x);
        
        /// <summary>
        /// Returns vec4.xwzyy swizzling.
        /// </summary>
        public vec5 xwzyy => new vec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns vec4.rabgg swizzling (equivalent to vec4.xwzyy).
        /// </summary>
        public vec5 rabgg => new vec5(x, w, z, y, y);
        
        /// <summary>
        /// Returns vec4.xwzyz swizzling.
        /// </summary>
        public vec5 xwzyz => new vec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns vec4.rabgb swizzling (equivalent to vec4.xwzyz).
        /// </summary>
        public vec5 rabgb => new vec5(x, w, z, y, z);
        
        /// <summary>
        /// Returns vec4.xwzyw swizzling.
        /// </summary>
        public vec5 xwzyw => new vec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns vec4.rabga swizzling (equivalent to vec4.xwzyw).
        /// </summary>
        public vec5 rabga => new vec5(x, w, z, y, w);
        
        /// <summary>
        /// Returns vec4.xwzz swizzling.
        /// </summary>
        public vec4 xwzz => new vec4(x, w, z, z);
        
        /// <summary>
        /// Returns vec4.rabb swizzling (equivalent to vec4.xwzz).
        /// </summary>
        public vec4 rabb => new vec4(x, w, z, z);
        
        /// <summary>
        /// Returns vec4.xwzzx swizzling.
        /// </summary>
        public vec5 xwzzx => new vec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns vec4.rabbr swizzling (equivalent to vec4.xwzzx).
        /// </summary>
        public vec5 rabbr => new vec5(x, w, z, z, x);
        
        /// <summary>
        /// Returns vec4.xwzzy swizzling.
        /// </summary>
        public vec5 xwzzy => new vec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns vec4.rabbg swizzling (equivalent to vec4.xwzzy).
        /// </summary>
        public vec5 rabbg => new vec5(x, w, z, z, y);
        
        /// <summary>
        /// Returns vec4.xwzzz swizzling.
        /// </summary>
        public vec5 xwzzz => new vec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns vec4.rabbb swizzling (equivalent to vec4.xwzzz).
        /// </summary>
        public vec5 rabbb => new vec5(x, w, z, z, z);
        
        /// <summary>
        /// Returns vec4.xwzzw swizzling.
        /// </summary>
        public vec5 xwzzw => new vec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns vec4.rabba swizzling (equivalent to vec4.xwzzw).
        /// </summary>
        public vec5 rabba => new vec5(x, w, z, z, w);
        
        /// <summary>
        /// Returns vec4.xwzw swizzling.
        /// </summary>
        public vec4 xwzw => new vec4(x, w, z, w);
        
        /// <summary>
        /// Returns vec4.raba swizzling (equivalent to vec4.xwzw).
        /// </summary>
        public vec4 raba => new vec4(x, w, z, w);
        
        /// <summary>
        /// Returns vec4.xwzwx swizzling.
        /// </summary>
        public vec5 xwzwx => new vec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns vec4.rabar swizzling (equivalent to vec4.xwzwx).
        /// </summary>
        public vec5 rabar => new vec5(x, w, z, w, x);
        
        /// <summary>
        /// Returns vec4.xwzwy swizzling.
        /// </summary>
        public vec5 xwzwy => new vec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns vec4.rabag swizzling (equivalent to vec4.xwzwy).
        /// </summary>
        public vec5 rabag => new vec5(x, w, z, w, y);
        
        /// <summary>
        /// Returns vec4.xwzwz swizzling.
        /// </summary>
        public vec5 xwzwz => new vec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns vec4.rabab swizzling (equivalent to vec4.xwzwz).
        /// </summary>
        public vec5 rabab => new vec5(x, w, z, w, z);
        
        /// <summary>
        /// Returns vec4.xwzww swizzling.
        /// </summary>
        public vec5 xwzww => new vec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns vec4.rabaa swizzling (equivalent to vec4.xwzww).
        /// </summary>
        public vec5 rabaa => new vec5(x, w, z, w, w);
        
        /// <summary>
        /// Returns vec4.xww swizzling.
        /// </summary>
        public vec3 xww => new vec3(x, w, w);
        
        /// <summary>
        /// Returns vec4.raa swizzling (equivalent to vec4.xww).
        /// </summary>
        public vec3 raa => new vec3(x, w, w);
        
        /// <summary>
        /// Returns vec4.xwwx swizzling.
        /// </summary>
        public vec4 xwwx => new vec4(x, w, w, x);
        
        /// <summary>
        /// Returns vec4.raar swizzling (equivalent to vec4.xwwx).
        /// </summary>
        public vec4 raar => new vec4(x, w, w, x);
        
        /// <summary>
        /// Returns vec4.xwwxx swizzling.
        /// </summary>
        public vec5 xwwxx => new vec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns vec4.raarr swizzling (equivalent to vec4.xwwxx).
        /// </summary>
        public vec5 raarr => new vec5(x, w, w, x, x);
        
        /// <summary>
        /// Returns vec4.xwwxy swizzling.
        /// </summary>
        public vec5 xwwxy => new vec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns vec4.raarg swizzling (equivalent to vec4.xwwxy).
        /// </summary>
        public vec5 raarg => new vec5(x, w, w, x, y);
        
        /// <summary>
        /// Returns vec4.xwwxz swizzling.
        /// </summary>
        public vec5 xwwxz => new vec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns vec4.raarb swizzling (equivalent to vec4.xwwxz).
        /// </summary>
        public vec5 raarb => new vec5(x, w, w, x, z);
        
        /// <summary>
        /// Returns vec4.xwwxw swizzling.
        /// </summary>
        public vec5 xwwxw => new vec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns vec4.raara swizzling (equivalent to vec4.xwwxw).
        /// </summary>
        public vec5 raara => new vec5(x, w, w, x, w);
        
        /// <summary>
        /// Returns vec4.xwwy swizzling.
        /// </summary>
        public vec4 xwwy => new vec4(x, w, w, y);
        
        /// <summary>
        /// Returns vec4.raag swizzling (equivalent to vec4.xwwy).
        /// </summary>
        public vec4 raag => new vec4(x, w, w, y);
        
        /// <summary>
        /// Returns vec4.xwwyx swizzling.
        /// </summary>
        public vec5 xwwyx => new vec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns vec4.raagr swizzling (equivalent to vec4.xwwyx).
        /// </summary>
        public vec5 raagr => new vec5(x, w, w, y, x);
        
        /// <summary>
        /// Returns vec4.xwwyy swizzling.
        /// </summary>
        public vec5 xwwyy => new vec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns vec4.raagg swizzling (equivalent to vec4.xwwyy).
        /// </summary>
        public vec5 raagg => new vec5(x, w, w, y, y);
        
        /// <summary>
        /// Returns vec4.xwwyz swizzling.
        /// </summary>
        public vec5 xwwyz => new vec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns vec4.raagb swizzling (equivalent to vec4.xwwyz).
        /// </summary>
        public vec5 raagb => new vec5(x, w, w, y, z);
        
        /// <summary>
        /// Returns vec4.xwwyw swizzling.
        /// </summary>
        public vec5 xwwyw => new vec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns vec4.raaga swizzling (equivalent to vec4.xwwyw).
        /// </summary>
        public vec5 raaga => new vec5(x, w, w, y, w);
        
        /// <summary>
        /// Returns vec4.xwwz swizzling.
        /// </summary>
        public vec4 xwwz => new vec4(x, w, w, z);
        
        /// <summary>
        /// Returns vec4.raab swizzling (equivalent to vec4.xwwz).
        /// </summary>
        public vec4 raab => new vec4(x, w, w, z);
        
        /// <summary>
        /// Returns vec4.xwwzx swizzling.
        /// </summary>
        public vec5 xwwzx => new vec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns vec4.raabr swizzling (equivalent to vec4.xwwzx).
        /// </summary>
        public vec5 raabr => new vec5(x, w, w, z, x);
        
        /// <summary>
        /// Returns vec4.xwwzy swizzling.
        /// </summary>
        public vec5 xwwzy => new vec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns vec4.raabg swizzling (equivalent to vec4.xwwzy).
        /// </summary>
        public vec5 raabg => new vec5(x, w, w, z, y);
        
        /// <summary>
        /// Returns vec4.xwwzz swizzling.
        /// </summary>
        public vec5 xwwzz => new vec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns vec4.raabb swizzling (equivalent to vec4.xwwzz).
        /// </summary>
        public vec5 raabb => new vec5(x, w, w, z, z);
        
        /// <summary>
        /// Returns vec4.xwwzw swizzling.
        /// </summary>
        public vec5 xwwzw => new vec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns vec4.raaba swizzling (equivalent to vec4.xwwzw).
        /// </summary>
        public vec5 raaba => new vec5(x, w, w, z, w);
        
        /// <summary>
        /// Returns vec4.xwww swizzling.
        /// </summary>
        public vec4 xwww => new vec4(x, w, w, w);
        
        /// <summary>
        /// Returns vec4.raaa swizzling (equivalent to vec4.xwww).
        /// </summary>
        public vec4 raaa => new vec4(x, w, w, w);
        
        /// <summary>
        /// Returns vec4.xwwwx swizzling.
        /// </summary>
        public vec5 xwwwx => new vec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns vec4.raaar swizzling (equivalent to vec4.xwwwx).
        /// </summary>
        public vec5 raaar => new vec5(x, w, w, w, x);
        
        /// <summary>
        /// Returns vec4.xwwwy swizzling.
        /// </summary>
        public vec5 xwwwy => new vec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns vec4.raaag swizzling (equivalent to vec4.xwwwy).
        /// </summary>
        public vec5 raaag => new vec5(x, w, w, w, y);
        
        /// <summary>
        /// Returns vec4.xwwwz swizzling.
        /// </summary>
        public vec5 xwwwz => new vec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns vec4.raaab swizzling (equivalent to vec4.xwwwz).
        /// </summary>
        public vec5 raaab => new vec5(x, w, w, w, z);
        
        /// <summary>
        /// Returns vec4.xwwww swizzling.
        /// </summary>
        public vec5 xwwww => new vec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns vec4.raaaa swizzling (equivalent to vec4.xwwww).
        /// </summary>
        public vec5 raaaa => new vec5(x, w, w, w, w);
        
        /// <summary>
        /// Returns vec4.yx swizzling.
        /// </summary>
        public vec2 yx => new vec2(y, x);
        
        /// <summary>
        /// Returns vec4.gr swizzling (equivalent to vec4.yx).
        /// </summary>
        public vec2 gr => new vec2(y, x);
        
        /// <summary>
        /// Returns vec4.yxx swizzling.
        /// </summary>
        public vec3 yxx => new vec3(y, x, x);
        
        /// <summary>
        /// Returns vec4.grr swizzling (equivalent to vec4.yxx).
        /// </summary>
        public vec3 grr => new vec3(y, x, x);
        
        /// <summary>
        /// Returns vec4.yxxx swizzling.
        /// </summary>
        public vec4 yxxx => new vec4(y, x, x, x);
        
        /// <summary>
        /// Returns vec4.grrr swizzling (equivalent to vec4.yxxx).
        /// </summary>
        public vec4 grrr => new vec4(y, x, x, x);
        
        /// <summary>
        /// Returns vec4.yxxxx swizzling.
        /// </summary>
        public vec5 yxxxx => new vec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns vec4.grrrr swizzling (equivalent to vec4.yxxxx).
        /// </summary>
        public vec5 grrrr => new vec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns vec4.yxxxy swizzling.
        /// </summary>
        public vec5 yxxxy => new vec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns vec4.grrrg swizzling (equivalent to vec4.yxxxy).
        /// </summary>
        public vec5 grrrg => new vec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns vec4.yxxxz swizzling.
        /// </summary>
        public vec5 yxxxz => new vec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns vec4.grrrb swizzling (equivalent to vec4.yxxxz).
        /// </summary>
        public vec5 grrrb => new vec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns vec4.yxxxw swizzling.
        /// </summary>
        public vec5 yxxxw => new vec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns vec4.grrra swizzling (equivalent to vec4.yxxxw).
        /// </summary>
        public vec5 grrra => new vec5(y, x, x, x, w);
        
        /// <summary>
        /// Returns vec4.yxxy swizzling.
        /// </summary>
        public vec4 yxxy => new vec4(y, x, x, y);
        
        /// <summary>
        /// Returns vec4.grrg swizzling (equivalent to vec4.yxxy).
        /// </summary>
        public vec4 grrg => new vec4(y, x, x, y);
        
        /// <summary>
        /// Returns vec4.yxxyx swizzling.
        /// </summary>
        public vec5 yxxyx => new vec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns vec4.grrgr swizzling (equivalent to vec4.yxxyx).
        /// </summary>
        public vec5 grrgr => new vec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns vec4.yxxyy swizzling.
        /// </summary>
        public vec5 yxxyy => new vec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns vec4.grrgg swizzling (equivalent to vec4.yxxyy).
        /// </summary>
        public vec5 grrgg => new vec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns vec4.yxxyz swizzling.
        /// </summary>
        public vec5 yxxyz => new vec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns vec4.grrgb swizzling (equivalent to vec4.yxxyz).
        /// </summary>
        public vec5 grrgb => new vec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns vec4.yxxyw swizzling.
        /// </summary>
        public vec5 yxxyw => new vec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns vec4.grrga swizzling (equivalent to vec4.yxxyw).
        /// </summary>
        public vec5 grrga => new vec5(y, x, x, y, w);
        
        /// <summary>
        /// Returns vec4.yxxz swizzling.
        /// </summary>
        public vec4 yxxz => new vec4(y, x, x, z);
        
        /// <summary>
        /// Returns vec4.grrb swizzling (equivalent to vec4.yxxz).
        /// </summary>
        public vec4 grrb => new vec4(y, x, x, z);
        
        /// <summary>
        /// Returns vec4.yxxzx swizzling.
        /// </summary>
        public vec5 yxxzx => new vec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns vec4.grrbr swizzling (equivalent to vec4.yxxzx).
        /// </summary>
        public vec5 grrbr => new vec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns vec4.yxxzy swizzling.
        /// </summary>
        public vec5 yxxzy => new vec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns vec4.grrbg swizzling (equivalent to vec4.yxxzy).
        /// </summary>
        public vec5 grrbg => new vec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns vec4.yxxzz swizzling.
        /// </summary>
        public vec5 yxxzz => new vec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns vec4.grrbb swizzling (equivalent to vec4.yxxzz).
        /// </summary>
        public vec5 grrbb => new vec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns vec4.yxxzw swizzling.
        /// </summary>
        public vec5 yxxzw => new vec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns vec4.grrba swizzling (equivalent to vec4.yxxzw).
        /// </summary>
        public vec5 grrba => new vec5(y, x, x, z, w);
        
        /// <summary>
        /// Returns vec4.yxxw swizzling.
        /// </summary>
        public vec4 yxxw => new vec4(y, x, x, w);
        
        /// <summary>
        /// Returns vec4.grra swizzling (equivalent to vec4.yxxw).
        /// </summary>
        public vec4 grra => new vec4(y, x, x, w);
        
        /// <summary>
        /// Returns vec4.yxxwx swizzling.
        /// </summary>
        public vec5 yxxwx => new vec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns vec4.grrar swizzling (equivalent to vec4.yxxwx).
        /// </summary>
        public vec5 grrar => new vec5(y, x, x, w, x);
        
        /// <summary>
        /// Returns vec4.yxxwy swizzling.
        /// </summary>
        public vec5 yxxwy => new vec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns vec4.grrag swizzling (equivalent to vec4.yxxwy).
        /// </summary>
        public vec5 grrag => new vec5(y, x, x, w, y);
        
        /// <summary>
        /// Returns vec4.yxxwz swizzling.
        /// </summary>
        public vec5 yxxwz => new vec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns vec4.grrab swizzling (equivalent to vec4.yxxwz).
        /// </summary>
        public vec5 grrab => new vec5(y, x, x, w, z);
        
        /// <summary>
        /// Returns vec4.yxxww swizzling.
        /// </summary>
        public vec5 yxxww => new vec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns vec4.grraa swizzling (equivalent to vec4.yxxww).
        /// </summary>
        public vec5 grraa => new vec5(y, x, x, w, w);
        
        /// <summary>
        /// Returns vec4.yxy swizzling.
        /// </summary>
        public vec3 yxy => new vec3(y, x, y);
        
        /// <summary>
        /// Returns vec4.grg swizzling (equivalent to vec4.yxy).
        /// </summary>
        public vec3 grg => new vec3(y, x, y);
        
        /// <summary>
        /// Returns vec4.yxyx swizzling.
        /// </summary>
        public vec4 yxyx => new vec4(y, x, y, x);
        
        /// <summary>
        /// Returns vec4.grgr swizzling (equivalent to vec4.yxyx).
        /// </summary>
        public vec4 grgr => new vec4(y, x, y, x);
        
        /// <summary>
        /// Returns vec4.yxyxx swizzling.
        /// </summary>
        public vec5 yxyxx => new vec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns vec4.grgrr swizzling (equivalent to vec4.yxyxx).
        /// </summary>
        public vec5 grgrr => new vec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns vec4.yxyxy swizzling.
        /// </summary>
        public vec5 yxyxy => new vec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns vec4.grgrg swizzling (equivalent to vec4.yxyxy).
        /// </summary>
        public vec5 grgrg => new vec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns vec4.yxyxz swizzling.
        /// </summary>
        public vec5 yxyxz => new vec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns vec4.grgrb swizzling (equivalent to vec4.yxyxz).
        /// </summary>
        public vec5 grgrb => new vec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns vec4.yxyxw swizzling.
        /// </summary>
        public vec5 yxyxw => new vec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns vec4.grgra swizzling (equivalent to vec4.yxyxw).
        /// </summary>
        public vec5 grgra => new vec5(y, x, y, x, w);
        
        /// <summary>
        /// Returns vec4.yxyy swizzling.
        /// </summary>
        public vec4 yxyy => new vec4(y, x, y, y);
        
        /// <summary>
        /// Returns vec4.grgg swizzling (equivalent to vec4.yxyy).
        /// </summary>
        public vec4 grgg => new vec4(y, x, y, y);
        
        /// <summary>
        /// Returns vec4.yxyyx swizzling.
        /// </summary>
        public vec5 yxyyx => new vec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns vec4.grggr swizzling (equivalent to vec4.yxyyx).
        /// </summary>
        public vec5 grggr => new vec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns vec4.yxyyy swizzling.
        /// </summary>
        public vec5 yxyyy => new vec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns vec4.grggg swizzling (equivalent to vec4.yxyyy).
        /// </summary>
        public vec5 grggg => new vec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns vec4.yxyyz swizzling.
        /// </summary>
        public vec5 yxyyz => new vec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns vec4.grggb swizzling (equivalent to vec4.yxyyz).
        /// </summary>
        public vec5 grggb => new vec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns vec4.yxyyw swizzling.
        /// </summary>
        public vec5 yxyyw => new vec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns vec4.grgga swizzling (equivalent to vec4.yxyyw).
        /// </summary>
        public vec5 grgga => new vec5(y, x, y, y, w);
        
        /// <summary>
        /// Returns vec4.yxyz swizzling.
        /// </summary>
        public vec4 yxyz => new vec4(y, x, y, z);
        
        /// <summary>
        /// Returns vec4.grgb swizzling (equivalent to vec4.yxyz).
        /// </summary>
        public vec4 grgb => new vec4(y, x, y, z);
        
        /// <summary>
        /// Returns vec4.yxyzx swizzling.
        /// </summary>
        public vec5 yxyzx => new vec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns vec4.grgbr swizzling (equivalent to vec4.yxyzx).
        /// </summary>
        public vec5 grgbr => new vec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns vec4.yxyzy swizzling.
        /// </summary>
        public vec5 yxyzy => new vec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns vec4.grgbg swizzling (equivalent to vec4.yxyzy).
        /// </summary>
        public vec5 grgbg => new vec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns vec4.yxyzz swizzling.
        /// </summary>
        public vec5 yxyzz => new vec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns vec4.grgbb swizzling (equivalent to vec4.yxyzz).
        /// </summary>
        public vec5 grgbb => new vec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns vec4.yxyzw swizzling.
        /// </summary>
        public vec5 yxyzw => new vec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns vec4.grgba swizzling (equivalent to vec4.yxyzw).
        /// </summary>
        public vec5 grgba => new vec5(y, x, y, z, w);
        
        /// <summary>
        /// Returns vec4.yxyw swizzling.
        /// </summary>
        public vec4 yxyw => new vec4(y, x, y, w);
        
        /// <summary>
        /// Returns vec4.grga swizzling (equivalent to vec4.yxyw).
        /// </summary>
        public vec4 grga => new vec4(y, x, y, w);
        
        /// <summary>
        /// Returns vec4.yxywx swizzling.
        /// </summary>
        public vec5 yxywx => new vec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns vec4.grgar swizzling (equivalent to vec4.yxywx).
        /// </summary>
        public vec5 grgar => new vec5(y, x, y, w, x);
        
        /// <summary>
        /// Returns vec4.yxywy swizzling.
        /// </summary>
        public vec5 yxywy => new vec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns vec4.grgag swizzling (equivalent to vec4.yxywy).
        /// </summary>
        public vec5 grgag => new vec5(y, x, y, w, y);
        
        /// <summary>
        /// Returns vec4.yxywz swizzling.
        /// </summary>
        public vec5 yxywz => new vec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns vec4.grgab swizzling (equivalent to vec4.yxywz).
        /// </summary>
        public vec5 grgab => new vec5(y, x, y, w, z);
        
        /// <summary>
        /// Returns vec4.yxyww swizzling.
        /// </summary>
        public vec5 yxyww => new vec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns vec4.grgaa swizzling (equivalent to vec4.yxyww).
        /// </summary>
        public vec5 grgaa => new vec5(y, x, y, w, w);
        
        /// <summary>
        /// Returns vec4.yxz swizzling.
        /// </summary>
        public vec3 yxz => new vec3(y, x, z);
        
        /// <summary>
        /// Returns vec4.grb swizzling (equivalent to vec4.yxz).
        /// </summary>
        public vec3 grb => new vec3(y, x, z);
        
        /// <summary>
        /// Returns vec4.yxzx swizzling.
        /// </summary>
        public vec4 yxzx => new vec4(y, x, z, x);
        
        /// <summary>
        /// Returns vec4.grbr swizzling (equivalent to vec4.yxzx).
        /// </summary>
        public vec4 grbr => new vec4(y, x, z, x);
        
        /// <summary>
        /// Returns vec4.yxzxx swizzling.
        /// </summary>
        public vec5 yxzxx => new vec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns vec4.grbrr swizzling (equivalent to vec4.yxzxx).
        /// </summary>
        public vec5 grbrr => new vec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns vec4.yxzxy swizzling.
        /// </summary>
        public vec5 yxzxy => new vec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns vec4.grbrg swizzling (equivalent to vec4.yxzxy).
        /// </summary>
        public vec5 grbrg => new vec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns vec4.yxzxz swizzling.
        /// </summary>
        public vec5 yxzxz => new vec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns vec4.grbrb swizzling (equivalent to vec4.yxzxz).
        /// </summary>
        public vec5 grbrb => new vec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns vec4.yxzxw swizzling.
        /// </summary>
        public vec5 yxzxw => new vec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns vec4.grbra swizzling (equivalent to vec4.yxzxw).
        /// </summary>
        public vec5 grbra => new vec5(y, x, z, x, w);
        
        /// <summary>
        /// Returns vec4.yxzy swizzling.
        /// </summary>
        public vec4 yxzy => new vec4(y, x, z, y);
        
        /// <summary>
        /// Returns vec4.grbg swizzling (equivalent to vec4.yxzy).
        /// </summary>
        public vec4 grbg => new vec4(y, x, z, y);
        
        /// <summary>
        /// Returns vec4.yxzyx swizzling.
        /// </summary>
        public vec5 yxzyx => new vec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns vec4.grbgr swizzling (equivalent to vec4.yxzyx).
        /// </summary>
        public vec5 grbgr => new vec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns vec4.yxzyy swizzling.
        /// </summary>
        public vec5 yxzyy => new vec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns vec4.grbgg swizzling (equivalent to vec4.yxzyy).
        /// </summary>
        public vec5 grbgg => new vec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns vec4.yxzyz swizzling.
        /// </summary>
        public vec5 yxzyz => new vec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns vec4.grbgb swizzling (equivalent to vec4.yxzyz).
        /// </summary>
        public vec5 grbgb => new vec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns vec4.yxzyw swizzling.
        /// </summary>
        public vec5 yxzyw => new vec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns vec4.grbga swizzling (equivalent to vec4.yxzyw).
        /// </summary>
        public vec5 grbga => new vec5(y, x, z, y, w);
        
        /// <summary>
        /// Returns vec4.yxzz swizzling.
        /// </summary>
        public vec4 yxzz => new vec4(y, x, z, z);
        
        /// <summary>
        /// Returns vec4.grbb swizzling (equivalent to vec4.yxzz).
        /// </summary>
        public vec4 grbb => new vec4(y, x, z, z);
        
        /// <summary>
        /// Returns vec4.yxzzx swizzling.
        /// </summary>
        public vec5 yxzzx => new vec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns vec4.grbbr swizzling (equivalent to vec4.yxzzx).
        /// </summary>
        public vec5 grbbr => new vec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns vec4.yxzzy swizzling.
        /// </summary>
        public vec5 yxzzy => new vec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns vec4.grbbg swizzling (equivalent to vec4.yxzzy).
        /// </summary>
        public vec5 grbbg => new vec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns vec4.yxzzz swizzling.
        /// </summary>
        public vec5 yxzzz => new vec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns vec4.grbbb swizzling (equivalent to vec4.yxzzz).
        /// </summary>
        public vec5 grbbb => new vec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns vec4.yxzzw swizzling.
        /// </summary>
        public vec5 yxzzw => new vec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns vec4.grbba swizzling (equivalent to vec4.yxzzw).
        /// </summary>
        public vec5 grbba => new vec5(y, x, z, z, w);
        
        /// <summary>
        /// Returns vec4.yxzw swizzling.
        /// </summary>
        public vec4 yxzw => new vec4(y, x, z, w);
        
        /// <summary>
        /// Returns vec4.grba swizzling (equivalent to vec4.yxzw).
        /// </summary>
        public vec4 grba => new vec4(y, x, z, w);
        
        /// <summary>
        /// Returns vec4.yxzwx swizzling.
        /// </summary>
        public vec5 yxzwx => new vec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns vec4.grbar swizzling (equivalent to vec4.yxzwx).
        /// </summary>
        public vec5 grbar => new vec5(y, x, z, w, x);
        
        /// <summary>
        /// Returns vec4.yxzwy swizzling.
        /// </summary>
        public vec5 yxzwy => new vec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns vec4.grbag swizzling (equivalent to vec4.yxzwy).
        /// </summary>
        public vec5 grbag => new vec5(y, x, z, w, y);
        
        /// <summary>
        /// Returns vec4.yxzwz swizzling.
        /// </summary>
        public vec5 yxzwz => new vec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns vec4.grbab swizzling (equivalent to vec4.yxzwz).
        /// </summary>
        public vec5 grbab => new vec5(y, x, z, w, z);
        
        /// <summary>
        /// Returns vec4.yxzww swizzling.
        /// </summary>
        public vec5 yxzww => new vec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns vec4.grbaa swizzling (equivalent to vec4.yxzww).
        /// </summary>
        public vec5 grbaa => new vec5(y, x, z, w, w);
        
        /// <summary>
        /// Returns vec4.yxw swizzling.
        /// </summary>
        public vec3 yxw => new vec3(y, x, w);
        
        /// <summary>
        /// Returns vec4.gra swizzling (equivalent to vec4.yxw).
        /// </summary>
        public vec3 gra => new vec3(y, x, w);
        
        /// <summary>
        /// Returns vec4.yxwx swizzling.
        /// </summary>
        public vec4 yxwx => new vec4(y, x, w, x);
        
        /// <summary>
        /// Returns vec4.grar swizzling (equivalent to vec4.yxwx).
        /// </summary>
        public vec4 grar => new vec4(y, x, w, x);
        
        /// <summary>
        /// Returns vec4.yxwxx swizzling.
        /// </summary>
        public vec5 yxwxx => new vec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns vec4.grarr swizzling (equivalent to vec4.yxwxx).
        /// </summary>
        public vec5 grarr => new vec5(y, x, w, x, x);
        
        /// <summary>
        /// Returns vec4.yxwxy swizzling.
        /// </summary>
        public vec5 yxwxy => new vec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns vec4.grarg swizzling (equivalent to vec4.yxwxy).
        /// </summary>
        public vec5 grarg => new vec5(y, x, w, x, y);
        
        /// <summary>
        /// Returns vec4.yxwxz swizzling.
        /// </summary>
        public vec5 yxwxz => new vec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns vec4.grarb swizzling (equivalent to vec4.yxwxz).
        /// </summary>
        public vec5 grarb => new vec5(y, x, w, x, z);
        
        /// <summary>
        /// Returns vec4.yxwxw swizzling.
        /// </summary>
        public vec5 yxwxw => new vec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns vec4.grara swizzling (equivalent to vec4.yxwxw).
        /// </summary>
        public vec5 grara => new vec5(y, x, w, x, w);
        
        /// <summary>
        /// Returns vec4.yxwy swizzling.
        /// </summary>
        public vec4 yxwy => new vec4(y, x, w, y);
        
        /// <summary>
        /// Returns vec4.grag swizzling (equivalent to vec4.yxwy).
        /// </summary>
        public vec4 grag => new vec4(y, x, w, y);
        
        /// <summary>
        /// Returns vec4.yxwyx swizzling.
        /// </summary>
        public vec5 yxwyx => new vec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns vec4.gragr swizzling (equivalent to vec4.yxwyx).
        /// </summary>
        public vec5 gragr => new vec5(y, x, w, y, x);
        
        /// <summary>
        /// Returns vec4.yxwyy swizzling.
        /// </summary>
        public vec5 yxwyy => new vec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns vec4.gragg swizzling (equivalent to vec4.yxwyy).
        /// </summary>
        public vec5 gragg => new vec5(y, x, w, y, y);
        
        /// <summary>
        /// Returns vec4.yxwyz swizzling.
        /// </summary>
        public vec5 yxwyz => new vec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns vec4.gragb swizzling (equivalent to vec4.yxwyz).
        /// </summary>
        public vec5 gragb => new vec5(y, x, w, y, z);
        
        /// <summary>
        /// Returns vec4.yxwyw swizzling.
        /// </summary>
        public vec5 yxwyw => new vec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns vec4.graga swizzling (equivalent to vec4.yxwyw).
        /// </summary>
        public vec5 graga => new vec5(y, x, w, y, w);
        
        /// <summary>
        /// Returns vec4.yxwz swizzling.
        /// </summary>
        public vec4 yxwz => new vec4(y, x, w, z);
        
        /// <summary>
        /// Returns vec4.grab swizzling (equivalent to vec4.yxwz).
        /// </summary>
        public vec4 grab => new vec4(y, x, w, z);
        
        /// <summary>
        /// Returns vec4.yxwzx swizzling.
        /// </summary>
        public vec5 yxwzx => new vec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns vec4.grabr swizzling (equivalent to vec4.yxwzx).
        /// </summary>
        public vec5 grabr => new vec5(y, x, w, z, x);
        
        /// <summary>
        /// Returns vec4.yxwzy swizzling.
        /// </summary>
        public vec5 yxwzy => new vec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns vec4.grabg swizzling (equivalent to vec4.yxwzy).
        /// </summary>
        public vec5 grabg => new vec5(y, x, w, z, y);
        
        /// <summary>
        /// Returns vec4.yxwzz swizzling.
        /// </summary>
        public vec5 yxwzz => new vec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns vec4.grabb swizzling (equivalent to vec4.yxwzz).
        /// </summary>
        public vec5 grabb => new vec5(y, x, w, z, z);
        
        /// <summary>
        /// Returns vec4.yxwzw swizzling.
        /// </summary>
        public vec5 yxwzw => new vec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns vec4.graba swizzling (equivalent to vec4.yxwzw).
        /// </summary>
        public vec5 graba => new vec5(y, x, w, z, w);
        
        /// <summary>
        /// Returns vec4.yxww swizzling.
        /// </summary>
        public vec4 yxww => new vec4(y, x, w, w);
        
        /// <summary>
        /// Returns vec4.graa swizzling (equivalent to vec4.yxww).
        /// </summary>
        public vec4 graa => new vec4(y, x, w, w);
        
        /// <summary>
        /// Returns vec4.yxwwx swizzling.
        /// </summary>
        public vec5 yxwwx => new vec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns vec4.graar swizzling (equivalent to vec4.yxwwx).
        /// </summary>
        public vec5 graar => new vec5(y, x, w, w, x);
        
        /// <summary>
        /// Returns vec4.yxwwy swizzling.
        /// </summary>
        public vec5 yxwwy => new vec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns vec4.graag swizzling (equivalent to vec4.yxwwy).
        /// </summary>
        public vec5 graag => new vec5(y, x, w, w, y);
        
        /// <summary>
        /// Returns vec4.yxwwz swizzling.
        /// </summary>
        public vec5 yxwwz => new vec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns vec4.graab swizzling (equivalent to vec4.yxwwz).
        /// </summary>
        public vec5 graab => new vec5(y, x, w, w, z);
        
        /// <summary>
        /// Returns vec4.yxwww swizzling.
        /// </summary>
        public vec5 yxwww => new vec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns vec4.graaa swizzling (equivalent to vec4.yxwww).
        /// </summary>
        public vec5 graaa => new vec5(y, x, w, w, w);
        
        /// <summary>
        /// Returns vec4.yy swizzling.
        /// </summary>
        public vec2 yy => new vec2(y, y);
        
        /// <summary>
        /// Returns vec4.gg swizzling (equivalent to vec4.yy).
        /// </summary>
        public vec2 gg => new vec2(y, y);
        
        /// <summary>
        /// Returns vec4.yyx swizzling.
        /// </summary>
        public vec3 yyx => new vec3(y, y, x);
        
        /// <summary>
        /// Returns vec4.ggr swizzling (equivalent to vec4.yyx).
        /// </summary>
        public vec3 ggr => new vec3(y, y, x);
        
        /// <summary>
        /// Returns vec4.yyxx swizzling.
        /// </summary>
        public vec4 yyxx => new vec4(y, y, x, x);
        
        /// <summary>
        /// Returns vec4.ggrr swizzling (equivalent to vec4.yyxx).
        /// </summary>
        public vec4 ggrr => new vec4(y, y, x, x);
        
        /// <summary>
        /// Returns vec4.yyxxx swizzling.
        /// </summary>
        public vec5 yyxxx => new vec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns vec4.ggrrr swizzling (equivalent to vec4.yyxxx).
        /// </summary>
        public vec5 ggrrr => new vec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns vec4.yyxxy swizzling.
        /// </summary>
        public vec5 yyxxy => new vec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns vec4.ggrrg swizzling (equivalent to vec4.yyxxy).
        /// </summary>
        public vec5 ggrrg => new vec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns vec4.yyxxz swizzling.
        /// </summary>
        public vec5 yyxxz => new vec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns vec4.ggrrb swizzling (equivalent to vec4.yyxxz).
        /// </summary>
        public vec5 ggrrb => new vec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns vec4.yyxxw swizzling.
        /// </summary>
        public vec5 yyxxw => new vec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns vec4.ggrra swizzling (equivalent to vec4.yyxxw).
        /// </summary>
        public vec5 ggrra => new vec5(y, y, x, x, w);
        
        /// <summary>
        /// Returns vec4.yyxy swizzling.
        /// </summary>
        public vec4 yyxy => new vec4(y, y, x, y);
        
        /// <summary>
        /// Returns vec4.ggrg swizzling (equivalent to vec4.yyxy).
        /// </summary>
        public vec4 ggrg => new vec4(y, y, x, y);
        
        /// <summary>
        /// Returns vec4.yyxyx swizzling.
        /// </summary>
        public vec5 yyxyx => new vec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns vec4.ggrgr swizzling (equivalent to vec4.yyxyx).
        /// </summary>
        public vec5 ggrgr => new vec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns vec4.yyxyy swizzling.
        /// </summary>
        public vec5 yyxyy => new vec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns vec4.ggrgg swizzling (equivalent to vec4.yyxyy).
        /// </summary>
        public vec5 ggrgg => new vec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns vec4.yyxyz swizzling.
        /// </summary>
        public vec5 yyxyz => new vec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns vec4.ggrgb swizzling (equivalent to vec4.yyxyz).
        /// </summary>
        public vec5 ggrgb => new vec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns vec4.yyxyw swizzling.
        /// </summary>
        public vec5 yyxyw => new vec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns vec4.ggrga swizzling (equivalent to vec4.yyxyw).
        /// </summary>
        public vec5 ggrga => new vec5(y, y, x, y, w);
        
        /// <summary>
        /// Returns vec4.yyxz swizzling.
        /// </summary>
        public vec4 yyxz => new vec4(y, y, x, z);
        
        /// <summary>
        /// Returns vec4.ggrb swizzling (equivalent to vec4.yyxz).
        /// </summary>
        public vec4 ggrb => new vec4(y, y, x, z);
        
        /// <summary>
        /// Returns vec4.yyxzx swizzling.
        /// </summary>
        public vec5 yyxzx => new vec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns vec4.ggrbr swizzling (equivalent to vec4.yyxzx).
        /// </summary>
        public vec5 ggrbr => new vec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns vec4.yyxzy swizzling.
        /// </summary>
        public vec5 yyxzy => new vec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns vec4.ggrbg swizzling (equivalent to vec4.yyxzy).
        /// </summary>
        public vec5 ggrbg => new vec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns vec4.yyxzz swizzling.
        /// </summary>
        public vec5 yyxzz => new vec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns vec4.ggrbb swizzling (equivalent to vec4.yyxzz).
        /// </summary>
        public vec5 ggrbb => new vec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns vec4.yyxzw swizzling.
        /// </summary>
        public vec5 yyxzw => new vec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns vec4.ggrba swizzling (equivalent to vec4.yyxzw).
        /// </summary>
        public vec5 ggrba => new vec5(y, y, x, z, w);
        
        /// <summary>
        /// Returns vec4.yyxw swizzling.
        /// </summary>
        public vec4 yyxw => new vec4(y, y, x, w);
        
        /// <summary>
        /// Returns vec4.ggra swizzling (equivalent to vec4.yyxw).
        /// </summary>
        public vec4 ggra => new vec4(y, y, x, w);
        
        /// <summary>
        /// Returns vec4.yyxwx swizzling.
        /// </summary>
        public vec5 yyxwx => new vec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns vec4.ggrar swizzling (equivalent to vec4.yyxwx).
        /// </summary>
        public vec5 ggrar => new vec5(y, y, x, w, x);
        
        /// <summary>
        /// Returns vec4.yyxwy swizzling.
        /// </summary>
        public vec5 yyxwy => new vec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns vec4.ggrag swizzling (equivalent to vec4.yyxwy).
        /// </summary>
        public vec5 ggrag => new vec5(y, y, x, w, y);
        
        /// <summary>
        /// Returns vec4.yyxwz swizzling.
        /// </summary>
        public vec5 yyxwz => new vec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns vec4.ggrab swizzling (equivalent to vec4.yyxwz).
        /// </summary>
        public vec5 ggrab => new vec5(y, y, x, w, z);
        
        /// <summary>
        /// Returns vec4.yyxww swizzling.
        /// </summary>
        public vec5 yyxww => new vec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns vec4.ggraa swizzling (equivalent to vec4.yyxww).
        /// </summary>
        public vec5 ggraa => new vec5(y, y, x, w, w);
        
        /// <summary>
        /// Returns vec4.yyy swizzling.
        /// </summary>
        public vec3 yyy => new vec3(y, y, y);
        
        /// <summary>
        /// Returns vec4.ggg swizzling (equivalent to vec4.yyy).
        /// </summary>
        public vec3 ggg => new vec3(y, y, y);
        
        /// <summary>
        /// Returns vec4.yyyx swizzling.
        /// </summary>
        public vec4 yyyx => new vec4(y, y, y, x);
        
        /// <summary>
        /// Returns vec4.gggr swizzling (equivalent to vec4.yyyx).
        /// </summary>
        public vec4 gggr => new vec4(y, y, y, x);
        
        /// <summary>
        /// Returns vec4.yyyxx swizzling.
        /// </summary>
        public vec5 yyyxx => new vec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns vec4.gggrr swizzling (equivalent to vec4.yyyxx).
        /// </summary>
        public vec5 gggrr => new vec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns vec4.yyyxy swizzling.
        /// </summary>
        public vec5 yyyxy => new vec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns vec4.gggrg swizzling (equivalent to vec4.yyyxy).
        /// </summary>
        public vec5 gggrg => new vec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns vec4.yyyxz swizzling.
        /// </summary>
        public vec5 yyyxz => new vec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns vec4.gggrb swizzling (equivalent to vec4.yyyxz).
        /// </summary>
        public vec5 gggrb => new vec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns vec4.yyyxw swizzling.
        /// </summary>
        public vec5 yyyxw => new vec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns vec4.gggra swizzling (equivalent to vec4.yyyxw).
        /// </summary>
        public vec5 gggra => new vec5(y, y, y, x, w);
        
        /// <summary>
        /// Returns vec4.yyyy swizzling.
        /// </summary>
        public vec4 yyyy => new vec4(y, y, y, y);
        
        /// <summary>
        /// Returns vec4.gggg swizzling (equivalent to vec4.yyyy).
        /// </summary>
        public vec4 gggg => new vec4(y, y, y, y);
        
        /// <summary>
        /// Returns vec4.yyyyx swizzling.
        /// </summary>
        public vec5 yyyyx => new vec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns vec4.ggggr swizzling (equivalent to vec4.yyyyx).
        /// </summary>
        public vec5 ggggr => new vec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns vec4.yyyyy swizzling.
        /// </summary>
        public vec5 yyyyy => new vec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns vec4.ggggg swizzling (equivalent to vec4.yyyyy).
        /// </summary>
        public vec5 ggggg => new vec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns vec4.yyyyz swizzling.
        /// </summary>
        public vec5 yyyyz => new vec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns vec4.ggggb swizzling (equivalent to vec4.yyyyz).
        /// </summary>
        public vec5 ggggb => new vec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns vec4.yyyyw swizzling.
        /// </summary>
        public vec5 yyyyw => new vec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns vec4.gggga swizzling (equivalent to vec4.yyyyw).
        /// </summary>
        public vec5 gggga => new vec5(y, y, y, y, w);
        
        /// <summary>
        /// Returns vec4.yyyz swizzling.
        /// </summary>
        public vec4 yyyz => new vec4(y, y, y, z);
        
        /// <summary>
        /// Returns vec4.gggb swizzling (equivalent to vec4.yyyz).
        /// </summary>
        public vec4 gggb => new vec4(y, y, y, z);
        
        /// <summary>
        /// Returns vec4.yyyzx swizzling.
        /// </summary>
        public vec5 yyyzx => new vec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns vec4.gggbr swizzling (equivalent to vec4.yyyzx).
        /// </summary>
        public vec5 gggbr => new vec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns vec4.yyyzy swizzling.
        /// </summary>
        public vec5 yyyzy => new vec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns vec4.gggbg swizzling (equivalent to vec4.yyyzy).
        /// </summary>
        public vec5 gggbg => new vec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns vec4.yyyzz swizzling.
        /// </summary>
        public vec5 yyyzz => new vec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns vec4.gggbb swizzling (equivalent to vec4.yyyzz).
        /// </summary>
        public vec5 gggbb => new vec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns vec4.yyyzw swizzling.
        /// </summary>
        public vec5 yyyzw => new vec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns vec4.gggba swizzling (equivalent to vec4.yyyzw).
        /// </summary>
        public vec5 gggba => new vec5(y, y, y, z, w);
        
        /// <summary>
        /// Returns vec4.yyyw swizzling.
        /// </summary>
        public vec4 yyyw => new vec4(y, y, y, w);
        
        /// <summary>
        /// Returns vec4.ggga swizzling (equivalent to vec4.yyyw).
        /// </summary>
        public vec4 ggga => new vec4(y, y, y, w);
        
        /// <summary>
        /// Returns vec4.yyywx swizzling.
        /// </summary>
        public vec5 yyywx => new vec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns vec4.gggar swizzling (equivalent to vec4.yyywx).
        /// </summary>
        public vec5 gggar => new vec5(y, y, y, w, x);
        
        /// <summary>
        /// Returns vec4.yyywy swizzling.
        /// </summary>
        public vec5 yyywy => new vec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns vec4.gggag swizzling (equivalent to vec4.yyywy).
        /// </summary>
        public vec5 gggag => new vec5(y, y, y, w, y);
        
        /// <summary>
        /// Returns vec4.yyywz swizzling.
        /// </summary>
        public vec5 yyywz => new vec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns vec4.gggab swizzling (equivalent to vec4.yyywz).
        /// </summary>
        public vec5 gggab => new vec5(y, y, y, w, z);
        
        /// <summary>
        /// Returns vec4.yyyww swizzling.
        /// </summary>
        public vec5 yyyww => new vec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns vec4.gggaa swizzling (equivalent to vec4.yyyww).
        /// </summary>
        public vec5 gggaa => new vec5(y, y, y, w, w);
        
        /// <summary>
        /// Returns vec4.yyz swizzling.
        /// </summary>
        public vec3 yyz => new vec3(y, y, z);
        
        /// <summary>
        /// Returns vec4.ggb swizzling (equivalent to vec4.yyz).
        /// </summary>
        public vec3 ggb => new vec3(y, y, z);
        
        /// <summary>
        /// Returns vec4.yyzx swizzling.
        /// </summary>
        public vec4 yyzx => new vec4(y, y, z, x);
        
        /// <summary>
        /// Returns vec4.ggbr swizzling (equivalent to vec4.yyzx).
        /// </summary>
        public vec4 ggbr => new vec4(y, y, z, x);
        
        /// <summary>
        /// Returns vec4.yyzxx swizzling.
        /// </summary>
        public vec5 yyzxx => new vec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns vec4.ggbrr swizzling (equivalent to vec4.yyzxx).
        /// </summary>
        public vec5 ggbrr => new vec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns vec4.yyzxy swizzling.
        /// </summary>
        public vec5 yyzxy => new vec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns vec4.ggbrg swizzling (equivalent to vec4.yyzxy).
        /// </summary>
        public vec5 ggbrg => new vec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns vec4.yyzxz swizzling.
        /// </summary>
        public vec5 yyzxz => new vec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns vec4.ggbrb swizzling (equivalent to vec4.yyzxz).
        /// </summary>
        public vec5 ggbrb => new vec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns vec4.yyzxw swizzling.
        /// </summary>
        public vec5 yyzxw => new vec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns vec4.ggbra swizzling (equivalent to vec4.yyzxw).
        /// </summary>
        public vec5 ggbra => new vec5(y, y, z, x, w);
        
        /// <summary>
        /// Returns vec4.yyzy swizzling.
        /// </summary>
        public vec4 yyzy => new vec4(y, y, z, y);
        
        /// <summary>
        /// Returns vec4.ggbg swizzling (equivalent to vec4.yyzy).
        /// </summary>
        public vec4 ggbg => new vec4(y, y, z, y);
        
        /// <summary>
        /// Returns vec4.yyzyx swizzling.
        /// </summary>
        public vec5 yyzyx => new vec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns vec4.ggbgr swizzling (equivalent to vec4.yyzyx).
        /// </summary>
        public vec5 ggbgr => new vec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns vec4.yyzyy swizzling.
        /// </summary>
        public vec5 yyzyy => new vec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns vec4.ggbgg swizzling (equivalent to vec4.yyzyy).
        /// </summary>
        public vec5 ggbgg => new vec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns vec4.yyzyz swizzling.
        /// </summary>
        public vec5 yyzyz => new vec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns vec4.ggbgb swizzling (equivalent to vec4.yyzyz).
        /// </summary>
        public vec5 ggbgb => new vec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns vec4.yyzyw swizzling.
        /// </summary>
        public vec5 yyzyw => new vec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns vec4.ggbga swizzling (equivalent to vec4.yyzyw).
        /// </summary>
        public vec5 ggbga => new vec5(y, y, z, y, w);
        
        /// <summary>
        /// Returns vec4.yyzz swizzling.
        /// </summary>
        public vec4 yyzz => new vec4(y, y, z, z);
        
        /// <summary>
        /// Returns vec4.ggbb swizzling (equivalent to vec4.yyzz).
        /// </summary>
        public vec4 ggbb => new vec4(y, y, z, z);
        
        /// <summary>
        /// Returns vec4.yyzzx swizzling.
        /// </summary>
        public vec5 yyzzx => new vec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns vec4.ggbbr swizzling (equivalent to vec4.yyzzx).
        /// </summary>
        public vec5 ggbbr => new vec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns vec4.yyzzy swizzling.
        /// </summary>
        public vec5 yyzzy => new vec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns vec4.ggbbg swizzling (equivalent to vec4.yyzzy).
        /// </summary>
        public vec5 ggbbg => new vec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns vec4.yyzzz swizzling.
        /// </summary>
        public vec5 yyzzz => new vec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns vec4.ggbbb swizzling (equivalent to vec4.yyzzz).
        /// </summary>
        public vec5 ggbbb => new vec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns vec4.yyzzw swizzling.
        /// </summary>
        public vec5 yyzzw => new vec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns vec4.ggbba swizzling (equivalent to vec4.yyzzw).
        /// </summary>
        public vec5 ggbba => new vec5(y, y, z, z, w);
        
        /// <summary>
        /// Returns vec4.yyzw swizzling.
        /// </summary>
        public vec4 yyzw => new vec4(y, y, z, w);
        
        /// <summary>
        /// Returns vec4.ggba swizzling (equivalent to vec4.yyzw).
        /// </summary>
        public vec4 ggba => new vec4(y, y, z, w);
        
        /// <summary>
        /// Returns vec4.yyzwx swizzling.
        /// </summary>
        public vec5 yyzwx => new vec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns vec4.ggbar swizzling (equivalent to vec4.yyzwx).
        /// </summary>
        public vec5 ggbar => new vec5(y, y, z, w, x);
        
        /// <summary>
        /// Returns vec4.yyzwy swizzling.
        /// </summary>
        public vec5 yyzwy => new vec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns vec4.ggbag swizzling (equivalent to vec4.yyzwy).
        /// </summary>
        public vec5 ggbag => new vec5(y, y, z, w, y);
        
        /// <summary>
        /// Returns vec4.yyzwz swizzling.
        /// </summary>
        public vec5 yyzwz => new vec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns vec4.ggbab swizzling (equivalent to vec4.yyzwz).
        /// </summary>
        public vec5 ggbab => new vec5(y, y, z, w, z);
        
        /// <summary>
        /// Returns vec4.yyzww swizzling.
        /// </summary>
        public vec5 yyzww => new vec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns vec4.ggbaa swizzling (equivalent to vec4.yyzww).
        /// </summary>
        public vec5 ggbaa => new vec5(y, y, z, w, w);
        
        /// <summary>
        /// Returns vec4.yyw swizzling.
        /// </summary>
        public vec3 yyw => new vec3(y, y, w);
        
        /// <summary>
        /// Returns vec4.gga swizzling (equivalent to vec4.yyw).
        /// </summary>
        public vec3 gga => new vec3(y, y, w);
        
        /// <summary>
        /// Returns vec4.yywx swizzling.
        /// </summary>
        public vec4 yywx => new vec4(y, y, w, x);
        
        /// <summary>
        /// Returns vec4.ggar swizzling (equivalent to vec4.yywx).
        /// </summary>
        public vec4 ggar => new vec4(y, y, w, x);
        
        /// <summary>
        /// Returns vec4.yywxx swizzling.
        /// </summary>
        public vec5 yywxx => new vec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns vec4.ggarr swizzling (equivalent to vec4.yywxx).
        /// </summary>
        public vec5 ggarr => new vec5(y, y, w, x, x);
        
        /// <summary>
        /// Returns vec4.yywxy swizzling.
        /// </summary>
        public vec5 yywxy => new vec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns vec4.ggarg swizzling (equivalent to vec4.yywxy).
        /// </summary>
        public vec5 ggarg => new vec5(y, y, w, x, y);
        
        /// <summary>
        /// Returns vec4.yywxz swizzling.
        /// </summary>
        public vec5 yywxz => new vec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns vec4.ggarb swizzling (equivalent to vec4.yywxz).
        /// </summary>
        public vec5 ggarb => new vec5(y, y, w, x, z);
        
        /// <summary>
        /// Returns vec4.yywxw swizzling.
        /// </summary>
        public vec5 yywxw => new vec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns vec4.ggara swizzling (equivalent to vec4.yywxw).
        /// </summary>
        public vec5 ggara => new vec5(y, y, w, x, w);
        
        /// <summary>
        /// Returns vec4.yywy swizzling.
        /// </summary>
        public vec4 yywy => new vec4(y, y, w, y);
        
        /// <summary>
        /// Returns vec4.ggag swizzling (equivalent to vec4.yywy).
        /// </summary>
        public vec4 ggag => new vec4(y, y, w, y);
        
        /// <summary>
        /// Returns vec4.yywyx swizzling.
        /// </summary>
        public vec5 yywyx => new vec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns vec4.ggagr swizzling (equivalent to vec4.yywyx).
        /// </summary>
        public vec5 ggagr => new vec5(y, y, w, y, x);
        
        /// <summary>
        /// Returns vec4.yywyy swizzling.
        /// </summary>
        public vec5 yywyy => new vec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns vec4.ggagg swizzling (equivalent to vec4.yywyy).
        /// </summary>
        public vec5 ggagg => new vec5(y, y, w, y, y);
        
        /// <summary>
        /// Returns vec4.yywyz swizzling.
        /// </summary>
        public vec5 yywyz => new vec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns vec4.ggagb swizzling (equivalent to vec4.yywyz).
        /// </summary>
        public vec5 ggagb => new vec5(y, y, w, y, z);
        
        /// <summary>
        /// Returns vec4.yywyw swizzling.
        /// </summary>
        public vec5 yywyw => new vec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns vec4.ggaga swizzling (equivalent to vec4.yywyw).
        /// </summary>
        public vec5 ggaga => new vec5(y, y, w, y, w);
        
        /// <summary>
        /// Returns vec4.yywz swizzling.
        /// </summary>
        public vec4 yywz => new vec4(y, y, w, z);
        
        /// <summary>
        /// Returns vec4.ggab swizzling (equivalent to vec4.yywz).
        /// </summary>
        public vec4 ggab => new vec4(y, y, w, z);
        
        /// <summary>
        /// Returns vec4.yywzx swizzling.
        /// </summary>
        public vec5 yywzx => new vec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns vec4.ggabr swizzling (equivalent to vec4.yywzx).
        /// </summary>
        public vec5 ggabr => new vec5(y, y, w, z, x);
        
        /// <summary>
        /// Returns vec4.yywzy swizzling.
        /// </summary>
        public vec5 yywzy => new vec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns vec4.ggabg swizzling (equivalent to vec4.yywzy).
        /// </summary>
        public vec5 ggabg => new vec5(y, y, w, z, y);
        
        /// <summary>
        /// Returns vec4.yywzz swizzling.
        /// </summary>
        public vec5 yywzz => new vec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns vec4.ggabb swizzling (equivalent to vec4.yywzz).
        /// </summary>
        public vec5 ggabb => new vec5(y, y, w, z, z);
        
        /// <summary>
        /// Returns vec4.yywzw swizzling.
        /// </summary>
        public vec5 yywzw => new vec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns vec4.ggaba swizzling (equivalent to vec4.yywzw).
        /// </summary>
        public vec5 ggaba => new vec5(y, y, w, z, w);
        
        /// <summary>
        /// Returns vec4.yyww swizzling.
        /// </summary>
        public vec4 yyww => new vec4(y, y, w, w);
        
        /// <summary>
        /// Returns vec4.ggaa swizzling (equivalent to vec4.yyww).
        /// </summary>
        public vec4 ggaa => new vec4(y, y, w, w);
        
        /// <summary>
        /// Returns vec4.yywwx swizzling.
        /// </summary>
        public vec5 yywwx => new vec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns vec4.ggaar swizzling (equivalent to vec4.yywwx).
        /// </summary>
        public vec5 ggaar => new vec5(y, y, w, w, x);
        
        /// <summary>
        /// Returns vec4.yywwy swizzling.
        /// </summary>
        public vec5 yywwy => new vec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns vec4.ggaag swizzling (equivalent to vec4.yywwy).
        /// </summary>
        public vec5 ggaag => new vec5(y, y, w, w, y);
        
        /// <summary>
        /// Returns vec4.yywwz swizzling.
        /// </summary>
        public vec5 yywwz => new vec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns vec4.ggaab swizzling (equivalent to vec4.yywwz).
        /// </summary>
        public vec5 ggaab => new vec5(y, y, w, w, z);
        
        /// <summary>
        /// Returns vec4.yywww swizzling.
        /// </summary>
        public vec5 yywww => new vec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns vec4.ggaaa swizzling (equivalent to vec4.yywww).
        /// </summary>
        public vec5 ggaaa => new vec5(y, y, w, w, w);
        
        /// <summary>
        /// Returns vec4.yz swizzling.
        /// </summary>
        public vec2 yz => new vec2(y, z);
        
        /// <summary>
        /// Returns vec4.gb swizzling (equivalent to vec4.yz).
        /// </summary>
        public vec2 gb => new vec2(y, z);
        
        /// <summary>
        /// Returns vec4.yzx swizzling.
        /// </summary>
        public vec3 yzx => new vec3(y, z, x);
        
        /// <summary>
        /// Returns vec4.gbr swizzling (equivalent to vec4.yzx).
        /// </summary>
        public vec3 gbr => new vec3(y, z, x);
        
        /// <summary>
        /// Returns vec4.yzxx swizzling.
        /// </summary>
        public vec4 yzxx => new vec4(y, z, x, x);
        
        /// <summary>
        /// Returns vec4.gbrr swizzling (equivalent to vec4.yzxx).
        /// </summary>
        public vec4 gbrr => new vec4(y, z, x, x);
        
        /// <summary>
        /// Returns vec4.yzxxx swizzling.
        /// </summary>
        public vec5 yzxxx => new vec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns vec4.gbrrr swizzling (equivalent to vec4.yzxxx).
        /// </summary>
        public vec5 gbrrr => new vec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns vec4.yzxxy swizzling.
        /// </summary>
        public vec5 yzxxy => new vec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns vec4.gbrrg swizzling (equivalent to vec4.yzxxy).
        /// </summary>
        public vec5 gbrrg => new vec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns vec4.yzxxz swizzling.
        /// </summary>
        public vec5 yzxxz => new vec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns vec4.gbrrb swizzling (equivalent to vec4.yzxxz).
        /// </summary>
        public vec5 gbrrb => new vec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns vec4.yzxxw swizzling.
        /// </summary>
        public vec5 yzxxw => new vec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns vec4.gbrra swizzling (equivalent to vec4.yzxxw).
        /// </summary>
        public vec5 gbrra => new vec5(y, z, x, x, w);
        
        /// <summary>
        /// Returns vec4.yzxy swizzling.
        /// </summary>
        public vec4 yzxy => new vec4(y, z, x, y);
        
        /// <summary>
        /// Returns vec4.gbrg swizzling (equivalent to vec4.yzxy).
        /// </summary>
        public vec4 gbrg => new vec4(y, z, x, y);
        
        /// <summary>
        /// Returns vec4.yzxyx swizzling.
        /// </summary>
        public vec5 yzxyx => new vec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns vec4.gbrgr swizzling (equivalent to vec4.yzxyx).
        /// </summary>
        public vec5 gbrgr => new vec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns vec4.yzxyy swizzling.
        /// </summary>
        public vec5 yzxyy => new vec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns vec4.gbrgg swizzling (equivalent to vec4.yzxyy).
        /// </summary>
        public vec5 gbrgg => new vec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns vec4.yzxyz swizzling.
        /// </summary>
        public vec5 yzxyz => new vec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns vec4.gbrgb swizzling (equivalent to vec4.yzxyz).
        /// </summary>
        public vec5 gbrgb => new vec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns vec4.yzxyw swizzling.
        /// </summary>
        public vec5 yzxyw => new vec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns vec4.gbrga swizzling (equivalent to vec4.yzxyw).
        /// </summary>
        public vec5 gbrga => new vec5(y, z, x, y, w);
        
        /// <summary>
        /// Returns vec4.yzxz swizzling.
        /// </summary>
        public vec4 yzxz => new vec4(y, z, x, z);
        
        /// <summary>
        /// Returns vec4.gbrb swizzling (equivalent to vec4.yzxz).
        /// </summary>
        public vec4 gbrb => new vec4(y, z, x, z);
        
        /// <summary>
        /// Returns vec4.yzxzx swizzling.
        /// </summary>
        public vec5 yzxzx => new vec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns vec4.gbrbr swizzling (equivalent to vec4.yzxzx).
        /// </summary>
        public vec5 gbrbr => new vec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns vec4.yzxzy swizzling.
        /// </summary>
        public vec5 yzxzy => new vec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns vec4.gbrbg swizzling (equivalent to vec4.yzxzy).
        /// </summary>
        public vec5 gbrbg => new vec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns vec4.yzxzz swizzling.
        /// </summary>
        public vec5 yzxzz => new vec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns vec4.gbrbb swizzling (equivalent to vec4.yzxzz).
        /// </summary>
        public vec5 gbrbb => new vec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns vec4.yzxzw swizzling.
        /// </summary>
        public vec5 yzxzw => new vec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns vec4.gbrba swizzling (equivalent to vec4.yzxzw).
        /// </summary>
        public vec5 gbrba => new vec5(y, z, x, z, w);
        
        /// <summary>
        /// Returns vec4.yzxw swizzling.
        /// </summary>
        public vec4 yzxw => new vec4(y, z, x, w);
        
        /// <summary>
        /// Returns vec4.gbra swizzling (equivalent to vec4.yzxw).
        /// </summary>
        public vec4 gbra => new vec4(y, z, x, w);
        
        /// <summary>
        /// Returns vec4.yzxwx swizzling.
        /// </summary>
        public vec5 yzxwx => new vec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns vec4.gbrar swizzling (equivalent to vec4.yzxwx).
        /// </summary>
        public vec5 gbrar => new vec5(y, z, x, w, x);
        
        /// <summary>
        /// Returns vec4.yzxwy swizzling.
        /// </summary>
        public vec5 yzxwy => new vec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns vec4.gbrag swizzling (equivalent to vec4.yzxwy).
        /// </summary>
        public vec5 gbrag => new vec5(y, z, x, w, y);
        
        /// <summary>
        /// Returns vec4.yzxwz swizzling.
        /// </summary>
        public vec5 yzxwz => new vec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns vec4.gbrab swizzling (equivalent to vec4.yzxwz).
        /// </summary>
        public vec5 gbrab => new vec5(y, z, x, w, z);
        
        /// <summary>
        /// Returns vec4.yzxww swizzling.
        /// </summary>
        public vec5 yzxww => new vec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns vec4.gbraa swizzling (equivalent to vec4.yzxww).
        /// </summary>
        public vec5 gbraa => new vec5(y, z, x, w, w);
        
        /// <summary>
        /// Returns vec4.yzy swizzling.
        /// </summary>
        public vec3 yzy => new vec3(y, z, y);
        
        /// <summary>
        /// Returns vec4.gbg swizzling (equivalent to vec4.yzy).
        /// </summary>
        public vec3 gbg => new vec3(y, z, y);
        
        /// <summary>
        /// Returns vec4.yzyx swizzling.
        /// </summary>
        public vec4 yzyx => new vec4(y, z, y, x);
        
        /// <summary>
        /// Returns vec4.gbgr swizzling (equivalent to vec4.yzyx).
        /// </summary>
        public vec4 gbgr => new vec4(y, z, y, x);
        
        /// <summary>
        /// Returns vec4.yzyxx swizzling.
        /// </summary>
        public vec5 yzyxx => new vec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns vec4.gbgrr swizzling (equivalent to vec4.yzyxx).
        /// </summary>
        public vec5 gbgrr => new vec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns vec4.yzyxy swizzling.
        /// </summary>
        public vec5 yzyxy => new vec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns vec4.gbgrg swizzling (equivalent to vec4.yzyxy).
        /// </summary>
        public vec5 gbgrg => new vec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns vec4.yzyxz swizzling.
        /// </summary>
        public vec5 yzyxz => new vec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns vec4.gbgrb swizzling (equivalent to vec4.yzyxz).
        /// </summary>
        public vec5 gbgrb => new vec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns vec4.yzyxw swizzling.
        /// </summary>
        public vec5 yzyxw => new vec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns vec4.gbgra swizzling (equivalent to vec4.yzyxw).
        /// </summary>
        public vec5 gbgra => new vec5(y, z, y, x, w);
        
        /// <summary>
        /// Returns vec4.yzyy swizzling.
        /// </summary>
        public vec4 yzyy => new vec4(y, z, y, y);
        
        /// <summary>
        /// Returns vec4.gbgg swizzling (equivalent to vec4.yzyy).
        /// </summary>
        public vec4 gbgg => new vec4(y, z, y, y);
        
        /// <summary>
        /// Returns vec4.yzyyx swizzling.
        /// </summary>
        public vec5 yzyyx => new vec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns vec4.gbggr swizzling (equivalent to vec4.yzyyx).
        /// </summary>
        public vec5 gbggr => new vec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns vec4.yzyyy swizzling.
        /// </summary>
        public vec5 yzyyy => new vec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns vec4.gbggg swizzling (equivalent to vec4.yzyyy).
        /// </summary>
        public vec5 gbggg => new vec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns vec4.yzyyz swizzling.
        /// </summary>
        public vec5 yzyyz => new vec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns vec4.gbggb swizzling (equivalent to vec4.yzyyz).
        /// </summary>
        public vec5 gbggb => new vec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns vec4.yzyyw swizzling.
        /// </summary>
        public vec5 yzyyw => new vec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns vec4.gbgga swizzling (equivalent to vec4.yzyyw).
        /// </summary>
        public vec5 gbgga => new vec5(y, z, y, y, w);
        
        /// <summary>
        /// Returns vec4.yzyz swizzling.
        /// </summary>
        public vec4 yzyz => new vec4(y, z, y, z);
        
        /// <summary>
        /// Returns vec4.gbgb swizzling (equivalent to vec4.yzyz).
        /// </summary>
        public vec4 gbgb => new vec4(y, z, y, z);
        
        /// <summary>
        /// Returns vec4.yzyzx swizzling.
        /// </summary>
        public vec5 yzyzx => new vec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns vec4.gbgbr swizzling (equivalent to vec4.yzyzx).
        /// </summary>
        public vec5 gbgbr => new vec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns vec4.yzyzy swizzling.
        /// </summary>
        public vec5 yzyzy => new vec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns vec4.gbgbg swizzling (equivalent to vec4.yzyzy).
        /// </summary>
        public vec5 gbgbg => new vec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns vec4.yzyzz swizzling.
        /// </summary>
        public vec5 yzyzz => new vec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns vec4.gbgbb swizzling (equivalent to vec4.yzyzz).
        /// </summary>
        public vec5 gbgbb => new vec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns vec4.yzyzw swizzling.
        /// </summary>
        public vec5 yzyzw => new vec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns vec4.gbgba swizzling (equivalent to vec4.yzyzw).
        /// </summary>
        public vec5 gbgba => new vec5(y, z, y, z, w);
        
        /// <summary>
        /// Returns vec4.yzyw swizzling.
        /// </summary>
        public vec4 yzyw => new vec4(y, z, y, w);
        
        /// <summary>
        /// Returns vec4.gbga swizzling (equivalent to vec4.yzyw).
        /// </summary>
        public vec4 gbga => new vec4(y, z, y, w);
        
        /// <summary>
        /// Returns vec4.yzywx swizzling.
        /// </summary>
        public vec5 yzywx => new vec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns vec4.gbgar swizzling (equivalent to vec4.yzywx).
        /// </summary>
        public vec5 gbgar => new vec5(y, z, y, w, x);
        
        /// <summary>
        /// Returns vec4.yzywy swizzling.
        /// </summary>
        public vec5 yzywy => new vec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns vec4.gbgag swizzling (equivalent to vec4.yzywy).
        /// </summary>
        public vec5 gbgag => new vec5(y, z, y, w, y);
        
        /// <summary>
        /// Returns vec4.yzywz swizzling.
        /// </summary>
        public vec5 yzywz => new vec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns vec4.gbgab swizzling (equivalent to vec4.yzywz).
        /// </summary>
        public vec5 gbgab => new vec5(y, z, y, w, z);
        
        /// <summary>
        /// Returns vec4.yzyww swizzling.
        /// </summary>
        public vec5 yzyww => new vec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns vec4.gbgaa swizzling (equivalent to vec4.yzyww).
        /// </summary>
        public vec5 gbgaa => new vec5(y, z, y, w, w);
        
        /// <summary>
        /// Returns vec4.yzz swizzling.
        /// </summary>
        public vec3 yzz => new vec3(y, z, z);
        
        /// <summary>
        /// Returns vec4.gbb swizzling (equivalent to vec4.yzz).
        /// </summary>
        public vec3 gbb => new vec3(y, z, z);
        
        /// <summary>
        /// Returns vec4.yzzx swizzling.
        /// </summary>
        public vec4 yzzx => new vec4(y, z, z, x);
        
        /// <summary>
        /// Returns vec4.gbbr swizzling (equivalent to vec4.yzzx).
        /// </summary>
        public vec4 gbbr => new vec4(y, z, z, x);
        
        /// <summary>
        /// Returns vec4.yzzxx swizzling.
        /// </summary>
        public vec5 yzzxx => new vec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns vec4.gbbrr swizzling (equivalent to vec4.yzzxx).
        /// </summary>
        public vec5 gbbrr => new vec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns vec4.yzzxy swizzling.
        /// </summary>
        public vec5 yzzxy => new vec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns vec4.gbbrg swizzling (equivalent to vec4.yzzxy).
        /// </summary>
        public vec5 gbbrg => new vec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns vec4.yzzxz swizzling.
        /// </summary>
        public vec5 yzzxz => new vec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns vec4.gbbrb swizzling (equivalent to vec4.yzzxz).
        /// </summary>
        public vec5 gbbrb => new vec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns vec4.yzzxw swizzling.
        /// </summary>
        public vec5 yzzxw => new vec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns vec4.gbbra swizzling (equivalent to vec4.yzzxw).
        /// </summary>
        public vec5 gbbra => new vec5(y, z, z, x, w);
        
        /// <summary>
        /// Returns vec4.yzzy swizzling.
        /// </summary>
        public vec4 yzzy => new vec4(y, z, z, y);
        
        /// <summary>
        /// Returns vec4.gbbg swizzling (equivalent to vec4.yzzy).
        /// </summary>
        public vec4 gbbg => new vec4(y, z, z, y);
        
        /// <summary>
        /// Returns vec4.yzzyx swizzling.
        /// </summary>
        public vec5 yzzyx => new vec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns vec4.gbbgr swizzling (equivalent to vec4.yzzyx).
        /// </summary>
        public vec5 gbbgr => new vec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns vec4.yzzyy swizzling.
        /// </summary>
        public vec5 yzzyy => new vec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns vec4.gbbgg swizzling (equivalent to vec4.yzzyy).
        /// </summary>
        public vec5 gbbgg => new vec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns vec4.yzzyz swizzling.
        /// </summary>
        public vec5 yzzyz => new vec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns vec4.gbbgb swizzling (equivalent to vec4.yzzyz).
        /// </summary>
        public vec5 gbbgb => new vec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns vec4.yzzyw swizzling.
        /// </summary>
        public vec5 yzzyw => new vec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns vec4.gbbga swizzling (equivalent to vec4.yzzyw).
        /// </summary>
        public vec5 gbbga => new vec5(y, z, z, y, w);
        
        /// <summary>
        /// Returns vec4.yzzz swizzling.
        /// </summary>
        public vec4 yzzz => new vec4(y, z, z, z);
        
        /// <summary>
        /// Returns vec4.gbbb swizzling (equivalent to vec4.yzzz).
        /// </summary>
        public vec4 gbbb => new vec4(y, z, z, z);
        
        /// <summary>
        /// Returns vec4.yzzzx swizzling.
        /// </summary>
        public vec5 yzzzx => new vec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns vec4.gbbbr swizzling (equivalent to vec4.yzzzx).
        /// </summary>
        public vec5 gbbbr => new vec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns vec4.yzzzy swizzling.
        /// </summary>
        public vec5 yzzzy => new vec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns vec4.gbbbg swizzling (equivalent to vec4.yzzzy).
        /// </summary>
        public vec5 gbbbg => new vec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns vec4.yzzzz swizzling.
        /// </summary>
        public vec5 yzzzz => new vec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns vec4.gbbbb swizzling (equivalent to vec4.yzzzz).
        /// </summary>
        public vec5 gbbbb => new vec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns vec4.yzzzw swizzling.
        /// </summary>
        public vec5 yzzzw => new vec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns vec4.gbbba swizzling (equivalent to vec4.yzzzw).
        /// </summary>
        public vec5 gbbba => new vec5(y, z, z, z, w);
        
        /// <summary>
        /// Returns vec4.yzzw swizzling.
        /// </summary>
        public vec4 yzzw => new vec4(y, z, z, w);
        
        /// <summary>
        /// Returns vec4.gbba swizzling (equivalent to vec4.yzzw).
        /// </summary>
        public vec4 gbba => new vec4(y, z, z, w);
        
        /// <summary>
        /// Returns vec4.yzzwx swizzling.
        /// </summary>
        public vec5 yzzwx => new vec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns vec4.gbbar swizzling (equivalent to vec4.yzzwx).
        /// </summary>
        public vec5 gbbar => new vec5(y, z, z, w, x);
        
        /// <summary>
        /// Returns vec4.yzzwy swizzling.
        /// </summary>
        public vec5 yzzwy => new vec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns vec4.gbbag swizzling (equivalent to vec4.yzzwy).
        /// </summary>
        public vec5 gbbag => new vec5(y, z, z, w, y);
        
        /// <summary>
        /// Returns vec4.yzzwz swizzling.
        /// </summary>
        public vec5 yzzwz => new vec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns vec4.gbbab swizzling (equivalent to vec4.yzzwz).
        /// </summary>
        public vec5 gbbab => new vec5(y, z, z, w, z);
        
        /// <summary>
        /// Returns vec4.yzzww swizzling.
        /// </summary>
        public vec5 yzzww => new vec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns vec4.gbbaa swizzling (equivalent to vec4.yzzww).
        /// </summary>
        public vec5 gbbaa => new vec5(y, z, z, w, w);
        
        /// <summary>
        /// Returns vec4.yzw swizzling.
        /// </summary>
        public vec3 yzw => new vec3(y, z, w);
        
        /// <summary>
        /// Returns vec4.gba swizzling (equivalent to vec4.yzw).
        /// </summary>
        public vec3 gba => new vec3(y, z, w);
        
        /// <summary>
        /// Returns vec4.yzwx swizzling.
        /// </summary>
        public vec4 yzwx => new vec4(y, z, w, x);
        
        /// <summary>
        /// Returns vec4.gbar swizzling (equivalent to vec4.yzwx).
        /// </summary>
        public vec4 gbar => new vec4(y, z, w, x);
        
        /// <summary>
        /// Returns vec4.yzwxx swizzling.
        /// </summary>
        public vec5 yzwxx => new vec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns vec4.gbarr swizzling (equivalent to vec4.yzwxx).
        /// </summary>
        public vec5 gbarr => new vec5(y, z, w, x, x);
        
        /// <summary>
        /// Returns vec4.yzwxy swizzling.
        /// </summary>
        public vec5 yzwxy => new vec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns vec4.gbarg swizzling (equivalent to vec4.yzwxy).
        /// </summary>
        public vec5 gbarg => new vec5(y, z, w, x, y);
        
        /// <summary>
        /// Returns vec4.yzwxz swizzling.
        /// </summary>
        public vec5 yzwxz => new vec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns vec4.gbarb swizzling (equivalent to vec4.yzwxz).
        /// </summary>
        public vec5 gbarb => new vec5(y, z, w, x, z);
        
        /// <summary>
        /// Returns vec4.yzwxw swizzling.
        /// </summary>
        public vec5 yzwxw => new vec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns vec4.gbara swizzling (equivalent to vec4.yzwxw).
        /// </summary>
        public vec5 gbara => new vec5(y, z, w, x, w);
        
        /// <summary>
        /// Returns vec4.yzwy swizzling.
        /// </summary>
        public vec4 yzwy => new vec4(y, z, w, y);
        
        /// <summary>
        /// Returns vec4.gbag swizzling (equivalent to vec4.yzwy).
        /// </summary>
        public vec4 gbag => new vec4(y, z, w, y);
        
        /// <summary>
        /// Returns vec4.yzwyx swizzling.
        /// </summary>
        public vec5 yzwyx => new vec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns vec4.gbagr swizzling (equivalent to vec4.yzwyx).
        /// </summary>
        public vec5 gbagr => new vec5(y, z, w, y, x);
        
        /// <summary>
        /// Returns vec4.yzwyy swizzling.
        /// </summary>
        public vec5 yzwyy => new vec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns vec4.gbagg swizzling (equivalent to vec4.yzwyy).
        /// </summary>
        public vec5 gbagg => new vec5(y, z, w, y, y);
        
        /// <summary>
        /// Returns vec4.yzwyz swizzling.
        /// </summary>
        public vec5 yzwyz => new vec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns vec4.gbagb swizzling (equivalent to vec4.yzwyz).
        /// </summary>
        public vec5 gbagb => new vec5(y, z, w, y, z);
        
        /// <summary>
        /// Returns vec4.yzwyw swizzling.
        /// </summary>
        public vec5 yzwyw => new vec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns vec4.gbaga swizzling (equivalent to vec4.yzwyw).
        /// </summary>
        public vec5 gbaga => new vec5(y, z, w, y, w);
        
        /// <summary>
        /// Returns vec4.yzwz swizzling.
        /// </summary>
        public vec4 yzwz => new vec4(y, z, w, z);
        
        /// <summary>
        /// Returns vec4.gbab swizzling (equivalent to vec4.yzwz).
        /// </summary>
        public vec4 gbab => new vec4(y, z, w, z);
        
        /// <summary>
        /// Returns vec4.yzwzx swizzling.
        /// </summary>
        public vec5 yzwzx => new vec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns vec4.gbabr swizzling (equivalent to vec4.yzwzx).
        /// </summary>
        public vec5 gbabr => new vec5(y, z, w, z, x);
        
        /// <summary>
        /// Returns vec4.yzwzy swizzling.
        /// </summary>
        public vec5 yzwzy => new vec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns vec4.gbabg swizzling (equivalent to vec4.yzwzy).
        /// </summary>
        public vec5 gbabg => new vec5(y, z, w, z, y);
        
        /// <summary>
        /// Returns vec4.yzwzz swizzling.
        /// </summary>
        public vec5 yzwzz => new vec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns vec4.gbabb swizzling (equivalent to vec4.yzwzz).
        /// </summary>
        public vec5 gbabb => new vec5(y, z, w, z, z);
        
        /// <summary>
        /// Returns vec4.yzwzw swizzling.
        /// </summary>
        public vec5 yzwzw => new vec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns vec4.gbaba swizzling (equivalent to vec4.yzwzw).
        /// </summary>
        public vec5 gbaba => new vec5(y, z, w, z, w);
        
        /// <summary>
        /// Returns vec4.yzww swizzling.
        /// </summary>
        public vec4 yzww => new vec4(y, z, w, w);
        
        /// <summary>
        /// Returns vec4.gbaa swizzling (equivalent to vec4.yzww).
        /// </summary>
        public vec4 gbaa => new vec4(y, z, w, w);
        
        /// <summary>
        /// Returns vec4.yzwwx swizzling.
        /// </summary>
        public vec5 yzwwx => new vec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns vec4.gbaar swizzling (equivalent to vec4.yzwwx).
        /// </summary>
        public vec5 gbaar => new vec5(y, z, w, w, x);
        
        /// <summary>
        /// Returns vec4.yzwwy swizzling.
        /// </summary>
        public vec5 yzwwy => new vec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns vec4.gbaag swizzling (equivalent to vec4.yzwwy).
        /// </summary>
        public vec5 gbaag => new vec5(y, z, w, w, y);
        
        /// <summary>
        /// Returns vec4.yzwwz swizzling.
        /// </summary>
        public vec5 yzwwz => new vec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns vec4.gbaab swizzling (equivalent to vec4.yzwwz).
        /// </summary>
        public vec5 gbaab => new vec5(y, z, w, w, z);
        
        /// <summary>
        /// Returns vec4.yzwww swizzling.
        /// </summary>
        public vec5 yzwww => new vec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns vec4.gbaaa swizzling (equivalent to vec4.yzwww).
        /// </summary>
        public vec5 gbaaa => new vec5(y, z, w, w, w);
        
        /// <summary>
        /// Returns vec4.yw swizzling.
        /// </summary>
        public vec2 yw => new vec2(y, w);
        
        /// <summary>
        /// Returns vec4.ga swizzling (equivalent to vec4.yw).
        /// </summary>
        public vec2 ga => new vec2(y, w);
        
        /// <summary>
        /// Returns vec4.ywx swizzling.
        /// </summary>
        public vec3 ywx => new vec3(y, w, x);
        
        /// <summary>
        /// Returns vec4.gar swizzling (equivalent to vec4.ywx).
        /// </summary>
        public vec3 gar => new vec3(y, w, x);
        
        /// <summary>
        /// Returns vec4.ywxx swizzling.
        /// </summary>
        public vec4 ywxx => new vec4(y, w, x, x);
        
        /// <summary>
        /// Returns vec4.garr swizzling (equivalent to vec4.ywxx).
        /// </summary>
        public vec4 garr => new vec4(y, w, x, x);
        
        /// <summary>
        /// Returns vec4.ywxxx swizzling.
        /// </summary>
        public vec5 ywxxx => new vec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns vec4.garrr swizzling (equivalent to vec4.ywxxx).
        /// </summary>
        public vec5 garrr => new vec5(y, w, x, x, x);
        
        /// <summary>
        /// Returns vec4.ywxxy swizzling.
        /// </summary>
        public vec5 ywxxy => new vec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns vec4.garrg swizzling (equivalent to vec4.ywxxy).
        /// </summary>
        public vec5 garrg => new vec5(y, w, x, x, y);
        
        /// <summary>
        /// Returns vec4.ywxxz swizzling.
        /// </summary>
        public vec5 ywxxz => new vec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns vec4.garrb swizzling (equivalent to vec4.ywxxz).
        /// </summary>
        public vec5 garrb => new vec5(y, w, x, x, z);
        
        /// <summary>
        /// Returns vec4.ywxxw swizzling.
        /// </summary>
        public vec5 ywxxw => new vec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns vec4.garra swizzling (equivalent to vec4.ywxxw).
        /// </summary>
        public vec5 garra => new vec5(y, w, x, x, w);
        
        /// <summary>
        /// Returns vec4.ywxy swizzling.
        /// </summary>
        public vec4 ywxy => new vec4(y, w, x, y);
        
        /// <summary>
        /// Returns vec4.garg swizzling (equivalent to vec4.ywxy).
        /// </summary>
        public vec4 garg => new vec4(y, w, x, y);
        
        /// <summary>
        /// Returns vec4.ywxyx swizzling.
        /// </summary>
        public vec5 ywxyx => new vec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns vec4.gargr swizzling (equivalent to vec4.ywxyx).
        /// </summary>
        public vec5 gargr => new vec5(y, w, x, y, x);
        
        /// <summary>
        /// Returns vec4.ywxyy swizzling.
        /// </summary>
        public vec5 ywxyy => new vec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns vec4.gargg swizzling (equivalent to vec4.ywxyy).
        /// </summary>
        public vec5 gargg => new vec5(y, w, x, y, y);
        
        /// <summary>
        /// Returns vec4.ywxyz swizzling.
        /// </summary>
        public vec5 ywxyz => new vec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns vec4.gargb swizzling (equivalent to vec4.ywxyz).
        /// </summary>
        public vec5 gargb => new vec5(y, w, x, y, z);
        
        /// <summary>
        /// Returns vec4.ywxyw swizzling.
        /// </summary>
        public vec5 ywxyw => new vec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns vec4.garga swizzling (equivalent to vec4.ywxyw).
        /// </summary>
        public vec5 garga => new vec5(y, w, x, y, w);
        
        /// <summary>
        /// Returns vec4.ywxz swizzling.
        /// </summary>
        public vec4 ywxz => new vec4(y, w, x, z);
        
        /// <summary>
        /// Returns vec4.garb swizzling (equivalent to vec4.ywxz).
        /// </summary>
        public vec4 garb => new vec4(y, w, x, z);
        
        /// <summary>
        /// Returns vec4.ywxzx swizzling.
        /// </summary>
        public vec5 ywxzx => new vec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns vec4.garbr swizzling (equivalent to vec4.ywxzx).
        /// </summary>
        public vec5 garbr => new vec5(y, w, x, z, x);
        
        /// <summary>
        /// Returns vec4.ywxzy swizzling.
        /// </summary>
        public vec5 ywxzy => new vec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns vec4.garbg swizzling (equivalent to vec4.ywxzy).
        /// </summary>
        public vec5 garbg => new vec5(y, w, x, z, y);
        
        /// <summary>
        /// Returns vec4.ywxzz swizzling.
        /// </summary>
        public vec5 ywxzz => new vec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns vec4.garbb swizzling (equivalent to vec4.ywxzz).
        /// </summary>
        public vec5 garbb => new vec5(y, w, x, z, z);
        
        /// <summary>
        /// Returns vec4.ywxzw swizzling.
        /// </summary>
        public vec5 ywxzw => new vec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns vec4.garba swizzling (equivalent to vec4.ywxzw).
        /// </summary>
        public vec5 garba => new vec5(y, w, x, z, w);
        
        /// <summary>
        /// Returns vec4.ywxw swizzling.
        /// </summary>
        public vec4 ywxw => new vec4(y, w, x, w);
        
        /// <summary>
        /// Returns vec4.gara swizzling (equivalent to vec4.ywxw).
        /// </summary>
        public vec4 gara => new vec4(y, w, x, w);
        
        /// <summary>
        /// Returns vec4.ywxwx swizzling.
        /// </summary>
        public vec5 ywxwx => new vec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns vec4.garar swizzling (equivalent to vec4.ywxwx).
        /// </summary>
        public vec5 garar => new vec5(y, w, x, w, x);
        
        /// <summary>
        /// Returns vec4.ywxwy swizzling.
        /// </summary>
        public vec5 ywxwy => new vec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns vec4.garag swizzling (equivalent to vec4.ywxwy).
        /// </summary>
        public vec5 garag => new vec5(y, w, x, w, y);
        
        /// <summary>
        /// Returns vec4.ywxwz swizzling.
        /// </summary>
        public vec5 ywxwz => new vec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns vec4.garab swizzling (equivalent to vec4.ywxwz).
        /// </summary>
        public vec5 garab => new vec5(y, w, x, w, z);
        
        /// <summary>
        /// Returns vec4.ywxww swizzling.
        /// </summary>
        public vec5 ywxww => new vec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns vec4.garaa swizzling (equivalent to vec4.ywxww).
        /// </summary>
        public vec5 garaa => new vec5(y, w, x, w, w);
        
        /// <summary>
        /// Returns vec4.ywy swizzling.
        /// </summary>
        public vec3 ywy => new vec3(y, w, y);
        
        /// <summary>
        /// Returns vec4.gag swizzling (equivalent to vec4.ywy).
        /// </summary>
        public vec3 gag => new vec3(y, w, y);
        
        /// <summary>
        /// Returns vec4.ywyx swizzling.
        /// </summary>
        public vec4 ywyx => new vec4(y, w, y, x);
        
        /// <summary>
        /// Returns vec4.gagr swizzling (equivalent to vec4.ywyx).
        /// </summary>
        public vec4 gagr => new vec4(y, w, y, x);
        
        /// <summary>
        /// Returns vec4.ywyxx swizzling.
        /// </summary>
        public vec5 ywyxx => new vec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns vec4.gagrr swizzling (equivalent to vec4.ywyxx).
        /// </summary>
        public vec5 gagrr => new vec5(y, w, y, x, x);
        
        /// <summary>
        /// Returns vec4.ywyxy swizzling.
        /// </summary>
        public vec5 ywyxy => new vec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns vec4.gagrg swizzling (equivalent to vec4.ywyxy).
        /// </summary>
        public vec5 gagrg => new vec5(y, w, y, x, y);
        
        /// <summary>
        /// Returns vec4.ywyxz swizzling.
        /// </summary>
        public vec5 ywyxz => new vec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns vec4.gagrb swizzling (equivalent to vec4.ywyxz).
        /// </summary>
        public vec5 gagrb => new vec5(y, w, y, x, z);
        
        /// <summary>
        /// Returns vec4.ywyxw swizzling.
        /// </summary>
        public vec5 ywyxw => new vec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns vec4.gagra swizzling (equivalent to vec4.ywyxw).
        /// </summary>
        public vec5 gagra => new vec5(y, w, y, x, w);
        
        /// <summary>
        /// Returns vec4.ywyy swizzling.
        /// </summary>
        public vec4 ywyy => new vec4(y, w, y, y);
        
        /// <summary>
        /// Returns vec4.gagg swizzling (equivalent to vec4.ywyy).
        /// </summary>
        public vec4 gagg => new vec4(y, w, y, y);
        
        /// <summary>
        /// Returns vec4.ywyyx swizzling.
        /// </summary>
        public vec5 ywyyx => new vec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns vec4.gaggr swizzling (equivalent to vec4.ywyyx).
        /// </summary>
        public vec5 gaggr => new vec5(y, w, y, y, x);
        
        /// <summary>
        /// Returns vec4.ywyyy swizzling.
        /// </summary>
        public vec5 ywyyy => new vec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns vec4.gaggg swizzling (equivalent to vec4.ywyyy).
        /// </summary>
        public vec5 gaggg => new vec5(y, w, y, y, y);
        
        /// <summary>
        /// Returns vec4.ywyyz swizzling.
        /// </summary>
        public vec5 ywyyz => new vec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns vec4.gaggb swizzling (equivalent to vec4.ywyyz).
        /// </summary>
        public vec5 gaggb => new vec5(y, w, y, y, z);
        
        /// <summary>
        /// Returns vec4.ywyyw swizzling.
        /// </summary>
        public vec5 ywyyw => new vec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns vec4.gagga swizzling (equivalent to vec4.ywyyw).
        /// </summary>
        public vec5 gagga => new vec5(y, w, y, y, w);
        
        /// <summary>
        /// Returns vec4.ywyz swizzling.
        /// </summary>
        public vec4 ywyz => new vec4(y, w, y, z);
        
        /// <summary>
        /// Returns vec4.gagb swizzling (equivalent to vec4.ywyz).
        /// </summary>
        public vec4 gagb => new vec4(y, w, y, z);
        
        /// <summary>
        /// Returns vec4.ywyzx swizzling.
        /// </summary>
        public vec5 ywyzx => new vec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns vec4.gagbr swizzling (equivalent to vec4.ywyzx).
        /// </summary>
        public vec5 gagbr => new vec5(y, w, y, z, x);
        
        /// <summary>
        /// Returns vec4.ywyzy swizzling.
        /// </summary>
        public vec5 ywyzy => new vec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns vec4.gagbg swizzling (equivalent to vec4.ywyzy).
        /// </summary>
        public vec5 gagbg => new vec5(y, w, y, z, y);
        
        /// <summary>
        /// Returns vec4.ywyzz swizzling.
        /// </summary>
        public vec5 ywyzz => new vec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns vec4.gagbb swizzling (equivalent to vec4.ywyzz).
        /// </summary>
        public vec5 gagbb => new vec5(y, w, y, z, z);
        
        /// <summary>
        /// Returns vec4.ywyzw swizzling.
        /// </summary>
        public vec5 ywyzw => new vec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns vec4.gagba swizzling (equivalent to vec4.ywyzw).
        /// </summary>
        public vec5 gagba => new vec5(y, w, y, z, w);
        
        /// <summary>
        /// Returns vec4.ywyw swizzling.
        /// </summary>
        public vec4 ywyw => new vec4(y, w, y, w);
        
        /// <summary>
        /// Returns vec4.gaga swizzling (equivalent to vec4.ywyw).
        /// </summary>
        public vec4 gaga => new vec4(y, w, y, w);
        
        /// <summary>
        /// Returns vec4.ywywx swizzling.
        /// </summary>
        public vec5 ywywx => new vec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns vec4.gagar swizzling (equivalent to vec4.ywywx).
        /// </summary>
        public vec5 gagar => new vec5(y, w, y, w, x);
        
        /// <summary>
        /// Returns vec4.ywywy swizzling.
        /// </summary>
        public vec5 ywywy => new vec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns vec4.gagag swizzling (equivalent to vec4.ywywy).
        /// </summary>
        public vec5 gagag => new vec5(y, w, y, w, y);
        
        /// <summary>
        /// Returns vec4.ywywz swizzling.
        /// </summary>
        public vec5 ywywz => new vec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns vec4.gagab swizzling (equivalent to vec4.ywywz).
        /// </summary>
        public vec5 gagab => new vec5(y, w, y, w, z);
        
        /// <summary>
        /// Returns vec4.ywyww swizzling.
        /// </summary>
        public vec5 ywyww => new vec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns vec4.gagaa swizzling (equivalent to vec4.ywyww).
        /// </summary>
        public vec5 gagaa => new vec5(y, w, y, w, w);
        
        /// <summary>
        /// Returns vec4.ywz swizzling.
        /// </summary>
        public vec3 ywz => new vec3(y, w, z);
        
        /// <summary>
        /// Returns vec4.gab swizzling (equivalent to vec4.ywz).
        /// </summary>
        public vec3 gab => new vec3(y, w, z);
        
        /// <summary>
        /// Returns vec4.ywzx swizzling.
        /// </summary>
        public vec4 ywzx => new vec4(y, w, z, x);
        
        /// <summary>
        /// Returns vec4.gabr swizzling (equivalent to vec4.ywzx).
        /// </summary>
        public vec4 gabr => new vec4(y, w, z, x);
        
        /// <summary>
        /// Returns vec4.ywzxx swizzling.
        /// </summary>
        public vec5 ywzxx => new vec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns vec4.gabrr swizzling (equivalent to vec4.ywzxx).
        /// </summary>
        public vec5 gabrr => new vec5(y, w, z, x, x);
        
        /// <summary>
        /// Returns vec4.ywzxy swizzling.
        /// </summary>
        public vec5 ywzxy => new vec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns vec4.gabrg swizzling (equivalent to vec4.ywzxy).
        /// </summary>
        public vec5 gabrg => new vec5(y, w, z, x, y);
        
        /// <summary>
        /// Returns vec4.ywzxz swizzling.
        /// </summary>
        public vec5 ywzxz => new vec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns vec4.gabrb swizzling (equivalent to vec4.ywzxz).
        /// </summary>
        public vec5 gabrb => new vec5(y, w, z, x, z);
        
        /// <summary>
        /// Returns vec4.ywzxw swizzling.
        /// </summary>
        public vec5 ywzxw => new vec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns vec4.gabra swizzling (equivalent to vec4.ywzxw).
        /// </summary>
        public vec5 gabra => new vec5(y, w, z, x, w);
        
        /// <summary>
        /// Returns vec4.ywzy swizzling.
        /// </summary>
        public vec4 ywzy => new vec4(y, w, z, y);
        
        /// <summary>
        /// Returns vec4.gabg swizzling (equivalent to vec4.ywzy).
        /// </summary>
        public vec4 gabg => new vec4(y, w, z, y);
        
        /// <summary>
        /// Returns vec4.ywzyx swizzling.
        /// </summary>
        public vec5 ywzyx => new vec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns vec4.gabgr swizzling (equivalent to vec4.ywzyx).
        /// </summary>
        public vec5 gabgr => new vec5(y, w, z, y, x);
        
        /// <summary>
        /// Returns vec4.ywzyy swizzling.
        /// </summary>
        public vec5 ywzyy => new vec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns vec4.gabgg swizzling (equivalent to vec4.ywzyy).
        /// </summary>
        public vec5 gabgg => new vec5(y, w, z, y, y);
        
        /// <summary>
        /// Returns vec4.ywzyz swizzling.
        /// </summary>
        public vec5 ywzyz => new vec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns vec4.gabgb swizzling (equivalent to vec4.ywzyz).
        /// </summary>
        public vec5 gabgb => new vec5(y, w, z, y, z);
        
        /// <summary>
        /// Returns vec4.ywzyw swizzling.
        /// </summary>
        public vec5 ywzyw => new vec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns vec4.gabga swizzling (equivalent to vec4.ywzyw).
        /// </summary>
        public vec5 gabga => new vec5(y, w, z, y, w);
        
        /// <summary>
        /// Returns vec4.ywzz swizzling.
        /// </summary>
        public vec4 ywzz => new vec4(y, w, z, z);
        
        /// <summary>
        /// Returns vec4.gabb swizzling (equivalent to vec4.ywzz).
        /// </summary>
        public vec4 gabb => new vec4(y, w, z, z);
        
        /// <summary>
        /// Returns vec4.ywzzx swizzling.
        /// </summary>
        public vec5 ywzzx => new vec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns vec4.gabbr swizzling (equivalent to vec4.ywzzx).
        /// </summary>
        public vec5 gabbr => new vec5(y, w, z, z, x);
        
        /// <summary>
        /// Returns vec4.ywzzy swizzling.
        /// </summary>
        public vec5 ywzzy => new vec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns vec4.gabbg swizzling (equivalent to vec4.ywzzy).
        /// </summary>
        public vec5 gabbg => new vec5(y, w, z, z, y);
        
        /// <summary>
        /// Returns vec4.ywzzz swizzling.
        /// </summary>
        public vec5 ywzzz => new vec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns vec4.gabbb swizzling (equivalent to vec4.ywzzz).
        /// </summary>
        public vec5 gabbb => new vec5(y, w, z, z, z);
        
        /// <summary>
        /// Returns vec4.ywzzw swizzling.
        /// </summary>
        public vec5 ywzzw => new vec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns vec4.gabba swizzling (equivalent to vec4.ywzzw).
        /// </summary>
        public vec5 gabba => new vec5(y, w, z, z, w);
        
        /// <summary>
        /// Returns vec4.ywzw swizzling.
        /// </summary>
        public vec4 ywzw => new vec4(y, w, z, w);
        
        /// <summary>
        /// Returns vec4.gaba swizzling (equivalent to vec4.ywzw).
        /// </summary>
        public vec4 gaba => new vec4(y, w, z, w);
        
        /// <summary>
        /// Returns vec4.ywzwx swizzling.
        /// </summary>
        public vec5 ywzwx => new vec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns vec4.gabar swizzling (equivalent to vec4.ywzwx).
        /// </summary>
        public vec5 gabar => new vec5(y, w, z, w, x);
        
        /// <summary>
        /// Returns vec4.ywzwy swizzling.
        /// </summary>
        public vec5 ywzwy => new vec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns vec4.gabag swizzling (equivalent to vec4.ywzwy).
        /// </summary>
        public vec5 gabag => new vec5(y, w, z, w, y);
        
        /// <summary>
        /// Returns vec4.ywzwz swizzling.
        /// </summary>
        public vec5 ywzwz => new vec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns vec4.gabab swizzling (equivalent to vec4.ywzwz).
        /// </summary>
        public vec5 gabab => new vec5(y, w, z, w, z);
        
        /// <summary>
        /// Returns vec4.ywzww swizzling.
        /// </summary>
        public vec5 ywzww => new vec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns vec4.gabaa swizzling (equivalent to vec4.ywzww).
        /// </summary>
        public vec5 gabaa => new vec5(y, w, z, w, w);
        
        /// <summary>
        /// Returns vec4.yww swizzling.
        /// </summary>
        public vec3 yww => new vec3(y, w, w);
        
        /// <summary>
        /// Returns vec4.gaa swizzling (equivalent to vec4.yww).
        /// </summary>
        public vec3 gaa => new vec3(y, w, w);
        
        /// <summary>
        /// Returns vec4.ywwx swizzling.
        /// </summary>
        public vec4 ywwx => new vec4(y, w, w, x);
        
        /// <summary>
        /// Returns vec4.gaar swizzling (equivalent to vec4.ywwx).
        /// </summary>
        public vec4 gaar => new vec4(y, w, w, x);
        
        /// <summary>
        /// Returns vec4.ywwxx swizzling.
        /// </summary>
        public vec5 ywwxx => new vec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns vec4.gaarr swizzling (equivalent to vec4.ywwxx).
        /// </summary>
        public vec5 gaarr => new vec5(y, w, w, x, x);
        
        /// <summary>
        /// Returns vec4.ywwxy swizzling.
        /// </summary>
        public vec5 ywwxy => new vec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns vec4.gaarg swizzling (equivalent to vec4.ywwxy).
        /// </summary>
        public vec5 gaarg => new vec5(y, w, w, x, y);
        
        /// <summary>
        /// Returns vec4.ywwxz swizzling.
        /// </summary>
        public vec5 ywwxz => new vec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns vec4.gaarb swizzling (equivalent to vec4.ywwxz).
        /// </summary>
        public vec5 gaarb => new vec5(y, w, w, x, z);
        
        /// <summary>
        /// Returns vec4.ywwxw swizzling.
        /// </summary>
        public vec5 ywwxw => new vec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns vec4.gaara swizzling (equivalent to vec4.ywwxw).
        /// </summary>
        public vec5 gaara => new vec5(y, w, w, x, w);
        
        /// <summary>
        /// Returns vec4.ywwy swizzling.
        /// </summary>
        public vec4 ywwy => new vec4(y, w, w, y);
        
        /// <summary>
        /// Returns vec4.gaag swizzling (equivalent to vec4.ywwy).
        /// </summary>
        public vec4 gaag => new vec4(y, w, w, y);
        
        /// <summary>
        /// Returns vec4.ywwyx swizzling.
        /// </summary>
        public vec5 ywwyx => new vec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns vec4.gaagr swizzling (equivalent to vec4.ywwyx).
        /// </summary>
        public vec5 gaagr => new vec5(y, w, w, y, x);
        
        /// <summary>
        /// Returns vec4.ywwyy swizzling.
        /// </summary>
        public vec5 ywwyy => new vec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns vec4.gaagg swizzling (equivalent to vec4.ywwyy).
        /// </summary>
        public vec5 gaagg => new vec5(y, w, w, y, y);
        
        /// <summary>
        /// Returns vec4.ywwyz swizzling.
        /// </summary>
        public vec5 ywwyz => new vec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns vec4.gaagb swizzling (equivalent to vec4.ywwyz).
        /// </summary>
        public vec5 gaagb => new vec5(y, w, w, y, z);
        
        /// <summary>
        /// Returns vec4.ywwyw swizzling.
        /// </summary>
        public vec5 ywwyw => new vec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns vec4.gaaga swizzling (equivalent to vec4.ywwyw).
        /// </summary>
        public vec5 gaaga => new vec5(y, w, w, y, w);
        
        /// <summary>
        /// Returns vec4.ywwz swizzling.
        /// </summary>
        public vec4 ywwz => new vec4(y, w, w, z);
        
        /// <summary>
        /// Returns vec4.gaab swizzling (equivalent to vec4.ywwz).
        /// </summary>
        public vec4 gaab => new vec4(y, w, w, z);
        
        /// <summary>
        /// Returns vec4.ywwzx swizzling.
        /// </summary>
        public vec5 ywwzx => new vec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns vec4.gaabr swizzling (equivalent to vec4.ywwzx).
        /// </summary>
        public vec5 gaabr => new vec5(y, w, w, z, x);
        
        /// <summary>
        /// Returns vec4.ywwzy swizzling.
        /// </summary>
        public vec5 ywwzy => new vec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns vec4.gaabg swizzling (equivalent to vec4.ywwzy).
        /// </summary>
        public vec5 gaabg => new vec5(y, w, w, z, y);
        
        /// <summary>
        /// Returns vec4.ywwzz swizzling.
        /// </summary>
        public vec5 ywwzz => new vec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns vec4.gaabb swizzling (equivalent to vec4.ywwzz).
        /// </summary>
        public vec5 gaabb => new vec5(y, w, w, z, z);
        
        /// <summary>
        /// Returns vec4.ywwzw swizzling.
        /// </summary>
        public vec5 ywwzw => new vec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns vec4.gaaba swizzling (equivalent to vec4.ywwzw).
        /// </summary>
        public vec5 gaaba => new vec5(y, w, w, z, w);
        
        /// <summary>
        /// Returns vec4.ywww swizzling.
        /// </summary>
        public vec4 ywww => new vec4(y, w, w, w);
        
        /// <summary>
        /// Returns vec4.gaaa swizzling (equivalent to vec4.ywww).
        /// </summary>
        public vec4 gaaa => new vec4(y, w, w, w);
        
        /// <summary>
        /// Returns vec4.ywwwx swizzling.
        /// </summary>
        public vec5 ywwwx => new vec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns vec4.gaaar swizzling (equivalent to vec4.ywwwx).
        /// </summary>
        public vec5 gaaar => new vec5(y, w, w, w, x);
        
        /// <summary>
        /// Returns vec4.ywwwy swizzling.
        /// </summary>
        public vec5 ywwwy => new vec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns vec4.gaaag swizzling (equivalent to vec4.ywwwy).
        /// </summary>
        public vec5 gaaag => new vec5(y, w, w, w, y);
        
        /// <summary>
        /// Returns vec4.ywwwz swizzling.
        /// </summary>
        public vec5 ywwwz => new vec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns vec4.gaaab swizzling (equivalent to vec4.ywwwz).
        /// </summary>
        public vec5 gaaab => new vec5(y, w, w, w, z);
        
        /// <summary>
        /// Returns vec4.ywwww swizzling.
        /// </summary>
        public vec5 ywwww => new vec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns vec4.gaaaa swizzling (equivalent to vec4.ywwww).
        /// </summary>
        public vec5 gaaaa => new vec5(y, w, w, w, w);
        
        /// <summary>
        /// Returns vec4.zx swizzling.
        /// </summary>
        public vec2 zx => new vec2(z, x);
        
        /// <summary>
        /// Returns vec4.br swizzling (equivalent to vec4.zx).
        /// </summary>
        public vec2 br => new vec2(z, x);
        
        /// <summary>
        /// Returns vec4.zxx swizzling.
        /// </summary>
        public vec3 zxx => new vec3(z, x, x);
        
        /// <summary>
        /// Returns vec4.brr swizzling (equivalent to vec4.zxx).
        /// </summary>
        public vec3 brr => new vec3(z, x, x);
        
        /// <summary>
        /// Returns vec4.zxxx swizzling.
        /// </summary>
        public vec4 zxxx => new vec4(z, x, x, x);
        
        /// <summary>
        /// Returns vec4.brrr swizzling (equivalent to vec4.zxxx).
        /// </summary>
        public vec4 brrr => new vec4(z, x, x, x);
        
        /// <summary>
        /// Returns vec4.zxxxx swizzling.
        /// </summary>
        public vec5 zxxxx => new vec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns vec4.brrrr swizzling (equivalent to vec4.zxxxx).
        /// </summary>
        public vec5 brrrr => new vec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns vec4.zxxxy swizzling.
        /// </summary>
        public vec5 zxxxy => new vec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns vec4.brrrg swizzling (equivalent to vec4.zxxxy).
        /// </summary>
        public vec5 brrrg => new vec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns vec4.zxxxz swizzling.
        /// </summary>
        public vec5 zxxxz => new vec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns vec4.brrrb swizzling (equivalent to vec4.zxxxz).
        /// </summary>
        public vec5 brrrb => new vec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns vec4.zxxxw swizzling.
        /// </summary>
        public vec5 zxxxw => new vec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns vec4.brrra swizzling (equivalent to vec4.zxxxw).
        /// </summary>
        public vec5 brrra => new vec5(z, x, x, x, w);
        
        /// <summary>
        /// Returns vec4.zxxy swizzling.
        /// </summary>
        public vec4 zxxy => new vec4(z, x, x, y);
        
        /// <summary>
        /// Returns vec4.brrg swizzling (equivalent to vec4.zxxy).
        /// </summary>
        public vec4 brrg => new vec4(z, x, x, y);
        
        /// <summary>
        /// Returns vec4.zxxyx swizzling.
        /// </summary>
        public vec5 zxxyx => new vec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns vec4.brrgr swizzling (equivalent to vec4.zxxyx).
        /// </summary>
        public vec5 brrgr => new vec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns vec4.zxxyy swizzling.
        /// </summary>
        public vec5 zxxyy => new vec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns vec4.brrgg swizzling (equivalent to vec4.zxxyy).
        /// </summary>
        public vec5 brrgg => new vec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns vec4.zxxyz swizzling.
        /// </summary>
        public vec5 zxxyz => new vec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns vec4.brrgb swizzling (equivalent to vec4.zxxyz).
        /// </summary>
        public vec5 brrgb => new vec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns vec4.zxxyw swizzling.
        /// </summary>
        public vec5 zxxyw => new vec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns vec4.brrga swizzling (equivalent to vec4.zxxyw).
        /// </summary>
        public vec5 brrga => new vec5(z, x, x, y, w);
        
        /// <summary>
        /// Returns vec4.zxxz swizzling.
        /// </summary>
        public vec4 zxxz => new vec4(z, x, x, z);
        
        /// <summary>
        /// Returns vec4.brrb swizzling (equivalent to vec4.zxxz).
        /// </summary>
        public vec4 brrb => new vec4(z, x, x, z);
        
        /// <summary>
        /// Returns vec4.zxxzx swizzling.
        /// </summary>
        public vec5 zxxzx => new vec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns vec4.brrbr swizzling (equivalent to vec4.zxxzx).
        /// </summary>
        public vec5 brrbr => new vec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns vec4.zxxzy swizzling.
        /// </summary>
        public vec5 zxxzy => new vec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns vec4.brrbg swizzling (equivalent to vec4.zxxzy).
        /// </summary>
        public vec5 brrbg => new vec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns vec4.zxxzz swizzling.
        /// </summary>
        public vec5 zxxzz => new vec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns vec4.brrbb swizzling (equivalent to vec4.zxxzz).
        /// </summary>
        public vec5 brrbb => new vec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns vec4.zxxzw swizzling.
        /// </summary>
        public vec5 zxxzw => new vec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns vec4.brrba swizzling (equivalent to vec4.zxxzw).
        /// </summary>
        public vec5 brrba => new vec5(z, x, x, z, w);
        
        /// <summary>
        /// Returns vec4.zxxw swizzling.
        /// </summary>
        public vec4 zxxw => new vec4(z, x, x, w);
        
        /// <summary>
        /// Returns vec4.brra swizzling (equivalent to vec4.zxxw).
        /// </summary>
        public vec4 brra => new vec4(z, x, x, w);
        
        /// <summary>
        /// Returns vec4.zxxwx swizzling.
        /// </summary>
        public vec5 zxxwx => new vec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns vec4.brrar swizzling (equivalent to vec4.zxxwx).
        /// </summary>
        public vec5 brrar => new vec5(z, x, x, w, x);
        
        /// <summary>
        /// Returns vec4.zxxwy swizzling.
        /// </summary>
        public vec5 zxxwy => new vec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns vec4.brrag swizzling (equivalent to vec4.zxxwy).
        /// </summary>
        public vec5 brrag => new vec5(z, x, x, w, y);
        
        /// <summary>
        /// Returns vec4.zxxwz swizzling.
        /// </summary>
        public vec5 zxxwz => new vec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns vec4.brrab swizzling (equivalent to vec4.zxxwz).
        /// </summary>
        public vec5 brrab => new vec5(z, x, x, w, z);
        
        /// <summary>
        /// Returns vec4.zxxww swizzling.
        /// </summary>
        public vec5 zxxww => new vec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns vec4.brraa swizzling (equivalent to vec4.zxxww).
        /// </summary>
        public vec5 brraa => new vec5(z, x, x, w, w);
        
        /// <summary>
        /// Returns vec4.zxy swizzling.
        /// </summary>
        public vec3 zxy => new vec3(z, x, y);
        
        /// <summary>
        /// Returns vec4.brg swizzling (equivalent to vec4.zxy).
        /// </summary>
        public vec3 brg => new vec3(z, x, y);
        
        /// <summary>
        /// Returns vec4.zxyx swizzling.
        /// </summary>
        public vec4 zxyx => new vec4(z, x, y, x);
        
        /// <summary>
        /// Returns vec4.brgr swizzling (equivalent to vec4.zxyx).
        /// </summary>
        public vec4 brgr => new vec4(z, x, y, x);
        
        /// <summary>
        /// Returns vec4.zxyxx swizzling.
        /// </summary>
        public vec5 zxyxx => new vec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns vec4.brgrr swizzling (equivalent to vec4.zxyxx).
        /// </summary>
        public vec5 brgrr => new vec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns vec4.zxyxy swizzling.
        /// </summary>
        public vec5 zxyxy => new vec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns vec4.brgrg swizzling (equivalent to vec4.zxyxy).
        /// </summary>
        public vec5 brgrg => new vec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns vec4.zxyxz swizzling.
        /// </summary>
        public vec5 zxyxz => new vec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns vec4.brgrb swizzling (equivalent to vec4.zxyxz).
        /// </summary>
        public vec5 brgrb => new vec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns vec4.zxyxw swizzling.
        /// </summary>
        public vec5 zxyxw => new vec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns vec4.brgra swizzling (equivalent to vec4.zxyxw).
        /// </summary>
        public vec5 brgra => new vec5(z, x, y, x, w);
        
        /// <summary>
        /// Returns vec4.zxyy swizzling.
        /// </summary>
        public vec4 zxyy => new vec4(z, x, y, y);
        
        /// <summary>
        /// Returns vec4.brgg swizzling (equivalent to vec4.zxyy).
        /// </summary>
        public vec4 brgg => new vec4(z, x, y, y);
        
        /// <summary>
        /// Returns vec4.zxyyx swizzling.
        /// </summary>
        public vec5 zxyyx => new vec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns vec4.brggr swizzling (equivalent to vec4.zxyyx).
        /// </summary>
        public vec5 brggr => new vec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns vec4.zxyyy swizzling.
        /// </summary>
        public vec5 zxyyy => new vec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns vec4.brggg swizzling (equivalent to vec4.zxyyy).
        /// </summary>
        public vec5 brggg => new vec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns vec4.zxyyz swizzling.
        /// </summary>
        public vec5 zxyyz => new vec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns vec4.brggb swizzling (equivalent to vec4.zxyyz).
        /// </summary>
        public vec5 brggb => new vec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns vec4.zxyyw swizzling.
        /// </summary>
        public vec5 zxyyw => new vec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns vec4.brgga swizzling (equivalent to vec4.zxyyw).
        /// </summary>
        public vec5 brgga => new vec5(z, x, y, y, w);
        
        /// <summary>
        /// Returns vec4.zxyz swizzling.
        /// </summary>
        public vec4 zxyz => new vec4(z, x, y, z);
        
        /// <summary>
        /// Returns vec4.brgb swizzling (equivalent to vec4.zxyz).
        /// </summary>
        public vec4 brgb => new vec4(z, x, y, z);
        
        /// <summary>
        /// Returns vec4.zxyzx swizzling.
        /// </summary>
        public vec5 zxyzx => new vec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns vec4.brgbr swizzling (equivalent to vec4.zxyzx).
        /// </summary>
        public vec5 brgbr => new vec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns vec4.zxyzy swizzling.
        /// </summary>
        public vec5 zxyzy => new vec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns vec4.brgbg swizzling (equivalent to vec4.zxyzy).
        /// </summary>
        public vec5 brgbg => new vec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns vec4.zxyzz swizzling.
        /// </summary>
        public vec5 zxyzz => new vec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns vec4.brgbb swizzling (equivalent to vec4.zxyzz).
        /// </summary>
        public vec5 brgbb => new vec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns vec4.zxyzw swizzling.
        /// </summary>
        public vec5 zxyzw => new vec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns vec4.brgba swizzling (equivalent to vec4.zxyzw).
        /// </summary>
        public vec5 brgba => new vec5(z, x, y, z, w);
        
        /// <summary>
        /// Returns vec4.zxyw swizzling.
        /// </summary>
        public vec4 zxyw => new vec4(z, x, y, w);
        
        /// <summary>
        /// Returns vec4.brga swizzling (equivalent to vec4.zxyw).
        /// </summary>
        public vec4 brga => new vec4(z, x, y, w);
        
        /// <summary>
        /// Returns vec4.zxywx swizzling.
        /// </summary>
        public vec5 zxywx => new vec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns vec4.brgar swizzling (equivalent to vec4.zxywx).
        /// </summary>
        public vec5 brgar => new vec5(z, x, y, w, x);
        
        /// <summary>
        /// Returns vec4.zxywy swizzling.
        /// </summary>
        public vec5 zxywy => new vec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns vec4.brgag swizzling (equivalent to vec4.zxywy).
        /// </summary>
        public vec5 brgag => new vec5(z, x, y, w, y);
        
        /// <summary>
        /// Returns vec4.zxywz swizzling.
        /// </summary>
        public vec5 zxywz => new vec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns vec4.brgab swizzling (equivalent to vec4.zxywz).
        /// </summary>
        public vec5 brgab => new vec5(z, x, y, w, z);
        
        /// <summary>
        /// Returns vec4.zxyww swizzling.
        /// </summary>
        public vec5 zxyww => new vec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns vec4.brgaa swizzling (equivalent to vec4.zxyww).
        /// </summary>
        public vec5 brgaa => new vec5(z, x, y, w, w);
        
        /// <summary>
        /// Returns vec4.zxz swizzling.
        /// </summary>
        public vec3 zxz => new vec3(z, x, z);
        
        /// <summary>
        /// Returns vec4.brb swizzling (equivalent to vec4.zxz).
        /// </summary>
        public vec3 brb => new vec3(z, x, z);
        
        /// <summary>
        /// Returns vec4.zxzx swizzling.
        /// </summary>
        public vec4 zxzx => new vec4(z, x, z, x);
        
        /// <summary>
        /// Returns vec4.brbr swizzling (equivalent to vec4.zxzx).
        /// </summary>
        public vec4 brbr => new vec4(z, x, z, x);
        
        /// <summary>
        /// Returns vec4.zxzxx swizzling.
        /// </summary>
        public vec5 zxzxx => new vec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns vec4.brbrr swizzling (equivalent to vec4.zxzxx).
        /// </summary>
        public vec5 brbrr => new vec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns vec4.zxzxy swizzling.
        /// </summary>
        public vec5 zxzxy => new vec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns vec4.brbrg swizzling (equivalent to vec4.zxzxy).
        /// </summary>
        public vec5 brbrg => new vec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns vec4.zxzxz swizzling.
        /// </summary>
        public vec5 zxzxz => new vec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns vec4.brbrb swizzling (equivalent to vec4.zxzxz).
        /// </summary>
        public vec5 brbrb => new vec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns vec4.zxzxw swizzling.
        /// </summary>
        public vec5 zxzxw => new vec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns vec4.brbra swizzling (equivalent to vec4.zxzxw).
        /// </summary>
        public vec5 brbra => new vec5(z, x, z, x, w);
        
        /// <summary>
        /// Returns vec4.zxzy swizzling.
        /// </summary>
        public vec4 zxzy => new vec4(z, x, z, y);
        
        /// <summary>
        /// Returns vec4.brbg swizzling (equivalent to vec4.zxzy).
        /// </summary>
        public vec4 brbg => new vec4(z, x, z, y);
        
        /// <summary>
        /// Returns vec4.zxzyx swizzling.
        /// </summary>
        public vec5 zxzyx => new vec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns vec4.brbgr swizzling (equivalent to vec4.zxzyx).
        /// </summary>
        public vec5 brbgr => new vec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns vec4.zxzyy swizzling.
        /// </summary>
        public vec5 zxzyy => new vec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns vec4.brbgg swizzling (equivalent to vec4.zxzyy).
        /// </summary>
        public vec5 brbgg => new vec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns vec4.zxzyz swizzling.
        /// </summary>
        public vec5 zxzyz => new vec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns vec4.brbgb swizzling (equivalent to vec4.zxzyz).
        /// </summary>
        public vec5 brbgb => new vec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns vec4.zxzyw swizzling.
        /// </summary>
        public vec5 zxzyw => new vec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns vec4.brbga swizzling (equivalent to vec4.zxzyw).
        /// </summary>
        public vec5 brbga => new vec5(z, x, z, y, w);
        
        /// <summary>
        /// Returns vec4.zxzz swizzling.
        /// </summary>
        public vec4 zxzz => new vec4(z, x, z, z);
        
        /// <summary>
        /// Returns vec4.brbb swizzling (equivalent to vec4.zxzz).
        /// </summary>
        public vec4 brbb => new vec4(z, x, z, z);
        
        /// <summary>
        /// Returns vec4.zxzzx swizzling.
        /// </summary>
        public vec5 zxzzx => new vec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns vec4.brbbr swizzling (equivalent to vec4.zxzzx).
        /// </summary>
        public vec5 brbbr => new vec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns vec4.zxzzy swizzling.
        /// </summary>
        public vec5 zxzzy => new vec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns vec4.brbbg swizzling (equivalent to vec4.zxzzy).
        /// </summary>
        public vec5 brbbg => new vec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns vec4.zxzzz swizzling.
        /// </summary>
        public vec5 zxzzz => new vec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns vec4.brbbb swizzling (equivalent to vec4.zxzzz).
        /// </summary>
        public vec5 brbbb => new vec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns vec4.zxzzw swizzling.
        /// </summary>
        public vec5 zxzzw => new vec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns vec4.brbba swizzling (equivalent to vec4.zxzzw).
        /// </summary>
        public vec5 brbba => new vec5(z, x, z, z, w);
        
        /// <summary>
        /// Returns vec4.zxzw swizzling.
        /// </summary>
        public vec4 zxzw => new vec4(z, x, z, w);
        
        /// <summary>
        /// Returns vec4.brba swizzling (equivalent to vec4.zxzw).
        /// </summary>
        public vec4 brba => new vec4(z, x, z, w);
        
        /// <summary>
        /// Returns vec4.zxzwx swizzling.
        /// </summary>
        public vec5 zxzwx => new vec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns vec4.brbar swizzling (equivalent to vec4.zxzwx).
        /// </summary>
        public vec5 brbar => new vec5(z, x, z, w, x);
        
        /// <summary>
        /// Returns vec4.zxzwy swizzling.
        /// </summary>
        public vec5 zxzwy => new vec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns vec4.brbag swizzling (equivalent to vec4.zxzwy).
        /// </summary>
        public vec5 brbag => new vec5(z, x, z, w, y);
        
        /// <summary>
        /// Returns vec4.zxzwz swizzling.
        /// </summary>
        public vec5 zxzwz => new vec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns vec4.brbab swizzling (equivalent to vec4.zxzwz).
        /// </summary>
        public vec5 brbab => new vec5(z, x, z, w, z);
        
        /// <summary>
        /// Returns vec4.zxzww swizzling.
        /// </summary>
        public vec5 zxzww => new vec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns vec4.brbaa swizzling (equivalent to vec4.zxzww).
        /// </summary>
        public vec5 brbaa => new vec5(z, x, z, w, w);
        
        /// <summary>
        /// Returns vec4.zxw swizzling.
        /// </summary>
        public vec3 zxw => new vec3(z, x, w);
        
        /// <summary>
        /// Returns vec4.bra swizzling (equivalent to vec4.zxw).
        /// </summary>
        public vec3 bra => new vec3(z, x, w);
        
        /// <summary>
        /// Returns vec4.zxwx swizzling.
        /// </summary>
        public vec4 zxwx => new vec4(z, x, w, x);
        
        /// <summary>
        /// Returns vec4.brar swizzling (equivalent to vec4.zxwx).
        /// </summary>
        public vec4 brar => new vec4(z, x, w, x);
        
        /// <summary>
        /// Returns vec4.zxwxx swizzling.
        /// </summary>
        public vec5 zxwxx => new vec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns vec4.brarr swizzling (equivalent to vec4.zxwxx).
        /// </summary>
        public vec5 brarr => new vec5(z, x, w, x, x);
        
        /// <summary>
        /// Returns vec4.zxwxy swizzling.
        /// </summary>
        public vec5 zxwxy => new vec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns vec4.brarg swizzling (equivalent to vec4.zxwxy).
        /// </summary>
        public vec5 brarg => new vec5(z, x, w, x, y);
        
        /// <summary>
        /// Returns vec4.zxwxz swizzling.
        /// </summary>
        public vec5 zxwxz => new vec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns vec4.brarb swizzling (equivalent to vec4.zxwxz).
        /// </summary>
        public vec5 brarb => new vec5(z, x, w, x, z);
        
        /// <summary>
        /// Returns vec4.zxwxw swizzling.
        /// </summary>
        public vec5 zxwxw => new vec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns vec4.brara swizzling (equivalent to vec4.zxwxw).
        /// </summary>
        public vec5 brara => new vec5(z, x, w, x, w);
        
        /// <summary>
        /// Returns vec4.zxwy swizzling.
        /// </summary>
        public vec4 zxwy => new vec4(z, x, w, y);
        
        /// <summary>
        /// Returns vec4.brag swizzling (equivalent to vec4.zxwy).
        /// </summary>
        public vec4 brag => new vec4(z, x, w, y);
        
        /// <summary>
        /// Returns vec4.zxwyx swizzling.
        /// </summary>
        public vec5 zxwyx => new vec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns vec4.bragr swizzling (equivalent to vec4.zxwyx).
        /// </summary>
        public vec5 bragr => new vec5(z, x, w, y, x);
        
        /// <summary>
        /// Returns vec4.zxwyy swizzling.
        /// </summary>
        public vec5 zxwyy => new vec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns vec4.bragg swizzling (equivalent to vec4.zxwyy).
        /// </summary>
        public vec5 bragg => new vec5(z, x, w, y, y);
        
        /// <summary>
        /// Returns vec4.zxwyz swizzling.
        /// </summary>
        public vec5 zxwyz => new vec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns vec4.bragb swizzling (equivalent to vec4.zxwyz).
        /// </summary>
        public vec5 bragb => new vec5(z, x, w, y, z);
        
        /// <summary>
        /// Returns vec4.zxwyw swizzling.
        /// </summary>
        public vec5 zxwyw => new vec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns vec4.braga swizzling (equivalent to vec4.zxwyw).
        /// </summary>
        public vec5 braga => new vec5(z, x, w, y, w);
        
        /// <summary>
        /// Returns vec4.zxwz swizzling.
        /// </summary>
        public vec4 zxwz => new vec4(z, x, w, z);
        
        /// <summary>
        /// Returns vec4.brab swizzling (equivalent to vec4.zxwz).
        /// </summary>
        public vec4 brab => new vec4(z, x, w, z);
        
        /// <summary>
        /// Returns vec4.zxwzx swizzling.
        /// </summary>
        public vec5 zxwzx => new vec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns vec4.brabr swizzling (equivalent to vec4.zxwzx).
        /// </summary>
        public vec5 brabr => new vec5(z, x, w, z, x);
        
        /// <summary>
        /// Returns vec4.zxwzy swizzling.
        /// </summary>
        public vec5 zxwzy => new vec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns vec4.brabg swizzling (equivalent to vec4.zxwzy).
        /// </summary>
        public vec5 brabg => new vec5(z, x, w, z, y);
        
        /// <summary>
        /// Returns vec4.zxwzz swizzling.
        /// </summary>
        public vec5 zxwzz => new vec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns vec4.brabb swizzling (equivalent to vec4.zxwzz).
        /// </summary>
        public vec5 brabb => new vec5(z, x, w, z, z);
        
        /// <summary>
        /// Returns vec4.zxwzw swizzling.
        /// </summary>
        public vec5 zxwzw => new vec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns vec4.braba swizzling (equivalent to vec4.zxwzw).
        /// </summary>
        public vec5 braba => new vec5(z, x, w, z, w);
        
        /// <summary>
        /// Returns vec4.zxww swizzling.
        /// </summary>
        public vec4 zxww => new vec4(z, x, w, w);
        
        /// <summary>
        /// Returns vec4.braa swizzling (equivalent to vec4.zxww).
        /// </summary>
        public vec4 braa => new vec4(z, x, w, w);
        
        /// <summary>
        /// Returns vec4.zxwwx swizzling.
        /// </summary>
        public vec5 zxwwx => new vec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns vec4.braar swizzling (equivalent to vec4.zxwwx).
        /// </summary>
        public vec5 braar => new vec5(z, x, w, w, x);
        
        /// <summary>
        /// Returns vec4.zxwwy swizzling.
        /// </summary>
        public vec5 zxwwy => new vec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns vec4.braag swizzling (equivalent to vec4.zxwwy).
        /// </summary>
        public vec5 braag => new vec5(z, x, w, w, y);
        
        /// <summary>
        /// Returns vec4.zxwwz swizzling.
        /// </summary>
        public vec5 zxwwz => new vec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns vec4.braab swizzling (equivalent to vec4.zxwwz).
        /// </summary>
        public vec5 braab => new vec5(z, x, w, w, z);
        
        /// <summary>
        /// Returns vec4.zxwww swizzling.
        /// </summary>
        public vec5 zxwww => new vec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns vec4.braaa swizzling (equivalent to vec4.zxwww).
        /// </summary>
        public vec5 braaa => new vec5(z, x, w, w, w);
        
        /// <summary>
        /// Returns vec4.zy swizzling.
        /// </summary>
        public vec2 zy => new vec2(z, y);
        
        /// <summary>
        /// Returns vec4.bg swizzling (equivalent to vec4.zy).
        /// </summary>
        public vec2 bg => new vec2(z, y);
        
        /// <summary>
        /// Returns vec4.zyx swizzling.
        /// </summary>
        public vec3 zyx => new vec3(z, y, x);
        
        /// <summary>
        /// Returns vec4.bgr swizzling (equivalent to vec4.zyx).
        /// </summary>
        public vec3 bgr => new vec3(z, y, x);
        
        /// <summary>
        /// Returns vec4.zyxx swizzling.
        /// </summary>
        public vec4 zyxx => new vec4(z, y, x, x);
        
        /// <summary>
        /// Returns vec4.bgrr swizzling (equivalent to vec4.zyxx).
        /// </summary>
        public vec4 bgrr => new vec4(z, y, x, x);
        
        /// <summary>
        /// Returns vec4.zyxxx swizzling.
        /// </summary>
        public vec5 zyxxx => new vec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns vec4.bgrrr swizzling (equivalent to vec4.zyxxx).
        /// </summary>
        public vec5 bgrrr => new vec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns vec4.zyxxy swizzling.
        /// </summary>
        public vec5 zyxxy => new vec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns vec4.bgrrg swizzling (equivalent to vec4.zyxxy).
        /// </summary>
        public vec5 bgrrg => new vec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns vec4.zyxxz swizzling.
        /// </summary>
        public vec5 zyxxz => new vec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns vec4.bgrrb swizzling (equivalent to vec4.zyxxz).
        /// </summary>
        public vec5 bgrrb => new vec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns vec4.zyxxw swizzling.
        /// </summary>
        public vec5 zyxxw => new vec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns vec4.bgrra swizzling (equivalent to vec4.zyxxw).
        /// </summary>
        public vec5 bgrra => new vec5(z, y, x, x, w);
        
        /// <summary>
        /// Returns vec4.zyxy swizzling.
        /// </summary>
        public vec4 zyxy => new vec4(z, y, x, y);
        
        /// <summary>
        /// Returns vec4.bgrg swizzling (equivalent to vec4.zyxy).
        /// </summary>
        public vec4 bgrg => new vec4(z, y, x, y);
        
        /// <summary>
        /// Returns vec4.zyxyx swizzling.
        /// </summary>
        public vec5 zyxyx => new vec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns vec4.bgrgr swizzling (equivalent to vec4.zyxyx).
        /// </summary>
        public vec5 bgrgr => new vec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns vec4.zyxyy swizzling.
        /// </summary>
        public vec5 zyxyy => new vec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns vec4.bgrgg swizzling (equivalent to vec4.zyxyy).
        /// </summary>
        public vec5 bgrgg => new vec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns vec4.zyxyz swizzling.
        /// </summary>
        public vec5 zyxyz => new vec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns vec4.bgrgb swizzling (equivalent to vec4.zyxyz).
        /// </summary>
        public vec5 bgrgb => new vec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns vec4.zyxyw swizzling.
        /// </summary>
        public vec5 zyxyw => new vec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns vec4.bgrga swizzling (equivalent to vec4.zyxyw).
        /// </summary>
        public vec5 bgrga => new vec5(z, y, x, y, w);
        
        /// <summary>
        /// Returns vec4.zyxz swizzling.
        /// </summary>
        public vec4 zyxz => new vec4(z, y, x, z);
        
        /// <summary>
        /// Returns vec4.bgrb swizzling (equivalent to vec4.zyxz).
        /// </summary>
        public vec4 bgrb => new vec4(z, y, x, z);
        
        /// <summary>
        /// Returns vec4.zyxzx swizzling.
        /// </summary>
        public vec5 zyxzx => new vec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns vec4.bgrbr swizzling (equivalent to vec4.zyxzx).
        /// </summary>
        public vec5 bgrbr => new vec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns vec4.zyxzy swizzling.
        /// </summary>
        public vec5 zyxzy => new vec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns vec4.bgrbg swizzling (equivalent to vec4.zyxzy).
        /// </summary>
        public vec5 bgrbg => new vec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns vec4.zyxzz swizzling.
        /// </summary>
        public vec5 zyxzz => new vec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns vec4.bgrbb swizzling (equivalent to vec4.zyxzz).
        /// </summary>
        public vec5 bgrbb => new vec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns vec4.zyxzw swizzling.
        /// </summary>
        public vec5 zyxzw => new vec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns vec4.bgrba swizzling (equivalent to vec4.zyxzw).
        /// </summary>
        public vec5 bgrba => new vec5(z, y, x, z, w);
        
        /// <summary>
        /// Returns vec4.zyxw swizzling.
        /// </summary>
        public vec4 zyxw => new vec4(z, y, x, w);
        
        /// <summary>
        /// Returns vec4.bgra swizzling (equivalent to vec4.zyxw).
        /// </summary>
        public vec4 bgra => new vec4(z, y, x, w);
        
        /// <summary>
        /// Returns vec4.zyxwx swizzling.
        /// </summary>
        public vec5 zyxwx => new vec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns vec4.bgrar swizzling (equivalent to vec4.zyxwx).
        /// </summary>
        public vec5 bgrar => new vec5(z, y, x, w, x);
        
        /// <summary>
        /// Returns vec4.zyxwy swizzling.
        /// </summary>
        public vec5 zyxwy => new vec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns vec4.bgrag swizzling (equivalent to vec4.zyxwy).
        /// </summary>
        public vec5 bgrag => new vec5(z, y, x, w, y);
        
        /// <summary>
        /// Returns vec4.zyxwz swizzling.
        /// </summary>
        public vec5 zyxwz => new vec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns vec4.bgrab swizzling (equivalent to vec4.zyxwz).
        /// </summary>
        public vec5 bgrab => new vec5(z, y, x, w, z);
        
        /// <summary>
        /// Returns vec4.zyxww swizzling.
        /// </summary>
        public vec5 zyxww => new vec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns vec4.bgraa swizzling (equivalent to vec4.zyxww).
        /// </summary>
        public vec5 bgraa => new vec5(z, y, x, w, w);
        
        /// <summary>
        /// Returns vec4.zyy swizzling.
        /// </summary>
        public vec3 zyy => new vec3(z, y, y);
        
        /// <summary>
        /// Returns vec4.bgg swizzling (equivalent to vec4.zyy).
        /// </summary>
        public vec3 bgg => new vec3(z, y, y);
        
        /// <summary>
        /// Returns vec4.zyyx swizzling.
        /// </summary>
        public vec4 zyyx => new vec4(z, y, y, x);
        
        /// <summary>
        /// Returns vec4.bggr swizzling (equivalent to vec4.zyyx).
        /// </summary>
        public vec4 bggr => new vec4(z, y, y, x);
        
        /// <summary>
        /// Returns vec4.zyyxx swizzling.
        /// </summary>
        public vec5 zyyxx => new vec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns vec4.bggrr swizzling (equivalent to vec4.zyyxx).
        /// </summary>
        public vec5 bggrr => new vec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns vec4.zyyxy swizzling.
        /// </summary>
        public vec5 zyyxy => new vec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns vec4.bggrg swizzling (equivalent to vec4.zyyxy).
        /// </summary>
        public vec5 bggrg => new vec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns vec4.zyyxz swizzling.
        /// </summary>
        public vec5 zyyxz => new vec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns vec4.bggrb swizzling (equivalent to vec4.zyyxz).
        /// </summary>
        public vec5 bggrb => new vec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns vec4.zyyxw swizzling.
        /// </summary>
        public vec5 zyyxw => new vec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns vec4.bggra swizzling (equivalent to vec4.zyyxw).
        /// </summary>
        public vec5 bggra => new vec5(z, y, y, x, w);
        
        /// <summary>
        /// Returns vec4.zyyy swizzling.
        /// </summary>
        public vec4 zyyy => new vec4(z, y, y, y);
        
        /// <summary>
        /// Returns vec4.bggg swizzling (equivalent to vec4.zyyy).
        /// </summary>
        public vec4 bggg => new vec4(z, y, y, y);
        
        /// <summary>
        /// Returns vec4.zyyyx swizzling.
        /// </summary>
        public vec5 zyyyx => new vec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns vec4.bgggr swizzling (equivalent to vec4.zyyyx).
        /// </summary>
        public vec5 bgggr => new vec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns vec4.zyyyy swizzling.
        /// </summary>
        public vec5 zyyyy => new vec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns vec4.bgggg swizzling (equivalent to vec4.zyyyy).
        /// </summary>
        public vec5 bgggg => new vec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns vec4.zyyyz swizzling.
        /// </summary>
        public vec5 zyyyz => new vec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns vec4.bgggb swizzling (equivalent to vec4.zyyyz).
        /// </summary>
        public vec5 bgggb => new vec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns vec4.zyyyw swizzling.
        /// </summary>
        public vec5 zyyyw => new vec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns vec4.bggga swizzling (equivalent to vec4.zyyyw).
        /// </summary>
        public vec5 bggga => new vec5(z, y, y, y, w);
        
        /// <summary>
        /// Returns vec4.zyyz swizzling.
        /// </summary>
        public vec4 zyyz => new vec4(z, y, y, z);
        
        /// <summary>
        /// Returns vec4.bggb swizzling (equivalent to vec4.zyyz).
        /// </summary>
        public vec4 bggb => new vec4(z, y, y, z);
        
        /// <summary>
        /// Returns vec4.zyyzx swizzling.
        /// </summary>
        public vec5 zyyzx => new vec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns vec4.bggbr swizzling (equivalent to vec4.zyyzx).
        /// </summary>
        public vec5 bggbr => new vec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns vec4.zyyzy swizzling.
        /// </summary>
        public vec5 zyyzy => new vec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns vec4.bggbg swizzling (equivalent to vec4.zyyzy).
        /// </summary>
        public vec5 bggbg => new vec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns vec4.zyyzz swizzling.
        /// </summary>
        public vec5 zyyzz => new vec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns vec4.bggbb swizzling (equivalent to vec4.zyyzz).
        /// </summary>
        public vec5 bggbb => new vec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns vec4.zyyzw swizzling.
        /// </summary>
        public vec5 zyyzw => new vec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns vec4.bggba swizzling (equivalent to vec4.zyyzw).
        /// </summary>
        public vec5 bggba => new vec5(z, y, y, z, w);
        
        /// <summary>
        /// Returns vec4.zyyw swizzling.
        /// </summary>
        public vec4 zyyw => new vec4(z, y, y, w);
        
        /// <summary>
        /// Returns vec4.bgga swizzling (equivalent to vec4.zyyw).
        /// </summary>
        public vec4 bgga => new vec4(z, y, y, w);
        
        /// <summary>
        /// Returns vec4.zyywx swizzling.
        /// </summary>
        public vec5 zyywx => new vec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns vec4.bggar swizzling (equivalent to vec4.zyywx).
        /// </summary>
        public vec5 bggar => new vec5(z, y, y, w, x);
        
        /// <summary>
        /// Returns vec4.zyywy swizzling.
        /// </summary>
        public vec5 zyywy => new vec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns vec4.bggag swizzling (equivalent to vec4.zyywy).
        /// </summary>
        public vec5 bggag => new vec5(z, y, y, w, y);
        
        /// <summary>
        /// Returns vec4.zyywz swizzling.
        /// </summary>
        public vec5 zyywz => new vec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns vec4.bggab swizzling (equivalent to vec4.zyywz).
        /// </summary>
        public vec5 bggab => new vec5(z, y, y, w, z);
        
        /// <summary>
        /// Returns vec4.zyyww swizzling.
        /// </summary>
        public vec5 zyyww => new vec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns vec4.bggaa swizzling (equivalent to vec4.zyyww).
        /// </summary>
        public vec5 bggaa => new vec5(z, y, y, w, w);
        
        /// <summary>
        /// Returns vec4.zyz swizzling.
        /// </summary>
        public vec3 zyz => new vec3(z, y, z);
        
        /// <summary>
        /// Returns vec4.bgb swizzling (equivalent to vec4.zyz).
        /// </summary>
        public vec3 bgb => new vec3(z, y, z);
        
        /// <summary>
        /// Returns vec4.zyzx swizzling.
        /// </summary>
        public vec4 zyzx => new vec4(z, y, z, x);
        
        /// <summary>
        /// Returns vec4.bgbr swizzling (equivalent to vec4.zyzx).
        /// </summary>
        public vec4 bgbr => new vec4(z, y, z, x);
        
        /// <summary>
        /// Returns vec4.zyzxx swizzling.
        /// </summary>
        public vec5 zyzxx => new vec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns vec4.bgbrr swizzling (equivalent to vec4.zyzxx).
        /// </summary>
        public vec5 bgbrr => new vec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns vec4.zyzxy swizzling.
        /// </summary>
        public vec5 zyzxy => new vec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns vec4.bgbrg swizzling (equivalent to vec4.zyzxy).
        /// </summary>
        public vec5 bgbrg => new vec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns vec4.zyzxz swizzling.
        /// </summary>
        public vec5 zyzxz => new vec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns vec4.bgbrb swizzling (equivalent to vec4.zyzxz).
        /// </summary>
        public vec5 bgbrb => new vec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns vec4.zyzxw swizzling.
        /// </summary>
        public vec5 zyzxw => new vec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns vec4.bgbra swizzling (equivalent to vec4.zyzxw).
        /// </summary>
        public vec5 bgbra => new vec5(z, y, z, x, w);
        
        /// <summary>
        /// Returns vec4.zyzy swizzling.
        /// </summary>
        public vec4 zyzy => new vec4(z, y, z, y);
        
        /// <summary>
        /// Returns vec4.bgbg swizzling (equivalent to vec4.zyzy).
        /// </summary>
        public vec4 bgbg => new vec4(z, y, z, y);
        
        /// <summary>
        /// Returns vec4.zyzyx swizzling.
        /// </summary>
        public vec5 zyzyx => new vec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns vec4.bgbgr swizzling (equivalent to vec4.zyzyx).
        /// </summary>
        public vec5 bgbgr => new vec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns vec4.zyzyy swizzling.
        /// </summary>
        public vec5 zyzyy => new vec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns vec4.bgbgg swizzling (equivalent to vec4.zyzyy).
        /// </summary>
        public vec5 bgbgg => new vec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns vec4.zyzyz swizzling.
        /// </summary>
        public vec5 zyzyz => new vec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns vec4.bgbgb swizzling (equivalent to vec4.zyzyz).
        /// </summary>
        public vec5 bgbgb => new vec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns vec4.zyzyw swizzling.
        /// </summary>
        public vec5 zyzyw => new vec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns vec4.bgbga swizzling (equivalent to vec4.zyzyw).
        /// </summary>
        public vec5 bgbga => new vec5(z, y, z, y, w);
        
        /// <summary>
        /// Returns vec4.zyzz swizzling.
        /// </summary>
        public vec4 zyzz => new vec4(z, y, z, z);
        
        /// <summary>
        /// Returns vec4.bgbb swizzling (equivalent to vec4.zyzz).
        /// </summary>
        public vec4 bgbb => new vec4(z, y, z, z);
        
        /// <summary>
        /// Returns vec4.zyzzx swizzling.
        /// </summary>
        public vec5 zyzzx => new vec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns vec4.bgbbr swizzling (equivalent to vec4.zyzzx).
        /// </summary>
        public vec5 bgbbr => new vec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns vec4.zyzzy swizzling.
        /// </summary>
        public vec5 zyzzy => new vec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns vec4.bgbbg swizzling (equivalent to vec4.zyzzy).
        /// </summary>
        public vec5 bgbbg => new vec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns vec4.zyzzz swizzling.
        /// </summary>
        public vec5 zyzzz => new vec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns vec4.bgbbb swizzling (equivalent to vec4.zyzzz).
        /// </summary>
        public vec5 bgbbb => new vec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns vec4.zyzzw swizzling.
        /// </summary>
        public vec5 zyzzw => new vec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns vec4.bgbba swizzling (equivalent to vec4.zyzzw).
        /// </summary>
        public vec5 bgbba => new vec5(z, y, z, z, w);
        
        /// <summary>
        /// Returns vec4.zyzw swizzling.
        /// </summary>
        public vec4 zyzw => new vec4(z, y, z, w);
        
        /// <summary>
        /// Returns vec4.bgba swizzling (equivalent to vec4.zyzw).
        /// </summary>
        public vec4 bgba => new vec4(z, y, z, w);
        
        /// <summary>
        /// Returns vec4.zyzwx swizzling.
        /// </summary>
        public vec5 zyzwx => new vec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns vec4.bgbar swizzling (equivalent to vec4.zyzwx).
        /// </summary>
        public vec5 bgbar => new vec5(z, y, z, w, x);
        
        /// <summary>
        /// Returns vec4.zyzwy swizzling.
        /// </summary>
        public vec5 zyzwy => new vec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns vec4.bgbag swizzling (equivalent to vec4.zyzwy).
        /// </summary>
        public vec5 bgbag => new vec5(z, y, z, w, y);
        
        /// <summary>
        /// Returns vec4.zyzwz swizzling.
        /// </summary>
        public vec5 zyzwz => new vec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns vec4.bgbab swizzling (equivalent to vec4.zyzwz).
        /// </summary>
        public vec5 bgbab => new vec5(z, y, z, w, z);
        
        /// <summary>
        /// Returns vec4.zyzww swizzling.
        /// </summary>
        public vec5 zyzww => new vec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns vec4.bgbaa swizzling (equivalent to vec4.zyzww).
        /// </summary>
        public vec5 bgbaa => new vec5(z, y, z, w, w);
        
        /// <summary>
        /// Returns vec4.zyw swizzling.
        /// </summary>
        public vec3 zyw => new vec3(z, y, w);
        
        /// <summary>
        /// Returns vec4.bga swizzling (equivalent to vec4.zyw).
        /// </summary>
        public vec3 bga => new vec3(z, y, w);
        
        /// <summary>
        /// Returns vec4.zywx swizzling.
        /// </summary>
        public vec4 zywx => new vec4(z, y, w, x);
        
        /// <summary>
        /// Returns vec4.bgar swizzling (equivalent to vec4.zywx).
        /// </summary>
        public vec4 bgar => new vec4(z, y, w, x);
        
        /// <summary>
        /// Returns vec4.zywxx swizzling.
        /// </summary>
        public vec5 zywxx => new vec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns vec4.bgarr swizzling (equivalent to vec4.zywxx).
        /// </summary>
        public vec5 bgarr => new vec5(z, y, w, x, x);
        
        /// <summary>
        /// Returns vec4.zywxy swizzling.
        /// </summary>
        public vec5 zywxy => new vec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns vec4.bgarg swizzling (equivalent to vec4.zywxy).
        /// </summary>
        public vec5 bgarg => new vec5(z, y, w, x, y);
        
        /// <summary>
        /// Returns vec4.zywxz swizzling.
        /// </summary>
        public vec5 zywxz => new vec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns vec4.bgarb swizzling (equivalent to vec4.zywxz).
        /// </summary>
        public vec5 bgarb => new vec5(z, y, w, x, z);
        
        /// <summary>
        /// Returns vec4.zywxw swizzling.
        /// </summary>
        public vec5 zywxw => new vec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns vec4.bgara swizzling (equivalent to vec4.zywxw).
        /// </summary>
        public vec5 bgara => new vec5(z, y, w, x, w);
        
        /// <summary>
        /// Returns vec4.zywy swizzling.
        /// </summary>
        public vec4 zywy => new vec4(z, y, w, y);
        
        /// <summary>
        /// Returns vec4.bgag swizzling (equivalent to vec4.zywy).
        /// </summary>
        public vec4 bgag => new vec4(z, y, w, y);
        
        /// <summary>
        /// Returns vec4.zywyx swizzling.
        /// </summary>
        public vec5 zywyx => new vec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns vec4.bgagr swizzling (equivalent to vec4.zywyx).
        /// </summary>
        public vec5 bgagr => new vec5(z, y, w, y, x);
        
        /// <summary>
        /// Returns vec4.zywyy swizzling.
        /// </summary>
        public vec5 zywyy => new vec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns vec4.bgagg swizzling (equivalent to vec4.zywyy).
        /// </summary>
        public vec5 bgagg => new vec5(z, y, w, y, y);
        
        /// <summary>
        /// Returns vec4.zywyz swizzling.
        /// </summary>
        public vec5 zywyz => new vec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns vec4.bgagb swizzling (equivalent to vec4.zywyz).
        /// </summary>
        public vec5 bgagb => new vec5(z, y, w, y, z);
        
        /// <summary>
        /// Returns vec4.zywyw swizzling.
        /// </summary>
        public vec5 zywyw => new vec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns vec4.bgaga swizzling (equivalent to vec4.zywyw).
        /// </summary>
        public vec5 bgaga => new vec5(z, y, w, y, w);
        
        /// <summary>
        /// Returns vec4.zywz swizzling.
        /// </summary>
        public vec4 zywz => new vec4(z, y, w, z);
        
        /// <summary>
        /// Returns vec4.bgab swizzling (equivalent to vec4.zywz).
        /// </summary>
        public vec4 bgab => new vec4(z, y, w, z);
        
        /// <summary>
        /// Returns vec4.zywzx swizzling.
        /// </summary>
        public vec5 zywzx => new vec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns vec4.bgabr swizzling (equivalent to vec4.zywzx).
        /// </summary>
        public vec5 bgabr => new vec5(z, y, w, z, x);
        
        /// <summary>
        /// Returns vec4.zywzy swizzling.
        /// </summary>
        public vec5 zywzy => new vec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns vec4.bgabg swizzling (equivalent to vec4.zywzy).
        /// </summary>
        public vec5 bgabg => new vec5(z, y, w, z, y);
        
        /// <summary>
        /// Returns vec4.zywzz swizzling.
        /// </summary>
        public vec5 zywzz => new vec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns vec4.bgabb swizzling (equivalent to vec4.zywzz).
        /// </summary>
        public vec5 bgabb => new vec5(z, y, w, z, z);
        
        /// <summary>
        /// Returns vec4.zywzw swizzling.
        /// </summary>
        public vec5 zywzw => new vec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns vec4.bgaba swizzling (equivalent to vec4.zywzw).
        /// </summary>
        public vec5 bgaba => new vec5(z, y, w, z, w);
        
        /// <summary>
        /// Returns vec4.zyww swizzling.
        /// </summary>
        public vec4 zyww => new vec4(z, y, w, w);
        
        /// <summary>
        /// Returns vec4.bgaa swizzling (equivalent to vec4.zyww).
        /// </summary>
        public vec4 bgaa => new vec4(z, y, w, w);
        
        /// <summary>
        /// Returns vec4.zywwx swizzling.
        /// </summary>
        public vec5 zywwx => new vec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns vec4.bgaar swizzling (equivalent to vec4.zywwx).
        /// </summary>
        public vec5 bgaar => new vec5(z, y, w, w, x);
        
        /// <summary>
        /// Returns vec4.zywwy swizzling.
        /// </summary>
        public vec5 zywwy => new vec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns vec4.bgaag swizzling (equivalent to vec4.zywwy).
        /// </summary>
        public vec5 bgaag => new vec5(z, y, w, w, y);
        
        /// <summary>
        /// Returns vec4.zywwz swizzling.
        /// </summary>
        public vec5 zywwz => new vec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns vec4.bgaab swizzling (equivalent to vec4.zywwz).
        /// </summary>
        public vec5 bgaab => new vec5(z, y, w, w, z);
        
        /// <summary>
        /// Returns vec4.zywww swizzling.
        /// </summary>
        public vec5 zywww => new vec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns vec4.bgaaa swizzling (equivalent to vec4.zywww).
        /// </summary>
        public vec5 bgaaa => new vec5(z, y, w, w, w);
        
        /// <summary>
        /// Returns vec4.zz swizzling.
        /// </summary>
        public vec2 zz => new vec2(z, z);
        
        /// <summary>
        /// Returns vec4.bb swizzling (equivalent to vec4.zz).
        /// </summary>
        public vec2 bb => new vec2(z, z);
        
        /// <summary>
        /// Returns vec4.zzx swizzling.
        /// </summary>
        public vec3 zzx => new vec3(z, z, x);
        
        /// <summary>
        /// Returns vec4.bbr swizzling (equivalent to vec4.zzx).
        /// </summary>
        public vec3 bbr => new vec3(z, z, x);
        
        /// <summary>
        /// Returns vec4.zzxx swizzling.
        /// </summary>
        public vec4 zzxx => new vec4(z, z, x, x);
        
        /// <summary>
        /// Returns vec4.bbrr swizzling (equivalent to vec4.zzxx).
        /// </summary>
        public vec4 bbrr => new vec4(z, z, x, x);
        
        /// <summary>
        /// Returns vec4.zzxxx swizzling.
        /// </summary>
        public vec5 zzxxx => new vec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns vec4.bbrrr swizzling (equivalent to vec4.zzxxx).
        /// </summary>
        public vec5 bbrrr => new vec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns vec4.zzxxy swizzling.
        /// </summary>
        public vec5 zzxxy => new vec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns vec4.bbrrg swizzling (equivalent to vec4.zzxxy).
        /// </summary>
        public vec5 bbrrg => new vec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns vec4.zzxxz swizzling.
        /// </summary>
        public vec5 zzxxz => new vec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns vec4.bbrrb swizzling (equivalent to vec4.zzxxz).
        /// </summary>
        public vec5 bbrrb => new vec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns vec4.zzxxw swizzling.
        /// </summary>
        public vec5 zzxxw => new vec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns vec4.bbrra swizzling (equivalent to vec4.zzxxw).
        /// </summary>
        public vec5 bbrra => new vec5(z, z, x, x, w);
        
        /// <summary>
        /// Returns vec4.zzxy swizzling.
        /// </summary>
        public vec4 zzxy => new vec4(z, z, x, y);
        
        /// <summary>
        /// Returns vec4.bbrg swizzling (equivalent to vec4.zzxy).
        /// </summary>
        public vec4 bbrg => new vec4(z, z, x, y);
        
        /// <summary>
        /// Returns vec4.zzxyx swizzling.
        /// </summary>
        public vec5 zzxyx => new vec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns vec4.bbrgr swizzling (equivalent to vec4.zzxyx).
        /// </summary>
        public vec5 bbrgr => new vec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns vec4.zzxyy swizzling.
        /// </summary>
        public vec5 zzxyy => new vec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns vec4.bbrgg swizzling (equivalent to vec4.zzxyy).
        /// </summary>
        public vec5 bbrgg => new vec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns vec4.zzxyz swizzling.
        /// </summary>
        public vec5 zzxyz => new vec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns vec4.bbrgb swizzling (equivalent to vec4.zzxyz).
        /// </summary>
        public vec5 bbrgb => new vec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns vec4.zzxyw swizzling.
        /// </summary>
        public vec5 zzxyw => new vec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns vec4.bbrga swizzling (equivalent to vec4.zzxyw).
        /// </summary>
        public vec5 bbrga => new vec5(z, z, x, y, w);
        
        /// <summary>
        /// Returns vec4.zzxz swizzling.
        /// </summary>
        public vec4 zzxz => new vec4(z, z, x, z);
        
        /// <summary>
        /// Returns vec4.bbrb swizzling (equivalent to vec4.zzxz).
        /// </summary>
        public vec4 bbrb => new vec4(z, z, x, z);
        
        /// <summary>
        /// Returns vec4.zzxzx swizzling.
        /// </summary>
        public vec5 zzxzx => new vec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns vec4.bbrbr swizzling (equivalent to vec4.zzxzx).
        /// </summary>
        public vec5 bbrbr => new vec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns vec4.zzxzy swizzling.
        /// </summary>
        public vec5 zzxzy => new vec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns vec4.bbrbg swizzling (equivalent to vec4.zzxzy).
        /// </summary>
        public vec5 bbrbg => new vec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns vec4.zzxzz swizzling.
        /// </summary>
        public vec5 zzxzz => new vec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns vec4.bbrbb swizzling (equivalent to vec4.zzxzz).
        /// </summary>
        public vec5 bbrbb => new vec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns vec4.zzxzw swizzling.
        /// </summary>
        public vec5 zzxzw => new vec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns vec4.bbrba swizzling (equivalent to vec4.zzxzw).
        /// </summary>
        public vec5 bbrba => new vec5(z, z, x, z, w);
        
        /// <summary>
        /// Returns vec4.zzxw swizzling.
        /// </summary>
        public vec4 zzxw => new vec4(z, z, x, w);
        
        /// <summary>
        /// Returns vec4.bbra swizzling (equivalent to vec4.zzxw).
        /// </summary>
        public vec4 bbra => new vec4(z, z, x, w);
        
        /// <summary>
        /// Returns vec4.zzxwx swizzling.
        /// </summary>
        public vec5 zzxwx => new vec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns vec4.bbrar swizzling (equivalent to vec4.zzxwx).
        /// </summary>
        public vec5 bbrar => new vec5(z, z, x, w, x);
        
        /// <summary>
        /// Returns vec4.zzxwy swizzling.
        /// </summary>
        public vec5 zzxwy => new vec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns vec4.bbrag swizzling (equivalent to vec4.zzxwy).
        /// </summary>
        public vec5 bbrag => new vec5(z, z, x, w, y);
        
        /// <summary>
        /// Returns vec4.zzxwz swizzling.
        /// </summary>
        public vec5 zzxwz => new vec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns vec4.bbrab swizzling (equivalent to vec4.zzxwz).
        /// </summary>
        public vec5 bbrab => new vec5(z, z, x, w, z);
        
        /// <summary>
        /// Returns vec4.zzxww swizzling.
        /// </summary>
        public vec5 zzxww => new vec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns vec4.bbraa swizzling (equivalent to vec4.zzxww).
        /// </summary>
        public vec5 bbraa => new vec5(z, z, x, w, w);
        
        /// <summary>
        /// Returns vec4.zzy swizzling.
        /// </summary>
        public vec3 zzy => new vec3(z, z, y);
        
        /// <summary>
        /// Returns vec4.bbg swizzling (equivalent to vec4.zzy).
        /// </summary>
        public vec3 bbg => new vec3(z, z, y);
        
        /// <summary>
        /// Returns vec4.zzyx swizzling.
        /// </summary>
        public vec4 zzyx => new vec4(z, z, y, x);
        
        /// <summary>
        /// Returns vec4.bbgr swizzling (equivalent to vec4.zzyx).
        /// </summary>
        public vec4 bbgr => new vec4(z, z, y, x);
        
        /// <summary>
        /// Returns vec4.zzyxx swizzling.
        /// </summary>
        public vec5 zzyxx => new vec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns vec4.bbgrr swizzling (equivalent to vec4.zzyxx).
        /// </summary>
        public vec5 bbgrr => new vec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns vec4.zzyxy swizzling.
        /// </summary>
        public vec5 zzyxy => new vec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns vec4.bbgrg swizzling (equivalent to vec4.zzyxy).
        /// </summary>
        public vec5 bbgrg => new vec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns vec4.zzyxz swizzling.
        /// </summary>
        public vec5 zzyxz => new vec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns vec4.bbgrb swizzling (equivalent to vec4.zzyxz).
        /// </summary>
        public vec5 bbgrb => new vec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns vec4.zzyxw swizzling.
        /// </summary>
        public vec5 zzyxw => new vec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns vec4.bbgra swizzling (equivalent to vec4.zzyxw).
        /// </summary>
        public vec5 bbgra => new vec5(z, z, y, x, w);
        
        /// <summary>
        /// Returns vec4.zzyy swizzling.
        /// </summary>
        public vec4 zzyy => new vec4(z, z, y, y);
        
        /// <summary>
        /// Returns vec4.bbgg swizzling (equivalent to vec4.zzyy).
        /// </summary>
        public vec4 bbgg => new vec4(z, z, y, y);
        
        /// <summary>
        /// Returns vec4.zzyyx swizzling.
        /// </summary>
        public vec5 zzyyx => new vec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns vec4.bbggr swizzling (equivalent to vec4.zzyyx).
        /// </summary>
        public vec5 bbggr => new vec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns vec4.zzyyy swizzling.
        /// </summary>
        public vec5 zzyyy => new vec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns vec4.bbggg swizzling (equivalent to vec4.zzyyy).
        /// </summary>
        public vec5 bbggg => new vec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns vec4.zzyyz swizzling.
        /// </summary>
        public vec5 zzyyz => new vec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns vec4.bbggb swizzling (equivalent to vec4.zzyyz).
        /// </summary>
        public vec5 bbggb => new vec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns vec4.zzyyw swizzling.
        /// </summary>
        public vec5 zzyyw => new vec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns vec4.bbgga swizzling (equivalent to vec4.zzyyw).
        /// </summary>
        public vec5 bbgga => new vec5(z, z, y, y, w);
        
        /// <summary>
        /// Returns vec4.zzyz swizzling.
        /// </summary>
        public vec4 zzyz => new vec4(z, z, y, z);
        
        /// <summary>
        /// Returns vec4.bbgb swizzling (equivalent to vec4.zzyz).
        /// </summary>
        public vec4 bbgb => new vec4(z, z, y, z);
        
        /// <summary>
        /// Returns vec4.zzyzx swizzling.
        /// </summary>
        public vec5 zzyzx => new vec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns vec4.bbgbr swizzling (equivalent to vec4.zzyzx).
        /// </summary>
        public vec5 bbgbr => new vec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns vec4.zzyzy swizzling.
        /// </summary>
        public vec5 zzyzy => new vec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns vec4.bbgbg swizzling (equivalent to vec4.zzyzy).
        /// </summary>
        public vec5 bbgbg => new vec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns vec4.zzyzz swizzling.
        /// </summary>
        public vec5 zzyzz => new vec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns vec4.bbgbb swizzling (equivalent to vec4.zzyzz).
        /// </summary>
        public vec5 bbgbb => new vec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns vec4.zzyzw swizzling.
        /// </summary>
        public vec5 zzyzw => new vec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns vec4.bbgba swizzling (equivalent to vec4.zzyzw).
        /// </summary>
        public vec5 bbgba => new vec5(z, z, y, z, w);
        
        /// <summary>
        /// Returns vec4.zzyw swizzling.
        /// </summary>
        public vec4 zzyw => new vec4(z, z, y, w);
        
        /// <summary>
        /// Returns vec4.bbga swizzling (equivalent to vec4.zzyw).
        /// </summary>
        public vec4 bbga => new vec4(z, z, y, w);
        
        /// <summary>
        /// Returns vec4.zzywx swizzling.
        /// </summary>
        public vec5 zzywx => new vec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns vec4.bbgar swizzling (equivalent to vec4.zzywx).
        /// </summary>
        public vec5 bbgar => new vec5(z, z, y, w, x);
        
        /// <summary>
        /// Returns vec4.zzywy swizzling.
        /// </summary>
        public vec5 zzywy => new vec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns vec4.bbgag swizzling (equivalent to vec4.zzywy).
        /// </summary>
        public vec5 bbgag => new vec5(z, z, y, w, y);
        
        /// <summary>
        /// Returns vec4.zzywz swizzling.
        /// </summary>
        public vec5 zzywz => new vec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns vec4.bbgab swizzling (equivalent to vec4.zzywz).
        /// </summary>
        public vec5 bbgab => new vec5(z, z, y, w, z);
        
        /// <summary>
        /// Returns vec4.zzyww swizzling.
        /// </summary>
        public vec5 zzyww => new vec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns vec4.bbgaa swizzling (equivalent to vec4.zzyww).
        /// </summary>
        public vec5 bbgaa => new vec5(z, z, y, w, w);
        
        /// <summary>
        /// Returns vec4.zzz swizzling.
        /// </summary>
        public vec3 zzz => new vec3(z, z, z);
        
        /// <summary>
        /// Returns vec4.bbb swizzling (equivalent to vec4.zzz).
        /// </summary>
        public vec3 bbb => new vec3(z, z, z);
        
        /// <summary>
        /// Returns vec4.zzzx swizzling.
        /// </summary>
        public vec4 zzzx => new vec4(z, z, z, x);
        
        /// <summary>
        /// Returns vec4.bbbr swizzling (equivalent to vec4.zzzx).
        /// </summary>
        public vec4 bbbr => new vec4(z, z, z, x);
        
        /// <summary>
        /// Returns vec4.zzzxx swizzling.
        /// </summary>
        public vec5 zzzxx => new vec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns vec4.bbbrr swizzling (equivalent to vec4.zzzxx).
        /// </summary>
        public vec5 bbbrr => new vec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns vec4.zzzxy swizzling.
        /// </summary>
        public vec5 zzzxy => new vec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns vec4.bbbrg swizzling (equivalent to vec4.zzzxy).
        /// </summary>
        public vec5 bbbrg => new vec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns vec4.zzzxz swizzling.
        /// </summary>
        public vec5 zzzxz => new vec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns vec4.bbbrb swizzling (equivalent to vec4.zzzxz).
        /// </summary>
        public vec5 bbbrb => new vec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns vec4.zzzxw swizzling.
        /// </summary>
        public vec5 zzzxw => new vec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns vec4.bbbra swizzling (equivalent to vec4.zzzxw).
        /// </summary>
        public vec5 bbbra => new vec5(z, z, z, x, w);
        
        /// <summary>
        /// Returns vec4.zzzy swizzling.
        /// </summary>
        public vec4 zzzy => new vec4(z, z, z, y);
        
        /// <summary>
        /// Returns vec4.bbbg swizzling (equivalent to vec4.zzzy).
        /// </summary>
        public vec4 bbbg => new vec4(z, z, z, y);
        
        /// <summary>
        /// Returns vec4.zzzyx swizzling.
        /// </summary>
        public vec5 zzzyx => new vec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns vec4.bbbgr swizzling (equivalent to vec4.zzzyx).
        /// </summary>
        public vec5 bbbgr => new vec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns vec4.zzzyy swizzling.
        /// </summary>
        public vec5 zzzyy => new vec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns vec4.bbbgg swizzling (equivalent to vec4.zzzyy).
        /// </summary>
        public vec5 bbbgg => new vec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns vec4.zzzyz swizzling.
        /// </summary>
        public vec5 zzzyz => new vec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns vec4.bbbgb swizzling (equivalent to vec4.zzzyz).
        /// </summary>
        public vec5 bbbgb => new vec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns vec4.zzzyw swizzling.
        /// </summary>
        public vec5 zzzyw => new vec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns vec4.bbbga swizzling (equivalent to vec4.zzzyw).
        /// </summary>
        public vec5 bbbga => new vec5(z, z, z, y, w);
        
        /// <summary>
        /// Returns vec4.zzzz swizzling.
        /// </summary>
        public vec4 zzzz => new vec4(z, z, z, z);
        
        /// <summary>
        /// Returns vec4.bbbb swizzling (equivalent to vec4.zzzz).
        /// </summary>
        public vec4 bbbb => new vec4(z, z, z, z);
        
        /// <summary>
        /// Returns vec4.zzzzx swizzling.
        /// </summary>
        public vec5 zzzzx => new vec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns vec4.bbbbr swizzling (equivalent to vec4.zzzzx).
        /// </summary>
        public vec5 bbbbr => new vec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns vec4.zzzzy swizzling.
        /// </summary>
        public vec5 zzzzy => new vec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns vec4.bbbbg swizzling (equivalent to vec4.zzzzy).
        /// </summary>
        public vec5 bbbbg => new vec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns vec4.zzzzz swizzling.
        /// </summary>
        public vec5 zzzzz => new vec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns vec4.bbbbb swizzling (equivalent to vec4.zzzzz).
        /// </summary>
        public vec5 bbbbb => new vec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns vec4.zzzzw swizzling.
        /// </summary>
        public vec5 zzzzw => new vec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns vec4.bbbba swizzling (equivalent to vec4.zzzzw).
        /// </summary>
        public vec5 bbbba => new vec5(z, z, z, z, w);
        
        /// <summary>
        /// Returns vec4.zzzw swizzling.
        /// </summary>
        public vec4 zzzw => new vec4(z, z, z, w);
        
        /// <summary>
        /// Returns vec4.bbba swizzling (equivalent to vec4.zzzw).
        /// </summary>
        public vec4 bbba => new vec4(z, z, z, w);
        
        /// <summary>
        /// Returns vec4.zzzwx swizzling.
        /// </summary>
        public vec5 zzzwx => new vec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns vec4.bbbar swizzling (equivalent to vec4.zzzwx).
        /// </summary>
        public vec5 bbbar => new vec5(z, z, z, w, x);
        
        /// <summary>
        /// Returns vec4.zzzwy swizzling.
        /// </summary>
        public vec5 zzzwy => new vec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns vec4.bbbag swizzling (equivalent to vec4.zzzwy).
        /// </summary>
        public vec5 bbbag => new vec5(z, z, z, w, y);
        
        /// <summary>
        /// Returns vec4.zzzwz swizzling.
        /// </summary>
        public vec5 zzzwz => new vec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns vec4.bbbab swizzling (equivalent to vec4.zzzwz).
        /// </summary>
        public vec5 bbbab => new vec5(z, z, z, w, z);
        
        /// <summary>
        /// Returns vec4.zzzww swizzling.
        /// </summary>
        public vec5 zzzww => new vec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns vec4.bbbaa swizzling (equivalent to vec4.zzzww).
        /// </summary>
        public vec5 bbbaa => new vec5(z, z, z, w, w);
        
        /// <summary>
        /// Returns vec4.zzw swizzling.
        /// </summary>
        public vec3 zzw => new vec3(z, z, w);
        
        /// <summary>
        /// Returns vec4.bba swizzling (equivalent to vec4.zzw).
        /// </summary>
        public vec3 bba => new vec3(z, z, w);
        
        /// <summary>
        /// Returns vec4.zzwx swizzling.
        /// </summary>
        public vec4 zzwx => new vec4(z, z, w, x);
        
        /// <summary>
        /// Returns vec4.bbar swizzling (equivalent to vec4.zzwx).
        /// </summary>
        public vec4 bbar => new vec4(z, z, w, x);
        
        /// <summary>
        /// Returns vec4.zzwxx swizzling.
        /// </summary>
        public vec5 zzwxx => new vec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns vec4.bbarr swizzling (equivalent to vec4.zzwxx).
        /// </summary>
        public vec5 bbarr => new vec5(z, z, w, x, x);
        
        /// <summary>
        /// Returns vec4.zzwxy swizzling.
        /// </summary>
        public vec5 zzwxy => new vec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns vec4.bbarg swizzling (equivalent to vec4.zzwxy).
        /// </summary>
        public vec5 bbarg => new vec5(z, z, w, x, y);
        
        /// <summary>
        /// Returns vec4.zzwxz swizzling.
        /// </summary>
        public vec5 zzwxz => new vec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns vec4.bbarb swizzling (equivalent to vec4.zzwxz).
        /// </summary>
        public vec5 bbarb => new vec5(z, z, w, x, z);
        
        /// <summary>
        /// Returns vec4.zzwxw swizzling.
        /// </summary>
        public vec5 zzwxw => new vec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns vec4.bbara swizzling (equivalent to vec4.zzwxw).
        /// </summary>
        public vec5 bbara => new vec5(z, z, w, x, w);
        
        /// <summary>
        /// Returns vec4.zzwy swizzling.
        /// </summary>
        public vec4 zzwy => new vec4(z, z, w, y);
        
        /// <summary>
        /// Returns vec4.bbag swizzling (equivalent to vec4.zzwy).
        /// </summary>
        public vec4 bbag => new vec4(z, z, w, y);
        
        /// <summary>
        /// Returns vec4.zzwyx swizzling.
        /// </summary>
        public vec5 zzwyx => new vec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns vec4.bbagr swizzling (equivalent to vec4.zzwyx).
        /// </summary>
        public vec5 bbagr => new vec5(z, z, w, y, x);
        
        /// <summary>
        /// Returns vec4.zzwyy swizzling.
        /// </summary>
        public vec5 zzwyy => new vec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns vec4.bbagg swizzling (equivalent to vec4.zzwyy).
        /// </summary>
        public vec5 bbagg => new vec5(z, z, w, y, y);
        
        /// <summary>
        /// Returns vec4.zzwyz swizzling.
        /// </summary>
        public vec5 zzwyz => new vec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns vec4.bbagb swizzling (equivalent to vec4.zzwyz).
        /// </summary>
        public vec5 bbagb => new vec5(z, z, w, y, z);
        
        /// <summary>
        /// Returns vec4.zzwyw swizzling.
        /// </summary>
        public vec5 zzwyw => new vec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns vec4.bbaga swizzling (equivalent to vec4.zzwyw).
        /// </summary>
        public vec5 bbaga => new vec5(z, z, w, y, w);
        
        /// <summary>
        /// Returns vec4.zzwz swizzling.
        /// </summary>
        public vec4 zzwz => new vec4(z, z, w, z);
        
        /// <summary>
        /// Returns vec4.bbab swizzling (equivalent to vec4.zzwz).
        /// </summary>
        public vec4 bbab => new vec4(z, z, w, z);
        
        /// <summary>
        /// Returns vec4.zzwzx swizzling.
        /// </summary>
        public vec5 zzwzx => new vec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns vec4.bbabr swizzling (equivalent to vec4.zzwzx).
        /// </summary>
        public vec5 bbabr => new vec5(z, z, w, z, x);
        
        /// <summary>
        /// Returns vec4.zzwzy swizzling.
        /// </summary>
        public vec5 zzwzy => new vec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns vec4.bbabg swizzling (equivalent to vec4.zzwzy).
        /// </summary>
        public vec5 bbabg => new vec5(z, z, w, z, y);
        
        /// <summary>
        /// Returns vec4.zzwzz swizzling.
        /// </summary>
        public vec5 zzwzz => new vec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns vec4.bbabb swizzling (equivalent to vec4.zzwzz).
        /// </summary>
        public vec5 bbabb => new vec5(z, z, w, z, z);
        
        /// <summary>
        /// Returns vec4.zzwzw swizzling.
        /// </summary>
        public vec5 zzwzw => new vec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns vec4.bbaba swizzling (equivalent to vec4.zzwzw).
        /// </summary>
        public vec5 bbaba => new vec5(z, z, w, z, w);
        
        /// <summary>
        /// Returns vec4.zzww swizzling.
        /// </summary>
        public vec4 zzww => new vec4(z, z, w, w);
        
        /// <summary>
        /// Returns vec4.bbaa swizzling (equivalent to vec4.zzww).
        /// </summary>
        public vec4 bbaa => new vec4(z, z, w, w);
        
        /// <summary>
        /// Returns vec4.zzwwx swizzling.
        /// </summary>
        public vec5 zzwwx => new vec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns vec4.bbaar swizzling (equivalent to vec4.zzwwx).
        /// </summary>
        public vec5 bbaar => new vec5(z, z, w, w, x);
        
        /// <summary>
        /// Returns vec4.zzwwy swizzling.
        /// </summary>
        public vec5 zzwwy => new vec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns vec4.bbaag swizzling (equivalent to vec4.zzwwy).
        /// </summary>
        public vec5 bbaag => new vec5(z, z, w, w, y);
        
        /// <summary>
        /// Returns vec4.zzwwz swizzling.
        /// </summary>
        public vec5 zzwwz => new vec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns vec4.bbaab swizzling (equivalent to vec4.zzwwz).
        /// </summary>
        public vec5 bbaab => new vec5(z, z, w, w, z);
        
        /// <summary>
        /// Returns vec4.zzwww swizzling.
        /// </summary>
        public vec5 zzwww => new vec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns vec4.bbaaa swizzling (equivalent to vec4.zzwww).
        /// </summary>
        public vec5 bbaaa => new vec5(z, z, w, w, w);
        
        /// <summary>
        /// Returns vec4.zw swizzling.
        /// </summary>
        public vec2 zw => new vec2(z, w);
        
        /// <summary>
        /// Returns vec4.ba swizzling (equivalent to vec4.zw).
        /// </summary>
        public vec2 ba => new vec2(z, w);
        
        /// <summary>
        /// Returns vec4.zwx swizzling.
        /// </summary>
        public vec3 zwx => new vec3(z, w, x);
        
        /// <summary>
        /// Returns vec4.bar swizzling (equivalent to vec4.zwx).
        /// </summary>
        public vec3 bar => new vec3(z, w, x);
        
        /// <summary>
        /// Returns vec4.zwxx swizzling.
        /// </summary>
        public vec4 zwxx => new vec4(z, w, x, x);
        
        /// <summary>
        /// Returns vec4.barr swizzling (equivalent to vec4.zwxx).
        /// </summary>
        public vec4 barr => new vec4(z, w, x, x);
        
        /// <summary>
        /// Returns vec4.zwxxx swizzling.
        /// </summary>
        public vec5 zwxxx => new vec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns vec4.barrr swizzling (equivalent to vec4.zwxxx).
        /// </summary>
        public vec5 barrr => new vec5(z, w, x, x, x);
        
        /// <summary>
        /// Returns vec4.zwxxy swizzling.
        /// </summary>
        public vec5 zwxxy => new vec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns vec4.barrg swizzling (equivalent to vec4.zwxxy).
        /// </summary>
        public vec5 barrg => new vec5(z, w, x, x, y);
        
        /// <summary>
        /// Returns vec4.zwxxz swizzling.
        /// </summary>
        public vec5 zwxxz => new vec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns vec4.barrb swizzling (equivalent to vec4.zwxxz).
        /// </summary>
        public vec5 barrb => new vec5(z, w, x, x, z);
        
        /// <summary>
        /// Returns vec4.zwxxw swizzling.
        /// </summary>
        public vec5 zwxxw => new vec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns vec4.barra swizzling (equivalent to vec4.zwxxw).
        /// </summary>
        public vec5 barra => new vec5(z, w, x, x, w);
        
        /// <summary>
        /// Returns vec4.zwxy swizzling.
        /// </summary>
        public vec4 zwxy => new vec4(z, w, x, y);
        
        /// <summary>
        /// Returns vec4.barg swizzling (equivalent to vec4.zwxy).
        /// </summary>
        public vec4 barg => new vec4(z, w, x, y);
        
        /// <summary>
        /// Returns vec4.zwxyx swizzling.
        /// </summary>
        public vec5 zwxyx => new vec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns vec4.bargr swizzling (equivalent to vec4.zwxyx).
        /// </summary>
        public vec5 bargr => new vec5(z, w, x, y, x);
        
        /// <summary>
        /// Returns vec4.zwxyy swizzling.
        /// </summary>
        public vec5 zwxyy => new vec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns vec4.bargg swizzling (equivalent to vec4.zwxyy).
        /// </summary>
        public vec5 bargg => new vec5(z, w, x, y, y);
        
        /// <summary>
        /// Returns vec4.zwxyz swizzling.
        /// </summary>
        public vec5 zwxyz => new vec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns vec4.bargb swizzling (equivalent to vec4.zwxyz).
        /// </summary>
        public vec5 bargb => new vec5(z, w, x, y, z);
        
        /// <summary>
        /// Returns vec4.zwxyw swizzling.
        /// </summary>
        public vec5 zwxyw => new vec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns vec4.barga swizzling (equivalent to vec4.zwxyw).
        /// </summary>
        public vec5 barga => new vec5(z, w, x, y, w);
        
        /// <summary>
        /// Returns vec4.zwxz swizzling.
        /// </summary>
        public vec4 zwxz => new vec4(z, w, x, z);
        
        /// <summary>
        /// Returns vec4.barb swizzling (equivalent to vec4.zwxz).
        /// </summary>
        public vec4 barb => new vec4(z, w, x, z);
        
        /// <summary>
        /// Returns vec4.zwxzx swizzling.
        /// </summary>
        public vec5 zwxzx => new vec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns vec4.barbr swizzling (equivalent to vec4.zwxzx).
        /// </summary>
        public vec5 barbr => new vec5(z, w, x, z, x);
        
        /// <summary>
        /// Returns vec4.zwxzy swizzling.
        /// </summary>
        public vec5 zwxzy => new vec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns vec4.barbg swizzling (equivalent to vec4.zwxzy).
        /// </summary>
        public vec5 barbg => new vec5(z, w, x, z, y);
        
        /// <summary>
        /// Returns vec4.zwxzz swizzling.
        /// </summary>
        public vec5 zwxzz => new vec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns vec4.barbb swizzling (equivalent to vec4.zwxzz).
        /// </summary>
        public vec5 barbb => new vec5(z, w, x, z, z);
        
        /// <summary>
        /// Returns vec4.zwxzw swizzling.
        /// </summary>
        public vec5 zwxzw => new vec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns vec4.barba swizzling (equivalent to vec4.zwxzw).
        /// </summary>
        public vec5 barba => new vec5(z, w, x, z, w);
        
        /// <summary>
        /// Returns vec4.zwxw swizzling.
        /// </summary>
        public vec4 zwxw => new vec4(z, w, x, w);
        
        /// <summary>
        /// Returns vec4.bara swizzling (equivalent to vec4.zwxw).
        /// </summary>
        public vec4 bara => new vec4(z, w, x, w);
        
        /// <summary>
        /// Returns vec4.zwxwx swizzling.
        /// </summary>
        public vec5 zwxwx => new vec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns vec4.barar swizzling (equivalent to vec4.zwxwx).
        /// </summary>
        public vec5 barar => new vec5(z, w, x, w, x);
        
        /// <summary>
        /// Returns vec4.zwxwy swizzling.
        /// </summary>
        public vec5 zwxwy => new vec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns vec4.barag swizzling (equivalent to vec4.zwxwy).
        /// </summary>
        public vec5 barag => new vec5(z, w, x, w, y);
        
        /// <summary>
        /// Returns vec4.zwxwz swizzling.
        /// </summary>
        public vec5 zwxwz => new vec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns vec4.barab swizzling (equivalent to vec4.zwxwz).
        /// </summary>
        public vec5 barab => new vec5(z, w, x, w, z);
        
        /// <summary>
        /// Returns vec4.zwxww swizzling.
        /// </summary>
        public vec5 zwxww => new vec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns vec4.baraa swizzling (equivalent to vec4.zwxww).
        /// </summary>
        public vec5 baraa => new vec5(z, w, x, w, w);
        
        /// <summary>
        /// Returns vec4.zwy swizzling.
        /// </summary>
        public vec3 zwy => new vec3(z, w, y);
        
        /// <summary>
        /// Returns vec4.bag swizzling (equivalent to vec4.zwy).
        /// </summary>
        public vec3 bag => new vec3(z, w, y);
        
        /// <summary>
        /// Returns vec4.zwyx swizzling.
        /// </summary>
        public vec4 zwyx => new vec4(z, w, y, x);
        
        /// <summary>
        /// Returns vec4.bagr swizzling (equivalent to vec4.zwyx).
        /// </summary>
        public vec4 bagr => new vec4(z, w, y, x);
        
        /// <summary>
        /// Returns vec4.zwyxx swizzling.
        /// </summary>
        public vec5 zwyxx => new vec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns vec4.bagrr swizzling (equivalent to vec4.zwyxx).
        /// </summary>
        public vec5 bagrr => new vec5(z, w, y, x, x);
        
        /// <summary>
        /// Returns vec4.zwyxy swizzling.
        /// </summary>
        public vec5 zwyxy => new vec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns vec4.bagrg swizzling (equivalent to vec4.zwyxy).
        /// </summary>
        public vec5 bagrg => new vec5(z, w, y, x, y);
        
        /// <summary>
        /// Returns vec4.zwyxz swizzling.
        /// </summary>
        public vec5 zwyxz => new vec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns vec4.bagrb swizzling (equivalent to vec4.zwyxz).
        /// </summary>
        public vec5 bagrb => new vec5(z, w, y, x, z);
        
        /// <summary>
        /// Returns vec4.zwyxw swizzling.
        /// </summary>
        public vec5 zwyxw => new vec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns vec4.bagra swizzling (equivalent to vec4.zwyxw).
        /// </summary>
        public vec5 bagra => new vec5(z, w, y, x, w);
        
        /// <summary>
        /// Returns vec4.zwyy swizzling.
        /// </summary>
        public vec4 zwyy => new vec4(z, w, y, y);
        
        /// <summary>
        /// Returns vec4.bagg swizzling (equivalent to vec4.zwyy).
        /// </summary>
        public vec4 bagg => new vec4(z, w, y, y);
        
        /// <summary>
        /// Returns vec4.zwyyx swizzling.
        /// </summary>
        public vec5 zwyyx => new vec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns vec4.baggr swizzling (equivalent to vec4.zwyyx).
        /// </summary>
        public vec5 baggr => new vec5(z, w, y, y, x);
        
        /// <summary>
        /// Returns vec4.zwyyy swizzling.
        /// </summary>
        public vec5 zwyyy => new vec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns vec4.baggg swizzling (equivalent to vec4.zwyyy).
        /// </summary>
        public vec5 baggg => new vec5(z, w, y, y, y);
        
        /// <summary>
        /// Returns vec4.zwyyz swizzling.
        /// </summary>
        public vec5 zwyyz => new vec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns vec4.baggb swizzling (equivalent to vec4.zwyyz).
        /// </summary>
        public vec5 baggb => new vec5(z, w, y, y, z);
        
        /// <summary>
        /// Returns vec4.zwyyw swizzling.
        /// </summary>
        public vec5 zwyyw => new vec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns vec4.bagga swizzling (equivalent to vec4.zwyyw).
        /// </summary>
        public vec5 bagga => new vec5(z, w, y, y, w);
        
        /// <summary>
        /// Returns vec4.zwyz swizzling.
        /// </summary>
        public vec4 zwyz => new vec4(z, w, y, z);
        
        /// <summary>
        /// Returns vec4.bagb swizzling (equivalent to vec4.zwyz).
        /// </summary>
        public vec4 bagb => new vec4(z, w, y, z);
        
        /// <summary>
        /// Returns vec4.zwyzx swizzling.
        /// </summary>
        public vec5 zwyzx => new vec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns vec4.bagbr swizzling (equivalent to vec4.zwyzx).
        /// </summary>
        public vec5 bagbr => new vec5(z, w, y, z, x);
        
        /// <summary>
        /// Returns vec4.zwyzy swizzling.
        /// </summary>
        public vec5 zwyzy => new vec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns vec4.bagbg swizzling (equivalent to vec4.zwyzy).
        /// </summary>
        public vec5 bagbg => new vec5(z, w, y, z, y);
        
        /// <summary>
        /// Returns vec4.zwyzz swizzling.
        /// </summary>
        public vec5 zwyzz => new vec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns vec4.bagbb swizzling (equivalent to vec4.zwyzz).
        /// </summary>
        public vec5 bagbb => new vec5(z, w, y, z, z);
        
        /// <summary>
        /// Returns vec4.zwyzw swizzling.
        /// </summary>
        public vec5 zwyzw => new vec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns vec4.bagba swizzling (equivalent to vec4.zwyzw).
        /// </summary>
        public vec5 bagba => new vec5(z, w, y, z, w);
        
        /// <summary>
        /// Returns vec4.zwyw swizzling.
        /// </summary>
        public vec4 zwyw => new vec4(z, w, y, w);
        
        /// <summary>
        /// Returns vec4.baga swizzling (equivalent to vec4.zwyw).
        /// </summary>
        public vec4 baga => new vec4(z, w, y, w);
        
        /// <summary>
        /// Returns vec4.zwywx swizzling.
        /// </summary>
        public vec5 zwywx => new vec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns vec4.bagar swizzling (equivalent to vec4.zwywx).
        /// </summary>
        public vec5 bagar => new vec5(z, w, y, w, x);
        
        /// <summary>
        /// Returns vec4.zwywy swizzling.
        /// </summary>
        public vec5 zwywy => new vec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns vec4.bagag swizzling (equivalent to vec4.zwywy).
        /// </summary>
        public vec5 bagag => new vec5(z, w, y, w, y);
        
        /// <summary>
        /// Returns vec4.zwywz swizzling.
        /// </summary>
        public vec5 zwywz => new vec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns vec4.bagab swizzling (equivalent to vec4.zwywz).
        /// </summary>
        public vec5 bagab => new vec5(z, w, y, w, z);
        
        /// <summary>
        /// Returns vec4.zwyww swizzling.
        /// </summary>
        public vec5 zwyww => new vec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns vec4.bagaa swizzling (equivalent to vec4.zwyww).
        /// </summary>
        public vec5 bagaa => new vec5(z, w, y, w, w);
        
        /// <summary>
        /// Returns vec4.zwz swizzling.
        /// </summary>
        public vec3 zwz => new vec3(z, w, z);
        
        /// <summary>
        /// Returns vec4.bab swizzling (equivalent to vec4.zwz).
        /// </summary>
        public vec3 bab => new vec3(z, w, z);
        
        /// <summary>
        /// Returns vec4.zwzx swizzling.
        /// </summary>
        public vec4 zwzx => new vec4(z, w, z, x);
        
        /// <summary>
        /// Returns vec4.babr swizzling (equivalent to vec4.zwzx).
        /// </summary>
        public vec4 babr => new vec4(z, w, z, x);
        
        /// <summary>
        /// Returns vec4.zwzxx swizzling.
        /// </summary>
        public vec5 zwzxx => new vec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns vec4.babrr swizzling (equivalent to vec4.zwzxx).
        /// </summary>
        public vec5 babrr => new vec5(z, w, z, x, x);
        
        /// <summary>
        /// Returns vec4.zwzxy swizzling.
        /// </summary>
        public vec5 zwzxy => new vec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns vec4.babrg swizzling (equivalent to vec4.zwzxy).
        /// </summary>
        public vec5 babrg => new vec5(z, w, z, x, y);
        
        /// <summary>
        /// Returns vec4.zwzxz swizzling.
        /// </summary>
        public vec5 zwzxz => new vec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns vec4.babrb swizzling (equivalent to vec4.zwzxz).
        /// </summary>
        public vec5 babrb => new vec5(z, w, z, x, z);
        
        /// <summary>
        /// Returns vec4.zwzxw swizzling.
        /// </summary>
        public vec5 zwzxw => new vec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns vec4.babra swizzling (equivalent to vec4.zwzxw).
        /// </summary>
        public vec5 babra => new vec5(z, w, z, x, w);
        
        /// <summary>
        /// Returns vec4.zwzy swizzling.
        /// </summary>
        public vec4 zwzy => new vec4(z, w, z, y);
        
        /// <summary>
        /// Returns vec4.babg swizzling (equivalent to vec4.zwzy).
        /// </summary>
        public vec4 babg => new vec4(z, w, z, y);
        
        /// <summary>
        /// Returns vec4.zwzyx swizzling.
        /// </summary>
        public vec5 zwzyx => new vec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns vec4.babgr swizzling (equivalent to vec4.zwzyx).
        /// </summary>
        public vec5 babgr => new vec5(z, w, z, y, x);
        
        /// <summary>
        /// Returns vec4.zwzyy swizzling.
        /// </summary>
        public vec5 zwzyy => new vec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns vec4.babgg swizzling (equivalent to vec4.zwzyy).
        /// </summary>
        public vec5 babgg => new vec5(z, w, z, y, y);
        
        /// <summary>
        /// Returns vec4.zwzyz swizzling.
        /// </summary>
        public vec5 zwzyz => new vec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns vec4.babgb swizzling (equivalent to vec4.zwzyz).
        /// </summary>
        public vec5 babgb => new vec5(z, w, z, y, z);
        
        /// <summary>
        /// Returns vec4.zwzyw swizzling.
        /// </summary>
        public vec5 zwzyw => new vec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns vec4.babga swizzling (equivalent to vec4.zwzyw).
        /// </summary>
        public vec5 babga => new vec5(z, w, z, y, w);
        
        /// <summary>
        /// Returns vec4.zwzz swizzling.
        /// </summary>
        public vec4 zwzz => new vec4(z, w, z, z);
        
        /// <summary>
        /// Returns vec4.babb swizzling (equivalent to vec4.zwzz).
        /// </summary>
        public vec4 babb => new vec4(z, w, z, z);
        
        /// <summary>
        /// Returns vec4.zwzzx swizzling.
        /// </summary>
        public vec5 zwzzx => new vec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns vec4.babbr swizzling (equivalent to vec4.zwzzx).
        /// </summary>
        public vec5 babbr => new vec5(z, w, z, z, x);
        
        /// <summary>
        /// Returns vec4.zwzzy swizzling.
        /// </summary>
        public vec5 zwzzy => new vec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns vec4.babbg swizzling (equivalent to vec4.zwzzy).
        /// </summary>
        public vec5 babbg => new vec5(z, w, z, z, y);
        
        /// <summary>
        /// Returns vec4.zwzzz swizzling.
        /// </summary>
        public vec5 zwzzz => new vec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns vec4.babbb swizzling (equivalent to vec4.zwzzz).
        /// </summary>
        public vec5 babbb => new vec5(z, w, z, z, z);
        
        /// <summary>
        /// Returns vec4.zwzzw swizzling.
        /// </summary>
        public vec5 zwzzw => new vec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns vec4.babba swizzling (equivalent to vec4.zwzzw).
        /// </summary>
        public vec5 babba => new vec5(z, w, z, z, w);
        
        /// <summary>
        /// Returns vec4.zwzw swizzling.
        /// </summary>
        public vec4 zwzw => new vec4(z, w, z, w);
        
        /// <summary>
        /// Returns vec4.baba swizzling (equivalent to vec4.zwzw).
        /// </summary>
        public vec4 baba => new vec4(z, w, z, w);
        
        /// <summary>
        /// Returns vec4.zwzwx swizzling.
        /// </summary>
        public vec5 zwzwx => new vec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns vec4.babar swizzling (equivalent to vec4.zwzwx).
        /// </summary>
        public vec5 babar => new vec5(z, w, z, w, x);
        
        /// <summary>
        /// Returns vec4.zwzwy swizzling.
        /// </summary>
        public vec5 zwzwy => new vec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns vec4.babag swizzling (equivalent to vec4.zwzwy).
        /// </summary>
        public vec5 babag => new vec5(z, w, z, w, y);
        
        /// <summary>
        /// Returns vec4.zwzwz swizzling.
        /// </summary>
        public vec5 zwzwz => new vec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns vec4.babab swizzling (equivalent to vec4.zwzwz).
        /// </summary>
        public vec5 babab => new vec5(z, w, z, w, z);
        
        /// <summary>
        /// Returns vec4.zwzww swizzling.
        /// </summary>
        public vec5 zwzww => new vec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns vec4.babaa swizzling (equivalent to vec4.zwzww).
        /// </summary>
        public vec5 babaa => new vec5(z, w, z, w, w);
        
        /// <summary>
        /// Returns vec4.zww swizzling.
        /// </summary>
        public vec3 zww => new vec3(z, w, w);
        
        /// <summary>
        /// Returns vec4.baa swizzling (equivalent to vec4.zww).
        /// </summary>
        public vec3 baa => new vec3(z, w, w);
        
        /// <summary>
        /// Returns vec4.zwwx swizzling.
        /// </summary>
        public vec4 zwwx => new vec4(z, w, w, x);
        
        /// <summary>
        /// Returns vec4.baar swizzling (equivalent to vec4.zwwx).
        /// </summary>
        public vec4 baar => new vec4(z, w, w, x);
        
        /// <summary>
        /// Returns vec4.zwwxx swizzling.
        /// </summary>
        public vec5 zwwxx => new vec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns vec4.baarr swizzling (equivalent to vec4.zwwxx).
        /// </summary>
        public vec5 baarr => new vec5(z, w, w, x, x);
        
        /// <summary>
        /// Returns vec4.zwwxy swizzling.
        /// </summary>
        public vec5 zwwxy => new vec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns vec4.baarg swizzling (equivalent to vec4.zwwxy).
        /// </summary>
        public vec5 baarg => new vec5(z, w, w, x, y);
        
        /// <summary>
        /// Returns vec4.zwwxz swizzling.
        /// </summary>
        public vec5 zwwxz => new vec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns vec4.baarb swizzling (equivalent to vec4.zwwxz).
        /// </summary>
        public vec5 baarb => new vec5(z, w, w, x, z);
        
        /// <summary>
        /// Returns vec4.zwwxw swizzling.
        /// </summary>
        public vec5 zwwxw => new vec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns vec4.baara swizzling (equivalent to vec4.zwwxw).
        /// </summary>
        public vec5 baara => new vec5(z, w, w, x, w);
        
        /// <summary>
        /// Returns vec4.zwwy swizzling.
        /// </summary>
        public vec4 zwwy => new vec4(z, w, w, y);
        
        /// <summary>
        /// Returns vec4.baag swizzling (equivalent to vec4.zwwy).
        /// </summary>
        public vec4 baag => new vec4(z, w, w, y);
        
        /// <summary>
        /// Returns vec4.zwwyx swizzling.
        /// </summary>
        public vec5 zwwyx => new vec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns vec4.baagr swizzling (equivalent to vec4.zwwyx).
        /// </summary>
        public vec5 baagr => new vec5(z, w, w, y, x);
        
        /// <summary>
        /// Returns vec4.zwwyy swizzling.
        /// </summary>
        public vec5 zwwyy => new vec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns vec4.baagg swizzling (equivalent to vec4.zwwyy).
        /// </summary>
        public vec5 baagg => new vec5(z, w, w, y, y);
        
        /// <summary>
        /// Returns vec4.zwwyz swizzling.
        /// </summary>
        public vec5 zwwyz => new vec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns vec4.baagb swizzling (equivalent to vec4.zwwyz).
        /// </summary>
        public vec5 baagb => new vec5(z, w, w, y, z);
        
        /// <summary>
        /// Returns vec4.zwwyw swizzling.
        /// </summary>
        public vec5 zwwyw => new vec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns vec4.baaga swizzling (equivalent to vec4.zwwyw).
        /// </summary>
        public vec5 baaga => new vec5(z, w, w, y, w);
        
        /// <summary>
        /// Returns vec4.zwwz swizzling.
        /// </summary>
        public vec4 zwwz => new vec4(z, w, w, z);
        
        /// <summary>
        /// Returns vec4.baab swizzling (equivalent to vec4.zwwz).
        /// </summary>
        public vec4 baab => new vec4(z, w, w, z);
        
        /// <summary>
        /// Returns vec4.zwwzx swizzling.
        /// </summary>
        public vec5 zwwzx => new vec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns vec4.baabr swizzling (equivalent to vec4.zwwzx).
        /// </summary>
        public vec5 baabr => new vec5(z, w, w, z, x);
        
        /// <summary>
        /// Returns vec4.zwwzy swizzling.
        /// </summary>
        public vec5 zwwzy => new vec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns vec4.baabg swizzling (equivalent to vec4.zwwzy).
        /// </summary>
        public vec5 baabg => new vec5(z, w, w, z, y);
        
        /// <summary>
        /// Returns vec4.zwwzz swizzling.
        /// </summary>
        public vec5 zwwzz => new vec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns vec4.baabb swizzling (equivalent to vec4.zwwzz).
        /// </summary>
        public vec5 baabb => new vec5(z, w, w, z, z);
        
        /// <summary>
        /// Returns vec4.zwwzw swizzling.
        /// </summary>
        public vec5 zwwzw => new vec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns vec4.baaba swizzling (equivalent to vec4.zwwzw).
        /// </summary>
        public vec5 baaba => new vec5(z, w, w, z, w);
        
        /// <summary>
        /// Returns vec4.zwww swizzling.
        /// </summary>
        public vec4 zwww => new vec4(z, w, w, w);
        
        /// <summary>
        /// Returns vec4.baaa swizzling (equivalent to vec4.zwww).
        /// </summary>
        public vec4 baaa => new vec4(z, w, w, w);
        
        /// <summary>
        /// Returns vec4.zwwwx swizzling.
        /// </summary>
        public vec5 zwwwx => new vec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns vec4.baaar swizzling (equivalent to vec4.zwwwx).
        /// </summary>
        public vec5 baaar => new vec5(z, w, w, w, x);
        
        /// <summary>
        /// Returns vec4.zwwwy swizzling.
        /// </summary>
        public vec5 zwwwy => new vec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns vec4.baaag swizzling (equivalent to vec4.zwwwy).
        /// </summary>
        public vec5 baaag => new vec5(z, w, w, w, y);
        
        /// <summary>
        /// Returns vec4.zwwwz swizzling.
        /// </summary>
        public vec5 zwwwz => new vec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns vec4.baaab swizzling (equivalent to vec4.zwwwz).
        /// </summary>
        public vec5 baaab => new vec5(z, w, w, w, z);
        
        /// <summary>
        /// Returns vec4.zwwww swizzling.
        /// </summary>
        public vec5 zwwww => new vec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns vec4.baaaa swizzling (equivalent to vec4.zwwww).
        /// </summary>
        public vec5 baaaa => new vec5(z, w, w, w, w);
        
        /// <summary>
        /// Returns vec4.wx swizzling.
        /// </summary>
        public vec2 wx => new vec2(w, x);
        
        /// <summary>
        /// Returns vec4.ar swizzling (equivalent to vec4.wx).
        /// </summary>
        public vec2 ar => new vec2(w, x);
        
        /// <summary>
        /// Returns vec4.wxx swizzling.
        /// </summary>
        public vec3 wxx => new vec3(w, x, x);
        
        /// <summary>
        /// Returns vec4.arr swizzling (equivalent to vec4.wxx).
        /// </summary>
        public vec3 arr => new vec3(w, x, x);
        
        /// <summary>
        /// Returns vec4.wxxx swizzling.
        /// </summary>
        public vec4 wxxx => new vec4(w, x, x, x);
        
        /// <summary>
        /// Returns vec4.arrr swizzling (equivalent to vec4.wxxx).
        /// </summary>
        public vec4 arrr => new vec4(w, x, x, x);
        
        /// <summary>
        /// Returns vec4.wxxxx swizzling.
        /// </summary>
        public vec5 wxxxx => new vec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns vec4.arrrr swizzling (equivalent to vec4.wxxxx).
        /// </summary>
        public vec5 arrrr => new vec5(w, x, x, x, x);
        
        /// <summary>
        /// Returns vec4.wxxxy swizzling.
        /// </summary>
        public vec5 wxxxy => new vec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns vec4.arrrg swizzling (equivalent to vec4.wxxxy).
        /// </summary>
        public vec5 arrrg => new vec5(w, x, x, x, y);
        
        /// <summary>
        /// Returns vec4.wxxxz swizzling.
        /// </summary>
        public vec5 wxxxz => new vec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns vec4.arrrb swizzling (equivalent to vec4.wxxxz).
        /// </summary>
        public vec5 arrrb => new vec5(w, x, x, x, z);
        
        /// <summary>
        /// Returns vec4.wxxxw swizzling.
        /// </summary>
        public vec5 wxxxw => new vec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns vec4.arrra swizzling (equivalent to vec4.wxxxw).
        /// </summary>
        public vec5 arrra => new vec5(w, x, x, x, w);
        
        /// <summary>
        /// Returns vec4.wxxy swizzling.
        /// </summary>
        public vec4 wxxy => new vec4(w, x, x, y);
        
        /// <summary>
        /// Returns vec4.arrg swizzling (equivalent to vec4.wxxy).
        /// </summary>
        public vec4 arrg => new vec4(w, x, x, y);
        
        /// <summary>
        /// Returns vec4.wxxyx swizzling.
        /// </summary>
        public vec5 wxxyx => new vec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns vec4.arrgr swizzling (equivalent to vec4.wxxyx).
        /// </summary>
        public vec5 arrgr => new vec5(w, x, x, y, x);
        
        /// <summary>
        /// Returns vec4.wxxyy swizzling.
        /// </summary>
        public vec5 wxxyy => new vec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns vec4.arrgg swizzling (equivalent to vec4.wxxyy).
        /// </summary>
        public vec5 arrgg => new vec5(w, x, x, y, y);
        
        /// <summary>
        /// Returns vec4.wxxyz swizzling.
        /// </summary>
        public vec5 wxxyz => new vec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns vec4.arrgb swizzling (equivalent to vec4.wxxyz).
        /// </summary>
        public vec5 arrgb => new vec5(w, x, x, y, z);
        
        /// <summary>
        /// Returns vec4.wxxyw swizzling.
        /// </summary>
        public vec5 wxxyw => new vec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns vec4.arrga swizzling (equivalent to vec4.wxxyw).
        /// </summary>
        public vec5 arrga => new vec5(w, x, x, y, w);
        
        /// <summary>
        /// Returns vec4.wxxz swizzling.
        /// </summary>
        public vec4 wxxz => new vec4(w, x, x, z);
        
        /// <summary>
        /// Returns vec4.arrb swizzling (equivalent to vec4.wxxz).
        /// </summary>
        public vec4 arrb => new vec4(w, x, x, z);
        
        /// <summary>
        /// Returns vec4.wxxzx swizzling.
        /// </summary>
        public vec5 wxxzx => new vec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns vec4.arrbr swizzling (equivalent to vec4.wxxzx).
        /// </summary>
        public vec5 arrbr => new vec5(w, x, x, z, x);
        
        /// <summary>
        /// Returns vec4.wxxzy swizzling.
        /// </summary>
        public vec5 wxxzy => new vec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns vec4.arrbg swizzling (equivalent to vec4.wxxzy).
        /// </summary>
        public vec5 arrbg => new vec5(w, x, x, z, y);
        
        /// <summary>
        /// Returns vec4.wxxzz swizzling.
        /// </summary>
        public vec5 wxxzz => new vec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns vec4.arrbb swizzling (equivalent to vec4.wxxzz).
        /// </summary>
        public vec5 arrbb => new vec5(w, x, x, z, z);
        
        /// <summary>
        /// Returns vec4.wxxzw swizzling.
        /// </summary>
        public vec5 wxxzw => new vec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns vec4.arrba swizzling (equivalent to vec4.wxxzw).
        /// </summary>
        public vec5 arrba => new vec5(w, x, x, z, w);
        
        /// <summary>
        /// Returns vec4.wxxw swizzling.
        /// </summary>
        public vec4 wxxw => new vec4(w, x, x, w);
        
        /// <summary>
        /// Returns vec4.arra swizzling (equivalent to vec4.wxxw).
        /// </summary>
        public vec4 arra => new vec4(w, x, x, w);
        
        /// <summary>
        /// Returns vec4.wxxwx swizzling.
        /// </summary>
        public vec5 wxxwx => new vec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns vec4.arrar swizzling (equivalent to vec4.wxxwx).
        /// </summary>
        public vec5 arrar => new vec5(w, x, x, w, x);
        
        /// <summary>
        /// Returns vec4.wxxwy swizzling.
        /// </summary>
        public vec5 wxxwy => new vec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns vec4.arrag swizzling (equivalent to vec4.wxxwy).
        /// </summary>
        public vec5 arrag => new vec5(w, x, x, w, y);
        
        /// <summary>
        /// Returns vec4.wxxwz swizzling.
        /// </summary>
        public vec5 wxxwz => new vec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns vec4.arrab swizzling (equivalent to vec4.wxxwz).
        /// </summary>
        public vec5 arrab => new vec5(w, x, x, w, z);
        
        /// <summary>
        /// Returns vec4.wxxww swizzling.
        /// </summary>
        public vec5 wxxww => new vec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns vec4.arraa swizzling (equivalent to vec4.wxxww).
        /// </summary>
        public vec5 arraa => new vec5(w, x, x, w, w);
        
        /// <summary>
        /// Returns vec4.wxy swizzling.
        /// </summary>
        public vec3 wxy => new vec3(w, x, y);
        
        /// <summary>
        /// Returns vec4.arg swizzling (equivalent to vec4.wxy).
        /// </summary>
        public vec3 arg => new vec3(w, x, y);
        
        /// <summary>
        /// Returns vec4.wxyx swizzling.
        /// </summary>
        public vec4 wxyx => new vec4(w, x, y, x);
        
        /// <summary>
        /// Returns vec4.argr swizzling (equivalent to vec4.wxyx).
        /// </summary>
        public vec4 argr => new vec4(w, x, y, x);
        
        /// <summary>
        /// Returns vec4.wxyxx swizzling.
        /// </summary>
        public vec5 wxyxx => new vec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns vec4.argrr swizzling (equivalent to vec4.wxyxx).
        /// </summary>
        public vec5 argrr => new vec5(w, x, y, x, x);
        
        /// <summary>
        /// Returns vec4.wxyxy swizzling.
        /// </summary>
        public vec5 wxyxy => new vec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns vec4.argrg swizzling (equivalent to vec4.wxyxy).
        /// </summary>
        public vec5 argrg => new vec5(w, x, y, x, y);
        
        /// <summary>
        /// Returns vec4.wxyxz swizzling.
        /// </summary>
        public vec5 wxyxz => new vec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns vec4.argrb swizzling (equivalent to vec4.wxyxz).
        /// </summary>
        public vec5 argrb => new vec5(w, x, y, x, z);
        
        /// <summary>
        /// Returns vec4.wxyxw swizzling.
        /// </summary>
        public vec5 wxyxw => new vec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns vec4.argra swizzling (equivalent to vec4.wxyxw).
        /// </summary>
        public vec5 argra => new vec5(w, x, y, x, w);
        
        /// <summary>
        /// Returns vec4.wxyy swizzling.
        /// </summary>
        public vec4 wxyy => new vec4(w, x, y, y);
        
        /// <summary>
        /// Returns vec4.argg swizzling (equivalent to vec4.wxyy).
        /// </summary>
        public vec4 argg => new vec4(w, x, y, y);
        
        /// <summary>
        /// Returns vec4.wxyyx swizzling.
        /// </summary>
        public vec5 wxyyx => new vec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns vec4.arggr swizzling (equivalent to vec4.wxyyx).
        /// </summary>
        public vec5 arggr => new vec5(w, x, y, y, x);
        
        /// <summary>
        /// Returns vec4.wxyyy swizzling.
        /// </summary>
        public vec5 wxyyy => new vec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns vec4.arggg swizzling (equivalent to vec4.wxyyy).
        /// </summary>
        public vec5 arggg => new vec5(w, x, y, y, y);
        
        /// <summary>
        /// Returns vec4.wxyyz swizzling.
        /// </summary>
        public vec5 wxyyz => new vec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns vec4.arggb swizzling (equivalent to vec4.wxyyz).
        /// </summary>
        public vec5 arggb => new vec5(w, x, y, y, z);
        
        /// <summary>
        /// Returns vec4.wxyyw swizzling.
        /// </summary>
        public vec5 wxyyw => new vec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns vec4.argga swizzling (equivalent to vec4.wxyyw).
        /// </summary>
        public vec5 argga => new vec5(w, x, y, y, w);
        
        /// <summary>
        /// Returns vec4.wxyz swizzling.
        /// </summary>
        public vec4 wxyz => new vec4(w, x, y, z);
        
        /// <summary>
        /// Returns vec4.argb swizzling (equivalent to vec4.wxyz).
        /// </summary>
        public vec4 argb => new vec4(w, x, y, z);
        
        /// <summary>
        /// Returns vec4.wxyzx swizzling.
        /// </summary>
        public vec5 wxyzx => new vec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns vec4.argbr swizzling (equivalent to vec4.wxyzx).
        /// </summary>
        public vec5 argbr => new vec5(w, x, y, z, x);
        
        /// <summary>
        /// Returns vec4.wxyzy swizzling.
        /// </summary>
        public vec5 wxyzy => new vec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns vec4.argbg swizzling (equivalent to vec4.wxyzy).
        /// </summary>
        public vec5 argbg => new vec5(w, x, y, z, y);
        
        /// <summary>
        /// Returns vec4.wxyzz swizzling.
        /// </summary>
        public vec5 wxyzz => new vec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns vec4.argbb swizzling (equivalent to vec4.wxyzz).
        /// </summary>
        public vec5 argbb => new vec5(w, x, y, z, z);
        
        /// <summary>
        /// Returns vec4.wxyzw swizzling.
        /// </summary>
        public vec5 wxyzw => new vec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns vec4.argba swizzling (equivalent to vec4.wxyzw).
        /// </summary>
        public vec5 argba => new vec5(w, x, y, z, w);
        
        /// <summary>
        /// Returns vec4.wxyw swizzling.
        /// </summary>
        public vec4 wxyw => new vec4(w, x, y, w);
        
        /// <summary>
        /// Returns vec4.arga swizzling (equivalent to vec4.wxyw).
        /// </summary>
        public vec4 arga => new vec4(w, x, y, w);
        
        /// <summary>
        /// Returns vec4.wxywx swizzling.
        /// </summary>
        public vec5 wxywx => new vec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns vec4.argar swizzling (equivalent to vec4.wxywx).
        /// </summary>
        public vec5 argar => new vec5(w, x, y, w, x);
        
        /// <summary>
        /// Returns vec4.wxywy swizzling.
        /// </summary>
        public vec5 wxywy => new vec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns vec4.argag swizzling (equivalent to vec4.wxywy).
        /// </summary>
        public vec5 argag => new vec5(w, x, y, w, y);
        
        /// <summary>
        /// Returns vec4.wxywz swizzling.
        /// </summary>
        public vec5 wxywz => new vec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns vec4.argab swizzling (equivalent to vec4.wxywz).
        /// </summary>
        public vec5 argab => new vec5(w, x, y, w, z);
        
        /// <summary>
        /// Returns vec4.wxyww swizzling.
        /// </summary>
        public vec5 wxyww => new vec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns vec4.argaa swizzling (equivalent to vec4.wxyww).
        /// </summary>
        public vec5 argaa => new vec5(w, x, y, w, w);
        
        /// <summary>
        /// Returns vec4.wxz swizzling.
        /// </summary>
        public vec3 wxz => new vec3(w, x, z);
        
        /// <summary>
        /// Returns vec4.arb swizzling (equivalent to vec4.wxz).
        /// </summary>
        public vec3 arb => new vec3(w, x, z);
        
        /// <summary>
        /// Returns vec4.wxzx swizzling.
        /// </summary>
        public vec4 wxzx => new vec4(w, x, z, x);
        
        /// <summary>
        /// Returns vec4.arbr swizzling (equivalent to vec4.wxzx).
        /// </summary>
        public vec4 arbr => new vec4(w, x, z, x);
        
        /// <summary>
        /// Returns vec4.wxzxx swizzling.
        /// </summary>
        public vec5 wxzxx => new vec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns vec4.arbrr swizzling (equivalent to vec4.wxzxx).
        /// </summary>
        public vec5 arbrr => new vec5(w, x, z, x, x);
        
        /// <summary>
        /// Returns vec4.wxzxy swizzling.
        /// </summary>
        public vec5 wxzxy => new vec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns vec4.arbrg swizzling (equivalent to vec4.wxzxy).
        /// </summary>
        public vec5 arbrg => new vec5(w, x, z, x, y);
        
        /// <summary>
        /// Returns vec4.wxzxz swizzling.
        /// </summary>
        public vec5 wxzxz => new vec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns vec4.arbrb swizzling (equivalent to vec4.wxzxz).
        /// </summary>
        public vec5 arbrb => new vec5(w, x, z, x, z);
        
        /// <summary>
        /// Returns vec4.wxzxw swizzling.
        /// </summary>
        public vec5 wxzxw => new vec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns vec4.arbra swizzling (equivalent to vec4.wxzxw).
        /// </summary>
        public vec5 arbra => new vec5(w, x, z, x, w);
        
        /// <summary>
        /// Returns vec4.wxzy swizzling.
        /// </summary>
        public vec4 wxzy => new vec4(w, x, z, y);
        
        /// <summary>
        /// Returns vec4.arbg swizzling (equivalent to vec4.wxzy).
        /// </summary>
        public vec4 arbg => new vec4(w, x, z, y);
        
        /// <summary>
        /// Returns vec4.wxzyx swizzling.
        /// </summary>
        public vec5 wxzyx => new vec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns vec4.arbgr swizzling (equivalent to vec4.wxzyx).
        /// </summary>
        public vec5 arbgr => new vec5(w, x, z, y, x);
        
        /// <summary>
        /// Returns vec4.wxzyy swizzling.
        /// </summary>
        public vec5 wxzyy => new vec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns vec4.arbgg swizzling (equivalent to vec4.wxzyy).
        /// </summary>
        public vec5 arbgg => new vec5(w, x, z, y, y);
        
        /// <summary>
        /// Returns vec4.wxzyz swizzling.
        /// </summary>
        public vec5 wxzyz => new vec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns vec4.arbgb swizzling (equivalent to vec4.wxzyz).
        /// </summary>
        public vec5 arbgb => new vec5(w, x, z, y, z);
        
        /// <summary>
        /// Returns vec4.wxzyw swizzling.
        /// </summary>
        public vec5 wxzyw => new vec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns vec4.arbga swizzling (equivalent to vec4.wxzyw).
        /// </summary>
        public vec5 arbga => new vec5(w, x, z, y, w);
        
        /// <summary>
        /// Returns vec4.wxzz swizzling.
        /// </summary>
        public vec4 wxzz => new vec4(w, x, z, z);
        
        /// <summary>
        /// Returns vec4.arbb swizzling (equivalent to vec4.wxzz).
        /// </summary>
        public vec4 arbb => new vec4(w, x, z, z);
        
        /// <summary>
        /// Returns vec4.wxzzx swizzling.
        /// </summary>
        public vec5 wxzzx => new vec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns vec4.arbbr swizzling (equivalent to vec4.wxzzx).
        /// </summary>
        public vec5 arbbr => new vec5(w, x, z, z, x);
        
        /// <summary>
        /// Returns vec4.wxzzy swizzling.
        /// </summary>
        public vec5 wxzzy => new vec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns vec4.arbbg swizzling (equivalent to vec4.wxzzy).
        /// </summary>
        public vec5 arbbg => new vec5(w, x, z, z, y);
        
        /// <summary>
        /// Returns vec4.wxzzz swizzling.
        /// </summary>
        public vec5 wxzzz => new vec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns vec4.arbbb swizzling (equivalent to vec4.wxzzz).
        /// </summary>
        public vec5 arbbb => new vec5(w, x, z, z, z);
        
        /// <summary>
        /// Returns vec4.wxzzw swizzling.
        /// </summary>
        public vec5 wxzzw => new vec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns vec4.arbba swizzling (equivalent to vec4.wxzzw).
        /// </summary>
        public vec5 arbba => new vec5(w, x, z, z, w);
        
        /// <summary>
        /// Returns vec4.wxzw swizzling.
        /// </summary>
        public vec4 wxzw => new vec4(w, x, z, w);
        
        /// <summary>
        /// Returns vec4.arba swizzling (equivalent to vec4.wxzw).
        /// </summary>
        public vec4 arba => new vec4(w, x, z, w);
        
        /// <summary>
        /// Returns vec4.wxzwx swizzling.
        /// </summary>
        public vec5 wxzwx => new vec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns vec4.arbar swizzling (equivalent to vec4.wxzwx).
        /// </summary>
        public vec5 arbar => new vec5(w, x, z, w, x);
        
        /// <summary>
        /// Returns vec4.wxzwy swizzling.
        /// </summary>
        public vec5 wxzwy => new vec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns vec4.arbag swizzling (equivalent to vec4.wxzwy).
        /// </summary>
        public vec5 arbag => new vec5(w, x, z, w, y);
        
        /// <summary>
        /// Returns vec4.wxzwz swizzling.
        /// </summary>
        public vec5 wxzwz => new vec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns vec4.arbab swizzling (equivalent to vec4.wxzwz).
        /// </summary>
        public vec5 arbab => new vec5(w, x, z, w, z);
        
        /// <summary>
        /// Returns vec4.wxzww swizzling.
        /// </summary>
        public vec5 wxzww => new vec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns vec4.arbaa swizzling (equivalent to vec4.wxzww).
        /// </summary>
        public vec5 arbaa => new vec5(w, x, z, w, w);
        
        /// <summary>
        /// Returns vec4.wxw swizzling.
        /// </summary>
        public vec3 wxw => new vec3(w, x, w);
        
        /// <summary>
        /// Returns vec4.ara swizzling (equivalent to vec4.wxw).
        /// </summary>
        public vec3 ara => new vec3(w, x, w);
        
        /// <summary>
        /// Returns vec4.wxwx swizzling.
        /// </summary>
        public vec4 wxwx => new vec4(w, x, w, x);
        
        /// <summary>
        /// Returns vec4.arar swizzling (equivalent to vec4.wxwx).
        /// </summary>
        public vec4 arar => new vec4(w, x, w, x);
        
        /// <summary>
        /// Returns vec4.wxwxx swizzling.
        /// </summary>
        public vec5 wxwxx => new vec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns vec4.ararr swizzling (equivalent to vec4.wxwxx).
        /// </summary>
        public vec5 ararr => new vec5(w, x, w, x, x);
        
        /// <summary>
        /// Returns vec4.wxwxy swizzling.
        /// </summary>
        public vec5 wxwxy => new vec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns vec4.ararg swizzling (equivalent to vec4.wxwxy).
        /// </summary>
        public vec5 ararg => new vec5(w, x, w, x, y);
        
        /// <summary>
        /// Returns vec4.wxwxz swizzling.
        /// </summary>
        public vec5 wxwxz => new vec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns vec4.ararb swizzling (equivalent to vec4.wxwxz).
        /// </summary>
        public vec5 ararb => new vec5(w, x, w, x, z);
        
        /// <summary>
        /// Returns vec4.wxwxw swizzling.
        /// </summary>
        public vec5 wxwxw => new vec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns vec4.arara swizzling (equivalent to vec4.wxwxw).
        /// </summary>
        public vec5 arara => new vec5(w, x, w, x, w);
        
        /// <summary>
        /// Returns vec4.wxwy swizzling.
        /// </summary>
        public vec4 wxwy => new vec4(w, x, w, y);
        
        /// <summary>
        /// Returns vec4.arag swizzling (equivalent to vec4.wxwy).
        /// </summary>
        public vec4 arag => new vec4(w, x, w, y);
        
        /// <summary>
        /// Returns vec4.wxwyx swizzling.
        /// </summary>
        public vec5 wxwyx => new vec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns vec4.aragr swizzling (equivalent to vec4.wxwyx).
        /// </summary>
        public vec5 aragr => new vec5(w, x, w, y, x);
        
        /// <summary>
        /// Returns vec4.wxwyy swizzling.
        /// </summary>
        public vec5 wxwyy => new vec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns vec4.aragg swizzling (equivalent to vec4.wxwyy).
        /// </summary>
        public vec5 aragg => new vec5(w, x, w, y, y);
        
        /// <summary>
        /// Returns vec4.wxwyz swizzling.
        /// </summary>
        public vec5 wxwyz => new vec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns vec4.aragb swizzling (equivalent to vec4.wxwyz).
        /// </summary>
        public vec5 aragb => new vec5(w, x, w, y, z);
        
        /// <summary>
        /// Returns vec4.wxwyw swizzling.
        /// </summary>
        public vec5 wxwyw => new vec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns vec4.araga swizzling (equivalent to vec4.wxwyw).
        /// </summary>
        public vec5 araga => new vec5(w, x, w, y, w);
        
        /// <summary>
        /// Returns vec4.wxwz swizzling.
        /// </summary>
        public vec4 wxwz => new vec4(w, x, w, z);
        
        /// <summary>
        /// Returns vec4.arab swizzling (equivalent to vec4.wxwz).
        /// </summary>
        public vec4 arab => new vec4(w, x, w, z);
        
        /// <summary>
        /// Returns vec4.wxwzx swizzling.
        /// </summary>
        public vec5 wxwzx => new vec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns vec4.arabr swizzling (equivalent to vec4.wxwzx).
        /// </summary>
        public vec5 arabr => new vec5(w, x, w, z, x);
        
        /// <summary>
        /// Returns vec4.wxwzy swizzling.
        /// </summary>
        public vec5 wxwzy => new vec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns vec4.arabg swizzling (equivalent to vec4.wxwzy).
        /// </summary>
        public vec5 arabg => new vec5(w, x, w, z, y);
        
        /// <summary>
        /// Returns vec4.wxwzz swizzling.
        /// </summary>
        public vec5 wxwzz => new vec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns vec4.arabb swizzling (equivalent to vec4.wxwzz).
        /// </summary>
        public vec5 arabb => new vec5(w, x, w, z, z);
        
        /// <summary>
        /// Returns vec4.wxwzw swizzling.
        /// </summary>
        public vec5 wxwzw => new vec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns vec4.araba swizzling (equivalent to vec4.wxwzw).
        /// </summary>
        public vec5 araba => new vec5(w, x, w, z, w);
        
        /// <summary>
        /// Returns vec4.wxww swizzling.
        /// </summary>
        public vec4 wxww => new vec4(w, x, w, w);
        
        /// <summary>
        /// Returns vec4.araa swizzling (equivalent to vec4.wxww).
        /// </summary>
        public vec4 araa => new vec4(w, x, w, w);
        
        /// <summary>
        /// Returns vec4.wxwwx swizzling.
        /// </summary>
        public vec5 wxwwx => new vec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns vec4.araar swizzling (equivalent to vec4.wxwwx).
        /// </summary>
        public vec5 araar => new vec5(w, x, w, w, x);
        
        /// <summary>
        /// Returns vec4.wxwwy swizzling.
        /// </summary>
        public vec5 wxwwy => new vec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns vec4.araag swizzling (equivalent to vec4.wxwwy).
        /// </summary>
        public vec5 araag => new vec5(w, x, w, w, y);
        
        /// <summary>
        /// Returns vec4.wxwwz swizzling.
        /// </summary>
        public vec5 wxwwz => new vec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns vec4.araab swizzling (equivalent to vec4.wxwwz).
        /// </summary>
        public vec5 araab => new vec5(w, x, w, w, z);
        
        /// <summary>
        /// Returns vec4.wxwww swizzling.
        /// </summary>
        public vec5 wxwww => new vec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns vec4.araaa swizzling (equivalent to vec4.wxwww).
        /// </summary>
        public vec5 araaa => new vec5(w, x, w, w, w);
        
        /// <summary>
        /// Returns vec4.wy swizzling.
        /// </summary>
        public vec2 wy => new vec2(w, y);
        
        /// <summary>
        /// Returns vec4.ag swizzling (equivalent to vec4.wy).
        /// </summary>
        public vec2 ag => new vec2(w, y);
        
        /// <summary>
        /// Returns vec4.wyx swizzling.
        /// </summary>
        public vec3 wyx => new vec3(w, y, x);
        
        /// <summary>
        /// Returns vec4.agr swizzling (equivalent to vec4.wyx).
        /// </summary>
        public vec3 agr => new vec3(w, y, x);
        
        /// <summary>
        /// Returns vec4.wyxx swizzling.
        /// </summary>
        public vec4 wyxx => new vec4(w, y, x, x);
        
        /// <summary>
        /// Returns vec4.agrr swizzling (equivalent to vec4.wyxx).
        /// </summary>
        public vec4 agrr => new vec4(w, y, x, x);
        
        /// <summary>
        /// Returns vec4.wyxxx swizzling.
        /// </summary>
        public vec5 wyxxx => new vec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns vec4.agrrr swizzling (equivalent to vec4.wyxxx).
        /// </summary>
        public vec5 agrrr => new vec5(w, y, x, x, x);
        
        /// <summary>
        /// Returns vec4.wyxxy swizzling.
        /// </summary>
        public vec5 wyxxy => new vec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns vec4.agrrg swizzling (equivalent to vec4.wyxxy).
        /// </summary>
        public vec5 agrrg => new vec5(w, y, x, x, y);
        
        /// <summary>
        /// Returns vec4.wyxxz swizzling.
        /// </summary>
        public vec5 wyxxz => new vec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns vec4.agrrb swizzling (equivalent to vec4.wyxxz).
        /// </summary>
        public vec5 agrrb => new vec5(w, y, x, x, z);
        
        /// <summary>
        /// Returns vec4.wyxxw swizzling.
        /// </summary>
        public vec5 wyxxw => new vec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns vec4.agrra swizzling (equivalent to vec4.wyxxw).
        /// </summary>
        public vec5 agrra => new vec5(w, y, x, x, w);
        
        /// <summary>
        /// Returns vec4.wyxy swizzling.
        /// </summary>
        public vec4 wyxy => new vec4(w, y, x, y);
        
        /// <summary>
        /// Returns vec4.agrg swizzling (equivalent to vec4.wyxy).
        /// </summary>
        public vec4 agrg => new vec4(w, y, x, y);
        
        /// <summary>
        /// Returns vec4.wyxyx swizzling.
        /// </summary>
        public vec5 wyxyx => new vec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns vec4.agrgr swizzling (equivalent to vec4.wyxyx).
        /// </summary>
        public vec5 agrgr => new vec5(w, y, x, y, x);
        
        /// <summary>
        /// Returns vec4.wyxyy swizzling.
        /// </summary>
        public vec5 wyxyy => new vec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns vec4.agrgg swizzling (equivalent to vec4.wyxyy).
        /// </summary>
        public vec5 agrgg => new vec5(w, y, x, y, y);
        
        /// <summary>
        /// Returns vec4.wyxyz swizzling.
        /// </summary>
        public vec5 wyxyz => new vec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns vec4.agrgb swizzling (equivalent to vec4.wyxyz).
        /// </summary>
        public vec5 agrgb => new vec5(w, y, x, y, z);
        
        /// <summary>
        /// Returns vec4.wyxyw swizzling.
        /// </summary>
        public vec5 wyxyw => new vec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns vec4.agrga swizzling (equivalent to vec4.wyxyw).
        /// </summary>
        public vec5 agrga => new vec5(w, y, x, y, w);
        
        /// <summary>
        /// Returns vec4.wyxz swizzling.
        /// </summary>
        public vec4 wyxz => new vec4(w, y, x, z);
        
        /// <summary>
        /// Returns vec4.agrb swizzling (equivalent to vec4.wyxz).
        /// </summary>
        public vec4 agrb => new vec4(w, y, x, z);
        
        /// <summary>
        /// Returns vec4.wyxzx swizzling.
        /// </summary>
        public vec5 wyxzx => new vec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns vec4.agrbr swizzling (equivalent to vec4.wyxzx).
        /// </summary>
        public vec5 agrbr => new vec5(w, y, x, z, x);
        
        /// <summary>
        /// Returns vec4.wyxzy swizzling.
        /// </summary>
        public vec5 wyxzy => new vec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns vec4.agrbg swizzling (equivalent to vec4.wyxzy).
        /// </summary>
        public vec5 agrbg => new vec5(w, y, x, z, y);
        
        /// <summary>
        /// Returns vec4.wyxzz swizzling.
        /// </summary>
        public vec5 wyxzz => new vec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns vec4.agrbb swizzling (equivalent to vec4.wyxzz).
        /// </summary>
        public vec5 agrbb => new vec5(w, y, x, z, z);
        
        /// <summary>
        /// Returns vec4.wyxzw swizzling.
        /// </summary>
        public vec5 wyxzw => new vec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns vec4.agrba swizzling (equivalent to vec4.wyxzw).
        /// </summary>
        public vec5 agrba => new vec5(w, y, x, z, w);
        
        /// <summary>
        /// Returns vec4.wyxw swizzling.
        /// </summary>
        public vec4 wyxw => new vec4(w, y, x, w);
        
        /// <summary>
        /// Returns vec4.agra swizzling (equivalent to vec4.wyxw).
        /// </summary>
        public vec4 agra => new vec4(w, y, x, w);
        
        /// <summary>
        /// Returns vec4.wyxwx swizzling.
        /// </summary>
        public vec5 wyxwx => new vec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns vec4.agrar swizzling (equivalent to vec4.wyxwx).
        /// </summary>
        public vec5 agrar => new vec5(w, y, x, w, x);
        
        /// <summary>
        /// Returns vec4.wyxwy swizzling.
        /// </summary>
        public vec5 wyxwy => new vec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns vec4.agrag swizzling (equivalent to vec4.wyxwy).
        /// </summary>
        public vec5 agrag => new vec5(w, y, x, w, y);
        
        /// <summary>
        /// Returns vec4.wyxwz swizzling.
        /// </summary>
        public vec5 wyxwz => new vec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns vec4.agrab swizzling (equivalent to vec4.wyxwz).
        /// </summary>
        public vec5 agrab => new vec5(w, y, x, w, z);
        
        /// <summary>
        /// Returns vec4.wyxww swizzling.
        /// </summary>
        public vec5 wyxww => new vec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns vec4.agraa swizzling (equivalent to vec4.wyxww).
        /// </summary>
        public vec5 agraa => new vec5(w, y, x, w, w);
        
        /// <summary>
        /// Returns vec4.wyy swizzling.
        /// </summary>
        public vec3 wyy => new vec3(w, y, y);
        
        /// <summary>
        /// Returns vec4.agg swizzling (equivalent to vec4.wyy).
        /// </summary>
        public vec3 agg => new vec3(w, y, y);
        
        /// <summary>
        /// Returns vec4.wyyx swizzling.
        /// </summary>
        public vec4 wyyx => new vec4(w, y, y, x);
        
        /// <summary>
        /// Returns vec4.aggr swizzling (equivalent to vec4.wyyx).
        /// </summary>
        public vec4 aggr => new vec4(w, y, y, x);
        
        /// <summary>
        /// Returns vec4.wyyxx swizzling.
        /// </summary>
        public vec5 wyyxx => new vec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns vec4.aggrr swizzling (equivalent to vec4.wyyxx).
        /// </summary>
        public vec5 aggrr => new vec5(w, y, y, x, x);
        
        /// <summary>
        /// Returns vec4.wyyxy swizzling.
        /// </summary>
        public vec5 wyyxy => new vec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns vec4.aggrg swizzling (equivalent to vec4.wyyxy).
        /// </summary>
        public vec5 aggrg => new vec5(w, y, y, x, y);
        
        /// <summary>
        /// Returns vec4.wyyxz swizzling.
        /// </summary>
        public vec5 wyyxz => new vec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns vec4.aggrb swizzling (equivalent to vec4.wyyxz).
        /// </summary>
        public vec5 aggrb => new vec5(w, y, y, x, z);
        
        /// <summary>
        /// Returns vec4.wyyxw swizzling.
        /// </summary>
        public vec5 wyyxw => new vec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns vec4.aggra swizzling (equivalent to vec4.wyyxw).
        /// </summary>
        public vec5 aggra => new vec5(w, y, y, x, w);
        
        /// <summary>
        /// Returns vec4.wyyy swizzling.
        /// </summary>
        public vec4 wyyy => new vec4(w, y, y, y);
        
        /// <summary>
        /// Returns vec4.aggg swizzling (equivalent to vec4.wyyy).
        /// </summary>
        public vec4 aggg => new vec4(w, y, y, y);
        
        /// <summary>
        /// Returns vec4.wyyyx swizzling.
        /// </summary>
        public vec5 wyyyx => new vec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns vec4.agggr swizzling (equivalent to vec4.wyyyx).
        /// </summary>
        public vec5 agggr => new vec5(w, y, y, y, x);
        
        /// <summary>
        /// Returns vec4.wyyyy swizzling.
        /// </summary>
        public vec5 wyyyy => new vec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns vec4.agggg swizzling (equivalent to vec4.wyyyy).
        /// </summary>
        public vec5 agggg => new vec5(w, y, y, y, y);
        
        /// <summary>
        /// Returns vec4.wyyyz swizzling.
        /// </summary>
        public vec5 wyyyz => new vec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns vec4.agggb swizzling (equivalent to vec4.wyyyz).
        /// </summary>
        public vec5 agggb => new vec5(w, y, y, y, z);
        
        /// <summary>
        /// Returns vec4.wyyyw swizzling.
        /// </summary>
        public vec5 wyyyw => new vec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns vec4.aggga swizzling (equivalent to vec4.wyyyw).
        /// </summary>
        public vec5 aggga => new vec5(w, y, y, y, w);
        
        /// <summary>
        /// Returns vec4.wyyz swizzling.
        /// </summary>
        public vec4 wyyz => new vec4(w, y, y, z);
        
        /// <summary>
        /// Returns vec4.aggb swizzling (equivalent to vec4.wyyz).
        /// </summary>
        public vec4 aggb => new vec4(w, y, y, z);
        
        /// <summary>
        /// Returns vec4.wyyzx swizzling.
        /// </summary>
        public vec5 wyyzx => new vec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns vec4.aggbr swizzling (equivalent to vec4.wyyzx).
        /// </summary>
        public vec5 aggbr => new vec5(w, y, y, z, x);
        
        /// <summary>
        /// Returns vec4.wyyzy swizzling.
        /// </summary>
        public vec5 wyyzy => new vec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns vec4.aggbg swizzling (equivalent to vec4.wyyzy).
        /// </summary>
        public vec5 aggbg => new vec5(w, y, y, z, y);
        
        /// <summary>
        /// Returns vec4.wyyzz swizzling.
        /// </summary>
        public vec5 wyyzz => new vec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns vec4.aggbb swizzling (equivalent to vec4.wyyzz).
        /// </summary>
        public vec5 aggbb => new vec5(w, y, y, z, z);
        
        /// <summary>
        /// Returns vec4.wyyzw swizzling.
        /// </summary>
        public vec5 wyyzw => new vec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns vec4.aggba swizzling (equivalent to vec4.wyyzw).
        /// </summary>
        public vec5 aggba => new vec5(w, y, y, z, w);
        
        /// <summary>
        /// Returns vec4.wyyw swizzling.
        /// </summary>
        public vec4 wyyw => new vec4(w, y, y, w);
        
        /// <summary>
        /// Returns vec4.agga swizzling (equivalent to vec4.wyyw).
        /// </summary>
        public vec4 agga => new vec4(w, y, y, w);
        
        /// <summary>
        /// Returns vec4.wyywx swizzling.
        /// </summary>
        public vec5 wyywx => new vec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns vec4.aggar swizzling (equivalent to vec4.wyywx).
        /// </summary>
        public vec5 aggar => new vec5(w, y, y, w, x);
        
        /// <summary>
        /// Returns vec4.wyywy swizzling.
        /// </summary>
        public vec5 wyywy => new vec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns vec4.aggag swizzling (equivalent to vec4.wyywy).
        /// </summary>
        public vec5 aggag => new vec5(w, y, y, w, y);
        
        /// <summary>
        /// Returns vec4.wyywz swizzling.
        /// </summary>
        public vec5 wyywz => new vec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns vec4.aggab swizzling (equivalent to vec4.wyywz).
        /// </summary>
        public vec5 aggab => new vec5(w, y, y, w, z);
        
        /// <summary>
        /// Returns vec4.wyyww swizzling.
        /// </summary>
        public vec5 wyyww => new vec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns vec4.aggaa swizzling (equivalent to vec4.wyyww).
        /// </summary>
        public vec5 aggaa => new vec5(w, y, y, w, w);
        
        /// <summary>
        /// Returns vec4.wyz swizzling.
        /// </summary>
        public vec3 wyz => new vec3(w, y, z);
        
        /// <summary>
        /// Returns vec4.agb swizzling (equivalent to vec4.wyz).
        /// </summary>
        public vec3 agb => new vec3(w, y, z);
        
        /// <summary>
        /// Returns vec4.wyzx swizzling.
        /// </summary>
        public vec4 wyzx => new vec4(w, y, z, x);
        
        /// <summary>
        /// Returns vec4.agbr swizzling (equivalent to vec4.wyzx).
        /// </summary>
        public vec4 agbr => new vec4(w, y, z, x);
        
        /// <summary>
        /// Returns vec4.wyzxx swizzling.
        /// </summary>
        public vec5 wyzxx => new vec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns vec4.agbrr swizzling (equivalent to vec4.wyzxx).
        /// </summary>
        public vec5 agbrr => new vec5(w, y, z, x, x);
        
        /// <summary>
        /// Returns vec4.wyzxy swizzling.
        /// </summary>
        public vec5 wyzxy => new vec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns vec4.agbrg swizzling (equivalent to vec4.wyzxy).
        /// </summary>
        public vec5 agbrg => new vec5(w, y, z, x, y);
        
        /// <summary>
        /// Returns vec4.wyzxz swizzling.
        /// </summary>
        public vec5 wyzxz => new vec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns vec4.agbrb swizzling (equivalent to vec4.wyzxz).
        /// </summary>
        public vec5 agbrb => new vec5(w, y, z, x, z);
        
        /// <summary>
        /// Returns vec4.wyzxw swizzling.
        /// </summary>
        public vec5 wyzxw => new vec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns vec4.agbra swizzling (equivalent to vec4.wyzxw).
        /// </summary>
        public vec5 agbra => new vec5(w, y, z, x, w);
        
        /// <summary>
        /// Returns vec4.wyzy swizzling.
        /// </summary>
        public vec4 wyzy => new vec4(w, y, z, y);
        
        /// <summary>
        /// Returns vec4.agbg swizzling (equivalent to vec4.wyzy).
        /// </summary>
        public vec4 agbg => new vec4(w, y, z, y);
        
        /// <summary>
        /// Returns vec4.wyzyx swizzling.
        /// </summary>
        public vec5 wyzyx => new vec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns vec4.agbgr swizzling (equivalent to vec4.wyzyx).
        /// </summary>
        public vec5 agbgr => new vec5(w, y, z, y, x);
        
        /// <summary>
        /// Returns vec4.wyzyy swizzling.
        /// </summary>
        public vec5 wyzyy => new vec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns vec4.agbgg swizzling (equivalent to vec4.wyzyy).
        /// </summary>
        public vec5 agbgg => new vec5(w, y, z, y, y);
        
        /// <summary>
        /// Returns vec4.wyzyz swizzling.
        /// </summary>
        public vec5 wyzyz => new vec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns vec4.agbgb swizzling (equivalent to vec4.wyzyz).
        /// </summary>
        public vec5 agbgb => new vec5(w, y, z, y, z);
        
        /// <summary>
        /// Returns vec4.wyzyw swizzling.
        /// </summary>
        public vec5 wyzyw => new vec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns vec4.agbga swizzling (equivalent to vec4.wyzyw).
        /// </summary>
        public vec5 agbga => new vec5(w, y, z, y, w);
        
        /// <summary>
        /// Returns vec4.wyzz swizzling.
        /// </summary>
        public vec4 wyzz => new vec4(w, y, z, z);
        
        /// <summary>
        /// Returns vec4.agbb swizzling (equivalent to vec4.wyzz).
        /// </summary>
        public vec4 agbb => new vec4(w, y, z, z);
        
        /// <summary>
        /// Returns vec4.wyzzx swizzling.
        /// </summary>
        public vec5 wyzzx => new vec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns vec4.agbbr swizzling (equivalent to vec4.wyzzx).
        /// </summary>
        public vec5 agbbr => new vec5(w, y, z, z, x);
        
        /// <summary>
        /// Returns vec4.wyzzy swizzling.
        /// </summary>
        public vec5 wyzzy => new vec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns vec4.agbbg swizzling (equivalent to vec4.wyzzy).
        /// </summary>
        public vec5 agbbg => new vec5(w, y, z, z, y);
        
        /// <summary>
        /// Returns vec4.wyzzz swizzling.
        /// </summary>
        public vec5 wyzzz => new vec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns vec4.agbbb swizzling (equivalent to vec4.wyzzz).
        /// </summary>
        public vec5 agbbb => new vec5(w, y, z, z, z);
        
        /// <summary>
        /// Returns vec4.wyzzw swizzling.
        /// </summary>
        public vec5 wyzzw => new vec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns vec4.agbba swizzling (equivalent to vec4.wyzzw).
        /// </summary>
        public vec5 agbba => new vec5(w, y, z, z, w);
        
        /// <summary>
        /// Returns vec4.wyzw swizzling.
        /// </summary>
        public vec4 wyzw => new vec4(w, y, z, w);
        
        /// <summary>
        /// Returns vec4.agba swizzling (equivalent to vec4.wyzw).
        /// </summary>
        public vec4 agba => new vec4(w, y, z, w);
        
        /// <summary>
        /// Returns vec4.wyzwx swizzling.
        /// </summary>
        public vec5 wyzwx => new vec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns vec4.agbar swizzling (equivalent to vec4.wyzwx).
        /// </summary>
        public vec5 agbar => new vec5(w, y, z, w, x);
        
        /// <summary>
        /// Returns vec4.wyzwy swizzling.
        /// </summary>
        public vec5 wyzwy => new vec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns vec4.agbag swizzling (equivalent to vec4.wyzwy).
        /// </summary>
        public vec5 agbag => new vec5(w, y, z, w, y);
        
        /// <summary>
        /// Returns vec4.wyzwz swizzling.
        /// </summary>
        public vec5 wyzwz => new vec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns vec4.agbab swizzling (equivalent to vec4.wyzwz).
        /// </summary>
        public vec5 agbab => new vec5(w, y, z, w, z);
        
        /// <summary>
        /// Returns vec4.wyzww swizzling.
        /// </summary>
        public vec5 wyzww => new vec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns vec4.agbaa swizzling (equivalent to vec4.wyzww).
        /// </summary>
        public vec5 agbaa => new vec5(w, y, z, w, w);
        
        /// <summary>
        /// Returns vec4.wyw swizzling.
        /// </summary>
        public vec3 wyw => new vec3(w, y, w);
        
        /// <summary>
        /// Returns vec4.aga swizzling (equivalent to vec4.wyw).
        /// </summary>
        public vec3 aga => new vec3(w, y, w);
        
        /// <summary>
        /// Returns vec4.wywx swizzling.
        /// </summary>
        public vec4 wywx => new vec4(w, y, w, x);
        
        /// <summary>
        /// Returns vec4.agar swizzling (equivalent to vec4.wywx).
        /// </summary>
        public vec4 agar => new vec4(w, y, w, x);
        
        /// <summary>
        /// Returns vec4.wywxx swizzling.
        /// </summary>
        public vec5 wywxx => new vec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns vec4.agarr swizzling (equivalent to vec4.wywxx).
        /// </summary>
        public vec5 agarr => new vec5(w, y, w, x, x);
        
        /// <summary>
        /// Returns vec4.wywxy swizzling.
        /// </summary>
        public vec5 wywxy => new vec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns vec4.agarg swizzling (equivalent to vec4.wywxy).
        /// </summary>
        public vec5 agarg => new vec5(w, y, w, x, y);
        
        /// <summary>
        /// Returns vec4.wywxz swizzling.
        /// </summary>
        public vec5 wywxz => new vec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns vec4.agarb swizzling (equivalent to vec4.wywxz).
        /// </summary>
        public vec5 agarb => new vec5(w, y, w, x, z);
        
        /// <summary>
        /// Returns vec4.wywxw swizzling.
        /// </summary>
        public vec5 wywxw => new vec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns vec4.agara swizzling (equivalent to vec4.wywxw).
        /// </summary>
        public vec5 agara => new vec5(w, y, w, x, w);
        
        /// <summary>
        /// Returns vec4.wywy swizzling.
        /// </summary>
        public vec4 wywy => new vec4(w, y, w, y);
        
        /// <summary>
        /// Returns vec4.agag swizzling (equivalent to vec4.wywy).
        /// </summary>
        public vec4 agag => new vec4(w, y, w, y);
        
        /// <summary>
        /// Returns vec4.wywyx swizzling.
        /// </summary>
        public vec5 wywyx => new vec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns vec4.agagr swizzling (equivalent to vec4.wywyx).
        /// </summary>
        public vec5 agagr => new vec5(w, y, w, y, x);
        
        /// <summary>
        /// Returns vec4.wywyy swizzling.
        /// </summary>
        public vec5 wywyy => new vec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns vec4.agagg swizzling (equivalent to vec4.wywyy).
        /// </summary>
        public vec5 agagg => new vec5(w, y, w, y, y);
        
        /// <summary>
        /// Returns vec4.wywyz swizzling.
        /// </summary>
        public vec5 wywyz => new vec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns vec4.agagb swizzling (equivalent to vec4.wywyz).
        /// </summary>
        public vec5 agagb => new vec5(w, y, w, y, z);
        
        /// <summary>
        /// Returns vec4.wywyw swizzling.
        /// </summary>
        public vec5 wywyw => new vec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns vec4.agaga swizzling (equivalent to vec4.wywyw).
        /// </summary>
        public vec5 agaga => new vec5(w, y, w, y, w);
        
        /// <summary>
        /// Returns vec4.wywz swizzling.
        /// </summary>
        public vec4 wywz => new vec4(w, y, w, z);
        
        /// <summary>
        /// Returns vec4.agab swizzling (equivalent to vec4.wywz).
        /// </summary>
        public vec4 agab => new vec4(w, y, w, z);
        
        /// <summary>
        /// Returns vec4.wywzx swizzling.
        /// </summary>
        public vec5 wywzx => new vec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns vec4.agabr swizzling (equivalent to vec4.wywzx).
        /// </summary>
        public vec5 agabr => new vec5(w, y, w, z, x);
        
        /// <summary>
        /// Returns vec4.wywzy swizzling.
        /// </summary>
        public vec5 wywzy => new vec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns vec4.agabg swizzling (equivalent to vec4.wywzy).
        /// </summary>
        public vec5 agabg => new vec5(w, y, w, z, y);
        
        /// <summary>
        /// Returns vec4.wywzz swizzling.
        /// </summary>
        public vec5 wywzz => new vec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns vec4.agabb swizzling (equivalent to vec4.wywzz).
        /// </summary>
        public vec5 agabb => new vec5(w, y, w, z, z);
        
        /// <summary>
        /// Returns vec4.wywzw swizzling.
        /// </summary>
        public vec5 wywzw => new vec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns vec4.agaba swizzling (equivalent to vec4.wywzw).
        /// </summary>
        public vec5 agaba => new vec5(w, y, w, z, w);
        
        /// <summary>
        /// Returns vec4.wyww swizzling.
        /// </summary>
        public vec4 wyww => new vec4(w, y, w, w);
        
        /// <summary>
        /// Returns vec4.agaa swizzling (equivalent to vec4.wyww).
        /// </summary>
        public vec4 agaa => new vec4(w, y, w, w);
        
        /// <summary>
        /// Returns vec4.wywwx swizzling.
        /// </summary>
        public vec5 wywwx => new vec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns vec4.agaar swizzling (equivalent to vec4.wywwx).
        /// </summary>
        public vec5 agaar => new vec5(w, y, w, w, x);
        
        /// <summary>
        /// Returns vec4.wywwy swizzling.
        /// </summary>
        public vec5 wywwy => new vec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns vec4.agaag swizzling (equivalent to vec4.wywwy).
        /// </summary>
        public vec5 agaag => new vec5(w, y, w, w, y);
        
        /// <summary>
        /// Returns vec4.wywwz swizzling.
        /// </summary>
        public vec5 wywwz => new vec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns vec4.agaab swizzling (equivalent to vec4.wywwz).
        /// </summary>
        public vec5 agaab => new vec5(w, y, w, w, z);
        
        /// <summary>
        /// Returns vec4.wywww swizzling.
        /// </summary>
        public vec5 wywww => new vec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns vec4.agaaa swizzling (equivalent to vec4.wywww).
        /// </summary>
        public vec5 agaaa => new vec5(w, y, w, w, w);
        
        /// <summary>
        /// Returns vec4.wz swizzling.
        /// </summary>
        public vec2 wz => new vec2(w, z);
        
        /// <summary>
        /// Returns vec4.ab swizzling (equivalent to vec4.wz).
        /// </summary>
        public vec2 ab => new vec2(w, z);
        
        /// <summary>
        /// Returns vec4.wzx swizzling.
        /// </summary>
        public vec3 wzx => new vec3(w, z, x);
        
        /// <summary>
        /// Returns vec4.abr swizzling (equivalent to vec4.wzx).
        /// </summary>
        public vec3 abr => new vec3(w, z, x);
        
        /// <summary>
        /// Returns vec4.wzxx swizzling.
        /// </summary>
        public vec4 wzxx => new vec4(w, z, x, x);
        
        /// <summary>
        /// Returns vec4.abrr swizzling (equivalent to vec4.wzxx).
        /// </summary>
        public vec4 abrr => new vec4(w, z, x, x);
        
        /// <summary>
        /// Returns vec4.wzxxx swizzling.
        /// </summary>
        public vec5 wzxxx => new vec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns vec4.abrrr swizzling (equivalent to vec4.wzxxx).
        /// </summary>
        public vec5 abrrr => new vec5(w, z, x, x, x);
        
        /// <summary>
        /// Returns vec4.wzxxy swizzling.
        /// </summary>
        public vec5 wzxxy => new vec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns vec4.abrrg swizzling (equivalent to vec4.wzxxy).
        /// </summary>
        public vec5 abrrg => new vec5(w, z, x, x, y);
        
        /// <summary>
        /// Returns vec4.wzxxz swizzling.
        /// </summary>
        public vec5 wzxxz => new vec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns vec4.abrrb swizzling (equivalent to vec4.wzxxz).
        /// </summary>
        public vec5 abrrb => new vec5(w, z, x, x, z);
        
        /// <summary>
        /// Returns vec4.wzxxw swizzling.
        /// </summary>
        public vec5 wzxxw => new vec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns vec4.abrra swizzling (equivalent to vec4.wzxxw).
        /// </summary>
        public vec5 abrra => new vec5(w, z, x, x, w);
        
        /// <summary>
        /// Returns vec4.wzxy swizzling.
        /// </summary>
        public vec4 wzxy => new vec4(w, z, x, y);
        
        /// <summary>
        /// Returns vec4.abrg swizzling (equivalent to vec4.wzxy).
        /// </summary>
        public vec4 abrg => new vec4(w, z, x, y);
        
        /// <summary>
        /// Returns vec4.wzxyx swizzling.
        /// </summary>
        public vec5 wzxyx => new vec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns vec4.abrgr swizzling (equivalent to vec4.wzxyx).
        /// </summary>
        public vec5 abrgr => new vec5(w, z, x, y, x);
        
        /// <summary>
        /// Returns vec4.wzxyy swizzling.
        /// </summary>
        public vec5 wzxyy => new vec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns vec4.abrgg swizzling (equivalent to vec4.wzxyy).
        /// </summary>
        public vec5 abrgg => new vec5(w, z, x, y, y);
        
        /// <summary>
        /// Returns vec4.wzxyz swizzling.
        /// </summary>
        public vec5 wzxyz => new vec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns vec4.abrgb swizzling (equivalent to vec4.wzxyz).
        /// </summary>
        public vec5 abrgb => new vec5(w, z, x, y, z);
        
        /// <summary>
        /// Returns vec4.wzxyw swizzling.
        /// </summary>
        public vec5 wzxyw => new vec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns vec4.abrga swizzling (equivalent to vec4.wzxyw).
        /// </summary>
        public vec5 abrga => new vec5(w, z, x, y, w);
        
        /// <summary>
        /// Returns vec4.wzxz swizzling.
        /// </summary>
        public vec4 wzxz => new vec4(w, z, x, z);
        
        /// <summary>
        /// Returns vec4.abrb swizzling (equivalent to vec4.wzxz).
        /// </summary>
        public vec4 abrb => new vec4(w, z, x, z);
        
        /// <summary>
        /// Returns vec4.wzxzx swizzling.
        /// </summary>
        public vec5 wzxzx => new vec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns vec4.abrbr swizzling (equivalent to vec4.wzxzx).
        /// </summary>
        public vec5 abrbr => new vec5(w, z, x, z, x);
        
        /// <summary>
        /// Returns vec4.wzxzy swizzling.
        /// </summary>
        public vec5 wzxzy => new vec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns vec4.abrbg swizzling (equivalent to vec4.wzxzy).
        /// </summary>
        public vec5 abrbg => new vec5(w, z, x, z, y);
        
        /// <summary>
        /// Returns vec4.wzxzz swizzling.
        /// </summary>
        public vec5 wzxzz => new vec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns vec4.abrbb swizzling (equivalent to vec4.wzxzz).
        /// </summary>
        public vec5 abrbb => new vec5(w, z, x, z, z);
        
        /// <summary>
        /// Returns vec4.wzxzw swizzling.
        /// </summary>
        public vec5 wzxzw => new vec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns vec4.abrba swizzling (equivalent to vec4.wzxzw).
        /// </summary>
        public vec5 abrba => new vec5(w, z, x, z, w);
        
        /// <summary>
        /// Returns vec4.wzxw swizzling.
        /// </summary>
        public vec4 wzxw => new vec4(w, z, x, w);
        
        /// <summary>
        /// Returns vec4.abra swizzling (equivalent to vec4.wzxw).
        /// </summary>
        public vec4 abra => new vec4(w, z, x, w);
        
        /// <summary>
        /// Returns vec4.wzxwx swizzling.
        /// </summary>
        public vec5 wzxwx => new vec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns vec4.abrar swizzling (equivalent to vec4.wzxwx).
        /// </summary>
        public vec5 abrar => new vec5(w, z, x, w, x);
        
        /// <summary>
        /// Returns vec4.wzxwy swizzling.
        /// </summary>
        public vec5 wzxwy => new vec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns vec4.abrag swizzling (equivalent to vec4.wzxwy).
        /// </summary>
        public vec5 abrag => new vec5(w, z, x, w, y);
        
        /// <summary>
        /// Returns vec4.wzxwz swizzling.
        /// </summary>
        public vec5 wzxwz => new vec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns vec4.abrab swizzling (equivalent to vec4.wzxwz).
        /// </summary>
        public vec5 abrab => new vec5(w, z, x, w, z);
        
        /// <summary>
        /// Returns vec4.wzxww swizzling.
        /// </summary>
        public vec5 wzxww => new vec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns vec4.abraa swizzling (equivalent to vec4.wzxww).
        /// </summary>
        public vec5 abraa => new vec5(w, z, x, w, w);
        
        /// <summary>
        /// Returns vec4.wzy swizzling.
        /// </summary>
        public vec3 wzy => new vec3(w, z, y);
        
        /// <summary>
        /// Returns vec4.abg swizzling (equivalent to vec4.wzy).
        /// </summary>
        public vec3 abg => new vec3(w, z, y);
        
        /// <summary>
        /// Returns vec4.wzyx swizzling.
        /// </summary>
        public vec4 wzyx => new vec4(w, z, y, x);
        
        /// <summary>
        /// Returns vec4.abgr swizzling (equivalent to vec4.wzyx).
        /// </summary>
        public vec4 abgr => new vec4(w, z, y, x);
        
        /// <summary>
        /// Returns vec4.wzyxx swizzling.
        /// </summary>
        public vec5 wzyxx => new vec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns vec4.abgrr swizzling (equivalent to vec4.wzyxx).
        /// </summary>
        public vec5 abgrr => new vec5(w, z, y, x, x);
        
        /// <summary>
        /// Returns vec4.wzyxy swizzling.
        /// </summary>
        public vec5 wzyxy => new vec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns vec4.abgrg swizzling (equivalent to vec4.wzyxy).
        /// </summary>
        public vec5 abgrg => new vec5(w, z, y, x, y);
        
        /// <summary>
        /// Returns vec4.wzyxz swizzling.
        /// </summary>
        public vec5 wzyxz => new vec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns vec4.abgrb swizzling (equivalent to vec4.wzyxz).
        /// </summary>
        public vec5 abgrb => new vec5(w, z, y, x, z);
        
        /// <summary>
        /// Returns vec4.wzyxw swizzling.
        /// </summary>
        public vec5 wzyxw => new vec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns vec4.abgra swizzling (equivalent to vec4.wzyxw).
        /// </summary>
        public vec5 abgra => new vec5(w, z, y, x, w);
        
        /// <summary>
        /// Returns vec4.wzyy swizzling.
        /// </summary>
        public vec4 wzyy => new vec4(w, z, y, y);
        
        /// <summary>
        /// Returns vec4.abgg swizzling (equivalent to vec4.wzyy).
        /// </summary>
        public vec4 abgg => new vec4(w, z, y, y);
        
        /// <summary>
        /// Returns vec4.wzyyx swizzling.
        /// </summary>
        public vec5 wzyyx => new vec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns vec4.abggr swizzling (equivalent to vec4.wzyyx).
        /// </summary>
        public vec5 abggr => new vec5(w, z, y, y, x);
        
        /// <summary>
        /// Returns vec4.wzyyy swizzling.
        /// </summary>
        public vec5 wzyyy => new vec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns vec4.abggg swizzling (equivalent to vec4.wzyyy).
        /// </summary>
        public vec5 abggg => new vec5(w, z, y, y, y);
        
        /// <summary>
        /// Returns vec4.wzyyz swizzling.
        /// </summary>
        public vec5 wzyyz => new vec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns vec4.abggb swizzling (equivalent to vec4.wzyyz).
        /// </summary>
        public vec5 abggb => new vec5(w, z, y, y, z);
        
        /// <summary>
        /// Returns vec4.wzyyw swizzling.
        /// </summary>
        public vec5 wzyyw => new vec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns vec4.abgga swizzling (equivalent to vec4.wzyyw).
        /// </summary>
        public vec5 abgga => new vec5(w, z, y, y, w);
        
        /// <summary>
        /// Returns vec4.wzyz swizzling.
        /// </summary>
        public vec4 wzyz => new vec4(w, z, y, z);
        
        /// <summary>
        /// Returns vec4.abgb swizzling (equivalent to vec4.wzyz).
        /// </summary>
        public vec4 abgb => new vec4(w, z, y, z);
        
        /// <summary>
        /// Returns vec4.wzyzx swizzling.
        /// </summary>
        public vec5 wzyzx => new vec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns vec4.abgbr swizzling (equivalent to vec4.wzyzx).
        /// </summary>
        public vec5 abgbr => new vec5(w, z, y, z, x);
        
        /// <summary>
        /// Returns vec4.wzyzy swizzling.
        /// </summary>
        public vec5 wzyzy => new vec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns vec4.abgbg swizzling (equivalent to vec4.wzyzy).
        /// </summary>
        public vec5 abgbg => new vec5(w, z, y, z, y);
        
        /// <summary>
        /// Returns vec4.wzyzz swizzling.
        /// </summary>
        public vec5 wzyzz => new vec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns vec4.abgbb swizzling (equivalent to vec4.wzyzz).
        /// </summary>
        public vec5 abgbb => new vec5(w, z, y, z, z);
        
        /// <summary>
        /// Returns vec4.wzyzw swizzling.
        /// </summary>
        public vec5 wzyzw => new vec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns vec4.abgba swizzling (equivalent to vec4.wzyzw).
        /// </summary>
        public vec5 abgba => new vec5(w, z, y, z, w);
        
        /// <summary>
        /// Returns vec4.wzyw swizzling.
        /// </summary>
        public vec4 wzyw => new vec4(w, z, y, w);
        
        /// <summary>
        /// Returns vec4.abga swizzling (equivalent to vec4.wzyw).
        /// </summary>
        public vec4 abga => new vec4(w, z, y, w);
        
        /// <summary>
        /// Returns vec4.wzywx swizzling.
        /// </summary>
        public vec5 wzywx => new vec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns vec4.abgar swizzling (equivalent to vec4.wzywx).
        /// </summary>
        public vec5 abgar => new vec5(w, z, y, w, x);
        
        /// <summary>
        /// Returns vec4.wzywy swizzling.
        /// </summary>
        public vec5 wzywy => new vec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns vec4.abgag swizzling (equivalent to vec4.wzywy).
        /// </summary>
        public vec5 abgag => new vec5(w, z, y, w, y);
        
        /// <summary>
        /// Returns vec4.wzywz swizzling.
        /// </summary>
        public vec5 wzywz => new vec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns vec4.abgab swizzling (equivalent to vec4.wzywz).
        /// </summary>
        public vec5 abgab => new vec5(w, z, y, w, z);
        
        /// <summary>
        /// Returns vec4.wzyww swizzling.
        /// </summary>
        public vec5 wzyww => new vec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns vec4.abgaa swizzling (equivalent to vec4.wzyww).
        /// </summary>
        public vec5 abgaa => new vec5(w, z, y, w, w);
        
        /// <summary>
        /// Returns vec4.wzz swizzling.
        /// </summary>
        public vec3 wzz => new vec3(w, z, z);
        
        /// <summary>
        /// Returns vec4.abb swizzling (equivalent to vec4.wzz).
        /// </summary>
        public vec3 abb => new vec3(w, z, z);
        
        /// <summary>
        /// Returns vec4.wzzx swizzling.
        /// </summary>
        public vec4 wzzx => new vec4(w, z, z, x);
        
        /// <summary>
        /// Returns vec4.abbr swizzling (equivalent to vec4.wzzx).
        /// </summary>
        public vec4 abbr => new vec4(w, z, z, x);
        
        /// <summary>
        /// Returns vec4.wzzxx swizzling.
        /// </summary>
        public vec5 wzzxx => new vec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns vec4.abbrr swizzling (equivalent to vec4.wzzxx).
        /// </summary>
        public vec5 abbrr => new vec5(w, z, z, x, x);
        
        /// <summary>
        /// Returns vec4.wzzxy swizzling.
        /// </summary>
        public vec5 wzzxy => new vec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns vec4.abbrg swizzling (equivalent to vec4.wzzxy).
        /// </summary>
        public vec5 abbrg => new vec5(w, z, z, x, y);
        
        /// <summary>
        /// Returns vec4.wzzxz swizzling.
        /// </summary>
        public vec5 wzzxz => new vec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns vec4.abbrb swizzling (equivalent to vec4.wzzxz).
        /// </summary>
        public vec5 abbrb => new vec5(w, z, z, x, z);
        
        /// <summary>
        /// Returns vec4.wzzxw swizzling.
        /// </summary>
        public vec5 wzzxw => new vec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns vec4.abbra swizzling (equivalent to vec4.wzzxw).
        /// </summary>
        public vec5 abbra => new vec5(w, z, z, x, w);
        
        /// <summary>
        /// Returns vec4.wzzy swizzling.
        /// </summary>
        public vec4 wzzy => new vec4(w, z, z, y);
        
        /// <summary>
        /// Returns vec4.abbg swizzling (equivalent to vec4.wzzy).
        /// </summary>
        public vec4 abbg => new vec4(w, z, z, y);
        
        /// <summary>
        /// Returns vec4.wzzyx swizzling.
        /// </summary>
        public vec5 wzzyx => new vec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns vec4.abbgr swizzling (equivalent to vec4.wzzyx).
        /// </summary>
        public vec5 abbgr => new vec5(w, z, z, y, x);
        
        /// <summary>
        /// Returns vec4.wzzyy swizzling.
        /// </summary>
        public vec5 wzzyy => new vec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns vec4.abbgg swizzling (equivalent to vec4.wzzyy).
        /// </summary>
        public vec5 abbgg => new vec5(w, z, z, y, y);
        
        /// <summary>
        /// Returns vec4.wzzyz swizzling.
        /// </summary>
        public vec5 wzzyz => new vec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns vec4.abbgb swizzling (equivalent to vec4.wzzyz).
        /// </summary>
        public vec5 abbgb => new vec5(w, z, z, y, z);
        
        /// <summary>
        /// Returns vec4.wzzyw swizzling.
        /// </summary>
        public vec5 wzzyw => new vec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns vec4.abbga swizzling (equivalent to vec4.wzzyw).
        /// </summary>
        public vec5 abbga => new vec5(w, z, z, y, w);
        
        /// <summary>
        /// Returns vec4.wzzz swizzling.
        /// </summary>
        public vec4 wzzz => new vec4(w, z, z, z);
        
        /// <summary>
        /// Returns vec4.abbb swizzling (equivalent to vec4.wzzz).
        /// </summary>
        public vec4 abbb => new vec4(w, z, z, z);
        
        /// <summary>
        /// Returns vec4.wzzzx swizzling.
        /// </summary>
        public vec5 wzzzx => new vec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns vec4.abbbr swizzling (equivalent to vec4.wzzzx).
        /// </summary>
        public vec5 abbbr => new vec5(w, z, z, z, x);
        
        /// <summary>
        /// Returns vec4.wzzzy swizzling.
        /// </summary>
        public vec5 wzzzy => new vec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns vec4.abbbg swizzling (equivalent to vec4.wzzzy).
        /// </summary>
        public vec5 abbbg => new vec5(w, z, z, z, y);
        
        /// <summary>
        /// Returns vec4.wzzzz swizzling.
        /// </summary>
        public vec5 wzzzz => new vec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns vec4.abbbb swizzling (equivalent to vec4.wzzzz).
        /// </summary>
        public vec5 abbbb => new vec5(w, z, z, z, z);
        
        /// <summary>
        /// Returns vec4.wzzzw swizzling.
        /// </summary>
        public vec5 wzzzw => new vec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns vec4.abbba swizzling (equivalent to vec4.wzzzw).
        /// </summary>
        public vec5 abbba => new vec5(w, z, z, z, w);
        
        /// <summary>
        /// Returns vec4.wzzw swizzling.
        /// </summary>
        public vec4 wzzw => new vec4(w, z, z, w);
        
        /// <summary>
        /// Returns vec4.abba swizzling (equivalent to vec4.wzzw).
        /// </summary>
        public vec4 abba => new vec4(w, z, z, w);
        
        /// <summary>
        /// Returns vec4.wzzwx swizzling.
        /// </summary>
        public vec5 wzzwx => new vec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns vec4.abbar swizzling (equivalent to vec4.wzzwx).
        /// </summary>
        public vec5 abbar => new vec5(w, z, z, w, x);
        
        /// <summary>
        /// Returns vec4.wzzwy swizzling.
        /// </summary>
        public vec5 wzzwy => new vec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns vec4.abbag swizzling (equivalent to vec4.wzzwy).
        /// </summary>
        public vec5 abbag => new vec5(w, z, z, w, y);
        
        /// <summary>
        /// Returns vec4.wzzwz swizzling.
        /// </summary>
        public vec5 wzzwz => new vec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns vec4.abbab swizzling (equivalent to vec4.wzzwz).
        /// </summary>
        public vec5 abbab => new vec5(w, z, z, w, z);
        
        /// <summary>
        /// Returns vec4.wzzww swizzling.
        /// </summary>
        public vec5 wzzww => new vec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns vec4.abbaa swizzling (equivalent to vec4.wzzww).
        /// </summary>
        public vec5 abbaa => new vec5(w, z, z, w, w);
        
        /// <summary>
        /// Returns vec4.wzw swizzling.
        /// </summary>
        public vec3 wzw => new vec3(w, z, w);
        
        /// <summary>
        /// Returns vec4.aba swizzling (equivalent to vec4.wzw).
        /// </summary>
        public vec3 aba => new vec3(w, z, w);
        
        /// <summary>
        /// Returns vec4.wzwx swizzling.
        /// </summary>
        public vec4 wzwx => new vec4(w, z, w, x);
        
        /// <summary>
        /// Returns vec4.abar swizzling (equivalent to vec4.wzwx).
        /// </summary>
        public vec4 abar => new vec4(w, z, w, x);
        
        /// <summary>
        /// Returns vec4.wzwxx swizzling.
        /// </summary>
        public vec5 wzwxx => new vec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns vec4.abarr swizzling (equivalent to vec4.wzwxx).
        /// </summary>
        public vec5 abarr => new vec5(w, z, w, x, x);
        
        /// <summary>
        /// Returns vec4.wzwxy swizzling.
        /// </summary>
        public vec5 wzwxy => new vec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns vec4.abarg swizzling (equivalent to vec4.wzwxy).
        /// </summary>
        public vec5 abarg => new vec5(w, z, w, x, y);
        
        /// <summary>
        /// Returns vec4.wzwxz swizzling.
        /// </summary>
        public vec5 wzwxz => new vec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns vec4.abarb swizzling (equivalent to vec4.wzwxz).
        /// </summary>
        public vec5 abarb => new vec5(w, z, w, x, z);
        
        /// <summary>
        /// Returns vec4.wzwxw swizzling.
        /// </summary>
        public vec5 wzwxw => new vec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns vec4.abara swizzling (equivalent to vec4.wzwxw).
        /// </summary>
        public vec5 abara => new vec5(w, z, w, x, w);
        
        /// <summary>
        /// Returns vec4.wzwy swizzling.
        /// </summary>
        public vec4 wzwy => new vec4(w, z, w, y);
        
        /// <summary>
        /// Returns vec4.abag swizzling (equivalent to vec4.wzwy).
        /// </summary>
        public vec4 abag => new vec4(w, z, w, y);
        
        /// <summary>
        /// Returns vec4.wzwyx swizzling.
        /// </summary>
        public vec5 wzwyx => new vec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns vec4.abagr swizzling (equivalent to vec4.wzwyx).
        /// </summary>
        public vec5 abagr => new vec5(w, z, w, y, x);
        
        /// <summary>
        /// Returns vec4.wzwyy swizzling.
        /// </summary>
        public vec5 wzwyy => new vec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns vec4.abagg swizzling (equivalent to vec4.wzwyy).
        /// </summary>
        public vec5 abagg => new vec5(w, z, w, y, y);
        
        /// <summary>
        /// Returns vec4.wzwyz swizzling.
        /// </summary>
        public vec5 wzwyz => new vec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns vec4.abagb swizzling (equivalent to vec4.wzwyz).
        /// </summary>
        public vec5 abagb => new vec5(w, z, w, y, z);
        
        /// <summary>
        /// Returns vec4.wzwyw swizzling.
        /// </summary>
        public vec5 wzwyw => new vec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns vec4.abaga swizzling (equivalent to vec4.wzwyw).
        /// </summary>
        public vec5 abaga => new vec5(w, z, w, y, w);
        
        /// <summary>
        /// Returns vec4.wzwz swizzling.
        /// </summary>
        public vec4 wzwz => new vec4(w, z, w, z);
        
        /// <summary>
        /// Returns vec4.abab swizzling (equivalent to vec4.wzwz).
        /// </summary>
        public vec4 abab => new vec4(w, z, w, z);
        
        /// <summary>
        /// Returns vec4.wzwzx swizzling.
        /// </summary>
        public vec5 wzwzx => new vec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns vec4.ababr swizzling (equivalent to vec4.wzwzx).
        /// </summary>
        public vec5 ababr => new vec5(w, z, w, z, x);
        
        /// <summary>
        /// Returns vec4.wzwzy swizzling.
        /// </summary>
        public vec5 wzwzy => new vec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns vec4.ababg swizzling (equivalent to vec4.wzwzy).
        /// </summary>
        public vec5 ababg => new vec5(w, z, w, z, y);
        
        /// <summary>
        /// Returns vec4.wzwzz swizzling.
        /// </summary>
        public vec5 wzwzz => new vec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns vec4.ababb swizzling (equivalent to vec4.wzwzz).
        /// </summary>
        public vec5 ababb => new vec5(w, z, w, z, z);
        
        /// <summary>
        /// Returns vec4.wzwzw swizzling.
        /// </summary>
        public vec5 wzwzw => new vec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns vec4.ababa swizzling (equivalent to vec4.wzwzw).
        /// </summary>
        public vec5 ababa => new vec5(w, z, w, z, w);
        
        /// <summary>
        /// Returns vec4.wzww swizzling.
        /// </summary>
        public vec4 wzww => new vec4(w, z, w, w);
        
        /// <summary>
        /// Returns vec4.abaa swizzling (equivalent to vec4.wzww).
        /// </summary>
        public vec4 abaa => new vec4(w, z, w, w);
        
        /// <summary>
        /// Returns vec4.wzwwx swizzling.
        /// </summary>
        public vec5 wzwwx => new vec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns vec4.abaar swizzling (equivalent to vec4.wzwwx).
        /// </summary>
        public vec5 abaar => new vec5(w, z, w, w, x);
        
        /// <summary>
        /// Returns vec4.wzwwy swizzling.
        /// </summary>
        public vec5 wzwwy => new vec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns vec4.abaag swizzling (equivalent to vec4.wzwwy).
        /// </summary>
        public vec5 abaag => new vec5(w, z, w, w, y);
        
        /// <summary>
        /// Returns vec4.wzwwz swizzling.
        /// </summary>
        public vec5 wzwwz => new vec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns vec4.abaab swizzling (equivalent to vec4.wzwwz).
        /// </summary>
        public vec5 abaab => new vec5(w, z, w, w, z);
        
        /// <summary>
        /// Returns vec4.wzwww swizzling.
        /// </summary>
        public vec5 wzwww => new vec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns vec4.abaaa swizzling (equivalent to vec4.wzwww).
        /// </summary>
        public vec5 abaaa => new vec5(w, z, w, w, w);
        
        /// <summary>
        /// Returns vec4.ww swizzling.
        /// </summary>
        public vec2 ww => new vec2(w, w);
        
        /// <summary>
        /// Returns vec4.aa swizzling (equivalent to vec4.ww).
        /// </summary>
        public vec2 aa => new vec2(w, w);
        
        /// <summary>
        /// Returns vec4.wwx swizzling.
        /// </summary>
        public vec3 wwx => new vec3(w, w, x);
        
        /// <summary>
        /// Returns vec4.aar swizzling (equivalent to vec4.wwx).
        /// </summary>
        public vec3 aar => new vec3(w, w, x);
        
        /// <summary>
        /// Returns vec4.wwxx swizzling.
        /// </summary>
        public vec4 wwxx => new vec4(w, w, x, x);
        
        /// <summary>
        /// Returns vec4.aarr swizzling (equivalent to vec4.wwxx).
        /// </summary>
        public vec4 aarr => new vec4(w, w, x, x);
        
        /// <summary>
        /// Returns vec4.wwxxx swizzling.
        /// </summary>
        public vec5 wwxxx => new vec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns vec4.aarrr swizzling (equivalent to vec4.wwxxx).
        /// </summary>
        public vec5 aarrr => new vec5(w, w, x, x, x);
        
        /// <summary>
        /// Returns vec4.wwxxy swizzling.
        /// </summary>
        public vec5 wwxxy => new vec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns vec4.aarrg swizzling (equivalent to vec4.wwxxy).
        /// </summary>
        public vec5 aarrg => new vec5(w, w, x, x, y);
        
        /// <summary>
        /// Returns vec4.wwxxz swizzling.
        /// </summary>
        public vec5 wwxxz => new vec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns vec4.aarrb swizzling (equivalent to vec4.wwxxz).
        /// </summary>
        public vec5 aarrb => new vec5(w, w, x, x, z);
        
        /// <summary>
        /// Returns vec4.wwxxw swizzling.
        /// </summary>
        public vec5 wwxxw => new vec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns vec4.aarra swizzling (equivalent to vec4.wwxxw).
        /// </summary>
        public vec5 aarra => new vec5(w, w, x, x, w);
        
        /// <summary>
        /// Returns vec4.wwxy swizzling.
        /// </summary>
        public vec4 wwxy => new vec4(w, w, x, y);
        
        /// <summary>
        /// Returns vec4.aarg swizzling (equivalent to vec4.wwxy).
        /// </summary>
        public vec4 aarg => new vec4(w, w, x, y);
        
        /// <summary>
        /// Returns vec4.wwxyx swizzling.
        /// </summary>
        public vec5 wwxyx => new vec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns vec4.aargr swizzling (equivalent to vec4.wwxyx).
        /// </summary>
        public vec5 aargr => new vec5(w, w, x, y, x);
        
        /// <summary>
        /// Returns vec4.wwxyy swizzling.
        /// </summary>
        public vec5 wwxyy => new vec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns vec4.aargg swizzling (equivalent to vec4.wwxyy).
        /// </summary>
        public vec5 aargg => new vec5(w, w, x, y, y);
        
        /// <summary>
        /// Returns vec4.wwxyz swizzling.
        /// </summary>
        public vec5 wwxyz => new vec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns vec4.aargb swizzling (equivalent to vec4.wwxyz).
        /// </summary>
        public vec5 aargb => new vec5(w, w, x, y, z);
        
        /// <summary>
        /// Returns vec4.wwxyw swizzling.
        /// </summary>
        public vec5 wwxyw => new vec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns vec4.aarga swizzling (equivalent to vec4.wwxyw).
        /// </summary>
        public vec5 aarga => new vec5(w, w, x, y, w);
        
        /// <summary>
        /// Returns vec4.wwxz swizzling.
        /// </summary>
        public vec4 wwxz => new vec4(w, w, x, z);
        
        /// <summary>
        /// Returns vec4.aarb swizzling (equivalent to vec4.wwxz).
        /// </summary>
        public vec4 aarb => new vec4(w, w, x, z);
        
        /// <summary>
        /// Returns vec4.wwxzx swizzling.
        /// </summary>
        public vec5 wwxzx => new vec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns vec4.aarbr swizzling (equivalent to vec4.wwxzx).
        /// </summary>
        public vec5 aarbr => new vec5(w, w, x, z, x);
        
        /// <summary>
        /// Returns vec4.wwxzy swizzling.
        /// </summary>
        public vec5 wwxzy => new vec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns vec4.aarbg swizzling (equivalent to vec4.wwxzy).
        /// </summary>
        public vec5 aarbg => new vec5(w, w, x, z, y);
        
        /// <summary>
        /// Returns vec4.wwxzz swizzling.
        /// </summary>
        public vec5 wwxzz => new vec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns vec4.aarbb swizzling (equivalent to vec4.wwxzz).
        /// </summary>
        public vec5 aarbb => new vec5(w, w, x, z, z);
        
        /// <summary>
        /// Returns vec4.wwxzw swizzling.
        /// </summary>
        public vec5 wwxzw => new vec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns vec4.aarba swizzling (equivalent to vec4.wwxzw).
        /// </summary>
        public vec5 aarba => new vec5(w, w, x, z, w);
        
        /// <summary>
        /// Returns vec4.wwxw swizzling.
        /// </summary>
        public vec4 wwxw => new vec4(w, w, x, w);
        
        /// <summary>
        /// Returns vec4.aara swizzling (equivalent to vec4.wwxw).
        /// </summary>
        public vec4 aara => new vec4(w, w, x, w);
        
        /// <summary>
        /// Returns vec4.wwxwx swizzling.
        /// </summary>
        public vec5 wwxwx => new vec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns vec4.aarar swizzling (equivalent to vec4.wwxwx).
        /// </summary>
        public vec5 aarar => new vec5(w, w, x, w, x);
        
        /// <summary>
        /// Returns vec4.wwxwy swizzling.
        /// </summary>
        public vec5 wwxwy => new vec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns vec4.aarag swizzling (equivalent to vec4.wwxwy).
        /// </summary>
        public vec5 aarag => new vec5(w, w, x, w, y);
        
        /// <summary>
        /// Returns vec4.wwxwz swizzling.
        /// </summary>
        public vec5 wwxwz => new vec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns vec4.aarab swizzling (equivalent to vec4.wwxwz).
        /// </summary>
        public vec5 aarab => new vec5(w, w, x, w, z);
        
        /// <summary>
        /// Returns vec4.wwxww swizzling.
        /// </summary>
        public vec5 wwxww => new vec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns vec4.aaraa swizzling (equivalent to vec4.wwxww).
        /// </summary>
        public vec5 aaraa => new vec5(w, w, x, w, w);
        
        /// <summary>
        /// Returns vec4.wwy swizzling.
        /// </summary>
        public vec3 wwy => new vec3(w, w, y);
        
        /// <summary>
        /// Returns vec4.aag swizzling (equivalent to vec4.wwy).
        /// </summary>
        public vec3 aag => new vec3(w, w, y);
        
        /// <summary>
        /// Returns vec4.wwyx swizzling.
        /// </summary>
        public vec4 wwyx => new vec4(w, w, y, x);
        
        /// <summary>
        /// Returns vec4.aagr swizzling (equivalent to vec4.wwyx).
        /// </summary>
        public vec4 aagr => new vec4(w, w, y, x);
        
        /// <summary>
        /// Returns vec4.wwyxx swizzling.
        /// </summary>
        public vec5 wwyxx => new vec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns vec4.aagrr swizzling (equivalent to vec4.wwyxx).
        /// </summary>
        public vec5 aagrr => new vec5(w, w, y, x, x);
        
        /// <summary>
        /// Returns vec4.wwyxy swizzling.
        /// </summary>
        public vec5 wwyxy => new vec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns vec4.aagrg swizzling (equivalent to vec4.wwyxy).
        /// </summary>
        public vec5 aagrg => new vec5(w, w, y, x, y);
        
        /// <summary>
        /// Returns vec4.wwyxz swizzling.
        /// </summary>
        public vec5 wwyxz => new vec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns vec4.aagrb swizzling (equivalent to vec4.wwyxz).
        /// </summary>
        public vec5 aagrb => new vec5(w, w, y, x, z);
        
        /// <summary>
        /// Returns vec4.wwyxw swizzling.
        /// </summary>
        public vec5 wwyxw => new vec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns vec4.aagra swizzling (equivalent to vec4.wwyxw).
        /// </summary>
        public vec5 aagra => new vec5(w, w, y, x, w);
        
        /// <summary>
        /// Returns vec4.wwyy swizzling.
        /// </summary>
        public vec4 wwyy => new vec4(w, w, y, y);
        
        /// <summary>
        /// Returns vec4.aagg swizzling (equivalent to vec4.wwyy).
        /// </summary>
        public vec4 aagg => new vec4(w, w, y, y);
        
        /// <summary>
        /// Returns vec4.wwyyx swizzling.
        /// </summary>
        public vec5 wwyyx => new vec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns vec4.aaggr swizzling (equivalent to vec4.wwyyx).
        /// </summary>
        public vec5 aaggr => new vec5(w, w, y, y, x);
        
        /// <summary>
        /// Returns vec4.wwyyy swizzling.
        /// </summary>
        public vec5 wwyyy => new vec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns vec4.aaggg swizzling (equivalent to vec4.wwyyy).
        /// </summary>
        public vec5 aaggg => new vec5(w, w, y, y, y);
        
        /// <summary>
        /// Returns vec4.wwyyz swizzling.
        /// </summary>
        public vec5 wwyyz => new vec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns vec4.aaggb swizzling (equivalent to vec4.wwyyz).
        /// </summary>
        public vec5 aaggb => new vec5(w, w, y, y, z);
        
        /// <summary>
        /// Returns vec4.wwyyw swizzling.
        /// </summary>
        public vec5 wwyyw => new vec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns vec4.aagga swizzling (equivalent to vec4.wwyyw).
        /// </summary>
        public vec5 aagga => new vec5(w, w, y, y, w);
        
        /// <summary>
        /// Returns vec4.wwyz swizzling.
        /// </summary>
        public vec4 wwyz => new vec4(w, w, y, z);
        
        /// <summary>
        /// Returns vec4.aagb swizzling (equivalent to vec4.wwyz).
        /// </summary>
        public vec4 aagb => new vec4(w, w, y, z);
        
        /// <summary>
        /// Returns vec4.wwyzx swizzling.
        /// </summary>
        public vec5 wwyzx => new vec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns vec4.aagbr swizzling (equivalent to vec4.wwyzx).
        /// </summary>
        public vec5 aagbr => new vec5(w, w, y, z, x);
        
        /// <summary>
        /// Returns vec4.wwyzy swizzling.
        /// </summary>
        public vec5 wwyzy => new vec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns vec4.aagbg swizzling (equivalent to vec4.wwyzy).
        /// </summary>
        public vec5 aagbg => new vec5(w, w, y, z, y);
        
        /// <summary>
        /// Returns vec4.wwyzz swizzling.
        /// </summary>
        public vec5 wwyzz => new vec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns vec4.aagbb swizzling (equivalent to vec4.wwyzz).
        /// </summary>
        public vec5 aagbb => new vec5(w, w, y, z, z);
        
        /// <summary>
        /// Returns vec4.wwyzw swizzling.
        /// </summary>
        public vec5 wwyzw => new vec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns vec4.aagba swizzling (equivalent to vec4.wwyzw).
        /// </summary>
        public vec5 aagba => new vec5(w, w, y, z, w);
        
        /// <summary>
        /// Returns vec4.wwyw swizzling.
        /// </summary>
        public vec4 wwyw => new vec4(w, w, y, w);
        
        /// <summary>
        /// Returns vec4.aaga swizzling (equivalent to vec4.wwyw).
        /// </summary>
        public vec4 aaga => new vec4(w, w, y, w);
        
        /// <summary>
        /// Returns vec4.wwywx swizzling.
        /// </summary>
        public vec5 wwywx => new vec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns vec4.aagar swizzling (equivalent to vec4.wwywx).
        /// </summary>
        public vec5 aagar => new vec5(w, w, y, w, x);
        
        /// <summary>
        /// Returns vec4.wwywy swizzling.
        /// </summary>
        public vec5 wwywy => new vec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns vec4.aagag swizzling (equivalent to vec4.wwywy).
        /// </summary>
        public vec5 aagag => new vec5(w, w, y, w, y);
        
        /// <summary>
        /// Returns vec4.wwywz swizzling.
        /// </summary>
        public vec5 wwywz => new vec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns vec4.aagab swizzling (equivalent to vec4.wwywz).
        /// </summary>
        public vec5 aagab => new vec5(w, w, y, w, z);
        
        /// <summary>
        /// Returns vec4.wwyww swizzling.
        /// </summary>
        public vec5 wwyww => new vec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns vec4.aagaa swizzling (equivalent to vec4.wwyww).
        /// </summary>
        public vec5 aagaa => new vec5(w, w, y, w, w);
        
        /// <summary>
        /// Returns vec4.wwz swizzling.
        /// </summary>
        public vec3 wwz => new vec3(w, w, z);
        
        /// <summary>
        /// Returns vec4.aab swizzling (equivalent to vec4.wwz).
        /// </summary>
        public vec3 aab => new vec3(w, w, z);
        
        /// <summary>
        /// Returns vec4.wwzx swizzling.
        /// </summary>
        public vec4 wwzx => new vec4(w, w, z, x);
        
        /// <summary>
        /// Returns vec4.aabr swizzling (equivalent to vec4.wwzx).
        /// </summary>
        public vec4 aabr => new vec4(w, w, z, x);
        
        /// <summary>
        /// Returns vec4.wwzxx swizzling.
        /// </summary>
        public vec5 wwzxx => new vec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns vec4.aabrr swizzling (equivalent to vec4.wwzxx).
        /// </summary>
        public vec5 aabrr => new vec5(w, w, z, x, x);
        
        /// <summary>
        /// Returns vec4.wwzxy swizzling.
        /// </summary>
        public vec5 wwzxy => new vec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns vec4.aabrg swizzling (equivalent to vec4.wwzxy).
        /// </summary>
        public vec5 aabrg => new vec5(w, w, z, x, y);
        
        /// <summary>
        /// Returns vec4.wwzxz swizzling.
        /// </summary>
        public vec5 wwzxz => new vec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns vec4.aabrb swizzling (equivalent to vec4.wwzxz).
        /// </summary>
        public vec5 aabrb => new vec5(w, w, z, x, z);
        
        /// <summary>
        /// Returns vec4.wwzxw swizzling.
        /// </summary>
        public vec5 wwzxw => new vec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns vec4.aabra swizzling (equivalent to vec4.wwzxw).
        /// </summary>
        public vec5 aabra => new vec5(w, w, z, x, w);
        
        /// <summary>
        /// Returns vec4.wwzy swizzling.
        /// </summary>
        public vec4 wwzy => new vec4(w, w, z, y);
        
        /// <summary>
        /// Returns vec4.aabg swizzling (equivalent to vec4.wwzy).
        /// </summary>
        public vec4 aabg => new vec4(w, w, z, y);
        
        /// <summary>
        /// Returns vec4.wwzyx swizzling.
        /// </summary>
        public vec5 wwzyx => new vec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns vec4.aabgr swizzling (equivalent to vec4.wwzyx).
        /// </summary>
        public vec5 aabgr => new vec5(w, w, z, y, x);
        
        /// <summary>
        /// Returns vec4.wwzyy swizzling.
        /// </summary>
        public vec5 wwzyy => new vec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns vec4.aabgg swizzling (equivalent to vec4.wwzyy).
        /// </summary>
        public vec5 aabgg => new vec5(w, w, z, y, y);
        
        /// <summary>
        /// Returns vec4.wwzyz swizzling.
        /// </summary>
        public vec5 wwzyz => new vec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns vec4.aabgb swizzling (equivalent to vec4.wwzyz).
        /// </summary>
        public vec5 aabgb => new vec5(w, w, z, y, z);
        
        /// <summary>
        /// Returns vec4.wwzyw swizzling.
        /// </summary>
        public vec5 wwzyw => new vec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns vec4.aabga swizzling (equivalent to vec4.wwzyw).
        /// </summary>
        public vec5 aabga => new vec5(w, w, z, y, w);
        
        /// <summary>
        /// Returns vec4.wwzz swizzling.
        /// </summary>
        public vec4 wwzz => new vec4(w, w, z, z);
        
        /// <summary>
        /// Returns vec4.aabb swizzling (equivalent to vec4.wwzz).
        /// </summary>
        public vec4 aabb => new vec4(w, w, z, z);
        
        /// <summary>
        /// Returns vec4.wwzzx swizzling.
        /// </summary>
        public vec5 wwzzx => new vec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns vec4.aabbr swizzling (equivalent to vec4.wwzzx).
        /// </summary>
        public vec5 aabbr => new vec5(w, w, z, z, x);
        
        /// <summary>
        /// Returns vec4.wwzzy swizzling.
        /// </summary>
        public vec5 wwzzy => new vec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns vec4.aabbg swizzling (equivalent to vec4.wwzzy).
        /// </summary>
        public vec5 aabbg => new vec5(w, w, z, z, y);
        
        /// <summary>
        /// Returns vec4.wwzzz swizzling.
        /// </summary>
        public vec5 wwzzz => new vec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns vec4.aabbb swizzling (equivalent to vec4.wwzzz).
        /// </summary>
        public vec5 aabbb => new vec5(w, w, z, z, z);
        
        /// <summary>
        /// Returns vec4.wwzzw swizzling.
        /// </summary>
        public vec5 wwzzw => new vec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns vec4.aabba swizzling (equivalent to vec4.wwzzw).
        /// </summary>
        public vec5 aabba => new vec5(w, w, z, z, w);
        
        /// <summary>
        /// Returns vec4.wwzw swizzling.
        /// </summary>
        public vec4 wwzw => new vec4(w, w, z, w);
        
        /// <summary>
        /// Returns vec4.aaba swizzling (equivalent to vec4.wwzw).
        /// </summary>
        public vec4 aaba => new vec4(w, w, z, w);
        
        /// <summary>
        /// Returns vec4.wwzwx swizzling.
        /// </summary>
        public vec5 wwzwx => new vec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns vec4.aabar swizzling (equivalent to vec4.wwzwx).
        /// </summary>
        public vec5 aabar => new vec5(w, w, z, w, x);
        
        /// <summary>
        /// Returns vec4.wwzwy swizzling.
        /// </summary>
        public vec5 wwzwy => new vec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns vec4.aabag swizzling (equivalent to vec4.wwzwy).
        /// </summary>
        public vec5 aabag => new vec5(w, w, z, w, y);
        
        /// <summary>
        /// Returns vec4.wwzwz swizzling.
        /// </summary>
        public vec5 wwzwz => new vec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns vec4.aabab swizzling (equivalent to vec4.wwzwz).
        /// </summary>
        public vec5 aabab => new vec5(w, w, z, w, z);
        
        /// <summary>
        /// Returns vec4.wwzww swizzling.
        /// </summary>
        public vec5 wwzww => new vec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns vec4.aabaa swizzling (equivalent to vec4.wwzww).
        /// </summary>
        public vec5 aabaa => new vec5(w, w, z, w, w);
        
        /// <summary>
        /// Returns vec4.www swizzling.
        /// </summary>
        public vec3 www => new vec3(w, w, w);
        
        /// <summary>
        /// Returns vec4.aaa swizzling (equivalent to vec4.www).
        /// </summary>
        public vec3 aaa => new vec3(w, w, w);
        
        /// <summary>
        /// Returns vec4.wwwx swizzling.
        /// </summary>
        public vec4 wwwx => new vec4(w, w, w, x);
        
        /// <summary>
        /// Returns vec4.aaar swizzling (equivalent to vec4.wwwx).
        /// </summary>
        public vec4 aaar => new vec4(w, w, w, x);
        
        /// <summary>
        /// Returns vec4.wwwxx swizzling.
        /// </summary>
        public vec5 wwwxx => new vec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns vec4.aaarr swizzling (equivalent to vec4.wwwxx).
        /// </summary>
        public vec5 aaarr => new vec5(w, w, w, x, x);
        
        /// <summary>
        /// Returns vec4.wwwxy swizzling.
        /// </summary>
        public vec5 wwwxy => new vec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns vec4.aaarg swizzling (equivalent to vec4.wwwxy).
        /// </summary>
        public vec5 aaarg => new vec5(w, w, w, x, y);
        
        /// <summary>
        /// Returns vec4.wwwxz swizzling.
        /// </summary>
        public vec5 wwwxz => new vec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns vec4.aaarb swizzling (equivalent to vec4.wwwxz).
        /// </summary>
        public vec5 aaarb => new vec5(w, w, w, x, z);
        
        /// <summary>
        /// Returns vec4.wwwxw swizzling.
        /// </summary>
        public vec5 wwwxw => new vec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns vec4.aaara swizzling (equivalent to vec4.wwwxw).
        /// </summary>
        public vec5 aaara => new vec5(w, w, w, x, w);
        
        /// <summary>
        /// Returns vec4.wwwy swizzling.
        /// </summary>
        public vec4 wwwy => new vec4(w, w, w, y);
        
        /// <summary>
        /// Returns vec4.aaag swizzling (equivalent to vec4.wwwy).
        /// </summary>
        public vec4 aaag => new vec4(w, w, w, y);
        
        /// <summary>
        /// Returns vec4.wwwyx swizzling.
        /// </summary>
        public vec5 wwwyx => new vec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns vec4.aaagr swizzling (equivalent to vec4.wwwyx).
        /// </summary>
        public vec5 aaagr => new vec5(w, w, w, y, x);
        
        /// <summary>
        /// Returns vec4.wwwyy swizzling.
        /// </summary>
        public vec5 wwwyy => new vec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns vec4.aaagg swizzling (equivalent to vec4.wwwyy).
        /// </summary>
        public vec5 aaagg => new vec5(w, w, w, y, y);
        
        /// <summary>
        /// Returns vec4.wwwyz swizzling.
        /// </summary>
        public vec5 wwwyz => new vec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns vec4.aaagb swizzling (equivalent to vec4.wwwyz).
        /// </summary>
        public vec5 aaagb => new vec5(w, w, w, y, z);
        
        /// <summary>
        /// Returns vec4.wwwyw swizzling.
        /// </summary>
        public vec5 wwwyw => new vec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns vec4.aaaga swizzling (equivalent to vec4.wwwyw).
        /// </summary>
        public vec5 aaaga => new vec5(w, w, w, y, w);
        
        /// <summary>
        /// Returns vec4.wwwz swizzling.
        /// </summary>
        public vec4 wwwz => new vec4(w, w, w, z);
        
        /// <summary>
        /// Returns vec4.aaab swizzling (equivalent to vec4.wwwz).
        /// </summary>
        public vec4 aaab => new vec4(w, w, w, z);
        
        /// <summary>
        /// Returns vec4.wwwzx swizzling.
        /// </summary>
        public vec5 wwwzx => new vec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns vec4.aaabr swizzling (equivalent to vec4.wwwzx).
        /// </summary>
        public vec5 aaabr => new vec5(w, w, w, z, x);
        
        /// <summary>
        /// Returns vec4.wwwzy swizzling.
        /// </summary>
        public vec5 wwwzy => new vec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns vec4.aaabg swizzling (equivalent to vec4.wwwzy).
        /// </summary>
        public vec5 aaabg => new vec5(w, w, w, z, y);
        
        /// <summary>
        /// Returns vec4.wwwzz swizzling.
        /// </summary>
        public vec5 wwwzz => new vec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns vec4.aaabb swizzling (equivalent to vec4.wwwzz).
        /// </summary>
        public vec5 aaabb => new vec5(w, w, w, z, z);
        
        /// <summary>
        /// Returns vec4.wwwzw swizzling.
        /// </summary>
        public vec5 wwwzw => new vec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns vec4.aaaba swizzling (equivalent to vec4.wwwzw).
        /// </summary>
        public vec5 aaaba => new vec5(w, w, w, z, w);
        
        /// <summary>
        /// Returns vec4.wwww swizzling.
        /// </summary>
        public vec4 wwww => new vec4(w, w, w, w);
        
        /// <summary>
        /// Returns vec4.aaaa swizzling (equivalent to vec4.wwww).
        /// </summary>
        public vec4 aaaa => new vec4(w, w, w, w);
        
        /// <summary>
        /// Returns vec4.wwwwx swizzling.
        /// </summary>
        public vec5 wwwwx => new vec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns vec4.aaaar swizzling (equivalent to vec4.wwwwx).
        /// </summary>
        public vec5 aaaar => new vec5(w, w, w, w, x);
        
        /// <summary>
        /// Returns vec4.wwwwy swizzling.
        /// </summary>
        public vec5 wwwwy => new vec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns vec4.aaaag swizzling (equivalent to vec4.wwwwy).
        /// </summary>
        public vec5 aaaag => new vec5(w, w, w, w, y);
        
        /// <summary>
        /// Returns vec4.wwwwz swizzling.
        /// </summary>
        public vec5 wwwwz => new vec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns vec4.aaaab swizzling (equivalent to vec4.wwwwz).
        /// </summary>
        public vec5 aaaab => new vec5(w, w, w, w, z);
        
        /// <summary>
        /// Returns vec4.wwwww swizzling.
        /// </summary>
        public vec5 wwwww => new vec5(w, w, w, w, w);
        
        /// <summary>
        /// Returns vec4.aaaaa swizzling (equivalent to vec4.wwwww).
        /// </summary>
        public vec5 aaaaa => new vec5(w, w, w, w, w);

        #endregion

    }
}
