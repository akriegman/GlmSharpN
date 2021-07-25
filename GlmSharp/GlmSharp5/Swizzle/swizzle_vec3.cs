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
    /// Temporary vector of type float with 3 components, used for implementing swizzling for vec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_vec3
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly float y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly float z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_vec3.
        /// </summary>
        internal swizzle_vec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns vec3.xx swizzling.
        /// </summary>
        public vec2 xx => new vec2(x, x);
        
        /// <summary>
        /// Returns vec3.rr swizzling (equivalent to vec3.xx).
        /// </summary>
        public vec2 rr => new vec2(x, x);
        
        /// <summary>
        /// Returns vec3.xxx swizzling.
        /// </summary>
        public vec3 xxx => new vec3(x, x, x);
        
        /// <summary>
        /// Returns vec3.rrr swizzling (equivalent to vec3.xxx).
        /// </summary>
        public vec3 rrr => new vec3(x, x, x);
        
        /// <summary>
        /// Returns vec3.xxxx swizzling.
        /// </summary>
        public vec4 xxxx => new vec4(x, x, x, x);
        
        /// <summary>
        /// Returns vec3.rrrr swizzling (equivalent to vec3.xxxx).
        /// </summary>
        public vec4 rrrr => new vec4(x, x, x, x);
        
        /// <summary>
        /// Returns vec3.xxxxx swizzling.
        /// </summary>
        public vec5 xxxxx => new vec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns vec3.rrrrr swizzling (equivalent to vec3.xxxxx).
        /// </summary>
        public vec5 rrrrr => new vec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns vec3.xxxxy swizzling.
        /// </summary>
        public vec5 xxxxy => new vec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns vec3.rrrrg swizzling (equivalent to vec3.xxxxy).
        /// </summary>
        public vec5 rrrrg => new vec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns vec3.xxxxz swizzling.
        /// </summary>
        public vec5 xxxxz => new vec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns vec3.rrrrb swizzling (equivalent to vec3.xxxxz).
        /// </summary>
        public vec5 rrrrb => new vec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns vec3.xxxy swizzling.
        /// </summary>
        public vec4 xxxy => new vec4(x, x, x, y);
        
        /// <summary>
        /// Returns vec3.rrrg swizzling (equivalent to vec3.xxxy).
        /// </summary>
        public vec4 rrrg => new vec4(x, x, x, y);
        
        /// <summary>
        /// Returns vec3.xxxyx swizzling.
        /// </summary>
        public vec5 xxxyx => new vec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns vec3.rrrgr swizzling (equivalent to vec3.xxxyx).
        /// </summary>
        public vec5 rrrgr => new vec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns vec3.xxxyy swizzling.
        /// </summary>
        public vec5 xxxyy => new vec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns vec3.rrrgg swizzling (equivalent to vec3.xxxyy).
        /// </summary>
        public vec5 rrrgg => new vec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns vec3.xxxyz swizzling.
        /// </summary>
        public vec5 xxxyz => new vec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns vec3.rrrgb swizzling (equivalent to vec3.xxxyz).
        /// </summary>
        public vec5 rrrgb => new vec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns vec3.xxxz swizzling.
        /// </summary>
        public vec4 xxxz => new vec4(x, x, x, z);
        
        /// <summary>
        /// Returns vec3.rrrb swizzling (equivalent to vec3.xxxz).
        /// </summary>
        public vec4 rrrb => new vec4(x, x, x, z);
        
        /// <summary>
        /// Returns vec3.xxxzx swizzling.
        /// </summary>
        public vec5 xxxzx => new vec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns vec3.rrrbr swizzling (equivalent to vec3.xxxzx).
        /// </summary>
        public vec5 rrrbr => new vec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns vec3.xxxzy swizzling.
        /// </summary>
        public vec5 xxxzy => new vec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns vec3.rrrbg swizzling (equivalent to vec3.xxxzy).
        /// </summary>
        public vec5 rrrbg => new vec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns vec3.xxxzz swizzling.
        /// </summary>
        public vec5 xxxzz => new vec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns vec3.rrrbb swizzling (equivalent to vec3.xxxzz).
        /// </summary>
        public vec5 rrrbb => new vec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns vec3.xxy swizzling.
        /// </summary>
        public vec3 xxy => new vec3(x, x, y);
        
        /// <summary>
        /// Returns vec3.rrg swizzling (equivalent to vec3.xxy).
        /// </summary>
        public vec3 rrg => new vec3(x, x, y);
        
        /// <summary>
        /// Returns vec3.xxyx swizzling.
        /// </summary>
        public vec4 xxyx => new vec4(x, x, y, x);
        
        /// <summary>
        /// Returns vec3.rrgr swizzling (equivalent to vec3.xxyx).
        /// </summary>
        public vec4 rrgr => new vec4(x, x, y, x);
        
        /// <summary>
        /// Returns vec3.xxyxx swizzling.
        /// </summary>
        public vec5 xxyxx => new vec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns vec3.rrgrr swizzling (equivalent to vec3.xxyxx).
        /// </summary>
        public vec5 rrgrr => new vec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns vec3.xxyxy swizzling.
        /// </summary>
        public vec5 xxyxy => new vec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns vec3.rrgrg swizzling (equivalent to vec3.xxyxy).
        /// </summary>
        public vec5 rrgrg => new vec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns vec3.xxyxz swizzling.
        /// </summary>
        public vec5 xxyxz => new vec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns vec3.rrgrb swizzling (equivalent to vec3.xxyxz).
        /// </summary>
        public vec5 rrgrb => new vec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns vec3.xxyy swizzling.
        /// </summary>
        public vec4 xxyy => new vec4(x, x, y, y);
        
        /// <summary>
        /// Returns vec3.rrgg swizzling (equivalent to vec3.xxyy).
        /// </summary>
        public vec4 rrgg => new vec4(x, x, y, y);
        
        /// <summary>
        /// Returns vec3.xxyyx swizzling.
        /// </summary>
        public vec5 xxyyx => new vec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns vec3.rrggr swizzling (equivalent to vec3.xxyyx).
        /// </summary>
        public vec5 rrggr => new vec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns vec3.xxyyy swizzling.
        /// </summary>
        public vec5 xxyyy => new vec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns vec3.rrggg swizzling (equivalent to vec3.xxyyy).
        /// </summary>
        public vec5 rrggg => new vec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns vec3.xxyyz swizzling.
        /// </summary>
        public vec5 xxyyz => new vec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns vec3.rrggb swizzling (equivalent to vec3.xxyyz).
        /// </summary>
        public vec5 rrggb => new vec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns vec3.xxyz swizzling.
        /// </summary>
        public vec4 xxyz => new vec4(x, x, y, z);
        
        /// <summary>
        /// Returns vec3.rrgb swizzling (equivalent to vec3.xxyz).
        /// </summary>
        public vec4 rrgb => new vec4(x, x, y, z);
        
        /// <summary>
        /// Returns vec3.xxyzx swizzling.
        /// </summary>
        public vec5 xxyzx => new vec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns vec3.rrgbr swizzling (equivalent to vec3.xxyzx).
        /// </summary>
        public vec5 rrgbr => new vec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns vec3.xxyzy swizzling.
        /// </summary>
        public vec5 xxyzy => new vec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns vec3.rrgbg swizzling (equivalent to vec3.xxyzy).
        /// </summary>
        public vec5 rrgbg => new vec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns vec3.xxyzz swizzling.
        /// </summary>
        public vec5 xxyzz => new vec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns vec3.rrgbb swizzling (equivalent to vec3.xxyzz).
        /// </summary>
        public vec5 rrgbb => new vec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns vec3.xxz swizzling.
        /// </summary>
        public vec3 xxz => new vec3(x, x, z);
        
        /// <summary>
        /// Returns vec3.rrb swizzling (equivalent to vec3.xxz).
        /// </summary>
        public vec3 rrb => new vec3(x, x, z);
        
        /// <summary>
        /// Returns vec3.xxzx swizzling.
        /// </summary>
        public vec4 xxzx => new vec4(x, x, z, x);
        
        /// <summary>
        /// Returns vec3.rrbr swizzling (equivalent to vec3.xxzx).
        /// </summary>
        public vec4 rrbr => new vec4(x, x, z, x);
        
        /// <summary>
        /// Returns vec3.xxzxx swizzling.
        /// </summary>
        public vec5 xxzxx => new vec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns vec3.rrbrr swizzling (equivalent to vec3.xxzxx).
        /// </summary>
        public vec5 rrbrr => new vec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns vec3.xxzxy swizzling.
        /// </summary>
        public vec5 xxzxy => new vec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns vec3.rrbrg swizzling (equivalent to vec3.xxzxy).
        /// </summary>
        public vec5 rrbrg => new vec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns vec3.xxzxz swizzling.
        /// </summary>
        public vec5 xxzxz => new vec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns vec3.rrbrb swizzling (equivalent to vec3.xxzxz).
        /// </summary>
        public vec5 rrbrb => new vec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns vec3.xxzy swizzling.
        /// </summary>
        public vec4 xxzy => new vec4(x, x, z, y);
        
        /// <summary>
        /// Returns vec3.rrbg swizzling (equivalent to vec3.xxzy).
        /// </summary>
        public vec4 rrbg => new vec4(x, x, z, y);
        
        /// <summary>
        /// Returns vec3.xxzyx swizzling.
        /// </summary>
        public vec5 xxzyx => new vec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns vec3.rrbgr swizzling (equivalent to vec3.xxzyx).
        /// </summary>
        public vec5 rrbgr => new vec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns vec3.xxzyy swizzling.
        /// </summary>
        public vec5 xxzyy => new vec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns vec3.rrbgg swizzling (equivalent to vec3.xxzyy).
        /// </summary>
        public vec5 rrbgg => new vec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns vec3.xxzyz swizzling.
        /// </summary>
        public vec5 xxzyz => new vec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns vec3.rrbgb swizzling (equivalent to vec3.xxzyz).
        /// </summary>
        public vec5 rrbgb => new vec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns vec3.xxzz swizzling.
        /// </summary>
        public vec4 xxzz => new vec4(x, x, z, z);
        
        /// <summary>
        /// Returns vec3.rrbb swizzling (equivalent to vec3.xxzz).
        /// </summary>
        public vec4 rrbb => new vec4(x, x, z, z);
        
        /// <summary>
        /// Returns vec3.xxzzx swizzling.
        /// </summary>
        public vec5 xxzzx => new vec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns vec3.rrbbr swizzling (equivalent to vec3.xxzzx).
        /// </summary>
        public vec5 rrbbr => new vec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns vec3.xxzzy swizzling.
        /// </summary>
        public vec5 xxzzy => new vec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns vec3.rrbbg swizzling (equivalent to vec3.xxzzy).
        /// </summary>
        public vec5 rrbbg => new vec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns vec3.xxzzz swizzling.
        /// </summary>
        public vec5 xxzzz => new vec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns vec3.rrbbb swizzling (equivalent to vec3.xxzzz).
        /// </summary>
        public vec5 rrbbb => new vec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns vec3.xy swizzling.
        /// </summary>
        public vec2 xy => new vec2(x, y);
        
        /// <summary>
        /// Returns vec3.rg swizzling (equivalent to vec3.xy).
        /// </summary>
        public vec2 rg => new vec2(x, y);
        
        /// <summary>
        /// Returns vec3.xyx swizzling.
        /// </summary>
        public vec3 xyx => new vec3(x, y, x);
        
        /// <summary>
        /// Returns vec3.rgr swizzling (equivalent to vec3.xyx).
        /// </summary>
        public vec3 rgr => new vec3(x, y, x);
        
        /// <summary>
        /// Returns vec3.xyxx swizzling.
        /// </summary>
        public vec4 xyxx => new vec4(x, y, x, x);
        
        /// <summary>
        /// Returns vec3.rgrr swizzling (equivalent to vec3.xyxx).
        /// </summary>
        public vec4 rgrr => new vec4(x, y, x, x);
        
        /// <summary>
        /// Returns vec3.xyxxx swizzling.
        /// </summary>
        public vec5 xyxxx => new vec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns vec3.rgrrr swizzling (equivalent to vec3.xyxxx).
        /// </summary>
        public vec5 rgrrr => new vec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns vec3.xyxxy swizzling.
        /// </summary>
        public vec5 xyxxy => new vec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns vec3.rgrrg swizzling (equivalent to vec3.xyxxy).
        /// </summary>
        public vec5 rgrrg => new vec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns vec3.xyxxz swizzling.
        /// </summary>
        public vec5 xyxxz => new vec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns vec3.rgrrb swizzling (equivalent to vec3.xyxxz).
        /// </summary>
        public vec5 rgrrb => new vec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns vec3.xyxy swizzling.
        /// </summary>
        public vec4 xyxy => new vec4(x, y, x, y);
        
        /// <summary>
        /// Returns vec3.rgrg swizzling (equivalent to vec3.xyxy).
        /// </summary>
        public vec4 rgrg => new vec4(x, y, x, y);
        
        /// <summary>
        /// Returns vec3.xyxyx swizzling.
        /// </summary>
        public vec5 xyxyx => new vec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns vec3.rgrgr swizzling (equivalent to vec3.xyxyx).
        /// </summary>
        public vec5 rgrgr => new vec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns vec3.xyxyy swizzling.
        /// </summary>
        public vec5 xyxyy => new vec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns vec3.rgrgg swizzling (equivalent to vec3.xyxyy).
        /// </summary>
        public vec5 rgrgg => new vec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns vec3.xyxyz swizzling.
        /// </summary>
        public vec5 xyxyz => new vec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns vec3.rgrgb swizzling (equivalent to vec3.xyxyz).
        /// </summary>
        public vec5 rgrgb => new vec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns vec3.xyxz swizzling.
        /// </summary>
        public vec4 xyxz => new vec4(x, y, x, z);
        
        /// <summary>
        /// Returns vec3.rgrb swizzling (equivalent to vec3.xyxz).
        /// </summary>
        public vec4 rgrb => new vec4(x, y, x, z);
        
        /// <summary>
        /// Returns vec3.xyxzx swizzling.
        /// </summary>
        public vec5 xyxzx => new vec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns vec3.rgrbr swizzling (equivalent to vec3.xyxzx).
        /// </summary>
        public vec5 rgrbr => new vec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns vec3.xyxzy swizzling.
        /// </summary>
        public vec5 xyxzy => new vec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns vec3.rgrbg swizzling (equivalent to vec3.xyxzy).
        /// </summary>
        public vec5 rgrbg => new vec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns vec3.xyxzz swizzling.
        /// </summary>
        public vec5 xyxzz => new vec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns vec3.rgrbb swizzling (equivalent to vec3.xyxzz).
        /// </summary>
        public vec5 rgrbb => new vec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns vec3.xyy swizzling.
        /// </summary>
        public vec3 xyy => new vec3(x, y, y);
        
        /// <summary>
        /// Returns vec3.rgg swizzling (equivalent to vec3.xyy).
        /// </summary>
        public vec3 rgg => new vec3(x, y, y);
        
        /// <summary>
        /// Returns vec3.xyyx swizzling.
        /// </summary>
        public vec4 xyyx => new vec4(x, y, y, x);
        
        /// <summary>
        /// Returns vec3.rggr swizzling (equivalent to vec3.xyyx).
        /// </summary>
        public vec4 rggr => new vec4(x, y, y, x);
        
        /// <summary>
        /// Returns vec3.xyyxx swizzling.
        /// </summary>
        public vec5 xyyxx => new vec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns vec3.rggrr swizzling (equivalent to vec3.xyyxx).
        /// </summary>
        public vec5 rggrr => new vec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns vec3.xyyxy swizzling.
        /// </summary>
        public vec5 xyyxy => new vec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns vec3.rggrg swizzling (equivalent to vec3.xyyxy).
        /// </summary>
        public vec5 rggrg => new vec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns vec3.xyyxz swizzling.
        /// </summary>
        public vec5 xyyxz => new vec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns vec3.rggrb swizzling (equivalent to vec3.xyyxz).
        /// </summary>
        public vec5 rggrb => new vec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns vec3.xyyy swizzling.
        /// </summary>
        public vec4 xyyy => new vec4(x, y, y, y);
        
        /// <summary>
        /// Returns vec3.rggg swizzling (equivalent to vec3.xyyy).
        /// </summary>
        public vec4 rggg => new vec4(x, y, y, y);
        
        /// <summary>
        /// Returns vec3.xyyyx swizzling.
        /// </summary>
        public vec5 xyyyx => new vec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns vec3.rgggr swizzling (equivalent to vec3.xyyyx).
        /// </summary>
        public vec5 rgggr => new vec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns vec3.xyyyy swizzling.
        /// </summary>
        public vec5 xyyyy => new vec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns vec3.rgggg swizzling (equivalent to vec3.xyyyy).
        /// </summary>
        public vec5 rgggg => new vec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns vec3.xyyyz swizzling.
        /// </summary>
        public vec5 xyyyz => new vec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns vec3.rgggb swizzling (equivalent to vec3.xyyyz).
        /// </summary>
        public vec5 rgggb => new vec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns vec3.xyyz swizzling.
        /// </summary>
        public vec4 xyyz => new vec4(x, y, y, z);
        
        /// <summary>
        /// Returns vec3.rggb swizzling (equivalent to vec3.xyyz).
        /// </summary>
        public vec4 rggb => new vec4(x, y, y, z);
        
        /// <summary>
        /// Returns vec3.xyyzx swizzling.
        /// </summary>
        public vec5 xyyzx => new vec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns vec3.rggbr swizzling (equivalent to vec3.xyyzx).
        /// </summary>
        public vec5 rggbr => new vec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns vec3.xyyzy swizzling.
        /// </summary>
        public vec5 xyyzy => new vec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns vec3.rggbg swizzling (equivalent to vec3.xyyzy).
        /// </summary>
        public vec5 rggbg => new vec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns vec3.xyyzz swizzling.
        /// </summary>
        public vec5 xyyzz => new vec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns vec3.rggbb swizzling (equivalent to vec3.xyyzz).
        /// </summary>
        public vec5 rggbb => new vec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns vec3.xyz swizzling.
        /// </summary>
        public vec3 xyz => new vec3(x, y, z);
        
        /// <summary>
        /// Returns vec3.rgb swizzling (equivalent to vec3.xyz).
        /// </summary>
        public vec3 rgb => new vec3(x, y, z);
        
        /// <summary>
        /// Returns vec3.xyzx swizzling.
        /// </summary>
        public vec4 xyzx => new vec4(x, y, z, x);
        
        /// <summary>
        /// Returns vec3.rgbr swizzling (equivalent to vec3.xyzx).
        /// </summary>
        public vec4 rgbr => new vec4(x, y, z, x);
        
        /// <summary>
        /// Returns vec3.xyzxx swizzling.
        /// </summary>
        public vec5 xyzxx => new vec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns vec3.rgbrr swizzling (equivalent to vec3.xyzxx).
        /// </summary>
        public vec5 rgbrr => new vec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns vec3.xyzxy swizzling.
        /// </summary>
        public vec5 xyzxy => new vec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns vec3.rgbrg swizzling (equivalent to vec3.xyzxy).
        /// </summary>
        public vec5 rgbrg => new vec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns vec3.xyzxz swizzling.
        /// </summary>
        public vec5 xyzxz => new vec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns vec3.rgbrb swizzling (equivalent to vec3.xyzxz).
        /// </summary>
        public vec5 rgbrb => new vec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns vec3.xyzy swizzling.
        /// </summary>
        public vec4 xyzy => new vec4(x, y, z, y);
        
        /// <summary>
        /// Returns vec3.rgbg swizzling (equivalent to vec3.xyzy).
        /// </summary>
        public vec4 rgbg => new vec4(x, y, z, y);
        
        /// <summary>
        /// Returns vec3.xyzyx swizzling.
        /// </summary>
        public vec5 xyzyx => new vec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns vec3.rgbgr swizzling (equivalent to vec3.xyzyx).
        /// </summary>
        public vec5 rgbgr => new vec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns vec3.xyzyy swizzling.
        /// </summary>
        public vec5 xyzyy => new vec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns vec3.rgbgg swizzling (equivalent to vec3.xyzyy).
        /// </summary>
        public vec5 rgbgg => new vec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns vec3.xyzyz swizzling.
        /// </summary>
        public vec5 xyzyz => new vec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns vec3.rgbgb swizzling (equivalent to vec3.xyzyz).
        /// </summary>
        public vec5 rgbgb => new vec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns vec3.xyzz swizzling.
        /// </summary>
        public vec4 xyzz => new vec4(x, y, z, z);
        
        /// <summary>
        /// Returns vec3.rgbb swizzling (equivalent to vec3.xyzz).
        /// </summary>
        public vec4 rgbb => new vec4(x, y, z, z);
        
        /// <summary>
        /// Returns vec3.xyzzx swizzling.
        /// </summary>
        public vec5 xyzzx => new vec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns vec3.rgbbr swizzling (equivalent to vec3.xyzzx).
        /// </summary>
        public vec5 rgbbr => new vec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns vec3.xyzzy swizzling.
        /// </summary>
        public vec5 xyzzy => new vec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns vec3.rgbbg swizzling (equivalent to vec3.xyzzy).
        /// </summary>
        public vec5 rgbbg => new vec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns vec3.xyzzz swizzling.
        /// </summary>
        public vec5 xyzzz => new vec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns vec3.rgbbb swizzling (equivalent to vec3.xyzzz).
        /// </summary>
        public vec5 rgbbb => new vec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns vec3.xz swizzling.
        /// </summary>
        public vec2 xz => new vec2(x, z);
        
        /// <summary>
        /// Returns vec3.rb swizzling (equivalent to vec3.xz).
        /// </summary>
        public vec2 rb => new vec2(x, z);
        
        /// <summary>
        /// Returns vec3.xzx swizzling.
        /// </summary>
        public vec3 xzx => new vec3(x, z, x);
        
        /// <summary>
        /// Returns vec3.rbr swizzling (equivalent to vec3.xzx).
        /// </summary>
        public vec3 rbr => new vec3(x, z, x);
        
        /// <summary>
        /// Returns vec3.xzxx swizzling.
        /// </summary>
        public vec4 xzxx => new vec4(x, z, x, x);
        
        /// <summary>
        /// Returns vec3.rbrr swizzling (equivalent to vec3.xzxx).
        /// </summary>
        public vec4 rbrr => new vec4(x, z, x, x);
        
        /// <summary>
        /// Returns vec3.xzxxx swizzling.
        /// </summary>
        public vec5 xzxxx => new vec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns vec3.rbrrr swizzling (equivalent to vec3.xzxxx).
        /// </summary>
        public vec5 rbrrr => new vec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns vec3.xzxxy swizzling.
        /// </summary>
        public vec5 xzxxy => new vec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns vec3.rbrrg swizzling (equivalent to vec3.xzxxy).
        /// </summary>
        public vec5 rbrrg => new vec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns vec3.xzxxz swizzling.
        /// </summary>
        public vec5 xzxxz => new vec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns vec3.rbrrb swizzling (equivalent to vec3.xzxxz).
        /// </summary>
        public vec5 rbrrb => new vec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns vec3.xzxy swizzling.
        /// </summary>
        public vec4 xzxy => new vec4(x, z, x, y);
        
        /// <summary>
        /// Returns vec3.rbrg swizzling (equivalent to vec3.xzxy).
        /// </summary>
        public vec4 rbrg => new vec4(x, z, x, y);
        
        /// <summary>
        /// Returns vec3.xzxyx swizzling.
        /// </summary>
        public vec5 xzxyx => new vec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns vec3.rbrgr swizzling (equivalent to vec3.xzxyx).
        /// </summary>
        public vec5 rbrgr => new vec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns vec3.xzxyy swizzling.
        /// </summary>
        public vec5 xzxyy => new vec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns vec3.rbrgg swizzling (equivalent to vec3.xzxyy).
        /// </summary>
        public vec5 rbrgg => new vec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns vec3.xzxyz swizzling.
        /// </summary>
        public vec5 xzxyz => new vec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns vec3.rbrgb swizzling (equivalent to vec3.xzxyz).
        /// </summary>
        public vec5 rbrgb => new vec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns vec3.xzxz swizzling.
        /// </summary>
        public vec4 xzxz => new vec4(x, z, x, z);
        
        /// <summary>
        /// Returns vec3.rbrb swizzling (equivalent to vec3.xzxz).
        /// </summary>
        public vec4 rbrb => new vec4(x, z, x, z);
        
        /// <summary>
        /// Returns vec3.xzxzx swizzling.
        /// </summary>
        public vec5 xzxzx => new vec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns vec3.rbrbr swizzling (equivalent to vec3.xzxzx).
        /// </summary>
        public vec5 rbrbr => new vec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns vec3.xzxzy swizzling.
        /// </summary>
        public vec5 xzxzy => new vec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns vec3.rbrbg swizzling (equivalent to vec3.xzxzy).
        /// </summary>
        public vec5 rbrbg => new vec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns vec3.xzxzz swizzling.
        /// </summary>
        public vec5 xzxzz => new vec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns vec3.rbrbb swizzling (equivalent to vec3.xzxzz).
        /// </summary>
        public vec5 rbrbb => new vec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns vec3.xzy swizzling.
        /// </summary>
        public vec3 xzy => new vec3(x, z, y);
        
        /// <summary>
        /// Returns vec3.rbg swizzling (equivalent to vec3.xzy).
        /// </summary>
        public vec3 rbg => new vec3(x, z, y);
        
        /// <summary>
        /// Returns vec3.xzyx swizzling.
        /// </summary>
        public vec4 xzyx => new vec4(x, z, y, x);
        
        /// <summary>
        /// Returns vec3.rbgr swizzling (equivalent to vec3.xzyx).
        /// </summary>
        public vec4 rbgr => new vec4(x, z, y, x);
        
        /// <summary>
        /// Returns vec3.xzyxx swizzling.
        /// </summary>
        public vec5 xzyxx => new vec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns vec3.rbgrr swizzling (equivalent to vec3.xzyxx).
        /// </summary>
        public vec5 rbgrr => new vec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns vec3.xzyxy swizzling.
        /// </summary>
        public vec5 xzyxy => new vec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns vec3.rbgrg swizzling (equivalent to vec3.xzyxy).
        /// </summary>
        public vec5 rbgrg => new vec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns vec3.xzyxz swizzling.
        /// </summary>
        public vec5 xzyxz => new vec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns vec3.rbgrb swizzling (equivalent to vec3.xzyxz).
        /// </summary>
        public vec5 rbgrb => new vec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns vec3.xzyy swizzling.
        /// </summary>
        public vec4 xzyy => new vec4(x, z, y, y);
        
        /// <summary>
        /// Returns vec3.rbgg swizzling (equivalent to vec3.xzyy).
        /// </summary>
        public vec4 rbgg => new vec4(x, z, y, y);
        
        /// <summary>
        /// Returns vec3.xzyyx swizzling.
        /// </summary>
        public vec5 xzyyx => new vec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns vec3.rbggr swizzling (equivalent to vec3.xzyyx).
        /// </summary>
        public vec5 rbggr => new vec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns vec3.xzyyy swizzling.
        /// </summary>
        public vec5 xzyyy => new vec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns vec3.rbggg swizzling (equivalent to vec3.xzyyy).
        /// </summary>
        public vec5 rbggg => new vec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns vec3.xzyyz swizzling.
        /// </summary>
        public vec5 xzyyz => new vec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns vec3.rbggb swizzling (equivalent to vec3.xzyyz).
        /// </summary>
        public vec5 rbggb => new vec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns vec3.xzyz swizzling.
        /// </summary>
        public vec4 xzyz => new vec4(x, z, y, z);
        
        /// <summary>
        /// Returns vec3.rbgb swizzling (equivalent to vec3.xzyz).
        /// </summary>
        public vec4 rbgb => new vec4(x, z, y, z);
        
        /// <summary>
        /// Returns vec3.xzyzx swizzling.
        /// </summary>
        public vec5 xzyzx => new vec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns vec3.rbgbr swizzling (equivalent to vec3.xzyzx).
        /// </summary>
        public vec5 rbgbr => new vec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns vec3.xzyzy swizzling.
        /// </summary>
        public vec5 xzyzy => new vec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns vec3.rbgbg swizzling (equivalent to vec3.xzyzy).
        /// </summary>
        public vec5 rbgbg => new vec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns vec3.xzyzz swizzling.
        /// </summary>
        public vec5 xzyzz => new vec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns vec3.rbgbb swizzling (equivalent to vec3.xzyzz).
        /// </summary>
        public vec5 rbgbb => new vec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns vec3.xzz swizzling.
        /// </summary>
        public vec3 xzz => new vec3(x, z, z);
        
        /// <summary>
        /// Returns vec3.rbb swizzling (equivalent to vec3.xzz).
        /// </summary>
        public vec3 rbb => new vec3(x, z, z);
        
        /// <summary>
        /// Returns vec3.xzzx swizzling.
        /// </summary>
        public vec4 xzzx => new vec4(x, z, z, x);
        
        /// <summary>
        /// Returns vec3.rbbr swizzling (equivalent to vec3.xzzx).
        /// </summary>
        public vec4 rbbr => new vec4(x, z, z, x);
        
        /// <summary>
        /// Returns vec3.xzzxx swizzling.
        /// </summary>
        public vec5 xzzxx => new vec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns vec3.rbbrr swizzling (equivalent to vec3.xzzxx).
        /// </summary>
        public vec5 rbbrr => new vec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns vec3.xzzxy swizzling.
        /// </summary>
        public vec5 xzzxy => new vec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns vec3.rbbrg swizzling (equivalent to vec3.xzzxy).
        /// </summary>
        public vec5 rbbrg => new vec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns vec3.xzzxz swizzling.
        /// </summary>
        public vec5 xzzxz => new vec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns vec3.rbbrb swizzling (equivalent to vec3.xzzxz).
        /// </summary>
        public vec5 rbbrb => new vec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns vec3.xzzy swizzling.
        /// </summary>
        public vec4 xzzy => new vec4(x, z, z, y);
        
        /// <summary>
        /// Returns vec3.rbbg swizzling (equivalent to vec3.xzzy).
        /// </summary>
        public vec4 rbbg => new vec4(x, z, z, y);
        
        /// <summary>
        /// Returns vec3.xzzyx swizzling.
        /// </summary>
        public vec5 xzzyx => new vec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns vec3.rbbgr swizzling (equivalent to vec3.xzzyx).
        /// </summary>
        public vec5 rbbgr => new vec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns vec3.xzzyy swizzling.
        /// </summary>
        public vec5 xzzyy => new vec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns vec3.rbbgg swizzling (equivalent to vec3.xzzyy).
        /// </summary>
        public vec5 rbbgg => new vec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns vec3.xzzyz swizzling.
        /// </summary>
        public vec5 xzzyz => new vec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns vec3.rbbgb swizzling (equivalent to vec3.xzzyz).
        /// </summary>
        public vec5 rbbgb => new vec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns vec3.xzzz swizzling.
        /// </summary>
        public vec4 xzzz => new vec4(x, z, z, z);
        
        /// <summary>
        /// Returns vec3.rbbb swizzling (equivalent to vec3.xzzz).
        /// </summary>
        public vec4 rbbb => new vec4(x, z, z, z);
        
        /// <summary>
        /// Returns vec3.xzzzx swizzling.
        /// </summary>
        public vec5 xzzzx => new vec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns vec3.rbbbr swizzling (equivalent to vec3.xzzzx).
        /// </summary>
        public vec5 rbbbr => new vec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns vec3.xzzzy swizzling.
        /// </summary>
        public vec5 xzzzy => new vec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns vec3.rbbbg swizzling (equivalent to vec3.xzzzy).
        /// </summary>
        public vec5 rbbbg => new vec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns vec3.xzzzz swizzling.
        /// </summary>
        public vec5 xzzzz => new vec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns vec3.rbbbb swizzling (equivalent to vec3.xzzzz).
        /// </summary>
        public vec5 rbbbb => new vec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns vec3.yx swizzling.
        /// </summary>
        public vec2 yx => new vec2(y, x);
        
        /// <summary>
        /// Returns vec3.gr swizzling (equivalent to vec3.yx).
        /// </summary>
        public vec2 gr => new vec2(y, x);
        
        /// <summary>
        /// Returns vec3.yxx swizzling.
        /// </summary>
        public vec3 yxx => new vec3(y, x, x);
        
        /// <summary>
        /// Returns vec3.grr swizzling (equivalent to vec3.yxx).
        /// </summary>
        public vec3 grr => new vec3(y, x, x);
        
        /// <summary>
        /// Returns vec3.yxxx swizzling.
        /// </summary>
        public vec4 yxxx => new vec4(y, x, x, x);
        
        /// <summary>
        /// Returns vec3.grrr swizzling (equivalent to vec3.yxxx).
        /// </summary>
        public vec4 grrr => new vec4(y, x, x, x);
        
        /// <summary>
        /// Returns vec3.yxxxx swizzling.
        /// </summary>
        public vec5 yxxxx => new vec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns vec3.grrrr swizzling (equivalent to vec3.yxxxx).
        /// </summary>
        public vec5 grrrr => new vec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns vec3.yxxxy swizzling.
        /// </summary>
        public vec5 yxxxy => new vec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns vec3.grrrg swizzling (equivalent to vec3.yxxxy).
        /// </summary>
        public vec5 grrrg => new vec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns vec3.yxxxz swizzling.
        /// </summary>
        public vec5 yxxxz => new vec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns vec3.grrrb swizzling (equivalent to vec3.yxxxz).
        /// </summary>
        public vec5 grrrb => new vec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns vec3.yxxy swizzling.
        /// </summary>
        public vec4 yxxy => new vec4(y, x, x, y);
        
        /// <summary>
        /// Returns vec3.grrg swizzling (equivalent to vec3.yxxy).
        /// </summary>
        public vec4 grrg => new vec4(y, x, x, y);
        
        /// <summary>
        /// Returns vec3.yxxyx swizzling.
        /// </summary>
        public vec5 yxxyx => new vec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns vec3.grrgr swizzling (equivalent to vec3.yxxyx).
        /// </summary>
        public vec5 grrgr => new vec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns vec3.yxxyy swizzling.
        /// </summary>
        public vec5 yxxyy => new vec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns vec3.grrgg swizzling (equivalent to vec3.yxxyy).
        /// </summary>
        public vec5 grrgg => new vec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns vec3.yxxyz swizzling.
        /// </summary>
        public vec5 yxxyz => new vec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns vec3.grrgb swizzling (equivalent to vec3.yxxyz).
        /// </summary>
        public vec5 grrgb => new vec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns vec3.yxxz swizzling.
        /// </summary>
        public vec4 yxxz => new vec4(y, x, x, z);
        
        /// <summary>
        /// Returns vec3.grrb swizzling (equivalent to vec3.yxxz).
        /// </summary>
        public vec4 grrb => new vec4(y, x, x, z);
        
        /// <summary>
        /// Returns vec3.yxxzx swizzling.
        /// </summary>
        public vec5 yxxzx => new vec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns vec3.grrbr swizzling (equivalent to vec3.yxxzx).
        /// </summary>
        public vec5 grrbr => new vec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns vec3.yxxzy swizzling.
        /// </summary>
        public vec5 yxxzy => new vec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns vec3.grrbg swizzling (equivalent to vec3.yxxzy).
        /// </summary>
        public vec5 grrbg => new vec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns vec3.yxxzz swizzling.
        /// </summary>
        public vec5 yxxzz => new vec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns vec3.grrbb swizzling (equivalent to vec3.yxxzz).
        /// </summary>
        public vec5 grrbb => new vec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns vec3.yxy swizzling.
        /// </summary>
        public vec3 yxy => new vec3(y, x, y);
        
        /// <summary>
        /// Returns vec3.grg swizzling (equivalent to vec3.yxy).
        /// </summary>
        public vec3 grg => new vec3(y, x, y);
        
        /// <summary>
        /// Returns vec3.yxyx swizzling.
        /// </summary>
        public vec4 yxyx => new vec4(y, x, y, x);
        
        /// <summary>
        /// Returns vec3.grgr swizzling (equivalent to vec3.yxyx).
        /// </summary>
        public vec4 grgr => new vec4(y, x, y, x);
        
        /// <summary>
        /// Returns vec3.yxyxx swizzling.
        /// </summary>
        public vec5 yxyxx => new vec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns vec3.grgrr swizzling (equivalent to vec3.yxyxx).
        /// </summary>
        public vec5 grgrr => new vec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns vec3.yxyxy swizzling.
        /// </summary>
        public vec5 yxyxy => new vec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns vec3.grgrg swizzling (equivalent to vec3.yxyxy).
        /// </summary>
        public vec5 grgrg => new vec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns vec3.yxyxz swizzling.
        /// </summary>
        public vec5 yxyxz => new vec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns vec3.grgrb swizzling (equivalent to vec3.yxyxz).
        /// </summary>
        public vec5 grgrb => new vec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns vec3.yxyy swizzling.
        /// </summary>
        public vec4 yxyy => new vec4(y, x, y, y);
        
        /// <summary>
        /// Returns vec3.grgg swizzling (equivalent to vec3.yxyy).
        /// </summary>
        public vec4 grgg => new vec4(y, x, y, y);
        
        /// <summary>
        /// Returns vec3.yxyyx swizzling.
        /// </summary>
        public vec5 yxyyx => new vec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns vec3.grggr swizzling (equivalent to vec3.yxyyx).
        /// </summary>
        public vec5 grggr => new vec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns vec3.yxyyy swizzling.
        /// </summary>
        public vec5 yxyyy => new vec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns vec3.grggg swizzling (equivalent to vec3.yxyyy).
        /// </summary>
        public vec5 grggg => new vec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns vec3.yxyyz swizzling.
        /// </summary>
        public vec5 yxyyz => new vec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns vec3.grggb swizzling (equivalent to vec3.yxyyz).
        /// </summary>
        public vec5 grggb => new vec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns vec3.yxyz swizzling.
        /// </summary>
        public vec4 yxyz => new vec4(y, x, y, z);
        
        /// <summary>
        /// Returns vec3.grgb swizzling (equivalent to vec3.yxyz).
        /// </summary>
        public vec4 grgb => new vec4(y, x, y, z);
        
        /// <summary>
        /// Returns vec3.yxyzx swizzling.
        /// </summary>
        public vec5 yxyzx => new vec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns vec3.grgbr swizzling (equivalent to vec3.yxyzx).
        /// </summary>
        public vec5 grgbr => new vec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns vec3.yxyzy swizzling.
        /// </summary>
        public vec5 yxyzy => new vec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns vec3.grgbg swizzling (equivalent to vec3.yxyzy).
        /// </summary>
        public vec5 grgbg => new vec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns vec3.yxyzz swizzling.
        /// </summary>
        public vec5 yxyzz => new vec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns vec3.grgbb swizzling (equivalent to vec3.yxyzz).
        /// </summary>
        public vec5 grgbb => new vec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns vec3.yxz swizzling.
        /// </summary>
        public vec3 yxz => new vec3(y, x, z);
        
        /// <summary>
        /// Returns vec3.grb swizzling (equivalent to vec3.yxz).
        /// </summary>
        public vec3 grb => new vec3(y, x, z);
        
        /// <summary>
        /// Returns vec3.yxzx swizzling.
        /// </summary>
        public vec4 yxzx => new vec4(y, x, z, x);
        
        /// <summary>
        /// Returns vec3.grbr swizzling (equivalent to vec3.yxzx).
        /// </summary>
        public vec4 grbr => new vec4(y, x, z, x);
        
        /// <summary>
        /// Returns vec3.yxzxx swizzling.
        /// </summary>
        public vec5 yxzxx => new vec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns vec3.grbrr swizzling (equivalent to vec3.yxzxx).
        /// </summary>
        public vec5 grbrr => new vec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns vec3.yxzxy swizzling.
        /// </summary>
        public vec5 yxzxy => new vec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns vec3.grbrg swizzling (equivalent to vec3.yxzxy).
        /// </summary>
        public vec5 grbrg => new vec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns vec3.yxzxz swizzling.
        /// </summary>
        public vec5 yxzxz => new vec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns vec3.grbrb swizzling (equivalent to vec3.yxzxz).
        /// </summary>
        public vec5 grbrb => new vec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns vec3.yxzy swizzling.
        /// </summary>
        public vec4 yxzy => new vec4(y, x, z, y);
        
        /// <summary>
        /// Returns vec3.grbg swizzling (equivalent to vec3.yxzy).
        /// </summary>
        public vec4 grbg => new vec4(y, x, z, y);
        
        /// <summary>
        /// Returns vec3.yxzyx swizzling.
        /// </summary>
        public vec5 yxzyx => new vec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns vec3.grbgr swizzling (equivalent to vec3.yxzyx).
        /// </summary>
        public vec5 grbgr => new vec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns vec3.yxzyy swizzling.
        /// </summary>
        public vec5 yxzyy => new vec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns vec3.grbgg swizzling (equivalent to vec3.yxzyy).
        /// </summary>
        public vec5 grbgg => new vec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns vec3.yxzyz swizzling.
        /// </summary>
        public vec5 yxzyz => new vec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns vec3.grbgb swizzling (equivalent to vec3.yxzyz).
        /// </summary>
        public vec5 grbgb => new vec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns vec3.yxzz swizzling.
        /// </summary>
        public vec4 yxzz => new vec4(y, x, z, z);
        
        /// <summary>
        /// Returns vec3.grbb swizzling (equivalent to vec3.yxzz).
        /// </summary>
        public vec4 grbb => new vec4(y, x, z, z);
        
        /// <summary>
        /// Returns vec3.yxzzx swizzling.
        /// </summary>
        public vec5 yxzzx => new vec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns vec3.grbbr swizzling (equivalent to vec3.yxzzx).
        /// </summary>
        public vec5 grbbr => new vec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns vec3.yxzzy swizzling.
        /// </summary>
        public vec5 yxzzy => new vec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns vec3.grbbg swizzling (equivalent to vec3.yxzzy).
        /// </summary>
        public vec5 grbbg => new vec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns vec3.yxzzz swizzling.
        /// </summary>
        public vec5 yxzzz => new vec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns vec3.grbbb swizzling (equivalent to vec3.yxzzz).
        /// </summary>
        public vec5 grbbb => new vec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns vec3.yy swizzling.
        /// </summary>
        public vec2 yy => new vec2(y, y);
        
        /// <summary>
        /// Returns vec3.gg swizzling (equivalent to vec3.yy).
        /// </summary>
        public vec2 gg => new vec2(y, y);
        
        /// <summary>
        /// Returns vec3.yyx swizzling.
        /// </summary>
        public vec3 yyx => new vec3(y, y, x);
        
        /// <summary>
        /// Returns vec3.ggr swizzling (equivalent to vec3.yyx).
        /// </summary>
        public vec3 ggr => new vec3(y, y, x);
        
        /// <summary>
        /// Returns vec3.yyxx swizzling.
        /// </summary>
        public vec4 yyxx => new vec4(y, y, x, x);
        
        /// <summary>
        /// Returns vec3.ggrr swizzling (equivalent to vec3.yyxx).
        /// </summary>
        public vec4 ggrr => new vec4(y, y, x, x);
        
        /// <summary>
        /// Returns vec3.yyxxx swizzling.
        /// </summary>
        public vec5 yyxxx => new vec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns vec3.ggrrr swizzling (equivalent to vec3.yyxxx).
        /// </summary>
        public vec5 ggrrr => new vec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns vec3.yyxxy swizzling.
        /// </summary>
        public vec5 yyxxy => new vec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns vec3.ggrrg swizzling (equivalent to vec3.yyxxy).
        /// </summary>
        public vec5 ggrrg => new vec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns vec3.yyxxz swizzling.
        /// </summary>
        public vec5 yyxxz => new vec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns vec3.ggrrb swizzling (equivalent to vec3.yyxxz).
        /// </summary>
        public vec5 ggrrb => new vec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns vec3.yyxy swizzling.
        /// </summary>
        public vec4 yyxy => new vec4(y, y, x, y);
        
        /// <summary>
        /// Returns vec3.ggrg swizzling (equivalent to vec3.yyxy).
        /// </summary>
        public vec4 ggrg => new vec4(y, y, x, y);
        
        /// <summary>
        /// Returns vec3.yyxyx swizzling.
        /// </summary>
        public vec5 yyxyx => new vec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns vec3.ggrgr swizzling (equivalent to vec3.yyxyx).
        /// </summary>
        public vec5 ggrgr => new vec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns vec3.yyxyy swizzling.
        /// </summary>
        public vec5 yyxyy => new vec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns vec3.ggrgg swizzling (equivalent to vec3.yyxyy).
        /// </summary>
        public vec5 ggrgg => new vec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns vec3.yyxyz swizzling.
        /// </summary>
        public vec5 yyxyz => new vec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns vec3.ggrgb swizzling (equivalent to vec3.yyxyz).
        /// </summary>
        public vec5 ggrgb => new vec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns vec3.yyxz swizzling.
        /// </summary>
        public vec4 yyxz => new vec4(y, y, x, z);
        
        /// <summary>
        /// Returns vec3.ggrb swizzling (equivalent to vec3.yyxz).
        /// </summary>
        public vec4 ggrb => new vec4(y, y, x, z);
        
        /// <summary>
        /// Returns vec3.yyxzx swizzling.
        /// </summary>
        public vec5 yyxzx => new vec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns vec3.ggrbr swizzling (equivalent to vec3.yyxzx).
        /// </summary>
        public vec5 ggrbr => new vec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns vec3.yyxzy swizzling.
        /// </summary>
        public vec5 yyxzy => new vec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns vec3.ggrbg swizzling (equivalent to vec3.yyxzy).
        /// </summary>
        public vec5 ggrbg => new vec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns vec3.yyxzz swizzling.
        /// </summary>
        public vec5 yyxzz => new vec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns vec3.ggrbb swizzling (equivalent to vec3.yyxzz).
        /// </summary>
        public vec5 ggrbb => new vec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns vec3.yyy swizzling.
        /// </summary>
        public vec3 yyy => new vec3(y, y, y);
        
        /// <summary>
        /// Returns vec3.ggg swizzling (equivalent to vec3.yyy).
        /// </summary>
        public vec3 ggg => new vec3(y, y, y);
        
        /// <summary>
        /// Returns vec3.yyyx swizzling.
        /// </summary>
        public vec4 yyyx => new vec4(y, y, y, x);
        
        /// <summary>
        /// Returns vec3.gggr swizzling (equivalent to vec3.yyyx).
        /// </summary>
        public vec4 gggr => new vec4(y, y, y, x);
        
        /// <summary>
        /// Returns vec3.yyyxx swizzling.
        /// </summary>
        public vec5 yyyxx => new vec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns vec3.gggrr swizzling (equivalent to vec3.yyyxx).
        /// </summary>
        public vec5 gggrr => new vec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns vec3.yyyxy swizzling.
        /// </summary>
        public vec5 yyyxy => new vec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns vec3.gggrg swizzling (equivalent to vec3.yyyxy).
        /// </summary>
        public vec5 gggrg => new vec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns vec3.yyyxz swizzling.
        /// </summary>
        public vec5 yyyxz => new vec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns vec3.gggrb swizzling (equivalent to vec3.yyyxz).
        /// </summary>
        public vec5 gggrb => new vec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns vec3.yyyy swizzling.
        /// </summary>
        public vec4 yyyy => new vec4(y, y, y, y);
        
        /// <summary>
        /// Returns vec3.gggg swizzling (equivalent to vec3.yyyy).
        /// </summary>
        public vec4 gggg => new vec4(y, y, y, y);
        
        /// <summary>
        /// Returns vec3.yyyyx swizzling.
        /// </summary>
        public vec5 yyyyx => new vec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns vec3.ggggr swizzling (equivalent to vec3.yyyyx).
        /// </summary>
        public vec5 ggggr => new vec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns vec3.yyyyy swizzling.
        /// </summary>
        public vec5 yyyyy => new vec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns vec3.ggggg swizzling (equivalent to vec3.yyyyy).
        /// </summary>
        public vec5 ggggg => new vec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns vec3.yyyyz swizzling.
        /// </summary>
        public vec5 yyyyz => new vec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns vec3.ggggb swizzling (equivalent to vec3.yyyyz).
        /// </summary>
        public vec5 ggggb => new vec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns vec3.yyyz swizzling.
        /// </summary>
        public vec4 yyyz => new vec4(y, y, y, z);
        
        /// <summary>
        /// Returns vec3.gggb swizzling (equivalent to vec3.yyyz).
        /// </summary>
        public vec4 gggb => new vec4(y, y, y, z);
        
        /// <summary>
        /// Returns vec3.yyyzx swizzling.
        /// </summary>
        public vec5 yyyzx => new vec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns vec3.gggbr swizzling (equivalent to vec3.yyyzx).
        /// </summary>
        public vec5 gggbr => new vec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns vec3.yyyzy swizzling.
        /// </summary>
        public vec5 yyyzy => new vec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns vec3.gggbg swizzling (equivalent to vec3.yyyzy).
        /// </summary>
        public vec5 gggbg => new vec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns vec3.yyyzz swizzling.
        /// </summary>
        public vec5 yyyzz => new vec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns vec3.gggbb swizzling (equivalent to vec3.yyyzz).
        /// </summary>
        public vec5 gggbb => new vec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns vec3.yyz swizzling.
        /// </summary>
        public vec3 yyz => new vec3(y, y, z);
        
        /// <summary>
        /// Returns vec3.ggb swizzling (equivalent to vec3.yyz).
        /// </summary>
        public vec3 ggb => new vec3(y, y, z);
        
        /// <summary>
        /// Returns vec3.yyzx swizzling.
        /// </summary>
        public vec4 yyzx => new vec4(y, y, z, x);
        
        /// <summary>
        /// Returns vec3.ggbr swizzling (equivalent to vec3.yyzx).
        /// </summary>
        public vec4 ggbr => new vec4(y, y, z, x);
        
        /// <summary>
        /// Returns vec3.yyzxx swizzling.
        /// </summary>
        public vec5 yyzxx => new vec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns vec3.ggbrr swizzling (equivalent to vec3.yyzxx).
        /// </summary>
        public vec5 ggbrr => new vec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns vec3.yyzxy swizzling.
        /// </summary>
        public vec5 yyzxy => new vec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns vec3.ggbrg swizzling (equivalent to vec3.yyzxy).
        /// </summary>
        public vec5 ggbrg => new vec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns vec3.yyzxz swizzling.
        /// </summary>
        public vec5 yyzxz => new vec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns vec3.ggbrb swizzling (equivalent to vec3.yyzxz).
        /// </summary>
        public vec5 ggbrb => new vec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns vec3.yyzy swizzling.
        /// </summary>
        public vec4 yyzy => new vec4(y, y, z, y);
        
        /// <summary>
        /// Returns vec3.ggbg swizzling (equivalent to vec3.yyzy).
        /// </summary>
        public vec4 ggbg => new vec4(y, y, z, y);
        
        /// <summary>
        /// Returns vec3.yyzyx swizzling.
        /// </summary>
        public vec5 yyzyx => new vec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns vec3.ggbgr swizzling (equivalent to vec3.yyzyx).
        /// </summary>
        public vec5 ggbgr => new vec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns vec3.yyzyy swizzling.
        /// </summary>
        public vec5 yyzyy => new vec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns vec3.ggbgg swizzling (equivalent to vec3.yyzyy).
        /// </summary>
        public vec5 ggbgg => new vec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns vec3.yyzyz swizzling.
        /// </summary>
        public vec5 yyzyz => new vec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns vec3.ggbgb swizzling (equivalent to vec3.yyzyz).
        /// </summary>
        public vec5 ggbgb => new vec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns vec3.yyzz swizzling.
        /// </summary>
        public vec4 yyzz => new vec4(y, y, z, z);
        
        /// <summary>
        /// Returns vec3.ggbb swizzling (equivalent to vec3.yyzz).
        /// </summary>
        public vec4 ggbb => new vec4(y, y, z, z);
        
        /// <summary>
        /// Returns vec3.yyzzx swizzling.
        /// </summary>
        public vec5 yyzzx => new vec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns vec3.ggbbr swizzling (equivalent to vec3.yyzzx).
        /// </summary>
        public vec5 ggbbr => new vec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns vec3.yyzzy swizzling.
        /// </summary>
        public vec5 yyzzy => new vec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns vec3.ggbbg swizzling (equivalent to vec3.yyzzy).
        /// </summary>
        public vec5 ggbbg => new vec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns vec3.yyzzz swizzling.
        /// </summary>
        public vec5 yyzzz => new vec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns vec3.ggbbb swizzling (equivalent to vec3.yyzzz).
        /// </summary>
        public vec5 ggbbb => new vec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns vec3.yz swizzling.
        /// </summary>
        public vec2 yz => new vec2(y, z);
        
        /// <summary>
        /// Returns vec3.gb swizzling (equivalent to vec3.yz).
        /// </summary>
        public vec2 gb => new vec2(y, z);
        
        /// <summary>
        /// Returns vec3.yzx swizzling.
        /// </summary>
        public vec3 yzx => new vec3(y, z, x);
        
        /// <summary>
        /// Returns vec3.gbr swizzling (equivalent to vec3.yzx).
        /// </summary>
        public vec3 gbr => new vec3(y, z, x);
        
        /// <summary>
        /// Returns vec3.yzxx swizzling.
        /// </summary>
        public vec4 yzxx => new vec4(y, z, x, x);
        
        /// <summary>
        /// Returns vec3.gbrr swizzling (equivalent to vec3.yzxx).
        /// </summary>
        public vec4 gbrr => new vec4(y, z, x, x);
        
        /// <summary>
        /// Returns vec3.yzxxx swizzling.
        /// </summary>
        public vec5 yzxxx => new vec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns vec3.gbrrr swizzling (equivalent to vec3.yzxxx).
        /// </summary>
        public vec5 gbrrr => new vec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns vec3.yzxxy swizzling.
        /// </summary>
        public vec5 yzxxy => new vec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns vec3.gbrrg swizzling (equivalent to vec3.yzxxy).
        /// </summary>
        public vec5 gbrrg => new vec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns vec3.yzxxz swizzling.
        /// </summary>
        public vec5 yzxxz => new vec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns vec3.gbrrb swizzling (equivalent to vec3.yzxxz).
        /// </summary>
        public vec5 gbrrb => new vec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns vec3.yzxy swizzling.
        /// </summary>
        public vec4 yzxy => new vec4(y, z, x, y);
        
        /// <summary>
        /// Returns vec3.gbrg swizzling (equivalent to vec3.yzxy).
        /// </summary>
        public vec4 gbrg => new vec4(y, z, x, y);
        
        /// <summary>
        /// Returns vec3.yzxyx swizzling.
        /// </summary>
        public vec5 yzxyx => new vec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns vec3.gbrgr swizzling (equivalent to vec3.yzxyx).
        /// </summary>
        public vec5 gbrgr => new vec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns vec3.yzxyy swizzling.
        /// </summary>
        public vec5 yzxyy => new vec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns vec3.gbrgg swizzling (equivalent to vec3.yzxyy).
        /// </summary>
        public vec5 gbrgg => new vec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns vec3.yzxyz swizzling.
        /// </summary>
        public vec5 yzxyz => new vec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns vec3.gbrgb swizzling (equivalent to vec3.yzxyz).
        /// </summary>
        public vec5 gbrgb => new vec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns vec3.yzxz swizzling.
        /// </summary>
        public vec4 yzxz => new vec4(y, z, x, z);
        
        /// <summary>
        /// Returns vec3.gbrb swizzling (equivalent to vec3.yzxz).
        /// </summary>
        public vec4 gbrb => new vec4(y, z, x, z);
        
        /// <summary>
        /// Returns vec3.yzxzx swizzling.
        /// </summary>
        public vec5 yzxzx => new vec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns vec3.gbrbr swizzling (equivalent to vec3.yzxzx).
        /// </summary>
        public vec5 gbrbr => new vec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns vec3.yzxzy swizzling.
        /// </summary>
        public vec5 yzxzy => new vec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns vec3.gbrbg swizzling (equivalent to vec3.yzxzy).
        /// </summary>
        public vec5 gbrbg => new vec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns vec3.yzxzz swizzling.
        /// </summary>
        public vec5 yzxzz => new vec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns vec3.gbrbb swizzling (equivalent to vec3.yzxzz).
        /// </summary>
        public vec5 gbrbb => new vec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns vec3.yzy swizzling.
        /// </summary>
        public vec3 yzy => new vec3(y, z, y);
        
        /// <summary>
        /// Returns vec3.gbg swizzling (equivalent to vec3.yzy).
        /// </summary>
        public vec3 gbg => new vec3(y, z, y);
        
        /// <summary>
        /// Returns vec3.yzyx swizzling.
        /// </summary>
        public vec4 yzyx => new vec4(y, z, y, x);
        
        /// <summary>
        /// Returns vec3.gbgr swizzling (equivalent to vec3.yzyx).
        /// </summary>
        public vec4 gbgr => new vec4(y, z, y, x);
        
        /// <summary>
        /// Returns vec3.yzyxx swizzling.
        /// </summary>
        public vec5 yzyxx => new vec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns vec3.gbgrr swizzling (equivalent to vec3.yzyxx).
        /// </summary>
        public vec5 gbgrr => new vec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns vec3.yzyxy swizzling.
        /// </summary>
        public vec5 yzyxy => new vec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns vec3.gbgrg swizzling (equivalent to vec3.yzyxy).
        /// </summary>
        public vec5 gbgrg => new vec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns vec3.yzyxz swizzling.
        /// </summary>
        public vec5 yzyxz => new vec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns vec3.gbgrb swizzling (equivalent to vec3.yzyxz).
        /// </summary>
        public vec5 gbgrb => new vec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns vec3.yzyy swizzling.
        /// </summary>
        public vec4 yzyy => new vec4(y, z, y, y);
        
        /// <summary>
        /// Returns vec3.gbgg swizzling (equivalent to vec3.yzyy).
        /// </summary>
        public vec4 gbgg => new vec4(y, z, y, y);
        
        /// <summary>
        /// Returns vec3.yzyyx swizzling.
        /// </summary>
        public vec5 yzyyx => new vec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns vec3.gbggr swizzling (equivalent to vec3.yzyyx).
        /// </summary>
        public vec5 gbggr => new vec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns vec3.yzyyy swizzling.
        /// </summary>
        public vec5 yzyyy => new vec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns vec3.gbggg swizzling (equivalent to vec3.yzyyy).
        /// </summary>
        public vec5 gbggg => new vec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns vec3.yzyyz swizzling.
        /// </summary>
        public vec5 yzyyz => new vec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns vec3.gbggb swizzling (equivalent to vec3.yzyyz).
        /// </summary>
        public vec5 gbggb => new vec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns vec3.yzyz swizzling.
        /// </summary>
        public vec4 yzyz => new vec4(y, z, y, z);
        
        /// <summary>
        /// Returns vec3.gbgb swizzling (equivalent to vec3.yzyz).
        /// </summary>
        public vec4 gbgb => new vec4(y, z, y, z);
        
        /// <summary>
        /// Returns vec3.yzyzx swizzling.
        /// </summary>
        public vec5 yzyzx => new vec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns vec3.gbgbr swizzling (equivalent to vec3.yzyzx).
        /// </summary>
        public vec5 gbgbr => new vec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns vec3.yzyzy swizzling.
        /// </summary>
        public vec5 yzyzy => new vec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns vec3.gbgbg swizzling (equivalent to vec3.yzyzy).
        /// </summary>
        public vec5 gbgbg => new vec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns vec3.yzyzz swizzling.
        /// </summary>
        public vec5 yzyzz => new vec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns vec3.gbgbb swizzling (equivalent to vec3.yzyzz).
        /// </summary>
        public vec5 gbgbb => new vec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns vec3.yzz swizzling.
        /// </summary>
        public vec3 yzz => new vec3(y, z, z);
        
        /// <summary>
        /// Returns vec3.gbb swizzling (equivalent to vec3.yzz).
        /// </summary>
        public vec3 gbb => new vec3(y, z, z);
        
        /// <summary>
        /// Returns vec3.yzzx swizzling.
        /// </summary>
        public vec4 yzzx => new vec4(y, z, z, x);
        
        /// <summary>
        /// Returns vec3.gbbr swizzling (equivalent to vec3.yzzx).
        /// </summary>
        public vec4 gbbr => new vec4(y, z, z, x);
        
        /// <summary>
        /// Returns vec3.yzzxx swizzling.
        /// </summary>
        public vec5 yzzxx => new vec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns vec3.gbbrr swizzling (equivalent to vec3.yzzxx).
        /// </summary>
        public vec5 gbbrr => new vec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns vec3.yzzxy swizzling.
        /// </summary>
        public vec5 yzzxy => new vec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns vec3.gbbrg swizzling (equivalent to vec3.yzzxy).
        /// </summary>
        public vec5 gbbrg => new vec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns vec3.yzzxz swizzling.
        /// </summary>
        public vec5 yzzxz => new vec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns vec3.gbbrb swizzling (equivalent to vec3.yzzxz).
        /// </summary>
        public vec5 gbbrb => new vec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns vec3.yzzy swizzling.
        /// </summary>
        public vec4 yzzy => new vec4(y, z, z, y);
        
        /// <summary>
        /// Returns vec3.gbbg swizzling (equivalent to vec3.yzzy).
        /// </summary>
        public vec4 gbbg => new vec4(y, z, z, y);
        
        /// <summary>
        /// Returns vec3.yzzyx swizzling.
        /// </summary>
        public vec5 yzzyx => new vec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns vec3.gbbgr swizzling (equivalent to vec3.yzzyx).
        /// </summary>
        public vec5 gbbgr => new vec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns vec3.yzzyy swizzling.
        /// </summary>
        public vec5 yzzyy => new vec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns vec3.gbbgg swizzling (equivalent to vec3.yzzyy).
        /// </summary>
        public vec5 gbbgg => new vec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns vec3.yzzyz swizzling.
        /// </summary>
        public vec5 yzzyz => new vec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns vec3.gbbgb swizzling (equivalent to vec3.yzzyz).
        /// </summary>
        public vec5 gbbgb => new vec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns vec3.yzzz swizzling.
        /// </summary>
        public vec4 yzzz => new vec4(y, z, z, z);
        
        /// <summary>
        /// Returns vec3.gbbb swizzling (equivalent to vec3.yzzz).
        /// </summary>
        public vec4 gbbb => new vec4(y, z, z, z);
        
        /// <summary>
        /// Returns vec3.yzzzx swizzling.
        /// </summary>
        public vec5 yzzzx => new vec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns vec3.gbbbr swizzling (equivalent to vec3.yzzzx).
        /// </summary>
        public vec5 gbbbr => new vec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns vec3.yzzzy swizzling.
        /// </summary>
        public vec5 yzzzy => new vec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns vec3.gbbbg swizzling (equivalent to vec3.yzzzy).
        /// </summary>
        public vec5 gbbbg => new vec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns vec3.yzzzz swizzling.
        /// </summary>
        public vec5 yzzzz => new vec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns vec3.gbbbb swizzling (equivalent to vec3.yzzzz).
        /// </summary>
        public vec5 gbbbb => new vec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns vec3.zx swizzling.
        /// </summary>
        public vec2 zx => new vec2(z, x);
        
        /// <summary>
        /// Returns vec3.br swizzling (equivalent to vec3.zx).
        /// </summary>
        public vec2 br => new vec2(z, x);
        
        /// <summary>
        /// Returns vec3.zxx swizzling.
        /// </summary>
        public vec3 zxx => new vec3(z, x, x);
        
        /// <summary>
        /// Returns vec3.brr swizzling (equivalent to vec3.zxx).
        /// </summary>
        public vec3 brr => new vec3(z, x, x);
        
        /// <summary>
        /// Returns vec3.zxxx swizzling.
        /// </summary>
        public vec4 zxxx => new vec4(z, x, x, x);
        
        /// <summary>
        /// Returns vec3.brrr swizzling (equivalent to vec3.zxxx).
        /// </summary>
        public vec4 brrr => new vec4(z, x, x, x);
        
        /// <summary>
        /// Returns vec3.zxxxx swizzling.
        /// </summary>
        public vec5 zxxxx => new vec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns vec3.brrrr swizzling (equivalent to vec3.zxxxx).
        /// </summary>
        public vec5 brrrr => new vec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns vec3.zxxxy swizzling.
        /// </summary>
        public vec5 zxxxy => new vec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns vec3.brrrg swizzling (equivalent to vec3.zxxxy).
        /// </summary>
        public vec5 brrrg => new vec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns vec3.zxxxz swizzling.
        /// </summary>
        public vec5 zxxxz => new vec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns vec3.brrrb swizzling (equivalent to vec3.zxxxz).
        /// </summary>
        public vec5 brrrb => new vec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns vec3.zxxy swizzling.
        /// </summary>
        public vec4 zxxy => new vec4(z, x, x, y);
        
        /// <summary>
        /// Returns vec3.brrg swizzling (equivalent to vec3.zxxy).
        /// </summary>
        public vec4 brrg => new vec4(z, x, x, y);
        
        /// <summary>
        /// Returns vec3.zxxyx swizzling.
        /// </summary>
        public vec5 zxxyx => new vec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns vec3.brrgr swizzling (equivalent to vec3.zxxyx).
        /// </summary>
        public vec5 brrgr => new vec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns vec3.zxxyy swizzling.
        /// </summary>
        public vec5 zxxyy => new vec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns vec3.brrgg swizzling (equivalent to vec3.zxxyy).
        /// </summary>
        public vec5 brrgg => new vec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns vec3.zxxyz swizzling.
        /// </summary>
        public vec5 zxxyz => new vec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns vec3.brrgb swizzling (equivalent to vec3.zxxyz).
        /// </summary>
        public vec5 brrgb => new vec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns vec3.zxxz swizzling.
        /// </summary>
        public vec4 zxxz => new vec4(z, x, x, z);
        
        /// <summary>
        /// Returns vec3.brrb swizzling (equivalent to vec3.zxxz).
        /// </summary>
        public vec4 brrb => new vec4(z, x, x, z);
        
        /// <summary>
        /// Returns vec3.zxxzx swizzling.
        /// </summary>
        public vec5 zxxzx => new vec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns vec3.brrbr swizzling (equivalent to vec3.zxxzx).
        /// </summary>
        public vec5 brrbr => new vec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns vec3.zxxzy swizzling.
        /// </summary>
        public vec5 zxxzy => new vec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns vec3.brrbg swizzling (equivalent to vec3.zxxzy).
        /// </summary>
        public vec5 brrbg => new vec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns vec3.zxxzz swizzling.
        /// </summary>
        public vec5 zxxzz => new vec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns vec3.brrbb swizzling (equivalent to vec3.zxxzz).
        /// </summary>
        public vec5 brrbb => new vec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns vec3.zxy swizzling.
        /// </summary>
        public vec3 zxy => new vec3(z, x, y);
        
        /// <summary>
        /// Returns vec3.brg swizzling (equivalent to vec3.zxy).
        /// </summary>
        public vec3 brg => new vec3(z, x, y);
        
        /// <summary>
        /// Returns vec3.zxyx swizzling.
        /// </summary>
        public vec4 zxyx => new vec4(z, x, y, x);
        
        /// <summary>
        /// Returns vec3.brgr swizzling (equivalent to vec3.zxyx).
        /// </summary>
        public vec4 brgr => new vec4(z, x, y, x);
        
        /// <summary>
        /// Returns vec3.zxyxx swizzling.
        /// </summary>
        public vec5 zxyxx => new vec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns vec3.brgrr swizzling (equivalent to vec3.zxyxx).
        /// </summary>
        public vec5 brgrr => new vec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns vec3.zxyxy swizzling.
        /// </summary>
        public vec5 zxyxy => new vec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns vec3.brgrg swizzling (equivalent to vec3.zxyxy).
        /// </summary>
        public vec5 brgrg => new vec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns vec3.zxyxz swizzling.
        /// </summary>
        public vec5 zxyxz => new vec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns vec3.brgrb swizzling (equivalent to vec3.zxyxz).
        /// </summary>
        public vec5 brgrb => new vec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns vec3.zxyy swizzling.
        /// </summary>
        public vec4 zxyy => new vec4(z, x, y, y);
        
        /// <summary>
        /// Returns vec3.brgg swizzling (equivalent to vec3.zxyy).
        /// </summary>
        public vec4 brgg => new vec4(z, x, y, y);
        
        /// <summary>
        /// Returns vec3.zxyyx swizzling.
        /// </summary>
        public vec5 zxyyx => new vec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns vec3.brggr swizzling (equivalent to vec3.zxyyx).
        /// </summary>
        public vec5 brggr => new vec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns vec3.zxyyy swizzling.
        /// </summary>
        public vec5 zxyyy => new vec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns vec3.brggg swizzling (equivalent to vec3.zxyyy).
        /// </summary>
        public vec5 brggg => new vec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns vec3.zxyyz swizzling.
        /// </summary>
        public vec5 zxyyz => new vec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns vec3.brggb swizzling (equivalent to vec3.zxyyz).
        /// </summary>
        public vec5 brggb => new vec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns vec3.zxyz swizzling.
        /// </summary>
        public vec4 zxyz => new vec4(z, x, y, z);
        
        /// <summary>
        /// Returns vec3.brgb swizzling (equivalent to vec3.zxyz).
        /// </summary>
        public vec4 brgb => new vec4(z, x, y, z);
        
        /// <summary>
        /// Returns vec3.zxyzx swizzling.
        /// </summary>
        public vec5 zxyzx => new vec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns vec3.brgbr swizzling (equivalent to vec3.zxyzx).
        /// </summary>
        public vec5 brgbr => new vec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns vec3.zxyzy swizzling.
        /// </summary>
        public vec5 zxyzy => new vec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns vec3.brgbg swizzling (equivalent to vec3.zxyzy).
        /// </summary>
        public vec5 brgbg => new vec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns vec3.zxyzz swizzling.
        /// </summary>
        public vec5 zxyzz => new vec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns vec3.brgbb swizzling (equivalent to vec3.zxyzz).
        /// </summary>
        public vec5 brgbb => new vec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns vec3.zxz swizzling.
        /// </summary>
        public vec3 zxz => new vec3(z, x, z);
        
        /// <summary>
        /// Returns vec3.brb swizzling (equivalent to vec3.zxz).
        /// </summary>
        public vec3 brb => new vec3(z, x, z);
        
        /// <summary>
        /// Returns vec3.zxzx swizzling.
        /// </summary>
        public vec4 zxzx => new vec4(z, x, z, x);
        
        /// <summary>
        /// Returns vec3.brbr swizzling (equivalent to vec3.zxzx).
        /// </summary>
        public vec4 brbr => new vec4(z, x, z, x);
        
        /// <summary>
        /// Returns vec3.zxzxx swizzling.
        /// </summary>
        public vec5 zxzxx => new vec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns vec3.brbrr swizzling (equivalent to vec3.zxzxx).
        /// </summary>
        public vec5 brbrr => new vec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns vec3.zxzxy swizzling.
        /// </summary>
        public vec5 zxzxy => new vec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns vec3.brbrg swizzling (equivalent to vec3.zxzxy).
        /// </summary>
        public vec5 brbrg => new vec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns vec3.zxzxz swizzling.
        /// </summary>
        public vec5 zxzxz => new vec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns vec3.brbrb swizzling (equivalent to vec3.zxzxz).
        /// </summary>
        public vec5 brbrb => new vec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns vec3.zxzy swizzling.
        /// </summary>
        public vec4 zxzy => new vec4(z, x, z, y);
        
        /// <summary>
        /// Returns vec3.brbg swizzling (equivalent to vec3.zxzy).
        /// </summary>
        public vec4 brbg => new vec4(z, x, z, y);
        
        /// <summary>
        /// Returns vec3.zxzyx swizzling.
        /// </summary>
        public vec5 zxzyx => new vec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns vec3.brbgr swizzling (equivalent to vec3.zxzyx).
        /// </summary>
        public vec5 brbgr => new vec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns vec3.zxzyy swizzling.
        /// </summary>
        public vec5 zxzyy => new vec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns vec3.brbgg swizzling (equivalent to vec3.zxzyy).
        /// </summary>
        public vec5 brbgg => new vec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns vec3.zxzyz swizzling.
        /// </summary>
        public vec5 zxzyz => new vec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns vec3.brbgb swizzling (equivalent to vec3.zxzyz).
        /// </summary>
        public vec5 brbgb => new vec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns vec3.zxzz swizzling.
        /// </summary>
        public vec4 zxzz => new vec4(z, x, z, z);
        
        /// <summary>
        /// Returns vec3.brbb swizzling (equivalent to vec3.zxzz).
        /// </summary>
        public vec4 brbb => new vec4(z, x, z, z);
        
        /// <summary>
        /// Returns vec3.zxzzx swizzling.
        /// </summary>
        public vec5 zxzzx => new vec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns vec3.brbbr swizzling (equivalent to vec3.zxzzx).
        /// </summary>
        public vec5 brbbr => new vec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns vec3.zxzzy swizzling.
        /// </summary>
        public vec5 zxzzy => new vec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns vec3.brbbg swizzling (equivalent to vec3.zxzzy).
        /// </summary>
        public vec5 brbbg => new vec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns vec3.zxzzz swizzling.
        /// </summary>
        public vec5 zxzzz => new vec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns vec3.brbbb swizzling (equivalent to vec3.zxzzz).
        /// </summary>
        public vec5 brbbb => new vec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns vec3.zy swizzling.
        /// </summary>
        public vec2 zy => new vec2(z, y);
        
        /// <summary>
        /// Returns vec3.bg swizzling (equivalent to vec3.zy).
        /// </summary>
        public vec2 bg => new vec2(z, y);
        
        /// <summary>
        /// Returns vec3.zyx swizzling.
        /// </summary>
        public vec3 zyx => new vec3(z, y, x);
        
        /// <summary>
        /// Returns vec3.bgr swizzling (equivalent to vec3.zyx).
        /// </summary>
        public vec3 bgr => new vec3(z, y, x);
        
        /// <summary>
        /// Returns vec3.zyxx swizzling.
        /// </summary>
        public vec4 zyxx => new vec4(z, y, x, x);
        
        /// <summary>
        /// Returns vec3.bgrr swizzling (equivalent to vec3.zyxx).
        /// </summary>
        public vec4 bgrr => new vec4(z, y, x, x);
        
        /// <summary>
        /// Returns vec3.zyxxx swizzling.
        /// </summary>
        public vec5 zyxxx => new vec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns vec3.bgrrr swizzling (equivalent to vec3.zyxxx).
        /// </summary>
        public vec5 bgrrr => new vec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns vec3.zyxxy swizzling.
        /// </summary>
        public vec5 zyxxy => new vec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns vec3.bgrrg swizzling (equivalent to vec3.zyxxy).
        /// </summary>
        public vec5 bgrrg => new vec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns vec3.zyxxz swizzling.
        /// </summary>
        public vec5 zyxxz => new vec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns vec3.bgrrb swizzling (equivalent to vec3.zyxxz).
        /// </summary>
        public vec5 bgrrb => new vec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns vec3.zyxy swizzling.
        /// </summary>
        public vec4 zyxy => new vec4(z, y, x, y);
        
        /// <summary>
        /// Returns vec3.bgrg swizzling (equivalent to vec3.zyxy).
        /// </summary>
        public vec4 bgrg => new vec4(z, y, x, y);
        
        /// <summary>
        /// Returns vec3.zyxyx swizzling.
        /// </summary>
        public vec5 zyxyx => new vec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns vec3.bgrgr swizzling (equivalent to vec3.zyxyx).
        /// </summary>
        public vec5 bgrgr => new vec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns vec3.zyxyy swizzling.
        /// </summary>
        public vec5 zyxyy => new vec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns vec3.bgrgg swizzling (equivalent to vec3.zyxyy).
        /// </summary>
        public vec5 bgrgg => new vec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns vec3.zyxyz swizzling.
        /// </summary>
        public vec5 zyxyz => new vec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns vec3.bgrgb swizzling (equivalent to vec3.zyxyz).
        /// </summary>
        public vec5 bgrgb => new vec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns vec3.zyxz swizzling.
        /// </summary>
        public vec4 zyxz => new vec4(z, y, x, z);
        
        /// <summary>
        /// Returns vec3.bgrb swizzling (equivalent to vec3.zyxz).
        /// </summary>
        public vec4 bgrb => new vec4(z, y, x, z);
        
        /// <summary>
        /// Returns vec3.zyxzx swizzling.
        /// </summary>
        public vec5 zyxzx => new vec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns vec3.bgrbr swizzling (equivalent to vec3.zyxzx).
        /// </summary>
        public vec5 bgrbr => new vec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns vec3.zyxzy swizzling.
        /// </summary>
        public vec5 zyxzy => new vec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns vec3.bgrbg swizzling (equivalent to vec3.zyxzy).
        /// </summary>
        public vec5 bgrbg => new vec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns vec3.zyxzz swizzling.
        /// </summary>
        public vec5 zyxzz => new vec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns vec3.bgrbb swizzling (equivalent to vec3.zyxzz).
        /// </summary>
        public vec5 bgrbb => new vec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns vec3.zyy swizzling.
        /// </summary>
        public vec3 zyy => new vec3(z, y, y);
        
        /// <summary>
        /// Returns vec3.bgg swizzling (equivalent to vec3.zyy).
        /// </summary>
        public vec3 bgg => new vec3(z, y, y);
        
        /// <summary>
        /// Returns vec3.zyyx swizzling.
        /// </summary>
        public vec4 zyyx => new vec4(z, y, y, x);
        
        /// <summary>
        /// Returns vec3.bggr swizzling (equivalent to vec3.zyyx).
        /// </summary>
        public vec4 bggr => new vec4(z, y, y, x);
        
        /// <summary>
        /// Returns vec3.zyyxx swizzling.
        /// </summary>
        public vec5 zyyxx => new vec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns vec3.bggrr swizzling (equivalent to vec3.zyyxx).
        /// </summary>
        public vec5 bggrr => new vec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns vec3.zyyxy swizzling.
        /// </summary>
        public vec5 zyyxy => new vec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns vec3.bggrg swizzling (equivalent to vec3.zyyxy).
        /// </summary>
        public vec5 bggrg => new vec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns vec3.zyyxz swizzling.
        /// </summary>
        public vec5 zyyxz => new vec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns vec3.bggrb swizzling (equivalent to vec3.zyyxz).
        /// </summary>
        public vec5 bggrb => new vec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns vec3.zyyy swizzling.
        /// </summary>
        public vec4 zyyy => new vec4(z, y, y, y);
        
        /// <summary>
        /// Returns vec3.bggg swizzling (equivalent to vec3.zyyy).
        /// </summary>
        public vec4 bggg => new vec4(z, y, y, y);
        
        /// <summary>
        /// Returns vec3.zyyyx swizzling.
        /// </summary>
        public vec5 zyyyx => new vec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns vec3.bgggr swizzling (equivalent to vec3.zyyyx).
        /// </summary>
        public vec5 bgggr => new vec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns vec3.zyyyy swizzling.
        /// </summary>
        public vec5 zyyyy => new vec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns vec3.bgggg swizzling (equivalent to vec3.zyyyy).
        /// </summary>
        public vec5 bgggg => new vec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns vec3.zyyyz swizzling.
        /// </summary>
        public vec5 zyyyz => new vec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns vec3.bgggb swizzling (equivalent to vec3.zyyyz).
        /// </summary>
        public vec5 bgggb => new vec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns vec3.zyyz swizzling.
        /// </summary>
        public vec4 zyyz => new vec4(z, y, y, z);
        
        /// <summary>
        /// Returns vec3.bggb swizzling (equivalent to vec3.zyyz).
        /// </summary>
        public vec4 bggb => new vec4(z, y, y, z);
        
        /// <summary>
        /// Returns vec3.zyyzx swizzling.
        /// </summary>
        public vec5 zyyzx => new vec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns vec3.bggbr swizzling (equivalent to vec3.zyyzx).
        /// </summary>
        public vec5 bggbr => new vec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns vec3.zyyzy swizzling.
        /// </summary>
        public vec5 zyyzy => new vec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns vec3.bggbg swizzling (equivalent to vec3.zyyzy).
        /// </summary>
        public vec5 bggbg => new vec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns vec3.zyyzz swizzling.
        /// </summary>
        public vec5 zyyzz => new vec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns vec3.bggbb swizzling (equivalent to vec3.zyyzz).
        /// </summary>
        public vec5 bggbb => new vec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns vec3.zyz swizzling.
        /// </summary>
        public vec3 zyz => new vec3(z, y, z);
        
        /// <summary>
        /// Returns vec3.bgb swizzling (equivalent to vec3.zyz).
        /// </summary>
        public vec3 bgb => new vec3(z, y, z);
        
        /// <summary>
        /// Returns vec3.zyzx swizzling.
        /// </summary>
        public vec4 zyzx => new vec4(z, y, z, x);
        
        /// <summary>
        /// Returns vec3.bgbr swizzling (equivalent to vec3.zyzx).
        /// </summary>
        public vec4 bgbr => new vec4(z, y, z, x);
        
        /// <summary>
        /// Returns vec3.zyzxx swizzling.
        /// </summary>
        public vec5 zyzxx => new vec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns vec3.bgbrr swizzling (equivalent to vec3.zyzxx).
        /// </summary>
        public vec5 bgbrr => new vec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns vec3.zyzxy swizzling.
        /// </summary>
        public vec5 zyzxy => new vec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns vec3.bgbrg swizzling (equivalent to vec3.zyzxy).
        /// </summary>
        public vec5 bgbrg => new vec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns vec3.zyzxz swizzling.
        /// </summary>
        public vec5 zyzxz => new vec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns vec3.bgbrb swizzling (equivalent to vec3.zyzxz).
        /// </summary>
        public vec5 bgbrb => new vec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns vec3.zyzy swizzling.
        /// </summary>
        public vec4 zyzy => new vec4(z, y, z, y);
        
        /// <summary>
        /// Returns vec3.bgbg swizzling (equivalent to vec3.zyzy).
        /// </summary>
        public vec4 bgbg => new vec4(z, y, z, y);
        
        /// <summary>
        /// Returns vec3.zyzyx swizzling.
        /// </summary>
        public vec5 zyzyx => new vec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns vec3.bgbgr swizzling (equivalent to vec3.zyzyx).
        /// </summary>
        public vec5 bgbgr => new vec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns vec3.zyzyy swizzling.
        /// </summary>
        public vec5 zyzyy => new vec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns vec3.bgbgg swizzling (equivalent to vec3.zyzyy).
        /// </summary>
        public vec5 bgbgg => new vec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns vec3.zyzyz swizzling.
        /// </summary>
        public vec5 zyzyz => new vec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns vec3.bgbgb swizzling (equivalent to vec3.zyzyz).
        /// </summary>
        public vec5 bgbgb => new vec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns vec3.zyzz swizzling.
        /// </summary>
        public vec4 zyzz => new vec4(z, y, z, z);
        
        /// <summary>
        /// Returns vec3.bgbb swizzling (equivalent to vec3.zyzz).
        /// </summary>
        public vec4 bgbb => new vec4(z, y, z, z);
        
        /// <summary>
        /// Returns vec3.zyzzx swizzling.
        /// </summary>
        public vec5 zyzzx => new vec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns vec3.bgbbr swizzling (equivalent to vec3.zyzzx).
        /// </summary>
        public vec5 bgbbr => new vec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns vec3.zyzzy swizzling.
        /// </summary>
        public vec5 zyzzy => new vec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns vec3.bgbbg swizzling (equivalent to vec3.zyzzy).
        /// </summary>
        public vec5 bgbbg => new vec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns vec3.zyzzz swizzling.
        /// </summary>
        public vec5 zyzzz => new vec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns vec3.bgbbb swizzling (equivalent to vec3.zyzzz).
        /// </summary>
        public vec5 bgbbb => new vec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns vec3.zz swizzling.
        /// </summary>
        public vec2 zz => new vec2(z, z);
        
        /// <summary>
        /// Returns vec3.bb swizzling (equivalent to vec3.zz).
        /// </summary>
        public vec2 bb => new vec2(z, z);
        
        /// <summary>
        /// Returns vec3.zzx swizzling.
        /// </summary>
        public vec3 zzx => new vec3(z, z, x);
        
        /// <summary>
        /// Returns vec3.bbr swizzling (equivalent to vec3.zzx).
        /// </summary>
        public vec3 bbr => new vec3(z, z, x);
        
        /// <summary>
        /// Returns vec3.zzxx swizzling.
        /// </summary>
        public vec4 zzxx => new vec4(z, z, x, x);
        
        /// <summary>
        /// Returns vec3.bbrr swizzling (equivalent to vec3.zzxx).
        /// </summary>
        public vec4 bbrr => new vec4(z, z, x, x);
        
        /// <summary>
        /// Returns vec3.zzxxx swizzling.
        /// </summary>
        public vec5 zzxxx => new vec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns vec3.bbrrr swizzling (equivalent to vec3.zzxxx).
        /// </summary>
        public vec5 bbrrr => new vec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns vec3.zzxxy swizzling.
        /// </summary>
        public vec5 zzxxy => new vec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns vec3.bbrrg swizzling (equivalent to vec3.zzxxy).
        /// </summary>
        public vec5 bbrrg => new vec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns vec3.zzxxz swizzling.
        /// </summary>
        public vec5 zzxxz => new vec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns vec3.bbrrb swizzling (equivalent to vec3.zzxxz).
        /// </summary>
        public vec5 bbrrb => new vec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns vec3.zzxy swizzling.
        /// </summary>
        public vec4 zzxy => new vec4(z, z, x, y);
        
        /// <summary>
        /// Returns vec3.bbrg swizzling (equivalent to vec3.zzxy).
        /// </summary>
        public vec4 bbrg => new vec4(z, z, x, y);
        
        /// <summary>
        /// Returns vec3.zzxyx swizzling.
        /// </summary>
        public vec5 zzxyx => new vec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns vec3.bbrgr swizzling (equivalent to vec3.zzxyx).
        /// </summary>
        public vec5 bbrgr => new vec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns vec3.zzxyy swizzling.
        /// </summary>
        public vec5 zzxyy => new vec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns vec3.bbrgg swizzling (equivalent to vec3.zzxyy).
        /// </summary>
        public vec5 bbrgg => new vec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns vec3.zzxyz swizzling.
        /// </summary>
        public vec5 zzxyz => new vec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns vec3.bbrgb swizzling (equivalent to vec3.zzxyz).
        /// </summary>
        public vec5 bbrgb => new vec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns vec3.zzxz swizzling.
        /// </summary>
        public vec4 zzxz => new vec4(z, z, x, z);
        
        /// <summary>
        /// Returns vec3.bbrb swizzling (equivalent to vec3.zzxz).
        /// </summary>
        public vec4 bbrb => new vec4(z, z, x, z);
        
        /// <summary>
        /// Returns vec3.zzxzx swizzling.
        /// </summary>
        public vec5 zzxzx => new vec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns vec3.bbrbr swizzling (equivalent to vec3.zzxzx).
        /// </summary>
        public vec5 bbrbr => new vec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns vec3.zzxzy swizzling.
        /// </summary>
        public vec5 zzxzy => new vec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns vec3.bbrbg swizzling (equivalent to vec3.zzxzy).
        /// </summary>
        public vec5 bbrbg => new vec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns vec3.zzxzz swizzling.
        /// </summary>
        public vec5 zzxzz => new vec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns vec3.bbrbb swizzling (equivalent to vec3.zzxzz).
        /// </summary>
        public vec5 bbrbb => new vec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns vec3.zzy swizzling.
        /// </summary>
        public vec3 zzy => new vec3(z, z, y);
        
        /// <summary>
        /// Returns vec3.bbg swizzling (equivalent to vec3.zzy).
        /// </summary>
        public vec3 bbg => new vec3(z, z, y);
        
        /// <summary>
        /// Returns vec3.zzyx swizzling.
        /// </summary>
        public vec4 zzyx => new vec4(z, z, y, x);
        
        /// <summary>
        /// Returns vec3.bbgr swizzling (equivalent to vec3.zzyx).
        /// </summary>
        public vec4 bbgr => new vec4(z, z, y, x);
        
        /// <summary>
        /// Returns vec3.zzyxx swizzling.
        /// </summary>
        public vec5 zzyxx => new vec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns vec3.bbgrr swizzling (equivalent to vec3.zzyxx).
        /// </summary>
        public vec5 bbgrr => new vec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns vec3.zzyxy swizzling.
        /// </summary>
        public vec5 zzyxy => new vec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns vec3.bbgrg swizzling (equivalent to vec3.zzyxy).
        /// </summary>
        public vec5 bbgrg => new vec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns vec3.zzyxz swizzling.
        /// </summary>
        public vec5 zzyxz => new vec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns vec3.bbgrb swizzling (equivalent to vec3.zzyxz).
        /// </summary>
        public vec5 bbgrb => new vec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns vec3.zzyy swizzling.
        /// </summary>
        public vec4 zzyy => new vec4(z, z, y, y);
        
        /// <summary>
        /// Returns vec3.bbgg swizzling (equivalent to vec3.zzyy).
        /// </summary>
        public vec4 bbgg => new vec4(z, z, y, y);
        
        /// <summary>
        /// Returns vec3.zzyyx swizzling.
        /// </summary>
        public vec5 zzyyx => new vec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns vec3.bbggr swizzling (equivalent to vec3.zzyyx).
        /// </summary>
        public vec5 bbggr => new vec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns vec3.zzyyy swizzling.
        /// </summary>
        public vec5 zzyyy => new vec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns vec3.bbggg swizzling (equivalent to vec3.zzyyy).
        /// </summary>
        public vec5 bbggg => new vec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns vec3.zzyyz swizzling.
        /// </summary>
        public vec5 zzyyz => new vec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns vec3.bbggb swizzling (equivalent to vec3.zzyyz).
        /// </summary>
        public vec5 bbggb => new vec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns vec3.zzyz swizzling.
        /// </summary>
        public vec4 zzyz => new vec4(z, z, y, z);
        
        /// <summary>
        /// Returns vec3.bbgb swizzling (equivalent to vec3.zzyz).
        /// </summary>
        public vec4 bbgb => new vec4(z, z, y, z);
        
        /// <summary>
        /// Returns vec3.zzyzx swizzling.
        /// </summary>
        public vec5 zzyzx => new vec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns vec3.bbgbr swizzling (equivalent to vec3.zzyzx).
        /// </summary>
        public vec5 bbgbr => new vec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns vec3.zzyzy swizzling.
        /// </summary>
        public vec5 zzyzy => new vec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns vec3.bbgbg swizzling (equivalent to vec3.zzyzy).
        /// </summary>
        public vec5 bbgbg => new vec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns vec3.zzyzz swizzling.
        /// </summary>
        public vec5 zzyzz => new vec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns vec3.bbgbb swizzling (equivalent to vec3.zzyzz).
        /// </summary>
        public vec5 bbgbb => new vec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns vec3.zzz swizzling.
        /// </summary>
        public vec3 zzz => new vec3(z, z, z);
        
        /// <summary>
        /// Returns vec3.bbb swizzling (equivalent to vec3.zzz).
        /// </summary>
        public vec3 bbb => new vec3(z, z, z);
        
        /// <summary>
        /// Returns vec3.zzzx swizzling.
        /// </summary>
        public vec4 zzzx => new vec4(z, z, z, x);
        
        /// <summary>
        /// Returns vec3.bbbr swizzling (equivalent to vec3.zzzx).
        /// </summary>
        public vec4 bbbr => new vec4(z, z, z, x);
        
        /// <summary>
        /// Returns vec3.zzzxx swizzling.
        /// </summary>
        public vec5 zzzxx => new vec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns vec3.bbbrr swizzling (equivalent to vec3.zzzxx).
        /// </summary>
        public vec5 bbbrr => new vec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns vec3.zzzxy swizzling.
        /// </summary>
        public vec5 zzzxy => new vec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns vec3.bbbrg swizzling (equivalent to vec3.zzzxy).
        /// </summary>
        public vec5 bbbrg => new vec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns vec3.zzzxz swizzling.
        /// </summary>
        public vec5 zzzxz => new vec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns vec3.bbbrb swizzling (equivalent to vec3.zzzxz).
        /// </summary>
        public vec5 bbbrb => new vec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns vec3.zzzy swizzling.
        /// </summary>
        public vec4 zzzy => new vec4(z, z, z, y);
        
        /// <summary>
        /// Returns vec3.bbbg swizzling (equivalent to vec3.zzzy).
        /// </summary>
        public vec4 bbbg => new vec4(z, z, z, y);
        
        /// <summary>
        /// Returns vec3.zzzyx swizzling.
        /// </summary>
        public vec5 zzzyx => new vec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns vec3.bbbgr swizzling (equivalent to vec3.zzzyx).
        /// </summary>
        public vec5 bbbgr => new vec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns vec3.zzzyy swizzling.
        /// </summary>
        public vec5 zzzyy => new vec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns vec3.bbbgg swizzling (equivalent to vec3.zzzyy).
        /// </summary>
        public vec5 bbbgg => new vec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns vec3.zzzyz swizzling.
        /// </summary>
        public vec5 zzzyz => new vec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns vec3.bbbgb swizzling (equivalent to vec3.zzzyz).
        /// </summary>
        public vec5 bbbgb => new vec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns vec3.zzzz swizzling.
        /// </summary>
        public vec4 zzzz => new vec4(z, z, z, z);
        
        /// <summary>
        /// Returns vec3.bbbb swizzling (equivalent to vec3.zzzz).
        /// </summary>
        public vec4 bbbb => new vec4(z, z, z, z);
        
        /// <summary>
        /// Returns vec3.zzzzx swizzling.
        /// </summary>
        public vec5 zzzzx => new vec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns vec3.bbbbr swizzling (equivalent to vec3.zzzzx).
        /// </summary>
        public vec5 bbbbr => new vec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns vec3.zzzzy swizzling.
        /// </summary>
        public vec5 zzzzy => new vec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns vec3.bbbbg swizzling (equivalent to vec3.zzzzy).
        /// </summary>
        public vec5 bbbbg => new vec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns vec3.zzzzz swizzling.
        /// </summary>
        public vec5 zzzzz => new vec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns vec3.bbbbb swizzling (equivalent to vec3.zzzzz).
        /// </summary>
        public vec5 bbbbb => new vec5(z, z, z, z, z);

        #endregion

    }
}
