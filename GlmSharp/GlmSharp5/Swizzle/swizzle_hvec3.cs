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
    /// Temporary vector of type Half with 3 components, used for implementing swizzling for hvec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_hvec3
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly Half x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly Half y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly Half z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_hvec3.
        /// </summary>
        internal swizzle_hvec3(Half x, Half y, Half z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns hvec3.xx swizzling.
        /// </summary>
        public hvec2 xx => new hvec2(x, x);
        
        /// <summary>
        /// Returns hvec3.rr swizzling (equivalent to hvec3.xx).
        /// </summary>
        public hvec2 rr => new hvec2(x, x);
        
        /// <summary>
        /// Returns hvec3.xxx swizzling.
        /// </summary>
        public hvec3 xxx => new hvec3(x, x, x);
        
        /// <summary>
        /// Returns hvec3.rrr swizzling (equivalent to hvec3.xxx).
        /// </summary>
        public hvec3 rrr => new hvec3(x, x, x);
        
        /// <summary>
        /// Returns hvec3.xxxx swizzling.
        /// </summary>
        public hvec4 xxxx => new hvec4(x, x, x, x);
        
        /// <summary>
        /// Returns hvec3.rrrr swizzling (equivalent to hvec3.xxxx).
        /// </summary>
        public hvec4 rrrr => new hvec4(x, x, x, x);
        
        /// <summary>
        /// Returns hvec3.xxxxx swizzling.
        /// </summary>
        public hvec5 xxxxx => new hvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns hvec3.rrrrr swizzling (equivalent to hvec3.xxxxx).
        /// </summary>
        public hvec5 rrrrr => new hvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns hvec3.xxxxy swizzling.
        /// </summary>
        public hvec5 xxxxy => new hvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns hvec3.rrrrg swizzling (equivalent to hvec3.xxxxy).
        /// </summary>
        public hvec5 rrrrg => new hvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns hvec3.xxxxz swizzling.
        /// </summary>
        public hvec5 xxxxz => new hvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns hvec3.rrrrb swizzling (equivalent to hvec3.xxxxz).
        /// </summary>
        public hvec5 rrrrb => new hvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns hvec3.xxxy swizzling.
        /// </summary>
        public hvec4 xxxy => new hvec4(x, x, x, y);
        
        /// <summary>
        /// Returns hvec3.rrrg swizzling (equivalent to hvec3.xxxy).
        /// </summary>
        public hvec4 rrrg => new hvec4(x, x, x, y);
        
        /// <summary>
        /// Returns hvec3.xxxyx swizzling.
        /// </summary>
        public hvec5 xxxyx => new hvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns hvec3.rrrgr swizzling (equivalent to hvec3.xxxyx).
        /// </summary>
        public hvec5 rrrgr => new hvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns hvec3.xxxyy swizzling.
        /// </summary>
        public hvec5 xxxyy => new hvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns hvec3.rrrgg swizzling (equivalent to hvec3.xxxyy).
        /// </summary>
        public hvec5 rrrgg => new hvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns hvec3.xxxyz swizzling.
        /// </summary>
        public hvec5 xxxyz => new hvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns hvec3.rrrgb swizzling (equivalent to hvec3.xxxyz).
        /// </summary>
        public hvec5 rrrgb => new hvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns hvec3.xxxz swizzling.
        /// </summary>
        public hvec4 xxxz => new hvec4(x, x, x, z);
        
        /// <summary>
        /// Returns hvec3.rrrb swizzling (equivalent to hvec3.xxxz).
        /// </summary>
        public hvec4 rrrb => new hvec4(x, x, x, z);
        
        /// <summary>
        /// Returns hvec3.xxxzx swizzling.
        /// </summary>
        public hvec5 xxxzx => new hvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns hvec3.rrrbr swizzling (equivalent to hvec3.xxxzx).
        /// </summary>
        public hvec5 rrrbr => new hvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns hvec3.xxxzy swizzling.
        /// </summary>
        public hvec5 xxxzy => new hvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns hvec3.rrrbg swizzling (equivalent to hvec3.xxxzy).
        /// </summary>
        public hvec5 rrrbg => new hvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns hvec3.xxxzz swizzling.
        /// </summary>
        public hvec5 xxxzz => new hvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns hvec3.rrrbb swizzling (equivalent to hvec3.xxxzz).
        /// </summary>
        public hvec5 rrrbb => new hvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns hvec3.xxy swizzling.
        /// </summary>
        public hvec3 xxy => new hvec3(x, x, y);
        
        /// <summary>
        /// Returns hvec3.rrg swizzling (equivalent to hvec3.xxy).
        /// </summary>
        public hvec3 rrg => new hvec3(x, x, y);
        
        /// <summary>
        /// Returns hvec3.xxyx swizzling.
        /// </summary>
        public hvec4 xxyx => new hvec4(x, x, y, x);
        
        /// <summary>
        /// Returns hvec3.rrgr swizzling (equivalent to hvec3.xxyx).
        /// </summary>
        public hvec4 rrgr => new hvec4(x, x, y, x);
        
        /// <summary>
        /// Returns hvec3.xxyxx swizzling.
        /// </summary>
        public hvec5 xxyxx => new hvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns hvec3.rrgrr swizzling (equivalent to hvec3.xxyxx).
        /// </summary>
        public hvec5 rrgrr => new hvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns hvec3.xxyxy swizzling.
        /// </summary>
        public hvec5 xxyxy => new hvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns hvec3.rrgrg swizzling (equivalent to hvec3.xxyxy).
        /// </summary>
        public hvec5 rrgrg => new hvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns hvec3.xxyxz swizzling.
        /// </summary>
        public hvec5 xxyxz => new hvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns hvec3.rrgrb swizzling (equivalent to hvec3.xxyxz).
        /// </summary>
        public hvec5 rrgrb => new hvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns hvec3.xxyy swizzling.
        /// </summary>
        public hvec4 xxyy => new hvec4(x, x, y, y);
        
        /// <summary>
        /// Returns hvec3.rrgg swizzling (equivalent to hvec3.xxyy).
        /// </summary>
        public hvec4 rrgg => new hvec4(x, x, y, y);
        
        /// <summary>
        /// Returns hvec3.xxyyx swizzling.
        /// </summary>
        public hvec5 xxyyx => new hvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns hvec3.rrggr swizzling (equivalent to hvec3.xxyyx).
        /// </summary>
        public hvec5 rrggr => new hvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns hvec3.xxyyy swizzling.
        /// </summary>
        public hvec5 xxyyy => new hvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns hvec3.rrggg swizzling (equivalent to hvec3.xxyyy).
        /// </summary>
        public hvec5 rrggg => new hvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns hvec3.xxyyz swizzling.
        /// </summary>
        public hvec5 xxyyz => new hvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns hvec3.rrggb swizzling (equivalent to hvec3.xxyyz).
        /// </summary>
        public hvec5 rrggb => new hvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns hvec3.xxyz swizzling.
        /// </summary>
        public hvec4 xxyz => new hvec4(x, x, y, z);
        
        /// <summary>
        /// Returns hvec3.rrgb swizzling (equivalent to hvec3.xxyz).
        /// </summary>
        public hvec4 rrgb => new hvec4(x, x, y, z);
        
        /// <summary>
        /// Returns hvec3.xxyzx swizzling.
        /// </summary>
        public hvec5 xxyzx => new hvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns hvec3.rrgbr swizzling (equivalent to hvec3.xxyzx).
        /// </summary>
        public hvec5 rrgbr => new hvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns hvec3.xxyzy swizzling.
        /// </summary>
        public hvec5 xxyzy => new hvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns hvec3.rrgbg swizzling (equivalent to hvec3.xxyzy).
        /// </summary>
        public hvec5 rrgbg => new hvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns hvec3.xxyzz swizzling.
        /// </summary>
        public hvec5 xxyzz => new hvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns hvec3.rrgbb swizzling (equivalent to hvec3.xxyzz).
        /// </summary>
        public hvec5 rrgbb => new hvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns hvec3.xxz swizzling.
        /// </summary>
        public hvec3 xxz => new hvec3(x, x, z);
        
        /// <summary>
        /// Returns hvec3.rrb swizzling (equivalent to hvec3.xxz).
        /// </summary>
        public hvec3 rrb => new hvec3(x, x, z);
        
        /// <summary>
        /// Returns hvec3.xxzx swizzling.
        /// </summary>
        public hvec4 xxzx => new hvec4(x, x, z, x);
        
        /// <summary>
        /// Returns hvec3.rrbr swizzling (equivalent to hvec3.xxzx).
        /// </summary>
        public hvec4 rrbr => new hvec4(x, x, z, x);
        
        /// <summary>
        /// Returns hvec3.xxzxx swizzling.
        /// </summary>
        public hvec5 xxzxx => new hvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns hvec3.rrbrr swizzling (equivalent to hvec3.xxzxx).
        /// </summary>
        public hvec5 rrbrr => new hvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns hvec3.xxzxy swizzling.
        /// </summary>
        public hvec5 xxzxy => new hvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns hvec3.rrbrg swizzling (equivalent to hvec3.xxzxy).
        /// </summary>
        public hvec5 rrbrg => new hvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns hvec3.xxzxz swizzling.
        /// </summary>
        public hvec5 xxzxz => new hvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns hvec3.rrbrb swizzling (equivalent to hvec3.xxzxz).
        /// </summary>
        public hvec5 rrbrb => new hvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns hvec3.xxzy swizzling.
        /// </summary>
        public hvec4 xxzy => new hvec4(x, x, z, y);
        
        /// <summary>
        /// Returns hvec3.rrbg swizzling (equivalent to hvec3.xxzy).
        /// </summary>
        public hvec4 rrbg => new hvec4(x, x, z, y);
        
        /// <summary>
        /// Returns hvec3.xxzyx swizzling.
        /// </summary>
        public hvec5 xxzyx => new hvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns hvec3.rrbgr swizzling (equivalent to hvec3.xxzyx).
        /// </summary>
        public hvec5 rrbgr => new hvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns hvec3.xxzyy swizzling.
        /// </summary>
        public hvec5 xxzyy => new hvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns hvec3.rrbgg swizzling (equivalent to hvec3.xxzyy).
        /// </summary>
        public hvec5 rrbgg => new hvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns hvec3.xxzyz swizzling.
        /// </summary>
        public hvec5 xxzyz => new hvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns hvec3.rrbgb swizzling (equivalent to hvec3.xxzyz).
        /// </summary>
        public hvec5 rrbgb => new hvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns hvec3.xxzz swizzling.
        /// </summary>
        public hvec4 xxzz => new hvec4(x, x, z, z);
        
        /// <summary>
        /// Returns hvec3.rrbb swizzling (equivalent to hvec3.xxzz).
        /// </summary>
        public hvec4 rrbb => new hvec4(x, x, z, z);
        
        /// <summary>
        /// Returns hvec3.xxzzx swizzling.
        /// </summary>
        public hvec5 xxzzx => new hvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns hvec3.rrbbr swizzling (equivalent to hvec3.xxzzx).
        /// </summary>
        public hvec5 rrbbr => new hvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns hvec3.xxzzy swizzling.
        /// </summary>
        public hvec5 xxzzy => new hvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns hvec3.rrbbg swizzling (equivalent to hvec3.xxzzy).
        /// </summary>
        public hvec5 rrbbg => new hvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns hvec3.xxzzz swizzling.
        /// </summary>
        public hvec5 xxzzz => new hvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns hvec3.rrbbb swizzling (equivalent to hvec3.xxzzz).
        /// </summary>
        public hvec5 rrbbb => new hvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns hvec3.xy swizzling.
        /// </summary>
        public hvec2 xy => new hvec2(x, y);
        
        /// <summary>
        /// Returns hvec3.rg swizzling (equivalent to hvec3.xy).
        /// </summary>
        public hvec2 rg => new hvec2(x, y);
        
        /// <summary>
        /// Returns hvec3.xyx swizzling.
        /// </summary>
        public hvec3 xyx => new hvec3(x, y, x);
        
        /// <summary>
        /// Returns hvec3.rgr swizzling (equivalent to hvec3.xyx).
        /// </summary>
        public hvec3 rgr => new hvec3(x, y, x);
        
        /// <summary>
        /// Returns hvec3.xyxx swizzling.
        /// </summary>
        public hvec4 xyxx => new hvec4(x, y, x, x);
        
        /// <summary>
        /// Returns hvec3.rgrr swizzling (equivalent to hvec3.xyxx).
        /// </summary>
        public hvec4 rgrr => new hvec4(x, y, x, x);
        
        /// <summary>
        /// Returns hvec3.xyxxx swizzling.
        /// </summary>
        public hvec5 xyxxx => new hvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns hvec3.rgrrr swizzling (equivalent to hvec3.xyxxx).
        /// </summary>
        public hvec5 rgrrr => new hvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns hvec3.xyxxy swizzling.
        /// </summary>
        public hvec5 xyxxy => new hvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns hvec3.rgrrg swizzling (equivalent to hvec3.xyxxy).
        /// </summary>
        public hvec5 rgrrg => new hvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns hvec3.xyxxz swizzling.
        /// </summary>
        public hvec5 xyxxz => new hvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns hvec3.rgrrb swizzling (equivalent to hvec3.xyxxz).
        /// </summary>
        public hvec5 rgrrb => new hvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns hvec3.xyxy swizzling.
        /// </summary>
        public hvec4 xyxy => new hvec4(x, y, x, y);
        
        /// <summary>
        /// Returns hvec3.rgrg swizzling (equivalent to hvec3.xyxy).
        /// </summary>
        public hvec4 rgrg => new hvec4(x, y, x, y);
        
        /// <summary>
        /// Returns hvec3.xyxyx swizzling.
        /// </summary>
        public hvec5 xyxyx => new hvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns hvec3.rgrgr swizzling (equivalent to hvec3.xyxyx).
        /// </summary>
        public hvec5 rgrgr => new hvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns hvec3.xyxyy swizzling.
        /// </summary>
        public hvec5 xyxyy => new hvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns hvec3.rgrgg swizzling (equivalent to hvec3.xyxyy).
        /// </summary>
        public hvec5 rgrgg => new hvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns hvec3.xyxyz swizzling.
        /// </summary>
        public hvec5 xyxyz => new hvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns hvec3.rgrgb swizzling (equivalent to hvec3.xyxyz).
        /// </summary>
        public hvec5 rgrgb => new hvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns hvec3.xyxz swizzling.
        /// </summary>
        public hvec4 xyxz => new hvec4(x, y, x, z);
        
        /// <summary>
        /// Returns hvec3.rgrb swizzling (equivalent to hvec3.xyxz).
        /// </summary>
        public hvec4 rgrb => new hvec4(x, y, x, z);
        
        /// <summary>
        /// Returns hvec3.xyxzx swizzling.
        /// </summary>
        public hvec5 xyxzx => new hvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns hvec3.rgrbr swizzling (equivalent to hvec3.xyxzx).
        /// </summary>
        public hvec5 rgrbr => new hvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns hvec3.xyxzy swizzling.
        /// </summary>
        public hvec5 xyxzy => new hvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns hvec3.rgrbg swizzling (equivalent to hvec3.xyxzy).
        /// </summary>
        public hvec5 rgrbg => new hvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns hvec3.xyxzz swizzling.
        /// </summary>
        public hvec5 xyxzz => new hvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns hvec3.rgrbb swizzling (equivalent to hvec3.xyxzz).
        /// </summary>
        public hvec5 rgrbb => new hvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns hvec3.xyy swizzling.
        /// </summary>
        public hvec3 xyy => new hvec3(x, y, y);
        
        /// <summary>
        /// Returns hvec3.rgg swizzling (equivalent to hvec3.xyy).
        /// </summary>
        public hvec3 rgg => new hvec3(x, y, y);
        
        /// <summary>
        /// Returns hvec3.xyyx swizzling.
        /// </summary>
        public hvec4 xyyx => new hvec4(x, y, y, x);
        
        /// <summary>
        /// Returns hvec3.rggr swizzling (equivalent to hvec3.xyyx).
        /// </summary>
        public hvec4 rggr => new hvec4(x, y, y, x);
        
        /// <summary>
        /// Returns hvec3.xyyxx swizzling.
        /// </summary>
        public hvec5 xyyxx => new hvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns hvec3.rggrr swizzling (equivalent to hvec3.xyyxx).
        /// </summary>
        public hvec5 rggrr => new hvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns hvec3.xyyxy swizzling.
        /// </summary>
        public hvec5 xyyxy => new hvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns hvec3.rggrg swizzling (equivalent to hvec3.xyyxy).
        /// </summary>
        public hvec5 rggrg => new hvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns hvec3.xyyxz swizzling.
        /// </summary>
        public hvec5 xyyxz => new hvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns hvec3.rggrb swizzling (equivalent to hvec3.xyyxz).
        /// </summary>
        public hvec5 rggrb => new hvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns hvec3.xyyy swizzling.
        /// </summary>
        public hvec4 xyyy => new hvec4(x, y, y, y);
        
        /// <summary>
        /// Returns hvec3.rggg swizzling (equivalent to hvec3.xyyy).
        /// </summary>
        public hvec4 rggg => new hvec4(x, y, y, y);
        
        /// <summary>
        /// Returns hvec3.xyyyx swizzling.
        /// </summary>
        public hvec5 xyyyx => new hvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns hvec3.rgggr swizzling (equivalent to hvec3.xyyyx).
        /// </summary>
        public hvec5 rgggr => new hvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns hvec3.xyyyy swizzling.
        /// </summary>
        public hvec5 xyyyy => new hvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns hvec3.rgggg swizzling (equivalent to hvec3.xyyyy).
        /// </summary>
        public hvec5 rgggg => new hvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns hvec3.xyyyz swizzling.
        /// </summary>
        public hvec5 xyyyz => new hvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns hvec3.rgggb swizzling (equivalent to hvec3.xyyyz).
        /// </summary>
        public hvec5 rgggb => new hvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns hvec3.xyyz swizzling.
        /// </summary>
        public hvec4 xyyz => new hvec4(x, y, y, z);
        
        /// <summary>
        /// Returns hvec3.rggb swizzling (equivalent to hvec3.xyyz).
        /// </summary>
        public hvec4 rggb => new hvec4(x, y, y, z);
        
        /// <summary>
        /// Returns hvec3.xyyzx swizzling.
        /// </summary>
        public hvec5 xyyzx => new hvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns hvec3.rggbr swizzling (equivalent to hvec3.xyyzx).
        /// </summary>
        public hvec5 rggbr => new hvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns hvec3.xyyzy swizzling.
        /// </summary>
        public hvec5 xyyzy => new hvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns hvec3.rggbg swizzling (equivalent to hvec3.xyyzy).
        /// </summary>
        public hvec5 rggbg => new hvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns hvec3.xyyzz swizzling.
        /// </summary>
        public hvec5 xyyzz => new hvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns hvec3.rggbb swizzling (equivalent to hvec3.xyyzz).
        /// </summary>
        public hvec5 rggbb => new hvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns hvec3.xyz swizzling.
        /// </summary>
        public hvec3 xyz => new hvec3(x, y, z);
        
        /// <summary>
        /// Returns hvec3.rgb swizzling (equivalent to hvec3.xyz).
        /// </summary>
        public hvec3 rgb => new hvec3(x, y, z);
        
        /// <summary>
        /// Returns hvec3.xyzx swizzling.
        /// </summary>
        public hvec4 xyzx => new hvec4(x, y, z, x);
        
        /// <summary>
        /// Returns hvec3.rgbr swizzling (equivalent to hvec3.xyzx).
        /// </summary>
        public hvec4 rgbr => new hvec4(x, y, z, x);
        
        /// <summary>
        /// Returns hvec3.xyzxx swizzling.
        /// </summary>
        public hvec5 xyzxx => new hvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns hvec3.rgbrr swizzling (equivalent to hvec3.xyzxx).
        /// </summary>
        public hvec5 rgbrr => new hvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns hvec3.xyzxy swizzling.
        /// </summary>
        public hvec5 xyzxy => new hvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns hvec3.rgbrg swizzling (equivalent to hvec3.xyzxy).
        /// </summary>
        public hvec5 rgbrg => new hvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns hvec3.xyzxz swizzling.
        /// </summary>
        public hvec5 xyzxz => new hvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns hvec3.rgbrb swizzling (equivalent to hvec3.xyzxz).
        /// </summary>
        public hvec5 rgbrb => new hvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns hvec3.xyzy swizzling.
        /// </summary>
        public hvec4 xyzy => new hvec4(x, y, z, y);
        
        /// <summary>
        /// Returns hvec3.rgbg swizzling (equivalent to hvec3.xyzy).
        /// </summary>
        public hvec4 rgbg => new hvec4(x, y, z, y);
        
        /// <summary>
        /// Returns hvec3.xyzyx swizzling.
        /// </summary>
        public hvec5 xyzyx => new hvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns hvec3.rgbgr swizzling (equivalent to hvec3.xyzyx).
        /// </summary>
        public hvec5 rgbgr => new hvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns hvec3.xyzyy swizzling.
        /// </summary>
        public hvec5 xyzyy => new hvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns hvec3.rgbgg swizzling (equivalent to hvec3.xyzyy).
        /// </summary>
        public hvec5 rgbgg => new hvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns hvec3.xyzyz swizzling.
        /// </summary>
        public hvec5 xyzyz => new hvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns hvec3.rgbgb swizzling (equivalent to hvec3.xyzyz).
        /// </summary>
        public hvec5 rgbgb => new hvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns hvec3.xyzz swizzling.
        /// </summary>
        public hvec4 xyzz => new hvec4(x, y, z, z);
        
        /// <summary>
        /// Returns hvec3.rgbb swizzling (equivalent to hvec3.xyzz).
        /// </summary>
        public hvec4 rgbb => new hvec4(x, y, z, z);
        
        /// <summary>
        /// Returns hvec3.xyzzx swizzling.
        /// </summary>
        public hvec5 xyzzx => new hvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns hvec3.rgbbr swizzling (equivalent to hvec3.xyzzx).
        /// </summary>
        public hvec5 rgbbr => new hvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns hvec3.xyzzy swizzling.
        /// </summary>
        public hvec5 xyzzy => new hvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns hvec3.rgbbg swizzling (equivalent to hvec3.xyzzy).
        /// </summary>
        public hvec5 rgbbg => new hvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns hvec3.xyzzz swizzling.
        /// </summary>
        public hvec5 xyzzz => new hvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns hvec3.rgbbb swizzling (equivalent to hvec3.xyzzz).
        /// </summary>
        public hvec5 rgbbb => new hvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns hvec3.xz swizzling.
        /// </summary>
        public hvec2 xz => new hvec2(x, z);
        
        /// <summary>
        /// Returns hvec3.rb swizzling (equivalent to hvec3.xz).
        /// </summary>
        public hvec2 rb => new hvec2(x, z);
        
        /// <summary>
        /// Returns hvec3.xzx swizzling.
        /// </summary>
        public hvec3 xzx => new hvec3(x, z, x);
        
        /// <summary>
        /// Returns hvec3.rbr swizzling (equivalent to hvec3.xzx).
        /// </summary>
        public hvec3 rbr => new hvec3(x, z, x);
        
        /// <summary>
        /// Returns hvec3.xzxx swizzling.
        /// </summary>
        public hvec4 xzxx => new hvec4(x, z, x, x);
        
        /// <summary>
        /// Returns hvec3.rbrr swizzling (equivalent to hvec3.xzxx).
        /// </summary>
        public hvec4 rbrr => new hvec4(x, z, x, x);
        
        /// <summary>
        /// Returns hvec3.xzxxx swizzling.
        /// </summary>
        public hvec5 xzxxx => new hvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns hvec3.rbrrr swizzling (equivalent to hvec3.xzxxx).
        /// </summary>
        public hvec5 rbrrr => new hvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns hvec3.xzxxy swizzling.
        /// </summary>
        public hvec5 xzxxy => new hvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns hvec3.rbrrg swizzling (equivalent to hvec3.xzxxy).
        /// </summary>
        public hvec5 rbrrg => new hvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns hvec3.xzxxz swizzling.
        /// </summary>
        public hvec5 xzxxz => new hvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns hvec3.rbrrb swizzling (equivalent to hvec3.xzxxz).
        /// </summary>
        public hvec5 rbrrb => new hvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns hvec3.xzxy swizzling.
        /// </summary>
        public hvec4 xzxy => new hvec4(x, z, x, y);
        
        /// <summary>
        /// Returns hvec3.rbrg swizzling (equivalent to hvec3.xzxy).
        /// </summary>
        public hvec4 rbrg => new hvec4(x, z, x, y);
        
        /// <summary>
        /// Returns hvec3.xzxyx swizzling.
        /// </summary>
        public hvec5 xzxyx => new hvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns hvec3.rbrgr swizzling (equivalent to hvec3.xzxyx).
        /// </summary>
        public hvec5 rbrgr => new hvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns hvec3.xzxyy swizzling.
        /// </summary>
        public hvec5 xzxyy => new hvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns hvec3.rbrgg swizzling (equivalent to hvec3.xzxyy).
        /// </summary>
        public hvec5 rbrgg => new hvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns hvec3.xzxyz swizzling.
        /// </summary>
        public hvec5 xzxyz => new hvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns hvec3.rbrgb swizzling (equivalent to hvec3.xzxyz).
        /// </summary>
        public hvec5 rbrgb => new hvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns hvec3.xzxz swizzling.
        /// </summary>
        public hvec4 xzxz => new hvec4(x, z, x, z);
        
        /// <summary>
        /// Returns hvec3.rbrb swizzling (equivalent to hvec3.xzxz).
        /// </summary>
        public hvec4 rbrb => new hvec4(x, z, x, z);
        
        /// <summary>
        /// Returns hvec3.xzxzx swizzling.
        /// </summary>
        public hvec5 xzxzx => new hvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns hvec3.rbrbr swizzling (equivalent to hvec3.xzxzx).
        /// </summary>
        public hvec5 rbrbr => new hvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns hvec3.xzxzy swizzling.
        /// </summary>
        public hvec5 xzxzy => new hvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns hvec3.rbrbg swizzling (equivalent to hvec3.xzxzy).
        /// </summary>
        public hvec5 rbrbg => new hvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns hvec3.xzxzz swizzling.
        /// </summary>
        public hvec5 xzxzz => new hvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns hvec3.rbrbb swizzling (equivalent to hvec3.xzxzz).
        /// </summary>
        public hvec5 rbrbb => new hvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns hvec3.xzy swizzling.
        /// </summary>
        public hvec3 xzy => new hvec3(x, z, y);
        
        /// <summary>
        /// Returns hvec3.rbg swizzling (equivalent to hvec3.xzy).
        /// </summary>
        public hvec3 rbg => new hvec3(x, z, y);
        
        /// <summary>
        /// Returns hvec3.xzyx swizzling.
        /// </summary>
        public hvec4 xzyx => new hvec4(x, z, y, x);
        
        /// <summary>
        /// Returns hvec3.rbgr swizzling (equivalent to hvec3.xzyx).
        /// </summary>
        public hvec4 rbgr => new hvec4(x, z, y, x);
        
        /// <summary>
        /// Returns hvec3.xzyxx swizzling.
        /// </summary>
        public hvec5 xzyxx => new hvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns hvec3.rbgrr swizzling (equivalent to hvec3.xzyxx).
        /// </summary>
        public hvec5 rbgrr => new hvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns hvec3.xzyxy swizzling.
        /// </summary>
        public hvec5 xzyxy => new hvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns hvec3.rbgrg swizzling (equivalent to hvec3.xzyxy).
        /// </summary>
        public hvec5 rbgrg => new hvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns hvec3.xzyxz swizzling.
        /// </summary>
        public hvec5 xzyxz => new hvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns hvec3.rbgrb swizzling (equivalent to hvec3.xzyxz).
        /// </summary>
        public hvec5 rbgrb => new hvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns hvec3.xzyy swizzling.
        /// </summary>
        public hvec4 xzyy => new hvec4(x, z, y, y);
        
        /// <summary>
        /// Returns hvec3.rbgg swizzling (equivalent to hvec3.xzyy).
        /// </summary>
        public hvec4 rbgg => new hvec4(x, z, y, y);
        
        /// <summary>
        /// Returns hvec3.xzyyx swizzling.
        /// </summary>
        public hvec5 xzyyx => new hvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns hvec3.rbggr swizzling (equivalent to hvec3.xzyyx).
        /// </summary>
        public hvec5 rbggr => new hvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns hvec3.xzyyy swizzling.
        /// </summary>
        public hvec5 xzyyy => new hvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns hvec3.rbggg swizzling (equivalent to hvec3.xzyyy).
        /// </summary>
        public hvec5 rbggg => new hvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns hvec3.xzyyz swizzling.
        /// </summary>
        public hvec5 xzyyz => new hvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns hvec3.rbggb swizzling (equivalent to hvec3.xzyyz).
        /// </summary>
        public hvec5 rbggb => new hvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns hvec3.xzyz swizzling.
        /// </summary>
        public hvec4 xzyz => new hvec4(x, z, y, z);
        
        /// <summary>
        /// Returns hvec3.rbgb swizzling (equivalent to hvec3.xzyz).
        /// </summary>
        public hvec4 rbgb => new hvec4(x, z, y, z);
        
        /// <summary>
        /// Returns hvec3.xzyzx swizzling.
        /// </summary>
        public hvec5 xzyzx => new hvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns hvec3.rbgbr swizzling (equivalent to hvec3.xzyzx).
        /// </summary>
        public hvec5 rbgbr => new hvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns hvec3.xzyzy swizzling.
        /// </summary>
        public hvec5 xzyzy => new hvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns hvec3.rbgbg swizzling (equivalent to hvec3.xzyzy).
        /// </summary>
        public hvec5 rbgbg => new hvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns hvec3.xzyzz swizzling.
        /// </summary>
        public hvec5 xzyzz => new hvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns hvec3.rbgbb swizzling (equivalent to hvec3.xzyzz).
        /// </summary>
        public hvec5 rbgbb => new hvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns hvec3.xzz swizzling.
        /// </summary>
        public hvec3 xzz => new hvec3(x, z, z);
        
        /// <summary>
        /// Returns hvec3.rbb swizzling (equivalent to hvec3.xzz).
        /// </summary>
        public hvec3 rbb => new hvec3(x, z, z);
        
        /// <summary>
        /// Returns hvec3.xzzx swizzling.
        /// </summary>
        public hvec4 xzzx => new hvec4(x, z, z, x);
        
        /// <summary>
        /// Returns hvec3.rbbr swizzling (equivalent to hvec3.xzzx).
        /// </summary>
        public hvec4 rbbr => new hvec4(x, z, z, x);
        
        /// <summary>
        /// Returns hvec3.xzzxx swizzling.
        /// </summary>
        public hvec5 xzzxx => new hvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns hvec3.rbbrr swizzling (equivalent to hvec3.xzzxx).
        /// </summary>
        public hvec5 rbbrr => new hvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns hvec3.xzzxy swizzling.
        /// </summary>
        public hvec5 xzzxy => new hvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns hvec3.rbbrg swizzling (equivalent to hvec3.xzzxy).
        /// </summary>
        public hvec5 rbbrg => new hvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns hvec3.xzzxz swizzling.
        /// </summary>
        public hvec5 xzzxz => new hvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns hvec3.rbbrb swizzling (equivalent to hvec3.xzzxz).
        /// </summary>
        public hvec5 rbbrb => new hvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns hvec3.xzzy swizzling.
        /// </summary>
        public hvec4 xzzy => new hvec4(x, z, z, y);
        
        /// <summary>
        /// Returns hvec3.rbbg swizzling (equivalent to hvec3.xzzy).
        /// </summary>
        public hvec4 rbbg => new hvec4(x, z, z, y);
        
        /// <summary>
        /// Returns hvec3.xzzyx swizzling.
        /// </summary>
        public hvec5 xzzyx => new hvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns hvec3.rbbgr swizzling (equivalent to hvec3.xzzyx).
        /// </summary>
        public hvec5 rbbgr => new hvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns hvec3.xzzyy swizzling.
        /// </summary>
        public hvec5 xzzyy => new hvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns hvec3.rbbgg swizzling (equivalent to hvec3.xzzyy).
        /// </summary>
        public hvec5 rbbgg => new hvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns hvec3.xzzyz swizzling.
        /// </summary>
        public hvec5 xzzyz => new hvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns hvec3.rbbgb swizzling (equivalent to hvec3.xzzyz).
        /// </summary>
        public hvec5 rbbgb => new hvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns hvec3.xzzz swizzling.
        /// </summary>
        public hvec4 xzzz => new hvec4(x, z, z, z);
        
        /// <summary>
        /// Returns hvec3.rbbb swizzling (equivalent to hvec3.xzzz).
        /// </summary>
        public hvec4 rbbb => new hvec4(x, z, z, z);
        
        /// <summary>
        /// Returns hvec3.xzzzx swizzling.
        /// </summary>
        public hvec5 xzzzx => new hvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns hvec3.rbbbr swizzling (equivalent to hvec3.xzzzx).
        /// </summary>
        public hvec5 rbbbr => new hvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns hvec3.xzzzy swizzling.
        /// </summary>
        public hvec5 xzzzy => new hvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns hvec3.rbbbg swizzling (equivalent to hvec3.xzzzy).
        /// </summary>
        public hvec5 rbbbg => new hvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns hvec3.xzzzz swizzling.
        /// </summary>
        public hvec5 xzzzz => new hvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns hvec3.rbbbb swizzling (equivalent to hvec3.xzzzz).
        /// </summary>
        public hvec5 rbbbb => new hvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns hvec3.yx swizzling.
        /// </summary>
        public hvec2 yx => new hvec2(y, x);
        
        /// <summary>
        /// Returns hvec3.gr swizzling (equivalent to hvec3.yx).
        /// </summary>
        public hvec2 gr => new hvec2(y, x);
        
        /// <summary>
        /// Returns hvec3.yxx swizzling.
        /// </summary>
        public hvec3 yxx => new hvec3(y, x, x);
        
        /// <summary>
        /// Returns hvec3.grr swizzling (equivalent to hvec3.yxx).
        /// </summary>
        public hvec3 grr => new hvec3(y, x, x);
        
        /// <summary>
        /// Returns hvec3.yxxx swizzling.
        /// </summary>
        public hvec4 yxxx => new hvec4(y, x, x, x);
        
        /// <summary>
        /// Returns hvec3.grrr swizzling (equivalent to hvec3.yxxx).
        /// </summary>
        public hvec4 grrr => new hvec4(y, x, x, x);
        
        /// <summary>
        /// Returns hvec3.yxxxx swizzling.
        /// </summary>
        public hvec5 yxxxx => new hvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns hvec3.grrrr swizzling (equivalent to hvec3.yxxxx).
        /// </summary>
        public hvec5 grrrr => new hvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns hvec3.yxxxy swizzling.
        /// </summary>
        public hvec5 yxxxy => new hvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns hvec3.grrrg swizzling (equivalent to hvec3.yxxxy).
        /// </summary>
        public hvec5 grrrg => new hvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns hvec3.yxxxz swizzling.
        /// </summary>
        public hvec5 yxxxz => new hvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns hvec3.grrrb swizzling (equivalent to hvec3.yxxxz).
        /// </summary>
        public hvec5 grrrb => new hvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns hvec3.yxxy swizzling.
        /// </summary>
        public hvec4 yxxy => new hvec4(y, x, x, y);
        
        /// <summary>
        /// Returns hvec3.grrg swizzling (equivalent to hvec3.yxxy).
        /// </summary>
        public hvec4 grrg => new hvec4(y, x, x, y);
        
        /// <summary>
        /// Returns hvec3.yxxyx swizzling.
        /// </summary>
        public hvec5 yxxyx => new hvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns hvec3.grrgr swizzling (equivalent to hvec3.yxxyx).
        /// </summary>
        public hvec5 grrgr => new hvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns hvec3.yxxyy swizzling.
        /// </summary>
        public hvec5 yxxyy => new hvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns hvec3.grrgg swizzling (equivalent to hvec3.yxxyy).
        /// </summary>
        public hvec5 grrgg => new hvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns hvec3.yxxyz swizzling.
        /// </summary>
        public hvec5 yxxyz => new hvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns hvec3.grrgb swizzling (equivalent to hvec3.yxxyz).
        /// </summary>
        public hvec5 grrgb => new hvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns hvec3.yxxz swizzling.
        /// </summary>
        public hvec4 yxxz => new hvec4(y, x, x, z);
        
        /// <summary>
        /// Returns hvec3.grrb swizzling (equivalent to hvec3.yxxz).
        /// </summary>
        public hvec4 grrb => new hvec4(y, x, x, z);
        
        /// <summary>
        /// Returns hvec3.yxxzx swizzling.
        /// </summary>
        public hvec5 yxxzx => new hvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns hvec3.grrbr swizzling (equivalent to hvec3.yxxzx).
        /// </summary>
        public hvec5 grrbr => new hvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns hvec3.yxxzy swizzling.
        /// </summary>
        public hvec5 yxxzy => new hvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns hvec3.grrbg swizzling (equivalent to hvec3.yxxzy).
        /// </summary>
        public hvec5 grrbg => new hvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns hvec3.yxxzz swizzling.
        /// </summary>
        public hvec5 yxxzz => new hvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns hvec3.grrbb swizzling (equivalent to hvec3.yxxzz).
        /// </summary>
        public hvec5 grrbb => new hvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns hvec3.yxy swizzling.
        /// </summary>
        public hvec3 yxy => new hvec3(y, x, y);
        
        /// <summary>
        /// Returns hvec3.grg swizzling (equivalent to hvec3.yxy).
        /// </summary>
        public hvec3 grg => new hvec3(y, x, y);
        
        /// <summary>
        /// Returns hvec3.yxyx swizzling.
        /// </summary>
        public hvec4 yxyx => new hvec4(y, x, y, x);
        
        /// <summary>
        /// Returns hvec3.grgr swizzling (equivalent to hvec3.yxyx).
        /// </summary>
        public hvec4 grgr => new hvec4(y, x, y, x);
        
        /// <summary>
        /// Returns hvec3.yxyxx swizzling.
        /// </summary>
        public hvec5 yxyxx => new hvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns hvec3.grgrr swizzling (equivalent to hvec3.yxyxx).
        /// </summary>
        public hvec5 grgrr => new hvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns hvec3.yxyxy swizzling.
        /// </summary>
        public hvec5 yxyxy => new hvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns hvec3.grgrg swizzling (equivalent to hvec3.yxyxy).
        /// </summary>
        public hvec5 grgrg => new hvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns hvec3.yxyxz swizzling.
        /// </summary>
        public hvec5 yxyxz => new hvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns hvec3.grgrb swizzling (equivalent to hvec3.yxyxz).
        /// </summary>
        public hvec5 grgrb => new hvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns hvec3.yxyy swizzling.
        /// </summary>
        public hvec4 yxyy => new hvec4(y, x, y, y);
        
        /// <summary>
        /// Returns hvec3.grgg swizzling (equivalent to hvec3.yxyy).
        /// </summary>
        public hvec4 grgg => new hvec4(y, x, y, y);
        
        /// <summary>
        /// Returns hvec3.yxyyx swizzling.
        /// </summary>
        public hvec5 yxyyx => new hvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns hvec3.grggr swizzling (equivalent to hvec3.yxyyx).
        /// </summary>
        public hvec5 grggr => new hvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns hvec3.yxyyy swizzling.
        /// </summary>
        public hvec5 yxyyy => new hvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns hvec3.grggg swizzling (equivalent to hvec3.yxyyy).
        /// </summary>
        public hvec5 grggg => new hvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns hvec3.yxyyz swizzling.
        /// </summary>
        public hvec5 yxyyz => new hvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns hvec3.grggb swizzling (equivalent to hvec3.yxyyz).
        /// </summary>
        public hvec5 grggb => new hvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns hvec3.yxyz swizzling.
        /// </summary>
        public hvec4 yxyz => new hvec4(y, x, y, z);
        
        /// <summary>
        /// Returns hvec3.grgb swizzling (equivalent to hvec3.yxyz).
        /// </summary>
        public hvec4 grgb => new hvec4(y, x, y, z);
        
        /// <summary>
        /// Returns hvec3.yxyzx swizzling.
        /// </summary>
        public hvec5 yxyzx => new hvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns hvec3.grgbr swizzling (equivalent to hvec3.yxyzx).
        /// </summary>
        public hvec5 grgbr => new hvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns hvec3.yxyzy swizzling.
        /// </summary>
        public hvec5 yxyzy => new hvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns hvec3.grgbg swizzling (equivalent to hvec3.yxyzy).
        /// </summary>
        public hvec5 grgbg => new hvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns hvec3.yxyzz swizzling.
        /// </summary>
        public hvec5 yxyzz => new hvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns hvec3.grgbb swizzling (equivalent to hvec3.yxyzz).
        /// </summary>
        public hvec5 grgbb => new hvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns hvec3.yxz swizzling.
        /// </summary>
        public hvec3 yxz => new hvec3(y, x, z);
        
        /// <summary>
        /// Returns hvec3.grb swizzling (equivalent to hvec3.yxz).
        /// </summary>
        public hvec3 grb => new hvec3(y, x, z);
        
        /// <summary>
        /// Returns hvec3.yxzx swizzling.
        /// </summary>
        public hvec4 yxzx => new hvec4(y, x, z, x);
        
        /// <summary>
        /// Returns hvec3.grbr swizzling (equivalent to hvec3.yxzx).
        /// </summary>
        public hvec4 grbr => new hvec4(y, x, z, x);
        
        /// <summary>
        /// Returns hvec3.yxzxx swizzling.
        /// </summary>
        public hvec5 yxzxx => new hvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns hvec3.grbrr swizzling (equivalent to hvec3.yxzxx).
        /// </summary>
        public hvec5 grbrr => new hvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns hvec3.yxzxy swizzling.
        /// </summary>
        public hvec5 yxzxy => new hvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns hvec3.grbrg swizzling (equivalent to hvec3.yxzxy).
        /// </summary>
        public hvec5 grbrg => new hvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns hvec3.yxzxz swizzling.
        /// </summary>
        public hvec5 yxzxz => new hvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns hvec3.grbrb swizzling (equivalent to hvec3.yxzxz).
        /// </summary>
        public hvec5 grbrb => new hvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns hvec3.yxzy swizzling.
        /// </summary>
        public hvec4 yxzy => new hvec4(y, x, z, y);
        
        /// <summary>
        /// Returns hvec3.grbg swizzling (equivalent to hvec3.yxzy).
        /// </summary>
        public hvec4 grbg => new hvec4(y, x, z, y);
        
        /// <summary>
        /// Returns hvec3.yxzyx swizzling.
        /// </summary>
        public hvec5 yxzyx => new hvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns hvec3.grbgr swizzling (equivalent to hvec3.yxzyx).
        /// </summary>
        public hvec5 grbgr => new hvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns hvec3.yxzyy swizzling.
        /// </summary>
        public hvec5 yxzyy => new hvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns hvec3.grbgg swizzling (equivalent to hvec3.yxzyy).
        /// </summary>
        public hvec5 grbgg => new hvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns hvec3.yxzyz swizzling.
        /// </summary>
        public hvec5 yxzyz => new hvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns hvec3.grbgb swizzling (equivalent to hvec3.yxzyz).
        /// </summary>
        public hvec5 grbgb => new hvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns hvec3.yxzz swizzling.
        /// </summary>
        public hvec4 yxzz => new hvec4(y, x, z, z);
        
        /// <summary>
        /// Returns hvec3.grbb swizzling (equivalent to hvec3.yxzz).
        /// </summary>
        public hvec4 grbb => new hvec4(y, x, z, z);
        
        /// <summary>
        /// Returns hvec3.yxzzx swizzling.
        /// </summary>
        public hvec5 yxzzx => new hvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns hvec3.grbbr swizzling (equivalent to hvec3.yxzzx).
        /// </summary>
        public hvec5 grbbr => new hvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns hvec3.yxzzy swizzling.
        /// </summary>
        public hvec5 yxzzy => new hvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns hvec3.grbbg swizzling (equivalent to hvec3.yxzzy).
        /// </summary>
        public hvec5 grbbg => new hvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns hvec3.yxzzz swizzling.
        /// </summary>
        public hvec5 yxzzz => new hvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns hvec3.grbbb swizzling (equivalent to hvec3.yxzzz).
        /// </summary>
        public hvec5 grbbb => new hvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns hvec3.yy swizzling.
        /// </summary>
        public hvec2 yy => new hvec2(y, y);
        
        /// <summary>
        /// Returns hvec3.gg swizzling (equivalent to hvec3.yy).
        /// </summary>
        public hvec2 gg => new hvec2(y, y);
        
        /// <summary>
        /// Returns hvec3.yyx swizzling.
        /// </summary>
        public hvec3 yyx => new hvec3(y, y, x);
        
        /// <summary>
        /// Returns hvec3.ggr swizzling (equivalent to hvec3.yyx).
        /// </summary>
        public hvec3 ggr => new hvec3(y, y, x);
        
        /// <summary>
        /// Returns hvec3.yyxx swizzling.
        /// </summary>
        public hvec4 yyxx => new hvec4(y, y, x, x);
        
        /// <summary>
        /// Returns hvec3.ggrr swizzling (equivalent to hvec3.yyxx).
        /// </summary>
        public hvec4 ggrr => new hvec4(y, y, x, x);
        
        /// <summary>
        /// Returns hvec3.yyxxx swizzling.
        /// </summary>
        public hvec5 yyxxx => new hvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns hvec3.ggrrr swizzling (equivalent to hvec3.yyxxx).
        /// </summary>
        public hvec5 ggrrr => new hvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns hvec3.yyxxy swizzling.
        /// </summary>
        public hvec5 yyxxy => new hvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns hvec3.ggrrg swizzling (equivalent to hvec3.yyxxy).
        /// </summary>
        public hvec5 ggrrg => new hvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns hvec3.yyxxz swizzling.
        /// </summary>
        public hvec5 yyxxz => new hvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns hvec3.ggrrb swizzling (equivalent to hvec3.yyxxz).
        /// </summary>
        public hvec5 ggrrb => new hvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns hvec3.yyxy swizzling.
        /// </summary>
        public hvec4 yyxy => new hvec4(y, y, x, y);
        
        /// <summary>
        /// Returns hvec3.ggrg swizzling (equivalent to hvec3.yyxy).
        /// </summary>
        public hvec4 ggrg => new hvec4(y, y, x, y);
        
        /// <summary>
        /// Returns hvec3.yyxyx swizzling.
        /// </summary>
        public hvec5 yyxyx => new hvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns hvec3.ggrgr swizzling (equivalent to hvec3.yyxyx).
        /// </summary>
        public hvec5 ggrgr => new hvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns hvec3.yyxyy swizzling.
        /// </summary>
        public hvec5 yyxyy => new hvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns hvec3.ggrgg swizzling (equivalent to hvec3.yyxyy).
        /// </summary>
        public hvec5 ggrgg => new hvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns hvec3.yyxyz swizzling.
        /// </summary>
        public hvec5 yyxyz => new hvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns hvec3.ggrgb swizzling (equivalent to hvec3.yyxyz).
        /// </summary>
        public hvec5 ggrgb => new hvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns hvec3.yyxz swizzling.
        /// </summary>
        public hvec4 yyxz => new hvec4(y, y, x, z);
        
        /// <summary>
        /// Returns hvec3.ggrb swizzling (equivalent to hvec3.yyxz).
        /// </summary>
        public hvec4 ggrb => new hvec4(y, y, x, z);
        
        /// <summary>
        /// Returns hvec3.yyxzx swizzling.
        /// </summary>
        public hvec5 yyxzx => new hvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns hvec3.ggrbr swizzling (equivalent to hvec3.yyxzx).
        /// </summary>
        public hvec5 ggrbr => new hvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns hvec3.yyxzy swizzling.
        /// </summary>
        public hvec5 yyxzy => new hvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns hvec3.ggrbg swizzling (equivalent to hvec3.yyxzy).
        /// </summary>
        public hvec5 ggrbg => new hvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns hvec3.yyxzz swizzling.
        /// </summary>
        public hvec5 yyxzz => new hvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns hvec3.ggrbb swizzling (equivalent to hvec3.yyxzz).
        /// </summary>
        public hvec5 ggrbb => new hvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns hvec3.yyy swizzling.
        /// </summary>
        public hvec3 yyy => new hvec3(y, y, y);
        
        /// <summary>
        /// Returns hvec3.ggg swizzling (equivalent to hvec3.yyy).
        /// </summary>
        public hvec3 ggg => new hvec3(y, y, y);
        
        /// <summary>
        /// Returns hvec3.yyyx swizzling.
        /// </summary>
        public hvec4 yyyx => new hvec4(y, y, y, x);
        
        /// <summary>
        /// Returns hvec3.gggr swizzling (equivalent to hvec3.yyyx).
        /// </summary>
        public hvec4 gggr => new hvec4(y, y, y, x);
        
        /// <summary>
        /// Returns hvec3.yyyxx swizzling.
        /// </summary>
        public hvec5 yyyxx => new hvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns hvec3.gggrr swizzling (equivalent to hvec3.yyyxx).
        /// </summary>
        public hvec5 gggrr => new hvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns hvec3.yyyxy swizzling.
        /// </summary>
        public hvec5 yyyxy => new hvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns hvec3.gggrg swizzling (equivalent to hvec3.yyyxy).
        /// </summary>
        public hvec5 gggrg => new hvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns hvec3.yyyxz swizzling.
        /// </summary>
        public hvec5 yyyxz => new hvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns hvec3.gggrb swizzling (equivalent to hvec3.yyyxz).
        /// </summary>
        public hvec5 gggrb => new hvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns hvec3.yyyy swizzling.
        /// </summary>
        public hvec4 yyyy => new hvec4(y, y, y, y);
        
        /// <summary>
        /// Returns hvec3.gggg swizzling (equivalent to hvec3.yyyy).
        /// </summary>
        public hvec4 gggg => new hvec4(y, y, y, y);
        
        /// <summary>
        /// Returns hvec3.yyyyx swizzling.
        /// </summary>
        public hvec5 yyyyx => new hvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns hvec3.ggggr swizzling (equivalent to hvec3.yyyyx).
        /// </summary>
        public hvec5 ggggr => new hvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns hvec3.yyyyy swizzling.
        /// </summary>
        public hvec5 yyyyy => new hvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns hvec3.ggggg swizzling (equivalent to hvec3.yyyyy).
        /// </summary>
        public hvec5 ggggg => new hvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns hvec3.yyyyz swizzling.
        /// </summary>
        public hvec5 yyyyz => new hvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns hvec3.ggggb swizzling (equivalent to hvec3.yyyyz).
        /// </summary>
        public hvec5 ggggb => new hvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns hvec3.yyyz swizzling.
        /// </summary>
        public hvec4 yyyz => new hvec4(y, y, y, z);
        
        /// <summary>
        /// Returns hvec3.gggb swizzling (equivalent to hvec3.yyyz).
        /// </summary>
        public hvec4 gggb => new hvec4(y, y, y, z);
        
        /// <summary>
        /// Returns hvec3.yyyzx swizzling.
        /// </summary>
        public hvec5 yyyzx => new hvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns hvec3.gggbr swizzling (equivalent to hvec3.yyyzx).
        /// </summary>
        public hvec5 gggbr => new hvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns hvec3.yyyzy swizzling.
        /// </summary>
        public hvec5 yyyzy => new hvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns hvec3.gggbg swizzling (equivalent to hvec3.yyyzy).
        /// </summary>
        public hvec5 gggbg => new hvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns hvec3.yyyzz swizzling.
        /// </summary>
        public hvec5 yyyzz => new hvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns hvec3.gggbb swizzling (equivalent to hvec3.yyyzz).
        /// </summary>
        public hvec5 gggbb => new hvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns hvec3.yyz swizzling.
        /// </summary>
        public hvec3 yyz => new hvec3(y, y, z);
        
        /// <summary>
        /// Returns hvec3.ggb swizzling (equivalent to hvec3.yyz).
        /// </summary>
        public hvec3 ggb => new hvec3(y, y, z);
        
        /// <summary>
        /// Returns hvec3.yyzx swizzling.
        /// </summary>
        public hvec4 yyzx => new hvec4(y, y, z, x);
        
        /// <summary>
        /// Returns hvec3.ggbr swizzling (equivalent to hvec3.yyzx).
        /// </summary>
        public hvec4 ggbr => new hvec4(y, y, z, x);
        
        /// <summary>
        /// Returns hvec3.yyzxx swizzling.
        /// </summary>
        public hvec5 yyzxx => new hvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns hvec3.ggbrr swizzling (equivalent to hvec3.yyzxx).
        /// </summary>
        public hvec5 ggbrr => new hvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns hvec3.yyzxy swizzling.
        /// </summary>
        public hvec5 yyzxy => new hvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns hvec3.ggbrg swizzling (equivalent to hvec3.yyzxy).
        /// </summary>
        public hvec5 ggbrg => new hvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns hvec3.yyzxz swizzling.
        /// </summary>
        public hvec5 yyzxz => new hvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns hvec3.ggbrb swizzling (equivalent to hvec3.yyzxz).
        /// </summary>
        public hvec5 ggbrb => new hvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns hvec3.yyzy swizzling.
        /// </summary>
        public hvec4 yyzy => new hvec4(y, y, z, y);
        
        /// <summary>
        /// Returns hvec3.ggbg swizzling (equivalent to hvec3.yyzy).
        /// </summary>
        public hvec4 ggbg => new hvec4(y, y, z, y);
        
        /// <summary>
        /// Returns hvec3.yyzyx swizzling.
        /// </summary>
        public hvec5 yyzyx => new hvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns hvec3.ggbgr swizzling (equivalent to hvec3.yyzyx).
        /// </summary>
        public hvec5 ggbgr => new hvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns hvec3.yyzyy swizzling.
        /// </summary>
        public hvec5 yyzyy => new hvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns hvec3.ggbgg swizzling (equivalent to hvec3.yyzyy).
        /// </summary>
        public hvec5 ggbgg => new hvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns hvec3.yyzyz swizzling.
        /// </summary>
        public hvec5 yyzyz => new hvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns hvec3.ggbgb swizzling (equivalent to hvec3.yyzyz).
        /// </summary>
        public hvec5 ggbgb => new hvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns hvec3.yyzz swizzling.
        /// </summary>
        public hvec4 yyzz => new hvec4(y, y, z, z);
        
        /// <summary>
        /// Returns hvec3.ggbb swizzling (equivalent to hvec3.yyzz).
        /// </summary>
        public hvec4 ggbb => new hvec4(y, y, z, z);
        
        /// <summary>
        /// Returns hvec3.yyzzx swizzling.
        /// </summary>
        public hvec5 yyzzx => new hvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns hvec3.ggbbr swizzling (equivalent to hvec3.yyzzx).
        /// </summary>
        public hvec5 ggbbr => new hvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns hvec3.yyzzy swizzling.
        /// </summary>
        public hvec5 yyzzy => new hvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns hvec3.ggbbg swizzling (equivalent to hvec3.yyzzy).
        /// </summary>
        public hvec5 ggbbg => new hvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns hvec3.yyzzz swizzling.
        /// </summary>
        public hvec5 yyzzz => new hvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns hvec3.ggbbb swizzling (equivalent to hvec3.yyzzz).
        /// </summary>
        public hvec5 ggbbb => new hvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns hvec3.yz swizzling.
        /// </summary>
        public hvec2 yz => new hvec2(y, z);
        
        /// <summary>
        /// Returns hvec3.gb swizzling (equivalent to hvec3.yz).
        /// </summary>
        public hvec2 gb => new hvec2(y, z);
        
        /// <summary>
        /// Returns hvec3.yzx swizzling.
        /// </summary>
        public hvec3 yzx => new hvec3(y, z, x);
        
        /// <summary>
        /// Returns hvec3.gbr swizzling (equivalent to hvec3.yzx).
        /// </summary>
        public hvec3 gbr => new hvec3(y, z, x);
        
        /// <summary>
        /// Returns hvec3.yzxx swizzling.
        /// </summary>
        public hvec4 yzxx => new hvec4(y, z, x, x);
        
        /// <summary>
        /// Returns hvec3.gbrr swizzling (equivalent to hvec3.yzxx).
        /// </summary>
        public hvec4 gbrr => new hvec4(y, z, x, x);
        
        /// <summary>
        /// Returns hvec3.yzxxx swizzling.
        /// </summary>
        public hvec5 yzxxx => new hvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns hvec3.gbrrr swizzling (equivalent to hvec3.yzxxx).
        /// </summary>
        public hvec5 gbrrr => new hvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns hvec3.yzxxy swizzling.
        /// </summary>
        public hvec5 yzxxy => new hvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns hvec3.gbrrg swizzling (equivalent to hvec3.yzxxy).
        /// </summary>
        public hvec5 gbrrg => new hvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns hvec3.yzxxz swizzling.
        /// </summary>
        public hvec5 yzxxz => new hvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns hvec3.gbrrb swizzling (equivalent to hvec3.yzxxz).
        /// </summary>
        public hvec5 gbrrb => new hvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns hvec3.yzxy swizzling.
        /// </summary>
        public hvec4 yzxy => new hvec4(y, z, x, y);
        
        /// <summary>
        /// Returns hvec3.gbrg swizzling (equivalent to hvec3.yzxy).
        /// </summary>
        public hvec4 gbrg => new hvec4(y, z, x, y);
        
        /// <summary>
        /// Returns hvec3.yzxyx swizzling.
        /// </summary>
        public hvec5 yzxyx => new hvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns hvec3.gbrgr swizzling (equivalent to hvec3.yzxyx).
        /// </summary>
        public hvec5 gbrgr => new hvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns hvec3.yzxyy swizzling.
        /// </summary>
        public hvec5 yzxyy => new hvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns hvec3.gbrgg swizzling (equivalent to hvec3.yzxyy).
        /// </summary>
        public hvec5 gbrgg => new hvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns hvec3.yzxyz swizzling.
        /// </summary>
        public hvec5 yzxyz => new hvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns hvec3.gbrgb swizzling (equivalent to hvec3.yzxyz).
        /// </summary>
        public hvec5 gbrgb => new hvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns hvec3.yzxz swizzling.
        /// </summary>
        public hvec4 yzxz => new hvec4(y, z, x, z);
        
        /// <summary>
        /// Returns hvec3.gbrb swizzling (equivalent to hvec3.yzxz).
        /// </summary>
        public hvec4 gbrb => new hvec4(y, z, x, z);
        
        /// <summary>
        /// Returns hvec3.yzxzx swizzling.
        /// </summary>
        public hvec5 yzxzx => new hvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns hvec3.gbrbr swizzling (equivalent to hvec3.yzxzx).
        /// </summary>
        public hvec5 gbrbr => new hvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns hvec3.yzxzy swizzling.
        /// </summary>
        public hvec5 yzxzy => new hvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns hvec3.gbrbg swizzling (equivalent to hvec3.yzxzy).
        /// </summary>
        public hvec5 gbrbg => new hvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns hvec3.yzxzz swizzling.
        /// </summary>
        public hvec5 yzxzz => new hvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns hvec3.gbrbb swizzling (equivalent to hvec3.yzxzz).
        /// </summary>
        public hvec5 gbrbb => new hvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns hvec3.yzy swizzling.
        /// </summary>
        public hvec3 yzy => new hvec3(y, z, y);
        
        /// <summary>
        /// Returns hvec3.gbg swizzling (equivalent to hvec3.yzy).
        /// </summary>
        public hvec3 gbg => new hvec3(y, z, y);
        
        /// <summary>
        /// Returns hvec3.yzyx swizzling.
        /// </summary>
        public hvec4 yzyx => new hvec4(y, z, y, x);
        
        /// <summary>
        /// Returns hvec3.gbgr swizzling (equivalent to hvec3.yzyx).
        /// </summary>
        public hvec4 gbgr => new hvec4(y, z, y, x);
        
        /// <summary>
        /// Returns hvec3.yzyxx swizzling.
        /// </summary>
        public hvec5 yzyxx => new hvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns hvec3.gbgrr swizzling (equivalent to hvec3.yzyxx).
        /// </summary>
        public hvec5 gbgrr => new hvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns hvec3.yzyxy swizzling.
        /// </summary>
        public hvec5 yzyxy => new hvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns hvec3.gbgrg swizzling (equivalent to hvec3.yzyxy).
        /// </summary>
        public hvec5 gbgrg => new hvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns hvec3.yzyxz swizzling.
        /// </summary>
        public hvec5 yzyxz => new hvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns hvec3.gbgrb swizzling (equivalent to hvec3.yzyxz).
        /// </summary>
        public hvec5 gbgrb => new hvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns hvec3.yzyy swizzling.
        /// </summary>
        public hvec4 yzyy => new hvec4(y, z, y, y);
        
        /// <summary>
        /// Returns hvec3.gbgg swizzling (equivalent to hvec3.yzyy).
        /// </summary>
        public hvec4 gbgg => new hvec4(y, z, y, y);
        
        /// <summary>
        /// Returns hvec3.yzyyx swizzling.
        /// </summary>
        public hvec5 yzyyx => new hvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns hvec3.gbggr swizzling (equivalent to hvec3.yzyyx).
        /// </summary>
        public hvec5 gbggr => new hvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns hvec3.yzyyy swizzling.
        /// </summary>
        public hvec5 yzyyy => new hvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns hvec3.gbggg swizzling (equivalent to hvec3.yzyyy).
        /// </summary>
        public hvec5 gbggg => new hvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns hvec3.yzyyz swizzling.
        /// </summary>
        public hvec5 yzyyz => new hvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns hvec3.gbggb swizzling (equivalent to hvec3.yzyyz).
        /// </summary>
        public hvec5 gbggb => new hvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns hvec3.yzyz swizzling.
        /// </summary>
        public hvec4 yzyz => new hvec4(y, z, y, z);
        
        /// <summary>
        /// Returns hvec3.gbgb swizzling (equivalent to hvec3.yzyz).
        /// </summary>
        public hvec4 gbgb => new hvec4(y, z, y, z);
        
        /// <summary>
        /// Returns hvec3.yzyzx swizzling.
        /// </summary>
        public hvec5 yzyzx => new hvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns hvec3.gbgbr swizzling (equivalent to hvec3.yzyzx).
        /// </summary>
        public hvec5 gbgbr => new hvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns hvec3.yzyzy swizzling.
        /// </summary>
        public hvec5 yzyzy => new hvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns hvec3.gbgbg swizzling (equivalent to hvec3.yzyzy).
        /// </summary>
        public hvec5 gbgbg => new hvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns hvec3.yzyzz swizzling.
        /// </summary>
        public hvec5 yzyzz => new hvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns hvec3.gbgbb swizzling (equivalent to hvec3.yzyzz).
        /// </summary>
        public hvec5 gbgbb => new hvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns hvec3.yzz swizzling.
        /// </summary>
        public hvec3 yzz => new hvec3(y, z, z);
        
        /// <summary>
        /// Returns hvec3.gbb swizzling (equivalent to hvec3.yzz).
        /// </summary>
        public hvec3 gbb => new hvec3(y, z, z);
        
        /// <summary>
        /// Returns hvec3.yzzx swizzling.
        /// </summary>
        public hvec4 yzzx => new hvec4(y, z, z, x);
        
        /// <summary>
        /// Returns hvec3.gbbr swizzling (equivalent to hvec3.yzzx).
        /// </summary>
        public hvec4 gbbr => new hvec4(y, z, z, x);
        
        /// <summary>
        /// Returns hvec3.yzzxx swizzling.
        /// </summary>
        public hvec5 yzzxx => new hvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns hvec3.gbbrr swizzling (equivalent to hvec3.yzzxx).
        /// </summary>
        public hvec5 gbbrr => new hvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns hvec3.yzzxy swizzling.
        /// </summary>
        public hvec5 yzzxy => new hvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns hvec3.gbbrg swizzling (equivalent to hvec3.yzzxy).
        /// </summary>
        public hvec5 gbbrg => new hvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns hvec3.yzzxz swizzling.
        /// </summary>
        public hvec5 yzzxz => new hvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns hvec3.gbbrb swizzling (equivalent to hvec3.yzzxz).
        /// </summary>
        public hvec5 gbbrb => new hvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns hvec3.yzzy swizzling.
        /// </summary>
        public hvec4 yzzy => new hvec4(y, z, z, y);
        
        /// <summary>
        /// Returns hvec3.gbbg swizzling (equivalent to hvec3.yzzy).
        /// </summary>
        public hvec4 gbbg => new hvec4(y, z, z, y);
        
        /// <summary>
        /// Returns hvec3.yzzyx swizzling.
        /// </summary>
        public hvec5 yzzyx => new hvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns hvec3.gbbgr swizzling (equivalent to hvec3.yzzyx).
        /// </summary>
        public hvec5 gbbgr => new hvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns hvec3.yzzyy swizzling.
        /// </summary>
        public hvec5 yzzyy => new hvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns hvec3.gbbgg swizzling (equivalent to hvec3.yzzyy).
        /// </summary>
        public hvec5 gbbgg => new hvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns hvec3.yzzyz swizzling.
        /// </summary>
        public hvec5 yzzyz => new hvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns hvec3.gbbgb swizzling (equivalent to hvec3.yzzyz).
        /// </summary>
        public hvec5 gbbgb => new hvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns hvec3.yzzz swizzling.
        /// </summary>
        public hvec4 yzzz => new hvec4(y, z, z, z);
        
        /// <summary>
        /// Returns hvec3.gbbb swizzling (equivalent to hvec3.yzzz).
        /// </summary>
        public hvec4 gbbb => new hvec4(y, z, z, z);
        
        /// <summary>
        /// Returns hvec3.yzzzx swizzling.
        /// </summary>
        public hvec5 yzzzx => new hvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns hvec3.gbbbr swizzling (equivalent to hvec3.yzzzx).
        /// </summary>
        public hvec5 gbbbr => new hvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns hvec3.yzzzy swizzling.
        /// </summary>
        public hvec5 yzzzy => new hvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns hvec3.gbbbg swizzling (equivalent to hvec3.yzzzy).
        /// </summary>
        public hvec5 gbbbg => new hvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns hvec3.yzzzz swizzling.
        /// </summary>
        public hvec5 yzzzz => new hvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns hvec3.gbbbb swizzling (equivalent to hvec3.yzzzz).
        /// </summary>
        public hvec5 gbbbb => new hvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns hvec3.zx swizzling.
        /// </summary>
        public hvec2 zx => new hvec2(z, x);
        
        /// <summary>
        /// Returns hvec3.br swizzling (equivalent to hvec3.zx).
        /// </summary>
        public hvec2 br => new hvec2(z, x);
        
        /// <summary>
        /// Returns hvec3.zxx swizzling.
        /// </summary>
        public hvec3 zxx => new hvec3(z, x, x);
        
        /// <summary>
        /// Returns hvec3.brr swizzling (equivalent to hvec3.zxx).
        /// </summary>
        public hvec3 brr => new hvec3(z, x, x);
        
        /// <summary>
        /// Returns hvec3.zxxx swizzling.
        /// </summary>
        public hvec4 zxxx => new hvec4(z, x, x, x);
        
        /// <summary>
        /// Returns hvec3.brrr swizzling (equivalent to hvec3.zxxx).
        /// </summary>
        public hvec4 brrr => new hvec4(z, x, x, x);
        
        /// <summary>
        /// Returns hvec3.zxxxx swizzling.
        /// </summary>
        public hvec5 zxxxx => new hvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns hvec3.brrrr swizzling (equivalent to hvec3.zxxxx).
        /// </summary>
        public hvec5 brrrr => new hvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns hvec3.zxxxy swizzling.
        /// </summary>
        public hvec5 zxxxy => new hvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns hvec3.brrrg swizzling (equivalent to hvec3.zxxxy).
        /// </summary>
        public hvec5 brrrg => new hvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns hvec3.zxxxz swizzling.
        /// </summary>
        public hvec5 zxxxz => new hvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns hvec3.brrrb swizzling (equivalent to hvec3.zxxxz).
        /// </summary>
        public hvec5 brrrb => new hvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns hvec3.zxxy swizzling.
        /// </summary>
        public hvec4 zxxy => new hvec4(z, x, x, y);
        
        /// <summary>
        /// Returns hvec3.brrg swizzling (equivalent to hvec3.zxxy).
        /// </summary>
        public hvec4 brrg => new hvec4(z, x, x, y);
        
        /// <summary>
        /// Returns hvec3.zxxyx swizzling.
        /// </summary>
        public hvec5 zxxyx => new hvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns hvec3.brrgr swizzling (equivalent to hvec3.zxxyx).
        /// </summary>
        public hvec5 brrgr => new hvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns hvec3.zxxyy swizzling.
        /// </summary>
        public hvec5 zxxyy => new hvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns hvec3.brrgg swizzling (equivalent to hvec3.zxxyy).
        /// </summary>
        public hvec5 brrgg => new hvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns hvec3.zxxyz swizzling.
        /// </summary>
        public hvec5 zxxyz => new hvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns hvec3.brrgb swizzling (equivalent to hvec3.zxxyz).
        /// </summary>
        public hvec5 brrgb => new hvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns hvec3.zxxz swizzling.
        /// </summary>
        public hvec4 zxxz => new hvec4(z, x, x, z);
        
        /// <summary>
        /// Returns hvec3.brrb swizzling (equivalent to hvec3.zxxz).
        /// </summary>
        public hvec4 brrb => new hvec4(z, x, x, z);
        
        /// <summary>
        /// Returns hvec3.zxxzx swizzling.
        /// </summary>
        public hvec5 zxxzx => new hvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns hvec3.brrbr swizzling (equivalent to hvec3.zxxzx).
        /// </summary>
        public hvec5 brrbr => new hvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns hvec3.zxxzy swizzling.
        /// </summary>
        public hvec5 zxxzy => new hvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns hvec3.brrbg swizzling (equivalent to hvec3.zxxzy).
        /// </summary>
        public hvec5 brrbg => new hvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns hvec3.zxxzz swizzling.
        /// </summary>
        public hvec5 zxxzz => new hvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns hvec3.brrbb swizzling (equivalent to hvec3.zxxzz).
        /// </summary>
        public hvec5 brrbb => new hvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns hvec3.zxy swizzling.
        /// </summary>
        public hvec3 zxy => new hvec3(z, x, y);
        
        /// <summary>
        /// Returns hvec3.brg swizzling (equivalent to hvec3.zxy).
        /// </summary>
        public hvec3 brg => new hvec3(z, x, y);
        
        /// <summary>
        /// Returns hvec3.zxyx swizzling.
        /// </summary>
        public hvec4 zxyx => new hvec4(z, x, y, x);
        
        /// <summary>
        /// Returns hvec3.brgr swizzling (equivalent to hvec3.zxyx).
        /// </summary>
        public hvec4 brgr => new hvec4(z, x, y, x);
        
        /// <summary>
        /// Returns hvec3.zxyxx swizzling.
        /// </summary>
        public hvec5 zxyxx => new hvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns hvec3.brgrr swizzling (equivalent to hvec3.zxyxx).
        /// </summary>
        public hvec5 brgrr => new hvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns hvec3.zxyxy swizzling.
        /// </summary>
        public hvec5 zxyxy => new hvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns hvec3.brgrg swizzling (equivalent to hvec3.zxyxy).
        /// </summary>
        public hvec5 brgrg => new hvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns hvec3.zxyxz swizzling.
        /// </summary>
        public hvec5 zxyxz => new hvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns hvec3.brgrb swizzling (equivalent to hvec3.zxyxz).
        /// </summary>
        public hvec5 brgrb => new hvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns hvec3.zxyy swizzling.
        /// </summary>
        public hvec4 zxyy => new hvec4(z, x, y, y);
        
        /// <summary>
        /// Returns hvec3.brgg swizzling (equivalent to hvec3.zxyy).
        /// </summary>
        public hvec4 brgg => new hvec4(z, x, y, y);
        
        /// <summary>
        /// Returns hvec3.zxyyx swizzling.
        /// </summary>
        public hvec5 zxyyx => new hvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns hvec3.brggr swizzling (equivalent to hvec3.zxyyx).
        /// </summary>
        public hvec5 brggr => new hvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns hvec3.zxyyy swizzling.
        /// </summary>
        public hvec5 zxyyy => new hvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns hvec3.brggg swizzling (equivalent to hvec3.zxyyy).
        /// </summary>
        public hvec5 brggg => new hvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns hvec3.zxyyz swizzling.
        /// </summary>
        public hvec5 zxyyz => new hvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns hvec3.brggb swizzling (equivalent to hvec3.zxyyz).
        /// </summary>
        public hvec5 brggb => new hvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns hvec3.zxyz swizzling.
        /// </summary>
        public hvec4 zxyz => new hvec4(z, x, y, z);
        
        /// <summary>
        /// Returns hvec3.brgb swizzling (equivalent to hvec3.zxyz).
        /// </summary>
        public hvec4 brgb => new hvec4(z, x, y, z);
        
        /// <summary>
        /// Returns hvec3.zxyzx swizzling.
        /// </summary>
        public hvec5 zxyzx => new hvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns hvec3.brgbr swizzling (equivalent to hvec3.zxyzx).
        /// </summary>
        public hvec5 brgbr => new hvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns hvec3.zxyzy swizzling.
        /// </summary>
        public hvec5 zxyzy => new hvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns hvec3.brgbg swizzling (equivalent to hvec3.zxyzy).
        /// </summary>
        public hvec5 brgbg => new hvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns hvec3.zxyzz swizzling.
        /// </summary>
        public hvec5 zxyzz => new hvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns hvec3.brgbb swizzling (equivalent to hvec3.zxyzz).
        /// </summary>
        public hvec5 brgbb => new hvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns hvec3.zxz swizzling.
        /// </summary>
        public hvec3 zxz => new hvec3(z, x, z);
        
        /// <summary>
        /// Returns hvec3.brb swizzling (equivalent to hvec3.zxz).
        /// </summary>
        public hvec3 brb => new hvec3(z, x, z);
        
        /// <summary>
        /// Returns hvec3.zxzx swizzling.
        /// </summary>
        public hvec4 zxzx => new hvec4(z, x, z, x);
        
        /// <summary>
        /// Returns hvec3.brbr swizzling (equivalent to hvec3.zxzx).
        /// </summary>
        public hvec4 brbr => new hvec4(z, x, z, x);
        
        /// <summary>
        /// Returns hvec3.zxzxx swizzling.
        /// </summary>
        public hvec5 zxzxx => new hvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns hvec3.brbrr swizzling (equivalent to hvec3.zxzxx).
        /// </summary>
        public hvec5 brbrr => new hvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns hvec3.zxzxy swizzling.
        /// </summary>
        public hvec5 zxzxy => new hvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns hvec3.brbrg swizzling (equivalent to hvec3.zxzxy).
        /// </summary>
        public hvec5 brbrg => new hvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns hvec3.zxzxz swizzling.
        /// </summary>
        public hvec5 zxzxz => new hvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns hvec3.brbrb swizzling (equivalent to hvec3.zxzxz).
        /// </summary>
        public hvec5 brbrb => new hvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns hvec3.zxzy swizzling.
        /// </summary>
        public hvec4 zxzy => new hvec4(z, x, z, y);
        
        /// <summary>
        /// Returns hvec3.brbg swizzling (equivalent to hvec3.zxzy).
        /// </summary>
        public hvec4 brbg => new hvec4(z, x, z, y);
        
        /// <summary>
        /// Returns hvec3.zxzyx swizzling.
        /// </summary>
        public hvec5 zxzyx => new hvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns hvec3.brbgr swizzling (equivalent to hvec3.zxzyx).
        /// </summary>
        public hvec5 brbgr => new hvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns hvec3.zxzyy swizzling.
        /// </summary>
        public hvec5 zxzyy => new hvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns hvec3.brbgg swizzling (equivalent to hvec3.zxzyy).
        /// </summary>
        public hvec5 brbgg => new hvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns hvec3.zxzyz swizzling.
        /// </summary>
        public hvec5 zxzyz => new hvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns hvec3.brbgb swizzling (equivalent to hvec3.zxzyz).
        /// </summary>
        public hvec5 brbgb => new hvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns hvec3.zxzz swizzling.
        /// </summary>
        public hvec4 zxzz => new hvec4(z, x, z, z);
        
        /// <summary>
        /// Returns hvec3.brbb swizzling (equivalent to hvec3.zxzz).
        /// </summary>
        public hvec4 brbb => new hvec4(z, x, z, z);
        
        /// <summary>
        /// Returns hvec3.zxzzx swizzling.
        /// </summary>
        public hvec5 zxzzx => new hvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns hvec3.brbbr swizzling (equivalent to hvec3.zxzzx).
        /// </summary>
        public hvec5 brbbr => new hvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns hvec3.zxzzy swizzling.
        /// </summary>
        public hvec5 zxzzy => new hvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns hvec3.brbbg swizzling (equivalent to hvec3.zxzzy).
        /// </summary>
        public hvec5 brbbg => new hvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns hvec3.zxzzz swizzling.
        /// </summary>
        public hvec5 zxzzz => new hvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns hvec3.brbbb swizzling (equivalent to hvec3.zxzzz).
        /// </summary>
        public hvec5 brbbb => new hvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns hvec3.zy swizzling.
        /// </summary>
        public hvec2 zy => new hvec2(z, y);
        
        /// <summary>
        /// Returns hvec3.bg swizzling (equivalent to hvec3.zy).
        /// </summary>
        public hvec2 bg => new hvec2(z, y);
        
        /// <summary>
        /// Returns hvec3.zyx swizzling.
        /// </summary>
        public hvec3 zyx => new hvec3(z, y, x);
        
        /// <summary>
        /// Returns hvec3.bgr swizzling (equivalent to hvec3.zyx).
        /// </summary>
        public hvec3 bgr => new hvec3(z, y, x);
        
        /// <summary>
        /// Returns hvec3.zyxx swizzling.
        /// </summary>
        public hvec4 zyxx => new hvec4(z, y, x, x);
        
        /// <summary>
        /// Returns hvec3.bgrr swizzling (equivalent to hvec3.zyxx).
        /// </summary>
        public hvec4 bgrr => new hvec4(z, y, x, x);
        
        /// <summary>
        /// Returns hvec3.zyxxx swizzling.
        /// </summary>
        public hvec5 zyxxx => new hvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns hvec3.bgrrr swizzling (equivalent to hvec3.zyxxx).
        /// </summary>
        public hvec5 bgrrr => new hvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns hvec3.zyxxy swizzling.
        /// </summary>
        public hvec5 zyxxy => new hvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns hvec3.bgrrg swizzling (equivalent to hvec3.zyxxy).
        /// </summary>
        public hvec5 bgrrg => new hvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns hvec3.zyxxz swizzling.
        /// </summary>
        public hvec5 zyxxz => new hvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns hvec3.bgrrb swizzling (equivalent to hvec3.zyxxz).
        /// </summary>
        public hvec5 bgrrb => new hvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns hvec3.zyxy swizzling.
        /// </summary>
        public hvec4 zyxy => new hvec4(z, y, x, y);
        
        /// <summary>
        /// Returns hvec3.bgrg swizzling (equivalent to hvec3.zyxy).
        /// </summary>
        public hvec4 bgrg => new hvec4(z, y, x, y);
        
        /// <summary>
        /// Returns hvec3.zyxyx swizzling.
        /// </summary>
        public hvec5 zyxyx => new hvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns hvec3.bgrgr swizzling (equivalent to hvec3.zyxyx).
        /// </summary>
        public hvec5 bgrgr => new hvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns hvec3.zyxyy swizzling.
        /// </summary>
        public hvec5 zyxyy => new hvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns hvec3.bgrgg swizzling (equivalent to hvec3.zyxyy).
        /// </summary>
        public hvec5 bgrgg => new hvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns hvec3.zyxyz swizzling.
        /// </summary>
        public hvec5 zyxyz => new hvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns hvec3.bgrgb swizzling (equivalent to hvec3.zyxyz).
        /// </summary>
        public hvec5 bgrgb => new hvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns hvec3.zyxz swizzling.
        /// </summary>
        public hvec4 zyxz => new hvec4(z, y, x, z);
        
        /// <summary>
        /// Returns hvec3.bgrb swizzling (equivalent to hvec3.zyxz).
        /// </summary>
        public hvec4 bgrb => new hvec4(z, y, x, z);
        
        /// <summary>
        /// Returns hvec3.zyxzx swizzling.
        /// </summary>
        public hvec5 zyxzx => new hvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns hvec3.bgrbr swizzling (equivalent to hvec3.zyxzx).
        /// </summary>
        public hvec5 bgrbr => new hvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns hvec3.zyxzy swizzling.
        /// </summary>
        public hvec5 zyxzy => new hvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns hvec3.bgrbg swizzling (equivalent to hvec3.zyxzy).
        /// </summary>
        public hvec5 bgrbg => new hvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns hvec3.zyxzz swizzling.
        /// </summary>
        public hvec5 zyxzz => new hvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns hvec3.bgrbb swizzling (equivalent to hvec3.zyxzz).
        /// </summary>
        public hvec5 bgrbb => new hvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns hvec3.zyy swizzling.
        /// </summary>
        public hvec3 zyy => new hvec3(z, y, y);
        
        /// <summary>
        /// Returns hvec3.bgg swizzling (equivalent to hvec3.zyy).
        /// </summary>
        public hvec3 bgg => new hvec3(z, y, y);
        
        /// <summary>
        /// Returns hvec3.zyyx swizzling.
        /// </summary>
        public hvec4 zyyx => new hvec4(z, y, y, x);
        
        /// <summary>
        /// Returns hvec3.bggr swizzling (equivalent to hvec3.zyyx).
        /// </summary>
        public hvec4 bggr => new hvec4(z, y, y, x);
        
        /// <summary>
        /// Returns hvec3.zyyxx swizzling.
        /// </summary>
        public hvec5 zyyxx => new hvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns hvec3.bggrr swizzling (equivalent to hvec3.zyyxx).
        /// </summary>
        public hvec5 bggrr => new hvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns hvec3.zyyxy swizzling.
        /// </summary>
        public hvec5 zyyxy => new hvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns hvec3.bggrg swizzling (equivalent to hvec3.zyyxy).
        /// </summary>
        public hvec5 bggrg => new hvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns hvec3.zyyxz swizzling.
        /// </summary>
        public hvec5 zyyxz => new hvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns hvec3.bggrb swizzling (equivalent to hvec3.zyyxz).
        /// </summary>
        public hvec5 bggrb => new hvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns hvec3.zyyy swizzling.
        /// </summary>
        public hvec4 zyyy => new hvec4(z, y, y, y);
        
        /// <summary>
        /// Returns hvec3.bggg swizzling (equivalent to hvec3.zyyy).
        /// </summary>
        public hvec4 bggg => new hvec4(z, y, y, y);
        
        /// <summary>
        /// Returns hvec3.zyyyx swizzling.
        /// </summary>
        public hvec5 zyyyx => new hvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns hvec3.bgggr swizzling (equivalent to hvec3.zyyyx).
        /// </summary>
        public hvec5 bgggr => new hvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns hvec3.zyyyy swizzling.
        /// </summary>
        public hvec5 zyyyy => new hvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns hvec3.bgggg swizzling (equivalent to hvec3.zyyyy).
        /// </summary>
        public hvec5 bgggg => new hvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns hvec3.zyyyz swizzling.
        /// </summary>
        public hvec5 zyyyz => new hvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns hvec3.bgggb swizzling (equivalent to hvec3.zyyyz).
        /// </summary>
        public hvec5 bgggb => new hvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns hvec3.zyyz swizzling.
        /// </summary>
        public hvec4 zyyz => new hvec4(z, y, y, z);
        
        /// <summary>
        /// Returns hvec3.bggb swizzling (equivalent to hvec3.zyyz).
        /// </summary>
        public hvec4 bggb => new hvec4(z, y, y, z);
        
        /// <summary>
        /// Returns hvec3.zyyzx swizzling.
        /// </summary>
        public hvec5 zyyzx => new hvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns hvec3.bggbr swizzling (equivalent to hvec3.zyyzx).
        /// </summary>
        public hvec5 bggbr => new hvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns hvec3.zyyzy swizzling.
        /// </summary>
        public hvec5 zyyzy => new hvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns hvec3.bggbg swizzling (equivalent to hvec3.zyyzy).
        /// </summary>
        public hvec5 bggbg => new hvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns hvec3.zyyzz swizzling.
        /// </summary>
        public hvec5 zyyzz => new hvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns hvec3.bggbb swizzling (equivalent to hvec3.zyyzz).
        /// </summary>
        public hvec5 bggbb => new hvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns hvec3.zyz swizzling.
        /// </summary>
        public hvec3 zyz => new hvec3(z, y, z);
        
        /// <summary>
        /// Returns hvec3.bgb swizzling (equivalent to hvec3.zyz).
        /// </summary>
        public hvec3 bgb => new hvec3(z, y, z);
        
        /// <summary>
        /// Returns hvec3.zyzx swizzling.
        /// </summary>
        public hvec4 zyzx => new hvec4(z, y, z, x);
        
        /// <summary>
        /// Returns hvec3.bgbr swizzling (equivalent to hvec3.zyzx).
        /// </summary>
        public hvec4 bgbr => new hvec4(z, y, z, x);
        
        /// <summary>
        /// Returns hvec3.zyzxx swizzling.
        /// </summary>
        public hvec5 zyzxx => new hvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns hvec3.bgbrr swizzling (equivalent to hvec3.zyzxx).
        /// </summary>
        public hvec5 bgbrr => new hvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns hvec3.zyzxy swizzling.
        /// </summary>
        public hvec5 zyzxy => new hvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns hvec3.bgbrg swizzling (equivalent to hvec3.zyzxy).
        /// </summary>
        public hvec5 bgbrg => new hvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns hvec3.zyzxz swizzling.
        /// </summary>
        public hvec5 zyzxz => new hvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns hvec3.bgbrb swizzling (equivalent to hvec3.zyzxz).
        /// </summary>
        public hvec5 bgbrb => new hvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns hvec3.zyzy swizzling.
        /// </summary>
        public hvec4 zyzy => new hvec4(z, y, z, y);
        
        /// <summary>
        /// Returns hvec3.bgbg swizzling (equivalent to hvec3.zyzy).
        /// </summary>
        public hvec4 bgbg => new hvec4(z, y, z, y);
        
        /// <summary>
        /// Returns hvec3.zyzyx swizzling.
        /// </summary>
        public hvec5 zyzyx => new hvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns hvec3.bgbgr swizzling (equivalent to hvec3.zyzyx).
        /// </summary>
        public hvec5 bgbgr => new hvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns hvec3.zyzyy swizzling.
        /// </summary>
        public hvec5 zyzyy => new hvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns hvec3.bgbgg swizzling (equivalent to hvec3.zyzyy).
        /// </summary>
        public hvec5 bgbgg => new hvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns hvec3.zyzyz swizzling.
        /// </summary>
        public hvec5 zyzyz => new hvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns hvec3.bgbgb swizzling (equivalent to hvec3.zyzyz).
        /// </summary>
        public hvec5 bgbgb => new hvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns hvec3.zyzz swizzling.
        /// </summary>
        public hvec4 zyzz => new hvec4(z, y, z, z);
        
        /// <summary>
        /// Returns hvec3.bgbb swizzling (equivalent to hvec3.zyzz).
        /// </summary>
        public hvec4 bgbb => new hvec4(z, y, z, z);
        
        /// <summary>
        /// Returns hvec3.zyzzx swizzling.
        /// </summary>
        public hvec5 zyzzx => new hvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns hvec3.bgbbr swizzling (equivalent to hvec3.zyzzx).
        /// </summary>
        public hvec5 bgbbr => new hvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns hvec3.zyzzy swizzling.
        /// </summary>
        public hvec5 zyzzy => new hvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns hvec3.bgbbg swizzling (equivalent to hvec3.zyzzy).
        /// </summary>
        public hvec5 bgbbg => new hvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns hvec3.zyzzz swizzling.
        /// </summary>
        public hvec5 zyzzz => new hvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns hvec3.bgbbb swizzling (equivalent to hvec3.zyzzz).
        /// </summary>
        public hvec5 bgbbb => new hvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns hvec3.zz swizzling.
        /// </summary>
        public hvec2 zz => new hvec2(z, z);
        
        /// <summary>
        /// Returns hvec3.bb swizzling (equivalent to hvec3.zz).
        /// </summary>
        public hvec2 bb => new hvec2(z, z);
        
        /// <summary>
        /// Returns hvec3.zzx swizzling.
        /// </summary>
        public hvec3 zzx => new hvec3(z, z, x);
        
        /// <summary>
        /// Returns hvec3.bbr swizzling (equivalent to hvec3.zzx).
        /// </summary>
        public hvec3 bbr => new hvec3(z, z, x);
        
        /// <summary>
        /// Returns hvec3.zzxx swizzling.
        /// </summary>
        public hvec4 zzxx => new hvec4(z, z, x, x);
        
        /// <summary>
        /// Returns hvec3.bbrr swizzling (equivalent to hvec3.zzxx).
        /// </summary>
        public hvec4 bbrr => new hvec4(z, z, x, x);
        
        /// <summary>
        /// Returns hvec3.zzxxx swizzling.
        /// </summary>
        public hvec5 zzxxx => new hvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns hvec3.bbrrr swizzling (equivalent to hvec3.zzxxx).
        /// </summary>
        public hvec5 bbrrr => new hvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns hvec3.zzxxy swizzling.
        /// </summary>
        public hvec5 zzxxy => new hvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns hvec3.bbrrg swizzling (equivalent to hvec3.zzxxy).
        /// </summary>
        public hvec5 bbrrg => new hvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns hvec3.zzxxz swizzling.
        /// </summary>
        public hvec5 zzxxz => new hvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns hvec3.bbrrb swizzling (equivalent to hvec3.zzxxz).
        /// </summary>
        public hvec5 bbrrb => new hvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns hvec3.zzxy swizzling.
        /// </summary>
        public hvec4 zzxy => new hvec4(z, z, x, y);
        
        /// <summary>
        /// Returns hvec3.bbrg swizzling (equivalent to hvec3.zzxy).
        /// </summary>
        public hvec4 bbrg => new hvec4(z, z, x, y);
        
        /// <summary>
        /// Returns hvec3.zzxyx swizzling.
        /// </summary>
        public hvec5 zzxyx => new hvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns hvec3.bbrgr swizzling (equivalent to hvec3.zzxyx).
        /// </summary>
        public hvec5 bbrgr => new hvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns hvec3.zzxyy swizzling.
        /// </summary>
        public hvec5 zzxyy => new hvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns hvec3.bbrgg swizzling (equivalent to hvec3.zzxyy).
        /// </summary>
        public hvec5 bbrgg => new hvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns hvec3.zzxyz swizzling.
        /// </summary>
        public hvec5 zzxyz => new hvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns hvec3.bbrgb swizzling (equivalent to hvec3.zzxyz).
        /// </summary>
        public hvec5 bbrgb => new hvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns hvec3.zzxz swizzling.
        /// </summary>
        public hvec4 zzxz => new hvec4(z, z, x, z);
        
        /// <summary>
        /// Returns hvec3.bbrb swizzling (equivalent to hvec3.zzxz).
        /// </summary>
        public hvec4 bbrb => new hvec4(z, z, x, z);
        
        /// <summary>
        /// Returns hvec3.zzxzx swizzling.
        /// </summary>
        public hvec5 zzxzx => new hvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns hvec3.bbrbr swizzling (equivalent to hvec3.zzxzx).
        /// </summary>
        public hvec5 bbrbr => new hvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns hvec3.zzxzy swizzling.
        /// </summary>
        public hvec5 zzxzy => new hvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns hvec3.bbrbg swizzling (equivalent to hvec3.zzxzy).
        /// </summary>
        public hvec5 bbrbg => new hvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns hvec3.zzxzz swizzling.
        /// </summary>
        public hvec5 zzxzz => new hvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns hvec3.bbrbb swizzling (equivalent to hvec3.zzxzz).
        /// </summary>
        public hvec5 bbrbb => new hvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns hvec3.zzy swizzling.
        /// </summary>
        public hvec3 zzy => new hvec3(z, z, y);
        
        /// <summary>
        /// Returns hvec3.bbg swizzling (equivalent to hvec3.zzy).
        /// </summary>
        public hvec3 bbg => new hvec3(z, z, y);
        
        /// <summary>
        /// Returns hvec3.zzyx swizzling.
        /// </summary>
        public hvec4 zzyx => new hvec4(z, z, y, x);
        
        /// <summary>
        /// Returns hvec3.bbgr swizzling (equivalent to hvec3.zzyx).
        /// </summary>
        public hvec4 bbgr => new hvec4(z, z, y, x);
        
        /// <summary>
        /// Returns hvec3.zzyxx swizzling.
        /// </summary>
        public hvec5 zzyxx => new hvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns hvec3.bbgrr swizzling (equivalent to hvec3.zzyxx).
        /// </summary>
        public hvec5 bbgrr => new hvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns hvec3.zzyxy swizzling.
        /// </summary>
        public hvec5 zzyxy => new hvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns hvec3.bbgrg swizzling (equivalent to hvec3.zzyxy).
        /// </summary>
        public hvec5 bbgrg => new hvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns hvec3.zzyxz swizzling.
        /// </summary>
        public hvec5 zzyxz => new hvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns hvec3.bbgrb swizzling (equivalent to hvec3.zzyxz).
        /// </summary>
        public hvec5 bbgrb => new hvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns hvec3.zzyy swizzling.
        /// </summary>
        public hvec4 zzyy => new hvec4(z, z, y, y);
        
        /// <summary>
        /// Returns hvec3.bbgg swizzling (equivalent to hvec3.zzyy).
        /// </summary>
        public hvec4 bbgg => new hvec4(z, z, y, y);
        
        /// <summary>
        /// Returns hvec3.zzyyx swizzling.
        /// </summary>
        public hvec5 zzyyx => new hvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns hvec3.bbggr swizzling (equivalent to hvec3.zzyyx).
        /// </summary>
        public hvec5 bbggr => new hvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns hvec3.zzyyy swizzling.
        /// </summary>
        public hvec5 zzyyy => new hvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns hvec3.bbggg swizzling (equivalent to hvec3.zzyyy).
        /// </summary>
        public hvec5 bbggg => new hvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns hvec3.zzyyz swizzling.
        /// </summary>
        public hvec5 zzyyz => new hvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns hvec3.bbggb swizzling (equivalent to hvec3.zzyyz).
        /// </summary>
        public hvec5 bbggb => new hvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns hvec3.zzyz swizzling.
        /// </summary>
        public hvec4 zzyz => new hvec4(z, z, y, z);
        
        /// <summary>
        /// Returns hvec3.bbgb swizzling (equivalent to hvec3.zzyz).
        /// </summary>
        public hvec4 bbgb => new hvec4(z, z, y, z);
        
        /// <summary>
        /// Returns hvec3.zzyzx swizzling.
        /// </summary>
        public hvec5 zzyzx => new hvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns hvec3.bbgbr swizzling (equivalent to hvec3.zzyzx).
        /// </summary>
        public hvec5 bbgbr => new hvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns hvec3.zzyzy swizzling.
        /// </summary>
        public hvec5 zzyzy => new hvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns hvec3.bbgbg swizzling (equivalent to hvec3.zzyzy).
        /// </summary>
        public hvec5 bbgbg => new hvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns hvec3.zzyzz swizzling.
        /// </summary>
        public hvec5 zzyzz => new hvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns hvec3.bbgbb swizzling (equivalent to hvec3.zzyzz).
        /// </summary>
        public hvec5 bbgbb => new hvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns hvec3.zzz swizzling.
        /// </summary>
        public hvec3 zzz => new hvec3(z, z, z);
        
        /// <summary>
        /// Returns hvec3.bbb swizzling (equivalent to hvec3.zzz).
        /// </summary>
        public hvec3 bbb => new hvec3(z, z, z);
        
        /// <summary>
        /// Returns hvec3.zzzx swizzling.
        /// </summary>
        public hvec4 zzzx => new hvec4(z, z, z, x);
        
        /// <summary>
        /// Returns hvec3.bbbr swizzling (equivalent to hvec3.zzzx).
        /// </summary>
        public hvec4 bbbr => new hvec4(z, z, z, x);
        
        /// <summary>
        /// Returns hvec3.zzzxx swizzling.
        /// </summary>
        public hvec5 zzzxx => new hvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns hvec3.bbbrr swizzling (equivalent to hvec3.zzzxx).
        /// </summary>
        public hvec5 bbbrr => new hvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns hvec3.zzzxy swizzling.
        /// </summary>
        public hvec5 zzzxy => new hvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns hvec3.bbbrg swizzling (equivalent to hvec3.zzzxy).
        /// </summary>
        public hvec5 bbbrg => new hvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns hvec3.zzzxz swizzling.
        /// </summary>
        public hvec5 zzzxz => new hvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns hvec3.bbbrb swizzling (equivalent to hvec3.zzzxz).
        /// </summary>
        public hvec5 bbbrb => new hvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns hvec3.zzzy swizzling.
        /// </summary>
        public hvec4 zzzy => new hvec4(z, z, z, y);
        
        /// <summary>
        /// Returns hvec3.bbbg swizzling (equivalent to hvec3.zzzy).
        /// </summary>
        public hvec4 bbbg => new hvec4(z, z, z, y);
        
        /// <summary>
        /// Returns hvec3.zzzyx swizzling.
        /// </summary>
        public hvec5 zzzyx => new hvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns hvec3.bbbgr swizzling (equivalent to hvec3.zzzyx).
        /// </summary>
        public hvec5 bbbgr => new hvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns hvec3.zzzyy swizzling.
        /// </summary>
        public hvec5 zzzyy => new hvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns hvec3.bbbgg swizzling (equivalent to hvec3.zzzyy).
        /// </summary>
        public hvec5 bbbgg => new hvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns hvec3.zzzyz swizzling.
        /// </summary>
        public hvec5 zzzyz => new hvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns hvec3.bbbgb swizzling (equivalent to hvec3.zzzyz).
        /// </summary>
        public hvec5 bbbgb => new hvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns hvec3.zzzz swizzling.
        /// </summary>
        public hvec4 zzzz => new hvec4(z, z, z, z);
        
        /// <summary>
        /// Returns hvec3.bbbb swizzling (equivalent to hvec3.zzzz).
        /// </summary>
        public hvec4 bbbb => new hvec4(z, z, z, z);
        
        /// <summary>
        /// Returns hvec3.zzzzx swizzling.
        /// </summary>
        public hvec5 zzzzx => new hvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns hvec3.bbbbr swizzling (equivalent to hvec3.zzzzx).
        /// </summary>
        public hvec5 bbbbr => new hvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns hvec3.zzzzy swizzling.
        /// </summary>
        public hvec5 zzzzy => new hvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns hvec3.bbbbg swizzling (equivalent to hvec3.zzzzy).
        /// </summary>
        public hvec5 bbbbg => new hvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns hvec3.zzzzz swizzling.
        /// </summary>
        public hvec5 zzzzz => new hvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns hvec3.bbbbb swizzling (equivalent to hvec3.zzzzz).
        /// </summary>
        public hvec5 bbbbb => new hvec5(z, z, z, z, z);

        #endregion

    }
}
