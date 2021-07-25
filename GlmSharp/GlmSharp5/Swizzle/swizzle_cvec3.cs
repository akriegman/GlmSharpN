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
    /// Temporary vector of type Complex with 3 components, used for implementing swizzling for cvec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_cvec3
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_cvec3.
        /// </summary>
        internal swizzle_cvec3(Complex x, Complex y, Complex z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns cvec3.xx swizzling.
        /// </summary>
        public cvec2 xx => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec3.rr swizzling (equivalent to cvec3.xx).
        /// </summary>
        public cvec2 rr => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec3.xxx swizzling.
        /// </summary>
        public cvec3 xxx => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec3.rrr swizzling (equivalent to cvec3.xxx).
        /// </summary>
        public cvec3 rrr => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec3.xxxx swizzling.
        /// </summary>
        public cvec4 xxxx => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec3.rrrr swizzling (equivalent to cvec3.xxxx).
        /// </summary>
        public cvec4 rrrr => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec3.xxxxx swizzling.
        /// </summary>
        public cvec5 xxxxx => new cvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns cvec3.rrrrr swizzling (equivalent to cvec3.xxxxx).
        /// </summary>
        public cvec5 rrrrr => new cvec5(x, x, x, x, x);
        
        /// <summary>
        /// Returns cvec3.xxxxy swizzling.
        /// </summary>
        public cvec5 xxxxy => new cvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns cvec3.rrrrg swizzling (equivalent to cvec3.xxxxy).
        /// </summary>
        public cvec5 rrrrg => new cvec5(x, x, x, x, y);
        
        /// <summary>
        /// Returns cvec3.xxxxz swizzling.
        /// </summary>
        public cvec5 xxxxz => new cvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns cvec3.rrrrb swizzling (equivalent to cvec3.xxxxz).
        /// </summary>
        public cvec5 rrrrb => new cvec5(x, x, x, x, z);
        
        /// <summary>
        /// Returns cvec3.xxxy swizzling.
        /// </summary>
        public cvec4 xxxy => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec3.rrrg swizzling (equivalent to cvec3.xxxy).
        /// </summary>
        public cvec4 rrrg => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec3.xxxyx swizzling.
        /// </summary>
        public cvec5 xxxyx => new cvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns cvec3.rrrgr swizzling (equivalent to cvec3.xxxyx).
        /// </summary>
        public cvec5 rrrgr => new cvec5(x, x, x, y, x);
        
        /// <summary>
        /// Returns cvec3.xxxyy swizzling.
        /// </summary>
        public cvec5 xxxyy => new cvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns cvec3.rrrgg swizzling (equivalent to cvec3.xxxyy).
        /// </summary>
        public cvec5 rrrgg => new cvec5(x, x, x, y, y);
        
        /// <summary>
        /// Returns cvec3.xxxyz swizzling.
        /// </summary>
        public cvec5 xxxyz => new cvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns cvec3.rrrgb swizzling (equivalent to cvec3.xxxyz).
        /// </summary>
        public cvec5 rrrgb => new cvec5(x, x, x, y, z);
        
        /// <summary>
        /// Returns cvec3.xxxz swizzling.
        /// </summary>
        public cvec4 xxxz => new cvec4(x, x, x, z);
        
        /// <summary>
        /// Returns cvec3.rrrb swizzling (equivalent to cvec3.xxxz).
        /// </summary>
        public cvec4 rrrb => new cvec4(x, x, x, z);
        
        /// <summary>
        /// Returns cvec3.xxxzx swizzling.
        /// </summary>
        public cvec5 xxxzx => new cvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns cvec3.rrrbr swizzling (equivalent to cvec3.xxxzx).
        /// </summary>
        public cvec5 rrrbr => new cvec5(x, x, x, z, x);
        
        /// <summary>
        /// Returns cvec3.xxxzy swizzling.
        /// </summary>
        public cvec5 xxxzy => new cvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns cvec3.rrrbg swizzling (equivalent to cvec3.xxxzy).
        /// </summary>
        public cvec5 rrrbg => new cvec5(x, x, x, z, y);
        
        /// <summary>
        /// Returns cvec3.xxxzz swizzling.
        /// </summary>
        public cvec5 xxxzz => new cvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns cvec3.rrrbb swizzling (equivalent to cvec3.xxxzz).
        /// </summary>
        public cvec5 rrrbb => new cvec5(x, x, x, z, z);
        
        /// <summary>
        /// Returns cvec3.xxy swizzling.
        /// </summary>
        public cvec3 xxy => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec3.rrg swizzling (equivalent to cvec3.xxy).
        /// </summary>
        public cvec3 rrg => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec3.xxyx swizzling.
        /// </summary>
        public cvec4 xxyx => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec3.rrgr swizzling (equivalent to cvec3.xxyx).
        /// </summary>
        public cvec4 rrgr => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec3.xxyxx swizzling.
        /// </summary>
        public cvec5 xxyxx => new cvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns cvec3.rrgrr swizzling (equivalent to cvec3.xxyxx).
        /// </summary>
        public cvec5 rrgrr => new cvec5(x, x, y, x, x);
        
        /// <summary>
        /// Returns cvec3.xxyxy swizzling.
        /// </summary>
        public cvec5 xxyxy => new cvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns cvec3.rrgrg swizzling (equivalent to cvec3.xxyxy).
        /// </summary>
        public cvec5 rrgrg => new cvec5(x, x, y, x, y);
        
        /// <summary>
        /// Returns cvec3.xxyxz swizzling.
        /// </summary>
        public cvec5 xxyxz => new cvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns cvec3.rrgrb swizzling (equivalent to cvec3.xxyxz).
        /// </summary>
        public cvec5 rrgrb => new cvec5(x, x, y, x, z);
        
        /// <summary>
        /// Returns cvec3.xxyy swizzling.
        /// </summary>
        public cvec4 xxyy => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec3.rrgg swizzling (equivalent to cvec3.xxyy).
        /// </summary>
        public cvec4 rrgg => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec3.xxyyx swizzling.
        /// </summary>
        public cvec5 xxyyx => new cvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns cvec3.rrggr swizzling (equivalent to cvec3.xxyyx).
        /// </summary>
        public cvec5 rrggr => new cvec5(x, x, y, y, x);
        
        /// <summary>
        /// Returns cvec3.xxyyy swizzling.
        /// </summary>
        public cvec5 xxyyy => new cvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns cvec3.rrggg swizzling (equivalent to cvec3.xxyyy).
        /// </summary>
        public cvec5 rrggg => new cvec5(x, x, y, y, y);
        
        /// <summary>
        /// Returns cvec3.xxyyz swizzling.
        /// </summary>
        public cvec5 xxyyz => new cvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns cvec3.rrggb swizzling (equivalent to cvec3.xxyyz).
        /// </summary>
        public cvec5 rrggb => new cvec5(x, x, y, y, z);
        
        /// <summary>
        /// Returns cvec3.xxyz swizzling.
        /// </summary>
        public cvec4 xxyz => new cvec4(x, x, y, z);
        
        /// <summary>
        /// Returns cvec3.rrgb swizzling (equivalent to cvec3.xxyz).
        /// </summary>
        public cvec4 rrgb => new cvec4(x, x, y, z);
        
        /// <summary>
        /// Returns cvec3.xxyzx swizzling.
        /// </summary>
        public cvec5 xxyzx => new cvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns cvec3.rrgbr swizzling (equivalent to cvec3.xxyzx).
        /// </summary>
        public cvec5 rrgbr => new cvec5(x, x, y, z, x);
        
        /// <summary>
        /// Returns cvec3.xxyzy swizzling.
        /// </summary>
        public cvec5 xxyzy => new cvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns cvec3.rrgbg swizzling (equivalent to cvec3.xxyzy).
        /// </summary>
        public cvec5 rrgbg => new cvec5(x, x, y, z, y);
        
        /// <summary>
        /// Returns cvec3.xxyzz swizzling.
        /// </summary>
        public cvec5 xxyzz => new cvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns cvec3.rrgbb swizzling (equivalent to cvec3.xxyzz).
        /// </summary>
        public cvec5 rrgbb => new cvec5(x, x, y, z, z);
        
        /// <summary>
        /// Returns cvec3.xxz swizzling.
        /// </summary>
        public cvec3 xxz => new cvec3(x, x, z);
        
        /// <summary>
        /// Returns cvec3.rrb swizzling (equivalent to cvec3.xxz).
        /// </summary>
        public cvec3 rrb => new cvec3(x, x, z);
        
        /// <summary>
        /// Returns cvec3.xxzx swizzling.
        /// </summary>
        public cvec4 xxzx => new cvec4(x, x, z, x);
        
        /// <summary>
        /// Returns cvec3.rrbr swizzling (equivalent to cvec3.xxzx).
        /// </summary>
        public cvec4 rrbr => new cvec4(x, x, z, x);
        
        /// <summary>
        /// Returns cvec3.xxzxx swizzling.
        /// </summary>
        public cvec5 xxzxx => new cvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns cvec3.rrbrr swizzling (equivalent to cvec3.xxzxx).
        /// </summary>
        public cvec5 rrbrr => new cvec5(x, x, z, x, x);
        
        /// <summary>
        /// Returns cvec3.xxzxy swizzling.
        /// </summary>
        public cvec5 xxzxy => new cvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns cvec3.rrbrg swizzling (equivalent to cvec3.xxzxy).
        /// </summary>
        public cvec5 rrbrg => new cvec5(x, x, z, x, y);
        
        /// <summary>
        /// Returns cvec3.xxzxz swizzling.
        /// </summary>
        public cvec5 xxzxz => new cvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns cvec3.rrbrb swizzling (equivalent to cvec3.xxzxz).
        /// </summary>
        public cvec5 rrbrb => new cvec5(x, x, z, x, z);
        
        /// <summary>
        /// Returns cvec3.xxzy swizzling.
        /// </summary>
        public cvec4 xxzy => new cvec4(x, x, z, y);
        
        /// <summary>
        /// Returns cvec3.rrbg swizzling (equivalent to cvec3.xxzy).
        /// </summary>
        public cvec4 rrbg => new cvec4(x, x, z, y);
        
        /// <summary>
        /// Returns cvec3.xxzyx swizzling.
        /// </summary>
        public cvec5 xxzyx => new cvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns cvec3.rrbgr swizzling (equivalent to cvec3.xxzyx).
        /// </summary>
        public cvec5 rrbgr => new cvec5(x, x, z, y, x);
        
        /// <summary>
        /// Returns cvec3.xxzyy swizzling.
        /// </summary>
        public cvec5 xxzyy => new cvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns cvec3.rrbgg swizzling (equivalent to cvec3.xxzyy).
        /// </summary>
        public cvec5 rrbgg => new cvec5(x, x, z, y, y);
        
        /// <summary>
        /// Returns cvec3.xxzyz swizzling.
        /// </summary>
        public cvec5 xxzyz => new cvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns cvec3.rrbgb swizzling (equivalent to cvec3.xxzyz).
        /// </summary>
        public cvec5 rrbgb => new cvec5(x, x, z, y, z);
        
        /// <summary>
        /// Returns cvec3.xxzz swizzling.
        /// </summary>
        public cvec4 xxzz => new cvec4(x, x, z, z);
        
        /// <summary>
        /// Returns cvec3.rrbb swizzling (equivalent to cvec3.xxzz).
        /// </summary>
        public cvec4 rrbb => new cvec4(x, x, z, z);
        
        /// <summary>
        /// Returns cvec3.xxzzx swizzling.
        /// </summary>
        public cvec5 xxzzx => new cvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns cvec3.rrbbr swizzling (equivalent to cvec3.xxzzx).
        /// </summary>
        public cvec5 rrbbr => new cvec5(x, x, z, z, x);
        
        /// <summary>
        /// Returns cvec3.xxzzy swizzling.
        /// </summary>
        public cvec5 xxzzy => new cvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns cvec3.rrbbg swizzling (equivalent to cvec3.xxzzy).
        /// </summary>
        public cvec5 rrbbg => new cvec5(x, x, z, z, y);
        
        /// <summary>
        /// Returns cvec3.xxzzz swizzling.
        /// </summary>
        public cvec5 xxzzz => new cvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns cvec3.rrbbb swizzling (equivalent to cvec3.xxzzz).
        /// </summary>
        public cvec5 rrbbb => new cvec5(x, x, z, z, z);
        
        /// <summary>
        /// Returns cvec3.xy swizzling.
        /// </summary>
        public cvec2 xy => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec3.rg swizzling (equivalent to cvec3.xy).
        /// </summary>
        public cvec2 rg => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec3.xyx swizzling.
        /// </summary>
        public cvec3 xyx => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec3.rgr swizzling (equivalent to cvec3.xyx).
        /// </summary>
        public cvec3 rgr => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec3.xyxx swizzling.
        /// </summary>
        public cvec4 xyxx => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec3.rgrr swizzling (equivalent to cvec3.xyxx).
        /// </summary>
        public cvec4 rgrr => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec3.xyxxx swizzling.
        /// </summary>
        public cvec5 xyxxx => new cvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns cvec3.rgrrr swizzling (equivalent to cvec3.xyxxx).
        /// </summary>
        public cvec5 rgrrr => new cvec5(x, y, x, x, x);
        
        /// <summary>
        /// Returns cvec3.xyxxy swizzling.
        /// </summary>
        public cvec5 xyxxy => new cvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns cvec3.rgrrg swizzling (equivalent to cvec3.xyxxy).
        /// </summary>
        public cvec5 rgrrg => new cvec5(x, y, x, x, y);
        
        /// <summary>
        /// Returns cvec3.xyxxz swizzling.
        /// </summary>
        public cvec5 xyxxz => new cvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns cvec3.rgrrb swizzling (equivalent to cvec3.xyxxz).
        /// </summary>
        public cvec5 rgrrb => new cvec5(x, y, x, x, z);
        
        /// <summary>
        /// Returns cvec3.xyxy swizzling.
        /// </summary>
        public cvec4 xyxy => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec3.rgrg swizzling (equivalent to cvec3.xyxy).
        /// </summary>
        public cvec4 rgrg => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec3.xyxyx swizzling.
        /// </summary>
        public cvec5 xyxyx => new cvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns cvec3.rgrgr swizzling (equivalent to cvec3.xyxyx).
        /// </summary>
        public cvec5 rgrgr => new cvec5(x, y, x, y, x);
        
        /// <summary>
        /// Returns cvec3.xyxyy swizzling.
        /// </summary>
        public cvec5 xyxyy => new cvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns cvec3.rgrgg swizzling (equivalent to cvec3.xyxyy).
        /// </summary>
        public cvec5 rgrgg => new cvec5(x, y, x, y, y);
        
        /// <summary>
        /// Returns cvec3.xyxyz swizzling.
        /// </summary>
        public cvec5 xyxyz => new cvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns cvec3.rgrgb swizzling (equivalent to cvec3.xyxyz).
        /// </summary>
        public cvec5 rgrgb => new cvec5(x, y, x, y, z);
        
        /// <summary>
        /// Returns cvec3.xyxz swizzling.
        /// </summary>
        public cvec4 xyxz => new cvec4(x, y, x, z);
        
        /// <summary>
        /// Returns cvec3.rgrb swizzling (equivalent to cvec3.xyxz).
        /// </summary>
        public cvec4 rgrb => new cvec4(x, y, x, z);
        
        /// <summary>
        /// Returns cvec3.xyxzx swizzling.
        /// </summary>
        public cvec5 xyxzx => new cvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns cvec3.rgrbr swizzling (equivalent to cvec3.xyxzx).
        /// </summary>
        public cvec5 rgrbr => new cvec5(x, y, x, z, x);
        
        /// <summary>
        /// Returns cvec3.xyxzy swizzling.
        /// </summary>
        public cvec5 xyxzy => new cvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns cvec3.rgrbg swizzling (equivalent to cvec3.xyxzy).
        /// </summary>
        public cvec5 rgrbg => new cvec5(x, y, x, z, y);
        
        /// <summary>
        /// Returns cvec3.xyxzz swizzling.
        /// </summary>
        public cvec5 xyxzz => new cvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns cvec3.rgrbb swizzling (equivalent to cvec3.xyxzz).
        /// </summary>
        public cvec5 rgrbb => new cvec5(x, y, x, z, z);
        
        /// <summary>
        /// Returns cvec3.xyy swizzling.
        /// </summary>
        public cvec3 xyy => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec3.rgg swizzling (equivalent to cvec3.xyy).
        /// </summary>
        public cvec3 rgg => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec3.xyyx swizzling.
        /// </summary>
        public cvec4 xyyx => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec3.rggr swizzling (equivalent to cvec3.xyyx).
        /// </summary>
        public cvec4 rggr => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec3.xyyxx swizzling.
        /// </summary>
        public cvec5 xyyxx => new cvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns cvec3.rggrr swizzling (equivalent to cvec3.xyyxx).
        /// </summary>
        public cvec5 rggrr => new cvec5(x, y, y, x, x);
        
        /// <summary>
        /// Returns cvec3.xyyxy swizzling.
        /// </summary>
        public cvec5 xyyxy => new cvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns cvec3.rggrg swizzling (equivalent to cvec3.xyyxy).
        /// </summary>
        public cvec5 rggrg => new cvec5(x, y, y, x, y);
        
        /// <summary>
        /// Returns cvec3.xyyxz swizzling.
        /// </summary>
        public cvec5 xyyxz => new cvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns cvec3.rggrb swizzling (equivalent to cvec3.xyyxz).
        /// </summary>
        public cvec5 rggrb => new cvec5(x, y, y, x, z);
        
        /// <summary>
        /// Returns cvec3.xyyy swizzling.
        /// </summary>
        public cvec4 xyyy => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec3.rggg swizzling (equivalent to cvec3.xyyy).
        /// </summary>
        public cvec4 rggg => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec3.xyyyx swizzling.
        /// </summary>
        public cvec5 xyyyx => new cvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns cvec3.rgggr swizzling (equivalent to cvec3.xyyyx).
        /// </summary>
        public cvec5 rgggr => new cvec5(x, y, y, y, x);
        
        /// <summary>
        /// Returns cvec3.xyyyy swizzling.
        /// </summary>
        public cvec5 xyyyy => new cvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns cvec3.rgggg swizzling (equivalent to cvec3.xyyyy).
        /// </summary>
        public cvec5 rgggg => new cvec5(x, y, y, y, y);
        
        /// <summary>
        /// Returns cvec3.xyyyz swizzling.
        /// </summary>
        public cvec5 xyyyz => new cvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns cvec3.rgggb swizzling (equivalent to cvec3.xyyyz).
        /// </summary>
        public cvec5 rgggb => new cvec5(x, y, y, y, z);
        
        /// <summary>
        /// Returns cvec3.xyyz swizzling.
        /// </summary>
        public cvec4 xyyz => new cvec4(x, y, y, z);
        
        /// <summary>
        /// Returns cvec3.rggb swizzling (equivalent to cvec3.xyyz).
        /// </summary>
        public cvec4 rggb => new cvec4(x, y, y, z);
        
        /// <summary>
        /// Returns cvec3.xyyzx swizzling.
        /// </summary>
        public cvec5 xyyzx => new cvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns cvec3.rggbr swizzling (equivalent to cvec3.xyyzx).
        /// </summary>
        public cvec5 rggbr => new cvec5(x, y, y, z, x);
        
        /// <summary>
        /// Returns cvec3.xyyzy swizzling.
        /// </summary>
        public cvec5 xyyzy => new cvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns cvec3.rggbg swizzling (equivalent to cvec3.xyyzy).
        /// </summary>
        public cvec5 rggbg => new cvec5(x, y, y, z, y);
        
        /// <summary>
        /// Returns cvec3.xyyzz swizzling.
        /// </summary>
        public cvec5 xyyzz => new cvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns cvec3.rggbb swizzling (equivalent to cvec3.xyyzz).
        /// </summary>
        public cvec5 rggbb => new cvec5(x, y, y, z, z);
        
        /// <summary>
        /// Returns cvec3.xyz swizzling.
        /// </summary>
        public cvec3 xyz => new cvec3(x, y, z);
        
        /// <summary>
        /// Returns cvec3.rgb swizzling (equivalent to cvec3.xyz).
        /// </summary>
        public cvec3 rgb => new cvec3(x, y, z);
        
        /// <summary>
        /// Returns cvec3.xyzx swizzling.
        /// </summary>
        public cvec4 xyzx => new cvec4(x, y, z, x);
        
        /// <summary>
        /// Returns cvec3.rgbr swizzling (equivalent to cvec3.xyzx).
        /// </summary>
        public cvec4 rgbr => new cvec4(x, y, z, x);
        
        /// <summary>
        /// Returns cvec3.xyzxx swizzling.
        /// </summary>
        public cvec5 xyzxx => new cvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns cvec3.rgbrr swizzling (equivalent to cvec3.xyzxx).
        /// </summary>
        public cvec5 rgbrr => new cvec5(x, y, z, x, x);
        
        /// <summary>
        /// Returns cvec3.xyzxy swizzling.
        /// </summary>
        public cvec5 xyzxy => new cvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns cvec3.rgbrg swizzling (equivalent to cvec3.xyzxy).
        /// </summary>
        public cvec5 rgbrg => new cvec5(x, y, z, x, y);
        
        /// <summary>
        /// Returns cvec3.xyzxz swizzling.
        /// </summary>
        public cvec5 xyzxz => new cvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns cvec3.rgbrb swizzling (equivalent to cvec3.xyzxz).
        /// </summary>
        public cvec5 rgbrb => new cvec5(x, y, z, x, z);
        
        /// <summary>
        /// Returns cvec3.xyzy swizzling.
        /// </summary>
        public cvec4 xyzy => new cvec4(x, y, z, y);
        
        /// <summary>
        /// Returns cvec3.rgbg swizzling (equivalent to cvec3.xyzy).
        /// </summary>
        public cvec4 rgbg => new cvec4(x, y, z, y);
        
        /// <summary>
        /// Returns cvec3.xyzyx swizzling.
        /// </summary>
        public cvec5 xyzyx => new cvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns cvec3.rgbgr swizzling (equivalent to cvec3.xyzyx).
        /// </summary>
        public cvec5 rgbgr => new cvec5(x, y, z, y, x);
        
        /// <summary>
        /// Returns cvec3.xyzyy swizzling.
        /// </summary>
        public cvec5 xyzyy => new cvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns cvec3.rgbgg swizzling (equivalent to cvec3.xyzyy).
        /// </summary>
        public cvec5 rgbgg => new cvec5(x, y, z, y, y);
        
        /// <summary>
        /// Returns cvec3.xyzyz swizzling.
        /// </summary>
        public cvec5 xyzyz => new cvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns cvec3.rgbgb swizzling (equivalent to cvec3.xyzyz).
        /// </summary>
        public cvec5 rgbgb => new cvec5(x, y, z, y, z);
        
        /// <summary>
        /// Returns cvec3.xyzz swizzling.
        /// </summary>
        public cvec4 xyzz => new cvec4(x, y, z, z);
        
        /// <summary>
        /// Returns cvec3.rgbb swizzling (equivalent to cvec3.xyzz).
        /// </summary>
        public cvec4 rgbb => new cvec4(x, y, z, z);
        
        /// <summary>
        /// Returns cvec3.xyzzx swizzling.
        /// </summary>
        public cvec5 xyzzx => new cvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns cvec3.rgbbr swizzling (equivalent to cvec3.xyzzx).
        /// </summary>
        public cvec5 rgbbr => new cvec5(x, y, z, z, x);
        
        /// <summary>
        /// Returns cvec3.xyzzy swizzling.
        /// </summary>
        public cvec5 xyzzy => new cvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns cvec3.rgbbg swizzling (equivalent to cvec3.xyzzy).
        /// </summary>
        public cvec5 rgbbg => new cvec5(x, y, z, z, y);
        
        /// <summary>
        /// Returns cvec3.xyzzz swizzling.
        /// </summary>
        public cvec5 xyzzz => new cvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns cvec3.rgbbb swizzling (equivalent to cvec3.xyzzz).
        /// </summary>
        public cvec5 rgbbb => new cvec5(x, y, z, z, z);
        
        /// <summary>
        /// Returns cvec3.xz swizzling.
        /// </summary>
        public cvec2 xz => new cvec2(x, z);
        
        /// <summary>
        /// Returns cvec3.rb swizzling (equivalent to cvec3.xz).
        /// </summary>
        public cvec2 rb => new cvec2(x, z);
        
        /// <summary>
        /// Returns cvec3.xzx swizzling.
        /// </summary>
        public cvec3 xzx => new cvec3(x, z, x);
        
        /// <summary>
        /// Returns cvec3.rbr swizzling (equivalent to cvec3.xzx).
        /// </summary>
        public cvec3 rbr => new cvec3(x, z, x);
        
        /// <summary>
        /// Returns cvec3.xzxx swizzling.
        /// </summary>
        public cvec4 xzxx => new cvec4(x, z, x, x);
        
        /// <summary>
        /// Returns cvec3.rbrr swizzling (equivalent to cvec3.xzxx).
        /// </summary>
        public cvec4 rbrr => new cvec4(x, z, x, x);
        
        /// <summary>
        /// Returns cvec3.xzxxx swizzling.
        /// </summary>
        public cvec5 xzxxx => new cvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns cvec3.rbrrr swizzling (equivalent to cvec3.xzxxx).
        /// </summary>
        public cvec5 rbrrr => new cvec5(x, z, x, x, x);
        
        /// <summary>
        /// Returns cvec3.xzxxy swizzling.
        /// </summary>
        public cvec5 xzxxy => new cvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns cvec3.rbrrg swizzling (equivalent to cvec3.xzxxy).
        /// </summary>
        public cvec5 rbrrg => new cvec5(x, z, x, x, y);
        
        /// <summary>
        /// Returns cvec3.xzxxz swizzling.
        /// </summary>
        public cvec5 xzxxz => new cvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns cvec3.rbrrb swizzling (equivalent to cvec3.xzxxz).
        /// </summary>
        public cvec5 rbrrb => new cvec5(x, z, x, x, z);
        
        /// <summary>
        /// Returns cvec3.xzxy swizzling.
        /// </summary>
        public cvec4 xzxy => new cvec4(x, z, x, y);
        
        /// <summary>
        /// Returns cvec3.rbrg swizzling (equivalent to cvec3.xzxy).
        /// </summary>
        public cvec4 rbrg => new cvec4(x, z, x, y);
        
        /// <summary>
        /// Returns cvec3.xzxyx swizzling.
        /// </summary>
        public cvec5 xzxyx => new cvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns cvec3.rbrgr swizzling (equivalent to cvec3.xzxyx).
        /// </summary>
        public cvec5 rbrgr => new cvec5(x, z, x, y, x);
        
        /// <summary>
        /// Returns cvec3.xzxyy swizzling.
        /// </summary>
        public cvec5 xzxyy => new cvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns cvec3.rbrgg swizzling (equivalent to cvec3.xzxyy).
        /// </summary>
        public cvec5 rbrgg => new cvec5(x, z, x, y, y);
        
        /// <summary>
        /// Returns cvec3.xzxyz swizzling.
        /// </summary>
        public cvec5 xzxyz => new cvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns cvec3.rbrgb swizzling (equivalent to cvec3.xzxyz).
        /// </summary>
        public cvec5 rbrgb => new cvec5(x, z, x, y, z);
        
        /// <summary>
        /// Returns cvec3.xzxz swizzling.
        /// </summary>
        public cvec4 xzxz => new cvec4(x, z, x, z);
        
        /// <summary>
        /// Returns cvec3.rbrb swizzling (equivalent to cvec3.xzxz).
        /// </summary>
        public cvec4 rbrb => new cvec4(x, z, x, z);
        
        /// <summary>
        /// Returns cvec3.xzxzx swizzling.
        /// </summary>
        public cvec5 xzxzx => new cvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns cvec3.rbrbr swizzling (equivalent to cvec3.xzxzx).
        /// </summary>
        public cvec5 rbrbr => new cvec5(x, z, x, z, x);
        
        /// <summary>
        /// Returns cvec3.xzxzy swizzling.
        /// </summary>
        public cvec5 xzxzy => new cvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns cvec3.rbrbg swizzling (equivalent to cvec3.xzxzy).
        /// </summary>
        public cvec5 rbrbg => new cvec5(x, z, x, z, y);
        
        /// <summary>
        /// Returns cvec3.xzxzz swizzling.
        /// </summary>
        public cvec5 xzxzz => new cvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns cvec3.rbrbb swizzling (equivalent to cvec3.xzxzz).
        /// </summary>
        public cvec5 rbrbb => new cvec5(x, z, x, z, z);
        
        /// <summary>
        /// Returns cvec3.xzy swizzling.
        /// </summary>
        public cvec3 xzy => new cvec3(x, z, y);
        
        /// <summary>
        /// Returns cvec3.rbg swizzling (equivalent to cvec3.xzy).
        /// </summary>
        public cvec3 rbg => new cvec3(x, z, y);
        
        /// <summary>
        /// Returns cvec3.xzyx swizzling.
        /// </summary>
        public cvec4 xzyx => new cvec4(x, z, y, x);
        
        /// <summary>
        /// Returns cvec3.rbgr swizzling (equivalent to cvec3.xzyx).
        /// </summary>
        public cvec4 rbgr => new cvec4(x, z, y, x);
        
        /// <summary>
        /// Returns cvec3.xzyxx swizzling.
        /// </summary>
        public cvec5 xzyxx => new cvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns cvec3.rbgrr swizzling (equivalent to cvec3.xzyxx).
        /// </summary>
        public cvec5 rbgrr => new cvec5(x, z, y, x, x);
        
        /// <summary>
        /// Returns cvec3.xzyxy swizzling.
        /// </summary>
        public cvec5 xzyxy => new cvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns cvec3.rbgrg swizzling (equivalent to cvec3.xzyxy).
        /// </summary>
        public cvec5 rbgrg => new cvec5(x, z, y, x, y);
        
        /// <summary>
        /// Returns cvec3.xzyxz swizzling.
        /// </summary>
        public cvec5 xzyxz => new cvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns cvec3.rbgrb swizzling (equivalent to cvec3.xzyxz).
        /// </summary>
        public cvec5 rbgrb => new cvec5(x, z, y, x, z);
        
        /// <summary>
        /// Returns cvec3.xzyy swizzling.
        /// </summary>
        public cvec4 xzyy => new cvec4(x, z, y, y);
        
        /// <summary>
        /// Returns cvec3.rbgg swizzling (equivalent to cvec3.xzyy).
        /// </summary>
        public cvec4 rbgg => new cvec4(x, z, y, y);
        
        /// <summary>
        /// Returns cvec3.xzyyx swizzling.
        /// </summary>
        public cvec5 xzyyx => new cvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns cvec3.rbggr swizzling (equivalent to cvec3.xzyyx).
        /// </summary>
        public cvec5 rbggr => new cvec5(x, z, y, y, x);
        
        /// <summary>
        /// Returns cvec3.xzyyy swizzling.
        /// </summary>
        public cvec5 xzyyy => new cvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns cvec3.rbggg swizzling (equivalent to cvec3.xzyyy).
        /// </summary>
        public cvec5 rbggg => new cvec5(x, z, y, y, y);
        
        /// <summary>
        /// Returns cvec3.xzyyz swizzling.
        /// </summary>
        public cvec5 xzyyz => new cvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns cvec3.rbggb swizzling (equivalent to cvec3.xzyyz).
        /// </summary>
        public cvec5 rbggb => new cvec5(x, z, y, y, z);
        
        /// <summary>
        /// Returns cvec3.xzyz swizzling.
        /// </summary>
        public cvec4 xzyz => new cvec4(x, z, y, z);
        
        /// <summary>
        /// Returns cvec3.rbgb swizzling (equivalent to cvec3.xzyz).
        /// </summary>
        public cvec4 rbgb => new cvec4(x, z, y, z);
        
        /// <summary>
        /// Returns cvec3.xzyzx swizzling.
        /// </summary>
        public cvec5 xzyzx => new cvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns cvec3.rbgbr swizzling (equivalent to cvec3.xzyzx).
        /// </summary>
        public cvec5 rbgbr => new cvec5(x, z, y, z, x);
        
        /// <summary>
        /// Returns cvec3.xzyzy swizzling.
        /// </summary>
        public cvec5 xzyzy => new cvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns cvec3.rbgbg swizzling (equivalent to cvec3.xzyzy).
        /// </summary>
        public cvec5 rbgbg => new cvec5(x, z, y, z, y);
        
        /// <summary>
        /// Returns cvec3.xzyzz swizzling.
        /// </summary>
        public cvec5 xzyzz => new cvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns cvec3.rbgbb swizzling (equivalent to cvec3.xzyzz).
        /// </summary>
        public cvec5 rbgbb => new cvec5(x, z, y, z, z);
        
        /// <summary>
        /// Returns cvec3.xzz swizzling.
        /// </summary>
        public cvec3 xzz => new cvec3(x, z, z);
        
        /// <summary>
        /// Returns cvec3.rbb swizzling (equivalent to cvec3.xzz).
        /// </summary>
        public cvec3 rbb => new cvec3(x, z, z);
        
        /// <summary>
        /// Returns cvec3.xzzx swizzling.
        /// </summary>
        public cvec4 xzzx => new cvec4(x, z, z, x);
        
        /// <summary>
        /// Returns cvec3.rbbr swizzling (equivalent to cvec3.xzzx).
        /// </summary>
        public cvec4 rbbr => new cvec4(x, z, z, x);
        
        /// <summary>
        /// Returns cvec3.xzzxx swizzling.
        /// </summary>
        public cvec5 xzzxx => new cvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns cvec3.rbbrr swizzling (equivalent to cvec3.xzzxx).
        /// </summary>
        public cvec5 rbbrr => new cvec5(x, z, z, x, x);
        
        /// <summary>
        /// Returns cvec3.xzzxy swizzling.
        /// </summary>
        public cvec5 xzzxy => new cvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns cvec3.rbbrg swizzling (equivalent to cvec3.xzzxy).
        /// </summary>
        public cvec5 rbbrg => new cvec5(x, z, z, x, y);
        
        /// <summary>
        /// Returns cvec3.xzzxz swizzling.
        /// </summary>
        public cvec5 xzzxz => new cvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns cvec3.rbbrb swizzling (equivalent to cvec3.xzzxz).
        /// </summary>
        public cvec5 rbbrb => new cvec5(x, z, z, x, z);
        
        /// <summary>
        /// Returns cvec3.xzzy swizzling.
        /// </summary>
        public cvec4 xzzy => new cvec4(x, z, z, y);
        
        /// <summary>
        /// Returns cvec3.rbbg swizzling (equivalent to cvec3.xzzy).
        /// </summary>
        public cvec4 rbbg => new cvec4(x, z, z, y);
        
        /// <summary>
        /// Returns cvec3.xzzyx swizzling.
        /// </summary>
        public cvec5 xzzyx => new cvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns cvec3.rbbgr swizzling (equivalent to cvec3.xzzyx).
        /// </summary>
        public cvec5 rbbgr => new cvec5(x, z, z, y, x);
        
        /// <summary>
        /// Returns cvec3.xzzyy swizzling.
        /// </summary>
        public cvec5 xzzyy => new cvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns cvec3.rbbgg swizzling (equivalent to cvec3.xzzyy).
        /// </summary>
        public cvec5 rbbgg => new cvec5(x, z, z, y, y);
        
        /// <summary>
        /// Returns cvec3.xzzyz swizzling.
        /// </summary>
        public cvec5 xzzyz => new cvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns cvec3.rbbgb swizzling (equivalent to cvec3.xzzyz).
        /// </summary>
        public cvec5 rbbgb => new cvec5(x, z, z, y, z);
        
        /// <summary>
        /// Returns cvec3.xzzz swizzling.
        /// </summary>
        public cvec4 xzzz => new cvec4(x, z, z, z);
        
        /// <summary>
        /// Returns cvec3.rbbb swizzling (equivalent to cvec3.xzzz).
        /// </summary>
        public cvec4 rbbb => new cvec4(x, z, z, z);
        
        /// <summary>
        /// Returns cvec3.xzzzx swizzling.
        /// </summary>
        public cvec5 xzzzx => new cvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns cvec3.rbbbr swizzling (equivalent to cvec3.xzzzx).
        /// </summary>
        public cvec5 rbbbr => new cvec5(x, z, z, z, x);
        
        /// <summary>
        /// Returns cvec3.xzzzy swizzling.
        /// </summary>
        public cvec5 xzzzy => new cvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns cvec3.rbbbg swizzling (equivalent to cvec3.xzzzy).
        /// </summary>
        public cvec5 rbbbg => new cvec5(x, z, z, z, y);
        
        /// <summary>
        /// Returns cvec3.xzzzz swizzling.
        /// </summary>
        public cvec5 xzzzz => new cvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns cvec3.rbbbb swizzling (equivalent to cvec3.xzzzz).
        /// </summary>
        public cvec5 rbbbb => new cvec5(x, z, z, z, z);
        
        /// <summary>
        /// Returns cvec3.yx swizzling.
        /// </summary>
        public cvec2 yx => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec3.gr swizzling (equivalent to cvec3.yx).
        /// </summary>
        public cvec2 gr => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec3.yxx swizzling.
        /// </summary>
        public cvec3 yxx => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec3.grr swizzling (equivalent to cvec3.yxx).
        /// </summary>
        public cvec3 grr => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec3.yxxx swizzling.
        /// </summary>
        public cvec4 yxxx => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec3.grrr swizzling (equivalent to cvec3.yxxx).
        /// </summary>
        public cvec4 grrr => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec3.yxxxx swizzling.
        /// </summary>
        public cvec5 yxxxx => new cvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns cvec3.grrrr swizzling (equivalent to cvec3.yxxxx).
        /// </summary>
        public cvec5 grrrr => new cvec5(y, x, x, x, x);
        
        /// <summary>
        /// Returns cvec3.yxxxy swizzling.
        /// </summary>
        public cvec5 yxxxy => new cvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns cvec3.grrrg swizzling (equivalent to cvec3.yxxxy).
        /// </summary>
        public cvec5 grrrg => new cvec5(y, x, x, x, y);
        
        /// <summary>
        /// Returns cvec3.yxxxz swizzling.
        /// </summary>
        public cvec5 yxxxz => new cvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns cvec3.grrrb swizzling (equivalent to cvec3.yxxxz).
        /// </summary>
        public cvec5 grrrb => new cvec5(y, x, x, x, z);
        
        /// <summary>
        /// Returns cvec3.yxxy swizzling.
        /// </summary>
        public cvec4 yxxy => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec3.grrg swizzling (equivalent to cvec3.yxxy).
        /// </summary>
        public cvec4 grrg => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec3.yxxyx swizzling.
        /// </summary>
        public cvec5 yxxyx => new cvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns cvec3.grrgr swizzling (equivalent to cvec3.yxxyx).
        /// </summary>
        public cvec5 grrgr => new cvec5(y, x, x, y, x);
        
        /// <summary>
        /// Returns cvec3.yxxyy swizzling.
        /// </summary>
        public cvec5 yxxyy => new cvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns cvec3.grrgg swizzling (equivalent to cvec3.yxxyy).
        /// </summary>
        public cvec5 grrgg => new cvec5(y, x, x, y, y);
        
        /// <summary>
        /// Returns cvec3.yxxyz swizzling.
        /// </summary>
        public cvec5 yxxyz => new cvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns cvec3.grrgb swizzling (equivalent to cvec3.yxxyz).
        /// </summary>
        public cvec5 grrgb => new cvec5(y, x, x, y, z);
        
        /// <summary>
        /// Returns cvec3.yxxz swizzling.
        /// </summary>
        public cvec4 yxxz => new cvec4(y, x, x, z);
        
        /// <summary>
        /// Returns cvec3.grrb swizzling (equivalent to cvec3.yxxz).
        /// </summary>
        public cvec4 grrb => new cvec4(y, x, x, z);
        
        /// <summary>
        /// Returns cvec3.yxxzx swizzling.
        /// </summary>
        public cvec5 yxxzx => new cvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns cvec3.grrbr swizzling (equivalent to cvec3.yxxzx).
        /// </summary>
        public cvec5 grrbr => new cvec5(y, x, x, z, x);
        
        /// <summary>
        /// Returns cvec3.yxxzy swizzling.
        /// </summary>
        public cvec5 yxxzy => new cvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns cvec3.grrbg swizzling (equivalent to cvec3.yxxzy).
        /// </summary>
        public cvec5 grrbg => new cvec5(y, x, x, z, y);
        
        /// <summary>
        /// Returns cvec3.yxxzz swizzling.
        /// </summary>
        public cvec5 yxxzz => new cvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns cvec3.grrbb swizzling (equivalent to cvec3.yxxzz).
        /// </summary>
        public cvec5 grrbb => new cvec5(y, x, x, z, z);
        
        /// <summary>
        /// Returns cvec3.yxy swizzling.
        /// </summary>
        public cvec3 yxy => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec3.grg swizzling (equivalent to cvec3.yxy).
        /// </summary>
        public cvec3 grg => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec3.yxyx swizzling.
        /// </summary>
        public cvec4 yxyx => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec3.grgr swizzling (equivalent to cvec3.yxyx).
        /// </summary>
        public cvec4 grgr => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec3.yxyxx swizzling.
        /// </summary>
        public cvec5 yxyxx => new cvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns cvec3.grgrr swizzling (equivalent to cvec3.yxyxx).
        /// </summary>
        public cvec5 grgrr => new cvec5(y, x, y, x, x);
        
        /// <summary>
        /// Returns cvec3.yxyxy swizzling.
        /// </summary>
        public cvec5 yxyxy => new cvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns cvec3.grgrg swizzling (equivalent to cvec3.yxyxy).
        /// </summary>
        public cvec5 grgrg => new cvec5(y, x, y, x, y);
        
        /// <summary>
        /// Returns cvec3.yxyxz swizzling.
        /// </summary>
        public cvec5 yxyxz => new cvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns cvec3.grgrb swizzling (equivalent to cvec3.yxyxz).
        /// </summary>
        public cvec5 grgrb => new cvec5(y, x, y, x, z);
        
        /// <summary>
        /// Returns cvec3.yxyy swizzling.
        /// </summary>
        public cvec4 yxyy => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec3.grgg swizzling (equivalent to cvec3.yxyy).
        /// </summary>
        public cvec4 grgg => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec3.yxyyx swizzling.
        /// </summary>
        public cvec5 yxyyx => new cvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns cvec3.grggr swizzling (equivalent to cvec3.yxyyx).
        /// </summary>
        public cvec5 grggr => new cvec5(y, x, y, y, x);
        
        /// <summary>
        /// Returns cvec3.yxyyy swizzling.
        /// </summary>
        public cvec5 yxyyy => new cvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns cvec3.grggg swizzling (equivalent to cvec3.yxyyy).
        /// </summary>
        public cvec5 grggg => new cvec5(y, x, y, y, y);
        
        /// <summary>
        /// Returns cvec3.yxyyz swizzling.
        /// </summary>
        public cvec5 yxyyz => new cvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns cvec3.grggb swizzling (equivalent to cvec3.yxyyz).
        /// </summary>
        public cvec5 grggb => new cvec5(y, x, y, y, z);
        
        /// <summary>
        /// Returns cvec3.yxyz swizzling.
        /// </summary>
        public cvec4 yxyz => new cvec4(y, x, y, z);
        
        /// <summary>
        /// Returns cvec3.grgb swizzling (equivalent to cvec3.yxyz).
        /// </summary>
        public cvec4 grgb => new cvec4(y, x, y, z);
        
        /// <summary>
        /// Returns cvec3.yxyzx swizzling.
        /// </summary>
        public cvec5 yxyzx => new cvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns cvec3.grgbr swizzling (equivalent to cvec3.yxyzx).
        /// </summary>
        public cvec5 grgbr => new cvec5(y, x, y, z, x);
        
        /// <summary>
        /// Returns cvec3.yxyzy swizzling.
        /// </summary>
        public cvec5 yxyzy => new cvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns cvec3.grgbg swizzling (equivalent to cvec3.yxyzy).
        /// </summary>
        public cvec5 grgbg => new cvec5(y, x, y, z, y);
        
        /// <summary>
        /// Returns cvec3.yxyzz swizzling.
        /// </summary>
        public cvec5 yxyzz => new cvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns cvec3.grgbb swizzling (equivalent to cvec3.yxyzz).
        /// </summary>
        public cvec5 grgbb => new cvec5(y, x, y, z, z);
        
        /// <summary>
        /// Returns cvec3.yxz swizzling.
        /// </summary>
        public cvec3 yxz => new cvec3(y, x, z);
        
        /// <summary>
        /// Returns cvec3.grb swizzling (equivalent to cvec3.yxz).
        /// </summary>
        public cvec3 grb => new cvec3(y, x, z);
        
        /// <summary>
        /// Returns cvec3.yxzx swizzling.
        /// </summary>
        public cvec4 yxzx => new cvec4(y, x, z, x);
        
        /// <summary>
        /// Returns cvec3.grbr swizzling (equivalent to cvec3.yxzx).
        /// </summary>
        public cvec4 grbr => new cvec4(y, x, z, x);
        
        /// <summary>
        /// Returns cvec3.yxzxx swizzling.
        /// </summary>
        public cvec5 yxzxx => new cvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns cvec3.grbrr swizzling (equivalent to cvec3.yxzxx).
        /// </summary>
        public cvec5 grbrr => new cvec5(y, x, z, x, x);
        
        /// <summary>
        /// Returns cvec3.yxzxy swizzling.
        /// </summary>
        public cvec5 yxzxy => new cvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns cvec3.grbrg swizzling (equivalent to cvec3.yxzxy).
        /// </summary>
        public cvec5 grbrg => new cvec5(y, x, z, x, y);
        
        /// <summary>
        /// Returns cvec3.yxzxz swizzling.
        /// </summary>
        public cvec5 yxzxz => new cvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns cvec3.grbrb swizzling (equivalent to cvec3.yxzxz).
        /// </summary>
        public cvec5 grbrb => new cvec5(y, x, z, x, z);
        
        /// <summary>
        /// Returns cvec3.yxzy swizzling.
        /// </summary>
        public cvec4 yxzy => new cvec4(y, x, z, y);
        
        /// <summary>
        /// Returns cvec3.grbg swizzling (equivalent to cvec3.yxzy).
        /// </summary>
        public cvec4 grbg => new cvec4(y, x, z, y);
        
        /// <summary>
        /// Returns cvec3.yxzyx swizzling.
        /// </summary>
        public cvec5 yxzyx => new cvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns cvec3.grbgr swizzling (equivalent to cvec3.yxzyx).
        /// </summary>
        public cvec5 grbgr => new cvec5(y, x, z, y, x);
        
        /// <summary>
        /// Returns cvec3.yxzyy swizzling.
        /// </summary>
        public cvec5 yxzyy => new cvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns cvec3.grbgg swizzling (equivalent to cvec3.yxzyy).
        /// </summary>
        public cvec5 grbgg => new cvec5(y, x, z, y, y);
        
        /// <summary>
        /// Returns cvec3.yxzyz swizzling.
        /// </summary>
        public cvec5 yxzyz => new cvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns cvec3.grbgb swizzling (equivalent to cvec3.yxzyz).
        /// </summary>
        public cvec5 grbgb => new cvec5(y, x, z, y, z);
        
        /// <summary>
        /// Returns cvec3.yxzz swizzling.
        /// </summary>
        public cvec4 yxzz => new cvec4(y, x, z, z);
        
        /// <summary>
        /// Returns cvec3.grbb swizzling (equivalent to cvec3.yxzz).
        /// </summary>
        public cvec4 grbb => new cvec4(y, x, z, z);
        
        /// <summary>
        /// Returns cvec3.yxzzx swizzling.
        /// </summary>
        public cvec5 yxzzx => new cvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns cvec3.grbbr swizzling (equivalent to cvec3.yxzzx).
        /// </summary>
        public cvec5 grbbr => new cvec5(y, x, z, z, x);
        
        /// <summary>
        /// Returns cvec3.yxzzy swizzling.
        /// </summary>
        public cvec5 yxzzy => new cvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns cvec3.grbbg swizzling (equivalent to cvec3.yxzzy).
        /// </summary>
        public cvec5 grbbg => new cvec5(y, x, z, z, y);
        
        /// <summary>
        /// Returns cvec3.yxzzz swizzling.
        /// </summary>
        public cvec5 yxzzz => new cvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns cvec3.grbbb swizzling (equivalent to cvec3.yxzzz).
        /// </summary>
        public cvec5 grbbb => new cvec5(y, x, z, z, z);
        
        /// <summary>
        /// Returns cvec3.yy swizzling.
        /// </summary>
        public cvec2 yy => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec3.gg swizzling (equivalent to cvec3.yy).
        /// </summary>
        public cvec2 gg => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec3.yyx swizzling.
        /// </summary>
        public cvec3 yyx => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec3.ggr swizzling (equivalent to cvec3.yyx).
        /// </summary>
        public cvec3 ggr => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec3.yyxx swizzling.
        /// </summary>
        public cvec4 yyxx => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec3.ggrr swizzling (equivalent to cvec3.yyxx).
        /// </summary>
        public cvec4 ggrr => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec3.yyxxx swizzling.
        /// </summary>
        public cvec5 yyxxx => new cvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns cvec3.ggrrr swizzling (equivalent to cvec3.yyxxx).
        /// </summary>
        public cvec5 ggrrr => new cvec5(y, y, x, x, x);
        
        /// <summary>
        /// Returns cvec3.yyxxy swizzling.
        /// </summary>
        public cvec5 yyxxy => new cvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns cvec3.ggrrg swizzling (equivalent to cvec3.yyxxy).
        /// </summary>
        public cvec5 ggrrg => new cvec5(y, y, x, x, y);
        
        /// <summary>
        /// Returns cvec3.yyxxz swizzling.
        /// </summary>
        public cvec5 yyxxz => new cvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns cvec3.ggrrb swizzling (equivalent to cvec3.yyxxz).
        /// </summary>
        public cvec5 ggrrb => new cvec5(y, y, x, x, z);
        
        /// <summary>
        /// Returns cvec3.yyxy swizzling.
        /// </summary>
        public cvec4 yyxy => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec3.ggrg swizzling (equivalent to cvec3.yyxy).
        /// </summary>
        public cvec4 ggrg => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec3.yyxyx swizzling.
        /// </summary>
        public cvec5 yyxyx => new cvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns cvec3.ggrgr swizzling (equivalent to cvec3.yyxyx).
        /// </summary>
        public cvec5 ggrgr => new cvec5(y, y, x, y, x);
        
        /// <summary>
        /// Returns cvec3.yyxyy swizzling.
        /// </summary>
        public cvec5 yyxyy => new cvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns cvec3.ggrgg swizzling (equivalent to cvec3.yyxyy).
        /// </summary>
        public cvec5 ggrgg => new cvec5(y, y, x, y, y);
        
        /// <summary>
        /// Returns cvec3.yyxyz swizzling.
        /// </summary>
        public cvec5 yyxyz => new cvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns cvec3.ggrgb swizzling (equivalent to cvec3.yyxyz).
        /// </summary>
        public cvec5 ggrgb => new cvec5(y, y, x, y, z);
        
        /// <summary>
        /// Returns cvec3.yyxz swizzling.
        /// </summary>
        public cvec4 yyxz => new cvec4(y, y, x, z);
        
        /// <summary>
        /// Returns cvec3.ggrb swizzling (equivalent to cvec3.yyxz).
        /// </summary>
        public cvec4 ggrb => new cvec4(y, y, x, z);
        
        /// <summary>
        /// Returns cvec3.yyxzx swizzling.
        /// </summary>
        public cvec5 yyxzx => new cvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns cvec3.ggrbr swizzling (equivalent to cvec3.yyxzx).
        /// </summary>
        public cvec5 ggrbr => new cvec5(y, y, x, z, x);
        
        /// <summary>
        /// Returns cvec3.yyxzy swizzling.
        /// </summary>
        public cvec5 yyxzy => new cvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns cvec3.ggrbg swizzling (equivalent to cvec3.yyxzy).
        /// </summary>
        public cvec5 ggrbg => new cvec5(y, y, x, z, y);
        
        /// <summary>
        /// Returns cvec3.yyxzz swizzling.
        /// </summary>
        public cvec5 yyxzz => new cvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns cvec3.ggrbb swizzling (equivalent to cvec3.yyxzz).
        /// </summary>
        public cvec5 ggrbb => new cvec5(y, y, x, z, z);
        
        /// <summary>
        /// Returns cvec3.yyy swizzling.
        /// </summary>
        public cvec3 yyy => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec3.ggg swizzling (equivalent to cvec3.yyy).
        /// </summary>
        public cvec3 ggg => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec3.yyyx swizzling.
        /// </summary>
        public cvec4 yyyx => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec3.gggr swizzling (equivalent to cvec3.yyyx).
        /// </summary>
        public cvec4 gggr => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec3.yyyxx swizzling.
        /// </summary>
        public cvec5 yyyxx => new cvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns cvec3.gggrr swizzling (equivalent to cvec3.yyyxx).
        /// </summary>
        public cvec5 gggrr => new cvec5(y, y, y, x, x);
        
        /// <summary>
        /// Returns cvec3.yyyxy swizzling.
        /// </summary>
        public cvec5 yyyxy => new cvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns cvec3.gggrg swizzling (equivalent to cvec3.yyyxy).
        /// </summary>
        public cvec5 gggrg => new cvec5(y, y, y, x, y);
        
        /// <summary>
        /// Returns cvec3.yyyxz swizzling.
        /// </summary>
        public cvec5 yyyxz => new cvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns cvec3.gggrb swizzling (equivalent to cvec3.yyyxz).
        /// </summary>
        public cvec5 gggrb => new cvec5(y, y, y, x, z);
        
        /// <summary>
        /// Returns cvec3.yyyy swizzling.
        /// </summary>
        public cvec4 yyyy => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec3.gggg swizzling (equivalent to cvec3.yyyy).
        /// </summary>
        public cvec4 gggg => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec3.yyyyx swizzling.
        /// </summary>
        public cvec5 yyyyx => new cvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns cvec3.ggggr swizzling (equivalent to cvec3.yyyyx).
        /// </summary>
        public cvec5 ggggr => new cvec5(y, y, y, y, x);
        
        /// <summary>
        /// Returns cvec3.yyyyy swizzling.
        /// </summary>
        public cvec5 yyyyy => new cvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns cvec3.ggggg swizzling (equivalent to cvec3.yyyyy).
        /// </summary>
        public cvec5 ggggg => new cvec5(y, y, y, y, y);
        
        /// <summary>
        /// Returns cvec3.yyyyz swizzling.
        /// </summary>
        public cvec5 yyyyz => new cvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns cvec3.ggggb swizzling (equivalent to cvec3.yyyyz).
        /// </summary>
        public cvec5 ggggb => new cvec5(y, y, y, y, z);
        
        /// <summary>
        /// Returns cvec3.yyyz swizzling.
        /// </summary>
        public cvec4 yyyz => new cvec4(y, y, y, z);
        
        /// <summary>
        /// Returns cvec3.gggb swizzling (equivalent to cvec3.yyyz).
        /// </summary>
        public cvec4 gggb => new cvec4(y, y, y, z);
        
        /// <summary>
        /// Returns cvec3.yyyzx swizzling.
        /// </summary>
        public cvec5 yyyzx => new cvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns cvec3.gggbr swizzling (equivalent to cvec3.yyyzx).
        /// </summary>
        public cvec5 gggbr => new cvec5(y, y, y, z, x);
        
        /// <summary>
        /// Returns cvec3.yyyzy swizzling.
        /// </summary>
        public cvec5 yyyzy => new cvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns cvec3.gggbg swizzling (equivalent to cvec3.yyyzy).
        /// </summary>
        public cvec5 gggbg => new cvec5(y, y, y, z, y);
        
        /// <summary>
        /// Returns cvec3.yyyzz swizzling.
        /// </summary>
        public cvec5 yyyzz => new cvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns cvec3.gggbb swizzling (equivalent to cvec3.yyyzz).
        /// </summary>
        public cvec5 gggbb => new cvec5(y, y, y, z, z);
        
        /// <summary>
        /// Returns cvec3.yyz swizzling.
        /// </summary>
        public cvec3 yyz => new cvec3(y, y, z);
        
        /// <summary>
        /// Returns cvec3.ggb swizzling (equivalent to cvec3.yyz).
        /// </summary>
        public cvec3 ggb => new cvec3(y, y, z);
        
        /// <summary>
        /// Returns cvec3.yyzx swizzling.
        /// </summary>
        public cvec4 yyzx => new cvec4(y, y, z, x);
        
        /// <summary>
        /// Returns cvec3.ggbr swizzling (equivalent to cvec3.yyzx).
        /// </summary>
        public cvec4 ggbr => new cvec4(y, y, z, x);
        
        /// <summary>
        /// Returns cvec3.yyzxx swizzling.
        /// </summary>
        public cvec5 yyzxx => new cvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns cvec3.ggbrr swizzling (equivalent to cvec3.yyzxx).
        /// </summary>
        public cvec5 ggbrr => new cvec5(y, y, z, x, x);
        
        /// <summary>
        /// Returns cvec3.yyzxy swizzling.
        /// </summary>
        public cvec5 yyzxy => new cvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns cvec3.ggbrg swizzling (equivalent to cvec3.yyzxy).
        /// </summary>
        public cvec5 ggbrg => new cvec5(y, y, z, x, y);
        
        /// <summary>
        /// Returns cvec3.yyzxz swizzling.
        /// </summary>
        public cvec5 yyzxz => new cvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns cvec3.ggbrb swizzling (equivalent to cvec3.yyzxz).
        /// </summary>
        public cvec5 ggbrb => new cvec5(y, y, z, x, z);
        
        /// <summary>
        /// Returns cvec3.yyzy swizzling.
        /// </summary>
        public cvec4 yyzy => new cvec4(y, y, z, y);
        
        /// <summary>
        /// Returns cvec3.ggbg swizzling (equivalent to cvec3.yyzy).
        /// </summary>
        public cvec4 ggbg => new cvec4(y, y, z, y);
        
        /// <summary>
        /// Returns cvec3.yyzyx swizzling.
        /// </summary>
        public cvec5 yyzyx => new cvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns cvec3.ggbgr swizzling (equivalent to cvec3.yyzyx).
        /// </summary>
        public cvec5 ggbgr => new cvec5(y, y, z, y, x);
        
        /// <summary>
        /// Returns cvec3.yyzyy swizzling.
        /// </summary>
        public cvec5 yyzyy => new cvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns cvec3.ggbgg swizzling (equivalent to cvec3.yyzyy).
        /// </summary>
        public cvec5 ggbgg => new cvec5(y, y, z, y, y);
        
        /// <summary>
        /// Returns cvec3.yyzyz swizzling.
        /// </summary>
        public cvec5 yyzyz => new cvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns cvec3.ggbgb swizzling (equivalent to cvec3.yyzyz).
        /// </summary>
        public cvec5 ggbgb => new cvec5(y, y, z, y, z);
        
        /// <summary>
        /// Returns cvec3.yyzz swizzling.
        /// </summary>
        public cvec4 yyzz => new cvec4(y, y, z, z);
        
        /// <summary>
        /// Returns cvec3.ggbb swizzling (equivalent to cvec3.yyzz).
        /// </summary>
        public cvec4 ggbb => new cvec4(y, y, z, z);
        
        /// <summary>
        /// Returns cvec3.yyzzx swizzling.
        /// </summary>
        public cvec5 yyzzx => new cvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns cvec3.ggbbr swizzling (equivalent to cvec3.yyzzx).
        /// </summary>
        public cvec5 ggbbr => new cvec5(y, y, z, z, x);
        
        /// <summary>
        /// Returns cvec3.yyzzy swizzling.
        /// </summary>
        public cvec5 yyzzy => new cvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns cvec3.ggbbg swizzling (equivalent to cvec3.yyzzy).
        /// </summary>
        public cvec5 ggbbg => new cvec5(y, y, z, z, y);
        
        /// <summary>
        /// Returns cvec3.yyzzz swizzling.
        /// </summary>
        public cvec5 yyzzz => new cvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns cvec3.ggbbb swizzling (equivalent to cvec3.yyzzz).
        /// </summary>
        public cvec5 ggbbb => new cvec5(y, y, z, z, z);
        
        /// <summary>
        /// Returns cvec3.yz swizzling.
        /// </summary>
        public cvec2 yz => new cvec2(y, z);
        
        /// <summary>
        /// Returns cvec3.gb swizzling (equivalent to cvec3.yz).
        /// </summary>
        public cvec2 gb => new cvec2(y, z);
        
        /// <summary>
        /// Returns cvec3.yzx swizzling.
        /// </summary>
        public cvec3 yzx => new cvec3(y, z, x);
        
        /// <summary>
        /// Returns cvec3.gbr swizzling (equivalent to cvec3.yzx).
        /// </summary>
        public cvec3 gbr => new cvec3(y, z, x);
        
        /// <summary>
        /// Returns cvec3.yzxx swizzling.
        /// </summary>
        public cvec4 yzxx => new cvec4(y, z, x, x);
        
        /// <summary>
        /// Returns cvec3.gbrr swizzling (equivalent to cvec3.yzxx).
        /// </summary>
        public cvec4 gbrr => new cvec4(y, z, x, x);
        
        /// <summary>
        /// Returns cvec3.yzxxx swizzling.
        /// </summary>
        public cvec5 yzxxx => new cvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns cvec3.gbrrr swizzling (equivalent to cvec3.yzxxx).
        /// </summary>
        public cvec5 gbrrr => new cvec5(y, z, x, x, x);
        
        /// <summary>
        /// Returns cvec3.yzxxy swizzling.
        /// </summary>
        public cvec5 yzxxy => new cvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns cvec3.gbrrg swizzling (equivalent to cvec3.yzxxy).
        /// </summary>
        public cvec5 gbrrg => new cvec5(y, z, x, x, y);
        
        /// <summary>
        /// Returns cvec3.yzxxz swizzling.
        /// </summary>
        public cvec5 yzxxz => new cvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns cvec3.gbrrb swizzling (equivalent to cvec3.yzxxz).
        /// </summary>
        public cvec5 gbrrb => new cvec5(y, z, x, x, z);
        
        /// <summary>
        /// Returns cvec3.yzxy swizzling.
        /// </summary>
        public cvec4 yzxy => new cvec4(y, z, x, y);
        
        /// <summary>
        /// Returns cvec3.gbrg swizzling (equivalent to cvec3.yzxy).
        /// </summary>
        public cvec4 gbrg => new cvec4(y, z, x, y);
        
        /// <summary>
        /// Returns cvec3.yzxyx swizzling.
        /// </summary>
        public cvec5 yzxyx => new cvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns cvec3.gbrgr swizzling (equivalent to cvec3.yzxyx).
        /// </summary>
        public cvec5 gbrgr => new cvec5(y, z, x, y, x);
        
        /// <summary>
        /// Returns cvec3.yzxyy swizzling.
        /// </summary>
        public cvec5 yzxyy => new cvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns cvec3.gbrgg swizzling (equivalent to cvec3.yzxyy).
        /// </summary>
        public cvec5 gbrgg => new cvec5(y, z, x, y, y);
        
        /// <summary>
        /// Returns cvec3.yzxyz swizzling.
        /// </summary>
        public cvec5 yzxyz => new cvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns cvec3.gbrgb swizzling (equivalent to cvec3.yzxyz).
        /// </summary>
        public cvec5 gbrgb => new cvec5(y, z, x, y, z);
        
        /// <summary>
        /// Returns cvec3.yzxz swizzling.
        /// </summary>
        public cvec4 yzxz => new cvec4(y, z, x, z);
        
        /// <summary>
        /// Returns cvec3.gbrb swizzling (equivalent to cvec3.yzxz).
        /// </summary>
        public cvec4 gbrb => new cvec4(y, z, x, z);
        
        /// <summary>
        /// Returns cvec3.yzxzx swizzling.
        /// </summary>
        public cvec5 yzxzx => new cvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns cvec3.gbrbr swizzling (equivalent to cvec3.yzxzx).
        /// </summary>
        public cvec5 gbrbr => new cvec5(y, z, x, z, x);
        
        /// <summary>
        /// Returns cvec3.yzxzy swizzling.
        /// </summary>
        public cvec5 yzxzy => new cvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns cvec3.gbrbg swizzling (equivalent to cvec3.yzxzy).
        /// </summary>
        public cvec5 gbrbg => new cvec5(y, z, x, z, y);
        
        /// <summary>
        /// Returns cvec3.yzxzz swizzling.
        /// </summary>
        public cvec5 yzxzz => new cvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns cvec3.gbrbb swizzling (equivalent to cvec3.yzxzz).
        /// </summary>
        public cvec5 gbrbb => new cvec5(y, z, x, z, z);
        
        /// <summary>
        /// Returns cvec3.yzy swizzling.
        /// </summary>
        public cvec3 yzy => new cvec3(y, z, y);
        
        /// <summary>
        /// Returns cvec3.gbg swizzling (equivalent to cvec3.yzy).
        /// </summary>
        public cvec3 gbg => new cvec3(y, z, y);
        
        /// <summary>
        /// Returns cvec3.yzyx swizzling.
        /// </summary>
        public cvec4 yzyx => new cvec4(y, z, y, x);
        
        /// <summary>
        /// Returns cvec3.gbgr swizzling (equivalent to cvec3.yzyx).
        /// </summary>
        public cvec4 gbgr => new cvec4(y, z, y, x);
        
        /// <summary>
        /// Returns cvec3.yzyxx swizzling.
        /// </summary>
        public cvec5 yzyxx => new cvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns cvec3.gbgrr swizzling (equivalent to cvec3.yzyxx).
        /// </summary>
        public cvec5 gbgrr => new cvec5(y, z, y, x, x);
        
        /// <summary>
        /// Returns cvec3.yzyxy swizzling.
        /// </summary>
        public cvec5 yzyxy => new cvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns cvec3.gbgrg swizzling (equivalent to cvec3.yzyxy).
        /// </summary>
        public cvec5 gbgrg => new cvec5(y, z, y, x, y);
        
        /// <summary>
        /// Returns cvec3.yzyxz swizzling.
        /// </summary>
        public cvec5 yzyxz => new cvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns cvec3.gbgrb swizzling (equivalent to cvec3.yzyxz).
        /// </summary>
        public cvec5 gbgrb => new cvec5(y, z, y, x, z);
        
        /// <summary>
        /// Returns cvec3.yzyy swizzling.
        /// </summary>
        public cvec4 yzyy => new cvec4(y, z, y, y);
        
        /// <summary>
        /// Returns cvec3.gbgg swizzling (equivalent to cvec3.yzyy).
        /// </summary>
        public cvec4 gbgg => new cvec4(y, z, y, y);
        
        /// <summary>
        /// Returns cvec3.yzyyx swizzling.
        /// </summary>
        public cvec5 yzyyx => new cvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns cvec3.gbggr swizzling (equivalent to cvec3.yzyyx).
        /// </summary>
        public cvec5 gbggr => new cvec5(y, z, y, y, x);
        
        /// <summary>
        /// Returns cvec3.yzyyy swizzling.
        /// </summary>
        public cvec5 yzyyy => new cvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns cvec3.gbggg swizzling (equivalent to cvec3.yzyyy).
        /// </summary>
        public cvec5 gbggg => new cvec5(y, z, y, y, y);
        
        /// <summary>
        /// Returns cvec3.yzyyz swizzling.
        /// </summary>
        public cvec5 yzyyz => new cvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns cvec3.gbggb swizzling (equivalent to cvec3.yzyyz).
        /// </summary>
        public cvec5 gbggb => new cvec5(y, z, y, y, z);
        
        /// <summary>
        /// Returns cvec3.yzyz swizzling.
        /// </summary>
        public cvec4 yzyz => new cvec4(y, z, y, z);
        
        /// <summary>
        /// Returns cvec3.gbgb swizzling (equivalent to cvec3.yzyz).
        /// </summary>
        public cvec4 gbgb => new cvec4(y, z, y, z);
        
        /// <summary>
        /// Returns cvec3.yzyzx swizzling.
        /// </summary>
        public cvec5 yzyzx => new cvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns cvec3.gbgbr swizzling (equivalent to cvec3.yzyzx).
        /// </summary>
        public cvec5 gbgbr => new cvec5(y, z, y, z, x);
        
        /// <summary>
        /// Returns cvec3.yzyzy swizzling.
        /// </summary>
        public cvec5 yzyzy => new cvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns cvec3.gbgbg swizzling (equivalent to cvec3.yzyzy).
        /// </summary>
        public cvec5 gbgbg => new cvec5(y, z, y, z, y);
        
        /// <summary>
        /// Returns cvec3.yzyzz swizzling.
        /// </summary>
        public cvec5 yzyzz => new cvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns cvec3.gbgbb swizzling (equivalent to cvec3.yzyzz).
        /// </summary>
        public cvec5 gbgbb => new cvec5(y, z, y, z, z);
        
        /// <summary>
        /// Returns cvec3.yzz swizzling.
        /// </summary>
        public cvec3 yzz => new cvec3(y, z, z);
        
        /// <summary>
        /// Returns cvec3.gbb swizzling (equivalent to cvec3.yzz).
        /// </summary>
        public cvec3 gbb => new cvec3(y, z, z);
        
        /// <summary>
        /// Returns cvec3.yzzx swizzling.
        /// </summary>
        public cvec4 yzzx => new cvec4(y, z, z, x);
        
        /// <summary>
        /// Returns cvec3.gbbr swizzling (equivalent to cvec3.yzzx).
        /// </summary>
        public cvec4 gbbr => new cvec4(y, z, z, x);
        
        /// <summary>
        /// Returns cvec3.yzzxx swizzling.
        /// </summary>
        public cvec5 yzzxx => new cvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns cvec3.gbbrr swizzling (equivalent to cvec3.yzzxx).
        /// </summary>
        public cvec5 gbbrr => new cvec5(y, z, z, x, x);
        
        /// <summary>
        /// Returns cvec3.yzzxy swizzling.
        /// </summary>
        public cvec5 yzzxy => new cvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns cvec3.gbbrg swizzling (equivalent to cvec3.yzzxy).
        /// </summary>
        public cvec5 gbbrg => new cvec5(y, z, z, x, y);
        
        /// <summary>
        /// Returns cvec3.yzzxz swizzling.
        /// </summary>
        public cvec5 yzzxz => new cvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns cvec3.gbbrb swizzling (equivalent to cvec3.yzzxz).
        /// </summary>
        public cvec5 gbbrb => new cvec5(y, z, z, x, z);
        
        /// <summary>
        /// Returns cvec3.yzzy swizzling.
        /// </summary>
        public cvec4 yzzy => new cvec4(y, z, z, y);
        
        /// <summary>
        /// Returns cvec3.gbbg swizzling (equivalent to cvec3.yzzy).
        /// </summary>
        public cvec4 gbbg => new cvec4(y, z, z, y);
        
        /// <summary>
        /// Returns cvec3.yzzyx swizzling.
        /// </summary>
        public cvec5 yzzyx => new cvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns cvec3.gbbgr swizzling (equivalent to cvec3.yzzyx).
        /// </summary>
        public cvec5 gbbgr => new cvec5(y, z, z, y, x);
        
        /// <summary>
        /// Returns cvec3.yzzyy swizzling.
        /// </summary>
        public cvec5 yzzyy => new cvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns cvec3.gbbgg swizzling (equivalent to cvec3.yzzyy).
        /// </summary>
        public cvec5 gbbgg => new cvec5(y, z, z, y, y);
        
        /// <summary>
        /// Returns cvec3.yzzyz swizzling.
        /// </summary>
        public cvec5 yzzyz => new cvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns cvec3.gbbgb swizzling (equivalent to cvec3.yzzyz).
        /// </summary>
        public cvec5 gbbgb => new cvec5(y, z, z, y, z);
        
        /// <summary>
        /// Returns cvec3.yzzz swizzling.
        /// </summary>
        public cvec4 yzzz => new cvec4(y, z, z, z);
        
        /// <summary>
        /// Returns cvec3.gbbb swizzling (equivalent to cvec3.yzzz).
        /// </summary>
        public cvec4 gbbb => new cvec4(y, z, z, z);
        
        /// <summary>
        /// Returns cvec3.yzzzx swizzling.
        /// </summary>
        public cvec5 yzzzx => new cvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns cvec3.gbbbr swizzling (equivalent to cvec3.yzzzx).
        /// </summary>
        public cvec5 gbbbr => new cvec5(y, z, z, z, x);
        
        /// <summary>
        /// Returns cvec3.yzzzy swizzling.
        /// </summary>
        public cvec5 yzzzy => new cvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns cvec3.gbbbg swizzling (equivalent to cvec3.yzzzy).
        /// </summary>
        public cvec5 gbbbg => new cvec5(y, z, z, z, y);
        
        /// <summary>
        /// Returns cvec3.yzzzz swizzling.
        /// </summary>
        public cvec5 yzzzz => new cvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns cvec3.gbbbb swizzling (equivalent to cvec3.yzzzz).
        /// </summary>
        public cvec5 gbbbb => new cvec5(y, z, z, z, z);
        
        /// <summary>
        /// Returns cvec3.zx swizzling.
        /// </summary>
        public cvec2 zx => new cvec2(z, x);
        
        /// <summary>
        /// Returns cvec3.br swizzling (equivalent to cvec3.zx).
        /// </summary>
        public cvec2 br => new cvec2(z, x);
        
        /// <summary>
        /// Returns cvec3.zxx swizzling.
        /// </summary>
        public cvec3 zxx => new cvec3(z, x, x);
        
        /// <summary>
        /// Returns cvec3.brr swizzling (equivalent to cvec3.zxx).
        /// </summary>
        public cvec3 brr => new cvec3(z, x, x);
        
        /// <summary>
        /// Returns cvec3.zxxx swizzling.
        /// </summary>
        public cvec4 zxxx => new cvec4(z, x, x, x);
        
        /// <summary>
        /// Returns cvec3.brrr swizzling (equivalent to cvec3.zxxx).
        /// </summary>
        public cvec4 brrr => new cvec4(z, x, x, x);
        
        /// <summary>
        /// Returns cvec3.zxxxx swizzling.
        /// </summary>
        public cvec5 zxxxx => new cvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns cvec3.brrrr swizzling (equivalent to cvec3.zxxxx).
        /// </summary>
        public cvec5 brrrr => new cvec5(z, x, x, x, x);
        
        /// <summary>
        /// Returns cvec3.zxxxy swizzling.
        /// </summary>
        public cvec5 zxxxy => new cvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns cvec3.brrrg swizzling (equivalent to cvec3.zxxxy).
        /// </summary>
        public cvec5 brrrg => new cvec5(z, x, x, x, y);
        
        /// <summary>
        /// Returns cvec3.zxxxz swizzling.
        /// </summary>
        public cvec5 zxxxz => new cvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns cvec3.brrrb swizzling (equivalent to cvec3.zxxxz).
        /// </summary>
        public cvec5 brrrb => new cvec5(z, x, x, x, z);
        
        /// <summary>
        /// Returns cvec3.zxxy swizzling.
        /// </summary>
        public cvec4 zxxy => new cvec4(z, x, x, y);
        
        /// <summary>
        /// Returns cvec3.brrg swizzling (equivalent to cvec3.zxxy).
        /// </summary>
        public cvec4 brrg => new cvec4(z, x, x, y);
        
        /// <summary>
        /// Returns cvec3.zxxyx swizzling.
        /// </summary>
        public cvec5 zxxyx => new cvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns cvec3.brrgr swizzling (equivalent to cvec3.zxxyx).
        /// </summary>
        public cvec5 brrgr => new cvec5(z, x, x, y, x);
        
        /// <summary>
        /// Returns cvec3.zxxyy swizzling.
        /// </summary>
        public cvec5 zxxyy => new cvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns cvec3.brrgg swizzling (equivalent to cvec3.zxxyy).
        /// </summary>
        public cvec5 brrgg => new cvec5(z, x, x, y, y);
        
        /// <summary>
        /// Returns cvec3.zxxyz swizzling.
        /// </summary>
        public cvec5 zxxyz => new cvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns cvec3.brrgb swizzling (equivalent to cvec3.zxxyz).
        /// </summary>
        public cvec5 brrgb => new cvec5(z, x, x, y, z);
        
        /// <summary>
        /// Returns cvec3.zxxz swizzling.
        /// </summary>
        public cvec4 zxxz => new cvec4(z, x, x, z);
        
        /// <summary>
        /// Returns cvec3.brrb swizzling (equivalent to cvec3.zxxz).
        /// </summary>
        public cvec4 brrb => new cvec4(z, x, x, z);
        
        /// <summary>
        /// Returns cvec3.zxxzx swizzling.
        /// </summary>
        public cvec5 zxxzx => new cvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns cvec3.brrbr swizzling (equivalent to cvec3.zxxzx).
        /// </summary>
        public cvec5 brrbr => new cvec5(z, x, x, z, x);
        
        /// <summary>
        /// Returns cvec3.zxxzy swizzling.
        /// </summary>
        public cvec5 zxxzy => new cvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns cvec3.brrbg swizzling (equivalent to cvec3.zxxzy).
        /// </summary>
        public cvec5 brrbg => new cvec5(z, x, x, z, y);
        
        /// <summary>
        /// Returns cvec3.zxxzz swizzling.
        /// </summary>
        public cvec5 zxxzz => new cvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns cvec3.brrbb swizzling (equivalent to cvec3.zxxzz).
        /// </summary>
        public cvec5 brrbb => new cvec5(z, x, x, z, z);
        
        /// <summary>
        /// Returns cvec3.zxy swizzling.
        /// </summary>
        public cvec3 zxy => new cvec3(z, x, y);
        
        /// <summary>
        /// Returns cvec3.brg swizzling (equivalent to cvec3.zxy).
        /// </summary>
        public cvec3 brg => new cvec3(z, x, y);
        
        /// <summary>
        /// Returns cvec3.zxyx swizzling.
        /// </summary>
        public cvec4 zxyx => new cvec4(z, x, y, x);
        
        /// <summary>
        /// Returns cvec3.brgr swizzling (equivalent to cvec3.zxyx).
        /// </summary>
        public cvec4 brgr => new cvec4(z, x, y, x);
        
        /// <summary>
        /// Returns cvec3.zxyxx swizzling.
        /// </summary>
        public cvec5 zxyxx => new cvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns cvec3.brgrr swizzling (equivalent to cvec3.zxyxx).
        /// </summary>
        public cvec5 brgrr => new cvec5(z, x, y, x, x);
        
        /// <summary>
        /// Returns cvec3.zxyxy swizzling.
        /// </summary>
        public cvec5 zxyxy => new cvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns cvec3.brgrg swizzling (equivalent to cvec3.zxyxy).
        /// </summary>
        public cvec5 brgrg => new cvec5(z, x, y, x, y);
        
        /// <summary>
        /// Returns cvec3.zxyxz swizzling.
        /// </summary>
        public cvec5 zxyxz => new cvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns cvec3.brgrb swizzling (equivalent to cvec3.zxyxz).
        /// </summary>
        public cvec5 brgrb => new cvec5(z, x, y, x, z);
        
        /// <summary>
        /// Returns cvec3.zxyy swizzling.
        /// </summary>
        public cvec4 zxyy => new cvec4(z, x, y, y);
        
        /// <summary>
        /// Returns cvec3.brgg swizzling (equivalent to cvec3.zxyy).
        /// </summary>
        public cvec4 brgg => new cvec4(z, x, y, y);
        
        /// <summary>
        /// Returns cvec3.zxyyx swizzling.
        /// </summary>
        public cvec5 zxyyx => new cvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns cvec3.brggr swizzling (equivalent to cvec3.zxyyx).
        /// </summary>
        public cvec5 brggr => new cvec5(z, x, y, y, x);
        
        /// <summary>
        /// Returns cvec3.zxyyy swizzling.
        /// </summary>
        public cvec5 zxyyy => new cvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns cvec3.brggg swizzling (equivalent to cvec3.zxyyy).
        /// </summary>
        public cvec5 brggg => new cvec5(z, x, y, y, y);
        
        /// <summary>
        /// Returns cvec3.zxyyz swizzling.
        /// </summary>
        public cvec5 zxyyz => new cvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns cvec3.brggb swizzling (equivalent to cvec3.zxyyz).
        /// </summary>
        public cvec5 brggb => new cvec5(z, x, y, y, z);
        
        /// <summary>
        /// Returns cvec3.zxyz swizzling.
        /// </summary>
        public cvec4 zxyz => new cvec4(z, x, y, z);
        
        /// <summary>
        /// Returns cvec3.brgb swizzling (equivalent to cvec3.zxyz).
        /// </summary>
        public cvec4 brgb => new cvec4(z, x, y, z);
        
        /// <summary>
        /// Returns cvec3.zxyzx swizzling.
        /// </summary>
        public cvec5 zxyzx => new cvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns cvec3.brgbr swizzling (equivalent to cvec3.zxyzx).
        /// </summary>
        public cvec5 brgbr => new cvec5(z, x, y, z, x);
        
        /// <summary>
        /// Returns cvec3.zxyzy swizzling.
        /// </summary>
        public cvec5 zxyzy => new cvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns cvec3.brgbg swizzling (equivalent to cvec3.zxyzy).
        /// </summary>
        public cvec5 brgbg => new cvec5(z, x, y, z, y);
        
        /// <summary>
        /// Returns cvec3.zxyzz swizzling.
        /// </summary>
        public cvec5 zxyzz => new cvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns cvec3.brgbb swizzling (equivalent to cvec3.zxyzz).
        /// </summary>
        public cvec5 brgbb => new cvec5(z, x, y, z, z);
        
        /// <summary>
        /// Returns cvec3.zxz swizzling.
        /// </summary>
        public cvec3 zxz => new cvec3(z, x, z);
        
        /// <summary>
        /// Returns cvec3.brb swizzling (equivalent to cvec3.zxz).
        /// </summary>
        public cvec3 brb => new cvec3(z, x, z);
        
        /// <summary>
        /// Returns cvec3.zxzx swizzling.
        /// </summary>
        public cvec4 zxzx => new cvec4(z, x, z, x);
        
        /// <summary>
        /// Returns cvec3.brbr swizzling (equivalent to cvec3.zxzx).
        /// </summary>
        public cvec4 brbr => new cvec4(z, x, z, x);
        
        /// <summary>
        /// Returns cvec3.zxzxx swizzling.
        /// </summary>
        public cvec5 zxzxx => new cvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns cvec3.brbrr swizzling (equivalent to cvec3.zxzxx).
        /// </summary>
        public cvec5 brbrr => new cvec5(z, x, z, x, x);
        
        /// <summary>
        /// Returns cvec3.zxzxy swizzling.
        /// </summary>
        public cvec5 zxzxy => new cvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns cvec3.brbrg swizzling (equivalent to cvec3.zxzxy).
        /// </summary>
        public cvec5 brbrg => new cvec5(z, x, z, x, y);
        
        /// <summary>
        /// Returns cvec3.zxzxz swizzling.
        /// </summary>
        public cvec5 zxzxz => new cvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns cvec3.brbrb swizzling (equivalent to cvec3.zxzxz).
        /// </summary>
        public cvec5 brbrb => new cvec5(z, x, z, x, z);
        
        /// <summary>
        /// Returns cvec3.zxzy swizzling.
        /// </summary>
        public cvec4 zxzy => new cvec4(z, x, z, y);
        
        /// <summary>
        /// Returns cvec3.brbg swizzling (equivalent to cvec3.zxzy).
        /// </summary>
        public cvec4 brbg => new cvec4(z, x, z, y);
        
        /// <summary>
        /// Returns cvec3.zxzyx swizzling.
        /// </summary>
        public cvec5 zxzyx => new cvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns cvec3.brbgr swizzling (equivalent to cvec3.zxzyx).
        /// </summary>
        public cvec5 brbgr => new cvec5(z, x, z, y, x);
        
        /// <summary>
        /// Returns cvec3.zxzyy swizzling.
        /// </summary>
        public cvec5 zxzyy => new cvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns cvec3.brbgg swizzling (equivalent to cvec3.zxzyy).
        /// </summary>
        public cvec5 brbgg => new cvec5(z, x, z, y, y);
        
        /// <summary>
        /// Returns cvec3.zxzyz swizzling.
        /// </summary>
        public cvec5 zxzyz => new cvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns cvec3.brbgb swizzling (equivalent to cvec3.zxzyz).
        /// </summary>
        public cvec5 brbgb => new cvec5(z, x, z, y, z);
        
        /// <summary>
        /// Returns cvec3.zxzz swizzling.
        /// </summary>
        public cvec4 zxzz => new cvec4(z, x, z, z);
        
        /// <summary>
        /// Returns cvec3.brbb swizzling (equivalent to cvec3.zxzz).
        /// </summary>
        public cvec4 brbb => new cvec4(z, x, z, z);
        
        /// <summary>
        /// Returns cvec3.zxzzx swizzling.
        /// </summary>
        public cvec5 zxzzx => new cvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns cvec3.brbbr swizzling (equivalent to cvec3.zxzzx).
        /// </summary>
        public cvec5 brbbr => new cvec5(z, x, z, z, x);
        
        /// <summary>
        /// Returns cvec3.zxzzy swizzling.
        /// </summary>
        public cvec5 zxzzy => new cvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns cvec3.brbbg swizzling (equivalent to cvec3.zxzzy).
        /// </summary>
        public cvec5 brbbg => new cvec5(z, x, z, z, y);
        
        /// <summary>
        /// Returns cvec3.zxzzz swizzling.
        /// </summary>
        public cvec5 zxzzz => new cvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns cvec3.brbbb swizzling (equivalent to cvec3.zxzzz).
        /// </summary>
        public cvec5 brbbb => new cvec5(z, x, z, z, z);
        
        /// <summary>
        /// Returns cvec3.zy swizzling.
        /// </summary>
        public cvec2 zy => new cvec2(z, y);
        
        /// <summary>
        /// Returns cvec3.bg swizzling (equivalent to cvec3.zy).
        /// </summary>
        public cvec2 bg => new cvec2(z, y);
        
        /// <summary>
        /// Returns cvec3.zyx swizzling.
        /// </summary>
        public cvec3 zyx => new cvec3(z, y, x);
        
        /// <summary>
        /// Returns cvec3.bgr swizzling (equivalent to cvec3.zyx).
        /// </summary>
        public cvec3 bgr => new cvec3(z, y, x);
        
        /// <summary>
        /// Returns cvec3.zyxx swizzling.
        /// </summary>
        public cvec4 zyxx => new cvec4(z, y, x, x);
        
        /// <summary>
        /// Returns cvec3.bgrr swizzling (equivalent to cvec3.zyxx).
        /// </summary>
        public cvec4 bgrr => new cvec4(z, y, x, x);
        
        /// <summary>
        /// Returns cvec3.zyxxx swizzling.
        /// </summary>
        public cvec5 zyxxx => new cvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns cvec3.bgrrr swizzling (equivalent to cvec3.zyxxx).
        /// </summary>
        public cvec5 bgrrr => new cvec5(z, y, x, x, x);
        
        /// <summary>
        /// Returns cvec3.zyxxy swizzling.
        /// </summary>
        public cvec5 zyxxy => new cvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns cvec3.bgrrg swizzling (equivalent to cvec3.zyxxy).
        /// </summary>
        public cvec5 bgrrg => new cvec5(z, y, x, x, y);
        
        /// <summary>
        /// Returns cvec3.zyxxz swizzling.
        /// </summary>
        public cvec5 zyxxz => new cvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns cvec3.bgrrb swizzling (equivalent to cvec3.zyxxz).
        /// </summary>
        public cvec5 bgrrb => new cvec5(z, y, x, x, z);
        
        /// <summary>
        /// Returns cvec3.zyxy swizzling.
        /// </summary>
        public cvec4 zyxy => new cvec4(z, y, x, y);
        
        /// <summary>
        /// Returns cvec3.bgrg swizzling (equivalent to cvec3.zyxy).
        /// </summary>
        public cvec4 bgrg => new cvec4(z, y, x, y);
        
        /// <summary>
        /// Returns cvec3.zyxyx swizzling.
        /// </summary>
        public cvec5 zyxyx => new cvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns cvec3.bgrgr swizzling (equivalent to cvec3.zyxyx).
        /// </summary>
        public cvec5 bgrgr => new cvec5(z, y, x, y, x);
        
        /// <summary>
        /// Returns cvec3.zyxyy swizzling.
        /// </summary>
        public cvec5 zyxyy => new cvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns cvec3.bgrgg swizzling (equivalent to cvec3.zyxyy).
        /// </summary>
        public cvec5 bgrgg => new cvec5(z, y, x, y, y);
        
        /// <summary>
        /// Returns cvec3.zyxyz swizzling.
        /// </summary>
        public cvec5 zyxyz => new cvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns cvec3.bgrgb swizzling (equivalent to cvec3.zyxyz).
        /// </summary>
        public cvec5 bgrgb => new cvec5(z, y, x, y, z);
        
        /// <summary>
        /// Returns cvec3.zyxz swizzling.
        /// </summary>
        public cvec4 zyxz => new cvec4(z, y, x, z);
        
        /// <summary>
        /// Returns cvec3.bgrb swizzling (equivalent to cvec3.zyxz).
        /// </summary>
        public cvec4 bgrb => new cvec4(z, y, x, z);
        
        /// <summary>
        /// Returns cvec3.zyxzx swizzling.
        /// </summary>
        public cvec5 zyxzx => new cvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns cvec3.bgrbr swizzling (equivalent to cvec3.zyxzx).
        /// </summary>
        public cvec5 bgrbr => new cvec5(z, y, x, z, x);
        
        /// <summary>
        /// Returns cvec3.zyxzy swizzling.
        /// </summary>
        public cvec5 zyxzy => new cvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns cvec3.bgrbg swizzling (equivalent to cvec3.zyxzy).
        /// </summary>
        public cvec5 bgrbg => new cvec5(z, y, x, z, y);
        
        /// <summary>
        /// Returns cvec3.zyxzz swizzling.
        /// </summary>
        public cvec5 zyxzz => new cvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns cvec3.bgrbb swizzling (equivalent to cvec3.zyxzz).
        /// </summary>
        public cvec5 bgrbb => new cvec5(z, y, x, z, z);
        
        /// <summary>
        /// Returns cvec3.zyy swizzling.
        /// </summary>
        public cvec3 zyy => new cvec3(z, y, y);
        
        /// <summary>
        /// Returns cvec3.bgg swizzling (equivalent to cvec3.zyy).
        /// </summary>
        public cvec3 bgg => new cvec3(z, y, y);
        
        /// <summary>
        /// Returns cvec3.zyyx swizzling.
        /// </summary>
        public cvec4 zyyx => new cvec4(z, y, y, x);
        
        /// <summary>
        /// Returns cvec3.bggr swizzling (equivalent to cvec3.zyyx).
        /// </summary>
        public cvec4 bggr => new cvec4(z, y, y, x);
        
        /// <summary>
        /// Returns cvec3.zyyxx swizzling.
        /// </summary>
        public cvec5 zyyxx => new cvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns cvec3.bggrr swizzling (equivalent to cvec3.zyyxx).
        /// </summary>
        public cvec5 bggrr => new cvec5(z, y, y, x, x);
        
        /// <summary>
        /// Returns cvec3.zyyxy swizzling.
        /// </summary>
        public cvec5 zyyxy => new cvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns cvec3.bggrg swizzling (equivalent to cvec3.zyyxy).
        /// </summary>
        public cvec5 bggrg => new cvec5(z, y, y, x, y);
        
        /// <summary>
        /// Returns cvec3.zyyxz swizzling.
        /// </summary>
        public cvec5 zyyxz => new cvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns cvec3.bggrb swizzling (equivalent to cvec3.zyyxz).
        /// </summary>
        public cvec5 bggrb => new cvec5(z, y, y, x, z);
        
        /// <summary>
        /// Returns cvec3.zyyy swizzling.
        /// </summary>
        public cvec4 zyyy => new cvec4(z, y, y, y);
        
        /// <summary>
        /// Returns cvec3.bggg swizzling (equivalent to cvec3.zyyy).
        /// </summary>
        public cvec4 bggg => new cvec4(z, y, y, y);
        
        /// <summary>
        /// Returns cvec3.zyyyx swizzling.
        /// </summary>
        public cvec5 zyyyx => new cvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns cvec3.bgggr swizzling (equivalent to cvec3.zyyyx).
        /// </summary>
        public cvec5 bgggr => new cvec5(z, y, y, y, x);
        
        /// <summary>
        /// Returns cvec3.zyyyy swizzling.
        /// </summary>
        public cvec5 zyyyy => new cvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns cvec3.bgggg swizzling (equivalent to cvec3.zyyyy).
        /// </summary>
        public cvec5 bgggg => new cvec5(z, y, y, y, y);
        
        /// <summary>
        /// Returns cvec3.zyyyz swizzling.
        /// </summary>
        public cvec5 zyyyz => new cvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns cvec3.bgggb swizzling (equivalent to cvec3.zyyyz).
        /// </summary>
        public cvec5 bgggb => new cvec5(z, y, y, y, z);
        
        /// <summary>
        /// Returns cvec3.zyyz swizzling.
        /// </summary>
        public cvec4 zyyz => new cvec4(z, y, y, z);
        
        /// <summary>
        /// Returns cvec3.bggb swizzling (equivalent to cvec3.zyyz).
        /// </summary>
        public cvec4 bggb => new cvec4(z, y, y, z);
        
        /// <summary>
        /// Returns cvec3.zyyzx swizzling.
        /// </summary>
        public cvec5 zyyzx => new cvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns cvec3.bggbr swizzling (equivalent to cvec3.zyyzx).
        /// </summary>
        public cvec5 bggbr => new cvec5(z, y, y, z, x);
        
        /// <summary>
        /// Returns cvec3.zyyzy swizzling.
        /// </summary>
        public cvec5 zyyzy => new cvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns cvec3.bggbg swizzling (equivalent to cvec3.zyyzy).
        /// </summary>
        public cvec5 bggbg => new cvec5(z, y, y, z, y);
        
        /// <summary>
        /// Returns cvec3.zyyzz swizzling.
        /// </summary>
        public cvec5 zyyzz => new cvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns cvec3.bggbb swizzling (equivalent to cvec3.zyyzz).
        /// </summary>
        public cvec5 bggbb => new cvec5(z, y, y, z, z);
        
        /// <summary>
        /// Returns cvec3.zyz swizzling.
        /// </summary>
        public cvec3 zyz => new cvec3(z, y, z);
        
        /// <summary>
        /// Returns cvec3.bgb swizzling (equivalent to cvec3.zyz).
        /// </summary>
        public cvec3 bgb => new cvec3(z, y, z);
        
        /// <summary>
        /// Returns cvec3.zyzx swizzling.
        /// </summary>
        public cvec4 zyzx => new cvec4(z, y, z, x);
        
        /// <summary>
        /// Returns cvec3.bgbr swizzling (equivalent to cvec3.zyzx).
        /// </summary>
        public cvec4 bgbr => new cvec4(z, y, z, x);
        
        /// <summary>
        /// Returns cvec3.zyzxx swizzling.
        /// </summary>
        public cvec5 zyzxx => new cvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns cvec3.bgbrr swizzling (equivalent to cvec3.zyzxx).
        /// </summary>
        public cvec5 bgbrr => new cvec5(z, y, z, x, x);
        
        /// <summary>
        /// Returns cvec3.zyzxy swizzling.
        /// </summary>
        public cvec5 zyzxy => new cvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns cvec3.bgbrg swizzling (equivalent to cvec3.zyzxy).
        /// </summary>
        public cvec5 bgbrg => new cvec5(z, y, z, x, y);
        
        /// <summary>
        /// Returns cvec3.zyzxz swizzling.
        /// </summary>
        public cvec5 zyzxz => new cvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns cvec3.bgbrb swizzling (equivalent to cvec3.zyzxz).
        /// </summary>
        public cvec5 bgbrb => new cvec5(z, y, z, x, z);
        
        /// <summary>
        /// Returns cvec3.zyzy swizzling.
        /// </summary>
        public cvec4 zyzy => new cvec4(z, y, z, y);
        
        /// <summary>
        /// Returns cvec3.bgbg swizzling (equivalent to cvec3.zyzy).
        /// </summary>
        public cvec4 bgbg => new cvec4(z, y, z, y);
        
        /// <summary>
        /// Returns cvec3.zyzyx swizzling.
        /// </summary>
        public cvec5 zyzyx => new cvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns cvec3.bgbgr swizzling (equivalent to cvec3.zyzyx).
        /// </summary>
        public cvec5 bgbgr => new cvec5(z, y, z, y, x);
        
        /// <summary>
        /// Returns cvec3.zyzyy swizzling.
        /// </summary>
        public cvec5 zyzyy => new cvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns cvec3.bgbgg swizzling (equivalent to cvec3.zyzyy).
        /// </summary>
        public cvec5 bgbgg => new cvec5(z, y, z, y, y);
        
        /// <summary>
        /// Returns cvec3.zyzyz swizzling.
        /// </summary>
        public cvec5 zyzyz => new cvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns cvec3.bgbgb swizzling (equivalent to cvec3.zyzyz).
        /// </summary>
        public cvec5 bgbgb => new cvec5(z, y, z, y, z);
        
        /// <summary>
        /// Returns cvec3.zyzz swizzling.
        /// </summary>
        public cvec4 zyzz => new cvec4(z, y, z, z);
        
        /// <summary>
        /// Returns cvec3.bgbb swizzling (equivalent to cvec3.zyzz).
        /// </summary>
        public cvec4 bgbb => new cvec4(z, y, z, z);
        
        /// <summary>
        /// Returns cvec3.zyzzx swizzling.
        /// </summary>
        public cvec5 zyzzx => new cvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns cvec3.bgbbr swizzling (equivalent to cvec3.zyzzx).
        /// </summary>
        public cvec5 bgbbr => new cvec5(z, y, z, z, x);
        
        /// <summary>
        /// Returns cvec3.zyzzy swizzling.
        /// </summary>
        public cvec5 zyzzy => new cvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns cvec3.bgbbg swizzling (equivalent to cvec3.zyzzy).
        /// </summary>
        public cvec5 bgbbg => new cvec5(z, y, z, z, y);
        
        /// <summary>
        /// Returns cvec3.zyzzz swizzling.
        /// </summary>
        public cvec5 zyzzz => new cvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns cvec3.bgbbb swizzling (equivalent to cvec3.zyzzz).
        /// </summary>
        public cvec5 bgbbb => new cvec5(z, y, z, z, z);
        
        /// <summary>
        /// Returns cvec3.zz swizzling.
        /// </summary>
        public cvec2 zz => new cvec2(z, z);
        
        /// <summary>
        /// Returns cvec3.bb swizzling (equivalent to cvec3.zz).
        /// </summary>
        public cvec2 bb => new cvec2(z, z);
        
        /// <summary>
        /// Returns cvec3.zzx swizzling.
        /// </summary>
        public cvec3 zzx => new cvec3(z, z, x);
        
        /// <summary>
        /// Returns cvec3.bbr swizzling (equivalent to cvec3.zzx).
        /// </summary>
        public cvec3 bbr => new cvec3(z, z, x);
        
        /// <summary>
        /// Returns cvec3.zzxx swizzling.
        /// </summary>
        public cvec4 zzxx => new cvec4(z, z, x, x);
        
        /// <summary>
        /// Returns cvec3.bbrr swizzling (equivalent to cvec3.zzxx).
        /// </summary>
        public cvec4 bbrr => new cvec4(z, z, x, x);
        
        /// <summary>
        /// Returns cvec3.zzxxx swizzling.
        /// </summary>
        public cvec5 zzxxx => new cvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns cvec3.bbrrr swizzling (equivalent to cvec3.zzxxx).
        /// </summary>
        public cvec5 bbrrr => new cvec5(z, z, x, x, x);
        
        /// <summary>
        /// Returns cvec3.zzxxy swizzling.
        /// </summary>
        public cvec5 zzxxy => new cvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns cvec3.bbrrg swizzling (equivalent to cvec3.zzxxy).
        /// </summary>
        public cvec5 bbrrg => new cvec5(z, z, x, x, y);
        
        /// <summary>
        /// Returns cvec3.zzxxz swizzling.
        /// </summary>
        public cvec5 zzxxz => new cvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns cvec3.bbrrb swizzling (equivalent to cvec3.zzxxz).
        /// </summary>
        public cvec5 bbrrb => new cvec5(z, z, x, x, z);
        
        /// <summary>
        /// Returns cvec3.zzxy swizzling.
        /// </summary>
        public cvec4 zzxy => new cvec4(z, z, x, y);
        
        /// <summary>
        /// Returns cvec3.bbrg swizzling (equivalent to cvec3.zzxy).
        /// </summary>
        public cvec4 bbrg => new cvec4(z, z, x, y);
        
        /// <summary>
        /// Returns cvec3.zzxyx swizzling.
        /// </summary>
        public cvec5 zzxyx => new cvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns cvec3.bbrgr swizzling (equivalent to cvec3.zzxyx).
        /// </summary>
        public cvec5 bbrgr => new cvec5(z, z, x, y, x);
        
        /// <summary>
        /// Returns cvec3.zzxyy swizzling.
        /// </summary>
        public cvec5 zzxyy => new cvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns cvec3.bbrgg swizzling (equivalent to cvec3.zzxyy).
        /// </summary>
        public cvec5 bbrgg => new cvec5(z, z, x, y, y);
        
        /// <summary>
        /// Returns cvec3.zzxyz swizzling.
        /// </summary>
        public cvec5 zzxyz => new cvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns cvec3.bbrgb swizzling (equivalent to cvec3.zzxyz).
        /// </summary>
        public cvec5 bbrgb => new cvec5(z, z, x, y, z);
        
        /// <summary>
        /// Returns cvec3.zzxz swizzling.
        /// </summary>
        public cvec4 zzxz => new cvec4(z, z, x, z);
        
        /// <summary>
        /// Returns cvec3.bbrb swizzling (equivalent to cvec3.zzxz).
        /// </summary>
        public cvec4 bbrb => new cvec4(z, z, x, z);
        
        /// <summary>
        /// Returns cvec3.zzxzx swizzling.
        /// </summary>
        public cvec5 zzxzx => new cvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns cvec3.bbrbr swizzling (equivalent to cvec3.zzxzx).
        /// </summary>
        public cvec5 bbrbr => new cvec5(z, z, x, z, x);
        
        /// <summary>
        /// Returns cvec3.zzxzy swizzling.
        /// </summary>
        public cvec5 zzxzy => new cvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns cvec3.bbrbg swizzling (equivalent to cvec3.zzxzy).
        /// </summary>
        public cvec5 bbrbg => new cvec5(z, z, x, z, y);
        
        /// <summary>
        /// Returns cvec3.zzxzz swizzling.
        /// </summary>
        public cvec5 zzxzz => new cvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns cvec3.bbrbb swizzling (equivalent to cvec3.zzxzz).
        /// </summary>
        public cvec5 bbrbb => new cvec5(z, z, x, z, z);
        
        /// <summary>
        /// Returns cvec3.zzy swizzling.
        /// </summary>
        public cvec3 zzy => new cvec3(z, z, y);
        
        /// <summary>
        /// Returns cvec3.bbg swizzling (equivalent to cvec3.zzy).
        /// </summary>
        public cvec3 bbg => new cvec3(z, z, y);
        
        /// <summary>
        /// Returns cvec3.zzyx swizzling.
        /// </summary>
        public cvec4 zzyx => new cvec4(z, z, y, x);
        
        /// <summary>
        /// Returns cvec3.bbgr swizzling (equivalent to cvec3.zzyx).
        /// </summary>
        public cvec4 bbgr => new cvec4(z, z, y, x);
        
        /// <summary>
        /// Returns cvec3.zzyxx swizzling.
        /// </summary>
        public cvec5 zzyxx => new cvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns cvec3.bbgrr swizzling (equivalent to cvec3.zzyxx).
        /// </summary>
        public cvec5 bbgrr => new cvec5(z, z, y, x, x);
        
        /// <summary>
        /// Returns cvec3.zzyxy swizzling.
        /// </summary>
        public cvec5 zzyxy => new cvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns cvec3.bbgrg swizzling (equivalent to cvec3.zzyxy).
        /// </summary>
        public cvec5 bbgrg => new cvec5(z, z, y, x, y);
        
        /// <summary>
        /// Returns cvec3.zzyxz swizzling.
        /// </summary>
        public cvec5 zzyxz => new cvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns cvec3.bbgrb swizzling (equivalent to cvec3.zzyxz).
        /// </summary>
        public cvec5 bbgrb => new cvec5(z, z, y, x, z);
        
        /// <summary>
        /// Returns cvec3.zzyy swizzling.
        /// </summary>
        public cvec4 zzyy => new cvec4(z, z, y, y);
        
        /// <summary>
        /// Returns cvec3.bbgg swizzling (equivalent to cvec3.zzyy).
        /// </summary>
        public cvec4 bbgg => new cvec4(z, z, y, y);
        
        /// <summary>
        /// Returns cvec3.zzyyx swizzling.
        /// </summary>
        public cvec5 zzyyx => new cvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns cvec3.bbggr swizzling (equivalent to cvec3.zzyyx).
        /// </summary>
        public cvec5 bbggr => new cvec5(z, z, y, y, x);
        
        /// <summary>
        /// Returns cvec3.zzyyy swizzling.
        /// </summary>
        public cvec5 zzyyy => new cvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns cvec3.bbggg swizzling (equivalent to cvec3.zzyyy).
        /// </summary>
        public cvec5 bbggg => new cvec5(z, z, y, y, y);
        
        /// <summary>
        /// Returns cvec3.zzyyz swizzling.
        /// </summary>
        public cvec5 zzyyz => new cvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns cvec3.bbggb swizzling (equivalent to cvec3.zzyyz).
        /// </summary>
        public cvec5 bbggb => new cvec5(z, z, y, y, z);
        
        /// <summary>
        /// Returns cvec3.zzyz swizzling.
        /// </summary>
        public cvec4 zzyz => new cvec4(z, z, y, z);
        
        /// <summary>
        /// Returns cvec3.bbgb swizzling (equivalent to cvec3.zzyz).
        /// </summary>
        public cvec4 bbgb => new cvec4(z, z, y, z);
        
        /// <summary>
        /// Returns cvec3.zzyzx swizzling.
        /// </summary>
        public cvec5 zzyzx => new cvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns cvec3.bbgbr swizzling (equivalent to cvec3.zzyzx).
        /// </summary>
        public cvec5 bbgbr => new cvec5(z, z, y, z, x);
        
        /// <summary>
        /// Returns cvec3.zzyzy swizzling.
        /// </summary>
        public cvec5 zzyzy => new cvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns cvec3.bbgbg swizzling (equivalent to cvec3.zzyzy).
        /// </summary>
        public cvec5 bbgbg => new cvec5(z, z, y, z, y);
        
        /// <summary>
        /// Returns cvec3.zzyzz swizzling.
        /// </summary>
        public cvec5 zzyzz => new cvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns cvec3.bbgbb swizzling (equivalent to cvec3.zzyzz).
        /// </summary>
        public cvec5 bbgbb => new cvec5(z, z, y, z, z);
        
        /// <summary>
        /// Returns cvec3.zzz swizzling.
        /// </summary>
        public cvec3 zzz => new cvec3(z, z, z);
        
        /// <summary>
        /// Returns cvec3.bbb swizzling (equivalent to cvec3.zzz).
        /// </summary>
        public cvec3 bbb => new cvec3(z, z, z);
        
        /// <summary>
        /// Returns cvec3.zzzx swizzling.
        /// </summary>
        public cvec4 zzzx => new cvec4(z, z, z, x);
        
        /// <summary>
        /// Returns cvec3.bbbr swizzling (equivalent to cvec3.zzzx).
        /// </summary>
        public cvec4 bbbr => new cvec4(z, z, z, x);
        
        /// <summary>
        /// Returns cvec3.zzzxx swizzling.
        /// </summary>
        public cvec5 zzzxx => new cvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns cvec3.bbbrr swizzling (equivalent to cvec3.zzzxx).
        /// </summary>
        public cvec5 bbbrr => new cvec5(z, z, z, x, x);
        
        /// <summary>
        /// Returns cvec3.zzzxy swizzling.
        /// </summary>
        public cvec5 zzzxy => new cvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns cvec3.bbbrg swizzling (equivalent to cvec3.zzzxy).
        /// </summary>
        public cvec5 bbbrg => new cvec5(z, z, z, x, y);
        
        /// <summary>
        /// Returns cvec3.zzzxz swizzling.
        /// </summary>
        public cvec5 zzzxz => new cvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns cvec3.bbbrb swizzling (equivalent to cvec3.zzzxz).
        /// </summary>
        public cvec5 bbbrb => new cvec5(z, z, z, x, z);
        
        /// <summary>
        /// Returns cvec3.zzzy swizzling.
        /// </summary>
        public cvec4 zzzy => new cvec4(z, z, z, y);
        
        /// <summary>
        /// Returns cvec3.bbbg swizzling (equivalent to cvec3.zzzy).
        /// </summary>
        public cvec4 bbbg => new cvec4(z, z, z, y);
        
        /// <summary>
        /// Returns cvec3.zzzyx swizzling.
        /// </summary>
        public cvec5 zzzyx => new cvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns cvec3.bbbgr swizzling (equivalent to cvec3.zzzyx).
        /// </summary>
        public cvec5 bbbgr => new cvec5(z, z, z, y, x);
        
        /// <summary>
        /// Returns cvec3.zzzyy swizzling.
        /// </summary>
        public cvec5 zzzyy => new cvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns cvec3.bbbgg swizzling (equivalent to cvec3.zzzyy).
        /// </summary>
        public cvec5 bbbgg => new cvec5(z, z, z, y, y);
        
        /// <summary>
        /// Returns cvec3.zzzyz swizzling.
        /// </summary>
        public cvec5 zzzyz => new cvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns cvec3.bbbgb swizzling (equivalent to cvec3.zzzyz).
        /// </summary>
        public cvec5 bbbgb => new cvec5(z, z, z, y, z);
        
        /// <summary>
        /// Returns cvec3.zzzz swizzling.
        /// </summary>
        public cvec4 zzzz => new cvec4(z, z, z, z);
        
        /// <summary>
        /// Returns cvec3.bbbb swizzling (equivalent to cvec3.zzzz).
        /// </summary>
        public cvec4 bbbb => new cvec4(z, z, z, z);
        
        /// <summary>
        /// Returns cvec3.zzzzx swizzling.
        /// </summary>
        public cvec5 zzzzx => new cvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns cvec3.bbbbr swizzling (equivalent to cvec3.zzzzx).
        /// </summary>
        public cvec5 bbbbr => new cvec5(z, z, z, z, x);
        
        /// <summary>
        /// Returns cvec3.zzzzy swizzling.
        /// </summary>
        public cvec5 zzzzy => new cvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns cvec3.bbbbg swizzling (equivalent to cvec3.zzzzy).
        /// </summary>
        public cvec5 bbbbg => new cvec5(z, z, z, z, y);
        
        /// <summary>
        /// Returns cvec3.zzzzz swizzling.
        /// </summary>
        public cvec5 zzzzz => new cvec5(z, z, z, z, z);
        
        /// <summary>
        /// Returns cvec3.bbbbb swizzling (equivalent to cvec3.zzzzz).
        /// </summary>
        public cvec5 bbbbb => new cvec5(z, z, z, z, z);

        #endregion

    }
}
